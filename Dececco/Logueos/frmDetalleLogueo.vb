Public Class frmDetalleLogueo

    Dim id_cuerpo_movimiento_hora As Integer = 0
    Dim id_cuerpo_movimiento_hora_inicial As Integer
    Dim rows_to_add As New List(Of Integer)
    Dim datos_inconsistentes As Boolean = False
    Dim sin_errores As Boolean = True
    Dim cambios_pendientes As Boolean = False
    Dim style_normal As New DataGridViewCellStyle
    Dim style_seleccionada As New DataGridViewCellStyle
    Dim ordenada As Boolean = False
    Dim oSubproyecto As New entSubproyecto


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

    Public Sub New(ByVal id_cuerpo_movimiento_hora As Integer)
        Me.id_cuerpo_movimiento_hora = id_cuerpo_movimiento_hora
        Me.id_cuerpo_movimiento_hora_inicial = id_cuerpo_movimiento_hora
        InitializeComponent()
    End Sub


    Private Sub frmDetalleLogueo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.dtp_fecha_hasta.Value = Date.Today
        Me.dtp_fecha_desde.Value = Date.Today
        Me.dtp_fecha.Value = Date.Today

        cargarGrillaClientes()
        cargarDatos()
        dgv_movimiento_hora.Columns("entrada").ValueType = GetType(Date)
        dgv_movimiento_hora.Columns("salida").ValueType = GetType(Date)
        calcularTiemposMuertos()


        With style_seleccionada
            .BackColor = Color.Green
            .Font = New Font("Tahoma", 8.0F, FontStyle.Bold)
            .ForeColor = Color.White
        End With

        With style_normal
            .BackColor = Color.White
            .Font = New Font("Tahoma", 8.0F, FontStyle.Regular)
            .ForeColor = Color.Black
        End With

        Me.cambios_pendientes = False

        


        'dgv_movimiento_hora.Sort(dgv_movimiento_hora.Columns("entrada"), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Public Sub Load_tree()

        Dim odr As New stArbol
        Dim id_color_proyecto As Integer = 0

        Dim odt As New DataTable
        odt = oProyecto.GetTree_conCliente_nvaImpl(CInt(cmb_cliente.SelectedValue))

        tv_subproyectos.Nodes.Clear()

        Dim x As Integer = 0

        For Each dr As DataRow In odt.Rows
            x = x + 1
            If DirectCast(dr("id_proyecto"), Integer) <> 0 Then

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

            End If
        Next


        Dim odtAct As New DataTable
        odtAct = oActividad_proyecto.GetAllProyectoConCliente(0, CInt(cmb_cliente.SelectedValue))

        Dim intIconoActividad As Integer = 0
        Dim intIconoActividadSeleccionado As Integer = 0

        Dim odtTempCont As New DataTable

        If odtAct.Rows.Count > 0 Then

            x = 0
            For Each dr As DataRow In odtAct.Rows
                x = x + 1

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
            Next
        End If

    End Sub


    Private Sub cargarGrillaClientes()
        cmb_cliente.DataSource = oCliente.GetCmb()
        cmb_cliente.ValueMember = "id_cliente"
        cmb_cliente.DisplayMember = "nombre_cliente"
        cmb_cliente.SelectedIndex = 0

        Dim dt As New DataTable
        dt = oUsuario.ConsultarNombreCompleto()
        cmb_usuarios.DataSource = dt
        cmb_usuarios.ValueMember = "Id_usuario"
        cmb_usuarios.DisplayMember = "Nombre_completo"
        cmb_usuarios.SelectedIndex = 0
    End Sub


    Private Sub cmb_cliente_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_cliente.SelectedIndexChanged
        Try
            If CInt(cmb_cliente.SelectedValue) <> 0 Then
                Load_tree()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tv_subproyectos_BeforeCollapse(sender As Object, e As TreeViewCancelEventArgs) Handles tv_subproyectos.BeforeCollapse
        Me.tv_subproyectos.SelectedNode = e.Node
    End Sub

    Private Sub tv_subproyectos_AfterExpand(sender As Object, e As TreeViewEventArgs) Handles tv_subproyectos.AfterExpand
        If Me.tv_subproyectos.SelectedNode.Nodes.Count > 0 Then
            If Me.tv_subproyectos.SelectedNode.Nodes(0).Text = " " Then
                Me.refrescarProyecto()
            End If
        End If
    End Sub

    Private Sub tv_subproyectos_BeforeExpand(sender As Object, e As TreeViewCancelEventArgs) Handles tv_subproyectos.BeforeExpand
        Me.tv_subproyectos.SelectedNode = e.Node
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
        Me.tv_subproyectos.SelectedNode = tnParent

        FillChild(tnParent, tnParent.Name)
        Me.FillChild_actividad(tnParent, tnParent.Name)

    End Sub


    Private Sub cargarDatos()
        If id_cuerpo_movimiento_hora <> 0 Then

            Dim dt As DataTable
            dt = oCuerpo_movimiento_hora.GetOne(id_cuerpo_movimiento_hora)

            Dim id_actividad_proyecto, id_subproyecto, id_usuario, id_proyecto As Integer
            id_proyecto = 0
            id_subproyecto = 0

            id_actividad_proyecto = CInt(oCuerpo_movimiento_hora.GetOne(id_cuerpo_movimiento_hora).Rows(0).Item("id_actividad_proyecto"))

            If id_actividad_proyecto <> 0 Then
                id_subproyecto = CInt(oActividad_proyecto.GetOne_2(id_actividad_proyecto).Rows(0).Item("id_subproyecto"))
                id_proyecto = CInt(oActividad_proyecto.GetOne_2(id_actividad_proyecto).Rows(0).Item("id_proyecto"))
                id_usuario = CInt(oMovimiento_hora.GetOne(CInt(oCuerpo_movimiento_hora.GetOne(id_cuerpo_movimiento_hora).Rows(0).Item("id_movimiento_hora"))).Rows(0).Item("id_usuario"))

                If id_subproyecto <> 0 Then
                    oSubproyecto.Modificar(id_subproyecto)
                    cmb_cliente.SelectedValue = CInt(oProyecto.GetCliente(oSubproyecto.id_proyecto).Rows(0).Item("id_cliente"))
                Else
                    oProyecto.Modificar(id_proyecto)
                    cmb_cliente.SelectedValue = oProyecto.id_cliente
                End If
                

                If id_usuario <> CInt(cmb_usuarios.SelectedValue) Then
                    cmb_usuarios.SelectedValue = id_usuario
                End If
            End If


            If dt.Rows.Count > 0 Then
                cargarActividadProyecto()
                If CDate(dt.Rows(0).Item("Salida")) < dtp_fecha_desde.Value Then
                    dtp_fecha_desde.Value = CDate(dt.Rows(0).Item("Entrada"))
                    dtp_fecha_hasta.Value = CDate(dt.Rows(0).Item("Salida"))
                Else
                    dtp_fecha_hasta.Value = CDate(dt.Rows(0).Item("Salida"))
                    dtp_fecha_desde.Value = CDate(dt.Rows(0).Item("Entrada"))
                End If
            End If

            'Setea la fecha del datetimepicker como la primera fecha de entrada
            If dt.Rows.Count > 0 And CDate(dtp_fecha.Value.ToShortDateString()) <> CDate(CDate(dt.Rows(0).Item("Entrada")).ToShortDateString()) Then
                dtp_fecha.Value = CDate(dt.Rows(0).Item("Entrada"))
            End If

            'Fondo de color verde al logueo que se está modificando
            For Each row As DataGridViewRow In dgv_movimiento_hora.Rows
                If CInt(row.Cells("id_cuerpoMovimientoHora").Value) = id_cuerpo_movimiento_hora Then
                    For Each cell As DataGridViewCell In row.Cells
                        cell.Style = style_seleccionada
                    Next
                End If
            Next

            cmb_usuarios.Enabled = False
            dtp_fecha.Enabled = False

            buscarNodo(id_actividad_proyecto)

        Else
            btnAceptar.Enabled = False
            cmb_usuarios.Enabled = True
            dtp_fecha.Enabled = True

        End If
    End Sub

    Private Sub cargarActividadProyecto()
        Dim dt As DataTable
        dt = oActividad_proyecto.GetOne_2(CInt(oCuerpo_movimiento_hora.GetOne(id_cuerpo_movimiento_hora).Rows(0).Item("id_actividad_proyecto")))

        Try

            Dim nodo As TreeNode
            Dim tvn() As TreeNode

            'If CType(sender, DataGridView).Focus Then
            Dim tabla As New DataTable
            tabla = oProyecto.GetOne_2(CInt(dt.Rows(0).Item("id_proyecto")))

            Dim arr() As Integer
            ReDim arr(0)
            arr(0) = CInt(tabla.Rows(0).Item("Id_proyecto"))

            Dim padre As Integer = CInt(tabla.Rows(0).Item("Id_proyecto_padre"))
            Dim b As Boolean = True

            If padre = CInt(cmb_cliente.SelectedValue) Or padre = 1 Then
                If CBool(tabla.Rows(0).Item("archivado")) = True Then
                    b = False
                End If
            End If

            If padre <> 1 Then

                While padre <> CInt(cmb_cliente.SelectedValue)
                    ReDim Preserve arr(UBound(arr) + 1)
                    tabla = oProyecto.GetOne_2(padre)
                    padre = CInt(tabla.Rows(0).Item("Id_proyecto_padre"))
                    arr(UBound(arr)) = CInt(tabla.Rows(0).Item("Id_proyecto"))
                    If CBool(tabla.Rows(0).Item("archivado")) = True Then
                        b = False
                        Exit While
                    End If
                End While
            Else
                b = False
            End If

            While b
                Dim proy As Integer
                tvn = Me.tv_subproyectos.Nodes.Find(CStr(dt.Rows(0).Item("id_proyecto")), True)

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
                    Dim nd() As TreeNode = Me.tv_subproyectos.Nodes.Find("-" & dt.Rows(0).Item("id_actividad").ToString(), True)
                    If nd.Length = 0 Then
                        Me.tv_subproyectos.SelectedNode = tvn(0)
                        refrescarProyecto()
                    End If
                End If

                nodo = GetNodeKeyProyecto(CInt("-" & dt.Rows(0).Item("id_actividad").ToString()), tv_subproyectos.Nodes)
                If nodo IsNot Nothing Then
                    b = False
                End If

            End While

            tv_subproyectos.SelectedNode = GetNodeKeyProyecto(CInt("-" & dt.Rows(0).Item("id_actividad").ToString()), tv_subproyectos.Nodes)

            If tv_subproyectos.SelectedNode.SelectedImageIndex = (0 Or -1) Then
                Me.tv_subproyectos.SelectedNode = Me.tv_subproyectos.Nodes.Find("-" & dt.Rows(0).Item("id_actividad").ToString(), True)(0)
            End If
            tv_subproyectos.Select()
        Catch ex As Exception

        End Try
    End Sub

    Private Function GetNodeKeyProyecto(ByVal id_proyecto As Integer, ByVal parentCollection As TreeNodeCollection) As TreeNode
        Dim ret As TreeNode
        Dim child As TreeNode

        For Each child In parentCollection 'step through the parentcollection
            If child.Name <> "" Then
                If CInt(child.Name) = id_proyecto Then
                    ret = child
                ElseIf child.GetNodeCount(False) > 0 Then ' if there is child items then call this function recursively
                    ret = GetNodeKeyProyecto(id_proyecto, child.Nodes)
                End If

                If Not ret Is Nothing Then Exit For 'if something was found, exit out of the for loop

            End If

        Next
        Return ret
    End Function

    Private Sub tv_subproyectos_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tv_subproyectos.AfterSelect
        Try
            Dim odt As stArbol = CType(tv_subproyectos.SelectedNode.Tag, stArbol)
            txt_proyecto_seleccionado.Text = ""

            If odt.id_subproyecto <> 0 Then
                txt_proyecto_seleccionado.Text = oSubproyecto.ObtenerProycetoYPath(odt.id_subproyecto).Rows(0).Item("nombre_subproyecto").ToString() 'oProyecto.GetOne_2(CType(tv_subproyectos.SelectedNode.Tag, stArbol).id_proyecto).Rows(0).Item("path").ToString()
            Else
                txt_proyecto_seleccionado.Text = oProyecto.GetOne_2(CType(tv_subproyectos.SelectedNode.Tag, stArbol).id_proyecto).Rows(0).Item("nombre_proyecto").ToString()
            End If

            If CType(tv_subproyectos.SelectedNode.Tag, stArbol).tipo = "a" Then
                txt_actividad_seleccionada.Text = oActividad.GetOne(CType(tv_subproyectos.SelectedNode.Tag, stArbol).id_actividad).Rows(0).Item("nombre_actividad").ToString()

                If CInt(cmb_usuarios.SelectedValue) <> 0 Then
                    btnAceptar.Enabled = True
                End If

                For Each row As DataGridViewRow In dgv_movimiento_hora.Rows
                    If CInt(row.Cells("id_cuerpoMovimientoHora").Value) = id_cuerpo_movimiento_hora Then
                        row.Cells("id_actividad_proyecto").Value = CType(tv_subproyectos.SelectedNode.Tag, stArbol).id_actividad_proyecto
                        row.Cells("Actividad").Value = oActividad.GetOne(CType(tv_subproyectos.SelectedNode.Tag, stArbol).id_actividad).Rows(0).Item("nombre_actividad")
                        row.Cells("Proyecto").Value = txt_proyecto_seleccionado.Text
                    End If
                Next
            Else
                txt_actividad_seleccionada.Text = ""
                btnAceptar.Enabled = False
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If calcularTiemposMuertos() Then
            Dim result As DialogResult
            result = MessageBox.Show("Hay tiempos entre trabajos que no se han registrado, ¿Desea continuar de todas maneras?", "Tiempos sin trabajar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

            If result = System.Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        End If
        verificarErrores()

        If sin_errores Then
            Dim id_movimiento_hora, aux_id_cuerpo_movimiento_hora As Integer

            For Each row As DataGridViewRow In dgv_movimiento_hora.Rows
                If CBool(row.Cells("no_trabajado").Value) = False Then
                    id_movimiento_hora = CInt(row.Cells("id_movimiento_hora").Value)
                    aux_id_cuerpo_movimiento_hora = CInt(row.Cells("id_cuerpoMovimientoHora").Value)
                    With oCuerpo_movimiento_hora
                        .Cargar()
                        .Modificar(aux_id_cuerpo_movimiento_hora)
                        .entrada = CDate(row.Cells("Entrada").Value)
                        .salida = CDate(row.Cells("Salida").Value)
                        .id_actividad_proyecto = CInt(row.Cells("id_actividad_proyecto").Value)
                        .id_movimiento_hora = id_movimiento_hora
                        .Guardar()
                    End With
                End If
            Next

            MessageBox.Show("Guardado exitosamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            MessageBox.Show("Debe corregir los errores antes de guardar los cambios", "Errores encontrados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        id_cuerpo_movimiento_hora = 0
        cmb_usuarios.Enabled = True
        dtp_fecha.Enabled = True
        Me.cambios_pendientes = False
        clear()

    End Sub

    Private Sub dtp_fecha_ValueChanged(sender As Object, e As EventArgs) Handles dtp_fecha.ValueChanged

        Dim fecha As New Date(dtp_fecha.Value.Year, dtp_fecha.Value.Month, dtp_fecha.Value.Day, dtp_fecha_desde.Value.Hour, dtp_fecha_desde.Value.Minute, dtp_fecha_desde.Value.Second)
        dtp_fecha_desde.Value = fecha

        fecha = New Date(dtp_fecha.Value.Year, dtp_fecha.Value.Month, dtp_fecha.Value.Day, dtp_fecha_hasta.Value.Hour, dtp_fecha_hasta.Value.Minute, dtp_fecha_hasta.Value.Second)
        dtp_fecha_hasta.Value = fecha

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim result = MessageBox.Show("¿Está seguro que desea cancelar?", "Cancelar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub actualizarGrillaMovimientoHora()
        Try
            If CInt(cmb_usuarios.SelectedValue) <> 0 Then

                Dim index As Integer
                Dim dt As DataTable
                Dim dr As DataGridViewRow

                btnAceptar.Enabled = True
                dgv_movimiento_hora.Rows.Clear()

                'Busca los logueos para el usuario seleccionado y el dia
                dt = oCuerpo_movimiento_hora.ObtenerPorusuarioYFecha(CInt(cmb_usuarios.SelectedValue), dtp_fecha.Value)

                For Each row As DataRow In dt.Rows
                    index = dgv_movimiento_hora.Rows.Add()

                    dr = dgv_movimiento_hora.Rows(index)
                    dr.Cells("id_movimiento_hora").Value = row.Item("id_movimiento_hora")
                    dr.Cells("id_cuerpoMovimientoHora").Value = row.Item("id_cuerpo_movimiento_hora")
                    dr.Cells("id_actividad_proyecto").Value = row.Item("id_actividad_proyecto")
                    dr.Cells("Entrada").Value = CDate(row.Item("Entrada"))
                    dr.Cells("Salida").Value = CDate(row.Item("Salida"))
                    dr.Cells("Proyecto").Value = row.Item("Proyecto")
                    dr.Cells("Actividad").Value = row.Item("Actividad")
                    dr.Cells("Subproyecto").Value = row.Item("Subproyecto")
                    dr.Cells("no_trabajado").Value = False
                Next

                Me.dgv_movimiento_hora.Columns("id_movimiento_hora").Visible = False
                Me.dgv_movimiento_hora.Columns("id_cuerpoMovimientoHora").Visible = False
                Me.dgv_movimiento_hora.Columns("id_actividad_proyecto").Visible = False
                Me.dgv_movimiento_hora.Columns("Proyecto").ReadOnly = True
                Me.dgv_movimiento_hora.Columns("Actividad").ReadOnly = True

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmb_usuarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_usuarios.SelectedIndexChanged, dtp_fecha.ValueChanged
        Try
            'Si no seleccionó ningun usuario limpia la grilla
            If CInt(cmb_usuarios.SelectedValue) = 0 Then
                Me.dgv_movimiento_hora.Rows.Clear()
            Else
                'Actualiza la grilla con los datos del usuario y fechas
                actualizarGrillaMovimientoHora()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub tv_subproyectos_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tv_subproyectos.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            Me.tv_subproyectos.SelectedNode = Me.tv_subproyectos.GetNodeAt(e.X, e.Y)
        End If
    End Sub

    Private Sub dgv_movimiento_hora_CellValueChanged(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgv_movimiento_hora.RowValidating

        If e.RowIndex <> -1 And Me.Enabled Then

            Dim fecha_hora, nueva_fecha_salida, nueva_fecha_entrada As Date

            fecha_hora = CDate(dgv_movimiento_hora.Rows(e.RowIndex).Cells("salida").Value)
            nueva_fecha_salida = New Date(dtp_fecha.Value.Year, dtp_fecha.Value.Month, dtp_fecha.Value.Day, fecha_hora.Hour, fecha_hora.Minute, fecha_hora.Second)

            fecha_hora = CDate(dgv_movimiento_hora.Rows(e.RowIndex).Cells("entrada").Value)
            nueva_fecha_entrada = New Date(dtp_fecha.Value.Year, dtp_fecha.Value.Month, dtp_fecha.Value.Day, fecha_hora.Hour, fecha_hora.Minute, fecha_hora.Second)

            'Se valida proque cuando se cambian los datos del datetimepicker se valida antes que se termine de cargar y salta error
            dgv_movimiento_hora.Rows(e.RowIndex).Cells("salida").Value = nueva_fecha_salida
            dgv_movimiento_hora.Rows(e.RowIndex).Cells("entrada").Value = nueva_fecha_entrada

            'Verifica que la hora de entrada sea menor que la de salida
            If CDate(dgv_movimiento_hora.Rows(e.RowIndex).Cells("entrada").Value) > CDate(dgv_movimiento_hora.Rows(e.RowIndex).Cells("salida").Value) Then
                MessageBox.Show("La hora de salida no puede ser anterior a la de entrada", "Verifique los datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.Cancel = True
                Exit Sub
            End If

            'Actualiza el datetimepicker del formulario
            If CInt(dgv_movimiento_hora.Rows(e.RowIndex).Cells("id_cuerpoMovimientoHora").Value) = id_cuerpo_movimiento_hora Then

                'Se valida proque cuando se cambian los datos del datetimepicker se valida antes que se termine de cargar y salta error
                If nueva_fecha_entrada > dtp_fecha_hasta.Value Then
                    dtp_fecha_hasta.Value = nueva_fecha_salida
                    dtp_fecha_desde.Value = nueva_fecha_entrada
                Else
                    dtp_fecha_desde.Value = nueva_fecha_entrada
                    dtp_fecha_hasta.Value = nueva_fecha_salida
                End If

                cambios_pendientes = True

            End If

            Me.verificarErrores()
        End If

    End Sub

    Private Sub dtp_fecha_desde_ValueChanged(sender As Object, e As EventArgs) Handles dtp_fecha_hasta.ValueChanged, dtp_fecha_desde.ValueChanged
        'Back color verde
        For Each row As DataGridViewRow In dgv_movimiento_hora.Rows
            If CInt(row.Cells("id_cuerpoMovimientoHora").Value) = id_cuerpo_movimiento_hora Then
                If dtp_fecha_desde.Value > dtp_fecha_hasta.Value Then
                    MessageBox.Show("La hora de salida no puede ser anterior a la de entrada", "Verifique los datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                row.Cells("entrada").Value = dtp_fecha_desde.Value
                row.Cells("salida").Value = dtp_fecha_hasta.Value
            End If
        Next
        cambios_pendientes = True
    End Sub

    ''' <summary>
    ''' Calcula que no haya tiempos sin trabajar entre los logueos del día
    ''' </summary>
    ''' <returns>Verdadero si hay tiempos muertos</returns>
    ''' <remarks></remarks>
    Private Function calcularTiemposMuertos() As Boolean

        Dim rows As New DataGridViewRowCollection(dgv_movimiento_hora)
        Dim row As Integer
        Dim hayEspaciosSinTrabajar As Boolean = False

        'Variable que indica que la grilla no está ordenada por fecha
        Me.ordenada = False

        'Elimina los logueos que no estén trabajados (no están en la base de datos)
        For Each row_1 As DataGridViewRow In dgv_movimiento_hora.Rows
            If CBool(row_1.Cells("no_trabajado").Value) = True Then
                dgv_movimiento_hora.Rows.Remove(row_1)
            End If
        Next

        Dim fecha_salida, fecha_menor As Date


        For Each row_1 As DataGridViewRow In dgv_movimiento_hora.Rows

            If CBool(row_1.Cells("no_trabajado").Value) = False Then
                fecha_salida = CDate(row_1.Cells("salida").Value)
                fecha_menor = Nothing

                For Each row_2 As DataGridViewRow In dgv_movimiento_hora.Rows
                    If row_2.Index > row_1.Index And CBool(row_2.Cells("no_trabajado").Value) = False Then
                        If fecha_menor = Nothing And CDate(row_2.Cells("entrada").Value).Subtract(fecha_salida).TotalMilliseconds > -1000 Then
                            fecha_menor = CDate(row_2.Cells("entrada").Value)
                        Else
                            If CDate(row_2.Cells("entrada").Value) < fecha_menor And CDate(row_2.Cells("entrada").Value).Subtract(fecha_salida).TotalMilliseconds > -1000 Then
                                fecha_menor = CDate(row_2.Cells("entrada").Value)
                            End If
                        End If
                    End If
                Next

                'Agrega una fila con información sobre logueo no trabajado
                If fecha_menor.Subtract(fecha_salida).TotalMinutes > 1 Then
                    row = dgv_movimiento_hora.Rows.Add()
                    dgv_movimiento_hora.Rows(row).Cells("id_movimiento_hora").Value = CInt(row_1.Cells("id_movimiento_hora").Value)
                    dgv_movimiento_hora.Rows(row).Cells("id_cuerpoMovimientoHora").Value = 0
                    dgv_movimiento_hora.Rows(row).Cells("id_actividad_proyecto").Value = 0
                    dgv_movimiento_hora.Rows(row).Cells("entrada").Value = fecha_salida.AddSeconds(1)
                    dgv_movimiento_hora.Rows(row).Cells("salida").Value = fecha_menor.AddSeconds(-1)
                    dgv_movimiento_hora.Rows(row).Cells("no_trabajado").Value = True
                    hayEspaciosSinTrabajar = True
                End If
            End If
        Next

        dgv_movimiento_hora.Sort(dgv_movimiento_hora.Columns("entrada"), System.ComponentModel.ListSortDirection.Ascending)

        Return hayEspaciosSinTrabajar
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        calcularTiemposMuertos()
    End Sub

    Private Sub agregarLogueo()

        'Si no hay ningún usuario seleccionado sale
        If CInt(cmb_usuarios.SelectedValue) = 0 Then
            MessageBox.Show("Seleccione un usuario", "Seleccionar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Try
            'Si no hubo ningun logueo ese día, entonces crea un objeto para Movimiento Hora
            Dim id_movimiento_hora, id_actividad_proyecto As Integer
            If dgv_movimiento_hora.RowCount > 0 Then
                id_movimiento_hora = CInt(dgv_movimiento_hora.Rows(0).Cells("id_movimiento_hora").Value)
            Else
                With oMovimiento_hora
                    .Cargar()
                    .Insertar()
                    .id_dia = 1
                    .fecha = dtp_fecha.Value
                    .id_usuario = CInt(cmb_usuarios.SelectedValue)
                    .Guardar()
                    id_movimiento_hora = .id_movimiento_hora
                End With
            End If

            tv_subproyectos.Nodes.Clear()
            cmb_cliente.SelectedIndex = 0

            Dim row As Integer
            id_actividad_proyecto = 0
            row = dgv_movimiento_hora.Rows.Add()
            dgv_movimiento_hora.Rows(row).Cells("id_actividad_proyecto").Value = id_actividad_proyecto
            btnAceptar.Enabled = False
            MessageBox.Show("Este cambio es permanente. Si desea cancelarlo haga click derecho sobre el ítem agregado y seleccione la opción Borrar", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If dgv_movimiento_hora.RowCount = 1 Then
                dgv_movimiento_hora.Rows(row).Cells("salida").Value = dtp_fecha_hasta.Value.AddSeconds(1)
                dgv_movimiento_hora.Rows(row).Cells("entrada").Value = dtp_fecha_desde.Value.AddSeconds(1)
            Else
                dgv_movimiento_hora.Rows(row).Cells("salida").Value = CDate(dgv_movimiento_hora.Rows(dgv_movimiento_hora.RowCount - 2).Cells("salida").Value).AddHours(1)
                dgv_movimiento_hora.Rows(row).Cells("entrada").Value = CDate(dgv_movimiento_hora.Rows(dgv_movimiento_hora.RowCount - 2).Cells("salida").Value).AddSeconds(1)
            End If

            'Inserta el nuevo logueo en la base de datos
            With oCuerpo_movimiento_hora
                .Cargar()
                .Insertar()
                .id_movimiento_hora = id_movimiento_hora
                .id_actividad_proyecto = id_actividad_proyecto
                .salida = CDate(dgv_movimiento_hora.Rows(row).Cells("salida").Value)
                .entrada = CDate(dgv_movimiento_hora.Rows(row).Cells("entrada").Value)
                .id_tipo_logueo = 3
                .Guardar()
                id_cuerpo_movimiento_hora = .id_cuerpo_movimiento_hora
            End With

            dgv_movimiento_hora.Rows(row).Cells("id_movimiento_hora").Value = id_movimiento_hora
            dgv_movimiento_hora.Rows(row).Cells("id_cuerpoMovimientoHora").Value = id_cuerpo_movimiento_hora

            For Each fila As DataGridViewRow In dgv_movimiento_hora.Rows
                If CInt(fila.Cells("id_cuerpoMovimientoHora").Value) = id_cuerpo_movimiento_hora_inicial Then
                    For Each cell As DataGridViewCell In fila.Cells
                        cell.Style = style_normal
                    Next
                End If
            Next
            For Each cell As DataGridViewCell In dgv_movimiento_hora.Rows(row).Cells
                cell.Style.BackColor = Color.Green
            Next

            dgv_movimiento_hora.ClearSelection()
            dgv_movimiento_hora.Rows(row).Selected = True

            id_cuerpo_movimiento_hora_inicial = id_cuerpo_movimiento_hora

            cargarDatos()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ts_agregar_Click(sender As Object, e As EventArgs) Handles ts_agregar.Click
        Me.agregarLogueo()
    End Sub

    Private Sub ts_modificar_Click(sender As Object, e As EventArgs) Handles ts_modificar.Click

        'Despinta si alguna fila está en estado de modificación (color verde)
        For Each fila As DataGridViewRow In dgv_movimiento_hora.Rows
            If CInt(fila.Cells("id_cuerpoMovimientoHora").Value) = id_cuerpo_movimiento_hora Then
                For Each cell As DataGridViewCell In fila.Cells
                    cell.Style = style_normal
                Next
            End If
        Next

        id_cuerpo_movimiento_hora = CInt(dgv_movimiento_hora.SelectedRows(0).Cells("id_cuerpoMovimientoHora").Value)
        id_cuerpo_movimiento_hora_inicial = id_cuerpo_movimiento_hora

        'Si modifica una fila que no está con logueo, entonces crea uno con la info de la primera fila
        If CInt(dgv_movimiento_hora.SelectedRows(0).Cells("id_cuerpomovimientohora").Value) = 0 And CBool(dgv_movimiento_hora.SelectedRows(0).Cells("no_trabajado").Value) = True Then
            Try
                Dim id_movimiento_hora, id_actividad_proyecto As Integer

                'Id del primer valor
                id_movimiento_hora = CInt(dgv_movimiento_hora.Rows(0).Cells("id_movimiento_hora").Value)

                'Si no hay nada, crea uno nuevo
                If id_movimiento_hora = 0 Then

                    With oMovimiento_hora
                        .Cargar()
                        .Insertar()
                        .id_dia = 1
                        .id_usuario = CInt(cmb_usuarios.SelectedValue)
                        .Guardar()
                        id_movimiento_hora = .id_movimiento_hora
                    End With

                End If

                'Si seleccionó una actividad en el arbol, guarda el id
                If CType(tv_subproyectos.SelectedNode.Tag, stArbol).tipo = "a" Then
                    id_actividad_proyecto = CInt(oActividad_proyecto.GetOne_3(CType(tv_subproyectos.SelectedNode.Tag, stArbol).id_proyecto, CType(tv_subproyectos.SelectedNode.Tag, stArbol).id_actividad).Rows(0).Item("id_actividad_proyecto"))
                Else
                    id_actividad_proyecto = 0
                End If

                'Crea un nuevo registro en la base de datos
                With oCuerpo_movimiento_hora
                    .Cargar()
                    .Insertar()
                    .id_movimiento_hora = id_movimiento_hora
                    .id_actividad_proyecto = id_actividad_proyecto
                    .entrada = CDate(dgv_movimiento_hora.SelectedRows(0).Cells("Entrada").Value)
                    .salida = CDate(dgv_movimiento_hora.SelectedRows(0).Cells("Salida").Value)
                    .id_tipo_logueo = 3
                    .Guardar()
                    id_cuerpo_movimiento_hora = .id_cuerpo_movimiento_hora
                End With

                Dim row As Integer
                row = dgv_movimiento_hora.SelectedRows(0).Index
                dgv_movimiento_hora.Rows(row).Cells("id_movimiento_hora").Value = id_movimiento_hora
                dgv_movimiento_hora.Rows(row).Cells("id_cuerpoMovimientoHora").Value = id_cuerpo_movimiento_hora

                'Si hay algun nodo seleccionado en el arbol, le agrega los datos a la grilla
                If (tv_subproyectos.SelectedNode Is Nothing) = False Then
                    'Si esta seleccionada una actividad, guarda el id en la grilla
                    If CType(tv_subproyectos.SelectedNode.Tag, stArbol).tipo = "a" Then
                        id_actividad_proyecto = CInt(oActividad_proyecto.GetOne_3(CType(tv_subproyectos.SelectedNode.Tag, stArbol).id_proyecto, CType(tv_subproyectos.SelectedNode.Tag, stArbol).id_actividad).Rows(0).Item("id_actividad_proyecto"))
                        dgv_movimiento_hora.Rows(row).Cells("id_actividad_proyecto").Value = id_actividad_proyecto
                        dgv_movimiento_hora.Rows(row).Cells("Actividad").Value = oActividad.GetOne(CType(tv_subproyectos.SelectedNode.Tag, stArbol).id_actividad).Rows(0).Item("nombre_actividad")
                        dgv_movimiento_hora.Rows(row).Cells("Proyecto").Value = oProyecto.GetOne(CType(tv_subproyectos.SelectedNode.Tag, stArbol).id_proyecto).Rows(0).Item("nombre proyecto").ToString()
                    Else
                        'Sino le asigna valor 0 y deshabilita el botón Aceptar
                        dgv_movimiento_hora.Rows(row).Cells("id_actividad_proyecto").Value = 0
                        btnAceptar.Enabled = False
                    End If
                Else
                    dgv_movimiento_hora.Rows(row).Cells("id_actividad_proyecto").Value = 0
                    btnAceptar.Enabled = False
                End If

                Me.dgv_movimiento_hora.Rows(row).Cells("no_trabajado").Value = False
                Me.dgv_movimiento_hora.Rows(row).Cells("salida").Value = oCuerpo_movimiento_hora.salida
                Me.dgv_movimiento_hora.Rows(row).Cells("entrada").Value = oCuerpo_movimiento_hora.entrada
                Me.dgv_movimiento_hora.ClearSelection()
                Me.dgv_movimiento_hora.Rows(row).Selected = True

                id_cuerpo_movimiento_hora_inicial = id_cuerpo_movimiento_hora

            Catch ex As Exception

            End Try
        End If

        cargarDatos()
        calcularTiemposMuertos()
    End Sub


    Private Sub dgv_movimiento_hora_MouseDown(sender As Object, e As MouseEventArgs) Handles dgv_movimiento_hora.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim currentMouseOverRow As Integer
            currentMouseOverRow = dgv_movimiento_hora.HitTest(e.X, e.Y).RowIndex

            If currentMouseOverRow >= 0 Then
                dgv_movimiento_hora.ClearSelection()
                dgv_movimiento_hora.Rows(currentMouseOverRow).Selected = True
            End If
        End If
    End Sub

    Private Sub borrarLogueo()
        If dgv_movimiento_hora.SelectedRows.Count > 0 Then
            Dim aux_id_cuerpo_movimiento_hora As Integer
            aux_id_cuerpo_movimiento_hora = CInt(dgv_movimiento_hora.SelectedRows(0).Cells("id_cuerpoMovimientoHora").Value)

            Dim result As DialogResult
            result = MessageBox.Show("El registro se eliminará permanentemente del sistema, ¿Desea continuar?", "Borrar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = System.Windows.Forms.DialogResult.Yes Then
                With oCuerpo_movimiento_hora
                    .Cargar()
                    .Borrar(aux_id_cuerpo_movimiento_hora)
                End With
                dgv_movimiento_hora.Rows().RemoveAt(dgv_movimiento_hora.SelectedRows(0).Index)

                If dgv_movimiento_hora.RowCount > 0 Then
                    dgv_movimiento_hora.ClearSelection()
                    dgv_movimiento_hora.Rows(0).Selected = True

                    If Me.id_cuerpo_movimiento_hora = aux_id_cuerpo_movimiento_hora Then
                        id_cuerpo_movimiento_hora = CInt(dgv_movimiento_hora.SelectedRows(0).Cells("id_cuerpoMovimientoHora").Value)
                        id_cuerpo_movimiento_hora_inicial = id_cuerpo_movimiento_hora

                        cargarDatos()
                    End If
                Else
                    Me.id_cuerpo_movimiento_hora = 0
                    Me.id_cuerpo_movimiento_hora_inicial = 0
                End If
            End If
        End If
    End Sub

    Private Sub ts_borrar_Click(sender As Object, e As EventArgs) Handles ts_borrar.Click
        Me.borrarLogueo()
    End Sub

    Private Sub verificarCambios()
        'Llevar esto al data changed de dtp_fecha y cmb_usuario

        Dim resultado As DialogResult
        resultado = MessageBox.Show("Si hizo alguna modificación en los registros, éstos se perderán. ¿Desea continuar cambiando de usuario?", "Cambiar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resultado = System.Windows.Forms.DialogResult.Yes Then
            sin_errores = True
        Else
            Exit Sub
        End If

    End Sub

    Private Sub verificarErrores()

        Me.sin_errores = True
        'Estilo de las celdas

        For Each row_1 As DataGridViewRow In dgv_movimiento_hora.Rows
            For Each cell As DataGridViewCell In row_1.Cells
                If CInt(row_1.Cells("id_cuerpoMovimientoHora").Value) = id_cuerpo_movimiento_hora Then
                    cell.Style.BackColor = Color.Green
                Else
                    cell.Style.BackColor = Color.White
                End If
            Next
        Next

        For Each row_1 As DataGridViewRow In dgv_movimiento_hora.Rows
            For Each row_2 As DataGridViewRow In dgv_movimiento_hora.Rows

                If row_1.Index < row_2.Index And CBool(row_1.Cells("no_trabajado").Value) = False And CBool(row_2.Cells("no_trabajado").Value) = False Then

                    If (CDate(row_2.Cells("salida").Value).Subtract(CDate(row_1.Cells("entrada").Value)).TotalSeconds >= 1 And CDate(row_1.Cells("salida").Value).Subtract(CDate(row_2.Cells("entrada").Value)).TotalSeconds >= 1) Then

                        If CBool(row_2.Cells("no_trabajado").Value) Then
                            'row_2.Cells("entrada").Value = row_1.Cells("salida").Value
                        Else
                            For Each cell As DataGridViewCell In row_1.Cells
                                If CInt(row_1.Cells("id_cuerpoMovimientoHora").Value) = id_cuerpo_movimiento_hora Then
                                    cell.Style.BackColor = Color.OrangeRed
                                Else
                                    cell.Style.BackColor = Color.Red
                                End If
                            Next
                            For Each cell As DataGridViewCell In row_2.Cells
                                If CInt(row_2.Cells("id_cuerpoMovimientoHora").Value) = id_cuerpo_movimiento_hora Then
                                    cell.Style.BackColor = Color.OrangeRed
                                Else
                                    cell.Style.BackColor = Color.Red
                                End If
                            Next
                        End If
                        Me.sin_errores = False

                    End If
                End If

                'Dim time_span As TimeSpan
                'If row_1.Index = row_2.Index - 1 Then
                '    time_span = CDate(row_2.Cells("entrada").Value).Subtract(CDate(row_1.Cells("salida").Value))
                '    If time_span.Duration.TotalMinutes > 1 Then
                '        If CBool(row_1.Cells("no_trabajado").Value) = True Then
                '            row_1.Cells("salida").Value = row_2.Cells("entrada").Value
                '        ElseIf CBool(row_2.Cells("no_trabajado").Value) = True Then
                '            row_2.Cells("entrada").Value = row_1.Cells("salida").Value
                '        End If
                '    End If
                'End If

            Next
        Next
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        clear()
    End Sub

    Private Sub clear()
        dtp_fecha.Enabled = True
        cmb_usuarios.Enabled = True
        btnAceptar.Enabled = False
        dgv_movimiento_hora.Rows.Clear()
        cmb_usuarios.SelectedValue = 0
        cmb_cliente.SelectedValue = 0
    End Sub

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

            Dim x As Integer = 0
            For Each dr As DataRow In odtAct.Rows
                x = x + 1

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


                'With oActividad_proyecto
                '    .Cargar()
                '    .Modificar(CInt(dr("id_actividad_proyecto").ToString))
                '    .orden = x
                '    .Guardar()
                'End With

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
            Next
            Return 0
        Else
            Return 0
        End If
    End Function

    Public Function FillChild(ByVal parent As TreeNode, ByVal id_subproyecto As String) As Integer

        'Los proyectos hijos del proyecto
        Dim odr As New stArbol
        Dim odtProy As New DataTable
        'odtProy = oProyecto.GetTree_2(CInt(IID))

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

        Dim x As Integer = 0

        If odtProy.Rows.Count > 0 Then

            For Each dr As DataRow In odtProy.Rows
                x = x + 1

                Dim child As New TreeNode()
                child.Text = dr("nombre").ToString().Trim()
                'Dim temp As String = dr("id_proyecto").ToString()

                odr.tipo = "s"
                odr.id_proyecto = CInt(dr("id_proyecto"))
                odr.id_subproyecto = CInt(dr("id_subproyecto"))
                odr.id_actividad = 0
                odr.id_actividad_proyecto = 0
                odr.id_cliente = 0
                odr.icono = 0

                child = parent.Nodes.Add(CStr(dr("id_subproyecto")), CStr(dr("nombre")), parent.ImageIndex)

                child.Tag = odr

                'agregado
                Dim odtAct As New DataTable
                'If Not cbx_factura.Checked Then
                '    odtAct = oActividad_proyecto.GetAllProyecto(CInt(IID))
                'End If


                'With oProyecto
                '    .Cargar()
                '    .Modificar(CInt(temp))
                '    .indice = x
                '    .Guardar()
                'End With

                If odtAct.Rows.Count > 0 Or odtProy.Rows.Count > 0 Then
                    Dim nodof As New TreeNode
                    nodof.Text = " "
                    child.Nodes.Add(nodof)
                End If
            Next
            Return 0
        Else
            Return 0
        End If
    End Function

    Private Sub buscarNodo(ByVal id_actividad_proyecto As Integer)
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

    Private Sub btnAgregar_Click_1(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Me.agregarLogueo()
    End Sub

    Private Sub btnQuitarLogueo_Click(sender As Object, e As EventArgs) Handles btnQuitarLogueo.Click
        Me.borrarLogueo()
    End Sub
End Class