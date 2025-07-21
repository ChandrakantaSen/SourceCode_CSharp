<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usersecurity_FormLevel
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
        Me.tview = New System.Windows.Forms.TreeView()
        Me.dduser = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tview
        '
        Me.tview.BackColor = System.Drawing.SystemColors.Info
        Me.tview.Location = New System.Drawing.Point(12, 12)
        Me.tview.Name = "tview"
        Me.tview.Size = New System.Drawing.Size(276, 368)
        Me.tview.TabIndex = 0
        '
        'dduser
        '
        Me.dduser.FormattingEnabled = True
        Me.dduser.Location = New System.Drawing.Point(415, 11)
        Me.dduser.Name = "dduser"
        Me.dduser.Size = New System.Drawing.Size(145, 21)
        Me.dduser.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(330, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "User "
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(439, 81)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(92, 28)
        Me.btnsave.TabIndex = 3
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Usersecurity_FormLevel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 415)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dduser)
        Me.Controls.Add(Me.tview)
        Me.Name = "Usersecurity_FormLevel"
        Me.Text = "Menu Level User Security"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tview As System.Windows.Forms.TreeView
    Friend WithEvents dduser As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnsave As System.Windows.Forms.Button
End Class
