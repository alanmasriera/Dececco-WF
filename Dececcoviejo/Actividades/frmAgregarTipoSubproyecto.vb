Public Class frmAgregarTipoSubproyecto
    Dim _Tipo_Subproyecto As New entTipo_Subproyecto
    Dim _SelectedRow As DataGridViewRow
    Dim _selected_horas_row As DataGridViewRow
    Private Sub frmAgregarTipoActividad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargarExistentes()
        Me.cargarActividades()
    End Sub

    Private Sub cargarExistentes()
        Me.dgv_tipos_subproyecto.Rows.Clear()

        Dim dt As DataTable
        dt = _Tipo_Subproyecto.Buscar(Me.txt_buscar_nombre_tipo_subroyecto.Text)

        If dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                Me.dgv_tipos_subproyecto.Rows.Add(CInt(row.Item("id_tipo_subproyecto").ToString()), row.Item("nombre_tipo_subproyecto").ToString())
            Next
        End If
    End Sub

    Private Sub cargarActividades()
        Me.cmb_actividades.DataSource = oActividad.GetTipoActividad()
        Me.cmb_actividades.ValueMember = "id_tipo_actividad"
        Me.cmb_actividades.DisplayMember = "descripcion"
    End Sub

    Private Sub btn_agregar_actividad_Click(sender As Object, e As EventArgs) Handles btn_agregar_actividad.Click
        Dim _actividad_tipo_subproyecto As New entActividad_Tipo_Subproyecto()

        With _actividad_tipo_subproyecto
            .Cargar()
            .Insertar()
            .id_tipo_subproyecto = _Tipo_Subproyecto.id_tipo_subproyecto
            .id_tipo_actividad = CInt(cmb_actividades.SelectedValue)
            If dgv_tipos_actividad.Rows.Count = 0 Then
                .orden = 1
            Else
                .orden = Me.dgv_tipos_actividad.Rows.Count + 1
            End If
            .Guardar()
        End With
        Me.cargarActividadesTipoProyecto()

    End Sub


    Private Sub cargarActividadesTipoProyecto()
        Dim dt As DataTable
        dt = _Tipo_Subproyecto.GetActividadesTipoProyecto(_Tipo_Subproyecto.id_tipo_subproyecto)

        Me.dgv_tipos_actividad.Rows.Clear()
        If dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                Me.dgv_tipos_actividad.Rows.Add(row.Item("id_actividad_tipo_subproyecto").ToString(), row.Item("id_tipo_actividad").ToString(), row.Item("descripcion").ToString())
            Next
        End If

    End Sub

    Private Sub cargarHorasTipoProyecto()
        Dim dt As DataTable
        dt = _Tipo_Subproyecto.GetHorasTipoProyecto(_Tipo_Subproyecto.id_tipo_subproyecto)

        Me.dgv_horas_subproyecto.Rows.Clear()
        If dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                Me.dgv_horas_subproyecto.Rows.Add(row.Item("id_hora_tipo_subproyecto").ToString(), row.Item("nombre").ToString(), row.Item("horas").ToString())
            Next
        End If

    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        limpiarControles()

        With _Tipo_Subproyecto
            .Cargar()
            .Insertar()
            .nombre_tipo_subproyecto = "Nuevo Tipo Subproyecto"
            .Guardar()
        End With

        Me.txt_nombre_tipo_subproyecto.Text = _Tipo_Subproyecto.nombre_tipo_subproyecto
        Me.txt_nombre_tipo_subproyecto.Focus()
        Me.cargarExistentes()

        Me.dgv_tipos_subproyecto.ClearSelection()

        If _SelectedRow Is Nothing = False Then
            For Each cell As DataGridViewCell In _SelectedRow.Cells
                cell.Style.BackColor = Color.White
            Next
            _SelectedRow = Nothing
        End If

    End Sub

    Private Sub limpiarControles()
        Me.txt_descripcion_tipo_subproyecto.Text = ""
        Me.txt_nombre_tipo_subproyecto.Text = ""
        Me.cmb_actividades.SelectedIndex = 0
        Me.dgv_tipos_actividad.Rows.Clear()
        Me.txt_nombre_hora_tipo_subproyecto.Text = ""
        Me.txt_num_horas.Value = 20
        Me.dgv_horas_subproyecto.Rows.Clear()

        Me.group_horas.Enabled = True
        Me.group_propiedades.Enabled = True

        Me._selected_horas_row = Nothing
        Me.btn_agregar_horas.Text = "Agregar"

    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If _Tipo_Subproyecto.id_tipo_subproyecto <> 0 Then
            With _Tipo_Subproyecto
                .Modificar(.id_tipo_subproyecto)
                .nombre_tipo_subproyecto = Me.txt_nombre_tipo_subproyecto.Text
                .descripcion = Me.txt_descripcion_tipo_subproyecto.Text
                .Guardar()
            End With
        End If

        Me.cargarExistentes()
    End Sub

    Private Sub btn_agregar_horas_Click(sender As Object, e As EventArgs) Handles btn_agregar_horas.Click
        Dim _Hora_tipo_Subproyecto As New entHora_Tipo_Subproyecto

        If _selected_horas_row Is Nothing Then

            With _Hora_tipo_Subproyecto
                .Cargar()
                .Insertar()
                .nombre = Me.txt_nombre_hora_tipo_subproyecto.Text
                .horas = CInt(Me.txt_num_horas.Value)
                .id_tipo_subproyecto = _Tipo_Subproyecto.id_tipo_subproyecto
                .Guardar()
            End With
        Else
            With _Hora_tipo_Subproyecto
                .Cargar()
                .Modificar(CInt(_selected_horas_row.Cells("id_hora_tipo_subproyecto").Value))
                .nombre = Me.txt_nombre_hora_tipo_subproyecto.Text
                .horas = CInt(Me.txt_num_horas.Value)
                .Guardar()
            End With

        End If

        Me.txt_nombre_hora_tipo_subproyecto.Text = ""
        Me.txt_num_horas.Value = 20
        Me.btn_agregar_horas.Text = "Agregar"
        Me._selected_horas_row = Nothing
        Me.cargarHorasTipoProyecto()

    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        Me.limpiarControles()

        'Cargo los controles con los datos
        With _Tipo_Subproyecto
            .Cargar()
            .Modificar(CInt(Me.dgv_tipos_subproyecto.SelectedRows(0).Cells("id_tipo_subproyecto").Value))

            Me.txt_nombre_tipo_subproyecto.Text = .nombre_tipo_subproyecto
            Me.txt_descripcion_tipo_subproyecto.Text = .descripcion
        End With

        Me.cargarActividadesTipoProyecto()
        Me.cargarHorasTipoProyecto()

        If _SelectedRow Is Nothing = False Then
            For Each cell As DataGridViewCell In _SelectedRow.Cells
                cell.Style.BackColor = Color.White
            Next
        End If

        _SelectedRow = Me.dgv_tipos_subproyecto.SelectedRows(0)

        For Each cell As DataGridViewCell In _SelectedRow.Cells
            cell.Style.BackColor = Color.LightGreen
        Next

    End Sub

    Private Sub dgv_tipos_subproyecto_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_tipos_subproyecto.CellDoubleClick
        Me.btn_modificar_Click(Nothing, Nothing)
    End Sub

    Private Sub dgv_horas_subproyecto_MouseDown(sender As Object, e As MouseEventArgs) Handles dgv_horas_subproyecto.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim currentMouseOverRow As Integer
            currentMouseOverRow = dgv_horas_subproyecto.HitTest(e.X, e.Y).RowIndex
            dgv_horas_subproyecto.ClearSelection()

            If currentMouseOverRow >= 0 Then
                dgv_horas_subproyecto.Rows(currentMouseOverRow).Selected = True
            End If
        End If
    End Sub

    Private Sub dgv_tipos_actividad_MouseDown(sender As Object, e As MouseEventArgs) Handles dgv_tipos_actividad.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim currentMouseOverRow As Integer
            currentMouseOverRow = dgv_tipos_actividad.HitTest(e.X, e.Y).RowIndex
            dgv_tipos_actividad.ClearSelection()

            If currentMouseOverRow >= 0 Then
                dgv_tipos_actividad.Rows(currentMouseOverRow).Selected = True
            End If
        End If
    End Sub

    Private Sub dgv_tipos_subproyecto_MouseDown(sender As Object, e As MouseEventArgs) Handles dgv_tipos_subproyecto.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim currentMouseOverRow As Integer
            currentMouseOverRow = dgv_tipos_subproyecto.HitTest(e.X, e.Y).RowIndex
            dgv_tipos_subproyecto.ClearSelection()

            If currentMouseOverRow >= 0 Then

                dgv_tipos_subproyecto.Rows(currentMouseOverRow).Selected = True
            End If
        End If
    End Sub

    Private Sub ts_borrar_hora_Click(sender As Object, e As EventArgs) Handles ts_borrar_hora.Click
        If dgv_horas_subproyecto.SelectedRows.Count > 0 Then
            Dim _hora_tipo_subproyecto As New entHora_Tipo_Subproyecto
            With _hora_tipo_subproyecto
                .Cargar()
                .Borrar(CInt(Me.dgv_horas_subproyecto.SelectedRows(0).Cells("id_hora_tipo_subproyecto").Value))
            End With
            Me.cargarHorasTipoProyecto()
        End If
    End Sub

    Private Sub ts_borrar_tipo_subproyecto_Click(sender As Object, e As EventArgs) Handles ts_borrar_tipo_subproyecto.Click
        If Me.dgv_tipos_subproyecto.SelectedRows.Count > 0 Then
            With _Tipo_Subproyecto
                .Cargar()
                If .Borrar(CInt(Me.dgv_tipos_subproyecto.SelectedRows(0).Cells("id_tipo_subproyecto").Value)) Then
                    MessageBox.Show("Tipo de subproyecto borrado con éxito.", "Borrado exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No se puede borrar un tipo de subproyecto que ya fue asignado a un subproyecto", "Borrado cancelado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End With
        End If
        Me.cargarExistentes()
        Me.limpiarControles()
    End Sub

    Private Sub ts_borrar_actividad_tipo_subproyecto_Click(sender As Object, e As EventArgs) Handles ts_borrar_actividad_tipo_subproyecto.Click
        If dgv_tipos_actividad.SelectedRows.Count > 0 Then
            Dim _Actividad_tipo_subproyecto As New entActividad_Tipo_Subproyecto
            With _Actividad_tipo_subproyecto
                .Cargar()
                .Borrar(CInt(Me.dgv_tipos_actividad.SelectedRows(0).Cells("id_actividad_tipo_subproyecto").Value))
            End With
            Me.cargarActividadesTipoProyecto()
        End If
    End Sub

    Private Sub btn_arriba_actividad_Click(sender As Object, e As EventArgs) Handles btn_arriba_actividad.Click
        If dgv_tipos_actividad.Rows.Count > 1 Then
            Dim _Actividad_tipo_proyecto As New entActividad_Tipo_Subproyecto
            Dim selected_index = Me.dgv_tipos_actividad.SelectedRows(0).Index

            If selected_index > 0 Then
                With _Actividad_tipo_proyecto
                    .Cargar()
                    .Modificar(CInt(Me.dgv_tipos_actividad.SelectedRows(0).Cells("id_actividad_tipo_subproyecto").Value))
                    .orden = .orden - 1
                    .Guardar()

                    .Cargar()
                    .Modificar(CInt(Me.dgv_tipos_actividad.Rows(selected_index - 1).Cells("id_actividad_tipo_subproyecto").Value))
                    .orden = .orden + 1
                    .Guardar()
                End With

                Me.cargarActividadesTipoProyecto()
                Me.dgv_tipos_actividad.ClearSelection()
                Me.dgv_tipos_actividad.Rows(selected_index - 1).Selected = True

            End If
        End If
    End Sub

    Private Sub btn_abajo_actividad_Click(sender As Object, e As EventArgs) Handles btn_abajo_actividad.Click
        If dgv_tipos_actividad.Rows.Count > 1 Then
            Dim _Actividad_tipo_proyecto As New entActividad_Tipo_Subproyecto
            Dim selected_index = Me.dgv_tipos_actividad.SelectedRows(0).Index
            Dim id_seleccionado As Integer = CInt(Me.dgv_tipos_actividad.SelectedRows(0).Cells("id_actividad_tipo_subproyecto").Value)

            If selected_index < Me.dgv_tipos_actividad.Rows.Count - 1 Then
                With _Actividad_tipo_proyecto
                    .Cargar()
                    .Modificar(id_seleccionado)
                    .orden = .orden + 1
                    .Guardar()

                    .Cargar()
                    .Modificar(CInt(Me.dgv_tipos_actividad.Rows(selected_index + 1).Cells("id_actividad_tipo_subproyecto").Value))
                    .orden = .orden - 1
                    .Guardar()
                End With

                Me.cargarActividadesTipoProyecto()
                Me.dgv_tipos_actividad.ClearSelection()
                Me.dgv_tipos_actividad.Rows(selected_index + 1).Selected = True

            End If
        End If
    End Sub

    Private Sub txt_buscar_nombre_tipo_subroyecto_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_buscar_nombre_tipo_subroyecto.KeyUp
        Me.cargarExistentes()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm_actividad As New frmABMActividad
        frm_actividad.btn_seleccionar.Enabled = True
        frm_actividad.ShowDialog(Me)
        Me.cargarActividades()
        cmb_actividades.SelectedValue = CInt(frm_actividad.dgv_actividad.SelectedRows(0).Cells("id_actividad").Value)
    End Sub

    Private Sub dgv_horas_subproyecto_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_horas_subproyecto.CellDoubleClick
        If Me.dgv_horas_subproyecto.SelectedRows.Count <> 0 Then

            If _selected_horas_row Is Nothing = False Then
                For Each cell As DataGridViewCell In _selected_horas_row.Cells
                    cell.Style.BackColor = Color.White
                Next
            End If

            Me._selected_horas_row = Me.dgv_horas_subproyecto.SelectedRows(0)
            Me.txt_nombre_hora_tipo_subproyecto.Text = _selected_horas_row.Cells("nombre_hora_tipo_subproyecto").Value.ToString()
            Me.txt_num_horas.Value = CDec(_selected_horas_row.Cells("horas").Value)
            Me.btn_agregar_horas.Text = "Guardar"

            For Each cell As DataGridViewCell In _selected_horas_row.Cells
                cell.Style.BackColor = Color.LightGreen
            Next
        End If
    End Sub

End Class