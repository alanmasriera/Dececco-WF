Public Class frmDetalleRecibo_cliente_cheque_2

   Private Sub frmDetalleRecibo_cliente_cheque_2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.ttGeneral.SetToolTip(Me.btnBuscaPago_cliente, "Buscar Nuevo Pago_cliente")
        Me.ttGeneral.SetToolTip(Me.btnBuscacheque_recibo, "Buscar Nuevo Cheque_recibo")
       Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Recibo_cliente_cheque_2")
       Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
       Try
           ObtenerDatos()

            'Me.cmbPago_cliente.Text = oPago_cliente.GetOne(CInt(Me.lblid_Pago_cliente.Text)).Rows(0).Item("nombre Pago_cliente").ToString.Trim
            Me.cmbcheque_recibo.Text = oCheque_recibido.GetOne(CInt(Me.lblid_cheque_recibo.Text)).Rows(0).Item("nombre Cheque_recibo").ToString.Trim
       Catch ex As Exception
           '    MessageBox.Show(ex.Message)
       End Try

       If BanderaRecibo_cliente_cheque_2  = 1 Then
           Me.LimpiarControles()
       End If
       Me.Text = "Recibo_cliente_cheque_2" & vgNombreFormulario
       Me.CancelButton = Me.btnSalir
       Me.BackColor = Color.Gainsboro
       Me.StartPosition = FormStartPosition.CenterScreen
       Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.lblid_pago_cliente.Text = CType(Me.Owner, frmDetallePago_cliente).lblid_pago_cliente.Text
        Me.lblid_cliente.Text = CType(Me.Owner, frmDetallePago_cliente).lblid_cliente.Text
   End Sub

   Sub CargarCombos()
        'Me.CargarPago_cliente
       Me.CargarCheque_recibo
   End Sub

    'Sub CargarPago_cliente()
    '    Dim odt As New DataTable

    '    odt = oPago_cliente.GetCmb
    '    With Me.cmbPago_cliente
    '        .DataSource = odt
    '        .DisplayMember = "nombre_pago_cliente"
    '        .ValueMember = "id_pago_cliente"
    '    End With
    '    If Me.cmbPago_cliente.SelectedIndex >= 0 Then
    '        cmbPago_cliente.SelectedIndex = 0
    '        Me.lblid_Pago_cliente.Text = cmbPago_cliente.SelectedValue.ToString
    '    End If
    'End Sub

   Sub CargarCheque_recibo()
       Dim odt As New DataTable

        odt = oChequeRecibido.GetCmbCliente(CInt(Me.lblid_cliente.Text))
       With Me.cmbCheque_recibo
           .DataSource = odt
            .DisplayMember = "nombre_cheque_recibido"
            .ValueMember = "Id_cheque_recibido"
       End With
       If Me.cmbCheque_recibo.SelectedIndex >= 0 Then
           cmbCheque_recibo.SelectedIndex = 0
           Me.lblid_Cheque_recibo.Text = cmbCheque_recibo.SelectedValue.ToString
       End If
   End Sub

   Sub LimpiarControles()
        'Me.lblid_pago_cliente.Text = "0"
        'Me.cmbPago_cliente.Text =  ""
       Me.lblid_cheque_recibo.Text = "0"
       Me.cmbCheque_recibo.Text =  ""
       Me.chkcontrol.Checked = False
   End Sub

   Private Sub ObtenerDatos()
        'Me.lblid_pago_cliente.Text = oRecibo_cliente_cheque_2.id_pago_cliente.ToString
       Me.lblid_cheque_recibo.Text = oRecibo_cliente_cheque_2.id_cheque_recibo.ToString
       Me.chkcontrol.Checked = oRecibo_cliente_cheque_2.control
   End Sub

   Private Sub AsignarDatos()
       oRecibo_cliente_cheque_2.id_pago_cliente = CInt(Me.lblid_pago_cliente.Text)
       oRecibo_cliente_cheque_2.id_cheque_recibo = CInt(Me.lblid_cheque_recibo.Text)
       oRecibo_cliente_cheque_2.control = Me.chkcontrol.Checked
   End Sub

   Public Sub SoloLectura()
        'Me.cmbPago_cliente.Enabled = False
        'Me.btnBuscaPago_cliente.Enabled = False
       Me.cmbCheque_recibo.Enabled = False
       Me.btnBuscaCheque_recibo.Enabled = False
       Me.chkcontrol.Enabled = False
       Me.btnGuardar.Visible = False
   End Sub

   Private Sub Guardar()
       Try
           Me.AsignarDatos()
           If oRecibo_cliente_cheque_2.Exist() Then
               If BanderaRecibo_cliente_cheque_2 = 1 Then
                   MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
               Exit Sub
               ElseIf BanderaRecibo_cliente_cheque_2 = 2 Then
                   If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                       = Windows.Forms.DialogResult.No Then
                       Exit Sub
                   End If
               End If
           End If
           Select Case BanderaRecibo_cliente_cheque_2
               Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                   oRecibo_cliente_cheque_2.Guardar()
                    CType(Me.Owner, frmDetallePago_cliente).RefrescarGrilla_3()
                   Me.CargarCombos()
                   oRecibo_cliente_cheque_2.Insertar()
                   Me.ObtenerDatos()
                   Me.LimpiarControles()
                    'Me.cmbPago_cliente.Focus
               Case 2 'GUARDA Y SALE (MODIFICAR)
                   oRecibo_cliente_cheque_2.Guardar()
                   Me.Close()
           End Select
       Catch ex As Exception
           MessageBox.Show(ex.Message)
       End Try
   End Sub

   Private Function ChequearVacios() As Boolean
       Dim bandera As Boolean
        If Me.Name = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
   End Function

   Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
       Dim blnVacios As Boolean

        'If CDbl(Me.lblid_pago_cliente.Text) = 0 Then
        '    MessageBox.Show("Debe Seleccionar un Dato del Combo de pago_cliente")
        '    Exit Sub
        'End If
       If CDbl(Me.lblid_cheque_recibo.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de cheque_recibo")
           Exit Sub
       End If

       blnVacios = Me.ChequearVacios
       If blnVacios = False Then
           MessageBox.Show("Debe Llenar los Campos Obligatorios")
           Exit Sub
       Else
           If BanderaRecibo_cliente_cheque_2  = 1 Then
               Me.Guardar()
           Else
               Me.Guardar()
           End If
       End If
   End Sub

   Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
       Me.Close()
   End Sub

    'Private Sub cmbPago_cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPago_cliente.SelectedIndexChanged
    '    If Me.cmbPago_cliente.SelectedIndex >= 0 Then
    '        Me.lblid_pago_cliente.Text = cmbPago_cliente.SelectedValue.ToString
    '    End If
    'End Sub

    'Private Sub btnBuscaPago_cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaPago_cliente.Click
    '    Dim frmTemporal As New FrmAbmPago_cliente
    '    frmTemporal.ShowDialog()
    '    Me.CargarPago_cliente()
    '    Me.cmbPago_cliente.Focus()
    '    Me.cmbPago_cliente.Text = ""
    '    Me.lblid_Pago_cliente.Text = "0"
    'End Sub

   Private Sub cmbCheque_recibo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCheque_recibo.SelectedIndexChanged
       If Me.cmbCheque_recibo.SelectedIndex >= 0 Then
           Me.lblid_cheque_recibo.Text = cmbCheque_recibo.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaCheque_recibo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaCheque_recibo.Click
        Dim frmTemporal As New Frmmovbancos
       frmTemporal.ShowDialog()
       Me.CargarCheque_recibo()
       Me.cmbCheque_recibo.Focus()
       Me.cmbCheque_recibo.Text = ""
       Me.lblid_Cheque_recibo.Text = "0"
   End Sub

   Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles chkcontrol.KeyPress
       If e.KeyChar.ToString = vbCr Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

    'Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    'Handles cmbPago_cliente.KeyDown, cmbCheque_recibo.KeyDown
    '    If CDbl(e.KeyValue.ToString) = 13 Then
    '        Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
    '    End If
    'End Sub

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

End Class
