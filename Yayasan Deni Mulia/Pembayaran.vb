Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class Pembayaran
    Dim rb As String
    Dim rb2 As Double
    Dim rb3 As Double
    Dim S1 As String = "Belum Lunas"
    Dim S2 As String = "Sudah Lunas"
    Dim S3 As String = "Belum Daftar Ulang"
    Dim S4 As String = "Sudah Daftar Ulang"
    Dim AK2 As Double = "1,100,000"
    Dim TKJ2 As Double = "1,000,000"
    Dim AP2 As Double = "1,200,000"
    Dim MM2 As Double = "1,800,000"
    Dim AK As Double = "2,700,000"
    Dim TKJ As Double = "2,900,000"
    Dim AP As Double = "3,000,000"
    Dim MM As Double = "3,850,000"
    Dim kelas As Integer = "1"
    Public con = New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("Yayasan_Deni_Mulia.My.MySettings.Sekolah").ConnectionString)
    Public cmd As SqlCommand
    Public con2 = New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("Yayasan_Deni_Mulia.My.MySettings.Data").ConnectionString)
    Public cmd2 As SqlCommand
    Dim bayar As Integer
    Dim hasil As Integer
    Dim st As String
    Private e As Object
    Private sender As Object

    Private Sub Pembayaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SekolahDataSet1.Sekolah' table. You can move, or remove it, as needed.
        Me.SekolahTableAdapter.Fill(Me.SekolahDataSet1.Sekolah)
        'TODO: This line of code loads data into the 'GambarDataSet.Gambar' table. You can move, or remove it, as needed.
        Me.GambarTableAdapter.Fill(Me.GambarDataSet.Gambar)
        Label12.Visible = False
        Label4.Text = Daftar.TextBox1.Text
        Label5.Text = Daftar.TextBox3.Text
        Jurusan()
        RadioButton()
        Label6.Text = rb
        Label9.Text = Format(rb2, "#,###,##0")
        DataGridView1.Visible = False
        DataGridView2.Visible = False
        FilterData("")
        gambar("")
        checkimage()
    End Sub

    Private Function RadioButton()
        If Daftar.RadioButton1.Checked = True Then
            rb = Daftar.RadioButton1.Text
        ElseIf Daftar.RadioButton2.Checked = True Then
            rb = Daftar.RadioButton2.Text
        ElseIf Daftar.RadioButton3.Checked = True Then
            rb = Daftar.RadioButton3.Text
        ElseIf Daftar.RadioButton4.Checked = True Then
            rb = Daftar.RadioButton4.Text
        Else
        End If
        Return 0
    End Function

    Private Function Jurusan()
        If Daftar.RadioButton1.Checked = True Then
            rb2 = AP
        ElseIf Daftar.RadioButton2.Checked = True Then
            rb2 = MM
        ElseIf Daftar.RadioButton3.Checked = True Then
            rb2 = AK
        ElseIf Daftar.RadioButton4.Checked = True Then
            rb2 = TKJ
        Else
        End If
        Return 0
    End Function

    Private Function JRS()
        If Daftar.RadioButton1.Checked = True Then
            rb3 = AP2
        ElseIf Daftar.RadioButton2.Checked = True Then
            rb3 = MM2
        ElseIf Daftar.RadioButton3.Checked = True Then
            rb3 = AK2
        ElseIf Daftar.RadioButton4.Checked = True Then
            rb3 = TKJ2
        Else
        End If
        Return 0
    End Function

    Private Sub gambar(Nis As String)
        Dim searchQuery As String = "SELECT * From Gambar WHERE NIS like '%" & Nis & "%'"
        Dim command As New SqlCommand(searchQuery, con)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table
    End Sub

    Private Function lgambar()
        Dim dt As New DataTable
        Dim bytes As [Byte]() = CType(DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value, Byte())
        Dim ms As New MemoryStream(bytes)
        Dim query As String = "select NIS from gambar where NIS=@NIS"
        con.Open()
        cmd = New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@NIS", Label5.Text)
        PictureBox1.Image = Image.FromStream(ms)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        con.Close()
        Return 0
    End Function

    Private Sub checkimage()
        gambar(Label5.Text)
        Dim query As String = "select NIS from Gambar where NIS=@NIS"
        con.Open()
        cmd = New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@NIS", Label5.Text)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader()
        If (dr.HasRows) Then
            con.Close()
            Label13.Visible = False
            lgambar()
        Else
            Label13.Visible = True
            PictureBox1.Visible = False
        End If
        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FilterData(Label5.Text)
        Dim query As String = "select NIS from Sekolah where NIS=@NIS"
        con.Open()
        con2.Open()
        cmd = New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@NIS", Label5.Text)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader()
        If (dr.HasRows) Then
            con.Close()
            con2.Close()
            con.Open()
            con2.Open()
            Label12.Text = DataGridView2.Item(10, DataGridView2.CurrentRow.Index).Value
            Dim total = TextBox1.Text
            bayar = Label9.Text
            If S1 = Label12.Text Then
                If total > bayar Then
                    hasil = total - bayar
                    MessageBox.Show("Pembayaran telah berhasil " + vbCrLf + "Saldo pembayaran sebesar :  " + "Rp. " + total + vbCrLf + "Kembalian anda sebesar : " + "Rp. " + Format(hasil, "#,###,##0"))
                    Dim updateQuery As String = "UPDATE dbo.Sekolah SET dbo.Sekolah.STATUS = @status WHERE Sekolah.NIS = @nis"
                    Using cmd3 As New SqlCommand(updateQuery, con)
                        cmd3.Parameters.Add(New SqlParameter With {.ParameterName = "@nis", .SqlDbType = SqlDbType.Int, .Value = Daftar.TextBox3.Text})
                        cmd3.Parameters.Add(New SqlParameter With {.ParameterName = "@status", .SqlDbType = SqlDbType.NVarChar, .Value = S2})
                        cmd3.ExecuteNonQuery()
                        con.Close()
                    End Using
                    cmd2 = New SqlCommand("insert into Data([NIS],[NAMA],[JURUSAN],[KELAS],[EKSKUL],[STATUS],[BIAYA]) values(@nis,@nama,@jurusan,@kelas,@ekskul,@status,@biaya)", con2)
                    cmd2.Parameters.Add("@nis", SqlDbType.Int).Value = Daftar.TextBox3.Text
                    cmd2.Parameters.Add("@nama", SqlDbType.NVarChar).Value = Label4.Text
                    RadioButton()
                    JRS()
                    cmd2.Parameters.Add("@jurusan", SqlDbType.NVarChar).Value = rb
                    cmd2.Parameters.Add("@kelas", SqlDbType.Int).Value = kelas
                    cmd2.Parameters.Add("@ekskul", SqlDbType.NVarChar).Value = Daftar.ComboBox2.Text
                    cmd2.Parameters.Add("@status", SqlDbType.NVarChar).Value = S3
                    cmd2.Parameters.Add("@biaya", SqlDbType.Decimal).Value = rb3
                    cmd2.ExecuteNonQuery()
                    con2.Close()
                    trf()
                    MessageBox.Show("Anda sudah menyelesaikan pembayaran" + vbCrLf + "Selamat datang di Sekolah Yayasan Deni Mulia")
                    Siswa()
                    Konfirmasi.Show()
                ElseIf total < bayar Then
                    hasil = total - bayar
                    MessageBox.Show("Anda membayar sebesar : " + total + vbCrLf + "Uang anda kurang sebesar : " + " " + "Rp. " + Format(hasil, "#,###,##0") + vbCrLf + "Pembayaran ditunda")
                    MessageBox.Show("Harap Selesaikan Pembayaran Anda")
                Else
                    con.Close()
                    con2.Close()
                End If
                con.Close()
                con2.Close()
            ElseIf S2 = Label12.Text Then
                MessageBox.Show("Anda sudah mendaftar ulang")
                con.Close()
                con2.Close()
            Else
                con.Close()
                con2.Close()
            End If
        Else
            MessageBox.Show("Data anda tidak ditemukan")
            con.Close()
            con2.Close()
        End If
    End Sub

    Private Function trf()
        Dim regDate As DateTime = DateTime.Now
        Dim strDate As String = regDate.ToString("yyyy-MM-dd")

        Dim query As String = "insert into Transfer([NIS],[TRF]) values(@nis,@trf)"
        con.Open()
        cmd = New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@nis", SqlDbType.Int).Value = Label5.Text
        cmd.Parameters.AddWithValue("@trf", SqlDbType.DateTime).Value = strDate
        cmd.ExecuteNonQuery()
        con.Close()
        Return 0
    End Function

    Private Sub FilterData(Nis As String)
        Dim searchQuery As String = "SELECT * From Sekolah WHERE NIS like '%" & Nis & "%'"
        Dim command As New SqlCommand(searchQuery, con)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table
    End Sub

    Private Function Siswa()
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        con.Open()
        'SET A NEW SPECIFIC TABLE IN THE DATABASE
        dt = New DataTable
        'SET YOUR COMMANDS TO PROVIDE A TEXT-BASE INTERFACE INTO THE MYSQL DATABASE SERVER. 
        'AND ONCE IT'S CONNECTED, YOU CAN MAKE QUERY OR MANY OTHER OPERATION.
        With cmd
            .Connection = con
            .CommandText = "SELECT * FROM Sekolah where NIS=@ID"
            .Parameters.AddWithValue("@ID", Label5.Text)
        End With
        'SET THIS STORED PROCEDURE TO SELECT THE RECORD IN THE DATASOURCE
        da.SelectCommand = cmd
        'FILLING THE DATA IN THE DATATABLE
        da.Fill(dt)
        'SET THE DATASOURCE OF THE DATAGRIDVIEW
        DataGridView1.DataSource = dt
        'CLOSING THE CONNECTION
        con.Close()
        da.Dispose()
        Return 0
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        CekData.Show()
    End Sub

End Class