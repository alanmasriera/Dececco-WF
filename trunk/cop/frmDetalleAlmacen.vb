Public Class frmDetalleAlmacen

   Private Sub frmDetalleAlmacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnBuscaCliente, "Buscar Nuevo Cliente")
       Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Almacen")
       Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
       Try
           ObtenerDatos()

           Me.cmbCliente.Text = oCliente.GetOne(CInt(Me.lblid_Cliente.Text)).Rows(0).Item("nombre Cliente").ToString.Trim
       Catch ex As Exception
           '    MessageBox.Show(ex.Message)
       End Try

       If BanderaAlmacen  = 1 Then
           Me.LimpiarControles()
       End If
       Me.Text = "Almacen" & vgNombreFormulario
       Me.CancelButton = Me.btnSalir
       Me.BackColor = Color.Gainsboro
       Me.StartPosition = FormStartPosition.CenterScreen
       Me.MinimizeBox = False
       Me.MaximizeBox = False
   End Sub

   Sub CargarCombos()
       Me.CargarCliente
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
       Me.txtnombre_almacen.Text = ""
       Me.chktilde.Checked = False
       Me.lblid_cliente.Text = "0"
       Me.cmbCliente.Text =  ""
   End Sub

   Private Sub ObtenerDatos()
       Me.txtnombre_almacen.Text = oAlmacen.nombre_almacen.Trim
       Me.chktilde.Checked = oAlmacen.tilde
       Me.lblid_cliente.Text = oAlmacen.id_cliente.ToString
   End Sub

   Private Sub AsignarDatos()
       oAlmacen.nombre_almacen = Me.txtnombre_almacen.Text
       oAlmacen.tilde = Me.chktilde.Checked
       oAlmacen.id_cliente = CInt(Me.lblid_cliente.Text)
   End Sub

   Public Sub SoloLectura()
       Me.txtnombre_almacen.Enabled = False
       Me.chktilde.Enabled = False
       Me.cmbCliente.Enabled = False
       Me.btnBuscaCliente.Enabled = False
       Me.btnGuardar.Visible = False
   End Sub

   Private Sub Guardar()
       Try
           Me.AsignarDatos()
           If oAlmacen.Exist() Then
               If BanderaAlmacen = 1 Then
                   MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
               Exit Sub
               ElseIf BanderaAlmacen = 2 Then
                   If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                       = Windows.Forms.DialogResult.No Then
                       Exit Sub
                   End If
               End If
           End If
           Select Case BanderaAlmacen
               Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                   oAlmacen.Guardar()
                   CType(Me.Owner, frmAbmAlmacen).RefrescarGrilla()
                   Me.CargarCombos()
                   oAlmacen.Insertar()
                   Me.ObtenerDatos()
                   Me.LimpiarControles()
                   Me.txtnombre_almacen.Focus
               Case 2 'GUARDA Y SALE (MODIFICAR)
                   oAlmacen.Guardar()
                   Me.Close()
           End Select
       Catch ex As Exception
           MessageBox.Show(ex.Message)
       End Try
   End Sub

   Private Function ChequearVacios() As Boolean
       Dim bandera As Boolean
       If _ 
       Me.txtnombre_almacen.Text = "" Then
           bandera = False
       Else
           bandera = True
       End If
       Return bandera
   End Function

   Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
       Dim blnVacios As Boolean

       If CDbl(Me.lblid_cliente.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de cliente")
           Exit Sub
       End If

       blnVacios = Me.ChequearVacios
       If blnVacios = False Then
           MessageBox.Show("Debe Llenar los Campos Obligatorios")
           Exit Sub
       Else
           If BanderaAlmacen  = 1 Then
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
       Dim frmTemporal As New FrmAbmCliente
       frmTemporal.ShowDialog()
       Me.CargarCliente()
       Me.cmbCliente.Focus()
       Me.cmbCliente.Text = ""
       Me.lblid_Cliente.Text = "0"
   End Sub

   Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtnombre_almacen.KeyPress, chktilde.KeyPress
       If e.KeyChar.ToString = vbCr Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
   Handles cmbCliente.KeyDown
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
