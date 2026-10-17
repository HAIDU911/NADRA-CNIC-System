Imports System.Data
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports System.Windows.Forms.DataVisualization.Charting

''' <summary>
''' Reports window: key figures, a gender pie chart, a provinces column chart,
''' top cities list and a CSV export of the whole register.
''' </summary>
Public Class frmStats

    Private Sub frmStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiTheme.StyleGroup(grpKpi)
        UiTheme.StyleGroup(grpCities)

        tipStats.SetToolTip(numTop, "How many cities to list")
        tipStats.SetToolTip(btnExport, "Write the whole citizens register to a CSV file")

        RefreshData()
    End Sub

    Public Sub RefreshData()
        Try
            Dim stats As CitizenStats = CitizenStore.GetStats()
            lblKpiTotal.Text = stats.Total.ToString()
            lblKpiFemale.Text = stats.Female.ToString()
            lblKpiVerified.Text = stats.Verified.ToString()
            lblKpiPending.Text = stats.Pending.ToString()
            lblKpiToday.Text = stats.RegisteredToday.ToString()

            BuildGenderChart()
            BuildProvinceChart()
            FillCities()

            lblUpdated.Text = "Last updated: " & Now.ToString("HH:mm:ss")
        Catch ex As Exception
            lblUpdated.Text = "Could not load statistics: " & ex.Message
        End Try
    End Sub

    Private Sub PrepareChart(ch As Chart, title As String)
        ch.Series.Clear()
        ch.Titles.Clear()
        ch.Legends.Clear()
        If ch.ChartAreas.Count = 0 Then ch.ChartAreas.Add("Main")
        ch.ChartAreas(0).BackColor = Color.White

        Using f As New Font("Segoe UI", 11.0F, FontStyle.Bold)
            ch.Titles.Add(New Title(title, Docking.Top, f, UiTheme.DeepGreen))
        End Using
    End Sub

    Private Sub BuildGenderChart()
        PrepareChart(chartGender, "Gender distribution")
        chartGender.Palette = ChartColorPalette.None

        Dim dt As DataTable = CitizenStore.GroupCount("Gender")
        Dim ser As New Series("Gender")
        ser.ChartType = SeriesChartType.Pie
        ser.IsValueShownAsLabel = True
        ser.Label = "#VALX: #VAL (#PERCENT{P0})"
        ser.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)

        For Each row As DataRow In dt.Rows
            Dim label As String = CStr(row("LabelName"))
            Dim count As Integer = CInt(row("Cnt"))
            Dim pointIndex As Integer = ser.Points.AddXY(label, count)
            If label = "Male" Then
                ser.Points(pointIndex).Color = Color.FromArgb(0, 105, 62)
            ElseIf label = "Female" Then
                ser.Points(pointIndex).Color = Color.FromArgb(218, 185, 60)
            Else
                ser.Points(pointIndex).Color = Color.FromArgb(140, 150, 145)
            End If
        Next
        chartGender.Series.Add(ser)
        chartGender.Legends.Add("Legend")
        chartGender.Legends(0).Docking = Docking.Bottom
    End Sub

    Private Sub BuildProvinceChart()
        PrepareChart(chartProvince, "Citizens by province")
        Dim dt As DataTable = CitizenStore.GroupCount("Province")

        Dim ser As New Series("Provinces")
        ser.ChartType = SeriesChartType.Column
        ser.IsValueShownAsLabel = True
        ser.Color = Color.FromArgb(0, 120, 70)
        For Each row As DataRow In dt.Rows
            ser.Points.AddXY(CStr(row("LabelName")), CInt(row("Cnt")))
        Next
        chartProvince.Series.Add(ser)

        With chartProvince.ChartAreas(0)
            .AxisX.LabelStyle.Angle = -35
            .AxisX.Interval = 1
            .AxisX.MajorGrid.Enabled = False
            .AxisY.MajorGrid.LineColor = Color.FromArgb(220, 230, 223)
            .BackColor = Color.White
        End With
        chartProvince.ChartAreas(0).AxisX.Title = "Province"
        chartProvince.ChartAreas(0).AxisY.Title = "Citizens"
    End Sub

    Private Sub FillCities()
        lvCities.BeginUpdate()
        lvCities.Items.Clear()
        Dim dt As DataTable = CitizenStore.GroupCount("City")
        Dim shown As Integer = 0
        For Each row As DataRow In dt.Rows
            If shown >= CInt(numTop.Value) Then Exit For
            Dim item As New ListViewItem(CStr(row("LabelName")))
            item.SubItems.Add(CInt(row("Cnt")).ToString())
            lvCities.Items.Add(item)
            shown += 1
        Next
        lvCities.EndUpdate()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshData()
    End Sub

    Private Sub numTop_ValueChanged(sender As Object, e As EventArgs) Handles numTop.ValueChanged
        FillCities()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        dlgCsv.FileName = "nadra_citizens_" & Format(Now, "yyyyMMdd_HHmm") & ".csv"
        If dlgCsv.ShowDialog(Me) <> DialogResult.OK Then Return

        Try
            Dim sb As New StringBuilder()
            sb.AppendLine("Cnic,Name,FatherName,Gender,DateOfBirth,BloodGroup,MaritalStatus,Religion,Nationality," &
                          "Education,Occupation,AreaType,PresentAddress,PermanentAddress,City,Province,Mobile," &
                          "Phone,Email,OfficeName,IssueDate,ExpiryDate,IsVerified,Documents,Notes,CreatedOn")

            For Each c As Citizen In CitizenStore.Search("")
                sb.AppendLine(Join({CsvField(c.Cnic), CsvField(c.Name), CsvField(c.FatherName),
                                    CsvField(c.Gender), CsvField(c.DateOfBirth.ToString("yyyy-MM-dd")),
                                    CsvField(c.BloodGroup), CsvField(c.MaritalStatus), CsvField(c.Religion),
                                    CsvField(c.Nationality), CsvField(c.Education), CsvField(c.Occupation),
                                    CsvField(c.AreaType), CsvField(c.PresentAddress), CsvField(c.PermanentAddress),
                                    CsvField(c.City), CsvField(c.Province), CsvField(c.Mobile), CsvField(c.Phone),
                                    CsvField(c.Email), CsvField(c.OfficeName),
                                    CsvField(c.IssueDate.ToString("yyyy-MM-dd")),
                                    CsvField(c.ExpiryDate.ToString("yyyy-MM-dd")),
                                    CsvField(If(c.IsVerified, "Yes", "No")), CsvField(c.Documents),
                                    CsvField(c.Notes), CsvField(c.CreatedOn.ToString("yyyy-MM-dd HH:mm"))}, ","))
            Next

            File.WriteAllText(dlgCsv.FileName, sb.ToString(), Encoding.UTF8)
            Db.LogActivity(Session.Current.Username, "EXPORT", "Citizens register exported to " & dlgCsv.FileName)
            MessageBox.Show(Me, "Export completed:" & vbCrLf & dlgCsv.FileName,
                            "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(Me, "Export failed: " & ex.Message, "Export",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function CsvField(value As String) As String
        If value Is Nothing Then Return """"""
        Return """" & value.Replace("""", """""") & """"
    End Function

End Class
