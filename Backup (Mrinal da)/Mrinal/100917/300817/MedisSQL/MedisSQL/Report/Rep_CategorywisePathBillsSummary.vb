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
Public Class Rep_CategorywisePathBillsSummary
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
            ds = Class1.ExecQueryDS("Rep_CategorywiseInHouseBillsSummary", Class1.CustomCommandType.StoredPorcedure, param)
            dgitemsummary.DataSource = ds.Tables(0)

        Catch ex As Exception

        End Try
    End Sub

End Class