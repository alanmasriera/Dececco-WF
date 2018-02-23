Public Class frmAbmFactura_recibo



    Private Sub frmAbmFactura_recibo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.dgv1.RowCount = 0 Then
            Try
                oRecibo_proveedor.Borrar_2(CInt(Me.lblid_recibo.Text))
            Catch ex As Exception
            End Try
        End If
        Try
            CType(Me.Owner, frmAbmRecibo_proveedor).RefrescarGrilla()
        Catch ex As Exception
        End Try
    End Sub








    Private Sub frmDetalleRecibo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttGeneral.SetToolTip(Me.btnAgregar, "Incorporar Nuevo Recibo")
        Me.ttGeneral.SetToolTip(Me.btnBorrar, "Borrar un  Recibo Existente")
        Me.ttGeneral.SetToolTip(Me.btnModificar, "Modificar  un Recibo Existente")
        Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Recibo")
        Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()

            Me.cmbProveedor.Text = oProveedor.GetOne(CInt(Me.lblid_proveedor.Text)).Rows(0).Item("nombre_Proveedor").ToString.Trim
        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try

        Me.lblid_recibo.Text = CType(Me.Owner, frmAbmRecibo_proveedor).lblid_pk.Text

        If BanderaRecibo_proveedor = 1 Then
            Me.LimpiarControles()
            Me.lblid_proveedor.Text = CType(Me.Owner, frmAbmRecibo_proveedor).lblid_proveedor.Text
            Me.cmbProveedor.Text = oProveedor.GetOne(CInt(Me.lblid_proveedor.Text)).Rows(0).Item("nombre_Proveedor").ToString.Trim
            Me.dtpFecha_recibo.Value = CType(Me.Owner, frmAbmRecibo_proveedor).dtpPeriodo.Value

            Me.btnAgregar.Enabled = False
            Me.btnBorrar.Enabled = False
            Me.btnModificar.Enabled = False
        End If

        Me.lblTitulo.Text = "Recibo"
        Me.Text = "Recibo" & NombreFormulario
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False

        Dim odt As DataTable
        odt = oFactura_recibo_proveedor.Cargar()

        RefrescarGrilla()

        'control de acceso y de permisos
        'Dim odtUser As New DataTable
        'odtUser = oUsuario.GetPermiso(NombreUsuario, Me.Name)
        'If odtUser.Rows.Count = 0 OrElse CDbl(odtUser.Rows(0).Item("habilitado")) = 0 Then
        '    Me.btnAgregar.Enabled = False
        '    Me.btnBorrar.Enabled = False
        '    Me.btnModificar.Enabled = False
        'End If

    End Sub

    Sub CargarCombos()
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

    Sub LimpiarControles()
        Me.lblid_recibo.Text = "0"

        Me.lblid_proveedor.Text = "0"
        Me.cmbProveedor.Text = ""
        Me.txtNumero_4.Text = ""
        Me.txtNumero_8.Text = ""
        Me.dtpFecha_recibo.Value = DateTime.Now
    End Sub

    Private Sub ObtenerDatos()
        If oRecibo_proveedor.numero_recibo.Length = 12 Then
            Me.txtNumero_4.Text = oRecibo_proveedor.numero_recibo.Substring(0, 4)
            Me.txtNumero_8.Text = oRecibo_proveedor.numero_recibo.Substring(4, 8)
        End If
        Me.lblid_proveedor.Text = CStr(oRecibo_proveedor.id_proveedor)
        Me.dtpFecha_recibo.Value = oRecibo_proveedor.fecha
    End Sub

    Private Sub AsignarDatos()
        oRecibo_proveedor.id_proveedor = CInt(Me.lblid_proveedor.Text)
        oRecibo_proveedor.numero_recibo = Me.txtNumero_4.Text & Me.txtNumero_8.Text
        oRecibo_proveedor.fecha = Me.dtpFecha_recibo.Value.Date
    End Sub

    Public Sub SoloLectura()
        Me.cmbProveedor.Enabled = False
        Me.txtNumero_4.Enabled = False
        Me.txtNumero_8.Enabled = False
        Me.dtpFecha_recibo.Enabled = False
        Me.btnGuardar.Visible = False
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            If oRecibo_proveedor.Exist_2() Then
                If BanderaRecibo_proveedor = 1 Then
                    MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
                    Exit Sub
                ElseIf BanderaRecibo_proveedor = 2 Then
                    If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                        = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            Me.txtNumero_4.ReadOnly = True
            Me.txtNumero_8.ReadOnly = True

            Select Case BanderaRecibo_proveedor
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oRecibo_proveedor.Guardar()

                    Me.lblid_recibo.Text = CStr(oRecibo_proveedor.id_recibo_proveedor)

                    CType(Me.Owner, frmAbmRecibo_proveedor).RefrescarGrilla()

                    Me.btnAgregar.Enabled = True
                    Me.btnBorrar.Enabled = True
                    Me.btnModificar.Enabled = True

                    MessageBox.Show("Se ha guardado el encabezado del recibo, puede ingresar el detalle")
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oRecibo_proveedor.Guardar()
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If Me.txtNumero_4.Text = "" Or Me.txtNumero_8.Text = "" Then
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
            If BanderaRecibo_proveedor = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cmbProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProveedor.SelectedIndexChanged
        If Me.cmbProveedor.SelectedIndex >= 0 Then
            Me.lblid_proveedor.Text = cmbProveedor.SelectedValue.ToString
        End If
    End Sub


    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    'Handles txtnumero_recibo.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
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

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles cmbProveedor.KeyDown, dtpFecha_recibo.KeyDown
        If e.KeyValue = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    'Handles 
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

    Private Sub txtNumero_4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumero_4.LostFocus
        Try
            Me.txtNumero_4.Text = CompletarCeros(Me.txtNumero_4.Text, 4)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtNumero_8_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumero_8.LostFocus
        Try
            Me.txtNumero_8.Text = CompletarCeros(Me.txtNumero_8.Text, 8)
        Catch ex As Exception
        End Try
    End Sub









    Dim odt As DataTable
    Dim BanderaConsultaFactura_recibo As Integer



    Public Sub RefrescarGrilla()
        Dim odt As DataTable

        odt = oFactura_recibo_proveedor.GetAll_2(CInt(Me.lblid_recibo.Text))
        Me.dgv1.DataSource = odt
        Me.dgv1.Columns(0).Visible = False

        Me.dgv1.Columns("IMPORTE_FACTURA").DefaultCellStyle.Format = "c"
        Me.dgv1.Columns("IMPORTE_FACTURA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgv1.Columns("IMPORTE_PAGADO").DefaultCellStyle.Format = "c"
        Me.dgv1.Columns("IMPORTE_PAGADO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Try
            Me.txtTotal.Text = FormatCurrency(oFactura_recibo_proveedor.GetAll_Sum(CInt(Me.lblid_recibo.Text)).Rows(0).Item("importe"))
        Catch ex As Exception
        End Try
    End Sub

    Public Sub RefrescarGrilla_2()
        Dim odt As DataTable

        odt = oFactura_recibo_proveedor.GetAll_2(0)
        Me.dgv1.DataSource = odt
        Me.dgv1.Columns(0).Visible = False

        Me.dgv1.Columns("IMPORTE_FACTURA").DefaultCellStyle.Format = "c"
        Me.dgv1.Columns("IMPORTE_FACTURA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgv1.Columns("IMPORTE_PAGADO").DefaultCellStyle.Format = "c"
        Me.dgv1.Columns("IMPORTE_PAGADO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Try
            Me.txtTotal.Text = "0"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar.ToString = vbCr Then
            Me.btnModificar.Focus()
        End If
    End Sub



    Private Sub dgv1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv1.CurrentCellChanged
        Try
            Me.lblid_pk.Text = CStr(Me.dgv1.Item(0, Me.dgv1.CurrentRow.Index).Value)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Botones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click, btnBorrar.Click, btnModificar.Click, btnSalir.Click
        Dim btnTemp As New Button
        Dim frmDetalle As New frmDetalleFactura_recibo
        btnTemp = CType(sender, Button)
        Try
            Select Case btnTemp.Name
                Case "btnAgregar"
                    BanderaFactura_recibo_proveedor = 1
                    Me.AddOwnedForm(frmDetalle)
                    oFactura_recibo_proveedor.Insertar()
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                Case "btnModificar"
                    If Not IsNumeric(Me.lblid_pk.Text) Then
                        Exit Sub
                    End If
                    BanderaFactura_recibo_proveedor = 2
                    Me.AddOwnedForm(frmDetalle)
                    oFactura_recibo_proveedor.Modificar(CInt(Me.lblid_pk.Text))
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                    RefrescarGrilla()
                Case "btnBorrar"
                    If Not IsNumeric(Me.lblid_pk.Text) Then
                        Exit Sub
                    End If
                    oFactura_recibo_proveedor.Borrar(CInt(Me.lblid_pk.Text))
                    RefrescarGrilla()
                Case "btnAyuda"
                    'Process.Start(PathAyuda + "frmAbmFactura_recibo.avi")
                Case "btnSalir"
                    Me.Close()
            End Select
            ' Me.txtBuscar.Text = ""
            ' Me.txtBuscar.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        If Me.dgv1.RowCount = 0 Then
            Try
                oRecibo_proveedor.Borrar_2(CInt(Me.lblid_recibo.Text))
            Catch ex As Exception
            End Try

        End If
        Me.txtNumero_4.ReadOnly = False
        Me.txtNumero_8.ReadOnly = False
        Me.btnAgregar.Enabled = False
        Me.btnBorrar.Enabled = False
        Me.btnModificar.Enabled = False
        Me.txtNumero_4.Text = ""
        Me.txtNumero_8.Text = ""
        Me.txtNumero_4.Focus()

        oRecibo_proveedor.Insertar()
        Me.lblid_recibo.Text = "0"

        Me.RefrescarGrilla_2()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
