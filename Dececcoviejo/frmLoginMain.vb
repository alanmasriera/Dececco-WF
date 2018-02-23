Public Class frmLoginMain

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Dim odtTemp As New DataTable

        'SP cop_Usuario_GetUser
        'Devuelve los datos del usuario, solo si usuario y contraseña son correctos
        odtTemp = oUsuario.GetUser(Me.UsernameTextBox.Text.Trim, Me.PasswordTextBox.Text.Trim)

        'Si no devuelve datos, es porque son incorrectos
        If odtTemp.Rows.Count <= 0 Then
            MessageBox.Show("Los datos ingresados son incorrectos", "PERMISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UsernameTextBox.Focus()
            UsernameTextBox.SelectAll()
        Else

            'VARIABLES GLOBALES
            vgNombreUsuario = Me.UsernameTextBox.Text
            vgCodigoUsuario = CInt(odtTemp.Rows(0).Item("id_usuario")) 'ID
            vgPermisoUsuario = CInt(odtTemp.Rows(0).Item("id_grupo_usuario")) 'GRUPO
            vgHoraIngreso = DateTime.Now

            'Todavía no se para que es
            vgCuentaProveedorResta = "FAC"
            Dim tabla1 As New DataTable
            'Busca todos los datos del usuario [Tabla: Usuario]
            tabla1 = oUsuario.GetOne(vgCodigoUsuario)
            If (tabla1.Rows(0)("session activa").ToString) = "" Then
                With oUsuario
                    .Cargar()
                    .Modificar(vgCodigoUsuario)
                    .session_activa = DateTime.Now
                    .Guardar()
                End With
            Else

                'Si sesión activa está dentro de los 2 minutos entonces el usuario esá logueado
                'TODO buscar una mejor implementación, no sirve para nada como lo hicieron
                Dim fecha As DateTime = CDate(tabla1.Rows(0)("session activa").ToString)
                If fecha >= DateTime.Now.AddMinutes(-2) Then
                    'MsgBox("El usuario ya se encuentra logueado, pero te logueo igual")
                    'MsgBox("El usuario ya se encuentra logueado")
                    'Exit Sub
                Else
                    With oUsuario
                        .Cargar()
                        .Modificar(vgCodigoUsuario)
                        .session_activa = DateTime.Now
                        .Guardar()
                    End With
                    Dim usuariologueado As String
                    usuariologueado = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString()
                    If vgNombreUsuario = usuariologueado Then

                    Else
                        'MsgBox("El usuario ya se encuentra logueado")
                        'Exit Sub
                    End If
                End If

            End If

            'Inicia el form principal
            frmLoginInicio.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub PasswordTextBox_Enter(sender As Object, e As EventArgs) Handles PasswordTextBox.Enter
        PasswordTextBox.SelectAll()
    End Sub
End Class
