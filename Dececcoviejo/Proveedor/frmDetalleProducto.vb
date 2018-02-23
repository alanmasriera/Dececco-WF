Public Class frmDetalleProducto
    Dim idprecio As Integer = 0
    Dim idstock As Integer = 0
   Private Sub frmDetalleProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnBuscaSubtipo_producto, "Buscar Nuevo Subtipo_producto")
       Me.ttGeneral.SetToolTip(Me.btnBuscaMarca, "Buscar Nuevo Marca")
       Me.ttGeneral.SetToolTip(Me.btnBuscaUnidad, "Buscar Nuevo Unidad")
       Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Producto")
       Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            Try
                ObtenerDatos()

                Me.cmbsubtipo_producto.Text = oSubtipo_producto.GetOne_2(CInt(Me.lblid_subtipo_producto.Text)).Rows(0).Item("nombre_Subtipo_producto").ToString.Trim
                Me.cmbmarca.Text = oMarca.GetOne(CInt(Me.lblid_marca.Text)).Rows(0).Item("nombre_Marca").ToString.Trim
                Me.cmbunidad.Text = oUnidad.GetOne(CInt(Me.lblid_unidad.Text)).Rows(0).Item("nombre_Unidad").ToString.Trim
            Catch ex As Exception

            End Try


            Dim odtPrecio As New DataTable
            odtPrecio = oPrecio.GetProductoProducto(oProducto.id_producto)

         
            Me.txtprecio.Text = CStr(odtPrecio.Rows(0).Item("precio"))
            Me.txtBonificacion1.Text = CStr(odtPrecio.Rows(0).Item("bonificacion1"))
            Me.txtBonificacion2.Text = CStr(odtPrecio.Rows(0).Item("bonificacion2"))
            Me.txtalicuota.Text = CStr(odtPrecio.Rows(0).Item("alicuota"))
            Me.txtiva.Text = CStr(odtPrecio.Rows(0).Item("iva"))
           
            Me.lblid_proveedor.Text = CStr(odtPrecio.Rows(0).Item("id_proveedor"))

            Me.txtmargen_ganancia.Text = CStr(odtPrecio.Rows(0).Item("margen_ganancia"))

            Me.cmbproveedor.Text = oProveedor.GetOne(CInt(Me.lblid_proveedor.Text)).Rows(0).Item("nombre Proveedor").ToString.Trim



            Dim odtStock As New DataTable
            odtStock = oStock.GetAllProducto(oProducto.id_producto)

            Me.txtstock.Text = "1" 'CStr(odtStock.Rows(0).Item("stock"))
            idstock = CInt(odtStock.Rows(0).Item("id_stock"))
            idprecio = CInt(odtPrecio.Rows(0).Item("id_precio"))
            Me.lblid_almacen.Text = CStr(odtStock.Rows(0).Item("id_almacen"))
            Me.cmbalmacen.Text = oAlmacen.GetOne(CInt(Me.lblid_almacen.Text)).Rows(0).Item("nombre Almacen").ToString.Trim
        Catch ex As Exception
            '    Errores(ex)
        End Try

        If BanderaProducto = 1 Then
            Try
                Me.LimpiarControles()
                Me.Panel1.Visible = True
                Me.cmbproveedor.Text = oProveedor.GetOne(parametro_Proveedor).Rows(0).Item("nombre Proveedor").ToString.Trim
                Me.lblid_proveedor.Text = CStr(parametro_Proveedor)
            Catch ex As Exception

            End Try

        End If
        Me.Text = "Producto"
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False
    End Sub

    Sub CargarCombos()
        Me.CargarSubtipo_producto()
        Me.CargarMarca()
        Me.CargarUnidad()
        Me.CargarProveedor()
        Me.CargarAlmacen()
    End Sub

    Sub CargarSubtipo_producto()
        Dim odt As New DataTable

        odt = oSubtipo_producto.GetCmb_2
        With Me.cmbsubtipo_producto
            .DataSource = odt
            .DisplayMember = "nombre_Subtipo_producto"
            .ValueMember = "id_Subtipo_producto"
        End With
        If Me.cmbsubtipo_producto.SelectedIndex >= 0 Then
            cmbsubtipo_producto.SelectedIndex = 0
            Me.lblid_subtipo_producto.Text = cmbsubtipo_producto.SelectedValue.ToString
        End If
    End Sub

    Sub CargarMarca()
        Dim odt As New DataTable

        odt = oMarca.GetCmb
        With Me.cmbmarca
            .DataSource = odt
            .DisplayMember = "nombre_Marca"
            .ValueMember = "id_Marca"
        End With
        If Me.cmbmarca.SelectedIndex >= 0 Then
            cmbmarca.SelectedIndex = 0
            Me.lblid_marca.Text = cmbmarca.SelectedValue.ToString
        End If
    End Sub

    Sub CargarUnidad()
        Dim odt As New DataTable

        odt = oUnidad.GetCmb
        With Me.cmbunidad
            .DataSource = odt
            .DisplayMember = "nombre_Unidad"
            .ValueMember = "id_Unidad"
        End With
        If Me.cmbunidad.SelectedIndex >= 0 Then
            cmbunidad.SelectedIndex = 0
            Me.lblid_unidad.Text = cmbunidad.SelectedValue.ToString
        End If
    End Sub

    Sub LimpiarControles()
        Me.txtnombre_producto.Text = ""
        Me.txtdescripcion.Text = ""
        Me.txtabreviatura.Text = ""
        Me.txtubicacion.Text = ""
        Me.txtPack.Text = ""
        Me.txtstock_ideal.Text = ""
        Me.txtstock_minimo.Text = ""
        Me.txtcantidad_compra.Text = ""
        Me.txtcantidad_ingreso.Text = "0"
        Me.lblid_subtipo_producto.Text = "1"
        Me.cmbsubtipo_producto.Text = ""
        Me.lblid_marca.Text = "1"
        Me.cmbmarca.Text = ""
        Me.lblid_unidad.Text = "1"
        Me.cmbunidad.Text = ""
        Me.chktilde.Checked = False
        Me.txtTipo_venta.Text = ""

        'Me.lblid_producto.Text = "0"
        'Me.cmbProducto.Text = ""
        Me.lblid_proveedor.Text = "0"
        Me.cmbproveedor.Text = ""
        Me.txtprecio.Text = "0"
        'Me.txtalicuota.Text = ""
        'Me.txtiva.Text = ""
        'Me.txtimpuesto_interno.Text = "0"
        Me.txtmargen_ganancia.Text = "0"
        Me.txtcod_producto_proveedor.Text = "0"
        Me.txtPrecio_venta_unitario.Text = ""
        'Me.txtCodigo.Text = ""

        Me.lblid_almacen.Text = "0"
        Me.cmbalmacen.Text = ""
        Me.txtstock.Text = ""

        Me.txtubicacion.Text = " - "
        Me.txtstock.Text = CStr(1)
        Me.txtPack.Text = CStr(1)
        Me.txtstock_ideal.Text = CStr(1)
        Me.txtstock_minimo.Text = CStr(1)
        Me.txtcantidad_compra.Text = CStr(1)
        Me.txtcantidad_ingreso.Text = CStr(1)
        Me.txtTipo_venta.Text = "U"

        Me.txtBonificacion1.Text = ""
        Me.txtBonificacion2.Text = ""
        Me.txtalicuota.Text = ""



        'Virikina_rio
        If vgNombrePermiso = "virikyna_rio" Then
            Me.txtubicacion.Text = " - "
            Me.txtPack.Text = CStr(1)
            Me.txtstock_ideal.Text = CStr(1)
            Me.txtstock_minimo.Text = CStr(1)
            Me.txtcantidad_compra.Text = CStr(1)
            Me.txtcantidad_ingreso.Text = CStr(1)
            Me.txtTipo_venta.Text = "U"

            Me.txtubicacion.Enabled = False
            Me.txtPack.Enabled = False
            Me.txtstock_ideal.Enabled = False
            Me.txtstock_minimo.Enabled = False
            ' Me.txtcod_producto_proveedor.Enabled = False
            ' Me.txtprecio.Enabled = False
            ' Me.txtmargen_ganancia.Enabled = False
            Me.txtcantidad_compra.Enabled = False
        End If

        ''libreria MC
        If vgNombrePermiso = "libreria_mc" Then
            Me.txtubicacion.Text = " - "
            Me.txtPack.Text = CStr(1)
            Me.txtstock_ideal.Text = CStr(1)
            Me.txtstock_minimo.Text = CStr(1)
            Me.txtcantidad_compra.Text = CStr(1)
            Me.txtcantidad_ingreso.Text = CStr(1)
            Me.txtTipo_venta.Text = "U"

            Me.txtubicacion.Enabled = False
            Me.txtPack.Enabled = False
            Me.txtstock_ideal.Enabled = False
            Me.txtstock_minimo.Enabled = False
            Me.txtcod_producto_proveedor.Enabled = False
            Me.txtprecio.Enabled = False
            Me.txtmargen_ganancia.Enabled = False
            Me.txtcantidad_compra.Enabled = False
        End If

        'Nazareno
        If vgNombrePermiso = "grisoni" Then
            Me.etiquetaabreviatura.Visible = False
            Me.txtabreviatura.Visible = False
            Me.etiquetaubicacion.Visible = False
            Me.txtubicacion.Visible = False
            Me.etiquetaid_subtipo_producto.Visible = False
            Me.cmbsubtipo_producto.Visible = False
            Me.btnBuscasubtipo_producto.Visible = False
            Me.cmbalmacen.Visible = True
            Me.txtabreviatura.Text = "-"
            Me.txtubicacion.Text = "-"
            Me.lblid_subtipo_producto.Text = "1"

        End If

        'Colinas del valle
        If vgNombrePermiso = "colina" Then
            Me.etiquetaiva.Visible = False
            Me.txtiva.Visible = False
            Me.etiquetaalicuota.Visible = False
            Me.txtalicuota.Visible = False
            Me.Label6.Visible = False
            Me.txtPrecio_con_iva.Visible = False

        End If


    End Sub

    Private Sub ObtenerDatos()
        Me.txtnombre_producto.Text = oProducto.nombre_producto.Trim
        Me.txtdescripcion.Text = oProducto.descripcion.Trim
        Me.txtabreviatura.Text = oProducto.abreviatura.Trim
        Me.txtubicacion.Text = oProducto.ubicacion.Trim
        Me.txtPack.Text = oProducto.pack.ToString.Trim
        Me.txtstock_ideal.Text = oProducto.stock_ideal.ToString.Trim
        Me.txtstock_minimo.Text = oProducto.stock_minimo.ToString.Trim
        Me.txtcantidad_compra.Text = oProducto.cantidad_compra.ToString.Trim
        Me.txtcantidad_ingreso.Text = oProducto.cantidad_ingreso.ToString.Trim
        Me.lblid_subtipo_producto.Text = oProducto.id_subtipo_producto.ToString
        Me.lblid_marca.Text = oProducto.id_marca.ToString
        Me.lblid_unidad.Text = oProducto.id_unidad.ToString
        Me.chktilde.Checked = oProducto.tilde
        Me.txtTipo_venta.Text = oProducto.tipo_venta

    End Sub

    Private Sub AsignarDatos()
        oProducto.nombre_producto = Me.txtnombre_producto.Text
        oProducto.descripcion = Me.txtdescripcion.Text
        oProducto.abreviatura = Me.txtabreviatura.Text
        oProducto.ubicacion = Me.txtubicacion.Text
        oProducto.pack = CDec(Me.txtPack.Text)
        oProducto.stock_ideal = CDec(Me.txtstock_ideal.Text)
        oProducto.stock_minimo = CDec(Me.txtstock_minimo.Text)
        oProducto.cantidad_compra = CDec(Me.txtcantidad_compra.Text)
        oProducto.cantidad_ingreso = CDec(Me.txtcantidad_ingreso.Text)
        oProducto.id_subtipo_producto = CInt(Me.lblid_subtipo_producto.Text)
        oProducto.id_marca = CInt(Me.lblid_marca.Text)
        oProducto.id_unidad = CInt(Me.lblid_unidad.Text)
        oProducto.tilde = Me.chktilde.Checked
        oProducto.tipo_venta = Me.txtTipo_venta.Text
    End Sub

    Public Sub SoloLectura()
        Me.txtnombre_producto.Enabled = False
        Me.txtdescripcion.Enabled = False
        Me.txtabreviatura.Enabled = False
        Me.txtubicacion.Enabled = False
        Me.txtPack.Enabled = False
        Me.txtstock_ideal.Enabled = False
        Me.txtstock_minimo.Enabled = False
        Me.txtcantidad_compra.Enabled = False
        Me.txtcantidad_ingreso.Enabled = False
        Me.cmbsubtipo_producto.Enabled = False
        Me.btnBuscasubtipo_producto.Enabled = False
        Me.cmbmarca.Enabled = False
        Me.btnBuscamarca.Enabled = False
        Me.cmbunidad.Enabled = False
        Me.btnBuscaunidad.Enabled = False
        Me.chktilde.Enabled = False
        Me.btnGuardar.Visible = False
        Me.txtTipo_venta.Enabled = False
    End Sub



    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            If oProducto.Exist_2() Then
                If BanderaProducto = 1 Then
                    MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
                    Exit Sub
                ElseIf BanderaProducto = 2 Then
                    If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                        = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            Select Case BanderaProducto
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    Dim idProducto As Integer = 0

                    oProducto.Guardar()
                    idProducto = oProducto.id_producto



                    'ingreso un precio cero
                    With oPrecio
                        .Cargar()
                        .Insertar()
                        .id_producto = idProducto
                        .id_proveedor = CInt(Me.lblid_proveedor.Text)
                        .precio = CDec(Me.txtprecio.Text)
                        .alicuota = CDec(Me.txtalicuota.Text)
                        .iva = CDec(Me.txtiva.Text)
                        .impuesto_interno = 0
                        .margen_ganancia = CDec(Me.txtmargen_ganancia.Text)
                        .cod_producto_proveedor = Me.txtcod_producto_proveedor.Text
                        .pack = CDec(Me.txtPack.Text)
                        .precio_venta_unitario = CDec(Me.txtPrecio_venta_unitario.Text)
                        .bonificacion1 = CDec(Me.txtBonificacion1.Text)
                        .bonificacion2 = CDec(Me.txtBonificacion2.Text)

                        .Guardar()
                    End With

                    'ingreso un stock cero
                    Me.InsertarStockCero(idProducto)

                    CType(Me.Owner, frmAbmProducto).RefrescarGrilla()
                    Me.CargarCombos()
                    oProducto.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.txtnombre_producto.Focus()

                Case 2 'GUARDA Y SALE (MODIFICAR)

                    oProducto.Guardar()

                    'ingreso un precio cero
                    With oPrecio
                        .Cargar()
                        If idprecio = 0 Then
                            .Insertar()
                            .id_producto = oProducto.id_producto
                        Else
                            .Modificar(idprecio)
                        End If

                        '.id_producto = idProducto
                        .id_proveedor = CInt(Me.lblid_proveedor.Text)
                        .precio = CDec(Me.txtprecio.Text)
                        .alicuota = CDec(Me.txtalicuota.Text)

                        .iva = CDec(Me.txtiva.Text)
                        .impuesto_interno = 0
                        .margen_ganancia = CDec(Me.txtmargen_ganancia.Text)
                        .cod_producto_proveedor = Me.txtcod_producto_proveedor.Text
                        .pack = CDec(Me.txtPack.Text)
                        .precio_venta_unitario = CDec(Me.txtPrecio_venta_unitario.Text)
                        .bonificacion1 = CDec(Me.txtBonificacion1.Text)
                        .bonificacion2 = CDec(Me.txtBonificacion2.Text)
                        .Guardar()
                    End With

                    With oStock
                        .Cargar()
                        If idstock = 0 Then
                            .Insertar()
                            .id_producto = oProducto.id_producto
                            .id_almacen = CInt(Me.lblid_almacen.Text)
                        Else
                            .Modificar(idstock)
                        End If

                        .stock = CDec(Me.txtstock.Text)
                        .Guardar()

                    End With

                    Me.Close()
            End Select
        Catch ex As Exception
            Errores(ex)
        End Try
    End Sub

    'Private Function controlarIdPrecioyIdStock() As Integer
    '    If idprecio = 0 And idstock = 0 Then
    '        BanderaProducto = 1
    '    Else
    '        BanderaProducto = 2
    '    End If
    '    Return BanderaProducto
    'End Function

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        ' Me.txtabreviatura.Text = "" Or Me.txtcantidad_compra.Text = "" Or _ Or Me.txtubicacion.Text = ""
        If Me.txtnombre_producto.Text = "" Or _
        Me.txtcantidad_ingreso.Text = "" Or Me.txtdescripcion.Text = "" Or Me.txtPack.Text = "" Or _
        Me.txtstock_ideal.Text = "" Or Me.txtstock_minimo.Text = "" Or _
        Me.txtPack.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Function ChequearVacios_2() As Boolean 'Me.txtstock.Text = "" Or Me.txtmargen_ganancia.Text = "" Or Me.txtcod_producto_proveedor.Text = "" Or Me.txtprecio.Text = ""  Or Me.txtPrecio_venta_unitario.Text = "" '
        Dim bandera As Boolean
        'Me.txtabreviatura.Text = "" Or Me.txtcantidad_compra.Text = "" Or _ Or Me.txtmargen_ganancia.Text = "" Or Me.txtPrecio_venta_unitario.Text = ""
        If Me.txtnombre_producto.Text = "" Or _
        Me.txtcantidad_ingreso.Text = "" Or Me.txtdescripcion.Text = "" Or Me.txtPack.Text = "" Or _
        Me.txtstock_ideal.Text = "" Or Me.txtstock_minimo.Text = "" Or Me.txtubicacion.Text = "" Or _
        Me.txtPack.Text = "" Or Me.txtstock.Text = "" Or Me.txtcod_producto_proveedor.Text = "" Or Me.txtprecio.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean

        If CDbl(Me.lblid_subtipo_producto.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de subtipo_producto")
            Exit Sub
        End If
        If CDbl(Me.lblid_marca.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de marca")
            Exit Sub
        End If
        If CDbl(Me.lblid_unidad.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de unidad")
            Exit Sub
        End If

        If BanderaProducto = 1 Then
            blnVacios = Me.ChequearVacios_2()
        Else
            blnVacios = Me.ChequearVacios()
        End If

        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaProducto = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cmbSubtipo_producto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsubtipo_producto.SelectedIndexChanged
        If Me.cmbsubtipo_producto.SelectedIndex >= 0 Then
            Me.lblid_subtipo_producto.Text = cmbsubtipo_producto.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaSubtipo_producto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscasubtipo_producto.Click
        Dim frmTemporal As New frmAbmSubtipo_producto
        frmTemporal.ShowDialog()
        Me.CargarSubtipo_producto()
        Me.cmbsubtipo_producto.Focus()
        Me.cmbsubtipo_producto.Text = ""
        Me.lblid_subtipo_producto.Text = "0"
    End Sub

    Private Sub cmbMarca_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbmarca.SelectedIndexChanged
        If Me.cmbmarca.SelectedIndex >= 0 Then
            Me.lblid_marca.Text = cmbmarca.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaMarca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscamarca.Click
        Dim frmTemporal As New frmAbmMarca
        frmTemporal.ShowDialog()
        Me.CargarMarca()
        Me.cmbmarca.Focus()
        Me.cmbmarca.Text = ""
        Me.lblid_marca.Text = "0"
    End Sub

    Private Sub cmbUnidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbunidad.SelectedIndexChanged
        If Me.cmbunidad.SelectedIndex >= 0 Then
            Me.lblid_unidad.Text = cmbunidad.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaUnidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaunidad.Click
        Dim frmTemporal As New frmAbmUnidad
        frmTemporal.ShowDialog()
        Me.CargarUnidad()
        Me.cmbunidad.Focus()
        Me.cmbunidad.Text = ""
        Me.lblid_unidad.Text = "0"
    End Sub

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtnombre_producto.KeyPress, txtdescripcion.KeyPress, txtabreviatura.KeyPress, txtubicacion.KeyPress, _
    chktilde.KeyPress, txtcod_producto_proveedor.KeyPress, txtTipo_venta.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles cmbsubtipo_producto.KeyDown, cmbmarca.KeyDown, cmbunidad.KeyDown, cmbproveedor.KeyDown, cmbalmacen.KeyDown
        If CDbl(e.KeyValue.ToString) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtPack.KeyPress, txtstock_ideal.KeyPress, txtstock_minimo.KeyPress, txtcantidad_compra.KeyPress, _
    txtcantidad_ingreso.KeyPress, txtstock.KeyPress, txtprecio.KeyPress, txtmargen_ganancia.KeyPress, _
    txtPrecio_venta_unitario.KeyPress, txtBonificacion1.KeyPress, txtBonificacion2.KeyPress, txtalicuota.KeyPress, txtiva.KeyPress
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

    Private Sub btnGenerarCodigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarCodigo.Click
        Dim ean13 As New Ean13Barcode2005.Ean13
        Dim strNum As String = ""
        Dim strNumCompleto As String = ""

        With oCodigo
            .Cargar()
            .Insertar()
            .nombre_codigo = ""
            .Guardar()
            strNum = CStr(.id_codigo)
        End With

        strNumCompleto = CompletarCerosCodigo(strNum)

        With ean13
            .CountryCode = "779"
            .ManufacturerCode = "1111"
            .ProductCode = strNumCompleto
            .CalculateChecksumDigit()

            Me.txtnombre_producto.Text = .CountryCode & .ManufacturerCode & .ProductCode & .ChecksumDigit
        End With


    End Sub

    Sub InsertarStockCero(ByVal idProd As Integer)
        Dim odtAlmacen As New DataTable
        Dim odtStock As New DataTable

        Dim idAlm As Integer = 0

        odtAlmacen = oAlmacen.ConsultarTodo
        For Each rowAlm As DataRow In odtAlmacen.Rows
            idAlm = CInt(rowAlm("id almacen"))

            odtStock = oStock.GetProductoAlmacen(idProd, idAlm)
            If odtStock.Rows.Count > 0 Then
                'como existe no hago nada
            Else
                With oStock
                    .Cargar()
                    .Insertar()
                    .actualizado = False
                    .id_almacen = idAlm
                    .id_producto = idProd
                    If CInt(Me.lblid_almacen.Text) = idAlm Then
                        .stock = CDec(Me.txtstock.Text)
                    Else
                        .stock = 0
                    End If
                    .Guardar()
                End With
            End If
        Next
    End Sub


    ''''''''''''''''''
    ' precio y stock
    ''''''''''''''''''

    Sub CargarProveedor()
        Dim odt As New DataTable

        odt = oProveedor.GetCmb
        With Me.cmbproveedor
            .DataSource = odt
            .DisplayMember = "nombre_Proveedor"
            .ValueMember = "id_Proveedor"
        End With
        If Me.cmbproveedor.SelectedIndex >= 0 Then
            cmbproveedor.SelectedIndex = 0
            Me.lblid_proveedor.Text = cmbproveedor.SelectedValue.ToString
        End If
    End Sub

    Sub CargarAlmacen()
        Dim odt As New DataTable

        odt = oAlmacen.GetCmb
        With Me.cmbalmacen
            .DataSource = odt
            .DisplayMember = "nombre_almacen"
            .ValueMember = "id_almacen"
        End With
        If Me.cmbalmacen.SelectedIndex >= 0 Then
            cmbalmacen.SelectedIndex = 0
            Me.lblid_almacen.Text = cmbalmacen.SelectedValue.ToString
        End If
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

    Private Sub cmbAlmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbalmacen.SelectedIndexChanged
        If Me.cmbalmacen.SelectedIndex >= 0 Then
            Me.lblid_almacen.Text = cmbalmacen.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaAlmacen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaalmacen.Click
        Dim frmTemporal As New frmAbmAlmacen
        frmTemporal.ShowDialog()
        Me.CargarAlmacen()
        Me.cmbalmacen.Focus()
        Me.cmbalmacen.Text = ""
        Me.lblid_almacen.Text = "0"
    End Sub

    Private Sub txtprecio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles txtprecio.TextChanged, txtalicuota.TextChanged
        Try

            If Me.txtprecio.Text = "" Or Me.txtalicuota.Text = "" Or Me.txtBonificacion1.Text = "" Or Me.txtBonificacion2.Text = "" Then
                'MessageBox.Show(" Debe ingresar el Precio Costo ,Alicuota, Bonificacion1 y Bonificacion2 para calcular el Iva.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Me.txtprecio.Focus()
                Exit Sub
            End If

            Dim decBon1 As Decimal = 0
            Dim decBon2 As Decimal = 0
            Dim a1, a2, a3 As Decimal
            Dim c As Decimal = CDec(txtprecio.Text)
            decBon1 = CDec(Me.txtBonificacion1.Text) / 100
            decBon2 = CDec(Me.txtBonificacion2.Text) / 100
            a1 = c - (c * decBon1)
            a2 = a1 - (a1 * decBon2)
            Me.txtiva.Text = CStr(a2 * CDec(Me.txtalicuota.Text) / 100) 'Me.txtiva.Text = CStr((CDec(Me.txtprecio.Text) - decBon1 - decBon2) * CDec(Me.txtalicuota.Text) / 100)
            Me.txtPrecio_con_iva.Text = CStr(a2 + CDec(Me.txtiva.Text)) 'CStr(CDec(Me.txtprecio.Text) - decBon1 - decBon2 + CDec(Me.txtiva.Text))

            Dim total As Decimal = 0
            If txtPack.Text = "" Or Me.txtPack.Text = "0" Then
                ' MsgBox("No hay Pack Divisorio")
                Exit Sub
            End If
            total = (CDec(Me.txtPrecio_con_iva.Text) / CDec(txtPack.Text) * (1 + CDec(Me.txtmargen_ganancia.Text) / 100))

            Select Case vgNombrePermiso
                Case "esquiu_f", "esquiu_c", "virikyna_rio", "super_miguel"
                    'sin redondeo
                    Me.txtPrecio_venta_unitario.Text = FormatNumber(total)
                Case Else
                    'con redondeo
                    Me.txtPrecio_venta_unitario.Text = FormatNumber(Math.Round(total, 0))

            End Select


        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtmargen_ganancia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmargen_ganancia.TextChanged
        If Me.txtmargen_ganancia.Text = "" Or Me.txtprecio.Text = "" Or Me.txtPack.Text = "" Then
            Exit Sub
        End If
        If txtPack.Text = "" Or Me.txtPack.Text = "0" Then
            ' MsgBox("No hay Pack Divisorio")
            Exit Sub
        End If
        Dim total As Decimal = 0
        total = (CDec(Me.txtPrecio_con_iva.Text) / CDec(txtPack.Text) * (1 + CDec(Me.txtmargen_ganancia.Text) / 100))

        Select Case vgNombrePermiso
            Case "esquiu_f", "esquiu_c", "virikyna_rio", "super_miguel"
                'sin redondeo
                Me.txtPrecio_venta_unitario.Text = FormatNumber(total)
            Case Else
                'con redondeo
                Me.txtPrecio_venta_unitario.Text = FormatNumber(Math.Round(total, 0))

        End Select


    End Sub


    Private Sub btnControlar_duplicado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnControlar_duplicado.Click
        Dim odt As New DataTable
        Dim odt_2 As New DataTable
        odt = oProducto.GetOneCodigo(Me.txtCodigo_producto.Text)
        If odt.Rows.Count = 0 Then
            Me.txtnombre_producto.Text = txtCodigo_producto.Text
            Exit Sub
        End If

        odt_2 = oProducto.GetOne(CInt(odt.Rows(0).Item("id_producto").ToString()))

        If odt_2.Rows(0).Item("nombre_producto").ToString() = Me.txtCodigo_producto.Text Then
            MessageBox.Show("El Producto ya existe.", "Informcacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Me.txtCodigo_producto.Focus()

        End If
    End Sub

    Private Sub txtnombre_producto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre_producto.TextChanged
        Me.txtcod_producto_proveedor.Text = Me.txtnombre_producto.Text
    End Sub

End Class
