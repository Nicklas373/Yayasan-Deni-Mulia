<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CekDataSiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SiswaBaruToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SiswaLamaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TentangAplikasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TentangKamiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TentangAplikasiToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Name = "Label2"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.PictureBox2, "PictureBox2")
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Purple
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Purple
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Purple
        resources.ApplyResources(Me.Button3, "Button3")
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Name = "Button3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Name = "Label3"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkMagenta
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CekDataSiswaToolStripMenuItem, Me.TentangAplikasiToolStripMenuItem})
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'CekDataSiswaToolStripMenuItem
        '
        Me.CekDataSiswaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SiswaBaruToolStripMenuItem, Me.SiswaLamaToolStripMenuItem})
        Me.CekDataSiswaToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray
        resources.ApplyResources(Me.CekDataSiswaToolStripMenuItem, "CekDataSiswaToolStripMenuItem")
        Me.CekDataSiswaToolStripMenuItem.Name = "CekDataSiswaToolStripMenuItem"
        '
        'SiswaBaruToolStripMenuItem
        '
        Me.SiswaBaruToolStripMenuItem.Name = "SiswaBaruToolStripMenuItem"
        resources.ApplyResources(Me.SiswaBaruToolStripMenuItem, "SiswaBaruToolStripMenuItem")
        '
        'SiswaLamaToolStripMenuItem
        '
        Me.SiswaLamaToolStripMenuItem.Name = "SiswaLamaToolStripMenuItem"
        resources.ApplyResources(Me.SiswaLamaToolStripMenuItem, "SiswaLamaToolStripMenuItem")
        '
        'TentangAplikasiToolStripMenuItem
        '
        Me.TentangAplikasiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TentangKamiToolStripMenuItem, Me.TentangAplikasiToolStripMenuItem1})
        Me.TentangAplikasiToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray
        Me.TentangAplikasiToolStripMenuItem.Name = "TentangAplikasiToolStripMenuItem"
        resources.ApplyResources(Me.TentangAplikasiToolStripMenuItem, "TentangAplikasiToolStripMenuItem")
        '
        'TentangKamiToolStripMenuItem
        '
        Me.TentangKamiToolStripMenuItem.Name = "TentangKamiToolStripMenuItem"
        resources.ApplyResources(Me.TentangKamiToolStripMenuItem, "TentangKamiToolStripMenuItem")
        '
        'TentangAplikasiToolStripMenuItem1
        '
        Me.TentangAplikasiToolStripMenuItem1.Name = "TentangAplikasiToolStripMenuItem1"
        resources.ApplyResources(Me.TentangAplikasiToolStripMenuItem1, "TentangAplikasiToolStripMenuItem1")
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 50
        '
        'ProgressBar1
        '
        resources.ApplyResources(Me.ProgressBar1, "ProgressBar1")
        Me.ProgressBar1.Name = "ProgressBar1"
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CekDataSiswaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SiswaBaruToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SiswaLamaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TentangAplikasiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TentangKamiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TentangAplikasiToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
