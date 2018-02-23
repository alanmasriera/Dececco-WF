Imports ControladoresLogica
Imports Entidades

Public Class frmAgregarSubproyecto

    Dim id_subproyecto As Integer
    Dim id_proyecto As Integer
    Dim nuevo_subproyecto As New SUBPROYECTO
    Dim tipo_subproyecto As New entTipo_Subproyecto

    Public Sub New(ByVal id_proyecto As Integer, ByVal id_subproyecto As Integer)

        InitializeComponent()
        Me.id_proyecto = id_proyecto
        Me.id_subproyecto = id_subproyecto

    End Sub

    Private Sub frmAgregarSubproyecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarComboTipoSubproyecto()
    End Sub

    Private Sub CargarComboTipoSubproyecto()

        Me.cmb_tipo_subproyecto.DataSource = tipo_subproyecto.GetCMB_TipoSubproyecto()
        Me.cmb_tipo_subproyecto.ValueMember = "id_tipo_subproyecto"
        Me.cmb_tipo_subproyecto.DisplayMember = "nombre_tipo_subproyecto"

        Me.cmb_actividad_subproyecto.DataSource = oActividad.GetTipoActividad()
        Me.cmb_actividad_subproyecto.ValueMember = "id_tipo_actividad"
        Me.cmb_actividad_subproyecto.DisplayMember = "descripcion"

        Me.cmb_actividad_control_subproyecto.DataSource = oActividad.GetTipoActividad()
        Me.cmb_actividad_control_subproyecto.ValueMember = "id_tipo_actividad"
        Me.cmb_actividad_control_subproyecto.DisplayMember = "descripcion"

        Dim odt As DataTable
        odt = oControl.GetCmb()

        Me.cmb_control.DataSource = odt
        Me.cmb_control.ValueMember = "id_control"
        Me.cmb_control.DisplayMember = "nombre_control"

        odt = oControl.GetCmb()
        odt.Rows.Add(0, "", 0)

        CType(Me.dgv_controles_subproyecto.Columns("nombre_control_subproyecto"), DataGridViewComboBoxColumn).DataSource = odt
        CType(Me.dgv_controles_subproyecto.Columns("nombre_control_subproyecto"), DataGridViewComboBoxColumn).DisplayMember = "nombre_control"
        CType(Me.dgv_controles_subproyecto.Columns("nombre_control_subproyecto"), DataGridViewComboBoxColumn).ValueMember = "id_control"

    End Sub

    Private Sub CargarActividades()
        Dim dt As DataTable

        Dim row_index As Integer

        dt = tipo_subproyecto.GetActividadesTipoProyecto(CInt(Me.cmb_tipo_subproyecto.SelectedValue))
        Me.dgv_actividades_subproyecto.Rows.Clear()
        For Each row As DataRow In dt.Rows
            row_index = dgv_actividades_subproyecto.Rows.Add()
            dgv_actividades_subproyecto.Rows(row_index).Cells("id_tipo_actividad").Value = row.Item("id_tipo_actividad").ToString()
            dgv_actividades_subproyecto.Rows(row_index).Cells("nombre_actividad").Value = row.Item("descripcion").ToString()
            dgv_actividades_subproyecto.Rows(row_index).Cells("Peso").Value = CDec(row.Item("criticidad"))

        Next

        Me.actualizarPesos()

    End Sub

    Private Sub actualizarPesos()

        Dim total_peso As Decimal = 0

        For Each row As DataGridViewRow In dgv_actividades_subproyecto.Rows
            total_peso = total_peso + CDec(row.Cells("Peso").Value)
        Next

        For Each row As DataGridViewRow In dgv_actividades_subproyecto.Rows
            row.Cells("Peso").Value = CDec(row.Cells("Peso").Value) / total_peso * 100
        Next

    End Sub


    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click

        Dim _Control_Subproyecto As New Control_Subproyecto
        Dim acti_proy As New Entidades.Actividad_proyecto

        For I = 1 To txt_cantidad.Value
            With nuevo_subproyecto
                .nombre = txt_nombre.Text + " " & I
                .id_tipo_subproyecto = CInt(cmb_tipo_subproyecto.SelectedValue)
                .fecha_inicio_estimada = Date.Now
                .fecha_fin_estimada = Date.Now
                .orden = 99999
                .ot = 0
                .genera_ot = chk_genera_ot.Checked
                .asignacion_automatica = False

                If id_subproyecto = 0 Then
                    .id_subproyecto_padre = 1
                    .id_proyecto = Me.id_proyecto
                Else
                    .id_subproyecto_padre = Me.id_subproyecto
                    .id_proyecto = Me.id_proyecto
                End If
                ControladorSubproyecto.InsertarSubproyecto(nuevo_subproyecto)

                If .genera_ot Then
                    ControladorSubproyecto.AsignarOT(nuevo_subproyecto.id_subproyecto)
                Else
                    Dim subp As New entSubproyecto
                    subp.ObtenerOTPadre(nuevo_subproyecto.id_subproyecto)
                End If

            End With



            Dim id_Actividad_actual As Integer

            For Each row As DataGridViewRow In dgv_actividades_subproyecto.Rows
                With oActividad
                    .Cargar()
                    .Insertar()
                    .id_tipo_actividad = CInt(row.Cells("id_tipo_actividad").Value)
                    .nombre_actividad = CStr(row.Cells("nombre_actividad").Value)
                    .costo_standart = CDec(row.Cells("Peso").Value) 'PESO
                    .tiempo_standart = 0
                    .Guardar()
                    id_Actividad_actual = .id_actividad

                    With acti_proy
                        .avance = 0
                        .cantidad_hora = 0
                        .complejidad = 0
                        .orden = row.Index + 1
                        .fecha_inicio = nuevo_subproyecto.fecha_fin_estimada

                        If row.Cells("fecha_fin_actividad").Value Is Nothing Then
                            .forzada_fecha_fin = False
                            .fecha_fin_previsto = nuevo_subproyecto.fecha_fin_estimada
                        ElseIf row.Cells("fecha_fin_actividad").Value IsNot Nothing And row.Cells("fecha_fin_actividad").Value.ToString() = "" Then
                            .forzada_fecha_fin = False
                            .fecha_fin_previsto = nuevo_subproyecto.fecha_fin_estimada
                        Else
                            .forzada_fecha_fin = True
                            .fecha_fin_previsto = CDate(row.Cells("fecha_fin_actividad").Value)
                        End If

                        .id_cliente = 0
                        .id_proyecto = Me.id_proyecto
                        .id_subproyecto = nuevo_subproyecto.id_subproyecto
                        .id_actividad = id_Actividad_actual
                        .id_control = 0
                        .id_controlador_1 = 0
                        .id_controlador_2 = 0
                        .porcentaje_avance = 0
                        .asignada = False
                         ControladorActividades.InsertarActividadProyecto(acti_proy)
                    End With

                End With
            Next


            For Each row As DataGridViewRow In Me.dgv_controles_subproyecto.Rows
                If row.Cells("nombre_control_subproyecto").Value IsNot Nothing Then
                    With _Control_Subproyecto
                        .Cargar()
                        .Insertar()
                        .id_control = CInt(row.Cells("nombre_control_subproyecto").Value)
                        .id_subproyecto = nuevo_subproyecto.id_subproyecto
                        .id_tipo_actividad = CInt(row.Cells("id_tipo_actividad_control_subproyecto").Value)
                        If .id_control <> 0 Then
                            .Guardar()
                        End If
                    End With
                End If
            Next

        Next

        ControladorProyecto.ActualizarHorasSubproyecto(ControladorProyecto.ObtenerPorID(Me.id_proyecto))
        Me.Close()
    End Sub

    Private Sub btn_agregar_actividad_subproyecto_Click(sender As Object, e As EventArgs) Handles btn_agregar_actividad_subproyecto.Click
        'Me.dgv_actividades_subproyecto.Rows.Add(cmb_actividad_subproyecto.SelectedValue, oTipo_actividad.GetOne(CInt(cmb_actividad_subproyecto.SelectedValue)).Rows(0).Item("descripcion").ToString(), oTipo_actividad.GetOne(CInt(cmb_actividad_subproyecto.SelectedValue)).Rows(0).Item("criticidad").ToString())

        Dim dr_index As Integer
        dr_index = Me.dgv_actividades_subproyecto.Rows.Add()
        With Me.dgv_actividades_subproyecto.Rows(dr_index)
            .Cells("id_tipo_actividad").Value = cmb_actividad_subproyecto.SelectedValue
            .Cells("nombre_Actividad").Value = Me.cmb_actividad_subproyecto.Text
            .Cells("Peso").Value = oTipo_actividad.GetOne(CInt(cmb_actividad_subproyecto.SelectedValue)).Rows(0).Item("criticidad").ToString()
            If Me.chk_forzar_fecha_fin_actividad.Checked Then
                .Cells("fecha_fin_actividad").Value = Me.dtp_fecha_fin_actividad.Value
            Else
                .Cells("fecha_fin_actividad").Value = ""
            End If
        End With

        Me.actualizarPesos()
        Me.PesosCorrectosSubproyceto()
    End Sub

    Private Sub cmb_tipo_subproyecto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tipo_subproyecto.SelectedIndexChanged
        Try
            Me.CargarActividades()
            Me.PesosCorrectosSubproyceto()
            Me.txt_nombre.Text = Me.cmb_tipo_subproyecto.Text
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dgv_actividades_subproyecto_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_actividades_subproyecto.CellEndEdit
        Me.PesosCorrectosSubproyceto()
    End Sub

    Private Function PesosCorrectosSubproyceto() As Boolean

        Dim total_peso As Decimal = 0

        For Each row As DataGridViewRow In dgv_actividades_subproyecto.Rows
            total_peso = total_peso + CDec(row.Cells("Peso").Value)
        Next

        Me.lbl_suma_pesos_subproyecto.Text = total_peso.ToString("0.00")

        If total_peso < 99 And total_peso <> 0 Or total_peso > 101 And total_peso <> 0 Then
            Me.btn_aceptar.Enabled = False
            Me.lbl_suma_pesos_subproyecto.ForeColor = Color.OrangeRed
        Else
            Me.btn_aceptar.Enabled = True
            Me.lbl_suma_pesos_subproyecto.ForeColor = Color.Green
        End If

        If (total_peso > 98 And total_peso < 102) Or total_peso = 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub dgv_actividades_subproyecto_MouseDown(sender As Object, e As MouseEventArgs) Handles dgv_actividades_subproyecto.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim currentMouseOverRow As Integer
            currentMouseOverRow = dgv_actividades_subproyecto.HitTest(e.X, e.Y).RowIndex

            If currentMouseOverRow >= 0 Then
                dgv_actividades_subproyecto.ClearSelection()
                dgv_actividades_subproyecto.Rows(currentMouseOverRow).Selected = True
                ts_actividad_subproyecto.Show(dgv_actividades_subproyecto, New Point(e.X, e.Y))
            End If
        End If
    End Sub

    Private Sub ts_borrar_actividad_subproyecto_Click(sender As Object, e As EventArgs) Handles ts_borrar_actividad_subproyecto.Click
        If dgv_actividades_subproyecto.SelectedRows.Count > 0 Then
            Me.dgv_actividades_subproyecto.Rows.Remove(dgv_actividades_subproyecto.SelectedRows(0))
            Me.actualizarPesos()
            Me.PesosCorrectosSubproyceto()
        End If
    End Sub


    Private Sub btn_agregar_control_subproyecto_Click(sender As Object, e As EventArgs) Handles btn_agregar_control_subproyecto.Click
        If Me.cmb_control.SelectedValue IsNot Nothing And Me.cmb_actividad_control_subproyecto.SelectedValue IsNot Nothing Then

            For Each row As DataGridViewRow In Me.dgv_controles_subproyecto.Rows
                If CInt(row.Cells("id_tipo_actividad_control_subproyecto").Value) = CInt(Me.cmb_actividad_control_subproyecto.SelectedValue) Then
                    Exit Sub
                End If
            Next

            Dim index As Integer
            index = Me.dgv_controles_subproyecto.Rows.Add()
            Me.dgv_controles_subproyecto.Rows(index).Cells("id_tipo_actividad_control_subproyecto").Value = CInt(Me.cmb_actividad_control_subproyecto.SelectedValue)
            Me.dgv_controles_subproyecto.Rows(index).Cells("nombre_actividad_control_subproyecto").Value = cmb_actividad_control_subproyecto.Text
            Me.dgv_controles_subproyecto.Rows(index).Cells("nombre_control_subproyecto").Value = CInt(cmb_control.SelectedValue)

        End If
    End Sub

    Private Sub chk_forzar_fecha_fin_actividad_CheckedChanged(sender As Object, e As EventArgs) Handles chk_forzar_fecha_fin_actividad.CheckedChanged
        Me.dtp_fecha_fin_actividad.Enabled = Me.chk_forzar_fecha_fin_actividad.Checked
    End Sub


End Class