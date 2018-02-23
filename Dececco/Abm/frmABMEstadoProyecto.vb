Public Class frmABMEstadoProyecto

    Dim selected_row As DataGridViewRow
    Dim oEstado_Subproyecto As New entEstado_Subproyecto

    Private Sub btn_agregar_estado_Click(sender As Object, e As EventArgs) Handles btn_agregar_estado.Click
        If String.IsNullOrEmpty(txt_nombre_estado.Text) = False Then
            With oEstado_Subproyecto
                .Cargar()
                .Insertar()
                .nombre = Me.txt_nombre_estado.Text
                .porcentaje = Me.txtnum_porcentaje.Value
                .Guardar()
            End With
        End If
        Me.cargarGrillaEstados("")
        Me.limpiarControles()
    End Sub

    Private Sub btn_buscar_estado_Click(sender As Object, e As EventArgs) Handles btn_buscar_estado.Click
        Me.cargarGrillaEstados(txt_buscar_nombre.Text)
    End Sub

    Private Sub btn_guardar_estado_Click(sender As Object, e As EventArgs) Handles btn_guardar_estado.Click
        If selected_row Is Nothing = False Then
            If String.IsNullOrEmpty(txt_nombre_estado.Text) = False Then
                With oEstado_Subproyecto
                    .Cargar()
                    .Modificar(CInt(Me.selected_row.Cells("id_estado_subproyecto").Value))
                    .nombre = Me.txt_nombre_estado.Text
                    .porcentaje = Me.txtnum_porcentaje.Value
                    .Guardar()
                End With
                Me.cargarGrillaEstados("")
                Me.limpiarControles()
                MessageBox.Show("Estado guardado con éxito", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        End If
    End Sub

    Private Sub btn_modificar_estado_Click(sender As Object, e As EventArgs) Handles btn_modificar_estado.Click
        'Si se seleccionó algnuna fila, restablezo al color original
        If selected_row Is Nothing = False Then
            For Each cell As DataGridViewCell In Me.selected_row.Cells
                cell.Style.BackColor = Color.White
            Next
        End If

        'Asigno la nueva fila seleccionada
        Me.selected_row = Me.dgv_estados.SelectedRows(0)

        'Le seteo color verde al fondo de la fila seleccionada
        For Each cell As DataGridViewCell In Me.dgv_estados.SelectedRows(0).Cells
            cell.Style.BackColor = Color.LightGreen
        Next

        'Asigno los valores a los controles
        Me.txt_nombre_estado.Text = Me.selected_row.Cells("nombre").Value.ToString()
        Me.txtnum_porcentaje.Value = CDec(Me.selected_row.Cells("porcentaje").Value.ToString())

        'Habilito el botón guardar
        Me.btn_guardar_estado.Enabled = True
        Me.btn_agregar_estado.Enabled = False
        Me.btn_guardar_estado.Visible = True
        Me.txt_nombre_estado.Focus()
    End Sub

    Private Sub btn_nuevo_estado_Click(sender As Object, e As EventArgs) Handles btn_nuevo_estado.Click
        If Me.ControlarCambios() Then
            'Si se seleccionó algnuna fila, restablezo al color original
            If selected_row Is Nothing = False Then
                For Each cell As DataGridViewCell In Me.selected_row.Cells
                    cell.Style.BackColor = Color.White
                Next
            End If
            Me.txt_nombre_estado.Focus()
            Me.limpiarControles()
        End If
    End Sub

    Private Sub frmABMEstadoProyecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.limpiarControles()
        Me.cargarGrillaEstados("")
        Me.txt_nombre_estado.Focus()
    End Sub

    Private Sub limpiarControles()
        Me.selected_row = Nothing
        Me.txt_nombre_estado.Text = ""
        Me.txtnum_porcentaje.Value = 33.33D
        Me.txt_nombre_estado.Focus()
        Me.btn_agregar_estado.Enabled = True
        Me.btn_guardar_estado.Enabled = False
        Me.btn_guardar_estado.Visible = False
    End Sub

    Private Sub cargarGrillaEstados(ByVal filtro_nombre As String)
        Dim dt As DataTable
        Dim row_act As Integer
        dt = oEstado_Subproyecto.Buscar(filtro_nombre)

        Me.dgv_estados.Rows.Clear()

        'Asigno los valores a la grilla
        For Each row As DataRow In dt.Rows
            row_act = Me.dgv_estados.Rows.Add()
            Me.dgv_estados.Rows(row_act).Cells("id_estado_subproyecto").Value = row.Item("id_estado_subproyecto")
            Me.dgv_estados.Rows(row_act).Cells("nombre").Value = row.Item("nombre")
            Me.dgv_estados.Rows(row_act).Cells("porcentaje").Value = row.Item("porcentaje")


            'Deshabilito el botón guardar por si se estaba modificando
            Me.btn_guardar_estado.Enabled = False
            Me.btn_agregar_estado.Enabled = True
            Me.btn_guardar_estado.Visible = False
        Next
    End Sub

    Private Sub dgv_estados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_estados.CellDoubleClick
        Me.btn_modificar_estado_Click(Nothing, Nothing)
    End Sub

    Private Sub ts_borrar_estado_Click(sender As Object, e As EventArgs) Handles ts_borrar_estado.Click
        If Me.dgv_estados.SelectedRows.Count > 0 Then
            Dim res As DialogResult
            res = MessageBox.Show("¿Está seguro que desea borrar el estado?", "Borrar Estado", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If res = System.Windows.Forms.DialogResult.Yes Then
                With oEstado_Subproyecto
                    .Cargar()
                    .Borrar(CInt(Me.dgv_estados.SelectedRows(0).Cells("id_estado_subproyecto").Value))
                    Me.cargarGrillaEstados(Me.txt_buscar_nombre.Text)
                End With
            End If
        Else
            MessageBox.Show("No hay ningún estado seleccionado", "Borrar Estado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub dgv_estados_MouseDown(sender As Object, e As MouseEventArgs) Handles dgv_estados.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim currentMouseOverRow As Integer
            currentMouseOverRow = dgv_estados.HitTest(e.X, e.Y).RowIndex

            If currentMouseOverRow >= 0 Then
                dgv_estados.ClearSelection()
                dgv_estados.Rows(currentMouseOverRow).Selected = True
            End If
        End If
    End Sub

    Private Sub txt_nombre_estado_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_nombre_estado.KeyUp

    End Sub

    Private Sub frmABMEstadoProyecto_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.ControlarCambios() = False Then
            e.Cancel = True
        End If
    End Sub

    Private Function ControlarCambios() As Boolean
        If Me.btn_guardar_estado.Enabled Then
            Dim res As DialogResult
            res = MessageBox.Show("No ha guardado los cambios, ¿Desea continuar?", "Cambios pendientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If res = System.Windows.Forms.DialogResult.No Then
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub btn_seleccionar_Click(sender As Object, e As EventArgs) Handles btn_seleccionar.Click
        Me.Close()
    End Sub

    Private Sub txt_buscar_nombre_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_buscar_nombre.KeyUp
        Me.cargarGrillaEstados(Me.txt_buscar_nombre.Text)
    End Sub
End Class