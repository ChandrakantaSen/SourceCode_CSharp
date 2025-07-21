<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class searchpatientoutstanding
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dttodate = New System.Windows.Forms.DateTimePicker()
        Me.dtfromdate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnprev = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnlast = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.txtpatientname = New System.Windows.Forms.TextBox()
        Me.txtpatientid = New System.Windows.Forms.TextBox()
        Me.dgpatient = New System.Windows.Forms.DataGridView()
        Me.row = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.billid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.patientpk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.billno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.billdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.patientid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ptname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.billvalue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.billpaid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.billdue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.billtype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.selectpk = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.lbltotalrecords = New System.Windows.Forms.Label()
        Me.lbltotalpage = New System.Windows.Forms.Label()
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
        Me.txtdueamount = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.dtpmt = New System.Windows.Forms.DateTimePicker()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtbillno = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtosamt = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgpatient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbpaymentdetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightCyan
        Me.GroupBox1.Controls.Add(Me.dttodate)
        Me.GroupBox1.Controls.Add(Me.dtfromdate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnprev)
        Me.GroupBox1.Controls.Add(Me.btnFirst)
        Me.GroupBox1.Controls.Add(Me.btnlast)
        Me.GroupBox1.Controls.Add(Me.btnnext)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnsearch)
        Me.GroupBox1.Controls.Add(Me.txtpatientname)
        Me.GroupBox1.Controls.Add(Me.txtpatientid)
        Me.GroupBox1.Location = New System.Drawing.Point(180, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(892, 145)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'dttodate
        '
        Me.dttodate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dttodate.Location = New System.Drawing.Point(493, 47)
        Me.dttodate.Name = "dttodate"
        Me.dttodate.Size = New System.Drawing.Size(101, 20)
        Me.dttodate.TabIndex = 14
        '
        'dtfromdate
        '
        Me.dtfromdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfromdate.Location = New System.Drawing.Point(118, 47)
        Me.dtfromdate.Name = "dtfromdate"
        Me.dtfromdate.Size = New System.Drawing.Size(103, 20)
        Me.dtfromdate.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(379, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 23)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "To Date"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(18, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 23)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "From Date"
        '
        'btnprev
        '
        Me.btnprev.Location = New System.Drawing.Point(552, 83)
        Me.btnprev.Name = "btnprev"
        Me.btnprev.Size = New System.Drawing.Size(62, 26)
        Me.btnprev.TabIndex = 10
        Me.btnprev.Text = "Prev"
        Me.btnprev.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(382, 83)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(62, 26)
        Me.btnFirst.TabIndex = 9
        Me.btnFirst.Text = "First"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnlast
        '
        Me.btnlast.Location = New System.Drawing.Point(637, 83)
        Me.btnlast.Name = "btnlast"
        Me.btnlast.Size = New System.Drawing.Size(62, 26)
        Me.btnlast.TabIndex = 8
        Me.btnlast.Text = "Last"
        Me.btnlast.UseVisualStyleBackColor = True
        '
        'btnnext
        '
        Me.btnnext.Location = New System.Drawing.Point(467, 83)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(62, 26)
        Me.btnnext.TabIndex = 7
        Me.btnnext.Text = "Next"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(379, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Patient Name"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(18, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Patient ID "
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(151, 83)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(62, 26)
        Me.btnsearch.TabIndex = 2
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'txtpatientname
        '
        Me.txtpatientname.Location = New System.Drawing.Point(493, 9)
        Me.txtpatientname.Multiline = True
        Me.txtpatientname.Name = "txtpatientname"
        Me.txtpatientname.Size = New System.Drawing.Size(277, 23)
        Me.txtpatientname.TabIndex = 1
        '
        'txtpatientid
        '
        Me.txtpatientid.Location = New System.Drawing.Point(118, 12)
        Me.txtpatientid.Name = "txtpatientid"
        Me.txtpatientid.Size = New System.Drawing.Size(177, 20)
        Me.txtpatientid.TabIndex = 0
        '
        'dgpatient
        '
        Me.dgpatient.AllowUserToAddRows = False
        Me.dgpatient.AllowUserToDeleteRows = False
        Me.dgpatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgpatient.BackgroundColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgpatient.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgpatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgpatient.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.row, Me.billid, Me.patientpk, Me.billno, Me.billdate, Me.patientid, Me.ptname, Me.billvalue, Me.billpaid, Me.billdue, Me.billtype, Me.selectpk})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgpatient.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgpatient.Location = New System.Drawing.Point(180, 200)
        Me.dgpatient.MultiSelect = False
        Me.dgpatient.Name = "dgpatient"
        Me.dgpatient.ReadOnly = True
        Me.dgpatient.Size = New System.Drawing.Size(892, 257)
        Me.dgpatient.TabIndex = 1
        '
        'row
        '
        Me.row.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.row.DataPropertyName = "rowno"
        Me.row.FillWeight = 76.14214!
        Me.row.HeaderText = "Srl No."
        Me.row.Name = "row"
        Me.row.ReadOnly = True
        Me.row.Width = 81
        '
        'billid
        '
        Me.billid.DataPropertyName = "billid"
        Me.billid.HeaderText = "billid"
        Me.billid.Name = "billid"
        Me.billid.ReadOnly = True
        Me.billid.Visible = False
        '
        'patientpk
        '
        Me.patientpk.DataPropertyName = "patientfk"
        Me.patientpk.HeaderText = "patientpk"
        Me.patientpk.Name = "patientpk"
        Me.patientpk.ReadOnly = True
        Me.patientpk.Visible = False
        '
        'billno
        '
        Me.billno.DataPropertyName = "billno"
        Me.billno.HeaderText = "Bill No"
        Me.billno.Name = "billno"
        Me.billno.ReadOnly = True
        '
        'billdate
        '
        Me.billdate.DataPropertyName = "billdate"
        Me.billdate.HeaderText = "Bill Date"
        Me.billdate.Name = "billdate"
        Me.billdate.ReadOnly = True
        '
        'patientid
        '
        Me.patientid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.patientid.DataPropertyName = "patientid"
        Me.patientid.FillWeight = 111.9289!
        Me.patientid.HeaderText = "Patient ID"
        Me.patientid.Name = "patientid"
        Me.patientid.ReadOnly = True
        Me.patientid.Width = 96
        '
        'ptname
        '
        Me.ptname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ptname.DataPropertyName = "patientname"
        Me.ptname.FillWeight = 111.9289!
        Me.ptname.HeaderText = "Patient Name"
        Me.ptname.Name = "ptname"
        Me.ptname.ReadOnly = True
        '
        'billvalue
        '
        Me.billvalue.DataPropertyName = "billvalue"
        Me.billvalue.HeaderText = "Bill Value"
        Me.billvalue.Name = "billvalue"
        Me.billvalue.ReadOnly = True
        '
        'billpaid
        '
        Me.billpaid.DataPropertyName = "billpaid"
        Me.billpaid.HeaderText = "Bill Paid"
        Me.billpaid.Name = "billpaid"
        Me.billpaid.ReadOnly = True
        '
        'billdue
        '
        Me.billdue.DataPropertyName = "billdue"
        Me.billdue.HeaderText = "billdue"
        Me.billdue.Name = "billdue"
        Me.billdue.ReadOnly = True
        '
        'billtype
        '
        Me.billtype.DataPropertyName = "billtype"
        Me.billtype.HeaderText = "Bill Type"
        Me.billtype.Name = "billtype"
        Me.billtype.ReadOnly = True
        '
        'selectpk
        '
        Me.selectpk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.selectpk.DataPropertyName = "commandname"
        Me.selectpk.HeaderText = "Select"
        Me.selectpk.Name = "selectpk"
        Me.selectpk.ReadOnly = True
        Me.selectpk.Width = 60
        '
        'lbltotalrecords
        '
        Me.lbltotalrecords.AutoSize = True
        Me.lbltotalrecords.Location = New System.Drawing.Point(177, 164)
        Me.lbltotalrecords.Name = "lbltotalrecords"
        Me.lbltotalrecords.Size = New System.Drawing.Size(69, 13)
        Me.lbltotalrecords.TabIndex = 2
        Me.lbltotalrecords.Text = "Total Record"
        '
        'lbltotalpage
        '
        Me.lbltotalpage.AutoSize = True
        Me.lbltotalpage.Location = New System.Drawing.Point(449, 164)
        Me.lbltotalpage.Name = "lbltotalpage"
        Me.lbltotalpage.Size = New System.Drawing.Size(59, 13)
        Me.lbltotalpage.TabIndex = 3
        Me.lbltotalpage.Text = "Total Page"
        '
        'gbpaymentdetails
        '
        Me.gbpaymentdetails.Controls.Add(Me.txtosamt)
        Me.gbpaymentdetails.Controls.Add(Me.Label6)
        Me.gbpaymentdetails.Controls.Add(Me.txtbillno)
        Me.gbpaymentdetails.Controls.Add(Me.Label5)
        Me.gbpaymentdetails.Controls.Add(Me.txtpmtremarks)
        Me.gbpaymentdetails.Controls.Add(Me.Label26)
        Me.gbpaymentdetails.Controls.Add(Me.btmpmtsave)
        Me.gbpaymentdetails.Controls.Add(Me.dtch)
        Me.gbpaymentdetails.Controls.Add(Me.Label25)
        Me.gbpaymentdetails.Controls.Add(Me.txtchno)
        Me.gbpaymentdetails.Controls.Add(Me.Label24)
        Me.gbpaymentdetails.Controls.Add(Me.ddmodeofpayment)
        Me.gbpaymentdetails.Controls.Add(Me.Label23)
        Me.gbpaymentdetails.Controls.Add(Me.txtdueamount)
        Me.gbpaymentdetails.Controls.Add(Me.Label22)
        Me.gbpaymentdetails.Controls.Add(Me.dtpmt)
        Me.gbpaymentdetails.Controls.Add(Me.Label21)
        Me.gbpaymentdetails.Location = New System.Drawing.Point(180, 476)
        Me.gbpaymentdetails.Name = "gbpaymentdetails"
        Me.gbpaymentdetails.Size = New System.Drawing.Size(892, 237)
        Me.gbpaymentdetails.TabIndex = 52
        Me.gbpaymentdetails.TabStop = False
        Me.gbpaymentdetails.Text = "Payment Details"
        '
        'txtpmtremarks
        '
        Me.txtpmtremarks.Location = New System.Drawing.Point(146, 140)
        Me.txtpmtremarks.Multiline = True
        Me.txtpmtremarks.Name = "txtpmtremarks"
        Me.txtpmtremarks.Size = New System.Drawing.Size(624, 48)
        Me.txtpmtremarks.TabIndex = 54
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(21, 140)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(94, 23)
        Me.Label26.TabIndex = 53
        Me.Label26.Text = "Remarks"
        '
        'btmpmtsave
        '
        Me.btmpmtsave.BackColor = System.Drawing.Color.Thistle
        Me.btmpmtsave.Location = New System.Drawing.Point(431, 194)
        Me.btmpmtsave.Name = "btmpmtsave"
        Me.btmpmtsave.Size = New System.Drawing.Size(77, 27)
        Me.btmpmtsave.TabIndex = 52
        Me.btmpmtsave.Text = "Save"
        Me.btmpmtsave.UseVisualStyleBackColor = False
        '
        'dtch
        '
        Me.dtch.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtch.Location = New System.Drawing.Point(146, 104)
        Me.dtch.Name = "dtch"
        Me.dtch.Size = New System.Drawing.Size(109, 20)
        Me.dtch.TabIndex = 51
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(21, 104)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(94, 23)
        Me.Label25.TabIndex = 50
        Me.Label25.Text = "Cheque date"
        '
        'txtchno
        '
        Me.txtchno.Location = New System.Drawing.Point(387, 104)
        Me.txtchno.Name = "txtchno"
        Me.txtchno.Size = New System.Drawing.Size(99, 20)
        Me.txtchno.TabIndex = 49
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(282, 104)
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
        Me.ddmodeofpayment.Location = New System.Drawing.Point(637, 72)
        Me.ddmodeofpayment.Name = "ddmodeofpayment"
        Me.ddmodeofpayment.Size = New System.Drawing.Size(94, 21)
        Me.ddmodeofpayment.TabIndex = 47
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(503, 72)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(128, 23)
        Me.Label23.TabIndex = 46
        Me.Label23.Text = "Mode of Payment"
        '
        'txtdueamount
        '
        Me.txtdueamount.Location = New System.Drawing.Point(387, 72)
        Me.txtdueamount.Name = "txtdueamount"
        Me.txtdueamount.Size = New System.Drawing.Size(99, 20)
        Me.txtdueamount.TabIndex = 45
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(282, 72)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(97, 23)
        Me.Label22.TabIndex = 44
        Me.Label22.Text = "Due Amount"
        '
        'dtpmt
        '
        Me.dtpmt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpmt.Location = New System.Drawing.Point(146, 72)
        Me.dtpmt.Name = "dtpmt"
        Me.dtpmt.Size = New System.Drawing.Size(109, 20)
        Me.dtpmt.TabIndex = 43
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(21, 72)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(46, 23)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "Date"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 23)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Bill No."
        '
        'txtbillno
        '
        Me.txtbillno.Enabled = False
        Me.txtbillno.Location = New System.Drawing.Point(146, 34)
        Me.txtbillno.Name = "txtbillno"
        Me.txtbillno.Size = New System.Drawing.Size(127, 20)
        Me.txtbillno.TabIndex = 56
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(282, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 23)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "OS Amount"
        '
        'txtosamt
        '
        Me.txtosamt.Enabled = False
        Me.txtosamt.Location = New System.Drawing.Point(387, 35)
        Me.txtosamt.Name = "txtosamt"
        Me.txtosamt.Size = New System.Drawing.Size(111, 20)
        Me.txtosamt.TabIndex = 58
        '
        'searchpatientoutstanding
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(1250, 748)
        Me.Controls.Add(Me.gbpaymentdetails)
        Me.Controls.Add(Me.lbltotalpage)
        Me.Controls.Add(Me.lbltotalrecords)
        Me.Controls.Add(Me.dgpatient)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "searchpatientoutstanding"
        Me.Text = "searchpatient"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgpatient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbpaymentdetails.ResumeLayout(False)
        Me.gbpaymentdetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtpatientname As System.Windows.Forms.TextBox
    Friend WithEvents txtpatientid As System.Windows.Forms.TextBox
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgpatient As System.Windows.Forms.DataGridView
    Friend WithEvents lbltotalrecords As System.Windows.Forms.Label
    Friend WithEvents btnnext As System.Windows.Forms.Button
    Friend WithEvents lbltotalpage As System.Windows.Forms.Label
    Friend WithEvents btnlast As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnprev As System.Windows.Forms.Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dttodate As DateTimePicker
    Friend WithEvents dtfromdate As DateTimePicker
    Friend WithEvents gbpaymentdetails As GroupBox
    Friend WithEvents txtpmtremarks As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents btmpmtsave As Button
    Friend WithEvents dtch As DateTimePicker
    Friend WithEvents Label25 As Label
    Friend WithEvents txtchno As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents ddmodeofpayment As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtdueamount As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents dtpmt As DateTimePicker
    Friend WithEvents Label21 As Label
    Friend WithEvents row As DataGridViewTextBoxColumn
    Friend WithEvents billid As DataGridViewTextBoxColumn
    Friend WithEvents patientpk As DataGridViewTextBoxColumn
    Friend WithEvents billno As DataGridViewTextBoxColumn
    Friend WithEvents billdate As DataGridViewTextBoxColumn
    Friend WithEvents patientid As DataGridViewTextBoxColumn
    Friend WithEvents ptname As DataGridViewTextBoxColumn
    Friend WithEvents billvalue As DataGridViewTextBoxColumn
    Friend WithEvents billpaid As DataGridViewTextBoxColumn
    Friend WithEvents billdue As DataGridViewTextBoxColumn
    Friend WithEvents billtype As DataGridViewTextBoxColumn
    Friend WithEvents selectpk As DataGridViewButtonColumn
    Friend WithEvents txtosamt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtbillno As TextBox
    Friend WithEvents Label5 As Label
End Class
