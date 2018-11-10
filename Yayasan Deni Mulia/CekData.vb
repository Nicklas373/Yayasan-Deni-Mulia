Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class CekData

    Public con = New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("Yayasan_Deni_Mulia.My.MySettings.Sekolah").ConnectionString)
    Public cmd As SqlCommand
    Public con2 = New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("Yayasan_Deni_Mulia.My.MySettings.Data").ConnectionString)
    Public cmd2 As SqlCommand

    Private Sub CekData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GambarDataSet2.Gambar' table. You can move, or remove it, as needed.
        Me.GambarTableAdapter.Fill(Me.GambarDataSet2.Gambar)
        'TODO: This line of code loads data into the 'TransferDataSet.Transfer' table. You can move, or remove it, as needed.
        Me.TransferTableAdapter.Fill(Me.TransferDataSet.Transfer)
        'TODO: This line of code loads data into the 'Sekolah._Sekolah' table. You can move, or remove it, as needed.
        Me.SekolahTableAdapter.Fill(Me.Sekolah._Sekolah)
        DataGridView1.Visible = False
        DataGridView2.Visible = False
        DataGridView3.Visible = False
        FilterData("")
        gambar("")
        checkimage()
        transfer("")
        DataLoad()
    End Sub

    Private Sub FilterData(Nis As String)
        Dim searchQuery As String = "SELECT * From Sekolah WHERE NIS like '%" & Nis & "%'"
        Dim command As New SqlCommand(searchQuery, con)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView3.DataSource = table
    End Sub

    Private Sub DataLoad()
        FilterData(Pembayaran.Label5.Text)
        gambar(Pembayaran.Label5.Text)
        transfer(Pembayaran.Label5.Text)
        Dim query As String = "select NIS from Sekolah where NIS=@NIS"
        con.Open()
        con2.Open()
        cmd = New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@NIS", Pembayaran.Label5.Text)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader()
        If (dr.HasRows) Then
            Label10.Text = DataGridView3.Item(0, DataGridView3.CurrentRow.Index).Value
            Label11.Text = DataGridView3.Item(1, DataGridView3.CurrentRow.Index).Value + " / " + Format(DataGridView3.Item(2, DataGridView3.CurrentRow.Index).Value, "yyyy-MM-dd")
            Label12.Text = DataGridView3.Item(3, DataGridView3.CurrentRow.Index).Value
            Label13.Text = DataGridView3.Item(4, DataGridView3.CurrentRow.Index).Value
            Label14.Text = DataGridView3.Item(5, DataGridView3.CurrentRow.Index).Value
            Label15.Text = DataGridView3.Item(6, DataGridView3.CurrentRow.Index).Value
            Label16.Text = DataGridView3.Item(7, DataGridView3.CurrentRow.Index).Value
            Label17.Text = DataGridView3.Item(8, DataGridView3.CurrentRow.Index).Value
            Label21.Text = "Rp. " + Format(DataGridView3.Item(9, DataGridView3.CurrentRow.Index).Value, "#,###,##0")
            Label19.Text = Format(DataGridView2.Item(1, DataGridView2.CurrentRow.Index).Value, "yyyy-MM-dd")
            con.Close()
            con2.Close()
        Else
            MessageBox.Show("Data tidak ditemukan")
            con.Close()
            con2.Close()
        End If
    End Sub

    Private Sub gambar(Nis As String)
        Dim searchQuery As String = "SELECT * From Gambar WHERE NIS like '%" & Nis & "%'"
        Dim command As New SqlCommand(searchQuery, con)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView2.DataSource = table
    End Sub

    Private Function lgambar()
        Dim dt As New DataTable
        Dim bytes As [Byte]() = CType(DataGridView2.Item(2, DataGridView2.CurrentRow.Index).Value, Byte())
        Dim ms As New MemoryStream(bytes)
        Dim query As String = "select NIS from gambar where NIS=@NIS"
        con.Open()
        cmd = New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@NIS", Pembayaran.Label5.Text)
        PictureBox1.Image = Image.FromStream(ms)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        con.Close()
        Return 0
    End Function

    Private Sub checkimage()
        gambar(Pembayaran.Label5.Text)
        Dim query As String = "select NIS from Gambar where NIS=@NIS"
        con.Open()
        cmd = New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@NIS", Pembayaran.Label5.Text)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader()
        If (dr.HasRows) Then
            con.Close()
            Label22.Visible = False
            lgambar()
        Else
            Label22.Visible = True
            PictureBox1.Visible = False
        End If
        con.Close()
    End Sub

    Private Sub transfer(Nis As String)
        Dim searchQuery As String = "SELECT * From Transfer WHERE NIS like '%" & Nis & "%'"
        Dim command As New SqlCommand(searchQuery, con)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Konfirmasi.Close()
        Pembayaran.Close()
        Daftar.Close()
    End Sub
End Class