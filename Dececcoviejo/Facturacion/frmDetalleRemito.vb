Public Class frmDetalleRemito

    Private Sub frmDetalleRemito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttGeneral.SetToolTip(Me.btnBuscaCliente, "Buscar Nuevo Cliente")
        Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Remito")
        Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()

            Me.cmbCliente.Text = oCliente.GetOne(Me.lblid_Cliente.Text).Rows(0).Item("nombre_Cliente").ToString.Trim
        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try

        If BanderaRemito = 1 Then
            Me.LimpiarControles()
        End If

        Me.Text = "Remito"
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Teal
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False
    End Sub

    Sub CargarCombos()
        Me.CargarCliente()
    End Sub

    Sub CargarCliente()
        Dim odt As New DataTable

        odt = oCliente.GetCmb
        With Me.cmbCliente
            .DataSource = odt
            .DisplayMember = "nombre_Cliente"
            .ValueMember = "id_Cliente"
        End With
        If Me.cmbCliente.SelectedIndex.ToString >= 0 Then
            cmbCliente.SelectedIndex = 0
            Me.lblid_Cliente.Text = cmbCliente.SelectedValue.ToString
        End If
    End Sub

    Sub LimpiarControles()
        Me.txtNumero_4.Text = ""
        Me.txtNumero_8.Text = ""
        Me.dtpfecha_remito.Value = DateTime.Now
        Me.lblid_cliente.Text = "0"
        Me.cmbCliente.Text = ""
        Me.chkControl.Checked = False
        Me.txtTotal_remito.Text = ""
    End Sub

    Private Sub ObtenerDatos()
        If oRemito.numero_remito.Length = 12 Then
            Me.txtNumero_4.Text = oRemito.numero_remito.Substring(0, 4)
            Me.txtNumero_8.Text = oRemito.numero_remito.Substring(4, 8)
        End If
        'Me.txtnumero_remito.Text = oRemito.numero_remito.Trim
        Me.dtpFecha_remito.Value = oRemito.fecha_remito
        Me.lblid_cliente.Text = oRemito.id_cliente
        Me.chkControl.Checked = oRemito.control
        Me.txtTotal_remito.Text = oRemito.total_remito
    End Sub

    Private Sub AsignarDatos()
        oRemito.numero_remito = Me.txtNumero_4.Text & Me.txtNumero_8.Text
        oRemito.fecha_remito = Me.dtpfecha_remito.Value.Date
        oRemito.id_cliente = Me.lblid_cliente.Text
        oRemito.control = Me.chkControl.Checked
        oRemito.total_remito = Me.txtTotal_remito.Text
    End Sub

    Public Sub SoloLectura()
        Me.txtNumero_4.Enabled = False
        Me.txtNumero_8.Enabled = False
        Me.dtpfecha_remito.Enabled = False
        Me.cmbCliente.Enabled = False
        Me.btnBuscaCliente.Enabled = False
        Me.chkcontrol.Enabled = False
        Me.btnGuardar.Visible = False
        Me.txtTotal_remito.Enabled = False
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            If oRemito.Exist() Then
                If BanderaRemito = 1 Then
                    MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
                    Exit Sub
                ElseIf BanderaRemito = 2 Then
                    If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                        = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            Select Case BanderaRemito
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oRemito.Guardar()
                    CType(Me.Owner, frmAbmVenta).RefrescarGrilla()
                    Me.CargarCombos()
                    oRemito.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.txtNumero_4.Focus()
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oRemito.Guardar()
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If Me.txtNumero_4.Text = "" Or Me.txtNumero_8.Text = "" Or Me.txtTotal_remito.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean

        If Me.lblid_cliente.Text = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de cliente")
            Exit Sub
        End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaRemito = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cmbCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCliente.SelectedIndexChanged
        If Me.cmbCliente.SelectedIndex >= 0 Then
            Me.lblid_cliente.Text = cmbCliente.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaCliente.Click
        Dim frmTemporal As New frmAbmClientes
        frmTemporal.ShowDialog()
        Me.CargarCliente()
        Me.cmbCliente.Focus()
        Me.cmbCliente.Text = ""
        Me.lblid_Cliente.Text = "0"
    End Sub

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles chkControl.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles dtpFecha_remito.KeyDown, cmbCliente.KeyDown
        If e.KeyValue.ToString = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtTotal_remito.KeyPress
        Dim txtTemp As TextBox
        txtTemp = sender

        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Then
            If InStr(txtTemp.Text, ",") <> 0 Then
                e.Handled = True
            Else
                e.KeyChar = ","
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
    Handles txtNumero_4.KeyPress, txtNumero_8.KeyPress
        Dim txtTemp As TextBox
        txtTemp = sender

        If e.KeyChar.ToString = vbCr Then
            If txtTemp.Name = "txtNumero_4" Then
                Me.txtNumero_4.Text = CompletarCeros(Me.txtNumero_4.Text, 4)
            End If
            If txtTemp.Name = "txtNumero_8" Then
                Me.txtNumero_8.Text = CompletarCeros(Me.txtNumero_8.Text, 8)
            End If
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If

        If (e.KeyChar.ToString >= "0" And e.KeyChar.ToString <= "9") Or e.KeyChar = vbBack Then
            '  e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


End Class