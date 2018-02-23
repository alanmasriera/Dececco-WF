Public Class frmDetalleCuerpo_factura_proveedor

   Private Sub frmDetalleCuerpo_factura_proveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.ttGeneral.SetToolTip(Me.btnBuscaFactura_proveedor, "Buscar Nuevo Factura_proveedor")
       Me.ttGeneral.SetToolTip(Me.btnBuscaProducto, "Buscar Nuevo Producto")
       Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Cuerpo_factura_proveedor")
       Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
       Try
           ObtenerDatos()

            'Me.cmbFactura_proveedor.Text = oFactura_proveedor.GetOne(CInt(Me.lblid_Factura_proveedor.Text)).Rows(0).Item("nombre Factura proveedor").ToString.Trim
            Me.cmbproducto.Text = oProducto.GetOne(CInt(Me.lblid_producto.Text)).Rows(0).Item("nombre Producto").ToString.Trim
        Catch ex As Exception
            '    Errores(ex)
        End Try

        Me.lblid_factura_proveedor.Text = CType(Me.Owner, frmDetalleFactura_proveedor).lblid_factura_proveedor.Text
        Me.lblid_proveedor.Text = CType(Me.Owner, frmDetalleFactura_proveedor).lblid_proveedor.Text

        If BanderaCuerpo_factura_proveedor = 1 Then
            Me.LimpiarControles()
        End If

        Me.Text = "Cuerpo_factura_proveedor" & vgNombreFormulario
        Me.CancelButton = Me.btnSalir
        'Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False
    End Sub

    Sub CargarCombos()
        Me.CargarProducto()
    End Sub

    Sub CargarProducto()
        Dim odt As New DataTable

        odt = oProducto.GetCmb2
        With Me.cmbproducto
            .DataSource = odt
            .DisplayMember = "nombre_Producto"
            .ValueMember = "id_Producto"
        End With
        If Me.cmbproducto.SelectedIndex >= 0 Then
            cmbproducto.SelectedIndex = 0
            Me.lblid_producto.Text = cmbproducto.SelectedValue.ToString
        End If
    End Sub

    Sub LimpiarControles()
        'Me.lblid_factura_proveedor.Text = "0"
        'Me.cmbFactura_proveedor.Text =  ""
        Me.lblid_producto.Text = "0"
        Me.cmbproducto.Text = ""
        Me.txtcantidad.Text = ""
        Me.txtprecio.Text = ""
        Me.txtalicuota.Text = ""
        Me.txtiva.Text = ""
        Me.chktilde.Checked = False
        Me.txtCodigo.Text = ""
        Me.txtimpuesto_interno.Text = ""
        Me.txtpack.Text = ""
        Me.txtImpuestoInternoTotal.Text = ""
    End Sub

    Private Sub ObtenerDatos()
        'Me.lblid_factura_proveedor.Text = oCuerpo_factura_proveedor.id_factura_proveedor.ToString
        Me.lblid_producto.Text = oCuerpo_factura_proveedor.id_producto.ToString
        Me.txtcantidad.Text = oCuerpo_factura_proveedor.cantidad.ToString.Trim
        Me.txtprecio.Text = oCuerpo_factura_proveedor.precio.ToString.Trim
        Me.txtalicuota.Text = oCuerpo_factura_proveedor.alicuota.ToString.Trim
        Me.txtiva.Text = oCuerpo_factura_proveedor.iva.ToString.Trim
        Me.chktilde.Checked = oCuerpo_factura_proveedor.tilde
        Me.txtimpuesto_interno.Text = oCuerpo_factura_proveedor.impuesto_interno.ToString
        Me.txtpack.Text = oCuerpo_factura_proveedor.pack.ToString
    End Sub

    Private Sub AsignarDatos()
        oCuerpo_factura_proveedor.id_factura_proveedor = CInt(Me.lblid_factura_proveedor.Text)
        oCuerpo_factura_proveedor.id_producto = CInt(Me.lblid_producto.Text)
        oCuerpo_factura_proveedor.cantidad = CDec(Me.txtcantidad.Text)
        oCuerpo_factura_proveedor.precio = CDec(Me.txtprecio.Text)
        oCuerpo_factura_proveedor.alicuota = CDec(Me.txtalicuota.Text)
        oCuerpo_factura_proveedor.iva = CDec(Me.txtiva.Text)
        oCuerpo_factura_proveedor.tilde = Me.chktilde.Checked
        oCuerpo_factura_proveedor.impuesto_interno = CDec(Me.txtimpuesto_interno.Text)
        oCuerpo_factura_proveedor.pack = CDec(Me.txtpack.Text)
    End Sub

    Public Sub SoloLectura()
        'Me.cmbFactura_proveedor.Enabled = False
        'Me.btnBuscaFactura_proveedor.Enabled = False
        Me.cmbproducto.Enabled = False
        Me.btnBuscaproducto.Enabled = False
        Me.txtcantidad.Enabled = False
        Me.txtprecio.Enabled = False
        Me.txtalicuota.Enabled = False
        Me.txtiva.Enabled = False
        Me.chktilde.Enabled = False
        Me.btnGuardar.Visible = False
        Me.txtimpuesto_interno.Enabled = False
    End Sub

    Private Sub Guardar()
        Try
            Dim odtControl As New DataTable
            odtControl = oCuerpo_factura_proveedor.GetAllFacturaOne(CInt(Me.lblid_factura_proveedor.Text), CInt(Me.lblid_producto.Text))
            If odtControl.Rows.Count > 0 And BanderaCuerpo_factura_proveedor = 1 Then
                MessageBox.Show("Sr. Usuario: El producto ya ha sido cargado a la factura")
                Exit Sub
            End If

            Me.AsignarDatos()
            If oCuerpo_factura_proveedor.Exist() Then
                If BanderaCuerpo_factura_proveedor = 1 Then
                    MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
                    Exit Sub
                ElseIf BanderaCuerpo_factura_proveedor = 2 Then
                    If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                        = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            Select Case BanderaCuerpo_factura_proveedor
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oCuerpo_factura_proveedor.Guardar()
                    CType(Me.Owner, frmDetalleFactura_proveedor).RefrescarGrillaCuerpoFactura()
                    'Me.CargarCombos()
                    oCuerpo_factura_proveedor.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()

                    If rbnCodigo.Checked = True Then
                        Me.txtCodigo.Focus()
                    Else
                        Me.cmbproducto.Focus()
                    End If

                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oCuerpo_factura_proveedor.Guardar()
                    Me.Close()
            End Select
        Catch ex As Exception
            Errores(ex)
        End Try
    End Sub

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If Me.txtcantidad.Text = "" Or Me.txtalicuota.Text = "" Or Me.txtiva.Text = "" Or _
        Me.txtprecio.Text = "" Or Me.txtimpuesto_interno.Text = "" Or Me.txtpack.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean

        'If CDbl(Me.lblid_factura_proveedor.Text) = 0 Then
        '    MessageBox.Show("Debe Seleccionar un Dato del Combo de factura_proveedor")
        '    Exit Sub
        'End If

        If CDbl(Me.lblid_producto.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de producto")
            Exit Sub
        End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaCuerpo_factura_proveedor = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cmbProducto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbproducto.SelectedIndexChanged
        If Me.cmbproducto.SelectedIndex >= 0 Then
            Me.lblid_producto.Text = cmbproducto.SelectedValue.ToString
        End If
        If Not IsNumeric(Me.lblid_producto.Text) Or Not IsNumeric(Me.lblid_proveedor.Text) Then
            Exit Sub
        End If

        Dim odt As New DataTable
        odt = oPrecio.GetProductoId(CInt(Me.lblid_proveedor.Text), CInt(Me.lblid_producto.Text))

        If odt.Rows.Count <= 0 Then
            MessageBox.Show("El Producto no Esta Cargado")
            Me.txtCodigo.Text = ""
            Me.txtCodigo.Focus()
            Exit Sub
        End If

        With odt.Rows(0)
            Me.txtalicuota.Text = .Item("alicuota").ToString.Trim()
            Me.txtprecio.Text = .Item("precio").ToString.Trim()
            Me.lblid_producto.Text = .Item("id_producto").ToString
            Me.txtimpuesto_interno.Text = .Item("impuesto_interno").ToString
        End With
        Me.txtiva.Text = CStr(CDec(Me.txtprecio.Text) * CDec(Me.txtalicuota.Text) / 100)
    End Sub

    Private Sub btnBuscaProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaproducto.Click
        Dim frmTemporal As New frmAbmProducto
        Me.AddOwnedForm(frmTemporal)
        parametro_Proveedor = CInt(Me.lblid_proveedor.Text)
        frmTemporal.ShowDialog()
        Me.CargarProducto()
        Me.cmbproducto.Focus()
        Me.cmbproducto.Text = ""
        Me.lblid_producto.Text = "0"
    End Sub

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles chktilde.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles cmbproducto.KeyDown
        If CDbl(e.KeyValue.ToString) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtcantidad.KeyPress, txtprecio.KeyPress, txtalicuota.KeyPress, txtiva.KeyPress, txtimpuesto_interno.KeyPress, _
    txtpack.KeyPress, txtImpuestoInternoTotal.KeyPress
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

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.txtcantidad.Focus()
        End If
    End Sub

    Private Sub txtCodigo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.LostFocus
        Try
            Dim odt As New DataTable

            'controlo que no este vacio
            If Me.txtCodigo.Text = "" Then
                Exit Sub
            End If

            'odt = oProducto.GetOneCodigo(Me.txtCodigo.Text)
            odt = oPrecio.GetProducto(CInt(Me.lblid_proveedor.Text), Me.txtCodigo.Text)

            If odt.Rows.Count <= 0 Then
                MessageBox.Show("El Producto no Esta Cargado")
                Me.txtCodigo.Text = ""
                Me.txtCodigo.Focus()
                Exit Sub
            End If

            With odt.Rows(0)
                Me.txtalicuota.Text = .Item("alicuota").ToString.Trim()
                Me.txtprecio.Text = .Item("precio").ToString.Trim()
                Me.lblid_producto.Text = .Item("id_producto").ToString
                Me.txtimpuesto_interno.Text = .Item("impuesto_interno").ToString
                Me.txtpack.Text = .Item("pack").ToString

                Me.cmbproducto.Text = oProducto.GetOne_2(CInt(Me.lblid_producto.Text)).Rows(0).Item("nombre Producto").ToString.Trim
            End With
            Me.txtiva.Text = CStr(CDec(Me.txtprecio.Text) * CDec(Me.txtalicuota.Text) / 100)

            'Me.cmbproducto.Text = oProducto.GetOneCodigo(Me.txtCodigo.Text).Rows(0).Item("nombre_Producto").ToString.Trim()
            Me.cmbproducto.Text = oPrecio.GetProducto(CInt(Me.lblid_proveedor.Text), Me.txtCodigo.Text).Rows(0).Item("nombre_Producto").ToString.Trim()


        Catch ex As Exception
            Errores(ex)
        End Try
    End Sub

    Private Sub btnBuscaPrecio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaPrecio.Click
        Dim frmTemporal As New frmAbmPrecio
        frmTemporal.ShowDialog()
        Me.txtCodigo.Text = ""
        Me.txtCodigo.Focus()
    End Sub

    Private Sub txtprecio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles txtprecio.TextChanged, txtalicuota.TextChanged
        If Me.txtalicuota.Text = "" Or Me.txtprecio.Text = "" Then
            Exit Sub
        End If
        Me.txtiva.Text = CStr(CDec(Me.txtprecio.Text) * CDec(Me.txtalicuota.Text) / 100)
    End Sub

    Private Sub txtImpuestoInternoTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImpuestoInternoTotal.TextChanged
        If Me.txtcantidad.Text = "" Or Me.txtImpuestoInternoTotal.Text = "" Then
            Exit Sub
        End If
        If Not IsNumeric(Me.txtImpuestoInternoTotal.Text) Then
            Exit Sub
        End If
        Dim decTemp As Decimal = 0
        decTemp = CDec(Me.txtImpuestoInternoTotal.Text) / CDec(Me.txtcantidad.Text)
        Me.txtimpuesto_interno.Text = FormatNumber(decTemp)
    End Sub



End Class
