Public Class frmDetalleEgreso_efectivo_proveedor

    Private Sub frmDetalleEgreso_efectivo_proveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Me.ttGeneral.SetToolTip(Me.btnBuscaRecibo_proveedor, "Buscar Nuevo Recibo_proveedor")
        Me.ttGeneral.SetToolTip(Me.btnBuscaEgreso_efectivo, "Buscar Nuevo Egreso_efectivo")
        Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Egreso_efectivo_proveedor")
        Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()

            ' Me.cmbRecibo_proveedor.Text = oRecibo_proveedor.GetOne(CInt(Me.lblid_Recibo_proveedor.Text)).Rows(0).Item("nombre Recibo_proveedor").ToString.Trim
            Me.cmbegreso_efectivo.Text = oEgreso_efectivo.GetOne(CInt(Me.lblid_egreso_efectivo.Text)).Rows(0).Item("nombre Egreso efectivo").ToString.Trim
            Me.lblid_recibo_proveedor.Text = CType(Me.Owner, frmDetalleRecibo_proveedor).lblid_recibo_proveedor.Text
        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try

        If BanderaEgreso_efectivo_proveedor = 1 Then
            Me.LimpiarControles()
        End If
        Me.Text = "Egreso_efectivo_proveedor" & vgNombreFormulario
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False

        Me.lblid_recibo_proveedor.Text = CType(Me.Owner, frmDetalleRecibo_proveedor).lblid_recibo_proveedor.Text
        Me.lblid_proveedor.Text = CType(Me.Owner, frmDetalleRecibo_proveedor).lblid_proveedor.Text
    End Sub

    Sub CargarCombos()
        ' Me.CargarRecibo_proveedor
        Me.CargarEgreso_efectivo()
    End Sub

    'Sub CargarRecibo_proveedor()
    '    Dim odt As New DataTable

    '    odt = oRecibo_proveedor.GetCmb
    '    With Me.cmbRecibo_proveedor
    '        .DataSource = odt
    '        .DisplayMember = "nombre_recibo_proveedor"
    '        .ValueMember = "id_recibo_proveedor"
    '    End With
    '    If Me.cmbRecibo_proveedor.SelectedIndex >= 0 Then
    '        cmbRecibo_proveedor.SelectedIndex = 0
    '        Me.lblid_Recibo_proveedor.Text = cmbRecibo_proveedor.SelectedValue.ToString
    '    End If
    'End Sub

    Sub CargarEgreso_efectivo()
        Dim odt As New DataTable

        odt = oEgreso_efectivo.GetCmb_2(CInt(Me.lblid_proveedor.Text))
        With Me.cmbEgreso_efectivo
            .DataSource = odt
            .DisplayMember = "nombre_egreso_efectivo"
            .ValueMember = "id_egreso_efectivo"
        End With
        If Me.cmbEgreso_efectivo.SelectedIndex >= 0 Then
            cmbEgreso_efectivo.SelectedIndex = 0
            Me.lblid_Egreso_efectivo.Text = cmbEgreso_efectivo.SelectedValue.ToString
        End If
    End Sub

    Sub LimpiarControles()
        Me.lblid_recibo_proveedor.Text = "0"
        '  Me.cmbRecibo_proveedor.Text =  ""
        Me.lblid_egreso_efectivo.Text = "0"
        Me.cmbEgreso_efectivo.Text = ""
        Me.txtimporte_pagado.Text = "0"
        Me.chkcontrol.Checked = False
    End Sub

    Private Sub ObtenerDatos()
        'Me.lblid_recibo_proveedor.Text = oEgreso_efectivo_proveedor.id_recibo_proveedor.ToString
        Me.lblid_egreso_efectivo.Text = oEgreso_efectivo_proveedor.id_egreso_efectivo.ToString
        Me.txtimporte_pagado.Text = oEgreso_efectivo_proveedor.importe_pagado.ToString.Trim
        Me.chkcontrol.Checked = oEgreso_efectivo_proveedor.control
    End Sub

    Private Sub AsignarDatos()
        oEgreso_efectivo_proveedor.id_recibo_proveedor = CInt(Me.lblid_recibo_proveedor.Text)
        oEgreso_efectivo_proveedor.id_egreso_efectivo = CInt(Me.lblid_egreso_efectivo.Text)
        oEgreso_efectivo_proveedor.importe_pagado = CDec(Me.txtimporte_pagado.Text)
        oEgreso_efectivo_proveedor.control = Me.chkcontrol.Checked
    End Sub

    Public Sub SoloLectura()
        ' Me.cmbRecibo_proveedor.Enabled = False
        ' Me.btnBuscaRecibo_proveedor.Enabled = False
        Me.cmbEgreso_efectivo.Enabled = False
        Me.btnBuscaEgreso_efectivo.Enabled = False
        Me.txtimporte_pagado.Enabled = False
        Me.chkcontrol.Enabled = False
        Me.btnGuardar.Visible = False
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            If oEgreso_efectivo_proveedor.Exist_2 Then
                If BanderaEgreso_efectivo_proveedor = 1 Then
                    MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
                    Exit Sub
                ElseIf BanderaEgreso_efectivo_proveedor = 2 Then
                    If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                        = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            Select Case BanderaEgreso_efectivo_proveedor
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oEgreso_efectivo_proveedor.Guardar()

                    CType(Me.Owner, frmDetalleRecibo_proveedor).RefrescarGrillaEgresoEfectivoProveedor()
                    Me.CargarCombos()
                    oEgreso_efectivo_proveedor.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.cmbegreso_efectivo.Focus()
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oEgreso_efectivo_proveedor.Guardar()
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If _
        Me.txtimporte_pagado.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean

        'If CDbl(Me.lblid_recibo_proveedor.Text) = 0 Then
        '    MessageBox.Show("Debe Seleccionar un Dato del Combo de recibo_proveedor")
        '    Exit Sub
        'End If
        If CDbl(Me.lblid_egreso_efectivo.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de egreso_efectivo")
            Exit Sub
        End If

        If Me.txtimporte_pagado.Text = "" Then
            MessageBox.Show("debe ingresar el importe_pagado")
            Me.txtimporte_pagado.Focus()
            Exit Sub
        End If
        If Not Me.txtSaldo.Text = "" Then
            If CDec(Me.txtimporte_pagado.Text) > CDec(Me.txtSaldo.Text) Then
                MessageBox.Show("El importe pagado supera el Total de los Egresos")
                Me.txtimporte_pagado.Focus()
                Exit Sub
            End If
        End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaEgreso_efectivo_proveedor = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    'Private Sub cmbRecibo_proveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRecibo_proveedor.SelectedIndexChanged
    '    If Me.cmbRecibo_proveedor.SelectedIndex >= 0 Then
    '        Me.lblid_recibo_proveedor.Text = cmbRecibo_proveedor.SelectedValue.ToString
    '    End If
    'End Sub

    'Private Sub btnBuscaRecibo_proveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaRecibo_proveedor.Click
    '    Dim frmTemporal As New FrmAbmRecibo_proveedor
    '    frmTemporal.ShowDialog()
    '    Me.CargarRecibo_proveedor()
    '    Me.cmbRecibo_proveedor.Focus()
    '    Me.cmbRecibo_proveedor.Text = ""
    '    Me.lblid_Recibo_proveedor.Text = "0"
    'End Sub

    Private Sub cmbEgreso_efectivo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEgreso_efectivo.SelectedIndexChanged
        If Me.cmbEgreso_efectivo.SelectedIndex >= 0 Then
            Me.lblid_egreso_efectivo.Text = cmbEgreso_efectivo.SelectedValue.ToString
        End If
        If Not IsNumeric(Me.lblid_egreso_efectivo.Text) Then
            Exit Sub
        End If
        Me.calcularGastado()
    End Sub

    Private Sub btnBuscaEgreso_efectivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaEgreso_efectivo.Click
        Dim frmTemporal As New frmResumenCaja
        frmTemporal.ShowDialog()
        Me.CargarEgreso_efectivo()
        Me.cmbEgreso_efectivo.Focus()
        Me.cmbEgreso_efectivo.Text = ""
        Me.lblid_Egreso_efectivo.Text = "0"
    End Sub

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles chkcontrol.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles cmbegreso_efectivo.KeyDown
        If CDbl(e.KeyValue.ToString) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtimporte_pagado.KeyPress
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

    Private Sub calcularGastado()
        Dim gastado As Decimal
        Dim odt As New DataTable
        Dim odtTotal As New DataTable
        Dim totalFactura As Decimal

        odtTotal = oEgreso_efectivo.GetOne(CInt(Me.lblid_egreso_efectivo.Text))

        For Each row As DataRow In odtTotal.Rows
            totalFactura += CDec(row("Importe").ToString())
        Next

        odt = oEgreso_efectivo_proveedor.GetImporte(CInt(Me.lblid_egreso_efectivo.Text))
        If odt.Rows.Count > 0 Then
            For Each r As DataRow In odt.Rows()
                gastado += CDec(r("Importe pagado").ToString())
            Next
            Me.txtGastado.Text = CStr(gastado)
        Else
            gastado = 0
            Me.txtGastado.Text = "0"
        End If
        Me.txtSaldo.Text = CStr(totalFactura - gastado)
        Me.txtimporte_pagado.Text = Me.txtSaldo.Text
    End Sub



End Class
