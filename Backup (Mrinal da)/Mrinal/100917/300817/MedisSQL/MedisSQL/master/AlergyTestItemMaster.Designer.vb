<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlergyTestItemMaster
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
        Me.lstallergyitem = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkconst = New System.Windows.Forms.CheckBox()
        Me.ddtestlab = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dddept = New System.Windows.Forms.ComboBox()
        Me.ddtype = New System.Windows.Forms.ComboBox()
        Me.ddcategory = New System.Windows.Forms.ComboBox()
        Me.txtunregisteredcharge = New System.Windows.Forms.TextBox()
        Me.txtregisteredcharges = New System.Windows.Forms.TextBox()
        Me.txtdelivery = New System.Windows.Forms.TextBox()
        Me.txtshortname = New System.Windows.Forms.TextBox()
        Me.txtitemname = New System.Windows.Forms.TextBox()
        Me.txtitemid = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dglab = New System.Windows.Forms.DataGridView()
        Me.labid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.labname = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Delvdays = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtsearchitemname = New System.Windows.Forms.TextBox()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.btndeletelab = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dglab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstallergyitem
        '
        Me.lstallergyitem.FormattingEnabled = True
        Me.lstallergyitem.Location = New System.Drawing.Point(537, 111)
        Me.lstallergyitem.Name = "lstallergyitem"
        Me.lstallergyitem.Size = New System.Drawing.Size(321, 381)
        Me.lstallergyitem.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SkyBlue
        Me.GroupBox1.Controls.Add(Me.chkconst)
        Me.GroupBox1.Controls.Add(Me.ddtestlab)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.dddept)
        Me.GroupBox1.Controls.Add(Me.ddtype)
        Me.GroupBox1.Controls.Add(Me.ddcategory)
        Me.GroupBox1.Controls.Add(Me.txtunregisteredcharge)
        Me.GroupBox1.Controls.Add(Me.txtregisteredcharges)
        Me.GroupBox1.Controls.Add(Me.txtdelivery)
        Me.GroupBox1.Controls.Add(Me.txtshortname)
        Me.GroupBox1.Controls.Add(Me.txtitemname)
        Me.GroupBox1.Controls.Add(Me.txtitemid)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(486, 285)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'chkconst
        '
        Me.chkconst.AutoSize = True
        Me.chkconst.Location = New System.Drawing.Point(25, 246)
        Me.chkconst.Name = "chkconst"
        Me.chkconst.Size = New System.Drawing.Size(116, 17)
        Me.chkconst.TabIndex = 22
        Me.chkconst.Text = "Only for registration"
        Me.chkconst.UseVisualStyleBackColor = True
        '
        'ddtestlab
        '
        Me.ddtestlab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddtestlab.FormattingEnabled = True
        Me.ddtestlab.Location = New System.Drawing.Point(287, 174)
        Me.ddtestlab.Name = "ddtestlab"
        Me.ddtestlab.Size = New System.Drawing.Size(181, 21)
        Me.ddtestlab.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(218, 177)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 23)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Test Lab"
        '
        'dddept
        '
        Me.dddept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dddept.FormattingEnabled = True
        Me.dddept.Location = New System.Drawing.Point(289, 140)
        Me.dddept.Name = "dddept"
        Me.dddept.Size = New System.Drawing.Size(121, 21)
        Me.dddept.TabIndex = 19
        '
        'ddtype
        '
        Me.ddtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddtype.FormattingEnabled = True
        Me.ddtype.Location = New System.Drawing.Point(91, 177)
        Me.ddtype.Name = "ddtype"
        Me.ddtype.Size = New System.Drawing.Size(121, 21)
        Me.ddtype.TabIndex = 18
        '
        'ddcategory
        '
        Me.ddcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddcategory.FormattingEnabled = True
        Me.ddcategory.Location = New System.Drawing.Point(91, 143)
        Me.ddcategory.Name = "ddcategory"
        Me.ddcategory.Size = New System.Drawing.Size(121, 21)
        Me.ddcategory.TabIndex = 17
        '
        'txtunregisteredcharge
        '
        Me.txtunregisteredcharge.Location = New System.Drawing.Point(345, 219)
        Me.txtunregisteredcharge.Name = "txtunregisteredcharge"
        Me.txtunregisteredcharge.Size = New System.Drawing.Size(112, 20)
        Me.txtunregisteredcharge.TabIndex = 16
        Me.txtunregisteredcharge.Visible = False
        '
        'txtregisteredcharges
        '
        Me.txtregisteredcharges.Location = New System.Drawing.Point(150, 219)
        Me.txtregisteredcharges.Name = "txtregisteredcharges"
        Me.txtregisteredcharges.Size = New System.Drawing.Size(104, 20)
        Me.txtregisteredcharges.TabIndex = 15
        '
        'txtdelivery
        '
        Me.txtdelivery.Location = New System.Drawing.Point(289, 109)
        Me.txtdelivery.Name = "txtdelivery"
        Me.txtdelivery.Size = New System.Drawing.Size(136, 20)
        Me.txtdelivery.TabIndex = 14
        '
        'txtshortname
        '
        Me.txtshortname.Location = New System.Drawing.Point(91, 106)
        Me.txtshortname.Name = "txtshortname"
        Me.txtshortname.Size = New System.Drawing.Size(119, 20)
        Me.txtshortname.TabIndex = 13
        '
        'txtitemname
        '
        Me.txtitemname.Location = New System.Drawing.Point(91, 76)
        Me.txtitemname.Name = "txtitemname"
        Me.txtitemname.Size = New System.Drawing.Size(340, 20)
        Me.txtitemname.TabIndex = 12
        '
        'txtitemid
        '
        Me.txtitemid.Location = New System.Drawing.Point(91, 50)
        Me.txtitemid.Name = "txtitemid"
        Me.txtitemid.Size = New System.Drawing.Size(136, 20)
        Me.txtitemid.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(262, 219)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 23)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Unregistered :"
        Me.Label11.Visible = False
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(82, 222)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 23)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Registered :"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(22, 219)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 23)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Charges"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(22, 177)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 23)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Type :"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(218, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 23)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "For Dept. :"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(22, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Category :"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(218, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Delivery :"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(22, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Short Name"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(22, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Item Name:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(22, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Item Id :"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(3, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(480, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Allergy Test Item Master"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dglab)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 369)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(500, 175)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'dglab
        '
        Me.dglab.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dglab.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dglab.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dglab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dglab.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.labid, Me.labname, Me.Delvdays, Me.Rate})
        Me.dglab.Location = New System.Drawing.Point(2, 19)
        Me.dglab.Name = "dglab"
        Me.dglab.Size = New System.Drawing.Size(492, 150)
        Me.dglab.TabIndex = 0
        '
        'labid
        '
        Me.labid.HeaderText = ""
        Me.labid.Name = "labid"
        Me.labid.Visible = False
        '
        'labname
        '
        Me.labname.DataPropertyName = "labname"
        Me.labname.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.labname.FillWeight = 69.96617!
        Me.labname.HeaderText = "Lab Description"
        Me.labname.Name = "labname"
        Me.labname.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.labname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Delvdays
        '
        Me.Delvdays.DataPropertyName = "delvdays"
        Me.Delvdays.FillWeight = 39.98715!
        Me.Delvdays.HeaderText = "Delivery Days"
        Me.Delvdays.MaxInputLength = 3
        Me.Delvdays.Name = "Delvdays"
        '
        'Rate
        '
        Me.Rate.DataPropertyName = "rate"
        Me.Rate.FillWeight = 37.39909!
        Me.Rate.HeaderText = "Rate"
        Me.Rate.MaxInputLength = 6
        Me.Rate.Name = "Rate"
        '
        'btnsave
        '
        Me.btnsave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnsave.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(468, 19)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(102, 34)
        Me.btnsave.TabIndex = 4
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnClose.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(586, 19)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(102, 34)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(534, 12)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(97, 28)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Item Name"
        '
        'txtsearchitemname
        '
        Me.txtsearchitemname.Location = New System.Drawing.Point(638, 13)
        Me.txtsearchitemname.Name = "txtsearchitemname"
        Me.txtsearchitemname.Size = New System.Drawing.Size(182, 20)
        Me.txtsearchitemname.TabIndex = 7
        '
        'btnsearch
        '
        Me.btnsearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnsearch.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.Location = New System.Drawing.Point(26, 17)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(102, 34)
        Me.btnsearch.TabIndex = 8
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'btndeletelab
        '
        Me.btndeletelab.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btndeletelab.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btndeletelab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndeletelab.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeletelab.Location = New System.Drawing.Point(12, 19)
        Me.btndeletelab.Name = "btndeletelab"
        Me.btndeletelab.Size = New System.Drawing.Size(102, 34)
        Me.btndeletelab.TabIndex = 9
        Me.btndeletelab.Text = "Delete Lab"
        Me.btndeletelab.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnadd.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(337, 19)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(102, 34)
        Me.btnadd.TabIndex = 10
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnadd)
        Me.GroupBox4.Controls.Add(Me.btnsave)
        Me.GroupBox4.Controls.Add(Me.btnClose)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox4.Location = New System.Drawing.Point(0, 638)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(951, 67)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btndeletelab)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 562)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(138, 76)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnsearch)
        Me.GroupBox5.Location = New System.Drawing.Point(553, 39)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(143, 60)
        Me.GroupBox5.TabIndex = 13
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "GroupBox5"
        '
        'AlergyTestItemMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(967, 582)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.txtsearchitemname)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstallergyitem)
        Me.Name = "AlergyTestItemMaster"
        Me.Text = "AlergyTestItemMaster"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dglab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstallergyitem As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dddept As System.Windows.Forms.ComboBox
    Friend WithEvents ddtype As System.Windows.Forms.ComboBox
    Friend WithEvents ddcategory As System.Windows.Forms.ComboBox
    Friend WithEvents txtunregisteredcharge As System.Windows.Forms.TextBox
    Friend WithEvents txtregisteredcharges As System.Windows.Forms.TextBox
    Friend WithEvents txtdelivery As System.Windows.Forms.TextBox
    Friend WithEvents txtshortname As System.Windows.Forms.TextBox
    Friend WithEvents txtitemname As System.Windows.Forms.TextBox
    Friend WithEvents txtitemid As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dglab As System.Windows.Forms.DataGridView
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtsearchitemname As System.Windows.Forms.TextBox
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents labid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents labname As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Delvdays As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btndeletelab As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ddtestlab As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents chkconst As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
End Class
