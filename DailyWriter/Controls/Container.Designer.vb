<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Container
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
        Me.pnlContainer = New System.Windows.Forms.Panel()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlBorderRight = New System.Windows.Forms.Panel()
        Me.pnlBorderBottom = New System.Windows.Forms.Panel()
        Me.pnlBorderLeft = New System.Windows.Forms.Panel()
        Me.pnlBorderTop = New System.Windows.Forms.Panel()
        Me.pnlContainer.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContainer
        '
        Me.pnlContainer.Controls.Add(Me.pnlBorderTop)
        Me.pnlContainer.Controls.Add(Me.pnlHeader)
        Me.pnlContainer.Controls.Add(Me.pnlBorderRight)
        Me.pnlContainer.Controls.Add(Me.pnlBorderBottom)
        Me.pnlContainer.Controls.Add(Me.pnlBorderLeft)
        Me.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContainer.Location = New System.Drawing.Point(0, 0)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(410, 176)
        Me.pnlContainer.TabIndex = 0
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Font = New System.Drawing.Font("Liberation Mono", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.pnlHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.pnlHeader.Location = New System.Drawing.Point(1, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(408, 20)
        Me.pnlHeader.TabIndex = 3
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(3, 1)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(65, 15)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Panel Title"
        '
        'pnlBorderRight
        '
        Me.pnlBorderRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.pnlBorderRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlBorderRight.Location = New System.Drawing.Point(409, 0)
        Me.pnlBorderRight.Name = "pnlBorderRight"
        Me.pnlBorderRight.Size = New System.Drawing.Size(1, 175)
        Me.pnlBorderRight.TabIndex = 2
        '
        'pnlBorderBottom
        '
        Me.pnlBorderBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.pnlBorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBorderBottom.Location = New System.Drawing.Point(1, 175)
        Me.pnlBorderBottom.Name = "pnlBorderBottom"
        Me.pnlBorderBottom.Size = New System.Drawing.Size(409, 1)
        Me.pnlBorderBottom.TabIndex = 1
        '
        'pnlBorderLeft
        '
        Me.pnlBorderLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.pnlBorderLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlBorderLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlBorderLeft.Name = "pnlBorderLeft"
        Me.pnlBorderLeft.Size = New System.Drawing.Size(1, 176)
        Me.pnlBorderLeft.TabIndex = 0
        '
        'pnlBorderTop
        '
        Me.pnlBorderTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.pnlBorderTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBorderTop.Location = New System.Drawing.Point(1, 20)
        Me.pnlBorderTop.Name = "pnlBorderTop"
        Me.pnlBorderTop.Size = New System.Drawing.Size(408, 1)
        Me.pnlBorderTop.TabIndex = 4
        '
        'Container
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.pnlContainer)
        Me.Name = "Container"
        Me.Size = New System.Drawing.Size(410, 176)
        Me.pnlContainer.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlContainer As Panel
    Friend WithEvents pnlBorderLeft As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlBorderRight As Panel
    Friend WithEvents pnlBorderBottom As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlBorderTop As Panel
End Class
