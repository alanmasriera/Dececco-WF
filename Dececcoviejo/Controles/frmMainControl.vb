Public Class frmMainControl
    'variable para saber que posicion del arbol esta
    Dim seleccionado As Integer
    Dim banderaclick As Integer = 0


    Private Sub frmMainControl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.RefrescarTree()
        Me.Load_tree()
    End Sub



    Dim odtVoz As New DataTable
    Dim odtTipoVoz As New DataTable
    Dim odtControl As New DataTable


    Private Sub btnAbrir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbrir.Click
        Try
            With OpenFileDialog1
                ' Vea btnRetriveFileNames_Click para obtener una explicación de los valores predeterminados
                ' de las propiedades.

                ' Comprobar que el archivo seleccionado existe. El cuadro de diálogo muestra
                ' una advertencia en caso contrario.
                .CheckFileExists = True

                ' Comprobar que la ruta de acceso seleccionada existe. El cuadro de diálogo muestra 
                ' una advertencia en caso contrario.
                .CheckPathExists = True

                ' Obtener o establecer una extensión predeterminada. No incluye el "." inicial.
                .DefaultExt = "png"

                ' ¿Devolver el archivo al que hace referencia un vínculo? Si False, devuelve el archivo de vínculo
                ' seleccionado. Si True, devuelve el archivo vinculado al archivo LNK.
                ' '.DereferenceLinks = True

                ' Al igual que en VB6, utilice un conjunto de pares de filtros, separados por "|". Cada
                ' par consta de una especificación descripción|archivo. Utilice "|" entre los pares. No es necesario
                ' poner "|" al final. Puede establecer la propiedad FilterIndex también, para seleccionar el
                ' filtro predeterminado. El primer filtro tiene el número 1 (no 0). El valor predeterminado es 1. 
                .Filter = _
                "Archivos PNG (*.png)|*.png|All files|*.*"

                .Multiselect = False

                ' ¿Restaurar el directorio original después de seleccionar
                ' un archivo? Si False, el directorio actual cambia
                ' al directorio en el que seleccionó el archivo.
                ' Establézcalo como True para poner la carpeta actual de nuevo
                ' donde estaba cuando comenzó.
                ' El valor predeterminado es False.
                .RestoreDirectory = True

                ' ¿Mostrar el botón Ayuda y la casilla de verificación Sólo lectura?
                .ShowHelp = True
                .ShowReadOnly = False

                ' ¿Comenzar con la casilla de verificación Sólo lectura activada?
                ' Esto sólo tiene sentido si ShowReadOnly es True.
                .ReadOnlyChecked = False

                .Title = "Seleccione un icono"

                ' ¿Aceptar sólo nombres de archivo Win32 válidos?
                .ValidateNames = True

                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Try
                        txticono.Text = .FileName
                        '  txtFileContents.Text = My.Computer.FileSystem.ReadAllText(.FileName)
                    Catch fileException As Exception
                        Throw fileException
                    End Try
                End If

            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

  
    'agregado para cargar el arbol
    Structure stArbol
        Dim tipo As String
        Dim id_control As Integer
        Dim id_tipo_voz As Integer
        Dim id_voz As Integer
        Dim icono As Integer
        Dim icono_seleccionado As Integer
    End Structure

    Public Sub Load_tree()
        ' Dim PrSet As DataSet = PDataset("SELECT * FROM proyecto where id_proyecto_padre = 1 AND id_proyecto <> 1")
        Dim odr As New stArbol

        Dim odt As New DataTable

        odt = oControl.ConsultarTodo

        Dim i As Integer = 0
        For Each row As DataRow In odt.Rows
            i = i + 1
            With oControl
                .Cargar()
                .Modificar(CInt(row.Item("id control").ToString))
                .indice = i
                .Guardar()
            End With
        Next

        TreeView1.Nodes.Clear()

        For Each dr As DataRow In odt.Rows
            If DirectCast(dr("id control"), Integer) <> 0 Then
                Dim tnParent As New TreeNode()
                tnParent.Text = dr("nombre control").ToString()
                Dim value As String = dr("id control").ToString()
                tnParent.Name = value
                'agregado para cuando selecciona abrir proyecto
                odr.tipo = "c"
                odr.id_control = CInt(dr("id control"))
                odr.id_tipo_voz = 0
                odr.id_voz = 0
                odr.icono = 0
                odr.icono_seleccionado = 2
                tnParent.Tag = odr

                tnParent.Expand()

                TreeView1.Nodes.Add(tnParent)

                FillChild(tnParent, value)
                'Me.FillChild_actividad(tnParent, value)

            End If
        Next
        'agregado para expandir el nodo
        Try

            Me.TreeView1.SelectedNode = Me.GetNodeKeyProyecto(CInt(lblid_control.Text), Me.TreeView1.Nodes)
            Me.TreeView1.SelectedNode.Expand() '.ExpandAll()
        Catch ex As Exception
        End Try

        'agregado para limpiar controles
        limpiar()
    End Sub

    Public Function FillChild(ByVal parent As TreeNode, ByVal IID As String) As Integer
        'Dim ds As DataSet = PDataset("SELECT * FROM proyecto WHERE id_proyecto_padre = " & IID)
        Dim odr As New stArbol
        Dim odtTipo_voz As New DataTable
        Dim x As Integer = 0
        odtTipo_voz = oTipo_voz.GetAllArbol_2(CInt(IID))

        ' If ds.Tables(0).Rows.Count > 0 Then
        If odtTipo_voz.Rows.Count > 0 Then
            ' For Each dr As DataRow In ds.Tables(0).Rows
            For Each dr As DataRow In odtTipo_voz.Rows
                x = x + 1
                Dim child As New TreeNode()
                child.Text = dr("Nombre_tipo_voz").ToString().Trim()
                Dim temp As String = dr("Id_tipo_voz").ToString()

                odr.tipo = "tv"
                odr.id_tipo_voz = CInt(dr("Id_tipo_voz"))
                odr.id_control = CInt(IID)
                odr.id_voz = 0
                odr.icono = 1
                odr.icono_seleccionado = 2

                child.Collapse()

                ' parent.Nodes.Add(child)

                child = parent.Nodes.Add(CStr(dr("Id_tipo_voz")), CStr(dr("Nombre_tipo_voz")), 1, 2)
                child.Tag = odr
                Me.fillChild_voz(child, CInt(IID), CInt(dr("id_tipo_voz"))) 'agregado

                With oTipo_voz
                    .Cargar()
                    .Modificar(CInt(temp))
                    .indice = x
                    .Guardar()
                End With
                'FillChild(child, temp)
            Next
            Return 0
        Else
            Return 0
        End If
    End Function

    Public Sub fillChild_voz(ByVal parent As TreeNode, ByVal id_c As Integer, ByRef id_tv As Integer) 'agregado
        Dim odr As New stArbol

        Dim odtVoz As New DataTable
        odtVoz = oVoz_tipo_voz.GetAll_4(CInt(id_tv))
        Dim x As Integer = 0
        ' If ds.Tables(0).Rows.Count > 0 Then
        If odtVoz.Rows.Count > 0 Then
            ' For Each dr As DataRow In ds.Tables(0).Rows
            For Each dr As DataRow In odtVoz.Rows
                x = x + 1
                Dim child As New TreeNode()
                child.Text = dr("Nombre_voz").ToString().Trim() 'modificado nombre_proyecto
                Dim temp As String = dr("id_voz_tipo_voz").ToString() ' modificado id_proyecto

                odr.tipo = "v"
                odr.id_voz = CInt(dr("id_voz"))
                odr.id_tipo_voz = CInt(id_tv)
                odr.id_control = CInt(id_c)

                odr.icono = 3
                odr.icono_seleccionado = 2
                child.Collapse()

                ' parent.Nodes.Add(child)

                'child = parent.Nodes.Add(CStr(dr("id_voz_tipo_voz")), CStr(dr("Nombre_voz")), 3, 2)
                child.Tag = odr
                child.ImageIndex = 3
                child.SelectedImageIndex = 2
                parent.Nodes.Add(child)
                'FillChild(child, temp)
                With oVoz_tipo_voz
                    .Cargar()
                    .Modificar(CInt(temp))
                    .indice = x
                    .Guardar()
                End With
            Next
            '    Return 0
            'Else
            '    Return 0
        End If
    End Sub


    ' ''''''
    ' ''''''
    ' funcionalidad del los menus

    Private Sub AgregarControlToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Dim frmPrincipal As New frmAbmControl
        BanderaControl = 1
        frmPrincipal.ShowDialog()
    End Sub

    Private Sub ModificarControlToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Dim frmDetalle As New frmDetalleControl
        BanderaControl = 2
        frmDetalle.ShowDialog()
    End Sub

    Private Sub TreeView1_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        Dim odr As New stArbol

        odr = CType(Me.TreeView1.SelectedNode.Tag, stArbol)

        If odr.tipo = "c" Then
            Me.lblid_control.Text = CStr(odr.id_control)
            odtControl = oControl.GetOne(CInt(Me.lblid_control.Text))
            With odtControl.Rows(0)
                Me.txtnombre_control.Text = CStr(.Item("nombre control"))
            End With
            seleccionado = 0
         
        ElseIf odr.tipo = "tv" Then
            Me.lblid_control.Text = CStr(odr.id_control)
            Me.lblid_tipo_voz.Text = CStr(odr.id_tipo_voz)
            odtTipoVoz = oTipo_voz.GetOne(CInt(Me.lblid_tipo_voz.Text))
            With odtTipoVoz.Rows(0)
                Me.txtnombre_tipo_voz.Text = CStr(.Item("Nombre tipo voz"))
                Me.txtCodigoTipo.Text = CStr(.Item("Codigo"))
            End With
            seleccionado = 1
       
        ElseIf odr.tipo = "v" Then
            Me.lblid_control.Text = CStr(odr.id_control)
            Me.lblid_tipo_voz.Text = CStr(odr.id_tipo_voz)
            Me.lblid_voz.Text = CStr(odr.id_voz)

            odtTipoVoz = oTipo_voz.GetOne(CInt(Me.lblid_tipo_voz.Text))
            With odtTipoVoz.Rows(0)
                Me.txtnombre_tipo_voz.Text = CStr(.Item("Nombre tipo voz"))
                Me.txtCodigoTipo.Text = CStr(.Item("codigo"))
            End With

            odtVoz = oVoz.GetOne(CInt(Me.lblid_voz.Text))
            With odtVoz.Rows(0)
                Me.txtnombre_voz.Text = CStr(.Item("nombre voz"))
                Me.txtcodigo.Text = CStr(.Item("codigo"))
                'modificado
                Me.txtCodigo_2.Text = CStr(.Item("codigo 2"))
                'Me.txtCodigo_2.Text = lblid_voz.Text

                Me.txticono.Text = CStr(.Item("icono"))
            End With
            seleccionado = 3
          
        End If

    End Sub

    Private Sub TreeView1_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles TreeView1.MouseDown
        Me.lblX.Text = CStr(e.X)
        Me.lblY.Text = CStr(e.Y)
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.banderaclick = 0
            Me.TreeView1.SelectedNode = Me.TreeView1.GetNodeAt(e.X, e.Y)
            ''nodo que será arrastrado
            'NodoOrigen = CType(Me.TreeView1.GetNodeAt(e.X, e.Y), TreeNode)
        Else
            banderaclick = 1
            'NodoOrigen = CType(Me.TreeView1.GetNodeAt(e.X, e.Y), TreeNode)
        End If
    End Sub

    Private Sub ts_agregar_control_Click(sender As System.Object, e As System.EventArgs) Handles ts_agregar_control.Click

        Dim blExiste As Boolean = True
        Dim odt As New DataTable
        Dim strNombre As String = "CONTROL_NUEVO"
        Dim contador As Integer = 1
        odt = oControl.GetAllExiste(strNombre)

        While blExiste = True
            If odt.Rows.Count <= 0 Then
                blExiste = False
            Else
                strNombre = "CONTROL_NUEVO_" & CStr(contador)
                contador = contador + 1
                odt = oControl.GetAllExiste(strNombre)
            End If
        End While

        With oControl
            .Cargar()
            .Insertar()
            .nombre_control = strNombre
            .Guardar()
        End With

        Me.lblid_control.Text = CStr(oControl.id_control)


        Try
            Dim odr As New stArbol
            Dim tnParent As New TreeNode()
            tnParent.Text = strNombre
            Dim value As String = Me.lblid_control.Text

            tnParent.Name = value
            tnParent.ImageIndex = 0


            odr.tipo = "c"
            odr.id_control = CInt(Me.lblid_control.Text)
            odr.id_tipo_voz = 0
            odr.id_voz = 0
            odr.icono = 0
            odr.icono_seleccionado = 2

            tnParent.Tag = odr
            TreeView1.Nodes.Add(tnParent)
            TreeView1.SelectedNode = tnParent
        Catch ex As Exception

        End Try

        'Me.Load_tree()
    End Sub

    Private Sub ts_modificar_control_Click(sender As System.Object, e As System.EventArgs) Handles ts_modificar_control.Click
        Dim frmControl As New frmDetalleControl
        If Not IsNumeric(Me.lblid_control.Text) Then
            Exit Sub
        End If
        BanderaControl = 2
        Me.AddOwnedForm(frmControl)
        oControl.Modificar(CInt(Me.lblid_control.Text))
        frmControl.CargarCombos()
        frmControl.ShowDialog()
        If BanderaControl <> 0 Then
            BanderaControl = 0
            Try
                Dim str As String = oControl.GetOne(CInt(Me.lblid_control.Text)).Rows(0).Item("nombre control").ToString
                Me.TreeView1.SelectedNode.Text = str
                Me.refrescarProyecto()
            Catch ex As Exception
                'Load_tree()
            End Try


        End If

    End Sub

    Private Sub ts_agregar_tv_Click(sender As System.Object, e As System.EventArgs) Handles ts_agregar_tv.Click
        Dim blExiste As Boolean = True
        Dim odt As New DataTable
        Dim strNombre As String = "TIPO_DE_VOZ_NUEVO"
        Dim contador As Integer = 1
        odt = oTipo_voz.GetAllExiste(strNombre)

        'variable ultimoCodigo agregada para guardar el ultimo tipo de codigo agregado
        'se llama al SP cop_Tipo_voz_GetUltimoCodigo para obtener el ultimo codigo y luego aumentarlo en uno

        Dim ultimoCodigo As String = ""
        Dim odt1 As New DataTable
        odt1 = oTipo_voz.GetUltimoCodigo(CInt(lblid_control.Text))

        If odt1.Rows.Count = 0 Then
            ultimoCodigo = "A"
        Else
            ultimoCodigo = Chr(Asc(CStr(odt1.Rows(0)("codigo"))) + 1)
        End If

        While blExiste = True
            If odt.Rows.Count <= 0 Then
                blExiste = False
            Else
                strNombre = "TIPO_DE_VOZ_NUEVO_" & CStr(contador)
                contador = contador + 1
                odt = oTipo_voz.GetAllExiste(strNombre)
            End If
        End While

        Dim tabla As New DataTable
        tabla = oTipo_voz.GetAllArbol_4(CInt(Me.lblid_control.Text))

        With oTipo_voz
            .Cargar()
            .Insertar()
            .id_control = CInt(Me.lblid_control.Text)
            .nombre_tipo_voz = strNombre
            .codigo = ultimoCodigo 'modificado
            .indice = tabla.Rows.Count + 1 'va a ser el ultimo 
            .Guardar()
            'agregado
            .UpdatePorcentaje_tipo_2(CInt(Me.lblid_control.Text))
        End With

        Me.lblid_tipo_voz.Text = CStr(oTipo_voz.id_tipo_voz)

        'Me.Load_tree()
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

        TreeView1.SelectedNode = tnParent
        TreeView1.SelectedNode.Expand()
    End Sub

    Private Sub cargarProyecto(ByVal tnParent As TreeNode)

        Me.TreeView1.SelectedNode = tnParent

        Dim odt As stArbol
        odt = CType(Me.TreeView1.SelectedNode.Tag, stArbol)

        Me.FillChild(tnParent, tnParent.Name)
        Me.fillChild_voz(tnParent, odt.id_control, odt.id_tipo_voz)

    End Sub

    Private Sub ts_modificar_tv_Click(sender As System.Object, e As System.EventArgs) Handles ts_modificar_tv.Click
        Dim frmTipo As New frmDetalleTipo_voz_3
        If Not IsNumeric(Me.lblid_tipo_voz.Text) Then
            Exit Sub
        End If
        BanderaTipo_voz = 1
        Me.AddOwnedForm(frmTipo)
        frmTipo.ShowDialog()
        'oTipo_voz.UpdatePorcentaje_tipo_2(CInt(lblid_control.Text), CInt(lblid_tipo_voz.Text))
        If BanderaTipo_voz = 1 Then
            'Load_tree()
            Me.refrescarProyecto()
            BanderaTipo_voz = 0
        End If

    End Sub

    Private Sub ts_agregar_v_Click(sender As System.Object, e As System.EventArgs) Handles ts_agregar_voz.Click
        'AGREGAR
        Dim blExiste As Boolean = True
        Dim odt As New DataTable
        Dim strNombre As String = "VOZ_NUEVO"
        Dim contador As Integer = 1
        Dim i As Integer

        odt = oVoz.GetAllExiste(strNombre)

        Dim odtTipo As New DataTable
        odtTipo = oTipo_voz.GetOne(CInt(Me.lblid_tipo_voz.Text))

            'para la voz
            Dim odt_2 As New DataTable
        odt_2 = oVoz.GetNextCode(Me.txtCodigoTipo.Text, CInt(Me.lblid_tipo_voz.Text))


        While blExiste = True
            If odt.Rows.Count <= 0 Then
                blExiste = False
            Else
                strNombre = "VOZ_NUEVO_" & CStr(contador)
                contador = contador + 1
                odt = oVoz.GetAllExiste(strNombre)
            End If
        End While

        With oVoz
            .Cargar()
            .Insertar()
            .nombre_voz = "Nueva Voz"
            .icono = ""

            Try
                .codigo = CStr(odt_2.Rows(0).Item("codigo"))
                .codigo_2 = CStr(odt_2.Rows(0).Item("codigo_2"))
            Catch ex As Exception
                .codigo = "A"
                .codigo_2 = CStr(1)
            End Try

            .pond_manual = False
            .rango = 0
            .Guardar()
            Me.lblid_voz.Text = CStr(.id_voz)
        End With

        Dim odt2 As New DataTable
        odt2 = oVoz_tipo_voz.GetAll_4(CInt(Me.lblid_tipo_voz.Text))

        With oVoz_tipo_voz
            .Cargar()
            .Insertar()
            .id_tipo_voz = CInt(Me.lblid_tipo_voz.Text)
            .id_voz = CInt(Me.lblid_voz.Text)
            .indice = odt2.Rows.Count + 1
            .Guardar()
            .UpdatePorcentaje(CInt(Me.lblid_tipo_voz.Text))
        End With
        Me.lblid_voz.Text = CStr(oVoz_tipo_voz.id_voz)
        'me actualiza el random de todas las voces creadas
        oVoz.UpdateRandom()
        ' Me.Load_tree()

        'agregar al arbol
        Dim node As New TreeNode
        Dim odr As New stArbol
        odr = CType(Me.TreeView1.SelectedNode.Tag, stArbol)

        'odr.tipo = "v"
        'odr.id_voz = CInt(Me.lblid_voz.Text)
        'odr.id_tipo_voz = CInt(Me.lblid_tipo_voz.Text)
        'odr.id_control = CInt(Me.lblid_control.Text)
        'odr.icono = 3
        'odr.icono_seleccionado = 2

        'cambiar ponderaciones a voces
        Dim padre As TreeNode = Me.TreeView1.SelectedNode
        'Dim str1, str2, str3 As String
        'str2 = oVoz.GetOne(oVoz_tipo_voz.id_voz_tipo_voz).Rows(0).Item("ponderacion").ToString
        'For Each nodo As TreeNode In padre.Nodes
        '    If nodo IsNot Nothing Then
        '        i = nodo.Text.IndexOf("%")
        '        If i = -1 Then
        '            i = 4
        '        End If
        '        str1 = nodo.Text.Substring(0, i + 2)
        '        i = nodo.Text.LastIndexOf("N")
        '        If i = -1 Then
        '            i = 12
        '        End If
        '        str3 = nodo.Text.Substring(i, nodo.Text.Length - i)
        '        nodo.Text = str1 & str2 & " " & str3
        '        '    nodo.Remove()
        '        'Else
        '        '    Exit For
        '    End If
        'Next
        'fillChild_voz(padre, CInt(Me.lblid_control.Text), CInt(Me.lblid_tipo_voz.Text))
        'Dim name As String = CStr(oVoz_tipo_voz.id_voz_tipo_voz)
        'Dim x As String = oVoz.codigo & "-" & oVoz.codigo_2 & " % " & str2 & " " & oVoz.nombre_voz
        'node.Tag = odr
        'node.ImageIndex = 3
        'node.SelectedImageIndex = 2
        'node.Text = x
        'node.Name = name
        'TreeView1.SelectedNode.Nodes.Add(node)  '(name, x, 3, 2)
        'Load_tree()
        If odr.id_voz <> 0 Then
            Me.TreeView1.SelectedNode = Me.TreeView1.SelectedNode.Parent
        End If

        Me.refrescarProyecto()

    End Sub

    Private Sub ts_modificar_voz_Click(sender As System.Object, e As System.EventArgs) Handles ts_modificar_voz.Click
        'Dim frmVoz As New frmDetalleVoz
        Dim frmVoz As New frmDetalleVoz_2
        If Not IsNumeric(Me.lblid_voz.Text) Then
            Exit Sub
        End If
        BanderaVoz = 2
        Me.AddOwnedForm(frmVoz)
        oVoz.Modificar(CInt(Me.lblid_voz.Text))

        frmVoz.activar(False, True)
        frmVoz.ShowDialog()

        If BanderaVoz = 2 Then
            'Load_tree()
            Me.TreeView1.SelectedNode = Me.TreeView1.SelectedNode.Parent
            Me.refrescarProyecto()
            BanderaVoz = 0
        End If
    End Sub

    Private Sub ts_borrar_control_Click(sender As System.Object, e As System.EventArgs) Handles ts_borrar_control.Click
        If MessageBox.Show("Desea Realmente Eliminar el Registro ", "BORRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Dim odt1 As New DataTable

        odt1 = oControl.ExisTipoVoz(CInt(Me.lblid_control.Text)) ' pregunto si el control tiene tipo asociados
        For Each row1 As DataRow In odt1.Rows 'si tiene voces asociadas borro
            Dim odt2 As New DataTable
            odt2 = oVoz_tipo_voz.ExisVoz(CInt(row1("id_tipo_voz")))
            For Each row3 As DataRow In odt2.Rows
                With oVoz
                    .Cargar()
                    .Borrar(CInt(row3("id_voz_tipo_voz")))
                    .Guardar()
                End With

                With oVoz_tipo_voz
                    .Cargar()
                    .BorrarTipoVoz(CInt(row1("id_tipo_voz"))) 'modificado estaba el id_voz_tipo_voz
                    .Guardar()
                End With
            Next
            With oTipo_voz
                .Cargar()
                .Borrar(CInt(row1("id_tipo_voz")))
                .Guardar()
            End With
        Next

        With oControl
            .Cargar()
            .Borrar(CInt(Me.lblid_control.Text))
            .Guardar()
        End With

        Me.TreeView1.SelectedNode.Remove()
    End Sub

    Private Sub ts_borrar_tv_Click(sender As System.Object, e As System.EventArgs) Handles ts_borrar_tv.Click

        If oTipo_voz.verificarIntegridadPorcentaje(CInt(Me.lblid_control.Text), CInt(Me.lblid_tipo_voz.Text)) = False Then
            MessageBox.Show("Todas las voces del control seleccionado tienen ponderaciones manuales, al menos una debe ser automática.", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If MessageBox.Show("Desea Realmente Eliminar el Registro ", "BORRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Dim odt2 As New DataTable
        odt2 = oVoz_tipo_voz.ExisVoz(CInt(Me.lblid_tipo_voz.Text))
        For Each row3 As DataRow In odt2.Rows
            With oVoz
                .Cargar()
                .Borrar(CInt(row3("id_voz_tipo_voz")))
                .Guardar()
            End With

            With oVoz_tipo_voz
                .Cargar()
                .BorrarTipoVoz(CInt(Me.lblid_tipo_voz.Text)) 'modificado antes esta el id_voz_tipo_voz
                .Guardar()
            End With
        Next
        With oTipo_voz
            .Cargar()
            .Borrar(CInt(Me.lblid_tipo_voz.Text))
            .Guardar()
            .UpdatePorcentaje_tipo_2(CInt(Me.lblid_control.Text))
        End With
        '
        Me.TreeView1.SelectedNode = Me.TreeView1.SelectedNode.Parent
        Me.refrescarProyecto()
        'Me.TreeView1.SelectedNode.Remove()
    End Sub

    Private Sub ts_borrar_voz_Click(sender As System.Object, e As System.EventArgs) Handles ts_borrar_voz.Click
        'variable can creada para saber cuantas voces tiene un tipo de voz
        'que luego sera utilizada para actualizar el campo codigo_2
        Dim odt As New DataTable
        Dim can As Integer = 0
        ''''
        If oVoz_tipo_voz.verificarIntegridadPorcentaje(CInt(Me.lblid_tipo_voz.Text), CInt(Me.lblid_voz.Text)) = False Then
            MessageBox.Show("Todas las voces del control seleccionado tienen ponderaciones manuales, al menos una debe ser automática.", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If MessageBox.Show("Desea Realmente Eliminar el Registro ", "BORRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        With oVoz
            .Cargar()
            .Borrar(CInt(Me.lblid_voz.Text))
            .Guardar()
        End With

        With oVoz_tipo_voz
            .Cargar()
            .BorrarVoz(CInt(Me.lblid_voz.Text), CInt(Me.lblid_tipo_voz.Text))
            .Guardar()
            .UpdatePorcentaje(CInt(Me.lblid_tipo_voz.Text))
        End With

        ''agregado para poder actualizar el codigo_2 en el arbol
        'oVoz_cantidad me trae el numero de voces restantes para ese tipo de voz
        odt = oVoz.Cantidad(CInt(Me.lblid_control.Text), CInt(Me.lblid_tipo_voz.Text))

        If odt.Rows.Count <> 0 Then
            can = CInt(odt.Rows(0)("cantidad"))
        End If

        ''oVoz_voces me trae todas las voces para ese control y tipo de voz
        odt = oVoz.Voces(CInt(Me.lblid_control.Text), CInt(Me.lblid_tipo_voz.Text))

        ' me actualiza el codigo_2 para las voces
        'can sera el valor que se actualiza en el codigo_2
        'y (cam - 1) es para que inicie en la posicion 0 del rows
        For i = 1 To can
            Try
                With oVoz
                    .Cargar()
                    .Modificar(CInt(odt.Rows(i - 1)("id_voz")))
                    .codigo_2 = CStr(i)
                    .Guardar()
                End With
            Catch ex As Exception
            End Try
        Next

        Me.TreeView1.SelectedNode = Me.TreeView1.SelectedNode.Parent
        Me.refrescarProyecto()
        'Load_tree()

    End Sub

    Private Sub ctx_menu_Opening(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles ctx_menu.Opening

        Select Case seleccionado
            Case 0
                Me.ts_agregar_control.Enabled = True
                Me.ts_borrar_control.Enabled = True
                Me.ts_modificar_control.Enabled = True
                Me.ts_agregar_tv.Enabled = True
                Me.ts_agregar_voz.Enabled = False 'modificado
                Me.ts_borrar_tv.Enabled = False
                Me.ts_borrar_voz.Enabled = False
                Me.ts_modificar_tv.Enabled = False
                Me.ts_modificar_voz.Enabled = False
                Me.ts_porcentaje.Enabled = False
                Me.ts_modificar_codigo_voz.Enabled = False
                Me.ts_porcentaje_tipo.Enabled = False
                Me.ts_ordenar_voz.Enabled = False
                Me.tsOrdenarTiposDeVoz.Enabled = True
            Case 1
                Me.ts_agregar_tv.Enabled = True
                Me.ts_borrar_tv.Enabled = True
                Me.ts_modificar_tv.Enabled = True
                Me.ts_porcentaje.Enabled = False
                Me.ts_agregar_control.Enabled = False
                Me.ts_agregar_voz.Enabled = True
                Me.ts_borrar_control.Enabled = False
                Me.ts_borrar_voz.Enabled = False
                Me.ts_modificar_control.Enabled = False
                Me.ts_modificar_voz.Enabled = False
                Me.ts_modificar_codigo_voz.Enabled = False
                Me.ts_porcentaje_tipo.Enabled = True
                Me.ts_ordenar_voz.Enabled = True
                Me.tsOrdenarTiposDeVoz.Enabled = False
                Me.ts_ordenar_voz.Enabled = True
            Case 3
                Me.ts_agregar_voz.Enabled = True
                Me.ts_borrar_voz.Enabled = True
                Me.ts_modificar_voz.Enabled = True
                Me.ts_porcentaje.Enabled = True
                Me.ts_agregar_control.Enabled = False
                Me.ts_agregar_tv.Enabled = False
                Me.ts_borrar_control.Enabled = False
                Me.ts_borrar_tv.Enabled = False
                Me.ts_modificar_control.Enabled = False
                Me.ts_modificar_tv.Enabled = False
                Me.ts_modificar_codigo_voz.Enabled = True
                Me.ts_porcentaje_tipo.Enabled = False
                Me.ts_ordenar_voz.Enabled = False
                Me.tsOrdenarTiposDeVoz.Enabled = False
            Case Else

        End Select
        'If vgNombreUsuario <> "administradorsistema" Then
        '    Me.ts_borrar_control.Enabled = False
        'End If
    End Sub
    ''
    ''
    'agregado para expandir el nodo
    Private Function GetNodeKeyProyecto(ByVal id_proyecto As Integer, ByVal parentCollection As TreeNodeCollection) As TreeNode
        Dim ret As TreeNode
        Dim child As TreeNode

        For Each child In parentCollection 'step through the parentcollection
            If CInt(child.Name) = id_proyecto Then
                ret = child
                ' ElseIf child.GetNodeCount(False) > 0 Then ' if there is child items then call this function recursively
                '     ret = GetNodeKeyProyecto(id_proyecto, child.Nodes)
            End If

            If Not ret Is Nothing Then Exit For 'if something was found, exit out of the for loop
        Next
        Return ret
    End Function

    '''' CREADO PARA LIMPIAR LOS CAMPOS
    Public Sub limpiar()
        Me.txtcodigo.Text = ""
        Me.txtCodigo_2.Text = ""
        Me.txtCodigoTipo.Text = ""
        Me.txticono.Text = ""
        Me.txtnombre_control.Text = ""
        Me.txtnombre_tipo_voz.Text = ""
        Me.txtnombre_voz.Text = ""
    End Sub

    Private Sub ts_porcentaje_Click(sender As System.Object, e As System.EventArgs) Handles ts_porcentaje.Click

        Dim frmVoz As New frmDetalleVoz_2
        If Not IsNumeric(Me.lblid_voz.Text) Then
            Exit Sub
        End If
        BanderaVoz = 2
        Me.AddOwnedForm(frmVoz)
        oVoz.Modificar(CInt(Me.lblid_voz.Text))
        'agregado para habilitar el porcentaje
        frmVoz.activar(True, False)
        frmVoz.ShowDialog()
        'oTipo_voz.UpdatePorcentaje(CInt(Me.lblid_tipo_voz.Text))
        'oTipo_voz.UpdatePorcentaje_2(CInt(Me.lblid_tipo_voz.Text), CInt(Me.lblid_voz.Text))
        oTipo_voz.UpdatePorcentaje_Todos(CInt(Me.lblid_tipo_voz.Text))
        'Load_tree()
        Me.TreeView1.SelectedNode = Me.TreeView1.SelectedNode.Parent
        Me.refrescarProyecto()
    End Sub

    Private Sub ts_Modificar_Codigo_Voz_Click(sender As System.Object, e As System.EventArgs) Handles ts_modificar_codigo_voz.Click
        Dim frmTemp As New frmDetalleVozCodigo
        Me.AddOwnedForm(frmTemp)
        frmTemp.ShowDialog()
        'Me.Load_tree()
        Me.TreeView1.SelectedNode = Me.TreeView1.SelectedNode.Parent
        Me.refrescarProyecto()
    End Sub

    Private Sub ts_porcentaje_tipo_Click(sender As System.Object, e As System.EventArgs) Handles ts_porcentaje_tipo.Click
        Dim frmTipo As New frmDetalleTipo_voz_2
        If Not IsNumeric(Me.lblid_tipo_voz.Text) Then
            Exit Sub
        End If
        Me.AddOwnedForm(frmTipo)
        frmTipo.ShowDialog()
        oTipo_voz.UpdatePorcentaje_tipo_2(CInt(lblid_control.Text))
        'Load_tree()
        Me.refrescarProyecto()
    End Sub

    Private Sub TreeView1_DragEnter(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles TreeView1.DragEnter
        e.Effect = DragDropEffects.Move
    End Sub

    Private Sub TreeView1_ItemDrag(sender As Object, e As System.Windows.Forms.ItemDragEventArgs) Handles TreeView1.ItemDrag
        DoDragDrop(e.Item, DragDropEffects.Move)
    End Sub

    Private Sub TreeView1_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles TreeView1.DragDrop
        'If Me.TreeView1.SelectedNode.ImageIndex <> 1 Or NodoOrigen.ImageIndex <> 1 Then
        '    Exit Sub
        'End If
        Try
            Dim NodoOrigen, DestinationNode As TreeNode
            Dim padre As Integer
            'desabilita el ordenamiento del arbol
            TreeView1.Sorted = False
            If e.Data.GetDataPresent("System.Windows.Forms.TreeNode", False) Then
                Dim pt As Point
                pt = CType(sender, TreeView).PointToClient(New Point(e.X, e.Y))
                'nodo de destino sera aquel nodo sobre el que este el mouse 
                DestinationNode = CType(sender, TreeView).GetNodeAt(pt)
                'nodo de origen
                NodoOrigen = CType(e.Data.GetData("System.Windows.Forms.TreeNode"), TreeNode)

                'para que el usuario al arrastrarlo sobre si mismo no haga nada
                If DestinationNode.Name <> NodoOrigen.Name Then
                    'si es click derecho(0) copia si es izq arrastra(1)
                    If banderaclick = 0 Then
                        If DestinationNode IsNot Nothing Then 'IsNothing(DestinationNode) 

                            If DestinationNode.ImageIndex = 3 Or (NodoOrigen.ImageIndex = 0 Or NodoOrigen.ImageIndex = -1) _
                                Or (DestinationNode.ImageIndex = NodoOrigen.ImageIndex) _
                                    Or (NodoOrigen.ImageIndex = 3 And (DestinationNode.ImageIndex = -1 Or DestinationNode.ImageIndex = 0)) Then 'si el nodo de destino es
                                Exit Sub
                            End If
                            'copia el archivo si el directorio de destino no es en el mismo
                            If DestinationNode.Parent IsNot NodoOrigen.Parent Then 'DestinationNode.FullPath <> NodoOrigen.FullPath Then
                                If (DestinationNode.ImageIndex = 0 Or DestinationNode.ImageIndex = -1) And NodoOrigen.ImageIndex = 1 Then
                                    With oTipo_voz
                                        .Modificar(CInt(NodoOrigen.Name))
                                        .id_control = CInt(DestinationNode.Name)
                                        .Guardar()
                                    End With
                                End If
                                If DestinationNode.ImageIndex = 1 And NodoOrigen.ImageIndex = 3 Then
                                    With oVoz_tipo_voz
                                        .Cargar()
                                        .Modificar(CInt(NodoOrigen.Name))
                                        .id_tipo_voz = CInt(DestinationNode.Name)
                                        .Guardar()
                                    End With
                                End If
                                DestinationNode.Nodes.Add(CType(NodoOrigen.Clone, TreeNode))
                                DestinationNode.Expand()
                                'Remove original node
                                NodoOrigen.Remove()
                            End If
                        End If
                        TreeView1.SelectedNode = DestinationNode.LastNode

                    Else    'click izq 1
                        'nodo siguiente al destino
                        Dim Nodosiguiente As TreeNode = DestinationNode.NextNode
                        'nodo anterior al destino
                        Dim prevNode As TreeNode = DestinationNode.PrevNode

                        Dim odt, torigen, tdestino As New DataTable
                        Dim x, y, i, index, origen, actual, destino As Integer '= odt.Rows.Count
                        y = 0

                        'el nodo arrastrado solo pueda ser arrastrado a nodos de su mismo nivel
                        If NodoOrigen.Parent Is DestinationNode.Parent Then

                            Dim parentNodo As Object = TreeView1.SelectedNode.Parent
                            Dim indicedNext, indicedPrev As Integer
                            x = NodoOrigen.ImageIndex
                            'si es un control 
                            Select Case x 'NodoOrigen.ImageIndex
                                Case 0 Or -1
                                    odt = oControl.ConsultarTodo

                                    torigen = oControl.GetOne(CInt(NodoOrigen.Name)) 'GetOne(CInt(Me.lblid_actividad_proyecto.Text))
                                    tdestino = oControl.GetOne(CInt(DestinationNode.Name))

                                    origen = CInt(torigen.Rows(0).Item("Indice").ToString)
                                    destino = CInt(tdestino.Rows(0).Item("Indice").ToString)


                                Case 1
                                    odt = oTipo_voz.GetAllArbol_2(CInt(Me.lblid_control.Text))

                                    torigen = oTipo_voz.GetOne(CInt(NodoOrigen.Name))
                                    tdestino = oTipo_voz.GetOne(CInt(DestinationNode.Name))

                                    'x = 0
                                    origen = CInt(torigen.Rows(0).Item("indice").ToString)
                                    destino = CInt(tdestino.Rows(0).Item("indice").ToString)


                                Case 3
                                    odt = oVoz_tipo_voz.GetAll_4(CInt(Me.lblid_tipo_voz.Text))

                                    torigen = oVoz_tipo_voz.GetOne(CInt(NodoOrigen.Name))
                                    tdestino = oVoz_tipo_voz.GetOne(CInt(DestinationNode.Name))

                                    origen = CInt(torigen.Rows(0).Item("indice").ToString)
                                    destino = CInt(tdestino.Rows(0).Item("indice").ToString)
                            End Select
                            If odt.Rows.Count = 0 Then
                                Exit Sub
                            End If
                            If Nodosiguiente IsNot Nothing Then
                                indicedNext = Nodosiguiente.Index
                                If IsNothing(prevNode) Then
                                    indicedPrev = 0
                                Else
                                    indicedPrev = DestinationNode.Index
                                End If


                                ' el movimiento de arrastrar es hacia arriba
                                If indicedNext <= NodoOrigen.Index Then
                                    index = indicedPrev
                                    'guarda
                                    For Each row As DataRow In odt.Rows
                                        actual = CInt(row.Item("indice"))
                                        If origen = actual Then
                                            y = destino
                                            i = CInt(NodoOrigen.Name)
                                            guardarOrdenBD(x, y, i)
                                        End If
                                        If origen > actual And actual >= destino Then
                                            y = actual + 1
                                            i = CInt(row(0).ToString)
                                            guardarOrdenBD(x, y, i)
                                        End If

                                    Next


                                Else ' el movimiento de arrastrar es hacia abajo
                                    index = indicedNext - 1

                                    For Each row As DataRow In odt.Rows 'For orden = CInt(act.Rows(0).Item("orden").ToString) To x
                                        actual = CInt(row.Item("indice").ToString)

                                        If origen = actual Then
                                            y = destino
                                            i = CInt(NodoOrigen.Name)
                                            guardarOrdenBD(x, y, i)
                                        End If
                                        If origen < actual And actual <= destino Then
                                            y = actual - 1
                                            i = (CInt(row.Item(0).ToString))
                                            guardarOrdenBD(x, y, i)
                                        End If

                                    Next

                                End If
                                ''' End If
                            Else  '''If IsNothing(Nodosiguiente) si no hay ningun nodo despues del nodo de destino
                                index = odt.Rows.Count

                                For Each row As DataRow In odt.Rows
                                    actual = CInt(row.Item("indice").ToString)
                                    If origen < actual Then
                                        'With oTipo_voz
                                        '    .Modificar(CInt(row("Id_tipo_voz").ToString))
                                        '    .indice = .indice - 1
                                        '    .Guardar()
                                        'End With
                                        i = CInt(row(0).ToString)
                                        y = 9999
                                        guardarOrdenBD(x, y, i)
                                    End If

                                Next
                                i = CInt(NodoOrigen.Name)
                                y = odt.Rows.Count
                                guardarOrdenBD(x, y, i)

                            End If

                            If parentNodo IsNot Nothing Then
                                CType(parentNodo, TreeNode).Nodes.Remove(CType(parentNodo, TreeNode).Nodes(NodoOrigen.Index))
                                CType(parentNodo, TreeNode).Nodes.Insert(index, NodoOrigen)
                            Else
                                TreeView1.Nodes.Remove(NodoOrigen)
                                TreeView1.Nodes.Insert(index, NodoOrigen)
                            End If
                        End If
                        'Seleccionamos el arrastrado
                        TreeView1.SelectedNode = NodoOrigen
                    End If
                End If
            End If



        Catch ex As Exception

        End Try


    End Sub

    Private Sub guardarOrdenBD(ByVal x As Integer, ByVal y As Integer, ByRef i As Integer)
        Select Case x
            Case 0 Or -1
                With oControl
                    .Modificar(i) 'CInt(torigen.Rows(0).Item("Id_control").ToString))
                    If y = 9999 Then
                        .indice = .indice - 1
                    Else
                        .indice = y
                    End If
                    .Guardar()
                End With
            Case 1
                'For Each row As DataRow In odt.Rows
                '    actual = CInt(row.Item("orden").ToString)

                '    If origen = actual Then
                With oTipo_voz
                    .Modificar(i) '(CInt(torigen.Rows(0).Item("Id tipo voz").ToString))
                    If y = 9999 Then
                        .indice = .indice - 1
                    Else
                        .indice = y
                    End If '(CInt(tdestino.Rows(0).Item("orden").ToString))
                    .Guardar()
                End With
                '                    End If


                '                Next
            Case 3
                With oVoz_tipo_voz
                    .Modificar(i) '(CInt(torigen.Rows(0).Item("Id tipo voz").ToString))
                    If y = 9999 Then
                        .indice = .indice - 1
                    Else
                        .indice = y
                    End If
                    .Guardar()
                End With
        End Select
    End Sub
    Private Sub tsOrdenarCreacion_Click(sender As Object, e As System.EventArgs) Handles tsOrdenCreacion.Click
        Dim tabla1 As New DataTable
        tabla1 = oTipo_voz.GetAllArbol_4(CInt(Me.lblid_control.Text))
        tsOrdenCreacion.Checked = True
        Dim x As Integer = 0
        For Each row As DataRow In tabla1.Rows
            x = x + 1
            With oTipo_voz
                .Cargar()
                .Modificar(CInt(row.Item("id_tipo_voz").ToString))
                .indice = x
                .nro = 1
                .Guardar()
            End With
        Next

        Me.refrescarProyecto()
        'Load_tree()
    End Sub

    Private Sub tsNombre_Click(sender As Object, e As System.EventArgs) Handles tsNombre.Click
        Dim odt As New DataTable
        odt = oTipo_voz.GetAllArbol_ordenado(CInt(Me.lblid_control.Text))
        tsNombre.Checked = True
        Dim x As Integer = 0
        For Each row As DataRow In odt.Rows
            x = x + 1
            With oTipo_voz
                .Cargar()
                .Modificar(CInt(row.Item("id_tipo_voz").ToString))
                .indice = x
                .nro = 2
                .Guardar()
            End With
        Next
        'Load_tree()
        Me.refrescarProyecto()
    End Sub

    Private Sub tsOrdenarTiposDeVoz_MouseHover(sender As Object, e As System.EventArgs) Handles tsOrdenarTiposDeVoz.MouseHover
        Dim tabla1 As New DataTable
        tabla1 = oTipo_voz.GetAllArbol_4(CInt(Me.lblid_control.Text))
        Try
            Dim ordenamiento As Integer = CInt(tabla1.Rows(0).Item("nro").ToString)

            Select Case ordenamiento
                Case 1
                    tsOrdenCreacion.Checked = True
                    tsNombre.Checked = False
                Case 2
                    tsOrdenCreacion.Checked = False
                    tsNombre.Checked = True
                Case Else
                    Exit Select
            End Select
        Catch ex As Exception
            tsOrdenCreacion.Checked = False
            tsNombre.Checked = False
        End Try
    End Sub

    Private Sub refrescarControl()
        Dim tnParent As New TreeNode()
        tnParent.Text = Me.TreeView1.SelectedNode.Text
        tnParent.Name = Me.lblid_control.Text
        Dim nodoindex = TreeView1.SelectedNode.Index

        Me.TreeView1.SelectedNode = tnParent

        FillChild(tnParent, tnParent.Name)
    End Sub

  
    Private Sub ts_ordenar_voz_MouseHover(sender As Object, e As System.EventArgs) Handles ts_ordenar_voz.MouseHover
        Dim tabla1 As New DataTable
        tabla1 = oVoz_tipo_voz.GetAll_4(CInt(TreeView1.SelectedNode.Name))
        Try
            Dim ordenamiento As Integer = CInt(tabla1.Rows(0).Item("nro").ToString)

            Select Case ordenamiento
                Case 1
                    ts_nombrevoz.Checked = False
                    ts_creacion.Checked = True
                Case 2
                    ts_creacion.Checked = False
                    ts_nombrevoz.Checked = True
                Case Else
                    Exit Select
            End Select
        Catch ex As Exception
            tsOrdenCreacion.Checked = False
            tsNombre.Checked = False
        End Try
    End Sub

    Private Sub ts_nombrevoz_Click(sender As Object, e As System.EventArgs) Handles ts_nombrevoz.Click
        Dim odt As New DataTable
        odt = oVoz_tipo_voz.GetAll_Nombre(CInt(Me.lblid_tipo_voz.Text))
        ts_nombrevoz.Checked = True
        Dim x As Integer = 0
        Dim id As Integer
        For Each row As DataRow In odt.Rows
            x = x + 1
            id = CInt(row.Item("id_voz").ToString)
            With oVoz_tipo_voz
                .Cargar()
                .Modificar(id)
                .indice = x
                .nro = 2
                .Guardar()
            End With
        Next
        Me.TreeView1.SelectedNode = Me.TreeView1.SelectedNode.Parent
        'Load_tree()
        Me.refrescarProyecto()
    End Sub

    Private Sub ts_creacion_Click(sender As Object, e As System.EventArgs) Handles ts_creacion.Click
        Dim tabla1 As New DataTable
        tabla1 = oVoz_tipo_voz.GetAll_Creacion(CInt(Me.lblid_tipo_voz.Text))
        tsOrdenCreacion.Checked = True
        Dim x As Integer = 0
        For Each row As DataRow In tabla1.Rows
            x = x + 1
            With oVoz_tipo_voz
                .Cargar()
                .Modificar(CInt(row.Item("id_voz").ToString))
                .indice = x
                .nro = 1
                .Guardar()
            End With
        Next
    End Sub

    Private Sub TreeView1_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseDoubleClick
        Dim str As stArbol
        str = CType(Me.TreeView1.SelectedNode.Tag, stArbol)

        If str.id_voz <> 0 Then
            Me.ts_modificar_voz_Click(Nothing, Nothing)
        ElseIf str.id_tipo_voz <> 0 Then
            Me.ts_modificar_tv_Click(Nothing, Nothing)
        Else
            Me.ts_modificar_control_Click(Nothing, Nothing)
        End If
    End Sub
End Class
