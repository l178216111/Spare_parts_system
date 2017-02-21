Public Class Form3
    Dim UserData As UserPermission
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call UserData.formlog()
        Form1.log = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.log = False
        Me.Hide()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserData = New UserPermission()
    End Sub
End Class