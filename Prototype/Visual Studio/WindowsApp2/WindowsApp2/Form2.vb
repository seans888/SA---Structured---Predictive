Public Class Form2
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSign2_Click(sender As Object, e As EventArgs) Handles btnSign2.Click
        My.Forms.Form3.Text = Now.ToString
        My.Forms.Form3.Show()
    End Sub
End Class