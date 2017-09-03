Public Class Form9
    Private Sub picBack7_Click(sender As Object, e As EventArgs) Handles picBack9.Click
        My.Forms.Form6.Text = Now.ToString
        My.Forms.Form6.Show()
        Me.Close()
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel9.Paint

    End Sub

    Private Sub picRev9_Click(sender As Object, e As EventArgs) Handles picRev9.Click
        My.Forms.Form10.Text = Now.ToString
        My.Forms.Form10.Show()
        Me.Close()
    End Sub
End Class