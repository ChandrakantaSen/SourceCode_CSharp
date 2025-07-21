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
Public Class frmMedPatMas


    Private Sub frmMedPatMas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populatedosage()
        populateCmb()
    End Sub

    Private Sub populatedosage()
        Try
            Dim dsd As DataSet
            ' Dim param(0) As SqlParameter
            'param(0) = New SqlParameter("@countryid", ddcountry.SelectedValue)

            dsd = Class1.ExecQueryDS("MedPatMasPt", Class1.CustomCommandType.StoredPorcedure)
            lstMedPat.DataSource = dsd.Tables(0)
            lstMedPat.DisplayMember = "PNam"
            lstMedPat.ValueMember = "ID"
        Catch ex As Exception

        End Try
    End Sub
    Private Sub populateCmb()
        Try
            Dim dsTypeId As DataSet
            Dim dsMedGenName As DataSet
            Dim dsdosId As DataSet
            Dim dsManufac As DataSet
            Dim dsMedGrp As DataSet

            dsTypeId = Class1.ExecQueryDS("FetchMedType", Class1.CustomCommandType.StoredPorcedure)
            cmbTypeid.DataSource = dsTypeId.Tables(0)
            cmbTypeid.DisplayMember = "TypeName"
            cmbTypeid.ValueMember = "Typeid"

            dsMedGenName = Class1.ExecQueryDS("MedGenMasAll", Class1.CustomCommandType.StoredPorcedure)
            cmbMedGenId.DataSource = dsMedGenName.Tables(0)
            cmbMedGenId.DisplayMember = "MedGenName"
            cmbMedGenId.ValueMember = "MedGenId"

            dsManufac = Class1.ExecQueryDS("FetchManufac", Class1.CustomCommandType.StoredPorcedure)
            cmbManufacId.DataSource = dsManufac.Tables(0)
            cmbManufacId.DisplayMember = "ManufacName"
            cmbManufacId.ValueMember = "ManufacId"

            dsdosId = Class1.ExecQueryDS("MedDosTypeMas", Class1.CustomCommandType.StoredPorcedure)
            cmbDosId.DataSource = dsdosId.Tables(0)
            cmbDosId.DisplayMember = "DosType"
            cmbDosId.ValueMember = "DosID"

            dsMedGrp = Class1.ExecQueryDS("MedGrpMas", Class1.CustomCommandType.StoredPorcedure)
            cmbMedGrpId.DataSource = dsMedGrp.Tables(0)
            cmbMedGrpId.DisplayMember = "MedGrp"
            cmbMedGrpId.ValueMember = "MedGrpId"
        Catch ex As Exception

        End Try
    End Sub
    Private Sub fetchagentdetailsbyagentid()
        Try
            Dim param(0) As SqlParameter
            param(0) = New SqlParameter("id", lstMedPat.SelectedValue)
            Dim ds As DataSet
            ds = Class1.ExecQueryDS("fetchMedPatMasbyId", Class1.CustomCommandType.StoredPorcedure, param)
            txtMedPatId.Text = ds.Tables(0).Rows(0).Item("MedPatId")
            txtPatName.Text = ds.Tables(0).Rows(0).Item("PatName")

            cmbDosId.SelectedValue = ds.Tables(0).Rows(0).Item(“DosId")
            cmbMedGenId.SelectedValue = ds.Tables(0).Rows(0).Item(“MedGenId")
            cmbTypeid.SelectedValue = ds.Tables(0).Rows(0).Item(“TypeId")
            cmbManufacId.SelectedValue = ds.Tables(0).Rows(0).Item(“ManufacId")
            txtManufacInfo.Text = ds.Tables(0).Rows(0).Item(“ManufacInfo") & ""


            Class1.CMedPatId = lstMedPat.SelectedValue

        Catch ex As Exception

        End Try
    End Sub

    Private Sub clearall()
        Try
            txtMedPatId.Text = ""
            txtPatName.Text = ""
            txtManufacInfo.Text = ""
            Class1.CMedPatId = "-1"

        Catch ex As Exception

        End Try
    End Sub
    Private Sub saveagent()
        Try
            Dim param(7) As SqlParameter

            param(0) = New SqlParameter("@MedPatId", txtMedPatId.Text)
            param(1) = New SqlParameter("@PatName", txtPatName.Text)
            param(2) = New SqlParameter("@MedGrpId", cmbMedGrpId.SelectedValue)
            param(3) = New SqlParameter("@MedGenId", cmbMedGenId.SelectedValue)
            param(4) = New SqlParameter("@TypeId", cmbTypeid.SelectedValue)
            param(5) = New SqlParameter("@ManufacId", cmbManufacId.SelectedValue)
            param(6) = New SqlParameter("@ManufacInfo", txtManufacInfo.Text)
            param(7) = New SqlParameter("@DosId", cmbDosId.SelectedValue)

            Dim dsret As DataSet
            dsret = Class1.ExecQueryDS("insert_MedPatMas", Class1.CustomCommandType.StoredPorcedure, param)
            If dsret.Tables(0).Rows(0).Item(0) = "1" Then
                MsgBox("Successfully Updated!")
                Me.Close()
            Else
                MsgBox("Error in Saving!")
            End If

            populatedosage()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub editagent()
        Try
            Dim param(8) As SqlParameter

            param(0) = New SqlParameter("@MedPatId", txtMedPatId.Text)
            param(1) = New SqlParameter("@PatName", txtPatName.Text)
            param(2) = New SqlParameter("@MedGrpId", cmbMedGrpId.SelectedValue)
            param(3) = New SqlParameter("@MedGenId", cmbMedGenId.SelectedValue)
            param(4) = New SqlParameter("@TypeId", cmbTypeid.SelectedValue)
            param(5) = New SqlParameter("@ManufacId", cmbManufacId.SelectedValue)
            param(6) = New SqlParameter("@ManufacInfo", txtManufacInfo.Text)
            param(7) = New SqlParameter("@DosId", cmbDosId.SelectedValue)
            param(8) = New SqlParameter("@Id", Class1.CMedPatId)

            Dim dsret As DataSet
            dsret = Class1.ExecQueryDS("Update_MedPatMas", Class1.CustomCommandType.StoredPorcedure, param)
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
            lstMedPat.Enabled = False
            btnexit.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If Class1.CMedPatId = "-1" Then
                saveagent()
            Else
                editagent()
            End If
            clearall()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lstMedPat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstMedPat.Click
        Try
            fetchagentdetailsbyagentid()
        Catch ex As Exception

        End Try
    End Sub
End Class