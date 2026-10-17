Imports System.Windows.Forms

''' <summary>
''' Application entry point: initialises the database, shows the login form
''' and then runs the full screen MDI main window.
''' </summary>
Friend Module Startup

    <STAThread()>
    Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException)
        AddHandler Application.ThreadException, AddressOf OnThreadException
        AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf OnDomainException

        ' Create the Microsoft Access database, tables and sample data on first run
        Dim dbError As String = ""
        If Not Db.Initialise(dbError) Then
            MessageBox.Show("The NADRA CNIC System could not initialise its database." &
                            vbCrLf & vbCrLf & dbError,
                            "NADRA CNIC System - Database Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' --skip-login is a demonstration aid (used when the assignment is shown/demoed
        ' and in automated checks): it signs in with the administrator account.
        If Environment.GetCommandLineArgs().Any(Function(a As String) String.Equals(a, "--skip-login", StringComparison.OrdinalIgnoreCase)) Then
            Session.Current = New Officer() With {.Id = 1, .Username = "admin", .FullName = "Muhammad Aslam",
                                                  .Designation = "System Administrator", .RoleName = "Administrator"}
            Session.LoginAt = Now
        Else
            Using login As New frmLogin()
                If login.ShowDialog() <> DialogResult.OK Then Return
            End Using
        End If

        Application.Run(New frmMain())
    End Sub

    Private Sub OnThreadException(sender As Object, e As Threading.ThreadExceptionEventArgs)
        MessageBox.Show("Unexpected error:" & vbCrLf & e.Exception.Message,
                        "NADRA CNIC System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Sub OnDomainException(sender As Object, e As UnhandledExceptionEventArgs)
        Dim ex As Exception = TryCast(e.ExceptionObject, Exception)
        MessageBox.Show("Critical error: " & If(ex IsNot Nothing, ex.Message, "unknown"),
                        "NADRA CNIC System", MessageBoxButtons.OK, MessageBoxIcon.[Error])
    End Sub

End Module
