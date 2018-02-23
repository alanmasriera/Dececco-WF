Public Class frmDetallePago_cliente

    Dim BanderaCierreForm As Boolean = False


    Private Sub frmDetalleNota_devolucion_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If BanderaCierreForm = False Then
            e.Cancel = True
        End If
    End Sub

    Private Sub frmDetallePago_cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttGeneral.SetToolTip(Me.btnBuscaCliente, "Buscar Nuevo Cliente")
        Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Pago_cliente")
        Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()


        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try

        Me.lblid_pago_cliente.Text = CType(Me.Owner, frmResumenCliente).lblid_pk_PagoCliente.Text

        If BanderaPago_cliente = 1 Then
            Me.LimpiarControles()
        End If

        Me.Text = "Pago_cliente"
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False

        oRecibo_cliente.Cargar()
        oRecibo_cliente_cheque.Cargar()
        oRecibo_cliente_cheque_2.Cargar()
        oRecibo_cliente_ingreso_efectivo.Cargar()

        Me.cmbcliente.Text = CType(Me.Owner, frmResumenCliente).cmbCliente.Text
        Me.lblid_cliente.Text = CType(Me.Owner, frmResumenCliente).lblid_cliente.Text
        BanderaCliente = CInt(Me.lblid_cliente.Text)
        Me.RefrescarGrilla()
        Me.RefrescarGrilla_2()
        Me.RefrescarGrilla_3()
        Me.RefrescarGrilla_4()

    End Sub

    Sub CargarCombos()
        'Me.CargarCliente()
    End Sub

    'Sub CargarCliente()
    '    Dim odt As New DataTable

    '    odt = oCliente.GetCmb
    '    With Me.cmbCliente
    '        .DataSource = odt
    '        .DisplayMember = "nombre_cliente"
    '        .ValueMember = "id_cliente"
    '    End With
    '    If Me.cmbCliente.SelectedIndex >= 0 Then
    '        cmbCliente.SelectedIndex = 0
    '        Me.lblid_Cliente.Text = cmbCliente.SelectedValue.ToString
    '    End If
    'End Sub

    Sub LimpiarControles()
        'Me.lblid_cliente.Text = "0"
        'Me.cmbCliente.Text =  ""
        Me.dtpfecha.Value = DateTime.Now
        Me.txtpago.Text = ""
        Me.txtdetalle.Text = ""
        Me.chkefectivo.Checked = False
        Me.txtNumero_4.Text = ""
        Me.txtNumero_8.Text = ""
        Me.txtretencion_iva.Text = "0"
        Me.txtingreso_bruto.Text = "0"
        Me.txtimpuesto_ganancia.Text = "0"
        Me.txtsuss.Text = "0"

        Me.lblid_pago_cliente.Text = "0"
        Me.txtTotalCheque.Text = "0"
        Me.txtTotalFactura.Text = "0"
        Me.txtObservacion.Text = ""
    End Sub

    Private Sub ObtenerDatos()
        'Me.lblid_cliente.Text = oPago_cliente.id_cliente.ToString
        Me.dtpfecha.Value = oPago_cliente.fecha
        Me.txtpago.Text = oPago_cliente.pago.ToString.Trim
        Me.txtdetalle.Text = oPago_cliente.detalle.Trim
        Me.chkefectivo.Checked = oPago_cliente.efectivo
        'Me.txtnumero_recibo.Text = oPago_cliente.numero_recibo.Trim

        Me.txtretencion_iva.Text = oPago_cliente.retencion_iva.ToString.Trim
        Me.txtingreso_bruto.Text = oPago_cliente.ingreso_bruto.ToString.Trim
        Me.txtimpuesto_ganancia.Text = oPago_cliente.impuesto_ganancia.ToString.Trim
        Me.txtsuss.Text = oPago_cliente.suss.ToString.Trim

        If oPago_cliente.numero_recibo.Length = 12 Then
            Me.txtNumero_4.Text = oPago_cliente.numero_recibo.Substring(0, 4)
            Me.txtNumero_8.Text = oPago_cliente.numero_recibo.Substring(4, 8)
        End If
        Me.txtObservacion.Text = oPago_cliente.observacion
    End Sub

    Private Sub AsignarDatos()
        oPago_cliente.id_cliente = CInt(Me.lblid_cliente.Text)
        oPago_cliente.fecha = Me.dtpfecha.Value.Date
        oPago_cliente.pago = CDec(Me.txtpago.Text)
        oPago_cliente.detalle = Me.txtdetalle.Text
        oPago_cliente.efectivo = Me.chkefectivo.Checked
        'oPago_cliente.numero_recibo = Me.txtnumero_recibo.Text
        oPago_cliente.numero_recibo = Me.txtNumero_4.Text & Me.txtNumero_8.Text
        oPago_cliente.retencion_iva = CDec(Me.txtretencion_iva.Text)
        oPago_cliente.ingreso_bruto = CDec(Me.txtingreso_bruto.Text)
        oPago_cliente.impuesto_ganancia = CDec(Me.txtimpuesto_ganancia.Text)
        oPago_cliente.suss = CDec(Me.txtsuss.Text)
        oPago_cliente.total_letra = Numalet.ToCardinal(Me.txtpago.Text)
        oPago_cliente.observacion = Me.txtObservacion.Text.Trim
    End Sub

    Public Sub SoloLectura()
        Me.cmbCliente.Enabled = False
        Me.btnBuscaCliente.Enabled = False
        Me.dtpfecha.Enabled = False
        Me.txtpago.Enabled = False
        Me.txtdetalle.Enabled = False
        Me.chkefectivo.Enabled = False
        Me.txtNumero_4.Enabled = False
        Me.txtNumero_8.Enabled = False
        Me.txtretencion_iva.Enabled = False
        Me.txtingreso_bruto.Enabled = False
        Me.txtimpuesto_ganancia.Enabled = False
        Me.txtsuss.Enabled = False
        Me.btnGuardar.Visible = False
    End Sub

    Private Sub Numeros(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
  Handles txtNumero_4.KeyPress, txtNumero_8.KeyPress
        Dim txtTemp As TextBox
        txtTemp = CType(sender, TextBox)

        If e.KeyChar.ToString = vbCr Then
            If txtTemp.Name = "txtNumero_4" Then
                Me.txtNumero_4.Text = CompletarCeros(Me.txtNumero_4.Text, 4)
            End If
            If txtTemp.Name = "txtNumero_8" Then
                Me.txtNumero_8.Text = CompletarCeros(Me.txtNumero_8.Text, 8)
            End If

            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If

        If (e.KeyChar.ToString >= "0" And e.KeyChar.ToString <= "9") Or e.KeyChar = vbBack Then
            '  e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            If oPago_cliente.Exist() Then
                If BanderaPago_cliente = 1 Then
                    MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
                    Exit Sub
                ElseIf BanderaPago_cliente = 2 Then
                    If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                        = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If

            Select Case BanderaPago_cliente
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oPago_cliente.Guardar()

                    Me.lblid_pago_cliente.Text = oPago_cliente.id_pago_cliente.ToString
                    oRecibo_cliente.UpdateID(CInt(Me.lblid_pago_cliente.Text))
                    oRecibo_cliente_cheque.UpdateID(CInt(Me.lblid_pago_cliente.Text))
                    oRecibo_cliente_cheque_2.UpdateID(CInt(Me.lblid_pago_cliente.Text))
                    oRecibo_cliente_ingreso_efectivo.UpdateID(CInt(Me.lblid_pago_cliente.Text))

                    ''archiva las facturas
                    Dim odt1 As New DataTable
                    Dim saldo1 As Decimal = 0
                    Dim var1 As Integer = 0
                    Dim odtFactura As New DataTable

                    For Each row As DataGridViewRow In dgv1.Rows
                        odt1 = oRecibo_cliente.GetAll_X_factura(CInt(row.Cells("id_factura").Value)) 'saldo
                        For Each r As DataRow In odt1.Rows
                            saldo1 += CDec(r("importe pagado"))
                        Next

                        odtFactura = oFactura.GetOne(CInt(row.Cells("id_factura").Value))
                        If saldo1 >= CDec(odtFactura.Rows(0).Item("total factura")) Then
                            oFactura.ArchivarFactura(CInt(row.Cells("id_factura").Value), True)
                        Else
                            oFactura.ArchivarFactura(CInt(row.Cells("id_factura").Value), False)
                        End If
                    Next

                    'For Each row As DataGridViewRow In dgv1.Rows
                    '    odt = oFactura.GetAll_3()
                    '    For Each r As DataRow In odt.Rows
                    '        saldo += CDec(r("importe pagado"))
                    '    Next
                    '    oFactura.ArchivarFactura(CInt(row.Cells("id_factura").Value), True)
                    'Next

                    'archiva los cheques caja
                    For Each row_2 As DataGridViewRow In dgv2.Rows
                        oCheque_recibido.ArchivarCheque(CInt(row_2.Cells("id_cheque_recibido").Value), True)
                    Next

                    'archiva los cheques banco
                    For Each row_3 As DataGridViewRow In dgv3.Rows
                        oChequeRecibido.ArchivarCheque(CInt(row_3.Cells("id_cheque_recibido").Value), True)
                    Next


                    Dim odt As New DataTable
                    Dim saldo As Decimal = 0
                    Dim var As Integer = 0
                    Dim odtIngreso As New DataTable

                    'archiva los ingresos
                    For Each row_4 As DataGridViewRow In dgv4.Rows
                        odt = oRecibo_cliente_ingreso_efectivo.GetAllIngreso_efectivo(CInt(row_4.Cells("id ingreso efectivo").Value)) 'saldo
                        For Each r As DataRow In odt.Rows
                            saldo += CDec(r("importe pagado"))
                        Next

                        odtIngreso = oIngreso_efectivo.GetOne(CInt(row_4.Cells("id ingreso efectivo").Value))
                        If saldo >= CDec(odtIngreso.Rows(0).Item("importe")) Then
                            oIngreso_efectivo.Archivar_ingreso(CInt(row_4.Cells("id ingreso efectivo").Value), True)
                        Else
                            oIngreso_efectivo.Archivar_ingreso(CInt(row_4.Cells("id ingreso efectivo").Value), False)
                        End If
                    Next

                    CType(Me.Owner, frmResumenCliente).RefrescarGrilla()
                    Me.CargarCombos()
                    oPago_cliente.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.cmbcliente.Focus()
                    Me.RefrescarGrilla()
                    Me.RefrescarGrilla_2()
                    Me.RefrescarGrilla_3()
                    Me.RefrescarGrilla_4()
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    BanderaCierreForm = True

                    oPago_cliente.Guardar()

                    'archiva las facturas
                    Dim odt1 As New DataTable
                    Dim saldo1 As Decimal = 0
                    Dim var1 As Integer = 0
                    Dim odtFactura As New DataTable

                    For Each row As DataGridViewRow In dgv1.Rows
                        odt1 = oRecibo_cliente.GetAll_X_factura(CInt(row.Cells("id_factura").Value)) 'saldo
                        For Each r As DataRow In odt1.Rows
                            saldo1 += CDec(r("importe pagado"))
                        Next

                        odtFactura = oFactura.GetOne(CInt(row.Cells("id_factura").Value))
                        If saldo1 >= CDec(odtFactura.Rows(0).Item("total factura")) Then
                            oFactura.ArchivarFactura(CInt(row.Cells("id_factura").Value), True)
                        Else
                            oFactura.ArchivarFactura(CInt(row.Cells("id_factura").Value), False)
                        End If
                    Next


                    'For Each row As DataGridViewRow In dgv1.Rows
                    '    oFactura.ArchivarFactura(CInt(row.Cells("id_factura").Value), True)
                    'Next

                    'archiva los cheques caja
                    For Each row_2 As DataGridViewRow In dgv2.Rows
                        oCheque_recibido.ArchivarCheque(CInt(row_2.Cells("id_cheque_recibido").Value), True)
                    Next

                    'archiva los cheques banco
                    For Each row_3 As DataGridViewRow In dgv3.Rows
                        oChequeRecibido.ArchivarCheque(CInt(row_3.Cells("id_cheque_recibido").Value), True)
                    Next


                    Dim odt As New DataTable
                    Dim saldo As Decimal = 0
                    Dim var As Integer = 0
                    Dim odtIngreso As New DataTable

                    'archiva los ingresos
                    For Each row_4 As DataGridViewRow In dgv4.Rows
                        odt = oRecibo_cliente_ingreso_efectivo.GetAllIngreso_efectivo(CInt(row_4.Cells("id ingreso efectivo").Value)) 'saldo
                        For Each r As DataRow In odt.Rows
                            saldo += CDec(r("importe pagado"))
                        Next

                        odtIngreso = oIngreso_efectivo.GetOne(CInt(row_4.Cells("id ingreso efectivo").Value))
                        If saldo >= CDec(odtIngreso.Rows(0).Item("importe")) Then
                            oIngreso_efectivo.Archivar_ingreso(CInt(row_4.Cells("id ingreso efectivo").Value), True)
                        Else
                            oIngreso_efectivo.Archivar_ingreso(CInt(row_4.Cells("id ingreso efectivo").Value), False)
                        End If
                    Next

                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If Me.txtpago.Text = "" Or Me.txtsuss.Text = "" Or Me.txtretencion_iva.Text = "" Or _
        Me.txtNumero_4.Text = "" Or Me.txtNumero_8.Text = "" Or Me.txtingreso_bruto.Text = "" Or _
        Me.txtimpuesto_ganancia.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean

        If CDbl(Me.lblid_cliente.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de cliente")
            Exit Sub
        End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaPago_cliente = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        BanderaCierreForm = True
        If Me.lblid_pago_cliente.Text = "0" Then
            oRecibo_cliente.DeletePago_cliente(0)
            oRecibo_cliente_cheque.DeleteRecibo_cliente(0)
            oRecibo_cliente_cheque_2.DeleteRecibo_cliente(0)
            oRecibo_cliente_ingreso_efectivo.DeleteRecibo_cliente(0)
        End If

        Me.Close()
    End Sub

    Private Sub cmbCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcliente.SelectedIndexChanged
        If Me.cmbCliente.SelectedIndex >= 0 Then
            Me.lblid_cliente.Text = cmbCliente.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscacliente.Click
        Dim frmTemporal As New FrmAbmCliente
        frmTemporal.ShowDialog()
        'Me.CargarCliente()
        Me.cmbCliente.Focus()
        Me.cmbCliente.Text = ""
        Me.lblid_Cliente.Text = "0"
    End Sub

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtdetalle.KeyPress, chkefectivo.KeyPress, txtObservacion.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles cmbcliente.KeyDown, dtpfecha.KeyDown
        If CDbl(e.KeyValue.ToString) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtpago.KeyPress, txtretencion_iva.KeyPress, txtingreso_bruto.KeyPress, txtimpuesto_ganancia.KeyPress, txtsuss.KeyPress
        Dim txtTemp As TextBox
        txtTemp = CType(sender, TextBox)

        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Then
            If InStr(txtTemp.Text, ",") <> 0 Then
                e.Handled = True
            Else
                e.KeyChar = CChar(",")
            End If
        End If

        Dim Largo As Integer = InStr(txtTemp.Text, ",")

        If txtTemp.Text.Length > Largo + 2 And Largo <> 0 And e.KeyChar.ToString <> vbBack Then
            e.Handled = True
        End If

        If (e.KeyChar.ToString >= "0" And e.KeyChar.ToString <= "9") Or e.KeyChar.ToString = "," Or e.KeyChar = vbBack Then
            '  e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub RefrescarGrilla()
        Dim odt As DataTable
        Dim decTotal As Decimal = 0

        odt = oRecibo_cliente.GetAllFactura(CInt(Me.lblid_pago_cliente.Text))
        Me.dgv1.DataSource = odt
        Me.dgv1.Columns(0).Visible = False
        Me.dgv1.Columns(1).Visible = False

        For Each row As DataRow In odt.Rows
            decTotal = decTotal + CDec(row.Item("total_factura"))
        Next

        Me.txtTotalFactura.Text = CStr(decTotal)

        If BanderaPago_cliente = 1 Then
            Me.txtpago.Text = Me.txtTotalFactura.Text
        End If

    End Sub

    Private Sub dgv1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv1.CurrentCellChanged
        Try
            Me.lblid_pk.Text = CStr(Me.dgv1.Item(0, Me.dgv1.CurrentRow.Index).Value)
            Me.lblid_factura.Text = CStr(Me.dgv1.Item("id_factura", Me.dgv1.CurrentRow.Index).Value)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Botones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnAgregar.Click, btnBorrar.Click, btnModificar.Click

        Dim btnTemp As New Button
        Dim frmDetalle As New frmDetalleRecibo_cliente
        btnTemp = CType(sender, Button)
        Try
            Select Case btnTemp.Name
                Case "btnAgregar"
                    BanderaRecibo_cliente = 1
                    Me.AddOwnedForm(frmDetalle)
                    oRecibo_cliente.Insertar()
                    frmDetalle.lblid_cliente.Text = Me.lblid_cliente.Text
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                Case "btnModificar"
                    If Not IsNumeric(Me.lblid_pk.Text) Then
                        Exit Sub
                    End If
                    BanderaRecibo_cliente = 2
                    Me.AddOwnedForm(frmDetalle)
                    oRecibo_cliente.Modificar(CInt(Me.lblid_pk.Text))
                    frmDetalle.lblid_cliente.Text = Me.lblid_cliente.Text
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                    RefrescarGrilla()
                Case "btnBorrar"
                    If Not IsNumeric(Me.lblid_pk.Text) Then
                        Exit Sub
                    End If

                    If MessageBox.Show("Desea Realmente Eliminar el Registro ", "BORRAR", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                    = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If

                    'desarchivo la factura
                    oFactura.ArchivarFactura(CInt(Me.lblid_factura.Text), False)

                    oRecibo_cliente.Borrar(CInt(Me.lblid_pk.Text))
                    RefrescarGrilla()
                Case "btnAyuda"
                    'Process.Start(PathAyuda + "frmAbmRecibo_cliente.avi")
                Case "btnSalir"
                    Me.Close()
            End Select
            'Me.txtBuscar.Text = ""
            'Me.txtBuscar.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub




    Public Sub RefrescarGrilla_2()
        Dim odt As DataTable
        Dim decTotal As Decimal = 0
        Dim decRet_cheques As Decimal = 0

        Dim decIngreso_bruto As Decimal = 0
        Dim decSuss As Decimal = 0
        Dim decRetencion_iva As Decimal = 0
        Dim decImp_ganancia As Decimal = 0

        odt = oRecibo_cliente_cheque.GetAllPagoCliente_2(CInt(Me.lblid_pago_cliente.Text))
        Me.dgv2.DataSource = odt
        Me.dgv2.Columns(0).Visible = False
        Me.dgv2.Columns("id_cheque_recibido").Visible = False

        For Each row As DataRow In odt.Rows
            decTotal = decTotal + CDec(row.Item("importe"))
        Next
        decIngreso_bruto = CDec(Me.txtingreso_bruto.Text)
        decSuss = CDec(Me.txtsuss.Text)
        decRetencion_iva = CDec(Me.txtretencion_iva.Text)
        decImp_ganancia = CDec(Me.txtimpuesto_ganancia.Text)

        Me.txtTotalCheque.Text = CStr(decTotal)
        decRet_cheques = decTotal + decIngreso_bruto + decSuss + decRetencion_iva + decImp_ganancia
        Me.txtRetenciones_cheques.Text = CStr(decRet_cheques)


    End Sub

    Private Sub dgv2_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv2.CurrentCellChanged
        Try
            Me.lblid_pk_2.Text = CStr(Me.dgv2.Item(0, Me.dgv2.CurrentRow.Index).Value)
            Me.lblid_cheque_recibido.Text = CStr(Me.dgv2.Item("id_cheque_recibido", Me.dgv2.CurrentRow.Index).Value)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Botones_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnAgregar_2.Click, btnBorrar_2.Click, btnModificar_2.Click

        Dim btnTemp As New Button
        Dim frmDetalle As New frmDetalleRecibo_cliente_cheque
        btnTemp = CType(sender, Button)
        Try
            Select Case btnTemp.Name
                Case "btnAgregar_2"
                    BanderaRecibo_cliente_cheque = 1
                    Me.AddOwnedForm(frmDetalle)
                    oRecibo_cliente_cheque.Insertar()
                    frmDetalle.lblid_cliente.Text = Me.lblid_cliente.Text
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                Case "btnModificar_2"
                    If Not IsNumeric(Me.lblid_pk.Text) Then
                        Exit Sub
                    End If
                    BanderaREcibo_cliente_cheque = 2
                    Me.AddOwnedForm(frmDetalle)
                    oRecibo_cliente_cheque.Modificar(CInt(Me.lblid_pk.Text))
                    frmDetalle.lblid_cliente.Text = Me.lblid_cliente.Text
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                    RefrescarGrilla_2()
                Case "btnBorrar_2"
                    If Not IsNumeric(Me.lblid_pk.Text) Then
                        Exit Sub
                    End If

                    If MessageBox.Show("Desea Realmente Eliminar el Registro ", "BORRAR", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                    = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If

                    'desarchivo el cheque
                    oCheque_recibido.ArchivarCheque(CInt(Me.lblid_cheque_recibido.Text), False)

                    oRecibo_cliente_cheque.Borrar(CInt(Me.lblid_pk_2.Text))

                    RefrescarGrilla_2()
                Case "btnAyuda"
                    'Process.Start(PathAyuda + "frmAbmRecibo_cliente_cheque.avi")
                Case "btnSalir"
                    Me.Close()
            End Select
            'Me.txtBuscar.Text = ""
            'Me.txtBuscar.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtControles_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles txtimpuesto_ganancia.LostFocus, txtsuss.LostFocus, txtretencion_iva.LostFocus, txtingreso_bruto.LostFocus

        Me.RefrescarGrilla_2()

    End Sub



    Public Sub RefrescarGrilla_3()
        Dim odt As DataTable
        'Dim decTotal As Decimal = 0
        'Dim decRet_cheques As Decimal = 0

        'Dim decIngreso_bruto As Decimal = 0
        'Dim decSuss As Decimal = 0
        'Dim decRetencion_iva As Decimal = 0
        'Dim decImp_ganancia As Decimal = 0

        odt = oRecibo_cliente_cheque_2.GetAllPagoCliente_2(CInt(Me.lblid_pago_cliente.Text))
        Me.dgv3.DataSource = odt
        Me.dgv3.Columns(0).Visible = False
        Me.dgv3.Columns("id_cheque_recibido").Visible = False

        'For Each row As DataRow In odt.Rows
        '    decTotal = decTotal + CDec(row.Item("importe"))
        'Next
        'decIngreso_bruto = CDec(Me.txtingreso_bruto.Text)
        'decSuss = CDec(Me.txtsuss.Text)
        'decRetencion_iva = CDec(Me.txtretencion_iva.Text)
        'decImp_ganancia = CDec(Me.txtimpuesto_ganancia.Text)

        'Me.txtTotalCheque.Text = CStr(decTotal)
        'decRet_cheques = decTotal + decIngreso_bruto + decSuss + decRetencion_iva + decImp_ganancia
        'Me.txtRetenciones_cheques.Text = CStr(decRet_cheques)


    End Sub

    Private Sub dgv3_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgv3.CurrentCellChanged
        Try
            Me.lblid_pk_3.Text = CStr(Me.dgv3.Item(0, Me.dgv3.CurrentRow.Index).Value)
            Me.lblid_cheque_recibido_2.Text = CStr(Me.dgv3.Item("id_cheque_recibido", Me.dgv3.CurrentRow.Index).Value)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Botones_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnAgregar_3.Click, btnBorrar_3.Click, btnModificar_3.Click

        Dim btnTemp As New Button
        Dim frmDetalle As New frmDetalleRecibo_cliente_cheque_2 'VER!

        btnTemp = CType(sender, Button)
        Try
            Select Case btnTemp.Name
                Case "btnAgregar_3"
                    BanderaRecibo_cliente_cheque_2 = 1
                    Me.AddOwnedForm(frmDetalle)
                    oRecibo_cliente_cheque_2.Insertar()
                    frmDetalle.lblid_cliente.Text = Me.lblid_cliente.Text

                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                Case "btnModificar_3"
                    If Not IsNumeric(Me.lblid_pk_3.Text) Then
                        Exit Sub
                    End If
                    BanderaRecibo_cliente_cheque_2 = 2
                    Me.AddOwnedForm(frmDetalle)
                    oRecibo_cliente_cheque_2.Modificar(CInt(Me.lblid_pk_3.Text))
                    'frmDetalle.lblid_proveedor.Text = Me.lblid_proveedor.Text
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                    RefrescarGrilla_3()
                Case "btnBorrar_3"
                    If Not IsNumeric(Me.lblid_pk_3.Text) Then
                        Exit Sub
                    End If

                    If MessageBox.Show("Desea Realmente Eliminar el Registro ", "BORRAR", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                    = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If

                    'desarchivo el cheque
                    oChequeRecibido.ArchivarCheque(CInt(Me.lblid_cheque_recibido_2.Text), False)

                    oRecibo_cliente_cheque_2.Borrar(CInt(Me.lblid_pk_3.Text))
                    RefrescarGrilla_3()
                Case "btnAyuda"
                    'Process.Start(PathAyuda + "frmAbmRecibo_proveedor_cheque.avi")
                Case "btnSalir"
                    Me.Close()
            End Select
            'Me.txtBuscar.Text = ""
            'Me.txtBuscar.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Public Sub RefrescarGrilla_4()
        Dim odt As DataTable

        odt = oRecibo_cliente_ingreso_efectivo.GetAllPagoCliente_2(CInt(Me.lblid_pago_cliente.Text))
        Me.dgv4.DataSource = odt
        Me.dgv4.Columns(0).Visible = False
        Me.dgv4.Columns("id pago cliente").Visible = False
        Me.dgv4.Columns("id ingreso efectivo").Visible = False



    End Sub

    Private Sub dvg4_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv4.CurrentCellChanged
        Try
            Me.lblid_pk_4.Text = CStr(Me.dgv4.Item(0, Me.dgv4.CurrentRow.Index).Value)
            Me.lblid_ingreso_efectivo.Text = CStr(Me.dgv4.Item("id ingreso efectivo", Me.dgv4.CurrentRow.Index).Value)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BotonesIngresos_Click_4(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnAgregar_ingreso_efectivo.Click, btnModificar_ingreso_efectivo.Click, btnBorrar_ingreso_efectivo.Click
        Dim btnTemp As New Button
        Dim frmDetalle As New frmDetalleRecibo_cliente_ingreso_efectivo
        btnTemp = CType(sender, Button)
        Try
            Select Case btnTemp.Name
                Case "btnAgregar_ingreso_efectivo"
                    BanderaRecibo_cliente_ingreso_efectivo = 1
                    vgFormularioPadre = Me.Name
                    Me.AddOwnedForm(frmDetalle)
                    oRecibo_cliente_ingreso_efectivo.Insertar()
                    frmDetalle.lblid_cliente.Text = Me.lblid_cliente.Text
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                Case "btnModificar_ingreso_efectivo"
                    If Not IsNumeric(Me.lblid_pk_4.Text) Then
                        Exit Sub
                    End If
                    BanderaRecibo_cliente_ingreso_efectivo = 2
                    Me.AddOwnedForm(frmDetalle)
                    oRecibo_cliente_ingreso_efectivo.Modificar(CInt(Me.lblid_pk_4.Text))
                    frmDetalle.lblid_cliente.Text = Me.lblid_cliente.Text
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                    RefrescarGrilla_4()
                Case "btnBorrar_ingreso_efectivo"
                    If Not IsNumeric(Me.lblid_pk_4.Text) Then
                        Exit Sub
                    End If

                    If MessageBox.Show("Desea Realmente Eliminar el Registro ", "BORRAR", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                    = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If

                    'desarchivo INGRESO EN EFECTIVO!
                    oIngreso_efectivo.Archivar_ingreso(CInt(Me.lblid_ingreso_efectivo.Text), False)

                    oRecibo_cliente_ingreso_efectivo.Borrar(CInt(Me.lblid_pk_4.Text))
                    RefrescarGrilla_4()
                    'Case "btnAyuda"
                    '    'Process.Start(PathAyuda + "frmAbmIngreso_efectivo.avi")
                    'Case "btnSalir"
                    '    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
