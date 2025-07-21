<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMedPatMas
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
        Me.lstMedPat = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbDosId = New System.Windows.Forms.ComboBox()
        Me.cmbMedGrpId = New System.Windows.Forms.ComboBox()
        Me.cmbMedGenId = New System.Windows.Forms.ComboBox()
        Me.cmbTypeid = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbManufacId = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtManufacInfo = New System.Windows.Forms.TextBox()
        Me.txtPatName = New System.Windows.Forms.TextBox()
        Me.txtMedPatId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstMedPat
        '
        Me.lstMedPat.FormattingEnabled = True
        Me.lstMedPat.Location = New System.Drawing.Point(592, 127)
        Me.lstMedPat.Name = "lstMedPat"
        Me.lstMedPat.Size = New System.Drawing.Size(209, 368)
        Me.lstMedPat.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Cornsilk
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmbDosId)
        Me.GroupBox1.Controls.Add(Me.cmbMedGrpId)
        Me.GroupBox1.Controls.Add(Me.cmbMedGenId)
        Me.GroupBox1.Controls.Add(Me.cmbTypeid)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbManufacId)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtManufacInfo)
        Me.GroupBox1.Controls.Add(Me.txtPatName)
        Me.GroupBox1.Controls.Add(Me.txtMedPatId)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 127)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(564, 373)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(299, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 22)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Dosage Unit"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 22)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Type"
        '
        'cmbDosId
        '
        Me.cmbDosId.FormattingEnabled = True
        Me.cmbDosId.Location = New System.Drawing.Point(390, 125)
        Me.cmbDosId.Name = "cmbDosId"
        Me.cmbDosId.Size = New System.Drawing.Size(102, 21)
        Me.cmbDosId.TabIndex = 26
        '
        'cmbMedGrpId
        '
        Me.cmbMedGrpId.FormattingEnabled = True
        Me.cmbMedGrpId.Location = New System.Drawing.Point(167, 162)
        Me.cmbMedGrpId.Name = "cmbMedGrpId"
        Me.cmbMedGrpId.Size = New System.Drawing.Size(326, 21)
        Me.cmbMedGrpId.TabIndex = 25
        '
        'cmbMedGenId
        '
        Me.cmbMedGenId.FormattingEnabled = True
        Me.cmbMedGenId.Location = New System.Drawing.Point(167, 92)
        Me.cmbMedGenId.Name = "cmbMedGenId"
        Me.cmbMedGenId.Size = New System.Drawing.Size(326, 21)
        Me.cmbMedGenId.TabIndex = 24
        '
        'cmbTypeid
        '
        Me.cmbTypeid.FormattingEnabled = True
        Me.cmbTypeid.Location = New System.Drawing.Point(167, 127)
        Me.cmbTypeid.Name = "cmbTypeid"
        Me.cmbTypeid.Size = New System.Drawing.Size(126, 21)
        Me.cmbTypeid.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 54)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Special Information"
        '
        'cmbManufacId
        '
        Me.cmbManufacId.FormattingEnabled = True
        Me.cmbManufacId.Location = New System.Drawing.Point(167, 197)
        Me.cmbManufacId.Name = "cmbManufacId"
        Me.cmbManufacId.Size = New System.Drawing.Size(326, 21)
        Me.cmbManufacId.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(33, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 22)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Manufacturer"
        '
        'txtManufacInfo
        '
        Me.txtManufacInfo.Location = New System.Drawing.Point(167, 232)
        Me.txtManufacInfo.Multiline = True
        Me.txtManufacInfo.Name = "txtManufacInfo"
        Me.txtManufacInfo.Size = New System.Drawing.Size(326, 53)
        Me.txtManufacInfo.TabIndex = 11
        '
        'txtPatName
        '
        Me.txtPatName.Location = New System.Drawing.Point(167, 58)
        Me.txtPatName.Name = "txtPatName"
        Me.txtPatName.Size = New System.Drawing.Size(326, 20)
        Me.txtPatName.TabIndex = 9
        '
        'txtMedPatId
        '
        Me.txtMedPatId.Location = New System.Drawing.Point(352, 20)
        Me.txtMedPatId.Name = "txtMedPatId"
        Me.txtMedPatId.Size = New System.Drawing.Size(94, 20)
        Me.txtMedPatId.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 22)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Group Name"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Generic Name"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 22)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Patent Name"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(233, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Medicine Id"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.btnexit)
        Me.GroupBox2.Controls.Add(Me.btnadd)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(3, 315)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(558, 55)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.SkyBlue
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(190, 19)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.SkyBlue
        Me.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexit.Location = New System.Drawing.Point(364, 19)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(79, 23)
        Me.btnexit.TabIndex = 1
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.SkyBlue
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadd.Location = New System.Drawing.Point(271, 19)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 23)
        Me.btnadd.TabIndex = 0
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'lbltitle
        '
        Me.lbltitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltitle.BackColor = System.Drawing.Color.SteelBlue
        Me.lbltitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.Gold
        Me.lbltitle.Location = New System.Drawing.Point(21, 79)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(780, 28)
        Me.lbltitle.TabIndex = 9
        Me.lbltitle.Text = "Medicine Master Form"
        Me.lbltitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmMedPatMas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 554)
        Me.Controls.Add(Me.lstMedPat)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbltitle)
        Me.Name = "frmMedPatMas"
        Me.Text = "Medicine Master"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstMedPat As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbDosId As ComboBox
    Friend WithEvents cmbMedGrpId As ComboBox
    Friend WithEvents cmbMedGenId As ComboBox
    Friend WithEvents cmbTypeid As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbManufacId As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtManufacInfo As TextBox
    Friend WithEvents txtPatName As TextBox
    Friend WithEvents txtMedPatId As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents lbltitle As Label
End Class
