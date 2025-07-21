<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReferenceMaster
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
        Me.lstRefMas = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkinhouseDoc = New System.Windows.Forms.CheckBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPIN = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbAgntId = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbDistID = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbAreaCode = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ddtitle = New System.Windows.Forms.ComboBox()
        Me.txtPh1 = New System.Windows.Forms.TextBox()
        Me.txtRefAddress = New System.Windows.Forms.TextBox()
        Me.txtRefName = New System.Windows.Forms.TextBox()
        Me.txtRefId = New System.Windows.Forms.TextBox()
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
        'lstRefMas
        '
        Me.lstRefMas.FormattingEnabled = True
        Me.lstRefMas.Location = New System.Drawing.Point(591, 89)
        Me.lstRefMas.Name = "lstRefMas"
        Me.lstRefMas.Size = New System.Drawing.Size(209, 407)
        Me.lstRefMas.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Cornsilk
        Me.GroupBox1.Controls.Add(Me.chkinhouseDoc)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtPIN)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cmbAgntId)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmbDistID)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmbAreaCode)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ddtitle)
        Me.GroupBox1.Controls.Add(Me.txtPh1)
        Me.GroupBox1.Controls.Add(Me.txtRefAddress)
        Me.GroupBox1.Controls.Add(Me.txtRefName)
        Me.GroupBox1.Controls.Add(Me.txtRefId)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(564, 404)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'chkinhouseDoc
        '
        Me.chkinhouseDoc.AutoSize = True
        Me.chkinhouseDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkinhouseDoc.Location = New System.Drawing.Point(382, 50)
        Me.chkinhouseDoc.Name = "chkinhouseDoc"
        Me.chkinhouseDoc.Size = New System.Drawing.Size(119, 17)
        Me.chkinhouseDoc.TabIndex = 27
        Me.chkinhouseDoc.Text = "In House Doctor"
        Me.chkinhouseDoc.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(174, 106)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(357, 20)
        Me.TextBox4.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(40, 106)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(128, 22)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Alternate Name"
        '
        'txtPIN
        '
        Me.txtPIN.Location = New System.Drawing.Point(434, 252)
        Me.txtPIN.MaxLength = 6
        Me.txtPIN.Name = "txtPIN"
        Me.txtPIN.Size = New System.Drawing.Size(97, 20)
        Me.txtPIN.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(379, 251)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 22)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "PIN"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(174, 278)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(357, 20)
        Me.txtEmail.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(40, 278)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 22)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "E mail"
        '
        'cmbAgntId
        '
        Me.cmbAgntId.FormattingEnabled = True
        Me.cmbAgntId.Location = New System.Drawing.Point(174, 305)
        Me.cmbAgntId.Name = "cmbAgntId"
        Me.cmbAgntId.Size = New System.Drawing.Size(175, 21)
        Me.cmbAgntId.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(40, 305)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 22)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Agent"
        '
        'cmbDistID
        '
        Me.cmbDistID.FormattingEnabled = True
        Me.cmbDistID.Location = New System.Drawing.Point(174, 252)
        Me.cmbDistID.Name = "cmbDistID"
        Me.cmbDistID.Size = New System.Drawing.Size(168, 21)
        Me.cmbDistID.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 22)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "District"
        '
        'cmbAreaCode
        '
        Me.cmbAreaCode.FormattingEnabled = True
        Me.cmbAreaCode.Location = New System.Drawing.Point(174, 50)
        Me.cmbAreaCode.Name = "cmbAreaCode"
        Me.cmbAreaCode.Size = New System.Drawing.Size(175, 21)
        Me.cmbAreaCode.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 22)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Area Name"
        '
        'ddtitle
        '
        Me.ddtitle.FormattingEnabled = True
        Me.ddtitle.Items.AddRange(New Object() {"Shri", "Smt.", "Mr.", "Mrs.", "Miss", "Dr.", "Dr. Mrs.", "Ms"})
        Me.ddtitle.Location = New System.Drawing.Point(174, 78)
        Me.ddtitle.Name = "ddtitle"
        Me.ddtitle.Size = New System.Drawing.Size(64, 21)
        Me.ddtitle.TabIndex = 12
        '
        'txtPh1
        '
        Me.txtPh1.Location = New System.Drawing.Point(174, 204)
        Me.txtPh1.Multiline = True
        Me.txtPh1.Name = "txtPh1"
        Me.txtPh1.Size = New System.Drawing.Size(357, 39)
        Me.txtPh1.TabIndex = 11
        '
        'txtRefAddress
        '
        Me.txtRefAddress.Location = New System.Drawing.Point(174, 133)
        Me.txtRefAddress.Multiline = True
        Me.txtRefAddress.Name = "txtRefAddress"
        Me.txtRefAddress.Size = New System.Drawing.Size(357, 64)
        Me.txtRefAddress.TabIndex = 10
        '
        'txtRefName
        '
        Me.txtRefName.Location = New System.Drawing.Point(244, 79)
        Me.txtRefName.Name = "txtRefName"
        Me.txtRefName.Size = New System.Drawing.Size(287, 20)
        Me.txtRefName.TabIndex = 9
        '
        'txtRefId
        '
        Me.txtRefId.Location = New System.Drawing.Point(352, 20)
        Me.txtRefId.Name = "txtRefId"
        Me.txtRefId.Size = New System.Drawing.Size(94, 20)
        Me.txtRefId.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 22)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Telephone / Fax Mobile Email"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Address"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 22)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(233, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Reference Id"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.btnexit)
        Me.GroupBox2.Controls.Add(Me.btnadd)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(3, 348)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(558, 53)
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
        Me.lbltitle.Location = New System.Drawing.Point(20, 41)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(916, 28)
        Me.lbltitle.TabIndex = 6
        Me.lbltitle.Text = "Reference Master Form"
        Me.lbltitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmReferenceMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 534)
        Me.Controls.Add(Me.lstRefMas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbltitle)
        Me.Name = "frmReferenceMaster"
        Me.Text = "Reference Master"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstRefMas As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPIN As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbAgntId As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbDistID As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbAreaCode As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ddtitle As ComboBox
    Friend WithEvents txtPh1 As TextBox
    Friend WithEvents txtRefAddress As TextBox
    Friend WithEvents txtRefName As TextBox
    Friend WithEvents txtRefId As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents lbltitle As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents chkinhouseDoc As CheckBox
End Class
