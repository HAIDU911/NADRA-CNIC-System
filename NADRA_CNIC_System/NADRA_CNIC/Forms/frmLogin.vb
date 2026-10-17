Imports System.IO
Imports System.Windows.Forms

''' <summary>
''' Officer sign-in window. Includes ErrorProvider validation, a remember-me
''' check box, a show-password toggle and a 15 second lockout after three
''' failed attempts (Timer driven).
''' </summary>
Public Class frmLogin

    Private Const MaxAttempts As Integer = 3
    Private _attempts As Integer = 0
    Private _lockSeconds As Integer = 0
    Private ReadOnly RememberFile As String = Path.Combine(AppPaths.DataRoot, "remember_user.txt")

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picLogo.Image = UiTheme.MakeLogo(72)
        Icon = UiTheme.MakeWindowIcon()

        tipLogin.SetToolTip(btnLogin, "Sign in with your officer account")
        tipLogin.SetToolTip(chkShow, "Show or hide the typed password")
        tipLogin.SetToolTip(txtUser, "Enter your NADRA officer user name")

        If File.Exists(RememberFile) Then
            txtUser.Text = File.ReadAllText(RememberFile).Trim()
            chkRemember.Checked = True
            If txtUser.Text <> "" Then txtPass.Focus()
        End If
    End Sub

    ''' <summary>Gradient header with the gold underline.</summary>
    Private Sub pnlHeader_Paint(sender As Object, e As PaintEventArgs) Handles pnlHeader.Paint
        UiTheme.PaintGradient(e.Graphics, pnlHeader.ClientRectangle, UiTheme.DeepGreen, UiTheme.Green)
        Using gold As New SolidBrush(UiTheme.Gold)
            e.Graphics.FillRectangle(gold, 0, pnlHeader.Height - 4, pnlHeader.Width, 4)
        End Using
    End Sub

    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged
        txtPass.UseSystemPasswordChar = Not chkShow.Checked
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If tmrLock.Enabled Then Return

        errLogin.Clear()
        lblMsg.Text = ""

        If String.IsNullOrWhiteSpace(txtUser.Text) Then
            errLogin.SetError(txtUser, "User name is required.")
            txtUser.Focus()
            Return
        End If
        If String.IsNullOrEmpty(txtPass.Text) Then
            errLogin.SetError(txtPass, "Password is required.")
            txtPass.Focus()
            Return
        End If

        Dim message As String = ""
        Dim officer As Officer = Auth.ValidateCredentials(txtUser.Text, txtPass.Text, message)

        If officer Is Nothing Then
            _attempts += 1
            errLogin.SetError(txtUser, "Check your credentials.")
            errLogin.SetError(txtPass, "Check your credentials.")
            If _attempts >= MaxAttempts Then
                StartLockout()
            Else
                lblMsg.Text = message & "  Attempt " & _attempts.ToString() & " of " & MaxAttempts.ToString() & "."
            End If
            Return
        End If

        ' remember the user name when requested
        Try
            If chkRemember.Checked Then
                File.WriteAllText(RememberFile, txtUser.Text.Trim())
            ElseIf File.Exists(RememberFile) Then
                File.Delete(RememberFile)
            End If
        Catch
        End Try

        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub StartLockout()
        _lockSeconds = 15
        btnLogin.Enabled = False
        tmrLock.Enabled = True
        lblMsg.Text = "Too many failed attempts - locked for 15 seconds."
    End Sub

    Private Sub tmrLock_Tick(sender As Object, e As EventArgs) Handles tmrLock.Tick
        _lockSeconds -= 1
        If _lockSeconds <= 0 Then
            tmrLock.Enabled = False
            btnLogin.Enabled = True
            _attempts = 0
            lblMsg.Text = ""
            txtPass.Clear()
            txtPass.Focus()
        Else
            lblMsg.Text = "Too many failed attempts - locked for " & _lockSeconds.ToString() & " seconds."
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

End Class
