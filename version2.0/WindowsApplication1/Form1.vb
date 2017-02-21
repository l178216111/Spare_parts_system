
Public Class Form1
    Dim UserData As UserPermission
    Public rht As String
    Public cm, m As String
    Public log As Boolean
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO:  这行代码将数据加载到表“Database2DataSet.Table1”中。您可以根据需要移动或删除它。
        Me.Table1TableAdapter.Fill(Me.Database2DataSet.Table1)
        log = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        UserData = New UserPermission()
        DataGridView1.DataSource = UserData.GetAll()
        TextBox3.Text = DataGridView1.RowCount '显示查询数目
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click '退出
        Me.Close()
    End Sub
    Public Sub logon()  '登陆
        If log = False Then
            Form3.ShowDialog()
        End If
    End Sub
    Private Sub LogOnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOnToolStripMenuItem.Click
        Call logon()
    End Sub
    Private Sub LogOffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOffToolStripMenuItem.Click
        MsgBox(Form3.TextBox1.Text & " log out")
        Form3.TextBox1.Text = ""
        Form3.TextBox2.Text = ""
        log = False
    End Sub
    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        form4.showdialog()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Form6.ComboBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        Form6.TextBox8.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        Form6.ComboBox2.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        Form6.TextBox2.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        TextBox2.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged '实时查询
        UserData.sinput = "status in ('Pass','Fail','Using','Repair')"
        UserData.tinput = vbNullString
        UserData.ninput = " and SN like'%" & UCase(TextBox1.Text.Trim) & "%'"
        UserData.cinput = vbNullString
        Me.DataGridView1.DataSource = UserData.search()
        Me.TextBox3.Text = Me.DataGridView1.RowCount
    End Sub
    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        Form2.Show()
    End Sub
    Sub list() 'dataview 赋值
        UserData.Type = DataGridView1.CurrentRow.Cells(0).Value.ToString 'type
        UserData.SN = DataGridView1.CurrentRow.Cells(1).Value.ToString 'SN
        UserData.status = DataGridView1.CurrentRow.Cells(2).Value.ToString '状态
        UserData.comment = DataGridView1.CurrentRow.Cells(4).Value.ToString 'comment
        UserData.data = Format(Now, "yyyy/MM/dd") 'date
    End Sub
    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Call logon()
        If log = True Then
            Form5.ShowDialog()
        End If
    End Sub

    'Private Sub DataGridView1_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDown
    '    If (e.Button = Windows.Forms.MouseButtons.Right And e.RowIndex > -1 And e.ColumnIndex > -1) The
    '        ContextMenuStrip1.Show(MousePosition.X, MousePosition.Y

    '    End If
    'End Sub

    Private Sub DataGridView1_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDown '右击菜单
        If e.Button = Windows.Forms.MouseButtons.Right Then

            If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then    '选中行头或列头均不触发

                'MsgBox(e.RowIndex & " : " & e.ColumnIndex)

                '若行已是选中状态就不再进行设置

                If (DataGridView1.Rows(e.RowIndex).Selected = False) Then

                    DataGridView1.ClearSelection()

                    DataGridView1.Rows(e.RowIndex).Selected = True

                End If

                '只选中一行时设置活动单元格

                If (DataGridView1.SelectedRows.Count = 1) Then

                    DataGridView1.CurrentCell = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex)

                End If
                Call logon()
                If log = True Then
                    Me.ContextMenuStrip1.Show(MousePosition.X, MousePosition.Y)
                End If
            End If
        End If
    End Sub

    Private Sub EnableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnableToolStripMenuItem.Click 'loop pass
        If log = True Then
            If Not rht = 3 Then
                If MsgBox("Ready This Board ? " & vbNewLine, vbExclamation + vbYesNo, "Ready") = vbYes Then
                    If DataGridView1.CurrentRow.Cells(2).Value.ToString = "Fail" Then
                        Call list()
                        UserData.cinput = DataGridView1.CurrentRow.Cells(4).Value.ToString & vbCrLf & "Loop pass " & "Comment:" & TextBox2.Text & ". " & Format(Now, "yyyy/MM/dd")
                        UserData.user = UCase(Form3.TextBox1.Text)
                        UserData.looppass()
                        DataGridView1.DataSource = UserData.diaplay()
                    Else
                        MsgBox("This Board Needn't To Repair", MsgBoxStyle.Exclamation)
                    End If
                    TextBox2.Text = ""
                    TextBox3.Text = DataGridView1.RowCount
                End If
            Else
                MsgBox("No Permission ", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub SendRepairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SendRepairToolStripMenuItem.Click 'repair
        If log = True Then
            If Not rht = 3 Then
                If MsgBox("Send This Board to repair" & vbNewLine, vbExclamation + vbYesNo, "Send") = vbYes Then
                    If DataGridView1.CurrentRow.Cells(4).Value.ToString = "Fail" Then
                        Call list()
                        UserData.cinput = DataGridView1.CurrentRow.Cells(4).Value.ToString & vbCrLf & "Send to repair  . " & Format(Now, "yyyy/MM/dd") & vbCrLf & "Repair Comment: " & TextBox2.Text
                        UserData.user = UCase(Form3.TextBox1.Text)
                        UserData.sendrepair()
                        DataGridView1.DataSource = UserData.diaplay()
                        TextBox2.Text = ""
                    Else
                        MsgBox("This Board Needn't To Repair", MsgBoxStyle.Exclamation)
                    End If
                    TextBox2.Text = ""
                    TextBox3.Text = DataGridView1.RowCount
                End If
            Else
                MsgBox("No Permission ", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click '删除
        If log = True Then
            If rht = 1 Then
                If MsgBox("Delect This Record? " & vbNewLine, vbExclamation + vbYesNo, "Delect") = vbYes Then
                    Call list()
                    UserData.delete()
                    DataGridView1.DataSource = UserData.diaplay()
                End If
                TextBox3.Text = DataGridView1.RowCount
            Else
                MsgBox("No Permission ", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub
    Private Sub SubmitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubmitToolStripMenuItem.Click
        Form5.ShowDialog()
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        DataGridView1.DataSource = UserData.GetAll()
        TextBox3.Text = DataGridView1.RowCount
    End Sub

    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        Call logon()
        If log = True Then
            If Not rht = 3 Then
                Form6.Show()
            Else
                MsgBox("No Permission ", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub
End Class
