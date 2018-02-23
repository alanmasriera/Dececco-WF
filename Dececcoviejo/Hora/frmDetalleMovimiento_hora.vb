Public Class frmDetalleMovimiento_hora

    Private Sub frmDetalleMovimiento_hora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttGeneral.SetToolTip(Me.btnBuscaEmpleado, "Buscar Nuevo Empleado")
        Me.ttGeneral.SetToolTip(Me.btnBuscaObra, "Buscar Nuevo Obra")
        Me.ttGeneral.SetToolTip(Me.btnBuscaDia, "Buscar Nuevo Dia")
        Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Movimiento_hora")
        Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()

            Me.cmbempleado.Text = oEmpleado.GetOne_2(CInt(Me.lblid_empleado.Text)).Rows(0).Item("nombre_Empleado").ToString.Trim
            Me.cmbObra.Text = oObra.GetOne(CInt(Me.lblid_Obra.Text)).Rows(0).Item("nombre_Obra").ToString.Trim
            Me.cmbDia.Text = oDia.GetOne(CInt(Me.lblid_Dia.Text)).Rows(0).Item("nombre_Dia").ToString.Trim
        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try

        If BanderaMovimiento_hora = 1 Then
            Me.LimpiarControles()

            'seteo la fecha por primera vez
            Me.dtpfecha.Value = DateTime.Now

            Me.lblid_empleado.Text = CType(Me.Owner, frmAbmMovimiento_hora).lblid_usuario.Text
            Me.cmbempleado.Text = oEmpleado.GetOne_2(CInt(Me.lblid_empleado.Text)).Rows(0).Item("nombre_Empleado").ToString.Trim
            Me.dtpfecha.Value = CType(Me.Owner, frmAbmMovimiento_hora).dtpInicio.Value.Date
        End If
        Me.Text = "Movimiento_hora"
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False
    End Sub

    Sub CargarCombos()
        ' Me.CargarEmpleado
        Me.CargarObra()
        Me.CargarDia()
    End Sub

    'Sub CargarEmpleado()
    '    Dim odt As New DataTable

    '     odt = oEmpleado.GetCmb_2
    '    With Me.cmbEmpleado
    '        .DataSource = odt
    '        .DisplayMember = "nombre_empleado"
    '        .ValueMember = "id_empleado"
    '    End With
    '    If Me.cmbEmpleado.SelectedIndex >= 0 Then
    '        cmbEmpleado.SelectedIndex = 0
    '        Me.lblid_Empleado.Text = cmbEmpleado.SelectedValue.ToString
    '    End If
    'End Sub

    Sub CargarObra()
        Dim odt As New DataTable

        odt = oObra.GetCmb_2
        With Me.cmbObra
            .DataSource = odt
            .DisplayMember = "nombre_obra"
            .ValueMember = "id_obra"
        End With
        If Me.cmbObra.SelectedIndex >= 0 Then
            cmbObra.SelectedIndex = 0
            Me.lblid_Obra.Text = cmbObra.SelectedValue.ToString
        End If
    End Sub

    Sub CargarDia()
        Dim odt As New DataTable

        odt = oDia.GetCmb_2
        With Me.cmbDia
            .DataSource = odt
            .DisplayMember = "nombre_dia"
            .ValueMember = "id_dia"
        End With
        If Me.cmbDia.SelectedIndex >= 0 Then
            cmbDia.SelectedIndex = 0
            Me.lblid_Dia.Text = cmbDia.SelectedValue.ToString
        End If
    End Sub

    Sub LimpiarControles()
        Me.dtpfecha.Value = DateAdd(DateInterval.Day, 1, Me.dtpfecha.Value)
        '   Me.lblid_empleado.Text = "0"
        '    Me.cmbEmpleado.Text =  ""
        Me.lblid_obra.Text = "0"
        Me.cmbObra.Text = ""
        Me.lblid_dia.Text = "0"
        Me.cmbdia.Text = ""

        Me.dtpentrada.Value = CDate(String.Concat(CStr(Me.dtpfecha.Value.Date), " 07:30:00"))
        Me.dtpsalida.Value = CDate(String.Concat(CStr(Me.dtpfecha.Value.Date), " 16:30:00"))

        Me.Label1.Visible = False
        Me.Label2.Visible = False
        Me.txtHora1.Visible = False
        Me.txtHora2.Visible = False
    End Sub

    Private Sub ObtenerDatos()
        Me.dtpfecha.Value = oMovimiento_hora.fecha
        Me.lblid_empleado.Text = oMovimiento_hora.id_empleado.ToString
        '   Me.lblid_obra.Text = oMovimiento_hora.id_obra.ToString
        Me.lblid_dia.Text = oMovimiento_hora.id_dia.ToString
        '   Me.dtpentrada.Value = oMovimiento_hora.entrada
        '   Me.dtpsalida.Value = oMovimiento_hora.salida
    End Sub

    Private Sub AsignarDatos()
        oMovimiento_hora.fecha = Me.dtpfecha.Value.Date
        oMovimiento_hora.id_empleado = CInt(Me.lblid_empleado.Text)
        '   oMovimiento_hora.id_obra = CInt(Me.lblid_obra.Text)
        oMovimiento_hora.id_dia = CInt(Me.lblid_dia.Text)
        '   oMovimiento_hora.entrada = Me.dtpentrada.Value
        '   oMovimiento_hora.salida = Me.dtpsalida.Value
    End Sub

    Public Sub SoloLectura()
        Me.dtpfecha.Enabled = False
        Me.cmbEmpleado.Enabled = False
        Me.btnBuscaEmpleado.Enabled = False
        Me.cmbObra.Enabled = False
        Me.btnBuscaObra.Enabled = False
        Me.cmbDia.Enabled = False
        Me.btnBuscaDia.Enabled = False
        Me.dtpentrada.Enabled = False
        Me.dtpsalida.Enabled = False
        Me.btnGuardar.Visible = False
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            If oMovimiento_hora.Exist() Then
                If BanderaMovimiento_hora = 1 Then
                    MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
                    Exit Sub
                ElseIf BanderaMovimiento_hora = 2 Then
                    If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                        = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            Select Case BanderaMovimiento_hora
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oMovimiento_hora.Guardar()
                    CType(Me.Owner, frmAbmMovimiento_hora).RefrescarGrilla()
                    Me.CargarCombos()
                    oMovimiento_hora.Insertar()
                    ' Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.dtpfecha.Focus()
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oMovimiento_hora.Guardar()
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If Me.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean

        If CDbl(Me.lblid_empleado.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de empleado")
            Exit Sub
        End If
        If CDbl(Me.lblid_obra.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de obra")
            Exit Sub
        End If
        If CDbl(Me.lblid_dia.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de dia")
            Exit Sub
        End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaMovimiento_hora = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    'Private Sub cmbEmpleado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEmpleado.SelectedIndexChanged
    '    If Me.cmbEmpleado.SelectedIndex >= 0 Then
    '        Me.lblid_empleado.Text = cmbEmpleado.SelectedValue.ToString
    '    End If
    'End Sub

    'Private Sub btnBuscaEmpleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaEmpleado.Click
    '    Dim frmTemporal As New FrmAbmEmpleado
    '    frmTemporal.ShowDialog()
    '    Me.CargarEmpleado()
    '    Me.cmbEmpleado.Focus()
    '    Me.cmbEmpleado.Text = ""
    '    Me.lblid_Empleado.Text = "0"
    'End Sub

    Private Sub cmbObra_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbObra.SelectedIndexChanged
        If Me.cmbObra.SelectedIndex >= 0 Then
            Me.lblid_obra.Text = cmbObra.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaObra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaObra.Click
        Dim frmTemporal As New FrmAbmObra
        frmTemporal.ShowDialog()
        Me.CargarObra()
        Me.cmbObra.Focus()
        Me.cmbObra.Text = ""
        Me.lblid_Obra.Text = "0"
    End Sub

    Private Sub cmbDia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDia.SelectedIndexChanged
        If Me.cmbDia.SelectedIndex >= 0 Then
            Me.lblid_dia.Text = cmbDia.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaDia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaDia.Click
        Dim frmTemporal As New FrmAbmDia
        frmTemporal.ShowDialog()
        Me.CargarDia()
        Me.cmbDia.Focus()
        Me.cmbDia.Text = ""
        Me.lblid_Dia.Text = "0"
    End Sub

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    'Handles 
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles dtpfecha.KeyDown, cmbEmpleado.KeyDown, cmbObra.KeyDown, cmbDia.KeyDown, dtpentrada.KeyDown, dtpsalida.KeyDown
        If CDbl(e.KeyValue.ToString) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    'Handles 
        Dim txtTemp As TextBox
        txtTemp = CType(sender, TextBox)

        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Then
            If InStr(txtTemp.Text, ",") <> 0 Then
                e.Handled = True
            Else
                e.KeyChar = CChar(",")
            End If
        End If

        Dim Largo As Integer = InStr(txtTemp.Text, ",")

        If txtTemp.Text.Length > Largo + 2 And Largo <> 0 And e.KeyChar.ToString <> vbBack Then
            e.Handled = True
        End If

        If (e.KeyChar.ToString >= "0" And e.KeyChar.ToString <= "9") Or e.KeyChar.ToString = "," Or e.KeyChar = vbBack Then
            '  e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnControl.Click
        Dim decTotal As Decimal = 0
        Dim decMinuto As Decimal = 0
        Dim decNormal As Decimal = 0
        Dim decExtra As Decimal = 0

        'calcula la cantidad de horas trabajadas
        decMinuto = DateDiff(DateInterval.Minute, Me.dtpentrada.Value, Me.dtpsalida.Value)
        decTotal = CDec(FormatNumber(decMinuto / 60, 1))

        Select Case Me.lblid_dia.Text
            'lunes a jueves
            Case "1"
                If decTotal > 9 Then
                    decExtra = decTotal - 9
                    Me.txtHora1.Text = "9"
                    Me.txtHora2.Text = CStr(decExtra)
                    Me.Label1.Text = "Normales"
                    Me.Label2.Text = "Extras"

                    Me.txtHora1.Visible = True
                    Me.Label1.Visible = True
                    Me.txtHora2.Visible = True
                    Me.Label2.Visible = True
                Else
                    Me.txtHora1.Text = CStr(decTotal)
                    Me.Label1.Text = "Normales"

                    Me.txtHora1.Visible = True
                    Me.Label1.Visible = True
                    Me.txtHora2.Visible = False
                    Me.Label2.Visible = False
                End If
                'viernes
            Case "2"
                If decTotal > 8 Then
                    decExtra = decTotal - 8
                    Me.txtHora1.Text = "8"
                    Me.txtHora2.Text = CStr(decExtra)
                    Me.Label1.Text = "Normales"
                    Me.Label2.Text = "Extras"

                    Me.txtHora1.Visible = True
                    Me.Label1.Visible = True
                    Me.txtHora2.Visible = True
                    Me.Label2.Visible = True
                Else
                    Me.txtHora1.Text = CStr(decTotal)
                    Me.Label1.Text = "Normales"

                    Me.txtHora1.Visible = True
                    Me.Label1.Visible = True
                    Me.txtHora2.Visible = False
                    Me.Label2.Visible = False
                End If
                'nocturna
            Case "3"
                If decTotal > 9 Then
                    decExtra = decTotal - 9
                    Me.txtHora1.Text = "9"
                    Me.txtHora2.Text = CStr(decExtra)
                    Me.Label1.Text = "Normales"
                    Me.Label2.Text = "Extras"

                    Me.txtHora1.Visible = True
                    Me.Label1.Visible = True
                    Me.txtHora2.Visible = True
                    Me.Label2.Visible = True
                Else
                    Me.txtHora1.Text = CStr(decTotal)
                    Me.Label1.Text = "Normales"

                    Me.txtHora1.Visible = True
                    Me.Label1.Visible = True
                    Me.txtHora2.Visible = False
                    Me.Label2.Visible = False
                End If
                'sabados
            Case "4"
                If decTotal > CDec(5.5) Then
                    decExtra = CDec(decTotal - 5.5)
                    Me.txtHora1.Text = "5,5"
                    Me.txtHora2.Text = CStr(decExtra)
                    Me.Label1.Text = "al 50%"
                    Me.Label2.Text = "al 100%"

                    Me.txtHora1.Visible = True
                    Me.Label1.Visible = True
                    Me.txtHora2.Visible = True
                    Me.Label2.Visible = True
                Else
                    Me.txtHora1.Text = CStr(decTotal)
                    Me.Label1.Text = "al 50%"

                    Me.txtHora1.Visible = True
                    Me.Label1.Visible = True
                    Me.txtHora2.Visible = False
                    Me.Label2.Visible = False
                End If
                'domingos
            Case "5"
                Me.txtHora1.Text = CStr(decTotal)
                Me.Label1.Text = "al 100%"

                Me.txtHora1.Visible = True
                Me.Label1.Visible = True
                Me.txtHora2.Visible = False
                Me.Label2.Visible = False
                'enfermedad
            Case "6"
                Me.txtHora1.Text = "8"
                Me.Label1.Text = "enfermedad"

                Me.txtHora1.Visible = True
                Me.Label1.Visible = True
                Me.txtHora2.Visible = False
                Me.Label2.Visible = False
                'accidente
            Case "7"
                Me.txtHora1.Text = "8"
                Me.Label1.Text = "accidente"

                Me.txtHora1.Visible = True
                Me.Label1.Visible = True
                Me.txtHora2.Visible = False
                Me.Label2.Visible = False
                'viajes
            Case "8"

                'feriado trabajado
            Case "9"


                'feriado
            Case "10"
                Me.txtHora1.Text = "8"
                Me.Label1.Text = "feriado"

                Me.txtHora1.Visible = True
                Me.Label1.Visible = True
                Me.txtHora2.Visible = False
                Me.Label2.Visible = False
                'especial
            Case "11"
                Me.txtHora1.Text = "8"
                Me.Label1.Text = "especial"

                Me.txtHora1.Visible = True
                Me.Label1.Visible = True
                Me.txtHora2.Visible = False
                Me.Label2.Visible = False
        End Select

        Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
    End Sub


    Private Sub dtpfecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpfecha.ValueChanged
        Me.dtpentrada.Value = Me.dtpfecha.Value.Date
        Me.dtpsalida.Value = Me.dtpfecha.Value.Date
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim strFecha1 As String = ""
        Dim strFecha2 As String = ""

        strFecha1 = Me.dtpfecha.Value.Date & " 07:30"
        strFecha2 = Me.dtpfecha.Value.Date & " 16:30"

        Me.dtpentrada.Value = CDate(strFecha1)
        Me.dtpsalida.Value = CDate(strFecha2)

        Me.btnControl.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim strFecha1 As String = ""

        strFecha1 = Me.dtpfecha.Value.Date & " 15:00"

        Me.dtpentrada.Value = CDate(strFecha1)
        Me.dtpsalida.Value = DateAdd(DateInterval.Day, 1, Me.dtpfecha.Value.Date)

        Me.btnControl.Focus()
    End Sub

End Class
