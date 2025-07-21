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
Public Class searchBill
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
            Dim param(5) As SqlParameter
            param(0) = New SqlParameter("@patientid", txtpatientid.Text)
            param(1) = New SqlParameter("@patientname", txtpatientname.Text)
            param(2) = New SqlParameter("@fromdate", dtfromdate.Value)
            param(3) = New SqlParameter("@todate", dttodate.Value)
            param(4) = New SqlParameter("@type", ddbilltype.SelectedItem.ToString())
            param(5) = New SqlParameter("@page", page)


            ds = Class1.ExecQueryDS("Searchbill", Class1.CustomCommandType.StoredPorcedure, param)
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
            lbltotalrecords.Text = "Total Records :"
            lbltotalrecords.Text = lbltotalrecords.Text & ":" & ds.Tables(1).Rows(0).Item(0)

            totalpage = totalcount \ 20
            If totalcount Mod 20 > 0 Then
                totalpage = totalpage + 1
            End If
            lbltotalpage.Text = "Total Page :"
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

            If e.ColumnIndex = 9 Then
                billpk = dgpatient.Rows(e.RowIndex).Cells(1).Value
                billtype1 = dgpatient.Rows(e.RowIndex).Cells(8).Value.ToString()
                If billtype1 = "Consultation" Then
                    Class1.cconsbillid = billpk
                    Dim frm As New AATC_REG_CONS
                    frm.Show()

                End If

                If billtype1 = "In-house Bill" Then
                    Class1.cpathbillid = billpk
                    Dim frm As New NCDasInhouse
                    frm.Show()

                End If
                If billtype1 = "Direct Sales Bill" Then
                    Class1.cdirectsalesbillid = billpk
                    Dim frm As New NCDasDirectBill
                    frm.Show()

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub searchpatientoutstanding_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            ddbilltype.SelectedIndex = 0
        Catch ex As Exception

        End Try
    End Sub

    Private Sub reset()
        Try
            billpk = -1
            patientfk = -1

            billtype1 = ""
        Catch ex As Exception

        End Try
    End Sub
End Class