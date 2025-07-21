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
Public Class EditAgentMaster
    Private Sub fetchagentdetailsbyagentid()
        Try
            Dim param(0) As SqlParameter
            param(0) = New SqlParameter("agentid", Class1.CAgentID)
            Dim ds As DataSet
            ds = Class1.ExecQueryDS("fetchagentdetailsbyagentid", Class1.CustomCommandType.StoredPorcedure, param)
            ddtitle.SelectedItem = ds.Tables(0).Rows(0).Item("AgntTitle")
            txtagentid.Text = ds.Tables(0).Rows(0).Item("AgntId")
            txtagentname.Text = ds.Tables(0).Rows(0).Item("AgntName")
            txtagentaddress.Text = ds.Tables(0).Rows(0).Item("AgntAddress")
            txtcontactno.Text = ds.Tables(0).Rows(0).Item("AgntTelEmail")
            chkinhouseagent.Checked = ds.Tables(0).Rows(0).Item("Inhouse")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub AddAgentMaster_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Class1.GetAccess(Class1.cAgentMaster, "Edit", "", Class1.cUserpk) = False Then
                MsgBox("No Access Rights!!")
                Me.BeginInvoke(New MethodInvoker(AddressOf Me.Close))
            End If

            fetchagentdetailsbyagentid()
        Catch ex As Exception

        End Try
    End Sub

 

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Try
            Dim param(6) As SqlParameter

            param(0) = New SqlParameter("@AgntId", txtagentid.Text)
            param(1) = New SqlParameter("@AgntName", txtagentname.Text)
            param(2) = New SqlParameter("@AgntTitle", ddtitle.SelectedItem)
            param(3) = New SqlParameter("@AgntAddress", txtagentaddress.Text)
            param(4) = New SqlParameter("@AgntTelEmail", txtcontactno.Text)
            param(5) = New SqlParameter("@Inhouse", chkinhouseagent.Checked)
            param(6) = New SqlParameter("@id", Class1.CAgentID)
            Dim dsret As DataSet
            dsret = Class1.ExecQueryDS("mas_update_agent_master", Class1.CustomCommandType.StoredPorcedure, param)
            If dsret.Tables(0).Rows(0).Item(0) = "1" Then
                MsgBox("Successfully Updated!")
                Me.Close()
            Else
                MsgBox("Error in Saving!")
            End If

        Catch ex As Exception

        End Try
    End Sub

   
    Private Sub btnexit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Try
            Me.Close()

        Catch ex As Exception

        End Try
    End Sub
End Class