Public Class frmLogin


    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Load_tree()
        Me.ControlPendiente()
        Me.gbProyecto.Visible = False
        Me.gbActividad.Visible = False

        oProyecto.Cargar()
    End Sub

    Sub ControlPendiente()
        Dim odt As New DataTable
        odt = oVoz.GetAllInicio_2(vgCodigoUsuario)

        Me.dgv1.DataSource = odt

        If odt.Rows.Count <= 0 Then
            Me.txtEstado.Text = "CONTROLES REALIZADOS"
            Me.txtEstado.BackColor = Color.YellowGreen
        Else
            Me.txtEstado.Text = "CONTROLES PENDIENTES"
            Me.txtEstado.BackColor = Color.Red

            '  Me.lblid_cuerpo_movimiento_voz.Text = CStr(odt.Rows(0).Item("id_cuerpo_movimiento_voz"))
            '   Me.txtPendiente.Text = CStr(oCuerpo_movimiento_voz.GetPath(CInt(Me.lblid_cuerpo_movimiento_voz.Text)).Rows(0).Item("Path_proyecto"))
        End If
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If Me.TreeView1.SelectedNode Is Nothing Then
            Exit Sub
        End If
        If Me.TreeView1.SelectedNode.SelectedImageIndex <> 3 Then
            MessageBox.Show("Debe seleccionar una actividad")
            Exit Sub
        End If

        If Me.lblid_actividad_proyecto.Text = "" Or Me.lblid_actividad_proyecto.Text = "0" Then
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

        If Me.lblid_cuerpo_movimiento_hora.Text = "0" Then
            With oCuerpo_movimiento_hora
                .Cargar()
                .Insertar()
                .entrada = dtHoraLogueo
                .salida = dtHoraLogueo
                .id_actividad_proyecto = CInt(Me.lblid_actividad_proyecto.Text)
                .id_movimiento_hora = vgCodigoMovimientoHora
                .Guardar()

                Me.lblid_cuerpo_movimiento_hora.Text = CStr(.id_cuerpo_movimiento_hora)
            End With
        Else
            If oCuerpo_movimiento_hora.salida = oCuerpo_movimiento_hora.entrada Then
                With oCuerpo_movimiento_hora
                    .Cargar()
                    .Modificar(CInt(Me.lblid_cuerpo_movimiento_hora.Text))
                    .salida = dtHoraLogueo
                    .Guardar()
                End With
                With oCuerpo_movimiento_hora
                    .Cargar()
                    .Insertar()
                    .entrada = dtHoraLogueo
                    .salida = dtHoraLogueo
                    .id_actividad_proyecto = CInt(Me.lblid_actividad_proyecto.Text)
                    .id_movimiento_hora = vgCodigoMovimientoHora
                    .Guardar()

                    Me.lblid_cuerpo_movimiento_hora.Text = CStr(.id_cuerpo_movimiento_hora)
                End With
            Else
                With oCuerpo_movimiento_hora
                    .Cargar()
                    .Insertar()
                    .entrada = dtHoraLogueo
                    .salida = dtHoraLogueo
                    .id_actividad_proyecto = CInt(Me.lblid_actividad_proyecto.Text)
                    .id_movimiento_hora = vgCodigoMovimientoHora
                    .Guardar()

                    Me.lblid_cuerpo_movimiento_hora.Text = CStr(.id_cuerpo_movimiento_hora)
                End With
            End If
        End If






        Dim frmTemp As New frmMain
        Me.AddOwnedForm(frmTemp)
        frmTemp.ShowDialog()

        Me.ControlPendiente()
        ''frmMain.Show()

        ''Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        If Me.lblid_cuerpo_movimiento_hora.Text = "0" Then
            Me.Close()
        End If

        With oCuerpo_movimiento_hora
            .Cargar()
            .Modificar(CInt(Me.lblid_cuerpo_movimiento_hora.Text))
            .salida = DateTime.Now
            .Guardar()
        End With

        Me.Close()
    End Sub


    Dim odtProyecto As New DataTable
    Dim odtActividad As New DataTable
    Dim odtActividad_proyecto As New DataTable

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        'If Me.TreeView1.SelectedNode.SelectedImageIndex = 0 Then

        'End If
        Try
            'If Me.TreeView1.SelectedNode.Level = 0 Then
            '    Me.lblid_proyecto.Text = Me.TreeView1.SelectedNode.Name
            '    Me.lblid_actividad.Text = CStr(0)
            '    odtProyecto = oProyecto.GetOne(CInt(Me.lblid_proyecto.Text))
            '    With odtProyecto.Rows(0)
            '        Me.txtnombre_proyecto.Text = CStr(.Item("nombre_proyecto"))
            '    End With
            'End If

            Select Case Me.TreeView1.SelectedNode.SelectedImageIndex
                Case -1

                    Me.lblid_proyecto.Text = Me.TreeView1.SelectedNode.Name
                    Me.lblid_actividad.Text = CStr(0)
                    odtProyecto = oProyecto.GetOne(CInt(Me.lblid_proyecto.Text))
                    With odtProyecto.Rows(0)
                        Me.txtnombre_proyecto.Text = CStr(.Item("nombre_proyecto"))
                    End With

                    Me.gbActividad.Enabled = True
                    Me.gbProyecto.Enabled = True

                    Me.lblVariableProyecto.Text = CStr(1)
                Case 3
                    Me.lblid_proyecto.Text = Me.TreeView1.SelectedNode.Parent.Name

                    'Dim tnTemp As New TreeNode
                    'tnTemp = Me.TreeView1.SelectedNode.Nodes(1).Name
                    Me.lblid_proyecto.Text = CStr(Me.TreeView1.SelectedNode.Tag)
                    odtProyecto = oProyecto.GetOne(CInt(Me.lblid_proyecto.Text))
                    With odtProyecto.Rows(0)
                        Me.txtnombre_proyecto.Text = CStr(.Item("nombre_proyecto"))
                    End With

                    Me.lblid_actividad.Text = Me.TreeView1.SelectedNode.Name
                    odtActividad = oActividad.GetOne(CInt(Me.lblid_actividad.Text))
                    With odtActividad.Rows(0)
                        Me.txtNombre_actividad.Text = CStr(.Item("nombre_Actividad"))
                    End With

                    odtActividad_proyecto = oActividad_proyecto.GetOne_3(CInt(Me.lblid_proyecto.Text), CInt(Me.lblid_actividad.Text))
                    With odtActividad_proyecto.Rows(0)
                        Me.lblid_actividad_proyecto.Text = CStr(.Item("id_actividad_proyecto"))
                    End With

                    Dim id_path As Integer = 0
                    Dim nom_path As String = ""
                    id_path = CInt(Me.lblid_proyecto.Text)

                    Dim odtProy As New DataTable
                    odtProy = oProyecto.GetTree_2(CInt(id_path))

                    Me.gbActividad.Enabled = True
                    Me.gbProyecto.Enabled = False

                    Me.lblVariableProyecto.Text = CStr(2)

            End Select

            Me.lblNodo.Text = CStr(Me.TreeView1.SelectedNode.Index)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub Load_tree()
        ' Dim PrSet As DataSet = PDataset("SELECT * FROM proyecto where id_proyecto_padre = 1 AND id_proyecto <> 1")

        Dim odt As New DataTable
        odt = oProyecto.GetTree

        TreeView1.Nodes.Clear()

        ' For Each dr As DataRow In PrSet.Tables(0).Rows
        For Each dr As DataRow In odt.Rows
            If DirectCast(dr("id_proyecto"), Integer) <> 0 Then
                Dim tnParent As New TreeNode()
                tnParent.Text = dr("nombre_proyecto").ToString()
                Dim value As String = dr("id_proyecto").ToString()
                tnParent.Name = value

                tnParent.Expand()

                TreeView1.Nodes.Add(tnParent)
                FillChild(tnParent, value)

            End If
        Next
        Me.TreeView1.CollapseAll()
    End Sub

    Public Function FillChild(ByVal parent As TreeNode, ByVal IID As String) As Integer
        'Dim ds As DataSet = PDataset("SELECT * FROM proyecto WHERE id_proyecto_padre = " & IID)

        Dim odtProy As New DataTable
        odtProy = oProyecto.GetTree_2(CInt(IID))

        ' If ds.Tables(0).Rows.Count > 0 Then
        If odtProy.Rows.Count > 0 Then
            ' For Each dr As DataRow In ds.Tables(0).Rows
            For Each dr As DataRow In odtProy.Rows

                Dim child As New TreeNode()
                child.Text = dr("nombre_proyecto").ToString().Trim()
                Dim temp As String = dr("id_proyecto").ToString()

                child.Collapse()

                ' parent.Nodes.Add(child)

                child = parent.Nodes.Add(CStr(dr("id_proyecto")), CStr(dr("nombre_proyecto")), 0)
                child.Tag = dr("id_proyecto")

                Me.FillChild_actividad(child, temp)

                ''Dim odt As New DataTable
                ''odt = oActividad_proyecto.GetAllProyecto(CInt(temp))
                '' ''odt = oActividad_proyecto.GetAllProyecto(CInt(IID))

                ''Dim contador As Integer = 1
                ''For Each row As DataRow In odt.Rows
                ''    Dim child_2 As New TreeNode()
                ''    child_2.Text = row("nombre_actividad").ToString().Trim()
                ''    Dim temp_2 As String = row("id_actividad").ToString()
                ''    child_2.Collapse()

                ''    child_2.Tag = dr("id_proyecto")
                ''    If contador = 1 Then
                ''        TreeView1.Nodes.Add(child_2)
                ''    End If

                ''    child_2 = parent.Nodes.Add(CStr(row("id_actividad")), CStr(row("nombre_actividad")), 1, 3)
                ''    'child_2.Tag = row("id_actividad")
                ''    child_2.Tag = dr("id_proyecto")
                ''    ''child_2.Tag = IID




                ''    '  parent.Nodes.Add(temp_2, child_2.Text, 1)
                ''    contador = contador + 1
                ''Next

                FillChild(child, temp)
            Next
            Return 0
        Else
            Return 0
        End If
    End Function

    Public Function FillChild_actividad(ByVal parent As TreeNode, ByVal IID As String) As Integer
        'Dim ds As DataSet = PDataset("SELECT * FROM proyecto WHERE id_proyecto_padre = " & IID)

        Dim odtAct As New DataTable
        odtAct = oActividad_proyecto.GetAllProyecto(CInt(IID))

        ' If ds.Tables(0).Rows.Count > 0 Then
        If odtAct.Rows.Count > 0 Then
            ' For Each dr As DataRow In ds.Tables(0).Rows
            For Each dr As DataRow In odtAct.Rows

                Dim child As New TreeNode()
                child.Text = dr("nombre_actividad").ToString().Trim()
                Dim temp As String = dr("id_actividad").ToString()
                child.Tag = IID

                child.Collapse()

                ' parent.Nodes.Add(child)

                child = parent.Nodes.Add(CStr(dr("id_actividad")), CStr(dr("nombre_actividad")), 1, 3)
                child.Tag = IID

                '  FillChild_actividad(child, temp)
            Next
            Return 0
        Else
            Return 0
        End If
    End Function




    Private Sub btnGuardarProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarProyecto.Click
        Select Case Me.lblBanderaProyecto.Text
            Case CStr(1)
                Dim idP As Integer = 0
                Dim srtPath As String = ""
                Dim odtP As New DataTable
                Dim odtP_2 As New DataTable

                odtP = oProyecto.GetOne(CInt(Me.lblid_proyecto.Text))
                idP = CInt(odtP.Rows(0).Item("id_proyecto_padre"))
                srtPath = CStr(odtP.Rows(0).Item("nombre_proyecto")) & "-" & Me.txtnombre_proyecto.Text

                While idP <> 1
                    odtP_2 = oProyecto.GetOne(idP)
                    idP = CInt(odtP_2.Rows(0).Item("id_proyecto_padre"))
                    srtPath = CStr(odtP_2.Rows(0).Item("nombre_proyecto")) & "-" & srtPath
                End While


                With oProyecto
                    .Cargar()
                    .Insertar()
                    .nombre_proyecto = Me.txtnombre_proyecto.Text
                    .path = srtPath
                    If Me.chkProyectoInicial.Checked = True Then
                        .id_proyecto_padre = 1
                        .id_proyect_manager = CInt(Me.lblid_proyect_manager.Text)
                        .id_controlador_1 = CInt(Me.lblid_controlador_1.Text)
                        .id_controlador_2 = CInt(Me.lblid_controlador_2.Text)
                    Else
                        .id_proyecto_padre = CInt(Me.lblid_proyecto.Text)
                    End If

                    .id_cliente = 1
                    .id_proyect_manager = CInt(odtP.Rows(0).Item("id_proyect_manager"))
                    .id_estado = 1
                    .id_controlador_1 = CInt(odtP.Rows(0).Item("id_controlador_1"))
                    .id_controlador_2 = CInt(odtP.Rows(0).Item("id_controlador_2"))
                    .total_hora = CDec(Me.txttotal_hora.Text)
                    .Guardar()
                End With

            Case CStr(2)

                Dim idP As Integer = 0
                Dim srtPath As String = ""
                Dim odtP As New DataTable
                Dim odtP_2 As New DataTable

                odtP = oProyecto.GetOne(CInt(Me.lblid_proyecto.Text))
                idP = CInt(odtP.Rows(0).Item("id_proyecto_padre"))
                srtPath = CStr(odtP.Rows(0).Item("nombre_proyecto"))

                While idP <> 1
                    odtP_2 = oProyecto.GetOne(idP)
                    idP = CInt(odtP_2.Rows(0).Item("id_proyecto_padre"))
                    srtPath = CStr(odtP_2.Rows(0).Item("nombre_proyecto")) & "-" & srtPath
                End While

                With oProyecto
                    .Cargar()
                    .Modificar(CInt(Me.lblid_proyecto.Text))
                    .nombre_proyecto = Me.txtnombre_proyecto.Text
                    .path = srtPath
                    .id_proyect_manager = CInt(odtP.Rows(0).Item("id_proyect_manager"))
                    .id_controlador_1 = CInt(odtP.Rows(0).Item("id_controlador_1"))
                    .id_controlador_2 = CInt(odtP.Rows(0).Item("id_controlador_2"))
                    .total_hora = CDec(Me.txttotal_hora.Text)
                    .Guardar()
                End With
        End Select

        Me.Load_tree()
    End Sub

    Sub LimpiarControlesProyecto()
        ' Me.txtdescripcion.Text = ""
        Me.txtnombre_proyecto.Text = ""
        ' Me.lblid_cliente.Text = "0"
        '  Me.cmbCliente.Text = ""
        ' Me.lblid_proyecto_padre.Text = "0"
        ' Me.cmbProyecto_padre.Text = ""
        Me.lblid_proyect_manager.Text = "0"
        Me.cmbproyect_manager.Text = ""
        ' Me.dtpfecha_inicio.Value = DateTime.Now
        ' Me.dtpfecha_fin_prevista.Value = DateTime.Now
        ' Me.dtpfecha_fin_real.Value = DateTime.Now
        Me.txtOrden.Text = ""
        ' Me.lblid_estado.Text = "0"
        ' Me.cmbEstado.Text = ""
        Me.txttotal_hora.Text = ""
        '  Me.txtprioridad.Text = ""
        '  Me.txtobservacion.Text = ""
        Me.lblid_controlador_1.Text = "0"
        Me.cmbcontrolador_1.Text = ""
        Me.lblid_controlador_2.Text = "0"
        Me.cmbcontrolador_2.Text = ""
        ' Me.txtpath.Text = ""
    End Sub

    Private Sub btnNuevoProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoProyecto.Click
        Me.LimpiarControlesProyecto()
        Me.lblBanderaProyecto.Text = CStr(1)
    End Sub

    Private Sub btnModificarProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarProyecto.Click
        Me.lblBanderaProyecto.Text = CStr(2)
    End Sub

    Private Sub btnBorrarProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarProyecto.Click
        If MessageBox.Show("Desea Realmente Eliminar el Registro ", "BORRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        With oProyecto
            .Cargar()
            .Borrar(CInt(Me.lblid_proyecto.Text))
            .Guardar()
        End With

        Me.Load_tree()
    End Sub


    Sub LimpiarControlesActividad()
        Me.txtNombre_actividad.Text = ""
        'Me.txttiempo_standart.Text = ""
        ' Me.txtcosto_standart.Text = ""
        '  Me.lblid_tipo_actividad.Text = "0"
        '  Me.cmbTipo_actividad.Text = ""
        Me.txtOrden.Text = ""
    End Sub

    Sub LimpiarControlesActividad_proyecto()
        ' Me.lblid_proyecto.Text = "0"
        '  Me.cmbProyecto.Text = ""
        Me.lblid_actividad.Text = "0"
        '   Me.cmbActividad.Text = ""
        '   Me.dtpfecha_inicio.Value = DateTime.Now
        '   Me.dtpfecha_fin_previsto.Value = DateTime.Now
        '   Me.dtpfecha_fin_real.Value = DateTime.Now
        Me.txtcantidad_hora.Text = ""
        '  Me.txtobjetivo.Text = ""
        '  Me.txtprioridad.Text = ""
        '  Me.txtcomplejidad.Text = ""
        '  Me.txtavance.Text = ""
        '  Me.txtobservacion.Text = ""
    End Sub

    Private Sub btnNuevoActividad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoActividad.Click
        Me.LimpiarControlesActividad()
        Me.LimpiarControlesActividad_proyecto()
        Me.lblBanderaActividad.Text = CStr(1)

        Dim odtAP As New DataTable
        odtAP = oActividad_proyecto.GetMaxOrden(CInt(Me.lblid_proyecto.Text))

        Me.txtOrden.Text = CStr(CDec(odtAP.Rows(0).Item("orden")) + 1)
        Me.btnGuardarActividad.Enabled = True
    End Sub

    Private Sub btnModificarActividad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarActividad.Click
        Me.lblBanderaActividad.Text = CStr(2)
        Me.btnGuardarActividad.Enabled = True
    End Sub

    Private Sub btnBorrarActividad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarActividad.Click
        If MessageBox.Show("Desea Realmente Eliminar el Registro ", "BORRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        With oActividad
            .Cargar()
            .Borrar(CInt(Me.lblid_actividad.Text))
            .Guardar()
        End With

        With oActividad_proyecto
            .Cargar()
            .Borrar(CInt(Me.lblid_actividad_proyecto.Text))
            .Guardar()
        End With

        Me.Load_tree()
    End Sub

    Private Sub btnGuardarActividad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarActividad.Click
        Select Case Me.lblBanderaActividad.Text
            Case CStr(1)
                With oActividad
                    .Cargar()
                    .Insertar()
                    .nombre_actividad = Me.txtNombre_actividad.Text
                    .Guardar()
                    Me.lblid_actividad.Text = CStr(.id_actividad)
                End With

                With oActividad_proyecto
                    .Cargar()
                    .Insertar()
                    .id_actividad = CInt(Me.lblid_actividad.Text)
                    .id_proyecto = CInt(Me.lblid_proyecto.Text)
                    .orden = CDec(Me.txtOrden.Text)
                    .Guardar()
                End With

            Case CStr(2)
                With oActividad
                    .Cargar()
                    .Modificar(CInt(Me.lblid_actividad.Text))
                    .nombre_actividad = Me.txtNombre_actividad.Text
                    .Guardar()
                End With

                With oActividad_proyecto
                    .Cargar()
                    .Modificar(CInt(Me.lblid_actividad_proyecto.Text))
                    .orden = CDec(Me.txtOrden.Text)
                    .Guardar()
                End With
        End Select

        Me.Load_tree()
        Me.btnGuardarActividad.Enabled = False
    End Sub

    Sub CargarProyect_manager()
        Dim odt As New DataTable

        odt = oUsuario.GetCmb
        With Me.cmbProyect_manager
            .DataSource = odt
            .DisplayMember = "nombre_usuario"
            .ValueMember = "id_usuario"
        End With
        If Me.cmbProyect_manager.SelectedIndex >= 0 Then
            cmbProyect_manager.SelectedIndex = 0
            Me.lblid_Proyect_manager.Text = cmbProyect_manager.SelectedValue.ToString
        End If
    End Sub

    Sub CargarControlador_1()
        Dim odt As New DataTable

        odt = oUsuario.GetCmb
        With Me.cmbControlador_1
            .DataSource = odt
            .DisplayMember = "nombre_usuario"
            .ValueMember = "id_usuario"
        End With
        If Me.cmbControlador_1.SelectedIndex >= 0 Then
            cmbControlador_1.SelectedIndex = 0
            Me.lblid_Controlador_1.Text = cmbControlador_1.SelectedValue.ToString
        End If
    End Sub

    Sub CargarControlador_2()
        Dim odt As New DataTable

        odt = oUsuario.GetCmb
        With Me.cmbControlador_2
            .DataSource = odt
            .DisplayMember = "nombre_usuario"
            .ValueMember = "id_usuario"
        End With
        If Me.cmbControlador_2.SelectedIndex >= 0 Then
            cmbControlador_2.SelectedIndex = 0
            Me.lblid_Controlador_2.Text = cmbControlador_2.SelectedValue.ToString
        End If
    End Sub

    Private Sub cmbProyect_manager_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbproyect_manager.SelectedIndexChanged
        If Me.cmbProyect_manager.SelectedIndex >= 0 Then
            Me.lblid_proyect_manager.Text = cmbProyect_manager.SelectedValue.ToString
        End If
    End Sub

    Private Sub cmbControlador_1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcontrolador_1.SelectedIndexChanged
        If Me.cmbcontrolador_1.SelectedIndex >= 0 Then
            Me.lblid_controlador_1.Text = cmbcontrolador_1.SelectedValue.ToString
        End If
    End Sub

    Private Sub cmbControlador_2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcontrolador_2.SelectedIndexChanged
        If Me.cmbControlador_2.SelectedIndex >= 0 Then
            Me.lblid_controlador_2.Text = cmbControlador_2.SelectedValue.ToString
        End If
    End Sub


    Private Sub AdministrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdministrarToolStripMenuItem.Click
        Me.gbProyecto.Visible = True
        Me.gbActividad.Visible = True
    End Sub

    Private Sub AgregarProyectoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarProyectoToolStripMenuItem.Click
        Dim frmDetalle As New frmDetalleProyecto

        BanderaProyecto = 1
        Me.AddOwnedForm(frmDetalle)
        oProyecto.Insertar()
        frmDetalle.CargarCombos()
        frmDetalle.ShowDialog()
    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If Me.lblVariableProyecto.Text = "1" Then
            AgregarActividadToolStripMenuItem.Visible = True
            AgregarProyectoToolStripMenuItem.Visible = True
            ModificarActividadToolStripMenuItem.Visible = True
            ModificarProyectoToolStripMenuItem.Visible = True
            BorrarActividadToolStripMenuItem.Visible = True
            BorrarProyectoToolStripMenuItem.Visible = True
        Else
            AgregarActividadToolStripMenuItem.Visible = True
            AgregarProyectoToolStripMenuItem.Visible = False
            ModificarActividadToolStripMenuItem.Visible = True
            ModificarProyectoToolStripMenuItem.Visible = False
            BorrarActividadToolStripMenuItem.Visible = True
            BorrarProyectoToolStripMenuItem.Visible = False
        End If
    End Sub
End Class
