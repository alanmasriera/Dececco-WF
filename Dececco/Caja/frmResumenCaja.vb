Imports Microsoft.VisualBasic
Imports System.Globalization

Public Class frmResumenCaja

    Private Sub frmResumenCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cultura regional
        Dim oldDecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        Dim forceDotCulture As CultureInfo
        forceDotCulture = CType(Application.CurrentCulture.Clone(), CultureInfo)
        forceDotCulture.NumberFormat.NumberDecimalSeparator = ","
        forceDotCulture.NumberFormat.NumberGroupSeparator = "."
        forceDotCulture.NumberFormat.CurrencyDecimalSeparator = ","
        forceDotCulture.NumberFormat.CurrencyGroupSeparator = "."
        forceDotCulture.NumberFormat.CurrencyDecimalDigits = 2
        forceDotCulture.NumberFormat.CurrencySymbol = "$"
        Application.CurrentCulture = forceDotCulture

        CargarEmpresa()
        Me.cmbEmpresa.Text = ""

        Me.lblidBanco.Text = "1"
        Me.lblidCuenta.Text = "1"
        Me.cmbEmpresa.Focus()

        'modificacion lubricentro
        Me.lblidEmpresa.Text = "1"
        Me.cmbEmpresa.Text = oEmpresa.GetOne(CInt(Me.lblidEmpresa.Text)).Rows(0).Item("nombre_Empresa").ToString.Trim
        '    Me.Cheques.Enabled = True
        RefrescarGrilla()
        Me.RefrescarResumen()
        Me.ControlarEnabled()

        Dim odt As New DataTable
        odt = oCliente_maestro.GetOne(1)


        'If odt.Rows(0).Item("Nombre permiso").ToString = "colina" Then
        Me.cmbEmpresa.Enabled = True
        'Else
        '    Me.cmbEmpresa.Enabled = False
        'End If

        Me.dtpInicio.Value = Date.Now
        Me.dtpFin.Value = Date.Now


    End Sub


    Dim dt1 As New DataTable("Cheques_Recibidos")
    Dim dt2 As New DataTable("Cheques_Librados")
    Dim dt4 As New DataTable("Creditos")
    Dim dt5 As New DataTable("Debitos")
    Dim dt8 As New DataTable("ResumenCuenta")
    Dim dt11 As New DataTable
    Dim dt22 As New DataTable

    Dim BanderaConsultaMovimiento As Integer
    Dim BanderaConsultaTipo As Integer

    Sub CargarEmpresa()
        Dim odt As New DataTable

        odt = oEmpresa.GetCmb
        With Me.cmbEmpresa
            .DataSource = odt
            .DisplayMember = "nombre_empresa"
            .ValueMember = "id_empresa"
        End With
        If Me.cmbEmpresa.SelectedIndex >= 0 Then
            cmbEmpresa.SelectedIndex = 0
            Me.lblidEmpresa.Text = cmbEmpresa.SelectedValue.ToString
        End If
    End Sub

    Sub RefrescarGrilla()
        Dim odt1 As New DataTable("Cheques_Recibidos")
        Dim odt2 As New DataTable("Cheques_Librados")
        Dim odt4 As New DataTable("Creditos")
        Dim odt5 As New DataTable("Debitos")
        Dim odt8 As New DataTable("Resumen_Cuenta_2")

        Dim odt11 As New DataTable
        Dim odt22 As New DataTable

        If Me.lblidEmpresa.Text = "" Or Me.lblidBanco.Text = "" Or Me.lblidCuenta.Text = "" Then
            Exit Sub
        End If

        Me.lblSaldoActual.Text = ""
        Me.txtSaldoContable.Text = ""

        dt1 = oCheque_recibido.Cargar
        dt2 = oCheque_librado.Cargar
        dt11 = oCheque_recibido.Cargar
        dt22 = oCheque_librado.Cargar
        dt4 = oIngreso_efectivo.Cargar
        dt5 = oEgreso_efectivo.Cargar

        odt1 = oCheque_recibido.Consultar(CInt(Me.lblidEmpresa.Text), Me.dtpPeriodo.Value.Date)
        parametro_banco = CInt(Me.lblidBanco.Text)
        parametro_empresa = CInt(Me.lblidEmpresa.Text)
        parametro_cuenta = CInt(Me.lblidCuenta.Text)
        parametro_id_banco = CInt(Me.lblidBanco.Text.Trim)
        parametro_id_cuenta = CInt(Me.lblidCuenta.Text.Trim)
        parametro_fecha = Me.dtpPeriodo.Value.Date


        odt11 = oCheque_recibido.Consultar2(CInt(Me.lblidEmpresa.Text), Me.dtpPeriodo.Value.Date)

        odt2 = oCheque_librado.Consultar(CInt(Me.lblidEmpresa.Text), Me.dtpPeriodo.Value.Date)
        parametro_banco = CInt(Me.lblidBanco.Text)
        parametro_empresa = CInt(Me.lblidEmpresa.Text)
        parametro_cuenta = CInt(Me.lblidCuenta.Text)
        parametro_id_banco = CInt(Me.lblidBanco.Text.Trim)
        parametro_id_cuenta = CInt(Me.lblidCuenta.Text.Trim)

        parametro_fecha = Me.dtpPeriodo.Value.Date


        odt22 = oCheque_librado.Consultar2(CInt(Me.lblidEmpresa.Text), Me.dtpPeriodo.Value.Date)

        odt4 = oIngreso_efectivo.Consultar(CInt(Me.lblidEmpresa.Text), Me.dtpPeriodo.Value.Date)
        parametro_banco = CInt(Me.lblidBanco.Text)
        parametro_empresa = CInt(Me.lblidEmpresa.Text)
        parametro_cuenta = CInt(Me.lblidCuenta.Text)
        parametro_id_banco = CInt(Me.lblidBanco.Text.Trim)
        parametro_id_cuenta = CInt(Me.lblidCuenta.Text.Trim)
        parametro_fecha = Me.dtpPeriodo.Value.Date



        odt5 = oEgreso_efectivo.Consultar(CInt(Me.lblidEmpresa.Text), Me.dtpPeriodo.Value.Date)
        odt8 = oResumen_cuenta_caja.ConsultarResumen(CInt(Me.lblidEmpresa.Text), Me.dtpPeriodo.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text))

        Me.lblSaldoAnterior.Text = FormatCurrency(oResumen_cuenta_caja.TraerSaldoAnteriorBanco(CInt(Me.lblidEmpresa.Text), Me.dtpPeriodo.Value.Date, CInt(Me.lblidCuenta.Text)))

        'cheque recibido
        Me.dgvChequeRecibido.DataSource = odt1
        Me.dgvChequeRecibido.Columns(0).Visible = False
        Me.dgvChequeRecibido.Columns("IMPORTE").DefaultCellStyle.Format = "c"
        Me.dgvChequeRecibido.Columns("IMPORTE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        ''cheque librado
        'Me.dgvChequeLibrado.DataSource = odt2
        'Me.dgvChequeLibrado.Columns(0).Visible = False
        'Me.dgvChequeLibrado.Columns("IMPORTE").DefaultCellStyle.Format = "c"
        'Me.dgvChequeLibrado.Columns("IMPORTE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        'credito
        Me.dgvIngreso.DataSource = odt4
        Me.dgvIngreso.Columns(0).Visible = False
        Me.dgvIngreso.Columns("IMPORTE").DefaultCellStyle.Format = "c"
        Me.dgvIngreso.Columns("IMPORTE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        'debito
        Me.DataGridView5.DataSource = odt5
        Me.DataGridView5.Columns(0).Visible = False
        Me.DataGridView5.Columns("IMPORTE").DefaultCellStyle.Format = "c"
        Me.DataGridView5.Columns("IMPORTE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        'resumen de cuenta
        Me.DataGridView8.DataSource = odt8
        Me.DataGridView8.Columns(0).Visible = False
        Me.DataGridView8.Columns("IMPORTE_DEBE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView8.Columns("IMPORTE_HABER").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView8.Columns("SALDO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView8.Columns("IMPORTE_DEBE").DefaultCellStyle.Format = "c"
        Me.DataGridView8.Columns("IMPORTE_HABER").DefaultCellStyle.Format = "c"
        Me.DataGridView8.Columns("SALDO").DefaultCellStyle.Format = "c"

        'cheque recibido
        Me.dgvChequeCobro.DataSource = odt11
        Me.dgvChequeCobro.Columns(0).Visible = False
        Me.dgvChequeCobro.Columns("IMPORTE").DefaultCellStyle.Format = "c"
        Me.dgvChequeCobro.Columns("IMPORTE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        ''cheque librado
        'Me.dgvChequePago.DataSource = odt22
        'Me.dgvChequePago.Columns(0).Visible = False
        'Me.dgvChequePago.Columns("IMPORTE").DefaultCellStyle.Format = "c"
        'Me.dgvChequePago.Columns("IMPORTE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        '   RefrescarId()
    End Sub

    Sub ControlarEnabled()
        If Me.lblidEmpresa.Text = "" Or Me.lblidBanco.Text = "" Or Me.lblidCuenta.Text = "" Then
            Exit Sub
        End If
        If oSaldo_caja.ControlarSaldo(CInt(Me.lblidEmpresa.Text), Me.dtpPeriodo.Value.Date, CInt(Me.lblidCuenta.Text)) Then
            Me.btnGenerarResumen.Enabled = True
            Me.btnCierrePeriodo.Enabled = True
            Me.btnModificarPeriodo.Enabled = False
            Me.btnAgregar.Enabled = True
            Me.btnModificar.Enabled = True
            Me.btnBorrar.Enabled = True
        Else
            Me.btnGenerarResumen.Enabled = False
            Me.btnCierrePeriodo.Enabled = False
            Me.btnModificarPeriodo.Enabled = True
            Me.btnAgregar.Enabled = False
            Me.btnModificar.Enabled = False
            Me.btnBorrar.Enabled = False
        End If


        'modificacion lubricentro
        If IsNumeric(Me.lblidEmpresa.Text) And IsNumeric(Me.lblidCuenta.Text) And IsNumeric(Me.lblidBanco.Text) Then
            Me.TCCaja.Enabled = True
        End If
    End Sub

    Private Sub Cheques_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TCCaja.SelectedIndexChanged
        'modificacion lubricentro
        If Not IsNumeric(Me.lblidEmpresa.Text) Or Not IsNumeric(Me.lblidCuenta.Text) Or Not IsNumeric(Me.lblidBanco.Text) Then
            Exit Sub
        End If

        Select Case Me.TCCaja.SelectedIndex
            Case 7
                Me.Btnimprime.Enabled = True
                Me.lblSaldoAnterior.Text = CStr(oResumen_cuenta_caja.TraerSaldoAnteriorBanco(CInt(Me.lblidEmpresa.Text), Me.dtpPeriodo.Value.Date, CInt(Me.lblidCuenta.Text)))
            Case Else
                'Me.Btnimprime.Enabled = False
        End Select
    End Sub

    Private Sub cmbEmpresa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbEmpresa.KeyDown
        If e.KeyValue = 13 Then
            Me.dtpPeriodo.Focus()
        End If
    End Sub

    Private Sub cmbEmpresa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEmpresa.SelectedIndexChanged
        Try
            If Me.cmbEmpresa.SelectedIndex >= 0 Then
                If Me.cmbEmpresa.SelectedValue.ToString = "System.Data.DataRowView" Then
                    Exit Sub
                End If
                Me.lblidEmpresa.Text = cmbEmpresa.SelectedValue.ToString
                Me.TCCaja.Enabled = True
                RefrescarGrilla()
                Me.ControlarEnabled()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvChequeRecibido_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvChequeRecibido.CellDoubleClick
        Try
            'pongo el id para hacer los cambios
            Me.lblidChequeRecibido.Text = CStr(Me.dgvChequeRecibido.Item(0, Me.dgvChequeRecibido.CurrentRow.Index).Value)

            If dgvChequeRecibido.Columns(e.ColumnIndex).Index = 1 Then
                If CDbl(Me.dgvChequeRecibido.Item(1, Me.dgvChequeRecibido.CurrentRow.Index).Value) = 0 Then
                    oCheque_recibido.Update_Check(CInt(Me.lblidChequeRecibido.Text), True)
                Else
                    oCheque_recibido.Update_Check(CInt(Me.lblidChequeRecibido.Text), False)
                End If
                Me.RefrescarGrilla()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvChequeRecibido_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvChequeRecibido.CurrentCellChanged
        Try
            Me.lblidChequeRecibido.Text = CStr(Me.dgvChequeRecibido.Item(0, Me.dgvChequeRecibido.CurrentRow.Index).Value)
        Catch ex As Exception

        End Try
    End Sub

    'Private Sub dgvChequeLibrado_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    '    Try
    '        'pongo el id para hacer el cambio
    '        Me.lblidChequeLibrado.Text = CStr(Me.dgvChequeLibrado.Item(0, Me.dgvChequeLibrado.CurrentRow.Index).Value)

    '        If dgvChequeLibrado.Columns(e.ColumnIndex).Index = 1 Then
    '            If CDbl(Me.dgvChequeLibrado.Item(1, Me.dgvChequeLibrado.CurrentRow.Index).Value) = 0 Then
    '                oCheque_librado.Update_Check(CInt(Me.lblidChequeLibrado.Text), True)
    '            Else
    '                oCheque_librado.Update_Check(CInt(Me.lblidChequeLibrado.Text), False)
    '            End If
    '            Me.RefrescarGrilla()
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    'Private Sub dgvChequeLibrado_CurrentCellChanged1(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Try
    '        Me.lblidChequeLibrado.Text = CStr(Me.dgvChequeLibrado.Item(0, Me.dgvChequeLibrado.CurrentRow.Index).Value)
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub dgvIngreso_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvIngreso.CellDoubleClick
        Try
            If dgvIngreso.Columns(e.ColumnIndex).Index = 1 Then
                If CDbl(Me.dgvIngreso.Item(1, Me.dgvIngreso.CurrentRow.Index).Value) = 0 Then
                    oIngreso_efectivo.Update_Check(CInt(Me.lblidCredito.Text), True)
                Else
                    oIngreso_efectivo.Update_Check(CInt(Me.lblidCredito.Text), False)
                End If
                Me.RefrescarGrilla()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvIngreso_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvIngreso.CurrentCellChanged
        Try
            Me.lblidCredito.Text = CStr(Me.dgvIngreso.Item(0, Me.dgvIngreso.CurrentRow.Index).Value)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView5_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView5.CellDoubleClick
        Try
            If DataGridView5.Columns(e.ColumnIndex).Index = 1 Then
                If CDbl(Me.DataGridView5.Item(1, Me.DataGridView5.CurrentRow.Index).Value) = 0 Then
                    oEgreso_efectivo.Update_Check(CInt(Me.lblidDebito.Text), True)
                Else
                    oEgreso_efectivo.Update_Check(CInt(Me.lblidDebito.Text), False)
                End If
                Me.RefrescarGrilla()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView5_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView5.CurrentCellChanged
        Try
            Me.lblidDebito.Text = CStr(Me.DataGridView5.Item(0, Me.DataGridView5.CurrentRow.Index).Value)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtpPeriodo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpPeriodo.KeyPress
        If e.KeyChar.ToString = vbCr Then
            If Me.lblidEmpresa.Text = "" Then
                Exit Sub
            End If
            Me.TCCaja.Focus()
            Me.RefrescarGrilla()

        Else
            '    e.Handled = True
        End If
    End Sub

    Private Sub dtpPeriodo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpPeriodo.ValueChanged
        If Me.lblidEmpresa.Text = "" Then
            Exit Sub
        End If
        RefrescarGrilla()
        Me.RefrescarResumen()
        Me.ControlarEnabled()
    End Sub

    Sub RefrescarResumen()
        Dim odt8 As New DataTable("ResumenCuenta")
        Dim i As Integer
        Dim s As Decimal
        Dim j As Integer
        Try
            Me.lblSaldoActual.Text = ""
            oResumen_cuenta_caja.GenerarResumen(CInt(Me.lblidEmpresa.Text), Me.dtpPeriodo.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text))
            oResumen_cuenta_caja.GenerarResumenTotal(CInt(Me.lblidEmpresa.Text), Me.dtpPeriodo.Value.Date, CInt(Me.lblidCuenta.Text), CInt(Me.lblidBanco.Text))
            odt8 = oResumen_cuenta_caja.ConsultarResumen(CInt(Me.lblidEmpresa.Text), Me.dtpPeriodo.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text))

            '  Me.lblSaldoActual.Text = ""

            j = odt8.Rows.Count - 1
            For i = 0 To odt8.Rows.Count - 1
                s = CDec(odt8.Rows(i).Item("saldo").ToString)
                If i = 0 Then
                    s = CDec(s) + CDec(Me.lblSaldoAnterior.Text)
                Else
                    s = s + CDec(odt8.Rows(i - 1).Item("saldo").ToString)
                End If
                odt8.Rows(i).Item("saldo") = s
            Next
            If j < 0 Then

                'bug de los saldos
                Me.lblTotalGrilla.Text = Me.lblSaldoAnterior.Text

                Exit Sub
            End If
            '  Me.lblSaldoActual.Text = odt8.Rows(j).Item("saldo").ToString
            oResumen_cuenta_caja.Update()
            oResumen_cuenta_caja.Guardar()
            Me.DataGridView8.DataSource = odt8
            Me.DataGridView8.Columns(0).Visible = False

            'agrega el saldo al total de la grilla
            Me.lblTotalGrilla.Text = CStr(s)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnGenerarResumen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarResumen.Click
        Me.RefrescarResumen()
    End Sub

    'coloca el rojo en la celdas negativas
    Private Sub GrillaCheque_CellFormatting(ByVal sender As Object, _
    ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) _
        Handles dgvChequeCobro.CellFormatting

        Try
            If dgvChequeCobro.Columns(e.ColumnIndex).Name.Equals("pago_tercero") = True Then
                'Dim intValue As Int32
                If CBool(e.Value) = True Then
                    'if Int32.TryParse((String)e.Value, out intValue) && 
                    '   (intValue < 0))
                    dgvChequeCobro.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red
                    'e.CellStyle.ForeColor = Color.Red
                    'e.CellStyle.SelectionBackColor = Color.DarkRed
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    'coloca el rojo en la celdas negativas
    Private Sub GrillaCheque_2_CellFormatting(ByVal sender As Object, _
    ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) _
        Handles dgvChequeRecibido.CellFormatting

        Try
            If dgvChequeRecibido.Columns(e.ColumnIndex).Name.Equals("pago_tercero") = True Then
                'Dim intValue As Int32
                If CBool(e.Value) = True Then
                    'if Int32.TryParse((String)e.Value, out intValue) && 
                    '   (intValue < 0))
                    dgvChequeRecibido.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red
                    'e.CellStyle.ForeColor = Color.Red
                    'e.CellStyle.SelectionBackColor = Color.DarkRed
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    'coloca el rojo en la celdas negativas
    Private Sub dataGridView8_CellFormatting(ByVal sender As Object, _
    ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) _
        Handles DataGridView8.CellFormatting
        If DataGridView8.Columns(e.ColumnIndex).Name.Equals("SALDO") Then
            'Dim intValue As Int32
            If CInt(e.Value) < 0 Then
                'if Int32.TryParse((String)e.Value, out intValue) && 
                '   (intValue < 0))
                e.CellStyle.ForeColor = Color.Red
                e.CellStyle.SelectionBackColor = Color.DarkRed
            End If
        End If
    End Sub


    Private Sub btnCierrePeriodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCierrePeriodo.Click
        Me.RefrescarResumen()

        If oSaldo_caja.ControlarSaldo(CInt(Me.lblidEmpresa.Text), Me.dtpPeriodo.Value, CInt(Me.lblidCuenta.Text)) Then
            If MessageBox.Show("Desea Realmente Cerrar el Periodo", "Cierre del Periodo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            Else
                oSaldo_caja.Cargar()
                oSaldo_caja.Insertar()
                oSaldo_caja.id_empresa = CInt(Me.lblidEmpresa.Text)
                oSaldo_caja.id_cuenta = CInt(Me.lblidCuenta.Text)
                oSaldo_caja.fecha_saldo = Me.dtpPeriodo.Value
                oSaldo_caja.saldo = CDec(Me.lblTotalGrilla.Text)
                oSaldo_caja.Guardar()
                Me.ControlarEnabled()
            End If
        Else
            If MessageBox.Show("El Periodo ya Esta Cerrado Desea Modificarlo", "Cierre del Periodo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            Else
                oSaldo_caja.Cargar()
                oSaldo_caja.Modificar(oSaldo_caja.ConsultarSaldoActual(CInt(Me.lblidEmpresa.Text), Me.dtpPeriodo.Value, CInt(Me.lblidCuenta.Text)))
                '  Me.CalcularDeclaracion()
                oSaldo_caja.id_empresa = CInt(Me.lblidEmpresa.Text)
                oSaldo_caja.id_cuenta = CInt(Me.lblidCuenta.Text)
                oSaldo_caja.fecha_saldo = Me.dtpPeriodo.Value
                oSaldo_caja.saldo = CDec(Me.lblTotalGrilla.Text)
                oSaldo_caja.Guardar()
                Me.ControlarEnabled()
            End If
        End If
        ' Me.EstadoCierre()
    End Sub


    Private Sub btnModificarPeriodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarPeriodo.Click
        If oSaldo_caja.ControlarSaldo(CInt(Me.lblidEmpresa.Text), Me.dtpPeriodo.Value.Date, CInt(Me.lblidCuenta.Text)) Then
            Me.btnGenerarResumen.Enabled = False
            Me.btnCierrePeriodo.Enabled = False
            Me.btnModificarPeriodo.Enabled = True
            Me.btnAgregar.Enabled = False
            Me.btnModificar.Enabled = False
            Me.btnBorrar.Enabled = False
        Else
            Me.btnGenerarResumen.Enabled = True
            Me.btnCierrePeriodo.Enabled = True
            Me.btnModificarPeriodo.Enabled = False
            Me.btnAgregar.Enabled = True
            Me.btnModificar.Enabled = True
            Me.btnBorrar.Enabled = True
        End If
    End Sub



    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim frmDetalle1 As New frmDetalleCheque_recibido
        Dim frmDetalle2 As New frmDetalleCheque_librado
        Dim frmDetalle4 As New frmDetalleIngreso_efectivo
        Dim frmDetalle5 As New frmDetalleEgreso_efectivo
        Dim frmDetalle6 As New frmConsultaCaja

        If Me.lblidEmpresa.Text = "" Then
            Exit Sub
        End If
        Try
            Select Case Me.TCCaja.SelectedTab.Name
                Case "cheque_recibido"
                    BanderaCheque_recibido = 1
                    Me.AddOwnedForm(frmDetalle1)
                    oCheque_recibido.Insertar()
                    frmDetalle1.CargarCombos()
                    frmDetalle1.ShowDialog()
                Case "cheque_librado"
                    BanderaCheque_librado = 1
                    Me.AddOwnedForm(frmDetalle2)
                    oCheque_librado.Insertar()
                    frmDetalle2.CargarCombos()
                    frmDetalle2.ShowDialog()
                Case "Ingreso"
                    BanderaIngreso_efectivo = 1
                    Me.AddOwnedForm(frmDetalle4)
                    vgFormularioPadre = Me.Name
                    oIngreso_efectivo.Insertar()
                    frmDetalle4.CargarCombos()
                    frmDetalle4.ShowDialog()
                Case "Egreso"
                    BanderaEgreso_efectivo = 1
                    Me.AddOwnedForm(frmDetalle5)
                    oEgreso_efectivo.Insertar()
                    frmDetalle5.CargarCombos()
                    frmDetalle5.ShowDialog()
                Case "Consulta"

            End Select
            Me.TCCaja.Focus()
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        If Me.lblidEmpresa.Text = "" Then
            Exit Sub
        End If

        If MessageBox.Show("Desea Realmente Eliminar el Registro ", "BORRAR", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
        = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Select Case Me.TCCaja.SelectedTab.Name
            Case "cheque_recibido"
                If Not IsNumeric(Me.lblidChequeRecibido.Text) Then
                    Exit Sub
                End If
                oCheque_recibido.Borrar(CInt(Me.lblidChequeRecibido.Text))

            Case "cheque_librado"
                If Not IsNumeric(Me.lblidChequeLibrado.Text) Then
                    Exit Sub
                End If
                oCheque_librado.Borrar(CInt(Me.lblidChequeLibrado.Text))

            Case "Ingreso"
                If Not IsNumeric(Me.lblidCredito.Text) Then
                    Exit Sub
                End If
                oIngreso_efectivo.Borrar(CInt(Me.lblidCredito.Text))

            Case "Egreso"
                If Not IsNumeric(Me.lblidDebito.Text) Then
                    Exit Sub
                End If
                oEgreso_efectivo.Borrar(CInt(Me.lblidDebito.Text))

        End Select

        RefrescarGrilla()
        Me.TCCaja.Focus()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim frmDetalle1 As New frmDetalleCheque_recibido
        Dim frmDetalle2 As New frmDetalleCheque_librado
        Dim frmDetalle4 As New frmDetalleIngreso_efectivo
        Dim frmDetalle5 As New frmDetalleEgreso_efectivo

        If Me.lblidEmpresa.Text = "" Then
            Exit Sub
        End If

        Try
            Select Case Me.TCCaja.SelectedTab.Name
                Case "cheque_recibido"
                    If Not IsNumeric(Me.lblidChequeRecibido.Text) Then
                        Exit Sub
                    End If
                    BanderaCheque_recibido = 2
                    Me.AddOwnedForm(frmDetalle1)
                    oCheque_recibido.Modificar(CInt(Me.lblidChequeRecibido.Text))
                    frmDetalle1.CargarCombos()
                    frmDetalle1.ShowDialog()

                Case "cheque_librado"
                    If Not IsNumeric(Me.lblidChequeLibrado.Text) Then
                        Exit Sub
                    End If
                    BanderaCheque_librado = 2
                    Me.AddOwnedForm(frmDetalle2)
                    oCheque_librado.Modificar(CInt(Me.lblidChequeLibrado.Text))
                    frmDetalle2.CargarCombos()
                    frmDetalle2.ShowDialog()

                Case "Ingreso"
                    If Not IsNumeric(Me.lblidCredito.Text) Then
                        Exit Sub
                    End If
                    BanderaIngreso_efectivo = 2
                    Me.AddOwnedForm(frmDetalle4)
                    oIngreso_efectivo.Modificar(CInt(Me.lblidCredito.Text))
                    frmDetalle4.CargarCombos()
                    frmDetalle4.ShowDialog()

                Case "Egreso"
                    If Not IsNumeric(Me.lblidDebito.Text) Then
                        Exit Sub
                    End If
                    BanderaEgreso_efectivo = 2
                    Me.AddOwnedForm(frmDetalle5)
                    oEgreso_efectivo.Modificar(CInt(Me.lblidDebito.Text))
                    frmDetalle5.CargarCombos()
                    frmDetalle5.ShowDialog()

            End Select
            Me.TCCaja.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        RefrescarGrilla()
        Me.TCCaja.Focus()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
        ' Me.Dispose()
    End Sub


    Private Sub btnBuscaEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaEmpresa.Click
        Dim frmTemp As New frmAbmEmpresa
        frmTemp.ShowDialog()
        Me.CargarEmpresa()
        Me.cmbEmpresa.Focus()
        Me.cmbEmpresa.Text = ""
        Me.lblidEmpresa.Text = "0"
    End Sub


    Private Sub btnSaldoActual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaldoActual.Click
        'traigo los valores del ultimo saldo
        Dim odtSaldoTemp As DataTable
        odtSaldoTemp = oSaldo_caja.GetMaxSaldo(CInt(Me.lblidCuenta.Text))

        Dim FechaMax As DateTime = #1/1/2000# 'fecha del ultimo saldo
        Dim decSaldoOld As Decimal = 0 'ultimo saldo

        If odtSaldoTemp.Rows.Count > 0 Then
            'obtengo la fecha mayor
            FechaMax = CDate(odtSaldoTemp.Rows(0).Item("fecha_saldo"))

            'obtengo el ultimo saldo
            decSaldoOld = CDec(odtSaldoTemp.Rows(0).Item("saldo"))
        Else
        End If

        'seteo la fecha con 01-mm-yy
        'FechaMax = "01-" & FechaMax.Month + 1 & "-" & FechaMax.Year


        'seteo la fecha con 01-mm-yy para calcular a partir del ultimo saldo guardado
        If FechaMax.Month = 12 Then
            FechaMax = CDate("01-01-" & FechaMax.Year + 1)
        Else
            FechaMax = CDate("01-" & FechaMax.Month + 1 & "-" & FechaMax.Year)
        End If

        'calculo el resumen
        oResumen_caja_temporal.GetResumen(CInt(Me.lblidEmpresa.Text), FechaMax, CInt(Me.lblidCuenta.Text), CInt(Me.lblidBanco.Text))

        'calculo el saldo actual
        Dim decSaldo As Decimal = 0
        decSaldo = oResumen_caja_temporal.GetSum + decSaldoOld

        Me.lblSaldoActual.Text = FormatCurrency(decSaldo)



        '*** cálculo del saldo contable ***

        oResumen_caja_temporal.GetResumenContable(CInt(Me.lblidEmpresa.Text), FechaMax, CInt(Me.lblidCuenta.Text), CInt(Me.lblidBanco.Text))

        Dim decSaldoContable As Decimal = 0
        decSaldoContable = oResumen_caja_temporal.GetSum + decSaldoOld

        Me.txtSaldoContable.Text = FormatCurrency(decSaldoContable)

    End Sub


    Private Sub Btnimprime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnimprime.Click
        '  Dim frmimpresiontemporal As New FrmReporteFactura
        Dim odt As New DataTable
        If Me.lblidBanco.Text = "0" Or Me.lblidCuenta.Text = "0" Or Me.lblidEmpresa.Text = "0" Then
            Exit Sub
        End If
        If Not IsNumeric(Me.lblidBanco.Text) Or Not IsNumeric(Me.lblidCuenta.Text) Or Not IsNumeric(Me.lblidEmpresa.Text) Then
            Exit Sub
        End If

        Try
            Select Case Me.TCCaja.SelectedTab.Name
                'Case "librados"
                '   Banderaprintpantalla = "cheques_librados_pantalla"
                'Case "recibidos"
                '   Banderaprintpantalla = "cheques_recibidos_pantalla"
                'Case "Transferencia"
                '   Banderaprintpantalla = "Transferencias_pantalla"

                'Case "DepEfect"
                '   Banderaprintpantalla = "Depositos_pantalla"

                Case "Resumen"
                    Dim FrmImprime As New frmReporteCaja_3

                    'If bandera_imprime_cliente = 0 Then
                    '   vgBanderaprint = "imprime_resumen_cliente"
                    'ElseIf bandera_imprime_cliente = 2 Then
                    '   vgBanderaprint = "imprime_facturas_cliente"
                    'ElseIf bandera_imprime_cliente = 4 Then

                    vgBanderaprint = "imprime_resumen_caja"
                    parametro_empresa = CInt(Me.lblidEmpresa.Text)
                    parametro_fecha_inicio = Me.dtpPeriodo.Value.Date
                    parametro_cuenta = CInt(Me.lblidCuenta.Text)
                    parametro_banco = CInt(Me.lblidBanco.Text)
                    parametro_periodo = Me.dtpPeriodo.Value.Date
                    parametro_sdo_ant = Me.lblSaldoAnterior.Text

                    FrmImprime.ShowDialog()

            End Select
            '   frmimpresiontemporal.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub Traer_datos()
        Me.Cargarbancos()
    End Sub


    Sub Cargarbancos()
        'Dim odt As New DataTable

        'odt = oBanco.get_banco(Me.lblidBanco.Text)
        parametro_nombre_banco = Me.lblidBanco.Text 'odt.Rows(0).Item("nombre_banco").ToString

    End Sub

    Private Sub dgvChequeCobro_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvChequeCobro.CurrentCellChanged
        Try
            Me.lblidChequeRecibido.Text = CStr(Me.dgvChequeCobro.Item(0, Me.dgvChequeCobro.CurrentRow.Index).Value)
        Catch ex As Exception

        End Try
    End Sub

    'Private Sub dgvChequePago_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    '    Try
    '        'pongo el id para hacer el cambio
    '        Me.lblidChequeLibrado.Text = CStr(Me.dgvChequePago.Item(0, Me.dgvChequePago.CurrentRow.Index).Value)

    '        If dgvChequePago.Columns(e.ColumnIndex).Index = 1 Then
    '            If CDbl(Me.dgvChequePago.Item(1, Me.dgvChequePago.CurrentRow.Index).Value) = 0 Then
    '                oCheque_librado.Update_Check(CInt(Me.lblidChequeLibrado.Text), True)
    '            Else
    '                oCheque_librado.Update_Check(CInt(Me.lblidChequeLibrado.Text), False)
    '            End If
    '            Me.RefrescarGrilla()
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    'Private Sub dgvChequePago_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Try
    '        Me.lblidChequeLibrado.Text = CStr(Me.dgvChequePago.Item(0, Me.dgvChequePago.CurrentRow.Index).Value)
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub dgvChequeCobro_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvChequeCobro.CellContentClick
        Try
            'pongo el id para hacer los cambios
            Me.lblidChequeRecibido.Text = CStr(Me.dgvChequeCobro.Item(0, Me.dgvChequeCobro.CurrentRow.Index).Value)

            If dgvChequeCobro.Columns(e.ColumnIndex).Index = 1 Then
                If CDbl(Me.dgvChequeCobro.Item(1, Me.dgvChequeCobro.CurrentRow.Index).Value) = 0 Then
                    oCheque_recibido.Update_Check(CInt(Me.lblidChequeRecibido.Text), True)
                Else
                    oCheque_recibido.Update_Check(CInt(Me.lblidChequeRecibido.Text), False)
                End If
                Me.RefrescarGrilla()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnConsultas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnConsulta_1.Click, btnConsulta_2.Click, btnConsulta_3.Click
        Dim btnTemp As New Button

        btnTemp = CType(sender, Button)

        parametro_fecha_inicio = Me.dtpInicio.Value.Date
        parametro_fecha_fin = Me.dtpFin.Value.Date

        Select Case btnTemp.Name
            Case "btnConsulta_1"
                Dim frmTemp As New frmReporteEgresoEntreFecha
                frmTemp.ShowDialog()

            Case "btnConsulta_2"
                Dim frmTemp As New frmReporteIngresoEntreFecha
                frmTemp.ShowDialog()

            Case "btnConsulta_3"
                Dim frmTemp As New frmReporteEgresoEntreFechaYTipoEgreso
                frmTemp.ShowDialog()
        End Select

    End Sub


End Class