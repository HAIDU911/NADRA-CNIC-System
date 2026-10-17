<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCitizen
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
        Me.lblMode = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlActions = New System.Windows.Forms.Panel()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.tabPersonal = New System.Windows.Forms.TabPage()
        Me.grpDetails = New System.Windows.Forms.GroupBox()
        Me.lblCreated = New System.Windows.Forms.Label()
        Me.grpArea = New System.Windows.Forms.GroupBox()
        Me.radUrban = New System.Windows.Forms.RadioButton()
        Me.radRural = New System.Windows.Forms.RadioButton()
        Me.lblOccupation = New System.Windows.Forms.Label()
        Me.txtOccupation = New System.Windows.Forms.TextBox()
        Me.lblEducation = New System.Windows.Forms.Label()
        Me.cmbEducation = New System.Windows.Forms.ComboBox()
        Me.grpIdentity = New System.Windows.Forms.GroupBox()
        Me.lblNationality = New System.Windows.Forms.Label()
        Me.cmbNationality = New System.Windows.Forms.ComboBox()
        Me.lblReligion = New System.Windows.Forms.Label()
        Me.cmbReligion = New System.Windows.Forms.ComboBox()
        Me.lblMarital = New System.Windows.Forms.Label()
        Me.cmbMarital = New System.Windows.Forms.ComboBox()
        Me.lblBlood = New System.Windows.Forms.Label()
        Me.cmbBlood = New System.Windows.Forms.ComboBox()
        Me.lblDob = New System.Windows.Forms.Label()
        Me.dtDob = New System.Windows.Forms.DateTimePicker()
        Me.grpGender = New System.Windows.Forms.GroupBox()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.lblFather = New System.Windows.Forms.Label()
        Me.txtFather = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblCnicStatus = New System.Windows.Forms.Label()
        Me.btnGenCnic = New System.Windows.Forms.Button()
        Me.mtbCnic = New System.Windows.Forms.MaskedTextBox()
        Me.lblCnic = New System.Windows.Forms.Label()
        Me.tabAddress = New System.Windows.Forms.TabPage()
        Me.grpPermanent = New System.Windows.Forms.GroupBox()
        Me.lblPermNote = New System.Windows.Forms.Label()
        Me.txtPermAddr = New System.Windows.Forms.TextBox()
        Me.lblPermAddr = New System.Windows.Forms.Label()
        Me.chkSame = New System.Windows.Forms.CheckBox()
        Me.grpPresent = New System.Windows.Forms.GroupBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblMobile = New System.Windows.Forms.Label()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.lblProvince = New System.Windows.Forms.Label()
        Me.cmbProvince = New System.Windows.Forms.ComboBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.lblPresentAddr = New System.Windows.Forms.Label()
        Me.txtPresentAddr = New System.Windows.Forms.TextBox()
        Me.tabPhoto = New System.Windows.Forms.TabPage()
        Me.lblPhotoTip = New System.Windows.Forms.Label()
        Me.grpPhotoActions = New System.Windows.Forms.GroupBox()
        Me.lblPhotoPath = New System.Windows.Forms.Label()
        Me.btnRemovePhoto = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnCapture = New System.Windows.Forms.Button()
        Me.picPhoto = New System.Windows.Forms.PictureBox()
        Me.tabVerification = New System.Windows.Forms.TabPage()
        Me.lblAudit = New System.Windows.Forms.Label()
        Me.grpNotes = New System.Windows.Forms.GroupBox()
        Me.txtNotes = New System.Windows.Forms.RichTextBox()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.grpOffice = New System.Windows.Forms.GroupBox()
        Me.chkVerified = New System.Windows.Forms.CheckBox()
        Me.lblExpiry = New System.Windows.Forms.Label()
        Me.dtExpiry = New System.Windows.Forms.DateTimePicker()
        Me.lblIssue = New System.Windows.Forms.Label()
        Me.dtIssue = New System.Windows.Forms.DateTimePicker()
        Me.lblOffice = New System.Windows.Forms.Label()
        Me.cmbOffice = New System.Windows.Forms.ComboBox()
        Me.chkDocs = New System.Windows.Forms.CheckedListBox()
        Me.lblDocs = New System.Windows.Forms.Label()
        Me.pnlGrid = New System.Windows.Forms.Panel()
        Me.gridCitizen = New System.Windows.Forms.DataGridView()
        Me.bindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.bsCitizens = New System.Windows.Forms.BindingSource(Me.components)
        Me.bindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.bindingNavigatorSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.bindingNavigatorMoveFirst = New System.Windows.Forms.ToolStripButton()
        Me.bindingNavigatorMovePrev = New System.Windows.Forms.ToolStripButton()
        Me.bindingNavigatorSep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.bindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.bindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.bindingNavigatorSep3 = New System.Windows.Forms.ToolStripSeparator()
        Me.bindingNavigatorMoveNext = New System.Windows.Forms.ToolStripButton()
        Me.bindingNavigatorMoveLast = New System.Windows.Forms.ToolStripButton()
        Me.bindingNavigatorSep4 = New System.Windows.Forms.ToolStripSeparator()
        Me.bindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.lblGridTitle = New System.Windows.Forms.ToolStripLabel()
        Me.errCitizen = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dlgPhoto = New System.Windows.Forms.OpenFileDialog()
        Me.dlgPrint = New System.Windows.Forms.PrintDialog()
        Me.dlgPageSetup = New System.Windows.Forms.PageSetupDialog()
        Me.ctxGrid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mniPreview = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniPageSetup = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniPrintDirect = New System.Windows.Forms.ToolStripMenuItem()
        Me.tipCitizen = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlTitle.SuspendLayout()
        Me.pnlActions.SuspendLayout()
        Me.tabMain.SuspendLayout()
        Me.tabPersonal.SuspendLayout()
        Me.grpDetails.SuspendLayout()
        Me.grpArea.SuspendLayout()
        Me.grpIdentity.SuspendLayout()
        Me.grpGender.SuspendLayout()
        Me.tabAddress.SuspendLayout()
        Me.grpPermanent.SuspendLayout()
        Me.grpPresent.SuspendLayout()
        Me.tabPhoto.SuspendLayout()
        Me.grpPhotoActions.SuspendLayout()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabVerification.SuspendLayout()
        Me.grpNotes.SuspendLayout()
        Me.grpOffice.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        CType(Me.gridCitizen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCitizens, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errCitizen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctxGrid.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.FromArgb(1, 65, 28)
        Me.pnlTitle.Controls.Add(Me.lblMode)
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
        Me.lblTitle.Size = New System.Drawing.Size(349, 28)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Citizen Registration && Records"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(205, 225, 212)
        Me.lblSubtitle.Location = New System.Drawing.Point(17, 36)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(443, 15)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Register, verify and print identity cards - NADRA CNIC Management System"
        '
        'lblMode
        '
        Me.lblMode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMode.BackColor = System.Drawing.Color.FromArgb(0, 158, 72)
        Me.lblMode.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblMode.ForeColor = System.Drawing.Color.White
        Me.lblMode.Location = New System.Drawing.Point(1150, 14)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(176, 30)
        Me.lblMode.TabIndex = 2
        Me.lblMode.Text = "VIEW"
        Me.lblMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlActions
        '
        Me.pnlActions.BackColor = System.Drawing.Color.White
        Me.pnlActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlActions.Controls.Add(Me.lblCount)
        Me.pnlActions.Controls.Add(Me.btnFilter)
        Me.pnlActions.Controls.Add(Me.txtFilter)
        Me.pnlActions.Controls.Add(Me.lblFilter)
        Me.pnlActions.Controls.Add(Me.btnRefresh)
        Me.pnlActions.Controls.Add(Me.btnPrint)
        Me.pnlActions.Controls.Add(Me.btnClear)
        Me.pnlActions.Controls.Add(Me.btnDelete)
        Me.pnlActions.Controls.Add(Me.btnUpdate)
        Me.pnlActions.Controls.Add(Me.btnSave)
        Me.pnlActions.Controls.Add(Me.btnNew)
        Me.pnlActions.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlActions.Location = New System.Drawing.Point(0, 58)
        Me.pnlActions.Name = "pnlActions"
        Me.pnlActions.Size = New System.Drawing.Size(1340, 54)
        Me.pnlActions.TabIndex = 1
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.White
        Me.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 105, 62)
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.btnNew.ForeColor = System.Drawing.Color.FromArgb(1, 65, 28)
        Me.btnNew.Location = New System.Drawing.Point(8, 9)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(96, 34)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(0, 105, 62)
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(110, 9)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(96, 34)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.White
        Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 105, 62)
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(1, 65, 28)
        Me.btnUpdate.Location = New System.Drawing.Point(212, 9)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(96, 34)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.White
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(178, 34, 34)
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(178, 34, 34)
        Me.btnDelete.Location = New System.Drawing.Point(314, 9)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(96, 34)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 105, 62)
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(1, 65, 28)
        Me.btnClear.Location = New System.Drawing.Point(416, 9)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(96, 34)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(1, 65, 28)
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(518, 9)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(128, 34)
        Me.btnPrint.TabIndex = 5
        Me.btnPrint.Text = "Print ID Card"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.White
        Me.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 105, 62)
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(1, 65, 28)
        Me.btnRefresh.Location = New System.Drawing.Point(652, 9)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(96, 34)
        Me.btnRefresh.TabIndex = 6
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblFilter.ForeColor = System.Drawing.Color.FromArgb(28, 40, 33)
        Me.lblFilter.Location = New System.Drawing.Point(790, 18)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(74, 15)
        Me.lblFilter.TabIndex = 7
        Me.lblFilter.Text = "Find record:"
        '
        'txtFilter
        '
        Me.txtFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFilter.Location = New System.Drawing.Point(870, 14)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(210, 23)
        Me.txtFilter.TabIndex = 8
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.Color.FromArgb(0, 158, 72)
        Me.btnFilter.FlatAppearance.BorderSize = 0
        Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilter.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.btnFilter.ForeColor = System.Drawing.Color.White
        Me.btnFilter.Location = New System.Drawing.Point(1086, 9)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(90, 34)
        Me.btnFilter.TabIndex = 9
        Me.btnFilter.Text = "Search"
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'lblCount
        '
        Me.lblCount.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblCount.ForeColor = System.Drawing.Color.FromArgb(1, 65, 28)
        Me.lblCount.Location = New System.Drawing.Point(1186, 9)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(144, 34)
        Me.lblCount.TabIndex = 10
        Me.lblCount.Text = "0 record(s)"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tabMain
        '
        Me.tabMain.Controls.Add(Me.tabPersonal)
        Me.tabMain.Controls.Add(Me.tabAddress)
        Me.tabMain.Controls.Add(Me.tabPhoto)
        Me.tabMain.Controls.Add(Me.tabVerification)
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.tabMain.Location = New System.Drawing.Point(0, 112)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(1340, 318)
        Me.tabMain.TabIndex = 2
        '
        'tabPersonal
        '
        Me.tabPersonal.BackColor = System.Drawing.Color.White
        Me.tabPersonal.Controls.Add(Me.grpIdentity)
        Me.tabPersonal.Controls.Add(Me.grpDetails)
        Me.tabPersonal.Location = New System.Drawing.Point(4, 26)
        Me.tabPersonal.Name = "tabPersonal"
        Me.tabPersonal.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPersonal.Size = New System.Drawing.Size(1332, 288)
        Me.tabPersonal.TabIndex = 0
        Me.tabPersonal.Text = "1. Personal Details"
        '
        'grpIdentity
        '
        Me.grpIdentity.Controls.Add(Me.lblNationality)
        Me.grpIdentity.Controls.Add(Me.cmbNationality)
        Me.grpIdentity.Controls.Add(Me.lblReligion)
        Me.grpIdentity.Controls.Add(Me.cmbReligion)
        Me.grpIdentity.Controls.Add(Me.lblMarital)
        Me.grpIdentity.Controls.Add(Me.cmbMarital)
        Me.grpIdentity.Controls.Add(Me.lblBlood)
        Me.grpIdentity.Controls.Add(Me.cmbBlood)
        Me.grpIdentity.Controls.Add(Me.lblDob)
        Me.grpIdentity.Controls.Add(Me.dtDob)
        Me.grpIdentity.Controls.Add(Me.grpGender)
        Me.grpIdentity.Controls.Add(Me.lblFather)
        Me.grpIdentity.Controls.Add(Me.txtFather)
        Me.grpIdentity.Controls.Add(Me.lblName)
        Me.grpIdentity.Controls.Add(Me.txtName)
        Me.grpIdentity.Controls.Add(Me.lblCnicStatus)
        Me.grpIdentity.Controls.Add(Me.btnGenCnic)
        Me.grpIdentity.Controls.Add(Me.mtbCnic)
        Me.grpIdentity.Controls.Add(Me.lblCnic)
        Me.grpIdentity.Location = New System.Drawing.Point(8, 6)
        Me.grpIdentity.Name = "grpIdentity"
        Me.grpIdentity.Size = New System.Drawing.Size(640, 274)
        Me.grpIdentity.TabIndex = 0
        Me.grpIdentity.TabStop = False
        Me.grpIdentity.Text = "Identity"
        '
        'lblCnic
        '
        Me.lblCnic.AutoSize = True
        Me.lblCnic.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblCnic.ForeColor = System.Drawing.Color.FromArgb(28, 40, 33)
        Me.lblCnic.Location = New System.Drawing.Point(14, 24)
        Me.lblCnic.Name = "lblCnic"
        Me.lblCnic.Size = New System.Drawing.Size(97, 15)
        Me.lblCnic.TabIndex = 0
        Me.lblCnic.Text = "CNIC Number:"
        '
        'mtbCnic
        '
        Me.mtbCnic.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.mtbCnic.Location = New System.Drawing.Point(17, 44)
        Me.mtbCnic.Mask = "00000\-0000000-0"
        Me.mtbCnic.Name = "mtbCnic"
        Me.mtbCnic.Size = New System.Drawing.Size(220, 25)
        Me.mtbCnic.TabIndex = 1
        '
        'btnGenCnic
        '
        Me.btnGenCnic.BackColor = System.Drawing.Color.White
        Me.btnGenCnic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 105, 62)
        Me.btnGenCnic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenCnic.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnGenCnic.ForeColor = System.Drawing.Color.FromArgb(1, 65, 28)
        Me.btnGenCnic.Location = New System.Drawing.Point(243, 44)
        Me.btnGenCnic.Name = "btnGenCnic"
        Me.btnGenCnic.Size = New System.Drawing.Size(92, 25)
        Me.btnGenCnic.TabIndex = 2
        Me.btnGenCnic.Text = "Generate"
        Me.btnGenCnic.UseVisualStyleBackColor = False
        '
        'lblCnicStatus
        '
        Me.lblCnicStatus.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.lblCnicStatus.ForeColor = System.Drawing.Color.FromArgb(0, 140, 60)
        Me.lblCnicStatus.Location = New System.Drawing.Point(341, 47)
        Me.lblCnicStatus.Name = "lblCnicStatus"
        Me.lblCnicStatus.Size = New System.Drawing.Size(286, 20)
        Me.lblCnicStatus.TabIndex = 3
        Me.lblCnicStatus.Text = ""
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(28, 40, 33)
        Me.lblName.Location = New System.Drawing.Point(14, 80)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(108, 15)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Full Name *"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtName.Location = New System.Drawing.Point(17, 100)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(610, 25)
        Me.txtName.TabIndex = 5
        '
        'lblFather
        '
        Me.lblFather.AutoSize = True
        Me.lblFather.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblFather.ForeColor = System.Drawing.Color.FromArgb(28, 40, 33)
        Me.lblFather.Location = New System.Drawing.Point(14, 134)
        Me.lblFather.Name = "lblFather"
        Me.lblFather.Size = New System.Drawing.Size(188, 15)
        Me.lblFather.TabIndex = 6
        Me.lblFather.Text = "Father / Husband Name *"
        '
        'txtFather
        '
        Me.txtFather.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtFather.Location = New System.Drawing.Point(17, 154)
        Me.txtFather.Name = "txtFather"
        Me.txtFather.Size = New System.Drawing.Size(610, 25)
        Me.txtFather.TabIndex = 7
        '
        'grpGender
        '
        Me.grpGender.Controls.Add(Me.radFemale)
        Me.grpGender.Controls.Add(Me.radMale)
        Me.grpGender.Location = New System.Drawing.Point(17, 168)
        Me.grpGender.Name = "grpGender"
        Me.grpGender.Size = New System.Drawing.Size(170, 60)
        Me.grpGender.TabIndex = 8
        Me.grpGender.TabStop = False
        Me.grpGender.Text = "Gender *"
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Checked = True
        Me.radMale.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.radMale.Location = New System.Drawing.Point(12, 24)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(60, 19)
        Me.radMale.TabIndex = 0
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.radFemale.Location = New System.Drawing.Point(88, 24)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(76, 19)
        Me.radFemale.TabIndex = 1
        Me.radFemale.Text = "Female"
        '
        'lblDob
        '
        Me.lblDob.AutoSize = True
        Me.lblDob.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblDob.ForeColor = System.Drawing.Color.FromArgb(28, 40, 33)
        Me.lblDob.Location = New System.Drawing.Point(200, 164)
        Me.lblDob.Name = "lblDob"
        Me.lblDob.Size = New System.Drawing.Size(90, 15)
        Me.lblDob.TabIndex = 9
        Me.lblDob.Text = "Date of Birth *"
        '
        'dtDob
        '
        Me.dtDob.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtDob.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtDob.Location = New System.Drawing.Point(203, 184)
        Me.dtDob.Name = "dtDob"
        Me.dtDob.Size = New System.Drawing.Size(140, 23)
        Me.dtDob.TabIndex = 10
        '
        'lblBlood
        '
        Me.lblBlood.AutoSize = True
        Me.lblBlood.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblBlood.ForeColor = System.Drawing.Color.FromArgb(28, 40, 33)
        Me.lblBlood.Location = New System.Drawing.Point(352, 164)
        Me.lblBlood.Name = "lblBlood"
        Me.lblBlood.Size = New System.Drawing.Size(84, 15)
        Me.lblBlood.TabIndex = 11
        Me.lblBlood.Text = "Blood Group"
        '
        'cmbBlood
        '
        Me.cmbBlood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBlood.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmbBlood.Location = New System.Drawing.Point(355, 184)
        Me.cmbBlood.Name = "cmbBlood"
        Me.cmbBlood.Size = New System.Drawing.Size(110, 23)
        Me.cmbBlood.TabIndex = 12
        '
        'lblMarital
        '
        Me.lblMarital.AutoSize = True
        Me.lblMarital.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblMarital.ForeColor = System.Drawing.Color.FromArgb(28, 40, 33)
        Me.lblMarital.Location = New System.Drawing.Point(14, 230)
        Me.lblMarital.Name = "lblMarital"
        Me.lblMarital.Size = New System.Drawing.Size(95, 15)
        Me.lblMarital.TabIndex = 13
        Me.lblMarital.Text = "Marital Status"
        '
        'cmbMarital
        '
        Me.cmbMarital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMarital.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmbMarital.Location = New System.Drawing.Point(17, 248)
        Me.cmbMarital.Name = "cmbMarital"
        Me.cmbMarital.Size = New System.Drawing.Size(130, 23)
        Me.cmbMarital.TabIndex = 14
        '
        'lblReligion
        '
        Me.lblReligion.AutoSize = True
        Me.lblReligion.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblReligion.ForeColor = System.Drawing.Color.FromArgb(28, 40, 33)
        Me.lblReligion.Location = New System.Drawing.Point(160, 230)
        Me.lblReligion.Name = "lblReligion"
        Me.lblReligion.Size = New System.Drawing.Size(67, 15)
        Me.lblReligion.TabIndex = 15
        Me.lblReligion.Text = "Religion"
        '
        'cmbReligion
        '
        Me.cmbReligion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReligion.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmbReligion.Location = New System.Drawing.Point(163, 248)
        Me.cmbReligion.Name = "cmbReligion"
        Me.cmbReligion.Size = New System.Drawing.Size(140, 23)
        Me.cmbReligion.TabIndex = 16
        '
        'lblNationality
        '
        Me.lblNationality.AutoSize = True
        Me.lblNationality.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblNationality.ForeColor = System.Drawing.Color.FromArgb(28, 40, 33)
        Me.lblNationality.Location = New System.Drawing.Point(316, 230)
        Me.lblNationality.Name = "lblNationality"
        Me.lblNationality.Size = New System.Drawing.Size(86, 15)
        Me.lblNationality.TabIndex = 17
        Me.lblNationality.Text = "Nationality"
        '
        'cmbNationality
        '
        Me.cmbNationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNationality.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmbNationality.Location = New System.Drawing.Point(319, 248)
        Me.cmbNationality.Name = "cmbNationality"
        Me.cmbNationality.Size = New System.Drawing.Size(160, 23)
        Me.cmbNationality.TabIndex = 18
        '
        'grpDetails
        '
        Me.grpDetails.Controls.Add(Me.lblCreated)
        Me.grpDetails.Controls.Add(Me.grpArea)
        Me.grpDetails.Controls.Add(Me.lblOccupation)
        Me.grpDetails.Controls.Add(Me.txtOccupation)
        Me.grpDetails.Controls.Add(Me.lblEducation)
        Me.grpDetails.Controls.Add(Me.cmbEducation)
        Me.grpDetails.Location = New System.Drawing.Point(656, 6)
        Me.grpDetails.Name = "grpDetails"
        Me.grpDetails.Size = New System.Drawing.Size(668, 274)
        Me.grpDetails.TabIndex = 1
        Me.grpDetails.TabStop = False
        Me.grpDetails.Text = "Education, Occupation && Area"
        '
        'lblEducation
        '
        Me.lblEducation.AutoSize = True
        Me.lblEducation.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblEducation.ForeColor = System.Drawing.Color.FromArgb(28, 40, 33)
        Me.lblEducation.Location = New System.Drawing.Point(16, 30)
        Me.lblEducation.Name = "lblEducation"
        Me.lblEducation.Size = New System.Drawing.Size(84, 15)
        Me.lblEducation.TabIndex = 0
        Me.lblEducation.Text = "Education"
        '
        'cmbEducation
        '
        Me.cmbEducation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEducation.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmbEducation.Location = New System.Drawing.Point(19, 50)
        Me.cmbEducation.Name = "cmbEducation"
        Me.cmbEducation.Size = New System.Drawing.Size(240, 23)
        Me.cmbEducation.TabIndex = 1
        '
        'lblOccupation
        '
        Me.lblOccupation.AutoSize = True
        Me.lblOccupation.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblOccupation.ForeColor = System.Drawing.Color.FromArgb(28, 40, 33)
        Me.lblOccupation.Location = New System.Drawing.Point(16, 88)
        Me.lblOccupation.Name = "lblOccupation"
        Me.lblOccupation.Size = New System.Drawing.Size(84, 15)
        Me.lblOccupation.TabIndex = 2
        Me.lblOccupation.Text = "Occupation"
        '
        'txtOccupation
        '
        Me.txtOccupation.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtOccupation.Location = New System.Drawing.Point(19, 108)
        Me.txtOccupation.Name = "txtOccupation"
        Me.txtOccupation.Size = New System.Drawing.Size(240, 25)
        Me.txtOccupation.TabIndex = 3
        '
        'grpArea
        '
        Me.grpArea.Controls.Add(Me.radRural)
        Me.grpArea.Controls.Add(Me.radUrban)
        Me.grpArea.Location = New System.Drawing.Point(19, 146)
        Me.grpArea.Name = "grpArea"
        Me.grpArea.Size = New System.Drawing.Size(320, 60)
        Me.grpArea.TabIndex = 4
        Me.grpArea.TabStop = False
        Me.grpArea.Text = "Area Type"
        '
        'radUrban
        '
        Me.radUrban.AutoSize = True
        Me.radUrban.Checked = True
        Me.radUrban.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.radUrban.Location = New System.Drawing.Point(16, 26)
        Me.radUrban.Name = "radUrban"
        Me.radUrban.Size = New System.Drawing.Size(70, 19)
        Me.radUrban.TabIndex = 0
        Me.radUrban.TabStop = True
        Me.radUrban.Text = "Urban"
        '
        'radRural
        '
        Me.radRural.AutoSize = True
        Me.radRural.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.radRural.Location = New System.Drawing.Point(140, 26)
        Me.radRural.Name = "radRural"
        Me.radRural.Size = New System.Drawing.Size(66, 19)
        Me.radRural.TabIndex = 1
        Me.radRural.Text = "Rural"
        '
        'lblCreated
        '
        Me.lblCreated.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.lblCreated.ForeColor = System.Drawing.Color.FromArgb(90, 110, 98)
        Me.lblCreated.Location = New System.Drawing.Point(16, 216)
        Me.lblCreated.Name = "lblCreated"
        Me.lblCreated.Size = New System.Drawing.Size(640, 46)
        Me.lblCreated.TabIndex = 5
        Me.lblCreated.Text = "Record audit: -"
        '
        'tabAddress
        '
        Me.tabAddress.BackColor = System.Drawing.Color.White
        Me.tabAddress.Controls.Add(Me.grpPermanent)
        Me.tabAddress.Controls.Add(Me.grpPresent)
        Me.tabAddress.Location = New System.Drawing.Point(4, 26)
        Me.tabAddress.Name = "tabAddress"
        Me.tabAddress.Size = New System.Drawing.Size(1332, 288)
        Me.tabAddress.TabIndex = 1
        Me.tabAddress.Text = "2. Address && Contact"
        '
        'grpPresent
        '
        Me.grpPresent.Controls.Add(Me.lblEmail)
        Me.grpPresent.Controls.Add(Me.txtEmail)
        Me.grpPresent.Controls.Add(Me.lblPhone)
        Me.grpPresent.Controls.Add(Me.txtPhone)
        Me.grpPresent.Controls.Add(Me.lblMobile)
        Me.grpPresent.Controls.Add(Me.txtMobile)
        Me.grpPresent.Controls.Add(Me.lblProvince)
        Me.grpPresent.Controls.Add(Me.cmbProvince)
        Me.grpPresent.Controls.Add(Me.lblCity)
        Me.grpPresent.Controls.Add(Me.txtCity)
        Me.grpPresent.Controls.Add(Me.lblPresentAddr)
        Me.grpPresent.Controls.Add(Me.txtPresentAddr)
        Me.grpPresent.Location = New System.Drawing.Point(8, 6)
        Me.grpPresent.Name = "grpPresent"
        Me.grpPresent.Size = New System.Drawing.Size(640, 274)
        Me.grpPresent.TabIndex = 0
        Me.grpPresent.TabStop = False
        Me.grpPresent.Text = "Present Address"
        '
        'lblPresentAddr
        '
        Me.lblPresentAddr.AutoSize = True
        Me.lblPresentAddr.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblPresentAddr.ForeColor = System.Drawing.Color.FromArgb(28, 40, 33)
        Me.lblPresentAddr.Location = New System.Drawing.Point(14, 24)
        Me.lblPresentAddr.Name = "lblPresentAddr"
        Me.lblPresentAddr.Size = New System.Drawing.Size(123, 15)
        Me.lblPresentAddr.TabIndex = 0
        Me.lblPresentAddr.Text = "House / Street / Area *"
        '
        'txtPresentAddr
        '
        Me.txtPresentAddr.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPresentAddr.Location = New System.Drawing.Point(17, 44)
        Me.txtPresentAddr.Multiline = True
        Me.txtPresentAddr.Name = "txtPresentAddr"
        Me.txtPresentAddr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPresentAddr.Size = New System.Drawing.Size(610, 58)
        Me.txtPresentAddr.TabIndex = 1
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblCity.ForeColor = System.Drawing.Color.FromArgb(28, 40, 33)
        Me.lblCity.Location = New System.Drawing.Point(14, 114)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(56, 15)
        Me.lblCity.TabIndex = 2
        Me.lblCity.Text = "City *"
        '
        'txtCity
        '
        Me.txtCity.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtCity.Location = New System.Drawing.Point(17, 134)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(180, 25)
        Me.txtCity.TabIndex = 3
        '
        'lblProvince
        '
        Me.lblProvince.AutoSize = True
        Me.lblProvince.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblProvince.ForeColor = System.Drawing.Color.FromArgb(28, 40, 33)
        Me.lblProvince.Location = New System.Drawing.Point(214, 114)
        Me.lblProvince.Name = "lblProvince"
        Me.lblProvince.Size = New System.Drawing.Size(86, 15)
        Me.lblProvince.TabIndex = 4
        Me.lblProvince.Text = "Province *"
        '
        'cmbProvince
        '
        Me.cmbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProvince.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmbProvince.Location = New System.Drawing.Point(217, 134)
        Me.cmbProvince.Name = "cmbProvince"
        Me.cmbProvince.Size = New System.Drawing.Size(410, 23)
        Me.cmbProvince.TabIndex = 5
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblMobile.ForeColor = System.Drawing.Color.FromArgb(28, 40, 33)
        Me.lblMobile.Location = New System.Drawing.Point(14, 172)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(136, 15)
        Me.lblMobile.TabIndex = 6
        Me.lblMobile.Text = "Mobile (03xx-xxxxxxx) *"
        '
        'txtMobile
        '
        Me.txtMobile.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtMobile.Location = New System.Drawing.Point(17, 192)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(180, 25)
        Me.txtMobile.TabIndex = 7
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblPhone.ForeColor = System.Drawing.Color.FromArgb(28, 40, 33)
        Me.lblPhone.Location = New System.Drawing.Point(214, 172)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(110, 15)
        Me.lblPhone.TabIndex = 8
        Me.lblPhone.Text = "Phone (optional)"
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtPhone.Location = New System.Drawing.Point(217, 192)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(180, 25)
        Me.txtPhone.TabIndex = 9
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(28, 40, 33)
        Me.lblEmail.Location = New System.Drawing.Point(14, 230)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(128, 15)
        Me.lblEmail.TabIndex = 10
        Me.lblEmail.Text = "E-mail (optional)"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtEmail.Location = New System.Drawing.Point(17, 250)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(380, 25)
        Me.txtEmail.TabIndex = 11
        '
        'grpPermanent
        '
        Me.grpPermanent.Controls.Add(Me.lblPermNote)
        Me.grpPermanent.Controls.Add(Me.txtPermAddr)
        Me.grpPermanent.Controls.Add(Me.lblPermAddr)
        Me.grpPermanent.Controls.Add(Me.chkSame)
        Me.grpPermanent.Location = New System.Drawing.Point(656, 6)
        Me.grpPermanent.Name = "grpPermanent"
        Me.grpPermanent.Size = New System.Drawing.Size(668, 274)
        Me.grpPermanent.TabIndex = 1
        Me.grpPermanent.TabStop = False
        Me.grpPermanent.Text = "Permanent Address"
        '
        'chkSame
        '
        Me.chkSame.AutoSize = True
        Me.chkSame.Checked = True
        Me.chkSame.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSame.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.chkSame.Location = New System.Drawing.Point(19, 28)
        Me.chkSame.Name = "chkSame"
        Me.chkSame.Size = New System.Drawing.Size(277, 19)
        Me.chkSame.TabIndex = 0
        Me.chkSame.Text = "Same as present address"
        Me.chkSame.UseVisualStyleBackColor = True
        '
        'lblPermAddr
        '
        Me.lblPermAddr.AutoSize = True
        Me.lblPermAddr.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblPermAddr.ForeColor = System.Drawing.Color.FromArgb(28, 40, 33)
        Me.lblPermAddr.Location = New System.Drawing.Point(16, 60)
        Me.lblPermAddr.Name = "lblPermAddr"
        Me.lblPermAddr.Size = New System.Drawing.Size(147, 15)
        Me.lblPermAddr.TabIndex = 1
        Me.lblPermAddr.Text = "Permanent Address"
        '
        'txtPermAddr
        '
        Me.txtPermAddr.Enabled = False
        Me.txtPermAddr.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPermAddr.Location = New System.Drawing.Point(19, 80)
        Me.txtPermAddr.Multiline = True
        Me.txtPermAddr.Name = "txtPermAddr"
        Me.txtPermAddr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPermAddr.Size = New System.Drawing.Size(630, 90)
        Me.txtPermAddr.TabIndex = 2
        '
        'lblPermNote
        '
        Me.lblPermNote.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.lblPermNote.ForeColor = System.Drawing.Color.FromArgb(90, 110, 98)
        Me.lblPermNote.Location = New System.Drawing.Point(16, 184)
        Me.lblPermNote.Name = "lblPermNote"
        Me.lblPermNote.Size = New System.Drawing.Size(636, 70)
        Me.lblPermNote.TabIndex = 3
        Me.lblPermNote.Text = "Tick the check box to copy the present address, or untick it to type a different" &
    " permanent address (as mentioned on the family registration certificate)."
        '
        'tabPhoto
        '
        Me.tabPhoto.BackColor = System.Drawing.Color.White
        Me.tabPhoto.Controls.Add(Me.lblPhotoTip)
        Me.tabPhoto.Controls.Add(Me.grpPhotoActions)
        Me.tabPhoto.Controls.Add(Me.picPhoto)
        Me.tabPhoto.Location = New System.Drawing.Point(4, 26)
        Me.tabPhoto.Name = "tabPhoto"
        Me.tabPhoto.Size = New System.Drawing.Size(1332, 288)
        Me.tabPhoto.TabIndex = 2
        Me.tabPhoto.Text = "3. Photograph (OpenCV)"
        '
        'picPhoto
        '
        Me.picPhoto.BackColor = System.Drawing.Color.FromArgb(231, 244, 236)
        Me.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPhoto.Location = New System.Drawing.Point(8, 6)
        Me.picPhoto.Name = "picPhoto"
        Me.picPhoto.Size = New System.Drawing.Size(210, 270)
        Me.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPhoto.TabIndex = 0
        Me.picPhoto.TabStop = False
        '
        'grpPhotoActions
        '
        Me.grpPhotoActions.Controls.Add(Me.lblPhotoPath)
        Me.grpPhotoActions.Controls.Add(Me.btnRemovePhoto)
        Me.grpPhotoActions.Controls.Add(Me.btnBrowse)
        Me.grpPhotoActions.Controls.Add(Me.btnCapture)
        Me.grpPhotoActions.Location = New System.Drawing.Point(230, 6)
        Me.grpPhotoActions.Name = "grpPhotoActions"
        Me.grpPhotoActions.Size = New System.Drawing.Size(470, 200)
        Me.grpPhotoActions.TabIndex = 1
        Me.grpPhotoActions.TabStop = False
        Me.grpPhotoActions.Text = "Photograph"
        '
        'btnCapture
        '
        Me.btnCapture.BackColor = System.Drawing.Color.FromArgb(0, 105, 62)
        Me.btnCapture.FlatAppearance.BorderSize = 0
        Me.btnCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCapture.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCapture.ForeColor = System.Drawing.Color.White
        Me.btnCapture.Location = New System.Drawing.Point(16, 30)
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.Size = New System.Drawing.Size(438, 38)
        Me.btnCapture.TabIndex = 0
        Me.btnCapture.Text = "Capture from Webcam (OpenCV Visual Lab)"
        Me.btnCapture.UseVisualStyleBackColor = False
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.White
        Me.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 105, 62)
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnBrowse.ForeColor = System.Drawing.Color.FromArgb(1, 65, 28)
        Me.btnBrowse.Location = New System.Drawing.Point(16, 78)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(438, 34)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Import Photo from File..."
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'btnRemovePhoto
        '
        Me.btnRemovePhoto.BackColor = System.Drawing.Color.White
        Me.btnRemovePhoto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(178, 34, 34)
        Me.btnRemovePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemovePhoto.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRemovePhoto.ForeColor = System.Drawing.Color.FromArgb(178, 34, 34)
        Me.btnRemovePhoto.Location = New System.Drawing.Point(16, 122)
        Me.btnRemovePhoto.Name = "btnRemovePhoto"
        Me.btnRemovePhoto.Size = New System.Drawing.Size(438, 34)
        Me.btnRemovePhoto.TabIndex = 2
        Me.btnRemovePhoto.Text = "Remove Photo"
        Me.btnRemovePhoto.UseVisualStyleBackColor = False
        '
        'lblPhotoPath
        '
        Me.lblPhotoPath.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.lblPhotoPath.ForeColor = System.Drawing.Color.FromArgb(90, 110, 98)
        Me.lblPhotoPath.Location = New System.Drawing.Point(16, 164)
        Me.lblPhotoPath.Name = "lblPhotoPath"
        Me.lblPhotoPath.Size = New System.Drawing.Size(438, 30)
        Me.lblPhotoPath.TabIndex = 3
        Me.lblPhotoPath.Text = "No photograph selected"
        '
        'lblPhotoTip
        '
        Me.lblPhotoTip.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblPhotoTip.ForeColor = System.Drawing.Color.FromArgb(28, 40, 33)
        Me.lblPhotoTip.Location = New System.Drawing.Point(716, 14)
        Me.lblPhotoTip.Name = "lblPhotoTip"
        Me.lblPhotoTip.Size = New System.Drawing.Size(590, 250)
        Me.lblPhotoTip.TabIndex = 2
        Me.lblPhotoTip.Text = "How to attach a photograph:" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) &
    "1. Click Capture from Webcam - the OpenCV Visual Effects Lab opens and streams " &
    "the camera." & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) &
    "2. Apply any visual effect (grayscale, Canny edges, face detection...) for previ" &
    "ew, then press Capture Photo - the original frame is stored as the citizen photo" &
    "ograph." & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) &
    "3. Or use Import Photo from File to pick an existing JPG/PNG." & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) &
    "Tip: face detection highlights faces with a green box, so you can align the pers" &
    "on before capturing."
        '
        'tabVerification
        '
        Me.tabVerification.BackColor = System.Drawing.Color.White
        Me.tabVerification.Controls.Add(Me.lblAudit)
        Me.tabVerification.Controls.Add(Me.grpNotes)
        Me.tabVerification.Controls.Add(Me.grpOffice)
        Me.tabVerification.Controls.Add(Me.chkDocs)
        Me.tabVerification.Controls.Add(Me.lblDocs)
        Me.tabVerification.Location = New System.Drawing.Point(4, 26)
        Me.tabVerification.Name = "tabVerification"
        Me.tabVerification.Size = New System.Drawing.Size(1332, 288)
        Me.tabVerification.TabIndex = 3
        Me.tabVerification.Text = "4. Documents && Verification"
        '
        'lblDocs
        '
        Me.lblDocs.AutoSize = True
        Me.lblDocs.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblDocs.ForeColor = System.Drawing.Color.FromArgb(1, 65, 28)
        Me.lblDocs.Location = New System.Drawing.Point(10, 10)
        Me.lblDocs.Name = "lblDocs"
        Me.lblDocs.Size = New System.Drawing.Size(196, 15)
        Me.lblDocs.TabIndex = 0
        Me.lblDocs.Text = "Documents submitted"
        '
        'chkDocs
        '
        Me.chkDocs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.chkDocs.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.chkDocs.FormattingEnabled = True
        Me.chkDocs.Location = New System.Drawing.Point(12, 30)
        Me.chkDocs.Name = "chkDocs"
        Me.chkDocs.Size = New System.Drawing.Size(360, 204)
        Me.chkDocs.TabIndex = 1
        '
        'grpOffice
        '
        Me.grpOffice.Controls.Add(Me.chkVerified)
        Me.grpOffice.Controls.Add(Me.lblExpiry)
        Me.grpOffice.Controls.Add(Me.dtExpiry)
        Me.grpOffice.Controls.Add(Me.lblIssue)
        Me.grpOffice.Controls.Add(Me.dtIssue)
        Me.grpOffice.Controls.Add(Me.lblOffice)
        Me.grpOffice.Controls.Add(Me.cmbOffice)
        Me.grpOffice.Location = New System.Drawing.Point(390, 6)
        Me.grpOffice.Name = "grpOffice"
        Me.grpOffice.Size = New System.Drawing.Size(470, 228)
        Me.grpOffice.TabIndex = 2
        Me.grpOffice.TabStop = False
        Me.grpOffice.Text = "Issuing Office && Validity"
        '
        'lblOffice
        '
        Me.lblOffice.AutoSize = True
        Me.lblOffice.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblOffice.ForeColor = System.Drawing.Color.FromArgb(28, 40, 33)
        Me.lblOffice.Location = New System.Drawing.Point(14, 26)
        Me.lblOffice.Name = "lblOffice"
        Me.lblOffice.Size = New System.Drawing.Size(95, 15)
        Me.lblOffice.TabIndex = 0
        Me.lblOffice.Text = "NADRA Office *"
        '
        'cmbOffice
        '
        Me.cmbOffice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOffice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmbOffice.Location = New System.Drawing.Point(17, 46)
        Me.cmbOffice.Name = "cmbOffice"
        Me.cmbOffice.Size = New System.Drawing.Size(436, 23)
        Me.cmbOffice.TabIndex = 1
        '
        'lblIssue
        '
        Me.lblIssue.AutoSize = True
        Me.lblIssue.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblIssue.ForeColor = System.Drawing.Color.FromArgb(28, 40, 33)
        Me.lblIssue.Location = New System.Drawing.Point(14, 84)
        Me.lblIssue.Name = "lblIssue"
        Me.lblIssue.Size = New System.Drawing.Size(86, 15)
        Me.lblIssue.TabIndex = 2
        Me.lblIssue.Text = "Issue Date"
        '
        'dtIssue
        '
        Me.dtIssue.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtIssue.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtIssue.Location = New System.Drawing.Point(17, 104)
        Me.dtIssue.Name = "dtIssue"
        Me.dtIssue.Size = New System.Drawing.Size(140, 23)
        Me.dtIssue.TabIndex = 3
        '
        'lblExpiry
        '
        Me.lblExpiry.AutoSize = True
        Me.lblExpiry.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblExpiry.ForeColor = System.Drawing.Color.FromArgb(28, 40, 33)
        Me.lblExpiry.Location = New System.Drawing.Point(180, 84)
        Me.lblExpiry.Name = "lblExpiry"
        Me.lblExpiry.Size = New System.Drawing.Size(92, 15)
        Me.lblExpiry.TabIndex = 4
        Me.lblExpiry.Text = "Expiry Date"
        '
        'dtExpiry
        '
        Me.dtExpiry.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtExpiry.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtExpiry.Location = New System.Drawing.Point(183, 104)
        Me.dtExpiry.Name = "dtExpiry"
        Me.dtExpiry.Size = New System.Drawing.Size(140, 23)
        Me.dtExpiry.TabIndex = 5
        '
        'chkVerified
        '
        Me.chkVerified.AutoSize = True
        Me.chkVerified.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chkVerified.ForeColor = System.Drawing.Color.FromArgb(0, 105, 62)
        Me.chkVerified.Location = New System.Drawing.Point(17, 152)
        Me.chkVerified.Name = "chkVerified"
        Me.chkVerified.Size = New System.Drawing.Size(302, 19)
        Me.chkVerified.TabIndex = 6
        Me.chkVerified.Text = "Biometrically VERIFIED by this officer"
        Me.chkVerified.UseVisualStyleBackColor = True
        '
        'grpNotes
        '
        Me.grpNotes.Controls.Add(Me.txtNotes)
        Me.grpNotes.Controls.Add(Me.lblNotes)
        Me.grpNotes.Location = New System.Drawing.Point(876, 6)
        Me.grpNotes.Name = "grpNotes"
        Me.grpNotes.Size = New System.Drawing.Size(448, 228)
        Me.grpNotes.TabIndex = 3
        Me.grpNotes.TabStop = False
        Me.grpNotes.Text = "Officer Remarks"
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblNotes.ForeColor = System.Drawing.Color.FromArgb(28, 40, 33)
        Me.lblNotes.Location = New System.Drawing.Point(14, 26)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(60, 15)
        Me.lblNotes.TabIndex = 0
        Me.lblNotes.Text = "Notes"
        '
        'txtNotes
        '
        Me.txtNotes.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNotes.Location = New System.Drawing.Point(17, 46)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(414, 168)
        Me.txtNotes.TabIndex = 1
        Me.txtNotes.Text = ""
        '
        'lblAudit
        '
        Me.lblAudit.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.lblAudit.ForeColor = System.Drawing.Color.FromArgb(90, 110, 98)
        Me.lblAudit.Location = New System.Drawing.Point(12, 244)
        Me.lblAudit.Name = "lblAudit"
        Me.lblAudit.Size = New System.Drawing.Size(848, 34)
        Me.lblAudit.TabIndex = 4
        Me.lblAudit.Text = "Verification audit: -"
        '
        'pnlGrid
        '
        Me.pnlGrid.BackColor = System.Drawing.Color.White
        Me.pnlGrid.Controls.Add(Me.gridCitizen)
        Me.pnlGrid.Controls.Add(Me.bindingNavigator1)
        Me.pnlGrid.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlGrid.Location = New System.Drawing.Point(0, 430)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Size = New System.Drawing.Size(1340, 190)
        Me.pnlGrid.TabIndex = 3
        '
        'gridCitizen
        '
        Me.gridCitizen.AllowUserToAddRows = False
        Me.gridCitizen.AllowUserToDeleteRows = False
        Me.gridCitizen.BackgroundColor = System.Drawing.Color.White
        Me.gridCitizen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gridCitizen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridCitizen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridCitizen.Location = New System.Drawing.Point(0, 25)
        Me.gridCitizen.MultiSelect = False
        Me.gridCitizen.Name = "gridCitizen"
        Me.gridCitizen.ReadOnly = True
        Me.gridCitizen.RowHeadersVisible = False
        Me.gridCitizen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridCitizen.Size = New System.Drawing.Size(1340, 165)
        Me.gridCitizen.TabIndex = 1
        '
        'bindingNavigator1
        '
        Me.bindingNavigator1.AddNewItem = Me.bindingNavigatorAddNewItem
        Me.bindingNavigator1.BindingSource = Me.bsCitizens
        Me.bindingNavigator1.CountItem = Me.bindingNavigatorCountItem
        Me.bindingNavigator1.DeleteItem = Me.bindingNavigatorDeleteItem
        Me.bindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bindingNavigatorAddNewItem, Me.bindingNavigatorSep1, Me.bindingNavigatorMoveFirst, Me.bindingNavigatorMovePrev, Me.bindingNavigatorSep2, Me.bindingNavigatorPositionItem, Me.bindingNavigatorCountItem, Me.bindingNavigatorSep3, Me.bindingNavigatorMoveNext, Me.bindingNavigatorMoveLast, Me.bindingNavigatorSep4, Me.bindingNavigatorDeleteItem, Me.lblGridTitle})
        Me.bindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.bindingNavigator1.MoveFirstItem = Me.bindingNavigatorMoveFirst
        Me.bindingNavigator1.MoveLastItem = Me.bindingNavigatorMoveLast
        Me.bindingNavigator1.MoveNextItem = Me.bindingNavigatorMoveNext
        Me.bindingNavigator1.MovePreviousItem = Me.bindingNavigatorMovePrev
        Me.bindingNavigator1.Name = "bindingNavigator1"
        Me.bindingNavigator1.PositionItem = Me.bindingNavigatorPositionItem
        Me.bindingNavigator1.Size = New System.Drawing.Size(1340, 25)
        Me.bindingNavigator1.TabIndex = 0
        '
        'bsCitizens
        '
        Me.bsCitizens.AllowNew = False
        '
        'bindingNavigatorAddNewItem
        '
        Me.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem"
        Me.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.bindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.bindingNavigatorAddNewItem.Text = "Add new"
        '
        'bindingNavigatorSep1
        '
        Me.bindingNavigatorSep1.Name = "bindingNavigatorSep1"
        Me.bindingNavigatorSep1.Size = New System.Drawing.Size(6, 25)
        '
        'bindingNavigatorMoveFirst
        '
        Me.bindingNavigatorMoveFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMoveFirst.Name = "bindingNavigatorMoveFirst"
        Me.bindingNavigatorMoveFirst.RightToLeftAutoMirrorImage = True
        Me.bindingNavigatorMoveFirst.Size = New System.Drawing.Size(23, 22)
        Me.bindingNavigatorMoveFirst.Text = "Move first"
        '
        'bindingNavigatorMovePrev
        '
        Me.bindingNavigatorMovePrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMovePrev.Name = "bindingNavigatorMovePrev"
        Me.bindingNavigatorMovePrev.RightToLeftAutoMirrorImage = True
        Me.bindingNavigatorMovePrev.Size = New System.Drawing.Size(23, 22)
        Me.bindingNavigatorMovePrev.Text = "Move previous"
        '
        'bindingNavigatorSep2
        '
        Me.bindingNavigatorSep2.Name = "bindingNavigatorSep2"
        Me.bindingNavigatorSep2.Size = New System.Drawing.Size(6, 25)
        '
        'bindingNavigatorPositionItem
        '
        Me.bindingNavigatorPositionItem.AccessibleName = "Position"
        Me.bindingNavigatorPositionItem.AutoSize = False
        Me.bindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem"
        Me.bindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.bindingNavigatorPositionItem.Text = "0"
        Me.bindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'bindingNavigatorCountItem
        '
        Me.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem"
        Me.bindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.bindingNavigatorCountItem.Text = "of {0}"
        Me.bindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'bindingNavigatorSep3
        '
        Me.bindingNavigatorSep3.Name = "bindingNavigatorSep3"
        Me.bindingNavigatorSep3.Size = New System.Drawing.Size(6, 25)
        '
        'bindingNavigatorMoveNext
        '
        Me.bindingNavigatorMoveNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMoveNext.Name = "bindingNavigatorMoveNext"
        Me.bindingNavigatorMoveNext.RightToLeftAutoMirrorImage = True
        Me.bindingNavigatorMoveNext.Size = New System.Drawing.Size(23, 22)
        Me.bindingNavigatorMoveNext.Text = "Move next"
        '
        'bindingNavigatorMoveLast
        '
        Me.bindingNavigatorMoveLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMoveLast.Name = "bindingNavigatorMoveLast"
        Me.bindingNavigatorMoveLast.RightToLeftAutoMirrorImage = True
        Me.bindingNavigatorMoveLast.Size = New System.Drawing.Size(23, 22)
        Me.bindingNavigatorMoveLast.Text = "Move last"
        '
        'bindingNavigatorSep4
        '
        Me.bindingNavigatorSep4.Name = "bindingNavigatorSep4"
        Me.bindingNavigatorSep4.Size = New System.Drawing.Size(6, 25)
        '
        'bindingNavigatorDeleteItem
        '
        Me.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem"
        Me.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.bindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.bindingNavigatorDeleteItem.Text = "Delete"
        '
        'lblGridTitle
        '
        Me.lblGridTitle.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblGridTitle.Name = "lblGridTitle"
        Me.lblGridTitle.Size = New System.Drawing.Size(149, 22)
        Me.lblGridTitle.Text = "Citizens database records"
        '
        'errCitizen
        '
        Me.errCitizen.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errCitizen.ContainerControl = Me
        '
        'dlgPhoto
        '
        Me.dlgPhoto.Filter = "Images|*.jpg;*.jpeg;*.png;*.bmp|All files|*.*"
        '
        'dlgPrint
        '
        Me.dlgPrint.UseEXDialog = True
        '
        'ctxGrid
        '
        Me.ctxGrid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniPreview, Me.mniPageSetup, Me.mniPrintDirect})
        Me.ctxGrid.Name = "ctxGrid"
        Me.ctxGrid.Size = New System.Drawing.Size(200, 70)
        '
        'mniPreview
        '
        Me.mniPreview.Name = "mniPreview"
        Me.mniPreview.Size = New System.Drawing.Size(199, 22)
        Me.mniPreview.Text = "Print Preview..."
        '
        'mniPageSetup
        '
        Me.mniPageSetup.Name = "mniPageSetup"
        Me.mniPageSetup.Size = New System.Drawing.Size(199, 22)
        Me.mniPageSetup.Text = "Page Setup..."
        '
        'mniPrintDirect
        '
        Me.mniPrintDirect.Name = "mniPrintDirect"
        Me.mniPrintDirect.Size = New System.Drawing.Size(199, 22)
        Me.mniPrintDirect.Text = "Print..."
        '
        'frmCitizen
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(238, 242, 239)
        Me.ClientSize = New System.Drawing.Size(1340, 620)
        Me.Controls.Add(Me.tabMain)
        Me.Controls.Add(Me.pnlGrid)
        Me.Controls.Add(Me.pnlActions)
        Me.Controls.Add(Me.pnlTitle)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "frmCitizen"
        Me.Text = "Citizen Registration"
        Me.pnlTitle.ResumeLayout(False)
        Me.pnlTitle.PerformLayout()
        Me.pnlActions.ResumeLayout(False)
        Me.pnlActions.PerformLayout()
        Me.tabMain.ResumeLayout(False)
        Me.tabPersonal.ResumeLayout(False)
        Me.grpDetails.ResumeLayout(False)
        Me.grpArea.ResumeLayout(False)
        Me.grpArea.PerformLayout()
        Me.grpIdentity.ResumeLayout(False)
        Me.grpIdentity.PerformLayout()
        Me.grpGender.ResumeLayout(False)
        Me.grpGender.PerformLayout()
        Me.tabAddress.ResumeLayout(False)
        Me.grpPermanent.ResumeLayout(False)
        Me.grpPermanent.PerformLayout()
        Me.grpPresent.ResumeLayout(False)
        Me.grpPresent.PerformLayout()
        Me.tabPhoto.ResumeLayout(False)
        Me.grpPhotoActions.ResumeLayout(False)
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabVerification.ResumeLayout(False)
        Me.tabVerification.PerformLayout()
        Me.grpNotes.ResumeLayout(False)
        Me.grpOffice.ResumeLayout(False)
        Me.grpOffice.PerformLayout()
        Me.pnlGrid.ResumeLayout(False)
        Me.pnlGrid.PerformLayout()
        CType(Me.gridCitizen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCitizens, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errCitizen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctxGrid.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents lblMode As System.Windows.Forms.Label
    Friend WithEvents pnlActions As System.Windows.Forms.Panel
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents lblFilter As System.Windows.Forms.Label
    Friend WithEvents txtFilter As System.Windows.Forms.TextBox
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents tabMain As System.Windows.Forms.TabControl
    Friend WithEvents tabPersonal As System.Windows.Forms.TabPage
    Friend WithEvents tabAddress As System.Windows.Forms.TabPage
    Friend WithEvents tabPhoto As System.Windows.Forms.TabPage
    Friend WithEvents tabVerification As System.Windows.Forms.TabPage
    Friend WithEvents grpIdentity As System.Windows.Forms.GroupBox
    Friend WithEvents lblCnic As System.Windows.Forms.Label
    Friend WithEvents mtbCnic As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnGenCnic As System.Windows.Forms.Button
    Friend WithEvents lblCnicStatus As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblFather As System.Windows.Forms.Label
    Friend WithEvents txtFather As System.Windows.Forms.TextBox
    Friend WithEvents grpGender As System.Windows.Forms.GroupBox
    Friend WithEvents radMale As System.Windows.Forms.RadioButton
    Friend WithEvents radFemale As System.Windows.Forms.RadioButton
    Friend WithEvents lblDob As System.Windows.Forms.Label
    Friend WithEvents dtDob As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblBlood As System.Windows.Forms.Label
    Friend WithEvents cmbBlood As System.Windows.Forms.ComboBox
    Friend WithEvents lblMarital As System.Windows.Forms.Label
    Friend WithEvents cmbMarital As System.Windows.Forms.ComboBox
    Friend WithEvents lblReligion As System.Windows.Forms.Label
    Friend WithEvents cmbReligion As System.Windows.Forms.ComboBox
    Friend WithEvents lblNationality As System.Windows.Forms.Label
    Friend WithEvents cmbNationality As System.Windows.Forms.ComboBox
    Friend WithEvents grpDetails As System.Windows.Forms.GroupBox
    Friend WithEvents lblEducation As System.Windows.Forms.Label
    Friend WithEvents cmbEducation As System.Windows.Forms.ComboBox
    Friend WithEvents lblOccupation As System.Windows.Forms.Label
    Friend WithEvents txtOccupation As System.Windows.Forms.TextBox
    Friend WithEvents grpArea As System.Windows.Forms.GroupBox
    Friend WithEvents radUrban As System.Windows.Forms.RadioButton
    Friend WithEvents radRural As System.Windows.Forms.RadioButton
    Friend WithEvents lblCreated As System.Windows.Forms.Label
    Friend WithEvents grpPresent As System.Windows.Forms.GroupBox
    Friend WithEvents lblPresentAddr As System.Windows.Forms.Label
    Friend WithEvents txtPresentAddr As System.Windows.Forms.TextBox
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents lblProvince As System.Windows.Forms.Label
    Friend WithEvents cmbProvince As System.Windows.Forms.ComboBox
    Friend WithEvents lblMobile As System.Windows.Forms.Label
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents grpPermanent As System.Windows.Forms.GroupBox
    Friend WithEvents chkSame As System.Windows.Forms.CheckBox
    Friend WithEvents lblPermAddr As System.Windows.Forms.Label
    Friend WithEvents txtPermAddr As System.Windows.Forms.TextBox
    Friend WithEvents lblPermNote As System.Windows.Forms.Label
    Friend WithEvents picPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents grpPhotoActions As System.Windows.Forms.GroupBox
    Friend WithEvents btnCapture As System.Windows.Forms.Button
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btnRemovePhoto As System.Windows.Forms.Button
    Friend WithEvents lblPhotoPath As System.Windows.Forms.Label
    Friend WithEvents lblPhotoTip As System.Windows.Forms.Label
    Friend WithEvents lblDocs As System.Windows.Forms.Label
    Friend WithEvents chkDocs As System.Windows.Forms.CheckedListBox
    Friend WithEvents grpOffice As System.Windows.Forms.GroupBox
    Friend WithEvents lblOffice As System.Windows.Forms.Label
    Friend WithEvents cmbOffice As System.Windows.Forms.ComboBox
    Friend WithEvents lblIssue As System.Windows.Forms.Label
    Friend WithEvents dtIssue As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblExpiry As System.Windows.Forms.Label
    Friend WithEvents dtExpiry As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkVerified As System.Windows.Forms.CheckBox
    Friend WithEvents grpNotes As System.Windows.Forms.GroupBox
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents txtNotes As System.Windows.Forms.RichTextBox
    Friend WithEvents lblAudit As System.Windows.Forms.Label
    Friend WithEvents pnlGrid As System.Windows.Forms.Panel
    Friend WithEvents gridCitizen As System.Windows.Forms.DataGridView
    Friend WithEvents bindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents bsCitizens As System.Windows.Forms.BindingSource
    Friend WithEvents bindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorSep1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bindingNavigatorMoveFirst As System.Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorMovePrev As System.Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorSep2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents bindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents bindingNavigatorSep3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bindingNavigatorMoveNext As System.Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorMoveLast As System.Windows.Forms.ToolStripButton
    Friend WithEvents bindingNavigatorSep4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblGridTitle As System.Windows.Forms.ToolStripLabel
    Friend WithEvents errCitizen As System.Windows.Forms.ErrorProvider
    Friend WithEvents dlgPhoto As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dlgPrint As System.Windows.Forms.PrintDialog
    Friend WithEvents dlgPageSetup As System.Windows.Forms.PageSetupDialog
    Friend WithEvents ctxGrid As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mniPreview As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniPageSetup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniPrintDirect As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tipCitizen As System.Windows.Forms.ToolTip

End Class
