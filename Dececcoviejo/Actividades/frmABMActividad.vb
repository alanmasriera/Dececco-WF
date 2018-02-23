Public Class frmABMActividad

    Dim selected_row As DataGridViewRow

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        If Me.ControlarCambios() Then
            'Si se seleccionó algnuna fila, restablezo al color original
            If selected_row Is Nothing = False Then
                For Each cell As DataGridViewCell In Me.selected_row.Cells
                    cell.Style.BackColor = Color.White
                Next
            End If
            Me.txt_nombre_actividad.Focus()
            Me.limpiarControles()
        End If
    End Sub

    Private Sub frmABMActividad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.limpiarControles()
        Me.cargarGrillaActividades("")
        Me.txt_nombre_actividad.Focus()
    End Sub

    Private Sub limpiarControles()
        Me.selected_row = Nothing
        Me.txt_nombre_actividad.Text = ""
        Me.txtnum_peso.Value = 33.33D
        Me.txt_nombre_actividad.Focus()
        Me.btn_agregaar.Enabled = True
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.Visible = False
        Me.chk_permitir_logueo.Checked = False
        Me.chk_asignable.Checked = True
    End Sub

    Private Sub cargarGrillaActividades(ByVal filtro_nombre As String)
        Dim dt As DataTable
        Dim row_act As Integer
        dt = oTipo_actividad.Buscar(filtro_nombre)

        Me.dgv_actividad.Rows.Clear()

        'Asigno los valores a la grilla
        For Each row As DataRow In dt.Rows
            row_act = Me.dgv_actividad.Rows.Add()
            Me.dgv_actividad.Rows(row_act).Cells("id_actividad").Value = row.Item("id_tipo_actividad")
            Me.dgv_actividad.Rows(row_act).Cells("porcentaje").Value = row.Item("criticidad")
            Me.dgv_actividad.Rows(row_act).Cells("descripcion").Value = row.Item("descripcion")
            Me.dgv_actividad.Rows(row_act).Cells("logueo_habilitado").Value = row.Item("logueo_habilitado")
            Me.dgv_actividad.Rows(row_act).Cells("Asignable").Value = row.Item("asignable")
        Next

        'Deshabilito el botón guardar por si se estaba modificando
        Me.btn_guardar.Enabled = False
        Me.btn_agregaar.Enabled = True
        Me.btn_guardar.Visible = False
    End Sub

    Private Sub btn_agregaar_Click(sender As Object, e As EventArgs) Handles btn_agregaar.Click
        If String.IsNullOrEmpty(txt_nombre_actividad.Text) = False Then
            With oTipo_actividad
                .Cargar()
                .Insertar()
                .descripcion = Me.txt_nombre_actividad.Text
                .criticidad = Me.txtnum_peso.Value
                .asignable = Me.chk_asignable.Checked
                .Guardar()
            End With

            'Quita la posibilidad de que los usuarios se logueen
            Dim usuario As DataTable = oUsuario.GetCmb
            Dim _Tipo_Actividad_Usuario As New Tipo_Actividad_Usuario

            For Each row_usuario As DataRow In usuario.Rows
                With _Tipo_Actividad_Usuario
                    .Cargar()
                    .Insertar()
                    .id_tipo_actividad = oTipo_actividad.id_tipo_actividad
                    .id_usuario = CInt(row_usuario.Item("id_usuario"))
                    .habilitado = False
                    If .Exist() = 0 Then
                        .Guardar()
                    End If
                End With
            Next
        End If
        Me.cargarGrillaActividades("")
        Me.limpiarControles()
    End Sub


    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        'Si se seleccionó algnuna fila, restablezo al color original
        If selected_row Is Nothing = False Then
            For Each cell As DataGridViewCell In Me.selected_row.Cells
                cell.Style.BackColor = Color.White
            Next
        End If

        'Asigno la nueva fila seleccionada
        Me.selected_row = Me.dgv_actividad.SelectedRows(0)

        'Le seteo color verde al fondo de la fila seleccionada
        For Each cell As DataGridViewCell In Me.dgv_actividad.SelectedRows(0).Cells
            cell.Style.BackColor = Color.LightGreen
        Next

        'Asigno los valores a los controles
        Me.txt_nombre_actividad.Text = Me.selected_row.Cells("descripcion").Value.ToString()
        Me.txtnum_peso.Value = CDec(Me.selected_row.Cells("porcentaje").Value.ToString())
        Me.chk_permitir_logueo.Checked = CBool(Me.selected_row.Cells("logueo_habilitado").Value)
        Me.chk_asignable.Checked = CBool(Me.selected_row.Cells("Asignable").Value)

        'Habilito el botón guardar
        Me.btn_guardar.Enabled = True
        Me.btn_agregaar.Enabled = False
        Me.btn_guardar.Visible = True
        Me.txt_nombre_actividad.Focus()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Me.cargarGrillaActividades(txt_buscar_nombre.Text)
    End Sub


    Private Sub dgv_actividad_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_actividad.CellDoubleClick
        Me.btn_modificar_Click(Nothing, Nothing)
    End Sub

    Private Sub ts_borrar_tipo_actividad_Click(sender As Object, e As EventArgs) Handles ts_borrar_tipo_actividad.Click
        If Me.dgv_actividad.SelectedRows.Count > 0 Then
            Dim res As DialogResult
            res = MessageBox.Show("¿Está seguro que desea borrar la actividad?", "Borrar Actividad", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If res = Windows.Forms.DialogResult.Yes Then
                With oTipo_actividad
                    .Cargar()
                    .Borrar(CInt(Me.dgv_actividad.SelectedRows(0).Cells("id_actividad").Value))
                End With

                Dim usuario As DataTable = oUsuario.GetCmb
                Dim _Tipo_Actividad_Usuario As New Tipo_Actividad_Usuario
                Dim asignaciones As DataTable = _Tipo_Actividad_Usuario.GetFromTipoActividad(CInt(Me.dgv_actividad.SelectedRows(0).Cells("id_actividad").Value))
                For Each row As DataRow In asignaciones.Rows
                    With _Tipo_Actividad_Usuario
                        .Cargar()
                        If oActividad_proyecto.ExistTipoActividad(CInt(row.Item("id_tipo_actividad"))) = False Then
                            .Borrar(CInt(row.Item("id_tipo_actividad_usuario")))
                        Else
                            MessageBox.Show("El tipo de actividad seleccionado fue asignado a una actividad. No se puede borrar", "Borrar Actividad", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End With
                Next
                Me.cargarGrillaActividades(Me.txt_buscar_nombre.Text)
            End If
        Else
            MessageBox.Show("No hay ninguna actividad seleccionada", "Borrar Actividad", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub dgv_actividad_MouseDown(sender As Object, e As MouseEventArgs) Handles dgv_actividad.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim currentMouseOverRow As Integer
            currentMouseOverRow = dgv_actividad.HitTest(e.X, e.Y).RowIndex

            If currentMouseOverRow >= 0 Then
                dgv_actividad.ClearSelection()
                dgv_actividad.Rows(currentMouseOverRow).Selected = True
            End If
        End If
    End Sub

    Private Sub txt_buscar_nombre_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_buscar_nombre.KeyUp
        Me.cargarGrillaActividades(Me.txt_buscar_nombre.Text)
    End Sub


    Private Sub btn_guardar_Click_1(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If selected_row Is Nothing = False Then
            If String.IsNullOrEmpty(txt_nombre_actividad.Text) = False Then

                With oTipo_actividad
                    .Cargar()
                    .Modificar(CInt(Me.selected_row.Cells("id_actividad").Value))
                    .descripcion = Me.txt_nombre_actividad.Text
                    .criticidad = Me.txtnum_peso.Value
                    .logueo_habilitado = Me.chk_permitir_logueo.Checked
                    .asignable = Me.chk_asignable.Checked
                    .ActualizarAsignableActividadProyecto(.id_tipo_actividad, .asignable)
                    .Guardar()
                End With

                Me.cargarGrillaActividades("")
                Me.limpiarControles()
                MessageBox.Show("Actividad guardada con éxito", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        End If
    End Sub

    Private Sub frmABMActividad_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.ControlarCambios() = False Then
            e.Cancel = True
        End If
    End Sub

    Private Function ControlarCambios() As Boolean
        If Me.btn_guardar.Enabled Then
            Dim res As DialogResult
            res = MessageBox.Show("No ha guardado los cambios, ¿Desea continuar?", "Cambios pendientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If res = Windows.Forms.DialogResult.No Then
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub btn_seleccionar_Click(sender As Object, e As EventArgs) Handles btn_seleccionar.Click
        Me.Close()
    End Sub
End Class