<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStats
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
        Me.btnExport = New System.Windows.Forms.Button()
        Me.lblUpdated = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpKpi = New System.Windows.Forms.GroupBox()
        Me.lblKpiToday = New System.Windows.Forms.Label()
        Me.lblKpiTodayCap = New System.Windows.Forms.Label()
        Me.lblKpiPending = New System.Windows.Forms.Label()
        Me.lblKpiPendingCap = New System.Windows.Forms.Label()
        Me.lblKpiVerified = New System.Windows.Forms.Label()
        Me.lblKpiVerifiedCap = New System.Windows.Forms.Label()
        Me.lblKpiFemale = New System.Windows.Forms.Label()
        Me.lblKpiFemaleCap = New System.Windows.Forms.Label()
        Me.lblKpiTotal = New System.Windows.Forms.Label()
        Me.lblKpiTotalCap = New System.Windows.Forms.Label()
        Me.splitCharts = New System.Windows.Forms.SplitContainer()
        Me.chartGender = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chartProvince = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.grpCities = New System.Windows.Forms.GroupBox()
        Me.lvCities = New System.Windows.Forms.ListView()
        Me.colCity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.numTop = New System.Windows.Forms.NumericUpDown()
        Me.lblTop = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.dlgCsv = New System.Windows.Forms.SaveFileDialog()
        Me.tipStats = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlTitle.SuspendLayout()
        Me.grpKpi.SuspendLayout()
        CType(Me.splitCharts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitCharts.Panel1.SuspendLayout()
        Me.splitCharts.Panel2.SuspendLayout()
        Me.splitCharts.SuspendLayout()
        CType(Me.chartGender, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartProvince, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRight.SuspendLayout()
        Me.grpCities.SuspendLayout()
        CType(Me.numTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.FromArgb(1, 65, 28)
        Me.pnlTitle.Controls.Add(Me.btnExport)
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
        Me.lblTitle.Size = New System.Drawing.Size(239, 28)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Statistics && Charts"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(205, 225, 212)
        Me.lblSubtitle.Location = New System.Drawing.Point(17, 36)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(378, 15)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Citizen demographics from the NADRA Access database"
        '
        'lblUpdated
        '
        Me.lblUpdated.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUpdated.BackColor = System.Drawing.Color.Transparent
        Me.lblUpdated.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblUpdated.ForeColor = System.Drawing.Color.FromArgb(218, 185, 60)
        Me.lblUpdated.Location = New System.Drawing.Point(750, 34)
        Me.lblUpdated.Name = "lblUpdated"
        Me.lblUpdated.Size = New System.Drawing.Size(340, 16)
        Me.lblUpdated.TabIndex = 2
        Me.lblUpdated.Text = "Last updated: -"
        Me.lblUpdated.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnExport
        '
        Me.btnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(218, 185, 60)
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExport.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.btnExport.ForeColor = System.Drawing.Color.White
        Me.btnExport.Location = New System.Drawing.Point(1100, 10)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(108, 30)
        Me.btnExport.TabIndex = 3
        Me.btnExport.Text = "Export CSV"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'grpKpi
        '
        Me.grpKpi.Controls.Add(Me.lblKpiToday)
        Me.grpKpi.Controls.Add(Me.lblKpiTodayCap)
        Me.grpKpi.Controls.Add(Me.lblKpiPending)
        Me.grpKpi.Controls.Add(Me.lblKpiPendingCap)
        Me.grpKpi.Controls.Add(Me.lblKpiVerified)
        Me.grpKpi.Controls.Add(Me.lblKpiVerifiedCap)
        Me.grpKpi.Controls.Add(Me.lblKpiFemale)
        Me.grpKpi.Controls.Add(Me.lblKpiFemaleCap)
        Me.grpKpi.Controls.Add(Me.lblKpiTotal)
        Me.grpKpi.Controls.Add(Me.lblKpiTotalCap)
        Me.grpKpi.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpKpi.Location = New System.Drawing.Point(0, 58)
        Me.grpKpi.Name = "grpKpi"
        Me.grpKpi.Size = New System.Drawing.Size(1340, 92)
        Me.grpKpi.TabIndex = 1
        Me.grpKpi.TabStop = False
        Me.grpKpi.Text = "Key figures"
        '
        'lblKpiTotalCap
        '
        Me.lblKpiTotalCap.AutoSize = True
        Me.lblKpiTotalCap.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblKpiTotalCap.ForeColor = System.Drawing.Color.FromArgb(0, 105, 62)
        Me.lblKpiTotalCap.Location = New System.Drawing.Point(20, 24)
        Me.lblKpiTotalCap.Name = "lblKpiTotalCap"
        Me.lblKpiTotalCap.Size = New System.Drawing.Size(98, 13)
        Me.lblKpiTotalCap.TabIndex = 0
        Me.lblKpiTotalCap.Text = "TOTAL CITIZENS"
        '
        'lblKpiTotal
        '
        Me.lblKpiTotal.AutoSize = True
        Me.lblKpiTotal.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblKpiTotal.ForeColor = System.Drawing.Color.FromArgb(1, 65, 28)
        Me.lblKpiTotal.Location = New System.Drawing.Point(18, 42)
        Me.lblKpiTotal.Name = "lblKpiTotal"
        Me.lblKpiTotal.Size = New System.Drawing.Size(32, 37)
        Me.lblKpiTotal.TabIndex = 1
        Me.lblKpiTotal.Text = "0"
        '
        'lblKpiFemaleCap
        '
        Me.lblKpiFemaleCap.AutoSize = True
        Me.lblKpiFemaleCap.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblKpiFemaleCap.ForeColor = System.Drawing.Color.FromArgb(0, 105, 62)
        Me.lblKpiFemaleCap.Location = New System.Drawing.Point(290, 24)
        Me.lblKpiFemaleCap.Name = "lblKpiFemaleCap"
        Me.lblKpiFemaleCap.Size = New System.Drawing.Size(155, 13)
        Me.lblKpiFemaleCap.TabIndex = 2
        Me.lblKpiFemaleCap.Text = "FEMALE CITIZENS"
        '
        'lblKpiFemale
        '
        Me.lblKpiFemale.AutoSize = True
        Me.lblKpiFemale.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblKpiFemale.ForeColor = System.Drawing.Color.FromArgb(1, 65, 28)
        Me.lblKpiFemale.Location = New System.Drawing.Point(288, 42)
        Me.lblKpiFemale.Name = "lblKpiFemale"
        Me.lblKpiFemale.Size = New System.Drawing.Size(32, 37)
        Me.lblKpiFemale.TabIndex = 3
        Me.lblKpiFemale.Text = "0"
        '
        'lblKpiVerifiedCap
        '
        Me.lblKpiVerifiedCap.AutoSize = True
        Me.lblKpiVerifiedCap.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblKpiVerifiedCap.ForeColor = System.Drawing.Color.FromArgb(0, 105, 62)
        Me.lblKpiVerifiedCap.Location = New System.Drawing.Point(560, 24)
        Me.lblKpiVerifiedCap.Name = "lblKpiVerifiedCap"
        Me.lblKpiVerifiedCap.Size = New System.Drawing.Size(112, 13)
        Me.lblKpiVerifiedCap.TabIndex = 4
        Me.lblKpiVerifiedCap.Text = "VERIFIED"
        '
        'lblKpiVerified
        '
        Me.lblKpiVerified.AutoSize = True
        Me.lblKpiVerified.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblKpiVerified.ForeColor = System.Drawing.Color.FromArgb(0, 158, 72)
        Me.lblKpiVerified.Location = New System.Drawing.Point(558, 42)
        Me.lblKpiVerified.Name = "lblKpiVerified"
        Me.lblKpiVerified.Size = New System.Drawing.Size(32, 37)
        Me.lblKpiVerified.TabIndex = 5
        Me.lblKpiVerified.Text = "0"
        '
        'lblKpiPendingCap
        '
        Me.lblKpiPendingCap.AutoSize = True
        Me.lblKpiPendingCap.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblKpiPendingCap.ForeColor = System.Drawing.Color.FromArgb(150, 90, 0)
        Me.lblKpiPendingCap.Location = New System.Drawing.Point(830, 24)
        Me.lblKpiPendingCap.Name = "lblKpiPendingCap"
        Me.lblKpiPendingCap.Size = New System.Drawing.Size(62, 13)
        Me.lblKpiPendingCap.TabIndex = 6
        Me.lblKpiPendingCap.Text = "PENDING"
        '
        'lblKpiPending
        '
        Me.lblKpiPending.AutoSize = True
        Me.lblKpiPending.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblKpiPending.ForeColor = System.Drawing.Color.FromArgb(196, 120, 0)
        Me.lblKpiPending.Location = New System.Drawing.Point(828, 42)
        Me.lblKpiPending.Name = "lblKpiPending"
        Me.lblKpiPending.Size = New System.Drawing.Size(32, 37)
        Me.lblKpiPending.TabIndex = 7
        Me.lblKpiPending.Text = "0"
        '
        'lblKpiTodayCap
        '
        Me.lblKpiTodayCap.AutoSize = True
        Me.lblKpiTodayCap.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblKpiTodayCap.ForeColor = System.Drawing.Color.FromArgb(0, 105, 62)
        Me.lblKpiTodayCap.Location = New System.Drawing.Point(1100, 24)
        Me.lblKpiTodayCap.Name = "lblKpiTodayCap"
        Me.lblKpiTodayCap.Size = New System.Drawing.Size(118, 13)
        Me.lblKpiTodayCap.TabIndex = 8
        Me.lblKpiTodayCap.Text = "TODAY"
        '
        'lblKpiToday
        '
        Me.lblKpiToday.AutoSize = True
        Me.lblKpiToday.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblKpiToday.ForeColor = System.Drawing.Color.FromArgb(1, 65, 28)
        Me.lblKpiToday.Location = New System.Drawing.Point(1098, 42)
        Me.lblKpiToday.Name = "lblKpiToday"
        Me.lblKpiToday.Size = New System.Drawing.Size(32, 37)
        Me.lblKpiToday.TabIndex = 9
        Me.lblKpiToday.Text = "0"
        '
        'splitCharts
        '
        Me.splitCharts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitCharts.Location = New System.Drawing.Point(0, 150)
        Me.splitCharts.Name = "splitCharts"
        Me.splitCharts.Panel1.Controls.Add(Me.chartGender)
        Me.splitCharts.Panel2.Controls.Add(Me.chartProvince)
        Me.splitCharts.Size = New System.Drawing.Size(1000, 460)
        Me.splitCharts.SplitterDistance = 500
        Me.splitCharts.TabIndex = 2
        '
        'chartGender
        '
        Me.chartGender.BackColor = System.Drawing.Color.White
        Me.chartGender.BorderlineColor = System.Drawing.Color.FromArgb(200, 215, 205)
        Me.chartGender.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.chartGender.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chartGender.Location = New System.Drawing.Point(0, 0)
        Me.chartGender.Name = "chartGender"
        Me.chartGender.Size = New System.Drawing.Size(500, 460)
        Me.chartGender.TabIndex = 0
        '
        'chartProvince
        '
        Me.chartProvince.BackColor = System.Drawing.Color.White
        Me.chartProvince.BorderlineColor = System.Drawing.Color.FromArgb(200, 215, 205)
        Me.chartProvince.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.chartProvince.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chartProvince.Location = New System.Drawing.Point(0, 0)
        Me.chartProvince.Name = "chartProvince"
        Me.chartProvince.Size = New System.Drawing.Size(496, 460)
        Me.chartProvince.TabIndex = 0
        '
        'pnlRight
        '
        Me.pnlRight.BackColor = System.Drawing.Color.White
        Me.pnlRight.Controls.Add(Me.grpCities)
        Me.pnlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlRight.Location = New System.Drawing.Point(1000, 150)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(340, 460)
        Me.pnlRight.TabIndex = 3
        '
        'grpCities
        '
        Me.grpCities.Controls.Add(Me.lvCities)
        Me.grpCities.Controls.Add(Me.numTop)
        Me.grpCities.Controls.Add(Me.lblTop)
        Me.grpCities.Controls.Add(Me.btnRefresh)
        Me.grpCities.Location = New System.Drawing.Point(8, 6)
        Me.grpCities.Name = "grpCities"
        Me.grpCities.Size = New System.Drawing.Size(324, 448)
        Me.grpCities.TabIndex = 0
        Me.grpCities.TabStop = False
        Me.grpCities.Text = "Top cities"
        '
        'lblTop
        '
        Me.lblTop.AutoSize = True
        Me.lblTop.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblTop.ForeColor = System.Drawing.Color.FromArgb(28, 40, 33)
        Me.lblTop.Location = New System.Drawing.Point(14, 24)
        Me.lblTop.Name = "lblTop"
        Me.lblTop.Size = New System.Drawing.Size(114, 15)
        Me.lblTop.TabIndex = 0
        Me.lblTop.Text = "Show top N cities:"
        '
        'numTop
        '
        Me.numTop.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.numTop.Location = New System.Drawing.Point(140, 22)
        Me.numTop.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.numTop.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.numTop.Name = "numTop"
        Me.numTop.Size = New System.Drawing.Size(60, 23)
        Me.numTop.TabIndex = 1
        Me.numTop.Value = New Decimal(New Integer() {8, 0, 0, 0})
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(0, 105, 62)
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(210, 20)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(100, 28)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'lvCities
        '
        Me.lvCities.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvCities.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colCity, Me.colCount})
        Me.lvCities.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lvCities.FullRowSelect = True
        Me.lvCities.GridLines = True
        Me.lvCities.Location = New System.Drawing.Point(14, 58)
        Me.lvCities.Name = "lvCities"
        Me.lvCities.Size = New System.Drawing.Size(296, 376)
        Me.lvCities.TabIndex = 3
        Me.lvCities.UseCompatibleStateImageBehavior = False
        Me.lvCities.View = System.Windows.Forms.View.Details
        '
        'colCity
        '
        Me.colCity.Text = "City"
        Me.colCity.Width = 195
        '
        'colCount
        '
        Me.colCount.Text = "Citizens"
        Me.colCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colCount.Width = 80
        '
        'dlgCsv
        '
        Me.dlgCsv.DefaultExt = "csv"
        Me.dlgCsv.Filter = "CSV file|*.csv|All files|*.*"
        '
        'frmStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(238, 242, 239)
        Me.ClientSize = New System.Drawing.Size(1340, 610)
        Me.Controls.Add(Me.splitCharts)
        Me.Controls.Add(Me.pnlRight)
        Me.Controls.Add(Me.grpKpi)
        Me.Controls.Add(Me.pnlTitle)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "frmStats"
        Me.Text = "Statistics and Charts"
        Me.pnlTitle.ResumeLayout(False)
        Me.pnlTitle.PerformLayout()
        Me.grpKpi.ResumeLayout(False)
        Me.grpKpi.PerformLayout()
        Me.splitCharts.Panel1.ResumeLayout(False)
        Me.splitCharts.Panel2.ResumeLayout(False)
        CType(Me.splitCharts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitCharts.ResumeLayout(False)
        CType(Me.chartGender, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartProvince, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRight.ResumeLayout(False)
        Me.grpCities.ResumeLayout(False)
        CType(Me.numTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents lblUpdated As System.Windows.Forms.Label
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents grpKpi As System.Windows.Forms.GroupBox
    Friend WithEvents lblKpiTotalCap As System.Windows.Forms.Label
    Friend WithEvents lblKpiTotal As System.Windows.Forms.Label
    Friend WithEvents lblKpiFemaleCap As System.Windows.Forms.Label
    Friend WithEvents lblKpiFemale As System.Windows.Forms.Label
    Friend WithEvents lblKpiVerifiedCap As System.Windows.Forms.Label
    Friend WithEvents lblKpiVerified As System.Windows.Forms.Label
    Friend WithEvents lblKpiPendingCap As System.Windows.Forms.Label
    Friend WithEvents lblKpiPending As System.Windows.Forms.Label
    Friend WithEvents lblKpiTodayCap As System.Windows.Forms.Label
    Friend WithEvents lblKpiToday As System.Windows.Forms.Label
    Friend WithEvents splitCharts As System.Windows.Forms.SplitContainer
    Friend WithEvents chartGender As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents chartProvince As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents pnlRight As System.Windows.Forms.Panel
    Friend WithEvents grpCities As System.Windows.Forms.GroupBox
    Friend WithEvents lvCities As System.Windows.Forms.ListView
    Friend WithEvents colCity As System.Windows.Forms.ColumnHeader
    Friend WithEvents colCount As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblTop As System.Windows.Forms.Label
    Friend WithEvents numTop As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents dlgCsv As System.Windows.Forms.SaveFileDialog
    Friend WithEvents tipStats As System.Windows.Forms.ToolTip

End Class
