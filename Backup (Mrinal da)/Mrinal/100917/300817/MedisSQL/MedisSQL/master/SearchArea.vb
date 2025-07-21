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
Public Class SearchArea

    Private Sub SearchArea_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Class1.GetAccess(Class1.CAreaMaster, "View", "", Class1.cUserpk) = False Then
                MsgBox("No Access Rights!!")
                Me.BeginInvoke(New MethodInvoker(AddressOf Me.Close))
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub fetchArea()
        Try
            Dim param(1) As SqlParameter
            param(0) = New SqlParameter("@areacode", txtcode.Text)
            param(1) = New SqlParameter("@areaname", txtname.Text)
            Dim ds As DataSet
            ds = Class1.ExecQueryDS("SearchArea", Class1.CustomCommandType.StoredPorcedure, param)
            dgarea.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            fetchArea()
        Catch ex As Exception

        End Try
    End Sub
End Class