Public Class Form4
    Dim UserData As UserPermission
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UserData.change()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserData = New UserPermission()
    End Sub
End Class