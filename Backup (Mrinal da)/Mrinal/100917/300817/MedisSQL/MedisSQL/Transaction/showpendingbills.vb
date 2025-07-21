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
Public Class showpendingbills

    Private Sub showpendingbills_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            showbillsummary()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub showbillsummary()
        Try
            Dim patientfk As String = Class1.cPatientfk
            Dim param(0) As SqlParameter
            param(0) = New SqlParameter("@patientfk", patientfk)
            Dim ds As DataSet
            ds = Class1.ExecQueryDS("showPatientOutstandingBill", Class1.CustomCommandType.StoredPorcedure, param)

            dgbillsummary.DataSource = ds.Tables(0)

        Catch ex As Exception

        End Try
    End Sub
End Class