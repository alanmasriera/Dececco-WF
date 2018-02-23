Public Class frmAbmCalendario

   Dim odt As DataTable
   Dim BanderaConsultaCalendario As Integer

   Private Sub frmAbmCalendario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.ttGeneral.SetToolTip(Me.btnAgregar, "Incorporar Nuevo Calendario")
        'Me.ttGeneral.SetToolTip(Me.btnBorrar, "Borrar un  Calendario Existente")
        'Me.ttGeneral.SetToolTip(Me.btnModificar, "Modificar  un Calendario Existente")
       'Me.ttGeneral.SetToolTip(Me.btnConsultar, "Consultar Datos del  Calendario Existente")

       Dim odt As DataTable
       odt = oCalendario.Cargar()

        Dim odtA As New DataTable
        Dim intMax As Integer = 0

        odtA = oCalendario.GetAnio
        intMax = CInt(odtA.Rows(0).Item("total"))

        Me.cmbAnio.Items.Clear()
        For i As Integer = intMax To intMax + 10
            Me.cmbAnio.Items.Add(i)
        Next
        Me.cmbAnio.Text = CStr(intMax)

        Me.CargarDia()
        odtAux = oAuxCal.Cargar
        odtAux.Columns.Add("nombre_dia", Type.GetType("System.String"))

        RefrescarGrilla()

        '  Me.txtBuscar.Focus()
        Me.lblTitulo.Text = "Calendario"
        Me.Text = "Gestión del Calendario General" & vgNombreFormulario
       Me.CancelButton = Me.btnSalir
       Me.BackColor = Color.Gainsboro
       Me.StartPosition = FormStartPosition.CenterScreen
       Me.MinimizeBox = False
       Me.MaximizeBox = False
       
       'control de acceso y de permisos
       Dim odtUser As New DataTable
       odtUser = oUsuario.GetPermiso(vgNombreUsuario, Me.Name)
        'If odtUser.Rows.Count = 0 OrElse CDbl(odtUser.Rows(0).Item("habilitado")) = 0 Then
        '    Me.btnAgregar.Enabled = False
        '    Me.btnBorrar.Enabled = False
        '    Me.btnModificar.Enabled = False
        'End If
        '   Me.btnAyuda.Visible = False


    End Sub



   Public Sub RefrescarGrilla()
       Dim odt As DataTable

        odt = oCalendario.GetAll_2(CDec(Me.cmbAnio.Text), CInt(Me.lblid_dia.Text))
       Me.dgv1.DataSource = odt
       Me.dgv1.Columns(0).Visible = False
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
    '    odt = oCalendario.Find_2(Me.txtBuscar.Text)
    '    Me.dgv1.DataSource = odt
    'End Sub

   Private Sub dgv1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv1.CurrentCellChanged
       Try
           Me.lblid_pk.Text = CStr(Me.dgv1.Item(0, Me.dgv1.CurrentRow.Index).Value)
       Catch ex As Exception
       End Try
   End Sub

    Private Sub Botones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Dim btnTemp As New Button
        Dim frmDetalle As New frmDetalleCalendario
        btnTemp = CType(sender, Button)
        Try
            Select Case btnTemp.Name
                Case "btnAgregar"
                    BanderaCalendario = 1
                    Me.AddOwnedForm(frmDetalle)
                    oCalendario.Insertar()
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                Case "btnModificar"
                    If Not IsNumeric(Me.lblid_pk.Text) Then
                        Exit Sub
                    End If
                    BanderaCalendario = 2
                    Me.AddOwnedForm(frmDetalle)
                    oCalendario.Modificar(CInt(Me.lblid_pk.Text))
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                    RefrescarGrilla()
                Case "btnBorrar"
                    If Not IsNumeric(Me.lblid_pk.Text) Then
                        Exit Sub
                    End If

                    If MessageBox.Show("Desea Realmente Eliminar el Registro ", "BORRAR", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                    = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If

                    oCalendario.Borrar(CInt(Me.lblid_pk.Text))
                    RefrescarGrilla()
                Case "btnAyuda"
                    'Process.Start(PathAyuda + "frmAbmCalendario.avi")
                Case "btnSalir"
                    Me.Close()
            End Select
            'Me.txtBuscar.Text = ""
            'Me.txtBuscar.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub







    Sub CargarDia()
        Dim odt As New DataTable

        odt = oDia.GetCmb_2
        With Me.cmbDia
            .DataSource = odt
            .DisplayMember = "nombre_dia"
            .ValueMember = "id_dia"
        End With
        If Me.cmbDia.SelectedIndex >= 0 Then
            cmbDia.SelectedIndex = 0
            Me.lblid_Dia.Text = cmbDia.SelectedValue.ToString
        End If
    End Sub

    ''''''''''' NUMEROS  '''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''
    Private Sub Numeros(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        Dim txtTemp As TextBox
        txtTemp = CType(sender, TextBox)

        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If

        If (e.KeyChar.ToString >= "0" And e.KeyChar.ToString <= "9") Or e.KeyChar = vbBack Then
            '  e.Handled = False
        Else
            e.Handled = True
        End If

        Me.RefrescarGrilla()
    End Sub

    Private Sub cmbDia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdia.SelectedIndexChanged
        If Me.cmbDia.SelectedIndex >= 0 Then
            Me.lblid_dia.Text = cmbDia.SelectedValue.ToString
        End If
        If Not IsNumeric(Me.lblid_dia.Text) Then
            Exit Sub
        End If
        Me.RefrescarGrilla()
    End Sub

    Private Sub cmbanio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAnio.SelectedIndexChanged
        If Not IsNumeric(Me.cmbAnio.Text) Then
            Exit Sub
        End If
        Me.RefrescarGrilla()
    End Sub

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    'Handles 
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles cmbdia.KeyDown
        If CDbl(e.KeyValue.ToString) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub





    Dim odtAux As New DataTable
    Dim oAuxCal As New Calendario

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim odr As DataRow



        odr = odtAux.NewRow()

        odr("fecha") = Me.mcFecha.SelectionStart.Date
        odr("id_dia") = Me.lblid_dia.Text
        odr("nombre_dia") = Me.cmbdia.Text

        odtAux.Rows.Add(odr)

        Me.dgvCambio.DataSource = odtAux
        Me.dgvCambio.Columns("id_calendario").Visible = False
        Me.dgvCambio.Columns("id_dia").Visible = False
        Me.dgvCambio.Columns("anio").Visible = False

    End Sub


    Private Sub btnActualizarCalendario_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizarCalendario.Click
        For Each row As DataRow In odtAux.Rows
            oCalendario.UpdateFecha(CDate(row("fecha")).Date)
        Next

        MessageBox.Show("Se ha actualizado el calendario")
        Me.RefrescarGrilla()
    End Sub

    Private Sub btnAgregarTodo_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarTodo.Click
        Dim odt_1 As New DataTable
        Dim odt_2 As New DataTable

        odt_1 = oUsuario.ConsultarTodo
        odt_2 = oCalendario.GetAllAnio(CDec(Me.cmbAnio.Text))

        'recorro todos los empleados
        For Each row_1 As DataRow In odt_1.Rows



            'recorro todo el calendario
            For Each row_2 As DataRow In odt_2.Rows

                If oCalendario_usuario.Exist_2(CInt(row_1("id_usuario")), CDate(row_2("fecha")), CInt(row_2("id_dia")), CDec(row_2("anio"))) Then

                Else
                    With oCalendario_usuario
                        .Cargar()
                        .Insertar()
                        '.anio = CDec(row_2("anio"))
                        '.fecha = CDate(row_2("fecha"))
                        '.id_dia = CInt(row_2("id_dia"))
                        .id_usuario = CInt(row_1("id_usuario"))
                        .Guardar()
                    End With
                End If


            Next
        Next

        MessageBox.Show("Se han generado los calendarios")
    End Sub


End Class
