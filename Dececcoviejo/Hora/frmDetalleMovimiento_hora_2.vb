Public Class frmDetalleMovimiento_hora_2

    Dim BanderaCierreForm As Boolean = False
    Dim BanderaHoraSalida As Boolean = False
    Dim odtObra As New DataTable
    Dim odtObra_2 As New DataTable
    Private Sub frmDetalleMovimiento_hora_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'If BanderaCierreForm = False Then
        '    e.Cancel = True
        'End If
    End Sub

    Private Sub frmDetalleMovimiento_hora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttGeneral.SetToolTip(Me.btnBuscaEmpleado, "Buscar Nuevo Empleado")
        Me.ttGeneral.SetToolTip(Me.btnBuscaDia, "Buscar Nuevo Dia")
        Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Movimiento_hora")
        Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")

        'modificado
        Me.Height = 698

        Me.ttGeneral.SetToolTip(Me.btnBuscaobra, "Buscar Nuevo Obra")
        Try
            ObtenerDatos()
            Me.cmbempleado.Text = oEmpleado.GetOne_3(CInt(Me.lblid_empleado.Text)).Rows(0).Item("nombre_usuario").ToString.Trim
            Me.cmbdia.Text = oDia.GetOne(CInt(Me.lblid_dia.Text)).Rows(0).Item("nombre_Dia").ToString.Trim
            Me.cmbobra.Text = oActividad_proyecto.GetOne_2(CInt(Me.lblid_obra.Text)).Rows(0).Item("nombre_actividad").ToString.Trim
        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try

        Me.lblid_Movimiento_hora.Text = CType(Me.Owner, frmAbmMovimiento_hora).lblid_pk.Text
        Me.chkExtra.Checked = CType(Me.Owner, frmAbmMovimiento_hora).chkExtra.Checked

        If BanderaMovimiento_hora = 1 Then
            Me.LimpiarControles()
            Me.LimpiarControlesCuerpo()

            'seteo la fecha por primera vez
            Me.dtpfecha.Value = DateTime.Now

            Me.lblid_empleado.Text = CType(Me.Owner, frmAbmMovimiento_hora).lblid_empleado.Text
            Me.cmbempleado.Text = oEmpleado.GetOne_2(CInt(Me.lblid_empleado.Text)).Rows(0).Item("nombre_usuario").ToString.Trim
            Me.dtpfecha.Value = CType(Me.Owner, frmAbmMovimiento_hora).dtpInicio.Value.Date

            Me.lblid_Movimiento_hora.Text = "0"
        End If

        Me.Text = "Movimiento_hora" & vgNombreFormulario
        Me.CancelButton = Me.btnSalir
        '   Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False

        'agregado para obtener el nombre de la obra
        'Dim odt As New DataTable
        'odt = oMovimiento_hora.GetAllMovimiento_3(CInt(Me.lblid_Movimiento_hora.Text), dtpfecha.Value.Date)
        'If odt.Rows.Count <> 0 Then
        '    Me.cmbobra.SelectedValue = odt.Rows(0)("id_actividad_proyecto").ToString.Trim
        'End If

        'oCuerpo_Movimiento_hora.Cargar()
        Me.RefrescarGrilla()
        Me.RefrescarGrilla_2()
        Me.ControlarHoras()
        Me.ControlarHoras_2()
    End Sub

    Sub CargarCombos()
        '  Me.CargarEmpleado()
        Me.CargarDia()
    End Sub

    'Sub CargarEmpleado()
    '    Dim odt As New DataTable

    '    odt = oEmpleado.GetCmb
    '    With Me.cmbEmpleado
    '        .DataSource = odt
    '        .DisplayMember = "nombre_usuario"
    '        .ValueMember = "id_Empleado"
    '    End With
    '    If Me.cmbEmpleado.SelectedIndex >= 0 Then
    '        cmbEmpleado.SelectedIndex = 0
    '        Me.lblid_Empleado.Text = cmbEmpleado.SelectedValue.ToString
    '    End If
    'End Sub

    Sub CargarDia()
        Dim odt As New DataTable

        odt = oDia.GetCmb_2
        With Me.cmbdia
            .DataSource = odt
            .DisplayMember = "nombre_Dia"
            .ValueMember = "id_Dia"
        End With
        If Me.cmbdia.SelectedIndex >= 0 Then
            cmbdia.SelectedIndex = 0
            Me.lblid_dia.Text = cmbdia.SelectedValue.ToString
        End If
    End Sub

    Sub LimpiarControles()
        Me.dtpfecha.Value = DateAdd(DateInterval.Day, 1, Me.dtpfecha.Value)
        '   Me.lblid_empleado.Text = "0"
        '    Me.cmbEmpleado.Text =  ""
        Me.lblid_obra.Text = "0"
        Me.cmbobra.Text = ""
        Me.lblid_dia.Text = "0"
        Me.cmbdia.Text = ""

        Me.dtpentrada.Value = CDate(String.Concat(CStr(Me.dtpfecha.Value.Date), " 07:30:00"))
        Me.dtpsalida.Value = CDate(String.Concat(CStr(Me.dtpfecha.Value.Date), " 16:30:00"))
        Me.dtpSalida_2.Value = CDate(String.Concat(CStr(Me.dtpfecha.Value.Date), " 16:30:00"))

        Me.Label1.Visible = False
        Me.Label2.Visible = False
        Me.txtHora1.Visible = False
        Me.txtHora2.Visible = False
        Me.txtHora3.Visible = False

        BanderaCuerpo_movimiento_hora = 1
    End Sub

    Private Sub ObtenerDatos()
        Me.dtpfecha.Value = oMovimiento_hora.fecha
        Me.lblid_empleado.Text = oMovimiento_hora.id_usuario.ToString ' oMovimiento_hora.id_empleado.ToString
        Me.lblid_dia.Text = oMovimiento_hora.id_dia.ToString

    End Sub

    Private Sub AsignarDatos()
        oMovimiento_hora.fecha = Me.dtpfecha.Value.Date
        ' oMovimiento_hora.id_empleado = CInt(Me.lblid_empleado.Text)
        oMovimiento_hora.id_usuario = CInt(Me.lblid_empleado.Text)
        oMovimiento_hora.id_dia = CInt(Me.lblid_dia.Text)

    End Sub

    Public Sub SoloLectura()
        Me.dtpfecha.Enabled = False
        Me.cmbempleado.Enabled = False
        Me.btnBuscaempleado.Enabled = False
        Me.cmbdia.Enabled = False
        Me.btnBuscadia.Enabled = False
        Me.btnGuardar.Visible = False
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            'If oMovimiento_hora.Exist() Then
            '    If BanderaMovimiento_hora = 1 Then
            '        MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
            '        Exit Sub
            '    ElseIf BanderaMovimiento_hora = 2 Then
            '        If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
            '            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
            '            = Windows.Forms.DialogResult.No Then
            '            Exit Sub
            '        End If
            '    End If
            'End If
            Select Case BanderaMovimiento_hora
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oMovimiento_hora.Guardar()

                    Me.lblid_Movimiento_hora.Text = oMovimiento_hora.id_movimiento_hora.ToString

                    With oCuerpo_movimiento_hora
                        '.Insertar()
                        .entrada = Me.dtpentrada.Value
                        .id_movimiento_hora = CInt(Me.lblid_Movimiento_hora.Text)
                        .id_actividad_proyecto = CInt(Me.lblid_obra.Text)
                        .salida = Me.dtpsalida.Value
                        ' .extra = Me.chkEsExtra.Checked
                        .Guardar()
                        .Insertar()
                    End With

                    If CInt(Me.lblid_Obra_2.Text) > 0 Then
                        oMovimiento_hora.Insertar()
                        Me.AsignarDatos()
                        oMovimiento_hora.Guardar()
                        Me.lblid_Movimiento_hora.Text = oMovimiento_hora.id_movimiento_hora.ToString

                        If Me.chkBarraE.Checked = True Then
                            With oCuerpo_movimiento_hora
                                '.Insertar()
                                .entrada = Me.dtpentrada.Value
                                .id_movimiento_hora = CInt(Me.lblid_Movimiento_hora.Text)
                                .id_actividad_proyecto = CInt(Me.lblid_Obra_2.Text)
                                .salida = Me.dtpSalida_2.Value
                                '.extra = True
                                .Guardar()
                                .Insertar()
                            End With
                        End If
                    End If

                    '   oCuerpo_Movimiento_hora.UpdateID(CInt(Me.lblid_Movimiento_hora.Text))

                    CType(Me.Owner, frmAbmMovimiento_hora).RefrescarGrilla()
                    'Me.CargarCombos()
                    oMovimiento_hora.Insertar()
                    'Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.LimpiarControlesCuerpo()
                    Me.dtpfecha.Focus()

                    Me.lblid_Movimiento_hora.Text = "0"
                    Me.RefrescarGrilla()

                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oMovimiento_hora.Guardar()
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub GuardarVarios()
        Try
            Me.AsignarDatos()
            'If oMovimiento_hora.Exist() Then
            '    If BanderaMovimiento_hora = 1 Then
            '        MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
            '        Exit Sub
            '    ElseIf BanderaMovimiento_hora = 2 Then
            '        If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
            '            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
            '            = Windows.Forms.DialogResult.No Then
            '            Exit Sub
            '        End If
            '    End If
            'End If
            Select Case BanderaMovimiento_hora
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oMovimiento_hora.Guardar()

                    Me.lblid_Movimiento_hora.Text = oMovimiento_hora.id_movimiento_hora.ToString
                    oCuerpo_movimiento_hora.UpdateID(CInt(Me.lblid_Movimiento_hora.Text), Me.chkEsExtra.Checked)

                    If Me.chkBarraE.Checked = True And Me.lblid_Obra_2.Text <> "0" Then
                        With oMovimiento_hora
                            .Cargar()
                            .Insertar()
                            .fecha = Me.dtpfecha.Value.Date
                            '.id_empleado = CInt(Me.lblid_empleado.Text)
                            .id_usuario = CInt(Me.lblid_empleado.Text)
                            .id_dia = CInt(Me.lblid_dia.Text)
                            .Guardar()

                            Me.lblid_Movimiento_hora.Text = .id_movimiento_hora.ToString
                        End With
                        oCuerpo_movimiento_hora.UpdateID(CInt(Me.lblid_Movimiento_hora.Text), True)
                    End If


                    CType(Me.Owner, frmAbmMovimiento_hora).RefrescarGrilla()
                    'Me.CargarCombos()
                    oMovimiento_hora.Insertar()
                    'Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.dtpfecha.Focus()
                    Me.RefrescarGrilla()

                    Me.lblid_Movimiento_hora.Text = "0"
                    Me.RefrescarGrilla()
                    Me.RefrescarGrilla_2()

                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oMovimiento_hora.Guardar()
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If Me.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean

        If CDbl(Me.lblid_empleado.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de empleado")
            Exit Sub
        End If
        If CDbl(Me.lblid_dia.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de dia")
            Exit Sub
        End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaMovimiento_hora = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        If Me.lblid_Movimiento_hora.Text = "0" Then
            oCuerpo_movimiento_hora.DeleteMovimiento_hora(0, False)
            oCuerpo_movimiento_hora.DeleteMovimiento_hora(0, True)
        End If

        Me.Close()
    End Sub

    'Private Sub cmbEmpleado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEmpleado.SelectedIndexChanged
    '    If Me.cmbEmpleado.SelectedIndex >= 0 Then
    '        Me.lblid_empleado.Text = cmbEmpleado.SelectedValue.ToString
    '    End If
    'End Sub

    'Private Sub btnBuscaEmpleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaEmpleado.Click
    '    Dim frmTemporal As New FrmAbmEmpleado
    '    frmTemporal.ShowDialog()
    '    Me.CargarEmpleado()
    '    Me.cmbEmpleado.Focus()
    '    Me.cmbEmpleado.Text = ""
    '    Me.lblid_Empleado.Text = "0"
    'End Sub

    Private Sub cmbDia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdia.SelectedIndexChanged
        If Me.cmbdia.SelectedIndex >= 0 Then
            Me.lblid_dia.Text = cmbdia.SelectedValue.ToString
        End If
        If Not IsNumeric(Me.lblid_dia.Text) Then
            Exit Sub
        End If
        'caso de enfermedad, accidente, feriado, especial
        Select Case CInt(Me.lblid_dia.Text)
            Case 6, 7, 11, 10
                Dim strFecha1 As String = ""
                Dim strFecha2 As String = ""

                strFecha1 = Me.dtpfecha.Value.Date & " 07:30"
                strFecha2 = Me.dtpfecha.Value.Date & " 15:30"

                Me.dtpentrada.Value = CDate(strFecha1)
                Me.dtpsalida.Value = CDate(strFecha2)
                Me.dtpSalida_2.Value = Me.dtpsalida.Value
        End Select
        Me.ControlarHoras()
    End Sub

    Private Sub btnBuscaDia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscadia.Click
        Dim frmTemporal As New frmAbmDia
        frmTemporal.ShowDialog()
        Me.CargarDia()
        Me.cmbdia.Focus()
        Me.cmbdia.Text = ""
        Me.lblid_dia.Text = "0"
    End Sub

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    'Handles 
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles dtpfecha.KeyDown, cmbempleado.KeyDown, cmbdia.KeyDown
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










    Public Sub RefrescarGrilla()
        Dim odt As DataTable

        odt = oCuerpo_movimiento_hora.GetAllMovimiento(CInt(Me.lblid_Movimiento_hora.Text), False)
        Me.dgv1.DataSource = odt
        Me.dgv1.Columns(0).Visible = False
    End Sub

    Public Sub RefrescarGrilla_2()
        Dim odt As DataTable

        odt = oCuerpo_movimiento_hora.GetAllMovimiento(CInt(Me.lblid_Movimiento_hora.Text), True)
        Me.dgv2.DataSource = odt
        Me.dgv2.Columns(0).Visible = False
    End Sub

    Private Sub dgv1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv1.CurrentCellChanged
        Try
            Me.lblid_pk.Text = CStr(Me.dgv1.Item(0, Me.dgv1.CurrentRow.Index).Value)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgv2_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv2.CurrentCellChanged
        Try
            Me.lblid_pk_2.Text = CStr(Me.dgv2.Item(0, Me.dgv1.CurrentRow.Index).Value)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Botones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
    btnAgregar.Click, btnBorrar.Click, btnModificar.Click, btnAgragar2.Click, btnBorrar2.Click, btnModificar2.Click

        Dim btnTemp As New Button
        Dim frmDetalle As New frmDetalleCuerpo_movimiento_hora
        btnTemp = CType(sender, Button)
        Try
            Select Case btnTemp.Name
                Case "btnAgregar"
                    BanderaCuerpo_movimiento_hora = 1
                    Me.AddOwnedForm(frmDetalle)
                    oCuerpo_movimiento_hora.Cargar()
                    oCuerpo_movimiento_hora.Insertar()
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                Case "btnModificar"
                    If Not IsNumeric(Me.lblid_pk.Text) Then
                        Exit Sub
                    End If
                    BanderaCuerpo_movimiento_hora = 2
                    Me.AddOwnedForm(frmDetalle)
                    oCuerpo_movimiento_hora.Modificar(CInt(Me.lblid_pk.Text))
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                    RefrescarGrilla()
                    Me.ControlarHoras()
                    oCuerpo_movimiento_hora.Insertar()
                Case "btnBorrar"
                    If Not IsNumeric(Me.lblid_pk.Text) Then
                        Exit Sub
                    End If

                    If MessageBox.Show("Desea Realmente Eliminar el Registro ", "BORRAR", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                    = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If

                    oCuerpo_movimiento_hora.Borrar(CInt(Me.lblid_pk.Text))
                    RefrescarGrilla()
                    Me.ControlarHoras()
                    oCuerpo_movimiento_hora.Insertar()
                    'Case "btnAyuda"
                    'Process.Start(PathAyuda + "frmAbmMovimiento_hora.avi")
                    'Case "btnSalir"
                    'Me.Close()
                Case "btnAgregar2"
                    BanderaCuerpo_movimiento_hora = 1
                    Me.AddOwnedForm(frmDetalle)
                    oCuerpo_movimiento_hora.Cargar()
                    oCuerpo_movimiento_hora.Insertar()
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                Case "btnModificar2"
                    If Not IsNumeric(Me.lblid_pk_2.Text) Then
                        Exit Sub
                    End If
                    BanderaCuerpo_movimiento_hora = 2
                    Me.AddOwnedForm(frmDetalle)
                    oCuerpo_movimiento_hora.Modificar(CInt(Me.lblid_pk_2.Text))
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                    RefrescarGrilla_2()
                    Me.ControlarHoras()
                    oCuerpo_movimiento_hora.Insertar()
                Case "btnBorrar2"
                    If Not IsNumeric(Me.lblid_pk_2.Text) Then
                        Exit Sub
                    End If

                    If MessageBox.Show("Desea Realmente Eliminar el Registro ", "BORRAR", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                    = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If

                    oCuerpo_movimiento_hora.Borrar(CInt(Me.lblid_pk_2.Text))
                    RefrescarGrilla_2()
                    Me.ControlarHoras()
                    oCuerpo_movimiento_hora.Insertar()
                    'Case "btnAyuda"
                    'Process.Start(PathAyuda + "frmAbmMovimiento_hora.avi")
                    'Case "btnSalir"
                    'Me.Close()
            End Select
            'seteo la bandera para ingresar
            BanderaCuerpo_movimiento_hora = 1


            'Me.txtBuscar.Text = ""
            'Me.txtBuscar.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub








    'Detalle del cuerpo 
    Private Sub frmDetalleCuerpo_movimiento_hora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Me.ttGeneral.SetToolTip(Me.btnBuscaObra, "Buscar Nuevo Obra")
        ' Me.ttGeneral.SetToolTip(Me.btnGuardarCuerpo, "GuardarCuerpo Datos del Cuerpo_movimiento_hora")
        ' Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            ' ObtenerDatosCuerpo()

            ' Me.cmbobra.Text = oActividad_proyecto.GetOne(CInt(Me.lblid_obra.Text)).Rows(0).Item("nombre_actividad").ToString.Trim
        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try

        'Me.lblid_movimiento_hora.Text = CType(Me.Owner, frmDetalleMovimiento_hora).lblid_movimiento_hora.Text

        'If BanderaCuerpo_movimiento_hora = 1 Then
        '    ' Me.LimpiarControlesCuerpo()
        'End If
    End Sub

    Sub CargarCombosCuerpo()
        Me.CargarObra()
    End Sub

    Sub CargarObra()
        Dim odt As New DataTable

        odt = oActividad_proyecto.GetCmb_2
        With Me.cmbobra
            .DataSource = odt
            .DisplayMember = "nombre_actividad_proyecto"
            .ValueMember = "id_actividad_proyecto"
        End With
        If Me.cmbobra.SelectedIndex >= 0 Then
            cmbobra.SelectedIndex = 0
            Me.lblid_obra.Text = cmbobra.SelectedValue.ToString
        End If
    End Sub

    Sub LimpiarControlesCuerpo()
        Me.lblid_obra.Text = "0"
        Me.cmbobra.Text = ""
        ' Me.dtpentrada.Value = DateTime.Now
        '  Me.dtpsalida.Value = DateTime.Now
        'Me.lblid_movimiento_hora.Text = "0"
        'Me.cmbID_Movimiento_hora.Text =  ""
    End Sub

    Private Sub ObtenerDatosCuerpo()
        Me.lblid_obra.Text = oCuerpo_movimiento_hora.id_actividad_proyecto.ToString
        Me.dtpentrada.Value = oCuerpo_movimiento_hora.entrada
        Me.dtpsalida.Value = CDate(oCuerpo_movimiento_hora.salida)
        'Me.lblid_movimiento_hora.Text = oCuerpo_movimiento_hora.id_movimiento_hora.ToString
    End Sub

    Private Sub AsignarDatosCuerpo()
        oCuerpo_movimiento_hora.id_actividad_proyecto = CInt(Me.lblid_obra.Text)
        oCuerpo_movimiento_hora.entrada = Me.dtpentrada.Value
        oCuerpo_movimiento_hora.salida = Me.dtpsalida.Value
        oCuerpo_movimiento_hora.id_movimiento_hora = CInt(Me.lblid_Movimiento_hora.Text)
        'oCuerpo_movimiento_hora.extra = Me.chkEsExtra.Checked
    End Sub

    Public Sub SoloLecturaCuerpo()
        Me.cmbobra.Enabled = False
        Me.btnBuscaobra.Enabled = False
        Me.dtpentrada.Enabled = False
        Me.dtpsalida.Enabled = False
        'Me.cmbMovimiento_hora.Enabled = False
        'Me.btnBuscaMovimiento_hora.Enabled = False
        ' Me.btnGuardarCuerpo.Visible = False
    End Sub

    Private Sub GuardarCuerpo()
        Try
            Me.AsignarDatosCuerpo()
            If oCuerpo_movimiento_hora.Exist() Then
                If BanderaCuerpo_movimiento_hora = 1 Then
                    MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
                    Exit Sub
                ElseIf BanderaCuerpo_movimiento_hora = 2 Then
                    If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                        = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            Select Case BanderaCuerpo_movimiento_hora
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oCuerpo_movimiento_hora.Guardar()

                    If CInt(Me.lblid_Obra_2.Text) > 0 And Me.chkBarraE.Checked = True Then
                        With oCuerpo_movimiento_hora
                            .Cargar()
                            .Insertar()
                            .id_actividad_proyecto = CInt(Me.lblid_Obra_2.Text)
                            .entrada = Me.dtpentrada.Value
                            .salida = Me.dtpSalida_2.Value
                            .id_movimiento_hora = CInt(Me.lblid_Movimiento_hora.Text)
                            '.extra = True
                            .Guardar()
                        End With
                    End If

                    Me.RefrescarGrilla()
                    Me.RefrescarGrilla_2()
                    'CType(Me.Owner, frmDetalleMovimiento_hora).RefrescarGrilla()
                    'Me.CargarCombosCuerpo()
                    oCuerpo_movimiento_hora.Insertar()
                    ' Me.ObtenerDatosCuerpo()
                    Me.LimpiarControlesCuerpo()
                    Me.cmbobra.Focus()
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oCuerpo_movimiento_hora.Guardar()
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ChequearVaciosCuerpo() As Boolean
        Dim bandera As Boolean
        If Me.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    'Private Sub btnGuardarCuerpo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarCuerpo.Click
    '    Dim blnVacios As Boolean

    '    If CDbl(Me.lblid_obra.Text) = 0 Then
    '        MessageBox.Show("Debe Seleccionar un Dato del Combo de obra")
    '        Exit Sub
    '    End If
    '    'If CDbl(Me.lblid_movimiento_hora.Text) = 0 Then
    '    'MessageBox.Show("Debe Seleccionar un Dato del Combo de movimiento_hora")
    '    'Exit Sub
    '    'End If

    '    blnVacios = Me.ChequearVaciosCuerpo
    '    If blnVacios = False Then
    '        MessageBox.Show("Debe Llenar los Campos Obligatorios")
    '        Exit Sub
    '    Else
    '        If BanderaCuerpo_movimiento_hora = 1 Then
    '            Me.GuardarCuerpo()
    '        Else
    '            Me.GuardarCuerpo()
    '        End If
    '    End If
    'End Sub

    Private Sub cmbObra_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbobra.SelectedIndexChanged
        Try
            If Me.cmbobra.SelectedIndex >= 0 Then
                Me.lblid_obra.Text = cmbobra.SelectedValue.ToString
            End If
            If Not IsNumeric(Me.lblid_obra.Text) Then
                Exit Sub
            End If
            odtObra = oActividad_proyecto.GetOne(CInt(Me.lblid_obra.Text))
            ' odtObra_2 = oActividad_proyecto.GetOne_3(CStr(odtObra.Rows(0).Item("nombre_actividad")) & "-E")

            If odtObra_2.Rows.Count > 0 Then
                Me.lblid_Obra_2.Text = odtObra_2.Rows(0).Item("id_actividad_proyecto").ToString()
            Else
                Me.lblid_Obra_2.Text = CStr(0)
            End If

            If odtObra.Rows.Count > 0 Then
                Me.chkEsExtra.Checked = CBool(odtObra.Rows(0).Item("extra"))
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBuscaObra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaobra.Click
        'Dim frmTemporal As New FrmAbmObra
        'frmTemporal.ShowDialog()
        'Me.CargarObra()
        'Me.cmbObra.Focus()
        'Me.cmbObra.Text = ""
        'Me.lblid_Obra.Text = "0"
    End Sub

    Private Sub TabulacionTextBoxCuerpo(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   'Handles 
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombosCuerpo(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
   Handles cmbobra.KeyDown, dtpentrada.KeyDown, dtpsalida.KeyDown, dtpSalida_2.KeyDown
        If CDbl(e.KeyValue.ToString) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub DecimalesCuerpo(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
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



    'botones guardar

    Private Sub btnGuardarUno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarUno.Click
        Dim blnVacios As Boolean
        Dim blnVaciosCuerpo As Boolean

        If CDbl(Me.lblid_empleado.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de empleado")
            Exit Sub
        End If
        If CDbl(Me.lblid_dia.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de dia")
            Exit Sub
        End If

        If CDbl(Me.lblid_obra.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de obra")
            Exit Sub
        End If

        blnVacios = Me.ChequearVacios
        blnVaciosCuerpo = Me.ChequearVaciosCuerpo
        If blnVacios = False Or blnVaciosCuerpo = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaMovimiento_hora = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub


    Private Sub btnGuardarVario1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarVario1.Click
        Dim blnVacios As Boolean

        If CDbl(Me.lblid_empleado.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de empleado")
            Exit Sub
        End If
        If CDbl(Me.lblid_dia.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de dia")
            Exit Sub
        End If

        If CDbl(Me.lblid_obra.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de obra")
            Exit Sub
        End If
        'If CDbl(Me.lblid_movimiento_hora.Text) = 0 Then
        'MessageBox.Show("Debe Seleccionar un Dato del Combo de movimiento_hora")
        'Exit Sub
        'End If

        blnVacios = Me.ChequearVaciosCuerpo
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaCuerpo_movimiento_hora = 1 Then
                Me.GuardarCuerpo()
            Else
                Me.GuardarCuerpo()
            End If
        End If
    End Sub

    Private Sub btnGuardarVario2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarVario2.Click
        Dim blnVacios As Boolean
        Dim blnVaciosCuerpo As Boolean

        If CDbl(Me.lblid_empleado.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de empleado")
            Exit Sub
        End If
        If CDbl(Me.lblid_dia.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de dia")
            Exit Sub
        End If

        'If CDbl(Me.lblid_obra.Text) = 0 Then
        '    MessageBox.Show("Debe Seleccionar un Dato del Combo de obra")
        '    Exit Sub
        'End If

        blnVacios = Me.ChequearVacios
        blnVaciosCuerpo = Me.ChequearVaciosCuerpo
        If blnVacios = False Or blnVaciosCuerpo = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaMovimiento_hora = 1 Then
                Me.GuardarVarios()
            Else
                Me.GuardarVarios()
            End If
        End If
    End Sub



    Private Sub btnControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnControl.Click
        Me.ControlarHoras()
        Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
    End Sub

    Private Sub dtpfecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpfecha.ValueChanged
        Me.dtpentrada.Value = Me.dtpfecha.Value.Date
        Me.dtpsalida.Value = Me.dtpfecha.Value.Date
        Me.dtpSalida_2.Value = Me.dtpfecha.Value.Date
    End Sub

    'atajos
    ''''''''''''''''
    Private Sub btnAtajos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnAtajo1.Click, btnAtajo2.Click, btnAtajo3.Click, btnAtajo4.Click, _
    btnAtajoAccidente.Click, btnAtajoEnfermedad.Click, btnAtajoEspecial.Click, _
    btnAtajoFeriado.Click, btnAtajoFeriadoTrabajado.Click, btnAtajo5.Click
        Dim btnTemp As New Button
        btnTemp = CType(sender, Button)

        Dim strFecha1 As String = ""
        Dim strFecha2 As String = ""
        Select Case btnTemp.Name
            Case "btnAtajo1"
                strFecha1 = Me.dtpfecha.Value.Date & " 07:30"
                strFecha2 = Me.dtpfecha.Value.Date & " 16:30"

                Me.dtpentrada.Value = CDate(strFecha1)
                Me.dtpsalida.Value = CDate(strFecha2)
                Me.dtpSalida_2.Value = Me.dtpsalida.Value
            Case "btnAtajo2"
                strFecha1 = Me.dtpfecha.Value.Date & " 15:00"

                Me.dtpentrada.Value = CDate(strFecha1)
                Me.dtpsalida.Value = DateAdd(DateInterval.Day, 1, Me.dtpfecha.Value.Date)
                Me.dtpSalida_2.Value = Me.dtpsalida.Value
            Case "btnAtajo3"
                strFecha1 = Me.dtpfecha.Value.Date & " 12:00"
                strFecha2 = Me.dtpfecha.Value.Date & " 21:00"

                Me.dtpentrada.Value = CDate(strFecha1)
                Me.dtpsalida.Value = CDate(strFecha2)
                Me.dtpSalida_2.Value = Me.dtpsalida.Value
            Case "btnAtajo4"
                strFecha1 = Me.dtpfecha.Value.Date & " 07:30"
                strFecha2 = Me.dtpfecha.Value.Date & " 15:30"

                Me.dtpentrada.Value = CDate(strFecha1)
                Me.dtpsalida.Value = CDate(strFecha2)
                Me.dtpSalida_2.Value = Me.dtpsalida.Value
            Case "btnAtajo5"
                strFecha1 = Me.dtpfecha.Value.Date & " 22:00"

                Me.dtpentrada.Value = CDate(strFecha1)
                Me.dtpsalida.Value = CDate(DateAdd(DateInterval.Day, 1, Me.dtpfecha.Value.Date) & " 7:00")
                Me.dtpSalida_2.Value = Me.dtpsalida.Value

            Case "btnAtajoAccidente"
                Me.lblid_dia.Text = CStr(7)
            Case "btnAtajoEnfermedad"
                Me.lblid_dia.Text = CStr(6)
            Case "btnAtajoEspecial"
                Me.lblid_dia.Text = CStr(11)
            Case "btnAtajoFeriado"
                Me.lblid_dia.Text = CStr(10)

        End Select

        'codigo compartido
        Select Case btnTemp.Name
            Case "btnAtajoAccidente", "btnAtajoEnfermedad", "btnAtajoEspecial", "btnAtajoFeriado"
                Me.cmbdia.Text = oDia.GetOne(CInt(Me.lblid_dia.Text)).Rows(0).Item("nombre_Dia").ToString.Trim

                strFecha1 = Me.dtpfecha.Value.Date & " 07:30"
                strFecha2 = Me.dtpfecha.Value.Date & " 15:30"

                Me.dtpentrada.Value = CDate(strFecha1)
                Me.dtpsalida.Value = CDate(strFecha2)
                Me.dtpSalida_2.Value = CDate(strFecha2)
            Case "btnAtajoFeriadoTrabajado"
                Me.lblid_dia.Text = "15"
                Me.cmbdia.Text = oDia.GetOne(CInt(Me.lblid_dia.Text)).Rows(0).Item("nombre_Dia").ToString.Trim

                strFecha1 = Me.dtpfecha.Value.Date & " 07:30"
                strFecha2 = Me.dtpfecha.Value.Date & " 15:30"

                Me.dtpentrada.Value = CDate(strFecha1)
                Me.dtpsalida.Value = CDate(strFecha2)
                Me.dtpSalida_2.Value = CDate(strFecha2)
        End Select

        Me.btnGuardarUno.Focus()
    End Sub


    'controla las horas
    Sub ControlarHoras()
        Dim decTotal As Decimal = 0
        Dim decMinuto As Decimal = 0
        Dim decNormal As Decimal = 0
        Dim decExtra As Decimal = 0

        Me.txtHora1.Text = CStr(0)
        Me.txtHora2.Text = CStr(0)
        Me.txtHora3.Text = CStr(0)

        Dim odtGrilla As New DataTable
        odtGrilla = oCuerpo_movimiento_hora.GetAllMovimientoControl(CInt(Me.lblid_Movimiento_hora.Text), Me.chkExtra.Checked)

        For Each row As DataRow In odtGrilla.Rows
            'calcula la cantidad de horas trabajadas
            decMinuto = DateDiff(DateInterval.Minute, CDate(row("entrada")), CDate(row("salida")))
            decTotal = decTotal + CDec(FormatNumber(decMinuto / 60, 1))
        Next

        'calcula la cantidad de horas trabajadas
        decMinuto = DateDiff(DateInterval.Minute, Me.dtpentrada.Value, Me.dtpsalida.Value)

        decTotal = decTotal + CDec(FormatNumber(decMinuto / 60, 1))

        Select Case Me.lblid_dia.Text
            'lunes a jueves
            Case "1"
                If decTotal > 9 Then
                    decExtra = decTotal - 9
                    Me.txtHora1.Text = "9"
                    Me.txtHora2.Text = CStr(decExtra)
                    Me.txtHora3.Text = CStr(decExtra)
                    Me.Label1.Text = "Normales"
                    Me.Label2.Text = "Extras"

                    Me.txtHora1.Visible = True
                    Me.Label1.Visible = True
                    Me.txtHora2.Visible = True
                    Me.txtHora3.Visible = False
                    Me.Label2.Visible = True
                Else
                    Me.txtHora1.Text = CStr(decTotal)
                    Me.Label1.Text = "Normales"

                    Me.txtHora1.Visible = True
                    Me.Label1.Visible = True
                    Me.txtHora2.Visible = True
                    Me.txtHora3.Visible = False
                    Me.Label2.Visible = False
                End If
                'viernes
            Case "2"
                If decTotal > 8 Then
                    decExtra = decTotal - 8
                    Me.txtHora1.Text = "8"
                    Me.txtHora2.Text = CStr(decExtra)
                    Me.txtHora3.Text = CStr(decExtra)
                    Me.Label1.Text = "Normales"
                    Me.Label2.Text = "Extras"

                    Me.txtHora1.Visible = True
                    Me.Label1.Visible = True
                    Me.txtHora2.Visible = True
                    Me.txtHora3.Visible = False
                    Me.Label2.Visible = True
                Else
                    Me.txtHora1.Text = CStr(decTotal)
                    Me.Label1.Text = "Normales"

                    Me.txtHora1.Visible = True
                    Me.Label1.Visible = True
                    Me.txtHora2.Visible = True
                    Me.txtHora3.Visible = True
                    Me.Label2.Visible = False
                End If
                'nocturna
            Case "3"
                If decTotal > 9 Then
                    decExtra = decTotal - 9
                    Me.txtHora1.Text = "9"

                    Me.txtHora2.Text = CStr(decExtra)
                    Me.txtHora3.Text = CStr(decExtra)
                    Me.Label1.Text = "Normales"
                    Me.Label2.Text = "Extras"

                    Me.txtHora1.Visible = True
                    Me.Label1.Visible = True

                    Me.txtHora2.Visible = True
                    Me.txtHora3.Visible = True
                    Me.Label2.Visible = True
                Else
                    Me.txtHora1.Text = CStr(decTotal)
                    Me.Label1.Text = "Normales"

                    Me.txtHora1.Visible = True
                    Me.Label1.Visible = True
                    Me.txtHora2.Visible = False
                    Me.txtHora3.Visible = False
                    Me.Label2.Visible = False
                End If
                'sabados
            Case "4", "17", "18"

                decMinuto = 0
                decTotal = 0
                Dim dec50 As Decimal = 0
                Dim dec100 As Decimal = 0

                Dim dtInicio As DateTime = Me.dtpentrada.Value
                Dim dtFin As DateTime = Me.dtpsalida.Value

                Dim dtAuxI As DateTime = New DateTime(dtpentrada.Value.Year, dtpentrada.Value.Month, dtpentrada.Value.Day, 13, 0, 0)

                If dtInicio < dtAuxI And dtFin <= dtAuxI Then
                    'horas 50
                    decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtFin)
                    dec50 = dec50 + CDec(FormatNumber(decMinuto / 60, 1))
                ElseIf dtInicio < dtAuxI And dtFin > dtAuxI Then
                    'horas 50
                    decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtAuxI)
                    dec50 = dec50 + CDec(FormatNumber(decMinuto / 60, 1))
                    'horas 100
                    decMinuto = DateDiff(DateInterval.Minute, dtAuxI, dtFin)
                    dec100 = dec100 + CDec(FormatNumber(decMinuto / 60, 1))
                ElseIf dtInicio > dtAuxI And dtFin > dtAuxI Then
                    'horas 100
                    decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtFin)
                    dec100 = dec100 + CDec(FormatNumber(decMinuto / 60, 1))
                End If

                Me.txtHora1.Text = CStr(dec50)
                Me.txtHora2.Text = CStr(dec100)
                Me.txtHora3.Text = CStr(dec100)
                Me.Label1.Text = "al 50%"
                Me.Label2.Text = "al 100%"

                Me.txtHora1.Visible = True
                Me.Label1.Visible = True
                Me.txtHora2.Visible = True
                Me.txtHora3.Visible = True
                Me.Label2.Visible = True

                'domingos
            Case "5"
                Me.txtHora1.Text = CStr(decTotal)
                Me.Label1.Text = "al 100%"

                Me.txtHora1.Visible = True
                Me.Label1.Visible = True
                Me.txtHora2.Visible = False
                Me.Label2.Visible = False
                'enfermedad
            Case "6"
                Me.txtHora1.Text = "8"
                Me.Label1.Text = "enfermedad"

                Me.txtHora1.Visible = True
                Me.Label1.Visible = True
                Me.txtHora2.Visible = False
                Me.Label2.Visible = False
                'accidente
            Case "7"
                Me.txtHora1.Text = "8"
                Me.Label1.Text = "accidente"

                Me.txtHora1.Visible = True
                Me.Label1.Visible = True
                Me.txtHora2.Visible = False
                Me.Label2.Visible = False
                'viajes
            Case "8"

                'feriado trabajado
            Case "15"
                If decTotal > 8 Then
                    decExtra = decTotal - 8
                    Me.txtHora1.Text = "8"
                    Me.txtHora2.Text = CStr(decExtra)
                    Me.txtHora3.Text = CStr(decExtra)
                    Me.Label1.Text = "Normales"
                    Me.Label2.Text = "Extras"

                    Me.txtHora1.Visible = True
                    Me.Label1.Visible = True
                    Me.txtHora2.Visible = True
                    Me.txtHora3.Visible = False
                    Me.Label2.Visible = True
                Else

                    Me.txtHora1.Text = CStr(decTotal)
                    Me.Label1.Text = "Normales"

                    Me.txtHora1.Visible = True
                    Me.Label1.Visible = True
                    Me.txtHora2.Visible = True
                    Me.txtHora3.Visible = True
                    Me.Label2.Visible = False
                End If

                'feriado
            Case "10"
                Me.txtHora1.Text = "8"
                Me.Label1.Text = "feriado"

                Me.txtHora1.Visible = True
                Me.Label1.Visible = True
                Me.txtHora2.Visible = False
                Me.Label2.Visible = False
                'especial
            Case "11"
                Me.txtHora1.Text = "8"
                Me.Label1.Text = "especial"

                Me.txtHora1.Visible = True
                Me.Label1.Visible = True
                Me.txtHora2.Visible = False
                Me.Label2.Visible = False

                'nocturna
            Case "16"
                If decTotal > 8 Then
                    decExtra = decTotal - 8
                    Me.txtHora1.Text = "8"

                    Me.txtHora2.Text = CStr(decExtra)
                    Me.txtHora3.Text = CStr(decExtra)
                    Me.Label1.Text = "Normales"
                    Me.Label2.Text = "Extras"

                    Me.txtHora1.Visible = True
                    Me.Label1.Visible = True

                    Me.txtHora2.Visible = True
                    Me.txtHora3.Visible = True
                    Me.Label2.Visible = True
                Else
                    Me.txtHora1.Text = CStr(decTotal)
                    Me.Label1.Text = "Normales"

                    Me.txtHora1.Visible = True
                    Me.Label1.Visible = True
                    Me.txtHora2.Visible = False
                    Me.txtHora3.Visible = False
                    Me.Label2.Visible = False
                End If
        End Select
    End Sub

    'controla las horas
    Sub ControlarHoras_2()
        Dim decTotal As Decimal = 0
        Dim decMinuto As Decimal = 0
        Dim decNormal As Decimal = 0
        Dim decExtra As Decimal = 0

        'agregado
        Me.txtHora1.Text = CStr(0)
        Me.txtHora2.Text = CStr(0)
        '''''''
        Me.txtHora3.Text = CStr(0)

        Dim odtGrilla As New DataTable
        odtGrilla = oCuerpo_movimiento_hora.GetAllMovimientoControl(CInt(Me.lblid_Movimiento_hora.Text), Me.chkExtra.Checked)

        For Each row As DataRow In odtGrilla.Rows
            'calcula la cantidad de horas trabajadas
            decMinuto = DateDiff(DateInterval.Minute, CDate(row("entrada")), CDate(row("salida")))
            decTotal = decTotal + CDec(FormatNumber(decMinuto / 60, 1))
        Next

        'calcula la cantidad de horas trabajadas
        decMinuto = DateDiff(DateInterval.Minute, Me.dtpentrada.Value, Me.dtpSalida_2.Value)

        decTotal = decTotal + CDec(FormatNumber(decMinuto / 60, 1))

        Select Case Me.lblid_dia.Text
            'lunes a jueves
            Case "1"
                If decTotal > 9 Then
                    decExtra = decTotal - 9
                    Me.txtHora1.Text = "9"
                    Me.txtHora3.Text = CStr(decExtra)
                    Me.Label1.Text = "Normales"
                    Me.Label2.Text = "Extras"

                    Me.txtHora1.Visible = True
                    Me.Label1.Visible = True
                    Me.txtHora3.Visible = True
                    Me.txtHora3.Visible = True
                    Me.Label2.Visible = True
                Else
                    Me.txtHora1.Text = CStr(decTotal)
                    Me.Label1.Text = "Normales"

                    Me.txtHora1.Visible = True
                    Me.Label1.Visible = True

                    Me.txtHora3.Visible = True
                    Me.Label2.Visible = False
                End If
                'viernes
            Case "2"
                If decTotal > 8 Then
                    decExtra = decTotal - 8
                    Me.txtHora1.Text = "8"

                    Me.txtHora3.Text = CStr(decExtra)
                    Me.Label1.Text = "Normales"
                    Me.Label2.Text = "Extras"

                    Me.txtHora1.Visible = True
                    Me.Label1.Visible = True

                    Me.txtHora3.Visible = True
                    Me.Label2.Visible = True
                Else
                    Me.txtHora1.Text = CStr(decTotal)
                    Me.Label1.Text = "Normales"

                    Me.txtHora1.Visible = True
                    Me.Label1.Visible = True

                    Me.Label2.Visible = False
                End If
                'nocturna
            Case "3"
                If decTotal > 9 Then
                    decExtra = decTotal - 9
                    Me.txtHora1.Text = "9"

                    Me.txtHora3.Text = CStr(decExtra)
                    Me.Label1.Text = "Normales"
                    Me.Label2.Text = "Extras"

                    Me.txtHora1.Visible = True
                    Me.Label1.Visible = True

                    Me.txtHora3.Visible = True
                    Me.Label2.Visible = True
                Else
                    Me.txtHora1.Text = CStr(decTotal)
                    Me.Label1.Text = "Normales"

                    Me.txtHora1.Visible = True
                    Me.Label1.Visible = True
                    Me.txtHora3.Visible = False
                    Me.txtHora3.Visible = False
                    Me.Label2.Visible = False
                End If
                'sabados
            Case "4"
                decMinuto = 0
                decTotal = 0
                Dim dec50 As Decimal = 0
                Dim dec100 As Decimal = 0

                Dim dtInicio As DateTime = Me.dtpentrada.Value
                Dim dtFin As DateTime = Me.dtpsalida.Value

                Dim dtAuxI As DateTime = New DateTime(dtpentrada.Value.Year, dtpentrada.Value.Month, dtpentrada.Value.Day, 13, 0, 0)

                If dtInicio < dtAuxI And dtFin <= dtAuxI Then
                    'horas 50
                    decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtFin)
                    dec50 = dec50 + CDec(FormatNumber(decMinuto / 60, 1))
                ElseIf dtInicio < dtAuxI And dtFin > dtAuxI Then
                    'horas 50
                    decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtAuxI)
                    dec50 = dec50 + CDec(FormatNumber(decMinuto / 60, 1))
                    'horas 100
                    decMinuto = DateDiff(DateInterval.Minute, dtAuxI, dtFin)
                    dec100 = dec100 + CDec(FormatNumber(decMinuto / 60, 1))
                ElseIf dtInicio > dtAuxI And dtFin > dtAuxI Then
                    'horas 100
                    decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtFin)
                    dec100 = dec100 + CDec(FormatNumber(decMinuto / 60, 1))
                End If

                Me.txtHora1.Text = CStr(dec50)
                Me.txtHora3.Text = CStr(dec100)
                'Me.Label1.Text = CStr(dec50)
                'Me.Label2.Text = CStr(dec100)
                Me.Label1.Text = "al 50%"
                Me.Label2.Text = "al 100%"

                Me.txtHora1.Visible = True
                Me.Label1.Visible = True
                Me.txtHora3.Visible = True
                Me.Label2.Visible = True

                'domingos
            Case "5"
                Me.txtHora1.Text = CStr(decTotal)
                Me.Label1.Text = "al 100%"

                Me.txtHora1.Visible = True
                Me.Label1.Visible = True
                Me.txtHora3.Visible = False
                Me.Label2.Visible = False
                'enfermedad
            Case "6"
                Me.txtHora1.Text = "8"
                Me.Label1.Text = "enfermedad"

                Me.txtHora1.Visible = True
                Me.Label1.Visible = True
                Me.txtHora3.Visible = False
                Me.Label2.Visible = False
                'accidente
            Case "7"
                Me.txtHora1.Text = "8"
                Me.Label1.Text = "accidente"

                Me.txtHora1.Visible = True
                Me.Label1.Visible = True
                Me.txtHora3.Visible = False
                Me.Label2.Visible = False
                'viajes
            Case "8"

                'feriado trabajado
            Case "15"
                If decTotal > 8 Then
                    decExtra = decTotal - 8
                    Me.txtHora1.Text = "8"

                    Me.txtHora3.Text = CStr(decExtra)
                    Me.Label1.Text = "Normales"
                    Me.Label2.Text = "Extras"

                    Me.txtHora1.Visible = True
                    Me.Label1.Visible = True

                    Me.txtHora3.Visible = True
                    Me.Label2.Visible = True
                Else
                    Me.txtHora1.Text = CStr(decTotal)
                    Me.Label1.Text = "Normales"

                    Me.txtHora1.Visible = True
                    Me.Label1.Visible = True

                    Me.Label2.Visible = False
                End If

                'feriado
            Case "10"
                Me.txtHora1.Text = "8"
                Me.Label1.Text = "feriado"

                Me.txtHora1.Visible = True
                Me.Label1.Visible = True
                Me.txtHora3.Visible = False
                Me.Label2.Visible = False
                'especial
            Case "11"
                Me.txtHora1.Text = "8"
                Me.Label1.Text = "especial"

                Me.txtHora1.Visible = True
                Me.Label1.Visible = True
                Me.txtHora3.Visible = False
                Me.Label2.Visible = False
        End Select
    End Sub
    Private Sub dtpentrada_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpentrada.ValueChanged
        Me.ControlarHoras()
    End Sub

    Private Sub dtpsalida_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpsalida.ValueChanged
        Dim intDif As Integer = 0
        intDif = Me.dtpsalida.Value.TimeOfDay.CompareTo(Me.dtpentrada.Value.TimeOfDay)

        If intDif < 0 Then
            Me.dtpsalida.Value = CDate(DateAdd(DateInterval.Day, 1, Me.dtpfecha.Value.Date) & " " & Me.dtpsalida.Value.Hour & ":" & Me.dtpsalida.Value.Minute)
        Else
            Me.dtpsalida.Value = CDate(Me.dtpfecha.Value.Date & " " & Me.dtpsalida.Value.Hour & ":" & Me.dtpsalida.Value.Minute)
        End If
        Me.BanderaHoraSalida = False
        Me.ControlarHoras()
    End Sub

    Private Sub dtpsalida_2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpSalida_2.ValueChanged
        Dim intDif As Integer = 0
        intDif = Me.dtpSalida_2.Value.TimeOfDay.CompareTo(Me.dtpentrada.Value.TimeOfDay)

        If intDif < 0 Then
            Me.dtpSalida_2.Value = CDate(DateAdd(DateInterval.Day, 1, Me.dtpfecha.Value.Date) & " " & Me.dtpSalida_2.Value.Hour & ":" & Me.dtpSalida_2.Value.Minute)
        Else
            Me.dtpSalida_2.Value = CDate(Me.dtpfecha.Value.Date & " " & Me.dtpSalida_2.Value.Hour & ":" & Me.dtpSalida_2.Value.Minute)
        End If
        Me.BanderaHoraSalida = True
        Me.ControlarHoras_2()
    End Sub

    Private Sub chkBarraE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBarraE.CheckedChanged
        If Me.chkBarraE.Checked = True Then
            Me.Height = 658
        End If
        If Me.chkBarraE.Checked = False Then
            'Me.Height = 530
            Me.Height = 698
        End If
    End Sub

  

End Class
