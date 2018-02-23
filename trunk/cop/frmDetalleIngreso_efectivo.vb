Public Class frmDetalleIngreso_efectivo

   Private Sub frmDetalleIngreso_efectivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnBuscaEmpresa, "Buscar Nuevo Empresa")
       Me.ttGeneral.SetToolTip(Me.btnBuscaCliente, "Buscar Nuevo Cliente")
       Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Ingreso_efectivo")
       Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
       Try
           ObtenerDatos()

           Me.cmbEmpresa.Text = oEmpresa.GetOne(CInt(Me.lblid_Empresa.Text)).Rows(0).Item("nombre Empresa").ToString.Trim
           Me.cmbCliente.Text = oCliente.GetOne(CInt(Me.lblid_Cliente.Text)).Rows(0).Item("nombre Cliente").ToString.Trim
       Catch ex As Exception
           '    MessageBox.Show(ex.Message)
       End Try

       If BanderaIngreso_efectivo  = 1 Then
           Me.LimpiarControles()
       End If
       Me.Text = "Ingreso_efectivo" & vgNombreFormulario
       Me.CancelButton = Me.btnSalir
       Me.BackColor = Color.Gainsboro
       Me.StartPosition = FormStartPosition.CenterScreen
       Me.MinimizeBox = False
       Me.MaximizeBox = False
   End Sub

   Sub CargarCombos()
       Me.CargarEmpresa
       Me.CargarCliente
   End Sub

   Sub CargarEmpresa()
       Dim odt As New DataTable

       odt = oEmpresa.GetCmb
       With Me.cmbEmpresa
           .DataSource = odt
           .DisplayMember = "nombre_empresa"
           .ValueMember = "id_empresa"
       End With
       If Me.cmbEmpresa.SelectedIndex >= 0 Then
           cmbEmpresa.SelectedIndex = 0
           Me.lblid_Empresa.Text = cmbEmpresa.SelectedValue.ToString
       End If
   End Sub

   Sub CargarCliente()
       Dim odt As New DataTable

       odt = oCliente.GetCmb
       With Me.cmbCliente
           .DataSource = odt
           .DisplayMember = "nombre_cliente"
           .ValueMember = "id_cliente"
       End With
       If Me.cmbCliente.SelectedIndex >= 0 Then
           cmbCliente.SelectedIndex = 0
           Me.lblid_Cliente.Text = cmbCliente.SelectedValue.ToString
       End If
   End Sub

   Sub LimpiarControles()
       Me.dtpfecha.Value = DateTime.Now
       Me.txtcomprobante.Text = ""
       Me.txtimporte.Text = "0"
       Me.txtiva.Text = "0"
       Me.txtdetalle.Text = ""
       Me.lblid_empresa.Text = "0"
       Me.cmbEmpresa.Text =  ""
       Me.chkcontrol.Checked = False
       Me.lblid_cliente.Text = "0"
       Me.cmbCliente.Text =  ""
       Me.chkarchivado.Checked = False
   End Sub

   Private Sub ObtenerDatos()
       Me.dtpfecha.Value = oIngreso_efectivo.fecha
       Me.txtcomprobante.Text = oIngreso_efectivo.comprobante.Trim
       Me.txtimporte.Text = oIngreso_efectivo.importe.ToString.Trim
       Me.txtiva.Text = oIngreso_efectivo.iva.ToString.Trim
       Me.txtdetalle.Text = oIngreso_efectivo.detalle.Trim
       Me.lblid_empresa.Text = oIngreso_efectivo.id_empresa.ToString
       Me.chkcontrol.Checked = oIngreso_efectivo.control
       Me.lblid_cliente.Text = oIngreso_efectivo.id_cliente.ToString
       Me.chkarchivado.Checked = oIngreso_efectivo.archivado
   End Sub

   Private Sub AsignarDatos()
       oIngreso_efectivo.fecha = Me.dtpfecha.Value.Date
       oIngreso_efectivo.comprobante = Me.txtcomprobante.Text
       oIngreso_efectivo.importe = CDec(Me.txtimporte.Text)
       oIngreso_efectivo.iva = CDec(Me.txtiva.Text)
       oIngreso_efectivo.detalle = Me.txtdetalle.Text
       oIngreso_efectivo.id_empresa = CInt(Me.lblid_empresa.Text)
       oIngreso_efectivo.control = Me.chkcontrol.Checked
       oIngreso_efectivo.id_cliente = CInt(Me.lblid_cliente.Text)
       oIngreso_efectivo.archivado = Me.chkarchivado.Checked
   End Sub

   Public Sub SoloLectura()
       Me.dtpfecha.Enabled = False
       Me.txtcomprobante.Enabled = False
       Me.txtimporte.Enabled = False
       Me.txtiva.Enabled = False
       Me.txtdetalle.Enabled = False
       Me.cmbEmpresa.Enabled = False
       Me.btnBuscaEmpresa.Enabled = False
       Me.chkcontrol.Enabled = False
       Me.cmbCliente.Enabled = False
       Me.btnBuscaCliente.Enabled = False
       Me.chkarchivado.Enabled = False
       Me.btnGuardar.Visible = False
   End Sub

   Private Sub Guardar()
       Try
           Me.AsignarDatos()
           If oIngreso_efectivo.Exist() Then
               If BanderaIngreso_efectivo = 1 Then
                   MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
               Exit Sub
               ElseIf BanderaIngreso_efectivo = 2 Then
                   If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                       = Windows.Forms.DialogResult.No Then
                       Exit Sub
                   End If
               End If
           End If
           Select Case BanderaIngreso_efectivo
               Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                   oIngreso_efectivo.Guardar()
                   CType(Me.Owner, frmAbmIngreso_efectivo).RefrescarGrilla()
                   Me.CargarCombos()
                   oIngreso_efectivo.Insertar()
                   Me.ObtenerDatos()
                   Me.LimpiarControles()
                   Me.dtpfecha.Focus
               Case 2 'GUARDA Y SALE (MODIFICAR)
                   oIngreso_efectivo.Guardar()
                   Me.Close()
           End Select
       Catch ex As Exception
           MessageBox.Show(ex.Message)
       End Try
   End Sub

   Private Function ChequearVacios() As Boolean
       Dim bandera As Boolean
       If _ 
       Me.txtcomprobante.Text = "" or _
       Me.txtimporte.Text = "" or _
       Me.txtiva.Text = "" or _
       Me.txtdetalle.Text = "" Then
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
       If CDbl(Me.lblid_cliente.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de cliente")
           Exit Sub
       End If

       blnVacios = Me.ChequearVacios
       If blnVacios = False Then
           MessageBox.Show("Debe Llenar los Campos Obligatorios")
           Exit Sub
       Else
           If BanderaIngreso_efectivo  = 1 Then
               Me.Guardar()
           Else
               Me.Guardar()
           End If
       End If
   End Sub

   Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
       Me.Close()
   End Sub

   Private Sub cmbEmpresa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEmpresa.SelectedIndexChanged
       If Me.cmbEmpresa.SelectedIndex >= 0 Then
           Me.lblid_empresa.Text = cmbEmpresa.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaEmpresa.Click
       Dim frmTemporal As New FrmAbmEmpresa
       frmTemporal.ShowDialog()
       Me.CargarEmpresa()
       Me.cmbEmpresa.Focus()
       Me.cmbEmpresa.Text = ""
       Me.lblid_Empresa.Text = "0"
   End Sub

   Private Sub cmbCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCliente.SelectedIndexChanged
       If Me.cmbCliente.SelectedIndex >= 0 Then
           Me.lblid_cliente.Text = cmbCliente.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaCliente.Click
       Dim frmTemporal As New FrmAbmCliente
       frmTemporal.ShowDialog()
       Me.CargarCliente()
       Me.cmbCliente.Focus()
       Me.cmbCliente.Text = ""
       Me.lblid_Cliente.Text = "0"
   End Sub

   Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtcomprobante.KeyPress, txtdetalle.KeyPress, chkcontrol.KeyPress, chkarchivado.KeyPress
       If e.KeyChar.ToString = vbCr Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
   Handles dtpfecha.KeyDown, cmbEmpresa.KeyDown, cmbCliente.KeyDown
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
