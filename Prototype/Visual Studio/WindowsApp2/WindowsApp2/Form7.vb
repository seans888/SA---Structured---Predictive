Public Class Form7
    Private Sub lblConcern2_6_Click(sender As Object, e As EventArgs) Handles lblConcern2_6.Click

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picBack7.Click
        My.Forms.Form6.Text = Now.ToString
        My.Forms.Form6.Show()
        Me.Close()
    End Sub

    Private Sub lblPercentage3_6_Click(sender As Object, e As EventArgs) Handles lblPercentage3_6.Click

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub picRev7_Click(sender As Object, e As EventArgs) Handles picRev7.Click
        My.Forms.Form8.Text = Now.ToString
        My.Forms.Form8.Show()
        Me.Close()
    End Sub
End Class