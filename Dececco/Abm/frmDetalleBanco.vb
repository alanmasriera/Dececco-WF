Public Class frmDetalleBanco

   Private Sub frmDetalleBanco_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnBuscaCalle, "Buscar Nuevo Calle")
       Me.ttGeneral.SetToolTip(Me.btnBuscaLocalidad, "Buscar Nuevo Localidad")
       Me.ttGeneral.SetToolTip(Me.btnBuscaProvincia, "Buscar Nuevo Provincia")
       Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Banco")
       Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
       Try
           ObtenerDatos()

           Me.cmbCalle.Text = oCalle.GetOne(CInt(Me.lblid_Calle.Text)).Rows(0).Item("nombre_Calle").ToString.Trim
           Me.cmbLocalidad.Text = oLocalidad.GetOne(CInt(Me.lblid_Localidad.Text)).Rows(0).Item("nombre_Localidad").ToString.Trim
           Me.cmbProvincia.Text = oProvincia.GetOne(CInt(Me.lblid_Provincia.Text)).Rows(0).Item("nombre_Provincia").ToString.Trim
       Catch ex As Exception
           '    MessageBox.Show(ex.Message)
       End Try

       If BanderaBanco  = 1 Then
           Me.LimpiarControles()
       End If
        Me.Text = "Banco" & vgNombreFormulario
       Me.CancelButton = Me.btnSalir
       Me.BackColor = Color.Gainsboro
       Me.StartPosition = FormStartPosition.CenterScreen
       Me.MinimizeBox = False
       Me.MaximizeBox = False
   End Sub

   Sub CargarCombos()
       Me.CargarCalle
       Me.CargarLocalidad
       Me.CargarProvincia
   End Sub

   Sub CargarCalle()
       Dim odt As New DataTable

       odt = oCalle.GetCmb
       With Me.cmbCalle
           .DataSource = odt
           .DisplayMember = "nombre_calle"
           .ValueMember = "id_calle"
       End With
       If Me.cmbCalle.SelectedIndex >= 0 Then
           cmbCalle.SelectedIndex = 0
           Me.lblid_Calle.Text = cmbCalle.SelectedValue.ToString
       End If
   End Sub

   Sub CargarLocalidad()
       Dim odt As New DataTable

       odt = oLocalidad.GetCmb
       With Me.cmbLocalidad
           .DataSource = odt
           .DisplayMember = "nombre_localidad"
           .ValueMember = "id_localidad"
       End With
       If Me.cmbLocalidad.SelectedIndex >= 0 Then
           cmbLocalidad.SelectedIndex = 0
           Me.lblid_Localidad.Text = cmbLocalidad.SelectedValue.ToString
       End If
   End Sub

   Sub CargarProvincia()
       Dim odt As New DataTable

       odt = oProvincia.GetCmb
       With Me.cmbProvincia
           .DataSource = odt
           .DisplayMember = "nombre_provincia"
           .ValueMember = "id_provincia"
       End With
       If Me.cmbProvincia.SelectedIndex >= 0 Then
           cmbProvincia.SelectedIndex = 0
           Me.lblid_Provincia.Text = cmbProvincia.SelectedValue.ToString
       End If
   End Sub

   Sub LimpiarControles()
       Me.txtnombre_banco.Text = ""
       Me.txtcuit_banco.Text = ""
       Me.txtdireccion.Text = ""
       Me.txttelefono.Text = ""
       Me.txtemail.Text = ""
       Me.txtpagina_web.Text = ""
       Me.txtnombre_fantasia.Text = ""
       Me.lblid_calle.Text = "0"
       Me.cmbCalle.Text =  ""
       Me.txtnumero.Text = ""
       Me.lblid_localidad.Text = "0"
       Me.cmbLocalidad.Text =  ""
       Me.lblid_provincia.Text = "0"
       Me.cmbProvincia.Text =  ""
       Me.txtiva.Text = ""
       Me.txtingreso_bruto.Text = ""
       Me.txtcontacto.Text = ""
   End Sub

   Private Sub ObtenerDatos()
       Me.txtnombre_banco.Text = oBanco.nombre_banco.Trim
       Me.txtcuit_banco.Text = oBanco.cuit_banco.Trim
       Me.txtdireccion.Text = oBanco.direccion.Trim
       Me.txttelefono.Text = oBanco.telefono.Trim
       Me.txtemail.Text = oBanco.email.Trim
       Me.txtpagina_web.Text = oBanco.pagina_web.Trim
       Me.txtnombre_fantasia.Text = oBanco.nombre_fantasia.Trim
       Me.lblid_calle.Text = oBanco.id_calle.ToString
       Me.txtnumero.Text = oBanco.numero.Trim
       Me.lblid_localidad.Text = oBanco.id_localidad.ToString
       Me.lblid_provincia.Text = oBanco.id_provincia.ToString
       Me.txtiva.Text = oBanco.iva.Trim
       Me.txtingreso_bruto.Text = oBanco.ingreso_bruto.Trim
       Me.txtcontacto.Text = oBanco.contacto.Trim
   End Sub

   Private Sub AsignarDatos()
       oBanco.nombre_banco = Me.txtnombre_banco.Text
       oBanco.cuit_banco = Me.txtcuit_banco.Text
       oBanco.direccion = Me.txtdireccion.Text
       oBanco.telefono = Me.txttelefono.Text
       oBanco.email = Me.txtemail.Text
       oBanco.pagina_web = Me.txtpagina_web.Text
       oBanco.nombre_fantasia = Me.txtnombre_fantasia.Text
       oBanco.id_calle = CInt(Me.lblid_calle.Text)
       oBanco.numero = Me.txtnumero.Text
       oBanco.id_localidad = CInt(Me.lblid_localidad.Text)
       oBanco.id_provincia = CInt(Me.lblid_provincia.Text)
       oBanco.iva = Me.txtiva.Text
       oBanco.ingreso_bruto = Me.txtingreso_bruto.Text
       oBanco.contacto = Me.txtcontacto.Text
   End Sub

   Public Sub SoloLectura()
       Me.txtnombre_banco.Enabled = False
       Me.txtcuit_banco.Enabled = False
       Me.txtdireccion.Enabled = False
       Me.txttelefono.Enabled = False
       Me.txtemail.Enabled = False
       Me.txtpagina_web.Enabled = False
       Me.txtnombre_fantasia.Enabled = False
       Me.cmbCalle.Enabled = False
       Me.btnBuscaCalle.Enabled = False
       Me.txtnumero.Enabled = False
       Me.cmbLocalidad.Enabled = False
       Me.btnBuscaLocalidad.Enabled = False
       Me.cmbProvincia.Enabled = False
       Me.btnBuscaProvincia.Enabled = False
       Me.txtiva.Enabled = False
       Me.txtingreso_bruto.Enabled = False
       Me.txtcontacto.Enabled = False
       Me.btnGuardar.Visible = False
   End Sub

   Private Sub Guardar()
       Try
           Me.AsignarDatos()
           If oBanco.Exist() Then
               If BanderaBanco = 1 Then
                   MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
               Exit Sub
               ElseIf BanderaBanco = 2 Then
                   If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                       = Windows.Forms.DialogResult.No Then
                       Exit Sub
                   End If
               End If
           End If
           Select Case BanderaBanco
               Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                   oBanco.Guardar()
                   CType(Me.Owner, frmAbmBanco).RefrescarGrilla()
                   Me.CargarCombos()
                   oBanco.Insertar()
                   Me.ObtenerDatos()
                   Me.LimpiarControles()
                   Me.txtnombre_banco.Focus
               Case 2 'GUARDA Y SALE (MODIFICAR)
                   oBanco.Guardar()
                   Me.Close()
           End Select
       Catch ex As Exception
           MessageBox.Show(ex.Message)
       End Try
   End Sub

   Private Function ChequearVacios() As Boolean
       Dim bandera As Boolean
       If Me.txtnombre_banco.Text = "" Then
           bandera = False
       Else
           bandera = True
       End If
       Return bandera
   End Function

   Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
       Dim blnVacios As Boolean

       If CDbl(Me.lblid_calle.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de calle")
           Exit Sub
       End If
       If CDbl(Me.lblid_localidad.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de localidad")
           Exit Sub
       End If
       If CDbl(Me.lblid_provincia.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de provincia")
           Exit Sub
       End If

       blnVacios = Me.ChequearVacios
       If blnVacios = False Then
           MessageBox.Show("Debe Llenar los Campos Obligatorios")
           Exit Sub
       Else
           If BanderaBanco  = 1 Then
               Me.Guardar()
           Else
               Me.Guardar()
           End If
       End If
   End Sub

   Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
       Me.Close()
   End Sub

   Private Sub cmbCalle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCalle.SelectedIndexChanged
       If Me.cmbCalle.SelectedIndex >= 0 Then
           Me.lblid_calle.Text = cmbCalle.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaCalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaCalle.Click
       Dim frmTemporal As New FrmAbmCalle
       frmTemporal.ShowDialog()
       Me.CargarCalle()
       Me.cmbCalle.Focus()
       Me.cmbCalle.Text = ""
       Me.lblid_Calle.Text = "0"
   End Sub

   Private Sub cmbLocalidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLocalidad.SelectedIndexChanged
       If Me.cmbLocalidad.SelectedIndex >= 0 Then
           Me.lblid_localidad.Text = cmbLocalidad.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaLocalidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaLocalidad.Click
       Dim frmTemporal As New FrmAbmLocalidad
       frmTemporal.ShowDialog()
       Me.CargarLocalidad()
       Me.cmbLocalidad.Focus()
       Me.cmbLocalidad.Text = ""
       Me.lblid_Localidad.Text = "0"
   End Sub

   Private Sub cmbProvincia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProvincia.SelectedIndexChanged
       If Me.cmbProvincia.SelectedIndex >= 0 Then
           Me.lblid_provincia.Text = cmbProvincia.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaProvincia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaProvincia.Click
       Dim frmTemporal As New FrmAbmProvincia
       frmTemporal.ShowDialog()
       Me.CargarProvincia()
       Me.cmbProvincia.Focus()
       Me.cmbProvincia.Text = ""
       Me.lblid_Provincia.Text = "0"
   End Sub

   Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtnombre_banco.KeyPress, txtcuit_banco.KeyPress, txtdireccion.KeyPress, txttelefono.KeyPress, txtemail.KeyPress, txtpagina_web.KeyPress, txtnombre_fantasia.KeyPress, txtnumero.KeyPress, txtiva.KeyPress, txtingreso_bruto.KeyPress, txtcontacto.KeyPress
       If e.KeyChar.ToString = vbCr Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
   Handles cmbCalle.KeyDown, cmbLocalidad.KeyDown, cmbProvincia.KeyDown
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
