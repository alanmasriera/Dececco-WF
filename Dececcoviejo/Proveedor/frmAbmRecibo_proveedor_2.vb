Public Class frmAbmRecibo_proveedor_2

    Dim odt As DataTable
    Dim BanderaConsultaRecibo_proveedor As Integer

    Private Sub frmAbmRecibo_proveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttGeneral.SetToolTip(Me.btnAgregar, "Incorporar Nuevo Recibo_proveedor")
        Me.ttGeneral.SetToolTip(Me.btnBorrar, "Borrar un  Recibo_proveedor Existente")
        Me.ttGeneral.SetToolTip(Me.btnModificar, "Modificar  un Recibo_proveedor Existente")
        'Me.ttGeneral.SetToolTip(Me.btnConsultar, "Consultar Datos del  Recibo_proveedor Existente")

        Dim odt As DataTable
        odt = oRecibo_proveedor.Cargar()

        Me.CargarProveedor()

        Me.lblid_proveedor.Text = CType(Me.Owner, frmResumenProveedor).lblid_proveedor.Text
        Me.dtpPeriodo.Value = CType(Me.Owner, frmResumenProveedor).dtpPeriodo.Value

        Me.cmbProveedor.Text = oProveedor.GetOne(CInt(Me.lblid_proveedor.Text)).Rows(0).Item("nombre Proveedor").ToString.Trim

        RefrescarGrilla()
        Me.txtBuscar.Focus()
        Me.lblTitulo.Text = "Recibo_proveedor"
        Me.Text = "Recibo_proveedor"
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False

        'control de acceso y de permisos
        Dim odtUser As New DataTable
        'odtUser = oUsuario.GetPermiso(vgNombreUsuario, Me.Name)
        'If odtUser.Rows.Count = 0 OrElse CDbl(odtUser.Rows(0).Item("habilitado")) = 0 Then
        '    Me.btnAgregar.Enabled = False
        '    Me.btnBorrar.Enabled = False
        '    Me.btnModificar.Enabled = False
        'End If
        'Me.btnAyuda.Visible = False

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

    Private Sub cmbProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProveedor.SelectedIndexChanged
        If Me.cmbProveedor.SelectedIndex >= 0 Then
            Me.lblid_proveedor.Text = cmbProveedor.SelectedValue.ToString
        End If
        If Not IsNumeric(Me.lblid_proveedor.Text) Then
            Exit Sub
        End If
        Me.RefrescarGrilla()
    End Sub

    Public Sub RefrescarGrilla()
        Dim odt As DataTable

        'odt = oRecibo_proveedor.ConsultarTodo()
        odt = oRecibo_proveedor.GetAll_2(CInt(lblid_proveedor.Text), CDate(dtpPeriodo.Text))
        Me.dgv1.DataSource = odt
        Me.dgv1.Columns(0).Visible = False
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
        odt = oRecibo_proveedor.Buscar(Me.txtBuscar.Text)
        Me.dgv1.DataSource = odt
    End Sub

    Private Sub dgv1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv1.CurrentCellChanged
        Try
            Me.lblid_pk.Text = CStr(Me.dgv1.Item(0, Me.dgv1.CurrentRow.Index).Value)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Botones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click, btnAyuda.Click, btnBorrar.Click, btnModificar.Click, btnSalir.Click
        Dim btnTemp As New Button
        Dim frmDetalle As New frmDetalleRecibo_proveedor
        btnTemp = CType(sender, Button)
        'Try
        Select Case btnTemp.Name
            Case "btnAgregar"
                BanderaPago_proveedor = 1
                Me.AddOwnedForm(frmDetalle)
                oRecibo_proveedor.Insertar()
                frmDetalle.CargarCombos()
                frmDetalle.ShowDialog()
            Case "btnModificar"
                If Not IsNumeric(Me.lblid_pk.Text) Then
                    Exit Sub
                End If
                BanderaPago_proveedor = 2
                Me.AddOwnedForm(frmDetalle)
                oRecibo_proveedor.Modificar(CInt(Me.lblid_pk.Text))
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
                Dim odt_4 As New DataTable

                'desarchivo las facturas
                odt = oFactura_recibo_proveedor.GetAllRecibo_proveedor(CInt(Me.lblid_pk.Text))
                For Each row As DataRow In odt.Rows
                    oFactura_proveedor.ArchivarFactura(CInt(row.Item("id_factura_proveedor")), False)
                Next

                'desarchivo los cheques de banco
                odt_2 = oCheque_proveedor.GetAllRecibo_proveedor(CInt(Me.lblid_pk.Text))
                For Each row_2 As DataRow In odt_2.Rows
                    oChequeLibrado.ArchivarCheque(CInt(row_2.Item("id_cheque_librado")), False)
                Next

                'desarchiva los cheques de caja
                odt_3 = oCheque_proveedor_2.GetAllRecibo_proveedor(CInt(Me.lblid_pk.Text))
                For Each row_3 As DataGridViewRow In odt_3.Rows
                    oCheque_recibido.ArchivarCheque(CInt(row_3.Cells("id_cheque_recibido").Value), False)
                Next

                'desarchiva los egresos
                odt_4 = oEgreso_efectivo_proveedor.GetAllRecibo_proveedor(CInt(Me.lblid_pk.Text))
                For Each row_4 As DataGridViewRow In odt_4.Rows
                    oEgreso_efectivo.ArchivarEgreso(CInt(row_4.Cells("id egreso efectivo").Value), False)
                Next

                'borra los cuerpos
                oFactura_recibo_proveedor.DeleteFacturaRecibo_proveedor(CInt(Me.lblid_pk.Text))
                oCheque_proveedor.DeleteCheque_proveedor(CInt(Me.lblid_pk.Text))
                oCheque_proveedor_2.DeleteCheque_proveedor(CInt(Me.lblid_pk.Text))
                oEgreso_efectivo_proveedor.DeleteEgreso_efectivo_proveedor(CInt(Me.lblid_pk.Text))

                oRecibo_proveedor.Borrar(CInt(Me.lblid_pk.Text))
                RefrescarGrilla()
            Case "btnAyuda"
                'Process.Start(PathAyuda + "frmAbmRecibo_proveedor.avi")
            Case "btnSalir"
                Me.Close()
        End Select
        Me.txtBuscar.Text = ""
        Me.txtBuscar.Focus()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'Dim frmimpresiontemporal As New FrmReporteFactura

        'Try
        '   Banderaprintpantalla = "recibo_proveedor"
        '    parametro_fac = CInt(lblid_pk.Text)
        '    frmimpresiontemporal.ShowDialog()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try

        ' ''Dim frmTemp As New frmReporteOrdenVenta
        ' ''Me.AddOwnedForm(frmTemp)
        ' ''frmTemp.lblid_recibo_proveedor.Text = Me.lblid_pk.Text
        ' ''frmTemp.ShowDialog()
    End Sub

    Private Sub dtpPeriodo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpPeriodo.ValueChanged
        RefrescarGrilla()
    End Sub

End Class
