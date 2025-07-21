<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NCDasInhouse
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgitems = New System.Windows.Forms.DataGridView()
        Me.txtpatientname = New System.Windows.Forms.TextBox()
        Me.ddsex = New System.Windows.Forms.ComboBox()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.txtage1 = New System.Windows.Forms.TextBox()
        Me.txtvisiteddoctorid = New System.Windows.Forms.TextBox()
        Me.txtvisiteddoctorname = New System.Windows.Forms.TextBox()
        Me.txtrefdoctorid = New System.Windows.Forms.TextBox()
        Me.txtlabid = New System.Windows.Forms.TextBox()
        Me.txtrefdoctorname = New System.Windows.Forms.TextBox()
        Me.txtlabname = New System.Windows.Forms.TextBox()
        Me.ddagent = New System.Windows.Forms.ComboBox()
        Me.ddbookfor = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtpatientID = New System.Windows.Forms.TextBox()
        Me.txtpatientoldid = New System.Windows.Forms.TextBox()
        Me.dtproposeddate = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtremarks = New System.Windows.Forms.TextBox()
        Me.txtdiscvisiteddoctor = New System.Windows.Forms.TextBox()
        Me.txtdiscrefdoctor = New System.Windows.Forms.TextBox()
        Me.txtdiscmanagement = New System.Windows.Forms.TextBox()
        Me.txtnetamount = New System.Windows.Forms.TextBox()
        Me.gbinsert = New System.Windows.Forms.GroupBox()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btninsert = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.chkprintremarks = New System.Windows.Forms.CheckBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtbilltime = New System.Windows.Forms.TextBox()
        Me.txtbooktime = New System.Windows.Forms.TextBox()
        Me.txtgrossamount = New System.Windows.Forms.TextBox()
        Me.gbSave = New System.Windows.Forms.GroupBox()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.gbpaymentdetails = New System.Windows.Forms.GroupBox()
        Me.txtpmtremarks = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btmpmtsave = New System.Windows.Forms.Button()
        Me.dtch = New System.Windows.Forms.DateTimePicker()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtchno = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.ddmodeofpayment = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtpaidamount = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.dtpmt = New System.Windows.Forms.DateTimePicker()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.dtbilldate = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtbillno = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.dtcollection = New System.Windows.Forms.DateTimePicker()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtcollectiontime = New System.Windows.Forms.TextBox()
        Me.Itemdescription = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Deliv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeliveryDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DelivfromLab = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.testdoneat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.senttolab = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgitems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbinsert.SuspendLayout()
        Me.gbSave.SuspendLayout()
        Me.gbpaymentdetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(402, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bill ID"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(667, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(232, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(232, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Sex"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(232, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Age"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(449, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Visited Doctor"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(449, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 31)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Ref. By Doctor"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(449, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 31)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Laboratory"
        Me.Label8.Visible = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(449, 186)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 31)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Agent"
        Me.Label9.Visible = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(449, 217)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 31)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "For"
        Me.Label10.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox1.Controls.Add(Me.dgitems)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 271)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(473, 186)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List of Items"
        '
        'dgitems
        '
        Me.dgitems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgitems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Itemdescription, Me.amount, Me.Deliv, Me.DeliveryDate, Me.DelivfromLab, Me.testdoneat, Me.senttolab, Me.Delete})
        Me.dgitems.Location = New System.Drawing.Point(7, 20)
        Me.dgitems.MultiSelect = False
        Me.dgitems.Name = "dgitems"
        Me.dgitems.Size = New System.Drawing.Size(449, 150)
        Me.dgitems.TabIndex = 0
        '
        'txtpatientname
        '
        Me.txtpatientname.Location = New System.Drawing.Point(281, 59)
        Me.txtpatientname.Name = "txtpatientname"
        Me.txtpatientname.Size = New System.Drawing.Size(372, 20)
        Me.txtpatientname.TabIndex = 12
        '
        'ddsex
        '
        Me.ddsex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddsex.FormattingEnabled = True
        Me.ddsex.Items.AddRange(New Object() {"Male", "Female"})
        Me.ddsex.Location = New System.Drawing.Point(281, 85)
        Me.ddsex.Name = "ddsex"
        Me.ddsex.Size = New System.Drawing.Size(67, 21)
        Me.ddsex.TabIndex = 13
        '
        'txtage
        '
        Me.txtage.Location = New System.Drawing.Point(281, 113)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(67, 20)
        Me.txtage.TabIndex = 14
        '
        'txtage1
        '
        Me.txtage1.Location = New System.Drawing.Point(354, 112)
        Me.txtage1.Name = "txtage1"
        Me.txtage1.Size = New System.Drawing.Size(67, 20)
        Me.txtage1.TabIndex = 15
        '
        'txtvisiteddoctorid
        '
        Me.txtvisiteddoctorid.Location = New System.Drawing.Point(548, 95)
        Me.txtvisiteddoctorid.Name = "txtvisiteddoctorid"
        Me.txtvisiteddoctorid.Size = New System.Drawing.Size(67, 20)
        Me.txtvisiteddoctorid.TabIndex = 17
        '
        'txtvisiteddoctorname
        '
        Me.txtvisiteddoctorname.Location = New System.Drawing.Point(621, 96)
        Me.txtvisiteddoctorname.Name = "txtvisiteddoctorname"
        Me.txtvisiteddoctorname.Size = New System.Drawing.Size(300, 20)
        Me.txtvisiteddoctorname.TabIndex = 18
        '
        'txtrefdoctorid
        '
        Me.txtrefdoctorid.Location = New System.Drawing.Point(548, 123)
        Me.txtrefdoctorid.Name = "txtrefdoctorid"
        Me.txtrefdoctorid.Size = New System.Drawing.Size(67, 20)
        Me.txtrefdoctorid.TabIndex = 19
        '
        'txtlabid
        '
        Me.txtlabid.Location = New System.Drawing.Point(548, 157)
        Me.txtlabid.Name = "txtlabid"
        Me.txtlabid.Size = New System.Drawing.Size(67, 20)
        Me.txtlabid.TabIndex = 20
        Me.txtlabid.Visible = False
        '
        'txtrefdoctorname
        '
        Me.txtrefdoctorname.Location = New System.Drawing.Point(621, 123)
        Me.txtrefdoctorname.Name = "txtrefdoctorname"
        Me.txtrefdoctorname.Size = New System.Drawing.Size(300, 20)
        Me.txtrefdoctorname.TabIndex = 21
        '
        'txtlabname
        '
        Me.txtlabname.Location = New System.Drawing.Point(621, 157)
        Me.txtlabname.Name = "txtlabname"
        Me.txtlabname.Size = New System.Drawing.Size(300, 20)
        Me.txtlabname.TabIndex = 22
        Me.txtlabname.Visible = False
        '
        'ddagent
        '
        Me.ddagent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddagent.FormattingEnabled = True
        Me.ddagent.Items.AddRange(New Object() {"Male", "Female"})
        Me.ddagent.Location = New System.Drawing.Point(548, 186)
        Me.ddagent.Name = "ddagent"
        Me.ddagent.Size = New System.Drawing.Size(373, 21)
        Me.ddagent.TabIndex = 23
        Me.ddagent.Visible = False
        '
        'ddbookfor
        '
        Me.ddbookfor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddbookfor.FormattingEnabled = True
        Me.ddbookfor.Items.AddRange(New Object() {"Male", "Female"})
        Me.ddbookfor.Location = New System.Drawing.Point(494, 217)
        Me.ddbookfor.Name = "ddbookfor"
        Me.ddbookfor.Size = New System.Drawing.Size(179, 21)
        Me.ddbookfor.TabIndex = 24
        Me.ddbookfor.Visible = False
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 23)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Patient ID"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 82)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 23)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Old ID"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(24, 486)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(214, 23)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Proposed Last Date of Delivery :"
        '
        'txtpatientID
        '
        Me.txtpatientID.Location = New System.Drawing.Point(93, 50)
        Me.txtpatientID.Name = "txtpatientID"
        Me.txtpatientID.Size = New System.Drawing.Size(133, 20)
        Me.txtpatientID.TabIndex = 29
        '
        'txtpatientoldid
        '
        Me.txtpatientoldid.Location = New System.Drawing.Point(93, 81)
        Me.txtpatientoldid.Name = "txtpatientoldid"
        Me.txtpatientoldid.Size = New System.Drawing.Size(133, 20)
        Me.txtpatientoldid.TabIndex = 30
        '
        'dtproposeddate
        '
        Me.dtproposeddate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtproposeddate.Location = New System.Drawing.Point(244, 489)
        Me.dtproposeddate.Name = "dtproposeddate"
        Me.dtproposeddate.Size = New System.Drawing.Size(83, 20)
        Me.dtproposeddate.TabIndex = 31
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(24, 511)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 23)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Remarks"
        '
        'txtremarks
        '
        Me.txtremarks.Location = New System.Drawing.Point(27, 537)
        Me.txtremarks.Multiline = True
        Me.txtremarks.Name = "txtremarks"
        Me.txtremarks.Size = New System.Drawing.Size(267, 116)
        Me.txtremarks.TabIndex = 33
        '
        'txtdiscvisiteddoctor
        '
        Me.txtdiscvisiteddoctor.Location = New System.Drawing.Point(437, 497)
        Me.txtdiscvisiteddoctor.Name = "txtdiscvisiteddoctor"
        Me.txtdiscvisiteddoctor.Size = New System.Drawing.Size(91, 20)
        Me.txtdiscvisiteddoctor.TabIndex = 38
        '
        'txtdiscrefdoctor
        '
        Me.txtdiscrefdoctor.Location = New System.Drawing.Point(437, 523)
        Me.txtdiscrefdoctor.Name = "txtdiscrefdoctor"
        Me.txtdiscrefdoctor.Size = New System.Drawing.Size(91, 20)
        Me.txtdiscrefdoctor.TabIndex = 39
        '
        'txtdiscmanagement
        '
        Me.txtdiscmanagement.Location = New System.Drawing.Point(437, 549)
        Me.txtdiscmanagement.Name = "txtdiscmanagement"
        Me.txtdiscmanagement.Size = New System.Drawing.Size(91, 20)
        Me.txtdiscmanagement.TabIndex = 40
        '
        'txtnetamount
        '
        Me.txtnetamount.Location = New System.Drawing.Point(437, 577)
        Me.txtnetamount.Name = "txtnetamount"
        Me.txtnetamount.Size = New System.Drawing.Size(91, 20)
        Me.txtnetamount.TabIndex = 41
        '
        'gbinsert
        '
        Me.gbinsert.Controls.Add(Me.btndelete)
        Me.gbinsert.Controls.Add(Me.btnedit)
        Me.gbinsert.Controls.Add(Me.btninsert)
        Me.gbinsert.Location = New System.Drawing.Point(27, 659)
        Me.gbinsert.Name = "gbinsert"
        Me.gbinsert.Size = New System.Drawing.Size(285, 79)
        Me.gbinsert.TabIndex = 43
        Me.gbinsert.TabStop = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.Thistle
        Me.btndelete.Location = New System.Drawing.Point(190, 28)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(77, 27)
        Me.btndelete.TabIndex = 2
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.Thistle
        Me.btnedit.Location = New System.Drawing.Point(107, 28)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(77, 27)
        Me.btnedit.TabIndex = 1
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btninsert
        '
        Me.btninsert.BackColor = System.Drawing.Color.Thistle
        Me.btninsert.Location = New System.Drawing.Point(21, 28)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(77, 27)
        Me.btninsert.TabIndex = 0
        Me.btninsert.Text = "Insert"
        Me.btninsert.UseVisualStyleBackColor = False
        '
        'btnreset
        '
        Me.btnreset.BackColor = System.Drawing.Color.Thistle
        Me.btnreset.Location = New System.Drawing.Point(183, 28)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(77, 27)
        Me.btnreset.TabIndex = 5
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = False
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.Thistle
        Me.btnexit.Location = New System.Drawing.Point(100, 28)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(77, 27)
        Me.btnexit.TabIndex = 4
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.Thistle
        Me.btnsave.Location = New System.Drawing.Point(17, 28)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(77, 27)
        Me.btnsave.TabIndex = 3
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'chkprintremarks
        '
        Me.chkprintremarks.AutoSize = True
        Me.chkprintremarks.Location = New System.Drawing.Point(84, 512)
        Me.chkprintremarks.Name = "chkprintremarks"
        Me.chkprintremarks.Size = New System.Drawing.Size(92, 17)
        Me.chkprintremarks.TabIndex = 44
        Me.chkprintremarks.Text = "Print Remarks"
        Me.chkprintremarks.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(846, 7)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(46, 23)
        Me.Label19.TabIndex = 45
        Me.Label19.Text = "Time"
        '
        'txtbilltime
        '
        Me.txtbilltime.Location = New System.Drawing.Point(898, 8)
        Me.txtbilltime.Name = "txtbilltime"
        Me.txtbilltime.Size = New System.Drawing.Size(112, 20)
        Me.txtbilltime.TabIndex = 46
        '
        'txtbooktime
        '
        Me.txtbooktime.Location = New System.Drawing.Point(679, 217)
        Me.txtbooktime.Name = "txtbooktime"
        Me.txtbooktime.Size = New System.Drawing.Size(133, 20)
        Me.txtbooktime.TabIndex = 47
        Me.txtbooktime.Visible = False
        '
        'txtgrossamount
        '
        Me.txtgrossamount.Location = New System.Drawing.Point(437, 463)
        Me.txtgrossamount.Name = "txtgrossamount"
        Me.txtgrossamount.Size = New System.Drawing.Size(91, 20)
        Me.txtgrossamount.TabIndex = 49
        '
        'gbSave
        '
        Me.gbSave.Controls.Add(Me.btnprint)
        Me.gbSave.Controls.Add(Me.btnreset)
        Me.gbSave.Controls.Add(Me.btnsave)
        Me.gbSave.Controls.Add(Me.btnexit)
        Me.gbSave.Location = New System.Drawing.Point(337, 659)
        Me.gbSave.Name = "gbSave"
        Me.gbSave.Size = New System.Drawing.Size(363, 79)
        Me.gbSave.TabIndex = 50
        Me.gbSave.TabStop = False
        '
        'btnprint
        '
        Me.btnprint.BackColor = System.Drawing.Color.Thistle
        Me.btnprint.Location = New System.Drawing.Point(266, 28)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(77, 27)
        Me.btnprint.TabIndex = 6
        Me.btnprint.Text = "Print"
        Me.btnprint.UseVisualStyleBackColor = False
        '
        'gbpaymentdetails
        '
        Me.gbpaymentdetails.Controls.Add(Me.txtpmtremarks)
        Me.gbpaymentdetails.Controls.Add(Me.Label26)
        Me.gbpaymentdetails.Controls.Add(Me.btmpmtsave)
        Me.gbpaymentdetails.Controls.Add(Me.dtch)
        Me.gbpaymentdetails.Controls.Add(Me.Label25)
        Me.gbpaymentdetails.Controls.Add(Me.txtchno)
        Me.gbpaymentdetails.Controls.Add(Me.Label24)
        Me.gbpaymentdetails.Controls.Add(Me.ddmodeofpayment)
        Me.gbpaymentdetails.Controls.Add(Me.Label23)
        Me.gbpaymentdetails.Controls.Add(Me.txtpaidamount)
        Me.gbpaymentdetails.Controls.Add(Me.Label22)
        Me.gbpaymentdetails.Controls.Add(Me.dtpmt)
        Me.gbpaymentdetails.Controls.Add(Me.Label21)
        Me.gbpaymentdetails.Location = New System.Drawing.Point(524, 251)
        Me.gbpaymentdetails.Name = "gbpaymentdetails"
        Me.gbpaymentdetails.Size = New System.Drawing.Size(492, 206)
        Me.gbpaymentdetails.TabIndex = 51
        Me.gbpaymentdetails.TabStop = False
        Me.gbpaymentdetails.Text = "Payment Details"
        '
        'txtpmtremarks
        '
        Me.txtpmtremarks.Location = New System.Drawing.Point(146, 101)
        Me.txtpmtremarks.Multiline = True
        Me.txtpmtremarks.Name = "txtpmtremarks"
        Me.txtpmtremarks.Size = New System.Drawing.Size(309, 48)
        Me.txtpmtremarks.TabIndex = 54
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(24, 102)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(94, 23)
        Me.Label26.TabIndex = 53
        Me.Label26.Text = "Remarks"
        '
        'btmpmtsave
        '
        Me.btmpmtsave.BackColor = System.Drawing.Color.Thistle
        Me.btmpmtsave.Location = New System.Drawing.Point(24, 163)
        Me.btmpmtsave.Name = "btmpmtsave"
        Me.btmpmtsave.Size = New System.Drawing.Size(77, 27)
        Me.btmpmtsave.TabIndex = 52
        Me.btmpmtsave.Text = "Save"
        Me.btmpmtsave.UseVisualStyleBackColor = False
        Me.btmpmtsave.Visible = False
        '
        'dtch
        '
        Me.dtch.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtch.Location = New System.Drawing.Point(146, 75)
        Me.dtch.Name = "dtch"
        Me.dtch.Size = New System.Drawing.Size(109, 20)
        Me.dtch.TabIndex = 51
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(24, 75)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(94, 23)
        Me.Label25.TabIndex = 50
        Me.Label25.Text = "Cheque date"
        '
        'txtchno
        '
        Me.txtchno.Location = New System.Drawing.Point(387, 49)
        Me.txtchno.Name = "txtchno"
        Me.txtchno.Size = New System.Drawing.Size(99, 20)
        Me.txtchno.TabIndex = 49
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(282, 49)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(99, 40)
        Me.Label24.TabIndex = 48
        Me.Label24.Text = "Cheque No./C.V.V. No."
        '
        'ddmodeofpayment
        '
        Me.ddmodeofpayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddmodeofpayment.FormattingEnabled = True
        Me.ddmodeofpayment.Items.AddRange(New Object() {"Cash", "Credit Card", "Debit Card", "Cheque"})
        Me.ddmodeofpayment.Location = New System.Drawing.Point(146, 48)
        Me.ddmodeofpayment.Name = "ddmodeofpayment"
        Me.ddmodeofpayment.Size = New System.Drawing.Size(94, 21)
        Me.ddmodeofpayment.TabIndex = 47
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(21, 45)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(128, 23)
        Me.Label23.TabIndex = 46
        Me.Label23.Text = "Mode of Payment"
        '
        'txtpaidamount
        '
        Me.txtpaidamount.Location = New System.Drawing.Point(387, 22)
        Me.txtpaidamount.Name = "txtpaidamount"
        Me.txtpaidamount.Size = New System.Drawing.Size(99, 20)
        Me.txtpaidamount.TabIndex = 45
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(284, 20)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 23)
        Me.Label22.TabIndex = 44
        Me.Label22.Text = "Amount"
        '
        'dtpmt
        '
        Me.dtpmt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpmt.Location = New System.Drawing.Point(146, 22)
        Me.dtpmt.Name = "dtpmt"
        Me.dtpmt.Size = New System.Drawing.Size(109, 20)
        Me.dtpmt.TabIndex = 43
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(21, 20)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(46, 23)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "Date"
        '
        'dtbilldate
        '
        Me.dtbilldate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtbilldate.Location = New System.Drawing.Point(728, 10)
        Me.dtbilldate.Name = "dtbilldate"
        Me.dtbilldate.Size = New System.Drawing.Size(112, 20)
        Me.dtbilldate.TabIndex = 52
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(333, 493)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(119, 23)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "Disc. Visited Dr. :"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(330, 524)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(101, 23)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Disc. Ref. Dr. :"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(302, 550)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(133, 23)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "Disc. Management :"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(330, 578)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(101, 23)
        Me.Label18.TabIndex = 37
        Me.Label18.Text = "Net Amount :"
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(330, 460)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(101, 23)
        Me.Label20.TabIndex = 48
        Me.Label20.Text = "Gross Amount :"
        '
        'txtbillno
        '
        Me.txtbillno.Location = New System.Drawing.Point(457, 8)
        Me.txtbillno.Name = "txtbillno"
        Me.txtbillno.Size = New System.Drawing.Size(158, 20)
        Me.txtbillno.TabIndex = 53
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.Thistle
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(12, 9)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(357, 23)
        Me.Label27.TabIndex = 54
        Me.Label27.Text = "N.C.Das Immunomedicare -InHouse Sale"
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(600, 33)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(113, 23)
        Me.Label28.TabIndex = 55
        Me.Label28.Text = "Collection Date"
        '
        'dtcollection
        '
        Me.dtcollection.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtcollection.Location = New System.Drawing.Point(728, 36)
        Me.dtcollection.Name = "dtcollection"
        Me.dtcollection.Size = New System.Drawing.Size(112, 20)
        Me.dtcollection.TabIndex = 56
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(846, 36)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(46, 23)
        Me.Label29.TabIndex = 57
        Me.Label29.Text = "Time"
        '
        'txtcollectiontime
        '
        Me.txtcollectiontime.Location = New System.Drawing.Point(898, 36)
        Me.txtcollectiontime.Name = "txtcollectiontime"
        Me.txtcollectiontime.Size = New System.Drawing.Size(112, 20)
        Me.txtcollectiontime.TabIndex = 58
        '
        'Itemdescription
        '
        Me.Itemdescription.DataPropertyName = "Itemdescription"
        Me.Itemdescription.HeaderText = "Description"
        Me.Itemdescription.Name = "Itemdescription"
        '
        'amount
        '
        Me.amount.DataPropertyName = "amount"
        Me.amount.HeaderText = "Amount"
        Me.amount.Name = "amount"
        '
        'Deliv
        '
        Me.Deliv.DataPropertyName = "delv"
        Me.Deliv.HeaderText = "Deliv."
        Me.Deliv.Name = "Deliv"
        Me.Deliv.Visible = False
        '
        'DeliveryDate
        '
        Me.DeliveryDate.DataPropertyName = "delvdate"
        Me.DeliveryDate.HeaderText = "Delivery Date"
        Me.DeliveryDate.Name = "DeliveryDate"
        '
        'DelivfromLab
        '
        Me.DelivfromLab.DataPropertyName = "delvlab"
        Me.DelivfromLab.HeaderText = "Delivery from Lab"
        Me.DelivfromLab.Name = "DelivfromLab"
        Me.DelivfromLab.Visible = False
        '
        'testdoneat
        '
        Me.testdoneat.DataPropertyName = "testdoneat"
        Me.testdoneat.HeaderText = "Test Done At"
        Me.testdoneat.Name = "testdoneat"
        Me.testdoneat.Visible = False
        '
        'senttolab
        '
        Me.senttolab.DataPropertyName = "senttolab"
        Me.senttolab.HeaderText = "Sent To Lab"
        Me.senttolab.Name = "senttolab"
        Me.senttolab.Visible = False
        '
        'Delete
        '
        Me.Delete.DataPropertyName = "delete"
        Me.Delete.HeaderText = "Delete"
        Me.Delete.Name = "Delete"
        Me.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Delete.Text = "Delete"
        '
        'NCDasInhouse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.ClientSize = New System.Drawing.Size(1028, 750)
        Me.Controls.Add(Me.txtcollectiontime)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.dtcollection)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.txtbillno)
        Me.Controls.Add(Me.dtbilldate)
        Me.Controls.Add(Me.gbpaymentdetails)
        Me.Controls.Add(Me.gbSave)
        Me.Controls.Add(Me.txtgrossamount)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtbooktime)
        Me.Controls.Add(Me.txtbilltime)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.chkprintremarks)
        Me.Controls.Add(Me.gbinsert)
        Me.Controls.Add(Me.txtnetamount)
        Me.Controls.Add(Me.txtdiscmanagement)
        Me.Controls.Add(Me.txtdiscrefdoctor)
        Me.Controls.Add(Me.txtdiscvisiteddoctor)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtremarks)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.dtproposeddate)
        Me.Controls.Add(Me.txtpatientoldid)
        Me.Controls.Add(Me.txtpatientID)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ddbookfor)
        Me.Controls.Add(Me.ddagent)
        Me.Controls.Add(Me.txtlabname)
        Me.Controls.Add(Me.txtrefdoctorname)
        Me.Controls.Add(Me.txtlabid)
        Me.Controls.Add(Me.txtrefdoctorid)
        Me.Controls.Add(Me.txtvisiteddoctorname)
        Me.Controls.Add(Me.txtvisiteddoctorid)
        Me.Controls.Add(Me.txtage1)
        Me.Controls.Add(Me.txtage)
        Me.Controls.Add(Me.ddsex)
        Me.Controls.Add(Me.txtpatientname)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NCDasInhouse"
        Me.Text = "N.C. Das In-house Bill"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgitems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbinsert.ResumeLayout(False)
        Me.gbSave.ResumeLayout(False)
        Me.gbpaymentdetails.ResumeLayout(False)
        Me.gbpaymentdetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtpatientname As System.Windows.Forms.TextBox
    Friend WithEvents ddsex As System.Windows.Forms.ComboBox
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents txtage1 As System.Windows.Forms.TextBox
    Friend WithEvents txtvisiteddoctorid As System.Windows.Forms.TextBox
    Friend WithEvents txtvisiteddoctorname As System.Windows.Forms.TextBox
    Friend WithEvents txtrefdoctorid As System.Windows.Forms.TextBox
    Friend WithEvents txtlabid As System.Windows.Forms.TextBox
    Friend WithEvents txtrefdoctorname As System.Windows.Forms.TextBox
    Friend WithEvents txtlabname As System.Windows.Forms.TextBox
    Friend WithEvents ddagent As System.Windows.Forms.ComboBox
    Friend WithEvents ddbookfor As System.Windows.Forms.ComboBox
    Friend WithEvents dgitems As System.Windows.Forms.DataGridView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtpatientID As System.Windows.Forms.TextBox
    Friend WithEvents txtpatientoldid As System.Windows.Forms.TextBox
    Friend WithEvents dtproposeddate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtremarks As System.Windows.Forms.TextBox
    Friend WithEvents txtdiscvisiteddoctor As System.Windows.Forms.TextBox
    Friend WithEvents txtdiscrefdoctor As System.Windows.Forms.TextBox
    Friend WithEvents txtdiscmanagement As System.Windows.Forms.TextBox
    Friend WithEvents txtnetamount As System.Windows.Forms.TextBox
    Friend WithEvents gbinsert As System.Windows.Forms.GroupBox
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btninsert As System.Windows.Forms.Button
    Friend WithEvents chkprintremarks As System.Windows.Forms.CheckBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtbilltime As System.Windows.Forms.TextBox
    Friend WithEvents txtbooktime As System.Windows.Forms.TextBox
    Friend WithEvents txtgrossamount As System.Windows.Forms.TextBox
    Friend WithEvents gbSave As System.Windows.Forms.GroupBox
    Friend WithEvents gbpaymentdetails As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtchno As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents ddmodeofpayment As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtpaidamount As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents dtpmt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btmpmtsave As System.Windows.Forms.Button
    Friend WithEvents dtch As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtpmtremarks As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents dtbilldate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtbillno As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents dtcollection As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtcollectiontime As System.Windows.Forms.TextBox
    Friend WithEvents Itemdescription As DataGridViewComboBoxColumn
    Friend WithEvents amount As DataGridViewTextBoxColumn
    Friend WithEvents Deliv As DataGridViewTextBoxColumn
    Friend WithEvents DeliveryDate As DataGridViewTextBoxColumn
    Friend WithEvents DelivfromLab As DataGridViewTextBoxColumn
    Friend WithEvents testdoneat As DataGridViewTextBoxColumn
    Friend WithEvents senttolab As DataGridViewTextBoxColumn
    Friend WithEvents Delete As DataGridViewButtonColumn
End Class
