Public Class frmDetalleCuerpo_factura2

    Private Sub frmDetalleCuerpo_factura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ttGuardar.SetToolTip(Me.btnGuardar, "Guardar Datos del Cuerpo_factura")
        Me.ttSalir.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()


        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try

        If BanderaCuerpo_factura = 1 Then
            Me.LimpiarControles()
        End If
        Me.Text = "Cuerpo_factura" & vgNombreFormulario
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.lblid_factura.Text = CType(Me.Owner, frmDetalleFactura3).lblid_factura.Text
    End Sub

    Sub CargarCombos()

    End Sub

    

    Sub LimpiarControles()

        Me.txtNro_Item.Text = ""
        Me.txtcantidad_item.Text = ""
        Me.txtprecio_item.Text = ""
        Me.txtDescripcion_item.Text = ""
    End Sub

    Private Sub ObtenerDatos()
        'Me.lblid_factura.Text = CStr(oCuerpo_factura.id_factura)
        'Me.lblid_item.Text = CStr(oCuerpo_factura.id_item)
        Me.txtNro_Item.Text = CStr(oCuerpo_factura.nro_item)
        Me.txtcantidad_item.Text = oCuerpo_factura.cantidad_item.ToString.Trim
        Me.txtprecio_item.Text = oCuerpo_factura.precio_item.ToString.Trim
        Me.txtDescripcion_item.Text = oCuerpo_factura.descripcion_item.Trim
        'Me.txtiva.Text = oCuerpo_factura.iva.ToString.Trim
    End Sub

    Private Sub AsignarDatos()
        oCuerpo_factura.id_factura = CInt(Me.lblid_factura.Text)
        oCuerpo_factura.id_item = 1
        oCuerpo_factura.nro_item = CInt(Me.txtNro_Item.Text)
        oCuerpo_factura.cantidad_item = CDec(Me.txtCantidad_item.Text)
        oCuerpo_factura.descripcion_item = Me.txtDescripcion_item.Text.Trim

        If Me.rbnIva21.Checked Then
            oCuerpo_factura.precio_item = CDec(CDec(Me.txtPrecio_item.Text) / 1.21)
        End If
        If Me.rbnIvaNo21.Checked Then
            oCuerpo_factura.precio_item = CDec(Me.txtPrecio_item.Text)
        End If
        If Me.rbnIva10.Checked Then
            oCuerpo_factura.precio_item = CDec(CDec(Me.txtPrecio_item.Text) / 1.105)
        End If
        If Me.rbnIvaNo10.Checked Then
            oCuerpo_factura.precio_item = CDec(Me.txtPrecio_item.Text)
        End If

        'oCuerpo_factura.iva = Me.txtiva.Text
    End Sub

    Public Sub SoloLectura()
        
        Me.txtcantidad_item.Enabled = False
        Me.txtprecio_item.Enabled = False
        Me.txtDescripcion_item.Enabled = False
        Me.btnGuardar.Visible = False
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            Select Case BanderaCuerpo_factura
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oCuerpo_factura.Guardar()
                    CType(Me.Owner, frmDetalleFactura3).RefrescarGrilla()
                    Me.CargarCombos()
                    oCuerpo_factura.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()

                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oCuerpo_factura.Guardar()
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

        'If CDbl(Me.lblid_item.Text) = 0 Then
        '    MessageBox.Show("Debe Seleccionar un Dato del Combo de item")
        '    Exit Sub
        'End If

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


    Private Sub btnBuscaItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmTemporal As New frmAbmItem
        frmTemporal.ShowDialog()
       
    End Sub

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
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