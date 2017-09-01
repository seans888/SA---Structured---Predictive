Public Class Form6
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblPercentage1_6_Click(sender As Object, e As EventArgs) Handles lblPercentage1_6.Click

    End Sub

    Private Sub lblConcern1_6_Click(sender As Object, e As EventArgs) Handles lblConcern1_6.Click
        My.Forms.Form7.Text = Now.ToString
        My.Forms.Form7.Show()
    End Sub

    Private Sub lblConcern2_6_Click(sender As Object, e As EventArgs) Handles lblConcern2_6.Click
        My.Forms.Form8.Text = Now.ToString
        My.Forms.Form8.Show()
    End Sub
End Class