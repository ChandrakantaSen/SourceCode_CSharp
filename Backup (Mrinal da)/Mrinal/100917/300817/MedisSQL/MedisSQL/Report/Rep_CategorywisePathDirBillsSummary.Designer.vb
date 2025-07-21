<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Rep_CategorywisePathDirBillsSummary
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgitemsummary = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtfromdate = New System.Windows.Forms.TextBox()
        Me.txttodate = New System.Windows.Forms.TextBox()
        Me.testitemid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.testitemdesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemqty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalamount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgitemsummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Olive
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1107, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ALLERGY && ASTHMA TREATMENT CENTRE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkKhaki
        Me.GroupBox1.Controls.Add(Me.dgitemsummary)
        Me.GroupBox1.Location = New System.Drawing.Point(221, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(660, 338)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'dgitemsummary
        '
        Me.dgitemsummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgitemsummary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.testitemid, Me.testitemdesc, Me.itemqty, Me.totalamount})
        Me.dgitemsummary.Location = New System.Drawing.Point(15, 28)
        Me.dgitemsummary.Name = "dgitemsummary"
        Me.dgitemsummary.Size = New System.Drawing.Size(630, 289)
        Me.dgitemsummary.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(320, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Test List For the period between "
        '
        'txtfromdate
        '
        Me.txtfromdate.Location = New System.Drawing.Point(491, 46)
        Me.txtfromdate.Name = "txtfromdate"
        Me.txtfromdate.Size = New System.Drawing.Size(100, 20)
        Me.txtfromdate.TabIndex = 3
        '
        'txttodate
        '
        Me.txttodate.Location = New System.Drawing.Point(654, 46)
        Me.txttodate.Name = "txttodate"
        Me.txttodate.Size = New System.Drawing.Size(100, 20)
        Me.txttodate.TabIndex = 4
        '
        'testitemid
        '
        Me.testitemid.DataPropertyName = "categoryid"
        Me.testitemid.HeaderText = "testitemid"
        Me.testitemid.Name = "testitemid"
        Me.testitemid.Visible = False
        '
        'testitemdesc
        '
        Me.testitemdesc.DataPropertyName = "OCat"
        Me.testitemdesc.HeaderText = "Test Description"
        Me.testitemdesc.Name = "testitemdesc"
        '
        'itemqty
        '
        Me.itemqty.DataPropertyName = "itemqty"
        Me.itemqty.HeaderText = "No.s"
        Me.itemqty.Name = "itemqty"
        '
        'totalamount
        '
        Me.totalamount.DataPropertyName = "totalamount"
        Me.totalamount.HeaderText = "Amount"
        Me.totalamount.Name = "totalamount"
        '
        'Rep_CategorywisePathBillsSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1107, 750)
        Me.Controls.Add(Me.txttodate)
        Me.Controls.Add(Me.txtfromdate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Rep_CategorywisePathBillsSummary"
        Me.Text = "Rep_CategorywisePathBillsSummary"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgitemsummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgitemsummary As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtfromdate As TextBox
    Friend WithEvents txttodate As TextBox
    Friend WithEvents testitemid As DataGridViewTextBoxColumn
    Friend WithEvents testitemdesc As DataGridViewTextBoxColumn
    Friend WithEvents itemqty As DataGridViewTextBoxColumn
    Friend WithEvents totalamount As DataGridViewTextBoxColumn
End Class
