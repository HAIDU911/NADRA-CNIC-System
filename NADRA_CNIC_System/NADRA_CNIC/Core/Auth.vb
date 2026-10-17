Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text

''' <summary>A NADRA officer (system user) account.</summary>
Friend Class Officer
    Public Property Id As Integer
    Public Property Username As String = ""
    Public Property FullName As String = ""
    Public Property Designation As String = ""
    Public Property RoleName As String = ""
End Class

''' <summary>Holds the officer that is currently signed in.</summary>
Friend NotInheritable Class Session

    Private Sub New()
    End Sub

    Public Shared Property Current As Officer
    Public Shared Property LoginAt As DateTime

    Public Shared ReadOnly Property UserLabel As String
        Get
            If Current Is Nothing Then Return "Anonymous"
            Return Current.FullName & " (" & Current.Designation & ")"
        End Get
    End Property

End Class

''' <summary>
''' Login logic. Passwords are stored as salted SHA-256 hashes - never in plain text.
''' </summary>
Friend NotInheritable Class Auth

    Private Const Salt As String = "NADRA-CNIC-SYS-2026"

    Private Sub New()
    End Sub

    ''' <summary>Produces the salted SHA-256 (hex) representation of a password.</summary>
    Public Shared Function HashPassword(password As String) As String
        Using sha As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha.ComputeHash(Encoding.UTF8.GetBytes(Salt & password))
            Dim sb As New StringBuilder()
            For Each b As Byte In bytes
                sb.Append(b.ToString("x2"))
            Next
            Return sb.ToString()
        End Using
    End Function

    ''' <summary>Checks a user name / password pair against the Officers table.</summary>
    Public Shared Function ValidateCredentials(username As String, password As String, ByRef message As String) As Officer
        If String.IsNullOrWhiteSpace(username) Then
            message = "Please enter the user name."
            Return Nothing
        End If
        If String.IsNullOrWhiteSpace(password) Then
            message = "Please enter the password."
            Return Nothing
        End If

        Dim hash As String = HashPassword(password.Trim())
        Const sql As String = "SELECT Id, Username, FullName, Designation, RoleName FROM Officers " &
                              "WHERE Username = @u AND PasswordHash = @p AND IsActive = True"

        Using cn As OleDbConnection = Db.OpenConnection()
            Using cmd As New OleDbCommand(sql, cn)
                cmd.Parameters.Add(Db.Param("@u", username.Trim().ToLower()))
                cmd.Parameters.Add(Db.Param("@p", hash))
                Using dr As OleDbDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        Dim off As New Officer()
                        off.Id = CInt(dr("Id"))
                        off.Username = CStr(dr("Username"))
                        off.FullName = CStr(dr("FullName"))
                        off.Designation = CStr(dr("Designation"))
                        off.RoleName = CStr(dr("RoleName"))
                        Session.Current = off
                        Session.LoginAt = Now
                        message = ""
                        Db.LogActivity(off.Username, "LOGIN", "Officer signed in to the system.")
                        Return off
                    End If
                End Using
            End Using
        End Using

        message = "Invalid user name or password. Please try again."
        Db.LogActivity(username.Trim().ToLower(), "LOGIN-FAILED", "Failed sign-in attempt.")
        Return Nothing
    End Function

End Class
