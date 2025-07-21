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
Public Class RptParameter
    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        Try



            Class1.paramarraycrystal = New ArrayList()
            Class1.paramarraycrystal.Add(dtfromdate.Value)
            Class1.paramarraycrystal.Add(dttodate.Value)
            If chkAllBill.Checked Then
                Class1.paramarraycrystal.Add(-1)
            ElseIf chkRegBill.Checked = True Then
                Class1.paramarraycrystal.Add(1)
            ElseIf chkInhouseBill.Checked = True Then
                Class1.paramarraycrystal.Add(2)
            ElseIf chkDirBill.Checked = True Then
                Class1.paramarraycrystal.Add(3)
            End If
            If chkBill.Checked = True Then
                Class1.cReportfilename = "rptgeneralbillsummary.rpt"
                If chkDoctor.Checked = True Then
                    Class1.paramarraycrystal.Add(-1)
                    Class1.cReportfilename = "rpt_bill_VisitedDoctorwise.rpt"
                End If
            ElseIf chkCollection.Checked = True Then
                If chkCashCollection.Checked = True Then Class1.paramarraycrystal.Add(0)
                    If chkcardcollection.Checked = True Then Class1.paramarraycrystal.Add(1)
                    If chkallcollection.Checked = True Then Class1.paramarraycrystal.Add(-1)

                    Class1.cReportfilename = "rptgeneralcollection.rpt"
                End If

                Dim frm As New rptview()
            frm.Show()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkBill_Click(sender As Object, e As EventArgs) Handles chkBill.Click
        Try
            gbpmtmode.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkCollection_Click(sender As Object, e As EventArgs) Handles chkCollection.Click
        Try
            gbpmtmode.Enabled = True
            chkallcollection.Checked = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RptParameter_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            populatedoctor()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub populatedoctor()
        Dim param(0) As SqlParameter
        Dim inhouse As Int16 = 1
        Dim ds As DataSet
        param(0) = New SqlParameter("@visitorref", inhouse)
        ds = Class1.ExecQueryDS("getvisiteddoctor", Class1.CustomCommandType.StoredPorcedure, param)
        If Not ds Is Nothing Then
            If ds.Tables.Count > 0 And ds.Tables(0).Rows.Count > 0 Then
                Dim dr As DataRow
                dr = ds.Tables(0).NewRow()
                dr(0) = -1
                dr(1) = "Select Doctor"

                ds.Tables(0).Rows.InsertAt(dr, 0)
                dddoctor.DataSource = ds.Tables(0)
                dddoctor.DisplayMember = "refname"
                dddoctor.ValueMember = "id"
            End If
        End If

    End Sub

    Private Sub btninhdrperfmonthwise_Click_Click(sender As Object, e As EventArgs) Handles btninhdrperfmonthwise_Click.Click
        Try
            Class1.paramarraycrystal.Clear()
            Class1.paramarraycrystal.Add(dtfromdate.Value.ToShortDateString())
            Class1.paramarraycrystal.Add(dttodate.Value.ToShortDateString())
            Class1.paramarraycrystal.Add(dddoctor.SelectedValue)
            Class1.cReportfilename = "rpt_monthly_inhousedoctorsperformance.rpt"


            Dim frm As New rptview()
            frm.Show()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnindrperformance_Click_Click(sender As Object, e As EventArgs) Handles btnindrperformance_Click.Click
        Try
            Class1.paramarraycrystal.Clear()
            Class1.paramarraycrystal.Add(dtfromdate.Value.ToShortDateString())
            Class1.paramarraycrystal.Add(dttodate.Value.ToShortDateString())
            Class1.paramarraycrystal.Add(dddoctor.SelectedValue)
            Class1.cReportfilename = "rpt_datewiseinhousedoctorsperformance.rpt"


            Dim frm As New rptview()
            frm.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Try
            Class1.paramarraycrystal.Clear()
            Class1.paramarraycrystal.Add(dtfromdate.Value.ToShortDateString())
            Class1.paramarraycrystal.Add(dttodate.Value.ToShortDateString())
            'Class1.paramarraycrystal.Add(-1)
            Class1.cReportfilename = "rpt_showdiscountbill.rpt"


            Dim frm As New rptview()
            frm.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Try
            Class1.paramarraycrystal.Clear()
            Class1.paramarraycrystal.Add(dtfromdate.Value.ToShortDateString())
            Class1.paramarraycrystal.Add(dttodate.Value.ToShortDateString())
            'Class1.paramarraycrystal.Add(-1)
            Class1.cReportfilename = "rpt_repooutstandingasondate.rpt"


            Dim frm As New rptview()
            frm.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Try
            Class1.paramarraycrystal.Clear()
            Class1.paramarraycrystal.Add(dtfromdate.Value.ToShortDateString())
            Class1.paramarraycrystal.Add(dttodate.Value.ToShortDateString())
            'Class1.paramarraycrystal.Add(-1)
            Class1.cReportfilename = "rpt_repodueCollection.rpt"


            Dim frm As New rptview()
            frm.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try
            Class1.paramarraycrystal.Clear()
            Class1.paramarraycrystal.Add(dtfromdate.Value.ToShortDateString())
            Class1.paramarraycrystal.Add(dttodate.Value.ToShortDateString())
            Class1.paramarraycrystal.Add(-1)
            Class1.cReportfilename = "rpt_repotestCatwise_FULL.rpt"


            Dim frm As New rptview()
            frm.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Class1.paramarraycrystal.Clear()
            Class1.paramarraycrystal.Add(dtfromdate.Value.ToShortDateString())
            Class1.paramarraycrystal.Add(dttodate.Value.ToShortDateString())
            Class1.paramarraycrystal.Add(-1)
            Class1.cReportfilename = "rpt_repotestCatwise_month.rpt"


            Dim frm As New rptview()
            frm.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            Class1.paramarraycrystal.Clear()
            Class1.paramarraycrystal.Add(dtfromdate.Value.ToShortDateString())
            Class1.paramarraycrystal.Add(dttodate.Value.ToShortDateString())
            Class1.paramarraycrystal.Add(-1)
            Class1.cReportfilename = "rpt_repotestCatwise_itemmonthly.rpt"


            Dim frm As New rptview()
            frm.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Class1.paramarraycrystal.Clear()
            Class1.paramarraycrystal.Add(dtfromdate.Value.ToShortDateString())
            Class1.paramarraycrystal.Add(dttodate.Value.ToShortDateString())
            Class1.paramarraycrystal.Add(-1)
            Class1.cReportfilename = "rpt_repotestCatwise_item.rpt"


            Dim frm As New rptview()
            frm.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Class1.paramarraycrystal.Clear()
            Class1.paramarraycrystal.Add(dtfromdate.Value.ToShortDateString())
            Class1.paramarraycrystal.Add(dttodate.Value.ToShortDateString())
            Class1.paramarraycrystal.Add(-1)
            Class1.cReportfilename = "rpt_repotestCatwise_date.rpt"


            Dim frm As New rptview()
            frm.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim frm As New Rep_ItemwiseRegBillsSummary
            frm.txtfromdate.Text = dtfromdate.Value.ToShortDateString
            frm.txttodate.Text = dttodate.Value.ToShortDateString
            frm.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Try
            Dim frm As New Rep_ItemwisePathBillsSummary
            frm.txtfromdate.Text = dtfromdate.Value.ToShortDateString
            frm.txttodate.Text = dttodate.Value.ToShortDateString
            frm.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim frm As New Rep_ItemwiseDirBillsSummary
            frm.txtfromdate.Text = dtfromdate.Value.ToShortDateString
            frm.txttodate.Text = dttodate.Value.ToShortDateString
            frm.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Try
            Class1.paramarraycrystal.Clear()
            Class1.paramarraycrystal.Add(dtfromdate.Value.ToShortDateString())
            Class1.paramarraycrystal.Add(dttodate.Value.ToShortDateString())
            Class1.paramarraycrystal.Add(dddoctor.SelectedValue)
            Class1.cReportfilename = "rpt_inhousedoctorpercent.rpt"


            Dim frm As New rptview()
            frm.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Try
            Class1.paramarraycrystal.Clear()
            Class1.paramarraycrystal.Add(dtfromdate.Value.ToShortDateString())
            Class1.paramarraycrystal.Add(dttodate.Value.ToShortDateString())
            Class1.paramarraycrystal.Add(dddoctor.SelectedValue)
            Class1.paramarraycrystal.Add(35)
            Class1.cReportfilename = "rpt_InhousedoctComm_samepercent.rpt"


            Dim frm As New rptview()
            frm.Show()
        Catch ex As Exception

        End Try
    End Sub
End Class