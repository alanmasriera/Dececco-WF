Public Class frmDetalleRemito_factura


    Private Sub frmDetalleRemito_factura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttGeneral.SetToolTip(Me.btnBuscaCliente, "Buscar Nuevo Cliente")
        'Me.ttGeneral.SetToolTip(Me.btnBuscaRemito, "Buscar Nuevo Remito")
        'Me.ttGeneral.SetToolTip(Me.btnBuscaFactura, "Buscar Nuevo Factura")
        Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Remito_factura")
        Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()

            Me.cmbCliente.Text = oCliente.GetOne(Me.lblid_Cliente.Text).Rows(0).Item("nombre_Cliente").ToString.Trim
            Me.txtRemito_aux.Text = oRemito.GetOne(Me.lblid_remito.Text).Rows(0).Item("numero_remito").ToString.Trim
            Me.txtFactura_aux.Text = oFactura.GetOne(Me.lblid_factura.Text).Rows(0).Item("numero_factura").ToString.Trim
            Me.txtNumero_4.Text = Me.txtRemito_aux.Text.Substring(0, 4)
            Me.txtNumero_8.Text = Me.txtRemito_aux.Text.Substring(4, 8)
            Me.txtNumero_42.Text = Me.txtFactura_aux.Text.Substring(0, 4)
            Me.txtNumero_82.Text = Me.txtFactura_aux.Text.Substring(4, 8)

            Me.LlenarLista()

        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try

        oCuerpo_remito.Cargar()

        If BanderaRemito_factura = 1 Then
            Me.LimpiarControles()
        End If
        Me.Text = "Remito_factura"
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Teal
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False
    End Sub

    Sub CargarCombos()
        Me.CargarCliente()
        'Me.CargarRemito()
        'Me.CargarFactura()
    End Sub

    Sub CargarCliente()
        Dim odt As New DataTable

        odt = oCliente.GetCmb
        With Me.cmbCliente
            .DataSource = odt
            .DisplayMember = "nombre_Cliente"
            .ValueMember = "id_Cliente"
        End With
        If Me.cmbCliente.SelectedIndex.ToString >= 0 Then
            cmbCliente.SelectedIndex = 0
            Me.lblid_Cliente.Text = cmbCliente.SelectedValue.ToString
        End If
    End Sub



    Sub LimpiarControles()
        Me.lblid_cliente.Text = "0"
        Me.cmbCliente.Text = ""
        Me.lblid_remito.Text = "0"
        'Me.cmbRemito.Text = ""
        Me.lblid_factura.Text = "0"
        'Me.cmbFactura.Text = ""
        Me.chkControl.Checked = False
        Me.txtNumero_4.Text = ""
        Me.txtNumero_42.Text = ""
        Me.txtNumero_8.Text = ""
        Me.txtNumero_82.Text = ""
    End Sub

    Private Sub ObtenerDatos()
        Me.lblid_cliente.Text = oRemito_factura.id_cliente
        Me.lblid_remito.Text = oRemito_factura.id_remito
        Me.lblid_factura.Text = oRemito_factura.id_factura
        Me.chkcontrol.Checked = oRemito_factura.control
    End Sub

    Private Sub AsignarDatos()
        oRemito_factura.id_cliente = Me.lblid_cliente.Text
        oRemito_factura.id_remito = Me.lblid_remito.Text
        oRemito_factura.id_factura = Me.lblid_factura.Text
        oRemito_factura.control = Me.chkcontrol.Checked
    End Sub


    Public Sub SoloLectura()
        Me.cmbCliente.Enabled = False
        Me.btnBuscaCliente.Enabled = False
        'Me.cmbRemito.Enabled = False
        'Me.btnBuscaRemito.Enabled = False
        'Me.cmbFactura.Enabled = False
        ' Me.btnBuscaFactura.Enabled = False
        Me.chkcontrol.Enabled = False
        Me.btnGuardar.Visible = False
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            If oRemito_factura.Exist() Then
                If BanderaRemito_factura = 1 Then
                    MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
                    Exit Sub
                ElseIf BanderaRemito_factura = 2 Then
                    If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                        = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            Select Case BanderaRemito_factura
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oRemito_factura.Guardar()

                    Me.AsignarDatosCuerpo()

                    CType(Me.Owner, frmAbmRecibo_factura).RefrescarGrilla()
                    Me.CargarCombos()
                    oRemito_factura.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.cmbCliente.Focus()
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oRemito_factura.Guardar()

                    Me.ModificarDatosCuerpo()

                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If Me.txtNumero_4.Text = "" Or Me.txtNumero_8.Text = "" Or Me.txtNumero_42.Text = "" Or Me.txtNumero_82.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean

        If Me.lblid_cliente.Text = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de cliente")
            Exit Sub
        End If
        If Me.lblid_remito.Text = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de remito")
            Exit Sub
        End If
        If Me.lblid_factura.Text = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de factura")
            Exit Sub
        End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaRemito_factura = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cmbCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCliente.SelectedIndexChanged
        If Me.cmbCliente.SelectedIndex >= 0 Then
            Me.lblid_cliente.Text = cmbCliente.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaCliente.Click
        Dim frmTemporal As New frmAbmClientes
        frmTemporal.ShowDialog()
        Me.CargarCliente()
        Me.cmbCliente.Focus()
        Me.cmbCliente.Text = ""
        Me.lblid_Cliente.Text = "0"
    End Sub


    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles chkcontrol.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles cmbCliente.KeyDown
        If e.KeyValue.ToString = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    'Handles 
        Dim txtTemp As TextBox
        txtTemp = sender

        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Then
            If InStr(txtTemp.Text, ",") <> 0 Then
                e.Handled = True
            Else
                e.KeyChar = ","
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


    Private Sub Numeros(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtNumero_4.KeyPress, txtNumero_8.KeyPress, txtNumero_42.KeyPress, txtNumero_82.KeyPress
        Dim txtTemp As TextBox
        txtTemp = sender

        If e.KeyChar.ToString = vbCr Then
            If txtTemp.Name = "txtNumero_4" Then
                Me.txtNumero_4.Text = CompletarCeros(Me.txtNumero_4.Text, 4)
            End If
            If txtTemp.Name = "txtNumero_8" Then
                Me.txtNumero_8.Text = CompletarCeros(Me.txtNumero_8.Text, 8)
            End If
            If txtTemp.Name = "txtNumero_42" Then
                Me.txtNumero_42.Text = CompletarCeros(Me.txtNumero_42.Text, 4)
            End If
            If txtTemp.Name = "txtNumero_82" Then
                Me.txtNumero_82.Text = CompletarCeros(Me.txtNumero_82.Text, 8)
            End If
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If

        If (e.KeyChar.ToString >= "0" And e.KeyChar.ToString <= "9") Or e.KeyChar = vbBack Then
            '  e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub






    Structure regCuerpo
        Dim indice As Integer
        Dim id_item As Integer
        Dim cantidad_item As Decimal
        Dim precio_item As Decimal
        Dim descripcion_item As String
    End Structure

    Dim reg() As regCuerpo

    Sub LlenarLista()

        Dim odtTemp As New DataTable
        oCuerpo_factura.Cargar()

        odtTemp = oCuerpo_factura.GetAll_2(Me.lblid_factura.Text)

        ReDim reg(odtTemp.Rows.Count() - 1)

        Dim indice As Integer = 0
        'Me.CheckedListBox1.DataSource = odtTemp
        ' Me.CheckedListBox1.ValueMember = "id_cuerpo_factura"
        ' Me.CheckedListBox1.DisplayMember = "nombre_item"

        Me.CheckedListBox1.Items.Clear()
        For Each row As DataRow In odtTemp.Rows
            Me.CheckedListBox1.Items.Add(row("nombre_item").ToString.Trim & " - " & row("cantidad_item").ToString.Trim & " - $ " & row("precio_item").ToString.Trim)
            reg(indice).indice = indice
            reg(indice).id_item = row("id_item")
            reg(indice).precio_item = row("precio_item")
            reg(indice).cantidad_item = row("cantidad_item")
            reg(indice).descripcion_item = row("descripcion_item")

            Me.CheckedListBox1.SetItemChecked(indice, True)
            indice = indice + 1

        Next


    End Sub

    Private Sub AsignarDatosCuerpo()
        Dim i As Integer
        Dim registro As regCuerpo

        For i = 0 To Me.CheckedListBox1.CheckedItems.Count - 1
            Dim a As Integer = Me.CheckedListBox1.CheckedIndices(i)

            Dim j As Integer = 0
            For Each registro In reg
                If reg(j).indice = a Then
                    oCuerpo_remito.Insertar()
                    oCuerpo_remito.id_item = reg(j).id_item
                    oCuerpo_remito.id_remito = Me.lblid_remito.Text
                    oCuerpo_remito.cantidad_item = reg(j).cantidad_item
                    oCuerpo_remito.precio_item = reg(j).precio_item
                    oCuerpo_remito.descripcion_item = reg(j).descripcion_item
                    oCuerpo_remito.Guardar()
                End If
                j = j + 1
            Next
        Next
    End Sub

    Private Sub ModificarDatosCuerpo()
        Dim i As Integer
        Dim registro As regCuerpo

        oCuerpo_remito.Delete_remito(Me.lblid_remito.Text)

        For i = 0 To Me.CheckedListBox1.CheckedItems.Count - 1
            Dim a As Integer = Me.CheckedListBox1.CheckedIndices(i)

            Dim j As Integer = 0
            For Each registro In reg
                If reg(j).indice = a Then
                    oCuerpo_remito.Insertar()
                    oCuerpo_remito.id_item = reg(j).id_item
                    oCuerpo_remito.id_remito = Me.lblid_remito.Text
                    oCuerpo_remito.cantidad_item = reg(j).cantidad_item
                    oCuerpo_remito.precio_item = reg(j).precio_item
                    oCuerpo_remito.descripcion_item = reg(j).descripcion_item
                    oCuerpo_remito.Guardar()
                End If
                j = j + 1
            Next
        Next
    End Sub


    Private Sub txtNumero_82_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumero_82.LostFocus
        If Me.txtNumero_42.Text = "" Or Me.txtNumero_82.Text = "" Then
            Exit Sub
        End If
        oFactura.Cargar()
        Try
            Me.lblid_factura.Text = oFactura.GetOne_2(Me.lblid_cliente.Text, Me.txtNumero_42.Text & Me.txtNumero_82.Text).Rows(0).Item("id_factura")
            Me.LlenarLista()
        Catch ex As Exception
            MessageBox.Show("la factura no existe")
            Me.txtNumero_42.Focus()
        End Try
    End Sub

    Private Sub txtNumero_8_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumero_8.LostFocus
        If Me.txtNumero_4.Text = "" Or Me.txtNumero_8.Text = "" Then
            Exit Sub
        End If
        oRemito.Cargar()
        Try
            Me.lblid_remito.Text = oRemito.GetOne_2(Me.lblid_cliente.Text, Me.txtNumero_4.Text & Me.txtNumero_8.Text).Rows(0).Item("id_remito")
            'Me.LlenarLista()
        Catch ex As Exception
            MessageBox.Show("el remito no existe")
            Me.txtNumero_4.Focus()
        End Try
    End Sub

    Private Sub btnBuscaRemito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaRemito.Click
        Dim frmTemp As New frmAbmVenta
        frmTemp.ShowDialog()
    End Sub

    Private Sub btnBuscaFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaFactura.Click
        Dim frmTemp As New frmAbmFactura
        frmTemp.ShowDialog()
    End Sub


End Class