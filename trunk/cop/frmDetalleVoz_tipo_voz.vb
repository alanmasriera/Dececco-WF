Public Class frmDetalleVoz_tipo_voz

   Private Sub frmDetalleVoz_tipo_voz_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnBuscaVoz, "Buscar Nuevo Voz")
       Me.ttGeneral.SetToolTip(Me.btnBuscaTipo_voz, "Buscar Nuevo Tipo_voz")
       Me.ttGeneral.SetToolTip(Me.btnBuscaIce, "Buscar Nuevo Ice")
       Me.ttGeneral.SetToolTip(Me.btnBusca, "Buscar Nuevo ")
       Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Voz_tipo_voz")
       Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
       Try
           ObtenerDatos()

           Me.cmbVoz.Text = oVoz.GetOne(CInt(Me.lblid_Voz.Text)).Rows(0).Item("nombre Voz").ToString.Trim
           Me.cmbTipo_voz.Text = oTipo_voz.GetOne(CInt(Me.lblid_Tipo_voz.Text)).Rows(0).Item("nombre Tipo_voz").ToString.Trim
           Me.cmbIce.Text = oIce.GetOne(CInt(Me.lblid_Ice.Text)).Rows(0).Item("nombre Ice").ToString.Trim
           Me.cmb.Text = o.GetOne(CInt(Me.lblid_.Text)).Rows(0).Item("nombre ").ToString.Trim
       Catch ex As Exception
           '    MessageBox.Show(ex.Message)
       End Try

       If BanderaVoz_tipo_voz  = 1 Then
           Me.LimpiarControles()
       End If
       Me.Text = "Voz_tipo_voz" & vgNombreFormulario
       Me.CancelButton = Me.btnSalir
       Me.BackColor = Color.Gainsboro
       Me.StartPosition = FormStartPosition.CenterScreen
       Me.MinimizeBox = False
       Me.MaximizeBox = False
   End Sub

   Sub CargarCombos()
       Me.CargarVoz
       Me.CargarTipo_voz
       Me.CargarIce
       Me.Cargar
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

   Sub CargarTipo_voz()
       Dim odt As New DataTable

       odt = oTipo_voz.GetCmb
       With Me.cmbTipo_voz
           .DataSource = odt
           .DisplayMember = "nombre_tipo_voz"
           .ValueMember = "id_tipo_voz"
       End With
       If Me.cmbTipo_voz.SelectedIndex >= 0 Then
           cmbTipo_voz.SelectedIndex = 0
           Me.lblid_Tipo_voz.Text = cmbTipo_voz.SelectedValue.ToString
       End If
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

   Sub Cargar()
       Dim odt As New DataTable

       odt = o.GetCmb
       With Me.cmb
           .DataSource = odt
           .DisplayMember = "nombre_"
           .ValueMember = "id_"
       End With
       If Me.cmb.SelectedIndex >= 0 Then
           cmb.SelectedIndex = 0
           Me.lblid_.Text = cmb.SelectedValue.ToString
       End If
   End Sub

   Sub LimpiarControles()
       Me.lblid_voz.Text = "0"
       Me.cmbVoz.Text =  ""
       Me.lblid_tipo_voz.Text = "0"
       Me.cmbTipo_voz.Text =  ""
       Me.txtporcentaje_voz.Text = "0"
       Me.txtporcentaje_tipo_voz.Text = "0"
       Me.lblindice.Text = "0"
       Me.cmbIce.Text =  ""
       Me.lblnro.Text = "0"
       Me.cmb.Text =  ""
   End Sub

   Private Sub ObtenerDatos()
       Me.lblid_voz.Text = oVoz_tipo_voz.id_voz.ToString
       Me.lblid_tipo_voz.Text = oVoz_tipo_voz.id_tipo_voz.ToString
       Me.txtporcentaje_voz.Text = oVoz_tipo_voz.porcentaje_voz.ToString.Trim
       Me.txtporcentaje_tipo_voz.Text = oVoz_tipo_voz.porcentaje_tipo_voz.ToString.Trim
       Me.lblindice.Text = oVoz_tipo_voz.indice.ToString
       Me.lblnro.Text = oVoz_tipo_voz.nro.ToString
   End Sub

   Private Sub AsignarDatos()
       oVoz_tipo_voz.id_voz = CInt(Me.lblid_voz.Text)
       oVoz_tipo_voz.id_tipo_voz = CInt(Me.lblid_tipo_voz.Text)
       oVoz_tipo_voz.porcentaje_voz = CDec(Me.txtporcentaje_voz.Text)
       oVoz_tipo_voz.porcentaje_tipo_voz = CDec(Me.txtporcentaje_tipo_voz.Text)
       oVoz_tipo_voz.indice = CInt(Me.lblindice.Text)
       oVoz_tipo_voz.nro = CInt(Me.lblnro.Text)
   End Sub

   Public Sub SoloLectura()
       Me.cmbVoz.Enabled = False
       Me.btnBuscaVoz.Enabled = False
       Me.cmbTipo_voz.Enabled = False
       Me.btnBuscaTipo_voz.Enabled = False
       Me.txtporcentaje_voz.Enabled = False
       Me.txtporcentaje_tipo_voz.Enabled = False
       Me.cmbIce.Enabled = False
       Me.btnBuscaIce.Enabled = False
       Me.cmb.Enabled = False
       Me.btnBusca.Enabled = False
       Me.btnGuardar.Visible = False
   End Sub

   Private Sub Guardar()
       Try
           Me.AsignarDatos()
           If oVoz_tipo_voz.Exist() Then
               If BanderaVoz_tipo_voz = 1 Then
                   MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
               Exit Sub
               ElseIf BanderaVoz_tipo_voz = 2 Then
                   If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                       = Windows.Forms.DialogResult.No Then
                       Exit Sub
                   End If
               End If
           End If
           Select Case BanderaVoz_tipo_voz
               Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                   oVoz_tipo_voz.Guardar()
                   CType(Me.Owner, frmAbmVoz_tipo_voz).RefrescarGrilla()
                   Me.CargarCombos()
                   oVoz_tipo_voz.Insertar()
                   Me.ObtenerDatos()
                   Me.LimpiarControles()
                   Me.cmbVoz.Focus
               Case 2 'GUARDA Y SALE (MODIFICAR)
                   oVoz_tipo_voz.Guardar()
                   Me.Close()
           End Select
       Catch ex As Exception
           MessageBox.Show(ex.Message)
       End Try
   End Sub

   Private Function ChequearVacios() As Boolean
       Dim bandera As Boolean
       If _ 
       Me.txtporcentaje_voz.Text = "" or _
       Me.txtporcentaje_tipo_voz.Text = "" Then
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
       If CDbl(Me.lblid_tipo_voz.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de tipo_voz")
           Exit Sub
       End If
       If CDbl(Me.lblindice.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de ice")
           Exit Sub
       End If
       If CDbl(Me.lblnro.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de ")
           Exit Sub
       End If

       blnVacios = Me.ChequearVacios
       If blnVacios = False Then
           MessageBox.Show("Debe Llenar los Campos Obligatorios")
           Exit Sub
       Else
           If BanderaVoz_tipo_voz  = 1 Then
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

   Private Sub cmbTipo_voz_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipo_voz.SelectedIndexChanged
       If Me.cmbTipo_voz.SelectedIndex >= 0 Then
           Me.lblid_tipo_voz.Text = cmbTipo_voz.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaTipo_voz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaTipo_voz.Click
       Dim frmTemporal As New FrmAbmTipo_voz
       frmTemporal.ShowDialog()
       Me.CargarTipo_voz()
       Me.cmbTipo_voz.Focus()
       Me.cmbTipo_voz.Text = ""
       Me.lblid_Tipo_voz.Text = "0"
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

   Private Sub cmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb.SelectedIndexChanged
       If Me.cmb.SelectedIndex >= 0 Then
           Me.lblnro.Text = cmb.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBusca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusca.Click
       Dim frmTemporal As New FrmAbm
       frmTemporal.ShowDialog()
       Me.Cargar()
       Me.cmb.Focus()
       Me.cmb.Text = ""
       Me.lblid_.Text = "0"
   End Sub

   Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   'Handles 
       If e.KeyChar.ToString = vbCr Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
   Handles cmbVoz.KeyDown, cmbTipo_voz.KeyDown, cmbIce.KeyDown, cmb.KeyDown
       If CDbl(e.KeyValue.ToString) = 13 Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtporcentaje_voz.KeyPress, txtporcentaje_tipo_voz.KeyPress
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
