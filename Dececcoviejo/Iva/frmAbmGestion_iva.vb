Imports System.Globalization

Public Class frmAbmGestion_iva

    Dim odt As DataTable
    Dim BanderaConsultaCompra As Integer

    Private Sub frmAbmGestion_iva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttAgregar.SetToolTip(Me.btnAgregar, "Incorporar Nuevo Compra")
        Me.ttBorrar.SetToolTip(Me.btnBorrar, "Borrar un  Compra Existente")
        Me.ttModificar.SetToolTip(Me.btnModificar, "Modificar  un Compra Existente")

        'cultura regional
        Dim oldDecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        Dim forceDotCulture As CultureInfo
        forceDotCulture = CType(Application.CurrentCulture.Clone(), CultureInfo)
        forceDotCulture.NumberFormat.NumberDecimalSeparator = ","
        forceDotCulture.NumberFormat.NumberGroupSeparator = "."
        forceDotCulture.NumberFormat.CurrencyDecimalSeparator = ","
        forceDotCulture.NumberFormat.CurrencyGroupSeparator = "."
        forceDotCulture.NumberFormat.CurrencySymbol = "$"
        Application.CurrentCulture = forceDotCulture

        oAsignacion_iva.Cargar()
        oPago_iva.Cargar()
        oSaldo_iva.Cargar()

        'Dim odt4 As New DataTable
        'odt4 = oMovimiento_iva.Consultar

        Me.Cargariva()
        Me.CargarEmpresa()

        'seteo los valores en 1 porque es una empresa
        Me.lblid_empresa.Text = CStr(1)
        Me.lblid_iva.Text = CStr(1)


        Me.RefrescarGrillaAsignacion()
        Me.RefrescarGrillaPago_iva()
        'Me.RefrescarGrillaVariable()

        Me.lblTitulo.Text = "Gestión de IVA"
        Me.Text = "Gestión de ivas" & vgNombreFormulario
    End Sub

    Sub Cargariva()
        Dim odt As New DataTable

        odt = oiva.GetCmb
        With Me.cmbiva
            .DataSource = odt
            .DisplayMember = "nombre_iva"
            .ValueMember = "id_iva"
        End With
        If Me.cmbiva.SelectedIndex >= 0 Then
            cmbiva.SelectedIndex = 0
            Me.lblid_iva.Text = cmbiva.SelectedValue.ToString
        End If
    End Sub

    Sub CargarEmpresa()
        Dim odt As New DataTable

        odt = oEmpresa.GetCmb
        With Me.cmbEmpresa
            .DataSource = odt
            .DisplayMember = "nombre_Empresa"
            .ValueMember = "id_Empresa"
        End With
        If Me.cmbEmpresa.SelectedIndex >= 0 Then
            cmbEmpresa.SelectedIndex = 0
            Me.lblid_empresa.Text = cmbEmpresa.SelectedValue.ToString
        End If
    End Sub

    Public Sub RefrescarGrillaAsignacion()

        Dim odtAsignacion As DataTable
        odtAsignacion = oAsignacion_iva.GetAll_2(CInt(Me.lblid_empresa.Text), CInt(Me.lblid_iva.Text), Me.dtpPeriodo.Value.Date)

        Me.dgvAsignaicon.DataSource = odtAsignacion
        Me.dgvAsignaicon.Columns(0).Visible = False
        Me.dgvAsignaicon.Columns("IMPORTE").DefaultCellStyle.Format = "c"
        Me.dgvAsignaicon.Columns("IMPORTE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '   Me.dgv1.Columns("TOTAL").DefaultCellStyle.Format = "c"
        '   Me.dgv1.Columns("TOTAL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


        'i = Me.dgv1.Rows.Count
        'If i > 1 Then Me.dgv1.CurrentCell = Me.dgv1(1, i - 1)

        Dim odt As New DataTable

        oIva_compra_temp.SetIva(Me.dtpPeriodo.Value.Date, Me.txtNumero_iva_compra.Text)

        odt = oIva_compra_temp.ConsultarTodo
        Me.dgv1.DataSource = odt
        Me.dgv1.Columns(0).Visible = False

        Dim decTotalIVACompra As Decimal = 0
        Dim decIVACompra As Decimal = 0
        Dim decImporteGrabadoCompra As Decimal = 0
        For Each row As DataRow In odt.Rows
            decImporteGrabadoCompra = decImporteGrabadoCompra + CDec(row.Item("imp_gravado"))
            decIVACompra = decIVACompra + CDec(row.Item("iva"))
            decTotalIVACompra = decTotalIVACompra + CDec(row.Item("totals"))
        Next

        Me.txtImporteGrabadoCompra.Text = CStr(decImporteGrabadoCompra)
        Me.txtIvaCompra.Text = CStr(decIVACompra)
        Me.txtTotalCompra.Text = CStr(decTotalIVACompra)

        Dim odt_2 As New DataTable
        odt_2 = oIva_compra.GetOneDate(Me.dtpPeriodo.Value.Date)
        If odt_2.Rows.Count <= 0 Then
            Me.lblEstado_libro.Text = "ABIERTO"
            Me.lblEstado_libro.BackColor = Color.Lime
        Else

            Me.lblEstado_libro.Text = "CERRADO"
            Me.lblEstado_libro.BackColor = Color.Red
        End If


    End Sub

    Public Sub RefrescarGrillaPago_iva()
        'Dim i As Integer = 0
        'Dim odt2 As DataTable
        'parametro_id_iva = 0
        ''  parametro_fecha_inicio = ""
        'odt2 = oPago_iva.GetAll_2(CInt(Me.lblid_empresa.Text), CInt(Me.lblid_iva.Text), Me.dtpPeriodo.Value.Date)
        'parametro_id_iva = CInt(Me.lblid_iva.Text.Trim)
        'parametro_fecha_inicio = Me.dtpPeriodo.Value
        'Me.dgv2.DataSource = odt2
        'Me.dgv2.Columns(0).Visible = False
        'Me.dgv2.Columns("IMPORTE").DefaultCellStyle.Format = "c"
        'Me.dgv2.Columns("IMPORTE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        'i = Me.dgv2.Rows.Count
        'If i > 1 Then Me.dgv2.CurrentCell = Me.dgv2(1, i - 1)

        Dim odt As New DataTable

        oIva_venta_temp.SetIva(Me.dtpPeriodo.Value.Date, Me.txtNumero_iva_venta.Text)

        odt = oIva_venta_temp.ConsultarTodo
        Me.dgv2.DataSource = odt
        Me.dgv2.Columns(0).Visible = False

        Dim decTotalIVAVenta As Decimal = 0
        Dim decIVAVenta As Decimal = 0
        Dim decImporteGrabadoVenta As Decimal = 0
        For Each row As DataRow In odt.Rows
            decImporteGrabadoVenta = decImporteGrabadoVenta + CDec(row.Item("imp_gravado"))
            decIVAVenta = decIVAVenta + CDec(row.Item("iva"))
            decTotalIVAVenta = decTotalIVAVenta + CDec(row.Item("totals"))
        Next

        Me.txtImporteGrabadoVenta.Text = CStr(decImporteGrabadoVenta)
        Me.txtIvaVenta.Text = CStr(decIVAVenta)
        Me.txtTotalVenta.Text = CStr(decTotalIVAVenta)

        Dim odt_2 As New DataTable
        odt_2 = oIva_venta.GetOneDate(Me.dtpPeriodo.Value.Date)
        If odt_2.Rows.Count <= 0 Then
            Me.lblEstado_libro_2.Text = "ABIERTO"
            Me.lblEstado_libro_2.BackColor = Color.Lime
        Else

            Me.lblEstado_libro_2.Text = "CERRADO"
            Me.lblEstado_libro_2.BackColor = Color.Red
        End If

    End Sub

    Public Sub RefrescarResumen()
        Dim odtResumen As New DataTable()
        Dim i As Integer
        Dim s As Decimal
        Dim j As Integer
        Dim FechaOld As DateTime
        Try
            Me.lblSaldoActual.Text = ""

            'seteo la fecha anterior y traigo el saldo anterior
            FechaOld = DateAdd(DateInterval.Month, -1, Me.dtpPeriodo.Value)
            parametro_fecha_old = FechaOld
            Me.lblSaldoAnterior.Text = FormatCurrency(oSaldo_iva.GetOldSaldo(CInt(Me.lblid_empresa.Text), CInt(Me.lblid_iva.Text), FechaOld))

            'genera el resumen de cuenta
            odtResumen = oResumen_iva.SetResumen(CInt(Me.lblid_empresa.Text), CInt(Me.lblid_iva.Text), Me.dtpPeriodo.Value.Date)
            parametro_id_iva = CInt(Me.lblid_iva.Text)
            parametro_id_iva_old = CInt(Me.lblid_iva.Text)
            parametro_fecha_inicio = Me.dtpPeriodo.Value.Date
            parametro_nom_iva = Me.cmbiva.Text

            'calcula el saldo parcial atraves de la grilla
            j = odtResumen.Rows.Count - 1
            For i = 0 To odtResumen.Rows.Count - 1
                s = CDec(odtResumen.Rows(i).Item("saldo").ToString)
                If i = 0 Then
                    s = CDec(s) + CDec(Me.lblSaldoAnterior.Text)
                Else
                    s = s + CDec(odtResumen.Rows(i - 1).Item("saldo").ToString)
                End If
                odtResumen.Rows(i).Item("saldo") = s
            Next
            If j < 0 Then
                Me.dgv9.DataSource = odtResumen
                Me.dgv9.Columns(0).Visible = False

                'bug de los saldos
                Me.lblTotalGrilla.Text = Me.lblSaldoAnterior.Text

                Exit Sub
            End If

            'actualiza el datatable
            oResumen_iva.Update()
            oResumen_iva.Guardar()

            'muestra el dt en la grilla
            Me.dgv9.DataSource = odtResumen
            Me.dgv9.Columns(0).Visible = False
            Me.dgv9.Columns("DEBE").DefaultCellStyle.Format = "c"
            Me.dgv9.Columns("DEBE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.dgv9.Columns("HABER").DefaultCellStyle.Format = "c"
            Me.dgv9.Columns("HABER").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.dgv9.Columns("SALDO").DefaultCellStyle.Format = "c"
            Me.dgv9.Columns("SALDO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            'agrega el saldo al total de la grilla
            Me.lblTotalGrilla.Text = CStr(s)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub RefrescarSaldo()
        'traigo los valores del ultimo saldo
        Dim odtSaldoTemp As DataTable
        odtSaldoTemp = oSaldo_iva.GetMaxSaldo(CInt(Me.lblid_empresa.Text), CInt(Me.lblid_iva.Text))

        Dim FechaMax As DateTime = #1/1/2000#
        Dim decSaldoOld As Decimal = 0

        'controlo si el dt esta vacio
        If odtSaldoTemp.Rows.Count > 0 Then
            'obtengo la fecha mayor
            FechaMax = CDate(odtSaldoTemp.Rows(0).Item("fecha_Saldo_iva"))

            'obtengo el ultimo saldo
            decSaldoOld = CDec(odtSaldoTemp.Rows(0).Item("Saldo_iva"))
        End If

        '''''ERROR EN FECHA 12''''''
        'seteo la fecha con 01-mm-yy para calcular a partir del ultimo saldo guardado
        If FechaMax.Month = 12 Then
            FechaMax = CDate("01-01-" & FechaMax.Year + 1)
        Else
            FechaMax = CDate("01-" & FechaMax.Month + 1 & "-" & FechaMax.Year)
        End If


        'calculo el saldo actual = ultimo saldo + resto a today
        Dim decSaldo As Decimal = 0
        decSaldo = oSaldo_iva.GetSaldo(CInt(Me.lblid_empresa.Text), CInt(Me.lblid_iva.Text), FechaMax) + decSaldoOld

        'lo pongo en el label
        Me.lblSaldoActual.Text = FormatCurrency(decSaldo)
    End Sub

    Private Sub dgvAsignacion_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvAsignaicon.CurrentCellChanged
        Me.lblid_asignacion.Text = "0"
        Try
            Me.lblid_asignacion.Text = CStr(Me.dgvAsignaicon.Item(0, Me.dgvAsignaicon.CurrentRow.Index).Value)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgv1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv1.CurrentCellChanged
        Try
            Me.lblid_pk1.Text = CStr(Me.dgv1.Item(0, Me.dgv1.CurrentRow.Index).Value)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgv2_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv2.CurrentCellChanged
        Try
            Me.lblid_pk2.Text = CStr(Me.dgv2.Item(0, Me.dgv2.CurrentRow.Index).Value)
        Catch ex As Exception
        End Try
    End Sub

    'coloca el rojo en la celdas negativas
    Private Sub dataGridView8_CellFormatting(ByVal sender As Object, _
    ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) _
        Handles dgv9.CellFormatting
        If dgv9.Columns(e.ColumnIndex).Name.Equals("SALDO") Then
            'Dim intValue As Int32
            If CInt(e.Value) < 0 Then
                'if Int32.TryParse((String)e.Value, out intValue) && 
                '   (intValue < 0))
                e.CellStyle.ForeColor = Color.Red
                e.CellStyle.SelectionBackColor = Color.DarkRed
            End If
        End If
    End Sub

    Private Sub Botones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click, btnBorrar.Click, btnModificar.Click, btnSalir.Click
        Dim btnTemp As New Button
        Dim frmDetalle As New frmDetalleAsignacion_iva
        Dim frmDetalle2 As New frmDetallePago_iva

        btnTemp = CType(sender, Button)
        Try
            If Me.tcCompra.SelectedIndex = 0 Then 'asignacion

                BtnImprimir.Visible = True
                Select Case btnTemp.Name
                    Case "btnAgregar"
                        BanderaAsignacion_iva = 1
                        Me.AddOwnedForm(frmDetalle)
                        oAsignacion_iva.Insertar()
                        frmDetalle.CargarCombos()
                        frmDetalle.ShowDialog()
                    Case "btnModificar"
                        If Not IsNumeric(Me.lblid_asignacion.Text) Then
                            Exit Sub
                        End If
                        BanderaAsignacion_iva = 2
                        Me.AddOwnedForm(frmDetalle)
                        oAsignacion_iva.Modificar(CInt(Me.lblid_asignacion.Text))
                        frmDetalle.CargarCombos()
                        frmDetalle.ShowDialog()
                        RefrescarGrillaAsignacion()
                    Case "btnBorrar"
                        If Not IsNumeric(Me.lblid_asignacion.Text) Then
                            Exit Sub
                        End If

                        oAsignacion_iva.Borrar(CInt(Me.lblid_asignacion.Text))
                        RefrescarGrillaAsignacion()
                    Case "btnAyuda"
                        'System.Diagnostics.Process.Start(PathAyuda + "FrmAbmCompra.htm")
                    Case "btnSalir"
                        Me.Close()
                End Select
            ElseIf Me.tcCompra.SelectedIndex = 1 Then 'pagos
                Select Case btnTemp.Name
                    Case "btnAgregar"
                        BanderaPago_iva = 1
                        Me.AddOwnedForm(frmDetalle2)
                        oPago_iva.Insertar()
                        frmDetalle2.CargarCombos()
                        frmDetalle2.ShowDialog()
                    Case "btnModificar"
                        If Not IsNumeric(Me.lblid_pk2.Text) Then
                            Exit Sub
                        End If
                        BanderaPago_iva = 2
                        Me.AddOwnedForm(frmDetalle2)
                        oPago_iva.Modificar(CInt(Me.lblid_pk2.Text))
                        frmDetalle2.CargarCombos()
                        frmDetalle2.ShowDialog()
                        RefrescarGrillaPago_iva()
                    Case "btnBorrar"
                        If Not IsNumeric(Me.lblid_pk2.Text) Then
                            Exit Sub
                        End If
                        If CDbl(Me.lblid_pk2.Text) <= 1 Then
                            MessageBox.Show("No se Puede Borrar el Registro")
                            Exit Sub
                        End If
                        oPago_iva.Borrar(CInt(Me.lblid_pk2.Text))
                        RefrescarGrillaPago_iva()
                    Case "btnAyuda"
                        'System.Diagnostics.Process.Start(PathAyuda + "FrmAbmPago_iva.htm")
                    Case "btnSalir"
                        Me.Close()
                End Select
            ElseIf Me.tcCompra.SelectedIndex = 2 Or Me.tcCompra.SelectedIndex = 3 Then 'resumen compra
                BtnImprimir.Visible = False

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub RefrescarCambioCombo()
        If Not IsNumeric(Me.lblid_iva.Text) Or Not IsNumeric(Me.lblid_empresa.Text) Then
            Exit Sub
        End If
        Me.RefrescarGrillaAsignacion()
        Me.RefrescarGrillaPago_iva()
        'Me.RefrescarGrillaVariable()
        Me.RefrescarResumen()
        Me.RefrescarSaldo()
        'Me.ControlarEnabled()
    End Sub

    Private Sub cmbiva_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbiva.SelectedIndexChanged
        If Me.cmbiva.SelectedIndex >= 0 Then
            Me.lblid_iva.Text = cmbiva.SelectedValue.ToString
        End If
        Me.RefrescarCambioCombo()
    End Sub

    Private Sub btnBuscaiva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaiva.Click
        Dim frmTemporal As New frmAbmiva
        frmTemporal.ShowDialog()
        Me.Cargariva()
        Me.cmbiva.Focus()
        Me.cmbiva.Text = ""
        Me.lblid_iva.Text = "0"
    End Sub

    Private Sub cmbEmpresa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEmpresa.SelectedIndexChanged
        If Me.cmbEmpresa.SelectedIndex >= 0 Then
            Me.lblid_empresa.Text = cmbEmpresa.SelectedValue.ToString
        End If
        Me.RefrescarCambioCombo()
    End Sub

    Private Sub btnBuscaEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaEmpresa.Click
        Dim frmTemporal As New frmAbmEmpresa
        frmTemporal.ShowDialog()
        Me.CargarEmpresa()
        Me.cmbEmpresa.Focus()
        Me.cmbEmpresa.Text = ""
        Me.lblid_empresa.Text = "0"
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles cmbiva.KeyDown, cmbEmpresa.KeyDown
        Dim dtpTemp As New Object
        dtpTemp = sender
        If e.KeyValue = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionDataPicker(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles dtpPeriodo.KeyDown
        If e.KeyValue = 13 Then
            Me.tcCompra.Enabled = True
            Me.RefrescarGrillaAsignacion()
            Me.RefrescarGrillaPago_iva()
            'Me.RefrescarGrillaVariable()
            Me.RefrescarResumen()
            Me.RefrescarSaldo()
            Me.ControlarEnabled()
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub dtpPeriodo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpPeriodo.ValueChanged
        Me.tcCompra.Enabled = True
        Me.RefrescarGrillaAsignacion()
        Me.RefrescarGrillaPago_iva()
        'Me.RefrescarGrillaVariable()
        Me.RefrescarResumen()
        Me.RefrescarSaldo()
        Me.ControlarEnabled()
    End Sub

    Private Sub btnGenerarResumen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarResumen.Click
        Me.RefrescarResumen()
    End Sub

    Private Sub btnSaldoActual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaldoActual.Click
        Me.RefrescarSaldo()
    End Sub

    Private Sub btnCierrePeriodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCierrePeriodo.Click
        Me.RefrescarResumen()
        Try
            'controlo si el saldo existe en la db - traigo el id_saldo
            Dim IdSaldo As Integer = oSaldo_iva.Check(CInt(Me.lblid_empresa.Text), CInt(Me.lblid_iva.Text), Me.dtpPeriodo.Value)
            If IdSaldo = 0 Then
                'agrego un nuevo registro
                If MessageBox.Show("Desea Realmente Cerrar el Periodo", "Cierre del Periodo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                Else
                    oSaldo_iva.Insertar()
                    oSaldo_iva.fecha_saldo_iva = Me.dtpPeriodo.Value.Date
                    oSaldo_iva.id_Iva = CInt(Me.lblid_iva.Text)
                    oSaldo_iva.id_empresa = CInt(Me.lblid_empresa.Text)
                    oSaldo_iva.saldo_Iva = CDec(Me.lblTotalGrilla.Text)
                    oSaldo_iva.Guardar()
                    Me.ControlarEnabled()
                End If
            Else
                'modifico un registro existente
                If MessageBox.Show("El Periodo ya Esta Cerrado Desea Modificarlo", "Cierre del Periodo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                Else
                    oSaldo_iva.Modificar(IdSaldo)
                    oSaldo_iva.fecha_saldo_iva = Me.dtpPeriodo.Value.Date
                    oSaldo_iva.id_Iva = CInt(Me.lblid_iva.Text)
                    oSaldo_iva.id_empresa = CInt(Me.lblid_empresa.Text)
                    oSaldo_iva.saldo_Iva = CDec(Me.lblTotalGrilla.Text)
                    oSaldo_iva.Guardar()
                    Me.ControlarEnabled()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnModificarPeriodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarPeriodo.Click
        Dim IdSaldo As Integer = oSaldo_iva.Check(CInt(Me.lblid_empresa.Text), CInt(Me.lblid_iva.Text), Me.dtpPeriodo.Value)
        If IdSaldo = 0 Then 'si no esta
            Me.btnGenerarResumen.Enabled = False
            Me.btnCierrePeriodo.Enabled = False
            Me.btnModificarPeriodo.Enabled = True
            Me.btnAgregar.Enabled = False
            Me.btnModificar.Enabled = False
            Me.btnBorrar.Enabled = False
        Else
            Me.btnGenerarResumen.Enabled = True
            Me.btnCierrePeriodo.Enabled = True
            Me.btnModificarPeriodo.Enabled = False
            Me.btnAgregar.Enabled = True
            Me.btnModificar.Enabled = True
            Me.btnBorrar.Enabled = True
        End If
    End Sub

    Sub ControlarEnabled()
        If Me.lblid_iva.Text = "" Then
            Exit Sub
        End If
        Dim IdSaldo As Integer = oSaldo_iva.Check(CInt(Me.lblid_empresa.Text), CInt(Me.lblid_iva.Text), Me.dtpPeriodo.Value)
        If IdSaldo = 0 Then 'si no esta
            Me.btnGenerarResumen.Enabled = True
            Me.btnCierrePeriodo.Enabled = True
            Me.btnModificarPeriodo.Enabled = False
            Me.btnAgregar.Enabled = True
            Me.btnModificar.Enabled = True
            Me.btnBorrar.Enabled = True
        Else
            Me.btnGenerarResumen.Enabled = False
            Me.btnCierrePeriodo.Enabled = False
            Me.btnModificarPeriodo.Enabled = True
            Me.btnAgregar.Enabled = False
            Me.btnModificar.Enabled = False
            Me.btnBorrar.Enabled = False
        End If
    End Sub

    'Private Sub BtnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImprimir.Click
    '    Dim FrmImprime As New Frmreporte_1
    '    parametro_iva_prn = Me.cmbiva.Text

    '    If bandera_imprime = 0 Then
    '        parametro_id_iva = CInt(Me.lblid_iva.Text)
    '        parametro_fecha_old = CDate(Me.dtpPeriodo.Text)
    '        parametro_id_empresa = CInt(Me.lblid_empresa.Text)
    '        Banderaprint = "imprime_asignacion_iva"
    '    ElseIf bandera_imprime = 1 Then
    '        'parametro_perido_resumen = Trim(Me.dtpPeriodo.Text)
    '        parametro_id_iva = CInt(Me.lblid_iva.Text)
    '        parametro_fecha_old = CDate(Me.dtpPeriodo.Text)
    '        'parametro_id_empresa = CInt(Me.lblid_empresa.Text)
    '        Banderaprint = "imprime_movimiento_iva"
    '    ElseIf bandera_imprime = 3 Then
    '        'parametro_perido_resumen = Trim(Me.dtpPeriodo.Text)
    '        parametro_id_iva = CInt(Me.lblid_iva.Text)
    '        parametro_fecha_old = CDate(Me.dtpPeriodo.Text)
    '        parametro_id_empresa = CInt(Me.lblid_empresa.Text)
    '        Banderaprint = "imprime_pagos_iva"
    '    ElseIf bandera_imprime = 2 Then
    '        'parametro_perido_resumen = Trim(Me.dtpPeriodo.Text)
    '        parametro_id_iva = CInt(Me.lblid_iva.Text)
    '        parametro_fecha_old = CDate(Me.dtpPeriodo.Text)
    '        parametro_id_empresa = CInt(Me.lblid_empresa.Text)
    '        parametro_periodo = CDate(Me.dtpPeriodo.Text)
    '        Banderaprint = "imprime_resumen_iva"
    '    End If
    '    FrmImprime.ShowDialog()


    'End Sub


    Private Sub tcCompra_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tcCompra.SelectedIndexChanged
        Select Case Me.tcCompra.SelectedIndex
            Case 0
                bandera_imprime = 0
                '     BtnImprimir.Visible = True
            Case 1
                bandera_imprime = 1
                '    BtnImprimir.Visible = True
            Case 2
                bandera_imprime = 2
                '     BtnImprimir.Visible = True
            Case 3
                bandera_imprime = 3
                '     BtnImprimir.Visible = True

        End Select
    End Sub



    Private Sub btn_retiros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_retiros.Click
        Dim frmTemp As New FrmConsultaivas
        Bandera_consulta_iva = "pagos"


        odtConsultaGeneral = oIva.GetAll_Pagos(Me.dtp_fecha_desde.Value.Date, Me.dtp_Fecha_Hasta.Value.Date, CInt(Me.lblid_iva.Text))

        id_iva_consulta = CInt(Me.lblid_iva.Text)

        datFecha_inicio = Me.dtp_fecha_desde.Value.Date
        datFecha_fin = Me.dtp_Fecha_Hasta.Value.Date

        strTituloConsultaGeneral = "ivas:  " & Me.cmbiva.Text
        parametro_nom_iva = Me.cmbiva.Text
        frmTemp.ShowDialog()
    End Sub

    Private Sub btn_Asignacion_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Asignacion.Click
        Dim frmTemp As New FrmConsultaivas
        Bandera_consulta_iva = "asignacion"

        odtConsultaGeneral = oIva.GetAll_Asignacion(Me.dtp_fecha_desde.Value.Date, Me.dtp_Fecha_Hasta.Value.Date, CInt(Me.lblid_iva.Text))

        id_iva_consulta = CInt(Me.lblid_iva.Text)

        datFecha_inicio = Me.dtp_fecha_desde.Value.Date
        datFecha_fin = Me.dtp_Fecha_Hasta.Value.Date

        strTituloConsultaGeneral = "iva:  " & Me.cmbiva.Text
        parametro_nom_iva = Me.cmbiva.Text
        frmTemp.ShowDialog()


    End Sub

    Private Sub btnCerrarIvaCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarIvaCompra.Click
        Dim odt As New DataTable
        odt = oIva_compra.GetOneDate(Me.dtpPeriodo.Value.Date)
        If odt.Rows.Count > 0 Then
            MessageBox.Show("el libro iva compras esta cerrado")
            Exit Sub
        End If

        If Me.txtNumero_iva_compra.Text = "" Then
            MessageBox.Show("debe ingresar un numero para el libro iva compras")
            Exit Sub
        End If
        oIva_compra_temp.SetIva(Me.dtpPeriodo.Value.Date, Me.txtNumero_iva_compra.Text)

        Dim odt_1 As New DataTable
        odt_1 = oIva_compra_temp.GetCierre(Me.dtpPeriodo.Value.Date)

        oIva_compra.Cargar()

        For Each row As DataRow In odt_1.Rows
            With oIva_compra
                .Insertar()
                .numero = CStr(row("numero"))
                .fecha = CDate(row("fecha"))
                .factura = CStr(row("factura"))
                .nombre = CStr(row("nombre"))
                .cuit = CStr(row("cuit"))
                .imp_gravado = CDec(row("imp_gravado"))
                .imp_exento = CDec(row("imp_exento"))
                .conc_no_grav = CDec(row("conc_no_grav"))
                .iva = CDec(row("iva"))
                .imp_otro = CDec(row("imp_otro"))
                .totals = CDec(row("totals"))
                .iva_ret = CDec(row("iva_ret"))
                .cerrado = True
                .Guardar()
            End With
        Next

        Me.RefrescarGrillaAsignacion()
        Me.txtNumero_iva_compra.Text = ""
        MessageBox.Show("se ha cerrado el libro iva compras")

        'cierre de saldo de proveedores
        Dim odtProv As New DataTable
        odtProv = oProveedor.ConsultarTodo
        For Each row As DataRow In odtProv.Rows
            Me.lblid_proveedor.Text = CStr(row("id_proveedor"))
            Me.CerrarProveedor()
            Me.CerrarSaldoProveedor()
        Next

    End Sub

    Private Sub btnCerrarIvaVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarIvaVenta.Click
        Dim odt As New DataTable
        odt = oIva_venta.GetOneDate(Me.dtpPeriodo.Value.Date)
        If odt.Rows.Count > 0 Then
            MessageBox.Show("el libro iva ventas esta cerrado")
            Exit Sub
        End If

        If Me.txtNumero_iva_venta.Text = "" Then
            MessageBox.Show("debe ingresar un numero para el libro iva ventas")
            Exit Sub
        End If
        oIva_venta_temp.SetIva(Me.dtpPeriodo.Value.Date, Me.txtNumero_iva_compra.Text)

        Dim odt_1 As New DataTable
        odt_1 = oIva_venta_temp.GetCierre(Me.dtpPeriodo.Value.Date)

        oIva_venta.Cargar()

        For Each row As DataRow In odt_1.Rows
            With oIva_venta
                .Insertar()
                .numero = CStr(row("numero"))
                .fecha = CDate(row("fecha"))
                .factura = CStr(row("factura"))
                .nombre = CStr(row("nombre"))
                .cuit = CStr(row("cuit"))
                .imp_gravado = CDec(row("imp_gravado"))
                .imp_exento = CDec(row("imp_exento"))
                .conc_no_grav = CDec(row("conc_no_grav"))
                .iva = CDec(row("iva"))
                .iva_no_ins = CDec(row("iva_no_ins"))
                .totals = CDec(row("totals"))
                .iva_ret = CDec(row("iva_ret"))
                .cerrado = True
                .Guardar()
            End With
        Next

        Me.RefrescarGrillaPago_iva()
        Me.txtNumero_iva_venta.Text = ""
        MessageBox.Show("se ha cerrado el libro iva ventas")
    End Sub


    Private Sub btnImprimirCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirCompra.Click
        'Dim odt As New DataTable
        'odt = oIva_compra.GetOneDate(Me.dtpPeriodo.Value.Date)
        'If odt.Rows.Count <= 0 Then
        '    MessageBox.Show("el libro iva ventas esta abierto, no lo puede Imprimir")
        '    Exit Sub
        'End If
        'Dim frmTemp As New frmReporteIva

        'Dim dtTo As DateTime = Me.dtpPeriodo.Value

        'dtTo = dtTo.AddMonths(1)
        'dtTo = dtTo.AddDays(-(dtTo.Day))

        'Banderaprint = "LibroIvaCompra"
        'parametro_fecha = Me.dtpPeriodo.Value
        'parametro_fecha_inicio = New DateTime(Me.dtpPeriodo.Value.Year, Me.dtpPeriodo.Value.Month, 1)
        'parametro_fecha_fin = dtTo

        'frmTemp.ShowDialog()
    End Sub

    Private Sub btnImprimirVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirVenta.Click
        'Dim odt As New DataTable
        'odt = oIva_venta.GetOneDate(Me.dtpPeriodo.Value.Date)
        'If odt.Rows.Count <= 0 Then
        '    MessageBox.Show("el libro iva ventas esta abierto, no lo puede Imprimir")
        '    Exit Sub
        'End If


        'Dim frmTemp As New frmReporteIva

        'Dim dtTo As DateTime = Me.dtpPeriodo.Value

        'dtTo = dtTo.AddMonths(1)
        'dtTo = dtTo.AddDays(-(dtTo.Day))


        'Banderaprint = "LibroIvaVenta"
        'parametro_fecha = Me.dtpPeriodo.Value
        'parametro_fecha_inicio = New DateTime(Me.dtpPeriodo.Value.Year, Me.dtpPeriodo.Value.Month, 1)
        'parametro_fecha_fin = dtTo

        'frmTemp.ShowDialog()
    End Sub

    Private Sub btnBorrar_CierreVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar_CierreVenta.Click
        oIva_venta.DeleteCierre(Me.dtpPeriodo.Value.Date)
        Me.RefrescarGrillaPago_iva()
    End Sub

    Private Sub btnBorrar_CierreCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar_CierreCompra.Click
        oIva_compra.DeleteCierre(Me.dtpPeriodo.Value.Date)
        Me.RefrescarGrillaAsignacion()
    End Sub




    Public Sub CerrarProveedor()
        Dim odtResumen As New DataTable()
        Dim i As Integer
        Dim s As Decimal
        Dim j As Integer
        Dim FechaOld As DateTime
        Try
            Me.lblSaldoActualProveedor.Text = ""
            '          Me.lblFacturacion_mes.Text = "$ 0"

            'seteo la fecha anterior y traigo el saldo anterior
            FechaOld = DateAdd(DateInterval.Month, -1, Me.dtpPeriodo.Value)
            'parametro_fecha_old = FechaOld
            Me.lblSaldoAnteriorProveedor.Text = FormatCurrency(oSaldo_proveedor.GetOldSaldo(CInt(Me.lblid_proveedor.Text), FechaOld))

            'genera el resumen de cuenta
            odtResumen = oResumen_proveedor.SetResumen(CInt(Me.lblid_proveedor.Text), Me.dtpPeriodo.Value.Date, vgCuentaProveedorResta)

            'calcula el saldo parcial atraves de la grilla
            j = odtResumen.Rows.Count - 1
            For i = 0 To odtResumen.Rows.Count - 1
                s = CDec(odtResumen.Rows(i).Item("saldo").ToString)
                If i = 0 Then
                    s = CDec(s) + CDec(Me.lblSaldoAnterior.Text)
                Else
                    s = s + CDec(odtResumen.Rows(i - 1).Item("saldo").ToString)
                End If
                odtResumen.Rows(i).Item("saldo") = s
            Next
            If j < 0 Then
                Me.dgv1.DataSource = odtResumen
                Me.dgv1.Columns(0).Visible = False

                'bug de los saldos
                Me.lblTotalGrillaProveedor.Text = Me.lblSaldoAnteriorProveedor.Text

                Exit Sub
            End If

            'actualiza el datatable
            oResumen_proveedor.Update()
            oResumen_proveedor.Guardar()

            'muestra el dt en la grilla
            Me.dgvProveedor.DataSource = odtResumen
            Me.dgvProveedor.Columns(0).Visible = False
            Me.dgvProveedor.Columns("DEBE").DefaultCellStyle.Format = "c"
            Me.dgvProveedor.Columns("DEBE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.dgvProveedor.Columns("HABER").DefaultCellStyle.Format = "c"
            Me.dgvProveedor.Columns("HABER").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.dgvProveedor.Columns("SALDO").DefaultCellStyle.Format = "c"
            Me.dgvProveedor.Columns("SALDO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            'agrega el saldo al total de la grilla
            Me.lblTotalGrillaProveedor.Text = CStr(s)


            Try
                '         Me.lblFacturacion_mes.Text = FormatCurrency(oFactura_proveedor.GetAll_Sum(Me.dtpPeriodo.Value.Date, CInt(Me.lblid_proveedor.Text)).Rows(0).Item("IMPORTE"))
            Catch ex As Exception
                '         Me.lblFacturacion_mes.Text = "$ 0"
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try




    End Sub


    Sub CerrarSaldoProveedor()
        Try
            'controlo si el saldo existe en la db - traigo el id_saldo
            Dim IdSaldo As Integer = oSaldo_proveedor.Check(CInt(Me.lblid_proveedor.Text), Me.dtpPeriodo.Value)
            If IdSaldo = 0 Then
                'agrego un nuevo registro
                With oSaldo_proveedor
                    .Cargar()
                    .Insertar()
                    .fecha_saldo_proveedor = Me.dtpPeriodo.Value.Date
                    .id_proveedor = CInt(Me.lblid_proveedor.Text)
                    .saldo_proveedor = CDec(Me.lblTotalGrilla.Text)
                    .Guardar()
                End With
            Else
                'modifico un registro existente
                With oSaldo_proveedor
                    .Cargar()
                    .Modificar(IdSaldo)
                    .fecha_saldo_proveedor = Me.dtpPeriodo.Value.Date
                    .id_proveedor = CInt(Me.lblid_proveedor.Text)
                    .saldo_proveedor = CDec(Me.lblTotalGrilla.Text)
                    .Guardar()
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


End Class