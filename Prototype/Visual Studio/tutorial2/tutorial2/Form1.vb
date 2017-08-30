Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim txtOutput As String = " "

        Dim randStr As String = "This is a string"

        txtOutput &= "randStr length = " & randStr.Length & Environment.NewLine

        txtOutput &= "1st 3 = " & randStr.Substring(0, 3) & Environment.NewLine

        randStr = randStr.Replace("string", "sentence")
        txtOutput &= "Changed String = " & randStr & Environment.NewLine

        Dim decRandNum As Decimal = 3123.14159
        txtOutput &= "Value = " & String.Format("{0:n3}", decRandNum) & Environment.NewLine
        txtOutput &= "Currency = " & String.Format("{0:c}", decRandNum) & Environment.NewLine
        txtOutput &= "Random = " & String.Format("{0:00000.0}", decRandNum) & Environment.NewLine
        txtOutput &= "is in String = " & InStr(1, randStr, "i", CompareMethod.Text) & Environment.NewLine

        Dim arrayEmployees(0 To 2) As String
        arrayEmployees(0) = "Bob"
        arrayEmployees(1) = "Sally"
        arrayEmployees(2) = "Paul"

        Dim strEmployees As String = Join(arrayEmployees, ", ")

        txtOutput &= "Employees = " & strEmployees & Environment.NewLine

        TextBox1.Text = txtOutput

    End Sub
End Class
