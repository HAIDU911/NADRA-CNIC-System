Imports System.Data
Imports System.Data.OleDb

''' <summary>
''' One record of the NADRA citizens database (the person a CNIC is issued to).
''' </summary>
Friend Class Citizen
    Public Property Cnic As String = ""
    Public Property Name As String = ""
    Public Property FatherName As String = ""
    Public Property Gender As String = ""
    Public Property DateOfBirth As DateTime
    Public Property BloodGroup As String = ""
    Public Property MaritalStatus As String = ""
    Public Property Religion As String = ""
    Public Property Nationality As String = "Pakistani"
    Public Property Education As String = ""
    Public Property Occupation As String = ""
    Public Property AreaType As String = "Urban"
    Public Property PresentAddress As String = ""
    Public Property PermanentAddress As String = ""
    Public Property City As String = ""
    Public Property Province As String = ""
    Public Property Mobile As String = ""
    Public Property Phone As String = ""
    Public Property Email As String = ""
    Public Property PhotoPath As String = ""
    Public Property OfficeName As String = ""
    Public Property IssueDate As DateTime
    Public Property ExpiryDate As DateTime
    Public Property IsVerified As Boolean
    Public Property Documents As String = ""
    Public Property Notes As String = ""
    Public Property CreatedOn As DateTime = Now
    Public Property ModifiedOn As DateTime

    Public Overrides Function ToString() As String
        Return Cnic & " - " & Name
    End Function
End Class

''' <summary>
''' CRUD (Create / Read / Update / Delete), searching, statistics and the
''' CNIC number validation with check-digit that the project adds on top of
''' the basic NADRA requirements.
''' </summary>
Friend NotInheritable Class CitizenStore

    Private Sub New()
    End Sub

    ' ------------------------------------------------------------------ CNIC helpers

    ''' <summary>Digits only, stripped of the dashes: 1234512345678</summary>
    Public Shared Function DigitsOnly(cnic As String) As String
        If cnic Is Nothing Then Return ""
        Dim sb As New System.Text.StringBuilder()
        For Each ch As Char In cnic
            If Char.IsDigit(ch) Then sb.Append(ch)
        Next
        Return sb.ToString()
    End Function

    ''' <summary>True when the 13 digit number passes the mod-10 (Luhn) check digit test.</summary>
    Public Shared Function HasValidCheckDigit(cnic As String) As Boolean
        Dim d As String = DigitsOnly(cnic)
        If d.Length <> 13 Then Return False
        Dim sum As Integer = 0
        For i As Integer = 0 To 11
            Dim value As Integer = CInt(Char.GetNumericValue(d(i)))
            If i Mod 2 = 0 Then
                value *= 2
                If value > 9 Then value -= 9
            End If
            sum += value
        Next
        Dim expected As Integer = (10 - (sum Mod 10)) Mod 10
        Return expected = CInt(Char.GetNumericValue(d(12)))
    End Function

    ''' <summary>Returns the correct 13th (check) digit for a 12 digit CNIC stem.</summary>
    Public Shared Function CheckDigitFor(base12 As String) As Char
        Dim sum As Integer = 0
        For i As Integer = 0 To 11
            Dim value As Integer = CInt(Char.GetNumericValue(base12(i)))
            If i Mod 2 = 0 Then
                value *= 2
                If value > 9 Then value -= 9
            End If
            sum += value
        Next
        Return ChrW(CInt(AscW("0"c)) + ((10 - (sum Mod 10)) Mod 10))
    End Function

    ''' <summary>Builds the canonical 00000-0000000-0 presentation of a CNIC.</summary>
    Public Shared Function FormatCnic(digits13 As String) As String
        Dim d As String = DigitsOnly(digits13)
        If d.Length <> 13 Then Return d
        Return d.Substring(0, 5) & "-" & d.Substring(5, 7) & "-" & d.Substring(12, 1)
    End Function

    ''' <summary>Full validation: 13 digits, correct shape and valid check digit.</summary>
    Public Shared Function ValidateCnic(cnic As String, ByRef message As String) As Boolean
        Dim d As String = DigitsOnly(cnic)
        If d.Length = 0 Then
            message = "CNIC number is required."
            Return False
        End If
        If d.Length <> 13 Then
            message = "A CNIC must contain exactly 13 digits (e.g. 42101-1234567-1)."
            Return False
        End If
        If d(0) = "0"c Then
            message = "The first 5 digits (region code) cannot start with 0."
            Return False
        End If
        If Not HasValidCheckDigit(d) Then
            message = "The check digit is not valid - please use the generated CNIC."
            Return False
        End If
        message = "Valid CNIC number."
        Return True
    End Function

    ''' <summary>Creates a brand new, check-digit-correct CNIC for the given region code.</summary>
    Public Shared Function GenerateCnic(regionCode As String) As String
        Dim rng As New Random()
        Dim stem As String = regionCode.PadRight(5, "0").Substring(0, 5)
        For i As Integer = 1 To 7
            stem &= ChrW(CInt(AscW("0"c)) + rng.Next(0, 10))
        Next
        Return FormatCnic(stem & CheckDigitFor(stem))
    End Function

    ' ------------------------------------------------------------------ CRUD

    Private Shared Function ReaderToCitizen(dr As OleDbDataReader) As Citizen
        Dim c As New Citizen()
        c.Cnic = CStr(ReadValue(dr, "Cnic"))
        c.Name = CStr(ReadValue(dr, "Name"))
        c.FatherName = CStr(ReadValue(dr, "FatherName"))
        c.Gender = CStr(ReadValue(dr, "Gender"))
        c.DateOfBirth = ToDate(ReadValue(dr, "DateOfBirth"))
        c.BloodGroup = CStr(ReadValue(dr, "BloodGroup"))
        c.MaritalStatus = CStr(ReadValue(dr, "MaritalStatus"))
        c.Religion = CStr(ReadValue(dr, "Religion"))
        c.Nationality = CStr(ReadValue(dr, "Nationality"))
        c.Education = CStr(ReadValue(dr, "Education"))
        c.Occupation = CStr(ReadValue(dr, "Occupation"))
        c.AreaType = CStr(ReadValue(dr, "AreaType"))
        c.PresentAddress = CStr(ReadValue(dr, "PresentAddress"))
        c.PermanentAddress = CStr(ReadValue(dr, "PermanentAddress"))
        c.City = CStr(ReadValue(dr, "City"))
        c.Province = CStr(ReadValue(dr, "Province"))
        c.Mobile = CStr(ReadValue(dr, "Mobile"))
        c.Phone = CStr(ReadValue(dr, "Phone"))
        c.Email = CStr(ReadValue(dr, "Email"))
        c.PhotoPath = CStr(ReadValue(dr, "PhotoPath"))
        c.OfficeName = CStr(ReadValue(dr, "OfficeName"))
        c.IssueDate = ToDate(ReadValue(dr, "IssueDate"))
        c.ExpiryDate = ToDate(ReadValue(dr, "ExpiryDate"))
        c.IsVerified = CBool(ReadValue(dr, "IsVerified"))
        c.Documents = CStr(ReadValue(dr, "Documents"))
        c.Notes = CStr(ReadValue(dr, "Notes"))
        c.CreatedOn = ToDate(ReadValue(dr, "CreatedOn"))
        c.ModifiedOn = ToDate(ReadValue(dr, "ModifiedOn"))
        Return c
    End Function

    Private Shared Function ReadValue(dr As OleDbDataReader, field As String) As Object
        Try
            Dim value As Object = dr(field)
            If value Is DBNull.Value Then
                Select Case field
                    Case "DateOfBirth", "IssueDate", "ExpiryDate" : Return #1/1/1900#
                    Case "IsVerified" : Return False
                    Case Else : Return ""
                End Select
            End If
            Return value
        Catch
            Return ""
        End Try
    End Function

    Private Shared Function ToDate(value As Object) As DateTime
        Try
            If TypeOf value Is DateTime Then Return CDate(value)
            If value Is Nothing OrElse value Is DBNull.Value OrElse CStr(value) = "" Then Return #1/1/1900#
            Return CDate(value)
        Catch
            Return #1/1/1900#
        End Try
    End Function

    Public Shared Function Exists(cnic As String) As Boolean
        Return Db.ScalarInt("SELECT COUNT(*) FROM Citizens WHERE Cnic = @c",
                            Db.Param("@c", DigitsOnly(cnic))) > 0
    End Function

    ''' <summary>Returns every citizen ordered by name.</summary>
    Public Shared Function GetAll() As List(Of Citizen)
        Return Search("")
    End Function

    ''' <summary>Free-text search over CNIC, name, father name, city and province.</summary>
    Public Shared Function Search(term As String) As List(Of Citizen)
        Dim list As New List(Of Citizen)()
        Dim sql As String = "SELECT * FROM Citizens"
        Dim hasTerm As Boolean = Not String.IsNullOrWhiteSpace(term)
        If hasTerm Then
            sql &= " WHERE Cnic LIKE @t OR Name LIKE @t OR FatherName LIKE @t OR City LIKE @t OR Province LIKE @t"
        End If
        sql &= " ORDER BY Name"

        Using cn As OleDbConnection = Db.OpenConnection()
            Using cmd As New OleDbCommand(sql, cn)
                If hasTerm Then cmd.Parameters.Add(Db.Param("@t", "%" & term.Trim() & "%"))
                Using dr As OleDbDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        list.Add(ReaderToCitizen(dr))
                    End While
                End Using
            End Using
        End Using
        Return list
    End Function

    Public Shared Function GetByCnic(cnic As String) As Citizen
        Const sql As String = "SELECT * FROM Citizens WHERE Cnic = @c"
        Using cn As OleDbConnection = Db.OpenConnection()
            Using cmd As New OleDbCommand(sql, cn)
                cmd.Parameters.Add(Db.Param("@c", DigitsOnly(cnic)))
                Using dr As OleDbDataReader = cmd.ExecuteReader()
                    If dr.Read() Then Return ReaderToCitizen(dr)
                End Using
            End Using
        End Using
        Return Nothing
    End Function

    ''' <summary>Inserts a new citizen. Returns Nothing on success or the error text.</summary>
    Public Shared Function Insert(c As Citizen, Optional silent As Boolean = False) As String
        Const sql As String =
            "INSERT INTO Citizens (Cnic, Name, FatherName, Gender, DateOfBirth, BloodGroup, MaritalStatus, " &
            "Religion, Nationality, Education, Occupation, AreaType, PresentAddress, PermanentAddress, City, " &
            "Province, Mobile, Phone, Email, PhotoPath, OfficeName, IssueDate, ExpiryDate, IsVerified, Documents, " &
            "Notes, CreatedOn, ModifiedOn) VALUES " &
            "(@cnic, @name, @father, @gender, @dob, @blood, @marital, @religion, @nationality, @education, " &
            "@occupation, @area, @present, @permanent, @city, @province, @mobile, @phone, @email, @photo, " &
            "@office, @issue, @expiry, @verified, @docs, @notes, @created, @modified)"

        Try
            Db.ExecuteNonQuery(sql, InsertParams(c))
            If Not silent Then
                Db.LogActivity(If(Session.Current IsNot Nothing, Session.Current.Username, "system"),
                               "CITIZEN-ADD", "Registered citizen " & c.Cnic & " (" & c.Name & ").")
            End If
            Return Nothing
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    ''' <summary>Updates an existing citizen. Returns Nothing on success or the error text.</summary>
    Public Shared Function Update(c As Citizen) As String
        Const sql As String =
            "UPDATE Citizens SET Name=@name, FatherName=@father, Gender=@gender, DateOfBirth=@dob, " &
            "BloodGroup=@blood, MaritalStatus=@marital, Religion=@religion, Nationality=@nationality, " &
            "Education=@education, Occupation=@occupation, AreaType=@area, PresentAddress=@present, " &
            "PermanentAddress=@permanent, City=@city, Province=@province, Mobile=@mobile, Phone=@phone, " &
            "Email=@email, PhotoPath=@photo, OfficeName=@office, IssueDate=@issue, ExpiryDate=@expiry, " &
            "IsVerified=@verified, Documents=@docs, Notes=@notes, ModifiedOn=@modified WHERE Cnic=@cnic"

        Try
            c.ModifiedOn = Now
            Db.ExecuteNonQuery(sql, UpdateParams(c))
            Db.LogActivity(If(Session.Current IsNot Nothing, Session.Current.Username, "system"),
                           "CITIZEN-EDIT", "Updated citizen " & c.Cnic & " (" & c.Name & ").")
            Return Nothing
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Shared Function Delete(cnic As String) As String
        Try
            Dim c As Citizen = GetByCnic(cnic)
            Db.ExecuteNonQuery("DELETE FROM Citizens WHERE Cnic = @c", Db.Param("@c", DigitsOnly(cnic)))
            Db.LogActivity(If(Session.Current IsNot Nothing, Session.Current.Username, "system"),
                           "CITIZEN-DELETE", "Deleted citizen " & DigitsOnly(cnic) &
                           If(c IsNot Nothing, " (" & c.Name & ")", "") & ".")
            Return Nothing
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    ''' <summary>
    ''' Insert parameters in the exact order the INSERT statement lists them.
    ''' Jet binds OleDb parameters by position, so order matters.
    ''' </summary>
    Private Shared Function InsertParams(c As Citizen) As OleDbParameter()
        Return {Db.Param("@cnic", DigitsOnly(c.Cnic)),
                Db.Param("@name", c.Name),
                Db.Param("@father", c.FatherName),
                Db.Param("@gender", c.Gender),
                Db.Param("@dob", c.DateOfBirth),
                Db.Param("@blood", c.BloodGroup),
                Db.Param("@marital", c.MaritalStatus),
                Db.Param("@religion", c.Religion),
                Db.Param("@nationality", c.Nationality),
                Db.Param("@education", c.Education),
                Db.Param("@occupation", c.Occupation),
                Db.Param("@area", c.AreaType),
                Db.Param("@present", c.PresentAddress),
                Db.Param("@permanent", c.PermanentAddress),
                Db.Param("@city", c.City),
                Db.Param("@province", c.Province),
                Db.Param("@mobile", c.Mobile),
                Db.Param("@phone", c.Phone),
                Db.Param("@email", c.Email),
                Db.Param("@photo", c.PhotoPath),
                Db.Param("@office", c.OfficeName),
                Db.Param("@issue", c.IssueDate),
                Db.Param("@expiry", c.ExpiryDate),
                Db.Param("@verified", c.IsVerified),
                Db.Param("@docs", c.Documents),
                Db.Param("@notes", c.Notes),
                Db.Param("@created", c.CreatedOn),
                Db.Param("@modified", c.ModifiedOn)}
    End Function

    ''' <summary>Update parameters in the exact order the UPDATE statement lists them (@cnic last).</summary>
    Private Shared Function UpdateParams(c As Citizen) As OleDbParameter()
        Return {Db.Param("@name", c.Name),
                Db.Param("@father", c.FatherName),
                Db.Param("@gender", c.Gender),
                Db.Param("@dob", c.DateOfBirth),
                Db.Param("@blood", c.BloodGroup),
                Db.Param("@marital", c.MaritalStatus),
                Db.Param("@religion", c.Religion),
                Db.Param("@nationality", c.Nationality),
                Db.Param("@education", c.Education),
                Db.Param("@occupation", c.Occupation),
                Db.Param("@area", c.AreaType),
                Db.Param("@present", c.PresentAddress),
                Db.Param("@permanent", c.PermanentAddress),
                Db.Param("@city", c.City),
                Db.Param("@province", c.Province),
                Db.Param("@mobile", c.Mobile),
                Db.Param("@phone", c.Phone),
                Db.Param("@email", c.Email),
                Db.Param("@photo", c.PhotoPath),
                Db.Param("@office", c.OfficeName),
                Db.Param("@issue", c.IssueDate),
                Db.Param("@expiry", c.ExpiryDate),
                Db.Param("@verified", c.IsVerified),
                Db.Param("@docs", c.Documents),
                Db.Param("@notes", c.Notes),
                Db.Param("@modified", c.ModifiedOn),
                Db.Param("@cnic", DigitsOnly(c.Cnic))}
    End Function

    ' ------------------------------------------------------------------ statistics

    ''' <summary>Summary figures used by the dashboard and the reports form.</summary>
    Public Shared Function GetStats() As CitizenStats
        Dim s As New CitizenStats()
        s.Total = Db.ScalarInt("SELECT COUNT(*) FROM Citizens")
        s.Male = Db.ScalarInt("SELECT COUNT(*) FROM Citizens WHERE Gender = 'Male'")
        s.Female = Db.ScalarInt("SELECT COUNT(*) FROM Citizens WHERE Gender = 'Female'")
        s.Other = Math.Max(0, s.Total - s.Male - s.Female)
        s.Verified = Db.ScalarInt("SELECT COUNT(*) FROM Citizens WHERE IsVerified = True")
        s.Pending = Math.Max(0, s.Total - s.Verified)
        Using cn As OleDbConnection = Db.OpenConnection()
            Using cmd As New OleDbCommand("SELECT COUNT(*) FROM Citizens WHERE CreatedOn >= @d", cn)
                cmd.Parameters.Add(Db.Param("@d", Date.Today))
                s.RegisteredToday = CInt(cmd.ExecuteScalar())
            End Using
        End Using
        Return s
    End Function

    ''' <summary>COUNT/GROUP BY helper used to feed the chart controls.</summary>
    Public Shared Function GroupCount(field As String) As DataTable
        Dim dt As New DataTable()
        Using cn As OleDbConnection = Db.OpenConnection()
            Using cmd As New OleDbCommand("SELECT " & field & " AS LabelName, COUNT(*) AS Cnt FROM Citizens " &
                                          "WHERE " & field & " IS NOT NULL AND " & field & " <> '' " &
                                          "GROUP BY " & field & " ORDER BY COUNT(*) DESC", cn)
                Using da As New OleDbDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

End Class

''' <summary>Simple statistics snapshot.</summary>
Friend Class CitizenStats
    Public Property Total As Integer
    Public Property Male As Integer
    Public Property Female As Integer
    Public Property Other As Integer
    Public Property Verified As Integer
    Public Property Pending As Integer
    Public Property RegisteredToday As Integer
End Class
