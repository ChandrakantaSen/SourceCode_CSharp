<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class searchBill
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.billtype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.selectpk = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.lbltotalrecords = New System.Windows.Forms.Label()
        Me.lbltotalpage = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ddbilltype = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgpatient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightCyan
        Me.GroupBox1.Controls.Add(Me.ddbilltype)
        Me.GroupBox1.Controls.Add(Me.Label5)
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
        Me.dttodate.Location = New System.Drawing.Point(401, 41)
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
        Me.Label4.Location = New System.Drawing.Point(313, 44)
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
        Me.Label2.Location = New System.Drawing.Point(313, 9)
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
        Me.txtpatientname.Location = New System.Drawing.Point(399, 9)
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgpatient.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgpatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgpatient.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.row, Me.billid, Me.patientpk, Me.billno, Me.billdate, Me.patientid, Me.ptname, Me.billvalue, Me.billtype, Me.selectpk})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgpatient.DefaultCellStyle = DataGridViewCellStyle4
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
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(520, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 23)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Bill Type"
        '
        'ddbilltype
        '
        Me.ddbilltype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddbilltype.FormattingEnabled = True
        Me.ddbilltype.Items.AddRange(New Object() {"Select", "Consultation", "In-house Bill", "Direct Sales Bill"})
        Me.ddbilltype.Location = New System.Drawing.Point(587, 41)
        Me.ddbilltype.Name = "ddbilltype"
        Me.ddbilltype.Size = New System.Drawing.Size(176, 21)
        Me.ddbilltype.TabIndex = 16
        '
        'searchBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(1250, 748)
        Me.Controls.Add(Me.lbltotalpage)
        Me.Controls.Add(Me.lbltotalrecords)
        Me.Controls.Add(Me.dgpatient)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "searchBill"
        Me.Text = "searchpatient"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgpatient, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents row As DataGridViewTextBoxColumn
    Friend WithEvents billid As DataGridViewTextBoxColumn
    Friend WithEvents patientpk As DataGridViewTextBoxColumn
    Friend WithEvents billno As DataGridViewTextBoxColumn
    Friend WithEvents billdate As DataGridViewTextBoxColumn
    Friend WithEvents patientid As DataGridViewTextBoxColumn
    Friend WithEvents ptname As DataGridViewTextBoxColumn
    Friend WithEvents billvalue As DataGridViewTextBoxColumn
    Friend WithEvents billtype As DataGridViewTextBoxColumn
    Friend WithEvents selectpk As DataGridViewButtonColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents ddbilltype As ComboBox
End Class
