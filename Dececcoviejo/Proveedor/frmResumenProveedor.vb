Imports System.Globalization

Public Class frmResumenProveedor
    Dim odt As DataTable

    Dim BanderaConsultaCompra As Integer

    Private Sub frmAbmGestion_empleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Me.ttModificar.SetToolTip(Me.btnModificar, "Modificar  un Compra Existente")

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

        oPago_proveedor.Cargar()
        oFactura_proveedor.Cargar()
        oSaldo_proveedor.Cargar()

        Me.CargarCombos()
        
        'Me.lblTitulo.Text = "Gestión de Empleados"
        Me.Text = "Gestión de Proveedores" & vgNombreFormulario
    End Sub

    Sub CargarCombos()
        Me.CargarProveedor()
    End Sub

    Sub CargarProveedor()
        Dim odt As New DataTable

        odt = oProveedor.GetCmb
        With Me.cmbProveedor
            .DataSource = odt
            .DisplayMember = "nombre_Proveedor"
            .ValueMember = "id_Proveedor"
        End With
        If Me.cmbProveedor.SelectedIndex >= 0 Then
            cmbProveedor.SelectedIndex = 0
            Me.lblid_proveedor.Text = cmbProveedor.SelectedValue.ToString
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
            Me.lblFacturacion_mes.Text = "$ 0"
            bandera_imprime_prov = 0
            btnImprimir.Enabled = True

            'seteo la fecha anterior y traigo el saldo anterior
            FechaOld = DateAdd(DateInterval.Month, -1, Me.dtpPeriodo.Value)
            'parametro_fecha_old = FechaOld
            Me.lblSaldoAnterior.Text = FormatCurrency(oSaldo_proveedor.GetOldSaldo(CInt(Me.lblid_proveedor.Text), FechaOld))

            'genera el resumen de cuenta
            odtResumen = oResumen_proveedor.SetResumen(CInt(Me.lblid_proveedor.Text), Me.dtpPeriodo.Value.Date, vgCuentaProveedorResta)

            parametro_periodo = Me.dtpPeriodo.Value
            parametro_fecha_inicio = Me.dtpPeriodo.Value.Date
            parametro_proveedor_prn = CInt(Me.lblid_proveedor.Text)
            parametro_nom_prov = Me.cmbProveedor.Text
            parametro_sdo_ant = Me.lblSaldoAnterior.Text

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
                Me.lblTotalGrilla.Text = Me.lblSaldoAnterior.Text

                Exit Sub
            End If

            'actualiza el datatable
            oResumen_proveedor.Update()
            oResumen_proveedor.Guardar()

            'muestra el dt en la grilla
            Me.dgv1.DataSource = odtResumen
            Me.dgv1.Columns(0).Visible = False
            Me.dgv1.Columns("DEBE").DefaultCellStyle.Format = "c"
            Me.dgv1.Columns("DEBE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.dgv1.Columns("HABER").DefaultCellStyle.Format = "c"
            Me.dgv1.Columns("HABER").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.dgv1.Columns("SALDO").DefaultCellStyle.Format = "c"
            Me.dgv1.Columns("SALDO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            'agrega el saldo al total de la grilla
            Me.lblTotalGrilla.Text = CStr(s)


            Try
                Me.lblFacturacion_mes.Text = FormatCurrency(oFactura_proveedor.GetAll_Sum(Me.dtpPeriodo.Value.Date, CInt(Me.lblid_proveedor.Text)).Rows(0).Item("IMPORTE"))
            Catch ex As Exception
                Me.lblFacturacion_mes.Text = "$ 0"
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub RefrescarSaldo()
        'traigo los valores del ultimo saldo
        Dim odtSaldoTemp As DataTable
        odtSaldoTemp = oSaldo_proveedor.GetMaxSaldo(CInt(Me.lblid_proveedor.Text))

        Dim FechaMax As DateTime = #1/1/2000#
        Dim decSaldoOld As Decimal = 0

        'controlo si el dt esta vacio
        If odtSaldoTemp.Rows.Count > 0 Then
            'obtengo la fecha mayor
            FechaMax = CDate(odtSaldoTemp.Rows(0).Item("fecha_Saldo_proveedor"))

            'obtengo el ultimo saldo
            decSaldoOld = CDec(odtSaldoTemp.Rows(0).Item("Saldo_proveedor"))
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
        decSaldo = oSaldo_proveedor.GetSaldo(CInt(Me.lblid_proveedor.Text), FechaMax, vgCuentaProveedorResta) + decSaldoOld

        'lo pongo en el label
        Me.lblSaldoActual.Text = FormatCurrency(decSaldo)
    End Sub


    Private Sub dgv1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv1.CurrentCellChanged
        Try
            Me.lblid_pk.Text = CStr(Me.dgv1.Item(0, Me.dgv1.CurrentRow.Index).Value)
        Catch ex As Exception
        End Try
    End Sub


    'coloca el rojo en la celdas negativas
    Private Sub dataGridView8_CellFormatting(ByVal sender As Object, _
    ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) _
        Handles dgv1.CellFormatting
        If dgv1.Columns(e.ColumnIndex).Name.Equals("SALDO") Then
            'Dim intValue As Int32
            If CInt(e.Value) < 0 Then
                'if Int32.TryParse((String)e.Value, out intValue) && 
                '   (intValue < 0))
                e.CellStyle.ForeColor = Color.Red
                e.CellStyle.SelectionBackColor = Color.DarkRed
            End If
        End If
    End Sub

    Private Sub Botones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnPago.Click, btnFactura.Click, btnSalir.Click

        Dim btnTemp As New Button
        btnTemp = CType(sender, Button)

        vgFormularioPadre = Me.Name

        Select Case btnTemp.Name
            Case "btnAyuda"
                'System.Diagnostics.Process.Start(PathAyuda + "FrmAbmCompra.htm")
            Case "btnSalir"
                Me.Close()
            Case "btnFactura"
                Dim frmTemp As New frmAbmFactura_proveedor
                Me.AddOwnedForm(frmTemp)
                frmTemp.ShowDialog()

                Me.RefrescarResumen()
                Me.RefrescarSaldo()
                'Me.ControlarEnabled()
            Case "btnPago"
                'Dim frmTemp As New frmAbmPago_proveedor

                Dim frmTemp As New frmAbmRecibo_proveedor_2
                Me.AddOwnedForm(frmTemp)
                frmTemp.ShowDialog()

                Me.RefrescarResumen()
                Me.RefrescarSaldo()
                'Me.ControlarEnabled()
        End Select

    End Sub

    Sub RefrescarCambioCombo()
        If Not IsNumeric(Me.lblid_proveedor.Text) Then
            Exit Sub
        Else
            If Me.cmbProveedor.SelectedIndex >= 0 Then
                Me.RefrescarResumen()
                Me.RefrescarSaldo()
            End If
            Me.RefrescarResumen()
            Me.RefrescarSaldo()
            'Me.ControlarEnabled()
        End If
    End Sub

    Private Sub cmbProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProveedor.SelectedIndexChanged
        If Me.cmbProveedor.SelectedIndex >= 0 Then
            Me.lblid_proveedor.Text = cmbProveedor.SelectedValue.ToString
        End If
        If Not IsNumeric(Me.lblid_proveedor.Text) Then
            Exit Sub
        End If
        Me.RefrescarResumen()
        Me.RefrescarSaldo()
        Me.ControlarEnabled()
    End Sub

    Private Sub btnBuscaProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaProveedor.Click
        Dim frmTemporal As New FrmAbmProveedor
        frmTemporal.ShowDialog()
        Me.CargarProveedor()
        Me.cmbProveedor.Focus()
        Me.cmbProveedor.Text = ""
        Me.lblid_Proveedor.Text = "0"
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpPeriodo.KeyDown, cmbProveedor.KeyDown
        Dim dtpTemp As New Object
        dtpTemp = sender
        If e.KeyValue = 13 Then
            Me.RefrescarResumen()
            Me.RefrescarSaldo()
            Me.ControlarEnabled()
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub dtpPeriodo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpPeriodo.ValueChanged
        Me.RefrescarResumen()
        Me.RefrescarSaldo()
        Me.ControlarEnabled()
    End Sub

    Private Sub btnGenerarResumen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarResumen.Click
        Me.RefrescarResumen()
        Me.btnCierrePeriodo.Enabled = True
    End Sub

    Private Sub btnSaldoActual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaldoActual.Click
        Me.RefrescarSaldo()
    End Sub

    Private Sub btnCierrePeriodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCierrePeriodo.Click
        Me.RefrescarResumen()
        Try
            'controlo si el saldo existe en la db - traigo el id_saldo
            Dim IdSaldo As Integer = oSaldo_proveedor.Check(CInt(Me.lblid_proveedor.Text), Me.dtpPeriodo.Value)
            If IdSaldo = 0 Then
                'agrego un nuevo registro
                If MessageBox.Show("Desea Realmente Cerrar el Periodo", "Cierre del Periodo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                Else
                    oSaldo_proveedor.Insertar()
                    oSaldo_proveedor.fecha_saldo_proveedor = Me.dtpPeriodo.Value.Date
                    oSaldo_proveedor.id_proveedor = CInt(Me.lblid_proveedor.Text)
                    oSaldo_proveedor.saldo_proveedor = CDec(Me.lblTotalGrilla.Text)
                    oSaldo_proveedor.Guardar()
                    Me.ControlarEnabled()
                    Me.dtpPeriodo.Enabled = True
                    Me.cmbProveedor.Enabled = True
                    Me.btnSaldoActual.Enabled = True
                    Me.btnSalir.Enabled = True
                End If
            Else
                'modifico un registro existente
                If MessageBox.Show("El Periodo ya Esta Cerrado Desea Modificarlo", "Cierre del Periodo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                Else
                    oSaldo_proveedor.Modificar(IdSaldo)
                    oSaldo_proveedor.fecha_saldo_proveedor = Me.dtpPeriodo.Value.Date
                    oSaldo_proveedor.id_proveedor = CInt(Me.lblid_proveedor.Text)
                    oSaldo_proveedor.saldo_proveedor = CDec(Me.lblTotalGrilla.Text)
                    oSaldo_proveedor.Guardar()
                    Me.ControlarEnabled()
                    Me.dtpPeriodo.Enabled = True
                    Me.cmbProveedor.Enabled = True
                    Me.btnSaldoActual.Enabled = True
                    Me.btnSalir.Enabled = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnModificarPeriodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarPeriodo.Click
        Dim IdSaldo As Integer = oSaldo_proveedor.Check(CInt(Me.lblid_proveedor.Text), Me.dtpPeriodo.Value)
        If IdSaldo = 0 Then 'si no esta
            Me.btnGenerarResumen.Enabled = False
            Me.btnCierrePeriodo.Enabled = False
            Me.btnModificarPeriodo.Enabled = True
            Me.btnFactura.Enabled = False
            Me.btnPago.Enabled = False
        Else
            Me.btnGenerarResumen.Enabled = True
            Me.btnCierrePeriodo.Enabled = False
            Me.btnModificarPeriodo.Enabled = False
            Me.btnFactura.Enabled = True
            Me.btnPago.Enabled = True
            'Me.dtpPeriodo.Enabled = False
            'Me.cmbProveedor.Enabled = False
            Me.btnSaldoActual.Enabled = False
            ' Me.btnConsultar.Enabled = False
            'Me.btnSalir.Enabled = False
        End If
    End Sub

    Sub ControlarEnabled()
        If Me.lblid_proveedor.Text = "" Then
            Exit Sub
        End If
        Dim IdSaldo As Integer = oSaldo_proveedor.Check(CInt(Me.lblid_proveedor.Text), Me.dtpPeriodo.Value)
        If IdSaldo = 0 Then 'si no esta
            Me.btnGenerarResumen.Enabled = True
            Me.btnCierrePeriodo.Enabled = True
            Me.btnModificarPeriodo.Enabled = False
            Me.btnFactura.Enabled = True
            Me.btnPago.Enabled = True
        Else
            Me.btnGenerarResumen.Enabled = False
            Me.btnCierrePeriodo.Enabled = False
            Me.btnModificarPeriodo.Enabled = True
            Me.btnFactura.Enabled = False
            Me.btnPago.Enabled = False
        End If
    End Sub

   



    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        Dim frmTemp As New frmConsultaProveedorMain
        frmTemp.ShowDialog()

        Me.RefrescarResumen()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If vgNombrePermiso = "console" Then

            If bandera_imprime_prov = 0 Then
                'Dim frmTemp As New frmReporteResumenProveedor
                'Me.AddOwnedForm(frmTemp)
                'frmTemp.ShowDialog()
            ElseIf bandera_imprime_prov = 2 Then
                'Dim frmTemp As New frmReporteFacturasProveedor
                'Me.AddOwnedForm(frmTemp)
                'frmTemp.ShowDialog()
            ElseIf bandera_imprime_prov = 4 Then
                'parametro_fecha_fin = DateTime.Now.Date
                'Dim frmTemp As New frmReporteFacturasProveedorVencidas
                'Me.AddOwnedForm(frmTemp)
                'frmTemp.ShowDialog()
            End If
        Else
            'Dim FrmImprime As New frmReporte_1

            'If bandera_imprime_prov = 0 Then
            '    vgBanderaprint = "imprime_resumen_prov"
            '    parametro_id_proveedor = CInt(Me.lblid_proveedor.Text)
            '    parametro_periodo = CDate(dtpPeriodo.Text.ToString)
            '    Dim frmTemp As New frmReporteResumenProveedor
            '    Me.AddOwnedForm(frmTemp)
            '    frmTemp.ShowDialog()
            '    Exit Sub
            'ElseIf bandera_imprime_prov = 2 Then
            '    vgBanderaprint = "imprime_facturas_Prov"
            'ElseIf bandera_imprime_prov = 4 Then
            '    vgBanderaprint = "imprime_facturas_vencidas"
            'End If

            'FrmImprime.ShowDialog()

        End If
        
    End Sub

    Private Sub dgv1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellDoubleClick
        Try
            If dgv1.Columns(e.ColumnIndex).Index = 2 Then
                Dim frmTemp As New frmConsultaFactura
                Dim strRecibo As String = ""
                strRecibo = Me.dgv1.Item(2, Me.dgv1.CurrentRow.Index).Value.ToString.Trim
                strRecibo = Microsoft.VisualBasic.Right(strRecibo, 13)
                strRecibo = strRecibo.Replace("-", "")

                odtConsultaGeneral.Clear()
                odtConsultaGeneral = oFactura_recibo_proveedor.GetAll_4(CInt(Me.lblid_proveedor.Text), strRecibo)
                frmTemp.ShowDialog()

            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub





    Private Sub btnCierreTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCierreTodo.Click
        'cierre de saldo de proveedores
        Dim odtProv As New DataTable
        odtProv = oProveedor.ConsultarTodo
        For Each row As DataRow In odtProv.Rows
            Me.lblid_proveedor.Text = CStr(row("id proveedor"))

            Me.RefrescarResumen()
            Try
                'controlo si el saldo existe en la db - traigo el id_saldo
                Dim IdSaldo As Integer = oSaldo_proveedor.Check(CInt(Me.lblid_proveedor.Text), Me.dtpPeriodo.Value)
                If IdSaldo = 0 Then
                    'agrego un nuevo registro

                    oSaldo_proveedor.Insertar()
                    oSaldo_proveedor.fecha_saldo_proveedor = Me.dtpPeriodo.Value.Date
                    oSaldo_proveedor.id_proveedor = CInt(Me.lblid_proveedor.Text)
                    oSaldo_proveedor.saldo_proveedor = CDec(Me.lblTotalGrilla.Text)
                    oSaldo_proveedor.Guardar()

                Else
                    'modifico un registro existente

                    oSaldo_proveedor.Modificar(IdSaldo)
                    oSaldo_proveedor.fecha_saldo_proveedor = Me.dtpPeriodo.Value.Date
                    oSaldo_proveedor.id_proveedor = CInt(Me.lblid_proveedor.Text)
                    oSaldo_proveedor.saldo_proveedor = CDec(Me.lblTotalGrilla.Text)
                    oSaldo_proveedor.Guardar()

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Next

        Me.CargarProveedor()
        Me.RefrescarResumen()
        Me.RefrescarSaldo()
        Me.ControlarEnabled()
    End Sub


    Private Sub bntAbrirPeriodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntAbrirPeriodos.Click
        oSaldo_proveedor.AbrirPeriodosProveedor(Me.dtpPeriodo.Value)
        Me.CargarProveedor()
        Me.RefrescarResumen()
        Me.RefrescarSaldo()
        Me.ControlarEnabled()
    End Sub
End Class