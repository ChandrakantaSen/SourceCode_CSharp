<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddAgentMaster
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
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkinhouseagent = New System.Windows.Forms.CheckBox()
        Me.ddtitle = New System.Windows.Forms.ComboBox()
        Me.txtcontactno = New System.Windows.Forms.TextBox()
        Me.txtagentaddress = New System.Windows.Forms.TextBox()
        Me.txtagentname = New System.Windows.Forms.TextBox()
        Me.txtagentid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.lstAgent = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbltitle
        '
        Me.lbltitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltitle.BackColor = System.Drawing.Color.SteelBlue
        Me.lbltitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.Gold
        Me.lbltitle.Location = New System.Drawing.Point(0, 0)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(986, 28)
        Me.lbltitle.TabIndex = 0
        Me.lbltitle.Text = "Agent Master Form"
        Me.lbltitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Cornsilk
        Me.GroupBox1.Controls.Add(Me.chkinhouseagent)
        Me.GroupBox1.Controls.Add(Me.ddtitle)
        Me.GroupBox1.Controls.Add(Me.txtcontactno)
        Me.GroupBox1.Controls.Add(Me.txtagentaddress)
        Me.GroupBox1.Controls.Add(Me.txtagentname)
        Me.GroupBox1.Controls.Add(Me.txtagentid)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(564, 269)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'chkinhouseagent
        '
        Me.chkinhouseagent.AutoSize = True
        Me.chkinhouseagent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkinhouseagent.Location = New System.Drawing.Point(322, 23)
        Me.chkinhouseagent.Name = "chkinhouseagent"
        Me.chkinhouseagent.Size = New System.Drawing.Size(114, 17)
        Me.chkinhouseagent.TabIndex = 13
        Me.chkinhouseagent.Text = "In House Agent"
        Me.chkinhouseagent.UseVisualStyleBackColor = True
        '
        'ddtitle
        '
        Me.ddtitle.FormattingEnabled = True
        Me.ddtitle.Items.AddRange(New Object() {"Shri", "Smt.", "Mr.", "Mrs.", "Miss"})
        Me.ddtitle.Location = New System.Drawing.Point(166, 58)
        Me.ddtitle.Name = "ddtitle"
        Me.ddtitle.Size = New System.Drawing.Size(64, 21)
        Me.ddtitle.TabIndex = 12
        '
        'txtcontactno
        '
        Me.txtcontactno.Location = New System.Drawing.Point(166, 152)
        Me.txtcontactno.Multiline = True
        Me.txtcontactno.Name = "txtcontactno"
        Me.txtcontactno.Size = New System.Drawing.Size(357, 53)
        Me.txtcontactno.TabIndex = 11
        '
        'txtagentaddress
        '
        Me.txtagentaddress.Location = New System.Drawing.Point(166, 96)
        Me.txtagentaddress.Multiline = True
        Me.txtagentaddress.Name = "txtagentaddress"
        Me.txtagentaddress.Size = New System.Drawing.Size(357, 34)
        Me.txtagentaddress.TabIndex = 10
        '
        'txtagentname
        '
        Me.txtagentname.Location = New System.Drawing.Point(236, 58)
        Me.txtagentname.Name = "txtagentname"
        Me.txtagentname.Size = New System.Drawing.Size(287, 20)
        Me.txtagentname.TabIndex = 9
        '
        'txtagentid
        '
        Me.txtagentid.Location = New System.Drawing.Point(166, 20)
        Me.txtagentid.Name = "txtagentid"
        Me.txtagentid.Size = New System.Drawing.Size(94, 20)
        Me.txtagentid.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 22)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Telephone / Fax Mobile Email"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Agent Address"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 22)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Agent Name"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Agent ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.btnexit)
        Me.GroupBox2.Controls.Add(Me.btnadd)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(3, 211)
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
        'lstAgent
        '
        Me.lstAgent.FormattingEnabled = True
        Me.lstAgent.Location = New System.Drawing.Point(597, 42)
        Me.lstAgent.Name = "lstAgent"
        Me.lstAgent.Size = New System.Drawing.Size(209, 277)
        Me.lstAgent.TabIndex = 2
        '
        'AddAgentMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(986, 406)
        Me.Controls.Add(Me.lstAgent)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbltitle)
        Me.Name = "AddAgentMaster"
        Me.Text = "AddAgentMaster"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcontactno As System.Windows.Forms.TextBox
    Friend WithEvents txtagentaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtagentname As System.Windows.Forms.TextBox
    Friend WithEvents txtagentid As System.Windows.Forms.TextBox
    Friend WithEvents ddtitle As System.Windows.Forms.ComboBox
    Friend WithEvents chkinhouseagent As System.Windows.Forms.CheckBox
    Friend WithEvents lstAgent As ListBox
    Friend WithEvents btnSave As Button
End Class
