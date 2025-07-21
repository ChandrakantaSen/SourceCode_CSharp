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
Public Class searchpatient
    Dim totalcount As Int32 = 0
    Dim currentpageindex As Int32 = 1
    Dim totalpage As Int32 = 0
    Dim patientfk As String
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
            Dim param(2) As SqlParameter
            param(0) = New SqlParameter("@patientid", txtpatientid.Text)
            param(1) = New SqlParameter("@patientname", txtpatientname.Text)
            param(2) = New SqlParameter("@page", page)


            ds = Class1.ExecQueryDS("searchPatient", Class1.CustomCommandType.StoredPorcedure, param)
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
           
            If e.ColumnIndex = 6 Then

                'If Class1.GetAccess(Class1.cAgentMaster, "Edit", "", Class1.cUserpk) = False Then
                '    MsgBox("No Edit Rights!!")
                'Else

                'End If
                'Class1.CAgentID = CInt(dgpatient.Rows(e.RowIndex).Cells(0).Value)
                'Dim frm As New EditAgentMaster()
                'frm.Show()
                'frm.MdiParent = Me.MdiParent
                'Me.Close()
                Me.DialogResult = Windows.Forms.DialogResult.OK
                patientfk = dgpatient.Rows(e.RowIndex).Cells(0).Value
                patient_id = dgpatient.Rows(e.RowIndex).Cells(2).Value
                patientsex = dgpatient.Rows(e.RowIndex).Cells(4).Value
                patientage = dgpatient.Rows(e.RowIndex).Cells(5).Value
                patient_name = dgpatient.Rows(e.RowIndex).Cells(3).Value
                Me.Close()

            End If
        Catch ex As Exception

        End Try
    End Sub

   

   
End Class