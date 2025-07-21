<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class searchpatient
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnprev = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnlast = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.txtmobile = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.txtpatientname = New System.Windows.Forms.TextBox()
        Me.txtpatientid = New System.Windows.Forms.TextBox()
        Me.dgpatient = New System.Windows.Forms.DataGridView()
        Me.row = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.patientpk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.patientid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ptname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Age = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.selectpk = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.lbltotalrecords = New System.Windows.Forms.Label()
        Me.lbltotalpage = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgpatient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightCyan
        Me.GroupBox1.Controls.Add(Me.btnprev)
        Me.GroupBox1.Controls.Add(Me.btnFirst)
        Me.GroupBox1.Controls.Add(Me.btnlast)
        Me.GroupBox1.Controls.Add(Me.btnnext)
        Me.GroupBox1.Controls.Add(Me.txtmobile)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnsearch)
        Me.GroupBox1.Controls.Add(Me.txtpatientname)
        Me.GroupBox1.Controls.Add(Me.txtpatientid)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(808, 145)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnprev
        '
        Me.btnprev.Location = New System.Drawing.Point(464, 83)
        Me.btnprev.Name = "btnprev"
        Me.btnprev.Size = New System.Drawing.Size(62, 26)
        Me.btnprev.TabIndex = 10
        Me.btnprev.Text = "Prev"
        Me.btnprev.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(303, 83)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(62, 26)
        Me.btnFirst.TabIndex = 9
        Me.btnFirst.Text = "First"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnlast
        '
        Me.btnlast.Location = New System.Drawing.Point(544, 83)
        Me.btnlast.Name = "btnlast"
        Me.btnlast.Size = New System.Drawing.Size(62, 26)
        Me.btnlast.TabIndex = 8
        Me.btnlast.Text = "Last"
        Me.btnlast.UseVisualStyleBackColor = True
        '
        'btnnext
        '
        Me.btnnext.Location = New System.Drawing.Point(382, 83)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(62, 26)
        Me.btnnext.TabIndex = 7
        Me.btnnext.Text = "Next"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'txtmobile
        '
        Me.txtmobile.Location = New System.Drawing.Point(151, 38)
        Me.txtmobile.Name = "txtmobile"
        Me.txtmobile.Size = New System.Drawing.Size(162, 20)
        Me.txtmobile.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(18, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Mobile No."
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(254, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Patient Name"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(18, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 23)
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
        Me.txtpatientname.Location = New System.Drawing.Point(340, 12)
        Me.txtpatientname.Multiline = True
        Me.txtpatientname.Name = "txtpatientname"
        Me.txtpatientname.Size = New System.Drawing.Size(277, 23)
        Me.txtpatientname.TabIndex = 1
        '
        'txtpatientid
        '
        Me.txtpatientid.Location = New System.Drawing.Point(151, 12)
        Me.txtpatientid.Name = "txtpatientid"
        Me.txtpatientid.Size = New System.Drawing.Size(72, 20)
        Me.txtpatientid.TabIndex = 0
        '
        'dgpatient
        '
        Me.dgpatient.AllowUserToAddRows = False
        Me.dgpatient.AllowUserToDeleteRows = False
        Me.dgpatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgpatient.BackgroundColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgpatient.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgpatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgpatient.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.row, Me.patientpk, Me.patientid, Me.ptname, Me.sex, Me.Age, Me.selectpk})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgpatient.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgpatient.Location = New System.Drawing.Point(12, 201)
        Me.dgpatient.MultiSelect = False
        Me.dgpatient.Name = "dgpatient"
        Me.dgpatient.ReadOnly = True
        Me.dgpatient.Size = New System.Drawing.Size(794, 257)
        Me.dgpatient.TabIndex = 1
        '
        'row
        '
        Me.row.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.row.DataPropertyName = "row"
        Me.row.FillWeight = 76.14214!
        Me.row.HeaderText = "Srl No."
        Me.row.Name = "row"
        Me.row.ReadOnly = True
        Me.row.Width = 81
        '
        'patientpk
        '
        Me.patientpk.DataPropertyName = "id"
        Me.patientpk.HeaderText = "patientpk"
        Me.patientpk.Name = "patientpk"
        Me.patientpk.ReadOnly = True
        Me.patientpk.Visible = False
        '
        'patientid
        '
        Me.patientid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.patientid.DataPropertyName = "patientid"
        Me.patientid.FillWeight = 111.9289!
        Me.patientid.HeaderText = "Patient ID"
        Me.patientid.Name = "patientid"
        Me.patientid.ReadOnly = True
        Me.patientid.Width = 97
        '
        'ptname
        '
        Me.ptname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ptname.DataPropertyName = "ptname"
        Me.ptname.FillWeight = 111.9289!
        Me.ptname.HeaderText = "Patient Name"
        Me.ptname.Name = "ptname"
        Me.ptname.ReadOnly = True
        '
        'sex
        '
        Me.sex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.sex.DataPropertyName = "sex"
        Me.sex.HeaderText = "Sex"
        Me.sex.Name = "sex"
        Me.sex.ReadOnly = True
        Me.sex.Width = 61
        '
        'Age
        '
        Me.Age.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Age.DataPropertyName = "age"
        Me.Age.HeaderText = "Age"
        Me.Age.Name = "Age"
        Me.Age.ReadOnly = True
        Me.Age.Width = 63
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
        Me.lbltotalrecords.Location = New System.Drawing.Point(23, 164)
        Me.lbltotalrecords.Name = "lbltotalrecords"
        Me.lbltotalrecords.Size = New System.Drawing.Size(69, 13)
        Me.lbltotalrecords.TabIndex = 2
        Me.lbltotalrecords.Text = "Total Record"
        '
        'lbltotalpage
        '
        Me.lbltotalpage.AutoSize = True
        Me.lbltotalpage.Location = New System.Drawing.Point(238, 164)
        Me.lbltotalpage.Name = "lbltotalpage"
        Me.lbltotalpage.Size = New System.Drawing.Size(59, 13)
        Me.lbltotalpage.TabIndex = 3
        Me.lbltotalpage.Text = "Total Page"
        '
        'searchpatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(958, 545)
        Me.Controls.Add(Me.lbltotalpage)
        Me.Controls.Add(Me.lbltotalrecords)
        Me.Controls.Add(Me.dgpatient)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "searchpatient"
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
    Friend WithEvents txtmobile As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgpatient As System.Windows.Forms.DataGridView
    Friend WithEvents lbltotalrecords As System.Windows.Forms.Label
    Friend WithEvents btnnext As System.Windows.Forms.Button
    Friend WithEvents lbltotalpage As System.Windows.Forms.Label
    Friend WithEvents btnlast As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnprev As System.Windows.Forms.Button
    Friend WithEvents row As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents patientpk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents patientid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ptname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Age As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents selectpk As System.Windows.Forms.DataGridViewButtonColumn
End Class
