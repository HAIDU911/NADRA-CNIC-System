<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAbout
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblTag = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.rtbAbout = New System.Windows.Forms.RichTextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lnkNadra = New System.Windows.Forms.LinkLabel()
        Me.tipAbout = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlHeader.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(1, 65, 28)
        Me.pnlHeader.Controls.Add(Me.lblVersion)
        Me.pnlHeader.Controls.Add(Me.lblTag)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.picLogo)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(760, 96)
        Me.pnlHeader.TabIndex = 0
        '
        'picLogo
        '
        Me.picLogo.Location = New System.Drawing.Point(16, 14)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(68, 68)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(98, 14)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(372, 25)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "NADRA CNIC Management System"
        '
        'lblTag
        '
        Me.lblTag.AutoSize = True
        Me.lblTag.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblTag.ForeColor = System.Drawing.Color.FromArgb(205, 225, 212)
        Me.lblTag.Location = New System.Drawing.Point(100, 42)
        Me.lblTag.Name = "lblTag"
        Me.lblTag.Size = New System.Drawing.Size(378, 15)
        Me.lblTag.TabIndex = 2
        Me.lblTag.Text = "Visual Programming - Assignment # 2 (CLO-2), Software Engineering Department"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblVersion.ForeColor = System.Drawing.Color.FromArgb(218, 185, 60)
        Me.lblVersion.Location = New System.Drawing.Point(100, 62)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(255, 13)
        Me.lblVersion.TabIndex = 3
        Me.lblVersion.Text = "Version 1.0  -  BSE 5A / 5B  -  .NET Framework 4.8"
        '
        'rtbAbout
        '
        Me.rtbAbout.BackColor = System.Drawing.Color.White
        Me.rtbAbout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtbAbout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rtbAbout.Location = New System.Drawing.Point(16, 108)
        Me.rtbAbout.Name = "rtbAbout"
        Me.rtbAbout.ReadOnly = True
        Me.rtbAbout.Size = New System.Drawing.Size(728, 320)
        Me.rtbAbout.TabIndex = 1
        Me.rtbAbout.Text = ""
        '
        'lnkNadra
        '
        Me.lnkNadra.AutoSize = True
        Me.lnkNadra.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lnkNadra.LinkColor = System.Drawing.Color.FromArgb(0, 105, 62)
        Me.lnkNadra.Location = New System.Drawing.Point(16, 440)
        Me.lnkNadra.Name = "lnkNadra"
        Me.lnkNadra.Size = New System.Drawing.Size(137, 15)
        Me.lnkNadra.TabIndex = 2
        Me.lnkNadra.TabStop = True
        Me.lnkNadra.Text = "https://www.nadra.gov.pk/"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(0, 105, 62)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(632, 430)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(112, 34)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmAbout
        '
        Me.AcceptButton = Me.btnClose
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(238, 242, 239)
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(760, 478)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lnkNadra)
        Me.Controls.Add(Me.rtbAbout)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About - NADRA CNIC Management System"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblTag As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents rtbAbout As System.Windows.Forms.RichTextBox
    Friend WithEvents lnkNadra As System.Windows.Forms.LinkLabel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents tipAbout As System.Windows.Forms.ToolTip

End Class
