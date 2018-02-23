Public Class frmBackup

    Private Sub frmBackup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttCarpeta.SetToolTip(Me.btnBuscaPath, "Seleccionar la Carpeta en Dónde se va ha Guardar la Copia de Seguridad")

        'control de acceso y de permisos
        Dim odtUser As New DataTable
        odtUser = oUsuario.GetPermiso(vgNombreUsuario, Me.Name)
        If odtUser.Rows.Count = 0 OrElse CBool(odtUser.Rows(0).Item("habilitado")) = False Then
            Me.btnBackup.Enabled = False
        End If
    End Sub



    Private Sub Botones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnBackup.Click, btnSalir.Click, btnBuscaPath.Click
        Dim btnTemp As New Button
        btnTemp = CType(sender, Button)

        Select Case btnTemp.Name
            Case "btnSalir"
                Me.Close()
            Case "btnBackup"
                If Me.txtNombre_archivo.Text = "" Or Me.txtPath.Text = "" Then
                    Exit Sub
                End If
                oBackup.nombre_base_dato = "DECECCO"

                'controlo si el path es "c:\"
                If Me.txtPath.Text.Length <= 3 Then
                    oBackup.path = Me.txtPath.Text.Trim & Me.txtNombre_archivo.Text.Trim
                Else
                    oBackup.path = Me.txtPath.Text.Trim & "\" & Me.txtNombre_archivo.Text.Trim
                End If

                oBackup.HacerBackup()
            Case "btnBuscaPath"
                Me.FolderBrowserDialog1.ShowDialog()
                Me.txtPath.Text = Me.FolderBrowserDialog1.SelectedPath
        End Select
    End Sub

End Class