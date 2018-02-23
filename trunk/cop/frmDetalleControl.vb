Public Class frmDetalleControl

   Private Sub frmDetalleControl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnBuscaIce, "Buscar Nuevo Ice")
       Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Control")
       Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
       Try
           ObtenerDatos()

           Me.cmbIce.Text = oIce.GetOne(CInt(Me.lblid_Ice.Text)).Rows(0).Item("nombre Ice").ToString.Trim
       Catch ex As Exception
           '    MessageBox.Show(ex.Message)
       End Try

       If BanderaControl  = 1 Then
           Me.LimpiarControles()
       End If
       Me.Text = "Control" & vgNombreFormulario
       Me.CancelButton = Me.btnSalir
       Me.BackColor = Color.Gainsboro
       Me.StartPosition = FormStartPosition.CenterScreen
       Me.MinimizeBox = False
       Me.MaximizeBox = False
   End Sub

   Sub CargarCombos()
       Me.CargarIce
   End Sub

   Sub CargarIce()
       Dim odt As New DataTable

       odt = oIce.GetCmb
       With Me.cmbIce
           .DataSource = odt
           .DisplayMember = "nombre_ice"
           .ValueMember = "id_ice"
       End With
       If Me.cmbIce.SelectedIndex >= 0 Then
           cmbIce.SelectedIndex = 0
           Me.lblid_Ice.Text = cmbIce.SelectedValue.ToString
       End If
   End Sub

   Sub LimpiarControles()
       Me.txtnombre_control.Text = ""
       Me.lblindice.Text = "0"
       Me.cmbIce.Text =  ""
   End Sub

   Private Sub ObtenerDatos()
       Me.txtnombre_control.Text = oControl.nombre_control.Trim
       Me.lblindice.Text = oControl.indice.ToString
   End Sub

   Private Sub AsignarDatos()
       oControl.nombre_control = Me.txtnombre_control.Text
       oControl.indice = CInt(Me.lblindice.Text)
   End Sub

   Public Sub SoloLectura()
       Me.txtnombre_control.Enabled = False
       Me.cmbIce.Enabled = False
       Me.btnBuscaIce.Enabled = False
       Me.btnGuardar.Visible = False
   End Sub

   Private Sub Guardar()
       Try
           Me.AsignarDatos()
           If oControl.Exist() Then
               If BanderaControl = 1 Then
                   MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
               Exit Sub
               ElseIf BanderaControl = 2 Then
                   If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                       = Windows.Forms.DialogResult.No Then
                       Exit Sub
                   End If
               End If
           End If
           Select Case BanderaControl
               Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                   oControl.Guardar()
                   CType(Me.Owner, frmAbmControl).RefrescarGrilla()
                   Me.CargarCombos()
                   oControl.Insertar()
                   Me.ObtenerDatos()
                   Me.LimpiarControles()
                   Me.txtnombre_control.Focus
               Case 2 'GUARDA Y SALE (MODIFICAR)
                   oControl.Guardar()
                   Me.Close()
           End Select
       Catch ex As Exception
           MessageBox.Show(ex.Message)
       End Try
   End Sub

   Private Function ChequearVacios() As Boolean
       Dim bandera As Boolean
       If _ 
       Me.txtnombre_control.Text = "" Then
           bandera = False
       Else
           bandera = True
       End If
       Return bandera
   End Function

   Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
       Dim blnVacios As Boolean

       If CDbl(Me.lblindice.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de ice")
           Exit Sub
       End If

       blnVacios = Me.ChequearVacios
       If blnVacios = False Then
           MessageBox.Show("Debe Llenar los Campos Obligatorios")
           Exit Sub
       Else
           If BanderaControl  = 1 Then
               Me.Guardar()
           Else
               Me.Guardar()
           End If
       End If
   End Sub

   Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
       Me.Close()
   End Sub

   Private Sub cmbIce_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbIce.SelectedIndexChanged
       If Me.cmbIce.SelectedIndex >= 0 Then
           Me.lblindice.Text = cmbIce.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaIce_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaIce.Click
       Dim frmTemporal As New FrmAbmIce
       frmTemporal.ShowDialog()
       Me.CargarIce()
       Me.cmbIce.Focus()
       Me.cmbIce.Text = ""
       Me.lblid_Ice.Text = "0"
   End Sub

   Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtnombre_control.KeyPress
       If e.KeyChar.ToString = vbCr Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
   Handles cmbIce.KeyDown
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
