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
Public Class frmPhysicianMaster
    Private Sub frmPhysicianMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'If Class1.GetAccess(Class1.cPhysMaster, "ADD", "", Class1.cUserpk) = False Then
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
            Dim param(1) As SqlParameter
            param(0) = New SqlParameter("@Physid", "")
            param(1) = New SqlParameter("@PhysName", "")

            Dim ds As DataSet
            ds = Class1.ExecQueryDS("getphysmaster", Class1.CustomCommandType.StoredPorcedure, param)
            lstPhyMas.DataSource = ds.Tables(0)
            lstPhyMas.ValueMember = "id"
            lstPhyMas.DisplayMember = "PhysName"



        Catch ex As Exception

        End Try
    End Sub
    Private Sub fetchPhysdetailsbyid()
        Try
            Dim param(0) As SqlParameter
            param(0) = New SqlParameter("id", lstPhyMas.SelectedValue)
            Dim ds As DataSet
            ds = Class1.ExecQueryDS("fetchPhysdetailsbyid", Class1.CustomCommandType.StoredPorcedure, param)
            ddtitle.SelectedItem = ds.Tables(0).Rows(0).Item("PhysTitle") & ""
            txtPhysID.Text = ds.Tables(0).Rows(0).Item("PhysID")
            txtPhysName.Text = ds.Tables(0).Rows(0).Item("PhysName")
            txtPhysAddress.Text = ds.Tables(0).Rows(0).Item("PhysAddress") & ""
            txtPhysTelEmail.Text = ds.Tables(0).Rows(0).Item("PhysTelEmail") & ""

            Class1.CPhysID = lstPhyMas.SelectedValue

        Catch ex As Exception

        End Try
    End Sub

    Private Sub clearall()
        Try
            ddtitle.SelectedItem = ""
            txtPhysID.Text = ""
            txtPhysName.Text = ""
            txtPhysAddress.Text = ""
            txtPhysTelEmail.Text = ""

            Class1.CPhysID = "-1"


        Catch ex As Exception

        End Try
    End Sub

    Private Sub lstPhyMas_Click(sender As Object, e As EventArgs) Handles lstPhyMas.Click
        Try
            fetchPhysdetailsbyid()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Try
            clearall()
            lstPhyMas.Enabled = False
            btnadd.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If Class1.CPhysID = "-1" Then
                savePhys()
            Else
                editPhys()
            End If
            clearall()
            populatelist()
            btnadd.Enabled = True
            lstPhyMas.Enabled = True
        Catch ex As Exception

        End Try
    End Sub
    Private Sub savePhys()
        Try
            Dim param(4) As SqlParameter

            param(0) = New SqlParameter("@PhysName", txtPhysName.Text)
            param(1) = New SqlParameter("@PhysId", txtPhysID.Text)
            param(2) = New SqlParameter("@PhysTitle", ddtitle.SelectedItem)
            param(3) = New SqlParameter("@PhysAddress", txtPhysAddress.Text)
            param(4) = New SqlParameter("@PhysTelEmail", txtPhysTelEmail.Text)

            Dim dsret As DataSet
            dsret = Class1.ExecQueryDS("mas_insert_Phys_master", Class1.CustomCommandType.StoredPorcedure, param)
            If dsret.Tables(0).Rows(0).Item(0) = "1" Then
                MsgBox("Save Successfully!")
            Else
                MsgBox("Error in Saving!")
            End If
            populatelist()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub editPhys()
        Try
            Dim param(5) As SqlParameter

            param(0) = New SqlParameter("@PhysId", txtPhysID.Text)
            param(1) = New SqlParameter("@PhysName", txtPhysName.Text)
            param(2) = New SqlParameter("@PhysTitle", ddtitle.SelectedItem)
            param(3) = New SqlParameter("@PhysAddress", txtPhysAddress.Text)
            param(4) = New SqlParameter("@PhysTelEmail", txtPhysTelEmail.Text)
            param(5) = New SqlParameter("@id", Class1.CPhysID)
            Dim dsret As DataSet
            dsret = Class1.ExecQueryDS("mas_update_Phys_master", Class1.CustomCommandType.StoredPorcedure, param)
            If dsret.Tables(0).Rows(0).Item(0) = "1" Then
                MsgBox("Successfully Updated!")
            Else
                MsgBox("Error in Saving!")
            End If

        Catch ex As Exception

        End Try
    End Sub

End Class