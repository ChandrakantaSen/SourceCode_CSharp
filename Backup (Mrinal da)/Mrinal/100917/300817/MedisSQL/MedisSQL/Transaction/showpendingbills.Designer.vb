<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class showpendingbills
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgbillsummary = New System.Windows.Forms.DataGridView()
        Me.billid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.patientfk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.billtype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.billno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.patientname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.billdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.billvalue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paidamount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Outstandingamt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgbillsummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgbillsummary)
        Me.GroupBox1.Location = New System.Drawing.Point(50, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(811, 244)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'dgbillsummary
        '
        Me.dgbillsummary.AllowUserToAddRows = False
        Me.dgbillsummary.AllowUserToDeleteRows = False
        Me.dgbillsummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbillsummary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.billid, Me.patientfk, Me.billtype, Me.billno, Me.patientname, Me.billdate, Me.billvalue, Me.paidamount, Me.Outstandingamt})
        Me.dgbillsummary.Location = New System.Drawing.Point(42, 19)
        Me.dgbillsummary.Name = "dgbillsummary"
        Me.dgbillsummary.ReadOnly = True
        Me.dgbillsummary.Size = New System.Drawing.Size(746, 150)
        Me.dgbillsummary.TabIndex = 0
        '
        'billid
        '
        Me.billid.DataPropertyName = "billid"
        Me.billid.HeaderText = "Bill ID"
        Me.billid.Name = "billid"
        Me.billid.ReadOnly = True
        Me.billid.Visible = False
        '
        'patientfk
        '
        Me.patientfk.DataPropertyName = "patientfk"
        Me.patientfk.HeaderText = "patientfk"
        Me.patientfk.Name = "patientfk"
        Me.patientfk.ReadOnly = True
        Me.patientfk.Visible = False
        '
        'billtype
        '
        Me.billtype.DataPropertyName = "billtype"
        Me.billtype.HeaderText = "Bill Type"
        Me.billtype.Name = "billtype"
        Me.billtype.ReadOnly = True
        '
        'billno
        '
        Me.billno.DataPropertyName = "AblId"
        Me.billno.HeaderText = "Bill No."
        Me.billno.Name = "billno"
        Me.billno.ReadOnly = True
        '
        'patientname
        '
        Me.patientname.DataPropertyName = "patientname"
        Me.patientname.HeaderText = "Patient Name"
        Me.patientname.Name = "patientname"
        Me.patientname.ReadOnly = True
        '
        'billdate
        '
        Me.billdate.DataPropertyName = "billdate"
        Me.billdate.HeaderText = "Bill Date"
        Me.billdate.Name = "billdate"
        Me.billdate.ReadOnly = True
        '
        'billvalue
        '
        Me.billvalue.DataPropertyName = "billvalue"
        Me.billvalue.HeaderText = "Bill Value"
        Me.billvalue.Name = "billvalue"
        Me.billvalue.ReadOnly = True
        '
        'paidamount
        '
        Me.paidamount.DataPropertyName = "billpaid"
        Me.paidamount.HeaderText = "Amount Paid"
        Me.paidamount.Name = "paidamount"
        Me.paidamount.ReadOnly = True
        '
        'Outstandingamt
        '
        Me.Outstandingamt.DataPropertyName = "outstanding"
        Me.Outstandingamt.HeaderText = "Outstanding Amount"
        Me.Outstandingamt.Name = "Outstandingamt"
        Me.Outstandingamt.ReadOnly = True
        '
        'showpendingbills
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 484)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "showpendingbills"
        Me.Text = "showpendingbills"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgbillsummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgbillsummary As System.Windows.Forms.DataGridView
    Friend WithEvents billid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents patientfk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents billtype As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents billno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents patientname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents billdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents billvalue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents paidamount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Outstandingamt As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
