Public Class EvenCheck_Input_Box

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n As Integer
        n = InputBox("Enter the range: ")
        'Debug.WriteLine("Inputted Value is: " & n)
        Print(n)
    End Sub
End Class