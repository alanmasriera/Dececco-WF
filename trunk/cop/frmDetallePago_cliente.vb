Public Class frmDetallePago_cliente

   Private Sub frmDetallePago_cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnBuscaCliente, "Buscar Nuevo Cliente")
       Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Pago_cliente")
       Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
       Try
           ObtenerDatos()

           Me.cmbCliente.Text = oCliente.GetOne(CInt(Me.lblid_Cliente.Text)).Rows(0).Item("nombre Cliente").ToString.Trim
       Catch ex As Exception
           '    MessageBox.Show(ex.Message)
       End Try

       If BanderaPago_cliente  = 1 Then
           Me.LimpiarControles()
       End If
       Me.Text = "Pago_cliente" & vgNombreFormulario
       Me.CancelButton = Me.btnSalir
       Me.BackColor = Color.Gainsboro
       Me.StartPosition = FormStartPosition.CenterScreen
       Me.MinimizeBox = False
       Me.MaximizeBox = False
   End Sub

   Sub CargarCombos()
       Me.CargarCliente
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
       Me.lblid_cliente.Text = "0"
       Me.cmbCliente.Text =  ""
       Me.dtpfecha.Value = DateTime.Now
       Me.txtpago.Text = "0"
       Me.txtdetalle.Text = ""
       Me.chkefectivo.Checked = False
       Me.txtnumero_recibo.Text = ""
       Me.txtretencion_iva.Text = "0"
       Me.txtingreso_bruto.Text = "0"
       Me.txtimpuesto_ganancia.Text = "0"
       Me.txtsuss.Text = "0"
       Me.txttotal_letra.Text = ""
       Me.txtobservacion.Text = ""
   End Sub

   Private Sub ObtenerDatos()
       Me.lblid_cliente.Text = oPago_cliente.id_cliente.ToString
       Me.dtpfecha.Value = oPago_cliente.fecha
       Me.txtpago.Text = oPago_cliente.pago.ToString.Trim
       Me.txtdetalle.Text = oPago_cliente.detalle.Trim
       Me.chkefectivo.Checked = oPago_cliente.efectivo
       Me.txtnumero_recibo.Text = oPago_cliente.numero_recibo.Trim
       Me.txtretencion_iva.Text = oPago_cliente.retencion_iva.ToString.Trim
       Me.txtingreso_bruto.Text = oPago_cliente.ingreso_bruto.ToString.Trim
       Me.txtimpuesto_ganancia.Text = oPago_cliente.impuesto_ganancia.ToString.Trim
       Me.txtsuss.Text = oPago_cliente.suss.ToString.Trim
       Me.txttotal_letra.Text = oPago_cliente.total_letra.Trim
       Me.txtobservacion.Text = oPago_cliente.observacion.Trim
   End Sub

   Private Sub AsignarDatos()
       oPago_cliente.id_cliente = CInt(Me.lblid_cliente.Text)
       oPago_cliente.fecha = Me.dtpfecha.Value.Date
       oPago_cliente.pago = CDec(Me.txtpago.Text)
       oPago_cliente.detalle = Me.txtdetalle.Text
       oPago_cliente.efectivo = Me.chkefectivo.Checked
       oPago_cliente.numero_recibo = Me.txtnumero_recibo.Text
       oPago_cliente.retencion_iva = CDec(Me.txtretencion_iva.Text)
       oPago_cliente.ingreso_bruto = CDec(Me.txtingreso_bruto.Text)
       oPago_cliente.impuesto_ganancia = CDec(Me.txtimpuesto_ganancia.Text)
       oPago_cliente.suss = CDec(Me.txtsuss.Text)
       oPago_cliente.total_letra = Me.txttotal_letra.Text
       oPago_cliente.observacion = Me.txtobservacion.Text
   End Sub

   Public Sub SoloLectura()
       Me.cmbCliente.Enabled = False
       Me.btnBuscaCliente.Enabled = False
       Me.dtpfecha.Enabled = False
       Me.txtpago.Enabled = False
       Me.txtdetalle.Enabled = False
       Me.chkefectivo.Enabled = False
       Me.txtnumero_recibo.Enabled = False
       Me.txtretencion_iva.Enabled = False
       Me.txtingreso_bruto.Enabled = False
       Me.txtimpuesto_ganancia.Enabled = False
       Me.txtsuss.Enabled = False
       Me.txttotal_letra.Enabled = False
       Me.txtobservacion.Enabled = False
       Me.btnGuardar.Visible = False
   End Sub

   Private Sub Guardar()
       Try
           Me.AsignarDatos()
           If oPago_cliente.Exist() Then
               If BanderaPago_cliente = 1 Then
                   MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
               Exit Sub
               ElseIf BanderaPago_cliente = 2 Then
                   If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                       = Windows.Forms.DialogResult.No Then
                       Exit Sub
                   End If
               End If
           End If
           Select Case BanderaPago_cliente
               Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                   oPago_cliente.Guardar()
                   CType(Me.Owner, frmAbmPago_cliente).RefrescarGrilla()
                   Me.CargarCombos()
                   oPago_cliente.Insertar()
                   Me.ObtenerDatos()
                   Me.LimpiarControles()
                   Me.cmbCliente.Focus
               Case 2 'GUARDA Y SALE (MODIFICAR)
                   oPago_cliente.Guardar()
                   Me.Close()
           End Select
       Catch ex As Exception
           MessageBox.Show(ex.Message)
       End Try
   End Sub

   Private Function ChequearVacios() As Boolean
       Dim bandera As Boolean
       If _ 
       Me.txtpago.Text = "" or _
       Me.txtdetalle.Text = "" or _
       Me.txtnumero_recibo.Text = "" or _
       Me.txtretencion_iva.Text = "" or _
       Me.txtingreso_bruto.Text = "" or _
       Me.txtimpuesto_ganancia.Text = "" or _
       Me.txtsuss.Text = "" or _
       Me.txttotal_letra.Text = "" or _
       Me.txtobservacion.Text = "" Then
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

       blnVacios = Me.ChequearVacios
       If blnVacios = False Then
           MessageBox.Show("Debe Llenar los Campos Obligatorios")
           Exit Sub
       Else
           If BanderaPago_cliente  = 1 Then
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

   Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtdetalle.KeyPress, chkefectivo.KeyPress, txtnumero_recibo.KeyPress, txttotal_letra.KeyPress, txtobservacion.KeyPress
       If e.KeyChar.ToString = vbCr Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
   Handles cmbCliente.KeyDown, dtpfecha.KeyDown
       If CDbl(e.KeyValue.ToString) = 13 Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtpago.KeyPress, txtretencion_iva.KeyPress, txtingreso_bruto.KeyPress, txtimpuesto_ganancia.KeyPress, txtsuss.KeyPress
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
