Public Class frmAbmPago_proveedor

    Dim odt As DataTable
    Dim BanderaConsultaPago_proveedor As Integer

    Private Sub frmAbmPago_proveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttGeneral.SetToolTip(Me.btnAgregar, "Incorporar Nuevo Pago_proveedor")
        Me.ttGeneral.SetToolTip(Me.btnBorrar, "Borrar un  Pago_proveedor Existente")
        Me.ttGeneral.SetToolTip(Me.btnModificar, "Modificar  un Pago_proveedor Existente")
        'Me.ttGeneral.SetToolTip(Me.btnConsultar, "Consultar Datos del  Pago_proveedor Existente")

        Dim odt As DataTable
        odt = oPago_proveedor.Cargar()

        Me.lblid_proveedor.Text = CType(Me.Owner, frmResumenProveedor).lblid_proveedor.Text
        Me.dtpPeriodo.Value = CType(Me.Owner, frmResumenProveedor).dtpPeriodo.Value

        Me.cmbProveedor.Text = oProveedor.GetOne(CInt(Me.lblid_proveedor.Text)).Rows(0).Item("nombre Proveedor").ToString.Trim


        RefrescarGrilla()
        Me.txtBuscar.Focus()
        Me.lblTitulo.Text = "Pago_proveedor"
        Me.Text = "Pago_proveedor" & vgNombreFormulario
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
    End Sub

    Public Sub RefrescarGrilla()
        Dim odt As DataTable

        odt = oPago_proveedor.GetAll_2(Me.dtpPeriodo.Value.Date, CInt(Me.lblid_proveedor.Text))
        Me.dgv1.DataSource = odt
        Me.dgv1.Columns(0).Visible = False
        Me.dgv1.Columns("PAGO").DefaultCellStyle.Format = "c"
        Me.dgv1.Columns("PAGO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
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
        odt = oPago_proveedor.Buscar(Me.txtBuscar.Text)
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

        btnTemp = CType(sender, Button)
        Try
            Select Case btnTemp.Name
                Case "btnAgregar"
                  
                Case "btnModificar"
                    If Not IsNumeric(Me.lblid_pk.Text) Then
                        Exit Sub
                    End If
                    BanderaPago_proveedor = 2
                    oPago_proveedor.Modificar(CInt(Me.lblid_pk.Text))
                
                Case "btnBorrar"
                    If Not IsNumeric(Me.lblid_pk.Text) Then
                        Exit Sub
                    End If
                    oPago_proveedor.Borrar(CInt(Me.lblid_pk.Text))
                    RefrescarGrilla()
                Case "btnAyuda"
                    'Process.Start(PathAyuda + "frmAbmPago_proveedor.avi")
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
        Me.RefrescarGrilla()
    End Sub

End Class