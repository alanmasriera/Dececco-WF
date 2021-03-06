Public Class frmAbmGrupo_permiso

   Dim odt As DataTable
   Dim BanderaConsultaGrupo_permiso As Integer

   Private Sub frmAbmGrupo_permiso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnAgregar, "Incorporar Nuevo Grupo_permiso")
       Me.ttGeneral.SetToolTip(Me.btnBorrar, "Borrar un  Grupo_permiso Existente")
       Me.ttGeneral.SetToolTip(Me.btnModificar, "Modificar  un Grupo_permiso Existente")
       'Me.ttGeneral.SetToolTip(Me.btnConsultar, "Consultar Datos del  Grupo_permiso Existente")

       Dim odt As DataTable
       odt = oGrupo_permiso.Cargar()

       RefrescarGrilla()
       Me.txtBuscar.Focus()
       Me.lblTitulo.Text = "Grupo_permiso"
       Me.Text = "Grupo_permiso"
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

       odt = oGrupo_permiso.ConsultarTodo()
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
       odt = oGrupo_permiso.Buscar(Me.txtBuscar.Text)
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
       Dim frmDetalle As New frmDetalleGrupo_permiso
       btnTemp = CType(sender, Button)
       Try
           Select Case btnTemp.Name
               Case "btnAgregar"
                   BanderaGrupo_permiso = 1
                   Me.AddOwnedForm(frmDetalle)
                   oGrupo_permiso.Insertar()
                   frmDetalle.CargarCombos()
                   frmDetalle.ShowDialog()
               Case "btnModificar"
                   If Not IsNumeric(Me.lblid_pk.Text) Then
                       Exit Sub
                   End If
                   BanderaGrupo_permiso = 2
                   Me.AddOwnedForm(frmDetalle)
                   oGrupo_permiso.Modificar(CInt(Me.lblid_pk.Text))
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

                    oGrupo_permiso.Borrar(CInt(Me.lblid_pk.Text))
                   RefrescarGrilla()
               Case "btnAyuda"
                   'Process.Start(PathAyuda + "frmAbmGrupo_permiso.avi")
               Case "btnSalir"
                   Me.Close()
           End Select
           Me.txtBuscar.Text = ""
           Me.txtBuscar.Focus()
       Catch ex As Exception
            Errores(ex)
       End Try
   End Sub

   End Class
