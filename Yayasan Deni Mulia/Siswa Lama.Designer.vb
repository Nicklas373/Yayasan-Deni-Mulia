<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Siswa_Lama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Siswa_Lama))
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NISDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAMADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JURUSANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KELASDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EKSKULDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BIAYADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataDataSet3 = New Yayasan_Deni_Mulia.DataDataSet3()
        Me.DataTableAdapter = New Yayasan_Deni_Mulia.DataDataSet3TableAdapters.DataTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(319, 180)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 29)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Cari"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(112, 180)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(171, 20)
        Me.TextBox1.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(52, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 21)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "NIS :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(131, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 21)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Cari Data Siswa "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 21.75!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(455, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(262, 40)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Yayasan Deni Mulia"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 21.75!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(464, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 40)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Data Siswa Lama"
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
        Me.DataGridView1.Location = New System.Drawing.Point(220, 243)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(743, 347)
        Me.DataGridView1.TabIndex = 16
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
        'DataBindingSource
        '
        Me.DataBindingSource.DataMember = "Data"
        Me.DataBindingSource.DataSource = Me.DataDataSet3
        '
        'DataDataSet3
        '
        Me.DataDataSet3.DataSetName = "DataDataSet3"
        Me.DataDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTableAdapter
        '
        Me.DataTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(700, 624)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 45)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Kembali"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(319, 624)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 45)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Perbaharui"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Siswa_Lama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1163, 681)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Siswa_Lama"
        Me.Text = "Siswa Lama"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataDataSet3 As DataDataSet3
    Friend WithEvents DataBindingSource As BindingSource
    Friend WithEvents DataTableAdapter As DataDataSet3TableAdapters.DataTableAdapter
    Friend WithEvents NISDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NAMADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JURUSANDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KELASDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EKSKULDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STATUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BIAYADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
