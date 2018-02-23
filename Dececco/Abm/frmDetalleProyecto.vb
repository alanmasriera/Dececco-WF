Public Class frmDetalleProyecto

    Dim proyecto As Proyecto
    Dim id_proyecto As Integer


    Private Sub frmDetalleProyecto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ttGeneral.SetToolTip(Me.btnBuscacliente, "Buscar Nuevo Cliente")
        Me.ttGeneral.SetToolTip(Me.btnBuscaproyecto_padre, "Buscar Nuevo Proyecto padre")
        Me.ttGeneral.SetToolTip(Me.btnBuscaproyect_manager, "Buscar Nuevo Proyect manager")
        Me.ttGeneral.SetToolTip(Me.btnBuscaestado, "Buscar Nuevo Estado")
        Me.ttGeneral.SetToolTip(Me.btnBuscacontrolador_1, "Buscar Nuevo Controlador 1")
        Me.ttGeneral.SetToolTip(Me.btnBuscacontrolador_2, "Buscar Nuevo Controlador 2")
        Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Proyecto")
        Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()

            Me.cmbcliente.SelectedValue = CInt(Me.lblid_cliente.Text)
            Me.cmbproyecto_padre.SelectedValue = CInt(Me.lblid_proyecto_padre.Text)
            Me.cmbproyect_manager.SelectedValue = CInt(Me.lblid_proyect_manager.Text)
            Me.cmbestado.SelectedValue = CInt(Me.lblid_estado.Text)
            Me.cmbcontrolador_1.SelectedValue = CInt(Me.lblid_controlador_1.Text)
            Me.cmbcontrolador_2.SelectedValue = CInt(Me.lblid_controlador_2.Text)
            Me.cmbPiloto.SelectedValue = oProyecto.id_piloto

        Catch ex As Exception

        End Try

        If BanderaProyecto = 1 Then
            Me.LimpiarControles()
        End If

        Me.Text = "Proyecto"
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False
    End Sub

    Sub CargarCombos()
        Me.CargarCliente()
        Me.CargarProyect_manager()
        Me.CargarEstado()
        Me.CargarControlador_1()
        Me.CargarControlador_2()
        Me.CargarPilotos()
    End Sub

    Sub CargarCliente()
        Dim odt As New DataTable

        odt = oCliente.GetCmb_2
        With Me.cmbcliente
            .DataSource = odt
            .DisplayMember = "nombre_cliente"
            .ValueMember = "id_cliente"
        End With
        If Me.cmbcliente.SelectedIndex >= 0 Then
            cmbcliente.SelectedIndex = 0
            Me.lblid_cliente.Text = cmbcliente.SelectedValue.ToString
        End If
    End Sub

    Sub CargarProyecto_padre()
        Dim odt As New DataTable

        odt = oProyecto.GetCmb_2
        With Me.cmbproyecto_padre
            .DataSource = odt
            .DisplayMember = "nombre_proyecto"
            .ValueMember = "id_proyecto"
        End With
        If Me.cmbproyecto_padre.SelectedIndex >= 0 Then
            cmbproyecto_padre.SelectedIndex = 0
            Me.lblid_proyecto_padre.Text = cmbproyecto_padre.SelectedValue.ToString
        End If
    End Sub

    Sub CargarProyect_manager()
        Dim odt As New DataTable

        odt = oUsuario.GetCmb
        With Me.cmbproyect_manager
            .DataSource = odt
            .DisplayMember = "nombre_usuario"
            .ValueMember = "id_usuario"
        End With
        If Me.cmbproyect_manager.SelectedIndex >= 0 Then
            cmbproyect_manager.SelectedIndex = 0
            Me.lblid_proyect_manager.Text = cmbproyect_manager.SelectedValue.ToString
        End If
    End Sub

    Sub CargarEstado()
        Dim odt As New DataTable

        odt = oEstado.GetCmb
        With Me.cmbestado
            .DataSource = odt
            .DisplayMember = "nombre_estado"
            .ValueMember = "id_estado"
        End With
        If Me.cmbestado.SelectedIndex >= 0 Then
            cmbestado.SelectedIndex = 0
            Me.lblid_estado.Text = cmbestado.SelectedValue.ToString
        End If
    End Sub

    Sub CargarControlador_1()
        Dim odt As New DataTable

        odt = oUsuario.GetCmb
        With Me.cmbcontrolador_1
            .DataSource = odt
            .DisplayMember = "nombre_usuario"
            .ValueMember = "id_usuario"
        End With
        If Me.cmbcontrolador_1.SelectedIndex >= 0 Then
            cmbcontrolador_1.SelectedIndex = 0
            Me.lblid_controlador_1.Text = cmbcontrolador_1.SelectedValue.ToString
        End If
    End Sub

    Sub CargarControlador_2()
        Dim odt As New DataTable

        odt = oUsuario.GetCmb
        With Me.cmbcontrolador_2
            .DataSource = odt
            .DisplayMember = "nombre_usuario"
            .ValueMember = "id_usuario"
        End With
        If Me.cmbcontrolador_2.SelectedIndex >= 0 Then
            cmbcontrolador_2.SelectedIndex = 0
            Me.lblid_controlador_2.Text = cmbcontrolador_2.SelectedValue.ToString
        End If
    End Sub

    Sub CargarPilotos()
        Dim odt As New DataTable

        odt = oUsuario.GetCmb
        With Me.cmbPiloto
            .DataSource = odt
            .DisplayMember = "nombre_usuario"
            .ValueMember = "id_usuario"
        End With
        If Me.cmbPiloto.SelectedIndex >= 0 Then
            cmbPiloto.SelectedIndex = 0
            Me.lblid_controlador_2.Text = cmbPiloto.SelectedValue.ToString
        End If
    End Sub

    Sub LimpiarControles()
        Me.txtdescripcion.Text = ""
        Me.txtnombre_proyecto.Text = ""
        Me.lblid_cliente.Text = "0"
        Me.cmbcliente.Text = ""
        Me.lblid_proyecto_padre.Text = "0"
        Me.cmbproyecto_padre.Text = ""
        Me.lblid_proyect_manager.Text = "0"
        Me.cmbproyect_manager.Text = ""
        Me.dtpfecha_inicio.Value = DateTime.Now
        Me.dtpfecha_fin_prevista.Value = DateTime.Now
        Me.dtpfecha_fin_real.Value = DateTime.Now
        Me.txtorden.Text = ""
        Me.lblid_estado.Text = "0"
        Me.cmbestado.Text = ""
        Me.txttotal_hora.Text = ""
        Me.txtprioridad.Text = ""
        Me.txtobservacion.Text = ""
        Me.lblid_controlador_1.Text = "0"
        Me.cmbcontrolador_1.Text = ""
        Me.lblid_controlador_2.Text = "0"
        Me.cmbcontrolador_2.Text = ""
        Me.txtpath.Text = ""
        Me.chkarchivado.Checked = False
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
        oProyecto.id_piloto = CInt(Me.cmbPiloto.SelectedValue)

        Me.lblid_proyecto.Text = CStr(oProyecto.id_proyecto)

        If BanderaProyecto = 2 Then
            Dim idP As Integer = 0
            Dim srtPath As String = ""
            Dim odtP As New DataTable
            Dim odtP_2 As New DataTable

            odtP = oProyecto.GetOne(oProyecto.id_proyecto)
            idP = CInt(odtP.Rows(0).Item("Id proyecto padre"))
            'srtPath = CStr(odtP.Rows(0).Item("nombre_proyecto")) ''& "-" & Me.txtnombre_proyecto.Text
            srtPath = Me.txtnombre_proyecto.Text


            While idP <> 1
                odtP_2 = oProyecto.GetOne(idP)
                idP = CInt(odtP_2.Rows(0).Item("Id proyecto padre"))
                srtPath = CStr(odtP_2.Rows(0).Item("Nombre proyecto")) & "-" & srtPath
            End While

            oProyecto.path = srtPath
        End If


    End Sub

    Public Sub SoloLectura()
        Me.txtdescripcion.Enabled = False
        Me.txtnombre_proyecto.Enabled = False
        Me.cmbcliente.Enabled = False
        Me.btnBuscacliente.Enabled = False
        Me.cmbproyecto_padre.Enabled = False
        Me.btnBuscaproyecto_padre.Enabled = False
        Me.cmbproyect_manager.Enabled = False
        Me.btnBuscaproyect_manager.Enabled = False
        Me.dtpfecha_inicio.Enabled = False
        Me.dtpfecha_fin_prevista.Enabled = False
        Me.dtpfecha_fin_real.Enabled = False
        Me.txtorden.Enabled = False
        Me.cmbestado.Enabled = False
        Me.btnBuscaestado.Enabled = False
        Me.txttotal_hora.Enabled = False
        Me.txtprioridad.Enabled = False
        Me.txtobservacion.Enabled = False
        Me.cmbcontrolador_1.Enabled = False
        Me.btnBuscacontrolador_1.Enabled = False
        Me.cmbcontrolador_2.Enabled = False
        Me.btnBuscacontrolador_2.Enabled = False
        Me.txtpath.Enabled = False
        Me.chkarchivado.Enabled = False
        Me.btnGuardar.Visible = False
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            If oProyecto.Exist() Then
                If BanderaProyecto = 1 Then
                    MessageBox.Show("Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
                    Exit Sub
                ElseIf BanderaProyecto = 2 Then
                    If MessageBox.Show("Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                        = System.Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            Select Case BanderaProyecto
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oProyecto.Guardar()
                    Try
                        GenererPathProyecto(CInt(Me.lblid_proyecto.Text))
                    Catch ex As Exception

                    End Try

                    CType(Me.Owner, frmAbmProyecto).RefrescarGrilla()
                    Me.CargarCombos()
                    oProyecto.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.txtdescripcion.Focus()
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oProyecto.Guardar()
                    Try
                        GenererPathProyecto(CInt(Me.lblid_proyecto.Text))
                    Catch ex As Exception

                    End Try

                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If Me.txtdescripcion.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean
        vgbanderaproyecto = True
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
        If CInt(cmbPiloto.SelectedValue) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de Piloto de proyecto")
            Exit Sub
        End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaProyecto = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cmbCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcliente.SelectedIndexChanged
        If Me.cmbcliente.SelectedIndex >= 0 Then
            Me.lblid_cliente.Text = cmbcliente.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscacliente.Click
        Dim frmTemporal As New frmAbmCliente
        frmTemporal.ShowDialog()
        Me.CargarCliente()
        Me.cmbcliente.Focus()
        Me.cmbcliente.Text = ""
        Me.lblid_cliente.Text = "0"
    End Sub

    Private Sub cmbProyecto_padre_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbproyecto_padre.SelectedIndexChanged
        If Me.cmbproyecto_padre.SelectedIndex >= 0 Then
            Me.lblid_proyecto_padre.Text = cmbproyecto_padre.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaProyecto_padre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaproyecto_padre.Click
        Dim frmTemporal As New frmAbmProyecto
        frmTemporal.ShowDialog()
        Me.CargarProyecto_padre()
        Me.cmbproyecto_padre.Focus()
        Me.cmbproyecto_padre.Text = ""
        Me.lblid_proyecto_padre.Text = "0"
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

    Private Sub cmbEstado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbestado.SelectedIndexChanged
        If Me.cmbestado.SelectedIndex >= 0 Then
            Me.lblid_estado.Text = cmbestado.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaEstado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaestado.Click
        Dim frmTemporal As New frmAbmEstado
        frmTemporal.ShowDialog()
        Me.CargarEstado()
        Me.cmbestado.Focus()
        Me.cmbestado.Text = ""
        Me.lblid_estado.Text = "0"
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

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtdescripcion.KeyPress, txtnombre_proyecto.KeyPress, txtorden.KeyPress, txtobservacion.KeyPress, txtpath.KeyPress, chkarchivado.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles cmbcliente.KeyDown, cmbproyecto_padre.KeyDown, cmbproyect_manager.KeyDown, dtpfecha_inicio.KeyDown, dtpfecha_fin_prevista.KeyDown, dtpfecha_fin_real.KeyDown, cmbestado.KeyDown, cmbcontrolador_1.KeyDown, cmbcontrolador_2.KeyDown
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


    Private Sub btnBuscarPiloto_Click(sender As Object, e As EventArgs) Handles btnBuscarPiloto.Click
        Dim frmTemporal As New frmAbmUsuario
        frmTemporal.ShowDialog()
        Me.CargarPilotos()
        Me.cmbPiloto.Focus()
        Me.cmbPiloto.Text = ""
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
