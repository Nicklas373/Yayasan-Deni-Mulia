Imports System.Data
Imports System.Data.SqlClient

Public Class Daftar_Ulang
    Public cmd As New SqlCommand
    Public da As New SqlDataAdapter
    Public dt As New DataTable
    Dim S1 As String = "Belum Daftar Ulang"
    Dim S2 As String = "Sudah Daftar Ulang"
    Dim hasil As Long
    Dim A As String = "1"
    Dim B As String = "2"
    Dim C As String = "3"
    Dim AP1 As Integer = "1200000"
    Dim ap11 As String = "satu juta dua ratus ribu rupiah"
    Dim AP2 As Integer = "1100000"
    Dim ap22 As String = "satu juta seratus ribu rupiah"
    Dim AP3 As Integer = "1000000"
    Dim ap33 As String = "satu juta rupiah"
    Dim MM1 As Integer = "1800000"
    Dim mm11 As String = "satu juta delapan ratus ribu rupiah"
    Dim MM2 As Integer = "1600000"
    Dim mm22 As String = "satu juta enam ratus ribu rupiah"
    Dim MM3 As Integer = "1400000"
    Dim mm33 As String = "satu juta empat ratus ribu rupiah"
    Dim AK1 As Integer = "1100000"
    Dim ak11 As String = "satu juta seratus ribut rupiah"
    Dim AK2 As Integer = "1000000"
    Dim ak22 As String = "satu juta rupiah"
    Dim AK3 As Integer = "950000"
    Dim ak33 As String = "sembilan ratus lima puluh ribu rupiah"
    Dim TKJ1 As Integer = "1000000"
    Dim tkj11 As String = "satu juta rupiah"
    Dim TKJ2 As Integer = "950000"
    Dim tkj22 As String = "sembilan ratus lima puluh ribu rupiah"
    Dim TKJ3 As Integer = "925000"
    Dim tkj33 As String = "sembilan ratus dua puluh lima ribu rupiah"
    Dim AK As String = "Akuntansi"
    Dim TKJ As String = "Teknik Komputer dan Jaringan"
    Dim MM As String = "Multimedia"
    Dim AP As String = "Administrasi Perkantoran"
    Dim KLS As String

    Private Sub Daftar_Ulang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data_load()
        FilterData("")
        DataGridView2.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        GroupBox1.Visible = False
        ComboBox1.Items.Add("1")
        ComboBox1.Items.Add("2")
        ComboBox1.Items.Add("3")
    End Sub

    Public Function data_load()
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim cons As String = System.Configuration.ConfigurationManager.ConnectionStrings("Yayasan_Deni_Mulia.My.MySettings.Data").ConnectionString
        Dim con = New SqlConnection(cons)

        'TODO: This line of code loads data into the 'DataDataSet2.Data' table. You can move, or remove it, as needed.
        Me.DataTableAdapter1.Fill(Me.DataDataSet2.Data)
        con.Open()
        'SET A NEW SPECIFIC TABLE IN THE DATABASE
        dt = New DataTable
        'SET YOUR COMMANDS TO PROVIDE A TEXT-BASE INTERFACE INTO THE MYSQL DATABASE SERVER. 
        'AND ONCE IT'S CONNECTED, YOU CAN MAKE QUERY OR MANY OTHER OPERATION.
        Dim query5 As String = "SELECT * FROM Data"
        cmd = New SqlCommand(query5, con)
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label8.Text = DataGridView2.Item(5, DataGridView2.CurrentRow.Index).Value
        If S1 = Label8.Text Then
            FilterData(TextBox2.Text)
            Dim cons As String = System.Configuration.ConfigurationManager.ConnectionStrings("Yayasan_Deni_Mulia.My.MySettings.Data").ConnectionString
            Dim con = New SqlConnection(cons)
            Dim query As String = "select NIS from Data where NIS=@NIS"
            con.Open()
            cmd = New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@NIS", TextBox2.Text)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader()
            If (dr.HasRows) Then
                MessageBox.Show("Data anda ditemukan")
                Daftar()
                con.Close()
            Else
                MessageBox.Show("Data anda tidak ditemukan")
                con.Close()
            End If
        Else
            MessageBox.Show("Anda sudah mendaftar ulang")
        End If
    End Sub

    Private Function Daftar()
        Label7.Text = DataGridView2.Item(2, DataGridView2.CurrentRow.Index).Value
        If Label7.Text = AK Then
            If ComboBox1.SelectedText = A Then
                KLS = A
                Label9.Text = AK1
                Label10.Text = ak11
                Label6.Text = "Rp. " + Format(AK1, "#,###,##0")
                Label6.Visible = True
                Label10.Visible = True
                Label11.Visible = True
                GroupBox1.Visible = True
            ElseIf ComboBox1.SelectedText = B Then
                KLS = B
                Label9.Text = AK2
                Label10.Text = ak22
                Label6.Text = "Rp. " + Format(AK2, "#,###,##0")
                Label6.Visible = True
                Label10.Visible = True
                Label11.Visible = True
                GroupBox1.Visible = True
            ElseIf ComboBox1.SelectedText = C Then
                KLS = C
                Label9.Text = AK3
                Label10.Text = ak33
                Label6.Text = "Rp. " + Format(AK3, "#,###,##0")
                Label6.Visible = True
                Label10.Visible = True
                Label11.Visible = True
                GroupBox1.Visible = True
            Else
                MsgBox("Data Invalid")
            End If
        ElseIf Label7.Text = AP Then
            If ComboBox1.SelectedText = A Then
                KLS = A
                Label9.Text = AP1
                Label10.Text = ap11
                Label6.Text = "Rp. " + Format(AP1, "#,###,##0")
                Label6.Visible = True
                Label10.Visible = True
                Label11.Visible = True
                GroupBox1.Visible = True
            ElseIf ComboBox1.SelectedText = B Then
                KLS = B
                Label9.Text = AP2
                Label10.Text = ap22
                Label6.Text = "Rp. " + Format(AP2, "#,###,##0")
                Label6.Visible = True
                Label10.Visible = True
                Label11.Visible = True
                GroupBox1.Visible = True
            ElseIf ComboBox1.SelectedText = C Then
                KLS = C
                Label9.Text = AP3
                Label10.Text = ap33
                Label6.Text = "Rp. " + Format(AP3, "#,###,##0")
                Label6.Visible = True
                Label10.Visible = True
                Label11.Visible = True
                GroupBox1.Visible = True
            Else
                MsgBox("Data Invalid")
            End If
        ElseIf Label7.Text = MM Then
            If ComboBox1.SelectedText = A Then
                KLS = A
                Label9.Text = MM1
                Label10.Text = mm11
                Label6.Text = "Rp. " + Format(MM1, "#,###,##0")
                Label6.Visible = True
                Label10.Visible = True
                Label11.Visible = True
                GroupBox1.Visible = True
            ElseIf ComboBox1.SelectedText = B Then
                KLS = B
                Label9.Text = MM2
                Label10.Text = mm22
                Label6.Text = "Rp. " + Format(MM2, "#,###,##0")
                Label6.Visible = True
                Label10.Visible = True
                Label11.Visible = True
                GroupBox1.Visible = True
            ElseIf ComboBox1.SelectedText = C Then
                KLS = C
                Label9.Text = MM3
                Label10.Text = mm33
                Label6.Text = "Rp. " + Format(MM3, "#,###,##0")
                Label6.Visible = True
                Label10.Visible = True
                Label11.Visible = True
                GroupBox1.Visible = True
            Else
                MsgBox("Data Invalid")
            End If
        ElseIf Label7.Text = TKJ Then
            If ComboBox1.SelectedText = A Then
                KLS = A
                Label9.Text = TKJ1
                Label10.Text = tkj11
                Label6.Text = "Rp. " + Format(TKJ1, "#,###,##0")
                Label6.Visible = True
                Label10.Visible = True
                Label11.Visible = True
                GroupBox1.Visible = True
            ElseIf ComboBox1.SelectedText = B Then
                KLS = B
                Label9.Text = TKJ2
                Label10.Text = tkj22
                Label6.Text = "Rp. " + Format(TKJ2, "#,###,##0")
                Label6.Visible = True
                Label10.Visible = True
                Label11.Visible = True
                GroupBox1.Visible = True
            ElseIf ComboBox1.SelectedText = C Then
                KLS = C
                Label9.Text = TKJ3
                Label10.Text = tkj33
                Label6.Text = "Rp. " + Format(TKJ3, "#,###,##0")
                Label6.Visible = True
                Label10.Visible = True
                Label11.Visible = True
                GroupBox1.Visible = True
            Else
                MsgBox("Data Invalid")
            End If
        Else
            MsgBox("Data Invalid")
        End If
        Return 0
    End Function

    Private Sub FilterData(Nis As String)
        Dim cons As String = System.Configuration.ConfigurationManager.ConnectionStrings("Yayasan_Deni_Mulia.My.MySettings.Data").ConnectionString
        Dim con = New SqlConnection(cons)
        Dim searchQuery As String = "SELECT * From Data WHERE NIS like '%" & Nis & "%'"
        Dim command As New SqlCommand(searchQuery, con)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView2.DataSource = table
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label8.Text = DataGridView2.Item(5, DataGridView2.CurrentRow.Index).Value
        If S1 = Label8.Text Then
            Dim harga As Double
            harga = CDbl(Label9.Text)
            MessageBox.Show("anda belum mendaftar ulang, silahkan mendaftar ulang")
            Dim cons As String = System.Configuration.ConfigurationManager.ConnectionStrings("Yayasan_Deni_Mulia.My.MySettings.Data").ConnectionString
            Dim con = New SqlConnection(cons)
            Dim bayar As Double
            Dim hasil As Double
            bayar = InputBox("Masukkan jumlah pembayaran : ", "Menu pembayaran")
            If bayar >= harga Then
                con.Close()
                hasil = bayar - harga
                MsgBox("Anda membayar sebesar : " + Format(bayar, "#,###,##0") + vbCrLf + "Kembalian anda sebesar : " + "Rp. " + Format(hasil, "#,###,##0"))
                Dim updateQuery As String = "UPDATE dbo.Data SET dbo.Data.STATUS = @status WHERE Data.NIS = @nis"
                con.Open()
                Using cmd As New SqlCommand(updateQuery, con)
                    cmd.Parameters.Add(New SqlParameter With {.ParameterName = "@nis", .SqlDbType = SqlDbType.Int, .Value = TextBox2.Text})
                    cmd.Parameters.Add(New SqlParameter With {.ParameterName = "@status", .SqlDbType = SqlDbType.NVarChar, .Value = S2})
                    cmd.ExecuteNonQuery()
                    con.Close()
                End Using
                Dim updateQuery2 As String = "UPDATE dbo.Data SET dbo.Data.BIAYA = @biaya WHERE Data.NIS = @nis"
                con.Open()
                Using cmd As New SqlCommand(updateQuery2, con)
                    cmd.Parameters.Add(New SqlParameter With {.ParameterName = "@nis", .SqlDbType = SqlDbType.Int, .Value = TextBox2.Text})
                    cmd.Parameters.Add(New SqlParameter With {.ParameterName = "@status", .SqlDbType = SqlDbType.NVarChar, .Value = S2})
                    cmd.Parameters.Add(New SqlParameter With {.ParameterName = "@biaya", .SqlDbType = SqlDbType.Decimal, .Value = Label9.Text})
                    cmd.ExecuteNonQuery()
                    con.Close()
                End Using
                Dim updateQuery3 As String = "UPDATE dbo.Data SET dbo.Data.KELAS = @kelas WHERE Data.NIS = @nis"
                con.Open()
                Using cmd As New SqlCommand(updateQuery3, con)
                    cmd.Parameters.Add(New SqlParameter With {.ParameterName = "@nis", .SqlDbType = SqlDbType.Int, .Value = TextBox2.Text})
                    cmd.Parameters.Add(New SqlParameter With {.ParameterName = "@status", .SqlDbType = SqlDbType.NVarChar, .Value = S2})
                    cmd.Parameters.Add(New SqlParameter With {.ParameterName = "@biaya", .SqlDbType = SqlDbType.Decimal, .Value = Label9.Text})
                    cmd.Parameters.Add(New SqlParameter With {.ParameterName = "@kelas", .SqlDbType = SqlDbType.NVarChar, .Value = KLS})
                    cmd.ExecuteNonQuery()
                    con.Close()
                End Using
                MessageBox.Show("Terima Kasih Telah" + vbCrLf + "Telah Melakukan Daftar Ulang")
                TampilData.Show()
            ElseIf bayar <= harga Then
                con.Close()
                hasil = harga - bayar
                MsgBox("Anda membayar sebesar : " + Format(bayar, "#,###,##0") + vbCrLf + "Uang anda kurang sebesar : " + " " + "Rp. " + Format(hasil, "#,###,##0") + vbCrLf + "Pembayaran ditunda")
            Else
                con.Close()
            End If
        ElseIf S2 = Label8.Text Then
            MessageBox.Show("Anda sudah mendaftar ulang")
        Else
            MsgBox("Data Invalid")
        End If
    End Sub
End Class