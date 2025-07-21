<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPtData
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
        Dim PatientIdLabel As System.Windows.Forms.Label
        Dim DateVisitLabel As System.Windows.Forms.Label
        Dim PhysicianIdLabel As System.Windows.Forms.Label
        Dim PtSexLabel As System.Windows.Forms.Label
        Dim PtAgeLabel As System.Windows.Forms.Label
        Dim PtHeightLabel As System.Windows.Forms.Label
        Dim PtWeightLabel As System.Windows.Forms.Label
        Dim DysSPLabel As System.Windows.Forms.Label
        Dim SeasIDLabel As System.Windows.Forms.Label
        Dim BPHisLabel As System.Windows.Forms.Label
        Dim BPDHisLabel As System.Windows.Forms.Label
        Dim BPPlsLabel As System.Windows.Forms.Label
        Dim MucousMembraneLabel As System.Windows.Forms.Label
        Dim NoseLabel As System.Windows.Forms.Label
        Dim ThroatLabel As System.Windows.Forms.Label
        Dim AirEntryLabel As System.Windows.Forms.Label
        Dim ChestLabel As System.Windows.Forms.Label
        Dim OtherPhysicalLabel As System.Windows.Forms.Label
        Dim PhysNotesLabel As System.Windows.Forms.Label
        Dim NotesLabel As System.Windows.Forms.Label
        Dim AdviceLabel As System.Windows.Forms.Label
        Dim InvstRestLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim MedIdLabel As System.Windows.Forms.Label
        Dim SlNoLabel As System.Windows.Forms.Label
        Dim DosageLabel As System.Windows.Forms.Label
        Dim DTypeLabel As System.Windows.Forms.Label
        Dim FreqIdLabel As System.Windows.Forms.Label
        Dim DurationLabel As System.Windows.Forms.Label
        Dim DwmLabel As System.Windows.Forms.Label
        Dim AbmealLabel As System.Windows.Forms.Label
        Dim MedDescLabel As System.Windows.Forms.Label
        Dim VaxRationLabel As System.Windows.Forms.Label
        Dim VaxVialLabel As System.Windows.Forms.Label
        Me.PatientIdTextBox = New System.Windows.Forms.TextBox()
        Me.DateVisitDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PtSexTextBox = New System.Windows.Forms.TextBox()
        Me.PtAgeTextBox = New System.Windows.Forms.TextBox()
        Me.PtAgeMonTextBox = New System.Windows.Forms.TextBox()
        Me.PtHeightTextBox = New System.Windows.Forms.TextBox()
        Me.PtWeightTextBox = New System.Windows.Forms.TextBox()
        Me.VisitDoneCheckBox = New System.Windows.Forms.CheckBox()
        Me.OcrDayCheckBox = New System.Windows.Forms.CheckBox()
        Me.OcrNightCheckBox = New System.Windows.Forms.CheckBox()
        Me.OcrAnyCheckBox = New System.Windows.Forms.CheckBox()
        Me.OcrEMCheckBox = New System.Windows.Forms.CheckBox()
        Me.OcrEveCheckBox = New System.Windows.Forms.CheckBox()
        Me.ErythemaCheckBox = New System.Windows.Forms.CheckBox()
        Me.DermatographismCheckBox = New System.Windows.Forms.CheckBox()
        Me.PallorCheckBox = New System.Windows.Forms.CheckBox()
        Me.OedemaCheckBox = New System.Windows.Forms.CheckBox()
        Me.ClubbingCheckBox = New System.Windows.Forms.CheckBox()
        Me.BPHisTextBox = New System.Windows.Forms.TextBox()
        Me.BPDHisTextBox = New System.Windows.Forms.TextBox()
        Me.BPPlsTextBox = New System.Windows.Forms.TextBox()
        Me.MucousMembraneTextBox = New System.Windows.Forms.TextBox()
        Me.NoseTextBox = New System.Windows.Forms.TextBox()
        Me.ThroatTextBox = New System.Windows.Forms.TextBox()
        Me.AirEntryTextBox = New System.Windows.Forms.TextBox()
        Me.ChestTextBox = New System.Windows.Forms.TextBox()
        Me.OtherPhysicalTextBox = New System.Windows.Forms.TextBox()
        Me.PhysNotesTextBox = New System.Windows.Forms.TextBox()
        Me.NotesTextBox = New System.Windows.Forms.TextBox()
        Me.AdviceTextBox = New System.Windows.Forms.TextBox()
        Me.InvstRestTextBox = New System.Windows.Forms.TextBox()
        Me.dgSymtom = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnaddGv = New System.Windows.Forms.Button()
        Me.cmbSymtomType = New System.Windows.Forms.ComboBox()
        Me.txtDur = New System.Windows.Forms.TextBox()
        Me.cmbSP = New System.Windows.Forms.ComboBox()
        Me.cmbSymtom = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnTestReq = New System.Windows.Forms.Button()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.btnIge = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnMediAdd = New System.Windows.Forms.Button()
        Me.SlNoTextBox = New System.Windows.Forms.TextBox()
        Me.DosageTextBox = New System.Windows.Forms.TextBox()
        Me.DTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.FreqIdComboBox = New System.Windows.Forms.ComboBox()
        Me.DurationTextBox = New System.Windows.Forms.TextBox()
        Me.DwmComboBox = New System.Windows.Forms.ComboBox()
        Me.AbmealTextBox = New System.Windows.Forms.TextBox()
        Me.MedDescTextBox = New System.Windows.Forms.TextBox()
        Me.MedIdComboBox = New System.Windows.Forms.ComboBox()
        Me.dgDrugs = New System.Windows.Forms.DataGridView()
        Me.txtpatientname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.VaxRationComboBox = New System.Windows.Forms.ComboBox()
        Me.VaxSLITTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnVacAdd = New System.Windows.Forms.Button()
        Me.cmbVaxValue = New System.Windows.Forms.ComboBox()
        Me.CmbAllerid = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lAllergen = New System.Windows.Forms.Label()
        Me.PhysicianIdCmb = New System.Windows.Forms.ComboBox()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.cmdPres = New System.Windows.Forms.Button()
        Me.cmdHistory = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.SeasIDCmb = New System.Windows.Forms.ComboBox()
        Me.ReftoCmb = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        PatientIdLabel = New System.Windows.Forms.Label()
        DateVisitLabel = New System.Windows.Forms.Label()
        PhysicianIdLabel = New System.Windows.Forms.Label()
        PtSexLabel = New System.Windows.Forms.Label()
        PtAgeLabel = New System.Windows.Forms.Label()
        PtHeightLabel = New System.Windows.Forms.Label()
        PtWeightLabel = New System.Windows.Forms.Label()
        DysSPLabel = New System.Windows.Forms.Label()
        SeasIDLabel = New System.Windows.Forms.Label()
        BPHisLabel = New System.Windows.Forms.Label()
        BPDHisLabel = New System.Windows.Forms.Label()
        BPPlsLabel = New System.Windows.Forms.Label()
        MucousMembraneLabel = New System.Windows.Forms.Label()
        NoseLabel = New System.Windows.Forms.Label()
        ThroatLabel = New System.Windows.Forms.Label()
        AirEntryLabel = New System.Windows.Forms.Label()
        ChestLabel = New System.Windows.Forms.Label()
        OtherPhysicalLabel = New System.Windows.Forms.Label()
        PhysNotesLabel = New System.Windows.Forms.Label()
        NotesLabel = New System.Windows.Forms.Label()
        AdviceLabel = New System.Windows.Forms.Label()
        InvstRestLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        MedIdLabel = New System.Windows.Forms.Label()
        SlNoLabel = New System.Windows.Forms.Label()
        DosageLabel = New System.Windows.Forms.Label()
        DTypeLabel = New System.Windows.Forms.Label()
        FreqIdLabel = New System.Windows.Forms.Label()
        DurationLabel = New System.Windows.Forms.Label()
        DwmLabel = New System.Windows.Forms.Label()
        AbmealLabel = New System.Windows.Forms.Label()
        MedDescLabel = New System.Windows.Forms.Label()
        VaxRationLabel = New System.Windows.Forms.Label()
        VaxVialLabel = New System.Windows.Forms.Label()
        CType(Me.dgSymtom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgDrugs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PatientIdLabel
        '
        PatientIdLabel.AutoSize = True
        PatientIdLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PatientIdLabel.Location = New System.Drawing.Point(168, 13)
        PatientIdLabel.Name = "PatientIdLabel"
        PatientIdLabel.Size = New System.Drawing.Size(75, 19)
        PatientIdLabel.TabIndex = 1
        PatientIdLabel.Text = "Patient Id:"
        '
        'DateVisitLabel
        '
        DateVisitLabel.AutoSize = True
        DateVisitLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateVisitLabel.Location = New System.Drawing.Point(622, 11)
        DateVisitLabel.Name = "DateVisitLabel"
        DateVisitLabel.Size = New System.Drawing.Size(77, 19)
        DateVisitLabel.TabIndex = 3
        DateVisitLabel.Text = "Date Visit:"
        '
        'PhysicianIdLabel
        '
        PhysicianIdLabel.AutoSize = True
        PhysicianIdLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PhysicianIdLabel.Location = New System.Drawing.Point(839, 12)
        PhysicianIdLabel.Name = "PhysicianIdLabel"
        PhysicianIdLabel.Size = New System.Drawing.Size(78, 19)
        PhysicianIdLabel.TabIndex = 5
        PhysicianIdLabel.Text = "Physician :"
        '
        'PtSexLabel
        '
        PtSexLabel.AutoSize = True
        PtSexLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PtSexLabel.Location = New System.Drawing.Point(173, 41)
        PtSexLabel.Name = "PtSexLabel"
        PtSexLabel.Size = New System.Drawing.Size(52, 19)
        PtSexLabel.TabIndex = 7
        PtSexLabel.Text = "Pt Sex:"
        '
        'PtAgeLabel
        '
        PtAgeLabel.AutoSize = True
        PtAgeLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PtAgeLabel.Location = New System.Drawing.Point(351, 41)
        PtAgeLabel.Name = "PtAgeLabel"
        PtAgeLabel.Size = New System.Drawing.Size(55, 19)
        PtAgeLabel.TabIndex = 9
        PtAgeLabel.Text = "Pt Age:"
        '
        'PtHeightLabel
        '
        PtHeightLabel.AutoSize = True
        PtHeightLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PtHeightLabel.Location = New System.Drawing.Point(559, 43)
        PtHeightLabel.Name = "PtHeightLabel"
        PtHeightLabel.Size = New System.Drawing.Size(73, 19)
        PtHeightLabel.TabIndex = 13
        PtHeightLabel.Text = "Pt Height:"
        '
        'PtWeightLabel
        '
        PtWeightLabel.AutoSize = True
        PtWeightLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PtWeightLabel.Location = New System.Drawing.Point(735, 45)
        PtWeightLabel.Name = "PtWeightLabel"
        PtWeightLabel.Size = New System.Drawing.Size(76, 19)
        PtWeightLabel.TabIndex = 15
        PtWeightLabel.Text = "Pt Weight:"
        '
        'DysSPLabel
        '
        DysSPLabel.AutoSize = True
        DysSPLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DysSPLabel.Location = New System.Drawing.Point(38, 363)
        DysSPLabel.Name = "DysSPLabel"
        DysSPLabel.Size = New System.Drawing.Size(104, 13)
        DysSPLabel.TabIndex = 109
        DysSPLabel.Text = "Blood Pressure : "
        '
        'SeasIDLabel
        '
        SeasIDLabel.AutoSize = True
        SeasIDLabel.Location = New System.Drawing.Point(316, 363)
        SeasIDLabel.Name = "SeasIDLabel"
        SeasIDLabel.Size = New System.Drawing.Size(82, 13)
        SeasIDLabel.TabIndex = 135
        SeasIDLabel.Text = "Problem Occurs"
        '
        'BPHisLabel
        '
        BPHisLabel.AutoSize = True
        BPHisLabel.Location = New System.Drawing.Point(45, 379)
        BPHisLabel.Name = "BPHisLabel"
        BPHisLabel.Size = New System.Drawing.Size(46, 13)
        BPHisLabel.TabIndex = 157
        BPHisLabel.Text = "Systolic:"
        '
        'BPDHisLabel
        '
        BPDHisLabel.AutoSize = True
        BPDHisLabel.Location = New System.Drawing.Point(176, 379)
        BPDHisLabel.Name = "BPDHisLabel"
        BPDHisLabel.Size = New System.Drawing.Size(56, 13)
        BPDHisLabel.TabIndex = 159
        BPDHisLabel.Text = "Diastolic : "
        '
        'BPPlsLabel
        '
        BPPlsLabel.AutoSize = True
        BPPlsLabel.Location = New System.Drawing.Point(320, 379)
        BPPlsLabel.Name = "BPPlsLabel"
        BPPlsLabel.Size = New System.Drawing.Size(36, 13)
        BPPlsLabel.TabIndex = 161
        BPPlsLabel.Text = "Pulse:"
        '
        'MucousMembraneLabel
        '
        MucousMembraneLabel.AutoSize = True
        MucousMembraneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MucousMembraneLabel.Location = New System.Drawing.Point(17, 415)
        MucousMembraneLabel.Name = "MucousMembraneLabel"
        MucousMembraneLabel.Size = New System.Drawing.Size(117, 13)
        MucousMembraneLabel.TabIndex = 163
        MucousMembraneLabel.Text = "Mucous Membrane:"
        '
        'NoseLabel
        '
        NoseLabel.AutoSize = True
        NoseLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NoseLabel.Location = New System.Drawing.Point(238, 415)
        NoseLabel.Name = "NoseLabel"
        NoseLabel.Size = New System.Drawing.Size(40, 13)
        NoseLabel.TabIndex = 165
        NoseLabel.Text = "Nose:"
        '
        'ThroatLabel
        '
        ThroatLabel.AutoSize = True
        ThroatLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ThroatLabel.Location = New System.Drawing.Point(18, 502)
        ThroatLabel.Name = "ThroatLabel"
        ThroatLabel.Size = New System.Drawing.Size(48, 13)
        ThroatLabel.TabIndex = 167
        ThroatLabel.Text = "Throat:"
        '
        'AirEntryLabel
        '
        AirEntryLabel.AutoSize = True
        AirEntryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AirEntryLabel.Location = New System.Drawing.Point(17, 596)
        AirEntryLabel.Name = "AirEntryLabel"
        AirEntryLabel.Size = New System.Drawing.Size(59, 13)
        AirEntryLabel.TabIndex = 169
        AirEntryLabel.Text = "Air Entry:"
        '
        'ChestLabel
        '
        ChestLabel.AutoSize = True
        ChestLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChestLabel.Location = New System.Drawing.Point(238, 502)
        ChestLabel.Name = "ChestLabel"
        ChestLabel.Size = New System.Drawing.Size(43, 13)
        ChestLabel.TabIndex = 171
        ChestLabel.Text = "Chest:"
        '
        'OtherPhysicalLabel
        '
        OtherPhysicalLabel.AutoSize = True
        OtherPhysicalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OtherPhysicalLabel.Location = New System.Drawing.Point(238, 596)
        OtherPhysicalLabel.Name = "OtherPhysicalLabel"
        OtherPhysicalLabel.Size = New System.Drawing.Size(93, 13)
        OtherPhysicalLabel.TabIndex = 173
        OtherPhysicalLabel.Text = "Other Physical:"
        '
        'PhysNotesLabel
        '
        PhysNotesLabel.AutoSize = True
        PhysNotesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PhysNotesLabel.Location = New System.Drawing.Point(613, 264)
        PhysNotesLabel.Name = "PhysNotesLabel"
        PhysNotesLabel.Size = New System.Drawing.Size(212, 13)
        PhysNotesLabel.TabIndex = 175
        PhysNotesLabel.Text = "Physician's Notes (Will Not be Print)"
        '
        'NotesLabel
        '
        NotesLabel.AutoSize = True
        NotesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NotesLabel.Location = New System.Drawing.Point(613, 66)
        NotesLabel.Name = "NotesLabel"
        NotesLabel.Size = New System.Drawing.Size(44, 13)
        NotesLabel.TabIndex = 177
        NotesLabel.Text = "Notes:"
        '
        'AdviceLabel
        '
        AdviceLabel.AutoSize = True
        AdviceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AdviceLabel.Location = New System.Drawing.Point(613, 159)
        AdviceLabel.Name = "AdviceLabel"
        AdviceLabel.Size = New System.Drawing.Size(50, 13)
        AdviceLabel.TabIndex = 179
        AdviceLabel.Text = "Advice:"
        '
        'InvstRestLabel
        '
        InvstRestLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        InvstRestLabel.Location = New System.Drawing.Point(12, 714)
        InvstRestLabel.Name = "InvstRestLabel"
        InvstRestLabel.Size = New System.Drawing.Size(100, 62)
        InvstRestLabel.TabIndex = 339
        InvstRestLabel.Text = "Findings /  Prov Diagnosis :"
        InvstRestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(71, 13)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(35, 13)
        Label1.TabIndex = 10
        Label1.Text = "Name"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(231, 16)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(47, 13)
        Label2.TabIndex = 11
        Label2.Text = "Duration"
        '
        'MedIdLabel
        '
        MedIdLabel.AutoSize = True
        MedIdLabel.Location = New System.Drawing.Point(63, 21)
        MedIdLabel.Name = "MedIdLabel"
        MedIdLabel.Size = New System.Drawing.Size(43, 13)
        MedIdLabel.TabIndex = 351
        MedIdLabel.Text = "Med Id:"
        '
        'SlNoLabel
        '
        SlNoLabel.AutoSize = True
        SlNoLabel.Location = New System.Drawing.Point(-1, 21)
        SlNoLabel.Name = "SlNoLabel"
        SlNoLabel.Size = New System.Drawing.Size(36, 13)
        SlNoLabel.TabIndex = 358
        SlNoLabel.Text = "Sl No:"
        '
        'DosageLabel
        '
        DosageLabel.AutoSize = True
        DosageLabel.Location = New System.Drawing.Point(169, 21)
        DosageLabel.Name = "DosageLabel"
        DosageLabel.Size = New System.Drawing.Size(47, 13)
        DosageLabel.TabIndex = 360
        DosageLabel.Text = "Dosage:"
        '
        'DTypeLabel
        '
        DTypeLabel.AutoSize = True
        DTypeLabel.Location = New System.Drawing.Point(222, 21)
        DTypeLabel.Name = "DTypeLabel"
        DTypeLabel.Size = New System.Drawing.Size(42, 13)
        DTypeLabel.TabIndex = 362
        DTypeLabel.Text = "DType:"
        '
        'FreqIdLabel
        '
        FreqIdLabel.AutoSize = True
        FreqIdLabel.Location = New System.Drawing.Point(324, 21)
        FreqIdLabel.Name = "FreqIdLabel"
        FreqIdLabel.Size = New System.Drawing.Size(43, 13)
        FreqIdLabel.TabIndex = 364
        FreqIdLabel.Text = "Freq Id:"
        '
        'DurationLabel
        '
        DurationLabel.AutoSize = True
        DurationLabel.Location = New System.Drawing.Point(385, 21)
        DurationLabel.Name = "DurationLabel"
        DurationLabel.Size = New System.Drawing.Size(50, 13)
        DurationLabel.TabIndex = 366
        DurationLabel.Text = "Duration:"
        '
        'DwmLabel
        '
        DwmLabel.AutoSize = True
        DwmLabel.Location = New System.Drawing.Point(441, 21)
        DwmLabel.Name = "DwmLabel"
        DwmLabel.Size = New System.Drawing.Size(32, 13)
        DwmLabel.TabIndex = 368
        DwmLabel.Text = "dwm:"
        '
        'AbmealLabel
        '
        AbmealLabel.AutoSize = True
        AbmealLabel.Location = New System.Drawing.Point(274, 21)
        AbmealLabel.Name = "AbmealLabel"
        AbmealLabel.Size = New System.Drawing.Size(44, 13)
        AbmealLabel.TabIndex = 370
        AbmealLabel.Text = "abmeal:"
        '
        'MedDescLabel
        '
        MedDescLabel.AutoSize = True
        MedDescLabel.Location = New System.Drawing.Point(500, 21)
        MedDescLabel.Name = "MedDescLabel"
        MedDescLabel.Size = New System.Drawing.Size(59, 13)
        MedDescLabel.TabIndex = 372
        MedDescLabel.Text = "Med Desc:"
        '
        'VaxRationLabel
        '
        VaxRationLabel.AutoSize = True
        VaxRationLabel.Location = New System.Drawing.Point(752, 611)
        VaxRationLabel.Name = "VaxRationLabel"
        VaxRationLabel.Size = New System.Drawing.Size(41, 13)
        VaxRationLabel.TabIndex = 354
        VaxRationLabel.Text = "Ration:"
        '
        'VaxVialLabel
        '
        VaxVialLabel.AutoSize = True
        VaxVialLabel.Location = New System.Drawing.Point(926, 611)
        VaxVialLabel.Name = "VaxVialLabel"
        VaxVialLabel.Size = New System.Drawing.Size(27, 13)
        VaxVialLabel.TabIndex = 355
        VaxVialLabel.Text = "Vial:"
        '
        'PatientIdTextBox
        '
        Me.PatientIdTextBox.Location = New System.Drawing.Point(255, 13)
        Me.PatientIdTextBox.Name = "PatientIdTextBox"
        Me.PatientIdTextBox.Size = New System.Drawing.Size(93, 20)
        Me.PatientIdTextBox.TabIndex = 2
        '
        'DateVisitDateTimePicker
        '
        Me.DateVisitDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateVisitDateTimePicker.Location = New System.Drawing.Point(705, 13)
        Me.DateVisitDateTimePicker.Name = "DateVisitDateTimePicker"
        Me.DateVisitDateTimePicker.Size = New System.Drawing.Size(122, 20)
        Me.DateVisitDateTimePicker.TabIndex = 4
        '
        'PtSexTextBox
        '
        Me.PtSexTextBox.Location = New System.Drawing.Point(255, 41)
        Me.PtSexTextBox.Name = "PtSexTextBox"
        Me.PtSexTextBox.Size = New System.Drawing.Size(78, 20)
        Me.PtSexTextBox.TabIndex = 8
        '
        'PtAgeTextBox
        '
        Me.PtAgeTextBox.Location = New System.Drawing.Point(412, 41)
        Me.PtAgeTextBox.Name = "PtAgeTextBox"
        Me.PtAgeTextBox.Size = New System.Drawing.Size(68, 20)
        Me.PtAgeTextBox.TabIndex = 10
        '
        'PtAgeMonTextBox
        '
        Me.PtAgeMonTextBox.Location = New System.Drawing.Point(497, 42)
        Me.PtAgeMonTextBox.Name = "PtAgeMonTextBox"
        Me.PtAgeMonTextBox.Size = New System.Drawing.Size(56, 20)
        Me.PtAgeMonTextBox.TabIndex = 12
        '
        'PtHeightTextBox
        '
        Me.PtHeightTextBox.Location = New System.Drawing.Point(639, 44)
        Me.PtHeightTextBox.Name = "PtHeightTextBox"
        Me.PtHeightTextBox.Size = New System.Drawing.Size(78, 20)
        Me.PtHeightTextBox.TabIndex = 14
        '
        'PtWeightTextBox
        '
        Me.PtWeightTextBox.Location = New System.Drawing.Point(817, 44)
        Me.PtWeightTextBox.Name = "PtWeightTextBox"
        Me.PtWeightTextBox.Size = New System.Drawing.Size(78, 20)
        Me.PtWeightTextBox.TabIndex = 16
        '
        'VisitDoneCheckBox
        '
        Me.VisitDoneCheckBox.Location = New System.Drawing.Point(1152, 11)
        Me.VisitDoneCheckBox.Name = "VisitDoneCheckBox"
        Me.VisitDoneCheckBox.Size = New System.Drawing.Size(84, 24)
        Me.VisitDoneCheckBox.TabIndex = 18
        Me.VisitDoneCheckBox.Text = "Completed"
        Me.VisitDoneCheckBox.UseVisualStyleBackColor = True
        '
        'OcrDayCheckBox
        '
        Me.OcrDayCheckBox.Location = New System.Drawing.Point(13, 11)
        Me.OcrDayCheckBox.Name = "OcrDayCheckBox"
        Me.OcrDayCheckBox.Size = New System.Drawing.Size(101, 24)
        Me.OcrDayCheckBox.TabIndex = 138
        Me.OcrDayCheckBox.Text = "Day"
        Me.OcrDayCheckBox.UseVisualStyleBackColor = True
        '
        'OcrNightCheckBox
        '
        Me.OcrNightCheckBox.Location = New System.Drawing.Point(13, 35)
        Me.OcrNightCheckBox.Name = "OcrNightCheckBox"
        Me.OcrNightCheckBox.Size = New System.Drawing.Size(101, 24)
        Me.OcrNightCheckBox.TabIndex = 140
        Me.OcrNightCheckBox.Text = "Night"
        Me.OcrNightCheckBox.UseVisualStyleBackColor = True
        '
        'OcrAnyCheckBox
        '
        Me.OcrAnyCheckBox.Location = New System.Drawing.Point(13, 59)
        Me.OcrAnyCheckBox.Name = "OcrAnyCheckBox"
        Me.OcrAnyCheckBox.Size = New System.Drawing.Size(101, 24)
        Me.OcrAnyCheckBox.TabIndex = 142
        Me.OcrAnyCheckBox.Text = "AnyTime"
        Me.OcrAnyCheckBox.UseVisualStyleBackColor = True
        '
        'OcrEMCheckBox
        '
        Me.OcrEMCheckBox.Location = New System.Drawing.Point(13, 83)
        Me.OcrEMCheckBox.Name = "OcrEMCheckBox"
        Me.OcrEMCheckBox.Size = New System.Drawing.Size(101, 24)
        Me.OcrEMCheckBox.TabIndex = 144
        Me.OcrEMCheckBox.Text = "Early Morning"
        Me.OcrEMCheckBox.UseVisualStyleBackColor = True
        '
        'OcrEveCheckBox
        '
        Me.OcrEveCheckBox.Location = New System.Drawing.Point(13, 107)
        Me.OcrEveCheckBox.Name = "OcrEveCheckBox"
        Me.OcrEveCheckBox.Size = New System.Drawing.Size(101, 24)
        Me.OcrEveCheckBox.TabIndex = 146
        Me.OcrEveCheckBox.Text = "Evening"
        Me.OcrEveCheckBox.UseVisualStyleBackColor = True
        '
        'ErythemaCheckBox
        '
        Me.ErythemaCheckBox.Location = New System.Drawing.Point(10, 7)
        Me.ErythemaCheckBox.Name = "ErythemaCheckBox"
        Me.ErythemaCheckBox.Size = New System.Drawing.Size(101, 24)
        Me.ErythemaCheckBox.TabIndex = 148
        Me.ErythemaCheckBox.Text = "Erythema"
        Me.ErythemaCheckBox.UseVisualStyleBackColor = True
        '
        'DermatographismCheckBox
        '
        Me.DermatographismCheckBox.Location = New System.Drawing.Point(10, 31)
        Me.DermatographismCheckBox.Name = "DermatographismCheckBox"
        Me.DermatographismCheckBox.Size = New System.Drawing.Size(101, 24)
        Me.DermatographismCheckBox.TabIndex = 150
        Me.DermatographismCheckBox.Text = "Dermatographism"
        Me.DermatographismCheckBox.UseVisualStyleBackColor = True
        '
        'PallorCheckBox
        '
        Me.PallorCheckBox.Location = New System.Drawing.Point(10, 55)
        Me.PallorCheckBox.Name = "PallorCheckBox"
        Me.PallorCheckBox.Size = New System.Drawing.Size(101, 24)
        Me.PallorCheckBox.TabIndex = 152
        Me.PallorCheckBox.Text = "Pallor"
        Me.PallorCheckBox.UseVisualStyleBackColor = True
        '
        'OedemaCheckBox
        '
        Me.OedemaCheckBox.Location = New System.Drawing.Point(10, 79)
        Me.OedemaCheckBox.Name = "OedemaCheckBox"
        Me.OedemaCheckBox.Size = New System.Drawing.Size(101, 24)
        Me.OedemaCheckBox.TabIndex = 154
        Me.OedemaCheckBox.Text = "Oedema"
        Me.OedemaCheckBox.UseVisualStyleBackColor = True
        '
        'ClubbingCheckBox
        '
        Me.ClubbingCheckBox.Location = New System.Drawing.Point(10, 103)
        Me.ClubbingCheckBox.Name = "ClubbingCheckBox"
        Me.ClubbingCheckBox.Size = New System.Drawing.Size(101, 24)
        Me.ClubbingCheckBox.TabIndex = 156
        Me.ClubbingCheckBox.Text = "Clubbing"
        Me.ClubbingCheckBox.UseVisualStyleBackColor = True
        '
        'BPHisTextBox
        '
        Me.BPHisTextBox.Location = New System.Drawing.Point(109, 379)
        Me.BPHisTextBox.Name = "BPHisTextBox"
        Me.BPHisTextBox.Size = New System.Drawing.Size(42, 20)
        Me.BPHisTextBox.TabIndex = 158
        '
        'BPDHisTextBox
        '
        Me.BPDHisTextBox.Location = New System.Drawing.Point(238, 379)
        Me.BPDHisTextBox.Name = "BPDHisTextBox"
        Me.BPDHisTextBox.Size = New System.Drawing.Size(42, 20)
        Me.BPDHisTextBox.TabIndex = 160
        '
        'BPPlsTextBox
        '
        Me.BPPlsTextBox.Location = New System.Drawing.Point(355, 379)
        Me.BPPlsTextBox.Name = "BPPlsTextBox"
        Me.BPPlsTextBox.Size = New System.Drawing.Size(42, 20)
        Me.BPPlsTextBox.TabIndex = 162
        '
        'MucousMembraneTextBox
        '
        Me.MucousMembraneTextBox.Location = New System.Drawing.Point(17, 431)
        Me.MucousMembraneTextBox.Multiline = True
        Me.MucousMembraneTextBox.Name = "MucousMembraneTextBox"
        Me.MucousMembraneTextBox.Size = New System.Drawing.Size(193, 69)
        Me.MucousMembraneTextBox.TabIndex = 164
        '
        'NoseTextBox
        '
        Me.NoseTextBox.Location = New System.Drawing.Point(238, 431)
        Me.NoseTextBox.Multiline = True
        Me.NoseTextBox.Name = "NoseTextBox"
        Me.NoseTextBox.Size = New System.Drawing.Size(193, 69)
        Me.NoseTextBox.TabIndex = 166
        '
        'ThroatTextBox
        '
        Me.ThroatTextBox.Location = New System.Drawing.Point(17, 518)
        Me.ThroatTextBox.Multiline = True
        Me.ThroatTextBox.Name = "ThroatTextBox"
        Me.ThroatTextBox.Size = New System.Drawing.Size(193, 69)
        Me.ThroatTextBox.TabIndex = 168
        '
        'AirEntryTextBox
        '
        Me.AirEntryTextBox.Location = New System.Drawing.Point(17, 613)
        Me.AirEntryTextBox.Multiline = True
        Me.AirEntryTextBox.Name = "AirEntryTextBox"
        Me.AirEntryTextBox.Size = New System.Drawing.Size(193, 69)
        Me.AirEntryTextBox.TabIndex = 170
        '
        'ChestTextBox
        '
        Me.ChestTextBox.Location = New System.Drawing.Point(238, 518)
        Me.ChestTextBox.Multiline = True
        Me.ChestTextBox.Name = "ChestTextBox"
        Me.ChestTextBox.Size = New System.Drawing.Size(193, 69)
        Me.ChestTextBox.TabIndex = 172
        '
        'OtherPhysicalTextBox
        '
        Me.OtherPhysicalTextBox.Location = New System.Drawing.Point(238, 613)
        Me.OtherPhysicalTextBox.Multiline = True
        Me.OtherPhysicalTextBox.Name = "OtherPhysicalTextBox"
        Me.OtherPhysicalTextBox.Size = New System.Drawing.Size(193, 69)
        Me.OtherPhysicalTextBox.TabIndex = 174
        '
        'PhysNotesTextBox
        '
        Me.PhysNotesTextBox.Location = New System.Drawing.Point(613, 280)
        Me.PhysNotesTextBox.Multiline = True
        Me.PhysNotesTextBox.Name = "PhysNotesTextBox"
        Me.PhysNotesTextBox.Size = New System.Drawing.Size(319, 74)
        Me.PhysNotesTextBox.TabIndex = 176
        '
        'NotesTextBox
        '
        Me.NotesTextBox.Location = New System.Drawing.Point(613, 82)
        Me.NotesTextBox.Multiline = True
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.Size = New System.Drawing.Size(319, 74)
        Me.NotesTextBox.TabIndex = 178
        '
        'AdviceTextBox
        '
        Me.AdviceTextBox.Location = New System.Drawing.Point(613, 175)
        Me.AdviceTextBox.Multiline = True
        Me.AdviceTextBox.Name = "AdviceTextBox"
        Me.AdviceTextBox.Size = New System.Drawing.Size(319, 74)
        Me.AdviceTextBox.TabIndex = 180
        '
        'InvstRestTextBox
        '
        Me.InvstRestTextBox.Location = New System.Drawing.Point(118, 710)
        Me.InvstRestTextBox.Multiline = True
        Me.InvstRestTextBox.Name = "InvstRestTextBox"
        Me.InvstRestTextBox.Size = New System.Drawing.Size(313, 66)
        Me.InvstRestTextBox.TabIndex = 340
        '
        'dgSymtom
        '
        Me.dgSymtom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSymtom.Location = New System.Drawing.Point(35, 138)
        Me.dgSymtom.Name = "dgSymtom"
        Me.dgSymtom.Size = New System.Drawing.Size(549, 215)
        Me.dgSymtom.TabIndex = 341
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnaddGv)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.cmbSymtomType)
        Me.GroupBox1.Controls.Add(Me.txtDur)
        Me.GroupBox1.Controls.Add(Me.cmbSP)
        Me.GroupBox1.Controls.Add(Me.cmbSymtom)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(549, 63)
        Me.GroupBox1.TabIndex = 342
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Symtoms"
        '
        'btnaddGv
        '
        Me.btnaddGv.Location = New System.Drawing.Point(491, 30)
        Me.btnaddGv.Name = "btnaddGv"
        Me.btnaddGv.Size = New System.Drawing.Size(56, 23)
        Me.btnaddGv.TabIndex = 12
        Me.btnaddGv.Text = "Add"
        Me.btnaddGv.UseVisualStyleBackColor = True
        '
        'cmbSymtomType
        '
        Me.cmbSymtomType.FormattingEnabled = True
        Me.cmbSymtomType.Location = New System.Drawing.Point(133, 28)
        Me.cmbSymtomType.Name = "cmbSymtomType"
        Me.cmbSymtomType.Size = New System.Drawing.Size(87, 21)
        Me.cmbSymtomType.TabIndex = 4
        '
        'txtDur
        '
        Me.txtDur.Location = New System.Drawing.Point(226, 29)
        Me.txtDur.Name = "txtDur"
        Me.txtDur.Size = New System.Drawing.Size(157, 20)
        Me.txtDur.TabIndex = 3
        '
        'cmbSP
        '
        Me.cmbSP.FormattingEnabled = True
        Me.cmbSP.Items.AddRange(New Object() {"Seasonal", "Perennial"})
        Me.cmbSP.Location = New System.Drawing.Point(389, 30)
        Me.cmbSP.Name = "cmbSP"
        Me.cmbSP.Size = New System.Drawing.Size(93, 21)
        Me.cmbSP.TabIndex = 1
        '
        'cmbSymtom
        '
        Me.cmbSymtom.FormattingEnabled = True
        Me.cmbSymtom.Location = New System.Drawing.Point(6, 28)
        Me.cmbSymtom.Name = "cmbSymtom"
        Me.cmbSymtom.Size = New System.Drawing.Size(121, 21)
        Me.cmbSymtom.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.OcrAnyCheckBox)
        Me.GroupBox2.Controls.Add(Me.OcrEveCheckBox)
        Me.GroupBox2.Controls.Add(Me.OcrEMCheckBox)
        Me.GroupBox2.Controls.Add(Me.OcrNightCheckBox)
        Me.GroupBox2.Controls.Add(Me.OcrDayCheckBox)
        Me.GroupBox2.Location = New System.Drawing.Point(461, 381)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox2.Size = New System.Drawing.Size(130, 136)
        Me.GroupBox2.TabIndex = 343
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DermatographismCheckBox)
        Me.GroupBox3.Controls.Add(Me.ClubbingCheckBox)
        Me.GroupBox3.Controls.Add(Me.OedemaCheckBox)
        Me.GroupBox3.Controls.Add(Me.PallorCheckBox)
        Me.GroupBox3.Controls.Add(Me.ErythemaCheckBox)
        Me.GroupBox3.Location = New System.Drawing.Point(461, 521)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(130, 136)
        Me.GroupBox3.TabIndex = 344
        Me.GroupBox3.TabStop = False
        '
        'btnTestReq
        '
        Me.btnTestReq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTestReq.Location = New System.Drawing.Point(461, 704)
        Me.btnTestReq.Name = "btnTestReq"
        Me.btnTestReq.Size = New System.Drawing.Size(130, 33)
        Me.btnTestReq.TabIndex = 345
        Me.btnTestReq.Text = "Test Requisition"
        Me.btnTestReq.UseVisualStyleBackColor = True
        '
        'btnTest
        '
        Me.btnTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTest.Location = New System.Drawing.Point(447, 743)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(52, 29)
        Me.btnTest.TabIndex = 346
        Me.btnTest.Text = "Test "
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'btnProfile
        '
        Me.btnProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfile.Location = New System.Drawing.Point(499, 743)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(58, 29)
        Me.btnProfile.TabIndex = 347
        Me.btnProfile.Text = "Profile"
        Me.btnProfile.UseVisualStyleBackColor = True
        '
        'btnIge
        '
        Me.btnIge.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIge.Location = New System.Drawing.Point(553, 743)
        Me.btnIge.Name = "btnIge"
        Me.btnIge.Size = New System.Drawing.Size(49, 29)
        Me.btnIge.TabIndex = 348
        Me.btnIge.Text = "IgE"
        Me.btnIge.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnMediAdd)
        Me.GroupBox4.Controls.Add(SlNoLabel)
        Me.GroupBox4.Controls.Add(Me.SlNoTextBox)
        Me.GroupBox4.Controls.Add(DosageLabel)
        Me.GroupBox4.Controls.Add(Me.DosageTextBox)
        Me.GroupBox4.Controls.Add(DTypeLabel)
        Me.GroupBox4.Controls.Add(Me.DTypeComboBox)
        Me.GroupBox4.Controls.Add(FreqIdLabel)
        Me.GroupBox4.Controls.Add(Me.FreqIdComboBox)
        Me.GroupBox4.Controls.Add(DurationLabel)
        Me.GroupBox4.Controls.Add(Me.DurationTextBox)
        Me.GroupBox4.Controls.Add(DwmLabel)
        Me.GroupBox4.Controls.Add(Me.DwmComboBox)
        Me.GroupBox4.Controls.Add(AbmealLabel)
        Me.GroupBox4.Controls.Add(Me.AbmealTextBox)
        Me.GroupBox4.Controls.Add(MedDescLabel)
        Me.GroupBox4.Controls.Add(Me.MedDescTextBox)
        Me.GroupBox4.Controls.Add(MedIdLabel)
        Me.GroupBox4.Controls.Add(Me.MedIdComboBox)
        Me.GroupBox4.Location = New System.Drawing.Point(611, 360)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(643, 68)
        Me.GroupBox4.TabIndex = 349
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Medicines prescribed"
        '
        'btnMediAdd
        '
        Me.btnMediAdd.Location = New System.Drawing.Point(592, 32)
        Me.btnMediAdd.Name = "btnMediAdd"
        Me.btnMediAdd.Size = New System.Drawing.Size(51, 23)
        Me.btnMediAdd.TabIndex = 374
        Me.btnMediAdd.Text = "Add"
        Me.btnMediAdd.UseVisualStyleBackColor = True
        '
        'SlNoTextBox
        '
        Me.SlNoTextBox.Location = New System.Drawing.Point(-1, 37)
        Me.SlNoTextBox.Name = "SlNoTextBox"
        Me.SlNoTextBox.Size = New System.Drawing.Size(36, 20)
        Me.SlNoTextBox.TabIndex = 359
        '
        'DosageTextBox
        '
        Me.DosageTextBox.Location = New System.Drawing.Point(172, 37)
        Me.DosageTextBox.Name = "DosageTextBox"
        Me.DosageTextBox.Size = New System.Drawing.Size(28, 20)
        Me.DosageTextBox.TabIndex = 361
        '
        'DTypeComboBox
        '
        Me.DTypeComboBox.FormattingEnabled = True
        Me.DTypeComboBox.Location = New System.Drawing.Point(203, 36)
        Me.DTypeComboBox.Name = "DTypeComboBox"
        Me.DTypeComboBox.Size = New System.Drawing.Size(61, 21)
        Me.DTypeComboBox.TabIndex = 363
        '
        'FreqIdComboBox
        '
        Me.FreqIdComboBox.FormattingEnabled = True
        Me.FreqIdComboBox.Location = New System.Drawing.Point(306, 35)
        Me.FreqIdComboBox.Name = "FreqIdComboBox"
        Me.FreqIdComboBox.Size = New System.Drawing.Size(61, 21)
        Me.FreqIdComboBox.TabIndex = 365
        '
        'DurationTextBox
        '
        Me.DurationTextBox.Location = New System.Drawing.Point(373, 35)
        Me.DurationTextBox.Name = "DurationTextBox"
        Me.DurationTextBox.Size = New System.Drawing.Size(33, 20)
        Me.DurationTextBox.TabIndex = 367
        '
        'DwmComboBox
        '
        Me.DwmComboBox.FormattingEnabled = True
        Me.DwmComboBox.Items.AddRange(New Object() {"day", "week", "month"})
        Me.DwmComboBox.Location = New System.Drawing.Point(412, 35)
        Me.DwmComboBox.Name = "DwmComboBox"
        Me.DwmComboBox.Size = New System.Drawing.Size(61, 21)
        Me.DwmComboBox.TabIndex = 369
        '
        'AbmealTextBox
        '
        Me.AbmealTextBox.Location = New System.Drawing.Point(270, 36)
        Me.AbmealTextBox.Name = "AbmealTextBox"
        Me.AbmealTextBox.Size = New System.Drawing.Size(35, 20)
        Me.AbmealTextBox.TabIndex = 371
        '
        'MedDescTextBox
        '
        Me.MedDescTextBox.Location = New System.Drawing.Point(479, 35)
        Me.MedDescTextBox.Name = "MedDescTextBox"
        Me.MedDescTextBox.Size = New System.Drawing.Size(94, 20)
        Me.MedDescTextBox.TabIndex = 373
        '
        'MedIdComboBox
        '
        Me.MedIdComboBox.FormattingEnabled = True
        Me.MedIdComboBox.Location = New System.Drawing.Point(41, 36)
        Me.MedIdComboBox.Name = "MedIdComboBox"
        Me.MedIdComboBox.Size = New System.Drawing.Size(121, 21)
        Me.MedIdComboBox.TabIndex = 352
        '
        'dgDrugs
        '
        Me.dgDrugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDrugs.Location = New System.Drawing.Point(610, 439)
        Me.dgDrugs.Name = "dgDrugs"
        Me.dgDrugs.Size = New System.Drawing.Size(559, 154)
        Me.dgDrugs.TabIndex = 351
        '
        'txtpatientname
        '
        Me.txtpatientname.Location = New System.Drawing.Point(408, 12)
        Me.txtpatientname.Name = "txtpatientname"
        Me.txtpatientname.Size = New System.Drawing.Size(199, 20)
        Me.txtpatientname.TabIndex = 353
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(359, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 19)
        Me.Label3.TabIndex = 352
        Me.Label3.Text = "Name"
        '
        'VaxRationComboBox
        '
        Me.VaxRationComboBox.FormattingEnabled = True
        Me.VaxRationComboBox.Items.AddRange(New Object() {"1:10000", "1:5000", "1:1000", "1:500", "1:100", "1:10"})
        Me.VaxRationComboBox.Location = New System.Drawing.Point(799, 611)
        Me.VaxRationComboBox.Name = "VaxRationComboBox"
        Me.VaxRationComboBox.Size = New System.Drawing.Size(121, 21)
        Me.VaxRationComboBox.TabIndex = 355
        '
        'VaxSLITTextBox
        '
        Me.VaxSLITTextBox.Location = New System.Drawing.Point(1011, 612)
        Me.VaxSLITTextBox.Name = "VaxSLITTextBox"
        Me.VaxSLITTextBox.Size = New System.Drawing.Size(100, 20)
        Me.VaxSLITTextBox.TabIndex = 357
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(611, 668)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(414, 104)
        Me.DataGridView1.TabIndex = 358
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(625, 611)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 359
        Me.Label4.Tag = ""
        Me.Label4.Text = "IMMUNOTHERAPY "
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
        Me.ComboBox1.Location = New System.Drawing.Point(960, 611)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(45, 21)
        Me.ComboBox1.TabIndex = 360
        '
        'btnVacAdd
        '
        Me.btnVacAdd.Location = New System.Drawing.Point(1011, 645)
        Me.btnVacAdd.Name = "btnVacAdd"
        Me.btnVacAdd.Size = New System.Drawing.Size(56, 23)
        Me.btnVacAdd.TabIndex = 375
        Me.btnVacAdd.Text = "Add"
        Me.btnVacAdd.UseVisualStyleBackColor = True
        '
        'cmbVaxValue
        '
        Me.cmbVaxValue.FormattingEnabled = True
        Me.cmbVaxValue.Items.AddRange(New Object() {"10%", "20%", "30%", "40%", "50%", "60%", "70%", "80%", "90%", "100%"})
        Me.cmbVaxValue.Location = New System.Drawing.Point(860, 641)
        Me.cmbVaxValue.Name = "cmbVaxValue"
        Me.cmbVaxValue.Size = New System.Drawing.Size(121, 21)
        Me.cmbVaxValue.TabIndex = 376
        '
        'CmbAllerid
        '
        Me.CmbAllerid.FormattingEnabled = True
        Me.CmbAllerid.Location = New System.Drawing.Point(680, 641)
        Me.CmbAllerid.Name = "CmbAllerid"
        Me.CmbAllerid.Size = New System.Drawing.Size(121, 21)
        Me.CmbAllerid.TabIndex = 377
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(814, 641)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 378
        Me.Label5.Text = "VAX"
        '
        'lAllergen
        '
        Me.lAllergen.AutoSize = True
        Me.lAllergen.Location = New System.Drawing.Point(635, 641)
        Me.lAllergen.Name = "lAllergen"
        Me.lAllergen.Size = New System.Drawing.Size(45, 13)
        Me.lAllergen.TabIndex = 379
        Me.lAllergen.Text = "Allergen"
        '
        'PhysicianIdCmb
        '
        Me.PhysicianIdCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PhysicianIdCmb.FormattingEnabled = True
        Me.PhysicianIdCmb.Location = New System.Drawing.Point(952, 14)
        Me.PhysicianIdCmb.Name = "PhysicianIdCmb"
        Me.PhysicianIdCmb.Size = New System.Drawing.Size(178, 21)
        Me.PhysicianIdCmb.TabIndex = 380
        '
        'cmdNew
        '
        Me.cmdNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Location = New System.Drawing.Point(839, 778)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(49, 29)
        Me.cmdNew.TabIndex = 383
        Me.cmdNew.Text = "New"
        Me.cmdNew.UseVisualStyleBackColor = True
        '
        'cmdPres
        '
        Me.cmdPres.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPres.Location = New System.Drawing.Point(709, 778)
        Me.cmdPres.Name = "cmdPres"
        Me.cmdPres.Size = New System.Drawing.Size(116, 29)
        Me.cmdPres.TabIndex = 382
        Me.cmdPres.Text = "&Prescription"
        Me.cmdPres.UseVisualStyleBackColor = True
        '
        'cmdHistory
        '
        Me.cmdHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHistory.Location = New System.Drawing.Point(611, 778)
        Me.cmdHistory.Name = "cmdHistory"
        Me.cmdHistory.Size = New System.Drawing.Size(84, 29)
        Me.cmdHistory.TabIndex = 381
        Me.cmdHistory.Text = "History"
        Me.cmdHistory.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(974, 778)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(49, 29)
        Me.cmdClose.TabIndex = 385
        Me.cmdClose.Text = "Exit"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Location = New System.Drawing.Point(902, 778)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(58, 29)
        Me.cmdEdit.TabIndex = 384
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'SeasIDCmb
        '
        Me.SeasIDCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SeasIDCmb.FormattingEnabled = True
        Me.SeasIDCmb.Location = New System.Drawing.Point(423, 359)
        Me.SeasIDCmb.Name = "SeasIDCmb"
        Me.SeasIDCmb.Size = New System.Drawing.Size(152, 21)
        Me.SeasIDCmb.TabIndex = 386
        '
        'ReftoCmb
        '
        Me.ReftoCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ReftoCmb.FormattingEnabled = True
        Me.ReftoCmb.Location = New System.Drawing.Point(1058, 40)
        Me.ReftoCmb.Name = "ReftoCmb"
        Me.ReftoCmb.Size = New System.Drawing.Size(178, 21)
        Me.ReftoCmb.TabIndex = 387
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(905, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 19)
        Me.Label6.TabIndex = 388
        Me.Label6.Text = "Refed To / Pass On :"
        '
        'frmPtData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1282, 632)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ReftoCmb)
        Me.Controls.Add(Me.SeasIDCmb)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.cmdPres)
        Me.Controls.Add(Me.cmdHistory)
        Me.Controls.Add(Me.PhysicianIdCmb)
        Me.Controls.Add(Me.lAllergen)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CmbAllerid)
        Me.Controls.Add(Me.cmbVaxValue)
        Me.Controls.Add(Me.btnVacAdd)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.VaxSLITTextBox)
        Me.Controls.Add(VaxVialLabel)
        Me.Controls.Add(VaxRationLabel)
        Me.Controls.Add(Me.VaxRationComboBox)
        Me.Controls.Add(Me.txtpatientname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgDrugs)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnIge)
        Me.Controls.Add(Me.btnProfile)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.btnTestReq)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgSymtom)
        Me.Controls.Add(InvstRestLabel)
        Me.Controls.Add(Me.InvstRestTextBox)
        Me.Controls.Add(PatientIdLabel)
        Me.Controls.Add(Me.PatientIdTextBox)
        Me.Controls.Add(DateVisitLabel)
        Me.Controls.Add(Me.DateVisitDateTimePicker)
        Me.Controls.Add(PhysicianIdLabel)
        Me.Controls.Add(PtSexLabel)
        Me.Controls.Add(Me.PtSexTextBox)
        Me.Controls.Add(PtAgeLabel)
        Me.Controls.Add(Me.PtAgeTextBox)
        Me.Controls.Add(Me.PtAgeMonTextBox)
        Me.Controls.Add(PtHeightLabel)
        Me.Controls.Add(Me.PtHeightTextBox)
        Me.Controls.Add(PtWeightLabel)
        Me.Controls.Add(Me.PtWeightTextBox)
        Me.Controls.Add(Me.VisitDoneCheckBox)
        Me.Controls.Add(DysSPLabel)
        Me.Controls.Add(SeasIDLabel)
        Me.Controls.Add(BPHisLabel)
        Me.Controls.Add(Me.BPHisTextBox)
        Me.Controls.Add(BPDHisLabel)
        Me.Controls.Add(Me.BPDHisTextBox)
        Me.Controls.Add(BPPlsLabel)
        Me.Controls.Add(Me.BPPlsTextBox)
        Me.Controls.Add(MucousMembraneLabel)
        Me.Controls.Add(Me.MucousMembraneTextBox)
        Me.Controls.Add(NoseLabel)
        Me.Controls.Add(Me.NoseTextBox)
        Me.Controls.Add(ThroatLabel)
        Me.Controls.Add(Me.ThroatTextBox)
        Me.Controls.Add(AirEntryLabel)
        Me.Controls.Add(Me.AirEntryTextBox)
        Me.Controls.Add(ChestLabel)
        Me.Controls.Add(Me.ChestTextBox)
        Me.Controls.Add(OtherPhysicalLabel)
        Me.Controls.Add(Me.OtherPhysicalTextBox)
        Me.Controls.Add(PhysNotesLabel)
        Me.Controls.Add(Me.PhysNotesTextBox)
        Me.Controls.Add(NotesLabel)
        Me.Controls.Add(Me.NotesTextBox)
        Me.Controls.Add(AdviceLabel)
        Me.Controls.Add(Me.AdviceTextBox)
        Me.Name = "frmPtData"
        Me.Text = "Patient Data"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgSymtom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgDrugs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PatientIdTextBox As TextBox
    Friend WithEvents DateVisitDateTimePicker As DateTimePicker
    Friend WithEvents PtSexTextBox As TextBox
    Friend WithEvents PtAgeTextBox As TextBox
    Friend WithEvents PtAgeMonTextBox As TextBox
    Friend WithEvents PtHeightTextBox As TextBox
    Friend WithEvents PtWeightTextBox As TextBox
    Friend WithEvents VisitDoneCheckBox As CheckBox
    Friend WithEvents OcrDayCheckBox As CheckBox
    Friend WithEvents OcrNightCheckBox As CheckBox
    Friend WithEvents OcrAnyCheckBox As CheckBox
    Friend WithEvents OcrEMCheckBox As CheckBox
    Friend WithEvents OcrEveCheckBox As CheckBox
    Friend WithEvents ErythemaCheckBox As CheckBox
    Friend WithEvents DermatographismCheckBox As CheckBox
    Friend WithEvents PallorCheckBox As CheckBox
    Friend WithEvents OedemaCheckBox As CheckBox
    Friend WithEvents ClubbingCheckBox As CheckBox
    Friend WithEvents BPHisTextBox As TextBox
    Friend WithEvents BPDHisTextBox As TextBox
    Friend WithEvents BPPlsTextBox As TextBox
    Friend WithEvents MucousMembraneTextBox As TextBox
    Friend WithEvents NoseTextBox As TextBox
    Friend WithEvents ThroatTextBox As TextBox
    Friend WithEvents AirEntryTextBox As TextBox
    Friend WithEvents ChestTextBox As TextBox
    Friend WithEvents OtherPhysicalTextBox As TextBox
    Friend WithEvents PhysNotesTextBox As TextBox
    Friend WithEvents NotesTextBox As TextBox
    Friend WithEvents AdviceTextBox As TextBox
    Friend WithEvents InvstRestTextBox As TextBox
    Friend WithEvents dgSymtom As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbSymtomType As ComboBox
    Friend WithEvents txtDur As TextBox
    Friend WithEvents cmbSP As ComboBox
    Friend WithEvents cmbSymtom As ComboBox
    Friend WithEvents btnaddGv As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnTestReq As Button
    Friend WithEvents btnTest As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents btnIge As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents SlNoTextBox As TextBox
    Friend WithEvents DosageTextBox As TextBox
    Friend WithEvents DTypeComboBox As ComboBox
    Friend WithEvents FreqIdComboBox As ComboBox
    Friend WithEvents DurationTextBox As TextBox
    Friend WithEvents DwmComboBox As ComboBox
    Friend WithEvents AbmealTextBox As TextBox
    Friend WithEvents MedDescTextBox As TextBox
    Friend WithEvents MedIdComboBox As ComboBox
    Friend WithEvents dgDrugs As DataGridView
    Friend WithEvents txtpatientname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnMediAdd As Button
    Friend WithEvents VaxRationComboBox As ComboBox
    Friend WithEvents VaxSLITTextBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnVacAdd As Button
    Friend WithEvents cmbVaxValue As ComboBox
    Friend WithEvents CmbAllerid As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lAllergen As Label
    Friend WithEvents PhysicianIdCmb As ComboBox
    Friend WithEvents cmdNew As Button
    Friend WithEvents cmdPres As Button
    Friend WithEvents cmdHistory As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents cmdEdit As Button
    Friend WithEvents SeasIDCmb As ComboBox
    Friend WithEvents ReftoCmb As ComboBox
    Friend WithEvents Label6 As Label
End Class
