Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function GetTxtLabel1() As Label
        Return txtLabel1
    End Function

    Private Sub txtBoton_Click(sender As Object, e As EventArgs) Handles txtBoton.Click
        For N = 2 To 2000 Step 2
        Next
    End Sub
End Class
