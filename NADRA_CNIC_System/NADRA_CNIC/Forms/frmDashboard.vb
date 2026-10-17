Imports System.Windows.Forms

''' <summary>
''' Dashboard child window: four KPI cards, verification progress bar,
''' month calendar, quick action links and the recent registrations list.
''' </summary>
Public Class frmDashboard

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiTheme.StyleGroup(grpTotal)
        UiTheme.StyleGroup(grpVerified)
        UiTheme.StyleGroup(grpPending)
        UiTheme.StyleGroup(grpToday)
        UiTheme.StyleGroup(grpRecent)
        UiTheme.StyleGroup(grpSide)

        tipDash.SetToolTip(btnRefresh, "Reload all figures from the database (F5)")
        tipDash.SetToolTip(lvRecent, "Double click a record to open it in the registration window")

        RefreshData()
    End Sub

    Private Sub frmDashboard_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        RefreshData()
    End Sub

    ''' <summary>Reloads every figure and the recent registrations list.</summary>
    Public Sub RefreshData()
        Try
            Dim stats As CitizenStats = CitizenStore.GetStats()

            lblTotalVal.Text = stats.Total.ToString()
            lblTotalSub.Text = "Male: " & stats.Male.ToString() & "   Female: " & stats.Female.ToString() &
                               "   Other: " & stats.Other.ToString()
            lblVerifiedVal.Text = stats.Verified.ToString()
            lblVerifiedSub.Text = Math.Round(If(stats.Total = 0, 0, stats.Verified * 100.0 / stats.Total), 1).ToString() &
                                  "% of all records are biometrically verified"
            lblPendingVal.Text = stats.Pending.ToString()
            lblPendingSub.Text = "Records still awaiting officer verification"
            lblTodayVal.Text = stats.RegisteredToday.ToString()
            lblTodaySub.Text = "New citizens registered on " & Date.Today.ToString("dd MMM yyyy")

            Dim pct As Integer = CInt(Math.Round(If(stats.Total = 0, 0, stats.Verified * 100.0 / stats.Total)))
            pbTarget.Value = Math.Min(100, pct)
            lblTargetVal.Text = stats.Verified.ToString() & " of " & stats.Total.ToString() &
                                " records verified  (" & pct.ToString() & "%)"

            ' recent registrations
            lvRecent.BeginUpdate()
            lvRecent.Items.Clear()
            Dim recent As List(Of Citizen) = CitizenStore.Search("")
            recent.Sort(Function(a As Citizen, b As Citizen) b.CreatedOn.CompareTo(a.CreatedOn))
            For Each c As Citizen In recent.Take(12)
                Dim item As New ListViewItem(c.Cnic)
                item.SubItems.Add(c.Name)
                item.SubItems.Add(c.City)
                item.SubItems.Add(c.CreatedOn.ToString("dd-MMM-yyyy HH:mm"))
                item.SubItems.Add(If(c.IsVerified, "Verified", "Pending"))
                If Not c.IsVerified Then item.ForeColor = Color.FromArgb(160, 100, 0)
                item.Tag = c.Cnic
                lvRecent.Items.Add(item)
            Next
            lvRecent.EndUpdate()

            lblUpdated.Text = "Last updated: " & Now.ToString("HH:mm:ss")
        Catch ex As Exception
            lblUpdated.Text = "Refresh failed: " & ex.Message
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshData()
    End Sub

    Private Sub lvRecent_DoubleClick(sender As Object, e As EventArgs) Handles lvRecent.DoubleClick
        If lvRecent.SelectedItems.Count = 0 Then Return
        Dim cnic As String = CStr(lvRecent.SelectedItems(0).Tag)
        Dim main As frmMain = TryCast(MdiParent, frmMain)
        If main IsNot Nothing Then main.OpenCitizen(cnic)
    End Sub

    Private Sub lnkRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkRegister.LinkClicked
        Dim main As frmMain = TryCast(MdiParent, frmMain)
        If main IsNot Nothing Then main.OpenCitizen().StartNewRegistration()
    End Sub

    Private Sub lnkVisual_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkVisual.LinkClicked
        Dim main As frmMain = TryCast(MdiParent, frmMain)
        If main IsNot Nothing Then main.OpenVisualLab()
    End Sub

    Private Sub lnkStats_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkStats.LinkClicked
        Dim main As frmMain = TryCast(MdiParent, frmMain)
        If main IsNot Nothing Then main.OpenStats()
    End Sub

End Class
