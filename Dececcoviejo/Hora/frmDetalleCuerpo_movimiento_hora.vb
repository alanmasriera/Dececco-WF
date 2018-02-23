Public Class frmDetalleCuerpo_movimiento_hora

   Private Sub frmDetalleCuerpo_movimiento_hora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttGeneral.SetToolTip(Me.btnBuscaActividad_proyecto, "Buscar Nuevo Actividad_proyecto")
        Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Cuerpo_movimiento_hora")
        Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()

            Me.cmbActividad_proyecto.Text = oActividad_proyecto.GetOne_2(CInt(Me.lblid_Actividad_proyecto.Text)).Rows(0).Item("nombre_Actividad_proyecto").ToString.Trim
        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try

        Me.lblid_movimiento_hora.Text = CType(Me.Owner, frmDetalleMovimiento_hora_2).lblid_Movimiento_hora.Text

        If BanderaCuerpo_movimiento_hora = 1 Then
            Me.LimpiarControles()
        End If
        Me.Text = "Cuerpo_movimiento_hora"
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False
    End Sub

    Sub CargarCombos()
        Me.CargarActividad_proyecto()
    End Sub

    Sub CargarActividad_proyecto()
        Dim odt As New DataTable

        odt = oActividad_proyecto.GetCmb_2
        With Me.cmbActividad_proyecto
            .DataSource = odt
            .DisplayMember = "nombre_Actividad_proyecto"
            .ValueMember = "id_Actividad_proyecto"
        End With
        If Me.cmbActividad_proyecto.SelectedIndex >= 0 Then
            cmbActividad_proyecto.SelectedIndex = 0
            Me.lblid_actividad_proyecto.Text = cmbActividad_proyecto.SelectedValue.ToString
        End If
    End Sub

    Sub LimpiarControles()
        Me.lblid_actividad_proyecto.Text = "0"
        Me.cmbActividad_proyecto.Text = ""
        Me.dtpentrada.Value = DateTime.Now
        Me.dtpsalida.Value = DateTime.Now
        'Me.lblid_movimiento_hora.Text = "0"
        'Me.cmbID_Movimiento_hora.Text =  ""
    End Sub

    Private Sub ObtenerDatos()
        Me.lblid_actividad_proyecto.Text = oCuerpo_movimiento_hora.id_Actividad_proyecto.ToString
        Me.dtpentrada.Value = oCuerpo_movimiento_hora.entrada
        Me.dtpsalida.Value = oCuerpo_movimiento_hora.salida
        'Me.lblid_movimiento_hora.Text = oCuerpo_movimiento_hora.id_movimiento_hora.ToString
    End Sub

    Private Sub AsignarDatos()
        oCuerpo_movimiento_hora.id_Actividad_proyecto = CInt(Me.lblid_Actividad_proyecto.Text)
        oCuerpo_movimiento_hora.entrada = Me.dtpentrada.Value
        oCuerpo_movimiento_hora.salida = Me.dtpsalida.Value
        oCuerpo_movimiento_hora.id_movimiento_hora = CInt(Me.lblid_movimiento_hora.Text)
    End Sub

    Public Sub SoloLectura()
        Me.cmbActividad_proyecto.Enabled = False
        Me.btnBuscaActividad_proyecto.Enabled = False
        Me.dtpentrada.Enabled = False
        Me.dtpsalida.Enabled = False
        'Me.cmbMovimiento_hora.Enabled = False
        'Me.btnBuscaMovimiento_hora.Enabled = False
        Me.btnGuardar.Visible = False
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            If oCuerpo_movimiento_hora.Exist() Then
                If BanderaCuerpo_movimiento_hora = 1 Then
                    MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
                    Exit Sub
                ElseIf BanderaCuerpo_movimiento_hora = 2 Then
                    If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                        = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            Select Case BanderaCuerpo_movimiento_hora
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oCuerpo_movimiento_hora.Guardar()
                    CType(Me.Owner, frmDetalleMovimiento_hora_2).RefrescarGrilla()
                    Me.CargarCombos()
                    oCuerpo_movimiento_hora.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.cmbActividad_proyecto.Focus()
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oCuerpo_movimiento_hora.Guardar()
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

        If CDbl(Me.lblid_actividad_proyecto.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de Actividad_proyecto")
            Exit Sub
        End If
        'If CDbl(Me.lblid_movimiento_hora.Text) = 0 Then
        'MessageBox.Show("Debe Seleccionar un Dato del Combo de movimiento_hora")
        'Exit Sub
        'End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaCuerpo_movimiento_hora = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cmbActividad_proyecto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbActividad_proyecto.SelectedIndexChanged
        If Me.cmbActividad_proyecto.SelectedIndex >= 0 Then
            Me.lblid_actividad_proyecto.Text = cmbActividad_proyecto.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaActividad_proyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaActividad_proyecto.Click
        'Dim frmTemporal As New frmMainProyecto
        'frmTemporal.ShowDialog()
        Me.CargarActividad_proyecto()
        Me.cmbActividad_proyecto.Focus()
        Me.cmbActividad_proyecto.Text = ""
        Me.lblid_actividad_proyecto.Text = "0"
    End Sub

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    'Handles 
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles cmbActividad_proyecto.KeyDown, dtpentrada.KeyDown, dtpsalida.KeyDown
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

    Private Sub dtpsalida_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpsalida.ValueChanged
        'Dim intDif As Integer = 0
        'intDif = Me.dtpsalida.Value.TimeOfDay.CompareTo(Me.dtpentrada.Value.TimeOfDay)

        'If intDif < 0 Then
        '    Me.dtpsalida.Value = CDate(DateAdd(DateInterval.Day, 1, Me.dtpfecha.Value.Date) & " " & Me.dtpsalida.Value.Hour & ":" & Me.dtpsalida.Value.Minute)
        'Else
        '    Me.dtpsalida.Value = CDate(Me.dtpfecha.Value.Date & " " & Me.dtpsalida.Value.Hour & ":" & Me.dtpsalida.Value.Minute)
        'End If
    End Sub

End Class
