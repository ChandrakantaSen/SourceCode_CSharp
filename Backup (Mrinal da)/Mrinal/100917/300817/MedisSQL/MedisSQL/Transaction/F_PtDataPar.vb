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
Public Class F_PtDataPar
    Private Sub F_PtDataPar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            getregisteredfordoctor()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub getregisteredfordoctor()
        Try
            Dim ds As DataSet
            Dim param(0) As SqlParameter
            param(0) = New SqlParameter("@visitorref", 1)
            ds = Class1.ExecQueryDS("getVisiteddoctor", Class1.CustomCommandType.StoredPorcedure, param)
            Dim dr As DataRow
            dr = ds.Tables(0).NewRow()
            dr(0) = -1
            dr(1) = "Select"

            ds.Tables(0).Rows.InsertAt(dr, 0)
            ddregdoct.DataSource = ds.Tables(0)
            ddregdoct.DisplayMember = "RefName"
            ddregdoct.ValueMember = "id"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ddregdoct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddregdoct.SelectedIndexChanged
        txtVDoc.Text = ddregdoct.SelectedValue.ToString()
    End Sub

    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click
        Try

            Dim ds As New DataSet()
            ds = fetchDailyPatList("F")
            dgPtDataDParNew.DataSource = ds.Tables(0)
            dgPtDataDParAC.DataSource = ds.Tables(1)
            dgPtDataDParRC.DataSource = ds.Tables(3)
            dgPtDataDParSC.DataSource = ds.Tables(2)
        Catch ex As Exception

        End Try
    End Sub
    Private Function fetchDailyPatList(ByVal vDONE As String) As DataSet
        Dim ds As New DataSet
        Dim dt As New DataTable
        Try
            Dim param(2) As SqlParameter
            param(0) = New SqlParameter("@dt", txtDt.Value.ToString("dd-MMM-yyyy"))
            param(1) = New SqlParameter("@VDoc", txtVDoc.Text)
            param(2) = New SqlParameter("@VDone", vDONE)



            ds = Class1.ExecQueryDS("fetchDailyPatList", Class1.CustomCommandType.StoredPorcedure, param)
            'dt = ds.Tables(0)
        Catch ex As Exception

        End Try
        Return ds

    End Function

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgPtDataDParRC_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPtDataDParRC.CellContentDoubleClick
        Try

            If e.ColumnIndex = 0 Then
                Class1.cPatientfk = dgPtDataDParRC.Rows(e.RowIndex).Cells(5).Value
                Dim frm As New frmPtData
                frm.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgPtDataDParSC_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPtDataDParSC.CellContentDoubleClick
        Try

            If e.ColumnIndex = 0 Then
                Class1.cPatientfk = dgPtDataDParSC.Rows(e.RowIndex).Cells(5).Value
                Dim frm As New frmPtData
                frm.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgPtDataDParAC_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPtDataDParAC.CellContentDoubleClick
        Try

            If e.ColumnIndex = 0 Then
                Class1.cPatientfk = dgPtDataDParAC.Rows(e.RowIndex).Cells(5).Value
                Dim frm As New frmPtData
                frm.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgPtDataDParNew_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPtDataDParNew.CellContentDoubleClick
        Try

            If e.ColumnIndex = 0 Then
                Class1.cPatientfk = dgPtDataDParNew.Rows(e.RowIndex).Cells(5).Value
                Dim frm As New frmPtData
                frm.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class