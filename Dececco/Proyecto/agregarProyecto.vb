Imports System.Collections.Generic
Imports System.IO
Imports ControladoresLogica
Imports Entidades

Public Class AgregarProyecto
    ReadOnly _controladorProyecto As New ControladorProyecto
    ReadOnly _controladorClientes As New ControladorClientes
    ''ReadOnly openFileDialog1 As New OpenFileDialog
    Public _proyecto As Entidades.Proyecto

    Dim _listaUsuarios As New List(Of Entidades.USUARIO)

    Public Sub New(ByVal indexCliente As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _listaUsuarios = ControladorUsuarios.ObtenerTodosUsuarios()

        CargarDatosMiembros()
        CargarCombosUsuarios()
        CargarComboClientes(indexCliente)

        'openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        'openFileDialog1.Multiselect = False
        'openFileDialog1.ValidateNames = True
        'openFileDialog1.DereferenceLinks = False
        'openFileDialog1.Filter = "Excel |*.xlsx"

        txt_nombre_proyecto.Focus()
    End Sub


    Private Sub CargarComboClientes(ByVal indexCliente As Integer)
        cmbCliente.DataSource = _controladorClientes.ObtenerTodos().OrderBy(Function(x) x.nombre_cliente).ToList()
        cmbCliente.DisplayMember = "nombre_cliente"
        cmbCliente.SelectedIndex = indexCliente
    End Sub

    Private Sub CargarDatosMiembros()
        dgv_miembros_proyecto.Rows.Clear()
        For Each usuario As Entidades.USUARIO In _listaUsuarios
            dgv_miembros_proyecto.Rows.Add(0, usuario.id_usuario, usuario.nombre & " " & usuario.apellido, False)
        Next
    End Sub

    Private Sub CargarCombosUsuarios()
        cmb_controlador_1.DataSource = New List(Of Entidades.USUARIO)(_listaUsuarios)
        cmb_controlador_1.DisplayMember = "FullName"

        cmb_controlador_2.DataSource = New List(Of Entidades.USUARIO)(_listaUsuarios)
        cmb_controlador_2.DisplayMember = "FullName"

        cmb_piloto_proyecto.DataSource = New List(Of Entidades.USUARIO)(_listaUsuarios)
        cmb_piloto_proyecto.DisplayMember = "FullName"

        _cmb_pm_proyecto.DataSource = New List(Of Entidades.USUARIO)(_listaUsuarios)
        _cmb_pm_proyecto.DisplayMember = "FullName"

        cmbCalendario.DataSource = ControladorCalendario.ObtenerCalendarios().Where(Function(x) x.es_calendario_base = True).ToList
        cmbCalendario.DisplayMember = "nombre_calendario"
    End Sub

    Private Sub btn_guardar_proyecto_Click(sender As Object, e As EventArgs) Handles btn_guardar_proyecto.Click
        Dim proyecto As New Entidades.Proyecto

        ''_lblGenerandoProyecto.Visible = True
        btn_guardar_proyecto.Enabled = False
        
        With proyecto
            .nombre_proyecto = txt_nombre_proyecto.Text
            .descripcion = txt_descripcion_proyecto.Text
            .fecha_inicio = dtp_fecha_inicio_estimada_proyecto.Value
            .fecha_fin_prevista = _dtp_fecha_fin_estimada_proyecto.Value
            .fecha_fin_real = _dtp_fecha_fin_estimada_proyecto.Value
            .archivado = False
            .prioridad = 0
            .id_controlador_1 = cmb_controlador_1.SelectedValue.id_usuario
            .id_controlador_2 = cmb_controlador_2.SelectedValue.id_usuario
            .id_proyect_manager = cmb_pm_proyecto.SelectedValue.id_usuario
            .id_piloto = cmb_piloto_proyecto.SelectedValue.id_usuario
            .total_hora = _txt_horas_proyecto.Value
            .id_cliente = cmbCliente.SelectedValue.id_cliente
            .id_estado = 0
            .path = carpeta_path_proyecto & ControladorClientes.ObtenerCLiente(.id_cliente).nombre_cliente & "\\" & .nombre_proyecto
            .indice = 0
            .nro = 0
            .activo = True
            .id_calendario_laboral_base = DirectCast(cmbCalendario.SelectedItem,Calendario_Laboral).id_calendario_laboral
        End With

        Directory.CreateDirectory(proyecto.path)
        
        _controladorProyecto.Insertar(proyecto:=proyecto, asignarOT:=True)

        Dim lista As New List(Of Entidades.USUARIO)
        Dim usuario As Entidades.USUARIO

        For Each row As DataGridViewRow In dgv_miembros_proyecto.Rows
            If row.Cells("chk_seleccionado_usuario_proyecto").Value = True Then
                usuario = New Entidades.USUARIO()
                usuario.id_usuario = row.Cells("id_usuario").Value
                lista.Add(usuario)
            End If
        Next

        _controladorProyecto.AsignarMiembros(lista, proyecto.id_proyecto)

        'If Not openFileDialog1.FileName = "" Then
        '    Dim excel As New ControladorProyectoExcel
        '    excel.AgregarProyectoExcel(proyecto)
        'End If

        _proyecto = proyecto
        DialogResult = DialogResult.OK
        Close()
    End Sub

    'Private Sub btnExcel_click(sender As Object, e As EventArgs) Handles btnExcel.Click
    '    If Not openFileDialog1.FileName = "" Then
    '        openFileDialog1.InitialDirectory = openFileDialog1.FileName.Substring(0, openFileDialog1.FileName.LastIndexOf("\"))
    '    End If

    '    If openFileDialog1.ShowDialog() = DialogResult.OK Then
    '        lblArchivoExcel.Text = openFileDialog1.FileName
    '    End If
    'End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

End Class