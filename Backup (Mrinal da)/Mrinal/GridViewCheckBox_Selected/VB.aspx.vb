
Imports System.Data

Partial Class VB
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Dim dt As New DataTable()
            dt.Columns.AddRange(New DataColumn(1) {New DataColumn("Name"), New DataColumn("Country")})
            dt.Rows.Add("John Hammond", "Canada")
            dt.Rows.Add("Rick Stewards", "United States")
            dt.Rows.Add("Huang He", "China")
            dt.Rows.Add("Mudassar Khan", "India")
            GridView1.DataSource = dt
            GridView1.DataBind()
        End If
    End Sub
    Protected Sub GetSelectedRecords(sender As Object, e As EventArgs)
        Dim dt As New DataTable()
        dt.Columns.AddRange(New DataColumn(1) {New DataColumn("Name"), New DataColumn("Country")})
        For Each row As GridViewRow In GridView1.Rows
            If row.RowType = DataControlRowType.DataRow Then
                Dim chkRow As CheckBox = TryCast(row.Cells(0).FindControl("chkRow"), CheckBox)
                If chkRow.Checked Then
                    Dim name As String = row.Cells(1).Text
                    Dim country As String = TryCast(row.Cells(2).FindControl("lblCountry"), Label).Text
                    dt.Rows.Add(name, country)
                End If
            End If
        Next
        gvSelected.DataSource = dt
        gvSelected.DataBind()
    End Sub
End Class
