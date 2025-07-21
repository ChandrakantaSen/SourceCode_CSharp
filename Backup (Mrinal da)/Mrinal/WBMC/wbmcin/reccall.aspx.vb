
Partial Class reccall
    Inherits System.Web.UI.Page

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        If txtPW.Text = "showdoc" Then
            Response.Redirect("default.aspx")
        ElseIf txtPW.Text = "showmem" Then
            Response.Redirect("memberslist.html")

        End If
    End Sub
End Class
