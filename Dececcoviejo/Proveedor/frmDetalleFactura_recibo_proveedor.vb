Public Class frmDetalleFactura_recibo_proveedor

   Private Sub frmDetalleFactura_recibo_proveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnBuscaFactura_proveedor, "Buscar Nuevo Factura_proveedor")
        'Me.ttGeneral.SetToolTip(Me.btnBuscaRecibo_proveedor, "Buscar Nuevo Recibo_proveedor")
       Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Factura_recibo_proveedor")
       Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
       Try
           ObtenerDatos()

            Me.cmbfactura_proveedor.Text = oFactura_proveedor.GetOne(CInt(Me.lblid_factura_proveedor.Text)).Rows(0).Item("nombre Factura proveedor").ToString.Trim

            'Me.cmbRecibo_proveedor.Text = oRecibo_proveedor.GetOne(CInt(Me.lblid_Recibo_proveedor.Text)).Rows(0).Item("nombre_Recibo_proveedor").ToString.Trim
       Catch ex As Exception
           '    MessageBox.Show(ex.Message)
        End Try

       
        If BanderaFactura_recibo_proveedor = 1 Then
            Me.LimpiarControles()
        End If
        Me.Text = "Factura_recibo_proveedor" & vgNombreFormulario
       Me.CancelButton = Me.btnSalir
       Me.BackColor = Color.Gainsboro
       Me.StartPosition = FormStartPosition.CenterScreen
       Me.MinimizeBox = False
        Me.MaximizeBox = False

        Me.lblid_recibo_proveedor.Text = CType(Me.Owner, frmDetalleRecibo_proveedor).lblid_recibo_proveedor.Text
        Me.lblid_proveedor.Text = CType(Me.Owner, frmDetalleRecibo_proveedor).lblid_proveedor.Text
   End Sub

   Sub CargarCombos()
       Me.CargarFactura_proveedor
        'Me.CargarRecibo_proveedor
   End Sub

   Sub CargarFactura_proveedor()
       Dim odt As New DataTable

        odt = oFactura_proveedor.GetCmbFacturaProveedor(CInt(Me.lblid_proveedor.Text))
       With Me.cmbFactura_proveedor
           .DataSource = odt
           .DisplayMember = "nombre_factura_proveedor"
           .ValueMember = "id_factura_proveedor"
       End With
       If Me.cmbFactura_proveedor.SelectedIndex >= 0 Then
           cmbFactura_proveedor.SelectedIndex = 0
           Me.lblid_Factura_proveedor.Text = cmbFactura_proveedor.SelectedValue.ToString
       End If
   End Sub

   Sub CargarRecibo_proveedor()
        'Dim odt As New DataTable

        'odt = oRecibo_proveedor.GetCmb
        'With Me.cmbRecibo_proveedor
        '    .DataSource = odt
        '    .DisplayMember = "nombre_recibo_proveedor"
        '    .ValueMember = "id_recibo_proveedor"
        'End With
        'If Me.cmbRecibo_proveedor.SelectedIndex >= 0 Then
        '    cmbRecibo_proveedor.SelectedIndex = 0
        '    Me.lblid_Recibo_proveedor.Text = cmbRecibo_proveedor.SelectedValue.ToString
        'End If
   End Sub

   Sub LimpiarControles()
       Me.lblid_factura_proveedor.Text = "0"
       Me.cmbFactura_proveedor.Text =  ""
       Me.lblid_recibo_proveedor.Text = "0"
        ' Me.cmbRecibo_proveedor.Text =  ""
       Me.txtimporte_pagado.Text = ""
        Me.chkefectivo.Checked = False
        Me.txtGastado.Text = "0"
        Me.txtSaldo.Text = "0"
   End Sub

   Private Sub ObtenerDatos()
       Me.lblid_factura_proveedor.Text = oFactura_recibo_proveedor.id_factura_proveedor.ToString
        Me.lblid_recibo_proveedor.Text = oFactura_recibo_proveedor.id_recibo_proveedor.ToString
        Me.txtimporte_pagado.Text = oFactura_recibo_proveedor.importe_pagado.ToString.Trim
        Me.chkefectivo.Checked = oFactura_recibo_proveedor.efectivo
   End Sub

   Private Sub AsignarDatos()
       oFactura_recibo_proveedor.id_factura_proveedor = CInt(Me.lblid_factura_proveedor.Text)
       oFactura_recibo_proveedor.id_recibo_proveedor = CInt(Me.lblid_recibo_proveedor.Text)
       oFactura_recibo_proveedor.importe_pagado = CDec(Me.txtimporte_pagado.Text)
       oFactura_recibo_proveedor.efectivo = Me.chkefectivo.Checked
   End Sub

   Public Sub SoloLectura()
       Me.cmbFactura_proveedor.Enabled = False
       Me.btnBuscaFactura_proveedor.Enabled = False
        'Me.cmbRecibo_proveedor.Enabled = False
        'Me.btnBuscaRecibo_proveedor.Enabled = False
       Me.txtimporte_pagado.Enabled = False
       Me.chkefectivo.Enabled = False
        Me.btnGuardar.Visible = False
        Me.txtGastado.Enabled = False
        Me.txtSaldo.Enabled = False
   End Sub

   Private Sub Guardar()
        Try
            Me.AsignarDatos()
            If oFactura_recibo_proveedor.Exist() Then
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
                    CType(Me.Owner, frmDetalleRecibo_proveedor).RefrescarGrilla()
                    Me.CargarCombos()
                    oFactura_recibo_proveedor.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.cmbfactura_proveedor.Focus()
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oFactura_recibo_proveedor.Guardar()
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

   Private Function ChequearVacios() As Boolean
       Dim bandera As Boolean
       If Me.txtimporte_pagado.Text = "" Then
           bandera = False
       Else
           bandera = True
       End If
       Return bandera
   End Function

   Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
       Dim blnVacios As Boolean

       If CDbl(Me.lblid_factura_proveedor.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de factura_proveedor")
           Exit Sub
        End If

        If Me.txtimporte_pagado.Text = "" Then
            MessageBox.Show("debe ingresar el importe_pagado")
            Me.txtimporte_pagado.Focus()
            Exit Sub
        End If
        If Not Me.txtSaldo.Text = "" Then
            If CDec(Me.txtimporte_pagado.Text) > CDec(Me.txtSaldo.Text) Then
                MessageBox.Show("El importe pagado supera el Total de la Factura")
                Me.txtimporte_pagado.Focus()
                Exit Sub
            End If
        End If

        'If CDbl(Me.lblid_recibo_proveedor.Text) = 0 Then
        '    MessageBox.Show("Debe Seleccionar un Dato del Combo de recibo_proveedor")
        '    Exit Sub
        'End If

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

   Private Sub cmbFactura_proveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFactura_proveedor.SelectedIndexChanged
       If Me.cmbFactura_proveedor.SelectedIndex >= 0 Then
            Me.lblid_factura_proveedor.Text = cmbfactura_proveedor.SelectedValue.ToString

        End If
        If Not IsNumeric(Me.lblid_factura_proveedor.Text) Then
            Exit Sub
        End If
        Me.calcularGastado()

   End Sub

   Private Sub btnBuscaFactura_proveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaFactura_proveedor.Click
        Dim frmTemporal As New frmAbmFactura_proveedor
        Me.AddOwnedForm(frmTemporal)
        vgFormularioPadre = Me.Name
       frmTemporal.ShowDialog()
       Me.CargarFactura_proveedor()
       Me.cmbFactura_proveedor.Focus()
       Me.cmbFactura_proveedor.Text = ""
       Me.lblid_Factura_proveedor.Text = "0"
   End Sub

    'Private Sub cmbRecibo_proveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRecibo_proveedor.SelectedIndexChanged
    '    If Me.cmbRecibo_proveedor.SelectedIndex >= 0 Then
    '        Me.lblid_recibo_proveedor.Text = cmbRecibo_proveedor.SelectedValue.ToString
    '    End If
    'End Sub

    'Private Sub btnBuscaRecibo_proveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaRecibo_proveedor.Click
    '    Dim frmTemporal As New FrmAbmRecibo_proveedor
    '    frmTemporal.ShowDialog()
    '    Me.CargarRecibo_proveedor()
    '     'Me.cmbRecibo_proveedor.Focus()
    '     'Me.cmbRecibo_proveedor.Text = ""
    '    Me.lblid_Recibo_proveedor.Text = "0"
    'End Sub

   Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles chkefectivo.KeyPress
       If e.KeyChar.ToString = vbCr Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles cmbfactura_proveedor.KeyDown
        If CDbl(e.KeyValue.ToString) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtimporte_pagado.KeyPress
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

        odtTotal = oFactura_proveedor.GetOne(CInt(Me.lblid_factura_proveedor.Text))
        For Each row As DataRow In odtTotal.Rows
            totalFactura += CDec(row("total factura").ToString())
        Next

        odt = oFactura_recibo_proveedor.GetAllFactura_proveedor(CInt(Me.lblid_factura_proveedor.Text))
        If odt.Rows.Count > 0 Then
            For Each r As DataRow In odt.Rows()
                gastado += CDec(r("importe_pagado").ToString())
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
