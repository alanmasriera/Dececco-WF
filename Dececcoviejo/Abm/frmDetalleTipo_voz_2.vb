Public Class frmDetalleTipo_voz_2
    Dim odt As DataTable
    Private Sub frmDetalleTipo_voz_2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        odt = oTipo_voz.GetOne(CInt(CType(Me.Owner, frmMainControl).lblid_tipo_voz.Text))
        Try
            Me.lblId_tipo_voz.Text = CType(Me.Owner, frmMainControl).lblid_tipo_voz.Text
            Me.txtponderacion.Text = CStr(odt.Rows(0)("ponderacion"))
            Me.chk_pond_manual.Checked = CBool(odt.Rows(0)("pond_manual"))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        If (Me.txtponderacion.Text) = "" Then
            MsgBox("INTRODUSCA UN VALOR A PONDERACION")
            Me.txtponderacion.Focus()
        Else
            Try
                With oTipo_voz
                    .Cargar()
                    .Modificar(CInt(Me.lblId_tipo_voz.Text))
                    .ponderacion = CDec(Me.txtponderacion.Text)
                    .pond_manual = chk_pond_manual.Checked
                    .Guardar()
                End With
            Catch ex As Exception
            End Try
            Me.Close()
        End If
    End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtponderacion.KeyPress
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

   
    Private Sub chk_pond_manual_CheckedChanged(sender As Object, e As EventArgs) Handles chk_pond_manual.CheckedChanged
        If chk_pond_manual.Checked = True Then
            'cambiar esto por tipo_voz
            If oTipo_voz.verificarIntegridadPorcentaje(CInt(CType(Me.Owner, frmMainControl).lblid_control.Text), CInt(CType(Me.Owner, frmMainControl).lblid_tipo_voz.Text)) = True Then
                txtponderacion.Enabled = True
            Else
                MessageBox.Show("Todas las demás voces del control seleccionado tienen ponderaciones manuales, al menos una debe ser automática.", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                chk_pond_manual.Checked = False
            End If

        Else
            txtponderacion.Enabled = False
        End If
    End Sub
End Class