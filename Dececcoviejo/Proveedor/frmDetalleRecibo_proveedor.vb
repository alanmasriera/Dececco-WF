Public Class frmDetalleRecibo_proveedor

    Dim BanderaCierreForm As Boolean = False

    Private Sub frmDetalleNota_devolucion_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If BanderaCierreForm = False Then
            e.Cancel = True
        End If
    End Sub

    Private Sub frmDetallePago_proveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttGeneral.SetToolTip(Me.btnBuscaproveedor, "Buscar Nuevo proveedor")
        Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Pago_proveedor")
        Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()


        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try

        Me.lblid_recibo_proveedor.Text = CType(Me.Owner, frmAbmRecibo_proveedor_2).lblid_pk.Text

        If BanderaPago_proveedor = 1 Then
            Me.LimpiarControles()
        End If

        Me.Text = "Pago_proveedor"
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False

        oCheque_proveedor.Cargar()
        oCheque_proveedor_2.Cargar()
        oFactura_recibo_proveedor.Cargar()
        oEgreso_efectivo_proveedor.Cargar()

        ' oRecibo_proveedor.Cargar()
        ' oRecibo_proveedor_cheque.Cargar()

        Me.cmbproveedor.Text = CType(Me.Owner, frmAbmRecibo_proveedor_2).cmbProveedor.Text
        Me.lblid_proveedor.Text = CType(Me.Owner, frmAbmRecibo_proveedor_2).lblid_proveedor.Text

        Me.RefrescarGrilla()
        Me.RefrescarGrilla_2()
        Me.RefrescarGrilla_3()
        Me.RefrescarGrillaEgresoEfectivoProveedor()
    End Sub

    Sub CargarCombos()
        'Me.Cargarproveedor()
    End Sub

    'Sub Cargarproveedor()
    '    Dim odt As New DataTable

    '    odt = oproveedor.GetCmb
    '    With Me.cmbproveedor
    '        .DataSource = odt
    '        .DisplayMember = "nombre_proveedor"
    '        .ValueMember = "id_proveedor"
    '    End With
    '    If Me.cmbproveedor.SelectedIndex >= 0 Then
    '        cmbproveedor.SelectedIndex = 0
    '        Me.lblid_proveedor.Text = cmbproveedor.SelectedValue.ToString
    '    End If
    'End Sub

    Sub LimpiarControles()
        'Me.lblid_proveedor.Text = "0"
        'Me.cmbproveedor.Text =  ""
        Me.dtpfecha.Value = DateTime.Now
        Me.txtpago.Text = ""
        Me.txtdetalle.Text = ""
        Me.chkefectivo.Checked = False
        Me.txtNumero_4.Text = ""
        Me.txtNumero_8.Text = ""
        Me.txtretencion_iva.Text = "0"
        Me.txtingreso_bruto.Text = "0"
        Me.txtimpuesto_ganancia.Text = "0"
        Me.txtsuss.Text = "0"

        Me.lblid_recibo_proveedor.Text = "0"
        Me.txtTotalCheque.Text = "0"
        Me.txtTotalFactura.Text = "0"
    End Sub

    Private Sub ObtenerDatos()
        'Me.lblid_proveedor.Text =oRecibo_proveedor.id_proveedor.ToString
        Me.dtpfecha.Value = oRecibo_proveedor.fecha
        Me.txtpago.Text = oRecibo_proveedor.pago.ToString.Trim
        Me.txtdetalle.Text = oRecibo_proveedor.detalle.Trim
        'Me.chkefectivo.Checked = oRecibo_proveedor.efectivo
        'Me.txtnumero_recibo.Text =oRecibo_proveedor.numero_recibo.Trim

        Me.txtretencion_iva.Text = oRecibo_proveedor.retencion_iva.ToString.Trim
        Me.txtingreso_bruto.Text = oRecibo_proveedor.ingreso_bruto.ToString.Trim
        Me.txtimpuesto_ganancia.Text = oRecibo_proveedor.impuesto_ganancia.ToString.Trim
        Me.txtsuss.Text = oRecibo_proveedor.suss.ToString.Trim

        If oRecibo_proveedor.numero_recibo.Length = 12 Then
            Me.txtNumero_4.Text = oRecibo_proveedor.numero_recibo.Substring(0, 4)
            Me.txtNumero_8.Text = oRecibo_proveedor.numero_recibo.Substring(4, 8)
        End If
    End Sub

    Private Sub AsignarDatos()
        oRecibo_proveedor.id_proveedor = CInt(Me.lblid_proveedor.Text)
        oRecibo_proveedor.fecha = Me.dtpfecha.Value.Date
        oRecibo_proveedor.pago = CDec(Me.txtpago.Text)
        oRecibo_proveedor.detalle = Me.txtdetalle.Text
        'oRecibo_proveedor.efectivo = Me.chkefectivo.Checked
        'oPago_proveedor.numero_recibo = Me.txtnumero_recibo.Text
        oRecibo_proveedor.numero_recibo = Me.txtNumero_4.Text & Me.txtNumero_8.Text
        oRecibo_proveedor.retencion_iva = CDec(Me.txtretencion_iva.Text)
        oRecibo_proveedor.ingreso_bruto = CDec(Me.txtingreso_bruto.Text)
        oRecibo_proveedor.impuesto_ganancia = CDec(Me.txtimpuesto_ganancia.Text)
        oRecibo_proveedor.suss = CDec(Me.txtsuss.Text)
    End Sub

    Public Sub SoloLectura()
        Me.cmbproveedor.Enabled = False
        Me.btnBuscaProveedor.Enabled = False
        Me.dtpfecha.Enabled = False
        Me.txtpago.Enabled = False
        Me.txtdetalle.Enabled = False
        Me.chkefectivo.Enabled = False
        Me.txtNumero_4.Enabled = False
        Me.txtNumero_8.Enabled = False
        Me.txtretencion_iva.Enabled = False
        Me.txtingreso_bruto.Enabled = False
        Me.txtimpuesto_ganancia.Enabled = False
        Me.txtsuss.Enabled = False
        Me.btnGuardar.Visible = False
    End Sub

    Private Sub Numeros(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
  Handles txtNumero_4.KeyPress, txtNumero_8.KeyPress
        Dim txtTemp As TextBox
        txtTemp = CType(sender, TextBox)

        If e.KeyChar.ToString = vbCr Then
            If txtTemp.Name = "txtNumero_4" Then
                Me.txtNumero_4.Text = CompletarCeros(Me.txtNumero_4.Text, 4)
            End If
            If txtTemp.Name = "txtNumero_8" Then
                Me.txtNumero_8.Text = CompletarCeros(Me.txtNumero_8.Text, 8)
            End If

            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If

        If (e.KeyChar.ToString >= "0" And e.KeyChar.ToString <= "9") Or e.KeyChar = vbBack Then
            '  e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Guardar()
        'Try
        Me.AsignarDatos()
        If oRecibo_proveedor.Exist() Then
            If BanderaPago_proveedor = 1 Then
                MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
                Exit Sub
            ElseIf BanderaPago_proveedor = 2 Then
                If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                    = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If
            End If
        End If
        Dim var As Integer = 0
        Select Case BanderaPago_proveedor
            Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                oRecibo_proveedor.Guardar()

                Me.lblid_recibo_proveedor.Text = oRecibo_proveedor.id_recibo_proveedor.ToString
                oFactura_recibo_proveedor.UpdateID(CInt(Me.lblid_recibo_proveedor.Text))
                oCheque_proveedor.UpdateID(CInt(Me.lblid_recibo_proveedor.Text))
                oCheque_proveedor_2.UpdateID(CInt(Me.lblid_recibo_proveedor.Text))
                oEgreso_efectivo_proveedor.UpdateID(CInt(Me.lblid_recibo_proveedor.Text))


                Dim odt As New DataTable
                Dim saldo As Decimal
                'archiva las facturas
                For Each row As DataGridViewRow In dgv1.Rows

                    odt = oFactura_recibo_proveedor.GetAllFactura_proveedor(CInt(row.Cells("id_factura_proveedor").Value)) 'saldo
                    For Each r As DataRow In odt.Rows
                        saldo += CDec(r("importe_pagado"))
                    Next
                    If saldo = CDec(row.Cells("total_factura").Value) Then
                        var = CInt(row.Cells("id_factura_proveedor").Value)
                        oFactura_proveedor.ArchivarFactura(CInt(row.Cells("id_factura_proveedor").Value), True)
                    End If
                Next

                'archiva los cheques de banco
                For Each row_2 As DataGridViewRow In dgv2.Rows
                    var = CInt(row_2.Cells("id_cheque_librado").Value)
                    oChequeLibrado.ArchivarCheque(CInt(row_2.Cells("id_cheque_librado").Value), True)
                    Dim odt_temp As New DataTable
                    odt_temp = oChequeLibrado.GetOne(var)

                    'oCheque_recibidoN.Cargar()
                    'oCheque_recibidoN.Insertar()
                    'oCheque_recibidoN.numero_cheque = CStr(odt_temp.Rows(0).Item("Numero cheque"))
                    'oCheque_recibidoN.id_cliente = CInt(1)
                    'oCheque_recibidoN.id_banco = CInt(odt_temp.Rows(0).Item("banco cheque"))
                    'oCheque_recibidoN.detalle = CStr("Por pago de iva")
                    'oCheque_recibidoN.fecha_recibido = CDate(odt_temp.Rows(0).Item("fecha librado"))
                    'oCheque_recibidoN.fecha_acreditacion = CDate(odt_temp.Rows(0).Item("fecha pago"))
                    'oCheque_recibidoN.importe = CDec(odt_temp.Rows(0).Item("importe"))
                    'oCheque_recibidoN.iva = CDec(odt_temp.Rows(0).Item("iva"))
                    'oCheque_recibidoN.id_provincia = CInt(1)
                    'oCheque_recibidoN.id_localidad = CInt(1)
                    'oCheque_recibidoN.id_em presa = CInt(odt_temp.Rows(0).Item("id empresa"))
                    'oCheque_recibidoN.control = CBool(odt_temp.Rows(0).Item("control"))
                    'oCheque_recibidoN.id_proveedor = CInt(odt_temp.Rows(0).Item("id proveedor"))
                    'oCheque_recibidoN.anulado = CBool(odt_temp.Rows(0).Item("anulado"))
                    'oCheque_recibidoN.pago_tercero = False
                    'oCheque_recibidoN.numero_recibo = ""
                    'oCheque_recibidoN.cobro_efectivo = False
                    'oCheque_recibidoN.id_banco_deposito = CInt(1)
                    'oCheque_recibidoN.id_cuenta = CInt(1)
                    'oCheque_recibidoN.deposito_cuenta = False
                    'oCheque_recibidoN.Guardar()
                Next

                'archiva los cheques de caja
                For Each row_3 As DataGridViewRow In dgv3.Rows
                    var = CInt(row_3.Cells("id_cheque_recibido").Value)
                    oCheque_recibido.ArchivarCheque(CInt(row_3.Cells("id_cheque_recibido").Value), True) ' ver SP!!

                    Dim odt_temp As New DataTable
                    'odt_temp = oCheque_recibido.GetOne(var)

                    'oCheque_recibidoN.Cargar()
                    'oCheque_recibidoN.Insertar()
                    'oCheque_recibidoN.numero_cheque = CStr(odt_temp.Rows(0).Item("Numero cheque"))
                    'oCheque_recibidoN.id_cliente = CInt(odt_temp.Rows(0).Item("id cliente"))
                    'oCheque_recibidoN.id_banco = CInt(odt_temp.Rows(0).Item("id banco"))
                    'oCheque_recibidoN.detalle = CStr(odt_temp.Rows(0).Item("detalle"))
                    'oCheque_recibidoN.fecha_recibido = CDate(odt_temp.Rows(0).Item("fecha recibido"))
                    'oCheque_recibidoN.fecha_acreditacion = CDate(odt_temp.Rows(0).Item("fecha acreditacion"))
                    'oCheque_recibidoN.importe = CDec(odt_temp.Rows(0).Item("importe"))
                    'oCheque_recibidoN.iva = CDec(odt_temp.Rows(0).Item("iva"))
                    'oCheque_recibidoN.id_provincia = CInt(odt_temp.Rows(0).Item("id provincia"))
                    'oCheque_recibidoN.id_localidad = CInt(odt_temp.Rows(0).Item("id localidad"))
                    'oCheque_recibidoN.id_empresa = CInt(odt_temp.Rows(0).Item("id empresa"))
                    'oCheque_recibidoN.control = CBool(odt_temp.Rows(0).Item("control"))
                    'oCheque_recibidoN.id_proveedor = CInt(odt_temp.Rows(0).Item("id proveedor"))
                    'oCheque_recibidoN.anulado = CBool(odt_temp.Rows(0).Item("anulado"))
                    'oCheque_recibidoN.pago_tercero = CBool(False)
                    'oCheque_recibidoN.numero_recibo = CStr(odt_temp.Rows(0).Item("numero recibo"))
                    'oCheque_recibidoN.cobro_efectivo = CBool(odt_temp.Rows(0).Item("cobro efectivo"))
                    'oCheque_recibidoN.id_banco_deposito = CInt(odt_temp.Rows(0).Item("id banco deposito"))
                    'oCheque_recibidoN.id_cuenta = CInt(odt_temp.Rows(0).Item("id cuenta"))
                    'oCheque_recibidoN.deposito_cuenta = CBool(odt_temp.Rows(0).Item("deposito cuenta"))
                    'oCheque_recibidoN.Guardar()

                Next

                'archiva los egresos
                For Each row_4 As DataGridViewRow In dgvEgreso_efectivo.Rows
                    var = CInt(row_4.Cells("id egreso efectivo").Value)
                    oEgreso_efectivo.ArchivarEgreso(CInt(row_4.Cells("id egreso efectivo").Value), True) ' ver SP!!
                Next

                CType(Me.Owner, frmAbmRecibo_proveedor_2).RefrescarGrilla()
                Me.CargarCombos()
                oRecibo_proveedor.Insertar()
                Me.ObtenerDatos()
                Me.LimpiarControles()
                Me.cmbproveedor.Focus()
                Me.RefrescarGrilla()
                Me.RefrescarGrilla_2()
                Me.RefrescarGrilla_3()
                Me.RefrescarGrillaEgresoEfectivoProveedor()
            Case 2 'GUARDA Y SALE (MODIFICAR)
                BanderaCierreForm = True

                oRecibo_proveedor.Guardar()
                Me.Close()
        End Select
        'Catch ex As Exception
        'MessageBox.Show(ex.Message)
        ' End Try
    End Sub

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If Me.txtpago.Text = "" Or Me.txtsuss.Text = "" Or Me.txtretencion_iva.Text = "" Or _
        Me.txtNumero_4.Text = "" Or Me.txtNumero_8.Text = "" Or Me.txtingreso_bruto.Text = "" Or _
        Me.txtimpuesto_ganancia.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean

        If CDbl(Me.lblid_proveedor.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de proveedor")
            Exit Sub
        End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaPago_proveedor = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        BanderaCierreForm = True
        If Me.lblid_recibo_proveedor.Text = "0" Then
            oFactura_recibo_proveedor.DeleteFacturaRecibo_proveedor(CInt(Me.lblid_recibo_proveedor.Text))
            oCheque_proveedor.DeleteCheque_proveedor(CInt(Me.lblid_recibo_proveedor.Text))
            oCheque_proveedor_2.DeleteCheque_proveedor(CInt(Me.lblid_recibo_proveedor.Text))

        End If

        Me.Close()
    End Sub

    Private Sub cmbproveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbproveedor.SelectedIndexChanged
        If Me.cmbproveedor.SelectedIndex >= 0 Then
            Me.lblid_proveedor.Text = cmbproveedor.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaproveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaProveedor.Click
        Dim frmTemporal As New frmAbmProveedor
        frmTemporal.ShowDialog()
        'Me.Cargarproveedor()
        Me.cmbproveedor.Focus()
        Me.cmbproveedor.Text = ""
        Me.lblid_proveedor.Text = "0"
    End Sub

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtdetalle.KeyPress, chkefectivo.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles cmbproveedor.KeyDown, dtpfecha.KeyDown
        If CDbl(e.KeyValue.ToString) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtpago.KeyPress, txtretencion_iva.KeyPress, txtingreso_bruto.KeyPress, txtimpuesto_ganancia.KeyPress, txtsuss.KeyPress
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

    Public Sub RefrescarGrilla()
        Dim odt As DataTable
        Dim decTotal As Decimal = 0
        Dim decTotalNotaCredito As Decimal = 0

        odt = oFactura_recibo_proveedor.GetAllRecibo_proveedor(CInt(Me.lblid_recibo_proveedor.Text))
        Me.dgv1.DataSource = odt
        Me.dgv1.Columns(0).Visible = False
        Me.dgv1.Columns(1).Visible = False
        Me.dgv1.Columns(2).Visible = False

        For Each row As DataRow In odt.Rows

            If row.Item("nombre_tipo_comprobante").ToString() = "NC" Then
                decTotalNotaCredito = decTotalNotaCredito + CDec(row.Item("importe_pagado"))
            Else
                decTotal = decTotal + CDec(row.Item("importe_pagado"))
            End If

        Next

        decTotal = decTotal - decTotalNotaCredito

        Me.txtTotalFactura.Text = CStr(decTotal)
        Me.txtpago.Text = CStr(decTotal)
    End Sub

    Private Sub dgv1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv1.CurrentCellChanged
        Try
            Me.lblid_pk.Text = CStr(Me.dgv1.Item(0, Me.dgv1.CurrentRow.Index).Value)
            Me.lblid_factura.Text = CStr(Me.dgv1.Item("id_factura", Me.dgv1.CurrentRow.Index).Value)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Botones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnAgregar.Click, btnBorrar.Click, btnModificar.Click

        Dim btnTemp As New Button
        Dim frmDetalle As New frmDetalleFactura_recibo_proveedor
        btnTemp = CType(sender, Button)
        Try
            Select Case btnTemp.Name
                Case "btnAgregar"
                    BanderaFactura_recibo_proveedor = 1
                    Me.AddOwnedForm(frmDetalle)
                    oFactura_recibo_proveedor.Insertar()
                    frmDetalle.lblid_proveedor.Text = Me.lblid_proveedor.Text
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                Case "btnModificar"
                    If Not IsNumeric(Me.lblid_pk.Text) Then
                        Exit Sub
                    End If
                    BanderaFactura_recibo_proveedor = 2
                    Me.AddOwnedForm(frmDetalle)
                    oFactura_recibo_proveedor.Modificar(CInt(Me.lblid_pk.Text))
                    frmDetalle.lblid_proveedor.Text = Me.lblid_proveedor.Text
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                    RefrescarGrilla()
                Case "btnBorrar"
                    If Not IsNumeric(Me.lblid_pk.Text) Then
                        Exit Sub
                    End If

                    If MessageBox.Show("Desea Realmente Eliminar el Registro ", "BORRAR", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                    = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If

                    'desarchivo la factura
                    oFactura_proveedor.ArchivarFactura(CInt(Me.lblid_factura.Text), False)

                    oFactura_recibo_proveedor.Borrar(CInt(Me.lblid_pk.Text))
                    RefrescarGrilla()
                Case "btnAyuda"
                    'Process.Start(PathAyuda + "frmAbmRecibo_proveedor.avi")
                Case "btnSalir"
                    Me.Close()
            End Select
            'Me.txtBuscar.Text = ""
            'Me.txtBuscar.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub




    Public Sub RefrescarGrilla_2()
        Dim odt As DataTable
        Dim decTotal As Decimal = 0

        odt = oCheque_proveedor.GetAllRecibo_proveedor(CInt(Me.lblid_recibo_proveedor.Text))
        Me.dgv2.DataSource = odt
        Me.dgv2.Columns(0).Visible = False
        Me.dgv2.Columns(1).Visible = False
        Me.dgv2.Columns(2).Visible = False

        For Each row As DataRow In odt.Rows
            decTotal = decTotal + CDec(row.Item("importe"))
        Next

        Me.txtTotalCheque.Text = CStr(decTotal)
    End Sub

    Public Sub RefrescarGrilla_3()
        Dim odt As DataTable
        Dim decTotal As Decimal = 0

        odt = oCheque_proveedor_2.GetAll_2(CInt(Me.lblid_recibo_proveedor.Text))
        Me.dgv3.DataSource = odt
        Me.dgv3.Columns(0).Visible = False
        Me.dgv3.Columns(1).Visible = False
        Me.dgv3.Columns(2).Visible = False

        For Each row As DataRow In odt.Rows
            decTotal = decTotal + CDec(row.Item("importe"))
        Next

        Me.txtTotalCheques_2.Text = CStr(decTotal)
    End Sub

    Private Sub dgv2_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv2.CurrentCellChanged
        Try
            Me.lblid_pk_2.Text = CStr(Me.dgv2.Item(0, Me.dgv2.CurrentRow.Index).Value)
            Me.lblid_cheque_recibido.Text = CStr(Me.dgv2.Item("id_cheque_recibido", Me.dgv2.CurrentRow.Index).Value)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Botones_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnAgregar_2.Click, btnBorrar_2.Click, btnModificar_2.Click

        Dim btnTemp As New Button
        Dim frmDetalle As New frmDetalleCheque_proveedor
        btnTemp = CType(sender, Button)
        Try
            Select Case btnTemp.Name
                Case "btnAgregar_2"
                    BanderaCheque_proveedor = 1
                    Me.AddOwnedForm(frmDetalle)
                    oCheque_proveedor.Insertar()
                    frmDetalle.lblid_proveedor.Text = Me.lblid_proveedor.Text
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                Case "btnModificar_2"
                    If Not IsNumeric(Me.lblid_pk_2.Text) Then
                        Exit Sub
                    End If
                    BanderaCheque_proveedor = 2
                    Me.AddOwnedForm(frmDetalle)
                    oCheque_proveedor.Modificar(CInt(Me.lblid_pk.Text))
                    frmDetalle.lblid_proveedor.Text = Me.lblid_proveedor.Text
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                    RefrescarGrilla_2()
                Case "btnBorrar_2"
                    If Not IsNumeric(Me.lblid_pk_2.Text) Then
                        Exit Sub
                    End If

                    If MessageBox.Show("Desea Realmente Eliminar el Registro ", "BORRAR", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                    = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If

                    'desarchivo el cheque
                    oChequeLibrado.ArchivarCheque(CInt(Me.lblid_cheque_recibido.Text), False)

                    oCheque_proveedor.Borrar(CInt(Me.lblid_pk_2.Text))
                    RefrescarGrilla_2()
                Case "btnAyuda"
                    'Process.Start(PathAyuda + "frmAbmRecibo_proveedor_cheque.avi")
                Case "btnSalir"
                    Me.Close()
            End Select
            'Me.txtBuscar.Text = ""
            'Me.txtBuscar.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Botones_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnAgregar_3.Click, btnBorrar_3.Click, btnModificar_3.Click

        Dim btnTemp As New Button
        Dim frmDetalle As New frmDetalleCheque_proveedor_2
        btnTemp = CType(sender, Button)
        Try
            Select Case btnTemp.Name
                Case "btnAgregar_3"
                    BanderaCheque_proveedor_2 = 1
                    Me.AddOwnedForm(frmDetalle)
                    oCheque_proveedor_2.Insertar()
                    frmDetalle.lblid_proveedor.Text = Me.lblid_proveedor.Text

                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                Case "btnModificar_3"
                    If Not IsNumeric(Me.lblid_pk_3.Text) Then
                        Exit Sub
                    End If
                    BanderaCheque_proveedor_2 = 2
                    Me.AddOwnedForm(frmDetalle)
                    oCheque_proveedor_2.Modificar(CInt(Me.lblid_pk_3.Text))
                    frmDetalle.lblid_proveedor.Text = Me.lblid_proveedor.Text
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                    RefrescarGrilla_3()
                Case "btnBorrar_3"
                    If Not IsNumeric(Me.lblid_pk_3.Text) Then
                        Exit Sub
                    End If

                    If MessageBox.Show("Desea Realmente Eliminar el Registro ", "BORRAR", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                    = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If

                    'desarchivo el cheque
                    oChequeRecibido.ArchivarCheque(CInt(Me.lblid_cheque_recibido_2.Text), False)

                    oCheque_proveedor_2.Borrar(CInt(Me.lblid_pk_3.Text))
                    RefrescarGrilla_3()
                Case "btnAyuda"
                    'Process.Start(PathAyuda + "frmAbmRecibo_proveedor_cheque.avi")
                Case "btnSalir"
                    Me.Close()
            End Select
            'Me.txtBuscar.Text = ""
            'Me.txtBuscar.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgv_3_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgv3.CurrentCellChanged
        Try
            Me.lblid_pk_3.Text = CStr(Me.dgv3.Item(0, Me.dgv2.CurrentRow.Index).Value)
            Me.lblid_cheque_recibido_2.Text = CStr(Me.dgv3.Item("id_cheque_recibido", Me.dgv3.CurrentRow.Index).Value)
        Catch ex As Exception
        End Try
    End Sub



    '''''''''''''''''''''''''''''''
    'codigo de la grilla efectivo
    '''''''''''''''''''''''''''''''

    Public Sub RefrescarGrillaEgresoEfectivoProveedor()
        Dim odt As DataTable

        odt = oEgreso_efectivo_proveedor.GetAllRecibo_proveedor(CInt(Me.lblid_recibo_proveedor.Text))
        Me.dgvEgreso_efectivo.DataSource = odt
        Me.dgvEgreso_efectivo.Columns(0).Visible = False
        Me.dgvEgreso_efectivo.Columns("id recibo proveedor").Visible = False
        Me.dgvEgreso_efectivo.Columns("id egreso efectivo").Visible = False
        Me.dgvEgreso_efectivo.Columns("control").Visible = False

    End Sub

    Private Sub dgvEgreso_efectivo_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvEgreso_efectivo.CurrentCellChanged
        Try
            Me.lblid_egreso_efectivo_proveedor.Text = CStr(Me.dgvEgreso_efectivo.Item(0, Me.dgvEgreso_efectivo.CurrentRow.Index).Value)
            Me.lblid_egreso_efectivo.Text = CStr(Me.dgvEgreso_efectivo.Item("id egreso efectivo", Me.dgvEgreso_efectivo.CurrentRow.Index).Value)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BotonesEgreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnAgregarEgreso.Click, btnBorrarEgreso.Click, btnModificarEgreso.Click
        Dim btnTemp As New Button
        Dim frmDetalle As New frmDetalleEgreso_efectivo_proveedor
        btnTemp = CType(sender, Button)
        Try
            Select Case btnTemp.Name
                Case "btnAgregarEgreso"
                    BanderaEgreso_efectivo_proveedor = 1
                    Me.AddOwnedForm(frmDetalle)
                    oEgreso_efectivo_proveedor.Insertar()
                    frmDetalle.lblid_proveedor.Text = Me.lblid_proveedor.Text
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                Case "btnModificarEgreso"
                    If Not IsNumeric(Me.lblid_egreso_efectivo_proveedor.Text) Then
                        Exit Sub
                    End If
                    BanderaEgreso_efectivo_proveedor = 2
                    Me.AddOwnedForm(frmDetalle)
                    oEgreso_efectivo_proveedor.Modificar(CInt(Me.lblid_egreso_efectivo_proveedor.Text))
                    frmDetalle.lblid_proveedor.Text = Me.lblid_proveedor.Text
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                    RefrescarGrillaEgresoEfectivoProveedor()
                Case "btnBorrarEgreso"
                    If Not IsNumeric(Me.lblid_egreso_efectivo_proveedor.Text) Then
                        Exit Sub
                    End If

                    If MessageBox.Show("Desea Realmente Eliminar el Registro ", "BORRAR", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                    = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If

                    oEgreso_efectivo_proveedor.Borrar(CInt(Me.lblid_egreso_efectivo_proveedor.Text))
                    RefrescarGrillaEgresoEfectivoProveedor()
                Case "btnAyuda"
                    'Process.Start(PathAyuda + "frmAbmEgreso_efectivo_proveedor.avi")
                Case "btnSalir"
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
