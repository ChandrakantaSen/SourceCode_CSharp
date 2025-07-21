Imports System.Data.SqlClient
Public Class Utility
    Public Shared noSearchMsg As String = "No Matching Found..."
    Public Shared SampleGiftExpense As String = "SampleExpense"
    Public Shared AutoID As String = "AutoID"
    Public Const cTransderInDocType As String = "PC"
    Public Const cStockTransfer As String = "ST"
    Public Const cStockReplacement As String = "STREP"
    Public Const cStockReplacementIN As String = "PCREP"

    Public Const cReturnToCompanyDocType As String = "PR"
    Public Const cReplacementMemoChallan As String = "CR" ' For received from stockiest
    Public Const cReplacementMemoIssueChallan As String = "RC" ' For issue to stockiest
    Public Const cSalesChallan As String = "CH"
    Public Const cSalesChallanSample As String = "CS"
    Public Const cSalesChallanReturn As String = "GR"
    Public Const cSalesReturn As String = "SR"
    Public Const cReplacementFlag As String = "Y"

    Public Const cVTypeSalesInvoice As String = "S"
    Public Const cVTypePurchaseReturn As String = "PO"
    Public Const cVTypePurchaseInvoice As String = "PI"
    Public Const cCOMBO_CODE As String = "CODE"
    Public Const cCOMBO_DESC As String = "DESC"
    Public Const cCOMBO_CODEDESC As String = "CODE_DESC"
    Public Const cCOMBO_DESCCODE As String = "DESC_CODE"

    '' ############ swarup as on 12112012
    Public Const cSalesOrder As String = "SO"
    Public Const cOpeningBalance As String = "OB"
    Public Const cStockAdjustmentDamage As String = "MRD"
    Public Const cStockAdjustmentExpire As String = "MRE"
    Public Const cStockAdjustmentOther As String = "MRO"
    Public Const cSalesChallanSampleToMR As String = "CSM"
    Public Const cSalesChallanGiftToMR As String = "GSM"
    Public Const cProducttoSampleConv As String = "PSC" ' Product to sample conversion
    Public Const cStockAdjustmentProduct As String = "MRP" ' Product to sample conversion
    ''################### end 12112012
    Public Enum CustomCommandType
        StoredPorcedure = 1
        SQTString = 2
    End Enum
#Region "General_Ledgers_Constants"
    'For Types of General Ledgers
    Public Const cGLTypeCashBank As String = "Cash/Bank"
    Public Const cGLTypeControlAccount As String = "Control A/c"
    Public Const cGLTypeOther As String = "Other"
    Public Const cGLTypeAll As String = "All"
    Public Const cGLTypeNOCashBank As String = "NoCashBank"
#End Region

#Region "Constants_for_Accounts_mapped"
    Public Const cMapAccProfitAndLoss As String = "PL_AC"
    Public Const cMapAccContra As String = "CONTRA_AC"
    Public Const cMapAccCash As String = "CASH_AC"
    Public Const cMapAccSundryDebtor As String = "SD"
    Public Const cMapAccSundryCreditor As String = "SC"
    Public Const cMapAccSalesAccount As String = "S_AC"
    Public Const cMapAccPurchaseAccount As String = "P_AC"
    Public Const cMapAccSalesReturn As String = "S_RETURN"
    Public Const cMapAccPurchaseReturn As String = "P_RETURN"
    Public Const cMapAccClosingStockBS As String = "CL_BS"
    Public Const cMapAccClosingStockPL As String = "CL_PL"
    Public Const cMapAccTDSMember As String = "TDS_AC"
    Public Const cMapAccRegistrationCharges As String = "REG_CH"
    Public Const cMapAccPMTCharges As String = "PMT_CH"
    Public Const cMapAccCommPay As String = "COMM_P"
    Public Const cMapAccTDSDeduct As String = "TDS_DED"
    Public Const cMapAccSmartPay As String = "SMART_P"
    Public Const cMapAccChampionPay As String = "CHAMPION_P"
    Public Const cMapAccGoldPay As String = "GOLD_P"

    Public Const cVTypeCashBank As String = "C"
    Public Const cVTypeJournal As String = "J"
    Public Const cVTypeDrNote As String = "DN"
    Public Const cVTypeCrNote As String = "CN"
#End Region

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
        constr = "Data Source=SOUMEN-PC\MSSQLSERVER2012;Initial Catalog=medisdata;Integrated Security=False;User=sa;Password=dasmondal;"
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
            ds = Utility.ExecProc("Sp_ds_Get_Product_Dropdown", CustomCommandType.StoredPorcedure, arParam)
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
            ds = Utility.ExecProc("Sp_ds_Get_Product_Dropdown_PS", CustomCommandType.StoredPorcedure, arParam)
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
            ds = Utility.ExecProc("Sp_ds_Get_Product_Batch", CustomCommandType.StoredPorcedure, arParam)
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
            ds = Utility.ExecProc("Sp_ds_Get_Product_Batch_Finyear", CustomCommandType.StoredPorcedure, arParam)
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
            ds = Utility.ExecProc("Sp_ds_Get_Product_Batch_Byindate_Finyear", CustomCommandType.StoredPorcedure, arParam)
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
            ds = Utility.ExecProc("Sp_ds_Get_Product_Batch", CustomCommandType.StoredPorcedure, arParam)
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
            ds = Utility.ExecProc("sp_ds_get_Sys_parameter_Bytblname", CustomCommandType.StoredPorcedure, arParam)

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
            ds = Utility.ExecProc("sp_ds_getStateDependentSysParameter", CustomCommandType.StoredPorcedure, arParam)

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
            ds = Utility.ExecProc("sp_ds_getsys_tran_approve", CustomCommandType.StoredPorcedure, arParam)

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
            ds = Utility.ExecProc("sp_ds_getsys_tran_approve_New", CustomCommandType.StoredPorcedure, arParam)

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

            ds = Utility.ExecProc("sp_ds_documentDateChecking", CustomCommandType.StoredPorcedure, arParam)
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

            ds = Utility.ExecProc("SP_Get_CheckDuplicateDocNumber", CustomCommandType.StoredPorcedure, arParms)



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
            ds = Utility.ExecProc("Sp_ds_Get_Product_Batch_WO_Chk_Qty", CustomCommandType.StoredPorcedure, arParam)
            Return ds
            'batch,expirydate,rate
        Catch ex As Exception

        End Try
    End Function
    Public Shared Function ProductBatchExpiryRateFetchWithoutCheckingQty_Finyear(ByVal productPk As Int32, _
                                                                                 ByVal externalFk As Int32, _
                                                                                 ByVal companyPk As Int32, _
                                                                                 ByVal locationFk As Int32, _
                                                                                 ByVal finyrfk As Int32) As DataSet
        Try
            Dim ds As New DataSet
            Dim arParam(4) As SqlParameter
            arParam(0) = New SqlParameter("@prodPk", productPk)
            arParam(1) = New SqlParameter("@externalFk", externalFk)
            arParam(2) = New SqlParameter("@comp", companyPk)
            arParam(3) = New SqlParameter("@loca", locationFk)
            arParam(4) = New SqlParameter("@finyrfk", finyrfk)
            ds = Utility.ExecProc("Sp_ds_Get_Product_Batch_WO_Chk_Qty_Finyear", CustomCommandType.StoredPorcedure, arParam)
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
End Class
