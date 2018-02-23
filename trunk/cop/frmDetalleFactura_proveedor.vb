Public Class frmDetalleFactura_proveedor

   Private Sub frmDetalleFactura_proveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnBuscaEmpresa, "Buscar Nuevo Empresa")
       Me.ttGeneral.SetToolTip(Me.btnBuscaTipo_comprobante, "Buscar Nuevo Tipo_comprobante")
       Me.ttGeneral.SetToolTip(Me.btnBuscaProveedor, "Buscar Nuevo Proveedor")
       Me.ttGeneral.SetToolTip(Me.btnBuscaAlmacen, "Buscar Nuevo Almacen")
       Me.ttGeneral.SetToolTip(Me.btnBuscaCuenta_contable, "Buscar Nuevo Cuenta_contable")
       Me.ttGeneral.SetToolTip(Me.btnBuscaUsuario, "Buscar Nuevo Usuario")
       Me.ttGeneral.SetToolTip(Me.btnBuscaEro_certificado, "Buscar Nuevo Ero_certificado")
       Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Factura_proveedor")
       Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
       Try
           ObtenerDatos()

           Me.cmbEmpresa.Text = oEmpresa.GetOne(CInt(Me.lblid_Empresa.Text)).Rows(0).Item("nombre Empresa").ToString.Trim
           Me.cmbTipo_comprobante.Text = oTipo_comprobante.GetOne(CInt(Me.lblid_Tipo_comprobante.Text)).Rows(0).Item("nombre Tipo_comprobante").ToString.Trim
           Me.cmbProveedor.Text = oProveedor.GetOne(CInt(Me.lblid_Proveedor.Text)).Rows(0).Item("nombre Proveedor").ToString.Trim
           Me.cmbAlmacen.Text = oAlmacen.GetOne(CInt(Me.lblid_Almacen.Text)).Rows(0).Item("nombre Almacen").ToString.Trim
           Me.cmbCuenta_contable.Text = oCuenta_contable.GetOne(CInt(Me.lblid_Cuenta_contable.Text)).Rows(0).Item("nombre Cuenta_contable").ToString.Trim
           Me.cmbUsuario.Text = oUsuario.GetOne(CInt(Me.lblid_Usuario.Text)).Rows(0).Item("nombre Usuario").ToString.Trim
           Me.cmbEro_certificado.Text = oEro_certificado.GetOne(CInt(Me.lblid_Ero_certificado.Text)).Rows(0).Item("nombre Ero_certificado").ToString.Trim
       Catch ex As Exception
           '    MessageBox.Show(ex.Message)
       End Try

       If BanderaFactura_proveedor  = 1 Then
           Me.LimpiarControles()
       End If
       Me.Text = "Factura_proveedor" & vgNombreFormulario
       Me.CancelButton = Me.btnSalir
       Me.BackColor = Color.Gainsboro
       Me.StartPosition = FormStartPosition.CenterScreen
       Me.MinimizeBox = False
       Me.MaximizeBox = False
   End Sub

   Sub CargarCombos()
       Me.CargarEmpresa
       Me.CargarTipo_comprobante
       Me.CargarProveedor
       Me.CargarAlmacen
       Me.CargarCuenta_contable
       Me.CargarUsuario
       Me.CargarEro_certificado
   End Sub

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
           Me.lblid_Empresa.Text = cmbEmpresa.SelectedValue.ToString
       End If
   End Sub

   Sub CargarTipo_comprobante()
       Dim odt As New DataTable

       odt = oTipo_comprobante.GetCmb
       With Me.cmbTipo_comprobante
           .DataSource = odt
           .DisplayMember = "nombre_tipo_comprobante"
           .ValueMember = "id_tipo_comprobante"
       End With
       If Me.cmbTipo_comprobante.SelectedIndex >= 0 Then
           cmbTipo_comprobante.SelectedIndex = 0
           Me.lblid_Tipo_comprobante.Text = cmbTipo_comprobante.SelectedValue.ToString
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

   Sub CargarAlmacen()
       Dim odt As New DataTable

       odt = oAlmacen.GetCmb
       With Me.cmbAlmacen
           .DataSource = odt
           .DisplayMember = "nombre_almacen"
           .ValueMember = "id_almacen"
       End With
       If Me.cmbAlmacen.SelectedIndex >= 0 Then
           cmbAlmacen.SelectedIndex = 0
           Me.lblid_Almacen.Text = cmbAlmacen.SelectedValue.ToString
       End If
   End Sub

   Sub CargarCuenta_contable()
       Dim odt As New DataTable

       odt = oCuenta_contable.GetCmb
       With Me.cmbCuenta_contable
           .DataSource = odt
           .DisplayMember = "nombre_cuenta_contable"
           .ValueMember = "id_cuenta_contable"
       End With
       If Me.cmbCuenta_contable.SelectedIndex >= 0 Then
           cmbCuenta_contable.SelectedIndex = 0
           Me.lblid_Cuenta_contable.Text = cmbCuenta_contable.SelectedValue.ToString
       End If
   End Sub

   Sub CargarUsuario()
       Dim odt As New DataTable

       odt = oUsuario.GetCmb
       With Me.cmbUsuario
           .DataSource = odt
           .DisplayMember = "nombre_usuario"
           .ValueMember = "id_usuario"
       End With
       If Me.cmbUsuario.SelectedIndex >= 0 Then
           cmbUsuario.SelectedIndex = 0
           Me.lblid_Usuario.Text = cmbUsuario.SelectedValue.ToString
       End If
   End Sub

   Sub CargarEro_certificado()
       Dim odt As New DataTable

       odt = oEro_certificado.GetCmb
       With Me.cmbEro_certificado
           .DataSource = odt
           .DisplayMember = "nombre_ero_certificado"
           .ValueMember = "id_ero_certificado"
       End With
       If Me.cmbEro_certificado.SelectedIndex >= 0 Then
           cmbEro_certificado.SelectedIndex = 0
           Me.lblid_Ero_certificado.Text = cmbEro_certificado.SelectedValue.ToString
       End If
   End Sub

   Sub LimpiarControles()
       Me.txtnumero_factura.Text = ""
       Me.lblid_empresa.Text = "0"
       Me.cmbEmpresa.Text =  ""
       Me.lblid_tipo_comprobante.Text = "0"
       Me.cmbTipo_comprobante.Text =  ""
       Me.dtpfecha.Value = DateTime.Now
       Me.dtpfecha_factura.Value = DateTime.Now
       Me.dtpfecha_vencimiento.Value = DateTime.Now
       Me.lblid_proveedor.Text = "0"
       Me.cmbProveedor.Text =  ""
       Me.txtobservacion.Text = ""
       Me.txtsaldo.Text = "0"
       Me.txtestado.Text = ""
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
       Me.txtimpuesto_interno.Text = "0"
       Me.txtotro.Text = "0"
       Me.txttotal_21.Text = "0"
       Me.txttotal_10_5.Text = "0"
       Me.txttotal_sin.Text = "0"
       Me.txttotal_factura.Text = "0"
       Me.lblid_almacen.Text = "0"
       Me.cmbAlmacen.Text =  ""
       Me.lblid_cuenta_contable.Text = "0"
       Me.cmbCuenta_contable.Text =  ""
       Me.lblid_usuario.Text = "0"
       Me.cmbUsuario.Text =  ""
       Me.chktilde.Checked = False
       Me.txtreferencia.Text = ""
       Me.txtsaldo_factura.Text = "0"
       Me.chkpagada.Checked = False
       Me.lblnumero_certificado.Text = "0"
       Me.cmbEro_certificado.Text =  ""
       Me.chkpago_a_cuenta.Checked = False
       Me.chksin_pago.Checked = False
   End Sub

   Private Sub ObtenerDatos()
       Me.txtnumero_factura.Text = oFactura_proveedor.numero_factura.Trim
       Me.lblid_empresa.Text = oFactura_proveedor.id_empresa.ToString
       Me.lblid_tipo_comprobante.Text = oFactura_proveedor.id_tipo_comprobante.ToString
       Me.dtpfecha.Value = oFactura_proveedor.fecha
       Me.dtpfecha_factura.Value = oFactura_proveedor.fecha_factura
       Me.dtpfecha_vencimiento.Value = oFactura_proveedor.fecha_vencimiento
       Me.lblid_proveedor.Text = oFactura_proveedor.id_proveedor.ToString
       Me.txtobservacion.Text = oFactura_proveedor.observacion.Trim
       Me.txtsaldo.Text = oFactura_proveedor.saldo.ToString.Trim
       Me.txtestado.Text = oFactura_proveedor.estado.Trim
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
       Me.txtimpuesto_interno.Text = oFactura_proveedor.impuesto_interno.ToString.Trim
       Me.txtotro.Text = oFactura_proveedor.otro.ToString.Trim
       Me.txttotal_21.Text = oFactura_proveedor.total_21.ToString.Trim
       Me.txttotal_10_5.Text = oFactura_proveedor.total_10_5.ToString.Trim
       Me.txttotal_sin.Text = oFactura_proveedor.total_sin.ToString.Trim
       Me.txttotal_factura.Text = oFactura_proveedor.total_factura.ToString.Trim
       Me.lblid_almacen.Text = oFactura_proveedor.id_almacen.ToString
       Me.lblid_cuenta_contable.Text = oFactura_proveedor.id_cuenta_contable.ToString
       Me.lblid_usuario.Text = oFactura_proveedor.id_usuario.ToString
       Me.chktilde.Checked = oFactura_proveedor.tilde
       Me.txtreferencia.Text = oFactura_proveedor.referencia.Trim
       Me.txtsaldo_factura.Text = oFactura_proveedor.saldo_factura.ToString.Trim
       Me.chkpagada.Checked = oFactura_proveedor.pagada
       Me.lblnumero_certificado.Text = oFactura_proveedor.numero_certificado.ToString
       Me.chkpago_a_cuenta.Checked = oFactura_proveedor.pago_a_cuenta
       Me.chksin_pago.Checked = oFactura_proveedor.sin_pago
   End Sub

   Private Sub AsignarDatos()
       oFactura_proveedor.numero_factura = Me.txtnumero_factura.Text
       oFactura_proveedor.id_empresa = CInt(Me.lblid_empresa.Text)
       oFactura_proveedor.id_tipo_comprobante = CInt(Me.lblid_tipo_comprobante.Text)
       oFactura_proveedor.fecha = Me.dtpfecha.Value.Date
       oFactura_proveedor.fecha_factura = Me.dtpfecha_factura.Value.Date
       oFactura_proveedor.fecha_vencimiento = Me.dtpfecha_vencimiento.Value.Date
       oFactura_proveedor.id_proveedor = CInt(Me.lblid_proveedor.Text)
       oFactura_proveedor.observacion = Me.txtobservacion.Text
       oFactura_proveedor.saldo = CDec(Me.txtsaldo.Text)
       oFactura_proveedor.estado = Me.txtestado.Text
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
       oFactura_proveedor.impuesto_interno = CDec(Me.txtimpuesto_interno.Text)
       oFactura_proveedor.otro = CDec(Me.txtotro.Text)
       oFactura_proveedor.total_21 = CDec(Me.txttotal_21.Text)
       oFactura_proveedor.total_10_5 = CDec(Me.txttotal_10_5.Text)
       oFactura_proveedor.total_sin = CDec(Me.txttotal_sin.Text)
       oFactura_proveedor.total_factura = CDec(Me.txttotal_factura.Text)
       oFactura_proveedor.id_almacen = CInt(Me.lblid_almacen.Text)
       oFactura_proveedor.id_cuenta_contable = CInt(Me.lblid_cuenta_contable.Text)
       oFactura_proveedor.id_usuario = CInt(Me.lblid_usuario.Text)
       oFactura_proveedor.tilde = Me.chktilde.Checked
       oFactura_proveedor.referencia = Me.txtreferencia.Text
       oFactura_proveedor.saldo_factura = CDec(Me.txtsaldo_factura.Text)
       oFactura_proveedor.pagada = Me.chkpagada.Checked
       oFactura_proveedor.numero_certificado = CInt(Me.lblnumero_certificado.Text)
       oFactura_proveedor.pago_a_cuenta = Me.chkpago_a_cuenta.Checked
       oFactura_proveedor.sin_pago = Me.chksin_pago.Checked
   End Sub

   Public Sub SoloLectura()
       Me.txtnumero_factura.Enabled = False
       Me.cmbEmpresa.Enabled = False
       Me.btnBuscaEmpresa.Enabled = False
       Me.cmbTipo_comprobante.Enabled = False
       Me.btnBuscaTipo_comprobante.Enabled = False
       Me.dtpfecha.Enabled = False
       Me.dtpfecha_factura.Enabled = False
       Me.dtpfecha_vencimiento.Enabled = False
       Me.cmbProveedor.Enabled = False
       Me.btnBuscaProveedor.Enabled = False
       Me.txtobservacion.Enabled = False
       Me.txtsaldo.Enabled = False
       Me.txtestado.Enabled = False
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
       Me.txtimpuesto_interno.Enabled = False
       Me.txtotro.Enabled = False
       Me.txttotal_21.Enabled = False
       Me.txttotal_10_5.Enabled = False
       Me.txttotal_sin.Enabled = False
       Me.txttotal_factura.Enabled = False
       Me.cmbAlmacen.Enabled = False
       Me.btnBuscaAlmacen.Enabled = False
       Me.cmbCuenta_contable.Enabled = False
       Me.btnBuscaCuenta_contable.Enabled = False
       Me.cmbUsuario.Enabled = False
       Me.btnBuscaUsuario.Enabled = False
       Me.chktilde.Enabled = False
       Me.txtreferencia.Enabled = False
       Me.txtsaldo_factura.Enabled = False
       Me.chkpagada.Enabled = False
       Me.cmbEro_certificado.Enabled = False
       Me.btnBuscaEro_certificado.Enabled = False
       Me.chkpago_a_cuenta.Enabled = False
       Me.chksin_pago.Enabled = False
       Me.btnGuardar.Visible = False
   End Sub

   Private Sub Guardar()
       Try
           Me.AsignarDatos()
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
                   oFactura_proveedor.Guardar()
                   CType(Me.Owner, frmAbmFactura_proveedor).RefrescarGrilla()
                   Me.CargarCombos()
                   oFactura_proveedor.Insertar()
                   Me.ObtenerDatos()
                   Me.LimpiarControles()
                   Me.txtnumero_factura.Focus
               Case 2 'GUARDA Y SALE (MODIFICAR)
                   oFactura_proveedor.Guardar()
                   Me.Close()
           End Select
       Catch ex As Exception
           MessageBox.Show(ex.Message)
       End Try
   End Sub

   Private Function ChequearVacios() As Boolean
       Dim bandera As Boolean
       If _ 
       Me.txtnumero_factura.Text = "" or _
       Me.txtobservacion.Text = "" or _
       Me.txtsaldo.Text = "" or _
       Me.txtestado.Text = "" or _
       Me.txtalicuota_iva.Text = "" or _
       Me.txtiva_21.Text = "" or _
       Me.txtiva_10_5.Text = "" or _
       Me.txtimporte_21.Text = "" or _
       Me.txtimporte_10_5.Text = "" or _
       Me.txtretencion_iva.Text = "" or _
       Me.txtpercepcion_iva.Text = "" or _
       Me.txtretencion_ingreso_bruto.Text = "" or _
       Me.txtpercepcion_ingreso_bruto.Text = "" or _
       Me.txtretencion_ganancia.Text = "" or _
       Me.txtimpuesto_interno.Text = "" or _
       Me.txtotro.Text = "" or _
       Me.txttotal_21.Text = "" or _
       Me.txttotal_10_5.Text = "" or _
       Me.txttotal_sin.Text = "" or _
       Me.txttotal_factura.Text = "" or _
       Me.txtreferencia.Text = "" or _
       Me.txtsaldo_factura.Text = "" Then
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
       If CDbl(Me.lblid_proveedor.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de proveedor")
           Exit Sub
       End If
       If CDbl(Me.lblid_almacen.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de almacen")
           Exit Sub
       End If
       If CDbl(Me.lblid_cuenta_contable.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de cuenta_contable")
           Exit Sub
       End If
       If CDbl(Me.lblid_usuario.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de usuario")
           Exit Sub
       End If
       If CDbl(Me.lblnumero_certificado.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de ero_certificado")
           Exit Sub
       End If

       blnVacios = Me.ChequearVacios
       If blnVacios = False Then
           MessageBox.Show("Debe Llenar los Campos Obligatorios")
           Exit Sub
       Else
           If BanderaFactura_proveedor  = 1 Then
               Me.Guardar()
           Else
               Me.Guardar()
           End If
       End If
   End Sub

   Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
       Me.Close()
   End Sub

   Private Sub cmbEmpresa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEmpresa.SelectedIndexChanged
       If Me.cmbEmpresa.SelectedIndex >= 0 Then
           Me.lblid_empresa.Text = cmbEmpresa.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaEmpresa.Click
       Dim frmTemporal As New FrmAbmEmpresa
       frmTemporal.ShowDialog()
       Me.CargarEmpresa()
       Me.cmbEmpresa.Focus()
       Me.cmbEmpresa.Text = ""
       Me.lblid_Empresa.Text = "0"
   End Sub

   Private Sub cmbTipo_comprobante_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipo_comprobante.SelectedIndexChanged
       If Me.cmbTipo_comprobante.SelectedIndex >= 0 Then
           Me.lblid_tipo_comprobante.Text = cmbTipo_comprobante.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaTipo_comprobante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaTipo_comprobante.Click
       Dim frmTemporal As New FrmAbmTipo_comprobante
       frmTemporal.ShowDialog()
       Me.CargarTipo_comprobante()
       Me.cmbTipo_comprobante.Focus()
       Me.cmbTipo_comprobante.Text = ""
       Me.lblid_Tipo_comprobante.Text = "0"
   End Sub

   Private Sub cmbProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProveedor.SelectedIndexChanged
       If Me.cmbProveedor.SelectedIndex >= 0 Then
           Me.lblid_proveedor.Text = cmbProveedor.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaProveedor.Click
       Dim frmTemporal As New FrmAbmProveedor
       frmTemporal.ShowDialog()
       Me.CargarProveedor()
       Me.cmbProveedor.Focus()
       Me.cmbProveedor.Text = ""
       Me.lblid_Proveedor.Text = "0"
   End Sub

   Private Sub cmbAlmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAlmacen.SelectedIndexChanged
       If Me.cmbAlmacen.SelectedIndex >= 0 Then
           Me.lblid_almacen.Text = cmbAlmacen.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaAlmacen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaAlmacen.Click
       Dim frmTemporal As New FrmAbmAlmacen
       frmTemporal.ShowDialog()
       Me.CargarAlmacen()
       Me.cmbAlmacen.Focus()
       Me.cmbAlmacen.Text = ""
       Me.lblid_Almacen.Text = "0"
   End Sub

   Private Sub cmbCuenta_contable_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCuenta_contable.SelectedIndexChanged
       If Me.cmbCuenta_contable.SelectedIndex >= 0 Then
           Me.lblid_cuenta_contable.Text = cmbCuenta_contable.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaCuenta_contable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaCuenta_contable.Click
       Dim frmTemporal As New FrmAbmCuenta_contable
       frmTemporal.ShowDialog()
       Me.CargarCuenta_contable()
       Me.cmbCuenta_contable.Focus()
       Me.cmbCuenta_contable.Text = ""
       Me.lblid_Cuenta_contable.Text = "0"
   End Sub

   Private Sub cmbUsuario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUsuario.SelectedIndexChanged
       If Me.cmbUsuario.SelectedIndex >= 0 Then
           Me.lblid_usuario.Text = cmbUsuario.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaUsuario.Click
       Dim frmTemporal As New FrmAbmUsuario
       frmTemporal.ShowDialog()
       Me.CargarUsuario()
       Me.cmbUsuario.Focus()
       Me.cmbUsuario.Text = ""
       Me.lblid_Usuario.Text = "0"
   End Sub

   Private Sub cmbEro_certificado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEro_certificado.SelectedIndexChanged
       If Me.cmbEro_certificado.SelectedIndex >= 0 Then
           Me.lblnumero_certificado.Text = cmbEro_certificado.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaEro_certificado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaEro_certificado.Click
       Dim frmTemporal As New FrmAbmEro_certificado
       frmTemporal.ShowDialog()
       Me.CargarEro_certificado()
       Me.cmbEro_certificado.Focus()
       Me.cmbEro_certificado.Text = ""
       Me.lblid_Ero_certificado.Text = "0"
   End Sub

   Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtnumero_factura.KeyPress, txtobservacion.KeyPress, txtestado.KeyPress, chktilde.KeyPress, txtreferencia.KeyPress, chkpagada.KeyPress, chkpago_a_cuenta.KeyPress, chksin_pago.KeyPress
       If e.KeyChar.ToString = vbCr Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
   Handles cmbEmpresa.KeyDown, cmbTipo_comprobante.KeyDown, dtpfecha.KeyDown, dtpfecha_factura.KeyDown, dtpfecha_vencimiento.KeyDown, cmbProveedor.KeyDown, cmbAlmacen.KeyDown, cmbCuenta_contable.KeyDown, cmbUsuario.KeyDown, cmbEro_certificado.KeyDown
       If CDbl(e.KeyValue.ToString) = 13 Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtsaldo.KeyPress, txtalicuota_iva.KeyPress, txtiva_21.KeyPress, txtiva_10_5.KeyPress, txtimporte_21.KeyPress, txtimporte_10_5.KeyPress, txtretencion_iva.KeyPress, txtpercepcion_iva.KeyPress, txtretencion_ingreso_bruto.KeyPress, txtpercepcion_ingreso_bruto.KeyPress, txtretencion_ganancia.KeyPress, txtimpuesto_interno.KeyPress, txtotro.KeyPress, txttotal_21.KeyPress, txttotal_10_5.KeyPress, txttotal_sin.KeyPress, txttotal_factura.KeyPress, txtsaldo_factura.KeyPress
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

End Class
