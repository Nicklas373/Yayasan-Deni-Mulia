Imports System.Data
Imports System.Data.SqlClient

Public Class Siswa_Baru
    Public cmd As New SqlCommand
    Public dt As New DataTable
    Public da As New SqlDataAdapter

    Private Sub Siswa_Baru_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Data_Refresh()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        check_data()
    End Sub

    Private Function Data_Refresh()
        Dim cons As String = System.Configuration.ConfigurationManager.ConnectionStrings("Yayasan_Deni_Mulia.My.MySettings.Sekolah").ConnectionString
        Dim con = New SqlConnection(cons)
        con.Open()
        dt = New DataTable
        With cmd
            .Connection = con
            .CommandText = "SELECT * FROM Sekolah"
        End With
        da.SelectCommand = cmd
        da.Fill(dt)
        DataGridView1.DataSource = dt
        con.Close()
        da.Dispose()
        Return 0
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

    Private Function check_data()
        Dim cons As String = System.Configuration.ConfigurationManager.ConnectionStrings("Yayasan_Deni_Mulia.My.MySettings.Sekolah").ConnectionString
        Dim con = New SqlConnection(cons)
        FilterData(TextBox1.Text)
        Dim query As String = "select NIS from Sekolah where NIS=@NIS"
        con.Open()
        cmd = New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@NIS", TextBox1.Text)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader()
        If (dr.HasRows) Then
            MessageBox.Show("Data anda ditemukan")
        Else
            MessageBox.Show("Data anda tidak ditemukan")
            con.Close()
        End If
        Return 0
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If IsNumeric(TextBox1.Text) Then
            CekData.Show()
        Else
            MsgBox("Harap Masukkan NIS anda")
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If TextBox1.Text.Length >= 8 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MsgBox("Harap masukkan NIS kurang dari 8 digit")
                TextBox1.Clear()
                TextBox1.Focus()
            End If
        End If
    End Sub
End Class