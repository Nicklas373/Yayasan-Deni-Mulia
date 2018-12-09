Imports System.Data
Imports System.Data.SqlClient

Public Class TampilData
    Public cmd As New SqlCommand
    Public dt As New DataTable
    Public da As New SqlDataAdapter

    Private Sub TampilData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi1()
        Refresh_load()
    End Sub

    Private Function Refresh_load()
        Dim cons As String = System.Configuration.ConfigurationManager.ConnectionStrings("Yayasan_Deni_Mulia.My.MySettings.Data").ConnectionString
        Dim con = New SqlConnection(cons)
        con.Open()
        dt = New DataTable
        With cmd
            .Connection = con
            .CommandText = "SELECT * FROM Data WHERE JURUSAN = @JURUSAN"
            .Parameters.AddWithValue("@JURUSAN", Daftar_Ulang.Label7.Text)
        End With
        da.SelectCommand = cmd
        da.Fill(dt)
        DataGridView1.DataSource = dt
        con.Close()
        da.Dispose()
        Return 0
    End Function
End Class