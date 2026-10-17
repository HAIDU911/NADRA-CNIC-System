Imports System.Diagnostics
Imports System.Windows.Forms

''' <summary>
''' Full screen MDI parent window of the NADRA system.
''' Green corporate header with logo, menu strip, tool strip, status strip,
''' navigation tree, quick search / CNIC verifier, notification icon and the
''' full screen (F11) toggle. Child windows open maximised inside it.
''' </summary>
Public Class frmMain

    Private _fullScreen As Boolean = False
    Private _savedBorder As FormBorderStyle = FormBorderStyle.Sizable

    ' ------------------------------------------------------------------ start-up

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiTheme.ApplyToolStripTheme(mnuMain)
        UiTheme.ApplyToolStripTheme(tsMain)
        UiTheme.ApplyToolStripTheme(stStatus)
        UiTheme.StyleGroup(grpQuick)
        UiTheme.StyleGroup(grpNav)

        picLogo.Image = UiTheme.MakeLogo(70)
        Icon = UiTheme.MakeWindowIcon()
        ntiTray.Icon = UiTheme.MakeWindowIcon()
        ntiTray.Text = "NADRA CNIC System"

        tsMain.ImageScalingSize = New Size(22, 22)
        SetupIcons()
        SetupNavigation()

        ' officer + database information
        lblOfficer.Text = "Signed in: " & Session.UserLabel
        stsUser.Text = "Signed in: " & Session.UserLabel & "   |   Login: " & Session.LoginAt.ToString("HH:mm")
        stsProvider.Text = "Provider: " & Db.ProviderName
        stsDb.Text = " DB: " & IO.Path.GetFileName(AppPaths.DatabaseFile)
        ' let the labels size to their text so the clock never overlaps the DB link
        For Each item As ToolStripItem In {stsUser, stsCount, stsProvider, stsDb, stsClock}
            item.AutoSize = True
        Next
        lblDbFile.Text = "Database:" & vbCrLf & AppPaths.DatabaseFile
        stsDb.ToolTipText = AppPaths.DatabaseFile
        stsProvider.ToolTipText = "Microsoft Access OLE DB provider in use"

        RefreshCounts()
        lblDate.Text = Now.ToString("dddd, d MMMM yyyy")

        ' start on the dashboard
        ShowChild(Of frmDashboard)()

        ntiTray.ShowBalloonTip(3000, "NADRA CNIC System",
                               "Signed in as " & Session.UserLabel & vbCrLf &
                               "Press F11 for full screen mode.", ToolTipIcon.Info)
    End Sub

    Private Sub SetupIcons()
        mniNew.Image = UiTheme.MakeIcon("new", 18)
        mniBackupFile.Image = UiTheme.MakeIcon("backup", 18)
        mniRestoreFile.Image = UiTheme.MakeIcon("backup", 18)
        mniExit.Image = UiTheme.MakeIcon("exit", 18)
        mniRegister.Image = UiTheme.MakeIcon("new", 18)
        mniSearch.Image = UiTheme.MakeIcon("search", 18)
        mniPrint.Image = UiTheme.MakeIcon("print", 18)
        mniVerifyCnic.Image = UiTheme.MakeIcon("verify", 18)
        mniVisual.Image = UiTheme.MakeIcon("camera", 18)
        mniCapture.Image = UiTheme.MakeIcon("image", 18)
        mniStats.Image = UiTheme.MakeIcon("chart", 18)
        mniIntegrity.Image = UiTheme.MakeIcon("database", 18)
        mniBackupDb.Image = UiTheme.MakeIcon("backup", 18)
        mniRestoreDb.Image = UiTheme.MakeIcon("backup", 18)
        mniRefresh.Image = UiTheme.MakeIcon("refresh", 18)
        mniFull.Image = UiTheme.MakeIcon("fullscreen", 18)
        mniAbout.Image = UiTheme.MakeIcon("info", 18)

        tsbNew.Image = UiTheme.MakeIcon("new")
        tsbSearch.Image = UiTheme.MakeIcon("search")
        tsbVisual.Image = UiTheme.MakeIcon("camera")
        tsbStats.Image = UiTheme.MakeIcon("chart")
        tsbBackup.Image = UiTheme.MakeIcon("backup")
        tsbPrint.Image = UiTheme.MakeIcon("print")
        tsbFull.Image = UiTheme.MakeIcon("fullscreen")
        tsbAbout.Image = UiTheme.MakeIcon("info")
    End Sub

    Private Sub SetupNavigation()
        For Each key As String In {"home", "new", "search", "print", "verify", "camera", "image",
                                   "chart", "database", "backup", "info", "refresh", "fullscreen"}
            imgNav.Images.Add(key, UiTheme.MakeIcon(key, 20))
        Next

        tvNav.Nodes.Clear()
        Dim home As TreeNode = AddNavNode(Nothing, "home", "Dashboard", "dashboard")

        Dim citizens As TreeNode = AddNavNode(Nothing, "verify", "Citizens", "register")
        AddNavNode(citizens, "new", "Register New Citizen", "register")
        AddNavNode(citizens, "search", "Search / Records", "search")
        AddNavNode(citizens, "print", "Print Identity Card", "print")
        AddNavNode(citizens, "verify", "Verify CNIC", "verify")

        Dim media As TreeNode = AddNavNode(Nothing, "camera", "OpenCV Visuals", "visual")
        AddNavNode(media, "camera", "Visual Effects Lab", "visual")
        AddNavNode(media, "image", "Capture Citizen Photo", "capture")

        AddNavNode(Nothing, "chart", "Statistics && Charts", "stats")

        Dim dbNode As TreeNode = AddNavNode(Nothing, "database", "Database", "integrity")
        AddNavNode(dbNode, "backup", "Backup / Restore", "backup")
        AddNavNode(dbNode, "verify", "Integrity Check", "integrity")

        AddNavNode(Nothing, "info", "About Project", "about")

        tvNav.ExpandAll()
        tvNav.SelectedNode = home
    End Sub

    Private Function AddNavNode(parent As TreeNode, key As String, text As String, tag As String) As TreeNode
        Dim node As New TreeNode(text)
        node.ImageKey = key
        node.SelectedImageKey = key
        node.Tag = tag
        If parent Is Nothing Then
            tvNav.Nodes.Add(node)
        Else
            parent.Nodes.Add(node)
        End If
        Return node
    End Function

    ' ------------------------------------------------------------------ child windows

    Private Function ShowChild(Of T As {Form, New})() As T
        For Each child As Form In MdiChildren
            If TypeOf child Is T Then
                Dim existing As T = DirectCast(child, T)
                FitChild(existing)
                existing.Activate()
                Return existing
            End If
        Next
        Dim created As New T()
        created.MdiParent = Me
        created.Show()
        FitChild(created)
        created.Activate()
        Return created
    End Function

    ''' <summary>The rectangle the MDI child windows may occupy (work area inside the shell).</summary>
    Private Function MdiClientArea() As Rectangle
        For Each c As Control In Controls
            Dim client As MdiClient = TryCast(c, MdiClient)
            If client IsNot Nothing Then Return client.ClientRectangle
        Next
        Return New Rectangle(0, 0, Math.Max(600, ClientSize.Width - 300), Math.Max(400, ClientSize.Height - 120))
    End Function

    ''' <summary>
    ''' Sizes a child window so it fills the shell exactly. Maximising an MDI child
    ''' is not dependable here (the child keeps its design width and its right-hand
    ''' panel would be clipped), so the child is placed inside the client rectangle instead.
    ''' </summary>
    Private Sub FitChild(child As Form)
        If child Is Nothing OrElse child.IsDisposed Then Return
        Dim area As Rectangle = MdiClientArea()
        ' the client rectangle is meaningless while the shell is still laying out
        If area.Width < 320 OrElse area.Height < 240 Then Return
        If child.WindowState <> FormWindowState.Normal Then child.WindowState = FormWindowState.Normal
        If child.Bounds <> area Then
            ' Resuming the layout after the resize is what makes the docked panels
            ' re-flow to the new client size; a plain Bounds assignment leaves them
            ' at their design coordinates.
            child.SuspendLayout()
            child.Bounds = area
            child.ResumeLayout(True)
            child.PerformLayout()
        End If
    End Sub

    ''' <summary>Keeps every open window fitted when the shell is resized or toggled full screen.</summary>
    Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If WindowState = FormWindowState.Minimized Then Return
        For Each child As Form In MdiChildren
            FitChild(child)
        Next
    End Sub

    ''' <summary>Opens (or activates) the citizen registration window.</summary>
    Public Function OpenCitizen(Optional term As String = "") As frmCitizen
        Dim f As frmCitizen = ShowChild(Of frmCitizen)()
        If Not String.IsNullOrEmpty(term) Then
            f.PerformSearch(term)
        End If
        Return f
    End Function

    ''' <summary>Opens (or activates) the OpenCV visual effects lab.</summary>
    Public Function OpenVisualLab() As frmVisual
        Return ShowChild(Of frmVisual)()
    End Function

    ''' <summary>Opens (or activates) the statistics / chart window.</summary>
    Public Function OpenStats() As frmStats
        Return ShowChild(Of frmStats)()
    End Function

    ''' <summary>Opens (or activates) the dashboard window.</summary>
    Public Function OpenDashboard() As frmDashboard
        Return ShowChild(Of frmDashboard)()
    End Function

    ''' <summary>Refreshes the record counters in the status strip.</summary>
    Public Sub RefreshCounts()
        Try
            stsCount.Text = "Citizens: " & CitizenStore.GetStats().Total.ToString()
        Catch
            stsCount.Text = "Citizens: -"
        End Try
    End Sub

    ' ------------------------------------------------------------------ navigation

    Private Sub tvNav_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvNav.AfterSelect
        If e.Node Is Nothing OrElse e.Node.Tag Is Nothing Then Return
        Navigate(CStr(e.Node.Tag))
    End Sub

    Public Sub Navigate(action As String)
        Select Case action
            Case "dashboard"
                OpenDashboard()
            Case "register"
                OpenCitizen().StartNewRegistration()
            Case "search"
                OpenCitizen()
            Case "print"
                OpenCitizen()
            Case "verify"
                mtbQuick.Focus()
            Case "visual", "capture"
                OpenVisualLab()
            Case "stats"
                OpenStats()
            Case "backup"
                DoBackup()
            Case "integrity"
                ShowIntegrity()
            Case "about"
                ShowAbout()
        End Select
    End Sub

    ' ------------------------------------------------------------------ menu / toolbar

    Private Sub mniNew_Click(sender As Object, e As EventArgs) Handles mniNew.Click, mniRegister.Click,
        tsbNew.Click
        OpenCitizen().StartNewRegistration()
    End Sub

    Private Sub mniSearch_Click(sender As Object, e As EventArgs) Handles mniSearch.Click, tsbSearch.Click
        OpenCitizen()
    End Sub

    Private Sub mniPrint_Click(sender As Object, e As EventArgs) Handles mniPrint.Click, tsbPrint.Click
        Dim f As frmCitizen = OpenCitizen()
        f.PrintSelectedRecord()
    End Sub

    Private Sub mniVerifyCnic_Click(sender As Object, e As EventArgs) Handles mniVerifyCnic.Click
        mtbQuick.Focus()
        VerifyQuickCnic()
    End Sub

    Private Sub mniVisual_Click(sender As Object, e As EventArgs) Handles mniVisual.Click,
        mniCapture.Click, tsbVisual.Click
        OpenVisualLab()
    End Sub

    Private Sub mniStats_Click(sender As Object, e As EventArgs) Handles mniStats.Click, tsbStats.Click
        OpenStats()
    End Sub

    Private Sub mniBackup_Click(sender As Object, e As EventArgs) Handles mniBackupFile.Click,
        mniBackupDb.Click, tsbBackup.Click
        DoBackup()
    End Sub

    Private Sub mniRestore_Click(sender As Object, e As EventArgs) Handles mniRestoreFile.Click,
        mniRestoreDb.Click
        DoRestore()
    End Sub

    Private Sub mniIntegrity_Click(sender As Object, e As EventArgs) Handles mniIntegrity.Click
        ShowIntegrity()
    End Sub

    Private Sub mniRefresh_Click(sender As Object, e As EventArgs) Handles mniRefresh.Click
        RefreshCounts()
        If TypeOf ActiveMdiChild Is frmDashboard Then
            DirectCast(ActiveMdiChild, frmDashboard).RefreshData()
        ElseIf TypeOf ActiveMdiChild Is frmStats Then
            DirectCast(ActiveMdiChild, frmStats).RefreshData()
        ElseIf TypeOf ActiveMdiChild Is frmCitizen Then
            DirectCast(ActiveMdiChild, frmCitizen).PerformSearch("")
        End If
    End Sub

    Private Sub mniFull_Click(sender As Object, e As EventArgs) Handles mniFull.Click, tsbFull.Click
        ToggleFullScreen()
    End Sub

    Private Sub mniAbout_Click(sender As Object, e As EventArgs) Handles mniAbout.Click, tsbAbout.Click
        ShowAbout()
    End Sub

    Private Sub mniExit_Click(sender As Object, e As EventArgs) Handles mniExit.Click
        Application.Exit()
    End Sub

    Private Sub mniCascade_Click(sender As Object, e As EventArgs) Handles mniCascade.Click
        LayoutMdi(MDILayout.Cascade)
    End Sub

    Private Sub mniTileH_Click(sender As Object, e As EventArgs) Handles mniTileH.Click
        LayoutMdi(MDILayout.TileHorizontal)
    End Sub

    Private Sub mniTileV_Click(sender As Object, e As EventArgs) Handles mniTileV.Click
        LayoutMdi(MDILayout.TileVertical)
    End Sub

    Private Sub mniMinAll_Click(sender As Object, e As EventArgs) Handles mniMinAll.Click
        For Each child As Form In MdiChildren
            child.WindowState = FormWindowState.Minimized
        Next
    End Sub

    ' ------------------------------------------------------------------ quick search / verify

    Private Sub btnQuickSearch_Click(sender As Object, e As EventArgs) Handles btnQuickSearch.Click
        Dim digits As String = CitizenStore.DigitsOnly(mtbQuick.Text)
        Dim term As String = If(digits.Length > 0, digits, txtQuickName.Text)
        OpenCitizen(term)
    End Sub

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        VerifyQuickCnic()
    End Sub

    Private Sub VerifyQuickCnic()
        Dim message As String = ""
        If CitizenStore.ValidateCnic(mtbQuick.Text, message) Then
            lblVerifyResult.ForeColor = Color.FromArgb(0, 140, 60)
            lblVerifyResult.Text = "VALID CNIC - check digit verified"
            Db.LogActivity(Session.Current.Username, "CNIC-VERIFY", "Validated " & mtbQuick.Text)
        Else
            lblVerifyResult.ForeColor = Color.Firebrick
            lblVerifyResult.Text = message
        End If
    End Sub

    Private Sub mtbQuick_TextChanged(sender As Object, e As EventArgs) Handles mtbQuick.TextChanged
        If lblVerifyResult.Text <> "" Then lblVerifyResult.Text = ""
    End Sub

    ' ------------------------------------------------------------------ database tools

    Private Sub DoBackup()
        dlgBackup.Filter = "Microsoft Access Database (*.mdb)|*.mdb|All files (*.*)|*.*"
        dlgBackup.FileName = "nadra_backup_" & Format(Now, "yyyyMMdd_HHmmss") & ".mdb"
        If dlgBackup.ShowDialog(Me) <> DialogResult.OK Then Return
        Try
            Db.BackupTo(dlgBackup.FileName)
            MessageBox.Show(Me, "Database backed up successfully:" & vbCrLf & dlgBackup.FileName,
                            "Backup Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(Me, "Backup failed: " & ex.Message, "Backup Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DoRestore()
        dlgRestore.Filter = "Microsoft Access Database (*.mdb)|*.mdb|All files (*.*)|*.*"
        If dlgRestore.ShowDialog(Me) <> DialogResult.OK Then Return

        Dim answer As DialogResult = MessageBox.Show(Me,
            "Restoring will REPLACE the current database (including all citizen records) " &
            "with the selected backup." & vbCrLf & vbCrLf & "Continue?",
            "Confirm Restore", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If answer <> DialogResult.Yes Then Return

        Dim errorText As String = ""
        If Db.RestoreFrom(dlgRestore.FileName, errorText) Then
            MessageBox.Show(Me, "Database restored. The application will now restart.",
                            "Restore Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Application.Restart()
        Else
            MessageBox.Show(Me, "Restore failed: " & errorText, "Restore Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ShowIntegrity()
        Try
            MessageBox.Show(Me, Db.IntegrityReport(), "Database Integrity Check",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "Integrity Check", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub ShowAbout()
        Using f As New frmAbout()
            f.ShowDialog(Me)
        End Using
    End Sub

    Private Sub stsDb_Click(sender As Object, e As EventArgs) Handles stsDb.Click
        MessageBox.Show(Me, "File: " & AppPaths.DatabaseFile & vbCrLf & vbCrLf &
                        "Provider: " & Db.ProviderName & vbCrLf &
                        "Location: " & AppPaths.DataRoot,
                        "Database Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub lnkDataFolder_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkDataFolder.LinkClicked
        Try
            Process.Start("explorer.exe", AppPaths.DataRoot)
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "Open Folder", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    ' ------------------------------------------------------------------ full screen

    Private Sub ToggleFullScreen()
        If Not _fullScreen Then
            _savedBorder = FormBorderStyle
            FormBorderStyle = FormBorderStyle.None
            WindowState = FormWindowState.Maximized
            pnlHeader.Visible = False
            mnuMain.Visible = False
            tsMain.Visible = False
            stStatus.Visible = False
            pnlNav.Visible = False
            splNav.Visible = False
            _fullScreen = True
        Else
            pnlHeader.Visible = True
            mnuMain.Visible = True
            tsMain.Visible = True
            stStatus.Visible = True
            pnlNav.Visible = True
            splNav.Visible = True
            FormBorderStyle = _savedBorder
            WindowState = FormWindowState.Maximized
            _fullScreen = False
        End If
    End Sub

    Private Sub frmMain_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F11
                ToggleFullScreen()
                e.Handled = True
            Case Keys.Escape
                If _fullScreen Then
                    ToggleFullScreen()
                    e.Handled = True
                End If
            Case Keys.F5
                mniRefresh_Click(Me, EventArgs.Empty)
                e.Handled = True
        End Select
    End Sub

    Private Sub btnFull_Click(sender As Object, e As EventArgs) Handles btnFull.Click
        ToggleFullScreen()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim answer As DialogResult = MessageBox.Show(Me, "Sign out and return to the login screen?",
                                                     "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If answer <> DialogResult.Yes Then Return
        Db.LogActivity(Session.Current.Username, "LOGOUT", "Officer signed out.")
        Session.Current = Nothing
        Application.Restart()
    End Sub

    ' ------------------------------------------------------------------ clock / tray

    Private Sub tmrClock_Tick(sender As Object, e As EventArgs) Handles tmrClock.Tick
        stsClock.Text = Now.ToString("HH:mm:ss")
        lblDate.Text = Now.ToString("dddd, d MMMM yyyy")
    End Sub

    Private Sub mniTrayOpen_Click(sender As Object, e As EventArgs) Handles mniTrayOpen.Click
        Show()
        If WindowState = FormWindowState.Minimized Then WindowState = FormWindowState.Maximized
        Activate()
    End Sub

    Private Sub mniTrayExit_Click(sender As Object, e As EventArgs) Handles mniTrayExit.Click
        Application.Exit()
    End Sub

    Private Sub ntiTray_DoubleClick(sender As Object, e As EventArgs) Handles ntiTray.DoubleClick
        mniTrayOpen_Click(sender, e)
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ntiTray.Visible = False
        ntiTray.Dispose()
    End Sub

End Class
