Imports System.Globalization

Public Class frmResumenCliente
    Dim odt As DataTable
    Dim BanderaConsultaCompra As Integer

    Private Sub frmAbmGestion_empleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Me.ttModificar.SetToolTip(Me.btnModificar, "Modificar  un Compra Existente")

        'cultura regional
        Dim oldDecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        Dim forceDotCulture As CultureInfo
        forceDotCulture = CType(Application.CurrentCulture.Clone(), CultureInfo)
        forceDotCulture.NumberFormat.NumberDecimalSeparator = ","
        forceDotCulture.NumberFormat.NumberGroupSeparator = "."
        forceDotCulture.NumberFormat.CurrencyDecimalSeparator = ","
        forceDotCulture.NumberFormat.CurrencyGroupSeparator = "."
        forceDotCulture.NumberFormat.CurrencySymbol = "$"
        Application.CurrentCulture = forceDotCulture

        oPago_cliente.Cargar()
        oFactura.Cargar()
        oSaldo_cliente.Cargar()
        oPresupuesto.Cargar()
        oOrden_compra.Cargar()
        oRemito.Cargar()
        oCliente.Cargar()

        Me.CargarCombos()

        'Me.lblTitulo.Text = "Gestión de Empleados"
        Me.Text = "Gestión de clientees" & vgNombreFormulario

        'agregado para tpclientes


        RefrescarGrilla()
        '''''
    End Sub

    Sub CargarCombos()
        Me.Cargarcliente()
    End Sub

    Sub Cargarcliente()
        Dim odt As New DataTable

        odt = oCliente.GetCmb_2
        With Me.cmbcliente
            .DataSource = odt
            .DisplayMember = "nombre_cliente"
            .ValueMember = "id_cliente"
        End With
        If Me.cmbCliente.SelectedIndex >= 0 Then
            cmbCliente.SelectedIndex = 0
            Me.lblid_cliente.Text = cmbCliente.SelectedValue.ToString
        End If
    End Sub




    Public Sub RefrescarResumen()
        Dim odtResumen As New DataTable()
        Dim i As Integer
        Dim s As Decimal
        Dim j As Integer
        Dim FechaOld As DateTime
        Try
            Me.lblSaldoActual.Text = ""
            Me.lblFacturacion_mes.Text = "$ 0"
            bandera_imprime_cliente = 0
            btnImprimir.Enabled = True

            'seteo la fecha anterior y traigo el saldo anterior
            FechaOld = DateAdd(DateInterval.Month, -1, Me.dtpPeriodo.Value)
            'parametro_fecha_old = FechaOld
            Me.lblSaldoAnterior.Text = CStr(oSaldo_cliente.GetOldSaldo(CInt(Me.lblid_cliente.Text), FechaOld)) ' FormatCurrency(oSaldo_cliente.GetOldSaldo(CInt(Me.lblid_cliente.Text), FechaOld))

            'genera el resumen de cuenta
            odtResumen = oResumen_cliente.SetResumen(CInt(Me.lblid_cliente.Text), Me.dtpPeriodo.Value.Date)

            parametro_periodo = CDate(Me.dtpPeriodo.Text)
            parametro_fecha_inicio = Me.dtpPeriodo.Value.Date
            parametro_cliente_prn = CInt(Me.lblid_cliente.Text)
            parametro_nom_cliente = Me.cmbCliente.Text
            parametro_saldo_anterior = CDec(Me.lblSaldoAnterior.Text)

            'calcula el saldo parcial atraves de la grilla
            j = odtResumen.Rows.Count - 1
            For i = 0 To odtResumen.Rows.Count - 1
                s = CDec(odtResumen.Rows(i).Item("saldo").ToString)
                If i = 0 Then
                    s = CDec(s) + CDec(Me.lblSaldoAnterior.Text)
                Else
                    s = s + CDec(odtResumen.Rows(i - 1).Item("saldo").ToString)
                End If
                odtResumen.Rows(i).Item("saldo") = s
            Next
            If j < 0 Then
                Me.dgv1.DataSource = odtResumen
                Me.dgv1.Columns(0).Visible = False

                'bug de los saldos
                Me.lblTotalGrilla.Text = Me.lblSaldoAnterior.Text

                Exit Sub
            End If

            'actualiza el datatable
            ''' oResumen_cliente.Update()
            oResumen_cliente.CrearComandoUpdate()
            oResumen_cliente.Guardar()

            'muestra el dt en la grilla
            Me.dgv1.DataSource = odtResumen
            Me.dgv1.Columns(0).Visible = False
            Me.dgv1.Columns("DEBE").DefaultCellStyle.Format = "c"
            Me.dgv1.Columns("DEBE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.dgv1.Columns("HABER").DefaultCellStyle.Format = "c"
            Me.dgv1.Columns("HABER").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.dgv1.Columns("SALDO").DefaultCellStyle.Format = "c"
            Me.dgv1.Columns("SALDO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            'agrega el saldo al total de la grilla
            Me.lblTotalGrilla.Text = CStr(s)

            Try
                Me.lblFacturacion_mes.Text = FormatCurrency(oFactura.GetAll_Sum(CInt(Me.lblid_cliente.Text), Me.dtpPeriodo.Value.Date).Rows(0).Item("IMPORTE"))
            Catch ex As Exception
                Me.lblFacturacion_mes.Text = "$ 0"
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub RefrescarSaldo()
        'traigo los valores del ultimo saldo
        Dim odtSaldoTemp As DataTable
        odtSaldoTemp = oSaldo_cliente.GetMaxSaldo(CInt(Me.lblid_cliente.Text))

        Dim FechaMax As DateTime = #1/1/2000#
        Dim decSaldoOld As Decimal = 0

        'controlo si el dt esta vacio
        If odtSaldoTemp.Rows.Count > 0 Then
            'obtengo la fecha mayor
            FechaMax = CDate(odtSaldoTemp.Rows(0).Item("fecha_Saldo_cliente"))

            'obtengo el ultimo saldo
            decSaldoOld = CDec(odtSaldoTemp.Rows(0).Item("Saldo_cliente"))
        End If

        '''''ERROR EN FECHA 12''''''
        'seteo la fecha con 01-mm-yy para calcular a partir del ultimo saldo guardado
        If FechaMax.Month = 12 Then
            FechaMax = CDate("01-01-" & FechaMax.Year + 1)
        Else
            FechaMax = CDate("01-" & FechaMax.Month + 1 & "-" & FechaMax.Year)
        End If


        'calculo el saldo actual = ultimo saldo + resto a today
        Dim decSaldo As Decimal = 0
        decSaldo = oSaldo_cliente.GetSaldo(CInt(Me.lblid_cliente.Text), FechaMax) + decSaldoOld

        'lo pongo en el label
        Me.lblSaldoActual.Text = FormatCurrency(decSaldo)
    End Sub


    Private Sub dgv1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            Me.lblid_pk.Text = CStr(Me.dgv1.Item(0, Me.dgv1.CurrentRow.Index).Value)
        Catch ex As Exception
        End Try
    End Sub


    'coloca el rojo en la celdas negativas
    Private Sub dataGridView8_CellFormatting(ByVal sender As Object, _
    ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)

        If dgv1.Columns(e.ColumnIndex).Name.Equals("SALDO") Then
            'Dim intValue As Int32
            If CInt(e.Value) < 0 Then
                'if Int32.TryParse((String)e.Value, out intValue) && 
                '   (intValue < 0))
                e.CellStyle.ForeColor = Color.Red
                e.CellStyle.SelectionBackColor = Color.DarkRed
            End If
        End If
    End Sub

    'Private Sub Botones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    'Handles btnPago.Click, btnSalir.Click

    '    Dim btnTemp As New Button
    '    btnTemp = CType(sender, Button)

    '    Select Case btnTemp.Name
    '        Case "btnAyuda"
    '            'System.Diagnostics.Process.Start(PathAyuda + "FrmAbmCompra.htm")
    '        Case "btnSalir"
    '            Me.Close()
    '            'Case "btnFactura"
    '            '    Dim frmTemp As New frmAbmFactura
    '            '    Me.AddOwnedForm(frmTemp)
    '            '    frmTemp.ShowDialog()

    '            '    Me.RefrescarResumen()
    '            '    Me.RefrescarSaldo()
    '            '    'Me.ControlarEnabled()
    '        Case "btnPago"
    '            'Dim frmTemp As New frmAbmPago_cliente

    '            Dim frmTemp As New frmAbmPago_cliente
    '            Me.AddOwnedForm(frmTemp)
    '            frmTemp.ShowDialog()

    '            Me.RefrescarResumen()
    '            Me.RefrescarSaldo()
    '            'Me.ControlarEnabled()
    '    End Select

    'End Sub

    'Sub RefrescarCambioCombo()
    '    If Not IsNumeric(Me.lblid_cliente.Text) Then
    '        Exit Sub
    '    End If
    '    Me.RefrescarResumen()
    '    Me.RefrescarSaldo()
    '    'Me.ControlarEnabled()
    'End Sub

    Private Sub cmbcliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCliente.SelectedIndexChanged
        If Me.cmbcliente.SelectedIndex >= 0 Then
            Me.lblid_cliente.Text = cmbcliente.SelectedValue.ToString
        End If
        If Not IsNumeric(Me.lblid_cliente.Text) Then
            Exit Sub
        End If
        Me.RefrescarResumen()
        Me.RefrescarSaldo()
        Me.ControlarEnabled()
        Me.RefrescarGrilla()

    End Sub

    Private Sub btnBuscacliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaCliente.Click
        Dim frmTemporal As New FrmAbmcliente
        frmTemporal.ShowDialog()
        Me.Cargarcliente()
        Me.cmbcliente.Focus()
        Me.cmbcliente.Text = ""
        Me.lblid_cliente.Text = "0"
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles dtpPeriodo.KeyDown, cmbCliente.KeyDown
        Dim dtpTemp As New Object
        dtpTemp = sender
        If CDbl(e.KeyValue.ToString) = 13 Then
            'If dtpTemp.Name = "dtpPeriodo" Then
            '    Me.RefrescarResumen()
            '    Me.RefrescarSaldo()
            '    Me.ControlarEnabled()
            'End If
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub dtpPeriodo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpPeriodo.ValueChanged
        Me.RefrescarResumen()
        Me.RefrescarSaldo()
        Me.ControlarEnabled()
        Me.RefrescarGrilla()
    End Sub

    Private Sub btnGenerarResumen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarResumen.Click
        Me.RefrescarResumen()
        Me.btnCierrePeriodo.Enabled = True
    End Sub

    Private Sub btnSaldoActual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaldoActual.Click
        Me.RefrescarSaldo()
    End Sub

    Private Sub btnCierrePeriodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCierrePeriodo.Click
        Me.RefrescarResumen()
        Try
            'controlo si el saldo existe en la db - traigo el id_saldo
            Dim IdSaldo As Integer = oSaldo_cliente.Check(CInt(Me.lblid_cliente.Text), Me.dtpPeriodo.Value)
            If IdSaldo = 0 Then
                'agrego un nuevo registro
                If MessageBox.Show("Desea Realmente Cerrar el Periodo", "Cierre del Periodo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                Else
                    oSaldo_cliente.Insertar()
                    oSaldo_cliente.fecha_saldo_cliente = Me.dtpPeriodo.Value.Date
                    oSaldo_cliente.id_cliente = CInt(Me.lblid_cliente.Text)
                    oSaldo_cliente.saldo_cliente = CDec(Me.lblTotalGrilla.Text)
                    oSaldo_cliente.Guardar()
                    Me.ControlarEnabled()
                    Me.dtpPeriodo.Enabled = True
                    Me.cmbCliente.Enabled = True
                    Me.btnSaldoActual.Enabled = True
                    Me.btnSalir.Enabled = True
                End If
            Else
                'modifico un registro existente
                If MessageBox.Show("El Periodo ya Esta Cerrado Desea Modificarlo", "Cierre del Periodo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                Else
                    oSaldo_cliente.Modificar(IdSaldo)
                    oSaldo_cliente.fecha_saldo_cliente = Me.dtpPeriodo.Value.Date
                    oSaldo_cliente.id_cliente = CInt(Me.lblid_cliente.Text)
                    oSaldo_cliente.saldo_cliente = CDec(Me.lblTotalGrilla.Text)
                    oSaldo_cliente.Guardar()
                    Me.ControlarEnabled()
                    Me.dtpPeriodo.Enabled = True
                    Me.cmbCliente.Enabled = True
                    Me.btnSaldoActual.Enabled = True
                    Me.btnSalir.Enabled = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnModificarPeriodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarPeriodo.Click
        Dim IdSaldo As Integer = oSaldo_cliente.Check(CInt(Me.lblid_cliente.Text), Me.dtpPeriodo.Value)
        If IdSaldo = 0 Then 'si no esta
            Me.btnGenerarResumen.Enabled = False
            Me.btnCierrePeriodo.Enabled = False
            Me.btnModificarPeriodo.Enabled = True
            'Me.btnFactura.Enabled = False
            Me.btnPago.Enabled = False
        Else
            Me.btnGenerarResumen.Enabled = True
            Me.btnCierrePeriodo.Enabled = False
            Me.btnModificarPeriodo.Enabled = False
            'Me.btnFactura.Enabled = True
            Me.btnPago.Enabled = True
            Me.dtpPeriodo.Enabled = False
            Me.cmbCliente.Enabled = False
            Me.btnSaldoActual.Enabled = False
            ' Me.btnConsultar.Enabled = False
            Me.btnSalir.Enabled = False
        End If
    End Sub

    Sub ControlarEnabled()
        If Me.lblid_cliente.Text = "" Then
            Exit Sub
        End If
        Dim IdSaldo As Integer = oSaldo_cliente.Check(CInt(Me.lblid_cliente.Text), Me.dtpPeriodo.Value)
        If IdSaldo = 0 Then 'si no esta
            Me.btnGenerarResumen.Enabled = True
            Me.btnCierrePeriodo.Enabled = True
            Me.btnModificarPeriodo.Enabled = False
            'Me.btnFactura.Enabled = True
            Me.btnPago.Enabled = True
        Else
            Me.btnGenerarResumen.Enabled = False
            Me.btnCierrePeriodo.Enabled = False
            Me.btnModificarPeriodo.Enabled = True
            'Me.btnFactura.Enabled = False
            Me.btnPago.Enabled = False
        End If
    End Sub





    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        'Dim frmTemp As New frmConsultaclienteMai
        'frmTemp.ShowDialog()

        'Me.RefrescarResumen()
    End Sub

    '''REVISAR
    'Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
    '    Dim FrmImprime As New frmReporteCliente

    '    'If bandera_imprime_cliente = 0 Then
    '    '    Banderaprint = "imprime_resumen_cliente"
    '    'ElseIf bandera_imprime_cliente = 2 Then
    '    '    Banderaprint = "imprime_facturas_cliente"
    '    'ElseIf bandera_imprime_cliente = 4 Then

    '    Banderaprint = "imprime_resumen_cliente"
    '    parametro_cliente_prn = CInt(Me.lblid_cliente.Text)
    '    parametro_fecha_inicio = Me.dtpPeriodo.Value.Date
    '    parametro_nom_cliente = Me.cmbCliente.Text
    '    parametro_periodo = Me.dtpPeriodo.Value.Date
    '    parametro_sdo_ant = Me.lblSaldoAnterior.Text

    '    FrmImprime.ShowDialog()

    'End Sub

    Private Sub dgv1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Try
            If dgv1.Columns(e.ColumnIndex).Index = 2 Then
                'Dim frmTemp As New frmConsultaFactura
                'Dim strRecibo As String = ""
                'strRecibo = Me.dgv1.Item(2, Me.dgv1.CurrentRow.Index).Value.ToString.Trim
                'strRecibo = Microsoft.VisualBasic.Right(strRecibo, 13)
                'strRecibo = strRecibo.Replace("-", "")

                'odtConsultaGeneral.Clear()
                'odtConsultaGeneral = oFactura_recibo.GetAll_4(Me.lblid_cliente.Text, strRecibo)
                'frmTemp.ShowDialog()

            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub






   
    Private Sub btnCierreTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCierreTodo.Click
        'cierre de saldo de proveedores
        Dim odtClie As New DataTable
        odtClie = oCliente.ConsultarTodo
        For Each row As DataRow In odtClie.Rows
            Me.lblid_cliente.Text = CStr(row("id_cliente"))


            Me.RefrescarResumen()
            Try
                'controlo si el saldo existe en la db - traigo el id_saldo
                Dim IdSaldo As Integer = oSaldo_cliente.Check(CInt(Me.lblid_cliente.Text), Me.dtpPeriodo.Value)
                If IdSaldo = 0 Then
                    'agrego un nuevo registro

                    oSaldo_cliente.Insertar()
                    oSaldo_cliente.fecha_saldo_cliente = Me.dtpPeriodo.Value.Date
                    oSaldo_cliente.id_cliente = CInt(Me.lblid_cliente.Text)
                    oSaldo_cliente.saldo_cliente = CDec(Me.lblTotalGrilla.Text)
                    oSaldo_cliente.Guardar()

                Else
                    'modifico un registro existente

                    oSaldo_cliente.Modificar(IdSaldo)
                    oSaldo_cliente.fecha_saldo_cliente = Me.dtpPeriodo.Value.Date
                    oSaldo_cliente.id_cliente = CInt(Me.lblid_cliente.Text)
                    oSaldo_cliente.saldo_cliente = CDec(Me.lblTotalGrilla.Text)
                    oSaldo_cliente.Guardar()

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Next

        Me.Cargarcliente()
        Me.RefrescarResumen()
        Me.RefrescarSaldo()
        Me.ControlarEnabled()
    End Sub

    Public Sub RefrescarGrilla()
        Dim odtPago As DataTable
        Dim odtFactura As DataTable

        odtPago = oPago_cliente.GetAll_3(CInt(Me.lblid_cliente.Text), Me.dtpPeriodo.Value)
        Me.dgvPagoCliente.DataSource = odtPago
        Me.dgvPagoCliente.Columns(0).Visible = False


        Dim fecha_factura = Format(Me.dtpPeriodo.Value.Date)
        odtFactura = oFactura.ConsultarTodo_2(Me.dtpPeriodo.Value.Date)
        Me.dgvFactura.DataSource = odtFactura
        Me.dgvFactura.Columns(0).Visible = False
        Me.dgvFactura.Columns("subtotal").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvFactura.Columns("subtotal").DefaultCellStyle.Format = "c"
        Me.dgvFactura.Columns("alicuota").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvFactura.Columns("alicuota").DefaultCellStyle.Format = "n"
        Me.dgvFactura.Columns("iva").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvFactura.Columns("iva").DefaultCellStyle.Format = "c"
        Me.dgvFactura.Columns("total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvFactura.Columns("total").DefaultCellStyle.Format = "c"
        Me.dgvFactura.Columns("impuesto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgvFactura.Columns("impuesto").DefaultCellStyle.Format = "c"

        RefrescarGrillaClientes()
        RefrescarGrillaOrdenCompra()
        RefrescarGrillaRemito()
        RefrescarGrillaPresupuesto()
    End Sub

    Private Sub Botones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarPago.Click, btnBorrarPago.Click, btnModificarPago.Click
        Dim btnTemp As New Button
        Dim frmDetalle As New frmDetallePago_cliente
        btnTemp = CType(sender, Button)
        Try
            Select Case btnTemp.Name
                Case "btnAgregarPago"
                    BanderaPago_cliente = 1
                    Me.AddOwnedForm(frmDetalle)
                    oPago_cliente.Insertar()
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                Case "btnModificarPago"
                    If Not IsNumeric(Me.lblid_pk_PagoCliente.Text) Then
                        Exit Sub
                    End If
                    BanderaPago_cliente = 2
                    Me.AddOwnedForm(frmDetalle)
                    oPago_cliente.Modificar(CInt(Me.lblid_pk_PagoCliente.Text))
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                    RefrescarGrilla()
                Case "btnBorrarPago"
                    If Not IsNumeric(Me.lblid_pk_PagoCliente.Text) Then
                        Exit Sub
                    End If

                    If MessageBox.Show("Desea Realmente Eliminar el Registro ", "BORRAR", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                    = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If

                    Dim odt As New DataTable
                    Dim odt_2 As New DataTable

                    'desarchivo las facturas
                    odt = oRecibo_cliente.GetAllPagoCliente(CInt(Me.lblid_pk_PagoCliente.Text))
                    For Each row As DataRow In odt.Rows
                        oFactura.ArchivarFactura(CInt(row.Item("id_factura")), False)
                    Next

                    'desarchivo los cheques
                    odt_2 = oRecibo_cliente_cheque.GetAllPagoCliente_2(CInt(Me.lblid_pk_PagoCliente.Text))
                    For Each row_2 As DataRow In odt_2.Rows
                        oChequeRecibido.ArchivarCheque(CInt(row_2.Item("id_cheque_recibido")), False)
                    Next

                    oRecibo_cliente.DeletePago_cliente(CInt(Me.lblid_pk_PagoCliente.Text))
                    'oRecibo_cliente_cheque.DeleteRecibo_clienteCheque(CInt(Me.lblid_pk_PagoCliente.Text))
                    oRecibo_cliente_cheque.DeleteRecibo_cliente(CInt(Me.lblid_pk_PagoCliente.Text))

                    oPago_cliente.Borrar(CInt(Me.lblid_pk_PagoCliente.Text))
                    RefrescarGrilla()
                    'Case "btnAyudaPago"
                    '    'Process.Start(PathAyuda + "frmAbmPago_cliente.avi")
                    'Case "btnSalir"
                    '    Me.Close()
            End Select
            'Me.txtBuscar.Text = ""
            'Me.txtBuscar.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    
    Private Sub dgvPagoCliente_CurrentCellChanged(sender As System.Object, e As System.EventArgs) Handles dgvPagoCliente.CurrentCellChanged
        Try
            Me.lblid_pk_PagoCliente.Text = CStr(Me.dgvPagoCliente.Item(0, Me.dgvPagoCliente.CurrentRow.Index).Value)
            parametro_id_pago_cliente = Me.lblid_pk_PagoCliente.Text
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BotonesFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnAgregar.Click, btnBorrar.Click, btnModificar.Click, _
     btnImrpimirFactura.Click, btnAgregar_2.Click, btnExporta.Click, btnItemGlobal.Click
        Dim btnTemp As New Button
        Dim frmDetalle As New frmDetalleFactura
        Dim frmDetalle_2 As New frmDetalleFactura2
        Dim frmDetalle_E As New frmDetalleFacturaExporta
        Dim frmDetalle_3 As New frmDetalleFactura3

        btnTemp = CType(sender, Button)
        Try
            Select Case btnTemp.Name
                Case "btnAgregar"
                    BanderaFactura = 1
                    Me.AddOwnedForm(frmDetalle)
                    oFactura.Insertar()

                    Me.lblid_pk_Factura.Text = CStr(0)

                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()

                Case "btnAgregar_2"
                    BanderaFactura = 1
                    Me.AddOwnedForm(frmDetalle_2)
                    oFactura.Insertar()

                    Me.lblid_pk_Factura.Text = CStr(0)

                    frmDetalle_2.CargarCombos()
                    frmDetalle_2.ShowDialog()

                Case "btnExporta"
                    BanderaFactura = 1
                    Me.AddOwnedForm(frmDetalle_E)
                    oFactura_exporta.Insertar()

                    Me.lblid_pk_Factura.Text = CStr(0)

                    frmDetalle_E.CargarCombos()
                    frmDetalle_E.ShowDialog()

                Case "btnItemGlobal"
                    BanderaFactura = 1
                    Me.AddOwnedForm(frmDetalle_3)
                    oFactura.Insertar()

                    Me.lblid_pk_Factura.Text = CStr(0)

                    frmDetalle_3.CargarCombos()
                    frmDetalle_3.ShowDialog()

                Case "btnModificar"
                    If Not IsNumeric(Me.lblid_pk_Factura.Text) Then
                        Exit Sub
                    End If
                    BanderaFactura = 2

                    If Me.lblid_pk_Factura.Text < "1" Then
                        MessageBox.Show("Debe seleccionar un registro")
                        Exit Sub
                    End If

                    oFactura.Modificar(CInt(Me.lblid_pk_Factura.Text))

                    'veo que tipo de factura es
                    If oFactura.tipo_factura = "A" Then
                        Me.AddOwnedForm(frmDetalle)
                        frmDetalle.CargarCombos()
                        frmDetalle.ShowDialog()
                    ElseIf oFactura.tipo_factura = "AA" Then
                        oCuerpo_factura.ModificarPorFactura(CInt(Me.lblid_pk_Factura.Text))
                        Me.AddOwnedForm(frmDetalle_2)
                        frmDetalle_2.CargarCombos()
                        frmDetalle_2.ShowDialog()
                    ElseIf oFactura.tipo_factura = "AAA" Then
                        Me.AddOwnedForm(frmDetalle_3)
                        frmDetalle_3.CargarCombos()
                        frmDetalle_3.ShowDialog()
                    End If

                    RefrescarGrilla()
                Case "btnBorrar"
                    If Not IsNumeric(Me.lblid_pk_Factura.Text) Then
                        Exit Sub
                    End If

                    If Me.lblid_pk_Factura.Text <= "1" Then
                        MessageBox.Show("Debe seleccionar un registro")
                        Exit Sub
                    End If

                    If CBool(Me.dgvFactura.Item("ANULADA", Me.dgvFactura.CurrentRow.Index).Value) = False Then
                        oFactura.Anular(CInt(Me.lblid_pk_Factura.Text), True)
                    Else
                        oFactura.Anular(CInt(Me.lblid_pk_Factura.Text), False)
                    End If


                    ' oFactura.Borrar(Me.lblid_pk_Factura.Text)
                    RefrescarGrilla()
                Case "btnAyuda"
                    'Process.Start(PathAyuda + "frmAbmFactura.avi")
                Case "btnSalir"
                    Me.Close()
                Case "btnImprimirFactura"
                    'Dim frmimpresiontemporal As New FrmReporteFactura

                    'Try
                    '    Banderaprintpantalla = "factura"
                    '    frmimpresiontemporal.ShowDialog()
                    'Catch ex As Exception
                    '    MessageBox.Show(ex.Message)
                    'End Try
            End Select
            Me.txtBuscar.Text = ""
            Me.txtBuscar.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvFactura_CurrentCellChanged(sender As Object, e As System.EventArgs) Handles dgvFactura.CurrentCellChanged
        Try
            Me.lblid_pk_Factura.Text = CStr(Me.dgvFactura.Item(0, Me.dgvFactura.CurrentRow.Index).Value)
            '0, Me.dgvPresupuesto.CurrentRow.Index
            parametro_fac = CInt(Me.lblid_pk_Factura.Text)
        Catch ex As Exception
        End Try
    End Sub

    '''''''''
    '''''''''
    'agregado para el tap Clientes

    Public Sub RefrescarGrillaClientes()
        Dim odt As DataTable

        odt = oCliente.ConsultarTodo()
        Me.dgv_cliente.DataSource = odt
        Me.dgv_cliente.Columns(0).Visible = False
    End Sub

    Private Sub txtBuscarC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarC.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.btnModificarC.Focus()
        End If
    End Sub

    Private Sub txtBuscarC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarC.TextChanged
        If Me.txtBuscarC.Text = "" Then
            Me.txtBuscarC.Text = " "
        End If
        odt = oCliente.Buscar(Me.txtBuscarC.Text)
        Me.dgv_cliente.DataSource = odt
    End Sub

    Private Sub dgv_cliente_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_cliente.CurrentCellChanged
        Try
            Me.lblid_c.Text = CStr(Me.dgv_cliente.Item(0, Me.dgv_cliente.CurrentRow.Index).Value)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Botones_Click1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarC.Click, btnAyuda.Click, btnBorrarC.Click, btnModificarC.Click, btnModificarPago.Click, btnBorrarPago.Click, btnAyudaPago.Click, btnAgregarPago.Click
        Dim btnTemp As New Button
        Dim frmDetalle As New frmDetalleCliente
        btnTemp = CType(sender, Button)
        Try
            Select Case btnTemp.Name
                Case "btnAgregarC"
                    BanderaCliente = 1
                    Me.AddOwnedForm(frmDetalle)


                    oCliente.Insertar()
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                Case "btnModificarC"
                    If Not IsNumeric(Me.lblid_c.Text) Then
                        Exit Sub
                    End If
                    BanderaCliente = 2
                    Me.AddOwnedForm(frmDetalle)
                    oCliente.Modificar(CInt(Me.lblid_c.Text))
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                    RefrescarGrillaClientes()
                Case "btnBorrarC"
                    If Not IsNumeric(Me.lblid_c.Text) Then
                        Exit Sub
                    End If

                    If MessageBox.Show("Desea Realmente Eliminar el Registro ", "BORRAR", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                    = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If

                    oCliente.Borrar(CInt(Me.lblid_c.Text))
                    RefrescarGrillaClientes()
                Case "btnAyuda"
                    'Process.Start(PathAyuda + "frmAbmCliente.avi")
                Case "btnSalirC"
                    Me.Close()
            End Select
            Me.txtBuscarC.Text = ""
            Me.txtBuscarC.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    ''''''''''
    ''''''''''
    'agregado para Orden de compra
    Public Sub RefrescarGrillaOrdenCompra()
        Dim odt As DataTable

        'odt = oOrden_compra.ConsultarTodo()
        odt = oOrden_compra.ConsultarTodo2(CInt(Me.lblid_cliente.Text))
        Me.dgv_orden_compra.DataSource = odt
        Me.dgv_orden_compra.Columns(0).Visible = False
        Me.dgv_orden_compra.Columns(2).Visible = False
        Me.dgv_orden_compra.Columns(7).Visible = False
    End Sub

    Private Sub txtBuscarCompra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarCompra.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.btnModificarCompra.Focus()
        End If
    End Sub

    Private Sub txtBuscarCompra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarCompra.TextChanged
        If Me.txtBuscarCompra.Text = "" Then
            Me.txtBuscarCompra.Text = " "
        End If
        odt = oOrden_compra.Buscar(Me.txtBuscarCompra.Text)
        Me.dgv_orden_compra.DataSource = odt
    End Sub

    Private Sub dgv_orden_compra_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_orden_compra.CurrentCellChanged
        Try
            Me.lblid_orden_compra.Text = CStr(Me.dgv_orden_compra.Item(0, Me.dgv_orden_compra.CurrentRow.Index).Value)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Botones_Click3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarCompra.Click, btnBorrarCompra.Click, btnModificarCompra.Click
        Dim btnTemp As New Button
        Dim frmDetalle As New frmDetalleOrden_compra
        btnTemp = CType(sender, Button)
        Try
            Select Case btnTemp.Name
                Case "btnAgregarCompra"
                    BanderaOrden_compra = 1
                    Me.AddOwnedForm(frmDetalle)
                    oOrden_compra.Insertar()
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                Case "btnModificarCompra"
                    If Not IsNumeric(Me.lblid_orden_compra.Text) Then
                        Exit Sub
                    End If
                    BanderaOrden_compra = 2
                    Me.AddOwnedForm(frmDetalle)
                    oOrden_compra.Modificar(CInt(Me.lblid_orden_compra.Text))
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                    RefrescarGrillaOrdenCompra()
                Case "btnBorrarCompra"
                    If Not IsNumeric(Me.lblid_orden_compra.Text) Then
                        Exit Sub
                    End If

                    If MessageBox.Show("Desea Realmente Eliminar el Registro ", "BORRAR", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                    = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If

                    oCuerpo_orden_compra.Deleteorden_compra(CInt(Me.lblid_orden_compra.Text), vgCodigoUsuario) ''

                    oOrden_compra.Borrar(CInt(Me.lblid_orden_compra.Text))
                    RefrescarGrillaOrdenCompra()
                Case "btnAyuda"
                    'Process.Start(PathAyuda + "frmAbmOrden_compra.avi")
                Case "btnSalir"
                    Me.Close()
            End Select
            Me.txtBuscarCompra.Text = ""
            Me.txtBuscarCompra.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    '''''''''''''''''''''
    '''''''''''''''''''''
    '''''''''''''''''''''
    'agregado para remito

    Public Sub RefrescarGrillaRemito()
        Dim odt As DataTable

        'odt = oRemito.ConsultarTodo()
        odt = oRemito.ConsultarTodo_2(CInt(Me.lblid_cliente.Text))
        Me.dgv_remito.DataSource = odt
        Me.dgv_remito.Columns(0).Visible = False
    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarRemito.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.btnModificarRemito.Focus()
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarRemito.TextChanged
        If Me.txtBuscarRemito.Text = "" Then
            Me.txtBuscarRemito.Text = " "
        End If
        odt = oRemito.Buscar(Me.txtBuscarRemito.Text)
        Me.dgv_remito.DataSource = odt
    End Sub

    Private Sub dgv_remito_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_remito.CurrentCellChanged
        Try
            Me.lblid_remito.Text = CStr(Me.dgv_remito.Item(0, Me.dgv_remito.CurrentRow.Index).Value)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Botones_Click4(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarRemito.Click, btnBorrarRemito.Click, btnModificarRemito.Click
        Dim btnTemp As New Button
        Dim frmDetalle As New frmDetalleRemito
        btnTemp = CType(sender, Button)
        Try
            Select Case btnTemp.Name
                Case "btnAgregarRemito"
                    BanderaRemito = 1
                    Me.AddOwnedForm(frmDetalle)
                    oRemito.Insertar()
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                Case "btnModificarRemito"
                    If Not IsNumeric(Me.lblid_remito.Text) Then
                        Exit Sub
                    End If
                    BanderaRemito = 2
                    Me.AddOwnedForm(frmDetalle)
                    oRemito.Modificar(CInt(Me.lblid_remito.Text))
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                    RefrescarGrillaRemito()
                Case "btnBorrarRemito"
                    If Not IsNumeric(Me.lblid_remito.Text) Then
                        Exit Sub
                    End If

                    If MessageBox.Show("Desea Realmente Eliminar el Registro ", "BORRAR", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                    = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If

                    oCuerpo_remito.DeleteRemito(CInt(Me.lblid_remito.Text), vgCodigoUsuario) ''

                    oRemito.Borrar(CInt(Me.lblid_remito.Text))
                    RefrescarGrillaRemito()
                Case "btnAyuda"
                    'Process.Start(PathAyuda + "frmAbmRemito.avi")
                Case "btnSalir"
                    Me.Close()
            End Select
            Me.txtBuscar.Text = ""
            Me.txtBuscar.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    ' PRESUPUESTO
    Public Sub RefrescarGrillaPresupuesto()
        Dim odt As DataTable

        odt = oPresupuesto.GetAll_2(CInt(Me.lblid_cliente.Text))
        Me.dgvPresupuesto.DataSource = odt
        Me.dgvPresupuesto.Columns(0).Visible = False
    End Sub

    Private Sub txtBuscarPresupuesto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConsultarPresupuesto.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.btnModificar_presupuesto.Focus()
        End If
    End Sub

    Private Sub txtBuscarPresupuesto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConsultarPresupuesto.TextChanged
        If Me.txtConsultarPresupuesto.Text = "" Then
            Me.txtConsultarPresupuesto.Text = " "
        End If
        odt = oPresupuesto.Buscar(Me.txtBuscar.Text)
        Me.dgv1.DataSource = odt
    End Sub

    Private Sub dgvPresupuesto_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvPresupuesto.CurrentCellChanged
        Try
            Me.lblid_presupuesto.Text = CStr(Me.dgvPresupuesto.Item(0, Me.dgvPresupuesto.CurrentRow.Index).Value)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BotonesPresupuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnAgregarPresupuesto.Click, btnBorrar_presupuesto.Click, btnModificar_presupuesto.Click
        Dim btnTemp As New Button
        Dim frmDetalle As New frmDetallePresupuesto
        btnTemp = CType(sender, Button)
        Try
            Select Case btnTemp.Name
                Case "btnAgregarPresupuesto"
                    BanderaPresupuesto = 1
                    Me.AddOwnedForm(frmDetalle)
                    oPresupuesto.Insertar()
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                Case "btnModificar_presupuesto"
                    If Not IsNumeric(Me.lblid_presupuesto.Text) Then
                        Exit Sub
                    End If
                    BanderaPresupuesto = 2
                    Me.AddOwnedForm(frmDetalle)
                    oPresupuesto.Modificar(CInt(Me.lblid_presupuesto.Text))
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                    RefrescarGrillaPresupuesto()
                Case "btnBorrar_presupuesto"
                    If Not IsNumeric(Me.lblid_presupuesto.Text) Then
                        Exit Sub
                    End If

                    If MessageBox.Show("Desea Realmente Eliminar el Registro ", "BORRAR", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                    = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If

                    oCuerpo_presupuesto.Deletepresupuesto(CInt(Me.lblid_pk.Text), vgCodigoUsuario)

                    oPresupuesto.Borrar(CInt(Me.lblid_presupuesto.Text))
                    RefrescarGrillaPresupuesto()
                Case "btnAyuda"
                    'Process.Start(PathAyuda + "frmAbmPresupuesto.avi")
                Case "btnSalir"
                    Me.Close()
            End Select
            Me.txtConsultarPresupuesto.Text = ""
            Me.txtConsultarPresupuesto.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


  
    Private Sub dgvFactura_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFactura.CellContentClick

    End Sub
End Class