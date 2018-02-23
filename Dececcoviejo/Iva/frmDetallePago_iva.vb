Public Class frmDetallePago_iva

    Private Sub frmDetallePago_iva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttGuardar.SetToolTip(Me.btnGuardar, "Guardar Datos del Pago_iva")
        Me.ttSalir.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()

        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try

        If BanderaPago_iva = 1 Then
            Me.LimpiarControles()
        End If
        Me.lblid_empresa.Text = CType(Me.Owner, frmAbmGestion_iva).lblid_empresa.Text
        Me.lblid_iva.Text = CType(Me.Owner, frmAbmGestion_iva).lblid_iva.Text

        Me.Text = "Pago_iva" & vgNombreFormulario
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False
    End Sub

    Sub CargarCombos()
        '  Me.CargarProveedor()
    End Sub

    Sub LimpiarControles()
        Me.dtpFecha_Pago_iva.Value = DateTime.Now
        Me.txtPago_iva.Text = ""
        Me.txtNumero_recibo_pago_iva.Text = "0000"
        Me.txtNumero_recibo_pago_iva2.Text = "00000001"
        Me.txtNumero_cheque_iva.Text = ""
        Me.dtpFecha_emision_cheque_iva.Value = DateTime.Now
        Me.dtpFecha_pago_cheque_iva.Value = DateTime.Now
        Me.txtDetalle_cheque_iva.Text = ""
        Me.txtdetalle_pago.Text = ""
    End Sub

    Private Sub ObtenerDatos()
        Me.dtpfecha_Pago_iva.Value = oPago_iva.fecha_Pago_iva
        Me.txtPago_iva.Text = oPago_iva.Pago_iva.ToString.Trim
        If oPago_iva.numero_recibo_Pago_iva.Length <> 12 Then
            Exit Sub
        Else
            Me.txtNumero_recibo_Pago_iva.Text = oPago_iva.numero_recibo_Pago_iva.Substring(0, 4)
            Me.txtNumero_recibo_Pago_iva2.Text = oPago_iva.numero_recibo_Pago_iva.Substring(4, 8)
        End If

        ' Me.lblid_proveedor.Text = oPago_iva.id_proveedor
        Me.chkEfectivo_iva.Checked = oPago_iva.efectivo_iva
        Me.txtNumero_cheque_iva.Text = oPago_iva.numero_cheque_iva.Trim
        Me.dtpFecha_emision_cheque_iva.Value = oPago_iva.fecha_emision_cheque_iva
        Me.dtpFecha_pago_cheque_iva.Value = oPago_iva.fecha_pago_cheque_iva
        Me.txtDetalle_cheque_iva.Text = oPago_iva.detalle_cheque_iva.Trim
        Me.txtdetalle_pago.Text = oPago_iva.detalle_pago.Trim
    End Sub

    Private Sub AsignarDatos()
        oPago_iva.fecha_Pago_iva = Me.dtpFecha_Pago_iva.Value.Date
        oPago_iva.pago_Iva = CDec(Me.txtPago_iva.Text)
        oPago_iva.numero_recibo_Pago_iva = Me.txtNumero_recibo_Pago_iva.Text & Me.txtNumero_recibo_Pago_iva2.Text
        oPago_iva.id_Iva = CInt(Me.lblid_iva.Text)
        oPago_iva.id_empresa = CInt(Me.lblid_empresa.Text)
        oPago_iva.efectivo_iva = Me.chkEfectivo_iva.Checked
        oPago_iva.numero_cheque_iva = Me.txtNumero_cheque_iva.Text
        If Me.chkEfectivo_iva.Checked = True Then
            ' oPago_iva.fecha_emision_cheque_iva = Nothing
            ' oPago_iva.fecha_pago_cheque_iva = Nothing
        Else
            oPago_iva.fecha_emision_cheque_iva = Me.dtpFecha_emision_cheque_iva.Value.Date
            oPago_iva.fecha_pago_cheque_iva = Me.dtpFecha_pago_cheque_iva.Value.Date
        End If
        oPago_iva.detalle_cheque_iva = Me.txtDetalle_cheque_iva.Text
        oPago_iva.detalle_pago = Me.txtdetalle_pago.Text
    End Sub

    Public Sub SoloLectura()
        Me.dtpfecha_Pago_iva.Enabled = False
        Me.txtPago_iva.Enabled = False
        Me.txtnumero_recibo_Pago_iva.Enabled = False
        Me.btnGuardar.Visible = False
        Me.chkEfectivo_iva.Enabled = False
        Me.txtNumero_cheque_iva.Enabled = False
        Me.dtpFecha_emision_cheque_iva.Enabled = False
        Me.dtpFecha_pago_cheque_iva.Enabled = False
        Me.txtDetalle_cheque_iva.Enabled = False
        Me.txtdetalle_pago.Enabled = False
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            If oPago_iva.Exist() Then
                If BanderaPago_iva = 1 Then
                    MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
                    Exit Sub
                ElseIf BanderaPago_iva = 2 Then
                    If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                        = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            Select Case BanderaPago_iva
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oPago_iva.Guardar()
                    CType(Me.Owner, frmAbmGestion_iva).RefrescarGrillaPago_iva()
                    Me.CargarCombos()
                    oPago_iva.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.dtpfecha_Pago_iva.Focus()
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oPago_iva.Guardar()
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If Me.txtPago_iva.Text = "" Or Me.txtNumero_recibo_Pago_iva.Text = "" Or Me.txtNumero_recibo_Pago_iva2.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean

        If CDbl(Me.lblid_iva.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de iva")
            Exit Sub
        End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaPago_iva = 1 Then
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
    Handles chkEfectivo_iva.KeyPress, txtNumero_cheque_iva.KeyPress, txtDetalle_cheque_iva.KeyPress, txtDetalle_pago.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles dtpFecha_pago_iva.KeyDown, dtpFecha_emision_cheque_iva.KeyDown, dtpFecha_pago_cheque_iva.KeyDown
        If CDbl(e.KeyValue.ToString) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtPago_iva.KeyPress
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

    Private Sub Numeros(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtNumero_recibo_pago_iva.KeyPress, txtNumero_recibo_pago_iva2.KeyPress
        Dim txtTemp As TextBox
        txtTemp = CType(sender, TextBox)

        If e.KeyChar.ToString = vbCr Then
            If txtTemp.Name = "txtNumero_recibo_pago_iva" Then
                Me.txtNumero_recibo_pago_iva.Text = CompletarCeros(Me.txtNumero_recibo_pago_iva.Text, 4)
            End If
            If txtTemp.Name = "txtNumero_recibo_pago_iva2" Then
                Me.txtNumero_recibo_pago_iva2.Text = CompletarCeros(Me.txtNumero_recibo_pago_iva2.Text, 8)
            End If
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If

        If (e.KeyChar.ToString >= "0" And e.KeyChar.ToString <= "9") Or e.KeyChar = vbBack Then
            '  e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub txtNumeros_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles txtNumero_recibo_Pago_iva.LostFocus, txtNumero_recibo_Pago_iva2.LostFocus
        Dim txtTemp As New TextBox
        txtTemp = CType(sender, TextBox)
        If txtTemp.Name = "txtNumero_recibo_pago_iva" And txtTemp.Text.Length <> 4 Then
            Me.txtNumero_recibo_pago_iva.Text = CompletarCeros(Me.txtNumero_recibo_pago_iva.Text, 4)
        End If
        If txtTemp.Name = "txtNumero_recibo_pago_iva2" And txtTemp.Text.Length <> 8 Then
            Me.txtNumero_recibo_pago_iva2.Text = CompletarCeros(Me.txtNumero_recibo_pago_iva2.Text, 8)
        End If
    End Sub

    Private Sub chkEfectivo_iva_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEfectivo_iva.CheckedChanged
        If Me.chkEfectivo_iva.Checked = True Then
            Me.gbxCheque.Enabled = False
        Else
            Me.gbxCheque.Enabled = True
        End If
    End Sub

    Private Sub chkEfectivo_iva_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chkEfectivo_iva.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

End Class