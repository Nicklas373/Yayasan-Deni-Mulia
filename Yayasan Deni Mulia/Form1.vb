Imports System.Windows.Forms

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Daftar.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Daftar_Ulang.Show()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Informasi.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Hide()
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Select Case e.CloseReason
            Case CloseReason.ApplicationExitCall
                e.Cancel = False
                SplashScreen1.Close()
            Case CloseReason.UserClosing
                Select Case MessageBox.Show("Apakah anda ingin keluar ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    Case DialogResult.Yes
                        e.Cancel = False
                        SplashScreen1.Close()
                    Case DialogResult.No
                        e.Cancel = True
                End Select
            Case Else
                e.Cancel = False
        End Select
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

    Private Sub TentangKamiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TentangKamiToolStripMenuItem.Click
        anggota.Show()
    End Sub
End Class
