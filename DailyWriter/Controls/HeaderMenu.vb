Public Class HeaderMenu
    Private Sub HeaderMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not My.Settings.Username = "" Then
            lblWelcome.Text = "Welcome back " & My.Settings.Username
        Else
            lblWelcome.Text = ""
        End If
    End Sub

    Private Sub lblLogout_Click(sender As Object, e As EventArgs) Handles lblLogout.Click
        My.Settings.Username = ""
        My.Settings.Save()
        Application.Restart()
    End Sub

    Private Sub lblHome_MouseEnter(sender As Object, e As EventArgs) Handles lblHome.MouseEnter
        lblHome.BackColor = Color.FromArgb(168, 82, 141)
    End Sub

    Private Sub lblHome_MouseLeave(sender As Object, e As EventArgs) Handles lblHome.MouseLeave
        lblHome.BackColor = Color.FromArgb(147, 65, 120)
    End Sub

    Private Sub lblLogout_MouseEnter(sender As Object, e As EventArgs) Handles lblLogout.MouseEnter
        lblLogout.BackColor = Color.FromArgb(168, 82, 141)
    End Sub

    Private Sub lblLogout_MouseLeave(sender As Object, e As EventArgs) Handles lblLogout.MouseLeave
        lblLogout.BackColor = Color.FromArgb(147, 65, 120)
    End Sub

    Private Sub lblManage_MouseEnter(sender As Object, e As EventArgs) Handles lblManage.MouseEnter
        lblManage.BackColor = Color.FromArgb(168, 82, 141)
    End Sub

    Private Sub lblManage_MouseLeave(sender As Object, e As EventArgs) Handles lblManage.MouseLeave
        lblManage.BackColor = Color.FromArgb(147, 65, 120)
    End Sub

    Private Sub lblNewEntry_MouseEnter(sender As Object, e As EventArgs) Handles lblNewEntry.MouseEnter
        lblNewEntry.BackColor = Color.FromArgb(168, 82, 141)
    End Sub

    Private Sub lblNewEntry_MouseLeave(sender As Object, e As EventArgs) Handles lblNewEntry.MouseLeave
        lblNewEntry.BackColor = Color.FromArgb(147, 65, 120)
    End Sub

    Private Sub lblNewJournal_MouseEnter(sender As Object, e As EventArgs) Handles lblNewJournal.MouseEnter
        lblNewJournal.BackColor = Color.FromArgb(168, 82, 141)
    End Sub

    Private Sub lblNewJournal_MouseLeave(sender As Object, e As EventArgs) Handles lblNewJournal.MouseLeave
        lblNewJournal.BackColor = Color.FromArgb(147, 65, 120)
    End Sub

    Private Sub lblSearch_MouseEnter(sender As Object, e As EventArgs) Handles lblSearch.MouseEnter
        lblSearch.BackColor = Color.FromArgb(168, 82, 141)
    End Sub

    Private Sub lblSearch_MouseLeave(sender As Object, e As EventArgs) Handles lblSearch.MouseLeave
        lblSearch.BackColor = Color.FromArgb(147, 65, 120)
    End Sub

    Private Sub lblSettings_MouseEnter(sender As Object, e As EventArgs) Handles lblSettings.MouseEnter
        lblSettings.BackColor = Color.FromArgb(168, 82, 141)
    End Sub

    Private Sub lblSettings_MouseLeave(sender As Object, e As EventArgs) Handles lblSettings.MouseLeave
        lblSettings.BackColor = Color.FromArgb(147, 65, 120)
    End Sub

    Private Sub lblNewJournal_Click(sender As Object, e As EventArgs) Handles lblNewJournal.Click
        Overlay.Show()
        NewJournal.Show()
    End Sub

    Private Sub lblNewEntry_Click(sender As Object, e As EventArgs) Handles lblNewEntry.Click
        Dashboard.SplitContainer1.Panel1Collapsed = True
        Dashboard.SplitContainer1.Panel2Collapsed = False
    End Sub
End Class
