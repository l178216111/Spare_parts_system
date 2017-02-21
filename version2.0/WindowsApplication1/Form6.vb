Public Class Form6
    Dim UserData As UserPermission
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserData = New UserPermission()
        Me.ComboBox1.SelectedIndex = 0
        Me.ComboBox2.SelectedIndex = 0
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs)  '板子返回
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
            TextBox2.Text = Form1.DataGridView1.RowCount
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs)  '修改
        If MsgBox("Change This Record? " & vbNewLine, vbExclamation + vbYesNo, "Change") = vbYes Then
            Call Form1.list()
            UserData.tinput = ComboBox1.Text
            UserData.sinput = ComboBox2.Text
            UserData.ninput = UCase(TextBox8.Text)
            UserData.cinput = TextBox2.Text
            UserData.updata()
            Form1.DataGridView1.DataSource = UserData.diaplay()
            TextBox2.Text = Form1.DataGridView1.RowCount
        End If
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs)  '添加
        If TextBox8.Text = vbNullString Then
            MsgBox("S/N is None", MsgBoxStyle.Exclamation, "Warning")
        ElseIf MsgBox("Add This Record? " & vbNewLine, vbExclamation + vbYesNo, "Add") = vbYes Then
            UserData.Type = ComboBox1.Text.Trim
            UserData.SN = UCase(TextBox8.Text.Trim)
            UserData.status = ComboBox2.Text.Trim
            UserData.data = Format(Now, "yyyy/MM/dd")
            UserData.comment = TextBox2.Text.Trim
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
        TextBox2.Text = Form1.DataGridView1.RowCount
    End Sub
End Class