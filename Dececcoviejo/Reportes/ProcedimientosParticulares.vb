Imports Microsoft.Office.Interop
Imports System.Data.SqlClient
Imports Microsoft.Office.Core
Imports Microsoft.Office.Core.MsoTriState
Imports System.Globalization

Public Class ProcedimientosParticulares

    Dim id_movimiento_voz As Integer
    Dim id_control As Integer

    Dim xlWorkBook As Excel.Workbook
    Dim xlWorkSheet As Excel.Worksheet
    Dim misValue As Object = System.Reflection.Missing.Value
    Dim xlApp As Excel.Application = New Excel.Application()
    Dim fila As Integer = 1

    Public Sub RealizarProcedimiento(ByVal id_movimiento_voz As Integer)

        If xlApp Is Nothing Then
            MessageBox.Show("Excel no está correctamente instalado")
            Return
        End If

        Me.id_movimiento_voz = id_movimiento_voz

        With oMovimiento_voz
            .Cargar()
            .Modificar(Me.id_movimiento_voz)
            Me.id_control = .id_control
        End With

        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = CType(xlWorkBook.Sheets(1), Excel.Worksheet)

        PageSetup()
        crearEncabezado()
        crearCuerpo()
        crearPie()

        closeFile()

    End Sub

    Private Sub PageSetup()
        xlApp.Calculation = Excel.XlCalculation.xlCalculationManual
        xlApp.ScreenUpdating = False

        xlWorkSheet.PageSetup.TopMargin = 0.8
        xlWorkSheet.PageSetup.RightMargin = 0.3
        xlWorkSheet.PageSetup.LeftMargin = 1.1
        xlWorkSheet.PageSetup.BottomMargin = 1
        xlWorkSheet.PageSetup.FooterMargin = 0
        xlWorkSheet.PageSetup.HeaderMargin = 0
        xlWorkSheet.PageSetup.AlignMarginsHeaderFooter = True
        xlWorkSheet.PageSetup.CenterHorizontally = True
        xlWorkSheet.PageSetup.PrintTitleRows = "$1:$5"
        xlWorkSheet.PageSetup.PrintTitleColumns = "$C:$F"


        'Configuracion comun
        xlWorkSheet.Range("A:A").ColumnWidth = 4
        xlWorkSheet.Range("B:B").ColumnWidth = 19
        xlWorkSheet.Range("C:C").ColumnWidth = 38
        xlWorkSheet.Range("D:D").ColumnWidth = 5
        xlWorkSheet.Range("E:E").ColumnWidth = 5
        xlWorkSheet.Range("F:F").ColumnWidth = 5.57
        xlWorkSheet.Range("G:G").ColumnWidth = 5.57
        xlWorkSheet.Range("H:H").ColumnWidth = 5.57
        xlWorkSheet.Range("I:I").ColumnWidth = 5.57

    End Sub

    Private Sub closeFile()
        'xlWorkBook.SaveAs("C:\Users\disegno-012\Documents\Sistema Dececco\Prox.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, _
        'Excel.XlSaveAsAccessMode.xlNoChange, misValue, misValue, misValue, misValue, misValue)
        xlWorkBook.ExportAsFixedFormat(Excel.XlFixedFormatType.xlTypePDF, System.IO.Path.GetTempFileName & ".pdf", Excel.XlFixedFormatQuality.xlQualityMinimum, True, False, 1, , True)

        'Dim result As DialogResult = MessageBox.Show("¿Desea guardar el archivo en formato Excel?", _
        '"Guardar checklist", _
        'MessageBoxButtons.YesNo, _
        'MessageBoxIcon.Question, _
        'MessageBoxDefaultButton.Button1)

        'If result = DialogResult.Yes Then
        '    xlWorkBook.Close(True, misValue, misValue)
        'Else
        xlWorkBook.Close(False, misValue, misValue)
        'End If

        xlApp.Quit()

        releaseObject(xlWorkSheet)
        releaseObject(xlWorkBook)
        releaseObject(xlApp)

    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try

    End Sub

    Private Sub crearEncabezado()
        Dim odt As New DataTable
        Dim cnn As New Conexion
        Dim oda As New SqlDataAdapter("getRPPMovimiento", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_movimiento_voz", SqlDbType.Int, 4, "id_movimiento_voz")
        oda.SelectCommand.Parameters("@id_movimiento_voz").Value = id_movimiento_voz

        oda.Fill(odt)

        Dim r As Excel.Range
        Dim shape As Microsoft.Office.Interop.Excel.Shape

        Try
            Dim fileName As String
            fileName = "E:\\logo descar.jpg"


            r = xlWorkSheet.Range(xlWorkSheet.Cells(fila, 1), xlWorkSheet.Cells(fila + 3, 2))
            shape = xlWorkSheet.Shapes.AddPicture(fileName, msoTrue, msoTrue, CSng(r.Left) + 30, CSng(r.Top) + 10, 80, 45)
        Catch e As Exception
        End Try
        'Merge celdas para logo Descar
        xlWorkSheet.Range(xlWorkSheet.Cells(fila, 1), xlWorkSheet.Cells(fila + 3, 2)).Merge()

        'Nombre procedimiento
        xlWorkSheet.Range(xlWorkSheet.Cells(fila, 3), xlWorkSheet.Cells(fila + 3, 6)).Merge()
        With xlWorkSheet.Range(xlWorkSheet.Cells(fila, 3), xlWorkSheet.Cells(fila + 3, 9))
            With .Font
                .Name = "Verdana"
                .Size = 13
            End With
            .WrapText = True
            .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        End With


        'Id procedimiento - RPP
        xlWorkSheet.Range(xlWorkSheet.Cells(fila, 7), xlWorkSheet.Cells(fila + 3, 9)).Merge()
        xlWorkSheet.Cells(fila, 3) = odt.Rows(0).Item("nombre_control").ToString()
        xlWorkSheet.Cells(fila, 7) = odt.Rows(0).Item("rpp").ToString()
        xlWorkSheet.Range(xlWorkSheet.Cells(fila, 7), xlWorkSheet.Cells(fila + 3, 9)).Font.Size = 11
        xlWorkSheet.Range(xlWorkSheet.Cells(fila, 7), xlWorkSheet.Cells(fila + 3, 9)).Font.FontStyle = "Bold"

        With xlWorkSheet.Range(xlWorkSheet.Cells(fila, 1), xlWorkSheet.Cells(fila + 3, 9))
            .Borders.Weight = 2.0
            .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3.0
            .Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3.0
            .Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3.0
            .Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3.0
        End With

        fila = 5

        xlWorkSheet.Range(xlWorkSheet.Cells(fila, 2), xlWorkSheet.Cells(fila, 4)).RowHeight = 4.5
        With xlWorkSheet.Range(xlWorkSheet.Cells(fila, 1), xlWorkSheet.Cells(fila, 9))
            .Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3.0
            .Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3.0
            .Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3.0
            .Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3.0
        End With

        fila = 6

        xlWorkSheet.Range(xlWorkSheet.Cells(fila, 1), xlWorkSheet.Cells(fila, 2)).Merge()
        xlWorkSheet.Cells(fila, 1) = "CLIENTE"

        xlWorkSheet.Cells(fila, 3) = odt.Rows(0).Item("cliente").ToString()

        xlWorkSheet.Range(xlWorkSheet.Cells(fila, 4), xlWorkSheet.Cells(fila, 5)).Merge()
        xlWorkSheet.Cells(fila, 4) = "FECHA"
        xlWorkSheet.Range(xlWorkSheet.Cells(fila, 6), xlWorkSheet.Cells(fila, 9)).Merge()
        xlWorkSheet.Cells(fila, 6) = CType(odt.Rows(0).Item("fecha"), Date).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)

        fila = fila + 1

        xlWorkSheet.Range(xlWorkSheet.Cells(fila, 1), xlWorkSheet.Cells(fila, 2)).Merge()
        xlWorkSheet.Cells(fila, 1) = "O.T:"
        xlWorkSheet.Range(xlWorkSheet.Cells(fila, 3), xlWorkSheet.Cells(fila, 9)).Merge()


        Dim _Actividad_Proy As New Actividad_proyecto
        With _Actividad_Proy
            .Cargar()
            .Modificar(oMovimiento_voz.id_actividad_proyecto)
        End With

        With xlWorkSheet.Range(xlWorkSheet.Cells(fila, 3), xlWorkSheet.Cells(fila, 9))
            .WrapText = False
            .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            .HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        End With

        If _Actividad_Proy.id_subproyecto <> 0 Then

            Dim oSubproyecto As New entSubproyecto
            With oSubproyecto
                .Cargar()
                .Modificar(_Actividad_Proy.id_subproyecto)
            End With

            If oSubproyecto.genera_ot Then
                xlWorkSheet.Cells(fila, 3) = CompletarCerosCodigo(CStr(oSubproyecto.ObtenerNroOrdenTrabajo(oSubproyecto.id_suproyecto)))
            Else
                xlWorkSheet.Cells(fila, 3) = CompletarCerosCodigo(CStr(oSubproyecto.ObtenerOTPadre(oSubproyecto.id_suproyecto)))
            End If
        Else
            xlWorkSheet.Cells(fila, 3) = CompletarCerosCodigo(CStr(oProyecto.ObtenerNroOrdenTrabajo(_Actividad_Proy.id_proyecto)))
        End If


        

        fila = fila + 1

        xlWorkSheet.Range(xlWorkSheet.Cells(fila, 1), xlWorkSheet.Cells(fila, 2)).Merge()
        xlWorkSheet.Cells(fila, 1) = "PROYECTO"
        xlWorkSheet.Range(xlWorkSheet.Cells(fila, 3), xlWorkSheet.Cells(fila, 9)).Merge()
        xlWorkSheet.Cells(fila, 3) = odt.Rows(0).Item("nombre_proyecto").ToString()

        With xlWorkSheet.Range(xlWorkSheet.Cells(6, 1), xlWorkSheet.Cells(8, 9))
            .Borders.Weight = 2.0
            .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3.0
            .Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3.0
            .Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3.0
            .Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3.0
        End With

        fila = fila + 1

        xlWorkSheet.Range(xlWorkSheet.Cells(fila, 1), xlWorkSheet.Cells(fila, 2)).Merge()
        xlWorkSheet.Cells(fila, 1) = "CADISTA"
        xlWorkSheet.Cells(fila, 3) = odt.Rows(0).Item("nombre_cadista").ToString()
        xlWorkSheet.Range(xlWorkSheet.Cells(fila, 4), xlWorkSheet.Cells(fila, 5)).Merge()
        xlWorkSheet.Cells(fila, 4) = "FIRMA"
        xlWorkSheet.Range(xlWorkSheet.Cells(fila, 6), xlWorkSheet.Cells(fila, 9)).Merge()

        fila = fila + 1

        xlWorkSheet.Range(xlWorkSheet.Cells(fila, 1), xlWorkSheet.Cells(fila, 2)).Merge()
        xlWorkSheet.Cells(fila, 1) = "PROYECT MANAGER"
        xlWorkSheet.Cells(fila, 3) = odt.Rows(0).Item("nombre_pm").ToString()
        xlWorkSheet.Range(xlWorkSheet.Cells(fila, 4), xlWorkSheet.Cells(fila, 5)).Merge()
        xlWorkSheet.Cells(fila, 4) = "FIRMA"
        xlWorkSheet.Range(xlWorkSheet.Cells(fila, 6), xlWorkSheet.Cells(fila, 9)).Merge()

        fila = fila + 1

        xlWorkSheet.Range(xlWorkSheet.Cells(fila, 1), xlWorkSheet.Cells(fila, 2)).Merge()
        xlWorkSheet.Cells(fila, 1) = "CONTROLADOR 1 ETAPA"
        xlWorkSheet.Cells(fila, 3) = odt.Rows(0).Item("nombre_ctrl1").ToString()
        xlWorkSheet.Range(xlWorkSheet.Cells(fila, 4), xlWorkSheet.Cells(fila, 6)).Merge()
        xlWorkSheet.Cells(fila, 4) = "FIRMA 1er CONTROL"
        xlWorkSheet.Range(xlWorkSheet.Cells(fila, 7), xlWorkSheet.Cells(fila, 9)).Merge()

        fila = fila + 1

        xlWorkSheet.Range(xlWorkSheet.Cells(fila, 1), xlWorkSheet.Cells(fila, 2)).Merge()
        xlWorkSheet.Cells(fila, 1) = "Pedido de SEGUNDO control"
        If CType(odt.Rows(0).Item("pedido_segundo_control"), Boolean) = True Then
            xlWorkSheet.Cells(fila, 3) = "SI"
        End If
        xlWorkSheet.Range(xlWorkSheet.Cells(fila, 4), xlWorkSheet.Cells(fila, 6)).Merge()
        xlWorkSheet.Cells(fila, 4) = "FIRMA 2do CONTROL"
        xlWorkSheet.Range(xlWorkSheet.Cells(fila, 7), xlWorkSheet.Cells(fila, 9)).Merge()

        With xlWorkSheet.Range(xlWorkSheet.Cells(9, 1), xlWorkSheet.Cells(12, 9))
            .Borders.Weight = 2.0
            .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            .Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3.0
            .Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = 3.0
            .Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 3.0
            .Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = 3.0
        End With

        fila = fila + 1

    End Sub

    Private Sub crearCuerpo()
        Dim odt As New DataTable
        Dim consulta As String
        Dim cnn As New Conexion
        consulta = "select * from Tipo_voz, Control where Tipo_voz.id_control = Control.id_control and control.id_control = @id_control"
        Dim border As Excel.Borders

        Dim oda As New SqlDataAdapter(consulta, cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.Text
        oda.SelectCommand.Parameters.Add("@id_control", SqlDbType.Int, 4, "id_control")
        oda.SelectCommand.Parameters("@id_control").Value = id_control


        oda.Fill(odt)
        Dim columna As Integer
        For i = 0 To odt.Rows.Count - 1
            columna = 1

            xlWorkSheet.Cells(fila, columna) = odt.Rows(i).Item("codigo").ToString()
            xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila + 1, columna)).Merge()
            border = xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila + 1, columna)).Borders
            border.LineStyle = Excel.XlLineStyle.xlContinuous
            border.Weight = 3.0
            columna = columna + 1

            xlWorkSheet.Cells(fila, columna) = odt.Rows(i).Item("nombre_tipo_voz").ToString()
            xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila + 1, columna + 1)).Merge()
            border = xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila + 1, columna + 1)).Borders
            border.LineStyle = Excel.XlLineStyle.xlContinuous
            border.Weight = 3.0
            columna = columna + 2

            xlWorkSheet.Cells(fila, columna) = "PRODUC."
            xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila, columna + 1)).Merge()
            border = xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila, columna + 1)).Borders
            border.LineStyle = Excel.XlLineStyle.xlContinuous
            border.Weight = 3.0

            xlWorkSheet.Cells(fila + 1, columna) = "NC"
            border = xlWorkSheet.Range(xlWorkSheet.Cells(fila + 1, columna), xlWorkSheet.Cells(fila + 1, columna)).Borders
            border.LineStyle = Excel.XlLineStyle.xlContinuous
            border.Weight = 3.0

            columna = columna + 1

            xlWorkSheet.Cells(fila + 1, columna) = "CTRL"
            border = xlWorkSheet.Range(xlWorkSheet.Cells(fila + 1, columna), xlWorkSheet.Cells(fila + 1, columna)).Borders
            border.LineStyle = Excel.XlLineStyle.xlContinuous
            border.Weight = 3.0
            columna = columna + 1

            xlWorkSheet.Cells(fila, columna) = "PRIMER CONTROL"
            xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila, columna + 1)).Merge()
            border = xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila, columna + 1)).Borders
            border.LineStyle = Excel.XlLineStyle.xlContinuous
            border.Weight = 3.0

            xlWorkSheet.Cells(fila + 1, columna) = "NC"
            border = xlWorkSheet.Range(xlWorkSheet.Cells(fila + 1, columna), xlWorkSheet.Cells(fila + 1, columna)).Borders
            border.LineStyle = Excel.XlLineStyle.xlContinuous
            border.Weight = 3.0

            columna = columna + 1
            xlWorkSheet.Cells(fila + 1, columna) = "CTRL"
            border = xlWorkSheet.Range(xlWorkSheet.Cells(fila + 1, columna), xlWorkSheet.Cells(fila + 1, columna)).Borders
            border.LineStyle = Excel.XlLineStyle.xlContinuous
            border.Weight = 3.0

            columna = columna + 1

            xlWorkSheet.Cells(fila, columna) = "SEGUNDO CONTROL"
            xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila, columna + 1)).Merge()
            border = xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila, columna + 1)).Borders
            border.LineStyle = Excel.XlLineStyle.xlContinuous
            border.Weight = 3.0


            xlWorkSheet.Cells(fila + 1, columna) = "NC"
            border = xlWorkSheet.Range(xlWorkSheet.Cells(fila + 1, columna), xlWorkSheet.Cells(fila + 1, columna)).Borders
            border.LineStyle = Excel.XlLineStyle.xlContinuous
            border.Weight = 3.0

            columna = columna + 1
            xlWorkSheet.Cells(fila + 1, columna) = "CTRL"
            border = xlWorkSheet.Range(xlWorkSheet.Cells(fila + 1, columna), xlWorkSheet.Cells(fila + 1, columna)).Borders
            border.LineStyle = Excel.XlLineStyle.xlContinuous
            border.Weight = 3.0

            With xlWorkSheet.Range(xlWorkSheet.Cells(fila, 1), xlWorkSheet.Cells(fila + 1, 3))
                With .Font
                    .Name = "Verdana"
                    .FontStyle = "Bold"
                    .Size = 10
                End With
            End With

            With xlWorkSheet.Range(xlWorkSheet.Cells(fila, 4), xlWorkSheet.Cells(fila + 1, columna))
                With .Font
                    .Name = "Verdana"
                    .FontStyle = "Bold"
                    .Size = 5
                End With
            End With

            xlWorkSheet.Range(xlWorkSheet.Cells(fila, 1), xlWorkSheet.Cells(fila + 1, columna)).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            xlWorkSheet.Range(xlWorkSheet.Cells(fila, 1), xlWorkSheet.Cells(fila + 1, columna)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            xlWorkSheet.Range(xlWorkSheet.Cells(fila, 1), xlWorkSheet.Cells(fila + 1, columna)).Interior.Color = Color.LightGray
            xlWorkSheet.Range(xlWorkSheet.Cells(fila, 1), xlWorkSheet.Cells(fila + 1, columna)).WrapText = True

            fila = fila + 2
            crearCuerpoMovimientoTipoVoz(CType(odt.Rows(i).Item("id_tipo_voz").ToString(), Integer))
        Next

        mostrarObservaciones()
        mostrarNotas()

    End Sub

    Private Sub crearCuerpoMovimientoTipoVoz(ByVal id_tipo_voz As Integer)
        Dim dt As DataTable
        Dim border As Excel.Borders

        If id_tipo_voz = 0 Then
            dt = oVoz.getNotas(id_movimiento_voz)
        Else
            dt = oVoz.getCuerpoMovimientoPorTipo(id_tipo_voz, id_movimiento_voz)
        End If

        Dim columna As Integer
        For Each dr As DataRow In dt.Rows
            columna = 1
            xlWorkSheet.Cells(fila, columna) = dr.Item("codigo").ToString() & "-" & dr.Item("codigo_2").ToString()

            columna = columna + 1

            xlWorkSheet.Cells(fila, columna) = dr.Item("nombre_voz").ToString()
            With xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila, columna + 1))
                With .Font
                    .Name = "Arial"
                    .Size = 8
                End With
            End With

            xlWorkSheet.Range("B:B").ColumnWidth = 57
            xlWorkSheet.Range(xlWorkSheet.Cells(fila, 2), xlWorkSheet.Cells(fila, columna)).RowHeight = 10
            xlWorkSheet.Range(xlWorkSheet.Cells(fila, 2), xlWorkSheet.Cells(fila, columna)).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            xlWorkSheet.Range(xlWorkSheet.Cells(fila, 2), xlWorkSheet.Cells(fila, columna)).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            xlWorkSheet.Range(xlWorkSheet.Cells(fila, 2), xlWorkSheet.Cells(fila, columna)).WrapText = True
            xlWorkSheet.Range(xlWorkSheet.Cells(fila, 2), xlWorkSheet.Cells(fila, 4)).EntireRow.AutoFit()
            Dim heigh As Object = xlWorkSheet.Range(xlWorkSheet.Cells(fila, 2), xlWorkSheet.Cells(fila, 4)).RowHeight
            xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila, columna + 1)).Merge()
            xlWorkSheet.Range(xlWorkSheet.Cells(fila, 2), xlWorkSheet.Cells(fila, 4)).RowHeight = heigh
            xlWorkSheet.Range("B:B").ColumnWidth = 19


            'Producción
            columna = columna + 2
            If CType(dr.Item("control1"), Boolean) = True Then
                If CType(dr.Item("nc1"), Boolean) = True Then
                    xlWorkSheet.Cells(fila, columna) = "✓"
                    xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila, columna)).Font.Color = Color.Blue
                Else

                    If CType(dr.Item("ok1"), Boolean) = True Then
                        xlWorkSheet.Cells(fila, columna + 1) = "✓"
                        xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna + 1), xlWorkSheet.Cells(fila, columna + 1)).Font.Color = Color.Green
                    Else
                        xlWorkSheet.Cells(fila, columna + 1) = "✘"
                        xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna + 1), xlWorkSheet.Cells(fila, columna + 1)).Font.Color = Color.Red
                    End If
                End If
            End If


            'Primer Control
            columna = columna + 2
            If CType(dr.Item("control2"), Boolean) = True Then
                If CType(dr.Item("nc1"), Boolean) = True Then
                    If CType(dr.Item("corresponde1"), Boolean) = True Then
                        xlWorkSheet.Cells(fila, columna) = "✘"
                        xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila, columna)).Font.Color = Color.Red
                        If CType(dr.Item("conforme1"), Boolean) = True Then
                            xlWorkSheet.Cells(fila, columna + 1) = "✓"
                            xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna + 1), xlWorkSheet.Cells(fila, columna + 1)).Font.Color = Color.Green
                        Else
                            xlWorkSheet.Cells(fila, columna + 1) = "✘"
                            xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna + 1), xlWorkSheet.Cells(fila, columna + 1)).Font.Color = Color.Red
                            If CType(dr.Item("correccion1"), Boolean) = True Then
                                xlWorkSheet.Cells(fila, columna + 1) = "✘  ✓"
                                xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna + 1), xlWorkSheet.Cells(fila, columna + 1)).Font.Color = Color.Blue
                            End If
                        End If
                    Else
                        xlWorkSheet.Cells(fila, columna) = "✓"
                        xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila, columna + 1)).Font.Color = Color.Green
                    End If
                Else
                    If CType(dr.Item("conforme1"), Boolean) = True Then
                        xlWorkSheet.Cells(fila, columna + 1) = "✓"
                        xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna + 1), xlWorkSheet.Cells(fila, columna + 1)).Font.Color = Color.Green
                    Else
                        xlWorkSheet.Cells(fila, columna + 1) = "✘"
                        xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna + 1), xlWorkSheet.Cells(fila, columna + 1)).Font.Color = Color.Red
                        If CType(dr.Item("correccion1"), Boolean) = True Then
                            xlWorkSheet.Cells(fila, columna + 1) = "✘  ✓"
                            xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna + 1), xlWorkSheet.Cells(fila, columna + 1)).Font.Color = Color.Blue
                        End If
                    End If
                End If
            End If


            If CType(dr.Item("pedido_segundo_control"), Boolean) = True Then
                'Segundo Control
                columna = columna + 2
                If CType(dr.Item("control3"), Boolean) = True Then
                    If CType(dr.Item("nc1"), Boolean) = True Then
                        If CType(dr.Item("corresponde2"), Boolean) = True Then
                            xlWorkSheet.Cells(fila, columna) = "✘"
                            xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila, columna)).Font.Color = Color.Red
                            If CType(dr.Item("conforme2"), Boolean) = True Then
                                xlWorkSheet.Cells(fila, columna + 1) = "✓"
                                xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna + 1), xlWorkSheet.Cells(fila, columna + 1)).Font.Color = Color.Green
                            Else
                                xlWorkSheet.Cells(fila, columna + 1) = "✘"
                                xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna + 1), xlWorkSheet.Cells(fila, columna + 1)).Font.Color = Color.Red
                                If CType(dr.Item("correccion2"), Boolean) = True Then
                                    xlWorkSheet.Cells(fila, columna + 1) = "✘  ✓"
                                    xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna + 1), xlWorkSheet.Cells(fila, columna + 1)).Font.Color = Color.Blue
                                End If
                            End If
                        Else
                            xlWorkSheet.Cells(fila, columna) = "✓"
                            xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila, columna + 1)).Font.Color = Color.Green
                        End If
                    Else
                        If CType(dr.Item("conforme2"), Boolean) = True Then
                            xlWorkSheet.Cells(fila, columna + 1) = "✓"
                            xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna + 1), xlWorkSheet.Cells(fila, columna + 1)).Font.Color = Color.Green
                        Else
                            xlWorkSheet.Cells(fila, columna + 1) = "✘"
                            xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna + 1), xlWorkSheet.Cells(fila, columna + 1)).Font.Color = Color.Red
                            If CType(dr.Item("correccion2"), Boolean) = True Then
                                xlWorkSheet.Cells(fila, columna + 1) = "✘  ✓"
                                xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna + 1), xlWorkSheet.Cells(fila, columna + 1)).Font.Color = Color.Blue
                            End If
                        End If
                    End If
                End If
            End If

            columna = columna + 1
            With xlWorkSheet.Range(xlWorkSheet.Cells(fila, 1), xlWorkSheet.Cells(fila, columna))
                With .Font
                    .Name = "Arial"
                    .Size = 8
                    .Bold = False
                End With
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With

            'El formato del nombre voz
            With xlWorkSheet.Range(xlWorkSheet.Cells(fila, 2), xlWorkSheet.Cells(fila, 2))
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With

            border = xlWorkSheet.Range(xlWorkSheet.Cells(fila, 1), xlWorkSheet.Cells(fila, 9)).Borders
            border.LineStyle = Excel.XlLineStyle.xlContinuous
            border.Weight = 2.0

            'xlWorkSheet.Range(xlWorkSheet.Cells(fila, 1), xlWorkSheet.Cells(fila, columna)).WrapText = True
            fila = fila + 1
        Next
    End Sub

    Private Sub crearPie()
        Dim columna As Integer = 1
        xlWorkSheet.Cells(fila, columna) = "Ref.:"
        columna = columna + 1

        xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila, 9)).Merge()
        xlWorkSheet.Cells(fila, columna) = "NC: No Corresponde    /    CTRL: Control    / CORR: Corregido    /    OT: Órden de Trabajo"


        fila = fila + 1
        xlWorkSheet.Range(xlWorkSheet.Cells(fila, 1), xlWorkSheet.Cells(fila, 9)).EntireRow.RowHeight = 60
        xlWorkSheet.Range(xlWorkSheet.Cells(fila, 1), xlWorkSheet.Cells(fila, 9)).Merge()

        fila = fila + 1
        columna = 1
        xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila, columna + 1)).Merge()
        xlWorkSheet.Cells(fila, columna) = "Prep. Resp Produc y Diseño"
        columna = columna + 2

        xlWorkSheet.Cells(fila, columna) = "Aprobó: Responsable de Dirección"
        columna = columna + 1

        xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila, columna + 5)).Merge()
        xlWorkSheet.Cells(fila, columna) = "Fecha de Emisión:  10-10-06"

        'Última fila
        fila = fila + 1
        columna = 1
        xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila, columna + 1)).Merge()
        xlWorkSheet.Cells(fila, columna) = "Lucas De Cecco"
        columna = columna + 2

        xlWorkSheet.Cells(fila, columna) = "Lucas De Cecco"
        columna = columna + 1

        xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila, columna + 3)).Merge()
        xlWorkSheet.Cells(fila, columna) = "Fecha de Rev.: 18-06-14"

        columna = columna + 4
        xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila, columna + 1)).Merge()
        xlWorkSheet.Cells(fila, columna) = "Ind. Mod: 06"

        With xlWorkSheet.Range(xlWorkSheet.Cells(fila - 3, 1), xlWorkSheet.Cells(fila, 9)).Borders
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = 2
        End With

    End Sub

    Private Sub mostrarObservaciones()
        'Dim odt As New DataTable
        'Dim consulta As String
        'Dim cnn As New Conexion
        'consulta = "select * from Tipo_voz, Control where Tipo_voz.id_control = Control.id_control and control.id_control = @id_control"
        Dim border As Excel.Borders

        'Dim oda As New SqlDataAdapter(consulta, cnn.Coneccion)

        'oda.SelectCommand.CommandType = CommandType.Text
        'oda.SelectCommand.Parameters.Add("@id_control", SqlDbType.Int, 4, "id_control")
        'oda.SelectCommand.Parameters("@id_control").Value = id_control


        'oda.Fill(odt)
        Dim columna As Integer

        'ENCABEZADO
        columna = 1

        xlWorkSheet.Cells(fila, columna) = "Z"
        xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila + 1, columna)).Merge()
        border = xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila + 1, columna)).Borders
        border.LineStyle = Excel.XlLineStyle.xlContinuous
        border.Weight = 3.0
        columna = columna + 1

        xlWorkSheet.Cells(fila, columna) = "OBSERVACIONES"
        xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila + 1, columna + 1)).Merge()
        border = xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila + 1, columna + 1)).Borders
        border.LineStyle = Excel.XlLineStyle.xlContinuous
        border.Weight = 3.0
        columna = columna + 2

        xlWorkSheet.Cells(fila, columna) = "PRODUC."
        xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila, columna + 1)).Merge()
        border = xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila, columna + 1)).Borders
        border.LineStyle = Excel.XlLineStyle.xlContinuous
        border.Weight = 3.0

        xlWorkSheet.Cells(fila + 1, columna) = "-"
        border = xlWorkSheet.Range(xlWorkSheet.Cells(fila + 1, columna), xlWorkSheet.Cells(fila + 1, columna)).Borders
        border.LineStyle = Excel.XlLineStyle.xlContinuous
        border.Weight = 3.0

        columna = columna + 1

        xlWorkSheet.Cells(fila + 1, columna) = "-"
        border = xlWorkSheet.Range(xlWorkSheet.Cells(fila + 1, columna), xlWorkSheet.Cells(fila + 1, columna)).Borders
        border.LineStyle = Excel.XlLineStyle.xlContinuous
        border.Weight = 3.0
        columna = columna + 1

        xlWorkSheet.Cells(fila, columna) = "PRIMER CONTROL"
        xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila, columna + 1)).Merge()
        border = xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila, columna + 1)).Borders
        border.LineStyle = Excel.XlLineStyle.xlContinuous
        border.Weight = 3.0

        xlWorkSheet.Cells(fila + 1, columna) = "-"
        border = xlWorkSheet.Range(xlWorkSheet.Cells(fila + 1, columna), xlWorkSheet.Cells(fila + 1, columna)).Borders
        border.LineStyle = Excel.XlLineStyle.xlContinuous
        border.Weight = 3.0

        columna = columna + 1
        xlWorkSheet.Cells(fila + 1, columna) = "CTRL"
        border = xlWorkSheet.Range(xlWorkSheet.Cells(fila + 1, columna), xlWorkSheet.Cells(fila + 1, columna)).Borders
        border.LineStyle = Excel.XlLineStyle.xlContinuous
        border.Weight = 3.0

        columna = columna + 1

        xlWorkSheet.Cells(fila, columna) = "SEGUNDO CONTROL"
        xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila, columna + 1)).Merge()
        border = xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila, columna + 1)).Borders
        border.LineStyle = Excel.XlLineStyle.xlContinuous
        border.Weight = 3.0


        xlWorkSheet.Cells(fila + 1, columna) = "NC"
        border = xlWorkSheet.Range(xlWorkSheet.Cells(fila + 1, columna), xlWorkSheet.Cells(fila + 1, columna)).Borders
        border.LineStyle = Excel.XlLineStyle.xlContinuous
        border.Weight = 3.0

        columna = columna + 1
        xlWorkSheet.Cells(fila + 1, columna) = "CTRL"
        border = xlWorkSheet.Range(xlWorkSheet.Cells(fila + 1, columna), xlWorkSheet.Cells(fila + 1, columna)).Borders
        border.LineStyle = Excel.XlLineStyle.xlContinuous
        border.Weight = 3.0

        With xlWorkSheet.Range(xlWorkSheet.Cells(fila, 1), xlWorkSheet.Cells(fila + 1, 3))
            With .Font
                .Name = "Verdana"
                .FontStyle = "Bold"
                .Size = 10
            End With
        End With

        With xlWorkSheet.Range(xlWorkSheet.Cells(fila, 4), xlWorkSheet.Cells(fila + 1, columna))
            With .Font
                .Name = "Verdana"
                .FontStyle = "Bold"
                .Size = 5
            End With
        End With

        xlWorkSheet.Range(xlWorkSheet.Cells(fila, 1), xlWorkSheet.Cells(fila + 1, columna)).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        xlWorkSheet.Range(xlWorkSheet.Cells(fila, 1), xlWorkSheet.Cells(fila + 1, columna)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        xlWorkSheet.Range(xlWorkSheet.Cells(fila, 1), xlWorkSheet.Cells(fila + 1, columna)).Interior.Color = Color.LightGray
        xlWorkSheet.Range(xlWorkSheet.Cells(fila, 1), xlWorkSheet.Cells(fila + 1, columna)).WrapText = True

        fila = fila + 2


        'DETALLE
        Dim dt As DataTable

        dt = oVoz.getObservaciones(id_movimiento_voz)

        For Each dr As DataRow In dt.Rows
            columna = 1
            xlWorkSheet.Cells(fila, columna) = dr.Item("codigo").ToString() & "-" & dr.Item("codigo_2").ToString()

            columna = columna + 1

            xlWorkSheet.Cells(fila, columna) = dr.Item("nombre_voz").ToString()
            With xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila, columna + 1))
                With .Font
                    .Name = "Arial"
                    .Size = 8
                End With
            End With

            xlWorkSheet.Range("B:B").ColumnWidth = 57
            xlWorkSheet.Range(xlWorkSheet.Cells(fila, 2), xlWorkSheet.Cells(fila, columna)).RowHeight = 10
            xlWorkSheet.Range(xlWorkSheet.Cells(fila, 2), xlWorkSheet.Cells(fila, columna)).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            xlWorkSheet.Range(xlWorkSheet.Cells(fila, 2), xlWorkSheet.Cells(fila, columna)).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            xlWorkSheet.Range(xlWorkSheet.Cells(fila, 2), xlWorkSheet.Cells(fila, columna)).WrapText = True
            xlWorkSheet.Range(xlWorkSheet.Cells(fila, 2), xlWorkSheet.Cells(fila, 4)).EntireRow.AutoFit()
            Dim heigh As Object = xlWorkSheet.Range(xlWorkSheet.Cells(fila, 2), xlWorkSheet.Cells(fila, 4)).RowHeight
            xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila, columna + 1)).Merge()
            xlWorkSheet.Range(xlWorkSheet.Cells(fila, 2), xlWorkSheet.Cells(fila, 4)).RowHeight = heigh
            xlWorkSheet.Range("B:B").ColumnWidth = 19


            'Producción
            columna = columna + 2
            'If CType(dr.Item("control1"), Boolean) = True Then
            '    If CType(dr.Item("nc1"), Boolean) = True Then
            '        xlWorkSheet.Cells(fila, columna) = "✓"
            '        xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila, columna)).Font.Color = Color.Blue
            '    Else

            '        If CType(dr.Item("ok1"), Boolean) = True Then
            '            xlWorkSheet.Cells(fila, columna + 1) = "✓"
            '            xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna + 1), xlWorkSheet.Cells(fila, columna + 1)).Font.Color = Color.Green
            '        Else
            '            xlWorkSheet.Cells(fila, columna + 1) = "✘"
            '            xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna + 1), xlWorkSheet.Cells(fila, columna + 1)).Font.Color = Color.Red
            '        End If
            '    End If
            'End If


            'Primer Control
            columna = columna + 2
            If CType(dr.Item("control2"), Boolean) = True Then
                'If CType(dr.Item("nc1"), Boolean) = True Then
                'If CType(dr.Item("corresponde1"), Boolean) = True Then
                '    xlWorkSheet.Cells(fila, columna) = "✘"
                '    xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila, columna)).Font.Color = Color.Red
                '    If CType(dr.Item("conforme1"), Boolean) = True Then
                '        xlWorkSheet.Cells(fila, columna + 1) = "✓"
                '        xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna + 1), xlWorkSheet.Cells(fila, columna + 1)).Font.Color = Color.Green
                '    Else
                '        xlWorkSheet.Cells(fila, columna + 1) = "✘"
                '        xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna + 1), xlWorkSheet.Cells(fila, columna + 1)).Font.Color = Color.Red
                '        If CType(dr.Item("correccion1"), Boolean) = True Then
                '            xlWorkSheet.Cells(fila, columna + 1) = "✘  ✓"
                '            xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna + 1), xlWorkSheet.Cells(fila, columna + 1)).Font.Color = Color.Blue
                '        End If
                '    End If
                'Else
                '    xlWorkSheet.Cells(fila, columna) = "✓"
                '    xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila, columna + 1)).Font.Color = Color.Green
                'End If
            Else
                '    If CType(dr.Item("conforme1"), Boolean) = True Then
                xlWorkSheet.Cells(fila, columna + 1) = "✓"
                xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna + 1), xlWorkSheet.Cells(fila, columna + 1)).Font.Color = Color.Green
                '    Else
                '        xlWorkSheet.Cells(fila, columna + 1) = "✘"
                '        xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna + 1), xlWorkSheet.Cells(fila, columna + 1)).Font.Color = Color.Red
                '        If CType(dr.Item("correccion1"), Boolean) = True Then
                '            xlWorkSheet.Cells(fila, columna + 1) = "✘  ✓"
                '            xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna + 1), xlWorkSheet.Cells(fila, columna + 1)).Font.Color = Color.Blue
                '        End If
                '    End If
                'End If
            End If


            'If CType(dr.Item("pedido_segundo_control"), Boolean) = True Then
            '    'Segundo Control
            '    columna = columna + 2
            '    If CType(dr.Item("control3"), Boolean) = True Then
            '        If CType(dr.Item("nc1"), Boolean) = True Then
            '            If CType(dr.Item("corresponde2"), Boolean) = True Then
            '                xlWorkSheet.Cells(fila, columna) = "✘"
            '                xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila, columna)).Font.Color = Color.Red
            '                If CType(dr.Item("conforme2"), Boolean) = True Then
            '                    xlWorkSheet.Cells(fila, columna + 1) = "✓"
            '                    xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna + 1), xlWorkSheet.Cells(fila, columna + 1)).Font.Color = Color.Green
            '                Else
            '                    xlWorkSheet.Cells(fila, columna + 1) = "✘"
            '                    xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna + 1), xlWorkSheet.Cells(fila, columna + 1)).Font.Color = Color.Red
            '                    If CType(dr.Item("correccion2"), Boolean) = True Then
            '                        xlWorkSheet.Cells(fila, columna + 1) = "✘  ✓"
            '                        xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna + 1), xlWorkSheet.Cells(fila, columna + 1)).Font.Color = Color.Blue
            '                    End If
            '                End If
            '            Else
            '                xlWorkSheet.Cells(fila, columna) = "✓"
            '                xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila, columna + 1)).Font.Color = Color.Green
            '            End If
            '        Else
            '            If CType(dr.Item("conforme2"), Boolean) = True Then
            '                xlWorkSheet.Cells(fila, columna + 1) = "✓"
            '                xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna + 1), xlWorkSheet.Cells(fila, columna + 1)).Font.Color = Color.Green
            '            Else
            '                xlWorkSheet.Cells(fila, columna + 1) = "✘"
            '                xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna + 1), xlWorkSheet.Cells(fila, columna + 1)).Font.Color = Color.Red
            '                If CType(dr.Item("correccion2"), Boolean) = True Then
            '                    xlWorkSheet.Cells(fila, columna + 1) = "✘  ✓"
            '                    xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna + 1), xlWorkSheet.Cells(fila, columna + 1)).Font.Color = Color.Blue
            '                End If
            '            End If
            '        End If
            '    End If
            'End If

            columna = columna + 1
            With xlWorkSheet.Range(xlWorkSheet.Cells(fila, 1), xlWorkSheet.Cells(fila, columna))
                With .Font
                    .Name = "Arial"
                    .Size = 8
                    .Bold = False
                End With
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With

            'El formato del nombre voz
            With xlWorkSheet.Range(xlWorkSheet.Cells(fila, 2), xlWorkSheet.Cells(fila, 2))
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End With

            border = xlWorkSheet.Range(xlWorkSheet.Cells(fila, 1), xlWorkSheet.Cells(fila, 9)).Borders
            border.LineStyle = Excel.XlLineStyle.xlContinuous
            border.Weight = 2.0

            'xlWorkSheet.Range(xlWorkSheet.Cells(fila, 1), xlWorkSheet.Cells(fila, columna)).WrapText = True
            fila = fila + 1

        Next


    End Sub

    Private Sub mostrarNotas()

        Dim border As Excel.Borders

        Dim columna As Integer

        'ENCABEZADO
        columna = 1

        xlWorkSheet.Cells(fila, columna) = "-"
        xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila + 1, columna)).Merge()
        border = xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila + 1, columna)).Borders
        border.LineStyle = Excel.XlLineStyle.xlContinuous
        border.Weight = 3.0
        columna = columna + 1

        xlWorkSheet.Cells(fila, columna) = "NOTAS"
        xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila + 1, columna + 1)).Merge()
        border = xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila + 1, columna + 1)).Borders
        border.LineStyle = Excel.XlLineStyle.xlContinuous
        border.Weight = 3.0
        columna = columna + 2

        xlWorkSheet.Cells(fila, columna) = "PRODUC."
        xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila, columna + 1)).Merge()
        border = xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila, columna + 1)).Borders
        border.LineStyle = Excel.XlLineStyle.xlContinuous
        border.Weight = 3.0

        xlWorkSheet.Cells(fila + 1, columna) = "-"
        border = xlWorkSheet.Range(xlWorkSheet.Cells(fila + 1, columna), xlWorkSheet.Cells(fila + 1, columna)).Borders
        border.LineStyle = Excel.XlLineStyle.xlContinuous
        border.Weight = 3.0

        columna = columna + 1

        xlWorkSheet.Cells(fila + 1, columna) = "-"
        border = xlWorkSheet.Range(xlWorkSheet.Cells(fila + 1, columna), xlWorkSheet.Cells(fila + 1, columna)).Borders
        border.LineStyle = Excel.XlLineStyle.xlContinuous
        border.Weight = 3.0
        columna = columna + 1

        xlWorkSheet.Cells(fila, columna) = "PRIMER CONTROL"
        xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila, columna + 1)).Merge()
        border = xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila, columna + 1)).Borders
        border.LineStyle = Excel.XlLineStyle.xlContinuous
        border.Weight = 3.0

        xlWorkSheet.Cells(fila + 1, columna) = "-"
        border = xlWorkSheet.Range(xlWorkSheet.Cells(fila + 1, columna), xlWorkSheet.Cells(fila + 1, columna)).Borders
        border.LineStyle = Excel.XlLineStyle.xlContinuous
        border.Weight = 3.0

        columna = columna + 1
        xlWorkSheet.Cells(fila + 1, columna) = "CTRL"
        border = xlWorkSheet.Range(xlWorkSheet.Cells(fila + 1, columna), xlWorkSheet.Cells(fila + 1, columna)).Borders
        border.LineStyle = Excel.XlLineStyle.xlContinuous
        border.Weight = 3.0

        columna = columna + 1

        xlWorkSheet.Cells(fila, columna) = "SEGUNDO CONTROL"
        xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila, columna + 1)).Merge()
        border = xlWorkSheet.Range(xlWorkSheet.Cells(fila, columna), xlWorkSheet.Cells(fila, columna + 1)).Borders
        border.LineStyle = Excel.XlLineStyle.xlContinuous
        border.Weight = 3.0


        xlWorkSheet.Cells(fila + 1, columna) = "NC"
        border = xlWorkSheet.Range(xlWorkSheet.Cells(fila + 1, columna), xlWorkSheet.Cells(fila + 1, columna)).Borders
        border.LineStyle = Excel.XlLineStyle.xlContinuous
        border.Weight = 3.0

        columna = columna + 1
        xlWorkSheet.Cells(fila + 1, columna) = "CTRL"
        border = xlWorkSheet.Range(xlWorkSheet.Cells(fila + 1, columna), xlWorkSheet.Cells(fila + 1, columna)).Borders
        border.LineStyle = Excel.XlLineStyle.xlContinuous
        border.Weight = 3.0

        With xlWorkSheet.Range(xlWorkSheet.Cells(fila, 1), xlWorkSheet.Cells(fila + 1, 3))
            With .Font
                .Name = "Verdana"
                .FontStyle = "Bold"
                .Size = 10
            End With
        End With

        With xlWorkSheet.Range(xlWorkSheet.Cells(fila, 4), xlWorkSheet.Cells(fila + 1, columna))
            With .Font
                .Name = "Verdana"
                .FontStyle = "Bold"
                .Size = 5
            End With
        End With

        xlWorkSheet.Range(xlWorkSheet.Cells(fila, 1), xlWorkSheet.Cells(fila + 1, columna)).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        xlWorkSheet.Range(xlWorkSheet.Cells(fila, 1), xlWorkSheet.Cells(fila + 1, columna)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        xlWorkSheet.Range(xlWorkSheet.Cells(fila, 1), xlWorkSheet.Cells(fila + 1, columna)).Interior.Color = Color.LightGray
        xlWorkSheet.Range(xlWorkSheet.Cells(fila, 1), xlWorkSheet.Cells(fila + 1, columna)).WrapText = True

        fila = fila + 2


        'DETALLE
        crearCuerpoMovimientoTipoVoz(0)


    End Sub


End Class
