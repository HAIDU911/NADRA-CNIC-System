Imports System
Imports System.Collections.Generic
Imports System.IO

Module Program

    Private _failures As Integer = 0

    Private Sub Check(label As String, ok As Boolean, Optional detail As String = "")
        Console.WriteLine((If(ok, "[ OK ]   ", "[FAIL]   ")) & label & If(detail = "", "", "  " & detail))
        If Not ok Then _failures += 1
    End Sub

    Sub Main()
        Console.WriteLine("==== NADRA CNIC System - headless self test ====")

        ' ---------------------------------------------------------- database
        AppPaths.EnsureFolders()
        Dim errorText As String = ""
        Check("Db.Initialise (creates .mdb, schema, seed data)", Db.Initialise(errorText), errorText)
        Console.WriteLine("         provider : " & Db.ProviderName)
        Console.WriteLine("         db file  : " & AppPaths.DatabaseFile)
        Check("database file exists", File.Exists(AppPaths.DatabaseFile))

        Dim stats As CitizenStats = CitizenStore.GetStats()
        Console.WriteLine("         citizens : " & stats.Total.ToString() & " (male " & stats.Male.ToString() &
                          ", female " & stats.Female.ToString() & ", verified " & stats.Verified.ToString() & ")")
        Check("seed data present", stats.Total >= 8)

        Dim badCheckDigits As Integer = 0
        Dim loaded As List(Of Citizen) = CitizenStore.Search("")
        For Each c As Citizen In loaded
            If Not CitizenStore.HasValidCheckDigit(c.Cnic) Then badCheckDigits += 1
        Next
        Check("every stored CNIC passes the check digit test", badCheckDigits = 0, badCheckDigits.ToString() & " invalid")

        ' CNIC validation helpers
        Check("HasValidCheckDigit rejects a wrong check digit", Not CitizenStore.HasValidCheckDigit("3520212345678"))
        Check("FormatCnic produces 00000-0000000-0", CitizenStore.FormatCnic("3520212345672") = "35202-1234567-2")
        Check("GenerateCnic produces a valid number", CitizenStore.HasValidCheckDigit(CitizenStore.GenerateCnic("42101")))

        ' ---------------------------------------------------------- CRUD round trip
        Dim t As New Citizen()
        t.Cnic = CitizenStore.GenerateCnic("61101")
        t.Name = "Self Test Citizen"
        t.FatherName = "Test Father"
        t.Gender = "Male"
        t.DateOfBirth = #1/1/1990#
        t.City = "Quetta"
        t.Province = "Balochistan"
        t.Mobile = "0300-1234567"
        t.OfficeName = "NADRA Regional Office - Quetta"
        t.CreatedOn = Now

        Check("INSERT citizen", CitizenStore.Insert(t) Is Nothing)
        Dim afterInsert As CitizenStats = CitizenStore.GetStats()
        Check("row count increased", afterInsert.Total = stats.Total + 1)
        t.City = "Islamabad"
        Check("UPDATE citizen", CitizenStore.Update(t) Is Nothing)
        Check("SELECT citizen by CNIC (update visible)", CitizenStore.GetByCnic(t.Cnic).City = "Islamabad")
        Check("free text search finds the record", CitizenStore.Search("Self Test").Count = 1)
        Check("search by city finds the record", CitizenStore.Search("Islamabad").Count >= 1)
        Check("DELETE citizen", CitizenStore.Delete(t.Cnic) Is Nothing)
        Check("row count restored", CitizenStore.GetStats().Total = stats.Total)

        ' ---------------------------------------------------------- officers / login
        Dim loginMessage As String = ""
        Check("officer login admin / nadra123", Auth.ValidateCredentials("admin", "nadra123", loginMessage) IsNot Nothing)
        Check("officer login officer / officer123", Auth.ValidateCredentials("officer", "officer123", loginMessage) IsNot Nothing)
        Check("wrong password rejected", Auth.ValidateCredentials("admin", "wrong", loginMessage) Is Nothing)
        Check("password is not stored as plain text", File.ReadAllText(AppPaths.DatabaseFile).IndexOf("nadra123") < 0)

        ' ---------------------------------------------------------- audit log + backup
        Check("backup copies the database", BackupRoundTrip())
        Check("integrity report runs", Db.IntegrityReport().IndexOf("database is OK") >= 0)

        ' ---------------------------------------------------------- OpenCV
        RunOpenCvTests()

        Console.WriteLine("==== finished, failures: " & _failures.ToString() & " ====")
        Environment.ExitCode = _failures
    End Sub

    Private Function BackupRoundTrip() As Boolean
        Dim target As String = Path.Combine(AppPaths.BackupFolder, "selftest_backup.mdb")
        Db.BackupTo(target)
        Return File.Exists(target)
    End Function

    Private Sub RunOpenCvTests()
        Console.WriteLine("---- OpenCV (OpenCvSharp) ----")
        Try
            Using frame As New OpenCvSharp.Mat(480, 640, OpenCvSharp.MatType.CV_8UC3, New OpenCvSharp.Scalar(40, 150, 90))
                Check("native OpenCvSharpExtern loaded (Mat created)", frame.Width = 640 AndAlso frame.Height = 480)

                Using engine As New VisionEngine()
                    For Each effect As String In VisionEngine.Effects
                        Using output As OpenCvSharp.Mat = engine.ApplyEffect(frame, effect, 9, True)
                            Check("effect '" & effect & "'", output IsNot Nothing AndAlso Not output.Empty(),
                                  output.Width.ToString() & "x" & output.Height.ToString())
                        End Using
                    Next

                    Check("haar cascade file deployed", File.Exists(AppPaths.CascadeFile))
                    Dim faceCount As Integer = 0
                    Dim ran As Boolean = engine.DetectAndDrawFaces(frame, faceCount)
                    Check("face detection executed", ran, "detections=" & faceCount.ToString())

                    Dim snap As String = Path.Combine(AppPaths.PhotosFolder, "selftest_snapshot.jpg")
                    VisionEngine.SaveFrame(frame, snap)
                    Check("JPEG written to photos folder", File.Exists(snap) AndAlso New FileInfo(snap).Length > 1000)

                    Using bmp As Drawing.Bitmap = VisionEngine.ToBitmap(frame)
                        Check("Mat -> Bitmap conversion", bmp.Width = 640 AndAlso bmp.Height = 480)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Check("OpenCV pipeline", False, ex.GetType().Name & ": " & ex.Message)
        End Try
    End Sub

End Module
