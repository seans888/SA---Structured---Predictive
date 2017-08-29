Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblName.Click

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        txtName.Text = "Hello " & txtName.Text

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMessage.Click
        MessageBox.Show("Hello " & txtName.Text, "Hello" & txtName.Text)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles btnAddValues.Click

        Try
            Dim firstNum As Integer = CInt(txtAddVal1.Text)
            Dim secondNum As Integer = CInt(txtAddVal2.Text)
            Dim sum = firstNum + secondNum

            txtSumAnswer.Text = CStr(sum)

        Catch ex As System.InvalidCastException
            MessageBox.Show("Please enter numbers to sum", "Error")

            Console.WriteLine("An Error occured")

        Catch ex As Exception
            MessageBox.Show("An unknown error occured", "Error")

        End Try

    End Sub

    Private Sub txtDivideVal1_TextChanged(sender As Object, e As EventArgs) Handles txtDivideVal1.TextChanged


    End Sub

    Private Sub btnDivideValues_Click(sender As Object, e As EventArgs) Handles btnDivideValues.Click

        Dim firstNum As Decimal = CDec(txtDivideVal1.Text)
        Dim secondNum As Decimal = CDec(txtDivideVal2.Text)
        Dim intSolution As Integer = CType(firstNum / secondNum, Integer)

        txtDivisionAnswer.Text = CStr(intSolution)
    End Sub
End Class
