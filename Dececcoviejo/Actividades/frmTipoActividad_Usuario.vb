Public Class frmTipoActividad_Usuario

    Private Sub frmTipoActividad_Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarDatos()
        Me.CargarGrillas()
    End Sub

    Private Sub CargarGrillas()
        Dim odt As DataTable
        Dim index As Integer

        odt = oActividad.GetTipoActividad()
        For Each row As DataRow In odt.Rows
            index = Me.dgv_tipo_actividad.Rows.Add()
            With Me.dgv_tipo_actividad.Rows(index)
                .Cells("id_tipo_actividad").Value = row.Item("id_tipo_actividad")
                .Cells("nombre_actividad").Value = row.Item("descripcion")
                .Cells("habilitado_actividad").Value = False
            End With
        Next

        odt = oUsuario.GetCmb()
        For Each row As DataRow In odt.Rows
            index = Me.dgv_usuarios.Rows.Add()
            With Me.dgv_usuarios.Rows(index)
                .Cells("id_usuario").Value = row.Item("id_usuario")
                .Cells("nombre_usuario").Value = row.Item("nombre_usuario")
                .Cells("habilitado_usuario").Value = False
            End With
        Next

    End Sub

    Private Sub CargarPorUsuario(ByVal id_usuario As Integer)
        Dim odt As DataTable
        Dim _tipo_Actividad_usuario As New Tipo_Actividad_Usuario
        Dim id_tipo_actividad_usuario, id_tipo_actividad As Integer
        odt = _tipo_Actividad_usuario.GetFromUsuario(id_usuario)
        For Each row As DataRow In odt.Rows
            For Each row_dgv As DataGridViewRow In Me.dgv_tipo_actividad.Rows
                id_tipo_actividad = CInt(row_dgv.Cells("id_tipo_actividad").Value)
                id_tipo_actividad_usuario = CInt(row.Item("id_tipo_actividad"))
                If id_tipo_actividad = id_tipo_actividad_usuario Then
                    row_dgv.Cells("habilitado_actividad").Value = CBool(row.Item("habilitado"))
                End If
            Next
        Next
    End Sub

    Private Sub dgv_usuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_usuarios.CellDoubleClick
        If e.ColumnIndex <> Me.dgv_usuarios.Columns("habilitado_usuario").Index Then
            If Me.dgv_usuarios.SelectedRows.Count > 0 Then
                Me.CargarPorUsuario(CInt(Me.dgv_usuarios.SelectedRows(0).Cells("id_usuario").Value))
                Me.dgv_usuarios.Columns("habilitado_usuario").Visible = False
                Me.dgv_tipo_actividad.Columns("habilitado_actividad").Visible = True
            End If
        End If
        
    End Sub

    Private Sub CargarPorTipoActividad(ByVal id_tipo_actividad As Integer)
        Dim odt As DataTable
        Dim _tipo_Actividad_usuario As New Tipo_Actividad_Usuario
        Dim id_usuario_tipo_Actividad, id_usuario As Integer
        odt = _tipo_Actividad_usuario.GetFromTipoActividad(id_tipo_actividad)
        For Each row As DataRow In odt.Rows
            For Each row_dgv As DataGridViewRow In Me.dgv_usuarios.Rows
                id_usuario = CInt(row_dgv.Cells("id_usuario").Value)
                id_usuario_tipo_Actividad = CInt(row.Item("id_usuario"))
                If id_usuario = id_usuario_tipo_Actividad Then
                    row_dgv.Cells("habilitado_usuario").Value = CBool(row.Item("habilitado"))
                End If
            Next
        Next
    End Sub

    Private Sub dgv_tipo_actividad_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_tipo_actividad.CellDoubleClick
        If e.ColumnIndex <> Me.dgv_tipo_actividad.Columns("habilitado_actividad").Index Then
            If Me.dgv_tipo_actividad.SelectedRows.Count > 0 Then
                Me.CargarPorTipoActividad(CInt(Me.dgv_tipo_actividad.SelectedRows(0).Cells("id_tipo_actividad").Value))
                Me.dgv_tipo_actividad.Columns("habilitado_actividad").Visible = False
                Me.dgv_usuarios.Columns("habilitado_usuario").Visible = True
            End If
        End If
    End Sub

    Private Sub CargarDatos()
        Dim usuario As DataTable = oUsuario.GetCmb
        Dim tipo_Actividad As DataTable = oTipo_actividad.GetCmb
        Dim _Tipo_Actividad_Usuario As New Tipo_Actividad_Usuario

        For Each row_usuario As DataRow In usuario.Rows
            For Each row_tipo_Actividad As DataRow In tipo_Actividad.Rows
                With _Tipo_Actividad_Usuario
                    .Cargar()
                    .Insertar()
                    .id_tipo_actividad = CInt(row_tipo_Actividad.Item("id_tipo_actividad"))
                    .id_usuario = CInt(row_usuario.Item("id_usuario"))
                    .habilitado = False
                    If .Exist() = 0 Then
                        .Guardar()
                    End If
                End With
            Next
        Next
    End Sub

    Private Sub dgv_usuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_usuarios.CellClick
        If e.ColumnIndex = Me.dgv_usuarios.Columns("habilitado_usuario").Index Then
            Dim selected As Boolean = CBool(Me.dgv_usuarios.Rows(e.RowIndex).Cells("habilitado_usuario").Value)
            Me.dgv_usuarios.Rows(e.RowIndex).Cells("habilitado_usuario").Value = Not selected
            Dim _Tipo_Actividad_Usuario As New Tipo_Actividad_Usuario
            With _Tipo_Actividad_Usuario
                .Cargar()
                .Insertar()
                .id_tipo_actividad = CInt(Me.dgv_tipo_actividad.SelectedRows(0).Cells("id_tipo_actividad").Value)
                .id_usuario = CInt(Me.dgv_usuarios.SelectedRows(0).Cells("id_usuario").Value)
                If .Exist() <> 0 Then
                    .Modificar(.Exist())
                    .habilitado = Not selected
                    .Guardar()
                End If
            End With
        End If
    End Sub

    Private Sub dgv_tipo_actividad_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_tipo_actividad.CellClick
        If e.ColumnIndex = Me.dgv_tipo_actividad.Columns("habilitado_actividad").Index Then
            Dim selected As Boolean = CBool(Me.dgv_tipo_actividad.Rows(e.RowIndex).Cells("habilitado_actividad").Value)
            Me.dgv_tipo_actividad.Rows(e.RowIndex).Cells("habilitado_actividad").Value = Not selected
            Dim _Tipo_Actividad_Usuario As New Tipo_Actividad_Usuario
            With _Tipo_Actividad_Usuario
                .Cargar()
                .Insertar()
                .id_tipo_actividad = CInt(Me.dgv_tipo_actividad.SelectedRows(0).Cells("id_tipo_actividad").Value)
                .id_usuario = CInt(Me.dgv_usuarios.SelectedRows(0).Cells("id_usuario").Value)
                If .Exist() <> 0 Then
                    .Modificar(.Exist())
                    .habilitado = Not selected
                    .Guardar()
                End If
            End With
        End If
    End Sub
End Class