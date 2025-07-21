Public Class Add_Two_Nos

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim num1, num2 As Integer
        Dim sum As Double

        num1 = Val(TextBox1.Text)   'Input through textbox 1
        num2 = Val(TextBox2.Text)   'Input through textbox 2
        sum = num1 + num2

        TextBox3.Text = sum 'Print sum into the textbox 3

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
End Class