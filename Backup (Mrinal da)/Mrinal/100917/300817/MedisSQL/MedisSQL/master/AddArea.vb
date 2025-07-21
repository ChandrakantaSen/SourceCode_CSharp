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
Public Class AddArea


    Private Sub save()
        Try
            Dim param(1) As SqlParameter

            param(0) = New SqlParameter("@AreaCode", txtcode.Text)
            param(1) = New SqlParameter("@AreaName", txtname.Text)
           
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

    Private Sub populatelist()
        Try
            Dim param(1) As SqlParameter
            param(0) = New SqlParameter("@areacode", "")
            param(1) = New SqlParameter("@areaname", "")

            Dim ds As DataSet
            ds = Class1.ExecQueryDS("SearchArea", Class1.CustomCommandType.StoredPorcedure, param)
            lstArea.DataSource = ds.Tables(0)
            lstArea.ValueMember = "id"
            lstArea.DisplayMember = "areaname"



        Catch ex As Exception

        End Try
    End Sub
    Private Sub fetchagentdetailsbyagentid()
        Try
            Dim param(0) As SqlParameter
            param(0) = New SqlParameter("id", lstArea.SelectedValue)
            Dim ds As DataSet
            ds = Class1.ExecQueryDS("fetchAreadetailsbyid", Class1.CustomCommandType.StoredPorcedure, param)
            txtcode.Text = ds.Tables(0).Rows(0).Item("areacode")
            txtname.Text = ds.Tables(0).Rows(0).Item("areaname")
            Class1.CAreaID = lstArea.SelectedValue

        Catch ex As Exception

        End Try
    End Sub

    Private Sub clearall()
        Try
            txtcode.Text = ""
            txtname.Text = ""
            Class1.CAreaID = "-1"

        Catch ex As Exception

        End Try
    End Sub
    Private Sub saveagent()
        Try
            Dim param(1) As SqlParameter

            param(0) = New SqlParameter("@areacode", txtcode.Text)
            param(1) = New SqlParameter("@areaname", txtname.Text)

            Dim dsret As DataSet
            dsret = Class1.ExecQueryDS("mas_insert_MasArea", Class1.CustomCommandType.StoredPorcedure, param)
            If dsret.Tables(0).Rows(0).Item(0) = "1" Then
                MsgBox("Save Successfully!")
            Else
                MsgBox("Error in Saving!")
            End If
            populatelist()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub editagent()
        Try
            Dim param(3) As SqlParameter

            param(0) = New SqlParameter("@areacode", txtcode.Text)
            param(1) = New SqlParameter("@areaname", txtname.Text)
            param(2) = New SqlParameter("@id", Class1.CAreaID)
            Dim dsret As DataSet
            dsret = Class1.ExecQueryDS("mas_Update_MasArea", Class1.CustomCommandType.StoredPorcedure, param)
            If dsret.Tables(0).Rows(0).Item(0) = "1" Then
                MsgBox("Successfully Updated!")
            Else
                MsgBox("Error in Saving!")
            End If
            populatelist()
            clearall()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub AddArea_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            'If Class1.GetAccess(Class1.CAreaMaster, "Add", "", Class1.cUserpk) = False Then
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

    Private Sub lstArea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstArea.SelectedIndexChanged

    End Sub

    Private Sub lstArea_Click(sender As Object, e As EventArgs) Handles lstArea.Click
        Try
            fetchagentdetailsbyagentid()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnadd_Click_1(sender As Object, e As EventArgs) Handles btnadd.Click
        Try
            clearall()
            lstArea.Enabled = False
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
End Class