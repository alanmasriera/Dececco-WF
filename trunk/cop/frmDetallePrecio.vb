Public Class frmDetallePrecio

   Private Sub frmDetallePrecio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnBuscaProducto, "Buscar Nuevo Producto")
       Me.ttGeneral.SetToolTip(Me.btnBuscaProveedor, "Buscar Nuevo Proveedor")
       Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Precio")
       Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
       Try
           ObtenerDatos()

           Me.cmbProducto.Text = oProducto.GetOne(CInt(Me.lblid_Producto.Text)).Rows(0).Item("nombre Producto").ToString.Trim
           Me.cmbProveedor.Text = oProveedor.GetOne(CInt(Me.lblid_Proveedor.Text)).Rows(0).Item("nombre Proveedor").ToString.Trim
       Catch ex As Exception
           '    MessageBox.Show(ex.Message)
       End Try

       If BanderaPrecio  = 1 Then
           Me.LimpiarControles()
       End If
       Me.Text = "Precio" & vgNombreFormulario
       Me.CancelButton = Me.btnSalir
       Me.BackColor = Color.Gainsboro
       Me.StartPosition = FormStartPosition.CenterScreen
       Me.MinimizeBox = False
       Me.MaximizeBox = False
   End Sub

   Sub CargarCombos()
       Me.CargarProducto
       Me.CargarProveedor
   End Sub

   Sub CargarProducto()
       Dim odt As New DataTable

       odt = oProducto.GetCmb
       With Me.cmbProducto
           .DataSource = odt
           .DisplayMember = "nombre_producto"
           .ValueMember = "id_producto"
       End With
       If Me.cmbProducto.SelectedIndex >= 0 Then
           cmbProducto.SelectedIndex = 0
           Me.lblid_Producto.Text = cmbProducto.SelectedValue.ToString
       End If
   End Sub

   Sub CargarProveedor()
       Dim odt As New DataTable

       odt = oProveedor.GetCmb
       With Me.cmbProveedor
           .DataSource = odt
           .DisplayMember = "nombre_proveedor"
           .ValueMember = "id_proveedor"
       End With
       If Me.cmbProveedor.SelectedIndex >= 0 Then
           cmbProveedor.SelectedIndex = 0
           Me.lblid_Proveedor.Text = cmbProveedor.SelectedValue.ToString
       End If
   End Sub

   Sub LimpiarControles()
       Me.lblid_producto.Text = "0"
       Me.cmbProducto.Text =  ""
       Me.lblid_proveedor.Text = "0"
       Me.cmbProveedor.Text =  ""
       Me.txtprecio.Text = "0"
       Me.txtalicuota.Text = "0"
       Me.txtiva.Text = "0"
       Me.txtimpuesto_interno.Text = "0"
       Me.txtpack.Text = "0"
       Me.txtmargen_ganancia.Text = "0"
       Me.txtcod_producto_proveedor.Text = ""
       Me.txtprecio_venta_unitario.Text = "0"
       Me.txtprecio_venta_mayorista.Text = "0"
       Me.txtprecio_venta_publico.Text = "0"
       Me.txtbonificacion1.Text = "0"
       Me.txtbonificacion2.Text = "0"
   End Sub

   Private Sub ObtenerDatos()
       Me.lblid_producto.Text = oPrecio.id_producto.ToString
       Me.lblid_proveedor.Text = oPrecio.id_proveedor.ToString
       Me.txtprecio.Text = oPrecio.precio.ToString.Trim
       Me.txtalicuota.Text = oPrecio.alicuota.ToString.Trim
       Me.txtiva.Text = oPrecio.iva.ToString.Trim
       Me.txtimpuesto_interno.Text = oPrecio.impuesto_interno.ToString.Trim
       Me.txtpack.Text = oPrecio.pack.ToString.Trim
       Me.txtmargen_ganancia.Text = oPrecio.margen_ganancia.ToString.Trim
       Me.txtcod_producto_proveedor.Text = oPrecio.cod_producto_proveedor.Trim
       Me.txtprecio_venta_unitario.Text = oPrecio.precio_venta_unitario.ToString.Trim
       Me.txtprecio_venta_mayorista.Text = oPrecio.precio_venta_mayorista.ToString.Trim
       Me.txtprecio_venta_publico.Text = oPrecio.precio_venta_publico.ToString.Trim
       Me.txtbonificacion1.Text = oPrecio.bonificacion1.ToString.Trim
       Me.txtbonificacion2.Text = oPrecio.bonificacion2.ToString.Trim
   End Sub

   Private Sub AsignarDatos()
       oPrecio.id_producto = CInt(Me.lblid_producto.Text)
       oPrecio.id_proveedor = CInt(Me.lblid_proveedor.Text)
       oPrecio.precio = CDec(Me.txtprecio.Text)
       oPrecio.alicuota = CDec(Me.txtalicuota.Text)
       oPrecio.iva = CDec(Me.txtiva.Text)
       oPrecio.impuesto_interno = CDec(Me.txtimpuesto_interno.Text)
       oPrecio.pack = CDec(Me.txtpack.Text)
       oPrecio.margen_ganancia = CDec(Me.txtmargen_ganancia.Text)
       oPrecio.cod_producto_proveedor = Me.txtcod_producto_proveedor.Text
       oPrecio.precio_venta_unitario = CDec(Me.txtprecio_venta_unitario.Text)
       oPrecio.precio_venta_mayorista = CDec(Me.txtprecio_venta_mayorista.Text)
       oPrecio.precio_venta_publico = CDec(Me.txtprecio_venta_publico.Text)
       oPrecio.bonificacion1 = CDec(Me.txtbonificacion1.Text)
       oPrecio.bonificacion2 = CDec(Me.txtbonificacion2.Text)
   End Sub

   Public Sub SoloLectura()
       Me.cmbProducto.Enabled = False
       Me.btnBuscaProducto.Enabled = False
       Me.cmbProveedor.Enabled = False
       Me.btnBuscaProveedor.Enabled = False
       Me.txtprecio.Enabled = False
       Me.txtalicuota.Enabled = False
       Me.txtiva.Enabled = False
       Me.txtimpuesto_interno.Enabled = False
       Me.txtpack.Enabled = False
       Me.txtmargen_ganancia.Enabled = False
       Me.txtcod_producto_proveedor.Enabled = False
       Me.txtprecio_venta_unitario.Enabled = False
       Me.txtprecio_venta_mayorista.Enabled = False
       Me.txtprecio_venta_publico.Enabled = False
       Me.txtbonificacion1.Enabled = False
       Me.txtbonificacion2.Enabled = False
       Me.btnGuardar.Visible = False
   End Sub

   Private Sub Guardar()
       Try
           Me.AsignarDatos()
           If oPrecio.Exist() Then
               If BanderaPrecio = 1 Then
                   MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
               Exit Sub
               ElseIf BanderaPrecio = 2 Then
                   If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                       = Windows.Forms.DialogResult.No Then
                       Exit Sub
                   End If
               End If
           End If
           Select Case BanderaPrecio
               Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                   oPrecio.Guardar()
                   CType(Me.Owner, frmAbmPrecio).RefrescarGrilla()
                   Me.CargarCombos()
                   oPrecio.Insertar()
                   Me.ObtenerDatos()
                   Me.LimpiarControles()
                   Me.cmbProducto.Focus
               Case 2 'GUARDA Y SALE (MODIFICAR)
                   oPrecio.Guardar()
                   Me.Close()
           End Select
       Catch ex As Exception
           MessageBox.Show(ex.Message)
       End Try
   End Sub

   Private Function ChequearVacios() As Boolean
       Dim bandera As Boolean
       If _ 
       Me.txtprecio.Text = "" or _
       Me.txtalicuota.Text = "" or _
       Me.txtiva.Text = "" or _
       Me.txtimpuesto_interno.Text = "" or _
       Me.txtpack.Text = "" or _
       Me.txtmargen_ganancia.Text = "" or _
       Me.txtcod_producto_proveedor.Text = "" or _
       Me.txtprecio_venta_unitario.Text = "" or _
       Me.txtprecio_venta_mayorista.Text = "" or _
       Me.txtprecio_venta_publico.Text = "" or _
       Me.txtbonificacion1.Text = "" or _
       Me.txtbonificacion2.Text = "" Then
           bandera = False
       Else
           bandera = True
       End If
       Return bandera
   End Function

   Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
       Dim blnVacios As Boolean

       If CDbl(Me.lblid_producto.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de producto")
           Exit Sub
       End If
       If CDbl(Me.lblid_proveedor.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de proveedor")
           Exit Sub
       End If

       blnVacios = Me.ChequearVacios
       If blnVacios = False Then
           MessageBox.Show("Debe Llenar los Campos Obligatorios")
           Exit Sub
       Else
           If BanderaPrecio  = 1 Then
               Me.Guardar()
           Else
               Me.Guardar()
           End If
       End If
   End Sub

   Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
       Me.Close()
   End Sub

   Private Sub cmbProducto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProducto.SelectedIndexChanged
       If Me.cmbProducto.SelectedIndex >= 0 Then
           Me.lblid_producto.Text = cmbProducto.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaProducto.Click
       Dim frmTemporal As New FrmAbmProducto
       frmTemporal.ShowDialog()
       Me.CargarProducto()
       Me.cmbProducto.Focus()
       Me.cmbProducto.Text = ""
       Me.lblid_Producto.Text = "0"
   End Sub

   Private Sub cmbProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProveedor.SelectedIndexChanged
       If Me.cmbProveedor.SelectedIndex >= 0 Then
           Me.lblid_proveedor.Text = cmbProveedor.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaProveedor.Click
       Dim frmTemporal As New FrmAbmProveedor
       frmTemporal.ShowDialog()
       Me.CargarProveedor()
       Me.cmbProveedor.Focus()
       Me.cmbProveedor.Text = ""
       Me.lblid_Proveedor.Text = "0"
   End Sub

   Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtcod_producto_proveedor.KeyPress
       If e.KeyChar.ToString = vbCr Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
   Handles cmbProducto.KeyDown, cmbProveedor.KeyDown
       If CDbl(e.KeyValue.ToString) = 13 Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtprecio.KeyPress, txtalicuota.KeyPress, txtiva.KeyPress, txtimpuesto_interno.KeyPress, txtpack.KeyPress, txtmargen_ganancia.KeyPress, txtprecio_venta_unitario.KeyPress, txtprecio_venta_mayorista.KeyPress, txtprecio_venta_publico.KeyPress, txtbonificacion1.KeyPress, txtbonificacion2.KeyPress
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
