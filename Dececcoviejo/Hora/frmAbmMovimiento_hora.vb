Public Class frmAbmMovimiento_hora

   Dim odt As DataTable
   Dim BanderaConsultaMovimiento_hora As Integer

   Private Sub frmAbmMovimiento_hora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnAgregar, "Incorporar Nuevo Movimiento_hora")
       Me.ttGeneral.SetToolTip(Me.btnBorrar, "Borrar un  Movimiento_hora Existente")
       Me.ttGeneral.SetToolTip(Me.btnModificar, "Modificar  un Movimiento_hora Existente")
       'Me.ttGeneral.SetToolTip(Me.btnConsultar, "Consultar Datos del  Movimiento_hora Existente")

       Dim odt As DataTable
        odt = oMovimiento_hora.Cargar()
       
        RefrescarGrilla()
       
        'Me.txtBuscar.Focus()
        Me.lblTitulo.Text = "Movimiento_hora"
        Me.Text = "Movimiento_hora" & vgNombreFormulario
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

        Me.CargarEmpleado()
    End Sub

    Sub CompletarMovimientoResumen()
        Dim odt As New DataTable
        odt = oMovimiento_hora.SetResumenEmpleado(Me.dtpInicio.Value.Date, Me.dtpFin.Value.Date, Me.chkExtra.Checked, CInt(Me.lblid_empleado.Text))

        Dim odt_empleado As New DataTable
        odt_empleado = oUsuario.GetOne(CInt(Me.lblid_empleado.Text))

        For Each rowMov As DataRow In odt.Rows
            If CInt(odt_empleado.Rows(0).Item("legajo").ToString()) = CInt(rowMov("Legajo").ToString()) Then
                Me.txtAccidente.Text = rowMov("Acci").ToString()
                Me.txtEnfermedad.Text = rowMov("Enfe").ToString()
                Me.txtEspecial.Text = rowMov("Espe").ToString()
                Me.txtFeriados.Text = rowMov("Feri").ToString()
                Me.txtNocturnas.Text = rowMov("Noct").ToString()
                Me.txtNormal_1.Text = rowMov("H_Norm").ToString()
                Me.txt50_1.Text = rowMov("H_50%").ToString()
                Me.txt100_1.Text = rowMov("H_100%").ToString()
                Me.txtTotal.Text = CStr(CDec(rowMov("H_Norm")) + CDec(rowMov("Noct")))
                Exit Sub
            End If
        Next
        Me.txtAccidente.Text = "0"
        Me.txtEnfermedad.Text = "0"
        Me.txtEspecial.Text = "0"
        Me.txtFeriados.Text = "0"
        Me.txtNocturnas.Text = "0"
        Me.txtNormal_1.Text = "0"
        Me.txt50_1.Text = "0"
        Me.txt100_1.Text = "0"
        Me.txtTotal.Text = "0"

    End Sub

    Public Sub RefrescarGrilla()
        Dim odt As New DataTable
        Dim odtControl As New DataTable
        Dim odtDetalle As New DataTable

        odt = oMovimiento_hora.GetAll_3(CInt(Me.lblid_empleado.Text), Me.dtpInicio.Value.Date, Me.dtpFin.Value.Date)
        Me.dgv1.DataSource = odt
        Me.dgv1.Columns(0).Visible = False
        Me.dgv1.Columns(1).Visible = False

        Dim odt_2 As New DataTable
        odt_2 = oMovimiento_hora.GetAll_6(CInt(Me.lblid_empleado.Text), Me.dtpInicio.Value.Date, Me.dtpFin.Value.Date, Me.chkExtra.Checked)
        Me.dgv2.DataSource = odt_2
        Me.dgv2.Columns(0).Visible = False
        '  Me.dgv2.Columns(1).Visible = False

        Dim decTotHor As Decimal = 0
        For Each row As DataRow In odt_2.Rows
            decTotHor = decTotHor + CDec(row("horas"))
        Next
        Me.txtTotalAgrupado.Text = FormatNumber(decTotHor)

        Try
            Me.CompletarMovimientoResumen()
        Catch ex As Exception

        End Try


        Dim decNormal As Decimal = 0
        Dim dec50 As Decimal = 0
        Dim dec100 As Decimal = 0
        Dim decTotal As Decimal = 0
        Dim decMinuto As Decimal = 0
        Dim dtInicio As DateTime
        Dim dtFin As DateTime

        Dim IDMov As Integer = 0



        odtControl = oMovimiento_hora.GetAllControl(CInt(Me.lblid_empleado.Text), Me.dtpInicio.Value.Date, Me.dtpFin.Value.Date)

        For Each row As DataRow In odtControl.Rows
            IDMov = CInt(row("id_movimiento_hora"))
            odtDetalle = oCuerpo_movimiento_hora.GetAllMovimientoControl(IDMov, Me.chkExtra.Checked)

            If odtDetalle.Rows.Count > 0 Then

                decMinuto = 0
                decTotal = 0
                For Each rowCuerpo As DataRow In odtDetalle.Rows
                    dtInicio = CDate(rowCuerpo("entrada"))
                    dtFin = CDate(rowCuerpo("salida"))
                    'calcula la cantidad de horas trabajadas
                    decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtFin)
                    decTotal = decTotal + CDec(FormatNumber(decMinuto / 60, 1))
                Next

                Select Case row("id_dia").ToString
                    'lunes a jueves
                    Case "1"
                        If decTotal > 9 Then
                            decNormal = decNormal + 9
                            dec50 = dec50 + decTotal - 9
                        Else
                            decNormal = decNormal + decTotal
                        End If
                        'viernes
                    Case "2"
                        If decTotal > 8 Then
                            decNormal = decNormal + 8
                            dec50 = dec50 + decTotal - 8
                        Else
                            decNormal = decNormal + decTotal
                        End If
                        'nocturna
                    Case "3"
                        If decTotal > 9 Then
                            decNormal = decNormal + 9
                            dec50 = dec50 + decTotal - 9
                        Else
                            decNormal = decNormal + decTotal
                        End If

                        'sabados
                    Case "4"
                        decMinuto = 0
                        decTotal = 0
                        For Each rowCuerpo As DataRow In odtDetalle.Rows
                            dtInicio = CDate(rowCuerpo("entrada"))
                            dtFin = CDate(rowCuerpo("salida"))

                            Dim dtAuxI As DateTime = New DateTime(dtInicio.Year, dtInicio.Month, dtInicio.Day, 13, 0, 0)

                            If dtInicio < dtAuxI And dtFin <= dtAuxI Then
                                'horas 50
                                decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtFin)
                                dec50 = dec50 + CDec(FormatNumber(decMinuto / 60, 1))
                            ElseIf dtInicio < dtAuxI And dtFin > dtAuxI Then
                                'horas 50
                                decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtAuxI)
                                dec50 = dec50 + CDec(FormatNumber(decMinuto / 60, 1))
                                'horas 100
                                decMinuto = DateDiff(DateInterval.Minute, dtAuxI, dtFin)
                                dec100 = dec100 + CDec(FormatNumber(decMinuto / 60, 1))
                            ElseIf dtInicio > dtAuxI And dtFin > dtAuxI Then
                                'horas 100
                                decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtFin)
                                dec100 = dec100 + CDec(FormatNumber(decMinuto / 60, 1))
                            End If
                        Next

                        'domingos
                    Case "5"
                        dec100 = dec100 + decTotal
                        'enfermedad
                    Case "6"
                        decNormal = decNormal + 8
                        'accidente
                    Case "7"
                        decNormal = decNormal + 8
                        'viajes
                    Case "8"

                        'feriado trabajado
                    Case "15"
                        If decTotal > 8 Then
                            decNormal = decNormal + 8
                            dec100 = dec100 + decTotal - 8
                        Else
                            decNormal = decNormal + 8
                        End If

                        'feriado
                    Case "10"
                        decNormal = decNormal + 8
                        'especial
                    Case "11"
                        decNormal = decNormal + 8
                        'nocturna viernes
                    Case "16"
                        If decTotal > 8 Then
                            decNormal = decNormal + 8
                            dec50 = dec50 + decTotal - 8
                        Else
                            decNormal = decNormal + decTotal
                        End If
                        'nocturna sabado
                    Case "17"
                        decMinuto = 0
                        decTotal = 0
                        For Each rowCuerpo As DataRow In odtDetalle.Rows
                            dtInicio = CDate(rowCuerpo("entrada"))
                            dtFin = CDate(rowCuerpo("salida"))

                            Dim dtAuxI As DateTime = New DateTime(dtInicio.Year, dtInicio.Month, dtInicio.Day, 13, 0, 0)

                            If dtInicio < dtAuxI And dtFin < dtAuxI Then
                                'horas 50
                                decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtFin)
                                dec50 = dec50 + CDec(FormatNumber(decMinuto / 60, 1))
                            ElseIf dtInicio < dtAuxI And dtFin > dtAuxI Then
                                'horas 50
                                decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtAuxI)
                                dec50 = dec50 + CDec(FormatNumber(decMinuto / 60, 1))
                                'horas 100
                                decMinuto = DateDiff(DateInterval.Minute, dtAuxI, dtFin)
                                dec100 = dec100 + CDec(FormatNumber(decMinuto / 60, 1))
                            ElseIf dtInicio > dtAuxI And dtFin > dtAuxI Then
                                'horas 100
                                decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtFin)
                                dec100 = dec100 + CDec(FormatNumber(decMinuto / 60, 1))
                            End If
                        Next
                        'nocturna domingo
                    Case "18"
                        dec100 = dec100 + decTotal
                End Select

            End If

        Next

        Me.txtNormal.Text = decNormal.ToString
        Me.txt50.Text = dec50.ToString
        Me.txt100.Text = dec100.ToString


    End Sub


    Sub CargarEmpleado()
        Dim odt As New DataTable

        odt = oUsuario.GetCmb_3
        With Me.cmbempleado
            .DataSource = odt
            .DisplayMember = "nombre_usuario"
            .ValueMember = "id_usuario"
        End With
        If Me.cmbempleado.SelectedIndex >= 0 Then
            cmbempleado.SelectedIndex = 0
            Me.lblid_empleado.Text = cmbempleado.SelectedValue.ToString
        End If
    End Sub

    Private Sub cmbEmpleado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbempleado.SelectedIndexChanged
        If Me.cmbempleado.SelectedIndex >= 0 Then
            Me.lblid_empleado.Text = cmbempleado.SelectedValue.ToString
        End If
        If Not IsNumeric(Me.lblid_empleado.Text) Then
            Exit Sub
        End If
        Me.RefrescarGrilla()

    End Sub

    Private Sub btnBuscaEmpleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaempleado.Click
        'modificado frmAbmEmpleado
        Dim frmTemporal As New frmAbmUsuario
        frmTemporal.ShowDialog()
        Me.CargarEmpleado()
        Me.cmbempleado.Focus()
        Me.cmbempleado.Text = ""
        Me.lblid_empleado.Text = "0"
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
    '    odt = oMovimiento_hora.Buscar(Me.txtBuscar.Text)
    '    Me.dgv1.DataSource = odt
    'End Sub

    Private Sub dgv1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv1.CurrentCellChanged
        Try
            Me.lblid_pk.Text = CStr(Me.dgv1.Item(0, Me.dgv1.CurrentRow.Index).Value)

        Catch ex As Exception
        End Try
    End Sub

    Private Sub Botones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click, btnAyuda.Click, btnBorrar.Click, btnModificar.Click, btnSalir.Click
        Dim btnTemp As New Button
        Dim frmDetalle As New frmDetalleMovimiento_hora_2
        btnTemp = CType(sender, Button)
        Try
            Select Case btnTemp.Name
                Case "btnAgregar"
                    If Me.lblid_empleado.Text = "" Then
                        MessageBox.Show("Sr. Usuario debe Seleccionar un Empleado de la Lista")
                        Exit Sub
                    End If
                    BanderaMovimiento_hora = 1
                    BanderaCuerpo_movimiento_hora = 1
                    Me.AddOwnedForm(frmDetalle)
                    oMovimiento_hora.Insertar()
                    oCuerpo_movimiento_hora.Cargar()
                    oCuerpo_movimiento_hora.Insertar()
                    frmDetalle.CargarCombos()
                    frmDetalle.CargarCombosCuerpo()
                    frmDetalle.ShowDialog()
                Case "btnModificar"
                    If Not IsNumeric(Me.lblid_pk.Text) Then
                        Exit Sub
                    End If
                    BanderaMovimiento_hora = 2
                    'BanderaCuerpo_movimiento_hora = 2 modificado
                    Me.AddOwnedForm(frmDetalle)
                    oMovimiento_hora.Modificar(CInt(Me.lblid_pk.Text))
                    frmDetalle.CargarCombos()
                    frmDetalle.CargarCombosCuerpo()
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

                    oCuerpo_movimiento_hora.DeleteMovimiento_hora(CInt(Me.lblid_pk.Text), Me.chkExtra.Checked)

                    oMovimiento_hora.Borrar(CInt(Me.lblid_pk.Text))
                    RefrescarGrilla()
                Case "btnAyuda"
                    'Process.Start(PathAyuda + "frmAbmMovimiento_hora.avi")
                Case "btnSalir"
                    Me.Close()
            End Select
            'Me.txtBuscar.Text = ""
            'Me.txtBuscar.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dtpInicio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpInicio.ValueChanged
        Me.RefrescarGrilla()
    End Sub

    Private Sub dtpFin_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFin.ValueChanged
        Me.RefrescarGrilla()
    End Sub


    'tabulacion combos
    Private Sub TabulacionCombosCuerpo(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles cmbempleado.KeyDown, dtpInicio.KeyDown, dtpFin.KeyDown
        If CDbl(e.KeyValue.ToString) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub chkExtra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkExtra.CheckedChanged
        Me.RefrescarGrilla()
    End Sub

   
 
End Class
