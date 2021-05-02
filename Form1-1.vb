Public Class circleArea

    Const dblPl As Double = 3.14159

    Dim intr As Integer

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        intr = TextBox1.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblFalalala.Text = dblPl * intr * intr
    End Sub


End Class
