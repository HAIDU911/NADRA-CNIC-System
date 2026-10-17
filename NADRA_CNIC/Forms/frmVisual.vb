Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports OpenCvSharp

''' <summary>
''' OpenCV module of the assignment: a live webcam with visual effects
''' (grayscale, sepia, Canny edges, blur, sharpen, threshold, negative),
''' Haar cascade face detection, snapshot saving and citizen photo capture.
''' </summary>
Public Class frmVisual

    ''' <summary>Raised when the Capture Photo button stores a photograph.</summary>
    Public Event PhotoCaptured(path As String)

    Private _engine As VisionEngine
    Private _rawFrame As Mat          ' last original camera frame (used for capture)
    Private _stillFrame As Mat        ' image loaded from a file
    Private _captureMode As Boolean = False
    Private _frameCount As Integer
    Private _frameWatch As Stopwatch
    Private _fps As Double = 0

    ' ------------------------------------------------------------------ start-up

    ''' <summary>
    ''' Places the title bar, preview and side panel by hand. The docked layout of this
    ''' form does not re-flow when the MDI shell resizes it, so the geometry is applied
    ''' explicitly on every resize.
    ''' </summary>
    Private Sub frmVisual_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        LayoutPanels()
    End Sub

    Private Sub LayoutPanels()
        If pnlTitle Is Nothing OrElse pnlRight Is Nothing OrElse stVisual Is Nothing OrElse picView Is Nothing Then Return
        Dim w As Integer = ClientSize.Width
        Dim h As Integer = ClientSize.Height
        If w < 320 OrElse h < 240 Then Return

        pnlTitle.SetBounds(0, 0, w, pnlTitle.Height)
        stVisual.SetBounds(0, h - stVisual.Height, w, stVisual.Height)

        Dim bodyTop As Integer = pnlTitle.Height
        Dim bodyHeight As Integer = Math.Max(120, h - pnlTitle.Height - stVisual.Height)
        Dim sideWidth As Integer = Math.Min(pnlRight.Width, Math.Max(220, w \ 3))

        pnlRight.SetBounds(w - sideWidth, bodyTop, sideWidth, bodyHeight)
        picView.SetBounds(0, bodyTop, Math.Max(160, w - sideWidth), bodyHeight)
    End Sub

    Private Sub frmVisual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiTheme.StyleGroup(grpSource)
        UiTheme.StyleGroup(grpEffect)
        UiTheme.StyleGroup(grpActions)
        UiTheme.ApplyToolStripTheme(stVisual)

        _engine = New VisionEngine()
        _frameWatch = Stopwatch.StartNew()

        cmbEffect.Items.Clear()
        For Each name As String In VisionEngine.Effects
            cmbEffect.Items.Add(name)
        Next
        cmbEffect.SelectedIndex = 0

        cmbCamera.SelectedIndex = 0
        tmrFrame.Stop()
        LayoutPanels()

        If File.Exists(AppPaths.CascadeFile) Then
            lblDetected.Text = "Haar cascade: loaded" & vbCrLf &
                               "Frontal face detector available."
        Else
            lblDetected.Text = "Haar cascade file not found:" & vbCrLf & AppPaths.CascadeFile
        End If

        tipVisual.SetToolTip(btnStart, "Start streaming from the selected camera")
        tipVisual.SetToolTip(btnCapture, "Save the original frame and attach it to the citizen record")
        tipVisual.SetToolTip(trkParam, "Kernel / threshold / blur intensity for the selected effect")
        tipVisual.SetToolTip(chkFace, "Highlight faces with the OpenCV Haar cascade")
    End Sub

    Private Function EffectName() As String
        If cmbEffect.SelectedItem Is Nothing Then Return "None (original)"
        Return CStr(cmbEffect.SelectedItem)
    End Function

    ' ------------------------------------------------------------------ camera

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        StartCamera()
    End Sub

    Private Sub StartCamera()
        If _engine Is Nothing Then _engine = New VisionEngine()

        Dim index As Integer = Math.Max(0, cmbCamera.SelectedIndex)
        If _engine.StartCamera(index) Then
            btnStart.Enabled = False
            btnStop.Enabled = True
            tmrFrame.Start()
            lblState.BackColor = UiTheme.BrightGreen
            lblState.Text = "LIVE - camera " & index.ToString() & " streaming"
            lblSrc.Text = "Source: webcam #" & index.ToString()
            lblCamInfo.Text = "Camera running at " & tmrFrame.Interval.ToString() & " ms/frame."
        Else
            btnStart.Enabled = True
            btnStop.Enabled = False
            lblState.BackColor = Color.Firebrick
            lblState.Text = "Camera could not be opened"
            MessageBox.Show(Me,
                "OpenCV could not open camera device " & index.ToString() & "." & vbCrLf & vbCrLf &
                "Check that a webcam is connected, that it is not used by another program, " &
                "and that camera access is allowed in Windows privacy settings.",
                "Camera", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        StopCamera()
    End Sub

    Private Sub StopCamera()
        tmrFrame.Stop()
        If _engine IsNot Nothing Then _engine.Stop()
        btnStart.Enabled = True
        btnStop.Enabled = False
        lblState.BackColor = Color.FromArgb(90, 110, 98)
        lblState.Text = "Camera stopped"
        lblSrc.Text = "Source: none"
        lblFps.Text = "FPS: -"
        If _rawFrame IsNot Nothing Then
            _rawFrame.Dispose()
            _rawFrame = Nothing
        End If
    End Sub

    ' ------------------------------------------------------------------ live frames

    Private Sub tmrFrame_Tick(sender As Object, e As EventArgs) Handles tmrFrame.Tick
        If _engine Is Nothing Then Return

        Dim frame As Mat = _engine.ReadFrame()
        If frame Is Nothing Then Return

        Try
            ' keep an untouched copy for the Capture button
            If _rawFrame IsNot Nothing Then _rawFrame.Dispose()
            _rawFrame = frame.Clone()

            Dim processed As Mat = _engine.ApplyEffect(frame, EffectName(), trkParam.Value, chkMirror.Checked)
            Try
                If chkFace.Checked Then ApplyFaceDetection(processed)
                ShowMat(processed)
            Finally
                processed.Dispose()
            End Try

            lblRes.Text = "Resolution: " & frame.Width.ToString() & " x " & frame.Height.ToString()
            UpdateFps()
        Finally
            frame.Dispose()
        End Try
    End Sub

    Private Sub ApplyFaceDetection(frame As Mat)
        Dim count As Integer = 0
        If _engine.DetectAndDrawFaces(frame, count) Then
            lblDetected.Text = "Faces detected: " & count.ToString() & vbCrLf &
                               "Haar frontal face cascade."
        Else
            lblDetected.Text = "Haar cascade file missing:" & vbCrLf & AppPaths.CascadeFile
        End If
    End Sub

    Private Sub UpdateFps()
        _frameCount += 1
        If _frameWatch.ElapsedMilliseconds >= 700 Then
            _fps = _frameCount * 1000.0 / _frameWatch.ElapsedMilliseconds
            _frameCount = 0
            _frameWatch.Restart()
            lblFps.Text = "FPS: " & _fps.ToString("0.0")
        End If
    End Sub

    Private Sub ShowMat(m As Mat)
        Dim bmp As Bitmap = VisionEngine.ToBitmap(m)
        Dim old As Image = picView.Image
        picView.Image = bmp
        If old IsNot Nothing Then old.Dispose()
    End Sub

    ' ------------------------------------------------------------------ still images

    Private Sub btnOpenImage_Click(sender As Object, e As EventArgs) Handles btnOpenImage.Click
        If dlgOpenImage.ShowDialog(Me) <> DialogResult.OK Then Return
        StopCamera()
        Try
            If _stillFrame IsNot Nothing Then _stillFrame.Dispose()
            _stillFrame = VisionEngine.LoadImageFile(dlgOpenImage.FileName)
            If _stillFrame Is Nothing OrElse _stillFrame.Empty() Then
                MessageBox.Show(Me, "The selected file could not be read as an image.",
                                "Image", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            lblSrc.Text = "Source: " & Path.GetFileName(dlgOpenImage.FileName)
            lblState.BackColor = UiTheme.Gold
            lblState.Text = "Still image loaded - effects update live"
            RenderStill()
        Catch ex As Exception
            MessageBox.Show(Me, "Could not open the image: " & ex.Message, "Image",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RenderStill()
        If _stillFrame Is Nothing OrElse _engine Is Nothing Then Return
        Dim processed As Mat = _engine.ApplyEffect(_stillFrame, EffectName(), trkParam.Value, chkMirror.Checked)
        Try
            If chkFace.Checked Then ApplyFaceDetection(processed)
            ShowMat(processed)
            lblRes.Text = "Resolution: " & processed.Width.ToString() & " x " & processed.Height.ToString()
        Finally
            processed.Dispose()
        End Try
    End Sub

    ' ------------------------------------------------------------------ effect controls

    Private Sub cmbEffect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEffect.SelectedIndexChanged
        If Not tmrFrame.Enabled Then RenderStill()
    End Sub

    Private Sub trkParam_Scroll(sender As Object, e As EventArgs) Handles trkParam.Scroll
        lblParamVal.Text = trkParam.Value.ToString()
        If Not tmrFrame.Enabled Then RenderStill()
    End Sub

    Private Sub trkParam_ValueChanged(sender As Object, e As EventArgs) Handles trkParam.ValueChanged
        lblParamVal.Text = trkParam.Value.ToString()
    End Sub

    Private Sub chkMirror_CheckedChanged(sender As Object, e As EventArgs) Handles chkMirror.CheckedChanged
        If Not tmrFrame.Enabled Then RenderStill()
    End Sub

    Private Sub chkFace_CheckedChanged(sender As Object, e As EventArgs) Handles chkFace.CheckedChanged
        If Not tmrFrame.Enabled Then RenderStill()
    End Sub

    ' ------------------------------------------------------------------ capturing

    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click
        If _rawFrame Is Nothing Then
            MessageBox.Show(Me, "Start the camera first so a frame can be captured.",
                            "Capture", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            Dim fileName As String = "capture_" & Format(Now, "yyyyMMdd_HHmmss") & ".jpg"
            Dim target As String = Path.Combine(AppPaths.PhotosFolder, fileName)
            VisionEngine.SaveFrame(_rawFrame, target)

            lblState.BackColor = UiTheme.BrightGreen
            lblState.Text = "Photo captured and attached: " & fileName
            RaiseEvent PhotoCaptured(target)

            MessageBox.Show(Me, "Photograph saved to:" & vbCrLf & target,
                            "Photo Captured", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(Me, "Capture failed: " & ex.Message, "Capture",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>Called from the citizen window: prepares the lab for photo capture.</summary>
    Public Sub FocusCaptureMode()
        _captureMode = True
        If Not tmrFrame.Enabled Then StartCamera()
        lblState.BackColor = UiTheme.Gold
        lblState.Text = "CAPTURE MODE - compose the photo, then press Capture Photo"
        Activate()
    End Sub

    Private Sub btnSaveSnap_Click(sender As Object, e As EventArgs) Handles btnSaveSnap.Click
        If picView.Image Is Nothing Then
            MessageBox.Show(Me, "Nothing to save yet - start the camera or open an image.",
                            "Snapshot", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        dlgSaveSnap.FileName = "nadra_snapshot_" & Format(Now, "yyyyMMdd_HHmmss") & ".jpg"
        If dlgSaveSnap.ShowDialog(Me) <> DialogResult.OK Then Return
        Try
            Using copy As New Bitmap(picView.Image)
                copy.Save(dlgSaveSnap.FileName)
            End Using
            MessageBox.Show(Me, "Snapshot saved:" & vbCrLf & dlgSaveSnap.FileName,
                            "Snapshot", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(Me, "Could not save the snapshot: " & ex.Message, "Snapshot",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        StopCamera()
        If _stillFrame IsNot Nothing Then
            _stillFrame.Dispose()
            _stillFrame = Nothing
        End If
        If picView.Image IsNot Nothing Then
            Dim old As Image = picView.Image
            picView.Image = Nothing
            old.Dispose()
        End If
        lblState.Text = "Camera stopped"
        lblState.BackColor = Color.FromArgb(90, 110, 98)
        lblDetected.Text = "Haar cascade ready: " & vbCrLf & "-"
        lblRes.Text = "Resolution: -"
    End Sub

    ' ------------------------------------------------------------------ cleanup

    Private Sub frmVisual_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        tmrFrame.Stop()
        If _rawFrame IsNot Nothing Then
            _rawFrame.Dispose()
            _rawFrame = Nothing
        End If
        If _stillFrame IsNot Nothing Then
            _stillFrame.Dispose()
            _stillFrame = Nothing
        End If
        If _engine IsNot Nothing Then
            _engine.Dispose()
            _engine = Nothing
        End If
    End Sub

End Class
