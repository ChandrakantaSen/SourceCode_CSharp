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
Public Class frmMedType


    Private Sub frmMedType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateMedType()
    End Sub

    Private Sub populateMedType()
        Try
            Dim dsd As DataSet
            ' Dim param(0) As SqlParameter
            'param(0) = New SqlParameter("@countryid", ddcountry.SelectedValue)

            dsd = Class1.ExecQueryDS("FetchType", Class1.CustomCommandType.StoredPorcedure)
            lstGenMas.DataSource = dsd.Tables(0)
            lstGenMas.DisplayMember = "TypeNam"
            lstGenMas.ValueMember = "Typeid"
        Catch ex As Exception

        End Try
    End Sub
    Private Sub save()
        Try
            Dim param(1) As SqlParameter

            param(0) = New SqlParameter("@Freqid", txtLabID.Text)
            param(1) = New SqlParameter("@Frequency", txtLabName.Text)

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
            param(0) = New SqlParameter("Freqid", lstGenMas.SelectedValue)
            Dim ds As DataSet
            ds = Class1.ExecQueryDS("getMedFrequencyMas", Class1.CustomCommandType.StoredPorcedure, param)
            txtLabID.Text = ds.Tables(0).Rows(0).Item("Freqid")
            txtLabName.Text = ds.Tables(0).Rows(0).Item("Frequency")
            Class1.CFreqID = lstGenMas.SelectedValue

        Catch ex As Exception

        End Try
    End Sub

    Private Sub clearall()
        Try
            txtLabID.Text = ""
            txtLabName.Text = ""
            Class1.CAreaID = "-1"

        Catch ex As Exception

        End Try
    End Sub
    Private Sub saveagent()
        Try
            Dim param(1) As SqlParameter

            param(0) = New SqlParameter("@Freqid", txtLabID.Text)
            param(1) = New SqlParameter("@Frequency", txtLabName.Text)

            Dim dsret As DataSet
            dsret = Class1.ExecQueryDS("mas_insert_MasArea", Class1.CustomCommandType.StoredPorcedure, param)
            If dsret.Tables(0).Rows(0).Item(0) = "1" Then
                MsgBox("Save Successfully!")
            Else
                MsgBox("Error in Saving!")
            End If
            populateMedType()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub editagent()
        Try
            Dim param(3) As SqlParameter

            param(0) = New SqlParameter("@Freqid", txtLabID.Text)
            param(1) = New SqlParameter("@Frequency", txtLabName.Text)
            param(2) = New SqlParameter("@id", Class1.CAreaID)
            Dim dsret As DataSet
            dsret = Class1.ExecQueryDS("mas_Update_MasArea", Class1.CustomCommandType.StoredPorcedure, param)
            If dsret.Tables(0).Rows(0).Item(0) = "1" Then
                MsgBox("Successfully Updated!")
            Else
                MsgBox("Error in Saving!")
            End If
            populateMedType()
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
            If Class1.CAreaID = "-1" Then
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