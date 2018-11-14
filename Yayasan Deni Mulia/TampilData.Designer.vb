<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TampilData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TampilData))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataDataSet1 = New Yayasan_Deni_Mulia.DataDataSet1()
        Me.DataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTableAdapter = New Yayasan_Deni_Mulia.DataDataSet1TableAdapters.DataTableAdapter()
        Me.NISDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAMADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JURUSANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KELASDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EKSKULDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BIAYADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NISDataGridViewTextBoxColumn, Me.NAMADataGridViewTextBoxColumn, Me.JURUSANDataGridViewTextBoxColumn, Me.KELASDataGridViewTextBoxColumn, Me.EKSKULDataGridViewTextBoxColumn, Me.STATUSDataGridViewTextBoxColumn, Me.BIAYADataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DataBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(42, 60)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(746, 385)
        Me.DataGridView1.TabIndex = 0
        '
        'DataDataSet1
        '
        Me.DataDataSet1.DataSetName = "DataDataSet1"
        Me.DataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataBindingSource
        '
        Me.DataBindingSource.DataMember = "Data"
        Me.DataBindingSource.DataSource = Me.DataDataSet1
        '
        'DataTableAdapter
        '
        Me.DataTableAdapter.ClearBeforeFill = True
        '
        'NISDataGridViewTextBoxColumn
        '
        Me.NISDataGridViewTextBoxColumn.DataPropertyName = "NIS"
        Me.NISDataGridViewTextBoxColumn.HeaderText = "NIS"
        Me.NISDataGridViewTextBoxColumn.Name = "NISDataGridViewTextBoxColumn"
        Me.NISDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NAMADataGridViewTextBoxColumn
        '
        Me.NAMADataGridViewTextBoxColumn.DataPropertyName = "NAMA"
        Me.NAMADataGridViewTextBoxColumn.HeaderText = "NAMA"
        Me.NAMADataGridViewTextBoxColumn.Name = "NAMADataGridViewTextBoxColumn"
        Me.NAMADataGridViewTextBoxColumn.ReadOnly = True
        '
        'JURUSANDataGridViewTextBoxColumn
        '
        Me.JURUSANDataGridViewTextBoxColumn.DataPropertyName = "JURUSAN"
        Me.JURUSANDataGridViewTextBoxColumn.HeaderText = "JURUSAN"
        Me.JURUSANDataGridViewTextBoxColumn.Name = "JURUSANDataGridViewTextBoxColumn"
        Me.JURUSANDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KELASDataGridViewTextBoxColumn
        '
        Me.KELASDataGridViewTextBoxColumn.DataPropertyName = "KELAS"
        Me.KELASDataGridViewTextBoxColumn.HeaderText = "KELAS"
        Me.KELASDataGridViewTextBoxColumn.Name = "KELASDataGridViewTextBoxColumn"
        Me.KELASDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EKSKULDataGridViewTextBoxColumn
        '
        Me.EKSKULDataGridViewTextBoxColumn.DataPropertyName = "EKSKUL"
        Me.EKSKULDataGridViewTextBoxColumn.HeaderText = "EKSKUL"
        Me.EKSKULDataGridViewTextBoxColumn.Name = "EKSKULDataGridViewTextBoxColumn"
        Me.EKSKULDataGridViewTextBoxColumn.ReadOnly = True
        '
        'STATUSDataGridViewTextBoxColumn
        '
        Me.STATUSDataGridViewTextBoxColumn.DataPropertyName = "STATUS"
        Me.STATUSDataGridViewTextBoxColumn.HeaderText = "STATUS"
        Me.STATUSDataGridViewTextBoxColumn.Name = "STATUSDataGridViewTextBoxColumn"
        Me.STATUSDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BIAYADataGridViewTextBoxColumn
        '
        Me.BIAYADataGridViewTextBoxColumn.DataPropertyName = "BIAYA"
        Me.BIAYADataGridViewTextBoxColumn.HeaderText = "BIAYA"
        Me.BIAYADataGridViewTextBoxColumn.Name = "BIAYADataGridViewTextBoxColumn"
        Me.BIAYADataGridViewTextBoxColumn.ReadOnly = True
        '
        'TampilData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(819, 457)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "TampilData"
        Me.Text = "Data Siswa "
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataDataSet1 As DataDataSet1
    Friend WithEvents DataBindingSource As BindingSource
    Friend WithEvents DataTableAdapter As DataDataSet1TableAdapters.DataTableAdapter
    Friend WithEvents NISDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NAMADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JURUSANDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KELASDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EKSKULDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STATUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BIAYADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
