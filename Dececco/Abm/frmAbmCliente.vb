Public Class frmAbmCliente

   Dim odt As DataTable
   Dim BanderaConsultaCliente As Integer

   Private Sub frmAbmCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnAgregar, "Incorporar Nuevo Cliente")
       Me.ttGeneral.SetToolTip(Me.btnBorrar, "Borrar un  Cliente Existente")
       Me.ttGeneral.SetToolTip(Me.btnModificar, "Modificar  un Cliente Existente")
       'Me.ttGeneral.SetToolTip(Me.btnConsultar, "Consultar Datos del  Cliente Existente")

       Dim odt As DataTable
       odt = oCliente.Cargar()

       RefrescarGrilla()
       Me.txtBuscar.Focus()
       Me.lblTitulo.Text = "Cliente"
        Me.Text = "Cliente" & vgNombreFormulario
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
       
   End Sub

   Public Sub RefrescarGrilla()
       Dim odt As DataTable

       odt = oCliente.ConsultarTodo()
        Me.dgv_clientes.DataSource = odt
        Me.dgv_clientes.Columns(0).Visible = False
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
        odt = oCliente.Buscar(Me.txtBuscar.Text)
        Me.dgv_clientes.DataSource = odt
    End Sub

    Private Sub dgv1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_clientes.CurrentCellChanged
        Try
            Me.lblid_pk.Text = CStr(Me.dgv_clientes.Item(0, Me.dgv_clientes.CurrentRow.Index).Value)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Botones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click, btnAyuda.Click, btnBorrar.Click, btnModificar.Click, btnSalir.Click
        Dim btnTemp As New Button
        Dim frmDetalle As New frmDetalleCliente
        btnTemp = CType(sender, Button)
        Try
            Select Case btnTemp.Name
                Case "btnAgregar"
                    BanderaCliente = 1
                    Me.AddOwnedForm(frmDetalle)
                    oCliente.Insertar()
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                Case "btnModificar"
                    If Not IsNumeric(Me.lblid_pk.Text) Then
                        Exit Sub
                    End If
                    BanderaCliente = 2
                    Me.AddOwnedForm(frmDetalle)
                    oCliente.Modificar(CInt(Me.lblid_pk.Text))
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                    RefrescarGrilla()
                Case "btnBorrar"
                    If Not IsNumeric(Me.lblid_pk.Text) Then
                        Exit Sub
                    End If

                    If MessageBox.Show("Desea Realmente Eliminar el Registro ", "BORRAR",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                   = System.Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If

                    oCliente.Borrar(CInt(Me.lblid_pk.Text))
                   RefrescarGrilla()
               Case "btnAyuda"
                   'Process.Start(PathAyuda + "frmAbmCliente.avi")
               Case "btnSalir"
                   Me.Close()
           End Select
           Me.txtBuscar.Text = ""
           Me.txtBuscar.Focus()
       Catch ex As Exception
       MessageBox.Show(ex.Message)
       End Try
   End Sub

   End Class
