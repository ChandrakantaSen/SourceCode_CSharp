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
Public Class NCDasInhouse
    Dim namescollection As New AutoCompleteStringCollection
    'Dim patientpk As String = "-1"
    Dim frm2 As AddPatientMaster
    Dim frmsearchpatient As searchpatient
    Dim visiteddoctorid As Int32 = -1
    Dim refdoctorid As Int32 = -1
    Dim reflabid As Int32 = -1
    Dim patientfk As Int32 = -1
    Dim billheaderid As Int32 = -1
    Dim entrymode As String = ""
    Private Sub getAllAgentmaster()
        Try
            Dim ds As DataSet
            ds = Class1.ExecQueryDS("getAllAgentmaster", Class1.CustomCommandType.StoredPorcedure, Nothing)
            If Not ds Is Nothing Then
                If ds.Tables.Count > 0 And ds.Tables(0).Rows.Count > 0 Then
                    Dim dr As DataRow
                    dr = ds.Tables(0).NewRow()
                    dr(0) = -1
                    dr(1) = ""
                    dr(2) = "Select Agent"

                    ds.Tables(0).Rows.InsertAt(dr, 0)
                    ddagent.DataSource = ds.Tables(0)
                    ddagent.DisplayMember = "AgntName"
                    ddagent.ValueMember = "id"

                End If
            End If

        Catch ex As Exception

        End Try


    End Sub
    Private Sub getchildFromCode()
        Try
            Dim ds As DataSet
            Dim param(0) As SqlParameter
            param(0) = New SqlParameter("@codeparent", "BILLFOR")

            ds = Class1.ExecQueryDS("getchildFromCode", Class1.CustomCommandType.StoredPorcedure, param)
            If Not ds Is Nothing Then
                If ds.Tables.Count > 0 And ds.Tables(0).Rows.Count > 0 Then
                    Dim dr As DataRow
                    dr = ds.Tables(0).NewRow()
                    dr(0) = -1
                    dr(1) = "Select"
                    ds.Tables(0).Rows.InsertAt(dr, 0)
                    ddbookfor.DataSource = ds.Tables(0)
                    ddbookfor.DisplayMember = "code_description"
                    ddbookfor.ValueMember = "code_pk"

                End If
            End If

        Catch ex As Exception

        End Try


    End Sub

    Private Sub FetchConsultation()
        Try
            Dim ds As DataSet
            ds = Class1.ExecQueryDS("FetchNonConsultation", Class1.CustomCommandType.StoredPorcedure, Nothing)

            If Not ds Is Nothing Then
                If ds.Tables.Count > 0 And ds.Tables(0).Rows.Count > 0 Then
                    Dim dr As DataRow
                    dr = ds.Tables(0).NewRow()
                    dr(0) = -1
                    dr(1) = "Select Item"

                    ds.Tables(0).Rows.InsertAt(dr, 0)

                    Me.Itemdescription.DisplayMember = "AitName"
                    Me.Itemdescription.ValueMember = "ID"
                    Me.Itemdescription.DataSource = ds.Tables(0)

                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninsert.Click
        Try
            gbSave.Visible = True
            gbinsert.Visible = False
            enabletrue(True)
            txtpatientID.Focus()
            txtpatientID.Text = ""
            patientfk = -1
            entrymode = "INSERT"
        Catch ex As Exception

        End Try
    End Sub
    Private Sub SshowOptionsForm()
        Dim options = New AddPatientMaster
        If options.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim value = options.mypatientfk
            MsgBox(value)
        End If
    End Sub
    Private Sub txtpatientID_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpatientID.DoubleClick
        Try
            frmsearchpatient = New searchpatient()
            frmsearchpatient.StartPosition = FormStartPosition.Manual
            frmsearchpatient.Location = New Point(10, 10)
            frmsearchpatient.WindowState = FormWindowState.Normal
            frmsearchpatient.Height = 600
            frmsearchpatient.Width = 750
            Dim dr As DialogResult = frmsearchpatient.ShowDialog(Me)
            If dr = Windows.Forms.DialogResult.OK Then
                'Dim value = options.mypatientfk
                'MsgBox(value)
                patientfk = frmsearchpatient.mypatientfk
                txtpatientID.Text = frmsearchpatient.mypatientid
                txtpatientname.Text = frmsearchpatient.mypatient_name
                txtage.Text = frmsearchpatient.mypatientage
                ddsex.SelectedItem = frmsearchpatient.mypatientsex
            Else
                MsgBox("Hello")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtvisiteddoctorid_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtvisiteddoctorid.LostFocus
        Try
            Dim ds As DataSet
            If txtvisiteddoctorid.Text.Trim() <> "" Then
                Dim param(1) As SqlParameter
                param(0) = New SqlParameter("@visiteddoctid", txtvisiteddoctorid.Text)
                param(1) = New SqlParameter("@inhouse", 1)
                ds = Class1.ExecQueryDS("getdoctorfromreftable", Class1.CustomCommandType.StoredPorcedure, param)
                txtvisiteddoctorname.Text = ""
                visiteddoctorid = -1
                If Not ds Is Nothing Then
                    If ds.Tables.Count > 0 And ds.Tables(0).Rows.Count > 0 Then
                        visiteddoctorid = ds.Tables(0).Rows(0).Item("id")
                        txtvisiteddoctorname.Text = ds.Tables(0).Rows(0).Item("RefName")
                        txtvisiteddoctorid.Text = ds.Tables(0).Rows(0).Item("RefId")
                    Else
                        MsgBox("No such Doctor available!!!!")
                        txtvisiteddoctorname.Text = ""
                        visiteddoctorid = -1
                        txtvisiteddoctorid.Text = ""
                    End If
                Else
                    MsgBox("No such Doctor available!!!!")
                    txtvisiteddoctorname.Text = ""
                    visiteddoctorid = -1
                    txtvisiteddoctorid.Text = ""
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtrefdoctorid_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtrefdoctorid.LostFocus
        Try
            Dim ds As DataSet
            If txtrefdoctorid.Text.Trim() <> "" Then
                Dim param(1) As SqlParameter
                param(0) = New SqlParameter("@visiteddoctid", txtrefdoctorid.Text)
                param(1) = New SqlParameter("@inhouse", 0)
                ds = Class1.ExecQueryDS("getdoctorfromreftable", Class1.CustomCommandType.StoredPorcedure, param)
                txtrefdoctorname.Text = ""
                refdoctorid = -1
                If Not ds Is Nothing Then
                    If ds.Tables.Count > 0 And ds.Tables(0).Rows.Count > 0 Then
                        refdoctorid = ds.Tables(0).Rows(0).Item("id")
                        txtrefdoctorname.Text = ds.Tables(0).Rows(0).Item("RefName")
                        txtrefdoctorid.Text = ds.Tables(0).Rows(0).Item("RefId")
                    Else
                        MsgBox("No such Doctor available!!!!")
                        txtrefdoctorname.Text = ""
                        refdoctorid = -1
                        txtrefdoctorid.Text = ""
                    End If
                Else
                    MsgBox("No such Doctor available!!!!")
                    txtrefdoctorname.Text = ""
                    refdoctorid = -1
                    txtrefdoctorid.Text = ""
                End If
            End If
        Catch ex As Exception


        End Try
    End Sub

    Private Sub txtlabid_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtlabid.LostFocus
        Try
            Dim ds As DataSet
            If txtlabid.Text.Trim() <> "" Then
                Dim param(0) As SqlParameter
                param(0) = New SqlParameter("@labid", txtlabid.Text)

                ds = Class1.ExecQueryDS("getRefLabMaster", Class1.CustomCommandType.StoredPorcedure, param)
                txtlabname.Text = ""
                reflabid = -1
                If Not ds Is Nothing Then
                    If ds.Tables.Count > 0 And ds.Tables(0).Rows.Count > 0 Then
                        reflabid = ds.Tables(0).Rows(0).Item("labfk")
                        txtlabname.Text = ds.Tables(0).Rows(0).Item("LabName")
                        txtlabid.Text = ds.Tables(0).Rows(0).Item("LabId")
                    Else
                        MsgBox("No such Laboratory available!!!!")
                        txtlabname.Text = ""
                        reflabid = -1
                        txtlabid.Text = ""
                    End If
                Else
                    MsgBox("No such Laboratory available!!!!")
                    txtlabname.Text = ""
                    reflabid = -1
                    txtlabid.Text = ""
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub fetchpathsalesbill()
        Try
            Dim param(0) As SqlParameter
            param(0) = New SqlParameter("@billid", Class1.cpathbillid)
            Dim ds As DataSet
            ds = Class1.ExecQueryDS("fetchpathsalesbill", Class1.CustomCommandType.StoredPorcedure, param)

            If Not ds Is Nothing Then
                If ds.Tables.Count > 0 And ds.Tables(0).Rows.Count > 0 Then
                    txtpatientID.Text = ds.Tables(0).Rows(0).Item("PatientId")
                    txtpatientoldid.Text = ""
                    txtpatientname.Text = ds.Tables(0).Rows(0).Item("PtName")
                    ddsex.SelectedItem = ds.Tables(0).Rows(0).Item("Sex")
                    txtvisiteddoctorname.Text = ds.Tables(0).Rows(0).Item("VisitToNam")
                    visiteddoctorid = ds.Tables(0).Rows(0).Item("visitingdoctorfk")
                    txtvisiteddoctorid.Text = ds.Tables(0).Rows(0).Item("VisitToId")
                    txtrefdoctorname.Text = ds.Tables(0).Rows(0).Item("RefName")
                    refdoctorid = ds.Tables(0).Rows(0).Item("refdoctorfk")
                    txtrefdoctorid.Text = ds.Tables(0).Rows(0).Item("RefId")
                    txtlabname.Text = ds.Tables(0).Rows(0).Item("LabName")
                    reflabid = ds.Tables(0).Rows(0).Item("labfk")
                    txtlabid.Text = ds.Tables(0).Rows(0).Item("LabId")
                    ddagent.SelectedValue = ds.Tables(0).Rows(0).Item("agentfk")
                    'ddbillfor.SelectedValue = -1
                    txtbillno.Text = ds.Tables(0).Rows(0).Item("PblId")
                    dtbilldate.Value = ds.Tables(0).Rows(0).Item("PblDt")
                    dtcollection.Value = ds.Tables(0).Rows(0).Item("CollDt")
                    txtage.Text = ds.Tables(0).Rows(0).Item("AgeYr")
                    txtgrossamount.Text = ds.Tables(0).Rows(0).Item("GrAmt")
                    txtnetamount.Text = ds.Tables(0).Rows(0).Item("PtotAmt")
                    txtdiscmanagement.Text = ds.Tables(0).Rows(0).Item("PtotDisc")
                    txtdiscrefdoctor.Text = ds.Tables(0).Rows(0).Item("PtotDiscRef")
                    txtdiscvisiteddoctor.Text = ds.Tables(0).Rows(0).Item("PTotDiscVisit")
                    txtremarks.Text = ds.Tables(0).Rows(0).Item("Remarks")
                    dtproposeddate.Value = ds.Tables(0).Rows(0).Item("PDelivDt")

                    txtbilltime.Text = Format(ds.Tables(0).Rows(0).Item("BillTime"), "hh:mm:ss tt")
                    txtcollectiontime.Text = Format(ds.Tables(0).Rows(0).Item("CollTime"), "hh:mm:ss tt")
                    'txtlabdoctor.Text = ds.Tables(0).Rows(0).Item("LabDoc")
                    'txtlabdoctorcode.Text = ds.Tables(0).Rows(0).Item("LabCode")
                    chkprintremarks.Checked = False

                    '' Details Portion

                    dgitems.DataSource = ds.Tables(1)
                    dgitems.AutoGenerateColumns = False

                    For i = 0 To ds.Tables(1).Rows.Count - 1

                        Dim dgrow As DataGridViewRow
                        dgrow = dgitems.Rows(i)
                        'If dgrow.Cells("labname").Value Is Nothing Then
                        '    Exit For
                        'End If
                        dgrow.Cells("Itemdescription").Value = ds.Tables(1).Rows(i).Item("Itemdescription")
                        dgrow.Cells("senttolab").Value = ds.Tables(1).Rows(i).Item("senttolab")
                    Next
                    If ds.Tables.Count > 2 And ds.Tables(2).Rows.Count > 0 Then
                        dtpmt.Value = ds.Tables(2).Rows(0).Item("PDPmtDt")
                        txtpaidamount.Text = ds.Tables(2).Rows(0).Item("PDPmtAmt")
                        ddmodeofpayment.SelectedItem = ds.Tables(2).Rows(0).Item("pmtmode")
                        txtchno.Text = ds.Tables(2).Rows(0).Item("cheque_CVV_no")
                        txtpmtremarks.Text = ds.Tables(2).Rows(0).Item("Remarks")
                    End If

                    'billheaderid = -1
                    'txtchno.Text = ""
                    'txtpaidamount.Text = "0"
                    'txtpmtremarks.Text = ""
                    'patientfk = -1
                    'dgitems.Rows.Clear()
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub AATC_REG_CONS_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            'ddbillfor.SelectedIndex = 0
            ddmodeofpayment.SelectedIndex = 0
            btndelete.Visible = False

            reset()
            enabletrue(False)

            gbSave.Visible = False
            getAllAgentmaster()
            getchildFromCode()
            FetchConsultation()
            txtbilltime.Text = Format(Now, "hh:mm:ss tt")
            txtcollectiontime.Text = Format(Now, "hh:mm:ss tt")
            txtbooktime.Text = Format(Now, "hh:mm:ss tt")
            dgitems.Rows(0).Cells(7).Value = "DELETE"
            If Class1.cpathbillid > 0 Then
                fetchpathsalesbill()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgitems_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgitems.CellClick
        Try
            If e.RowIndex = dgitems.NewRowIndex Or e.RowIndex < 0 Then
                Exit Sub

            End If
            If e.ColumnIndex = Me.dgitems.Columns("delete").Index Then
                dgitems.Rows.RemoveAt(e.RowIndex)
                calculateamount()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgitems_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgitems.CellFormatting
        'Try
        '    If e.RowIndex < 0 Or e.RowIndex = Me.dgitems.NewRowIndex Then
        '        Exit Sub
        '    End If
        '    If e.ColumnIndex = Me.dgitems.Columns("delete").Index Then
        '        e.Value = "Delete"
        '    End If
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub dgitems_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgitems.CurrentCellDirtyStateChanged
        Try
            Dim col As DataGridViewColumn = dgitems.Columns(dgitems.CurrentCell.ColumnIndex)
            If TypeOf col Is DataGridViewComboBoxColumn Then
                dgitems.CommitEdit(DataGridViewDataErrorContexts.Commit)
                calculateamount()
            End If
        Catch ex As Exception

        End Try
    End Sub



    Private Sub dgitems_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgitems.EditingControlShowing
        Try
            'If dgitems.CurrentCell.ColumnIndex = 0 And 
            If TypeOf e.Control Is ComboBox Then
                '   Dim comboBox As 
                If dgitems.CurrentCell.ColumnIndex = 0 Then
                    Dim editcombo As ComboBox = CType(e.Control, ComboBox)
                    editcombo.SelectedIndex = 0
                    If Not editcombo Is Nothing Then
                        RemoveHandler editcombo.SelectedValueChanged, AddressOf editcombo_SelectedIndexChanged
                        AddHandler editcombo.SelectedValueChanged, AddressOf editcombo_SelectedIndexChanged

                    End If
                End If

            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub fetchallergyitemdetails(ByVal itemvalue As String)

        Try

        Catch ex As Exception

        End Try
    End Sub
    Private Sub calculateamount()
        Try
            Dim totalvalue As Int32 = 0
            For i = 0 To dgitems.Rows.Count - 1

                Dim dgrow As DataGridViewRow
                dgrow = dgitems.Rows(i)
                If dgrow.Cells("Itemdescription").Value Is Nothing Then
                    Exit For
                End If
                totalvalue = totalvalue + CInt(dgrow.Cells("amount").Value)
                'dr = dtlab.NewRow()
                'dr("AitId") = ""
                'dr("labfk") = dgrow.Cells("labname").Value
                'dr("AitRate") = IIf(IsNumeric(dgrow.Cells("Rate").Value), dgrow.Cells("Rate").Value, 0)
                'dr("DelivDays") = IIf(IsNumeric(dgrow.Cells("Delvdays").Value), dgrow.Cells("Delvdays").Value, 0)

                'dtlab.Rows.Add(dr)
                'dtlab.AcceptChanges()
            Next
            txtgrossamount.Text = totalvalue
            txtnetamount.Text = totalvalue
        Catch ex As Exception

        End Try
    End Sub
    Private Sub editcombo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            Dim cbocell As ComboBox = CType(sender, ComboBox)
            'MsgBox(cbocell.SelectedValue.ToString())
            'dgitems.CurrentRow.Cells(1).Value = "11"
            dgitems.CurrentRow.Cells(1).Value = "0"
            dgitems.CurrentRow.Cells(3).Value = ""
            dgitems.CurrentRow.Cells(7).Value = "DELETE"
            If cbocell.SelectedIndex > 0 Then
                Dim param(1) As SqlParameter
                param(0) = New SqlParameter("aiid", cbocell.SelectedValue)
                param(1) = New SqlParameter("dlvdate", dtbilldate.Value.ToShortDateString())
                Dim ds As DataSet
                ds = Class1.ExecQueryDS("fetchallergyitemdetailsver2", Class1.CustomCommandType.StoredPorcedure, param)
                If Not ds Is Nothing Then
                    If ds.Tables.Count > 0 And ds.Tables(0).Rows.Count > 0 Then
                        'dgitems.CurrentRow.Cells(0).Value = cbocell.SelectedValue
                        dgitems.CurrentRow.Cells(1).Value = ds.Tables(0).Rows(0).Item("AitRateR")
                        dgitems.CurrentRow.Cells(3).Value = ds.Tables(0).Rows(0).Item("dlvdate")

                        dgitems.CurrentRow.Cells(7).Value = "DELETE"
                        'txtgrossamount.Text = ds.Tables(0).Rows(0).Item("AitRateR")
                        'calculateamount()

                    End If
                End If
            End If
            'dgitems.CommitEdit(DataGridViewDataErrorContexts.Commit)
            ''dgitems.BindingContext().
            'Dim totalvalue As Int32 = 0
            'For i = 0 To dgitems.Rows.Count - 1

            '    Dim dgrow As DataGridViewRow
            '    dgrow = dgitems.Rows(i)
            '    If dgrow.Cells("Itemdescription").Value Is Nothing Then
            '        Exit For
            '    End If
            '    totalvalue = totalvalue + CInt(dgrow.Cells("amount").Value)

            'Next
            'totalvalue = totalvalue + CInt(dgitems.CurrentRow.Cells(1).Value)
            'txtgrossamount.Text = totalvalue

        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtpatientID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpatientID.KeyDown
        If e.KeyValue = Keys.F8 Then
            Try
                frmsearchpatient = New searchpatient()
                frmsearchpatient.StartPosition = FormStartPosition.Manual
                frmsearchpatient.Location = New Point(10, 10)
                frmsearchpatient.WindowState = FormWindowState.Normal
                frmsearchpatient.Height = 600
                frmsearchpatient.Width = 750
                Dim dr As DialogResult = frmsearchpatient.ShowDialog(Me)
                If dr = Windows.Forms.DialogResult.OK Then
                    'Dim value = options.mypatientfk
                    'MsgBox(value)
                    patientfk = frmsearchpatient.mypatientfk
                    txtpatientID.Text = frmsearchpatient.mypatientid
                    txtpatientname.Text = frmsearchpatient.mypatient_name
                    txtage.Text = frmsearchpatient.mypatientage
                    ddsex.SelectedItem = frmsearchpatient.mypatientsex
                Else
                    MsgBox("Hello")
                End If
            Catch ex As Exception

            End Try
        End If
        If e.KeyValue = Keys.F6 Then
            Try
                frm2 = New AddPatientMaster()
                frm2.StartPosition = FormStartPosition.Manual
                frm2.Location = New Point(10, 10)
                frm2.WindowState = FormWindowState.Normal
                frm2.Height = 517
                frm2.Width = 688
                Dim dr As DialogResult = frm2.ShowDialog(Me)
                If dr = Windows.Forms.DialogResult.OK Then
                    Dim value = frm2.mypatientfk
                    patientfk = frm2.mypatientfk
                    txtpatientID.Text = frm2.mypatientid
                    txtpatientname.Text = frm2.txtname.Text
                    txtage.Text = frm2.txtage.Text
                    ddsex.SelectedItem = frm2.ddsex.SelectedItem

                Else
                    MsgBox("Hello")
                End If
            Catch ex As Exception

            End Try
        End If

    End Sub
    Private Function validdata() As Boolean
        Try
            If patientfk < 1 Then
                MsgBox("Must enter or Select Patient!!")
                Return False
            End If
            If dgitems.Rows.Count <= 1 Then
                MsgBox("Must Items!!")
                Return False
            End If
            If CDec(txtnetamount.Text) < CDec(txtpaidamount.Text) Then
                MsgBox("Net amount cannot be less than paid amount!!")
                Return False
            End If
            Return True
        Catch ex As Exception

        End Try
    End Function
    Private Sub btnsave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            If validdata() = False Then
                Exit Sub

            End If
            Dim paidamount As Decimal = 0
            Dim netamount As Decimal = 0
            Dim balamount As Decimal = 0
            paidamount = CDec(IIf(IsNumeric(txtpaidamount.Text), txtpaidamount.Text, 0))
            netamount = CDec(IIf(IsNumeric(txtnetamount.Text), txtnetamount.Text, 0))
            balamount = netamount - paidamount
            Dim AllergyBillHeader As New DataTable
            AllergyBillHeader.Columns.Add("AblId")
            AllergyBillHeader.Columns.Add("AblDt")
            AllergyBillHeader.Columns.Add("PatientId")
            AllergyBillHeader.Columns.Add("OldId")
            AllergyBillHeader.Columns.Add("VisitToNam")
            AllergyBillHeader.Columns.Add("VisitToId")
            AllergyBillHeader.Columns.Add("RefName")
            AllergyBillHeader.Columns.Add("RefId")
            AllergyBillHeader.Columns.Add("LabName")
            AllergyBillHeader.Columns.Add("LabId")
            AllergyBillHeader.Columns.Add("AgntId")
            AllergyBillHeader.Columns.Add("PDelivDt")
            AllergyBillHeader.Columns.Add("DelivTime")
            AllergyBillHeader.Columns.Add("GrAmt")
            AllergyBillHeader.Columns.Add("AtotAmt")
            AllergyBillHeader.Columns.Add("AtotDisc")
            AllergyBillHeader.Columns.Add("ATotDiscVisit")
            AllergyBillHeader.Columns.Add("AtotDiscRef")
            AllergyBillHeader.Columns.Add("AtotBal")
            AllergyBillHeader.Columns.Add("TestList")
            AllergyBillHeader.Columns.Add("BillFor")
            AllergyBillHeader.Columns.Add("Prnted")
            AllergyBillHeader.Columns.Add("Remarks")
            AllergyBillHeader.Columns.Add("PrnRemarks")
            AllergyBillHeader.Columns.Add("BillTime")
            AllergyBillHeader.Columns.Add("CretCurrUser")
            AllergyBillHeader.Columns.Add("Post")
            AllergyBillHeader.Columns.Add("TestSend")
            AllergyBillHeader.Columns.Add("CollId")
            AllergyBillHeader.Columns.Add("LabCode")
            AllergyBillHeader.Columns.Add("BokFor")
            AllergyBillHeader.Columns.Add("BokTime")
            AllergyBillHeader.Columns.Add("VCallDone")
            AllergyBillHeader.Columns.Add("patientfk")
            AllergyBillHeader.Columns.Add("visitingdoctorfk")
            AllergyBillHeader.Columns.Add("refdoctorfk")
            AllergyBillHeader.Columns.Add("labfk")
            AllergyBillHeader.Columns.Add("bookforcodepk")
            AllergyBillHeader.Columns.Add("agentfk")
            AllergyBillHeader.Columns.Add("CollDt")
            AllergyBillHeader.Columns.Add("CollTime")

            AllergyBillHeader.AcceptChanges()

            Dim drheader As DataRow
            Dim AblId As String = ""
            AblId = Class1.NewYearId("T_PathBill", "PblId", "", Format(dtbilldate.Value, "dd-MMM-yyyy"), 5)
            'Exit Sub
            drheader = AllergyBillHeader.NewRow()
            drheader("AblId") = AblId
            drheader("AblDt") = Format(dtbilldate.Value, "dd-MMM-yyyy")
            drheader("PatientId") = txtpatientID.Text
            drheader("OldId") = txtpatientoldid.Text
            drheader("VisitToNam") = txtvisiteddoctorname.Text
            drheader("VisitToId") = txtvisiteddoctorid.Text
            drheader("RefName") = txtrefdoctorname.Text
            drheader("RefId") = txtrefdoctorid.Text
            drheader("LabName") = txtlabname.Text
            drheader("LabId") = txtlabid.Text
            drheader("AgntId") = ddagent.Text
            drheader("PDelivDt") = Format(dtproposeddate.Value, "dd-MMM-yyyy")
            drheader("DelivTime") = ""
            drheader("GrAmt") = IIf(txtgrossamount.Text = "", 0, txtgrossamount.Text)
            drheader("AtotAmt") = IIf(txtnetamount.Text = "", 0, txtnetamount.Text)
            drheader("AtotDisc") = IIf(txtdiscmanagement.Text = "", 0, txtdiscmanagement.Text)
            drheader("ATotDiscVisit") = IIf(txtdiscvisiteddoctor.Text = "", 0, txtdiscvisiteddoctor.Text)
            drheader("AtotDiscRef") = IIf(txtdiscrefdoctor.Text = "", 0, txtdiscrefdoctor.Text)
            drheader("AtotBal") = balamount ' IIf(txtnetamount.Text = "", 0, txtnetamount.Text)
            drheader("TestList") = ""
            drheader("BillFor") = "" ' ddbillfor.SelectedItem
            'drheader("Prnted")
            drheader("Remarks") = txtremarks.Text
            drheader("PrnRemarks") = chkprintremarks.Checked
            drheader("BillTime") = txtbilltime.Text
            drheader("CretCurrUser") = Class1.cUserID
            'drheader("Post")
            'drheader("TestSend")
            'drheader("CollId")
            'drheader("LabCode")
            drheader("BokFor") = ddbookfor.Text
            drheader("BokTime") = txtbooktime.Text
            'drheader("VCallDone")
            drheader("patientfk") = patientfk
            drheader("visitingdoctorfk") = visiteddoctorid
            drheader("refdoctorfk") = refdoctorid
            drheader("labfk") = reflabid
            drheader("bookforcodepk") = ddbookfor.SelectedValue
            drheader("agentfk") = ddagent.SelectedValue
            drheader("CollDt") = dtcollection.Value.ToShortDateString()
            drheader("CollTime") = txtcollectiontime.Text

            AllergyBillHeader.Rows.Add(drheader)

            Dim dsallergybillheader As New DataSet
            dsallergybillheader.Tables.Add(AllergyBillHeader)
            dsallergybillheader.AcceptChanges()


            Dim dtbillsub As New DataTable
            dtbillsub.Columns.Add("AblId")
            dtbillsub.Columns.Add("AitId")
            dtbillsub.Columns.Add("AblAmt")
            dtbillsub.Columns.Add("DelivDt")
            dtbillsub.Columns.Add("biilitemid")
            'dtbillsub.Columns.Add("")
            'dtbillsub.Columns.Add("")
            'dtbillsub.Columns.Add("")
            'dtbillsub.Columns.Add("")
            dtbillsub.AcceptChanges()
            Dim dsbillsubid As New DataSet
            Dim drsubbill As DataRow

            For i = 0 To dgitems.Rows.Count - 1

                Dim dgrow As DataGridViewRow
                dgrow = dgitems.Rows(i)
                If dgrow.Cells("Itemdescription").Value Is Nothing Then
                    Exit For
                End If
                drsubbill = dtbillsub.NewRow
                drsubbill("AitId") = dgrow.Cells("Itemdescription").Value
                drsubbill("biilitemid") = dgrow.Cells("Itemdescription").Value
                drsubbill("AblAmt") = IIf(IsNumeric(dgrow.Cells("amount").Value), dgrow.Cells("amount").Value, 0)
                drsubbill("DelivDt") = dgrow.Cells("deliverydate").Value
                dtbillsub.Rows.Add(drsubbill)
                dtbillsub.AcceptChanges()


                'MsgBox(dgrow.Cells("Itemdescription").Value)
            Next
            dsbillsubid.Tables.Add(dtbillsub)

            Dim dtpayment As New DataTable
            dtpayment.Columns.Add("dateofpayment")
            dtpayment.Columns.Add("paidamount")
            dtpayment.Columns.Add("modeofpayment")
            dtpayment.Columns.Add("cheque_cvv_no")
            dtpayment.Columns.Add("chequedate")
            dtpayment.Columns.Add("remarks")
            dtpayment.AcceptChanges()

            Dim dspayment As New DataSet
            Dim drpayment As DataRow
            drpayment = dtpayment.NewRow()
            drpayment("dateofpayment") = Format(dtpmt.Value, "dd-MMM-yyyy")
            drpayment("paidamount") = txtpaidamount.Text
            drpayment("modeofpayment") = ddmodeofpayment.SelectedItem
            drpayment("cheque_cvv_no") = txtchno.Text
            drpayment("chequedate") = Format(dtch.Value, "dd-MMM-yyyy")
            drpayment("remarks") = txtpmtremarks.Text
            dtpayment.Rows.Add(drpayment)
            dtpayment.AcceptChanges()
            dspayment.Tables.Add(dtpayment)
            dspayment.AcceptChanges()



            Dim param(4) As SqlParameter
            param(0) = New SqlParameter("@Xmlitem", dsallergybillheader.GetXml())
            param(1) = New SqlParameter("@Xmlsubitem", dsbillsubid.GetXml)
            param(2) = New SqlParameter("@XmlsubitemP", dspayment.GetXml)
            param(3) = New SqlParameter("@userfk", Class1.cUserpk)
            param(4) = New SqlParameter("@mode", -1)

            Dim dsret As DataSet
            dsret = Class1.ExecQueryDS("sp_Insert_pathbill", Class1.CustomCommandType.StoredPorcedure, param)

            If Not dsret Is Nothing Then
                If dsret.Tables.Count > 0 And dsret.Tables(0).Rows.Count > 0 Then
                    If dsret.Tables(0).Rows(0).Item(0) = "1" Then
                        billheaderid = dsret.Tables(0).Rows(0).Item("headerid")
                        'savePayment()
                        MsgBox("Save Successfully!!")
                        reset()
                    Else
                        MsgBox("Error in saving!!")

                    End If
                End If
            End If

            '' sp_Insert_regbill
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnexit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub reset()
        Try
            txtpatientID.Text = ""
            txtpatientoldid.Text = ""
            txtpatientname.Text = ""
            txtvisiteddoctorname.Text = ""
            visiteddoctorid = -1
            txtvisiteddoctorid.Text = ""
            txtrefdoctorname.Text = ""
            refdoctorid = -1
            txtrefdoctorid.Text = ""
            txtlabname.Text = ""
            reflabid = -1
            txtlabid.Text = ""
            ddagent.SelectedValue = -1
            'ddbillfor.SelectedValue = -1
            txtbillno.Text = ""
            txtage.Text = ""
            txtgrossamount.Text = "0"
            txtnetamount.Text = "0"
            txtdiscmanagement.Text = "0"
            txtdiscrefdoctor.Text = "0"
            txtdiscvisiteddoctor.Text = "0"
            txtremarks.Text = ""
            chkprintremarks.Checked = False
            billheaderid = -1
            txtchno.Text = ""
            txtpaidamount.Text = "0"
            txtpmtremarks.Text = ""
            patientfk = -1
            dgitems.Rows.Clear()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub enabletrue(ByVal en As Boolean)
        Try
            txtpatientID.Enabled = en
            txtpatientoldid.Enabled = en
            txtpatientname.Enabled = en
            txtvisiteddoctorname.Enabled = en

            txtvisiteddoctorid.Enabled = en
            txtrefdoctorname.Enabled = en

            txtrefdoctorid.Enabled = en
            txtlabname.Enabled = en

            txtlabid.Enabled = en
            ddagent.Enabled = en
            'ddbillfor.Enabled = en
            txtbillno.Enabled = en
            txtage.Enabled = en
            txtgrossamount.Enabled = en
            txtnetamount.Enabled = en
            txtdiscmanagement.Enabled = en
            txtdiscrefdoctor.Enabled = en
            txtdiscvisiteddoctor.Enabled = en
            txtremarks.Enabled = en
            chkprintremarks.Enabled = en

            txtchno.Enabled = en
            txtpaidamount.Enabled = en
            txtpmtremarks.Enabled = en

            dgitems.Enabled = en

        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtdiscmanagement_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdiscmanagement.GotFocus
        Try
            txtnetamount.Text = CDec(IIf(IsNumeric(txtgrossamount.Text), txtgrossamount.Text, 0)) -
               (CDec(IIf(IsNumeric(txtdiscmanagement.Text), txtdiscmanagement.Text, 0)) +
                CDec(IIf(IsNumeric(txtdiscrefdoctor.Text), txtdiscrefdoctor.Text, 0)) +
                 CDec(IIf(IsNumeric(txtdiscvisiteddoctor.Text), txtdiscvisiteddoctor.Text, 0)))

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtdiscrefdoctor_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdiscrefdoctor.GotFocus
        Try
            txtnetamount.Text = CDec(IIf(IsNumeric(txtgrossamount.Text), txtgrossamount.Text, 0)) -
               (CDec(IIf(IsNumeric(txtdiscmanagement.Text), txtdiscmanagement.Text, 0)) +
                CDec(IIf(IsNumeric(txtdiscrefdoctor.Text), txtdiscrefdoctor.Text, 0)) +
                 CDec(IIf(IsNumeric(txtdiscvisiteddoctor.Text), txtdiscvisiteddoctor.Text, 0)))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtdiscvisiteddoctor_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdiscvisiteddoctor.GotFocus
        Try
            txtnetamount.Text = CDec(IIf(IsNumeric(txtgrossamount.Text), txtgrossamount.Text, 0)) -
               (CDec(IIf(IsNumeric(txtdiscmanagement.Text), txtdiscmanagement.Text, 0)) +
                CDec(IIf(IsNumeric(txtdiscrefdoctor.Text), txtdiscrefdoctor.Text, 0)) +
                 CDec(IIf(IsNumeric(txtdiscvisiteddoctor.Text), txtdiscvisiteddoctor.Text, 0)))
        Catch ex As Exception

        End Try
    End Sub
    Private Sub savePayment()
        Try

            Dim param(6) As SqlParameter
            param(0) = New SqlParameter("@headerid", billheaderid)
            param(1) = New SqlParameter("@dateofpayment", dtpmt.Value)
            param(2) = New SqlParameter("@paidamount", txtpaidamount.Text)
            param(3) = New SqlParameter("@modeofpayment", ddmodeofpayment.SelectedItem)
            param(4) = New SqlParameter("@cheque_cvv_no", txtchno.Text)
            param(5) = New SqlParameter("@chequedate", dtch.Value)
            param(6) = New SqlParameter("@remarks", txtpmtremarks.Text)

            Dim dsret As DataSet
            dsret = Class1.ExecQueryDS("billpayment", Class1.CustomCommandType.StoredPorcedure, param)
            If Not dsret Is Nothing Then
                If dsret.Tables.Count > 0 And dsret.Tables(0).Rows.Count > 0 Then
                    If dsret.Tables(0).Rows(0).Item(0) = "1" Then

                        MsgBox("Payment Save Successfully!!")

                    Else
                        MsgBox("Error in payment saving!!")

                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btmpmtsave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btmpmtsave.Click
        Try
            If billheaderid < 1 Then
                Exit Sub
            End If
            savePayment()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnedit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnedit.Click

        Try
            gbSave.Visible = True
            gbinsert.Visible = False
            enabletrue(True)
            txtpatientID.Focus()
            txtpatientID.Text = ""
            patientfk = -1
            entrymode = "EDIT"
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btndelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            gbSave.Visible = True
            gbinsert.Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnreset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnreset.Click
        Try
            reset()
            enabletrue(False)
            gbinsert.Visible = True
            gbSave.Visible = False

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        Try
            'Dim par As ArrayList()


            'Class1.paramarraycrystal = New ArrayList()
            'Class1.paramarraycrystal.Add(27)
            'Class1.cReportfilename = "rpt_consbill.rpt"
            'Dim frm As New rptview()
            'frm.Show()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtpatientID_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpatientID.LostFocus
        Try
            Dim ds As DataSet
            If txtpatientID.Text.Trim() <> "" Then
                Dim param(0) As SqlParameter
                param(0) = New SqlParameter("@patientid", txtpatientID.Text)

                ds = Class1.ExecQueryDS("getpatientMasterbypatientid", Class1.CustomCommandType.StoredPorcedure, param)

                patientfk = -1
                If Not ds Is Nothing Then
                    If ds.Tables.Count > 0 And ds.Tables(0).Rows.Count > 0 Then
                        txtpatientname.Text = ds.Tables(0).Rows(0).Item("PtName")
                        txtage.Text = ds.Tables(0).Rows(0).Item("Age")
                        ddsex.SelectedItem = ds.Tables(0).Rows(0).Item("sex")
                        patientfk = ds.Tables(0).Rows(0).Item("id")
                        Class1.cPatientfk = ds.Tables(0).Rows(0).Item("id")
                        Dim param1(0) As SqlParameter
                        param1(0) = New SqlParameter("@patientfk", patientfk)

                        ds = Class1.ExecQueryDS("calculatePatientOutstanding", Class1.CustomCommandType.StoredPorcedure, param1)
                        If Not ds Is Nothing Then
                            If ds.Tables.Count > 0 And ds.Tables(0).Rows.Count > 0 Then
                                If CInt(ds.Tables(0).Rows(0).Item("outstanding")) > 0 Then
                                    MsgBox("This patient has outstanding payment of Rs." & ds.Tables(0).Rows(0).Item("outstanding"))
                                    Dim frmshowodbill As New showpendingbills()
                                    frmshowodbill.Show()
                                End If
                            End If
                        End If

                    Else
                        MsgBox("No such patient registered!!!!")
                        txtpatientname.Text = ""
                        txtage.Text = ""
                        patientfk = -1
                    End If
                Else
                    MsgBox("No such patient registered!!!!")
                    txtpatientname.Text = ""
                    txtage.Text = ""
                    patientfk = -1
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub NCDasInhouse_HandleDestroyed(sender As Object, e As EventArgs) Handles Me.HandleDestroyed

    End Sub
End Class