Public Class frmDetalleProyecto

   Private Sub frmDetalleProyecto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnBuscaCliente, "Buscar Nuevo Cliente")
       Me.ttGeneral.SetToolTip(Me.btnBuscaProyecto_padre, "Buscar Nuevo Proyecto_padre")
       Me.ttGeneral.SetToolTip(Me.btnBuscaProyect_manager, "Buscar Nuevo Proyect_manager")
       Me.ttGeneral.SetToolTip(Me.btnBuscaEstado, "Buscar Nuevo Estado")
       Me.ttGeneral.SetToolTip(Me.btnBuscaControlador_1, "Buscar Nuevo Controlador_1")
       Me.ttGeneral.SetToolTip(Me.btnBuscaControlador_2, "Buscar Nuevo Controlador_2")
       Me.ttGeneral.SetToolTip(Me.btnBuscaIce, "Buscar Nuevo Ice")
       Me.ttGeneral.SetToolTip(Me.btnBusca, "Buscar Nuevo ")
       Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Proyecto")
       Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
       Try
           ObtenerDatos()

           Me.cmbCliente.Text = oCliente.GetOne(CInt(Me.lblid_Cliente.Text)).Rows(0).Item("nombre Cliente").ToString.Trim
           Me.cmbProyecto_padre.Text = oProyecto_padre.GetOne(CInt(Me.lblid_Proyecto_padre.Text)).Rows(0).Item("nombre Proyecto_padre").ToString.Trim
           Me.cmbProyect_manager.Text = oProyect_manager.GetOne(CInt(Me.lblid_Proyect_manager.Text)).Rows(0).Item("nombre Proyect_manager").ToString.Trim
           Me.cmbEstado.Text = oEstado.GetOne(CInt(Me.lblid_Estado.Text)).Rows(0).Item("nombre Estado").ToString.Trim
           Me.cmbControlador_1.Text = oControlador_1.GetOne(CInt(Me.lblid_Controlador_1.Text)).Rows(0).Item("nombre Controlador_1").ToString.Trim
           Me.cmbControlador_2.Text = oControlador_2.GetOne(CInt(Me.lblid_Controlador_2.Text)).Rows(0).Item("nombre Controlador_2").ToString.Trim
           Me.cmbIce.Text = oIce.GetOne(CInt(Me.lblid_Ice.Text)).Rows(0).Item("nombre Ice").ToString.Trim
           Me.cmb.Text = o.GetOne(CInt(Me.lblid_.Text)).Rows(0).Item("nombre ").ToString.Trim
       Catch ex As Exception
           '    MessageBox.Show(ex.Message)
       End Try

       If BanderaProyecto  = 1 Then
           Me.LimpiarControles()
       End If
       Me.Text = "Proyecto" & vgNombreFormulario
       Me.CancelButton = Me.btnSalir
       Me.BackColor = Color.Gainsboro
       Me.StartPosition = FormStartPosition.CenterScreen
       Me.MinimizeBox = False
       Me.MaximizeBox = False
   End Sub

   Sub CargarCombos()
       Me.CargarCliente
       Me.CargarProyecto_padre
       Me.CargarProyect_manager
       Me.CargarEstado
       Me.CargarControlador_1
       Me.CargarControlador_2
       Me.CargarIce
       Me.Cargar
   End Sub

   Sub CargarCliente()
       Dim odt As New DataTable

       odt = oCliente.GetCmb
       With Me.cmbCliente
           .DataSource = odt
           .DisplayMember = "nombre_cliente"
           .ValueMember = "id_cliente"
       End With
       If Me.cmbCliente.SelectedIndex >= 0 Then
           cmbCliente.SelectedIndex = 0
           Me.lblid_Cliente.Text = cmbCliente.SelectedValue.ToString
       End If
   End Sub

   Sub CargarProyecto_padre()
       Dim odt As New DataTable

       odt = oProyecto_padre.GetCmb
       With Me.cmbProyecto_padre
           .DataSource = odt
           .DisplayMember = "nombre_proyecto_padre"
           .ValueMember = "id_proyecto_padre"
       End With
       If Me.cmbProyecto_padre.SelectedIndex >= 0 Then
           cmbProyecto_padre.SelectedIndex = 0
           Me.lblid_Proyecto_padre.Text = cmbProyecto_padre.SelectedValue.ToString
       End If
   End Sub

   Sub CargarProyect_manager()
       Dim odt As New DataTable

       odt = oProyect_manager.GetCmb
       With Me.cmbProyect_manager
           .DataSource = odt
           .DisplayMember = "nombre_proyect_manager"
           .ValueMember = "id_proyect_manager"
       End With
       If Me.cmbProyect_manager.SelectedIndex >= 0 Then
           cmbProyect_manager.SelectedIndex = 0
           Me.lblid_Proyect_manager.Text = cmbProyect_manager.SelectedValue.ToString
       End If
   End Sub

   Sub CargarEstado()
       Dim odt As New DataTable

       odt = oEstado.GetCmb
       With Me.cmbEstado
           .DataSource = odt
           .DisplayMember = "nombre_estado"
           .ValueMember = "id_estado"
       End With
       If Me.cmbEstado.SelectedIndex >= 0 Then
           cmbEstado.SelectedIndex = 0
           Me.lblid_Estado.Text = cmbEstado.SelectedValue.ToString
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

   Sub CargarIce()
       Dim odt As New DataTable

       odt = oIce.GetCmb
       With Me.cmbIce
           .DataSource = odt
           .DisplayMember = "nombre_ice"
           .ValueMember = "id_ice"
       End With
       If Me.cmbIce.SelectedIndex >= 0 Then
           cmbIce.SelectedIndex = 0
           Me.lblid_Ice.Text = cmbIce.SelectedValue.ToString
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
       Me.txtdescripcion.Text = ""
       Me.txtnombre_proyecto.Text = ""
       Me.lblid_cliente.Text = "0"
       Me.cmbCliente.Text =  ""
       Me.lblid_proyecto_padre.Text = "0"
       Me.cmbProyecto_padre.Text =  ""
       Me.lblid_proyect_manager.Text = "0"
       Me.cmbProyect_manager.Text =  ""
       Me.dtpfecha_inicio.Value = DateTime.Now
       Me.dtpfecha_fin_prevista.Value = DateTime.Now
       Me.dtpfecha_fin_real.Value = DateTime.Now
       Me.txtorden.Text = ""
       Me.lblid_estado.Text = "0"
       Me.cmbEstado.Text =  ""
       Me.txttotal_hora.Text = "0"
       Me.txtprioridad.Text = "0"
       Me.txtobservacion.Text = ""
       Me.lblid_controlador_1.Text = "0"
       Me.cmbControlador_1.Text =  ""
       Me.lblid_controlador_2.Text = "0"
       Me.cmbControlador_2.Text =  ""
       Me.txtpath.Text = ""
       Me.chkarchivado.Checked = False
       Me.lblindice.Text = "0"
       Me.cmbIce.Text =  ""
       Me.lblnro.Text = "0"
       Me.cmb.Text =  ""
   End Sub

   Private Sub ObtenerDatos()
       Me.txtdescripcion.Text = oProyecto.descripcion.Trim
       Me.txtnombre_proyecto.Text = oProyecto.nombre_proyecto.Trim
       Me.lblid_cliente.Text = oProyecto.id_cliente.ToString
       Me.lblid_proyecto_padre.Text = oProyecto.id_proyecto_padre.ToString
       Me.lblid_proyect_manager.Text = oProyecto.id_proyect_manager.ToString
       Me.dtpfecha_inicio.Value = oProyecto.fecha_inicio
       Me.dtpfecha_fin_prevista.Value = oProyecto.fecha_fin_prevista
       Me.dtpfecha_fin_real.Value = oProyecto.fecha_fin_real
       Me.txtorden.Text = oProyecto.orden.Trim
       Me.lblid_estado.Text = oProyecto.id_estado.ToString
       Me.txttotal_hora.Text = oProyecto.total_hora.ToString.Trim
       Me.txtprioridad.Text = oProyecto.prioridad.ToString.Trim
       Me.txtobservacion.Text = oProyecto.observacion.Trim
       Me.lblid_controlador_1.Text = oProyecto.id_controlador_1.ToString
       Me.lblid_controlador_2.Text = oProyecto.id_controlador_2.ToString
       Me.txtpath.Text = oProyecto.path.Trim
       Me.chkarchivado.Checked = oProyecto.archivado
       Me.lblindice.Text = oProyecto.indice.ToString
       Me.lblnro.Text = oProyecto.nro.ToString
   End Sub

   Private Sub AsignarDatos()
       oProyecto.descripcion = Me.txtdescripcion.Text
       oProyecto.nombre_proyecto = Me.txtnombre_proyecto.Text
       oProyecto.id_cliente = CInt(Me.lblid_cliente.Text)
       oProyecto.id_proyecto_padre = CInt(Me.lblid_proyecto_padre.Text)
       oProyecto.id_proyect_manager = CInt(Me.lblid_proyect_manager.Text)
       oProyecto.fecha_inicio = Me.dtpfecha_inicio.Value.Date
       oProyecto.fecha_fin_prevista = Me.dtpfecha_fin_prevista.Value.Date
       oProyecto.fecha_fin_real = Me.dtpfecha_fin_real.Value.Date
       oProyecto.orden = Me.txtorden.Text
       oProyecto.id_estado = CInt(Me.lblid_estado.Text)
       oProyecto.total_hora = CDec(Me.txttotal_hora.Text)
       oProyecto.prioridad = CDec(Me.txtprioridad.Text)
       oProyecto.observacion = Me.txtobservacion.Text
       oProyecto.id_controlador_1 = CInt(Me.lblid_controlador_1.Text)
       oProyecto.id_controlador_2 = CInt(Me.lblid_controlador_2.Text)
       oProyecto.path = Me.txtpath.Text
       oProyecto.archivado = Me.chkarchivado.Checked
       oProyecto.indice = CInt(Me.lblindice.Text)
       oProyecto.nro = CInt(Me.lblnro.Text)
   End Sub

   Public Sub SoloLectura()
       Me.txtdescripcion.Enabled = False
       Me.txtnombre_proyecto.Enabled = False
       Me.cmbCliente.Enabled = False
       Me.btnBuscaCliente.Enabled = False
       Me.cmbProyecto_padre.Enabled = False
       Me.btnBuscaProyecto_padre.Enabled = False
       Me.cmbProyect_manager.Enabled = False
       Me.btnBuscaProyect_manager.Enabled = False
       Me.dtpfecha_inicio.Enabled = False
       Me.dtpfecha_fin_prevista.Enabled = False
       Me.dtpfecha_fin_real.Enabled = False
       Me.txtorden.Enabled = False
       Me.cmbEstado.Enabled = False
       Me.btnBuscaEstado.Enabled = False
       Me.txttotal_hora.Enabled = False
       Me.txtprioridad.Enabled = False
       Me.txtobservacion.Enabled = False
       Me.cmbControlador_1.Enabled = False
       Me.btnBuscaControlador_1.Enabled = False
       Me.cmbControlador_2.Enabled = False
       Me.btnBuscaControlador_2.Enabled = False
       Me.txtpath.Enabled = False
       Me.chkarchivado.Enabled = False
       Me.cmbIce.Enabled = False
       Me.btnBuscaIce.Enabled = False
       Me.cmb.Enabled = False
       Me.btnBusca.Enabled = False
       Me.btnGuardar.Visible = False
   End Sub

   Private Sub Guardar()
       Try
           Me.AsignarDatos()
           If oProyecto.Exist() Then
               If BanderaProyecto = 1 Then
                   MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
               Exit Sub
               ElseIf BanderaProyecto = 2 Then
                   If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                       = Windows.Forms.DialogResult.No Then
                       Exit Sub
                   End If
               End If
           End If
           Select Case BanderaProyecto
               Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                   oProyecto.Guardar()
                   CType(Me.Owner, frmAbmProyecto).RefrescarGrilla()
                   Me.CargarCombos()
                   oProyecto.Insertar()
                   Me.ObtenerDatos()
                   Me.LimpiarControles()
                   Me.txtdescripcion.Focus
               Case 2 'GUARDA Y SALE (MODIFICAR)
                   oProyecto.Guardar()
                   Me.Close()
           End Select
       Catch ex As Exception
           MessageBox.Show(ex.Message)
       End Try
   End Sub

   Private Function ChequearVacios() As Boolean
       Dim bandera As Boolean
       If _ 
       Me.txtdescripcion.Text = "" or _
       Me.txtnombre_proyecto.Text = "" or _
       Me.txtorden.Text = "" or _
       Me.txttotal_hora.Text = "" or _
       Me.txtprioridad.Text = "" or _
       Me.txtobservacion.Text = "" or _
       Me.txtpath.Text = "" Then
           bandera = False
       Else
           bandera = True
       End If
       Return bandera
   End Function

   Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
       Dim blnVacios As Boolean

       If CDbl(Me.lblid_cliente.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de cliente")
           Exit Sub
       End If
       If CDbl(Me.lblid_proyecto_padre.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de proyecto_padre")
           Exit Sub
       End If
       If CDbl(Me.lblid_proyect_manager.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de proyect_manager")
           Exit Sub
       End If
       If CDbl(Me.lblid_estado.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de estado")
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
       If CDbl(Me.lblindice.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de ice")
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
           If BanderaProyecto  = 1 Then
               Me.Guardar()
           Else
               Me.Guardar()
           End If
       End If
   End Sub

   Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
       Me.Close()
   End Sub

   Private Sub cmbCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCliente.SelectedIndexChanged
       If Me.cmbCliente.SelectedIndex >= 0 Then
           Me.lblid_cliente.Text = cmbCliente.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaCliente.Click
       Dim frmTemporal As New FrmAbmCliente
       frmTemporal.ShowDialog()
       Me.CargarCliente()
       Me.cmbCliente.Focus()
       Me.cmbCliente.Text = ""
       Me.lblid_Cliente.Text = "0"
   End Sub

   Private Sub cmbProyecto_padre_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProyecto_padre.SelectedIndexChanged
       If Me.cmbProyecto_padre.SelectedIndex >= 0 Then
           Me.lblid_proyecto_padre.Text = cmbProyecto_padre.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaProyecto_padre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaProyecto_padre.Click
       Dim frmTemporal As New FrmAbmProyecto_padre
       frmTemporal.ShowDialog()
       Me.CargarProyecto_padre()
       Me.cmbProyecto_padre.Focus()
       Me.cmbProyecto_padre.Text = ""
       Me.lblid_Proyecto_padre.Text = "0"
   End Sub

   Private Sub cmbProyect_manager_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProyect_manager.SelectedIndexChanged
       If Me.cmbProyect_manager.SelectedIndex >= 0 Then
           Me.lblid_proyect_manager.Text = cmbProyect_manager.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaProyect_manager_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaProyect_manager.Click
       Dim frmTemporal As New FrmAbmProyect_manager
       frmTemporal.ShowDialog()
       Me.CargarProyect_manager()
       Me.cmbProyect_manager.Focus()
       Me.cmbProyect_manager.Text = ""
       Me.lblid_Proyect_manager.Text = "0"
   End Sub

   Private Sub cmbEstado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEstado.SelectedIndexChanged
       If Me.cmbEstado.SelectedIndex >= 0 Then
           Me.lblid_estado.Text = cmbEstado.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaEstado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaEstado.Click
       Dim frmTemporal As New FrmAbmEstado
       frmTemporal.ShowDialog()
       Me.CargarEstado()
       Me.cmbEstado.Focus()
       Me.cmbEstado.Text = ""
       Me.lblid_Estado.Text = "0"
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

   Private Sub cmbIce_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbIce.SelectedIndexChanged
       If Me.cmbIce.SelectedIndex >= 0 Then
           Me.lblindice.Text = cmbIce.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaIce_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaIce.Click
       Dim frmTemporal As New FrmAbmIce
       frmTemporal.ShowDialog()
       Me.CargarIce()
       Me.cmbIce.Focus()
       Me.cmbIce.Text = ""
       Me.lblid_Ice.Text = "0"
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
   Handles txtdescripcion.KeyPress, txtnombre_proyecto.KeyPress, txtorden.KeyPress, txtobservacion.KeyPress, txtpath.KeyPress, chkarchivado.KeyPress
       If e.KeyChar.ToString = vbCr Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
   Handles cmbCliente.KeyDown, cmbProyecto_padre.KeyDown, cmbProyect_manager.KeyDown, dtpfecha_inicio.KeyDown, dtpfecha_fin_prevista.KeyDown, dtpfecha_fin_real.KeyDown, cmbEstado.KeyDown, cmbControlador_1.KeyDown, cmbControlador_2.KeyDown, cmbIce.KeyDown, cmb.KeyDown
       If CDbl(e.KeyValue.ToString) = 13 Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txttotal_hora.KeyPress, txtprioridad.KeyPress
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
