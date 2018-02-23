Public Class frmDetalleCliente

    Private Sub frmDetalleCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttGeneral.SetToolTip(Me.btnBuscatipo_dni, "Buscar Nuevo Tipo DNI")
        Me.ttGeneral.SetToolTip(Me.btnBuscacalle, "Buscar Nueva Calle")
        Me.ttGeneral.SetToolTip(Me.btnBuscalocalidad, "Buscar Nueva Localidad")
        Me.ttGeneral.SetToolTip(Me.btnBuscaprovincia, "Buscar Nueva Provincia")
        Me.ttGeneral.SetToolTip(Me.btnBuscacondicion_iva, "Buscar Nueva Condición iva")
        Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar datos del Cliente")
        Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()

            Me.cmbtipo_dni.Text = oTipo_dni.GetOne(CInt(Me.lblid_tipo_dni.Text)).Rows(0).Item("nombre_Tipo_dni").ToString.Trim
            Me.cmbcalle.Text = oCalle.GetOne(CInt(Me.lblid_calle.Text)).Rows(0).Item("nombre_Calle").ToString.Trim
            Me.cmblocalidad.Text = oLocalidad.GetOne(CInt(Me.lblid_localidad.Text)).Rows(0).Item("nombre_Localidad").ToString.Trim
            Me.cmbprovincia.Text = oProvincia.GetOne(CInt(Me.lblid_provincia.Text)).Rows(0).Item("nombre_Provincia").ToString.Trim
            Me.cmbcondicion_iva.Text = oCondicion_iva.GetOne(CInt(Me.lblid_condicion_iva.Text)).Rows(0).Item("nombre_Condicion_iva").ToString.Trim
        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try

        If BanderaCliente = 1 Then
            Me.LimpiarControles()
        End If
        Me.Text = "Cliente"
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False
    End Sub

    Sub CargarCombos()
        Me.CargarTipo_dni()
        Me.CargarCalle()
        Me.CargarLocalidad()
        Me.CargarProvincia()
        Me.CargarCondicion_iva()
    End Sub

    Sub CargarTipo_dni()
        Dim odt As New DataTable

        odt = oTipo_dni.GetCmb
        With Me.cmbTipo_dni
            .DataSource = odt
            .DisplayMember = "nombre_tipo_dni"
            .ValueMember = "id_tipo_dni"
        End With
        If Me.cmbTipo_dni.SelectedIndex >= 0 Then
            cmbTipo_dni.SelectedIndex = 0
            Me.lblid_Tipo_dni.Text = cmbTipo_dni.SelectedValue.ToString
        End If
    End Sub

    Sub CargarCalle()
        Dim odt As New DataTable

        odt = oCalle.GetCmb
        With Me.cmbCalle
            .DataSource = odt
            .DisplayMember = "nombre_calle"
            .ValueMember = "id_calle"
        End With
        If Me.cmbCalle.SelectedIndex >= 0 Then
            cmbCalle.SelectedIndex = 0
            Me.lblid_Calle.Text = cmbCalle.SelectedValue.ToString
        End If
    End Sub

    Sub CargarLocalidad()
        Dim odt As New DataTable

        odt = oLocalidad.GetCmb
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

    Sub CargarCondicion_iva()
        Dim odt As New DataTable

        odt = oCondicion_iva.GetCmb
        With Me.cmbCondicion_iva
            .DataSource = odt
            .DisplayMember = "nombre_condicion_iva"
            .ValueMember = "id_condicion_iva"
        End With
        If Me.cmbCondicion_iva.SelectedIndex >= 0 Then
            cmbCondicion_iva.SelectedIndex = 0
            Me.lblid_Condicion_iva.Text = cmbCondicion_iva.SelectedValue.ToString
        End If
    End Sub

    Sub LimpiarControles()
        Me.txtnombre_cliente.Text = ""
        Me.txtapellido_cliente.Text = ""
        Me.txtrazon_social.Text = ""
        Me.txtnombre_fantasia.Text = ""
        Me.txtcontacto.Text = ""
        Me.txtdni_cliente.Text = ""
        Me.lblid_tipo_dni.Text = "0"
        Me.cmbTipo_dni.Text = ""
        Me.lblid_calle.Text = "0"
        Me.cmbCalle.Text = ""
        Me.txtdireccion_cliente.Text = ""
        Me.lblid_localidad.Text = "0"
        Me.cmbLocalidad.Text = ""
        Me.lblid_provincia.Text = "0"
        Me.cmbProvincia.Text = ""
        Me.txttelefono.Text = ""
        Me.txtmail.Text = ""
        Me.txtweb.Text = ""
        Me.lblid_condicion_iva.Text = "0"
        Me.cmbCondicion_iva.Text = ""
        Me.txtingreso_bruto.Text = ""
        Me.txtlugar_pago.Text = ""
        Me.chkpercepcion_iva.Checked = False
        Me.chkpercepcion_ingreso_bruto.Checked = False
        Me.chkretencion_iva.Checked = False
        Me.chkretencion_ingreso_bruto.Checked = False
        Me.txtnumero_proveedor.Text = ""
    End Sub

    Private Sub ObtenerDatos()
        Me.txtnombre_cliente.Text = oCliente.nombre_cliente.Trim
        Me.txtapellido_cliente.Text = oCliente.apellido_cliente.Trim
        Me.txtrazon_social.Text = oCliente.razon_social.Trim
        Me.txtnombre_fantasia.Text = oCliente.nombre_fantasia.Trim
        Me.txtcontacto.Text = oCliente.contacto.Trim
        Me.txtdni_cliente.Text = oCliente.dni_cliente.Trim
        Me.lblid_tipo_dni.Text = oCliente.id_tipo_dni.ToString
        Me.lblid_calle.Text = oCliente.id_calle.ToString
        Me.txtdireccion_cliente.Text = oCliente.direccion_cliente.Trim
        Me.lblid_localidad.Text = oCliente.id_localidad.ToString
        Me.lblid_provincia.Text = oCliente.id_provincia.ToString
        Me.txttelefono.Text = oCliente.telefono.Trim
        Me.txtmail.Text = oCliente.mail.Trim
        Me.txtweb.Text = oCliente.web.Trim
        Me.lblid_condicion_iva.Text = oCliente.id_condicion_iva.ToString
        Me.txtingreso_bruto.Text = oCliente.ingreso_bruto.Trim
        Me.txtlugar_pago.Text = oCliente.lugar_pago.Trim
        Me.chkpercepcion_iva.Checked = oCliente.percepcion_iva
        Me.chkpercepcion_ingreso_bruto.Checked = oCliente.percepcion_ingreso_bruto
        Me.chkretencion_iva.Checked = oCliente.retencion_iva
        Me.chkretencion_ingreso_bruto.Checked = oCliente.retencion_ingreso_bruto
        Me.txtnumero_proveedor.Text = oCliente.numero_proveedor.Trim
    End Sub

    Private Sub AsignarDatos()
        oCliente.nombre_cliente = Me.txtnombre_cliente.Text
        oCliente.apellido_cliente = Me.txtapellido_cliente.Text
        oCliente.razon_social = Me.txtrazon_social.Text
        oCliente.nombre_fantasia = Me.txtnombre_fantasia.Text
        oCliente.contacto = Me.txtcontacto.Text
        oCliente.dni_cliente = Me.txtdni_cliente.Text
        oCliente.id_tipo_dni = CInt(Me.lblid_tipo_dni.Text)
        oCliente.id_calle = CInt(Me.lblid_calle.Text)
        oCliente.direccion_cliente = Me.txtdireccion_cliente.Text
        oCliente.id_localidad = CInt(Me.lblid_localidad.Text)
        oCliente.id_provincia = CInt(Me.lblid_provincia.Text)
        oCliente.telefono = Me.txttelefono.Text
        oCliente.mail = Me.txtmail.Text
        oCliente.web = Me.txtweb.Text
        oCliente.id_condicion_iva = CInt(Me.lblid_condicion_iva.Text)
        oCliente.ingreso_bruto = Me.txtingreso_bruto.Text
        oCliente.lugar_pago = Me.txtlugar_pago.Text
        oCliente.percepcion_iva = Me.chkpercepcion_iva.Checked
        oCliente.percepcion_ingreso_bruto = Me.chkpercepcion_ingreso_bruto.Checked
        oCliente.retencion_iva = Me.chkretencion_iva.Checked
        oCliente.retencion_ingreso_bruto = Me.chkretencion_ingreso_bruto.Checked
        oCliente.numero_proveedor = Me.txtnumero_proveedor.Text
    End Sub

    Public Sub SoloLectura()
        Me.txtnombre_cliente.Enabled = False
        Me.txtapellido_cliente.Enabled = False
        Me.txtrazon_social.Enabled = False
        Me.txtnombre_fantasia.Enabled = False
        Me.txtcontacto.Enabled = False
        Me.txtdni_cliente.Enabled = False
        Me.cmbTipo_dni.Enabled = False
        Me.btnBuscaTipo_dni.Enabled = False
        Me.cmbCalle.Enabled = False
        Me.btnBuscaCalle.Enabled = False
        Me.txtdireccion_cliente.Enabled = False
        Me.cmbLocalidad.Enabled = False
        Me.btnBuscaLocalidad.Enabled = False
        Me.cmbProvincia.Enabled = False
        Me.btnBuscaProvincia.Enabled = False
        Me.txttelefono.Enabled = False
        Me.txtmail.Enabled = False
        Me.txtweb.Enabled = False
        Me.cmbCondicion_iva.Enabled = False
        Me.btnBuscaCondicion_iva.Enabled = False
        Me.txtingreso_bruto.Enabled = False
        Me.txtlugar_pago.Enabled = False
        Me.chkpercepcion_iva.Enabled = False
        Me.chkpercepcion_ingreso_bruto.Enabled = False
        Me.chkretencion_iva.Enabled = False
        Me.chkretencion_ingreso_bruto.Enabled = False
        Me.txtnumero_proveedor.Enabled = False
        Me.btnGuardar.Visible = False
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            If oCliente.Exist() Then
                If BanderaCliente = 1 Then
                    MessageBox.Show("Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
                    Exit Sub
                ElseIf BanderaCliente = 2 Then
                    If MessageBox.Show("Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                        = System.Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            Select Case BanderaCliente
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oCliente.Guardar()

                    'modificado antes estaba CType(Me.Owner, frmAbmCliente).RefrescarGrilla()
                    Try
                        CType(Me.Owner, frmAbmCliente).RefrescarGrilla()
                    Catch ex As Exception
                        'CType(Me.Owner, frmResumenCliente).RefrescarGrillaClientes()
                    End Try


                    Me.CargarCombos()
                    oCliente.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.txtnombre_cliente.Focus()
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oCliente.Guardar()
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If Me.txtnombre_cliente.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean

        'If CDbl(Me.lblid_tipo_dni.Text) = 0 Then
        '    MessageBox.Show("Debe Seleccionar un Dato del Combo de tipo DNI")
        '    Exit Sub
        'End If
        'If CDbl(Me.lblid_calle.Text) = 0 Then
        '    MessageBox.Show("Debe Seleccionar un Dato del Combo de calle")
        '    Exit Sub
        'End If
        'If CDbl(Me.lblid_localidad.Text) = 0 Then
        '    MessageBox.Show("Debe Seleccionar un Dato del Combo de localidad")
        '    Exit Sub
        'End If
        'If CDbl(Me.lblid_provincia.Text) = 0 Then
        '    MessageBox.Show("Debe Seleccionar un Dato del Combo de provincia")
        '    Exit Sub
        'End If
        'If CDbl(Me.lblid_condicion_iva.Text) = 0 Then
        '    MessageBox.Show("Debe Seleccionar un Dato del Combo de condición IVA")
        '    Exit Sub
        'End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaCliente = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cmbTipo_dni_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtipo_dni.SelectedIndexChanged
        If Me.cmbtipo_dni.SelectedIndex >= 0 Then
            Me.lblid_tipo_dni.Text = cmbtipo_dni.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaTipo_dni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscatipo_dni.Click
        'Dim frmTemporal As New FrmAbmTipo_dni
        'frmTemporal.ShowDialog()
        'Me.CargarTipo_dni()
        'Me.cmbTipo_dni.Focus()
        'Me.cmbTipo_dni.Text = ""
        'Me.lblid_Tipo_dni.Text = "0"
    End Sub

    Private Sub cmbCalle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcalle.SelectedIndexChanged
        If Me.cmbcalle.SelectedIndex >= 0 Then
            Me.lblid_calle.Text = cmbcalle.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaCalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscacalle.Click
        'Dim frmTemporal As New FrmAbmCalle
        'frmTemporal.ShowDialog()
        'Me.CargarCalle()
        'Me.cmbCalle.Focus()
        'Me.cmbCalle.Text = ""
        'Me.lblid_Calle.Text = "0"
    End Sub

    Private Sub cmbLocalidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmblocalidad.SelectedIndexChanged
        If Me.cmblocalidad.SelectedIndex >= 0 Then
            Me.lblid_localidad.Text = cmblocalidad.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaLocalidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscalocalidad.Click
        'Dim frmTemporal As New FrmAbmLocalidad
        'frmTemporal.ShowDialog()
        'Me.CargarLocalidad()
        'Me.cmbLocalidad.Focus()
        'Me.cmbLocalidad.Text = ""
        'Me.lblid_Localidad.Text = "0"
    End Sub

    Private Sub cmbProvincia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbprovincia.SelectedIndexChanged
        If Me.cmbprovincia.SelectedIndex >= 0 Then
            Me.lblid_provincia.Text = cmbprovincia.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaProvincia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaprovincia.Click
        'Dim frmTemporal As New FrmAbmProvincia
        'frmTemporal.ShowDialog()
        'Me.CargarProvincia()
        'Me.cmbProvincia.Focus()
        'Me.cmbProvincia.Text = ""
        'Me.lblid_Provincia.Text = "0"
    End Sub

    Private Sub cmbCondicion_iva_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcondicion_iva.SelectedIndexChanged
        If Me.cmbcondicion_iva.SelectedIndex >= 0 Then
            Me.lblid_condicion_iva.Text = cmbcondicion_iva.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaCondicion_iva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscacondicion_iva.Click
        'Dim frmTemporal As New FrmAbmCondicion_iva
        'frmTemporal.ShowDialog()
        'Me.CargarCondicion_iva()
        'Me.cmbCondicion_iva.Focus()
        'Me.cmbCondicion_iva.Text = ""
        'Me.lblid_Condicion_iva.Text = "0"
    End Sub

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtnombre_cliente.KeyPress, txtapellido_cliente.KeyPress, txtrazon_social.KeyPress, txtnombre_fantasia.KeyPress, txtcontacto.KeyPress, txtdni_cliente.KeyPress, txtdireccion_cliente.KeyPress, txttelefono.KeyPress, txtmail.KeyPress, txtweb.KeyPress, txtingreso_bruto.KeyPress, txtlugar_pago.KeyPress, chkpercepcion_iva.KeyPress, chkpercepcion_ingreso_bruto.KeyPress, chkretencion_iva.KeyPress, chkretencion_ingreso_bruto.KeyPress, txtnumero_proveedor.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles cmbtipo_dni.KeyDown, cmbcalle.KeyDown, cmblocalidad.KeyDown, cmbprovincia.KeyDown, cmbcondicion_iva.KeyDown
        If CDbl(e.KeyValue.ToString) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

        Else
            e.Handled = True
        End If
    End Sub



End Class
