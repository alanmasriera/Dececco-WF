Public Class frmDetallePrecio

    Private Sub frmDetallePrecio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttGeneral.SetToolTip(Me.btnBuscaproducto, "Buscar Nuevo Producto")
        Me.ttGeneral.SetToolTip(Me.btnBuscaproveedor, "Buscar Nuevo Proveedor")
        Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Precio")
        Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()

            Me.cmbproducto.Text = oProducto.GetOne_2(CInt(Me.lblid_producto.Text)).Rows(0).Item("nombre Producto").ToString.Trim
            Me.cmbproveedor.Text = oProveedor.GetOne(CInt(Me.lblid_proveedor.Text)).Rows(0).Item("nombre Proveedor").ToString.Trim
        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try

        If BanderaPrecio = 1 Then
            Me.LimpiarControles()
        End If
        Me.Text = "Precio"
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False

    End Sub

    Sub CargarCombos()
        Me.CargarProducto()
        Me.CargarProveedor()
    End Sub

    Sub CargarProducto()
        Dim odt As New DataTable

        odt = oProducto.GetCmb2
        With Me.cmbProducto
            .DataSource = odt
            .DisplayMember = "nombre_Producto"
            .ValueMember = "id_Producto"
        End With
        If Me.cmbProducto.SelectedIndex >= 0 Then
            cmbProducto.SelectedIndex = 0
            Me.lblid_Producto.Text = cmbProducto.SelectedValue.ToString
        End If
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
            Me.lblid_Proveedor.Text = cmbProveedor.SelectedValue.ToString
        End If
    End Sub

    Sub LimpiarControles()
        Me.lblid_producto.Text = "0"
        Me.cmbProducto.Text = ""
        Me.lblid_proveedor.Text = "0"
        Me.cmbProveedor.Text = ""
        Me.txtprecio.Text = ""
        Me.txtalicuota.Text = ""
        Me.txtiva.Text = ""
        Me.txtimpuesto_interno.Text = "0"
        Me.txtmargen_ganancia.Text = "0"
        Me.txtcod_producto_proveedor.Text = ""
        Me.txtPack.Text = ""
        Me.txtPrecio_venta_unitario.Text = ""
        Me.txtCodigo.Text = ""
        Me.txtPrecio_venta_mayorista.Text = ""
        Me.txtPrecio_venta_publico.Text = ""
        Me.txtBonificacion1.Text = ""
        Me.txtBonificacion2.Text = ""
    End Sub

    Private Sub ObtenerDatos()
        Me.lblid_producto.Text = oPrecio.id_producto.ToString
        Me.lblid_proveedor.Text = oPrecio.id_proveedor.ToString
        Me.txtprecio.Text = oPrecio.precio.ToString.Trim
        Me.txtalicuota.Text = oPrecio.alicuota.ToString.Trim
        Me.txtiva.Text = oPrecio.iva.ToString.Trim
        Me.txtimpuesto_interno.Text = oPrecio.impuesto_interno.ToString.Trim
        Me.txtmargen_ganancia.Text = oPrecio.margen_ganancia.ToString.Trim
        Me.txtcod_producto_proveedor.Text = oPrecio.cod_producto_proveedor.Trim
        Me.txtPack.Text = oPrecio.pack.ToString
        Me.txtPrecio_venta_unitario.Text = oPrecio.precio_venta_unitario.ToString
        Me.txtPrecio_venta_mayorista.Text = oPrecio.precio_venta_mayorista.ToString
        Me.txtPrecio_venta_publico.Text = oPrecio.precio_venta_publico.ToString
        Me.txtBonificacion1.Text = oPrecio.bonificacion1.ToString()
        Me.txtBonificacion2.Text = oPrecio.bonificacion2.ToString()
    End Sub

    Private Sub AsignarDatos()
        oPrecio.id_producto = CInt(Me.lblid_producto.Text)
        oPrecio.id_proveedor = CInt(Me.lblid_proveedor.Text)
        oPrecio.precio = CDec(Me.txtprecio.Text)
        oPrecio.alicuota = CDec(Me.txtalicuota.Text)
        oPrecio.iva = CDec(Me.txtiva.Text)
        oPrecio.impuesto_interno = CDec(Me.txtimpuesto_interno.Text)
        oPrecio.margen_ganancia = CDec(Me.txtmargen_ganancia.Text)
        oPrecio.cod_producto_proveedor = Me.txtcod_producto_proveedor.Text
        oPrecio.pack = CDec(Me.txtPack.Text)
        oPrecio.precio_venta_unitario = CDec(Me.txtPrecio_venta_unitario.Text)
        oPrecio.precio_venta_mayorista = CDec(Me.txtPrecio_venta_mayorista.Text)
        oPrecio.precio_venta_publico = CDec(Me.txtPrecio_venta_publico.Text)
        oPrecio.bonificacion1 = CDec(Me.txtBonificacion1.Text)
        oPrecio.bonificacion2 = CDec(Me.txtBonificacion2.Text)
    End Sub

    Public Sub SoloLectura()
        Me.cmbProducto.Enabled = False
        Me.btnBuscaProducto.Enabled = False
        Me.cmbProveedor.Enabled = False
        Me.btnBuscaProveedor.Enabled = False
        Me.txtprecio.Enabled = False
        Me.txtalicuota.Enabled = False
        Me.txtiva.Enabled = False
        Me.txtimpuesto_interno.Enabled = False
        Me.txtmargen_ganancia.Enabled = False
        Me.txtcod_producto_proveedor.Enabled = False
        Me.btnGuardar.Visible = False
        Me.txtPack.Enabled = False
        Me.txtPrecio_venta_unitario.Enabled = False
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            If oPrecio.Exist() Then
                If BanderaPrecio = 1 Then
                    MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
                    Exit Sub
                ElseIf BanderaPrecio = 2 Then
                    If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                        = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            Select Case BanderaPrecio
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oPrecio.Guardar()
                    CType(Me.Owner, frmAbmPrecio).RefrescarGrilla()
                    Me.CargarCombos()
                    oPrecio.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.txtCodigo.Focus()
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oPrecio.Guardar()
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If Me.txtprecio.Text = "" Or Me.txtalicuota.Text = "" Or Me.txtimpuesto_interno.Text = "" Or _
        Me.txtiva.Text = "" Or Me.txtmargen_ganancia.Text = "" Or Me.txtPack.Text = "" Or Me.txtPrecio_venta_unitario.Text = "" Or _
        Me.txtPrecio_venta_mayorista.Text = "" Or Me.txtPrecio_venta_publico.Text = "" Or Me.txtBonificacion2.Text = "" Or Me.txtBonificacion1.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean

        If CDbl(Me.lblid_producto.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de producto")
            Exit Sub
        End If
        If CDbl(Me.lblid_proveedor.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de proveedor")
            Exit Sub
        End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaPrecio = 1 Then
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
        If Not IsNumeric(Me.lblid_producto.Text) Then
            Exit Sub
        End If
        Dim odt As New DataTable
        odt = oProducto.GetOne(CInt(Me.lblid_producto.Text))
        If odt.Rows.Count <= 0 Then
            Exit Sub
        Else
            Me.txtPack.Text = odt.Rows(0).Item("pack").ToString
        End If
    End Sub

    Private Sub btnBuscaProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaproducto.Click
        Dim frmTemporal As New frmAbmProducto
        frmTemporal.ShowDialog()
        Me.CargarProducto()
        Me.cmbproducto.Focus()
        Me.cmbproducto.Text = ""
        Me.lblid_producto.Text = "0"
    End Sub

    Private Sub cmbProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbproveedor.SelectedIndexChanged
        If Me.cmbproveedor.SelectedIndex >= 0 Then
            Me.lblid_proveedor.Text = cmbproveedor.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaproveedor.Click
        Dim frmTemporal As New frmAbmProveedor
        frmTemporal.ShowDialog()
        Me.CargarProveedor()
        Me.cmbproveedor.Focus()
        Me.cmbproveedor.Text = ""
        Me.lblid_proveedor.Text = "0"
    End Sub

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtcod_producto_proveedor.KeyPress, txtCodigo.KeyPress
        Dim txtTemp As TextBox
        txtTemp = CType(sender, TextBox)

        If e.KeyChar.ToString = vbCr Then
            If txtTemp.Name = "txtCodigo" Then
                Me.FillDatos()
            End If
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles cmbproducto.KeyDown, cmbproveedor.KeyDown
        If CDbl(e.KeyValue.ToString) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtprecio.KeyPress, txtalicuota.KeyPress, txtiva.KeyPress, txtimpuesto_interno.KeyPress, _
    txtmargen_ganancia.KeyPress, txtPack.KeyPress, txtPrecio_venta_unitario.KeyPress, txtPrecio_venta_mayorista.KeyPress, _
    txtPrecio_venta_publico.KeyPress, txtBonificacion2.KeyPress, txtBonificacion1.KeyPress

        Dim txtTemp As TextBox
        txtTemp = CType(sender, TextBox)

        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)

            If txtTemp.Name = "txtprecio" Then
                Me.txtprecio.Text = FormatNumber(Me.txtprecio.Text, 2)
            End If
            If txtTemp.Name = "txtmargen_ganancia" Then
                Me.txtmargen_ganancia.Text = FormatNumber(Me.txtmargen_ganancia.Text, 2)
            End If
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

    Private Sub txtprecio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles txtprecio.TextChanged, txtalicuota.TextChanged

        If Me.txtprecio.Text = "" Or Me.txtalicuota.Text = "" Or Me.txtBonificacion1.Text = "" Or Me.txtBonificacion2.Text = "" Then
            'MessageBox.Show(" Debe ingresar el Precio Costo ,Alicuota, Bonificacion1 y Bonificacion2 para calcular el Iva.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Me.txtprecio.Focus()
            Exit Sub
        End If

        Dim decBon1 As Decimal = 0
        Dim decBon2 As Decimal = 0
        decBon1 = CDec(Me.txtprecio.Text) * CDec(Me.txtBonificacion1.Text) / 100
        decBon2 = CDec(Me.txtprecio.Text) * CDec(Me.txtBonificacion2.Text) / 100

        Me.txtiva.Text = CStr((CDec(Me.txtprecio.Text) - decBon1 - decBon2) * CDec(Me.txtalicuota.Text) / 100)
        Me.txtPrecio_con_iva.Text = CStr(CDec(Me.txtprecio.Text) - decBon1 - decBon2 + CDec(Me.txtiva.Text))
    End Sub

    Private Sub txtmargen_ganancia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmargen_ganancia.TextChanged
        If Me.txtmargen_ganancia.Text = "" Or Me.txtiva.Text = "" Or Me.txtprecio.Text = "" Or Me.txtalicuota.Text = "" Or _
            Me.txtimpuesto_interno.Text = "" Or Me.txtPack.Text = "" Then
            Exit Sub
        End If

        Dim total As Decimal = 0
        total = (CDec(Me.txtPrecio_con_iva.Text) / CDec(txtPack.Text) * (1 + CDec(Me.txtmargen_ganancia.Text) / 100))

        Select Case vgNombrePermiso
            Case "esquiu_f", "esquiu_c"
                'sin redondeo
                Me.txtPrecio_venta_unitario.Text = FormatNumber(total)
            Case Else
                Me.txtPrecio_venta_unitario.Text = FormatNumber(Math.Round(total, 0))

        End Select

    End Sub


    'llena el combo y asociados
    Sub FillDatos()
        Dim odt As New DataTable
        Dim odt2 As New DataTable
        odt = oProducto.GetOneCodigo(Me.txtCodigo.Text)

        If odt.Rows.Count <= 0 Then
            MessageBox.Show("Codigo de Producto Inexistente")
            Exit Sub
        End If

        Me.lblid_producto.Text = odt.Rows(0).Item("id_producto").ToString
        Me.cmbproducto.Text = oProducto.GetOne_2(CInt(Me.lblid_producto.Text)).Rows(0).Item("nombre Producto").ToString.Trim

        '  Me.txtDescripcion.Text = oProducto.GetOneCodigo(Me.txtCodigo.Text).Rows(0).Item("nombre_Producto").ToString.Trim

        Me.txtPack.Text = odt.Rows(0).Item("pack").ToString
    End Sub


    'Private Sub txtBonificacion2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBonificacion2.LostFocus
    '    If Me.txtprecio.Text = "" Or Me.txtBonificacion1.Text = "" Or Me.txtBonificacion2.Text = "" Then
    '        MessageBox.Show(" Debe ingresar el Precio Costo , Bonificacion1 y Bonificacion2 para calcular el Iva.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Me.txtprecio.Focus()
    '        Exit Sub
    '    End If
    '    Dim decIva As Decimal = 0
    '    decIva = CDec(Me.txtprecio.Text) - CDec(Me.txtBonificacion1.Text) - CDec(Me.txtBonificacion2.Text)
    '    Me.txtiva.Text = CStr(decIva)

    'End Sub

End Class
