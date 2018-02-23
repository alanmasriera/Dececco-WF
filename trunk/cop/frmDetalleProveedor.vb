Public Class frmDetalleProveedor

   Private Sub frmDetalleProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnBuscaCondicion_iva, "Buscar Nuevo Condicion_iva")
       Me.ttGeneral.SetToolTip(Me.btnBuscaTipo_proveedor, "Buscar Nuevo Tipo_proveedor")
       Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Proveedor")
       Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
       Try
           ObtenerDatos()

           Me.cmbCondicion_iva.Text = oCondicion_iva.GetOne(CInt(Me.lblid_Condicion_iva.Text)).Rows(0).Item("nombre Condicion_iva").ToString.Trim
           Me.cmbTipo_proveedor.Text = oTipo_proveedor.GetOne(CInt(Me.lblid_Tipo_proveedor.Text)).Rows(0).Item("nombre Tipo_proveedor").ToString.Trim
       Catch ex As Exception
           '    MessageBox.Show(ex.Message)
       End Try

       If BanderaProveedor  = 1 Then
           Me.LimpiarControles()
       End If
       Me.Text = "Proveedor" & vgNombreFormulario
       Me.CancelButton = Me.btnSalir
       Me.BackColor = Color.Gainsboro
       Me.StartPosition = FormStartPosition.CenterScreen
       Me.MinimizeBox = False
       Me.MaximizeBox = False
   End Sub

   Sub CargarCombos()
       Me.CargarCondicion_iva
       Me.CargarTipo_proveedor
   End Sub

   Sub CargarCondicion_iva()
       Dim odt As New DataTable

       odt = oCondicion_iva.GetCmb
       With Me.cmbCondicion_iva
           .DataSource = odt
           .DisplayMember = "nombre_condicion_iva"
           .ValueMember = "id_condicion_iva"
       End With
       If Me.cmbCondicion_iva.SelectedIndex >= 0 Then
           cmbCondicion_iva.SelectedIndex = 0
           Me.lblid_Condicion_iva.Text = cmbCondicion_iva.SelectedValue.ToString
       End If
   End Sub

   Sub CargarTipo_proveedor()
       Dim odt As New DataTable

       odt = oTipo_proveedor.GetCmb
       With Me.cmbTipo_proveedor
           .DataSource = odt
           .DisplayMember = "nombre_tipo_proveedor"
           .ValueMember = "id_tipo_proveedor"
       End With
       If Me.cmbTipo_proveedor.SelectedIndex >= 0 Then
           cmbTipo_proveedor.SelectedIndex = 0
           Me.lblid_Tipo_proveedor.Text = cmbTipo_proveedor.SelectedValue.ToString
       End If
   End Sub

   Sub LimpiarControles()
       Me.txtnombre_proveedor.Text = ""
       Me.txtcontacto.Text = ""
       Me.txtcuit.Text = ""
       Me.txtingreso_bruto.Text = ""
       Me.txtdireccion.Text = ""
       Me.txtlocalidad.Text = ""
       Me.txtprovincia.Text = ""
       Me.txttelefono.Text = ""
       Me.txtemail.Text = ""
       Me.txtweb.Text = ""
       Me.lblid_condicion_iva.Text = "0"
       Me.cmbCondicion_iva.Text =  ""
       Me.lblid_tipo_proveedor.Text = "0"
       Me.cmbTipo_proveedor.Text =  ""
   End Sub

   Private Sub ObtenerDatos()
       Me.txtnombre_proveedor.Text = oProveedor.nombre_proveedor.Trim
       Me.txtcontacto.Text = oProveedor.contacto.Trim
       Me.txtcuit.Text = oProveedor.cuit.Trim
       Me.txtingreso_bruto.Text = oProveedor.ingreso_bruto.Trim
       Me.txtdireccion.Text = oProveedor.direccion.Trim
       Me.txtlocalidad.Text = oProveedor.localidad.Trim
       Me.txtprovincia.Text = oProveedor.provincia.Trim
       Me.txttelefono.Text = oProveedor.telefono.Trim
       Me.txtemail.Text = oProveedor.email.Trim
       Me.txtweb.Text = oProveedor.web.Trim
       Me.lblid_condicion_iva.Text = oProveedor.id_condicion_iva.ToString
       Me.lblid_tipo_proveedor.Text = oProveedor.id_tipo_proveedor.ToString
   End Sub

   Private Sub AsignarDatos()
       oProveedor.nombre_proveedor = Me.txtnombre_proveedor.Text
       oProveedor.contacto = Me.txtcontacto.Text
       oProveedor.cuit = Me.txtcuit.Text
       oProveedor.ingreso_bruto = Me.txtingreso_bruto.Text
       oProveedor.direccion = Me.txtdireccion.Text
       oProveedor.localidad = Me.txtlocalidad.Text
       oProveedor.provincia = Me.txtprovincia.Text
       oProveedor.telefono = Me.txttelefono.Text
       oProveedor.email = Me.txtemail.Text
       oProveedor.web = Me.txtweb.Text
       oProveedor.id_condicion_iva = CInt(Me.lblid_condicion_iva.Text)
       oProveedor.id_tipo_proveedor = CInt(Me.lblid_tipo_proveedor.Text)
   End Sub

   Public Sub SoloLectura()
       Me.txtnombre_proveedor.Enabled = False
       Me.txtcontacto.Enabled = False
       Me.txtcuit.Enabled = False
       Me.txtingreso_bruto.Enabled = False
       Me.txtdireccion.Enabled = False
       Me.txtlocalidad.Enabled = False
       Me.txtprovincia.Enabled = False
       Me.txttelefono.Enabled = False
       Me.txtemail.Enabled = False
       Me.txtweb.Enabled = False
       Me.cmbCondicion_iva.Enabled = False
       Me.btnBuscaCondicion_iva.Enabled = False
       Me.cmbTipo_proveedor.Enabled = False
       Me.btnBuscaTipo_proveedor.Enabled = False
       Me.btnGuardar.Visible = False
   End Sub

   Private Sub Guardar()
       Try
           Me.AsignarDatos()
           If oProveedor.Exist() Then
               If BanderaProveedor = 1 Then
                   MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
               Exit Sub
               ElseIf BanderaProveedor = 2 Then
                   If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                       = Windows.Forms.DialogResult.No Then
                       Exit Sub
                   End If
               End If
           End If
           Select Case BanderaProveedor
               Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                   oProveedor.Guardar()
                   CType(Me.Owner, frmAbmProveedor).RefrescarGrilla()
                   Me.CargarCombos()
                   oProveedor.Insertar()
                   Me.ObtenerDatos()
                   Me.LimpiarControles()
                   Me.txtnombre_proveedor.Focus
               Case 2 'GUARDA Y SALE (MODIFICAR)
                   oProveedor.Guardar()
                   Me.Close()
           End Select
       Catch ex As Exception
           MessageBox.Show(ex.Message)
       End Try
   End Sub

   Private Function ChequearVacios() As Boolean
       Dim bandera As Boolean
       If _ 
       Me.txtnombre_proveedor.Text = "" or _
       Me.txtcontacto.Text = "" or _
       Me.txtcuit.Text = "" or _
       Me.txtingreso_bruto.Text = "" or _
       Me.txtdireccion.Text = "" or _
       Me.txtlocalidad.Text = "" or _
       Me.txtprovincia.Text = "" or _
       Me.txttelefono.Text = "" or _
       Me.txtemail.Text = "" or _
       Me.txtweb.Text = "" Then
           bandera = False
       Else
           bandera = True
       End If
       Return bandera
   End Function

   Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
       Dim blnVacios As Boolean

       If CDbl(Me.lblid_condicion_iva.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de condicion_iva")
           Exit Sub
       End If
       If CDbl(Me.lblid_tipo_proveedor.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de tipo_proveedor")
           Exit Sub
       End If

       blnVacios = Me.ChequearVacios
       If blnVacios = False Then
           MessageBox.Show("Debe Llenar los Campos Obligatorios")
           Exit Sub
       Else
           If BanderaProveedor  = 1 Then
               Me.Guardar()
           Else
               Me.Guardar()
           End If
       End If
   End Sub

   Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
       Me.Close()
   End Sub

   Private Sub cmbCondicion_iva_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCondicion_iva.SelectedIndexChanged
       If Me.cmbCondicion_iva.SelectedIndex >= 0 Then
           Me.lblid_condicion_iva.Text = cmbCondicion_iva.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaCondicion_iva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaCondicion_iva.Click
       Dim frmTemporal As New FrmAbmCondicion_iva
       frmTemporal.ShowDialog()
       Me.CargarCondicion_iva()
       Me.cmbCondicion_iva.Focus()
       Me.cmbCondicion_iva.Text = ""
       Me.lblid_Condicion_iva.Text = "0"
   End Sub

   Private Sub cmbTipo_proveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipo_proveedor.SelectedIndexChanged
       If Me.cmbTipo_proveedor.SelectedIndex >= 0 Then
           Me.lblid_tipo_proveedor.Text = cmbTipo_proveedor.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaTipo_proveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaTipo_proveedor.Click
       Dim frmTemporal As New FrmAbmTipo_proveedor
       frmTemporal.ShowDialog()
       Me.CargarTipo_proveedor()
       Me.cmbTipo_proveedor.Focus()
       Me.cmbTipo_proveedor.Text = ""
       Me.lblid_Tipo_proveedor.Text = "0"
   End Sub

   Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtnombre_proveedor.KeyPress, txtcontacto.KeyPress, txtcuit.KeyPress, txtingreso_bruto.KeyPress, txtdireccion.KeyPress, txtlocalidad.KeyPress, txtprovincia.KeyPress, txttelefono.KeyPress, txtemail.KeyPress, txtweb.KeyPress
       If e.KeyChar.ToString = vbCr Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
   Handles cmbCondicion_iva.KeyDown, cmbTipo_proveedor.KeyDown
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
