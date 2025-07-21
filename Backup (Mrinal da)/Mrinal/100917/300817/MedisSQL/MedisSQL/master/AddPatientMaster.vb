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
Public Class AddPatientMaster
    Dim patientpk As String
    Public Property mypatientfk() As String
        Get
            Return patientpk
        End Get
        Set(ByVal value As String)

        End Set
    End Property
    Dim patientid As String
    Public Property mypatientid() As String
        Get
            Return patientid
        End Get
        Set(ByVal value As String)

        End Set
    End Property
    Private Sub populatecountry()
        Try
            Dim ds As DataSet
            ds = Class1.ExecQueryDS("getcountry", Class1.CustomCommandType.StoredPorcedure, Nothing)
            ddcountry.DataSource = ds.Tables(0)
            ddcountry.DisplayMember = "country"
            ddcountry.ValueMember = "id"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub populatestate()
        Try
            Dim ds As DataSet
            Dim param(0) As SqlParameter
            param(0) = New SqlParameter("@countryid", ddcountry.SelectedValue)
            ds = Class1.ExecQueryDS("getstate", Class1.CustomCommandType.StoredPorcedure, param)
            ddstate.DataSource = ds.Tables(0)
            ddstate.DisplayMember = "StateNam"
            ddstate.ValueMember = "id"
        Catch ex As Exception

        End Try
    End Sub
    Private Sub populatedistrict()
        Try
            Dim ds As DataSet
            Dim param(0) As SqlParameter
            param(0) = New SqlParameter("@statefk", ddstate.SelectedValue)
            ds = Class1.ExecQueryDS("getdistrict", Class1.CustomCommandType.StoredPorcedure, param)
            dddist.DataSource = ds.Tables(0)
            dddist.DisplayMember = "DistNam"
            dddist.ValueMember = "id"
        Catch ex As Exception

        End Try
    End Sub
    Private Sub getregisteredfordoctor()
        Try
            Dim ds As DataSet
            'Dim param(0) As SqlParameter
            'param(0) = New SqlParameter("@statefk", ddstate.SelectedValue)
            ds = Class1.ExecQueryDS("getregisteredfordoctor", Class1.CustomCommandType.StoredPorcedure, Nothing)
            Dim dr As DataRow
            dr = ds.Tables(0).NewRow()
            dr(0) = -1
            dr(1) = "Select"

            ds.Tables(0).Rows.InsertAt(dr, 0)
            ddregdoct.DataSource = ds.Tables(0)
            ddregdoct.DisplayMember = "RefName"
            ddregdoct.ValueMember = "id"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub getreferredby()
        Try
            Dim ds As DataSet
            'Dim param(0) As SqlParameter
            'param(0) = New SqlParameter("@statefk", ddstate.SelectedValue)
            ds = Class1.ExecQueryDS("getreferredby", Class1.CustomCommandType.StoredPorcedure, Nothing)
            Dim dr As DataRow
            dr = ds.Tables(0).NewRow()
            dr(0) = -1
            dr(1) = "Select"

            ds.Tables(0).Rows.InsertAt(dr, 0)
            ddrefdoct.DataSource = ds.Tables(0)
            ddrefdoct.DisplayMember = "RefName"
            ddrefdoct.ValueMember = "id"
        Catch ex As Exception

        End Try
    End Sub
    Private Sub fetchMasInfoSource()
        Try
            Dim ds As DataSet
            'Dim param(0) As SqlParameter
            'param(0) = New SqlParameter("@statefk", ddstate.SelectedValue)
            ds = Class1.ExecQueryDS("fetchMasInfoSource", Class1.CustomCommandType.StoredPorcedure, Nothing)
            Dim dr As DataRow
            dr = ds.Tables(0).NewRow()
            dr(0) = -1
            dr(1) = "Select"

            ds.Tables(0).Rows.InsertAt(dr, 0)
            ddsource.DataSource = ds.Tables(0)
            ddsource.DisplayMember = "InfoSItem"
            ddsource.ValueMember = "id"
        Catch ex As Exception

        End Try
    End Sub
    Private Sub getchildFromCode()
        Try
            Dim ds As DataSet
            Dim param(0) As SqlParameter
            param(0) = New SqlParameter("@codeparent", "PATIENTGENERATEDBY")

            ds = Class1.ExecQueryDS("getchildFromCode", Class1.CustomCommandType.StoredPorcedure, param)
            If Not ds Is Nothing Then
                If ds.Tables.Count > 0 And ds.Tables(0).Rows.Count > 0 Then
                    Dim dr As DataRow
                    dr = ds.Tables(0).NewRow()
                    dr(0) = -1
                    dr(1) = "Select"
                    ds.Tables(0).Rows.InsertAt(dr, 0)
                    ddgenerated.DataSource = ds.Tables(0)
                    ddgenerated.DisplayMember = "code_description"
                    ddgenerated.ValueMember = "code_pk"

                End If
            End If

        Catch ex As Exception

        End Try


    End Sub
    Private Sub AddPatientMaster_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            'If Class1.GetAccess(Class1.cAgentMaster, "ADD", "", Class1.cUserpk) = False Then
            '    MsgBox("No Access Rights!!")
            '    Me.BeginInvoke(New MethodInvoker(AddressOf Me.Close))
            'End If
            ddcenter.SelectedIndex = 0
            ddsex.SelectedIndex = 0
            populatecountry()
            populatestate()
            populatedistrict()
            getregisteredfordoctor()
            getreferredby()
            fetchMasInfoSource()
            getchildFromCode()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub save()
        Try
            Dim param(25) As SqlParameter

            param(0) = New SqlParameter("@PatientId", "")
            param(1) = New SqlParameter("@CenName", ddcenter.SelectedItem)
            param(2) = New SqlParameter("@OldId", txtoldid.Text)
            param(3) = New SqlParameter("@DateReg", dtreg.Value)
            param(4) = New SqlParameter("@PtName", txtname.Text)
            param(5) = New SqlParameter("@Sex", IIf(ddsex.SelectedItem = "Male", "M", "F"))

            param(6) = New SqlParameter("@PtDOB", dtdob.Value)
            param(7) = New SqlParameter("@Age", IIf(txtage.Text = "", "0", txtage.Text))
            param(8) = New SqlParameter("@AgeMon", 0)
            param(9) = New SqlParameter("@Address", txtaddress.Text)
            param(10) = New SqlParameter("@City", "")
            param(11) = New SqlParameter("@DistID", dddist.SelectedValue)

            param(12) = New SqlParameter("@Pin", "")
            param(13) = New SqlParameter("@CountryID", ddcountry.SelectedValue)
            param(14) = New SqlParameter("@StateID", ddstate.SelectedValue)
            param(15) = New SqlParameter("@RefId", ddrefdoct.Text)
            param(16) = New SqlParameter("@InfoSId", ddsource.Text)
            param(17) = New SqlParameter("@PhoneNo", txtphoneno.Text)

            param(18) = New SqlParameter("@RefFor", ddregdoct.Text)
            param(19) = New SqlParameter("@countryfk", ddcountry.SelectedValue)
            param(20) = New SqlParameter("@statefk", ddstate.SelectedValue)
            param(21) = New SqlParameter("@distfk", dddist.SelectedValue)
            param(22) = New SqlParameter("@Reffk", ddregdoct.SelectedValue)
            param(23) = New SqlParameter("@Infofk", ddsource.SelectedValue)

            param(24) = New SqlParameter("@RefForfk", ddrefdoct.SelectedValue)
            param(25) = New SqlParameter("@created_by", Class1.cUserpk)
            Dim dsret As DataSet
            dsret = Class1.ExecQueryDS("mas_insert_patient_master", Class1.CustomCommandType.StoredPorcedure, param)
            If dsret.Tables(0).Rows(0).Item(0) = "1" Then
                MsgBox("Save Successfully!")
                patientpk = dsret.Tables(0).Rows(0).Item(1)
                patientid = dsret.Tables(0).Rows(0).Item(2)
                Me.Close()
            Else
                MsgBox("Error in Saving!")
                patientpk = dsret.Tables(0).Rows(0).Item(1)
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub btncancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnsave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            Me.DialogResult = Windows.Forms.DialogResult.OK
            save()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ddcountry_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddcountry.SelectedIndexChanged
        Try
            populatestate()
            populatedistrict()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ddstate_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddstate.SelectedIndexChanged
        Try
            populatedistrict()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ddcenter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddcenter.SelectedIndexChanged

    End Sub

    Private Sub dtdob_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtdob.KeyDown
       
    End Sub

    Private Sub dtdob_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtdob.LostFocus
        Try
            Dim param(0) As SqlParameter
            param(0) = New SqlParameter("@dob", dtdob.Value)
            Dim ds As DataSet
            ds = Class1.ExecQueryDS("calculateage", Class1.CustomCommandType.StoredPorcedure, param)
            txtage.Text = ds.Tables(0).Rows(0).Item(0)

        Catch ex As Exception

        End Try
    End Sub
End Class