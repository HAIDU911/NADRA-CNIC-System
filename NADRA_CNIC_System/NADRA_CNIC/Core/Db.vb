Imports System.Data
Imports System.Data.OleDb
Imports System.IO

''' <summary>
''' Microsoft Access data layer.
''' The database file is created automatically on the first run (no manual setup),
''' the schema is created with DDL statements and two officer accounts plus a set of
''' sample citizens are seeded so the application is immediately usable.
''' Works with the ACE (Office) or the Jet (built into Windows) OLE DB provider.
''' </summary>
Friend NotInheritable Class Db

    Private Sub New()
    End Sub

    Private Shared _provider As String = Nothing
    Private Shared _connectionString As String = Nothing

    ''' <summary>OLE DB provider actually in use, e.g. Microsoft.Jet.OLEDB.4.0</summary>
    Public Shared ReadOnly Property ProviderName As String
        Get
            Return If(_provider, "(not initialised)")
        End Get
    End Property

    Public Shared ReadOnly Property DatabasePath As String
        Get
            Return AppPaths.DatabaseFile
        End Get
    End Property

    ' ------------------------------------------------------------------ initialisation

    ''' <summary>Probes the installed OLE DB providers, creates the file, schema and seed data.</summary>
    Public Shared Function Initialise(ByRef errorText As String) As Boolean
        AppPaths.EnsureFolders()

        ' the .mdb file has to exist before the first OLE DB connection can be opened
        Dim createError As String = ""
        If Not EnsureDatabaseFile(createError) Then
            errorText = "The Microsoft Access database could not be created." & vbCrLf & vbCrLf & createError &
                        vbCrLf & vbCrLf &
                        "Please install the 32-bit ''Microsoft Access Database Engine'' (or 32-bit Microsoft Office) " &
                        "and start the program again. The built-in Jet provider (Microsoft.Jet.OLEDB.4.0) needs " &
                        "the ADOX component to create a new database file."
            Return False
        End If

        Dim candidates As String() = {
            "Microsoft.ACE.OLEDB.16.0",
            "Microsoft.ACE.OLEDB.12.0",
            "Microsoft.Jet.OLEDB.4.0"
        }

        Dim lastError As String = ""
        For Each cand As String In candidates
            If TryProvider(cand, lastError) Then
                Exit For
            End If
        Next

        If _provider Is Nothing Then
            errorText = "No Microsoft Access database provider was found on this computer." & vbCrLf & vbCrLf &
                        "Install either Microsoft Office / Access Database Engine (ACE) " &
                        "or use the 32-bit (x86) build so the built-in Jet provider can be used." &
                        vbCrLf & vbCrLf & "Technical detail: " & lastError
            Return False
        End If

        If Not CreateSchema(errorText) Then Return False
        SeedData()
        errorText = ""
        Return True
    End Function

    ''' <summary>
    ''' Creates an empty Access database file when it does not exist yet.
    ''' ADOX (Microsoft ADO Extensions) is used because Jet cannot create a file by itself.
    ''' </summary>
    Private Shared Function EnsureDatabaseFile(ByRef lastError As String) As Boolean
        If File.Exists(AppPaths.DatabaseFile) Then Return True

        Try
            Dim catalog As Object = Interaction.CreateObject("ADOX.Catalog")
            catalog.Create("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & AppPaths.DatabaseFile)
            Return File.Exists(AppPaths.DatabaseFile)
        Catch ex As Exception
            lastError = "ADOX / Jet could not create the database file: " & ex.Message
        End Try

        ' second chance: some ACE builds create the file on first connection
        For Each candidate As String In {"Microsoft.ACE.OLEDB.16.0", "Microsoft.ACE.OLEDB.12.0"}
            Try
                Using cn As New OleDbConnection(BuildConnString(candidate))
                    cn.Open()
                End Using
                If File.Exists(AppPaths.DatabaseFile) Then Return True
            Catch
            End Try
        Next

        Return False
    End Function

    Private Shared Function BuildConnString(provider As String) As String
        Return "Provider=" & provider & ";Data Source=" & AppPaths.DatabaseFile &
               ";Persist Security Info=False;"
    End Function

    Private Shared Function TryProvider(provider As String, ByRef lastError As String) As Boolean
        Try
            Using cn As New OleDbConnection(BuildConnString(provider))
                cn.Open()   ' Jet/ACE create an empty .mdb file when it does not exist yet
            End Using
            _provider = provider
            _connectionString = BuildConnString(provider)
            Return True
        Catch ex As Exception
            lastError = provider & " -> " & ex.Message
            Return False
        End Try
    End Function

    ''' <summary>Opens a new connection with the provider chosen during start-up.</summary>
    Public Shared Function OpenConnection() As OleDbConnection
        If _connectionString Is Nothing Then
            Throw New InvalidOperationException("The database has not been initialised yet.")
        End If
        Dim cn As New OleDbConnection(_connectionString)
        cn.Open()
        Return cn
    End Function

    ' ------------------------------------------------------------------ schema

    Private Shared Function CreateSchema(ByRef errorText As String) As Boolean
        Dim statements As String() = {
            "CREATE TABLE Officers (" & _
                "Id COUNTER CONSTRAINT PK_Officers PRIMARY KEY, " & _
                "Username TEXT(50) NOT NULL, " & _
                "PasswordHash TEXT(128) NOT NULL, " & _
                "FullName TEXT(100) NOT NULL, " & _
                "Designation TEXT(80), " & _
                "RoleName TEXT(40), " & _
                "IsActive YESNO NOT NULL, " & _
                "CreatedOn DATETIME NOT NULL)",
            "CREATE TABLE Citizens (" & _
                "Cnic TEXT(13) NOT NULL CONSTRAINT PK_Citizens PRIMARY KEY, " & _
                "Name TEXT(100) NOT NULL, " & _
                "FatherName TEXT(100), " & _
                "Gender TEXT(10), " & _
                "DateOfBirth DATETIME, " & _
                "BloodGroup TEXT(5), " & _
                "MaritalStatus TEXT(20), " & _
                "Religion TEXT(30), " & _
                "Nationality TEXT(30), " & _
                "Education TEXT(50), " & _
                "Occupation TEXT(50), " & _
                "AreaType TEXT(20), " & _
                "PresentAddress MEMO, " & _
                "PermanentAddress MEMO, " & _
                "City TEXT(60), " & _
                "Province TEXT(40), " & _
                "Mobile TEXT(20), " & _
                "Phone TEXT(20), " & _
                "Email TEXT(80), " & _
                "PhotoPath MEMO, " & _
                "OfficeName TEXT(90), " & _
                "IssueDate DATETIME, " & _
                "ExpiryDate DATETIME, " & _
                "IsVerified YESNO NOT NULL, " & _
                "Documents MEMO, " & _
                "Notes MEMO, " & _
                "CreatedOn DATETIME NOT NULL, " & _
                "ModifiedOn DATETIME)",
            "CREATE TABLE ActivityLog (" & _
                "Id COUNTER CONSTRAINT PK_ActivityLog PRIMARY KEY, " & _
                "EventTime DATETIME NOT NULL, " & _
                "Username TEXT(50), " & _
                "ActionText TEXT(60), " & _
                "Details MEMO)",
            "CREATE INDEX IX_Citizens_Name ON Citizens (Name)",
            "CREATE INDEX IX_Citizens_City ON Citizens (City)"
        }

        Try
            For Each sql As String In statements
                Dim table As String = WhichTable(sql)
                If table <> "" AndAlso TableExists(table) Then Continue For   ' schema already there (second run)

                Using cn As OleDbConnection = OpenConnection()
                    Using cmd As New OleDbCommand(sql, cn)
                        Try
                            cmd.ExecuteNonQuery()
                        Catch ex As Exception
                            ' an already existing index is harmless, anything else is a real error
                            If Not sql.TrimStart().ToUpper().StartsWith("CREATE INDEX") Then Throw
                        End Try
                    End Using
                End Using
            Next

            errorText = ""
            Return True
        Catch ex As Exception
            errorText = "Could not create the database schema: " & ex.Message
            Return False
        End Try
    End Function

    Private Shared Function WhichTable(sql As String) As String
        Dim s As String = sql.TrimStart()
        If s.ToUpper().StartsWith("CREATE TABLE") Then
            Return s.Substring("CREATE TABLE ".Length).Trim().Split({" "c, "("c})(0)
        End If
        Return ""
    End Function

    Private Shared Function TableExists(tableName As String) As Boolean
        Try
            Using cn As OleDbConnection = OpenConnection()
                Dim schema As DataTable = cn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables,
                    New Object() {Nothing, Nothing, tableName, "TABLE"})
                Return schema IsNot Nothing AndAlso schema.Rows.Count > 0
            End Using
        Catch
            Return False
        End Try
    End Function

    ' ------------------------------------------------------------------ seed data

    Private Shared Sub SeedData()
        ' --- officer accounts -------------------------------------------------
        Dim officerCount As Integer = ScalarInt("SELECT COUNT(*) FROM Officers")
        If officerCount = 0 Then
            InsertOfficer("admin", "nadra123", "Muhammad Aslam", "System Administrator", "Administrator")
            InsertOfficer("officer", "officer123", "Sana Tariq", "Verification Officer", "Officer")
        End If

        ' --- sample citizens --------------------------------------------------
        Dim citizenCount As Integer = ScalarInt("SELECT COUNT(*) FROM Citizens")
        If citizenCount > 0 Then Return

        Dim samples As New List(Of Citizen)()
        samples.Add(MakeSample("12345", "1000001", "Ali Raza", "Muhammad Raza", "Male", #5/14/1992#, "B+", "Married", "Islam", "Bachelor", "Government Employee", "House 12, Street 4, G-11/3", "House 12, Street 4, G-11/3", "Islamabad", "Islamabad Capital Territory", "0300-1234567", "051-2345678", "ali.raza@example.com", True))
        samples.Add(MakeSample("42101", "2000002", "Ayesha Siddiqui", "Abdul Siddiqui", "Female", #2/2/1996#, "O+", "Single", "Islam", "Master", "Teacher", "Flat 7-B, Clifton Block 5", "Flat 7-B, Clifton Block 5", "Karachi", "Sindh", "0321-9876543", "021-34567890", "ayesha.s@example.com", True))
        samples.Add(MakeSample("35202", "3000003", "Hassan Ahmed", "Ghulam Ahmed", "Male", #11/20/1988#, "A+", "Married", "Islam", "Master", "Software Engineer", "120-A, Model Town Link Road", "120-A, Model Town Link Road", "Lahore", "Punjab", "0333-4567890", "042-35678901", "hassan.ahmed@example.com", True))
        samples.Add(MakeSample("61101", "4000004", "Fatima Bibi", "Karim Bakhsh", "Female", #7/7/1999#, "AB-", "Single", "Islam", "Intermediate", "Student", "Mohallah Islamia, Near Bungalow No 3", "Mohallah Islamia, Near Bungalow No 3", "Quetta", "Balochistan", "0312-1122334", "081-2233445", "fatima.bibi@example.com", False))
        samples.Add(MakeSample("37305", "5000005", "Usman Ghani", "Naseem Gul", "Male", #3/18/1985#, "O-", "Divorced", "Islam", "Matric", "Transporter", "Village & PO Saidu Sharif", "Village & PO Saidu Sharif", "Swat", "Khyber Pakhtunkhwa", "0345-6677889", "0946-223344", "usman.ghani@example.com", False))
        samples.Add(MakeSample("81203", "6000006", "Maryam Masih", "Yaqoob Masih", "Female", #12/25/1994#, "B-", "Married", "Christianity", "Bachelor", "Nurse", "Street 9, Christian Colony", "Street 9, Christian Colony", "Gilgit", "Gilgit-Baltistan", "0355-9900112", "05811-22334", "maryam.masih@example.com", True))
        samples.Add(MakeSample("43301", "7000007", "Zainab Khalid", "Khalid Mehmood", "Female", #4/9/2001#, "A-", "Single", "Islam", "Intermediate", "Student", "House 45, Hyderabad Road", "House 45, Hyderabad Road", "Hyderabad", "Sindh", "0301-5566778", "022-2765432", "zainab.k@example.com", False))
        samples.Add(MakeSample("31301", "8000008", "Bilal Hussain", "Shahid Hussain", "Male", #9/30/1990#, "AB+", "Married", "Islam", "Bachelor", "Businessman", "Chungi Amar Sidhu, Near Bus Stop", "Chungi Amar Sidhu, Near Bus Stop", "Lahore", "Punjab", "0342-3344556", "042-37890123", "bilal.hussain@example.com", True))

        For Each c As Citizen In samples
            CitizenStore.Insert(c, silent:=True)
        Next

        LogActivity("system", "SEED", "Sample officer accounts and " & samples.Count.ToString() & " citizen records created.")
    End Sub

    Private Shared Sub InsertOfficer(username As String, password As String, fullName As String,
                                     designation As String, role As String)
        Const sql As String = "INSERT INTO Officers (Username, PasswordHash, FullName, Designation, RoleName, IsActive, CreatedOn) " &
                              "VALUES (@u, @p, @f, @d, @r, @active, @c)"
        Using cn As OleDbConnection = OpenConnection()
            Using cmd As New OleDbCommand(sql, cn)
                cmd.Parameters.Add(Param("@u", username.ToLower()))
                cmd.Parameters.Add(Param("@p", Auth.HashPassword(password)))
                cmd.Parameters.Add(Param("@f", fullName))
                cmd.Parameters.Add(Param("@d", designation))
                cmd.Parameters.Add(Param("@r", role))
                cmd.Parameters.Add(Param("@active", True))
                cmd.Parameters.Add(Param("@c", Now))
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Shared Function MakeSample(base12 As String, serial As String, name As String, father As String,
                                       gender As String, dob As DateTime, blood As String, marital As String,
                                       religion As String, education As String, occupation As String,
                                       present As String, permanent As String, city As String, province As String,
                                       mobile As String, phone As String, email As String,
                                       verified As Boolean) As Citizen
        Dim stem As String = base12 & serial
        Dim c As New Citizen()
        c.Cnic = CitizenStore.FormatCnic(stem & CitizenStore.CheckDigitFor(stem))
        c.Name = name
        c.FatherName = father
        c.Gender = gender
        c.DateOfBirth = dob
        c.BloodGroup = blood
        c.MaritalStatus = marital
        c.Religion = religion
        c.Nationality = "Pakistani"
        c.Education = education
        c.Occupation = occupation
        c.AreaType = "Urban"
        c.PresentAddress = present
        c.PermanentAddress = permanent
        c.City = city
        c.Province = province
        c.Mobile = mobile
        c.Phone = phone
        c.Email = email
        c.OfficeName = "NADRA Regional Office - " & city
        c.IssueDate = New DateTime(dob.Year + 18, Math.Min(dob.Month, 12), 1).AddDays(30)
        If c.IssueDate < #1/1/2010# Then c.IssueDate = #1/1/2018#
        c.ExpiryDate = c.IssueDate.AddYears(10)
        c.IsVerified = verified
        c.Documents = "Birth Certificate / B-Form"
        c.Notes = If(verified, "Verified against biometric record.", "Pending biometric verification.")
        c.CreatedOn = Now.AddDays(-New Random().Next(1, 400))
        Return c
    End Function

    ' ------------------------------------------------------------------ helpers

    ''' <summary>
    ''' Builds a strongly typed parameter. Microsoft.Jet.OLEDB.4.0 rejects several of the
    ''' data types that AddWithValue would guess (unicode strings, dates), so every
    ''' parameter in this project is created explicitly.
    ''' </summary>
    Public Shared Function Param(name As String, value As Object) As OleDbParameter
        If value Is Nothing Then value = DBNull.Value
        If TypeOf value Is String Then
            Dim text As String = CStr(value)
            If text.Length > 250 Then
                Return New OleDbParameter(name, OleDbType.LongVarChar) With {.Value = text}
            End If
            Return New OleDbParameter(name, OleDbType.VarChar, 255) With {.Value = text}
        End If
        If TypeOf value Is Boolean Then
            Return New OleDbParameter(name, OleDbType.Boolean) With {.Value = value}
        End If
        If TypeOf value Is DateTime Then
            Return New OleDbParameter(name, OleDbType.Date) With {.Value = value}
        End If
        If TypeOf value Is Integer Then
            Return New OleDbParameter(name, OleDbType.Integer) With {.Value = value}
        End If
        Return New OleDbParameter(name, value)
    End Function

    Public Shared Function ScalarInt(sql As String, ParamArray args As OleDbParameter()) As Integer
        Using cn As OleDbConnection = OpenConnection()
            Using cmd As New OleDbCommand(sql, cn)
                For Each p As OleDbParameter In args
                    cmd.Parameters.Add(p)
                Next
                Dim result As Object = cmd.ExecuteScalar()
                If result Is Nothing OrElse result Is DBNull.Value Then Return 0
                Return CInt(result)
            End Using
        End Using
    End Function

    Public Shared Function ExecuteNonQuery(sql As String, ParamArray args As OleDbParameter()) As Integer
        Using cn As OleDbConnection = OpenConnection()
            Using cmd As New OleDbCommand(sql, cn)
                For Each p As OleDbParameter In args
                    cmd.Parameters.Add(p)
                Next
                Return cmd.ExecuteNonQuery()
            End Using
        End Using
    End Function

    ''' <summary>Writes an entry into the ActivityLog (audit trail) table.</summary>
    Public Shared Sub LogActivity(userName As String, actionText As String, details As String)
        Try
            Const sql As String = "INSERT INTO ActivityLog (EventTime, Username, ActionText, Details) VALUES (@t, @u, @a, @d)"
            Using cn As OleDbConnection = OpenConnection()
                Using cmd As New OleDbCommand(sql, cn)
                    cmd.Parameters.Add(Param("@t", Now))
                    cmd.Parameters.Add(Param("@u", If(userName, "")))
                    cmd.Parameters.Add(Param("@a", If(actionText, "")))
                    cmd.Parameters.Add(Param("@d", If(details, "")))
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch
            ' audit trail must never break the main workflow
        End Try
    End Sub

    ' ------------------------------------------------------------------ maintenance

    ''' <summary>Copies the live database to the location chosen by the officer.</summary>
    Public Shared Sub BackupTo(targetFile As String)
        File.Copy(AppPaths.DatabaseFile, targetFile, True)
        LogActivity(If(Session.Current IsNot Nothing, Session.Current.Username, "system"),
                    "BACKUP", "Database backed up to " & targetFile)
    End Sub

    ''' <summary>Validates and restores a previously taken backup.</summary>
    Public Shared Function RestoreFrom(sourceFile As String, ByRef errorText As String) As Boolean
        Dim header(19) As Byte
        Using fs As FileStream = File.OpenRead(sourceFile)
            If fs.Length < 2048 Then
                errorText = "The selected file is too small to be a valid Access database."
                Return False
            End If
            fs.Read(header, 0, 20)
        End Using
        Dim marker As String = System.Text.Encoding.ASCII.GetString(header, 4, 14)
        If marker <> "Standard Jet DB" AndAlso marker <> "Standard ACE DB" Then
            errorText = "The selected file is not a Microsoft Access database."
            Return False
        End If

        File.Copy(sourceFile, AppPaths.DatabaseFile, True)
        LogActivity(If(Session.Current IsNot Nothing, Session.Current.Username, "system"),
                    "RESTORE", "Database restored from " & sourceFile)
        errorText = ""
        Return True
    End Function

    ''' <summary>Simple integrity report used by the Database menu.</summary>
    Public Shared Function IntegrityReport() As String
        Dim sb As New System.Text.StringBuilder()
        sb.AppendLine("NADRA CNIC System - Database Integrity Check")
        sb.AppendLine("-------------------------------------------")
        sb.AppendLine("File       : " & AppPaths.DatabaseFile)
        sb.AppendLine("Provider   : " & ProviderName)
        sb.AppendLine("Size       : " & New FileInfo(AppPaths.DatabaseFile).Length.ToString("N0") & " bytes")
        sb.AppendLine("Checked on : " & Now.ToString("F"))
        sb.AppendLine()
        sb.AppendLine("Citizens     : " & ScalarInt("SELECT COUNT(*) FROM Citizens").ToString())
        sb.AppendLine("Officers     : " & ScalarInt("SELECT COUNT(*) FROM Officers").ToString())
        sb.AppendLine("Activity log : " & ScalarInt("SELECT COUNT(*) FROM ActivityLog").ToString())
        sb.AppendLine()
        sb.AppendLine("Result: all tables responded successfully - database is OK.")
        LogActivity(If(Session.Current IsNot Nothing, Session.Current.Username, "system"),
                    "INTEGRITY", "Database integrity check executed.")
        Return sb.ToString()
    End Function

End Class
