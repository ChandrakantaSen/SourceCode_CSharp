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
Public Class userSecurity_FormEvent
    Private Sub fetchalluser()
        Try
            Dim ds As DataSet
            ds = Class1.ExecQueryDS("sp_get_all_user", Class1.CustomCommandType.StoredPorcedure, Nothing)
            If Not ds Is Nothing Then
                If ds.Tables.Count > 0 And ds.Tables(0).Rows.Count > 0 Then
                    dduser.DataSource = ds.Tables(0)
                    ''cboNme.Items.Insert(0, "Select")

                    'cboNme.Items.Insert(i + 1, ds.Tables(0).Rows(i).Item(1))
                    dduser.DisplayMember = "user_name"
                    dduser.ValueMember = "id"
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub populatesecuritygrid()
        Try
            Dim ds As DataSet
            Dim param(0) As SqlParameter
            param(0) = New SqlParameter("@userfk", dduser.SelectedValue)

            ds = Class1.ExecQueryDS("sp_util_formlevel_event_security", Class1.CustomCommandType.StoredPorcedure, param)
            gvmenu.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub userSecurity_FormEvent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Class1.GetAccess(Class1.cUserSecurityFormLevel, "ADD", "", Class1.cUserpk) = False Then
                MsgBox("No Access Rights!!")
                Me.BeginInvoke(New MethodInvoker(AddressOf Me.Close))
            End If
            fetchalluser()
            populatesecuritygrid()
          

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnsave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            Dim dt As New DataTable
            dt.Columns.Add("user_pk")
            dt.Columns.Add("menu_id")
            dt.Columns.Add("add_val")
            dt.Columns.Add("edit_val")
            dt.Columns.Add("delete_val")
            dt.Columns.Add("view_val")
            dt.AcceptChanges()
            Dim dr As DataRow
            For i = 0 To gvmenu.Rows.Count - 1
                Dim dgrow As DataGridViewRow
                dgrow = gvmenu.Rows(i)
                dr = dt.NewRow()
                dr("user_pk") = dduser.SelectedValue
                dr("menu_id") = dgrow.Cells("menuid").Value
                dr("add_val") = dgrow.Cells("Addition").Value
                'MsgBox(dgrow.Cells("Addition").Value)
                dr("edit_val") = dgrow.Cells("edit").Value
                dr("delete_val") = dgrow.Cells("delete").Value
                dr("view_val") = dgrow.Cells("view").Value
                dt.Rows.Add(dr)
            Next
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim param(0) As SqlParameter
            param(0) = New SqlParameter("@Xml", ds.GetXml())
            Dim dsret As DataSet
            dsret = Class1.ExecQueryDS("sp_Insert_PageSecurity", Class1.CustomCommandType.StoredPorcedure, param)

            MsgBox("Save Successfully!!")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dduser_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dduser.SelectedIndexChanged
        Try
            populatesecuritygrid()
        Catch ex As Exception

        End Try
    End Sub

   

    Private Sub gvmenu_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles gvmenu.DataBindingComplete
        Try
            Dim height As Int32 = 25
            gvmenu.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue
            gvmenu.EnableHeadersVisualStyles = False
            gvmenu.Font = New Font("Microsoft Sans Serif", 10)
            For i = 0 To gvmenu.Rows.Count - 1
                Dim dgrow As DataGridViewRow
                dgrow = gvmenu.Rows(i)

                dgrow.DefaultCellStyle.BackColor = Color.LightSkyBlue
                dgrow.Height = 25
                height = height + 25
            Next
            gvmenu.Height = height
        Catch ex As Exception

        End Try
    End Sub

 
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class