Public Class frmDetalleActividad_proyecto

   Private Sub frmDetalleActividad_proyecto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnBuscaProyecto, "Buscar Nuevo Proyecto")
       Me.ttGeneral.SetToolTip(Me.btnBuscaActividad, "Buscar Nuevo Actividad")
       Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Actividad_proyecto")
       Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
       Try
           ObtenerDatos()

           Me.cmbProyecto.Text = oProyecto.GetOne(CInt(Me.lblid_Proyecto.Text)).Rows(0).Item("nombre_Proyecto").ToString.Trim
           Me.cmbActividad.Text = oActividad.GetOne(CInt(Me.lblid_Actividad.Text)).Rows(0).Item("nombre_Actividad").ToString.Trim
       Catch ex As Exception
           '    MessageBox.Show(ex.Message)
       End Try

       If BanderaActividad_proyecto  = 1 Then
           Me.LimpiarControles()
       End If
       Me.Text = "Actividad_proyecto"
       Me.CancelButton = Me.btnSalir
       Me.BackColor = Color.Gainsboro
       Me.StartPosition = FormStartPosition.CenterScreen
       Me.MinimizeBox = False
       Me.MaximizeBox = False
   End Sub

   Sub CargarCombos()
       Me.CargarProyecto
       Me.CargarActividad
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

   Sub LimpiarControles()
       Me.lblid_proyecto.Text = "0"
       Me.cmbProyecto.Text =  ""
       Me.lblid_actividad.Text = "0"
       Me.cmbActividad.Text =  ""
       Me.dtpfecha_inicio.Value = DateTime.Now
       Me.dtpfecha_fin_previsto.Value = DateTime.Now
       Me.dtpfecha_fin_real.Value = DateTime.Now
       Me.txtcantidad_hora.Text = ""
       Me.txtobjetivo.Text = ""
       Me.txtprioridad.Text = ""
       Me.txtcomplejidad.Text = ""
       Me.txtavance.Text = ""
       Me.txtobservacion.Text = ""
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
       If Me.txtcantidad_hora.Text = "" Then
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

   Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtobjetivo.KeyPress, txtobservacion.KeyPress
       If e.KeyChar.ToString = vbCr Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
   Handles cmbProyecto.KeyDown, cmbActividad.KeyDown, dtpfecha_inicio.KeyDown, dtpfecha_fin_previsto.KeyDown, dtpfecha_fin_real.KeyDown
       If CDbl(e.KeyValue.ToString) = 13 Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtcantidad_hora.KeyPress, txtprioridad.KeyPress, txtcomplejidad.KeyPress, txtavance.KeyPress
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
