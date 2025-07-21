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
Public Class Usersecurity_FormLevel

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
    Private Function populatetreeview(ByRef parentnode As TreeNode, ByRef parentid As Integer) As Integer
        Try
            Dim node As TreeNode
            Dim counter As Integer = 0
            Dim str As String = ""
            str = "Select id,menu_id,menu_name,parent_id from tbl_menu where parent_id=" & parentid
            Dim ds As DataSet
            ds = Class1.ExecQueryDS(str, Class1.CustomCommandType.SQTString, Nothing)

            If ds.Tables(0).Rows.Count > 0 Then
                For counter = 0 To ds.Tables(0).Rows.Count - 1
                    node = New TreeNode(ds.Tables(0).Rows(counter).Item("menu_name"))
                    node.Tag = ds.Tables(0).Rows(counter).Item("id")
                    'node.Checked = True
                    parentnode.Nodes.Add(node)
                    populatetreeview(node, ds.Tables(0).Rows(counter).Item("id"))
                Next

            Else
                Return parentnode.Tag
            End If
        Catch ex As Exception

        End Try
    End Function
    Private Function displaynode(ByVal parentnode As TreeNode) As String
        Try
            If parentnode.Nodes.Count > 0 Then
                For i = 0 To parentnode.Nodes.Count - 1
                    parentnode.Checked = False
                    If idexist(parentnode.Tag) = 1 Then
                        parentnode.Checked = True
                    End If
                    displaynode(parentnode.Nodes(i))
                Next
            Else
                parentnode.Checked = False
                If idexist(parentnode.Tag) = 1 Then
                    parentnode.Checked = True
                End If
                Return ""
            End If

        Catch ex As Exception

        End Try
    End Function
    Private Function idexist(ByVal id As String) As Integer
        Dim ret As Int16
        Try
            Dim param(1) As SqlParameter
            param(0) = New SqlParameter("menu_id", id)
            param(1) = New SqlParameter("user_id", dduser.SelectedValue.ToString())
            Dim ds As DataSet
            ds = Class1.ExecQueryDS("sp_check_menu_exists", Class1.CustomCommandType.StoredPorcedure, param)
            ret = CInt(ds.Tables(0).Rows(0).Item(0))

        Catch ex As Exception
            ret = 0
        End Try
        Return ret
    End Function
    Private Sub Usersecurity_FormLevel_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            fetchalluser()
            Dim node As TreeNode
            node = New TreeNode("Mainmenu")
            tview.Nodes.Clear()
            tview.Nodes.Add(node)

            tview.CheckBoxes = True
            populatetreeview(node, -1)

            For cnt = 0 To tview.Nodes.Count - 1
                displaynode(tview.Nodes(cnt))
            Next
            tview.ExpandAll()

        Catch ex As Exception

        End Try
    End Sub
    Private Function SaveTree(ByVal parentnode As TreeNode) As String
        Try
            If parentnode.Nodes.Count > 0 Then
                For i = 0 To parentnode.Nodes.Count - 1
                    'If idexist(parentnode.Tag) = 1 Then
                    '    parentnode.Checked = True
                    'End If
                    Dim flag As Int16 = 0
                    If parentnode.Checked Then
                        flag = 1
                    End If
                    SaveTreeNode(parentnode.Tag, flag)
                    SaveTree(parentnode.Nodes(i))
                Next
            Else
                'If idexist(parentnode.Tag) = 1 Then
                '    parentnode.Checked = True
                'End If
                Dim flag As Int16 = 0
                If parentnode.Checked Then
                    flag = 1
                End If
                SaveTreeNode(parentnode.Tag, flag)
                Return ""
            End If

        Catch ex As Exception

        End Try
    End Function
    Private Sub SaveTreeNode(ByVal id As String, ByVal flag As Int16)
        Dim ret As Int16 = 0
        Try
            Dim param(2) As SqlParameter
            param(0) = New SqlParameter("menu_id", id)
            param(1) = New SqlParameter("user_id", dduser.SelectedValue.ToString())
            param(2) = New SqlParameter("flag", flag)
            Dim ds As DataSet
            ds = Class1.ExecQueryDS("sp_save_usersecurity", Class1.CustomCommandType.StoredPorcedure, param)
            'ret = CInt(ds.Tables(0).Rows(0).Item(0))

        Catch ex As Exception
            'ret = 0
        End Try

    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            For cnt = 0 To tview.Nodes.Count - 1
                SaveTree(tview.Nodes(cnt))
            Next
            MsgBox("Data Save Successfully!!")
        Catch ex As Exception

        End Try
    End Sub

 
    Private Sub dduser_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dduser.SelectedIndexChanged
        Try
            For cnt = 0 To tview.Nodes.Count - 1
                displaynode(tview.Nodes(cnt))
            Next
        Catch ex As Exception

        End Try
    End Sub
End Class