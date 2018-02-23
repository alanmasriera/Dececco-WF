Public Class frmDetalleRecibo_cliente_ingreso_efectivo

    Private Sub frmDetalleRecibo_cliente_ingreso_efectivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.ttGeneral.SetToolTip(Me.btnBuscaPago_cliente, "Buscar Nuevo Pago_cliente")
        Me.ttGeneral.SetToolTip(Me.btnBuscaingreso_efectivo, "Buscar Nuevo Ingreso_efectivo")
        Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Recibo_cliente_ingreso_efectivo")
        Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()

            'Me.cmbPago_cliente.Text = oPago_cliente.GetOne(CInt(Me.lblid_Pago_cliente.Text)).Rows(0).Item("nombre Pago_cliente").ToString.Trim
            Me.cmbingreso_efectivo.Text = oIngreso_efectivo.GetOne(CInt(Me.lblid_ingreso_efectivo.Text)).Rows(0).Item("nombre Ingreso efectivo").ToString.Trim
        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try

        If BanderaRecibo_cliente_ingreso_efectivo = 1 Then
            Me.LimpiarControles()
        End If
        Me.Text = "Recibo_cliente_ingreso_efectivo" & vgNombreFormulario
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False

        Me.lblid_pago_cliente.Text = CType(Me.Owner, frmDetallePago_cliente).lblid_pago_cliente.Text
        Me.lblid_cliente.Text = CType(Me.Owner, frmDetallePago_cliente).lblid_cliente.Text


    End Sub

    Sub CargarCombos()
        'Me.CargarPago_cliente
        Me.CargarIngreso_efectivo()
    End Sub

    'Sub CargarPago_cliente()
    '    Dim odt As New DataTable

    '    odt = oPago_cliente.GetCmb
    '    With Me.cmbPago_cliente
    '        .DataSource = odt
    '        .DisplayMember = "nombre_pago_cliente"
    '        .ValueMember = "id_pago_cliente"
    '    End With
    '    If Me.cmbPago_cliente.SelectedIndex >= 0 Then
    '        cmbPago_cliente.SelectedIndex = 0
    '        Me.lblid_Pago_cliente.Text = cmbPago_cliente.SelectedValue.ToString
    '    End If
    'End Sub

    Sub CargarIngreso_efectivo()
        Dim odt As New DataTable

        odt = oIngreso_efectivo.GetCmb_2(CInt(Me.lblid_cliente.Text))
        With Me.cmbingreso_efectivo
            .DataSource = odt
            .DisplayMember = "nombre_ingreso_efectivo"
            .ValueMember = "id_ingreso_efectivo"
        End With
        If Me.cmbingreso_efectivo.SelectedIndex >= 0 Then
            cmbingreso_efectivo.SelectedIndex = 0
            Me.lblid_ingreso_efectivo.Text = cmbingreso_efectivo.SelectedValue.ToString
        End If
    End Sub

    Sub LimpiarControles()
        'Me.lblid_pago_cliente.Text = "0"
        'Me.cmbPago_cliente.Text =  ""
        Me.lblid_ingreso_efectivo.Text = "0"
        Me.cmbingreso_efectivo.Text = ""
        Me.txtimporte_pagado.Text = "0"
        Me.txtGastado.Text = "0"
        Me.txtSaldo.Text = "0"
    End Sub

    Private Sub ObtenerDatos()
        'Me.lblid_pago_cliente.Text = oRecibo_cliente_ingreso_efectivo.id_pago_cliente.ToString
        Me.lblid_ingreso_efectivo.Text = oRecibo_cliente_ingreso_efectivo.id_ingreso_efectivo.ToString
        Me.txtimporte_pagado.Text = oRecibo_cliente_ingreso_efectivo.importe_pagado.ToString.Trim
        Me.lbl_viejo.Text = oRecibo_cliente_ingreso_efectivo.id_ingreso_efectivo.ToString
    End Sub

    Private Sub AsignarDatos()
        oRecibo_cliente_ingreso_efectivo.id_pago_cliente = CInt(Me.lblid_pago_cliente.Text)
        oRecibo_cliente_ingreso_efectivo.id_ingreso_efectivo = CInt(Me.lblid_ingreso_efectivo.Text)
        oRecibo_cliente_ingreso_efectivo.importe_pagado = CDec(Me.txtimporte_pagado.Text)
    End Sub

    Public Sub SoloLectura()
        'Me.cmbPago_cliente.Enabled = False
        'Me.btnBuscaPago_cliente.Enabled = False
        Me.cmbingreso_efectivo.Enabled = False
        Me.btnBuscaingreso_efectivo.Enabled = False
        Me.txtimporte_pagado.Enabled = False
        Me.btnGuardar.Visible = False
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            If oRecibo_cliente_ingreso_efectivo.Exist() Then
                If BanderaRecibo_cliente_ingreso_efectivo = 1 Then
                    MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
                    Exit Sub
                ElseIf BanderaRecibo_cliente_ingreso_efectivo = 2 Then
                    If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                        = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            Select Case BanderaRecibo_cliente_ingreso_efectivo
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oRecibo_cliente_ingreso_efectivo.Guardar()
                    CType(Me.Owner, frmDetallePago_cliente).RefrescarGrilla_4()
                    Me.CargarCombos()
                    oRecibo_cliente_ingreso_efectivo.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    'Me.cmbPago_cliente.Focus
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oRecibo_cliente_ingreso_efectivo.Guardar()

                    If Me.lbl_viejo.Text = oRecibo_cliente_ingreso_efectivo.id_ingreso_efectivo.ToString Then

                    Else
                        oIngreso_efectivo.Archivar_ingreso(CInt(Me.lbl_viejo.Text), False)
                    End If


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

        'If CDbl(Me.lblid_pago_cliente.Text) = 0 Then
        '    MessageBox.Show("Debe Seleccionar un Dato del Combo de pago_cliente")
        '    Exit Sub
        'End If
        If CDbl(Me.lblid_ingreso_efectivo.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de ingreso_efectivo")
            Exit Sub
        End If

        If Me.txtimporte_pagado.Text = "" Then
            MessageBox.Show("debe ingresar el importe_pagado")
            Me.txtimporte_pagado.Focus()
            Exit Sub
        End If
        If Not Me.txtSaldo.Text = "" Then
            If CDec(Me.txtimporte_pagado.Text) > CDec(Me.txtSaldo.Text) Then
                MessageBox.Show("El importe pagado supera el Total de los Ingresos")
                Me.txtimporte_pagado.Focus()
                Exit Sub
            End If
        End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaRecibo_cliente_ingreso_efectivo = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    'Private Sub cmbPago_cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPago_cliente.SelectedIndexChanged
    '    If Me.cmbPago_cliente.SelectedIndex >= 0 Then
    '        Me.lblid_pago_cliente.Text = cmbPago_cliente.SelectedValue.ToString
    '    End If
    'End Sub

    'Private Sub btnBuscaPago_cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaPago_cliente.Click
    '    Dim frmTemporal As New FrmAbmPago_cliente
    '    frmTemporal.ShowDialog()
    '    Me.CargarPago_cliente()
    '    Me.cmbPago_cliente.Focus()
    '    Me.cmbPago_cliente.Text = ""
    '    Me.lblid_Pago_cliente.Text = "0"
    'End Sub

    Private Sub cmbIngreso_efectivo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbingreso_efectivo.SelectedIndexChanged
        If Me.cmbingreso_efectivo.SelectedIndex >= 0 Then
            Me.lblid_ingreso_efectivo.Text = cmbingreso_efectivo.SelectedValue.ToString
        End If
        If Not IsNumeric(Me.lblid_ingreso_efectivo.Text) Then
            Exit Sub
        End If
        Me.calcularGastado()
    End Sub

    Private Sub btnBuscaIngreso_efectivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaingreso_efectivo.Click
        Dim frmTemporal As New frmDetalleIngreso_efectivo
        BanderaIngreso_efectivo = 1
        oIngreso_efectivo.Cargar()
        oIngreso_efectivo.Insertar()
        Me.AddOwnedForm(frmTemporal)
        frmTemporal.CargarCombos()
        frmTemporal.ShowDialog()
        Me.cmbingreso_efectivo.Focus()
        Me.cmbingreso_efectivo.Text = ""
        Me.lblid_ingreso_efectivo.Text = "0"
    End Sub

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    'Handles 

    End Sub

    'Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    'Handles cmbPago_cliente.KeyDown, cmbIngreso_efectivo.KeyDown
    '    If CDbl(e.KeyValue.ToString) = 13 Then
    '        Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
    '    End If
    'End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtimporte_pagado.KeyPress

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

        odtTotal = oIngreso_efectivo.GetOne(CInt(Me.lblid_ingreso_efectivo.Text))

        For Each row As DataRow In odtTotal.Rows
            totalFactura += CDec(row("Importe").ToString())
        Next

        odt = oRecibo_cliente_ingreso_efectivo.GetImporte2(CInt(Me.lblid_ingreso_efectivo.Text))
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
