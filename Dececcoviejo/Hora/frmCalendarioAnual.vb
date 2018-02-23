Public Class frmCalendarioAnual
    Dim _Calendario As New Calendario
    Dim cargando As Boolean = False
    Dim _id_calendario_usuario_global As Integer = 0

    Private Sub calendario_DateSelected(sender As Object, e As DateRangeEventArgs) Handles calendario_control.DateSelected
        Dim fecha_seleccionada As Date

        cargando = True
        fecha_seleccionada = e.Start

        With _Calendario
            .Cargar()
            If .Exist_2(fecha_seleccionada) <> 0 Then
                .Modificar(.Exist_2(fecha_seleccionada))
                Me.txt_dia_seleccionado.Text = fecha_seleccionada.ToString("dd/MM/yyyy")
                Me.txt_nombre_dia.Text = WeekdayName(fecha_seleccionada.DayOfWeek + 1)
                Me.dtp_hora_inicio.Value = .hora_inicio
                Me.dtp_hora_fin.Value = .hora_fin
                Me.chk_dia_laboral.Checked = .dia_laboral
                Me.chk_feriado.Checked = .feriado

                Me.cargarMiembrosCalendario()
                Me.ActualziarDatosPersonal()

                Me.cargando = False
                Me.TabControl1.Enabled = True
            Else
                Me.LimpiarDatosPersonal()
                Me.dgv_miembros_subproyecto.Rows.Clear()
                Me.chk_feriado.Checked = False
                Me.chk_dia_laboral.Checked = False
                Me.dtp_hora_inicio.Value = Date.Now
                Me.dtp_hora_fin.Value = Date.Now
                Me.TabControl1.Enabled = False
            End If
        End With



        
    End Sub

    Private Sub chk_feriado_CheckedChanged(sender As Object, e As EventArgs) Handles chk_feriado.CheckedChanged
        If Me.cargando = False Then
            Me.chk_dia_laboral.Checked = False
            With _Calendario
                If .id_calendario <> 0 Then
                    .feriado = Me.chk_feriado.Checked
                    .Guardar()
                End If
            End With
        End If
    End Sub

    Private Sub chk_dia_laboral_CheckedChanged(sender As Object, e As EventArgs) Handles chk_dia_laboral.CheckedChanged
        If cargando = False Then
            With _Calendario
                If .id_calendario <> 0 Then
                    .dia_laboral = Me.chk_dia_laboral.Checked
                    .Guardar()
                End If
            End With
        End If
    End Sub

    Private Sub dtp_hora_inicio_ValueChanged(sender As Object, e As EventArgs) Handles dtp_hora_inicio.ValueChanged
        If cargando = False Then
            With _Calendario
                If .id_calendario <> 0 Then
                    .hora_inicio = Me.dtp_hora_inicio.Value
                    .Guardar()
                End If
            End With
        End If
    End Sub

    Private Sub dtp_hora_fin_ValueChanged(sender As Object, e As EventArgs) Handles dtp_hora_fin.ValueChanged
        If cargando = False Then
            With _Calendario
                If .id_calendario <> 0 Then
                    .hora_fin = Me.dtp_hora_fin.Value
                    .Guardar()
                End If
            End With
        End If
    End Sub

    Private Sub frmCalendarioAnual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With _Calendario
            .Cargar()
            .Insertar()
        End With

        Me.CargarCombos()
        Me.cargarMiembrosCalendario()
    End Sub

    Private Sub CargarCombos()
        Dim odt As Datatable
        Dim _Usuario As New Usuario
        Dim _Calendario_Usuario As New Calendario_usuario

        odt = oUsuario.GetCmb
        With Me.cmb_miembros_calendario
            .DataSource = odt
            .DisplayMember = "nombre_usuario"
            .ValueMember = "id_usuario"
        End With

        Dim id_selected As Integer = 0
        If Me.cmb_miembro_personal.SelectedValue IsNot Nothing Then
            id_selected = CInt(Me.cmb_miembro_personal.SelectedValue)
        End If

        If _Calendario.id_calendario <> 0 Then
            odt = _Calendario_Usuario.GetMiembrosAnio(_Calendario.fecha.Year)
            With Me.cmb_miembro_personal
                .DataSource = odt
                .DisplayMember = "nombre_usuario"
                .ValueMember = "id_usuario"
                .SelectedValue = id_selected
            End With
        End If

    End Sub

    Private Sub btn_agregar_miembro_calendario_Click(sender As Object, e As EventArgs) Handles btn_agregar_miembro_calendario.Click
        Dim odt_anio As DataTable
        Dim _CalendarioUsuario As New Calendario_usuario


        If Me.cmb_miembros_calendario.SelectedValue IsNot Nothing Then

            'Verifica que no se encuentre el usuario en la grilla
            Dim encontrado As Boolean = False
            For Each row As DataGridViewRow In dgv_miembros_subproyecto.Rows
                If CInt(row.Cells("id_usuario").Value) = CInt(Me.cmb_miembros_calendario.SelectedValue) Then
                    encontrado = True
                    Exit Sub
                End If
            Next

            odt_anio = _Calendario.GetAllAnio(_Calendario.fecha.Year)
            For Each row As DataRow In odt_anio.Rows
                With _CalendarioUsuario
                    .Cargar()
                    .Insertar()
                    .id_calendario = CInt(row.Item("id_calendario"))
                    .motivo = ""
                    .trabaja = CBool(row.Item("dia_laboral"))
                    .id_usuario = CInt(Me.cmb_miembros_calendario.SelectedValue)
                    .hora_inicio = CDate(row.Item("hora_inicio"))
                    .hora_fin = CDate(row.Item("hora_fin"))
                    .Guardar()
                End With
            Next

        End If
        Me.cargarMiembrosCalendario()
    End Sub

    Private Sub cargarMiembrosCalendario()
        Dim odt As DataTable
        Dim _Calendario_Usuario As New Calendario_usuario
        Dim index As Integer = 0

        Me.dgv_miembros_subproyecto.Rows.Clear()

        odt = _Calendario_Usuario.GetMiembrosAnio(_Calendario.fecha.Year)
        For Each row As DataRow In odt.Rows
            With Me.dgv_miembros_subproyecto
                index = Me.dgv_miembros_subproyecto.Rows.Add()
                .Rows(index).Cells("id_usuario").Value = row.Item("id_usuario")
                .Rows(index).Cells("nombre_usuario").Value = row.Item("nombre_usuario")
            End With
        Next

        Me.LimpiarDatosPersonal()
        Me.CargarCombos()
    End Sub

    Private Sub cmb_miembro_personal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_miembro_personal.SelectedIndexChanged
        If cargando = False Then
            Me.ActualziarDatosPersonal()
        End If
    End Sub

    Private Sub ActualziarDatosPersonal()

        If Me.cmb_miembro_personal.SelectedValue IsNot Nothing Then
            Dim id_usuario As Integer = CInt(Me.cmb_miembro_personal.SelectedValue)
            Dim _Calendario_usuario As New Calendario_usuario

            Dim odt As DataTable
            odt = _Calendario_usuario.GetDia(_Calendario.fecha, id_usuario)

            Me.LimpiarDatosPersonal()

            If odt.Rows.Count > 0 Then
                Me.txt_nombre_usuario.Text = odt.Rows(0).Item("nombre").ToString()
                Me.txt_apellido_usuario.Text = odt.Rows(0).Item("apellido").ToString()
                Me.dtp_hora_desde_personal.Value = CDate(odt.Rows(0).Item("hora_inicio"))
                Me.dtp_hora_hasta_personal.Value = CDate(odt.Rows(0).Item("hora_fin"))
                Me.txt_motivo_personal.Text = odt.Rows(0).Item("motivo").ToString()
                Me._id_calendario_usuario_global = CInt(odt.Rows(0).Item("id_calendario_usuario"))
                Me.chk_trabaja_personal.Checked = CBool(odt.Rows(0).Item("trabaja"))
            End If

        End If
    End Sub

    Private Sub LimpiarDatosPersonal()
        Me._id_calendario_usuario_global = 0
        Me.txt_nombre_usuario.Text = ""
        Me.txt_apellido_usuario.Text = ""
        Me.dtp_hora_desde_personal.Value = Date.Now
        Me.dtp_hora_hasta_personal.Value = Date.Now
        Me.chk_trabaja_personal.Checked = False
        Me.txt_motivo_personal.Text = ""
    End Sub

    Private Sub btn_guardar_personal_Click(sender As Object, e As EventArgs) Handles btn_guardar_personal.Click
        If _id_calendario_usuario_global <> 0 Then
            Dim _Calendario_usuario As New Calendario_usuario

            With _Calendario_usuario
                .Cargar()
                .Modificar(Me._id_calendario_usuario_global)
                .motivo = Me.txt_motivo_personal.Text
                .trabaja = Me.chk_trabaja_personal.Checked
                .hora_inicio = Me.dtp_hora_desde_personal.Value
                .hora_fin = Me.dtp_hora_hasta_personal.Value
                .Guardar()
            End With

            MessageBox.Show("Calendario actualizado con éxito", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

End Class