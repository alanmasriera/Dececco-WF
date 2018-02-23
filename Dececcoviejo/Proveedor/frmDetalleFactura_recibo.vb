Public Class frmDetalleFactura_recibo

    Dim decSaldo As Decimal = 0
    Dim decNew As Decimal = 0
    Dim decOld As Decimal = 0

    Private Sub frmDetalleFactura_recibo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.ttGeneral.SetToolTip(Me.btnBuscaFactura, "Buscar Nuevo Factura")
        'Me.ttGeneral.SetToolTip(Me.btnBuscaRecibo, "Buscar Nuevo Recibo")
        Me.ttGeneral.SetToolTip(Me.btnBuscaBanco, "Buscar Nuevo Banco")
        Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Factura_recibo")
        Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()


            Dim odtTemp As New DataTable
            'Me.CompletarFactura()
            odtTemp = oFactura_proveedor.GetOne_2(CInt(Me.lblid_factura.Text))
            Me.txtImporte_factura.Text = CStr(odtTemp.Rows(0).Item("importe"))
            Me.txtSaldo_factura.Text = CStr(odtTemp.Rows(0).Item("saldo_factura"))
            Me.txtNumero_4.Text = odtTemp.Rows(0).Item("numero").ToString.Substring(0, 4)
            Me.txtNumero_8.Text = odtTemp.Rows(0).Item("numero").ToString.Substring(4, 8)
            Me.txtNumero_4.ReadOnly = True
            Me.txtNumero_8.ReadOnly = True

            decSaldo = CDec(Me.txtSaldo_factura.Text)
            decOld = CDec(Me.txtImporte_pagado.Text)

            'Me.cmbRecibo.Text = oRecibo.GetOne(Me.lblid_Recibo.Text).Rows(0).Item("nombre_Recibo").ToString.Trim
            Me.cmbBanco.Text = oBanco.GetOne(CInt(Me.lblid_banco.Text)).Rows(0).Item("nombre_Banco").ToString.Trim
        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try




        If BanderaFactura_recibo_proveedor = 1 Then
            Me.LimpiarControles()
        End If
        Me.Text = "Factura_recibo" & NombreFormulario
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False

        Me.lblid_recibo.Text = CType(Me.Owner, frmAbmFactura_recibo).lblid_recibo.Text
        Me.lblid_proveedor.Text = CType(Me.Owner, frmAbmFactura_recibo).lblid_proveedor.Text
        Me.cmbProveedor.Text = oProveedor.GetOne(CInt(Me.lblid_proveedor.Text)).Rows(0).Item("nombre_Proveedor").ToString.Trim

        Me.RefrescarGrilla()

        Me.CargarCombos()

        If BanderaFactura_recibo_proveedor = 2 Then
            Me.txtImporte_pagado.Focus()
        End If
    End Sub

    Public Sub RefrescarGrilla()
        Dim odt As DataTable

        odt = oFactura_proveedor.GetAll_Recibo(CInt(Me.lblid_proveedor.Text))
        Me.dgv1.DataSource = odt
        Me.dgv1.Columns(0).Visible = False
        Me.dgv1.Columns("SALDO").DefaultCellStyle.Format = "c"
        Me.dgv1.Columns("SALDO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgv1.Columns("IMPORTE").DefaultCellStyle.Format = "c"
        Me.dgv1.Columns("IMPORTE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        Dim decTotal As Decimal = 0
        For Each row As DataRow In odt.Rows
            decTotal = decTotal + CDec(row.Item("saldo"))
        Next
        Me.txtTotal.Text = FormatCurrency(decTotal)
    End Sub

    Sub CargarCombos()
        ' Me.CargarFactura()
        'Me.CargarRecibo()
        Me.CargarBanco()
        Me.CargarProveedor()
    End Sub

    Sub CargarProveedor()
        Dim odt As New DataTable

        odt = oProveedor.GetCmb
        With Me.cmbProveedor
            .DataSource = odt
            .DisplayMember = "nombre_Proveedor"
            .ValueMember = "id_Proveedor"
        End With
        If Me.cmbProveedor.SelectedIndex >= 0 Then
            cmbProveedor.SelectedIndex = 0
            Me.lblid_proveedor.Text = cmbProveedor.SelectedValue.ToString
        End If
    End Sub

    Sub CargarBanco()
        Dim odt As New DataTable

        odt = oBanco.GetCmb
        With Me.cmbBanco
            .DataSource = odt
            .DisplayMember = "nombre_Banco"
            .ValueMember = "id_Banco"
        End With
        If Me.cmbBanco.SelectedIndex >= 0 Then
            cmbBanco.SelectedIndex = 0
            Me.lblid_banco.Text = cmbBanco.SelectedValue.ToString
        End If
    End Sub

    Sub LimpiarControles()
        Me.lblid_factura.Text = "0"
        'Me.cmbFactura.Text = ""
        'Me.lblid_recibo.Text = "0"
        'Me.cmbRecibo.Text = ""
        Me.txtImporte_pagado.Text = ""
        Me.chkEfectivo.Checked = False

        If Me.chkConservarCheque.Checked = False Then
            Me.txtNumero_cheque.Text = ""
            Me.lblid_banco.Text = "3"
            Me.cmbBanco.Text = "NINGUNO"
            Me.txtPlaza_cheque.Text = ""
            Me.dtpFecha_pago.Value = DateTime.Now
        End If

        Me.txtSaldo_factura.Text = ""
        Me.txtSaldo_nuevo.Text = ""
        Me.txtNumero_4.Text = ""
        Me.txtNumero_8.Text = ""
        Me.txtImporte_factura.Text = ""
    End Sub

    Private Sub ObtenerDatos()
        Me.lblid_factura.Text = CStr(oFactura_recibo_proveedor.id_factura_proveedor)
        'Me.lblid_recibo.Text = oFactura_recibo_proveedor.id_recibo
        Me.txtImporte_pagado.Text = oFactura_recibo_proveedor.importe_pagado.ToString.Trim
        Me.chkEfectivo.Checked = oFactura_recibo_proveedor.efectivo
        'Me.txtNumero_cheque.Text = oFactura_recibo_proveedor.numero_cheque.Trim
        'Me.lblid_banco.Text = CStr(oFactura_recibo_proveedor.id_banco)
        'Me.txtPlaza_cheque.Text = oFactura_recibo_proveedor.plaza_cheque.Trim
        'Me.dtpFecha_pago.Value = oFactura_recibo_proveedor.fecha_pago
    End Sub

    Private Sub AsignarDatos()
        oFactura_recibo_proveedor.id_factura_proveedor = CInt(Me.lblid_factura.Text)
        oFactura_recibo_proveedor.id_recibo_proveedor = CInt(Me.lblid_recibo.Text)
        oFactura_recibo_proveedor.importe_pagado = CDec(Me.txtImporte_pagado.Text)
        oFactura_recibo_proveedor.efectivo = Me.chkEfectivo.Checked
        'oFactura_recibo_proveedor.numero_cheque = Me.txtNumero_cheque.Text
        'oFactura_recibo_proveedor.id_banco = CInt(Me.lblid_banco.Text)
        'oFactura_recibo_proveedor.plaza_cheque = Me.txtPlaza_cheque.Text
        'oFactura_recibo_proveedor.fecha_pago = Me.dtpFecha_pago.Value.Date
    End Sub

    Public Sub SoloLectura()
        'Me.cmbFactura.Enabled = False
        'Me.btnBuscaFactura.Enabled = False
        'Me.cmbRecibo.Enabled = False
        'Me.btnBuscaRecibo.Enabled = False
        Me.txtImporte_pagado.Enabled = False
        Me.chkEfectivo.Enabled = False
        Me.txtNumero_cheque.Enabled = False
        Me.cmbBanco.Enabled = False
        Me.btnBuscaBanco.Enabled = False
        Me.txtPlaza_cheque.Enabled = False
        Me.dtpFecha_pago.Enabled = False
        Me.btnGuardar.Visible = False
    End Sub

    Private Sub Guardar()
        Try
            If CDec(Me.txtImporte_pagado.Text) > CDec(Me.txtSaldo_factura.Text) And BanderaFactura_recibo_proveedor = 1 Then
                MessageBox.Show("El importe pagado no debe ser superior al saldo de la factura")
                Exit Sub
            End If

            Me.AsignarDatos()
            If oFactura_recibo_proveedor.Exist_2() Then
                If BanderaFactura_recibo_proveedor = 1 Then
                    MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
                    Exit Sub
                ElseIf BanderaFactura_recibo_proveedor = 2 Then
                    If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                        = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            Select Case BanderaFactura_recibo_proveedor
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oFactura_recibo_proveedor.Guardar()

                    oFactura_proveedor.Update_saldo(CInt(Me.lblid_factura.Text), CDec(Me.txtSaldo_nuevo.Text))
                    If CDec(Me.txtSaldo_nuevo.Text) = 0 Then
                        oFactura_proveedor.Update_pagada(CInt(Me.lblid_factura.Text), True)
                    End If
                    CType(Me.Owner, frmAbmFactura_recibo).RefrescarGrilla()
                    'Me.CargarCombos()
                    oFactura_recibo_proveedor.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()

                    Me.RefrescarGrilla()
                    Me.dgv1.Focus()
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    decNew = decSaldo + decOld - CDec(Me.txtImporte_pagado.Text)
                    If decNew < 0 Then
                        MessageBox.Show("El importe pagado supera al importe de la factura")
                        Exit Sub
                    End If
                    oFactura_recibo_proveedor.Guardar()

                    If decNew = 0 Then
                        oFactura_proveedor.Update_saldo(CInt(Me.lblid_factura.Text), decNew)
                        oFactura_proveedor.Update_pagada(CInt(Me.lblid_factura.Text), True)
                    Else
                        oFactura_proveedor.Update_saldo(CInt(Me.lblid_factura.Text), decNew)
                        oFactura_proveedor.Update_pagada(CInt(Me.lblid_factura.Text), False)
                    End If

                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If Me.txtImporte_pagado.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean

        If CDbl(Me.lblid_factura.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de factura")
            Exit Sub
        End If
        If CDbl(Me.lblid_recibo.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de recibo")
            Exit Sub
        End If
        If CDbl(Me.lblid_banco.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de banco")
            Exit Sub
        End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaFactura_recibo_proveedor = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cmbBanco_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBanco.SelectedIndexChanged
        If Me.cmbBanco.SelectedIndex >= 0 Then
            Me.lblid_banco.Text = cmbBanco.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaBanco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaBanco.Click
        Dim frmTemporal As New frmAbmBanco
        frmTemporal.ShowDialog()
        Me.CargarBanco()
        Me.cmbBanco.Focus()
        Me.cmbBanco.Text = ""
        Me.lblid_banco.Text = "0"
    End Sub

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles chkEfectivo.KeyPress, txtNumero_cheque.KeyPress, txtPlaza_cheque.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles cmbBanco.KeyDown, dtpFecha_pago.KeyDown
        If e.KeyValue = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtImporte_pagado.KeyPress
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

    Private Sub dgv1_CellContextMenuStripNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventArgs) Handles dgv1.CellContextMenuStripNeeded

    End Sub


    Private Sub dgv1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellDoubleClick
        Try
            If dgv1.Columns(e.ColumnIndex).Index = 1 Then
                Me.txtNumero_4.Text = Me.dgv1.Item(1, Me.dgv1.CurrentRow.Index).Value.ToString.Substring(0, 4)
                Me.txtNumero_8.Text = Me.dgv1.Item(1, Me.dgv1.CurrentRow.Index).Value.ToString.Substring(5, 8)

                Me.CompletarFactura()
                Me.txtImporte_pagado.Focus()
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtNumero_4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumero_4.LostFocus
        Try
            Me.txtNumero_4.Text = CompletarCeros(Me.txtNumero_4.Text, 4)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtNumero_8_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumero_8.LostFocus
        Try
            Me.txtNumero_8.Text = CompletarCeros(Me.txtNumero_8.Text, 8)

            Me.CompletarFactura()
        Catch ex As Exception
        End Try
    End Sub

    Sub CompletarFactura()
        Dim odtTemp As New DataTable

        odtTemp = oFactura_proveedor.Find_2(Me.txtNumero_4.Text & Me.txtNumero_8.Text, CInt(Me.lblid_proveedor.Text))
        Try
            Me.lblid_factura.Text = CStr(odtTemp.Rows(0).Item("id_factura_proveedor"))
            Me.txtImporte_factura.Text = CStr(odtTemp.Rows(0).Item("importe"))
            Me.txtSaldo_factura.Text = CStr(odtTemp.Rows(0).Item("saldo_factura"))
            'pone en el importe a pagar el saldo de la factura
            Me.txtImporte_pagado.Text = CStr(odtTemp.Rows(0).Item("saldo_factura"))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txtImporte_pagado_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImporte_pagado.LostFocus
        Try
            Me.txtSaldo_nuevo.Text = CStr(CDec(Me.txtSaldo_factura.Text) - CDec(Me.txtImporte_pagado.Text))
            If BanderaFactura_recibo_proveedor = 2 Then
                Me.txtSaldo_nuevo.Text = CStr(decSaldo + decOld - CDec(Me.txtImporte_pagado.Text))
            End If
        Catch ex As Exception
            Me.txtSaldo_nuevo.Text = "0"
        End Try
    End Sub

   

    Private Sub dgv1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv1.CurrentCellChanged
        Try
            Me.lblid_pk.Text = CStr(Me.dgv1.Item(0, Me.dgv1.CurrentRow.Index).Value)
        Catch ex As Exception
        End Try
    End Sub


    Private Sub btnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsulta.Click
        Dim frmTemp As New frmConsultaProveedor

        odtConsultaGeneral = oFactura_proveedor.GetPagoRecibo(CInt(Me.lblid_proveedor.Text), CInt(Me.lblid_pk.Text))
        BanderaConsultaGeneral = "saldo_factura_proveedor"
        '  odtConsultaGeneralSuma = oFactura_proveedor.GetPagoRecibo(Me.lblid_proveedor.Text)
        strTituloConsultaGeneral = ""
        frmTemp.ShowDialog()
    End Sub

    
    Private Sub cmbProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProveedor.SelectedIndexChanged
        If Me.cmbProveedor.SelectedIndex >= 0 Then
            Me.lblid_proveedor.Text = cmbProveedor.SelectedValue.ToString
        End If
        If Not IsNumeric(Me.lblid_proveedor.Text) Then
            Exit Sub
        End If
        Me.RefrescarGrilla()
    End Sub
End Class