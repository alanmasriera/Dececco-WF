Public Class frmDetalleCuerpo_facturaexporta
    Private Sub frmDetalleCuerpo_facturaexporta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttItem.SetToolTip(Me.btnBuscaItem, "Buscar Nuevo Item")
        Me.ttGuardar.SetToolTip(Me.btnGuardar, "Guardar Datos del Cuerpo_factura")
        Me.ttSalir.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()

            Me.cmbItem.Text = oItem.GetOne(CInt(Me.lblid_item.Text)).Rows(0).Item("nombre_Item").ToString.Trim
        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try
        If BanderaCuerpo_factura = 1 Then
            Me.LimpiarControles()
        End If


        'oCuerpo_factura_exporta.Cargar()
        'oFactura_exporta.Cargar()

        Me.Text = "Cuerpo_factura_exporta" & vgNombreFormulario
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.lblid_factura.Text = CType(Me.Owner, frmDetalleFacturaExporta).lblid_factura.Text
    End Sub

    Sub CargarCombos()
        Me.CargarItem()
    End Sub

    Sub CargarItem()
        Dim odt As New DataTable

        odt = oItem.GetCmb
        With Me.cmbItem
            .DataSource = odt
            .DisplayMember = "nombre_Item"
            .ValueMember = "id_Item"
        End With
        If Me.cmbItem.SelectedIndex >= 0 Then
            cmbItem.SelectedIndex = 0
            Me.lblid_item.Text = cmbItem.SelectedValue.ToString
        End If
    End Sub

    Sub LimpiarControles()
        Me.lblid_item.Text = "0"
        Me.txtNro_Item.Text = ""
        Me.cmbItem.Text = ""
        Me.txtcantidad_item.Text = ""
        Me.txtprecio_item.Text = ""
        ' Me.txtdescripcion_item.Text = ""
    End Sub

    Private Sub ObtenerDatos()
        '  Me.lblid_factura.Text = oCuerpo_factura.id_factura
        Me.lblid_item.Text = CStr(oCuerpo_factura_exporta.id_item)
        Me.txtNro_Item.Text = CStr(oCuerpo_factura_exporta.nro_item)
        Me.txtCantidad_item.Text = oCuerpo_factura_exporta.cantidad_item.ToString.Trim
        Me.txtPrecio_item.Text = oCuerpo_factura_exporta.precio_item.ToString.Trim
        '  Me.txtdescripcion_item.Text = oCuerpo_factura.descripcion_item.Trim
        'Me.txtiva.Text = oCuerpo_factura.iva.ToString.Trim
    End Sub

    Private Sub AsignarDatos()
        oCuerpo_factura_exporta.id_factura = CInt(Me.lblid_factura.Text)
        oCuerpo_factura_exporta.id_item = CInt(Me.lblid_item.Text)
        oCuerpo_factura_exporta.nro_item = CInt(Me.txtNro_Item.Text)
        oCuerpo_factura_exporta.cantidad_item = CDec(Me.txtCantidad_item.Text)
        oCuerpo_factura_exporta.descripcion_item = Me.cmbItem.Text.Trim

        If Me.rbnIva21.Checked Then
            oCuerpo_factura_exporta.precio_item = CDec(CDec(Me.txtPrecio_item.Text) / 1.21)
        End If
        If Me.rbnIvaNo21.Checked Then
            oCuerpo_factura_exporta.precio_item = CDec(Me.txtPrecio_item.Text)
        End If
        If Me.rbnIva10.Checked Then
            oCuerpo_factura_exporta.precio_item = CDec(CDec(Me.txtPrecio_item.Text) / 1.105)
        End If
        If Me.rbnIvaNo10.Checked Then
            oCuerpo_factura_exporta.precio_item = CDec(Me.txtPrecio_item.Text)
        End If

        'oCuerpo_factura.iva = Me.txtiva.Text
    End Sub

    Public Sub SoloLectura()
        Me.cmbItem.Enabled = False
        Me.btnBuscaItem.Enabled = False
        Me.txtcantidad_item.Enabled = False
        Me.txtprecio_item.Enabled = False
        ' Me.txtdescripcion_item.Enabled = False
        Me.btnGuardar.Visible = False
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            Select Case BanderaCuerpo_factura
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)

                    'oFactura_exporta.Guardar()

                    'Me.lblid_factura.Text = CStr(oFactura_exporta.id_factura)

                    'oCuerpo_factura.id_factura = CInt(Me.lblid_factura.Text)


                    oCuerpo_factura_exporta.Guardar()
                    CType(Me.Owner, frmDetalleFacturaExporta).RefrescarGrilla()
                    Me.CargarCombos()
                    oCuerpo_factura_exporta.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.cmbItem.Focus()
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oCuerpo_factura_exporta.Guardar()
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If Me.txtCantidad_item.Text = "" Or Me.txtPrecio_item.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean

        If CDbl(Me.lblid_item.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de item")
            Exit Sub
        End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar Todos los Campos")
            Exit Sub
        Else
            If BanderaCuerpo_factura = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cmbItem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbItem.SelectedIndexChanged
        If Me.cmbItem.SelectedIndex >= 0 Then
            Me.lblid_item.Text = cmbItem.SelectedValue.ToString
            '  Me.txtDescripcion_item.Text = Me.cmbItem.Text.Trim
        End If
    End Sub

    Private Sub btnBuscaItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaItem.Click
        Dim frmTemporal As New FrmAbmItem
        frmTemporal.ShowDialog()
        Me.CargarItem()
        Me.cmbItem.Focus()
        Me.cmbItem.Text = ""
        Me.lblid_Item.Text = "0"
    End Sub

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbItem.KeyDown
        If e.KeyValue = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtCantidad_item.KeyPress, txtPrecio_item.KeyPress
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