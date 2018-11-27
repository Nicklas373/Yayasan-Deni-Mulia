Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class Pembayaran
    Dim rb As String
    Dim rb2 As Integer
    Dim S1 As String = "Belum Lunas"
    Dim S2 As String = "Sudah Lunas"
    Dim S3 As String = "Belum Daftar Ulang"
    Dim S4 As String = "Sudah Daftar Ulang"
    Dim biaya As Integer = "0"
    Dim AK As Integer = "2700000"
    Dim TKJ As Integer = "2900000"
    Dim AP As Integer = "3000000"
    Dim MM As Integer = "3850000"
    Dim kelas As String = "1"
    Dim cons As String = System.Configuration.ConfigurationManager.ConnectionStrings("Yayasan_Deni_Mulia.My.MySettings.Sekolah").ConnectionString
    Dim con = New SqlConnection(cons)
    Dim cons2 As String = System.Configuration.ConfigurationManager.ConnectionStrings("Yayasan_Deni_Mulia.My.MySettings.Data").ConnectionString
    Dim con2 = New SqlConnection(cons2)
    Public cmd As SqlCommand
    Public cmd2 As SqlCommand
    Dim bayar As Integer
    Dim hasil As Integer
    Dim st As String
    Private e As Object
    Private sender As Object

    Private Sub Pembayaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi1()
        sklh_load()
        gambar_load()
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

    Public Function gambar_load()
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim cons As String = System.Configuration.ConfigurationManager.ConnectionStrings("Yayasan_Deni_Mulia.My.MySettings.Sekolah").ConnectionString
        Dim con = New SqlConnection(cons)

        'TODO: This line of code loads data into the 'GambarDataSet.Gambar' table. You can move, or remove it, as needed.
        Me.GambarTableAdapter.Fill(Me.GambarDataSet.Gambar)
        con.Open()
        'SET A NEW SPECIFIC TABLE IN THE DATABASE
        dt = New DataTable
        'SET YOUR COMMANDS TO PROVIDE A TEXT-BASE INTERFACE INTO THE MYSQL DATABASE SERVER. 
        'AND ONCE IT'S CONNECTED, YOU CAN MAKE QUERY OR MANY OTHER OPERATION.
        Dim query5 As String = "SELECT * FROM Gambar"
        cmd = New SqlCommand(query5, con)
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

    Public Function sklh_load()
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim cons As String = System.Configuration.ConfigurationManager.ConnectionStrings("Yayasan_Deni_Mulia.My.MySettings.Sekolah").ConnectionString
        Dim con = New SqlConnection(cons)

        'TODO: This line of code loads data into the 'SekolahDataSet3.Sekolah' table. You can move, or remove it, as needed.
        Me.SekolahTableAdapter1.Fill(Me.SekolahDataSet3.Sekolah)
        con.Open()
        'SET A NEW SPECIFIC TABLE IN THE DATABASE
        dt = New DataTable
        'SET YOUR COMMANDS TO PROVIDE A TEXT-BASE INTERFACE INTO THE MYSQL DATABASE SERVER. 
        'AND ONCE IT'S CONNECTED, YOU CAN MAKE QUERY OR MANY OTHER OPERATION.
        Dim query4 As String = "SELECT * FROM Sekolah"
        cmd = New SqlCommand(query4, con)
        'SET THIS STORED PROCEDURE TO SELECT THE RECORD IN THE DATASOURCE
        da.SelectCommand = cmd
        'FILLING THE DATA IN THE DATATABLE
        da.Fill(dt)
        'SET THE DATASOURCE OF THE DATAGRIDVIEW
        DataGridView2.DataSource = dt
        'CLOSING THE CONNECTION
        con.Close()
        da.Dispose()
        Return 0
    End Function

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
            con.close()
            Label13.Visible = True
            PictureBox1.Visible = False
        End If
        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FilterData(Label5.Text)
        Dim query As String = "select NIS from Sekolah where NIS=@NIS"
        con.Open()
        cmd = New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@NIS", Label5.Text)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader()
        If (dr.HasRows) Then
            Label12.Text = DataGridView2.Item(10, DataGridView2.CurrentRow.Index).Value
            Dim total = TextBox1.Text
            bayar = Label9.Text
            con.close()
            If S1 = Label12.Text Then
                If total > bayar Then
                    hasil = total - bayar
                    MessageBox.Show("Pembayaran telah berhasil " + vbCrLf + "Saldo pembayaran sebesar :  " + "Rp. " + total + vbCrLf + "Kembalian anda sebesar : " + "Rp. " + Format(hasil, "#,###,##0"))
                    con.open()
                    Dim updateQuery As String = "UPDATE dbo.Sekolah SET dbo.Sekolah.STATUS = @status WHERE Sekolah.NIS = @nis"
                    Using cmd3 As New SqlCommand(updateQuery, con)
                        cmd3.Parameters.Add(New SqlParameter With {.ParameterName = "@nis", .SqlDbType = SqlDbType.Int, .Value = Daftar.TextBox3.Text})
                        cmd3.Parameters.Add(New SqlParameter With {.ParameterName = "@status", .SqlDbType = SqlDbType.NVarChar, .Value = S2})
                        cmd3.ExecuteNonQuery()
                        con.Close()
                    End Using
                    con2.Open()
                    cmd2 = New SqlCommand("insert into Data([NIS],[NAMA],[JURUSAN],[KELAS],[EKSKUL],[STATUS],[BIAYA]) values(@nis,@nama,@jurusan,@kelas,@ekskul,@status,@biaya)", con2)
                    cmd2.Parameters.Add("@nis", SqlDbType.Int).Value = Daftar.TextBox3.Text
                    cmd2.Parameters.Add("@nama", SqlDbType.NVarChar).Value = Label4.Text
                    RadioButton()
                    cmd2.Parameters.Add("@jurusan", SqlDbType.NVarChar).Value = rb
                    cmd2.Parameters.Add("@kelas", SqlDbType.NVarChar).Value = kelas
                    cmd2.Parameters.Add("@ekskul", SqlDbType.NVarChar).Value = Daftar.ComboBox2.Text
                    cmd2.Parameters.Add("@status", SqlDbType.NVarChar).Value = S3
                    cmd2.Parameters.Add("@biaya", SqlDbType.Decimal).Value = biaya
                    cmd2.ExecuteNonQuery()
                    con2.Close()
                    trf()
                    MsgBox("Anda sudah menyelesaikan pembayaran" + vbCrLf + "Selamat datang di Sekolah Yayasan Deni Mulia", MsgBoxStyle.Information)
                    Konfirmasi.Show()
                ElseIf total = bayar Then
                    hasil = bayar
                    MsgBox("Pembayaran telah berhasil " + vbCrLf + "Saldo pembayaran sebesar :  " + "Rp. " + total, MsgBoxStyle.Information)
                    con.open()
                    Dim updateQuery As String = "UPDATE dbo.Sekolah SET dbo.Sekolah.STATUS = @status WHERE Sekolah.NIS = @nis"
                    Using cmd3 As New SqlCommand(updateQuery, con)
                        cmd3.Parameters.Add(New SqlParameter With {.ParameterName = "@nis", .SqlDbType = SqlDbType.Int, .Value = Daftar.TextBox3.Text})
                        cmd3.Parameters.Add(New SqlParameter With {.ParameterName = "@status", .SqlDbType = SqlDbType.NVarChar, .Value = S2})
                        cmd3.ExecuteNonQuery()
                        con.Close()
                    End Using
                    con2.Open()
                    cmd2 = New SqlCommand("insert into Data([NIS],[NAMA],[JURUSAN],[KELAS],[EKSKUL],[STATUS],[BIAYA]) values(@nis,@nama,@jurusan,@kelas,@ekskul,@status,@biaya)", con2)
                    cmd2.Parameters.Add("@nis", SqlDbType.Int).Value = Daftar.TextBox3.Text
                    cmd2.Parameters.Add("@nama", SqlDbType.NVarChar).Value = Label4.Text
                    RadioButton()
                    cmd2.Parameters.Add("@jurusan", SqlDbType.NVarChar).Value = rb
                    cmd2.Parameters.Add("@kelas", SqlDbType.NVarChar).Value = kelas
                    cmd2.Parameters.Add("@ekskul", SqlDbType.NVarChar).Value = Daftar.ComboBox2.Text
                    cmd2.Parameters.Add("@status", SqlDbType.NVarChar).Value = S3
                    cmd2.Parameters.Add("@biaya", SqlDbType.Decimal).Value = biaya
                    cmd2.ExecuteNonQuery()
                    con2.Close()
                    trf()
                    MsgBox("Anda sudah menyelesaikan pembayaran" + vbCrLf + "Selamat datang di Sekolah Yayasan Deni Mulia", MsgBoxStyle.Information)
                    Konfirmasi.Show()
                ElseIf total < bayar Then
                    con.close()
                    hasil = total - bayar
                    MsgBox("Anda membayar sebesar : " + total + vbCrLf + "Uang anda kurang sebesar : " + " " + "Rp. " + Format(hasil, "#,###,##0") + vbCrLf + "Pembayaran ditunda", MsgBoxStyle.Critical)
                    MsgBox("Harap Selesaikan Pembayaran Anda", MsgBoxStyle.Critical)
                Else
                    con.close()
                End If
            ElseIf S2 = Label12.Text Then
                con.close()
                MsgBox("Anda sudah mendaftar ulang", MsgBoxStyle.Information)
            Else
                con.close()
            End If
        Else
            con.close()
            MsgBox("Data anda tidak ditemukan", MsgBoxStyle.Critical)
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

        DataGridView2.DataSource = table
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

End Class