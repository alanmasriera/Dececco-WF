Public Class frmDetalleRemito

    Dim BanderaCierreForm As Boolean = False
    Private Sub frmDetalleRemito_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If BanderaCierreForm = False Then
            e.Cancel = True
        End If
    End Sub

    Private Sub frmDetalleRemito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttGeneral.SetToolTip(Me.btnBuscaFactura, "Buscar Nuevo Factura")
        'Me.ttGeneral.SetToolTip(Me.btnBuscaCliente, "Buscar Nuevo Cliente")
        'Me.ttGeneral.SetToolTip(Me.btnBuscaUsuario, "Buscar Nuevo Usuario")
        Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Remito")
        Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()

            Me.cmbfactura.Text = oFactura.GetOne(CInt(Me.lblid_factura.Text)).Rows(0).Item("Numero factura").ToString.Trim
            Me.cmbCondVta.Text = oCondicion_Venta.GetOne(CInt(Me.lblId_Condicion_vta.Text)).Rows(0).Item("Nombre condicion venta").ToString.Trim
            Me.cmbcliente.Text = oCliente.GetOne(CInt(Me.lblid_cliente.Text)).Rows(0).Item("nombre_Cliente").ToString.Trim
            'Me.cmbUsuario.Text = oUsuario.GetOne(CInt(Me.lblid_Usuario.Text)).Rows(0).Item("nombre_Usuario").ToString.Trim
        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try

        'agregado
        
            Me.lblid_Remito.Text = CType(Me.Owner, frmResumenCliente).lblid_remito.Text



        If BanderaRemito = 1 Then
            Me.LimpiarControles()
        End If
        Me.Text = "Remito"
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False

        oCuerpo_remito.Cargar()

        Me.cmbcliente.Text = CType(Me.Owner, frmResumenCliente).cmbCliente.Text
        Me.lblid_cliente.Text = CType(Me.Owner, frmResumenCliente).lblid_cliente.Text


        Me.RefrescarGrilla()
    End Sub

    Sub CargarCombos()
        Me.CargarFactura()
        'Me.CargarCliente()
        Me.CargarCondicionVta()
    End Sub

    Sub CargarFactura()
        Dim odt As New DataTable

        odt = oFactura.GetCmb

        With Me.cmbFactura
            .DataSource = odt
            .DisplayMember = "numero_Factura"
            .ValueMember = "id_Factura"
        End With
        If Me.cmbFactura.SelectedIndex >= 0 Then
            cmbFactura.SelectedIndex = 0
            Me.lblid_Factura.Text = cmbFactura.SelectedValue.ToString
        End If
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

    Sub LimpiarControles()
        Me.lblid_Remito.Text = "0"
        Me.lblid_factura.Text = "0"
        Me.cmbFactura.Text = ""
        Me.lblid_Remito.Text = "0"
        Me.dtpfecha_remito.Value = DateTime.Now
        Me.lblid_Remito.Text = "0"
        Me.txtnumero_remito.Text = ""
        Me.lblid_Remito.Text = "0"
        'Me.lblid_cliente.Text = "0"
        'Me.cmbCliente.Text = ""
        Me.lblid_Remito.Text = "0"
        'Me.txtcondicion_venta.Text = ""
        Me.lblid_Remito.Text = "0"
        Me.txtobservacion.Text = ""
        Me.lblid_Remito.Text = "0"
        Me.lblid_usuario.Text = "0"
        'Me.cmbUsuario.Text =  ""
        Me.lblid_Remito.Text = "0"
    End Sub

    Private Sub ObtenerDatos()
        Me.lblid_factura.Text = oRemito.id_factura.ToString
        Me.dtpfecha_remito.Value = oRemito.fecha_remito
        Me.txtnumero_remito.Text = oRemito.numero_remito.Trim
        'Me.lblid_cliente.Text = oRemito.id_cliente.ToString
        Me.lblId_Condicion_vta.Text = CStr(oRemito.id_condicion_venta)
        Me.txtobservacion.Text = oRemito.observacion.Trim
        'Me.lblid_usuario.Text = oRemito.id_usuario.ToString
    End Sub

    Private Sub AsignarDatos()
        oRemito.id_factura = CInt(Me.lblid_factura.Text)
        oRemito.fecha_remito = Me.dtpfecha_remito.Value.Date
        oRemito.numero_remito = Me.txtnumero_remito.Text
        oRemito.id_cliente = CInt(Me.lblid_cliente.Text)
        oRemito.id_condicion_venta = CInt(Me.lblId_Condicion_vta.Text)
        oRemito.observacion = Me.txtobservacion.Text
        'oRemito.id_usuario = CInt(Me.lblid_usuario.Text)
    End Sub

    Public Sub SoloLectura()
        Me.cmbFactura.Enabled = False
        Me.btnBuscaFactura.Enabled = False
        Me.dtpfecha_remito.Enabled = False
        Me.txtnumero_remito.Enabled = False
        Me.cmbCliente.Enabled = False
        'Me.btnBuscaCliente.Enabled = False
        Me.cmbCondVta.Enabled = False
        Me.txtobservacion.Enabled = False
        'Me.cmbUsuario.Enabled = False
        'Me.btnBuscaUsuario.Enabled = False
        Me.btnGuardar.Visible = False
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            If oRemito.Exist() Then
                If BanderaRemito = 1 Then
                    MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
                    Exit Sub
                ElseIf BanderaRemito = 2 Then
                    If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                        = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            Select Case BanderaRemito
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oRemito.Guardar()

                    Me.lblid_Remito.Text = oRemito.id_Remito.ToString
                    oCuerpo_remito.UpdateID(CInt(Me.lblid_Remito.Text), vgCodigoUsuario) ''

                    'agregado
                    CType(Me.Owner, frmResumenCliente).RefrescarGrillaRemito()

        'Me.CargarCombos()
        oRemito.Insertar()
        'Me.ObtenerDatos()
        Me.LimpiarControles()
        Me.cmbfactura.Focus()
        Me.RefrescarGrilla()

                    ' Me.lblid_Remito.Text = "0"
                    'Me.RefrescarGrilla()

                Case 2 'GUARDA Y SALE (MODIFICAR)
        oRemito.Guardar()
        BanderaCierreForm = True
        Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If Me.txtnumero_remito.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean

        If CDbl(Me.lblid_factura.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de factura")
            Exit Sub
        End If
        If CDbl(Me.lblid_cliente.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de cliente")
            Exit Sub
        End If
        'If CDbl(Me.lblid_usuario.Text) = 0 Then
        '    MessageBox.Show("Debe Seleccionar un Dato del Combo de usuario")
        '    Exit Sub
        'End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaRemito = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        BanderaCierreForm = True
        If Me.lblid_Remito.Text = "0" Then
            oCuerpo_remito.DeleteRemito(0, vgCodigoUsuario) ''
        End If

        Me.Close()
    End Sub

    Private Sub cmbFactura_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbfactura.SelectedIndexChanged
        If Me.cmbFactura.SelectedIndex >= 0 Then
            Me.lblid_factura.Text = cmbFactura.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscafactura.Click
        Dim frmTemporal As New FrmAbmFactura
        frmTemporal.ShowDialog()
        Me.CargarFactura()
        Me.cmbFactura.Focus()
        Me.cmbFactura.Text = ""
        Me.lblid_Factura.Text = "0"
    End Sub

    Private Sub cmbCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcliente.SelectedIndexChanged
        If Me.cmbCliente.SelectedIndex >= 0 Then
            Me.lblid_cliente.Text = cmbCliente.SelectedValue.ToString
        End If
    End Sub
    Private Sub cmbCondVta_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbCondVta.SelectedIndexChanged
        If Me.cmbCondVta.SelectedIndex >= 0 Then
            Me.lblId_Condicion_vta.Text = cmbCondVta.SelectedValue.ToString
        End If
    End Sub

    Sub CargarCondicionVta()
        Dim odt As New DataTable

        odt = oCondicion_Venta.GetCmb
        With Me.cmbCondVta
            .DataSource = odt
            .DisplayMember = "nombre_condicion_venta"
            .ValueMember = "id_condicion_venta"
        End With
        If Me.cmbCondVta.SelectedIndex >= 0 Then
            cmbCondVta.SelectedIndex = 0
            Me.lblId_Condicion_vta.Text = cmbCondVta.SelectedValue.ToString
        End If
    End Sub

    'Private Sub btnBuscaCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim frmTemporal As New frmAbmCliente
    '    frmTemporal.ShowDialog()
    '    Me.CargarCliente()
    '    Me.cmbcliente.Focus()
    '    Me.cmbcliente.Text = ""
    '    Me.lblid_cliente.Text = "0"
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

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtnumero_remito.KeyPress, txtobservacion.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles cmbfactura.KeyDown, dtpfecha_remito.KeyDown, cmbcliente.KeyDown, cmbcliente.KeyDown  ', cmbUsuario.KeyDown
        If CDbl(e.KeyValue.ToString) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    'Handles 
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

        odt = oCuerpo_Remito.GetAllMovimiento(CInt(Me.lblid_Remito.Text))
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
        Dim frmDetalle As New frmDetalleCuerpo_Remito
        btnTemp = CType(sender, Button)
        Try
            Select Case btnTemp.Name
                Case "btnAgregar"
                    BanderaCuerpo_Remito = 1
                    Me.AddOwnedForm(frmDetalle)
                    oCuerpo_Remito.Insertar()
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                Case "btnModificar"
                    If Not IsNumeric(Me.lblid_pk.Text) Then
                        Exit Sub
                    End If
                    BanderaCuerpo_Remito = 2
                    Me.AddOwnedForm(frmDetalle)
                    oCuerpo_Remito.Modificar(CInt(Me.lblid_pk.Text))
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

                    oCuerpo_Remito.Borrar(CInt(Me.lblid_pk.Text))
                    RefrescarGrilla()
                    'Case "btnAyuda"
                    'Process.Start(PathAyuda + "frmAbmRemito.avi")
                    'Case "btnSalir"
                    'Me.Close()
            End Select
            'Me.txtBuscar.Text = ""
            'Me.txtBuscar.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

 
    Private Sub btnBusca_condicion_venta_Click(sender As System.Object, e As System.EventArgs) Handles btnBusca_condicion_venta.Click
        Dim frm1 As New frmAbmCondicion_venta
        frm1.ShowDialog()
    End Sub
End Class
