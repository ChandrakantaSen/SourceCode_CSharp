Imports System.Data.SqlClient
Public Class Form2
    Dim recordpointer As Int32
    Dim ds As DataSet
    Dim id As Int32
    Public Function hello()

    End Function


    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub resetcontrols()
        Try
            txtage.Text = 0
            txtname.Text = ""
            txtregno.Text = ""

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            Dim param(2) As SqlParameter
            param(0) = New SqlParameter("@name", txtname.Text)
            param(1) = New SqlParameter("@regno", txtregno.Text)
            param(2) = New SqlParameter("@age", txtage.Text)

            Dim ds As DataSet
            ds = Utility.ExecQueryDS("proc_student", Utility.CustomCommandType.StoredPorcedure, param)
            If ds.Tables(0).Rows(0).Item(0) = "1" Then
                MsgBox("Data Save Successfully!!")
                resetcontrols()


            Else
                MsgBox("Error in Data Saving !!")

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        Try
            Dim param(0) As SqlParameter
            param(0) = New SqlParameter("@name", txtName_S.Text)


            ds = Utility.ExecQueryDS("search_student", Utility.CustomCommandType.StoredPorcedure, param)
            txttotalrecords.Text = 0
            If Not ds Is Nothing Then
                If ds.Tables.Count > 0 And ds.Tables(0).Rows.Count > 0 Then
                    recordpointer = 0
                    txtrecordpointer.Text = 1
                    id = ds.Tables(0).Rows(0).Item("id")
                    txttotalrecords.Text = ds.Tables(0).Rows.Count
                    txtname.Text = ds.Tables(0).Rows(0).Item("name")
                    txtage.Text = ds.Tables(0).Rows(0).Item("age")
                    txtregno.Text = (ds.Tables(0).Rows(0).Item("regno"))

                End If
            End If

        Catch ex As Exception

        End Try
    End Sub



    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            recordpointer = ds.Tables(0).Rows.Count - 1
            id = ds.Tables(0).Rows(recordpointer).Item("id")
            txtname.Text = ds.Tables(0).Rows(recordpointer).Item("name")
            txtage.Text = ds.Tables(0).Rows(recordpointer).Item("age")
            txtregno.Text = (ds.Tables(0).Rows(recordpointer).Item("regno"))

            txtrecordpointer.Text = recordpointer + 1
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If recordpointer = ds.Tables(0).Rows.Count Then Exit Sub
            recordpointer += 1
            id = ds.Tables(0).Rows(recordpointer).Item("id")
            txtname.Text = ds.Tables(0).Rows(recordpointer).Item("name")
            txtage.Text = ds.Tables(0).Rows(recordpointer).Item("age")
            txtregno.Text = (ds.Tables(0).Rows(recordpointer).Item("regno"))

            txtrecordpointer.Text = recordpointer + 1
        Catch ex As Exception

        End Try
    End Sub



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            If recordpointer = 0 Then Exit Sub
            If recordpointer = ds.Tables(0).Rows.Count Then
                recordpointer -= 2
            Else
                recordpointer -= 1
            End If
            id = ds.Tables(0).Rows(recordpointer).Item("id")
            txtname.Text = ds.Tables(0).Rows(recordpointer).Item("name")
            txtage.Text = ds.Tables(0).Rows(recordpointer).Item("age")
            txtregno.Text = (ds.Tables(0).Rows(recordpointer).Item("regno"))

            txtrecordpointer.Text = recordpointer + 1
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            recordpointer = 0
            id = ds.Tables(0).Rows(recordpointer).Item("id")
            txtname.Text = ds.Tables(0).Rows(recordpointer).Item("name")
            txtage.Text = ds.Tables(0).Rows(recordpointer).Item("age")
            txtregno.Text = (ds.Tables(0).Rows(recordpointer).Item("regno"))

            txtrecordpointer.Text = recordpointer + 1
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninsert.Click
        Try
            txtname.Text = ""
            txtage.Text = ""
            txtregno.Text = ""
            btnupdate.Enabled = False
            btndelete.Enabled = False

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Try
            Dim param(3) As SqlParameter
            param(0) = New SqlParameter("@name", txtname.Text)
            param(1) = New SqlParameter("@regno", txtregno.Text)
            param(2) = New SqlParameter("@age", txtage.Text)
            param(3) = New SqlParameter("@id", id)
            Dim ds As DataSet
            ds = Utility.ExecQueryDS("update_tbl_student", Utility.CustomCommandType.StoredPorcedure, param)
            If ds.Tables(0).Rows(0).Item(0) = "1" Then
                MsgBox("Data Updated Successfully!!")
                resetcontrols()


            Else
                MsgBox("Error in Data Updating !!")

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            Dim param(0) As SqlParameter
            param(0) = New SqlParameter("id", id)
            Dim ds As DataSet
            ds = Utility.ExecQueryDS("delete_tbl_student", Utility.CustomCommandType.StoredPorcedure, param)
            If ds.Tables(0).Rows(0).Item(0) = "1" Then
                MsgBox("Data deleted Successfully!!")
                resetcontrols()


            Else
                MsgBox("Error in Data deletion !!")

            End If

        Catch ex As Exception

        End Try
    End Sub
End Class