<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Siswa_Baru
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Siswa_Baru))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NAMADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TEMPATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TANGGALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NISDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ALAMATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JURUSANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EKSKULDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAILDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BIAYADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SekolahBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SekolahDataSet4 = New Yayasan_Deni_Mulia.SekolahDataSet4()
        Me.SekolahTableAdapter = New Yayasan_Deni_Mulia.SekolahDataSet4TableAdapters.SekolahTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SekolahBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SekolahDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 21.75!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(453, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data Siswa Baru"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 21.75!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(444, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(262, 40)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Yayasan Deni Mulia"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NAMADataGridViewTextBoxColumn, Me.TEMPATDataGridViewTextBoxColumn, Me.TANGGALDataGridViewTextBoxColumn, Me.NISDataGridViewTextBoxColumn, Me.ALAMATDataGridViewTextBoxColumn, Me.JURUSANDataGridViewTextBoxColumn, Me.HPDataGridViewTextBoxColumn, Me.EKSKULDataGridViewTextBoxColumn, Me.EMAILDataGridViewTextBoxColumn, Me.BIAYADataGridViewTextBoxColumn, Me.STATUSDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SekolahBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 244)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1145, 374)
        Me.DataGridView1.TabIndex = 3
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
        'NISDataGridViewTextBoxColumn
        '
        Me.NISDataGridViewTextBoxColumn.DataPropertyName = "NIS"
        Me.NISDataGridViewTextBoxColumn.HeaderText = "NIS"
        Me.NISDataGridViewTextBoxColumn.Name = "NISDataGridViewTextBoxColumn"
        Me.NISDataGridViewTextBoxColumn.ReadOnly = True
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
        'SekolahBindingSource
        '
        Me.SekolahBindingSource.DataMember = "Sekolah"
        Me.SekolahBindingSource.DataSource = Me.SekolahDataSet4
        '
        'SekolahDataSet4
        '
        Me.SekolahDataSet4.DataSetName = "SekolahDataSet4"
        Me.SekolahDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SekolahTableAdapter
        '
        Me.SekolahTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Location = New System.Drawing.Point(213, 624)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 45)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Perbaharui"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.Location = New System.Drawing.Point(775, 624)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 45)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Kembali"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(120, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cari Data Siswa "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(41, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "NIS "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(101, 180)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(171, 29)
        Me.TextBox1.TabIndex = 8
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.Location = New System.Drawing.Point(308, 180)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 29)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Cari"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button4.Location = New System.Drawing.Point(494, 624)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(115, 45)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Cetak Data"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Siswa_Baru
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1163, 681)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Siswa_Baru"
        Me.Text = "Cek Data Siswa Baru"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SekolahBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SekolahDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SekolahDataSet4 As SekolahDataSet4
    Friend WithEvents SekolahBindingSource As BindingSource
    Friend WithEvents SekolahTableAdapter As SekolahDataSet4TableAdapters.SekolahTableAdapter
    Friend WithEvents NAMADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TEMPATDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TANGGALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NISDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ALAMATDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JURUSANDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EKSKULDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EMAILDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BIAYADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STATUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
