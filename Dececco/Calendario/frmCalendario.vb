Imports Entidades
Imports ControladoresLogica

Public Class frmCalendario
    Private Sub btnDetalles_Click(sender As Object, e As EventArgs) Handles btnDetalles.Click
        If TabControl1.SelectedTab.Equals(tabSemanasLaborales) And dgv_semanas_laborales.SelectedRows.Count > 0 Then
            Dim defCale As Definicion_Calendario_Laboral
            defCale = ControladorCalendario.ObtenerDefinicionPorID(dgv_semanas_laborales.Item(id_detalle_calendario_dgv.Index,dgv_semanas_laborales.SelectedRows(0).Index).Value)
            Dim frmDetalle As New frmDetalleCalSemanal(defCale)
            frmDetalle.ShowDialog

        Else
            If dgvExcepciones.SelectedRows.Count > 0 Then
                Dim exce As Excepcion_Calendario
                exce = ControladorCalendario.ObtenerExcepcionPorID(dgvExcepciones.Item(id_excepcion_dgv.Index,dgvExcepciones.SelectedRows(0).Index).Value)
                Dim frmExcepcion As New frmDetalleExcepcion(exce)
                frmExcepcion.ShowDialog()
                End If
        End If
        CargarCombos
    End Sub

    Private Sub InsertarDetalleCalendario()
        Dim definicion As New Definicion_Calendario_Laboral

        With definicion
            .nombre_definicion = dgv_semanas_laborales.Item(nombre_detalle_calendario_dgv.Index, dgv_semanas_laborales.SelectedRows(0).Index).Value
            .fecha_desde = Convert.ToDateTime(dgv_semanas_laborales.Item(fecha_comienzo_detalle_calendario_dgv.Index,dgv_semanas_laborales.SelectedRows(0).Index).Value)
            .fecha_hasta = Convert.ToDateTime(dgv_semanas_laborales.Item(fecha_fin_detalle_calendario_dgv.Index,dgv_semanas_laborales.SelectedRows(0).Index).Value)
        End With

        ControladorCalendario.Insertar(definicion)

    End Sub

    Private Sub btnCrearCalendario_Click(sender As Object, e As EventArgs) Handles btnCrearCalendario.Click
        Dim frmNvo As New frmNuevoCalendario
        If frmNvo.ShowDialog = DialogResult.OK Then
            CargarCalendarios
            cmbCalendarios.SelectedItem = frmNvo.calen
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub frmCalendario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCalendarios
    End Sub

    Private Sub CargarCalendarios()
        cmbCalendarios.DataSource = ControladorCalendario.ObtenerCalendarios()
        cmbCalendarios.ValueMember = "nombre_calendario"
    End Sub

    Private Sub btnAgregarDetalle_Click(sender As Object, e As EventArgs) Handles btnAgregarDetalle.Click
        Dim idRow As Integer

        If TabControl1.SelectedTab.Equals(tabSemanasLaborales) Then

            idRow = dgv_semanas_laborales.Rows.Add

            Dim definicion As New Definicion_Calendario_Laboral
            definicion.nombre_definicion = "[Sin nombre]"
            definicion.id_calendario_laboral = DirectCast(cmbCalendarios.SelectedItem, Calendario_Laboral).id_calendario_laboral
            definicion.fecha_desde = Date.Today
            definicion.fecha_hasta = Date.Today.AddMonths(1)

            With dgv_semanas_laborales.Rows.Item(idRow).Cells
            
                .Item(nombre_detalle_calendario_dgv.Index).Value = definicion.nombre_definicion
                .Item(fecha_comienzo_detalle_calendario_dgv.Index).Value = ""
                .Item(fecha_fin_detalle_calendario_dgv.Index).Value = ""

                definicion = ControladorCalendario.Insertar(definicion)

                .Item(id_detalle_calendario_dgv.Index).Value = definicion.id_definicion_calendario_laboral

            End With

        Else

            idRow = dgvExcepciones.Rows.Add
            Dim excepcion As New Excepcion_Calendario
            excepcion.nombre_excepcion = "[Sin nombre]"
            excepcion.id_calendario_laboral = DirectCast(cmbCalendarios.SelectedItem, Calendario_Laboral).id_calendario_laboral
            excepcion.fecha_comienzo = calendarioMeses.SelectionRange.Start
            excepcion.fecha_fin = calendarioMeses.SelectionRange.End
            excepcion.laborable = False
            excepcion.freq_type = 0
            excepcion.freq_interval = 0

             With dgvExcepciones.Rows.Item(idRow).Cells
            
                .Item(nombre_excepcion_dgv.Index).Value = excepcion.nombre_excepcion
                .Item(fecha_desde_excepcion_dgv.Index).Value = excepcion.fecha_comienzo
                .Item(fecha_fin_excepcion_dgv.Index).Value = excepcion.fecha_fin

                excepcion = ControladorCalendario.Insertar(excepcion)

                .Item(id_excepcion_dgv.Index).Value = excepcion.id_exception_calendario

            End With

        End If

    End Sub

    Private Sub cmbCalendarios_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbCalendarios.SelectedValueChanged
        CargarCombos
        If cmbCalendarios.SelectedItem IsNot Nothing Then
            If DirectCast(cmbCalendarios.SelectedItem, Calendario_Laboral).es_calendario_base Then
                lblCalBase.Visible = False
                cmbCalendarioBase.Visible = False
                Else
                lblCalBase.Visible = True
                cmbCalendarioBase.Visible = True

            End If
            End If

    End Sub

    Private SUb CargarCombos
        CargarDefiniciones(DirectCast(cmbCalendarios.SelectedItem, Calendario_Laboral))
        CargarExcepciones(DirectCast(cmbCalendarios.SelectedItem, Calendario_Laboral))
    End SUb

    Private Sub CargarDefiniciones(ByVal calendarioLaboral As Calendario_Laboral)
        Dim definiciones As List(Of Definicion_Calendario_Laboral)  = ControladorCalendario.ObtenerDefiniciones(calendarioLaboral)
        dgv_semanas_laborales.Rows.Clear

        For Each def In definiciones
            Dim idRow As Integer
            idRow = dgv_semanas_laborales.Rows.Add

            With dgv_semanas_laborales.Rows.Item(idRow).Cells
            
                .Item(nombre_detalle_calendario_dgv.Index).Value = def.nombre_definicion
                .Item(fecha_comienzo_detalle_calendario_dgv.Index).Value = def.fecha_desde
                .Item(fecha_fin_detalle_calendario_dgv.Index).Value = def.fecha_hasta
                .Item(id_detalle_calendario_dgv.Index).Value = def.id_definicion_calendario_laboral

        End With
        Next

    End Sub

    Private Sub CargarExcepciones(ByVal calendario As Calendario_Laboral)
        Dim excepciones As List(Of Excepcion_Calendario) = ControladorCalendario.ObtenerExcepciones(calendario)
        dgvExcepciones.Rows.Clear

        For Each exc In excepciones
            Dim idRow As Integer
            idRow = dgvExcepciones.Rows.Add

            With dgvExcepciones.Rows.Item(idRow).Cells
                .Item(nombre_excepcion_dgv.Index).Value = exc.nombre_excepcion
                .Item(fecha_desde_excepcion_dgv.Index).Value = exc.fecha_comienzo
                .Item(fecha_fin_excepcion_dgv.Index).Value = exc.fecha_fin
                .Item(id_excepcion_dgv.Index).Value = exc.id_exception_calendario
            End With
        Next

    End Sub

    Private Sub dgv_semanas_laborales_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_semanas_laborales.CellValueChanged
        If (e.ColumnIndex = fecha_comienzo_detalle_calendario_dgv.Index Or e.ColumnIndex = fecha_fin_detalle_calendario_dgv.Index  Or e.ColumnIndex = nombre_detalle_calendario_dgv.Index) And e.RowIndex >= 0 Then
            Dim def As Definicion_Calendario_Laboral
            def = ControladorCalendario.ObtenerDefinicionPorID(dgv_semanas_laborales.Item(id_detalle_calendario_dgv.Index,e.RowIndex).Value)

            If def IsNot Nothing Then
                def.fecha_desde = If(dgv_semanas_laborales.Item(fecha_comienzo_detalle_calendario_dgv.Index,e.RowIndex).Value <> "",dgv_semanas_laborales.Item(fecha_comienzo_detalle_calendario_dgv.Index,e.RowIndex).Value,Date.Today)
                def.fecha_hasta = If(dgv_semanas_laborales.Item(fecha_fin_detalle_calendario_dgv.Index,e.RowIndex).Value <> "", dgv_semanas_laborales.Item(fecha_fin_detalle_calendario_dgv.Index,e.RowIndex).Value, Date.Today)
                def.nombre_definicion = dgv_semanas_laborales.Item(nombre_detalle_calendario_dgv.Index, e.RowIndex).Value

                ControladorCalendario.ActualizarDefinicion(def)
            End If


        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If TabControl1.SelectedTab.Equals(tabSemanasLaborales) And dgv_semanas_laborales.SelectedRows.Count > 0 Then
            Dim defCale As Definicion_Calendario_Laboral
            defCale = ControladorCalendario.ObtenerDefinicionPorID(dgv_semanas_laborales.Item(id_detalle_calendario_dgv.Index,dgv_semanas_laborales.SelectedRows(0).Index).Value)
            If defCale IsNot Nothing Then
                ControladorCalendario.Eliminar(defCale)
                CargarCombos
            End If           
        Else
            Dim exce As Excepcion_Calendario
            exce = ControladorCalendario.ObtenerExcepcionPorID(dgvExcepciones.Item(id_excepcion_dgv.Index,dgvExcepciones.SelectedRows(0).Index).Value)
            If exce IsNot Nothing Then
                ControladorCalendario.Eliminar(exce)
                CargarCombos
            End If      
        End If
    End Sub


    Private Sub calendarioMeses_DateSelected(sender As Object, e As DateRangeEventArgs) Handles calendarioMeses.DateSelected
        Dim horas As List(Of Tuple(Of TimeSpan,TimeSpan))
        horas = ControladorCalendario.ObtenerHorasLaboralesDia(DirectCast(cmbCalendarios.SelectedItem, Calendario_Laboral),e.Start)

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Close
    End Sub
End Class