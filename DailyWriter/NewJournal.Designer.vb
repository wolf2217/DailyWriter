<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewJournal
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.RichTextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnPassword = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtPhotoUpload = New System.Windows.Forms.TextBox()
        Me.photoCover = New System.Windows.Forms.PictureBox()
        Me.Container1 = New DailyWriter.Container()
        Me.Container2 = New DailyWriter.Container()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.photoCover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblClose
        '
        Me.lblClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClose.AutoSize = True
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.Gray
        Me.lblClose.Location = New System.Drawing.Point(570, 0)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(21, 22)
        Me.lblClose.TabIndex = 1
        Me.lblClose.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Give your journal a title"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(41, 180)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(507, 25)
        Me.txtTitle.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(246, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Write a short description of this journal"
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(44, 236)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(504, 96)
        Me.txtDesc.TabIndex = 5
        Me.txtDesc.Text = ""
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnPassword)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtPassword)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(44, 338)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(434, 35)
        Me.FlowLayoutPanel1.TabIndex = 7
        '
        'btnPassword
        '
        Me.btnPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPassword.ForeColor = System.Drawing.Color.White
        Me.btnPassword.Location = New System.Drawing.Point(3, 3)
        Me.btnPassword.Name = "btnPassword"
        Me.btnPassword.Size = New System.Drawing.Size(206, 28)
        Me.btnPassword.TabIndex = 6
        Me.btnPassword.Text = "Click to password protect this"
        Me.btnPassword.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(215, 3)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(210, 25)
        Me.txtPassword.TabIndex = 7
        Me.txtPassword.UseSystemPasswordChar = True
        Me.txtPassword.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(484, 338)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(64, 35)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtPhotoUpload
        '
        Me.txtPhotoUpload.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhotoUpload.ForeColor = System.Drawing.Color.Gray
        Me.txtPhotoUpload.Location = New System.Drawing.Point(21, 68)
        Me.txtPhotoUpload.Name = "txtPhotoUpload"
        Me.txtPhotoUpload.Size = New System.Drawing.Size(496, 25)
        Me.txtPhotoUpload.TabIndex = 9
        Me.txtPhotoUpload.Text = "Click to upload a photo as your journal cover"
        '
        'photoCover
        '
        Me.photoCover.Image = Global.DailyWriter.My.Resources.Resources.icons8_Globe_96px_1
        Me.photoCover.InitialImage = Global.DailyWriter.My.Resources.Resources.icons8_Globe_96px_1
        Me.photoCover.Location = New System.Drawing.Point(523, 59)
        Me.photoCover.Name = "photoCover"
        Me.photoCover.Size = New System.Drawing.Size(49, 43)
        Me.photoCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.photoCover.TabIndex = 10
        Me.photoCover.TabStop = False
        '
        'Container1
        '
        Me.Container1.BorderBottomColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Container1.BorderBottomSize = 1
        Me.Container1.BorderLeftColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Container1.BorderLeftSize = 1
        Me.Container1.BorderRightColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Container1.BorderRightSize = 1
        Me.Container1.Location = New System.Drawing.Point(12, 118)
        Me.Container1.Name = "Container1"
        Me.Container1.Size = New System.Drawing.Size(569, 276)
        Me.Container1.TabIndex = 11
        Me.Container1.Title = "New Journal"
        Me.Container1.TitleBackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Container1.TitleColor = System.Drawing.Color.White
        '
        'Container2
        '
        Me.Container2.BorderBottomColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Container2.BorderBottomSize = 1
        Me.Container2.BorderLeftColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Container2.BorderLeftSize = 1
        Me.Container2.BorderRightColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Container2.BorderRightSize = 1
        Me.Container2.Location = New System.Drawing.Point(12, 34)
        Me.Container2.Name = "Container2"
        Me.Container2.Size = New System.Drawing.Size(569, 78)
        Me.Container2.TabIndex = 12
        Me.Container2.Title = "Upload a photo cover for this journal"
        Me.Container2.TitleBackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Container2.TitleColor = System.Drawing.Color.White
        '
        'NewJournal
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(593, 406)
        Me.ControlBox = False
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPhotoUpload)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Container1)
        Me.Controls.Add(Me.photoCover)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.Container2)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "NewJournal"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.photoCover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblClose As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDesc As RichTextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnPassword As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents txtPhotoUpload As TextBox
    Friend WithEvents photoCover As PictureBox
    Friend WithEvents Container1 As Container
    Friend WithEvents Container2 As Container
End Class
