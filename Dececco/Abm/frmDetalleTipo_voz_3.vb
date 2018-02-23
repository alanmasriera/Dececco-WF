Public Class frmDetalleTipo_voz_3
    Dim odt As DataTable

    Private Sub frmDetalleTipo_voz_3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        odt = oTipo_voz.GetOne(CInt(CType(Me.Owner, frmMainControl).lblid_tipo_voz.Text))
        Try
            Me.lblId_tipo_voz.Text = CType(Me.Owner, frmMainControl).lblid_tipo_voz.Text
            Me.txtnombre_tipo_voz.Text = CStr(odt.Rows(0)("Nombre tipo voz"))
            Me.txtcodigo.Text = CStr(odt.Rows(0)("Codigo"))
        Catch ex As Exception
        End Try
        Me.txtcodigo.Enabled = False
        Me.txtnombre_tipo_voz.Focus()
    End Sub
  
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        BanderaTipo_voz = 0
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        If (Me.txtnombre_tipo_voz.Text) = "" Then
            MsgBox("INTRODUSCA UN NOMBRE AL TIPO DE VOZ")
            Me.txtnombre_tipo_voz.Focus()
        else
        Try
            With oTipo_voz
                .Cargar()
                .Modificar(CInt(Me.lblId_tipo_voz.Text))
                .nombre_tipo_voz = Me.txtnombre_tipo_voz.Text
                .Guardar()
            End With
        Catch ex As Exception
        End Try
            Me.Close()
        End If
    End Sub

    'Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    'Handles txtponderacion.KeyPress
    '    Dim txtTemp As TextBox
    '    txtTemp = CType(sender, TextBox)

    '    If e.KeyChar.ToString = vbCr Then
    '        Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
    '    End If
    '    If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Then
    '        If InStr(txtTemp.Text, ",") <> 0 Then
    '            e.Handled = True
    '        Else
    '            e.KeyChar = CChar(",")
    '        End If
    '    End If

    '    Dim Largo As Integer = InStr(txtTemp.Text, ",")

    '    If txtTemp.Text.Length > Largo + 2 And Largo <> 0 And e.KeyChar.ToString <> vbBack Then
    '        e.Handled = True
    '    End If

    '    If (e.KeyChar.ToString >= "0" And e.KeyChar.ToString <= "9") Or e.KeyChar.ToString = "," Or e.KeyChar = vbBack Then
    '        '  e.Handled = False
    '    Else
    '        e.Handled = True
    '    End If
    'End Sub

End Class