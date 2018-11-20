Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Daftar.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Daftar_Ulang.Show()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("Belom dibuat")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SiswaBaruToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SiswaBaruToolStripMenuItem.Click
        Siswa_Baru.Show()
    End Sub

    Private Sub SiswaLamaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SiswaLamaToolStripMenuItem.Click
        Siswa_Lama.Show()
    End Sub

    Private Sub TentangAplikasiToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TentangAplikasiToolStripMenuItem1.Click
        Tentang_Aplikasi.Show()
    End Sub
End Class
