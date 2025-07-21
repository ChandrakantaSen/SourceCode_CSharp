<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container()
        Dim FetchstudentBindingSource As System.Windows.Forms.BindingSource
        Me.TestDataSet = New Test.TestDataSet()
        Me.cboNme = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FetchstudentTableAdapter = New Test.TestDataSetTableAdapters.fetchstudentTableAdapter()
        Me.dg = New System.Windows.Forms.DataGridView()
        FetchstudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(FetchstudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FetchstudentBindingSource
        '
        FetchstudentBindingSource.DataMember = "fetchstudent"
        FetchstudentBindingSource.DataSource = Me.TestDataSet
        '
        'TestDataSet
        '
        Me.TestDataSet.DataSetName = "TestDataSet"
        Me.TestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboNme
        '
        Me.cboNme.FormattingEnabled = True
        Me.cboNme.Location = New System.Drawing.Point(105, 12)
        Me.cboNme.Name = "cboNme"
        Me.cboNme.Size = New System.Drawing.Size(121, 21)
        Me.cboNme.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'FetchstudentTableAdapter
        '
        Me.FetchstudentTableAdapter.ClearBeforeFill = True
        '
        'dg
        '
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(19, 64)
        Me.dg.Name = "dg"
        Me.dg.Size = New System.Drawing.Size(496, 94)
        Me.dg.TabIndex = 2
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 262)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboNme)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(FetchstudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboNme As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TestDataSet As Test.TestDataSet
    Friend WithEvents FetchstudentTableAdapter As Test.TestDataSetTableAdapters.fetchstudentTableAdapter
    Friend WithEvents dg As System.Windows.Forms.DataGridView
End Class
