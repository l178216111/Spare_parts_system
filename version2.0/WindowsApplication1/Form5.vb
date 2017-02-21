Public Class Form5
    Dim UserData As UserPermission
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserData = New UserPermission()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click 'borrow
        Call Form1.logon()
        If Form1.log = True Then
            If TextBox4.Text = vbNullString Then
                MsgBox("Fail S/N is None", MsgBoxStyle.Exclamation, "Warning") '确认输入SN
            ElseIf TextBox5.Text = vbNullString Then
                MsgBox("Tool is None", MsgBoxStyle.Exclamation, "Warning") '确认输入 机台
            ElseIf TextBox6.Text = vbNullString Then '确认输入comment
                MsgBox("Fail Comment is None", MsgBoxStyle.Exclamation, "Warning")
            ElseIf MsgBox("Use This Board? " & vbNewLine, vbExclamation + vbYesNo, "Add") = vbYes Then '最终确认
                Call Form1.list()
                UserData.cinput = Form1.DataGridView1.CurrentRow.Cells(4).Value.ToString & vbCrLf & "Use on T" & TextBox5.Text & ". " & Format(Now, "yyyy/MM/dd")
                UserData.user = UCase(Form3.TextBox1.Text)
                UserData.ninput = UCase(TextBox4.Text.Trim)
                UserData.use()
                UserData.check()
                If UserData.sel = True Then '没有重复SN
                    UserData.comment = "Fail from T" & TextBox5.Text & ".Comment: " & TextBox6.Text & ". " & Format(Now, "yyyy/MM/dd")
                    UserData.AddF()
                Else '有重复SN
                    UserData.getcomment()
                    UserData.comment = UserData.comm & vbCrLf & "Fail from T" & TextBox5.Text & ".Comment: " & TextBox6.Text & ". " & Format(Now, "yyyy/MM/dd")
                    UserData.changeF()
                End If
                Form1.DataGridView1.DataSource = UserData.diaplay()
            End If
        End If
    End Sub
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)  '机台限制2位数
        Dim count As Integer = System.Text.Encoding.Default.GetByteCount(Me.TextBox5.Text)
        If count > 2 Then
            TextBox5.Text = ""
        End If
    End Sub
End Class