Public Class frmControlActividad

    Dim odt As New DataTable
    Dim intNumeroRevision As Integer
    Dim odtTempE As New DataTable
    Dim intBanderaVolver As Integer = 0
    Dim btnVolverPresionado As Boolean = False
    Dim hayDisconformidad As Boolean
    Dim primer_inicio As Boolean = True
    Dim strCodigoTipo As String = ""
    Dim strCodigoTipoViejo As String = ""
    Dim intRowPosicion As Integer = 0
    Dim pedido_segundo_control As Boolean
    Dim banCorresponde As Boolean = False
    Dim intNumeroControl As Integer = 0
    Dim posicion_tabla As Integer = -1
    Dim posicion_tabla_ultimo As Integer = -1
    Dim id_actividad_proyecto As Integer
    Dim id_detalle_recurso As Integer = 0
    Dim id_cuerpo_movimiento_voz As Integer = 0
    Dim id_cuerpo_movimiento_voz_viejo As Integer = 0
    Dim id_movimiento_voz As Integer = 0
    Dim id_tipo_voz As Integer = 0
    Dim id_control As Integer = 0
    Dim _Movimiento_voz As New Movimiento_voz

    Public Sub New(ByVal id_actividad_proyecto As Integer, ByVal id_detalle_recurso As Integer, ByVal id_movimiento_voz As Integer)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        Me.id_actividad_proyecto = id_actividad_proyecto
        Me.id_movimiento_voz = id_movimiento_voz
        Me.id_detalle_recurso = id_detalle_recurso
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub frmControlActividad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        With _Movimiento_voz
            .Cargar()
            .Modificar(Me.id_movimiento_voz)
            Me.id_control = .id_control
        End With

        'Para obtener el nombre del proyecto
        Dim nombre_proyecto As String

        Dim _actividad_proyecto As New Actividad_proyecto
        Dim _Subproyecto As New entSubproyecto
        Dim _Proyecto As New Proyecto

        With _actividad_proyecto
            .Cargar()
            .Modificar(Me.id_actividad_proyecto)
        End With

        If _actividad_proyecto.id_subproyecto <> 0 Then
            With _Subproyecto
                .Cargar()
                .Modificar(_actividad_proyecto.id_subproyecto)
            End With
            nombre_proyecto = _Subproyecto.ObtenerProycetoYPath(_Subproyecto.id_suproyecto).Rows(0).Item("nombre_proyecto").ToString() + " / " + _Subproyecto.ObtenerProycetoYPath(_Subproyecto.id_suproyecto).Rows(0).Item("nombre_subproyecto").ToString()
        Else
            nombre_proyecto = _Proyecto.GetProyecto(_actividad_proyecto.id_proyecto).nombre_proyecto
        End If

        'Indica el path del proyecto seleccionado
        Me.Text = nombre_proyecto


        'Se utiliza para saber si cuando el controlador corrige y no encuentra errores, que 
        'el movimiento_voz cambie a estado completado
        hayDisconformidad = False


        'INICIALIZAR
        ObtenerVoces()


        Try
            Me.RefrescarControl()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ObtenerVoces()
        Select Case vgNumeroControl
            Case 1
                'Control de producción
                'SP: cop_Cuerpo_movimiento_voz_GetAllInicioPM - en el metodo se buscan todas las preguntas y propiedades del control
                odt = oVoz.GetAllInicioPM(vgCodigoUsuario, Me.id_actividad_proyecto, Me.id_control, 1)
                intNumeroControl = 1
            Case 2
                'Primer control
                odt = oVoz.GetAllInicioPM(vgCodigoUsuario, Me.id_actividad_proyecto, Me.id_control, 2)
                intNumeroControl = 2
            Case 3
                'Primera Corrección
                odt = oVoz.GetAllInicioPM(vgCodigoUsuario, Me.id_actividad_proyecto, Me.id_control, 3)

                'Verifica que haya errores por corregir
                If odt.Rows.Count > 0 Then
                    banCorresponde = True
                End If
                intNumeroControl = 3
            Case 4
                'Se hizo un pedido de segundo control y el cadista tiene que volver a pasar los controles
                odt = oVoz.GetAllInicioPM(vgCodigoUsuario, Me.id_actividad_proyecto, Me.id_control, 4)
                intNumeroControl = 4
            Case 5
                'El controlador tiene que revisar el nuevo control realizado por el cadista
                odt = oVoz.GetAllInicioPM(vgCodigoUsuario, Me.id_actividad_proyecto, Me.id_control, 5)
                intNumeroControl = 5
            Case 6
                'El controlador tiene que revisar el nuevo control realizado por el cadista
                odt = oVoz.GetAllInicioPM(vgCodigoUsuario, Me.id_actividad_proyecto, Me.id_control, 6)
                intNumeroControl = 6
        End Select
    End Sub

    Sub RefrescarControl()

        If btnVolverPresionado = True And posicion_tabla = posicion_tabla_ultimo Then
            btnVolverPresionado = False
        End If

        posicion_tabla = posicion_tabla + 1
        'Restablece los controles del checklist
        Me.Limpiar()

        banCorresponde = False

        odtTempE = oCuerpo_movimiento_voz.GetAllMovimientoGetRevision(Me.id_movimiento_voz, intNumeroRevision)


        If odt.Rows.Count = posicion_tabla Then

            'If intNumeroRevision <> 0 Then

            Dim rta As DialogResult
            rta = MessageBox.Show("Se realizaron todos los controles. ¿Desea salir?", "Completado", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If rta = DialogResult.Yes Then

                If vgNumeroControl = 1 Then
                    'Actualizar Movimiento_Control
                    With oMovimiento_voz
                        .Cargar()
                        .Modificar(Me.id_movimiento_voz)
                        .control_prod = True
                        .id_usuario_1 = vgCodigoUsuario
                        .Guardar()
                    End With
                    'Agregado por alan ->
                    Dim detalle_recurso As Entidades.Detalle_recurso = ControladoresLogica.ControladorTareas.ObtenerPorID(Me.id_detalle_recurso)
                    If detalle_recurso IsNot Nothing Then
                        detalle_recurso.fecha_fin = DateTime.Now
                        detalle_recurso.realizada = True
                        detalle_recurso.forzada = False
                        ControladoresLogica.ControladorTareas.Actualizar(detalle_recurso)
                    End If
                    '<-
                    

                End If
                If vgNumeroControl = 2 Then
                    'Actualizar Movimiento_Control
                    With oMovimiento_voz
                        .Cargar()
                        .Modificar(Me.id_movimiento_voz)
                        .id_usuario_2 = vgCodigoUsuario
                        .control_1 = True
                        If pedido_segundo_control = False And Not (hayDisconformidad = True) And oMovimiento_voz.hayErrores(Me.id_movimiento_voz) = False Then
                            .completado = True
                            .fecha_completado = Date.Now
                        End If
                        .Guardar()
                    End With

                    Dim detalle_recurso As Entidades.Detalle_recurso = ControladoresLogica.ControladorTareas.ObtenerPorID(Me.id_detalle_recurso)
                    If detalle_recurso IsNot Nothing Then
                        detalle_recurso.fecha_fin = DateTime.Now
                        detalle_recurso.realizada = True
                        detalle_recurso.forzada = False
                        ControladoresLogica.ControladorTareas.Actualizar(detalle_recurso)
                    End If

                End If

                If vgNumeroControl = 3 Then
                    'Actualizar Movimiento_Control
                    With oMovimiento_voz
                        .Cargar()
                        .Modificar(Me.id_movimiento_voz)
                        .control_corr_1 = True
                        .id_usuario_3 = vgCodigoUsuario
                        If pedido_segundo_control = False Then
                            .completado = True
                            .fecha_completado = Date.Now
                        End If
                        .Guardar()
                    End With

                    'Agregado por alan ->
                    Dim detalle_recurso As Entidades.Detalle_recurso = ControladoresLogica.ControladorTareas.ObtenerPorID(Me.id_detalle_recurso)
                    If detalle_recurso IsNot Nothing Then
                        detalle_recurso.fecha_fin = DateTime.Now
                        detalle_recurso.realizada = True
                        detalle_recurso.forzada = False
                        ControladoresLogica.ControladorTareas.Actualizar(detalle_recurso)
                    End If
                    '<-
                End If
                If vgNumeroControl = 4 Then
                    'Actualizar Movimiento_Control
                    With oMovimiento_voz
                        .Cargar()
                        .Modificar(Me.id_movimiento_voz)
                        .id_usuario_4 = vgCodigoUsuario
                        .control_prod_2 = True
                        .Guardar()
                    End With
                    MsgBox("Avisar a alan si salio este cartel")
                End If
                If vgNumeroControl = 5 Then
                    'Actualizar Movimiento_Control
                    With oMovimiento_voz
                        .Cargar()
                        .Modificar(Me.id_movimiento_voz)
                        .control_2 = True
                        .id_usuario_5 = vgCodigoUsuario
                        If Not (hayDisconformidad = True) Then
                            .completado = True
                            .fecha_completado = Date.Now
                        End If
                        .Guardar()
                    End With
                    MsgBox("Avisar a alan si salio este cartel")
                End If
                If vgNumeroControl = 6 Then
                    'Actualizar Movimiento_Control
                    With oMovimiento_voz
                        .Cargar()
                        .Modificar(Me.id_movimiento_voz)
                        .completado = True
                        .fecha_completado = Date.Now
                        .id_usuario_6 = vgCodigoUsuario
                        .control_corr_2 = True
                        .Guardar()
                    End With
                    MsgBox("Avisar a alan si salio este cartel")
                End If

                MessageBox.Show("Recuerde Loguearse en su próxima actividad", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Me.Close()
            Else
                posicion_tabla = odt.Rows.Count - 1
                btnVolverPresionado = True
            End If
            'Else
            '    MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Me.Close()
            'End If


            Exit Sub
        End If

        Dim strTipo_voz As String = ""
        Dim idTipoVoz As Integer = 0
        Dim idMovimientoVoz As Integer = 0
        Dim flagcorresp As Boolean

        strTipo_voz = CStr(odt.Rows(posicion_tabla).Item("nombre_tipo_voz"))
        idTipoVoz = CInt(odt.Rows(posicion_tabla).Item("id_tipo_voz"))
        idMovimientoVoz = CInt(odt.Rows(posicion_tabla).Item("id_movimiento_voz"))
        strCodigoTipo = CStr(odt.Rows(posicion_tabla).Item("codigo_tipo"))
        Me.id_tipo_voz = CInt(odt.Rows(posicion_tabla).Item("id_tipo_voz"))

        Try
            flagcorresp = CBool(odt.Rows(posicion_tabla).Item("corresponde_el_ctrl"))
        Catch ex As Exception

        End Try

        If banCorresponde = False And btnVolverPresionado = False Then
            'Pregunta si corresponde el control
            Me.completarControl(intNumeroControl, strTipo_voz, flagcorresp)
        End If


        If odt.Rows.Count = posicion_tabla Then
            Exit Sub
        End If


        'Si hay datos actualiza el formulario
        With odt.Rows(posicion_tabla)
            Me.id_cuerpo_movimiento_voz = CInt(.Item("id_cuerpo_movimiento_voz"))

            'Si es para el segundo control de producción, que no muestre los guardados
            If vgNumeroControl <> 5 Then
                Me.chkOk.Checked = CBool(.Item("ok1"))
                Me.chkNoCorresponde.Checked = CBool(.Item("nc1"))
            Else
                Me.chkOk.Checked = False
                Me.chkNoCorresponde.Checked = False
            End If
            Me.chkCorresponde1.Checked = CBool(.Item("corresponde1"))

            If vgNumeroControl = 2 Then
                If Me.chkNoCorresponde.Checked = True Then
                    chkCorresponde1.Enabled = True
                    chkCorresponde1.Visible = True
                Else
                    chkCorresponde1.Checked = True
                    chkCorresponde1.Visible = False
                    chkCorresponde1.Enabled = False
                End If
            End If

            If vgNumeroControl = 3 Then
                If Me.chkNoCorresponde.Checked = True Then
                    chkCorresponde1.Enabled = True
                    chkCorresponde1.Visible = True
                    chkCorresponde1.AutoCheck = False
                Else
                    chkCorresponde1.Checked = True
                    chkCorresponde1.Visible = False
                    chkCorresponde1.Enabled = False
                End If
            End If

            Me.chkConforme.Checked = CBool(.Item("conforme1"))
            Me.chkNoConforme.Checked = CBool(.Item("no_conforme1"))
            Me.cmbTipo1.Text = CStr(.Item("tipo1"))
            Me.txtDetalle1.Text = CStr(.Item("detalle1"))
            Me.chkCorreccion.Checked = CBool(.Item("correccion1"))
            Me.chkCorresponde2.Checked = CBool(.Item("corresponde2"))
            Me.chkConforme2.Checked = CBool(.Item("conforme2"))
            Me.chkNoConforme2.Checked = CBool(.Item("no_conforme2"))
            Me.cmbTipo2.Text = CStr(.Item("tipo2"))
            Me.txtDetalle2.Text = CStr(.Item("detalle2"))
            Me.chkCorreccion2.Checked = CBool(.Item("correccion2"))
            Me.TextBox1.Text = CStr(.Item("codigo")) & "-" & CStr(.Item("codigo_2"))
            Me.txtNombre_voz.Text = CStr(.Item("nombre_tipo_voz")) & vbCrLf & CStr(.Item("nombre_voz"))
            Me.chkCorresp.Checked = True
            Me.PictureBox1.ImageLocation = CStr(.Item("icono"))
            intNumeroRevision = CInt(.Item("numero_revision"))

        End With

        'En el primer control, setea el tamaño y posición del formulario
        If primer_inicio = True Then
            Me.FormularioSize()
            primer_inicio = False
        End If

        intRowPosicion = 0
    End Sub

    Sub completarControl(ByRef intNumeroControl As Integer, ByVal strTipo_voz As String, ByRef flag As Boolean)

        Select Case intNumeroControl

            Case 1
                If strCodigoTipo <> strCodigoTipoViejo Then

                    'Primer control, se pregunta si corresponde
                    If MessageBox.Show("¿Corresponde el control: " & strCodigoTipo & " - " & strTipo_voz & " ?", "Control",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then

                        Dim odtTempC As New DataTable
                        odtTempC = oCuerpo_movimiento_voz.GetAllMovimientoTipoVoz(Me.id_movimiento_voz, Me.id_tipo_voz)
                        Dim odtTempD As New DataTable
                        posicion_tabla = posicion_tabla + odtTempC.Rows.Count - 1

                        'A todas las filas del control que no corresponde las setea
                        For Each row As DataRow In odtTempC.Rows
                            odtTempD = oCuerpo_movimiento_voz.GetAllMovimientoGetMaxRevision(Me.id_movimiento_voz)
                            With oCuerpo_movimiento_voz
                                .Cargar()
                                .Modificar(CInt(row("Id cuerpo movimiento voz")))
                                .nc1 = True
                                .completado = True
                                .completado_pm = False
                                .control1 = True
                                .numero_revision = CDec(odtTempD.Rows(0).Item("numero revision")) + 1
                                intNumeroRevision = CInt(.numero_revision)
                                .corresponde = False
                                .Guardar()
                            End With
                        Next

                        Me.RefrescarControl()

                    End If
                    strCodigoTipoViejo = strCodigoTipo
                Else
                    Me.chkCorresp.Checked = True
                End If


            Case 2
                If strCodigoTipo <> strCodigoTipoViejo Then
                    If flag = False Then
                        If MessageBox.Show("Corresponde el control: " & strCodigoTipo & " - " & strTipo_voz & " ?", "Control",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then

                            Dim odtTempC As New DataTable
                            odtTempC = oCuerpo_movimiento_voz.GetAllMovimientoTipoVoz(Me.id_movimiento_voz, Me.id_tipo_voz)
                            Dim odtTempD As New DataTable
                            posicion_tabla = posicion_tabla + odtTempC.Rows.Count - 1

                            For Each row As DataRow In odtTempC.Rows
                                odtTempD = oCuerpo_movimiento_voz.GetAllMovimientoGetMaxRevision(Me.id_movimiento_voz)
                                With oCuerpo_movimiento_voz
                                    .Cargar()
                                    .Modificar(CInt(row("Id cuerpo movimiento voz")))
                                    .conforme1 = True
                                    .completado_pm = False
                                    If chkPedir_segundo_control.Checked = False Then
                                        .completado_pm = True
                                    End If
                                    .control2 = True
                                    .numero_revision = CDec(odtTempD.Rows(0).Item("numero revision")) + 1
                                    intNumeroRevision = CInt(.numero_revision)
                                    .Guardar()
                                End With
                            Next
                            Me.RefrescarControl()

                        End If
                    End If
                    strCodigoTipoViejo = strCodigoTipo
                End If

            Case 4
                If strCodigoTipo <> strCodigoTipoViejo Then

                    'Primer control, se pregunta si corresponde
                    If MessageBox.Show("¿Corresponde el control: " & strCodigoTipo & " - " & strTipo_voz & " ?", "Control",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then

                        Dim odtTempC As New DataTable
                        odtTempC = oCuerpo_movimiento_voz.GetAllMovimientoTipoVoz(Me.id_movimiento_voz, Me.id_tipo_voz)
                        Dim odtTempD As New DataTable
                        posicion_tabla = posicion_tabla + odtTempC.Rows.Count - 1

                        'A todas las filas del control que no corresponde las setea
                        For Each row As DataRow In odtTempC.Rows
                            odtTempD = oCuerpo_movimiento_voz.GetAllMovimientoGetMaxRevision(Me.id_movimiento_voz)
                            With oCuerpo_movimiento_voz
                                .Cargar()
                                .Modificar(CInt(row("Id cuerpo movimiento voz")))
                                .nc1 = True
                                .numero_revision = CDec(odtTempD.Rows(0).Item("numero revision")) + 1
                                intNumeroRevision = CInt(.numero_revision)
                                .corresponde = False
                                .Guardar()
                            End With
                        Next
                        Me.RefrescarControl()
                    End If
                    strCodigoTipoViejo = strCodigoTipo
                Else
                    Me.chkCorresp.Checked = True
                End If

            Case 5
                If strCodigoTipo <> strCodigoTipoViejo Then
                    If flag = False Then
                        If MessageBox.Show("Corresponde el control: " & strCodigoTipo & " - " & strTipo_voz & " ?", "Control",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then

                            Dim odtTempC As New DataTable
                            odtTempC = oCuerpo_movimiento_voz.GetAllMovimientoTipoVoz(Me.id_movimiento_voz, Me.id_tipo_voz)
                            Dim odtTempD As New DataTable
                            posicion_tabla = posicion_tabla + odtTempC.Rows.Count - 1

                            For Each row As DataRow In odtTempC.Rows
                                odtTempD = oCuerpo_movimiento_voz.GetAllMovimientoGetMaxRevision(Me.id_movimiento_voz)
                                With oCuerpo_movimiento_voz
                                    .Cargar()
                                    .Modificar(CInt(row("Id cuerpo movimiento voz")))
                                    .conforme2 = True
                                    .completado = True
                                    .completado_pm = True
                                    .control3 = True
                                    .numero_revision = CDec(odtTempD.Rows(0).Item("numero revision")) + 1
                                    intNumeroRevision = CInt(.numero_revision)
                                    .Guardar()
                                End With
                            Next
                            Me.RefrescarControl()
                        End If
                    End If
                    strCodigoTipoViejo = strCodigoTipo
                    Me.chkCorresp.Checked = False
                End If
        End Select



    End Sub

    Sub FormularioSize()

        Dim tamaño_1_panel As Integer
        Dim tamaño_2_paneles As Integer
        Dim tamaño_3_paneles As Integer
        Dim ancho_form As Integer

        tamaño_1_panel = CInt(Me.panel_cadista.Width * (1.02))
        tamaño_2_paneles = CInt((Me.panel_cadista.Width + Me.panel_control_1.Width) * (1.01))
        tamaño_3_paneles = Me.Width
        ancho_form = Me.Height ' CInt(Me.panel_cadista.Height * (1.33))

        Me.Location = New Point(0, 600)

        Select Case vgNumeroControl
            Case 1 'Control de Producción
                Me.Size = CType(New Point(tamaño_1_panel, ancho_form), Drawing.Size)
                Me.panel_control_1.Enabled = True
                Me.panel_control_2.Enabled = True
                Me.panel_cadista.Enabled = True
                Me.panel_control_1.Visible = False
                Me.panel_control_2.Visible = False
                Me.cmbTipo1.Enabled = False
                Me.cmbTipo2.Enabled = False
                Me.txtDetalle1.Enabled = False
                Me.txtDetalle2.Enabled = False
                Me.txtDetalle1.ReadOnly = False

            Case 2 'Primer control

                Me.panel_control_1.Enabled = True
                Me.panel_control_2.Enabled = False
                Me.chkPedir_segundo_control.Visible = True

                'Panel Cadista
                Me.panel_cadista.Enabled = True
                Me.chkOk.AutoCheck = False
                Me.chkNoCorresponde.AutoCheck = False
                Me.txtNombre_voz.ReadOnly = True
                Me.btnVolver.Enabled = False
                Me.btnAceptar1.Enabled = False
                Me.btnVolver.Visible = False
                Me.btnAceptar1.Visible = False

                Me.panel_control_2.Visible = False
                Me.cmbTipo2.Enabled = False
                Me.chkCorreccion.Enabled = False
                Me.chkCorreccion.Visible = False
                Me.btn_nueva_voz.Visible = True

            Case 3 'Corrección 1

                Me.panel_control_1.Enabled = True
                Me.chkNoConforme.Enabled = True
                Me.chkConforme.Enabled = True
                Me.chkNoConforme.AutoCheck = False
                Me.chkConforme.AutoCheck = False
                Me.chkCorreccion.Enabled = True
                Me.txtDetalle1.ReadOnly = True

                'Panel Cadista
                Me.panel_cadista.Enabled = True
                Me.chkOk.AutoCheck = False
                Me.chkNoCorresponde.AutoCheck = False
                Me.txtNombre_voz.ReadOnly = True
                Me.btnVolver.Enabled = False
                Me.btnAceptar1.Enabled = False
                Me.btnVolver.Enabled = False
                Me.btnAceptar1.Enabled = False
                Me.btnVolver.Visible = False
                Me.btnAceptar1.Visible = False

                Me.panel_control_2.Enabled = False
                Me.panel_control_2.Visible = False

            Case 4 '2do control en producción

                Me.panel_control_2.Enabled = False
                Me.panel_control_2.Visible = False

                Me.panel_cadista.Enabled = True
                Me.cmbTipo1.Enabled = False
                Me.cmbTipo2.Enabled = False
                Me.txtDetalle1.ReadOnly = True
                Me.txtDetalle2.ReadOnly = True
                Me.txtNombre_voz.Enabled = True
                Me.txtNombre_voz.ReadOnly = True
                Me.chkOk.Checked = False
                Me.chkNoCorresponde.Checked = False

                Me.panel_control_1.Enabled = True
                Me.txtDetalle1.ReadOnly = True
                Me.chkConforme.AutoCheck = False
                Me.chkNoConforme.AutoCheck = False
                Me.chkCorreccion.AutoCheck = False
                Me.chkPedir_segundo_control.Visible = False
                Me.btnvolver2.Visible = False
                Me.btnAceptar2.Visible = False


            Case 5 '2do control en control.Windows.Forms..

                Me.panel_control_1.Enabled = True
                Me.chkNoConforme.Enabled = True
                Me.chkConforme.Enabled = True
                Me.chkNoConforme.AutoCheck = False
                Me.chkConforme.AutoCheck = False
                Me.chkCorreccion.Enabled = True
                Me.chkCorreccion.AutoCheck = False
                Me.cmbTipo1.Enabled = False
                Me.txtDetalle1.ReadOnly = True

                Me.panel_control_2.Enabled = True
                Me.panel_control_2.Visible = True
                Me.chkCorreccion2.Enabled = False

                'Panel Cadista
                Me.panel_cadista.Enabled = True
                Me.chkOk.Enabled = False
                Me.chkNoCorresponde.Enabled = False
                Me.txtNombre_voz.ReadOnly = True
                Me.btnVolver.Enabled = False
                Me.btnAceptar1.Enabled = False


            Case 6 '2da corrección

                Me.panel_control_1.Enabled = False
                Me.panel_control_2.Enabled = True
                Me.panel_control_2.Visible = True

                Me.cmbTipo1.Enabled = False
                Me.cmbTipo2.Enabled = False
                Me.txtDetalle1.ReadOnly = True
                Me.txtDetalle2.ReadOnly = True

                Me.chkCorreccion2.Enabled = True
                Me.chkConforme2.AutoCheck = False
                Me.chkNoConforme2.AutoCheck = False
                Me.chkCorresponde2.AutoCheck = False


                Me.panel_control_1.Enabled = True
                Me.chkNoConforme.Enabled = True
                Me.chkConforme.Enabled = True
                Me.chkNoConforme.AutoCheck = False
                Me.chkConforme.AutoCheck = False
                Me.chkCorreccion.AutoCheck = False
                Me.txtDetalle1.ReadOnly = True

                'Panel Cadista
                Me.panel_cadista.Enabled = True
                Me.chkOk.AutoCheck = False
                Me.chkNoCorresponde.AutoCheck = False
                Me.txtNombre_voz.ReadOnly = True
                Me.btnVolver.Enabled = False
                Me.btnAceptar1.Enabled = False

        End Select

    End Sub


    Sub Limpiar()
        Me.chkNoCorresponde.Checked = False
        Me.chkOk.Checked = False
        Me.chkCorreccion2.Checked = False
        Me.chkNoConforme2.Checked = False
        Me.chkCorreccion.Checked = False
        Me.chkConforme2.Checked = False
        Me.chkCorresponde2.Checked = False
        Me.chkNoConforme.Checked = False
        Me.chkConforme.Checked = False
        Me.chkCorresponde1.Checked = False
        Me.TextBox1.Text = ""
        Me.txtNombre_voz.Text = ""
        Me.txtDetalle2.Text = ""
        Me.txtDetalle1.Text = ""
        Me.PictureBox1.Image = Nothing
        Me.cmbTipo2.Text = "ncm"
        Me.cmbTipo1.Text = "ncm"
        If vgNumeroControl <> 2 Then
            Me.chkPedir_segundo_control.Checked = False
        End If
        Me.chkCorresp.Checked = False
    End Sub

    Private Sub btnAceptar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar1.Click

        If Me.Guardar_produccion() Then
            Me.RefrescarControl()
        End If

    End Sub

    Private Function Guardar_produccion() As Boolean
        If Not IsNumeric(Me.id_cuerpo_movimiento_voz) Then
            Return False
            Exit Function
        End If


        If Me.chkOk.Checked = False And Me.chkNoCorresponde.Checked = False Then
            MessageBox.Show("Debe seleccionar una opción", "Seleccione una opción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Exit Function
        End If

        'Busca el mayor valor de la tabla cuerpo_movimiento_voz de ese movimiento_voz
        Dim odtTempD As New DataTable
        odtTempD = oCuerpo_movimiento_voz.GetAllMovimientoGetMaxRevision(Me.id_movimiento_voz)

        With oCuerpo_movimiento_voz
            .Cargar()
            .Modificar(CInt(Me.id_cuerpo_movimiento_voz))
            .nc1 = Me.chkNoCorresponde.Checked
            .ok1 = Me.chkOk.Checked
            .completado = True
            .completado_pm = False
            .control1 = True
            .numero_revision = CDec(odtTempD.Rows(0).Item("numero revision")) + 1
            intNumeroRevision = CInt(.numero_revision)
            .corresponde = Me.chkCorresp.Checked
            .Guardar()
        End With

        With odt.Rows(posicion_tabla)
            .Item("nc1") = Me.chkNoCorresponde.Checked
            .Item("ok1") = Me.chkOk.Checked
            .Item("completado") = True
            .Item("completado_pm") = False
            .Item("corresponde") = Me.chkCorresp.Checked

        End With

        Me.ObtenerVoces()

        Me.id_cuerpo_movimiento_voz_viejo = Me.id_cuerpo_movimiento_voz
        Return True
    End Function

    Private Sub chkNoCorresponde_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.chkNoCorresponde.Checked = True Then
            If Me.chkOk.Checked = True Then
                Me.chkOk.Checked = False
            End If
        End If
    End Sub

    Private Sub chkOk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.chkOk.Checked = True Then
            If Me.chkNoCorresponde.Checked = True Then
                Me.chkNoCorresponde.Checked = False
            End If
        End If
    End Sub

    Dim odtProyecto As New DataTable
    Dim odtActividad As New DataTable
    Dim odtActividad_proyecto As New DataTable

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Guardar_produccion()
        Me.VolverRegistroAnterior()
    End Sub

    Private Sub btnAceptar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar2.Click

        If Me.Guardar_control() Then
            btnVolverPresionado = False
            Me.RefrescarControl()
        End If
        

    End Sub

    Private Function Guardar_control() As Boolean

        If Not IsNumeric(Me.id_cuerpo_movimiento_voz) Then
            Return False
            Exit Function
        End If

        'Si el cadista indica que no corresponde el punto, y el controlador solo pone siguiente, automaticamente se tilda la opcion corresponde
        If chkCorresponde1.Checked = False And Me.chkNoCorresponde.Checked = True And Me.chkConforme.Checked = False And vgNumeroControl = 2 Then
            Me.chkConforme.Checked = True
        End If

        If vgNumeroControl = 3 And chkCorreccion.Checked = False Then
            MessageBox.Show("Debe corregir el error", "Corregir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Exit Function
        End If

        If ((Me.chkNoConforme.Checked = False And Me.chkConforme.Checked = False And chkNoCorresponde.Checked = False And vgNumeroControl = 1) Or (chkCorresponde1.Checked = True And Me.chkNoConforme.Checked = False And Me.chkConforme.Checked = False And vgNumeroControl = 2)) Then
            MessageBox.Show("Debe seleccionar una opción", "Seleccione una opción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Exit Function
        End If

        Dim odtTempD As New DataTable
        odtTempD = oCuerpo_movimiento_voz.GetAllMovimientoGetMaxRevision(Me.id_movimiento_voz)
        Dim i As Integer = Me.id_cuerpo_movimiento_voz

        With oCuerpo_movimiento_voz
            .Cargar()
            .Modificar(Me.id_cuerpo_movimiento_voz)
            .corresponde1 = Me.chkCorresponde1.Checked
            .conforme1 = Me.chkConforme.Checked
            .no_conforme1 = Me.chkNoConforme.Checked
            .detalle1 = Me.txtDetalle1.Text
            .tipo1 = Me.cmbTipo1.Text
            .correccion1 = Me.chkCorreccion.Checked
            .control2 = True

            If .conforme1 = True Then
                .completado = True
                .completado_pm = True
            ElseIf .no_conforme1 = True And .correccion1 = False Then
                .completado = False
                .completado_pm = True
            ElseIf .no_conforme1 = True And .correccion1 = True And .pedido_segundo_control = True Then
                .completado = True
                .completado_pm = False
            ElseIf .no_conforme1 = True And .correccion1 = True And .pedido_segundo_control = False Then
                .completado = True
                .completado_pm = True
            End If

            .numero_revision = CDec(odtTempD.Rows(0).Item("numero revision")) + 1
            intNumeroRevision = CInt(.numero_revision)

            .Guardar()
        End With

        With odt.Rows(posicion_tabla)
            .Item("conforme1") = Me.chkConforme.Checked
            .Item("no_conforme1") = Me.chkNoConforme.Checked
            .Item("corresponde1") = Me.chkCorresponde1.Checked
            .Item("completado_pm") = False


        End With

        If Me.chkConforme.Checked = False Then
            hayDisconformidad = True
        End If

        Me.id_cuerpo_movimiento_voz_viejo = Me.id_cuerpo_movimiento_voz

        Return True
    End Function


    Private Sub btnvolver2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvolver2.Click
        With oCuerpo_movimiento_voz
            .Cargar()
            .Modificar(Me.id_cuerpo_movimiento_voz)
            .corresponde1 = Me.chkCorresponde1.Checked
            .conforme1 = Me.chkConforme.Checked
            .no_conforme1 = Me.chkNoConforme.Checked
            .detalle1 = Me.txtDetalle1.Text
            .tipo1 = Me.cmbTipo1.Text
            .correccion1 = Me.chkCorreccion.Checked
            .control2 = True

            If .conforme1 = True Then
                .completado = True
                .completado_pm = True
            ElseIf .no_conforme1 = True And .correccion1 = False Then
                .completado = False
                .completado_pm = True
            ElseIf .no_conforme1 = True And .correccion1 = True And .pedido_segundo_control = True Then
                .completado = True
                .completado_pm = False
            ElseIf .no_conforme1 = True And .correccion1 = True And .pedido_segundo_control = False Then
                .completado = True
                .completado_pm = True
            End If

            '.numero_revision = CDec(odtTempD.Rows(0).Item("numero revision")) + 1
            'intNumeroRevision = CInt(.numero_revision)

            .Guardar()
        End With

        Me.ObtenerVoces()

        With odt.Rows(posicion_tabla)
            .Item("conforme1") = Me.chkConforme.Checked
            .Item("no_conforme1") = Me.chkNoConforme.Checked
            .Item("corresponde1") = Me.chkCorresponde1.Checked
            .Item("completado_pm") = False
        End With

        Me.VolverRegistroAnterior()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnAceptar_2doC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar_2doC.Click
       
        Me.Guardar_segundo_control()
        Me.RefrescarControl()
    End Sub

    Private Sub Guardar_segundo_control()
        If Not IsNumeric(Me.id_cuerpo_movimiento_voz) Then
            Exit Sub
        End If

        If vgNumeroControl = 6 And Me.chkCorreccion2.Checked = False Then
            MessageBox.Show("Debe corregir el error", "Corregir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If vgNumeroControl = 5 And Me.chkNoConforme2.Checked = False And Me.chkConforme2.Checked = False Then
            MessageBox.Show("Debe seleccionar una opción", "Seleccione una opción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If Me.chkConforme2.Checked = False Then
            hayDisconformidad = True
        End If

        Dim odtTempD As New DataTable
        odtTempD = oCuerpo_movimiento_voz.GetAllMovimientoGetMaxRevision(Me.id_movimiento_voz)


        With oCuerpo_movimiento_voz
            .Cargar()
            .Modificar(CInt(Me.id_cuerpo_movimiento_voz))
            .corresponde2 = Me.chkCorresponde2.Checked
            .conforme2 = Me.chkConforme2.Checked
            .no_conforme2 = Me.chkNoConforme2.Checked
            .correccion2 = Me.chkCorreccion2.Checked
            .tipo2 = Me.cmbTipo2.Text
            .detalle2 = Me.txtDetalle2.Text
            .control3 = True

            If .conforme2 = True Then
                .completado = True
                .completado_pm = True
                'si no esta conforme y no esta corregido
            ElseIf .no_conforme2 = True And .correccion2 = False Then
                .completado = False
                .completado_pm = True
            ElseIf .no_conforme2 = True And .correccion2 = True Then
                .completado = True
                .completado_pm = True
            End If

            .numero_revision = CDec(odtTempD.Rows(0).Item("numero revision")) + 1
            intNumeroRevision = CInt(.numero_revision)
            .Guardar()
        End With

        Me.ObtenerVoces()

        Me.id_cuerpo_movimiento_voz_viejo = Me.id_cuerpo_movimiento_voz
    End Sub
    'Btn Volver 2do control
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver_2doC.Click
        Me.Guardar_segundo_control()
        btnVolverPresionado = True
        Me.VolverRegistroAnterior()
    End Sub

    Private Sub chkCorresponde_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCorresponde1.CheckedChanged
        If vgNumeroControl = 2 Then
            If Me.chkCorresponde1.Checked = True Then
                Me.chkNoConforme.Enabled = True
                Me.chkConforme.Enabled = True
                Me.chkCorresponde1.ForeColor = Color.Green
            Else
                Me.chkNoConforme.Enabled = False
                Me.chkConforme.Enabled = False
                Me.chkCorresponde1.ForeColor = Color.Red
            End If
        End If
    End Sub

    Private Sub chkConforme_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkConforme.CheckedChanged
        If Me.chkConforme.Checked = True Then
            Me.chkNoConforme.Checked = False
            Me.cmbTipo1.Text = ""
        End If
    End Sub

    Private Sub chkNoConforme_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNoConforme.CheckedChanged
        If Me.chkNoConforme.Checked = True Then
            Me.chkConforme.Checked = False
            Me.txtDetalle1.Enabled = True
            Me.txtDetalle1.Focus()
        Else
            Me.txtDetalle1.Enabled = False
        End If
    End Sub

    Private Sub chkCorresponde2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCorresponde2.CheckedChanged
        If Me.chkCorresponde2.Checked = True Then
            Me.cmbTipo2.Enabled = True
            Me.cmbTipo2.Text = "ncm"
        Else
            Me.cmbTipo2.Enabled = False
            Me.cmbTipo2.Text = ""
        End If
    End Sub

    Private Sub chkConforme2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkConforme2.CheckedChanged
        If Me.chkConforme2.Checked = True Then
            Me.chkNoConforme2.Checked = False
            Me.cmbTipo2.Text = ""
        End If
    End Sub

    Private Sub chkNoConforme2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNoConforme2.CheckedChanged
        If Me.chkNoConforme2.Checked = True Then
            Me.chkConforme2.Checked = False
            Me.txtDetalle2.Enabled = True
        Else
            Me.txtDetalle2.Enabled = False
        End If
    End Sub


    Sub VolverRegistroAnterior()
        If odt.Rows.Count > 0 Then

            posicion_tabla = posicion_tabla - 1
            

            If posicion_tabla = -1 Then
                MessageBox.Show("Ha llegado al primer registro", "Primer registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                posicion_tabla = 0
            Else

                If btnVolverPresionado = False Then
                    btnVolverPresionado = True
                    posicion_tabla_ultimo = posicion_tabla
                End If

                With odt.Rows(posicion_tabla)
                    Me.id_cuerpo_movimiento_voz = CInt(.Item("id_cuerpo_movimiento_voz"))
                    Me.chkCorresponde1.Checked = CBool(.Item("corresponde1"))
                    Me.chkConforme.Checked = CBool(.Item("conforme1"))
                    Me.chkNoConforme.Checked = CBool(.Item("no_conforme1"))
                    Me.cmbTipo1.Text = CStr(.Item("tipo1"))
                    Me.txtDetalle1.Text = CStr(.Item("detalle1"))
                    Me.chkCorreccion.Checked = CBool(.Item("correccion1"))
                    Me.chkCorresponde2.Checked = CBool(.Item("corresponde2"))
                    Me.chkConforme2.Checked = CBool(.Item("conforme2"))
                    Me.chkNoConforme2.Checked = CBool(.Item("no_conforme2"))
                    Me.cmbTipo2.Text = CStr(.Item("tipo2"))
                    Me.txtDetalle2.Text = CStr(.Item("detalle2"))
                    Me.chkCorreccion2.Checked = CBool(.Item("correccion2"))
                    Me.TextBox1.Text = CStr(.Item("codigo")) & "-" & CStr(.Item("codigo_2"))
                    Me.txtNombre_voz.Text = CStr(.Item("nombre_tipo_voz")) & vbCrLf & CStr(.Item("nombre_voz"))
                    Me.chkCorresp.Checked = True
                    Me.PictureBox1.ImageLocation = CStr(.Item("icono"))

                    Me.chkOk.Checked = CBool(.Item("ok1")) 'agregado
                    intNumeroRevision = CInt(.Item("numero_revision"))
                    Me.chkNoCorresponde.Checked = CBool(.Item("nc1"))

                    strCodigoTipo = CStr(odt.Rows(posicion_tabla).Item("codigo_tipo"))
                    strCodigoTipoViejo = strCodigoTipo

                    If Me.chkNoCorresponde.Checked = True Then
                        chkCorresponde1.Enabled = True
                        chkCorresponde1.Visible = True
                    Else
                        chkCorresponde1.Checked = True                        
                        chkCorresponde1.Visible = False
                        chkCorresponde1.Enabled = False
                    End If

                End With
            End If
        End If

        
        intRowPosicion = intRowPosicion + 1
    End Sub


    Sub VolverRegistroAnteriorPrimerControl(ByVal adicion As Integer)

        If odtTempE.Rows.Count > 0 Then
            If odtTempE.Rows.Count <= intRowPosicion Then
                MessageBox.Show("Ha llegado al último registro", "Último registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

                With odtTempE.Rows(intRowPosicion - 0)
                    Me.id_cuerpo_movimiento_voz = CInt(.Item("id cuerpo movimiento voz"))
                    Me.chkNoCorresponde.Checked = CBool(.Item("nc1"))
                    Me.chkOk.Checked = CBool(.Item("ok1"))
                    Me.chkCorresponde1.Checked = CBool(.Item("corresponde1"))
                    Me.chkConforme.Checked = CBool(.Item("conforme1"))
                    Me.chkNoConforme.Checked = CBool(.Item("no conforme1"))
                    Me.cmbTipo1.Text = CStr(.Item("tipo1"))
                    Me.txtDetalle1.Text = CStr(.Item("detalle1"))
                    Me.chkCorreccion.Checked = CBool(.Item("correccion1"))
                    Me.chkCorresponde2.Checked = CBool(.Item("corresponde2"))
                    Me.chkConforme2.Checked = CBool(.Item("conforme2"))
                    Me.chkNoConforme2.Checked = CBool(.Item("no conforme2"))
                    Me.cmbTipo2.Text = CStr(.Item("tipo2"))
                    Me.txtDetalle2.Text = CStr(.Item("detalle2"))
                    Me.chkCorreccion2.Checked = CBool(.Item("correccion2"))
                    Me.TextBox1.Text = CStr(.Item("codigo")) & "-" & CStr(.Item("codigo 2"))
                    Me.txtNombre_voz.Text = CStr(.Item("nombre voz"))
                    Me.PictureBox1.ImageLocation = CStr(.Item("icono"))
                    intNumeroRevision = CInt(.Item("numero revision"))

                End With
            End If
        End If
        intRowPosicion = intRowPosicion + 1
    End Sub

    Private Sub btnVolverUltimo_Click(sender As System.Object, e As System.EventArgs)
        Me.VolverRegistroAnterior()
    End Sub

    Private Sub bntMas_Click(sender As System.Object, e As System.EventArgs) Handles bntMas.Click
        Dim intFuente As Integer = 0
        intFuente = CInt(Me.txtNombre_voz.Font.Size)

        If intFuente < 30 Then
            Me.txtNombre_voz.Font = New Font(Me.txtNombre_voz.Font.Name, intFuente + 1)
        End If
    End Sub

    Private Sub btnMenos_Click(sender As System.Object, e As System.EventArgs) Handles btnMenos.Click
        Dim intFuente As Integer = 0
        intFuente = CInt(Me.txtNombre_voz.Font.Size)
        If intFuente > 5 Then
            Me.txtNombre_voz.Font = New Font(Me.txtNombre_voz.Font.Name, intFuente - 1)
        End If
    End Sub

    Private Sub chkPedir_segundo_control_CheckedChanged(sender As Object, e As EventArgs) Handles chkPedir_segundo_control.CheckedChanged
        Try
            If Me.chkPedir_segundo_control.Checked = True Then
                Dim result As Integer = MessageBox.Show("¿Está seguro que desea solicitar un pedido de segundo control?", "Segundo Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.No Then
                    chkPedir_segundo_control.Checked = False
                    pedido_segundo_control = False
                ElseIf result = DialogResult.Yes Then
                    oMovimiento_voz.UpdatePedidoSegundoControl(Me.id_movimiento_voz, True)
                    pedido_segundo_control = True
                End If
            Else
                Dim result As Integer = MessageBox.Show("¿Está seguro que desea cancelar el pedido de segundo control?", "Cancelar segundo Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.No Then
                    chkPedir_segundo_control.Checked = True
                    pedido_segundo_control = True
                ElseIf result = DialogResult.Yes Then
                    oMovimiento_voz.UpdatePedidoSegundoControl(Me.id_movimiento_voz, False)
                    pedido_segundo_control = False
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub chkNoConformidad_CheckedChanged(sender As Object, e As EventArgs) Handles chkNoConformidad.CheckedChanged
        If Me.chkNoConformidad.Checked = True Then
            Me.cmbTipo1.Enabled = True
            Me.cmbTipo1.Text = "ncm"
        Else
            Me.cmbTipo1.Enabled = False
            Me.cmbTipo1.Text = ""
        End If
    End Sub

    Private Sub chkNoCorresponde_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkNoCorresponde.CheckedChanged
        Dim sender_check As CheckBox
        sender_check = CType(sender, CheckBox)
        If chkOk.Checked = True And chkNoCorresponde.Checked = True Then
            chkOk.Checked = False
        End If
    End Sub

    Private Sub chkOk_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkOk.CheckedChanged
        Dim sender_check As CheckBox
        sender_check = CType(sender, CheckBox)
        If chkOk.Checked = True And chkNoCorresponde.Checked = True Then
            chkNoCorresponde.Checked = False
        End If
    End Sub

    Private Sub btn_nueva_voz_Click(sender As Object, e As EventArgs) Handles btn_nueva_voz.Click
        Dim frmNuevaVoz As New frmNuevaVoz(Me.id_movimiento_voz)
        frmNuevaVoz.Show()
    End Sub
End Class