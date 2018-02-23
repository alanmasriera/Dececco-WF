Public Class frmDetalleCuerpo_orden_compra

    Private Sub frmDetalleCuerpo_orden_compra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttGeneral.SetToolTip(Me.btnBuscaItem, "Buscar Nuevo Item")
        'Me.ttGeneral.SetToolTip(Me.btnBuscaUsuario, "Buscar Nuevo Usuario")
        Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Cuerpo_orden_compra")
        Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()

            Me.cmbItem.Text = oItem.GetOne(CInt(Me.lblid_Item.Text)).Rows(0).Item("nombre_Item").ToString.Trim
            'Me.cmbUsuario.Text = oUsuario.GetOne(CInt(Me.lblid_Usuario.Text)).Rows(0).Item("nombre_Usuario").ToString.Trim
        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try

        Me.lblid_orden_compra.Text = CType(Me.Owner, frmDetalleorden_compra).lblid_orden_compra.Text

        If BanderaCuerpo_orden_compra = 1 Then
            Me.LimpiarControles()
        End If
        Me.Text = "Cuerpo_orden_compra"
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False
    End Sub

    Sub CargarCombos()
        Me.CargarItem()
        'Me.CargarUsuario
    End Sub

    Sub CargarItem()
        Dim odt As New DataTable

        odt = oItem.GetCmb
        With Me.cmbItem
            .DataSource = odt
            .DisplayMember = "nombre_Item"
            .ValueMember = "id_Item"
        End With
        If Me.cmbItem.SelectedIndex >= 0 Then
            cmbItem.SelectedIndex = 0
            Me.lblid_Item.Text = cmbItem.SelectedValue.ToString
        End If
    End Sub

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
        'Me.lblid_orden_compra.Text = "0"
        'Me.cmbID_Orden_compra.Text =  ""
        Me.lblid_item.Text = "0"
        Me.cmbItem.Text = ""
        Me.txtcantidad.Text = ""
        Me.txtprecio_unitario.Text = ""
        Me.lblid_usuario.Text = "0"
        'Me.cmbUsuario.Text =  ""
    End Sub

    Private Sub ObtenerDatos()
        'Me.lblid_orden_compra.Text = oCuerpo_orden_compra.id_orden_compra.ToString
        Me.lblid_item.Text = oCuerpo_orden_compra.id_item.ToString
        Me.txtcantidad.Text = oCuerpo_orden_compra.cantidad.ToString.Trim
        Me.txtprecio_unitario.Text = oCuerpo_orden_compra.precio_unitario.ToString.Trim
        'Me.lblid_usuario.Text = oCuerpo_orden_compra.id_usuario.ToString
    End Sub

    Private Sub AsignarDatos()
        oCuerpo_orden_compra.id_orden_compra = CInt(Me.lblid_orden_compra.Text)
        oCuerpo_orden_compra.id_item = CInt(Me.lblid_item.Text)
        oCuerpo_orden_compra.cantidad = CDec(Me.txtcantidad.Text)
        oCuerpo_orden_compra.precio_unitario = CDec(Me.txtprecio_unitario.Text)
        oCuerpo_orden_compra.id_usuario = vgCodigoUsuario ''
    End Sub

    Public Sub SoloLectura()
        'Me.cmbOrden_compra.Enabled = False
        'Me.btnBuscaOrden_compra.Enabled = False
        Me.cmbItem.Enabled = False
        Me.btnBuscaItem.Enabled = False
        Me.txtcantidad.Enabled = False
        Me.txtprecio_unitario.Enabled = False
        'Me.cmbUsuario.Enabled = False
        'Me.btnBuscaUsuario.Enabled = False
        Me.btnGuardar.Visible = False
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            If oCuerpo_orden_compra.Exist() Then
                If BanderaCuerpo_orden_compra = 1 Then
                    MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
                    Exit Sub
                ElseIf BanderaCuerpo_orden_compra = 2 Then
                    If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                        = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            Select Case BanderaCuerpo_orden_compra
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oCuerpo_orden_compra.Guardar()
                    CType(Me.Owner, frmDetalleorden_compra).RefrescarGrilla()
                    Me.CargarCombos()
                    oCuerpo_orden_compra.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    'Me.cmbOrden_compra.Focus
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oCuerpo_orden_compra.Guardar()
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If Me.txtcantidad.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean

        'If CDbl(Me.lblid_orden_compra.Text) = 0 Then
        'MessageBox.Show("Debe Seleccionar un Dato del Combo de orden_compra")
        'Exit Sub
        'End If
        If CDbl(Me.lblid_item.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de item")
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
            If BanderaCuerpo_orden_compra = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cmbItem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbitem.SelectedIndexChanged
        If Me.cmbItem.SelectedIndex >= 0 Then
            Me.lblid_item.Text = cmbItem.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaitem.Click
        Dim frmTemporal As New FrmAbmItem
        frmTemporal.ShowDialog()
        Me.CargarItem()
        Me.cmbItem.Focus()
        Me.cmbItem.Text = ""
        Me.lblid_Item.Text = "0"
    End Sub

    'Private Sub cmbUsuario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUsuario.SelectedIndexChanged
    '    If Me.cmbUsuario.SelectedIndex >= 0 Then
    '        Me.lblid_usuario.Text = cmbUsuario.SelectedValue.ToString
    '    End If
    'End Sub

    'Private Sub btnBuscaUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaUsuario.Click
    '    Dim frmTemporal As New FrmAbmUsuario
    '    frmTemporal.ShowDialog()
    '     'Me.CargarUsuario()
    '     'Me.cmbUsuario.Focus()
    '     'Me.cmbUsuario.Text = ""
    '    Me.lblid_Usuario.Text = "0"
    'End Sub

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    'Handles 
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles cmbitem.KeyDown ', cmbUsuario.KeyDown
        If CDbl(e.KeyValue.ToString) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtcantidad.KeyPress, txtprecio_unitario.KeyPress
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
