Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

''' <summary>
''' Everything that gives the application its NADRA look: the official green colour
''' scheme, shared fonts, the gradient header painter, the hand-drawn NADRA style
''' logo and the icon factory used by the menu and toolbar (no image files needed).
''' </summary>
Friend NotInheritable Class UiTheme

    Private Sub New()
    End Sub

    ' ------------------------------------------------------------------ palette
    ' Colours follow the NADRA corporate identity (deep green / white / gold).

    Public Shared ReadOnly DeepGreen As Color = Color.FromArgb(1, 65, 28)
    Public Shared ReadOnly Green As Color = Color.FromArgb(0, 105, 62)
    Public Shared ReadOnly BrightGreen As Color = Color.FromArgb(0, 158, 72)
    Public Shared ReadOnly PaleGreen As Color = Color.FromArgb(231, 244, 236)
    Public Shared ReadOnly Gold As Color = Color.FromArgb(218, 185, 60)
    Public Shared ReadOnly Canvas As Color = Color.FromArgb(238, 242, 239)
    Public Shared ReadOnly Ink As Color = Color.FromArgb(28, 40, 33)
    Public Shared ReadOnly SoftWhite As Color = Color.FromArgb(247, 250, 248)

    ' ------------------------------------------------------------------ fonts

    Public Shared ReadOnly FontTitle As New Font("Segoe UI", 22.0F, FontStyle.Bold)
    Public Shared ReadOnly FontHeader As New Font("Segoe UI", 12.0F, FontStyle.Bold)
    Public Shared ReadOnly FontSection As New Font("Segoe UI", 9.75F, FontStyle.Bold)
    Public Shared ReadOnly FontNormal As New Font("Segoe UI", 9.0F)
    Public Shared ReadOnly FontSmall As New Font("Segoe UI", 8.0F)
    Public Shared ReadOnly FontBigNumber As New Font("Segoe UI", 26.0F, FontStyle.Bold)

    ' ------------------------------------------------------------------ painting

    ''' <summary>Vertical gradient used for every green header bar.</summary>
    Public Shared Sub PaintGradient(g As Graphics, rect As Rectangle, topColor As Color, bottomColor As Color)
        Using br As New LinearGradientBrush(rect, topColor, bottomColor, LinearGradientMode.Vertical)
            g.FillRectangle(br, rect)
        End Using
    End Sub

    ''' <summary>Paints a NADRA style title bar into a panel (gradient + title + subtitle).</summary>
    Public Shared Sub PaintHeader(sender As Object, e As PaintEventArgs, title As String, subtitle As String)
        Dim pnl As Panel = DirectCast(sender, Panel)
        Dim rect As New Rectangle(0, 0, pnl.Width, pnl.Height)
        PaintGradient(e.Graphics, rect, DeepGreen, Green)

        ' gold underline
        Using br As New SolidBrush(Gold)
            e.Graphics.FillRectangle(br, 0, pnl.Height - 3, pnl.Width, 3)
        End Using

        Using titleFont As New Font("Segoe UI", 14.0F, FontStyle.Bold)
            Using br As New SolidBrush(Color.White)
                e.Graphics.DrawString(title, titleFont, br, 14, 8)
            End Using
        End Using
        If Not String.IsNullOrEmpty(subtitle) Then
            Using br As New SolidBrush(Color.FromArgb(205, 225, 212))
                e.Graphics.DrawString(subtitle, FontNormal, br, 16, pnl.Height - 26)
            End Using
        End If
    End Sub

    ' ------------------------------------------------------------------ logo

    ''' <summary>
    ''' Draws the NADRA style emblem: a deep green roundel with the white crescent and
    ''' star (as used on the national identity card) - fully generated with GDI+.
    ''' </summary>
    Public Shared Function MakeLogo(size As Integer) As Bitmap
        Dim bmp As New Bitmap(size, size)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.SmoothingMode = SmoothingMode.AntiAlias
            Dim rect As New Rectangle(0, 0, size - 1, size - 1)

            Using br As New LinearGradientBrush(rect, BrightGreen, DeepGreen, LinearGradientMode.ForwardDiagonal)
                g.FillEllipse(br, rect)
            End Using
            Using pen As New Pen(Gold, Math.Max(2.0F, size / 24.0F))
                g.DrawEllipse(pen, rect)
            End Using

            ' crescent: outer disc with an offset inner disc excluded
            Dim cx As Single = size * 0.46F
            Dim cy As Single = size * 0.5F
            Dim r As Single = size * 0.3F
            Dim shift As Single = r * 0.55F
            Using outer As New GraphicsPath()
                outer.AddEllipse(cx - r, cy - r, r * 2, r * 2)
                Using inner As New GraphicsPath()
                    inner.AddEllipse(cx - r + shift, cy - r - shift * 0.15F, r * 2, r * 2)
                    Using reg As New Region(outer)
                        reg.Exclude(inner)
                        Using white As New SolidBrush(Color.White)
                            g.FillRegion(white, reg)
                        End Using
                    End Using
                End Using
            End Using

            ' five pointed star at the opening of the crescent
            Dim starCenter As New PointF(size * 0.66F, size * 0.34F)
            Dim pts As PointF() = StarPoints(starCenter, size * 0.11F, size * 0.045F)
            Using white As New SolidBrush(Color.White)
                g.FillPolygon(white, pts)
            End Using
        End Using
        Return bmp
    End Function

    Private Shared Function StarPoints(center As PointF, outerR As Single, innerR As Single) As PointF()
        Dim pts(9) As PointF
        For i As Integer = 0 To 9
            Dim angle As Double = (-Math.PI / 2) + i * (Math.PI / 5)
            Dim radius As Single = If(i Mod 2 = 0, outerR, innerR)
            pts(i) = New PointF(CSng(center.X + radius * Math.Cos(angle)),
                                CSng(center.Y + radius * Math.Sin(angle)))
        Next
        Return pts
    End Function

    ' ------------------------------------------------------------------ icons

    ''' <summary>
    ''' Generates the small white glyphs used by the toolbar, menu and tree view.
    ''' Kinds: new, save, edit, delete, search, print, camera, chart, database,
    ''' backup, info, fullscreen, exit, refresh, verify, image, play, stop, home.
    ''' </summary>
    Public Shared Function MakeIcon(kind As String, Optional size As Integer = 22) As Bitmap
        Dim bmp As New Bitmap(size, size)
        Dim s As Single = size
        Using g As Graphics = Graphics.FromImage(bmp)
            g.SmoothingMode = SmoothingMode.AntiAlias
            Dim white As New SolidBrush(Color.White)
            Dim pen As New Pen(Color.White, Math.Max(1.6F, s / 11.0F))
            Try
                Select Case kind.ToLower()
                    Case "new"
                        g.FillRectangle(white, s * 0.18F, s * 0.1F, s * 0.5F, s * 0.68F)
                        Using bg As New SolidBrush(Green)
                            g.FillRectangle(bg, s * 0.24F, s * 0.34F, s * 0.38F, s * 0.06F)
                            g.FillRectangle(bg, s * 0.24F, s * 0.46F, s * 0.38F, s * 0.06F)
                        End Using
                        g.FillEllipse(white, s * 0.55F, s * 0.55F, s * 0.36F, s * 0.36F)
                        Using gp As New GraphicsPath()
                            gp.AddLine(s * 0.64F, s * 0.73F, s * 0.82F, s * 0.73F)
                            gp.AddLine(s * 0.73F, s * 0.64F, s * 0.73F, s * 0.82F)
                            g.DrawPath(pen, gp)
                        End Using
                    Case "save"
                        g.FillRectangle(white, s * 0.12F, s * 0.12F, s * 0.76F, s * 0.76F)
                        Using bg As New SolidBrush(Green)
                            g.FillRectangle(bg, s * 0.32F, s * 0.12F, s * 0.36F, s * 0.28F)
                            g.FillRectangle(bg, s * 0.2F, s * 0.56F, s * 0.6F, s * 0.32F)
                        End Using
                    Case "edit"
                        Using gp As New GraphicsPath()
                            gp.AddPolygon({New PointF(s * 0.72F, s * 0.12F), New PointF(s * 0.88F, s * 0.28F),
                                           New PointF(s * 0.5F, s * 0.66F), New PointF(s * 0.3F, s * 0.7F),
                                           New PointF(s * 0.34F, s * 0.5F)})
                            g.FillPath(white, gp)
                        End Using
                    Case "delete"
                        Using gp As New GraphicsPath()
                            gp.AddRectangle(New RectangleF(s * 0.2F, s * 0.28F, s * 0.6F, s * 0.58F))
                            g.DrawPath(pen, gp)
                            g.DrawLine(pen, s * 0.12F, s * 0.22F, s * 0.88F, s * 0.22F)
                            g.DrawLine(pen, s * 0.38F, s * 0.12F, s * 0.62F, s * 0.22F)
                        End Using
                    Case "search"
                        g.DrawEllipse(pen, s * 0.16F, s * 0.14F, s * 0.5F, s * 0.5F)
                        g.DrawLine(pen, s * 0.6F, s * 0.6F, s * 0.86F, s * 0.86F)
                    Case "print"
                        g.FillRectangle(white, s * 0.26F, s * 0.12F, s * 0.48F, s * 0.28F)
                        g.FillRectangle(white, s * 0.12F, s * 0.4F, s * 0.76F, s * 0.3F)
                        g.FillRectangle(white, s * 0.26F, s * 0.62F, s * 0.48F, s * 0.26F)
                        Using bg As New SolidBrush(Green)
                            g.FillRectangle(bg, s * 0.2F, s * 0.46F, s * 0.24F, s * 0.08F)
                        End Using
                    Case "camera"
                        g.FillRectangle(white, s * 0.1F, s * 0.26F, s * 0.8F, s * 0.52F)
                        Using bg As New SolidBrush(Green)
                            g.FillEllipse(bg, s * 0.3F, s * 0.36F, s * 0.32F, s * 0.32F)
                        End Using
                        g.FillRectangle(white, s * 0.36F, s * 0.16F, s * 0.28F, s * 0.12F)
                    Case "chart"
                        g.FillRectangle(white, s * 0.14F, s * 0.5F, s * 0.18F, s * 0.38F)
                        g.FillRectangle(white, s * 0.4F, s * 0.28F, s * 0.18F, s * 0.6F)
                        g.FillRectangle(white, s * 0.66F, s * 0.4F, s * 0.18F, s * 0.48F)
                    Case "database"
                        g.FillEllipse(white, s * 0.14F, s * 0.1F, s * 0.72F, s * 0.22F)
                        g.FillRectangle(white, s * 0.14F, s * 0.21F, s * 0.72F, s * 0.5F)
                        g.FillEllipse(white, s * 0.14F, s * 0.58F, s * 0.72F, s * 0.22F)
                        Using bg As New SolidBrush(Green)
                            g.FillEllipse(bg, s * 0.24F, s * 0.16F, s * 0.52F, s * 0.1F)
                            g.FillEllipse(bg, s * 0.24F, s * 0.42F, s * 0.52F, s * 0.1F)
                        End Using
                    Case "backup"
                        g.FillRectangle(white, s * 0.16F, s * 0.6F, s * 0.68F, s * 0.26F)
                        Using gp As New GraphicsPath()
                            gp.AddPolygon({New PointF(s * 0.5F, s * 0.08F), New PointF(s * 0.72F, s * 0.34F),
                                           New PointF(s * 0.6F, s * 0.34F), New PointF(s * 0.6F, s * 0.52F),
                                           New PointF(s * 0.4F, s * 0.52F), New PointF(s * 0.4F, s * 0.34F),
                                           New PointF(s * 0.28F, s * 0.34F)})
                            g.FillPath(white, gp)
                        End Using
                    Case "info"
                        g.DrawEllipse(pen, s * 0.12F, s * 0.12F, s * 0.76F, s * 0.76F)
                        g.FillEllipse(white, s * 0.42F, s * 0.22F, s * 0.16F, s * 0.16F)
                        g.FillRectangle(white, s * 0.44F, s * 0.42F, s * 0.12F, s * 0.34F)
                    Case "fullscreen"
                        g.DrawLines(pen, {New PointF(s * 0.42F, s * 0.12F), New PointF(s * 0.12F, s * 0.12F),
                                          New PointF(s * 0.12F, s * 0.42F)})
                        g.DrawLines(pen, {New PointF(s * 0.58F, s * 0.12F), New PointF(s * 0.88F, s * 0.12F),
                                          New PointF(s * 0.88F, s * 0.42F)})
                        g.DrawLines(pen, {New PointF(s * 0.12F, s * 0.58F), New PointF(s * 0.12F, s * 0.88F),
                                          New PointF(s * 0.42F, s * 0.88F)})
                        g.DrawLines(pen, {New PointF(s * 0.88F, s * 0.58F), New PointF(s * 0.88F, s * 0.88F),
                                          New PointF(s * 0.58F, s * 0.88F)})
                    Case "exit"
                        g.DrawRectangle(pen, s * 0.12F, s * 0.12F, s * 0.44F, s * 0.76F)
                        g.DrawLine(pen, s * 0.34F, s * 0.5F, s * 0.9F, s * 0.5F)
                        g.DrawLines(pen, {New PointF(s * 0.72F, s * 0.32F), New PointF(s * 0.9F, s * 0.5F),
                                          New PointF(s * 0.72F, s * 0.68F)})
                    Case "refresh"
                        g.DrawArc(pen, s * 0.16F, s * 0.16F, s * 0.68F, s * 0.68F, 40, 280)
                        Using gp As New GraphicsPath()
                            gp.AddPolygon({New PointF(s * 0.86F, s * 0.5F), New PointF(s * 0.66F, s * 0.36F),
                                           New PointF(s * 0.66F, s * 0.62F)})
                            g.FillPath(white, gp)
                        End Using
                    Case "verify"
                        Using gp As New GraphicsPath()
                            gp.AddPolygon({New PointF(s * 0.5F, s * 0.08F), New PointF(s * 0.86F, s * 0.22F),
                                           New PointF(s * 0.82F, s * 0.62F), New PointF(s * 0.5F, s * 0.92F),
                                           New PointF(s * 0.18F, s * 0.62F), New PointF(s * 0.14F, s * 0.22F)})
                            g.DrawPath(pen, gp)
                        End Using
                        g.DrawLines(pen, {New PointF(s * 0.34F, s * 0.5F), New PointF(s * 0.46F, s * 0.64F),
                                          New PointF(s * 0.68F, s * 0.36F)})
                    Case "image"
                        g.FillRectangle(white, s * 0.12F, s * 0.2F, s * 0.76F, s * 0.6F)
                        Using bg As New SolidBrush(Green)
                            g.FillPolygon(bg, {New PointF(s * 0.2F, s * 0.7F), New PointF(s * 0.4F, s * 0.42F),
                                               New PointF(s * 0.54F, s * 0.6F), New PointF(s * 0.66F, s * 0.48F),
                                               New PointF(s * 0.8F, s * 0.7F)})
                            g.FillEllipse(bg, s * 0.6F, s * 0.28F, s * 0.12F, s * 0.12F)
                        End Using
                    Case "play"
                        Using gp As New GraphicsPath()
                            gp.AddPolygon({New PointF(s * 0.28F, s * 0.16F), New PointF(s * 0.84F, s * 0.5F),
                                           New PointF(s * 0.28F, s * 0.84F)})
                            g.FillPath(white, gp)
                        End Using
                    Case "stop"
                        g.FillRectangle(white, s * 0.2F, s * 0.2F, s * 0.6F, s * 0.6F)
                    Case "home"
                        Using gp As New GraphicsPath()
                            gp.AddPolygon({New PointF(s * 0.5F, s * 0.1F), New PointF(s * 0.9F, s * 0.48F),
                                           New PointF(s * 0.78F, s * 0.48F), New PointF(s * 0.78F, s * 0.86F),
                                           New PointF(s * 0.22F, s * 0.86F), New PointF(s * 0.22F, s * 0.48F),
                                           New PointF(s * 0.1F, s * 0.48F)})
                            g.FillPath(white, gp)
                        End Using
                    Case Else
                        g.FillEllipse(white, s * 0.25F, s * 0.25F, s * 0.5F, s * 0.5F)
                End Select
                white.Dispose()
                pen.Dispose()
            Catch
            End Try
        End Using
        Return bmp
    End Function

    <System.Runtime.InteropServices.DllImport("user32.dll", CharSet:=System.Runtime.InteropServices.CharSet.Auto)>
    Private Shared Function DestroyIcon(handle As IntPtr) As Boolean
    End Function

    ''' <summary>Converts a drawn glyph into an Icon for the window / notification area.</summary>
    Public Shared Function MakeWindowIcon() As Icon
        Using bmp As Bitmap = MakeLogo(32)
            Dim hIcon As IntPtr = bmp.GetHicon()
            Try
                Using tempIcon As Icon = Icon.FromHandle(hIcon)
                    Return DirectCast(tempIcon.Clone(), Icon)
                End Using
            Finally
                DestroyIcon(hIcon)
            End Try
        End Using
    End Function

    ' ------------------------------------------------------------------ control styling

    ''' <summary>Green professional renderer for every MenuStrip / ToolStrip / StatusStrip.</summary>
    Public Shared Sub ApplyToolStripTheme(ts As ToolStrip)
        ' Setting Renderer switches RenderMode to Custom automatically;
        ' assigning RenderMode = Custom explicitly throws at run time.
        ts.Renderer = New ToolStripProfessionalRenderer(New NadraColourTable())
        ts.BackColor = DeepGreen
        ts.ForeColor = Color.White
        ts.Font = New Font("Segoe UI", 9.0F)
        For Each item As ToolStripItem In ts.Items
            item.ForeColor = Color.White
            If TypeOf item Is ToolStripDropDownItem Then
                For Each subItem As ToolStripItem In DirectCast(item, ToolStripDropDownItem).DropDownItems
                    subItem.ForeColor = Ink
                Next
            End If
        Next
    End Sub

    ''' <summary>NADRA green colour table used by the strip renderer.</summary>
    Friend Class NadraColourTable
        Inherits ProfessionalColorTable

        Public Overrides ReadOnly Property ToolStripGradientBegin As Color
            Get
                Return DeepGreen
            End Get
        End Property
        Public Overrides ReadOnly Property ToolStripGradientMiddle As Color
            Get
                Return Green
            End Get
        End Property
        Public Overrides ReadOnly Property ToolStripGradientEnd As Color
            Get
                Return Green
            End Get
        End Property
        Public Overrides ReadOnly Property ToolStripDropDownBackground As Color
            Get
                Return Color.White
            End Get
        End Property
        Public Overrides ReadOnly Property ImageMarginGradientBegin As Color
            Get
                Return Green
            End Get
        End Property
        Public Overrides ReadOnly Property ImageMarginGradientMiddle As Color
            Get
                Return DeepGreen
            End Get
        End Property
        Public Overrides ReadOnly Property ImageMarginGradientEnd As Color
            Get
                Return DeepGreen
            End Get
        End Property
        Public Overrides ReadOnly Property MenuItemSelected As Color
            Get
                Return BrightGreen
            End Get
        End Property
        Public Overrides ReadOnly Property MenuItemSelectedGradientBegin As Color
            Get
                Return BrightGreen
            End Get
        End Property
        Public Overrides ReadOnly Property MenuItemSelectedGradientEnd As Color
            Get
                Return BrightGreen
            End Get
        End Property
        Public Overrides ReadOnly Property MenuItemBorder As Color
            Get
                Return Gold
            End Get
        End Property
        Public Overrides ReadOnly Property MenuBorder As Color
            Get
                Return DeepGreen
            End Get
        End Property
        Public Overrides ReadOnly Property SeparatorDark As Color
            Get
                Return Color.FromArgb(120, 200, 160)
            End Get
        End Property
        Public Overrides ReadOnly Property SeparatorLight As Color
            Get
                Return Color.FromArgb(120, 200, 160)
            End Get
        End Property
    End Class

    ''' <summary>Shared DataGridView styling (green header, zebra rows, green selection).</summary>
    Public Shared Sub StyleGrid(grid As DataGridView)
        grid.EnableHeadersVisualStyles = False
        grid.BackgroundColor = Color.White
        grid.BorderStyle = BorderStyle.FixedSingle
        grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        grid.GridColor = Color.FromArgb(220, 230, 223)
        grid.RowHeadersVisible = False
        grid.AllowUserToAddRows = False
        grid.AllowUserToDeleteRows = False
        grid.AllowUserToResizeRows = False
        grid.MultiSelect = False
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        With grid.ColumnHeadersDefaultCellStyle
            .BackColor = Green
            .ForeColor = Color.White
            .Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
            .SelectionBackColor = Green
        End With
        grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        grid.ColumnHeadersHeight = 34

        With grid.DefaultCellStyle
            .Font = FontNormal
            .BackColor = Color.White
            .ForeColor = Ink
            .SelectionBackColor = PaleGreen
            .SelectionForeColor = Ink
        End With
        With grid.AlternatingRowsDefaultCellStyle
            .BackColor = SoftWhite
        End With
    End Sub

    ''' <summary>Styles a group box consistently on every form.</summary>
    Public Shared Sub StyleGroup(grp As GroupBox)
        grp.Font = FontSection
        grp.ForeColor = DeepGreen
        grp.Margin = New Padding(6)
    End Sub

End Class
