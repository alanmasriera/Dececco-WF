Public Class frmDetalleCheque_proveedor_2

   Private Sub frmDetalleCheque_proveedor_2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

       Me.ttGeneral.SetToolTip(Me.btnBuscaCheque_recibido, "Buscar Nuevo Cheque_recibido")
       Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Cheque_proveedor_2")
       Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
       Try
           ObtenerDatos()

            'Me.cmbRecibo_proveedo.Text = oRecibo_proveedor.GetOne(CInt(Me.lblid_recibo_proveedor.Text)).Rows(0).Item("nombre_Recibo_proveedor").ToString.Trim
            Me.cmbcheque_recibido.Text = oCheque_recibido.GetOne(CInt(Me.lblid_cheque_recibido.Text)).Rows(0).Item("nombre Cheque recibido").ToString.Trim
            'Me.lblid_recibo_proveedor.Text = CType(Me.Owner, frmDetalleRecibo_proveedor).lblid_recibo_proveedor.Text
       Catch ex As Exception
           '    MessageBox.Show(ex.Message)
       End Try

       If BanderaCheque_proveedor_2  = 1 Then
           Me.LimpiarControles()
       End If
        Me.Text = "Cheque_proveedor_2" & vgNombreFormulario
       Me.CancelButton = Me.btnSalir
       Me.BackColor = Color.Gainsboro
       Me.StartPosition = FormStartPosition.CenterScreen
       Me.MinimizeBox = False
        Me.MaximizeBox = False

        Me.lblid_recibo_proveedor.Text = CType(Me.Owner, frmDetalleRecibo_proveedor).lblid_recibo_proveedor.Text
        Me.lblid_proveedor.Text = CType(Me.Owner, frmDetalleRecibo_proveedor).lblid_proveedor.Text
    End Sub

    Sub CargarCombos()

        Me.CargarCheque_recibido()
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

    Sub CargarCheque_recibido()
        Dim odt As New DataTable

        odt = oCheque_recibido.GetCmb_2(CInt(Me.lblid_proveedor.Text))

        With Me.cmbcheque_recibido
            .DataSource = odt
            .DisplayMember = "nombre_cheque_recibido"
            .ValueMember = "id_cheque_recibido"
        End With
        If Me.cmbcheque_recibido.SelectedIndex >= 0 Then
            cmbcheque_recibido.SelectedIndex = 0
            Me.lblid_cheque_recibido.Text = cmbcheque_recibido.SelectedValue.ToString
        End If
    End Sub

    Sub LimpiarControles()
        'Me.lblid_recibo_proveedor.Text = "0"
        'Me.cmbRecibo_proveedor.Text =  ""
        Me.lblid_cheque_recibido.Text = "0"
        Me.cmbcheque_recibido.Text = ""
        Me.chkcontrol.Checked = False
    End Sub

    Private Sub ObtenerDatos()
        'Me.lblid_recibo_proveedor.Text = oCheque_proveedor_2.id_recibo_proveedor.ToString
        Me.lblid_cheque_recibido.Text = oCheque_proveedor_2.id_cheque_recibido.ToString
        Me.chkcontrol.Checked = oCheque_proveedor_2.control
    End Sub

    Private Sub AsignarDatos()
        oCheque_proveedor_2.id_recibo_proveedor = CInt(Me.lblid_recibo_proveedor.Text)
        oCheque_proveedor_2.id_cheque_recibido = CInt(Me.lblid_cheque_recibido.Text)
        oCheque_proveedor_2.control = Me.chkcontrol.Checked
    End Sub

    Public Sub SoloLectura()
        'Me.cmbRecibo_proveedor.Enabled = False
        'Me.btnBuscaRecibo_proveedor.Enabled = False
        Me.cmbcheque_recibido.Enabled = False
        Me.btnBuscacheque_recibido.Enabled = False
        Me.chkcontrol.Enabled = False
        Me.btnGuardar.Visible = False
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            If oCheque_proveedor_2.Exist() Then
                If BanderaCheque_proveedor_2 = 1 Then
                    MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
                    Exit Sub
                ElseIf BanderaCheque_proveedor_2 = 2 Then
                    If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                        = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            Select Case BanderaCheque_proveedor_2
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oCheque_proveedor_2.Guardar()
                    CType(Me.Owner, frmDetalleRecibo_proveedor).RefrescarGrilla_3()
                    Me.CargarCombos()
                    oCheque_proveedor_2.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    cmbcheque_recibido.Focus()
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oCheque_proveedor_2.Guardar()
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

        'If CDbl(Me.lblid_cheque_recibido.Text) = 0 Then
        '    MessageBox.Show("Debe Seleccionar un Dato del Combo de cheque_recibido")
        '    Exit Sub
        'End If

       blnVacios = Me.ChequearVacios
       If blnVacios = False Then
           MessageBox.Show("Debe Llenar los Campos Obligatorios")
           Exit Sub
       Else
           If BanderaCheque_proveedor_2  = 1 Then
               Me.Guardar()
           Else
               Me.Guardar()
           End If
       End If
   End Sub

   Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
       Me.Close()
   End Sub

  

  

   Private Sub cmbCheque_recibido_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCheque_recibido.SelectedIndexChanged
       If Me.cmbCheque_recibido.SelectedIndex >= 0 Then
           Me.lblid_cheque_recibido.Text = cmbCheque_recibido.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaCheque_recibido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaCheque_recibido.Click
        Dim frmTemporal As New frmResumenCaja
       frmTemporal.ShowDialog()
       Me.CargarCheque_recibido()
       Me.cmbCheque_recibido.Focus()
       Me.cmbCheque_recibido.Text = ""
       Me.lblid_Cheque_recibido.Text = "0"
   End Sub

   Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles chkcontrol.KeyPress
       If e.KeyChar.ToString = vbCr Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles cmbcheque_recibido.KeyDown
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
