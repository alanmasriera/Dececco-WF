Imports ControladoresLogica

Public Class frmPrioridadProyectos
    Private Sub frmPrioridadProyectos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarSubproyectos
    End Sub

    Private Sub CargarSubproyectos
        Dim lista = ControladoresLogica.ControladorSubproyecto.ObtenerSubproyectosConActividadesActivos().OrderBy(Function(x) x.id_prioridad)
        Dim fila As Integer

        Me.dgvSubproyectos.Rows.Clear

        For Each  item In lista
            fila = dgvSubproyectos.Rows.Add

            With dgvSubproyectos.Rows.Item(fila).Cells
                .Item(id_proyecto_dgv.Index).Value = item.id_proyecto
                .Item(id_subproyecto_dgv.Index).Value = item.id_subproyecto
                .Item(nombre_proyecto_dgv.Index).Value = ControladorProyecto.ObtenerPorID(item.id_proyecto.Value).nombre_proyecto
                .Item(nombre_subproyecto_dgv.Index).Value = item.nombre
                .Item(path_dgv.Index).Value = ControladorSubproyecto.ObtenerPathSubproyecto(item)
                .Item(fecha_inicio_dgv.Index).Value = ControladorTareas.CalcularFechaInicioSubproyecto(item)
                .Item(fecha_fin_dgv.Index).Value = ControladorTareas.CalcularFechaFinSubproyecto(item)
            End With

        Next            

    End Sub

    Private Sub btn_abajo_proyecto_Click(sender As Object, e As EventArgs) Handles btn_abajo_proyecto.Click
        Dim rowIndex As Integer
        Dim filasSeleccionadas As List(Of DataGridViewRow) = dgvSubproyectos.SelectedRows.OfType(Of DataGridViewRow).ToList
        dgvSubproyectos.ClearSelection

        For Each item As DataGridViewRow In filasSeleccionadas.OrderByDescending(Function(x) x.Index).ToList
            If (item.Index < dgvSubproyectos.Rows.Count -1) Then
                rowIndex = item.Index                 
                dgvSubproyectos.Rows.Remove(item)        
                dgvSubproyectos.ClearSelection        
                dgvSubproyectos.Rows.Insert(rowIndex +1,item)
                dgvSubproyectos.ClearSelection
            Else
                Exit For
            End If
        Next
        
        For Each item As DataGridViewRow In filasSeleccionadas
            item.Selected =  True
        Next

    End Sub

    Private Sub btn_arriba_proyecto_Click(sender As Object, e As EventArgs) Handles btn_arriba_proyecto.Click
        Dim rowIndex As Integer
        Dim filasSeleccionadas As List(Of DataGridViewRow) = dgvSubproyectos.SelectedRows.OfType(Of DataGridViewRow).ToList
        dgvSubproyectos.ClearSelection

        For Each item As DataGridViewRow In filasSeleccionadas.OrderBy(Function(x) x.Index).ToList
            If (item.Index > 0) Then
                rowIndex = item.Index                 
                dgvSubproyectos.Rows.Remove(item)        
                dgvSubproyectos.ClearSelection        
                dgvSubproyectos.Rows.Insert(rowIndex -1,item)
                dgvSubproyectos.ClearSelection
            Else
                Exit For
            End If
        Next
        
        For Each item As DataGridViewRow In filasSeleccionadas
            item.Selected =  True
        Next
    End Sub

    Private Sub btn_guardar_subproyecto_Click(sender As Object, e As EventArgs) Handles btn_guardar_subproyecto.Click
        Dim subproyecto As Entidades.SUBPROYECTO

        For Each item As DataGridViewRow In Me.dgvSubproyectos.Rows
            subproyecto = ControladorSubproyecto.BuscarPorId(item.Cells.Item(id_subproyecto_dgv.Index).Value)
            subproyecto.id_prioridad = item.Index +1
            ControladorSubproyecto.ActualizarSubproyecto(subproyecto)
        Next

    End Sub
End Class