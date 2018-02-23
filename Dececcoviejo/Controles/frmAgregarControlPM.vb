Public Class frmAgregarControlPM

    Dim id_actividad_proyecto As Integer

    Public Sub New(ByVal id_actividad_proyecto As Integer)

        Me.id_actividad_proyecto = id_actividad_proyecto
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub frmAgregarControl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CargarCombos()
        Me.CargarControl()
    End Sub

    Sub CargarControl()
        Dim odt As New DataTable
        odt = oControl.GetCmb
        With Me.cmbcontrol
            .DataSource = odt
            .DisplayMember = "nombre_control"
            .ValueMember = "id_control"
        End With

        odt = oUsuario.GetCmb
        With Me.cmb_cadista
            .DataSource = odt
            .DisplayMember = "nombre_usuario"
            .ValueMember = "id_usuario"
            .SelectedValue = vgCodigoUsuario
        End With

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

        If Me.cmbcontrol.SelectedIndex >= 0 Then
            cmbcontrol.SelectedIndex = 0
            Me.lblid_control.Text = cmbcontrol.SelectedValue.ToString
        End If
    End Sub




    Private Sub btnAgregarControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarControl.Click
        vgbanderacontrol = True
        'Dim odtProy As New DataTable
        'odtProy = oProyecto.GetOne(CInt(Me.lblid_proyecto.Text))
        'Dim rowProy As DataRow = odtProy.Rows(0)

        Dim odtActProy As New DataTable
        odtActProy = oActividad_proyecto.GetOne(id_actividad_proyecto)
        Dim rowActProy As DataRow = odtActProy.Rows(0)


        With oMovimiento_voz
            .Cargar()
            .Insertar()
            .fecha = Date.Now
            .id_cadista = CInt(Me.cmb_cadista.SelectedValue)
            .id_control = CInt(Me.cmbcontrol.SelectedValue)
            .id_controlador_1 = CInt(cmb_controlador_1.SelectedValue)
            .id_controlador_2 = CInt(cmb_controlador_2.SelectedValue)
            .id_proyect_manager = 0 'CInt(rowProy("id proyect manager"))
            .id_actividad_proyecto = id_actividad_proyecto
            .id_usuario_anterior = vgUsuarioAnterior
            .id_usuario_1 = CInt(Me.cmb_control_produccion.SelectedValue)
            .id_usuario_2 = CInt(Me.cmb_primer_control.SelectedValue)
            .id_usuario_3 = CInt(Me.cmb_correccion_1.SelectedValue)
            .id_usuario_4 = CInt(Me.cmb_2do_control_produccion.SelectedValue)
            .id_usuario_5 = CInt(Me.cmb_segundo_control.SelectedValue)
            .id_usuario_6 = CInt(Me.cmb_correccion_2.SelectedValue)
            .Guardar()

        End With

        Dim odtControl As New DataTable
        odtControl = oControl.GetAllVoz(CInt(Me.cmbcontrol.SelectedValue))

        For Each row As DataRow In odtControl.Rows
            With oCuerpo_movimiento_voz
                .Cargar()
                .Insertar()
                .id_movimiento_voz = oMovimiento_voz.id_movimiento_voz
                .id_usuario = CInt(Me.cmb_control_produccion.SelectedValue)
                .completado = False
                .id_voz = CInt(row("id_voz"))
                .Guardar()
            End With
        Next

        Dim _Actividad_Proyecto As New Actividad_proyecto
        With _Actividad_Proyecto
            .Cargar()
            .Modificar(Me.id_actividad_proyecto)
            .id_control = CInt(Me.cmbcontrol.SelectedValue)
            .id_controlador_1 = CInt(Me.cmb_primer_control.SelectedValue)
            .id_controlador_2 = CInt(cmb_controlador_2.SelectedValue)
        End With

        Me.Close()
    End Sub

    Private Sub CargarCombos()
        Me.cmb_control_produccion.DataSource = oUsuario.GetCmb()
        Me.cmb_control_produccion.ValueMember = "id_usuario"
        Me.cmb_control_produccion.DisplayMember = "nombre_usuario"

        Me.cmb_primer_control.DataSource = oUsuario.GetCmb()
        Me.cmb_primer_control.ValueMember = "id_usuario"
        Me.cmb_primer_control.DisplayMember = "nombre_usuario"

        Me.cmb_correccion_1.DataSource = oUsuario.GetCmb()
        Me.cmb_correccion_1.ValueMember = "id_usuario"
        Me.cmb_correccion_1.DisplayMember = "nombre_usuario"

        Me.cmb_2do_control_produccion.DataSource = oUsuario.GetCmb()
        Me.cmb_2do_control_produccion.ValueMember = "id_usuario"
        Me.cmb_2do_control_produccion.DisplayMember = "nombre_usuario"

        Me.cmb_segundo_control.DataSource = oUsuario.GetCmb()
        Me.cmb_segundo_control.ValueMember = "id_usuario"
        Me.cmb_segundo_control.DisplayMember = "nombre_usuario"

        Me.cmb_correccion_2.DataSource = oUsuario.GetCmb()
        Me.cmb_correccion_2.ValueMember = "id_usuario"
        Me.cmb_correccion_2.DisplayMember = "nombre_usuario"


    End Sub


    Private Sub cmb_cadista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_cadista.SelectedIndexChanged
        Try
            Me.cmb_control_produccion.SelectedValue = Me.cmb_cadista.SelectedValue
            Me.cmb_correccion_1.SelectedValue = Me.cmb_cadista.SelectedValue
            Me.cmb_2do_control_produccion.SelectedValue = Me.cmb_cadista.SelectedValue
            Me.cmb_correccion_2.SelectedValue = Me.cmb_cadista.SelectedValue
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmb_controlador_1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_controlador_1.SelectedIndexChanged
        Try
            Me.cmb_primer_control.SelectedValue = Me.cmb_controlador_1.SelectedValue
            Me.cmb_segundo_control.SelectedValue = Me.cmb_controlador_1.SelectedValue
        Catch ex As Exception

        End Try
    End Sub
End Class