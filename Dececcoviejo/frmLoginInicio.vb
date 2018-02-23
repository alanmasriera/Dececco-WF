Imports System.Text
Imports System.Data.SqlClient
Imports PopupNotifier
Imports System.Windows.Forms.Integration
Imports DlhSoft.Windows.Controls
Imports DlhSoft.Windows.Data
Imports System.Windows.Media

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
    Dim es_admin As Boolean = False
    Dim _task_manager As New TaskManager
    Dim _Actividad As New Dececco.Actividad
    Dim _Tipo_Actividad As New Tipo_actividad



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
        Me.cargarGrillaClientes()
        ' Add any initialization after the InitializeComponent() call.

        Me.DeshabilitarTabs()

        Me.es_admin = Me.verificarPermiso()
        If Me.es_admin = False Then
            eliminarControlNoAdministrador()
        Else
            'Borra pagina Gantt
            TabControl1.TabPages.Remove(TabControl1.TabPages.Item(11))
        End If

        Me.ActualizarGrillaLogueoUsuario()

    End Sub

    Private Sub frmLoginInicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Load_tree()
        Me.actualizarHoraLogueo()
        Me.RefrescarControl()
        Me.RefrescarPermisos()
        Me.RefrescarLogueo()
        Me.RefrescarTarea()
        Me.CargarGrillaTareasPendientes()

        ActualizarGrillaLogueo()

        oProyecto.Cargar()

        Me.Timer1.Start()
        Me.Timer_Logueo.Enabled = True
        Me.Timer_Logueo.Start()
        Me.TimerLogueo.Start()

        


    End Sub

    'Grilla de los logueos por proyecto y actividad DEL usuario
    Sub RefrescarGrillaLogueo()

        Dim odtMovimientoHora As New DataTable
        Dim odtDetalle As New DataTable
        Dim decTotal As Decimal = 0
        Dim decTotalHora As Decimal = 0
        Dim decMinuto As Decimal = 0
        Dim dtInicio As DateTime
        Dim dtFin As DateTime
        Dim dr_index As Integer
        Dim IDMov As Integer = 0

        'En realidad usa el cop_movimiento_hora_GetAll_4
        'Muestra (ademas de las que se ocultan aca): Hora entrada, hora salida, horas, proyecto, actividad
        odtMovimientoHora = oMovimiento_hora.GetAll_3(CInt(vgCodigoUsuario), DateTime.Now.Date, DateAdd(DateInterval.Day, 1, DateTime.Now.Date))


        dgvLogueo.Rows.Clear()

        For Each row As DataRow In odtMovimientoHora.Rows
            dr_index = dgvLogueo.Rows.Add()
            With dgvLogueo.Rows(dr_index)
                .Cells("id_cuerpo_movimiento_hora_login_dgv").Value = row.Item("id_cuerpo_movimiento_hora")
                .Cells("id_actividad_proyecto_login_dgv").Value = row.Item("id_actividad_proyecto")
                .Cells("entrada_login_dgv").Value = row.Item("Entrada")
                .Cells("salida_login_dgv").Value = row.Item("Salida")
                .Cells("tiempo_login_dgv").Value = row.Item("Tiempo (hh:mm:ss)")
                .Cells("actividad_login_dgv").Value = row.Item("Actividad")
                .Cells("proyecto_login_dgv").Value = row.Item("Proyecto")
                .Cells("nombre_proyecto_login_dgv").Value = row.Item("nombre_proyecto")
                .Cells("id_movimiento_hora_login_dgv").Value = row.Item("id_movimiento_hora")
                .Cells("id_proyecto_dgv_logueo").Value = row.Item("id_proyecto")
                .Cells("id_cliente_dgv_logueo").Value = row.Item("id_cliente")
            End With
        Next

        Dim hora As String

        For Each row As DataGridViewRow In dgvLogueo.Rows
            hora = row.Cells("tiempo_login_dgv").Value.ToString()
            hora = TimeSpan.FromSeconds(CDbl(hora)).ToString("hh\:mm\:ss")
            row.Cells("tiempo_login_dgv").Value = hora
        Next

        'Calcula la cantidad de horas logueadas
        For Each row As DataRow In odtMovimientoHora.Rows
            dtInicio = CDate(row("entrada"))
            dtFin = CDate(row("salida"))

            'calcula la cantidad de horas trabajadas
            decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtFin)
            decTotal = CDec(FormatNumber(decMinuto / 60, 1))
            decTotalHora = decTotalHora + decTotal
        Next

    End Sub

    Private Sub actualizarHoraLogueo()
        If oMovimiento_hora.GetHoraLogueo(vgCodigoUsuario) Is Nothing Then
            hora_logueo_dia = Date.Now
        Else
            hora_logueo_dia = oMovimiento_hora.GetHoraLogueo(vgCodigoUsuario)
        End If
    End Sub

    Sub RefrescarTarea()

    End Sub

    Sub RefrescarPermisos()

        'Descativa todo

        'ToolStrip Menu
        Me.tsAdministrarControl.Enabled = False
        Me.tsAdministrarCuentaCliente.Enabled = False
        Me.tsAdministrarCuentaProveedor.Enabled = False
        Me.tsAdministrarIva.Enabled = False
        Me.tsAdministrarHora.Enabled = False
        Me.tsAdministrarSeguridad.Enabled = False
        Me.tsAdministrarBanco.Enabled = False
        Me.tsAdministrarCaja.Enabled = False

        'Me.tsAgregarActividad.Enabled = False

        'Me.tsAgregarFactura.Enabled = False
        'Me.tsAgregarProyecto.Enabled = False
        'Me.tsAgregarProyectoInicial.Enabled = False

        ' Me.tsAsignarRecurso.Enabled = False
        ' Me.tsBorrarActividad.Enabled = False
        Me.tsBorrarHoraDevolver.Enabled = False
        ' Me.tsBorrarProyecto.Enabled = False

        Me.tsCalendarioAnual.Enabled = False
        ' Me.tsCopiarEstructura.Enabled = False
        '  Me.tsCopiarProyecto.Enabled = False
        Me.tsHorasADevolver.Enabled = False

        '  Me.tsModificarActividad.Enabled = False
        Me.tsModificarHoraDevolver.Enabled = False
        '  Me.tsModificarProyecto.Enabled = False

        Me.tsMostrarProyectosOcultos.Enabled = False
        Me.tsNuevoCalendario.Enabled = False
        ' Me.tsPegarEstructura.Enabled = False
        ' Me.tsPegarProyecto.Enabled = False
        Me.tsReordenarVoz.Enabled = False
        Me.tsRevisarCalendario.Enabled = False
        '  Me.tsPegarEstructuraProyectoInicial.Enabled = False


        'botones
        Me.tsCliente.Enabled = False
        Me.tsControl.Enabled = False

        Me.tsHora.Enabled = False
        Me.tsIva.Enabled = False
        Me.tsProveedor.Enabled = False
        Me.tsProyecto.Enabled = False
        Me.tsSeguridad.Enabled = False
        Me.tsCaja.Enabled = False
        Me.tsBanco.Enabled = False
        Me.ResumenPeriodicoToolStripMenuItem.Enabled = False

        Dim odt As New DataTable
        odt = oUsuario.GetPermiso_2(vgNombreUsuario)


        For Each dr As DataRow In odt.Rows
            Select Case CStr(dr("formulario"))

                Case "tsAdministrarControl"
                    Me.tsAdministrarControl.Enabled = CBool(dr("habilitado"))
                Case "tsAdministrarCuentaCliente"
                    Me.tsAdministrarCuentaCliente.Enabled = CBool(dr("habilitado"))
                Case "tsAdministrarCuentaProveedor"
                    Me.tsAdministrarCuentaProveedor.Enabled = CBool(dr("habilitado"))
                Case "tsAdministrarIva"
                    Me.tsAdministrarIva.Enabled = CBool(dr("habilitado"))
                Case "tsAdministrarHora"
                    Me.tsAdministrarHora.Enabled = CBool(dr("habilitado"))
                Case "tsAdministrarSeguridad"
                    Me.tsAdministrarSeguridad.Enabled = CBool(dr("habilitado"))
                Case "tsAdministrarCaja"
                    Me.tsAdministrarCaja.Enabled = CBool(dr("habilitado"))
                Case "tsAdministrarBanco"
                    Me.tsAdministrarBanco.Enabled = CBool(dr("habilitado"))
                Case "tsReportesControl"
                    Me.tsReportesControl.Enabled = CBool(dr("habilitado"))
                Case "tsVerControles"
                    Me.tsVerControles.Enabled = CBool(dr("habilitado"))
                Case "tsVerLogueos"
                    Me.tsVerLogueos.Enabled = CBool(dr("habilitado"))
                Case "tsResumenPeriodico"
                    Me.ResumenPeriodicoToolStripMenuItem.Enabled = CBool(dr("habilitado"))
                Case "tsAgregarFactura"
                    Me.tsAgregarFactura.Enabled = CBool(dr("habilitado"))
                    ' Case "tsAgregarProyecto"
                    'Me.tsAgregarProyecto.Enabled = CBool(dr("habilitado"))
                    ' Case "tsAgregarProyectoInicial"
                    '   Me.tsAgregarProyectoInicial.Enabled = CBool(dr("habilitado"))
                    '  Case "tsPegarEstructuraProyectoInicial"
                    ' Me.tsPegarEstructuraProyectoInicial.Enabled = CBool(dr("habilitado")) 'agregado

                    ' Case "tsAsignarRecurso"
                    ' Me.tsAsignarRecurso.Enabled = CBool(dr("habilitado"))
                    ' Case "tsBorrarActividad"
                    '  Me.tsBorrarActividad.Enabled = CBool(dr("habilitado"))
                Case "tsBorrarHoraDevolver"
                    Me.tsBorrarHoraDevolver.Enabled = CBool(dr("habilitado"))
                    '  Case "tsBorrarProyecto"
                    '    Me.tsBorrarProyecto.Enabled = CBool(dr("habilitado"))
                Case "tsCalendarioAnual"
                    Me.tsCalendarioAnual.Enabled = CBool(dr("habilitado"))
                    ' Case "tsCopiarEstructura"
                    '   Me.tsCopiarEstructura.Enabled = CBool(dr("habilitado"))
                    'Case "tsCopiarProyecto"
                    '   Me.tsCopiarProyecto.Enabled = CBool(dr("habilitado"))
                Case "tsHorasADevolver"
                    Me.tsHorasADevolver.Enabled = CBool(dr("habilitado"))
                    ' Case "tsModificarActividad"
                    '  Me.tsModificarActividad.Enabled = CBool(dr("habilitado"))
                Case "tsModificarHoraDevolver"
                    Me.tsModificarHoraDevolver.Enabled = CBool(dr("habilitado"))
                    'Case "tsModificarProyecto"
                    '  Me.tsModificarProyecto.Enabled = CBool(dr("habilitado"))
                Case "tsMostrarProyectosOcultos"
                    Me.tsMostrarProyectosOcultos.Enabled = CBool(dr("habilitado"))
                Case "tsNuevoCalendario"
                    Me.tsNuevoCalendario.Enabled = CBool(dr("habilitado"))
                    'Case "tsPegarEstructura"
                    '   Me.tsPegarEstructura.Enabled = CBool(dr("habilitado"))
                    ' Case "tsPegarProyecto"
                    '  Me.tsPegarProyecto.Enabled = CBool(dr("habilitado"))
                Case "tsReordenarVoz"
                    Me.tsReordenarVoz.Enabled = CBool(dr("habilitado"))
                Case "tsRevisarCalendario"
                    Me.tsRevisarCalendario.Enabled = CBool(dr("habilitado"))

               
                Case "tsCliente"
                    Me.tsCliente.Visible = CBool(dr("habilitado"))
                    Me.tsCliente.Enabled = CBool(dr("habilitado"))
                    Me.ts_cliente.Visible = CBool(dr("habilitado"))
                    Me.ts_cliente.Enabled = CBool(dr("habilitado"))

                Case "tsControl"
                    Me.tsControl.Visible = CBool(dr("habilitado"))
                    Me.tsControl.Enabled = CBool(dr("habilitado"))
                Case "tsFactura"

                Case "tsHora"
                    Me.tsHora.Visible = CBool(dr("habilitado"))
                    Me.tsHora.Enabled = CBool(dr("habilitado"))
                Case "tsIva"
                    Me.tsIva.Visible = CBool(dr("habilitado"))
                    Me.tsIva.Enabled = CBool(dr("habilitado"))
                Case "tsProveedor"
                    Me.tsProveedor.Visible = CBool(dr("habilitado"))
                    Me.tsProveedor.Enabled = CBool(dr("habilitado"))
                Case "tsProyecto"
                    Me.tsProyecto.Visible = CBool(dr("habilitado"))
                    Me.tsProyecto.Enabled = CBool(dr("habilitado"))
                Case "tsSeguridad"
                    Me.tsSeguridad.Visible = CBool(dr("habilitado"))
                    Me.tsSeguridad.Enabled = CBool(dr("habilitado"))
                Case "tsCaja"
                    Me.tsCaja.Visible = CBool(dr("habilitado"))
                    Me.tsCaja.Enabled = CBool(dr("habilitado"))
                Case "tsBanco"
                    Me.tsBanco.Visible = CBool(dr("habilitado"))
                    Me.tsBanco.Enabled = CBool(dr("habilitado"))

            End Select

        Next

    End Sub

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
                            FormatCell(row_grid, System.Drawing.Color.LightBlue)
                        ElseIf CBool(row.Item("control_prod_2")) = True And CBool(row.Item("control_2")) = True Then
                            FormatCell(row_grid, System.Drawing.Color.RosyBrown)
                        End If
                    Else
                        'Primer control
                        If CBool(row.Item("control_prod")) = False And CBool(row.Item("control_1")) = False Then
                            'FormatCell(Me.dgvControl.Rows(odt_index), Color.Yellow)
                        ElseIf CBool(row.Item("control_prod")) = True And CBool(row.Item("control_1")) = False Then

                            If CInt(row.Item("id_proveedor")) <> 0 Then
                                FormatCell(row_grid, System.Drawing.Color.Gray)
                            Else
                                FormatCell(row_grid, System.Drawing.Color.LightBlue)
                            End If

                        ElseIf CBool(row.Item("control_prod")) = True And CBool(row.Item("control_1")) = True Then
                            FormatCell(row_grid, System.Drawing.Color.RosyBrown)
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
                        FormatCell(Me.dgvControl.Rows(odt_index), System.Drawing.Color.LightBlue)
                    ElseIf CBool(row.Item("control_prod_2")) = True And CBool(row.Item("control_2")) = True Then
                        FormatCell(Me.dgvControl.Rows(odt_index), System.Drawing.Color.RosyBrown)
                    End If
                Else
                    'Primer control
                    If CBool(row.Item("control_prod")) = False And CBool(row.Item("control_1")) = False Then
                        'FormatCell(Me.dgvControl.Rows(odt_index), Color.Yellow)
                    ElseIf CBool(row.Item("control_prod")) = True And CBool(row.Item("control_1")) = False Then

                        If CInt(row.Item("id_proveedor")) <> 0 Then
                            FormatCell(Me.dgvControl.Rows(odt_index), System.Drawing.Color.Gray)
                        Else
                            FormatCell(Me.dgvControl.Rows(odt_index), System.Drawing.Color.LightBlue)
                        End If

                    ElseIf CBool(row.Item("control_prod")) = True And CBool(row.Item("control_1")) = True Then
                        FormatCell(Me.dgvControl.Rows(odt_index), System.Drawing.Color.RosyBrown)
                    End If
                End If

            End If

        Next
        

        If dgvControl.Rows.Count > 0 And index_pendiente <> 0 Then
            Me.dgvControl.ClearSelection()
            Me.dgvControl.Rows(index_pendiente).Selected = True
        End If

        If Me.dgvControl.Rows.Count > cantidad Then
            mostrarNotificacion("CONTROL: Tiene un nuevo checklist pendiente")
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
                            FormatCell(row_grid, System.Drawing.Color.LightBlue)
                        ElseIf CBool(row.Item("control_prod_2")) = True And CBool(row.Item("control_2")) = True Then
                            FormatCell(row_grid, System.Drawing.Color.RosyBrown)
                        End If
                    Else
                        'Primer control
                        If CBool(row.Item("control_prod")) = False And CBool(row.Item("control_1")) = False Then
                            'FormatCell(Me.dgvControl.Rows(odt_index), Color.Yellow)
                        ElseIf CBool(row.Item("control_prod")) = True And CBool(row.Item("control_1")) = False Then
                            FormatCell(row_grid, System.Drawing.Color.LightBlue)
                        ElseIf CBool(row.Item("control_prod")) = True And CBool(row.Item("control_1")) = True Then
                            FormatCell(row_grid, System.Drawing.Color.RosyBrown)
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

                    If CBool(row.Item("no_conformidad")) = True Then
                        FormatCell(row_grid, System.Drawing.Color.OrangeRed)
                    End If
                    'If CBool(row.Item("pedido_segundo_control")) Then
                    '    If CBool(row.Item("control_prod_2")) = False And CBool(row.Item("control_2")) = False Then

                    '    ElseIf CBool(row.Item("control_prod_2")) = True And CBool(row.Item("control_2")) = False Then
                    '        FormatCell(row_grid, Color.LightBlue)
                    '    ElseIf CBool(row.Item("control_prod_2")) = True And CBool(row.Item("control_2")) = True Then
                    '        FormatCell(row_grid, Color.RosyBrown)
                    '    End If
                    'Else
                    '    'Primer control
                    '    If CBool(row.Item("control_prod")) = False And CBool(row.Item("control_1")) = False Then

                    '    ElseIf CBool(row.Item("control_prod")) = True And CBool(row.Item("control_1")) = False Then
                    '        FormatCell(row_grid, Color.LightBlue)
                    '    ElseIf CBool(row.Item("control_prod")) = True And CBool(row.Item("control_1")) = True Then
                    '        FormatCell(row_grid, Color.RosyBrown)
                    '    End If
                    'End If
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

                If CBool(row.Item("no_conformidad")) = True Then
                    FormatCell(Me.dgvControlesCompletados.Rows(odt_index), System.Drawing.Color.OrangeRed)
                End If
            End If
        Next

        If dgvControlesCompletados.Rows.Count > 0 And index_completado <> 0 Then
            Me.dgvControlesCompletados.ClearSelection()
            Me.dgvControlesCompletados.Rows(index_completado).Selected = True
        End If

    End Sub

    Private Sub FormatCell(ByRef row As DataGridViewRow, ByVal color As System.Drawing.Color)
        For Each cell As DataGridViewCell In row.Cells
            cell.Style.BackColor = color
        Next
    End Sub

    Sub RefrescarLogueo()
        Me.RefrescarGrillaLogueo()

        If vgControlLogueo = True Then
            Me.txtEstadoLogueo.BackColor = System.Drawing.Color.YellowGreen

            Me.txt_proyecto_logueado.Text = Me.dgvLogueo.Rows(0).Cells("nombre_proyecto_login_dgv").Value.ToString()
            Me.txt_subproyecto_logueado.Text = Me.dgvLogueo.Rows(0).Cells("proyecto_login_dgv").Value.ToString()
            Me.txt_actividad_logueado.Text = Me.dgvLogueo.Rows(0).Cells("actividad_login_dgv").Value.ToString()
        Else
            Me.txtEstadoLogueo.BackColor = System.Drawing.Color.Red

            Me.txt_proyecto_logueado.Text = ""
            Me.txt_subproyecto_logueado.Text = ""
            Me.txt_actividad_logueado.Text = ""
        End If

    End Sub

    Sub LoguearUsuario()
        Dim odt As stArbol

        If Me.TreeView1.SelectedNode Is Nothing Then
            Exit Sub
        End If

        odt = CType(TreeView1.SelectedNode.Tag, stArbol)

        If Me.TreeView1.SelectedNode.SelectedImageIndex <> 3 Then
            MessageBox.Show("Debe seleccionar una actividad")
            Exit Sub
        End If

        If odt.id_actividad_proyecto = 0 Then
            MessageBox.Show("Debe seleccionar un proyecto")
            Exit Sub
        End If

        Dim dtHoraLogueo As DateTime

        If opInicio = True Then
            dtHoraLogueo = vgHoraIngreso

            With oMovimiento_hora
                .Cargar()
                .Insertar()
                .fecha = Date.Now
                .id_dia = 1
                .id_usuario = vgCodigoUsuario
                .Guardar()
                vgCodigoMovimientoHora = .id_movimiento_hora
            End With
        Else
            dtHoraLogueo = DateTime.Now
        End If

        opInicio = False

        Dim tabla As New DataTable
        tabla = oCuerpo_movimiento_hora.GetOne_Act(Me.id_cuerpo_movimiento_hora, odt.id_actividad_proyecto) 'GetOne(CInt(Me.lblid_cuerpo_movimiento_hora.Text))

        If tabla.Rows.Count > 0 Then
            vgyalogueado = True
            Exit Sub
        End If

        If Me.id_cuerpo_movimiento_hora = 0 Then
            With oCuerpo_movimiento_hora
                .Cargar()
                .Insertar()
                .entrada = dtHoraLogueo
                .salida = dtHoraLogueo
                .id_actividad_proyecto = odt.id_actividad_proyecto
                .id_movimiento_hora = vgCodigoMovimientoHora
                .id_tipo_logueo = 1
                .Guardar()

                Me.id_cuerpo_movimiento_hora = .id_cuerpo_movimiento_hora
            End With
        Else
            If oCuerpo_movimiento_hora.salida = oCuerpo_movimiento_hora.entrada Then
                With oCuerpo_movimiento_hora
                    .Cargar()
                    .Modificar(Me.id_cuerpo_movimiento_hora)
                    .salida = dtHoraLogueo
                    .Guardar()
                End With
                With oCuerpo_movimiento_hora
                    .Cargar()
                    .Insertar()
                    .entrada = dtHoraLogueo
                    .salida = dtHoraLogueo
                    .id_actividad_proyecto = odt.id_actividad_proyecto
                    .id_movimiento_hora = vgCodigoMovimientoHora
                    .id_tipo_logueo = 1
                    .Guardar()

                    Me.id_cuerpo_movimiento_hora = .id_cuerpo_movimiento_hora
                End With
            Else
                With oCuerpo_movimiento_hora
                    .Cargar()
                    .Insertar()
                    .entrada = dtHoraLogueo
                    .salida = dtHoraLogueo
                    .id_tipo_logueo = 1
                    .id_actividad_proyecto = odt.id_actividad_proyecto
                    .id_movimiento_hora = vgCodigoMovimientoHora
                    .Guardar()

                    Me.id_cuerpo_movimiento_hora = .id_cuerpo_movimiento_hora
                End With
            End If
        End If

        vgControlLogueo = True
        Me.RefrescarLogueo()
        Me.id_proyecto_anotacion = odt.id_proyecto
        Me.CargarListaAnotaciones()

    End Sub

    Private Sub btnLoginProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoginproyecto.Click

        If Me.TreeView1.SelectedNode Is Nothing Then
            Exit Sub
        End If

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''SE COMENTA HASTA QUE SE DESHABILITEN LOS LOGUEOS A ACTIVIDADES SIN CONTROL'''''''
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        'Dim _Actividad_Proyecto As New Actividad_proyecto
        'Dim _Actividad As New Actividad
        'Dim _Tipo_Actividad As New Tipo_actividad
        'Dim odr As stArbol = CType(Me.TreeView1.SelectedNode.Tag, stArbol)

        'With _Actividad_Proyecto
        '    .Cargar()
        '    .Modificar(odr.id_actividad_proyecto)
        'End With

        'With _Actividad
        '    .Cargar()
        '    .Modificar(_Actividad_Proyecto.id_actividad)
        'End With

        'With _Tipo_actividad
        '    .Cargar()
        '    .Modificar(_Actividad.id_tipo_actividad)

        '    If .logueo_habilitado Then
        '    Else
        '        Exit Sub
        '    End If

        'End With

        Me.LoguearUsuario()

        If vgyalogueado Then
            vgyalogueado = False
            Exit Sub
        End If

        Me.Timer2.Start()

    End Sub


    Dim odtProyecto As New DataTable
    Dim odtActividad As New DataTable
    Dim odtActividad_proyecto As New DataTable

    Private Sub TreeView1_BeforeCollapse(sender As Object, e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView1.BeforeCollapse
        Me.TreeView1.SelectedNode = e.Node
    End Sub

    Private Sub treeview1_beforeexpand(sender As Object, e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView1.BeforeExpand
        Me.TreeView1.SelectedNode = e.Node
    End Sub
    Private Sub TreeView1_AfterExpand(sender As Object, e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterExpand
        If Me.TreeView1.SelectedNode.Nodes.Count > 0 Then
            If Me.TreeView1.SelectedNode.Nodes(0).Text = " " Then
                Me.refrescarProyecto()
            End If
        End If
    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect

        Try

            Dim odr As New stArbol
            odr = CType(Me.TreeView1.SelectedNode.Tag, stArbol)

            If odr.tipo = "p" Then
                Me.lblid_proyecto.Text = CStr(odr.id_proyecto)
                Me.lblid_actividad.Text = CStr(Math.Abs(odr.id_actividad))
                Me.lblid_actividad_proyecto.Text = CStr(0)
                Me.lblVariableProyecto.Text = CStr(1)
                vgProyectoSeleccionado = Me.TreeView1.SelectedNode.FullPath

            ElseIf odr.tipo = "a" Then
                Me.lblid_proyecto.Text = CStr(odr.id_proyecto)
                Me.lblid_actividad.Text = CStr(Math.Abs(odr.id_actividad))

                odtProyecto = oProyecto.GetOne(CInt(Me.lblid_proyecto.Text))
                With odtProyecto.Rows(0)
                    vgProyectoSeleccionado = CStr(.Item("path"))
                End With

                odtActividad = oActividad.GetOne(CInt(Me.lblid_actividad.Text))
                With odtActividad.Rows(0)
                    vgProyectoSeleccionado = vgProyectoSeleccionado & "-" & CStr(.Item("nombre_Actividad"))
                End With

                odtActividad_proyecto = oActividad_proyecto.GetOne_1(CInt(Me.lblid_actividad.Text)) '3(CInt(Me.lblid_proyecto.Text), CInt(Me.lblid_actividad.Text))
                With odtActividad_proyecto.Rows(0)
                    Me.lblid_actividad_proyecto.Text = CStr(.Item("id_actividad_proyecto"))
                End With

                Me.lblVariableProyecto.Text = CStr(2)
                vgProyectoSeleccionado = Me.TreeView1.SelectedNode.FullPath

                'Para ver si el boton se habilita para el logueo solo si tiene control
                Dim _Actividad_Proyecto As New Actividad_proyecto
                Dim _Actividad As New Actividad
                Dim _Tipo_Actividad As New Tipo_actividad

                With _Actividad_Proyecto
                    .Cargar()
                    .Modificar(odr.id_actividad_proyecto)
                End With

                With _Actividad
                    .Cargar()
                    .Modificar(_Actividad_Proyecto.id_actividad)
                End With

                Dim _usuario_Proyecto As New Usuario_Proyecto
                If _usuario_Proyecto.EsPMoPiloto(vgCodigoUsuario, odr.id_proyecto) Then
                    Me.btnLoginproyecto.Visible = True
                Else
                    With _Tipo_Actividad
                        .Cargar()
                        .Modificar(_Actividad.id_tipo_actividad)

                        If .logueo_habilitado Then
                            Me.btnLoginproyecto.Visible = True
                        Else
                            Me.btnLoginproyecto.Visible = False
                        End If

                    End With
                End If

            End If

            Try
                Me.lblNodo.Text = CStr(TreeView1.SelectedNode.Parent.Name)
            Catch ex As Exception
                Me.lblNodo.Text = CStr(TreeView1.SelectedNode.Name)
            End Try

            Me.lblNodoSeleccionado.Text = Me.TreeView1.SelectedNode.Name

            Me.Text = vgProyectoSeleccionado

            'Si el usuario logueado es PM - 
            If vgPermisoUsuario = 3 Then
                'Dim odt As New DataTable
                'odt = oVoz.GetAllInicio_2_PM(CInt(Me.lblid_proyecto.Text))

                'Me.dgvControl.DataSource = odt
                'Me.dgvControl.Columns(0).Visible = False
                'Me.dgvControl.DataSource = odt
                'Me.dgvControl.Columns(1).Visible = False
                'Me.dgvControl.DataSource = odt
                'Me.dgvControl.Columns(2).Visible = False
            End If
        Catch ex As Exception

        End Try

    End Sub

    


    Public Function FillChild(ByVal parent As TreeNode, ByVal id_subproyecto As String) As Integer

        'Los proyectos hijos del proyecto
        Dim odr As New stArbol
        Dim odtProy As New DataTable

        Dim odr_parent As New stArbol
        odr_parent = CType(parent.Tag, stArbol)
        If odr_parent.tipo = "p" Then
            odtProy = oSubproyecto.ObtenerPorProyecto(odr_parent.id_proyecto, 1)
        ElseIf odr_parent.tipo = "s" Then
            odtProy = oSubproyecto.ObtenerPorProyecto(0, CInt(id_subproyecto))
        Else
            Return Nothing
            Exit Function
        End If


        Dim x As Integer = 1

        If odtProy.Rows.Count > 0 Then

            For Each dr As DataRow In odtProy.Rows

                If es_admin Then
                    With oSubproyecto
                        .Cargar()
                        .Modificar(CInt(dr("id_subproyecto")))
                        .orden = x
                        .Guardar()
                    End With
                End If

                Dim child As New TreeNode()
                child.Text = dr("nombre").ToString().Trim()

                odr.tipo = "s"
                odr.id_proyecto = CInt(dr("id_proyecto"))
                odr.id_subproyecto = CInt(dr("id_subproyecto"))
                odr.id_actividad = 0
                odr.id_actividad_proyecto = 0
                odr.id_cliente = 0
                odr.icono = 0

                child = parent.Nodes.Add(CStr(dr("id_subproyecto")), CStr(dr("nombre")), parent.ImageIndex)

                child.Tag = odr

                If odtProy.Rows.Count > 0 Then
                    Dim nodof As New TreeNode
                    nodof.Text = " "
                    child.Nodes.Add(nodof)
                End If

                x = x + 2

            Next
            Return 0
        Else
            Return 0
        End If
    End Function

    Public Function FillChild_actividad(ByVal parent As TreeNode, ByVal id_proyecto As String) As Integer

        Dim odr As New stArbol

        Dim odr_parent As New stArbol
        odr_parent = CType(parent.Tag, stArbol)

        Dim odtAct As New DataTable

        If odr_parent.tipo = "s" Then
            odtAct = oActividad_proyecto.GetAllProyecto(0, odr_parent.id_subproyecto, 0)
        ElseIf odr_parent.tipo = "p" Then
            odtAct = oActividad_proyecto.GetAllProyecto(odr_parent.id_proyecto, 0, 0)
        End If


        Dim intIconoActividad As Integer = 0
        Dim intIconoActividadSeleccionado As Integer = 0

        Dim odtTempCont As New DataTable

        If odtAct.Rows.Count > 0 Then

            Dim x As Integer = 1
            For Each dr As DataRow In odtAct.Rows

                If es_admin Then
                    With oActividad_proyecto
                        .Cargar()
                        .Modificar(CInt(dr("id_actividad_proyecto")))
                        .orden = x
                        .Guardar()
                    End With
                End If

                Dim child As New TreeNode()

                Dim odtActividadenProceso As New DataTable
                odtActividadenProceso = oMovimiento_voz.GetActividadProyectoEnProceso(CInt(dr("id_actividad_proyecto")))

                odtTempCont = oMovimiento_voz.GetActividadProyecto(CInt(dr("id_actividad_proyecto")))

                If odtTempCont.Rows.Count > 0 Then
                    odtTempCont = oMovimiento_voz.GetActividadProyectoCompleto(CInt(dr("id_actividad_proyecto")))

                    If odtTempCont.Rows.Count > 0 Then
                        intIconoActividad = 8
                        If odtActividadenProceso.Rows.Count > 0 Then
                            intIconoActividad = 9
                        End If
                    Else
                        intIconoActividad = 6
                    End If

                Else
                    intIconoActividad = 1
                End If

                If CBool(dr("no_conformidad")) = True Then
                    intIconoActividad = 10
                End If

                odr.tipo = "a"
                odr.id_proyecto = CInt(dr("id_proyecto"))
                odr.id_actividad = CInt(dr("id_actividad"))
                odr.id_actividad_proyecto = CInt(dr("id_actividad_proyecto"))
                odr.id_subproyecto = odr_parent.id_subproyecto
                odr.id_cliente = 0
                odr.icono = intIconoActividad
                odr.icono_seleccionado = 3


                child = parent.Nodes.Add(CStr(CDec(dr("id_actividad")) * -1), CStr(dr("nombre_actividad")), intIconoActividad, 3)
                child.Tag = odr

                x = x + 2

            Next
            Return 0
        Else
            Return 0
        End If
    End Function



    Private Sub TreeView1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TreeView1.MouseDown
        Me.TreeView1.SelectedNode = Me.TreeView1.GetNodeAt(e.X, e.Y)


        If Me.TreeView1.SelectedNode IsNot Nothing Then
            Dim odt As stArbol
            odt = CType(Me.TreeView1.SelectedNode.Tag, stArbol)
            If vgControlLogueo = False Then
                Me.id_proyecto_anotacion = odt.id_proyecto
                Me.CargarListaAnotaciones()
            End If
        End If


        Me.lblX.Text = CStr(e.X)
        Me.lblY.Text = CStr(e.Y)

        If e.Button = Windows.Forms.MouseButtons.Right Then


            Me.TreeView1.SelectedNode = Me.TreeView1.GetNodeAt(e.X, e.Y)

            If Me.TreeView1.SelectedNode Is Nothing = False Then

                Me.lblid_proyecto.Text = Me.TreeView1.SelectedNode.Name
                Me.id_proyecto = CType(TreeView1.SelectedNode.Tag, stArbol).id_proyecto
                Me.id_subproyecto = CType(TreeView1.SelectedNode.Tag, stArbol).id_subproyecto
                Me.id_actividad = CType(TreeView1.SelectedNode.Tag, stArbol).id_actividad
                Me.id_actividad_proyecto = CType(TreeView1.SelectedNode.Tag, stArbol).id_actividad_proyecto

                If es_admin Then

                    tsModificarSubproyecto.Visible = True
                    tsSeparator1.Visible = True
                    tsSeparator2.Visible = True
                    ts_borrar_proyecto.Visible = False
                    TseparatorActividad.Visible = False
                    tsAgregarActividad.Visible = False
                    tsBorrarActividad.Visible = False
                    ts_id_proyecto_admin.Visible = True
                    ts_login_admin.Visible = False
                    ts_actualizar_proyecto_admin.Visible = False

                    If CType(Me.TreeView1.SelectedNode.Tag, stArbol).tipo = "s" Then
                        tsBorrarSubproyecto.Visible = True
                        ts_actualizar_proyecto_admin.Enabled = True
                        ts_actualizar_proyecto_admin.Visible = True

                    ElseIf CType(Me.TreeView1.SelectedNode.Tag, stArbol).tipo = "p" Then
                        tsAgregarSubproyecto.Visible = True
                        'MODIFICAR para agregar "agregar subproyectoss"
                        tsAgregarSubproyectos.Visible = False
                        tsBorrarSubproyecto.Visible = False
                        TseparatorActividad.Visible = True
                        tsAgregarActividad.Visible = True
                        ts_borrar_proyecto.Visible = True
                        ts_actualizar_proyecto_admin.Enabled = True
                        ts_actualizar_proyecto_admin.Visible = True
                    Else
                        ts_login_admin.Visible = True
                        ts_login_admin.Enabled = True
                        ts_separador_login_admin.Visible = True
                        TseparatorActividad.Visible = True
                        tsAgregarActividad.Visible = True
                        tsBorrarActividad.Visible = True
                    End If

                    If id_actividad_proyecto <> 0 Then
                        Me.ts_id_proyecto_admin.Text = "ID: " & Me.id_actividad_proyecto
                    ElseIf id_subproyecto <> 0 Then
                        Me.ts_id_proyecto_admin.Text = "ID: " & Me.id_subproyecto
                    ElseIf Me.id_proyecto <> 0 Then
                        Me.ts_id_proyecto_admin.Text = "ID: " & Me.id_proyecto
                    Else
                        Me.ts_id_proyecto_admin.Text = ""
                    End If

                    cmsProyectoAdm.Show(TreeView1, New Point(e.X, e.Y))

                    

                Else
                    Me.banderaclick = 0

                    Try
                        

                        If id_actividad_proyecto <> 0 Then
                            Me.ts_id_proyecto.Text = "ID: " & Me.id_actividad_proyecto
                        ElseIf id_subproyecto <> 0 Then
                            Me.ts_id_proyecto.Text = "ID: " & Me.id_subproyecto
                        ElseIf Me.id_proyecto <> 0 Then
                            Me.ts_id_proyecto.Text = "ID: " & Me.id_proyecto
                        Else
                            Me.ts_id_proyecto.Text = ""
                        End If

                        cmsProyecto.Show(TreeView1, New Point(e.X, e.Y))

                    Catch ex As Exception
                        Me.lblid_proyecto.Text = CStr(0)
                    End Try
                End If

            Else
                If es_admin Then
                    ts_login_admin.Visible = False
                    ts_actualizar_proyecto_admin.Visible = False
                    Me.ts_id_proyecto_admin.Visible = False
                    cmsProyectoAdm.Show(TreeView1, New Point(e.X, e.Y))
                    ts_borrar_proyecto.Visible = False
                    tsBorrarSubproyecto.Visible = False
                    tsAgregarSubproyecto.Visible = False
                    tsAgregarSubproyectos.Visible = False
                    tsModificarSubproyecto.Visible = False
                    tsSeparator1.Visible = False
                    tsSeparator2.Visible = False
                    TseparatorActividad.Visible = False
                    tsAgregarActividad.Visible = False
                    tsBorrarActividad.Visible = False

                End If
                
            End If
        Else
        banderaclick = 1
        End If

    End Sub

    Private Function GetNodeKeyProyecto(ByVal id_subproyecto As Integer, ByVal parentCollection As TreeNodeCollection) As TreeNode
        Dim ret As TreeNode
        Dim child As TreeNode

        For Each child In parentCollection 'step through the parentcollection
            If child.Name <> "" Then
                If CInt(child.Name) = id_subproyecto Then
                    ret = child
                ElseIf child.GetNodeCount(False) > 0 Then ' if there is child items then call this function recursively
                    ret = GetNodeKeyProyecto(id_subproyecto, child.Nodes)
                End If

                If Not ret Is Nothing Then Exit For 'if something was found, exit out of the for loop

            End If

        Next
        Return ret
    End Function


    Private Sub btnNuevoProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.lblBanderaProyecto.Text = CStr(1)
    End Sub

    Private Sub btnModificarProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.lblBanderaProyecto.Text = CStr(2)
    End Sub


    Private Sub LoguearNuevamente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ts_loguearNuevamente.Click


        If dgvLogueo.SelectedRows(0).Index = 0 And vgControlLogueo = False Then
            With oCuerpo_movimiento_hora
                .Cargar()
                .Modificar(CInt(dgvLogueo.SelectedRows(0).Cells("id_cuerpo_movimiento_hora_login_dgv").Value))
                .salida = Date.Now
                .Guardar()
            End With
        ElseIf dgvLogueo.SelectedRows(0).Index <> 0 Then
            With oCuerpo_movimiento_hora
                .Cargar()
                .Insertar()
                .entrada = Date.Now
                .salida = Date.Now
                .id_actividad_proyecto = CInt(dgvLogueo.SelectedRows(0).Cells("id_actividad_proyecto_login_dgv").Value)
                .id_movimiento_hora = CInt(dgvLogueo.SelectedRows(0).Cells("id_movimiento_hora_login_dgv").Value)
                .Guardar()

                Me.id_cuerpo_movimiento_hora = .id_cuerpo_movimiento_hora
                'Me.lblid_cuerpo_movimiento_hora.Text = CStr(.id_cuerpo_movimiento_hora)
            End With


        End If

        vgControlLogueo = True
        Me.RefrescarLogueo()

        'If vgyalogueado Then
        '    vgyalogueado = False
        '    Exit Sub
        'End If

        'If Not Timer2.Enabled Then
        Me.Timer2.Start()
        'End If

        Me.id_proyecto_anotacion = CInt(dgvLogueo.SelectedRows(0).Cells("id_proyecto_dgv_logueo").Value)
        Me.CargarListaAnotaciones()

        'Dim odtDet As New DataTable
        ''Dim odtUser As New DataTable
        'odtDet = oDetalle_recurso.GetOneIngreso(CInt(Me.lblid_actividad_proyecto.Text))
        ''odtUser = oUsuario.GetOne(vgCodigoUsuario)

        'Try
        '    With oDetalle_recurso
        '        .Cargar()
        '        .Modificar(CInt(odtDet.Rows(0).Item(0).ToString))
        '        vgUsuarioAnterior = CInt(.id_usuario)
        '        .id_usuario = vgCodigoUsuario
        '        .Guardar()
        '    End With

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmsProyecto.Opening
        Dim aux As String = ""

        Try
            Dim odr As stArbol = CType(Me.TreeView1.SelectedNode.Tag, stArbol)
            Select Case Me.TreeView1.SelectedNode.SelectedImageIndex
                Case -1

                    Me.lblid_proyecto.Text = Me.TreeView1.SelectedNode.Name
                    Me.lblid_actividad.Text = CStr(0)
                    '------------------------------------------
                    ' menu contextual 19/03         PROYECTO
                    Me.tsSeparator6.Visible = False

                    ' Me.tsSeparator1.Visible = True
                    '  Me.tsSeparator2.Visible = True
                    '  Me.tsSeparator3.Visible = True
                    '  Me.tsModificarProyecto.Visible = True
                    ' Me.tsModificarProyecto.Enabled = True
                    '' Me.tsAgregarProyectoInicial.Visible = True
                    ' Me.tsBorrarProyecto.Visible = True
                    '  Me.tsBorrarProyecto.Enabled = True
                    '' Me.tsAgregarActividad.Visible = True
                    ''   Me.tsAgregarActividad.Enabled = True
                    'Me.tsBorrarActividad.Visible = False
                    '  Me.tsModificarActividad.Visible = False

                    '   Me.tsAgregarProyecto.Visible = True
                    '  Me.tsAgregarProyecto.Enabled = True
                    '  Me.tsPegarEstructura.Visible = True
                    ' Me.tsPegarEstructuraProyectoInicial.Visible = False
                    Me.tsRefrescarProyecto.Visible = True
                    Me.ts_actualizar_proyecto_admin.Visible = True

                    If banderacopiarestructura = 1 Then
                        ' Me.tsPegarEstructura.Enabled = True
                        '  Me.tsPegarEstructuraProyectoInicial.Enabled = True
                        banderacopiarestructura = 0
                    Else
                        '   Me.tsPegarEstructura.Enabled = False
                        ' Me.tsPegarEstructuraProyectoInicial.Enabled = False
                    End If

                    '  Me.tsCopiarEstructura.Visible = True
                    '  Me.tsCopiarEstructura.Enabled = True
                    '  Me.tsPegarProyecto.Visible = True

                    If banderacopiarproyecto = 1 Then
                        '  Me.tsPegarProyecto.Enabled = True
                        banderacopiarproyecto = 0
                    Else
                        '  Me.tsPegarProyecto.Enabled = False
                    End If


                    '  Me.tsCopiarProyecto.Visible = True
                    '  Me.tsCopiarProyecto.Enabled = True
                    ' Me.tsModificarCadista.Visible = False
                    '-------------------------------------------
                Case 3
                    Me.lblid_proyecto.Text = Me.TreeView1.SelectedNode.Parent.Name
                    ' Me.lblid_proyecto.Text = CStr(Me.TreeView1.SelectedNode.Tag)
                    aux = Me.TreeView1.SelectedNode.Name
                    Me.lblid_actividad.Text = CStr(Math.Abs(CDec(aux)))
                    '------------------------------------------
                    'permisos de menu contextual 19/03    ACTIVIDAD
                    Me.tsSeparator6.Visible = True
                    ' Me.tsSeparator5.Visible = True

                    'If oUsuario_permiso.TienePermiso(vgCodigoUsuario, 68) Then
                    '    Me.tsBorrarCtrl.Enabled = True
                    'Else
                    '    Me.tsBorrarCtrl.Enabled = False
                    'End If

                    'Me.tsBorrarCtrl.Visible = True
                    ' Me.tsArchivarProyecto.Visible = False
                    'Me.smOrdenarArbol.Visible = False
                    Me.tsRefrescarProyecto.Visible = False
                    Me.ts_actualizar_proyecto_admin.Visible = False
                    'Me.smOrdenar.Visible = False
                    'Me.tsSeparator1.Visible = False
                    ' Me.tsSeparator2.Visible = False
                    'Me.tsSeparator3.Visible = True
                    'Me.tsSeparator4.Visible = False
                    ' Me.tsModificarProyecto.Visible = False
                    '  Me.tsAgregarProyectoInicial.Visible = False
                    ' Me.tsBorrarProyecto.Visible = False
                    'Me.tsAgregarActividad.Visible = False
                    'Me.tsModificarActividad.Visible = True
                    ' Me.tsModificarActividad.Enabled = True
                    ' Me.tsBorrarActividad.Visible = True
                    ' Me.tsBorrarActividad.Enabled = True
                    'Me.tsAgregarControl.Visible = False 'True
                    'Me.tsAgregarControl.Enabled = False 'True

                    Me.ts_login_actividad.Enabled = True
                    Me.ts_login_actividad.Visible = True
                    Me.tsSeparator_login.Visible = True

                    Me.ts_login_admin.Enabled = True
                    Me.ts_login_admin.Visible = True
                    Me.ts_separador_login_admin.Visible = True

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    '''''''''SE COMENTA HASTA QUE SE DESHABILITEN LOS LOGUEOS A ACTIVIDADES SIN CONTROL'''''''
                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                    Dim _Actividad_Proyecto As New Actividad_proyecto
                    Dim _Actividad As New Actividad
                    Dim _Tipo_actividad As New Tipo_actividad

                    With _Actividad_Proyecto
                        .Cargar()
                        .Modificar(odr.id_actividad_proyecto)
                    End With

                    With _Actividad
                        .Cargar()
                        .Modificar(_Actividad_Proyecto.id_actividad)
                    End With

                    With _Tipo_actividad
                        .Cargar()
                        .Modificar(_Actividad.id_tipo_actividad)

                        If .logueo_habilitado Then
                            Me.ts_login_actividad.Enabled = True
                            Me.ts_login_actividad.Visible = True
                            Me.tsSeparator_login.Visible = True

                            Me.ts_login_admin.Enabled = True
                            Me.ts_login_admin.Visible = True
                            Me.ts_separador_login_admin.Visible = True
                        Else
                            Me.ts_login_actividad.Enabled = False
                            Me.ts_login_actividad.Visible = False
                            Me.tsSeparator_login.Visible = False

                            Me.ts_login_admin.Enabled = False
                            Me.ts_login_admin.Visible = False
                            Me.ts_separador_login_admin.Visible = False
                        End If

                    End With

                    Dim _usuario_Proyecto As New Usuario_Proyecto
                    If _usuario_Proyecto.EsPMoPiloto(vgCodigoUsuario, odr.id_proyecto) Then
                        Me.ts_login_actividad.Enabled = True
                        Me.ts_login_actividad.Visible = True
                        Me.tsSeparator_login.Visible = True

                        Me.ts_login_admin.Enabled = True
                        Me.ts_login_admin.Visible = True
                        Me.ts_separador_login_admin.Visible = True
                    End If




                    '  Me.tsAgregarProyecto.Visible = False
                    '  Me.tsPegarEstructura.Visible = False
                    '  Me.tsCopiarEstructura.Visible = False
                    '  Me.tsPegarEstructuraProyectoInicial.Visible = False
                    ' Me.tsPegarProyecto.Visible = False
                    ' Me.tsCopiarProyecto.Visible = False
                    ' Me.tsModificarCadista.Visible = True
                    '-------------------------------------------



                    'Para Subproyecto
                    'odtActividad_proyecto = oActividad_proyecto.GetOne_3(CInt(Me.lblid_proyecto.Text), Math.Abs(CInt(Me.lblid_actividad.Text)))
                    'With odtActividad_precto.Rows(0)
                    '    Me.lblid_actividad_proyecto.Text = CStr(.Item("id_actividad_proyecto"))
                    'End With

                    'Para Subproyecto
                    odtActividad_proyecto = oActividad_proyecto.GetOne(CType(TreeView1.SelectedNode.Tag, stArbol).id_actividad_proyecto)
                    With odtActividad_proyecto.Rows(0)
                        Me.lblid_actividad_proyecto.Text = CStr(.Item("id actividad proyecto"))
                    End With

                    Dim id_path As Integer = 0
                    Dim nom_path As String = ""
                    id_path = CInt(Me.lblid_proyecto.Text)

                    Dim odtProy As New DataTable
                    odtProy = oProyecto.GetTree_2(CInt(id_path))

                    Me.lblVariableProyecto.Text = CStr(2)


                Case Else

                    If Me.TreeView1.SelectedNode.ImageIndex = 0 Then
                        Me.TreeView1.SelectedNode.SelectedImageIndex = -1
                        Me.lblid_proyecto.Text = Me.TreeView1.SelectedNode.Name
                        Me.lblid_actividad.Text = CStr(0)
                        '------------------------------------------
                        ' permisos de menu contextual 19/03 PROYECTO
                        Me.tsSeparator6.Visible = True

                        Me.tsRefrescarProyecto.Visible = False
                        Me.ts_actualizar_proyecto_admin.Visible = False
                        ' Me.tsModificarProyecto.Visible = True
                        ' Me.tsModificarProyecto.Enabled = True
                        ' Me.tsAgregarProyectoInicial.Visible = False
                        ' Me.tsBorrarProyecto.Visible = True
                        ' Me.tsBorrarProyecto.Enabled = True
                        ' Me.tsAgregarActividad.Visible = True
                        '' Me.tsAgregarActividad.Enabled = True
                        ' Me.tsBorrarActividad.Visible = False
                        ' Me.tsModificarActividad.Visible = False

                        'Me.tsAgregarProyecto.Visible = True
                        ' Me.tsAgregarProyecto.Enabled = True
                        ' Me.tsPegarEstructura.Visible = True
                        ' Me.tsPegarEstructuraProyectoInicial.Visible = False

                        Me.ts_login_actividad.Enabled = False
                        Me.ts_login_actividad.Visible = False
                        Me.tsSeparator_login.Visible = False

                        Me.ts_login_admin.Enabled = False
                        Me.ts_login_admin.Visible = False
                        Me.ts_separador_login_admin.Visible = False

                        If banderacopiarestructura = 1 Then
                            ' Me.tsPegarEstructura.Enabled = True
                            ' Me.tsPegarEstructuraProyectoInicial.Enabled = True
                            banderacopiarestructura = 0
                        Else
                            ' Me.tsPegarEstructura.Enabled = False
                            ' Me.tsPegarEstructuraProyectoInicial.Enabled = False
                        End If

                        ' Me.tsCopiarEstructura.Visible = True
                        ' Me.tsCopiarEstructura.Enabled = True
                        'Me.tsPegarProyecto.Visible = True

                        If banderacopiarproyecto = 1 Then
                            ' Me.tsPegarProyecto.Enabled = True
                            banderacopiarproyecto = 0
                        Else
                            'Me.tsPegarProyecto.Enabled = False
                        End If

                        ' Me.tsCopiarProyecto.Visible = True
                        'Me.tsCopiarProyecto.Enabled = True
                        ' Me.tsModificarCadista.Visible = False
                    End If
            End Select

            Try
                Me.lblNodo.Text = CStr(TreeView1.SelectedNode.Parent.Name)
            Catch ex As Exception
                Me.lblNodo.Text = Me.lblid_proyecto.Text 'CStr(TreeView1.SelectedNode.Name)
            End Try
        Catch                                           'NADA
            Me.tsSeparator6.Visible = False

            Me.tsRefrescarProyecto.Visible = False
            Me.ts_actualizar_proyecto_admin.Visible = False
            '' Me.tsAgregarProyectoInicial.Visible = True
            ' Me.tsAgregarProyectoInicial.Enabled = True
            ' Me.tsModificarProyecto.Visible = False
            ' Me.tsBorrarProyecto.Visible = False
            'Me.tsAgregarActividad.Visible = False
            ' Me.tsModificarActividad.Visible = False
            ' Me.tsBorrarActividad.Visible = False
            '  Me.tsAgregarProyecto.Visible = False
            '  Me.tsPegarEstructura.Visible = False
            '  Me.tsCopiarEstructura.Visible = False
            '  Me.tsPegarEstructuraProyectoInicial.Visible = True
            If banderacopiarestructura = 1 Then
                '  Me.tsPegarEstructura.Enabled = True
                '  Me.tsPegarEstructuraProyectoInicial.Enabled = True
                'banderacopiarestructura = 0
            Else
                ' Me.tsPegarEstructura.Enabled = False
                '  Me.tsPegarEstructuraProyectoInicial.Enabled = False
            End If
            Me.ts_login_actividad.Enabled = False
            Me.ts_login_actividad.Visible = False
            Me.tsSeparator_login.Visible = False

            Me.ts_login_admin.Enabled = False
            Me.ts_login_admin.Visible = False
            Me.ts_separador_login_admin.Visible = False

            'Me.tsPegarEstructura.Enabled = False
            'Me.tsPegarEstructuraProyectoInicial.Enabled = False
            'End If
            '  Me.tsPegarProyecto.Visible = False
            '  Me.tsCopiarProyecto.Visible = False
            '  Me.tsModificarCadista.Visible = False
            '  Me.tsAsignarRecurso.Enabled = True
        End Try


    End Sub

    Private Sub LoginActividadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ts_login_actividad.Click, ts_login_admin.Click

        If Me.TreeView1.SelectedNode Is Nothing Then
            Exit Sub
        End If

        Me.LoguearUsuario()

        If vgyalogueado Then
            vgyalogueado = False
            Exit Sub
        End If

        Me.Timer2.Start()

        Dim odtDet As New DataTable
        odtDet = oDetalle_recurso.GetOneIngreso(CType(Me.TreeView1.SelectedNode.Tag, stArbol).id_actividad_proyecto)

        Try
            With oDetalle_recurso
                .Cargar()
                .Modificar(CInt(odtDet.Rows(0).Item(0).ToString))
                vgUsuarioAnterior = CInt(.id_usuario)
                .id_usuario = vgCodigoUsuario
                .Guardar()
            End With

        Catch ex As Exception

        End Try
    End Sub

    Private Sub AdministrarProyectoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If CType(TreeView1.SelectedNode.Tag, stArbol).tipo = "p" Then
            Dim frm As New frmAdministrarSubproyectos(CType(TreeView1.SelectedNode.Tag, stArbol).id_proyecto, CType(TreeView1.SelectedNode.Tag, stArbol).tipo)
            frm.Show()
        ElseIf CType(TreeView1.SelectedNode.Tag, stArbol).tipo = "s" Then
            Dim frm As New frmAdministrarSubproyectos(CType(TreeView1.SelectedNode.Tag, stArbol).id_subproyecto, CType(TreeView1.SelectedNode.Tag, stArbol).tipo)
            frm.Show()
        ElseIf CType(TreeView1.SelectedNode.Tag, stArbol).tipo = "a" Then
            Dim frm As New frmAdministrarSubproyectos(CType(TreeView1.SelectedNode.Tag, stArbol).id_actividad_proyecto, CType(TreeView1.SelectedNode.Tag, stArbol).tipo)
            frm.Show()
        End If


    End Sub


    Private Sub AgregarControlToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim odtTempCont As New DataTable
        Dim nd As New TreeNode
        nd = Me.TreeView1.SelectedNode

        'El movimiento_voz de ese actividad_proyecto
        odtTempCont = oMovimiento_voz.GetActividadProyecto(CInt(Me.lblid_actividad_proyecto.Text))
        If odtTempCont.Rows.Count > 0 Then
            MessageBox.Show("La actividad ya posee un control asignado")

            odtTempCont = oMovimiento_voz.GetActividadProyectoPrimerControl(CInt(Me.lblid_actividad_proyecto.Text))
            If odtTempCont.Rows.Count > 0 Then
                MessageBox.Show("El primer control de la actividad ya fue realizada")
            End If
            Exit Sub
        ElseIf lblid_actividad.Text = CStr(0) Then
            Exit Sub
        End If

        Dim frmTemp As New frmAgregarControlPM(CInt(Me.lblid_actividad_proyecto.Text))

        Me.AddOwnedForm(frmTemp)
        frmTemp.ShowDialog()

        If vgbanderacontrol = True Then

            Me.TreeView1.SelectedNode.ImageIndex = 8

            Dim odtUsuario As New DataTable
            odtUsuario = oUsuario.ConsultarTodo

            Try
                For Each row As DataRow In odtUsuario.Rows

                    If vgCodigoUsuario <> CInt(row("id usuario")) Then
                        With oModificacion_arbol
                            .Cargar()
                            .Insertar()
                            .id_actividad = Math.Abs(CInt(Me.lblid_actividad.Text))
                            .id_actividad_proyecto = CInt(Me.lblid_actividad_proyecto.Text)
                            .id_proyecto = CInt(Me.lblid_proyecto.Text)
                            .id_usuario = CInt(row("id usuario"))
                            .nodo = Me.TreeView1.SelectedNode.Index
                            .nodo_padre = CDec(Me.TreeView1.SelectedNode.Name)
                            .nombre_modificacion_arbol = "tsAgregarControl"
                            .realizado = False
                            .tipo_nodo = "a"
                            .Guardar()
                        End With
                    End If

                Next
            Catch ex As Exception
            End Try

            vgbanderacontrol = False
        End If
        Try
            Me.RefrescarControl()
            For Each row As DataGridViewRow In dgvControl.Rows
                If row.Cells("id_movimiento_voz").Value.ToString() = frmTemp.lblid_movimiento_voz.Text Then
                    dgvControl.Rows(dgvControl.Rows.IndexOf(row)).Selected = True
                    Exit For
                End If
            Next

        Catch ex As Exception

        End Try

        Me.TreeView1.SelectedNode = nd
    End Sub

    '' Logueo para un control - id_tipo_logueo = 2
    Sub LoguearControl(ByVal id_actividad_proyecto As Integer)
        Dim dtHoraLogueo As DateTime

        If opInicio = True Then
            dtHoraLogueo = vgHoraIngreso

            With oMovimiento_hora
                .Cargar()
                .Insertar()
                .fecha = Date.Now
                .id_dia = 1
                .id_usuario = vgCodigoUsuario
                .Guardar()

                vgCodigoMovimientoHora = .id_movimiento_hora
            End With
        Else
            dtHoraLogueo = DateTime.Now
        End If

        opInicio = False

        Dim tabla As New DataTable
        tabla = oCuerpo_movimiento_hora.GetOne_Act(Me.id_cuerpo_movimiento_hora, id_actividad_proyecto)
        If tabla.Rows.Count > 0 Then
            vgyalogueado = True
            vgControlLogueo = True
            Me.RefrescarLogueo()
            Exit Sub
        End If


        If Me.id_cuerpo_movimiento_hora = 0 Then
            With oCuerpo_movimiento_hora
                .Cargar()
                .Insertar()
                .entrada = dtHoraLogueo
                .salida = dtHoraLogueo
                .id_tipo_logueo = 2
                .id_actividad_proyecto = id_actividad_proyecto
                .id_movimiento_hora = vgCodigoMovimientoHora
                .Guardar()

                Me.id_cuerpo_movimiento_hora = .id_cuerpo_movimiento_hora
            End With
        Else
            If oCuerpo_movimiento_hora.salida = oCuerpo_movimiento_hora.entrada Then
                With oCuerpo_movimiento_hora
                    .Cargar()
                    .Modificar(Me.id_cuerpo_movimiento_hora)
                    .salida = dtHoraLogueo
                    .Guardar()
                End With
                With oCuerpo_movimiento_hora
                    .Cargar()
                    .Insertar()
                    .entrada = dtHoraLogueo
                    .salida = dtHoraLogueo
                    .id_tipo_logueo = 2
                    .id_actividad_proyecto = id_actividad_proyecto
                    .id_movimiento_hora = vgCodigoMovimientoHora
                    .Guardar()

                    Me.id_cuerpo_movimiento_hora = .id_cuerpo_movimiento_hora
                End With
            Else
                With oCuerpo_movimiento_hora
                    .Cargar()
                    .Insertar()
                    .entrada = dtHoraLogueo
                    .salida = dtHoraLogueo
                    .id_tipo_logueo = 2
                    .id_actividad_proyecto = id_actividad_proyecto
                    .id_movimiento_hora = vgCodigoMovimientoHora
                    .Guardar()

                    Me.id_cuerpo_movimiento_hora = .id_cuerpo_movimiento_hora
                End With
            End If
        End If

        If vgyalogueado Then
            vgyalogueado = False
            Exit Sub
        End If

        Me.Timer2.Start()

        Dim _Actividad_Proyecto As New Actividad_proyecto
        With _Actividad_Proyecto
            .Cargar()
            .Modificar(id_actividad_proyecto)
        End With

        Me.id_proyecto_anotacion = _Actividad_Proyecto.id_proyecto
        Me.CargarListaAnotaciones()

        vgControlLogueo = True
        Me.RefrescarLogueo()
    End Sub

    Private Sub btnRealizarControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRealizarControl.Click

        If Me.dgvControl.SelectedRows.Count > 0 Then
            Me.RealizarControl(CInt(Me.dgvControl.SelectedRows(0).Cells("id_movimiento_voz_dgv").Value), 0)
        End If

    End Sub

    'Cuando el usuario hace click en una fila de controles
    Private Sub dgvControl_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvControl.CurrentCellChanged

        'Try
        '    Me.lblid_pk.Text = CStr(CType(sender, DataGridView).Item(0, CType(sender, DataGridView).CurrentRow.Index).Value)
        '    Me.lblid_pk_proyecto.Text = CStr(CType(sender, DataGridView).Item("id_proyecto", CType(sender, DataGridView).CurrentRow.Index).Value)
        '    Me.lblid_pk_actividad.Text = CStr(CType(sender, DataGridView).Item("id_actividad", CType(sender, DataGridView).CurrentRow.Index).Value)
        '    Me.lblid_control.Text = CStr(CType(sender, DataGridView).Item("id_control", CType(sender, DataGridView).CurrentRow.Index).Value)
        '    Me.lblid_movimiento_voz.Text = CStr(CType(sender, DataGridView).Item("id_movimiento_voz", CType(sender, DataGridView).CurrentRow.Index).Value)
        '    Me.lblid_actividad_proyecto.Text = CStr(CType(sender, DataGridView).Item("id_actividad_proyecto", CType(sender, DataGridView).CurrentRow.Index).Value)

        '    Me.chkP.Checked = CBool(CType(sender, DataGridView).Item("P1", CType(sender, DataGridView).CurrentRow.Index).Value)
        '    Me.chk1.Checked = CBool(CType(sender, DataGridView).Item("1", CType(sender, DataGridView).CurrentRow.Index).Value)
        '    Me.chk2.Checked = CBool(CType(sender, DataGridView).Item("2", CType(sender, DataGridView).CurrentRow.Index).Value)
        '    Dim chkP2 As Boolean = CBool(CType(sender, DataGridView).Item("P2", CType(sender, DataGridView).CurrentRow.Index).Value)

        '    'Setea la variable global vGNumeroControl, que indica en que etapa del control se encuentra

        '    If CBool(CType(sender, DataGridView).Item("P1", CType(sender, DataGridView).CurrentRow.Index).Value) = False Then
        '        vgNumeroControl = 1 'Control del cadista
        '    ElseIf Me.chkP.Checked = True And Me.chk1.Checked = False And Me.chk2.Checked = False Then
        '        vgNumeroControl = 2 'Primer control
        '    ElseIf Me.chkP.Checked = True And Me.chk1.Checked = True And Me.chk2.Checked = False And chkP2 = False Then
        '        If CBool(CType(sender, DataGridView).Item("P2C", CType(sender, DataGridView).CurrentRow.Index).Value) = True Then
        '            vgNumeroControl = 4 ' El cadista tiene que hacer el checklist de nuevo
        '        Else
        '            vgNumeroControl = 3 'El cadista tiene que corregir el primer control, no se hizo pedido de 2do control
        '        End If
        '    ElseIf Me.chkP.Checked = True And Me.chk1.Checked = True And Me.chk2.Checked = False And chkP2 = True Then
        '        vgNumeroControl = 5 'El controlador tiene que corregir el nuevo control
        '    ElseIf Me.chkP.Checked = True And Me.chk1.Checked = True And Me.chk2.Checked = True And chkP2 = True Then
        '        vgNumeroControl = 6 'El cadista tiene que corregir el 2do control
        '    End If

        '    cmb_cliente.SelectedValue = CInt(oProyecto.ObtenerClienteProyecto(CInt(Me.lblid_pk_proyecto.Text)).Rows(0).Item("id_proyecto"))
        '    buscarNodo(CInt(Me.lblid_actividad_proyecto.Text))

        '    '    Dim nodo As TreeNode
        '    '    Dim tvn() As TreeNode
        '    '    If CType(sender, DataGridView).Focus Then
        '    '        Dim tabla As New DataTable
        '    '        tabla = oProyecto.GetOne_2(CInt(Me.lblid_pk_proyecto.Text))

        '    '        Dim arr() As Integer
        '    '        ReDim arr(0)
        '    '        arr(0) = CInt(tabla.Rows(0).Item("Id_proyecto"))
        '    '        Dim padre As Integer = CInt(tabla.Rows(0).Item("Id_proyecto_padre"))
        '    '        Dim b As Boolean = True

        '    '        If padre = 1 Then
        '    '            If CBool(tabla.Rows(0).Item("archivado")) = True Then
        '    '                b = False
        '    '            End If
        '    '        End If

        '    '        While padre <> 1
        '    '            ReDim Preserve arr(UBound(arr) + 1)
        '    '            tabla = oProyecto.GetOne_2(padre)
        '    '            padre = CInt(tabla.Rows(0).Item("Id_proyecto_padre"))
        '    '            arr(UBound(arr)) = CInt(tabla.Rows(0).Item("Id_proyecto"))
        '    '            If CBool(tabla.Rows(0).Item("archivado")) = True Then
        '    '                b = False
        '    '                Exit While
        '    '            End If
        '    '        End While

        '    '        While b
        '    '            Dim proy As Integer
        '    '            tvn = Me.TreeView1.Nodes.Find(CStr(lblid_pk_proyecto.Text), True)

        '    '            If tvn.Length = 0 Then

        '    '                proy = CInt(tabla.Rows(0).Item("Id_proyecto"))
        '    '                nodo = TreeView1.SelectedNode 'nodo le asigno algo solo para q tome el valor q adquiere en for

        '    '                Try
        '    '                    For index As Integer = 0 To arr.Count - 1
        '    '                        tvn = Me.TreeView1.Nodes.Find(CStr(arr(index)), True)
        '    '                        If tvn.Length > 0 Then
        '    '                            For indice As Integer = index To 0 Step -1

        '    '                                Me.TreeView1.SelectedNode = Me.TreeView1.Nodes.Find(CStr(arr(indice)), True)(0)
        '    '                                nodo = Me.TreeView1.SelectedNode 'Next

        '    '                                refrescarProyecto()

        '    '                            Next
        '    '                            Exit For
        '    '                        End If
        '    '                    Next
        '    '                Catch ex As Exception

        '    '                End Try


        '    '            Else
        '    '                Dim nd() As TreeNode = Me.TreeView1.Nodes.Find("-" & Me.lblid_pk_actividad.Text, True)
        '    '                If nd.Length = 0 Then
        '    '                    Me.TreeView1.SelectedNode = tvn(0)
        '    '                    refrescarProyecto()

        '    '                End If

        '    '            End If

        '    '            nodo = GetNodeKeyProyecto(CInt("-" & Me.lblid_pk_actividad.Text), TreeView1.Nodes)
        '    '            If nodo IsNot Nothing Then
        '    '                b = False
        '    '            End If
        '    '        End While
        '    '    End If

        '    '    TreeView1.SelectedNode = GetNodeKeyProyecto(CInt("-" & Me.lblid_pk_actividad.Text), TreeView1.Nodes)

        '    '    If TreeView1.SelectedNode.SelectedImageIndex = (0 Or -1) Then
        '    '        Me.TreeView1.SelectedNode = Me.TreeView1.Nodes.Find("-" & Me.lblid_pk_actividad.Text, True)(0)
        '    '    End If
        '    '    TreeView1.Select()
        'Catch ex As Exception

        'End Try
    End Sub


    'Private Sub tsmiPegarProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsPegarProyecto.Click
    '    Dim odt As New DataTable
    '    odt = oProyecto.GetOne(CInt(Me.lblid_proyecto.Text))

    '    Dim odtCopia As New DataTable
    '    odtCopia = oProyecto.GetOne(CInt(Me.lblid_proyecto_copia.Text))

    '    With oProyecto
    '        .Cargar()
    '        .Insertar()
    '        .descripcion = CStr(odtCopia.Rows(0).Item("descripcion")) & "_1"
    '        .nombre_proyecto = CStr(odtCopia.Rows(0).Item("nombre proyecto")) & "_1"
    '        .id_cliente = CInt(odt.Rows(0).Item("id cliente"))
    '        .id_proyecto_padre = CInt(Me.lblid_proyecto.Text) 'CInt(odt.Rows(0).Item("id_proyecto_padre"))
    '        .id_proyect_manager = CInt(odt.Rows(0).Item("id proyect manager"))
    '        .fecha_inicio = CDate(odt.Rows(0).Item("fecha inicio"))
    '        .fecha_fin_prevista = CDate(odt.Rows(0).Item("fecha fin prevista"))
    '        .fecha_fin_real = CDate(odt.Rows(0).Item("fecha fin real"))
    '        .orden = CStr(odt.Rows(0).Item("orden"))
    '        .id_estado = CInt(odt.Rows(0).Item("id estado"))
    '        .total_hora = CDec(odt.Rows(0).Item("total hora"))
    '        .prioridad = CDec(odt.Rows(0).Item("prioridad"))
    '        .observacion = CStr(odt.Rows(0).Item("observacion"))
    '        .id_controlador_1 = CInt(odt.Rows(0).Item("id controlador 1"))
    '        .id_controlador_2 = CInt(odt.Rows(0).Item("id controlador 2"))
    '        .path = vgProyectoSeleccionado
    '        .Guardar()
    '    End With

    '    Dim tab As New DataTable
    '    tab = oUsuario.ConsultarTodo

    '    For Each row As DataRow In tab.Rows
    '        With oModificacion_arbol
    '            .Cargar()
    '            .Insertar()
    '            .id_proyecto = CInt(Me.lblid_proyecto.Text)
    '            .id_usuario = CInt(row("id usuario"))
    '            .nodo_padre = CDec(Me.TreeView1.SelectedNode.Name)
    '            .nombre_modificacion_arbol = "tsPegarProyecto"
    '            .realizado = False
    '            .tipo_nodo = "p"
    '            .Guardar()
    '        End With
    '    Next
    '    Me.refrescarProyecto()
    'End Sub


    'Private Sub tsmiAgregarActividad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsAgregarActividad.Click

    '    Dim odtAct As New DataTable
    '    odtAct = oActividad.GetOne(CInt(Me.lblid_actividad.Text))
    '    Dim odtProy As New DataTable
    '    odtProy = oProyecto.GetOne(CInt(Me.lblid_proyecto.Text))
    '    Dim n As Integer
    '    Dim str As String

    '    Dim rowAct As DataRow

    '    If odtAct.Rows.Count > 0 Then
    '        rowAct = odtAct.Rows(0)

    '        Dim odtAP As New DataTable
    '        odtAP = oActividad_proyecto.GetMaxOrden(CInt(Me.lblid_proyecto.Text))

    '        Me.txtOrden.Text = CStr(CDec(odtAP.Rows(0).Item("orden")) + 1)

    '        With oActividad
    '            .Cargar()
    '            .Insertar()
    '            .nombre_actividad = CStr(rowAct.Item("nombre_actividad")) & "_1"
    '            .id_tipo_actividad = CInt(rowAct.Item("id_tipo_actividad"))
    '            .tiempo_standart = CDec(rowAct.Item("tiempo_standart"))
    '            .Guardar()
    '            Me.lblid_actividad.Text = CStr(.id_actividad)
    '        End With

    '        Dim odtUsuario As New DataTable
    '        odtUsuario = oUsuario.GetCmbPM

    '        With oActividad_proyecto
    '            .Cargar()
    '            .Insertar()
    '            .id_actividad = CInt(Me.lblid_actividad.Text)
    '            .id_proyecto = CInt(Me.lblid_proyecto.Text)
    '            .orden = CDec(Me.txtOrden.Text)

    '            If odtProy.Rows.Count > 0 Then
    '                .id_controlador_1 = CInt(odtProy.Rows(0).Item("id_controlador_1"))
    '                .id_controlador_2 = CInt(odtProy.Rows(0).Item("id_controlador_2"))
    '            Else
    '                If odtUsuario.Rows.Count > 0 Then
    '                    .id_controlador_1 = CInt(odtUsuario.Rows(0).Item("id_usuario"))
    '                    .id_controlador_2 = CInt(odtUsuario.Rows(0).Item("id_usuario"))
    '                Else
    '                    .id_controlador_1 = 1
    '                    .id_controlador_2 = 1
    '                End If
    '            End If
    '            .Guardar()
    '            Me.lblid_actividad_proyecto.Text = CStr(.id_actividad_proyecto)
    '        End With
    '    Else
    '        Dim odtUsuario As New DataTable
    '        odtUsuario = oUsuario.GetCmbPM

    '        With oActividad
    '            .Cargar()
    '            .Insertar()
    '            .nombre_actividad = "Nueva Actividad"
    '            .id_tipo_actividad = 1
    '            .tiempo_standart = 1
    '            str = CStr(.nombre_actividad)
    '            Dim tabla, tabla1 As New DataTable
    '            tabla = oActividad.GetAllExiste2(CInt(odtProy.Rows(0).Item("Id proyecto")), str)

    '            If tabla.Rows.Count > 0 Then
    '                For i As Integer = 1 To tabla.Rows.Count
    '                    tabla1 = oActividad.GetAllExiste2(CInt(odtProy.Rows(0).Item("id proyecto")), str & "_" & i)
    '                    If tabla1.Rows.Count = 0 Then
    '                        n = i
    '                        Exit For
    '                    End If
    '                Next
    '                If n <> 0 Then

    '                    .nombre_actividad = str & "_" & n
    '                Else
    '                    .nombre_actividad = str & "_" & tabla.Rows.Count + 1
    '                End If
    '            Else

    '                .nombre_actividad = str & "_1"
    '            End If

    '            .Guardar()
    '            Me.lblid_actividad.Text = CStr(.id_actividad)

    '        End With

    '        Dim odt As New DataTable
    '        odt = oActividad_proyecto.GetOne_4(CInt(Me.lblid_proyecto.Text))

    '        With oActividad_proyecto
    '            .Cargar()
    '            .Insertar()
    '            .id_actividad = CInt(Me.lblid_actividad.Text)
    '            .id_proyecto = CInt(Me.lblid_proyecto.Text)

    '            If odtProy.Rows.Count > 0 Then
    '                .id_controlador_1 = CInt(odtProy.Rows(0).Item("Id controlador 1"))
    '                .id_controlador_2 = CInt(odtProy.Rows(0).Item("Id controlador 2"))
    '            Else
    '                If odtUsuario.Rows.Count > 0 Then
    '                    .id_controlador_1 = CInt(odtUsuario.Rows(0).Item("id_usuario"))
    '                    .id_controlador_2 = CInt(odtUsuario.Rows(0).Item("id_usuario"))
    '                Else
    '                    .id_controlador_1 = 1
    '                    .id_controlador_2 = 1
    '                End If
    '            End If

    '            If odt.Rows.Count > 0 Then
    '                .orden = odt.Rows.Count + 1
    '            Else
    '                .orden = 1
    '            End If

    '            .Guardar()
    '            Me.lblid_actividad_proyecto.Text = CStr(.id_actividad_proyecto)
    '        End With
    '    End If

    '    Dim frmDetalle As New frmDetalleActividad

    '    If Not IsNumeric(Me.lblid_actividad.Text) Then
    '        Exit Sub
    '    End If

    '    BanderaActividad = 2
    '    Me.AddOwnedForm(frmDetalle)
    '    oActividad.Modificar(CInt(Me.lblid_actividad.Text))
    '    frmDetalle.CargarCombos()
    '    frmDetalle.ShowDialog()

    '    If vgbanderactividad = True Then
    '        TreeView1.SelectedNode.Nodes.Add(CStr(CDec(Me.lblid_actividad.Text) * -1), CStr(oActividad.nombre_actividad), 1, 3)

    '        Dim odr As New stArbol

    '        odr.tipo = "a"
    '        odr.id_proyecto = CInt(Me.lblid_proyecto.Text)
    '        odr.id_actividad = CInt(Me.lblid_actividad.Text)
    '        odr.icono = 1
    '        odr.icono_seleccionado = 3

    '        TreeView1.SelectedNode.Tag = odr

    '        vgbanderactividad = False
    '    Else
    '        oActividad.Borrar(CInt(Me.lblid_actividad.Text))
    '        Me.lblNodoSeleccionado.Text = Me.lblid_proyecto.Text

    '    End If

    '    Dim tab As New DataTable
    '    tab = oUsuario.ConsultarTodo

    '    For Each row As DataRow In tab.Rows
    '        With oModificacion_arbol
    '            .Cargar()
    '            .Insertar()
    '            .id_actividad = Math.Abs(CInt(Me.lblid_actividad.Text))
    '            .id_actividad_proyecto = CInt(Me.lblid_actividad_proyecto.Text)
    '            .id_proyecto = CInt(Me.lblid_proyecto.Text)
    '            .id_usuario = CInt(row("id usuario"))
    '            .nodo = Me.TreeView1.SelectedNode.Index
    '            .nodo_padre = CDec(Me.TreeView1.SelectedNode.Name)
    '            .nombre_modificacion_arbol = "tsAgregarActividad"
    '            .realizado = False
    '            .tipo_nodo = "a"
    '            .Guardar()
    '        End With
    '    Next
    'End Sub





    Private Sub AdministrarToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsAdministrarSeguridad.Click
        Dim frmTemp As New frmSeguridad
        frmTemp.ShowDialog()
    End Sub

    'Private Sub tsAdministrarControl_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsAdministrarControles.Click

    '    If CType(TreeView1.SelectedNode.Tag, stArbol).tipo = "s" Then
    '        Dim _Subpro As New entSubproyecto
    '        With _Subpro
    '            .Cargar()
    '            .Modificar(CType(TreeView1.SelectedNode.Tag, stArbol).id_subproyecto)
    '        End With

    '        Dim frmTemp As New frmAdministrarControles(_Subpro)
    '        frmTemp.ShowDialog()

    '    ElseIf CType(TreeView1.SelectedNode.Tag, stArbol).tipo = "p" Then
    '        Dim _Proyecto As New Proyecto

    '        With _Proyecto
    '            .Cargar()
    '            .Modificar(CType(TreeView1.SelectedNode.Tag, stArbol).id_proyecto)
    '        End With

    '        Dim frmTemp As New frmAdministrarControles(_Proyecto)
    '        frmTemp.ShowDialog()
    '    End If

    'End Sub


    Private Sub ReordenarVocesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsReordenarVoz.Click
        oVoz.UpdateRandom()
        MessageBox.Show("El orden aleatoreo de las voces ha cambiado correctamente")
    End Sub

    Private Sub Calendario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsAdministrarHora.Click
        'Dim frmTemp As New frmAbmCalendario
        'frmTemp.ShowDialog()

        Dim frmTemp As New frmCalendarioAnual
        frmTemp.ShowDialog()
    End Sub

    Private Sub AdministrarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmTemp As New frmAbmMovimiento_hora
        frmTemp.ShowDialog()
    End Sub


    Private Sub tsAdministrarControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsAdministrarControl.Click
        Dim frmTemp As New frmMainControl
        frmTemp.ShowDialog()
    End Sub

    'timer
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick


        Me.RefrescarPermisos()
        Me.CargarGrillaTareasPendientes()
        Me.verificarCambiosAntaciones()
        Me.RefrescarControl()

        If selected_row_tarea IsNot Nothing Then
            If selected_row_tarea.Index > -1 Then
                Me.CargarHorasTarea(CInt(selected_row_tarea.Cells("id_detalle_recurso_asignar").Value))
            End If
        End If



        Dim odtPendiente As New DataTable
        odtPendiente = oModificacion_arbol.GetAllPendiente(vgCodigoUsuario)

        Try
            Dim aux As String
            Dim nodo As TreeNode
            Dim pendiente As String = ""
            For Each row As DataRow In odtPendiente.Rows
                pendiente = row("nombre modificacion arbol").ToString
                Select Case pendiente

                    'Case "tsAdministrarControl"
                    '    Me.tsAdministrarControl.Enabled = CBool(dr("habilitado"))
                    'Case "tsAdministrarCuentaCliente"
                    '    Me.tsAdministrarCuentaCliente.Enabled = CBool(dr("habilitado"))
                    'Case "tsAdministrarCuentaProveedor"
                    '    Me.tsAdministrarCuentaProveedor.Enabled = CBool(dr("habilitado"))
                    'Case "tsAdministrarIva"
                    '    Me.tsAdministrarIva.Enabled = CBool(dr("habilitado"))
                    'Case "tsAdministrarHora"
                    '    Me.tsAdministrarHora.Enabled = CBool(dr("habilitado"))
                    'Case "tsAdministrarSeguridad"
                    '    Me.tsAdministrarSeguridad.Enabled = CBool(dr("habilitado"))

                    Case "tsAgregarActividad"
                        'Me.tsAgregarActividad.Enabled = CBool(row("habilitado"))
                        nodo = Me.TreeView1.SelectedNode
                        aux = row("Id proyecto").ToString
                        Me.TreeView1.SelectedNode = Me.TreeView1.Nodes.Find(aux, True)(0)
                        Me.refrescarProyecto()

                        'TreeView1.SelectedNode = GetNodeKeyProyecto(CInt("-" & row("id actividad").ToString), TreeView1.Nodes)
                        Me.TreeView1.SelectedNode = nodo


                    Case "tsAgregarControl"
                        Dim var As Integer
                        var = 0
                        var = CInt(Me.lblid_actividad.Text)
                        nodo = Me.TreeView1.SelectedNode
                        TreeView1.SelectedNode = GetNodeKeyProyecto(CInt("-" & row("id actividad").ToString), TreeView1.Nodes)
                        TreeView1.Select()
                        Try
                            If IsNothing(Me.TreeView1.SelectedNode) Then

                            Else
                                Me.TreeView1.SelectedNode.ImageIndex = 8
                            End If

                        Catch ex As Exception

                        End Try



                        'With oModificacion_arbol
                        '    .Cargar()
                        '    .Modificar(CInt(row("id modificacion arbol")))
                        '    .realizado = True
                        '    .Guardar()
                        'End With

                        TreeView1.SelectedNode = nodo 'GetNodeKeyProyecto(-var, TreeView1.Nodes)
                        TreeView1.Select()
                        '    Me.tsAgregarControl.Enabled = CBool(dr("habilitado"))

                    Case "tsRealizarControl"
                        'q utilidad tiene var?
                        Dim var As Integer
                        var = 0
                        var = CInt(Me.lblid_actividad.Text)
                        nodo = Me.TreeView1.SelectedNode
                        TreeView1.SelectedNode = GetNodeKeyProyecto(CInt("-" & row("id actividad").ToString), TreeView1.Nodes)
                        TreeView1.Select()
                        Try
                            'actualiza la imagen del nodo segun el control y refresca la grilla de control
                            If Me.TreeView1.SelectedNode IsNot Nothing Then
                                'la columna nombre tiene el indice de la imagen que hay que poner al nodo
                                Me.TreeView1.SelectedNode.ImageIndex = CInt(row("nombre").ToString)
                                Me.RefrescarControl()
                            End If
                        Catch ex As Exception
                        End Try
                        TreeView1.SelectedNode = nodo 'GetNodeKeyProyecto(-var, TreeView1.Nodes)
                        TreeView1.Select()
                        'Case "tsAgregarFactura"
                        '    Me.tsAgregarFactura.Enabled = CBool(dr("habilitado"))
                    Case "tsAgregarProyecto", "tsPegarProyecto", "tsPegarEstructura"
                        nodo = Me.TreeView1.SelectedNode
                        'Dim cad As String = nodo.Name
                        aux = row("nodo padre").ToString
                        Dim arr As TreeNode()
                        arr = Me.TreeView1.Nodes.Find(aux, True)
                        If arr.Length > 0 Then
                            Me.TreeView1.SelectedNode = Me.TreeView1.Nodes.Find(aux, True)(0)
                            Me.refrescarProyecto()
                        End If
                        'TreeView1.SelectedNode = GetNodeKeyProyecto(CInt("-" & row("id actividad").ToString), TreeView1.Nodes)
                        Me.TreeView1.SelectedNode = nodo
                        '    Me.tsAgregarProyecto.Enabled = CBool(dr("habilitado"))
                    Case "tsAgregarProyectoInicial", "tsPegarEstructuraProyectoInicial"
                        nodo = Me.TreeView1.SelectedNode
                        aux = row("Id proyecto").ToString
                        Dim aux2 As String
                        aux2 = row("nombre").ToString
                        If CDbl(row("id usuario modificador")) <> vgCodigoUsuario And Me.TreeView1.Nodes.Find(aux, True).Length = 0 Then 'guarde el codigo del usuario en el id_act
                            Me.TreeView1.Nodes.Add(aux, aux2)
                            Me.TreeView1.SelectedNode = Me.TreeView1.Nodes.Find(aux, True)(0)
                            refrescarProyecto()
                        End If
                        Me.TreeView1.SelectedNode = nodo
                        '    'TreeView1.SelectedNode = GetNodeKeyProyecto(CInt("-" & row("id actividad").ToString), TreeView1.Nodes)
                        '    Me.TreeView1.SelectedNode = nd
                        'Me.tsAgregarProyectoInicial.Enabled = CBool(dr("habilitado"))
                        'Case "tsPegarEstructuraProyectoInicial"
                        '    Me.tsPegarEstructuraProyectoInicial.Enabled = CBool(dr("habilitado")) 'agregado

                        'Case "tsAsignarRecurso"
                        '    Me.tsAsignarRecurso.Enabled = CBool(dr("habilitado"))
                    Case "tsBorrarActividad"
                        '    Me.tsBorrarActividad.Enabled = CBool(dr("habilitado"))
                        aux = row("id actividad").ToString
                        Dim n1, n2 As TreeNode
                        n1 = Me.TreeView1.Nodes.Find("-" & aux, True)(0)
                        'Me.TreeView1.SelectedNode = n1
                        'n2 = Me.TreeView1.SelectedNode.PrevNode
                        TreeView1.Nodes.Remove(n1)
                        'Me.TreeView1.SelectedNode = n2


                        'Case "tsBorrarHoraDevolver"
                        '    Me.tsBorrarHoraDevolver.Enabled = CBool(dr("habilitado"))
                    Case "tsBorrarProyecto"
                        aux = row("nodo padre").ToString
                        Dim arr As TreeNode()
                        Try
                            arr = Me.TreeView1.Nodes.Find(aux, True)
                            'If arr.Length > 0 Then
                            nodo = arr(0)
                            TreeView1.Nodes.Remove(nodo)
                            'End If
                            'Me.TreeView1.SelectedNode = n1
                            'n2 = Me.TreeView1.SelectedNode.PrevNode

                        Catch ex As Exception

                        End Try


                        '    Me.tsBorrarProyecto.Enabled = CBool(dr("habilitado"))
                        'Case "tsCalendarioAnual"
                        '    Me.tsCalendarioAnual.Enabled = CBool(dr("habilitado"))
                        'Case "tsCopiarEstructura"
                        '    Me.tsCopiarEstructura.Enabled = CBool(dr("habilitado"))
                        'Case "tsCopiarProyecto"
                        '    Me.tsCopiarProyecto.Enabled = CBool(dr("habilitado"))
                        'Case "tsHorasADevolver"
                        '    Me.tsHorasADevolver.Enabled = CBool(dr("habilitado"))
                        'Case "tsModificarActividad"
                        '    Me.tsModificarActividad.Enabled = CBool(dr("habilitado"))
                        'Case "tsModificarHoraDevolver"
                        '    Me.tsModificarHoraDevolver.Enabled = CBool(dr("habilitado"))
                        'Case "tsModificarProyecto"
                        '    Me.tsModificarProyecto.Enabled = CBool(dr("habilitado"))
                        'Case "tsMostrarProyectosOcultos"
                        '    Me.tsMostrarProyectosOcultos.Enabled = CBool(dr("habilitado"))
                        'Case "tsNuevoCalendario"
                        '    Me.tsNuevoCalendario.Enabled = CBool(dr("habilitado"))
                        'Case "tsPegarEstructura"
                        '    Me.tsPegarEstructura.Enabled = CBool(dr("habilitado"))
                        'Case "tsPegarProyecto"

                        '    Me.tsPegarProyecto.Enabled = CBool(dr("habilitado"))
                        'Case "tsReordenarVoz"
                        '    Me.tsReordenarVoz.Enabled = CBool(dr("habilitado"))
                        'Case "tsRevisarCalendario"
                        '    Me.tsRevisarCalendario.Enabled = CBool(dr("habilitado"))
                    Case "tsArchivarProyecto"
                        aux = row("id proyecto").ToString
                        Dim n1 As TreeNode
                        If CDec(row("nodo padre")) = 1 Then
                            n1 = Me.TreeView1.Nodes.Find(aux, True)(0)
                            TreeView1.Nodes.Remove(n1)
                        End If

                    Case "tsArrastrar"

                        nodo = Me.TreeView1.SelectedNode
                        Dim nodo1 As TreeNode
                        Dim arr As TreeNode()
                        aux = row("nodo").ToString
                        Dim nom, padre As String
                        nom = row("nombre").ToString
                        padre = row("nodo padre").ToString
                        If CInt(row("id usuario modificador")) <> vgCodigoUsuario Then
                            Try
                                arr = Me.TreeView1.Nodes.Find(aux, True)
                                nodo1 = arr(0)
                                TreeView1.Nodes.Remove(nodo1)
                            Catch ex As Exception

                            End Try

                            If CDec(padre) = 1 Then
                                Me.TreeView1.Nodes.Add(aux, nom)
                                Me.TreeView1.SelectedNode = Me.TreeView1.Nodes.Find(aux, True)(0)
                            Else
                                arr = Me.TreeView1.Nodes.Find(padre, True)
                                If arr.Length > 0 Then
                                    Me.TreeView1.SelectedNode = arr(0)
                                End If
                            End If
                            refrescarProyecto()
                            Me.TreeView1.SelectedNode = nodo
                        End If

                    Case "tsModificarActividad"
                        Dim nodoaux As TreeNode
                        nodoaux = Me.TreeView1.SelectedNode
                        Dim nombre As String

                        Try
                            nombre = oActividad.GetOne(CInt(row("id actividad").ToString)).Rows(0).Item("Nombre_actividad").ToString
                            aux = row("nodo padre").ToString
                            Dim arr As TreeNode()
                            arr = Me.TreeView1.Nodes.Find(aux, True)
                            'If arr.Length > 0 Then
                            nodo = arr(0)

                            Me.TreeView1.SelectedNode = nodo
                            Me.TreeView1.SelectedNode.Text = nombre
                            'End If
                            'Me.TreeView1.SelectedNode = n1
                            'n2 = Me.TreeView1.SelectedNode.PrevNode

                        Catch ex As Exception

                        End Try
                        Me.TreeView1.SelectedNode = nodoaux
                        'Me.TreeView1.SelectedNode = n1
                        'n2 = Me.TreeView1.SelectedNode.PrevNode

                    Case "tsModificarProyecto"
                        Dim nodoaux As TreeNode
                        Dim id_proyecto As Integer

                        id_proyecto = CInt(row("id proyecto").ToString)
                        nodo = Me.TreeView1.SelectedNode
                        aux = row("nodo padre").ToString
                        Dim nombre As String
                        nombre = oProyecto.GetOne(id_proyecto).Rows(0).Item("Nombre proyecto").ToString

                        Dim arr As TreeNode()
                        arr = Me.TreeView1.Nodes.Find(aux, True)
                        'If arr.Length > 0 Then
                        nodoaux = arr(0)

                        Me.TreeView1.SelectedNode = nodoaux
                        Me.TreeView1.SelectedNode.Text = nombre

                        Me.TreeView1.SelectedNode = nodo
                        'Case "tsCliente"
                        '    Me.tsCliente.Enabled = CBool(dr("habilitado"))
                        'Case "tsControl"
                        '    Me.tsControl.Enabled = CBool(dr("habilitado"))
                        'Case "tsFactura"
                        '    Me.tsFactura.Enabled = CBool(dr("habilitado"))
                        'Case "tsHora"
                        '    Me.tsHora.Enabled = CBool(dr("habilitado"))
                        'Case "tsIva"
                        '    Me.tsIva.Enabled = CBool(dr("habilitado"))
                        'Case "tsProveedor"
                        '    Me.tsProveedor.Enabled = CBool(dr("habilitado"))
                        'Case "tsProyecto"
                        '    Me.tsProyecto.Enabled = CBool(dr("habilitado"))
                        'Case "tsSeguridad"
                        '    Me.tsSeguridad.Enabled = CBool(dr("habilitado"))
                End Select

                'Dim proy As String = row("Id proyecto").ToString
                'Me.TreeView1.SelectedNode = Me.TreeView1.Nodes.Find(proy, True)(0)
                'Me.refrescarProyecto()
                ''TreeView1.SelectedNode = GetNodeKeyProyecto(CInt("-" & row("id actividad").ToString), TreeView1.Nodes)


                With oModificacion_arbol
                    .Cargar()
                    .Modificar(CInt(row("id modificacion arbol")))
                    .realizado = True
                    .Guardar()
                End With
            Next
        Catch ex As Exception

        End Try
    End Sub


    Private Sub VerProyectosOcultos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsVerProyectosOcultos.Click
        Me.chkProyectoOculto.Checked = True
        'agregado
        Me.cbx_factura.Checked = False
        Me.Load_tree()
        Me.TreeView1.ContextMenuStrip = Me.cmsProyecto
    End Sub

    Private Sub MostrarProyectosOcultos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsMostrarProyectosOcultos.Click
        Me.chkProyectoOculto.Checked = False
        Me.cbx_factura.Checked = False
        Me.Load_tree()
        Me.TreeView1.ContextMenuStrip = Me.cmsProyecto
    End Sub

    Private Sub chkControlProyecto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.RefrescarControl()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tsAsignarRecurso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmDetalle As New frmDetalleDetalle_recurso
        oDetalle_recurso.Cargar()
        oDetalle_recurso.Insertar()

        If Not IsNumeric(Me.lblid_detalle_recurso.Text) Then
            Exit Sub
        End If
        BanderaDetalle_recurso = 1
        Me.AddOwnedForm(frmDetalle)


        frmDetalle.CargarCombos()
        frmDetalle.ShowDialog()
    End Sub


    'Private Sub tsCopiarEstructura_Click(sender As System.Object, e As System.EventArgs) Handles tsCopiarEstructura.Click
    '    'coloco el id del proyecto de origen que es el que se va a copiar
    '    Me.lblid_proyecto_origen.Text = Me.lblid_proyecto.Text
    '    banderacopiarestructura = 1
    'End Sub

    'Private Sub tsPegarEstructura_Click(sender As System.Object, e As System.EventArgs) Handles tsPegarEstructura.Click

    '    Me.Load_treeCopiar()
    '    Me.refrescarProyecto()

    '    Dim tab As New DataTable
    '    tab = oUsuario.ConsultarTodo

    '    For Each row As DataRow In tab.Rows
    '        With oModificacion_arbol
    '            .Cargar()
    '            .Insertar()
    '            .id_proyecto = CInt(Me.lblid_proyecto.Text)
    '            .id_usuario = CInt(row("id usuario"))
    '            .nodo_padre = CDec(Me.TreeView1.SelectedNode.Name)
    '            .nombre_modificacion_arbol = "tsPegarEstructura"
    '            .realizado = False
    '            .tipo_nodo = "p"
    '            .Guardar()
    '        End With
    '    Next
    'End Sub

    Private Sub btnRealizarTarea_Click(sender As System.Object, e As System.EventArgs)
        oDetalle_recurso.PonerRealizada(CInt(Me.lblid_detalle_recurso.Text))
        Me.RefrescarTarea()
    End Sub


    Private Sub tsNuevoCalendario_Click(sender As System.Object, e As System.EventArgs) Handles tsNuevoCalendario.Click
        Dim frmTemp As New frmNuevoCalendario
        frmTemp.ShowDialog()
    End Sub

    Private Sub tsRevisarCalendario_Click(sender As System.Object, e As System.EventArgs) Handles tsRevisarCalendario.Click
        Dim frmTemp As New frmAbmCalendario_usuario
        frmTemp.ShowDialog()
    End Sub

    Private Sub tsHorasAdevolver_Click(sender As System.Object, e As System.EventArgs) Handles tsHorasADevolver.Click
        Dim btnTemp As New Button
        Dim frmDetalle As New frmDetalleHora_a_devolver

        oHora_a_devolver.Cargar()

        Try
            BanderaHora_a_devolver = 1
            Me.AddOwnedForm(frmDetalle)
            oHora_a_devolver.Insertar()
            frmDetalle.CargarCombos()
            frmDetalle.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        RefrescarHoraADevolver()
    End Sub

    Private Sub tsHora_Click(sender As System.Object, e As System.EventArgs) Handles tsHora.Click
        RefrescarHoraADevolver()
    End Sub

    Private Sub tsFactura_Click(sender As System.Object, e As System.EventArgs)
        'ahora tiene que llamar el arbol load_tree_factura
        Me.cbx_factura.Checked = True
        Me.Load_tree()
        Me.TreeView1.ContextMenuStrip = Me.ctm_factura
    End Sub


    Private Sub AgregarFacturaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles tsAgregarFactura.Click
        Dim frmTemp As New frmAbmFactura
        'agregado para obtener referencia
        Me.AddOwnedForm(frmTemp)
        frmTemp.ShowDialog()
    End Sub

    Private Sub tsProyecto_Click(sender As System.Object, e As System.EventArgs)
        Me.cbx_factura.Checked = False
        Me.TreeView1.ContextMenuStrip = Me.cmsProyecto
    End Sub

    Private Sub tsAdministrarIva_Click(sender As System.Object, e As System.EventArgs) Handles tsAdministrarIva.Click
        Dim frmTemp As New frmAbmGestion_iva
        frmTemp.ShowDialog()
    End Sub

    Private Sub tsAdministrarCuentaProveedor_Click(sender As System.Object, e As System.EventArgs) Handles tsAdministrarCuentaProveedor.Click
        Dim frmTemp As New frmResumenProveedor
        frmTemp.ShowDialog()
    End Sub

    Private Sub tsAdministrarCuentaCliente_Click(sender As System.Object, e As System.EventArgs) Handles tsAdministrarCuentaCliente.Click
        Dim frmTemp As New frmResumenCliente
        frmTemp.ShowDialog()
    End Sub

    'Private Sub PegarEstructuraProyectoInicialToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles tsPegarEstructuraProyectoInicial.Click
    '    copia1 = 1
    '    Me.Load_treeCopiar()
    '    Me.Load_tree()

    '    Dim odt As New DataTable
    '    odt = oProyecto.GetTree_Padre(1)

    '    Dim tabla1 As New DataTable
    '    tabla1 = oUsuario.ConsultarTodo

    '    For Each row As DataRow In tabla1.Rows
    '        With oModificacion_arbol
    '            .Cargar()
    '            .Insertar()
    '            .id_actividad = vgCodigoUsuario 'mando el codigo aca de puro negro para no tener q agregar un campo mas 'Math.Abs(CInt(Me.lblid_actividad.Text))
    '            .id_proyecto = CInt(odt.Rows(odt.Rows.Count - 1)("id_proyecto"))
    '            .id_usuario = CInt(row("id usuario"))
    '            .nodo = CDec(odt.Rows(odt.Rows.Count - 1)("id_proyecto")) 'CDec(Me.lblid_proyecto_origen.Text)
    '            .nodo_padre = 1
    '            .nombre_modificacion_arbol = "tsPegarEstructuraProyectoInicial"
    '            .realizado = False
    '            .tipo_nodo = "p"
    '            .nombre = odt.Rows(odt.Rows.Count - 1)("Nombre_proyecto").ToString
    '            .id_usuario_modificador = vgCodigoUsuario
    '            .Guardar()
    '        End With
    '    Next
    'End Sub

    ' modifica horas pendientes
    Private Sub btn_modificar_Click(sender As System.Object, e As System.EventArgs)
        'If lblid_horas_pendiente.Text = "0" Then
        '    MsgBox("No seleccionó el usuario a modificar horas pendientes")
        'Else
        '    Dim btnTemp As New Button
        '    Dim frmDetalle As New frmDetalleHora_a_devolver
        '    oHora_a_devolver.Cargar()
        '    Try
        '        BanderaHora_a_devolver = 2
        '        Me.AddOwnedForm(frmDetalle)
        '        oHora_a_devolver.Modificar(CInt(lblid_horas_pendiente.Text))
        '        frmDetalle.CargarCombos()
        '        frmDetalle.ShowDialog()
        '    Catch ex As Exception
        '        MessageBox.Show(ex.Message)
        '    End Try
        'End If
        'RefrescarHoraADevolver()
    End Sub


    Sub RefrescarHoraADevolver()
        'Dim odt As New DataTable
        'Dim decTot As Decimal = 0

        'odt = oHora_a_devolver.GetAll_3(DateTime.Now, vgCodigoUsuario)

        'dgvHorasDevolver.DataSource = odt
        'Me.dgvHorasDevolver.Columns(0).Visible = False
        'Me.dgvHorasDevolver.Columns(1).Visible = False

        'For Each row As DataRow In odt.Rows
        '    decTot = decTot + CDec(row.Item("hora"))
        'Next

        'Me.lblTablero_1.Text = "Horas a Devolver por Usuario"
        'Me.lblTableroTotal_1.Text = CStr(decTot)
    End Sub

    Private Sub btn_cancelar_Click(sender As System.Object, e As System.EventArgs)
        'If lblid_horas_pendiente.Text = "0" Then
        '    MsgBox("Seleccione el usuario a borrar horas pendientes")
        'Else
        '    oHora_a_devolver.Borrar(CInt(lblid_horas_pendiente.Text))
        'End If
        'RefrescarHoraADevolver()
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Try
            With oCuerpo_movimiento_hora
                .Cargar()
                .Modificar(Me.id_cuerpo_movimiento_hora)
                .salida = DateTime.Now
                .Guardar()
            End With
            Me.RefrescarLogueo()

        Catch ex As Exception
        End Try

    End Sub


    Private Sub tsModificarHoraDevolver_Click(sender As System.Object, e As System.EventArgs) Handles tsModificarHoraDevolver.Click
        'If lblid_horas_pendiente.Text = "0" Then
        '    MsgBox("No seleccionó el usuario a modificar horas pendientes")
        'Else
        '    Dim btnTemp As New Button
        '    Dim frmDetalle As New frmDetalleHora_a_devolver
        '    oHora_a_devolver.Cargar()
        '    Try
        '        BanderaHora_a_devolver = 2
        '        Me.AddOwnedForm(frmDetalle)
        '        oHora_a_devolver.Modificar(CInt(lblid_horas_pendiente.Text))
        '        frmDetalle.CargarCombos()
        '        frmDetalle.ShowDialog()
        '    Catch ex As Exception
        '        MessageBox.Show(ex.Message)
        '    End Try
        'End If
        'RefrescarHoraADevolver()
    End Sub

    Private Sub tsBorrarHoraDevolver_Click(sender As System.Object, e As System.EventArgs) Handles tsBorrarHoraDevolver.Click
        'If lblid_horas_pendiente.Text = "0" Then
        '    MsgBox("No seleccionó el usuario a borrar horas pendientes")
        'Else
        '    oHora_a_devolver.Borrar(CInt(lblid_horas_pendiente.Text))
        'End If
        'RefrescarHoraADevolver()
    End Sub


    'agregado par actualizar arbol de logueados
    Private Sub Timer_Logueo_Tick(sender As System.Object, e As System.EventArgs) Handles Timer_Logueo.Tick
        With oUsuario
            .Cargar()
            .Modificar(CInt(vgCodigoUsuario))
            .session_activa = DateTime.Now
            .Guardar()
        End With
        ActualizarGrillaLogueo()
    End Sub

    Private Sub VerTodasLasTareasPendientesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VerTodasLasTareasPendientesToolStripMenuItem.Click
        'ControlTarea_all()
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


    Private Sub borrarcontrol()
         Try
            If Not oUsuario_permiso.TienePermiso(vgCodigoUsuario, 68) Then
                MessageBox.Show("No tiene permisos para realizar esta operación")
                Exit Sub
            End If

            oMovimiento_voz.BorrarConControlesRealizados(CInt(Me.selected_rowControl.Cells("id_movimiento_voz_control").Value))
            Me.refrescarProyecto()
            Me.LimpiarDatosControl()
            Me.CargarGrillaActividadesControles()
            'MessageBox.Show("Control borrado exitosamene", "Borrar Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al borrar el control: " + ex.Message, "Borrar Control", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnRefrescarControl_Click(sender As System.Object, e As System.EventArgs) Handles btnRefrescarControl.Click
        Me.RefrescarControl()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim intFuente As Integer = 0
        intFuente = CInt(Me.TreeView1.Font.Size)

        If intFuente < 30 Then
            Me.TreeView1.Font = New Font(Me.TreeView1.Font.Name, intFuente + 1)
        End If

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim intFuente As Integer = 0
        intFuente = CInt(Me.TreeView1.Font.Size)
        If intFuente > 5 Then
            Me.TreeView1.Font = New Font(Me.TreeView1.Font.Name, intFuente - 1)
        End If

    End Sub

    'coloca el rojo en la celdas negativas
    Private Sub dgvControl_CellFormatting(ByVal sender As Object, _
    ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)
        Try
            CType(sender, DataGridView).Rows(e.RowIndex).DefaultCellStyle.BackColor = System.Drawing.Color.Green

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

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.TreeView1.Sorted = False
        Me.Load_tree()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs)
        MessageBox.Show("Proyecto: " & Me.lblid_proyecto.Text & vbCr &
                        "Actividad: " & Me.lblid_actividad.Text & vbCr & _
                        "Actividad_Proyecto: " & Me.lblid_actividad_proyecto.Text & vbCr & _
                        "Control: " & Me.lblid_control.Text)
    End Sub

    Private Sub tsAdministrarCaja_Click(sender As System.Object, e As System.EventArgs) Handles tsAdministrarCaja.Click
        Dim frmTemp As New frmResumenCaja
        frmTemp.ShowDialog()
    End Sub

    Private Sub tsAdministrarBanco_Click(sender As System.Object, e As System.EventArgs) Handles tsAdministrarBanco.Click
        Dim frmTemp As New Frmmovbancos
        frmTemp.ShowDialog()
    End Sub

    Private Sub RecorrerNodos(treeNode As TreeNode)
        Try
            'Si el nodo que recibimos tiene hijos se recorrerá
            'para luego verificar si esta o no checkeado
            For Each tn As TreeNode In treeNode.Nodes
                Dim odr As New stArbol
                odr = CType(tn.Tag, stArbol)
                MessageBox.Show(tn.Name + " " + tn.Text)

                If odr.tipo = "a" Then
                    MessageBox.Show(tn.Name + " " + tn.Text)

                End If

                RecorrerNodos(treeNode)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub btnVerHoras_Click(sender As System.Object, e As System.EventArgs) Handles btnVerHoras.Click
        If Me.TreeView1.SelectedNode IsNot Nothing Then
            Dim odr As New stArbol
            odr = CType(Me.TreeView1.SelectedNode.Tag, stArbol)

            If odr.tipo = "p" Then
                Dim frmPropiedadProyecto As New frmPropiedadesProyecto(odr.id_proyecto, 0)
                frmPropiedadProyecto.ShowDialog()
            ElseIf odr.tipo = "s" Then
                Dim frmPropiedadActividad As New frmPropiedadesProyecto(0, odr.id_subproyecto)
                frmPropiedadActividad.ShowDialog()
            ElseIf odr.tipo = "a" Then
                Dim frmPropiedadActividad As New frmPropiedadesActividad(odr.id_actividad_proyecto)
                frmPropiedadActividad.ShowDialog()
            End If
        Else
            MessageBox.Show("Por favor, seleccione un proyecto para ver los avances", "Seleccionar Proyecto", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub tsRefrescarProyecto_Click(sender As Object, e As System.EventArgs) Handles tsRefrescarProyecto.Click, ts_actualizar_proyecto_admin.Click
        refrescarProyecto()
    End Sub

    Private Sub refrescarProyecto()
        Dim tnParent As New TreeNode()
        tnParent.Text = Me.TreeView1.SelectedNode.Text
        tnParent.Name = Me.TreeView1.SelectedNode.Name
        tnParent.Tag = Me.TreeView1.SelectedNode.Tag
        Dim nodoindex = TreeView1.SelectedNode.Index

        cargarProyecto(tnParent)

        Dim nodo, nodosgte As TreeNode

        If TreeView1.SelectedNode IsNot Nothing Then
            nodo = TreeView1.SelectedNode.Parent
            nodosgte = TreeView1.SelectedNode.NextNode

            Me.TreeView1.SelectedNode = tnParent

            If Me.TreeView1.SelectedNode.Name <> tnParent.Name Then
                Me.TreeView1.SelectedNode = Me.TreeView1.Nodes.Find(tnParent.Name, True)(0)
            End If

            If nodo Is Nothing Then
                If nodosgte Is Nothing Then
                    TreeView1.Nodes.Remove(TreeView1.SelectedNode)
                    TreeView1.Nodes.Add(tnParent)
                Else
                    TreeView1.Nodes.Remove(TreeView1.SelectedNode)
                    TreeView1.Nodes.Insert(nodoindex, tnParent)
                End If
            Else
                If nodosgte Is Nothing Then
                    TreeView1.Nodes.Remove(TreeView1.SelectedNode)
                    nodo.Nodes.Add(tnParent)
                Else
                    TreeView1.Nodes.Remove(TreeView1.SelectedNode)
                    CType(nodo, TreeNode).Nodes.Insert(nodoindex, tnParent)
                End If
            End If
        End If

        TreeView1.SelectedNode = tnParent
        TreeView1.SelectedNode.Expand()
    End Sub

    Private Sub cargarProyecto(ByVal tnParent As TreeNode)

        Me.TreeView1.SelectedNode = tnParent

        Me.FillChild(tnParent, tnParent.Name)
        Me.FillChild_actividad(tnParent, tnParent.Name)

    End Sub


    Private Sub tsBorrarCtrl_Click(sender As Object, e As System.EventArgs)
        Dim odtTempCont As New DataTable

        odtTempCont = oMovimiento_voz.GetActividadProyecto(CInt(Me.lblid_actividad_proyecto.Text))
        If odtTempCont.Rows.Count > 0 Then
            borrarcontrol()
        Else
            MessageBox.Show("La Actividad no posee ningun control asignado")
        End If
    End Sub


    Private Sub btnInforme_Click(sender As Object, e As EventArgs) Handles btnInforme.Click
        Try
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

    Private Sub TimerLogueo_Tick(sender As Object, e As EventArgs) Handles TimerLogueo.Tick
        Dim time_span As TimeSpan
        If vgControlLogueo = True And dgvLogueo.Rows.Count > 0 Then
            time_span = CDate(DateTime.Now.ToString("HH:mm:ss")).Subtract(CDate(CDate(Me.dgvLogueo.Rows(0).Cells("salida_login_dgv").Value).ToString("HH:mm:ss")))
            Dim time_span_add As TimeSpan
            For Each row As DataGridViewRow In dgvLogueo.Rows
                If row.Cells("proyecto_login_dgv").Value.ToString() + row.Cells("actividad_login_dgv").Value.ToString() = Me.dgvLogueo.Rows(0).Cells("proyecto_login_dgv").Value.ToString() + Me.dgvLogueo.Rows(0).Cells("actividad_login_dgv").Value.ToString() Then
                    time_span_add = CDate(CDate(row.Cells("salida_login_dgv").Value).ToString("HH:mm:ss")).Subtract(CDate(CDate(row.Cells("entrada_login_dgv").Value).ToString("HH:mm:ss")))
                    time_span = time_span + time_span_add
                End If
            Next
            Me.txt_hora_parcial.Text = time_span.ToString("hh\:mm\:ss")
        Else
            Me.txt_hora_parcial.Text = "No logueado"
        End If

        'Hora total
        time_span = CDate(DateTime.Now.ToString("HH:mm:ss")).Subtract(CDate(CDate(hora_logueo_dia).ToString("HH:mm:ss")))
        Me.txt_hora_total.Text = time_span.ToString("hh\:mm\:ss")
    End Sub

    'Private Sub frmLoginInicio_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
    '    Try
    '        If e.Alt And e.KeyCode = Keys.Enter And Me.TreeView1.SelectedNode IsNot Nothing And Me.tsAdministrarProyecto.Enabled Then

    '            If CType(TreeView1.SelectedNode.Tag, stArbol).tipo = "p" Then
    '                Dim frm As New frmAdministrarSubproyectos(CType(TreeView1.SelectedNode.Tag, stArbol).id_proyecto, CType(TreeView1.SelectedNode.Tag, stArbol).tipo)
    '                frm.Show()
    '            ElseIf CType(TreeView1.SelectedNode.Tag, stArbol).tipo = "s" Then
    '                Dim frm As New frmAdministrarSubproyectos(CType(TreeView1.SelectedNode.Tag, stArbol).id_subproyecto, CType(TreeView1.SelectedNode.Tag, stArbol).tipo)
    '                frm.Show()
    '            ElseIf CType(TreeView1.SelectedNode.Tag, stArbol).tipo = "a" Then
    '                Dim frm As New frmAdministrarSubproyectos(CType(TreeView1.SelectedNode.Tag, stArbol).id_actividad_proyecto, CType(TreeView1.SelectedNode.Tag, stArbol).tipo)
    '                frm.Show()
    '            End If
    '        End If
    '    Catch ex As Exception

    '    End Try

    'End Sub

    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsReportesControl.Click
        Dim frmReporte As New frmReporteControles
        frmReporte.Show()
    End Sub

    Private Sub dgvLogueo_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvLogueo.MouseClick
        'If e.Button = MouseButtons.Right Then
        '    Dim currentMouseOverRow As Integer
        '    currentMouseOverRow = dgvLogueo.HitTest(e.X, e.Y).RowIndex

        '    If currentMouseOverRow >= 0 Then
        '        dgvLogueo.ClearSelection()
        '        dgvLogueo.Rows(currentMouseOverRow).Selected = True
        '        cmsLogueo.Show(dgvLogueo, New Point(e.X, e.Y))
        '    End If
        'End If
    End Sub

    Private Sub VerControlesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsVerControles.Click
        Dim frmVerControles As New frmVerControles
        frmVerControles.ShowDialog()
    End Sub


    Private Sub VerLogueosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsVerLogueos.Click
        Dim frmLogueoDia As New frmLogueoDia(vgCodigoUsuario)
        frmLogueoDia.ShowDialog()
    End Sub

    Private Sub ActualizarGrillaLogueo()
        Try
            Dim dt As DataTable
            Dim dr_index As Integer
            dt = oCuerpo_movimiento_hora.GetLogueoActual()

            dgv_logueo_actual.Rows.Clear()

            For Each row As DataRow In dt.Rows
                dr_index = dgv_logueo_actual.Rows.Add()
                With dgv_logueo_actual.Rows(dr_index)
                    .Cells("Proyecto").Value = row.Item("Proyecto")
                    .Cells("Nombre").Value = row.Item("Nombre")
                    .Cells("logueado_Actividad").Value = row.Item("Actividad")
                    .Cells("Subproyecto").Value = row.Item("Subproyecto")
                    .Cells("id_cuerpo_movimiento_hora_dgv_logueo").Value = row.Item("id_cuerpo_movimiento_hora")
                    .Cells("id_movimiento_hora_dgv_logueo").Value = row.Item("id_movimiento_hora")
                    .Cells("id_actividad_proyecto_dgv_logueo").Value = row.Item("id_Actividad_proyecto")
                End With
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgv_logueo_actual_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgv_logueo_actual.DataBindingComplete
        Me.dgv_logueo_actual.Columns("Proyecto").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub AdministrarToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles ts_AdministrarCliente.Click
        Dim frmCliente As New frmAbmCliente
        frmCliente.ShowDialog()
    End Sub

    Private Sub cargarGrillaClientes()

        cmb_cliente.DataSource = oCliente.GetCmb()
        cmb_cliente.ValueMember = "id_cliente"
        cmb_cliente.DisplayMember = "nombre_cliente"
        cmb_cliente.SelectedValue = 2

    End Sub

    Private Sub buscarNodoSubproyecto(ByVal id_subproyecto As Integer)
        Dim nodo As TreeNode
        Dim tvn() As TreeNode
        Dim b As Boolean = True
        Dim proy As Integer
        Dim id_proyecto, id_cliente As Integer
        Dim tabla As New DataTable
        Dim arr() As Integer
        ReDim arr(0)

        With oSubproyecto
            .Cargar()
            .Modificar(id_subproyecto)
            id_proyecto = .id_proyecto

            oProyecto.Modificar(.id_proyecto)
            id_cliente = oProyecto.id_cliente
        End With

        cmb_cliente.SelectedValue = id_cliente
        tabla = oProyecto.GetOne_2(id_proyecto)

        arr(0) = CInt(tabla.Rows(0).Item("Id_proyecto"))

        tvn = Me.TreeView1.Nodes.Find(CStr(id_proyecto), True)

        If tvn.Length = 0 Then

            proy = CInt(tabla.Rows(0).Item("Id_proyecto"))
            nodo = TreeView1.SelectedNode 'nodo le asigno algo solo para q tome el valor q adquiere en for

            Try
                For index As Integer = 0 To arr.Count - 1
                    tvn = Me.TreeView1.Nodes.Find(CStr(arr(index)), True)
                    If tvn.Length > 0 Then
                        For indice As Integer = index To 0 Step -1

                            Me.TreeView1.SelectedNode = Me.TreeView1.Nodes.Find(CStr(arr(indice)), True)(0)
                            nodo = Me.TreeView1.SelectedNode 'Next
                            refrescarProyecto()

                        Next
                        Exit For
                    End If
                Next
            Catch ex As Exception

            End Try

        Else
            Me.TreeView1.SelectedNode = tvn(0)
            refrescarProyecto()
            Me.TreeView1.Focus()
        End If

        Dim dt As DataTable
        dt = oSubproyecto.ObtenerPadres(id_subproyecto)

        Dim i As Integer = dt.Rows.Count - 1

        For Each row As DataRow In dt.Rows
            tvn = Me.TreeView1.Nodes.Find(CStr(dt.Rows(i).Item("id_subproyecto")), True)

            Me.TreeView1.SelectedNode = tvn(0)
            refrescarProyecto()
            Me.TreeView1.Focus()

            i = i - 1
        Next
    End Sub

    Private Sub buscarNodo(ByVal id_actividad_proyecto As Integer)
        Dim nodo As TreeNode
        Dim tvn() As TreeNode
        Dim id_actividad, id_proyecto, id_subproyecto As Integer
        Dim tabla As New DataTable
        Dim arr() As Integer
        ReDim arr(0)
        Dim b As Boolean = True
        Dim proy As Integer

        With oActividad_proyecto
            .Cargar()
            .Modificar(id_actividad_proyecto)
            id_actividad = .id_actividad
            id_proyecto = .id_proyecto
            id_subproyecto = .id_subproyecto
        End With

        tabla = oProyecto.GetOne_2(id_proyecto)

        arr(0) = CInt(tabla.Rows(0).Item("Id_proyecto"))
        Dim padre As Integer = CInt(tabla.Rows(0).Item("Id_proyecto_padre"))

        tvn = Me.TreeView1.Nodes.Find(CStr(id_proyecto), True)

        If tvn.Length = 0 Then

            proy = CInt(tabla.Rows(0).Item("Id_proyecto"))
            nodo = TreeView1.SelectedNode 'nodo le asigno algo solo para q tome el valor q adquiere en for

            Try
                For index As Integer = 0 To arr.Count - 1
                    tvn = Me.TreeView1.Nodes.Find(CStr(arr(index)), True)
                    If tvn.Length > 0 Then
                        For indice As Integer = index To 0 Step -1

                            Me.TreeView1.SelectedNode = Me.TreeView1.Nodes.Find(CStr(arr(indice)), True)(0)
                            nodo = Me.TreeView1.SelectedNode 'Next
                            refrescarProyecto()

                        Next
                        Exit For
                    End If
                Next
            Catch ex As Exception

            End Try

        Else
            Dim nd() As TreeNode = Me.TreeView1.Nodes.Find("-" & id_actividad, True)
            If nd.Length = 0 Then
                Me.TreeView1.SelectedNode = tvn(0)
                refrescarProyecto()
            End If
        End If

        If id_subproyecto <> 0 Then
            Dim dt As DataTable
            dt = oSubproyecto.ObtenerPadres(id_subproyecto)

            Dim i As Integer = dt.Rows.Count - 1

            For Each row As DataRow In dt.Rows
                tvn = Me.TreeView1.Nodes.Find(CStr(dt.Rows(i).Item("id_subproyecto")), True)

                Dim nd() As TreeNode = Me.TreeView1.Nodes.Find("-" & id_actividad, True)
                If nd.Length = 0 Then
                    Me.TreeView1.SelectedNode = tvn(0)
                    refrescarProyecto()
                End If

                i = i - 1
            Next
        End If


        nodo = GetNodeKeyProyecto(CInt("-" & id_actividad), TreeView1.Nodes)
        If nodo IsNot Nothing Then
            b = False
            TreeView1.SelectedNode = nodo
        End If


    End Sub


    Private Sub cmb_cliente_posta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_cliente.SelectedIndexChanged
        Try
            Load_tree()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Load_tree()

        Dim odr As New stArbol
        Dim id_color_proyecto As Integer = 0
        Dim odt As New DataTable
        Dim odtAct As New DataTable
        Dim intIconoActividad As Integer = 0
        Dim intIconoActividadSeleccionado As Integer = 0
        Dim odtTempCont As New DataTable
        Dim child As New TreeNode()
        Dim odtActividadenProceso As New DataTable


        odt = oProyecto.GetTree_conCliente_nvaImpl(CInt(cmb_cliente.SelectedValue))

        TreeView1.Nodes.Clear()

        Dim x As Integer = 1

        For Each dr As DataRow In odt.Rows

            If DirectCast(dr("id_proyecto"), Integer) <> 0 Then

                If es_admin Then
                    With oProyecto
                        .Cargar()
                        .Modificar(CInt(dr("id_proyecto")))
                        .nro = x
                        .Guardar()
                    End With
                End If

                Dim tnParent As New TreeNode()
                tnParent.Text = dr("nombre_proyecto").ToString()

                Dim value As String = dr("id_proyecto").ToString()
                tnParent.Name = value


                If id_color_proyecto = CInt(dr("id_proyecto")) Then
                    tnParent.ImageIndex = 5
                Else
                    tnParent.ImageIndex = 0
                End If

                odr.tipo = "p"
                odr.id_proyecto = CInt(dr("id_proyecto"))
                odr.id_actividad = 0
                odr.id_actividad_proyecto = 0
                odr.id_cliente = CInt(dr("id_cliente"))
                odr.icono = 0
                odr.id_subproyecto = 0

                tnParent.Tag = odr

                TreeView1.Nodes.Add(tnParent)

                ''Los proyectos hijos del proyecto
                Dim odtProy As New DataTable
                odtProy = oSubproyecto.ObtenerPorProyecto(odr.id_proyecto, 1)


                Dim odtAct1 As New DataTable
                odtAct1 = oActividad_proyecto.GetAllProyecto(odr.id_proyecto, 0, 0)

                Dim nodoh As New TreeNode
                nodoh.Text = " "

                If odtAct1.Rows.Count > 0 Or odtProy.Rows.Count > 0 Then
                    tnParent.Nodes.Add(nodoh)
                End If
                x = x + 2
            End If
        Next


        odtAct = oActividad_proyecto.GetAllProyectoConCliente(0, CInt(cmb_cliente.SelectedValue))

        If odtAct.Rows.Count > 0 Then

            x = 1
            For Each dr As DataRow In odtAct.Rows

                If es_admin Then
                    With oActividad_proyecto
                        .Cargar()
                        .Modificar(CInt(dr("id_actividad_proyecto")))
                        .orden = x
                        .Guardar()
                    End With
                End If

                odtActividadenProceso = oMovimiento_voz.GetActividadProyectoEnProceso(CInt(dr("id_actividad_proyecto")))
                odtTempCont = oMovimiento_voz.GetActividadProyecto(CInt(dr("id_actividad_proyecto")))

                If odtTempCont.Rows.Count > 0 Then
                    odtTempCont = oMovimiento_voz.GetActividadProyectoCompleto(CInt(dr("id_actividad_proyecto")))

                    If odtTempCont.Rows.Count > 0 Then
                        intIconoActividad = 8
                        If odtActividadenProceso.Rows.Count > 0 Then
                            intIconoActividad = 9
                        End If
                    Else
                        intIconoActividad = 6
                    End If

                Else
                    intIconoActividad = 1
                End If

                If CBool(dr("no_conformidad")) = True Then
                    intIconoActividad = 10
                End If

                odr.tipo = "a"
                odr.id_proyecto = CInt(dr("id_proyecto"))
                odr.id_actividad = CInt(dr("id_actividad"))
                odr.id_actividad_proyecto = CInt(dr("id_actividad_proyecto"))
                odr.icono = intIconoActividad
                odr.icono_seleccionado = 3
                odr.id_cliente = CInt(cmb_cliente.SelectedValue)
                odr.id_subproyecto = CInt(dr("id_subproyecto"))

                child = TreeView1.Nodes.Add(CStr(CDec(dr("id_actividad")) * -1), CStr(dr("nombre_actividad")), intIconoActividad, 3)
                child.Tag = odr

                x = x + 2
            Next
        End If

    End Sub


    Private Sub btn_buscar_ot_Click(sender As Object, e As EventArgs) Handles btn_buscar_ot.Click
        Try
            Dim id_subproyecto As Integer
            id_subproyecto = CInt(oSubproyecto.ObtenerPorOT("0", Me.txt_buscar_ot.Text).Rows(0).Item("id_subproyecto"))

            Me.buscarNodoSubproyecto(id_subproyecto)
            'If es_admin Then
            '    If Me.TreeView1.SelectedNode IsNot Nothing Then
            '        If CType(Me.TreeView1.SelectedNode.Tag, stArbol).id_subproyecto = id_subproyecto Then
            '            Me.tv_subproyectos_MouseDoubleClick(Nothing, Nothing)
            '        End If
            '    End If
            'End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_buscar_ot_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_buscar_ot.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                btn_buscar_ot_Click(Nothing, Nothing)
            End If
        Catch ex As Exception

        End Try

    End Sub


    Private Sub ts_tipos_subproyecto_Click(sender As Object, e As EventArgs) Handles ts_tipos_subproyecto.Click
        Dim form As New frmAgregarTipoSubproyecto
        form.Show()
    End Sub

    Private Sub ts_administrar_actividades_Click(sender As Object, e As EventArgs) Handles ts_administrar_actividades.Click
        Dim form As New frmABMActividad
        form.Show()
    End Sub

    Private Sub tabControles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabControles.SelectedIndexChanged
        Me.HabilitarControlesControl(False)
    End Sub

    Private Sub dgvControl_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvControl.CellDoubleClick
        Try
            Me.tv_subproyectos_MouseDoubleClick(Nothing, Nothing)
            Me.id_control_pdf = CInt(CType(sender, DataGridView).Item("id_control_dgv", CType(sender, DataGridView).CurrentRow.Index).Value)
            Me.id_movimiento_voz_pdf = CInt(CType(sender, DataGridView).Item("id_movimiento_voz_dgv", CType(sender, DataGridView).CurrentRow.Index).Value)
            btnInforme.Enabled = True

            Me.lblid_pk.Text = CStr(CType(sender, DataGridView).Item(0, CType(sender, DataGridView).CurrentRow.Index).Value)
            Me.lblid_pk_proyecto.Text = CStr(CType(sender, DataGridView).Item("id_proyecto_dgv", CType(sender, DataGridView).CurrentRow.Index).Value)
            Me.lblid_pk_actividad.Text = CStr(CType(sender, DataGridView).Item("id_actividad_dgv", CType(sender, DataGridView).CurrentRow.Index).Value)
            Me.lblid_control.Text = CStr(CType(sender, DataGridView).Item("id_control_dgv", CType(sender, DataGridView).CurrentRow.Index).Value)
            Me.lblid_movimiento_voz.Text = CStr(CType(sender, DataGridView).Item("id_movimiento_voz_dgv", CType(sender, DataGridView).CurrentRow.Index).Value)
            Me.lblid_actividad_proyecto.Text = CStr(CType(sender, DataGridView).Item("id_actividad_proyecto_dgv", CType(sender, DataGridView).CurrentRow.Index).Value)

            Me.chkP.Checked = CBool(CType(sender, DataGridView).Item("control_prod_dgv", CType(sender, DataGridView).CurrentRow.Index).Value)
            Me.chk1.Checked = CBool(CType(sender, DataGridView).Item("control_1_dgv", CType(sender, DataGridView).CurrentRow.Index).Value)
            Me.chk2.Checked = CBool(CType(sender, DataGridView).Item("control_2_dgv", CType(sender, DataGridView).CurrentRow.Index).Value)
            Dim chkP2 As Boolean = CBool(CType(sender, DataGridView).Item("control_prod_2_dgv", CType(sender, DataGridView).CurrentRow.Index).Value)

            cmb_cliente.SelectedValue = CInt(oProyecto.ObtenerClienteProyecto(CInt(Me.lblid_pk_proyecto.Text)).Rows(0).Item("id_cliente"))
            buscarNodo(CInt(CType(sender, DataGridView).Item("id_actividad_proyecto_dgv", CType(sender, DataGridView).CurrentRow.Index).Value))


        Catch ex As Exception

        End Try
    End Sub


    Private Sub dgvControlEspera_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvControlEspera.CellDoubleClick
        Try
            Me.id_control_pdf = CInt(CType(sender, DataGridView).Item("id_control_dgv_espera", CType(sender, DataGridView).CurrentRow.Index).Value)
            Me.id_movimiento_voz_pdf = CInt(CType(sender, DataGridView).Item("id_movimiento_voz_dgv_espera", CType(sender, DataGridView).CurrentRow.Index).Value)
            btnInforme.Enabled = True

            cmb_cliente.SelectedValue = CInt(oProyecto.ObtenerClienteProyecto(CInt(CType(sender, DataGridView).Item("id_proyecto_dgv_espera", CType(sender, DataGridView).CurrentRow.Index).Value)).Rows(0).Item("id_cliente"))
            buscarNodo(CInt(CType(sender, DataGridView).Item("id_actividad_proyecto_dgv_espera", CType(sender, DataGridView).CurrentRow.Index).Value))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvControlesCompletados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvControlesCompletados.CellDoubleClick
        Try
            Me.id_control_pdf = CInt(CType(sender, DataGridView).Item("id_control_dgv_completado", CType(sender, DataGridView).CurrentRow.Index).Value)
            Me.id_movimiento_voz_pdf = CInt(CType(sender, DataGridView).Item("id_movimiento_voz_dgv_completado", CType(sender, DataGridView).CurrentRow.Index).Value)
            btnInforme.Enabled = True

            cmb_cliente.SelectedValue = CInt(oProyecto.ObtenerClienteProyecto(CInt(CType(sender, DataGridView).Item("id_proyecto_dgv_completado", CType(sender, DataGridView).CurrentRow.Index).Value)).Rows(0).Item("id_cliente"))
            buscarNodo(CInt(CType(sender, DataGridView).Item("id_actividad_proyecto_dgv_completado", CType(sender, DataGridView).CurrentRow.Index).Value))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvLogueo_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLogueo.CellDoubleClick
        If dgvLogueo.Rows.Count > 0 And dgvLogueo.SelectedRows.Count > 0 Then
            cmb_cliente.SelectedValue = CInt(CType(sender, DataGridView).SelectedRows(0).Cells("id_cliente_dgv_logueo").Value)
            buscarNodo(CInt(CType(sender, DataGridView).Item("id_actividad_proyecto_login_dgv", CType(sender, DataGridView).CurrentRow.Index).Value))
        End If
    End Sub

    Private Sub CargarGrillaTareasPendientes()
        Dim odt As DataTable
        Dim dr_index As Integer
        Dim id_detalle_recurso As Integer = 0
        Dim id_detalle_recurso_tabla As Integer = 0
        Dim id_detalle_recurso_grilla As Integer = 0
        Dim index As Integer = -1
        Dim encontrado As Boolean
        odt = oDetalle_recurso.GetPendiente(vgCodigoUsuario)

        If Me.dgv_tareas_pendientes.SelectedRows.Count > 0 Then
            id_detalle_recurso = CInt(Me.dgv_tareas_pendientes.SelectedRows(0).Cells("id_detalle_recurso_asignar").Value)
        End If

        Me.tab_tareas.Text = "Tareas (" & odt.Rows.Count & ")"

        Dim cantidad As Integer = Me.dgv_tareas_pendientes.Rows.Count


        'CONTROLES


        For Each row_grid As DataGridViewRow In dgv_tareas_pendientes.Rows
            id_detalle_recurso_grilla = CInt(row_grid.Cells("id_detalle_recurso_asignar").Value)
            encontrado = False
            For Each row As DataRow In odt.Rows
                id_detalle_recurso_tabla = CInt(row.Item("id_detalle_recurso"))
                If id_detalle_recurso_tabla = id_detalle_recurso_grilla Then
                    encontrado = True
                End If
            Next
            If encontrado = False Then
                Me.dgv_tareas_pendientes.Rows.Remove(row_grid)
            End If
        Next

        For Each row As DataRow In odt.Rows
            encontrado = False
            id_detalle_recurso_tabla = CInt(row.Item("id_detalle_recurso"))
            For Each row_grid As DataGridViewRow In dgv_tareas_pendientes.Rows
                id_detalle_recurso_grilla = CInt(row_grid.Cells("id_detalle_recurso_asignar").Value)

                If id_detalle_recurso_grilla = id_detalle_recurso_tabla Then
                    With row_grid
                        .Cells("id_detalle_recurso_asignar").Value = row.Item("id_detalle_recurso").ToString()
                        .Cells("id_actividad_proyecto_asignar").Value = row.Item("id_actividad_proyecto").ToString()
                        .Cells("id_actividad_asignar").Value = row.Item("id_actividad").ToString()
                        .Cells("id_proyecto_asignar").Value = row.Item("id_proyecto").ToString()
                        .Cells("motivo_asignar").Value = row.Item("motivo").ToString()
                        .Cells("nombre_actividad_asignar").Value = row.Item("nombre_actividad").ToString()
                        .Cells("cantidad_hora_asignar").Value = row.Item("cantidad_hora").ToString()
                        .Cells("nombre_proyecto_asignar").Value = row.Item("nombre_proyecto").ToString()
                        .Cells("nombre_subproyecto_asignar").Value = row.Item("nombre_subproyecto").ToString()
                        .Cells("nombre_cliente_asignar").Value = row.Item("nombre_cliente").ToString()
                    End With
                    If id_detalle_recurso <> 0 And id_detalle_recurso = CInt(row.Item("id_detalle_recurso")) Then
                        index = row_grid.Index
                    End If
                    encontrado = True

                    Exit For
                End If
            Next


            If encontrado = False Then
                dr_index = dgv_tareas_pendientes.Rows.Add()
                With dgv_tareas_pendientes.Rows(dr_index)
                    .Cells("id_detalle_recurso_asignar").Value = row.Item("id_detalle_recurso").ToString()
                    .Cells("id_actividad_proyecto_asignar").Value = row.Item("id_actividad_proyecto").ToString()
                    .Cells("id_actividad_asignar").Value = row.Item("id_actividad").ToString()
                    .Cells("id_proyecto_asignar").Value = row.Item("id_proyecto").ToString()
                    .Cells("motivo_asignar").Value = row.Item("motivo").ToString()
                    .Cells("nombre_actividad_asignar").Value = row.Item("nombre_actividad").ToString()
                    .Cells("cantidad_hora_asignar").Value = row.Item("cantidad_hora").ToString()
                    .Cells("nombre_proyecto_asignar").Value = row.Item("nombre_proyecto").ToString()
                    .Cells("nombre_subproyecto_asignar").Value = row.Item("nombre_subproyecto").ToString()
                    .Cells("nombre_cliente_asignar").Value = row.Item("nombre_cliente").ToString()
                    If id_detalle_recurso <> 0 And id_detalle_recurso = CInt(row.Item("id_detalle_recurso")) Then
                        index = dr_index
                    End If
                End With
            End If
        Next







        ''''''''''''''''''''''''''''''''''''''''''''''''''''''


        'Me.dgv_tareas_pendientes.Rows.Clear()


        'For Each row As DataRow In odt.Rows
        '    dr_index = dgv_tareas_pendientes.Rows.Add()
        '    With dgv_tareas_pendientes.Rows(dr_index)
        '        .Cells("id_detalle_recurso_asignar").Value = row.Item("id_detalle_recurso").ToString()
        '        .Cells("id_actividad_proyecto_asignar").Value = row.Item("id_actividad_proyecto").ToString()
        '        .Cells("id_actividad_asignar").Value = row.Item("id_actividad").ToString()
        '        .Cells("id_proyecto_asignar").Value = row.Item("id_proyecto").ToString()
        '        .Cells("motivo_asignar").Value = row.Item("motivo").ToString()
        '        .Cells("nombre_actividad_asignar").Value = row.Item("nombre_actividad").ToString()
        '        .Cells("cantidad_hora_asignar").Value = row.Item("cantidad_hora").ToString()
        '        .Cells("nombre_proyecto_asignar").Value = row.Item("nombre_proyecto").ToString()
        '        .Cells("nombre_subproyecto_asignar").Value = row.Item("nombre_subproyecto").ToString()
        '        .Cells("nombre_cliente_asignar").Value = row.Item("nombre_cliente").ToString()
        '        If id_detalle_recurso <> 0 And id_detalle_recurso = CInt(row.Item("id_detalle_recurso")) Then
        '            index = dr_index
        '        End If
        '    End With
        'Next



        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        If Me.dgv_tareas_pendientes.Rows.Count > cantidad Then
            mostrarNotificacion("TAREAS: Tiene nuevas tareas para realizar")
        End If

        If index <> -1 Then
            Me.dgv_tareas_pendientes.ClearSelection()
            Me.dgv_tareas_pendientes.Rows(index).Selected = True
            Me.selected_row_tarea = Me.dgv_tareas_pendientes.Rows(index)
            Me.CargarDatosTarea()
        Else
            Me.LimpiarDatosTareas()
        End If


    End Sub

    Private Sub ts_administrar_estados_Click(sender As Object, e As EventArgs) Handles ts_administrar_estados.Click
        Dim form As New frmABMEstadoProyecto
        form.Show()
    End Sub


    Private Sub dgv_tareas_pendientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        If dgv_tareas_pendientes.Rows.Count > 0 And dgv_tareas_pendientes.SelectedRows.Count > 0 Then

            Dim _proy As New Proyecto
            With _proy
                .Cargar()
                .Modificar(CInt(CType(sender, DataGridView).SelectedRows(0).Cells("id_proyecto_asignar").Value))
            End With

            cmb_cliente.SelectedValue = _proy.id_cliente
            buscarNodo(CInt(CType(sender, DataGridView).Item("id_actividad_proyecto_asignar", CType(sender, DataGridView).CurrentRow.Index).Value))
        End If
    End Sub

    Private Sub CargarListaAnotaciones()
        lista_anotaciones.Clear()

        If id_proyecto_anotacion <> 0 Then

            Dim odt As DataTable
            Dim oAnotacion_Proyecto As New entAnotaciones_Proyecto

            odt = oAnotacion_Proyecto.GetFromProyectoCadista(Me.id_proyecto_anotacion)

            lista_anotaciones.Columns.Add("Anotaciones")
            lista_anotaciones.Columns(0).Width = lista_anotaciones.Width - 4

            For Each row As DataRow In odt.Rows
                Dim anotacion As ListViewItem
                anotacion = lista_anotaciones.Items.Add(row.Item("id_anotacion").ToString(), row.Item("descripcion").ToString(), 2)

                If CBool(row.Item("resaltar")) Then
                    anotacion.ForeColor = System.Drawing.Color.Red
                End If

            Next
        End If
    End Sub

    Private Sub verificarCambiosAntaciones()
        If id_proyecto_anotacion <> 0 Then

            Dim odt As DataTable
            Dim oAnotacion_Proyecto As New entAnotaciones_Proyecto

            odt = oAnotacion_Proyecto.GetFromProyectoCadista(Me.id_proyecto_anotacion)

            Dim existe As Boolean
            For Each lv_item As ListViewItem In lista_anotaciones.Items
                existe = False
                For Each row As DataRow In odt.Rows
                    If lv_item.Name = row.Item("id_anotacion").ToString() Then
                        existe = True
                        Exit For
                    End If
                Next
                If existe = False Then
                    lista_anotaciones.Columns.Clear()
                    Me.CargarListaAnotaciones()
                    mostrarNotificacion("ANOTACIONES: Han surgido modificaciones en las anotaciones!")
                    Exit Sub
                End If
            Next

            For Each row As DataRow In odt.Rows

                Dim aux As ListViewItem

                If lista_anotaciones.Items.Find(row.Item("id_anotacion").ToString(), False).Length > 0 Then
                    aux = lista_anotaciones.Items.Find(row.Item("id_anotacion").ToString(), False)(0)

                    If aux.Text.Equals(row.Item("descripcion").ToString()) = False Then
                        mostrarNotificacion("ANOTACIONES: " & aux.Text & " cambiado a: " & row.Item("descripcion").ToString())
                        aux.Text = row.Item("descripcion").ToString()
                    End If

                    If aux.ForeColor <> System.Drawing.Color.Red And CBool(row.Item("resaltar")) Then
                        aux.ForeColor = System.Drawing.Color.Red
                    ElseIf aux.ForeColor <> System.Drawing.Color.Black And CBool(row.Item("resaltar")) = False Then
                        aux.ForeColor = System.Drawing.Color.Black
                    End If
                Else
                    lista_anotaciones.Columns.Clear()
                    Me.CargarListaAnotaciones()
                    mostrarNotificacion2("ANOTACIONES: Han surgido modificaciones en las anotaciones!")
                    Exit Sub
                End If
            Next
        End If
    End Sub

    Private Sub ts_anotaciones_copiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ts_anotaciones_copiar.Click
        If lista_anotaciones.SelectedItems.Count = 0 Then Exit Sub
        Clipboard.Clear()
        Clipboard.SetText(lista_anotaciones.SelectedItems(0).Text)
    End Sub

    Private Sub CargarHorasTarea(ByVal id_detalle_recurso As Integer)

        Dim odtMovimientoHora As New DataTable
        Dim decTotal As Decimal = 0
        Dim decTotalHora As Decimal = 0
        Dim decMinuto As Decimal = 0
        Dim dtInicio As DateTime
        Dim dtFin As DateTime
        Dim dr_index As Integer
        Dim id_cuerpo_movimiento_hora_pendiente As Integer
        Dim encontrado As Boolean = False
        Dim id_movimiento_grilla, id_movimiento_tabla As Integer

        odtMovimientoHora = oCuerpo_movimiento_hora.GetAllPorDetalleRecurso(id_detalle_recurso, vgCodigoUsuario)

        If Me.dgvLogueoDeTarea.SelectedRows().Count > 0 Then
            id_cuerpo_movimiento_hora_pendiente = CInt(Me.dgvLogueoDeTarea.SelectedRows(0).Cells("id_cuerpo_movimiento_hora_login_tarea").Value)
        End If


        For Each row_grid As DataGridViewRow In dgvLogueoDeTarea.Rows
            id_movimiento_grilla = CInt(row_grid.Cells("id_cuerpo_movimiento_hora_login_tarea").Value)
            encontrado = False
            For Each row As DataRow In odtMovimientoHora.Rows
                id_movimiento_tabla = CInt(row.Item("id_cuerpo_movimiento_hora"))
                If id_movimiento_tabla = id_movimiento_grilla Then
                    encontrado = True
                End If
            Next
            If encontrado = False Then
                Me.dgvLogueoDeTarea.Rows.Remove(row_grid)
            End If
        Next


        For Each row As DataRow In odtMovimientoHora.Rows
            encontrado = False
            id_movimiento_tabla = CInt(row.Item("id_cuerpo_movimiento_hora"))
            For Each row_grid As DataGridViewRow In dgvLogueoDeTarea.Rows
                id_movimiento_grilla = CInt(row_grid.Cells("id_cuerpo_movimiento_hora_login_tarea").Value)

                If id_movimiento_grilla = id_movimiento_tabla Then
                    With row_grid
                        .Cells("id_cuerpo_movimiento_hora_login_tarea").Value = row.Item("id_cuerpo_movimiento_hora")
                        .Cells("hora_entrada_tarea").Value = row.Item("Inicio")
                        .Cells("hora_salida_tarea").Value = row.Item("Fin")
                        .Cells("tiempo_tarea").Value = TimeSpan.FromSeconds(CDbl(row.Item("Tiempo"))).ToString("hh\:mm\:ss")
                        .Cells("fecha_tarea").Value = row.Item("Fecha")
                        .Cells("id_movimiento_hora_login_tarea").Value = row.Item("id_movimiento_hora")
                    End With
                    encontrado = True

                    Exit For
                End If
            Next

            If encontrado = False Then
                dr_index = dgvLogueoDeTarea.Rows.Add()
                With dgvLogueoDeTarea.Rows(dr_index)
                    .Cells("id_cuerpo_movimiento_hora_login_tarea").Value = row.Item("id_cuerpo_movimiento_hora")
                    .Cells("hora_entrada_tarea").Value = row.Item("Inicio")
                    .Cells("hora_salida_tarea").Value = row.Item("Fin")
                    .Cells("tiempo_tarea").Value = TimeSpan.FromSeconds(CDbl(row.Item("Tiempo"))).ToString("hh\:mm\:ss")
                    .Cells("fecha_tarea").Value = row.Item("Fecha")
                    .Cells("id_movimiento_hora_login_tarea").Value = row.Item("id_movimiento_hora")
                End With
            End If
        Next


        'Dim hora As String

        'For Each row As DataGridViewRow In dgvLogueoDeTarea.Rows
        '    hora = row.Cells("tiempo_tarea").Value.ToString()
        '    hora = TimeSpan.FromSeconds(CDbl(hora)).ToString("hh\:mm\:ss")
        '    row.Cells("tiempo_tarea").Value = hora
        'Next

        For Each row As DataRow In odtMovimientoHora.Rows
            dtInicio = CDate(row("Inicio"))
            dtFin = CDate(row("Fin"))

            'calcula la cantidad de horas trabajadas
            decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtFin)
            decTotal = CDec(FormatNumber(decMinuto / 60, 2))
            decTotalHora = decTotalHora + decTotal
        Next

        Me.CargarDatosTarea()
        Me.txt_cantidad_horas_reales.Text = FormatNumber(decTotalHora, 2)

        Dim porcentaje As Integer = 0
        If CDec(selected_row_tarea.Cells("cantidad_hora_asignar").Value) <> 0 Then
            porcentaje = CInt(decTotalHora / CDec(selected_row_tarea.Cells("cantidad_hora_asignar").Value) * 100)
        End If

        If porcentaje > 100 Then
            Me.progreso_tarea.Value = 100
            SendMessage(progreso_tarea.Handle.ToInt32, 1040, 2, 0)
        ElseIf porcentaje < 100 And porcentaje > 95 Then
            Me.progreso_tarea.Value = porcentaje
            SendMessage(progreso_tarea.Handle.ToInt32, 1040, 3, 0)
        ElseIf porcentaje >= 0 Then
            SendMessage(progreso_tarea.Handle.ToInt32, 1040, 1, 0)
            Me.progreso_tarea.Value = porcentaje
        End If

    End Sub

    Private Sub CargarDatosTarea()
        Dim id_detalle_recurso As Integer = CInt(selected_row_tarea.Cells("id_detalle_recurso_asignar").Value)
        Dim odt As DataTable

        odt = oDetalle_recurso.GetTodaInformacion(id_detalle_recurso)

        Me.LimpiarDatostareas()

        If odt.Rows.Count > 0 Then
            With odt.Rows(0)
                Me.txt_nombre_cliente_tareas.Text = .Item("nombre_cliente").ToString()
                Me.txt_nombre_proyecto_tareas.Text = .Item("nombre_proyecto").ToString()
                Me.txt_nombre_subproyecto_tareas.Text = .Item("nombre_subproyecto").ToString()
                Me.txt_nombre_Actividad_tareas.Text = .Item("nombre_Actividad").ToString()
                Me.txt_fecha_inicio_tareas.Text = .Item("fecha_inicio").ToString()
                Me.txt_horas_estimadas_tareas.Text = .Item("cantidad_hora").ToString()
                Me.txt_observaciones_tareas.Text = .Item("motivo").ToString()

                'ECHO este if agregue
                'If oSubproyecto.genera_ot Then
                '    Me.TextOt.Text = CompletarCerosCodigo(CStr(oSubproyecto.ObtenerNroOrdenTrabajo(oSubproyecto.id_suproyecto)))
                'Else
                '    Me.TextOt.Text = CompletarCerosCodigo(CStr(oSubproyecto.ObtenerOTPadre(oSubproyecto.id_suproyecto)))
                'End If

                If CBool(.Item("control_asignado")) Then
                    Me.chk_asignado_control_tareas.Checked = CBool(.Item("control_asignado"))
                    Me.btn_realizar_control_tarea.Enabled = CBool(.Item("control_asignado"))
                    Me.txt_nombre_control_tareas.Text = .Item("nombre_control").ToString()
                Else
                    Dim _Actividad_Proyecto As New Actividad_proyecto
                    Dim _Actividad As New Actividad

                    With _Actividad_Proyecto
                        .Cargar()
                        .Modificar(CInt(odt.Rows(0).Item("id_actividad_proyecto")))
                    End With

                    With _Actividad
                        .Cargar()
                        .Modificar(_Actividad_Proyecto.id_actividad)
                    End With

                    If _Actividad_Proyecto.id_control <> 0 Then
                        Me.chk_asignado_control_tareas.Checked = CBool(.Item("control_asignado"))
                        Me.btn_realizar_control_tarea.Enabled = CBool(.Item("control_asignado"))
                        Me.txt_nombre_control_tareas.Text = .Item("nombre_control").ToString()
                    Else
                        Dim id_control As Integer = 0
                        If _Actividad_Proyecto.GetControl(_Actividad_Proyecto.id_actividad_proyecto, _Actividad.id_tipo_actividad).Rows().Count > 0 Then
                            With _Actividad_Proyecto.GetControl(_Actividad_Proyecto.id_actividad_proyecto, _Actividad.id_tipo_actividad).Rows(0)
                                _Actividad_Proyecto.id_control = CInt(.Item("id_control"))
                                If _Actividad_Proyecto.id_control <> 0 Then
                                    Me.txt_nombre_control_tareas.Text = oControl.GetOne(_Actividad_Proyecto.id_control).Rows(0).Item("Nombre Control").ToString()
                                    Me.chk_asignado_control_tareas.Checked = True
                                    Me.btn_realizar_control_tarea.Enabled = True
                                Else
                                    Me.txt_nombre_control_tareas.Text = ""
                                    Me.chk_asignado_control_tareas.Checked = False
                                    Me.btn_realizar_control_tarea.Enabled = False
                                End If
                            End With
                        Else
                            Me.txt_nombre_control_tareas.Text = ""
                            Me.chk_asignado_control_tareas.Checked = False
                            Me.btn_realizar_control_tarea.Enabled = False
                        End If

                    End If
                End If

                Me.chk_realizada_tarea.Checked = CBool(.Item("realizada"))
            End With
        End If



    End Sub

    Private Sub LimpiarDatosTareas()
        Me.txt_nombre_cliente_tareas.Text = ""
        Me.txt_nombre_proyecto_tareas.Text = ""
        Me.txt_nombre_subproyecto_tareas.Text = ""
        Me.txt_nombre_Actividad_tareas.Text = ""
        Me.txt_fecha_inicio_tareas.Text = ""
        Me.txt_horas_estimadas_tareas.Text = ""
        Me.txt_observaciones_tareas.Text = ""
        Me.txt_nombre_control_tareas.Text = ""
        Me.chk_asignado_control_tareas.Checked = False
        Me.chk_realizada_tarea.Checked = False
        Me.btn_realizar_control_tarea.Enabled = False
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

    Private Sub btnLoginTarea_Click(sender As Object, e As EventArgs) Handles btnLoginTarea.Click

        If Me.dgv_tareas_pendientes.SelectedRows.Count = 0 Then
            Exit Sub
        End If

        Dim dtHoraLogueo As DateTime
        Dim id_detalle_recurso_temp As Integer
        id_detalle_recurso_temp = CInt(Me.dgv_tareas_pendientes.SelectedRows(0).Cells("id_detalle_recurso_asignar").Value)

        If opInicio = True Then
            dtHoraLogueo = vgHoraIngreso

            With oMovimiento_hora
                .Cargar()
                .Insertar()
                .fecha = Date.Now
                .id_dia = 1
                .id_usuario = vgCodigoUsuario
                .Guardar()
                vgCodigoMovimientoHora = .id_movimiento_hora
            End With
        Else
            dtHoraLogueo = DateTime.Now
        End If

        opInicio = False

        Dim tabla As New DataTable
        tabla = oCuerpo_movimiento_hora.GetOne_Act(Me.id_cuerpo_movimiento_hora, CInt(Me.dgv_tareas_pendientes.SelectedRows(0).Cells("id_actividad_proyecto_asignar").Value))

        If tabla.Rows.Count > 0 Then
            vgyalogueado = True
            Exit Sub
        End If

        If Me.id_cuerpo_movimiento_hora = 0 Then
            With oCuerpo_movimiento_hora
                .Cargar()
                .Insertar()
                .entrada = dtHoraLogueo
                .salida = dtHoraLogueo
                .id_actividad_proyecto = CInt(Me.dgv_tareas_pendientes.SelectedRows(0).Cells("id_actividad_proyecto_asignar").Value)
                .id_movimiento_hora = vgCodigoMovimientoHora
                .id_tipo_logueo = 1
                .id_detalle_recurso = id_detalle_recurso_temp
                .Guardar()

                Me.id_cuerpo_movimiento_hora = .id_cuerpo_movimiento_hora
            End With
        Else
            If oCuerpo_movimiento_hora.salida = oCuerpo_movimiento_hora.entrada Then
                With oCuerpo_movimiento_hora
                    .Cargar()
                    .Modificar(Me.id_cuerpo_movimiento_hora)
                    .salida = dtHoraLogueo
                    .Guardar()
                End With
                With oCuerpo_movimiento_hora
                    .Cargar()
                    .Insertar()
                    .entrada = dtHoraLogueo
                    .salida = dtHoraLogueo
                    .id_actividad_proyecto = CInt(Me.dgv_tareas_pendientes.SelectedRows(0).Cells("id_actividad_proyecto_asignar").Value)
                    .id_movimiento_hora = vgCodigoMovimientoHora
                    .id_tipo_logueo = 1
                    .id_detalle_recurso = id_detalle_recurso_temp
                    .Guardar()

                    Me.id_cuerpo_movimiento_hora = .id_cuerpo_movimiento_hora
                End With
            Else
                With oCuerpo_movimiento_hora
                    .Cargar()
                    .Insertar()
                    .entrada = dtHoraLogueo
                    .salida = dtHoraLogueo
                    .id_actividad_proyecto = CInt(Me.dgv_tareas_pendientes.SelectedRows(0).Cells("id_actividad_proyecto_asignar").Value)
                    .id_movimiento_hora = vgCodigoMovimientoHora
                    .id_tipo_logueo = 1
                    .id_detalle_recurso = id_detalle_recurso_temp
                    .Guardar()

                    Me.id_cuerpo_movimiento_hora = .id_cuerpo_movimiento_hora
                End With
            End If
        End If

        Dim id_actividad_proyecto As Integer = oCuerpo_movimiento_hora.id_actividad_proyecto
        Dim _Detalle_Recurso As New Detalle_recurso
        Dim odt_pendiente As DataTable
        odt_pendiente = _Detalle_Recurso.GetAllPendiente()
        Dim _Actividad_proyecto As New Actividad_proyecto

        For Each row As DataRow In odt_pendiente.Rows
            If CInt(row.Item("id_Actividad_proyecto")) = id_actividad_proyecto Then
                If CInt(row.Item("id_detalle_recurso")) <> CInt(Me.dgv_tareas_pendientes.SelectedRows(0).Cells("id_detalle_recurso_asignar").Value) Then
                    With _Detalle_Recurso
                        .Cargar()
                        .Borrar(CInt(row.Item("id_detalle_recurso")))
                    End With
                End If
            End If
        Next

        With _Actividad_proyecto
            .Cargar()
            .Modificar(id_actividad_proyecto)
            .asignada = True
            .Guardar()
        End With

        vgControlLogueo = True
        Me.RefrescarLogueo()
        Me.id_proyecto_anotacion = CInt(Me.dgv_tareas_pendientes.SelectedRows(0).Cells("id_proyecto_asignar").Value)
        Me.CargarListaAnotaciones()

        If vgyalogueado Then
            vgyalogueado = False
            Exit Sub
        End If

        Me.Timer2.Start()
    End Sub

    Private Sub dgv_tareas_pendientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_tareas_pendientes.CellClick
        If Me.dgv_tareas_pendientes.SelectedRows.Count > 0 Then

            With oProyecto
                .Cargar()
                .Modificar(CInt(Me.dgv_tareas_pendientes.SelectedRows(0).Cells("id_proyecto_asignar").Value))
            End With

            Me.selected_row_tarea = Me.dgv_tareas_pendientes.SelectedRows(0)
            Me.CargarHorasTarea(CInt(selected_row_tarea.Cells("id_detalle_recurso_asignar").Value))

        End If
    End Sub

    Private Sub dgv_tareas_pendientes_CellDoubleClick_2(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_tareas_pendientes.CellDoubleClick
        If Me.dgv_tareas_pendientes.SelectedRows.Count > 0 Then

            With oProyecto
                .Cargar()
                .Modificar(CInt(Me.dgv_tareas_pendientes.SelectedRows(0).Cells("id_proyecto_asignar").Value))
            End With

            Me.selected_row_tarea = Me.dgv_tareas_pendientes.SelectedRows(0)
            Me.CargarHorasTarea(CInt(selected_row_tarea.Cells("id_detalle_recurso_asignar").Value))

            cmb_cliente.SelectedValue = oProyecto.id_cliente
            buscarNodo(CInt(CType(sender, DataGridView).Item("id_actividad_proyecto_asignar", CType(sender, DataGridView).CurrentRow.Index).Value))

        End If
    End Sub

    Private Sub btn_realizar_control_tarea_Click(sender As Object, e As EventArgs) Handles btn_realizar_control_tarea.Click

        If Me.selected_row_tarea IsNot Nothing Then

            Dim id_detalle_recurso As Integer = CInt(selected_row_tarea.Cells("id_detalle_recurso_asignar").Value)
            Dim id_actividad_proyecto As Integer = CInt(selected_row_tarea.Cells("id_actividad_proyecto_asignar").Value)
            Dim _Detalle_Recurso As New Detalle_recurso
            Dim odt_pendiente As DataTable
            Dim _Actividad_proyecto As New Actividad_proyecto

            odt_pendiente = _Detalle_Recurso.GetAllPendiente()

            'Borra la asignación de la tarea a otras personas
            For Each row As DataRow In odt_pendiente.Rows
                If CInt(row.Item("id_Actividad_proyecto")) = id_actividad_proyecto Then
                    If CInt(row.Item("id_detalle_recurso")) <> CInt(Me.dgv_tareas_pendientes.SelectedRows(0).Cells("id_detalle_recurso_asignar").Value) Then
                        With _Detalle_Recurso
                            .Cargar()
                            .Borrar(CInt(row.Item("id_detalle_recurso")))
                        End With
                    End If
                End If
            Next

            'Setea la actividad como asignada
            With _Actividad_proyecto
                .Cargar()
                .Modificar(id_actividad_proyecto)
                .asignada = True
                .Guardar()
            End With


            If Me.chk_asignado_control_tareas.Checked Then
                Dim odt As DataTable
                Dim id_movimiento_voz As Integer = 0

                odt = oDetalle_recurso.GetTodaInformacion(id_detalle_recurso)

                If odt.Rows.Count > 0 Then
                    With odt.Rows(0)
                        id_movimiento_voz = CInt(.Item("id_movimiento_voz"))
                    End With
                End If

                If id_movimiento_voz <> 0 Then
                    With oMovimiento_voz
                        .Cargar()
                        .Modificar(id_movimiento_voz)

                        If .id_usuario_1 <> vgCodigoUsuario And .id_usuario_1 <> 0 Then
                            MessageBox.Show("El control de esta actividad ha sido asignada a otra persona. Consulte con el piloto de proyecto", "Control de la actividad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If

                    End With

                Else
                    Dim _Actividad As New Actividad

                    With _Actividad_proyecto
                        .Cargar()
                        .Modificar(CInt(selected_row_tarea.Cells("id_actividad_proyecto_asignar").Value))
                    End With

                    With _Actividad
                        .Cargar()
                        .Modificar(CInt(selected_row_tarea.Cells("id_actividad_asignar").Value))
                    End With

                    With oMovimiento_voz
                        .Cargar()
                        .Insertar()
                        .fecha = Date.Now
                        .id_cadista = vgCodigoUsuario
                        If _Actividad_proyecto.id_control <> 0 Then
                            .id_controlador_1 = _Actividad_proyecto.id_controlador_1
                            .id_controlador_2 = _Actividad_proyecto.id_controlador_2
                        Else
                            Dim id_control As Integer = 0
                            With _Actividad_proyecto.GetControl(_Actividad_proyecto.id_actividad_proyecto, _Actividad.id_tipo_actividad).Rows(0)
                                _Actividad_proyecto.id_control = CInt(.Item("id_control"))
                                _Actividad_proyecto.id_controlador_1 = CInt(.Item("id_controlador_1"))
                                _Actividad_proyecto.id_controlador_2 = CInt(.Item("id_controlador_2"))
                                _Actividad_proyecto.Guardar()
                            End With
                        End If

                        .id_proyect_manager = 0
                        .id_actividad_proyecto = _Actividad_proyecto.id_actividad_proyecto
                        .id_usuario_anterior = 0
                        .id_usuario_1 = vgCodigoUsuario
                        .id_usuario_2 = _Actividad_proyecto.id_controlador_1
                        .id_usuario_3 = vgCodigoUsuario
                        .id_usuario_4 = vgCodigoUsuario
                        .id_usuario_5 = _Actividad_proyecto.id_controlador_1
                        .id_usuario_6 = vgCodigoUsuario

                        If _Actividad_proyecto.id_proveedor <> 0 Then

                            .control_prod = True
                            .id_usuario_1 = 0
                            .id_usuario_2 = _Actividad_proyecto.id_controlador_1
                            .id_usuario_3 = 0
                            .id_usuario_4 = 0
                            .id_usuario_5 = _Actividad_proyecto.id_controlador_1
                            .id_usuario_6 = 0

                            With oDetalle_recurso
                                .Cargar()
                                .Modificar(id_detalle_recurso)
                                .realizada = True
                                .Guardar()
                            End With

                        End If

                        .id_control = _Actividad_proyecto.id_control
                        .Guardar()

                    End With

                    Dim odtControl As New DataTable
                    odtControl = oControl.GetAllVoz(_Actividad_proyecto.id_control)

                    'Crea todas las voces del control
                    For Each row As DataRow In odtControl.Rows
                        With oCuerpo_movimiento_voz
                            .Cargar()
                            .Insertar()
                            .id_movimiento_voz = oMovimiento_voz.id_movimiento_voz
                            .id_usuario = vgCodigoUsuario
                            .completado = False
                            .id_voz = CInt(row("id_voz"))
                            If _Actividad_proyecto.id_proveedor <> 0 Then
                                .nc1 = False
                                .ok1 = True
                                .completado = True
                                .completado_pm = False
                                .control1 = True
                                .numero_revision = 1
                                .corresponde = False
                                .id_usuario = 0
                            End If
                            .Guardar()
                        End With
                    Next

                End If

                Me.RealizarControl(oMovimiento_voz.id_movimiento_voz, id_detalle_recurso)

            End If

        End If

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
        Me.LoguearControl(oMovimiento_voz.id_actividad_proyecto)

        Dim frmTemp As New frmControlActividad(oMovimiento_voz.id_actividad_proyecto, id_detalle_recurso, oMovimiento_voz.id_movimiento_voz)
        Me.AddOwnedForm(frmTemp)
        frmTemp.ShowDialog()

        Me.Visible = True
        vgControlLogueo = True
        Me.RefrescarControl()

    End Sub

    Private Sub mostrarNotificacion(ByVal text As String)

        PopupNotifier2.TitleText = "Nueva notificación"
        PopupNotifier2.ContentText = text
        PopupNotifier2.ShowCloseButton = True
        PopupNotifier2.ShowOptionsButton = False
        PopupNotifier2.ShowGrip = True
        PopupNotifier2.Delay = 2500
        PopupNotifier2.AnimationInterval = 10
        PopupNotifier2.AnimationDuration = 1000
        PopupNotifier2.TitlePadding = New Padding(0)
        PopupNotifier2.ContentPadding = New Padding(0)
        PopupNotifier2.ImagePadding = New Padding(10)
        PopupNotifier2.Scroll = True
        PopupNotifier2.Image = My.Resources.write_e_mail

        PopupNotifier2.Popup()
    End Sub
    Private Sub mostrarNotificacion2(ByVal text As String)

        PopupNotifier2.TitleText = "Nueva notificación"
        PopupNotifier2.ContentText = text
        PopupNotifier2.ShowCloseButton = True
        PopupNotifier2.ShowOptionsButton = False
        PopupNotifier2.ShowGrip = True
        PopupNotifier2.Delay = 100000000
        PopupNotifier2.AnimationInterval = 10
        PopupNotifier2.AnimationDuration = 1000
        PopupNotifier2.TitlePadding = New Padding(0)
        PopupNotifier2.ContentPadding = New Padding(0)
        PopupNotifier2.ImagePadding = New Padding(10)
        PopupNotifier2.Scroll = True
        PopupNotifier2.Image = My.Resources.write_e_mail

        PopupNotifier2.Popup()
    End Sub

    Private Sub ts_actividades_usuario_Click(sender As Object, e As EventArgs) Handles ts_actividades_usuario.Click
        Dim form As New frmTipoActividad_Usuario
        form.Show()
    End Sub

    Private Sub btnLoginproyecto_VisibleChanged(sender As Object, e As EventArgs) Handles btnLoginproyecto.VisibleChanged
        If Me.btnLoginproyecto.Visible = True Then
            Me.txtEstadoLogueo.Size = New Size(45, 34)
            Me.txtEstadoLogueo.Location = New Point(120, 9)
        Else
            Me.txtEstadoLogueo.Size = New Size(156, 34)
            Me.txtEstadoLogueo.Location = New Point(9, 9)
        End If
    End Sub

    Private Sub Button4_Click_2(sender As Object, e As EventArgs) Handles Button4.Click
        _task_manager.AsignarProyectoAUsuario(30347, 31)
    End Sub


    Private Sub dgv_tareas_pendientes_MouseDown(sender As Object, e As MouseEventArgs) Handles dgv_tareas_pendientes.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim currentMouseOverRow As Integer
            currentMouseOverRow = dgv_tareas_pendientes.HitTest(e.X, e.Y).RowIndex

            If currentMouseOverRow >= 0 Then
                Me.ts_id_tarea_asignada.Text = "ID: " & dgv_tareas_pendientes.Rows(currentMouseOverRow).Cells("id_detalle_recurso_asignar").Value.ToString()
                cms_tareas_asignadas.Show(dgv_tareas_pendientes, New Point(e.X, e.Y))
            End If
        End If
    End Sub

    Private Sub dgvControl_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvControl.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim currentMouseOverRow As Integer
            currentMouseOverRow = dgvControl.HitTest(e.X, e.Y).RowIndex

            If currentMouseOverRow >= 0 Then
                Me.ts_id_control.Text = "ID: " & dgvControl.Rows(currentMouseOverRow).Cells("id_movimiento_voz_dgv").Value.ToString()
                cms_controles.Show(dgvControl, New Point(e.X, e.Y))
            End If
        End If
    End Sub

    Private Sub dgvControlEspera_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvControlEspera.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim currentMouseOverRow As Integer
            currentMouseOverRow = dgvControlEspera.HitTest(e.X, e.Y).RowIndex

            If currentMouseOverRow >= 0 Then
                Me.ts_id_control.Text = "ID: " & dgvControlEspera.Rows(currentMouseOverRow).Cells("id_movimiento_voz_dgv_espera").Value.ToString()
                cms_controles.Show(dgvControlEspera, New Point(e.X, e.Y))
            End If
        End If
    End Sub

    Private Sub dgvControlesCompletados_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvControlesCompletados.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim currentMouseOverRow As Integer
            currentMouseOverRow = dgvControlesCompletados.HitTest(e.X, e.Y).RowIndex

            If currentMouseOverRow >= 0 Then
                Me.ts_id_control.Text = "ID: " & dgvControlesCompletados.Rows(currentMouseOverRow).Cells("id_movimiento_voz_dgv_completado").Value.ToString()
                cms_controles.Show(dgvControl, New Point(e.X, e.Y))
            End If
        End If
    End Sub

    Private Sub eliminarControlNoAdministrador()

        Me.btn_abajo_proyecto.Visible = False
        Me.btn_arriba_proyecto.Visible = False

        For Each tabs As TabPage In Me.TabControl1.TabPages
            If Not (TabControl1.TabPages.IndexOf(tabs) >= 0 And TabControl1.TabPages.IndexOf(tabs) < 3) Then
                TabControl1.TabPages.Remove(tabs)
            End If
        Next
    End Sub

    Private Sub ts_login_admin_Click(sender As Object, e As EventArgs) Handles ts_login_admin.Click

    End Sub

    Private Sub ts_actualizar_proyecto_admin_Click(sender As Object, e As EventArgs) Handles ts_actualizar_proyecto_admin.Click

    End Sub

    Dim id_proyecto As Integer = 0
    Dim id_subproyecto As Integer = 0
    Dim id_actividad As Integer = 0
    Dim id_actividad_proyecto As Integer = 0
    Dim _ActividadProyecto As New Actividad_proyecto
    Dim _ClsProyecto As New Proyecto
    Dim selected_node_to_modify As TreeNode
    Dim nuevo_proyecto As Boolean = False
    Dim nueva_actividad As Boolean = False
    Dim _Movimiento_Voz As New Movimiento_voz
    Dim selected_rowControl As DataGridViewRow
    Dim _ClsControl As New Control
    Dim _Detalle_Recurso As New Detalle_recurso
    Dim oEstado_Subproyecto As New entEstado_Subproyecto
    Dim ultima_fila_unidad As DataGridViewRow
    Dim cargando_datos As Boolean = True

    Public Sub New(ByVal id_entrada As Integer, ByVal tipo As String)
        If Me.verificarPermiso() = False Then
            Exit Sub
        End If

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        If tipo = "a" Then
            Me.id_actividad_proyecto = id_entrada
        ElseIf tipo = "p" Then
            Me.id_proyecto = id_entrada
        ElseIf tipo = "s" Then
            Me.id_subproyecto = id_entrada
        End If
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Function verificarPermiso() As Boolean
        Dim odt As New DataTable
        odt = oUsuario.GetPermiso_2(vgNombreUsuario)
        For Each dr As DataRow In odt.Rows
            Select Case CStr(dr("formulario"))

                Case "tsAdministrarProyecto"
                    If CBool(dr("habilitado")) = False Then
                        Return False
                    End If
            End Select
        Next
        Return True
    End Function



    Private Sub frmAdministrarSubproyectos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.verificarPermiso() = False Then
            Exit Sub
        End If

        Me.cargarGrillaClientes()
        Me.Load_tree()

        oSubproyecto.Cargar()
        oSubproyecto.Insertar()

        _ClsProyecto.Cargar()
        _ClsProyecto.Insertar()

        _ActividadProyecto.Cargar()
        _ActividadProyecto.Insertar()

        Try
            If id_subproyecto <> 0 Then
                Me.buscarNodoSubproyecto(Me.id_subproyecto)
            ElseIf id_proyecto <> 0 Then
                Me.buscarNodoProyecto(Me.id_proyecto)
            ElseIf id_actividad_proyecto <> 0 Then
                Me.buscarNodo(Me.id_actividad_proyecto)
            End If
            Me.tv_subproyectos_MouseDoubleClick(Nothing, Nothing)
        Catch ex As Exception

        End Try

    End Sub


    Private Sub AgregarProyectoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles tsAgregarProyecto.Click

        Dim odt As New DataTable
        odt = oProyecto.GetOne(Me.id_subproyecto)

        Dim odtUsuario As New DataTable
        odtUsuario = oUsuario.GetCmbPM

        Dim str As String
        Dim n As Integer

        With oProyecto
            .Cargar()
            .Insertar()
            .fecha_fin_real = DateTime.Now
            .fecha_inicio = DateTime.Now
            .id_cliente = CInt(odt.Rows(0).Item("id cliente"))

            If CInt(odt.Rows(0).Item("id controlador 1")) = 1 Then
                .id_controlador_1 = CInt(odtUsuario.Rows(0).Item("id_usuario"))
            Else
                .id_controlador_1 = CInt(odt.Rows(0).Item("id controlador 1"))
            End If

            If CInt(odt.Rows(0).Item("id controlador 2")) = 1 Then
                .id_controlador_2 = CInt(odtUsuario.Rows(0).Item("id_usuario"))
            Else
                .id_controlador_2 = CInt(odt.Rows(0).Item("id controlador 2"))
            End If

            .id_estado = CInt(odt.Rows(0).Item("id estado"))
            .id_proyect_manager = CInt(odt.Rows(0).Item("id proyect manager"))
            .id_proyecto_padre = CInt(odt.Rows(0).Item("id proyecto"))
            .id_piloto = CInt(odt.Rows(0).Item("Id piloto"))
            str = CStr(odt.Rows(0).Item("nombre proyecto"))

            Dim tabla, tabla1 As New DataTable
            tabla = oProyecto.GetAllExiste2(CInt(odt.Rows(0).Item("id proyecto")), str)

            If tabla.Rows.Count > 0 Then
                For i As Integer = 1 To tabla.Rows.Count
                    tabla1 = oProyecto.GetAllExiste2(CInt(odt.Rows(0).Item("id proyecto")), CStr(odt.Rows(0).Item("nombre proyecto")) & "_" & i)
                    If tabla1.Rows.Count = 0 Then
                        n = i
                        Exit For
                    End If
                    i += 1
                Next

                If n <> 0 Then
                    .descripcion = CStr(odt.Rows(0).Item("descripcion")) & "_" & n
                    .nombre_proyecto = CStr(odt.Rows(0).Item("nombre_proyecto")) & "_" & n
                Else
                    .descripcion = CStr(odt.Rows(0).Item("descripcion")) & "_" & tabla.Rows.Count + 1
                    .nombre_proyecto = CStr(odt.Rows(0).Item("nombre proyecto")) & "_" & tabla.Rows.Count + 1
                End If
            Else
                .descripcion = CStr(odt.Rows(0).Item("descripcion")) & "_1"
                .nombre_proyecto = CStr(odt.Rows(0).Item("nombre proyecto")) & "_1"
            End If

            .observacion = CStr(odt.Rows(0).Item("observacion"))

            Dim dt As New DataTable
            dt = oProyecto.GetTree_2(Me.id_subproyecto)
            If dt.Rows.Count > 0 Then
                .indice = dt.Rows.Count + 1
            Else
                .indice = 1
            End If

            .orden = "-"
            .path = CStr(odt.Rows(0).Item("path")) & "-" & CStr(odt.Rows(0).Item("nombre proyecto")) & "_1"
            .prioridad = CDec(odt.Rows(0).Item("prioridad"))
            .total_hora = CDec(odt.Rows(0).Item("total hora"))
            .Guardar()
            Me.id_subproyecto = .id_proyecto
        End With

        Dim frmDetalle As New frmDetalleProyecto

        If Not IsNumeric(Me.id_subproyecto) Then
            Exit Sub
        End If

        BanderaProyecto = 2
        Me.AddOwnedForm(frmDetalle)

        oProyecto.Modificar(Me.id_subproyecto)
        frmDetalle.CargarCombos()
        frmDetalle.ShowDialog()

        If vgbanderaproyecto = True Then
            vgbanderaproyecto = False
        Else
            oProyecto.Borrar(Me.id_proyecto)
            Try
                Dim id_previo As Integer
                id_previo = CInt(Me.TreeView1.SelectedNode.Name)
                Me.id_subproyecto = id_previo
            Catch ex As Exception
            End Try
        End If

        Dim tab As New DataTable
        tab = oUsuario.ConsultarTodo

        'For Each row As DataRow In tab.Rows
        '    With oModificacion_arbol
        '        .Cargar()
        '        .Insertar()
        '        '.id_actividad = Math.Abs(CInt(id_actividad))
        '        '.id_actividad_proyecto = CInt(id_actividad_proyecto)
        '        .id_proyecto = Me.id_subproyecto
        '        .id_usuario = CInt(row("id usuario"))
        '        .nodo_padre = CDec(Me.TreeView1.SelectedNode.Name)
        '        .nombre_modificacion_arbol = "tsAgregarProyecto"
        '        .realizado = False
        '        .tipo_nodo = "p"
        '        .Guardar()
        '    End With
        'Next
    End Sub


    Private Sub ModificarProyectoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles tsModificarProyecto.Click
        Dim frmDetalle As New frmDetalleProyecto

        If Not IsNumeric(Me.id_subproyecto) Then
            Exit Sub
        End If

        BanderaProyecto = 2
        Me.AddOwnedForm(frmDetalle)
        oProyecto.Modificar(Me.id_subproyecto)
        frmDetalle.CargarCombos()
        frmDetalle.ShowDialog()

        Dim odt As New DataTable
        odt = oProyecto.GetOne(Me.id_subproyecto)
        Me.TreeView1.SelectedNode.Text = odt.Rows(0).Item("nombre proyecto").ToString    'oProyecto.nombre_proyecto

        Dim tab As New DataTable
        tab = oUsuario.ConsultarTodo

        For Each row As DataRow In tab.Rows
            With oModificacion_arbol
                .Cargar()
                .Insertar()
                .id_proyecto = Me.id_subproyecto
                .id_usuario = CInt(row("id usuario"))
                .nodo_padre = CDec(Me.TreeView1.SelectedNode.Name)
                .nombre_modificacion_arbol = "tsModificarProyecto"
                .realizado = False
                .tipo_nodo = "p"
                .Guardar()
            End With
        Next
    End Sub

    Private Sub BorrarProyectoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles tsBorrarProyecto.Click
        If Not IsNumeric(Me.id_subproyecto) Then
            Exit Sub
        End If

        If MessageBox.Show("Desea Realmente Eliminar el Registro ", "BORRAR", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
        = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Dim tab As New DataTable
        tab = oUsuario.ConsultarTodo

        For Each row As DataRow In tab.Rows
            With oModificacion_arbol
                .Cargar()
                .Insertar()
                .id_proyecto = Me.id_subproyecto
                .id_usuario = CInt(row("id usuario"))
                .nodo_padre = CDec(Me.TreeView1.SelectedNode.Name)
                .nombre_modificacion_arbol = "tsBorrarProyecto"
                .realizado = False
                .tipo_nodo = "p"
                .nombre = Me.TreeView1.SelectedNode.Text
                .Guardar()
            End With
        Next

        oProyecto.Borrar(Me.id_subproyecto)

        Try
            Dim id_previo As Integer
            id_previo = CInt(Me.TreeView1.SelectedNode.PrevNode.Name)
            Me.id_subproyecto = id_previo
        Catch ex As Exception
        End Try

        TreeView1.Nodes.Remove(TreeView1.SelectedNode)

    End Sub


    Private Sub tsmiModificarActividad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles tsModificarActividad.Click

        Dim frmDetalle As New frmDetalleActividad

        If Not IsNumeric(id_actividad) Or id_actividad = 0 Then
            Exit Sub
        End If

        BanderaActividad = 2
        Me.AddOwnedForm(frmDetalle)

        oActividad.Modificar(Math.Abs(CInt(id_actividad)))

        banderamodifact = 1

        frmDetalle.CargarCombos()
        frmDetalle.ShowDialog()

        Me.TreeView1.SelectedNode.Text = oActividad.nombre_actividad

        Dim odtUsuario As New DataTable
        odtUsuario = oUsuario.ConsultarTodo

        Try
            For Each row As DataRow In odtUsuario.Rows

                If vgCodigoUsuario <> CInt(row("id usuario")) Then
                    With oModificacion_arbol
                        .Cargar()
                        .Insertar()
                        .id_actividad = Math.Abs(CInt(id_actividad))
                        .id_actividad_proyecto = CInt(id_actividad_proyecto)
                        .id_proyecto = Me.id_subproyecto
                        .id_usuario = CInt(row("id usuario"))
                        .nodo = Me.TreeView1.SelectedNode.Index
                        'en vez de guardar el nodo padre guardo este nodo para despues poder modificarle el texto
                        .nodo_padre = CDec(Me.TreeView1.SelectedNode.Name)
                        .nombre_modificacion_arbol = "tsModificarActividad"
                        .realizado = False
                        .tipo_nodo = "a"
                        .Guardar()
                    End With
                End If

            Next
        Catch ex As Exception
        End Try
    End Sub


    Private Sub cargarComboUsuarios()
        Dim odt As DataTable
        Dim usuario_proyecto As New Usuario_Proyecto
        odt = usuario_proyecto.GetCmb(Me.id_proyecto, 0, 1)

        odt.Rows.Add(0, 0, 0, 0, " - Sin selección - ")

        With Me.cmb_usuarios_asignar
            .DataSource = odt
            .DisplayMember = "nombre_usuario"
            .ValueMember = "id_usuario"
            .SelectedValue = 0
        End With

    End Sub



    Private Sub cargarDatosSubproyecto()

        Me.clearTabSubproyecto()

        With oSubproyecto
            .Cargar()
            .Modificar(Me.id_subproyecto)
            .Guardar()
        End With

        'Combobox
        Dim dt As DataTable
        Dim _actividad As New Actividad
        Dim _tipoSubproyecto As New entTipo_Subproyecto()
        Dim _horasSubproyecto As New entHora_Tipo_Subproyecto
        Dim usuario_proyecto As New Usuario_Proyecto
        Dim _Usuarios As New Usuario


        dt = usuario_proyecto.GetCmb(Me.id_proyecto, Me.id_subproyecto, 0)
        Dim dr_index As Integer
        Me.dgv_miembros_subproyecto.Rows.Clear()
        For Each row As DataRow In dt.Rows
            dr_index = Me.dgv_miembros_subproyecto.Rows.Add()
            Me.dgv_miembros_subproyecto.Rows(dr_index).Cells("id_usuario_proyecto_subproyecto").Value = 0
            Me.dgv_miembros_subproyecto.Rows(dr_index).Cells("id_usuario_subproyecto").Value = row.Item("id_usuario")
            Me.dgv_miembros_subproyecto.Rows(dr_index).Cells("nombre_usuario_subproyecto").Value = row.Item("nombre_usuario")
            Me.dgv_miembros_subproyecto.Rows(dr_index).Cells("chk_seleccionado_usuario_subproyecto").Value = False
        Next


        Dim odt As DataTable

        odt = oControl.GetCmb()
        odt.Rows.Add(0, "", 0)

        CType(Me.dgv_controles_subproyecto.Columns("nombre_control_subproyecto"), DataGridViewComboBoxColumn).DataSource = odt
        CType(Me.dgv_controles_subproyecto.Columns("nombre_control_subproyecto"), DataGridViewComboBoxColumn).DisplayMember = "nombre_control"
        CType(Me.dgv_controles_subproyecto.Columns("nombre_control_subproyecto"), DataGridViewComboBoxColumn).ValueMember = "id_control"

        odt = _actividad.GetTipoActividad()
        Me.dgv_controles_subproyecto.Rows.Clear()

        For Each row As DataRow In odt.Rows
            dr_index = Me.dgv_controles_subproyecto.Rows.Add()
            Me.dgv_controles_subproyecto.Rows(dr_index).Cells("id_control_subproyecto").Value = 0
            Me.dgv_controles_subproyecto.Rows(dr_index).Cells("id_tipo_actividad_control_subproyecto").Value = row.Item("id_tipo_actividad")
            Me.dgv_controles_subproyecto.Rows(dr_index).Cells("nombre_actividad_control_subproyecto").Value = row.Item("descripcion")
            Me.dgv_controles_subproyecto.Rows(dr_index).Cells("nombre_control_subproyecto").Value = 0
        Next


        cmb_tipo_subproyecto.DataSource = _tipoSubproyecto.GetCMB_TipoSubproyecto()
        cmb_tipo_subproyecto.DisplayMember = "nombre_tipo_subproyecto"
        cmb_tipo_subproyecto.ValueMember = "id_tipo_subproyecto"

        'Combo Horas tipo Subproyecto
        dt = _tipoSubproyecto.GetHorasTipoProyecto(oSubproyecto.id_tipo_subproyecto)
        cmb_horas_subproyecto.DisplayMember = "nombre"
        cmb_horas_subproyecto.ValueMember = "id_hora_tipo_subproyecto"

        Dim dr As DataRow
        dr = dt.NewRow()
        dr.Item("nombre") = "Otro"
        dr.Item("id_hora_tipo_subproyecto") = 0
        dt.Rows.InsertAt(dr, 0)

        cmb_horas_subproyecto.DataSource = dt

        Me.chk_asignacion_automatica.Checked = oSubproyecto.asignacion_automatica

        'Combo Actividades
        Me.cmb_actividad_subproyecto.DataSource = _actividad.GetTipoActividad()
        Me.cmb_actividad_subproyecto.DisplayMember = "descripcion"
        Me.cmb_actividad_subproyecto.ValueMember = "id_tipo_actividad"
        Me.cmb_actividad_subproyecto.SelectedIndex = 0


        'Combo Prioridades
        '....

        Me.txt_ot_cliente_subproyecto.Text = oSubproyecto.ot_cliente
        Me.txt_nombre_subproyecto.Text = oSubproyecto.nombre

        If oSubproyecto.genera_ot Then
            Me.txt_ot_subproyecto.Text = CompletarCerosCodigo(CStr(oSubproyecto.ObtenerNroOrdenTrabajo(oSubproyecto.id_suproyecto)))
        Else
            Me.txt_ot_subproyecto.Text = CompletarCerosCodigo(CStr(oSubproyecto.ObtenerOTPadre(oSubproyecto.id_suproyecto)))
        End If

        Me.cmb_tipo_subproyecto.SelectedValue = oSubproyecto.id_tipo_subproyecto
        Me.chk_forzar_fecha_inicio.Checked = oSubproyecto.forzada_fecha_inicio_estimada
        Me.chk_forzar_fecha_fin.Checked = oSubproyecto.forzada_fecha_fin_estimada
        Me.dtp_fecha_inicio_estimada_subproyecto.Value = oSubproyecto.fecha_inicio_estimada
        Me.dtp_fecha_fin_estimada_subproyecto.Value = oSubproyecto.fecha_fin_estimada
        Me.cmb_horas_subproyecto.SelectedValue = oSubproyecto.id_hora_tipo_subproyecto
        Me.txt_horas_subproyecto.Text = CStr(oSubproyecto.horas_estimadas)
        Me.cmb_prioridad_subproyecto.SelectedValue = oSubproyecto.id_prioridad
        Me.chk_genera_ot_subproyecto.Checked = oSubproyecto.genera_ot
        Me.cargarActividadesenGrillaSubproyectos()
        Me.cargarControlesPredeterminados()
        Me.PesosCorrectosSubproyceto()
        Me.CargarMiembrosSubroyecto()

        'Controles
        Me.CargarGrillaActividadesControles()

    End Sub

    Private Sub cargarActividadesenGrillaSubproyectos()
        Dim dt As DataTable
        Dim actividad_grilla As New Actividad
        Dim index As Integer

        dt = oActividad_proyecto.GetAllProyecto(0, Me.id_subproyecto, 0)

        dgv_actividades_subproyecto.Rows.Clear()

        For Each row As DataRow In dt.Rows
            With actividad_grilla
                .Cargar()
                .Modificar(CInt(row.Item("id_actividad")))
                index = dgv_actividades_subproyecto.Rows.Add()
                dgv_actividades_subproyecto.Rows(index).Cells("id_actividad_proyecto_dgv_subpr").Value = CInt(row.Item("id_actividad_proyecto").ToString())
                dgv_actividades_subproyecto.Rows(index).Cells("id_actividad_dgv_subpr").Value = CInt(row.Item("id_actividad").ToString())
                dgv_actividades_subproyecto.Rows(index).Cells("id_tipo_actividad_dgv_subpr").Value = CInt(row.Item("id_tipo_actividad").ToString())
                dgv_actividades_subproyecto.Rows(index).Cells("nombre_actividad_dgv_subpr").Value = CStr(oActividad.GetOne(CInt(row.Item("id_actividad").ToString())).Rows(0).Item("nombre_actividad").ToString())
                dgv_actividades_subproyecto.Rows(index).Cells("tipo_actividad_dgv_subpr").Value = oTipo_actividad.GetOne(CInt(row.Item("id_tipo_actividad").ToString())).Rows(0).Item("descripcion").ToString()
                dgv_actividades_subproyecto.Rows(index).Cells("peso_dgv_subpr").Value = CDec(oActividad.GetOne(CInt(row.Item("id_actividad").ToString())).Rows(0).Item("costo_standart").ToString())
            End With
        Next

        Me.PesosCorrectosSubproyceto()

    End Sub

    Private Sub cargarDatosProyecto()
        With _ClsProyecto
            .Cargar()
            .Modificar(Me.id_proyecto)
            If .orden = "0" Then
                .AgregarOT(.id_proyecto)
                .Modificar(.id_proyecto)
            End If
        End With

        Dim dt As DataTable
        Dim _Usuarios As New Usuario

        dt = _Usuarios.GetCmb()
        Dim dr_index As Integer
        Me.dgv_miembros_proyecto.Rows.Clear()
        For Each row As DataRow In dt.Rows
            dr_index = Me.dgv_miembros_proyecto.Rows.Add()
            Me.dgv_miembros_proyecto.Rows(dr_index).Cells("id_usuario_proyecto").Value = 0
            Me.dgv_miembros_proyecto.Rows(dr_index).Cells("id_usuario").Value = row.Item("id_usuario")
            Me.dgv_miembros_proyecto.Rows(dr_index).Cells("nombre_usuario_proyecto").Value = row.Item("nombre_usuario")
            Me.dgv_miembros_proyecto.Rows(dr_index).Cells("chk_seleccionado_usuario_proyecto").Value = False
        Next

        Me.CargarMiembrosProyecto()

        Me.cmb_piloto_proyecto.DataSource = oUsuario.GetCmb()
        Me.cmb_piloto_proyecto.ValueMember = "id_usuario"
        Me.cmb_piloto_proyecto.DisplayMember = "nombre_usuario"

        Me.cmb_pm_proyecto.DataSource = oUsuario.GetCmb()
        Me.cmb_pm_proyecto.ValueMember = "id_usuario"
        Me.cmb_pm_proyecto.DisplayMember = "nombre_usuario"

        Me.cmb_estado_proyecto.DataSource = oEstado_Subproyecto.GetCmb()
        Me.cmb_estado_proyecto.ValueMember = "id_estado_subproyecto"
        Me.cmb_estado_proyecto.DisplayMember = "nombre"
        Me.cmb_estado_proyecto.SelectedIndex = -1

        Dim odt As DataTable
        odt = oUsuario.GetCmb
        With Me.cmb_controlador_1
            .DataSource = odt
            .DisplayMember = "nombre_usuario"
            .ValueMember = "id_usuario"
            .SelectedValue = 8
        End With

        odt = oUsuario.GetCmb
        With Me.cmb_controlador_2
            .DataSource = odt
            .DisplayMember = "nombre_usuario"
            .ValueMember = "id_usuario"
            .SelectedValue = 25
        End With

        Me.clearTabProyecto()

        Me.txt_nombre_proyecto.Text = _ClsProyecto.nombre_proyecto
        Me.txt_ot_proyecto.Text = CompletarCerosCodigo(_ClsProyecto.orden)
        Me.dtp_fecha_inicio_estimada_proyecto.Value = _ClsProyecto.fecha_inicio
        Me.dtp_fecha_fin_estimada_proyecto.Value = _ClsProyecto.fecha_fin_prevista
        Me.txt_descripcion_proyecto.Text = _ClsProyecto.descripcion

        If _ClsProyecto.id_estado <> 0 Then
            Me.cmb_estado_proyecto.SelectedValue = _ClsProyecto.id_estado
        End If

        Try
            Me.cmb_controlador_1.SelectedValue = CInt(_ClsProyecto.id_controlador_1)
            Me.cmb_controlador_2.SelectedValue = CInt(_ClsProyecto.id_controlador_2)
        Catch ex As Exception
            Me.cmb_controlador_1.SelectedValue = 0
            Me.cmb_controlador_2.SelectedValue = 0
        End Try

        Me.cmb_pm_proyecto.SelectedValue = _ClsProyecto.id_proyect_manager
        Me.cmb_piloto_proyecto.SelectedValue = _ClsProyecto.id_piloto
        Me.txt_horas_proyecto.Text = CStr(_ClsProyecto.total_hora)
        Me.cmb_prioridad_proyecto.SelectedValue = _ClsProyecto.prioridad
        Me.chk_archivado_proyecto.Checked = _ClsProyecto.archivado

        'Controles
        Me.CargarGrillaActividadesControles()

        'Anotaciones
        Me.ActualizarGrillaAnotaciones()

    End Sub

    Private Sub CargarHorasUsuarioXUnidad()
        Dim _usuario_Proyecto As New Usuario_Proyecto
        Dim _ClsProyecto As New Proyecto
        Dim _Subproyecto As New entSubproyecto
        Dim dr_index As Integer
        Dim id_subproyecto As Integer = Me.id_subproyecto
        Dim dt_usuarios As DataTable
        Dim suma_usuario, suma_unidad As Double

        Me.dgv_horas_unidades.Rows.Clear()
        Me.dgv_horas_unidades.Columns.Clear()

        Try
            If Me.id_proyecto = 0 And Me.id_subproyecto = 0 Then
                Exit Sub
            Else
                dr_index = Me.dgv_horas_unidades.Columns.Add("id_usuario", "id_usuario")
                Me.dgv_horas_unidades.Columns(dr_index).Visible = False

                Me.dgv_horas_unidades.Columns.Add("nombre_usuario", "Usuario")

                If Me.id_subproyecto = 0 Then
                    id_subproyecto = 1
                    dt_usuarios = _ClsProyecto.GetHorasTrabajadas(Me.id_proyecto)
                Else
                    dt_usuarios = _ClsProyecto.GetHorasTrabajadasSubproyecto(Me.id_subproyecto)
                End If

                Dim dt_subproyecto As DataTable = _Subproyecto.ObtenerPorProyecto(Me.id_proyecto, id_subproyecto)
                For Each row As DataRow In dt_subproyecto.Rows
                    Me.dgv_horas_unidades.Columns.Add(row.Item("id_subproyecto").ToString(), row.Item("nombre").ToString())
                Next
                dr_index = Me.dgv_horas_unidades.Columns.Add("total_horas_usuario", "Total")
                Me.dgv_horas_unidades.Columns(dr_index).DefaultCellStyle.BackColor = System.Drawing.Color.LightGray
                Me.dgv_horas_unidades.Columns(dr_index).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


                For Each row As DataRow In dt_usuarios.Rows
                    dr_index = Me.dgv_horas_unidades.Rows.Add()
                    Me.dgv_horas_unidades.Rows(dr_index).Cells("id_usuario").Value = row.Item("id_usuario")
                    Me.dgv_horas_unidades.Rows(dr_index).Cells("nombre_usuario").Value = row.Item("Usuario")
                    For Each row_subproyecto As DataGridViewColumn In Me.dgv_horas_unidades.Columns
                        If row_subproyecto.Index > 1 And row_subproyecto.Index < Me.dgv_horas_unidades.Columns.Count - 1 Then
                            dt_usuarios = _ClsProyecto.GetHorasTrabajadasSubproyecto(CInt(row_subproyecto.Name))
                            For Each row_horas As DataRow In dt_usuarios.Rows
                                If CInt(row_horas.Item("id_usuario")) = CInt(row.Item("id_usuario")) Then
                                    Me.dgv_horas_unidades.Rows(dr_index).Cells(row_subproyecto.Index).Value = row_horas.Item("Horas").ToString.Replace(".", ",")
                                    suma_usuario = suma_usuario + CDbl(row_horas.Item("Horas"))
                                End If
                            Next
                        End If
                    Next
                    Me.dgv_horas_unidades.Rows(dr_index).Cells("total_horas_usuario").Value = suma_usuario.ToString.Replace(".", ",")
                    suma_usuario = 0
                Next

                If Me.dgv_horas_unidades.Rows.Count > 0 Then
                    dr_index = Me.dgv_horas_unidades.Rows.Add("total_horas_unidad", "Total")
                    Me.dgv_horas_unidades.Rows(dr_index).DefaultCellStyle.BackColor = System.Drawing.Color.LightGray
                    Me.dgv_horas_unidades.Rows(dr_index).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                End If

                For Each column_subproyecto As DataGridViewColumn In Me.dgv_horas_unidades.Columns
                    If column_subproyecto.Index > 1 And column_subproyecto.Index < Me.dgv_horas_unidades.Columns.Count - 1 Then
                        For Each row_horas As DataGridViewRow In Me.dgv_horas_unidades.Rows
                            suma_unidad = suma_unidad + CDbl(row_horas.Cells(column_subproyecto.Index).Value)
                        Next
                        Me.dgv_horas_unidades.Rows(Me.dgv_horas_unidades.Rows.Count - 1).Cells(column_subproyecto.Index).Value = suma_unidad.ToString.Replace(".", ",")
                        suma_unidad = 0
                    End If
                Next
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub CargarDatosAvancesyHoras()
        Dim dt_unidades As DataTable
        Dim dr_index As Integer

        Me.clearTabAvances()
        Me.clearTabHora()

        If _ActividadProyecto.id_actividad_proyecto <> 0 Then
            dt_unidades = New DataTable
        ElseIf Me.oSubproyecto.id_suproyecto <> 0 Then
            dt_unidades = oSubproyecto.ObtenerHijos(Me.oSubproyecto.id_suproyecto)
        Else
            dt_unidades = _ClsProyecto.GetUnidades(Me._ClsProyecto.id_proyecto)
        End If

        For Each row As DataRow In dt_unidades.Rows
            dr_index = dgv_unidades_proyecto.Rows.Add()
            With dgv_unidades_proyecto.Rows(dr_index)
                .Cells("nombre_subproyecto").Value = row.Item("nombre")
                .Cells("id_subproyecto_dgv").Value = row.Item("id_subproyecto")
            End With
        Next

        chk_mostrar_todas_horas.Checked = True
        Me.ActualizarHorasProyecto()

        cargarAvances()
    End Sub

    Private Sub cargarAvances()

        Dim encontrado As Boolean = False
        Dim usuario As DataTable
        Dim dt_unidades As DataTable


        If _ActividadProyecto.id_actividad_proyecto <> 0 Then
            Me.dgv_avance_proyecto.Rows.Clear()
            Exit Sub
        ElseIf Me.oSubproyecto.id_suproyecto <> 0 Then
            dt_unidades = oSubproyecto.ObtenerHijos(Me.oSubproyecto.id_suproyecto)
        Else
            dt_unidades = _ClsProyecto.GetUnidades(Me._ClsProyecto.id_proyecto)
        End If


        For Each row As DataRow In dt_unidades.Rows
            dgv_avance_proyecto.Rows.Add(row.Item("id_subproyecto"), row.Item("nombre"))
        Next

        For Each row As DataGridViewRow In dgv_avance_proyecto.Rows

            'CONCEPTO
            If oSubproyecto.ObtenerAvanceConcepto(CInt(row.Cells("idSubproyecto").Value)).Rows.Count > 0 Then
                For Each row_concepto As DataRow In oSubproyecto.ObtenerAvanceConcepto(CInt(row.Cells("idSubproyecto").Value)).Rows
                    If row.Cells("Unidad").Value.ToString() = row_concepto.Item("nombre_proyecto").ToString() Then

                        If CBool(row_concepto.Item("Concepto")) Then
                            row.Cells("Concepto").Style.BackColor = System.Drawing.Color.Green
                            row.Cells("Concepto").Value = "Completado"
                            row.Cells("resp_concepto").Value = row_concepto.Item("Responsable")
                            row.Cells("id_actividad_proyecto_concepto_avance").Value = row_concepto.Item("id_actividad_proyecto")
                        Else
                            If CBool(row_concepto.Item("control_1")) Then
                                row.Cells("Concepto").Style.BackColor = System.Drawing.Color.SandyBrown
                                row.Cells("Concepto").Value = "En corrección"
                                row.Cells("resp_concepto").Value = row_concepto.Item("Corrector")
                                row.Cells("id_actividad_proyecto_concepto_avance").Value = row_concepto.Item("id_actividad_proyecto")
                            ElseIf Not CBool(row_concepto.Item("control_prod")) Then
                                row.Cells("Concepto").Style.BackColor = System.Drawing.Color.Yellow
                                row.Cells("Concepto").Value = "Control de producción"
                                row.Cells("resp_concepto").Value = row_concepto.Item("Responsable")
                                row.Cells("id_actividad_proyecto_concepto_avance").Value = row_concepto.Item("id_actividad_proyecto")
                            Else
                                row.Cells("Concepto").Style.BackColor = System.Drawing.Color.Orange
                                row.Cells("Concepto").Value = "Control de calidad"
                                row.Cells("resp_concepto").Value = row_concepto.Item("Controlador")
                                row.Cells("id_actividad_proyecto_concepto_avance").Value = row_concepto.Item("id_actividad_proyecto")
                            End If
                        End If

                        encontrado = True
                        Exit For
                    End If
                Next
            End If
            If encontrado = False Then
                row.Cells("Concepto").Value = "Sin completar"
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



                        If CBool(row_preparacion.Item("Preparacion")) Then
                            row.Cells("Preparacion").Style.BackColor = System.Drawing.Color.Green
                            row.Cells("Preparacion").Value = "Completado"
                            row.Cells("resp_preparacion").Value = row_preparacion.Item("Responsable")
                            row.Cells("id_actividad_proyecto_preparacion_avance").Value = row_preparacion.Item("id_actividad_proyecto")
                        Else
                            If CBool(row_preparacion.Item("control_1")) Then
                                row.Cells("Preparacion").Style.BackColor = System.Drawing.Color.SandyBrown
                                row.Cells("Preparacion").Value = "En corrección"
                                row.Cells("resp_preparacion").Value = row_preparacion.Item("Corrector")
                                row.Cells("id_actividad_proyecto_preparacion_avance").Value = row_preparacion.Item("id_actividad_proyecto")
                            ElseIf Not CBool(row_preparacion.Item("control_prod")) Then
                                row.Cells("Preparacion").Style.BackColor = System.Drawing.Color.Yellow
                                row.Cells("Preparacion").Value = "Control de producción"
                                row.Cells("resp_preparacion").Value = row_preparacion.Item("Responsable")
                                row.Cells("id_actividad_proyecto_preparacion_avance").Value = row_preparacion.Item("id_actividad_proyecto")
                            Else
                                row.Cells("Preparacion").Style.BackColor = System.Drawing.Color.Orange
                                row.Cells("Preparacion").Value = "Control de calidad"
                                row.Cells("resp_preparacion").Value = row_preparacion.Item("Controlador")
                                row.Cells("id_actividad_proyecto_preparacion_avance").Value = row_preparacion.Item("id_actividad_proyecto")
                            End If
                        End If
                        encontrado = True
                        Exit For
                    End If
                Next
            End If
            If encontrado = False Then
                row.Cells("Preparacion").Value = "Sin completar"

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


                        If CBool(row_detallado.Item("Detallado")) Then
                            row.Cells("Detallado").Style.BackColor = System.Drawing.Color.Green
                            row.Cells("Detallado").Value = "Completado"
                            row.Cells("resp_detallado").Value = row_detallado.Item("Responsable")
                            row.Cells("id_actividad_proyecto_detallado_avance").Value = row_detallado.Item("id_actividad_proyecto")
                        Else
                            If CBool(row_detallado.Item("control_1")) Then
                                row.Cells("Detallado").Style.BackColor = System.Drawing.Color.SandyBrown
                                row.Cells("Detallado").Value = "En corrección"
                                row.Cells("resp_detallado").Value = row_detallado.Item("Corrector")
                                row.Cells("id_actividad_proyecto_detallado_avance").Value = row_detallado.Item("id_actividad_proyecto")
                            ElseIf Not CBool(row_detallado.Item("control_prod")) Then
                                row.Cells("Detallado").Style.BackColor = System.Drawing.Color.Yellow
                                row.Cells("Detallado").Value = "Control de producción"
                                row.Cells("resp_detallado").Value = row_detallado.Item("Responsable")
                                row.Cells("id_actividad_proyecto_detallado_avance").Value = row_detallado.Item("id_actividad_proyecto")
                            Else
                                row.Cells("Detallado").Style.BackColor = System.Drawing.Color.Orange
                                row.Cells("Detallado").Value = "Control de calidad"
                                row.Cells("resp_detallado").Value = row_detallado.Item("Controlador")
                                row.Cells("id_actividad_proyecto_detallado_avance").Value = row_detallado.Item("id_actividad_proyecto")
                            End If
                        End If
                        encontrado = True
                        Exit For
                    End If
                Next
            End If
            If encontrado = False Then
                row.Cells("Detallado").Value = "Sin completar"

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

    Private Sub cargarDatosActividad()


        Me.cargarComboTipoActividad()
        Me.cargarComboControlesActividad()

        With _ActividadProyecto
            .Cargar()
            .Modificar(Me.id_actividad_proyecto)
        End With

        With _Actividad
            .Cargar()
            .Modificar(Me.id_actividad)
        End With

        With _Tipo_Actividad
            .Cargar()
            .Modificar(_Actividad.id_tipo_actividad)
        End With

        Me.clearTabActividad()
        Me.txtnombre_actividad.Text = _Actividad.nombre_actividad
        Me.cmbtipo_actividad.SelectedValue = _Actividad.id_tipo_actividad
        Me.txt_motivo_actividad.Text = _ActividadProyecto.observacion
        Me.chk_asignada.Checked = _ActividadProyecto.asignada
        Me.chk_forzar_inicio_actividad.Checked = _ActividadProyecto.forzada_fecha_inicio
        Me.chk_forzar_fin_actividad.Checked = _ActividadProyecto.forzada_fecha_fin
        Me.chk_no_conformidad.Checked = _ActividadProyecto.no_conformidad
        Me.chk_ap_asignable.Checked = _ActividadProyecto.asignable


        If Me.chk_no_conformidad.Checked = True Then
            Me.txt_motivo_no_conformidad.Text = _ActividadProyecto.motivo_no_conformidad
        End If


        If _ActividadProyecto.fecha_inicio_real = Nothing = False Then
            Me.dtp_fecha_inicio_real_actividad_proyecto.Value = _ActividadProyecto.fecha_inicio_real
            Me.lbl_fecha_inicio_real_actividad.Visible = True
            Me.dtp_fecha_inicio_real_actividad_proyecto.Visible = True
        Else
            Me.lbl_fecha_inicio_real_actividad.Visible = False
            Me.dtp_fecha_inicio_real_actividad_proyecto.Visible = False
        End If

        If _ActividadProyecto.fecha_fin_real = Nothing = False Then
            Me.dtp_fecha_fin_real_actividad_proyecto.Value = _ActividadProyecto.fecha_fin_real
            Me.lbl_fecha_fin_real_actividad.Visible = True
            Me.dtp_fecha_fin_real_actividad_proyecto.Visible = True
        Else
            Me.lbl_fecha_fin_real_actividad.Visible = False
            Me.dtp_fecha_fin_real_actividad_proyecto.Visible = False
        End If

        Me.txt_peso_actividad.Text = CStr(_Actividad.costo_standart)
        Me.txt_horas_actividad.Text = CStr(_ActividadProyecto.cantidad_hora)
        Me.cmb_prioridad_actividad.SelectedValue = _ActividadProyecto.prioridad
        Me.dtp_inicio_estimado_actividad.Value = _ActividadProyecto.fecha_inicio
        Me.dtp_fin_estimado_actividad.Value = _ActividadProyecto.fecha_fin_previsto

        If _ActividadProyecto.id_control <> 0 Then
            Me.habilitarCombosControlActividad(True)
            Me.chk_tiene_control_actividad.Checked = True
            Me.cmb_control_actividad.SelectedValue = _ActividadProyecto.id_control
            Me.cmb_controlador_1_actividad.SelectedValue = _ActividadProyecto.id_controlador_1
            Me.cmb_controlador_2_actividad.SelectedValue = _ActividadProyecto.id_controlador_2
        Else
            Me.chk_tiene_control_actividad.Checked = False
            Me.habilitarCombosControlActividad(False)
        End If

        If _ActividadProyecto.id_proveedor <> 0 Then
            Me.chk_actividad_proveedor.Checked = True
            Me.cmb_actividad_proveedor.Enabled = True
            Me.cmb_actividad_proveedor.SelectedValue = _ActividadProyecto.id_proveedor
            Me.btn_crear_control_proveedor.Enabled = True
        Else
            Me.chk_actividad_proveedor.Checked = False
            Me.cmb_actividad_proveedor.Enabled = False
            Me.btn_crear_control_proveedor.Enabled = False
        End If

        Me.CargarDatosAsignaciones()

    End Sub

    Private Sub CargarDatosAsignaciones()
        Me.cargarComboUsuarios()
        Me._Detalle_Recurso = New Detalle_recurso

        Dim _Actividad As New Actividad
        With _Actividad
            .Cargar()
            .Modificar(Me.id_actividad)
        End With

        Me.txt_nombre_actividad_asignar.Text = _Actividad.nombre_actividad
        Me.txt_tipo_actividad_Asignar.Text = cmbtipo_actividad.Text
        Me.txt_detalle_asignar.Text = _ActividadProyecto.observacion
        Me.txtnum_cantidad_horas_asignar.Value = 1D

        Me.ActualizarGrillAsignados()

        'Horas
        Dim odtMovimientoHora As New DataTable
        Dim decTotal As Decimal = 0
        Dim decTotalHora As Decimal = 0
        Dim decMinuto As Decimal = 0
        Dim dtInicio As DateTime
        Dim dtFin As DateTime
        Dim dr_index As Integer

        odtMovimientoHora = oCuerpo_movimiento_hora.GetAllPorActividadProyecto(Me.id_actividad_proyecto, 0)

        dgvLogueo_admin.Rows.Clear()

        For Each row As DataRow In odtMovimientoHora.Rows
            dr_index = dgvLogueo_admin.Rows.Add()
            With dgvLogueo_admin.Rows(dr_index)
                .Cells("id_cuerpo_movimiento_hora_login_dgv_admin").Value = row.Item("id_cuerpo_movimiento_hora")
                .Cells("hora_entrada_tarea_admin").Value = row.Item("Inicio")
                .Cells("hora_salida_tarea_admin").Value = row.Item("Fin")
                .Cells("tiempo_tarea_admin").Value = row.Item("Tiempo")
                .Cells("fecha_tarea_admin").Value = row.Item("Fecha")
                .Cells("nombre_usuario_tarea_admin").Value = row.Item("Usuario")
                .Cells("id_movimiento_hora_login_dgv_admin").Value = row.Item("id_movimiento_hora")
            End With
        Next

        Dim hora As String

        For Each row As DataGridViewRow In dgvLogueo_admin.Rows
            hora = row.Cells("tiempo_tarea_admin").Value.ToString()
            hora = TimeSpan.FromSeconds(CDbl(hora)).ToString("hh\:mm\:ss")
            row.Cells("tiempo_tarea_admin").Value = hora
        Next

        For Each row As DataRow In odtMovimientoHora.Rows
            dtInicio = CDate(row("Inicio"))
            dtFin = CDate(row("Fin"))

            'calcula la cantidad de horas trabajadas
            decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtFin)
            decTotal = CDec(FormatNumber(decMinuto / 60, 1))
            decTotalHora = decTotalHora + decTotal
        Next

    End Sub


    Private Sub tv_subproyectos_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TreeView1.MouseDoubleClick
        If es_admin Then
            Me.cargando_datos = True

            Me.id_proyecto = CType(TreeView1.SelectedNode.Tag, stArbol).id_proyecto
            Me.id_subproyecto = CType(TreeView1.SelectedNode.Tag, stArbol).id_subproyecto
            Me.id_actividad = CType(TreeView1.SelectedNode.Tag, stArbol).id_actividad
            Me.id_actividad_proyecto = CType(TreeView1.SelectedNode.Tag, stArbol).id_actividad_proyecto

            If Me.selected_node_to_modify Is Nothing = False Then
                Try
                    selected_node_to_modify.BackColor = System.Drawing.Color.Gainsboro
                Catch ex As Exception

                End Try
            End If

            With _ActividadProyecto
                .Cargar()
                .Insertar()
            End With

            With _ClsProyecto
                .Cargar()
                .Insertar()
            End With

            With oSubproyecto
                .Cargar()
                .Insertar()
            End With

            Me.LimpiarDatosControl()

            If CType(TreeView1.SelectedNode.Tag, stArbol).tipo = "p" Then
                If Me.id_proyecto <> 0 Then
                    Me.clearTabSubproyecto()
                    Me.clearTabActividad()
                    Me.cargarDatosProyecto()
                    Me.CargarDatosAvancesyHoras()
                    TabControl1.SelectedIndex = 3
                    'Me.CargarHorasUsuarioXUnidad()
                End If
            ElseIf CType(TreeView1.SelectedNode.Tag, stArbol).tipo = "s" Then
                If Me.id_subproyecto <> 0 Then
                    Me.cargarDatosProyecto()
                    Me.cargarDatosSubproyecto()
                    Me.CargarDatosAvancesyHoras()
                    Me.clearTabActividad()
                    'Me.CargarHorasUsuarioXUnidad()
                    TabControl1.SelectedIndex = 4
                End If
            ElseIf CType(TreeView1.SelectedNode.Tag, stArbol).tipo = "a" Then
                Me.cargarDatosProyecto()
                Me.clearTabHora()
                Me.clearTabAvances()

                If id_subproyecto <> 0 Then
                    Me.cargarDatosSubproyecto()
                    tab_Subproyecto.Enabled = True

                Else
                    Me.clearTabSubproyecto()
                    tab_Subproyecto.Enabled = False
                End If

                Me.cargarDatosActividad()
                Me.CargarDatosAvancesyHoras()
                TabControl1.SelectedIndex = 5
            End If

            Select Case TabControl1.SelectedIndex
                Case 3
                    tab_Subproyecto.Enabled = False
                    tab_Actividad.Enabled = False
                    tab_asignar_actividad.Enabled = False
                    tab_Proyecto.Enabled = True
                    tabPage_avances.Enabled = True
                    tabPage_horas.Enabled = True
                Case 4
                    tab_Subproyecto.Enabled = True
                    tab_Actividad.Enabled = False
                    tab_asignar_actividad.Enabled = False
                    tab_Proyecto.Enabled = True
                    tabPage_avances.Enabled = True
                    tabPage_horas.Enabled = True
                Case 5
                    tab_Actividad.Enabled = True
                    tab_asignar_actividad.Enabled = True
                    tab_Proyecto.Enabled = True
                    tabPage_avances.Enabled = False
                    tabPage_horas.Enabled = True
            End Select

            selected_node_to_modify = TreeView1.SelectedNode
            Me.TreeView1.SelectedNode.BackColor = System.Drawing.Color.LightGreen
            Me.cargando_datos = False

        End If

    End Sub

    Private Sub DeshabilitarTabs()
        tab_Subproyecto.Enabled = False
        tab_Actividad.Enabled = False
        tab_asignar_actividad.Enabled = False
        tab_Proyecto.Enabled = False
        tab_control.Enabled = False
    End Sub

    Private Sub clearTabActividad()
        Me.txtnombre_actividad.Text = ""
        Me.cmbtipo_actividad.SelectedValue = 0
        Me.txt_motivo_actividad.Text = ""
        Me.chk_asignada.Checked = False
        Me.dtp_fecha_inicio_real_actividad_proyecto.Value = DateTime.Now
        Me.dtp_fecha_fin_real_actividad_proyecto.Value = DateTime.Now
        Me.txt_peso_actividad.Text = ""
        Me.txt_horas_actividad.Text = ""
        Me.cmb_prioridad_actividad.SelectedValue = 0
        Me.dtp_inicio_estimado_actividad.Value = DateTime.Now
        Me.dtp_fin_estimado_actividad.Value = DateTime.Now
    End Sub

    Private Sub clearTabHora()
        Me.dgv_unidades_proyecto.Rows.Clear()

        Me.txtHorasConsumidas.Text = ""
        Me.chk_mostrar_todas_horas.Checked = True
    End Sub

    Private Sub clearTabAvances()
        Me.dgv_avance_proyecto.Rows.Clear()
    End Sub

    Private Sub clearTabProyecto()

        Me.txt_nombre_proyecto.Text = ""
        Me.txt_ot_subproyecto.Text = ""
        Me.dtp_fecha_inicio_estimada_proyecto.Value = Date.Now
        Me.dtp_fecha_fin_estimada_subproyecto.Value = Date.Now
        Me.txt_descripcion_proyecto.Text = ""
        Me.cmb_estado_proyecto.SelectedValue = 0
        Me.cmb_pm_proyecto.SelectedValue = 0
        Me.cmb_piloto_proyecto.SelectedValue = 0
        Me.txt_horas_proyecto.Text = ""
        Me.cmb_prioridad_proyecto.SelectedValue = 0
        Me.chk_archivado_proyecto.Checked = False
    End Sub

    Private Sub clearTabSubproyecto()

        With oSubproyecto
            .Cargar()
            .Insertar()
        End With

        Me.txt_nombre_subproyecto.Text = ""
        Me.txt_ot_subproyecto.Text = ""
        Me.txt_ot_cliente_subproyecto.Text = ""
        Me.cmb_tipo_subproyecto.SelectedValue = 0
        Me.dtp_fecha_inicio_estimada_subproyecto.Value = Date.Now
        Me.dtp_fecha_fin_estimada_subproyecto.Value = Date.Now
        Me.cmb_horas_subproyecto.SelectedValue = 0
        Me.txt_horas_subproyecto.Text = ""
        Me.cmb_prioridad_subproyecto.SelectedValue = 0
        Me.txt_nombre_Actividad_subproyecto.Text = ""
        Me.dgv_actividades_subproyecto.Rows.Clear()
    End Sub


    Private Sub tsAgregarSubproyecto_Click(sender As Object, e As EventArgs) Handles tsAgregarSubproyecto.Click
        Dim odp As New stArbol
        odp = CType(TreeView1.SelectedNode.Tag, stArbol)
        Dim selectedNode As TreeNode
        selectedNode = Me.TreeView1.SelectedNode

        If odp.tipo <> "a" Then

            selectedNode = Me.TreeView1.SelectedNode

            Dim frmNuevo As New frmAgregarSubproyecto(odp.id_proyecto, odp.id_subproyecto)
            frmNuevo.ShowDialog()
            refrescarProyecto()

            Me.TreeView1.SelectedNode = selectedNode
            Me.tv_subproyectos_MouseDoubleClick(Nothing, Nothing)
        Else
            'Seleccionó una actividad, no se puee crear un subproyecto
        End If

    End Sub
    Private Sub tsAgregarSubproyectos_Click(sender As Object, e As EventArgs) Handles tsAgregarSubproyectos.Click
        'MsgBox("Modulo en construccion..")
        Dim odp As New stArbol
        odp = CType(TreeView1.SelectedNode.Tag, stArbol)
        Dim selectedNode As TreeNode
        selectedNode = Me.TreeView1.SelectedNode

        If odp.tipo <> "a" Then

            selectedNode = Me.TreeView1.SelectedNode

            Dim frmNuevo As New frmAgregarSubproyectos(odp.id_proyecto, odp.id_subproyecto)
            frmNuevo.ShowDialog()
            refrescarProyecto()

            Me.TreeView1.SelectedNode = selectedNode
            Me.tv_subproyectos_MouseDoubleClick(Nothing, Nothing)
        Else
            'Seleccionó una actividad, no se puee crear un subproyecto
        End If

    End Sub

    Private Sub btn_agregar_actividad_subproyecto_Click(sender As Object, e As EventArgs) Handles btn_agregar_actividad_subproyecto.Click
        Dim id_actividad_actual As Integer

        With oActividad
            .Cargar()
            .Insertar()

            .id_tipo_actividad = CInt(Me.cmb_actividad_subproyecto.SelectedValue)
            .nombre_actividad = Me.txt_nombre_Actividad_subproyecto.Text
            .costo_standart = CDec(oTipo_actividad.GetOne(CInt(Me.cmb_actividad_subproyecto.SelectedValue)).Rows(0).Item("criticidad").ToString()) 'PESO
            .tiempo_standart = 0
            .Guardar()
            id_actividad_actual = .id_actividad
        End With

        With oActividad_proyecto
            .Cargar()
            .Insertar()
            .avance = 0
            .cantidad_hora = 0
            .complejidad = 0
            .orden = Me.dgv_actividades_subproyecto.Rows.Count
            .fecha_inicio = oSubproyecto.fecha_fin_estimada
            .fecha_fin_previsto = oSubproyecto.fecha_fin_estimada
            .id_cliente = _ClsProyecto.id_cliente
            .id_proyecto = _ClsProyecto.id_proyecto
            .id_subproyecto = oSubproyecto.id_suproyecto
            .id_actividad = id_actividad_actual
            .id_control = 0
            .asignada = False
            .Guardar()

            If oSubproyecto.asignacion_automatica Then
                Dim _Usuario_proyecto As New Usuario_Proyecto
                Dim odt_miembros_subproyectos As DataTable = _Usuario_proyecto.GetCmb(oSubproyecto.id_proyecto, oSubproyecto.id_suproyecto, 1)
                If odt_miembros_subproyectos.Rows.Count = 0 Then
                    odt_miembros_subproyectos = _Usuario_proyecto.GetCmb(oSubproyecto.id_proyecto, oSubproyecto.id_suproyecto, 0)
                    For Each row As DataRow In odt_miembros_subproyectos.Rows
                        With _Detalle_Recurso
                            .Cargar()
                            .Insertar()
                            .realizada = False
                            .tipo = "automatico"
                            .porcentaje_avance = 0
                            .id_actividad_proyecto = oActividad_proyecto.id_actividad_proyecto
                            .motivo = ""
                            .cantidad_hora = oActividad_proyecto.cantidad_hora
                            If .cantidad_hora = 0 Then
                                .cantidad_hora = 0.1D
                            End If
                            .id_usuario = CInt(row.Item("id_usuario"))
                            .Guardar()
                        End With
                    Next
                End If
            End If
        End With


        Me.cargarActividadesenGrillaSubproyectos()
        Me.ActualziarArbol(Me.selected_node_to_modify)

    End Sub

    Private Sub ActualziarArbol(ByVal treeNode As TreeNode)
        'Actualizar arbol
        treeNode.Nodes.Clear()
        Me.cargarProyecto(treeNode)
    End Sub

    Private Sub cargarComboTipoActividad()
        Me.cmbtipo_actividad.DataSource = oActividad.GetTipoActividad()
        Me.cmbtipo_actividad.ValueMember = "id_tipo_actividad"
        Me.cmbtipo_actividad.DisplayMember = "descripcion"
    End Sub

    Private Sub btn_guardar_proyecto_Click(sender As Object, e As EventArgs) Handles btn_guardar_proyecto.Click
        Dim existe As Boolean = True

        With oProyecto
            .Cargar()
            .Modificar(Me.id_proyecto)
            .archivado = chk_archivado_proyecto.Checked
            .descripcion = txt_descripcion_proyecto.Text
            .fecha_fin_prevista = dtp_fecha_fin_estimada_proyecto.Value
            '.fecha_fin_real = 
            .fecha_inicio = dtp_fecha_inicio_estimada_proyecto.Value
            '.id_cliente = 
            .id_controlador_1 = CInt(Me.cmb_controlador_1.SelectedValue)
            .id_controlador_2 = CInt(Me.cmb_controlador_2.SelectedValue)
            '.id_estado
            .id_piloto = CInt(cmb_piloto_proyecto.SelectedValue)
            .id_proyect_manager = CInt(cmb_pm_proyecto.SelectedValue)
            .id_proyecto_padre = 1
            .nombre_proyecto = txt_nombre_proyecto.Text
            '.nro
            '.observacion = 
            .prioridad = CInt(cmb_prioridad_proyecto.SelectedValue)
            .total_hora = CInt(txt_horas_proyecto.Value)
            '.orden = txt_ot_proyecto.Text
            existe = .Exist()

            MessageBox.Show("Datos actualizados correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'End If
            .Guardar()
        End With

        'Actualiza los datos de las anotaciones
        Me.ActualizarDatosAnotaciones()

        Me.TreeView1.Nodes.Find(CStr(oProyecto.id_proyecto), False).First().Text = oProyecto.nombre_proyecto
    End Sub

    Private Sub AgregarNuevoProyectoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarNuevoProyectoToolStripMenuItem.Click
        Me.nuevo_proyecto = True
        With oProyecto
            .Cargar()
            .Insertar()
            .nombre_proyecto = "Nuevo Proyecto"
            .id_cliente = CInt(cmb_cliente.SelectedValue)
            .id_controlador_1 = 8
            .id_controlador_2 = 25
            .Guardar()
            .AgregarOT(.id_proyecto)
        End With

        Me.clearTabActividad()
        Me.clearTabSubproyecto()
        Me.clearTabProyecto()

        Me.TreeView1.SelectedNode = Me.addNodoProyecto(oProyecto.nombre_proyecto, oProyecto.id_proyecto)
        Me.tv_subproyectos_MouseDoubleClick(Nothing, Nothing)
        Me.TabControl1.SelectedIndex = 0
    End Sub

    Private Function addNodoProyecto(ByVal nombre_proyecto As String, ByVal id_proyecto As Integer) As TreeNode
        Dim tnParent As New TreeNode()
        Dim odr As New stArbol

        tnParent.Text = nombre_proyecto
        tnParent.Name = id_proyecto.ToString()

        tnParent.ImageIndex = 0

        odr.tipo = "p"
        odr.id_proyecto = id_proyecto
        odr.id_actividad = 0
        odr.id_actividad_proyecto = 0
        odr.id_cliente = CInt(cmb_cliente.SelectedValue)
        odr.icono = 0
        odr.id_subproyecto = 0

        tnParent.Tag = odr

        TreeView1.Nodes.Add(tnParent)

        Return tnParent
    End Function

    Private Sub cmb_horas_subproyecto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_horas_subproyecto.SelectedIndexChanged
        Try
            If CInt(cmb_horas_subproyecto.SelectedValue) <> 0 Then
                Dim _Hora_Tipo_Subproyecto As New entHora_Tipo_Subproyecto
                Me.txt_horas_subproyecto.Text = CStr(_Hora_Tipo_Subproyecto.GetOne(CInt(cmb_horas_subproyecto.SelectedValue)).horas)
                Me.txt_horas_subproyecto.Enabled = False
            Else
                Me.txt_horas_subproyecto.Text = CStr(oSubproyecto.horas_estimadas)
                Me.txt_horas_subproyecto.Enabled = True
                Me.txt_horas_subproyecto.Focus()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmb_actividad_subproyecto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_actividad_subproyecto.SelectedIndexChanged
        Try
            Dim _tipo_actividad As New Tipo_actividad
            Me.txt_nombre_Actividad_subproyecto.Text = _tipo_actividad.GetOne(CInt(cmb_actividad_subproyecto.SelectedValue)).Rows(0).Item("descripcion").ToString()
            Me.txt_nombre_Actividad_subproyecto.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Function PesosCorrectosSubproyceto() As Boolean

        Dim total_peso As Decimal = 0

        For Each row As DataGridViewRow In dgv_actividades_subproyecto.Rows
            total_peso = total_peso + CDec(row.Cells("Peso_dgv_subpr").Value)
        Next

        Me.lbl_suma_pesos_subproyecto.Text = total_peso.ToString("0.00")

        If (total_peso < 99 Or total_peso > 101) And total_peso <> 0 Then
            Me.btn_guardar_subproyecto.Enabled = False
            Me.lbl_suma_pesos_subproyecto.ForeColor = System.Drawing.Color.OrangeRed
        Else
            Me.btn_guardar_subproyecto.Enabled = True
            Me.lbl_suma_pesos_subproyecto.ForeColor = System.Drawing.Color.Green
        End If

        If total_peso > 99 Or total_peso = 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub actualizarPesosSubproyecto()

        Dim total_peso As Decimal = 0

        For Each row As DataGridViewRow In dgv_actividades_subproyecto.Rows
            total_peso = total_peso + CDec(row.Cells("Peso_dgv_subpr").Value)
        Next

        For Each row As DataGridViewRow In dgv_actividades_subproyecto.Rows
            row.Cells("Peso_dgv_subpr").Value = CDec(row.Cells("Peso_dgv_subpr").Value) / total_peso * 100
        Next

    End Sub


    Private Sub btn_guardar_subproyecto_Click(sender As Object, e As EventArgs) Handles btn_guardar_subproyecto.Click
        If PesosCorrectosSubproyceto() Then
            'Guardar
            With oSubproyecto
                .Cargar()
                .Modificar(.id_suproyecto)
                .fecha_fin_estimada = dtp_fecha_fin_estimada_subproyecto.Value
                .fecha_inicio_estimada = dtp_fecha_inicio_estimada_subproyecto.Value
                .id_tipo_subproyecto = CInt(cmb_tipo_subproyecto.SelectedValue)
                .ot = CInt(Me.txt_ot_subproyecto.Text)
                .ot_cliente = Me.txt_ot_cliente_subproyecto.Text
                .horas_estimadas = CInt(Me.txt_horas_subproyecto.Text)
                .forzada_fecha_inicio_estimada = Me.chk_forzar_fecha_inicio.Checked
                .forzada_fecha_fin_estimada = Me.chk_forzar_fecha_fin.Checked
                '.id_proyecto
                '.observaciones
                '.id_estado_proyecto
                .genera_ot = chk_genera_ot_subproyecto.Checked
                .id_hora_tipo_subproyecto = CInt(cmb_horas_subproyecto.SelectedValue)
                .nombre = Me.txt_nombre_subproyecto.Text
                .Guardar()
            End With

            'Actualiza lso pesos de las actividades
            For Each row As DataGridViewRow In dgv_actividades_subproyecto.Rows
                With oActividad
                    .Cargar()
                    .Modificar(CInt(row.Cells("id_actividad_dgv_subpr").Value))
                    .costo_standart = CDec(row.Cells("peso_dgv_subpr").Value)
                    .Guardar()
                End With

                With oActividad_proyecto
                    .Cargar()
                    .Modificar(CInt(row.Cells("id_actividad_proyecto_dgv_subpr").Value))
                    .orden = row.Index + 1
                    .cantidad_hora = oActividad.costo_standart * oSubproyecto.horas_estimadas / 100
                    .Guardar()
                End With
            Next

            For Each row As DataGridViewRow In Me.dgv_controles_subproyecto.Rows
                Dim _Control_Subproyecto As New Control_Subproyecto
                With _Control_Subproyecto
                    .Cargar()
                    If CInt(row.Cells("id_control_subproyecto").Value) <> 0 Then
                        .Modificar(CInt(row.Cells("id_control_subproyecto").Value))
                        .id_control = CInt(row.Cells("nombre_control_subproyecto").Value)
                        .id_subproyecto = Me.id_subproyecto
                        .id_tipo_actividad = CInt(row.Cells("id_tipo_actividad_control_subproyecto").Value)
                        If row.Cells("nombre_control_subproyecto").Value IsNot Nothing Then
                            If CInt(row.Cells("nombre_control_subproyecto").Value) <> 0 Then
                                .Guardar()
                            Else
                                .Borrar(CInt(row.Cells("id_control_subproyecto").Value))
                            End If
                        Else
                            .Borrar(CInt(row.Cells("id_control_subproyecto").Value))
                        End If
                    Else
                        If row.Cells("nombre_control_subproyecto").Value IsNot Nothing Then
                            If CInt(row.Cells("nombre_control_subproyecto").Value) <> 0 Then
                                .Insertar()
                                .id_control = CInt(row.Cells("nombre_control_subproyecto").Value)
                                .id_subproyecto = Me.id_subproyecto
                                .id_tipo_actividad = CInt(row.Cells("id_tipo_actividad_control_subproyecto").Value)
                                .Guardar()
                            End If
                        End If
                    End If

                End With
            Next
            Me.cargarControlesPredeterminados()
            Me.TreeView1.Nodes.Find(CStr(oSubproyecto.id_suproyecto), True).First().Text = oSubproyecto.nombre
            MessageBox.Show("Datos actualizados correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            MessageBox.Show("Los pesos asignados a las actividades no suman 100%. Cambie los datos e intente nuevamente", "Pesos de actividades", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub dgv_actividades_subproyecto_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_actividades_subproyecto.CellEndEdit
        PesosCorrectosSubproyceto()
    End Sub

    Private Sub btn_arriba_actividad_Click(sender As Object, e As EventArgs) Handles btn_arriba_actividad.Click
        If dgv_actividades_subproyecto.Rows.Count > 1 Then
            Dim _Actividad_tipo_proyecto As New entActividad_Tipo_Subproyecto
            Dim selected_index = Me.dgv_actividades_subproyecto.SelectedRows(0).Index

            If selected_index > 0 Then
                With oActividad_proyecto
                    .Cargar()
                    .Modificar(CInt(Me.dgv_actividades_subproyecto.SelectedRows(0).Cells("id_actividad_proyecto_dgv_subpr").Value))
                    .orden = selected_index
                    .Guardar()

                    .Cargar()
                    .Modificar(CInt(Me.dgv_actividades_subproyecto.Rows(selected_index - 1).Cells("id_actividad_proyecto_dgv_subpr").Value))
                    .orden = selected_index + 2
                    .Guardar()
                End With

                Me.cargarActividadesenGrillaSubproyectos()

                If CType(selected_node_to_modify.Tag, stArbol).tipo = "a" Then
                    Dim key As String = CStr(CDec(CType(selected_node_to_modify.Tag, stArbol).id_actividad) * -1)
                    Dim nodo_parent As TreeNode = Me.selected_node_to_modify.Parent
                    Me.ActualziarArbol(nodo_parent)
                    Me.selected_node_to_modify = Me.TreeView1.Nodes.Find(key, True).First()
                    Me.selected_node_to_modify.BackColor = System.Drawing.Color.LightGreen
                    Me.TreeView1.SelectedNode = Me.selected_node_to_modify
                Else
                    Me.ActualziarArbol(Me.selected_node_to_modify)
                End If

                Me.dgv_actividades_subproyecto.ClearSelection()
                Me.dgv_actividades_subproyecto.Rows(selected_index - 1).Selected = True
            End If
        End If
    End Sub

    Private Sub btn_abajo_actividad_Click(sender As Object, e As EventArgs) Handles btn_abajo_actividad.Click
        If dgv_actividades_subproyecto.Rows.Count > 1 Then
            Dim _Actividad_tipo_proyecto As New entActividad_Tipo_Subproyecto
            Dim selected_index = Me.dgv_actividades_subproyecto.SelectedRows(0).Index
            Dim id_seleccionado As Integer = CInt(Me.dgv_actividades_subproyecto.SelectedRows(0).Cells("id_actividad_proyecto_dgv_subpr").Value)

            If selected_index < Me.dgv_actividades_subproyecto.Rows.Count - 1 Then
                With oActividad_proyecto
                    .Cargar()
                    .Modificar(id_seleccionado)
                    .orden = selected_index + 2
                    .Guardar()

                    .Cargar()
                    .Modificar(CInt(Me.dgv_actividades_subproyecto.Rows(selected_index + 1).Cells("id_actividad_proyecto_dgv_subpr").Value))
                    .orden = selected_index
                    .Guardar()
                End With

                Me.cargarActividadesenGrillaSubproyectos()

                If CType(selected_node_to_modify.Tag, stArbol).tipo = "a" Then
                    Dim key As String = CStr(CDec(CType(selected_node_to_modify.Tag, stArbol).id_actividad) * -1)
                    Dim nodo_parent As TreeNode = Me.selected_node_to_modify.Parent
                    Me.ActualziarArbol(nodo_parent)
                    Me.selected_node_to_modify = Me.TreeView1.Nodes.Find(key, True).First()
                    Me.selected_node_to_modify.BackColor = System.Drawing.Color.LightGreen
                    Me.TreeView1.SelectedNode = Me.selected_node_to_modify
                Else
                    Me.ActualziarArbol(Me.selected_node_to_modify)
                End If

                Me.dgv_actividades_subproyecto.ClearSelection()
                Me.dgv_actividades_subproyecto.Rows(selected_index + 1).Selected = True
            End If
        End If
    End Sub

    Private Sub ts_borrar_actividad_subproyecto_Click(sender As Object, e As EventArgs) Handles ts_borrar_actividad_subproyecto.Click
        If dgv_actividades_subproyecto.SelectedRows.Count > 0 Then

            With oActividad_proyecto
                .Cargar()
                If (.HayHorasCargadas(CInt(dgv_actividades_subproyecto.SelectedRows(0).Cells("id_actividad_proyecto_dgv_subpr").Value))) Then
                    MessageBox.Show("Hay horas logueadas en la actividad seleccionada. No se puede borrar.", "Horas logueadas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            End With

            With oActividad_proyecto
                .Cargar()
                .Borrar(CInt(dgv_actividades_subproyecto.SelectedRows(0).Cells("id_actividad_proyecto_dgv_subpr").Value))
            End With

            With oActividad
                .Cargar()
                .Borrar(CInt(dgv_actividades_subproyecto.SelectedRows(0).Cells("id_actividad_dgv_subpr").Value))
            End With

            'las tareas
            Dim _Detalle_Recurso As New Detalle_recurso
            Dim odt As New DataTable
            odt = _Detalle_Recurso.GetCmb()
            For Each row As DataRow In odt.Rows
                If CInt(row.Item("id_actividad_proyecto")) = CInt(dgv_actividades_subproyecto.SelectedRows(0).Cells("id_actividad_proyecto_dgv_subpr").Value) Then
                    With _Detalle_Recurso
                        .Cargar()
                        .Borrar(CInt(row.Item("id_detalle_recurso")))
                    End With
                End If
            Next

            Me.ActualziarArbol(selected_node_to_modify)
            Me.cargarActividadesenGrillaSubproyectos()
            Me.PesosCorrectosSubproyceto()

        End If
    End Sub

    Private Sub dgv_actividades_subproyecto_MouseDown(sender As Object, e As MouseEventArgs) Handles dgv_actividades_subproyecto.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim currentMouseOverRow As Integer
            currentMouseOverRow = dgv_actividades_subproyecto.HitTest(e.X, e.Y).RowIndex

            If currentMouseOverRow >= 0 Then
                dgv_actividades_subproyecto.ClearSelection()
                dgv_actividades_subproyecto.Rows(currentMouseOverRow).Selected = True
                ts_actividades_subproyectos.Show(dgv_actividades_subproyecto, New Point(e.X, e.Y))
            End If
        End If
    End Sub

    Private Sub btn_guardar_Actividad_Click(sender As Object, e As EventArgs) Handles btn_guardar_Actividad.Click

        Dim _Actividad As New Actividad

        'If Me.chk_tiene_control_actividad.Checked = False And Me.chk_actividad_proveedor.Checked = True Then
        '    MessageBox.Show("Si la actividad es de proveedor, debe ingresar un control", "Ingrese control", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Exit Sub
        'End If

        If Me.chk_actividad_proveedor.Checked = True And Me.cmb_actividad_proveedor.SelectedValue Is Nothing Then
            MessageBox.Show("Por favor, seleccione el proveedor", "Seleccione proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Me.chk_no_conformidad.Checked Then
            If Me.txt_motivo_no_conformidad.Text = "" Then
                MessageBox.Show("Debe ingresar el motivo de la no conformidad", "No conformidad", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If

        With _ActividadProyecto
            .Cargar()
            .Modificar(Me.id_actividad_proyecto)
            .observacion = Me.txt_motivo_actividad.Text
            .fecha_inicio = Me.dtp_inicio_estimado_actividad.Value
            .fecha_fin_previsto = Me.dtp_fin_estimado_actividad.Value
            .cantidad_hora = CDec(Me.txt_horas_actividad.Text)
            .prioridad = CInt(Me.cmb_prioridad_actividad.SelectedValue)
            .forzada_fecha_inicio = CBool(Me.chk_forzar_inicio_actividad.Checked)
            .forzada_fecha_fin = CBool(Me.chk_forzar_fin_actividad.Checked)
            .asignable = CBool(Me.chk_ap_asignable.Checked)



            If Me.chk_actividad_proveedor.Checked Then
                .id_proveedor = CInt(Me.cmb_actividad_proveedor.SelectedValue)

                Dim _Actividad_proyecto As New Actividad_proyecto

                .asignada = True

                'With _Detalle_Recurso
                '    .Cargar()
                '    .Insertar()
                '    .cantidad_hora = CDec(Me.txt_horas_actividad.Text)
                '    .id_actividad_proyecto = Me.id_actividad_proyecto
                '    .id_usuario = CInt(Me.cmb_controlador_1_actividad.SelectedValue)
                '    .motivo = "Control de proveedor"
                '    .cantidad_hora = 1
                '    .porcentaje_avance = 0
                '    .realizada = False
                '    .tipo = "Control proveedor"
                '    .Guardar()
                'End With
            Else
                .id_proveedor = 0
            End If


            If Me.chk_tiene_control_actividad.Checked Then

                If Me.cmb_control_actividad.SelectedValue Is Nothing Then
                    MessageBox.Show("Seleccione el control de la actividad", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                If Me.cmb_controlador_1_actividad.SelectedValue Is Nothing Then
                    MessageBox.Show("Seleccione el controlador 1", "Controlador 1", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                If Me.cmb_controlador_2_actividad.SelectedValue Is Nothing Then
                    MessageBox.Show("Seleccione el controlador 2", "Controlador 2", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                .id_controlador_1 = CInt(Me.cmb_controlador_1_actividad.SelectedValue)
                .id_controlador_2 = CInt(Me.cmb_controlador_2_actividad.SelectedValue)
                .id_control = CInt(Me.cmb_control_actividad.SelectedValue)

            Else
                .id_controlador_1 = 0
                .id_controlador_2 = 0
                .id_control = 0
            End If

            .no_conformidad = Me.chk_no_conformidad.Checked
            If Me.chk_no_conformidad.Checked Then
                .motivo_no_conformidad = txt_motivo_no_conformidad.Text
            Else
                .motivo_no_conformidad = ""
            End If

            .Guardar()

        End With

        With _Actividad
            .Cargar()
            .Modificar(Me.id_actividad)
            .nombre_actividad = Me.txtnombre_actividad.Text
            .id_tipo_actividad = CInt(Me.cmbtipo_actividad.SelectedValue)
            .costo_standart = CDec(Me.txt_peso_actividad.Text)
            .Guardar()
        End With

        Me.CargarDatosAsignaciones()
        Me.txt_nombre_actividad_asignar.Text = Me.txtnombre_actividad.Text
        Me.txt_tipo_actividad_Asignar.Text = Me.cmbtipo_actividad.Text
        Me.txt_detalle_asignar.Text = Me.txt_motivo_actividad.Text
        Me.TreeView1.Nodes.Find("-" + CStr(Me.id_actividad), True).First().Text = _Actividad.nombre_actividad
        MessageBox.Show("Datos actualizados correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    End Sub


    Private Sub tsBorrarSubproyecto_Click(sender As Object, e As EventArgs) Handles tsBorrarSubproyecto.Click
        If IsNothing(TreeView1.SelectedNode) = False Then

            If oSubproyecto.hayLogueos(CInt(CType(Me.TreeView1.SelectedNode.Tag, stArbol).id_subproyecto)) Then
                MessageBox.Show("Hay horas logueadas en el proyecto seleccionado. No se puede borrar.", "Horas logueadas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If MessageBox.Show("Desea Realmente Eliminar el Registro ", "BORRAR", _
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
            = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If

            'Dim tab As New DataTable
            'tab = oUsuario.ConsultarTodo

            'For Each row As DataRow In tab.Rows
            '    With oModificacion_arbol
            '        .Cargar()
            '        .Insertar()
            '        .id_proyecto = CInt(Me.lblid_proyecto.Text)
            '        .id_usuario = CInt(row("id usuario"))
            '        .nodo_padre = CDec(Me.TreeView1.SelectedNode.Name)
            '        .nombre_modificacion_arbol = "tsBorrarProyecto"
            '        .realizado = False
            '        .tipo_nodo = "p"
            '        .nombre = Me.TreeView1.SelectedNode.Text
            '        .Guardar()
            '    End With
            'Next

            oSubproyecto.Borrar(CInt(CType(Me.TreeView1.SelectedNode.Tag, stArbol).id_subproyecto))

            TreeView1.Nodes.Remove(TreeView1.SelectedNode)
        End If
    End Sub

    Private Sub chk_genera_ot_subproyecto_CheckedChanged(sender As Object, e As EventArgs) Handles chk_genera_ot_subproyecto.CheckedChanged

        If oSubproyecto.genera_ot = False And chk_genera_ot_subproyecto.Checked Then

            With oSubproyecto
                .Modificar(.id_suproyecto)
                If .ot = 0 Then
                    oSubproyecto.AgregarOT(.id_suproyecto)
                End If
            End With

            Me.txt_ot_subproyecto.Text = CompletarCerosCodigo(CStr(oSubproyecto.ObtenerNroOrdenTrabajo(oSubproyecto.id_suproyecto)))

        ElseIf oSubproyecto.genera_ot = True And chk_genera_ot_subproyecto.Checked = False Then

            Me.txt_ot_subproyecto.Text = CompletarCerosCodigo(CStr(oSubproyecto.ObtenerOTPadre(oSubproyecto.id_suproyecto)))

        End If

        With oSubproyecto
            .Modificar(.id_suproyecto)
            .genera_ot = chk_genera_ot_subproyecto.Checked
            .Guardar()
        End With

    End Sub

    Function CompletarCerosCodigo(ByVal strCadena As String) As String
        Select Case Len(strCadena)
            Case 1 : strCadena = "0000" + strCadena
            Case 2 : strCadena = "000" + strCadena
            Case 3 : strCadena = "00" + strCadena
            Case 4 : strCadena = "0" + strCadena
            Case 5 : strCadena = strCadena
        End Select

        Return strCadena
    End Function

    Private Sub tsModificarSubproyecto_Click(sender As Object, e As EventArgs) Handles tsModificarSubproyecto.Click
        tv_subproyectos_MouseDoubleClick(Nothing, Nothing)
    End Sub

    'Private Sub buscarNodoSubproyecto(ByVal id_subproyecto As Integer)
    '    Dim nodo As TreeNode
    '    Dim tvn() As TreeNode

    '    Dim id_proyecto, id_cliente As Integer
    '    With oSubproyecto
    '        .Cargar()
    '        .Modificar(id_subproyecto)
    '        id_proyecto = .id_proyecto

    '        oProyecto.Modificar(.id_proyecto)
    '        id_cliente = oProyecto.id_cliente
    '    End With

    '    cmb_cliente.SelectedValue = id_cliente
    '    Load_tree()

    '    Dim tabla As New DataTable
    '    tabla = oProyecto.GetOne_2(id_proyecto)

    '    Dim arr() As Integer
    '    ReDim arr(0)
    '    arr(0) = CInt(tabla.Rows(0).Item("Id_proyecto"))
    '    Dim b As Boolean = True


    '    Dim proy As Integer
    '    tvn = Me.TreeView1.Nodes.Find(CStr(id_proyecto), True)

    '    If tvn.Length = 0 Then

    '        proy = CInt(tabla.Rows(0).Item("Id_proyecto"))
    '        nodo = TreeView1.SelectedNode 'nodo le asigno algo solo para q tome el valor q adquiere en for

    '        Try
    '            For index As Integer = 0 To arr.Count - 1
    '                tvn = Me.TreeView1.Nodes.Find(CStr(arr(index)), True)
    '                If tvn.Length > 0 Then
    '                    For indice As Integer = index To 0 Step -1

    '                        Me.TreeView1.SelectedNode = Me.TreeView1.Nodes.Find(CStr(arr(indice)), True)(0)
    '                        nodo = Me.TreeView1.SelectedNode 'Next
    '                        refrescarProyecto()
    '                    Next
    '                    Exit For
    '                End If
    '            Next
    '        Catch ex As Exception

    '        End Try


    '    Else
    '        Dim nd() As TreeNode = Me.TreeView1.Nodes.Find("-" & id_actividad, True)
    '        If nd.Length = 0 Then
    '            Me.TreeView1.SelectedNode = tvn(0)
    '            refrescarProyecto()
    '        End If
    '    End If

    '    Dim dt As DataTable
    '    dt = oSubproyecto.ObtenerPadres(id_subproyecto)

    '    Dim i As Integer = dt.Rows.Count - 1

    '    For Each row As DataRow In dt.Rows
    '        tvn = Me.TreeView1.Nodes.Find(CStr(dt.Rows(i).Item("id_subproyecto")), True)

    '        Dim nd() As TreeNode = Me.TreeView1.Nodes.Find("-" & id_actividad, True)
    '        If nd.Length = 0 Then
    '            Me.TreeView1.SelectedNode = tvn(0)
    '            refrescarProyecto()
    '        End If

    '        i = i - 1
    '    Next
    'End Sub

    'Private Sub buscarNodo(ByVal id_actividad_proyecto As Integer)
    '    Dim nodo As TreeNode
    '    Dim tvn() As TreeNode

    '    Dim id_actividad, id_proyecto, id_subproyecto, id_cliente As Integer
    '    With oActividad_proyecto
    '        .Cargar()
    '        .Modificar(id_actividad_proyecto)
    '        id_actividad = .id_actividad
    '        id_proyecto = .id_proyecto
    '        id_subproyecto = .id_subproyecto
    '    End With

    '    oProyecto.Modificar(id_proyecto)
    '    id_cliente = oProyecto.id_cliente


    '    cmb_cliente.SelectedValue = id_cliente
    '    Load_tree()

    '    Dim tabla As New DataTable
    '    tabla = oProyecto.GetOne_2(id_proyecto)

    '    Dim arr() As Integer
    '    ReDim arr(0)
    '    arr(0) = CInt(tabla.Rows(0).Item("Id_proyecto"))
    '    Dim padre As Integer = CInt(tabla.Rows(0).Item("Id_proyecto_padre"))
    '    Dim b As Boolean = True



    '    Dim proy As Integer
    '    tvn = Me.TreeView1.Nodes.Find(CStr(id_proyecto), True)

    '    If tvn.Length = 0 Then

    '        proy = CInt(tabla.Rows(0).Item("Id_proyecto"))
    '        nodo = TreeView1.SelectedNode 'nodo le asigno algo solo para q tome el valor q adquiere en for

    '        Try
    '            For index As Integer = 0 To arr.Count - 1
    '                tvn = Me.TreeView1.Nodes.Find(CStr(arr(index)), True)
    '                If tvn.Length > 0 Then
    '                    For indice As Integer = index To 0 Step -1

    '                        Me.TreeView1.SelectedNode = Me.TreeView1.Nodes.Find(CStr(arr(indice)), True)(0)
    '                        nodo = Me.TreeView1.SelectedNode 'Next
    '                        refrescarProyecto()

    '                    Next
    '                    Exit For
    '                End If
    '            Next
    '        Catch ex As Exception

    '        End Try


    '    Else
    '        Dim nd() As TreeNode = Me.TreeView1.Nodes.Find("-" & id_actividad, True)
    '        If nd.Length = 0 Then
    '            Me.TreeView1.SelectedNode = tvn(0)
    '            refrescarProyecto()
    '        End If
    '    End If

    '    If id_subproyecto <> 0 Then
    '        Dim dt As DataTable
    '        dt = oSubproyecto.ObtenerPadres(id_subproyecto)

    '        Dim i As Integer = dt.Rows.Count - 1

    '        For Each row As DataRow In dt.Rows
    '            tvn = Me.TreeView1.Nodes.Find(CStr(dt.Rows(i).Item("id_subproyecto")), True)

    '            Dim nd() As TreeNode = Me.TreeView1.Nodes.Find("-" & id_actividad, True)
    '            If nd.Length = 0 Then
    '                Me.TreeView1.SelectedNode = tvn(0)
    '                refrescarProyecto()
    '            End If

    '            i = i - 1
    '        Next
    '    End If


    '    nodo = GetNodeKeyProyecto(CInt("-" & id_actividad), TreeView1.Nodes)
    '    If nodo IsNot Nothing Then
    '        b = False
    '        TreeView1.SelectedNode = nodo
    '    End If

    'End Sub

    Private Sub buscarNodoProyecto(ByVal id_proyecto As Integer)
        Dim nodo As TreeNode
        Dim tvn() As TreeNode

        Dim id_cliente As Integer

        oProyecto.Modificar(id_proyecto)
        id_cliente = oProyecto.id_cliente


        cmb_cliente.SelectedValue = id_cliente
        Load_tree()

        Dim tabla As New DataTable
        tabla = oProyecto.GetOne_2(id_proyecto)

        Dim arr() As Integer
        ReDim arr(0)
        arr(0) = CInt(tabla.Rows(0).Item("Id_proyecto"))
        Dim b As Boolean = True


        Dim proy As Integer
        tvn = Me.TreeView1.Nodes.Find(CStr(id_proyecto), True)

        If tvn.Length = 0 Then

            proy = CInt(tabla.Rows(0).Item("Id_proyecto"))
            nodo = TreeView1.SelectedNode 'nodo le asigno algo solo para q tome el valor q adquiere en for

            Try
                For index As Integer = 0 To arr.Count - 1
                    tvn = Me.TreeView1.Nodes.Find(CStr(arr(index)), True)
                    If tvn.Length > 0 Then
                        For indice As Integer = index To 0 Step -1

                            Me.TreeView1.SelectedNode = Me.TreeView1.Nodes.Find(CStr(arr(indice)), True)(0)
                            nodo = Me.TreeView1.SelectedNode 'Next
                            refrescarProyecto()

                        Next
                        Exit For
                    End If
                Next
            Catch ex As Exception

            End Try

        Else
            Dim nd() As TreeNode = Me.TreeView1.Nodes.Find("-" & id_actividad, True)
            If nd.Length = 0 Then
                Me.TreeView1.SelectedNode = tvn(0)
                refrescarProyecto()
            End If
        End If


    End Sub

    Private Sub buscarNodoActividadProyecto(ByVal id_actividad_proyecto As Integer)
        Dim nodo As TreeNode
        Dim tvn() As TreeNode

        Dim id_actividad, id_proyecto, id_subproyecto As Integer
        With oActividad_proyecto
            .Cargar()
            .Modificar(id_actividad_proyecto)
            id_actividad = .id_actividad
            id_proyecto = .id_proyecto
            id_subproyecto = .id_subproyecto
        End With


        Dim tabla As New DataTable
        tabla = oProyecto.GetOne_2(id_proyecto)

        Dim arr() As Integer
        ReDim arr(0)
        arr(0) = CInt(tabla.Rows(0).Item("Id_proyecto"))
        Dim padre As Integer = CInt(tabla.Rows(0).Item("Id_proyecto_padre"))
        Dim b As Boolean = True


        Dim proy As Integer
        tvn = Me.TreeView1.Nodes.Find(CStr(id_proyecto), True)

        If tvn.Length = 0 Then

            proy = CInt(tabla.Rows(0).Item("Id_proyecto"))
            nodo = TreeView1.SelectedNode 'nodo le asigno algo solo para q tome el valor q adquiere en for

            Try
                For index As Integer = 0 To arr.Count - 1
                    tvn = Me.TreeView1.Nodes.Find(CStr(arr(index)), True)
                    If tvn.Length > 0 Then
                        For indice As Integer = index To 0 Step -1

                            Me.TreeView1.SelectedNode = Me.TreeView1.Nodes.Find(CStr(arr(indice)), True)(0)
                            nodo = Me.TreeView1.SelectedNode 'Next
                            refrescarProyecto()

                        Next
                        Exit For
                    End If
                Next
            Catch ex As Exception

            End Try


        Else
            Dim nd() As TreeNode = Me.TreeView1.Nodes.Find("-" & id_actividad, True)
            If nd.Length = 0 Then
                Me.TreeView1.SelectedNode = tvn(0)
                refrescarProyecto()
            End If
        End If

        Dim dt As DataTable
        dt = oSubproyecto.ObtenerPadres(id_subproyecto)

        Dim i As Integer = dt.Rows.Count - 1

        For Each row As DataRow In dt.Rows
            tvn = Me.TreeView1.Nodes.Find(CStr(dt.Rows(i).Item("id_subproyecto")), True)

            Dim nd() As TreeNode = Me.TreeView1.Nodes.Find("-" & id_actividad, True)
            If nd.Length = 0 Then
                Me.TreeView1.SelectedNode = tvn(0)
                refrescarProyecto()
            End If

            i = i - 1
        Next

        nodo = GetNodeKeyProyecto(CInt("-" & id_actividad), TreeView1.Nodes)
        If nodo IsNot Nothing Then
            b = False
            TreeView1.SelectedNode = nodo
        End If


    End Sub

    Private Sub tsmiAgregarActividad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsAgregarActividad.Click

        If TreeView1.SelectedNode IsNot Nothing Then
            Dim odt As stArbol = CType(TreeView1.SelectedNode.Tag, stArbol)
            Dim id_actividad_actual As Integer = 0

            With oActividad
                .Cargar()
                .Insertar()
                .id_tipo_actividad = CInt(oActividad.GetTipoActividad().Rows(0).Item("id_tipo_actividad"))
                .nombre_actividad = "Nueva Actividad" 'CStr(oActividad.GetTipoActividad().Rows(0).Item("descripcion"))
                .costo_standart = 0 ' Peso
                .tiempo_standart = 0
                .Guardar()
                id_actividad_actual = .id_actividad

                With oActividad_proyecto
                    .Cargar()
                    .Insertar()
                    .avance = 0
                    .cantidad_hora = 0
                    .complejidad = 0
                    '.orden = 
                    .fecha_inicio = Date.Now
                    .fecha_fin_previsto = Date.Now
                    .id_cliente = 0
                    .id_proyecto = Me.id_proyecto
                    .id_control = 0
                    If odt.tipo = "s" Then
                        .id_subproyecto = odt.id_subproyecto
                    ElseIf odt.tipo = "p" Then
                        .id_subproyecto = 0
                    End If

                    .id_actividad = id_actividad_actual
                    .Guardar()
                End With
            End With

            Me.refrescarProyecto()
            Me.buscarNodo(oActividad_proyecto.id_actividad_proyecto)
            Me.tv_subproyectos_MouseDoubleClick(Nothing, Nothing)
        End If

    End Sub

    Private Sub tsBorrarActividad_Click(sender As Object, e As EventArgs) Handles tsBorrarActividad.Click
        Dim odt As stArbol = CType(TreeView1.SelectedNode.Tag, stArbol)

        If odt.tipo = "a" Then

            Dim selected_node As TreeNode = TreeView1.SelectedNode.Parent
            Me.TreeView1.SelectedNode = selected_node

            With oActividad_proyecto
                .Cargar()
                If .HayHorasCargadas(odt.id_actividad_proyecto) Then
                    MessageBox.Show("Hay horas logueadas en la actividad seleccionada. No se puede borrar.", "Horas logueadas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            End With

            With oActividad_proyecto
                .Cargar()
                .Borrar(odt.id_actividad_proyecto)
            End With

            With oActividad
                .Cargar()
                .Borrar(odt.id_actividad)
            End With

            'las tareas
            Dim _Detalle_Recurso As New Detalle_recurso
            Dim tareas As New DataTable
            tareas = _Detalle_Recurso.GetCmb()
            For Each row As DataRow In tareas.Rows
                If CInt(row.Item("id_actividad_proyecto")) = odt.id_actividad_proyecto Then
                    With _Detalle_Recurso
                        .Cargar()
                        .Borrar(CInt(row.Item("id_detalle_recurso")))
                    End With
                End If
            Next

            Me.ActualziarArbol(selected_node)
            Me.TreeView1.SelectedNode.Expand()

        End If
    End Sub

    Private Sub btn_arriba_proyecto_Click(sender As Object, e As EventArgs) Handles btn_arriba_proyecto.Click

        If Me.TreeView1.SelectedNode IsNot Nothing Then

            Dim to_modify As Boolean = False
            Dim info As stArbol = CType(Me.TreeView1.SelectedNode.Tag, stArbol)

            If info.tipo = "p" Then

                If selected_node_to_modify IsNot Nothing Then
                    If CType(selected_node_to_modify.Tag, stArbol).id_proyecto = info.id_proyecto Then
                        to_modify = True
                    End If
                End If


                With oProyecto
                    .Cargar()
                    .Modificar(info.id_proyecto)
                    If .nro > 2 Then
                        .nro = .nro - 3
                        .Guardar()
                    Else
                        Me.TreeView1.Focus()
                        Exit Sub
                    End If
                End With

                Me.buscarNodoProyecto(info.id_proyecto)

            ElseIf info.tipo = "s" Then

                If selected_node_to_modify IsNot Nothing Then
                    If CType(selected_node_to_modify.Tag, stArbol).id_subproyecto = info.id_subproyecto Then
                        to_modify = True
                    End If
                End If

                With oSubproyecto
                    .Cargar()
                    .Modificar(info.id_subproyecto)
                    If .orden > 2 Then
                        .orden = .orden - 3
                        .Guardar()
                    Else
                        Me.TreeView1.Focus()
                        Exit Sub
                    End If
                End With

                Me.TreeView1.SelectedNode = Me.TreeView1.SelectedNode.Parent
                Me.refrescarProyecto()
                Me.TreeView1.SelectedNode = Me.TreeView1.Nodes.Find(CStr(info.id_subproyecto), True)(0)

            ElseIf info.tipo = "a" Then

                If selected_node_to_modify IsNot Nothing Then
                    If CType(selected_node_to_modify.Tag, stArbol).id_actividad_proyecto = info.id_actividad_proyecto Then
                        to_modify = True
                    End If
                End If

                With oActividad_proyecto
                    .Cargar()
                    .Modificar(info.id_actividad_proyecto)
                    If .orden > 2 Then
                        .orden = .orden - 3
                        .Guardar()
                    Else
                        Me.TreeView1.Focus()
                        Exit Sub
                    End If
                End With

                Me.TreeView1.SelectedNode = Me.TreeView1.SelectedNode.Parent
                Me.refrescarProyecto()
                Me.TreeView1.SelectedNode = Me.TreeView1.Nodes.Find(CStr(info.id_actividad * -1), True)(0)

            End If

            If to_modify Then
                Me.selected_node_to_modify = Me.TreeView1.SelectedNode
                Me.selected_node_to_modify.BackColor = System.Drawing.Color.LightGreen
            Else
                Me.actualizarColorModificar()
            End If

            Me.TreeView1.Focus()

        End If
    End Sub

    Private Sub btn_abajo_proyecto_Click(sender As Object, e As EventArgs) Handles btn_abajo_proyecto.Click

        If Me.TreeView1.SelectedNode IsNot Nothing Then

            Dim to_modify As Boolean = False
            Dim info As stArbol = CType(Me.TreeView1.SelectedNode.Tag, stArbol)

            If info.tipo = "p" Then

                If selected_node_to_modify IsNot Nothing Then
                    If CType(selected_node_to_modify.Tag, stArbol).id_proyecto = info.id_proyecto Then
                        to_modify = True
                    End If
                End If

                With oProyecto
                    .Cargar()
                    .Modificar(info.id_proyecto)
                    If .nro < Me.TreeView1.GetNodeCount(False) * 2 - 1 Then
                        .nro = .nro + 3
                        .Guardar()
                    Else
                        Me.TreeView1.Focus()
                        Exit Sub
                    End If

                End With

                Me.buscarNodoProyecto(info.id_proyecto)

            ElseIf info.tipo = "s" Then

                If selected_node_to_modify IsNot Nothing Then
                    If CType(selected_node_to_modify.Tag, stArbol).id_subproyecto = info.id_subproyecto Then
                        to_modify = True
                    End If
                End If

                With oSubproyecto
                    .Cargar()
                    .Modificar(info.id_subproyecto)
                    If .orden < Me.TreeView1.SelectedNode.Parent.Nodes.Count * 2 - 1 Then
                        .orden = .orden + 3
                        .Guardar()
                    Else
                        Me.TreeView1.Focus()
                        Exit Sub
                    End If
                End With

                Me.TreeView1.SelectedNode = Me.TreeView1.SelectedNode.Parent
                Me.refrescarProyecto()
                Me.TreeView1.SelectedNode = Me.TreeView1.Nodes.Find(CStr(info.id_subproyecto), True)(0)

            ElseIf info.tipo = "a" Then

                If selected_node_to_modify IsNot Nothing Then
                    If CType(selected_node_to_modify.Tag, stArbol).id_actividad_proyecto = info.id_actividad_proyecto Then
                        to_modify = True
                    End If
                End If

                With oActividad_proyecto
                    .Cargar()
                    .Modificar(info.id_actividad_proyecto)
                    If .orden < Me.TreeView1.SelectedNode.Parent.Nodes.Count * 2 - 1 Then
                        .orden = .orden + 3
                        .Guardar()
                    Else
                        Me.TreeView1.Focus()
                        Exit Sub
                    End If
                End With

                Me.TreeView1.SelectedNode = Me.TreeView1.SelectedNode.Parent
                Me.refrescarProyecto()
                Me.TreeView1.SelectedNode = Me.TreeView1.Nodes.Find(CStr(info.id_actividad * -1), True)(0)

            End If

            If to_modify Then
                Me.selected_node_to_modify = Me.TreeView1.SelectedNode
                Me.selected_node_to_modify.BackColor = System.Drawing.Color.LightGreen
            Else
                Me.actualizarColorModificar()
            End If

            Me.TreeView1.Focus()

        End If

    End Sub

    Private Sub actualizarColorModificar()

        If Me.selected_node_to_modify IsNot Nothing Then
            Dim dt As stArbol = CType(Me.selected_node_to_modify.Tag, stArbol)
            Dim node As TreeNode

            If dt.tipo = "a" Then
                node = Me.TreeView1.Nodes.Find(CStr(dt.id_actividad * -1), True)(0)
            ElseIf dt.tipo = "p" Then
                node = Me.TreeView1.Nodes.Find(CStr(dt.id_proyecto), True)(0)
            ElseIf dt.tipo = "s" Then
                node = Me.TreeView1.Nodes.Find(CStr(dt.id_subproyecto), True)(0)
            End If

            Me.selected_node_to_modify = node
            node.BackColor = System.Drawing.Color.LightGreen

        End If


    End Sub

    Private Sub btn_guardar_actividad_Asignar_Click(sender As Object, e As EventArgs) Handles btn_guardar_actividad_Asignar.Click

        Dim id_detalle_recurso As Integer
        Try
            For Each row As DataGridViewRow In Me.dgv_actividades_asignados.Rows
                id_detalle_recurso = CInt(row.Cells("id_detalle_recurso_asignado").Value)
                With _Detalle_Recurso
                    .Cargar()
                    .Modificar(id_detalle_recurso)
                    .cantidad_hora = CDec(row.Cells("horas_asignado").Value)
                    .motivo = CStr(row.Cells("observacion_asignado").Value)
                    .realizada = CBool(row.Cells("realizada_asignado").Value)
                    .forzada = CBool(row.Cells("forzada_asignado").Value)
                    .fecha_fin = CDate(row.Cells("fecha_fin_detalle_recurso_asignado").Value)
                    .fecha_inicio = CDate(row.Cells("fecha_inicio_detalle_recurso_asignado").Value)
                    .Guardar()
                End With
            Next




            MessageBox.Show("Asignaciones actualizadas correctamente", "Asignación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error en la asignación de la actividad: " + ex.Message, "Asignación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub


    Private Sub btn_guardar_control_Click(sender As Object, e As EventArgs) Handles btn_guardar_control.Click
        Try
            With _Movimiento_Voz
                .Cargar()
                If .id_movimiento_voz <> 0 Then
                    .Modificar(.id_movimiento_voz)
                    .id_usuario_1 = CInt(cmb_control_produccion.SelectedValue)
                    .id_usuario_2 = CInt(cmb_primer_control.SelectedValue)
                    .id_usuario_3 = CInt(cmb_correccion_1.SelectedValue)
                    .id_usuario_4 = CInt(cmb_2do_control_produccion.SelectedValue)
                    .id_usuario_5 = CInt(cmb_segundo_control.SelectedValue)
                    .id_usuario_6 = CInt(cmb_correccion_2.SelectedValue)
                    .Guardar()
                End If
            End With
            MessageBox.Show("Datos actualizados correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al actualizar el control. Error: " & ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarGrillaActividadesControles()
        Dim dt As DataTable
        Dim dr_index As Integer

        dgv_actividades_control.Rows.Clear()

        If oSubproyecto.id_suproyecto <> 0 Then
            dt = oSubproyecto.ObtenerActividadesControl(oSubproyecto.id_suproyecto)
        ElseIf _ClsProyecto IsNot Nothing Then
            dt = _ClsProyecto.ObtenerActividadesControl(_ClsProyecto.id_proyecto)
        Else
            Exit Sub
        End If

        For Each row As DataRow In dt.Rows
            dr_index = dgv_actividades_control.Rows.Add()
            dgv_actividades_control.Rows(dr_index).Cells("id_actividad_control").Value = row.Item("id_actividad")
            dgv_actividades_control.Rows(dr_index).Cells("id_actividad_proyecto_control").Value = row.Item("id_actividad_proyecto")
            dgv_actividades_control.Rows(dr_index).Cells("id_movimiento_voz_control").Value = row.Item("id_movimiento_voz")
            dgv_actividades_control.Rows(dr_index).Cells("nombre_actividad_control").Value = row.Item("nombre_actividad")
            dgv_actividades_control.Rows(dr_index).Cells("control").Value = CBool(row.Item("control"))
            dgv_actividades_control.Rows(dr_index).Cells("completado").Value = CBool(row.Item("completado"))
            dgv_actividades_control.Rows(dr_index).Cells("btn_asignar").Value = "Asignar"
            dgv_actividades_control.Rows(dr_index).Cells("btn_ver_control").Value = "Ver"

            If CBool(row.Item("control")) Then
                dgv_actividades_control.Rows(dr_index).Cells("btn_asignar").ReadOnly = True
                dgv_actividades_control.Rows(dr_index).Cells("btn_ver_control").ReadOnly = False
            Else
                dgv_actividades_control.Rows(dr_index).Cells("btn_asignar").ReadOnly = False
                dgv_actividades_control.Rows(dr_index).Cells("btn_ver_control").ReadOnly = True
            End If

            If _ActividadProyecto.id_actividad_proyecto = CInt(row.Item("id_actividad_proyecto")) Then
                dgv_actividades_control.ClearSelection()
                dgv_actividades_control.Rows(dr_index).Selected = True
                Me.LimpiarDatosControl()
                If CInt(Me.dgv_actividades_control.Rows(dr_index).Cells("id_movimiento_voz_control").Value) <> 0 Then
                    Me.CargarDatosControl()
                End If
            End If


        Next
    End Sub

    Private Sub dgv_actividades_control_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_actividades_control.CellDoubleClick

        If dgv_actividades_control.Rows.Count > 0 Then
            If e.ColumnIndex <> dgv_actividades_control.Columns("btn_asignar").Index And CBool(dgv_actividades_control.Rows(e.RowIndex).Cells("control").Value) = True Then
                Me.CargarDatosControl()
            Else
                Me.selected_rowControl = Nothing
                Me.LimpiarDatosControl()

                If selected_rowControl IsNot Nothing Then
                    For Each cell As DataGridViewCell In selected_rowControl.Cells
                        cell.Style.BackColor = System.Drawing.Color.White
                    Next
                End If
            End If
        End If

    End Sub

    Private Sub CargarDatosControl()

        Me.LimpiarDatosControl()

        If selected_rowControl IsNot Nothing Then
            For Each cell As DataGridViewCell In selected_rowControl.Cells
                cell.Style.BackColor = System.Drawing.Color.White
            Next
        End If

        Me.CargarEstado(CInt(dgv_actividades_control.Rows(Me.dgv_actividades_control.SelectedRows(0).Index).Cells("id_movimiento_voz_control").Value))

        Me.grp_detalle.Enabled = True
        Me.grp_estado.Enabled = True
        Me.grp_responsables.Enabled = True

        Me.selected_rowControl = Me.dgv_actividades_control.Rows(Me.dgv_actividades_control.SelectedRows(0).Index)
        For Each cell As DataGridViewCell In selected_rowControl.Cells
            cell.Style.BackColor = System.Drawing.Color.LightGreen
        Next
    End Sub

    Private Sub CargarEstado(ByVal id_movimiento_voz As Integer)
        Dim dt As DataTable
        dt = _Movimiento_Voz.ObtenerDatos(id_movimiento_voz)

        With _Movimiento_Voz
            .Cargar()
            .Modificar(id_movimiento_voz)
        End With

        If dt.Rows.Count > 0 Then

            Me.btn_borrar_control.Enabled = True
            Me.btn_guardar_control.Enabled = True

            chk_control_produccion.Checked = CBool(dt.Rows(0).Item("control_prod"))
            chk_primer_control.Checked = CBool(dt.Rows(0).Item("control_1"))
            chk_correccion_1.Checked = CBool(dt.Rows(0).Item("control_corr_1"))
            chk_2do_control_produccion.Checked = CBool(dt.Rows(0).Item("control_prod_2"))
            chk_segundo_control.Checked = CBool(dt.Rows(0).Item("control_2"))
            chk_correccion_2.Checked = CBool(dt.Rows(0).Item("control_corr_2"))
            chk_completado.Checked = CBool(dt.Rows(0).Item("completado"))

            Me.cmb_control_produccion.SelectedValue = CInt(dt.Rows(0).Item("id_usuario_1"))
            If chk_control_produccion.Checked Then
                Me.cmb_control_produccion.Enabled = False
            End If

            Me.cmb_primer_control.SelectedValue = CInt(dt.Rows(0).Item("id_usuario_2"))
            If chk_primer_control.Checked Then
                Me.cmb_primer_control.Enabled = False
            End If

            Me.cmb_correccion_1.SelectedValue = CInt(dt.Rows(0).Item("id_usuario_3"))
            If chk_correccion_1.Checked Or chk_completado.Checked Or CBool(dt.Rows(0).Item("pedido_segundo_control")) Then
                Me.cmb_correccion_1.Enabled = False
            End If

            Me.cmb_2do_control_produccion.SelectedValue = CInt(dt.Rows(0).Item("id_usuario_4"))
            If chk_2do_control_produccion.Checked Or chk_completado.Checked Then
                Me.cmb_2do_control_produccion.Enabled = False
            End If

            Me.cmb_segundo_control.SelectedValue = CInt(dt.Rows(0).Item("id_usuario_5"))
            If chk_segundo_control.Checked Or chk_completado.Checked Then
                Me.cmb_segundo_control.Enabled = False
            End If

            Me.cmb_correccion_2.SelectedValue = CInt(dt.Rows(0).Item("id_usuario_6"))
            If chk_correccion_2.Checked Or chk_completado.Checked Then
                Me.cmb_correccion_2.Enabled = False
            End If

        End If

        'Datos abajo de la grilla
        dt = _Movimiento_Voz.ObtenerDatosExtras(id_movimiento_voz)

        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                Me.lbl_nombre_control.Text = .Item("nombre_control").ToString()
                Me.lbl_tipo_actividad.Text = .Item("descripcion").ToString()
                Me.lbl_porcentaje_correcto.Text = FormatNumber(CDbl(.Item("Porcentaje").ToString()), 3) + "%"
                Me.lbl_fecha_inicio_control.Text = .Item("fecha_inicio").ToString()
                Me.lbl_fecha_completado_control.Text = .Item("fecha_completado").ToString()
            End With
        End If

    End Sub

    Private Sub CargarCombos()
        Me.cmb_control_produccion.DataSource = oUsuario.GetCmb()
        Me.cmb_control_produccion.ValueMember = "id_usuario"
        Me.cmb_control_produccion.DisplayMember = "nombre_usuario"
        Me.cmb_control_produccion.SelectedValue = 0

        Me.cmb_primer_control.DataSource = oUsuario.GetCmb()
        Me.cmb_primer_control.ValueMember = "id_usuario"
        Me.cmb_primer_control.DisplayMember = "nombre_usuario"
        Me.cmb_primer_control.SelectedValue = 0

        Me.cmb_correccion_1.DataSource = oUsuario.GetCmb()
        Me.cmb_correccion_1.ValueMember = "id_usuario"
        Me.cmb_correccion_1.DisplayMember = "nombre_usuario"
        Me.cmb_correccion_1.SelectedValue = 0

        Me.cmb_2do_control_produccion.DataSource = oUsuario.GetCmb()
        Me.cmb_2do_control_produccion.ValueMember = "id_usuario"
        Me.cmb_2do_control_produccion.DisplayMember = "nombre_usuario"
        Me.cmb_2do_control_produccion.SelectedValue = 0

        Me.cmb_segundo_control.DataSource = oUsuario.GetCmb()
        Me.cmb_segundo_control.ValueMember = "id_usuario"
        Me.cmb_segundo_control.DisplayMember = "nombre_usuario"
        Me.cmb_segundo_control.SelectedValue = 0

        Me.cmb_correccion_2.DataSource = oUsuario.GetCmb()
        Me.cmb_correccion_2.ValueMember = "id_usuario"
        Me.cmb_correccion_2.DisplayMember = "nombre_usuario"
        Me.cmb_correccion_2.SelectedValue = 0

    End Sub

    Private Sub LimpiarDatosControl()

        Me.lbl_nombre_control.Text = ""
        Me.lbl_fecha_inicio_control.Text = ""
        Me.lbl_fecha_completado_control.Text = ""
        Me.lbl_porcentaje_correcto.Text = ""
        Me.lbl_tipo_actividad.Text = ""

        Me.CargarCombos()

        Me.btn_borrar_control.Enabled = False
        Me.btn_guardar_control.Enabled = False

        Me.grp_detalle.Enabled = False
        Me.grp_estado.Enabled = False
        Me.grp_responsables.Enabled = False

        chk_control_produccion.Checked = False
        chk_primer_control.Checked = False
        chk_correccion_1.Checked = False
        chk_2do_control_produccion.Checked = False
        chk_segundo_control.Checked = False
        chk_correccion_2.Checked = False
        chk_completado.Checked = False

        Me.cmb_control_produccion.Enabled = True
        Me.cmb_primer_control.Enabled = True
        Me.cmb_correccion_1.Enabled = True
        Me.cmb_2do_control_produccion.Enabled = True
        Me.cmb_segundo_control.Enabled = True
        Me.cmb_correccion_2.Enabled = True

        tab_control.Enabled = True

        Me.dgv_actividades_asignados.Rows.Clear()

    End Sub

    Private Sub dgv_actividades_control_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_actividades_control.CellClick

        'Click en botón Ver
        If e.ColumnIndex = dgv_actividades_control.Columns("btn_ver_control").Index Then
            If CBool(dgv_actividades_control.Rows(e.RowIndex).Cells("control").Value) Then
                Try
                    Me.id_movimiento_voz_pdf = CInt(dgv_actividades_control.Rows(e.RowIndex).Cells("id_movimiento_voz_control").Value)
                    Background_pdf.RunWorkerAsync()
                    MessageBox.Show("Este proceso puede demorar. Se abrirá el PDF una vez finalizado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch ex As Exception

                End Try
            Else
                MessageBox.Show("La actividad no posee un control asignado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        ElseIf e.ColumnIndex = dgv_actividades_control.Columns("btn_asignar").Index Then
            If CBool(dgv_actividades_control.Rows(e.RowIndex).Cells("control").Value) = False Then
                Try
                    Dim frm As New frmAgregarControlPM(CInt(dgv_actividades_control.Rows(e.RowIndex).Cells("id_actividad_proyecto_control").Value))
                    frm.ShowDialog()
                    Me.CargarGrillaActividadesControles()
                    Me.TreeView1.SelectedNode = Me.TreeView1.Nodes.Find(CStr(oSubproyecto.id_suproyecto), True).First()
                    Me.refrescarProyecto()
                Catch ex As Exception

                End Try
            Else
                MessageBox.Show("La actividad ya posee un control asignado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub


    Private Sub btn_borrar_control_Click(sender As Object, e As EventArgs) Handles btn_borrar_control.Click
        If Me.selected_rowControl IsNot Nothing Then
            Try
                Dim res As DialogResult
                res = MessageBox.Show("¿Está seguro que desea borrar el control?", "Borrar Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If res = Windows.Forms.DialogResult.Yes Then
                    Dim odtTempCont As New DataTable
                    Me.borrarcontrol()
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub ts_borrar_proyecto_Click(sender As Object, e As EventArgs) Handles ts_borrar_proyecto.Click
        Dim odt As stArbol = CType(TreeView1.SelectedNode.Tag, stArbol)

        If odt.tipo = "p" Then
            If MessageBox.Show("¿Está seguro que desea borrar el proyecto?", "Borrar proyecto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If

            With oProyecto
                .Cargar()
                If .TieneLogueos(odt.id_proyecto) = False Then
                    .BorrarConSubproyectoYActividad(odt.id_proyecto)
                    .Guardar()
                    .Cargar()
                    .Insertar()
                    Me.Load_tree()
                Else
                    MessageBox.Show("No se puede borrar el proyecto porque posee horas trabajadas", "Borrar proyecto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        End If


    End Sub

    Private Sub btn_agregar_anotacion_Click(sender As Object, e As EventArgs) Handles btn_agregar_anotacion.Click

        Dim oAnotacion_Proyecto As New entAnotaciones_Proyecto

        With oAnotacion_Proyecto
            .Cargar()
            .Insertar()
            .mostrar = True
            .resaltar = True
            .descripcion = Me.txt_anotacion.Text
            .orden = 9999
            .fecha = Date.Now
            .id_usuario = vgCodigoUsuario
            .archivado = False
            .id_proyecto = Me.id_proyecto
            .id_actividad_proyecto = 0
            .id_subproyecto = 0
            .Guardar()
        End With

        Me.ActualizarGrillaAnotaciones()
    End Sub

    Private Sub ActualizarGrillaAnotaciones()
        'Cuando se guarda el proyecto
        Dim dr_index As Integer
        Dim odt As New DataTable
        Dim oAnotacion_Proyecto As New entAnotaciones_Proyecto

        odt = oAnotacion_Proyecto.GetFromProyectoAdmin(Me.id_proyecto)

        'Para actualizar de anotaciones
        Me.dgv_anotaciones_proyecto.Rows.Clear()

        For Each row As DataRow In odt.Rows
            With dgv_anotaciones_proyecto
                dr_index = .Rows.Add()
                .Rows(dr_index).Cells("descripcion_anotaciones").Value = row.Item("descripcion").ToString()
                .Rows(dr_index).Cells("mostrar_anotacion").Value = CBool(row.Item("mostrar"))
                .Rows(dr_index).Cells("resaltar_anotacion").Value = CBool(row.Item("resaltar"))
                .Rows(dr_index).Cells("id_proyecto_anotaciones").Value = row.Item("id_proyecto")
                .Rows(dr_index).Cells("id_anotacion").Value = row.Item("id_anotacion")
                .Rows(dr_index).Cells("orden_anotaciones").Value = row.Item("id_anotacion")
                .Rows(dr_index).Cells("fecha_anotaciones").Value = row.Item("fecha")
                .Rows(dr_index).Cells("id_usuario_anotaciones").Value = row.Item("id_usuario")
                .Rows(dr_index).Cells("archivado_anotaciones").Value = row.Item("archivado")
                .Rows(dr_index).Cells("id_actividad_proyecto_anotaciones").Value = row.Item("id_actividad_proyecto")
                .Rows(dr_index).Cells("id_subproyecto_anotaciones").Value = row.Item("id_subproyecto")
            End With
        Next

    End Sub

    Private Sub ActualizarDatosAnotaciones()

        Dim id_anotacion As Integer
        Dim oAnotacion_Proyecto As New entAnotaciones_Proyecto

        For Each row As DataGridViewRow In dgv_anotaciones_proyecto.Rows

            id_anotacion = CInt(row.Cells("id_anotacion").Value)

            'Recorrer para modificar anotaciones
            With oAnotacion_Proyecto
                .Cargar()
                .Modificar(id_anotacion)
                .mostrar = CBool(row.Cells("mostrar_anotacion").Value)
                .resaltar = CBool(row.Cells("resaltar_anotacion").Value)
                .descripcion = row.Cells("descripcion_anotaciones").Value.ToString()
                .orden = row.Index
                .fecha = Date.Now
                .id_usuario = vgCodigoUsuario
                .archivado = False
                .Guardar()
            End With
        Next
    End Sub

    Private Sub CargarGrillaTareasPendientes(ByVal id_usuario As Integer)
        Dim odt As DataTable
        Dim dr_index As Integer
        odt = oDetalle_recurso.GetPendiente(id_usuario)

        Me.dgv_tareas_pendientes_admin.Rows.Clear()

        For Each row As DataRow In odt.Rows
            dr_index = dgv_tareas_pendientes_admin.Rows.Add()
            With dgv_tareas_pendientes_admin.Rows(dr_index)
                .Cells("id_detalle_recurso_asignar_admin").Value = row.Item("id_detalle_recurso").ToString()
                .Cells("id_actividad_proyecto_asignar_admin").Value = row.Item("id_actividad_proyecto").ToString()
                .Cells("id_actividad_asignar_admin").Value = row.Item("id_actividad").ToString()
                .Cells("id_proyecto_asignar_admin").Value = row.Item("id_proyecto").ToString()
                .Cells("motivo_asignar_admin").Value = row.Item("motivo").ToString()
                .Cells("nombre_actividad_asignar_admin").Value = row.Item("nombre_actividad").ToString()
                .Cells("cantidad_hora_asignar_admin").Value = row.Item("cantidad_hora").ToString()
                .Cells("nombre_proyecto_asignar_admin").Value = row.Item("nombre_proyecto").ToString()
                .Cells("nombre_subproyecto_asignar_admin").Value = row.Item("nombre_subproyecto").ToString()
                .Cells("nombre_cliente_asignar_admin").Value = row.Item("nombre_cliente").ToString()
            End With
        Next

    End Sub

    Private Sub cmb_usuarios_asignar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_usuarios_asignar.SelectedIndexChanged
        Try
            Me.dgv_tareas_pendientes_admin.Rows.Clear()
            Me.CargarGrillaTareasPendientes(CInt(cmb_usuarios_asignar.SelectedValue))
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dgv_unidades_proyecto_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_unidades_proyecto.CellDoubleClick
        chk_mostrar_todas_horas.Checked = False

        ActualizarHorasDeUnidad()
    End Sub

    Private Sub chk_mostrar_todas_horas_CheckedChanged(sender As Object, e As EventArgs) Handles chk_mostrar_todas_horas.CheckedChanged
        If chk_mostrar_todas_horas.Checked = True Then
            Me.ActualizarHorasProyecto()
        Else
            ActualizarHorasDeUnidad()
        End If
    End Sub

    Private Sub ActualizarHorasProyecto()
        If Not IsNothing(ultima_fila_unidad) Then
            For Each cell As DataGridViewCell In ultima_fila_unidad.Cells()
                cell.Style.BackColor = System.Drawing.Color.White
            Next
        End If

        Dim dt_horas As DataTable

        Me.dgv_avance_proyecto.Rows.Clear()

        If _ActividadProyecto IsNot Nothing And _ActividadProyecto.id_actividad_proyecto <> 0 Then
            Dim Actividad As New Actividad()
            dt_horas = Actividad.GetHorasTrabajadas(_ActividadProyecto.id_actividad_proyecto)
            Me.txtHorasParciales.Text = "-"
        ElseIf id_subproyecto = 0 Then
            dt_horas = _ClsProyecto.GetHorasTrabajadas(_ClsProyecto.id_proyecto)
            Dim dt As DataTable
            Dim tiempo As TimeSpan = New TimeSpan(0)
            Try

                For Each row As DataRow In dt_horas.Rows
                    dt = oCuerpo_movimiento_hora.GetLogueoDia(CInt(row.Item("id_usuario").ToString()), dtp_fecha_desde.Value, dtp_fecha_hasta.Value, CInt(cmb_cliente.SelectedValue), CInt(_ClsProyecto.id_proyecto))
                    For Each row2 As DataRow In dt.Rows
                        tiempo = tiempo + CDate(row2.Item("Hora Salida")).Subtract(CDate(CDate(row2.Item("Hora Entrada")).ToString("HH:mm:ss")))
                    Next
                Next
            Catch ex As Exception
            End Try
            Me.txtHorasParciales.Text = Me.txtHorasParciales.Text + tiempo.ToString()
            Me.txtHorasParciales.Text = String.Format("{0} horas {1} minutos {2} segundos", _
            CInt(Math.Truncate(tiempo.TotalHours)), _
            tiempo.Minutes, _
            tiempo.Seconds)
        Else
            dt_horas = _ClsProyecto.GetHorasTrabajadasSubproyecto(oSubproyecto.id_suproyecto)
            Me.txtHorasParciales.Text = "-"
        End If


        

        dgv_horas_proyecto.DataSource = dt_horas
        Try
            dgv_horas_proyecto.Columns(2).Visible = False
        Catch ex As Exception

        End Try


        Dim horas As Double = 0
        For Each row As DataGridViewRow In dgv_horas_proyecto.Rows
            horas = horas + CDbl(row.Cells(1).Value.ToString())
        Next

        Me.txtHorasConsumidas.Text = horas.ToString()
    End Sub

    Private Sub ActualizarHorasDeUnidad()
        If dgv_unidades_proyecto.SelectedRows.Count > 0 Then

            If Not IsNothing(ultima_fila_unidad) Then
                For Each cell As DataGridViewCell In ultima_fila_unidad.Cells()
                    cell.Style.BackColor = System.Drawing.Color.White
                Next
            End If

            ultima_fila_unidad = dgv_unidades_proyecto.SelectedRows(0)
            Dim dt_horas As DataTable
            dt_horas = _ClsProyecto.GetHorasTrabajadasSubproyecto(CInt(ultima_fila_unidad.Cells("id_subproyecto_dgv").Value))
            dgv_horas_proyecto.DataSource = dt_horas

            Dim horas As Double = 0
            For Each row As DataGridViewRow In dgv_horas_proyecto.Rows
                horas = horas + CDbl(row.Cells(1).Value.ToString())
            Next

            Me.txtHorasConsumidas.Text = horas.ToString()

            For Each cell As DataGridViewCell In ultima_fila_unidad.Cells()
                cell.Style.BackColor = System.Drawing.Color.GreenYellow
            Next
        End If
    End Sub

    Private Sub dgv_avance_proyecto_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_avance_proyecto.CellDoubleClick
        If Me.dgv_avance_proyecto.SelectedRows.Count > 0 Then
            If e.ColumnIndex = Me.dgv_avance_proyecto.Columns("concepto").Index Or e.ColumnIndex = Me.dgv_avance_proyecto.Columns("resp_concepto").Index Then
                'Seleccionó concepto
                _ClsProyecto = New Proyecto()
                With oSubproyecto
                    .Cargar()
                    .Modificar(CInt(Me.dgv_avance_proyecto.SelectedRows(0).Cells("idSubProyecto").Value))
                End With

                Me.CargarGrillaActividadesControles()
                For Each row As DataGridViewRow In Me.dgv_actividades_control.Rows
                    If Me.dgv_avance_proyecto.SelectedRows(0).Cells("id_actividad_proyecto_concepto_avance").Value Is Nothing Then
                        If row.Cells("nombre_actividad_control").Value.ToString().ToLower().Contains("conc") Then
                            Me.dgv_actividades_control.ClearSelection()
                            Me.dgv_actividades_control.Rows(row.Index).Selected = True
                            Me.LimpiarDatosControl()
                            Me.TabControl1.SelectedIndex = 4
                            Exit Sub
                        End If
                    Else
                        If CInt(row.Cells("id_actividad_proyecto_control").Value) = CInt(Me.dgv_avance_proyecto.SelectedRows(0).Cells("id_actividad_proyecto_concepto_avance").Value) Then
                            Me.dgv_actividades_control.ClearSelection()
                            Me.dgv_actividades_control.Rows(row.Index).Selected = True
                            Me.CargarDatosControl()
                            Me.TabControl1.SelectedIndex = 4
                            Exit Sub
                        End If
                    End If
                Next

            ElseIf e.ColumnIndex = Me.dgv_avance_proyecto.Columns("preparacion").Index Or e.ColumnIndex = Me.dgv_avance_proyecto.Columns("resp_preparacion").Index Then
                'Seleccionó preparacion
                _ClsProyecto = New Proyecto()
                With oSubproyecto
                    .Cargar()
                    .Modificar(CInt(Me.dgv_avance_proyecto.SelectedRows(0).Cells("idSubProyecto").Value))
                End With

                Me.CargarGrillaActividadesControles()
                For Each row As DataGridViewRow In Me.dgv_actividades_control.Rows
                    If Me.dgv_avance_proyecto.SelectedRows(0).Cells("id_actividad_proyecto_preparacion_avance").Value Is Nothing Then
                        If row.Cells("nombre_actividad_control").Value.ToString().ToLower().Contains("prep") Then
                            Me.dgv_actividades_control.ClearSelection()
                            Me.dgv_actividades_control.Rows(row.Index).Selected = True
                            Me.LimpiarDatosControl()
                            Me.TabControl1.SelectedIndex = 4
                            Exit Sub
                        End If
                    Else
                        If CInt(row.Cells("id_actividad_proyecto_control").Value) = CInt(Me.dgv_avance_proyecto.SelectedRows(0).Cells("id_actividad_proyecto_preparacion_avance").Value) Then
                            Me.dgv_actividades_control.ClearSelection()
                            Me.dgv_actividades_control.Rows(row.Index).Selected = True
                            Me.CargarDatosControl()
                            Me.TabControl1.SelectedIndex = 4
                            Exit Sub
                        End If
                    End If
                Next
            ElseIf e.ColumnIndex = Me.dgv_avance_proyecto.Columns("detallado").Index Or e.ColumnIndex = Me.dgv_avance_proyecto.Columns("resp_detallado").Index Then
                'Seleccionó preparacion
                _ClsProyecto = New Proyecto()
                With oSubproyecto
                    .Cargar()
                    .Modificar(CInt(Me.dgv_avance_proyecto.SelectedRows(0).Cells("idSubProyecto").Value))
                End With

                Me.CargarGrillaActividadesControles()
                For Each row As DataGridViewRow In Me.dgv_actividades_control.Rows
                    If Me.dgv_avance_proyecto.SelectedRows(0).Cells("id_actividad_proyecto_detallado_avance").Value Is Nothing Then
                        If row.Cells("nombre_actividad_control").Value.ToString().ToLower().Contains("det") Then
                            Me.dgv_actividades_control.ClearSelection()
                            Me.dgv_actividades_control.Rows(row.Index).Selected = True
                            Me.LimpiarDatosControl()
                            Me.TabControl1.SelectedIndex = 4
                            Exit Sub
                        End If
                    Else
                        If CInt(row.Cells("id_actividad_proyecto_control").Value) = CInt(Me.dgv_avance_proyecto.SelectedRows(0).Cells("id_actividad_proyecto_detallado_avance").Value) Then
                            Me.dgv_actividades_control.ClearSelection()
                            Me.dgv_actividades_control.Rows(row.Index).Selected = True
                            Me.CargarDatosControl()
                            Me.TabControl1.SelectedIndex = 4
                            Exit Sub
                        End If
                    End If
                Next


            End If
        End If
    End Sub

    Private Sub cargarComboControlesActividad()
        Dim odt As New DataTable
        odt = oControl.GetCmb
        With Me.cmb_control_actividad
            .DataSource = odt
            .DisplayMember = "nombre_control"
            .ValueMember = "id_control"
            .SelectedIndex = -1
        End With

        odt = oUsuario.GetCmb
        With Me.cmb_controlador_1_actividad
            .DataSource = odt
            .DisplayMember = "nombre_usuario"
            .ValueMember = "id_usuario"
            .SelectedIndex = -1
        End With

        odt = oUsuario.GetCmb
        With Me.cmb_controlador_2_actividad
            .DataSource = odt
            .DisplayMember = "nombre_usuario"
            .ValueMember = "id_usuario"
            .SelectedIndex = -1
        End With

        odt = oProveedor.GetCmb()
        With Me.cmb_actividad_proveedor
            .DataSource = odt
            .DisplayMember = "nombre_proveedor"
            .ValueMember = "id_proveedor"
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub habilitarCombosControlActividad(ByVal val As Boolean)
        Me.cmb_control_actividad.Enabled = val
        Me.cmb_controlador_1_actividad.Enabled = val
        Me.cmb_controlador_1_actividad.SelectedValue = 8
        Me.cmb_controlador_2_actividad.Enabled = val
        Me.cmb_controlador_2_actividad.SelectedValue = 25
    End Sub

    Private Sub chk_tiene_control_actividad_CheckedChanged(sender As Object, e As EventArgs) Handles chk_tiene_control_actividad.CheckedChanged

        If cargando_datos = False Then
            If chk_tiene_control_actividad.Checked = False And oMovimiento_voz.obtenerMovimientoVozDesdeActividadProyecto(_ActividadProyecto.id_actividad_proyecto) <> 0 Then
                MessageBox.Show("La actividad ya posee un control asignado. Elimínelo e intente nuevamente", "Control existente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.chk_tiene_control_actividad.Checked = True
            Else
                Me.habilitarCombosControlActividad(chk_tiene_control_actividad.Checked)
            End If
        End If
    End Sub

    Private Sub btn_agregar_miembro_proyecto_Click(sender As Object, e As EventArgs) Handles btn_agregar_miembro_proyecto.Click

        If cmb_miembro_proyecto.SelectedValue IsNot Nothing Then
            Dim usuario_proyecto As New Usuario_Proyecto

            With usuario_proyecto
                .Cargar()
                .Insertar()
                .id_proyecto = Me.id_proyecto
                .id_subproyecto = 0
                .id_usuario = CInt(Me.cmb_miembro_proyecto.SelectedValue)
                If usuario_proyecto.Exist() Then
                    Exit Sub
                End If
                .Guardar()
                Me.AgregarAsignacionesMiembro(.id_subproyecto, .id_proyecto, .id_usuario)
            End With
        End If

        Me.CargarMiembrosProyecto()

    End Sub

    Private Sub CargarMiembrosProyecto()
        Dim odt As DataTable
        Dim usuario_proyecto As New Usuario_Proyecto

        odt = usuario_proyecto.GetCmb(Me.id_proyecto, 0, 1)

        'Me.dgv_miembros_proyecto.Rows.Clear()

        For Each row As DataRow In odt.Rows

            For Each row_grid As DataGridViewRow In Me.dgv_miembros_proyecto.Rows
                If CInt(row_grid.Cells("id_usuario").Value) = CInt(row.Item("id_usuario")) Then
                    row_grid.Cells("id_usuario_proyecto").Value = CInt(row.Item("id_usuario_proyecto"))
                    row_grid.Cells("chk_seleccionado_usuario_proyecto").Value = True
                End If
            Next


            'dr_index = Me.dgv_miembros_proyecto.Rows.Add()
            'Me.dgv_miembros_proyecto.Rows(dr_index).Cells("id_usuario_proyecto").Value = row.Item("id_usuario_proyecto")
            'Me.dgv_miembros_proyecto.Rows(dr_index).Cells("id_usuario").Value = row.Item("id_usuario")
            'Me.dgv_miembros_proyecto.Rows(dr_index).Cells("nombre_usuario_proyecto").Value = row.Item("nombre_usuario")

        Next

        If Me.id_subproyecto <> 0 Then
            Me.cargarDatosSubproyecto()
        End If

        'Alan yo saque esto - 12-8-2015
        'If Me.id_actividad_proyecto <> 0 Then
        '    Me.cargarDatosActividad()
        'End If

    End Sub



    Private Sub CargarMiembrosSubroyecto()
        Dim odt As DataTable
        Dim usuario_proyecto As New Usuario_Proyecto
        Dim dr_index As Integer

        odt = usuario_proyecto.GetCmb(Me.id_proyecto, Me.id_subproyecto, 1)


        For Each row As DataRow In odt.Rows

            For Each row_grid As DataGridViewRow In Me.dgv_miembros_subproyecto.Rows
                If CInt(row_grid.Cells("id_usuario_subproyecto").Value) = CInt(row.Item("id_usuario")) Then
                    row_grid.Cells("id_usuario_proyecto_subproyecto").Value = CInt(row.Item("id_usuario_proyecto"))
                    row_grid.Cells("chk_seleccionado_usuario_subproyecto").Value = True
                End If
            Next
        Next


        'Alan yo saque esto - 12-08-2015
        'If Me.id_actividad_proyecto <> 0 Then
        '    Me.cargarDatosActividad()
        'End If

    End Sub


    Private Sub cargarControlesPredeterminados()
        Dim dt As DataTable
        Dim _Control_Subproyecto As New Control_Subproyecto

        dt = _Control_Subproyecto.GetFromSubproyecto(Me.id_subproyecto)
        'Me.dgv_controles_subproyecto.Rows.Clear()

        For Each row As DataRow In dt.Rows
            With _Control_Subproyecto
                .Cargar()
                .Modificar(CInt(row.Item("id_control_subproyecto")))

                For Each row_control As DataGridViewRow In Me.dgv_controles_subproyecto.Rows
                    If CInt(row_control.Cells("id_tipo_actividad_control_subproyecto").Value) = CInt(row.Item("id_tipo_actividad")) Then
                        row_control.Cells("id_control_subproyecto").Value = row.Item("id_control_subproyecto")
                        row_control.Cells("nombre_control_subproyecto").Value = row.Item("id_control")
                    End If
                Next
                'FALTA EL PESO
                'index = Me.dgv_controles_subproyecto.Rows.Add()
                'Me.dgv_controles_subproyecto.Rows(index).Cells("id_control_subproyecto").Value = row.Item("id_control_subproyecto")
                'Me.dgv_controles_subproyecto.Rows(index).Cells("id_tipo_actividad_control_subproyecto").Value = row.Item("id_tipo_actividad")
                'Me.dgv_controles_subproyecto.Rows(index).Cells("nombre_actividad_control_subproyecto").Value = row.Item("nombre_actividad")
                'Me.dgv_controles_subproyecto.Rows(index).Cells("nombre_control_subproyecto").Value = row.Item("id_control")
            End With
        Next

    End Sub

    Private Sub chk_asignacion_automatica_CheckedChanged(sender As Object, e As EventArgs) Handles chk_asignacion_automatica.CheckedChanged
        If cargando_datos = False Then

            If Me.chk_asignacion_automatica.Checked = True Then
                If MessageBox.Show("¿Está seguro que desea asignar automáticamente las tareas del subproyecto?. No se asignarán las actividades con asignación forzada", "Asignación automática", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If

                Me.AsignarAutomatica()
            Else

                If MessageBox.Show("¿Está seguro que desea quitar las asignaciones automáticas del subproyecto?. No se asignarán las actividades con asignación forzada", "Asignación automática", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If

                Dim _Subproyecto As New entSubproyecto
                With _Subproyecto
                    .Cargar()
                    .Modificar(Me.id_subproyecto)
                    .asignacion_automatica = Me.chk_asignacion_automatica.Checked
                    .Guardar()
                End With

                Dim odt As DataTable
                odt = oActividad_proyecto.GetAllSubproyectoConHijos(Me.id_subproyecto)

                Dim _Actividad_Proyecto As New Actividad_proyecto
                Dim _Subproyecto_Tarea As New entSubproyecto
                Dim _Usuario_proyecto As New Usuario_Proyecto
                Dim odt_miembros As DataTable
                Dim _Detalle_Recurso As New Detalle_recurso
                Dim odt_pendiente As DataTable
                Dim id_actividad_proyecto As Integer

                For Each row As DataRow In odt.Rows
                    With _Actividad_Proyecto
                        .Cargar()
                        .Modificar(CInt(row.Item("id_actividad_proyecto")))
                        If .asignada = False Then
                            With _Subproyecto
                                .Cargar()
                                .Modificar(_Actividad_Proyecto.id_subproyecto)
                                odt_miembros = _Usuario_proyecto.GetCmb(Me.id_proyecto, _Actividad_Proyecto.id_subproyecto, 1)
                                .asignacion_automatica = False
                                .Guardar()

                                If odt_miembros.Rows.Count = 0 Then
                                    odt_miembros = _Usuario_proyecto.GetCmb(Me.id_proyecto, _Actividad_Proyecto.id_subproyecto, 0)
                                End If

                                id_actividad_proyecto = _Actividad_Proyecto.id_actividad_proyecto

                                odt_pendiente = _Detalle_Recurso.GetAllPendiente()

                                For Each row2 As DataRow In odt_pendiente.Rows
                                    If CInt(row2.Item("id_actividad_proyecto")) = id_actividad_proyecto Then
                                        With _Detalle_Recurso
                                            .Cargar()
                                            .Borrar(CInt(row2.Item("id_detalle_recurso")))
                                        End With
                                    End If
                                Next

                            End With
                        End If
                    End With
                Next
            End If

        End If
    End Sub

    Private Sub AsignarAutomatica()
        Dim _Subproyecto As New entSubproyecto
        With _Subproyecto
            .Cargar()
            .Modificar(Me.id_subproyecto)
            .asignacion_automatica = Me.chk_asignacion_automatica.Checked
            .Guardar()
        End With

        Dim odt As DataTable
        odt = oActividad_proyecto.GetAllSubproyectoConHijos(Me.id_subproyecto)

        Dim _Actividad_Proyecto As New Actividad_proyecto
        Dim _Subproyecto_Tarea As New entSubproyecto
        Dim _Usuario_proyecto As New Usuario_Proyecto
        Dim _Tipo_Actividad_Usuario As New Tipo_Actividad_Usuario
        Dim _Actividad As New Actividad
        Dim odt_miembros As DataTable
        Dim _Detalle_Recurso As New Detalle_recurso
        Dim asignaciones_usuario As DataTable

        For Each row As DataRow In odt.Rows
            With _Actividad_Proyecto
                .Cargar()
                .Modificar(CInt(row.Item("id_actividad_proyecto")))

                With _Actividad
                    .Cargar()
                    .Modificar(_Actividad_Proyecto.id_actividad)
                End With

                If .asignada = False Then
                    With _Subproyecto
                        .Cargar()
                        .Modificar(_Actividad_Proyecto.id_subproyecto)
                        odt_miembros = _Usuario_proyecto.GetCmb(Me.id_proyecto, _Actividad_Proyecto.id_subproyecto, 1)
                        .asignacion_automatica = True
                        .Guardar()

                        If odt_miembros.Rows.Count = 0 Then
                            odt_miembros = _Usuario_proyecto.GetCmb(Me.id_proyecto, _Actividad_Proyecto.id_subproyecto, 0)
                        End If

                        For Each row_miembro As DataRow In odt_miembros.Rows
                            asignaciones_usuario = _Tipo_Actividad_Usuario.GetFromUsuario(CInt(row_miembro.Item("id_usuario")))
                            For Each row_Asignacion As DataRow In asignaciones_usuario.Rows

                                With _Tipo_Actividad_Usuario
                                    .Cargar()
                                    .Modificar(CInt(row_Asignacion.Item("id_tipo_actividad_usuario")))
                                End With

                                If _Tipo_Actividad_Usuario.id_tipo_actividad = _Actividad.id_tipo_actividad Then
                                    If _Tipo_Actividad_Usuario.habilitado = True Then
                                        With _Detalle_Recurso
                                            .Cargar()
                                            .Insertar()
                                            .realizada = False
                                            .tipo = "automatico"
                                            .porcentaje_avance = 0
                                            .id_actividad_proyecto = _Actividad_Proyecto.id_actividad_proyecto
                                            .motivo = ""
                                            .cantidad_hora = _Actividad_Proyecto.cantidad_hora
                                            If .cantidad_hora = 0 Then
                                                .cantidad_hora = 0.1D
                                            End If
                                            .id_usuario = CInt(row_miembro.Item("id_usuario"))
                                            .Guardar()
                                        End With
                                    End If
                                End If
                            Next
                        Next
                    End With
                End If
            End With
        Next
    End Sub

    Private Function BorrarAsignacionesMiembro(ByVal id_subproyecto As Integer, ByVal id_proyecto As Integer, ByVal id_usuario As Integer, ByVal preguntar As Boolean) As Boolean

        If id_usuario = 0 Then
            Exit Function
        End If

        If preguntar Then
            If MessageBox.Show("¿Está seguro que desea quitar a " & oUsuario.GetOne(id_usuario).Rows(0).Item("nombre").ToString() & " " & oUsuario.GetOne(id_usuario).Rows(0).Item("apellido").ToString() & "?. Se eliminarán sus tareas correspondientes", "Quitar miembro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Return False
                Exit Function
            End If
        End If

        Dim _Subproyecto As New entSubproyecto

        Dim odt As DataTable
        If id_subproyecto <> 0 Then
            odt = oActividad_proyecto.GetAllSubproyectoConHijos(Me.id_subproyecto)
        ElseIf id_proyecto <> 0 Then
            odt = oActividad_proyecto.GetAllProyectoConHijos(Me.id_proyecto)
        Else
            Exit Function
        End If

        Dim _Actividad_Proyecto As New Actividad_proyecto
        Dim _Subproyecto_Tarea As New entSubproyecto
        Dim _Usuario_proyecto As New Usuario_Proyecto
        Dim _Detalle_Recurso As New Detalle_recurso
        Dim odt_pendiente As DataTable
        Dim odt_miembros As DataTable
        Dim id_actividad_proyecto As Integer

        If id_subproyecto = 0 Then
            'Busca los miembros del subproyecto
            odt_miembros = _Usuario_proyecto.GetCmb(Me.id_proyecto, 0, 1)
            If odt_miembros.Rows.Count = 0 Then
                odt_miembros = _Usuario_proyecto.GetCmb(Me.id_proyecto, 0, 0)
            End If

            'Borra la pertenencia del usuario al subproyecto
            For Each row_miembro As DataRow In odt_miembros.Rows
                With _Usuario_proyecto
                    .Cargar()
                    .Modificar(CInt(row_miembro.Item("id_usuario_proyecto")))
                    If .id_usuario = id_usuario Then
                        .Borrar(CInt(row_miembro.Item("id_usuario_proyecto")))
                    End If
                End With
            Next
        End If



        For Each row As DataRow In odt.Rows
            With _Actividad_Proyecto
                .Cargar()
                .Modificar(CInt(row.Item("id_actividad_proyecto")))
                id_actividad_proyecto = _Actividad_Proyecto.id_actividad_proyecto

                'Busca dentro de TODAS las tareas
                odt_pendiente = _Detalle_Recurso.GetCmb()

                'Borra solo las tareas de las actividades del proyeecto o subproyecto a quitar el miembro
                'y solo para el usuario a borrar
                For Each row2 As DataRow In odt_pendiente.Rows
                    If CInt(row2.Item("id_actividad_proyecto")) = id_actividad_proyecto Then
                        If CInt(row2.Item("id_usuario")) = id_usuario Then
                            With _Detalle_Recurso
                                .Cargar()
                                .Borrar(CInt(row2.Item("id_detalle_recurso")))
                            End With
                        End If
                    End If
                Next

                'Si es subproyecto, reasigna
                If _Actividad_Proyecto.id_subproyecto <> 0 Then
                    With _Subproyecto
                        .Cargar()
                        .Modificar(_Actividad_Proyecto.id_subproyecto)

                        'Busca los miembros del subproyecto
                        odt_miembros = _Usuario_proyecto.GetCmb(Me.id_proyecto, _Actividad_Proyecto.id_subproyecto, 1)
                        If odt_miembros.Rows.Count = 0 Then
                            'odt_miembros = _Usuario_proyecto.GetCmb(Me.id_proyecto, _Actividad_Proyecto.id_subproyecto, 0)
                        End If

                        'Borra la pertenencia del usuario al subproyecto
                        For Each row_miembro As DataRow In odt_miembros.Rows
                            With _Usuario_proyecto
                                .Cargar()
                                .Modificar(CInt(row_miembro.Item("id_usuario_proyecto")))
                                If .id_usuario = id_usuario Then
                                    .Borrar(CInt(row_miembro.Item("id_usuario_proyecto")))
                                End If
                            End With
                        Next

                        'Actualiza las variables. Si al principio no encuentra datos es porque los toma del padre
                        odt_miembros = _Usuario_proyecto.GetCmb(Me.id_proyecto, _Actividad_Proyecto.id_subproyecto, 1)
                        If odt_miembros.Rows.Count = 0 Then
                            odt_miembros = _Usuario_proyecto.GetCmb(Me.id_proyecto, _Actividad_Proyecto.id_subproyecto, 0)
                        End If

                        'Si la asignación del subproyecto es automática y la tarea del miembro que se borró
                        'era forzada, entonces se hace automatica y se reasigna
                        If .asignacion_automatica = True And _Actividad_Proyecto.asignada Then
                            For Each row_miembro As DataRow In odt_miembros.Rows
                                With _Detalle_Recurso
                                    .Cargar()
                                    .Insertar()
                                    .realizada = False
                                    .tipo = "automatico"
                                    .porcentaje_avance = 0
                                    .id_actividad_proyecto = _Actividad_Proyecto.id_actividad_proyecto
                                    .motivo = ""
                                    .cantidad_hora = _Actividad_Proyecto.cantidad_hora
                                    If .cantidad_hora = 0 Then
                                        .cantidad_hora = 0.1D
                                    End If
                                    .id_usuario = CInt(row_miembro.Item("id_usuario"))
                                    .Guardar()
                                End With
                            Next
                        End If

                        'Se quita el forzado
                        With _Actividad_Proyecto
                            .asignada = False
                            .Guardar()
                        End With
                    End With
                End If
            End With
        Next

        Return True
    End Function

    Private Sub AgregarAsignacionesMiembro(ByVal id_subproyecto As Integer, ByVal id_proyecto As Integer, ByVal id_usuario As Integer)

        Dim _Actividad_Proyecto As New Actividad_proyecto
        Dim _Subproyecto_Tarea As New entSubproyecto
        Dim _Usuario_proyecto As New Usuario_Proyecto
        Dim _Detalle_Recurso As New Detalle_recurso
        Dim odt_pendiente As DataTable
        Dim odt_subproyectos As New DataTable
        Dim id_actividad_proyecto As Integer

        If id_usuario = 0 Then
            Exit Sub
        End If

        Dim _Subproyecto As New entSubproyecto

        Dim odt As DataTable
        If id_subproyecto <> 0 Then
            odt = oActividad_proyecto.GetAllSubproyectoConHijos(Me.id_subproyecto)

        ElseIf id_proyecto <> 0 Then
            odt = oActividad_proyecto.GetAllProyectoConHijos(Me.id_proyecto)
        Else
            Exit Sub
        End If

        Dim odt_miembros_subproyectos As DataTable

        Try
            For Each row As DataRow In odt.Rows
                With _Actividad_Proyecto
                    .Cargar()
                    .Modificar(CInt(row.Item("id_actividad_proyecto")))
                    id_actividad_proyecto = _Actividad_Proyecto.id_actividad_proyecto

                    If _Actividad_Proyecto.id_subproyecto <> 0 Then

                        With _Subproyecto
                            .Cargar()
                            .Modificar(_Actividad_Proyecto.id_subproyecto)

                            With _Usuario_proyecto
                                .Cargar()
                                odt_miembros_subproyectos = .GetCmb(id_proyecto, _Subproyecto.id_suproyecto, 1)
                            End With
                            'Busca dentro de TODAS las tareas
                            odt_pendiente = _Detalle_Recurso.GetCmb()

                            If id_subproyecto = _Subproyecto.id_suproyecto And odt_miembros_subproyectos.Rows.Count = 1 And .asignacion_automatica = True And _Actividad_Proyecto.asignada = False Then
                                'Si antes estaba en automatico y no habia miembros especificos, y el subproyecto
                                'es en donde se agrego (queda especifico) entonces quita las asignaciones anteriores
                                'solo lo deja al nuevo miembro                          

                                odt_miembros_subproyectos = _Usuario_proyecto.GetCmb(id_proyecto, id_subproyecto, 0)
                                For Each row2 As DataRow In odt_miembros_subproyectos.Rows
                                    If CInt(row2.Item("id_usuario")) <> id_usuario Then
                                        Me.BorrarAsignacionesMiembro(id_subproyecto, id_proyecto, CInt(row2.Item("id_usuario")), False)
                                    End If
                                Next

                                'Si ya habia asignados, agrega la asignacion en este nivel
                            ElseIf id_subproyecto = _Subproyecto.id_suproyecto And .asignacion_automatica = True And _Actividad_Proyecto.asignada = False Then
                                With _Detalle_Recurso
                                    .Cargar()
                                    .Insertar()
                                    .realizada = False
                                    .tipo = "automatico"
                                    .porcentaje_avance = 0
                                    .id_actividad_proyecto = _Actividad_Proyecto.id_actividad_proyecto
                                    .motivo = ""
                                    .cantidad_hora = _Actividad_Proyecto.cantidad_hora
                                    If .cantidad_hora = 0 Then
                                        .cantidad_hora = 0.1D
                                    End If
                                    .id_usuario = id_usuario
                                    .Guardar()
                                End With
                            End If
                        End With

                        'Si es subproyecto, reasigna
                        If id_subproyecto <> _Subproyecto.id_suproyecto And _Actividad_Proyecto.id_subproyecto <> 0 Then
                            With _Subproyecto
                                .Cargar()
                                .Modificar(_Actividad_Proyecto.id_subproyecto)

                                'Si la asignación del subproyecto es automática, no hay usuarios especificos asignados
                                'al subproyecto, y la actividad no está forzada entonces lo asigna al nuevo miembro
                                If odt_miembros_subproyectos.Rows.Count = 0 And .asignacion_automatica = True And _Actividad_Proyecto.asignada = False Then
                                    With _Detalle_Recurso
                                        .Cargar()
                                        .Insertar()
                                        .realizada = False
                                        .tipo = "automatico"
                                        .porcentaje_avance = 0
                                        .id_actividad_proyecto = _Actividad_Proyecto.id_actividad_proyecto
                                        .motivo = ""
                                        .cantidad_hora = _Actividad_Proyecto.cantidad_hora
                                        If .cantidad_hora = 0 Then
                                            .cantidad_hora = 0.1D
                                        End If
                                        .id_usuario = id_usuario
                                        .Guardar()
                                    End With
                                End If
                            End With
                        End If
                    End If
                End With
            Next
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btn_agregar_miembro_Actividad_Click(sender As Object, e As EventArgs) Handles btn_agregar_miembro_Actividad.Click
        If CInt(cmb_usuarios_asignar.SelectedValue) <> 0 Then

            For Each row As DataGridViewRow In Me.dgv_actividades_asignados.Rows
                If CInt(row.Cells("id_usuario_asignado").Value) = CInt(cmb_usuarios_asignar.SelectedValue) Then
                    If CBool(row.Cells("realizada_asignado").Value) = False Then
                        Exit Sub
                    End If
                End If
            Next

            Dim _Actividad_proyecto As New Actividad_proyecto
            With _Actividad_proyecto
                .Cargar()
                .Modificar(Me.id_actividad_proyecto)
                .asignada = True
                .Guardar()
            End With

            Try
                With _Detalle_Recurso
                    .Cargar()
                    .Insertar()
                    .cantidad_hora = CDec(Me.txt_horas_actividad.Text)
                    .id_actividad_proyecto = Me.id_actividad_proyecto
                    .id_usuario = CInt(Me.cmb_usuarios_asignar.SelectedValue)
                    .motivo = Me.txt_observaciones_asignar.Text
                    .cantidad_hora = Me.txtnum_cantidad_horas_asignar.Value
                    .porcentaje_avance = 0
                    .realizada = False
                    .fecha_inicio = _task_manager.CalcularCantidadDias(.id_usuario, Me.dtp_fecha_inicio_detalle_actividad.Value, 0)
                    .fecha_fin = _task_manager.CalcularCantidadDias(.id_usuario, .fecha_inicio, .cantidad_hora)
                    .tipo = "-"

                    .Guardar()
                End With

                Dim _Detalle_Recurso_2 As New Detalle_recurso
                Dim odt_pendiente As DataTable
                odt_pendiente = _Detalle_Recurso_2.GetAllPendiente()

            Catch ex As Exception
                MessageBox.Show("Ha ocurrido un problema al asignar la actividad: " + ex.Message, "Asignación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try

        Else
            MessageBox.Show("Debe seleccionar un usuario", "Asignación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        Me.ActualizarGrillAsignados()
    End Sub

    Private Sub ActualizarGrillAsignados()
        'Verifica si ya está asignada
        Dim odt As DataTable = _Detalle_Recurso.GetOneIngreso(Me.id_actividad_proyecto)
        Dim index As Integer

        Me.dgv_actividades_asignados.Rows.Clear()

        'Está asignada
        If odt.Rows.Count > 0 Then
            For Each row As DataRow In odt.Rows
                With _Detalle_Recurso
                    .Cargar()
                    .Modificar(CInt(odt.Rows(0).Item("id_detalle_recurso")))
                    index = Me.dgv_actividades_asignados.Rows.Add()

                    With Me.dgv_actividades_asignados.Rows(index)
                        .Cells("id_detalle_recurso_asignado").Value = CInt(row.Item("id_detalle_recurso"))
                        .Cells("id_usuario_asignado").Value = CInt(row.Item("id_usuario"))
                        .Cells("nombre_usuario_asignado").Value = CStr(row.Item("nombre_usuario"))
                        .Cells("observacion_asignado").Value = CStr(row.Item("motivo"))
                        .Cells("horas_asignado").Value = CDec(row.Item("cantidad_hora"))
                        .Cells("forzada_asignado").Value = CBool(row.Item("forzada"))
                        .Cells("realizada_asignado").Value = CBool(row.Item("realizada"))
                        .Cells("fecha_inicio_detalle_recurso_asignado").Value = CDate(row.Item("fecha_inicio"))
                        .Cells("fecha_fin_detalle_recurso_asignado").Value = CDate(row.Item("fecha_fin"))
                    End With

                    Me.txt_observaciones_asignar.Text = ""
                    Me.cmb_usuarios_asignar.SelectedValue = 0
                    Me.chk_reealizada_actividad.Checked = .realizada
                    Me.txtnum_cantidad_horas_asignar.Value = 1
                End With

                With _Detalle_Recurso
                    .Cargar()
                    .Insertar()
                End With
            Next

        End If
    End Sub

    Private Sub dgv_actividades_asignados_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_actividades_asignados.CellEndEdit

        'End If
    End Sub

    Private Sub dgv_actividades_asignados_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_actividades_asignados.CellValueChanged
        If cargando_datos = False Then
            Try
                Dim id_detalle_recurso As Integer

                If e.ColumnIndex = Me.dgv_actividades_asignados.Columns("realizada_asignado").Index Then
                    Me.dgv_actividades_asignados.Rows(e.RowIndex).Cells("forzada_asignado").Value = Not CBool(Me.dgv_actividades_asignados.Rows(e.RowIndex).Cells("realizada_asignado").Value)
                ElseIf e.ColumnIndex = Me.dgv_actividades_asignados.Columns("forzada_asignado").Index Then
                    Me.dgv_actividades_asignados.Rows(e.RowIndex).Cells("realizada_asignado").Value = Not CBool(Me.dgv_actividades_asignados.Rows(e.RowIndex).Cells("forzada_asignado").Value)
                ElseIf e.ColumnIndex = Me.dgv_actividades_asignados.Columns("fecha_inicio_detalle_recurso_asignado").Index Or e.ColumnIndex = Me.dgv_actividades_asignados.Columns("horas_asignado").Index Then
                    Me.dgv_actividades_asignados.Rows(e.RowIndex).Cells("fecha_inicio_detalle_recurso_asignado").Value = _task_manager.CalcularCantidadDias(CInt(Me.dgv_actividades_asignados.Rows(e.RowIndex).Cells("id_usuario_asignado").Value), CDate(Me.dgv_actividades_asignados.Rows(e.RowIndex).Cells("fecha_inicio_detalle_recurso_asignado").Value), 0)
                    Me.dgv_actividades_asignados.Rows(e.RowIndex).Cells("fecha_fin_detalle_recurso_asignado").Value = _task_manager.CalcularCantidadDias(CInt(Me.dgv_actividades_asignados.Rows(e.RowIndex).Cells("id_usuario_asignado").Value), CDate(Me.dgv_actividades_asignados.Rows(e.RowIndex).Cells("fecha_inicio_detalle_recurso_asignado").Value), CDec(Me.dgv_actividades_asignados.Rows(e.RowIndex).Cells("horas_asignado").Value))
                End If

                id_detalle_recurso = CInt(Me.dgv_actividades_asignados.Rows(e.RowIndex).Cells("id_detalle_recurso_asignado").Value)
                With _Detalle_Recurso
                    .Cargar()
                    .Modificar(id_detalle_recurso)
                    .cantidad_hora = CDec(Me.dgv_actividades_asignados.Rows(e.RowIndex).Cells("horas_asignado").Value)
                    .motivo = CStr(Me.dgv_actividades_asignados.Rows(e.RowIndex).Cells("observacion_asignado").Value)
                    .realizada = CBool(Me.dgv_actividades_asignados.Rows(e.RowIndex).Cells("realizada_asignado").Value)
                    .forzada = CBool(Me.dgv_actividades_asignados.Rows(e.RowIndex).Cells("forzada_asignado").Value)
                    .realizada = CBool(Me.dgv_actividades_asignados.Rows(e.RowIndex).Cells("realizada_asignado").Value)
                    .fecha_inicio = CDate(Me.dgv_actividades_asignados.Rows(e.RowIndex).Cells("fecha_inicio_detalle_recurso_asignado").Value)
                    .fecha_fin = CDate(Me.dgv_actividades_asignados.Rows(e.RowIndex).Cells("fecha_fin_detalle_recurso_asignado").Value)
                    .Guardar()
                End With
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub chk_actividad_proveedor_CheckedChanged(sender As Object, e As EventArgs) Handles chk_actividad_proveedor.CheckedChanged
        If cargando_datos = False Then
            If chk_actividad_proveedor.Checked = True Then
                Me.cmb_actividad_proveedor.Enabled = True
                Me.cmb_actividad_proveedor.SelectedValue = 38
                Me.btn_crear_control_proveedor.Enabled = True
            Else
                Me.cmb_actividad_proveedor.Enabled = False
                Me.cmb_actividad_proveedor.SelectedValue = 0
                Me.btn_crear_control_proveedor.Enabled = False
            End If
        End If
    End Sub

    Private Sub chk_forzar_fecha_inicio_CheckedChanged(sender As Object, e As EventArgs) Handles chk_forzar_fecha_inicio.CheckedChanged
        'If cargando_datos = False Then
        Me.dtp_fecha_inicio_estimada_subproyecto.Enabled = Me.chk_forzar_fecha_inicio.Checked
        'End If
    End Sub

    Private Sub chk_forzar_fecha_fin_CheckedChanged(sender As Object, e As EventArgs) Handles chk_forzar_fecha_fin.CheckedChanged
        'If cargando_datos = False Then
        Me.dtp_fecha_fin_estimada_subproyecto.Enabled = Me.chk_forzar_fecha_fin.Checked
        'End If
    End Sub

    Private Sub chk_forzar_inicio_actividad_CheckedChanged(sender As Object, e As EventArgs) Handles chk_forzar_inicio_actividad.CheckedChanged
        Me.dtp_inicio_estimado_actividad.Enabled = Me.chk_forzar_inicio_actividad.Checked
    End Sub

    Private Sub chk_forzar_fin_actividad_CheckedChanged(sender As Object, e As EventArgs) Handles chk_forzar_fin_actividad.CheckedChanged
        Me.dtp_fin_estimado_actividad.Enabled = Me.chk_forzar_fin_actividad.Checked
    End Sub


    Private Sub dgv_miembros_proyecto_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgv_miembros_proyecto.CellValidating

    End Sub

    Private Sub dgv_miembros_proyecto_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgv_miembros_proyecto.CurrentCellDirtyStateChanged

    End Sub

    Private Sub dgv_miembros_proyecto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_miembros_proyecto.CellContentClick
        If e.ColumnIndex = Me.dgv_miembros_proyecto.Columns("chk_seleccionado_usuario_proyecto").Index Then

            If CBool(Me.dgv_miembros_proyecto.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) = False Then
                Dim usuario_proyecto As New Usuario_Proyecto

                With usuario_proyecto
                    .Cargar()
                    .Insertar()
                    .id_proyecto = Me.id_proyecto
                    .id_subproyecto = 0
                    .id_usuario = CInt(Me.dgv_miembros_proyecto.Rows(e.RowIndex).Cells("id_usuario").Value)
                    If usuario_proyecto.Exist() Then
                        Exit Sub
                    End If
                    .Guardar()
                    Me.dgv_miembros_proyecto.Rows(e.RowIndex).Cells("id_usuario_proyecto").Value = .id_usuario_proyecto
                    Me.AgregarAsignacionesMiembro(.id_subproyecto, .id_proyecto, .id_usuario)
                    Me.dgv_miembros_proyecto.CommitEdit(Nothing)
                End With
            Else

                Dim usuario_proyecto As New Usuario_Proyecto
                With usuario_proyecto

                    .Cargar()
                    .Modificar(CInt(dgv_miembros_proyecto.Rows(e.RowIndex).Cells("id_usuario_proyecto").Value))

                    If Me.BorrarAsignacionesMiembro(.id_subproyecto, .id_proyecto, .id_usuario, True) Then
                        Me.dgv_miembros_proyecto.Rows(e.RowIndex).Cells("id_usuario_proyecto").Value = 0
                        Me.dgv_miembros_proyecto.CommitEdit(Nothing)
                    Else
                        Me.dgv_miembros_proyecto.CancelEdit()
                    End If

                End With

            End If

            If Me.id_subproyecto <> 0 Then
                Me.cargarDatosSubproyecto()
            End If

        End If
    End Sub

    Private Sub dgv_miembros_subproyecto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_miembros_subproyecto.CellContentClick
        If e.ColumnIndex = Me.dgv_miembros_subproyecto.Columns("chk_seleccionado_usuario_subproyecto").Index Then


            If CBool(Me.dgv_miembros_subproyecto.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) = False Then
                Dim usuario_proyecto As New Usuario_Proyecto

                With usuario_proyecto
                    .Cargar()
                    .Insertar()
                    .id_proyecto = Me.id_proyecto
                    .id_subproyecto = Me.id_subproyecto
                    .id_usuario = CInt(Me.dgv_miembros_subproyecto.Rows(e.RowIndex).Cells("id_usuario_subproyecto").Value)
                    If usuario_proyecto.Exist() Then
                        Exit Sub
                    End If
                    .Guardar()
                    Me.dgv_miembros_subproyecto.Rows(e.RowIndex).Cells("id_usuario_proyecto_subproyecto").Value = .id_usuario_proyecto
                    Me.AgregarAsignacionesMiembro(.id_subproyecto, .id_proyecto, .id_usuario)
                    Me.dgv_miembros_subproyecto.CommitEdit(Nothing)
                End With
            Else

                Dim usuario_proyecto As New Usuario_Proyecto
                Dim id_usuario, id_subproyecto, id_proyecto As Integer
                With usuario_proyecto

                    .Cargar()
                    .Modificar(CInt(dgv_miembros_subproyecto.Rows(e.RowIndex).Cells("id_usuario_proyecto_subproyecto").Value))
                    id_usuario = .id_usuario
                    id_proyecto = .id_proyecto
                    id_subproyecto = .id_subproyecto
                    .Borrar(CInt(dgv_miembros_subproyecto.SelectedRows(0).Cells("id_usuario_proyecto_subproyecto").Value))

                    If Me.BorrarAsignacionesMiembro(id_subproyecto, id_proyecto, id_usuario, True) Then
                        Me.dgv_miembros_subproyecto.Rows(e.RowIndex).Cells("id_usuario_proyecto_subproyecto").Value = 0
                        Me.dgv_miembros_subproyecto.CommitEdit(Nothing)
                    Else
                        Me.dgv_miembros_subproyecto.CancelEdit()
                    End If

                End With

                If usuario_proyecto.GetCmb(Me.id_proyecto, Me.id_subproyecto, 1).Rows.Count = 0 And Me.chk_asignacion_automatica.Checked Then
                    Me.AsignarAutomatica()
                End If

            End If

        End If
    End Sub

    Private Sub dgv_controles_subproyecto_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgv_controles_subproyecto.CurrentCellDirtyStateChanged
        'For Each row As DataGridViewRow In Me.dgv_controles_subproyecto.Rows
        Dim row As DataGridViewRow = Me.dgv_controles_subproyecto.SelectedRows(0)

        Dim _Control_Subproyecto As New Control_Subproyecto
        With _Control_Subproyecto
            .Cargar()
            If CInt(row.Cells("id_control_subproyecto").Value) <> 0 Then
                .Modificar(CInt(row.Cells("id_control_subproyecto").Value))
                .id_control = CInt(row.Cells("nombre_control_subproyecto").Value)
                .id_subproyecto = Me.id_subproyecto
                .id_tipo_actividad = CInt(row.Cells("id_tipo_actividad_control_subproyecto").Value)
                If row.Cells("nombre_control_subproyecto").Value IsNot Nothing Then
                    If CInt(row.Cells("nombre_control_subproyecto").Value) <> 0 Then
                        .Guardar()
                    Else
                        .Borrar(CInt(row.Cells("id_control_subproyecto").Value))
                    End If
                Else
                    .Borrar(CInt(row.Cells("id_control_subproyecto").Value))
                End If
            Else
                If row.Cells("nombre_control_subproyecto").Value IsNot Nothing Then
                    If CInt(row.Cells("nombre_control_subproyecto").Value) <> 0 Then
                        .Insertar()
                        .id_control = CInt(row.Cells("nombre_control_subproyecto").Value)
                        .id_subproyecto = Me.id_subproyecto
                        .id_tipo_actividad = CInt(row.Cells("id_tipo_actividad_control_subproyecto").Value)
                        .Guardar()
                    End If
                End If
            End If

        End With
        'Next
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 10 Then ' Horas x subproyecto
            Me.CargarHorasUsuarioXUnidad()
        ElseIf TabControl1.SelectedIndex = 11 Then
            Me.CargarGantt()
        End If
    End Sub


    Private Sub btn_crear_control_proveedor_Click(sender As Object, e As EventArgs) Handles btn_crear_control_proveedor.Click

        If oMovimiento_voz.obtenerMovimientoVozDesdeActividadProyecto(Me.id_actividad_proyecto) <> 0 Then
            MessageBox.Show("Ya se ha creado un control para la actividad seleccionada", "Control ya existente", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim _Actividad_proyecto As New Actividad_proyecto

        With _Actividad_proyecto
            .Cargar()
            .Modificar(id_actividad_proyecto)
            .asignada = True
            .Guardar()
        End With

        Dim _Actividad As New Actividad


        With _Actividad
            .Cargar()
            .Modificar(_Actividad_proyecto.id_actividad)
        End With

        With oMovimiento_voz
            .Cargar()
            .Insertar()
            .fecha = Date.Now
            .id_cadista = _Actividad_proyecto.id_proveedor
            If _Actividad_proyecto.id_control <> 0 Then
                .id_controlador_1 = _Actividad_proyecto.id_controlador_1
                .id_controlador_2 = _Actividad_proyecto.id_controlador_2
            Else
                Dim id_control As Integer = 0
                With _Actividad_proyecto.GetControl(_Actividad_proyecto.id_actividad_proyecto, _Actividad.id_tipo_actividad).Rows(0)
                    _Actividad_proyecto.id_control = CInt(.Item("id_control"))
                    _Actividad_proyecto.id_controlador_1 = CInt(.Item("id_controlador_1"))
                    _Actividad_proyecto.id_controlador_2 = CInt(.Item("id_controlador_2"))
                    _Actividad_proyecto.Guardar()
                End With
            End If

            .id_proyect_manager = 0
            .id_actividad_proyecto = _Actividad_proyecto.id_actividad_proyecto
            .id_usuario_anterior = 0

            .control_prod = True
            .id_usuario_1 = 0
            .id_usuario_2 = _Actividad_proyecto.id_controlador_1
            .id_usuario_3 = 0
            .id_usuario_4 = 0
            .id_usuario_5 = _Actividad_proyecto.id_controlador_1
            .id_usuario_6 = 0

            .id_control = _Actividad_proyecto.id_control
            .Guardar()

        End With

        Dim odtControl As New DataTable
        odtControl = oControl.GetAllVoz(_Actividad_proyecto.id_control)

        For Each row As DataRow In odtControl.Rows
            With oCuerpo_movimiento_voz
                .Cargar()
                .Insertar()
                .id_movimiento_voz = oMovimiento_voz.id_movimiento_voz
                .id_usuario = vgCodigoUsuario
                .completado = False
                .id_voz = CInt(row("id_voz"))
                If _Actividad_proyecto.id_proveedor <> 0 Then
                    .nc1 = False
                    .ok1 = True
                    .completado = True
                    .completado_pm = False
                    .control1 = True
                    .numero_revision = 1
                    .corresponde = False
                    .id_usuario = 0
                End If
                .Guardar()
            End With
        Next

    End Sub


    Private Sub dgv_actividades_asignados_MouseDown(sender As Object, e As MouseEventArgs) Handles dgv_actividades_asignados.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim currentMouseOverRow As Integer
            currentMouseOverRow = dgv_actividades_asignados.HitTest(e.X, e.Y).RowIndex

            If currentMouseOverRow >= 0 Then
                dgv_actividades_asignados.ClearSelection()
                dgv_actividades_asignados.Rows(currentMouseOverRow).Selected = True
                Me.ts_id_tarea_asignada.Text = "ID: " & dgv_actividades_asignados.SelectedRows(0).Cells("id_detalle_recurso_asignado").Value.ToString()
                ts_tareas_asignadas.Show(dgv_actividades_asignados, New Point(e.X, e.Y))
            End If
        End If
    End Sub

    Private Sub ts_eliminar_tarea_asignada_Click(sender As Object, e As EventArgs) Handles ts_eliminar_tarea_asignada.Click
        'Try
        '    Dim id_detalle_recurso As Integer = CInt(dgv_actividades_asignados.SelectedRows(0).Cells("id_detalle_recurso_asignado").Value)
        '    With _Detalle_Recurso
        '        .Cargar()
        '        .Borrar(id_detalle_recurso)
        '    End With
        '    Me.CargarDatosAsignaciones()
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub dgv_actividades_control_MouseDown(sender As Object, e As MouseEventArgs) Handles dgv_actividades_control.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim currentMouseOverRow As Integer
            currentMouseOverRow = dgv_actividades_control.HitTest(e.X, e.Y).RowIndex

            If currentMouseOverRow >= 0 Then
                Me.ts_id_control.Text = "ID: " & dgv_actividades_control.Rows(currentMouseOverRow).Cells("id_movimiento_voz_control").Value.ToString()
                cms_controles.Show(dgv_actividades_control, New Point(e.X, e.Y))
            End If
        End If
    End Sub

    Private Sub dgv_anotaciones_proyecto_MouseDown(sender As Object, e As MouseEventArgs) Handles dgv_anotaciones_proyecto.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim currentMouseOverRow As Integer
            currentMouseOverRow = dgv_anotaciones_proyecto.HitTest(e.X, e.Y).RowIndex

            If currentMouseOverRow >= 0 Then
                Me.ts_id_anotacion.Text = "ID: " & dgv_anotaciones_proyecto.Rows(currentMouseOverRow).Cells("id_anotacion").Value.ToString()
                cms_anotaciones_grilla.Show(dgv_anotaciones_proyecto, New Point(e.X, e.Y))
            End If
        End If
    End Sub


    Private Sub chk_no_conformidad_CheckedChanged(sender As Object, e As EventArgs) Handles chk_no_conformidad.CheckedChanged
        If Me.chk_no_conformidad.Checked = True Then
            Me.txt_motivo_no_conformidad.Enabled = True
        Else
            Me.txt_motivo_no_conformidad.Enabled = False
            Me.txt_motivo_no_conformidad.Text = ""
        End If

    End Sub

    Private Sub CargarGantt()
        ''Dim elhost As ElementHost = New ElementHost()
        ''elhost.Size = New Size(500, 500)
        ''elhost.Location = New Point(10, 10)

        ''Dim wpfctl As GanttWpf = New GanttWpf()
        ''elhost.Child = wpfctl
        'GanttWpf1.GanttChartDataGrid1.Scales(5).Intervals.Clear()
        ''Me.tab_Gantt.Controls.Add(elhost)
        'GanttWpf1.GanttChartDataGrid1.WorkingDayStart = TimeOfDay.Parse("08:00:00")
        'GanttWpf1.GanttChartDataGrid1.WorkingDayFinish = TimeOfDay.Parse("16:30:00")
        ''GanttWpf1.GanttChartDataGrid1.NonworkingIntervals = new ObservableCollection<TimeInterval>(
        ''   new TimeInterval[] { new TimeInterval(DateTime.Today.AddDays(2), DateTime.Today.AddDays(3).Add(TimeSpan.Parse("12:00:00"))) })
        'GanttWpf1.GanttChartDataGrid1.TimelinePageStart = New DateTime(2014, 1, 1)
        'GanttWpf1.GanttChartDataGrid1.TimelinePageFinish = DateTime.Today.AddMonths(2)
        'GanttWpf1.GanttChartDataGrid1.VisibleDayStart = TimeOfDay.Parse("09:00:00")
        'GanttWpf1.GanttChartDataGrid1.VisibleDayFinish = TimeOfDay.Parse("15:00:00")

        'GanttWpf1.GanttChartDataGrid1.Items.Clear()

        'Dim subproject As New GanttChartItem()


        'If oSubproyecto IsNot Nothing And oSubproyecto.id_suproyecto <> 0 Then
        '    subproject.Content = oSubproyecto.nombre
        '    subproject.AssignmentsContent = oSubproyecto.nombre
        '    GanttWpf1.GanttChartDataGrid1.Items.Add(subproject)
        '    subproject.Start = oSubproyecto.fecha_inicio_estimada
        '    subproject.Finish = oSubproyecto.fecha_fin_estimada
        '    ObtenerSubproyectos(GanttWpf1.GanttChartDataGrid1, subproject, oSubproyecto.id_suproyecto, _ClsProyecto.id_proyecto)
        'Else
        '    'Proyecto
        '    subproject.Content = _ClsProyecto.nombre_proyecto
        '    subproject.AssignmentsContent = _ClsProyecto.nombre_proyecto
        '    GanttWpf1.GanttChartDataGrid1.Items.Add(subproject)
        '    subproject.Start = _ClsProyecto.fecha_inicio
        '    subproject.Finish = _ClsProyecto.fecha_fin_prevista

        '    Dim aux As New ScaleInterval(_ClsProyecto.fecha_fin_prevista, DateAdd(DateInterval.Day, 1, _ClsProyecto.fecha_fin_prevista))
        '    GanttWpf1.GanttChartDataGrid1.Scales(5).Intervals.Add(aux)

        '    ObtenerSubproyectos(GanttWpf1.GanttChartDataGrid1, subproject, 0, _ClsProyecto.id_proyecto)
        'End If


        ''prueba vertical

        ''GanttWpf1.GanttChartDataGrid1.ApplyTemplate()
        ''Dim startDate As DateTime = DateTime.Today.AddDays(-CInt(DateTime.Today.DayOfWeek))
        ''Dim [date] As DateTime = startDate.AddDays(-5 * 7)
        ''While [date] < startDate.AddDays(20 * 7)
        ''    Dim scala As New ScaleInterval([date], [date].AddDays(7))
        ''    scala.HeaderContent = [date].ToLongDateString()
        ''    GanttWpf1.GanttChartDataGrid1.Scales(1).Intervals.Add(scala)
        ''    [date] = [date].AddDays(7)
        ''End While

        ''For Each interval As ScaleInterval In GanttWpf1.GanttChartDataGrid1.Scales(2).Intervals
        ''    Dim dayNumber As Integer = CInt((interval.TimeInterval.Start.[Date] - startDate).TotalDays)
        ''    interval.HeaderContent = If(dayNumber >= 0, (dayNumber + 1).ToString(), String.Empty)
        ''Next
        ' '' Do not allow end users to change the timeline page by using special extra horizontal scrolling buttons.
        ''GanttWpf1.GanttChartDataGrid1.AreUpdateTimelinePageButtonsVisible = False


    End Sub


    'Private Sub ObtenerSubproyectos(ByRef manager As GanttChartDataGrid, proyecto_padre As GanttChartItem, id_subproyecto As Integer, id_proyecto As Integer)
    'Dim subproyectos As DataTable
    'If id_subproyecto <> 0 Then
    '    subproyectos = ObtenerPorProyecto(0, id_subproyecto)
    'Else
    '    subproyectos = ObtenerPorProyecto(id_proyecto, 1)
    'End If

    'For Each row_subproyecto As DataRow In subproyectos.Rows
    '    Dim subproject As New GanttChartItem()
    '    subproject.Content = row_subproyecto("nombre").ToString()
    '    subproject.AssignmentsContent = row_subproyecto("nombre").ToString()
    '    manager.Items.Add(subproject)
    '    '_mManager.SetDuration(subproject, 3);
    '    'subproject.Complete = 0.5f;
    '    'subproject.IsCollapsed = true;
    '    'var span3 = Convert.ToDateTime(row_subproyecto["fecha_fin_estimada"]) - DateTime.Today;
    '    '_mManager.SetDuration(subproject, (int)Math.Round(span3.TotalDays));
    '    'manager.Group(proyecto_padre, subproject);
    '    subproject.Start = Convert.ToDateTime(row_subproyecto("fecha_inicio_estimada"))
    '    subproject.Finish = Convert.ToDateTime(row_subproyecto("fecha_fin_estimada"))

    '    If proyecto_padre IsNot Nothing Then
    '        Dim pred As New PredecessorItem
    '        pred.Item = proyecto_padre
    '        subproject.Predecessors.Add(pred)
    '        subproject.Indentation = proyecto_padre.Indentation + 1
    '    Else
    '        subproject.Indentation = 1
    '    End If

    '    If ObtenerPorProyecto(0, Convert.ToInt32(row_subproyecto("id_subproyecto"))).Rows.Count > 0 Then
    '        ObtenerSubproyectos(manager, subproject, Convert.ToInt32(row_subproyecto("id_subproyecto")), 0)
    '    End If

    '    ObtenerActividades(manager, subproject, Convert.ToInt32(row_subproyecto("id_subproyecto")))
    'Next

    'End Sub

    'Private Sub ObtenerActividades(ByRef manager As GanttChartDataGrid, proyecto_padre As GanttChartItem, id_subproyecto As Integer)
    'Dim proy As New Proyecto()
    'Dim subproyectos As DataTable
    'subproyectos = proy.GetAllDeSubproyectoAsignados(id_subproyecto)

    'Dim predecesor As GanttChartItem = Nothing
    ''List<MyTask> actividades = new List<MyTask>();
    'For Each row_subproyecto As DataRow In subproyectos.Rows
    '    Dim subproject As New GanttChartItem()
    '    subproject.Content = row_subproyecto("nombre_actividad").ToString()
    '    subproject.AssignmentsContent = row_subproyecto("nombre_actividad").ToString()
    '    subproject.Start = Convert.ToDateTime(row_subproyecto("fecha_inicio_real"))
    '    subproject.Finish = Convert.ToDateTime(row_subproyecto("fecha_fin_previsto"))

    '    If Convert.ToInt32(row_subproyecto("completado")) = 1 Then
    '        subproject.IsCompleted = True
    '        Dim bru As Windows.Media.Brush = New Windows.Media.SolidColorBrush(Colors.Green)
    '        GanttChartView.SetStandardBarFill(subproject, bru)
    '    Else
    '        Dim bru As Windows.Media.Brush = New Windows.Media.SolidColorBrush(Colors.Yellow)
    '        GanttChartView.SetStandardBarFill(subproject, bru)
    '        subproject.IsCompleted = False
    '        subproject.CompletedFinish = Convert.ToDateTime(row_subproyecto("fecha_fin_previsto"))
    '        'subproject.TotalEffort = New TimeSpan(Convert.ToInt32(row_subproyecto("tiempo_standart")) * 36000000000)
    '        'subproject.CompletedEffort = New TimeSpan(Convert.ToInt32(row_subproyecto.Item("horas_usadas")) * 36000000000)


    '        If _Detalle_Recurso.GetFromActividad(CInt(row_subproyecto("id_actividad_proyecto"))) IsNot Nothing Then
    '            Dim _Usuario_tarea As New Usuario
    '            _Usuario_tarea.Modificar(_Detalle_Recurso.GetFromActividad(CInt(row_subproyecto("id_actividad_proyecto"))).id_usuario)

    '            subproject.Start = _Detalle_Recurso.GetFromActividad(CInt(row_subproyecto("id_actividad_proyecto"))).fecha_inicio
    '            subproject.Finish = _Detalle_Recurso.GetFromActividad(CInt(row_subproyecto("id_actividad_proyecto"))).fecha_fin
    '            subproject.CompletedFinish = _Detalle_Recurso.GetFromActividad(CInt(row_subproyecto("id_actividad_proyecto"))).fecha_fin
    '            Dim total As Double = _Detalle_Recurso.GetFromActividad(CInt(row_subproyecto("id_actividad_proyecto"))).cantidad_hora
    '            Dim usados As Double = CDbl(row_subproyecto.Item("horas_usadas"))
    '            subproject.AssignmentsContent = row_subproyecto("nombre_actividad").ToString() + " (" + _Usuario_tarea.nombre + " " + _Usuario_tarea.apellido + ")"
    '            subproject.IsCompleted = False
    '            If total <> 0 Then
    '                subproject.Completion = usados / total
    '            Else
    '                subproject.Completion = 0
    '            End If

    '            'subproject.TotalEffort = New TimeSpan(CLng(_Detalle_Recurso.GetFromActividad(CInt(row_subproyecto("id_actividad_proyecto"))).cantidad_hora))
    '            'subproject.CompletedEffort = New TimeSpan(Convert.ToInt32(row_subproyecto.Item("horas_usadas")) * 36000000000)
    '        End If

    '    End If

    '    'GanttChartView.SetStandardBarStroke(subproject, bru);
    '    If predecesor IsNot Nothing Then
    '        Dim pred As New PredecessorItem
    '        pred.Item = predecesor
    '        subproject.Predecessors.Add(pred)
    '        predecesor = subproject
    '    Else
    '        predecesor = subproject
    '    End If

    '    If proyecto_padre IsNot Nothing Then
    '        subproject.Indentation = proyecto_padre.Indentation + 1
    '    Else
    '        subproject.Indentation = 1
    '    End If


    '    '_mManager.Add(subproject);
    '    '_mManager.Group(proyecto_padre, subproject);
    '    ' subproject.Complete = 0.5f;
    '    'subproject.IsCollapsed = true;
    '    ' actividades.Add(subproject);
    '    ' var span4 = Convert.ToDateTime(row_subproyecto["fecha_inicio"]) - _mManager.Start;
    '    '  _mManager.SetStart(subproject, Convert.ToInt32(Math.Truncate(span4.TotalDays)));
    '    '  var span3 = Convert.ToDateTime(row_subproyecto["fecha_fin_previsto"]) - Convert.ToDateTime(row_subproyecto["fecha_inicio"]);
    '    '  _mManager.SetDuration(subproject, Convert.ToInt32(Math.Truncate(span3.TotalDays)));


    '    manager.Items.Add(subproject)
    'Next


    'End Sub

    Public Function ObtenerPorProyecto(id_proyecto As Integer, id_subproyecto_padre As Integer) As DataTable
        Dim cnn As New Conexion()
        Dim odt As New DataTable()
        Dim oda As New SqlDataAdapter("cop_subproyecto_getFromProyecto", cnn.Coneccion())

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 6, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_proyecto
        oda.SelectCommand.Parameters.Add("@id_subproyecto_padre", SqlDbType.Int, 6, "id_subproyecto_padre")
        oda.SelectCommand.Parameters("@id_subproyecto_padre").Value = id_subproyecto_padre

        oda.Fill(odt)

        Return odt
    End Function



    Private Sub dtp_fecha_desde_logueo_ValueChanged(sender As Object, e As EventArgs) Handles dtp_fecha_desde_logueo.ValueChanged
        ActualizarGrillaLogueoUsuario()
    End Sub

    Private Sub dtp_fecha_hasta_logueo_ValueChanged(sender As Object, e As EventArgs) Handles dtp_fecha_hasta_logueo.ValueChanged
        ActualizarGrillaLogueoUsuario()
    End Sub

    Private Sub ActualizarGrillaLogueoUsuario()
        Try
            'If loaded Then
            Dim dt As DataTable
            Dim dr_index As Integer
            dt = oCuerpo_movimiento_hora.GetLogueoDia(vgCodigoUsuario, dtp_fecha_desde_logueo.Value, dtp_fecha_hasta_logueo.Value, 0, 0)

            dgv_logueo_dia.Rows.Clear()

            For Each row As DataRow In dt.Rows
                dr_index = dgv_logueo_dia.Rows.Add()
                With dgv_logueo_dia.Rows(dr_index)
                    .Cells("id_movimiento_hora_logueo").Value = row.Item("id_movimiento_hora").ToString()
                    .Cells("id_cuerpo_movimiento_hora_logueo").Value = row.Item("id_cuerpo_movimiento_hora").ToString()
                    .Cells("fecha_logueo").Value = CDate(row.Item("Fecha"))
                    .Cells("hora_entrada_logueo").Value = row.Item("Hora Entrada").ToString()
                    .Cells("hora_salida_logueo").Value = row.Item("Hora Salida").ToString()
                    .Cells("tiempo_logueo").Value = row.Item("Tiempo").ToString()
                    .Cells("cliente_logueo").Value = row.Item("Cliente").ToString()
                    .Cells("proyecto_logueo").Value = row.Item("Proyecto").ToString()
                    .Cells("subproyecto_logueo").Value = row.Item("Subproyecto").ToString()
                    .Cells("actividad_logueo").Value = row.Item("Actividad").ToString()
                    .Cells("tipo_logueo").Value = row.Item("Tipo").ToString()
                End With
            Next

            Me.dgv_logueo_dia.Columns("fecha_logueo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.dgv_logueo_dia.Columns("hora_entrada_logueo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.dgv_logueo_dia.Columns("hora_salida_logueo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Me.dgv_logueo_dia.Columns("tiempo_logueo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


            If dgv_logueo_dia.Rows.Count > 0 Then
                Dim time_span As TimeSpan
                Dim tiempo As TimeSpan

                For Each row As DataGridViewRow In dgv_logueo_dia.Rows
                    time_span = CDate(row.Cells("hora_salida_logueo").Value).Subtract(CDate(CDate(row.Cells("hora_entrada_logueo").Value).ToString("HH:mm:ss")))
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
                hora = row.Cells("tiempo_logueo").Value.ToString()
                hora = TimeSpan.FromSeconds(CDbl(hora)).ToString("hh\:mm\:ss")
                row.Cells("tiempo_logueo").Value = hora
            Next
            'End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_nombre_cliente_tareas_TextChanged(sender As Object, e As EventArgs) Handles txt_nombre_cliente_tareas.TextChanged

    End Sub

    Private Sub txt_hora_total_TextChanged(sender As Object, e As EventArgs) Handles txt_hora_total.TextChanged

    End Sub

    Private Sub ResumenPeriodicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResumenPeriodicoToolStripMenuItem.Click
        Dim frmResumenPeriodico As New frmResumenPeriodico()
        frmResumenPeriodico.ShowDialog()
    End Sub

    Private Sub dtp_fecha_desde_ValueChanged(sender As Object, e As EventArgs) Handles dtp_fecha_desde.ValueChanged
        ActualizarHorasProyecto()
    End Sub

    Private Sub dtp_fecha_hasta_ValueChanged(sender As Object, e As EventArgs) Handles dtp_fecha_hasta.ValueChanged
        ActualizarHorasProyecto()
    End Sub

    Private Sub dgv_avance_proyecto_ColumnHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_avance_proyecto.ColumnHeaderMouseDoubleClick
        cargarAvances()
    End Sub


    Private Sub dgv_anotaciones_proyecto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_anotaciones_proyecto.CellContentClick

    End Sub

End Class