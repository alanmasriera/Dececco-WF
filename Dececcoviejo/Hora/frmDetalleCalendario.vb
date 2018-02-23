Public Class frmDetalleCalendario

    Private Sub frmDetalleCalendario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttGeneral.SetToolTip(Me.btnBuscaDia, "Buscar Nuevo Dia")
        Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Calendario")
        Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()

            Me.cmbDia.Text = oDia.GetOne(CInt(Me.lblid_Dia.Text)).Rows(0).Item("nombre_Dia").ToString.Trim
        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try

        If BanderaCalendario = 1 Then
            Me.LimpiarControles()
        End If
        Me.Text = "Calendario" & vgNombreFormulario
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False
    End Sub

    Sub CargarCombos()
        Me.CargarDia()
    End Sub

    Sub CargarDia()
        Dim odt As New DataTable

        odt = oDia.GetCmb
        With Me.cmbDia
            .DataSource = odt
            .DisplayMember = "nombre_dia"
            .ValueMember = "id_dia"
        End With
        If Me.cmbDia.SelectedIndex >= 0 Then
            cmbDia.SelectedIndex = 0
            Me.lblid_Dia.Text = cmbDia.SelectedValue.ToString
        End If
    End Sub

    Sub LimpiarControles()
        Me.dtpfecha.Value = DateTime.Now
        Me.lblid_dia.Text = "0"
        Me.cmbDia.Text = ""
        Me.txtanio.Text = ""
    End Sub

    Private Sub ObtenerDatos()
        Me.dtpfecha.Value = oCalendario.fecha
        Me.lblid_dia.Text = oCalendario.id_dia.ToString
        Me.txtanio.Text = oCalendario.fecha.Year.ToString()
    End Sub

    Private Sub AsignarDatos()
        oCalendario.fecha = Me.dtpfecha.Value.Date
        oCalendario.id_dia = CInt(Me.lblid_dia.Text)
        'oCalendario.anio = CDec(Me.txtanio.Text)
    End Sub

    Public Sub SoloLectura()
        Me.dtpfecha.Enabled = False
        Me.cmbDia.Enabled = False
        Me.btnBuscaDia.Enabled = False
        Me.txtanio.Enabled = False
        Me.btnGuardar.Visible = False
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            If oCalendario.Exist() Then
                If BanderaCalendario = 1 Then
                    MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
                    Exit Sub
                ElseIf BanderaCalendario = 2 Then
                    If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                        = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            Select Case BanderaCalendario
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oCalendario.Guardar()
                    CType(Me.Owner, frmAbmCalendario).RefrescarGrilla()
                    Me.CargarCombos()
                    oCalendario.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.dtpfecha.Focus()
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oCalendario.Guardar()
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If Me.txtanio.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean

        If CDbl(Me.lblid_dia.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de dia")
            Exit Sub
        End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaCalendario = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cmbDia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdia.SelectedIndexChanged
        If Me.cmbDia.SelectedIndex >= 0 Then
            Me.lblid_dia.Text = cmbDia.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaDia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscadia.Click
        Dim frmTemporal As New FrmAbmDia
        frmTemporal.ShowDialog()
        Me.CargarDia()
        Me.cmbDia.Focus()
        Me.cmbDia.Text = ""
        Me.lblid_Dia.Text = "0"
    End Sub

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    'Handles 
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles dtpfecha.KeyDown, cmbdia.KeyDown
        If CDbl(e.KeyValue.ToString) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtanio.KeyPress
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
