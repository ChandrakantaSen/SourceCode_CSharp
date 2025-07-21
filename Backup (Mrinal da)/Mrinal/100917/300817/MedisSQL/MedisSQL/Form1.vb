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
Public Class Form1

    Dim conn As SqlConnection
    Dim MnuStrip As MenuStrip
    Dim MnuStripItem As ToolStripMenuItem
    Dim dsMenu As New DataSet

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub PopulateMenu(ByVal dt As DataTable, ByVal parentMenuId As Integer, ByVal parentMenuItem As ToolStripMenuItem)
        'Dim currentPage As String = Path.GetFileName(Request.Url.AbsolutePath)

        For Each row As DataRow In dt.Rows
            Dim menuItem As New ToolStripMenuItem(row("menu_name").ToString(), Nothing, New EventHandler(AddressOf ChildClick))
            menuItem.Tag = row("id").ToString()
            '   With {
            '.Tag = row("id").ToString(),
            '.Text = }
            ''menuItem.CheckOnClick as New EventHandler(AddressOf ChildClick)
            ' Event menuItem.onClick(ByVal sender As Object, ByVal e As EventArgs)
            If parentMenuId = -1 Then
                MnuStrip.Items.Add(menuItem)
                ' Dim dtChild As DataTable = Me.GetData(Integer.Parse(menuItem.Tag))
                Dim dtChild As DataTable = Me.GetData1(Integer.Parse(menuItem.Tag)).Tables(0)
                PopulateMenu(dtChild, Integer.Parse(menuItem.Tag), menuItem)
            Else
                parentMenuItem.DropDownItems.Add(menuItem)
                ' Dim dtChild As DataTable = Me.GetData(Integer.Parse(menuItem.Tag))
                Dim dtChild As DataTable = Me.GetData1(Integer.Parse(menuItem.Tag)).Tables(0)
                PopulateMenu(dtChild, Integer.Parse(menuItem.Tag), menuItem)
            End If
        Next
    End Sub
    Private Function GetData(ByVal parentMenuId As Integer) As DataTable
        Dim query As String = "SELECT [menu_name], [id] FROM [tbl_menu] WHERE parent_id = @ParentMenuId"
        Dim constr As String = ConfigurationManager.ConnectionStrings("dbConnStr").ConnectionString
        Using con As New SqlConnection(constr)
            Dim dt As New DataTable()
            Using cmd As New SqlCommand(query)
                Using sda As New SqlDataAdapter()
                    cmd.Parameters.AddWithValue("@ParentMenuId", parentMenuId)
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    sda.Fill(dt)
                End Using
            End Using
            Return dt
        End Using
    End Function
    Private Function GetData1(ByVal parentMenuId As Integer) As DataSet
        Dim dt As New DataTable()
        Dim ds As New DataSet
        Try
            Dim param(1) As SqlParameter
            param(0) = New SqlParameter("parentMenuId", parentMenuId)
            param(1) = New SqlParameter("userid", Class1.cUserpk)
            ds = Class1.ExecQueryDS("sp_fetch_menuitem", Class1.CustomCommandType.StoredPorcedure, param)

        Catch ex As Exception

        End Try
        Return ds
    End Function

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            MsgBox("closed!!")
            Application.Exit()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Try
            ToolStripStatusLabel1.Text = Class1.cUsername
            Dim connectionString As [String]
            connectionString = ConfigurationManager.ConnectionStrings("dbConnStr").ConnectionString
            conn = New SqlConnection(connectionString)

            Me.IsMdiContainer = True

            'Creating object of MenuStrip class
            MnuStrip = New MenuStrip()

            'Placing the control to the Form
            Me.Controls.Add(MnuStrip)

            Dim dt1 As DataTable = Me.GetData1(-1).Tables(0)
            PopulateMenu(dt1, -1, Nothing)
            ' The Form.MainMenuStrip property determines the merge target.
            Me.MainMenuStrip = MnuStrip



            Return


         
        Catch ex As Exception

        End Try
    End Sub
    Public Function SubMenu(ByVal mnu As ToolStripMenuItem, ByVal menu_name As String, ByVal parent_id As String) As String
        Dim Seqchild As [String] = (Convert.ToString("SELECT menu_name,id FROM tbl_menu WHERE parent_id='") & parent_id) + "'"
        'Dim dachildmnu As New SqlDataAdapter(Seqchild, conn)
        'Dim dtchild As New DataTable()
        'dachildmnu.Fill(dtchild)

        Dim ds As DataSet
        ds = Class1.ExecProc(Seqchild, Class1.CustomCommandType.StoredPorcedure, Nothing)

        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr As DataRow In ds.Tables(0).Rows
                Dim SSMenu As New ToolStripMenuItem(dr("menu_name").ToString(), Nothing, New EventHandler(AddressOf ChildClick))
                SSMenu.Tag = dr("id").ToString()
                'mnu.DropDownItems.Add(SSMenu)
                SubMenu(mnu, dr("menu_name").ToString(), dr("id").ToString())
            Next
        Else
            'Dim dr As DataRow
            'dr = dtchild.Rows(0)
            'Dim SSMenu As New ToolStripMenuItem(dr("menu_name").ToString(), Nothing, New EventHandler(AddressOf ChildClick))
            'SSMenu.Tag = dr("id").ToString()
            'mnu.DropDownItems.Add(SSMenu)

            'Dim Seqchild1 As [String] = (Convert.ToString("SELECT menu_name,id FROM tbl_menu WHERE id='") & parent_id) + "'"
            'Dim dachildmnu1 As New SqlDataAdapter(Seqchild1, conn)
            'Dim dtchild1 As New DataTable()
            'dachildmnu1.Fill(dtchild1)


            Dim SSMenu As New ToolStripMenuItem(menu_name, Nothing, New EventHandler(AddressOf ChildClick))
            SSMenu.Tag = parent_id
            mnu.DropDownItems.Add(SSMenu)
            Return menu_name
        End If
        Return menu_name
    End Function

    Private Sub ChildClick(ByVal sender As Object, ByVal e As EventArgs)
        ' MessageBox.Show(string.Concat("You have Clicked ", sender.ToString(), " Menu"), "Menu Items Event",MessageBoxButtons.OK, MessageBoxIcon.Information);
        Dim s As ToolStripMenuItem
        s = sender
        Dim id = s.Tag
        Dim Seqtx As [String] = "SELECT formname FROM tbl_menu WHERE id='" + id + "'"
        Dim datransaction As New SqlDataAdapter(Seqtx, conn)
        Dim dtransaction As New DataTable()
        datransaction.Fill(dtransaction)

        Dim frmAssembly As Assembly = Assembly.LoadFile(Application.ExecutablePath)
        For Each type As Type In frmAssembly.GetTypes()
            'MessageBox.Show(type.Name);
            If type.BaseType = GetType(Form) Then
                If type.Name = dtransaction.Rows(0)(0).ToString() Then
                    Dim frmShow As Form = DirectCast(frmAssembly.CreateInstance(type.ToString()), Form)
                    ' then when you want to close all of them simple call the below code

                    For Each form As Form In Me.MdiChildren
                        If form.Name = "AATC_REG_CONS" Then
                        Else
                            form.Close()
                        End If

                    Next

                    frmShow.MdiParent = Me
                    frmShow.WindowState = FormWindowState.Maximized
                    'frmShow.ControlBox = false;
                    frmShow.Show()
                End If
            End If
        Next
    End Sub
    
   

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel2.Text = Now.ToString("HH:mm:ss")
    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub
End Class

