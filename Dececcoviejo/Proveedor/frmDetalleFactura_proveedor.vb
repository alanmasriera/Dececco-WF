Public Class frmDetalleFactura_proveedor

    Dim BanderaCierreForm As Boolean = False

    Private Sub frmDetalleFactura_proveedor_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If BanderaCierreForm = False Then
            e.Cancel = True
        End If
    End Sub

    Private Sub frmDetalleFactura_proveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttGeneral.SetToolTip(Me.btnBuscaFactura, "En caso de cargar una NC buscar la factura para hacer la referencia")
        Me.ttGeneral.SetToolTip(Me.txtReferencia, "En caso de cargar una NC buscar la factura para hacer la referencia")

        Try
            ObtenerDatosFactura()

            '  Me.cmbtipo_factura.Text = oTipo_factura.GetOne(CInt(Me.lblid_tipo_factura.Text)).Rows(0).Item("nombre_Tipo_factura").ToString.Trim
            Me.cmbProveedor.Text = oProveedor.GetOne(CInt(Me.lblid_proveedor.Text)).Rows(0).Item("nombre Proveedor").ToString.Trim
            '   Me.cmbUsuario.Text = oUsuario.GetOne(CInt(Me.lblid_Usuario.Text)).Rows(0).Item("nombre Usuario").ToString.Trim
            Me.cmbtipo_comprobante.Text = oTipo_comprobante.GetOne(CInt(Me.lblid_tipo_comprobante.Text)).Rows(0).Item("nombre Tipo comprobante").ToString.Trim

        Catch ex As Exception
            '    Errores(ex)
        End Try
        Me.lblid_usuario.Text = vgCodigoUsuario.ToString

        Me.lblid_factura_proveedor.Text = CType(Me.Owner, frmAbmFactura_proveedor).lblid_pk.Text
        Me.lblid_empresa.Text = CType(Me.Owner, frmAbmFactura_proveedor).lblid_empresa.Text
        Me.lblid_proveedor.Text = CType(Me.Owner, frmAbmFactura_proveedor).lblid_proveedor.Text
        Me.dtpfecha.Value = CType(Me.Owner, frmAbmFactura_proveedor).dtpPeriodo.Value

        Me.cmbEmpresa.Text = CType(Me.Owner, frmAbmFactura_proveedor).cmbEmpresa.Text
        Me.cmbProveedor.Text = CType(Me.Owner, frmAbmFactura_proveedor).cmbProveedor.Text

        'agregado
        Me.dtpPeriodo.Value = CType(Me.Owner, frmAbmFactura_proveedor).dtpPeriodo.Value

        If BanderaFactura_proveedor = 1 Then
            Me.LimpiarControlesFactura()
        Else
            If CType(Me.Owner, frmAbmFactura_proveedor).lblEstado_libro.Text = "CERRADO" Then
                Me.dtpfecha.Enabled = False
            End If
        End If
        Me.CancelButton = Me.btnSalir

        Dim odt As DataTable
        odt = oCuerpo_factura_proveedor.Cargar()

        'odt = oNota_pedido.Cargar
        'oNota_pedido.Insertar()



        RefrescarGrillaCuerpoFactura()
        'Me.RefrescarGrillaNPPendiente()
        'Me.RefrescarGrillaFacturaPendiente()
    End Sub

    'Sub RefrescarGrillaNPPendiente()
    '    Dim odt As DataTable

    '    odt = oNota_pedido.GetAllEstado(CInt(Me.lblid_empresa.Text), CInt(Me.lblid_proveedor.Text), CChar("E"))
    '    Me.dgvNP_pendiente.DataSource = odt
    '    Me.dgvNP_pendiente.Columns(0).Visible = False
    'End Sub

    'Sub RefrescarGrillaFacturaPendiente()
    '    Dim odt As DataTable

    '    odt = oFactura_proveedor.GetAllEstado(CInt(Me.lblid_empresa.Text), CInt(Me.lblid_proveedor.Text), CChar("I"))
    '    Me.dgvFacturaPendiente.DataSource = odt
    '    Me.dgvFacturaPendiente.Columns(0).Visible = False
    'End Sub

    Sub CargarCombosFactura()
        ' Me.CargarTipo_factura()
        Me.CargarTipo_comprobante()
        Me.CargarProveedor()
        Me.CargarEmpresa()
        ' Me.CargarAlmacen()
    End Sub

    Sub CargarTipo_comprobante()
        Dim odt As New DataTable

        odt = oTipo_comprobante.GetCmb
        With Me.cmbtipo_comprobante
            .DataSource = odt
            .DisplayMember = "nombre_Tipo_comprobante"
            .ValueMember = "id_Tipo_comprobante"
        End With
        If Me.cmbtipo_comprobante.SelectedIndex >= 0 Then
            cmbtipo_comprobante.SelectedIndex = 0
            Me.lblid_tipo_comprobante.Text = cmbtipo_comprobante.SelectedValue.ToString
        End If
    End Sub

    'Sub CargarTipo_factura()
    '    Dim odt As New DataTable

    '    odt = oTipo_factura.GetCmb
    '    With Me.cmbtipo_factura
    '        .DataSource = odt
    '        .DisplayMember = "abreviatura"
    '        .ValueMember = "id_Tipo_factura"
    '    End With
    '    If Me.cmbtipo_factura.SelectedIndex >= 0 Then
    '        cmbtipo_factura.SelectedIndex = 0
    '        Me.lblid_tipo_factura.Text = cmbtipo_factura.SelectedValue.ToString
    '    End If
    'End Sub

    Sub CargarProveedor()
        Dim odt As New DataTable

        odt = oProveedor.GetCmb
        With Me.cmbProveedor
            .DataSource = odt
            .DisplayMember = "nombre_Proveedor"
            .ValueMember = "id_Proveedor"
        End With
        If Me.cmbProveedor.SelectedIndex >= 0 Then
            cmbProveedor.SelectedIndex = 0
            Me.lblid_proveedor.Text = cmbProveedor.SelectedValue.ToString
        End If
    End Sub

    Sub CargarEmpresa()
        Dim odt As New DataTable

        odt = oEmpresa.GetCmb
        With Me.cmbEmpresa
            .DataSource = odt
            .DisplayMember = "nombre_Empresa"
            .ValueMember = "id_Empresa"
        End With
        If Me.cmbEmpresa.SelectedIndex >= 0 Then
            cmbEmpresa.SelectedIndex = 0
            Me.lblid_empresa.Text = cmbEmpresa.SelectedValue.ToString
        End If
    End Sub

    'Sub CargarAlmacen()
    '    Dim odt As New DataTable

    '    odt = oAlmacen.GetCmb
    '    With Me.cmbAlmacen
    '        .DataSource = odt
    '        .DisplayMember = "nombre_Almacen"
    '        .ValueMember = "id_Almacen"
    '    End With
    '    If Me.cmbAlmacen.SelectedIndex >= 0 Then
    '        cmbAlmacen.SelectedIndex = 0
    '        Me.lblid_Almacen.Text = cmbAlmacen.SelectedValue.ToString
    '    End If
    'End Sub

    Sub LimpiarControlesFactura()
        Me.lblid_factura_proveedor.Text = "0"
        Me.txtNumero_4.Text = ""
        Me.txtNumero_8.Text = ""
        'Me.lblid_empresa.Text = "0"
        'Me.cmbEmpresa.Text = ""
        Me.lblid_tipo_comprobante.Text = "0"
        Me.cmbtipo_comprobante.Text = ""
        'Me.lblid_tipo_factura.Text = "0"
        'Me.cmbtipo_factura.Text = ""
        'Me.dtpfecha.Value = DateTime.Now
        Me.dtpfecha_factura.Value = DateTime.Now
        Me.dtpfecha_vencimiento.Value = DateTime.Now
        'Me.lblid_proveedor.Text = "0"
        'Me.cmbProveedor.Text = ""
        Me.txtObservacion.Text = ""
        Me.txtSaldo.Text = ""
        Me.txtEstado.Text = "I"
        Me.txtalicuota_iva.Text = "0"
        Me.txtiva_21.Text = "0"
        Me.txtiva_10_5.Text = "0"
        Me.txtimporte_21.Text = "0"
        Me.txtimporte_10_5.Text = "0"
        Me.txtretencion_iva.Text = "0"
        Me.txtpercepcion_iva.Text = "0"
        Me.txtretencion_ingreso_bruto.Text = "0"
        Me.txtpercepcion_ingreso_bruto.Text = "0"
        Me.txtretencion_ganancia.Text = "0"
        Me.txttotal_21.Text = "0"
        Me.txttotal_10_5.Text = "0"
        Me.txttotal_sin.Text = "0"
        Me.txtTotal_factura.Text = "0"


        'seteo variable unica
        Me.lblid_almacen.Text = "1"

        Me.txtImpuesto_interno.Text = "0"
        Me.txtOtro.Text = "0"
        'Me.lblid_usuario.Text = "0"
        'Me.cmbusuario.Text = ""
        'Me.chkTilde.Checked = False

        'agregado para certificado
        Me.txtCertificado.Text = "0"
        lblid_certificado.Text = "0"
        Me.chkPago_a_cuenta.Checked = False
        Me.chkFactura_paga.Checked = False
    End Sub

    Private Sub ObtenerDatosFactura()
        If oFactura_proveedor.numero_factura.Length = 12 Then
            Me.txtNumero_4.Text = oFactura_proveedor.numero_factura.Substring(0, 4)
            Me.txtNumero_8.Text = oFactura_proveedor.numero_factura.Substring(4, 8)
        End If

        'Me.txtnumero_factura.Text = oFactura_proveedor.numero_factura.Trim
        'Me.lblid_empresa.Text = oFactura_proveedor.id_empresa.ToString
        Me.lblid_tipo_comprobante.Text = oFactura_proveedor.id_tipo_comprobante.ToString
        ' Me.lblid_tipo_factura.Text = oFactura_proveedor.id_tipo_factura.ToString
        Me.dtpfecha.Value = oFactura_proveedor.fecha
        Me.dtpfecha_factura.Value = oFactura_proveedor.fecha_factura
        Me.dtpfecha_vencimiento.Value = oFactura_proveedor.fecha_vencimiento
        Me.lblid_proveedor.Text = oFactura_proveedor.id_proveedor.ToString
        Me.txtObservacion.Text = oFactura_proveedor.observacion.Trim
        'Me.txtSaldo.Text = oFactura_proveedor.saldo.ToString.Trim
        Me.txtEstado.Text = oFactura_proveedor.estado.Trim
        Me.txtalicuota_iva.Text = oFactura_proveedor.alicuota_iva.ToString.Trim
        Me.txtiva_21.Text = oFactura_proveedor.iva_21.ToString.Trim
        Me.txtiva_10_5.Text = oFactura_proveedor.iva_10_5.ToString.Trim
        Me.txtimporte_21.Text = oFactura_proveedor.importe_21.ToString.Trim
        Me.txtimporte_10_5.Text = oFactura_proveedor.importe_10_5.ToString.Trim
        Me.txtretencion_iva.Text = oFactura_proveedor.retencion_iva.ToString.Trim
        Me.txtpercepcion_iva.Text = oFactura_proveedor.percepcion_iva.ToString.Trim
        Me.txtretencion_ingreso_bruto.Text = oFactura_proveedor.retencion_ingreso_bruto.ToString.Trim
        Me.txtpercepcion_ingreso_bruto.Text = oFactura_proveedor.percepcion_ingreso_bruto.ToString.Trim
        Me.txtretencion_ganancia.Text = oFactura_proveedor.retencion_ganancia.ToString.Trim
        Me.txttotal_21.Text = oFactura_proveedor.total_21.ToString.Trim
        Me.txttotal_10_5.Text = oFactura_proveedor.total_10_5.ToString.Trim
        Me.txttotal_sin.Text = oFactura_proveedor.total_sin.ToString.Trim
        Me.txtTotal_factura.Text = oFactura_proveedor.total_factura.ToString.Trim
        'Me.lblid_usuario.Text = oFactura_proveedor.id_usuario.ToString
        Me.chkTilde.Checked = oFactura_proveedor.tilde
        Me.lblid_almacen.Text = oFactura_proveedor.id_almacen.ToString
        Me.txtImpuesto_interno.Text = oFactura_proveedor.impuesto_interno.ToString
        Me.txtOtro.Text = oFactura_proveedor.otro.ToString

        'agregado para el certificado
        'Me.txtCertificado.Text = oFactura_proveedor.numero_certificado.ToString
        Me.chkPago_a_cuenta.Checked = oFactura_proveedor.pago_a_cuenta
        Me.chkFactura_paga.Checked = oFactura_proveedor.pagada
    End Sub

    Private Sub AsignarDatosFactura()
        oFactura_proveedor.numero_factura = Me.txtNumero_4.Text & Me.txtNumero_8.Text
        oFactura_proveedor.id_empresa = CInt(Me.lblid_empresa.Text)
        oFactura_proveedor.id_tipo_comprobante = CInt(Me.lblid_tipo_comprobante.Text)
        ' oFactura_proveedor.id_tipo_factura = CInt(Me.lblid_tipo_factura.Text)
        oFactura_proveedor.fecha = Me.dtpfecha.Value.Date
        oFactura_proveedor.fecha_factura = Me.dtpfecha_factura.Value.Date
        oFactura_proveedor.fecha_vencimiento = Me.dtpfecha_vencimiento.Value.Date
        oFactura_proveedor.id_proveedor = CInt(Me.lblid_proveedor.Text)
        oFactura_proveedor.observacion = Me.txtObservacion.Text
        oFactura_proveedor.alicuota_iva = CDec(Me.txtalicuota_iva.Text)
        oFactura_proveedor.iva_21 = CDec(Me.txtiva_21.Text)
        oFactura_proveedor.iva_10_5 = CDec(Me.txtiva_10_5.Text)
        oFactura_proveedor.importe_21 = CDec(Me.txtimporte_21.Text)
        oFactura_proveedor.importe_10_5 = CDec(Me.txtimporte_10_5.Text)
        oFactura_proveedor.retencion_iva = CDec(Me.txtretencion_iva.Text)
        oFactura_proveedor.percepcion_iva = CDec(Me.txtpercepcion_iva.Text)
        oFactura_proveedor.retencion_ingreso_bruto = CDec(Me.txtretencion_ingreso_bruto.Text)
        oFactura_proveedor.percepcion_ingreso_bruto = CDec(Me.txtpercepcion_ingreso_bruto.Text)
        oFactura_proveedor.retencion_ganancia = CDec(Me.txtretencion_ganancia.Text)
        oFactura_proveedor.total_21 = CDec(Me.txttotal_21.Text)
        oFactura_proveedor.total_10_5 = CDec(Me.txttotal_10_5.Text)
        oFactura_proveedor.total_sin = CDec(Me.txttotal_sin.Text)
        oFactura_proveedor.total_factura = CDec(Me.txtTotal_factura.Text)
        oFactura_proveedor.sin_pago = False
        If BanderaFactura_proveedor = 1 Then
            oFactura_proveedor.saldo_factura = CDec(Me.txtTotal_factura.Text)
        End If

        oFactura_proveedor.id_usuario = vgCodigoUsuario
        oFactura_proveedor.tilde = Me.chkTilde.Checked
        oFactura_proveedor.estado = Me.txtEstado.Text
        oFactura_proveedor.id_almacen = CInt(Me.lblid_almacen.Text)
        oFactura_proveedor.impuesto_interno = CDec(Me.txtImpuesto_interno.Text)
        oFactura_proveedor.otro = CDec(Me.txtOtro.Text)

        'agregado para el certificado
        'oFactura_proveedor.numero_certificado = CInt(Me.txtCertificado.Text)
        oFactura_proveedor.pago_a_cuenta = Me.chkPago_a_cuenta.Checked
    End Sub

    Public Sub SoloLecturaFactura()
        Me.txtNumero_4.Enabled = False
        Me.txtNumero_8.Enabled = False
        Me.cmbEmpresa.Enabled = False
        Me.btnBuscaEmpresa.Enabled = False
        Me.cmbtipo_comprobante.Enabled = False
        'Me.btnBuscatipo_comprobante.Enabled = False
        ' Me.cmbtipo_factura.Enabled = False
        'Me.btnBuscatipo_factura.Enabled = False
        Me.dtpfecha.Enabled = False
        Me.dtpfecha_factura.Enabled = False
        Me.dtpfecha_vencimiento.Enabled = False
        Me.cmbProveedor.Enabled = False
        Me.btnBuscaProveedor.Enabled = False
        Me.txtObservacion.Enabled = False
        Me.txtSaldo.Enabled = False
        Me.txtEstado.Enabled = False
        Me.txtalicuota_iva.Enabled = False
        Me.txtiva_21.Enabled = False
        Me.txtiva_10_5.Enabled = False
        Me.txtimporte_21.Enabled = False
        Me.txtimporte_10_5.Enabled = False
        Me.txtretencion_iva.Enabled = False
        Me.txtpercepcion_iva.Enabled = False
        Me.txtretencion_ingreso_bruto.Enabled = False
        Me.txtpercepcion_ingreso_bruto.Enabled = False
        Me.txtretencion_ganancia.Enabled = False
        Me.txttotal_21.Enabled = False
        Me.txttotal_10_5.Enabled = False
        Me.txttotal_sin.Enabled = False
        Me.txtTotal_factura.Enabled = False
        'Me.cmbusuario.Enabled = False
        'Me.btnBuscausuario.Enabled = False
        Me.chkTilde.Enabled = False
        Me.btnGuardar.Visible = False
        Me.cmbAlmacen.Enabled = False
        Me.txtImpuesto_interno.Enabled = False
        Me.txtOtro.Enabled = False

        'agregado para numero de certificado
        Me.txtCertificado.Enabled = False
        Me.chkPago_a_cuenta.Enabled = False
    End Sub

    Private Sub GuardarFactura()
        Try
            Me.AsignarDatosFactura()
            If oFactura_proveedor.Exist() Then
                If BanderaFactura_proveedor = 1 Then
                    MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
                    Exit Sub
                ElseIf BanderaFactura_proveedor = 2 Then
                    If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                        = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            Select Case BanderaFactura_proveedor
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)

                    'agregado buscar si existe un cliente con ese numero de factura
                    Dim odt As New DataTable
                    odt = oFactura_proveedor.existe(CInt(lblid_proveedor.Text), CStr(txtNumero_4.Text & txtNumero_8.Text), CInt(lblid_tipo_comprobante.Text))
                    If odt.Rows.Count <> 0 Then
                        MsgBox("Se encontro una Factura con el mismo nombre de Proveedor,Numero de Factura y Tipo de Factura")
                        Exit Sub
                    Else
                        oFactura_proveedor.Guardar()

                        'actualizo el cuerpo con el id de la factura
                        Me.lblid_factura_proveedor.Text = oFactura_proveedor.id_factura_proveedor.ToString
                        oCuerpo_factura_proveedor.UpdateID(CInt(Me.lblid_factura_proveedor.Text))

                        If chkConStock.Checked = True Then
                            'es nota de credito
                            If Me.lblid_tipo_comprobante.Text = "6" Then
                                'descuento
                                oProducto.UpdateStockFacturaDescuento(CInt(Me.lblid_factura_proveedor.Text), CInt(Me.lblid_almacen.Text))
                            Else
                                'actualizo el stock de cada producto de la factura
                                oProducto.UpdateStockFacturaAgrego(CInt(Me.lblid_factura_proveedor.Text), CInt(Me.lblid_almacen.Text))
                            End If
                        End If

                        'actualizo el precio de cada producto de la factura
                        oCuerpo_factura_proveedor.UpdatePrecioNew(CInt(Me.lblid_factura_proveedor.Text))

                        'si queremos que arme un recibo automatico
                        If Me.chkFactura_paga.Checked = True Then
                            'agrego un recibo simultaneo

                            Dim var_id_recibo_proveedor As Integer
                            Dim var_id_egreso_efectivo As Integer
                            With oRecibo_proveedor
                                .Cargar()
                                .Insertar()
                                .id_proveedor = CInt(Me.lblid_proveedor.Text)
                                .fecha = Me.dtpfecha_factura.Value.Date
                                .pago = CDec(Me.txtTotal_factura.Text)
                                .detalle = ""
                                '.efectivo = Me.chkefectivo.Checked
                                '.numero_recibo = Me.txtnumero_recibo.Text
                                .numero_recibo = "000000000000"
                                .retencion_iva = 0
                                .ingreso_bruto = 0
                                .impuesto_ganancia = 0
                                .suss = 0
                                .Guardar()
                                var_id_recibo_proveedor = .id_recibo_proveedor
                            End With

                            With oEgreso_efectivo
                                .Cargar()
                                .Insertar()
                                .a_rendir = False
                                .archivado = True
                                .comprobante = CStr(1)
                                .control = True
                                .detalle = Me.txtObservacion.Text
                                .fecha = Me.dtpfecha_factura.Value.Date
                                .id_empresa = CInt(Me.lblid_empresa.Text)
                                .id_proveedor = CInt(Me.lblid_proveedor.Text)
                                .id_tipo_egreso = 1
                                .importe = CDec(Me.txtTotal_factura.Text)
                                .iva = 0
                                .Guardar()
                                var_id_egreso_efectivo = .id_egreso_efectivo
                            End With

                            With oEgreso_efectivo_proveedor
                                .Cargar()
                                .Insertar()
                                .control = True
                                .id_egreso_efectivo = var_id_egreso_efectivo
                                .id_recibo_proveedor = var_id_recibo_proveedor
                                .Guardar()
                            End With
                        Else
                            With oFactura_proveedor
                                .Cargar()
                                .Modificar(CInt(Me.lblid_factura_proveedor.Text))
                                .sin_pago = True
                                .Guardar()
                            End With
                        End If



                        CType(Me.Owner, frmAbmFactura_proveedor).RefrescarGrilla()
                        'Me.CargarCombosFactura()
                        oFactura_proveedor.Insertar()
                        'Me.ObtenerDatosFactura()
                        Me.LimpiarControlesFactura()
                        Me.txtNumero_4.Focus()

                        Me.lblid_factura_proveedor.Text = "0"
                        Me.RefrescarGrillaCuerpoFactura()




                        ' Me.RefrescarGrillaFacturaPendiente()
                    End If
                Case 2 'GUARDA Y SALE (MODIFICAR)

                    If chkConStock.Checked = True Then
                        'es nota de credito
                        If Me.lblid_tipo_comprobante.Text = "6" Then
                            'agrego
                            oProducto.UpdateStockFacturaAgrego(CInt(Me.lblid_factura_proveedor.Text), CInt(Me.lblid_almacen.Text))
                        Else
                            'descuento
                            oProducto.UpdateStockFacturaDescuento(CInt(Me.lblid_factura_proveedor.Text), CInt(Me.lblid_almacen.Text))
                        End If
                    End If

                    oFactura_proveedor.Guardar()

                    If chkConStock.Checked = True Then
                        'es nota de credito
                        If Me.lblid_tipo_comprobante.Text = "6" Then
                            'descuento
                            oProducto.UpdateStockFacturaDescuento(CInt(Me.lblid_factura_proveedor.Text), CInt(Me.lblid_almacen.Text))
                        Else
                            'agrego
                            oProducto.UpdateStockFacturaAgrego(CInt(Me.lblid_factura_proveedor.Text), CInt(Me.lblid_almacen.Text))
                        End If
                    End If

                    BanderaCierreForm = True
                    Me.Close()
            End Select
        Catch ex As Exception
            Errores(ex)
        End Try
    End Sub

    Private Function ChequearVaciosFactura() As Boolean
        Dim bandera As Boolean
        If Me.txtNumero_4.Text = "" Or Me.txtNumero_8.Text = "" Or Me.txtTotal_factura.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean

        If CDbl(Me.lblid_empresa.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de empresa")
            Exit Sub
        End If
        If CDbl(Me.lblid_tipo_comprobante.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de tipo_comprobante")
            Exit Sub
        End If
        'If CDbl(Me.lblid_tipo_factura.Text) = 0 Then
        '    MessageBox.Show("Debe Seleccionar un Dato del Combo de tipo_factura")
        '    Exit Sub
        'End If
        If CDbl(Me.lblid_proveedor.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de proveedor")
            Exit Sub
        End If
        If CDbl(Me.lblid_almacen.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de almacen")
            Exit Sub
        End If
        'If CDbl(Me.lblid_usuario.Text) = 0 Then
        '    MessageBox.Show("Debe Seleccionar un Dato del Combo de usuario")
        '    Exit Sub
        'End If

        If Me.dgvCuerpo_factura.RowCount <= 0 Then
            oCuerpo_factura_proveedor.InsertNinguno()
            'MessageBox.Show("No puede guardar una factura sin datos")
            'Exit Sub
        End If

        'se comento para permitir el importe igual a cero
        'If CDec(Me.txtTotal_factura.Text) <= 0 Then
        '    MessageBox.Show("No puede guardar una factura con importe = 0")
        '    Exit Sub
        'End If

        'agreado para el numero de certificado


        blnVacios = Me.ChequearVaciosFactura
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaFactura_proveedor = 1 Then
                Me.GuardarFactura()
            Else
                Me.GuardarFactura()
            End If
        End If
    End Sub

    Private Sub cmbEmpresa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEmpresa.SelectedIndexChanged
        If Me.cmbEmpresa.SelectedIndex >= 0 Then
            Me.lblid_empresa.Text = cmbEmpresa.SelectedValue.ToString
        End If
        If Not IsNumeric(Me.lblid_empresa.Text) Then
            Exit Sub
        End If
        Me.RefrescarGrillaCuerpoFactura()
        'Me.RefrescarGrillaNPPendiente()
        'Me.RefrescarGrillaFacturaPendiente()
    End Sub

    Private Sub btnBuscaEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaEmpresa.Click
        Dim frmTemporal As New frmAbmEmpresa
        frmTemporal.ShowDialog()
        Me.CargarEmpresa()
        Me.cmbEmpresa.Focus()
        Me.cmbEmpresa.Text = ""
        Me.lblid_empresa.Text = "0"
    End Sub

    Private Sub cmbTipo_comprobante_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtipo_comprobante.SelectedIndexChanged
        If Me.cmbtipo_comprobante.SelectedIndex >= 0 Then
            Me.lblid_tipo_comprobante.Text = cmbtipo_comprobante.SelectedValue.ToString
            Me.txtComprobante.Text = Me.cmbtipo_comprobante.Text
        End If
        'agregade en el caso de que sea NC
        If Me.txtComprobante.Text = "NC" Then
            Me.btnBuscaFactura.Enabled = True
            Me.txtReferencia.Enabled = False
            ' Me.btnGuardar.Enabled = False
        Else
            Me.btnBuscaFactura.Enabled = False
            Me.txtReferencia.Enabled = True
            ' Me.btnGuardar.Enabled = True
        End If
    End Sub

    'Private Sub btnBuscaTipo_comprobante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscatipo_comprobante.Click
    '    Dim frmTemporal As New FrmAbmTipo_comprobante
    '    frmTemporal.ShowDialog()
    '    Me.CargarTipo_comprobante()
    '    Me.cmbTipo_comprobante.Focus()
    '    Me.cmbTipo_comprobante.Text = ""
    '    Me.lblid_Tipo_comprobante.Text = "0"
    'End Sub

    'Private Sub cmbTipo_factura_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Me.cmbtipo_factura.SelectedIndex >= 0 Then
    '        Me.lblid_tipo_factura.Text = cmbtipo_factura.SelectedValue.ToString
    '    End If
    'End Sub

    'Private Sub btnBuscaTipo_factura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscatipo_factura.Click
    '    Dim frmTemporal As New FrmAbmTipo_factura
    '    frmTemporal.ShowDialog()
    '    Me.CargarTipo_factura()
    '    Me.cmbTipo_factura.Focus()
    '    Me.cmbTipo_factura.Text = ""
    '    Me.lblid_Tipo_factura.Text = "0"
    'End Sub

    Private Sub cmbProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProveedor.SelectedIndexChanged
        If Me.cmbProveedor.SelectedIndex >= 0 Then
            Me.lblid_proveedor.Text = cmbProveedor.SelectedValue.ToString
        End If
        If Not IsNumeric(Me.lblid_proveedor.Text) Then
            Exit Sub
        End If
        Me.RefrescarGrillaCuerpoFactura()
        'Me.RefrescarGrillaNPPendiente()
        'Me.RefrescarGrillaFacturaPendiente()
    End Sub

    Private Sub btnBuscaProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaProveedor.Click
        Dim frmTemporal As New frmAbmProveedor
        frmTemporal.ShowDialog()
        Me.CargarProveedor()
        Me.cmbProveedor.Focus()
        Me.cmbProveedor.Text = ""
        Me.lblid_proveedor.Text = "0"
    End Sub

    'Private Sub cmbAlmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAlmacen.SelectedIndexChanged
    '    If Me.cmbAlmacen.SelectedIndex >= 0 Then
    '        Me.lblid_almacen.Text = cmbAlmacen.SelectedValue.ToString
    '    End If
    'End Sub

    'Private Sub btnBuscaAlmacen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaAlmacen.Click
    '    Dim frmTemporal As New FrmAbmAlmacen
    '    frmTemporal.ShowDialog()
    '    Me.CargarAlmacen()
    '    Me.cmbAlmacen.Focus()
    '    Me.cmbAlmacen.Text = ""
    '    Me.lblid_Almacen.Text = "0"
    'End Sub

    Private Sub TabulacionTextBoxFactura(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtObservacion.KeyPress, txtEstado.KeyPress, chkTilde.KeyPress, chkPago_a_cuenta.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombosFactura(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles cmbEmpresa.KeyDown, cmbtipo_comprobante.KeyDown, dtpfecha.KeyDown, _
    dtpfecha_factura.KeyDown, dtpfecha_vencimiento.KeyDown, cmbProveedor.KeyDown, cmbAlmacen.KeyDown
        If CDbl(e.KeyValue.ToString) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub NumerosFactura(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtNumero_4.KeyPress, txtNumero_8.KeyPress
        Dim txtTemp As TextBox
        txtTemp = CType(sender, TextBox)

        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)

            If txtTemp.Name = "txtNumero_4" Then
                Me.txtNumero_4.Text = CompletarCeros(Me.txtNumero_4.Text, 4)
            End If
            If txtTemp.Name = "txtNumero_8" Then
                Me.txtNumero_8.Text = CompletarCeros(Me.txtNumero_8.Text, 8)
            End If
        End If

        If (e.KeyChar.ToString >= "0" And e.KeyChar.ToString <= "9") Or e.KeyChar = vbBack Then
            '  e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub


    Private Sub DecimalesFactura(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtSaldo.KeyPress, txtalicuota_iva.KeyPress, txtiva_21.KeyPress, txtiva_10_5.KeyPress, _
    txtimporte_21.KeyPress, txtimporte_10_5.KeyPress, txtretencion_iva.KeyPress, _
    txtpercepcion_iva.KeyPress, txtretencion_ingreso_bruto.KeyPress, txtpercepcion_ingreso_bruto.KeyPress, _
    txtretencion_ganancia.KeyPress, txttotal_21.KeyPress, txttotal_10_5.KeyPress, txttotal_sin.KeyPress, _
    txtTotal_factura.KeyPress, txtImpuesto_interno.KeyPress, txtOtro.KeyPress
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



















    'cuerpo de la factura
    '*******************************

    Public Sub RefrescarGrillaCuerpoFactura()
        Dim odt As DataTable

        odt = oCuerpo_factura_proveedor.GetAllFactura(CInt(Me.lblid_factura_proveedor.Text))
        Me.dgvCuerpo_factura.DataSource = odt
        Me.dgvCuerpo_factura.Columns(0).Visible = False

        Dim decTotal As Decimal = 0
        For Each row As DataRow In odt.Rows
            decTotal = decTotal + CDec(row.Item("Total"))
        Next
        Me.txtCalculado.Text = FormatCurrency(decTotal)
    End Sub

    Private Sub dgvCuerpo_factura_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvCuerpo_factura.CurrentCellChanged
        Try
            Me.lblid_cuerpo_factura.Text = CStr(Me.dgvCuerpo_factura.Item(0, Me.dgvCuerpo_factura.CurrentRow.Index).Value)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BotonesCuerpoFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnAgregarCF.Click, btnBorrarCF.Click, btnModificarCF.Click, btnSalir.Click
        Dim btnTemp As New Button
        Dim frmDetalle As New frmDetalleCuerpo_factura_proveedor
        btnTemp = CType(sender, Button)
        Try
            Select Case btnTemp.Name
                Case "btnAgregarCF"
                    BanderaCuerpo_factura_proveedor = 1
                    Me.AddOwnedForm(frmDetalle)
                    oCuerpo_factura_proveedor.Insertar()
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                Case "btnModificarCF"
                    If Not IsNumeric(Me.lblid_cuerpo_factura.Text) Then
                        Exit Sub
                    End If
                    BanderaCuerpo_factura_proveedor = 2
                    Me.AddOwnedForm(frmDetalle)
                    oCuerpo_factura_proveedor.Modificar(CInt(Me.lblid_cuerpo_factura.Text))
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                    RefrescarGrillaCuerpoFactura()
                Case "btnBorrarCF"
                    If Not IsNumeric(Me.lblid_cuerpo_factura.Text) Then
                        Exit Sub
                    End If

                    If MessageBox.Show("Desea Realmente Eliminar el Registro ", "BORRAR", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                    = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If

                    'borro del stock la cantidad que se elimina
                    oCuerpo_factura_proveedor.DeleteStockCuerpo(CInt(Me.lblid_cuerpo_factura.Text), CInt(Me.lblid_almacen.Text))

                    'borro el registro
                    oCuerpo_factura_proveedor.Borrar(CInt(Me.lblid_cuerpo_factura.Text))

                    RefrescarGrillaCuerpoFactura()
                Case "btnAyuda"
                    'Process.Start(PathAyuda + "frmAbmCuerpo_factura_proveedor.avi")
                Case "btnSalir"
                    BanderaCierreForm = True

                    'borro el cuerpo si la factura no se guardo
                    If Me.lblid_factura_proveedor.Text = "0" Then
                        oCuerpo_factura_proveedor.DeleteFactura(0)
                    End If

                    Me.Close()
            End Select
        Catch ex As Exception
            Errores(ex)
        End Try
    End Sub

    Private Sub txtNumero_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles txtNumero_4.LostFocus, txtNumero_8.LostFocus
        Dim txtTemp As New TextBox

        txtTemp = CType(sender, TextBox)

        Select Case txtTemp.Name
            Case "txtNumero_4"
                Me.txtNumero_4.Text = CompletarCeros(Me.txtNumero_4.Text, 4)
            Case "txtNumero_8"
                Me.txtNumero_8.Text = CompletarCeros(Me.txtNumero_8.Text, 8)
        End Select

        If txtTemp.Name = "txtNumero_4" Or txtTemp.Name = "txtNumero_8" Then
            If oFactura_proveedor.Exist_3((txtNumero_4.Text & txtNumero_8.Text), CInt(lblid_proveedor.Text)) Then
                MsgBox("Ya existe el numero de factura para el Proveedor seleccionado")

            End If
        End If

    End Sub








    'cuerpo de la nota de devolucion
    '*******************************



    'Private Sub BotonesND_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    Dim btnTemp As New Button
    '    Dim frmDetalle As New frmDetalleCuerpo_nota_devolucion
    '    btnTemp = CType(sender, Button)
    '    Try
    '        Select Case btnTemp.Name
    '            Case "btnAgregarND"
    '                BanderaCuerpo_nota_devolucion = 1
    '                Me.AddOwnedForm(frmDetalle)
    '                oCuerpo_nota_devolucion.Insertar()
    '                frmDetalle.CargarCombos()
    '                frmDetalle.ShowDialog()
    '            Case "btnModificarND"
    '                If Not IsNumeric(Me.lblid_cuerpo_nota_devolucion.Text) Then
    '                    Exit Sub
    '                End If
    '                BanderaCuerpo_nota_devolucion = 2
    '                Me.AddOwnedForm(frmDetalle)
    '                oCuerpo_nota_devolucion.Modificar(CInt(Me.lblid_cuerpo_nota_devolucion.Text))
    '                frmDetalle.CargarCombos()
    '                frmDetalle.ShowDialog()
    '                'RefrescarGrilla()
    '            Case "btnBorrarND"
    '                If Not IsNumeric(Me.lblid_cuerpo_nota_devolucion.Text) Then
    '                    Exit Sub
    '                End If

    '                If MessageBox.Show("Desea Realmente Eliminar el Registro ", "BORRAR", _
    '                MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
    '                = Windows.Forms.DialogResult.No Then
    '                    Exit Sub
    '                End If

    '                oCuerpo_nota_devolucion.Borrar(CInt(Me.lblid_cuerpo_nota_devolucion.Text))
    '                'RefrescarGrilla()
    '        End Select

    '    Catch ex As Exception
    '        Errores(ex)
    '    End Try
    'End Sub


    'Private Sub dgvNP_pendiente_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Try
    '        Me.lblid_nota_pedido.Text = CStr(Me.dgvNP_pendiente.Item(0, Me.dgvNP_pendiente.CurrentRow.Index).Value)
    '    Catch ex As Exception
    '    End Try
    'End Sub

    'Private Sub dgvNP_pendiente_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    '    Try
    '        'pongo el id para hacer el cambio
    '        Me.lblid_nota_pedido.Text = CStr(Me.dgvNP_pendiente.Item("id_nota_pedido", Me.dgvNP_pendiente.CurrentRow.Index).Value)

    '        If dgvNP_pendiente.Columns(e.ColumnIndex).Name = "Tilde" Then
    '            oNota_pedido.UpdateTilde(CInt(Me.lblid_nota_pedido.Text))
    '            Me.RefrescarGrillaNPPendiente()
    '        End If
    '    Catch ex As Exception
    '        Errores(ex)
    '    End Try
    'End Sub


    'Private Sub dgvFacturaPendiente_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Try
    '        Me.lblid_factura_pendiente.Text = CStr(Me.dgvFacturaPendiente.Item(0, Me.dgvFacturaPendiente.CurrentRow.Index).Value)
    '    Catch ex As Exception
    '    End Try
    'End Sub

    'Private Sub dgvFacturaPendiente_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    '    Try
    '        'pongo el id para hacer el cambio
    '        Me.lblid_factura_pendiente.Text = CStr(Me.dgvFacturaPendiente.Item("id_factura_proveedor", Me.dgvFacturaPendiente.CurrentRow.Index).Value)

    '        If dgvFacturaPendiente.Columns(e.ColumnIndex).Name = "Tilde" Then
    '            oFactura_proveedor.UpdateTilde(CInt(Me.lblid_factura_pendiente.Text))
    '            Me.RefrescarGrillaFacturaPendiente()
    '        End If
    '    Catch ex As Exception
    '        Errores(ex)
    '    End Try
    'End Sub

    'Private Sub btnCompara_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim odt As New DataTable

    '    oComparativa_np_2.SetComparativa(CInt(Me.lblid_empresa.Text), CInt(Me.lblid_proveedor.Text))

    '    With oComparativa_np_2
    '        .Cargar()
    '        odt = .GetAll_2()
    '    End With

    '    Me.dgvControl.DataSource = odt
    'End Sub


    'Private Sub btnMarcaRevisada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    oFactura_proveedor.UpdateEstado(CInt(Me.lblid_empresa.Text), CInt(Me.lblid_proveedor.Text), CChar("I"), CChar("R"))
    '    oNota_pedido.UpdateEstado(CInt(Me.lblid_empresa.Text), CInt(Me.lblid_proveedor.Text), CChar("E"), CChar("R"))

    '    Me.RefrescarGrillaFacturaPendiente()
    '    Me.RefrescarGrillaNPPendiente()

    '    Dim odt As New DataTable
    '    With oComparativa_np_2
    '        .Cargar()
    '        .Truncate()
    '        odt = .GetAll_2()
    '    End With

    '    Me.dgvControl.DataSource = odt
    'End Sub


    Private Sub txtimporte_21_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles txtSaldo.TextChanged, txtalicuota_iva.TextChanged, txtiva_21.TextChanged, txtiva_10_5.TextChanged, _
    txtimporte_21.TextChanged, txtimporte_10_5.TextChanged, txtretencion_iva.TextChanged, _
    txtpercepcion_iva.TextChanged, txtretencion_ingreso_bruto.TextChanged, txtpercepcion_ingreso_bruto.TextChanged, _
    txtretencion_ganancia.TextChanged, txttotal_21.TextChanged, txttotal_10_5.TextChanged, txttotal_sin.TextChanged, _
    txtTotal_factura.TextChanged, txtImpuesto_interno.TextChanged, txtOtro.TextChanged

        Dim txtTemp As New TextBox
        txtTemp = CType(sender, TextBox)

        If Not IsNumeric(txtTemp.Text) Then
            Exit Sub
        End If

        'If txtiva_21.Text = "" Or txtiva_10_5.Text = "" Or _
        'txtimporte_21.Text = "" Or txtimporte_10_5.Text = "" Or txtretencion_iva.Text = "" Or _
        'txtpercepcion_iva.Text = "" Or txtretencion_ingreso_bruto.Text = "" Or txtpercepcion_ingreso_bruto.Text = "" Or _
        'txtretencion_ganancia.Text = "" Or txttotal_21.Text = "" Or txttotal_10_5.Text = "" Or txttotal_sin.Text = "" Or _
        'txtTotal_factura.Text = "" Or txtImpuesto_interno.Text = "" Or txtOtro.Text = "" Then
        '    Exit Sub
        'End If

        ' recorrer todos los controles del formulario indicado  
        For Each c As System.Windows.Forms.Control In Me.gbDecimal.Controls
            If TypeOf c Is TextBox And c.Text = "" Then
                Exit Sub
            End If
        Next

        Select Case txtTemp.Name
            Case "txtimporte_10_5"
                Me.txtiva_10_5.Text = CStr(Math.Round(CDec(Me.txtimporte_10_5.Text) * 10.5 / 100, 2))
            Case "txtimporte_21"
                Me.txtiva_21.Text = CStr(Math.Round(CDec(Me.txtimporte_21.Text) * 21 / 100, 2))
        End Select

        Me.txttotal_10_5.Text = CStr(Math.Round(CDec(Me.txtimporte_10_5.Text) + CDec(Me.txtiva_10_5.Text), 2))
        Me.txttotal_21.Text = CStr(Math.Round(CDec(Me.txtimporte_21.Text) + CDec(Me.txtiva_21.Text), 2))

        Me.txtTotalCalculado.Text = CStr(CDec(Me.txttotal_10_5.Text) + CDec(Me.txttotal_21.Text) + CDec(Me.txttotal_sin.Text) + _
        CDec(Me.txtpercepcion_iva.Text) + CDec(Me.txtpercepcion_ingreso_bruto.Text) - _
        CDec(Me.txtretencion_iva.Text) - CDec(Me.txtretencion_ingreso_bruto.Text) - CDec(Me.txtretencion_ganancia.Text) + _
        CDec(Me.txtImpuesto_interno.Text) + CDec(txtOtro.Text))
        Me.txtTotal_factura.Text = Me.txtTotalCalculado.Text

    End Sub




    Private Sub btnBuscaFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaFactura.Click
        Dim frmTemp As New frmBuscarFactura

        Me.AddOwnedForm(frmTemp)
        frmTemp.ShowDialog()

        Me.lblid_factura_referencia.Text = CStr(id_factura_global)
        Me.txtReferencia.Text = numero_factura_global
        Me.txtFactura_referencia.Text = Me.txtReferencia.Text.Replace("-", "")

        'control: si no tiene factura para hacer la nc no permite guardar
        If Me.lblid_factura_referencia.Text = "0" Or Me.lblid_factura_referencia.Text = "" Then
            Me.btnGuardar.Enabled = False
        Else
            Me.btnGuardar.Enabled = True
        End If
    End Sub



    Private Sub dtpfecha_factura_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpfecha_factura.ValueChanged
        Me.dtpfecha_vencimiento.Value = Me.dtpfecha_factura.Value
    End Sub

End Class
