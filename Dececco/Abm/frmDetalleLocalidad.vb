Public Class frmDetalleLocalidad

   Private Sub frmDetalleLocalidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnBuscaProvincia, "Buscar Nuevo Provincia")
       Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Localidad")
       Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
       Try
           ObtenerDatos()

           Me.cmbProvincia.Text = oProvincia.GetOne(CInt(Me.lblid_Provincia.Text)).Rows(0).Item("nombre_Provincia").ToString.Trim
       Catch ex As Exception
           '    MessageBox.Show(ex.Message)
       End Try

       If BanderaLocalidad  = 1 Then
           Me.LimpiarControles()
       End If
        Me.Text = "Localidad" & vgNombreFormulario
       Me.CancelButton = Me.btnSalir
       Me.BackColor = Color.Gainsboro
       Me.StartPosition = FormStartPosition.CenterScreen
       Me.MinimizeBox = False
       Me.MaximizeBox = False
   End Sub

   Sub CargarCombos()
       Me.CargarProvincia
   End Sub

   Sub CargarProvincia()
       Dim odt As New DataTable

       odt = oProvincia.GetCmb
       With Me.cmbProvincia
           .DataSource = odt
           .DisplayMember = "nombre_provincia"
           .ValueMember = "id_provincia"
       End With
       If Me.cmbProvincia.SelectedIndex >= 0 Then
           cmbProvincia.SelectedIndex = 0
           Me.lblid_Provincia.Text = cmbProvincia.SelectedValue.ToString
       End If
   End Sub

   Sub LimpiarControles()
       Me.txtnombre_localidad.Text = ""
       Me.lblid_provincia.Text = "0"
       Me.cmbProvincia.Text =  ""
       Me.txtcodigo_postal.Text = ""
       Me.txtcaracteristica_telefonica.Text = ""
   End Sub

   Private Sub ObtenerDatos()
       Me.txtnombre_localidad.Text = oLocalidad.nombre_localidad.Trim
       Me.lblid_provincia.Text = oLocalidad.id_provincia.ToString
       Me.txtcodigo_postal.Text = oLocalidad.codigo_postal.Trim
       Me.txtcaracteristica_telefonica.Text = oLocalidad.caracteristica_telefonica.Trim
   End Sub

   Private Sub AsignarDatos()
       oLocalidad.nombre_localidad = Me.txtnombre_localidad.Text
       oLocalidad.id_provincia = CInt(Me.lblid_provincia.Text)
       oLocalidad.codigo_postal = Me.txtcodigo_postal.Text
       oLocalidad.caracteristica_telefonica = Me.txtcaracteristica_telefonica.Text
   End Sub

   Public Sub SoloLectura()
       Me.txtnombre_localidad.Enabled = False
       Me.cmbProvincia.Enabled = False
       Me.btnBuscaProvincia.Enabled = False
       Me.txtcodigo_postal.Enabled = False
       Me.txtcaracteristica_telefonica.Enabled = False
       Me.btnGuardar.Visible = False
   End Sub

   Private Sub Guardar()
       Try
           Me.AsignarDatos()
           If oLocalidad.Exist() Then
               If BanderaLocalidad = 1 Then
                   MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
               Exit Sub
               ElseIf BanderaLocalidad = 2 Then
                   If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                       = Windows.Forms.DialogResult.No Then
                       Exit Sub
                   End If
               End If
           End If
           Select Case BanderaLocalidad
               Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                   oLocalidad.Guardar()
                   CType(Me.Owner, frmAbmLocalidad).RefrescarGrilla()
                   Me.CargarCombos()
                   oLocalidad.Insertar()
                   Me.ObtenerDatos()
                   Me.LimpiarControles()
                   Me.txtnombre_localidad.Focus
               Case 2 'GUARDA Y SALE (MODIFICAR)
                   oLocalidad.Guardar()
                   Me.Close()
           End Select
       Catch ex As Exception
           MessageBox.Show(ex.Message)
       End Try
   End Sub

   Private Function ChequearVacios() As Boolean
       Dim bandera As Boolean
       If Me.txtnombre_localidad.Text = "" Then
           bandera = False
       Else
           bandera = True
       End If
       Return bandera
   End Function

   Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
       Dim blnVacios As Boolean

       If CDbl(Me.lblid_provincia.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de provincia")
           Exit Sub
       End If

       blnVacios = Me.ChequearVacios
       If blnVacios = False Then
           MessageBox.Show("Debe Llenar los Campos Obligatorios")
           Exit Sub
       Else
           If BanderaLocalidad  = 1 Then
               Me.Guardar()
           Else
               Me.Guardar()
           End If
       End If
   End Sub

   Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
       Me.Close()
   End Sub

   Private Sub cmbProvincia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProvincia.SelectedIndexChanged
       If Me.cmbProvincia.SelectedIndex >= 0 Then
           Me.lblid_provincia.Text = cmbProvincia.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaProvincia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaProvincia.Click
       Dim frmTemporal As New FrmAbmProvincia
       frmTemporal.ShowDialog()
       Me.CargarProvincia()
       Me.cmbProvincia.Focus()
       Me.cmbProvincia.Text = ""
       Me.lblid_Provincia.Text = "0"
   End Sub

   Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtnombre_localidad.KeyPress, txtcodigo_postal.KeyPress, txtcaracteristica_telefonica.KeyPress
       If e.KeyChar.ToString = vbCr Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
   Handles cmbProvincia.KeyDown
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
