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
Public Class searchAgentMaster


    Private Sub searchAgentMaster_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Class1.GetAccess(Class1.cAgentMaster, "VIEW", "", Class1.cUserpk) = False Then
                MsgBox("No Access Rights!!")
                Me.BeginInvoke(New MethodInvoker(AddressOf Me.Close))
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgagent.CellContentClick
        Try
            'MsgBox(e.ColumnIndex)
            'MsgBox(dgagent.Rows(e.RowIndex).Cells(0).Value.ToString())
            If e.ColumnIndex = 6 Then
                If Class1.GetAccess(Class1.cAgentMaster, "Edit", "", Class1.cUserpk) = False Then
                    MsgBox("No Edit Rights!!")
                Else
                    Class1.CAgentID = CInt(dgagent.Rows(e.RowIndex).Cells(0).Value)
                    Dim frm As New EditAgentMaster()
                    frm.Show()
                    frm.MdiParent = Me.MdiParent
                    Me.Close()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub searchAgent()
        Try
            Dim param(1) As SqlParameter
            param(0) = New SqlParameter("@agentid", txtagentid.Text)
            param(1) = New SqlParameter("@agentname", txtagentname.Text)

            Dim ds As DataSet
            ds = Class1.ExecQueryDS("getAgentmaster", Class1.CustomCommandType.StoredPorcedure, param)

            dgagent.DataSource = Nothing
            If Not ds Is Nothing Then
                If ds.Tables.Count > 0 And ds.Tables(0).Rows.Count > 0 Then
                    dgagent.DataSource = ds.Tables(0)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        Try
            searchAgent()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgagent_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgagent.DataBindingComplete
        'Try
        '    Dim height As Int32 = 25
        '    dgagent.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue
        '    dgagent.EnableHeadersVisualStyles = False
        '    dgagent.Font = New Font("Microsoft Sans Serif", 10)
        '    For i = 0 To dgagent.Rows.Count - 1
        '        Dim dgrow As DataGridViewRow
        '        dgrow = dgagent.Rows(i)

        '        dgrow.DefaultCellStyle.BackColor = Color.LightSkyBlue
        '        dgrow.Height = 25
        '        height = height + 25
        '    Next
        '    dgagent.Height = height
        'Catch ex As Exception

        'End Try
    End Sub
End Class