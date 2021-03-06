﻿Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class Daftar
    Dim rb As String
    Dim rb2 As Integer
    Dim S1 As String = "Belum Lunas"
    Dim S2 As String = "Sudah Lunas"
    Dim AK As Integer = "2700000"
    Dim TKJ As Integer = "2900000"
    Dim AP As Integer = "3000000"
    Dim MM As Integer = "3850000"

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As SqlCommand
        FilterData(TextBox3.Text)
        Dim cons As String = System.Configuration.ConfigurationManager.ConnectionStrings("Yayasan_Deni_Mulia.My.MySettings.Sekolah").ConnectionString
        Dim con = New SqlConnection(cons)
        Dim query As String = "select NIS from Sekolah where NIS=@NIS"
        con.Open()
        cmd = New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@NIS", TextBox3.Text)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader()
        If (dr.HasRows) Then
            cekdata()
            con.Close()
        Else
            con.Close()
			con.open()
            If System.IO.File.Exists(TextBox7.Text) Then
                uploadimage()
                RadioButton()
                Jurusan()
                register()
            Else
                MsgBox("Anda tidak memasukkan foto", MsgBoxStyle.Information)
                register()
            End If
        End If
    End Sub

    Private Function register()
        If IsNumeric(TextBox3.Text) And RadioButton1.Checked = True OrElse RadioButton2.Checked = True OrElse RadioButton3.Checked = True OrElse RadioButton4.Checked = True Then
            Dim cmd2 As SqlCommand
            Dim cons As String = System.Configuration.ConfigurationManager.ConnectionStrings("Yayasan_Deni_Mulia.My.MySettings.Sekolah").ConnectionString
            Dim con = New SqlConnection(cons)
            con.Open()
            RadioButton()
            Jurusan()
            cmd2 = New SqlCommand("insert into Sekolah([NAMA],[TEMPAT],[TANGGAL],[NIS],[ALAMAT],[JURUSAN],[HP],[EKSKUL],[EMAIL],[BIAYA],[STATUS]) values(@nama,@tempat,@tanggal,@nis,@alamat,@jurusan,@hp,@ekskul,@email,@biaya,@status)", con)
            cmd2.Parameters.Add("@nama", SqlDbType.NVarChar).Value = TextBox1.Text
            cmd2.Parameters.Add("@tempat", SqlDbType.NVarChar).Value = TextBox2.Text
            cmd2.Parameters.Add("@tanggal", SqlDbType.DateTime).Value = DateTimePicker1.Value
            cmd2.Parameters.Add("@nis", SqlDbType.Int).Value = TextBox3.Text
            cmd2.Parameters.Add("@alamat", SqlDbType.NVarChar).Value = TextBox4.Text
            cmd2.Parameters.Add("@jurusan", SqlDbType.NVarChar).Value = rb
            cmd2.Parameters.Add("@hp", SqlDbType.NVarChar).Value = TextBox5.Text
            cmd2.Parameters.Add("@ekskul", SqlDbType.NVarChar).Value = ComboBox2.Text
            cmd2.Parameters.Add("@email", SqlDbType.NVarChar).Value = TextBox6.Text
            cmd2.Parameters.Add("@biaya", SqlDbType.Decimal).Value = rb2
            cmd2.Parameters.Add("@status", SqlDbType.NVarChar).Value = S1
            cmd2.ExecuteNonQuery()
            MsgBox("Data anda telah di input", MsgBoxStyle.Information)
            con.Close()
            Pembayaran.Show()
        Else
            MsgBox("Harap isi NIS anda dengan angka & Harap isi jurusan anda", MsgBoxStyle.Critical)
            TextBox3.Text = ""
        End If
        Return 0
    End Function

    Private Function RadioButton()
        If RadioButton1.Checked = True Then
            rb = RadioButton1.Text
        ElseIf RadioButton2.Checked = True Then
            rb = RadioButton2.Text
        ElseIf RadioButton3.Checked = True Then
            rb = RadioButton3.Text
        ElseIf RadioButton4.Checked = True Then
            rb = RadioButton4.Text
        Else
        End If
        Return 0
    End Function

    Private Function Jurusan()
        If RadioButton1.Checked = True Then
            rb2 = AP
        ElseIf RadioButton2.Checked = True Then
            rb2 = MM
        ElseIf RadioButton3.Checked = True Then
            rb2 = AK
        ElseIf RadioButton4.Checked = True Then
            rb2 = TKJ
        Else
        End If
        Return 0
    End Function

    Private Sub Daftar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi1()
        'TODO: This line of code loads data into the 'SekolahDataSet.Sekolah' table. You can move, or remove it, as needed.
        Me.SekolahTableAdapter1.Fill(Me.SekolahDataSet.Sekolah)
        ComboBox2.Items.Add("Futsal")
        ComboBox2.Items.Add("Bulu Tangkis")
        ComboBox2.Items.Add("Tari Saman")
        ComboBox2.Items.Add("Silat")
        ComboBox2.Items.Add("Taekwondo")
        ComboBox2.Items.Add("Dance")
        ComboBox2.Items.Add("Basket")
        ComboBox2.Items.Add("Rohis")
        ComboBox2.Items.Add("Band")
        ComboBox2.Items.Add("Karate")
        TextBox7.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = True
        DataGridView1.Visible = False
        PictureBox1.Visible = False
        FilterData("")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Using OpenFileDialog As OpenFileDialog = Me.GetOpenFileDialog()

            'Open the File Dialog to select the file
            If (OpenFileDialog.ShowDialog(Me) = DialogResult.OK) Then

                TextBox7.Text = OpenFileDialog.FileName
                PictureBox1.Image = Image.FromFile(OpenFileDialog.FileName)
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                Label12.Visible = False
                PictureBox1.Visible = True

            Else 'Cancel
                Label12.Visible = True
                PictureBox1.Visible = False
                Exit Sub

            End If

        End Using
    End Sub

    Private Sub uploadimage()
        Me.Label10.Text = ""

        If LTrim(RTrim(TextBox7.Text)) = "" Then

            Me.Label10.Text = "Enter File Name"

            TextBox7.Focus()

            Exit Sub

        End If

        'Call Upload Images Or File
        Dim sFileToUpload As String = ""

        sFileToUpload = LTrim(RTrim(TextBox7.Text))

        Dim Extension As String = System.IO.Path.GetExtension(sFileToUpload)

        If StrComp(Extension, ".bmp", CompareMethod.Text) = 0 Or
            StrComp(Extension, ".jpg", CompareMethod.Text) = 0 Or
            StrComp(Extension, ".jpeg", CompareMethod.Text) = 0 Or
            StrComp(Extension, ".png", CompareMethod.Text) = 0 Or
            StrComp(Extension, ".gif", CompareMethod.Text) = 0 Then

            upLoadImageOrFile(sFileToUpload, "Image")

        Else 'Pass the extension

            upLoadImageOrFile(sFileToUpload, Extension)

        End If
    End Sub

    Private Function GetOpenFileDialog() As OpenFileDialog

        Dim openFileDialog As New OpenFileDialog

        openFileDialog.CheckPathExists = True

        openFileDialog.CheckFileExists = True

        openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.PNG;*.GIF)|*.bmp;*.jpg;*.jpeg;*.PNG;*.GIF|" +
        "PNG files (*.png)|*.png"

        openFileDialog.Multiselect = False
        openFileDialog.AddExtension = True
        openFileDialog.ValidateNames = True
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

        Return openFileDialog

    End Function

    Private Sub upLoadImageOrFile(ByVal sFilePath As String, ByVal sFileType As String)
        Dim SqlCom As SqlCommand

        Dim imageData As Byte()

        Dim sFileName As String

        Dim qry As String

        Dim cons As String = System.Configuration.ConfigurationManager.ConnectionStrings("Yayasan_Deni_Mulia.My.MySettings.Sekolah").ConnectionString
        Dim con3 = New SqlConnection(cons)

        If con3.State = ConnectionState.Closed Then

            con3.Open()

        End If

        Try

            'Read Image Bytes into a byte array 

            'Convert File to bytes Array
            imageData = ReadFile(sFilePath)

            sFileName = System.IO.Path.GetFileName(sFilePath)

            'Set insert query 
            qry = "insert into Gambar (NIS,FileName,ImageData,FileType) values(@nis,@FileName,@ImageData,@FileType)"

            'Initialize SqlCommand object for insert. 
            SqlCom = New SqlCommand(qry, con3)

            'We are passing File Name and Image byte data as sql parameters. 

            SqlCom.Parameters.Add(New SqlParameter("@nis", TextBox3.Text))
            SqlCom.Parameters.Add(New SqlParameter("@FileName", sFileName))
            SqlCom.Parameters.Add(New SqlParameter("@ImageData", DirectCast(imageData, Object)))

            SqlCom.Parameters.Add(New SqlParameter("@FileType", sFileType))

            'Execute the Query
            SqlCom.ExecuteNonQuery()

            Label10.Visible = False

            con3.Close()

        Catch ex As Exception
            con3.Close()
        End Try
    End Sub

    Private Function ReadFile(ByVal sPath As String) As Byte()

        'Initialize byte array with a null value initially. 
        Dim data As Byte() = Nothing

        'Use FileInfo object to get file size. 
        Dim fInfo As New FileInfo(sPath)
        Dim numBytes As Long = fInfo.Length

        'Open FileStream to read file 
        Dim fStream As New FileStream(sPath, FileMode.Open, FileAccess.Read)

        'Use BinaryReader to read file stream into byte array. 
        Dim br As New BinaryReader(fStream)

        'When you use BinaryReader, you need to supply number of bytes to read from file. 
        'In this case we want to read entire file. So supplying total number of bytes. 
        data = br.ReadBytes(CInt(numBytes))

        Return data
    End Function

    Private Sub FilterData(Nis As String)
        Dim cons As String = System.Configuration.ConfigurationManager.ConnectionStrings("Yayasan_Deni_Mulia.My.MySettings.Sekolah").ConnectionString
        Dim con = New SqlConnection(cons)
        Dim searchQuery As String = "SELECT * From Sekolah WHERE NIS like '%" & Nis & "%'"
        Dim command As New SqlCommand(searchQuery, con)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table
    End Sub

    Private Sub cekdata()
        Label11.Text = DataGridView1.Item(10, DataGridView1.CurrentRow.Index).Value
        If S1 = Label11.Text Then
            MsgBox("Anda sudah terdaftar" + vbCrLf + "namun anda belum melunasi pembayaran", MsgBoxStyle.Information)
            Pembayaran.Show()
        ElseIf S2 = Label11.Text Then
            MsgBox("Anda sudah terdaftar" + vbCrLf + "Anda sudah melunasi pembayaran", MsgBoxStyle.Information)
            MsgBox("Silahkan mendaftar ulang", MsgBoxStyle.Information)
            Daftar_Ulang.Show()
            Me.Close()
        Else
            MsgBox("Anda sudah terdaftar", MsgBoxStyle.Information)
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            MsgBox("Silahkan mendaftar ulang", MsgBoxStyle.Information)
            Me.Close()
            Form1.Show()
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If TextBox3.Text.Length >= 8 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MsgBox("Harap masukkan NIS kurang dari 8 digit", MsgBoxStyle.Critical)
                TextBox3.Clear()
                TextBox3.Focus()
            End If
        End If
    End Sub
End Class