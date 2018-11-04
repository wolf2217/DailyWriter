<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.lblClose = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.passLogin = New System.Windows.Forms.TextBox()
        Me.userLogin = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.confirmReg = New System.Windows.Forms.TextBox()
        Me.passReg = New System.Windows.Forms.TextBox()
        Me.userReg = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Container1 = New DailyWriter.Container()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Container2 = New DailyWriter.Container()
        Me.Container3 = New DailyWriter.Container()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblClose
        '
        Me.lblClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClose.AutoSize = True
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.lblClose.Location = New System.Drawing.Point(703, 0)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(21, 22)
        Me.lblClose.TabIndex = 1
        Me.lblClose.Text = "X"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(245, 169)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 28)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'passLogin
        '
        Me.passLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.passLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.passLogin.Location = New System.Drawing.Point(111, 130)
        Me.passLogin.Name = "passLogin"
        Me.passLogin.Size = New System.Drawing.Size(210, 25)
        Me.passLogin.TabIndex = 3
        Me.passLogin.Text = "admin123"
        Me.passLogin.UseSystemPasswordChar = True
        '
        'userLogin
        '
        Me.userLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.userLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.userLogin.Location = New System.Drawing.Point(111, 90)
        Me.userLogin.Name = "userLogin"
        Me.userLogin.Size = New System.Drawing.Size(210, 25)
        Me.userLogin.TabIndex = 2
        Me.userLogin.Text = "Networking26"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(39, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(36, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(610, 199)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 28)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Register"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'confirmReg
        '
        Me.confirmReg.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.confirmReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.confirmReg.Location = New System.Drawing.Point(475, 165)
        Me.confirmReg.Name = "confirmReg"
        Me.confirmReg.Size = New System.Drawing.Size(210, 25)
        Me.confirmReg.TabIndex = 6
        '
        'passReg
        '
        Me.passReg.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.passReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.passReg.Location = New System.Drawing.Point(475, 126)
        Me.passReg.Name = "passReg"
        Me.passReg.Size = New System.Drawing.Size(210, 25)
        Me.passReg.TabIndex = 5
        Me.passReg.UseSystemPasswordChar = True
        '
        'userReg
        '
        Me.userReg.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.userReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.userReg.Location = New System.Drawing.Point(475, 90)
        Me.userReg.Name = "userReg"
        Me.userReg.Size = New System.Drawing.Size(210, 25)
        Me.userReg.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(403, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 18)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Re-Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(400, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(400, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Username"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("KG HAPPY Solid", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Orchid
        Me.Label7.Location = New System.Drawing.Point(391, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(283, 26)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Sign up to create your own"
        '
        'Container1
        '
        Me.Container1.BackColor = System.Drawing.Color.White
        Me.Container1.BorderBottomColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Container1.BorderBottomSize = 1
        Me.Container1.BorderLeftColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Container1.BorderLeftSize = 1
        Me.Container1.BorderRightColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Container1.BorderRightSize = 1
        Me.Container1.BorderTopColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Container1.BorderTopSize = 1
        Me.Container1.Location = New System.Drawing.Point(12, 26)
        Me.Container1.Name = "Container1"
        Me.Container1.Size = New System.Drawing.Size(347, 210)
        Me.Container1.TabIndex = 9
        Me.Container1.Title = "Member Login"
        Me.Container1.TitleBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Container1.TitleColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(131, Byte), Integer))
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("KG HAPPY Solid", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Orchid
        Me.Label6.Location = New System.Drawing.Point(45, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(273, 26)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Log In to your daily writer"
        '
        'Container2
        '
        Me.Container2.BackColor = System.Drawing.Color.White
        Me.Container2.BorderBottomColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Container2.BorderBottomSize = 1
        Me.Container2.BorderLeftColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Container2.BorderLeftSize = 1
        Me.Container2.BorderRightColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Container2.BorderRightSize = 1
        Me.Container2.BorderTopColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Container2.BorderTopSize = 1
        Me.Container2.Location = New System.Drawing.Point(365, 26)
        Me.Container2.Name = "Container2"
        Me.Container2.Size = New System.Drawing.Size(347, 210)
        Me.Container2.TabIndex = 11
        Me.Container2.Title = "Member Register"
        Me.Container2.TitleBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Container2.TitleColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(131, Byte), Integer))
        '
        'Container3
        '
        Me.Container3.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Container3.BorderBottomColor = System.Drawing.Color.White
        Me.Container3.BorderBottomSize = 1
        Me.Container3.BorderLeftColor = System.Drawing.Color.White
        Me.Container3.BorderLeftSize = 1
        Me.Container3.BorderRightColor = System.Drawing.Color.White
        Me.Container3.BorderRightSize = 1
        Me.Container3.BorderTopColor = System.Drawing.Color.Transparent
        Me.Container3.BorderTopSize = 1
        Me.Container3.ForeColor = System.Drawing.Color.White
        Me.Container3.Location = New System.Drawing.Point(-1, 248)
        Me.Container3.Name = "Container3"
        Me.Container3.Size = New System.Drawing.Size(738, 270)
        Me.Container3.TabIndex = 12
        Me.Container3.Title = "  Welcome to Daily Writer"
        Me.Container3.TitleBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Container3.TitleColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(107, 285)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(509, 69)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = resources.GetString("Label8.Text")
        '
        'Home
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(726, 516)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.confirmReg)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.passReg)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.passLogin)
        Me.Controls.Add(Me.userLogin)
        Me.Controls.Add(Me.userReg)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Container1)
        Me.Controls.Add(Me.Container2)
        Me.Controls.Add(Me.Container3)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Home"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblClose As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents passLogin As TextBox
    Friend WithEvents userLogin As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents confirmReg As TextBox
    Friend WithEvents passReg As TextBox
    Friend WithEvents userReg As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Container1 As Container
    Friend WithEvents Label6 As Label
    Friend WithEvents Container2 As Container
    Friend WithEvents Container3 As Container
    Friend WithEvents Label8 As Label
End Class
