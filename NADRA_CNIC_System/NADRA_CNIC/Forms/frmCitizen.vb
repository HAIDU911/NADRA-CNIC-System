Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms

''' <summary>
''' Citizen registration / records window.
''' Tabbed data entry (personal, address, OpenCV photograph, documents),
''' manual CNIC check-digit validation with ErrorProvider, save / update /
''' delete, a BindingNavigator + DataGridView bound to a BindingSource and
''' the printed NADRA style identity card (PrintPreviewDialog).
''' </summary>
Public Class frmCitizen

    Private _mode As String = "view"
    Private _photoPath As String = ""
    Private _loading As Boolean = False
    Private _filter As String = ""
    Private _currentCitizen As Citizen = Nothing

    ' ------------------------------------------------------------------ start-up

    Private Sub frmCitizen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiTheme.StyleGrid(gridCitizen)
        UiTheme.ApplyToolStripTheme(bindingNavigator1)

        For Each page As TabPage In tabMain.TabPages
            For Each ctl As Control In page.Controls
                If TypeOf ctl Is GroupBox Then UiTheme.StyleGroup(DirectCast(ctl, GroupBox))
            Next
        Next

        BuildGridColumns()
        gridCitizen.DataSource = bsCitizens
        PopulateCombos()

        chkDocs.Items.Clear()
        For Each docName As String In New String() {"Birth Certificate / B-Form", "Previous CNIC",
                                                     "Father / Guardian CNIC", "Domicile Certificate",
                                                     "Passport (if any)", "Passport-size Photographs (2)",
                                                     "Biometric Verification Slip"}
            chkDocs.Items.Add(docName)
        Next

        bindingNavigatorAddNewItem.Image = UiTheme.MakeIcon("new", 16)
        bindingNavigatorDeleteItem.Image = UiTheme.MakeIcon("delete", 16)
        bindingNavigatorMoveFirst.Image = UiTheme.MakeIcon("play", 16)
        bindingNavigatorMoveNext.Image = UiTheme.MakeIcon("play", 16)
        bindingNavigatorMoveLast.Image = UiTheme.MakeIcon("play", 16)
        bindingNavigatorMovePrev.Image = UiTheme.MakeIcon("play", 16)
        gridCitizen.ContextMenuStrip = ctxGrid

        tipCitizen.SetToolTip(mtbCnic, "13 digit CNIC - the last digit is a check digit")
        tipCitizen.SetToolTip(btnGenCnic, "Generate a valid CNIC with correct check digit")
        tipCitizen.SetToolTip(btnPrint, "Print preview of the NADRA style identity card")
        tipCitizen.SetToolTip(btnCapture, "Open the OpenCV visual lab and capture a photo")
        tipCitizen.SetToolTip(lblCnicStatus, "Live check-digit validation")

        ClearForm()
        LoadRecords("")
    End Sub

    Private Sub BuildGridColumns()
        gridCitizen.Columns.Clear()

        Dim colCnic As New DataGridViewTextBoxColumn()
        colCnic.HeaderText = "CNIC"
        colCnic.DataPropertyName = "Cnic"
        colCnic.FillWeight = 18
        gridCitizen.Columns.Add(colCnic)

        Dim colName As New DataGridViewTextBoxColumn()
        colName.HeaderText = "Name"
        colName.DataPropertyName = "Name"
        colName.FillWeight = 24
        gridCitizen.Columns.Add(colName)

        Dim colGender As New DataGridViewTextBoxColumn()
        colGender.HeaderText = "Gender"
        colGender.DataPropertyName = "Gender"
        colGender.FillWeight = 10
        gridCitizen.Columns.Add(colGender)

        Dim colCity As New DataGridViewTextBoxColumn()
        colCity.HeaderText = "City"
        colCity.DataPropertyName = "City"
        colCity.FillWeight = 14
        gridCitizen.Columns.Add(colCity)

        Dim colProvince As New DataGridViewTextBoxColumn()
        colProvince.HeaderText = "Province"
        colProvince.DataPropertyName = "Province"
        colProvince.FillWeight = 16
        gridCitizen.Columns.Add(colProvince)

        Dim colVerified As New DataGridViewCheckBoxColumn()
        colVerified.HeaderText = "Verified"
        colVerified.DataPropertyName = "IsVerified"
        colVerified.FillWeight = 8
        gridCitizen.Columns.Add(colVerified)

        Dim colCreated As New DataGridViewTextBoxColumn()
        colCreated.HeaderText = "Registered"
        colCreated.DataPropertyName = "CreatedOn"
        colCreated.DefaultCellStyle.Format = "dd-MMM-yyyy"
        colCreated.FillWeight = 10
        gridCitizen.Columns.Add(colCreated)
    End Sub

    Private Sub PopulateCombos()
        cmbBlood.Items.Clear()
        cmbBlood.Items.AddRange(New Object() {"A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-"})
        cmbBlood.SelectedIndex = -1

        cmbMarital.Items.Clear()
        cmbMarital.Items.AddRange(New Object() {"Single", "Married", "Divorced", "Widowed"})
        cmbMarital.SelectedIndex = 0

        cmbReligion.Items.Clear()
        cmbReligion.Items.AddRange(New Object() {"Islam", "Christianity", "Hinduism", "Sikhism", "Other"})
        cmbReligion.SelectedIndex = 0

        cmbNationality.Items.Clear()
        cmbNationality.Items.AddRange(New Object() {"Pakistani"})
        cmbNationality.SelectedIndex = 0

        cmbEducation.Items.Clear()
        cmbEducation.Items.AddRange(New Object() {"None", "Primary", "Matric", "Intermediate", "Bachelor", "Master", "M.Phil / PhD"})
        cmbEducation.SelectedIndex = 0

        cmbProvince.Items.Clear()
        cmbProvince.Items.AddRange(New Object() {"Islamabad Capital Territory", "Punjab", "Sindh",
                                                  "Khyber Pakhtunkhwa", "Balochistan", "Gilgit-Baltistan",
                                                  "Azad Jammu & Kashmir"})
        cmbProvince.SelectedIndex = -1

        cmbOffice.Items.Clear()
        cmbOffice.Items.AddRange(New Object() {"NADRA Head Office - Islamabad", "NADRA Regional Office - Lahore",
                                                "NADRA Regional Office - Karachi", "NADRA Regional Office - Peshawar",
                                                "NADRA Regional Office - Quetta", "NADRA Regional Office - Multan",
                                                "NADRA Regional Office - Gilgit", "NADRA Mega Center - Islamabad"})
        cmbOffice.SelectedIndex = -1
    End Sub

    ' ------------------------------------------------------------------ records

    Private Sub LoadRecords(selectCnic As String)
        _loading = True
        Try
            Dim list As List(Of Citizen) = CitizenStore.Search(_filter)
            bsCitizens.DataSource = New BindingList(Of Citizen)(list)
            lblCount.Text = list.Count.ToString() & " record(s)"

            If list.Count > 0 Then
                Dim index As Integer = 0
                If Not String.IsNullOrEmpty(selectCnic) Then
                    For i As Integer = 0 To list.Count - 1
                        If CitizenStore.DigitsOnly(list(i).Cnic) = CitizenStore.DigitsOnly(selectCnic) Then
                            index = i
                            Exit For
                        End If
                    Next
                End If
                bsCitizens.Position = index
                LoadInto(list(index))
                _mode = "edit"
            Else
                ClearForm()
                _mode = "add"
            End If
            UpdateModeLabel()
        Finally
            _loading = False
        End Try
    End Sub

    Private Sub LoadInto(c As Citizen)
        _currentCitizen = c
        mtbCnic.Text = CitizenStore.FormatCnic(c.Cnic)
        txtName.Text = c.Name
        txtFather.Text = c.FatherName
        radMale.Checked = (c.Gender = "Male")
        radFemale.Checked = (c.Gender = "Female")
        If c.DateOfBirth.Year > 1900 Then dtDob.Value = c.DateOfBirth Else dtDob.Value = New DateTime(1995, 1, 1)
        cmbBlood.SelectedItem = c.BloodGroup
        cmbMarital.SelectedItem = c.MaritalStatus
        cmbReligion.SelectedItem = c.Religion
        cmbNationality.SelectedItem = If(c.Nationality = "", "Pakistani", c.Nationality)
        cmbEducation.SelectedItem = c.Education
        txtOccupation.Text = c.Occupation
        radUrban.Checked = (c.AreaType <> "Rural")
        radRural.Checked = (c.AreaType = "Rural")

        txtPresentAddr.Text = c.PresentAddress
        txtPermAddr.Text = c.PermanentAddress
        chkSame.Checked = (c.PermanentAddress = c.PresentAddress)
        txtCity.Text = c.City
        cmbProvince.SelectedItem = c.Province
        txtMobile.Text = c.Mobile
        txtPhone.Text = c.Phone
        txtEmail.Text = c.Email

        _photoPath = c.PhotoPath
        ShowPhoto()

        chkVerified.Checked = c.IsVerified
        cmbOffice.SelectedItem = c.OfficeName
        If c.IssueDate.Year > 1900 Then dtIssue.Value = c.IssueDate Else dtIssue.Value = Date.Today
        If c.ExpiryDate.Year > 1900 Then dtExpiry.Value = c.ExpiryDate Else dtExpiry.Value = Date.Today.AddYears(10)

        For i As Integer = 0 To chkDocs.Items.Count - 1
            Dim docName As String = CStr(chkDocs.Items(i))
            chkDocs.SetItemChecked(i, c.Documents.IndexOf(docName, StringComparison.OrdinalIgnoreCase) >= 0)
        Next

        txtNotes.Text = c.Notes
        lblAudit.Text = "Created: " & c.CreatedOn.ToString("dd-MMM-yyyy HH:mm") &
                        "   |   Last modified: " &
                        If(c.ModifiedOn.Year > 1900, c.ModifiedOn.ToString("dd-MMM-yyyy HH:mm"), "-")
        lblCreated.Text = "Record audit - created " & c.CreatedOn.ToString("dd-MMM-yyyy HH:mm") &
                          If(c.ModifiedOn.Year > 1900, ", last modified " & c.ModifiedOn.ToString("dd-MMM-yyyy HH:mm"), "")
    End Sub

    Private Function ReadForm() As Citizen
        Dim c As New Citizen()
        c.Cnic = CitizenStore.FormatCnic(CitizenStore.DigitsOnly(mtbCnic.Text))
        c.Name = txtName.Text.Trim()
        c.FatherName = txtFather.Text.Trim()
        c.Gender = If(radFemale.Checked, "Female", "Male")
        c.DateOfBirth = dtDob.Value.Date
        c.BloodGroup = If(cmbBlood.SelectedItem Is Nothing, "", CStr(cmbBlood.SelectedItem))
        c.MaritalStatus = If(cmbMarital.SelectedItem Is Nothing, "", CStr(cmbMarital.SelectedItem))
        c.Religion = If(cmbReligion.SelectedItem Is Nothing, "", CStr(cmbReligion.SelectedItem))
        c.Nationality = If(cmbNationality.SelectedItem Is Nothing, "Pakistani", CStr(cmbNationality.SelectedItem))
        c.Education = If(cmbEducation.SelectedItem Is Nothing, "", CStr(cmbEducation.SelectedItem))
        c.Occupation = txtOccupation.Text.Trim()
        c.AreaType = If(radRural.Checked, "Rural", "Urban")
        c.PresentAddress = txtPresentAddr.Text.Trim()
        c.PermanentAddress = If(chkSame.Checked, txtPresentAddr.Text.Trim(), txtPermAddr.Text.Trim())
        c.City = txtCity.Text.Trim()
        c.Province = If(cmbProvince.SelectedItem Is Nothing, "", CStr(cmbProvince.SelectedItem))
        c.Mobile = txtMobile.Text.Trim()
        c.Phone = txtPhone.Text.Trim()
        c.Email = txtEmail.Text.Trim()
        c.PhotoPath = _photoPath
        c.OfficeName = If(cmbOffice.SelectedItem Is Nothing, "", CStr(cmbOffice.SelectedItem))
        c.IssueDate = dtIssue.Value.Date
        c.ExpiryDate = dtExpiry.Value.Date
        c.IsVerified = chkVerified.Checked
        c.Notes = txtNotes.Text.Trim()

        Dim docs As New System.Text.StringBuilder()
        For Each item As Object In chkDocs.CheckedItems
            If docs.Length > 0 Then docs.Append("; ")
            docs.Append(CStr(item))
        Next
        c.Documents = docs.ToString()

        c.CreatedOn = If(_currentCitizen IsNot Nothing, _currentCitizen.CreatedOn, Now)
        Return c
    End Function

    Private Sub ClearForm()
        _currentCitizen = Nothing
        _loading = True
        Try
            mtbCnic.Clear()
            txtName.Clear()
            txtFather.Clear()
            radMale.Checked = True
            dtDob.Value = New DateTime(1995, 1, 1)
            cmbBlood.SelectedIndex = -1
            cmbMarital.SelectedIndex = 0
            cmbReligion.SelectedIndex = 0
            cmbNationality.SelectedIndex = 0
            cmbEducation.SelectedIndex = 0
            txtOccupation.Clear()
            radUrban.Checked = True
            txtPresentAddr.Clear()
            txtPermAddr.Clear()
            chkSame.Checked = True
            txtCity.Clear()
            cmbProvince.SelectedIndex = -1
            txtMobile.Clear()
            txtPhone.Clear()
            txtEmail.Clear()
            _photoPath = ""
            ShowPhoto()
            chkVerified.Checked = False
            cmbOffice.SelectedIndex = -1
            dtIssue.Value = Date.Today
            dtExpiry.Value = Date.Today.AddYears(10)
            For i As Integer = 0 To chkDocs.Items.Count - 1
                chkDocs.SetItemChecked(i, False)
            Next
            txtNotes.Clear()
            lblCnicStatus.Text = ""
            lblAudit.Text = "Verification audit: -"
            lblCreated.Text = "Record audit: -"
            errCitizen.Clear()
        Finally
            _loading = False
        End Try
    End Sub

    Private Sub UpdateModeLabel()
        Select Case _mode
            Case "add"
                lblMode.Text = "NEW RECORD"
                lblMode.BackColor = UiTheme.Gold
                lblMode.ForeColor = UiTheme.Ink
                mtbCnic.ReadOnly = False
                btnGenCnic.Enabled = True
                tipCitizen.SetToolTip(mtbCnic, "13 digit CNIC - the last digit is a check digit")
            Case "edit"
                lblMode.Text = "EDIT / VIEW RECORD"
                lblMode.BackColor = UiTheme.BrightGreen
                lblMode.ForeColor = Color.White
                mtbCnic.ReadOnly = True
                btnGenCnic.Enabled = False
                tipCitizen.SetToolTip(mtbCnic, "CNIC is primary key and locked in edit mode. Click New Record to register another CNIC.")
            Case Else
                lblMode.Text = "VIEW"
                lblMode.BackColor = UiTheme.BrightGreen
                lblMode.ForeColor = Color.White
                mtbCnic.ReadOnly = True
                btnGenCnic.Enabled = False
        End Select
    End Sub

    Public Sub StartNewRegistration()
        _mode = "add"
        ClearForm()
        tabMain.SelectedIndex = 0
        UpdateModeLabel()
        mtbCnic.Focus()
    End Sub

    Public Sub PerformSearch(term As String)
        _filter = If(term, "")
        txtFilter.Text = _filter
        LoadRecords("")
        gridCitizen.Focus()
    End Sub

    ' ------------------------------------------------------------------ grid / navigator

    Private Sub gridCitizen_SelectionChanged(sender As Object, e As EventArgs) Handles gridCitizen.SelectionChanged
        If _loading Then Return
        If gridCitizen.CurrentRow Is Nothing Then Return
        Dim c As Citizen = TryCast(gridCitizen.CurrentRow.DataBoundItem, Citizen)
        If c Is Nothing Then Return
        _loading = True
        Try
            LoadInto(c)
            _mode = "edit"
            UpdateModeLabel()
        Finally
            _loading = False
        End Try
    End Sub

    Private Sub bindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles bindingNavigatorAddNewItem.Click
        StartNewRegistration()
    End Sub

    Private Sub bindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles bindingNavigatorDeleteItem.Click
        DeleteRecord()
    End Sub

    Private Sub bindingNavigatorPositionItem_KeyDown(sender As Object, e As KeyEventArgs) _
        Handles bindingNavigatorPositionItem.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim index As Integer
            If Integer.TryParse(bindingNavigatorPositionItem.Text, index) Then
                If index >= 1 AndAlso index <= bsCitizens.Count Then
                    bsCitizens.Position = index - 1
                    gridCitizen.Focus()
                End If
            End If
        End If
    End Sub

    ' ------------------------------------------------------------------ buttons

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        StartNewRegistration()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If _mode = "edit" Then
            If bsCitizens.Current IsNot Nothing Then LoadInto(DirectCast(bsCitizens.Current, Citizen))
        Else
            ClearForm()
        End If
        errCitizen.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveRecord()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If _mode = "add" Then
            MessageBox.Show(Me, "This is a new record - use Save to insert it.", "Update",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        SaveRecord()
    End Sub

    Private Sub SaveRecord()
        If Not ValidateForm() Then Return

        Dim c As Citizen = ReadForm()
        Dim errorText As String = ""

        If _mode = "add" Then
            errorText = CitizenStore.Insert(c)
        Else
            errorText = CitizenStore.Update(c)
        End If

        If errorText IsNot Nothing Then
            MessageBox.Show(Me, "The record could not be saved:" & vbCrLf & errorText,
                            "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim main As frmMain = TryCast(MdiParent, frmMain)
        If main IsNot Nothing Then main.RefreshCounts()

        LoadRecords(c.Cnic)
        MessageBox.Show(Me, "Citizen record saved successfully." & vbCrLf & vbCrLf &
                        "CNIC: " & CitizenStore.FormatCnic(c.Cnic),
                        "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteRecord()
    End Sub

    Private Sub DeleteRecord()
        Dim digits As String = CitizenStore.DigitsOnly(mtbCnic.Text)
        If digits.Length <> 13 Then
            MessageBox.Show(Me, "Select a record first.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim answer As DialogResult = MessageBox.Show(Me,
            "Delete the citizen record " & CitizenStore.FormatCnic(digits) & " (" & txtName.Text & ")?" & vbCrLf &
            "This action cannot be undone.", "Confirm Delete",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If answer <> DialogResult.Yes Then Return

        Dim errorText As String = CitizenStore.Delete(digits)
        If errorText IsNot Nothing Then
            MessageBox.Show(Me, "Delete failed: " & errorText, "Delete",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim main As frmMain = TryCast(MdiParent, frmMain)
        If main IsNot Nothing Then main.RefreshCounts()

        LoadRecords("")
        MessageBox.Show(Me, "Record deleted.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadRecords(CitizenStore.DigitsOnly(mtbCnic.Text))
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        _filter = txtFilter.Text.Trim()
        LoadRecords("")
    End Sub

    Private Sub txtFilter_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFilter.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnFilter_Click(sender, EventArgs.Empty)
            e.SuppressKeyPress = True
        End If
    End Sub

    ' ------------------------------------------------------------------ photo

    Private Sub ShowPhoto()
        If picPhoto.Image IsNot Nothing Then
            Dim old As Image = picPhoto.Image
            picPhoto.Image = Nothing
            old.Dispose()
        End If

        If _photoPath <> "" AndAlso File.Exists(_photoPath) Then
            Try
                Using fs As New FileStream(_photoPath, FileMode.Open, FileAccess.Read)
                    Dim img As Image = Image.FromStream(fs)
                    picPhoto.Image = New Bitmap(img)
                End Using
                lblPhotoPath.Text = "Photo: " & Path.GetFileName(_photoPath)
                Return
            Catch
            End Try
        End If

        picPhoto.Image = MakePlaceholderPhoto()
        lblPhotoPath.Text = "No photograph selected"
    End Sub

    Private Function MakePlaceholderPhoto() As Bitmap
        Dim bmp As New Bitmap(210, 270)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.Clear(UiTheme.PaleGreen)
            Using pen As New Pen(UiTheme.Green, 2)
                g.DrawRectangle(pen, 1, 1, bmp.Width - 3, bmp.Height - 3)
            End Using
            Using f As New Font("Segoe UI", 12.0F, FontStyle.Bold)
                Using br As New SolidBrush(UiTheme.Green)
                    g.DrawString("NO PHOTO", f, br, 62, 112)
                End Using
            End Using
            Using f As New Font("Segoe UI", 8.0F)
                Using br As New SolidBrush(Color.FromArgb(90, 110, 98))
                    g.DrawString("Capture with the", f, br, 60, 140)
                    g.DrawString("OpenCV visual lab", f, br, 56, 154)
                End Using
            End Using
        End Using
        Return bmp
    End Function

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If dlgPhoto.ShowDialog(Me) <> DialogResult.OK Then Return
        Try
            Dim cnic As String = CitizenStore.DigitsOnly(mtbCnic.Text)
            If cnic.Length <> 13 Then cnic = "TEMP"
            _photoPath = AppPaths.StorePhoto(dlgPhoto.FileName, cnic)
            ShowPhoto()
        Catch ex As Exception
            MessageBox.Show(Me, "Could not import the photo: " & ex.Message, "Photo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRemovePhoto_Click(sender As Object, e As EventArgs) Handles btnRemovePhoto.Click
        _photoPath = ""
        ShowPhoto()
    End Sub

    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click
        Dim main As frmMain = TryCast(MdiParent, frmMain)
        If main Is Nothing Then
            MessageBox.Show(Me, "The visual lab can only be opened from the main window.",
                            "Capture", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim lab As frmVisual = main.OpenVisualLab()
        RemoveHandler lab.PhotoCaptured, AddressOf OnPhotoCaptured
        AddHandler lab.PhotoCaptured, AddressOf OnPhotoCaptured
        lab.FocusCaptureMode()
    End Sub

    ''' <summary>Receives the photograph captured in the OpenCV lab.</summary>
    Private Sub OnPhotoCaptured(filePath As String)
        Dim sender As frmVisual = TryCast(FindVisualLab(), frmVisual)
        If sender IsNot Nothing Then RemoveHandler sender.PhotoCaptured, AddressOf OnPhotoCaptured

        _photoPath = filePath
        ShowPhoto()
        MessageBox.Show(Me, "Photograph attached:" & vbCrLf & Path.GetFileName(filePath),
                        "Photo Captured", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Function FindVisualLab() As Form
        If MdiParent Is Nothing Then Return Nothing
        For Each child As Form In MdiParent.MdiChildren
            If TypeOf child Is frmVisual Then Return child
        Next
        Return Nothing
    End Function

    Private Sub chkSame_CheckedChanged(sender As Object, e As EventArgs) Handles chkSame.CheckedChanged
        txtPermAddr.Enabled = Not chkSame.Checked
        If chkSame.Checked Then txtPermAddr.Text = txtPresentAddr.Text
    End Sub

    Private Sub txtPresentAddr_TextChanged(sender As Object, e As EventArgs) Handles txtPresentAddr.TextChanged
        If chkSame.Checked Then txtPermAddr.Text = txtPresentAddr.Text
    End Sub

    ' ------------------------------------------------------------------ validation

    Private Sub mtbCnic_TextChanged(sender As Object, e As EventArgs) Handles mtbCnic.TextChanged
        Dim message As String = ""
        If CitizenStore.DigitsOnly(mtbCnic.Text).Length = 0 Then
            lblCnicStatus.Text = ""
            Return
        End If
        If CitizenStore.ValidateCnic(mtbCnic.Text, message) Then
            lblCnicStatus.ForeColor = Color.FromArgb(0, 140, 60)
            lblCnicStatus.Text = "Valid CNIC format and check digit"
        Else
            lblCnicStatus.ForeColor = Color.Firebrick
            lblCnicStatus.Text = message
        End If
    End Sub

    Private Sub btnGenCnic_Click(sender As Object, e As EventArgs) Handles btnGenCnic.Click
        Dim region As String = CitizenStore.DigitsOnly(mtbCnic.Text)
        If region.Length >= 5 Then
            region = region.Substring(0, 5)
        Else
            region = "35202"
        End If
        mtbCnic.Text = CitizenStore.GenerateCnic(region)
    End Sub

    Private Function ValidateForm() As Boolean
        errCitizen.Clear()
        Dim ok As Boolean = True
        Dim message As String = ""

        If Not CitizenStore.ValidateCnic(mtbCnic.Text, message) Then
            errCitizen.SetError(mtbCnic, message)
            ok = False
        ElseIf _mode = "add" AndAlso CitizenStore.Exists(mtbCnic.Text) Then
            errCitizen.SetError(mtbCnic, "A citizen with this CNIC already exists in the database.")
            ok = False
        End If

        If txtName.Text.Trim().Length < 3 Then
            errCitizen.SetError(txtName, "Full name is required (at least 3 characters).")
            ok = False
        End If

        If txtFather.Text.Trim().Length < 3 Then
            errCitizen.SetError(txtFather, "Father / husband name is required.")
            ok = False
        End If

        If Not radMale.Checked AndAlso Not radFemale.Checked Then
            errCitizen.SetError(grpGender, "Select the gender.")
            ok = False
        End If

        If dtDob.Value.Date > Date.Today OrElse dtDob.Value.Year < 1900 Then
            errCitizen.SetError(dtDob, "Date of birth must be between 1900 and today.")
            ok = False
        End If

        If txtCity.Text.Trim() = "" Then
            errCitizen.SetError(txtCity, "City is required.")
            ok = False
        End If

        If cmbProvince.SelectedIndex < 0 Then
            errCitizen.SetError(cmbProvince, "Please select a province.")
            ok = False
        End If

        Dim mobile As String = CitizenStore.DigitsOnly(txtMobile.Text)
        If mobile.Length <> 11 OrElse Not mobile.StartsWith("03") Then
            errCitizen.SetError(txtMobile, "Mobile number must be 11 digits starting with 03 (e.g. 0300-1234567).")
            ok = False
        End If

        If txtEmail.Text.Trim() <> "" AndAlso Not (txtEmail.Text.Contains("@"c) AndAlso txtEmail.Text.Contains("."c)) Then
            errCitizen.SetError(txtEmail, "E-mail address is not valid.")
            ok = False
        End If

        If cmbOffice.SelectedIndex < 0 Then
            errCitizen.SetError(cmbOffice, "Select the issuing NADRA office.")
            ok = False
        End If

        If Not ok Then
            MessageBox.Show(Me, "Please correct the highlighted fields before saving.",
                            "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Return ok
    End Function

    ' ------------------------------------------------------------------ printing

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PreviewRecord()
    End Sub

    Private Sub mniPreview_Click(sender As Object, e As EventArgs) Handles mniPreview.Click
        PreviewRecord()
    End Sub

    Private Sub mniPrintDirect_Click(sender As Object, e As EventArgs) Handles mniPrintDirect.Click
        PrintDirect()
    End Sub

    Private Sub mniPageSetup_Click(sender As Object, e As EventArgs) Handles mniPageSetup.Click
        Dim doc As New CnicPrint(ReadForm())
        dlgPageSetup.Document = doc
        If dlgPageSetup.ShowDialog(Me) = DialogResult.OK Then
            doc.DefaultPageSettings = dlgPageSetup.PageSettings
            CnicPrint.ShowPreview(doc, Me)
        End If
    End Sub

    Public Sub PreviewRecord()
        Dim c As Citizen = ReadForm()
        If CitizenStore.DigitsOnly(c.Cnic).Length <> 13 Then
            MessageBox.Show(Me, "Select or enter a citizen record first.", "Print",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        CnicPrint.ShowPreview(New CnicPrint(c), Me)
    End Sub

    Private Sub PrintDirect()
        Dim c As Citizen = ReadForm()
        If CitizenStore.DigitsOnly(c.Cnic).Length <> 13 Then
            MessageBox.Show(Me, "Select or enter a citizen record first.", "Print",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim doc As New CnicPrint(c)
        dlgPrint.Document = doc
        If dlgPrint.ShowDialog(Me) = DialogResult.OK Then
            Try
                doc.Print()
            Catch ex As Exception
                MessageBox.Show(Me, "Printing failed: " & ex.Message, "Print",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ''' <summary>Called from the main window Print button / menu.</summary>
    Public Sub PrintSelectedRecord()
        PreviewRecord()
    End Sub

End Class
