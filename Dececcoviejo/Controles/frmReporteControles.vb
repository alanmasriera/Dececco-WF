Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.IO

Public Class frmReporteControles
    Dim report_document As New ReportClass

    Private Sub frmReporteControles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGrillas()
    End Sub

    Private Sub btn_obtener_reporte_Click(sender As Object, e As EventArgs) Handles btn_obtener_reporte.Click
        actualizarInforme()
    End Sub


    Private Sub actualizarInforme()

        If rb_cadistas.Checked Then
            report_document = New reporteControles___Cadistas()
        ElseIf rb_controles.Checked Then
            report_document = New reporteControles___Controles()
        ElseIf rb_empresa.Checked Then
            report_document = New reporteControles___Empresa()
        ElseIf rb_proyectos.Checked Then
            report_document = New reporteControles___Proyectos()
        ElseIf rb_voces.Checked Then
            report_document = New reporteControles___Voz()
        ElseIf rb_clientes.Checked Then
            report_document = New reporteControles___Clientes()
        ElseIf rb_actividad.Checked Then
            report_document = New reporteControles___Actividad()
        End If

        obtenerConParametros()
        
    End Sub

    Private Sub obtenerConParametros()

        Dim paramField As ParameterField = New ParameterField()
        Dim paramFields As ParameterFields = New ParameterFields()
        Dim paramDiscreteValue As ParameterDiscreteValue = New ParameterDiscreteValue()


        'Proyecto
        paramField = New ParameterField()
        paramField.Name = "@id_proyecto"
        If cmb_proyecto.SelectedIndex = -1 Then
            paramDiscreteValue.Value = 0
        Else
            paramDiscreteValue.Value = cmb_proyecto.SelectedValue
        End If

        paramField.CurrentValues.Add(paramDiscreteValue)
        paramFields.Add(paramField)


        'Proyecto
        paramField = New ParameterField()
        paramDiscreteValue = New ParameterDiscreteValue()
        paramField.Name = "@id_control"
        ' If cmb_control.SelectedIndex = -1 Then
        'paramDiscreteValue.Value = 0
        'Else
        paramDiscreteValue.Value = cmb_control.SelectedValue
        ' End If

        paramField.CurrentValues.Add(paramDiscreteValue)
        paramFields.Add(paramField)

        'Proyecto
        paramField = New ParameterField()
        paramDiscreteValue = New ParameterDiscreteValue()
        paramField.Name = "@voz"
        If String.IsNullOrEmpty(txt_voz.Text) Then
            paramDiscreteValue.Value = Nothing
        Else
            paramDiscreteValue.Value = txt_voz.Text
        End If

        paramField.CurrentValues.Add(paramDiscreteValue)
        paramFields.Add(paramField)

        'Proyecto
        paramField = New ParameterField()
        paramDiscreteValue = New ParameterDiscreteValue()
        paramField.Name = "@id_cliente"
        If cmb_cliente.SelectedIndex = -1 Then
            paramDiscreteValue.Value = 0
        Else
            paramDiscreteValue.Value = cmb_cliente.SelectedValue
        End If

        paramField.CurrentValues.Add(paramDiscreteValue)
        paramFields.Add(paramField)

        'Proyecto
        paramField = New ParameterField()
        paramDiscreteValue = New ParameterDiscreteValue()
        paramField.Name = "@id_usuario"
        'If cmb_cliente.SelectedIndex = -1 Then
        'paramDiscreteValue.Value = 0
        'Else
        paramDiscreteValue.Value = cmb_usuarios.SelectedValue
        'End If

        paramField.CurrentValues.Add(paramDiscreteValue)
        paramFields.Add(paramField)

        'Proyecto
        paramDiscreteValue = New ParameterDiscreteValue()
        paramField = New ParameterField()
        paramField.Name = "@fecha_desde"
        'If dtp_fecha_desde.Value Then
        'paramDiscreteValue.Value = String.Empty
        'Else
        paramDiscreteValue.Value = dtp_fecha_desde.Value
        'End If

        paramField.CurrentValues.Add(paramDiscreteValue)
        paramFields.Add(paramField)

        'Proyecto
        paramField = New ParameterField()
        paramDiscreteValue = New ParameterDiscreteValue()
        paramField.Name = "@fecha_hasta"
        ' If dtp_fecha_desde.Value0 Then
        'paramDiscreteValue.Value = String.Empty
        'Else
        paramDiscreteValue.Value = dtp_fecha_hasta.Value
        'End If

        paramField.CurrentValues.Add(paramDiscreteValue)
        paramFields.Add(paramField)


        'Proyecto
        paramField = New ParameterField()
        paramDiscreteValue = New ParameterDiscreteValue()
        paramField.Name = "@param_proyecto"
        paramDiscreteValue.Value = chk_proyecto.Checked
        paramField.CurrentValues.Add(paramDiscreteValue)
        paramFields.Add(paramField)


        'Proyecto
        paramField = New ParameterField()
        paramDiscreteValue = New ParameterDiscreteValue()
        paramField.Name = "@param_control"
        paramDiscreteValue.Value = chk_control.Checked
        paramField.CurrentValues.Add(paramDiscreteValue)
        paramFields.Add(paramField)


        'Proyecto
        paramField = New ParameterField()
        paramDiscreteValue = New ParameterDiscreteValue()
        paramField.Name = "@param_voz"
        paramDiscreteValue.Value = chk_voz.Checked
        paramField.CurrentValues.Add(paramDiscreteValue)
        paramFields.Add(paramField)

        'Proyecto
        paramField = New ParameterField()
        paramDiscreteValue = New ParameterDiscreteValue()
        paramField.Name = "@param_cadista"
        paramDiscreteValue.Value = chk_cadista.Checked
        paramField.CurrentValues.Add(paramDiscreteValue)
        paramFields.Add(paramField)

        'Proyecto
        paramField = New ParameterField()
        paramDiscreteValue = New ParameterDiscreteValue()
        paramField.Name = "@param_cliente"
        paramDiscreteValue.Value = chk_clientes.Checked
        paramField.CurrentValues.Add(paramDiscreteValue)
        paramFields.Add(paramField)

        If rb_empresa.Checked Then

            report_document.SetParameterValue("@param_year", chk_anio.Checked, "PorFecha")
            report_document.SetParameterValue("@param_month", chk_mes.Checked, "PorFecha")
            report_document.SetParameterValue("@fecha_desde", dtp_fecha_desde.Value, "PorFecha")
            report_document.SetParameterValue("@fecha_hasta", dtp_fecha_hasta.Value, "PorFecha")

        End If

        

        CrystalReportViewer1.ParameterFieldInfo = paramFields
        report_document.SetDatabaseLogon("sa", "esteban")
        CrystalReportViewer1.ReportSource = report_document
    End Sub

    Private Sub obtenerConParametrosEmpresa(ByRef paramFields As ParameterFields)

        Dim paramField As ParameterField = New ParameterField()
        Dim paramDiscreteValue As ParameterDiscreteValue = New ParameterDiscreteValue()


    End Sub


    Private Sub rb_empresa_CheckedChanged(sender As Object, e As EventArgs) Handles rb_voces.CheckedChanged, rb_proyectos.CheckedChanged, rb_empresa.CheckedChanged, rb_controles.CheckedChanged, rb_cadistas.CheckedChanged, rb_actividad.CheckedChanged, rb_clientes.CheckedChanged
        Dim report_document As New ReportClass
        If CType(sender, RadioButton).Checked = True Then
            actualizarInforme()

            If CType(sender, RadioButton).Name = rb_empresa.Name Then
                grp_fechas.Visible = True
            Else
                grp_fechas.Visible = False
            End If
        End If

    End Sub

    Private Sub cargarGrillas()

        dtp_fecha_desde.Value = DateAdd(DateInterval.Year, -15, Date.Now)

        Dim dt As DataTable
        dt = oControl.ConsultarTodo()
        dt.Rows.Add(0, " - Todos - ")

        cmb_control.DataSource = dt
        cmb_control.ValueMember = "id control"
        cmb_control.DisplayMember = "nombre control"
        cmb_control.SelectedValue = 0

        dt = oCliente.ConsultarTodo()
        dt.Rows.Add(0, " - Todos - ")
        cmb_cliente.DataSource = dt
        cmb_cliente.ValueMember = "Id_cliente"
        cmb_cliente.DisplayMember = "Nombre_cliente"
        cmb_cliente.SelectedValue = 0

        dt = oUsuario.ConsultarNombreCompleto()
        dt.Rows.Add(0, " - Todos - ")
        cmb_usuarios.DataSource = dt
        cmb_usuarios.ValueMember = "Id_usuario"
        cmb_usuarios.DisplayMember = "Nombre_completo"
        cmb_usuarios.SelectedValue = 0

        dt = oProyecto.ObtenerProyectos(0)
        dt.Rows.Add(0, "", " - Todos - ")
        cmb_proyecto.DataSource = dt
        cmb_proyecto.ValueMember = "Id_proyecto"
        cmb_proyecto.DisplayMember = "Nombre_proyecto"
        cmb_proyecto.SelectedValue = 0


    End Sub


    Private Sub cmb_cliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_cliente.SelectedIndexChanged
        If cmb_cliente.SelectedIndex <> 0 Then
            Dim dt As DataTable
            dt = oProyecto.ObtenerProyectos(CInt(cmb_cliente.SelectedValue))
            dt.Rows.Add(0, "", " - Todos - ")
            cmb_proyecto.DataSource = dt
            cmb_proyecto.ValueMember = "Id_proyecto"
            cmb_proyecto.DisplayMember = "Nombre_proyecto"
            cmb_proyecto.SelectedValue = 0
        End If
    End Sub

End Class