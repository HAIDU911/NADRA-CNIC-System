<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVisual
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picView = New System.Windows.Forms.PictureBox()
        Me.stVisual = New System.Windows.Forms.StatusStrip()
        Me.lblSrc = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblFps = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblRes = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblEngine = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.grpActions = New System.Windows.Forms.GroupBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnOpenImage = New System.Windows.Forms.Button()
        Me.btnSaveSnap = New System.Windows.Forms.Button()
        Me.btnCapture = New System.Windows.Forms.Button()
        Me.grpEffect = New System.Windows.Forms.GroupBox()
        Me.lblDetected = New System.Windows.Forms.Label()
        Me.chkFace = New System.Windows.Forms.CheckBox()
        Me.chkMirror = New System.Windows.Forms.CheckBox()
        Me.lblParamVal = New System.Windows.Forms.Label()
        Me.trkParam = New System.Windows.Forms.TrackBar()
        Me.lblParam = New System.Windows.Forms.Label()
        Me.cmbEffect = New System.Windows.Forms.ComboBox()
        Me.lblEffect = New System.Windows.Forms.Label()
        Me.grpSource = New System.Windows.Forms.GroupBox()
        Me.lblCamInfo = New System.Windows.Forms.Label()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.cmbCamera = New System.Windows.Forms.ComboBox()
        Me.lblCamera = New System.Windows.Forms.Label()
        Me.tmrFrame = New System.Windows.Forms.Timer(Me.components)
        Me.dlgOpenImage = New System.Windows.Forms.OpenFileDialog()
        Me.dlgSaveSnap = New System.Windows.Forms.SaveFileDialog()
        Me.tipVisual = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlTitle.SuspendLayout()
        CType(Me.picView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.stVisual.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        Me.grpActions.SuspendLayout()
        Me.grpEffect.SuspendLayout()
        CType(Me.trkParam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSource.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.FromArgb(1, 65, 28)
        Me.pnlTitle.Controls.Add(Me.lblState)
        Me.pnlTitle.Controls.Add(Me.lblSubtitle)
        Me.pnlTitle.Controls.Add(Me.lblTitle)
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(1340, 58)
        Me.pnlTitle.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(14, 8)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(293, 28)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "OpenCV Visual Effects Lab"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(205, 225, 212)
        Me.lblSubtitle.Location = New System.Drawing.Point(17, 36)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(493, 15)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Webcam capture, real-time image processing and Haar cascade face detection (OpenCV)"
        '
        'lblState
        '
        Me.lblState.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblState.BackColor = System.Drawing.Color.FromArgb(0, 158, 72)
        Me.lblState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblState.ForeColor = System.Drawing.Color.White
        Me.lblState.Location = New System.Drawing.Point(760, 14)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(566, 30)
        Me.lblState.TabIndex = 2
        Me.lblState.Text = "Camera stopped"
        Me.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picView
        '
        Me.picView.BackColor = System.Drawing.Color.Black
        Me.picView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picView.Location = New System.Drawing.Point(0, 58)
        Me.picView.Name = "picView"
        Me.picView.Size = New System.Drawing.Size(1040, 564)
        Me.picView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picView.TabIndex = 1
        Me.picView.TabStop = False
        '
        'stVisual
        '
        Me.stVisual.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblSrc, Me.lblFps, Me.lblRes, Me.lblEngine})
        Me.stVisual.Location = New System.Drawing.Point(0, 622)
        Me.stVisual.Name = "stVisual"
        Me.stVisual.Size = New System.Drawing.Size(1340, 22)
        Me.stVisual.TabIndex = 2
        '
        'lblSrc
        '
        Me.lblSrc.Name = "lblSrc"
        Me.lblSrc.Size = New System.Drawing.Size(420, 17)
        Me.lblSrc.Spring = True
        Me.lblSrc.Text = "Source: none"
        Me.lblSrc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFps
        '
        Me.lblFps.Name = "lblFps"
        Me.lblFps.Size = New System.Drawing.Size(110, 17)
        Me.lblFps.Text = "FPS: -"
        '
        'lblRes
        '
        Me.lblRes.Name = "lblRes"
        Me.lblRes.Size = New System.Drawing.Size(120, 17)
        Me.lblRes.Text = "Resolution: -"
        '
        'lblEngine
        '
        Me.lblEngine.Name = "lblEngine"
        Me.lblEngine.Size = New System.Drawing.Size(160, 17)
        Me.lblEngine.Text = "Engine: OpenCvSharp"
        '
        'pnlRight
        '
        Me.pnlRight.BackColor = System.Drawing.Color.White
        Me.pnlRight.Controls.Add(Me.grpActions)
        Me.pnlRight.Controls.Add(Me.grpEffect)
        Me.pnlRight.Controls.Add(Me.grpSource)
        Me.pnlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlRight.Location = New System.Drawing.Point(1040, 58)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(300, 564)
        Me.pnlRight.TabIndex = 3
        '
        'grpSource
        '
        Me.grpSource.Controls.Add(Me.lblCamInfo)
        Me.grpSource.Controls.Add(Me.btnStop)
        Me.grpSource.Controls.Add(Me.btnStart)
        Me.grpSource.Controls.Add(Me.cmbCamera)
        Me.grpSource.Controls.Add(Me.lblCamera)
        Me.grpSource.Location = New System.Drawing.Point(8, 6)
        Me.grpSource.Name = "grpSource"
        Me.grpSource.Size = New System.Drawing.Size(284, 132)
        Me.grpSource.TabIndex = 0
        Me.grpSource.TabStop = False
        Me.grpSource.Text = "Camera source"
        '
        'lblCamera
        '
        Me.lblCamera.AutoSize = True
        Me.lblCamera.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblCamera.ForeColor = System.Drawing.Color.FromArgb(28, 40, 33)
        Me.lblCamera.Location = New System.Drawing.Point(12, 20)
        Me.lblCamera.Name = "lblCamera"
        Me.lblCamera.Size = New System.Drawing.Size(108, 15)
        Me.lblCamera.TabIndex = 0
        Me.lblCamera.Text = "Camera device:"
        '
        'cmbCamera
        '
        Me.cmbCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCamera.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmbCamera.Items.AddRange(New Object() {"0 - default webcam", "1 - second camera", "2 - third camera"})
        Me.cmbCamera.Location = New System.Drawing.Point(15, 40)
        Me.cmbCamera.Name = "cmbCamera"
        Me.cmbCamera.Size = New System.Drawing.Size(254, 23)
        Me.cmbCamera.TabIndex = 1
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.FromArgb(0, 105, 62)
        Me.btnStart.FlatAppearance.BorderSize = 0
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.btnStart.ForeColor = System.Drawing.Color.White
        Me.btnStart.Location = New System.Drawing.Point(15, 70)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(120, 30)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "Start Camera"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.White
        Me.btnStop.Enabled = False
        Me.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(178, 34, 34)
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStop.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.btnStop.ForeColor = System.Drawing.Color.FromArgb(178, 34, 34)
        Me.btnStop.Location = New System.Drawing.Point(141, 70)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(128, 30)
        Me.btnStop.TabIndex = 3
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'lblCamInfo
        '
        Me.lblCamInfo.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.lblCamInfo.ForeColor = System.Drawing.Color.FromArgb(90, 110, 98)
        Me.lblCamInfo.Location = New System.Drawing.Point(12, 104)
        Me.lblCamInfo.Name = "lblCamInfo"
        Me.lblCamInfo.Size = New System.Drawing.Size(260, 22)
        Me.lblCamInfo.TabIndex = 4
        Me.lblCamInfo.Text = "No camera started yet."
        '
        'grpEffect
        '
        Me.grpEffect.Controls.Add(Me.lblDetected)
        Me.grpEffect.Controls.Add(Me.chkFace)
        Me.grpEffect.Controls.Add(Me.chkMirror)
        Me.grpEffect.Controls.Add(Me.lblParamVal)
        Me.grpEffect.Controls.Add(Me.trkParam)
        Me.grpEffect.Controls.Add(Me.lblParam)
        Me.grpEffect.Controls.Add(Me.cmbEffect)
        Me.grpEffect.Controls.Add(Me.lblEffect)
        Me.grpEffect.Location = New System.Drawing.Point(8, 144)
        Me.grpEffect.Name = "grpEffect"
        Me.grpEffect.Size = New System.Drawing.Size(284, 236)
        Me.grpEffect.TabIndex = 1
        Me.grpEffect.TabStop = False
        Me.grpEffect.Text = "Visual effect"
        '
        'lblEffect
        '
        Me.lblEffect.AutoSize = True
        Me.lblEffect.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblEffect.ForeColor = System.Drawing.Color.FromArgb(28, 40, 33)
        Me.lblEffect.Location = New System.Drawing.Point(12, 20)
        Me.lblEffect.Name = "lblEffect"
        Me.lblEffect.Size = New System.Drawing.Size(75, 15)
        Me.lblEffect.TabIndex = 0
        Me.lblEffect.Text = "Effect:"
        '
        'cmbEffect
        '
        Me.cmbEffect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEffect.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmbEffect.Location = New System.Drawing.Point(15, 40)
        Me.cmbEffect.Name = "cmbEffect"
        Me.cmbEffect.Size = New System.Drawing.Size(254, 23)
        Me.cmbEffect.TabIndex = 1
        '
        'lblParam
        '
        Me.lblParam.AutoSize = True
        Me.lblParam.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblParam.ForeColor = System.Drawing.Color.FromArgb(28, 40, 33)
        Me.lblParam.Location = New System.Drawing.Point(12, 74)
        Me.lblParam.Name = "lblParam"
        Me.lblParam.Size = New System.Drawing.Size(178, 15)
        Me.lblParam.TabIndex = 2
        Me.lblParam.Text = "Intensity / kernel / threshold"
        '
        'trkParam
        '
        Me.trkParam.Location = New System.Drawing.Point(15, 92)
        Me.trkParam.Maximum = 31
        Me.trkParam.Minimum = 1
        Me.trkParam.Name = "trkParam"
        Me.trkParam.Size = New System.Drawing.Size(210, 45)
        Me.trkParam.TabIndex = 3
        Me.trkParam.TickFrequency = 2
        Me.trkParam.Value = 7
        '
        'lblParamVal
        '
        Me.lblParamVal.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblParamVal.ForeColor = System.Drawing.Color.FromArgb(0, 105, 62)
        Me.lblParamVal.Location = New System.Drawing.Point(231, 100)
        Me.lblParamVal.Name = "lblParamVal"
        Me.lblParamVal.Size = New System.Drawing.Size(40, 24)
        Me.lblParamVal.TabIndex = 4
        Me.lblParamVal.Text = "7"
        Me.lblParamVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkMirror
        '
        Me.chkMirror.AutoSize = True
        Me.chkMirror.Checked = True
        Me.chkMirror.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMirror.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.chkMirror.Location = New System.Drawing.Point(16, 146)
        Me.chkMirror.Name = "chkMirror"
        Me.chkMirror.Size = New System.Drawing.Size(110, 19)
        Me.chkMirror.TabIndex = 5
        Me.chkMirror.Text = "Mirror preview"
        Me.chkMirror.UseVisualStyleBackColor = True
        '
        'chkFace
        '
        Me.chkFace.AutoSize = True
        Me.chkFace.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.chkFace.Location = New System.Drawing.Point(146, 146)
        Me.chkFace.Name = "chkFace"
        Me.chkFace.Size = New System.Drawing.Size(122, 19)
        Me.chkFace.TabIndex = 6
        Me.chkFace.Text = "Face detection"
        Me.chkFace.UseVisualStyleBackColor = True
        '
        'lblDetected
        '
        Me.lblDetected.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblDetected.ForeColor = System.Drawing.Color.FromArgb(90, 110, 98)
        Me.lblDetected.Location = New System.Drawing.Point(12, 172)
        Me.lblDetected.Name = "lblDetected"
        Me.lblDetected.Size = New System.Drawing.Size(260, 56)
        Me.lblDetected.TabIndex = 7
        Me.lblDetected.Text = "Haar cascade ready: " & Global.Microsoft.VisualBasic.ChrW(10) & "-"
        '
        'grpActions
        '
        Me.grpActions.Controls.Add(Me.btnReset)
        Me.grpActions.Controls.Add(Me.btnOpenImage)
        Me.grpActions.Controls.Add(Me.btnSaveSnap)
        Me.grpActions.Controls.Add(Me.btnCapture)
        Me.grpActions.Location = New System.Drawing.Point(8, 386)
        Me.grpActions.Name = "grpActions"
        Me.grpActions.Size = New System.Drawing.Size(284, 170)
        Me.grpActions.TabIndex = 2
        Me.grpActions.TabStop = False
        Me.grpActions.Text = "Capture && files"
        '
        'btnCapture
        '
        Me.btnCapture.BackColor = System.Drawing.Color.FromArgb(0, 105, 62)
        Me.btnCapture.FlatAppearance.BorderSize = 0
        Me.btnCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCapture.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCapture.ForeColor = System.Drawing.Color.White
        Me.btnCapture.Location = New System.Drawing.Point(14, 26)
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.Size = New System.Drawing.Size(256, 36)
        Me.btnCapture.TabIndex = 0
        Me.btnCapture.Text = "Capture Photo"
        Me.btnCapture.UseVisualStyleBackColor = False
        '
        'btnSaveSnap
        '
        Me.btnSaveSnap.BackColor = System.Drawing.Color.White
        Me.btnSaveSnap.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 105, 62)
        Me.btnSaveSnap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveSnap.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.btnSaveSnap.ForeColor = System.Drawing.Color.FromArgb(1, 65, 28)
        Me.btnSaveSnap.Location = New System.Drawing.Point(14, 70)
        Me.btnSaveSnap.Name = "btnSaveSnap"
        Me.btnSaveSnap.Size = New System.Drawing.Size(256, 30)
        Me.btnSaveSnap.TabIndex = 1
        Me.btnSaveSnap.Text = "Save Snapshot..."
        Me.btnSaveSnap.UseVisualStyleBackColor = False
        '
        'btnOpenImage
        '
        Me.btnOpenImage.BackColor = System.Drawing.Color.White
        Me.btnOpenImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 105, 62)
        Me.btnOpenImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenImage.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.btnOpenImage.ForeColor = System.Drawing.Color.FromArgb(1, 65, 28)
        Me.btnOpenImage.Location = New System.Drawing.Point(14, 104)
        Me.btnOpenImage.Name = "btnOpenImage"
        Me.btnOpenImage.Size = New System.Drawing.Size(256, 30)
        Me.btnOpenImage.TabIndex = 2
        Me.btnOpenImage.Text = "Open Image File..."
        Me.btnOpenImage.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.White
        Me.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(90, 110, 98)
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.btnReset.ForeColor = System.Drawing.Color.FromArgb(28, 40, 33)
        Me.btnReset.Location = New System.Drawing.Point(14, 138)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(256, 24)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset View"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'tmrFrame
        '
        Me.tmrFrame.Interval = 33
        '
        'dlgOpenImage
        '
        Me.dlgOpenImage.Filter = "Images|*.jpg;*.jpeg;*.png;*.bmp|All files|*.*"
        '
        'dlgSaveSnap
        '
        Me.dlgSaveSnap.DefaultExt = "jpg"
        Me.dlgSaveSnap.Filter = "JPEG image|*.jpg|PNG image|*.png|Bitmap|*.bmp"
        '
        'frmVisual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(238, 242, 239)
        Me.ClientSize = New System.Drawing.Size(1340, 644)
        Me.Controls.Add(Me.picView)
        Me.Controls.Add(Me.pnlRight)
        Me.Controls.Add(Me.stVisual)
        Me.Controls.Add(Me.pnlTitle)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "frmVisual"
        Me.Text = "OpenCV Visual Effects Lab"
        Me.pnlTitle.ResumeLayout(False)
        Me.pnlTitle.PerformLayout()
        CType(Me.picView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.stVisual.ResumeLayout(False)
        Me.stVisual.PerformLayout()
        Me.pnlRight.ResumeLayout(False)
        Me.grpActions.ResumeLayout(False)
        Me.grpEffect.ResumeLayout(False)
        CType(Me.trkParam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSource.ResumeLayout(False)
        Me.SuspendLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents picView As System.Windows.Forms.PictureBox
    Friend WithEvents stVisual As System.Windows.Forms.StatusStrip
    Friend WithEvents lblSrc As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblFps As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblRes As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblEngine As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents pnlRight As System.Windows.Forms.Panel
    Friend WithEvents grpSource As System.Windows.Forms.GroupBox
    Friend WithEvents lblCamera As System.Windows.Forms.Label
    Friend WithEvents cmbCamera As System.Windows.Forms.ComboBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents lblCamInfo As System.Windows.Forms.Label
    Friend WithEvents grpEffect As System.Windows.Forms.GroupBox
    Friend WithEvents lblEffect As System.Windows.Forms.Label
    Friend WithEvents cmbEffect As System.Windows.Forms.ComboBox
    Friend WithEvents lblParam As System.Windows.Forms.Label
    Friend WithEvents trkParam As System.Windows.Forms.TrackBar
    Friend WithEvents lblParamVal As System.Windows.Forms.Label
    Friend WithEvents chkMirror As System.Windows.Forms.CheckBox
    Friend WithEvents chkFace As System.Windows.Forms.CheckBox
    Friend WithEvents lblDetected As System.Windows.Forms.Label
    Friend WithEvents grpActions As System.Windows.Forms.GroupBox
    Friend WithEvents btnCapture As System.Windows.Forms.Button
    Friend WithEvents btnSaveSnap As System.Windows.Forms.Button
    Friend WithEvents btnOpenImage As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents tmrFrame As System.Windows.Forms.Timer
    Friend WithEvents dlgOpenImage As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dlgSaveSnap As System.Windows.Forms.SaveFileDialog
    Friend WithEvents tipVisual As System.Windows.Forms.ToolTip

End Class
