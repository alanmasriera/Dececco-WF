Public Class frmDetalleCheque_librado

   Private Sub frmDetalleCheque_librado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttGeneral.SetToolTip(Me.btnBuscaProveedor, "Buscar Nuevo Persona")
        ' Me.ttGeneral.SetToolTip(Me.btnBuscaEmpresa, "Buscar Nuevo Empresa")
        Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Cheque_librado")
        Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()

            Me.cmbProveedor.Text = oProveedor.GetOne(CInt(Me.lblid_proveedor.Text)).Rows(0).Item("nombre_proveedor").ToString.Trim
            '   Me.cmbEmpresa.Text = oEmpresa.GetOne(CInt(Me.lblid_Empresa.Text)).Rows(0).Item("nombre_Empresa").ToString.Trim
        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try

        If BanderaCheque_librado = 1 Then
            Me.LimpiarControles()
        End If
        Me.Text = "Cheque_librado" & vgNombreFormulario
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False

        Me.lblid_empresa.Text = CType(Me.Owner, frmResumenCaja).lblidEmpresa.Text
    End Sub

    Sub CargarCombos()
        Me.Cargarproveedor()
        ' Me.CargarEmpresa
    End Sub

    Sub Cargarproveedor()
        Dim odt As New DataTable

        odt = oProveedor.GetCmb
        With Me.cmbProveedor
            .DataSource = odt
            .DisplayMember = "nombre_proveedor"
            .ValueMember = "id_proveedor"
        End With
        If Me.cmbProveedor.SelectedIndex >= 0 Then
            cmbProveedor.SelectedIndex = 0
            Me.lblid_proveedor.Text = cmbProveedor.SelectedValue.ToString
        End If
    End Sub



    Sub LimpiarControles()
        Me.txtnumero_cheque.Text = ""
        Me.lblid_proveedor.Text = "0"
        Me.cmbProveedor.Text = ""
        Me.txtdetalle.Text = ""
        Me.dtpfecha_librado.Value = DateTime.Now
        Me.dtpfecha_pago.Value = DateTime.Now
        Me.txtimporte.Text = ""
        Me.txtiva.Text = "0"
        'Me.lblid_empresa.Text = "0"
        'Me.cmbEmpresa.Text =  ""
        Me.chkcontrol.Checked = False
        Me.chkanulado.Checked = False
    End Sub

    Private Sub ObtenerDatos()
        Me.txtnumero_cheque.Text = oCheque_librado.numero_cheque.Trim
        Me.lblid_proveedor.Text = oCheque_librado.id_proveedor.ToString
        Me.txtdetalle.Text = oCheque_librado.detalle.Trim
        Me.dtpfecha_librado.Value = oCheque_librado.fecha_librado
        Me.dtpfecha_pago.Value = oCheque_librado.fecha_pago
        Me.txtimporte.Text = oCheque_librado.importe.ToString.Trim
        Me.txtiva.Text = oCheque_librado.iva.ToString.Trim
        '  Me.lblid_empresa.Text = oCheque_librado.id_empresa.ToString
        Me.chkcontrol.Checked = oCheque_librado.control
        Me.chkanulado.Checked = oCheque_librado.anulado
    End Sub

    Private Sub AsignarDatos()
        oCheque_librado.numero_cheque = Me.txtnumero_cheque.Text
        oCheque_librado.id_proveedor = CInt(Me.lblid_proveedor.Text)
        oCheque_librado.detalle = Me.txtdetalle.Text.Trim
        oCheque_librado.fecha_librado = Me.dtpfecha_librado.Value.Date
        oCheque_librado.fecha_pago = Me.dtpfecha_pago.Value.Date
        oCheque_librado.importe = CDec(Me.txtimporte.Text)
        oCheque_librado.iva = CDec(Me.txtiva.Text)
        oCheque_librado.id_empresa = CInt(Me.lblid_empresa.Text)
        oCheque_librado.control = Me.chkcontrol.Checked
        oCheque_librado.anulado = Me.chkanulado.Checked
    End Sub

    Public Sub SoloLectura()
        Me.txtnumero_cheque.Enabled = False
        Me.cmbProveedor.Enabled = False
        Me.btnBuscaProveedor.Enabled = False
        Me.txtdetalle.Enabled = False
        Me.dtpfecha_librado.Enabled = False
        Me.dtpfecha_pago.Enabled = False
        Me.txtimporte.Enabled = False
        Me.txtiva.Enabled = False
        'Me.cmbEmpresa.Enabled = False
        'Me.btnBuscaEmpresa.Enabled = False
        Me.chkcontrol.Enabled = False
        Me.chkanulado.Enabled = False
        Me.btnGuardar.Visible = False
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            If oCheque_librado.Exist() Then
                If BanderaCheque_librado = 1 Then
                    MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
                    Exit Sub
                ElseIf BanderaCheque_librado = 2 Then
                    If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                        = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            Select Case BanderaCheque_librado
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oCheque_librado.Guardar()
                    CType(Me.Owner, frmResumenCaja).RefrescarGrilla()
                    Me.CargarCombos()
                    oCheque_librado.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.txtnumero_cheque.Focus()
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oCheque_librado.Guardar()
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If Me.txtnumero_cheque.Text = "" Or Me.txtimporte.Text = "" Or Me.txtiva.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean

        If CDbl(Me.lblid_proveedor.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de persona")
            Exit Sub
        End If
        If CDbl(Me.lblid_empresa.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de empresa")
            Exit Sub
        End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaCheque_librado = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cmbPersona_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProveedor.SelectedIndexChanged
        If Me.cmbProveedor.SelectedIndex >= 0 Then
            Me.lblid_proveedor.Text = cmbProveedor.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaproveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaProveedor.Click
        Dim frmTemporal As New frmAbmProveedor
        frmTemporal.ShowDialog()
        Me.Cargarproveedor()
        Me.cmbProveedor.Focus()
        Me.cmbProveedor.Text = ""
        Me.lblid_proveedor.Text = "0"
    End Sub

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtnumero_cheque.KeyPress, txtdetalle.KeyPress, chkcontrol.KeyPress, chkanulado.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles cmbProveedor.KeyDown, dtpfecha_librado.KeyDown, dtpfecha_pago.KeyDown
        If CDbl(e.KeyValue.ToString) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

   Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtimporte.KeyPress, txtiva.KeyPress
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
