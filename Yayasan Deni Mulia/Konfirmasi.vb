﻿Imports System.Windows.Forms

Public Class Konfirmasi

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        CekData.Show()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.Close()
        Pembayaran.Close()
        Daftar.Close()
    End Sub

    Private Sub Konfirmasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi1()
    End Sub
End Class
