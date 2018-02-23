Public Class frmDetalleVoz

   Private Sub frmDetalleVoz_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Voz")
       Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
       Try
           ObtenerDatos()

       Catch ex As Exception
           '    MessageBox.Show(ex.Message)
       End Try

       If BanderaVoz  = 1 Then
           Me.LimpiarControles()
       End If
       Me.Text = "Voz"
       Me.CancelButton = Me.btnSalir
       Me.BackColor = Color.Gainsboro
       Me.StartPosition = FormStartPosition.CenterScreen
       Me.MinimizeBox = False
       Me.MaximizeBox = False
   End Sub

   Sub CargarCombos()
   End Sub

   Sub LimpiarControles()
       Me.txtnombre_voz.Text = ""
       Me.txticono.Text = ""
       Me.txtcodigo.Text = ""
       Me.txtcodigo_2.Text = ""
       Me.txtponderacion.Text = ""
       Me.txtrandom.Text = ""
   End Sub

   Private Sub ObtenerDatos()
       Me.txtnombre_voz.Text = oVoz.nombre_voz.Trim
       Me.txticono.Text = oVoz.icono.Trim
       Me.txtcodigo.Text = oVoz.codigo.Trim
       Me.txtcodigo_2.Text = oVoz.codigo_2.Trim
       Me.txtponderacion.Text = oVoz.ponderacion.ToString.Trim
       Me.txtrandom.Text = oVoz.random.ToString.Trim
   End Sub

   Private Sub AsignarDatos()
       oVoz.nombre_voz = Me.txtnombre_voz.Text
       oVoz.icono = Me.txticono.Text
       oVoz.codigo = Me.txtcodigo.Text
       oVoz.codigo_2 = Me.txtcodigo_2.Text
       oVoz.ponderacion = CDec(Me.txtponderacion.Text)
       oVoz.random = CDec(Me.txtrandom.Text)
   End Sub

   Public Sub SoloLectura()
       Me.txtnombre_voz.Enabled = False
       Me.txticono.Enabled = False
       Me.txtcodigo.Enabled = False
       Me.txtcodigo_2.Enabled = False
       Me.txtponderacion.Enabled = False
       Me.txtrandom.Enabled = False
       Me.btnGuardar.Visible = False
   End Sub

   Private Sub Guardar()
       Try
           Me.AsignarDatos()
           If oVoz.Exist() Then
               If BanderaVoz = 1 Then
                   MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
               Exit Sub
               ElseIf BanderaVoz = 2 Then
                    If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                       = System.Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            Select Case BanderaVoz
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oVoz.Guardar()
                    CType(Me.Owner, frmAbmVoz).RefrescarGrilla()
                    Me.CargarCombos()
                    oVoz.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.txtnombre_voz.Focus()
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oVoz.Guardar()
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If Me.txtnombre_voz.Text = "" Then
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
            If BanderaVoz = 1 Then
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
   Handles txtnombre_voz.KeyPress, txticono.KeyPress, txtcodigo.KeyPress, txtcodigo_2.KeyPress
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
   Handles txtponderacion.KeyPress, txtrandom.KeyPress
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

    'agregado para cuando en el arbol seleccionan modificar voz
    Public Sub noVisibles()
        Me.etiquetacodigo.Visible = False
        Me.etiquetacodigo_2.Visible = False
        Me.etiquetaponderacion.Visible = False
        Me.etiquetarandom.Visible = False
        Me.txtcodigo_2.Visible = False
        Me.txtcodigo.Visible = False
        Me.txtponderacion.Visible = False
        Me.txtrandom.Visible = False
    End Sub
    Public Sub cambioPorcentaje()
        Me.txtnombre_voz.Enabled = False
        Me.txticono.Enabled = False
        Me.etiquetacodigo.Visible = False
        Me.etiquetacodigo_2.Visible = False
        Me.etiquetaponderacion.Visible = False
        Me.etiquetarandom.Visible = False
        Me.txtcodigo_2.Visible = False
        Me.txtcodigo.Visible = False
        Me.txtponderacion.Visible = True
        Me.txtrandom.Visible = False
    End Sub

End Class
