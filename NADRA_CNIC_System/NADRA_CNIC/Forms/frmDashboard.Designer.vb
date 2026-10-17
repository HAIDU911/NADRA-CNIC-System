<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
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
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.lblUpdated = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpRecent = New System.Windows.Forms.GroupBox()
        Me.lvRecent = New System.Windows.Forms.ListView()
        Me.colCnic = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grpSide = New System.Windows.Forms.GroupBox()
        Me.lblQuick = New System.Windows.Forms.Label()
        Me.lnkStats = New System.Windows.Forms.LinkLabel()
        Me.lnkVisual = New System.Windows.Forms.LinkLabel()
        Me.lnkRegister = New System.Windows.Forms.LinkLabel()
        Me.calToday = New System.Windows.Forms.MonthCalendar()
        Me.lblTargetVal = New System.Windows.Forms.Label()
        Me.pbTarget = New System.Windows.Forms.ProgressBar()
        Me.lblTargetCap = New System.Windows.Forms.Label()
        Me.tblCards = New System.Windows.Forms.TableLayoutPanel()
        Me.grpToday = New System.Windows.Forms.GroupBox()
        Me.lblTodayVal = New System.Windows.Forms.Label()
        Me.lblTodayCap = New System.Windows.Forms.Label()
        Me.lblTodaySub = New System.Windows.Forms.Label()
        Me.grpPending = New System.Windows.Forms.GroupBox()
        Me.lblPendingVal = New System.Windows.Forms.Label()
        Me.lblPendingCap = New System.Windows.Forms.Label()
        Me.lblPendingSub = New System.Windows.Forms.Label()
        Me.grpVerified = New System.Windows.Forms.GroupBox()
        Me.lblVerifiedVal = New System.Windows.Forms.Label()
        Me.lblVerifiedCap = New System.Windows.Forms.Label()
        Me.lblVerifiedSub = New System.Windows.Forms.Label()
        Me.grpTotal = New System.Windows.Forms.GroupBox()
        Me.lblTotalVal = New System.Windows.Forms.Label()
        Me.lblTotalCap = New System.Windows.Forms.Label()
        Me.lblTotalSub = New System.Windows.Forms.Label()
        Me.tipDash = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlTitle.SuspendLayout()
        Me.grpRecent.SuspendLayout()
        Me.grpSide.SuspendLayout()
        Me.tblCards.SuspendLayout()
        Me.grpToday.SuspendLayout()
        Me.grpPending.SuspendLayout()
        Me.grpVerified.SuspendLayout()
        Me.grpTotal.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.FromArgb(1, 65, 28)
        Me.pnlTitle.Controls.Add(Me.btnRefresh)
        Me.pnlTitle.Controls.Add(Me.lblUpdated)
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
        Me.lblTitle.Size = New System.Drawing.Size(140, 28)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Dashboard"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(205, 225, 212)
        Me.lblSubtitle.Location = New System.Drawing.Point(17, 36)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(329, 15)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Citizen registration overview - NADRA CNIC Management System"
        '
        'lblUpdated
        '
        Me.lblUpdated.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUpdated.BackColor = System.Drawing.Color.Transparent
        Me.lblUpdated.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblUpdated.ForeColor = System.Drawing.Color.FromArgb(218, 185, 60)
        Me.lblUpdated.Location = New System.Drawing.Point(940, 32)
        Me.lblUpdated.Name = "lblUpdated"
        Me.lblUpdated.Size = New System.Drawing.Size(270, 16)
        Me.lblUpdated.TabIndex = 2
        Me.lblUpdated.Text = "Last updated: -"
        Me.lblUpdated.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(218, 185, 60)
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(1216, 10)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(110, 26)
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.Text = "Refresh (F5)"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'grpRecent
        '
        Me.grpRecent.Controls.Add(Me.lvRecent)
        Me.grpRecent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpRecent.Location = New System.Drawing.Point(0, 208)
        Me.grpRecent.Name = "grpRecent"
        Me.grpRecent.Size = New System.Drawing.Size(1030, 502)
        Me.grpRecent.TabIndex = 1
        Me.grpRecent.TabStop = False
        Me.grpRecent.Text = "Recent Registrations (double-click a row to open the record)"
        '
        'lvRecent
        '
        Me.lvRecent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvRecent.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colCnic, Me.colName, Me.colCity, Me.colDate, Me.colStatus})
        Me.lvRecent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvRecent.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lvRecent.FullRowSelect = True
        Me.lvRecent.GridLines = True
        Me.lvRecent.HideSelection = False
        Me.lvRecent.Location = New System.Drawing.Point(3, 19)
        Me.lvRecent.Name = "lvRecent"
        Me.lvRecent.Size = New System.Drawing.Size(1024, 480)
        Me.lvRecent.TabIndex = 0
        Me.lvRecent.UseCompatibleStateImageBehavior = False
        Me.lvRecent.View = System.Windows.Forms.View.Details
        '
        'colCnic
        '
        Me.colCnic.Text = "CNIC"
        Me.colCnic.Width = 130
        '
        'colName
        '
        Me.colName.Text = "Name"
        Me.colName.Width = 210
        '
        'colCity
        '
        Me.colCity.Text = "City"
        Me.colCity.Width = 150
        '
        'colDate
        '
        Me.colDate.Text = "Registered"
        Me.colDate.Width = 150
        '
        'colStatus
        '
        Me.colStatus.Text = "Status"
        Me.colStatus.Width = 110
        '
        'grpSide
        '
        Me.grpSide.Controls.Add(Me.lblQuick)
        Me.grpSide.Controls.Add(Me.lnkStats)
        Me.grpSide.Controls.Add(Me.lnkVisual)
        Me.grpSide.Controls.Add(Me.lnkRegister)
        Me.grpSide.Controls.Add(Me.calToday)
        Me.grpSide.Controls.Add(Me.lblTargetVal)
        Me.grpSide.Controls.Add(Me.pbTarget)
        Me.grpSide.Controls.Add(Me.lblTargetCap)
        Me.grpSide.Dock = System.Windows.Forms.DockStyle.Right
        Me.grpSide.Location = New System.Drawing.Point(1030, 208)
        Me.grpSide.Name = "grpSide"
        Me.grpSide.Size = New System.Drawing.Size(310, 502)
        Me.grpSide.TabIndex = 2
        Me.grpSide.TabStop = False
        Me.grpSide.Text = "Verification && Quick Actions"
        '
        'lblTargetCap
        '
        Me.lblTargetCap.AutoSize = True
        Me.lblTargetCap.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblTargetCap.ForeColor = System.Drawing.Color.FromArgb(28, 40, 33)
        Me.lblTargetCap.Location = New System.Drawing.Point(14, 28)
        Me.lblTargetCap.Name = "lblTargetCap"
        Me.lblTargetCap.Size = New System.Drawing.Size(148, 15)
        Me.lblTargetCap.TabIndex = 0
        Me.lblTargetCap.Text = "Verification progress"
        '
        'pbTarget
        '
        Me.pbTarget.Location = New System.Drawing.Point(16, 50)
        Me.pbTarget.Name = "pbTarget"
        Me.pbTarget.Size = New System.Drawing.Size(276, 24)
        Me.pbTarget.Step = 1
        Me.pbTarget.TabIndex = 1
        '
        'lblTargetVal
        '
        Me.lblTargetVal.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblTargetVal.ForeColor = System.Drawing.Color.FromArgb(0, 105, 62)
        Me.lblTargetVal.Location = New System.Drawing.Point(14, 82)
        Me.lblTargetVal.Name = "lblTargetVal"
        Me.lblTargetVal.Size = New System.Drawing.Size(280, 32)
        Me.lblTargetVal.TabIndex = 2
        Me.lblTargetVal.Text = "-"
        '
        'calToday
        '
        Me.calToday.Location = New System.Drawing.Point(16, 122)
        Me.calToday.Name = "calToday"
        Me.calToday.TabIndex = 3
        '
        'lblQuick
        '
        Me.lblQuick.AutoSize = True
        Me.lblQuick.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblQuick.ForeColor = System.Drawing.Color.FromArgb(1, 65, 28)
        Me.lblQuick.Location = New System.Drawing.Point(14, 358)
        Me.lblQuick.Name = "lblQuick"
        Me.lblQuick.Size = New System.Drawing.Size(97, 15)
        Me.lblQuick.TabIndex = 4
        Me.lblQuick.Text = "Quick actions"
        '
        'lnkRegister
        '
        Me.lnkRegister.AutoSize = True
        Me.lnkRegister.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lnkRegister.LinkColor = System.Drawing.Color.FromArgb(0, 105, 62)
        Me.lnkRegister.Location = New System.Drawing.Point(16, 382)
        Me.lnkRegister.Name = "lnkRegister"
        Me.lnkRegister.Size = New System.Drawing.Size(164, 15)
        Me.lnkRegister.TabIndex = 5
        Me.lnkRegister.TabStop = True
        Me.lnkRegister.Text = "+ Register a new citizen"
        '
        'lnkVisual
        '
        Me.lnkVisual.AutoSize = True
        Me.lnkVisual.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lnkVisual.LinkColor = System.Drawing.Color.FromArgb(0, 105, 62)
        Me.lnkVisual.Location = New System.Drawing.Point(16, 406)
        Me.lnkVisual.Name = "lnkVisual"
        Me.lnkVisual.Size = New System.Drawing.Size(204, 15)
        Me.lnkVisual.TabIndex = 6
        Me.lnkVisual.TabStop = True
        Me.lnkVisual.Text = "Open OpenCV Visual Effects Lab"
        '
        'lnkStats
        '
        Me.lnkStats.AutoSize = True
        Me.lnkStats.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lnkStats.LinkColor = System.Drawing.Color.FromArgb(0, 105, 62)
        Me.lnkStats.Location = New System.Drawing.Point(16, 430)
        Me.lnkStats.Name = "lnkStats"
        Me.lnkStats.Size = New System.Drawing.Size(140, 15)
        Me.lnkStats.TabIndex = 7
        Me.lnkStats.TabStop = True
        Me.lnkStats.Text = "View statistics && charts"
        '
        'tblCards
        '
        Me.tblCards.ColumnCount = 4
        Me.tblCards.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblCards.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblCards.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblCards.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblCards.Controls.Add(Me.grpToday, 3, 0)
        Me.tblCards.Controls.Add(Me.grpPending, 2, 0)
        Me.tblCards.Controls.Add(Me.grpVerified, 1, 0)
        Me.tblCards.Controls.Add(Me.grpTotal, 0, 0)
        Me.tblCards.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblCards.Location = New System.Drawing.Point(0, 58)
        Me.tblCards.Name = "tblCards"
        Me.tblCards.RowCount = 1
        Me.tblCards.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblCards.Size = New System.Drawing.Size(1340, 150)
        Me.tblCards.TabIndex = 3
        '
        'grpTotal
        '
        Me.grpTotal.Controls.Add(Me.lblTotalVal)
        Me.grpTotal.Controls.Add(Me.lblTotalCap)
        Me.grpTotal.Controls.Add(Me.lblTotalSub)
        Me.grpTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpTotal.Location = New System.Drawing.Point(6, 6)
        Me.grpTotal.Margin = New System.Windows.Forms.Padding(6, 6, 3, 6)
        Me.grpTotal.Name = "grpTotal"
        Me.grpTotal.Size = New System.Drawing.Size(322, 138)
        Me.grpTotal.TabIndex = 0
        Me.grpTotal.TabStop = False
        '
        'lblTotalCap
        '
        Me.lblTotalCap.AutoSize = True
        Me.lblTotalCap.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalCap.ForeColor = System.Drawing.Color.FromArgb(0, 105, 62)
        Me.lblTotalCap.Location = New System.Drawing.Point(12, 20)
        Me.lblTotalCap.Name = "lblTotalCap"
        Me.lblTotalCap.Size = New System.Drawing.Size(117, 15)
        Me.lblTotalCap.TabIndex = 0
        Me.lblTotalCap.Text = "TOTAL CITIZENS"
        '
        'lblTotalVal
        '
        Me.lblTotalVal.AutoSize = True
        Me.lblTotalVal.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalVal.ForeColor = System.Drawing.Color.FromArgb(1, 65, 28)
        Me.lblTotalVal.Location = New System.Drawing.Point(10, 44)
        Me.lblTotalVal.Name = "lblTotalVal"
        Me.lblTotalVal.Size = New System.Drawing.Size(41, 47)
        Me.lblTotalVal.TabIndex = 1
        Me.lblTotalVal.Text = "0"
        '
        'lblTotalSub
        '
        Me.lblTotalSub.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblTotalSub.ForeColor = System.Drawing.Color.FromArgb(90, 110, 98)
        Me.lblTotalSub.Location = New System.Drawing.Point(12, 100)
        Me.lblTotalSub.Name = "lblTotalSub"
        Me.lblTotalSub.Size = New System.Drawing.Size(298, 30)
        Me.lblTotalSub.TabIndex = 2
        Me.lblTotalSub.Text = "-"
        '
        'grpVerified
        '
        Me.grpVerified.Controls.Add(Me.lblVerifiedVal)
        Me.grpVerified.Controls.Add(Me.lblVerifiedCap)
        Me.grpVerified.Controls.Add(Me.lblVerifiedSub)
        Me.grpVerified.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpVerified.Location = New System.Drawing.Point(337, 6)
        Me.grpVerified.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.grpVerified.Name = "grpVerified"
        Me.grpVerified.Size = New System.Drawing.Size(325, 138)
        Me.grpVerified.TabIndex = 1
        Me.grpVerified.TabStop = False
        '
        'lblVerifiedCap
        '
        Me.lblVerifiedCap.AutoSize = True
        Me.lblVerifiedCap.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblVerifiedCap.ForeColor = System.Drawing.Color.FromArgb(0, 105, 62)
        Me.lblVerifiedCap.Location = New System.Drawing.Point(12, 20)
        Me.lblVerifiedCap.Name = "lblVerifiedCap"
        Me.lblVerifiedCap.Size = New System.Drawing.Size(157, 15)
        Me.lblVerifiedCap.TabIndex = 0
        Me.lblVerifiedCap.Text = "VERIFIED RECORDS"
        '
        'lblVerifiedVal
        '
        Me.lblVerifiedVal.AutoSize = True
        Me.lblVerifiedVal.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Bold)
        Me.lblVerifiedVal.ForeColor = System.Drawing.Color.FromArgb(0, 158, 72)
        Me.lblVerifiedVal.Location = New System.Drawing.Point(10, 44)
        Me.lblVerifiedVal.Name = "lblVerifiedVal"
        Me.lblVerifiedVal.Size = New System.Drawing.Size(41, 47)
        Me.lblVerifiedVal.TabIndex = 1
        Me.lblVerifiedVal.Text = "0"
        '
        'lblVerifiedSub
        '
        Me.lblVerifiedSub.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblVerifiedSub.ForeColor = System.Drawing.Color.FromArgb(90, 110, 98)
        Me.lblVerifiedSub.Location = New System.Drawing.Point(12, 100)
        Me.lblVerifiedSub.Name = "lblVerifiedSub"
        Me.lblVerifiedSub.Size = New System.Drawing.Size(300, 30)
        Me.lblVerifiedSub.TabIndex = 2
        Me.lblVerifiedSub.Text = "-"
        '
        'grpPending
        '
        Me.grpPending.Controls.Add(Me.lblPendingVal)
        Me.grpPending.Controls.Add(Me.lblPendingCap)
        Me.grpPending.Controls.Add(Me.lblPendingSub)
        Me.grpPending.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpPending.Location = New System.Drawing.Point(668, 6)
        Me.grpPending.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.grpPending.Name = "grpPending"
        Me.grpPending.Size = New System.Drawing.Size(325, 138)
        Me.grpPending.TabIndex = 2
        Me.grpPending.TabStop = False
        '
        'lblPendingCap
        '
        Me.lblPendingCap.AutoSize = True
        Me.lblPendingCap.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPendingCap.ForeColor = System.Drawing.Color.FromArgb(150, 90, 0)
        Me.lblPendingCap.Location = New System.Drawing.Point(12, 20)
        Me.lblPendingCap.Name = "lblPendingCap"
        Me.lblPendingCap.Size = New System.Drawing.Size(158, 15)
        Me.lblPendingCap.TabIndex = 0
        Me.lblPendingCap.Text = "PENDING VERIFICATION"
        '
        'lblPendingVal
        '
        Me.lblPendingVal.AutoSize = True
        Me.lblPendingVal.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Bold)
        Me.lblPendingVal.ForeColor = System.Drawing.Color.FromArgb(196, 120, 0)
        Me.lblPendingVal.Location = New System.Drawing.Point(10, 44)
        Me.lblPendingVal.Name = "lblPendingVal"
        Me.lblPendingVal.Size = New System.Drawing.Size(41, 47)
        Me.lblPendingVal.TabIndex = 1
        Me.lblPendingVal.Text = "0"
        '
        'lblPendingSub
        '
        Me.lblPendingSub.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblPendingSub.ForeColor = System.Drawing.Color.FromArgb(90, 110, 98)
        Me.lblPendingSub.Location = New System.Drawing.Point(12, 100)
        Me.lblPendingSub.Name = "lblPendingSub"
        Me.lblPendingSub.Size = New System.Drawing.Size(300, 30)
        Me.lblPendingSub.TabIndex = 2
        Me.lblPendingSub.Text = "-"
        '
        'grpToday
        '
        Me.grpToday.Controls.Add(Me.lblTodayVal)
        Me.grpToday.Controls.Add(Me.lblTodayCap)
        Me.grpToday.Controls.Add(Me.lblTodaySub)
        Me.grpToday.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpToday.Location = New System.Drawing.Point(999, 6)
        Me.grpToday.Margin = New System.Windows.Forms.Padding(3, 6, 6, 6)
        Me.grpToday.Name = "grpToday"
        Me.grpToday.Size = New System.Drawing.Size(332, 138)
        Me.grpToday.TabIndex = 3
        Me.grpToday.TabStop = False
        '
        'lblTodayCap
        '
        Me.lblTodayCap.AutoSize = True
        Me.lblTodayCap.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTodayCap.ForeColor = System.Drawing.Color.FromArgb(1, 65, 28)
        Me.lblTodayCap.Location = New System.Drawing.Point(12, 20)
        Me.lblTodayCap.Name = "lblTodayCap"
        Me.lblTodayCap.Size = New System.Drawing.Size(160, 15)
        Me.lblTodayCap.TabIndex = 0
        Me.lblTodayCap.Text = "REGISTERED TODAY"
        '
        'lblTodayVal
        '
        Me.lblTodayVal.AutoSize = True
        Me.lblTodayVal.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Bold)
        Me.lblTodayVal.ForeColor = System.Drawing.Color.FromArgb(1, 65, 28)
        Me.lblTodayVal.Location = New System.Drawing.Point(10, 44)
        Me.lblTodayVal.Name = "lblTodayVal"
        Me.lblTodayVal.Size = New System.Drawing.Size(41, 47)
        Me.lblTodayVal.TabIndex = 1
        Me.lblTodayVal.Text = "0"
        '
        'lblTodaySub
        '
        Me.lblTodaySub.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblTodaySub.ForeColor = System.Drawing.Color.FromArgb(90, 110, 98)
        Me.lblTodaySub.Location = New System.Drawing.Point(12, 100)
        Me.lblTodaySub.Name = "lblTodaySub"
        Me.lblTodaySub.Size = New System.Drawing.Size(306, 30)
        Me.lblTodaySub.TabIndex = 2
        Me.lblTodaySub.Text = "-"
        '
        'tipDash
        '
        Me.tipDash.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(238, 242, 239)
        Me.ClientSize = New System.Drawing.Size(1340, 710)
        Me.Controls.Add(Me.grpRecent)
        Me.Controls.Add(Me.grpSide)
        Me.Controls.Add(Me.tblCards)
        Me.Controls.Add(Me.pnlTitle)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "frmDashboard"
        Me.Text = "Dashboard"
        Me.pnlTitle.ResumeLayout(False)
        Me.pnlTitle.PerformLayout()
        Me.grpRecent.ResumeLayout(False)
        Me.grpSide.ResumeLayout(False)
        Me.grpSide.PerformLayout()
        Me.tblCards.ResumeLayout(False)
        Me.grpToday.ResumeLayout(False)
        Me.grpPending.ResumeLayout(False)
        Me.grpVerified.ResumeLayout(False)
        Me.grpTotal.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents lblUpdated As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents grpRecent As System.Windows.Forms.GroupBox
    Friend WithEvents lvRecent As System.Windows.Forms.ListView
    Friend WithEvents colCnic As System.Windows.Forms.ColumnHeader
    Friend WithEvents colName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colCity As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents colStatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents grpSide As System.Windows.Forms.GroupBox
    Friend WithEvents lblTargetCap As System.Windows.Forms.Label
    Friend WithEvents pbTarget As System.Windows.Forms.ProgressBar
    Friend WithEvents lblTargetVal As System.Windows.Forms.Label
    Friend WithEvents calToday As System.Windows.Forms.MonthCalendar
    Friend WithEvents lblQuick As System.Windows.Forms.Label
    Friend WithEvents lnkRegister As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkVisual As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkStats As System.Windows.Forms.LinkLabel
    Friend WithEvents tblCards As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents grpTotal As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalCap As System.Windows.Forms.Label
    Friend WithEvents lblTotalVal As System.Windows.Forms.Label
    Friend WithEvents lblTotalSub As System.Windows.Forms.Label
    Friend WithEvents grpVerified As System.Windows.Forms.GroupBox
    Friend WithEvents lblVerifiedCap As System.Windows.Forms.Label
    Friend WithEvents lblVerifiedVal As System.Windows.Forms.Label
    Friend WithEvents lblVerifiedSub As System.Windows.Forms.Label
    Friend WithEvents grpPending As System.Windows.Forms.GroupBox
    Friend WithEvents lblPendingCap As System.Windows.Forms.Label
    Friend WithEvents lblPendingVal As System.Windows.Forms.Label
    Friend WithEvents lblPendingSub As System.Windows.Forms.Label
    Friend WithEvents grpToday As System.Windows.Forms.GroupBox
    Friend WithEvents lblTodayCap As System.Windows.Forms.Label
    Friend WithEvents lblTodayVal As System.Windows.Forms.Label
    Friend WithEvents lblTodaySub As System.Windows.Forms.Label
    Friend WithEvents tipDash As System.Windows.Forms.ToolTip

End Class
