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
Public Class frmPtData

    Dim dt As New DataTable
    Dim dtDrugs As New DataTable
    Dim dtvac As New DataTable
    Private Sub frmPtData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        populatesymtom()
        populatesymtomType()
        populateMedicine()
        populateAllergen()
        getregisteredfordoctor()
        populateSeason()
        dt.Columns.Add("Symtom")
        dt.Columns.Add("Symtomtype")
        dt.Columns.Add("Dur")
        dt.Columns.Add("SP")
        dt.AcceptChanges()
        dtDrugs.Columns.Add("SlNo")
        dtDrugs.Columns.Add("MedId")
        dtDrugs.Columns.Add("Dosage")
        dtDrugs.Columns.Add("DType")
        dtDrugs.Columns.Add("FreqId")
        dtDrugs.Columns.Add("Duration")
        dtDrugs.Columns.Add("dwm")
        dtDrugs.Columns.Add("abmeal")
        dtDrugs.Columns.Add("MedDesc")
        dtDrugs.AcceptChanges()
        dtvac.Columns.Add("Allerid")
        dtvac.Columns.Add("VaxValue")
        dtvac.AcceptChanges()
        populatePtData()
    End Sub
    Private Sub getregisteredfordoctor()
        Try
            Dim ds As DataSet
            Dim param(0) As SqlParameter
            param(0) = New SqlParameter("@visitorref", 1)
            ds = Class1.ExecQueryDS("getVisiteddoctor", Class1.CustomCommandType.StoredPorcedure, param)
            Dim dr As DataRow
            dr = ds.Tables(0).NewRow()
            dr(0) = -1
            dr(1) = "Select"

            ds.Tables(0).Rows.InsertAt(dr, 0)
            PhysicianIdCmb.DataSource = ds.Tables(0)
            PhysicianIdCmb.DisplayMember = "RefName"
            PhysicianIdCmb.ValueMember = "id"
            ReftoCmb.DataSource = ds.Tables(0)
            ReftoCmb.DisplayMember = "RefName"
            ReftoCmb.ValueMember = "id"
        Catch ex As Exception

        End Try
    End Sub
    Private Sub populatePtData()
        Try
            Dim param(0) As SqlParameter
            param(0) = New SqlParameter("PatientId", Class1.cPatientfk)
            Dim ds As DataSet
            ds = Class1.ExecQueryDS("fetchPatientDt", Class1.CustomCommandType.StoredPorcedure, param)
            If ds.Tables(0).Rows.Count.ToString() > 0 Then
                PatientIdTextBox.Text = ds.Tables(0).Rows(0).Item("PatientId") & ""
                DateVisitDateTimePicker.Value = ds.Tables(0).Rows(0).Item("DateVisit") & ""
                PhysicianIdCmb.SelectedValue = ds.Tables(0).Rows(0).Item("Physicianfk")
                PtSexTextBox.Text = ds.Tables(0).Rows(0).Item("PtSex") & ""
                PtAgeTextBox.Text = ds.Tables(0).Rows(0).Item("PtAge") & ""
                PtAgeMonTextBox.Text = ds.Tables(0).Rows(0).Item("PtAgeMon") & ""
                PtHeightTextBox.Text = ds.Tables(0).Rows(0).Item("PtHeight") & ""
                PtWeightTextBox.Text = ds.Tables(0).Rows(0).Item("PtWeight") & ""
                VisitDoneCheckBox.Checked = ds.Tables(0).Rows(0).Item("VisitDone") & ""
                SeasIDCmb.SelectedValue = ds.Tables(0).Rows(0).Item("SeasID") & ""
                OcrDayCheckBox.Checked = ds.Tables(0).Rows(0).Item("OcrDay") & ""
                OcrNightCheckBox.Checked = ds.Tables(0).Rows(0).Item("OcrNight") & ""
                OcrAnyCheckBox.Checked = ds.Tables(0).Rows(0).Item("OcrAny") & ""
                OcrEMCheckBox.Checked = ds.Tables(0).Rows(0).Item("OcrEM") & ""
                OcrEveCheckBox.Checked = ds.Tables(0).Rows(0).Item("OcrEve") & ""
                ErythemaCheckBox.Checked = ds.Tables(0).Rows(0).Item("Erythema") & ""
                DermatographismCheckBox.Checked = ds.Tables(0).Rows(0).Item("Dermatographism") & ""
                PallorCheckBox.Checked = ds.Tables(0).Rows(0).Item("Pallor") & ""
                OedemaCheckBox.Checked = ds.Tables(0).Rows(0).Item("Oedema") & ""
                ClubbingCheckBox.Checked = ds.Tables(0).Rows(0).Item("Clubbing") & ""
                BPHisTextBox.Text = ds.Tables(0).Rows(0).Item("BPHis") & ""
                BPDHisTextBox.Text = ds.Tables(0).Rows(0).Item("BPDHis") & ""
                BPPlsTextBox.Text = ds.Tables(0).Rows(0).Item("BPPls") & ""
                MucousMembraneTextBox.Text = ds.Tables(0).Rows(0).Item("MucousMembrane") & ""
                NoseTextBox.Text = ds.Tables(0).Rows(0).Item("Nose") & ""
                ThroatTextBox.Text = ds.Tables(0).Rows(0).Item("Throat") & ""
                AirEntryTextBox.Text = ds.Tables(0).Rows(0).Item("AirEntry") & ""
                ChestTextBox.Text = ds.Tables(0).Rows(0).Item("Chest") & ""
                OtherPhysicalTextBox.Text = ds.Tables(0).Rows(0).Item("OtherPhysical") & ""
                PhysNotesTextBox.Text = ds.Tables(0).Rows(0).Item("PhysNotes") & ""
                NotesTextBox.Text = ds.Tables(0).Rows(0).Item("Notes") & ""
                AdviceTextBox.Text = ds.Tables(0).Rows(0).Item("Advice") & ""
                ReftoCmb.SelectedValue = IIf(IsDBNull(ds.Tables(0).Rows(0).Item("RefTofk")), 0, ds.Tables(0).Rows(0).Item("RefTofk"))
                txtpatientname.Text = ds.Tables(0).Rows(0).Item("PtName") & ""

                'dtDrugs.Columns.Add("SlNo")
                'dtDrugs.Columns.Add("MedId")
                'dtDrugs.Columns.Add("Dosage")
                'dtDrugs.Columns.Add("DType")
                'dtDrugs.Columns.Add("FreqId")
                'dtDrugs.Columns.Add("Duration")
                'dtDrugs.Columns.Add("dwm")
                'dtDrugs.Columns.Add("abmeal")
                'dtDrugs.Columns.Add("MedDesc")
                Dim dr As DataRow

                If ds.Tables(1).Rows.Count.ToString() > 0 Then
                    'dgDrugs.DataSource = ds.Tables(1)
                    For i = 0 To ds.Tables(1).Rows.Count - 1
                        dr = dtDrugs.NewRow()
                        dr("SlNo") = ds.Tables(1).Rows(i).Item("SlNo")
                        dr("MedId") = ds.Tables(1).Rows(i).Item("MedId")
                        dr("Dosage") = ds.Tables(1).Rows(i).Item("Dosage")
                        dr("DType") = ds.Tables(1).Rows(i).Item("DType")
                        dr("FreqId") = ds.Tables(1).Rows(i).Item("FreqId")
                        dr("Duration") = ds.Tables(1).Rows(i).Item("Duration")
                        dr("dwm") = ds.Tables(1).Rows(i).Item("dwm")
                        dr("abmeal") = ds.Tables(1).Rows(i).Item("abmeal")
                        dr("MedDesc") = ds.Tables(1).Rows(i).Item("MedDesc")

                        dtDrugs.Rows.Add(dr)
                    Next
                    dgDrugs.DataSource = dtDrugs
                End If
            End If
            PatientIdTextBox.Text = Class1.cPatientfk
        Catch ex As Exception

        End Try
    End Sub
    Private Sub populatesymtom()
        Try
            Dim ds As DataSet
            'Dim param(0) As SqlParameter
            'param(0) = New SqlParameter("@countryid", ddcountry.SelectedValue)
            ds = Class1.ExecQueryDS("GetSymtom", Class1.CustomCommandType.StoredPorcedure)
            cmbSymtom.DataSource = ds.Tables(0)
            cmbSymtom.DisplayMember = "Symtoms"
            cmbSymtom.ValueMember = "Symtoms"
        Catch ex As Exception

        End Try
    End Sub
    Private Sub populateAllergen()
        Try
            Dim ds As DataSet
            'Dim param(0) As SqlParameter
            'param(0) = New SqlParameter("@countryid", ddcountry.SelectedValue)
            ds = Class1.ExecQueryDS("Allergen", Class1.CustomCommandType.StoredPorcedure)
            CmbAllerid.DataSource = ds.Tables(0)
            CmbAllerid.DisplayMember = "[local name]"
            CmbAllerid.ValueMember = "AllerId"
        Catch ex As Exception

        End Try
    End Sub
    Private Sub populateSeason()
        Try
            Dim ds As DataSet
            'Dim param(0) As SqlParameter
            'param(0) = New SqlParameter("@countryid", ddcountry.SelectedValue)
            ds = Class1.ExecQueryDS("FetchSeason", Class1.CustomCommandType.StoredPorcedure)
            SeasIDCmb.DataSource = ds.Tables(0)
            SeasIDCmb.DisplayMember = "SeasNam"
            SeasIDCmb.ValueMember = "SeasId"
        Catch ex As Exception

        End Try
    End Sub
    Private Sub populateMedicine()
        Try
            Dim dsm As DataSet
            Dim dsf As DataSet
            Dim dsd As DataSet
            ' Dim param(0) As SqlParameter
            'param(0) = New SqlParameter("@countryid", ddcountry.SelectedValue)
            dsm = Class1.ExecQueryDS("MedPatMasPt", Class1.CustomCommandType.StoredPorcedure)
            MedIdComboBox.DataSource = dsm.Tables(0)
            MedIdComboBox.DisplayMember = "Pnam"
            MedIdComboBox.ValueMember = "MedPatId"

            dsf = Class1.ExecQueryDS("MedFreqMas", Class1.CustomCommandType.StoredPorcedure)
            FreqIdComboBox.DataSource = dsf.Tables(0)
            FreqIdComboBox.DisplayMember = "Frequency"
            FreqIdComboBox.ValueMember = "Freqid"

            dsd = Class1.ExecQueryDS("MedDosTypeMas", Class1.CustomCommandType.StoredPorcedure)
            DTypeComboBox.DataSource = dsd.Tables(0)
            DTypeComboBox.DisplayMember = "DosType"
            DTypeComboBox.ValueMember = "DosID"
        Catch ex As Exception

        End Try
    End Sub
    Private Sub populatesymtomType()
        Try
            Dim dss As DataSet
            ' Dim param(0) As SqlParameter
            'param(0) = New SqlParameter("@countryid", ddcountry.SelectedValue)
            dss = Class1.ExecQueryDS("GetSymtomType", Class1.CustomCommandType.StoredPorcedure)
            cmbSymtomType.DataSource = dss.Tables(0)
            cmbSymtomType.DisplayMember = "SymtomType"
            cmbSymtomType.ValueMember = "SymtomType"
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnaddGv_Click(sender As Object, e As EventArgs) Handles btnaddGv.Click
        Dim dr As DataRow
        dr = dt.NewRow()
        dr("Symtom") = cmbSymtom.Text
        dr("SymtomType") = cmbSymtomType.Text
        dr("Dur") = txtDur.Text
        dr("sp") = cmbSP.Text
        dt.Rows.Add(dr)
        dt.AcceptChanges()
        dgSymtom.DataSource = dt

    End Sub

    Private Sub btnMediAdd_Click(sender As Object, e As EventArgs) Handles btnMediAdd.Click
        Dim dr As DataRow
        dr = dtDrugs.NewRow()
        dr("SlNo") = SlNoTextBox.Text
        dr("MedId") = MedIdComboBox.Text
        dr("Dosage") = DosageTextBox.Text
        dr("DType") = DTypeComboBox.Text
        dr("FreqId") = FreqIdComboBox.Text
        dr("Duration") = DurationTextBox.Text
        dr("dwm") = DwmComboBox.Text
        dr("abmeal") = AbmealTextBox.Text
        dr("MedDesc") = MedDescTextBox.Text
        dtDrugs.Rows.Add(dr)
        dtDrugs.AcceptChanges()
        dgDrugs.DataSource = dtDrugs

    End Sub

    Private Sub btnVacAdd_Click(sender As Object, e As EventArgs) Handles btnVacAdd.Click
        Dim dr As DataRow
        dr = dtvac.NewRow()
        dr("Allerid") = CmbAllerid.Text
        dr("VaxValue") = cmbVaxValue.Text
        dtvac.Rows.Add(dr)
        dtvac.AcceptChanges()
        dgSymtom.DataSource = dtvac
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdHistory_Click(sender As Object, e As EventArgs) Handles cmdHistory.Click
        Try
            Dim frm As New frmPatientHist
            Class1.cPatientID = PatientIdTextBox.Text
            frm.Show()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class