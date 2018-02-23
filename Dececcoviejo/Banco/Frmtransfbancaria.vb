Public Class Frmtransfbancaria

    Private Sub Frmtransfbancaria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolTipguarda.SetToolTip(btnguardar, "Guardar Datos ")
        ToolTipsalir.SetToolTip(btnsalir, "Volver a la Pantalla Anterior")
        ToolTipbco.SetToolTip(Me.btnBuscaBanco, "Localiza o Agrega un nuevo Banco")
        Try
            ObtenerDatos()

            Me.cmbBanco.Text = oBanco.GetOne(CInt(Me.lblid_BancoCheque.Text)).Rows(0).Item("nombre_banco").ToString.Trim
            Me.Cmbcliente.Text = oCliente.GetOne(CInt(Me.lblid_Cliente.Text)).Rows(0).Item("nombre_Cliente").ToString.Trim
        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try
        If BanderaCheque = 3 Then
            Me.LimpiarControles()
        End If
        Me.dpTransferencia.Focus()

        ''control de acceso y de permisos
        'Dim odtUser As New DataTable
        'odtUser = oUsuario.GetPermiso(vgNombreUsuario, Me.Name)
        'If odtUser.Rows.Count = 0 OrElse CDbl(odtUser.Rows(0).Item("habilitado")) = 0 Then
        '    Me.btnGuardar.Enabled = False
        'End If
        Dim odt As New DataTable
        odt = oCliente_maestro.GetOne(1)
        'If odt.Rows(0).Item("nombre_permiso").ToString = "colina" Then
        'Else
        ''    Me.etiquetaiva.Visible = False
        Me.txtiva.Visible = True
        'End If
       
    End Sub

    Sub CargarBancoOrigen()
        Dim odt As New DataTable

        odt = oBanco.GetCmb
        With Me.cmbBanco
            .DataSource = odt
            .DisplayMember = "nombre_banco"
            .ValueMember = "id_banco"
        End With
        If Me.cmbBanco.SelectedIndex >= 0 Then
            cmbBanco.SelectedIndex = 0
            Me.lblid_BancoCheque.Text = cmbBanco.SelectedValue.ToString
        End If
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

    Sub LimpiarControles()
        Me.dpTransferencia.Value = CType(Me.Owner, Frmmovbancos).dpBanco.Value
        Me.cmbBanco.Text = ""
        Me.Txtboletatransf.Text = ""
        Me.Txtimporte.Text = ""
        Me.txtDetalle.Text = ""
        Me.lblid_BancoCheque.Text = "0"
        Me.lblid_Cliente.Text = "0"
        Me.Cmbcliente.Text = ""
        Me.txtiva.Text = "0"

       
    End Sub

    'CARGA EL FORMULARIO CON LOS DATOS DE LA TRANSFERENCIA
    Private Sub ObtenerDatos()
        Me.lblid_BancoCheque.Text = CStr(oTransferenciaBancaria.banco_origen)
        Me.Txtboletatransf.Text = oTransferenciaBancaria.comprobante
        Me.txtDetalle.Text = oTransferenciaBancaria.detalle
        Me.dpTransferencia.Value = oTransferenciaBancaria.Fecha
        Me.Txtimporte.Text = CStr(oTransferenciaBancaria.importe)
        Me.lblid_Cliente.Text = CStr(oTransferenciaBancaria.id_cliente)
    End Sub

    'ASIGNA LOS VALORES DEL FORMULARIO DE LA TRANSFERENCIA
    Private Sub AsignarDatos()
        oTransferenciaBancaria.banco_origen = CInt(Me.lblid_BancoCheque.Text)
        oTransferenciaBancaria.Comprobante = Me.Txtboletatransf.Text
        oTransferenciaBancaria.Detalle = Me.txtDetalle.Text.Trim
        oTransferenciaBancaria.Fecha = Me.dpTransferencia.Value.Date
        oTransferenciaBancaria.importe = CDec(Me.Txtimporte.Text)
        oTransferenciaBancaria.banco_destino = CInt(CType(Me.Owner, Frmmovbancos).lblidBanco.Text)
        oTransferenciaBancaria.id_cuenta = CInt(CType(Me.Owner, Frmmovbancos).lblidCuenta.Text)
        oTransferenciaBancaria.id_empresa = CInt(CType(Me.Owner, Frmmovbancos).lblidEmpresa.Text)
        oTransferenciaBancaria.periodo = Me.dpTransferencia.Value.Date
        oTransferenciaBancaria.id_cliente = CInt(Me.lblid_Cliente.Text)
    End Sub

    Public Sub SoloLectura()
        Me.cmbBanco.Enabled = False
        Me.Txtboletatransf.Enabled = False
        Me.txtDetalle.Enabled = False
        Me.dpTransferencia.Enabled = False
        Me.Txtimporte.Enabled = False
        Me.btnBuscaBanco.Enabled = False

        Me.btnGuardar.Visible = False
        Me.Cmbcliente.Enabled = False
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            Select Case BanderaCheque
                Case 3 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oTransferenciaBancaria.Guardar()
                    CType(Me.Owner, Frmmovbancos).RefrescarGrilla()
                    '   Me.BorrarCombos()
                    CargarBancoOrigen()
                    oTransferenciaBancaria.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.dpTransferencia.Focus()
                Case 33 'GUARDA Y SALE (MODIFICAR)
                    oTransferenciaBancaria.Guardar()
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'CONTROLA LOS CONTROLES VACIOS Y DEVUELVE UN BOOLEAN
    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If Me.Txtboletatransf.Text = "" Or Me.txtDetalle.Text = "" Or Me.Txtimporte.Text = "" Or Me.txtiva.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub cmbBanco_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbBanco.KeyDown
        If e.KeyValue = 13 Then
            Me.Txtimporte.Focus()
        End If
    End Sub

    Private Sub cmbBanco_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBanco.SelectedIndexChanged
        If Me.cmbBanco.SelectedIndex >= 0 Then
            Me.lblid_BancoCheque.Text = cmbBanco.SelectedValue.ToString
        End If
    End Sub

    Private Sub cmbCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbcliente.SelectedIndexChanged
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

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles Cmbcliente.KeyDown
        If CDbl(e.KeyValue.ToString) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles Txtimporte.KeyPress, txtiva.KeyPress
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

    Private Sub txtDetalle_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDetalle.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.btnguardar.Focus()
        End If
    End Sub

    Private Sub Txtboletatransf_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtboletatransf.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.cmbBanco.Focus()
        End If

        If (e.KeyChar.ToString >= "0" And e.KeyChar.ToString <= "9") Or e.KeyChar.ToString = "/" Or e.KeyChar.ToString = "-" Or e.KeyChar = vbBack Then
            '  e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub dpTransferencia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dpTransferencia.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.Txtboletatransf.Focus()
        End If
    End Sub

    Private Sub btnBcos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaBanco.Click
        Dim frmTemp As New frmAbmBanco
        frmTemp.ShowDialog()
        Me.CargarBancoOrigen()
        Me.cmbBanco.Focus()
        Me.cmbBanco.Text = ""
        Me.lblid_BancoCheque.Text = "0"
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean

        'controla la fecha transferencia con el período indicado en Movimiento Bancos.
        If Not dpTransferencia.Value.Month = CType(Me.Owner, Frmmovbancos).dpBanco.Value.Month And _
                dpTransferencia.Value.Year = CType(Me.Owner, Frmmovbancos).dpBanco.Value.Year Then
            If MessageBox.Show("El Mes/Año de la fecha ingresada no es igual al período. ¿Desea continuar con la fecha ingresada?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        End If


        If CDbl(Me.lblid_BancoCheque.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Banco del Combo")
            Exit Sub
        End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios (*) ")
            Exit Sub
        Else
            If BanderaCheque = 3 Then
                Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


End Class