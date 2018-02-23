Public Class frmConsultaProveedor

    Private Sub frmConsultaProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim odtTemp As New DataTable
        'If Banderabtn = 2 Or Banderabtn = 4 Then
        '    Me.btnImprimir.Enabled = True
        '    Banderabtn = 0
        'Else
        '    Me.btnImprimir.Enabled = False
        '    Banderabtn = 0
        'End If

        Select Case BanderaConsultaGeneral
            Case "saldo_proveedor_todo"
                Me.dgv1.DataSource = odtConsultaGeneral
                Me.dgv1.Columns(0).Visible = False
                Me.dgv1.Columns("SALDO_TOTAL").DefaultCellStyle.Format = "c"
                Me.dgv1.Columns("SALDO_TOTAL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                odtTemp = oConsulta_saldo_proveedor.GetAll_Sum
                If odtTemp.Rows.Count > 0 Then
                    Me.txtTotalConsulta.Text = FormatCurrency(odtTemp.Rows(0).Item("TOTAL"))
                Else
                    Me.txtTotalConsulta.Text = FormatCurrency(0)
                End If

                If CDec(Me.txtTotalConsulta.Text) < 0 Then
                    Me.txtTotalConsulta.ForeColor = Color.Red
                Else
                    Me.txtTotalConsulta.ForeColor = Color.Green
                End If
                Me.lblTitulo.Text = "Saldo total de todos los proveedores"
            Case "factura_vencida_entre_fecha_proveedor"
                Me.dgv1.DataSource = odtConsultaGeneral
                Me.dgv1.Columns(0).Visible = False
                Me.dgv1.Columns("IMPORTE").DefaultCellStyle.Format = "c"
                Me.dgv1.Columns("IMPORTE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Me.dgv1.Columns("SALDO").DefaultCellStyle.Format = "c"
                Me.dgv1.Columns("SALDO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                If odtConsultaGeneralSuma.Rows.Count > 0 Then
                    Try
                        Me.txtTotalConsulta.Text = FormatCurrency(odtConsultaGeneralSuma.Rows(0).Item("IMPORTE"))
                    Catch ex As Exception
                        Me.txtTotalConsulta.Text = "0"
                    End Try
                Else
                    Me.txtTotalConsulta.Text = FormatCurrency(0)
                End If

                If CDec(Me.txtTotalConsulta.Text) < 0 Then
                    Me.txtTotalConsulta.ForeColor = Color.Red
                Else
                    Me.txtTotalConsulta.ForeColor = Color.Green
                End If
                Me.lblTitulo.Text = "Facturas Vencidas Entre Fechas por Proveedor"
                Me.lblDetalle_consulta.Text = strTituloConsultaGeneral
            Case "movimiento_proveedor_entre_fecha"
                Me.dgv1.DataSource = odtConsultaGeneral
                Me.dgv1.Columns(0).Visible = False
                Me.dgv1.Columns("DEBE").DefaultCellStyle.Format = "c"
                Me.dgv1.Columns("DEBE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Me.dgv1.Columns("HABER").DefaultCellStyle.Format = "c"
                Me.dgv1.Columns("HABER").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                ' Me.dgv1.Columns("SALDO").DefaultCellStyle.Format = "c"
                ' Me.dgv1.Columns("SALDO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Me.lblTitulo.Text = "Facturas y Pagos Entre Fechas de Todos los Proveedores"

                If odtConsultaGeneralSuma.Rows.Count > 0 Then
                    Try
                        Me.txtTotalConsulta.Text = FormatCurrency(odtConsultaGeneralSuma.Rows(0).Item("TOTAL"))
                    Catch ex As Exception
                        Me.txtTotalConsulta.Text = "0"
                    End Try
                Else
                    Me.txtTotalConsulta.Text = FormatCurrency(0)
                End If

                If CDec(Me.txtTotalConsulta.Text) < 0 Then
                    Me.txtTotalConsulta.ForeColor = Color.Red
                Else
                    Me.txtTotalConsulta.ForeColor = Color.Green
                End If
            Case "factura_vencida_entre_fecha"
                Me.dgv1.DataSource = odtConsultaGeneral
                Me.dgv1.Columns(0).Visible = False
                Me.dgv1.Columns("SALDO").DefaultCellStyle.Format = "c"
                Me.dgv1.Columns("SALDO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Me.lblTitulo.Text = "Facturas Vencidas Entre Fechas de Todos los Proveedores"
                If odtConsultaGeneralSuma.Rows.Count > 0 Then
                    Try
                        Me.txtTotalConsulta.Text = FormatCurrency(odtConsultaGeneralSuma.Rows(0).Item("TOTAL"))
                    Catch ex As Exception
                        Me.txtTotalConsulta.Text = "0"
                    End Try
                Else
                    Me.txtTotalConsulta.Text = FormatCurrency(0)
                End If

                If CDec(Me.txtTotalConsulta.Text) < 0 Then
                    Me.txtTotalConsulta.ForeColor = Color.Red
                Else
                    Me.txtTotalConsulta.ForeColor = Color.Green
                End If
            Case "movimiento_proveedor_entre_fecha_proveedor"
                Me.dgv1.DataSource = odtConsultaGeneral
                Me.dgv1.Columns(0).Visible = False
                Me.dgv1.Columns("DEBE").DefaultCellStyle.Format = "c"
                Me.dgv1.Columns("DEBE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Me.dgv1.Columns("HABER").DefaultCellStyle.Format = "c"
                Me.dgv1.Columns("HABER").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                ' Me.dgv1.Columns("SALDO").DefaultCellStyle.Format = "c"
                ' Me.dgv1.Columns("SALDO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Me.lblTitulo.Text = "Facturas y Pagos Entre Fechas por Proveedor"
                Me.lblDetalle_consulta.Text = strTituloConsultaGeneral

                If odtConsultaGeneralSuma.Rows.Count > 0 Then
                    Try
                        Me.txtTotalConsulta.Text = FormatCurrency(odtConsultaGeneralSuma.Rows(0).Item("TOTAL"))
                    Catch ex As Exception
                        Me.txtTotalConsulta.Text = "0"
                    End Try
                Else
                    Me.txtTotalConsulta.Text = FormatCurrency(0)
                End If

                If CDec(Me.txtTotalConsulta.Text) < 0 Then
                    Me.txtTotalConsulta.ForeColor = Color.Red
                Else
                    Me.txtTotalConsulta.ForeColor = Color.Green
                End If
            Case "total_gastado_entre_fecha"
                Me.dgv1.DataSource = odtConsultaGeneral
                'Me.dgv1.Columns(0).Visible = False
                Me.dgv1.Columns("IMPORTE").DefaultCellStyle.Format = "c"
                Me.dgv1.Columns("IMPORTE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Me.lblTitulo.Text = "Total Comprado a Todos los Proveedores"
                Me.lblDetalle_consulta.Text = strTituloConsultaGeneral

                If odtConsultaGeneralSuma.Rows.Count > 0 Then
                    Try
                        Me.txtTotalConsulta.Text = FormatCurrency(odtConsultaGeneralSuma.Rows(0).Item("IMPORTE"))
                    Catch ex As Exception
                        Me.txtTotalConsulta.Text = "0"
                    End Try
                Else
                    Me.txtTotalConsulta.Text = FormatCurrency(0)
                End If

                If CDec(Me.txtTotalConsulta.Text) < 0 Then
                    Me.txtTotalConsulta.ForeColor = Color.Red
                Else
                    Me.txtTotalConsulta.ForeColor = Color.Green
                End If
                parametro_total = CDec(Me.txtTotalConsulta.Text)
            Case "saldo_factura_proveedor"
                Me.dgv1.DataSource = odtConsultaGeneral

        End Select


    End Sub


    'coloca el rojo en la celdas negativas
    Private Sub dgv1_CellFormatting(ByVal sender As Object, _
    ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) _
        Handles dgv1.CellFormatting
        If dgv1.Columns(e.ColumnIndex).Name.Equals("SALDO_TOTAL") Or _
        dgv1.Columns(e.ColumnIndex).Name.Equals("SALDO_ANTERIOR") Or _
        dgv1.Columns(e.ColumnIndex).Name.Equals("SALDO_ACTUAL") Then
            'Dim intValue As Int32
            If CInt(e.Value) < 0 Then
                'if Int32.TryParse((String)e.Value, out intValue) && 
                '   (intValue < 0))
                e.CellStyle.ForeColor = Color.Red
                e.CellStyle.SelectionBackColor = Color.White
            End If
        End If
    End Sub




    'Private Sub dgv1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgv1.MouseClick

    '    If e.Button = Windows.Forms.MouseButtons.Right Then
    '        Me.ContextMenuStrip1.Show(Control.MousePosition.X, Control.MousePosition.Y)
    '    End If


    'End Sub




    Sub CalcularTotal(ByVal columna As Integer)
        Dim decTotalSelect As Decimal = 0
        Dim counter As Integer

        For counter = 0 To (dgv1.SelectedCells.Count - 1)
            If dgv1.SelectedCells(counter).FormattedValueType Is _
            Type.GetType("System.String") Then

                Dim value As String = Nothing

                ' If the cell contains a value that has not been commited,
                ' use the modified value.
                If (dgv1.IsCurrentCellDirty = True) Then

                    value = dgv1.SelectedCells(counter) _
                        .EditedFormattedValue.ToString()
                Else

                    value = dgv1.SelectedCells(counter) _
                        .FormattedValue.ToString()
                End If

                If value IsNot Nothing Then

                    ' Ignore cells in the Description column.
                    If dgv1.SelectedCells(counter).ColumnIndex = dgv1.Columns(columna).Index Then
                        If Not value.Length = 0 Then
                            decTotalSelect += CDec(value)
                        End If
                    End If
                End If
            End If
        Next
        Me.ToolStripTextBox1.Text = FormatCurrency(decTotalSelect)
    End Sub

    Sub CalcularImporte()
        Dim decTotal As Decimal = 0
        Dim counter As Integer

        For counter = 0 To (dgv1.Rows.Count - 1)
            If Not dgv1.Rows(counter) _
                .Cells("importe").Value Is Nothing Then

                If Not dgv1.Rows(counter) _
                    .Cells("importe").Value.ToString().Length = 0 Then

                    decTotal += CDec(dgv1.Rows(counter).Cells("importe").Value)
                End If
            End If
        Next
        '  Me.txtTotal.Text = FormatCurrency(decTotal)

    End Sub


    Sub CalcularCuenta()
        Dim decTotalSelect As Decimal = 0
        Dim counter As Integer
        Dim decContador As Integer = 0

        For counter = 0 To (dgv1.SelectedCells.Count - 1)
            If dgv1.SelectedCells(counter).FormattedValueType Is _
            Type.GetType("System.String") Then

                Dim value As String = Nothing

                ' If the cell contains a value that has not been commited,
                ' use the modified value.
                If (dgv1.IsCurrentCellDirty = True) Then

                    value = dgv1.SelectedCells(counter) _
                        .EditedFormattedValue.ToString()
                Else

                    value = dgv1.SelectedCells(counter) _
                        .FormattedValue.ToString()
                End If

                If value IsNot Nothing Then

                    ' Ignore cells in the Description column.
                    'If dgv1.SelectedCells(counter).ColumnIndex = dgv1.Columns("TOTAL").Index Then
                    If Not value.Length = 0 Then
                        'decTotalSelect += value
                        decContador = decContador + 1
                    End If
                    'End If
                End If
            End If
        Next
        Me.ToolStripTextBox2.Text = CStr(decContador)
    End Sub

    Dim columna As Integer

    Private Sub ToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Try
            columna = Me.dgv1.CurrentCell.ColumnIndex

            Me.CalcularTotal(columna)
        Catch ex As Exception
            Me.ToolStripTextBox1.Text = FormatCurrency(0)
        End Try

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Try
            Me.CalcularCuenta()
        Catch ex As Exception
        End Try

    End Sub


    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'Dim FrmImprime As New frmReporte_1
        'FrmImprime.ShowDialog()ç

        Select Case vgBanderaprint
            Case "imprime_saldo_proveedores"
                ' Dim FrmImprime As New
                'parametro_Proveedor=
                parametro_fecha_fin = CType(Me.Owner, frmConsultaProveedorMain).dtpFecha_hasta.Value.Date
                parametro_fecha_inicio = CType(Me.Owner, frmConsultaProveedorMain).dtpFecha_desde.Value.Date
                'FrmImprime.ShowDialog()

            Case "imprime_facturas_Prov"
                'Dim FrmImprime As New 
                parametro_fecha_fin = CType(Me.Owner, frmConsultaProveedorMain).dtpFecha_hasta.Value.Date
                parametro_fecha_inicio = CType(Me.Owner, frmConsultaProveedorMain).dtpFecha_desde.Value.Date
                'parametro_id_proveedor = CInt(CType(Me.Owner, frmConsultaProveedorMain).lblid_proveedor.Text)
                parametro_nom_prov = CType(Me.Owner, frmConsultaProveedorMain).cmbProveedor.Text
                'FrmImprime.ShowDialog()

            Case "imprime_facturas_vencidas"
                'Dim FrmImprime As New frmReporteProveedoresEntreFechas
                parametro_fecha_fin = CType(Me.Owner, frmConsultaProveedorMain).dtpFecha_hasta.Value.Date
                parametro_fecha_inicio = CType(Me.Owner, frmConsultaProveedorMain).dtpFecha_desde.Value.Date
                'FrmImprime.ShowDialog()

            Case "imprime_total_gastado_entre_fecha"
                '      Dim FrmImprime As New frmTotal_gastado_a_proveedores
                parametro_fecha_fin = CType(Me.Owner, frmConsultaProveedorMain).dtpFecha_hasta.Value.Date
                parametro_fecha_inicio = CType(Me.Owner, frmConsultaProveedorMain).dtpFecha_desde.Value.Date
                'parametro_id_proveedor = CInt(CType(Me.Owner, frmConsultaProveedorMain).lblid_proveedor.Text)
                parametro_nom_prov = CType(Me.Owner, frmConsultaProveedorMain).cmbProveedor.Text
                'FrmImprime.ShowDialog()


        End Select


        'boton 4
        'Dim FrmImprime As New frmReporteProveedoresEntreFechas
        'parametro_fecha_fin = CType(Me.Owner, frmConsultaProveedorMain).dtpFecha_hasta.Value.Date
        'parametro_fecha_inicio = CType(Me.Owner, frmConsultaProveedorMain).dtpFecha_desde.Value.Date
        'FrmImprime.ShowDialog()
    End Sub

End Class