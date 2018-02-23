Public Class frmDetalleTemp_grilla_pago_cliente

   Private Sub frmDetalleTemp_grilla_pago_cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnBuscaPago_cliente, "Buscar Nuevo Pago_cliente")
       Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Temp_grilla_pago_cliente")
       Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
       Try
           ObtenerDatos()

           Me.cmbPago_cliente.Text = oPago_cliente.GetOne(CInt(Me.lblid_Pago_cliente.Text)).Rows(0).Item("nombre Pago_cliente").ToString.Trim
       Catch ex As Exception
           '    MessageBox.Show(ex.Message)
       End Try

       If BanderaTemp_grilla_pago_cliente  = 1 Then
           Me.LimpiarControles()
       End If
       Me.Text = "Temp_grilla_pago_cliente" & vgNombreFormulario
       Me.CancelButton = Me.btnSalir
       Me.BackColor = Color.Gainsboro
       Me.StartPosition = FormStartPosition.CenterScreen
       Me.MinimizeBox = False
       Me.MaximizeBox = False
   End Sub

   Sub CargarCombos()
       Me.CargarPago_cliente
   End Sub

   Sub CargarPago_cliente()
       Dim odt As New DataTable

       odt = oPago_cliente.GetCmb
       With Me.cmbPago_cliente
           .DataSource = odt
           .DisplayMember = "nombre_pago_cliente"
           .ValueMember = "id_pago_cliente"
       End With
       If Me.cmbPago_cliente.SelectedIndex >= 0 Then
           cmbPago_cliente.SelectedIndex = 0
           Me.lblid_Pago_cliente.Text = cmbPago_cliente.SelectedValue.ToString
       End If
   End Sub

   Sub LimpiarControles()
       Me.lblid_pago_cliente.Text = "0"
       Me.cmbPago_cliente.Text =  ""
       Me.dtpfecha.Value = DateTime.Now
       Me.txtapellido.Text = ""
       Me.txtnombre.Text = ""
       Me.txtpago.Text = "0"
       Me.txtdetalle.Text = ""
       Me.txtnumero_recibo.Text = ""
       Me.txtobservacion.Text = ""
       Me.txtnumero_orden_compra.Text = ""
   End Sub

   Private Sub ObtenerDatos()
       Me.lblid_pago_cliente.Text = oTemp_grilla_pago_cliente.id_pago_cliente.ToString
       Me.dtpfecha.Value = oTemp_grilla_pago_cliente.fecha
       Me.txtapellido.Text = oTemp_grilla_pago_cliente.apellido.Trim
       Me.txtnombre.Text = oTemp_grilla_pago_cliente.nombre.Trim
       Me.txtpago.Text = oTemp_grilla_pago_cliente.pago.ToString.Trim
       Me.txtdetalle.Text = oTemp_grilla_pago_cliente.detalle.Trim
       Me.txtnumero_recibo.Text = oTemp_grilla_pago_cliente.numero_recibo.Trim
       Me.txtobservacion.Text = oTemp_grilla_pago_cliente.observacion.Trim
       Me.txtnumero_orden_compra.Text = oTemp_grilla_pago_cliente.numero_orden_compra.Trim
   End Sub

   Private Sub AsignarDatos()
       oTemp_grilla_pago_cliente.id_pago_cliente = CInt(Me.lblid_pago_cliente.Text)
       oTemp_grilla_pago_cliente.fecha = Me.dtpfecha.Value.Date
       oTemp_grilla_pago_cliente.apellido = Me.txtapellido.Text
       oTemp_grilla_pago_cliente.nombre = Me.txtnombre.Text
       oTemp_grilla_pago_cliente.pago = CDec(Me.txtpago.Text)
       oTemp_grilla_pago_cliente.detalle = Me.txtdetalle.Text
       oTemp_grilla_pago_cliente.numero_recibo = Me.txtnumero_recibo.Text
       oTemp_grilla_pago_cliente.observacion = Me.txtobservacion.Text
       oTemp_grilla_pago_cliente.numero_orden_compra = Me.txtnumero_orden_compra.Text
   End Sub

   Public Sub SoloLectura()
       Me.cmbPago_cliente.Enabled = False
       Me.btnBuscaPago_cliente.Enabled = False
       Me.dtpfecha.Enabled = False
       Me.txtapellido.Enabled = False
       Me.txtnombre.Enabled = False
       Me.txtpago.Enabled = False
       Me.txtdetalle.Enabled = False
       Me.txtnumero_recibo.Enabled = False
       Me.txtobservacion.Enabled = False
       Me.txtnumero_orden_compra.Enabled = False
       Me.btnGuardar.Visible = False
   End Sub

   Private Sub Guardar()
       Try
           Me.AsignarDatos()
           If oTemp_grilla_pago_cliente.Exist() Then
               If BanderaTemp_grilla_pago_cliente = 1 Then
                   MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
               Exit Sub
               ElseIf BanderaTemp_grilla_pago_cliente = 2 Then
                   If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                       = Windows.Forms.DialogResult.No Then
                       Exit Sub
                   End If
               End If
           End If
           Select Case BanderaTemp_grilla_pago_cliente
               Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                   oTemp_grilla_pago_cliente.Guardar()
                   CType(Me.Owner, frmAbmTemp_grilla_pago_cliente).RefrescarGrilla()
                   Me.CargarCombos()
                   oTemp_grilla_pago_cliente.Insertar()
                   Me.ObtenerDatos()
                   Me.LimpiarControles()
                   Me.cmbPago_cliente.Focus
               Case 2 'GUARDA Y SALE (MODIFICAR)
                   oTemp_grilla_pago_cliente.Guardar()
                   Me.Close()
           End Select
       Catch ex As Exception
           MessageBox.Show(ex.Message)
       End Try
   End Sub

   Private Function ChequearVacios() As Boolean
       Dim bandera As Boolean
       If _ 
       Me.txtapellido.Text = "" or _
       Me.txtnombre.Text = "" or _
       Me.txtpago.Text = "" or _
       Me.txtdetalle.Text = "" or _
       Me.txtnumero_recibo.Text = "" or _
       Me.txtobservacion.Text = "" or _
       Me.txtnumero_orden_compra.Text = "" Then
           bandera = False
       Else
           bandera = True
       End If
       Return bandera
   End Function

   Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
       Dim blnVacios As Boolean

       If CDbl(Me.lblid_pago_cliente.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de pago_cliente")
           Exit Sub
       End If

       blnVacios = Me.ChequearVacios
       If blnVacios = False Then
           MessageBox.Show("Debe Llenar los Campos Obligatorios")
           Exit Sub
       Else
           If BanderaTemp_grilla_pago_cliente  = 1 Then
               Me.Guardar()
           Else
               Me.Guardar()
           End If
       End If
   End Sub

   Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
       Me.Close()
   End Sub

   Private Sub cmbPago_cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPago_cliente.SelectedIndexChanged
       If Me.cmbPago_cliente.SelectedIndex >= 0 Then
           Me.lblid_pago_cliente.Text = cmbPago_cliente.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaPago_cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaPago_cliente.Click
       Dim frmTemporal As New FrmAbmPago_cliente
       frmTemporal.ShowDialog()
       Me.CargarPago_cliente()
       Me.cmbPago_cliente.Focus()
       Me.cmbPago_cliente.Text = ""
       Me.lblid_Pago_cliente.Text = "0"
   End Sub

   Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtapellido.KeyPress, txtnombre.KeyPress, txtdetalle.KeyPress, txtnumero_recibo.KeyPress, txtobservacion.KeyPress, txtnumero_orden_compra.KeyPress
       If e.KeyChar.ToString = vbCr Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
   Handles cmbPago_cliente.KeyDown, dtpfecha.KeyDown
       If CDbl(e.KeyValue.ToString) = 13 Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtpago.KeyPress
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
