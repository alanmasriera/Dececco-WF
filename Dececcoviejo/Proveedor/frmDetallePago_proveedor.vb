Public Class frmDetallePago_proveedor


    Private Sub frmDetallePago_proveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttGeneral.SetToolTip(Me.btnBuscaProveedor, "Buscar Nuevo Proveedor")
        Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Pago_proveedor")
        Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()

            Me.cmbProveedor.Text = oProveedor.GetOne(CInt(Me.lblid_proveedor.Text)).Rows(0).Item("nombre_Proveedor").ToString.Trim
        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try

        If BanderaPago_proveedor = 1 Then
            Me.LimpiarControles()

            Me.lblid_proveedor.Text = CType(Me.Owner, frmAbmPago_proveedor).lblid_proveedor.Text
            Me.cmbProveedor.Text = oProveedor.GetOne(CInt(Me.lblid_proveedor.Text)).Rows(0).Item("nombre_Proveedor").ToString.Trim
        End If

        Me.Text = "Pago_proveedor" & NombreFormulario
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False

    End Sub

    Sub CargarCombos()
        Me.CargarProveedor()
    End Sub

    Sub CargarProveedor()
        Dim odt As New DataTable

        odt = oProveedor.GetCmb
        With Me.cmbProveedor
            .DataSource = odt
            .DisplayMember = "nombre_Proveedor"
            .ValueMember = "id_Proveedor"
        End With
        If Me.cmbProveedor.SelectedIndex >= 0 Then
            cmbProveedor.SelectedIndex = 0
            Me.lblid_proveedor.Text = cmbProveedor.SelectedValue.ToString
        End If
    End Sub

    Sub LimpiarControles()
        ' Me.lblid_proveedor.Text = "0"
        ' Me.cmbProveedor.Text = ""
        Me.dtpfecha.Value = DateTime.Now
        Me.txtpago.Text = ""
        Me.txtNumero_4.Text = ""
        Me.txtNumero_8.Text = ""
        Me.txtdetalle.Text = ""
        Me.chkEfectivo.Text = ""
    End Sub

    Private Sub ObtenerDatos()
        If oPago_proveedor.numero_remito.Length = 12 Then
            Me.txtNumero_4.Text = oPago_proveedor.numero_remito.Substring(0, 4)
            Me.txtNumero_8.Text = oPago_proveedor.numero_remito.Substring(4, 8)
        End If

        Me.lblid_proveedor.Text = CStr(oPago_proveedor.id_proveedor)

        Me.dtpFecha.Value = oPago_proveedor.fecha
        Me.txtPago.Text = oPago_proveedor.pago.ToString.Trim
        Me.txtDetalle.Text = oPago_proveedor.detalle.Trim
        Me.chkEfectivo.Checked = oPago_proveedor.efectivo
    End Sub

    Private Sub AsignarDatos()
        oPago_proveedor.id_proveedor = CInt(Me.lblid_proveedor.Text)
        oPago_proveedor.fecha = Me.dtpFecha.Value.Date
        oPago_proveedor.pago = CDec(Me.txtPago.Text)
        oPago_proveedor.numero_remito = Me.txtNumero_4.Text & Me.txtNumero_8.Text
        oPago_proveedor.detalle = Me.txtDetalle.Text
        oPago_proveedor.efectivo = Me.chkEfectivo.Checked
    End Sub

    Public Sub SoloLectura()
        Me.cmbProveedor.Enabled = False
        Me.btnBuscaProveedor.Enabled = False
        Me.dtpfecha.Enabled = False
        Me.txtpago.Enabled = False
        Me.txtNumero_4.Enabled = False
        Me.txtNumero_8.Enabled = False
        Me.txtdetalle.Enabled = False
        Me.chkEfectivo.Enabled = False
        Me.btnGuardar.Visible = False
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            Select Case BanderaPago_proveedor
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oPago_proveedor.Guardar()
                    CType(Me.Owner, frmAbmPago_proveedor).RefrescarGrilla()
                    ' Me.CargarCombos()
                    oPago_proveedor.Insertar()
                    ' Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.dtpFecha.Focus()
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oPago_proveedor.Guardar()
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If Me.txtpago.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean

        If CDbl(Me.lblid_proveedor.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de proveedor")
            Exit Sub
        End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaPago_proveedor = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cmbProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProveedor.SelectedIndexChanged
        If Me.cmbProveedor.SelectedIndex >= 0 Then
            Me.lblid_proveedor.Text = cmbProveedor.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaProveedor.Click
        Dim frmTemporal As New FrmAbmProveedor
        frmTemporal.ShowDialog()
        Me.CargarProveedor()
        Me.cmbProveedor.Focus()
        Me.cmbProveedor.Text = ""
        Me.lblid_Proveedor.Text = "0"
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles cmbProveedor.KeyDown, dtpFecha.KeyDown
        If e.KeyValue = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtNumero_4.KeyPress, txtDetalle.KeyPress, txtNumero_8.KeyPress
        Dim txtTemp As New TextBox
        txtTemp = CType(sender, TextBox)

        If e.KeyChar.ToString = vbCr Then
            If txtTemp.Name = "txtNumero_4" Then
                Me.txtNumero_4.Text = CompletarCeros(Me.txtNumero_4.Text, 4)
            End If
            If txtTemp.Name = "txtNumero_8" Then
                Me.txtNumero_8.Text = CompletarCeros(Me.txtNumero_8.Text, 8)
            End If
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtPago.KeyPress
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

    Private Sub chkEfectivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEfectivo.CheckedChanged
        Dim chkTemp As New CheckBox
        chkTemp = CType(sender, CheckBox)

        ' If chkTemp.Checked = False Then
        '  Me.cmbCheque_librado.Enabled = False
        '  Me.btnBuscaCheque_librado.Enabled = False
        '   Else
        '  Me.cmbCheque_librado.Enabled = True
        '  Me.btnBuscaCheque_librado.Enabled = True
        ' End If
    End Sub


    Private Sub btnBuscaCheque_librado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaCheque_librado.Click
        'Dim frmTemp As New Frmmovbancos
        'frmTemp.ShowDialog()

    End Sub

    Private Sub txtNumero_4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumero_4.LostFocus
        Me.txtNumero_4.Text = CompletarCeros(Me.txtNumero_4.Text, 4)
    End Sub

    Private Sub txtNumero_8_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumero_8.LostFocus
        Me.txtNumero_8.Text = CompletarCeros(Me.txtNumero_8.Text, 8)
    End Sub


End Class