Public Class frmDetalleCheque_recibido

   Private Sub frmDetalleCheque_recibido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnBuscaCliente, "Buscar Nuevo Cliente")
       Me.ttGeneral.SetToolTip(Me.btnBuscaBanco, "Buscar Nuevo Banco")
       Me.ttGeneral.SetToolTip(Me.btnBuscaProvincia, "Buscar Nuevo Provincia")
       Me.ttGeneral.SetToolTip(Me.btnBuscaLocalidad, "Buscar Nuevo Localidad")
        '  Me.ttGeneral.SetToolTip(Me.btnBuscaEmpresa, "Buscar Nuevo Empresa")
       Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Cheque_recibido")
       Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
       Try
           ObtenerDatos()

           Me.cmbCliente.Text = oCliente.GetOne(CInt(Me.lblid_Cliente.Text)).Rows(0).Item("nombre_Cliente").ToString.Trim
           Me.cmbBanco.Text = oBanco.GetOne(CInt(Me.lblid_Banco.Text)).Rows(0).Item("nombre_Banco").ToString.Trim
           Me.cmbProvincia.Text = oProvincia.GetOne(CInt(Me.lblid_Provincia.Text)).Rows(0).Item("nombre_Provincia").ToString.Trim
           Me.cmbLocalidad.Text = oLocalidad.GetOne(CInt(Me.lblid_Localidad.Text)).Rows(0).Item("nombre_Localidad").ToString.Trim
            '   Me.cmbEmpresa.Text = oEmpresa.GetOne(CInt(Me.lblid_Empresa.Text)).Rows(0).Item("nombre_Empresa").ToString.Trim
            Me.cmbproveedor.Text = oProveedor.GetOne(CInt(Me.lblid_proveedor.Text)).Rows(0).Item("nombre_Proveedor").ToString.Trim

            Me.cmbbanco_deposito.Text = oBanco.GetOne(CInt(Me.lblid_banco_deposito.Text)).Rows(0).Item("nombre_Banco").ToString.Trim
            Me.cmbcuenta.Text = oCuenta.GetOne(CInt(Me.lblid_cuenta.Text)).Rows(0).Item("numero").ToString.Trim
        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
       End Try

       If BanderaCheque_recibido  = 1 Then
           Me.LimpiarControles()
       End If
        Me.Text = "Cheque_recibido" & vgNombreFormulario
       Me.CancelButton = Me.btnSalir
       Me.BackColor = Color.Gainsboro
       Me.StartPosition = FormStartPosition.CenterScreen
       Me.MinimizeBox = False
        Me.MaximizeBox = False

        Me.lblid_empresa.Text = CType(Me.Owner, frmResumenCaja).lblidEmpresa.Text

        Dim odt As New DataTable
        odt = oCliente_maestro.GetOne(1)
        'If odt.Rows(0).Item("Nombre permiso").ToString = "colina" Then
        '    Me.etiquetaiva.Visible = False
        '    Me.txtiva.Visible = False
        'End If
   End Sub

   Sub CargarCombos()
       Me.CargarCliente
       Me.CargarBanco
       Me.CargarProvincia
        '    Me.CargarLocalidad()
        Me.CargarProveedor()
        Me.CargarBancoDeposito()
        ' Me.CargarCuenta()
    End Sub

   Sub CargarCliente()
       Dim odt As New DataTable

       odt = oCliente.GetCmb
       With Me.cmbCliente
           .DataSource = odt
           .DisplayMember = "nombre_cliente"
           .ValueMember = "id_cliente"
       End With
       If Me.cmbCliente.SelectedIndex >= 0 Then
           cmbCliente.SelectedIndex = 0
           Me.lblid_Cliente.Text = cmbCliente.SelectedValue.ToString
       End If
   End Sub

   Sub CargarBanco()
       Dim odt As New DataTable

       odt = oBanco.GetCmb
       With Me.cmbBanco
           .DataSource = odt
           .DisplayMember = "nombre_banco"
           .ValueMember = "id_banco"
       End With
       If Me.cmbBanco.SelectedIndex >= 0 Then
           cmbBanco.SelectedIndex = 0
           Me.lblid_Banco.Text = cmbBanco.SelectedValue.ToString
       End If
   End Sub

   Sub CargarProvincia()
       Dim odt As New DataTable

       odt = oProvincia.GetCmb
       With Me.cmbProvincia
           .DataSource = odt
           .DisplayMember = "nombre_provincia"
           .ValueMember = "id_provincia"
       End With
       If Me.cmbProvincia.SelectedIndex >= 0 Then
           cmbProvincia.SelectedIndex = 0
           Me.lblid_Provincia.Text = cmbProvincia.SelectedValue.ToString
       End If
   End Sub

   Sub CargarLocalidad()
       Dim odt As New DataTable

        odt = oLocalidad.GetCmb_2(CInt(Me.lblid_provincia.Text))
       With Me.cmbLocalidad
           .DataSource = odt
           .DisplayMember = "nombre_localidad"
           .ValueMember = "id_localidad"
       End With
       If Me.cmbLocalidad.SelectedIndex >= 0 Then
           cmbLocalidad.SelectedIndex = 0
           Me.lblid_Localidad.Text = cmbLocalidad.SelectedValue.ToString
       End If
   End Sub

    Sub CargarProveedor()
        Dim odt As New DataTable

        odt = oProveedor.GetCmb
        With Me.cmbProveedor
            .DataSource = odt
            .DisplayMember = "nombre_proveedor"
            .ValueMember = "id_proveedor"
        End With
        If Me.cmbProveedor.SelectedIndex >= 0 Then
            cmbProveedor.SelectedIndex = 0
            Me.lblid_Proveedor.Text = cmbProveedor.SelectedValue.ToString
        End If
    End Sub

    Sub CargarBancoDeposito()
        Dim odt As New DataTable

        odt = oBanco.GetCmb
        With Me.cmbbanco_deposito
            .DataSource = odt
            .DisplayMember = "nombre_banco"
            .ValueMember = "id_banco"
        End With
        If Me.cmbbanco_deposito.SelectedIndex >= 0 Then
            cmbbanco_deposito.SelectedIndex = 0
            Me.lblid_banco_deposito.Text = cmbbanco_deposito.SelectedValue.ToString
        End If
    End Sub

    Sub CargarCuenta()
        Dim odt As New DataTable

        odt = oCuenta.Consultar(CInt(Me.lblid_banco_deposito.Text), CInt(Me.lblid_empresa.Text))
        With Me.cmbcuenta
            .DataSource = odt
            .DisplayMember = "numero"
            .ValueMember = "id_cuenta"
        End With
        If Me.cmbcuenta.SelectedIndex >= 0 Then
            cmbcuenta.SelectedIndex = 0
            Me.lblid_cuenta.Text = cmbcuenta.SelectedValue.ToString
        End If
    End Sub

    Sub LimpiarControles()
        Me.txtnumero_cheque.Text = ""
        Me.lblid_cliente.Text = "0"
        Me.cmbcliente.Text = ""
        Me.lblid_banco.Text = "0"
        Me.cmbbanco.Text = ""
        Me.txtdetalle.Text = ""
        Me.dtpfecha_recibido.Value = DateTime.Now
        Me.dtpfecha_acreditacion.Value = DateTime.Now
        Me.txtimporte.Text = ""
        Me.txtiva.Text = "0"
        Me.lblid_provincia.Text = "0"
        Me.cmbprovincia.Text = ""
        Me.lblid_localidad.Text = "0"
        Me.cmblocalidad.Text = ""
        'Me.lblid_empresa.Text = "0"
        'Me.cmbEmpresa.Text =  ""
        Me.chkcontrol.Checked = False
        Me.lblid_proveedor.Text = "1"
        Me.cmbproveedor.Text = "Ninguno"
        Me.chkanulado.Checked = False
        Me.chkpago_tercero.Checked = False
        Me.txtnumero_recibo.Text = ""
        Me.chkcobro_efectivo.Checked = False
        Me.lblid_banco_deposito.Text = "1"
        Me.cmbbanco_deposito.Text = "Ninguno"
        Me.lblid_cuenta.Text = "1"
        Me.cmbcuenta.Text = "Ninguno"
        Me.chkDeposito_cuenta.Checked = False
        'opcion de terceros
        '' Me.LimpiarTercero()
    End Sub

    'Sub LimpiarTercero()
    '    If Me.chkpago_tercero.Checked = True Then
    '    Else
    '        Me.lblid_proveedor.Text = "1"
    '        Me.cmbproveedor.Text = oProveedor.GetOne(CInt(Me.lblid_proveedor.Text)).Rows(0).Item("nombre_Proveedor").ToString.Trim
    '    End If
    'End Sub

   Private Sub ObtenerDatos()
       Me.txtnumero_cheque.Text = oCheque_recibido.numero_cheque.Trim
       Me.lblid_cliente.Text = oCheque_recibido.id_cliente.ToString
       Me.lblid_banco.Text = oCheque_recibido.id_banco.ToString
       Me.txtdetalle.Text = oCheque_recibido.detalle.Trim
       Me.dtpfecha_recibido.Value = oCheque_recibido.fecha_recibido
       Me.dtpfecha_acreditacion.Value = oCheque_recibido.fecha_acreditacion
       Me.txtimporte.Text = oCheque_recibido.importe.ToString.Trim
       Me.txtiva.Text = oCheque_recibido.iva.ToString.Trim
       Me.lblid_provincia.Text = oCheque_recibido.id_provincia.ToString
       Me.lblid_localidad.Text = oCheque_recibido.id_localidad.ToString
        ' Me.lblid_empresa.Text = oCheque_recibido.id_empresa.ToString
        Me.chkcontrol.Checked = oCheque_recibido.control
        Me.lblid_proveedor.Text = oCheque_recibido.id_proveedor.ToString
        Me.chkanulado.Checked = oCheque_recibido.anulado
        Me.chkpago_tercero.Checked = oCheque_recibido.pago_tercero
        Me.txtnumero_recibo.Text = oCheque_recibido.numero_recibo.Trim
        Me.chkcobro_efectivo.Checked = oCheque_recibido.cobro_efectivo
        Me.lblid_banco_deposito.Text = CStr(oCheque_recibido.id_banco_deposito)
        Me.lblid_cuenta.Text = CStr(oCheque_recibido.id_cuenta)
        Me.chkDeposito_cuenta.Checked = oCheque_recibido.deposito_cuenta
   End Sub

   Private Sub AsignarDatos()
       oCheque_recibido.numero_cheque = Me.txtnumero_cheque.Text
       oCheque_recibido.id_cliente = CInt(Me.lblid_cliente.Text)
       oCheque_recibido.id_banco = CInt(Me.lblid_banco.Text)
        oCheque_recibido.detalle = Me.txtdetalle.Text.Trim
       oCheque_recibido.fecha_recibido = Me.dtpfecha_recibido.Value.Date
       oCheque_recibido.fecha_acreditacion = Me.dtpfecha_acreditacion.Value.Date
       oCheque_recibido.importe = CDec(Me.txtimporte.Text)
       oCheque_recibido.iva = CDec(Me.txtiva.Text)
       oCheque_recibido.id_provincia = CInt(Me.lblid_provincia.Text)
       oCheque_recibido.id_localidad = CInt(Me.lblid_localidad.Text)
       oCheque_recibido.id_empresa = CInt(Me.lblid_empresa.Text)
        oCheque_recibido.control = Me.chkcontrol.Checked
        oCheque_recibido.id_proveedor = CInt(Me.lblid_proveedor.Text)
        oCheque_recibido.anulado = Me.chkanulado.Checked
        oCheque_recibido.pago_tercero = Me.chkpago_tercero.Checked
        oCheque_recibido.numero_recibo = Me.txtnumero_recibo.Text
        oCheque_recibido.cobro_efectivo = Me.chkcobro_efectivo.Checked
        oCheque_recibido.id_banco_deposito = CInt(Me.lblid_banco_deposito.Text)
        oCheque_recibido.id_cuenta = CInt(Me.lblid_cuenta.Text)
        oCheque_recibido.deposito_cuenta = Me.chkDeposito_cuenta.Checked
   End Sub

   Public Sub SoloLectura()
       Me.txtnumero_cheque.Enabled = False
       Me.cmbCliente.Enabled = False
       Me.btnBuscaCliente.Enabled = False
       Me.cmbBanco.Enabled = False
       Me.btnBuscaBanco.Enabled = False
       Me.txtdetalle.Enabled = False
       Me.dtpfecha_recibido.Enabled = False
       Me.dtpfecha_acreditacion.Enabled = False
       Me.txtimporte.Enabled = False
       Me.txtiva.Enabled = False
       Me.cmbProvincia.Enabled = False
       Me.btnBuscaProvincia.Enabled = False
       Me.cmbLocalidad.Enabled = False
       Me.btnBuscaLocalidad.Enabled = False
        'Me.cmbEmpresa.Enabled = False
        'Me.btnBuscaEmpresa.Enabled = False
        Me.chkcontrol.Enabled = False
        Me.cmbproveedor.Enabled = False
        Me.btnBuscaproveedor.Enabled = False
        Me.chkanulado.Enabled = False
        Me.chkpago_tercero.Enabled = False
        Me.txtnumero_recibo.Enabled = False
        Me.chkcobro_efectivo.Enabled = False
        Me.btnGuardar.Visible = False
        Me.cmbbanco_deposito.Enabled = False
        Me.cmbcuenta.Enabled = False
        Me.chkDeposito_cuenta.Enabled = False
   End Sub

   Private Sub Guardar()
       Try
           Me.AsignarDatos()
           If oCheque_recibido.Exist() Then
               If BanderaCheque_recibido = 1 Then
                   MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
               Exit Sub
               ElseIf BanderaCheque_recibido = 2 Then
                   If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                       = Windows.Forms.DialogResult.No Then
                       Exit Sub
                   End If
               End If
           End If
           Select Case BanderaCheque_recibido
               Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oCheque_recibido.Guardar()

                    'si se cobra agrego un depo en efectivo
                    If Me.chkcobro_efectivo.Checked = True Then
                        With oIngreso_efectivo
                            .Cargar()
                            .Insertar()
                            .comprobante = CStr(1)
                            .detalle = "Ingresa del cheque: " & Me.txtnumero_cheque.Text
                            .fecha = Me.dtpfecha_acreditacion.Value
                            .id_empresa = 1
                            .importe = CDec(Me.txtimporte.Text)
                            .iva = CDec(Me.txtiva.Text)
                            .Guardar()
                        End With
                        'si se deposito agrego un deposito en bancos
                    ElseIf Me.chkDeposito_cuenta.Checked = True Then
                        With oChequeRecibido
                            .Cargar()
                            .Insertar()
                            .id_cliente = CInt(Me.lblid_cliente.Text)
                            .banco_cheque = CInt(Me.lblid_banco.Text)
                            .id_provincia = CInt(Me.lblid_provincia.Text)
                            .id_localidad = CInt(Me.lblid_localidad.Text)
                            .numero_cheque = Me.txtnumero_cheque.Text
                            .detalle = Me.txtdetalle.Text.Trim
                            .fecha_recibido = Me.dtpfecha_recibido.Value.Date
                            .fecha_acreditacion = Me.dtpfecha_acreditacion.Value.Date
                            .importe = CDec(Me.txtimporte.Text)
                            .banco_deposito = CInt(Me.lblid_banco_deposito.Text)
                            .id_cuenta = CInt(Me.lblid_cuenta.Text)
                            .id_empresa = CInt(Me.lblid_empresa.Text)
                            .periodo = Me.dtpfecha_acreditacion.Value.Date
                            .vendido = False
                            .iva = CDec(Me.txtiva.Text)
                            .anulado = False
                            .control = False
                            .fecha_venta = Me.dtpfecha_acreditacion.Value.Date
                            .Guardar()
                        End With
                    End If

                    CType(Me.Owner, frmResumenCaja).RefrescarGrilla()
                    Me.CargarCombos()
                    oCheque_recibido.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.txtnumero_cheque.Focus()

                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oCheque_recibido.Guardar()

                    'si se cobra agrego un depo en efectivo
                    If Me.chkcobro_efectivo.Checked = True Then
                        With oIngreso_efectivo
                            .Cargar()
                            .Insertar()
                            .comprobante = CStr(1)
                            .detalle = "Ingresa del cheque: " & Me.txtnumero_cheque.Text
                            .fecha = Me.dtpfecha_acreditacion.Value
                            .id_empresa = 1
                            .importe = CDec(Me.txtimporte.Text)
                            .iva = CDec(Me.txtiva.Text)
                            .Guardar()
                        End With
                        With oCheque_recibido
                            .Modificar(.id_cheque_recibido)
                            .archivado = True
                            .Guardar()
                        End With

                        'si se deposito agrego un deposito en bancos
                    ElseIf Me.chkDeposito_cuenta.Checked = True Then
                        With oChequeRecibido
                            .Cargar()
                            .Insertar()
                            .id_cliente = CInt(Me.lblid_cliente.Text)
                            .banco_cheque = CInt(Me.lblid_banco.Text)
                            .id_provincia = CInt(Me.lblid_provincia.Text)
                            .id_localidad = CInt(Me.lblid_localidad.Text)
                            .numero_cheque = Me.txtnumero_cheque.Text
                            .detalle = Me.txtdetalle.Text.Trim
                            .fecha_recibido = Me.dtpfecha_recibido.Value.Date
                            .fecha_acreditacion = Me.dtpfecha_acreditacion.Value.Date
                            .importe = CDec(Me.txtimporte.Text)
                            .banco_deposito = CInt(Me.lblid_banco_deposito.Text)
                            .id_cuenta = CInt(Me.lblid_cuenta.Text)
                            .id_empresa = CInt(Me.lblid_empresa.Text)
                            .periodo = Me.dtpfecha_acreditacion.Value.Date
                            .vendido = False
                            .iva = CDec(Me.txtiva.Text)
                            .anulado = False
                            .control = False
                            .fecha_venta = Me.dtpfecha_acreditacion.Value.Date
                            .Guardar()
                        End With

                        With oCheque_recibido
                            .Modificar(.id_cheque_recibido)
                            .archivado = True
                            .Guardar()
                        End With

                    End If
                    Me.Close()
            End Select
       Catch ex As Exception
           MessageBox.Show(ex.Message)
       End Try
   End Sub

   Private Function ChequearVacios() As Boolean
       Dim bandera As Boolean
        If Me.txtnumero_cheque.Text = "" Or Me.txtimporte.Text = "" Or Me.txtiva.Text = "" Then
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
       If CDbl(Me.lblid_banco.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de banco")
           Exit Sub
       End If
       If CDbl(Me.lblid_provincia.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de provincia")
           Exit Sub
       End If
       If CDbl(Me.lblid_localidad.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de localidad")
           Exit Sub
       End If
       If CDbl(Me.lblid_empresa.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de empresa")
           Exit Sub
       End If
        If CDbl(Me.lblid_proveedor.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de proveedor")
            Exit Sub
        End If
        If CDbl(Me.lblid_banco_deposito.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de banco de deposito")
            Exit Sub
        End If
        If CDbl(Me.lblid_cuenta.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de cuenta")
            Exit Sub
        End If

       blnVacios = Me.ChequearVacios
       If blnVacios = False Then
           MessageBox.Show("Debe Llenar los Campos Obligatorios")
           Exit Sub
       Else
           If BanderaCheque_recibido  = 1 Then
               Me.Guardar()
           Else
               Me.Guardar()
           End If
       End If
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
       Dim frmTemporal As New FrmAbmCliente
       frmTemporal.ShowDialog()
       Me.CargarCliente()
       Me.cmbCliente.Focus()
       Me.cmbCliente.Text = ""
       Me.lblid_Cliente.Text = "0"
   End Sub

   Private Sub cmbBanco_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBanco.SelectedIndexChanged
       If Me.cmbBanco.SelectedIndex >= 0 Then
           Me.lblid_banco.Text = cmbBanco.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaBanco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaBanco.Click
       Dim frmTemporal As New FrmAbmBanco
       frmTemporal.ShowDialog()
       Me.CargarBanco()
       Me.cmbBanco.Focus()
       Me.cmbBanco.Text = ""
       Me.lblid_Banco.Text = "0"
   End Sub

   Private Sub cmbProvincia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProvincia.SelectedIndexChanged
       If Me.cmbProvincia.SelectedIndex >= 0 Then
           Me.lblid_provincia.Text = cmbProvincia.SelectedValue.ToString
        End If
        If Not IsNumeric(Me.lblid_provincia.Text) Then
            Exit Sub
        End If
        Me.CargarLocalidad()
   End Sub

   Private Sub btnBuscaProvincia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaProvincia.Click
       Dim frmTemporal As New FrmAbmProvincia
       frmTemporal.ShowDialog()
       Me.CargarProvincia()
       Me.cmbProvincia.Focus()
       Me.cmbProvincia.Text = ""
       Me.lblid_Provincia.Text = "0"
   End Sub

   Private Sub cmbLocalidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLocalidad.SelectedIndexChanged
       If Me.cmbLocalidad.SelectedIndex >= 0 Then
           Me.lblid_localidad.Text = cmbLocalidad.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaLocalidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaLocalidad.Click
       Dim frmTemporal As New FrmAbmLocalidad
       frmTemporal.ShowDialog()
       Me.CargarLocalidad()
       Me.cmbLocalidad.Focus()
       Me.cmbLocalidad.Text = ""
       Me.lblid_Localidad.Text = "0"
   End Sub

    'Private Sub cmbEmpresa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEmpresa.SelectedIndexChanged
    '    If Me.cmbEmpresa.SelectedIndex >= 0 Then
    '        Me.lblid_empresa.Text = cmbEmpresa.SelectedValue.ToString
    '    End If
    'End Sub

    'Private Sub btnBuscaEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaEmpresa.Click
    '    Dim frmTemporal As New FrmAbmEmpresa
    '    frmTemporal.ShowDialog()
    '    Me.CargarEmpresa()
    '    Me.cmbEmpresa.Focus()
    '    Me.cmbEmpresa.Text = ""
    '    Me.lblid_Empresa.Text = "0"
    'End Sub

    Private Sub cmbProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbproveedor.SelectedIndexChanged
        If Me.cmbproveedor.SelectedIndex >= 0 Then
            Me.lblid_proveedor.Text = cmbproveedor.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaproveedor.Click
        Dim frmTemporal As New FrmAbmProveedor
        frmTemporal.ShowDialog()
        Me.CargarProveedor()
        Me.cmbProveedor.Focus()
        Me.cmbProveedor.Text = ""
        Me.lblid_proveedor.Text = "0"
    End Sub

    Private Sub cmbBanco_deposito_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbanco_deposito.SelectedIndexChanged
        If Me.cmbbanco_deposito.SelectedIndex >= 0 Then
            Me.lblid_banco_deposito.Text = cmbbanco_deposito.SelectedValue.ToString
        End If
        If Not IsNumeric(Me.lblid_banco_deposito.Text) Then
            Exit Sub
        End If
        Me.CargarCuenta()
    End Sub

    Private Sub cmbCuenta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcuenta.SelectedIndexChanged
        If Me.cmbcuenta.SelectedIndex >= 0 Then
            Me.lblid_cuenta.Text = cmbcuenta.SelectedValue.ToString
        End If
    End Sub

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtnumero_cheque.KeyPress, txtdetalle.KeyPress, chkcontrol.KeyPress, chkanulado.KeyPress, _
   chkpago_tercero.KeyPress, txtnumero_recibo.KeyPress, chkcobro_efectivo.KeyPress, chkDeposito_cuenta.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles cmbcliente.KeyDown, cmbbanco.KeyDown, dtpfecha_recibido.KeyDown, dtpfecha_acreditacion.KeyDown, _
    cmbprovincia.KeyDown, cmblocalidad.KeyDown, cmbproveedor.KeyDown, cmbbanco_deposito.KeyDown, cmbcuenta.KeyDown
        If CDbl(e.KeyValue.ToString) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

   Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtimporte.KeyPress, txtiva.KeyPress
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

    Private Sub chkpago_tercero_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkpago_tercero.CheckedChanged
        If Me.chkpago_tercero.Checked = True Then
            Me.chkcobro_efectivo.Checked = False
            Me.chkDeposito_cuenta.Checked = False
            Me.pnlProveedor.Enabled = True
            Me.pnlDeposito.Enabled = False
            Me.lblid_banco_deposito.Text = "1"
            Me.cmbbanco_deposito.Text = "Ninguno"
            Me.lblid_cuenta.Text = "1"
            Me.cmbcuenta.Text = "Ninguno"
        Else
            Me.pnlProveedor.Enabled = False
        End If
    End Sub

    Private Sub chkcobro_efectivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkcobro_efectivo.CheckedChanged
        If Me.chkcobro_efectivo.Checked = True Then
            Me.chkpago_tercero.Checked = False
            Me.chkDeposito_cuenta.Checked = False
            Me.pnlProveedor.Enabled = False
            Me.pnlDeposito.Enabled = False
            Me.lblid_banco_deposito.Text = "1"
            Me.cmbbanco_deposito.Text = "Ninguno"
            Me.lblid_cuenta.Text = "1"
            Me.cmbcuenta.Text = "Ninguno"
            Me.lblid_proveedor.Text = "1"
            Me.cmbproveedor.Text = "Ninguno"
            Me.txtnumero_recibo.Text = ""
        End If
    End Sub

    Private Sub chkDeposito_cuenta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDeposito_cuenta.CheckedChanged
        If Me.chkDeposito_cuenta.Checked = True Then
            Me.chkcobro_efectivo.Checked = False
            Me.chkpago_tercero.Checked = False
            Me.pnlProveedor.Enabled = False
            Me.pnlDeposito.Enabled = True
            Me.lblid_proveedor.Text = "1"
            Me.cmbproveedor.Text = "Ninguno"
            Me.txtnumero_recibo.Text = ""
        Else
            Me.pnlDeposito.Enabled = False
        End If
    End Sub

End Class
