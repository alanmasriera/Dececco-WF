Public Class frmDetalleOrden_compra

    Dim BanderaCierreForm As Boolean = False
    Private Sub frmDetalleOrden_compra_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs)
        If BanderaCierreForm = False Then
            e.Cancel = True
        End If
    End Sub

    Private Sub frmDetalleOrden_compra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.ttGeneral.SetToolTip(Me.btnBuscacliente, "Buscar Nuevo Cliente")
        'Me.ttGeneral.SetToolTip(Me.btnBuscausuario, "Buscar Nuevo Usuario")
        Me.ttGeneral.SetToolTip(Me.btnBuscapresupuesto, "Buscar Nuevo Presupuesto")
        Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Orden_compra")
        Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()

            Me.cmbcliente.Text = oCliente.GetOne(CInt(Me.lblid_cliente.Text)).Rows(0).Item("nombre_Cliente").ToString.Trim
            Me.cmbusuario.Text = oUsuario.GetOne(CInt(Me.lblid_usuario.Text)).Rows(0).Item("nombre_Usuario").ToString.Trim
            Me.cmbpresupuesto.Text = oPresupuesto.GetOne(CInt(Me.lblid_presupuesto.Text)).Rows(0).Item("numero presupuesto").ToString.Trim
        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try

        Me.lblid_Orden_compra.Text = CType(Me.Owner, frmResumenCliente).lblid_orden_compra.Text

        If BanderaOrden_compra = 1 Then
            Me.LimpiarControles()
        End If
        Me.Text = "Orden_compra"
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False

        Me.cmbcliente.Text = CType(Me.Owner, frmResumenCliente).cmbCliente.Text
        Me.lblid_cliente.Text = CType(Me.Owner, frmResumenCliente).lblid_cliente.Text

        parametro_id_cliente = CInt(Me.lblid_cliente.Text)
        parametro_cliente = Me.cmbcliente.Text

        oCuerpo_orden_compra.Cargar()

        Me.RefrescarGrilla()
    End Sub

    Sub CargarCombos()
        'Me.CargarCliente()
        'Me.CargarUsuario()
        Me.CargarPresupuesto()
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

    'Sub CargarUsuario()
    '    Dim odt As New DataTable

    '    odt = oUsuario.GetCmb
    '    With Me.cmbUsuario
    '        .DataSource = odt
    '        .DisplayMember = "nombre_Usuario"
    '        .ValueMember = "id_Usuario"
    '    End With
    '    If Me.cmbUsuario.SelectedIndex >= 0 Then
    '        cmbUsuario.SelectedIndex = 0
    '        Me.lblid_Usuario.Text = cmbUsuario.SelectedValue.ToString
    '    End If
    'End Sub

    Sub CargarPresupuesto()
        Dim odt As New DataTable

        odt = oPresupuesto.GetCmb
        With Me.cmbPresupuesto
            .DataSource = odt
            .DisplayMember = "numero_presupuesto"
            .ValueMember = "id_Presupuesto"
        End With
        If Me.cmbPresupuesto.SelectedIndex >= 0 Then
            cmbPresupuesto.SelectedIndex = 0
            Me.lblid_Presupuesto.Text = cmbPresupuesto.SelectedValue.ToString
        End If
    End Sub

    Sub LimpiarControles()
        Me.dtpfecha_orden_compra.Value = DateTime.Now
        'Me.lblid_cliente.Text = "0"
        'Me.cmbCliente.Text = ""
        Me.txtobservacion.Text = ""
        Me.txtacepto_orden_compra.Text = ""
        Me.txttotal_orden_compra.Text = ""
        'Me.lblid_usuario.Text = "0"
        'Me.cmbUsuario.Text = ""
        Me.lblid_presupuesto.Text = "0"
        Me.cmbPresupuesto.Text = ""
    End Sub

    Private Sub ObtenerDatos()
        Me.dtpfecha_orden_compra.Value = oOrden_compra.fecha_orden_compra
        'Me.lblid_cliente.Text = oOrden_compra.id_cliente.ToString
        Me.txtobservacion.Text = oOrden_compra.observacion.Trim
        Me.txtacepto_orden_compra.Text = oOrden_compra.acepto_orden_compra.Trim
        Me.txttotal_orden_compra.Text = oOrden_compra.total_orden_compra.ToString.Trim
        'Me.lblid_usuario.Text = oOrden_compra.id_usuario.ToString
        Me.lblid_presupuesto.Text = oOrden_compra.id_presupuesto.ToString
    End Sub

    Private Sub AsignarDatos()
        oOrden_compra.fecha_orden_compra = Me.dtpfecha_orden_compra.Value.Date
        oOrden_compra.id_cliente = CInt(Me.lblid_cliente.Text)
        oOrden_compra.observacion = Me.txtobservacion.Text
        oOrden_compra.acepto_orden_compra = Me.txtacepto_orden_compra.Text
        oOrden_compra.total_orden_compra = CDec(Me.txttotal_orden_compra.Text)
        oOrden_compra.id_usuario = vgCodigoUsuario
        oOrden_compra.id_presupuesto = CInt(Me.lblid_presupuesto.Text)
    End Sub

    Public Sub SoloLectura()
        Me.dtpfecha_orden_compra.Enabled = False
        Me.cmbCliente.Enabled = False
        'Me.btnBuscaCliente.Enabled = False
        Me.txtobservacion.Enabled = False
        Me.txtacepto_orden_compra.Enabled = False
        Me.txttotal_orden_compra.Enabled = False
        Me.cmbUsuario.Enabled = False
        Me.btnBuscaUsuario.Enabled = False
        Me.cmbPresupuesto.Enabled = False
        Me.btnBuscaPresupuesto.Enabled = False
        Me.btnGuardar.Visible = False
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            If oOrden_compra.Exist() Then
                If BanderaOrden_compra = 1 Then
                    MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
                    Exit Sub
                ElseIf BanderaOrden_compra = 2 Then
                    If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                        = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            Select Case BanderaOrden_compra
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oOrden_compra.Guardar()

                    Me.lblid_Orden_compra.Text = oOrden_compra.id_Orden_compra.ToString
                    oCuerpo_orden_compra.UpdateID(CInt(Me.lblid_Orden_compra.Text), vgCodigoUsuario)

                    CType(Me.Owner, frmResumenCliente).RefrescarGrillaOrdenCompra()
                    'Me.CargarCombos()
                    oOrden_compra.Insertar()
                    'Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.dtpfecha_orden_compra.Focus()
                    Me.RefrescarGrilla()

                    Me.lblid_Orden_compra.Text = "0"
                    Me.RefrescarGrilla()

                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oOrden_compra.Guardar()
                    BanderaCierreForm = True
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If Me.txtobservacion.Text = "" Then
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
        'If CDbl(Me.lblid_usuario.Text) = 0 Then
        '    MessageBox.Show("Debe Seleccionar un Dato del Combo de usuario")
        '    Exit Sub
        'End If
        If CDbl(Me.lblid_presupuesto.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de presupuesto")
            Exit Sub
        End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaOrden_compra = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BanderaCierreForm = True
        If Me.lblid_Orden_compra.Text = "0" Then
            oCuerpo_orden_compra.Deleteorden_compra(0, vgCodigoUsuario)
        End If

        Me.Close()
    End Sub

    Private Sub cmbCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCliente.SelectedIndexChanged
        If Me.cmbCliente.SelectedIndex >= 0 Then
            Me.lblid_cliente.Text = cmbCliente.SelectedValue.ToString
        End If
    End Sub

    'Private Sub btnBuscaCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaCliente.Click
    '    Dim frmTemporal As New FrmAbmCliente
    '    frmTemporal.ShowDialog()
    '    'Me.CargarCliente()
    '    Me.cmbCliente.Focus()
    '    Me.cmbCliente.Text = ""
    '    Me.lblid_Cliente.Text = "0"
    'End Sub

    'Private Sub cmbUsuario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUsuario.SelectedIndexChanged
    '    If Me.cmbUsuario.SelectedIndex >= 0 Then
    '        Me.lblid_usuario.Text = cmbUsuario.SelectedValue.ToString
    '    End If
    'End Sub

    'Private Sub btnBuscaUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaUsuario.Click
    '    Dim frmTemporal As New FrmAbmUsuario
    '    frmTemporal.ShowDialog()
    '    Me.CargarUsuario()
    '    Me.cmbUsuario.Focus()
    '    Me.cmbUsuario.Text = ""
    '    Me.lblid_Usuario.Text = "0"
    'End Sub

    Private Sub cmbPresupuesto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPresupuesto.SelectedIndexChanged
        If Me.cmbPresupuesto.SelectedIndex >= 0 Then
            Me.lblid_presupuesto.Text = cmbPresupuesto.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaPresupuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaPresupuesto.Click
        Dim frmTemporal As New FrmAbmPresupuesto
        frmTemporal.ShowDialog()
        Me.CargarPresupuesto()
        Me.cmbPresupuesto.Focus()
        Me.cmbPresupuesto.Text = ""
        Me.lblid_Presupuesto.Text = "0"
    End Sub

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtobservacion.KeyPress, txtacepto_orden_compra.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles dtpfecha_orden_compra.KeyDown, cmbCliente.KeyDown, cmbUsuario.KeyDown, cmbPresupuesto.KeyDown
        If CDbl(e.KeyValue.ToString) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txttotal_orden_compra.KeyPress
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

        odt = oCuerpo_orden_compra.GetAllMovimiento(CInt(Me.lblid_Orden_compra.Text))
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
        Dim frmDetalle As New frmDetalleCuerpo_Orden_compra
        btnTemp = CType(sender, Button)
        Try
            Select Case btnTemp.Name
                Case "btnAgregar"
                    BanderaCuerpo_Orden_compra = 1
                    Me.AddOwnedForm(frmDetalle)
                    oCuerpo_Orden_compra.Insertar()
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                Case "btnModificar"
                    If Not IsNumeric(Me.lblid_pk.Text) Then
                        Exit Sub
                    End If
                    BanderaCuerpo_Orden_compra = 2
                    Me.AddOwnedForm(frmDetalle)
                    oCuerpo_Orden_compra.Modificar(CInt(Me.lblid_pk.Text))
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

                    oCuerpo_Orden_compra.Borrar(CInt(Me.lblid_pk.Text))
                    RefrescarGrilla()
                    'Case "btnAyuda"
                    'Process.Start(PathAyuda + "frmAbmOrden_compra.avi")
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
