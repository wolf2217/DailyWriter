<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Notify
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblClose
        '
        Me.lblClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(390, 100)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Padding = New System.Windows.Forms.Padding(3)
        Me.lblClose.Size = New System.Drawing.Size(56, 28)
        Me.lblClose.TabIndex = 1
        Me.lblClose.Text = "Okay"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.ForeColor = System.Drawing.Color.Gray
        Me.lblName.Location = New System.Drawing.Point(12, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(0, 18)
        Me.lblName.TabIndex = 2
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(15, 13)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(432, 77)
        Me.lblMessage.TabIndex = 3
        Me.lblMessage.Text = "Label1"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Notify
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(459, 137)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblClose)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.MaximumSize = New System.Drawing.Size(475, 153)
        Me.MinimumSize = New System.Drawing.Size(475, 153)
        Me.Name = "Notify"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblClose As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblMessage As Label
End Class
