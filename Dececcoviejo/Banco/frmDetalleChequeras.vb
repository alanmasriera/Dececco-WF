Public Class frmDetalleChequeras

   Private Sub frmDetalleChequeras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnBuscaBanco, "Buscar Nuevo Banco")
       Me.ttGeneral.SetToolTip(Me.btnBuscaCuenta, "Buscar Nuevo Cuenta")
       Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Chequeras")
       Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
       Try
           ObtenerDatos()

           Me.cmbBanco.Text = oBanco.GetOne(CInt(Me.lblid_Banco.Text)).Rows(0).Item("nombre_Banco").ToString.Trim
            Me.cmbcuenta.Text = oCuenta.GetOne(CInt(Me.lblid_cuenta.Text)).Rows(0).Item("numero").ToString.Trim
       Catch ex As Exception
           '    MessageBox.Show(ex.Message)
       End Try

        If BanderaChequera = 1 Then
            Me.LimpiarControles()
        End If
       Me.Text = "Chequeras"
       Me.CancelButton = Me.btnSalir
       Me.BackColor = Color.Gainsboro
       Me.StartPosition = FormStartPosition.CenterScreen
       Me.MinimizeBox = False
       Me.MaximizeBox = False
   End Sub

   Sub CargarCombos()
       Me.CargarBanco
        ' Me.CargarCuenta
   End Sub

   Sub CargarBanco()
       Dim odt As New DataTable

       odt = oBanco.GetCmb
       With Me.cmbBanco
           .DataSource = odt
           .DisplayMember = "nombre_banco"
           .ValueMember = "id_banco"
       End With
       If Me.cmbBanco.SelectedIndex >= 0 Then
           cmbBanco.SelectedIndex = 0
           Me.lblid_Banco.Text = cmbBanco.SelectedValue.ToString
       End If
   End Sub

   Sub CargarCuenta()
       Dim odt As New DataTable

        odt = oCuenta.GetCmb_2(CInt(Me.lblid_banco.Text))
       With Me.cmbCuenta
           .DataSource = odt
           .DisplayMember = "nombre_cuenta"
           .ValueMember = "id_cuenta"
       End With
       If Me.cmbCuenta.SelectedIndex >= 0 Then
           cmbCuenta.SelectedIndex = 0
           Me.lblid_Cuenta.Text = cmbCuenta.SelectedValue.ToString
       End If
   End Sub

   Sub LimpiarControles()
       Me.txtnumero_cheque.Text = ""
       Me.chktipo_cheque.Checked = False
       Me.lblid_banco.Text = "0"
       Me.cmbBanco.Text =  ""
       Me.lblid_cuenta.Text = "0"
       Me.cmbCuenta.Text =  ""
       Me.txtinicio.Text = ""
       Me.txtfin.Text = ""
   End Sub

   Private Sub ObtenerDatos()
        Me.txtnumero_cheque.Text = oChequera.numero_cheque.Trim
        Me.chktipo_cheque.Checked = oChequera.tipo_cheque
        Me.lblid_banco.Text = oChequera.id_banco.ToString
        Me.lblid_cuenta.Text = oChequera.id_cuenta.ToString
        Me.txtinicio.Text = oChequera.inicio.ToString.Trim
        Me.txtfin.Text = oChequera.fin.ToString.Trim
    End Sub

    Private Sub AsignarDatos()
        oChequera.numero_cheque = Me.txtnumero_cheque.Text
        oChequera.tipo_cheque = Me.chktipo_cheque.Checked
        oChequera.id_banco = CInt(Me.lblid_banco.Text)
        oChequera.id_cuenta = CInt(Me.lblid_cuenta.Text)
        oChequera.inicio = CDec(Me.txtinicio.Text)
        oChequera.fin = CDec(Me.txtfin.Text)
    End Sub

    Public Sub SoloLectura()
        Me.txtnumero_cheque.Enabled = False
        Me.chktipo_cheque.Enabled = False
        Me.cmbbanco.Enabled = False
        Me.btnBuscabanco.Enabled = False
        Me.cmbcuenta.Enabled = False
        Me.btnBuscacuenta.Enabled = False
        Me.txtinicio.Enabled = False
        Me.txtfin.Enabled = False
        Me.btnGuardar.Visible = False
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            If oChequera.Exist() Then
                If BanderaChequera = 1 Then
                    MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
                    Exit Sub
                ElseIf BanderaChequera = 2 Then
                    If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen �Desea Reemplazarlos?", "MODIFICAR", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                        = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            Select Case BanderaChequera
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oChequera.Guardar()
                    CType(Me.Owner, frmAbmChequeras).RefrescarGrilla()
                    Me.CargarCombos()
                    oChequera.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.txtnumero_cheque.Focus()
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oChequera.Guardar()
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

   Private Function ChequearVacios() As Boolean
       Dim bandera As Boolean
       If Me.txtnumero_cheque.Text = "" Then
           bandera = False
       Else
           bandera = True
       End If
       Return bandera
   End Function

   Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
       Dim blnVacios As Boolean

       If CDbl(Me.lblid_banco.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de banco")
           Exit Sub
       End If
       If CDbl(Me.lblid_cuenta.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de cuenta")
           Exit Sub
       End If

       blnVacios = Me.ChequearVacios
       If blnVacios = False Then
           MessageBox.Show("Debe Llenar los Campos Obligatorios")
           Exit Sub
       Else
            If BanderaChequera = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
       End If
   End Sub

   Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
       Me.Close()
   End Sub

   Private Sub cmbBanco_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBanco.SelectedIndexChanged
       If Me.cmbBanco.SelectedIndex >= 0 Then
           Me.lblid_banco.Text = cmbBanco.SelectedValue.ToString
        End If
        If Not IsNumeric(Me.lblid_banco.Text) Then
            Exit Sub
        End If
        Me.CargarCuenta()
   End Sub

   Private Sub btnBuscaBanco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaBanco.Click
       Dim frmTemporal As New FrmAbmBanco
       frmTemporal.ShowDialog()
       Me.CargarBanco()
       Me.cmbBanco.Focus()
       Me.cmbBanco.Text = ""
       Me.lblid_Banco.Text = "0"
   End Sub

   Private Sub cmbCuenta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCuenta.SelectedIndexChanged
       If Me.cmbCuenta.SelectedIndex >= 0 Then
           Me.lblid_cuenta.Text = cmbCuenta.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaCuenta.Click
        Dim frmTemporal As New frmAbmCuentas
       frmTemporal.ShowDialog()
       Me.CargarCuenta()
       Me.cmbCuenta.Focus()
       Me.cmbCuenta.Text = ""
       Me.lblid_Cuenta.Text = "0"
   End Sub

   Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtnumero_cheque.KeyPress, chktipo_cheque.KeyPress
       If e.KeyChar.ToString = vbCr Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
   Handles cmbBanco.KeyDown, cmbCuenta.KeyDown
       If CDbl(e.KeyValue.ToString) = 13 Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtinicio.KeyPress, txtfin.KeyPress
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
