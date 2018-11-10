<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CekData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CekData))
        Me.Sekolah = New Yayasan_Deni_Mulia.Sekolah()
        Me.SekolahBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SekolahTableAdapter = New Yayasan_Deni_Mulia.SekolahTableAdapters.SekolahTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TransferDataSet = New Yayasan_Deni_Mulia.TransferDataSet()
        Me.TransferBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransferTableAdapter = New Yayasan_Deni_Mulia.TransferDataSetTableAdapters.TransferTableAdapter()
        Me.NISDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TRFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.GambarDataSet = New Yayasan_Deni_Mulia.GambarDataSet()
        Me.GambarDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GambarDataSet2 = New Yayasan_Deni_Mulia.GambarDataSet2()
        Me.GambarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GambarTableAdapter = New Yayasan_Deni_Mulia.GambarDataSet2TableAdapters.GambarTableAdapter()
        Me.NISDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FileNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImageDataDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.FileTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.NAMADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TEMPATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TANGGALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NISDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ALAMATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JURUSANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EKSKULDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAILDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BIAYADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
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
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.Sekolah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SekolahBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransferDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransferBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GambarDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GambarDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GambarDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GambarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Sekolah
        '
        Me.Sekolah.DataSetName = "Sekolah"
        Me.Sekolah.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SekolahBindingSource
        '
        Me.SekolahBindingSource.DataMember = "Sekolah"
        Me.SekolahBindingSource.DataSource = Me.Sekolah
        '
        'SekolahTableAdapter
        '
        Me.SekolahTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NISDataGridViewTextBoxColumn, Me.TRFDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TransferBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(758, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(10, 13)
        Me.DataGridView1.TabIndex = 0
        '
        'TransferDataSet
        '
        Me.TransferDataSet.DataSetName = "TransferDataSet"
        Me.TransferDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TransferBindingSource
        '
        Me.TransferBindingSource.DataMember = "Transfer"
        Me.TransferBindingSource.DataSource = Me.TransferDataSet
        '
        'TransferTableAdapter
        '
        Me.TransferTableAdapter.ClearBeforeFill = True
        '
        'NISDataGridViewTextBoxColumn
        '
        Me.NISDataGridViewTextBoxColumn.DataPropertyName = "NIS"
        Me.NISDataGridViewTextBoxColumn.HeaderText = "NIS"
        Me.NISDataGridViewTextBoxColumn.Name = "NISDataGridViewTextBoxColumn"
        Me.NISDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TRFDataGridViewTextBoxColumn
        '
        Me.TRFDataGridViewTextBoxColumn.DataPropertyName = "TRF"
        Me.TRFDataGridViewTextBoxColumn.HeaderText = "TRF"
        Me.TRFDataGridViewTextBoxColumn.Name = "TRFDataGridViewTextBoxColumn"
        Me.TRFDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NISDataGridViewTextBoxColumn1, Me.FileNameDataGridViewTextBoxColumn, Me.ImageDataDataGridViewImageColumn, Me.FileTypeDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.GambarBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(774, 12)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(14, 13)
        Me.DataGridView2.TabIndex = 1
        '
        'GambarDataSet
        '
        Me.GambarDataSet.DataSetName = "GambarDataSet"
        Me.GambarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GambarDataSetBindingSource
        '
        Me.GambarDataSetBindingSource.DataSource = Me.GambarDataSet
        Me.GambarDataSetBindingSource.Position = 0
        '
        'GambarDataSet2
        '
        Me.GambarDataSet2.DataSetName = "GambarDataSet2"
        Me.GambarDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GambarBindingSource
        '
        Me.GambarBindingSource.DataMember = "Gambar"
        Me.GambarBindingSource.DataSource = Me.GambarDataSet2
        '
        'GambarTableAdapter
        '
        Me.GambarTableAdapter.ClearBeforeFill = True
        '
        'NISDataGridViewTextBoxColumn1
        '
        Me.NISDataGridViewTextBoxColumn1.DataPropertyName = "NIS"
        Me.NISDataGridViewTextBoxColumn1.HeaderText = "NIS"
        Me.NISDataGridViewTextBoxColumn1.Name = "NISDataGridViewTextBoxColumn1"
        Me.NISDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'FileNameDataGridViewTextBoxColumn
        '
        Me.FileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName"
        Me.FileNameDataGridViewTextBoxColumn.HeaderText = "FileName"
        Me.FileNameDataGridViewTextBoxColumn.Name = "FileNameDataGridViewTextBoxColumn"
        Me.FileNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ImageDataDataGridViewImageColumn
        '
        Me.ImageDataDataGridViewImageColumn.DataPropertyName = "ImageData"
        Me.ImageDataDataGridViewImageColumn.HeaderText = "ImageData"
        Me.ImageDataDataGridViewImageColumn.Name = "ImageDataDataGridViewImageColumn"
        Me.ImageDataDataGridViewImageColumn.ReadOnly = True
        '
        'FileTypeDataGridViewTextBoxColumn
        '
        Me.FileTypeDataGridViewTextBoxColumn.DataPropertyName = "FileType"
        Me.FileTypeDataGridViewTextBoxColumn.HeaderText = "FileType"
        Me.FileTypeDataGridViewTextBoxColumn.Name = "FileTypeDataGridViewTextBoxColumn"
        Me.FileTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AllowUserToOrderColumns = True
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NAMADataGridViewTextBoxColumn, Me.TEMPATDataGridViewTextBoxColumn, Me.TANGGALDataGridViewTextBoxColumn, Me.NISDataGridViewTextBoxColumn2, Me.ALAMATDataGridViewTextBoxColumn, Me.JURUSANDataGridViewTextBoxColumn, Me.HPDataGridViewTextBoxColumn, Me.EKSKULDataGridViewTextBoxColumn, Me.EMAILDataGridViewTextBoxColumn, Me.BIAYADataGridViewTextBoxColumn, Me.STATUSDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.SekolahBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(794, 12)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.Size = New System.Drawing.Size(13, 12)
        Me.DataGridView3.TabIndex = 2
        '
        'NAMADataGridViewTextBoxColumn
        '
        Me.NAMADataGridViewTextBoxColumn.DataPropertyName = "NAMA"
        Me.NAMADataGridViewTextBoxColumn.HeaderText = "NAMA"
        Me.NAMADataGridViewTextBoxColumn.Name = "NAMADataGridViewTextBoxColumn"
        Me.NAMADataGridViewTextBoxColumn.ReadOnly = True
        '
        'TEMPATDataGridViewTextBoxColumn
        '
        Me.TEMPATDataGridViewTextBoxColumn.DataPropertyName = "TEMPAT"
        Me.TEMPATDataGridViewTextBoxColumn.HeaderText = "TEMPAT"
        Me.TEMPATDataGridViewTextBoxColumn.Name = "TEMPATDataGridViewTextBoxColumn"
        Me.TEMPATDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TANGGALDataGridViewTextBoxColumn
        '
        Me.TANGGALDataGridViewTextBoxColumn.DataPropertyName = "TANGGAL"
        Me.TANGGALDataGridViewTextBoxColumn.HeaderText = "TANGGAL"
        Me.TANGGALDataGridViewTextBoxColumn.Name = "TANGGALDataGridViewTextBoxColumn"
        Me.TANGGALDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NISDataGridViewTextBoxColumn2
        '
        Me.NISDataGridViewTextBoxColumn2.DataPropertyName = "NIS"
        Me.NISDataGridViewTextBoxColumn2.HeaderText = "NIS"
        Me.NISDataGridViewTextBoxColumn2.Name = "NISDataGridViewTextBoxColumn2"
        Me.NISDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'ALAMATDataGridViewTextBoxColumn
        '
        Me.ALAMATDataGridViewTextBoxColumn.DataPropertyName = "ALAMAT"
        Me.ALAMATDataGridViewTextBoxColumn.HeaderText = "ALAMAT"
        Me.ALAMATDataGridViewTextBoxColumn.Name = "ALAMATDataGridViewTextBoxColumn"
        Me.ALAMATDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JURUSANDataGridViewTextBoxColumn
        '
        Me.JURUSANDataGridViewTextBoxColumn.DataPropertyName = "JURUSAN"
        Me.JURUSANDataGridViewTextBoxColumn.HeaderText = "JURUSAN"
        Me.JURUSANDataGridViewTextBoxColumn.Name = "JURUSANDataGridViewTextBoxColumn"
        Me.JURUSANDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HPDataGridViewTextBoxColumn
        '
        Me.HPDataGridViewTextBoxColumn.DataPropertyName = "HP"
        Me.HPDataGridViewTextBoxColumn.HeaderText = "HP"
        Me.HPDataGridViewTextBoxColumn.Name = "HPDataGridViewTextBoxColumn"
        Me.HPDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EKSKULDataGridViewTextBoxColumn
        '
        Me.EKSKULDataGridViewTextBoxColumn.DataPropertyName = "EKSKUL"
        Me.EKSKULDataGridViewTextBoxColumn.HeaderText = "EKSKUL"
        Me.EKSKULDataGridViewTextBoxColumn.Name = "EKSKULDataGridViewTextBoxColumn"
        Me.EKSKULDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EMAILDataGridViewTextBoxColumn
        '
        Me.EMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn.Name = "EMAILDataGridViewTextBoxColumn"
        Me.EMAILDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BIAYADataGridViewTextBoxColumn
        '
        Me.BIAYADataGridViewTextBoxColumn.DataPropertyName = "BIAYA"
        Me.BIAYADataGridViewTextBoxColumn.HeaderText = "BIAYA"
        Me.BIAYADataGridViewTextBoxColumn.Name = "BIAYADataGridViewTextBoxColumn"
        Me.BIAYADataGridViewTextBoxColumn.ReadOnly = True
        '
        'STATUSDataGridViewTextBoxColumn
        '
        Me.STATUSDataGridViewTextBoxColumn.DataPropertyName = "STATUS"
        Me.STATUSDataGridViewTextBoxColumn.HeaderText = "STATUS"
        Me.STATUSDataGridViewTextBoxColumn.Name = "STATUSDataGridViewTextBoxColumn"
        Me.STATUSDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(646, 125)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(132, 25)
        Me.Label22.TabIndex = 65
        Me.Label22.Text = "Tidak ada foto"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(658, 407)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(77, 25)
        Me.Label21.TabIndex = 64
        Me.Label21.Text = "Label21"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(617, 368)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(161, 25)
        Me.Label20.TabIndex = 63
        Me.Label20.Text = "Total Pembayaran"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(658, 320)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(77, 25)
        Me.Label19.TabIndex = 62
        Me.Label19.Text = "Label19"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(617, 285)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(150, 25)
        Me.Label18.TabIndex = 61
        Me.Label18.Text = "Tanggal Transfer"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(663, 79)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 123)
        Me.PictureBox1.TabIndex = 60
        Me.PictureBox1.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(284, 356)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 25)
        Me.Label17.TabIndex = 59
        Me.Label17.Text = "Label17"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(284, 320)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 25)
        Me.Label16.TabIndex = 58
        Me.Label16.Text = "Label16"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(284, 285)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 25)
        Me.Label15.TabIndex = 57
        Me.Label15.Text = "Label15"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(284, 247)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 25)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "Label14"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(284, 211)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 25)
        Me.Label13.TabIndex = 55
        Me.Label13.Text = "Label13"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(284, 177)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 25)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "Label12"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(284, 140)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 25)
        Me.Label11.TabIndex = 53
        Me.Label11.Text = "Label11"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(284, 105)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 25)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Label10"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(41, 320)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 25)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Ekskul :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(41, 247)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 25)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Jurusan :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(41, 356)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 25)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Email :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(41, 285)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 25)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "No HP :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 25)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Alamat :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 25)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "NIS :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 25)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Tempat / Tanggal Lahir :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 25)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Nama Lengkap :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(349, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 25)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Cek Data Siswa"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Location = New System.Drawing.Point(354, 407)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 38)
        Me.Button1.TabIndex = 66
        Me.Button1.Text = "Kembali"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CekData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(819, 457)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "CekData"
        Me.Text = "Cek Data Siswa"
        CType(Me.Sekolah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SekolahBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransferDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransferBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GambarDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GambarDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GambarDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GambarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Sekolah As Sekolah
    Friend WithEvents SekolahBindingSource As BindingSource
    Friend WithEvents SekolahTableAdapter As SekolahTableAdapters.SekolahTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TransferDataSet As TransferDataSet
    Friend WithEvents TransferBindingSource As BindingSource
    Friend WithEvents TransferTableAdapter As TransferDataSetTableAdapters.TransferTableAdapter
    Friend WithEvents NISDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TRFDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents GambarDataSetBindingSource As BindingSource
    Friend WithEvents GambarDataSet As GambarDataSet
    Friend WithEvents GambarDataSet2 As GambarDataSet2
    Friend WithEvents GambarBindingSource As BindingSource
    Friend WithEvents GambarTableAdapter As GambarDataSet2TableAdapters.GambarTableAdapter
    Friend WithEvents NISDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FileNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImageDataDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents FileTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents NAMADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TEMPATDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TANGGALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NISDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ALAMATDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JURUSANDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EKSKULDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EMAILDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BIAYADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STATUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
