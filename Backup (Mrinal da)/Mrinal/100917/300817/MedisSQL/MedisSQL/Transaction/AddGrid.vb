Imports System.Data.SqlClient
Imports System.Data
Public Class AddGrid1
    Dim dt As New DataTable
    Private Sub AddGrid_Load(sender As Object, e As EventArgs) Handles Me.Load

        dt.Columns.Add("n1")
        dt.Columns.Add("sex")
        dt.AcceptChanges()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dr As DataRow
        dr = dt.NewRow()
        dr("n1") = TextBox1.Text
        dr("sex") = TextBox2.Text
        dt.Rows.Add(dr)
        dt.AcceptChanges()
        dg.DataSource = dt

    End Sub
End Class