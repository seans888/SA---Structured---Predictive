Public Class Form8
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblPercentage1_6_Click(sender As Object, e As EventArgs) Handles lblPercentage1_6.Click

    End Sub

    Private Sub picBack8_Click(sender As Object, e As EventArgs) Handles picBack8.Click
        My.Forms.Form6.Text = Now.ToString
        My.Forms.Form6.Show()
        Me.Close()
    End Sub

    Private Sub picRevese8_Click(sender As Object, e As EventArgs) Handles picRevese8.Click
        My.Forms.Form7.Text = Now.ToString
        My.Forms.Form7.Show()
        Me.Close()
    End Sub

    Private Sub lblSample1_6_Click(sender As Object, e As EventArgs) Handles lblHeader8.Click

    End Sub
End Class