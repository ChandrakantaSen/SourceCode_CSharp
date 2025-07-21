Imports System.Data
Imports System.Data.OleDb

Partial Class _Default
    Inherits System.Web.UI.Page
    Dim dscoll As New DataSet
    Dim cnn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dst As DataSet
    Dim adp As OleDbDataAdapter

    Sub initi()
        cnn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\hostingspaces\wbmc\wbmc.in\wwwroot\WbmcRegn.mdb;User Id=admin;Password=;")
    End Sub

    Protected Sub RadioButtonList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButtonList1.SelectedIndexChanged
        MultiView1.ActiveViewIndex = RadioButtonList1.SelectedValue
        RAppDt.Text = ""
        RRegNo.Text = ""
        RNam.Text = ""
        LNam.Text = ""
        gv.Visible = False
        PAppDt.Text = ""
        PRegNo.Text = ""
        PNam.Text = ""
        LPNam.Text = ""
        pgv.Visible = False
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MultiView1.ActiveViewIndex = RadioButtonList1.SelectedValue

    End Sub

    Protected Sub RClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RClear.Click
        RAppDt.Text = ""
        RRegNo.Text = ""
        RNam.Text = ""
        LNam.Text = ""
        gv.Visible = False
    End Sub

    Protected Sub PClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PClear.Click
        PAppDt.Text = ""
        PRegNo.Text = ""
        PNam.Text = ""
        LPNam.Text = ""
        pgv.Visible = False

    End Sub

    Protected Sub PSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PSubmit.Click
        Dim strcol As String
        strcol = "SELECT WbmcRegistrationMaster.RegMasterId, WbmcRegistrationMaster.ProvRegNo, WbmcRegistrationMaster.ProvRegDate, WbmcRegistrationMaster.FName & ' ' & WbmcRegistrationMaster.MName & ' ' & WbmcRegistrationMaster.LName AS RName, WbmcRegistrationMaster.PresentAddress, WbmcRegistrationMaster.Died, WbmcProvisionalRegistrationData.ApplicationDate, WbmcProvisionalRegistrationData.CommencementDate, WbmcProvisionalRegistrationData.ValidityDate, WbmcProvisionalRegistrationData.AppFeeRtNo, WbmcProvisionalRegistrationData.AppFeeRtDate FROM WbmcRegistrationMaster LEFT JOIN WbmcProvisionalRegistrationData ON WbmcRegistrationMaster.RegMasterId = WbmcProvisionalRegistrationData.RegMasterId WHERE (WbmcRegistrationMaster.ProvRegNo) Is Not Null AND (WbmcRegistrationMaster.Died)=False"


        If PAppDt.Text <> "" Then
            strcol = strcol & "	And (WbmcProvisionalRegistrationData.ApplicationDate)= #" & CDate(RAppDt.Text) & "#"
        End If

        If PRegNo.Text <> "" Then
            strcol = strcol & "	And (WbmcRegistrationMaster.ProvRegNo)=" & (PRegNo.Text) & "Order By "
        End If

        If PNam.Text <> "" Then
            strcol = strcol & "	AND (WbmcRegistrationMaster.FName) Like '%" & (PNam.Text) & "%'"
        End If

        If LPNam.Text <> "" Then
            strcol = strcol & "	AND (WbmcRegistrationMaster.LName) Like '%" & (LPNam.Text) & "%'"
        End If

        gv.Visible = False
        pgv.Visible = True

        initi()
        cmd = New OleDbCommand(strcol, cnn)
        dst = New DataSet
        adp = New OleDbDataAdapter(cmd)
        Try
            cnn.Open()
        Catch ex As Exception
            Response.Write("Problem in Database Connection")
        End Try
        adp.Fill(dst, "WbmcRegistrationMaster")
        Me.pgv.DataSource = dst.Tables(0)
        Me.pgv.DataBind()
        cnn.Close()

    End Sub

    Public Function DtFormat(ByVal dd As String) As String
        DtFormat = (DatePart("yyyy", CDate(dd)) * 10000) + (DatePart("m", CDate(dd)) * 100) + (DatePart("d", CDate(dd)))
    End Function

    Protected Sub RSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RSubmit.Click
        Dim strcol As String


        strcol = "SELECT WbmcRegistrationMaster.RegMasterId, WbmcRegistrationMaster.RegNo, WbmcRegistrationMaster.RegDate, WbmcRegistrationMaster.FName & ' ' & WbmcRegistrationMaster.MName & ' ' & WbmcRegistrationMaster.LName AS RName, WbmcRegistrationMaster.PresentAddress, WbmcRegistrationData.ApplicationDate, WbmcRegistrationMaster.Died, WbmcRegistrationMaster.Checked FROM WbmcRegistrationMaster LEFT JOIN WbmcRegistrationData ON WbmcRegistrationMaster.RegMasterId = WbmcRegistrationData.RegMasterId WHERE (WbmcRegistrationMaster.RegNo) Is Not Null"


        If RAppDt.Text <> "" Then
            strcol = strcol & "	And (WbmcRegistrationData.ApplicationDate)= #" & CDate(RAppDt.Text) & "#"
        End If

        If RRegNo.Text <> "" Then
            strcol = strcol & "	And (WbmcRegistrationMaster.RegNo)=" & (RRegNo.Text)
        End If

        If RNam.Text <> "" Then
            strcol = strcol & "	AND (WbmcRegistrationMaster.FName) Like '%" & (RNam.Text) & "%'"
        End If

        If LNam.Text <> "" Then
            strcol = strcol & "	AND (WbmcRegistrationMaster.LName) Like '%" & (LNam.Text) & "%'"
        End If
        pgv.Visible = False
        gv.Visible = True

        initi()
        cmd = New OleDbCommand(strcol, cnn)
        dst = New DataSet
        adp = New OleDbDataAdapter(cmd)
        Try
            cnn.Open()
        Catch ex As Exception
            Response.Write("Problem in Database Connection")
        End Try
        adp.Fill(dst, "WbmcRegistrationMaster")
        Me.gv.DataSource = dst.Tables(0)
        Me.gv.DataBind()
        cnn.Close()



    End Sub

    
    Protected Sub gv_RowEditing(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewEditEventArgs) Handles gv.RowEditing
        Dim id As String = CType(gv.DataKeys(e.NewEditIndex).Value.ToString(), Long)
        GetDetails(id)
    End Sub

    Public Sub GetDetails(ByVal id As String)

        'Dim strConn As String = "Data Source=ritusuper1;Initial Catalog=tpa;Persist Security Info=True;User ID=sa;Password=developer"
        'Dim strConn As String = ConfigurationManager.ConnectionStrings("dbcon").ConnectionString
        'Dim connection As OleDbConnection = New OleDbConnection(strConn)
        initi()
        Dim sql As String = "SELECT *  FROM WbmcRegistrationMaster WHERE RegMasterId = " & id

        Dim command As OleDbCommand = New OleDbCommand(sql, cnn)

        Dim dr As OleDbDataReader

        cnn.Open()
        dr = command.ExecuteReader()

        If dr.Read() Then
            Response.Redirect("details.aspx?RegMasterId=" & id)
        End If




        cnn.Close()

    End Sub
End Class
