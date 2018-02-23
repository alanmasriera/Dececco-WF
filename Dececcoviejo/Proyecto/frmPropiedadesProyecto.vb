Imports System.Globalization

Public Class frmPropiedadesProyecto

    Dim proyecto As Proyecto
    Dim oSubproyecto As New entSubproyecto
    Dim id_proyecto As Integer
    Dim id_subproyecto As Integer
    Dim ultima_fila_unidad As DataGridViewRow

    Public Sub New(ByVal id_proyecto As Integer, ByVal id_subproyecto As Integer)
        InitializeComponent()

        Me.id_subproyecto = id_subproyecto

        If id_subproyecto <> 0 Then
            oSubproyecto.Modificar(id_subproyecto)
            Me.id_proyecto = oSubproyecto.id_proyecto
        Else
            Me.id_proyecto = id_proyecto
        End If

    End Sub


    Private Sub frmPropiedadesProyecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO PERMISOS!

        proyecto = oProyecto.GetProyecto(id_proyecto)

        lbl_nombre_proyecto.Text = proyecto.nombre_proyecto

        Dim dt_cliente As DataTable
        dt_cliente = proyecto.GetCliente(id_proyecto)
        If dt_cliente.Rows.Count > 0 Then
            lbl_cliente.Text = dt_cliente.Rows(0).Item("nombre_cliente").ToString()
        Else
            lbl_cliente.Text = "-"
        End If

        lbl_descripcion.Text = proyecto.descripcion

        Dim dt_responsables As DataTable
        dt_responsables = proyecto.GetResponsables(id_proyecto)
        Try
            lbl_proyect_manager.Text = dt_responsables.Rows(0).Item("PM").ToString()
            lbl_piloto_proyecto.Text = dt_responsables.Rows(0).Item("piloto").ToString()
        Catch ex As Exception
            MsgBox("El proyecto no tiene asignado un Proyect Manager y/o Piloto de proyecto")
        End Try

        Dim dt_fechas As DataTable
        dt_fechas = proyecto.GetFechas(id_proyecto)
        lbl_fecha_inicio.Text = CType(dt_fechas.Rows(0).Item("fecha_inicio"), Date).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)
        lbl_fecha_prevista_fin.Text = CType(dt_fechas.Rows(0).Item("fecha_fin_prevista"), Date).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)
        lbl_fecha_fin_real.Text = CType(dt_fechas.Rows(0).Item("fecha_fin_real"), Date).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)

        Dim dt_unidades As DataTable
        Dim dr_index As Integer

        If Me.id_subproyecto <> 0 Then
            dt_unidades = oSubproyecto.ObtenerHijos(Me.id_subproyecto)
        Else
            dt_unidades = proyecto.GetUnidades(id_proyecto)
        End If

        dgv_unidades_proyecto.Rows.Clear()

        For Each row As DataRow In dt_unidades.Rows
            dr_index = dgv_unidades_proyecto.Rows.Add()
            With dgv_unidades_proyecto.Rows(dr_index)
                .Cells("nombre_subproyecto").Value = row.Item("nombre")
                .Cells("id_subproyecto_dgv").Value = row.Item("id_subproyecto")
            End With
        Next
        

        chk_mostrar_todas_horas.Checked = True

        cargarAvances()

    End Sub

    Private Sub btn_Aceptar_Click(sender As Object, e As EventArgs) Handles btn_Aceptar.Click
        Me.Close()
    End Sub


    Private Sub cargarAvances()
        'dgv_avance_proyecto.DataSource = oProyecto.ObtenerAvanceConcepto(id_proyecto)
        Dim encontrado As Boolean = False
        Dim usuario As DataTable

        Dim dt_unidades As DataTable

        If Me.id_subproyecto <> 0 Then
            dt_unidades = oSubproyecto.ObtenerHijos(Me.id_subproyecto)
        Else
            dt_unidades = proyecto.GetUnidades(id_proyecto)
        End If

        'For Each row As DataRow In oProyecto.GetUnidades(id_proyecto).Rows
        For Each row As DataRow In dt_unidades.Rows
            dgv_avance_proyecto.Rows.Add(row.Item("id_subproyecto"), row.Item("nombre"))
        Next

        For Each row As DataGridViewRow In dgv_avance_proyecto.Rows

            'CONCEPTO
            If oSubproyecto.ObtenerAvanceConcepto(CInt(row.Cells("idSubproyecto").Value)).Rows.Count > 0 Then
                For Each row_concepto As DataRow In oSubproyecto.ObtenerAvanceConcepto(CInt(row.Cells("idSubproyecto").Value)).Rows
                    If row.Cells("Unidad").Value.ToString() = row_concepto.Item("nombre_proyecto").ToString() Then
                        'row.Cells("Concepto").Value = CBool(row_concepto.Item("Concepto"))
                        If CBool(row_concepto.Item("Concepto")) Then
                            row.Cells("Concepto").Style.BackColor = System.Drawing.Color.Green
                            row.Cells("Concepto").Value = "Completado"
                        Else
                            row.Cells("Concepto").Style.BackColor = System.Drawing.Color.Yellow
                            row.Cells("Concepto").Value = "En proceso de Checklist"
                        End If
                        row.Cells("resp_concepto").Value = row_concepto.Item("Responsable")
                        encontrado = True
                        Exit For
                    End If
                Next
            End If
            If encontrado = False Then
                row.Cells("Concepto").Value = "Sin completar"
                'row.Cells("Concepto").Style.BackColor = System.Drawing.Color.Yellow
                usuario = oProyecto.ObtenerUsuarioLogueado(CInt(row.Cells("idSubProyecto").Value), "concep")
                If usuario.Rows.Count = 0 Then
                    row.Cells("Concepto").Value = "No trabajado el dia actual"
                    row.Cells("resp_concepto").Value = "-"
                Else
                    If oProyecto.estaLogueado(CInt(row.Cells("idSubProyecto").Value), "concep", CInt(usuario.Rows(0).Item("id_usuario").ToString())) Then
                        row.Cells("Concepto").Value = "Trabajando ahora"
                        row.Cells("Concepto").Style.BackColor = System.Drawing.Color.LightSkyBlue
                    Else
                        row.Cells("Concepto").Value = "Trabajado Hoy"
                    End If
                    row.Cells("resp_concepto").Value = usuario.Rows(0).Item("nombre").ToString()
                End If
            End If
            encontrado = False

            'PREPARACION
            If oProyecto.ObtenerAvancePreparacion(CInt(row.Cells("idSubproyecto").Value)).Rows.Count > 0 Then
                For Each row_preparacion As DataRow In oProyecto.ObtenerAvancePreparacion(CInt(row.Cells("idSubproyecto").Value)).Rows
                    If row.Cells("Unidad").Value.ToString() = row_preparacion.Item("nombre_proyecto").ToString() Then
                        'row.Cells("Preparacion").Value = CBool(row_preparacion.Item("Preparacion"))
                        If CBool(row_preparacion.Item("Preparacion")) Then
                            row.Cells("Preparacion").Style.BackColor = System.Drawing.Color.Green
                            row.Cells("Preparacion").Value = "Completado"
                        Else
                            row.Cells("Preparacion").Style.BackColor = System.Drawing.Color.Yellow
                            row.Cells("Preparacion").Value = "En proceso de Checklist"
                        End If
                        row.Cells("resp_preparacion").Value = row_preparacion.Item("Responsable")
                        encontrado = True
                        Exit For
                    End If
                Next
            End If
            If encontrado = False Then
                row.Cells("Preparacion").Value = "Sin completar"
                'row.Cells("Concepto").Style.BackColor = System.Drawing.Color.Yellow
                usuario = oProyecto.ObtenerUsuarioLogueado(CInt(row.Cells("idSubProyecto").Value), "prep")
                If usuario.Rows.Count = 0 Then
                    row.Cells("Preparacion").Value = "No trabajado el dia actual"
                    row.Cells("resp_preparacion").Value = "-"
                Else
                    If oProyecto.estaLogueado(CInt(row.Cells("idSubProyecto").Value), "prep", CInt(usuario.Rows(0).Item("id_usuario").ToString())) Then
                        row.Cells("Preparacion").Value = "Trabajando ahora"
                        row.Cells("Preparacion").Style.BackColor = System.Drawing.Color.LightSkyBlue
                    Else
                        row.Cells("Preparacion").Value = "Trabajado Hoy"
                    End If
                    row.Cells("resp_preparacion").Value = usuario.Rows(0).Item("nombre").ToString()
                End If
            End If
            encontrado = False

            'DETALLADO
            If oProyecto.ObtenerAvanceDetallado(CInt(row.Cells("idSubproyecto").Value)).Rows.Count > 0 Then
                For Each row_detallado As DataRow In oProyecto.ObtenerAvanceDetallado(CInt(row.Cells("idSubproyecto").Value)).Rows
                    If row.Cells("Unidad").Value.ToString() = row_detallado.Item("nombre_proyecto").ToString() Then
                        'row.Cells("Detallado").Value = CBool(row_detallado.Item("Detallado"))
                        If CBool(row_detallado.Item("Detallado")) Then
                            row.Cells("Detallado").Style.BackColor = System.Drawing.Color.Green
                            row.Cells("Detallado").Value = "Completado"
                        Else
                            row.Cells("Detallado").Style.BackColor = System.Drawing.Color.Yellow
                            row.Cells("Detallado").Value = "En proceso de Checklist"
                        End If
                        row.Cells("resp_detallado").Value = row_detallado.Item("Responsable")
                        encontrado = True
                        Exit For
                    End If
                Next
            End If
            If encontrado = False Then
                row.Cells("Detallado").Value = "Sin completar"
                'row.Cells("Concepto").Style.BackColor = System.Drawing.Color.Yellow
                usuario = oProyecto.ObtenerUsuarioLogueado(CInt(row.Cells("idSubProyecto").Value), "detal")
                If usuario.Rows.Count = 0 Then
                    row.Cells("Detallado").Value = "No trabajado el dia actual"
                    row.Cells("resp_detallado").Value = "-"
                Else
                    If oProyecto.estaLogueado(CInt(row.Cells("idSubProyecto").Value), "detal", CInt(usuario.Rows(0).Item("id_usuario").ToString())) Then
                        row.Cells("Detallado").Value = "Trabajando ahora"
                        row.Cells("Detallado").Style.BackColor = System.Drawing.Color.LightSkyBlue
                    Else
                        row.Cells("Detallado").Value = "Trabajado Hoy"
                    End If
                    row.Cells("resp_detallado").Value = usuario.Rows(0).Item("nombre").ToString()
                End If
            End If
            encontrado = False


        Next

    End Sub


    Private Sub dgv_unidades_proyecto_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_unidades_proyecto.CellDoubleClick

        chk_mostrar_todas_horas.Checked = False

        ActualizarHorasDeUnidad()

    End Sub

    Private Sub chk_mostrar_todas_horas_CheckedChanged(sender As Object, e As EventArgs) Handles chk_mostrar_todas_horas.CheckedChanged
        If chk_mostrar_todas_horas.Checked = True Then

            If Not IsNothing(ultima_fila_unidad) Then
                For Each cell As DataGridViewCell In ultima_fila_unidad.Cells()
                    cell.Style.BackColor = Color.White
                Next
            End If
           

            Dim dt_horas As DataTable

            If id_subproyecto = 0 Then
                dt_horas = proyecto.GetHorasTrabajadas(id_proyecto)
            Else
                dt_horas = proyecto.GetHorasTrabajadasSubproyecto(id_subproyecto)
            End If

            dgv_horas_proyecto.DataSource = dt_horas
            dgv_horas_proyecto.Columns(2).Visible = False

            Dim horas As Double = 0
            For Each row As DataGridViewRow In dgv_horas_proyecto.Rows
                horas = horas + CDbl(row.Cells(1).Value.ToString())
            Next

            Me.txtHorasConsumidas.Text = horas.ToString()

        Else
            ActualizarHorasDeUnidad()
        End If
    End Sub

    Private Sub ActualizarHorasDeUnidad()
        If dgv_unidades_proyecto.SelectedRows.Count > 0 Then

            If Not IsNothing(ultima_fila_unidad) Then
                For Each cell As DataGridViewCell In ultima_fila_unidad.Cells()
                    cell.Style.BackColor = Color.White
                Next
            End If

            ultima_fila_unidad = dgv_unidades_proyecto.SelectedRows(0)
            Dim dt_horas As DataTable
            dt_horas = proyecto.GetHorasTrabajadasSubproyecto(CInt(ultima_fila_unidad.Cells("id_subproyecto_dgv").Value))
            dgv_horas_proyecto.DataSource = dt_horas

            Dim horas As Double = 0
            For Each row As DataGridViewRow In dgv_horas_proyecto.Rows
                horas = horas + CDbl(row.Cells(1).Value.ToString())
            Next

            Me.txtHorasConsumidas.Text = horas.ToString()

            For Each cell As DataGridViewCell In ultima_fila_unidad.Cells()
                cell.Style.BackColor = Color.GreenYellow
            Next
        End If
    End Sub
End Class