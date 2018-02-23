Public Class frmAbmRecibo_proveedor

    Dim odt As DataTable
    Dim BanderaConsultaRecibo As Integer

    Private Sub frmAbmRecibo_proveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttGeneral.SetToolTip(Me.btnAgregar, "Incorporar Nuevo Recibo")
        Me.ttGeneral.SetToolTip(Me.btnBorrar, "Borrar un  Recibo Existente")
        Me.ttGeneral.SetToolTip(Me.btnModificar, "Modificar  un Recibo Existente")
        'Me.ttGeneral.SetToolTip(Me.btnConsultar, "Consultar Datos del  Recibo Existente")

        Dim odt As DataTable
        odt = oRecibo_proveedor.Cargar()

        'cuando es 5 trabaja con los datos de la factura
        If BanderaRecibo_proveedor = 5 Then
            'Me.lblid_proveedor.Text = CType(Me.Owner, frmDetalleFactura).lblid_proveedor.Text
            'Me.dtpPeriodo.Value = CType(Me.Owner, frmDetalleFactura).dtpFecha.Value
            BanderaRecibo_proveedor = 0
        Else
            Me.lblid_proveedor.Text = CType(Me.Owner, frmResumenProveedor).lblid_proveedor.Text
            Me.dtpPeriodo.Value = CType(Me.Owner, frmResumenProveedor).dtpPeriodo.Value
        End If


        Me.cmbProveedor.Text = oProveedor.GetOne(CInt(Me.lblid_proveedor.Text)).Rows(0).Item("nombre_Proveedor").ToString.Trim

        RefrescarGrilla()
        Me.txtBuscar.Focus()
        Me.lblTitulo.Text = "Recibo"
        Me.Text = "Recibo" & NombreFormulario
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False

        'control de acceso y de permisos
        Dim odtUser As New DataTable
        odtUser = oUsuario.GetPermiso(NombreUsuario, Me.Name)
        If odtUser.Rows.Count = 0 OrElse CDbl(odtUser.Rows(0).Item("habilitado")) = 0 Then
            Me.btnAgregar.Enabled = False
            Me.btnBorrar.Enabled = False
            Me.btnModificar.Enabled = False
        End If
        btnAyuda.Visible = False

    End Sub

    Public Sub RefrescarGrilla()

        Dim odt As DataTable

        odt = oRecibo_proveedor.GetAll_2(CInt(Me.lblid_proveedor.Text), Me.dtpPeriodo.Value.Date)
        Me.dgv1.DataSource = odt
        Me.dgv1.Columns(0).Visible = False
        Me.dgv1.Columns("IMPORTE").DefaultCellStyle.Format = "c"
        Me.dgv1.Columns("IMPORTE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
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
        Dim frmDetalle As New frmDetalleRecibo_proveedor_2
        btnTemp = CType(sender, Button)
        Try
            Select Case btnTemp.Name
                Case "btnAgregar"
                    BanderaRecibo_proveedor = 1
                    Me.AddOwnedForm(frmDetalle)
                    oRecibo_proveedor.Insertar()
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                Case "btnModificar"
                    If Not IsNumeric(Me.lblid_pk.Text) Then
                        Exit Sub
                    End If
                    BanderaRecibo_proveedor = 2
                    Me.AddOwnedForm(frmDetalle)
                    oRecibo_proveedor.Modificar(CInt(Me.lblid_pk.Text))
                    frmDetalle.CargarCombos()
                    'frmDetalle.btnNuevo.Enabled = False
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
                    oRecibo_proveedor.Borrar(CInt(Me.lblid_pk.Text))
                    Dim odtTemp As New DataTable
                    Dim id_factura As Integer
                    Dim saldo_factura As Decimal

                    odtTemp = oFactura_recibo_proveedor.GetAll_3(CInt(Me.lblid_pk.Text))
                    For Each row As DataRow In odtTemp.Rows
                        id_factura = CInt(row.Item("id_factura"))
                        saldo_factura = CDec(row.Item("importe_pagado"))
                        oFactura_recibo_proveedor.Update_saldo_factura(id_factura, saldo_factura)
                    Next
                    RefrescarGrilla()
                Case "btnAyuda"
                    'Process.Start(PathAyuda + "frmAbmRecibo.avi")
                Case "btnSalir"
                    Me.Close()
            End Select
            Me.txtBuscar.Text = ""
            Me.txtBuscar.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dtpPeriodo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpPeriodo.ValueChanged
        Try
            Me.RefrescarGrilla()
        Catch ex As Exception
        End Try
    End Sub

End Class
