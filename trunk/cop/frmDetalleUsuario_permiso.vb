Public Class frmDetalleUsuario_permiso

   Private Sub frmDetalleUsuario_permiso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnBuscaUsuario, "Buscar Nuevo Usuario")
       Me.ttGeneral.SetToolTip(Me.btnBuscaPermiso, "Buscar Nuevo Permiso")
       Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Usuario_permiso")
       Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
       Try
           ObtenerDatos()

           Me.cmbUsuario.Text = oUsuario.GetOne(CInt(Me.lblid_Usuario.Text)).Rows(0).Item("nombre Usuario").ToString.Trim
           Me.cmbPermiso.Text = oPermiso.GetOne(CInt(Me.lblid_Permiso.Text)).Rows(0).Item("nombre Permiso").ToString.Trim
       Catch ex As Exception
           '    MessageBox.Show(ex.Message)
       End Try

       If BanderaUsuario_permiso  = 1 Then
           Me.LimpiarControles()
       End If
       Me.Text = "Usuario_permiso" & vgNombreFormulario
       Me.CancelButton = Me.btnSalir
       Me.BackColor = Color.Gainsboro
       Me.StartPosition = FormStartPosition.CenterScreen
       Me.MinimizeBox = False
       Me.MaximizeBox = False
   End Sub

   Sub CargarCombos()
       Me.CargarUsuario
       Me.CargarPermiso
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

   Sub CargarPermiso()
       Dim odt As New DataTable

       odt = oPermiso.GetCmb
       With Me.cmbPermiso
           .DataSource = odt
           .DisplayMember = "nombre_permiso"
           .ValueMember = "id_permiso"
       End With
       If Me.cmbPermiso.SelectedIndex >= 0 Then
           cmbPermiso.SelectedIndex = 0
           Me.lblid_Permiso.Text = cmbPermiso.SelectedValue.ToString
       End If
   End Sub

   Sub LimpiarControles()
       Me.lblid_usuario.Text = "0"
       Me.cmbUsuario.Text =  ""
       Me.lblid_permiso.Text = "0"
       Me.cmbPermiso.Text =  ""
       Me.chkhabilitado.Checked = False
   End Sub

   Private Sub ObtenerDatos()
       Me.lblid_usuario.Text = oUsuario_permiso.id_usuario.ToString
       Me.lblid_permiso.Text = oUsuario_permiso.id_permiso.ToString
       Me.chkhabilitado.Checked = oUsuario_permiso.habilitado
   End Sub

   Private Sub AsignarDatos()
       oUsuario_permiso.id_usuario = CInt(Me.lblid_usuario.Text)
       oUsuario_permiso.id_permiso = CInt(Me.lblid_permiso.Text)
       oUsuario_permiso.habilitado = Me.chkhabilitado.Checked
   End Sub

   Public Sub SoloLectura()
       Me.cmbUsuario.Enabled = False
       Me.btnBuscaUsuario.Enabled = False
       Me.cmbPermiso.Enabled = False
       Me.btnBuscaPermiso.Enabled = False
       Me.chkhabilitado.Enabled = False
       Me.btnGuardar.Visible = False
   End Sub

   Private Sub Guardar()
       Try
           Me.AsignarDatos()
           If oUsuario_permiso.Exist() Then
               If BanderaUsuario_permiso = 1 Then
                   MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
               Exit Sub
               ElseIf BanderaUsuario_permiso = 2 Then
                   If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                       = Windows.Forms.DialogResult.No Then
                       Exit Sub
                   End If
               End If
           End If
           Select Case BanderaUsuario_permiso
               Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                   oUsuario_permiso.Guardar()
                   CType(Me.Owner, frmAbmUsuario_permiso).RefrescarGrilla()
                   Me.CargarCombos()
                   oUsuario_permiso.Insertar()
                   Me.ObtenerDatos()
                   Me.LimpiarControles()
                   Me.cmbUsuario.Focus
               Case 2 'GUARDA Y SALE (MODIFICAR)
                   oUsuario_permiso.Guardar()
                   Me.Close()
           End Select
       Catch ex As Exception
           MessageBox.Show(ex.Message)
       End Try
   End Sub

   Private Function ChequearVacios() As Boolean
       Dim bandera As Boolean
       If _ 
           bandera = False
       Else
           bandera = True
       End If
       Return bandera
   End Function

   Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
       Dim blnVacios As Boolean

       If CDbl(Me.lblid_usuario.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de usuario")
           Exit Sub
       End If
       If CDbl(Me.lblid_permiso.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de permiso")
           Exit Sub
       End If

       blnVacios = Me.ChequearVacios
       If blnVacios = False Then
           MessageBox.Show("Debe Llenar los Campos Obligatorios")
           Exit Sub
       Else
           If BanderaUsuario_permiso  = 1 Then
               Me.Guardar()
           Else
               Me.Guardar()
           End If
       End If
   End Sub

   Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
       Me.Close()
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

   Private Sub cmbPermiso_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPermiso.SelectedIndexChanged
       If Me.cmbPermiso.SelectedIndex >= 0 Then
           Me.lblid_permiso.Text = cmbPermiso.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaPermiso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaPermiso.Click
       Dim frmTemporal As New FrmAbmPermiso
       frmTemporal.ShowDialog()
       Me.CargarPermiso()
       Me.cmbPermiso.Focus()
       Me.cmbPermiso.Text = ""
       Me.lblid_Permiso.Text = "0"
   End Sub

   Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles chkhabilitado.KeyPress
       If e.KeyChar.ToString = vbCr Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
   Handles cmbUsuario.KeyDown, cmbPermiso.KeyDown
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
