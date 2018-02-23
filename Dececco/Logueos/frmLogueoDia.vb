Public Class frmLogueoDia
    Dim id_usuario As Integer
    Dim loaded As Boolean = False
    Public Sub New(ByVal id_usuario As Integer)

        Me.id_usuario = id_usuario
        InitializeComponent()

    End Sub

    Private Sub frmLogueoDia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dt As New DataTable
        dt = oUsuario.ConsultarNombreCompleto()
        dt.Rows.Add(0, " - Todos - ")
        cmb_usuarios.DataSource = dt
        cmb_usuarios.ValueMember = "Id_usuario"
        cmb_usuarios.DisplayMember = "Nombre_completo"
        cmb_usuarios.SelectedValue = 0

        dt = oCliente.ConsultarTodo()
        dt.Rows.Add(0, " - Todos - ")
        cmb_cliente.DataSource = dt
        cmb_cliente.ValueMember = "Id_cliente"
        cmb_cliente.DisplayMember = "Nombre_cliente"
        cmb_cliente.SelectedValue = 0


        dt = oProyecto.ObtenerProyectos(0)
        dt.Rows.Add(0, "", " - Todos - ")
        cmb_proyecto.DataSource = dt
        cmb_proyecto.ValueMember = "Id_proyecto"
        cmb_proyecto.DisplayMember = "Nombre_proyecto"
        cmb_proyecto.SelectedValue = 0

        dtp_fecha_desde.Value = Date.Today
        dtp_fecha_hasta.Value = Date.Today

        loaded = True
        Me.ActualizarGrillaLogueo()
    End Sub

    Private Sub cmb_usuario_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_usuarios.SelectedValueChanged, dtp_fecha_desde.ValueChanged, dtp_fecha_hasta.ValueChanged, cmb_proyecto.SelectedValueChanged
        ActualizarGrillaLogueo()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ActualizarGrillaLogueo()
    End Sub

    Private Sub ActualizarGrillaLogueo()
        Try
            If loaded Then
                Dim dt As DataTable
                Dim dr_index As Integer
                dt = oCuerpo_movimiento_hora.GetLogueoDia(CInt(cmb_usuarios.SelectedValue), dtp_fecha_desde.Value, dtp_fecha_hasta.Value, CInt(cmb_cliente.SelectedValue), CInt(cmb_proyecto.SelectedValue))

                dgv_logueo_dia.Rows.Clear()

                For Each row As DataRow In dt.Rows
                    dr_index = dgv_logueo_dia.Rows.Add()
                    With dgv_logueo_dia.Rows(dr_index)
                        .Cells("id_movimiento_hora").Value = row.Item("id_movimiento_hora").ToString()
                        .Cells("id_cuerpo_movimiento_hora").Value = row.Item("id_cuerpo_movimiento_hora").ToString()
                        .Cells("nombre_usuario").Value = row.Item("Nombre").ToString()
                        .Cells("fecha").Value = CDate(row.Item("Fecha"))
                        .Cells("hora_entrada").Value = row.Item("Hora Entrada").ToString()
                        .Cells("hora_salida").Value = row.Item("Hora Salida").ToString()
                        .Cells("tiempo").Value = row.Item("Tiempo").ToString()
                        .Cells("cliente").Value = row.Item("Cliente").ToString()
                        .Cells("proyecto").Value = row.Item("Proyecto").ToString()
                        .Cells("subproyecto").Value = row.Item("Subproyecto").ToString()
                        .Cells("actividad").Value = row.Item("Actividad").ToString()
                        .Cells("tipo_logueo").Value = row.Item("Tipo").ToString()
                    End With
                Next

                Me.dgv_logueo_dia.Columns("fecha").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.dgv_logueo_dia.Columns("hora_entrada").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.dgv_logueo_dia.Columns("hora_salida").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Me.dgv_logueo_dia.Columns("tiempo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                Me.dgv_logueo_dia.Sort(Me.dgv_logueo_dia.Columns("fecha"), System.ComponentModel.ListSortDirection.Ascending)

                If dgv_logueo_dia.Rows.Count > 0 Then
                    Dim time_span As TimeSpan
                    Dim tiempo As TimeSpan

                    For Each row As DataGridViewRow In dgv_logueo_dia.Rows
                        time_span = CDate(row.Cells("hora_salida").Value).Subtract(CDate(CDate(row.Cells("hora_entrada").Value).ToString("HH:mm:ss")))
                        tiempo = tiempo + time_span
                    Next
                    Me.lbl_total_horas.Text = String.Format("{0} horas {1} minutos {2} segundos", _
                             CInt(Math.Truncate(tiempo.TotalHours)), _
                             tiempo.Minutes, _
                             tiempo.Seconds)
                Else
                    Me.lbl_total_horas.Text = "0"
                End If

                Dim hora As String

                For Each row As DataGridViewRow In dgv_logueo_dia.Rows
                    hora = row.Cells("tiempo").Value.ToString()
                    hora = TimeSpan.FromSeconds(CDbl(hora)).ToString("hh\:mm\:ss")
                    row.Cells("tiempo").Value = hora
                Next
            End If

        Catch ex As Exception

        End Try
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frmDetalleLogueo As New frmDetalleLogueo(0)
        frmDetalleLogueo.ShowDialog()
        Me.ActualizarGrillaLogueo()
    End Sub

    Private Sub ts_modificar_Click(sender As Object, e As EventArgs) Handles ts_modificar.Click
        Dim frmDetalleLogueo As New frmDetalleLogueo(CInt(dgv_logueo_dia.SelectedRows(0).Cells("id_cuerpo_movimiento_hora").Value))
        frmDetalleLogueo.ShowDialog()
        Me.ActualizarGrillaLogueo()
    End Sub


    Private Sub dgv_logueo_dia_MouseDown(sender As Object, e As MouseEventArgs) Handles dgv_logueo_dia.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim currentMouseOverRow As Integer
            currentMouseOverRow = dgv_logueo_dia.HitTest(e.X, e.Y).RowIndex

            If currentMouseOverRow >= 0 Then
                dgv_logueo_dia.ClearSelection()
                dgv_logueo_dia.Rows(currentMouseOverRow).Selected = True
                ts_horas.Show(dgv_logueo_dia, New Point(e.X, e.Y))
            End If
        End If
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


End Class