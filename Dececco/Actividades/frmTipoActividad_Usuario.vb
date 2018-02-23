Imports ControladoresLogica
Imports Entidades
Public Class frmTipoActividad_Usuario

    Private Sub frmTipoActividad_Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarDatos()
        Me.CargarGrillas()
    End Sub

    Private Sub CargarGrillas()
        Dim odt As List(Of Entidades.Tipo_actividad)
        Dim index As Integer

        odt = ControladoresLogica.ControladorActividades.ObtenerTiposActividad()
        For Each row As Entidades.Tipo_actividad In odt
            index = Me.dgv_tipo_actividad.Rows.Add()
            With Me.dgv_tipo_actividad.Rows(index)
                .Cells("id_tipo_actividad").Value = row.id_tipo_actividad
                .Cells("nombre_actividad").Value = row.descripcion
                .Cells("habilitado_actividad").Value = False
                .Cells.Item(calificacion_dgv.Index).Value = 0
            End With
        Next

        Dim usuarios As List(Of Entidades.USUARIO)
        usuarios = ControladorUsuarios.ObtenerTodosUsuarios()
        For Each row As Entidades.USUARIO In usuarios
            index = Me.dgv_usuarios.Rows.Add()
            With Me.dgv_usuarios.Rows(index)
                .Cells("id_usuario").Value = row.id_usuario
                .Cells("nombre_usuario").Value = row.FullName
                .Cells("habilitado_usuario").Value = False
            End With
        Next

    End Sub

    Private Sub CargarPorUsuario(ByVal id_usuario As Integer)
        Dim odt As List(Of Entidades.Tipo_Actividad_Usuario)
        Dim _tipo_Actividad_usuario As New Tipo_Actividad_Usuario
        Dim id_tipo_actividad_usuario, id_tipo_actividad As Integer
        odt = ControladorActividades.ObtenerTiposActividadUsuario(ControladorUsuarios.ObtenerUsuario(id_usuario))


        For Each row As Entidades.Tipo_Actividad_usuario In odt
            For Each row_dgv As DataGridViewRow In Me.dgv_tipo_actividad.Rows
                id_tipo_actividad = CInt(row_dgv.Cells("id_tipo_actividad").Value)
                id_tipo_actividad_usuario = row.id_tipo_actividad
                If id_tipo_actividad = id_tipo_actividad_usuario Then
                    row_dgv.Cells("habilitado_actividad").Value = row.habilitado
                    If (row.habilitado) Then
                        row_dgv.Cells.Item(calificacion_dgv.Index).Value = If( row.calificacion > 0, row.calificacion, 1)
                        Else
                        row_dgv.Cells.Item(calificacion_dgv.Index).Value = 0
                    End If
                    
                End If
            Next
        Next
    End Sub

    Private Sub dgv_usuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_usuarios.CellDoubleClick
        If e.ColumnIndex <> Me.dgv_usuarios.Columns("habilitado_usuario").Index And e.ColumnIndex <> calificacion_usuario_dgv.Index  Then
            If Me.dgv_usuarios.SelectedCells.Count > 0 Then
                Me.CargarPorUsuario(CInt(Me.dgv_usuarios.SelectedCells(0).OwningRow.Cells("id_usuario").Value))
                Me.dgv_usuarios.Columns("habilitado_usuario").Visible = False
                Me.dgv_tipo_actividad.Columns("habilitado_actividad").Visible = True
                Me.calificacion_usuario_dgv.Visible = False
                Me.calificacion_dgv.Visible = True
            End If
        End If
        
    End Sub

    Private Sub CargarPorTipoActividad(ByVal id_tipo_actividad As Integer)
        Dim odt As List(Of Entidades.Tipo_Actividad_Usuario)
        Dim _tipo_Actividad_usuario As New Tipo_Actividad_Usuario
        Dim id_usuario_tipo_Actividad, id_usuario As Integer
        odt = ControladorActividades.ObtenerTiposActividadUsuario(ControladorActividades.ObtenerTipoActividad(id_tipo_actividad))

        For Each row As Entidades.Tipo_Actividad_Usuario In odt
            For Each row_dgv As DataGridViewRow In Me.dgv_usuarios.Rows
                id_usuario = CInt(row_dgv.Cells("id_usuario").Value)
                id_usuario_tipo_Actividad = row.id_usuario
                If id_usuario = id_usuario_tipo_Actividad Then
                    row_dgv.Cells("habilitado_usuario").Value = row.habilitado
                    If (row.habilitado) Then
                        row_dgv.Cells.Item(calificacion_usuario_dgv.Index).Value = If( row.calificacion > 0, row.calificacion, 1)
                        Else
                        row_dgv.Cells.Item(calificacion_usuario_dgv.Index).Value = 0
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub dgv_tipo_actividad_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_tipo_actividad.CellDoubleClick
        If e.ColumnIndex <> Me.dgv_tipo_actividad.Columns("habilitado_actividad").Index And e.ColumnIndex <> calificacion_dgv.Index Then
            If Me.dgv_tipo_actividad.SelectedCells.Count > 0 Then
                Me.CargarPorTipoActividad(CInt(Me.dgv_tipo_actividad.SelectedCells(0).OwningRow.Cells("id_tipo_actividad").Value))
                Me.dgv_tipo_actividad.Columns("habilitado_actividad").Visible = False
                Me.calificacion_dgv.Visible = False
                Me.dgv_usuarios.Columns("habilitado_usuario").Visible = True
                Me.calificacion_usuario_dgv.Visible = True
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
            Dim _Tipo_Actividad_Usuario As New Entidades.Tipo_Actividad_Usuario
            With _Tipo_Actividad_Usuario
                .id_tipo_actividad = CInt(Me.dgv_tipo_actividad.SelectedCells(0).OwningRow.Cells("id_tipo_actividad").Value)
                .id_usuario = CInt(Me.dgv_usuarios.Item(id_usuario.Index,e.RowIndex).Value)
                _Tipo_Actividad_Usuario = ControladorActividades.ObtenerTipoActividadUsuario(.id_tipo_actividad, .id_usuario)
                If _Tipo_Actividad_Usuario IsNot Nothing Then
                    _Tipo_Actividad_Usuario.habilitado = Not selected     
                    If (_Tipo_Actividad_Usuario.habilitado) Then
                        Me.dgv_usuarios.Item(calificacion_usuario_dgv.Index,e.RowIndex).Value = If( _Tipo_Actividad_Usuario.calificacion > 0, _Tipo_Actividad_Usuario.calificacion, 1)
                        Else
                        Me.dgv_usuarios.Item(calificacion_usuario_dgv.Index,e.RowIndex).Value = 0
                    End If              
                    ControladorActividades.actualizarTipoActividadUsuario(_Tipo_Actividad_Usuario)
                End If
            End With
        End If
    End Sub

    Private Sub dgv_tipo_actividad_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_tipo_actividad.CellClick
        If e.ColumnIndex = Me.dgv_tipo_actividad.Columns("habilitado_actividad").Index Then
            Dim selected As Boolean = CBool(Me.dgv_tipo_actividad.Rows(e.RowIndex).Cells("habilitado_actividad").Value)
            Me.dgv_tipo_actividad.Rows(e.RowIndex).Cells("habilitado_actividad").Value = Not selected
            Dim _Tipo_Actividad_Usuario As New Entidades.Tipo_Actividad_Usuario
            With _Tipo_Actividad_Usuario
                .id_tipo_actividad = CInt(Me.dgv_tipo_actividad.Item(id_tipo_actividad.Index, e.RowIndex).Value)
                .id_usuario = CInt(Me.dgv_usuarios.SelectedCells(0).OwningRow.Cells("id_usuario").Value)
                _Tipo_Actividad_Usuario = ControladorActividades.ObtenerTipoActividadUsuario(.id_tipo_actividad, .id_usuario)
                If _Tipo_Actividad_Usuario IsNot Nothing Then
                    .habilitado = Not selected
                    If (.habilitado) Then
                        Me.dgv_tipo_actividad.Item(calificacion_dgv.Index,e.RowIndex).Value = If( _Tipo_Actividad_Usuario.calificacion > 0, _Tipo_Actividad_Usuario.calificacion, 1)
                        Else
                        Me.dgv_tipo_actividad.Item(calificacion_dgv.Index,e.RowIndex).Value = 0
                    End If     
                End If
                ControladorActividades.actualizarTipoActividadUsuario(_Tipo_Actividad_Usuario)
            End With
        End If
    End Sub



    Private Sub dgv_usuarios_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_usuarios.CellEndEdit
        If e.ColumnIndex = calificacion_usuario_dgv.Index Then
            Dim _Tipo_Actividad_Usuario As New Entidades.Tipo_Actividad_Usuario
            With _Tipo_Actividad_Usuario
                .id_tipo_actividad = CInt(Me.dgv_tipo_actividad.SelectedCells(0).OwningRow.Cells("id_tipo_actividad").Value)
                .id_usuario = dgv_usuarios.Item(id_usuario.Index,e.RowIndex).Value
                _Tipo_Actividad_Usuario = ControladorActividades.ObtenerTipoActividadUsuario(.id_tipo_actividad, .id_usuario)
                If _Tipo_Actividad_Usuario IsNot Nothing Then
                    If _Tipo_Actividad_Usuario.habilitado Then
                        _Tipo_Actividad_Usuario.calificacion = Cdec(Me.dgv_usuarios.Item(calificacion_usuario_dgv.Index,e.RowIndex).Value)
                        Else
                        _Tipo_Actividad_Usuario.calificacion = 0
                    End If
                    ControladorActividades.actualizarTipoActividadUsuario(_Tipo_Actividad_Usuario)
                End If
            End With
        End If
    End Sub

    Private Sub dgv_tipo_actividad_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_tipo_actividad.CellEndEdit
        If e.ColumnIndex = calificacion_dgv.Index Then
            Dim _Tipo_Actividad_Usuario As New Entidades.Tipo_Actividad_Usuario
            With _Tipo_Actividad_Usuario
                .id_tipo_actividad = Me.dgv_tipo_actividad.Item(id_tipo_actividad.Index,e.RowIndex ).Value
                .id_usuario = CInt(Me.dgv_usuarios.SelectedCells(0).OwningRow.Cells("id_usuario").Value)
                _Tipo_Actividad_Usuario = ControladorActividades.ObtenerTipoActividadUsuario(.id_tipo_actividad, .id_usuario)
                If _Tipo_Actividad_Usuario IsNot Nothing Then
                    If _Tipo_Actividad_Usuario.habilitado Then
                        _Tipo_Actividad_Usuario.calificacion = CDec(Me.dgv_tipo_actividad.Item(calificacion_dgv.Index,e.RowIndex ).Value)
                        Else
                        _Tipo_Actividad_Usuario.calificacion = 0
                    End If
                    ControladorActividades.actualizarTipoActividadUsuario(_Tipo_Actividad_Usuario)
                End If
            End With
        End If
    End Sub
End Class