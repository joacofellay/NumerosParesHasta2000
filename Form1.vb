Public Class Form1
    Private Sub txtBoton_Click(sender As Object, e As EventArgs) Handles txtBoton.Click
        For N = 2 To 2000 Step 2
            txtMostrar.Items.Add(N)
        Next
    End Sub
End Class
