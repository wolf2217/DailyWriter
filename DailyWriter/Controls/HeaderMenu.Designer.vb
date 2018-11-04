<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HeaderMenu
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblLogout = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblHome = New System.Windows.Forms.Label()
        Me.lblNewJournal = New System.Windows.Forms.Label()
        Me.lblNewEntry = New System.Windows.Forms.Label()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.lblManage = New System.Windows.Forms.Label()
        Me.lblSettings = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblLogout)
        Me.Panel1.Controls.Add(Me.lblWelcome)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(794, 32)
        Me.Panel1.TabIndex = 0
        '
        'lblLogout
        '
        Me.lblLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLogout.AutoSize = True
        Me.lblLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLogout.Font = New System.Drawing.Font("Liberation Mono", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogout.Location = New System.Drawing.Point(719, 7)
        Me.lblLogout.Name = "lblLogout"
        Me.lblLogout.Size = New System.Drawing.Size(68, 18)
        Me.lblLogout.TabIndex = 1
        Me.lblLogout.Text = "Logout"
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Liberation Mono", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(6, 7)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(68, 18)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Label1"
        '
        'lblHome
        '
        Me.lblHome.AutoSize = True
        Me.lblHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblHome.Location = New System.Drawing.Point(23, 39)
        Me.lblHome.Name = "lblHome"
        Me.lblHome.Size = New System.Drawing.Size(52, 19)
        Me.lblHome.TabIndex = 1
        Me.lblHome.Text = "Home"
        '
        'lblNewJournal
        '
        Me.lblNewJournal.AutoSize = True
        Me.lblNewJournal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblNewJournal.Location = New System.Drawing.Point(90, 39)
        Me.lblNewJournal.Name = "lblNewJournal"
        Me.lblNewJournal.Size = New System.Drawing.Size(100, 19)
        Me.lblNewJournal.TabIndex = 2
        Me.lblNewJournal.Text = "New Journal"
        '
        'lblNewEntry
        '
        Me.lblNewEntry.AutoSize = True
        Me.lblNewEntry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblNewEntry.Location = New System.Drawing.Point(207, 39)
        Me.lblNewEntry.Name = "lblNewEntry"
        Me.lblNewEntry.Size = New System.Drawing.Size(83, 19)
        Me.lblNewEntry.TabIndex = 3
        Me.lblNewEntry.Text = "New Entry"
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSearch.Location = New System.Drawing.Point(307, 39)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(116, 19)
        Me.lblSearch.TabIndex = 4
        Me.lblSearch.Text = "Search Entries"
        '
        'lblManage
        '
        Me.lblManage.AutoSize = True
        Me.lblManage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblManage.Location = New System.Drawing.Point(442, 39)
        Me.lblManage.Name = "lblManage"
        Me.lblManage.Size = New System.Drawing.Size(121, 19)
        Me.lblManage.TabIndex = 5
        Me.lblManage.Text = "Manage Entries"
        '
        'lblSettings
        '
        Me.lblSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSettings.AutoSize = True
        Me.lblSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblSettings.Location = New System.Drawing.Point(716, 39)
        Me.lblSettings.Name = "lblSettings"
        Me.lblSettings.Size = New System.Drawing.Size(68, 19)
        Me.lblSettings.TabIndex = 6
        Me.lblSettings.Text = "Settings"
        '
        'HeaderMenu
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Controls.Add(Me.lblSettings)
        Me.Controls.Add(Me.lblManage)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.lblNewEntry)
        Me.Controls.Add(Me.lblNewJournal)
        Me.Controls.Add(Me.lblHome)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "HeaderMenu"
        Me.Size = New System.Drawing.Size(794, 65)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblLogout As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblHome As Label
    Friend WithEvents lblNewJournal As Label
    Friend WithEvents lblNewEntry As Label
    Friend WithEvents lblSearch As Label
    Friend WithEvents lblManage As Label
    Friend WithEvents lblSettings As Label
End Class
