<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userSecurity_FormEvent
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
        Me.gvmenu = New System.Windows.Forms.DataGridView()
        Me.MenuName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Addition = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.edit = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.delete = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.view = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.menuid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.dduser = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.Button()
        CType(Me.gvmenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gvmenu
        '
        Me.gvmenu.AllowUserToAddRows = False
        Me.gvmenu.AllowUserToDeleteRows = False
        Me.gvmenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gvmenu.BackgroundColor = System.Drawing.Color.DeepSkyBlue
        Me.gvmenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvmenu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MenuName, Me.Addition, Me.edit, Me.delete, Me.view, Me.menuid})
        Me.gvmenu.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.gvmenu.GridColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvmenu.Location = New System.Drawing.Point(0, 8)
        Me.gvmenu.Name = "gvmenu"
        Me.gvmenu.RowHeadersVisible = False
        Me.gvmenu.RowHeadersWidth = 25
        Me.gvmenu.Size = New System.Drawing.Size(541, 37)
        Me.gvmenu.TabIndex = 0
        '
        'MenuName
        '
        Me.MenuName.DataPropertyName = "menuname"
        Me.MenuName.HeaderText = "Menu"
        Me.MenuName.Name = "MenuName"
        Me.MenuName.ReadOnly = True
        Me.MenuName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Addition
        '
        Me.Addition.DataPropertyName = "Addition"
        Me.Addition.HeaderText = "Add"
        Me.Addition.Name = "Addition"
        '
        'edit
        '
        Me.edit.DataPropertyName = "edit"
        Me.edit.HeaderText = "Edit"
        Me.edit.Name = "edit"
        '
        'delete
        '
        Me.delete.DataPropertyName = "delete"
        Me.delete.HeaderText = "Delete"
        Me.delete.Name = "delete"
        '
        'view
        '
        Me.view.DataPropertyName = "view"
        Me.view.HeaderText = "View"
        Me.view.Name = "view"
        '
        'menuid
        '
        Me.menuid.DataPropertyName = "menuid"
        Me.menuid.HeaderText = ""
        Me.menuid.Name = "menuid"
        Me.menuid.Visible = False
        '
        'btnsave
        '
        Me.btnsave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnsave.Location = New System.Drawing.Point(216, 146)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 1
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'dduser
        '
        Me.dduser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dduser.FormattingEnabled = True
        Me.dduser.Location = New System.Drawing.Point(274, 52)
        Me.dduser.Name = "dduser"
        Me.dduser.Size = New System.Drawing.Size(121, 24)
        Me.dduser.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(195, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "User"
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.Controls.Add(Me.gvmenu)
        Me.Panel1.Location = New System.Drawing.Point(76, 92)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(544, 48)
        Me.Panel1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Linen
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(671, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Page Level Security"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnclose
        '
        Me.btnclose.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnclose.Location = New System.Drawing.Point(307, 146)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(72, 23)
        Me.btnclose.TabIndex = 6
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'userSecurity_FormEvent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(671, 355)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dduser)
        Me.Controls.Add(Me.btnsave)
        Me.Name = "userSecurity_FormEvent"
        Me.Text = "userSecurity_FormEvent"
        CType(Me.gvmenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gvmenu As System.Windows.Forms.DataGridView
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents dduser As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Addition As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents edit As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents delete As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents view As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents menuid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
End Class
