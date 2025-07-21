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
Public Class frmRefLab
    Private Sub frmRefLab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'If Class1.GetAccess(Class1.cLabMaster, "ADD", "", Class1.cUserpk) = False Then
            '    MsgBox("No Access Rights!!")
            '    Me.BeginInvoke(New MethodInvoker(AddressOf Me.Close))
            'End If

            populatelist()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub populatelist()
        Try
            Dim param(0) As SqlParameter
            param(0) = New SqlParameter("@Labid", "")
            'param(1) = New SqlParameter("@LabName", "")

            Dim ds As DataSet
            ds = Class1.ExecQueryDS("getRefLabMaster", Class1.CustomCommandType.StoredPorcedure, param)
            lstLabMas.DataSource = ds.Tables(0)
            lstLabMas.ValueMember = "labfk"
            lstLabMas.DisplayMember = "LabName"



        Catch ex As Exception

        End Try
    End Sub
    Private Sub fetchLabdetailsbyid()
        Try
            Dim param(0) As SqlParameter
            param(0) = New SqlParameter("LabId", lstLabMas.SelectedValue)
            Dim ds As DataSet
            ds = Class1.ExecQueryDS("fetchaRefLabdetailsbytid", Class1.CustomCommandType.StoredPorcedure, param)
            txtLabContact.Text = ds.Tables(0).Rows(0).Item("LabContact") & ""
            txtLabID.Text = ds.Tables(0).Rows(0).Item("LabID")
            txtLabName.Text = ds.Tables(0).Rows(0).Item("LabName")
            txtLabAddress.Text = ds.Tables(0).Rows(0).Item("LabAddress") & ""
            txtLabTelEmail.Text = ds.Tables(0).Rows(0).Item("LabTelEmail") & ""
            cmbAgntId.SelectedValue = ds.Tables(0).Rows(0).Item("AgntId") & ""
            Class1.CLabID = lstLabMas.SelectedValue

        Catch ex As Exception

        End Try
    End Sub

    Private Sub clearall()
        Try

            txtLabID.Text = ""
            txtLabName.Text = ""
            txtLabAddress.Text = ""
            txtLabTelEmail.Text = ""

            Class1.CLabID = "-1"


        Catch ex As Exception

        End Try
    End Sub

    Private Sub lstLabMas_Click(sender As Object, e As EventArgs) Handles lstLabMas.Click
        Try
            fetchLabdetailsbyid()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Try
            clearall()
            lstLabMas.Enabled = False
            btnadd.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If Class1.CLabID = "-1" Then
                saveLab()
            Else
                editLab()
            End If
            clearall()
            populatelist()
            btnadd.Enabled = True
            lstLabMas.Enabled = True
        Catch ex As Exception

        End Try
    End Sub
    Private Sub saveLab()
        Try
            Dim param(4) As SqlParameter

            param(0) = New SqlParameter("@LabName", txtLabName.Text)
            param(1) = New SqlParameter("@LabId", txtLabID.Text)
            param(2) = New SqlParameter("@LabContact", txtLabContact.Text)
            param(3) = New SqlParameter("@LabAddress", txtLabAddress.Text)
            param(4) = New SqlParameter("@LabTelEmail", txtLabTelEmail.Text)

            Dim dsret As DataSet
            dsret = Class1.ExecQueryDS("mas_insert_Lab_master", Class1.CustomCommandType.StoredPorcedure, param)
            If dsret.Tables(0).Rows(0).Item(0) = "1" Then
                MsgBox("Save Successfully!")
            Else
                MsgBox("Error in Saving!")
            End If
            populatelist()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub editLab()
        Try
            Dim param(5) As SqlParameter

            param(0) = New SqlParameter("@LabId", txtLabID.Text)
            param(1) = New SqlParameter("@LabName", txtLabName.Text)

            param(3) = New SqlParameter("@LabAddress", txtLabAddress.Text)
            param(4) = New SqlParameter("@LabTelEmail", txtLabTelEmail.Text)
            param(5) = New SqlParameter("@id", Class1.CLabID)
            Dim dsret As DataSet
            dsret = Class1.ExecQueryDS("mas_update_Lab_master", Class1.CustomCommandType.StoredPorcedure, param)
            If dsret.Tables(0).Rows(0).Item(0) = "1" Then
                MsgBox("Successfully Updated!")
            Else
                MsgBox("Error in Saving!")
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class