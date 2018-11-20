<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Daftar_Ulang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Daftar_Ulang))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SekolahDataSet2 = New Yayasan_Deni_Mulia.SekolahDataSet2()
        Me.SekolahBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SekolahTableAdapter = New Yayasan_Deni_Mulia.SekolahDataSet2TableAdapters.SekolahTableAdapter()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.NISDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAMADataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JURUSANDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KELASDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EKSKULDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUSDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BIAYADataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataDataSet2 = New Yayasan_Deni_Mulia.DataDataSet2()
        Me.DataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataDataSet = New Yayasan_Deni_Mulia.DataDataSet()
        Me.DataTableAdapter = New Yayasan_Deni_Mulia.DataDataSetTableAdapters.DataTableAdapter()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataTableAdapter1 = New Yayasan_Deni_Mulia.DataDataSet2TableAdapters.DataTableAdapter()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.SekolahDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SekolahBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(275, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Daftar Ulang Siswa/i"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(275, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(262, 40)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Yayasan Deni Mulia"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "NIS :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Kelas :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(368, 280)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 30)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "TOTAL"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(30, 371)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 48)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Bayar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(119, 147)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(202, 20)
        Me.TextBox1.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(119, 194)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(202, 20)
        Me.TextBox2.TabIndex = 8
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(119, 234)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(202, 21)
        Me.ComboBox1.TabIndex = 9
        '
        'SekolahDataSet2
        '
        Me.SekolahDataSet2.DataSetName = "SekolahDataSet2"
        Me.SekolahDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SekolahBindingSource
        '
        Me.SekolahBindingSource.DataMember = "Sekolah"
        Me.SekolahBindingSource.DataSource = Me.SekolahDataSet2
        '
        'SekolahTableAdapter
        '
        Me.SekolahTableAdapter.ClearBeforeFill = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NISDataGridViewTextBoxColumn1, Me.NAMADataGridViewTextBoxColumn1, Me.JURUSANDataGridViewTextBoxColumn1, Me.KELASDataGridViewTextBoxColumn, Me.EKSKULDataGridViewTextBoxColumn1, Me.STATUSDataGridViewTextBoxColumn1, Me.BIAYADataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.DataBindingSource1
        Me.DataGridView2.Location = New System.Drawing.Point(797, 9)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(10, 12)
        Me.DataGridView2.TabIndex = 11
        '
        'NISDataGridViewTextBoxColumn1
        '
        Me.NISDataGridViewTextBoxColumn1.DataPropertyName = "NIS"
        Me.NISDataGridViewTextBoxColumn1.HeaderText = "NIS"
        Me.NISDataGridViewTextBoxColumn1.Name = "NISDataGridViewTextBoxColumn1"
        Me.NISDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'NAMADataGridViewTextBoxColumn1
        '
        Me.NAMADataGridViewTextBoxColumn1.DataPropertyName = "NAMA"
        Me.NAMADataGridViewTextBoxColumn1.HeaderText = "NAMA"
        Me.NAMADataGridViewTextBoxColumn1.Name = "NAMADataGridViewTextBoxColumn1"
        Me.NAMADataGridViewTextBoxColumn1.ReadOnly = True
        '
        'JURUSANDataGridViewTextBoxColumn1
        '
        Me.JURUSANDataGridViewTextBoxColumn1.DataPropertyName = "JURUSAN"
        Me.JURUSANDataGridViewTextBoxColumn1.HeaderText = "JURUSAN"
        Me.JURUSANDataGridViewTextBoxColumn1.Name = "JURUSANDataGridViewTextBoxColumn1"
        Me.JURUSANDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'KELASDataGridViewTextBoxColumn
        '
        Me.KELASDataGridViewTextBoxColumn.DataPropertyName = "KELAS"
        Me.KELASDataGridViewTextBoxColumn.HeaderText = "KELAS"
        Me.KELASDataGridViewTextBoxColumn.Name = "KELASDataGridViewTextBoxColumn"
        Me.KELASDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EKSKULDataGridViewTextBoxColumn1
        '
        Me.EKSKULDataGridViewTextBoxColumn1.DataPropertyName = "EKSKUL"
        Me.EKSKULDataGridViewTextBoxColumn1.HeaderText = "EKSKUL"
        Me.EKSKULDataGridViewTextBoxColumn1.Name = "EKSKULDataGridViewTextBoxColumn1"
        Me.EKSKULDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'STATUSDataGridViewTextBoxColumn1
        '
        Me.STATUSDataGridViewTextBoxColumn1.DataPropertyName = "STATUS"
        Me.STATUSDataGridViewTextBoxColumn1.HeaderText = "STATUS"
        Me.STATUSDataGridViewTextBoxColumn1.Name = "STATUSDataGridViewTextBoxColumn1"
        Me.STATUSDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'BIAYADataGridViewTextBoxColumn1
        '
        Me.BIAYADataGridViewTextBoxColumn1.DataPropertyName = "BIAYA"
        Me.BIAYADataGridViewTextBoxColumn1.HeaderText = "BIAYA"
        Me.BIAYADataGridViewTextBoxColumn1.Name = "BIAYADataGridViewTextBoxColumn1"
        Me.BIAYADataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataBindingSource1
        '
        Me.DataBindingSource1.DataMember = "Data"
        Me.DataBindingSource1.DataSource = Me.DataDataSet2
        '
        'DataDataSet2
        '
        Me.DataDataSet2.DataSetName = "DataDataSet2"
        Me.DataDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataBindingSource
        '
        Me.DataBindingSource.DataMember = "Data"
        Me.DataBindingSource.DataSource = Me.DataDataSet
        '
        'DataDataSet
        '
        Me.DataDataSet.DataSetName = "DataDataSet"
        Me.DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTableAdapter
        '
        Me.DataTableAdapter.ClearBeforeFill = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(752, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Label7"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(707, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Label8"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(662, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Label9"
        '
        'DataTableAdapter1
        '
        Me.DataTableAdapter1.ClearBeforeFill = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(85, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 21)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Nominal"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(2, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 21)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Nominal :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Location = New System.Drawing.Point(296, 324)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 60)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'Daftar_Ulang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(819, 457)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Daftar_Ulang"
        Me.Text = "Daftar Ulang "
        CType(Me.SekolahDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SekolahBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents SekolahDataSet2 As SekolahDataSet2
    Friend WithEvents SekolahBindingSource As BindingSource
    Friend WithEvents SekolahTableAdapter As SekolahDataSet2TableAdapters.SekolahTableAdapter
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataDataSet As DataDataSet
    Friend WithEvents DataBindingSource As BindingSource
    Friend WithEvents DataTableAdapter As DataDataSetTableAdapters.DataTableAdapter
    Friend WithEvents NISDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NAMADataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents JURUSANDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents KELASDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EKSKULDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents STATUSDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BIAYADataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DataDataSet2 As DataDataSet2
    Friend WithEvents DataBindingSource1 As BindingSource
    Friend WithEvents DataTableAdapter1 As DataDataSet2TableAdapters.DataTableAdapter
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
