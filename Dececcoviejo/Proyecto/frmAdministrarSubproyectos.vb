Imports System.Data.SqlClient

Public Class frmAdministrarSubproyectos

    Dim id_proyecto As Integer = 0
    Dim id_subproyecto As Integer = 0
    Dim id_actividad As Integer = 0
    Dim id_actividad_proyecto As Integer = 0
    Dim oSubproyecto As New entSubproyecto
    Dim _ActividadProyecto As New Actividad_proyecto
    Dim _Proyecto As New Proyecto
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

    Public Sub New()
        If Me.verificarPermiso() = False Then
            Exit Sub
        End If

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.DeshabilitarTabs()

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

        _Proyecto.Cargar()
        _Proyecto.Insertar()

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

    Private Sub tv_subproyectos_BeforeCollapse(sender As Object, e As System.Windows.Forms.TreeViewCancelEventArgs) Handles tv_subproyectos.BeforeCollapse
        Me.tv_subproyectos.SelectedNode = e.Node
    End Sub

    Private Sub tv_subproyectos_beforeexpand(sender As Object, e As System.Windows.Forms.TreeViewCancelEventArgs) Handles tv_subproyectos.BeforeExpand
        Me.tv_subproyectos.SelectedNode = e.Node
    End Sub
    Private Sub tv_subproyectos_AfterExpand(sender As Object, e As System.Windows.Forms.TreeViewEventArgs) Handles tv_subproyectos.AfterExpand
        If Me.tv_subproyectos.SelectedNode.Nodes.Count > 0 Then
            If Me.tv_subproyectos.SelectedNode.Nodes(0).Text = " " Then
                Me.refrescarProyecto()
            End If
        End If
    End Sub

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

                With oSubproyecto
                    .Cargar()
                    .Modificar(CInt(dr("id_subproyecto")))
                    .orden = x
                    .Guardar()
                End With

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


                Dim odtAct As New DataTable

                If odtAct.Rows.Count > 0 Or odtProy.Rows.Count > 0 Then
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

                With oActividad_proyecto
                    .Cargar()
                    .Modificar(CInt(dr("id_actividad_proyecto")))
                    .orden = x
                    .Guardar()
                End With

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


                '#########################################
                'prueba de recorrer arbol para hacer horas
                '#########################################
                With oTemp_actividad_proyecto
                    .Cargar()
                    .Insertar()
                    .id_actividad = odr.id_actividad
                    .id_proyecto = odr.id_proyecto
                    .id_actividad_proyecto = CInt(dr("id_actividad_proyecto").ToString)
                    .id_usuario = vgCodigoUsuario
                    .Guardar()
                End With

                x = x + 2
            Next
            Return 0
        Else
            Return 0
        End If
    End Function

    Private Sub tv_subproyectos_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tv_subproyectos.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Right Then

            Me.tv_subproyectos.SelectedNode = Me.tv_subproyectos.GetNodeAt(e.X, e.Y)

            If Me.tv_subproyectos.SelectedNode Is Nothing = False Then
                tsModificarSubproyecto.Visible = True
                tsSeparator1.Visible = True
                tsSeparator2.Visible = True
                ts_borrar_proyecto.Visible = False
                TseparatorActividad.Visible = False
                tsAgregarActividad.Visible = False
                tsBorrarActividad.Visible = False

                If CType(Me.tv_subproyectos.SelectedNode.Tag, stArbol).tipo = "s" Then
                    tsBorrarSubproyecto.Visible = True
                    
                ElseIf CType(Me.tv_subproyectos.SelectedNode.Tag, stArbol).tipo = "p" Then
                    tsAgregarSubproyecto.Visible = True
                    tsBorrarSubproyecto.Visible = False
                    TseparatorActividad.Visible = True
                    tsAgregarActividad.Visible = True
                    ts_borrar_proyecto.Visible = True
                Else
                    TseparatorActividad.Visible = True
                    tsAgregarActividad.Visible = True
                    tsBorrarActividad.Visible = True
                End If

                cmsProyectoAdm.Show(tv_subproyectos, New Point(e.X, e.Y))

            Else
                cmsProyectoAdm.Show(tv_subproyectos, New Point(e.X, e.Y))
                ts_borrar_proyecto.Visible = False
                tsBorrarSubproyecto.Visible = False
                tsAgregarSubproyecto.Visible = False
                tsModificarSubproyecto.Visible = False
                tsSeparator1.Visible = False
                tsSeparator2.Visible = False
                TseparatorActividad.Visible = False
                tsAgregarActividad.Visible = False
                tsBorrarActividad.Visible = False
            End If

        End If

    End Sub

    Private Function GetNodeKeyProyecto(ByVal id_proyecto As Integer, ByVal parentCollection As TreeNodeCollection) As TreeNode
        Dim ret As TreeNode
        Dim child As TreeNode

        For Each child In parentCollection
            If child.Name <> "" Then
                If CInt(child.Name) = id_proyecto Then
                    ret = child
                ElseIf child.GetNodeCount(False) > 0 Then
                    ret = GetNodeKeyProyecto(id_proyecto, child.Nodes)
                End If

                If Not ret Is Nothing Then Exit For

            End If

        Next
        Return ret
    End Function


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
                id_previo = CInt(Me.tv_subproyectos.SelectedNode.Name)
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
        '        .nodo_padre = CDec(Me.tv_subproyectos.SelectedNode.Name)
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
        Me.tv_subproyectos.SelectedNode.Text = odt.Rows(0).Item("nombre proyecto").ToString    'oProyecto.nombre_proyecto

        Dim tab As New DataTable
        tab = oUsuario.ConsultarTodo

        For Each row As DataRow In tab.Rows
            With oModificacion_arbol
                .Cargar()
                .Insertar()
                .id_proyecto = Me.id_subproyecto
                .id_usuario = CInt(row("id usuario"))
                .nodo_padre = CDec(Me.tv_subproyectos.SelectedNode.Name)
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
                .nodo_padre = CDec(Me.tv_subproyectos.SelectedNode.Name)
                .nombre_modificacion_arbol = "tsBorrarProyecto"
                .realizado = False
                .tipo_nodo = "p"
                .nombre = Me.tv_subproyectos.SelectedNode.Text
                .Guardar()
            End With
        Next

        oProyecto.Borrar(Me.id_subproyecto)

        Try
            Dim id_previo As Integer
            id_previo = CInt(Me.tv_subproyectos.SelectedNode.PrevNode.Name)
            Me.id_subproyecto = id_previo
        Catch ex As Exception
        End Try

        tv_subproyectos.Nodes.Remove(tv_subproyectos.SelectedNode)

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

        Me.tv_subproyectos.SelectedNode.Text = oActividad.nombre_actividad

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
                        .nodo = Me.tv_subproyectos.SelectedNode.Index
                        'en vez de guardar el nodo padre guardo este nodo para despues poder modificarle el texto
                        .nodo_padre = CDec(Me.tv_subproyectos.SelectedNode.Name)
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


    Private Sub refrescarProyecto()
        Dim tnParent As New TreeNode()
        tnParent.Text = Me.tv_subproyectos.SelectedNode.Text
        tnParent.Name = Me.tv_subproyectos.SelectedNode.Name
        tnParent.Tag = Me.tv_subproyectos.SelectedNode.Tag
        Dim nodoindex = tv_subproyectos.SelectedNode.Index

        cargarProyecto(tnParent)

        Dim nodo, nodosgte As TreeNode

        If tv_subproyectos.SelectedNode IsNot Nothing Then
            nodo = tv_subproyectos.SelectedNode.Parent
            nodosgte = tv_subproyectos.SelectedNode.NextNode

            Me.tv_subproyectos.SelectedNode = tnParent

            If Me.tv_subproyectos.SelectedNode.Name <> tnParent.Name Then
                Me.tv_subproyectos.SelectedNode = Me.tv_subproyectos.Nodes.Find(tnParent.Name, True)(0)
            End If

            If nodo Is Nothing Then
                If nodosgte Is Nothing Then
                    tv_subproyectos.Nodes.Remove(tv_subproyectos.SelectedNode)
                    tv_subproyectos.Nodes.Add(tnParent)
                Else
                    tv_subproyectos.Nodes.Remove(tv_subproyectos.SelectedNode)
                    tv_subproyectos.Nodes.Insert(nodoindex, tnParent)
                End If
            Else
                If nodosgte Is Nothing Then
                    tv_subproyectos.Nodes.Remove(tv_subproyectos.SelectedNode)
                    nodo.Nodes.Add(tnParent)
                Else
                    tv_subproyectos.Nodes.Remove(tv_subproyectos.SelectedNode)
                    CType(nodo, TreeNode).Nodes.Insert(nodoindex, tnParent)
                End If
            End If
        End If

        tv_subproyectos.SelectedNode = tnParent
        tv_subproyectos.SelectedNode.Expand()
    End Sub

    Private Sub cargarProyecto(ByVal tnParent As TreeNode)

        Me.FillChild(tnParent, tnParent.Name)
        Me.FillChild_actividad(tnParent, tnParent.Name)

    End Sub

    Private Sub cargarGrillaClientes()

        cmb_cliente.DataSource = oCliente.GetCmb() '.GetClientes()
        cmb_cliente.ValueMember = "id_cliente"
        cmb_cliente.DisplayMember = "nombre_cliente"
        cmb_cliente.SelectedIndex = 0

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
        odt = oProyecto.GetTree_conCliente_nvaImpl(CInt(cmb_cliente.SelectedValue))

        tv_subproyectos.Nodes.Clear()

        Dim x As Integer = 1

        For Each dr As DataRow In odt.Rows

            If DirectCast(dr("id_proyecto"), Integer) <> 0 Then
                With oProyecto
                    .Cargar()
                    .Modificar(CInt(dr("id_proyecto")))
                    .nro = x
                    .Guardar()
                End With

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

                tv_subproyectos.Nodes.Add(tnParent)

                'Los proyectos hijos del proyecto
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


        Dim odtAct As New DataTable
        odtAct = oActividad_proyecto.GetAllProyectoConCliente(0, CInt(cmb_cliente.SelectedValue))

        Dim intIconoActividad As Integer = 0
        Dim intIconoActividadSeleccionado As Integer = 0
        Dim odtTempCont As New DataTable

        If odtAct.Rows.Count > 0 Then

            x = 1
            For Each dr As DataRow In odtAct.Rows

                With oActividad_proyecto
                    .Cargar()
                    .Modificar(CInt(dr("id_actividad_proyecto")))
                    .orden = x
                    .Guardar()
                End With

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

                odr.tipo = "a"
                odr.id_proyecto = CInt(dr("id_proyecto"))
                odr.id_actividad = CInt(dr("id_actividad"))
                odr.id_actividad_proyecto = CInt(dr("id_actividad_proyecto"))
                odr.icono = intIconoActividad
                odr.icono_seleccionado = 3
                odr.id_cliente = CInt(cmb_cliente.SelectedValue)
                odr.id_subproyecto = CInt(dr("id_subproyecto"))

                child = tv_subproyectos.Nodes.Add(CStr(CDec(dr("id_actividad")) * -1), CStr(dr("nombre_actividad")), intIconoActividad, 3)
                child.Tag = odr

                x = x + 2
            Next
        End If

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
                dgv_actividades_subproyecto.Rows(index).Cells("id_actividad_proyecto_dgv").Value = CInt(row.Item("id_actividad_proyecto").ToString())
                dgv_actividades_subproyecto.Rows(index).Cells("id_actividad_dgv").Value = CInt(row.Item("id_actividad").ToString())
                dgv_actividades_subproyecto.Rows(index).Cells("id_tipo_actividad_dgv").Value = CInt(row.Item("id_tipo_actividad").ToString())
                dgv_actividades_subproyecto.Rows(index).Cells("nombre_actividad_dgv").Value = CStr(oActividad.GetOne(CInt(row.Item("id_actividad").ToString())).Rows(0).Item("nombre_actividad").ToString())
                dgv_actividades_subproyecto.Rows(index).Cells("tipo_actividad_dgv").Value = oTipo_actividad.GetOne(CInt(row.Item("id_tipo_actividad").ToString())).Rows(0).Item("descripcion").ToString()
                dgv_actividades_subproyecto.Rows(index).Cells("peso_dgv").Value = CDec(oActividad.GetOne(CInt(row.Item("id_actividad").ToString())).Rows(0).Item("costo_standart").ToString())
            End With
        Next

        Me.PesosCorrectosSubproyceto()

    End Sub

    Private Sub cargarDatosProyecto()
        With _Proyecto
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

        Me.txt_nombre_proyecto.Text = _Proyecto.nombre_proyecto
        Me.txt_ot_proyecto.Text = CompletarCerosCodigo(_Proyecto.orden)
        Me.dtp_fecha_inicio_estimada_proyecto.Value = _Proyecto.fecha_inicio
        Me.dtp_fecha_inicio_estimada_proyecto.Value = _Proyecto.fecha_fin_prevista
        Me.txt_descripcion_proyecto.Text = _Proyecto.descripcion

        If _Proyecto.id_estado <> 0 Then
            Me.cmb_estado_proyecto.SelectedValue = _Proyecto.id_estado
        End If

        Try
            Me.cmb_controlador_1.SelectedValue = CInt(_Proyecto.id_controlador_1)
            Me.cmb_controlador_2.SelectedValue = CInt(_Proyecto.id_controlador_2)
        Catch ex As Exception
            Me.cmb_controlador_1.SelectedValue = 0
            Me.cmb_controlador_2.SelectedValue = 0
        End Try

        Me.cmb_pm_proyecto.SelectedValue = _Proyecto.id_proyect_manager
        Me.cmb_piloto_proyecto.SelectedValue = _Proyecto.id_piloto
        Me.txt_horas_proyecto.Text = CStr(_Proyecto.total_hora)
        Me.cmb_prioridad_proyecto.SelectedValue = _Proyecto.prioridad
        Me.chk_archivado_proyecto.Checked = _Proyecto.archivado

        'Controles
        Me.CargarGrillaActividadesControles()

        'Anotaciones
        Me.ActualizarGrillaAnotaciones()

    End Sub

    Private Sub CargarHorasUsuarioXUnidad()
        Dim _usuario_Proyecto As New Usuario_Proyecto
        Dim _Proyecto As New Proyecto
        Dim _Subproyecto As New entSubproyecto
        Dim dr_index As Integer
        Dim id_subproyecto As Integer = Me.id_subproyecto
        Dim dt_usuarios As DataTable
        Dim suma_usuario, suma_unidad As Double

        Me.dgv_horas_unidades.Rows.Clear()
        Me.dgv_horas_unidades.Columns.Clear()


        dr_index = Me.dgv_horas_unidades.Columns.Add("id_usuario", "id_usuario")
        Me.dgv_horas_unidades.Columns(dr_index).Visible = False

        Me.dgv_horas_unidades.Columns.Add("nombre_usuario", "Usuario")

        If Me.id_subproyecto = 0 Then
            id_subproyecto = 1
            dt_usuarios = _Proyecto.GetHorasTrabajadas(Me.id_proyecto)
        Else
            dt_usuarios = _Proyecto.GetHorasTrabajadasSubproyecto(Me.id_subproyecto)
        End If

        Dim dt_subproyecto As DataTable = _Subproyecto.ObtenerPorProyecto(Me.id_proyecto, id_subproyecto)
        For Each row As DataRow In dt_subproyecto.Rows
            Me.dgv_horas_unidades.Columns.Add(row.Item("id_subproyecto").ToString(), row.Item("nombre").ToString())
        Next
        dr_index = Me.dgv_horas_unidades.Columns.Add("total_horas_usuario", "Total")
        Me.dgv_horas_unidades.Columns(dr_index).DefaultCellStyle.BackColor = Color.LightGray
        Me.dgv_horas_unidades.Columns(dr_index).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


        For Each row As DataRow In dt_usuarios.Rows
            dr_index = Me.dgv_horas_unidades.Rows.Add()
            Me.dgv_horas_unidades.Rows(dr_index).Cells("id_usuario").Value = row.Item("id_usuario")
            Me.dgv_horas_unidades.Rows(dr_index).Cells("nombre_usuario").Value = row.Item("Usuario")
            For Each row_subproyecto As DataGridViewColumn In Me.dgv_horas_unidades.Columns
                If row_subproyecto.Index > 1 And row_subproyecto.Index < Me.dgv_horas_unidades.Columns.Count - 1 Then
                    dt_usuarios = _Proyecto.GetHorasTrabajadasSubproyecto(CInt(row_subproyecto.Name))
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
            Me.dgv_horas_unidades.Rows(dr_index).DefaultCellStyle.BackColor = Color.LightGray
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
            dt_unidades = _Proyecto.GetUnidades(Me._Proyecto.id_proyecto)
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
            dt_unidades = _Proyecto.GetUnidades(Me._Proyecto.id_proyecto)
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

        Dim _Actividad As New Actividad
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

        Me.clearTabActividad()
        Me.txtnombre_actividad.Text = _Actividad.nombre_actividad
        Me.cmbtipo_actividad.SelectedValue = _Actividad.id_tipo_actividad
        Me.txt_motivo_actividad.Text = _ActividadProyecto.observacion
        Me.chk_asignada.Checked = _ActividadProyecto.asignada
        Me.chk_forzar_inicio_actividad.Checked = _ActividadProyecto.forzada_fecha_inicio
        Me.chk_forzar_fin_actividad.Checked = _ActividadProyecto.forzada_fecha_fin

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

        dgvLogueo.Rows.Clear()

        For Each row As DataRow In odtMovimientoHora.Rows
            dr_index = dgvLogueo.Rows.Add()
            With dgvLogueo.Rows(dr_index)
                .Cells("id_cuerpo_movimiento_hora_login_dgv").Value = row.Item("id_cuerpo_movimiento_hora")
                .Cells("hora_entrada_tarea").Value = row.Item("Inicio")
                .Cells("hora_salida_tarea").Value = row.Item("Fin")
                .Cells("tiempo_tarea").Value = row.Item("Tiempo")
                .Cells("fecha_tarea").Value = row.Item("Fecha")
                .Cells("nombre_usuario_tarea").Value = row.Item("Usuario")
                .Cells("id_movimiento_hora_login_dgv").Value = row.Item("id_movimiento_hora")
            End With
        Next

        Dim hora As String

        For Each row As DataGridViewRow In dgvLogueo.Rows
            hora = row.Cells("tiempo_tarea").Value.ToString()
            hora = TimeSpan.FromSeconds(CDbl(hora)).ToString("hh\:mm\:ss")
            row.Cells("tiempo_tarea").Value = hora
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


    Private Sub tv_subproyectos_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles tv_subproyectos.MouseDoubleClick
        Me.cargando_datos = True

        Me.id_proyecto = CType(tv_subproyectos.SelectedNode.Tag, stArbol).id_proyecto
        Me.id_subproyecto = CType(tv_subproyectos.SelectedNode.Tag, stArbol).id_subproyecto
        Me.id_actividad = CType(tv_subproyectos.SelectedNode.Tag, stArbol).id_actividad
        Me.id_actividad_proyecto = CType(tv_subproyectos.SelectedNode.Tag, stArbol).id_actividad_proyecto

        If Me.selected_node_to_modify Is Nothing = False Then
            Try
                selected_node_to_modify.BackColor = Color.Gainsboro
            Catch ex As Exception

            End Try
        End If

        With _ActividadProyecto
            .Cargar()
            .Insertar()
        End With

        With _Proyecto
            .Cargar()
            .Insertar()
        End With

        With oSubproyecto
            .Cargar()
            .Insertar()
        End With

        Me.LimpiarDatosControl()

        If CType(tv_subproyectos.SelectedNode.Tag, stArbol).tipo = "p" Then
            If Me.id_proyecto <> 0 Then
                Me.clearTabSubproyecto()
                Me.clearTabActividad()
                Me.cargarDatosProyecto()
                Me.CargarDatosAvancesyHoras()
                TabControl1.SelectedIndex = 0
                'Me.CargarHorasUsuarioXUnidad()
            End If
        ElseIf CType(tv_subproyectos.SelectedNode.Tag, stArbol).tipo = "s" Then
            If Me.id_subproyecto <> 0 Then
                Me.cargarDatosProyecto()
                Me.cargarDatosSubproyecto()
                Me.CargarDatosAvancesyHoras()
                Me.clearTabActividad()
                'Me.CargarHorasUsuarioXUnidad()
                TabControl1.SelectedIndex = 1
            End If
        ElseIf CType(tv_subproyectos.SelectedNode.Tag, stArbol).tipo = "a" Then
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
            TabControl1.SelectedIndex = 2
        End If

        Select Case TabControl1.SelectedIndex
            Case 0
                tab_Subproyecto.Enabled = False
                tab_Actividad.Enabled = False
                tab_asignar_actividad.Enabled = False
                tab_Proyecto.Enabled = True
                tabPage_avances.Enabled = True
                tabPage_horas.Enabled = True
            Case 1
                tab_Subproyecto.Enabled = True
                tab_Actividad.Enabled = False
                tab_asignar_actividad.Enabled = False
                tab_Proyecto.Enabled = True
                tabPage_avances.Enabled = True
                tabPage_horas.Enabled = True
            Case 2
                tab_Actividad.Enabled = True
                tab_asignar_actividad.Enabled = True
                tab_Proyecto.Enabled = True
                tabPage_avances.Enabled = False
                tabPage_horas.Enabled = True
        End Select

        selected_node_to_modify = tv_subproyectos.SelectedNode
        Me.tv_subproyectos.SelectedNode.BackColor = Color.LightGreen
        Me.cargando_datos = False


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
        odp = CType(tv_subproyectos.SelectedNode.Tag, stArbol)
        Dim selectedNode As TreeNode
        selectedNode = Me.tv_subproyectos.SelectedNode

        If odp.tipo <> "a" Then

            selectedNode = Me.tv_subproyectos.SelectedNode

            Dim frmNuevo As New frmAgregarSubproyecto(odp.id_proyecto, odp.id_subproyecto)
            frmNuevo.ShowDialog()
            refrescarProyecto()

            Me.tv_subproyectos.SelectedNode = selectedNode
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
            .id_cliente = _Proyecto.id_cliente
            .id_proyecto = _Proyecto.id_proyecto
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

        'MessageBox.Show("Datos actualizados correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        'Else
        'MessageBox.Show("Por favor, corrija los pesos de las actividades", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If

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

        Me.tv_subproyectos.Nodes.Find(CStr(oProyecto.id_proyecto), False).First().Text = oProyecto.nombre_proyecto
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

        Me.tv_subproyectos.SelectedNode = Me.addNodoProyecto(oProyecto.nombre_proyecto, oProyecto.id_proyecto)
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

        tv_subproyectos.Nodes.Add(tnParent)

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
            total_peso = total_peso + CDec(row.Cells("Peso_dgv").Value)
        Next

        Me.lbl_suma_pesos_subproyecto.Text = total_peso.ToString("0.00")

        If (total_peso < 99 Or total_peso > 101) And total_peso <> 0 Then
            Me.btn_guardar_subproyecto.Enabled = False
            Me.lbl_suma_pesos_subproyecto.ForeColor = Color.OrangeRed
        Else
            Me.btn_guardar_subproyecto.Enabled = True
            Me.lbl_suma_pesos_subproyecto.ForeColor = Color.Green
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
            total_peso = total_peso + CDec(row.Cells("Peso_dgv").Value)
        Next

        For Each row As DataGridViewRow In dgv_actividades_subproyecto.Rows
            row.Cells("Peso_dgv").Value = CDec(row.Cells("Peso_dgv").Value) / total_peso * 100
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
                    .Modificar(CInt(row.Cells("id_actividad_dgv").Value))
                    .costo_standart = CDec(row.Cells("peso_dgv").Value)
                    .Guardar()
                End With

                With oActividad_proyecto
                    .Cargar()
                    .Modificar(CInt(row.Cells("id_actividad_proyecto_dgv").Value))
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
            Me.tv_subproyectos.Nodes.Find(CStr(oSubproyecto.id_suproyecto), True).First().Text = oSubproyecto.nombre
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
                    .Modificar(CInt(Me.dgv_actividades_subproyecto.SelectedRows(0).Cells("id_actividad_proyecto_dgv").Value))
                    .orden = selected_index
                    .Guardar()

                    .Cargar()
                    .Modificar(CInt(Me.dgv_actividades_subproyecto.Rows(selected_index - 1).Cells("id_actividad_proyecto_dgv").Value))
                    .orden = selected_index + 2
                    .Guardar()
                End With

                Me.cargarActividadesenGrillaSubproyectos()

                If CType(selected_node_to_modify.Tag, stArbol).tipo = "a" Then
                    Dim key As String = CStr(CDec(CType(selected_node_to_modify.Tag, stArbol).id_actividad) * -1)
                    Dim nodo_parent As TreeNode = Me.selected_node_to_modify.Parent
                    Me.ActualziarArbol(nodo_parent)
                    Me.selected_node_to_modify = Me.tv_subproyectos.Nodes.Find(key, True).First()
                    Me.selected_node_to_modify.BackColor = Color.LightGreen
                    Me.tv_subproyectos.SelectedNode = Me.selected_node_to_modify
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
            Dim id_seleccionado As Integer = CInt(Me.dgv_actividades_subproyecto.SelectedRows(0).Cells("id_actividad_proyecto_dgv").Value)

            If selected_index < Me.dgv_actividades_subproyecto.Rows.Count - 1 Then
                With oActividad_proyecto
                    .Cargar()
                    .Modificar(id_seleccionado)
                    .orden = selected_index + 2
                    .Guardar()

                    .Cargar()
                    .Modificar(CInt(Me.dgv_actividades_subproyecto.Rows(selected_index + 1).Cells("id_actividad_proyecto_dgv").Value))
                    .orden = selected_index
                    .Guardar()
                End With

                Me.cargarActividadesenGrillaSubproyectos()

                If CType(selected_node_to_modify.Tag, stArbol).tipo = "a" Then
                    Dim key As String = CStr(CDec(CType(selected_node_to_modify.Tag, stArbol).id_actividad) * -1)
                    Dim nodo_parent As TreeNode = Me.selected_node_to_modify.Parent
                    Me.ActualziarArbol(nodo_parent)
                    Me.selected_node_to_modify = Me.tv_subproyectos.Nodes.Find(key, True).First()
                    Me.selected_node_to_modify.BackColor = Color.LightGreen
                    Me.tv_subproyectos.SelectedNode = Me.selected_node_to_modify
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
                If (.HayHorasCargadas(CInt(dgv_actividades_subproyecto.SelectedRows(0).Cells("id_actividad_proyecto_dgv").Value))) Then
                    MessageBox.Show("Hay horas logueadas en la actividad seleccionada. No se puede borrar.", "Horas logueadas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            End With

            With oActividad_proyecto
                .Cargar()
                .Borrar(CInt(dgv_actividades_subproyecto.SelectedRows(0).Cells("id_actividad_proyecto_dgv").Value))
            End With

            With oActividad
                .Cargar()
                .Borrar(CInt(dgv_actividades_subproyecto.SelectedRows(0).Cells("id_actividad_dgv").Value))
            End With

            'las tareas
            Dim _Detalle_Recurso As New Detalle_recurso
            Dim odt As New DataTable
            odt = _Detalle_Recurso.GetCmb()
            For Each row As DataRow In odt.Rows
                If CInt(row.Item("id_actividad_proyecto")) = CInt(dgv_actividades_subproyecto.SelectedRows(0).Cells("id_actividad_proyecto_dgv").Value) Then
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_guardar_Actividad.Click

        Dim _Actividad As New Actividad

        'If Me.chk_tiene_control_actividad.Checked = False And Me.chk_actividad_proveedor.Checked = True Then
        '    MessageBox.Show("Si la actividad es de proveedor, debe ingresar un control", "Ingrese control", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Exit Sub
        'End If

        If Me.chk_actividad_proveedor.Checked = True And Me.cmb_actividad_proveedor.SelectedValue Is Nothing Then
            MessageBox.Show("Por favor, seleccione el proveedor", "Seleccione proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
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
        Me.tv_subproyectos.Nodes.Find("-" + CStr(Me.id_actividad), True).First().Text = _Actividad.nombre_actividad
        MessageBox.Show("Datos actualizados correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


    End Sub


    Private Sub tsBorrarSubproyecto_Click(sender As Object, e As EventArgs) Handles tsBorrarSubproyecto.Click
        If IsNothing(tv_subproyectos.SelectedNode) = False Then

            If oSubproyecto.hayLogueos(CInt(CType(Me.tv_subproyectos.SelectedNode.Tag, stArbol).id_subproyecto)) Then
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
            '        .nodo_padre = CDec(Me.tv_subproyectos.SelectedNode.Name)
            '        .nombre_modificacion_arbol = "tsBorrarProyecto"
            '        .realizado = False
            '        .tipo_nodo = "p"
            '        .nombre = Me.tv_subproyectos.SelectedNode.Text
            '        .Guardar()
            '    End With
            'Next

            oSubproyecto.Borrar(CInt(CType(Me.tv_subproyectos.SelectedNode.Tag, stArbol).id_subproyecto))

            tv_subproyectos.Nodes.Remove(tv_subproyectos.SelectedNode)
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

    Private Sub buscarNodoSubproyecto(ByVal id_subproyecto As Integer)
        Dim nodo As TreeNode
        Dim tvn() As TreeNode

        Dim id_proyecto, id_cliente As Integer
        With oSubproyecto
            .Cargar()
            .Modificar(id_subproyecto)
            id_proyecto = .id_proyecto

            oProyecto.Modificar(.id_proyecto)
            id_cliente = oProyecto.id_cliente
        End With

        cmb_cliente.SelectedValue = id_cliente
        Load_tree()

        Dim tabla As New DataTable
        tabla = oProyecto.GetOne_2(id_proyecto)

        Dim arr() As Integer
        ReDim arr(0)
        arr(0) = CInt(tabla.Rows(0).Item("Id_proyecto"))
        Dim b As Boolean = True


        Dim proy As Integer
        tvn = Me.tv_subproyectos.Nodes.Find(CStr(id_proyecto), True)

        If tvn.Length = 0 Then

            proy = CInt(tabla.Rows(0).Item("Id_proyecto"))
            nodo = tv_subproyectos.SelectedNode 'nodo le asigno algo solo para q tome el valor q adquiere en for

            Try
                For index As Integer = 0 To arr.Count - 1
                    tvn = Me.tv_subproyectos.Nodes.Find(CStr(arr(index)), True)
                    If tvn.Length > 0 Then
                        For indice As Integer = index To 0 Step -1

                            Me.tv_subproyectos.SelectedNode = Me.tv_subproyectos.Nodes.Find(CStr(arr(indice)), True)(0)
                            nodo = Me.tv_subproyectos.SelectedNode 'Next
                            refrescarProyecto()
                        Next
                        Exit For
                    End If
                Next
            Catch ex As Exception

            End Try


        Else
            Dim nd() As TreeNode = Me.tv_subproyectos.Nodes.Find("-" & id_actividad, True)
            If nd.Length = 0 Then
                Me.tv_subproyectos.SelectedNode = tvn(0)
                refrescarProyecto()
            End If
        End If

        Dim dt As DataTable
        dt = oSubproyecto.ObtenerPadres(id_subproyecto)

        Dim i As Integer = dt.Rows.Count - 1

        For Each row As DataRow In dt.Rows
            tvn = Me.tv_subproyectos.Nodes.Find(CStr(dt.Rows(i).Item("id_subproyecto")), True)

            Dim nd() As TreeNode = Me.tv_subproyectos.Nodes.Find("-" & id_actividad, True)
            If nd.Length = 0 Then
                Me.tv_subproyectos.SelectedNode = tvn(0)
                refrescarProyecto()
            End If

            i = i - 1
        Next
    End Sub

    Private Sub buscarNodo(ByVal id_actividad_proyecto As Integer)
        Dim nodo As TreeNode
        Dim tvn() As TreeNode

        Dim id_actividad, id_proyecto, id_subproyecto, id_cliente As Integer
        With oActividad_proyecto
            .Cargar()
            .Modificar(id_actividad_proyecto)
            id_actividad = .id_actividad
            id_proyecto = .id_proyecto
            id_subproyecto = .id_subproyecto
        End With

        oProyecto.Modificar(id_proyecto)
        id_cliente = oProyecto.id_cliente


        cmb_cliente.SelectedValue = id_cliente
        Load_tree()

        Dim tabla As New DataTable
        tabla = oProyecto.GetOne_2(id_proyecto)

        Dim arr() As Integer
        ReDim arr(0)
        arr(0) = CInt(tabla.Rows(0).Item("Id_proyecto"))
        Dim padre As Integer = CInt(tabla.Rows(0).Item("Id_proyecto_padre"))
        Dim b As Boolean = True



        Dim proy As Integer
        tvn = Me.tv_subproyectos.Nodes.Find(CStr(id_proyecto), True)

        If tvn.Length = 0 Then

            proy = CInt(tabla.Rows(0).Item("Id_proyecto"))
            nodo = tv_subproyectos.SelectedNode 'nodo le asigno algo solo para q tome el valor q adquiere en for

            Try
                For index As Integer = 0 To arr.Count - 1
                    tvn = Me.tv_subproyectos.Nodes.Find(CStr(arr(index)), True)
                    If tvn.Length > 0 Then
                        For indice As Integer = index To 0 Step -1

                            Me.tv_subproyectos.SelectedNode = Me.tv_subproyectos.Nodes.Find(CStr(arr(indice)), True)(0)
                            nodo = Me.tv_subproyectos.SelectedNode 'Next
                            refrescarProyecto()

                        Next
                        Exit For
                    End If
                Next
            Catch ex As Exception

            End Try


        Else
            Dim nd() As TreeNode = Me.tv_subproyectos.Nodes.Find("-" & id_actividad, True)
            If nd.Length = 0 Then
                Me.tv_subproyectos.SelectedNode = tvn(0)
                refrescarProyecto()
            End If
        End If

        If id_subproyecto <> 0 Then
            Dim dt As DataTable
            dt = oSubproyecto.ObtenerPadres(id_subproyecto)

            Dim i As Integer = dt.Rows.Count - 1

            For Each row As DataRow In dt.Rows
                tvn = Me.tv_subproyectos.Nodes.Find(CStr(dt.Rows(i).Item("id_subproyecto")), True)

                Dim nd() As TreeNode = Me.tv_subproyectos.Nodes.Find("-" & id_actividad, True)
                If nd.Length = 0 Then
                    Me.tv_subproyectos.SelectedNode = tvn(0)
                    refrescarProyecto()
                End If

                i = i - 1
            Next
        End If


        nodo = GetNodeKeyProyecto(CInt("-" & id_actividad), tv_subproyectos.Nodes)
        If nodo IsNot Nothing Then
            b = False
            tv_subproyectos.SelectedNode = nodo
        End If

    End Sub

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
        tvn = Me.tv_subproyectos.Nodes.Find(CStr(id_proyecto), True)

        If tvn.Length = 0 Then

            proy = CInt(tabla.Rows(0).Item("Id_proyecto"))
            nodo = tv_subproyectos.SelectedNode 'nodo le asigno algo solo para q tome el valor q adquiere en for

            Try
                For index As Integer = 0 To arr.Count - 1
                    tvn = Me.tv_subproyectos.Nodes.Find(CStr(arr(index)), True)
                    If tvn.Length > 0 Then
                        For indice As Integer = index To 0 Step -1

                            Me.tv_subproyectos.SelectedNode = Me.tv_subproyectos.Nodes.Find(CStr(arr(indice)), True)(0)
                            nodo = Me.tv_subproyectos.SelectedNode 'Next
                            refrescarProyecto()

                        Next
                        Exit For
                    End If
                Next
            Catch ex As Exception

            End Try

        Else
            Dim nd() As TreeNode = Me.tv_subproyectos.Nodes.Find("-" & id_actividad, True)
            If nd.Length = 0 Then
                Me.tv_subproyectos.SelectedNode = tvn(0)
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
        tvn = Me.tv_subproyectos.Nodes.Find(CStr(id_proyecto), True)

        If tvn.Length = 0 Then

            proy = CInt(tabla.Rows(0).Item("Id_proyecto"))
            nodo = tv_subproyectos.SelectedNode 'nodo le asigno algo solo para q tome el valor q adquiere en for

            Try
                For index As Integer = 0 To arr.Count - 1
                    tvn = Me.tv_subproyectos.Nodes.Find(CStr(arr(index)), True)
                    If tvn.Length > 0 Then
                        For indice As Integer = index To 0 Step -1

                            Me.tv_subproyectos.SelectedNode = Me.tv_subproyectos.Nodes.Find(CStr(arr(indice)), True)(0)
                            nodo = Me.tv_subproyectos.SelectedNode 'Next
                            refrescarProyecto()

                        Next
                        Exit For
                    End If
                Next
            Catch ex As Exception

            End Try


        Else
            Dim nd() As TreeNode = Me.tv_subproyectos.Nodes.Find("-" & id_actividad, True)
            If nd.Length = 0 Then
                Me.tv_subproyectos.SelectedNode = tvn(0)
                refrescarProyecto()
            End If
        End If

        Dim dt As DataTable
        dt = oSubproyecto.ObtenerPadres(id_subproyecto)

        Dim i As Integer = dt.Rows.Count - 1

        For Each row As DataRow In dt.Rows
            tvn = Me.tv_subproyectos.Nodes.Find(CStr(dt.Rows(i).Item("id_subproyecto")), True)

            Dim nd() As TreeNode = Me.tv_subproyectos.Nodes.Find("-" & id_actividad, True)
            If nd.Length = 0 Then
                Me.tv_subproyectos.SelectedNode = tvn(0)
                refrescarProyecto()
            End If

            i = i - 1
        Next

        nodo = GetNodeKeyProyecto(CInt("-" & id_actividad), tv_subproyectos.Nodes)
        If nodo IsNot Nothing Then
            b = False
            tv_subproyectos.SelectedNode = nodo
        End If


    End Sub

    Private Sub tsmiAgregarActividad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsAgregarActividad.Click

        If tv_subproyectos.SelectedNode IsNot Nothing Then
            Dim odt As stArbol = CType(tv_subproyectos.SelectedNode.Tag, stArbol)
            Dim id_actividad_actual As Integer = 0

            With oActividad
                .Cargar()
                .Insertar()
                .id_tipo_actividad = CInt(oActividad.GetTipoActividad().Rows(0).Item("id_tipo_actividad"))
                .nombre_actividad = CStr(oActividad.GetTipoActividad().Rows(0).Item("descripcion"))
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
        Dim odt As stArbol = CType(tv_subproyectos.SelectedNode.Tag, stArbol)

        If odt.tipo = "a" Then

            Dim selected_node As TreeNode = tv_subproyectos.SelectedNode.Parent
            Me.tv_subproyectos.SelectedNode = selected_node

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
            Me.tv_subproyectos.SelectedNode.Expand()

        End If
    End Sub

    Private Sub btn_arriba_proyecto_Click(sender As Object, e As EventArgs) Handles btn_arriba_proyecto.Click
        If Me.tv_subproyectos.SelectedNode IsNot Nothing Then
            Dim to_modify As Boolean = False
            Dim info As stArbol = CType(Me.tv_subproyectos.SelectedNode.Tag, stArbol)

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
                        Me.tv_subproyectos.Focus()
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
                        Me.tv_subproyectos.Focus()
                        Exit Sub
                    End If
                End With

                Me.tv_subproyectos.SelectedNode = Me.tv_subproyectos.SelectedNode.Parent
                Me.refrescarProyecto()
                Me.tv_subproyectos.SelectedNode = Me.tv_subproyectos.Nodes.Find(CStr(info.id_subproyecto), True)(0)

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
                        Me.tv_subproyectos.Focus()
                        Exit Sub
                    End If
                End With

                Me.tv_subproyectos.SelectedNode = Me.tv_subproyectos.SelectedNode.Parent
                Me.refrescarProyecto()
                Me.tv_subproyectos.SelectedNode = Me.tv_subproyectos.Nodes.Find(CStr(info.id_actividad * -1), True)(0)

            End If

            If to_modify Then
                Me.selected_node_to_modify = Me.tv_subproyectos.SelectedNode
                Me.selected_node_to_modify.BackColor = Color.LightGreen
            Else
                Me.actualizarColorModificar()
            End If

            Me.tv_subproyectos.Focus()

        End If
    End Sub

    Private Sub btn_abajo_proyecto_Click(sender As Object, e As EventArgs) Handles btn_abajo_proyecto.Click

        If Me.tv_subproyectos.SelectedNode IsNot Nothing Then

            Dim to_modify As Boolean = False
            Dim info As stArbol = CType(Me.tv_subproyectos.SelectedNode.Tag, stArbol)

            If info.tipo = "p" Then

                If CType(selected_node_to_modify.Tag, stArbol).id_proyecto = info.id_proyecto Then
                    to_modify = True
                End If

                With oProyecto
                    .Cargar()
                    .Modificar(info.id_proyecto)
                    If .nro < Me.tv_subproyectos.GetNodeCount(False) * 2 - 1 Then
                        .nro = .nro + 3
                        .Guardar()
                    Else
                        Me.tv_subproyectos.Focus()
                        Exit Sub
                    End If

                End With

                Me.buscarNodoProyecto(info.id_proyecto)

            ElseIf info.tipo = "s" Then

                If CType(selected_node_to_modify.Tag, stArbol).id_subproyecto = info.id_subproyecto Then
                    to_modify = True
                End If

                With oSubproyecto
                    .Cargar()
                    .Modificar(info.id_subproyecto)
                    If .orden < Me.tv_subproyectos.SelectedNode.Parent.Nodes.Count * 2 - 1 Then
                        .orden = .orden + 3
                        .Guardar()
                    Else
                        Me.tv_subproyectos.Focus()
                        Exit Sub
                    End If
                End With

                Me.tv_subproyectos.SelectedNode = Me.tv_subproyectos.SelectedNode.Parent
                Me.refrescarProyecto()
                Me.tv_subproyectos.SelectedNode = Me.tv_subproyectos.Nodes.Find(CStr(info.id_subproyecto), True)(0)

            ElseIf info.tipo = "a" Then

                If CType(selected_node_to_modify.Tag, stArbol).id_actividad_proyecto = info.id_actividad_proyecto Then
                    to_modify = True
                End If

                With oActividad_proyecto
                    .Cargar()
                    .Modificar(info.id_actividad_proyecto)
                    If .orden < Me.tv_subproyectos.SelectedNode.Parent.Nodes.Count * 2 - 1 Then
                        .orden = .orden + 3
                        .Guardar()
                    Else
                        Me.tv_subproyectos.Focus()
                        Exit Sub
                    End If
                End With

                Me.tv_subproyectos.SelectedNode = Me.tv_subproyectos.SelectedNode.Parent
                Me.refrescarProyecto()
                Me.tv_subproyectos.SelectedNode = Me.tv_subproyectos.Nodes.Find(CStr(info.id_actividad * -1), True)(0)

            End If

            If to_modify Then
                Me.selected_node_to_modify = Me.tv_subproyectos.SelectedNode
                Me.selected_node_to_modify.BackColor = Color.LightGreen
            Else
                Me.actualizarColorModificar()
            End If

            Me.tv_subproyectos.Focus()

        End If

    End Sub

    Private Sub actualizarColorModificar()

        If Me.selected_node_to_modify IsNot Nothing Then
            Dim dt As stArbol = CType(Me.selected_node_to_modify.Tag, stArbol)
            Dim node As TreeNode

            If dt.tipo = "a" Then
                node = Me.tv_subproyectos.Nodes.Find(CStr(dt.id_actividad * -1), True)(0)
            ElseIf dt.tipo = "p" Then
                node = Me.tv_subproyectos.Nodes.Find(CStr(dt.id_proyecto), True)(0)
            ElseIf dt.tipo = "s" Then
                node = Me.tv_subproyectos.Nodes.Find(CStr(dt.id_subproyecto), True)(0)
            End If

            Me.selected_node_to_modify = node
            node.BackColor = Color.LightGreen

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
        ElseIf _Proyecto IsNot Nothing Then
            dt = _Proyecto.ObtenerActividadesControl(_Proyecto.id_proyecto)
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
                        cell.Style.BackColor = Color.White
                    Next
                End If
            End If
        End If

    End Sub

    Private Sub CargarDatosControl()

        Me.LimpiarDatosControl()

        If selected_rowControl IsNot Nothing Then
            For Each cell As DataGridViewCell In selected_rowControl.Cells
                cell.Style.BackColor = Color.White
            Next
        End If

        Me.CargarEstado(CInt(dgv_actividades_control.Rows(Me.dgv_actividades_control.SelectedRows(0).Index).Cells("id_movimiento_voz_control").Value))

        Me.grp_detalle.Enabled = True
        Me.grp_estado.Enabled = True
        Me.grp_responsables.Enabled = True

        Me.selected_rowControl = Me.dgv_actividades_control.Rows(Me.dgv_actividades_control.SelectedRows(0).Index)
        For Each cell As DataGridViewCell In selected_rowControl.Cells
            cell.Style.BackColor = Color.LightGreen
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

        With _Movimiento_Voz
            .Cargar()
            .Insertar()
        End With

        tab_control.Enabled = True

        With _Proyecto
            .Cargar()
            .Insertar()
        End With

        With oSubproyecto
            .Cargar()
            .Insertar()
        End With

        Me.dgv_actividades_asignados.Rows.Clear()

    End Sub

    Private Sub dgv_actividades_control_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_actividades_control.CellClick

        'Click en botón Ver
        If e.ColumnIndex = dgv_actividades_control.Columns("btn_ver_control").Index Then
            If CBool(dgv_actividades_control.Rows(e.RowIndex).Cells("control").Value) Then
                Try
                    Background_pdf.RunWorkerAsync(CInt(dgv_actividades_control.Rows(e.RowIndex).Cells("id_movimiento_voz_control").Value))
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
                    Me.tv_subproyectos.SelectedNode = Me.tv_subproyectos.Nodes.Find(CStr(oSubproyecto.id_suproyecto), True).First()
                    Me.refrescarProyecto()
                Catch ex As Exception

                End Try
            Else
                MessageBox.Show("La actividad ya posee un control asignado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub Background_pdf_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Background_pdf.DoWork
        Try
            Dim proc As New ProcedimientosParticulares
            proc.RealizarProcedimiento(CInt(e.Argument))

        Catch ex As Exception
            MessageBox.Show("Error al mostrar el procedimiento: " + ex.Message)
        End Try
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

    Private Sub borrarcontrol()
        Try
            If Not oUsuario_permiso.TienePermiso(vgCodigoUsuario, 68) Then
                MessageBox.Show("No tiene permisos para realizar esta operación")
                Exit Sub
            End If

            oMovimiento_voz.BorrarConControlesRealizados(CInt(Me.selected_rowControl.Cells("id_movimiento_voz_control").Value))
            Me.refrescarProyecto()
            Me.CargarGrillaActividadesControles()
            Me.LimpiarDatosControl()
            MessageBox.Show("Control borrado exitosamene", "Borrar Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al borrar el control: " + ex.Message, "Borrar Control", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btn_buscar_ot_Click(sender As Object, e As EventArgs) Handles btn_buscar_ot.Click
        Try
            Dim id_subproyecto As Integer
            id_subproyecto = CInt(oSubproyecto.ObtenerPorOT("0", Me.txt_buscar_ot.Text).Rows(0).Item("id_subproyecto"))

            Me.buscarNodoSubproyecto(id_subproyecto)
            If Me.tv_subproyectos.SelectedNode IsNot Nothing Then
                If CType(Me.tv_subproyectos.SelectedNode.Tag, stArbol).id_subproyecto = id_subproyecto Then
                    Me.tv_subproyectos_MouseDoubleClick(Nothing, Nothing)
                End If
            End If
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

    Private Sub ts_borrar_proyecto_Click(sender As Object, e As EventArgs) Handles ts_borrar_proyecto.Click
        Dim odt As stArbol = CType(tv_subproyectos.SelectedNode.Tag, stArbol)

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

        Me.dgv_tareas_pendientes.Rows.Clear()

        For Each row As DataRow In odt.Rows
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
            End With
        Next

    End Sub

    Private Sub cmb_usuarios_asignar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_usuarios_asignar.SelectedIndexChanged
        Try
            Me.dgv_tareas_pendientes.Rows.Clear()
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
                cell.Style.BackColor = Color.White
            Next
        End If

        Dim dt_horas As DataTable

        Me.dgv_avance_proyecto.Rows.Clear()

        If _ActividadProyecto IsNot Nothing And _ActividadProyecto.id_actividad_proyecto <> 0 Then
            Dim Actividad As New Actividad()
            dt_horas = Actividad.GetHorasTrabajadas(_ActividadProyecto.id_actividad_proyecto)
        ElseIf id_subproyecto = 0 Then
            dt_horas = _Proyecto.GetHorasTrabajadas(_Proyecto.id_proyecto)
        Else
            dt_horas = _Proyecto.GetHorasTrabajadasSubproyecto(oSubproyecto.id_suproyecto)
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
                    cell.Style.BackColor = Color.White
                Next
            End If

            ultima_fila_unidad = dgv_unidades_proyecto.SelectedRows(0)
            Dim dt_horas As DataTable
            dt_horas = _Proyecto.GetHorasTrabajadasSubproyecto(CInt(ultima_fila_unidad.Cells("id_subproyecto_dgv").Value))
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

    Private Sub dgv_avance_proyecto_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_avance_proyecto.CellDoubleClick
        If Me.dgv_avance_proyecto.SelectedRows.Count > 0 Then
            If e.ColumnIndex = Me.dgv_avance_proyecto.Columns("concepto").Index Or e.ColumnIndex = Me.dgv_avance_proyecto.Columns("resp_concepto").Index Then
                'Seleccionó concepto
                _Proyecto = New Proyecto()
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
                _Proyecto = New Proyecto()
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
                _Proyecto = New Proyecto()
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

        If Me.id_actividad_proyecto <> 0 Then
            Me.cargarDatosActividad()
        End If

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


        If Me.id_actividad_proyecto <> 0 Then
            Me.cargarDatosActividad()
        End If

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
                    .cantidad_hora = txtnum_cantidad_horas_asignar.Value
                    .porcentaje_avance = 0
                    .realizada = False
                    .tipo = "-"
                    .Guardar()
                End With

                Dim _Detalle_Recurso_2 As New Detalle_recurso
                Dim odt_pendiente As DataTable
                odt_pendiente = _Detalle_Recurso_2.GetAllPendiente()

            Catch ex As Exception
                MessageBox.Show("Ha ocurrido un problema al asignar la actividad: " + ex.Message, "Asignación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
            'End If

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

                If e.RowIndex = Me.dgv_actividades_asignados.Columns("realizada_asignado").Index Then
                    Me.dgv_actividades_asignados.Rows(e.RowIndex).Cells("forzada_asignado").Value = Not CBool(Me.dgv_actividades_asignados.Rows(e.RowIndex).Cells("realizada_asignado").Value)
                ElseIf e.RowIndex = Me.dgv_actividades_asignados.Columns("forzada_asignado").Index Then
                    Me.dgv_actividades_asignados.Rows(e.RowIndex).Cells("realizada_asignado").Value = Not CBool(Me.dgv_actividades_asignados.Rows(e.RowIndex).Cells("forzada_asignado").Value)
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
        If TabControl1.SelectedIndex = 7 Then ' Horas x subproyecto
            Me.CargarHorasUsuarioXUnidad()
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
        Try
            Dim id_detalle_recurso As Integer = CInt(dgv_actividades_asignados.SelectedRows(0).Cells("id_detalle_recurso_asignado").Value)
            With _Detalle_Recurso
                .Cargar()
                .Borrar(id_detalle_recurso)
            End With
            Me.CargarDatosAsignaciones()
        Catch ex As Exception

        End Try
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
                cms_anotaciones.Show(dgv_anotaciones_proyecto, New Point(e.X, e.Y))
            End If
        End If
    End Sub
End Class