
Public Class frmDetalleFactura3


    Dim strFactura As String = "Factura"
    Dim strNC As String = "Nota de Crédito"
    Dim strND As String = "Nota de Débito"

    Private Sub frmDetalleFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttCliente.SetToolTip(Me.btnBuscaCliente, "Buscar Nuevo Cliente")
        Me.ttGuardar.SetToolTip(Me.btnGuardar, "Guardar Datos de la Factura")
        Me.ttSalir.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Me.ttAgregar.SetToolTip(Me.btnAgregar, "Agrega un item a la factura")
        Me.ttBorrar.SetToolTip(Me.btnBorrar, "Borra el item seleccionado de la factura")
        Me.ttModificar.SetToolTip(Me.btnModificar, "Modifica el item seleccionado de la factura")
        Me.ttImprimir.SetToolTip(Me.btnImprimir, "Imprimir la Factura")

        Try
            ObtenerDatos()

            Me.cmbCliente.Text = oCliente.GetOne_2(CInt(Me.lblid_cliente.Text)).Rows(0).Item("nombre_cliente").ToString.Trim ' modificado por nombre_empleado
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
        End Try
       


        If BanderaFactura = 1 Then
            Me.LimpiarControles()
        End If

        Try
            Me.lblid_factura.Text = CType(Me.Owner, frmResumenCliente).lblid_pk_Factura.Text
        Catch ex As Exception
            Me.lblid_factura.Text = CType(Me.Owner, frmAbmFactura).lblid_pk.Text
        End Try

        Dim odt As DataTable
        odt = oCuerpo_factura.ConsultarTodo_2(CInt(lblid_factura.Text))
        oCuerpo_factura.Cargar()
        'oCuerpo_factura_exporta.Cargar()

        RefrescarGrilla()

        Me.Text = "Factura" & vgNombreFormulario
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False
    End Sub

    Sub CargarCombos()
        Me.CargarCliente()
    End Sub

    Sub CargarCliente()
        Dim odt As New DataTable

        odt = oCliente.GetCmb_2
        With Me.cmbCliente
            .DataSource = odt
            '.DisplayMember = "nombre_Cliente"
            .DisplayMember = "nombre_cliente"
            .ValueMember = "id_Cliente"
        End With
        If Me.cmbCliente.SelectedIndex >= 0 Then
            cmbCliente.SelectedIndex = 0
            Me.lblid_cliente.Text = cmbCliente.SelectedValue.ToString
        End If
    End Sub

    Sub LimpiarControles()
        Dim CadenaTemp As String
        CadenaTemp = oFactura.GetTop()
        If CadenaTemp.Length = 12 Then
            Me.txtNumero_factura_1.Text = CadenaTemp.Substring(0, 4)
            Me.txtNumero_factura_2.Text = CadenaTemp.Substring(4, 8)
        End If
        Me.lblid_cliente.Text = "0"
        Me.cmbCliente.Text = ""
        Me.lblid_pk.Text = "0"
        Me.lblid_factura.Text = "1"
        Me.dtpFecha_factura.Value = DateTime.Now
        Me.dtpFecha.Value = DateTime.Now
        Me.txtIva_factura.Text = "21"
        Me.txtSubtotal.Text = ""
        Me.txtIva.Text = ""
        Me.txtTotal.Text = ""
        Me.txtTipo.Text = "AAA"
        Me.txtCondicion_pago.Text = ""
        Me.txtReferencia.Text = ""
        Dim odt As DataTable
        odt = oCuerpo_factura.ConsultarTodo_2(1)
        Me.dgv1.DataSource = odt
        Me.dgv1.Columns(0).Visible = False
        Me.dgv1.Columns("cantidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgv1.Columns("cantidad").DefaultCellStyle.Format = "n"
        Me.dgv1.Columns("precio_unitario").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgv1.Columns("precio_unitario").DefaultCellStyle.Format = "c"
        Me.dgv1.Columns("importe").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgv1.Columns("importe").DefaultCellStyle.Format = "c"
        Me.dgv1.Columns("cantidad").Width = 100
        Me.dgv1.Columns("precio_unitario").Width = 130
        Me.dgv1.Columns("importe").Width = 100
        Me.dgv1.Columns("descripcion").Width = 400
        Me.txtTotal_letra.Text = ""
        Me.rbnFactura.Checked = True
        Me.rbnNC.Checked = False
        Me.rbnND.Checked = False
        Me.rbnResponsable_inscripto.Checked = True
        Me.rbnResponsable_no_inscripto.Checked = False
        Me.rbnContado.Checked = True
        Me.rbnCuenta_corriente.Checked = False
        Me.txtImpuesto.Text = "0"
        Me.txtNumero_remito_1.Text = ""
        Me.txtNumero_remito_2.Text = ""
        Me.txtOrden_compra.Text = ""
    End Sub

    Private Sub ObtenerDatos()
        Me.lblid_cliente.Text = CStr(oFactura.id_cliente)

        If oFactura.numero_factura.Length = 12 Then
            Me.txtNumero_factura_1.Text = oFactura.numero_factura.Substring(0, 4)
            Me.txtNumero_factura_2.Text = oFactura.numero_factura.Substring(4, 8)
        End If

        Me.dtpFecha_factura.Value = oFactura.fecha_factura
        Me.dtpFecha.Value = oFactura.fecha
        Me.txtIva_factura.Text = oFactura.iva_factura.ToString.Trim
        Me.txtTipo.Text = oFactura.tipo_factura
        ' Me.chkanulada.Checked = oFactura.anulada

        Try
            Me.txtTotal_letra.Text = oFactura.total_letra
        Catch ex As Exception

        End Try

        If oFactura.movimiento.Trim = strFactura Then
            Me.rbnFactura.Checked = True
        ElseIf oFactura.movimiento.Trim = strNC Then
            Me.rbnNC.Checked = True
        ElseIf oFactura.movimiento.Trim = strND Then
            Me.rbnND.Checked = True
        End If

        If oFactura.responsable_inscripto = True Then
            Me.rbnResponsable_inscripto.Checked = True
            Me.rbnResponsable_no_inscripto.Checked = False
        ElseIf oFactura.responsable_no_inscripto = True Then
            Me.rbnResponsable_inscripto.Checked = False
            Me.rbnResponsable_no_inscripto.Checked = True
        End If

        If oFactura.contado = True Then
            Me.rbnContado.Checked = True
            Me.rbnCuenta_corriente.Checked = False
        ElseIf oFactura.cuenta_corriente = True Then
            Me.rbnContado.Checked = False
            Me.rbnCuenta_corriente.Checked = True
        End If
        Me.txtImpuesto.Text = CStr(oFactura.impuesto)

        If oFactura.numero_recibo.Length = 12 Then
            Me.txtNumero_remito_1.Text = oFactura.numero_recibo.Substring(0, 4)
            Me.txtNumero_remito_2.Text = oFactura.numero_recibo.Substring(4, 8)
        End If
        Me.txtCondicion_pago.Text = oFactura.condicion_pago.Trim
        Me.txtReferencia.Text = oFactura.referencia.Trim
        '''  Me.txtOrden_compra.Text = CStr(oFactura.id_orden_compra)
    End Sub

    Private Sub AsignarDatos()
        oFactura.id_cliente = CInt(Me.lblid_cliente.Text)
        oFactura.numero_factura = Me.txtNumero_factura_1.Text & Me.txtNumero_factura_2.Text
        oFactura.fecha_factura = Me.dtpFecha_factura.Value.Date
        oFactura.fecha = Me.dtpFecha.Value.Date
        oFactura.iva_factura = CDec(Me.txtIva_factura.Text)
        oFactura.anulada = False
        oFactura.subtotal_factura = CDec(Me.txtSubtotal.Text)
        oFactura.tipo_factura = Me.txtTipo.Text


        oFactura.total_factura = CDec(Me.txtTotal.Text)


        Dim Total As Decimal = CDec(Me.txtTotal.Text)
        oFactura.total_letra = Numalet.ToCardinal(Total)

        If Me.rbnFactura.Checked Then
            oFactura.movimiento = strFactura
        ElseIf Me.rbnNC.Checked Then
            oFactura.movimiento = strNC
        ElseIf Me.rbnND.Checked Then
            oFactura.movimiento = strND
        End If

        'campos contado
        If Me.rbnContado.Checked Then
            oFactura.contado = True
            oFactura.cuenta_corriente = False
        ElseIf Me.rbnCuenta_corriente.Checked Then
            oFactura.contado = False
            oFactura.cuenta_corriente = True
        End If
        'campos responsable inscripto
        If Me.rbnResponsable_inscripto.Checked Then
            oFactura.responsable_inscripto = True
            oFactura.responsable_no_inscripto = False
            oFactura.total_iva = CDec(Me.txtIva.Text)
            oFactura.iva_no_inscripto = 0
        ElseIf Me.rbnResponsable_no_inscripto.Checked Then
            oFactura.responsable_inscripto = False
            oFactura.responsable_no_inscripto = True
            oFactura.total_iva = 0
            oFactura.iva_no_inscripto = CDec(Me.txtIva.Text)
        End If

        If Me.txtNumero_remito_1.Text = "" Or Me.txtNumero_remito_2.Text = "" Then
        Else
            oFactura.numero_recibo = Me.txtNumero_remito_1.Text & Me.txtNumero_remito_2.Text
        End If
        oFactura.impuesto = CDec(Me.txtImpuesto.Text)
        oFactura.condicion_pago = Me.txtCondicion_pago.Text
        oFactura.referencia = Me.txtReferencia.Text
        ''' oFactura.id_orden_compra = CInt(Me.txtOrden_compra.Text)
    End Sub


    Public Sub SoloLectura()
        Me.cmbCliente.Enabled = False
        Me.btnBuscaCliente.Enabled = False
        Me.txtNumero_factura_1.Enabled = False
        Me.txtNumero_factura_2.Enabled = False
        Me.dtpFecha_factura.Enabled = False
        Me.dtpFecha.Enabled = False
        Me.txtIva_factura.Enabled = False
        '  Me.anulada.Enabled = False
        Me.txtCondicion_pago.Enabled = False
        Me.txtReferencia.Enabled = False
        Me.btnGuardar.Visible = False
    End Sub

    Private Sub Guardar()
        'Dim idfactura As Integer
        Try
            Me.AsignarDatos()
            Select Case BanderaFactura

                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oFactura.Guardar()

                    Me.lblid_factura.Text = CStr(oFactura.id_factura)

                    oCuerpo_factura.UpdateFactura(CInt(Me.lblid_factura.Text))

                    '   Try
                    CType(Me.Owner, frmResumenCliente).RefrescarGrilla()
                    'Catch ex As Exception
                    '    CType(Me.Owner, frmAbmFactura).RefrescarGrilla()
                    'End Try



                    parametro_fac = CInt(Me.lblid_factura.Text)
                    ' Me.CargarCombos()
                    oFactura.Insertar()
                    Me.ObtenerDatos()
                    ' Me.LimpiarControles()

                    ' Me.cmbCliente.Focus()
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oFactura.Guardar()
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If Me.txtNumero_factura_1.Text = "" Or Me.txtNumero_factura_2.Text = "" Or _
        Me.txtImpuesto.Text = "" Or Me.txtIva_factura.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean

        If Me.lblid_cliente.Text = "0" Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de cliente")
            Exit Sub
        End If
        If Me.dgv1.RowCount < 1 Then
            MessageBox.Show("No se Puede Guardar una Factura sin Datos")
            Exit Sub
        End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar Todos los Campos")
            Exit Sub
        Else
            If BanderaFactura = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
            Me.btnImprimir.Enabled = True
            Me.btnNuevo.Enabled = True
            Me.btnGuardar.Enabled = False
            Me.btnAgregar.Enabled = False
            Me.btnBorrar.Enabled = False
            Me.btnModificar.Enabled = False
        End If

    End Sub

    Private Sub cmbCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCliente.SelectedIndexChanged
        If Me.cmbCliente.SelectedIndex >= 0 Then
            Me.lblid_cliente.Text = cmbCliente.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaCliente.Click
        Dim frmTemporal As New frmAbmCliente
        frmTemporal.ShowDialog()
        Me.CargarCliente()
        Me.cmbCliente.Focus()
        Me.cmbCliente.Text = ""
        Me.lblid_cliente.Text = "0"
    End Sub

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtNumero_factura_1.KeyPress, txtNumero_factura_2.KeyPress, _
    txtNumero_remito_1.KeyPress, txtNumero_remito_2.KeyPress
        Dim txtTemp As New TextBox
        txtTemp = CType(sender, TextBox)

        If e.KeyChar.ToString = vbCr Then
            If txtTemp.Name = "txtNumero_factura_1" Then
                Me.txtNumero_factura_1.Text = CompletarCeros(Me.txtNumero_factura_1.Text, 4)
            ElseIf txtTemp.Name = "txtNumero_factura_2" Then
                Me.txtNumero_factura_2.Text = CompletarCeros(Me.txtNumero_factura_2.Text, 8)
            ElseIf txtTemp.Name = "txtNumero_remito_1" Then
                Me.txtNumero_remito_1.Text = CompletarCeros(Me.txtNumero_remito_1.Text, 4)
            ElseIf txtTemp.Name = "txtNumero_remito_2" Then
                Me.txtNumero_remito_2.Text = CompletarCeros(Me.txtNumero_remito_2.Text, 8)
            End If
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If

        If (e.KeyChar.ToString >= "0" And e.KeyChar.ToString <= "9") Or e.KeyChar = vbBack Then
            '  e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles cmbCliente.KeyDown, dtpFecha_factura.KeyDown, dtpFecha.KeyDown
        If e.KeyValue = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtIva_factura.KeyPress, txtImpuesto.KeyPress
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

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.LimpiarControles()
        Me.cmbCliente.Focus()

        Me.btnImprimir.Enabled = False
        Me.btnNuevo.Enabled = False
        Me.btnGuardar.Enabled = True
        Me.btnAgregar.Enabled = True
        Me.btnBorrar.Enabled = True
        Me.btnModificar.Enabled = True
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'Dim frmimpresiontemporal As New FrmReporteFactura

        'Try
        '    Banderaprintpantalla = "factura"
        '    frmimpresiontemporal.ShowDialog()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try


    End Sub





    '--------------------------------
    'codigo del cuerpo de la factura
    '--------------------------------
    Public Sub RefrescarGrilla()
        Dim odt As DataTable

        odt = oCuerpo_factura.ConsultarTodo_2(CInt(Me.lblid_factura.Text))
        Me.dgv1.DataSource = odt
        Me.dgv1.Columns(0).Visible = False

        'Me.dgv1.Columns("item").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        ' Me.dgv1.Columns("item").DefaultCellStyle.Format = "n"

        Me.dgv1.Columns("cantidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgv1.Columns("cantidad").DefaultCellStyle.Format = "n"
        Me.dgv1.Columns("precio_unitario").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgv1.Columns("precio_unitario").DefaultCellStyle.Format = "c"
        Me.dgv1.Columns("importe").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgv1.Columns("importe").DefaultCellStyle.Format = "c"

        'tamaño de la grilla
        'Me.dgv1.Columns("item").Width = 60
        Me.dgv1.Columns("cantidad").Width = 100
        Me.dgv1.Columns("precio_unitario").Width = 130
        Me.dgv1.Columns("importe").Width = 100
        Me.dgv1.Columns("descripcion").Width = 400

        'calculo de totales
        Me.txtSubtotal.Text = FormatCurrency(oCuerpo_factura.GetSum(CInt(Me.lblid_factura.Text)))
        Me.txtIva.Text = FormatCurrency((CDec(Me.txtSubtotal.Text) + CDec(Me.txtImpuesto.Text)) * CDec(Me.txtIva_factura.Text) / 100)
        Me.txtTotal.Text = FormatCurrency(CDec(Me.txtSubtotal.Text) + CDec(Me.txtIva.Text) + CDec(Me.txtImpuesto.Text))

        'total en letras
        Dim Total As Decimal = CDec(Me.txtTotal.Text)
        Me.txtTotal_letra.Text = Numalet.ToCardinal(Total)
    End Sub

    Private Sub dgv1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv1.CurrentCellChanged
        Try
            Me.lblid_pk.Text = CStr(Me.dgv1.Item(0, Me.dgv1.CurrentRow.Index).Value)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Botones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnSalir.Click, btnAgregar.Click, btnBorrar.Click, btnModificar.Click
        Dim btnTemp As New Button
        Dim frmDetalle As New frmDetalleCuerpo_factura2
        btnTemp = CType(sender, Button)
        Try
            Select Case btnTemp.Name
                Case "btnAgregar"
                    BanderaCuerpo_factura = 1
                    Me.AddOwnedForm(frmDetalle)
                    oCuerpo_factura.Insertar()
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                Case "btnModificar"
                    If Not IsNumeric(Me.lblid_pk.Text) Then
                        Exit Sub
                    End If

                    If Me.lblid_pk.Text <= "0" Then
                        ' MessageBox.Show("Debe seleccionar un registro")
                        Exit Sub
                    End If

                    BanderaCuerpo_factura = 2
                    Me.AddOwnedForm(frmDetalle)
                    oCuerpo_factura.Modificar(CInt(Me.lblid_pk.Text))
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                    RefrescarGrilla()
                Case "btnBorrar"
                    If Not IsNumeric(Me.lblid_pk.Text) Then
                        Exit Sub
                    End If

                    If Me.lblid_pk.Text <= "0" Then
                        ' MessageBox.Show("Debe seleccionar un registro")
                        Exit Sub
                    End If

                    oCuerpo_factura.Borrar(CInt(Me.lblid_pk.Text))
                    RefrescarGrilla()
                Case "btnAyuda"
                    'Process.Start(PathAyuda + "frmAbmCuerpo_factura.avi")
                Case "btnSalir"
                    oCuerpo_factura.BorrarResto()
                    If BanderaFactura = 2 Then
                        Me.AsignarDatos()
                        oFactura.Guardar()
                    End If
                    Me.Close()
            End Select
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtImpuesto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles txtImpuesto.LostFocus, txtIva_factura.LostFocus
        Me.RefrescarGrilla()
    End Sub





    Private Sub rbnFactura_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnFactura.CheckedChanged
        Me.txtcomprobante.Text = "FACTURA"
    End Sub

    Private Sub rbnNC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnNC.CheckedChanged
        Me.txtcomprobante.Text = "NOTA DE CREDITO"
    End Sub

    Private Sub rbnND_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnND.CheckedChanged
        Me.txtcomprobante.Text = "NOTA DE DEBITO"
    End Sub


End Class