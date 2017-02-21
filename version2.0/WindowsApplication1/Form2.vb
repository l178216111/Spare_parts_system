Public Class Form2
    Dim UserData As UserPermission
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If ComboBox2.Text = "Pass and Fail" Then 'status
            UserData.sinput = "status in ('Pass','Fail')"
        ElseIf ComboBox2.Text = "All" Then
            UserData.sinput = "status in ('Pass','Fail','Using','Repair')"
        Else : UserData.sinput = "status='" & ComboBox2.Text & "'"
        End If
        If ComboBox1.Text = "All" Then 'status
            UserData.tinput = vbNullString
        Else : UserData.tinput = " and Type='" & ComboBox1.Text & "'"
        End If
        If TextBox1.Text = vbNullString Then 'SN
            UserData.ninput = vbNullString
        Else : UserData.ninput = " and SN like'%" & UCase(TextBox1.Text.Trim) & "%'"
        End If
        If TextBox2.Text = vbNullString Then 'comment
            UserData.cinput = vbNullString
        Else : UserData.cinput = " and comment like '%" & UCase(TextBox2.Text.Trim) & "%'"
        End If
        If CheckBox1.Checked Then '日期
            UserData.data = " and data between #" & DateTimePicker2.Value.ToShortDateString & "# and #" & DateTimePicker3.Value.ToShortDateString & "#"
        Else : UserData.data = vbNullString
        End If
        Form1.DataGridView1.DataSource = UserData.search()
        Me.TextBox3.Text = Form1.DataGridView1.RowCount
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserData = New UserPermission()
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker3.Format = DateTimePickerFormat.Custom
        Me.ComboBox1.SelectedIndex = 0
        Me.ComboBox2.SelectedIndex = 0
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Form1.DataGridView1.DataSource = UserData.GetAll()
        TextBox3.Text = Form1.DataGridView1.RowCount
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class