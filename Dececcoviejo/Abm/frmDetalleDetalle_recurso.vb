Public Class frmDetalleDetalle_recurso

    Private Sub frmDetalleDetalle_recurso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Me.ttGeneral.SetToolTip(Me.btnBuscaactividad_proyecto, "Buscar Nuevo Actividad_proyecto")
        Me.ttGeneral.SetToolTip(Me.btnBuscausuario, "Buscar Nuevo Usuario")
        Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Detalle_recurso")
        Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()

            '  Me.cmbactividad_proyecto.Text = oActividad_proyecto.GetOne(CInt(Me.lblid_actividad_proyecto.Text)).Rows(0).Item("nombre_Actividad_proyecto").ToString.Trim
            Me.cmbusuario.Text = oUsuario.GetOne(CInt(Me.lblid_usuario.Text)).Rows(0).Item("nombre_Usuario").ToString.Trim
        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try

        If BanderaDetalle_recurso = 1 Then
            Me.LimpiarControles()
        End If
        Me.Text = "Detalle_recurso"
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False

        Me.lblid_actividad_proyecto.Text = CType(Me.Owner, frmLoginInicio).lblid_actividad_proyecto.Text

        Me.RefrescarGrilla()
    End Sub

    Public Sub RefrescarGrilla()
        Dim odt As DataTable

        odt = oDetalle_recurso.GetOneIngreso(CInt(Me.lblid_actividad_proyecto.Text))
        Me.dgv1.DataSource = odt

        Me.dgv1.Columns(0).Visible = False
        Me.dgv1.Columns("id_usuario").Visible = False
        Me.dgv1.Columns("id_actividad_proyecto").Visible = False
    End Sub


    Sub CargarCombos()
        ' Me.CargarActividad_proyecto()
        Me.CargarUsuario()
    End Sub

    'Sub CargarActividad_proyecto()
    '    Dim odt As New DataTable

    '    odt = oActividad_proyecto.GetCmb
    '    With Me.cmbActividad_proyecto
    '        .DataSource = odt
    '        .DisplayMember = "nombre_actividad_proyecto"
    '        .ValueMember = "id_actividad_proyecto"
    '    End With
    '    If Me.cmbActividad_proyecto.SelectedIndex >= 0 Then
    '        cmbActividad_proyecto.SelectedIndex = 0
    '        Me.lblid_Actividad_proyecto.Text = cmbActividad_proyecto.SelectedValue.ToString
    '    End If
    'End Sub

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

    Sub LimpiarControles()
        '  Me.lblid_actividad_proyecto.Text = "0"
        '  Me.cmbActividad_proyecto.Text = ""
        Me.lblid_usuario.Text = "0"
        Me.cmbUsuario.Text = ""
        Me.txtcantidad_hora.Text = ""
        Me.txtporcentaje_avance.Text = ""
        Me.txtmotivo.Text = ""
        Me.txttipo.Text = ""
        Me.chkRealizada.Checked = False
    End Sub

    Private Sub ObtenerDatos()
        '  Me.lblid_actividad_proyecto.Text = oDetalle_recurso.id_actividad_proyecto.ToString
        '  Me.lblid_usuario.Text = oDetalle_recurso.id_usuario.ToString
        Me.txtcantidad_hora.Text = oDetalle_recurso.cantidad_hora.ToString.Trim
        Me.txtporcentaje_avance.Text = oDetalle_recurso.porcentaje_avance.ToString.Trim
        Me.txtmotivo.Text = oDetalle_recurso.motivo.Trim
        Me.txttipo.Text = oDetalle_recurso.tipo.Trim
        Me.chkRealizada.Checked = CBool(oDetalle_recurso.realizada)
    End Sub

    Private Sub AsignarDatos()
        oDetalle_recurso.id_actividad_proyecto = CInt(Me.lblid_actividad_proyecto.Text)
        oDetalle_recurso.id_usuario = CInt(Me.lblid_usuario.Text)
        oDetalle_recurso.cantidad_hora = CDec(Me.txtcantidad_hora.Text)
        oDetalle_recurso.porcentaje_avance = CDec(Me.txtporcentaje_avance.Text)
        oDetalle_recurso.motivo = Me.txtmotivo.Text
        oDetalle_recurso.tipo = Me.txttipo.Text
        oDetalle_recurso.realizada = Me.chkRealizada.Checked
    End Sub

    Public Sub SoloLectura()
        'Me.cmbActividad_proyecto.Enabled = False
        'Me.btnBuscaActividad_proyecto.Enabled = False
        Me.cmbUsuario.Enabled = False
        Me.btnBuscaUsuario.Enabled = False
        Me.txtcantidad_hora.Enabled = False
        Me.txtporcentaje_avance.Enabled = False
        Me.txtmotivo.Enabled = False
        Me.txttipo.Enabled = False
        Me.btnGuardar.Visible = False
        Me.chkRealizada.Enabled = False
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            If oDetalle_recurso.Exist() Then
                If BanderaDetalle_recurso = 1 Then
                    MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
                    Exit Sub
                ElseIf BanderaDetalle_recurso = 2 Then
                    If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                        = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            Select Case BanderaDetalle_recurso
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oDetalle_recurso.Guardar()
                    '  CType(Me.Owner, frmAbmDetalle_recurso).RefrescarGrilla()

                    Me.RefrescarGrilla()

                    Me.CargarCombos()
                    oDetalle_recurso.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.cmbusuario.Focus()
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oDetalle_recurso.Guardar()
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If Me.txtcantidad_hora.Text = "" Or Me.txtporcentaje_avance.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean

        If CDbl(Me.lblid_actividad_proyecto.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de actividad_proyecto")
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
            If BanderaDetalle_recurso = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    'Private Sub cmbActividad_proyecto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbactividad_proyecto.SelectedIndexChanged
    '    If Me.cmbActividad_proyecto.SelectedIndex >= 0 Then
    '        Me.lblid_actividad_proyecto.Text = cmbActividad_proyecto.SelectedValue.ToString
    '    End If
    'End Sub

    'Private Sub btnBuscaActividad_proyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaactividad_proyecto.Click
    '    Dim frmTemporal As New frmDetalleActividad
    '    frmTemporal.ShowDialog()
    '    Me.CargarActividad_proyecto()
    '    Me.cmbActividad_proyecto.Focus()
    '    Me.cmbActividad_proyecto.Text = ""
    '    Me.lblid_Actividad_proyecto.Text = "0"
    'End Sub

    Private Sub cmbUsuario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbusuario.SelectedIndexChanged
        If Me.cmbUsuario.SelectedIndex >= 0 Then
            Me.lblid_usuario.Text = cmbUsuario.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscausuario.Click
        Dim frmTemporal As New FrmAbmUsuario
        frmTemporal.ShowDialog()
        Me.CargarUsuario()
        Me.cmbUsuario.Focus()
        Me.cmbUsuario.Text = ""
        Me.lblid_Usuario.Text = "0"
    End Sub

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtmotivo.KeyPress, txttipo.KeyPress, chkRealizada.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles cmbusuario.KeyDown
        If CDbl(e.KeyValue.ToString) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtcantidad_hora.KeyPress, txtporcentaje_avance.KeyPress
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






    Private Sub dgv1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv1.CurrentCellChanged
        Try
            Me.lblid_pk.Text = CStr(Me.dgv1.Item(0, Me.dgv1.CurrentRow.Index).Value)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Botones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnBorrar.Click
        Dim btnTemp As New Button
        Dim frmDetalle As New frmDetalleDetalle_recurso
        btnTemp = CType(sender, Button)
        Try
            Select Case btnTemp.Name
                'Case "btnAgregar"
                '    BanderaDetalle_recurso = 1
                '    Me.AddOwnedForm(frmDetalle)
                '    oDetalle_recurso.Insertar()
                '    frmDetalle.CargarCombos()
                '    frmDetalle.ShowDialog()
                'Case "btnModificar"
                '    If Not IsNumeric(Me.lblid_pk.Text) Then
                '        Exit Sub
                '    End If
                '    BanderaDetalle_recurso = 2
                '    Me.AddOwnedForm(frmDetalle)
                '    oDetalle_recurso.Modificar(CInt(Me.lblid_pk.Text))
                '    frmDetalle.CargarCombos()
                '    frmDetalle.ShowDialog()
                '    RefrescarGrilla()
                Case "btnBorrar"
                    If Not IsNumeric(Me.lblid_pk.Text) Then
                        Exit Sub
                    End If

                    If MessageBox.Show("Desea Realmente Eliminar el Registro ", "BORRAR", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                    = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If

                    oDetalle_recurso.Borrar(CInt(Me.lblid_pk.Text))
                    RefrescarGrilla()
                Case "btnAyuda"
                    'Process.Start(PathAyuda + "frmAbmDetalle_recurso.avi")
                    'Case "btnSalir"
                    '    Me.Close()
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



End Class
