Public Class frmAgregarAbm

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim odt As New DataTable

        If Me.txtNombre.Text = "" Or Me.txtDetalle.Text = "" Then
            MessageBox.Show("Debe llenar todos los campos")
            Exit Sub
        End If

        'agrego el permiso
        oPermiso.InsertNewPermiso(Me.txtDetalle.Text, Me.txtNombre.Text)

        'agrego el permiso para cada usuario
        odt = oGrupo_usuario.ConsultarTodo
        For Each row As DataRow In odt.Rows
            oPermiso.InsertNewPermisoUsuario(Me.txtNombre.Text, CInt(row("id_grupo_usuario")))
            MessageBox.Show("Se Agrego el Formulario Para: " & row("nombre_grupo_usuario").ToString)
        Next

        Me.txtDetalle.Text = ""
        Me.txtNombre.Text = ""
        Me.txtDetalle.Focus()
    End Sub


    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtDetalle.KeyPress, txtNombre.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

End Class