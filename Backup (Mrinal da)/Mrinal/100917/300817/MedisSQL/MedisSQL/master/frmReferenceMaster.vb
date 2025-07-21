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
Public Class frmReferenceMaster
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub populatelist()
        Try
            Dim param(1) As SqlParameter
            param(0) = New SqlParameter("@Refid", "")
            param(1) = New SqlParameter("@RefName", "")

            Dim ds As DataSet
            ds = Class1.ExecQueryDS("getReferenceMaster", Class1.CustomCommandType.StoredPorcedure, param)
            lstRefMas.DataSource = ds.Tables(0)
            lstRefMas.ValueMember = "id"
            lstRefMas.DisplayMember = "RefName"

            populatedistrict()
            populateAgent()
            populateArea()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub populatedistrict()
        Try
            Dim ds As DataSet
            Dim param(1) As SqlParameter

            param(0) = New SqlParameter("@id", "")
            param(1) = New SqlParameter("@DistNam", "")
            ds = Class1.ExecQueryDS("getdistrict", Class1.CustomCommandType.StoredPorcedure, param)
            cmbDistID.DataSource = ds.Tables(0)
            cmbDistID.DisplayMember = "DistNam"
            cmbDistID.ValueMember = "id"
        Catch ex As Exception

        End Try
    End Sub
    Private Sub populateAgent()
        Try
            Dim ds As DataSet
            Dim param(1) As SqlParameter
            param(0) = New SqlParameter("@agentid", "")
            param(1) = New SqlParameter("@agentname", "")
            ds = Class1.ExecQueryDS("getAgentmaster", Class1.CustomCommandType.StoredPorcedure, param)
            cmbAgntId.DataSource = ds.Tables(0)
            cmbAgntId.ValueMember = "id"
            cmbAgntId.DisplayMember = "agntname"
        Catch ex As Exception

        End Try
    End Sub
    Private Sub populateArea()
        Try
            Dim param(1) As SqlParameter
            param(0) = New SqlParameter("@areacode", "")
            param(1) = New SqlParameter("@areaname", "")

            Dim ds As DataSet
            ds = Class1.ExecQueryDS("SearchArea", Class1.CustomCommandType.StoredPorcedure, param)
            cmbAreaCode.DataSource = ds.Tables(0)
            cmbAreaCode.ValueMember = "areaid"
            cmbAreaCode.DisplayMember = "areaname"

        Catch ex As Exception

        End Try
    End Sub

    Private Sub fetchRefdetailsbyid()
        Try
            Dim param(0) As SqlParameter
            param(0) = New SqlParameter("refid", lstRefMas.SelectedValue)
            Dim ds As DataSet
            ds = Class1.ExecQueryDS("fetchaReferencedetailsbytid", Class1.CustomCommandType.StoredPorcedure, param)
            ddtitle.SelectedItem = ds.Tables(0).Rows(0).Item("RefTitle") & ""
            txtRefId.Text = ds.Tables(0).Rows(0).Item("RefID")
            txtRefName.Text = ds.Tables(0).Rows(0).Item("RefName")
            txtRefAddress.Text = ds.Tables(0).Rows(0).Item("RefAddress") & ""
            txtPh1.Text = ds.Tables(0).Rows(0).Item("Ph1") & ""
            cmbAreaCode.SelectedValue = ds.Tables(0).Rows(0).Item("AreaCode")
            cmbDistID.SelectedValue = ds.Tables(0).Rows(0).Item("DistID")
            txtPIN.Text = ds.Tables(0).Rows(0).Item("Pin") & ""
            txtEmail.Text = ds.Tables(0).Rows(0).Item("email") & ""
            cmbAgntId.SelectedValue = ds.Tables(0).Rows(0).Item("agntid")
            chkinhouseDoc.Checked = ds.Tables(0).Rows(0).Item("Inhouse")
            Class1.CRefID = lstRefMas.SelectedValue

        Catch ex As Exception

        End Try
    End Sub

    Private Sub clearall()
        Try
            ddtitle.SelectedItem = ""
            txtRefId.Text = ""
            txtRefName.Text = ""
            txtRefAddress.Text = ""
            txtPh1.Text = ""
            cmbAreaCode.SelectedValue = ""
            cmbDistID.SelectedValue = ""
            txtPIN.Text = ""
            txtEmail.Text = ""
            cmbAgntId.SelectedValue = ""
            chkinhouseDoc.Checked = False
            Class1.CRefID = "-1"


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Try
            clearall()
            lstRefMas.Enabled = False
            btnadd.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If Class1.CRefID = "-1" Then
                saveRef()
            Else
                editRef()
            End If
            clearall()
            populatelist()
            btnadd.Enabled = True
            lstRefMas.Enabled = True
        Catch ex As Exception

        End Try
    End Sub
    Private Sub saveRef()
        Try
            Dim param(4) As SqlParameter

            param(0) = New SqlParameter("@AreaCode", cmbAreaCode.SelectedValue)
            param(0) = New SqlParameter("@RefName", txtRefName.Text)
            param(1) = New SqlParameter("@RefId", txtRefId.Text)
            param(2) = New SqlParameter("@RefTitle", ddtitle.SelectedItem)
            param(3) = New SqlParameter("@RefAddress", txtRefAddress.Text)
            param(4) = New SqlParameter("@DistID", cmbDistID.SelectedValue)
            param(5) = New SqlParameter("@pin", txtPIN.Text)
            param(6) = New SqlParameter("@REmail", txtEmail.Text)
            param(7) = New SqlParameter("@Ph1", txtPh1.Text)
            param(8) = New SqlParameter("@AgntId", cmbAgntId.SelectedValue)
            param(9) = New SqlParameter("@Inhouse", chkinhouseDoc.Text)


            Dim dsret As DataSet
            dsret = Class1.ExecQueryDS("mas_insert_Ref_master", Class1.CustomCommandType.StoredPorcedure, param)
            If dsret.Tables(0).Rows(0).Item(0) = "1" Then
                MsgBox("Save Successfully!")
            Else
                MsgBox("Error in Saving!")
            End If
            populatelist()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub editRef()
        Try
            Dim param(5) As SqlParameter

            param(0) = New SqlParameter("@AreaCode", cmbAreaCode.SelectedValue)
            param(0) = New SqlParameter("@RefName", txtRefName.Text)
            param(1) = New SqlParameter("@RefId", txtRefId.Text)
            param(2) = New SqlParameter("@RefTitle", ddtitle.SelectedItem)
            param(3) = New SqlParameter("@RefAddress", txtRefAddress.Text)
            param(4) = New SqlParameter("@DistID", cmbDistID.SelectedValue)
            param(5) = New SqlParameter("@pin", txtPIN.Text)
            param(6) = New SqlParameter("@REmail", txtEmail.Text)
            param(7) = New SqlParameter("@Ph1", txtPh1.Text)
            param(8) = New SqlParameter("@AgntId", cmbAgntId.SelectedValue)
            param(9) = New SqlParameter("@Inhouse", chkinhouseDoc.Text)
            param(5) = New SqlParameter("@id", Class1.CRefID)
            Dim dsret As DataSet
            dsret = Class1.ExecQueryDS("mas_update_Ref_master", Class1.CustomCommandType.StoredPorcedure, param)
            If dsret.Tables(0).Rows(0).Item(0) = "1" Then
                MsgBox("Successfully Updated!")
            Else
                MsgBox("Error in Saving!")
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub lstRefMas_Click(sender As Object, e As EventArgs) Handles lstRefMas.Click
        Try
            fetchRefdetailsbyid()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmReferenceMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'If Class1.GetAccess(Class1.cRefMaster, "ADD", "", Class1.cUserpk) = False Then
            '    MsgBox("No Access Rights!!")
            '    Me.BeginInvoke(New MethodInvoker(AddressOf Me.Close))
            'End If

            populatelist()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class