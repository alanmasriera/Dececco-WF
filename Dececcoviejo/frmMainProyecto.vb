Imports System.Data.SqlClient
Imports System.Xml
Imports System.IO

Public Class frmMainProyecto

    Private Sub frmMainProyecto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Me.RefrescarTree()
        Me.Load_tree()

        Me.CargarControlador_1()
        Me.CargarControlador_2()
        Me.CargarProyect_manager()
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

    Private Sub btnBuscaProyect_manager_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmTemporal As New frmAbmUsuario
        frmTemporal.ShowDialog()
        Me.CargarProyect_manager()
        Me.cmbproyect_manager.Focus()
        Me.cmbproyect_manager.Text = ""
        Me.lblid_proyect_manager.Text = "0"
    End Sub

    Private Sub cmbControlador_1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcontrolador_1.SelectedIndexChanged
        If Me.cmbcontrolador_1.SelectedIndex >= 0 Then
            Me.lblid_controlador_1.Text = cmbcontrolador_1.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaControlador_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmTemporal As New frmAbmUsuario
        frmTemporal.ShowDialog()
        Me.CargarControlador_1()
        Me.cmbcontrolador_1.Focus()
        Me.cmbcontrolador_1.Text = ""
        Me.lblid_controlador_1.Text = "0"
    End Sub

    Private Sub cmbControlador_2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcontrolador_2.SelectedIndexChanged
        If Me.cmbControlador_2.SelectedIndex >= 0 Then
            Me.lblid_controlador_2.Text = cmbControlador_2.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaControlador_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmTemporal As New frmAbmUsuario
        frmTemporal.ShowDialog()
        Me.CargarControlador_2()
        Me.cmbcontrolador_2.Focus()
        Me.cmbcontrolador_2.Text = ""
        Me.lblid_controlador_2.Text = "0"
    End Sub

    'Sub RefrescarTree()
    '    Dim odsProyecto As New DataSet
    '    Dim odtProyecto As New DataTable
    '    Dim odtTipoVoz As New DataTable
    '    Dim odtVozTipoVoz As New DataTable

    '    odtProyecto = oProyecto.GetAllFirst
    '    odtTipoVoz = oTipo_voz.GetAllArbol
    '    odtVozTipoVoz = oVoz_tipo_voz.GetAll_3

    '    odsProyecto.Tables.Add(odtProyecto)
    '    odsProyecto.Tables.Add(odtTipoVoz)
    '    odsProyecto.Tables.Add(odtVozTipoVoz)

    '    Try
    '        odsProyecto.Relations.Add("ProyectoAProyecto", odsProyecto.Tables("Proyecto").Columns("id_proyecto"), odsProyecto.Tables("Proyecto").Columns("id_proyecto_padre"))
    '        odsProyecto.Relations.Add("TipoAVoz", odsProyecto.Tables("Tipo_voz").Columns("id_tipo_voz"), odsProyecto.Tables("Voz_tipo_voz").Columns("id_tipo_voz"))
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try

    '    ''Create a data relation object to facilitate the relationship between the Customers and Orders data tables.
    '    'DSNWind.Relations.Add("CustToOrd", DSNWind.Tables("dtCustomers").Columns("CustomerID"), DSNWind.Tables("dtOrders").Columns("CustomerID"))
    '    'DSNWind.Relations.Add("OrdToDet", DSNWind.Tables("dtOrders").Columns("OrderID"), DSNWind.Tables("dtOrderdetails").Columns("OrderID"))
    '    '''''''''''''''''''''''
    '    TreeView1.Nodes.Clear()
    '    Dim i, n As Integer
    '    Dim parentrow As DataRow
    '    Dim ParentTable As DataTable
    '    ParentTable = odsProyecto.Tables("Proyecto")

    '    For Each parentrow In ParentTable.Rows
    '        Dim parentnode As TreeNode
    '        parentnode = New TreeNode(CStr(parentrow.Item("nombre_proyecto")))
    '        parentnode.Name = CStr(parentrow.Item("id_proyecto"))

    '        TreeView1.Nodes.Add(parentnode)
    '        ''''populate child'''''
    '        '''''''''''''''''''''''
    '        Dim childrow As DataRow
    '        Dim childnode As TreeNode
    '        childnode = New TreeNode()
    '        For Each childrow In parentrow.GetChildRows("ProyectoAProyecto")
    '            childnode = parentnode.Nodes.Add(CStr(childrow("id_proyecto")), CStr(childrow("nombre_proyecto")), 1)
    '            childnode.Tag = childrow("id_tipo_voz")
    '            ''''populate child2''''
    '            ''''''''''''''''''''''''''
    '            Dim childrow2 As DataRow
    '            Dim childnode2 As TreeNode
    '            childnode2 = New TreeNode()
    '            For Each childrow2 In childrow.GetChildRows("TipoAVoz")
    '                childnode2 = childnode.Nodes.Add(CStr(childrow2("id_voz")), CStr(childrow2("nombre_voz")), 3)

    '            Next childrow2
    '            ''''''''''''''''''''''''

    '        Next childrow
    '        '''''''''''''''
    '    Next parentrow
    'End Sub

    Protected Function PDataset(ByVal select_statement As String) As DataSet
        Dim strServer As String
        Dim strDB As String
        Dim strUser As String
        Dim strPass As String

        'strServer = Environment.MachineName
        'strServer = strServer & "(local)\SQLExpress"

        'conexion casa
        'strServer = "PCMARIO\SQLExpress"

        'conexion trabajo
        'strServer = "CBA-28\SQLExpress"

        'conexion carlos
        strServer = "SERVER"

        'Conexion(notebook)
        ' strServer = "(local)\SQLEXPRESS"


        ' strDB = "SuperTest"

        strDB = "Dececco"

        strUser = "carlos"
        strPass = "carlos2008"

        Dim cadena As String = ""
        cadena = "Server=" & strServer & ";" & _
                                "DataBase=" & strDB & ";" & _
                                "User ID=" & strUser & ";" & _
                                "Password=" & strPass & ";" & _
                                "Trusted_Connection=false"

        Dim _con As New SqlConnection(cadena)
        Dim ad As New SqlDataAdapter(select_statement, _con)
        Dim ds As New DataSet()
        ad.Fill(ds)
        _con.Close()
        Return ds
    End Function

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
        Me.TreeView1.ExpandAll()
    End Sub

    Public Function FillChild(ByVal parent As TreeNode, ByVal IID As String) As Integer
        Dim ds As DataSet = PDataset("SELECT * FROM proyecto WHERE id_proyecto_padre = " & IID)

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

                Dim odt As New DataTable
                odt = oActividad_proyecto.GetAllProyecto(CInt(temp))
                For Each row As DataRow In odt.Rows
                    Dim child_2 As New TreeNode()
                    child_2.Text = row("nombre_actividad").ToString().Trim()
                    Dim temp_2 As String = row("id_actividad").ToString()
                    child_2.Collapse()

                    child_2 = parent.Nodes.Add(CStr(row("id_actividad")), CStr(row("nombre_actividad")), 1, 3)
                    child_2.Tag = row("id_proyecto")

                    '  parent.Nodes.Add(temp_2, child_2.Text, 1)
                Next

                FillChild(child, temp)
            Next
            Return 0
        Else
            Return 0
        End If
    End Function

    Public Function FillChild_2(ByVal parent As TreeNode, ByVal IID As String) As Integer
        Dim ds As DataSet = PDataset("SELECT * FROM dbo.Actividad INNER JOIN dbo.Actividad_proyecto ON dbo.Actividad.id_actividad = dbo.Actividad_proyecto.id_actividad WHERE id_proyecto = " & IID)
        If ds.Tables(0).Rows.Count > 0 Then

            For Each dr As DataRow In ds.Tables(0).Rows
                Dim child As New TreeNode()
                child.Text = dr("nombre_actividad").ToString().Trim()
                Dim temp As String = dr("id_actividad").ToString()
                child.Collapse()
                parent.Nodes.Add(child)
                FillChild_2(child, temp)
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

    Private Sub btnNuevoProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoProyecto.Click
        Me.txtnombre_proyecto.Text = ""
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
                    Me.GroupBox2.Enabled = True
                    Me.GroupBox1.Enabled = False
                Case 3
                    Me.lblid_proyecto.Text = Me.TreeView1.SelectedNode.Parent.Name
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

                    Me.GroupBox2.Enabled = False
                    Me.GroupBox1.Enabled = True

            End Select
        Catch ex As Exception

        End Try



    End Sub

    Private Sub btnNuevoActividad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoActividad.Click
        Me.txtnombre_actividad.Text = ""
        Me.lblBanderaActividad.Text = CStr(1)

        Dim odtAP As New DataTable
        odtAP = oActividad_proyecto.GetMaxOrden(CInt(Me.lblid_proyecto.Text))

        Me.txtOrden.Text = CStr(CDec(odtAP.Rows(0).Item("orden")) + 1)
    End Sub

    Private Sub btnModificarActividad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarActividad.Click
        Me.lblBanderaActividad.Text = CStr(2)
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
    End Sub

    Private Sub chkProyectoInicial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkProyectoInicial.CheckedChanged
        If Me.chkProyectoInicial.Checked = True Then
            Me.cmbcontrolador_1.Visible = True
            Me.cmbcontrolador_2.Visible = True
            Me.cmbproyect_manager.Visible = True
            Me.etiquetaid_controlador_1.Visible = True
            Me.etiquetaid_controlador_2.Visible = True
            Me.etiquetaid_proyect_manager.Visible = True
        Else
            Me.cmbcontrolador_1.Visible = False
            Me.cmbcontrolador_2.Visible = False
            Me.cmbproyect_manager.Visible = False
            Me.etiquetaid_controlador_1.Visible = False
            Me.etiquetaid_controlador_2.Visible = False
            Me.etiquetaid_proyect_manager.Visible = False
        End If
    End Sub

End Class