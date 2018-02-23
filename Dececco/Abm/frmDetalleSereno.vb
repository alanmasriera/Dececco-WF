Public Class frmDetalleSereno

   Private Sub frmDetalleSereno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Sereno")
       Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
       Try
           ObtenerDatos()

       Catch ex As Exception
           '    MessageBox.Show(ex.Message)
       End Try

       If BanderaSereno  = 1 Then
           Me.LimpiarControles()
       End If
        Me.Text = "Sereno" & NombreFormulario
       Me.CancelButton = Me.btnSalir
       Me.BackColor = Color.Gainsboro
       Me.StartPosition = FormStartPosition.CenterScreen
       Me.MinimizeBox = False
       Me.MaximizeBox = False
   End Sub

   Sub CargarCombos()
   End Sub

   Sub LimpiarControles()
       Me.txtsueldo_sereno.Text = ""
       Me.txtcontribucion_extraordinaria.Text = ""
       Me.txtaporte_solidario.Text = ""
       Me.txtayuda_escolar.Text = ""
       Me.txtvalor_discapacitado.Text = ""
       Me.txthora_administrativo.Text = ""
       Me.txtvalor_embargo.Text = ""
   End Sub

   Private Sub ObtenerDatos()
       Me.txtsueldo_sereno.Text = oSereno.sueldo_sereno.ToString.Trim
       Me.txtcontribucion_extraordinaria.Text = oSereno.contribucion_extraordinaria.ToString.Trim
       Me.txtaporte_solidario.Text = oSereno.aporte_solidario.ToString.Trim
       Me.txtayuda_escolar.Text = oSereno.ayuda_escolar.ToString.Trim
       Me.txtvalor_discapacitado.Text = oSereno.valor_discapacitado.ToString.Trim
       Me.txthora_administrativo.Text = oSereno.hora_administrativo.ToString.Trim
       Me.txtvalor_embargo.Text = oSereno.valor_embargo.ToString.Trim
   End Sub

   Private Sub AsignarDatos()
       oSereno.sueldo_sereno = CDec(Me.txtsueldo_sereno.Text)
       oSereno.contribucion_extraordinaria = CDec(Me.txtcontribucion_extraordinaria.Text)
       oSereno.aporte_solidario = CDec(Me.txtaporte_solidario.Text)
       oSereno.ayuda_escolar = CDec(Me.txtayuda_escolar.Text)
       oSereno.valor_discapacitado = CDec(Me.txtvalor_discapacitado.Text)
       oSereno.hora_administrativo = CDec(Me.txthora_administrativo.Text)
       oSereno.valor_embargo = CDec(Me.txtvalor_embargo.Text)
   End Sub

   Public Sub SoloLectura()
       Me.txtsueldo_sereno.Enabled = False
       Me.txtcontribucion_extraordinaria.Enabled = False
       Me.txtaporte_solidario.Enabled = False
       Me.txtayuda_escolar.Enabled = False
       Me.txtvalor_discapacitado.Enabled = False
       Me.txthora_administrativo.Enabled = False
       Me.txtvalor_embargo.Enabled = False
       Me.btnGuardar.Visible = False
   End Sub

   Private Sub Guardar()
       Try
           Me.AsignarDatos()
           If oSereno.Exist() Then
               If BanderaSereno = 1 Then
                   MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
               Exit Sub
               ElseIf BanderaSereno = 2 Then
                   If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                       = Windows.Forms.DialogResult.No Then
                       Exit Sub
                   End If
               End If
           End If
           Select Case BanderaSereno
               Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                   oSereno.Guardar()
                   CType(Me.Owner, frmAbmSereno).RefrescarGrilla()
                   Me.CargarCombos()
                   oSereno.Insertar()
                   Me.ObtenerDatos()
                   Me.LimpiarControles()
                   Me.txtsueldo_sereno.Focus
               Case 2 'GUARDA Y SALE (MODIFICAR)
                   oSereno.Guardar()
                   Me.Close()
           End Select
       Catch ex As Exception
           MessageBox.Show(ex.Message)
       End Try
   End Sub

   Private Function ChequearVacios() As Boolean
       Dim bandera As Boolean
       If Me.txtsueldo_sereno.Text = "" Then
           bandera = False
       Else
           bandera = True
       End If
       Return bandera
   End Function

   Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
       Dim blnVacios As Boolean


       blnVacios = Me.ChequearVacios
       If blnVacios = False Then
           MessageBox.Show("Debe Llenar los Campos Obligatorios")
           Exit Sub
       Else
           If BanderaSereno  = 1 Then
               Me.Guardar()
           Else
               Me.Guardar()
           End If
       End If
   End Sub

   Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
       Me.Close()
   End Sub

   Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   'Handles 
       If e.KeyChar.ToString = vbCr Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
   'Handles 
       If CDbl(e.KeyValue.ToString) = 13 Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtsueldo_sereno.KeyPress, txtcontribucion_extraordinaria.KeyPress, txtaporte_solidario.KeyPress, txtayuda_escolar.KeyPress, txtvalor_discapacitado.KeyPress, txthora_administrativo.KeyPress, txtvalor_embargo.KeyPress
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
