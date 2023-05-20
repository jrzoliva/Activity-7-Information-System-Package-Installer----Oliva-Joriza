Imports Microsoft.Office.Interop
Module ExcelPublic

    Public currentDate As DateTime = DateTime.Now
    Public strpassword = "jorizaoliva"
    Public xlsPath As String = System.IO.Directory.GetCurrentDirectory & "\data_ojt\TEMPLATE\"
    Public xlsFiles As String = System.IO.Directory.GetCurrentDirectory & "\data_ojt\"
    Public Sub importToExcel(ByVal mydg As DataGridView, ByVal templatefilename As String)
        Dim xlsApp As Excel.Application
        Dim xlsWB As Excel.Workbook
        Dim xlsSheet As Excel.Worksheet

        xlsApp = New Excel.Application
        xlsApp.Visible = False
        xlsWB = xlsApp.Workbooks.Open(xlsPath & templatefilename)

        xlsSheet = xlsWB.Worksheets(1)



        Dim columnName As String
        Dim z As Integer
        For z = 0 To mydg.ColumnCount - 1
            columnName = mydg.Columns(z).HeaderText
            xlsSheet.Cells(5, z + 1) = columnName
            Dim cellRange As Excel.Range = xlsSheet.Cells(5, z + 1)
            cellRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter ' Set horizontal alignment to center
            cellRange.EntireColumn.AutoFit()
            cellRange.EntireRow.AutoFit()
        Next

        Dim x, y As Integer
        For x = 0 To mydg.RowCount - 1
            For y = 0 To mydg.ColumnCount - 1
                Dim cellRange As Excel.Range = xlsSheet.Cells(x + 6, y + 1)
                cellRange.Value = mydg.Rows(x).Cells(y).Value
                cellRange.WrapText = False ' Set text wrap to true
                cellRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter ' Set horizontal alignment to center
                cellRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter ' Set vertical alignment to center
                cellRange.EntireColumn.AutoFit()
                cellRange.EntireRow.AutoFit()
            Next

        Next
        With xlsSheet.Range(convertToLetters(1) & 6, convertToLetters(mydg.ColumnCount) & x + 5)
            .Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        End With


        templatefilename = templatefilename.Replace(".xlsx", "")
        templatefilename = templatefilename.Replace(".xls", "")
        Dim myfilename As String = templatefilename & " " & currentDate.ToString("yyyy-MM-dd_HHmmss") & ".xlsx"
        MsgBox(myfilename)
        xlsSheet.Protect(strpassword)
        xlsApp.ActiveWindow.View = Excel.XlWindowView.xlPageLayoutView
        xlsApp.ActiveWindow.DisplayGridlines = False
        xlsWB.SaveAs(xlsFiles & myfilename)
        xlsApp.Quit()
        releaseObject(xlsApp)
        releaseObject(xlsWB)
        releaseObject(xlsSheet)
        System.Diagnostics.Process.Start("excel.exe", """" & xlsFiles & myfilename & """")
    End Sub

    Public Function convertToLetters(ByVal number As Integer) As String
        number -= 1
        Dim result As String = String.Empty

        If (26 > number) Then
            result = Chr(number + 65)
        Else
            Dim column As Integer

            Do
                column = number Mod 26
                number = (number \ 26) - 1
                result = Chr(column + 65) + result
            Loop Until (number < 0)
        End If

        Return result

    End Function

    Public Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

End Module
