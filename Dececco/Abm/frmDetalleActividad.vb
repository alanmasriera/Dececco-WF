Public Class frmDetalleActividad

    Dim odtRec As New DataTable

    Private Sub frmDetalleActividad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ttGeneral.SetToolTip(Me.btnBuscatipo_actividad, "Buscar Nuevo Tipo_actividad")
        Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Actividad")
        Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()

        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try

        If BanderaActividad = 1 Then
            Me.LimpiarControles()
        End If
        Me.Text = "Actividad"
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False

        Me.lblid_actividad_proyecto.Text = CType(Me.Owner, frmLoginInicio).lblid_actividad_proyecto.Text
        Dim odtActProy As New DataTable
        odtActProy = oActividad_proyecto.GetOne(CInt(Me.lblid_actividad_proyecto.Text))
        If odtActProy.Rows.Count > 0 Then
            Me.lblid_controlador_1.Text = CStr(odtActProy.Rows(0).Item("id controlador 1"))
            Me.lblid_controlador_2.Text = CStr(odtActProy.Rows(0).Item("id controlador 2"))

            Try
                Me.cmbcontrolador_1.Text = oUsuario.GetOne(CInt(Me.lblid_controlador_1.Text)).Rows(0).Item("nombre usuario").ToString.Trim
                Me.cmbcontrolador_2.Text = oUsuario.GetOne(CInt(Me.lblid_controlador_2.Text)).Rows(0).Item("nombre usuario").ToString.Trim
            Catch ex As Exception
            End Try

        End If

        odtRec = oDetalle_recurso.GetOneIngreso(CInt(Me.lblid_actividad_proyecto.Text))
        If odtRec.Rows.Count > 0 Then
            Me.lblid_detalle_recurso.Text = CStr(odtRec.Rows(0).Item("id_detalle_recurso"))
            Me.txtmotivo.Text = CStr(odtRec.Rows(0).Item("motivo"))
            Me.lblid_usuario.Text = CStr(odtRec.Rows(0).Item("id_usuario"))
            Me.cmbusuario.Text = CStr(odtRec.Rows(0).Item("nombre_usuario"))
        Else
            Me.lblid_usuario.Text = CStr(vgCodigoUsuario)
            Me.cmbusuario.Text = vgNombreUsuario
        End If

        If Me.cmbusuario.Text = vgNombreUsuario Then
        Else
            If banderamodifact = 1 Then
                ' Me.cmbusuario.Enabled = False
                banderamodifact = 0
            End If
        End If

        Try
            Dim odtMovVoz As New DataTable
            odtMovVoz = oMovimiento_voz.GetActividadProyecto(CInt(Me.lblid_actividad_proyecto.Text))
            If odtMovVoz.Rows.Count > 0 Then
                Me.lblid_movimiento_voz.Text = CStr(odtMovVoz.Rows(0).Item("id_movimiento_voz"))
                Me.lblid_usuario.Text = CStr(odtMovVoz.Rows(0).Item("Id_cadista"))
            End If

            Me.cmbtipo_actividad.Text = oTipo_actividad.GetOne(CInt(Me.lblid_tipo_actividad.Text)).Rows(0).Item("descripcion").ToString.Trim
            Me.cmbusuario.Text = oUsuario.GetOne(CInt(Me.lblid_usuario.Text)).Rows(0).Item("nombre_usuario").ToString.Trim

        Catch ex As Exception

        End Try
    End Sub

    Sub CargarCombos()
        Me.CargarTipo_actividad()
        Me.CargarUsuario()
        Me.CargarControlador_1()
        Me.CargarControlador_2()
    End Sub

    Sub CargarTipo_actividad()
        Dim odt As New DataTable

        odt = oTipo_actividad.GetCmb
        With Me.cmbtipo_actividad
            .DataSource = odt
            .DisplayMember = "descripcion"
            .ValueMember = "id_tipo_actividad"
        End With
        If Me.cmbtipo_actividad.SelectedIndex >= 0 Then
            cmbtipo_actividad.SelectedIndex = 0
            Me.lblid_tipo_actividad.Text = cmbtipo_actividad.SelectedValue.ToString
        End If
    End Sub

    Sub CargarUsuario()
        Dim odt As New DataTable

        odt = oUsuario.GetCmb
        With Me.cmbusuario
            .DataSource = odt
            .DisplayMember = "nombre_usuario"
            .ValueMember = "id_usuario"
        End With
        If Me.cmbusuario.SelectedIndex >= 0 Then
            cmbusuario.SelectedIndex = 0
            Me.lblid_usuario.Text = cmbusuario.SelectedValue.ToString
        End If
    End Sub

    Sub CargarControlador_1()
        Dim odt As New DataTable

        odt = oUsuario.GetCmbPM
        With Me.cmbControlador_1
            .DataSource = odt
            .DisplayMember = "nombre_usuario"
            .ValueMember = "id_usuario"
        End With
        If Me.cmbControlador_1.SelectedIndex >= 0 Then
            cmbControlador_1.SelectedIndex = 0
            Me.lblid_Controlador_1.Text = cmbControlador_1.SelectedValue.ToString
        End If
    End Sub

    Sub CargarControlador_2()
        Dim odt As New DataTable

        odt = oUsuario.GetCmbPM
        With Me.cmbControlador_2
            .DataSource = odt
            .DisplayMember = "nombre_usuario"
            .ValueMember = "id_usuario"
        End With
        If Me.cmbControlador_2.SelectedIndex >= 0 Then
            cmbControlador_2.SelectedIndex = 0
            Me.lblid_Controlador_2.Text = cmbControlador_2.SelectedValue.ToString
        End If
    End Sub

    Sub LimpiarControles()
        Me.txtnombre_actividad.Text = ""
        Me.txttiempo_standart.Text = ""
        Me.txtcosto_standart.Text = "0"
        Me.lblid_tipo_actividad.Text = "0"
        Me.cmbtipo_actividad.Text = ""

        Me.cmbusuario.Text = ""
        Me.lblid_usuario.Text = "0"
        Me.txtmotivo.Text = ""
    End Sub

    Private Sub ObtenerDatos()
        Me.txtnombre_actividad.Text = oActividad.nombre_actividad.Trim
        Me.txttiempo_standart.Text = oActividad.tiempo_standart.ToString.Trim
        Me.txtcosto_standart.Text = oActividad.costo_standart.ToString.Trim
        Me.lblid_tipo_actividad.Text = oActividad.id_tipo_actividad.ToString
    End Sub

    Private Sub AsignarDatos()
        oActividad.nombre_actividad = Me.txtnombre_actividad.Text
        oActividad.tiempo_standart = CDec(Me.txttiempo_standart.Text)
        oActividad.costo_standart = CDec(Me.txtcosto_standart.Text)
        oActividad.id_tipo_actividad = CInt(Me.lblid_tipo_actividad.Text)
    End Sub

    Public Sub SoloLectura()
        Me.txtnombre_actividad.Enabled = False
        Me.txttiempo_standart.Enabled = False
        Me.txtcosto_standart.Enabled = False
        Me.cmbtipo_actividad.Enabled = False
        Me.btnBuscatipo_actividad.Enabled = False
        Me.btnGuardar.Visible = False
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            'If oActividad.Exist() Then
            '    If BanderaActividad = 1 Then
            '        MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
            '        Exit Sub
            '    ElseIf BanderaActividad = 2 Then
            '        If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
            '            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
            '            = System.Windows.Forms.DialogResult.No Then
            '            Exit Sub
            '        End If
            '    End If
            'End If
            Select Case BanderaActividad
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oActividad.Guardar()
                    ''  CType(Me.Owner, frmAbmActividad).RefrescarGrilla()
                    Me.CargarCombos()
                    oActividad.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.txtnombre_actividad.Focus()
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oActividad.Guardar()

                    Dim odtDet As New DataTable
                    odtDet = oDetalle_recurso.GetOneIngreso(CInt(Me.lblid_actividad_proyecto.Text))

                    If odtRec.Rows.Count > 0 Then
                        With oDetalle_recurso
                            .Cargar()
                            .Modificar(CInt(Me.lblid_detalle_recurso.Text))
                            .cantidad_hora = CDec(Me.txttiempo_standart.Text)
                            .id_actividad_proyecto = CInt(Me.lblid_actividad_proyecto.Text)

                            vgUsuarioAnterior = CInt(.id_usuario)

                            .id_usuario = CInt(Me.lblid_usuario.Text)
                            .motivo = Me.txtmotivo.Text
                            .porcentaje_avance = 10
                            .realizada = False
                            .tipo = "-"
                            .Guardar()
                        End With
                    Else
                        With oDetalle_recurso
                            .Cargar()
                            .Insertar()
                            .cantidad_hora = CDec(Me.txttiempo_standart.Text)
                            .id_actividad_proyecto = CInt(Me.lblid_actividad_proyecto.Text)
                            .id_usuario = CInt(Me.lblid_usuario.Text)

                            vgUsuarioAnterior = CInt(.id_usuario)

                            .motivo = Me.txtmotivo.Text
                            .porcentaje_avance = 10
                            .realizada = False
                            .tipo = "-"
                            .Guardar()
                        End With
                    End If

                    With oActividad_proyecto
                        .Modificar(CInt(Me.lblid_actividad_proyecto.Text))
                        .id_controlador_1 = CInt(Me.lblid_controlador_1.Text)
                        .id_controlador_2 = CInt(Me.lblid_controlador_2.Text)
                        .Guardar()
                    End With

                    Try
                        With oMovimiento_voz
                            .Cargar()
                            '''''''ver
                            .Modificar(CInt(Me.lblid_movimiento_voz.Text))
                            .id_cadista = CInt(Me.lblid_usuario.Text)
                            .Guardar()
                        End With
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
        If Me.txtnombre_actividad.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean
        vgbanderactividad = True
        If CDbl(Me.lblid_tipo_actividad.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de tipo_actividad")
            Exit Sub
        End If

        If CDbl(Me.lblid_usuario.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de usuario")
            Exit Sub
        End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaActividad = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cmbTipo_actividad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtipo_actividad.SelectedIndexChanged
        If Me.cmbtipo_actividad.SelectedIndex >= 0 Then
            Me.lblid_tipo_actividad.Text = cmbtipo_actividad.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaTipo_actividad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscatipo_actividad.Click
        Dim frmTemporal As New frmAbmTipo_actividad
        frmTemporal.ShowDialog()
        Me.CargarTipo_actividad()
        Me.cmbtipo_actividad.Focus()
        Me.cmbtipo_actividad.Text = ""
        Me.lblid_tipo_actividad.Text = "0"
    End Sub

    Private Sub cmbUsuario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbusuario.SelectedIndexChanged
        If Me.cmbusuario.SelectedIndex >= 0 Then
            Me.lblid_usuario.Text = cmbusuario.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscausuario.Click
        Dim frmTemporal As New frmAbmUsuario
        frmTemporal.ShowDialog()
        Me.CargarUsuario()
        Me.cmbusuario.Focus()
        Me.cmbusuario.Text = ""
        Me.lblid_usuario.Text = "0"
    End Sub

    Private Sub cmbControlador_1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcontrolador_1.SelectedIndexChanged
        If Me.cmbcontrolador_1.SelectedIndex >= 0 Then
            Me.lblid_controlador_1.Text = cmbcontrolador_1.SelectedValue.ToString
        End If
    End Sub

    Private Sub cmbControlador_2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcontrolador_2.SelectedIndexChanged
        If Me.cmbcontrolador_2.SelectedIndex >= 0 Then
            Me.lblid_controlador_2.Text = cmbcontrolador_2.SelectedValue.ToString
        End If
    End Sub

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtnombre_actividad.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles cmbtipo_actividad.KeyDown
        If CDbl(e.KeyValue.ToString) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txttiempo_standart.KeyPress, txtcosto_standart.KeyPress
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
