Public Class frmAgregarSubproyectos

    Dim id_subproyecto As Integer
    Dim id_proyecto As Integer
    Dim ready As Boolean = False
    Dim cboxActividades As New DataGridViewComboBoxCell
    Dim cboxControles As New DataGridViewComboBoxCell
    Dim last As Integer
    Dim tipo_subproyecto As New entTipo_Subproyecto
    Dim nuevo_subproyecto As New entSubproyecto
    Dim dgvArr(1) As DataGridView



    Private Sub saveDgv(ByVal pos As Integer, ByVal dgv As DataGridView)
        println("saveDgv", CStr(pos))
        If pos > dgvArr.Length - 1 Then
            ReDim Preserve dgvArr(pos + 1)
        End If
        dgvArr(pos) = dgv
    End Sub



    Public Sub New(ByVal id_proyecto As Integer, ByVal id_subproyecto As Integer)

        InitializeComponent()
        Me.id_proyecto = id_proyecto
        Me.id_subproyecto = id_subproyecto
    End Sub

    Private Sub frmAgregarSubproyecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.cargarBoxTipo()
        cmb_tipo_subproyecto.DataSource = tipo_subproyecto.GetCMB_TipoSubproyecto()
        cmb_tipo_subproyecto.ValueMember = "id_tipo_subproyecto"
        cmb_tipo_subproyecto.DisplayMember = "nombre_tipo_subproyecto"

        cmb_tipo_hijos.DataSource = tipo_subproyecto.GetCMB_TipoSubproyecto()
        cmb_tipo_hijos.ValueMember = "id_tipo_subproyecto"
        cmb_tipo_hijos.DisplayMember = "nombre_tipo_subproyecto"

        Dim tiposActividades As DataTable = oActividad.GetTipoActividad()
        CBActividades.DataSource = tiposActividades
        CBActividades.ValueMember = "id_tipo_actividad"
        CBActividades.DisplayMember = "descripcion"

        Me.addFila()
        Me.actualizarControles()
    End Sub
    Private Sub addFila()

        Dim cboxTipo As New DataGridViewComboBoxCell
        Dim cboxTipoH As New DataGridViewComboBoxCell

        cboxTipo.DataSource = tipo_subproyecto.GetCMB_TipoSubproyecto()
        cboxTipo.ValueMember = "id_tipo_subproyecto"
        cboxTipo.DisplayMember = "nombre_tipo_subproyecto"
        cboxTipo.AutoComplete = True

        cboxTipoH.DataSource = tipo_subproyecto.GetCMB_TipoSubproyecto()
        cboxTipoH.ValueMember = "id_tipo_subproyecto"
        cboxTipoH.DisplayMember = "nombre_tipo_subproyecto"
        cboxTipoH.AutoComplete = True

        last = Me.dgvSubproyectos.Rows.Add()
        With Me.dgvSubproyectos.Rows(last)
            .Cells("id_hijo").Value = ""
            .Cells("nombre").Value = ""
            .Cells("tipo") = cboxTipo
            Me.ready = True
            .Cells("cant_hijos").Value = "0"
            .Cells("tipo_hijos") = cboxTipoH
            .Cells("tipo_hijos").Value = 4
            .Cells("personalizar_hijos").Value = "perzonaliza"
        End With
        Me.fila.Text = last.ToString()

        Me.ready = True
        Me.dgvSubproyectos.Rows(last).Cells("tipo").Value = 4
        'TODO que hago con id_hijo?

    End Sub
    Private Sub cargarBoxTipo()

        Dim tipo_subproyecto As New entTipo_Subproyecto



    End Sub
    Private Sub actualizarActividades(index As Integer)
        println("actualizarActividades", "")
        Dim dgv As New DataGridView
        If index < 0 Then
            index = 0
        End If
        dgvActividades = dgvArr(index)



        'cBoxActividades = CType(Me.dgvSubproyectos.Rows(index).Cells("actividades"), DataGridViewComboBoxCell)
        'Me.dgvActividades.Rows.Clear()
        'If cBoxActividades.Items.Count > 0 Then
        '    Dim i As Integer
        '    For i = 0 To cBoxActividades.Items.Count - 1
        '        Dim rowView As DataRowView = CType(cBoxActividades.Items(i), DataRowView)
        '        index = Me.dgvActividades.Rows.Add()

        '        With Me.dgvActividades.Rows(index)
        '            .Cells("id_tipo_actividad").Value = rowView.Item("id_tipo_actividad")
        '            .Cells("nombre_actividad").Value = rowView.Item("descripcion")
        '            .Cells("Peso").Value = rowView.Item("criticidad")
        '        End With
        '    Next
        'End If

    End Sub
    Private Sub actualizarControles()
        Dim odt As DataTable
        Dim tiposActividades As DataTable = oActividad.GetTipoActividad()
        Dim index As Integer

        odt = oControl.GetCmb()
        odt.Rows.Add(0, "", 0)

        CType(Me.dgvControles.Columns("control"), DataGridViewComboBoxColumn).DataSource = odt
        CType(Me.dgvControles.Columns("control"), DataGridViewComboBoxColumn).DisplayMember = "nombre_control"
        CType(Me.dgvControles.Columns("control"), DataGridViewComboBoxColumn).ValueMember = "id_control"

        For Each row As DataRow In tiposActividades.Rows
            index = dgvControles.Rows.Add()
            With Me.dgvControles.Rows(index)
                .Cells("id_actividad").Value = row.Item("id_tipo_actividad")
                .Cells("actividad").Value = row.Item("descripcion")
            End With
        Next
    End Sub
    Private Sub dgvSubproyectos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubproyectos.CellContentClick
        actualizarActividades(e.RowIndex)
        Me.fila.Text = e.RowIndex.ToString()
    End Sub
    Private Sub dgvSubproyectos_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubproyectos.CellValueChanged
        If ready Then
            Me.fila.Text = e.RowIndex.ToString()
            'Si modifico el tipo guardo en actividades de esa row las activiades correspondientes
            If Me.dgvSubproyectos.CurrentRow.Cells("tipo").ColumnIndex = e.ColumnIndex Then
                Dim tablaActividades As New DataTable

                tablaActividades = tipo_subproyecto.GetActividadesTipoProyecto(CInt(Me.dgvSubproyectos.Rows(e.RowIndex).Cells("tipo").Value))
                tablaActividades.Columns.Add("fecha_fin_actividad", Type.GetType("System.String"))
                println("tipo actividad es", CStr(Me.dgvSubproyectos.Rows(e.RowIndex).Cells("tipo").Value))
                println("t columnName 0", tablaActividades.Columns(0).ColumnName)

                Dim dgv As New DataGridView
                dgv.DataSource = tablaActividades
                saveDgv(CInt(Me.fila.Text), dgv)
                actualizarActividades(CInt(Me.fila.Text))

                'cBoxActividades.DataSource = tablaActividades
                'cBoxActividades.ValueMember = "id_tipo_actividad"
                'cBoxActividades.DisplayMember = "descripcion"

                'Me.dgvSubproyectos.Rows(e.RowIndex).Cells("actividades") = cBoxActividades

                'actualizarActividades(e.RowIndex)

            End If
        End If

    End Sub
    Private Sub dgvSubproyectos_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvSubproyectos.CellMouseDown
        'TODO hacer que se llame a actualizar solo cuando sea una fila distinta
        actualizarActividades(e.RowIndex)
        Me.fila.Text = e.RowIndex.ToString()
    End Sub
    'Private Sub dgvSubproyectos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvSubproyectos.KeyDown
    '    If e.KeyCode = Keys.Enter And dgvSubproyectos.CurrentCell.RowIndex = last Then
    '        addFila()
    '    End If
    'End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click

        Dim _Control_Subproyecto As New Control_Subproyecto

        For Each row As DataGridViewRow In dgvSubproyectos.Rows
            With nuevo_subproyecto
                .Cargar()
                .Insertar()
                .nombre = row.Cells("nombre").ToString()
                .id_tipo_subproyecto = CInt(row.Cells("tipo").Value.ToString())
                .fecha_inicio_estimada = Date.Now
                .fecha_fin_estimada = Date.Now
                .orden = 99999
                .ot = 0
                'TODO.genera_ot = chk_genera_ot.Checked
                .asignacion_automatica = False

                If id_subproyecto = 0 Then
                    .id_subproyecto_padre = 1
                    .id_proyecto = Me.id_proyecto
                Else
                    .id_subproyecto_padre = Me.id_subproyecto
                    .id_proyecto = Me.id_proyecto
                End If
                .Guardar()

                If .genera_ot Then
                    .AgregarOT(.id_suproyecto)
                Else
                    .ObtenerOTPadre(.id_suproyecto)
                End If
                .Guardar()
                .Modificar(.id_suproyecto)
            End With



            Dim id_Actividad_actual As Integer
            Dim actividades As DataGridViewComboBoxCell
            actividades = CType(row.Cells("actividades"), DataGridViewComboBoxCell)
            For i = 0 To actividades.Items.Count - 1
                Dim act As DataRowView = CType(cboxActividades.Items(i), DataRowView)
                With oActividad
                    .Cargar()
                    .Insertar()
                    .id_tipo_actividad = CInt(act.Item("id_tipo_actividad"))
                    .nombre_actividad = CStr(act.Item("descripcion"))
                    .costo_standart = CDec(act.Item("Peso"))
                    .tiempo_standart = 0
                    .Guardar()
                    id_Actividad_actual = .id_actividad

                    With oActividad_proyecto
                        .Cargar()
                        .Insertar()
                        .avance = 0
                        .cantidad_hora = 0
                        .complejidad = 0
                        .orden = actividades.Items.IndexOf(act) + 1
                        .fecha_inicio = nuevo_subproyecto.fecha_fin_estimada

                        If act.Item("fecha_fin_actividad") Is Nothing Then
                            .forzada_fecha_fin = False
                            .fecha_fin_previsto = nuevo_subproyecto.fecha_fin_estimada
                        ElseIf act.Item("fecha_fin_actividad") IsNot Nothing And act.Item("fecha_fin_actividad").ToString() = "" Then
                            .forzada_fecha_fin = False
                            .fecha_fin_previsto = nuevo_subproyecto.fecha_fin_estimada
                        Else
                            .forzada_fecha_fin = True
                            .fecha_fin_previsto = CDate(act.Item("fecha_fin_actividad"))
                        End If

                        .id_cliente = 0
                        .id_proyecto = Me.id_proyecto
                        .id_subproyecto = nuevo_subproyecto.id_suproyecto
                        .id_actividad = id_Actividad_actual
                        .id_control = 0
                        .id_controlador_1 = 0
                        .id_controlador_2 = 0
                        .porcentaje_avance = 0
                        .asignada = False
                        .Guardar()
                    End With

                End With
            Next


            For Each rowC As DataGridViewRow In Me.dgvControles.Rows
                If rowC.Cells("control").Value IsNot Nothing Then
                    With _Control_Subproyecto
                        .Cargar()
                        .Insertar()
                        .id_control = CInt(rowC.Cells("control").Value)
                        .id_subproyecto = nuevo_subproyecto.id_suproyecto
                        .id_tipo_actividad = CInt(rowC.Cells("id_actividad").Value)
                        If .id_control <> 0 Then
                            .Guardar()
                        End If
                    End With
                End If
            Next

        Next
        Me.Close()
    End Sub

    Private Sub btn_agregar_actividad_subproyecto_Click(sender As Object, e As EventArgs) Handles btn_agregarActividad.Click
        If CBActividades.SelectedIndex <> 0 And Not contieneActividad() Then

            Dim Index As Integer = dgvArr(CInt(Me.fila.Text)).Rows.Add()
            Dim selected As DataRowView = CType(CBActividades.SelectedItem, DataRowView)


            With dgvArr(CInt(Me.fila.Text)).Rows(Index)
                .Cells("id_tipo_actividad").Value = selected.Item("id_tipo_actividad")
                .Cells("nombre_actividad").Value = selected.Item("descripcion")
                .Cells("Peso").Value = selected.Item("criticidad")
            End With
            actualizarActividades(CInt(Me.fila.Text))


            'Dim Index As Integer = dgvActividades.Rows.Add()
            'Dim selected As DataRowView = CType(CBActividades.SelectedItem, DataRowView)


            'With Me.dgvActividades.Rows(Index)
            '    .Cells("id_tipo_actividad").Value = selected.Item("id_tipo_actividad")
            '    .Cells("nombre_actividad").Value = selected.Item("descripcion")
            '    .Cells("Peso").Value = selected.Item("criticidad")
            'End With
            ''datagridview to DataGridViewComboBoxCell
            'Dim actividades As New DataGridViewComboBoxCell
            'Dim dt As New DataTable
            'dt = dgvToDt(dgvActividades)

            'actividades.DataSource = dt
            'actividades.ValueMember = "id_tipo_actividad"
            'actividades.DisplayMember = "descripcion"



            'Me.txt.AppendText("Largo dt = " & dt.Rows.Count.ToString() & Environment.NewLine)
            ''Me.dgvSubproyectos.Rows(CType(Me.fila.Text, Integer)).Cells("actividades") = actividades



        End If



    End Sub

    Private Function dgvToDt(dgv As DataGridView) As DataTable
        Dim dt As New DataTable
        For Each col As DataGridViewColumn In dgv.Columns
            dt.Columns.Add(col.HeaderText)
            Me.txt.AppendText("dt es " & dt.ToString() & Environment.NewLine & "##################################" & Environment.NewLine)
        Next

        For Each row As DataGridViewRow In dgv.Rows

            Dim dtRow As DataRow = dt.NewRow
            For Each cell As DataGridViewCell In row.Cells
                Try
                    Me.txt.AppendText(cell.ToString() & Environment.NewLine)
                    Me.txt.AppendText("dato = " & cell.Value.ToString() & Environment.NewLine)
                    dtRow(cell.ColumnIndex) = cell.Value
                Catch ex As Exception

                End Try
                

            Next
        Next
        Return dt
    End Function
    Private Function contieneActividad() As Boolean
        For Each row As DataGridViewRow In dgvArr(CInt(Me.fila.Text)).Rows()
            If CType(row.Cells("id_tipo_actividad").Value, Integer) = CType(CBActividades.SelectedValue, Integer) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub btn_agregarSubproyecto_Click(sender As Object, e As EventArgs) Handles btn_agregarSubproyecto.Click
        addFila()
    End Sub

    Private Sub cmb_tipo_subproyecto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tipo_subproyecto.SelectedIndexChanged
        For Each row As DataGridViewRow In dgvSubproyectos.Rows
            CType(row.Cells("tipo"), DataGridViewComboBoxCell).Value = cmb_tipo_subproyecto.SelectedIndex + 1
        Next
    End Sub

    Private Sub cmb_tipo_hijos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tipo_hijos.SelectedIndexChanged
        For Each row As DataGridViewRow In dgvSubproyectos.Rows
            CType(row.Cells("tipo_hijos"), DataGridViewComboBoxCell).Value = cmb_tipo_hijos.SelectedIndex + 1
        Next
    End Sub

    Private Sub txt_cantidadH_ValueChanged(sender As Object, e As EventArgs) Handles txt_cantidadH.ValueChanged
        For Each row As DataGridViewRow In dgvSubproyectos.Rows
            row.Cells("cant_hijos").Value = txt_cantidadH.Value
        Next
    End Sub

    Private Sub txt_nombre_TextChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_nombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            For Each row As DataGridViewRow In dgvSubproyectos.Rows
                row.Cells("nombre").Value = txt_nombre.Text
            Next
        End If

    End Sub

    Public Sub PasteData(ByRef dgv As DataGridView)
        Dim tArr() As String
        Dim arT() As String
        Dim i As Integer
        tArr = Clipboard.GetText().Split(CChar(Environment.NewLine))
        For i = 0 To tArr.Length - 1
            arT = tArr(i).Split(CChar(vbTab))
            Me.dgvSubproyectos.Rows(i).Cells("nombre").Value = arT(0).TrimStart
        Next

    End Sub

    Private Sub btn_pegar_Click(sender As Object, e As EventArgs) Handles btn_pegar.Click
        PasteData(dgvSubproyectos)
    End Sub

    Private Sub println(ByVal str As String, ByVal str2 As String)
        Me.txt.AppendText(str & ": " & str2 & Environment.NewLine)
    End Sub
End Class
'TODO modificar dgv subproyectos al modificar peso de actividades
'TODO si cambio tipo de subproyect a todos, mostrar actividades y actualizar en todos!