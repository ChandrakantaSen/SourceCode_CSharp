Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.IO
Imports System.Configuration
Imports utility
Public Class rptview
    Dim myRpt As New ReportDocument

    Private Sub rptview_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim strFileName As String
            Dim report = Class1.cReportfilename

            strFileName = "\Report\ReportFile\" & report ' Utility.Utility.SetBlankIfNull(Utility.Utility.GetConfigValue("strRptFilePath")) & "\" & Session("fileName")

            strFileName = GetFolder(Application.StartupPath, "MedisSQL") & strFileName  ' "


            Dim myTable As CrystalDecisions.CrystalReports.Engine.Table
            Dim myLogin As CrystalDecisions.Shared.TableLogOnInfo


            Dim paramArr As New ArrayList
            paramArr = Class1.paramarraycrystal  ' Session("param")
            'CrystalReportViewer1.HasPrintButton = True

           

            Dim i As Integer

            myRpt.Load(strFileName)

            For i = 0 To paramArr.Count - 1
                myRpt.SetParameterValue(i, paramArr.Item(i))
            Next

            For Each myTable In myRpt.Database.Tables
                myLogin = myTable.LogOnInfo
                myLogin.ConnectionInfo.DatabaseName = "medisdata" ' Utility.Utility.SetBlankIfNull(Utility.Utility.GetConfigValue("strRptDatabase"))
                myLogin.ConnectionInfo.ServerName = "mrinallap" ' Utility.Utility.SetBlankIfNull(Utility.Utility.GetConfigValue("strRptServerName"))
                myLogin.ConnectionInfo.Password = "dasmondal" ' Utility.Utility.SetBlankIfNull(Utility.Utility.GetConfigValue("strPassword"))
                myLogin.ConnectionInfo.UserID = "sa" ' Utility.Utility.SetBlankIfNull(Utility.Utility.GetConfigValue("strUser"))
                myTable.ApplyLogOnInfo(myLogin)
            Next


            CrystalReportViewer1.ReportSource = myRpt
        Catch
        End Try
    End Sub
    Public Function GetFolder(ByVal foldername As String, ByVal seekfolder As String) As String
        Try
            Dim result As String = ""
            While foldername <> ""
                Dim temp = IO.Directory.GetParent(foldername)
                If temp Is Nothing Then
                    Exit While

                End If
                foldername = IO.Directory.GetParent(foldername).FullName
                If foldername.EndsWith(seekfolder) Then
                    result = foldername
                    Exit While

                End If
            End While
            Return result
        Catch ex As Exception

        End Try
    End Function
End Class