Public Class frmDetalleTipo_producto

    Private Sub frmDetalleTipo_producto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttGeneral.SetToolTip(Me.btnBuscagrupo_producto, "Buscar Nuevo Grupo_producto")
        Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Tipo_producto")
        Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()

            Me.cmbgrupo_producto.Text = oGrupo_producto.GetOne(CInt(Me.lblid_grupo_producto.Text)).Rows(0).Item("nombre Grupo producto").ToString.Trim
        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try

        If BanderaTipo_producto = 1 Then
            Me.LimpiarControles()
        End If
        Me.Text = "Tipo_producto"
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False
    End Sub

   Sub CargarCombos()
       Me.CargarGrupo_producto
   End Sub

   Sub CargarGrupo_producto()
       Dim odt As New DataTable

       odt = oGrupo_producto.GetCmb
       With Me.cmbGrupo_producto
           .DataSource = odt
           .DisplayMember = "nombre_Grupo_producto"
           .ValueMember = "id_Grupo_producto"
       End With
       If Me.cmbGrupo_producto.SelectedIndex >= 0 Then
           cmbGrupo_producto.SelectedIndex = 0
           Me.lblid_Grupo_producto.Text = cmbGrupo_producto.SelectedValue.ToString
       End If
   End Sub

   Sub LimpiarControles()
       Me.txtnombre_tipo_producto.Text = ""
       Me.lblid_grupo_producto.Text = "0"
       Me.cmbGrupo_producto.Text =  ""
       Me.chktilde.Checked = False
   End Sub

   Private Sub ObtenerDatos()
       Me.txtnombre_tipo_producto.Text = oTipo_producto.nombre_tipo_producto.Trim
       Me.lblid_grupo_producto.Text = oTipo_producto.id_grupo_producto.ToString
       Me.chktilde.Checked = oTipo_producto.tilde
   End Sub

   Private Sub AsignarDatos()
       oTipo_producto.nombre_tipo_producto = Me.txtnombre_tipo_producto.Text
       oTipo_producto.id_grupo_producto = CInt(Me.lblid_grupo_producto.Text)
       oTipo_producto.tilde = Me.chktilde.Checked
   End Sub

   Public Sub SoloLectura()
       Me.txtnombre_tipo_producto.Enabled = False
       Me.cmbGrupo_producto.Enabled = False
       Me.btnBuscaGrupo_producto.Enabled = False
       Me.chktilde.Enabled = False
       Me.btnGuardar.Visible = False
   End Sub

   Private Sub Guardar()
       Try
           Me.AsignarDatos()
           If oTipo_producto.Exist() Then
               If BanderaTipo_producto = 1 Then
                   MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
               Exit Sub
               ElseIf BanderaTipo_producto = 2 Then
                   If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                       = Windows.Forms.DialogResult.No Then
                       Exit Sub
                   End If
               End If
           End If
           Select Case BanderaTipo_producto
               Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                   oTipo_producto.Guardar()
                   CType(Me.Owner, frmAbmTipo_producto).RefrescarGrilla()
                   Me.CargarCombos()
                   oTipo_producto.Insertar()
                   Me.ObtenerDatos()
                   Me.LimpiarControles()
                   Me.txtnombre_tipo_producto.Focus
               Case 2 'GUARDA Y SALE (MODIFICAR)
                   oTipo_producto.Guardar()
                   Me.Close()
           End Select
       Catch ex As Exception
           MessageBox.Show(ex.Message)
       End Try
   End Sub

   Private Function ChequearVacios() As Boolean
       Dim bandera As Boolean
       If Me.txtnombre_tipo_producto.Text = "" Then
           bandera = False
       Else
           bandera = True
       End If
       Return bandera
   End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean

        If CDbl(Me.lblid_grupo_producto.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de grupo_producto")
            Exit Sub
        End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaTipo_producto = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

   Private Sub cmbGrupo_producto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGrupo_producto.SelectedIndexChanged
       If Me.cmbGrupo_producto.SelectedIndex >= 0 Then
           Me.lblid_grupo_producto.Text = cmbGrupo_producto.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaGrupo_producto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaGrupo_producto.Click
       Dim frmTemporal As New FrmAbmGrupo_producto
       frmTemporal.ShowDialog()
       Me.CargarGrupo_producto()
       Me.cmbGrupo_producto.Focus()
       Me.cmbGrupo_producto.Text = ""
       Me.lblid_Grupo_producto.Text = "0"
   End Sub

   Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtnombre_tipo_producto.KeyPress, chktilde.KeyPress
       If e.KeyChar.ToString = vbCr Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
   Handles cmbGrupo_producto.KeyDown
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
