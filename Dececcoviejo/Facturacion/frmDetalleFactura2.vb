Public Class frmDetalleFactura2

    Dim strTipoFactura As String = ""

    Private Sub frmDetalleFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttCliente.SetToolTip(Me.btnBuscaCliente, "Buscar Nuevo Cliente")
        Me.ttGuardar.SetToolTip(Me.btnGuardar, "Guardar Datos de la Factura")
        Me.ttSalir.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Me.ttImprimir.SetToolTip(Me.btnImprimir, "Imprimir la Factura")


        Try
            ObtenerDatos()

            Me.cmbCliente.Text = oCliente.GetOne_2(CInt(Me.lblid_cliente.Text)).Rows(0).Item("nombre_Cliente").ToString.Trim
            Me.cmbMoneda.Text = oMoneda.GetOne(CInt(Me.lblid_moneda.Text)).Rows(0).Item("nombre moneda").ToString.Trim
        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try

        If BanderaFactura = 1 Then
            Me.LimpiarControles()
        Else
            If CType(Me.Owner, frmAbmFactura).lblEstado_libro.Text = "CERRADO" Then
                Me.dtpFecha.Enabled = False
            End If
        End If
        oCuerpo_factura.Cargar()

        Me.lblid_factura.Text = CType(Me.Owner, frmAbmFactura).lblid_pk.Text
        Dim odt As DataTable
        odt = oCuerpo_factura.ConsultarTodo_2(CInt(lblid_factura.Text))

        Try
            Me.Totales()
        Catch ex As Exception

        End Try


        Me.Text = "Factura" & vgNombreFormulario
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False
    End Sub

    Sub CargarCombos()
        Me.CargarCliente()
        Me.CargarMoneda()
    End Sub

    Sub CargarCliente()
        Dim odt As New DataTable

        odt = oCliente.GetCmb_2
        With Me.cmbCliente
            .DataSource = odt
            .DisplayMember = "nombre_Cliente"
            .ValueMember = "id_Cliente"
        End With
        If Me.cmbCliente.SelectedIndex >= 0 Then
            cmbCliente.SelectedIndex = 0
            Me.lblid_cliente.Text = cmbCliente.SelectedValue.ToString
        End If
    End Sub

    Sub CargarMoneda()
        Dim odt As New DataTable

        odt = oMoneda.GetCmb
        With Me.cmbMoneda
            .DataSource = odt
            .DisplayMember = "nombre_moneda"
            .ValueMember = "id_moneda"
        End With
        If Me.cmbMoneda.SelectedIndex >= 0 Then
            cmbMoneda.SelectedIndex = 0
            Me.lblid_Moneda.Text = cmbMoneda.SelectedValue.ToString
        End If
    End Sub

    Sub LimpiarControles()
        Dim CadenaTemp As String
        CadenaTemp = oFactura.GetTop()
        If CadenaTemp.Length = 12 Then
            Me.txtNumero_factura_1.Text = CadenaTemp.Substring(0, 4)
            Me.txtNumero_factura_2.Text = CadenaTemp.Substring(4, 8)
        End If

        Me.lblid_cliente.Text = "0"
        Me.cmbCliente.Text = ""
        Me.lblid_pk.Text = "0"
        Me.lblid_factura.Text = "1"
        ' Me.txtNumero_factura_1.Text = ""
        ' Me.txtNumero_factura_2.Text = ""
        Me.dtpFecha_factura.Value = DateTime.Now
        Me.txtIva_factura.Text = "21"
        Me.txtSubtotal.Text = ""
        Me.txtIva.Text = ""
        Me.txtTotal.Text = ""
        Me.txtTipo.Text = "AA"
        Me.txtCondicion_pago.Text = ""
        Me.txtReferencia.Text = ""

        Me.txtCantidad_item.Text = ""
        Me.txtPrecio_item.Text = ""
        Me.txtDescripcion_item.Text = ""
        Me.txtImporte.Text = ""
        Me.txtTotal_letra.Text = ""

        Me.rbnFactura.Checked = True
        Me.rbnNC.Checked = False
        Me.rbnND.Checked = False

        Me.rbnResponsable_inscripto.Checked = True
        Me.rbnResponsable_no_inscripto.Checked = False

        Me.rbnContado.Checked = True
        Me.rbnCuenta_corriente.Checked = False
        Me.rbnTarjeta.Checked = False
        Me.rbnCheque.Checked = False

        Me.txtImpuesto.Text = "0"
        Me.txtNumero_remito_1.Text = ""
        Me.txtNumero_remito_2.Text = ""

        ''
        'agregado
        Me.rbnRetencion.Checked = False
        Me.txtRetencion.Text = "0"

        'agregado
        Me.dtpFechaVen.Value = DateTime.Now
        Me.txt_certificado.Text = ""
        Me.dtpFecha.Value = DateTime.Now


        Me.lblid_moneda.Text = "0"
        Me.cmbMoneda.Text = ""
    End Sub

    Private Sub ObtenerDatos()
        Me.lblid_cliente.Text = CStr(oFactura.id_cliente)

        If oFactura.numero_factura.Length <> 12 Then
            'Exit Sub
        Else
            Me.txtNumero_factura_1.Text = oFactura.numero_factura.Substring(0, 4)
            Me.txtNumero_factura_2.Text = oFactura.numero_factura.Substring(4, 8)
        End If

        Me.dtpFecha_factura.Value = oFactura.fecha_factura
        Me.txtIva_factura.Text = oFactura.iva_factura.ToString.Trim
        Me.txtTipo.Text = oFactura.tipo_factura


        'detalle
        Me.txtCantidad_item.Text = CStr(oCuerpo_factura.cantidad_item)
        Me.txtDescripcion_item.Text = oCuerpo_factura.descripcion_item
        Me.txtPrecio_item.Text = CStr(oCuerpo_factura.precio_item)

        Try
            Me.txtTotal_letra.Text = oFactura.total_letra
        Catch ex As Exception

        End Try

        If oFactura.movimiento.Trim = "Factura" Then
            Me.rbnFactura.Checked = True
        ElseIf oFactura.movimiento.Trim = "Nota de Crédito" Then
            Me.rbnNC.Checked = True
        ElseIf oFactura.movimiento.Trim = "Nota de Débito" Then
            Me.rbnND.Checked = True
        ElseIf oFactura.movimiento.Trim = "Retencion" Then
            Me.rbnRetencion.Checked = True
        End If

        If oFactura.responsable_inscripto = True Then
            Me.rbnResponsable_inscripto.Checked = True
            Me.rbnResponsable_no_inscripto.Checked = False
        ElseIf oFactura.responsable_no_inscripto = True Then
            Me.rbnResponsable_inscripto.Checked = False
            Me.rbnResponsable_no_inscripto.Checked = True
        End If

        If oFactura.contado = True Then
            Me.rbnContado.Checked = True
            Me.rbnCuenta_corriente.Checked = False
            Me.rbnTarjeta.Checked = False
            Me.rbnCheque.Checked = False
        ElseIf oFactura.cuenta_corriente = True Then
            Me.rbnContado.Checked = False
            Me.rbnCuenta_corriente.Checked = True
            Me.rbnTarjeta.Checked = False
            Me.rbnCheque.Checked = False
        ElseIf oFactura.cuenta_corriente = True Then
            Me.rbnContado.Checked = False
            Me.rbnCuenta_corriente.Checked = False
            Me.rbnTarjeta.Checked = True
            Me.rbnCheque.Checked = False
        ElseIf oFactura.cuenta_corriente = True Then
            Me.rbnContado.Checked = False
            Me.rbnCuenta_corriente.Checked = False
            Me.rbnTarjeta.Checked = False
            Me.rbnCheque.Checked = True
        End If
        Me.txtImpuesto.Text = CStr(oFactura.impuesto)
        '''
        ''agregado para retenciones
        Me.txtRetencion.Text = oFactura.retencion_iva.ToString.Trim
        Me.txtNro_Item.Text = oCuerpo_factura.nro_item.ToString.Trim

        'agregado
        Me.txt_certificado.Text = oFactura.numero_certificado.Trim
        Me.dtpFechaVen.Value = oFactura.fecha_vencimiento
        Me.dtpFecha.Value = oFactura.fecha


        Me.txtCondicion_pago.Text = oFactura.condicion_pago.Trim
        Me.txtReferencia.Text = oFactura.referencia.Trim

        If oFactura.numero_recibo.Length <> 12 Then
            'Exit Sub
        Else
            Me.txtNumero_remito_1.Text = oFactura.numero_recibo.Substring(0, 4)
            Me.txtNumero_remito_2.Text = oFactura.numero_recibo.Substring(4, 8)
        End If

        Me.lblid_moneda.Text = CStr(oFactura.id_moneda)
    End Sub

    Private Sub AsignarDatos()
        oFactura.id_cliente = CInt(Me.lblid_cliente.Text)
        oFactura.numero_factura = Me.txtNumero_factura_1.Text & Me.txtNumero_factura_2.Text
        oFactura.fecha_factura = Me.dtpFecha_factura.Value.Date
        oFactura.iva_factura = CDec(Me.txtIva_factura.Text)
        oFactura.anulada = False
        oFactura.subtotal_factura = CDec(Me.txtSubtotal.Text)
        oFactura.tipo_factura = Me.txtTipo.Text

        oFactura.total_iva = CDec(Me.txtIva.Text)
        oFactura.total_factura = CDec(Me.txtTotal.Text)

        Dim Total As Decimal = CDec(Me.txtTotal.Text)
        oFactura.total_letra = Numalet.ToCardinal(Total)

        If Me.rbnFactura.Checked Then
            strTipoFactura = "Factura"
        ElseIf Me.rbnNC.Checked Then
            strTipoFactura = "Nota de Crédito"
        ElseIf Me.rbnND.Checked Then
            strTipoFactura = "Nota de Débito"
        ElseIf Me.rbnRetencion.Checked Then
            strTipoFactura = "Retencion"
        End If
        oFactura.movimiento = strTipoFactura

        'campos contado
        If Me.rbnContado.Checked Then
            oFactura.contado = True
            oFactura.cuenta_corriente = False
            oFactura.Tarjeta = False
            oFactura.Cheque = False
        ElseIf Me.rbnCuenta_corriente.Checked Then
            oFactura.contado = False
            oFactura.cuenta_corriente = True
            oFactura.Tarjeta = False
            oFactura.Cheque = False
        ElseIf Me.rbnCuenta_corriente.Checked Then
            oFactura.contado = False
            oFactura.cuenta_corriente = False
            oFactura.Tarjeta = True
            oFactura.Cheque = False
        ElseIf Me.rbnCuenta_corriente.Checked Then
            oFactura.contado = False
            oFactura.cuenta_corriente = False
            oFactura.Tarjeta = False
            oFactura.Cheque = True
        End If
        'campos responsable inscripto
        If Me.rbnResponsable_inscripto.Checked Then
            oFactura.responsable_inscripto = True
            oFactura.responsable_no_inscripto = False
            oFactura.total_iva = CDec(Me.txtIva.Text)
            oFactura.iva_no_inscripto = 0
        ElseIf Me.rbnResponsable_no_inscripto.Checked Then
            oFactura.responsable_inscripto = False
            oFactura.responsable_no_inscripto = True
            oFactura.total_iva = 0
            oFactura.iva_no_inscripto = CDec(Me.txtIva.Text)
        End If

        If Me.txtNumero_remito_1.Text = "" Or Me.txtNumero_remito_2.Text = "" Then
        Else
            oFactura.numero_recibo = Me.txtNumero_remito_1.Text & Me.txtNumero_remito_2.Text
        End If
        oFactura.impuesto = CDec(Me.txtImpuesto.Text)
        oFactura.condicion_pago = Me.txtCondicion_pago.Text
        oFactura.referencia = Me.txtReferencia.Text

        'agregado para retencion
        oFactura.retencion_iva = CDec(Me.txtRetencion.Text)

        'agregado
        oFactura.fecha_vencimiento = Me.dtpFechaVen.Value.Date
        oFactura.numero_certificado = txt_certificado.Text
        oFactura.fecha = Me.dtpFecha.Value.Date

        oFactura.id_moneda = CInt(Me.lblid_moneda.Text)
    End Sub

    Public Sub SoloLectura()
        Me.cmbCliente.Enabled = False
        Me.btnBuscaCliente.Enabled = False
        Me.txtNumero_factura_1.Enabled = False
        Me.txtNumero_factura_2.Enabled = False
        Me.dtpFecha_factura.Enabled = False
        Me.txtIva_factura.Enabled = False
        '  Me.anulada.Enabled = False
        Me.txtCondicion_pago.Enabled = False
        Me.txtReferencia.Enabled = False
        Me.btnGuardar.Visible = False
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()

            Dim odtDup As New DataTable
            If strTipoFactura = "Retencion" Then
                odtDup = oFactura.GetExist1(CInt(Me.lblid_cliente.Text), Me.txtNumero_factura_1.Text & Me.txtNumero_factura_2.Text, strTipoFactura)
                If odtDup.Rows.Count > 0 And BanderaFactura = 1 Then
                    MessageBox.Show("Sr. Usuario el Comprobante ya Existe")
                    Exit Sub
                End If
            Else
                odtDup = oFactura.GetExist(CInt(Me.lblid_cliente.Text), Me.txtNumero_factura_1.Text & Me.txtNumero_factura_2.Text, strTipoFactura)
                If odtDup.Rows.Count > 0 And BanderaFactura = 1 Then
                    MessageBox.Show("Sr. Usuario el Comprobante ya Existe")
                    Exit Sub
                End If
            End If
            Select Case BanderaFactura
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oFactura.Guardar()

                    Me.lblid_factura.Text = CStr(oFactura.id_factura)

                    oCuerpo_factura.Insertar()
                    oCuerpo_factura.id_factura = oFactura.id_factura 'Me.lblid_factura.Text
                    oCuerpo_factura.id_item = 1 'me.lblid_item.Text
                    oCuerpo_factura.nro_item = CInt(Me.txtNro_Item.Text)
                    oCuerpo_factura.cantidad_item = CDec(Me.txtCantidad_item.Text)
                    oCuerpo_factura.precio_item = CDec(Me.txtPrecio_item.Text)
                    oCuerpo_factura.descripcion_item = Me.txtDescripcion_item.Text.Trim
                    oCuerpo_factura.Guardar()

                    '   oCuerpo_factura.UpdateFactura(Me.lblid_factura.Text)

                    CType(Me.Owner, frmAbmFactura).RefrescarGrilla()
                    parametro_fac = CInt(Me.lblid_factura.Text)
                    ' Me.CargarCombos()
                    oFactura.Insertar()

                    'Me.ObtenerDatos()
                    ' Me.LimpiarControles()

                    ' Me.cmbCliente.Focus()
                    Me.btnImprimir.Enabled = True
                    Me.btnNuevo.Enabled = True
                    Me.btnGuardar.Enabled = False

                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oFactura.Guardar()
                    'oCuerpo_factura.Insertar()
                    oCuerpo_factura.id_factura = oFactura.id_factura 'Me.lblid_factura.Text
                    'oCuerpo_factura.id_item = 1 'me.lblid_item.Text
                    oCuerpo_factura.nro_item = CInt(Me.txtNro_Item.Text)
                    oCuerpo_factura.cantidad_item = CDec(Me.txtCantidad_item.Text)
                    oCuerpo_factura.precio_item = CDec(Me.txtPrecio_item.Text)
                    oCuerpo_factura.descripcion_item = Me.txtDescripcion_item.Text.Trim
                    oCuerpo_factura.Guardar()

                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If Me.txtNumero_factura_1.Text = "" Or Me.txtNumero_factura_2.Text = "" Or _
        Me.txtCantidad_item.Text = "" Or Me.txtNro_Item.Text = "" Or Me.txtImpuesto.Text = "" Or _
        Me.txtDescripcion_item.Text = "" Or Me.txtPrecio_item.Text = "" Or Me.txtIva_factura.Text = "" _
        Or Me.txt_certificado.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean

        If Me.lblid_cliente.Text = "0" Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de cliente")
            Exit Sub
        End If
        If CDbl(Me.lblid_moneda.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de moneda")
            Exit Sub
        End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar Todos los Campos")
            Exit Sub
        Else
            If BanderaFactura = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If

        End If
        'LimpiarControles()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cmbCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCliente.SelectedIndexChanged

        If Me.cmbCliente.SelectedIndex >= 0 Then
            Me.lblid_cliente.Text = cmbCliente.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaCliente.Click
        Dim frmTemporal As New frmAbmCliente
        frmTemporal.ShowDialog()
        Me.CargarCliente()
        Me.cmbCliente.Focus()
        Me.cmbCliente.Text = ""
        Me.lblid_Cliente.Text = "0"
    End Sub

    Private Sub cmbMoneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMoneda.SelectedIndexChanged
        If Me.cmbMoneda.SelectedIndex >= 0 Then
            Me.lblid_moneda.Text = cmbMoneda.SelectedValue.ToString
        End If
    End Sub

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtNumero_factura_1.KeyPress, txtNumero_factura_2.KeyPress, _
    txtNumero_remito_1.KeyPress, txtNumero_remito_2.KeyPress
        Dim txtTemp As New TextBox
        txtTemp = CType(sender, TextBox)

        If e.KeyChar.ToString = vbCr Then
            If txtTemp.Name = "txtNumero_factura_1" Then
                Me.txtNumero_factura_1.Text = CompletarCeros(Me.txtNumero_factura_1.Text, 4)
            ElseIf txtTemp.Name = "txtNumero_factura_2" Then
                Me.txtNumero_factura_2.Text = CompletarCeros(Me.txtNumero_factura_2.Text, 8)
            ElseIf txtTemp.Name = "txtNumero_remito_1" Then
                Me.txtNumero_remito_1.Text = CompletarCeros(Me.txtNumero_remito_1.Text, 4)
            ElseIf txtTemp.Name = "txtNumero_remito_2" Then
                Me.txtNumero_remito_2.Text = CompletarCeros(Me.txtNumero_remito_2.Text, 8)
            End If
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If

        If (e.KeyChar.ToString >= "0" And e.KeyChar.ToString <= "9") Or e.KeyChar = vbBack Then
            '  e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles cmbCliente.KeyDown, dtpFecha_factura.KeyDown, cmbMoneda.KeyDown
        If e.KeyValue = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtIva_factura.KeyPress, txtCantidad_item.KeyPress, txtPrecio_item.KeyPress, _
    txtImpuesto.KeyPress, txtRetencion.KeyPress
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

    Private Sub TabulacionTextBox_2(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtDescripcion_item.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.LimpiarControles()
        Me.cmbCliente.Focus()

        Me.btnImprimir.Enabled = False
        Me.btnNuevo.Enabled = False
        Me.btnGuardar.Enabled = True
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'Dim frmimpresiontemporal As New FrmReporteFactura

        'Try
        '    Select Case CInt(Me.lblid_moneda.Text)
        '        Case 1 'peso
        '            Banderaprintpantalla = "factura"
        '        Case 2 'dolar
        '            Banderaprintpantalla = "factura_dolar"
        '        Case 3 'euro
        '    End Select

        '    frmimpresiontemporal.ShowDialog()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try


    End Sub


    Public Sub Totales()
        'calculo de totales
        Me.txtSubtotal.Text = FormatCurrency(CDec(Me.txtCantidad_item.Text) * CDec(Me.txtPrecio_item.Text))
        Me.txtImporte.Text = Me.txtSubtotal.Text
        Me.txtIva.Text = FormatCurrency((CDec(Me.txtSubtotal.Text) + CDec(Me.txtImpuesto.Text)) * CDec(Me.txtIva_factura.Text) / 100)
        Me.txtTotal.Text = FormatCurrency(CDec(Me.txtSubtotal.Text) + CDec(Me.txtIva.Text) + CDec(Me.txtImpuesto.Text))

        Dim Total As Decimal = CDec(Me.txtTotal.Text)

        Me.txtTotal_letra.Text = Numalet.ToCardinal(Total)
    End Sub

    Private Sub txtPrecio_item_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles txtPrecio_item.LostFocus, txtCantidad_item.LostFocus, txtImpuesto.LostFocus, _
    txtIva_factura.LostFocus
        Try
            If Me.txtCantidad_item.Text = "" Or Me.txtPrecio_item.Text = "" Or Me.txtImpuesto.Text = "" Or Me.txtIva_factura.Text = "" Then
                Exit Sub
            End If
            Me.Totales()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rbnFactura_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnFactura.CheckedChanged
        Me.txtcomprobante.Text = "FACTURA"
    End Sub

    Private Sub rbnNC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnNC.CheckedChanged
        Me.txtcomprobante.Text = "NOTA DE CREDITO"
    End Sub

    Private Sub rbnND_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnND.CheckedChanged
        Me.txtcomprobante.Text = "NOTA DE DEBITO"
    End Sub

    Private Sub rbnRetencion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnRetencion.CheckedChanged
        Me.txtcomprobante.Text = "RETENCION"
    End Sub


End Class