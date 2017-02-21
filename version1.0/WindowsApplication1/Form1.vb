
Public Class Form1
    Dim UserData As UserPermission
    Public rht As String
    Public cm, m As String
    Public log As Boolean
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO:  这行代码将数据加载到表“Database2DataSet.Table1”中。您可以根据需要移动或删除它。
        Me.Table1TableAdapter.Fill(Me.Database2DataSet.Table1)
        Me.ComboBox1.SelectedIndex = 0
        Me.ComboBox2.SelectedIndex = 0
        Me.ComboBox3.SelectedIndex = 0
        log = False
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker3.Format = DateTimePickerFormat.Custom
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        UserData = New UserPermission()
        DataGridView1.DataSource = UserData.GetAll()
        TextBox3.Text = DataGridView1.RowCount '显示查询数目
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click '添加
        Call logon()
        If log = True Then
            If rht = 1 Then
                If TextBox1.Text = vbNullString Then
                    MsgBox("S/N is None", MsgBoxStyle.Exclamation, "Warning")
                ElseIf MsgBox("Add This Record? " & vbNewLine, vbExclamation + vbYesNo, "Add") = vbYes Then
                    UserData.Type = ComboBox1.Text.Trim
                    UserData.SN = UCase(TextBox1.Text.Trim)
                    UserData.status = ComboBox2.Text.Trim
                    UserData.data = Format(Now, "yyyy/MM/dd")
                    UserData.comment = TextBox2.Text.Trim
                    UserData.ninput = UCase(TextBox1.Text.Trim)
                    ' UserData.user = Form3.TextBox1.Text
                    Call UserData.check()
                    If UserData.sel = False Then '有重复SN
                        MsgBox("The repeat record", MsgBoxStyle.Exclamation)
                        DataGridView1.DataSource = UserData.diaplayy()
                    Else
                        UserData.Add()
                        DataGridView1.DataSource = UserData.diaplay()
                        TextBox1.Text = ""
                        TextBox2.Text = ""
                    End If
                    End If
                    TextBox3.Text = DataGridView1.RowCount
            Else
                MsgBox("No Permission ", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click '删除
        Call logon()
        If log = True Then
            If rht = 1 Then
                If MsgBox("Delect This Record? " & vbNewLine, vbExclamation + vbYesNo, "Delect") = vbYes Then
                    UserData.Type = DataGridView1.CurrentRow.Cells(0).Value.ToString
                    UserData.SN = DataGridView1.CurrentRow.Cells(1).Value.ToString
                    UserData.status = DataGridView1.CurrentRow.Cells(2).Value.ToString
                    UserData.comment = DataGridView1.CurrentRow.Cells(4).Value.ToString
                    UserData.delete()
                    DataGridView1.DataSource = UserData.diaplay()
                End If
                TextBox3.Text = DataGridView1.RowCount
            Else
                MsgBox("No Permission ", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click '退出
        Me.Close()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click '修改
        Call logon()
        If log = True Then
            If rht = 1 Then
                If MsgBox("Change This Record? " & vbNewLine, vbExclamation + vbYesNo, "Change") = vbYes Then
                    UserData.Type = DataGridView1.CurrentRow.Cells(0).Value.ToString
                    UserData.SN = DataGridView1.CurrentRow.Cells(1).Value.ToString
                    UserData.status = DataGridView1.CurrentRow.Cells(2).Value.ToString
                    UserData.comment = DataGridView1.CurrentRow.Cells(4).Value.ToString
                    UserData.data = Format(Now, "yyyy/MM/dd")
                    UserData.tinput = ComboBox1.Text
                    UserData.sinput = ComboBox2.Text
                    UserData.ninput = UCase(TextBox1.Text)
                    UserData.cinput = TextBox2.Text
                    UserData.updata()
                    DataGridView1.DataSource = UserData.diaplay()
                    TextBox3.Text = DataGridView1.RowCount
                End If
            Else
                MsgBox("No Permission ", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click '借出
        Call logon()
        If log = True Then
            If ComboBox1.Text = "012 Relay" Or ComboBox1.Text = "009 Relay" Then
                If MsgBox("Fail This Relay? " & vbNewLine, vbExclamation + vbYesNo, "Add") = vbYes Then
                    UserData.Type = ComboBox1.Text
                    UserData.user = UCase(Form3.TextBox1.Text)
                    UserData.data = Format(Now, "yyyy/MM/dd")
                    UserData.ninput = UCase(TextBox4.Text.Trim)
                    UserData.comment = "From T" & TextBox5.Text & "S750 Fail: " & TextBox6.Text & " date:" & Format(Now, "yyyy/MM/dd")
                    UserData.AddF()
                    DataGridView1.DataSource = UserData.diaplay()
                    TextBox4.Text = ""
                    TextBox5.Text = ""
                    TextBox6.Text = ""
                End If
            ElseIf TextBox1.Text = vbNullString Then
                MsgBox("Please First Select Board", MsgBoxStyle.Exclamation, "Warning")
            ElseIf TextBox4.Text = vbNullString Then
                MsgBox("Fail S/N is None", MsgBoxStyle.Exclamation, "Warning")
            ElseIf TextBox5.Text = vbNullString Then
                MsgBox("Tool is None", MsgBoxStyle.Exclamation, "Warning")
            ElseIf TextBox6.Text = vbNullString Then
                MsgBox("Fail Comment is None", MsgBoxStyle.Exclamation, "Warning")
            ElseIf MsgBox("Use This Board? " & vbNewLine, vbExclamation + vbYesNo, "Add") = vbYes Then
                Select Case DataGridView1.CurrentRow.Cells(2).Value.ToString
                    Case "Pass"
                        UserData.Type = DataGridView1.CurrentRow.Cells(0).Value.ToString
                        UserData.SN = DataGridView1.CurrentRow.Cells(1).Value.ToString
                        UserData.status = DataGridView1.CurrentRow.Cells(2).Value.ToString
                        UserData.cinput = DataGridView1.CurrentRow.Cells(4).Value.ToString & vbCrLf & "Use on T" & TextBox5.Text & " date:" & Format(Now, "yyyy/MM/dd")
                        UserData.user = UCase(Form3.TextBox1.Text)
                        UserData.data = Format(Now, "yyyy/MM/dd")
                        UserData.ninput = UCase(TextBox4.Text.Trim)
                        UserData.use()
                        UserData.check()
                        If UserData.sel = True Then '没有重复SN
                            UserData.comment = "From T" & TextBox5.Text & "S750 Fail: " & TextBox6.Text & " date:" & Format(Now, "yyyy/MM/dd")
                            UserData.AddF()
                        Else '有重复SN
                            UserData.getcomment()
                            UserData.comment = UserData.comm & vbCrLf & "From T" & TextBox5.Text & "S750 Fail: " & TextBox6.Text & " date:" & Format(Now, "yyyy/MM/dd")
                            UserData.changeF()
                        End If
                        DataGridView1.DataSource = UserData.diaplay()
                        TextBox4.Text = ""
                        TextBox5.Text = ""
                        TextBox6.Text = ""
                    Case "Fail"
                        If MsgBox("Use Fail Board? " & vbNewLine, vbExclamation + vbYesNo, "Add") = vbYes Then
                            UserData.Type = DataGridView1.CurrentRow.Cells(0).Value.ToString
                            UserData.SN = DataGridView1.CurrentRow.Cells(1).Value.ToString
                            UserData.status = DataGridView1.CurrentRow.Cells(2).Value.ToString
                            UserData.cinput = DataGridView1.CurrentRow.Cells(4).Value.ToString & vbCrLf & "Use on T" & TextBox5.Text & " date:" & Format(Now, "yyyy/MM/dd")
                            UserData.user = UCase(Form3.TextBox1.Text)
                            UserData.data = Format(Now, "yyyy/MM/dd")
                            UserData.ninput = UCase(TextBox4.Text.Trim)
                            UserData.use()
                            UserData.check()
                            If UserData.sel = True Then '没有重复SN
                                UserData.comment = "From T" & TextBox5.Text & "S750 Fail: " & TextBox6.Text & " date:" & Format(Now, "yyyy/MM/dd")
                                UserData.AddF()
                            Else '有重复SN
                                UserData.getcomment()
                                UserData.comment = UserData.comm & vbCrLf & "From T" & TextBox5.Text & "S750 Fail: " & TextBox6.Text & " date:" & Format(Now, "yyyy/MM/dd")
                                UserData.changeF()
                            End If
                            DataGridView1.DataSource = UserData.diaplay()
                            TextBox4.Text = ""
                            TextBox5.Text = ""
                            TextBox6.Text = ""
                        End If
                    Case Else
                        MsgBox("This board is " & DataGridView1.CurrentRow.Cells(2).Value.ToString, MsgBoxStyle.Exclamation)
                End Select
            End If
        End If
        TextBox3.Text = DataGridView1.RowCount
    End Sub
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged '机台限制2位数
        Dim count As Integer = System.Text.Encoding.Default.GetByteCount(Me.TextBox5.Text)
        If count > 2 Then
            TextBox5.Text = ""
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click '送修
        Call logon()
        If log = True Then
            If Not rht = 3 Then
                If MsgBox("Send This Board to repair by " & ComboBox3.Text & "?" & vbNewLine, vbExclamation + vbYesNo, "Send") = vbYes Then
                    If ComboBox2.Text = "Fail" Then
                        UserData.Type = DataGridView1.CurrentRow.Cells(0).Value.ToString
                        UserData.SN = DataGridView1.CurrentRow.Cells(1).Value.ToString
                        UserData.status = DataGridView1.CurrentRow.Cells(2).Value.ToString
                        UserData.data = Format(Now, "yyyy/MM/dd")
                        UserData.comment = DataGridView1.CurrentRow.Cells(4).Value.ToString
                        UserData.cinput = DataGridView1.CurrentRow.Cells(4).Value.ToString & vbCrLf & "send to repair  " & ComboBox3.Text & " Date:" & Format(Now, "yyyy/MM/dd") & vbCrLf & "Repair Comment: " & TextBox7.Text
                        UserData.user = UCase(Form3.TextBox1.Text)
                        UserData.sendrepair()
                        DataGridView1.DataSource = UserData.diaplay()
                        TextBox7.Text = ""
                    Else
                        MsgBox("This Board Needn't To Repair", MsgBoxStyle.Exclamation)
                    End If
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                    TextBox7.Text = ""
                    TextBox3.Text = DataGridView1.RowCount
                End If
            Else
                MsgBox("No Permission ", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub
   Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click '测板子pass
        Call logon()
        If log = True Then
            If Not rht = 3 Then
                If MsgBox("Ready This Board ? " & vbNewLine, vbExclamation + vbYesNo, "Ready") = vbYes Then
                    If ComboBox2.Text = "Fail" Then
                        UserData.Type = DataGridView1.CurrentRow.Cells(0).Value.ToString
                        UserData.SN = DataGridView1.CurrentRow.Cells(1).Value.ToString
                        UserData.status = DataGridView1.CurrentRow.Cells(2).Value.ToString
                        UserData.data = Format(Now, "yyyy/MM/dd")
                        UserData.comment = DataGridView1.CurrentRow.Cells(4).Value.ToString
                        UserData.cinput = DataGridView1.CurrentRow.Cells(4).Value.ToString & vbCrLf & "Loop pass " & "Comment:" & TextBox7.Text & " Date:" & Format(Now, "yyyy/MM/dd")
                        UserData.user = UCase(Form3.TextBox1.Text)
                        UserData.looppass()
                        DataGridView1.DataSource = UserData.diaplay()
                    Else
                        MsgBox("This Board Needn't To Repair", MsgBoxStyle.Exclamation)
                    End If
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                    TextBox7.Text = ""
                    TextBox3.Text = DataGridView1.RowCount
                End If
            Else
                MsgBox("No Permission ", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click '添加 repair
        Call logon()
        If log = True Then
            If Not rht = 3 Then
                If TextBox1.Text = vbNullString Then
                    MsgBox("S/N is None", MsgBoxStyle.Exclamation, "Warning")
                Else
                    If MsgBox("Add This Record? " & vbNewLine, vbExclamation + vbYesNo, "Add") = vbYes Then
                        UserData.Type = ComboBox1.Text.Trim
                        UserData.ninput = UCase(TextBox1.Text.Trim)
                        UserData.check()
                        UserData.data = Format(Now, "yyyy/MM/dd")
                        UserData.user = UCase(Form3.TextBox1.Text)
                        If UserData.sel = False Then '有重复SN
                            UserData.comment = "Repeat SN. DOA" & " Date: " & Format(Now, "yyyy/MM/dd")
                            UserData.SDS()
                        Else  '没有重复SN
                            UserData.comment = "DOA" & " Date: " & Format(Now, "yyyy/MM/dd")
                            UserData.DOA()
                        End If
                        TextBox1.Text = ""
                        TextBox2.Text = ""
                        TextBox7.Text = ""
                        DataGridView1.DataSource = UserData.diaplay()
                        TextBox3.Text = DataGridView1.RowCount
                    End If
                End If
            Else
                MsgBox("No Permission ", MsgBoxStyle.Exclamation)
            End If
        End If
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

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click 'search
        If ComboBox2.Text = "Pass and Fail" Then 'status
            UserData.sinput = "status in ('Pass','Fail')"
        Else : UserData.sinput = "status='" & ComboBox2.Text & "'"
        End If
        If ComboBox1.Text = "All" Then 'status
            UserData.tinput = vbNullString
        Else : UserData.tinput = " and Type='" & ComboBox1.Text & "'"
        End If
        If TextBox1.Text = vbNullString Then 'SN
            UserData.ninput = vbNullString
        Else : UserData.ninput = " and SN='" & UCase(TextBox1.Text.Trim) & "'"
        End If
        If TextBox2.Text = vbNullString Then 'comment
            UserData.cinput = vbNullString
        Else : UserData.cinput = " and comment like '%" & UCase(TextBox2.Text.Trim) & "%'"
        End If
        If CheckBox1.Checked Then '日期
            UserData.data = " and data between #" & DateTimePicker2.Value.ToShortDateString & "# and #" & DateTimePicker3.Value.ToShortDateString & "#"
        Else : UserData.data = vbNullString
        End If
        Me.DataGridView1.DataSource = UserData.search()
        Me.TextBox3.Text = Me.DataGridView1.RowCount
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        DataGridView1.DataSource = UserData.GetAll()
        TextBox3.Text = DataGridView1.RowCount
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick '刷新
        ComboBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        TextBox1.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        ComboBox2.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        TextBox2.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click 'Upgrade
        Call logon()
        If log = True Then
            If Not rht = 3 Then
                If MsgBox("Unready This Record? " & vbNewLine, vbExclamation + vbYesNo, "Add") = vbYes Then
                    UserData.Type = DataGridView1.CurrentRow.Cells(0).Value.ToString
                    UserData.SN = DataGridView1.CurrentRow.Cells(1).Value.ToString
                    UserData.cinput = DataGridView1.CurrentRow.Cells(4).Value.ToString & vbCrLf & TextBox7.Text & " date:" & Format(Now, "yyyy/MM/dd")
                    UserData.user = UCase(Form3.TextBox1.Text)
                    UserData.data = Format(Now, "yyyy/MM/dd")
                    UserData.use()
                    DataGridView1.DataSource = UserData.diaplay()
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                    TextBox7.Text = ""
                End If
            Else
                MsgBox("No Permission ", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub
End Class
