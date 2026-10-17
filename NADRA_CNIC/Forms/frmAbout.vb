Imports System.Diagnostics
Imports System.Windows.Forms

''' <summary>
''' About / project details window. Explains the assignment, the database
''' schema, the toolbox controls used and the OpenCV module.
''' </summary>
Public Class frmAbout

    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picLogo.Image = UiTheme.MakeLogo(68)
        Icon = UiTheme.MakeWindowIcon()

        tipAbout.SetToolTip(lnkNadra, "Open the official NADRA website in your browser")

        rtbAbout.Clear()
        rtbAbout.SelectionFont = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        rtbAbout.SelectionColor = UiTheme.DeepGreen
        rtbAbout.AppendText("Course: Visual Programming        Assignment # 2 (CLO-2)" & vbCrLf)
        rtbAbout.AppendText("Class: BSE - 5A & 5B        Software Engineering Department" & vbCrLf & vbCrLf)

        rtbAbout.SelectionFont = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        rtbAbout.SelectionColor = UiTheme.Green
        rtbAbout.AppendText("Question 1 requirements" & vbCrLf)
        rtbAbout.SelectionFont = New Font("Segoe UI", 9.0F)
        rtbAbout.SelectionColor = UiTheme.Ink
        rtbAbout.AppendText("Design and code a .NET application fulfilling the requirements of the NADRA " &
                            "database, utilising the maximum possible tools from the Toolbox, and use OpenCV " &
                            "for a small module showing a visual effect. Additional requirements were added " &
                            "(CNIC check-digit validation, officer login, audit trail, statistics and printing)." &
                            vbCrLf & vbCrLf)

        rtbAbout.SelectionFont = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        rtbAbout.SelectionColor = UiTheme.Green
        rtbAbout.AppendText("What this application does" & vbCrLf)
        rtbAbout.SelectionFont = New Font("Segoe UI", 9.0F)
        rtbAbout.SelectionColor = UiTheme.Ink
        rtbAbout.AppendText(" - Registers citizens in a Microsoft Access database (auto-created on first run)" & vbCrLf)
        rtbAbout.AppendText(" - Validates the 13 digit CNIC (format + mod-10 check digit) and generates new numbers" & vbCrLf)
        rtbAbout.AppendText(" - Captures the citizen photograph with OpenCV (webcam, visual effects, face detection)" & vbCrLf)
        rtbAbout.AppendText(" - Searches, edits, verifies and deletes records (BindingNavigator + DataGridView)" & vbCrLf)
        rtbAbout.AppendText(" - Prints a NADRA style identity card with PrintPreviewDialog" & vbCrLf)
        rtbAbout.AppendText(" - Charts citizen statistics (pie / column charts) and exports the register to CSV" & vbCrLf)
        rtbAbout.AppendText(" - Keeps an audit trail (logins, edits, deletes, backups) and supports backup / restore" & vbCrLf & vbCrLf)

        rtbAbout.SelectionFont = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        rtbAbout.SelectionColor = UiTheme.Green
        rtbAbout.AppendText("Technology" & vbCrLf)
        rtbAbout.SelectionFont = New Font("Segoe UI", 9.0F)
        rtbAbout.SelectionColor = UiTheme.Ink
        rtbAbout.AppendText("Visual Basic .NET (Windows Forms, .NET Framework 4.8, x86), " &
                            "Microsoft Access (ACE / Jet OLE DB), OpenCvSharp 4.11 (OpenCV wrapper)." & vbCrLf)
        rtbAbout.AppendText("Database file: " & AppPaths.DatabaseFile & vbCrLf)
        rtbAbout.AppendText("Provider: " & Db.ProviderName & vbCrLf & vbCrLf)
        rtbAbout.AppendText("This is a university assignment project. It is not affiliated with NADRA; " &
                            "the name and colours are used for academic demonstration only.")

        lnkNadra.Links.Clear()
        lnkNadra.Links.Add(0, lnkNadra.Text.Length, "https://www.nadra.gov.pk/")
    End Sub

    Private Sub lnkNadra_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkNadra.LinkClicked
        Try
            Process.Start(CStr(e.Link.LinkData))
        Catch
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

End Class
