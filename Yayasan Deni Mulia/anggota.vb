Public Class anggota
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub anggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi1()
    End Sub
End Class