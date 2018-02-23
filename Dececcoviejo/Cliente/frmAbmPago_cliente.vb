Public Class frmAbmPago_cliente

   Dim odt As DataTable
   Dim BanderaConsultaPago_cliente As Integer

   Private Sub frmAbmPago_cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnAgregar, "Incorporar Nuevo Pago_cliente")
       Me.ttGeneral.SetToolTip(Me.btnBorrar, "Borrar un  Pago_cliente Existente")
       Me.ttGeneral.SetToolTip(Me.btnModificar, "Modificar  un Pago_cliente Existente")
       'Me.ttGeneral.SetToolTip(Me.btnConsultar, "Consultar Datos del  Pago_cliente Existente")

       Dim odt As DataTable
       odt = oPago_cliente.Cargar()

        Me.Cargarcliente()

       Me.txtBuscar.Focus()
       Me.lblTitulo.Text = "Pago_cliente"
        Me.Text = "Pago_cliente" & vgNombreFormulario
       Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
       Me.StartPosition = FormStartPosition.CenterScreen
       Me.MinimizeBox = False
       Me.MaximizeBox = False
       
        'control de acceso y de permisos
        Dim odtUser As New DataTable
        odtUser = oUsuario.GetPermiso(vgNombreUsuario, Me.Name)
        If odtUser.Rows.Count = 0 OrElse CDbl(odtUser.Rows(0).Item("habilitado")) = 0 Then
            Me.btnAgregar.Enabled = False
            Me.btnBorrar.Enabled = False
            Me.btnModificar.Enabled = False
        End If
        btnAyuda.Visible = False

        Me.lblid_cliente.Text = CType(Me.Owner, frmResumenCliente).lblid_cliente.Text
        Me.cmbCliente.Text = oCliente.GetOne(CInt(Me.lblid_cliente.Text)).Rows(0).Item("nombre Cliente").ToString.Trim
        Me.dtpPeriodo.Value = CType(Me.Owner, frmResumenCliente).dtpPeriodo.Value

        RefrescarGrilla()
   End Sub

    Sub Cargarcliente()
        Dim odt As New DataTable

        odt = oCliente.GetCmb_2
        With Me.cmbcliente
            .DataSource = odt
            .DisplayMember = "nombre_cliente"
            .ValueMember = "id_cliente"
        End With
        If Me.cmbCliente.SelectedIndex >= 0 Then
            cmbCliente.SelectedIndex = 0
            Me.lblid_cliente.Text = cmbCliente.SelectedValue.ToString
        End If
    End Sub

    Private Sub cmbcliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCliente.SelectedIndexChanged
        If Me.cmbCliente.SelectedIndex >= 0 Then
            Me.lblid_cliente.Text = cmbCliente.SelectedValue.ToString
        End If
        If Not IsNumeric(Me.lblid_cliente.Text) Then
            Exit Sub
        End If
        Me.RefrescarGrilla()
    End Sub

    Public Sub RefrescarGrilla()
        Dim odt2 As New DataTable
        Dim odt As DataTable
        odt = oPago_cliente.GetAll_3(CInt(Me.lblid_cliente.Text), Me.dtpPeriodo.Value)

        oTemp_grilla_pago_cliente.Truncate()
        For Each row As DataRow In odt.Rows
            With oTemp_grilla_pago_cliente
                .Cargar()
                .Insertar()
                .id_pago_cliente = CInt(row("id_pago_cliente"))
                .fecha = CDate(row("fecha"))
                .apellido = CStr(row("apellido_cliente"))
                .nombre = CStr(row("nombre_cliente"))
                .pago = CDec(row("pago"))
                .detalle = CStr(row("detalle"))
                .numero_recibo = CStr(row("numero_recibo"))
                .observacion = CStr(row("observacion"))

                odt2 = oRecibo_cliente.GetOne_factura(CInt(row("id_pago_cliente")))
                If odt2.Rows.Count > 0 Then
                    .numero_orden_compra = odt2.Rows(0).Item("numero_factura").ToString
                Else
                    .numero_orden_compra = "0"
                End If

                .Guardar()
            End With
        Next
        Me.dgv1.DataSource = oTemp_grilla_pago_cliente.ConsultarTodo()
        Me.dgv1.Columns(0).Visible = False
        Me.dgv1.Columns(9).HeaderText = "Nº Factura"
    End Sub

   Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
       If e.KeyChar.ToString = vbCr Then
           Me.btnModificar.Focus()
       End If
   End Sub

   Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
       If Me.txtBuscar.Text = "" Then
           Me.txtBuscar.Text = " "
       End If
        odt = oPago_cliente.Find_2(Me.txtBuscar.Text)
       Me.dgv1.DataSource = odt
   End Sub

   Private Sub dgv1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv1.CurrentCellChanged
       Try
            Me.lblid_pk.Text = CStr(Me.dgv1.Item("id pago cliente", Me.dgv1.CurrentRow.Index).Value)
       Catch ex As Exception
       End Try
   End Sub

    Private Sub Botones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click, btnAyuda.Click, btnBorrar.Click, btnModificar.Click, btnSalir.Click, btnImprimir.Click
        Dim btnTemp As New Button
        Dim frmDetalle As New frmDetallePago_cliente
        btnTemp = CType(sender, Button)
        Try
            Select Case btnTemp.Name
                Case "btnAgregar"
                    BanderaPago_cliente = 1
                    Me.AddOwnedForm(frmDetalle)
                    oPago_cliente.Insertar()
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                Case "btnModificar"
                    If Not IsNumeric(Me.lblid_pk.Text) Then
                        Exit Sub
                    End If
                    BanderaPago_cliente = 2
                    Me.AddOwnedForm(frmDetalle)
                    oPago_cliente.Modificar(CInt(Me.lblid_pk.Text))
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

                    Dim odt As New DataTable
                    Dim odt_2 As New DataTable
                    Dim odt_3 As New DataTable

                    'desarchivo las facturas
                    odt = oRecibo_cliente.GetAllPagoCliente(CInt(Me.lblid_pk.Text))
                    For Each row As DataRow In odt.Rows
                        oFactura.ArchivarFactura(CInt(row.Item("id_recibo_cliente")), False)
                    Next

                    'desarchivo los cheques caja
                    odt_2 = oRecibo_cliente_cheque.GetAllPagoCliente_2(CInt(Me.lblid_pk.Text))
                    For Each row_2 As DataRow In odt_2.Rows
                        oCheque_recibido.ArchivarCheque(CInt(row_2.Item("id_cheque_recibido")), False)
                    Next

                    'desarchivo los cheques banco
                    odt_3 = oRecibo_cliente_cheque_2.GetAllPagoCliente_2(CInt(Me.lblid_pk.Text))
                    For Each row_3 As DataRow In odt_3.Rows
                        oChequeRecibido.ArchivarCheque(CInt(row_3.Item("id_cheque_recibido")), False)
                    Next

                    oRecibo_cliente.DeletePago_cliente(CInt(Me.lblid_pk.Text))
                    oRecibo_cliente_cheque.DeleteRecibo_cliente(CInt(Me.lblid_pk.Text))
                    oRecibo_cliente_cheque_2.DeleteRecibo_cliente(CInt(Me.lblid_pk.Text))

                    oPago_cliente.Borrar(CInt(Me.lblid_pk.Text))
                    RefrescarGrilla()
                    'Case "btnAyuda"
                    '    'Process.Start(PathAyuda + "frmAbmPago_cliente.avi")
                    'Case "btnSalir"
                    '    Me.Close()
                Case "btnImprimir"
                    Dim frmimpresiontemporal As New frmReporteReciboConsole

                    Try
                        Banderaprintpantalla = "recibo"
                        parametro_fac = CInt(lblid_pk.Text)
                        frmimpresiontemporal.ShowDialog()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
            End Select
            'Me.txtBuscar.Text = ""
            'Me.txtBuscar.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dtpPeriodo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpPeriodo.ValueChanged
        Me.RefrescarGrilla()
    End Sub

    Private Sub dgv1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellContentClick

    End Sub
End Class
