Public Class Form6
    Dim UserData As UserPermission
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserData = New UserPermission()
    End Sub
    Private Sub list() 'dataview 赋值
        UserData.Type = Form1.DataGridView1.CurrentRow.Cells(0).Value.ToString 'type
        UserData.SN = Form1.DataGridView1.CurrentRow.Cells(1).Value.ToString 'SN
        UserData.status = Form1.DataGridView1.CurrentRow.Cells(2).Value.ToString '状态
        UserData.comment = Form1.DataGridView1.CurrentRow.Cells(4).Value.ToString 'comment
        UserData.user = UCase(Form3.TextBox1.Text)
        UserData.data = Format(Now, "yyyy/MM/dd") 'date
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click  '添加
        If TextBox8.Text = vbNullString Then
            MsgBox("S/N is None", MsgBoxStyle.Exclamation, "Warning")
        ElseIf MsgBox("Add This Record? " & vbNewLine, vbExclamation + vbYesNo, "Add") = vbYes Then
            UserData.Type = ComboBox1.Text.Trim
            UserData.SN = UCase(TextBox8.Text.Trim)
            UserData.status = ComboBox2.Text.Trim
            UserData.data = Format(Now, "yyyy/MM/dd")
            UserData.comment = TextBox2.Text.Trim
            UserData.user = UCase(Form3.TextBox1.Text)
            UserData.ninput = UCase(TextBox8.Text.Trim)
            ' UserData.user = Form3.TextBox1.Text
            Call UserData.check()
            If UserData.sel = False Then '有重复SN
                MsgBox("The repeat record", MsgBoxStyle.Exclamation)
                Form1.DataGridView1.DataSource = UserData.diaplayy()
            Else
                UserData.Add()
                Form1.DataGridView1.DataSource = UserData.diaplay()
                TextBox8.Text = ""
                TextBox2.Text = ""
            End If
        End If
        Form1.TextBox2.Text = Form1.DataGridView1.RowCount
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click 'change
        If MsgBox("Change This Record? " & vbNewLine, vbExclamation + vbYesNo, "Change") = vbYes Then
            Call list()
            UserData.tinput = ComboBox1.Text
            UserData.Type = ComboBox1.Text
            UserData.sinput = ComboBox2.Text
            UserData.ninput = UCase(TextBox8.Text)
            UserData.cinput = TextBox2.Text
            UserData.updata()
            Form1.DataGridView1.DataSource = UserData.diaplay()
        End If
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click '板子返回
        If MsgBox("Add This Record? " & vbNewLine, vbExclamation + vbYesNo, "Add") = vbYes Then
            UserData.Type = ComboBox1.Text
            UserData.ninput = UCase(TextBox8.Text.Trim)
            UserData.check()
            UserData.data = Format(Now, "yyyy/MM/dd")
            UserData.user = UCase(Form3.TextBox1.Text)
            If UserData.sel = False Then '有重复SN
                UserData.comment = "Repeat SN. DOA:" & "" & Format(Now, "yyyy/MM/dd")
                UserData.SDS()
            Else  '没有重复SN
                UserData.comment = "DOA:" & "" & Format(Now, "yyyy/MM/dd")
                UserData.DOA()
            End If
            TextBox8.Text = ""
            Form1.DataGridView1.DataSource = UserData.diaplay()
            Form1.TextBox2.Text = Form1.DataGridView1.RowCount
        End If
    End Sub
End Class