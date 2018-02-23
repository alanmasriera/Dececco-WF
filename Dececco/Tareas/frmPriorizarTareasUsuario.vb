Imports ControladoresLogica
Imports Entidades

Public Class frmPriorizarTareasUsuario
    Private Sub frmPriorizarTareasUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarUsuarios()
    End Sub

    Private Sub CargarListaTareas()
        Dim listaTareas As List(Of Entidades.DatosTarea)
        listaTareas = ControladorTareas.ObtenerTareasPendientes(cmbUsuarios.SelectedValue)

        dgvListaTareas.Rows.Clear

        For Each tarea As DatosTarea In listaTareas
            Dim nro = dgvListaTareas.Rows.Add()
            dgvListaTareas.Item(id_detalle_recurso_dgv.Index,nro).Value = tarea.tarea.id_detalle_recurso
            dgvListaTareas.Item(id_usuario_dgv.Index,nro).Value = tarea.tarea.id_usuario
            dgvListaTareas.Item(fecha_inicio_dgv.Index,nro).Value = tarea.tarea.fecha_inicio
            dgvListaTareas.Item(fecha_fin_dgv.Index,nro).Value = tarea.tarea.fecha_fin
            dgvListaTareas.Item(nombre_proyecto_dgv.Index,nro).Value = tarea.proyecto.nombre_proyecto
            dgvListaTareas.Item(subproyecto_dgv.Index,nro).Value = ControladorSubproyecto.ObtenerPathSubproyecto(tarea.subproyecto)
            dgvListaTareas.Item(actividad_dgv.Index,nro).Value = tarea.actividad.nombre_actividad
            dgvListaTareas.Item(usuario_dgv.Index,nro).Value = ControladorUsuarios.ObtenerUsuario(tarea.tarea.id_usuario).FullName
            dgvListaTareas.Item(id_actividad_proyecto_dgv.Index,nro).Value = tarea.tarea.id_actividad_proyecto
            dgvListaTareas.Item(forzada_dgv.Index,nro).Value = tarea.tarea.forzada
            If tarea.tarea.forzada Then
                dgvListaTareas.Rows.Item(nro).DefaultCellStyle.BackColor = color.GreenYellow
                dgvListaTareas.Item(fecha_inicio_dgv.Index,nro).ReadOnly = False
                dgvListaTareas.Item(fecha_fin_dgv.Index,nro).ReadOnly = False
            End If
        Next

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        CargarListaTareas()
    End Sub

    Private SUb CargarUsuarios()
        Dim listaUsuario As List(Of Entidades.USUARIO)
        listaUsuario = ControladorUsuarios.ObtenerTodosUsuarios().OrderBy(Function(x) x.FullName).ToList()

        cmbUsuarios.DataSource = listaUsuario
        cmbUsuarios.ValueMember = "id_usuario"
        cmbUsuarios.DisplayMember = "FullName"
         
        If cmbUsuarios.Items.Count > 0 Then
            cmbUsuarios.SelectedIndex = 0
        End If

    End SUb

    Private Sub dgvListaTareas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaTareas.CellContentClick
        Dim color = dgvListaTareas.DefaultCellStyle.BackColor

        If e.ColumnIndex = forzada_dgv.Index Then
            If dgvListaTareas.Item(e.ColumnIndex,e.RowIndex).Value = True Then
                dgvListaTareas.Item(fecha_inicio_dgv.Index,e.RowIndex).ReadOnly = True
                dgvListaTareas.Item(fecha_fin_dgv.Index,e.RowIndex).ReadOnly = True
                dgvListaTareas.Rows.Item(e.RowIndex).DefaultCellStyle.BackColor = color

                Dim detalle as Entidades.Detalle_recurso = ControladorTareas.ObtenerPorID(dgvListaTareas.Item(id_detalle_recurso_dgv.Index,e.RowIndex).Value)
                dgvListaTareas.Item(fecha_inicio_dgv.Index,e.RowIndex).Value = detalle.fecha_inicio.Value
                dgvListaTareas.Item(fecha_fin_dgv.Index,e.RowIndex).Value = detalle.fecha_fin.Value
            Else
                dgvListaTareas.Item(fecha_inicio_dgv.Index,e.RowIndex).ReadOnly = False
                dgvListaTareas.Item(fecha_fin_dgv.Index,e.RowIndex).ReadOnly = False
                dgvListaTareas.Rows.Item(e.RowIndex).DefaultCellStyle.BackColor = color.GreenYellow
            End If
            dgvListaTareas.Item(e.ColumnIndex,e.RowIndex).Value = Not dgvListaTareas.Item(e.ColumnIndex,e.RowIndex).Value
        End If

    End Sub

    Private Sub btn_guardar_subproyecto_Click(sender As Object, e As EventArgs) Handles btn_guardar_subproyecto.Click
        For Each item as DataGridViewRow in dgvListaTareas.Rows
            Dim detalle As Entidades.Detalle_recurso = ControladorTareas.ObtenerPorID(item.Cells(_id_detalle_recurso_dgv.Index).Value)

            If detalle IsNot Nothing THen

                If detalle.forzada <> item.Cells(forzada_dgv.Index).Value Or detalle.fecha_inicio <> item.Cells(fecha_inicio_dgv.Index).Value Then
                    detalle.forzada = item.Cells(forzada_dgv.Index).Value
                    detalle.fecha_inicio = item.Cells(fecha_inicio_dgv.Index).Value
                    detalle.fecha_fin = ControladorCalendario.CalcularFechaFin(
                        ControladorActividades.ObtenerActividadProyecto(detalle.id_actividad_proyecto),
                        ControladorUsuarios.ObtenerUsuario(detalle.id_usuario),
                        item.Cells(fecha_inicio_dgv.Index).Value,
                        (ControladorActividades.ObtenerHorasTotalesActividad(ControladorActividades.ObtenerActividadProyecto(detalle.id_actividad_proyecto))))

                ControladorTareas.Actualizar(detalle)
                End If
                
            End If
        Next
        Close()
    End Sub

    Private Sub dgvListaTareas_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaTareas.CellValueChanged
        If e.RowIndex >=0 Then
            If e.ColumnIndex = fecha_inicio_dgv.Index Then
                Dim detalle as Entidades.Detalle_recurso = ControladorTareas.ObtenerPorID(dgvListaTareas.Item(id_detalle_recurso_dgv.Index,e.RowIndex).Value)
                If detalle IsNot Nothing Then
                    Dim fecha As DateTime = dgvListaTareas.Item(e.ColumnIndex,e.RowIndex).Value
                dgvListaTareas.Item(fecha_fin_dgv.Index,e.RowIndex).Value = ControladorCalendario.CalcularFechaFin(
                        ControladorActividades.ObtenerActividadProyecto(detalle.id_actividad_proyecto),
                        ControladorUsuarios.ObtenerUsuario(detalle.id_usuario),
                        fecha,
                        (ControladorActividades.ObtenerHorasTotalesActividad(ControladorActividades.ObtenerActividadProyecto(detalle.id_actividad_proyecto))))
            End If
            
            End If
        End If
        
    End Sub
End Class