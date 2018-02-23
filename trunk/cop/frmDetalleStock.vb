Public Class frmDetalleStock

   Private Sub frmDetalleStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnBuscaProducto, "Buscar Nuevo Producto")
       Me.ttGeneral.SetToolTip(Me.btnBuscaAlmacen, "Buscar Nuevo Almacen")
       Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Stock")
       Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
       Try
           ObtenerDatos()

           Me.cmbProducto.Text = oProducto.GetOne(CInt(Me.lblid_Producto.Text)).Rows(0).Item("nombre Producto").ToString.Trim
           Me.cmbAlmacen.Text = oAlmacen.GetOne(CInt(Me.lblid_Almacen.Text)).Rows(0).Item("nombre Almacen").ToString.Trim
       Catch ex As Exception
           '    MessageBox.Show(ex.Message)
       End Try

       If BanderaStock  = 1 Then
           Me.LimpiarControles()
       End If
       Me.Text = "Stock" & vgNombreFormulario
       Me.CancelButton = Me.btnSalir
       Me.BackColor = Color.Gainsboro
       Me.StartPosition = FormStartPosition.CenterScreen
       Me.MinimizeBox = False
       Me.MaximizeBox = False
   End Sub

   Sub CargarCombos()
       Me.CargarProducto
       Me.CargarAlmacen
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

   Sub CargarAlmacen()
       Dim odt As New DataTable

       odt = oAlmacen.GetCmb
       With Me.cmbAlmacen
           .DataSource = odt
           .DisplayMember = "nombre_almacen"
           .ValueMember = "id_almacen"
       End With
       If Me.cmbAlmacen.SelectedIndex >= 0 Then
           cmbAlmacen.SelectedIndex = 0
           Me.lblid_Almacen.Text = cmbAlmacen.SelectedValue.ToString
       End If
   End Sub

   Sub LimpiarControles()
       Me.lblid_producto.Text = "0"
       Me.cmbProducto.Text =  ""
       Me.lblid_almacen.Text = "0"
       Me.cmbAlmacen.Text =  ""
       Me.txtstock.Text = "0"
       Me.chkactualizado.Checked = False
       Me.txtstock_oferta.Text = "0"
   End Sub

   Private Sub ObtenerDatos()
       Me.lblid_producto.Text = oStock.id_producto.ToString
       Me.lblid_almacen.Text = oStock.id_almacen.ToString
       Me.txtstock.Text = oStock.stock.ToString.Trim
       Me.chkactualizado.Checked = oStock.actualizado
       Me.txtstock_oferta.Text = oStock.stock_oferta.ToString.Trim
   End Sub

   Private Sub AsignarDatos()
       oStock.id_producto = CInt(Me.lblid_producto.Text)
       oStock.id_almacen = CInt(Me.lblid_almacen.Text)
       oStock.stock = CDec(Me.txtstock.Text)
       oStock.actualizado = Me.chkactualizado.Checked
       oStock.stock_oferta = CDec(Me.txtstock_oferta.Text)
   End Sub

   Public Sub SoloLectura()
       Me.cmbProducto.Enabled = False
       Me.btnBuscaProducto.Enabled = False
       Me.cmbAlmacen.Enabled = False
       Me.btnBuscaAlmacen.Enabled = False
       Me.txtstock.Enabled = False
       Me.chkactualizado.Enabled = False
       Me.txtstock_oferta.Enabled = False
       Me.btnGuardar.Visible = False
   End Sub

   Private Sub Guardar()
       Try
           Me.AsignarDatos()
           If oStock.Exist() Then
               If BanderaStock = 1 Then
                   MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
               Exit Sub
               ElseIf BanderaStock = 2 Then
                   If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                       = Windows.Forms.DialogResult.No Then
                       Exit Sub
                   End If
               End If
           End If
           Select Case BanderaStock
               Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                   oStock.Guardar()
                   CType(Me.Owner, frmAbmStock).RefrescarGrilla()
                   Me.CargarCombos()
                   oStock.Insertar()
                   Me.ObtenerDatos()
                   Me.LimpiarControles()
                   Me.cmbProducto.Focus
               Case 2 'GUARDA Y SALE (MODIFICAR)
                   oStock.Guardar()
                   Me.Close()
           End Select
       Catch ex As Exception
           MessageBox.Show(ex.Message)
       End Try
   End Sub

   Private Function ChequearVacios() As Boolean
       Dim bandera As Boolean
       If _ 
       Me.txtstock.Text = "" or _
       Me.txtstock_oferta.Text = "" Then
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
       If CDbl(Me.lblid_almacen.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de almacen")
           Exit Sub
       End If

       blnVacios = Me.ChequearVacios
       If blnVacios = False Then
           MessageBox.Show("Debe Llenar los Campos Obligatorios")
           Exit Sub
       Else
           If BanderaStock  = 1 Then
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

   Private Sub cmbAlmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAlmacen.SelectedIndexChanged
       If Me.cmbAlmacen.SelectedIndex >= 0 Then
           Me.lblid_almacen.Text = cmbAlmacen.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaAlmacen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaAlmacen.Click
       Dim frmTemporal As New FrmAbmAlmacen
       frmTemporal.ShowDialog()
       Me.CargarAlmacen()
       Me.cmbAlmacen.Focus()
       Me.cmbAlmacen.Text = ""
       Me.lblid_Almacen.Text = "0"
   End Sub

   Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles chkactualizado.KeyPress
       If e.KeyChar.ToString = vbCr Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
   Handles cmbProducto.KeyDown, cmbAlmacen.KeyDown
       If CDbl(e.KeyValue.ToString) = 13 Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtstock.KeyPress, txtstock_oferta.KeyPress
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
