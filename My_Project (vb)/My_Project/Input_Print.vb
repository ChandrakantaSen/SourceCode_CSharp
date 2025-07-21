Public Class Input_Print

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim int As Integer
        Dim str, strPrint As String

        'int = TextBox1.Text
        str = TextBox1.Text
        strPrint = "Hello " & str & ". How are you?"

        'TextBox2.Paste(int)
        TextBox2.Paste(strPrint)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub
End Class