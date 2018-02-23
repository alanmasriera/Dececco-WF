Public Class frmDetalleSubtipo_producto

    Private Sub frmDetalleSubtipo_producto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttGeneral.SetToolTip(Me.btnBuscatipo_producto, "Buscar Nuevo Tipo_producto")
        Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Subtipo_producto")
        Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()

            Me.cmbtipo_producto.Text = oTipo_producto.GetOne_2(CInt(Me.lblid_tipo_producto.Text)).Rows(0).Item("nombre_Tipo_producto").ToString.Trim
        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try

        If BanderaSubtipo_producto = 1 Then
            Me.LimpiarControles()
        End If
        Me.Text = "Subtipo_producto"
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False
    End Sub

   Sub CargarCombos()
       Me.CargarTipo_producto
   End Sub

   Sub CargarTipo_producto()
       Dim odt As New DataTable

        odt = oTipo_producto.GeCmb_2
       With Me.cmbTipo_producto
           .DataSource = odt
           .DisplayMember = "nombre_Tipo_producto"
           .ValueMember = "id_Tipo_producto"
       End With
       If Me.cmbTipo_producto.SelectedIndex >= 0 Then
           cmbTipo_producto.SelectedIndex = 0
           Me.lblid_Tipo_producto.Text = cmbTipo_producto.SelectedValue.ToString
       End If
   End Sub

   Sub LimpiarControles()
       Me.txtnombre_subtipo_producto.Text = ""
       Me.lblid_tipo_producto.Text = "0"
       Me.cmbTipo_producto.Text =  ""
       Me.chktilde.Checked = False
   End Sub

   Private Sub ObtenerDatos()
       Me.txtnombre_subtipo_producto.Text = oSubtipo_producto.nombre_subtipo_producto.Trim
       Me.lblid_tipo_producto.Text = oSubtipo_producto.id_tipo_producto.ToString
       Me.chktilde.Checked = oSubtipo_producto.tilde
   End Sub

   Private Sub AsignarDatos()
       oSubtipo_producto.nombre_subtipo_producto = Me.txtnombre_subtipo_producto.Text
       oSubtipo_producto.id_tipo_producto = CInt(Me.lblid_tipo_producto.Text)
       oSubtipo_producto.tilde = Me.chktilde.Checked
   End Sub

    Public Sub SoloLectura()
        Me.txtnombre_subtipo_producto.Enabled = False
        Me.cmbtipo_producto.Enabled = False
        Me.btnBuscatipo_producto.Enabled = False
        Me.chktilde.Enabled = False
        Me.btnGuardar.Visible = False
    End Sub

   Private Sub Guardar()
       Try
           Me.AsignarDatos()
           If oSubtipo_producto.Exist() Then
               If BanderaSubtipo_producto = 1 Then
                   MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
               Exit Sub
               ElseIf BanderaSubtipo_producto = 2 Then
                   If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                       = Windows.Forms.DialogResult.No Then
                       Exit Sub
                   End If
               End If
           End If
           Select Case BanderaSubtipo_producto
               Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                   oSubtipo_producto.Guardar()
                   CType(Me.Owner, frmAbmSubtipo_producto).RefrescarGrilla()
                   Me.CargarCombos()
                   oSubtipo_producto.Insertar()
                   Me.ObtenerDatos()
                   Me.LimpiarControles()
                   Me.txtnombre_subtipo_producto.Focus
               Case 2 'GUARDA Y SALE (MODIFICAR)
                   oSubtipo_producto.Guardar()
                   Me.Close()
           End Select
       Catch ex As Exception
           MessageBox.Show(ex.Message)
       End Try
   End Sub

   Private Function ChequearVacios() As Boolean
       Dim bandera As Boolean
       If Me.txtnombre_subtipo_producto.Text = "" Then
           bandera = False
       Else
           bandera = True
       End If
       Return bandera
   End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean

        If CDbl(Me.lblid_tipo_producto.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de tipo_producto")
            Exit Sub
        End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaSubtipo_producto = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

   Private Sub cmbTipo_producto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipo_producto.SelectedIndexChanged
       If Me.cmbTipo_producto.SelectedIndex >= 0 Then
           Me.lblid_tipo_producto.Text = cmbTipo_producto.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaTipo_producto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaTipo_producto.Click
       Dim frmTemporal As New FrmAbmTipo_producto
       frmTemporal.ShowDialog()
       Me.CargarTipo_producto()
       Me.cmbTipo_producto.Focus()
       Me.cmbTipo_producto.Text = ""
       Me.lblid_Tipo_producto.Text = "0"
   End Sub

   Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtnombre_subtipo_producto.KeyPress, chktilde.KeyPress
       If e.KeyChar.ToString = vbCr Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
   Handles cmbTipo_producto.KeyDown
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


    Private Sub btnBuscatipo_producto_Click_1(sender As System.Object, e As System.EventArgs) Handles btnBuscatipo_producto.Click

    End Sub
End Class
