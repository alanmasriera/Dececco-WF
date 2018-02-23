Public Class frmDetallePresupuesto

    Dim BanderaCierreForm As Boolean = False
    Private Sub frmDetallePresupuesto_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If BanderaCierreForm = False Then
            e.Cancel = True
        End If
    End Sub

    Private Sub frmDetallePresupuesto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.ttGeneral.SetToolTip(Me.btnBuscaCliente, "Buscar Nuevo Cliente")
        Me.ttGeneral.SetToolTip(Me.btnBuscaTipo_moneda, "Buscar Nuevo Tipo_moneda")
        Me.ttGeneral.SetToolTip(Me.btnBuscaForma_pago, "Buscar Nuevo Forma_pago")
        Me.ttGeneral.SetToolTip(Me.btnBuscaMedio_entrega, "Buscar Nuevo Medio_entrega")
        Me.ttGeneral.SetToolTip(Me.btnBuscaPreparo, "Buscar Nuevo Preparo")
        Me.ttGeneral.SetToolTip(Me.btnBuscaResponsable_calidad, "Buscar Nuevo Responsable_calidad")
        Me.ttGeneral.SetToolTip(Me.btnBuscaAprobo, "Buscar Nuevo Aprobo")
        Me.ttGeneral.SetToolTip(Me.btnBuscaDireccion_general, "Buscar Nuevo Direccion_general")
        Me.ttGeneral.SetToolTip(Me.btnBuscaFirma, "Buscar Nuevo Firma")
        Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Presupuesto")
        Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()
            Me.cmbtipo_moneda.Text = oTipo_moneda.GetOne(CInt(Me.lblid_tipo_moneda.Text)).Rows(0).Item("nombre tipo moneda").ToString.Trim
            Me.cmbforma_pago.Text = oForma_pago.GetOne(CInt(Me.lblid_forma_pago.Text)).Rows(0).Item("nombre forma pago").ToString.Trim
            Me.cmbmedio_entrega.Text = oMedio_entrega.GetOne(CInt(Me.lblid_medio_entrega.Text)).Rows(0).Item("nombre medio entrega").ToString.Trim
            Me.cmbpreparo.Text = oPreparo.GetOne(CInt(Me.lblid_preparo.Text)).Rows(0).Item("nombre_usuario").ToString.Trim
            Me.cmbresponsable_calidad.Text = oResponsable_calidad.GetOne(CInt(Me.lblid_responsable_calidad.Text)).Rows(0).Item("nombre_usuario").ToString.Trim
            Me.cmbaprobo.Text = oAprobo.GetOne(CInt(Me.lblid_aprobo.Text)).Rows(0).Item("nombre_usuario").ToString.Trim
            Me.cmbdireccion_general.Text = oDireccion_general.GetOne(CInt(Me.lblid_direccion_general.Text)).Rows(0).Item("nombre_usuario").ToString.Trim
            Me.cmbfirma.Text = oFirma.GetOne(CInt(Me.lblid_firma.Text)).Rows(0).Item("nombre_usuario").ToString.Trim

            Me.cmbcliente.Text = oCliente.GetOne(CInt(Me.lblid_cliente.Text)).Rows(0).Item("nombre_cliente").ToString.Trim
        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try
        If vgFormularioPadre = "frmAbmPresupuesto" Then
            Me.lblid_Presupuesto.Text = CType(Me.Owner, frmAbmPresupuesto).lblid_pk.Text
            Me.lblid_cliente.Text = CStr(parametro_id_cliente = CInt(Me.lblid_cliente.Text))
            Me.cmbcliente.Text = parametro_cliente
        Else
            Me.lblid_Presupuesto.Text = CType(Me.Owner, frmResumenCliente).lblid_presupuesto.Text

            Me.cmbcliente.Text = CType(Me.Owner, frmResumenCliente).cmbCliente.Text
            Me.lblid_cliente.Text = CType(Me.Owner, frmResumenCliente).lblid_cliente.Text
        End If


        If BanderaPresupuesto = 1 Then
            Me.LimpiarControles()
        End If
        Me.Text = "Presupuesto"
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False

        oCuerpo_Presupuesto.Cargar()
        Me.RefrescarGrilla()
    End Sub

    Sub CargarCombos()
        'me.CargarCliente()
        Me.CargarTipo_moneda()
        Me.CargarForma_pago()
        Me.CargarMedio_entrega()
        Me.CargarPreparo()
        Me.CargarResponsable_calidad()
        Me.CargarAprobo()
        Me.CargarDireccion_general()
        Me.CargarFirma()
    End Sub

    'Sub CargarCliente()
    '    Dim odt As New DataTable

    '    odt = oCliente.GetCmb
    '    With Me.cmbCliente
    '        .DataSource = odt
    '        .DisplayMember = "nombre_Cliente"
    '        .ValueMember = "id_Cliente"
    '    End With
    '    If Me.cmbCliente.SelectedIndex >= 0 Then
    '        cmbCliente.SelectedIndex = 0
    '        Me.lblid_Cliente.Text = cmbCliente.SelectedValue.ToString
    '    End If
    'End Sub

    Sub CargarTipo_moneda()
        Dim odt As New DataTable

        odt = oTipo_moneda.GetCmb
        With Me.cmbTipo_moneda
            .DataSource = odt
            .DisplayMember = "nombre_Tipo_moneda"
            .ValueMember = "id_Tipo_moneda"
        End With
        If Me.cmbTipo_moneda.SelectedIndex >= 0 Then
            cmbTipo_moneda.SelectedIndex = 0
            Me.lblid_Tipo_moneda.Text = cmbTipo_moneda.SelectedValue.ToString
        End If
    End Sub

    Sub CargarForma_pago()
        Dim odt As New DataTable

        odt = oForma_pago.GetCmb
        With Me.cmbForma_pago
            .DataSource = odt
            .DisplayMember = "nombre_Forma_pago"
            .ValueMember = "id_Forma_pago"
        End With
        If Me.cmbForma_pago.SelectedIndex >= 0 Then
            cmbForma_pago.SelectedIndex = 0
            Me.lblid_Forma_pago.Text = cmbForma_pago.SelectedValue.ToString
        End If
    End Sub

    Sub CargarMedio_entrega()
        Dim odt As New DataTable

        odt = oMedio_entrega.GetCmb
        With Me.cmbMedio_entrega
            .DataSource = odt
            .DisplayMember = "nombre_Medio_entrega"
            .ValueMember = "id_Medio_entrega"
        End With
        If Me.cmbMedio_entrega.SelectedIndex >= 0 Then
            cmbMedio_entrega.SelectedIndex = 0
            Me.lblid_Medio_entrega.Text = cmbMedio_entrega.SelectedValue.ToString
        End If
    End Sub

    Sub CargarPreparo()
        Dim odt As New DataTable

        odt = oPreparo.GetCmb
        With Me.cmbPreparo
            .DataSource = odt
            .DisplayMember = "nombre_usuario"
            .ValueMember = "id_usuario"
        End With
        If Me.cmbPreparo.SelectedIndex >= 0 Then
            cmbPreparo.SelectedIndex = 0
            Me.lblid_Preparo.Text = cmbPreparo.SelectedValue.ToString
        End If
    End Sub

    Sub CargarResponsable_calidad()
        Dim odt As New DataTable

        odt = oResponsable_calidad.GetCmb
        With Me.cmbResponsable_calidad
            .DataSource = odt
            .DisplayMember = "nombre_usuario"
            .ValueMember = "id_usuario"
        End With
        If Me.cmbResponsable_calidad.SelectedIndex >= 0 Then
            cmbResponsable_calidad.SelectedIndex = 0
            Me.lblid_Responsable_calidad.Text = cmbResponsable_calidad.SelectedValue.ToString
        End If
    End Sub

    Sub CargarAprobo()
        Dim odt As New DataTable

        odt = oAprobo.GetCmb
        With Me.cmbAprobo
            .DataSource = odt
            .DisplayMember = "nombre_usuario"
            .ValueMember = "id_usuario"
        End With
        If Me.cmbAprobo.SelectedIndex >= 0 Then
            cmbAprobo.SelectedIndex = 0
            Me.lblid_Aprobo.Text = cmbAprobo.SelectedValue.ToString
        End If
    End Sub

    Sub CargarDireccion_general()
        Dim odt As New DataTable

        odt = oDireccion_general.GetCmb
        With Me.cmbDireccion_general
            .DataSource = odt
            .DisplayMember = "nombre_usuario"
            .ValueMember = "id_usuario"
        End With
        If Me.cmbDireccion_general.SelectedIndex >= 0 Then
            cmbDireccion_general.SelectedIndex = 0
            Me.lblid_Direccion_general.Text = cmbDireccion_general.SelectedValue.ToString
        End If
    End Sub

    Sub CargarFirma()
        Dim odt As New DataTable

        odt = oFirma.GetCmb
        With Me.cmbFirma
            .DataSource = odt
            .DisplayMember = "nombre_usuario"
            .ValueMember = "id_usuario"
        End With
        If Me.cmbFirma.SelectedIndex >= 0 Then
            cmbFirma.SelectedIndex = 0
            Me.lblid_Firma.Text = cmbFirma.SelectedValue.ToString
        End If
    End Sub

    Sub LimpiarControles()
        Me.lblid_Presupuesto.Text = "0"
        Me.txtnumero.Text = ""
        'Me.lblid_Presupuesto.Text = "0"
        Me.txtnumero_presupuesto.Text = ""
        'Me.lblid_Presupuesto.Text = "0"
        Me.dtpfecha_presupuesto.Value = DateTime.Now
        ' Me.lblid_Presupuesto.Text = "0"
        Me.txtnumero_revision.Text = ""
        ' Me.lblid_Presupuesto.Text = "0"
        'Me.lblid_cliente.Text = "0"
        'Me.cmbCliente.Text = ""
        ' Me.lblid_Presupuesto.Text = "0"
        Me.dtpplazo_entrega.Value = DateTime.Now
        'Me.lblid_Presupuesto.Text = "0"
        Me.txtimporte_total.Text = ""
        'Me.lblid_Presupuesto.Text = "0"
        Me.lblid_tipo_moneda.Text = "0"
        Me.cmbTipo_moneda.Text = ""
        'Me.lblid_Presupuesto.Text = "0"
        Me.lblid_forma_pago.Text = "0"
        Me.cmbForma_pago.Text = ""
        'Me.lblid_Presupuesto.Text = "0"
        Me.lblid_medio_entrega.Text = "0"
        Me.cmbMedio_entrega.Text = ""
        'Me.lblid_Presupuesto.Text = "0"
        Me.lblid_preparo.Text = "0"
        Me.cmbPreparo.Text = ""
        'Me.lblid_Presupuesto.Text = "0"
        Me.lblid_responsable_calidad.Text = "0"
        Me.cmbResponsable_calidad.Text = ""
        'Me.lblid_Presupuesto.Text = "0"
        Me.lblid_aprobo.Text = "0"
        Me.cmbAprobo.Text = ""
        'Me.lblid_Presupuesto.Text = "0"
        Me.lblid_direccion_general.Text = "0"
        Me.cmbDireccion_general.Text = ""
        'Me.lblid_Presupuesto.Text = "0"
        Me.dtpfecha_emision.Value = DateTime.Now
        'Me.lblid_Presupuesto.Text = "0"
        Me.dtpfecha_revision.Value = DateTime.Now
        'Me.lblid_Presupuesto.Text = "0"
        Me.lblid_firma.Text = "0"
        Me.cmbFirma.Text = ""
        'Me.lblid_Presupuesto.Text = "0"
    End Sub

    Private Sub ObtenerDatos()
        Me.txtnumero.Text = oPresupuesto.numero.Trim
        Me.txtnumero_presupuesto.Text = oPresupuesto.numero_presupuesto.Trim
        Me.dtpfecha_presupuesto.Value = oPresupuesto.fecha_presupuesto
        Me.txtnumero_revision.Text = oPresupuesto.numero_revision.Trim
        'Me.lblid_cliente.Text = oPresupuesto.id_cliente.ToString
        Me.dtpplazo_entrega.Value = oPresupuesto.plazo_entrega
        Me.txtimporte_total.Text = oPresupuesto.importe_total.ToString.Trim
        Me.lblid_tipo_moneda.Text = oPresupuesto.id_tipo_moneda.ToString
        Me.lblid_forma_pago.Text = oPresupuesto.id_forma_pago.ToString
        Me.lblid_medio_entrega.Text = oPresupuesto.id_medio_entrega.ToString
        Me.lblid_preparo.Text = oPresupuesto.id_preparo.ToString
        Me.lblid_responsable_calidad.Text = oPresupuesto.id_responsable_calidad.ToString
        Me.lblid_aprobo.Text = oPresupuesto.id_aprobo.ToString
        Me.lblid_direccion_general.Text = oPresupuesto.id_direccion_general.ToString
        Me.dtpfecha_emision.Value = oPresupuesto.fecha_emision
        Me.dtpfecha_revision.Value = oPresupuesto.fecha_revision
        Me.lblid_firma.Text = oPresupuesto.id_firma.ToString
    End Sub

    Private Sub AsignarDatos()
        oPresupuesto.numero = Me.txtnumero.Text
        oPresupuesto.numero_presupuesto = Me.txtnumero_presupuesto.Text
        oPresupuesto.fecha_presupuesto = Me.dtpfecha_presupuesto.Value.Date
        oPresupuesto.numero_revision = Me.txtnumero_revision.Text
        oPresupuesto.id_cliente = CInt(Me.lblid_cliente.Text)
        oPresupuesto.plazo_entrega = Me.dtpplazo_entrega.Value.Date
        oPresupuesto.importe_total = CDec(Me.txtimporte_total.Text)
        oPresupuesto.id_tipo_moneda = CInt(Me.lblid_tipo_moneda.Text)
        oPresupuesto.id_forma_pago = CInt(Me.lblid_forma_pago.Text)
        oPresupuesto.id_medio_entrega = CInt(Me.lblid_medio_entrega.Text)
        oPresupuesto.id_preparo = CInt(Me.lblid_preparo.Text)
        oPresupuesto.id_responsable_calidad = CInt(Me.lblid_responsable_calidad.Text)
        oPresupuesto.id_aprobo = CInt(Me.lblid_aprobo.Text)
        oPresupuesto.id_direccion_general = CInt(Me.lblid_direccion_general.Text)
        oPresupuesto.fecha_emision = Me.dtpfecha_emision.Value.Date
        oPresupuesto.fecha_revision = Me.dtpfecha_revision.Value.Date
        oPresupuesto.id_firma = CInt(Me.lblid_firma.Text)
    End Sub

    Public Sub SoloLectura()
        Me.txtnumero.Enabled = False
        Me.txtnumero_presupuesto.Enabled = False
        Me.dtpfecha_presupuesto.Enabled = False
        Me.txtnumero_revision.Enabled = False
        Me.cmbCliente.Enabled = False
        'Me.btnBuscaCliente.Enabled = False
        Me.dtpplazo_entrega.Enabled = False
        Me.txtimporte_total.Enabled = False
        Me.cmbTipo_moneda.Enabled = False
        Me.btnBuscaTipo_moneda.Enabled = False
        Me.cmbForma_pago.Enabled = False
        Me.btnBuscaForma_pago.Enabled = False
        Me.cmbMedio_entrega.Enabled = False
        Me.btnBuscaMedio_entrega.Enabled = False
        Me.cmbPreparo.Enabled = False
        Me.btnBuscaPreparo.Enabled = False
        Me.cmbResponsable_calidad.Enabled = False
        Me.btnBuscaResponsable_calidad.Enabled = False
        Me.cmbAprobo.Enabled = False
        Me.btnBuscaAprobo.Enabled = False
        Me.cmbDireccion_general.Enabled = False
        Me.btnBuscaDireccion_general.Enabled = False
        Me.dtpfecha_emision.Enabled = False
        Me.dtpfecha_revision.Enabled = False
        Me.cmbFirma.Enabled = False
        Me.btnBuscaFirma.Enabled = False
        Me.btnGuardar.Visible = False
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            If oPresupuesto.Exist() Then
                If BanderaPresupuesto = 1 Then
                    MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
                    Exit Sub
                ElseIf BanderaPresupuesto = 2 Then
                    If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                        = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            Select Case BanderaPresupuesto
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oPresupuesto.Guardar()

                    Me.lblid_Presupuesto.Text = oPresupuesto.id_Presupuesto.ToString
                    oCuerpo_presupuesto.UpdateID(CInt(Me.lblid_Presupuesto.Text), vgCodigoUsuario)

                    CType(Me.Owner, frmResumenCliente).RefrescarGrillaPresupuesto()
                    'Me.CargarCombos()
                    oPresupuesto.Insertar()
                    'Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.txtnumero.Focus()
                    Me.RefrescarGrilla()

                    Me.lblid_Presupuesto.Text = "0"
                    Me.RefrescarGrilla()

                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oPresupuesto.Guardar()
                    BanderaCierreForm = True
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If Me.txtnumero.Text = "" Then
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
        If CDbl(Me.lblid_tipo_moneda.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de tipo_moneda")
            Exit Sub
        End If
        If CDbl(Me.lblid_forma_pago.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de forma_pago")
            Exit Sub
        End If
        If CDbl(Me.lblid_medio_entrega.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de medio_entrega")
            Exit Sub
        End If
        If CDbl(Me.lblid_preparo.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de preparo")
            Exit Sub
        End If
        If CDbl(Me.lblid_responsable_calidad.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de responsable_calidad")
            Exit Sub
        End If
        If CDbl(Me.lblid_aprobo.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de aprobo")
            Exit Sub
        End If
        If CDbl(Me.lblid_direccion_general.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de direccion_general")
            Exit Sub
        End If
        If CDbl(Me.lblid_firma.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de firma")
            Exit Sub
        End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaPresupuesto = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        BanderaCierreForm = True
        If Me.lblid_Presupuesto.Text = "0" Then
            oCuerpo_presupuesto.Deletepresupuesto(0, vgCodigoUsuario)
        End If

        Me.Close()
    End Sub

    Private Sub cmbCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcliente.SelectedIndexChanged
        If Me.cmbCliente.SelectedIndex >= 0 Then
            Me.lblid_cliente.Text = cmbCliente.SelectedValue.ToString
        End If
    End Sub

    'Private Sub btnBuscaCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim frmTemporal As New frmAbmCliente
    '    frmTemporal.ShowDialog()
    '    'Me.CargarCliente()
    '    Me.cmbcliente.Focus()
    '    Me.cmbcliente.Text = ""
    '    Me.lblid_cliente.Text = "0"
    'End Sub

    Private Sub cmbTipo_moneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtipo_moneda.SelectedIndexChanged
        If Me.cmbTipo_moneda.SelectedIndex >= 0 Then
            Me.lblid_tipo_moneda.Text = cmbTipo_moneda.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaTipo_moneda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscatipo_moneda.Click
        Dim frmTemporal As New FrmAbmTipo_moneda
        frmTemporal.ShowDialog()
        Me.CargarTipo_moneda()
        Me.cmbTipo_moneda.Focus()
        Me.cmbTipo_moneda.Text = ""
        Me.lblid_Tipo_moneda.Text = "0"
    End Sub

    Private Sub cmbForma_pago_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbforma_pago.SelectedIndexChanged
        If Me.cmbForma_pago.SelectedIndex >= 0 Then
            Me.lblid_forma_pago.Text = cmbForma_pago.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaForma_pago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaforma_pago.Click
        Dim frmTemporal As New FrmAbmForma_pago
        frmTemporal.ShowDialog()
        Me.CargarForma_pago()
        Me.cmbForma_pago.Focus()
        Me.cmbForma_pago.Text = ""
        Me.lblid_Forma_pago.Text = "0"
    End Sub

    Private Sub cmbMedio_entrega_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbmedio_entrega.SelectedIndexChanged
        If Me.cmbMedio_entrega.SelectedIndex >= 0 Then
            Me.lblid_medio_entrega.Text = cmbMedio_entrega.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaMedio_entrega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscamedio_entrega.Click
        Dim frmTemporal As New FrmAbmMedio_entrega
        frmTemporal.ShowDialog()
        Me.CargarMedio_entrega()
        Me.cmbMedio_entrega.Focus()
        Me.cmbMedio_entrega.Text = ""
        Me.lblid_Medio_entrega.Text = "0"
    End Sub

    Private Sub cmbPreparo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbpreparo.SelectedIndexChanged
        If Me.cmbPreparo.SelectedIndex >= 0 Then
            Me.lblid_preparo.Text = cmbPreparo.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaPreparo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscapreparo.Click
        Dim frmTemporal As New frmAbmUsuario
        frmTemporal.ShowDialog()
        Me.CargarPreparo()
        Me.cmbPreparo.Focus()
        Me.cmbPreparo.Text = ""
        Me.lblid_Preparo.Text = "0"
    End Sub

    Private Sub cmbResponsable_calidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbresponsable_calidad.SelectedIndexChanged
        If Me.cmbResponsable_calidad.SelectedIndex >= 0 Then
            Me.lblid_responsable_calidad.Text = cmbResponsable_calidad.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaResponsable_calidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaresponsable_calidad.Click
        Dim frmTemporal As New frmAbmUsuario
        frmTemporal.ShowDialog()
        Me.CargarResponsable_calidad()
        Me.cmbResponsable_calidad.Focus()
        Me.cmbResponsable_calidad.Text = ""
        Me.lblid_Responsable_calidad.Text = "0"
    End Sub

    Private Sub cmbAprobo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbaprobo.SelectedIndexChanged
        If Me.cmbAprobo.SelectedIndex >= 0 Then
            Me.lblid_aprobo.Text = cmbAprobo.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaAprobo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaaprobo.Click
        Dim frmTemporal As New frmAbmUsuario
        frmTemporal.ShowDialog()
        Me.CargarAprobo()
        Me.cmbAprobo.Focus()
        Me.cmbAprobo.Text = ""
        Me.lblid_Aprobo.Text = "0"
    End Sub

    Private Sub cmbDireccion_general_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdireccion_general.SelectedIndexChanged
        If Me.cmbDireccion_general.SelectedIndex >= 0 Then
            Me.lblid_direccion_general.Text = cmbDireccion_general.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaDireccion_general_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscadireccion_general.Click
        Dim frmTemporal As New frmAbmUsuario
        frmTemporal.ShowDialog()
        Me.CargarDireccion_general()
        Me.cmbDireccion_general.Focus()
        Me.cmbDireccion_general.Text = ""
        Me.lblid_Direccion_general.Text = "0"
    End Sub

    Private Sub cmbFirma_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbfirma.SelectedIndexChanged
        If Me.cmbFirma.SelectedIndex >= 0 Then
            Me.lblid_firma.Text = cmbFirma.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaFirma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscafirma.Click
        Dim frmTemporal As New frmAbmUsuario
        frmTemporal.ShowDialog()
        Me.CargarFirma()
        Me.cmbFirma.Focus()
        Me.cmbFirma.Text = ""
        Me.lblid_Firma.Text = "0"
    End Sub

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtnumero.KeyPress, txtnumero_presupuesto.KeyPress, txtnumero_revision.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles dtpfecha_presupuesto.KeyDown, cmbcliente.KeyDown, dtpplazo_entrega.KeyDown, cmbtipo_moneda.KeyDown, cmbforma_pago.KeyDown, cmbmedio_entrega.KeyDown, cmbpreparo.KeyDown, cmbresponsable_calidad.KeyDown, cmbaprobo.KeyDown, cmbdireccion_general.KeyDown, dtpfecha_emision.KeyDown, dtpfecha_revision.KeyDown, cmbfirma.KeyDown
        If CDbl(e.KeyValue.ToString) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtimporte_total.KeyPress
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

        odt = oCuerpo_Presupuesto.GetAllMovimiento(CInt(Me.lblid_Presupuesto.Text))
        Me.dgv1.DataSource = odt
        Me.dgv1.Columns(0).Visible = False
    End Sub

    Private Sub dgv1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv1.CurrentCellChanged
        Try
            Me.lblid_pk.Text = CStr(Me.dgv1.Item(0, Me.dgv1.CurrentRow.Index).Value)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Botones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click, btnBorrar.Click, btnModificar.Click
        Dim btnTemp As New Button
        Dim frmDetalle As New frmDetalleCuerpo_Presupuesto
        btnTemp = CType(sender, Button)
        Try
            Select Case btnTemp.Name
                Case "btnAgregar"
                    BanderaCuerpo_Presupuesto = 1
                    Me.AddOwnedForm(frmDetalle)
                    oCuerpo_Presupuesto.Insertar()
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                Case "btnModificar"
                    If Not IsNumeric(Me.lblid_pk.Text) Then
                        Exit Sub
                    End If
                    BanderaCuerpo_Presupuesto = 2
                    Me.AddOwnedForm(frmDetalle)
                    oCuerpo_Presupuesto.Modificar(CInt(Me.lblid_pk.Text))
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

                    oCuerpo_Presupuesto.Borrar(CInt(Me.lblid_pk.Text))
                    RefrescarGrilla()
                    'Case "btnAyuda"
                    'Process.Start(PathAyuda + "frmAbmPresupuesto.avi")
                    'Case "btnSalir"
                    'Me.Close()
            End Select
            'Me.txtBuscar.Text = ""
            'Me.txtBuscar.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


End Class
