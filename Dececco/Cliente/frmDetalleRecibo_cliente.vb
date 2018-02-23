Public Class frmDetalleRecibo_cliente

    Private Sub frmDetalleRecibo_cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.ttGeneral.SetToolTip(Me.btnBuscaPago_cliente, "Buscar Nuevo Pago_cliente")
        Me.ttGeneral.SetToolTip(Me.btnBuscafactura, "Buscar Nuevo Factura")
        Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Recibo_cliente")
        Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()

            'Me.cmbPago_cliente.Text = oPago_cliente.GetOne(CInt(Me.lblid_Pago_cliente.Text)).Rows(0).Item("nombre_Pago_cliente").ToString.Trim
            Me.cmbfactura.Text = oFactura.GetOne(CInt(Me.lblid_factura.Text)).Rows(0).Item("nombre Factura").ToString.Trim
        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try


        'Me.lblid_cliente.Text = CType(Me.Owner, frmDetallePago_cliente).lblid_cliente.Text

        If BanderaRecibo_cliente = 1 Then
            Me.LimpiarControles()
        End If

        Me.Text = "Recibo_cliente"
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.lblid_pago_cliente.Text = CType(Me.Owner, frmDetallePago_cliente).lblid_pago_cliente.Text

    End Sub

    Sub CargarCombos()
        'Me.CargarPago_cliente
        Me.CargarFactura()
    End Sub

    Sub CargarPago_cliente()
        'Dim odt As New DataTable

        'odt = oPago_cliente.GetCmb
        'With Me.cmbPago_cliente
        '    .DataSource = odt
        '    .DisplayMember = "nombre_pago_cliente"
        '    .ValueMember = "id_pago_cliente"
        'End With
        'If Me.cmbPago_cliente.SelectedIndex >= 0 Then
        '    cmbPago_cliente.SelectedIndex = 0
        '    Me.lblid_Pago_cliente.Text = cmbPago_cliente.SelectedValue.ToString
        'End If
    End Sub

    Sub CargarFactura()
        Dim odt As New DataTable

        odt = oFactura.GetCmbFacturaCliente(CInt(Me.lblid_cliente.Text))
        With Me.cmbfactura
            .DataSource = odt
            .DisplayMember = "nombre_factura"
            .ValueMember = "id_factura"
        End With
        If Me.cmbfactura.SelectedIndex >= 0 Then
            cmbfactura.SelectedIndex = 0
            Me.lblid_factura.Text = cmbfactura.SelectedValue.ToString
        End If
    End Sub

    Sub LimpiarControles()
        ' Me.lblid_pago_cliente.Text = "0"
        'Me.cmbPago_cliente.Text =  ""
        Me.lblid_factura.Text = "0"
        Me.cmbfactura.Text = ""
        Me.chkcontrol.Checked = False
        Me.txtimporte_pagado.Text = "0"
    End Sub

    Private Sub ObtenerDatos()
        Me.lblid_pago_cliente.Text = oRecibo_cliente.id_pago_cliente.ToString
        Me.lblid_factura.Text = oRecibo_cliente.id_factura.ToString
        Me.txtimporte_pagado.Text = oRecibo_cliente.importe_pagado.ToString.Trim
        Me.lbl_viejo.Text = oRecibo_cliente.id_factura.ToString

    End Sub

    Private Sub AsignarDatos()
        oRecibo_cliente.id_pago_cliente = CInt(Me.lblid_pago_cliente.Text)
        oRecibo_cliente.id_factura = CInt(Me.lblid_factura.Text)
        oRecibo_cliente.importe_pagado = CDec(Me.txtimporte_pagado.Text)
    End Sub

  Public Sub SoloLectura()
        'Me.cmbPago_cliente.Enabled = False
        'Me.btnBuscaPago_cliente.Enabled = False
        Me.cmbfactura.Enabled = False
        Me.btnBuscafactura.Enabled = False
        Me.chkcontrol.Enabled = False
        Me.btnGuardar.Visible = False
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            If oRecibo_cliente.Exist() Then
                If BanderaRecibo_cliente = 1 Then
                    MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
                    Exit Sub
                ElseIf BanderaRecibo_cliente = 2 Then
                    If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                        = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            Select Case BanderaRecibo_cliente
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oRecibo_cliente.Guardar()

                    CType(Me.Owner, frmDetallePago_cliente).RefrescarGrilla()
                    Me.CargarCombos()
                    oRecibo_cliente.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.cmbfactura.Focus()
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oRecibo_cliente.Guardar()

                    If Me.lbl_viejo.Text = oRecibo_cliente.id_factura.ToString Then
                    Else
                        oFactura.ArchivarFactura(CInt(Me.lbl_viejo.Text), False)
                    End If

                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If Me.Text = "" Then
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
        If CDbl(Me.lblid_factura.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de factura")
            Exit Sub
        End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaRecibo_cliente = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    ''Private Sub cmbPago_cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    ''    If Me.cmbpago_cliente.SelectedIndex >= 0 Then
    ''        Me.lblid_pago_cliente.Text = cmbpago_cliente.SelectedValue.ToString
    ''    End If
    ''End Sub

    'Private Sub btnBuscaPago_cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim frmTemporal As New frmAbmPago_cliente
    '    frmTemporal.ShowDialog()
    '    Me.CargarPago_cliente()
    '    'Me.cmbpago_cliente.Focus()
    '    'Me.cmbpago_cliente.Text = ""
    '    Me.lblid_pago_cliente.Text = "0"
    'End Sub

    Private Sub cmbFactura_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbfactura.SelectedIndexChanged
        If Me.cmbfactura.SelectedIndex >= 0 Then
            Me.lblid_factura.Text = cmbfactura.SelectedValue.ToString
        End If
        Me.calcularGastado()
    End Sub

    Private Sub btnBuscaFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscafactura.Click
        Dim frmTemporal As New frmAbmFactura
        vgFormularioPadre = Me.Name
        Me.AddOwnedForm(frmTemporal)
        frmTemporal.ShowDialog()
        Me.CargarFactura()
        Me.cmbfactura.Focus()
        Me.cmbfactura.Text = ""
        Me.lblid_factura.Text = "0"
    End Sub

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chkcontrol.KeyPress

        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbfactura.KeyDown

        If CDbl(e.KeyValue.ToString) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    'Handles 

    End Sub

    Private Sub calcularGastado()
        Dim gastado As Decimal
        Dim odt As New DataTable
        Dim odtTotal As New DataTable
        Dim totalRecibo As Decimal
        Try
            odtTotal = oFactura.GetOne(CInt(Me.lblid_factura.Text))
        Catch

        End Try


        For Each row As DataRow In odtTotal.Rows
            totalRecibo += CDec(row("Total factura").ToString())
        Next

        Try
            odt = oRecibo_cliente.GetAll_X_factura(CInt(Me.lblid_factura.Text))
        Catch

        End Try

        If odt.Rows.Count > 0 Then
            For Each r As DataRow In odt.Rows()
                gastado += CDec(r("Importe pagado").ToString())
            Next
            Me.txtGastado.Text = CStr(gastado)
        Else
            gastado = 0
            Me.txtGastado.Text = "0"
        End If
        Me.txtSaldo.Text = CStr(totalRecibo - gastado)
        Me.txtimporte_pagado.Text = Me.txtSaldo.Text
    End Sub


End Class
