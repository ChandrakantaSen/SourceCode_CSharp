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
Public Class searchpatientoutstanding
    Dim totalcount As Int32 = 0
    Dim currentpageindex As Int32 = 1
    Dim totalpage As Int32 = 0
    Dim patientfk As Int32 = -1
    Dim billpk As Int32 = -1
    Dim billdueamount As Int32 = 0
    Dim billtype1 As String = ""
    Public Property mypatientfk() As String
        Get
            Return patientfk
        End Get
        Set(ByVal value As String)

        End Set
    End Property
    Dim patient_id As String
    Public Property mypatientid() As String
        Get
            Return patient_id
        End Get
        Set(ByVal value As String)

        End Set
    End Property
    Dim patient_name As String
    Public Property mypatient_name() As String
        Get
            Return patient_name
        End Get
        Set(ByVal value As String)

        End Set
    End Property
    Dim patientsex As String
    Public Property mypatientsex() As String
        Get
            Return patientsex
        End Get
        Set(ByVal value As String)

        End Set
    End Property
    Dim patientage As String
    Public Property mypatientage() As String
        Get
            Return patientage
        End Get
        Set(ByVal value As String)

        End Set
    End Property
    Private Function Searchdata(ByVal page As Int16) As DataSet
        Dim ds As New DataSet
        Dim dt As New DataTable
        Try
            Dim param(4) As SqlParameter
            param(0) = New SqlParameter("@patientid", txtpatientid.Text)
            param(1) = New SqlParameter("@patientname", txtpatientname.Text)
            param(2) = New SqlParameter("@fromdate", dtfromdate.Value)
            param(3) = New SqlParameter("@todate", dttodate.Value)
            param(4) = New SqlParameter("@page", page)


            ds = Class1.ExecQueryDS("SearchPatientForOutstanding", Class1.CustomCommandType.StoredPorcedure, param)
            dt = ds.Tables(0)
        Catch ex As Exception

        End Try
        Return ds

    End Function
    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        Try
            currentpageindex = 1
            Dim ds As New DataSet()
            ds = Searchdata(1)
            dgpatient.DataSource = ds.Tables(0)
            totalcount = ds.Tables(1).Rows(0).Item(0)
            lbltotalrecords.Text = lbltotalrecords.Text & ":" & ds.Tables(1).Rows(0).Item(0)

            totalpage = totalcount \ 20
            If totalcount Mod 20 > 0 Then
                totalpage = totalpage + 1
            End If
            lbltotalpage.Text = lbltotalpage.Text & ":" & totalpage
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnnext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnnext.Click
        Try
            If Me.currentpageindex < Me.totalpage Then
                Me.currentpageindex = Me.currentpageindex + 1
                Me.dgpatient.datasource = Searchdata(currentpageindex).Tables(0)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnlast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlast.Click
        Try
            'If Me.currentpageindex > 1 Then
            Me.currentpageindex = Me.totalpage
            Me.dgpatient.DataSource = Searchdata(currentpageindex).Tables(0)
            'End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        Try
            Me.currentpageindex = 1
            Me.dgpatient.DataSource = Searchdata(currentpageindex).Tables(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnprev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprev.Click
        Try
            If Me.currentpageindex > 1 Then
                Me.currentpageindex = Me.currentpageindex - 1
                Me.dgpatient.DataSource = Searchdata(currentpageindex).Tables(0)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgpatient_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgpatient.CellContentClick
        Try

            If e.ColumnIndex = 11 Then
                billpk = dgpatient.Rows(e.RowIndex).Cells(1).Value
                txtdueamount.Text = dgpatient.Rows(e.RowIndex).Cells(9).Value
                billdueamount = dgpatient.Rows(e.RowIndex).Cells(9).Value
                txtosamt.Text = dgpatient.Rows(e.RowIndex).Cells(9).Value
                txtbillno.Text = dgpatient.Rows(e.RowIndex).Cells(2).Value
                billtype1 = dgpatient.Rows(e.RowIndex).Cells(10).Value.ToString()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub searchpatientoutstanding_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            ddmodeofpayment.SelectedIndex = 0
        Catch ex As Exception

        End Try
    End Sub
    Private Sub savePayment()
        Try

            Dim param(7) As SqlParameter
            param(0) = New SqlParameter("@headerid", billpk)
            param(1) = New SqlParameter("@dateofpayment", dtpmt.Value)
            param(2) = New SqlParameter("@paidamount", txtdueamount.Text)
            param(3) = New SqlParameter("@modeofpayment", ddmodeofpayment.SelectedItem)
            param(4) = New SqlParameter("@cheque_cvv_no", txtchno.Text)
            param(5) = New SqlParameter("@chequedate", dtch.Value)
            param(6) = New SqlParameter("@remarks", txtpmtremarks.Text)
            param(7) = New SqlParameter("@type", billtype1)

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
    Private Sub btmpmtsave_Click(sender As Object, e As EventArgs) Handles btmpmtsave.Click
        Try
            If billpk < 1 Then
                MsgBox("Must select a Bill !!")
                Exit Sub
            End If
            If CInt(txtosamt.Text) < CInt(txtdueamount.Text) Then
                MsgBox("Excessive due amount is being paid!!")
                Exit Sub
            End If
            If CInt(txtdueamount.Text) = 0 Then
                MsgBox("Due amount can not be zero!!")
                Exit Sub
            End If
            If billpk > 0 Then
                savePayment()
                reset()
                '#############################
                currentpageindex = 1
                Dim ds As New DataSet()
                ds = Searchdata(1)
                dgpatient.DataSource = ds.Tables(0)
                totalcount = ds.Tables(1).Rows(0).Item(0)
                lbltotalrecords.Text = "Total Record:"
                lbltotalrecords.Text = lbltotalrecords.Text & ":" & ds.Tables(1).Rows(0).Item(0)

                totalpage = totalcount \ 20
                If totalcount Mod 20 > 0 Then
                    totalpage = totalpage + 1
                End If
                lbltotalpage.Text = "Total Page:"
                lbltotalpage.Text = lbltotalpage.Text & ":" & totalpage

                '#############################
            Else

            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub reset()
        Try
            billpk = -1
            patientfk = -1
            txtosamt.Text = "0"
            txtdueamount.Text = "0"
            txtbillno.Text = ""
            txtchno.Text = ""
            ddmodeofpayment.SelectedIndex = 0
            txtpmtremarks.Text = ""
            billtype1 = ""
        Catch ex As Exception

        End Try
    End Sub
End Class