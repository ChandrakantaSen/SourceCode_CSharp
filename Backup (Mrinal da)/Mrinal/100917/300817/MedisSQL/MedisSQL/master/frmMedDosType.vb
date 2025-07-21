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
Public Class frmMedDosType
    Private Sub frmMedDosType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populatedosage()

    End Sub
    Private Sub populatedosage()
        Try
            Dim dsd As DataSet
            ' Dim param(0) As SqlParameter
            'param(0) = New SqlParameter("@countryid", ddcountry.SelectedValue)

            dsd = Class1.ExecQueryDS("MedDosTypeMas", Class1.CustomCommandType.StoredPorcedure)
            lstLabMas.DataSource = dsd.Tables(0)
            lstLabMas.DisplayMember = "DosType"
            lstLabMas.ValueMember = "DosID"
        Catch ex As Exception

        End Try
    End Sub
    Private Sub save()
        Try
            Dim param(1) As SqlParameter

            param(0) = New SqlParameter("@Dosid", txtDosID.Text)
            param(1) = New SqlParameter("@Dostype", txtDosType.Text)

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
            param(0) = New SqlParameter("Dosid", lstLabMas.SelectedValue)
            Dim ds As DataSet
            ds = Class1.ExecQueryDS("getMedDosTypeMas", Class1.CustomCommandType.StoredPorcedure, param)
            txtDosID.Text = ds.Tables(0).Rows(0).Item("Dosid")
            txtDosType.Text = ds.Tables(0).Rows(0).Item("Dostype")
            Class1.CDosID = lstLabMas.SelectedValue

        Catch ex As Exception

        End Try
    End Sub

    Private Sub clearall()
        Try
            txtDosID.Text = ""
            txtDosType.Text = ""
            Class1.CDosID = "-1"

        Catch ex As Exception

        End Try
    End Sub
    Private Sub saveagent()
        Try
            Dim param(1) As SqlParameter

            param(0) = New SqlParameter("@Dosid", txtDosID.Text)
            param(1) = New SqlParameter("@Dostype", txtDosType.Text)

            Dim dsret As DataSet
            dsret = Class1.ExecQueryDS("mas_insert_Dos", Class1.CustomCommandType.StoredPorcedure, param)
            If dsret.Tables(0).Rows(0).Item(0) = "1" Then
                MsgBox("Save Successfully!")
            Else
                MsgBox("Error in Saving!")
            End If
            populatedosage()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub editagent()
        Try
            Dim param(2) As SqlParameter

            param(0) = New SqlParameter("@DosId", txtDosID.Text)
            param(1) = New SqlParameter("@DosType", txtDosType.Text)

            Dim dsret As DataSet
            dsret = Class1.ExecQueryDS("mas_Update_Dos", Class1.CustomCommandType.StoredPorcedure, param)
            If dsret.Tables(0).Rows(0).Item(0) = "1" Then
                MsgBox("Successfully Updated!")
            Else
                MsgBox("Error in Saving!")
            End If
            populatedosage()
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
            lstLabMas.Enabled = False
            btnexit.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If Class1.CDosID = "-1" Then
                saveagent()
            Else
                editagent()
            End If
            clearall()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub lstLabMas_Click(sender As Object, e As EventArgs) Handles lstLabMas.Click
        Try
            fetchagentdetailsbyagentid()
        Catch ex As Exception

        End Try
    End Sub
End Class