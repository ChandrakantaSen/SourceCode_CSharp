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
Public Class AddAgentMaster
    Private Sub populatelist()
        Try
            Dim param(1) As SqlParameter
            param(0) = New SqlParameter("@agentid", "")
            param(1) = New SqlParameter("@agentname", "")

            Dim ds As DataSet
            ds = Class1.ExecQueryDS("getAgentmaster", Class1.CustomCommandType.StoredPorcedure, param)
            lstAgent.DataSource = ds.Tables(0)
            lstAgent.ValueMember = "id"
            lstAgent.DisplayMember = "agntname"



        Catch ex As Exception

        End Try
    End Sub
    Private Sub fetchagentdetailsbyagentid()
        Try
            Dim param(0) As SqlParameter
            param(0) = New SqlParameter("agentid", lstAgent.SelectedValue)
            Dim ds As DataSet
            ds = Class1.ExecQueryDS("fetchagentdetailsbyagentid", Class1.CustomCommandType.StoredPorcedure, param)
            ddtitle.SelectedItem = ds.Tables(0).Rows(0).Item("AgntTitle")
            txtagentid.Text = ds.Tables(0).Rows(0).Item("AgntId")
            txtagentname.Text = ds.Tables(0).Rows(0).Item("AgntName")
            txtagentaddress.Text = ds.Tables(0).Rows(0).Item("AgntAddress")
            txtcontactno.Text = ds.Tables(0).Rows(0).Item("AgntTelEmail")
            chkinhouseagent.Checked = ds.Tables(0).Rows(0).Item("Inhouse")
            Class1.CAgentID = lstAgent.SelectedValue

        Catch ex As Exception

        End Try
    End Sub

    Private Sub clearall()
        Try
            ddtitle.SelectedItem = ""
            txtagentid.Text = ""
            txtagentname.Text = ""
            txtagentaddress.Text = ""
            txtcontactno.Text = ""
            chkinhouseagent.Checked = 0
            Class1.CAgentID = "-1"


        Catch ex As Exception

        End Try
    End Sub
    Private Sub AddAgentMaster_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            'If Class1.GetAccess(Class1.cAgentMaster, "ADD", "", Class1.cUserpk) = False Then
            '    MsgBox("No Access Rights!!")
            '    Me.BeginInvoke(New MethodInvoker(AddressOf Me.Close))
            'End If

            populatelist()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Try
            clearall()
            lstAgent.Enabled = False
            btnadd.Enabled = False
        Catch ex As Exception

        End Try
    End Sub
    Private Sub saveagent()
        Try
            Dim param(5) As SqlParameter

            param(0) = New SqlParameter("@AgntId", txtagentid.Text)
            param(1) = New SqlParameter("@AgntName", txtagentname.Text)
            param(2) = New SqlParameter("@AgntTitle", ddtitle.SelectedItem)
            param(3) = New SqlParameter("@AgntAddress", txtagentaddress.Text)
            param(4) = New SqlParameter("@AgntTelEmail", txtcontactno.Text)
            param(5) = New SqlParameter("@Inhouse", chkinhouseagent.Checked)

            Dim dsret As DataSet
            dsret = Class1.ExecQueryDS("mas_insert_agent_master", Class1.CustomCommandType.StoredPorcedure, param)
            If dsret.Tables(0).Rows(0).Item(0) = "1" Then
                MsgBox("Save Successfully!")
            Else
                MsgBox("Error in Saving!")
            End If
            populatelist()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub lstAgent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAgent.SelectedIndexChanged

    End Sub

    Private Sub lstAgent_Click(sender As Object, e As EventArgs) Handles lstAgent.Click
        Try
            fetchagentdetailsbyagentid()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If Class1.CAgentID = "-1" Then
                saveagent()
            Else
                editagent()
            End If
            clearall()
            populatelist()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub editagent()
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
            Else
                MsgBox("Error in Saving!")
            End If

        Catch ex As Exception

        End Try
    End Sub

End Class