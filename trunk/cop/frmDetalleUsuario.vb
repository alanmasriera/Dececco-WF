Public Class frmDetalleUsuario

   Private Sub frmDetalleUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnBuscaGrupo_usuario, "Buscar Nuevo Grupo_usuario")
       Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Usuario")
       Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
       Try
           ObtenerDatos()

           Me.cmbGrupo_usuario.Text = oGrupo_usuario.GetOne(CInt(Me.lblid_Grupo_usuario.Text)).Rows(0).Item("nombre Grupo_usuario").ToString.Trim
       Catch ex As Exception
           '    MessageBox.Show(ex.Message)
       End Try

       If BanderaUsuario  = 1 Then
           Me.LimpiarControles()
       End If
       Me.Text = "Usuario" & vgNombreFormulario
       Me.CancelButton = Me.btnSalir
       Me.BackColor = Color.Gainsboro
       Me.StartPosition = FormStartPosition.CenterScreen
       Me.MinimizeBox = False
       Me.MaximizeBox = False
   End Sub

   Sub CargarCombos()
       Me.CargarGrupo_usuario
   End Sub

   Sub CargarGrupo_usuario()
       Dim odt As New DataTable

       odt = oGrupo_usuario.GetCmb
       With Me.cmbGrupo_usuario
           .DataSource = odt
           .DisplayMember = "nombre_grupo_usuario"
           .ValueMember = "id_grupo_usuario"
       End With
       If Me.cmbGrupo_usuario.SelectedIndex >= 0 Then
           cmbGrupo_usuario.SelectedIndex = 0
           Me.lblid_Grupo_usuario.Text = cmbGrupo_usuario.SelectedValue.ToString
       End If
   End Sub

   Sub LimpiarControles()
       Me.txtnombre_usuario.Text = ""
       Me.txtpassword_usuario.Text = ""
       Me.lblid_grupo_usuario.Text = "0"
       Me.cmbGrupo_usuario.Text =  ""
       Me.txtlegajo.Text = ""
       Me.txtapellido.Text = ""
       Me.txtnombre.Text = ""
       Me.dtpsession_activa.Value = DateTime.Now
   End Sub

   Private Sub ObtenerDatos()
       Me.txtnombre_usuario.Text = oUsuario.nombre_usuario.Trim
       Me.txtpassword_usuario.Text = oUsuario.password_usuario.Trim
       Me.lblid_grupo_usuario.Text = oUsuario.id_grupo_usuario.ToString
       Me.txtlegajo.Text = oUsuario.legajo.Trim
       Me.txtapellido.Text = oUsuario.apellido.Trim
       Me.txtnombre.Text = oUsuario.nombre.Trim
       Me.dtpsession_activa.Value = oUsuario.session_activa
   End Sub

   Private Sub AsignarDatos()
       oUsuario.nombre_usuario = Me.txtnombre_usuario.Text
       oUsuario.password_usuario = Me.txtpassword_usuario.Text
       oUsuario.id_grupo_usuario = CInt(Me.lblid_grupo_usuario.Text)
       oUsuario.legajo = Me.txtlegajo.Text
       oUsuario.apellido = Me.txtapellido.Text
       oUsuario.nombre = Me.txtnombre.Text
       oUsuario.session_activa = Me.dtpsession_activa.Value.Date
   End Sub

   Public Sub SoloLectura()
       Me.txtnombre_usuario.Enabled = False
       Me.txtpassword_usuario.Enabled = False
       Me.cmbGrupo_usuario.Enabled = False
       Me.btnBuscaGrupo_usuario.Enabled = False
       Me.txtlegajo.Enabled = False
       Me.txtapellido.Enabled = False
       Me.txtnombre.Enabled = False
       Me.dtpsession_activa.Enabled = False
       Me.btnGuardar.Visible = False
   End Sub

   Private Sub Guardar()
       Try
           Me.AsignarDatos()
           If oUsuario.Exist() Then
               If BanderaUsuario = 1 Then
                   MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
               Exit Sub
               ElseIf BanderaUsuario = 2 Then
                   If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                       = Windows.Forms.DialogResult.No Then
                       Exit Sub
                   End If
               End If
           End If
           Select Case BanderaUsuario
               Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                   oUsuario.Guardar()
                   CType(Me.Owner, frmAbmUsuario).RefrescarGrilla()
                   Me.CargarCombos()
                   oUsuario.Insertar()
                   Me.ObtenerDatos()
                   Me.LimpiarControles()
                   Me.txtnombre_usuario.Focus
               Case 2 'GUARDA Y SALE (MODIFICAR)
                   oUsuario.Guardar()
                   Me.Close()
           End Select
       Catch ex As Exception
           MessageBox.Show(ex.Message)
       End Try
   End Sub

   Private Function ChequearVacios() As Boolean
       Dim bandera As Boolean
       If _ 
       Me.txtnombre_usuario.Text = "" or _
       Me.txtpassword_usuario.Text = "" or _
       Me.txtlegajo.Text = "" or _
       Me.txtapellido.Text = "" or _
       Me.txtnombre.Text = "" Then
           bandera = False
       Else
           bandera = True
       End If
       Return bandera
   End Function

   Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
       Dim blnVacios As Boolean

       If CDbl(Me.lblid_grupo_usuario.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de grupo_usuario")
           Exit Sub
       End If

       blnVacios = Me.ChequearVacios
       If blnVacios = False Then
           MessageBox.Show("Debe Llenar los Campos Obligatorios")
           Exit Sub
       Else
           If BanderaUsuario  = 1 Then
               Me.Guardar()
           Else
               Me.Guardar()
           End If
       End If
   End Sub

   Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
       Me.Close()
   End Sub

   Private Sub cmbGrupo_usuario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGrupo_usuario.SelectedIndexChanged
       If Me.cmbGrupo_usuario.SelectedIndex >= 0 Then
           Me.lblid_grupo_usuario.Text = cmbGrupo_usuario.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaGrupo_usuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaGrupo_usuario.Click
       Dim frmTemporal As New FrmAbmGrupo_usuario
       frmTemporal.ShowDialog()
       Me.CargarGrupo_usuario()
       Me.cmbGrupo_usuario.Focus()
       Me.cmbGrupo_usuario.Text = ""
       Me.lblid_Grupo_usuario.Text = "0"
   End Sub

   Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtnombre_usuario.KeyPress, txtpassword_usuario.KeyPress, txtlegajo.KeyPress, txtapellido.KeyPress, txtnombre.KeyPress
       If e.KeyChar.ToString = vbCr Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
   Handles cmbGrupo_usuario.KeyDown, dtpsession_activa.KeyDown
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
