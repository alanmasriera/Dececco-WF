Public Class frmDetalleGrupo_permiso

    Private Sub frmDetalleGrupo_permiso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttGrupo_usuario.SetToolTip(Me.btnBuscaGrupo_usuario, "Buscar Nuevo Grupo_usuario")
        '   Me.ttPermiso.SetToolTip(Me.btnBuscaPermiso, "Buscar Nuevo Permiso")
        '    Me.ttGuardar.SetToolTip(Me.btnGuardar, "Guardar Datos del Grupo_permiso")
        Me.ttSalir.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()

            Me.cmbGrupo_usuario.Text = oGrupo_usuario.GetOne(CInt(Me.lblid_grupo_usuario.Text)).Rows(0).Item("nombre_Grupo_usuario").ToString.Trim
        Catch ex As Exception
            '    Errores(ex)
        End Try

        If BanderaGrupo_permiso = 1 Then
            Me.LimpiarControles()
        End If
        Me.Text = "Grupo_permiso"
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False

        Me.CargarCombos()
    End Sub

    Sub CargarCombos()
        Me.CargarGrupo_usuario()
        '  Me.CargarPermiso()
    End Sub

    Sub CargarGrupo_usuario()
        Dim odt As New DataTable

        odt = oGrupo_usuario.GetCmb
        With Me.cmbGrupo_usuario
            .DataSource = odt
            .DisplayMember = "nombre_Grupo_usuario"
            .ValueMember = "id_Grupo_usuario"
        End With
        If Me.cmbGrupo_usuario.SelectedIndex >= 0 Then
            cmbGrupo_usuario.SelectedIndex = 0
            Me.lblid_grupo_usuario.Text = cmbGrupo_usuario.SelectedValue.ToString
        End If
    End Sub

    Sub CargarPermiso()
        Dim odt As New DataTable

        odt = oGrupo_permiso.GetPermiso(CInt(Me.lblid_grupo_usuario.Text))

        Me.dgv1.DataSource = odt
        Me.dgv1.Columns(0).Visible = False

    End Sub

    Sub LimpiarGrilla()
        Dim odt As New DataTable

        odt = oGrupo_permiso.GetPermiso(0)
        Me.dgv1.DataSource = odt
        Me.dgv1.Columns(0).Visible = False
    End Sub

    Sub LimpiarControles()
        Me.lblid_grupo_usuario.Text = "0"
        Me.cmbGrupo_usuario.Text = ""
    End Sub

    Private Sub ObtenerDatos()
        Me.lblid_grupo_usuario.Text = CStr(oGrupo_permiso.id_grupo_usuario)
    End Sub

    Public Sub SoloLectura()
        Me.cmbGrupo_usuario.Enabled = False
        Me.btnBuscaGrupo_usuario.Enabled = False
    End Sub

    Private Sub Guardar()
        Try
            '    Me.AsignarDatos()
            Select Case BanderaGrupo_permiso
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oGrupo_permiso.Guardar()
                    '   CType(Me.Owner, frmAbmGrupo_permiso).RefrescarGrilla()
                    Me.CargarCombos()
                    oGrupo_permiso.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.cmbGrupo_usuario.Focus()
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oGrupo_permiso.Guardar()
                    Me.Close()
            End Select
        Catch ex As Exception
            Errores(ex)
        End Try
    End Sub

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If Me.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cmbGrupo_usuario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGrupo_usuario.SelectedIndexChanged
        If Me.cmbGrupo_usuario.SelectedIndex >= 0 Then
            Me.lblid_grupo_usuario.Text = cmbGrupo_usuario.SelectedValue.ToString
        End If
        If Not IsNumeric(Me.lblid_grupo_usuario.Text) Then
            Exit Sub
        End If
        Me.CargarPermiso()
    End Sub

    Private Sub btnBuscaGrupo_usuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaGrupo_usuario.Click
        Dim frmTemporal As New FrmAbmGrupo_usuario
        frmTemporal.ShowDialog()
        Me.CargarGrupo_usuario()
        Me.cmbGrupo_usuario.Focus()
        Me.cmbGrupo_usuario.Text = ""
        Me.lblid_grupo_usuario.Text = "0"
        Me.LimpiarGrilla()
    End Sub

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    'Handles chkhabilitado.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles cmbGrupo_usuario.KeyDown
        If CDbl(e.KeyValue.ToString) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    'Handles 
        Dim txtTemp As TextBox
        txtTemp = CType(sender, TextBox)

        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Then
            If InStr(txtTemp.Text, ",") <> 0 Then
                e.Handled = True
            Else
                e.KeyChar = CChar(",")
            End If
        End If

        Dim Largo As Integer = InStr(txtTemp.Text, ",")

        If txtTemp.Text.Length > Largo + 2 And Largo <> 0 And e.KeyChar.ToString <> vbBack Then
            e.Handled = True
        End If

        If (e.KeyChar.ToString >= "0" And e.KeyChar.ToString <= "9") Or e.KeyChar.ToString = "," Or e.KeyChar = vbBack Then
            '  e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub btnLlenar_permiso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLlenar_permiso.Click
        If Not IsNumeric(Me.lblid_grupo_usuario.Text) Then
            Exit Sub
        End If

        Dim odt As New DataTable
        Dim odt_permiso As New DataTable
        odt_permiso = oPermiso.ConsultarTodo()



        For Each row As DataRow In odt_permiso.Rows
            odt = oGrupo_permiso.Exist_2(CInt(Me.lblid_grupo_usuario.Text), CInt(row("id_permiso").ToString()))

            If odt.Rows.Count > 0 Then
            Else
                With oGrupo_permiso
                    .Cargar()
                    .Insertar()
                    .habilitado = False
                    .id_grupo_usuario = CInt(Me.lblid_grupo_usuario.Text)
                    .id_permiso = CInt(row("id_permiso").ToString())
                    .Guardar()
                End With
            End If
        Next

        Me.CargarPermiso()

    End Sub


    Private Sub dgv1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv1.CurrentCellChanged
        Try
            Me.lblid_pk.Text = CStr(Me.dgv1.Item(0, Me.dgv1.CurrentRow.Index).Value)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgv1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellDoubleClick
        Try
            If dgv1.Columns(e.ColumnIndex).Name = "HABILITADO" Then
                If CDbl(Me.dgv1.Item("HABILITADO", Me.dgv1.CurrentRow.Index).Value) = 0 Then
                    oGrupo_permiso.Update_Check(CInt(Me.lblid_pk.Text), True)
                Else
                    oGrupo_permiso.Update_Check(CInt(Me.lblid_pk.Text), False)
                End If
                Me.CargarPermiso()
            End If
        Catch ex As Exception
            Errores(ex)
        End Try
    End Sub

    Private Sub btnCheckAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckAll.Click
        If Not IsNumeric(Me.lblid_grupo_usuario.Text) Then
            Exit Sub
        End If
        oGrupo_permiso.Update_CheckAll(CInt(Me.lblid_grupo_usuario.Text))
        Me.CargarPermiso()
    End Sub

    Private Sub btnUnCheckAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnCheckAll.Click
        If Not IsNumeric(Me.lblid_grupo_usuario.Text) Then
            Exit Sub
        End If
        oGrupo_permiso.Update_UnCheckAll(CInt(Me.lblid_grupo_usuario.Text))
        Me.CargarPermiso()
    End Sub

End Class