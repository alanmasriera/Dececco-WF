Public Class frmDetalleActividad_proyecto

   Private Sub frmDetalleActividad_proyecto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnBuscaProyecto, "Buscar Nuevo Proyecto")
       Me.ttGeneral.SetToolTip(Me.btnBuscaActividad, "Buscar Nuevo Actividad")
       Me.ttGeneral.SetToolTip(Me.btnBuscaControlador_1, "Buscar Nuevo Controlador_1")
       Me.ttGeneral.SetToolTip(Me.btnBuscaControlador_2, "Buscar Nuevo Controlador_2")
       Me.ttGeneral.SetToolTip(Me.btnBusca, "Buscar Nuevo ")
       Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Actividad_proyecto")
       Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
       Try
           ObtenerDatos()

           Me.cmbProyecto.Text = oProyecto.GetOne(CInt(Me.lblid_Proyecto.Text)).Rows(0).Item("nombre Proyecto").ToString.Trim
           Me.cmbActividad.Text = oActividad.GetOne(CInt(Me.lblid_Actividad.Text)).Rows(0).Item("nombre Actividad").ToString.Trim
           Me.cmbControlador_1.Text = oControlador_1.GetOne(CInt(Me.lblid_Controlador_1.Text)).Rows(0).Item("nombre Controlador_1").ToString.Trim
           Me.cmbControlador_2.Text = oControlador_2.GetOne(CInt(Me.lblid_Controlador_2.Text)).Rows(0).Item("nombre Controlador_2").ToString.Trim
           Me.cmb.Text = o.GetOne(CInt(Me.lblid_.Text)).Rows(0).Item("nombre ").ToString.Trim
       Catch ex As Exception
           '    MessageBox.Show(ex.Message)
       End Try

       If BanderaActividad_proyecto  = 1 Then
           Me.LimpiarControles()
       End If
       Me.Text = "Actividad_proyecto" & vgNombreFormulario
       Me.CancelButton = Me.btnSalir
       Me.BackColor = Color.Gainsboro
       Me.StartPosition = FormStartPosition.CenterScreen
       Me.MinimizeBox = False
       Me.MaximizeBox = False
   End Sub

   Sub CargarCombos()
       Me.CargarProyecto
       Me.CargarActividad
       Me.CargarControlador_1
       Me.CargarControlador_2
       Me.Cargar
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

   Sub CargarControlador_1()
       Dim odt As New DataTable

       odt = oControlador_1.GetCmb
       With Me.cmbControlador_1
           .DataSource = odt
           .DisplayMember = "nombre_controlador_1"
           .ValueMember = "id_controlador_1"
       End With
       If Me.cmbControlador_1.SelectedIndex >= 0 Then
           cmbControlador_1.SelectedIndex = 0
           Me.lblid_Controlador_1.Text = cmbControlador_1.SelectedValue.ToString
       End If
   End Sub

   Sub CargarControlador_2()
       Dim odt As New DataTable

       odt = oControlador_2.GetCmb
       With Me.cmbControlador_2
           .DataSource = odt
           .DisplayMember = "nombre_controlador_2"
           .ValueMember = "id_controlador_2"
       End With
       If Me.cmbControlador_2.SelectedIndex >= 0 Then
           cmbControlador_2.SelectedIndex = 0
           Me.lblid_Controlador_2.Text = cmbControlador_2.SelectedValue.ToString
       End If
   End Sub

   Sub Cargar()
       Dim odt As New DataTable

       odt = o.GetCmb
       With Me.cmb
           .DataSource = odt
           .DisplayMember = "nombre_"
           .ValueMember = "id_"
       End With
       If Me.cmb.SelectedIndex >= 0 Then
           cmb.SelectedIndex = 0
           Me.lblid_.Text = cmb.SelectedValue.ToString
       End If
   End Sub

   Sub LimpiarControles()
       Me.lblid_proyecto.Text = "0"
       Me.cmbProyecto.Text =  ""
       Me.lblid_actividad.Text = "0"
       Me.cmbActividad.Text =  ""
       Me.dtpfecha_inicio.Value = DateTime.Now
       Me.dtpfecha_fin_previsto.Value = DateTime.Now
       Me.dtpfecha_fin_real.Value = DateTime.Now
       Me.txtcantidad_hora.Text = "0"
       Me.txtobjetivo.Text = ""
       Me.txtprioridad.Text = "0"
       Me.txtcomplejidad.Text = "0"
       Me.txtavance.Text = "0"
       Me.txtobservacion.Text = ""
       Me.txtorden.Text = "0"
       Me.lblid_controlador_1.Text = "0"
       Me.cmbControlador_1.Text =  ""
       Me.lblid_controlador_2.Text = "0"
       Me.cmbControlador_2.Text =  ""
       Me.lblnro.Text = "0"
       Me.cmb.Text =  ""
   End Sub

   Private Sub ObtenerDatos()
       Me.lblid_proyecto.Text = oActividad_proyecto.id_proyecto.ToString
       Me.lblid_actividad.Text = oActividad_proyecto.id_actividad.ToString
       Me.dtpfecha_inicio.Value = oActividad_proyecto.fecha_inicio
       Me.dtpfecha_fin_previsto.Value = oActividad_proyecto.fecha_fin_previsto
       Me.dtpfecha_fin_real.Value = oActividad_proyecto.fecha_fin_real
       Me.txtcantidad_hora.Text = oActividad_proyecto.cantidad_hora.ToString.Trim
       Me.txtobjetivo.Text = oActividad_proyecto.objetivo.Trim
       Me.txtprioridad.Text = oActividad_proyecto.prioridad.ToString.Trim
       Me.txtcomplejidad.Text = oActividad_proyecto.complejidad.ToString.Trim
       Me.txtavance.Text = oActividad_proyecto.avance.ToString.Trim
       Me.txtobservacion.Text = oActividad_proyecto.observacion.Trim
       Me.txtorden.Text = oActividad_proyecto.orden.ToString.Trim
       Me.lblid_controlador_1.Text = oActividad_proyecto.id_controlador_1.ToString
       Me.lblid_controlador_2.Text = oActividad_proyecto.id_controlador_2.ToString
       Me.lblnro.Text = oActividad_proyecto.nro.ToString
   End Sub

   Private Sub AsignarDatos()
       oActividad_proyecto.id_proyecto = CInt(Me.lblid_proyecto.Text)
       oActividad_proyecto.id_actividad = CInt(Me.lblid_actividad.Text)
       oActividad_proyecto.fecha_inicio = Me.dtpfecha_inicio.Value.Date
       oActividad_proyecto.fecha_fin_previsto = Me.dtpfecha_fin_previsto.Value.Date
       oActividad_proyecto.fecha_fin_real = Me.dtpfecha_fin_real.Value.Date
       oActividad_proyecto.cantidad_hora = CDec(Me.txtcantidad_hora.Text)
       oActividad_proyecto.objetivo = Me.txtobjetivo.Text
       oActividad_proyecto.prioridad = CDec(Me.txtprioridad.Text)
       oActividad_proyecto.complejidad = CDec(Me.txtcomplejidad.Text)
       oActividad_proyecto.avance = CDec(Me.txtavance.Text)
       oActividad_proyecto.observacion = Me.txtobservacion.Text
       oActividad_proyecto.orden = CDec(Me.txtorden.Text)
       oActividad_proyecto.id_controlador_1 = CInt(Me.lblid_controlador_1.Text)
       oActividad_proyecto.id_controlador_2 = CInt(Me.lblid_controlador_2.Text)
       oActividad_proyecto.nro = CInt(Me.lblnro.Text)
   End Sub

   Public Sub SoloLectura()
       Me.cmbProyecto.Enabled = False
       Me.btnBuscaProyecto.Enabled = False
       Me.cmbActividad.Enabled = False
       Me.btnBuscaActividad.Enabled = False
       Me.dtpfecha_inicio.Enabled = False
       Me.dtpfecha_fin_previsto.Enabled = False
       Me.dtpfecha_fin_real.Enabled = False
       Me.txtcantidad_hora.Enabled = False
       Me.txtobjetivo.Enabled = False
       Me.txtprioridad.Enabled = False
       Me.txtcomplejidad.Enabled = False
       Me.txtavance.Enabled = False
       Me.txtobservacion.Enabled = False
       Me.txtorden.Enabled = False
       Me.cmbControlador_1.Enabled = False
       Me.btnBuscaControlador_1.Enabled = False
       Me.cmbControlador_2.Enabled = False
       Me.btnBuscaControlador_2.Enabled = False
       Me.cmb.Enabled = False
       Me.btnBusca.Enabled = False
       Me.btnGuardar.Visible = False
   End Sub

   Private Sub Guardar()
       Try
           Me.AsignarDatos()
           If oActividad_proyecto.Exist() Then
               If BanderaActividad_proyecto = 1 Then
                   MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
               Exit Sub
               ElseIf BanderaActividad_proyecto = 2 Then
                   If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                       = Windows.Forms.DialogResult.No Then
                       Exit Sub
                   End If
               End If
           End If
           Select Case BanderaActividad_proyecto
               Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                   oActividad_proyecto.Guardar()
                   CType(Me.Owner, frmAbmActividad_proyecto).RefrescarGrilla()
                   Me.CargarCombos()
                   oActividad_proyecto.Insertar()
                   Me.ObtenerDatos()
                   Me.LimpiarControles()
                   Me.cmbProyecto.Focus
               Case 2 'GUARDA Y SALE (MODIFICAR)
                   oActividad_proyecto.Guardar()
                   Me.Close()
           End Select
       Catch ex As Exception
           MessageBox.Show(ex.Message)
       End Try
   End Sub

   Private Function ChequearVacios() As Boolean
       Dim bandera As Boolean
       If _ 
       Me.txtcantidad_hora.Text = "" or _
       Me.txtobjetivo.Text = "" or _
       Me.txtprioridad.Text = "" or _
       Me.txtcomplejidad.Text = "" or _
       Me.txtavance.Text = "" or _
       Me.txtobservacion.Text = "" or _
       Me.txtorden.Text = "" Then
           bandera = False
       Else
           bandera = True
       End If
       Return bandera
   End Function

   Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
       Dim blnVacios As Boolean

       If CDbl(Me.lblid_proyecto.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de proyecto")
           Exit Sub
       End If
       If CDbl(Me.lblid_actividad.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de actividad")
           Exit Sub
       End If
       If CDbl(Me.lblid_controlador_1.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de controlador_1")
           Exit Sub
       End If
       If CDbl(Me.lblid_controlador_2.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de controlador_2")
           Exit Sub
       End If
       If CDbl(Me.lblnro.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de ")
           Exit Sub
       End If

       blnVacios = Me.ChequearVacios
       If blnVacios = False Then
           MessageBox.Show("Debe Llenar los Campos Obligatorios")
           Exit Sub
       Else
           If BanderaActividad_proyecto  = 1 Then
               Me.Guardar()
           Else
               Me.Guardar()
           End If
       End If
   End Sub

   Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
       Me.Close()
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

   Private Sub cmbControlador_1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbControlador_1.SelectedIndexChanged
       If Me.cmbControlador_1.SelectedIndex >= 0 Then
           Me.lblid_controlador_1.Text = cmbControlador_1.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaControlador_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaControlador_1.Click
       Dim frmTemporal As New FrmAbmControlador_1
       frmTemporal.ShowDialog()
       Me.CargarControlador_1()
       Me.cmbControlador_1.Focus()
       Me.cmbControlador_1.Text = ""
       Me.lblid_Controlador_1.Text = "0"
   End Sub

   Private Sub cmbControlador_2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbControlador_2.SelectedIndexChanged
       If Me.cmbControlador_2.SelectedIndex >= 0 Then
           Me.lblid_controlador_2.Text = cmbControlador_2.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaControlador_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaControlador_2.Click
       Dim frmTemporal As New FrmAbmControlador_2
       frmTemporal.ShowDialog()
       Me.CargarControlador_2()
       Me.cmbControlador_2.Focus()
       Me.cmbControlador_2.Text = ""
       Me.lblid_Controlador_2.Text = "0"
   End Sub

   Private Sub cmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb.SelectedIndexChanged
       If Me.cmb.SelectedIndex >= 0 Then
           Me.lblnro.Text = cmb.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBusca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusca.Click
       Dim frmTemporal As New FrmAbm
       frmTemporal.ShowDialog()
       Me.Cargar()
       Me.cmb.Focus()
       Me.cmb.Text = ""
       Me.lblid_.Text = "0"
   End Sub

   Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtobjetivo.KeyPress, txtobservacion.KeyPress
       If e.KeyChar.ToString = vbCr Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
   Handles cmbProyecto.KeyDown, cmbActividad.KeyDown, dtpfecha_inicio.KeyDown, dtpfecha_fin_previsto.KeyDown, dtpfecha_fin_real.KeyDown, cmbControlador_1.KeyDown, cmbControlador_2.KeyDown, cmb.KeyDown
       If CDbl(e.KeyValue.ToString) = 13 Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtcantidad_hora.KeyPress, txtprioridad.KeyPress, txtcomplejidad.KeyPress, txtavance.KeyPress, txtorden.KeyPress
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
