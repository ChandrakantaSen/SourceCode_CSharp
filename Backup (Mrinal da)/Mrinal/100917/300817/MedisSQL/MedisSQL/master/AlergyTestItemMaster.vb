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
Public Class AlergyTestItemMaster
    Dim alid As String = ""
    Private Sub FetchAllAlItem()
        Try
            Dim ds As DataSet
            Dim param(0) As SqlParameter
            param(0) = New SqlParameter("searchitemname", txtsearchitemname.Text)

            ds = Class1.ExecQueryDS("FetchAllAlItem", Class1.CustomCommandType.StoredPorcedure, param)
            Me.lstallergyitem.Items.Clear()
            If Not ds Is Nothing Then
                If ds.Tables.Count > 0 And ds.Tables(0).Rows.Count > 0 Then
                    Me.lstallergyitem.DisplayMember = "AitName"
                    Me.lstallergyitem.ValueMember = "ID"
                    Me.lstallergyitem.DataSource = ds.Tables(0)

                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub FetchLab()
        Try
            Dim ds As DataSet
            ds = Class1.ExecQueryDS("FetchLab", Class1.CustomCommandType.StoredPorcedure, Nothing)

            If Not ds Is Nothing Then
                If ds.Tables.Count > 0 And ds.Tables(0).Rows.Count > 0 Then
                    'Dim dr As DataRow
                    'dr = ds.Tables(0).NewRow()
                    'dr(0) = -1
                    'dr(1) = "Select Lab"

                    'ds.Tables(0).Rows.InsertAt(dr, 0)

                    Me.labname.DisplayMember = "LabName"
                    Me.labname.ValueMember = "labfk"
                    Me.labname.DataSource = ds.Tables(0)

                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub FetchTestLab()
        Try
            Dim ds As DataSet
            ds = Class1.ExecQueryDS("FetchTestLab", Class1.CustomCommandType.StoredPorcedure, Nothing)
            ddtestlab.Items.Clear()
            If Not ds Is Nothing Then
                If ds.Tables.Count > 0 And ds.Tables(0).Rows.Count > 0 Then
                    Dim dr As DataRow
                    dr = ds.Tables(0).NewRow()
                    dr(0) = -1
                    dr(1) = "Select Lab"

                    ds.Tables(0).Rows.InsertAt(dr, 0)
                    ddtestlab.DataSource = ds.Tables(0)
                    ddtestlab.DisplayMember = "TLabNam"
                    ddtestlab.ValueMember = "testLabId"
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub FetchCategory()
        Try
            Dim ds As DataSet
            ds = Class1.ExecQueryDS("FetchCategory", Class1.CustomCommandType.StoredPorcedure, Nothing)
            ddcategory.Items.Clear()
            If Not ds Is Nothing Then
                If ds.Tables.Count > 0 And ds.Tables(0).Rows.Count > 0 Then
                    Dim dr As DataRow
                    dr = ds.Tables(0).NewRow()
                    dr(0) = -1
                    dr(1) = "Select Category"
                    dr(2) = ""
                    ds.Tables(0).Rows.InsertAt(dr, 0)
                    ddcategory.DataSource = ds.Tables(0)
                    ddcategory.DisplayMember = "OCat"
                    ddcategory.ValueMember = "Ocatfk"
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub FetchDepartment()
        Try
            Dim ds As DataSet
            ds = Class1.ExecQueryDS("FetchDepartment", Class1.CustomCommandType.StoredPorcedure, Nothing)
            dddept.Items.Clear()
            If Not ds Is Nothing Then
                If ds.Tables.Count > 0 And ds.Tables(0).Rows.Count > 0 Then
                    Dim dr As DataRow
                    dr = ds.Tables(0).NewRow()
                    dr(0) = -1
                    dr(1) = ""
                    dr(2) = "Select Department"
                    ds.Tables(0).Rows.InsertAt(dr, 0)
                    dddept.DataSource = ds.Tables(0)
                    dddept.DisplayMember = "Dept"
                    dddept.ValueMember = "deptfk"
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub FetchType()
        Try
            Dim ds As DataSet
            ds = Class1.ExecQueryDS("FetchType", Class1.CustomCommandType.StoredPorcedure, Nothing)
            ddtype.Items.Clear()
            If Not ds Is Nothing Then
                If ds.Tables.Count > 0 And ds.Tables(0).Rows.Count > 0 Then
                    Dim dr As DataRow
                    dr = ds.Tables(0).NewRow()
                    dr(0) = -1
                    dr(1) = ""
                    dr(2) = "Select Type"
                    ds.Tables(0).Rows.InsertAt(dr, 0)
                    ddtype.DataSource = ds.Tables(0)
                    ddtype.DisplayMember = "TypeNam"
                    ddtype.ValueMember = "typefk"
                End If
            End If
           

        Catch ex As Exception

        End Try
    End Sub
    Private Sub AlergyTestItemMaster_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            FetchCategory()
            FetchDepartment()
            FetchType()
            FetchLab()
            FetchTestLab()
            FetchAllAlItem()
            btnsave.Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub dglab_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dglab.CellContentClick

    End Sub
    Private Sub save()
        Try
            Dim dtalitem As New DataTable
            dtalitem.Columns.Add("AitId")
            dtalitem.Columns.Add("AitName")
            dtalitem.Columns.Add("AitRateR")
            dtalitem.Columns.Add("AitRateU")
            dtalitem.Columns.Add("DelivDays")
            dtalitem.Columns.Add("CommDr")
            dtalitem.Columns.Add("CommAgnt")
            dtalitem.Columns.Add("AitNameSh")
            dtalitem.Columns.Add("CatId")
            dtalitem.Columns.Add("DeptID")
            dtalitem.Columns.Add("TypeID")
            dtalitem.Columns.Add("RFId")
            dtalitem.Columns.Add("TType")
            dtalitem.Columns.Add("Catfk")
            dtalitem.Columns.Add("Deptfk")
            dtalitem.Columns.Add("Typefk")
            dtalitem.Columns.Add("testlabid")
            dtalitem.Columns.Add("onlyforregistration")
            dtalitem.AcceptChanges()

            Dim dtlab As New DataTable
            dtlab.Columns.Add("AitId")
            dtlab.Columns.Add("labfk")
            dtlab.Columns.Add("DelivDays")
            dtlab.Columns.Add("AitRate")
            dtlab.AcceptChanges()

            Dim dr As DataRow
            dr = dtalitem.NewRow()
            dr("AitId") = txtitemid.Text
            dr("AitName") = txtitemname.Text
            dr("AitRateR") = IIf(txtregisteredcharges.Text = "", 0, txtregisteredcharges.Text)
            dr("AitRateU") = IIf(txtunregisteredcharge.Text = "", 0, txtunregisteredcharge.Text)
            dr("DelivDays") = IIf(txtdelivery.Text = "", 0, txtdelivery.Text)
            dr("CommDr") = 0
            dr("CommAgnt") = 0
            dr("AitNameSh") = txtshortname.Text
            dr("CatId") = ddcategory.Text
            dr("DeptID") = dddept.Text
            dr("TypeID") = ddtype.Text
            dr("RFId") = ""
            dr("TType") = ""
            dr("Catfk") = ddcategory.SelectedValue
            dr("Deptfk") = dddept.SelectedValue
            dr("Typefk") = ddtype.SelectedValue
            dr("testlabid") = ddtestlab.SelectedValue
            dr("onlyforregistration") = IIf(chkconst.Checked = True, "Y", "N")
            dtalitem.Rows.Add(dr)
            dtalitem.AcceptChanges()
            Dim dsalitem As New DataSet
            dsalitem.Tables.Add(dtalitem)
            dsalitem.AcceptChanges()

            For i = 0 To dglab.Rows.Count - 1

                Dim dgrow As DataGridViewRow
                dgrow = dglab.Rows(i)
                If dgrow.Cells("labname").Value Is Nothing Then
                    Exit For
                End If
                'MsgBox(dgrow.Cells("labname").Value)
                dr = dtlab.NewRow()
                dr("AitId") = ""
                dr("labfk") = dgrow.Cells("labname").Value
                dr("AitRate") = IIf(IsNumeric(dgrow.Cells("Rate").Value), dgrow.Cells("Rate").Value, 0)
                dr("DelivDays") = IIf(IsNumeric(dgrow.Cells("Delvdays").Value), dgrow.Cells("Delvdays").Value, 0)

                dtlab.Rows.Add(dr)
                dtlab.AcceptChanges()
            Next
            Dim dslab As New DataSet
            dslab.Tables.Add(dtlab)

            Dim param(3) As SqlParameter
            param(0) = New SqlParameter("@Xmlalitem", dsalitem.GetXml())
            param(1) = New SqlParameter("@Xmllab", dslab.GetXml())
            param(2) = New SqlParameter("@userfk", Class1.cUserpk)
            param(3) = New SqlParameter("@mode", alid)
            Dim dsret As DataSet
            dsret = Class1.ExecQueryDS("sp_Insert_alitem", Class1.CustomCommandType.StoredPorcedure, param)
            'dsret = Class1.ExecQueryDS("sp_Insert_PageSecurity", Class1.CustomCommandType.StoredPorcedure, param)
            If Not dsret Is Nothing Then
                If dsret.Tables(0).Rows(0).Item(0) = "1" Then
                    MsgBox("Save Successfully!!")
                    FetchAllAlItem()
                    reset()
                Else
                    MsgBox("Error in Data")
                End If
            End If




        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            save()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnsearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        Try
            FetchAllAlItem()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub FetchAllAlItemByid()
        Try

            Dim param(0) As SqlParameter
            param(0) = New SqlParameter("alID", alid)
            Dim ds As DataSet
            dglab.DataSource = Nothing
            ds = Class1.ExecQueryDS("FetchAllAlItemByid", Class1.CustomCommandType.StoredPorcedure, param)

            If Not ds Is Nothing Then
                If ds.Tables.Count > 0 And ds.Tables(0).Rows.Count > 0 Then
                    txtitemid.Text = ds.Tables(0).Rows(0).Item("AitId")
                    txtitemname.Text = ds.Tables(0).Rows(0).Item("AitName")
                    txtshortname.Text = ds.Tables(0).Rows(0).Item("AitNameSh")
                    txtdelivery.Text = ds.Tables(0).Rows(0).Item("DelivDays")
                    ddcategory.SelectedValue = ds.Tables(0).Rows(0).Item("Catfk")
                    dddept.SelectedValue = ds.Tables(0).Rows(0).Item("Deptfk")
                    ddtype.SelectedValue = ds.Tables(0).Rows(0).Item("Typefk")
                    txtregisteredcharges.Text = ds.Tables(0).Rows(0).Item("AitRateR")
                    txtunregisteredcharge.Text = ds.Tables(0).Rows(0).Item("AitRateU")
                    'txtdoctorcommission.Text = ds.Tables(0).Rows(0).Item("CommDr")
                    'txtagentcommission.Text = ds.Tables(0).Rows(0).Item("CommAgnt")
                    ddtestlab.SelectedValue = ds.Tables(0).Rows(0).Item("testlabid")
                    chkconst.Checked = IIf(ds.Tables(0).Rows(0).Item("onlyforregistration").ToString = "Y", True, False)

                    If ds.Tables(1).Rows.Count > 0 Then
                        dglab.DataSource = ds.Tables(1)
                        dglab.AutoGenerateColumns = False

                        'For j = 0 To ds.Tables(1).Rows.Count - 1

                        For i = 0 To ds.Tables(1).Rows.Count - 1

                            Dim dgrow As DataGridViewRow
                            dgrow = dglab.Rows(i)
                            'If dgrow.Cells("labname").Value Is Nothing Then
                            '    Exit For
                            'End If
                            dgrow.Cells("labname").Value = ds.Tables(1).Rows(i).Item("labfk")
                        Next
                        dglab.Columns.Remove("labfk")
                        'Next
                    End If
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub lstallergyitem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstallergyitem.Click
        Try
            alid = lstallergyitem.SelectedValue
            FetchAllAlItemByid()
            btnsave.Visible = True
            'btnadd.Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lstallergyitem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstallergyitem.SelectedIndexChanged

    End Sub

    Private Sub btndeletelab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndeletelab.Click
        Try
            For Each row As DataGridViewRow In dglab.SelectedRows
                If Not row.IsNewRow Then
                    dglab.Rows.Remove(row)
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub reset()
        Try
            txtitemid.Text = ""
            txtitemname.Text = ""
            txtshortname.Text = ""
            txtdelivery.Text = "0"
            ddcategory.SelectedValue = -1
            dddept.SelectedValue = -1
            ddtype.SelectedValue = -1
            txtregisteredcharges.Text = "0"
            txtunregisteredcharge.Text = "0"
            'txtdoctorcommission.Text = "0"
            'txtagentcommission.Text = "0"
            alid = "-1"
            dglab.DataSource = Nothing
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnadd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Try
            reset()
            btnsave.Visible = True
        Catch ex As Exception

        End Try
    End Sub

End Class