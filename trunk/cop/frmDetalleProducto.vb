Public Class frmDetalleProducto

   Private Sub frmDetalleProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnBuscaSubtipo_producto, "Buscar Nuevo Subtipo_producto")
       Me.ttGeneral.SetToolTip(Me.btnBuscaMarca, "Buscar Nuevo Marca")
       Me.ttGeneral.SetToolTip(Me.btnBuscaUnidad, "Buscar Nuevo Unidad")
       Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Producto")
       Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
       Try
           ObtenerDatos()

           Me.cmbSubtipo_producto.Text = oSubtipo_producto.GetOne(CInt(Me.lblid_Subtipo_producto.Text)).Rows(0).Item("nombre Subtipo_producto").ToString.Trim
           Me.cmbMarca.Text = oMarca.GetOne(CInt(Me.lblid_Marca.Text)).Rows(0).Item("nombre Marca").ToString.Trim
           Me.cmbUnidad.Text = oUnidad.GetOne(CInt(Me.lblid_Unidad.Text)).Rows(0).Item("nombre Unidad").ToString.Trim
       Catch ex As Exception
           '    MessageBox.Show(ex.Message)
       End Try

       If BanderaProducto  = 1 Then
           Me.LimpiarControles()
       End If
       Me.Text = "Producto" & vgNombreFormulario
       Me.CancelButton = Me.btnSalir
       Me.BackColor = Color.Gainsboro
       Me.StartPosition = FormStartPosition.CenterScreen
       Me.MinimizeBox = False
       Me.MaximizeBox = False
   End Sub

   Sub CargarCombos()
       Me.CargarSubtipo_producto
       Me.CargarMarca
       Me.CargarUnidad
   End Sub

   Sub CargarSubtipo_producto()
       Dim odt As New DataTable

       odt = oSubtipo_producto.GetCmb
       With Me.cmbSubtipo_producto
           .DataSource = odt
           .DisplayMember = "nombre_subtipo_producto"
           .ValueMember = "id_subtipo_producto"
       End With
       If Me.cmbSubtipo_producto.SelectedIndex >= 0 Then
           cmbSubtipo_producto.SelectedIndex = 0
           Me.lblid_Subtipo_producto.Text = cmbSubtipo_producto.SelectedValue.ToString
       End If
   End Sub

   Sub CargarMarca()
       Dim odt As New DataTable

       odt = oMarca.GetCmb
       With Me.cmbMarca
           .DataSource = odt
           .DisplayMember = "nombre_marca"
           .ValueMember = "id_marca"
       End With
       If Me.cmbMarca.SelectedIndex >= 0 Then
           cmbMarca.SelectedIndex = 0
           Me.lblid_Marca.Text = cmbMarca.SelectedValue.ToString
       End If
   End Sub

   Sub CargarUnidad()
       Dim odt As New DataTable

       odt = oUnidad.GetCmb
       With Me.cmbUnidad
           .DataSource = odt
           .DisplayMember = "nombre_unidad"
           .ValueMember = "id_unidad"
       End With
       If Me.cmbUnidad.SelectedIndex >= 0 Then
           cmbUnidad.SelectedIndex = 0
           Me.lblid_Unidad.Text = cmbUnidad.SelectedValue.ToString
       End If
   End Sub

   Sub LimpiarControles()
       Me.txtnombre_producto.Text = ""
       Me.txtdescripcion.Text = ""
       Me.txtabreviatura.Text = ""
       Me.txtubicacion.Text = ""
       Me.txtpack.Text = "0"
       Me.txtstock_ideal.Text = "0"
       Me.txtstock_minimo.Text = "0"
       Me.txtcantidad_compra.Text = "0"
       Me.txtcantidad_ingreso.Text = "0"
       Me.lblid_subtipo_producto.Text = "0"
       Me.cmbSubtipo_producto.Text =  ""
       Me.lblid_marca.Text = "0"
       Me.cmbMarca.Text =  ""
       Me.lblid_unidad.Text = "0"
       Me.cmbUnidad.Text =  ""
       Me.chktilde.Checked = False
       Me.txttipo_venta.Text = ""
   End Sub

   Private Sub ObtenerDatos()
       Me.txtnombre_producto.Text = oProducto.nombre_producto.Trim
       Me.txtdescripcion.Text = oProducto.descripcion.Trim
       Me.txtabreviatura.Text = oProducto.abreviatura.Trim
       Me.txtubicacion.Text = oProducto.ubicacion.Trim
       Me.txtpack.Text = oProducto.pack.ToString.Trim
       Me.txtstock_ideal.Text = oProducto.stock_ideal.ToString.Trim
       Me.txtstock_minimo.Text = oProducto.stock_minimo.ToString.Trim
       Me.txtcantidad_compra.Text = oProducto.cantidad_compra.ToString.Trim
       Me.txtcantidad_ingreso.Text = oProducto.cantidad_ingreso.ToString.Trim
       Me.lblid_subtipo_producto.Text = oProducto.id_subtipo_producto.ToString
       Me.lblid_marca.Text = oProducto.id_marca.ToString
       Me.lblid_unidad.Text = oProducto.id_unidad.ToString
       Me.chktilde.Checked = oProducto.tilde
       Me.txttipo_venta.Text = oProducto.tipo_venta.Trim
   End Sub

   Private Sub AsignarDatos()
       oProducto.nombre_producto = Me.txtnombre_producto.Text
       oProducto.descripcion = Me.txtdescripcion.Text
       oProducto.abreviatura = Me.txtabreviatura.Text
       oProducto.ubicacion = Me.txtubicacion.Text
       oProducto.pack = CDec(Me.txtpack.Text)
       oProducto.stock_ideal = CDec(Me.txtstock_ideal.Text)
       oProducto.stock_minimo = CDec(Me.txtstock_minimo.Text)
       oProducto.cantidad_compra = CDec(Me.txtcantidad_compra.Text)
       oProducto.cantidad_ingreso = CDec(Me.txtcantidad_ingreso.Text)
       oProducto.id_subtipo_producto = CInt(Me.lblid_subtipo_producto.Text)
       oProducto.id_marca = CInt(Me.lblid_marca.Text)
       oProducto.id_unidad = CInt(Me.lblid_unidad.Text)
       oProducto.tilde = Me.chktilde.Checked
       oProducto.tipo_venta = Me.txttipo_venta.Text
   End Sub

   Public Sub SoloLectura()
       Me.txtnombre_producto.Enabled = False
       Me.txtdescripcion.Enabled = False
       Me.txtabreviatura.Enabled = False
       Me.txtubicacion.Enabled = False
       Me.txtpack.Enabled = False
       Me.txtstock_ideal.Enabled = False
       Me.txtstock_minimo.Enabled = False
       Me.txtcantidad_compra.Enabled = False
       Me.txtcantidad_ingreso.Enabled = False
       Me.cmbSubtipo_producto.Enabled = False
       Me.btnBuscaSubtipo_producto.Enabled = False
       Me.cmbMarca.Enabled = False
       Me.btnBuscaMarca.Enabled = False
       Me.cmbUnidad.Enabled = False
       Me.btnBuscaUnidad.Enabled = False
       Me.chktilde.Enabled = False
       Me.txttipo_venta.Enabled = False
       Me.btnGuardar.Visible = False
   End Sub

   Private Sub Guardar()
       Try
           Me.AsignarDatos()
           If oProducto.Exist() Then
               If BanderaProducto = 1 Then
                   MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
               Exit Sub
               ElseIf BanderaProducto = 2 Then
                   If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                       = Windows.Forms.DialogResult.No Then
                       Exit Sub
                   End If
               End If
           End If
           Select Case BanderaProducto
               Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                   oProducto.Guardar()
                   CType(Me.Owner, frmAbmProducto).RefrescarGrilla()
                   Me.CargarCombos()
                   oProducto.Insertar()
                   Me.ObtenerDatos()
                   Me.LimpiarControles()
                   Me.txtnombre_producto.Focus
               Case 2 'GUARDA Y SALE (MODIFICAR)
                   oProducto.Guardar()
                   Me.Close()
           End Select
       Catch ex As Exception
           MessageBox.Show(ex.Message)
       End Try
   End Sub

   Private Function ChequearVacios() As Boolean
       Dim bandera As Boolean
       If _ 
       Me.txtnombre_producto.Text = "" or _
       Me.txtdescripcion.Text = "" or _
       Me.txtabreviatura.Text = "" or _
       Me.txtubicacion.Text = "" or _
       Me.txtpack.Text = "" or _
       Me.txtstock_ideal.Text = "" or _
       Me.txtstock_minimo.Text = "" or _
       Me.txtcantidad_compra.Text = "" or _
       Me.txtcantidad_ingreso.Text = "" or _
       Me.txttipo_venta.Text = "" Then
           bandera = False
       Else
           bandera = True
       End If
       Return bandera
   End Function

   Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
       Dim blnVacios As Boolean

       If CDbl(Me.lblid_subtipo_producto.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de subtipo_producto")
           Exit Sub
       End If
       If CDbl(Me.lblid_marca.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de marca")
           Exit Sub
       End If
       If CDbl(Me.lblid_unidad.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de unidad")
           Exit Sub
       End If

       blnVacios = Me.ChequearVacios
       If blnVacios = False Then
           MessageBox.Show("Debe Llenar los Campos Obligatorios")
           Exit Sub
       Else
           If BanderaProducto  = 1 Then
               Me.Guardar()
           Else
               Me.Guardar()
           End If
       End If
   End Sub

   Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
       Me.Close()
   End Sub

   Private Sub cmbSubtipo_producto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSubtipo_producto.SelectedIndexChanged
       If Me.cmbSubtipo_producto.SelectedIndex >= 0 Then
           Me.lblid_subtipo_producto.Text = cmbSubtipo_producto.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaSubtipo_producto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaSubtipo_producto.Click
       Dim frmTemporal As New FrmAbmSubtipo_producto
       frmTemporal.ShowDialog()
       Me.CargarSubtipo_producto()
       Me.cmbSubtipo_producto.Focus()
       Me.cmbSubtipo_producto.Text = ""
       Me.lblid_Subtipo_producto.Text = "0"
   End Sub

   Private Sub cmbMarca_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMarca.SelectedIndexChanged
       If Me.cmbMarca.SelectedIndex >= 0 Then
           Me.lblid_marca.Text = cmbMarca.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaMarca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaMarca.Click
       Dim frmTemporal As New FrmAbmMarca
       frmTemporal.ShowDialog()
       Me.CargarMarca()
       Me.cmbMarca.Focus()
       Me.cmbMarca.Text = ""
       Me.lblid_Marca.Text = "0"
   End Sub

   Private Sub cmbUnidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUnidad.SelectedIndexChanged
       If Me.cmbUnidad.SelectedIndex >= 0 Then
           Me.lblid_unidad.Text = cmbUnidad.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaUnidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaUnidad.Click
       Dim frmTemporal As New FrmAbmUnidad
       frmTemporal.ShowDialog()
       Me.CargarUnidad()
       Me.cmbUnidad.Focus()
       Me.cmbUnidad.Text = ""
       Me.lblid_Unidad.Text = "0"
   End Sub

   Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtnombre_producto.KeyPress, txtdescripcion.KeyPress, txtabreviatura.KeyPress, txtubicacion.KeyPress, chktilde.KeyPress, txttipo_venta.KeyPress
       If e.KeyChar.ToString = vbCr Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
   Handles cmbSubtipo_producto.KeyDown, cmbMarca.KeyDown, cmbUnidad.KeyDown
       If CDbl(e.KeyValue.ToString) = 13 Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtpack.KeyPress, txtstock_ideal.KeyPress, txtstock_minimo.KeyPress, txtcantidad_compra.KeyPress, txtcantidad_ingreso.KeyPress
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
