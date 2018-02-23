Imports ControladoresLogica
Imports Entidades

Public Class frmVerProyectosActivos

    Dim cargando As Boolean = True
    Private Sub frmVerProyectosActivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGrila()
        
    End Sub

    Private Sub cargarGrila()
        cargando = True
        Dim proyec As List(Of Entidades.Proyecto) = ControladorProyecto.ObtenerProyectos()
        Dim row As Integer

        dgv_proyectos.Rows.Clear()

        For Each proy In proyec

            row = dgv_proyectos.Rows.Add()

            dgv_proyectos.Item(id_proyecto_dgv.Index, row).Value = proy.id_proyecto
            dgv_proyectos.Item(nombre_cliente_dgv.Index, row).Value = If (proy.id_cliente = 0, "", ControladorClientes.ObtenerCLiente(proy.id_cliente).nombre_cliente)
            dgv_proyectos.Item(nombre_proyecto_dgv.Index, row).Value = proy.nombre_proyecto
            dgv_proyectos.Item(chk_activo_dgv.Index, row).Value = proy.activo

        Next
        cargando = False
    End Sub

    Private Sub dgv_proyectos_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_proyectos.CellValueChanged
        If e.ColumnIndex = chk_activo_dgv.Index And cargando = False Then
            Dim id_proyecto As Integer = dgv_proyectos.Item(id_proyecto_dgv.Index, e.RowIndex).Value
            ControladorProyecto.ActualizarActivo(id_proyecto, dgv_proyectos.Item(chk_activo_dgv.Index, e.RowIndex).Value)
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Close()
    End Sub

    Private Sub dgv_proyectos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_proyectos.CellClick
        
    End Sub
End Class