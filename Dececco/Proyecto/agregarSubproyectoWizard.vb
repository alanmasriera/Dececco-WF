Public Class agregarSubproyectoWizard
    ReadOnly _myPanels As List(Of Panel) = New List(Of Panel)
    Dim _count As Integer = 0
    ReadOnly _idProyecto As Integer
    ReadOnly _idSubproyecto As Integer
    ReadOnly _nuevoSubproyecto As New entSubproyecto
    ReadOnly _subproyectPadre As New entSubproyecto
    ReadOnly _tipoSubproyecto As New entTipo_Subproyecto
    ReadOnly _proyecto As New Proyecto

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancelar.Click
        Close()
    End Sub

    Private Sub bntPrevious_Click(sender As System.Object, e As System.EventArgs) Handles btn_anterior.Click

        If _count = 0 Then
            Exit Sub
        End If

        If _count > 0 Then
            _count -= 1
        Else
            _count = _myPanels.Count - 1
        End If
        _myPanels(_count).BringToFront()
    End Sub

    Public Sub New(ByVal id_proyecto As Integer, ByVal id_subproyecto As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        _myPanels.Add(Panel1)
        _myPanels.Add(Panel2)
        _myPanels.Add(Panel3)
        _myPanels.Add(Panel4)

        Me._idProyecto = id_proyecto
        Me._idSubproyecto = id_subproyecto

        _myPanels(_count).BringToFront()

        lbl_horas_disponibles.Text = _proyecto.ObtenerHorasDisponiblesProyecto(id_proyecto).ToString()

    End Sub

    Private Sub btn_siguiente_Click(sender As Object, e As EventArgs) Handles btn_siguiente.Click
        If _count < _myPanels.Count - 1 Then
            _count += 1
            If _myPanels(_count) Is Panel2 Then
                ActualizarCantidadSubrpoyectos()
            End If
            If _myPanels(_count) Is Panel4 Then
                btn_siguiente.Name = "Aceptar"
            Else
                btn_siguiente.Name = "Siguiente"
            End If
        Else ''Finalizar
            _count = _myPanels.Count - 1
            Me.Guardar()
        End If
        _myPanels(_count).BringToFront()
    End Sub

    Private Sub ActualizarCantidadSubrpoyectos()

        Dim horaTipo As New entTipo_Subproyecto
        Dim odt As DataTable = horaTipo.GetHorasTipoProyecto(CInt(cmb_tipo_subproyecto.SelectedValue))
        odt.Rows.Add(0, 0, "Otro", 1)

        CType(dgv_subproyectos.Columns("id_hora_tipo_subproyecto"), DataGridViewComboBoxColumn).DataSource = odt
        CType(dgv_subproyectos.Columns("id_hora_tipo_subproyecto"), DataGridViewComboBoxColumn).DisplayMember = "nombre"
        CType(dgv_subproyectos.Columns("id_hora_tipo_subproyecto"), DataGridViewComboBoxColumn).ValueMember = "id_hora_tipo_subproyecto"


        dgv_subproyectos.Rows.Clear()
        For i = 1 To txt_cantidad.Value
            Me.dgv_subproyectos.Rows.Add(0, txt_nombre.Text & " " & i, 0, 1)
        Next

    End Sub

    Private Sub Guardar()
        Dim controlSubproyecto As New Control_Subproyecto

        _proyecto.Modificar(_idProyecto)

        If _idSubproyecto > 1 Then
            _subproyectPadre.Modificar(_idSubproyecto)
        End If


        For I = 0 To dgv_subproyectos.Rows.Count - 1
            With _nuevoSubproyecto
                .Cargar()
                .Insertar()
                .nombre = dgv_subproyectos.Rows.Item(I).Cells().Item("nombre_subproyecto").Value.ToString()
                .horas_estimadas = Convert.ToInt32(dgv_subproyectos.Rows.Item(I).Cells().Item("Horas").Value)
                .id_tipo_subproyecto = CInt(cmb_tipo_subproyecto.SelectedValue)
                .fecha_inicio_estimada = Date.Now
                .fecha_fin_estimada = Date.Now
                .orden = 99999
                .id_hora_tipo_subproyecto = CInt(Me.dgv_subproyectos.Rows.Item(I).Cells().Item("id_hora_tipo_subproyecto").Value)
                .ot = 0
                .genera_ot = chk_genera_ot.Checked
                .asignacion_automatica = True


                If Me._idSubproyecto = 0 Then
                    .id_subproyecto_padre = 1
                    .id_proyecto = Me._idProyecto
                Else
                    .id_subproyecto_padre = Me._idSubproyecto
                    .id_proyecto = Me._idProyecto
                End If
                .Guardar()
                If _idSubproyecto > 1 Then
                    If (_subproyectPadre.asignacion_automatica) Then
                        Me.AsignarAutomatica(.id_suproyecto)
                    End if
                End If
                If .genera_ot Then
                    .AgregarOT(.id_suproyecto)
                Else
                    .ObtenerOTPadre(.id_suproyecto)
                End If
                .Guardar()
                .Modificar(.id_suproyecto)
            End With

            Dim id_Actividad_actual As Integer

            For Each row As DataGridViewRow In dgv_actividades_subproyecto.Rows
                With oActividad
                    .Cargar()
                    .Insertar()
                    .id_tipo_actividad = CInt(row.Cells("id_tipo_actividad").Value)
                    .nombre_actividad = CStr(row.Cells("nombre_actividad").Value)
                    .costo_standart = CDec(row.Cells("Peso").Value) 'PESO
                    .tiempo_standart = 0
                    .Guardar()
                    id_Actividad_actual = .id_actividad

                    With oActividad_proyecto
                        .Cargar()
                        .Insertar()
                        .avance = 0
                        .cantidad_hora = 0
                        .complejidad = 0
                        .orden = row.Index + 1
                        .fecha_inicio = _nuevoSubproyecto.fecha_fin_estimada

                        If row.Cells("fecha_fin_actividad").Value Is Nothing Then
                            .forzada_fecha_fin = False
                            .fecha_fin_previsto = _nuevoSubproyecto.fecha_fin_estimada
                        ElseIf row.Cells("fecha_fin_actividad").Value IsNot Nothing And row.Cells("fecha_fin_actividad").Value.ToString() = "" Then
                            .forzada_fecha_fin = False
                            .fecha_fin_previsto = _nuevoSubproyecto.fecha_fin_estimada
                        Else
                            .forzada_fecha_fin = True
                            .fecha_fin_previsto = CDate(row.Cells("fecha_fin_actividad").Value)
                        End If

                        .id_cliente = 0
                        .id_proyecto = Me._idProyecto
                        .id_subproyecto = _nuevoSubproyecto.id_suproyecto
                        .id_actividad = id_Actividad_actual
                        .id_control = 0
                        .id_controlador_1 = 0
                        .id_controlador_2 = 0
                        .porcentaje_avance = 0
                        .asignada = False
                        .Guardar()
                    End With

                End With
            Next


            For Each row As DataGridViewRow In Me.dgv_controles_subproyecto.Rows
                If row.Cells("nombre_control_subproyecto").Value IsNot Nothing Then
                    With controlSubproyecto
                        .Cargar()
                        .Insertar()
                        .id_control = CInt(row.Cells("nombre_control_subproyecto").Value)
                        .id_subproyecto = _nuevoSubproyecto.id_suproyecto
                        .id_tipo_actividad = CInt(row.Cells("id_tipo_actividad_control_subproyecto").Value)
                        If .id_control <> 0 Then
                            .Guardar()
                        End If
                    End With
                End If
            Next

        Next

        Me.Close()
    End Sub

    Private Sub AsignarAutomatica(ByVal id_subproyecto_nuevo As Integer)
        Dim subproyecto As New entSubproyecto

        With subproyecto
            .Cargar()
            .Modificar(id_subproyecto_nuevo)
            .asignacion_automatica = True
            .Guardar()
        End With

        Dim odt As DataTable
        odt = oActividad_proyecto.GetAllSubproyectoConHijos(id_subproyecto_nuevo)

        Dim actividadProyecto As New Actividad_proyecto
        Dim usuarioProyecto As New Usuario_Proyecto
        Dim tipoActividadUsuario As New Tipo_Actividad_Usuario
        Dim actividad As New Actividad
        Dim odtMiembros As DataTable
        Dim detalleRecurso As New Detalle_recurso
        Dim asignacionesUsuario As DataTable

        For Each row As DataRow In odt.Rows
            With actividadProyecto
                .Cargar()
                .Modificar(CInt(row.Item("id_actividad_proyecto")))

                With actividad
                    .Cargar()
                    .Modificar(actividadProyecto.id_actividad)
                End With

                If .asignada = False Then
                    With subproyecto
                        .Cargar()
                        .Modificar(actividadProyecto.id_subproyecto)
                        'odtMiembros = usuarioProyecto.GetCmb(Me._idProyecto, actividadProyecto.id_subproyecto, 1)
                        .asignacion_automatica = True
                        .Guardar()

                        'If odtMiembros.Rows.Count = 0 Then
                        '    odtMiembros = usuarioProyecto.GetCmb(Me._idProyecto, actividadProyecto.id_subproyecto, 0)
                        'End If

                        'For Each rowMiembro As DataRow In odtMiembros.Rows
                        '    asignacionesUsuario = tipoActividadUsuario.GetFromUsuario(CInt(rowMiembro.Item("id_usuario")))
                        '    For Each rowAsignacion As DataRow In asignacionesUsuario.Rows

                        '        With tipoActividadUsuario
                        '            .Cargar()
                        '            .Modificar(CInt(rowAsignacion.Item("id_tipo_actividad_usuario")))
                        '        End With

                        '        If tipoActividadUsuario.id_tipo_actividad = actividad.id_tipo_actividad Then
                        '            If tipoActividadUsuario.habilitado = True Then
                        '                With detalleRecurso
                        '                    .Cargar()
                        '                    .Insertar()
                        '                    .realizada = False
                        '                    .tipo = "automatico"
                        '                    .porcentaje_avance = 0
                        '                    .id_actividad_proyecto = actividadProyecto.id_actividad_proyecto
                        '                    .motivo = ""
                        '                    .cantidad_hora = actividadProyecto.cantidad_hora
                        '                    If .cantidad_hora = 0 Then
                        '                        .cantidad_hora = 0.1D
                        '                    End If
                        '                    .id_usuario = CInt(rowMiembro.Item("id_usuario"))
                        '                    .Guardar()
                        '                End With
                        '            End If
                        '        End If
                        '    Next
                        'Next
                    End With
                End If
            End With
        Next
    End Sub

    Private Sub agregarSubproyectoWizard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarComboTipoSubproyecto()
    End Sub

    Private Sub CargarComboTipoSubproyecto()

        cmb_tipo_subproyecto.DataSource = _tipoSubproyecto.GetCMB_TipoSubproyecto()
        cmb_tipo_subproyecto.ValueMember = "id_tipo_subproyecto"
        cmb_tipo_subproyecto.DisplayMember = "nombre_tipo_subproyecto"

        cmb_actividad_subproyecto.DataSource = oActividad.GetTipoActividad()
        cmb_actividad_subproyecto.ValueMember = "id_tipo_actividad"
        cmb_actividad_subproyecto.DisplayMember = "descripcion"

        cmb_actividad_control_subproyecto.DataSource = oActividad.GetTipoActividad()
        cmb_actividad_control_subproyecto.ValueMember = "id_tipo_actividad"
        cmb_actividad_control_subproyecto.DisplayMember = "descripcion"

        Dim odt As DataTable
        odt = oControl.GetCmb()

        cmb_control.DataSource = odt
        cmb_control.ValueMember = "id_control"
        cmb_control.DisplayMember = "nombre_control"

        odt = oControl.GetCmb()
        odt.Rows.Add(0, "", 0)

        CType(dgv_controles_subproyecto.Columns("nombre_control_subproyecto"), DataGridViewComboBoxColumn).DataSource = odt
        CType(dgv_controles_subproyecto.Columns("nombre_control_subproyecto"), DataGridViewComboBoxColumn).DisplayMember = "nombre_control"
        CType(dgv_controles_subproyecto.Columns("nombre_control_subproyecto"), DataGridViewComboBoxColumn).ValueMember = "id_control"

    End Sub

    Private Sub CargarActividades()
        Dim dt As DataTable

        Dim row_index As Integer

        dt = _tipoSubproyecto.GetActividadesTipoProyecto(CInt(Me.cmb_tipo_subproyecto.SelectedValue))
        Me.dgv_actividades_subproyecto.Rows.Clear()
        For Each row As DataRow In dt.Rows
            row_index = dgv_actividades_subproyecto.Rows.Add()
            dgv_actividades_subproyecto.Rows(row_index).Cells("id_tipo_actividad").Value = row.Item("id_tipo_actividad").ToString()
            dgv_actividades_subproyecto.Rows(row_index).Cells("nombre_actividad").Value = row.Item("descripcion").ToString()
            dgv_actividades_subproyecto.Rows(row_index).Cells("Peso").Value = CDec(row.Item("criticidad"))

        Next

        Me.ActualizarPesos()

    End Sub

    Private Sub ActualizarPesos()

        Dim totalPeso As Decimal = 0

        For Each row As DataGridViewRow In dgv_actividades_subproyecto.Rows
            totalPeso = totalPeso + CDec(row.Cells("Peso").Value)
        Next


        For Each row As DataGridViewRow In dgv_actividades_subproyecto.Rows
            If totalPeso >0 Then
                row.Cells("Peso").Value = CDec(row.Cells("Peso").Value) / totalPeso * 100
            End If            
        Next

    End Sub

    Private Sub btn_agregar_actividad_subproyecto_Click(sender As Object, e As EventArgs) Handles btn_agregar_actividad_subproyecto.Click
        'Me.dgv_actividades_subproyecto.Rows.Add(cmb_actividad_subproyecto.SelectedValue, oTipo_actividad.GetOne(CInt(cmb_actividad_subproyecto.SelectedValue)).Rows(0).Item("descripcion").ToString(), oTipo_actividad.GetOne(CInt(cmb_actividad_subproyecto.SelectedValue)).Rows(0).Item("criticidad").ToString())

        Dim drIndex As Integer
        drIndex = Me.dgv_actividades_subproyecto.Rows.Add()
        With Me.dgv_actividades_subproyecto.Rows(drIndex)
            .Cells("id_tipo_actividad").Value = cmb_actividad_subproyecto.SelectedValue
            .Cells("nombre_Actividad").Value = Me.cmb_actividad_subproyecto.Text
            .Cells("Peso").Value = oTipo_actividad.GetOne(CInt(cmb_actividad_subproyecto.SelectedValue)).Rows(0).Item("criticidad").ToString()
            If Me.chk_forzar_fecha_fin_actividad.Checked Then
                .Cells("fecha_fin_actividad").Value = Me.dtp_fecha_fin_actividad.Value
            Else
                .Cells("fecha_fin_actividad").Value = ""
            End If
        End With

        Me.ActualizarPesos()
        Me.PesosCorrectosSubproyceto()
    End Sub

    Private Sub cmb_tipo_subproyecto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tipo_subproyecto.SelectedIndexChanged
        Try
            Me.CargarActividades()
            Me.PesosCorrectosSubproyceto()
            Me.txt_nombre.Text = Me.cmb_tipo_subproyecto.Text
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dgv_actividades_subproyecto_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_actividades_subproyecto.CellEndEdit
        Me.PesosCorrectosSubproyceto()
    End Sub

    Private Function PesosCorrectosSubproyceto() As Boolean

        Dim totalPeso As Decimal = 0

        For Each row As DataGridViewRow In dgv_actividades_subproyecto.Rows
            totalPeso = totalPeso + CDec(row.Cells("Peso").Value)
        Next

        Me.lbl_suma_pesos_subproyecto.Text = totalPeso.ToString("0.00")

        If totalPeso < 99 And totalPeso <> 0 Or totalPeso > 101 And totalPeso <> 0 Then
            Me.lbl_suma_pesos_subproyecto.ForeColor = Color.OrangeRed
        Else
            Me.lbl_suma_pesos_subproyecto.ForeColor = Color.Green
        End If

        If (totalPeso > 98 And totalPeso < 102) Or totalPeso = 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub dgv_actividades_subproyecto_MouseDown(sender As Object, e As MouseEventArgs) Handles dgv_actividades_subproyecto.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim currentMouseOverRow As Integer
            currentMouseOverRow = dgv_actividades_subproyecto.HitTest(e.X, e.Y).RowIndex

            If currentMouseOverRow >= 0 Then
                dgv_actividades_subproyecto.ClearSelection()
                dgv_actividades_subproyecto.Rows(currentMouseOverRow).Selected = True
                ts_actividad_subproyecto.Show(dgv_actividades_subproyecto, New Point(e.X, e.Y))
            End If
        End If
    End Sub

    Private Sub ts_borrar_actividad_subproyecto_Click(sender As Object, e As EventArgs) Handles ts_borrar_actividad_subproyecto.Click
        If dgv_actividades_subproyecto.SelectedRows.Count > 0 Then

            dgv_actividades_subproyecto.Rows.Remove(dgv_actividades_subproyecto.SelectedRows(0))

        End If
    End Sub


    Private Sub btn_agregar_control_subproyecto_Click(sender As Object, e As EventArgs) Handles btn_agregar_control_subproyecto.Click
        If Me.cmb_control.SelectedValue IsNot Nothing And Me.cmb_actividad_control_subproyecto.SelectedValue IsNot Nothing Then

            For Each row As DataGridViewRow In Me.dgv_controles_subproyecto.Rows
                If CInt(row.Cells("id_tipo_actividad_control_subproyecto").Value) = CInt(Me.cmb_actividad_control_subproyecto.SelectedValue) Then
                    Exit Sub
                End If
            Next

            Dim index As Integer
            index = Me.dgv_controles_subproyecto.Rows.Add()
            Me.dgv_controles_subproyecto.Rows(index).Cells("id_tipo_actividad_control_subproyecto").Value = CInt(Me.cmb_actividad_control_subproyecto.SelectedValue)
            Me.dgv_controles_subproyecto.Rows(index).Cells("nombre_actividad_control_subproyecto").Value = cmb_actividad_control_subproyecto.Text
            Me.dgv_controles_subproyecto.Rows(index).Cells("nombre_control_subproyecto").Value = CInt(cmb_control.SelectedValue)

        End If
    End Sub

    Private Sub dgv_subproyectos_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgv_subproyectos.CellValidating
        If dgv_subproyectos.Rows.Count > 0 Then
            If e.ColumnIndex = dgv_subproyectos.Columns.Item("id_hora_tipo_subproyecto").Index Then
                Dim val As Integer = CInt(dgv_subproyectos.Rows(e.RowIndex).Cells("id_hora_tipo_subproyecto").Value)
                If val <> 0 Then
                    Dim horaTipo As New entHora_Tipo_Subproyecto
                    horaTipo.Cargar()
                    horaTipo.Modificar(val)
                    dgv_subproyectos.Rows(e.RowIndex).Cells("Horas").Value = horaTipo.horas
                    dgv_subproyectos.Columns().Item("Horas").ReadOnly = True
                Else
                    dgv_subproyectos.Columns().Item("Horas").ReadOnly = False
                End If
            End If
        End If
    End Sub

    Private Sub dgv_subproyectos_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgv_subproyectos.CurrentCellDirtyStateChanged
        If dgv_subproyectos.Rows.Count > 0 Then
            If dgv_subproyectos.CurrentCell.ColumnIndex = dgv_subproyectos.Columns.Item("id_hora_tipo_subproyecto").Index Then
                Dim val As Integer = CInt(dgv_subproyectos.CurrentRow.Cells("id_hora_tipo_subproyecto").Value)
                If val <> 0 Then
                    Dim horaTipo As New entHora_Tipo_Subproyecto
                    horaTipo.Cargar()
                    horaTipo.Modificar(val)
                    dgv_subproyectos.CurrentRow.Cells("Horas").Value = horaTipo.horas
                    dgv_subproyectos.Columns().Item("Horas").ReadOnly = True
                Else
                    dgv_subproyectos.Columns().Item("Horas").ReadOnly = False
                End If
            End If
        End If
    End Sub

    Private Sub chk_forzar_fecha_fin_actividad_CheckedChanged(sender As Object, e As EventArgs) Handles chk_forzar_fecha_fin_actividad.CheckedChanged
        Me.dtp_fecha_fin_actividad.Enabled = Me.chk_forzar_fecha_fin_actividad.Checked
    End Sub


    Private Sub btnBorrarControlActividad_Click(sender As Object, e As EventArgs) Handles btnBorrarControlActividad.Click
        For Each oneCell As DataGridViewRow in dgv_controles_subproyecto.SelectedRows
    
        If oneCell.Selected Then
            dgv_controles_subproyecto.Rows.RemoveAt(oneCell.Index)
                End If
    Next
    End Sub
End Class