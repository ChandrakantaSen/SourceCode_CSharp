<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class searchAgentMaster
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.txtagentname = New System.Windows.Forms.TextBox()
        Me.txtagentid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgagent = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgntId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgntName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgntAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgntTelEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Inhouse = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.commandname = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgagent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.GroupBox1.Controls.Add(Me.btnsearch)
        Me.GroupBox1.Controls.Add(Me.txtagentname)
        Me.GroupBox1.Controls.Add(Me.txtagentid)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(684, 106)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.SkyBlue
        Me.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.Location = New System.Drawing.Point(28, 60)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(75, 24)
        Me.btnsearch.TabIndex = 4
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'txtagentname
        '
        Me.txtagentname.Location = New System.Drawing.Point(305, 20)
        Me.txtagentname.Name = "txtagentname"
        Me.txtagentname.Size = New System.Drawing.Size(158, 20)
        Me.txtagentname.TabIndex = 3
        '
        'txtagentid
        '
        Me.txtagentid.Location = New System.Drawing.Point(111, 20)
        Me.txtagentid.Name = "txtagentid"
        Me.txtagentid.Size = New System.Drawing.Size(82, 20)
        Me.txtagentid.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(199, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Agent Name"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Agent ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox2.Controls.Add(Me.dgagent)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(67, 116)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(577, 206)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'dgagent
        '
        Me.dgagent.AllowUserToAddRows = False
        Me.dgagent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgagent.BackgroundColor = System.Drawing.Color.CadetBlue
        Me.dgagent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgagent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.AgntId, Me.AgntName, Me.AgntAddress, Me.AgntTelEmail, Me.Inhouse, Me.commandname})
        Me.dgagent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgagent.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgagent.Location = New System.Drawing.Point(3, 16)
        Me.dgagent.Name = "dgagent"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgagent.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgagent.RowHeadersVisible = False
        Me.dgagent.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightBlue
        Me.dgagent.Size = New System.Drawing.Size(571, 187)
        Me.dgagent.TabIndex = 0
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = ""
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'AgntId
        '
        Me.AgntId.DataPropertyName = "AgntId"
        Me.AgntId.HeaderText = "Agent Id"
        Me.AgntId.Name = "AgntId"
        '
        'AgntName
        '
        Me.AgntName.DataPropertyName = "AgntName"
        Me.AgntName.HeaderText = "Agent Name"
        Me.AgntName.Name = "AgntName"
        '
        'AgntAddress
        '
        Me.AgntAddress.DataPropertyName = "AgntAddress"
        Me.AgntAddress.HeaderText = "Agent Address"
        Me.AgntAddress.Name = "AgntAddress"
        '
        'AgntTelEmail
        '
        Me.AgntTelEmail.DataPropertyName = "AgntTelEmail"
        Me.AgntTelEmail.HeaderText = "Contact No"
        Me.AgntTelEmail.Name = "AgntTelEmail"
        '
        'Inhouse
        '
        Me.Inhouse.DataPropertyName = "Inhouse"
        Me.Inhouse.HeaderText = "inhouse"
        Me.Inhouse.Name = "Inhouse"
        Me.Inhouse.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Inhouse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'commandname
        '
        Me.commandname.DataPropertyName = "commandname"
        Me.commandname.HeaderText = "Action"
        Me.commandname.Name = "commandname"
        Me.commandname.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.commandname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'searchAgentMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(709, 334)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "searchAgentMaster"
        Me.Text = "searchAgentMaster"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgagent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtagentname As System.Windows.Forms.TextBox
    Friend WithEvents txtagentid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgagent As System.Windows.Forms.DataGridView
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgntId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgntName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgntAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgntTelEmail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Inhouse As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents commandname As System.Windows.Forms.DataGridViewButtonColumn
End Class
