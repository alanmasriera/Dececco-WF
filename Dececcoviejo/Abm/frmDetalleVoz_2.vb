﻿Public Class frmDetalleVoz_2

    Private Sub frmDetalleVoz_2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Voz")
        Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")

        Try
            ObtenerDatos()
        Catch ex As Exception

        End Try

        If BanderaVoz = 1 Then
            Me.LimpiarControles()
        End If
        Me.Text = "Voz"
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False
    End Sub


    Sub LimpiarControles()
        Me.txtnombre_voz.Text = ""
        Me.txticono.Text = ""
        Me.txtponderacion.Text = ""
    End Sub

    Private Sub ObtenerDatos()
        Me.txtnombre_voz.Text = oVoz.nombre_voz.Trim
        Me.txticono.Text = oVoz.icono.Trim
        Me.txtponderacion.Text = oVoz.ponderacion.ToString.Trim
        Me.chk_pond_manual.Checked = oVoz.pond_manual
        Me.txtrango.Text = oVoz.rango.ToString.Trim
    End Sub

    Private Sub AsignarDatos()
        oVoz.nombre_voz = Me.txtnombre_voz.Text
        oVoz.icono = Me.txticono.Text
        oVoz.ponderacion = CDec(Me.txtponderacion.Text)
        oVoz.pond_manual = chk_pond_manual.Checked
        oVoz.rango = CDec(Me.txtrango.Text)
    End Sub

    Public Sub SoloLectura()
        Me.txtnombre_voz.Enabled = False
        Me.txticono.Enabled = False
        Me.txtponderacion.Enabled = False
        Me.btnGuardar.Visible = False
        Me.chk_pond_manual.Enabled = False
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            If oVoz.Exist() Then
                If BanderaVoz = 1 Then
                    MessageBox.Show("Los datos que pretende ingresar ya fueron cargados en el sistema")
                    Exit Sub
                ElseIf BanderaVoz = 2 Then
                    If MessageBox.Show("Los datos que desea modificar ya existen, ¿Desea reemplazarlos?", "Modificar", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                        = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            Select Case BanderaVoz
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oVoz.Guardar()
                    CType(Me.Owner, frmAbmVoz).RefrescarGrilla()
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


    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        BanderaVoz = 0
        Me.Close()
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    'Handles 
        If CDbl(e.KeyValue.ToString) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtponderacion.KeyPress ', txtrandom.KeyPress
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

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
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
    Public Sub activar(ByVal acti_ponderacion As Boolean, ByVal acti_nombre As Boolean)
        Me.txtnombre_voz.Enabled = acti_nombre
        Me.txtponderacion.Enabled = acti_ponderacion
        Me.chk_pond_manual.Enabled = acti_ponderacion
    End Sub

    Private Sub chk_pond_manual_CheckedChanged(sender As Object, e As EventArgs) Handles chk_pond_manual.CheckedChanged
        If chk_pond_manual.Checked = True Then
            If oVoz_tipo_voz.verificarIntegridadPorcentaje(CInt(CType(Me.Owner, frmMainControl).lblid_tipo_voz.Text), CInt(CType(Me.Owner, frmMainControl).lblid_voz.Text)) = True Then
                txtponderacion.Enabled = True
            Else
                MessageBox.Show("Todas las demás voces del control seleccionado tienen ponderaciones manuales, al menos una debe ser automática.", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                chk_pond_manual.Checked = False
            End If

        Else
            txtponderacion.Enabled = False
        End If
    End Sub

    Private Sub txtrango_KeyDown(sender As Object, e As EventArgs) Handles txtrango.KeyDown
        btnGuardar.Focus()

    End Sub

    Private Sub txtrango_KeyDown(sender As Object, e As KeyEventArgs) Handles txtrango.KeyDown

    End Sub
End Class