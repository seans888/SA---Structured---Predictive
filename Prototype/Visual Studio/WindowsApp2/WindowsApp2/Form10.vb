Public Class Form10
    Private Sub picBack10_Click(sender As Object, e As EventArgs) Handles picBack10.Click
        My.Forms.Form6.Text = Now.ToString
        My.Forms.Form6.Show()
        Me.Close()
    End Sub

    Private Sub picRevese10_Click(sender As Object, e As EventArgs) Handles picRevese10.Click
        My.Forms.Form9.Text = Now.ToString
        My.Forms.Form9.Show()
        Me.Close()
    End Sub

    Private Sub btnHome10_Click(sender As Object, e As EventArgs) Handles btnHome10.Click
        My.Forms.Form5.Text = Now.ToString
        My.Forms.Form5.Show()
        Me.Close()
    End Sub
End Class