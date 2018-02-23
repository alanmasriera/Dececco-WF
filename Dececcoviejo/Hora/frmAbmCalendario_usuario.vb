Public Class frmAbmCalendario_usuario

    Dim odt As DataTable
    Dim BanderaConsultaCalendario_usuario As Integer

    Dim odtAux As New DataTable
    Dim oAuxCal As New Calendario

    Private Sub frmAbmCalendario_usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.ttGeneral.SetToolTip(Me.btnAgregar, "Incorporar Nuevo Calendario_usuario")
        'Me.ttGeneral.SetToolTip(Me.btnBorrar, "Borrar un  Calendario_usuario Existente")
        'Me.ttGeneral.SetToolTip(Me.btnModificar, "Modificar  un Calendario_usuario Existente")
        'Me.ttGeneral.SetToolTip(Me.btnConsultar, "Consultar Datos del  Calendario_usuario Existente")

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

        Me.cargarCombos()
        odtAux = oAuxCal.Cargar
        odtAux.Columns.Add("nombre_dia", Type.GetType("System.String"))
        RefrescarGrilla()

        Me.lblTitulo.Text = "Calendario_usuario"
        Me.Text = "Calendario_usuario" & vgNombreFormulario
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False

        Me.Consultar()
    End Sub

    Sub CargarDia()
        Dim odt As New DataTable

        odt = oDia.GetCmb
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

    Sub CargarUsuario()
        Dim odt As New DataTable

        odt = oUsuario.GetCmb_2
        With Me.cmbUsuario
            .DataSource = odt
            .DisplayMember = "nombre_Usuario"
            .ValueMember = "id_usuario"
        End With
        If Me.cmbUsuario.SelectedIndex >= 0 Then
            cmbdia.SelectedIndex = 0
            Me.lblid_usuario.Text = cmbUsuario.SelectedValue.ToString
        End If
    End Sub

    Sub CargarCombos()
        Me.CargarDia()
        Me.CargarUsuario()

    End Sub


    Public Sub RefrescarGrilla()
        Dim odt As DataTable

        odt = oCalendario_usuario.GetAll_3(CDec(Me.cmbAnio.Text), CInt(Me.lblid_dia.Text), CInt(Me.lblid_usuario.Text))
        Me.dgv1.DataSource = odt
        Me.dgv1.Columns(0).Visible = False
    End Sub

    Structure regTemp
        Dim indice As Integer
        Dim Id_usuario As Integer
        Dim Nombre_usuario As String
    End Structure

    Dim reg() As regTemp
    Sub Consultar()
        Dim odt As New DataTable
        odt = oUsuario.GetAll_2()

        ReDim reg(odt.Rows.Count - 1)

        Dim indice As Integer = 0

        Me.CheckedListBox1.Items.Clear()

        For Each row As DataRow In odt.Rows
            Me.CheckedListBox1.Items.Add(row("Nombre_usuario").ToString.Trim)
            reg(indice).indice = indice
            reg(indice).Id_usuario = CInt(row("Id_usuario"))
            reg(indice).Nombre_usuario = CStr(row("Nombre_usuario"))
            indice = indice + 1
        Next
    End Sub

    Private Sub dgv1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv1.CurrentCellChanged
        Try
            Me.lblid_pk.Text = CStr(Me.dgv1.Item(0, Me.dgv1.CurrentRow.Index).Value)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Botones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim btnTemp As New Button
        Dim frmDetalle As New frmDetalleCalendario_usuario
        btnTemp = CType(sender, Button)
        Try
            Select Case btnTemp.Name
                Case "btnAgregar"
                    BanderaCalendario_usuario = 1
                    Me.AddOwnedForm(frmDetalle)
                    oCalendario_usuario.Insertar()
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                Case "btnModificar"
                    If Not IsNumeric(Me.lblid_pk.Text) Then
                        Exit Sub
                    End If
                    BanderaCalendario_usuario = 2
                    Me.AddOwnedForm(frmDetalle)
                    oCalendario_usuario.Modificar(CInt(Me.lblid_pk.Text))
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

                    oCalendario_usuario.Borrar(CInt(Me.lblid_pk.Text))
                    RefrescarGrilla()
                Case "btnAyuda"
                    'Process.Start(PathAyuda + "frmAbmCalendario_usuario.avi")
                Case "btnSalir"
                    Me.Close()
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

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
        Dim contador As Integer = 0
        Dim i As Integer = 0
        Dim registro As regTemp
        Dim a As Integer
        Dim j As Integer

        For Each row As DataRow In odtAux.Rows
            '  oCalendario.UpdateFecha(CDate(row("fecha")).Date, CInt(row("id_dia")))

            Me.Cursor = Cursors.WaitCursor

            For i = 0 To Me.CheckedListBox1.CheckedItems.Count - 1
                a = Me.CheckedListBox1.CheckedIndices(i)

                j = 0
                For Each registro In reg
                    If reg(j).indice = a Then

                        contador += 1
                        'oUsuario.Exist()                

                        oCalendario_usuario.UpdateFechaUsuario(CDate(row("fecha")).Date, CInt(row("id_dia")), reg(j).Id_usuario)
                    End If
                    j = j + 1
                Next
            Next
        Next



        Me.Cursor = Cursors.Default
        'CType(Me.Owner, frmAbmAsiento_modelo).RefrescarGrilla()


        MessageBox.Show("Se ha actualizado el calendario")
        Me.RefrescarGrilla()
    End Sub

    Private Sub btnAgregarTodo_Click(sender As System.Object, e As System.EventArgs)
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

    Private Sub cmbDia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdia.SelectedIndexChanged
        If Me.cmbDia.SelectedIndex >= 0 Then
            Me.lblid_dia.Text = cmbDia.SelectedValue.ToString
        End If
        If Not IsNumeric(Me.lblid_dia.Text) Then
            Exit Sub
        End If
        Me.RefrescarGrilla()
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
   Handles cmbdia.KeyDown, cmbAnio.KeyDown, cmbUsuario.KeyDown
        If CDbl(e.KeyValue.ToString) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub cmbanio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAnio.SelectedIndexChanged
        If Not IsNumeric(Me.cmbAnio.Text) Then
            Exit Sub
        End If
        Me.RefrescarGrilla()
    End Sub

    Private Sub cmbUsuario_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cmbUsuario.SelectedIndexChanged

        If Me.cmbUsuario.SelectedIndex >= 0 Then
            Me.lblid_usuario.Text = cmbUsuario.SelectedValue.ToString
        End If
        If Not IsNumeric(Me.lblid_usuario.Text) Then
            Exit Sub
        End If
        Me.RefrescarGrilla()
    End Sub


    Private Sub btnLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles btnLimpiar.Click
        odtAux.Clear()
        dgvCambio.DataSource = odtAux
    End Sub
End Class
