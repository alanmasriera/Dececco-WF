Imports System.Text
Imports System.Data.SqlClient

Public Class frmLoginInicio
    Dim banderaProyectoLoguin As String '''''
    Dim copia1 As Integer = 0
    Dim banderaclick As Integer = 0
    Dim id_movimiento_voz_pdf As Integer
    Dim id_proyecto_anotacion As Integer = 0
    Dim id_control_pdf As Integer
    Dim id_cuerpo_movimiento_hora As Integer = 0
    Dim hora_logueo_dia As Nullable(Of Date)
    Dim oSubproyecto As New entSubproyecto
    Dim selected_row_tarea As DataGridViewRow
    Dim id_proyecto, id_subproyecto, id_Actividad, id_actividad_proyecto As Integer

    Structure stArbol
        Dim tipo As String
        Dim id_actividad As Integer
        Dim icono As Integer
        Dim icono_seleccionado As Integer
        Dim id_proyecto As Integer
        Dim id_factura As Integer
        Dim id_cliente As Integer
        Dim id_subproyecto As Integer
        Dim id_actividad_proyecto As Integer
    End Structure

    Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmLoginInicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.RefrescarControl()


    End Sub

    'Grilla de los logueos por proyecto y actividad DEL usuario
    

    'Actualiza la grilla de controles (checklists)
    Sub RefrescarControl()
        Dim odtPendiente As New DataTable
        Dim odtEspera As New DataTable
        Dim odtCompletado As New DataTable
        Dim odt_index, id_movimiento_grilla, id_movimiento_tabla As Integer
        Dim index_espera, index_pendiente, index_completado As Integer
        Dim id_movimiento_voz_espera, id_movimiento_voz_completado, id_movimiento_voz_pendiente As Integer
        Dim cantidad As Integer
        Dim encontrado As Boolean = False

        'Pendiente
        odtPendiente = oVoz.GetAllInicio_4_PM_ConPendientes(vgCodigoUsuario)

        Me.tab_controles.Text = "Controles (" & odtPendiente.Rows.Count & ")"

        If Me.dgvControl.SelectedRows().Count > 0 Then
            id_movimiento_voz_pendiente = CInt(Me.dgvControl.SelectedRows(0).Cells("id_movimiento_voz_dgv").Value)
        End If

        cantidad = Me.dgvControl.Rows.Count

        For Each row_grid As DataGridViewRow In dgvControl.Rows
            id_movimiento_grilla = CInt(row_grid.Cells("id_movimiento_voz_dgv").Value)
            encontrado = False
            For Each row As DataRow In odtPendiente.Rows
                id_movimiento_tabla = CInt(row.Item("id_movimiento_voz"))
                If id_movimiento_tabla = id_movimiento_grilla Then
                    encontrado = True
                End If
            Next
            If encontrado = False Then
                'Me.dgvControl.Rows(row_grid.Index).Cells.Clear()
                Me.dgvControl.Rows.Remove(row_grid)
            End If
        Next

        'Me.dgvControl.Rows.Clear()
        For Each row As DataRow In odtPendiente.Rows
            encontrado = False
            id_movimiento_tabla = CInt(row.Item("id_movimiento_voz"))
            For Each row_grid As DataGridViewRow In dgvControl.Rows
                id_movimiento_grilla = CInt(row_grid.Cells("id_movimiento_voz_dgv").Value)

                If id_movimiento_grilla = id_movimiento_tabla Then
                    row_grid.Cells("id_actividad_proyecto_dgv").Value = row.Item("id_actividad_proyecto")
                    row_grid.Cells("id_actividad_dgv").Value = row.Item("id_actividad")
                    row_grid.Cells("id_proyecto_dgv").Value = row.Item("id_proyecto")
                    row_grid.Cells("id_control_dgv").Value = row.Item("id_control")
                    row_grid.Cells("id_movimiento_voz_dgv").Value = row.Item("id_movimiento_voz")
                    row_grid.Cells("control_prod_dgv").Value = row.Item("control_prod")
                    row_grid.Cells("control_1_dgv").Value = row.Item("control_1")
                    row_grid.Cells("pedido_segundo_control_dgv").Value = row.Item("pedido_segundo_control")
                    row_grid.Cells("control_prod_2_dgv").Value = row.Item("control_prod_2")
                    row_grid.Cells("control_2_dgv").Value = row.Item("control_2")
                    row_grid.Cells("nombre_control_dgv").Value = row.Item("nombre_control")
                    row_grid.Cells("nombre_subproyecto_dgv").Value = row.Item("nombre_subproyecto")
                    row_grid.Cells("nombre_proyecto_dgv").Value = row.Item("nombre_proyecto")
                    row_grid.Cells("nombre_actividad_dgv").Value = row.Item("nombre_actividad")
                    row_grid.Cells("id_usuario_1_dgv").Value = row.Item("id_usuario_1")
                    row_grid.Cells("id_usuario_2_dgv").Value = row.Item("id_usuario_2")
                    row_grid.Cells("id_usuario_3_dgv").Value = row.Item("id_usuario_3")
                    row_grid.Cells("id_usuario_4_dgv").Value = row.Item("id_usuario_4")
                    row_grid.Cells("id_usuario_5_dgv").Value = row.Item("id_usuario_5")
                    row_grid.Cells("id_usuario_6_dgv").Value = row.Item("id_usuario_6")
                    row_grid.Cells("fecha_asignada_dgv").Value = row.Item("fecha")
                    row_grid.Cells("fecha_inicio_dgv").Value = row.Item("fecha_inicio")
                    row_grid.Cells("fecha_completado_dgv").Value = row.Item("fecha_completado")
                    row_grid.Cells("cadista_1").Value = row.Item("Cadista 1")
                    row_grid.Cells("controlador_1").Value = row.Item("Controlador 1")
                    row_grid.Cells("correccion_1").Value = row.Item("Corrección 1")
                    row_grid.Cells("cadista_2").Value = row.Item("Cadista 2")
                    row_grid.Cells("controlador_2").Value = row.Item("Controlador 2")
                    row_grid.Cells("correccion_2").Value = row.Item("Corrección 2")
                    row_grid.Cells("corr_1_pendiente").Value = row.Item("control_corr_1")
                    row_grid.Cells("corr_2_pendiente").Value = row.Item("control_corr_2")
                    If id_movimiento_voz_pendiente = CInt(row_grid.Cells("id_movimiento_voz_dgv").Value) Then
                        index_pendiente = row_grid.Index
                    End If

                    If CBool(row.Item("pedido_segundo_control")) Then
                        If CBool(row.Item("control_prod_2")) = False And CBool(row.Item("control_2")) = False Then
                            'FormatCell(Me.dgvControl.Rows(odt_index), Color.Yellow)
                        ElseIf CBool(row.Item("control_prod_2")) = True And CBool(row.Item("control_2")) = False Then
                            FormatCell(row_grid, Color.LightBlue)
                        ElseIf CBool(row.Item("control_prod_2")) = True And CBool(row.Item("control_2")) = True Then
                            FormatCell(row_grid, Color.RosyBrown)
                        End If
                    Else
                        'Primer control
                        If CBool(row.Item("control_prod")) = False And CBool(row.Item("control_1")) = False Then
                            'FormatCell(Me.dgvControl.Rows(odt_index), Color.Yellow)
                        ElseIf CBool(row.Item("control_prod")) = True And CBool(row.Item("control_1")) = False Then

                            If CInt(row.Item("id_proveedor")) <> 0 Then
                                FormatCell(row_grid, Color.Gray)
                            Else
                                FormatCell(row_grid, Color.LightBlue)
                            End If

                        ElseIf CBool(row.Item("control_prod")) = True And CBool(row.Item("control_1")) = True Then
                            FormatCell(row_grid, Color.RosyBrown)
                        End If
                    End If

                    encontrado = True

                    Exit For
                End If
            Next

            If encontrado = False Then
                odt_index = Me.dgvControl.Rows.Add()
                Me.dgvControl.Rows(odt_index).Cells("id_actividad_proyecto_dgv").Value = row.Item("id_actividad_proyecto")
                Me.dgvControl.Rows(odt_index).Cells("id_actividad_dgv").Value = row.Item("id_actividad")
                Me.dgvControl.Rows(odt_index).Cells("id_proyecto_dgv").Value = row.Item("id_proyecto")
                Me.dgvControl.Rows(odt_index).Cells("id_control_dgv").Value = row.Item("id_control")
                Me.dgvControl.Rows(odt_index).Cells("id_movimiento_voz_dgv").Value = row.Item("id_movimiento_voz")
                Me.dgvControl.Rows(odt_index).Cells("control_prod_dgv").Value = row.Item("control_prod")
                Me.dgvControl.Rows(odt_index).Cells("control_1_dgv").Value = row.Item("control_1")
                Me.dgvControl.Rows(odt_index).Cells("pedido_segundo_control_dgv").Value = row.Item("pedido_segundo_control")
                Me.dgvControl.Rows(odt_index).Cells("control_prod_2_dgv").Value = row.Item("control_prod_2")
                Me.dgvControl.Rows(odt_index).Cells("control_2_dgv").Value = row.Item("control_2")
                Me.dgvControl.Rows(odt_index).Cells("nombre_control_dgv").Value = row.Item("nombre_control")
                Me.dgvControl.Rows(odt_index).Cells("nombre_subproyecto_dgv").Value = row.Item("nombre_subproyecto")
                Me.dgvControl.Rows(odt_index).Cells("nombre_proyecto_dgv").Value = row.Item("nombre_proyecto")
                Me.dgvControl.Rows(odt_index).Cells("nombre_actividad_dgv").Value = row.Item("nombre_actividad")
                Me.dgvControl.Rows(odt_index).Cells("id_usuario_1_dgv").Value = row.Item("id_usuario_1")
                Me.dgvControl.Rows(odt_index).Cells("id_usuario_2_dgv").Value = row.Item("id_usuario_2")
                Me.dgvControl.Rows(odt_index).Cells("id_usuario_3_dgv").Value = row.Item("id_usuario_3")
                Me.dgvControl.Rows(odt_index).Cells("id_usuario_4_dgv").Value = row.Item("id_usuario_4")
                Me.dgvControl.Rows(odt_index).Cells("id_usuario_5_dgv").Value = row.Item("id_usuario_5")
                Me.dgvControl.Rows(odt_index).Cells("id_usuario_6_dgv").Value = row.Item("id_usuario_6")
                Me.dgvControl.Rows(odt_index).Cells("fecha_asignada_dgv").Value = row.Item("fecha")
                Me.dgvControl.Rows(odt_index).Cells("fecha_inicio_dgv").Value = row.Item("fecha_inicio")
                Me.dgvControl.Rows(odt_index).Cells("fecha_completado_dgv").Value = row.Item("fecha_completado")
                Me.dgvControl.Rows(odt_index).Cells("cadista_1").Value = row.Item("Cadista 1")
                Me.dgvControl.Rows(odt_index).Cells("controlador_1").Value = row.Item("Controlador 1")
                Me.dgvControl.Rows(odt_index).Cells("correccion_1").Value = row.Item("Corrección 1")
                Me.dgvControl.Rows(odt_index).Cells("cadista_2").Value = row.Item("Cadista 2")
                Me.dgvControl.Rows(odt_index).Cells("controlador_2").Value = row.Item("Controlador 2")
                Me.dgvControl.Rows(odt_index).Cells("correccion_2").Value = row.Item("Corrección 2")
                Me.dgvControl.Rows(odt_index).Cells("corr_1_pendiente").Value = row.Item("control_corr_1")
                Me.dgvControl.Rows(odt_index).Cells("corr_2_pendiente").Value = row.Item("control_corr_2")
                If id_movimiento_voz_pendiente = CInt(Me.dgvControl.Rows(odt_index).Cells("id_movimiento_voz_dgv").Value) Then
                    index_pendiente = odt_index
                End If



                If CBool(row.Item("pedido_segundo_control")) Then
                    If CBool(row.Item("control_prod_2")) = False And CBool(row.Item("control_2")) = False Then
                        'FormatCell(Me.dgvControl.Rows(odt_index), Color.Yellow)
                    ElseIf CBool(row.Item("control_prod_2")) = True And CBool(row.Item("control_2")) = False Then
                        FormatCell(Me.dgvControl.Rows(odt_index), Color.LightBlue)
                    ElseIf CBool(row.Item("control_prod_2")) = True And CBool(row.Item("control_2")) = True Then
                        FormatCell(Me.dgvControl.Rows(odt_index), Color.RosyBrown)
                    End If
                Else
                    'Primer control
                    If CBool(row.Item("control_prod")) = False And CBool(row.Item("control_1")) = False Then
                        'FormatCell(Me.dgvControl.Rows(odt_index), Color.Yellow)
                    ElseIf CBool(row.Item("control_prod")) = True And CBool(row.Item("control_1")) = False Then

                        If CInt(row.Item("id_proveedor")) <> 0 Then
                            FormatCell(Me.dgvControl.Rows(odt_index), Color.Gray)
                        Else
                            FormatCell(Me.dgvControl.Rows(odt_index), Color.LightBlue)
                        End If

                    ElseIf CBool(row.Item("control_prod")) = True And CBool(row.Item("control_1")) = True Then
                        FormatCell(Me.dgvControl.Rows(odt_index), Color.RosyBrown)
                    End If
                End If

            End If

        Next
        

        If dgvControl.Rows.Count > 0 And index_pendiente <> 0 Then
            Me.dgvControl.ClearSelection()
            Me.dgvControl.Rows(index_pendiente).Selected = True
        End If

        If Me.dgvControl.Rows.Count > cantidad Then
            'mostrarNotificacion("CONTROL: Tiene un nuevo checklist pendiente")
        End If



        'En espera

        If Me.dgvControlEspera.SelectedRows().Count > 0 Then
            id_movimiento_voz_espera = CInt(Me.dgvControlEspera.SelectedRows(0).Cells("id_movimiento_voz_dgv_espera").Value)
        End If

        odtEspera = oVoz.GetAllInicio_4_PM_EnEspera(vgCodigoUsuario)

        For Each row_grid As DataGridViewRow In dgvControlEspera.Rows
            id_movimiento_grilla = CInt(row_grid.Cells("id_movimiento_voz_dgv_espera").Value)
            encontrado = False
            For Each row As DataRow In odtEspera.Rows
                id_movimiento_tabla = CInt(row.Item("id_movimiento_voz"))
                If id_movimiento_tabla = id_movimiento_grilla Then
                    encontrado = True
                End If
            Next
            If encontrado = False Then
                Me.dgvControlEspera.Rows.Remove(row_grid)
            End If
        Next

        For Each row As DataRow In odtEspera.Rows
            encontrado = False
            id_movimiento_tabla = CInt(row.Item("id_movimiento_voz"))
            For Each row_grid As DataGridViewRow In dgvControlEspera.Rows
                id_movimiento_grilla = CInt(row_grid.Cells("id_movimiento_voz_dgv_espera").Value)

                If id_movimiento_grilla = id_movimiento_tabla Then
                    row_grid.Cells("id_actividad_proyecto_dgv_espera").Value = row.Item("id_actividad_proyecto")
                    row_grid.Cells("id_actividad_dgv_espera").Value = row.Item("id_actividad")
                    row_grid.Cells("id_proyecto_dgv_espera").Value = row.Item("id_proyecto")
                    row_grid.Cells("id_control_dgv_espera").Value = row.Item("id_control")
                    row_grid.Cells("id_movimiento_voz_dgv_espera").Value = row.Item("id_movimiento_voz")
                    row_grid.Cells("control_prod_dgv_espera").Value = row.Item("control_prod")
                    row_grid.Cells("control_1_dgv_espera").Value = row.Item("control_1")
                    row_grid.Cells("pedido_segundo_control_dgv_espera").Value = row.Item("pedido_segundo_control")
                    row_grid.Cells("control_prod_2_dgv_espera").Value = row.Item("control_prod_2")
                    row_grid.Cells("control_2_dgv_espera").Value = row.Item("control_2")
                    row_grid.Cells("nombre_control_dgv_espera").Value = row.Item("nombre_control")
                    row_grid.Cells("nombre_subproyecto_dgv_espera").Value = row.Item("nombre_subproyecto")
                    row_grid.Cells("nombre_proyecto_dgv_espera").Value = row.Item("nombre_proyecto")
                    row_grid.Cells("nombre_actividad_dgv_espera").Value = row.Item("nombre_actividad")
                    row_grid.Cells("id_usuario_1_dgv_espera").Value = row.Item("id_usuario_1")
                    row_grid.Cells("id_usuario_2_dgv_espera").Value = row.Item("id_usuario_2")
                    row_grid.Cells("id_usuario_3_dgv_espera").Value = row.Item("id_usuario_3")
                    row_grid.Cells("id_usuario_4_dgv_espera").Value = row.Item("id_usuario_4")
                    row_grid.Cells("id_usuario_5_dgv_espera").Value = row.Item("id_usuario_5")
                    row_grid.Cells("id_usuario_6_dgv_espera").Value = row.Item("id_usuario_6")
                    row_grid.Cells("fecha_asignada_dgv_espera").Value = row.Item("fecha")
                    row_grid.Cells("fecha_inicio_dgv_espera").Value = row.Item("fecha_inicio")
                    row_grid.Cells("fecha_completado_dgv_espera").Value = row.Item("fecha_completado")
                    row_grid.Cells("cadista_1_espera").Value = row.Item("Cadista 1")
                    row_grid.Cells("controlador_1_espera").Value = row.Item("Controlador 1")
                    row_grid.Cells("correccion_1_espera").Value = row.Item("Corrección 1")
                    row_grid.Cells("cadista_2_espera").Value = row.Item("Cadista 2")
                    row_grid.Cells("controlador_2_espera").Value = row.Item("Controlador 2")
                    row_grid.Cells("correccion_2_espera").Value = row.Item("Corrección 2")
                    row_grid.Cells("corr_1_espera").Value = row.Item("control_corr_1")
                    row_grid.Cells("corr_2_espera").Value = row.Item("control_corr_2")
                    If id_movimiento_voz_espera = CInt(row_grid.Cells("id_movimiento_voz_dgv_espera").Value) Then
                        index_espera = row_grid.Index
                    End If

                    If CBool(row.Item("pedido_segundo_control")) Then
                        If CBool(row.Item("control_prod_2")) = False And CBool(row.Item("control_2")) = False Then
                            'FormatCell(Me.dgvControl.Rows(odt_index), Color.Yellow)
                        ElseIf CBool(row.Item("control_prod_2")) = True And CBool(row.Item("control_2")) = False Then
                            FormatCell(row_grid, Color.LightBlue)
                        ElseIf CBool(row.Item("control_prod_2")) = True And CBool(row.Item("control_2")) = True Then
                            FormatCell(row_grid, Color.RosyBrown)
                        End If
                    Else
                        'Primer control
                        If CBool(row.Item("control_prod")) = False And CBool(row.Item("control_1")) = False Then
                            'FormatCell(Me.dgvControl.Rows(odt_index), Color.Yellow)
                        ElseIf CBool(row.Item("control_prod")) = True And CBool(row.Item("control_1")) = False Then
                            FormatCell(row_grid, Color.LightBlue)
                        ElseIf CBool(row.Item("control_prod")) = True And CBool(row.Item("control_1")) = True Then
                            FormatCell(row_grid, Color.RosyBrown)
                        End If
                    End If
                    encontrado = True

                    Exit For
                End If
            Next

            If encontrado = False Then
                odt_index = Me.dgvControlEspera.Rows.Add()
                Me.dgvControlEspera.Rows(odt_index).Cells("id_actividad_proyecto_dgv_espera").Value = row.Item("id_actividad_proyecto")
                Me.dgvControlEspera.Rows(odt_index).Cells("id_actividad_dgv_espera").Value = row.Item("id_actividad")
                Me.dgvControlEspera.Rows(odt_index).Cells("id_proyecto_dgv_espera").Value = row.Item("id_proyecto")
                Me.dgvControlEspera.Rows(odt_index).Cells("id_control_dgv_espera").Value = row.Item("id_control")
                Me.dgvControlEspera.Rows(odt_index).Cells("id_movimiento_voz_dgv_espera").Value = row.Item("id_movimiento_voz")
                Me.dgvControlEspera.Rows(odt_index).Cells("control_prod_dgv_espera").Value = row.Item("control_prod")
                Me.dgvControlEspera.Rows(odt_index).Cells("control_1_dgv_espera").Value = row.Item("control_1")
                Me.dgvControlEspera.Rows(odt_index).Cells("pedido_segundo_control_dgv_espera").Value = row.Item("pedido_segundo_control")
                Me.dgvControlEspera.Rows(odt_index).Cells("control_prod_2_dgv_espera").Value = row.Item("control_prod_2")
                Me.dgvControlEspera.Rows(odt_index).Cells("control_2_dgv_espera").Value = row.Item("control_2")
                Me.dgvControlEspera.Rows(odt_index).Cells("nombre_control_dgv_espera").Value = row.Item("nombre_control")
                Me.dgvControlEspera.Rows(odt_index).Cells("nombre_subproyecto_dgv_espera").Value = row.Item("nombre_subproyecto")
                Me.dgvControlEspera.Rows(odt_index).Cells("nombre_proyecto_dgv_espera").Value = row.Item("nombre_proyecto")
                Me.dgvControlEspera.Rows(odt_index).Cells("nombre_actividad_dgv_espera").Value = row.Item("nombre_actividad")
                Me.dgvControlEspera.Rows(odt_index).Cells("id_usuario_1_dgv_espera").Value = row.Item("id_usuario_1")
                Me.dgvControlEspera.Rows(odt_index).Cells("id_usuario_2_dgv_espera").Value = row.Item("id_usuario_2")
                Me.dgvControlEspera.Rows(odt_index).Cells("id_usuario_3_dgv_espera").Value = row.Item("id_usuario_3")
                Me.dgvControlEspera.Rows(odt_index).Cells("id_usuario_4_dgv_espera").Value = row.Item("id_usuario_4")
                Me.dgvControlEspera.Rows(odt_index).Cells("id_usuario_5_dgv_espera").Value = row.Item("id_usuario_5")
                Me.dgvControlEspera.Rows(odt_index).Cells("id_usuario_6_dgv_espera").Value = row.Item("id_usuario_6")
                Me.dgvControlEspera.Rows(odt_index).Cells("fecha_inicio_dgv_espera").Value = row.Item("fecha_inicio")
                Me.dgvControlEspera.Rows(odt_index).Cells("fecha_asignada_dgv_espera").Value = row.Item("fecha")
                Me.dgvControlEspera.Rows(odt_index).Cells("fecha_completado_dgv_espera").Value = row.Item("fecha_completado")
                Me.dgvControlEspera.Rows(odt_index).Cells("completado_dgv_espera").Value = row.Item("completado")
                Me.dgvControlEspera.Rows(odt_index).Cells("cadista_1_espera").Value = row.Item("Cadista 1")
                Me.dgvControlEspera.Rows(odt_index).Cells("controlador_1_espera").Value = row.Item("Controlador 1")
                Me.dgvControlEspera.Rows(odt_index).Cells("correccion_1_espera").Value = row.Item("Corrección 1")
                Me.dgvControlEspera.Rows(odt_index).Cells("cadista_2_espera").Value = row.Item("Cadista 2")
                Me.dgvControlEspera.Rows(odt_index).Cells("controlador_2_espera").Value = row.Item("Controlador 2")
                Me.dgvControlEspera.Rows(odt_index).Cells("correccion_2_espera").Value = row.Item("Corrección 2")
                Me.dgvControlEspera.Rows(odt_index).Cells("corr_1_espera").Value = row.Item("control_corr_1")
                Me.dgvControlEspera.Rows(odt_index).Cells("corr_2_espera").Value = row.Item("control_corr_2")
                If id_movimiento_voz_espera = CInt(Me.dgvControlEspera.Rows(odt_index).Cells("id_movimiento_voz_dgv_espera").Value) Then
                    index_espera = odt_index
                End If
            End If
        Next

        If dgvControlEspera.Rows.Count > 0 And index_espera <> 0 Then
            Me.dgvControlEspera.ClearSelection()
            Me.dgvControlEspera.Rows(index_espera).Selected = True
        End If


        'Completados

        If Me.dgvControlesCompletados.SelectedRows().Count > 0 Then
            id_movimiento_voz_completado = CInt(Me.dgvControlesCompletados.SelectedRows(0).Cells("id_movimiento_voz_dgv_completado").Value)
        End If

        odtCompletado = oVoz.GetAllInicio_4_PM_Completados(vgCodigoUsuario)

        For Each row_grid As DataGridViewRow In dgvControlesCompletados.Rows
            id_movimiento_grilla = CInt(row_grid.Cells("id_movimiento_voz_dgv_completado").Value)
            encontrado = False
            For Each row As DataRow In odtCompletado.Rows
                id_movimiento_tabla = CInt(row.Item("id_movimiento_voz"))
                If id_movimiento_tabla = id_movimiento_grilla Then
                    encontrado = True
                End If
            Next
            If encontrado = False Then
                Me.dgvControlesCompletados.Rows.Remove(row_grid)
            End If
        Next

        For Each row As DataRow In odtCompletado.Rows
            encontrado = False
            id_movimiento_tabla = CInt(row.Item("id_movimiento_voz"))
            For Each row_grid As DataGridViewRow In dgvControlesCompletados.Rows
                id_movimiento_grilla = CInt(row_grid.Cells("id_movimiento_voz_dgv_completado").Value)

                If id_movimiento_grilla = id_movimiento_tabla Then
                    row_grid.Cells("id_actividad_proyecto_dgv_completado").Value = row.Item("id_actividad_proyecto")
                    row_grid.Cells("id_actividad_dgv_completado").Value = row.Item("id_actividad")
                    row_grid.Cells("id_proyecto_dgv_completado").Value = row.Item("id_proyecto")
                    row_grid.Cells("id_control_dgv_completado").Value = row.Item("id_control")
                    row_grid.Cells("id_movimiento_voz_dgv_completado").Value = row.Item("id_movimiento_voz")
                    row_grid.Cells("control_prod_dgv_completado").Value = row.Item("control_prod")
                    row_grid.Cells("control_1_dgv_completado").Value = row.Item("control_1")
                    row_grid.Cells("pedido_segundo_control_dgv_completado").Value = row.Item("pedido_segundo_control")
                    row_grid.Cells("control_prod_2_dgv_completado").Value = row.Item("control_prod_2")
                    row_grid.Cells("control_2_dgv_completado").Value = row.Item("control_2")
                    row_grid.Cells("nombre_control_dgv_completado").Value = row.Item("nombre_control")
                    row_grid.Cells("nombre_subproyecto_dgv_completado").Value = row.Item("nombre_subproyecto")
                    row_grid.Cells("nombre_proyecto_dgv_completado").Value = row.Item("nombre_proyecto")
                    row_grid.Cells("nombre_actividad_dgv_completado").Value = row.Item("nombre_actividad")
                    row_grid.Cells("id_usuario_1_dgv_completado").Value = row.Item("id_usuario_1")
                    row_grid.Cells("id_usuario_2_dgv_completado").Value = row.Item("id_usuario_2")
                    row_grid.Cells("id_usuario_3_dgv_completado").Value = row.Item("id_usuario_3")
                    row_grid.Cells("id_usuario_4_dgv_completado").Value = row.Item("id_usuario_4")
                    row_grid.Cells("id_usuario_5_dgv_completado").Value = row.Item("id_usuario_5")
                    row_grid.Cells("id_usuario_6_dgv_completado").Value = row.Item("id_usuario_6")
                    row_grid.Cells("fecha_asignada_dgv_completado").Value = row.Item("fecha")
                    row_grid.Cells("fecha_inicio_dgv_completado").Value = row.Item("fecha_inicio")
                    row_grid.Cells("fecha_completado_dgv_completado").Value = row.Item("fecha_completado")
                    row_grid.Cells("cadista_1_completado").Value = row.Item("Cadista 1")
                    row_grid.Cells("controlador_1_completado").Value = row.Item("Controlador 1")
                    row_grid.Cells("correccion_1_completado").Value = row.Item("Corrección 1")
                    row_grid.Cells("cadista_2_completado").Value = row.Item("Cadista 2")
                    row_grid.Cells("controlador_2_completado").Value = row.Item("Controlador 2")
                    row_grid.Cells("correccion_2_completado").Value = row.Item("Corrección 2")
                    row_grid.Cells("corr_1_completado").Value = row.Item("control_corr_1")
                    row_grid.Cells("corr_2_completado").Value = row.Item("control_corr_2")
                    If id_movimiento_voz_completado = CInt(row_grid.Cells("id_movimiento_voz_dgv_completado").Value) Then
                        index_completado = row_grid.Index
                    End If

                    If CBool(row.Item("pedido_segundo_control")) Then
                        If CBool(row.Item("control_prod_2")) = False And CBool(row.Item("control_2")) = False Then

                        ElseIf CBool(row.Item("control_prod_2")) = True And CBool(row.Item("control_2")) = False Then
                            FormatCell(row_grid, Color.LightBlue)
                        ElseIf CBool(row.Item("control_prod_2")) = True And CBool(row.Item("control_2")) = True Then
                            FormatCell(row_grid, Color.RosyBrown)
                        End If
                    Else
                        'Primer control
                        If CBool(row.Item("control_prod")) = False And CBool(row.Item("control_1")) = False Then

                        ElseIf CBool(row.Item("control_prod")) = True And CBool(row.Item("control_1")) = False Then
                            FormatCell(row_grid, Color.LightBlue)
                        ElseIf CBool(row.Item("control_prod")) = True And CBool(row.Item("control_1")) = True Then
                            FormatCell(row_grid, Color.RosyBrown)
                        End If
                    End If
                    encontrado = True

                    Exit For
                End If
            Next

            If encontrado = False Then
                odt_index = Me.dgvControlesCompletados.Rows.Add()
                Me.dgvControlesCompletados.Rows(odt_index).Cells("id_actividad_proyecto_dgv_completado").Value = row.Item("id_actividad_proyecto")
                Me.dgvControlesCompletados.Rows(odt_index).Cells("id_actividad_dgv_completado").Value = row.Item("id_actividad")
                Me.dgvControlesCompletados.Rows(odt_index).Cells("id_proyecto_dgv_completado").Value = row.Item("id_proyecto")
                Me.dgvControlesCompletados.Rows(odt_index).Cells("id_control_dgv_completado").Value = row.Item("id_control")
                Me.dgvControlesCompletados.Rows(odt_index).Cells("id_movimiento_voz_dgv_completado").Value = row.Item("id_movimiento_voz")
                Me.dgvControlesCompletados.Rows(odt_index).Cells("control_prod_dgv_completado").Value = row.Item("control_prod")
                Me.dgvControlesCompletados.Rows(odt_index).Cells("control_1_dgv_completado").Value = row.Item("control_1")
                Me.dgvControlesCompletados.Rows(odt_index).Cells("pedido_segundo_control_dgv_completado").Value = row.Item("pedido_segundo_control")
                Me.dgvControlesCompletados.Rows(odt_index).Cells("control_prod_2_dgv_completado").Value = row.Item("control_prod_2")
                Me.dgvControlesCompletados.Rows(odt_index).Cells("control_2_dgv_completado").Value = row.Item("control_2")
                Me.dgvControlesCompletados.Rows(odt_index).Cells("nombre_control_dgv_completado").Value = row.Item("nombre_control")
                Me.dgvControlesCompletados.Rows(odt_index).Cells("nombre_subproyecto_dgv_completado").Value = row.Item("nombre_subproyecto")
                Me.dgvControlesCompletados.Rows(odt_index).Cells("nombre_proyecto_dgv_completado").Value = row.Item("nombre_proyecto")
                Me.dgvControlesCompletados.Rows(odt_index).Cells("nombre_actividad_dgv_completado").Value = row.Item("nombre_actividad")
                Me.dgvControlesCompletados.Rows(odt_index).Cells("id_usuario_1_dgv_completado").Value = row.Item("id_usuario_1")
                Me.dgvControlesCompletados.Rows(odt_index).Cells("id_usuario_2_dgv_completado").Value = row.Item("id_usuario_2")
                Me.dgvControlesCompletados.Rows(odt_index).Cells("id_usuario_3_dgv_completado").Value = row.Item("id_usuario_3")
                Me.dgvControlesCompletados.Rows(odt_index).Cells("id_usuario_4_dgv_completado").Value = row.Item("id_usuario_4")
                Me.dgvControlesCompletados.Rows(odt_index).Cells("id_usuario_5_dgv_completado").Value = row.Item("id_usuario_5")
                Me.dgvControlesCompletados.Rows(odt_index).Cells("id_usuario_6_dgv_completado").Value = row.Item("id_usuario_6")
                Me.dgvControlesCompletados.Rows(odt_index).Cells("fecha_inicio_dgv_completado").Value = row.Item("fecha_inicio")
                Me.dgvControlesCompletados.Rows(odt_index).Cells("fecha_asignada_dgv_completado").Value = row.Item("fecha")
                Me.dgvControlesCompletados.Rows(odt_index).Cells("fecha_completado_dgv_completado").Value = row.Item("fecha_completado")
                Me.dgvControlesCompletados.Rows(odt_index).Cells("completado_dgv_completado").Value = row.Item("completado")
                Me.dgvControlesCompletados.Rows(odt_index).Cells("cadista_1_completado").Value = row.Item("Cadista 1")
                Me.dgvControlesCompletados.Rows(odt_index).Cells("controlador_1_completado").Value = row.Item("Controlador 1")
                Me.dgvControlesCompletados.Rows(odt_index).Cells("correccion_1_completado").Value = row.Item("Corrección 1")
                Me.dgvControlesCompletados.Rows(odt_index).Cells("cadista_2_completado").Value = row.Item("Cadista 2")
                Me.dgvControlesCompletados.Rows(odt_index).Cells("controlador_2_completado").Value = row.Item("Controlador 2")
                Me.dgvControlesCompletados.Rows(odt_index).Cells("correccion_2_completado").Value = row.Item("Corrección 2")
                Me.dgvControlesCompletados.Rows(odt_index).Cells("corr_1_completado").Value = row.Item("control_corr_1")
                Me.dgvControlesCompletados.Rows(odt_index).Cells("corr_2_completado").Value = row.Item("control_corr_2")
                If id_movimiento_voz_completado = CInt(Me.dgvControlesCompletados.Rows(odt_index).Cells("id_movimiento_voz_dgv_completado").Value) Then
                    index_completado = odt_index
                End If
            End If
        Next

        If dgvControlesCompletados.Rows.Count > 0 And index_completado <> 0 Then
            Me.dgvControlesCompletados.ClearSelection()
            Me.dgvControlesCompletados.Rows(index_completado).Selected = True
        End If

    End Sub

    Private Sub FormatCell(ByRef row As DataGridViewRow, ByVal color As Color)
        For Each cell As DataGridViewCell In row.Cells
            cell.Style.BackColor = color
        Next
    End Sub


    Dim odtProyecto As New DataTable
    Dim odtActividad As New DataTable
    Dim odtActividad_proyecto As New DataTable

   
    Private Sub btnRealizarControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRealizarControl.Click

        If Me.dgvControl.SelectedRows.Count > 0 Then
            Me.RealizarControl(CInt(Me.dgvControl.SelectedRows(0).Cells("id_movimiento_voz_dgv").Value), 0)
        End If

    End Sub


    Private Sub ReordenarVocesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        oVoz.UpdateRandom()
        MessageBox.Show("El orden aleatoreo de las voces ha cambiado correctamente")
    End Sub


    Private Sub chkControlProyecto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.RefrescarControl()
        Catch ex As Exception
        End Try
    End Sub

  
 

    'agregado recien para tareas por usuario
    Private Sub tsTareasXUsuario_MouseHover(sender As System.Object, e As System.EventArgs) Handles tsTareasXUsuario.MouseHover
        Me.tsTareasXUsuario.DropDownItems.Clear()
        Dim odtUsuarios As New DataTable
        odtUsuarios = oUsuario.GetActivo()

        For Each row As DataRow In odtUsuarios.Rows
            Dim menu As New ToolStripMenuItem
            Dim img As Image = Nothing

            menu.Name = "ts" & CStr(row.Item("Nombre_usuario"))
            menu.Text = CStr(row.Item("Nombre_usuario"))
            tsTareasXUsuario.DropDownItems.Add(menu.Text, img, New EventHandler(AddressOf crearEvento_Click))
        Next
    End Sub

    Public Sub crearEvento_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'Dim odtTarea1 As New DataTable

        'odtTarea1 = oDetalle_recurso.GetPendienteUsuario(CType(sender, ToolStripMenuItem).Text)

        'Me.dgvTarea.DataSource = odtTarea1
        'Me.dgvTarea.Columns(0).Visible = False
        'Me.dgvTarea.Columns("id_proyecto").Visible = False
        'Me.dgvTarea.Columns("id_actividad_proyecto").Visible = False
        'Me.dgvTarea.Columns("id_actividad").Visible = False

        'If odtTarea1.Rows.Count <= 0 Then
        '    Me.txtEstadoTarea.BackColor = Color.YellowGreen
        'Else
        '    Me.txtEstadoTarea.BackColor = Color.Red
        'End If
    End Sub

    'coloca el rojo en la celdas negativas
    Private Sub dgvControl_CellFormatting(ByVal sender As Object, _
    ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)
        Try
            CType(sender, DataGridView).Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Green

            ''Pone en verde las filas que tengan check en Control 2

            'If CType(sender, DataGridView).Columns(e.ColumnIndex).Name = "2" Then
            '    If CBool(e.Value) = True Then
            '        'CType(sender, DataGridView).Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Green
            '        Exit Sub
            '    End If
            'ElseIf CType(sender, DataGridView).Columns(e.ColumnIndex).Name = "1" Then

            'ElseIf CType(sender, DataGridView).Columns(e.ColumnIndex).Name = "P" Then

            '    For Each fila As DataGridViewRow In CType(sender, DataGridView).Rows
            '        If CBool(fila.Cells("1").Value.ToString()) = True Then
            '            If CBool(fila.Cells("P").Value.ToString()) = True Then
            '                fila.DefaultCellStyle.BackColor = Color.YellowGreen
            '            Else
            '                fila.DefaultCellStyle.BackColor = Color.Yellow
            '            End If

            '        Else
            '            If CBool(fila.Cells("P").Value.ToString()) = True Then
            '                fila.DefaultCellStyle.BackColor = Color.Yellow
            '            End If
            '        End If

            '    Next
            'End If

        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnInforme_Click(sender As Object, e As EventArgs) Handles btnInforme.Click
        Try
            'Me.id_movimiento_voz_pdf = CInt(dgvControl.Item("id_movimiento_voz_dgv", dgvControl.CurrentRow.Index).Value)
            Background_pdf.RunWorkerAsync()
            MessageBox.Show("Este proceso puede demorar. Se abrirá el PDF una vez finalizado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnInforme.Enabled = False
            btnInforme.Text = "Espere..."
        Catch ex As Exception
            btnInforme.Enabled = True
            btnInforme.Text = "ver PDF"
        End Try

    End Sub


    Private Sub Background_pdf_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Background_pdf.DoWork
        Try
            If Me.id_movimiento_voz_pdf <> 0 Then
                Dim proc As New ProcedimientosParticulares
                proc.RealizarProcedimiento(id_movimiento_voz_pdf)
            End If


        Catch ex As Exception
            MessageBox.Show("Debe seleccionar un control")
        End Try
    End Sub


    Private Sub Background_pdf_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Background_pdf.RunWorkerCompleted
        btnInforme.Enabled = True
        btnInforme.Text = "ver PDF"
    End Sub


    Private Sub frmLoginInicio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Application.Exit()

        If MessageBox.Show("¿Desea Realmente Salir del Sistema?", "SALIR", _
       MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
       = Windows.Forms.DialogResult.No Then
            e.Cancel = True
            Exit Sub
        End If

        If Me.id_cuerpo_movimiento_hora <> 0 Then
            Try
                With oCuerpo_movimiento_hora
                    .Cargar()
                    .Modificar(Me.id_cuerpo_movimiento_hora)
                    .salida = DateTime.Now
                    .Guardar()
                End With
            Catch ex As Exception
            End Try
        End If


    End Sub


    Private Sub tabControles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabControles.SelectedIndexChanged
        Me.HabilitarControlesControl(False)
    End Sub


    Private Sub dgvControlEspera_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvControlEspera.CellDoubleClick
        Try
            Me.id_control_pdf = CInt(CType(sender, DataGridView).Item("id_control_dgv_espera", CType(sender, DataGridView).CurrentRow.Index).Value)
            Me.id_movimiento_voz_pdf = CInt(CType(sender, DataGridView).Item("id_movimiento_voz_dgv_espera", CType(sender, DataGridView).CurrentRow.Index).Value)
            btnInforme.Enabled = True
            
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvControlesCompletados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvControlesCompletados.CellDoubleClick
        Try
            Me.id_control_pdf = CInt(CType(sender, DataGridView).Item("id_control_dgv_completado", CType(sender, DataGridView).CurrentRow.Index).Value)
            Me.id_movimiento_voz_pdf = CInt(CType(sender, DataGridView).Item("id_movimiento_voz_dgv_completado", CType(sender, DataGridView).CurrentRow.Index).Value)
            btnInforme.Enabled = True

        Catch ex As Exception

        End Try
    End Sub


    Private Sub dgvControl_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvControl.CellClick, dgvControlEspera.CellClick, dgvControlesCompletados.CellClick
        If CType(sender, DataGridView).SelectedRows.Count > 0 Then
            Me.HabilitarControlesControl(True)

            Dim odt As DataTable

            If tabControles.SelectedIndex = 0 Then
                odt = oVoz.GetInformacion(CInt(Me.dgvControl.SelectedRows(0).Cells("id_movimiento_voz_dgv").Value))
                Me.id_movimiento_voz_pdf = CInt(Me.dgvControl.SelectedRows(0).Cells("id_movimiento_voz_dgv").Value)
                Me.btnRealizarControl.Enabled = True
            ElseIf tabControles.SelectedIndex = 1 Then
                odt = oVoz.GetInformacion(CInt(Me.dgvControlEspera.SelectedRows(0).Cells("id_movimiento_voz_dgv_espera").Value))
                Me.id_movimiento_voz_pdf = CInt(Me.dgvControlEspera.SelectedRows(0).Cells("id_movimiento_voz_dgv_espera").Value)
            ElseIf tabControles.SelectedIndex = 2 Then
                odt = oVoz.GetInformacion(CInt(Me.dgvControlesCompletados.SelectedRows(0).Cells("id_movimiento_voz_dgv_completado").Value))
                Me.id_movimiento_voz_pdf = CInt(Me.dgvControlesCompletados.SelectedRows(0).Cells("id_movimiento_voz_dgv_completado").Value)
            Else
                Exit Sub
            End If


            For Each row As DataRow In odt.Rows

                Me.chk_produccion_control.Checked = CBool(row.Item("control_prod"))
                Me.chk_control_1_control.Checked = CBool(row.Item("control_1"))
                Me.chk_produccion_2_control.Checked = CBool(row.Item("control_prod_2"))
                Me.chk_control_2_control.Checked = CBool(row.Item("control_2"))
                Me.chk_correccion_1_control.Checked = CBool(row.Item("control_corr_1"))
                Me.chk_correccion_2_control.Checked = CBool(row.Item("control_corr_2"))

                Me.txt_control_control.Text = row.Item("nombre_control").ToString()
                Me.txt_cliente_control.Text = row.Item("nombre_cliente").ToString()
                Me.txt_subproyecto_control.Text = row.Item("nombre_subproyecto").ToString()
                Me.txt_proyecto_control.Text = row.Item("nombre_proyecto").ToString()
                Me.txt_actividad_control.Text = row.Item("nombre_actividad").ToString()

                Me.txt_fecha_inicio_control.Text = row.Item("fecha_inicio").ToString()
                Me.txt_fecha_completado_control.Text = row.Item("fecha_completado").ToString()

                Me.txt_produccion_control.Text = row.Item("Cadista 1").ToString()
                Me.txt_control_1_control.Text = row.Item("Controlador 1").ToString()
                Me.txt_correccion_1_control.Text = row.Item("Corrección 1").ToString()
                Me.txt_produccion_2_control.Text = row.Item("Cadista 2").ToString()
                Me.txt_control_2_control.Text = row.Item("Controlador 2").ToString()
                Me.txt_correccion_2_control.Text = row.Item("Corrección 2").ToString()

                Me.chk_completado_control.Checked = CBool(row.Item("completado"))
            Next
        Else
            Me.HabilitarControlesControl(False)
        End If
    End Sub

    Private Sub HabilitarControlesControl(ByVal val As Boolean)
        Me.txt_control_control.Text = ""
        Me.txt_control_control.Enabled = val

        Me.Label30.Enabled = val

        Me.grp_propiedades_control.Enabled = val
        Me.txt_cliente_control.Text = ""
        Me.txt_proyecto_control.Text = ""
        Me.txt_subproyecto_control.Text = ""
        Me.txt_actividad_control.Text = ""
        Me.grp_estado_control.Enabled = val
        Me.txt_produccion_control.Text = ""
        Me.chk_produccion_control.Checked = False
        Me.txt_control_1_control.Text = ""
        Me.chk_control_1_control.Checked = False
        Me.txt_correccion_1_control.Text = ""
        Me.chk_correccion_1_control.Checked = False
        Me.txt_produccion_2_control.Text = ""
        Me.chk_produccion_2_control.Checked = False
        Me.txt_correccion_2_control.Text = ""
        Me.chk_correccion_2_control.Checked = False
        Me.txt_control_2_control.Text = ""
        Me.chk_control_2_control.Checked = False
        Me.grp_fechas_control.Enabled = val
        Me.txt_fecha_inicio_control.Text = ""
        Me.txt_fecha_completado_control.Text = ""

        Me.btnInforme.Enabled = val
        Me.btnRealizarControl.Enabled = False
        Me.id_movimiento_voz_pdf = 0

    End Sub


    

    Private Sub RealizarControl(ByVal id_movimiento_voz As Integer, ByVal id_detalle_recurso As Integer)

        With oMovimiento_voz
            .Cargar()
            .Modificar(id_movimiento_voz)
        End With

        If oMovimiento_voz.control_prod = False Then
            vgNumeroControl = 1 'Control del cadista
        ElseIf oMovimiento_voz.control_prod And oMovimiento_voz.control_1 = False And oMovimiento_voz.control_2 = False Then
            vgNumeroControl = 2 'Primer control
        ElseIf oMovimiento_voz.control_prod = True And oMovimiento_voz.control_1 = True And oMovimiento_voz.control_2 = False And oMovimiento_voz.control_prod_2 = False Then
            If oMovimiento_voz.pedido_segundo_control = True Then
                vgNumeroControl = 4 ' El cadista tiene que hacer el checklist de nuevo
            Else
                vgNumeroControl = 3 'El cadista tiene que corregir el primer control, no se hizo pedido de 2do control
            End If
        ElseIf oMovimiento_voz.control_prod And oMovimiento_voz.control_1 = True And oMovimiento_voz.control_2 = False And oMovimiento_voz.control_prod_2 = True Then
            vgNumeroControl = 5 'El controlador tiene que corregir el nuevo control
        ElseIf oMovimiento_voz.control_prod = True And oMovimiento_voz.control_1 = True And oMovimiento_voz.control_2 = True And oMovimiento_voz.control_prod_2 = True Then
            vgNumeroControl = 6 'El cadista tiene que corregir el 2do control
        End If


        If Me.chkP.Checked = False And Me.chk1.Checked = False And Me.chk2.Checked = False Then
            With oMovimiento_voz
                .Cargar()
                .Modificar(id_movimiento_voz)
                .id_cadista = vgCodigoUsuario
                .Guardar()
            End With
        End If

        If Me.chkP.Checked = True And Me.chk1.Checked = False And Me.chk2.Checked = False Then
            With oMovimiento_voz
                .Cargar()
                .Modificar(id_movimiento_voz)
                .id_controlador_asignado = vgCodigoUsuario
                .id_usuario_2 = vgCodigoUsuario
                .id_usuario_5 = vgCodigoUsuario
                .Guardar()
            End With
        End If

        Me.Visible = False

        Dim frmTemp As New frmControlActividad(oMovimiento_voz.id_actividad_proyecto, id_detalle_recurso, oMovimiento_voz.id_movimiento_voz)
        Me.AddOwnedForm(frmTemp)
        frmTemp.ShowDialog()

        Me.Visible = True
        vgControlLogueo = True
        Me.RefrescarControl()

    End Sub




End Class