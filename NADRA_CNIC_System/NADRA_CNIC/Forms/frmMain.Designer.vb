<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mniBackupFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniRestoreFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniSep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mniExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRegistration = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniRegister = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniSep3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mniPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniVerifyCnic = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMedia = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniVisual = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniCapture = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReports = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniStats = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDatabase = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniIntegrity = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniSep4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mniBackupDb = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniRestoreDb = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniFull = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindow = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniCascade = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniTileH = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniTileV = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniMinAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.tsbNew = New System.Windows.Forms.ToolStripButton()
        Me.tsbSearch = New System.Windows.Forms.ToolStripButton()
        Me.tsbVisual = New System.Windows.Forms.ToolStripButton()
        Me.tsbStats = New System.Windows.Forms.ToolStripButton()
        Me.tsbSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbBackup = New System.Windows.Forms.ToolStripButton()
        Me.tsbPrint = New System.Windows.Forms.ToolStripButton()
        Me.tsbSep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbFull = New System.Windows.Forms.ToolStripButton()
        Me.tsbAbout = New System.Windows.Forms.ToolStripButton()
        Me.stStatus = New System.Windows.Forms.StatusStrip()
        Me.stsUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsProvider = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsDb = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsClock = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnFull = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblOfficer = New System.Windows.Forms.Label()
        Me.lblTag = New System.Windows.Forms.Label()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.splNav = New System.Windows.Forms.Splitter()
        Me.pnlNav = New System.Windows.Forms.Panel()
        Me.grpNav = New System.Windows.Forms.GroupBox()
        Me.tvNav = New System.Windows.Forms.TreeView()
        Me.imgNav = New System.Windows.Forms.ImageList(Me.components)
        Me.grpQuick = New System.Windows.Forms.GroupBox()
        Me.lblVerifyResult = New System.Windows.Forms.Label()
        Me.btnVerify = New System.Windows.Forms.Button()
        Me.btnQuickSearch = New System.Windows.Forms.Button()
        Me.txtQuickName = New System.Windows.Forms.TextBox()
        Me.lblQuickName = New System.Windows.Forms.Label()
        Me.mtbQuick = New System.Windows.Forms.MaskedTextBox()
        Me.lblQuickCnic = New System.Windows.Forms.Label()
        Me.lnkDataFolder = New System.Windows.Forms.LinkLabel()
        Me.lblDbFile = New System.Windows.Forms.Label()
        Me.tmrClock = New System.Windows.Forms.Timer(Me.components)
        Me.ntiTray = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ctxTray = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mniTrayOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniTrayExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.dlgBackup = New System.Windows.Forms.SaveFileDialog()
        Me.dlgRestore = New System.Windows.Forms.OpenFileDialog()
        Me.tipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.IsMdiContainer = True
        Me.mnuMain.SuspendLayout()
        Me.tsMain.SuspendLayout()
        Me.stStatus.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNav.SuspendLayout()
        Me.grpNav.SuspendLayout()
        Me.grpQuick.SuspendLayout()
        Me.ctxTray.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuRegistration, Me.mnuMedia, Me.mnuReports, Me.mnuDatabase, Me.mnuView, Me.mnuWindow, Me.mnuHelp})
        Me.mnuMain.Location = New System.Drawing.Point(0, 92)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(1360, 24)
        Me.mnuMain.TabIndex = 1
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniNew, Me.mniSep1, Me.mniBackupFile, Me.mniRestoreFile, Me.mniSep2, Me.mniExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mniNew
        '
        Me.mniNew.Name = "mniNew"
        Me.mniNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mniNew.Size = New System.Drawing.Size(210, 22)
        Me.mniNew.Text = "&New Citizen"
        '
        'mniSep1
        '
        Me.mniSep1.Name = "mniSep1"
        Me.mniSep1.Size = New System.Drawing.Size(207, 6)
        '
        'mniBackupFile
        '
        Me.mniBackupFile.Name = "mniBackupFile"
        Me.mniBackupFile.Size = New System.Drawing.Size(210, 22)
        Me.mniBackupFile.Text = "Backup Database..."
        '
        'mniRestoreFile
        '
        Me.mniRestoreFile.Name = "mniRestoreFile"
        Me.mniRestoreFile.Size = New System.Drawing.Size(210, 22)
        Me.mniRestoreFile.Text = "Restore Database..."
        '
        'mniSep2
        '
        Me.mniSep2.Name = "mniSep2"
        Me.mniSep2.Size = New System.Drawing.Size(207, 6)
        '
        'mniExit
        '
        Me.mniExit.Name = "mniExit"
        Me.mniExit.Size = New System.Drawing.Size(210, 22)
        Me.mniExit.Text = "E&xit"
        '
        'mnuRegistration
        '
        Me.mnuRegistration.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniRegister, Me.mniSearch, Me.mniSep3, Me.mniPrint, Me.mniVerifyCnic})
        Me.mnuRegistration.Name = "mnuRegistration"
        Me.mnuRegistration.Size = New System.Drawing.Size(87, 20)
        Me.mnuRegistration.Text = "&Registration"
        '
        'mniRegister
        '
        Me.mniRegister.Name = "mniRegister"
        Me.mniRegister.Size = New System.Drawing.Size(230, 22)
        Me.mniRegister.Text = "&Register New Citizen"
        '
        'mniSearch
        '
        Me.mniSearch.Name = "mniSearch"
        Me.mniSearch.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.mniSearch.Size = New System.Drawing.Size(230, 22)
        Me.mniSearch.Text = "Search / Records"
        '
        'mniSep3
        '
        Me.mniSep3.Name = "mniSep3"
        Me.mniSep3.Size = New System.Drawing.Size(227, 6)
        '
        'mniPrint
        '
        Me.mniPrint.Name = "mniPrint"
        Me.mniPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mniPrint.Size = New System.Drawing.Size(230, 22)
        Me.mniPrint.Text = "Print Identity Card"
        '
        'mniVerifyCnic
        '
        Me.mniVerifyCnic.Name = "mniVerifyCnic"
        Me.mniVerifyCnic.Size = New System.Drawing.Size(230, 22)
        Me.mniVerifyCnic.Text = "Verify CNIC Check Digit"
        '
        'mnuMedia
        '
        Me.mnuMedia.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniVisual, Me.mniCapture})
        Me.mnuMedia.Name = "mnuMedia"
        Me.mnuMedia.Size = New System.Drawing.Size(116, 20)
        Me.mnuMedia.Text = "&OpenCV && Visuals"
        '
        'mniVisual
        '
        Me.mniVisual.Name = "mniVisual"
        Me.mniVisual.Size = New System.Drawing.Size(240, 22)
        Me.mniVisual.Text = "Visual Effects Lab (OpenCV)"
        '
        'mniCapture
        '
        Me.mniCapture.Name = "mniCapture"
        Me.mniCapture.Size = New System.Drawing.Size(240, 22)
        Me.mniCapture.Text = "Capture Citizen Photo..."
        '
        'mnuReports
        '
        Me.mnuReports.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniStats})
        Me.mnuReports.Name = "mnuReports"
        Me.mnuReports.Size = New System.Drawing.Size(66, 20)
        Me.mnuReports.Text = "&Reports"
        '
        'mniStats
        '
        Me.mniStats.Name = "mniStats"
        Me.mniStats.Size = New System.Drawing.Size(186, 22)
        Me.mniStats.Text = "Statistics && Charts"
        '
        'mnuDatabase
        '
        Me.mnuDatabase.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniIntegrity, Me.mniSep4, Me.mniBackupDb, Me.mniRestoreDb})
        Me.mnuDatabase.Name = "mnuDatabase"
        Me.mnuDatabase.Size = New System.Drawing.Size(72, 20)
        Me.mnuDatabase.Text = "&Database"
        '
        'mniIntegrity
        '
        Me.mniIntegrity.Name = "mniIntegrity"
        Me.mniIntegrity.Size = New System.Drawing.Size(200, 22)
        Me.mniIntegrity.Text = "Check Integrity"
        '
        'mniSep4
        '
        Me.mniSep4.Name = "mniSep4"
        Me.mniSep4.Size = New System.Drawing.Size(197, 6)
        '
        'mniBackupDb
        '
        Me.mniBackupDb.Name = "mniBackupDb"
        Me.mniBackupDb.Size = New System.Drawing.Size(200, 22)
        Me.mniBackupDb.Text = "Backup..."
        '
        'mniRestoreDb
        '
        Me.mniRestoreDb.Name = "mniRestoreDb"
        Me.mniRestoreDb.Size = New System.Drawing.Size(200, 22)
        Me.mniRestoreDb.Text = "Restore..."
        '
        'mnuView
        '
        Me.mnuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniRefresh, Me.mniFull})
        Me.mnuView.Name = "mnuView"
        Me.mnuView.Size = New System.Drawing.Size(44, 20)
        Me.mnuView.Text = "&View"
        '
        'mniRefresh
        '
        Me.mniRefresh.Name = "mniRefresh"
        Me.mniRefresh.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.mniRefresh.Size = New System.Drawing.Size(180, 22)
        Me.mniRefresh.Text = "Refresh"
        '
        'mniFull
        '
        Me.mniFull.Name = "mniFull"
        Me.mniFull.ShortcutKeys = System.Windows.Forms.Keys.F11
        Me.mniFull.Size = New System.Drawing.Size(180, 22)
        Me.mniFull.Text = "Full Screen"
        '
        'mnuWindow
        '
        Me.mnuWindow.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniCascade, Me.mniTileH, Me.mniTileV, Me.mniMinAll})
        Me.mnuWindow.Name = "mnuWindow"
        Me.mnuWindow.Size = New System.Drawing.Size(68, 20)
        Me.mnuWindow.Text = "&Window"
        '
        'mniCascade
        '
        Me.mniCascade.Name = "mniCascade"
        Me.mniCascade.Size = New System.Drawing.Size(150, 22)
        Me.mniCascade.Text = "Cascade"
        '
        'mniTileH
        '
        Me.mniTileH.Name = "mniTileH"
        Me.mniTileH.Size = New System.Drawing.Size(150, 22)
        Me.mniTileH.Text = "Tile Horizontal"
        '
        'mniTileV
        '
        Me.mniTileV.Name = "mniTileV"
        Me.mniTileV.Size = New System.Drawing.Size(150, 22)
        Me.mniTileV.Text = "Tile Vertical"
        '
        'mniMinAll
        '
        Me.mniMinAll.Name = "mniMinAll"
        Me.mniMinAll.Size = New System.Drawing.Size(150, 22)
        Me.mniMinAll.Text = "Minimize All"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "&Help"
        '
        'mniAbout
        '
        Me.mniAbout.Name = "mniAbout"
        Me.mniAbout.Size = New System.Drawing.Size(180, 22)
        Me.mniAbout.Text = "About / Project Details"
        '
        'tsMain
        '
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNew, Me.tsbSearch, Me.tsbVisual, Me.tsbStats, Me.tsbSep1, Me.tsbBackup, Me.tsbPrint, Me.tsbSep2, Me.tsbFull, Me.tsbAbout})
        Me.tsMain.Location = New System.Drawing.Point(0, 116)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(1360, 32)
        Me.tsMain.TabIndex = 2
        '
        'tsbNew
        '
        Me.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbNew.Name = "tsbNew"
        Me.tsbNew.Size = New System.Drawing.Size(23, 29)
        Me.tsbNew.Text = "New Citizen"
        '
        'tsbSearch
        '
        Me.tsbSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSearch.Name = "tsbSearch"
        Me.tsbSearch.Size = New System.Drawing.Size(23, 29)
        Me.tsbSearch.Text = "Search"
        '
        'tsbVisual
        '
        Me.tsbVisual.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbVisual.Name = "tsbVisual"
        Me.tsbVisual.Size = New System.Drawing.Size(23, 29)
        Me.tsbVisual.Text = "Visual Effects Lab"
        '
        'tsbStats
        '
        Me.tsbStats.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbStats.Name = "tsbStats"
        Me.tsbStats.Size = New System.Drawing.Size(23, 29)
        Me.tsbStats.Text = "Statistics"
        '
        'tsbSep1
        '
        Me.tsbSep1.Name = "tsbSep1"
        Me.tsbSep1.Size = New System.Drawing.Size(6, 32)
        '
        'tsbBackup
        '
        Me.tsbBackup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbBackup.Name = "tsbBackup"
        Me.tsbBackup.Size = New System.Drawing.Size(23, 29)
        Me.tsbBackup.Text = "Backup Database"
        '
        'tsbPrint
        '
        Me.tsbPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbPrint.Name = "tsbPrint"
        Me.tsbPrint.Size = New System.Drawing.Size(23, 29)
        Me.tsbPrint.Text = "Print Identity Card"
        '
        'tsbSep2
        '
        Me.tsbSep2.Name = "tsbSep2"
        Me.tsbSep2.Size = New System.Drawing.Size(6, 32)
        '
        'tsbFull
        '
        Me.tsbFull.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbFull.Name = "tsbFull"
        Me.tsbFull.Size = New System.Drawing.Size(23, 29)
        Me.tsbFull.Text = "Full Screen"
        '
        'tsbAbout
        '
        Me.tsbAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAbout.Name = "tsbAbout"
        Me.tsbAbout.Size = New System.Drawing.Size(23, 29)
        Me.tsbAbout.Text = "About"
        '
        'stStatus
        '
        Me.stStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stsUser, Me.stsCount, Me.stsProvider, Me.stsDb, Me.stsClock})
        Me.stStatus.Location = New System.Drawing.Point(0, 738)
        Me.stStatus.Name = "stStatus"
        Me.stStatus.Size = New System.Drawing.Size(1360, 22)
        Me.stStatus.TabIndex = 3
        '
        'stsUser
        '
        Me.stsUser.Name = "stsUser"
        Me.stsUser.Size = New System.Drawing.Size(118, 17)
        Me.stsUser.Spring = True
        Me.stsUser.Text = "Officer"
        Me.stsUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'stsCount
        '
        Me.stsCount.Name = "stsCount"
        Me.stsCount.Size = New System.Drawing.Size(110, 17)
        Me.stsCount.Text = "Citizens: 0"
        '
        'stsProvider
        '
        Me.stsProvider.Name = "stsProvider"
        Me.stsProvider.Size = New System.Drawing.Size(140, 17)
        Me.stsProvider.Text = "Provider: -"
        '
        'stsDb
        '
        Me.stsDb.IsLink = True
        Me.stsDb.Name = "stsDb"
        Me.stsDb.Size = New System.Drawing.Size(70, 17)
        Me.stsDb.Text = "Database"
        '
        'stsClock
        '
        Me.stsClock.Name = "stsClock"
        Me.stsClock.Size = New System.Drawing.Size(65, 17)
        Me.stsClock.Text = "00:00:00"
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(1, 65, 28)
        Me.pnlHeader.Controls.Add(Me.btnFull)
        Me.pnlHeader.Controls.Add(Me.btnLogout)
        Me.pnlHeader.Controls.Add(Me.lblDate)
        Me.pnlHeader.Controls.Add(Me.lblOfficer)
        Me.pnlHeader.Controls.Add(Me.lblTag)
        Me.pnlHeader.Controls.Add(Me.lblBrand)
        Me.pnlHeader.Controls.Add(Me.picLogo)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1360, 92)
        Me.pnlHeader.TabIndex = 0
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Location = New System.Drawing.Point(16, 11)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(70, 70)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'lblBrand
        '
        Me.lblBrand.AutoSize = True
        Me.lblBrand.BackColor = System.Drawing.Color.Transparent
        Me.lblBrand.Font = New System.Drawing.Font("Segoe UI", 19.0!, System.Drawing.FontStyle.Bold)
        Me.lblBrand.ForeColor = System.Drawing.Color.White
        Me.lblBrand.Location = New System.Drawing.Point(98, 11)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(167, 34)
        Me.lblBrand.TabIndex = 1
        Me.lblBrand.Text = "N A D R A"
        '
        'lblTag
        '
        Me.lblTag.AutoSize = True
        Me.lblTag.BackColor = System.Drawing.Color.Transparent
        Me.lblTag.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTag.ForeColor = System.Drawing.Color.FromArgb(205, 225, 212)
        Me.lblTag.Location = New System.Drawing.Point(102, 50)
        Me.lblTag.Name = "lblTag"
        Me.lblTag.Size = New System.Drawing.Size(403, 15)
        Me.lblTag.TabIndex = 2
        Me.lblTag.Text = "National Database && Registration Authority  |  Government of Pakistan"
        '
        'lblOfficer
        '
        Me.lblOfficer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOfficer.BackColor = System.Drawing.Color.Transparent
        Me.lblOfficer.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblOfficer.ForeColor = System.Drawing.Color.White
        Me.lblOfficer.Location = New System.Drawing.Point(760, 14)
        Me.lblOfficer.Name = "lblOfficer"
        Me.lblOfficer.Size = New System.Drawing.Size(420, 20)
        Me.lblOfficer.TabIndex = 3
        Me.lblOfficer.Text = "Officer:"
        Me.lblOfficer.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblDate
        '
        Me.lblDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(218, 185, 60)
        Me.lblDate.Location = New System.Drawing.Point(760, 40)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(420, 18)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = ""
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(218, 185, 60)
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(1186, 14)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(78, 26)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnFull
        '
        Me.btnFull.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFull.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(218, 185, 60)
        Me.btnFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFull.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.btnFull.ForeColor = System.Drawing.Color.White
        Me.btnFull.Location = New System.Drawing.Point(1270, 14)
        Me.btnFull.Name = "btnFull"
        Me.btnFull.Size = New System.Drawing.Size(78, 26)
        Me.btnFull.TabIndex = 6
        Me.btnFull.Text = "Full Screen"
        Me.btnFull.UseVisualStyleBackColor = True
        '
        'splNav
        '
        Me.splNav.BackColor = System.Drawing.Color.FromArgb(218, 185, 60)
        Me.splNav.Dock = System.Windows.Forms.DockStyle.Left
        Me.splNav.Location = New System.Drawing.Point(0, 148)
        Me.splNav.MinExtra = 240
        Me.splNav.MinSize = 240
        Me.splNav.Name = "splNav"
        Me.splNav.Size = New System.Drawing.Size(5, 590)
        Me.splNav.TabIndex = 4
        Me.splNav.TabStop = False
        '
        'pnlNav
        '
        Me.pnlNav.BackColor = System.Drawing.Color.White
        Me.pnlNav.Controls.Add(Me.grpNav)
        Me.pnlNav.Controls.Add(Me.grpQuick)
        Me.pnlNav.Controls.Add(Me.lnkDataFolder)
        Me.pnlNav.Controls.Add(Me.lblDbFile)
        Me.pnlNav.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlNav.Location = New System.Drawing.Point(0, 148)
        Me.pnlNav.Name = "pnlNav"
        Me.pnlNav.Size = New System.Drawing.Size(300, 590)
        Me.pnlNav.TabIndex = 5
        '
        'grpQuick
        '
        Me.grpQuick.Controls.Add(Me.lblVerifyResult)
        Me.grpQuick.Controls.Add(Me.btnVerify)
        Me.grpQuick.Controls.Add(Me.btnQuickSearch)
        Me.grpQuick.Controls.Add(Me.txtQuickName)
        Me.grpQuick.Controls.Add(Me.lblQuickName)
        Me.grpQuick.Controls.Add(Me.mtbQuick)
        Me.grpQuick.Controls.Add(Me.lblQuickCnic)
        Me.grpQuick.Location = New System.Drawing.Point(10, 8)
        Me.grpQuick.Name = "grpQuick"
        Me.grpQuick.Size = New System.Drawing.Size(280, 190)
        Me.grpQuick.TabIndex = 0
        Me.grpQuick.TabStop = False
        Me.grpQuick.Text = "Quick Search / Verify"
        '
        'lblQuickCnic
        '
        Me.lblQuickCnic.AutoSize = True
        Me.lblQuickCnic.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblQuickCnic.ForeColor = System.Drawing.Color.FromArgb(28, 40, 33)
        Me.lblQuickCnic.Location = New System.Drawing.Point(12, 24)
        Me.lblQuickCnic.Name = "lblQuickCnic"
        Me.lblQuickCnic.Size = New System.Drawing.Size(97, 15)
        Me.lblQuickCnic.TabIndex = 0
        Me.lblQuickCnic.Text = "CNIC number:"
        '
        'mtbQuick
        '
        Me.mtbQuick.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.mtbQuick.Location = New System.Drawing.Point(15, 44)
        Me.mtbQuick.Mask = "00000\-0000000-0"
        Me.mtbQuick.Name = "mtbQuick"
        Me.mtbQuick.Size = New System.Drawing.Size(250, 25)
        Me.mtbQuick.TabIndex = 1
        '
        'lblQuickName
        '
        Me.lblQuickName.AutoSize = True
        Me.lblQuickName.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblQuickName.ForeColor = System.Drawing.Color.FromArgb(28, 40, 33)
        Me.lblQuickName.Location = New System.Drawing.Point(12, 76)
        Me.lblQuickName.Name = "lblQuickName"
        Me.lblQuickName.Size = New System.Drawing.Size(126, 15)
        Me.lblQuickName.TabIndex = 2
        Me.lblQuickName.Text = "Name / City / Province:"
        '
        'txtQuickName
        '
        Me.txtQuickName.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtQuickName.Location = New System.Drawing.Point(15, 96)
        Me.txtQuickName.Name = "txtQuickName"
        Me.txtQuickName.Size = New System.Drawing.Size(250, 25)
        Me.txtQuickName.TabIndex = 3
        '
        'btnQuickSearch
        '
        Me.btnQuickSearch.BackColor = System.Drawing.Color.FromArgb(0, 105, 62)
        Me.btnQuickSearch.FlatAppearance.BorderSize = 0
        Me.btnQuickSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuickSearch.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.btnQuickSearch.ForeColor = System.Drawing.Color.White
        Me.btnQuickSearch.Location = New System.Drawing.Point(15, 130)
        Me.btnQuickSearch.Name = "btnQuickSearch"
        Me.btnQuickSearch.Size = New System.Drawing.Size(118, 28)
        Me.btnQuickSearch.TabIndex = 4
        Me.btnQuickSearch.Text = "Search Records"
        Me.btnQuickSearch.UseVisualStyleBackColor = False
        '
        'btnVerify
        '
        Me.btnVerify.BackColor = System.Drawing.Color.White
        Me.btnVerify.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 105, 62)
        Me.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerify.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.btnVerify.ForeColor = System.Drawing.Color.FromArgb(1, 65, 28)
        Me.btnVerify.Location = New System.Drawing.Point(147, 130)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(118, 28)
        Me.btnVerify.TabIndex = 5
        Me.btnVerify.Text = "Verify Check Digit"
        Me.btnVerify.UseVisualStyleBackColor = False
        '
        'lblVerifyResult
        '
        Me.lblVerifyResult.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblVerifyResult.ForeColor = System.Drawing.Color.FromArgb(0, 105, 62)
        Me.lblVerifyResult.Location = New System.Drawing.Point(15, 165)
        Me.lblVerifyResult.Name = "lblVerifyResult"
        Me.lblVerifyResult.Size = New System.Drawing.Size(256, 16)
        Me.lblVerifyResult.TabIndex = 6
        Me.lblVerifyResult.Text = ""
        '
        'grpNav
        '
        Me.grpNav.Controls.Add(Me.tvNav)
        Me.grpNav.Location = New System.Drawing.Point(10, 206)
        Me.grpNav.Name = "grpNav"
        Me.grpNav.Size = New System.Drawing.Size(280, 320)
        Me.grpNav.TabIndex = 1
        Me.grpNav.TabStop = False
        Me.grpNav.Text = "Navigation"
        '
        'tvNav
        '
        Me.tvNav.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tvNav.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvNav.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.tvNav.FullRowSelect = True
        Me.tvNav.ImageList = Me.imgNav
        Me.tvNav.Location = New System.Drawing.Point(3, 19)
        Me.tvNav.Name = "tvNav"
        Me.tvNav.PathSeparator = "|"
        Me.tvNav.ShowLines = False
        Me.tvNav.ShowRootLines = False
        Me.tvNav.Size = New System.Drawing.Size(274, 320)
        Me.tvNav.TabIndex = 0
        '
        'imgNav
        '
        Me.imgNav.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.imgNav.ImageSize = New System.Drawing.Size(20, 20)
        Me.imgNav.TransparentColor = System.Drawing.Color.Transparent
        '
        'lnkDataFolder
        '
        Me.lnkDataFolder.AutoSize = True
        Me.lnkDataFolder.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lnkDataFolder.LinkColor = System.Drawing.Color.FromArgb(0, 105, 62)
        Me.lnkDataFolder.Location = New System.Drawing.Point(14, 572)
        Me.lnkDataFolder.Name = "lnkDataFolder"
        Me.lnkDataFolder.Size = New System.Drawing.Size(124, 13)
        Me.lnkDataFolder.TabIndex = 3
        Me.lnkDataFolder.TabStop = True
        Me.lnkDataFolder.Text = "Open data folder..."
        '
        'lblDbFile
        '
        Me.lblDbFile.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.lblDbFile.ForeColor = System.Drawing.Color.FromArgb(90, 110, 98)
        Me.lblDbFile.Location = New System.Drawing.Point(12, 534)
        Me.lblDbFile.Name = "lblDbFile"
        Me.lblDbFile.Size = New System.Drawing.Size(276, 36)
        Me.lblDbFile.TabIndex = 2
        Me.lblDbFile.Text = "Database:"
        '
        'tmrClock
        '
        Me.tmrClock.Enabled = True
        Me.tmrClock.Interval = 1000
        '
        'ntiTray
        '
        Me.ntiTray.ContextMenuStrip = Me.ctxTray
        Me.ntiTray.Text = "NADRA CNIC System"
        Me.ntiTray.Visible = True
        '
        'ctxTray
        '
        Me.ctxTray.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniTrayOpen, Me.mniTrayExit})
        Me.ctxTray.Name = "ctxTray"
        Me.ctxTray.Size = New System.Drawing.Size(180, 48)
        '
        'mniTrayOpen
        '
        Me.mniTrayOpen.Name = "mniTrayOpen"
        Me.mniTrayOpen.Size = New System.Drawing.Size(179, 22)
        Me.mniTrayOpen.Text = "Open NADRA System"
        '
        'mniTrayExit
        '
        Me.mniTrayExit.Name = "mniTrayExit"
        Me.mniTrayExit.Size = New System.Drawing.Size(179, 22)
        Me.mniTrayExit.Text = "Exit"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(238, 242, 239)
        Me.ClientSize = New System.Drawing.Size(1360, 760)
        Me.Controls.Add(Me.splNav)
        Me.Controls.Add(Me.pnlNav)
        Me.Controls.Add(Me.stStatus)
        Me.Controls.Add(Me.tsMain)
        Me.Controls.Add(Me.mnuMain)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NADRA - National Database & Registration Authority"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        Me.stStatus.ResumeLayout(False)
        Me.stStatus.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNav.ResumeLayout(False)
        Me.pnlNav.PerformLayout()
        Me.grpNav.ResumeLayout(False)
        Me.grpQuick.ResumeLayout(False)
        Me.grpQuick.PerformLayout()
        Me.ctxTray.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniSep1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mniBackupFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniRestoreFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniSep2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mniExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRegistration As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniRegister As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniSearch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniSep3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mniPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniVerifyCnic As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMedia As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniVisual As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniCapture As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReports As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniStats As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDatabase As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniIntegrity As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniSep4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mniBackupDb As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniRestoreDb As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniFull As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuWindow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniCascade As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniTileH As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniTileV As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniMinAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsMain As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbVisual As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbStats As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSep1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbBackup As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSep2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbFull As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbAbout As System.Windows.Forms.ToolStripButton
    Friend WithEvents stStatus As System.Windows.Forms.StatusStrip
    Friend WithEvents stsUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stsCount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stsProvider As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stsDb As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stsClock As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblBrand As System.Windows.Forms.Label
    Friend WithEvents lblTag As System.Windows.Forms.Label
    Friend WithEvents lblOfficer As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnFull As System.Windows.Forms.Button
    Friend WithEvents splNav As System.Windows.Forms.Splitter
    Friend WithEvents pnlNav As System.Windows.Forms.Panel
    Friend WithEvents grpQuick As System.Windows.Forms.GroupBox
    Friend WithEvents lblQuickCnic As System.Windows.Forms.Label
    Friend WithEvents mtbQuick As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblQuickName As System.Windows.Forms.Label
    Friend WithEvents txtQuickName As System.Windows.Forms.TextBox
    Friend WithEvents btnQuickSearch As System.Windows.Forms.Button
    Friend WithEvents btnVerify As System.Windows.Forms.Button
    Friend WithEvents lblVerifyResult As System.Windows.Forms.Label
    Friend WithEvents grpNav As System.Windows.Forms.GroupBox
    Friend WithEvents tvNav As System.Windows.Forms.TreeView
    Friend WithEvents imgNav As System.Windows.Forms.ImageList
    Friend WithEvents lnkDataFolder As System.Windows.Forms.LinkLabel
    Friend WithEvents lblDbFile As System.Windows.Forms.Label
    Friend WithEvents tmrClock As System.Windows.Forms.Timer
    Friend WithEvents ntiTray As System.Windows.Forms.NotifyIcon
    Friend WithEvents ctxTray As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mniTrayOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniTrayExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dlgBackup As System.Windows.Forms.SaveFileDialog
    Friend WithEvents dlgRestore As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tipMain As System.Windows.Forms.ToolTip

End Class
