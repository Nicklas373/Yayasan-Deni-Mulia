Imports System.Data
Imports System.Data.SqlClient

Module Koneksi
    Public cmd As New SqlCommand
    Dim cons As String = System.Configuration.ConfigurationManager.ConnectionStrings("Yayasan_Deni_Mulia.My.MySettings.Sekolah").ConnectionString
    Dim con = New SqlConnection(cons)
    Dim cons2 As String = System.Configuration.ConfigurationManager.ConnectionStrings("Yayasan_Deni_Mulia.My.MySettings.Data").ConnectionString
    Dim con2 = New SqlConnection(cons2)

    Public Sub koneksi1()
        If con.open() = True Then
            con.close()
        Else
            con.close()
        End If

        If con2.open() = True Then
            con2.close()
        Else
            con2.close()
        End If
    End Sub

End Module
