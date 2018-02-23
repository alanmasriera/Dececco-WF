Public Class frmDetalleCuerpo_movimiento_voz

   Private Sub frmDetalleCuerpo_movimiento_voz_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnBuscaVoz, "Buscar Nuevo Voz")
       Me.ttGeneral.SetToolTip(Me.btnBuscaMovimiento_voz, "Buscar Nuevo Movimiento_voz")
       Me.ttGeneral.SetToolTip(Me.btnBuscaUsuario, "Buscar Nuevo Usuario")
       Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Cuerpo_movimiento_voz")
       Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
       Try
           ObtenerDatos()

           Me.cmbVoz.Text = oVoz.GetOne(CInt(Me.lblid_Voz.Text)).Rows(0).Item("nombre Voz").ToString.Trim
           Me.cmbMovimiento_voz.Text = oMovimiento_voz.GetOne(CInt(Me.lblid_Movimiento_voz.Text)).Rows(0).Item("nombre Movimiento_voz").ToString.Trim
           Me.cmbUsuario.Text = oUsuario.GetOne(CInt(Me.lblid_Usuario.Text)).Rows(0).Item("nombre Usuario").ToString.Trim
       Catch ex As Exception
           '    MessageBox.Show(ex.Message)
       End Try

       If BanderaCuerpo_movimiento_voz  = 1 Then
           Me.LimpiarControles()
       End If
       Me.Text = "Cuerpo_movimiento_voz" & vgNombreFormulario
       Me.CancelButton = Me.btnSalir
       Me.BackColor = Color.Gainsboro
       Me.StartPosition = FormStartPosition.CenterScreen
       Me.MinimizeBox = False
       Me.MaximizeBox = False
   End Sub

   Sub CargarCombos()
       Me.CargarVoz
       Me.CargarMovimiento_voz
       Me.CargarUsuario
   End Sub

   Sub CargarVoz()
       Dim odt As New DataTable

       odt = oVoz.GetCmb
       With Me.cmbVoz
           .DataSource = odt
           .DisplayMember = "nombre_voz"
           .ValueMember = "id_voz"
       End With
       If Me.cmbVoz.SelectedIndex >= 0 Then
           cmbVoz.SelectedIndex = 0
           Me.lblid_Voz.Text = cmbVoz.SelectedValue.ToString
       End If
   End Sub

   Sub CargarMovimiento_voz()
       Dim odt As New DataTable

       odt = oMovimiento_voz.GetCmb
       With Me.cmbMovimiento_voz
           .DataSource = odt
           .DisplayMember = "nombre_movimiento_voz"
           .ValueMember = "id_movimiento_voz"
       End With
       If Me.cmbMovimiento_voz.SelectedIndex >= 0 Then
           cmbMovimiento_voz.SelectedIndex = 0
           Me.lblid_Movimiento_voz.Text = cmbMovimiento_voz.SelectedValue.ToString
       End If
   End Sub

   Sub CargarUsuario()
       Dim odt As New DataTable

       odt = oUsuario.GetCmb
       With Me.cmbUsuario
           .DataSource = odt
           .DisplayMember = "nombre_usuario"
           .ValueMember = "id_usuario"
       End With
       If Me.cmbUsuario.SelectedIndex >= 0 Then
           cmbUsuario.SelectedIndex = 0
           Me.lblid_Usuario.Text = cmbUsuario.SelectedValue.ToString
       End If
   End Sub

   Sub LimpiarControles()
       Me.lblid_voz.Text = "0"
       Me.cmbVoz.Text =  ""
       Me.chknc1.Checked = False
       Me.chkok1.Checked = False
       Me.chkcorresponde1.Checked = False
       Me.chkconforme1.Checked = False
       Me.chkno_conforme1.Checked = False
       Me.txttipo1.Text = ""
       Me.txtdetalle1.Text = ""
       Me.chkcorreccion1.Checked = False
       Me.lblid_movimiento_voz.Text = "0"
       Me.cmbMovimiento_voz.Text =  ""
       Me.lblid_usuario.Text = "0"
       Me.cmbUsuario.Text =  ""
       Me.chkcorresponde2.Checked = False
       Me.chkconforme2.Checked = False
       Me.chkno_conforme2.Checked = False
       Me.txttipo2.Text = ""
       Me.txtdetalle2.Text = ""
       Me.chkcorreccion2.Checked = False
       Me.txtrandom.Text = "0"
       Me.chkcompletado.Checked = False
       Me.chkcompletado_pm.Checked = False
       Me.chkcontrol1.Checked = False
       Me.chkcontrol2.Checked = False
       Me.chkcontrol3.Checked = False
       Me.chkpedido_segundo_control.Checked = False
       Me.txtnumero_revision.Text = "0"
       Me.chkcorresponde.Checked = False
   End Sub

   Private Sub ObtenerDatos()
       Me.lblid_voz.Text = oCuerpo_movimiento_voz.id_voz.ToString
       Me.chknc1.Checked = oCuerpo_movimiento_voz.nc1
       Me.chkok1.Checked = oCuerpo_movimiento_voz.ok1
       Me.chkcorresponde1.Checked = oCuerpo_movimiento_voz.corresponde1
       Me.chkconforme1.Checked = oCuerpo_movimiento_voz.conforme1
       Me.chkno_conforme1.Checked = oCuerpo_movimiento_voz.no_conforme1
       Me.txttipo1.Text = oCuerpo_movimiento_voz.tipo1.Trim
       Me.txtdetalle1.Text = oCuerpo_movimiento_voz.detalle1.Trim
       Me.chkcorreccion1.Checked = oCuerpo_movimiento_voz.correccion1
       Me.lblid_movimiento_voz.Text = oCuerpo_movimiento_voz.id_movimiento_voz.ToString
       Me.lblid_usuario.Text = oCuerpo_movimiento_voz.id_usuario.ToString
       Me.chkcorresponde2.Checked = oCuerpo_movimiento_voz.corresponde2
       Me.chkconforme2.Checked = oCuerpo_movimiento_voz.conforme2
       Me.chkno_conforme2.Checked = oCuerpo_movimiento_voz.no_conforme2
       Me.txttipo2.Text = oCuerpo_movimiento_voz.tipo2.Trim
       Me.txtdetalle2.Text = oCuerpo_movimiento_voz.detalle2.Trim
       Me.chkcorreccion2.Checked = oCuerpo_movimiento_voz.correccion2
       Me.txtrandom.Text = oCuerpo_movimiento_voz.random.ToString.Trim
       Me.chkcompletado.Checked = oCuerpo_movimiento_voz.completado
       Me.chkcompletado_pm.Checked = oCuerpo_movimiento_voz.completado_pm
       Me.chkcontrol1.Checked = oCuerpo_movimiento_voz.control1
       Me.chkcontrol2.Checked = oCuerpo_movimiento_voz.control2
       Me.chkcontrol3.Checked = oCuerpo_movimiento_voz.control3
       Me.chkpedido_segundo_control.Checked = oCuerpo_movimiento_voz.pedido_segundo_control
       Me.txtnumero_revision.Text = oCuerpo_movimiento_voz.numero_revision.ToString.Trim
       Me.chkcorresponde.Checked = oCuerpo_movimiento_voz.corresponde
   End Sub

   Private Sub AsignarDatos()
       oCuerpo_movimiento_voz.id_voz = CInt(Me.lblid_voz.Text)
       oCuerpo_movimiento_voz.nc1 = Me.chknc1.Checked
       oCuerpo_movimiento_voz.ok1 = Me.chkok1.Checked
       oCuerpo_movimiento_voz.corresponde1 = Me.chkcorresponde1.Checked
       oCuerpo_movimiento_voz.conforme1 = Me.chkconforme1.Checked
       oCuerpo_movimiento_voz.no_conforme1 = Me.chkno_conforme1.Checked
       oCuerpo_movimiento_voz.tipo1 = Me.txttipo1.Text
       oCuerpo_movimiento_voz.detalle1 = Me.txtdetalle1.Text
       oCuerpo_movimiento_voz.correccion1 = Me.chkcorreccion1.Checked
       oCuerpo_movimiento_voz.id_movimiento_voz = CInt(Me.lblid_movimiento_voz.Text)
       oCuerpo_movimiento_voz.id_usuario = CInt(Me.lblid_usuario.Text)
       oCuerpo_movimiento_voz.corresponde2 = Me.chkcorresponde2.Checked
       oCuerpo_movimiento_voz.conforme2 = Me.chkconforme2.Checked
       oCuerpo_movimiento_voz.no_conforme2 = Me.chkno_conforme2.Checked
       oCuerpo_movimiento_voz.tipo2 = Me.txttipo2.Text
       oCuerpo_movimiento_voz.detalle2 = Me.txtdetalle2.Text
       oCuerpo_movimiento_voz.correccion2 = Me.chkcorreccion2.Checked
       oCuerpo_movimiento_voz.random = CDec(Me.txtrandom.Text)
       oCuerpo_movimiento_voz.completado = Me.chkcompletado.Checked
       oCuerpo_movimiento_voz.completado_pm = Me.chkcompletado_pm.Checked
       oCuerpo_movimiento_voz.control1 = Me.chkcontrol1.Checked
       oCuerpo_movimiento_voz.control2 = Me.chkcontrol2.Checked
       oCuerpo_movimiento_voz.control3 = Me.chkcontrol3.Checked
       oCuerpo_movimiento_voz.pedido_segundo_control = Me.chkpedido_segundo_control.Checked
       oCuerpo_movimiento_voz.numero_revision = CDec(Me.txtnumero_revision.Text)
       oCuerpo_movimiento_voz.corresponde = Me.chkcorresponde.Checked
   End Sub

   Public Sub SoloLectura()
       Me.cmbVoz.Enabled = False
       Me.btnBuscaVoz.Enabled = False
       Me.chknc1.Enabled = False
       Me.chkok1.Enabled = False
       Me.chkcorresponde1.Enabled = False
       Me.chkconforme1.Enabled = False
       Me.chkno_conforme1.Enabled = False
       Me.txttipo1.Enabled = False
       Me.txtdetalle1.Enabled = False
       Me.chkcorreccion1.Enabled = False
       Me.cmbMovimiento_voz.Enabled = False
       Me.btnBuscaMovimiento_voz.Enabled = False
       Me.cmbUsuario.Enabled = False
       Me.btnBuscaUsuario.Enabled = False
       Me.chkcorresponde2.Enabled = False
       Me.chkconforme2.Enabled = False
       Me.chkno_conforme2.Enabled = False
       Me.txttipo2.Enabled = False
       Me.txtdetalle2.Enabled = False
       Me.chkcorreccion2.Enabled = False
       Me.txtrandom.Enabled = False
       Me.chkcompletado.Enabled = False
       Me.chkcompletado_pm.Enabled = False
       Me.chkcontrol1.Enabled = False
       Me.chkcontrol2.Enabled = False
       Me.chkcontrol3.Enabled = False
       Me.chkpedido_segundo_control.Enabled = False
       Me.txtnumero_revision.Enabled = False
       Me.chkcorresponde.Enabled = False
       Me.btnGuardar.Visible = False
   End Sub

   Private Sub Guardar()
       Try
           Me.AsignarDatos()
           If oCuerpo_movimiento_voz.Exist() Then
               If BanderaCuerpo_movimiento_voz = 1 Then
                   MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
               Exit Sub
               ElseIf BanderaCuerpo_movimiento_voz = 2 Then
                   If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                       = Windows.Forms.DialogResult.No Then
                       Exit Sub
                   End If
               End If
           End If
           Select Case BanderaCuerpo_movimiento_voz
               Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                   oCuerpo_movimiento_voz.Guardar()
                   CType(Me.Owner, frmAbmCuerpo_movimiento_voz).RefrescarGrilla()
                   Me.CargarCombos()
                   oCuerpo_movimiento_voz.Insertar()
                   Me.ObtenerDatos()
                   Me.LimpiarControles()
                   Me.cmbVoz.Focus
               Case 2 'GUARDA Y SALE (MODIFICAR)
                   oCuerpo_movimiento_voz.Guardar()
                   Me.Close()
           End Select
       Catch ex As Exception
           MessageBox.Show(ex.Message)
       End Try
   End Sub

   Private Function ChequearVacios() As Boolean
       Dim bandera As Boolean
       If _ 
       Me.txttipo1.Text = "" or _
       Me.txtdetalle1.Text = "" or _
       Me.txttipo2.Text = "" or _
       Me.txtdetalle2.Text = "" or _
       Me.txtrandom.Text = "" or _
       Me.txtnumero_revision.Text = "" Then
           bandera = False
       Else
           bandera = True
       End If
       Return bandera
   End Function

   Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
       Dim blnVacios As Boolean

       If CDbl(Me.lblid_voz.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de voz")
           Exit Sub
       End If
       If CDbl(Me.lblid_movimiento_voz.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de movimiento_voz")
           Exit Sub
       End If
       If CDbl(Me.lblid_usuario.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de usuario")
           Exit Sub
       End If

       blnVacios = Me.ChequearVacios
       If blnVacios = False Then
           MessageBox.Show("Debe Llenar los Campos Obligatorios")
           Exit Sub
       Else
           If BanderaCuerpo_movimiento_voz  = 1 Then
               Me.Guardar()
           Else
               Me.Guardar()
           End If
       End If
   End Sub

   Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
       Me.Close()
   End Sub

   Private Sub cmbVoz_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbVoz.SelectedIndexChanged
       If Me.cmbVoz.SelectedIndex >= 0 Then
           Me.lblid_voz.Text = cmbVoz.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaVoz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaVoz.Click
       Dim frmTemporal As New FrmAbmVoz
       frmTemporal.ShowDialog()
       Me.CargarVoz()
       Me.cmbVoz.Focus()
       Me.cmbVoz.Text = ""
       Me.lblid_Voz.Text = "0"
   End Sub

   Private Sub cmbMovimiento_voz_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMovimiento_voz.SelectedIndexChanged
       If Me.cmbMovimiento_voz.SelectedIndex >= 0 Then
           Me.lblid_movimiento_voz.Text = cmbMovimiento_voz.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaMovimiento_voz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaMovimiento_voz.Click
       Dim frmTemporal As New FrmAbmMovimiento_voz
       frmTemporal.ShowDialog()
       Me.CargarMovimiento_voz()
       Me.cmbMovimiento_voz.Focus()
       Me.cmbMovimiento_voz.Text = ""
       Me.lblid_Movimiento_voz.Text = "0"
   End Sub

   Private Sub cmbUsuario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUsuario.SelectedIndexChanged
       If Me.cmbUsuario.SelectedIndex >= 0 Then
           Me.lblid_usuario.Text = cmbUsuario.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaUsuario.Click
       Dim frmTemporal As New FrmAbmUsuario
       frmTemporal.ShowDialog()
       Me.CargarUsuario()
       Me.cmbUsuario.Focus()
       Me.cmbUsuario.Text = ""
       Me.lblid_Usuario.Text = "0"
   End Sub

   Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles chknc1.KeyPress, chkok1.KeyPress, chkcorresponde1.KeyPress, chkconforme1.KeyPress, chkno_conforme1.KeyPress, txttipo1.KeyPress, txtdetalle1.KeyPress, chkcorreccion1.KeyPress, chkcorresponde2.KeyPress, chkconforme2.KeyPress, chkno_conforme2.KeyPress, txttipo2.KeyPress, txtdetalle2.KeyPress, chkcorreccion2.KeyPress, chkcompletado.KeyPress, chkcompletado_pm.KeyPress, chkcontrol1.KeyPress, chkcontrol2.KeyPress, chkcontrol3.KeyPress, chkpedido_segundo_control.KeyPress, chkcorresponde.KeyPress
       If e.KeyChar.ToString = vbCr Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
   Handles cmbVoz.KeyDown, cmbMovimiento_voz.KeyDown, cmbUsuario.KeyDown
       If CDbl(e.KeyValue.ToString) = 13 Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtrandom.KeyPress, txtnumero_revision.KeyPress
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
