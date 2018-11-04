<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Me.components = New System.ComponentModel.Container()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.JournalDataSet = New DailyWriter.JournalDataSet()
        Me.DwjournalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dw_journalTableAdapter = New DailyWriter.JournalDataSetTableAdapters.dw_journalTableAdapter()
        Me.TableAdapterManager = New DailyWriter.JournalDataSetTableAdapters.TableAdapterManager()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblJournal = New System.Windows.Forms.Label()
        Me.txtEntry = New System.Windows.Forms.RichTextBox()
        Me.txtEntryTitle = New System.Windows.Forms.TextBox()
        Me.Container3 = New DailyWriter.Container()
        Me.Container2 = New DailyWriter.Container()
        Me.Container1 = New DailyWriter.Container()
        Me.HeaderMenu1 = New DailyWriter.HeaderMenu()
        CType(Me.JournalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DwjournalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 89)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(224, 444)
        Me.FlowLayoutPanel1.TabIndex = 3
        '
        'JournalDataSet
        '
        Me.JournalDataSet.DataSetName = "JournalDataSet"
        Me.JournalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DwjournalBindingSource
        '
        Me.DwjournalBindingSource.DataMember = "dw_journal"
        Me.DwjournalBindingSource.DataSource = Me.JournalDataSet
        '
        'Dw_journalTableAdapter
        '
        Me.Dw_journalTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.dw_journalTableAdapter = Me.Dw_journalTableAdapter
        Me.TableAdapterManager.dw_usersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DailyWriter.JournalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(236, 71)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.LinkLabel2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LinkLabel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblJournal)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtEntry)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Container3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtEntryTitle)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Container2)
        Me.SplitContainer1.Size = New System.Drawing.Size(540, 453)
        Me.SplitContainer1.SplitterDistance = 114
        Me.SplitContainer1.TabIndex = 5
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(90, 56)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(15, 18)
        Me.LinkLabel2.TabIndex = 3
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Entries"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(90, 31)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(15, 18)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Journals"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(220, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 28)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "In"
        '
        'lblJournal
        '
        Me.lblJournal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblJournal.AutoEllipsis = True
        Me.lblJournal.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblJournal.ForeColor = System.Drawing.Color.DimGray
        Me.lblJournal.Location = New System.Drawing.Point(244, 31)
        Me.lblJournal.Name = "lblJournal"
        Me.lblJournal.Size = New System.Drawing.Size(169, 28)
        Me.lblJournal.TabIndex = 7
        Me.lblJournal.Text = "Journal Name"
        '
        'txtEntry
        '
        Me.txtEntry.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEntry.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEntry.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntry.Location = New System.Drawing.Point(9, 92)
        Me.txtEntry.Name = "txtEntry"
        Me.txtEntry.Size = New System.Drawing.Size(404, 326)
        Me.txtEntry.TabIndex = 3
        Me.txtEntry.Text = ""
        '
        'txtEntryTitle
        '
        Me.txtEntryTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEntryTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEntryTitle.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntryTitle.Location = New System.Drawing.Point(9, 29)
        Me.txtEntryTitle.Name = "txtEntryTitle"
        Me.txtEntryTitle.Size = New System.Drawing.Size(205, 29)
        Me.txtEntryTitle.TabIndex = 1
        '
        'Container3
        '
        Me.Container3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Container3.BorderBottomColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Container3.BorderBottomSize = 1
        Me.Container3.BorderLeftColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Container3.BorderLeftSize = 1
        Me.Container3.BorderRightColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Container3.BorderRightSize = 1
        Me.Container3.BorderTopColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Container3.BorderTopSize = 1
        Me.Container3.Location = New System.Drawing.Point(6, 68)
        Me.Container3.Name = "Container3"
        Me.Container3.Size = New System.Drawing.Size(412, 355)
        Me.Container3.TabIndex = 5
        Me.Container3.Title = "Write what is on your mind"
        Me.Container3.TitleBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Container3.TitleColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(131, Byte), Integer))
        '
        'Container2
        '
        Me.Container2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Container2.BorderBottomColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Container2.BorderBottomSize = 1
        Me.Container2.BorderLeftColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Container2.BorderLeftSize = 1
        Me.Container2.BorderRightColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Container2.BorderRightSize = 1
        Me.Container2.BorderTopColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Container2.BorderTopSize = 1
        Me.Container2.Location = New System.Drawing.Point(6, 5)
        Me.Container2.Name = "Container2"
        Me.Container2.Size = New System.Drawing.Size(412, 58)
        Me.Container2.TabIndex = 4
        Me.Container2.Title = "Title this journal entry"
        Me.Container2.TitleBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Container2.TitleColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(131, Byte), Integer))
        '
        'Container1
        '
        Me.Container1.BorderBottomColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Container1.BorderBottomSize = 1
        Me.Container1.BorderLeftColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Container1.BorderLeftSize = 1
        Me.Container1.BorderRightColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Container1.BorderRightSize = 1
        Me.Container1.BorderTopColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Container1.BorderTopSize = 1
        Me.Container1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Container1.Location = New System.Drawing.Point(0, 65)
        Me.Container1.Name = "Container1"
        Me.Container1.Size = New System.Drawing.Size(230, 471)
        Me.Container1.TabIndex = 4
        Me.Container1.Title = "My Journals"
        Me.Container1.TitleBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Container1.TitleColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(131, Byte), Integer))
        '
        'HeaderMenu1
        '
        Me.HeaderMenu1.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.HeaderMenu1.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderMenu1.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeaderMenu1.ForeColor = System.Drawing.Color.White
        Me.HeaderMenu1.Location = New System.Drawing.Point(0, 0)
        Me.HeaderMenu1.Name = "HeaderMenu1"
        Me.HeaderMenu1.Size = New System.Drawing.Size(788, 65)
        Me.HeaderMenu1.TabIndex = 2
        '
        'Dashboard
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(788, 536)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Container1)
        Me.Controls.Add(Me.HeaderMenu1)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Dashboard"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.JournalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DwjournalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HeaderMenu1 As HeaderMenu
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents JournalDataSet As JournalDataSet
    Friend WithEvents DwjournalBindingSource As BindingSource
    Friend WithEvents Dw_journalTableAdapter As JournalDataSetTableAdapters.dw_journalTableAdapter
    Friend WithEvents TableAdapterManager As JournalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Container1 As Container
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents txtEntry As RichTextBox
    Friend WithEvents txtEntryTitle As TextBox
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents Container3 As Container
    Friend WithEvents Container2 As Container
    Friend WithEvents lblJournal As Label
    Friend WithEvents Label1 As Label
End Class
