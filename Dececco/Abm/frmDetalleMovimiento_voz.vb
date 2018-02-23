Public Class frmDetalleMovimiento_voz

    Private Sub frmDetalleMovimiento_voz_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttGeneral.SetToolTip(Me.btnBuscaControl, "Buscar Nuevo Control")
        Me.ttGeneral.SetToolTip(Me.btnBuscaActividad_proyecto, "Buscar Nuevo Actividad_proyecto")
        Me.ttGeneral.SetToolTip(Me.btnBuscaCadista, "Buscar Nuevo Cadista")
        Me.ttGeneral.SetToolTip(Me.btnBuscaProyect_manager, "Buscar Nuevo Proyect_manager")
        Me.ttGeneral.SetToolTip(Me.btnBuscaControlador_1, "Buscar Nuevo Controlador_1")
        Me.ttGeneral.SetToolTip(Me.btnBuscaControlador_2, "Buscar Nuevo Controlador_2")
        Me.ttGeneral.SetToolTip(Me.btnBuscaUsuario_anterior, "Buscar Nuevo Usuario_anterior")
        Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Movimiento_voz")
        Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()

            Me.cmbControl.Text = oControl.GetOne(CInt(Me.lblid_Control.Text)).Rows(0).Item("nombre Control").ToString.Trim
            Me.cmbActividad_proyecto.Text = oActividad_proyecto.GetOne(CInt(Me.lblid_Actividad_proyecto.Text)).Rows(0).Item("nombre Actividad_proyecto").ToString.Trim
            Me.cmbcadista.Text = oUsuario.GetOne(CInt(Me.lblid_cadista.Text)).Rows(0).Item("nombre Cadista").ToString.Trim
            Me.cmbproyect_manager.Text = oUsuario.GetOne(CInt(Me.lblid_proyect_manager.Text)).Rows(0).Item("nombre Proyect_manager").ToString.Trim
            Me.cmbcontrolador_1.Text = oUsuario.GetOne(CInt(Me.lblid_controlador_1.Text)).Rows(0).Item("nombre Controlador_1").ToString.Trim
            Me.cmbcontrolador_2.Text = oUsuario.GetOne(CInt(Me.lblid_controlador_2.Text)).Rows(0).Item("nombre Controlador_2").ToString.Trim
            Me.cmbusuario_anterior.Text = oUsuario.GetOne(CInt(Me.lblid_usuario_anterior.Text)).Rows(0).Item("nombre Usuario_anterior").ToString.Trim
        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try

        If BanderaMovimiento_voz = 1 Then
            Me.LimpiarControles()
        End If
        Me.Text = "Movimiento_voz" & vgNombreFormulario
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False
    End Sub

    Sub CargarCombos()
        Me.CargarControl()
        Me.CargarActividad_proyecto()
        Me.CargarCadista()
        Me.CargarProyect_manager()
        Me.CargarControlador_1()
        Me.CargarControlador_2()
        Me.CargarUsuario_anterior()
    End Sub

    Sub CargarControl()
        Dim odt As New DataTable

        odt = oControl.GetCmb
        With Me.cmbControl
            .DataSource = odt
            .DisplayMember = "nombre_control"
            .ValueMember = "id_control"
        End With
        If Me.cmbControl.SelectedIndex >= 0 Then
            cmbControl.SelectedIndex = 0
            Me.lblid_Control.Text = cmbControl.SelectedValue.ToString
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

    Sub CargarCadista()
        Dim odt As New DataTable

        odt = oUsuario.GetCmb
        With Me.cmbCadista
            .DataSource = odt
            .DisplayMember = "nombre_cadista"
            .ValueMember = "id_cadista"
        End With
        If Me.cmbCadista.SelectedIndex >= 0 Then
            cmbCadista.SelectedIndex = 0
            Me.lblid_Cadista.Text = cmbCadista.SelectedValue.ToString
        End If
    End Sub

    Sub CargarProyect_manager()
        Dim odt As New DataTable

        odt = oUsuario.GetCmb
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

    Sub CargarControlador_1()
        Dim odt As New DataTable

        odt = oUsuario.GetCmb
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

        odt = oUsuario.GetCmb
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

    Sub CargarUsuario_anterior()
        Dim odt As New DataTable

        odt = oUsuario.GetCmb
        With Me.cmbUsuario_anterior
            .DataSource = odt
            .DisplayMember = "nombre_usuario_anterior"
            .ValueMember = "id_usuario_anterior"
        End With
        If Me.cmbUsuario_anterior.SelectedIndex >= 0 Then
            cmbUsuario_anterior.SelectedIndex = 0
            Me.lblid_Usuario_anterior.Text = cmbUsuario_anterior.SelectedValue.ToString
        End If
    End Sub

    Sub LimpiarControles()
        Me.lblid_control.Text = "0"
        Me.cmbControl.Text = ""
        Me.dtpfecha.Value = DateTime.Now
        Me.txtot.Text = ""
        Me.lblid_actividad_proyecto.Text = "0"
        Me.cmbActividad_proyecto.Text = ""
        Me.lblid_cadista.Text = "0"
        Me.cmbCadista.Text = ""
        Me.lblid_proyect_manager.Text = "0"
        Me.cmbProyect_manager.Text = ""
        Me.lblid_controlador_1.Text = "0"
        Me.cmbControlador_1.Text = ""
        Me.lblid_controlador_2.Text = "0"
        Me.cmbControlador_2.Text = ""
        Me.chkcompletado.Checked = False
        Me.lblid_usuario_anterior.Text = "0"
        Me.cmbUsuario_anterior.Text = ""
    End Sub

    Private Sub ObtenerDatos()
        Me.lblid_control.Text = oMovimiento_voz.id_control.ToString
        Me.dtpfecha.Value = oMovimiento_voz.fecha
        Me.txtot.Text = oMovimiento_voz.ot.Trim
        Me.lblid_actividad_proyecto.Text = oMovimiento_voz.id_actividad_proyecto.ToString
        Me.lblid_cadista.Text = oMovimiento_voz.id_cadista.ToString
        Me.lblid_proyect_manager.Text = oMovimiento_voz.id_proyect_manager.ToString
        Me.lblid_controlador_1.Text = oMovimiento_voz.id_controlador_1.ToString
        Me.lblid_controlador_2.Text = oMovimiento_voz.id_controlador_2.ToString
        Me.chkcompletado.Checked = CBool(oMovimiento_voz.completado)
        Me.lblid_usuario_anterior.Text = oMovimiento_voz.id_usuario_anterior.ToString
    End Sub

    Private Sub AsignarDatos()
        oMovimiento_voz.id_control = CInt(Me.lblid_control.Text)
        oMovimiento_voz.fecha = Me.dtpfecha.Value.Date
        oMovimiento_voz.ot = Me.txtot.Text
        oMovimiento_voz.id_actividad_proyecto = CInt(Me.lblid_actividad_proyecto.Text)
        oMovimiento_voz.id_cadista = CInt(Me.lblid_cadista.Text)
        oMovimiento_voz.id_proyect_manager = CInt(Me.lblid_proyect_manager.Text)
        oMovimiento_voz.id_controlador_1 = CInt(Me.lblid_controlador_1.Text)
        oMovimiento_voz.id_controlador_2 = CInt(Me.lblid_controlador_2.Text)
        oMovimiento_voz.completado = Me.chkcompletado.Checked
        oMovimiento_voz.id_usuario_anterior = CInt(Me.lblid_usuario_anterior.Text)
    End Sub

    Public Sub SoloLectura()
        Me.cmbControl.Enabled = False
        Me.btnBuscaControl.Enabled = False
        Me.dtpfecha.Enabled = False
        Me.txtot.Enabled = False
        Me.cmbActividad_proyecto.Enabled = False
        Me.btnBuscaActividad_proyecto.Enabled = False
        Me.cmbCadista.Enabled = False
        Me.btnBuscaCadista.Enabled = False
        Me.cmbProyect_manager.Enabled = False
        Me.btnBuscaProyect_manager.Enabled = False
        Me.cmbControlador_1.Enabled = False
        Me.btnBuscaControlador_1.Enabled = False
        Me.cmbControlador_2.Enabled = False
        Me.btnBuscaControlador_2.Enabled = False
        Me.chkcompletado.Enabled = False
        Me.cmbUsuario_anterior.Enabled = False
        Me.btnBuscaUsuario_anterior.Enabled = False
        Me.btnGuardar.Visible = False
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            If oMovimiento_voz.Exist() Then
                If BanderaMovimiento_voz = 1 Then
                    MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
                    Exit Sub
                ElseIf BanderaMovimiento_voz = 2 Then
                    If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                        = System.Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            Select Case BanderaMovimiento_voz
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oMovimiento_voz.Guardar()
                    CType(Me.Owner, frmAbmMovimiento_voz).RefrescarGrilla()
                    Me.CargarCombos()
                    oMovimiento_voz.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.cmbcontrol.Focus()
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oMovimiento_voz.Guardar()
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If _
        Me.txtot.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean

        If CDbl(Me.lblid_control.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de control")
            Exit Sub
        End If
        If CDbl(Me.lblid_actividad_proyecto.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de actividad_proyecto")
            Exit Sub
        End If
        If CDbl(Me.lblid_cadista.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de cadista")
            Exit Sub
        End If
        If CDbl(Me.lblid_proyect_manager.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de proyect_manager")
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
        If CDbl(Me.lblid_usuario_anterior.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de usuario_anterior")
            Exit Sub
        End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaMovimiento_voz = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cmbControl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcontrol.SelectedIndexChanged
        If Me.cmbcontrol.SelectedIndex >= 0 Then
            Me.lblid_control.Text = cmbcontrol.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscacontrol.Click
        Dim frmTemporal As New frmAbmControl
        frmTemporal.ShowDialog()
        Me.CargarControl()
        Me.cmbcontrol.Focus()
        Me.cmbcontrol.Text = ""
        Me.lblid_control.Text = "0"
    End Sub

    Private Sub cmbActividad_proyecto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbactividad_proyecto.SelectedIndexChanged
        If Me.cmbactividad_proyecto.SelectedIndex >= 0 Then
            Me.lblid_actividad_proyecto.Text = cmbactividad_proyecto.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaActividad_proyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaactividad_proyecto.Click
        Dim frmTemporal As New frmAbmUsuario
        frmTemporal.ShowDialog()
        Me.CargarActividad_proyecto()
        Me.cmbactividad_proyecto.Focus()
        Me.cmbactividad_proyecto.Text = ""
        Me.lblid_actividad_proyecto.Text = "0"
    End Sub

    Private Sub cmbCadista_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcadista.SelectedIndexChanged
        If Me.cmbcadista.SelectedIndex >= 0 Then
            Me.lblid_cadista.Text = cmbcadista.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaCadista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscacadista.Click
        Dim frmTemporal As New frmAbmUsuario
        frmTemporal.ShowDialog()
        Me.CargarCadista()
        Me.cmbcadista.Focus()
        Me.cmbcadista.Text = ""
        Me.lblid_cadista.Text = "0"
    End Sub

    Private Sub cmbProyect_manager_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbproyect_manager.SelectedIndexChanged
        If Me.cmbproyect_manager.SelectedIndex >= 0 Then
            Me.lblid_proyect_manager.Text = cmbproyect_manager.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaProyect_manager_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaproyect_manager.Click
        Dim frmTemporal As New frmAbmUsuario
        frmTemporal.ShowDialog()
        Me.CargarProyect_manager()
        Me.cmbproyect_manager.Focus()
        Me.cmbproyect_manager.Text = ""
        Me.lblid_proyect_manager.Text = "0"
    End Sub

    Private Sub cmbControlador_1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcontrolador_1.SelectedIndexChanged
        If Me.cmbcontrolador_1.SelectedIndex >= 0 Then
            Me.lblid_controlador_1.Text = cmbcontrolador_1.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaControlador_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscacontrolador_1.Click
        Dim frmTemporal As New frmAbmUsuario
        frmTemporal.ShowDialog()
        Me.CargarControlador_1()
        Me.cmbcontrolador_1.Focus()
        Me.cmbcontrolador_1.Text = ""
        Me.lblid_controlador_1.Text = "0"
    End Sub

    Private Sub cmbControlador_2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcontrolador_2.SelectedIndexChanged
        If Me.cmbcontrolador_2.SelectedIndex >= 0 Then
            Me.lblid_controlador_2.Text = cmbcontrolador_2.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaControlador_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscacontrolador_2.Click
        Dim frmTemporal As New frmAbmUsuario
        frmTemporal.ShowDialog()
        Me.CargarControlador_2()
        Me.cmbcontrolador_2.Focus()
        Me.cmbcontrolador_2.Text = ""
        Me.lblid_controlador_2.Text = "0"
    End Sub

    Private Sub cmbUsuario_anterior_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbusuario_anterior.SelectedIndexChanged
        If Me.cmbusuario_anterior.SelectedIndex >= 0 Then
            Me.lblid_usuario_anterior.Text = cmbusuario_anterior.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaUsuario_anterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscausuario_anterior.Click
        Dim frmTemporal As New frmAbmUsuario
        frmTemporal.ShowDialog()
        Me.CargarUsuario_anterior()
        Me.cmbusuario_anterior.Focus()
        Me.cmbusuario_anterior.Text = ""
        Me.lblid_usuario_anterior.Text = "0"
    End Sub

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtot.KeyPress, chkcompletado.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles cmbcontrol.KeyDown, dtpfecha.KeyDown, cmbactividad_proyecto.KeyDown, cmbcadista.KeyDown, cmbproyect_manager.KeyDown, cmbcontrolador_1.KeyDown, cmbcontrolador_2.KeyDown, cmbusuario_anterior.KeyDown
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
