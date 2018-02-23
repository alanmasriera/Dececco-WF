Public Class Frmchequerecibido

    Private Sub Frmcheqrecibido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolTipguarda.SetToolTip(btnguardar, "Guardar Datos ")
        ToolTipsalir.SetToolTip(btnsalir, "Volver a la Pantalla Anterior")
        ToolTipcliente.SetToolTip(btnbuscacliente, "Localiza o Agrega un nuevo Cliente")
        ToolTipbco.SetToolTip(Btnbcabco, "Localiza o Agrega un nuevo Banco")
        ToolTiplocalidad.SetToolTip(btnBuscaLocalidad, "Localiza o Agrega una nueva Localidad")
        Try
            ObtenerDatos()

            Me.Cmbcliente.Text = oCliente.GetOne(CInt(Me.lblid_Cliente.Text)).Rows(0).Item("nombre Cliente").ToString.Trim
            Me.Cmbbancocheque.Text = oBanco.GetOne(CInt(Me.lblid_BancoCheque.Text)).Rows(0).Item("nombre_banco").ToString.Trim
            Me.Cmbprovincia.Text = oProvincia.GetOne(CInt(Me.lblid_Provincia.Text)).Rows(0).Item("nombre_Provincia").ToString.Trim
            Me.cmblocalidad.Text = oLocalidad.GetOne(CInt(Me.lblid_Localidad.Text)).Rows(0).Item("nombre_Localidad").ToString.Trim
        Catch ex As Exception
            ' MessageBox.Show("") 'ex.Message)
        End Try

        If BanderaCheque = 1 Then
            Me.LimpiarControles()
        End If
        Me.CancelButton = Me.btnSalir
        Me.lblid_cuenta.Text = CType(Me.Owner, Frmmovbancos).lblidCuenta.Text
        Me.CalcularLimite()

        ''control de acceso y de permisos
        'Dim odtUser As New DataTable
        'odtUser = oUsuario.GetPermiso(vgNombreUsuario, Me.Name)
        'If odtUser.Rows.Count = 0 OrElse CDbl(odtUser.Rows(0).Item("habilitado")) = 0 Then
        '    Me.btnGuardar.Enabled = False
        'End If

        'colina
        Dim odt As New DataTable
        odt = oCliente_maestro.GetOne(1)
        If odt.Rows(0).Item("nombre_permiso").ToString = "colina" Then
            Me.etiquetaiva.Visible = False
            Me.txtiva.Visible = False
        End If
    End Sub

    Sub CalcularLimite()
        Try
            Me.txtLimite.Text = FormatCurrency(oLimite.GetLimit(CInt(Me.lblid_cuenta.Text)).Rows(0).Item("limite"))
        Catch ex As Exception
            Me.txtLimite.Text = CStr(0)
        End Try
        Me.ProgressBar1.Minimum = 0
        Me.ProgressBar1.Maximum = CInt(Me.txtLimite.Text)

        Try
            Me.txtEmitido.Text = FormatCurrency(oChequeRecibido.GetSpend(CInt(Me.lblid_cuenta.Text)).Rows(0).Item("total"))
        Catch ex As Exception
            Me.txtEmitido.Text = CStr(0)
        End Try
        If CDec(Me.txtLimite.Text) < CDec(Me.txtEmitido.Text) Then
            Me.ProgressBar1.Value = CInt(Me.txtLimite.Text)
            Me.txtSaldo.ForeColor = Color.Red
        Else
            If CDbl(Me.txtLimite.Text) = 0 Then
                Me.ProgressBar1.Maximum = CInt(Me.txtEmitido.Text)
            End If
            Me.ProgressBar1.Value = CInt(Me.txtEmitido.Text)
            Me.txtSaldo.ForeColor = Color.Blue
        End If

        Me.txtSaldo.Text = FormatCurrency(CDec(Me.txtLimite.Text) - CDec(Me.txtEmitido.Text))
    End Sub


    Sub CargarProvincia()
        Dim odt As New DataTable

        odt = oProvincia.GetCmb
        With Me.Cmbprovincia
            .DataSource = odt
            .DisplayMember = "nombre_Provincia"
            .ValueMember = "id_Provincia"
        End With
        If Me.Cmbprovincia.SelectedIndex >= 0 Then
            Cmbprovincia.SelectedIndex = 0
            Me.lblid_Provincia.Text = Cmbprovincia.SelectedValue.ToString
        End If
    End Sub

    Sub CargarLocalidad()
        Dim odt As New DataTable

        odt = oLocalidad.GetCmb_2(CInt(Me.lblid_Provincia.Text))
        With Me.cmblocalidad
            .DataSource = odt
            .DisplayMember = "nombre_Localidad"
            .ValueMember = "id_Localidad"
        End With
        If Me.cmblocalidad.SelectedIndex >= 0 Then
            cmblocalidad.SelectedIndex = 0
            Me.lblid_Localidad.Text = cmblocalidad.SelectedValue.ToString
        End If
    End Sub


    Sub CargarCliente()
        Dim odt As New DataTable

        odt = oCliente.GetCmb
        With Me.Cmbcliente
            .DataSource = odt
            .DisplayMember = "nombre_cliente"
            .ValueMember = "id_cliente"
        End With
        If Me.Cmbcliente.SelectedIndex >= 0 Then
            Cmbcliente.SelectedIndex = 0
            Me.lblid_Cliente.Text = Cmbcliente.SelectedValue.ToString
        End If
    End Sub

    Sub CargarBancoCheque()
        Dim odt As New DataTable

        odt = oBanco.GetCmb
        With Me.Cmbbancocheque
            .DataSource = odt
            .DisplayMember = "nombre_banco"
            .ValueMember = "id_banco"
        End With
        If Me.Cmbbancocheque.SelectedIndex >= 0 Then
            Cmbbancocheque.SelectedIndex = 0
            Me.lblid_BancoCheque.Text = Cmbbancocheque.SelectedValue.ToString
        End If
    End Sub



    Sub LimpiarControles()
        Me.fechaacredita.Value = CType(Me.Owner, Frmmovbancos).dpBanco.Value
        Me.fecharecibido.Value = CType(Me.Owner, Frmmovbancos).dpBanco.Value
        Me.Cmbcliente.Text = ""
        Me.Cmbbancocheque.Text = ""
        Me.Cmbprovincia.Text = ""
        Me.cmblocalidad.Text = ""
        Me.Txtnrocheque.Text = ""
        Me.txtImporte.Text = ""
        Me.txtDetalle.Text = ""
        Me.lblid_Cliente.Text = "0"
        Me.lblid_BancoCheque.Text = "0"
        Me.lblid_Provincia.Text = "0"
        Me.lblid_Localidad.Text = "0"
        Me.chkVendido.Checked = False
        Me.dtpFechaVenta.Value = DateTime.Now
        Me.txtiva.Text = "0"
        Me.chkanulado.Checked = False
        Me.chkcontrol.Checked = False
    End Sub

    'CARGA EL FORMULARIO CON LOS DATOS DEL EMPLEADO
    Private Sub ObtenerDatos()
        Me.lblid_Cliente.Text = CStr(oChequeRecibido.id_cliente)
        Me.lblid_BancoCheque.Text = CStr(oChequeRecibido.banco_cheque)
        Me.lblid_Provincia.Text = CStr(oChequeRecibido.id_provincia)
        Me.lblid_Localidad.Text = CStr(oChequeRecibido.id_localidad)
        Me.Txtnrocheque.Text = oChequeRecibido.numero_cheque
        Me.txtDetalle.Text = oChequeRecibido.detalle
        Me.fecharecibido.Value = oChequeRecibido.fecha_recibido
        Me.fechaacredita.Value = oChequeRecibido.fecha_acreditacion
        Me.txtImporte.Text = CStr(oChequeRecibido.importe)
        Me.chkVendido.Checked = oChequeRecibido.vendido
        Me.dtpFechaVenta.Value = oChequeRecibido.fecha_venta
        Me.txtiva.Text = CStr(oChequeRecibido.iva)
        Me.chkanulado.Checked = oChequeRecibido.anulado
        Me.chkcontrol.Checked = oChequeRecibido.control
    End Sub

    'ASIGNA LOS VALORES DEL FORMULARIO AL EMPLEADO
    Private Sub AsignarDatos()
        oChequeRecibido.id_cliente = CInt(Me.lblid_Cliente.Text)
        oChequeRecibido.banco_cheque = CInt(Me.lblid_BancoCheque.Text)
        oChequeRecibido.id_provincia = CInt(Me.lblid_Provincia.Text)
        oChequeRecibido.id_localidad = CInt(Me.lblid_Localidad.Text)
        oChequeRecibido.numero_cheque = Me.Txtnrocheque.Text
        oChequeRecibido.Detalle = Me.txtDetalle.Text.Trim
        oChequeRecibido.fecha_recibido = Me.fecharecibido.Value.Date
        oChequeRecibido.fecha_acreditacion = Me.fechaacredita.Value.Date
        oChequeRecibido.importe = CDec(Me.txtImporte.Text)
        oChequeRecibido.banco_deposito = CInt(CType(Me.Owner, Frmmovbancos).lblidBanco.Text)
        oChequeRecibido.id_cuenta = CInt(CType(Me.Owner, Frmmovbancos).lblidCuenta.Text)
        oChequeRecibido.id_empresa = CInt(CType(Me.Owner, Frmmovbancos).lblidEmpresa.Text)
        oChequeRecibido.Periodo = Me.fechaacredita.Value.Date
        oChequeRecibido.vendido = Me.chkVendido.Checked
        oChequeRecibido.iva = CDec(Me.txtiva.Text)
        oChequeRecibido.anulado = Me.chkanulado.Checked
        oChequeRecibido.control = Me.chkcontrol.Checked

        If Me.chkVendido.Checked = True Then
            oChequeRecibido.fecha_venta = Me.dtpFechaVenta.Value.Date
        Else
            oChequeRecibido.fecha_venta = Me.fechaacredita.Value.Date
        End If

    End Sub

    'BORRA TODOS LOS COMBOS
    Public Sub BorrarCombos()
        '     Me.Cmbcliente.Items.Clear()
        '     Me.Cmbbancocheque.Items.Clear()
        '     Me.cmbbcodeposito.Items.Clear()
        '     Me.Cmbcuenta.Items.Clear()
        '     Me.Cmbprovincia.Items.Clear()
        '     Me.cmblocalidad.Items.Clear()
    End Sub

    'ENABLE=FALSE TODOS LOS CONTROLES PARA CONSULTA
    Public Sub SoloLectura()
        Me.Cmbcliente.Enabled = False
        Me.Cmbbancocheque.Enabled = False
        Me.Txtnrocheque.Enabled = False
        Me.txtDetalle.Enabled = False
        Me.fechaacredita.Enabled = False
        Me.fecharecibido.Enabled = False
        Me.txtImporte.Enabled = False
        Me.Cmbprovincia.Enabled = False
        Me.cmblocalidad.Enabled = False
        Me.dtpFechaVenta.Enabled = False
        Me.chkVendido.Enabled = False
        Me.btnGuardar.Visible = False
        Me.txtiva.Enabled = False
        Me.chkanulado.Enabled = False
        Me.chkcontrol.Enabled = False
        Me.etiquetaiva.Visible = False
        Me.txtiva.Visible = False

    End Sub

    'GUARDA LOS CAMBIOS
    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            If oChequeRecibido.Exist() Then
                If BanderaCheque = 1 Then
                    MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
                    Exit Sub
                ElseIf BanderaCheque = 1 Then
                    If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                        = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            Select Case BanderaCheque
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oChequeRecibido.Guardar()
                    CType(Me.Owner, Frmmovbancos).RefrescarGrilla()
                    '   Me.BorrarCombos()
                    CargarProvincia()
                    CargarCliente()
                    CargarBancoCheque()
                    oChequeRecibido.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.Cmbcliente.Focus()
                    Me.CalcularLimite()
                Case 11 'GUARDA Y SALE (MODIFICAR)
                    oChequeRecibido.Guardar()
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'CONTROLA LOS CONTROLES VACIOS Y DEVUELVE UN BOOLEAN
    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If Me.Txtnrocheque.Text = "" Or Me.txtDetalle.Text = "" Or Me.txtImporte.Text = "" Or Me.txtiva.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub Cmbprovincia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cmbprovincia.KeyDown
        If e.KeyValue = 13 Then
            Me.cmblocalidad.Focus()
        End If
    End Sub

    Private Sub cmbProvincia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbprovincia.SelectedIndexChanged
        If Me.cmbProvincia.SelectedIndex >= 0 Then
            Me.lblid_Provincia.Text = Cmbprovincia.SelectedValue.ToString
        End If
        If Not IsNumeric(Me.lblid_Provincia.Text) Then
            Exit Sub
        End If
        Me.CargarLocalidad()
    End Sub

    Private Sub Cmbbancocheque_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cmbbancocheque.KeyDown
        If e.KeyValue = 13 Then
            Me.Txtnrocheque.Focus()
        End If
    End Sub

    Private Sub Cmbbancocheque_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmbbancocheque.SelectedIndexChanged
        If Me.Cmbbancocheque.SelectedIndex >= 0 Then
            Me.lblid_BancoCheque.Text = Cmbbancocheque.SelectedValue.ToString
        End If
    End Sub

    Private Sub Cmbcliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cmbcliente.KeyDown
        If e.KeyValue = 13 Then
            Me.Cmbbancocheque.Focus()
        End If
    End Sub

    Private Sub Cmbcliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbcliente.SelectedIndexChanged
        If Me.Cmbcliente.SelectedIndex >= 0 Then
            Me.lblid_Cliente.Text = Cmbcliente.SelectedValue.ToString
        End If
    End Sub

    Private Sub cmblocalidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmblocalidad.KeyDown
        If e.KeyValue = 13 Then
            Me.chkVendido.Focus()
        End If
    End Sub

    Private Sub cmbLocalidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmblocalidad.SelectedIndexChanged
        If Me.cmbLocalidad.SelectedIndex >= 0 Then
            Me.lblid_Localidad.Text = cmblocalidad.SelectedValue.ToString
        End If
    End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtImporte.KeyPress, txtiva.KeyPress
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

    Function controlarExistenciaCheque() As Boolean

        Dim odt As New DataTable

        odt = oChequeRecibido.GetCheque(Me.Txtnrocheque.Text.Trim, CInt(Me.lblid_cuenta.Text))

        If odt.Rows.Count > 0 Then
            Return True
        End If
        Return False

    End Function


    Private Sub Txtnrocheque_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtnrocheque.KeyPress
        If e.KeyChar.ToString = vbCr Then
            'agregadod
            If controlarExistenciaCheque() = True Then
                MessageBox.Show("El número de cheque ingresado existe", "Error", MessageBoxButtons.OK)
                Me.Txtnrocheque.Focus()
                Exit Sub
            End If
            Me.fecharecibido.Focus()
        End If

        If (e.KeyChar.ToString >= "0" And e.KeyChar.ToString <= "9") Or e.KeyChar.ToString = "/" Or e.KeyChar.ToString = "-" Or e.KeyChar = vbBack Then
            '  e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub fecharecibido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fecharecibido.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.fechaacredita.Focus()
        End If
    End Sub

    Private Sub fechaacredita_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fechaacredita.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.txtImporte.Focus()
        End If
    End Sub

    Private Sub btnBuscaCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaCliente.Click
        Dim frmTemp As New frmAbmCliente
        frmTemp.ShowDialog()
        Me.CargarCliente()
        Me.Cmbcliente.Focus()
        Me.Cmbcliente.Text = ""
        Me.lblid_Cliente.Text = "0"
    End Sub

    Private Sub btnBcaBco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBcaBco.Click
        Dim frmTemp As New frmAbmBanco
        frmTemp.ShowDialog()
        Me.CargarBancoCheque()
        Me.Cmbbancocheque.Focus()
        Me.Cmbbancocheque.Text = ""
        Me.lblid_BancoCheque.Text = "0"
    End Sub

    Private Sub btnBuscaLocalidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaLocalidad.Click
        Dim frmTemporal As New FrmAbmLocalidad
        frmTemporal.ShowDialog()
        Me.CargarLocalidad()
        Me.cmbLocalidad.Focus()
        Me.cmbLocalidad.Text = ""
        Me.lblid_Localidad.Text = "0"
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean

        If controlarExistenciaCheque() = True Then
            MessageBox.Show("El número de cheque ingresado existe", "Error", MessageBoxButtons.OK)
            Me.Txtnrocheque.Focus()
            Exit Sub
        End If
        

        'controla la fecharecibido con el período indicado en Movimiento Bancos.
        If Not fecharecibido.Value.Month = CType(Me.Owner, Frmmovbancos).dpBanco.Value.Month And _
                fecharecibido.Value.Year = CType(Me.Owner, Frmmovbancos).dpBanco.Value.Year Then
            If MessageBox.Show("El Mes/Año de la fecha ingresada no es igual al período. ¿Desea continuar con la fecha ingresada?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        End If


        If CDbl(Me.lblid_Cliente.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Cliente del Combo")
            Exit Sub
        ElseIf CDbl(Me.lblid_BancoCheque.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Banco del Combo")
            Exit Sub
        ElseIf CDbl(Me.lblid_Provincia.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar una Provincia del Combo")
            Exit Sub
        ElseIf CDbl(Me.lblid_Localidad.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar una Localidad del Combo")
            Exit Sub
        End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios (*) ")
            Exit Sub
        Else
            If BanderaCheque = 1 Then
                Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub dtpFechaVenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFechaVenta.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.btnGuardar.Focus()
        End If
    End Sub

    Private Sub btnBuscaLimite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaLimite.Click
        Dim frmTemp As New frmAbmLimite

        Try
            frmTemp.ShowDialog()
            Me.txtLimite.Text = CStr(oLimite.GetLimit(CInt(Me.lblid_cuenta.Text)).Rows(0).Item("limite"))
            Me.CalcularLimite()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtDetalle.KeyPress, chkVendido.KeyPress, chkcontrol.KeyPress, chkanulado.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

End Class