Imports System.Data
Imports System.Data.OleDb

Partial Class details
    Inherits System.Web.UI.Page
    Dim dscollD As New DataSet
    Dim cnnD As OleDbConnection

    Dim cmdD As OleDbCommand
    Dim adpD As OleDbDataAdapter
    Dim redD As OleDbDataReader

    Dim cmdQ As OleDbCommand
    Dim adpQ As OleDbDataAdapter
    Dim dstQ As New DataSet

    Dim cmdCH As OleDbCommand
    Dim adpCH As OleDbDataAdapter
    Dim dstCH As DataSet

    Dim cmdRE As OleDbCommand
    Dim adpRE As OleDbDataAdapter
    Dim dstRE As DataSet

    'Dim cmdR As OleDbCommand
    'Dim redR As OleDbDataReader

    Dim RegMasterId As Long

    Sub initi()
        cnnD = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\hostingspaces\wbmc\wbmc.in\wwwroot\WbmcRegn.mdb;User Id=admin;Password=;")
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim strcolD As String
        Dim strcolCH As String
        Dim strcolQ As String
        Dim strcolR As String

        RegMasterId = Request.QueryString("RegMasterId")
        strcolD = "SELECT WbmcRegistrationMaster.RegMasterId, WbmcRegistrationMaster.RegNo, WbmcRegistrationMaster.RegDate, WbmcRegistrationMaster.Title & ' ' & WbmcRegistrationMaster.FName & ' ' & WbmcRegistrationMaster.MName & ' ' & WbmcRegistrationMaster.LName AS DrNam, WbmcRegistrationMaster.FatherName, WbmcRegistrationMaster.Sex, WbmcRegistrationMaster.BirthDate, WbmcRegistrationMaster.PermanentAddress, WbmcRegistrationMaster.PresentAddress, WbmcRegistrationMaster.Phno & ' / ' & WbmcRegistrationMaster.mobno AS ContNo,  WbmcRegistrationMaster.Checked as UpdRem, WbmcRegistrationMaster.Died  FROM WbmcRegistrationMaster WHERE WbmcRegistrationMaster.RegMasterId= " & RegMasterId
        strcolQ = "SELECT AllQuali.RegMasterId, AllQuali.University, AllQuali.Institute, AllQuali.QYear, AllQuali.Quali, AllQuali.Spec FROM AllQuali  where AllQuali.RegMasterId =" & RegMasterId & " Order By AllQuali.QYear"

        strcolCH = "SELECT WbmcRegDataChange.RegMasterId, WbmcRegDataChange.ItemChanged, WbmcRegDataChange.DateofChange, WbmcRegDataChange.ItemOld, WbmcRegDataChange.ItemNew FROM WbmcRegDataChange where WbmcRegDataChange.RegMasterId = " & RegMasterId & " Order By WbmcRegDataChange.DateofChange"

        strcolR = "SELECT AllRemarks.RegMasterId, AllRemarks.AcDate, AllRemarks.Action FROM AllRemarks where AllRemarks.RegMasterId = " & RegMasterId & " Order By  AllRemarks.AcDate"

        initi()
        Try
            'cnnD.Open()
        Catch ex As Exception
            Response.Write("Problem in Database Connection")
        End Try
        cmdD = New OleDbCommand(strcolD, cnnD)
        'adpD = New OleDbDataAdapter(cmdD)


        cmdQ = New OleDbCommand(strcolQ, cnnD)
        adpQ = New OleDbDataAdapter(cmdQ)

        cmdCH = New OleDbCommand(strcolCH, cnnD)
        adpCH = New OleDbDataAdapter(cmdCH)

        cmdRE = New OleDbCommand(strcolR, cnnD)
        adpRE = New OleDbDataAdapter(cmdRE)

        dstCH = New DataSet
        dstQ = New DataSet
        dstRE = New DataSet
        '********************************************************************************************
        cnnD.Open()
        redD = cmdD.ExecuteReader()
        redD.Read()
        If redD.HasRows() Then
            txtNo.Text = redD.GetValue(1) 'dstD.Tables(0).Rows(0)("RegNo")
            txtDate.Text = redD.GetValue(2) 'dstD.Tables(0).Rows(0)("RegDate")
            txtName.Text = redD.GetValue(3) 'dstD.Tables(0).Rows(0)("DrName")
            If Not DBNull.Value.Equals(redD.GetValue(4)) Then
                txtFather.Text = redD.GetValue(4) 'dstD.Tables(0).Rows(0)("DrName")
            End If
            If redD.GetValue(5) = 1 Then
                txtSex.Text = "Male" 'dstD.Tables(0).Rows(0)("DrName")
            Else
                txtSex.Text = "Female" ' redD.GetValue(5) 'dstD.Tables(0).Rows(0)("DrName")
            End If
            If Not DBNull.Value.Equals(redD.GetValue(6)) Then
                txtDOB.Text = redD.GetValue(6) 'dstD.Tables(0).Rows(0)("DrName")
            End If
            If Not DBNull.Value.Equals(redD.GetValue(7)) Then
                txtPermanent.Text = redD.GetValue(7) 'dstD.Tables(0).Rows(0)("DrName")
            End If 
            If Not DBNull.Value.Equals(redD.GetValue(8)) Then
                txtPresent.Text = redD.GetValue(8) ', ",", "," & vbCrLf)  'dstD.Tables(0).Rows(0)("PresentAddress")
            End If
            If Not DBNull.Value.Equals(redD.GetValue(9)) Then
                txtContact.Text = redD.GetValue(9) 'dstD.Tables(5).Rows(0)("PermanentAddress")
            End If
            If Not DBNull.Value.Equals(redD.GetValue(10)) Then
                txtUpdtRem.Text = redD.GetValue(10) 'dstD.Tables(5).Rows(0)("PermanentAddress")
            End If


        End If
        '********************************************************************************************
        adpQ.Fill(dstQ, "AllQuali")
        Me.gvQuali.DataSource = dstQ.Tables(0)
        Me.gvQuali.DataBind()

        '********************************************************************************************
        adpCH.Fill(dstCH, "WbmcRegDataChange")
        Me.gvChange.DataSource = dstCH.Tables(0)
        Me.gvChange.DataBind()

        '*****************************************************************************
        adpRE.Fill(dstRE, "AllRemarks")
        Me.gvRemark.DataSource = dstRE.Tables(0)
        Me.gvRemark.DataBind()


    End Sub

End Class
