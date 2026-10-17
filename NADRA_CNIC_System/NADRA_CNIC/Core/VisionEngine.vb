Imports System.Drawing
Imports OpenCvSharp
Imports OpenCvSharp.Extensions

''' <summary>
''' The OpenCV module of the application.
''' Wraps camera capture, the visual effects (grayscale, sepia, Canny edges, blur,
''' sharpen, threshold, negative) and Haar-cascade face detection.
''' </summary>
Friend NotInheritable Class VisionEngine
    Implements IDisposable

    ''' <summary>Effect names offered in the combo box of the visual lab.</summary>
    Public Shared ReadOnly Effects As String() = {
        "None (original)",
        "Grayscale",
        "Sepia Tone",
        "Canny Edges",
        "Gaussian Blur",
        "Sharpen",
        "Threshold (B/W)",
        "Negative (Invert)"
    }

    Private _capture As VideoCapture
    Private _cascade As CascadeClassifier
    Private _cameraRunning As Boolean

    ''' <summary>True while the webcam is streaming.</summary>
    Public ReadOnly Property CameraRunning As Boolean
        Get
            Return _cameraRunning
        End Get
    End Property

    ''' <summary>True when the Haar cascade file could be loaded.</summary>
    Public ReadOnly Property FaceDetectorAvailable As Boolean
        Get
            Return _cascade IsNot Nothing AndAlso Not _cascade.Empty()
        End Get
    End Property

    ' ------------------------------------------------------------------ camera

    ''' <summary>Opens the webcam with the given device index.</summary>
    Public Function StartCamera(index As Integer) As Boolean
        [Stop]()
        Try
            _capture = New VideoCapture(index, VideoCaptureAPIs.DSHOW)
            If Not _capture.IsOpened() Then
                _capture.Dispose()
                _capture = New VideoCapture(index)   ' fall back to the default API
            End If
            If Not _capture.IsOpened() Then
                _capture.Dispose()
                _capture = Nothing
                Return False
            End If
            _cameraRunning = True
            Return True
        Catch
            _cameraRunning = False
            Return False
        End Try
    End Function

    ''' <summary>Reads the next camera frame. Returns Nothing when no frame is available.</summary>
    Public Function ReadFrame() As Mat
        If _capture Is Nothing OrElse Not _cameraRunning Then Return Nothing
        Dim frame As New Mat()
        If _capture.Read(frame) AndAlso Not frame.Empty() Then
            Return frame
        End If
        frame.Dispose()
        Return Nothing
    End Function

    Public Sub [Stop]()
        _cameraRunning = False
        If _capture IsNot Nothing Then
            _capture.Dispose()
            _capture = Nothing
        End If
    End Sub

    ' ------------------------------------------------------------------ images

    ''' <summary>Loads a still image (jpg/png/bmp) from disk.</summary>
    Public Shared Function LoadImageFile(path As String) As Mat
        Return Cv2.ImRead(path, ImreadModes.Color)
    End Function

    ''' <summary>Saves a frame to disk as JPEG.</summary>
    Public Shared Sub SaveFrame(frame As Mat, path As String)
        Cv2.ImWrite(path, frame)
    End Sub

    ''' <summary>Converts a frame to a GDI+ bitmap ready for a PictureBox.</summary>
    Public Shared Function ToBitmap(frame As Mat) As Bitmap
        Return frame.ToBitmap()
    End Function

    ' ------------------------------------------------------------------ effects

    ''' <summary>
    ''' Applies the selected visual effect and returns a NEW matrix
    ''' (the source frame is never modified).
    ''' </summary>
    Public Function ApplyEffect(source As Mat, effectName As String, parameter As Integer,
                                Optional mirror As Boolean = False) As Mat
        Dim result As New Mat()
        Try
            Select Case effectName
                Case "Grayscale"
                    Dim gray As New Mat()
                    Cv2.CvtColor(source, gray, ColorConversionCodes.BGR2GRAY)
                    Cv2.CvtColor(gray, result, ColorConversionCodes.GRAY2BGR)
                    gray.Dispose()

                Case "Sepia Tone"
                    Dim kernel As New Mat(3, 3, MatType.CV_32FC1)
                    kernel.Set(0, 0, 0.272F) : kernel.Set(0, 1, 0.534F) : kernel.Set(0, 2, 0.131F)
                    kernel.Set(1, 0, 0.349F) : kernel.Set(1, 1, 0.686F) : kernel.Set(1, 2, 0.168F)
                    kernel.Set(2, 0, 0.393F) : kernel.Set(2, 1, 0.769F) : kernel.Set(2, 2, 0.189F)
                    Cv2.Filter2D(source, result, -1, kernel)
                    kernel.Dispose()

                Case "Canny Edges"
                    Dim gray As New Mat()
                    Cv2.CvtColor(source, gray, ColorConversionCodes.BGR2GRAY)
                    Dim low As Integer = Math.Max(10, parameter)
                    Dim edges As New Mat()
                    Cv2.Canny(gray, edges, low, low * 3)
                    Cv2.CvtColor(edges, result, ColorConversionCodes.GRAY2BGR)
                    edges.Dispose()
                    gray.Dispose()

                Case "Gaussian Blur"
                    Dim k As Integer = Math.Max(1, parameter)
                    If k Mod 2 = 0 Then k += 1          ' kernel size must be odd
                    Cv2.GaussianBlur(source, result, New OpenCvSharp.Size(k, k), 0)

                Case "Sharpen"
                    Dim kernel As New Mat(3, 3, MatType.CV_32FC1)
                    Dim centre As Single = CSng(8 + parameter / 10.0)
                    For r As Integer = 0 To 2
                        For c As Integer = 0 To 2
                            kernel.Set(r, c, If(r = 1 AndAlso c = 1, centre, -1.0F))
                        Next
                    Next
                    Cv2.Filter2D(source, result, -1, kernel)
                    kernel.Dispose()

                Case "Threshold (B/W)"
                    Dim gray As New Mat()
                    Cv2.CvtColor(source, gray, ColorConversionCodes.BGR2GRAY)
                    Dim level As Double = Math.Max(1, Math.Min(254, parameter))
                    Dim bw As New Mat()
                    Cv2.Threshold(gray, bw, level, 255, ThresholdTypes.Binary)
                    Cv2.CvtColor(bw, result, ColorConversionCodes.GRAY2BGR)
                    bw.Dispose()
                    gray.Dispose()

                Case "Negative (Invert)"
                    Cv2.BitwiseNot(source, result)

                Case Else
                    source.CopyTo(result)
            End Select

            If mirror Then
                Dim flipped As New Mat()
                Cv2.Flip(result, flipped, FlipMode.Y)
                result.Dispose()
                result = flipped
            End If

            Return result
        Catch
            result.Dispose()
            Dim fallback As New Mat()
            source.CopyTo(fallback)
            Return fallback
        End Try
    End Function

    ''' <summary>
    ''' Runs the Haar cascade face detector on the frame and draws green boxes
    ''' with a label around every face that is found. Returns the number of faces.
    ''' </summary>
    Public Function DetectAndDrawFaces(frame As Mat, ByRef faceCount As Integer) As Boolean
        faceCount = 0
        If _cascade Is Nothing Then
            _cascade = New CascadeClassifier(AppPaths.CascadeFile)
            If _cascade.Empty() Then
                _cascade.Dispose()
                _cascade = Nothing
                Return False
            End If
        End If

        Using gray As New Mat()
            If frame.Channels() = 1 Then
                frame.CopyTo(gray)
            Else
                Cv2.CvtColor(frame, gray, ColorConversionCodes.BGR2GRAY)
            End If
            Cv2.EqualizeHist(gray, gray)
            Dim faces() As Rect = _cascade.DetectMultiScale(gray, 1.1, 5, 0, New OpenCvSharp.Size(80, 80))
            faceCount = faces.Length
            For i As Integer = 0 To faces.Length - 1
                Cv2.Rectangle(frame, faces(i), New Scalar(0, 220, 60), 2)
                Dim label As String = "FACE " & (i + 1).ToString()
                Dim org As New OpenCvSharp.Point(faces(i).X + 4, Math.Max(16, faces(i).Y - 8))
                Cv2.PutText(frame, label, org, HersheyFonts.HersheySimplex, 0.6,
                            New Scalar(0, 255, 120), 2, LineTypes.AntiAlias)
            Next
        End Using
        Return True
    End Function

    ' ------------------------------------------------------------------ dispose

    Public Sub Dispose() Implements IDisposable.Dispose
        [Stop]()
        If _cascade IsNot Nothing Then
            _cascade.Dispose()
            _cascade = Nothing
        End If
    End Sub

End Class
