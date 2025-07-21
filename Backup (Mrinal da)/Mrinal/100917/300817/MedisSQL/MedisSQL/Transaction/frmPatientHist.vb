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
Public Class frmPatientHist
    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles chkBowWor.CheckedChanged

    End Sub
    Private Sub populatePtHist()
        'Try
        '    Dim param(1) As SqlParameter
        '    param(0) = New SqlParameter("@areacode", "")
        '    param(1) = New SqlParameter("@areaname", "")

        '    Dim ds As DataSet
        '    ds = Class1.ExecQueryDS("SearchArea", Class1.CustomCommandType.StoredPorcedure, param)
        '    cmbAreaCode.DataSource = ds.Tables(0)
        '    cmbAreaCode.ValueMember = "areaid"
        '    cmbAreaCode.DisplayMember = "areaname"

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub fetchPatientHist()
        Try
            Dim param(0) As SqlParameter
            param(0) = New SqlParameter("PatientId", Class1.cPatientfk)
            Dim ds As DataSet
            ds = Class1.ExecQueryDS("fetchPatientHist", Class1.CustomCommandType.StoredPorcedure, param)
            'txtPatientId.text = ds.Tables(0).Rows(0).Item("PatientId") & ""
            txtDrugRec.text = ds.Tables(0).Rows(0).Item("DrugRec") & ""
            txtShortHist.Text = ds.Tables(0).Rows(0).Item("ShortHist") & ""
            'txtOnSetHist.text = ds.Tables(0).Rows(0).Item("OnSetHist") & ""
            txtOnSetPlace.Text = ds.Tables(0).Rows(0).Item("OnSetPlace") & ""
            txtOnSetIllness.Text = ds.Tables(0).Rows(0).Item("OnSetIllness") & ""
            txtOnSetOccu.Text = ds.Tables(0).Rows(0).Item("OnSetOccu") & ""
            txtOnSetOth.Text = ds.Tables(0).Rows(0).Item("OnSetOthe") & ""
            chkBowReg.Checked = ds.Tables(0).Rows(0).Item("BowReg") & ""
            chkBowCons.Checked = ds.Tables(0).Rows(0).Item("BowCons") & ""
            chkBowMuc.Checked = ds.Tables(0).Rows(0).Item("BowMuc") & ""
            chkBowWor.Checked = ds.Tables(0).Rows(0).Item("BowWor") & ""
            chkBowBlad.Checked = ds.Tables(0).Rows(0).Item("BowBlad") & ""
            cmbSupQty.Text = ds.Tables(0).Rows(0).Item("SupQty") & ""
            cmbSupCons.Text = ds.Tables(0).Rows(0).Item("SupCons") & ""
            cmbSupColo.Text = ds.Tables(0).Rows(0).Item("SupColo") & ""
            cmbSupSmel.Text = ds.Tables(0).Rows(0).Item("SupSmel") & ""
            cmbSupNat.Text = ds.Tables(0).Rows(0).Item("SupNat") & ""
            'txtAPainInt.text = ds.Tables(0).Rows(0).Item("APainInt") & ""
            'txtAPainCons.text = ds.Tables(0).Rows(0).Item("APainCons") & ""
            'txtAPainAcid.text = ds.Tables(0).Rows(0).Item("APainAcid") & ""
            'txtAPainSite.text = ds.Tables(0).Rows(0).Item("APainSite") & ""
            txtCurrMed.Text = ds.Tables(0).Rows(0).Item("CurrMedic") & ""
            chkFHPatAsth.Checked = ds.Tables(0).Rows(0).Item("FHPatAsth") & ""
            chkFHPatCOPD.Checked = ds.Tables(0).Rows(0).Item("FHPatCOPD") & ""
            chkFHPatRhin.Checked = ds.Tables(0).Rows(0).Item("FHPatRhin") & ""
            chkFHPatUrti.Checked = ds.Tables(0).Rows(0).Item("FHPatUrti") & ""
            chkFHPatEcze.Checked = ds.Tables(0).Rows(0).Item("FHPatEcze") & ""
            chkFHMatAsth.Checked = ds.Tables(0).Rows(0).Item("FHMatAsth") & ""
            chkFHMatCOPD.Checked = ds.Tables(0).Rows(0).Item("FHMatCOPD") & ""
            chkFHMatRhin.Checked = ds.Tables(0).Rows(0).Item("FHMatRhin") & ""
            chkFHMatUrti.Checked = ds.Tables(0).Rows(0).Item("FHMatUrti") & ""
            chkFHMatEcze.Checked = ds.Tables(0).Rows(0).Item("FHMatEcze") & ""
            chkEHSmok.Checked = ds.Tables(0).Rows(0).Item("EHSmok") & ""
            chkEHAlco.Checked = ds.Tables(0).Rows(0).Item("EHAlco") & ""
            chkEHOth.Checked = ds.Tables(0).Rows(0).Item("EHOth") & ""
            chkEHVeg.Checked = ds.Tables(0).Rows(0).Item("EHVeg") & ""
            chkEHNonVeg.Checked = ds.Tables(0).Rows(0).Item("EHNonVeg") & ""
            chkEHHousCountry.Checked = ds.Tables(0).Rows(0).Item("EHHousCountry") & ""
            chkEHHousTown.Checked = ds.Tables(0).Rows(0).Item("EHHousTown") & ""
            chkEHHousOld.Checked = ds.Tables(0).Rows(0).Item("EHHousOld") & ""
            chkEHHousNew.Checked = ds.Tables(0).Rows(0).Item("EHHousNew") & ""
            chkEHHousDamp.Checked = ds.Tables(0).Rows(0).Item("EHHousDamp") & ""
            chkEHHousDry.Checked = ds.Tables(0).Rows(0).Item("EHHousDry") & ""
            chkEHBedKapok.Checked = ds.Tables(0).Rows(0).Item("EHBedKapok") & ""
            chkEHBedCotton.Checked = ds.Tables(0).Rows(0).Item("EHBedCott") & ""
            chkEHBedFoam.Checked = ds.Tables(0).Rows(0).Item("EHBedFoam") & ""
            chkEHBedCoir.Checked = ds.Tables(0).Rows(0).Item("EHBedCoir") & ""
            chkEHPetDog.Checked = ds.Tables(0).Rows(0).Item("EHPetDog") & ""
            chkEHPetCat.Checked = ds.Tables(0).Rows(0).Item("EHPetCat") & ""
            chkEHPetBird.Checked = ds.Tables(0).Rows(0).Item("EHPetBird") & ""
            chkEHPetCatl.Checked = ds.Tables(0).Rows(0).Item("EHPetCatl") & ""
            chkEHPetGoat.checked = ds.Tables(0).Rows(0).Item("EHPetGoat") & ""
            chkEHPetPig.Checked = ds.Tables(0).Rows(0).Item("EHPetPig") & ""
            cmbEHInhal.Text = ds.Tables(0).Rows(0).Item("EHInhal") & ""
            cmbEHInges.Text = ds.Tables(0).Rows(0).Item("EHInges") & ""
            cmbEHCont.Text = ds.Tables(0).Rows(0).Item("EHCont") & ""
            txtPFTVc.text = ds.Tables(0).Rows(0).Item("PFTVc") & ""
            txtPFTV1.text = ds.Tables(0).Rows(0).Item("PFTV1") & ""
            txtPFTV1c.text = ds.Tables(0).Rows(0).Item("PFTV1c") & ""
            txtPFTfr.text = ds.Tables(0).Rows(0).Item("PFTfr") & ""
            chkSMKHistA.Checked = ds.Tables(0).Rows(0).Item("SMKHistA") & ""
            chkSMKHistP.Checked = ds.Tables(0).Rows(0).Item("SMKHistP") & ""
            txtTotIg.text = ds.Tables(0).Rows(0).Item("TotIg") & ""
            txtChol.text = ds.Tables(0).Rows(0).Item("Chol") & ""
            txtTry.text = ds.Tables(0).Rows(0).Item("Try") & ""
            txtHight.text = ds.Tables(0).Rows(0).Item("Hight") & ""
            txtWeight.text = ds.Tables(0).Rows(0).Item("Weight") & ""
            txtDigNot.Text = ds.Tables(0).Rows(0).Item("DigNot") & ""
            txtEOSI.text = ds.Tables(0).Rows(0).Item("EOSI") & ""
            txtWBC.text = ds.Tables(0).Rows(0).Item("WBC") & ""
            txtOccup.Text = ds.Tables(0).Rows(0).Item("Occup") & ""
            cmbInfoSID.Text = ds.Tables(0).Rows(0).Item("InfoSId") & ""
            txtRefby.Text = ds.Tables(0).Rows(0).Item("RefBy") & ""

        Catch ex As Exception

        End Try
    End Sub


    Private Sub frmPatientHist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fetchPatientHist()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim param(74) As SqlParameter

            param(0) = New SqlParameter(“@PatientId", Class1.cPatientID)
            param(1) = New SqlParameter(“@DrugRec", txtDrugRec.Text)
            param(2) = New SqlParameter(“@ShortHist", txtShortHist.Text)
            param(3) = New SqlParameter(“@OnSetHist", "") 'txtOnSetHist.text
            param(4) = New SqlParameter(“@OnSetPlace", txtOnSetPlace.Text)
            param(5) = New SqlParameter(“@OnSetIllness", txtOnSetIllness.Text)
            param(6) = New SqlParameter(“@OnSetOccu", txtOnSetOccu.Text)
            param(7) = New SqlParameter(“@OnSetOthe", txtOnSetOth.Text)
            param(8) = New SqlParameter(“@BowReg", chkBowReg.Checked)
            param(9) = New SqlParameter(“@BowCons", chkBowCons.Checked)
            param(10) = New SqlParameter(“@BowMuc", chkBowMuc.Checked)
            param(11) = New SqlParameter(“@BowWor", chkBowWor.Checked)
            param(12) = New SqlParameter(“@BowBlad", chkBowBlad.Checked)
            param(13) = New SqlParameter(“@SupQty", cmbSupQty.Text)
            param(14) = New SqlParameter(“@SupCons", cmbSupCons.Text)
            param(15) = New SqlParameter(“@SupColo", cmbSupColo.Text)
            param(16) = New SqlParameter(“@SupSmel", cmbSupSmel.Text)
            param(17) = New SqlParameter(“@SupNat", cmbSupNat.Text)
            param(18) = New SqlParameter(“@APainInt", "") 'txtAPainInt.text
            param(19) = New SqlParameter(“@APainCons", "") 'txtAPainCons.text)
            param(20) = New SqlParameter(“@APainAcid", "") 'txtAPainAcid.text)
            param(21) = New SqlParameter(“@APainSite", "") 'txtAPainSite.text)
            param(22) = New SqlParameter(“@CurrMedic", txtCurrMed.Text)
            param(23) = New SqlParameter(“@FHPatAsth", chkFHPatAsth.Checked)
            param(24) = New SqlParameter(“@FHPatCOPD", chkFHPatCOPD.Checked)
            param(25) = New SqlParameter(“@FHPatRhin", chkFHPatRhin.Checked)
            param(26) = New SqlParameter(“@FHPatUrti", chkFHPatUrti.Checked)
            param(27) = New SqlParameter(“@FHPatEcze", chkFHPatEcze.Checked)
            param(28) = New SqlParameter(“@FHMatAsth", chkFHMatAsth.Checked)
            param(29) = New SqlParameter(“@FHMatCOPD", chkFHMatCOPD.Checked)
            param(30) = New SqlParameter(“@FHMatRhin", chkFHMatRhin.Checked)
            param(31) = New SqlParameter(“@FHMatUrti", chkFHMatUrti.Checked)
            param(32) = New SqlParameter(“@FHMatEcze", chkFHMatEcze.Checked)
            param(33) = New SqlParameter(“@EHSmok", chkEHSmok.Checked)
            param(34) = New SqlParameter(“@EHAlco", chkEHAlco.Checked)
            param(35) = New SqlParameter(“@EHOth", chkEHOth.Checked)
            param(36) = New SqlParameter(“@EHVeg", chkEHVeg.Checked)
            param(37) = New SqlParameter(“@EHNonVeg", chkEHNonVeg.Checked)
            param(38) = New SqlParameter(“@EHHousCountry", chkEHHousCountry.Checked)
            param(39) = New SqlParameter(“@EHHousTown", chkEHHousTown.Checked)
            param(40) = New SqlParameter(“@EHHousOld", chkEHHousOld.Checked)
            param(41) = New SqlParameter(“@EHHousNew", chkEHHousNew.Checked)
            param(42) = New SqlParameter(“@EHHousDamp", chkEHHousDamp.Checked)
            param(43) = New SqlParameter(“@EHHousDry", chkEHHousDry.Checked)
            param(44) = New SqlParameter(“@EHBedKapok", chkEHBedKapok.Checked)
            param(45) = New SqlParameter(“@EHBedCott", chkEHBedCotton.Checked)
            param(46) = New SqlParameter(“@EHBedFoam", chkEHBedFoam.Checked)
            param(47) = New SqlParameter(“@EHBedCoir", chkEHBedCoir.Checked)
            param(48) = New SqlParameter(“@EHPetDog", chkEHPetDog.Checked)
            param(49) = New SqlParameter(“@EHPetCat", chkEHPetCat.Checked)
            param(50) = New SqlParameter(“@EHPetBird", chkEHPetBird.Checked)
            param(51) = New SqlParameter(“@EHPetCatl", chkEHPetCatl.Checked)
            param(52) = New SqlParameter(“@EHPetGoat", chkEHPetGoat.Checked)
            param(53) = New SqlParameter(“@EHPetPig", chkEHPetPig.Checked)
            param(54) = New SqlParameter(“@EHInhal", cmbEHInhal.Text)
            param(55) = New SqlParameter(“@EHInges", cmbEHInges.Text)
            param(56) = New SqlParameter(“@EHCont", cmbEHCont.Text)
            param(57) = New SqlParameter(“@PFTVc", txtPFTVc.Text)
            param(58) = New SqlParameter(“@PFTV1", txtPFTV1.Text)
            param(59) = New SqlParameter(“@PFTV1c", txtPFTV1c.Text)
            param(60) = New SqlParameter(“@PFTfr", txtPFTfr.Text)
            param(61) = New SqlParameter(“@SMKHistA", chkSMKHistA.Checked)
            param(62) = New SqlParameter(“@SMKHistP", chkSMKHistP.Checked)
            param(63) = New SqlParameter(“@TotIg", txtTotIg.Text)
            param(64) = New SqlParameter(“@Chol", txtChol.Text)
            param(65) = New SqlParameter(“@Try", txtTry.Text)
            param(66) = New SqlParameter(“@Hight", txtHight.Text)
            param(67) = New SqlParameter(“@Weight", txtWeight.Text)
            param(68) = New SqlParameter(“@DigNot", txtDigNot.Text)
            param(69) = New SqlParameter(“@EOSI", txtEOSI.Text)
            param(70) = New SqlParameter(“@WBC", txtWBC.Text)
            param(71) = New SqlParameter(“@Occup", txtOccup.Text)
            param(72) = New SqlParameter(“@InfoSId", cmbInfoSID.Text)
            param(73) = New SqlParameter(“@RefBy", txtRefby.Text)
            param(74) = New SqlParameter(“@Patientfk", Class1.cPatientfk)
            Dim dsret As DataSet
            dsret = Class1.ExecQueryDS("insertPatientHist", Class1.CustomCommandType.StoredPorcedure, param)
            If dsret.Tables(0).Rows(0).Item(0) = "1" Then
                MsgBox("Successfully Updated!")
            Else
                MsgBox("Error in Saving!")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
End Class