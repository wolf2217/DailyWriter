Public Class JournalList
    Private Sub photoCover_Click(sender As Object, e As EventArgs) Handles photoCover.Click

        'If picLock.Visible = True Then
        '    If InputBox("Enter your journal password", "Password Protected") = My.Settings.Username Then
        '        Notify.Show()
        '        Notify.lblMessage.Text = "Access Granted"
        '    Else
        '        Notify.Show()
        '        Notify.lblMessage.Text = "Access has been denied"
        '    End If
        'Else
        'End If
        Dashboard.SplitContainer1.Panel1Collapsed = True
        Dashboard.SplitContainer1.Panel2Collapsed = False
        Dashboard.lblJournal.Text = lblJournal.Text
        Dashboard.txtEntryTitle.Focus()
    End Sub
End Class
