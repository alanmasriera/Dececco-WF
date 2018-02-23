Public Class frmAbmFactura_proveedor

    'Dim odt As DataTable
   Dim BanderaConsultaFactura_proveedor As Integer

   Private Sub frmAbmFactura_proveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnAgregar, "Incorporar Nuevo Factura_proveedor")
       Me.ttGeneral.SetToolTip(Me.btnBorrar, "Borrar un  Factura_proveedor Existente")
       Me.ttGeneral.SetToolTip(Me.btnModificar, "Modificar  un Factura_proveedor Existente")
       'Me.ttGeneral.SetToolTip(Me.btnConsultar, "Consultar Datos del  Factura_proveedor Existente")

       Dim odt As DataTable
        odt = oFactura_proveedor.Cargar()

        'Dim odt2 As DataTable
        'odt2 = oNota_devolucion.Cargar()

        'Me.txtBuscar.Focus()
        Me.lblTitulo.Text = "Factura_proveedor"
        Me.Text = "Factura_proveedor" & vgNombreFormulario
        Me.CancelButton = Me.btnSalir
        'Me.BackColor = Color.Gainsboro
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

            Me.btnAgregarND.Enabled = False
            Me.btnBorrarND.Enabled = False
            Me.btnModificarND.Enabled = False
        End If
        Me.btnAyuda.Visible = False

        Me.CargarProveedor()
        'Me.CargarEmpresa()
        'Me.CargarAlmacen()

        If (vgFormularioPadre = "frmDetalleFactura_recibo_proveedor") Then
            Me.lblid_proveedor.Text = CType(Me.Owner, frmDetalleFactura_recibo_proveedor).lblid_proveedor.Text
            Me.cmbProveedor.Text = oProveedor.GetOne(CInt(Me.lblid_proveedor.Text)).Rows(0).Item("nombre Proveedor").ToString.Trim
        ElseIf (vgFormularioPadre = "frmResumenProveedor") Then
            Me.lblid_proveedor.Text = CType(Me.Owner, frmResumenProveedor).lblid_proveedor.Text
            Me.cmbProveedor.Text = CType(Me.Owner, frmResumenProveedor).cmbProveedor.Text

        End If


        Me.dtpPeriodo.Value = Date.Now
        Me.lblid_empresa.Text = "1"

        RefrescarGrilla()
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

    Sub CargarEmpresa()
        Dim odt As New DataTable

        odt = oEmpresa.GetCmb
        With Me.cmbEmpresa
            .DataSource = odt
            .DisplayMember = "nombre_Empresa"
            .ValueMember = "id_Empresa"
        End With
        If Me.cmbEmpresa.SelectedIndex >= 0 Then
            cmbEmpresa.SelectedIndex = 0
            Me.lblid_empresa.Text = cmbEmpresa.SelectedValue.ToString
        End If
    End Sub

    'Sub CargarAlmacen()
    '    Dim odt As New DataTable

    '    odt = oAlmacen.GetCmb
    '    With Me.cmbAlmacen
    '        .DataSource = odt
    '        .DisplayMember = "nombre_Almacen"
    '        .ValueMember = "id_Almacen"
    '    End With
    '    If Me.cmbAlmacen.SelectedIndex >= 0 Then
    '        cmbAlmacen.SelectedIndex = 0
    '        Me.lblid_Almacen.Text = cmbAlmacen.SelectedValue.ToString
    '    End If
    'End Sub

    Dim odt As DataTable
    Dim odt2 As DataTable

    Sub CalcularTotal()
        Dim decTotalFactura As Decimal = 0
        Dim decTotalND As Decimal = 0

        Try
            For Each row As DataRow In odt.Rows
                decTotalFactura = decTotalFactura + CDec(row.Item("Total"))
            Next
        Catch ex As Exception
            Errores(ex)
        End Try

        'Try
        '    For Each row2 As DataRow In odt2.Rows
        '        decTotalND = decTotalND + CDec(row2.Item("Total"))
        '    Next
        'Catch ex As Exception
        '    Errores(ex)
        'End Try

        Try
            Me.txtTotalFactura.Text = CStr(decTotalFactura)
        Catch ex As Exception
            Errores(ex)
        End Try
        Try
            Me.txtTotalND.Text = CStr(decTotalND)
        Catch ex As Exception
            Errores(ex)
        End Try
        Try
            Me.txtTotalAbonar.Text = CStr(decTotalFactura - decTotalND)
        Catch ex As Exception
            Errores(ex)
        End Try
    End Sub


    Public Sub RefrescarGrilla()


        If rbnSin.Checked = True Then
            odt = oFactura_proveedor.GetAll_3(CInt(Me.lblid_empresa.Text), CInt(Me.lblid_proveedor.Text), Me.dtpPeriodo.Value, 0)
        ElseIf rbnCon.Checked = True Then
            odt = oFactura_proveedor.GetAll_3(CInt(Me.lblid_empresa.Text), CInt(Me.lblid_proveedor.Text), Me.dtpPeriodo.Value, 1)
        Else
            odt = oFactura_proveedor.GetAll_3(CInt(Me.lblid_empresa.Text), CInt(Me.lblid_proveedor.Text), Me.dtpPeriodo.Value, 2)
        End If

        Me.dgv1.DataSource = odt
        Me.dgv1.Columns(0).Visible = False

        'If rbnSin.Checked = True Then
        '    odt2 = oNota_devolucion.GetAll_2(CInt(Me.lblid_empresa.Text), CInt(Me.lblid_proveedor.Text), Me.dtpPeriodo.Value, 0)
        'ElseIf rbnCon.Checked = True Then
        '    odt2 = oNota_devolucion.GetAll_2(CInt(Me.lblid_empresa.Text), CInt(Me.lblid_proveedor.Text), Me.dtpPeriodo.Value, 1)
        'Else
        '    odt2 = oNota_devolucion.GetAll_2(CInt(Me.lblid_empresa.Text), CInt(Me.lblid_proveedor.Text), Me.dtpPeriodo.Value, 2)
        'End If

        'Me.dgv2.DataSource = odt2
        'Me.dgv2.Columns(0).Visible = False

        Dim odt_2 As New DataTable
        odt_2 = oIva_compra.GetOneDate(Me.dtpPeriodo.Value.Date)
        If odt_2.Rows.Count <= 0 Then
            Me.lblEstado_libro.Text = "ABIERTO"
            Me.lblEstado_libro.BackColor = Color.Lime
            Me.btnAgregar.Enabled = True

        Else

            Me.lblEstado_libro.Text = "CERRADO"
            Me.lblEstado_libro.BackColor = Color.Red
            Me.btnAgregar.Enabled = False
        End If

        Me.CalcularTotal()
    End Sub



    'Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If e.KeyChar.ToString = vbCr Then
    '        Me.btnModificar.Focus()
    '    End If
    'End Sub

    'Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Me.txtBuscar.Text = "" Then
    '        Me.txtBuscar.Text = " "
    '    End If
    '    odt = oFactura_proveedor.Buscar(Me.txtBuscar.Text)
    '    Me.dgv1.DataSource = odt
    'End Sub

    Private Sub dgv1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellDoubleClick
        Try
            'pongo el id para hacer el cambio
            Me.lblid_pk.Text = CStr(Me.dgv1.Item("id_factura_proveedor", Me.dgv1.CurrentRow.Index).Value)

            If dgv1.Columns(e.ColumnIndex).Name = "Tilde" Then
                oFactura_proveedor.UpdateTilde(CInt(Me.lblid_pk.Text))
                Me.RefrescarGrilla()
            End If
        Catch ex As Exception
            Errores(ex)
        End Try
    End Sub

   Private Sub dgv1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv1.CurrentCellChanged
       Try
           Me.lblid_pk.Text = CStr(Me.dgv1.Item(0, Me.dgv1.CurrentRow.Index).Value)
       Catch ex As Exception
       End Try
   End Sub

    Private Sub Botones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnAgregar.Click, btnAyuda.Click, btnBorrar.Click, btnModificar.Click, btnSalir.Click

        Dim btnTemp As New Button
        Dim frmDetalle As New frmDetalleFactura_proveedor
        btnTemp = CType(sender, Button)

        vgFormularioPadre = Me.Name

        Try
            Select Case btnTemp.Name
                Case "btnAgregar"
                    BanderaFactura_proveedor = 1
                    Me.AddOwnedForm(frmDetalle)
                    oFactura_proveedor.Insertar()
                    frmDetalle.CargarCombosFactura()
                    frmDetalle.ShowDialog()
                Case "btnModificar"
                    If Not IsNumeric(Me.lblid_pk.Text) Then
                        Exit Sub
                    End If
                    BanderaFactura_proveedor = 2
                    Me.AddOwnedForm(frmDetalle)
                    oFactura_proveedor.Modificar(CInt(Me.lblid_pk.Text))
                    frmDetalle.CargarCombosFactura()
                    frmDetalle.ShowDialog()
                    RefrescarGrilla()
                Case "btnBorrar"
                    If Not IsNumeric(Me.lblid_pk.Text) Then
                        Exit Sub
                    End If

                    'If Not IsNumeric(Me.lblid_almacen.Text) Then
                    '    Exit Sub
                    'End If

                    'If Me.lblid_almacen.Text = "0" Or Me.lblid_pk.Text = "0" Then
                    '    Exit Sub
                    'End If

                    If MessageBox.Show("Desea Realmente Eliminar el Registro ", "BORRAR", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                    = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                    'oCuerpo_factura_proveedor.DeleteStockFactura(CInt(Me.lblid_pk.Text), CInt(Me.lblid_almacen.Text))

                    ''descuento del stock
                    'oProducto.UpdateStockFacturaDescuento(CInt(Me.lblid_pk.Text), CInt(Me.lblid_almacen.Text))  

                    'borro el cuerpo
                    oCuerpo_factura_proveedor.DeleteFactura(CInt(Me.lblid_pk.Text))
                    'borro la factura
                    oFactura_proveedor.Borrar(CInt(Me.lblid_pk.Text))

                    RefrescarGrilla()
                Case "btnAyuda"
                    'Process.Start(PathAyuda + "frmAbmFactura_proveedor.avi")
                Case "btnSalir"
                    Me.Close()
            End Select
            'Me.txtBuscar.Text = ""
            'Me.txtBuscar.Focus()
        Catch ex As Exception
            Errores(ex)
        End Try
    End Sub

    Private Sub cmbEmpresa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEmpresa.SelectedIndexChanged
        If Me.cmbEmpresa.SelectedIndex >= 0 Then
            Me.lblid_empresa.Text = cmbEmpresa.SelectedValue.ToString
        End If
        If Not IsNumeric(Me.lblid_empresa.Text) Then
            Exit Sub
        End If
        Me.RefrescarGrilla()
    End Sub

    Private Sub btnBuscaEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaEmpresa.Click
        Dim frmTemporal As New frmAbmEmpresa
        frmTemporal.ShowDialog()
        Me.CargarEmpresa()
        Me.cmbEmpresa.Focus()
        Me.cmbEmpresa.Text = ""
        Me.lblid_empresa.Text = "0"
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

    Private Sub btnBuscaProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaProveedor.Click
        Dim frmTemporal As New frmAbmProveedor
        frmTemporal.ShowDialog()
        Me.CargarProveedor()
        Me.cmbProveedor.Focus()
        Me.cmbProveedor.Text = ""
        Me.lblid_proveedor.Text = "0"
    End Sub

    Private Sub cmbAlmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAlmacen.SelectedIndexChanged
        If Me.cmbAlmacen.SelectedIndex >= 0 Then
            Me.lblid_almacen.Text = cmbAlmacen.SelectedValue.ToString
        End If
    End Sub

    Private Sub dtpPeriodo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpPeriodo.ValueChanged
        Me.RefrescarGrilla()
    End Sub








    'Private Sub BotonesND_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    'Handles btnAgregarND.Click, btnModificarND.Click, btnBorrarND.Click
    '    Dim btnTemp As New Button
    '    Dim frmDetalle As New frmDetalleNota_devolucion
    '    btnTemp = CType(sender, Button)
    '    Try
    '        Select Case btnTemp.Name
    '            Case "btnAgregarND"
    '                BanderaNota_devolucion = 1
    '                Me.AddOwnedForm(frmDetalle)
    '                oNota_devolucion.Insertar()
    '                frmDetalle.CargarCombos()
    '                frmDetalle.ShowDialog()
    '            Case "btnModificarND"
    '                If Not IsNumeric(Me.lblid_pk2.Text) Then
    '                    Exit Sub
    '                End If
    '                BanderaNota_devolucion = 2
    '                Me.AddOwnedForm(frmDetalle)
    '                oNota_devolucion.Modificar(CInt(Me.lblid_pk2.Text))
    '                frmDetalle.CargarCombos()
    '                frmDetalle.ShowDialog()
    '                RefrescarGrilla()
    '            Case "btnBorrarND"
    '                If Not IsNumeric(Me.lblid_pk2.Text) Then
    '                    Exit Sub
    '                End If

    '                If Not IsNumeric(Me.lblid_almacen.Text) Then
    '                    Exit Sub
    '                End If

    '                If Me.lblid_almacen.Text = "0" Or Me.lblid_pk2.Text = "0" Then
    '                    Exit Sub
    '                End If

    '                If MessageBox.Show("Desea Realmente Eliminar el Registro ", "BORRAR", _
    '                MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
    '                = Windows.Forms.DialogResult.No Then
    '                    Exit Sub
    '                End If

    '                'descuento del stock
    '                oProducto.UpdateStockNDDescuento(CInt(Me.lblid_pk2.Text), CInt(Me.lblid_almacen.Text))
    '                'borro el cuerpo
    '                oCuerpo_nota_devolucion.DeleteND(CInt(Me.lblid_pk2.Text))
    '                'borro la nota de devolucion
    '                oNota_devolucion.Borrar(CInt(Me.lblid_pk2.Text))

    '                RefrescarGrilla()

    '        End Select
    '        ' Me.txtBuscar.Text = ""
    '        ' Me.txtBuscar.Focus()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    'Private Sub dgv2_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv2.CellDoubleClick
    '    Try
    '        'pongo el id para hacer el cambio
    '        Me.lblid_pk2.Text = CStr(Me.dgv2.Item("id_nota_devolucion", Me.dgv2.CurrentRow.Index).Value)

    '        If dgv2.Columns(e.ColumnIndex).Name = "Tilde" Then
    '            oNota_devolucion.UpdateTilde(CInt(Me.lblid_pk2.Text))
    '            Me.RefrescarGrilla()
    '        End If
    '    Catch ex As Exception
    '        Errores(ex)
    '    End Try
    'End Sub

    'Private Sub dgv2_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv2.CurrentCellChanged
    '    Try
    '        Me.lblid_pk2.Text = CStr(Me.dgv2.Item(0, Me.dgv2.CurrentRow.Index).Value)
    '    Catch ex As Exception
    '    End Try
    'End Sub

    Private Sub RadioButtons_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles rbnSin.CheckedChanged, rbnCon.CheckedChanged, rbnTodo.CheckedChanged
        Dim rbnTemp As New RadioButton
        rbnTemp = CType(sender, RadioButton)

        Select Case rbnTemp.Name
            Case "rbnSin"
                Me.RefrescarGrilla()
            Case "rbnCon"
                Me.RefrescarGrilla()
            Case "rbnTodo"
                Me.RefrescarGrilla()
        End Select

    End Sub

End Class
