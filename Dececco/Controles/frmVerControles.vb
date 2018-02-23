Public Class frmVerControles

    Private Sub frmVerControles_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargarGrillas()
        RefrescarControl()
    End Sub

    Sub RefrescarControl()
        Dim odtPendiente As New DataTable
        Dim odtEspera As New DataTable
        Dim odtCompletado As New DataTable

        'Pendiente
        odtPendiente = oVoz.GetAllInicio_4_PM_Todos(CInt(cmb_proyecto.SelectedValue), CInt(cmb_control.SelectedValue), "", CInt(cmb_cliente.SelectedValue), CInt(cmb_usuarios.SelectedValue), CInt(cmb_controlador_1.SelectedValue), CInt(cmb_controlador_2.SelectedValue), dtp_fecha_desde.Value, dtp_fecha_hasta.Value, chk_proyecto.Checked, chk_cadista.Checked, chk_etapas.Checked, chk_control.Checked, chk_clientes.Checked, chk_concepto.Checked, chk_preparado.Checked, chk_detallado.Checked, chk_fecha.Checked, 0, Me.txt_nombre.Text)
        Me.dgv_controles.DataSource = odtPendiente
        Me.dgv_controles.Columns(0).Visible = False
        Me.dgv_controles.Columns(1).Visible = False
        Me.dgv_controles.Columns(2).Visible = False
        Me.dgv_controles.Columns(3).Visible = False



        Me.dgv_controles.Columns(4).Visible = chk_etapas.Checked
        Me.dgv_controles.Columns(5).Visible = chk_etapas.Checked
        Me.dgv_controles.Columns(6).Visible = chk_etapas.Checked
        Me.dgv_controles.Columns(7).Visible = chk_etapas.Checked
        Me.dgv_controles.Columns(8).Visible = chk_etapas.Checked

        'Me.dgv_controles.Columns("Completado").SortMode = DataGridViewColumnSortMode.Automatic
        'Me.dgv_controles.Columns("P1").SortMode = DataGridViewColumnSortMode.Automatic
        'Me.dgv_controles.Columns("1").SortMode = DataGridViewColumnSortMode.Automatic
        'Me.dgv_controles.Columns("P2C").SortMode = DataGridViewColumnSortMode.Automatic
        'Me.dgv_controles.Columns("P2").SortMode = DataGridViewColumnSortMode.Automatic
        'Me.dgv_controles.Columns("2").SortMode = DataGridViewColumnSortMode.Automatic

        Me.dgv_controles.Columns("id_movimiento_voz").Visible = False
        Me.dgv_controles.Columns("id_usuario_anterior").Visible = False

        Me.dgv_controles.Columns("Cliente").Visible = chk_clientes.Checked
        Me.dgv_controles.Columns("Control").Visible = chk_control.Checked
        Me.dgv_controles.Columns("Proyecto").Visible = chk_proyecto.Checked
        Me.dgv_controles.Columns("Fecha").Visible = chk_fecha.Checked

        Me.dgv_controles.Columns("Cadista").Visible = chk_cadista.Checked
        Me.dgv_controles.Columns("Controlador 1").Visible = chk_cadista.Checked
        Me.dgv_controles.Columns("Controlador 2").Visible = chk_cadista.Checked

        If dgv_controles.Rows.Count > 0 Then
            Me.dgv_controles.Rows.Item(0).Selected = True
        End If


    End Sub


    Private Sub cargarGrillas()

        dtp_fecha_desde.Value = DateAdd(DateInterval.Year, -15, Date.Now)

        Dim dt As DataTable
        dt = oControl.ConsultarTodo()
        dt.Rows.Add(0, " - Todos - ")

        cmb_control.DataSource = dt
        cmb_control.ValueMember = "id control"
        cmb_control.DisplayMember = "nombre control"
        cmb_control.SelectedValue = 0


        dt = oCliente.ConsultarTodo()
        dt.Rows.Add(0, " - Todos - ")
        cmb_cliente.DataSource = dt
        cmb_cliente.ValueMember = "Id_cliente"
        cmb_cliente.DisplayMember = "Nombre_cliente"
        cmb_cliente.SelectedValue = 0

        dt = oUsuario.ConsultarNombreCompleto()
        dt.Rows.Add(0, " - Todos - ")
        cmb_usuarios.DataSource = dt
        cmb_usuarios.ValueMember = "Id_usuario"
        cmb_usuarios.DisplayMember = "Nombre_completo"
        cmb_usuarios.SelectedValue = 0

        dt = oUsuario.ConsultarNombreCompleto()
        dt.Rows.Add(0, " - Todos - ")
        cmb_controlador_1.DataSource = dt
        cmb_controlador_1.ValueMember = "Id_usuario"
        cmb_controlador_1.DisplayMember = "Nombre_completo"
        cmb_controlador_1.SelectedValue = 0

        dt = oUsuario.ConsultarNombreCompleto()
        dt.Rows.Add(0, " - Todos - ")
        cmb_controlador_2.DataSource = dt
        cmb_controlador_2.ValueMember = "Id_usuario"
        cmb_controlador_2.DisplayMember = "Nombre_completo"
        cmb_controlador_2.SelectedValue = 0

        dt = oProyecto.ObtenerProyectos(0)
        dt.Rows.Add(0, "", " - Todos - ")
        cmb_proyecto.DataSource = dt
        cmb_proyecto.ValueMember = "Id_proyecto"
        cmb_proyecto.DisplayMember = "Nombre_proyecto"
        cmb_proyecto.SelectedValue = 0


    End Sub


    Private Sub cmb_cliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_cliente.SelectedIndexChanged
        If cmb_cliente.SelectedIndex <> 0 Then
            Dim dt As DataTable
            dt = oProyecto.ObtenerProyectos(CInt(cmb_cliente.SelectedValue))
            dt.Rows.Add(0, "", " - Todos - ")
            cmb_proyecto.DataSource = dt
            cmb_proyecto.ValueMember = "Id_proyecto"
            cmb_proyecto.DisplayMember = "Nombre_proyecto"
            cmb_proyecto.SelectedValue = 0
        End If
    End Sub

    Private Sub btn_ver_reporte_Click(sender As Object, e As EventArgs) Handles btn_ver_reporte.Click
        RefrescarControl()
    End Sub

    Private Sub Background_pdf_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Background_pdf.DoWork
        Try
            Dim proc As New ProcedimientosParticulares
            proc.RealizarProcedimiento(CInt(dgv_controles.SelectedRows(0).Cells("id_movimiento_voz").Value))

        Catch ex As Exception
            MessageBox.Show("Debe seleccionar un control")
        End Try
    End Sub

    Private Sub dgv_controles_MouseClick(sender As Object, e As MouseEventArgs) Handles dgv_controles.MouseClick

        If e.Button = MouseButtons.Right Then
            Dim currentMouseOverRow As Integer
            currentMouseOverRow = dgv_controles.HitTest(e.X, e.Y).RowIndex

            If currentMouseOverRow >= 0 Then
                'm.MenuItems.Add(New MenuItem(String.Format("Do something to row {0}", currentMouseOverRow.ToString())))
                dgv_controles.ClearSelection()
                dgv_controles.Rows(currentMouseOverRow).Selected = True
                ts_imprimir.Show(dgv_controles, New Point(e.X, e.Y))
            End If
        End If
    End Sub

    Private Sub VerControlesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ts_imprimir_checklist.Click
        Try
            Background_pdf.RunWorkerAsync()
            MessageBox.Show("Este proceso puede demorar. Se abrirá el PDF una vez finalizado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgv_controles_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgv_controles.DataBindingComplete
        'dgv_controles.Columns("Proyecto").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub txt_nombre_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_nombre.KeyUp
        Me.btn_ver_reporte_Click(Nothing, Nothing)
    End Sub
End Class