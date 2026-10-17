<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.lblTag1 = New System.Windows.Forms.Label()
        Me.lblTag2 = New System.Windows.Forms.Label()
        Me.pnlCard = New System.Windows.Forms.Panel()
        Me.lblSignIn = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.chkShow = New System.Windows.Forms.CheckBox()
        Me.chkRemember = New System.Windows.Forms.CheckBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.lblHint = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.errLogin = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tmrLock = New System.Windows.Forms.Timer(Me.components)
        Me.tipLogin = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlHeader.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCard.SuspendLayout()
        CType(Me.errLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(1, 65, 28)
        Me.pnlHeader.Controls.Add(Me.lblTag2)
        Me.pnlHeader.Controls.Add(Me.lblTag1)
        Me.pnlHeader.Controls.Add(Me.lblBrand)
        Me.pnlHeader.Controls.Add(Me.picLogo)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(520, 110)
        Me.pnlHeader.TabIndex = 0
        '
        'picLogo
        '
        Me.picLogo.Location = New System.Drawing.Point(18, 18)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(72, 72)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'lblBrand
        '
        Me.lblBrand.AutoSize = True
        Me.lblBrand.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblBrand.ForeColor = System.Drawing.Color.White
        Me.lblBrand.Location = New System.Drawing.Point(104, 18)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(145, 37)
        Me.lblBrand.TabIndex = 1
        Me.lblBrand.Text = "N A D R A"
        '
        'lblTag1
        '
        Me.lblTag1.AutoSize = True
        Me.lblTag1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTag1.ForeColor = System.Drawing.Color.FromArgb(205, 225, 212)
        Me.lblTag1.Location = New System.Drawing.Point(107, 58)
        Me.lblTag1.Name = "lblTag1"
        Me.lblTag1.Size = New System.Drawing.Size(304, 15)
        Me.lblTag1.TabIndex = 2
        Me.lblTag1.Text = "National Database & Registration Authority"
        '
        'lblTag2
        '
        Me.lblTag2.AutoSize = True
        Me.lblTag2.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblTag2.ForeColor = System.Drawing.Color.FromArgb(218, 185, 60)
        Me.lblTag2.Location = New System.Drawing.Point(107, 78)
        Me.lblTag2.Name = "lblTag2"
        Me.lblTag2.Size = New System.Drawing.Size(126, 15)
        Me.lblTag2.TabIndex = 3
        Me.lblTag2.Text = "Government of Pakistan"
        '
        'pnlCard
        '
        Me.pnlCard.BackColor = System.Drawing.Color.White
        Me.pnlCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCard.Controls.Add(Me.lblMsg)
        Me.pnlCard.Controls.Add(Me.btnCancel)
        Me.pnlCard.Controls.Add(Me.btnLogin)
        Me.pnlCard.Controls.Add(Me.chkRemember)
        Me.pnlCard.Controls.Add(Me.chkShow)
        Me.pnlCard.Controls.Add(Me.txtPass)
        Me.pnlCard.Controls.Add(Me.lblPass)
        Me.pnlCard.Controls.Add(Me.txtUser)
        Me.pnlCard.Controls.Add(Me.lblUser)
        Me.pnlCard.Controls.Add(Me.lblSignIn)
        Me.pnlCard.Location = New System.Drawing.Point(30, 130)
        Me.pnlCard.Name = "pnlCard"
        Me.pnlCard.Size = New System.Drawing.Size(460, 300)
        Me.pnlCard.TabIndex = 1
        '
        'lblSignIn
        '
        Me.lblSignIn.AutoSize = True
        Me.lblSignIn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblSignIn.ForeColor = System.Drawing.Color.FromArgb(1, 65, 28)
        Me.lblSignIn.Location = New System.Drawing.Point(18, 14)
        Me.lblSignIn.Name = "lblSignIn"
        Me.lblSignIn.Size = New System.Drawing.Size(164, 21)
        Me.lblSignIn.TabIndex = 0
        Me.lblSignIn.Text = "Officer Sign In"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblUser.ForeColor = System.Drawing.Color.FromArgb(28, 40, 33)
        Me.lblUser.Location = New System.Drawing.Point(18, 54)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(73, 15)
        Me.lblUser.TabIndex = 1
        Me.lblUser.Text = "User Name:"
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtUser.Location = New System.Drawing.Point(18, 74)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(420, 25)
        Me.txtUser.TabIndex = 2
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPass.ForeColor = System.Drawing.Color.FromArgb(28, 40, 33)
        Me.lblPass.Location = New System.Drawing.Point(18, 108)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(63, 15)
        Me.lblPass.TabIndex = 3
        Me.lblPass.Text = "Password:"
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPass.Location = New System.Drawing.Point(18, 128)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPass.Size = New System.Drawing.Size(420, 25)
        Me.txtPass.TabIndex = 4
        Me.txtPass.UseSystemPasswordChar = True
        '
        'chkShow
        '
        Me.chkShow.AutoSize = True
        Me.chkShow.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.chkShow.ForeColor = System.Drawing.Color.FromArgb(28, 40, 33)
        Me.chkShow.Location = New System.Drawing.Point(20, 164)
        Me.chkShow.Name = "chkShow"
        Me.chkShow.Size = New System.Drawing.Size(113, 19)
        Me.chkShow.TabIndex = 5
        Me.chkShow.Text = "Show password"
        Me.chkShow.UseVisualStyleBackColor = True
        '
        'chkRemember
        '
        Me.chkRemember.AutoSize = True
        Me.chkRemember.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.chkRemember.ForeColor = System.Drawing.Color.FromArgb(28, 40, 33)
        Me.chkRemember.Location = New System.Drawing.Point(240, 164)
        Me.chkRemember.Name = "chkRemember"
        Me.chkRemember.Size = New System.Drawing.Size(159, 19)
        Me.chkRemember.TabIndex = 6
        Me.chkRemember.Text = "Remember user name"
        Me.chkRemember.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(0, 105, 62)
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(20, 200)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(205, 40)
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.Text = "Sign In"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 105, 62)
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(1, 65, 28)
        Me.btnCancel.Location = New System.Drawing.Point(235, 200)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(205, 40)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Exit"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblMsg
        '
        Me.lblMsg.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblMsg.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0)
        Me.lblMsg.Location = New System.Drawing.Point(20, 252)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(420, 36)
        Me.lblMsg.TabIndex = 9
        Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHint
        '
        Me.lblHint.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblHint.ForeColor = System.Drawing.Color.FromArgb(28, 40, 33)
        Me.lblHint.Location = New System.Drawing.Point(30, 440)
        Me.lblHint.Name = "lblHint"
        Me.lblHint.Size = New System.Drawing.Size(460, 34)
        Me.lblHint.TabIndex = 2
        Me.lblHint.Text = "Accounts:  officer / officer123  (Verification Officer)     |     admin / nadra1" &
    "23  (Administrator)"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.lblVersion.ForeColor = System.Drawing.Color.FromArgb(90, 110, 98)
        Me.lblVersion.Location = New System.Drawing.Point(30, 478)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(229, 13)
        Me.lblVersion.TabIndex = 3
        Me.lblVersion.Text = "NADRA CNIC Management System v1.0  -  Academic Project"
        '
        'errLogin
        '
        Me.errLogin.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errLogin.ContainerControl = Me
        '
        'tmrLock
        '
        Me.tmrLock.Interval = 1000
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(238, 242, 239)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(520, 500)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblHint)
        Me.Controls.Add(Me.pnlCard)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign In - NADRA CNIC Management System"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCard.ResumeLayout(False)
        Me.pnlCard.PerformLayout()
        CType(Me.errLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblBrand As System.Windows.Forms.Label
    Friend WithEvents lblTag1 As System.Windows.Forms.Label
    Friend WithEvents lblTag2 As System.Windows.Forms.Label
    Friend WithEvents pnlCard As System.Windows.Forms.Panel
    Friend WithEvents lblSignIn As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents chkShow As System.Windows.Forms.CheckBox
    Friend WithEvents chkRemember As System.Windows.Forms.CheckBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents lblHint As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents errLogin As System.Windows.Forms.ErrorProvider
    Friend WithEvents tmrLock As System.Windows.Forms.Timer
    Friend WithEvents tipLogin As System.Windows.Forms.ToolTip

End Class
