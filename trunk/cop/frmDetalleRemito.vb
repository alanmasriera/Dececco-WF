Public Class frmDetalleRemito

   Private Sub frmDetalleRemito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnBuscaFactura, "Buscar Nuevo Factura")
       Me.ttGeneral.SetToolTip(Me.btnBuscaCliente, "Buscar Nuevo Cliente")
       Me.ttGeneral.SetToolTip(Me.btnBuscaCondicion_venta, "Buscar Nuevo Condicion_venta")
       Me.ttGeneral.SetToolTip(Me.btnBuscaUsuario, "Buscar Nuevo Usuario")
       Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Remito")
       Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
       Try
           ObtenerDatos()

           Me.cmbFactura.Text = oFactura.GetOne(CInt(Me.lblid_Factura.Text)).Rows(0).Item("nombre Factura").ToString.Trim
           Me.cmbCliente.Text = oCliente.GetOne(CInt(Me.lblid_Cliente.Text)).Rows(0).Item("nombre Cliente").ToString.Trim
           Me.cmbCondicion_venta.Text = oCondicion_venta.GetOne(CInt(Me.lblid_Condicion_venta.Text)).Rows(0).Item("nombre Condicion_venta").ToString.Trim
           Me.cmbUsuario.Text = oUsuario.GetOne(CInt(Me.lblid_Usuario.Text)).Rows(0).Item("nombre Usuario").ToString.Trim
       Catch ex As Exception
           '    MessageBox.Show(ex.Message)
       End Try

       If BanderaRemito  = 1 Then
           Me.LimpiarControles()
       End If
       Me.Text = "Remito" & vgNombreFormulario
       Me.CancelButton = Me.btnSalir
       Me.BackColor = Color.Gainsboro
       Me.StartPosition = FormStartPosition.CenterScreen
       Me.MinimizeBox = False
       Me.MaximizeBox = False
   End Sub

   Sub CargarCombos()
       Me.CargarFactura
       Me.CargarCliente
       Me.CargarCondicion_venta
       Me.CargarUsuario
   End Sub

   Sub CargarFactura()
       Dim odt As New DataTable

       odt = oFactura.GetCmb
       With Me.cmbFactura
           .DataSource = odt
           .DisplayMember = "nombre_factura"
           .ValueMember = "id_factura"
       End With
       If Me.cmbFactura.SelectedIndex >= 0 Then
           cmbFactura.SelectedIndex = 0
           Me.lblid_Factura.Text = cmbFactura.SelectedValue.ToString
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

   Sub CargarCondicion_venta()
       Dim odt As New DataTable

       odt = oCondicion_venta.GetCmb
       With Me.cmbCondicion_venta
           .DataSource = odt
           .DisplayMember = "nombre_condicion_venta"
           .ValueMember = "id_condicion_venta"
       End With
       If Me.cmbCondicion_venta.SelectedIndex >= 0 Then
           cmbCondicion_venta.SelectedIndex = 0
           Me.lblid_Condicion_venta.Text = cmbCondicion_venta.SelectedValue.ToString
       End If
   End Sub

   Sub CargarUsuario()
       Dim odt As New DataTable

       odt = oUsuario.GetCmb
       With Me.cmbUsuario
           .DataSource = odt
           .DisplayMember = "nombre_usuario"
           .ValueMember = "id_usuario"
       End With
       If Me.cmbUsuario.SelectedIndex >= 0 Then
           cmbUsuario.SelectedIndex = 0
           Me.lblid_Usuario.Text = cmbUsuario.SelectedValue.ToString
       End If
   End Sub

   Sub LimpiarControles()
       Me.lblid_factura.Text = "0"
       Me.cmbFactura.Text =  ""
       Me.dtpfecha_remito.Value = DateTime.Now
       Me.txtnumero_remito.Text = ""
       Me.lblid_cliente.Text = "0"
       Me.cmbCliente.Text =  ""
       Me.txtobservacion.Text = ""
       Me.lblid_condicion_venta.Text = "0"
       Me.cmbCondicion_venta.Text =  ""
       Me.lblid_usuario.Text = "0"
       Me.cmbUsuario.Text =  ""
   End Sub

   Private Sub ObtenerDatos()
       Me.lblid_factura.Text = oRemito.id_factura.ToString
       Me.dtpfecha_remito.Value = oRemito.fecha_remito
       Me.txtnumero_remito.Text = oRemito.numero_remito.Trim
       Me.lblid_cliente.Text = oRemito.id_cliente.ToString
       Me.txtobservacion.Text = oRemito.observacion.Trim
       Me.lblid_condicion_venta.Text = oRemito.id_condicion_venta.ToString
       Me.lblid_usuario.Text = oRemito.id_usuario.ToString
   End Sub

   Private Sub AsignarDatos()
       oRemito.id_factura = CInt(Me.lblid_factura.Text)
       oRemito.fecha_remito = Me.dtpfecha_remito.Value.Date
       oRemito.numero_remito = Me.txtnumero_remito.Text
       oRemito.id_cliente = CInt(Me.lblid_cliente.Text)
       oRemito.observacion = Me.txtobservacion.Text
       oRemito.id_condicion_venta = CInt(Me.lblid_condicion_venta.Text)
       oRemito.id_usuario = CInt(Me.lblid_usuario.Text)
   End Sub

   Public Sub SoloLectura()
       Me.cmbFactura.Enabled = False
       Me.btnBuscaFactura.Enabled = False
       Me.dtpfecha_remito.Enabled = False
       Me.txtnumero_remito.Enabled = False
       Me.cmbCliente.Enabled = False
       Me.btnBuscaCliente.Enabled = False
       Me.txtobservacion.Enabled = False
       Me.cmbCondicion_venta.Enabled = False
       Me.btnBuscaCondicion_venta.Enabled = False
       Me.cmbUsuario.Enabled = False
       Me.btnBuscaUsuario.Enabled = False
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
                   CType(Me.Owner, frmAbmRemito).RefrescarGrilla()
                   Me.CargarCombos()
                   oRemito.Insertar()
                   Me.ObtenerDatos()
                   Me.LimpiarControles()
                   Me.cmbFactura.Focus
               Case 2 'GUARDA Y SALE (MODIFICAR)
                   oRemito.Guardar()
                   Me.Close()
           End Select
       Catch ex As Exception
           MessageBox.Show(ex.Message)
       End Try
   End Sub

   Private Function ChequearVacios() As Boolean
       Dim bandera As Boolean
       If _ 
       Me.txtnumero_remito.Text = "" or _
       Me.txtobservacion.Text = "" Then
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
       If CDbl(Me.lblid_condicion_venta.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de condicion_venta")
           Exit Sub
       End If
       If CDbl(Me.lblid_usuario.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de usuario")
           Exit Sub
       End If

       blnVacios = Me.ChequearVacios
       If blnVacios = False Then
           MessageBox.Show("Debe Llenar los Campos Obligatorios")
           Exit Sub
       Else
           If BanderaRemito  = 1 Then
               Me.Guardar()
           Else
               Me.Guardar()
           End If
       End If
   End Sub

   Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
       Me.Close()
   End Sub

   Private Sub cmbFactura_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFactura.SelectedIndexChanged
       If Me.cmbFactura.SelectedIndex >= 0 Then
           Me.lblid_factura.Text = cmbFactura.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaFactura.Click
       Dim frmTemporal As New FrmAbmFactura
       frmTemporal.ShowDialog()
       Me.CargarFactura()
       Me.cmbFactura.Focus()
       Me.cmbFactura.Text = ""
       Me.lblid_Factura.Text = "0"
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

   Private Sub cmbCondicion_venta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCondicion_venta.SelectedIndexChanged
       If Me.cmbCondicion_venta.SelectedIndex >= 0 Then
           Me.lblid_condicion_venta.Text = cmbCondicion_venta.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaCondicion_venta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaCondicion_venta.Click
       Dim frmTemporal As New FrmAbmCondicion_venta
       frmTemporal.ShowDialog()
       Me.CargarCondicion_venta()
       Me.cmbCondicion_venta.Focus()
       Me.cmbCondicion_venta.Text = ""
       Me.lblid_Condicion_venta.Text = "0"
   End Sub

   Private Sub cmbUsuario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUsuario.SelectedIndexChanged
       If Me.cmbUsuario.SelectedIndex >= 0 Then
           Me.lblid_usuario.Text = cmbUsuario.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaUsuario.Click
       Dim frmTemporal As New FrmAbmUsuario
       frmTemporal.ShowDialog()
       Me.CargarUsuario()
       Me.cmbUsuario.Focus()
       Me.cmbUsuario.Text = ""
       Me.lblid_Usuario.Text = "0"
   End Sub

   Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtnumero_remito.KeyPress, txtobservacion.KeyPress
       If e.KeyChar.ToString = vbCr Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
   Handles cmbFactura.KeyDown, dtpfecha_remito.KeyDown, cmbCliente.KeyDown, cmbCondicion_venta.KeyDown, cmbUsuario.KeyDown
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

End Class
