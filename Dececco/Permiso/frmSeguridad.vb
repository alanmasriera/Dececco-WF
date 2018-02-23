Public Class frmSeguridad

    Private Sub frmSeguridad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'control de acceso y de permisos
        Dim odtUser As New DataTable
        odtUser = oUsuario.GetPermiso(vgNombreUsuario, Me.Name)
        If odtUser.Rows.Count = 0 OrElse CBool(odtUser.Rows(0).Item("habilitado")) = False Then
            Me.btnGrupo_usuario.Enabled = False
            Me.btnUsuario.Enabled = False
            Me.btnPermiso.Enabled = False
            Me.btnBackup.Enabled = False
        End If

        'If vgNombreUsuario = "administradorsistema" Then
        Dim tabla As New DataTable
        tabla = oUsuario_permiso.GetOnen(vgCodigoUsuario, 71)
        If tabla.Rows.Count > 0 Then
            Me.btnPermisoAbm.Visible = True
        End If
        'End If
    End Sub


    Private Sub Botones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnGrupo_usuario.Click, btnSalir.Click, btnUsuario.Click, btnPermiso.Click, _
    btnBackup.Click, btnPermisoAbm.Click, Button1.Click

        Dim btnTemp As New Button
        btnTemp = CType(sender, Button)

        Select Case btnTemp.Name
            Case "btnSalir"
                Me.Close()
            Case "btnGrupo_usuario"
                Dim frmTemp As New frmAbmGrupo_usuario
                frmTemp.ShowDialog()
            Case "btnUsuario"
                Dim frmTemp As New frmAbmUsuario
                frmTemp.ShowDialog()
            Case "btnPermiso"
                Dim frmTemp As New frmDetalleGrupo_permiso
                frmTemp.ShowDialog()
            Case "btnBackup"
                Dim frmTemp As New frmBackup
                frmTemp.ShowDialog()
            Case "btnPermisoAbm"
                Dim frmTemp As New frmAgregarAbm
                frmTemp.ShowDialog()
            Case "Button1"
                Dim frmTemp As New frmAbmUsuario_permiso
                frmTemp.ShowDialog()

        End Select
    End Sub

End Class