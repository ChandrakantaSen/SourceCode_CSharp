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
Public Class frmemployee


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
                    node.Checked = True
                    parentnode.Nodes.Add(node)
                    populatetreeview(node, ds.Tables(0).Rows(counter).Item("id"))
                Next

            Else
                Return parentnode.Tag
            End If
        Catch ex As Exception

        End Try
    End Function

    Private Sub frmemployee_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim node As TreeNode
            node = New TreeNode("Mainmenu")

            TreeView1.Nodes.Add(node)
            TreeView1.CheckBoxes = True
            populatetreeview(node, -1)

            For cnt = 0 To TreeView1.Nodes.Count - 1
                MsgBox(TreeView1.Nodes(cnt).Text)
                displaynode(TreeView1.Nodes(cnt))
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Function displaynode(ByVal parentnode As TreeNode) As String
        Try
            If parentnode.Nodes.Count > 0 Then
                For i = 0 To parentnode.Nodes.Count - 1
                    MsgBox(parentnode.Nodes(i).Text)
                    displaynode(parentnode.Nodes(i))
                Next
            Else
                Return ""
            End If
          
        Catch ex As Exception

        End Try
    End Function
End Class