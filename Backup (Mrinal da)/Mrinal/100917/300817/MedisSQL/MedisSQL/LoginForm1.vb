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
Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Class1.cUsername = UsernameTextBox.Text
        Dim ds As DataSet
        Dim param(1) As SqlParameter
        UsernameTextBox.Text = "Admin"
        PasswordTextBox.Text = "welcome"
        param(0) = New SqlParameter("@userId", UsernameTextBox.Text)
        param(1) = New SqlParameter("@userPwd", PasswordTextBox.Text)
        ds = Class1.ExecQueryDS("sp_VerifyUser", Class1.CustomCommandType.StoredPorcedure, param)
        If Not ds Is Nothing Then
            If ds.Tables.Count > 0 Then
                If ds.Tables(0).Rows.Count > 0 Then
                    Class1.cUserID = ds.Tables(0).Rows(0).Item("user_id").ToString()
                    Class1.cUserpk = ds.Tables(0).Rows(0).Item("id").ToString()
                    Class1.cfinyrfk = ddfinyear.SelectedValue.ToString()
                    Class1.cfinyrcode = ddfinyear.SelectedItem.ToString
                Else
                    MsgBox("Invalid User ID/Password!!")
                    Exit Sub
                End If
            Else
                MsgBox("Invalid User ID/Password!!")
                Exit Sub
            End If
        Else
            MsgBox("Invalid User ID/Password!!")
            Exit Sub
        End If

        Dim frmShow As Form = New Form1()
        frmShow.Show()
        'Me.Close()
        Me.Hide()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            populatefinancialyear()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub populatefinancialyear()
        Try
            Dim ds As DataSet
            ds = Class1.ExecQueryDS("SP_get_FinancialYear", Class1.CustomCommandType.StoredPorcedure, Nothing)
            ddfinyear.DataSource = ds.Tables(0)
            ddfinyear.DisplayMember = "mfny_fin_year"
            ddfinyear.ValueMember = "mfny_pk"
        Catch ex As Exception

        End Try
    End Sub
End Class
