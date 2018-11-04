Module Journals
    Public db As New FunctionsDataContext

    Public Function DisplayJournals()
        Dim journals As New JournalList
        For Each journal In db.dw_journals
            If journal.Username = My.Settings.Username And journal.IsPassword = True Then
                journals.picLock.Visible = True
                journals.photoCover.ImageLocation = journal.JournalCover
                journals.lblJournal.Text = journal.JournalTitle
                Dashboard.FlowLayoutPanel1.Controls.Add(journals)
            Else
                journals.picLock.Visible = False
                journals.photoCover.ImageLocation = journal.JournalCover
                journals.lblJournal.Text = journal.JournalTitle
                Dashboard.FlowLayoutPanel1.Controls.Add(journals)
            End If
        Next
        Return 0
    End Function
End Module
