Public Class frmAbmUsuario

    Dim odt As DataTable
    Dim BanderaConsultaUsuario As Integer

    Private Sub frmAbmUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttAgregar.SetToolTip(Me.btnAgregar, "Incorporar Nuevo Usuario")
        Me.ttBorrar.SetToolTip(Me.btnBorrar, "Borrar un  Usuario Existente")
        Me.ttModificar.SetToolTip(Me.btnModificar, "Modificar  un Usuario Existente")
        'Me.ttConsultar.SetToolTip(Me.btnConsultar, "Consultar Datos del  Usuario Existente")

        Dim odt As DataTable
        odt = oUsuario.Cargar

        RefrescarGrilla()
        Me.txtBuscar.Focus()
        Me.lblTitulo.Text = "Usuarios"
        Me.Text = "Usuarios"
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

        odt = oUsuario.GetAll_2()
        Me.dgv1.DataSource = odt
        Me.dgv1.Columns(0).Visible = False
        Me.dgv1.Columns("Password_usuario").Visible = False
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
        odt = oUsuario.Find_2(Me.txtBuscar.Text)
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
        Dim frmDetalle As New frmDetalleUsuario
        Dim user As New Entidades.Usuario

        btnTemp = CType(sender, Button)

        Select Case btnTemp.Name
            Case "btnAgregar"

                BanderaUsuario = 1
                Me.AddOwnedForm(frmDetalle)

                frmDetalle.CargarCombos()
                frmDetalle.ShowDialog()
                '.Cargar()
                '.Insertar()

                '.id_tipo_actividad = CInt(Me.cmb_actividad_subproyecto.SelectedValue)
                '.nombre_actividad = Me.txt_nombre_Actividad_subproyecto.Text
                '.costo_standart = CDec(oTipo_actividad.GetOne(CInt(Me.cmb_actividad_subproyecto.SelectedValue)).Rows(0).Item("criticidad").ToString()) 'PESO
                '.tiempo_standart = 0
                '.Guardar()
                'id_actividad_actual = .id_actividad

            Case "btnModificar"
                If Not IsNumeric(Me.lblid_pk.Text) Then
                    Exit Sub
                End If
                BanderaUsuario = 2
                user = ControladoresLogica.ControladorUsuarios.ObtenerUsuario(CInt(Me.lblid_pk.Text))
                frmDetalle = New frmDetalleUsuario(user)
                Me.AddOwnedForm(frmDetalle)
                frmDetalle.CargarCombos()
                frmDetalle.ShowDialog()
                RefrescarGrilla()
            Case "btnBorrar"
                If Not IsNumeric(Me.lblid_pk.Text) Then
                    Exit Sub
                End If
                user = ControladoresLogica.ControladorUsuarios.ObtenerUsuario(CInt(Me.lblid_pk.Text))
                ControladoresLogica.ControladorUsuarios.Eliminar(user)  
                RefrescarGrilla()
            Case "btnAyuda"
                'Process.Start(PathAyuda + "frmAbmUsuario.avi")
            Case "btnSalir"
                Me.Close()
        End Select
        Me.txtBuscar.Text = ""
        Me.txtBuscar.Focus()
        'Catch ex As Exception
        '    Errores(ex)
        'End Try
    End Sub

End Class