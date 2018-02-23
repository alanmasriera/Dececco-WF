Public Class frmDetalleAsignacion_iva

    Private Sub frmDetalleAsignacion_iva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttGuardar.SetToolTip(Me.btnGuardar, "Guardar Datos del Asignacion_iva")
        Me.ttSalir.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()

            '  Me.cmbEmpresa.Text = oEmpresa.GetOne(Me.lblid_Empresa.Text).Rows(0).Item("nombre_Empresa").ToString.Trim
            '  Me.cmbiva.Text = oiva.GetOne(Me.lblid_iva.Text).Rows(0).Item("nombre_iva").ToString.Trim
        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try

        If BanderaAsignacion_iva = 1 Then
            Me.LimpiarControles()
        End If
        Me.Text = "Asignacion_iva" & vgNombreFormulario
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False

        Me.lblid_empresa.Text = CType(Me.Owner, frmAbmGestion_iva).lblid_empresa.Text
        Me.lblid_iva.Text = CType(Me.Owner, frmAbmGestion_iva).lblid_iva.Text
    End Sub

    Sub CargarCombos()
        '   Me.CargarEmpresa()
        '   Me.Cargariva()
    End Sub

    Sub LimpiarControles()
        Me.txtSueldo_iva.Text = ""
        Me.dtpFecha_asignacion_iva.Value = DateTime.Now
        Me.txtdetalle_asignacion_iva.Text = ""
    End Sub

    Private Sub ObtenerDatos()
        '  Me.lblid_empresa.Text = CStr(oAsignacion_iva.id_empresa)
        '  Me.lblid_iva.Text = CStr(oAsignacion_iva.id_Iva)
        Me.txtsueldo_iva.Text = oAsignacion_iva.sueldo_iva.ToString.Trim
        Me.dtpFecha_asignacion_iva.Value = oAsignacion_iva.fecha_asignacion_iva
        Me.txtdetalle_asignacion_iva.Text = oAsignacion_iva.detalle_asignacion_iva.Trim
    End Sub

    Private Sub AsignarDatos()
        oAsignacion_iva.id_empresa = CInt(Me.lblid_empresa.Text)
        oAsignacion_iva.id_Iva = CInt(Me.lblid_iva.Text)
        oAsignacion_iva.sueldo_Iva = CDec(Me.txtSueldo_iva.Text)
        oAsignacion_iva.fecha_asignacion_iva = Me.dtpFecha_asignacion_iva.Value.Date
        oAsignacion_iva.detalle_asignacion_iva = Me.txtDetalle_asignacion_iva.Text.Trim
    End Sub

    Public Sub SoloLectura()
        Me.txtSueldo_iva.Enabled = False
        Me.dtpFecha_asignacion_iva.Enabled = False
        Me.txtdetalle_asignacion_iva.Enabled = False
        Me.btnGuardar.Visible = False
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            Select Case BanderaAsignacion_iva
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oAsignacion_iva.Guardar()
                    CType(Me.Owner, frmAbmGestion_iva).RefrescarGrillaAsignacion()
                    Me.CargarCombos()
                    oAsignacion_iva.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.dtpFecha_asignacion_iva.Focus()
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oAsignacion_iva.Guardar()
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If Me.txtsueldo_iva.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean

        If CDbl(Me.lblid_empresa.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de empresa")
            Exit Sub
        End If
        If CDbl(Me.lblid_iva.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de iva")
            Exit Sub
        End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaAsignacion_iva = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub



    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtDetalle_asignacion_iva.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles dtpFecha_asignacion_iva.KeyDown
        If CDbl(e.KeyValue.ToString) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtSueldo_iva.KeyPress
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

End Class