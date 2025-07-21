Public Class Avg_Three_Nos

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim num1, num2, num3 As Integer
        Dim sum, avg As Double

        num1 = Val(TextBox1.Text)
        num2 = Val(TextBox2.Text)
        num3 = Val(TextBox3.Text)

        sum = (num1 + num2 + num3)
        avg = (Int(sum / 3.0))

        TextBox4.Text = "Average of  numbers are " & avg
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub
End Class