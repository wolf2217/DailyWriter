Imports System.Runtime.InteropServices
Public Class NewJournal
    Private db As New FunctionsDataContext
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

#Region "drag form"
    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    <DllImportAttribute("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr,
      ByVal Msg As Integer, ByVal wParam As Integer,
      ByVal lParam As Integer) As Integer
    End Function

    <DllImportAttribute("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function
#End Region

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Close()
    End Sub

    Private Sub btnPassword_Click(sender As Object, e As EventArgs) Handles btnPassword.Click
        If txtPassword.Visible = False Then
            txtPassword.Visible = True
            btnPassword.Text = "Click to remove password"
        Else
            txtPassword.Text = ""
            txtPassword.Visible = False
            btnPassword.Text = "Click to password protect this"
        End If
    End Sub

    Private Sub NewJournal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Overlay.Close()
    End Sub

    Private Sub txtPhotoUpload_Click(sender As Object, e As EventArgs) Handles txtPhotoUpload.Click
        Dim ofd As New OpenFileDialog
        ofd.ShowDialog()
        txtPhotoUpload.Text = ofd.FileName
        photoCover.ImageLocation = ofd.FileName
        'Width = 750
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not txtPassword.Text = "" Then
            Dim createJournalWithPass = New dw_journal With {
                .Created = Date.Today.ToLongDateString(),
                .IsPassword = True,
                .JournalCover = txtPhotoUpload.Text,
                .JournalDescription = txtDesc.Text,
                .JournalTitle = txtTitle.Text,
                .Password = txtPassword.Text,
                .Username = My.Settings.Username
            }
            db.dw_journals.InsertOnSubmit(createJournalWithPass)
            Try
                db.SubmitChanges()
                MsgBox("Journal created successfully and the password is " & txtPassword.Text, MsgBoxStyle.Information)
                Dashboard.Dw_journalTableAdapter.Fill(Dashboard.JournalDataSet.dw_journal)
                DisplayJournals()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Dim createJournalWithoutPass = New dw_journal With {
                .Created = Date.Today.ToLongDateString(),
                .IsPassword = False,
                .JournalCover = txtPhotoUpload.Text,
                .JournalDescription = txtDesc.Text,
                .JournalTitle = txtTitle.Text,
                .Password = vbNull,
                .Username = My.Settings.Username
            }
            db.dw_journals.InsertOnSubmit(createJournalWithoutPass)
            Try
                db.SubmitChanges()
                'MsgBox("Journal was created and is NOT password protected", MsgBoxStyle.Information)
                Dashboard.Dw_journalTableAdapter.Fill(Dashboard.JournalDataSet.dw_journal)
                DisplayJournals()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub NewJournal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPhotoUpload.Text = photoCover.ImageLocation
    End Sub
End Class
