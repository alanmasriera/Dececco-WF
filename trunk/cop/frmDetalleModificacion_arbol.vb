Public Class frmDetalleModificacion_arbol

   Private Sub frmDetalleModificacion_arbol_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnBuscaUsuario, "Buscar Nuevo Usuario")
       Me.ttGeneral.SetToolTip(Me.btnBuscaActividad, "Buscar Nuevo Actividad")
       Me.ttGeneral.SetToolTip(Me.btnBuscaProyecto, "Buscar Nuevo Proyecto")
       Me.ttGeneral.SetToolTip(Me.btnBuscaActividad_proyecto, "Buscar Nuevo Actividad_proyecto")
       Me.ttGeneral.SetToolTip(Me.btnBuscaUsuario_modificador, "Buscar Nuevo Usuario_modificador")
       Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Modificacion_arbol")
       Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
       Try
           ObtenerDatos()

           Me.cmbUsuario.Text = oUsuario.GetOne(CInt(Me.lblid_Usuario.Text)).Rows(0).Item("nombre Usuario").ToString.Trim
           Me.cmbActividad.Text = oActividad.GetOne(CInt(Me.lblid_Actividad.Text)).Rows(0).Item("nombre Actividad").ToString.Trim
           Me.cmbProyecto.Text = oProyecto.GetOne(CInt(Me.lblid_Proyecto.Text)).Rows(0).Item("nombre Proyecto").ToString.Trim
           Me.cmbActividad_proyecto.Text = oActividad_proyecto.GetOne(CInt(Me.lblid_Actividad_proyecto.Text)).Rows(0).Item("nombre Actividad_proyecto").ToString.Trim
           Me.cmbUsuario_modificador.Text = oUsuario_modificador.GetOne(CInt(Me.lblid_Usuario_modificador.Text)).Rows(0).Item("nombre Usuario_modificador").ToString.Trim
       Catch ex As Exception
           '    MessageBox.Show(ex.Message)
       End Try

       If BanderaModificacion_arbol  = 1 Then
           Me.LimpiarControles()
       End If
       Me.Text = "Modificacion_arbol" & vgNombreFormulario
       Me.CancelButton = Me.btnSalir
       Me.BackColor = Color.Gainsboro
       Me.StartPosition = FormStartPosition.CenterScreen
       Me.MinimizeBox = False
       Me.MaximizeBox = False
   End Sub

   Sub CargarCombos()
       Me.CargarUsuario
       Me.CargarActividad
       Me.CargarProyecto
       Me.CargarActividad_proyecto
       Me.CargarUsuario_modificador
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

   Sub CargarActividad()
       Dim odt As New DataTable

       odt = oActividad.GetCmb
       With Me.cmbActividad
           .DataSource = odt
           .DisplayMember = "nombre_actividad"
           .ValueMember = "id_actividad"
       End With
       If Me.cmbActividad.SelectedIndex >= 0 Then
           cmbActividad.SelectedIndex = 0
           Me.lblid_Actividad.Text = cmbActividad.SelectedValue.ToString
       End If
   End Sub

   Sub CargarProyecto()
       Dim odt As New DataTable

       odt = oProyecto.GetCmb
       With Me.cmbProyecto
           .DataSource = odt
           .DisplayMember = "nombre_proyecto"
           .ValueMember = "id_proyecto"
       End With
       If Me.cmbProyecto.SelectedIndex >= 0 Then
           cmbProyecto.SelectedIndex = 0
           Me.lblid_Proyecto.Text = cmbProyecto.SelectedValue.ToString
       End If
   End Sub

   Sub CargarActividad_proyecto()
       Dim odt As New DataTable

       odt = oActividad_proyecto.GetCmb
       With Me.cmbActividad_proyecto
           .DataSource = odt
           .DisplayMember = "nombre_actividad_proyecto"
           .ValueMember = "id_actividad_proyecto"
       End With
       If Me.cmbActividad_proyecto.SelectedIndex >= 0 Then
           cmbActividad_proyecto.SelectedIndex = 0
           Me.lblid_Actividad_proyecto.Text = cmbActividad_proyecto.SelectedValue.ToString
       End If
   End Sub

   Sub CargarUsuario_modificador()
       Dim odt As New DataTable

       odt = oUsuario_modificador.GetCmb
       With Me.cmbUsuario_modificador
           .DataSource = odt
           .DisplayMember = "nombre_usuario_modificador"
           .ValueMember = "id_usuario_modificador"
       End With
       If Me.cmbUsuario_modificador.SelectedIndex >= 0 Then
           cmbUsuario_modificador.SelectedIndex = 0
           Me.lblid_Usuario_modificador.Text = cmbUsuario_modificador.SelectedValue.ToString
       End If
   End Sub

   Sub LimpiarControles()
       Me.txtnombre_modificacion_arbol.Text = ""
       Me.lblid_usuario.Text = "0"
       Me.cmbUsuario.Text =  ""
       Me.chkrealizado.Checked = False
       Me.lblid_actividad.Text = "0"
       Me.cmbActividad.Text =  ""
       Me.lblid_proyecto.Text = "0"
       Me.cmbProyecto.Text =  ""
       Me.lblid_actividad_proyecto.Text = "0"
       Me.cmbActividad_proyecto.Text =  ""
       Me.txttipo_nodo.Text = ""
       Me.txtnodo.Text = "0"
       Me.txtnodo_padre.Text = "0"
       Me.txtnombre.Text = ""
       Me.lblid_usuario_modificador.Text = "0"
       Me.cmbUsuario_modificador.Text =  ""
   End Sub

   Private Sub ObtenerDatos()
       Me.txtnombre_modificacion_arbol.Text = oModificacion_arbol.nombre_modificacion_arbol.Trim
       Me.lblid_usuario.Text = oModificacion_arbol.id_usuario.ToString
       Me.chkrealizado.Checked = oModificacion_arbol.realizado
       Me.lblid_actividad.Text = oModificacion_arbol.id_actividad.ToString
       Me.lblid_proyecto.Text = oModificacion_arbol.id_proyecto.ToString
       Me.lblid_actividad_proyecto.Text = oModificacion_arbol.id_actividad_proyecto.ToString
       Me.txttipo_nodo.Text = oModificacion_arbol.tipo_nodo.Trim
       Me.txtnodo.Text = oModificacion_arbol.nodo.ToString.Trim
       Me.txtnodo_padre.Text = oModificacion_arbol.nodo_padre.ToString.Trim
       Me.txtnombre.Text = oModificacion_arbol.nombre.Trim
       Me.lblid_usuario_modificador.Text = oModificacion_arbol.id_usuario_modificador.ToString
   End Sub

   Private Sub AsignarDatos()
       oModificacion_arbol.nombre_modificacion_arbol = Me.txtnombre_modificacion_arbol.Text
       oModificacion_arbol.id_usuario = CInt(Me.lblid_usuario.Text)
       oModificacion_arbol.realizado = Me.chkrealizado.Checked
       oModificacion_arbol.id_actividad = CInt(Me.lblid_actividad.Text)
       oModificacion_arbol.id_proyecto = CInt(Me.lblid_proyecto.Text)
       oModificacion_arbol.id_actividad_proyecto = CInt(Me.lblid_actividad_proyecto.Text)
       oModificacion_arbol.tipo_nodo = Me.txttipo_nodo.Text
       oModificacion_arbol.nodo = CDec(Me.txtnodo.Text)
       oModificacion_arbol.nodo_padre = CDec(Me.txtnodo_padre.Text)
       oModificacion_arbol.nombre = Me.txtnombre.Text
       oModificacion_arbol.id_usuario_modificador = CInt(Me.lblid_usuario_modificador.Text)
   End Sub

   Public Sub SoloLectura()
       Me.txtnombre_modificacion_arbol.Enabled = False
       Me.cmbUsuario.Enabled = False
       Me.btnBuscaUsuario.Enabled = False
       Me.chkrealizado.Enabled = False
       Me.cmbActividad.Enabled = False
       Me.btnBuscaActividad.Enabled = False
       Me.cmbProyecto.Enabled = False
       Me.btnBuscaProyecto.Enabled = False
       Me.cmbActividad_proyecto.Enabled = False
       Me.btnBuscaActividad_proyecto.Enabled = False
       Me.txttipo_nodo.Enabled = False
       Me.txtnodo.Enabled = False
       Me.txtnodo_padre.Enabled = False
       Me.txtnombre.Enabled = False
       Me.cmbUsuario_modificador.Enabled = False
       Me.btnBuscaUsuario_modificador.Enabled = False
       Me.btnGuardar.Visible = False
   End Sub

   Private Sub Guardar()
       Try
           Me.AsignarDatos()
           If oModificacion_arbol.Exist() Then
               If BanderaModificacion_arbol = 1 Then
                   MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
               Exit Sub
               ElseIf BanderaModificacion_arbol = 2 Then
                   If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                       = Windows.Forms.DialogResult.No Then
                       Exit Sub
                   End If
               End If
           End If
           Select Case BanderaModificacion_arbol
               Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                   oModificacion_arbol.Guardar()
                   CType(Me.Owner, frmAbmModificacion_arbol).RefrescarGrilla()
                   Me.CargarCombos()
                   oModificacion_arbol.Insertar()
                   Me.ObtenerDatos()
                   Me.LimpiarControles()
                   Me.txtnombre_modificacion_arbol.Focus
               Case 2 'GUARDA Y SALE (MODIFICAR)
                   oModificacion_arbol.Guardar()
                   Me.Close()
           End Select
       Catch ex As Exception
           MessageBox.Show(ex.Message)
       End Try
   End Sub

   Private Function ChequearVacios() As Boolean
       Dim bandera As Boolean
       If _ 
       Me.txtnombre_modificacion_arbol.Text = "" or _
       Me.txttipo_nodo.Text = "" or _
       Me.txtnodo.Text = "" or _
       Me.txtnodo_padre.Text = "" or _
       Me.txtnombre.Text = "" Then
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
       If CDbl(Me.lblid_actividad.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de actividad")
           Exit Sub
       End If
       If CDbl(Me.lblid_proyecto.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de proyecto")
           Exit Sub
       End If
       If CDbl(Me.lblid_actividad_proyecto.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de actividad_proyecto")
           Exit Sub
       End If
       If CDbl(Me.lblid_usuario_modificador.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de usuario_modificador")
           Exit Sub
       End If

       blnVacios = Me.ChequearVacios
       If blnVacios = False Then
           MessageBox.Show("Debe Llenar los Campos Obligatorios")
           Exit Sub
       Else
           If BanderaModificacion_arbol  = 1 Then
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

   Private Sub cmbActividad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbActividad.SelectedIndexChanged
       If Me.cmbActividad.SelectedIndex >= 0 Then
           Me.lblid_actividad.Text = cmbActividad.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaActividad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaActividad.Click
       Dim frmTemporal As New FrmAbmActividad
       frmTemporal.ShowDialog()
       Me.CargarActividad()
       Me.cmbActividad.Focus()
       Me.cmbActividad.Text = ""
       Me.lblid_Actividad.Text = "0"
   End Sub

   Private Sub cmbProyecto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProyecto.SelectedIndexChanged
       If Me.cmbProyecto.SelectedIndex >= 0 Then
           Me.lblid_proyecto.Text = cmbProyecto.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaProyecto.Click
       Dim frmTemporal As New FrmAbmProyecto
       frmTemporal.ShowDialog()
       Me.CargarProyecto()
       Me.cmbProyecto.Focus()
       Me.cmbProyecto.Text = ""
       Me.lblid_Proyecto.Text = "0"
   End Sub

   Private Sub cmbActividad_proyecto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbActividad_proyecto.SelectedIndexChanged
       If Me.cmbActividad_proyecto.SelectedIndex >= 0 Then
           Me.lblid_actividad_proyecto.Text = cmbActividad_proyecto.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaActividad_proyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaActividad_proyecto.Click
       Dim frmTemporal As New FrmAbmActividad_proyecto
       frmTemporal.ShowDialog()
       Me.CargarActividad_proyecto()
       Me.cmbActividad_proyecto.Focus()
       Me.cmbActividad_proyecto.Text = ""
       Me.lblid_Actividad_proyecto.Text = "0"
   End Sub

   Private Sub cmbUsuario_modificador_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUsuario_modificador.SelectedIndexChanged
       If Me.cmbUsuario_modificador.SelectedIndex >= 0 Then
           Me.lblid_usuario_modificador.Text = cmbUsuario_modificador.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaUsuario_modificador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaUsuario_modificador.Click
       Dim frmTemporal As New FrmAbmUsuario_modificador
       frmTemporal.ShowDialog()
       Me.CargarUsuario_modificador()
       Me.cmbUsuario_modificador.Focus()
       Me.cmbUsuario_modificador.Text = ""
       Me.lblid_Usuario_modificador.Text = "0"
   End Sub

   Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtnombre_modificacion_arbol.KeyPress, chkrealizado.KeyPress, txttipo_nodo.KeyPress, txtnombre.KeyPress
       If e.KeyChar.ToString = vbCr Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
   Handles cmbUsuario.KeyDown, cmbActividad.KeyDown, cmbProyecto.KeyDown, cmbActividad_proyecto.KeyDown, cmbUsuario_modificador.KeyDown
       If CDbl(e.KeyValue.ToString) = 13 Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtnodo.KeyPress, txtnodo_padre.KeyPress
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
