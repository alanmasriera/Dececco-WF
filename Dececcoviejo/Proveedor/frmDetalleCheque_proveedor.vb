Public Class frmDetalleCheque_proveedor

   Private Sub frmDetalleCheque_proveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Me.ttGeneral.SetToolTip(Me.btnBuscaRecibo_proveedor, "Buscar Nuevo Recibo_proveedor")
        Me.ttGeneral.SetToolTip(Me.btnBuscaCheque_librado, "Buscar Nuevo Cheque_librado")
        Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Cheque_proveedor")
        Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()

            '  Me.cmbRecibo_proveedor.Text = oRecibo_proveedor.GetOne(CInt(Me.lblid_Recibo_proveedor.Text)).Rows(0).Item("nombre_Recibo_proveedor").ToString.Trim
            Me.cmbcheque_librado.Text = oCheque_librado.GetOne(CInt(Me.lblid_cheque_librado.Text)).Rows(0).Item("nombre Cheque librado").ToString.Trim
        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try

        If BanderaCheque_proveedor = 1 Then
            Me.LimpiarControles()
        End If
        Me.Text = "Cheque_proveedor" & vgNombreFormulario
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False

        Me.lblid_recibo_proveedor.Text = CType(Me.Owner, frmDetalleRecibo_proveedor).lblid_recibo_proveedor.Text
        Me.lblid_proveedor.Text = CType(Me.Owner, frmDetalleRecibo_proveedor).lblid_proveedor.Text
    End Sub

    Sub CargarCombos()
        ' Me.CargarRecibo_proveedor
        Me.CargarCheque_librado()
    End Sub

    'Sub CargarRecibo_proveedor()
    '    Dim odt As New DataTable

    '    odt = oRecibo_proveedor.GetCmb
    '    With Me.cmbRecibo_proveedor
    '        .DataSource = odt
    '        .DisplayMember = "nombre_recibo_proveedor"
    '        .ValueMember = "id_recibo_proveedor"
    '    End With
    '    If Me.cmbRecibo_proveedor.SelectedIndex >= 0 Then
    '        cmbRecibo_proveedor.SelectedIndex = 0
    '        Me.lblid_Recibo_proveedor.Text = cmbRecibo_proveedor.SelectedValue.ToString
    '    End If
    'End Sub

    Sub CargarCheque_librado()
        Dim odt As New DataTable

        odt = oCheque_librado.GetCmbProveedor(CInt(Me.lblid_proveedor.Text))
        With Me.cmbCheque_librado
            .DataSource = odt
            .DisplayMember = "nombre_cheque_librado"
            .ValueMember = "id_cheque_librado"
        End With
        If Me.cmbCheque_librado.SelectedIndex >= 0 Then
            cmbCheque_librado.SelectedIndex = 0
            Me.lblid_Cheque_librado.Text = cmbCheque_librado.SelectedValue.ToString
        End If
    End Sub

    Sub LimpiarControles()
        '  Me.lblid_recibo_proveedor.Text = "0"
        '  Me.cmbRecibo_proveedor.Text =  ""
        Me.lblid_cheque_librado.Text = "0"
        Me.cmbCheque_librado.Text = ""
        Me.chkcontrol.Checked = False
    End Sub

    Private Sub ObtenerDatos()
        ' Me.lblid_recibo_proveedor.Text = oCheque_proveedor.id_recibo_proveedor.ToString
        Me.lblid_cheque_librado.Text = oCheque_proveedor.id_cheque_librado.ToString
        Me.chkcontrol.Checked = oCheque_proveedor.control
    End Sub

    Private Sub AsignarDatos()
        oCheque_proveedor.id_recibo_proveedor = CInt(Me.lblid_recibo_proveedor.Text)
        oCheque_proveedor.id_cheque_librado = CInt(Me.lblid_cheque_librado.Text)
        oCheque_proveedor.control = Me.chkcontrol.Checked
    End Sub

    Public Sub SoloLectura()
        ' Me.cmbRecibo_proveedor.Enabled = False
        ' Me.btnBuscaRecibo_proveedor.Enabled = False
        Me.cmbCheque_librado.Enabled = False
        Me.btnBuscaCheque_librado.Enabled = False
        Me.chkcontrol.Enabled = False
        Me.btnGuardar.Visible = False
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            If oCheque_proveedor.Exist() Then
                If BanderaCheque_proveedor = 1 Then
                    MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
                    Exit Sub
                ElseIf BanderaCheque_proveedor = 2 Then
                    If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                        = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            Select Case BanderaCheque_proveedor
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oCheque_proveedor.Guardar()
                    CType(Me.Owner, frmDetalleRecibo_proveedor).RefrescarGrilla_2()
                    Me.CargarCombos()
                    oCheque_proveedor.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.cmbcheque_librado.Focus()
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oCheque_proveedor.Guardar()
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

        'If CDbl(Me.lblid_recibo_proveedor.Text) = 0 Then
        '    MessageBox.Show("Debe Seleccionar un Dato del Combo de recibo_proveedor")
        '    Exit Sub
        'End If
        If CDbl(Me.lblid_cheque_librado.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de cheque_librado")
            Exit Sub
        End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaCheque_proveedor = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    'Private Sub cmbRecibo_proveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRecibo_proveedor.SelectedIndexChanged
    '    If Me.cmbRecibo_proveedor.SelectedIndex >= 0 Then
    '        Me.lblid_recibo_proveedor.Text = cmbRecibo_proveedor.SelectedValue.ToString
    '    End If
    'End Sub

    'Private Sub btnBuscaRecibo_proveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaRecibo_proveedor.Click
    '    Dim frmTemporal As New FrmAbmRecibo_proveedor
    '    frmTemporal.ShowDialog()
    '    Me.CargarRecibo_proveedor()
    '    Me.cmbRecibo_proveedor.Focus()
    '    Me.cmbRecibo_proveedor.Text = ""
    '    Me.lblid_Recibo_proveedor.Text = "0"
    'End Sub

    Private Sub cmbCheque_librado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCheque_librado.SelectedIndexChanged
        If Me.cmbCheque_librado.SelectedIndex >= 0 Then
            Me.lblid_cheque_librado.Text = cmbCheque_librado.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaCheque_librado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaCheque_librado.Click
        Dim frmTemporal As New Frmmovbancos
        frmTemporal.ShowDialog()
        Me.CargarCheque_librado()
        Me.cmbCheque_librado.Focus()
        Me.cmbCheque_librado.Text = ""
        Me.lblid_Cheque_librado.Text = "0"
    End Sub

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles chkcontrol.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles cmbcheque_librado.KeyDown
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

    
    
End Class
