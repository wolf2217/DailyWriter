<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class JournalList
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblJournal = New System.Windows.Forms.Label()
        Me.picLock = New System.Windows.Forms.PictureBox()
        Me.photoCover = New System.Windows.Forms.PictureBox()
        CType(Me.picLock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.photoCover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblJournal
        '
        Me.lblJournal.AutoEllipsis = True
        Me.lblJournal.AutoSize = True
        Me.lblJournal.BackColor = System.Drawing.Color.Transparent
        Me.lblJournal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.lblJournal.Location = New System.Drawing.Point(34, 0)
        Me.lblJournal.Name = "lblJournal"
        Me.lblJournal.Size = New System.Drawing.Size(33, 13)
        Me.lblJournal.TabIndex = 1
        Me.lblJournal.Text = "Label"
        '
        'picLock
        '
        Me.picLock.BackColor = System.Drawing.Color.White
        Me.picLock.Image = Global.DailyWriter.My.Resources.Resources.Lock_16x
        Me.picLock.Location = New System.Drawing.Point(0, 0)
        Me.picLock.Name = "picLock"
        Me.picLock.Size = New System.Drawing.Size(16, 16)
        Me.picLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picLock.TabIndex = 2
        Me.picLock.TabStop = False
        Me.picLock.Visible = False
        '
        'photoCover
        '
        Me.photoCover.BackColor = System.Drawing.Color.White
        Me.photoCover.Cursor = System.Windows.Forms.Cursors.Hand
        Me.photoCover.Location = New System.Drawing.Point(0, 0)
        Me.photoCover.Name = "photoCover"
        Me.photoCover.Size = New System.Drawing.Size(32, 28)
        Me.photoCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.photoCover.TabIndex = 0
        Me.photoCover.TabStop = False
        '
        'JournalList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.Controls.Add(Me.picLock)
        Me.Controls.Add(Me.lblJournal)
        Me.Controls.Add(Me.photoCover)
        Me.Name = "JournalList"
        Me.Size = New System.Drawing.Size(206, 31)
        CType(Me.picLock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.photoCover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents photoCover As PictureBox
    Friend WithEvents lblJournal As Label
    Friend WithEvents picLock As PictureBox
End Class
