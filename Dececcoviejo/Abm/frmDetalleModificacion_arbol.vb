Public Class frmDetalleModificacion_arbol

    Private Sub frmDetalleModificacion_arbol_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttGeneral.SetToolTip(Me.btnBuscausuario, "Buscar Nuevo Usuario")
        Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Modificacion_arbol")
        Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()

            Me.cmbusuario.Text = oUsuario.GetOne(CInt(Me.lblid_usuario.Text)).Rows(0).Item("nombre Usuario").ToString.Trim
        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try

        If BanderaModificacion_arbol = 1 Then
            Me.LimpiarControles()
        End If
        Me.Text = "Modificacion_arbol" & vgNombreFormulario
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False
    End Sub

   Sub CargarCombos()
       Me.CargarUsuario
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
       Me.txtnombre_modificacion_arbol.Text = ""
       Me.lblid_usuario.Text = "0"
       Me.cmbUsuario.Text =  ""
       Me.chkrealizado.Checked = False
   End Sub

   Private Sub ObtenerDatos()
       Me.txtnombre_modificacion_arbol.Text = oModificacion_arbol.nombre_modificacion_arbol.Trim
       Me.lblid_usuario.Text = oModificacion_arbol.id_usuario.ToString
       Me.chkrealizado.Checked = oModificacion_arbol.realizado
   End Sub

   Private Sub AsignarDatos()
       oModificacion_arbol.nombre_modificacion_arbol = Me.txtnombre_modificacion_arbol.Text
       oModificacion_arbol.id_usuario = CInt(Me.lblid_usuario.Text)
       oModificacion_arbol.realizado = Me.chkrealizado.Checked
   End Sub

   Public Sub SoloLectura()
       Me.txtnombre_modificacion_arbol.Enabled = False
       Me.cmbUsuario.Enabled = False
       Me.btnBuscaUsuario.Enabled = False
       Me.chkrealizado.Enabled = False
       Me.btnGuardar.Visible = False
   End Sub

   Private Sub Guardar()
       Try
           Me.AsignarDatos()
           If oModificacion_arbol.Exist() Then
               If BanderaModificacion_arbol = 1 Then
                   MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
               Exit Sub
               ElseIf BanderaModificacion_arbol = 2 Then
                   If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                       = Windows.Forms.DialogResult.No Then
                       Exit Sub
                   End If
               End If
           End If
           Select Case BanderaModificacion_arbol
               Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                   oModificacion_arbol.Guardar()
                   CType(Me.Owner, frmAbmModificacion_arbol).RefrescarGrilla()
                   Me.CargarCombos()
                   oModificacion_arbol.Insertar()
                   Me.ObtenerDatos()
                   Me.LimpiarControles()
                   Me.txtnombre_modificacion_arbol.Focus
               Case 2 'GUARDA Y SALE (MODIFICAR)
                   oModificacion_arbol.Guardar()
                   Me.Close()
           End Select
       Catch ex As Exception
           MessageBox.Show(ex.Message)
       End Try
   End Sub

   Private Function ChequearVacios() As Boolean
       Dim bandera As Boolean
       If _ 
       Me.txtnombre_modificacion_arbol.Text = "" Then
           bandera = False
       Else
           bandera = True
       End If
       Return bandera
   End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean

        If CDbl(Me.lblid_usuario.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de usuario")
            Exit Sub
        End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaModificacion_arbol = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
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
   Handles txtnombre_modificacion_arbol.KeyPress, chkrealizado.KeyPress
       If e.KeyChar.ToString = vbCr Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
   Handles cmbUsuario.KeyDown
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
