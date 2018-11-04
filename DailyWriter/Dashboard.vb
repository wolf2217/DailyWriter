Imports System.Runtime.InteropServices
Public Class Dashboard
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

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JournalDataSet.dw_journal' table. You can move, or remove it, as needed.
        Me.Dw_journalTableAdapter.Fill(Me.JournalDataSet.dw_journal)
        DisplayJournals()
        SplitContainer1.Panel2Collapsed = True
    End Sub

End Class
