Public Class Second_Highest

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b, c, max As Long
        a = Integer.Parse(Val(TextBox1.Text))
        b = Integer.Parse(Val(TextBox2.Text))
        c = Integer.Parse(Val(TextBox3.Text))

        If ((a > b) And (a > c)) Then
            If (b > c) Then
                max = b
            Else
                max = c
            End If
        ElseIf ((b > a) And (b > c)) Then
            If (a > c) Then
                max = a
            Else
                max = c
            End If
        Else
            If (a > b) Then
                max = a
            Else
                max = b
            End If
        End If
        TextBox3.Text = "Second Highest Number is: " & max
    End Sub
End Class