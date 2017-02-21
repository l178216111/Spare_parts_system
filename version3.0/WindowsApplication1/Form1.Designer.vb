<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database2DataSet = New WindowsApplication1.Database2DataSet()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SubmitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelayToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelayToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendRepairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Table1TableAdapter = New WindowsApplication1.Database2DataSetTableAdapters.Table1TableAdapter()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "S/N"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(82, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(90, 20)
        Me.TextBox1.TabIndex = 10
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(555, 55)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(120, 281)
        Me.TextBox2.TabIndex = 16
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.SearchToolStripMenuItem, Me.AdminToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(687, 24)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOnToolStripMenuItem, Me.LogOffToolStripMenuItem, Me.ChangePasswordToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'LogOnToolStripMenuItem
        '
        Me.LogOnToolStripMenuItem.Name = "LogOnToolStripMenuItem"
        Me.LogOnToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LogOnToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.LogOnToolStripMenuItem.Text = "Log on"
        '
        'LogOffToolStripMenuItem
        '
        Me.LogOffToolStripMenuItem.Name = "LogOffToolStripMenuItem"
        Me.LogOffToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.LogOffToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.LogOffToolStripMenuItem.Text = "Log off"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change password"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(165, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(650, 29)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(25, 20)
        Me.TextBox3.TabIndex = 47
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.comment, Me.DataGridViewTextBoxColumn17})
        Me.DataGridView1.DataSource = Me.Table1BindingSource
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(12, 55)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(659, 281)
        Me.DataGridView1.TabIndex = 55
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "type"
        Me.DataGridViewTextBoxColumn12.HeaderText = "type"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "SN"
        Me.DataGridViewTextBoxColumn13.HeaderText = "SN"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "status"
        Me.DataGridViewTextBoxColumn14.HeaderText = "status"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "data"
        Me.DataGridViewTextBoxColumn15.HeaderText = "data"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'comment
        '
        Me.comment.DataPropertyName = "comment"
        Me.comment.HeaderText = "comment"
        Me.comment.Name = "comment"
        Me.comment.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "userid"
        Me.DataGridViewTextBoxColumn17.HeaderText = "userid"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.Database2DataSet
        '
        'Database2DataSet
        '
        Me.Database2DataSet.DataSetName = "Database2DataSet"
        Me.Database2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubmitToolStripMenuItem, Me.RelayToolStripMenuItem, Me.EnableToolStripMenuItem, Me.SendRepairToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(147, 114)
        '
        'SubmitToolStripMenuItem
        '
        Me.SubmitToolStripMenuItem.Name = "SubmitToolStripMenuItem"
        Me.SubmitToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.SubmitToolStripMenuItem.Text = "Submit"
        '
        'RelayToolStripMenuItem
        '
        Me.RelayToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RelayToolStripMenuItem1, Me.RelayToolStripMenuItem2})
        Me.RelayToolStripMenuItem.Name = "RelayToolStripMenuItem"
        Me.RelayToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.RelayToolStripMenuItem.Text = "Change Relay"
        '
        'RelayToolStripMenuItem1
        '
        Me.RelayToolStripMenuItem1.Name = "RelayToolStripMenuItem1"
        Me.RelayToolStripMenuItem1.Size = New System.Drawing.Size(123, 22)
        Me.RelayToolStripMenuItem1.Text = "012 Relay"
        '
        'RelayToolStripMenuItem2
        '
        Me.RelayToolStripMenuItem2.Name = "RelayToolStripMenuItem2"
        Me.RelayToolStripMenuItem2.Size = New System.Drawing.Size(123, 22)
        Me.RelayToolStripMenuItem2.Text = "009 Relay"
        '
        'EnableToolStripMenuItem
        '
        Me.EnableToolStripMenuItem.Name = "EnableToolStripMenuItem"
        Me.EnableToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.EnableToolStripMenuItem.Text = "Enable"
        '
        'SendRepairToolStripMenuItem
        '
        Me.SendRepairToolStripMenuItem.Name = "SendRepairToolStripMenuItem"
        Me.SendRepairToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.SendRepairToolStripMenuItem.Text = "Send Repair"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(190, 19)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 70
        Me.Button9.Text = "Display"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 348)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "J750 Spare Parts System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SNDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents LogOnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UseridDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Database2DataSet As WindowsApplication1.Database2DataSet
    Friend WithEvents Table1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table1TableAdapter As WindowsApplication1.Database2DataSetTableAdapters.Table1TableAdapter
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents comment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SubmitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SendRepairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents AdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelayToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelayToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem

End Class
