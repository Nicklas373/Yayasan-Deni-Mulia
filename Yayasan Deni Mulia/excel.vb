Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office
Imports System.Runtime.InteropServices
Imports System.IO

Module Export1
    Public DataGridView1 As New DataGridView
    Public Sub Show1(DataGridView1 As DataGridView)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Int16, j As Int16
        Dim sv As String = "C:\Users\" & SystemInformation.UserName & "\Documents"
        Dim saveFileDialog1 As New SaveFileDialog()
        Dim sPath As String

        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = CType(xlWorkBook.Sheets("sheet1"), Excel.Worksheet)

        For k As Integer = 0 To DataGridView1.Columns.Count - 1
            xlWorkSheet.Cells(1, k + 1) = DataGridView1.Columns(k).HeaderText
        Next
        For i = 0 To DataGridView1.RowCount - 1
            For j = 0 To DataGridView1.ColumnCount - 1
                xlworksheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
            Next
        Next

        saveFileDialog1.Filter = "xls files (*.xls)|*.xls"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True
        saveFileDialog1.InitialDirectory = sv

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            sPath = saveFileDialog1.FileName
            xlWorkBook.SaveAs(sPath, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
         Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
            xlWorkBook.Close(True, misValue, misValue)
            xlApp.Quit()
            MsgBox("Data berhasil di export", MsgBoxStyle.Information)
        Else
            MsgBox("Data gagal di export", MsgBoxStyle.Critical)
        End If

        releaseObject(xlWorkSheet)
        releaseObject(xlWorkBook)
        releaseObject(xlApp)
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            If obj IsNot Nothing Then
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
                obj = Nothing
            End If

        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

End Module