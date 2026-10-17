Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Printing
Imports System.IO
Imports System.Windows.Forms

''' <summary>
''' Renders a NADRA style identity card (green header, photograph, all citizen
''' fields, issue/expiry and check-digit badge) plus a record summary below it.
''' Used with PrintPreviewDialog, PrintDialog and PageSetupDialog.
''' </summary>
Friend Class CnicPrint
    Inherits PrintDocument

    Private ReadOnly _c As Citizen

    Public Sub New(c As Citizen)
        MyBase.New()
        _c = c
        DocumentName = "NADRA CNIC - " & c.Cnic
        DefaultPageSettings.Landscape = True
        DefaultPageSettings.Margins = New Margins(45, 45, 45, 45)
    End Sub

    ''' <summary>Opens the print preview window for the given document.</summary>
    Public Shared Sub ShowPreview(doc As PrintDocument, owner As IWin32Window)
        Using dlg As New PrintPreviewDialog()
            dlg.Document = doc
            dlg.UseAntiAlias = True
            dlg.Width = 1080
            dlg.Height = 760
            dlg.ShowIcon = False
            dlg.Text = "Print Preview - NADRA Identity Card"
            dlg.ShowDialog(owner)
        End Using
    End Sub

    Protected Overrides Sub OnBeginPrint(e As PrintEventArgs)
        MyBase.OnBeginPrint(e)
    End Sub

    Protected Overrides Sub OnPrintPage(e As PrintPageEventArgs)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias
        g.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit

        Dim area As Rectangle = e.MarginBounds

        ' ---------------------------------------------------------- page heading
        Using f As New Font("Segoe UI", 14.0F, FontStyle.Bold)
            Using br As New SolidBrush(UiTheme.DeepGreen)
                g.DrawString("NATIONAL DATABASE & REGISTRATION AUTHORITY", f, br, area.Left, area.Top)
            End Using
        End Using
        Using f As New Font("Segoe UI", 9.0F)
            Using br As New SolidBrush(Color.FromArgb(90, 110, 98))
                g.DrawString("Computerised National Identity Card - specimen print produced by the " &
                             "NADRA CNIC Management System", f, br, area.Left, area.Top + 28)
            End Using
        End Using

        ' ---------------------------------------------------------- the card
        Dim card As New Rectangle(area.Left, area.Top + 58, 790, 420)
        Using shadow As New SolidBrush(Color.FromArgb(35, 0, 0, 0))
            g.FillRectangle(shadow, card.X + 6, card.Y + 6, card.Width, card.Height)
        End Using
        Using border As New Pen(UiTheme.DeepGreen, 2.0F)
            g.FillRectangle(Brushes.White, card)
            g.DrawRectangle(border, card)
        End Using

        ' green header band
        Dim header As New Rectangle(card.X + 2, card.Y + 2, card.Width - 3, 86)
        Using br As New LinearGradientBrush(header, UiTheme.BrightGreen, UiTheme.DeepGreen, LinearGradientMode.Horizontal)
            g.FillRectangle(br, header)
        End Using
        Using gold As New SolidBrush(UiTheme.Gold)
            g.FillRectangle(gold, header.X, header.Bottom - 3, header.Width, 3)
        End Using

        Using logo As Bitmap = UiTheme.MakeLogo(64)
            g.DrawImage(logo, header.X + 14, header.Y + 11, 64, 64)
        End Using
        Using f As New Font("Segoe UI", 20.0F, FontStyle.Bold)
            Using br As New SolidBrush(Color.White)
                g.DrawString("N A D R A", f, br, header.X + 92, header.Y + 14)
            End Using
        End Using
        Using f As New Font("Segoe UI", 8.5F)
            Using br As New SolidBrush(Color.FromArgb(215, 230, 222))
                g.DrawString("National Database & Registration Authority - Government of Pakistan",
                             f, br, header.X + 96, header.Y + 54)
            End Using
        End Using
        Using f As New Font("Segoe UI", 10.0F, FontStyle.Bold)
            Using br As New SolidBrush(UiTheme.Gold)
                g.DrawString("IDENTITY CARD", f, br, header.Right - 150, header.Y + 18)
                g.DrawString("PAKISTAN", f, br, header.Right - 120, header.Y + 40)
            End Using
        End Using

        ' ---------------------------------------------------------- photograph
        Dim photoRect As New Rectangle(card.X + 18, card.Y + 104, 150, 190)
        Using pale As New SolidBrush(UiTheme.PaleGreen)
            g.FillRectangle(pale, photoRect)
        End Using
        Using pen As New Pen(UiTheme.Green, 1.5F)
            g.DrawRectangle(pen, photoRect)
        End Using
        Dim photoDrawn As Boolean = False
        If _c.PhotoPath <> "" AndAlso File.Exists(_c.PhotoPath) Then
            Try
                Using fs As New FileStream(_c.PhotoPath, FileMode.Open, FileAccess.Read)
                    Using img As Image = Image.FromStream(fs)
                        g.DrawImage(img, photoRect)
                        photoDrawn = True
                    End Using
                End Using
            Catch
            End Try
        End If
        If Not photoDrawn Then
            Using f As New Font("Segoe UI", 9.0F, FontStyle.Bold)
                Using br As New SolidBrush(UiTheme.Green)
                    g.DrawString("RECENT", f, br, photoRect.X + 45, photoRect.Y + 80)
                    g.DrawString("PHOTOGRAPH", f, br, photoRect.X + 24, photoRect.Y + 98)
                End Using
            End Using
        End If

        ' signature strip under the photo
        Dim sigRect As New Rectangle(photoRect.X, photoRect.Bottom + 10, 150, 34)
        g.DrawRectangle(Pens.Gray, sigRect)
        Using f As New Font("Segoe UI", 7.0F)
            Using br As New SolidBrush(Color.Gray)
                g.DrawString("Card holder signature", f, br, sigRect.X + 6, sigRect.Y + 10)
            End Using
        End Using

        ' ---------------------------------------------------------- fields
        Dim xLeft As Integer = card.X + 186
        Dim xRight As Integer = card.X + 476
        Dim y As Integer = card.Y + 104

        DrawField(g, "CNIC NUMBER", CitizenStore.FormatCnic(_c.Cnic), xLeft, y, 270, 18.0F, True)
        y += 40
        DrawField(g, "NAME", _c.Name, xLeft, y, 290)
        DrawField(g, "FATHER / HUSBAND", _c.FatherName, xRight, y, 290)
        y += 46
        DrawField(g, "DATE OF BIRTH", If(_c.DateOfBirth.Year > 1900, _c.DateOfBirth.ToString("dd MMM yyyy"), "-"),
                  xLeft, y, 140)
        DrawField(g, "GENDER", _c.Gender, xLeft + 160, y, 110)
        DrawField(g, "BLOOD GROUP", _c.BloodGroup, xLeft + 290, y, 110)
        y += 44
        DrawField(g, "MARITAL STATUS", _c.MaritalStatus, xLeft, y, 140)
        DrawField(g, "RELIGION", _c.Religion, xLeft + 160, y, 110)
        DrawField(g, "NATIONALITY", _c.Nationality, xLeft + 290, y, 150)
        y += 44
        DrawField(g, "ADDRESS", _c.PresentAddress, xLeft, y, 590, 9.0F, False)
        y += 34
        DrawField(g, "CITY / PROVINCE", _c.City & ", " & _c.Province, xLeft, y, 290)
        DrawField(g, "MOBILE", _c.Mobile, xRight, y, 160)
        DrawField(g, "E-MAIL", _c.Email, xRight + 170, y, 160)
        y += 44
        DrawField(g, "DATE OF ISSUE", If(_c.IssueDate.Year > 1900, _c.IssueDate.ToString("dd MMM yyyy"), "-"), xLeft, y, 150)
        DrawField(g, "DATE OF EXPIRY", If(_c.ExpiryDate.Year > 1900, _c.ExpiryDate.ToString("dd MMM yyyy"), "-"), xLeft + 170, y, 150)
        DrawField(g, "ISSUING OFFICE", _c.OfficeName, xLeft + 340, y, 260)

        ' check digit badge
        Dim badge As New Rectangle(card.Right - 158, card.Y + 100, 140, 26)
        Using br As New SolidBrush(If(CitizenStore.HasValidCheckDigit(_c.Cnic), Color.FromArgb(0, 140, 60), Color.Firebrick))
            g.FillRectangle(br, badge)
        End Using
        Using f As New Font("Segoe UI", 7.5F, FontStyle.Bold)
            Using br As New SolidBrush(Color.White)
                g.DrawString(If(CitizenStore.HasValidCheckDigit(_c.Cnic), "CHECK DIGIT: VALID", "CHECK DIGIT: INVALID"),
                             f, br, badge.X + 8, badge.Y + 7)
            End Using
        End Using

        ' footer band
        Dim footer As New Rectangle(card.X + 2, card.Bottom - 44, card.Width - 3, 42)
        Using br As New SolidBrush(UiTheme.DeepGreen)
            g.FillRectangle(br, footer)
        End Using
        Using f As New Font("Segoe UI", 7.5F)
            Using br As New SolidBrush(Color.FromArgb(215, 230, 222))
                g.DrawString("This card is the property of NADRA and remains valid until the expiry date shown. " &
                             "If found, please return it to the nearest NADRA office.", f, br, footer.X + 12, footer.Y + 8)
                g.DrawString("www.nadra.gov.pk", f, br, footer.Right - 100, footer.Y + 22)
            End Using
        End Using

        ' ---------------------------------------------------------- record summary
        Dim sy As Integer = card.Bottom + 24
        Using f As New Font("Segoe UI", 10.0F, FontStyle.Bold)
            Using br As New SolidBrush(UiTheme.DeepGreen)
                g.DrawString("Citizen record summary", f, br, area.Left, sy)
            End Using
        End Using
        sy += 26

        Dim summary As String =
            "Registration status : " & If(_c.IsVerified, "Biometrically verified", "Pending verification") & vbCrLf &
            "Documents on file   : " & If(_c.Documents = "", "-", _c.Documents) & vbCrLf &
            "Occupation          : " & If(_c.Occupation = "", "-", _c.Occupation) &
            "        Education: " & If(_c.Education = "", "-", _c.Education) & vbCrLf &
            "Area type           : " & _c.AreaType & "        Permanent address: " &
            If(_c.PermanentAddress = "", "-", _c.PermanentAddress) & vbCrLf &
            "Telephone           : " & If(_c.Phone = "", "-", _c.Phone) &
            "        Mobile: " & If(_c.Mobile = "", "-", _c.Mobile) & vbCrLf &
            "Officer remarks     : " & If(_c.Notes = "", "-", _c.Notes)

        Using f As New Font("Segoe UI", 8.5F)
            Using br As New SolidBrush(UiTheme.Ink)
                g.DrawString(summary, f, br, New RectangleF(area.Left, sy, area.Width, 130))
            End Using
        End Using

        sy += 122
        Using f As New Font("Segoe UI", 7.5F)
            Using br As New SolidBrush(Color.FromArgb(110, 120, 115))
                Dim officer As String = If(Session.Current IsNot Nothing, Session.UserLabel, "System")
                g.DrawString("Printed by: " & officer & "        Printed on: " & Now.ToString("dd MMM yyyy HH:mm") &
                             "        NADRA CNIC Management System v1.0 (Visual Programming Assignment #2)",
                             f, br, area.Left, sy)
            End Using
        End Using

        e.HasMorePages = False
    End Sub

    ''' <summary>Draws a caption + value pair and advances nothing (caller controls Y).</summary>
    Private Sub DrawField(g As Graphics, caption As String, value As String, x As Integer, y As Integer,
                          width As Integer, Optional valueSize As Single = 10.0F, Optional big As Boolean = False)
        Using fc As New Font("Segoe UI", 6.5F, FontStyle.Bold)
            Using br As New SolidBrush(Color.FromArgb(110, 125, 118))
                g.DrawString(caption, fc, br, x, y)
            End Using
        End Using

        Dim text As String = If(value = "", "-", value)
        Using fv As New Font("Segoe UI", valueSize, If(big, FontStyle.Bold, FontStyle.Regular))
            Using br As New SolidBrush(UiTheme.Ink)
                g.DrawString(text, fv, br, New RectangleF(x, y + 10, width, 34))
            End Using
        End Using
    End Sub

End Class
