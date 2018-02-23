Public Class frmDetalleTipo_voz

    Private Sub frmDetalleTipo_voz_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttGeneral.SetToolTip(Me.btnBuscaControl, "Buscar Nuevo Control")
        Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Tipo_voz")
        Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()

            Me.cmbControl.Text = oControl.GetOne(CInt(Me.lblid_Control.Text)).Rows(0).Item("nombre_Control").ToString.Trim
        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try

        If BanderaTipo_voz = 1 Then
            Me.LimpiarControles()
        End If
        Me.Text = "Tipo_voz"
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False
    End Sub

    Sub CargarCombos()
        Me.CargarControl()
    End Sub

    Sub CargarControl()
        Dim odt As New DataTable

        odt = oControl.GetCmb
        With Me.cmbControl
            .DataSource = odt
            .DisplayMember = "nombre_control"
            .ValueMember = "id_control"
        End With
        If Me.cmbControl.SelectedIndex >= 0 Then
            cmbControl.SelectedIndex = 0
            Me.lblid_Control.Text = cmbControl.SelectedValue.ToString
        End If
    End Sub

    Sub LimpiarControles()
        Me.txtnombre_tipo_voz.Text = ""
        Me.txtcodigo.Text = ""
        Me.txtponderacion.Text = ""
        Me.lblid_control.Text = "0"
        Me.cmbControl.Text = ""
    End Sub

    Private Sub ObtenerDatos()
        Me.txtnombre_tipo_voz.Text = oTipo_voz.nombre_tipo_voz.Trim
        Me.txtcodigo.Text = oTipo_voz.codigo.Trim
        Me.txtponderacion.Text = oTipo_voz.ponderacion.ToString.Trim
        Me.lblid_control.Text = oTipo_voz.id_control.ToString
    End Sub

    Private Sub AsignarDatos()
        oTipo_voz.nombre_tipo_voz = Me.txtnombre_tipo_voz.Text
        oTipo_voz.codigo = Me.txtcodigo.Text
        oTipo_voz.ponderacion = CDec(Me.txtponderacion.Text)
        oTipo_voz.id_control = CInt(Me.lblid_control.Text)
    End Sub

    Public Sub SoloLectura()
        Me.txtnombre_tipo_voz.Enabled = False
        Me.txtcodigo.Enabled = False
        Me.txtponderacion.Enabled = False
        Me.cmbControl.Enabled = False
        Me.btnBuscaControl.Enabled = False
        Me.btnGuardar.Visible = False
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            If oTipo_voz.Exist() Then
                If BanderaTipo_voz = 1 Then
                    MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
                    Exit Sub
                ElseIf BanderaTipo_voz = 2 Then
                    If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                        = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            Select Case BanderaTipo_voz
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oTipo_voz.Guardar()
                    CType(Me.Owner, frmAbmTipo_voz).RefrescarGrilla()
                    Me.CargarCombos()
                    oTipo_voz.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.txtnombre_tipo_voz.Focus()
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oTipo_voz.Guardar()
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If Me.txtnombre_tipo_voz.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean

        If CDbl(Me.lblid_control.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de control")
            Exit Sub
        End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaTipo_voz = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cmbControl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcontrol.SelectedIndexChanged
        If Me.cmbControl.SelectedIndex >= 0 Then
            Me.lblid_control.Text = cmbControl.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscacontrol.Click
        Dim frmTemporal As New FrmAbmControl
        frmTemporal.ShowDialog()
        Me.CargarControl()
        Me.cmbControl.Focus()
        Me.cmbControl.Text = ""
        Me.lblid_Control.Text = "0"
    End Sub

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtnombre_tipo_voz.KeyPress, txtcodigo.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles cmbcontrol.KeyDown
        If CDbl(e.KeyValue.ToString) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
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

   

End Class
