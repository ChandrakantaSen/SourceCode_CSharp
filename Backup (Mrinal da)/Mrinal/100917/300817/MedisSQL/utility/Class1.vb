Imports System.Data.SqlClient
Public Class Class1
    Public Shared cUsername As String
    Public Shared cUserpk As String
    Public Shared cUserID As String
    Public Shared cfinyrfk As String
    Public Shared cfinyrcode As String

    Public Shared cUserSecurityFormLevel As Int32 = 4
    Public Shared cAgentMaster As Int32 = 5
    Public Shared CAreaMaster As Int16 = 7


    Public Shared CAgentID As Int16 = -1
    Public Shared CAreaID As Int16 = -1
    Public Shared CPhysID As Int16 = -1
    Public Shared CRefID As Int16 = -1
    Public Shared CLabID As Int16 = -1
    Public Shared CDosID As Int16 = -1
    Public Shared CFreqID As Int16 = -1
    Public Shared CMedPatId As Int16 = -1
    Public Shared CMedGenId As String = "-1"
    Public Shared cPatientID As String = "-1"

    Public Shared paramarraycrystal As New ArrayList
    Public Shared cReportfilename As String
    Public Shared cPatientfk As Int32 = -1

    Public Shared cdirectsalesbillid As Int32 = -1
    Public Shared cconsbillid As Int32 = -1
    Public Shared cpathbillid As Int32 = -1

    ''################### end 12112012
    Public Enum CustomCommandType
        StoredPorcedure = 1
        SQTString = 2
    End Enum
    Public Shared Function GetAccess(ByVal PageId As Int32, ByVal AccType As String,
                             ByVal emplType As String, ByVal UserPk As Int32) As Boolean
        Try
            GetAccess = False
            Dim ds As New DataSet
            Dim arParms(1) As SqlParameter

            arParms(0) = New SqlParameter("@user_pk", UserPk)
            arParms(1) = New SqlParameter("@menu_id", PageId)
            ds = ExecQueryDS("[Sp_Get_PageSecurityByUser]", CustomCommandType.StoredPorcedure, arParms)
            If Not ds Is Nothing Then
                If ds.Tables.Count > 0 Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        If UCase(AccType) = "ADD" Then
                            If ds.Tables(0).Rows(0).Item("add_val") = "1" Then
                                GetAccess = True
                            Else
                                GetAccess = False
                            End If
                        End If
                        If UCase(AccType) = "EDIT" Then
                            If ds.Tables(0).Rows(0).Item("edit_val") = "1" Then
                                GetAccess = True
                            Else
                                GetAccess = False
                            End If
                        End If
                        If UCase(AccType) = "DELETE" Then
                            If ds.Tables(0).Rows(0).Item("delete_val") = "1" Then
                                GetAccess = True
                            Else
                                GetAccess = False
                            End If
                        End If
                        If UCase(AccType) = "VIEW" Then
                            If ds.Tables(0).Rows(0).Item("view_val") = "1" Then
                                GetAccess = True
                            Else
                                GetAccess = False
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Function
    Public Class ServerProcessMessage
        Public Message As String
        Public intReturnValue As Integer
    End Class
    Public Shared Function SetMinDateIfNull(ByVal obj As Object) As DateTime
        If obj Is Nothing Or IsDBNull(obj) Then
            SetMinDateIfNull = Convert.ToDateTime("1/1/1900")
        Else
            SetMinDateIfNull = Convert.ToDateTime(obj)
        End If
        Return SetMinDateIfNull
    End Function

    Public Shared Function SetBlankIfNull(ByVal obj As Object) As String
        If obj Is Nothing Or IsDBNull(obj) Then
            SetBlankIfNull = ""
        Else
            SetBlankIfNull = obj.ToString()
        End If
        Return SetBlankIfNull
    End Function

    Public Shared Function SetNegativeOneIfNull(ByVal obj As Object) As Int32
        If obj Is Nothing Or IsDBNull(obj) Then
            SetNegativeOneIfNull = -1
        Else
            SetNegativeOneIfNull = CInt(obj)
        End If
        Return SetNegativeOneIfNull
    End Function
    Public Shared Function SetZeroIfNullforDecimal(ByVal obj As Object) As Decimal
        If obj Is Nothing Or IsDBNull(obj) Then
            SetZeroIfNullforDecimal = 0
        Else
            SetZeroIfNullforDecimal = CDec(obj)
        End If
        Return SetZeroIfNullforDecimal
    End Function
    Public Shared Function SetZeroIfNull(ByVal obj As Object) As Int32
        If obj Is Nothing Or IsDBNull(obj) Then
            SetZeroIfNull = 0
        Else
            SetZeroIfNull = CInt(obj)
        End If
        Return SetZeroIfNull
    End Function

    Public Shared Function SetZeroPointZeroIfNull(ByVal obj As Object) As Decimal
        If obj Is Nothing Or IsDBNull(obj) Then
            SetZeroPointZeroIfNull = 0.0
        ElseIf obj.ToString().Equals(String.Empty) Then
            SetZeroPointZeroIfNull = 0.0
        Else
            SetZeroPointZeroIfNull = CDec(obj)
        End If
        Return SetZeroPointZeroIfNull
    End Function

    Public Shared Function SetFalseIfNull(ByVal obj As Object) As Boolean
        If obj Is Nothing Or IsDBNull(obj) Then
            SetFalseIfNull = -1
        Else
            SetFalseIfNull = CBool(obj)
        End If
        Return SetFalseIfNull
    End Function



    Public Shared Function IsDataSetEmpty(ByVal cmdDst As DataSet) As Boolean
        If cmdDst IsNot Nothing And cmdDst.Tables.Count > 0 And cmdDst.Tables(0) IsNot Nothing And cmdDst.Tables(0).Rows.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function


    Public Shared Function GetConnnectionString(ByVal ConnStringName As String) As String
        'Return SetBlankIfNull(System.Configuration.ConfigurationManager.ConnectionStrings(ConnStringName))
        Dim constr As String
        constr = "Database=medisdata;Server=mrinallap;Integrated Security=False;User=sa;Password=dasmondal;"
        'constr = "Database=medisdata;Server=SOUMEN-PC;Integrated Security=False;User=sa;Password=dasmondal;"
        Return constr
    End Function
    Public Shared Function ExecProcMrweb(ByVal strSQL As String, ByVal cmdtype As CustomCommandType, _
                           Optional ByVal param() As SqlParameter = Nothing) As DataSet
        Dim conn As SqlConnection = Nothing
        Dim ds As DataSet = Nothing
        Try
            conn = New SqlConnection(GetConnnectionString("dbConnStrMrweb"))
            Dim cmd As New SqlCommand(strSQL, conn)

            If cmdtype.ToString = "StoredPorcedure" Then
                cmd.CommandType = CommandType.StoredProcedure
            ElseIf cmdtype.ToString = "SQTString" Then
                cmd.CommandType = CommandType.Text
            End If

            If Not param Is Nothing Then
                If param.Length > 0 Then
                    For Each par As SqlParameter In param
                        cmd.Parameters.Add(New SqlParameter(par.ParameterName, par.Value))
                    Next
                End If
            End If

            conn.Open()
            Dim da As New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds)

            conn.Close()
            conn.Dispose()
            conn = Nothing

        Catch ex As Exception
            conn.Close()
            conn.Dispose()
            conn = Nothing
        End Try

        Return ds
    End Function
    Public Shared Function ExecQueryDS(ByVal strSQL As String, _
                                ByVal cmdtype As CustomCommandType, _
                                 Optional ByVal param() As SqlParameter = Nothing) As DataSet
        Dim conn As SqlConnection = Nothing
        Dim ds As New DataSet
        Try
            conn = New SqlConnection(GetConnnectionString("dbConnStr"))
            Dim cmd As New SqlCommand(strSQL, conn)
            cmd.CommandTimeout = 500000
            If cmdtype.ToString = "StoredPorcedure" Then
                cmd.CommandType = CommandType.StoredProcedure
            ElseIf cmdtype.ToString = "SQTString" Then
                cmd.CommandType = CommandType.Text
            End If

            If Not param Is Nothing Then
                If param.Length > 0 Then
                    For Each par As SqlParameter In param
                        cmd.Parameters.Add(New SqlParameter(par.ParameterName, par.Value))
                    Next
                End If
            End If

            conn.Open()
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            da.Fill(ds)

            conn.Close()
            conn.Dispose()
            conn = Nothing

        Catch ex As Exception
            conn.Close()
            conn.Dispose()
            conn = Nothing
        End Try

        Return ds
    End Function
    Public Shared Function ExecProcgreenply(ByVal strSQL As String, ByVal cmdtype As CustomCommandType, _
                            Optional ByVal param() As SqlParameter = Nothing) As DataSet
        Dim conn As SqlConnection = Nothing
        Dim ds As DataSet = Nothing
        Try
            conn = New SqlConnection(GetConnnectionString("dbConnStrgreenply"))
            Dim cmd As New SqlCommand(strSQL, conn)

            If cmdtype.ToString = "StoredPorcedure" Then
                cmd.CommandType = CommandType.StoredProcedure
            ElseIf cmdtype.ToString = "SQTString" Then
                cmd.CommandType = CommandType.Text
            End If

            If Not param Is Nothing Then
                If param.Length > 0 Then
                    For Each par As SqlParameter In param
                        cmd.Parameters.Add(New SqlParameter(par.ParameterName, par.Value))
                    Next
                End If
            End If

            conn.Open()
            Dim da As New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds)

            conn.Close()
            conn.Dispose()
            conn = Nothing

        Catch ex As Exception
            conn.Close()
            conn.Dispose()
            conn = Nothing
        End Try

        Return ds
    End Function

    Public Shared Function ExecProc(ByVal strSQL As String, ByVal cmdtype As CustomCommandType, _
                            Optional ByVal param() As SqlParameter = Nothing) As DataSet
        Dim conn As SqlConnection = Nothing
        Dim ds As DataSet = Nothing
        Try
            conn = New SqlConnection(GetConnnectionString("dbConnStr"))
            Dim cmd As New SqlCommand(strSQL, conn)

            If cmdtype.ToString = "StoredPorcedure" Then
                cmd.CommandType = CommandType.StoredProcedure
            ElseIf cmdtype.ToString = "SQTString" Then
                cmd.CommandType = CommandType.Text
            End If

            If Not param Is Nothing Then
                If param.Length > 0 Then
                    For Each par As SqlParameter In param
                        cmd.Parameters.Add(New SqlParameter(par.ParameterName, par.Value))
                    Next
                End If
            End If

            conn.Open()
            Dim da As New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds)

            conn.Close()
            conn.Dispose()
            conn = Nothing

        Catch ex As Exception
            conn.Close()
            conn.Dispose()
            conn = Nothing
        End Try

        Return ds
    End Function
    Public Shared Function ProductDropDown(ByVal productPopulateBy As String, ByVal externalFk As Int32, ByVal companyPk As Int32, ByVal locationFk As Int32) As DataSet
        Try
            Dim ds As New DataSet
            Dim arParam(3) As SqlParameter
            arParam(0) = New SqlParameter("@pType", productPopulateBy)
            arParam(1) = New SqlParameter("@externalFk", externalFk)
            arParam(2) = New SqlParameter("@comp", companyPk)
            arParam(3) = New SqlParameter("@loca", locationFk)
            ds = ExecProc("Sp_ds_Get_Product_Dropdown", CustomCommandType.StoredPorcedure, arParam)
            Return ds
        Catch ex As Exception

        End Try
    End Function
    Public Shared Function ProductDropDown_WithSample(ByVal productPopulateBy As String, ByVal externalFk As Int32, ByVal companyPk As Int32, ByVal locationFk As Int32, ByVal ps As String) As DataSet
        Try
            Dim ds As New DataSet
            Dim arParam(4) As SqlParameter
            arParam(0) = New SqlParameter("@pType", productPopulateBy)
            arParam(1) = New SqlParameter("@externalFk", externalFk)
            arParam(2) = New SqlParameter("@comp", companyPk)
            arParam(3) = New SqlParameter("@loca", locationFk)
            arParam(4) = New SqlParameter("@ps", ps)
            ds = ExecProc("Sp_ds_Get_Product_Dropdown_PS", CustomCommandType.StoredPorcedure, arParam)
            Return ds
        Catch ex As Exception

        End Try
    End Function
    Public Shared Function ProductBatchExpiryRateFetch(ByVal productPk As Int32, ByVal externalFk As Int32, ByVal companyPk As Int32, ByVal locationFk As Int32) As DataSet
        Try
            Dim ds As New DataSet
            Dim arParam(3) As SqlParameter
            arParam(0) = New SqlParameter("@prodPk", productPk)
            arParam(1) = New SqlParameter("@externalFk", externalFk)
            arParam(2) = New SqlParameter("@comp", companyPk)
            arParam(3) = New SqlParameter("@loca", locationFk)
            ds = ExecProc("Sp_ds_Get_Product_Batch", CustomCommandType.StoredPorcedure, arParam)
            Return ds
            'batch,expirydate,rate
        Catch ex As Exception

        End Try
    End Function
    Public Shared Function ProductBatchExpiryRateFetch_Finyear(ByVal productPk As Int32, _
                                                               ByVal externalFk As Int32, _
                                                               ByVal companyPk As Int32, _
                                                               ByVal locationFk As Int32, _
                                                               ByVal finfk As Int32, _
                                                               Optional ByVal stockpk As Int32 = -1, _
                                                               Optional ByVal sdate As String = "") As DataSet
        Try
            Dim ds As New DataSet
            Dim arParam(6) As SqlParameter
            arParam(0) = New SqlParameter("@prodPk", productPk)
            arParam(1) = New SqlParameter("@externalFk", externalFk)
            arParam(2) = New SqlParameter("@comp", companyPk)
            arParam(3) = New SqlParameter("@loca", locationFk)
            arParam(4) = New SqlParameter("@finyrfk", finfk)
            arParam(5) = New SqlParameter("@stockfk", stockpk)
            arParam(6) = New SqlParameter("@sdate", sdate)
            ds = ExecProc("Sp_ds_Get_Product_Batch_Finyear", CustomCommandType.StoredPorcedure, arParam)
            Return ds
            'batch,expirydate,rate
        Catch ex As Exception

        End Try
    End Function
    Public Shared Function ProductBatchExpiryRateFetch_ByInvdate_Finyear(ByVal productPk As Int32, _
                                                               ByVal externalFk As Int32, _
                                                               ByVal companyPk As Int32, _
                                                               ByVal locationFk As Int32, _
                                                               ByVal finfk As Int32, ByVal invdate As String) As DataSet
        Try
            Dim ds As New DataSet
            Dim arParam(5) As SqlParameter
            arParam(0) = New SqlParameter("@prodPk", productPk)
            arParam(1) = New SqlParameter("@externalFk", externalFk)
            arParam(2) = New SqlParameter("@comp", companyPk)
            arParam(3) = New SqlParameter("@loca", locationFk)
            arParam(4) = New SqlParameter("@finyrfk", finfk)
            arParam(5) = New SqlParameter("@invdate", invdate)
            ds = ExecProc("Sp_ds_Get_Product_Batch_Byindate_Finyear", CustomCommandType.StoredPorcedure, arParam)
            Return ds
            'batch,expirydate,rate
        Catch ex As Exception

        End Try
    End Function
    Public Shared Function ExpiryRateFetchByProductBatchWise(ByVal productPk As Int32, ByVal ProductBatch As String, ByVal externalFk As Int32, ByVal companyPk As Int32, ByVal locationFk As Int32) As DataSet
        Try
            Dim ds As New DataSet
            Dim arParam(3) As SqlParameter
            arParam(0) = New SqlParameter("@prodPk", productPk)
            arParam(2) = New SqlParameter("@externalFk", externalFk)
            arParam(3) = New SqlParameter("@comp", companyPk)
            arParam(4) = New SqlParameter("@loca", locationFk)
            arParam(1) = New SqlParameter("@batch", ProductBatch)
            ds = ExecProc("Sp_ds_Get_Product_Batch", CustomCommandType.StoredPorcedure, arParam)
            Return ds
            'batch,expirydate,rate
        Catch ex As Exception

        End Try
    End Function
    Public Shared Function getSysParameterbytblName(ByVal tblname As String, ByVal companyPk As Int32, ByVal locationFk As Int32) As DataSet
        Dim ds As New DataSet
        Try
            Dim arParam(2) As SqlParameter
            arParam(0) = New SqlParameter("@sysp_tblname", tblname)
            arParam(1) = New SqlParameter("@comp_fk", companyPk)
            arParam(2) = New SqlParameter("@loca_fk", locationFk)
            ds = ExecProc("sp_ds_get_Sys_parameter_Bytblname", CustomCommandType.StoredPorcedure, arParam)

        Catch ex As Exception

        End Try
        Return ds
    End Function

    Public Shared Function getStateDependentSysParameter(ByVal depo_pk As Integer, ByVal companyPk As Int32, ByVal locationFk As Int32) As DataSet
        Dim ds As New DataSet
        Try
            Dim arParam(2) As SqlParameter
            arParam(0) = New SqlParameter("@depo_pk", depo_pk)
            arParam(1) = New SqlParameter("@comp_fk", companyPk)
            arParam(2) = New SqlParameter("@loca_fk", locationFk)
            ds = ExecProc("sp_ds_getStateDependentSysParameter", CustomCommandType.StoredPorcedure, arParam)

        Catch ex As Exception

        End Try
        Return ds
    End Function
    Public Shared Function sp_ds_getsys_tran_approve(ByVal empl_fk As Integer, ByVal depo_pk As Integer, ByVal companyPk As Int32, ByVal locationFk As Int32) As DataSet
        Dim ds As New DataSet
        Try
            Dim arParam(3) As SqlParameter
            arParam(0) = New SqlParameter("@empl_fk", empl_fk)
            arParam(1) = New SqlParameter("@depo_pk", depo_pk)
            arParam(2) = New SqlParameter("@comp_fk", companyPk)
            arParam(3) = New SqlParameter("@loca_fk", locationFk)
            ds = ExecProc("sp_ds_getsys_tran_approve", CustomCommandType.StoredPorcedure, arParam)

        Catch ex As Exception

        End Try
        Return ds
    End Function
    Public Shared Function sp_ds_getsys_tran_approve_New(ByVal empl_fk As Integer, _
                                                         ByVal depo_pk As Integer, _
                                                         ByVal companyPk As Int32, _
                                                         ByVal locationFk As Int32, _
                                                         ByVal tblname As String) As DataSet
        Dim ds As New DataSet
        Try
            Dim arParam(4) As SqlParameter
            arParam(0) = New SqlParameter("@empl_fk", empl_fk)
            arParam(1) = New SqlParameter("@depo_pk", depo_pk)
            arParam(2) = New SqlParameter("@comp_fk", companyPk)
            arParam(3) = New SqlParameter("@loca_fk", locationFk)
            arParam(4) = New SqlParameter("@tblname", tblname)
            ds = ExecProc("sp_ds_getsys_tran_approve_New", CustomCommandType.StoredPorcedure, arParam)

        Catch ex As Exception

        End Try
        Return ds
    End Function
    Public Shared Function documentDateChecking(ByVal dtlfklist As String, ByVal tranname As String, ByVal companyPk As Int32, ByVal locationFk As Int32) As DataSet
        Try
            Dim ds As New DataSet
            Dim arParam(3) As SqlParameter
            arParam(0) = New SqlParameter("@dtlfklist", dtlfklist)
            arParam(1) = New SqlParameter("@tranname", tranname)
            arParam(2) = New SqlParameter("@compfk", companyPk)
            arParam(3) = New SqlParameter("@locafk", locationFk)

            ds = ExecProc("sp_ds_documentDateChecking", CustomCommandType.StoredPorcedure, arParam)
            Return ds
            'batch,expirydate,rate
        Catch ex As Exception

        End Try
    End Function

    Public Shared Sub SendEmailNew(ByVal subject As String, ByVal body As String, ByVal Emailto As String)
        'Create instance of main mail message class.
        Dim mailMessage As System.Net.Mail.MailMessage = New System.Net.Mail.MailMessage()

        'Configure mail mesage
        'Set the From address with user input
        '    mailMessage.From = New System.Net.Mail.MailAddress(txtFromAddress.Text.Trim())
        'Get From address in web.config
        mailMessage.From = New System.Net.Mail.MailAddress("sumit.debnath@gmail.com")
        'Another option is the "from" attirbute in the <smtp> element in the web.config.

        'Set additinal addresses
        mailMessage.To.Add(New System.Net.Mail.MailAddress(Emailto))
        'mailMessage.CC.Add((New System.Net.Mail.MailAddress("ask.mendine@gmail.com")))
        'mailMessage.CC.Add((New System.Net.Mail.MailAddress("sumitdebnath@rediff.com")))
        'mailMessage.Bcc
        'mailMessage.ReplyTo

        'Set additional options
        mailMessage.Priority = Net.Mail.MailPriority.High
        'Text/HTML
        mailMessage.IsBodyHtml = False
        mailMessage.IsBodyHtml = True
        'Set the subjet and body text
        mailMessage.Subject = subject
        mailMessage.Body = body

        'Add one to many attachments



        'Create an instance of the SmtpClient class for sending the email
        Dim smtpClient As System.Net.Mail.SmtpClient = New System.Net.Mail.SmtpClient()
        smtpClient.EnableSsl = True
        'Use a Try/Catch block to trap sending errors
        'Especially useful when looping through multiple sends
        Try
            smtpClient.Send(mailMessage)
        Catch smtpExc As System.Net.Mail.SmtpException
            'Log error information on which email failed.
            'Response.Write(smtpExc.Message)
        Catch ex As Exception
            'Log general errors
            'Response.Write(ex.Message)
        End Try
    End Sub

    Public Shared Function checkDuplicateDocNumber(ByVal doc_no As String, ByVal locaPk As Int32, ByVal CompanyPk As Int32, ByVal mode As Int32, ByVal Doc As String, ByVal delflag As String) As DataSet
        Dim ds As New DataSet
        Dim arParms(5) As SqlParameter
        Try
            arParms(0) = New SqlParameter("@doc_no", doc_no)
            arParms(1) = New SqlParameter("@compFk", CompanyPk)
            arParms(2) = New SqlParameter("@locaFk", locaPk)
            arParms(3) = New SqlParameter("@mode", mode)
            arParms(4) = New SqlParameter("@Doc", Doc)
            arParms(5) = New SqlParameter("@Delflag", delflag)

            ds = ExecProc("SP_Get_CheckDuplicateDocNumber", CustomCommandType.StoredPorcedure, arParms)



        Catch ex As Exception

        End Try
        Return ds
    End Function
    Public Shared Function ProductBatchExpiryRateFetchWithoutCheckingQty(ByVal productPk As Int32, ByVal externalFk As Int32, ByVal companyPk As Int32, ByVal locationFk As Int32) As DataSet
        Try
            Dim ds As New DataSet
            Dim arParam(3) As SqlParameter
            arParam(0) = New SqlParameter("@prodPk", productPk)
            arParam(1) = New SqlParameter("@externalFk", externalFk)
            arParam(2) = New SqlParameter("@comp", companyPk)
            arParam(3) = New SqlParameter("@loca", locationFk)
            ds = ExecProc("Sp_ds_Get_Product_Batch_WO_Chk_Qty", CustomCommandType.StoredPorcedure, arParam)
            Return ds
            'batch,expirydate,rate
        Catch ex As Exception

        End Try
    End Function
    Public Shared Function ProductBatchExpiryRateFetchWithoutCheckingQty_Finyear(ByVal productPk As Int32,
                                                                                 ByVal externalFk As Int32,
                                                                                 ByVal companyPk As Int32,
                                                                                 ByVal locationFk As Int32,
                                                                                 ByVal finyrfk As Int32) As DataSet
        Try
            Dim ds As New DataSet
            Dim arParam(4) As SqlParameter
            arParam(0) = New SqlParameter("@prodPk", productPk)
            arParam(1) = New SqlParameter("@externalFk", externalFk)
            arParam(2) = New SqlParameter("@comp", companyPk)
            arParam(3) = New SqlParameter("@loca", locationFk)
            arParam(4) = New SqlParameter("@finyrfk", finyrfk)
            ds = ExecProc("Sp_ds_Get_Product_Batch_WO_Chk_Qty_Finyear", CustomCommandType.StoredPorcedure, arParam)
            Return ds
            'batch,expirydate,rate
        Catch ex As Exception

        End Try
    End Function
    Public Shared Function returnCurrentDate(ByVal icurrdate As Date, ByVal dtfrom As Date, ByVal dtto As Date) As Date
        Try
            If Not (icurrdate >= dtfrom And icurrdate <= dtto) Then
                icurrdate = dtto
            End If
        Catch ex As Exception

        End Try
        Return icurrdate
    End Function
    Public Shared Function NewPatId(ByVal TableName As String, ByVal IdName As String, ByVal Prefix As String,
                   ByVal datefield As Date, ByVal YrCode As Int32, ByVal MonCode As Int32, ByVal numlen As Byte) As String
        Dim sqlFilter As String
        Dim m_PrefixLen, m_TotLen As Byte, m_BaseId, m_CeilId, m_NewId As Long, m_Id As String = ""
        m_PrefixLen = Len(Prefix)
        m_TotLen = m_PrefixLen + IIf(YrCode = 2 Or YrCode = 4, YrCode, 0) _
                   + IIf(YrCode = 2 Or YrCode = 4, IIf(MonCode = 2, MonCode, 0), 0) + numlen
        sqlFilter = "Select convert(int,Right(" & IdName & ", (Len(" & IdName & ") - " _
                   & m_PrefixLen & "))) as IdNum from " & TableName &
                   " where Len(" & IdName & ") = " & numlen &
                  " order by convert(int,Right(" & IdName & ", (Len(" & IdName & ") - " _
                   & m_PrefixLen & "))) desc"
        Dim ds As DataSet
        ds = ExecQueryDS(sqlFilter, CustomCommandType.SQTString, Nothing)
        'db = CurrentDb()
        'rs = db.OpenRecordset(sqlFilter)
        If YrCode = 4 Then
            If MonCode = 2 Then
                m_BaseId = Year(datefield) * 10 ^ (numlen + 2) + Month(datefield) * 10 ^ numlen
                m_CeilId = Year(datefield) * 10 ^ (numlen + 2) + (Month(datefield) + 1) * 10 ^ numlen
            Else
                m_BaseId = Year(datefield) * 10 ^ numlen
                m_CeilId = (Year(datefield) + 1) * 10 ^ numlen
            End If
        ElseIf YrCode = 2 Then
            If MonCode = 2 Then
                m_BaseId = (Year(datefield) Mod 100) * 10 ^ (numlen + 2) + Month(datefield) * 10 ^ numlen
                m_CeilId = (Year(datefield) Mod 100) * 10 ^ (numlen + 2) + (Month(datefield) + 1) * 10 ^ numlen
            Else
                m_BaseId = (Year(datefield) Mod 100) * 10 ^ numlen
                m_CeilId = ((Year(datefield) Mod 100) + 1) * 10 ^ numlen
            End If
        Else
            m_BaseId = 0
            m_CeilId = 10 ^ numlen
        End If
        m_NewId = 0
        Dim autoid As String = ""
        If Not ds Is Nothing Then
            If ds.Tables.Count > 0 And ds.Tables(0).Rows.Count > 0 Then
                autoid = ds.Tables(0).Rows(0).Item(0)
                m_NewId = Val(Right(autoid, (m_TotLen - m_PrefixLen)))
            End If
        End If
        If m_BaseId > m_NewId Then
            m_NewId = m_BaseId + 1
        Else
            m_NewId = m_NewId + 1
        End If
        m_Id = Prefix & m_NewId.ToString().PadLeft((m_TotLen - m_PrefixLen), "0")   'Format(m_NewId, cstr((m_TotLen - m_PrefixLen), "0"))
        ''      If Not rs.BOF Then
        ''          rs.FindLast("IdNum  < " & m_CeilId)
        ''          If Not rs.NoMatch Then
        ''              m_NewId = Val(Right(rs!idnum, (m_TotLen - m_PrefixLen)))
        ''          End If
        ''      End If
        ''      If m_BaseId > m_NewId Then
        ''          m_NewId = m_BaseId + 1
        ''      Else
        ''          m_NewId = m_NewId + 1
        ''      End If
        ''m_Id = Prefix & Format(m_NewId, String((m_TotLen - m_PrefixLen), "0"))
        NewPatId = m_Id
    End Function
    Public Shared Function NewYearId(ByVal TableName As String, ByVal IdName As String, ByVal Prefix As String,
               ByVal datefield As Date, ByVal numlen As Byte) As String

        'Dim db As Database
        'Dim rs As Recordset
        Dim sqlFilter As String

        Dim m_PrefixLen, m_TotLen As Byte
        Dim m_BaseId, m_CeilId, m_NewYearId As Long
        Dim m_PrefixA, m_PrefixB, m_SuffixA, m_Id, m_ShYearA, m_ShYearB As String

        m_ShYearA = ShFYear(datefield)


        m_SuffixA = "/" & m_ShYearA
        m_PrefixLen = Len(Trim(m_SuffixA))

        m_TotLen = m_PrefixLen + numlen

        sqlFilter = "Select Top 1 convert(int,Left(" & IdName & "," & numlen &
                     ")) as IdNum from " & TableName &
                     " where Rtrim(Ltrim(Right( " & IdName & "," & m_PrefixLen & "))) = '" &
                     m_SuffixA & "' order by convert(int,Left(" & IdName & "," & numlen & ")) desc;"

        Dim ds As DataSet
        ds = ExecQueryDS(sqlFilter, CustomCommandType.SQTString, Nothing)

        m_BaseId = 0
        m_CeilId = 10 ^ numlen

        m_NewYearId = 0
        'If Not rs.BOF Then
        '    rs.FindLast("IdNum  < " & m_CeilId)
        '    If Not rs.NoMatch Then
        '        m_NewYearId = Val(Left(rs!idnum, (m_TotLen - m_PrefixLen)))
        '    End If
        'End If
        Dim autoid As String = ""
        If Not ds Is Nothing Then
            If ds.Tables.Count > 0 And ds.Tables(0).Rows.Count > 0 Then
                autoid = ds.Tables(0).Rows(0).Item(0)
                m_NewYearId = Val(Right(autoid, (m_TotLen - m_PrefixLen)))
            End If
        End If
        If m_BaseId > m_NewYearId Then
            m_NewYearId = m_BaseId + 1
        Else
            m_NewYearId = m_NewYearId + 1
        End If
        'm_Id = Format(m_NewYearId, String((m_TotLen - m_PrefixLen), "0")) & m_SuffixA
        m_Id = m_NewYearId.ToString().PadLeft((m_TotLen - m_PrefixLen), "0") & m_SuffixA
        NewYearId = m_Id
    End Function
    Public Shared Function ShFYear(ByVal Anydate As String) As String
        'Dim shm_month As Integer, shm_year As String, shm_fyear As String
        Dim fycode As String = ""
        Dim ds As DataSet
        Dim param(0) As SqlParameter
        param(0) = New SqlParameter("@anydate", Anydate)

        ds = Class1.ExecQueryDS("getfinyrbyanydate", Class1.CustomCommandType.StoredPorcedure, param)

        If Not ds Is Nothing Then
            If ds.Tables.Count > 0 And ds.Tables(0).Rows.Count > 0 Then
                fycode = ds.Tables(0).Rows(0).Item(0)

            End If
        End If
        Return fycode
    End Function
End Class
