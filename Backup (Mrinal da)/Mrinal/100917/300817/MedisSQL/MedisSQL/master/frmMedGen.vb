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
Public Class frmMedGen


    Private Sub frmMedGen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateMedGen()
    End Sub
    Private Sub populateMedGen()
        Try
            Dim dsd As DataSet
            ' Dim param(0) As SqlParameter
            'param(0) = New SqlParameter("@countryid", ddcountry.SelectedValue)

            dsd = Class1.ExecQueryDS("MedGenMasAll", Class1.CustomCommandType.StoredPorcedure)
            lstGenMas.DataSource = dsd.Tables(0)
            lstGenMas.DisplayMember = "MedGenName"
            lstGenMas.ValueMember = "MedGenId"
        Catch ex As Exception

        End Try
    End Sub
    Private Sub save()
        Try
            Dim param(1) As SqlParameter

            param(0) = New SqlParameter("@MedGenId", txtMedGenId.Text)
            param(1) = New SqlParameter("@MedGenName", txtMedGenName.Text)

            Dim dsret As DataSet
            dsret = Class1.ExecQueryDS("mas_insert_MasArea", Class1.CustomCommandType.StoredPorcedure, param)
            If dsret.Tables(0).Rows(0).Item(0) = "1" Then
                MsgBox("Successfully Updated!")
                Me.Close()
            Else
                MsgBox("Error in Saving!")
            End If

        Catch ex As Exception

        End Try
    End Sub


    Private Sub fetchagentdetailsbyagentid()
        Try
            Dim param(0) As SqlParameter
            param(0) = New SqlParameter("MedGenId", lstGenMas.SelectedValue)
            Dim ds As DataSet
            ds = Class1.ExecQueryDS("fetchMedGenMas", Class1.CustomCommandType.StoredPorcedure, param)
            txtMedGenId.Text = ds.Tables(0).Rows(0).Item("MedGenId") & ""
            txtMedGenName.Text = ds.Tables(0).Rows(0).Item("MedGenName") & ""
            txtIndication.Text = ds.Tables(0).Rows(0).Item("Indication") & ""
            txtContraInd.Text = ds.Tables(0).Rows(0).Item("ContraInd") & ""
            txtSplInfo.Text = ds.Tables(0).Rows(0).Item("SplInfo") & ""
            Class1.CMedGenId = lstGenMas.SelectedValue

        Catch ex As Exception

        End Try
    End Sub

    Private Sub clearall()
        Try
            txtMedGenId.Text = ""
            txtMedGenName.Text = ""
            txtIndication.Text = ""
            txtSplInfo.Text = ""
            txtContraInd.Text = ""
            Class1.CMedGenId = "-1"

        Catch ex As Exception

        End Try
    End Sub
    Private Sub saveagent()
        Try
            Dim param(5) As SqlParameter
            txtMedGenId.Text = Class1.NewYearId("T_MedPatMas", "MedPatId", "MP-", Date.Today(), 4)
            param(0) = New SqlParameter("@MedGenId", txtMedGenId.Text)
            param(1) = New SqlParameter("@MedGenName", txtMedGenName.Text)
            param(2) = New SqlParameter("@Indication", txtIndication.Text)
            param(3) = New SqlParameter("@ContraInd", txtContraInd.Text)
            param(4) = New SqlParameter("@SplInfo", txtSplInfo.Text)

            Dim dsret As DataSet
            dsret = Class1.ExecQueryDS("insert_MedGenMas", Class1.CustomCommandType.StoredPorcedure, param)
            If dsret.Tables(0).Rows(0).Item(0) = "1" Then
                MsgBox("Save Successfully!")
            Else
                MsgBox("Error in Saving!")
            End If
            populateMedGen()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub editagent()
        Try
            Dim param(4) As SqlParameter

            param(0) = New SqlParameter("@MedGenId", txtMedGenId.Text)
            param(1) = New SqlParameter("@MedGenName", txtMedGenName.Text)
            param(2) = New SqlParameter("@Indication", txtIndication.Text)
            param(3) = New SqlParameter("@ContraInd", txtContraInd.Text)
            param(4) = New SqlParameter("@SplInfo", txtSplInfo.Text)

            Dim dsret As DataSet
            dsret = Class1.ExecQueryDS("Update_MedGenMas", Class1.CustomCommandType.StoredPorcedure, param)
            If dsret.Tables(0).Rows(0).Item(0) = "1" Then
                MsgBox("Successfully Updated!")
            Else
                MsgBox("Error in Saving!")
            End If
            populateMedGen()
            clearall()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnadd_Click_1(sender As Object, e As EventArgs) Handles btnadd.Click
        Try
            clearall()
            lstGenMas.Enabled = False
            btnexit.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If Class1.CMedGenId = "-1" Then
                saveagent()
            Else
                editagent()
            End If
            clearall()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lstGenMas_Click(sender As Object, e As EventArgs) Handles lstGenMas.Click
        Try
            fetchagentdetailsbyagentid()
        Catch ex As Exception

        End Try
    End Sub
End Class