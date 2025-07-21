Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Reflection
Imports System
Imports utility
Public Class Rep_ItemwiseDirBillsSummary
    Dim billitemid As String
    Dim billdesc As String = ""
    Dim rate As String = ""
    Private Sub Rep_ItemwiseRegBillsSummary_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            fetchitemdata()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub fetchitemdata()
        Try
            Dim param(2) As SqlParameter
            param(0) = New SqlParameter("@fromDate", txtfromdate.Text)
            param(1) = New SqlParameter("@todate", txttodate.Text)
            param(2) = New SqlParameter("@item", "")
            Dim ds As DataSet
            ds = Class1.ExecQueryDS("Rep_ItemwiseDirBillsSummary", Class1.CustomCommandType.StoredPorcedure, param)
            dgitemsummary.DataSource = ds.Tables(0)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgitemsummary_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgitemsummary.CellContentClick

    End Sub

    Private Sub dgitemsummary_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgitemsummary.CellDoubleClick
        Try

            billitemid = dgitemsummary.Rows(e.RowIndex).Cells(0).Value
            billdesc = dgitemsummary.Rows(e.RowIndex).Cells(1).Value
            rate = dgitemsummary.Rows(e.RowIndex).Cells(3).Value
            lbltestitem.Text = "Text Item :" & billdesc & " For the period between " & txtfromdate.Text & " and " & txttodate.Text
            regbilldetails()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub regbilldetails()
        Try
            Dim param(3) As SqlParameter
            param(0) = New SqlParameter("fromdate", txtfromdate.Text)
            param(1) = New SqlParameter("todate", txttodate.Text)
            param(2) = New SqlParameter("billitemid", billitemid)
            param(3) = New SqlParameter("rate", rate)
            Dim ds As DataSet
            ds = Class1.ExecQueryDS("Rep_ItemwiseDirBillsdetails_itemwise", Class1.CustomCommandType.StoredPorcedure, param)
            dgitemdetails.DataSource = ds.Tables(0)
            dgitemdetails.Columns.Remove("AitName")
        Catch ex As Exception

        End Try
    End Sub
End Class