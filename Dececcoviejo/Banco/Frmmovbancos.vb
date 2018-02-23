Imports Microsoft.VisualBasic
Imports System.Globalization
Imports System.Data.OleDb ' agregado
Imports System.Math

Public Class Frmmovbancos

    Dim dt1 As New DataTable("Cheques_Recibidos")
    Dim dt3 As New DataTable("Transferencia_Bancaria")
    Dim dt2 As New DataTable("Cheques_Librados")
    Dim dt4 As New DataTable("Creditos")
    Dim dt5 As New DataTable("Debitos")
    Dim dt6 As New DataTable("Depositos_Efectivo")
    Dim dt7 As New DataTable("Gastos")
    Dim dt8 As New DataTable("ResumenCuenta")
    Dim dt11 As New DataTable
    Dim dt22 As New DataTable

    Dim BanderaConsultaMovimiento As Integer
    Dim BanderaConsultaTipo As Integer

    Sub CargarEmpresa()
        Dim odt As New DataTable

        odt = oEmpresa.GetCmb
        With Me.cmbEmpresa
            .DataSource = odt
            .DisplayMember = "nombre_empresa"
            .ValueMember = "id_empresa"
        End With
        If Me.cmbEmpresa.SelectedIndex >= 0 Then
            cmbEmpresa.SelectedIndex = 0
            Me.lblidEmpresa.Text = cmbEmpresa.SelectedValue.ToString
        End If
    End Sub

    Sub CargarCliente()
        Dim odt As New DataTable

        odt = oCliente.GetCmb
        With Me.cmbCliente
            .DataSource = odt
            .DisplayMember = "nombre_cliente"
            .ValueMember = "id_cliente"
        End With
        If Me.cmbCliente.SelectedIndex >= 0 Then
            cmbCliente.SelectedIndex = 0
            Me.lblidCliente.Text = cmbCliente.SelectedValue.ToString
        End If
    End Sub

    Sub CargarProveedor()
        Dim odt As New DataTable

        odt = oProveedor.GetCmb
        With Me.cmbCliente
            .DataSource = odt
            .DisplayMember = "nombre_proveedor"
            .ValueMember = "id_proveedor"
        End With
        If Me.cmbCliente.SelectedIndex >= 0 Then
            cmbCliente.SelectedIndex = 0
            Me.lblidCliente.Text = cmbCliente.SelectedValue.ToString
        End If
    End Sub

    Sub CargarBanco()
        Dim odt As New DataTable

        odt = oBanco.GetCmb
        With Me.Cmbbanco
            .DataSource = odt
            .DisplayMember = "nombre_banco"
            .ValueMember = "id_banco"
        End With
        If Me.Cmbbanco.SelectedIndex >= 0 Then
            Cmbbanco.SelectedIndex = 0
            Me.lblidBanco.Text = Cmbbanco.SelectedValue.ToString
        End If
    End Sub

    Sub CargarCuenta(ByVal idBanco As Integer, ByVal idEmpresa As Integer)
        Dim odt As New DataTable

        If idBanco < 0 Then
            Exit Sub
        End If

        odt = oCuenta.Consultar(idBanco, idEmpresa)
        With Me.cmbCuenta
            .DataSource = odt
            .DisplayMember = "numero"
            .ValueMember = "id_cuenta"
        End With
        If Me.cmbCuenta.SelectedIndex >= 0 Then
            cmbCuenta.SelectedIndex = 0
            Me.lblidCuenta.Text = cmbCuenta.SelectedValue.ToString
        End If
    End Sub

    Sub RefrescarGrilla()
        Dim odt1 As New DataTable("Cheques_Recibidos")
        Dim odt2 As New DataTable("Cheques_Librados")
        Dim odt3 As New DataTable("Transferencia_Bancaria")
        Dim odt4 As New DataTable("Creditos")
        Dim odt5 As New DataTable("Debitos")
        Dim odt6 As New DataTable("Depositos_Efectivo")
        Dim odt7 As New DataTable("Gastos")
        Dim odt8 As New DataTable("Resumen_Cuenta_2")

        Dim odt11 As New DataTable
        Dim odt22 As New DataTable

        If Me.lblidEmpresa.Text = "" Or Me.lblidBanco.Text = "" Or Me.lblidCuenta.Text = "" Then
            Exit Sub
        End If

        Me.lblSaldoActual.Text = ""
        Me.txtSaldoContable.Text = ""

        dt1 = oChequeRecibido.Cargar
        dt2 = oChequeLibrado.Cargar
        dt11 = oChequeRecibido.Cargar
        dt22 = oChequeLibrado.Cargar
        dt3 = oTransferenciaBancaria.Cargar
        dt4 = oCredito.Cargar
        dt5 = oDebito.Cargar
        dt6 = oDepositoEfectivo.Cargar
        dt7 = oGasto.Cargar

        odt1 = oChequeRecibido.Consultar(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text))
        parametro_banco = CInt(Me.lblidBanco.Text)
        parametro_empresa = CInt(Me.lblidEmpresa.Text)
        parametro_cuenta = CInt(Me.lblidCuenta.Text)
        parametro_id_banco = CInt(Me.lblidBanco.Text.Trim)
        parametro_id_cuenta = CInt(Me.lblidCuenta.Text.Trim)
        parametro_fecha = Me.dpBanco.Value.Date






        odt11 = oChequeRecibido.Consultar2(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text))

        odt2 = oChequeLibrado.Consultar(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text))
        parametro_banco = CInt(Me.lblidBanco.Text)
        parametro_empresa = CInt(Me.lblidEmpresa.Text)
        parametro_cuenta = CInt(Me.lblidCuenta.Text)
        parametro_id_banco = CInt(Me.lblidBanco.Text.Trim)
        parametro_id_cuenta = CInt(Me.lblidCuenta.Text.Trim)

        parametro_fecha = Me.dpBanco.Value.Date




        odt22 = oChequeLibrado.Consultar2(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text))

        odt3 = oTransferenciaBancaria.Consultar(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text))
        parametro_banco = CInt(Me.lblidBanco.Text)
        parametro_empresa = CInt(Me.lblidEmpresa.Text)
        parametro_cuenta = CInt(Me.lblidCuenta.Text)
        parametro_id_banco = CInt(Me.lblidBanco.Text.Trim)
        parametro_id_cuenta = CInt(Me.lblidCuenta.Text.Trim)
        parametro_fecha = Me.dpBanco.Value.Date


        odt4 = oCredito.Consultar(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text))
        parametro_banco = CInt(Me.lblidBanco.Text)
        parametro_empresa = CInt(Me.lblidEmpresa.Text)
        parametro_cuenta = CInt(Me.lblidCuenta.Text)
        parametro_id_banco = CInt(Me.lblidBanco.Text.Trim)
        parametro_id_cuenta = CInt(Me.lblidCuenta.Text.Trim)
        parametro_fecha = Me.dpBanco.Value.Date



        odt5 = oDebito.Consultar(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text))
        odt6 = oDepositoEfectivo.Consultar(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text))

        parametro_banco = CInt(Me.lblidBanco.Text)
        parametro_empresa = CInt(Me.lblidEmpresa.Text)
        parametro_cuenta = CInt(Me.lblidCuenta.Text)
        parametro_id_banco = CInt(Me.lblidBanco.Text.Trim)
        parametro_id_cuenta = CInt(Me.lblidCuenta.Text.Trim)
        parametro_fecha = Me.dpBanco.Value.Date

        odt7 = oGasto.Consultar(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text))
        odt8 = oResumenCuenta.ConsultarResumen(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text))

        Me.lblSaldoAnterior.Text = FormatCurrency(oResumenCuenta.TraerSaldoAnteriorBanco(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidCuenta.Text)))

        'cheque recibido
        Me.DataGridView1.DataSource = odt1
        Me.DataGridView1.Columns(0).Visible = False
        Me.DataGridView1.Columns("IMPORTE").DefaultCellStyle.Format = "c"
        Me.DataGridView1.Columns("IMPORTE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        'cheque librado
        Me.DataGridView2.DataSource = odt2
        Me.DataGridView2.Columns(0).Visible = False
        Me.DataGridView2.Columns("IMPORTE").DefaultCellStyle.Format = "c"
        Me.DataGridView2.Columns("IMPORTE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        'transferencia bancaria
        Me.DataGridView3.DataSource = odt3
        Me.DataGridView3.Columns(0).Visible = False
        Me.DataGridView3.Columns("IMPORTE").DefaultCellStyle.Format = "c"
        Me.DataGridView3.Columns("IMPORTE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        'credito
        Me.DataGridView4.DataSource = odt4
        Me.DataGridView4.Columns(0).Visible = False
        Me.DataGridView4.Columns("IMPORTE").DefaultCellStyle.Format = "c"
        Me.DataGridView4.Columns("IMPORTE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        'debito
        Me.DataGridView5.DataSource = odt5
        Me.DataGridView5.Columns(0).Visible = False
        Me.DataGridView5.Columns("IMPORTE").DefaultCellStyle.Format = "c"
        Me.DataGridView5.Columns("IMPORTE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        'deposito en efectivo
        Me.DataGridView6.DataSource = odt6
        Me.DataGridView6.Columns(0).Visible = False
        Me.DataGridView6.Columns("IMPORTE").DefaultCellStyle.Format = "c"
        Me.DataGridView6.Columns("IMPORTE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        'gasto
        Me.DataGridView7.DataSource = odt7
        Me.DataGridView7.Columns(0).Visible = False
        Me.DataGridView7.Columns("IMPORTE").DefaultCellStyle.Format = "c"
        Me.DataGridView7.Columns("IMPORTE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        'resumen de cuenta
        Me.DataGridView8.DataSource = odt8
        Me.DataGridView8.Columns(0).Visible = False
        Me.DataGridView8.Columns("IMPORTE_DEBE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView8.Columns("IMPORTE_HABER").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView8.Columns("SALDO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.DataGridView8.Columns("IMPORTE_DEBE").DefaultCellStyle.Format = "c"
        Me.DataGridView8.Columns("IMPORTE_HABER").DefaultCellStyle.Format = "c"
        Me.DataGridView8.Columns("SALDO").DefaultCellStyle.Format = "c"

        'cheque recibido
        Me.DataGridView9.DataSource = odt11
        Me.DataGridView9.Columns(0).Visible = False
        Me.DataGridView9.Columns("IMPORTE").DefaultCellStyle.Format = "c"
        Me.DataGridView9.Columns("IMPORTE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        'cheque librado
        Me.DataGridView10.DataSource = odt22
        Me.DataGridView10.Columns(0).Visible = False
        Me.DataGridView10.Columns("IMPORTE").DefaultCellStyle.Format = "c"
        Me.DataGridView10.Columns("IMPORTE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        '   RefrescarId()
    End Sub

    Sub ControlarEnabled()
        If Me.lblidEmpresa.Text = "" Or Me.lblidBanco.Text = "" Or Me.lblidCuenta.Text = "" Then
            Exit Sub
        End If
        If oSaldoBanco.ControlarSaldo(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidCuenta.Text)) Then
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


        'modificacion lubricentro
        If IsNumeric(Me.lblidEmpresa.Text) And IsNumeric(Me.lblidCuenta.Text) And IsNumeric(Me.lblidBanco.Text) Then
            Me.Cheques.Enabled = True
        End If
    End Sub

    '  Private Sub RefrescarId()
    '        Try
    '   Dim odw As DataView
    '
    '           Select Case BanderaCheque
    '              Case 1
    '          odw = dt1.DefaultView
    '           Me.lblidChequeRecibido.Text = odw(DataGridView1.CurrentRow.Index)("id_cheque_recibido").ToString()
    '        Case 2
    '             odw = dt2.DefaultView
    '              Me.lblidChequeLibrado.Text = odw(DataGridView2.CurrentRow.Index)("id_cheque_librado").ToString()
    '           Case 3
    '                odw = dt3.DefaultView
    '                 Me.lblidTransferenciaBancaria.Text = odw(DataGridView3.CurrentRow.Index)("id_transferencia_bancaria").ToString()
    '    Case 4
    '         odw = dt4.DefaultView
    '          Me.lblidCredito.Text = odw(DataGridView4.CurrentRow.Index)("id_credito").ToString()
    '       Case 5
    '            odw = dt5.DefaultView
    '                 Me.lblidDebito.Text = odw(DataGridView5.CurrentRow.Index)("id_debito").ToString()
    '         Case 6
    '              odw = dt6.DefaultView
    '               Me.lblidDepositoEfectivo.Text = odw(DataGridView6.CurrentRow.Index)("id_deposito_efectivo").ToString()
    '            Case 7
    '                 odw = dt7.DefaultView
    '                  Me.lblidGasto.Text = odw(DataGridView7.CurrentRow.Index)("id_gasto").ToString()
    '           End Select
    '
    '        Catch ex As Exception
    '   Me.lblidChequeRecibido.Text = ""
    '    Me.lblidChequeLibrado.Text = ""
    '     Me.lblidDebito.Text = ""
    '      Me.lblidCredito.Text = ""
    '       Me.lblidDepositoEfectivo.Text = ""
    '        Me.lblidGasto.Text = ""
    '         Me.lblidTransferenciaBancaria.Text = ""
    '      End Try
    '  End Sub

    Private Sub Frmmovbancos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'cultura regional
        Dim oldDecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        Dim forceDotCulture As CultureInfo
        forceDotCulture = CType(Application.CurrentCulture.Clone(), CultureInfo)
        forceDotCulture.NumberFormat.NumberDecimalSeparator = ","
        forceDotCulture.NumberFormat.NumberGroupSeparator = "."
        forceDotCulture.NumberFormat.CurrencyDecimalSeparator = ","
        forceDotCulture.NumberFormat.CurrencyGroupSeparator = "."
        forceDotCulture.NumberFormat.CurrencyDecimalDigits = 2
        forceDotCulture.NumberFormat.CurrencySymbol = "$"
        Application.CurrentCulture = forceDotCulture

        CargarEmpresa()
        CargarBanco()
        Me.cmbEmpresa.Text = ""
        Me.Cmbbanco.Text = ""
        Me.cmbCuenta.Text = ""
        Me.cmbCliente.Text = ""

        Me.lblidBanco.Text = ""
        Me.lblidCuenta.Text = ""
        Me.lblidCliente.Text = ""
        Me.cmbEmpresa.Focus()

        'modificacion lubricentro
        Me.lblidEmpresa.Text = "1"
        Me.cmbEmpresa.Text = oEmpresa.GetOne(CInt(Me.lblidEmpresa.Text)).Rows(0).Item("nombre_Empresa").ToString.Trim
        '    Me.Cheques.Enabled = True
        RefrescarGrilla()
        Me.ControlarEnabled()
        Me.habilitar_importacion(False)

        Dim odt As New DataTable
        odt = oCliente_maestro.GetOne(1)
        If odt.Rows(0).Item("nombre_permiso").ToString = "colina" Then
            Me.cmbEmpresa.Enabled = True
            Me.btnBuscaEmpresa.Enabled = True
        End If

       
    End Sub


    Private Sub Cheques_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cheques.SelectedIndexChanged
        'modificacion lubricentro
        If Not IsNumeric(Me.lblidEmpresa.Text) Or Not IsNumeric(Me.lblidCuenta.Text) Or Not IsNumeric(Me.lblidBanco.Text) Then
            Exit Sub
        End If

        Select Case Me.Cheques.SelectedIndex
            Case 7
                Me.Btnimprime.Enabled = True
                Me.lblSaldoAnterior.Text = CStr(oResumenCuenta.TraerSaldoAnteriorBanco(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidCuenta.Text)))
            Case Else
                'Me.Btnimprime.Enabled = False
        End Select
    End Sub

    Private Sub cmbEmpresa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbEmpresa.KeyDown
        If e.KeyValue = 13 Then
            Me.Cmbbanco.Focus()
        End If
    End Sub

    Private Sub cmbEmpresa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEmpresa.SelectedIndexChanged
        Try
            If Me.cmbEmpresa.SelectedIndex >= 0 Then
                If Me.cmbEmpresa.SelectedValue.ToString = "System.Data.DataRowView" Then
                    Exit Sub
                End If
                Me.lblidEmpresa.Text = cmbEmpresa.SelectedValue.ToString
                Me.Cheques.Enabled = True
                RefrescarGrilla()
                Me.ControlarEnabled()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Cmbbanco_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cmbbanco.KeyDown
        If e.KeyValue = 13 Then
            Me.cmbCuenta.Focus()
        End If
    End Sub

    Private Sub Cmbbanco_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbbanco.SelectedIndexChanged
        If Me.Cmbbanco.SelectedIndex >= 0 Then
            Me.lblidBanco.Text = Cmbbanco.SelectedValue.ToString
            Try
                Me.CargarCuenta(CInt(Me.lblidBanco.Text), CInt(Me.lblidEmpresa.Text))
            Catch ex As Exception
                If Err.Number = 91 Then
                    Me.cmbCuenta.Text = ""
                    Me.lblidCuenta.Text = "0"
                End If
            End Try
        End If
        Me.habilitar_importacion(True) 'agregado
    End Sub

    Private Sub cmbCuenta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCuenta.KeyDown
        If e.KeyValue = 13 Then
            Me.dpBanco.Focus()
        End If
    End Sub

    Private Sub cmbCuenta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCuenta.SelectedIndexChanged
        If Me.cmbCuenta.SelectedIndex >= 0 Then
            Try
                Me.lblidCuenta.Text = cmbCuenta.SelectedValue.ToString
                RefrescarGrilla()
                Me.ControlarEnabled()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            'pongo el id para hacer los cambios
            Me.lblidChequeRecibido.Text = CStr(Me.DataGridView1.Item(0, Me.DataGridView1.CurrentRow.Index).Value)

            If DataGridView1.Columns(e.ColumnIndex).Index = 1 Then
                If CDbl(Me.DataGridView1.Item(1, Me.DataGridView1.CurrentRow.Index).Value) = 0 Then
                    oChequeRecibido.Update_Check(CInt(Me.lblidChequeRecibido.Text), True)
                Else
                    oChequeRecibido.Update_Check(CInt(Me.lblidChequeRecibido.Text), False)
                End If
                Me.RefrescarGrilla()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.CurrentCellChanged
        Try
            Me.lblidChequeRecibido.Text = CStr(Me.DataGridView1.Item(0, Me.DataGridView1.CurrentRow.Index).Value)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView2_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        Try
            'pongo el id para hacer el cambio
            Me.lblidChequeLibrado.Text = CStr(Me.DataGridView2.Item(0, Me.DataGridView2.CurrentRow.Index).Value)

            If DataGridView2.Columns(e.ColumnIndex).Index = 1 Then
                If CDbl(Me.DataGridView2.Item(1, Me.DataGridView2.CurrentRow.Index).Value) = 0 Then
                    oChequeLibrado.Update_Check(CInt(Me.lblidChequeLibrado.Text), True)
                Else
                    oChequeLibrado.Update_Check(CInt(Me.lblidChequeLibrado.Text), False)
                End If
                Me.RefrescarGrilla()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView2_CurrentCellChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView2.CurrentCellChanged
        Try
            Me.lblidChequeLibrado.Text = CStr(Me.DataGridView2.Item(0, Me.DataGridView2.CurrentRow.Index).Value)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView3_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellDoubleClick
        Try
            If DataGridView3.Columns(e.ColumnIndex).Index = 1 Then
                If CDbl(Me.DataGridView3.Item(1, Me.DataGridView3.CurrentRow.Index).Value) = 0 Then
                    oTransferenciaBancaria.Update_Check(CInt(Me.lblidTransferenciaBancaria.Text), True)
                Else
                    oTransferenciaBancaria.Update_Check(CInt(Me.lblidTransferenciaBancaria.Text), False)
                End If
                Me.RefrescarGrilla()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView3_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView3.CurrentCellChanged
        Try
            Me.lblidTransferenciaBancaria.Text = CStr(Me.DataGridView3.Item(0, Me.DataGridView3.CurrentRow.Index).Value)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView4_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView4.CellDoubleClick
        Try
            If DataGridView4.Columns(e.ColumnIndex).Index = 1 Then
                If CDbl(Me.DataGridView4.Item(1, Me.DataGridView4.CurrentRow.Index).Value) = 0 Then
                    oCredito.Update_Check(CInt(Me.lblidCredito.Text), True)
                Else
                    oCredito.Update_Check(CInt(Me.lblidCredito.Text), False)
                End If
                Me.RefrescarGrilla()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView4_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView4.CurrentCellChanged
        Try
            Me.lblidCredito.Text = CStr(Me.DataGridView4.Item(0, Me.DataGridView4.CurrentRow.Index).Value)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView5_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView5.CellDoubleClick
        Try
            If DataGridView5.Columns(e.ColumnIndex).Index = 1 Then
                If CDbl(Me.DataGridView5.Item(1, Me.DataGridView5.CurrentRow.Index).Value) = 0 Then
                    oDebito.Update_Check(CInt(Me.lblidDebito.Text), True)
                Else
                    oDebito.Update_Check(CInt(Me.lblidDebito.Text), False)
                End If
                Me.RefrescarGrilla()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView5_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView5.CurrentCellChanged
        Try
            Me.lblidDebito.Text = CStr(Me.DataGridView5.Item(0, Me.DataGridView5.CurrentRow.Index).Value)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView6_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView6.CellDoubleClick
        Try
            If DataGridView6.Columns(e.ColumnIndex).Index = 1 Then
                If CDbl(Me.DataGridView6.Item(1, Me.DataGridView6.CurrentRow.Index).Value) = 0 Then
                    oDepositoEfectivo.Update_Check(CInt(Me.lblidDepositoEfectivo.Text), True)
                Else
                    oDepositoEfectivo.Update_Check(CInt(Me.lblidDepositoEfectivo.Text), False)
                End If
                Me.RefrescarGrilla()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView6_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView6.CurrentCellChanged
        Try
            Me.lblidDepositoEfectivo.Text = CStr(Me.DataGridView6.Item(0, Me.DataGridView6.CurrentRow.Index).Value)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView7_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView7.CellDoubleClick
        Try
            If DataGridView7.Columns(e.ColumnIndex).Index = 1 Then
                If CDbl(Me.DataGridView7.Item(1, Me.DataGridView7.CurrentRow.Index).Value) = 0 Then
                    oGasto.Update_Check(CInt(Me.lblidGasto.Text), True)
                Else
                    oGasto.Update_Check(CInt(Me.lblidGasto.Text), False)
                End If
                Me.RefrescarGrilla()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView7_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView7.CurrentCellChanged
        Try
            Me.lblidGasto.Text = CStr(Me.DataGridView7.Item(0, Me.DataGridView7.CurrentRow.Index).Value)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dpBanco_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dpBanco.KeyPress
        If e.KeyChar.ToString = vbCr Then
            If Me.lblidEmpresa.Text = "" Then
                Exit Sub
            End If
            Me.Cheques.Focus()
            Me.RefrescarGrilla()

        Else
            '    e.Handled = True
        End If
    End Sub

    Private Sub dpBanco_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dpBanco.ValueChanged
        If Me.lblidEmpresa.Text = "" Then
            Exit Sub
        End If

        RefrescarGrilla()
        Me.ControlarEnabled()
    End Sub

    Private Sub btnGenerarResumen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarResumen.Click
        Dim odt8 As New DataTable("ResumenCuenta")
        Dim i As Integer
        Dim s As Decimal
        Dim j As Integer
        Try
            'Me.lblSaldoActual.Text = ""
            oResumenCuenta.GenerarResumen(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text))
            oResumenCuenta.GenerarResumenTotal(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidCuenta.Text), CInt(Me.lblidBanco.Text))
            odt8 = oResumenCuenta.ConsultarResumen(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text))

            Me.lblSaldoActual.Text = ""

            j = odt8.Rows.Count - 1
            For i = 0 To odt8.Rows.Count - 1
                s = CDec(odt8.Rows(i).Item("saldo").ToString)
                If i = 0 Then
                    s = CDec(s) + CDec(Me.lblSaldoAnterior.Text)
                Else
                    s = s + CDec(odt8.Rows(i - 1).Item("saldo").ToString)
                End If
                odt8.Rows(i).Item("saldo") = s
            Next
            If j < 0 Then

                'bug de los saldos
                Me.lblTotalGrilla.Text = Me.lblSaldoAnterior.Text

                Exit Sub
            End If
            'Me.lblSaldoActual.Text = odt8.Rows(j).Item("saldo").ToString
            oResumenCuenta.Update()
            oResumenCuenta.Guardar()
            Me.DataGridView8.DataSource = odt8
            Me.DataGridView8.Columns(0).Visible = False
            'Me.lblSaldoAnterior.Text = odt8.Columns("s").ToString
            'agrega el saldo al total de la grilla
            Me.lblTotalGrilla.Text = CStr(s)

        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub

    'coloca el rojo en la celdas negativas
    Private Sub dataGridView8_CellFormatting(ByVal sender As Object, _
    ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) _
        Handles DataGridView8.CellFormatting
        If DataGridView8.Columns(e.ColumnIndex).Name.Equals("SALDO") Then
            'Dim intValue As Int32
            If CInt(e.Value) < 0 Then
                'if Int32.TryParse((String)e.Value, out intValue) && 
                '   (intValue < 0))
                e.CellStyle.ForeColor = Color.Red
                e.CellStyle.SelectionBackColor = Color.DarkRed
            End If
        End If
    End Sub

    Private Sub btnCierrePeriodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCierrePeriodo.Click
        Dim odt8 As New DataTable("ResumenCuenta")
        Dim i As Integer
        Dim s As Decimal = 0
        Dim j As Integer
        Try
            Me.lblSaldoActual.Text = ""
            oResumenCuenta.GenerarResumen(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text))
            oResumenCuenta.GenerarResumenTotal(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidCuenta.Text), CInt(Me.lblidBanco.Text))
            odt8 = oResumenCuenta.ConsultarResumen(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text))

            '  Me.lblSaldoActual.Text = ""
            j = odt8.Rows.Count - 1
            For i = 0 To odt8.Rows.Count - 1
                s = CDec(odt8.Rows(i).Item("saldo").ToString)
                If i = 0 Then
                    s = CDec(s) + CDec(Me.lblSaldoAnterior.Text)
                Else
                    s = s + CDec(odt8.Rows(i - 1).Item("saldo").ToString)
                End If
                odt8.Rows(i).Item("saldo") = s
            Next

            'comentado para poder cerrar un período sin movimientos.
            'If j < 0 Then
            '    'Exit Sub
            'End If
            '    Me.lblSaldoActual.Text = odt8.Rows(j).Item("saldo").ToString
            oResumenCuenta.Update()
            oResumenCuenta.Guardar()
            Me.DataGridView8.DataSource = odt8
            Me.DataGridView8.Columns(0).Visible = False

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Me.lblTotalGrilla.Text = CStr(s)

        If oSaldoBanco.ControlarSaldo(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value, CInt(Me.lblidCuenta.Text)) Then
            If MessageBox.Show("Desea Realmente Cerrar el Periodo", "Cierre del Periodo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            Else
                oSaldoBanco.Cargar()
                oSaldoBanco.Insertar()
                oSaldoBanco.id_empresa = CInt(Me.lblidEmpresa.Text)
                oSaldoBanco.id_cuenta = CInt(Me.lblidCuenta.Text)
                oSaldoBanco.fecha_saldo = Me.dpBanco.Value
                oSaldoBanco.saldo = CDec(Me.lblTotalGrilla.Text)
                oSaldoBanco.Guardar()
                Me.ControlarEnabled()
            End If
        Else
            If MessageBox.Show("El Periodo ya Esta Cerrado Desea Modificarlo", "Cierre del Periodo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            Else
                oSaldoBanco.Cargar()
                oSaldoBanco.Modificar(oSaldoBanco.ConsultarSaldoActual(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value, CInt(Me.lblidCuenta.Text)))
                '  Me.CalcularDeclaracion()
                oSaldoBanco.id_empresa = CInt(Me.lblidEmpresa.Text)
                oSaldoBanco.id_cuenta = CInt(Me.lblidCuenta.Text)
                oSaldoBanco.fecha_saldo = Me.dpBanco.Value
                oSaldoBanco.saldo = CDec(Me.lblTotalGrilla.Text)
                oSaldoBanco.Guardar()
                Me.ControlarEnabled()
            End If
        End If
        ' Me.EstadoCierre()
    End Sub


    Private Sub btnModificarPeriodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarPeriodo.Click
        If oSaldoBanco.ControlarSaldo(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidCuenta.Text)) Then
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



    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim frmdetalle1 As New Frmchequerecibido 'esta
        Dim frmdetalle2 As New Frmchequelibrado   'esta
        Dim frmdetalle3 As New Frmtransfbancaria    't
        Dim frmdetalle4 As New Frmcredextra         't
        Dim frmdetalle5 As New Frmdebextra          't
        Dim frmdetalle6 As New Frmdepefectivo       't
        Dim frmdetalle7 As New Frmgtosbanco         'ok
        If Me.lblidEmpresa.Text = "" Then
            Exit Sub
        End If
        Try
            Select Case Me.Cheques.SelectedTab.Name
                Case "recibidos"
                    BanderaCheque = 1
                    oChequeRecibido.Insertar()
                    Me.AddOwnedForm(frmdetalle1)
                    frmdetalle1.CargarProvincia()
                    frmdetalle1.CargarCliente()
                    frmdetalle1.CargarBancoCheque()
                    frmdetalle1.ShowDialog()
                Case "librados"
                    BanderaCheque = 2
                    oChequeLibrado.Insertar()
                    Me.AddOwnedForm(frmdetalle2)

                    frmdetalle2.lblid_cuenta.Text = Me.lblidCuenta.Text
                    frmdetalle2.CargarCombos()
                    frmdetalle2.ShowDialog()
                Case "Transferencia"
                    BanderaCheque = 3
                    oTransferenciaBancaria.Insertar()
                    Me.AddOwnedForm(frmdetalle3)
                    frmdetalle3.CargarBancoOrigen()
                    frmdetalle3.CargarCliente()
                    frmdetalle3.ShowDialog()
                Case "Credextra"
                    BanderaCheque = 4
                    oCredito.Insertar()
                    Me.AddOwnedForm(frmdetalle4)
                    frmdetalle4.ShowDialog()
                Case "Debextra"
                    BanderaCheque = 5
                    oDebito.Insertar()
                    Me.AddOwnedForm(frmdetalle5)
                    frmdetalle5.ShowDialog()
                Case "DepEfect"
                    BanderaCheque = 6
                    oDepositoEfectivo.Insertar()
                    Me.AddOwnedForm(frmdetalle6)
                    frmdetalle6.ShowDialog()
                Case "Gtosbanco"
                    BanderaCheque = 7
                    oGasto.Insertar()
                    Me.AddOwnedForm(frmdetalle7)
                    frmdetalle7.ShowDialog()
            End Select
            Me.Cheques.Focus()
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        If Me.lblidEmpresa.Text = "" Then
            Exit Sub
        End If

        Select Case Me.Cheques.SelectedTab.Name
            Case "recibidos"
                If Me.lblidChequeRecibido.Text <> "" Then
                    oChequeRecibido.Borrar(CInt(Me.lblidChequeRecibido.Text))
                End If
            Case "Transferencia"
                If Me.lblidTransferenciaBancaria.Text <> "" Then
                    oTransferenciaBancaria.Borrar(CInt(Me.lblidTransferenciaBancaria.Text))
                End If
            Case "librados"
                If Me.lblidChequeLibrado.Text <> "" Then
                    oChequeLibrado.Borrar(CInt(Me.lblidChequeLibrado.Text))
                End If
            Case "Credextra"
                If Me.lblidCredito.Text <> "" Then
                    oCredito.Borrar(CInt(Me.lblidCredito.Text))
                End If
            Case "Debextra"
                If Me.lblidDebito.Text <> "" Then
                    oDebito.Borrar(CInt(Me.lblidDebito.Text))
                End If
            Case "DepEfect"
                If Me.lblidDepositoEfectivo.Text <> "" Then
                    oDepositoEfectivo.Borrar(CInt(Me.lblidDepositoEfectivo.Text))
                End If
            Case "Gtosbanco"
                If Me.lblidGasto.Text <> "" Then
                    oGasto.Borrar(CInt(Me.lblidGasto.Text))
                End If
        End Select

        RefrescarGrilla()
        Me.Cheques.Focus()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim frmdetalle1 As New Frmchequerecibido
        Dim frmdetalle2 As New Frmchequelibrado
        Dim frmdetalle3 As New Frmtransfbancaria
        Dim frmdetalle4 As New Frmcredextra
        Dim frmdetalle5 As New Frmdebextra
        Dim frmdetalle6 As New Frmdepefectivo
        Dim frmdetalle7 As New Frmgtosbanco

        If Me.lblidEmpresa.Text = "" Then
            Exit Sub
        End If

        Try
            Select Case Me.Cheques.SelectedTab.Name
                Case "recibidos"
                    BanderaCheque = 11
                    If Me.lblidChequeRecibido.Text <> "" Then
                        oChequeRecibido.Modificar(CInt(Me.lblidChequeRecibido.Text))
                        frmdetalle1.CargarProvincia()
                        frmdetalle1.CargarCliente()
                        frmdetalle1.CargarBancoCheque()
                        Me.AddOwnedForm(frmdetalle1)
                        frmdetalle1.ShowDialog()
                    End If
                Case "librados"
                    BanderaCheque = 22
                    If Me.lblidChequeLibrado.Text <> "" Then
                        oChequeLibrado.Modificar(CInt(Me.lblidChequeLibrado.Text))

                        frmdetalle2.lblid_cuenta.Text = Me.lblidCuenta.Text
                        frmdetalle2.CargarCombos()
                        Me.AddOwnedForm(frmdetalle2)
                        frmdetalle2.ShowDialog()
                    End If
                Case "Transferencia"
                    BanderaCheque = 33
                    If Me.lblidTransferenciaBancaria.Text <> "" Then
                        oTransferenciaBancaria.Modificar(CInt(Me.lblidTransferenciaBancaria.Text))
                        Me.AddOwnedForm(frmdetalle3)
                        frmdetalle3.CargarBancoOrigen()
                        frmdetalle3.ShowDialog()
                    End If
                Case "Credextra"
                    BanderaCheque = 44
                    If Me.lblidCredito.Text <> "" Then
                        oCredito.Modificar(CInt(Me.lblidCredito.Text))
                        Me.AddOwnedForm(frmdetalle4)
                        frmdetalle4.ShowDialog()
                    End If
                Case "Debextra"
                    BanderaCheque = 55
                    If Me.lblidDebito.Text <> "" Then
                        oDebito.Modificar(CInt(Me.lblidDebito.Text))
                        Me.AddOwnedForm(frmdetalle5)
                        frmdetalle5.ShowDialog()
                    End If
                Case "DepEfect"
                    BanderaCheque = 66
                    If Me.lblidDepositoEfectivo.Text <> "" Then
                        oDepositoEfectivo.Modificar(CInt(Me.lblidDepositoEfectivo.Text))
                        Me.AddOwnedForm(frmdetalle6)
                        frmdetalle6.ShowDialog()
                    End If
                Case "Gtosbanco"
                    BanderaCheque = 77
                    If Me.lblidGasto.Text <> "" Then
                        oGasto.Modificar(CInt(Me.lblidGasto.Text))
                        Me.AddOwnedForm(frmdetalle7)
                        frmdetalle7.ShowDialog()
                    End If
            End Select
            Me.Cheques.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        RefrescarGrilla()
        Me.Cheques.Focus()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()

        ' Me.Dispose()
    End Sub

    Private Sub btnAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'System.Diagnostics.Process.Start(PathAyuda + "Frmmovbancos.htm")
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscaEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaEmpresa.Click
        Dim frmTemp As New frmAbmEmpresa
        frmTemp.ShowDialog()
        Me.CargarEmpresa()
        Me.cmbEmpresa.Focus()
        Me.cmbEmpresa.Text = ""
        Me.lblidEmpresa.Text = "0"
        Me.cmbCuenta.Text = ""
        Me.lblidCuenta.Text = "0"
    End Sub

    Private Sub btnBcos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBcos.Click
        Dim frmTemp As New frmAbmBanco
        frmTemp.ShowDialog()
        Me.CargarBanco()
        Me.Cmbbanco.Focus()
        Me.Cmbbanco.Text = ""
        Me.lblidBanco.Text = "0"
        Me.cmbCuenta.Text = ""
        Me.lblidCuenta.Text = "0"
    End Sub

    Private Sub btnCuentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuentas.Click
        Dim frmTemp As New frmAbmCuentas
        frmTemp.ShowDialog()
        Me.Cmbbanco.Focus()
        Me.cmbCuenta.Text = ""
        Me.lblidCuenta.Text = "0"
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        Try
            Select Case BanderaConsultaMovimiento
                Case 1 ' CHEQUES LIBRADOS
                    Select Case BanderaConsultaTipo
                        Case 1 'ENTRE FECHAS
                            odtConsultaBancos = oChequeLibrado.ConsultarEntreFechas(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text), Me.dpInicio.Value.Date, Me.dpFin.Value.Date)
                            parametro_banco = CInt(Me.lblidBanco.Text)
                            parametro_empresa = CInt(Me.lblidEmpresa.Text)
                            parametro_cuenta = CInt(Me.lblidCuenta.Text)
                            parametro_fecha = Me.dpBanco.Value.Date
                            parametro_fecha_inicio = Me.dpInicio.Value.Date
                            parametro_fecha_fin = Me.dpFin.Value.Date
                            parametro_nombre_cuenta = Me.cmbCuenta.Text
                            parametro_nombre_banco = Me.Cmbbanco.Text
                            Banderaprint = "resumen_librado"


                        Case 2 'FECHA PAGO
                            odtConsultaBancos = oChequeLibrado.ConsultarPorFechaPago(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text), Me.dpFecha.Value.Date, Me.dtpFechaFin.Value.Date)
                            parametro_banco = CInt(Me.lblidBanco.Text)
                            parametro_empresa = CInt(Me.lblidEmpresa.Text)
                            parametro_cuenta = CInt(Me.lblidCuenta.Text)
                            parametro_fecha = Me.dpBanco.Value.Date
                            parametro_fecha_fin = Me.dpFecha.Value.Date
                            parametro_nombre_cuenta = Me.lblidCuenta.Text
                            parametro_nombre_banco = Me.lblidBanco.Text
                            Banderaprint = "resumen_librado_pago"


                        Case 3 'FECHA EMISION
                            odtConsultaBancos = oChequeLibrado.ConsultarPorFechaLibrado(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text), Me.dpFecha.Value.Date, Me.dtpFechaFin.Value.Date)
                            parametro_banco = CInt(Me.lblidBanco.Text)
                            parametro_empresa = CInt(Me.lblidEmpresa.Text)
                            parametro_cuenta = CInt(Me.lblidCuenta.Text)
                            parametro_fecha = Me.dpBanco.Value.Date
                            parametro_fecha_fin = Me.dpFecha.Value.Date
                            parametro_nombre_cuenta = Me.lblidCuenta.Text
                            parametro_nombre_banco = Me.lblidBanco.Text
                            Banderaprint = "resumen_librado_Librado"

                        Case 4 'PROVEEDOR
                            odtConsultaBancos = oChequeLibrado.ConsultarPorProveedor(CInt(Me.lblidEmpresa.Text), Me.dpDesde.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text), CInt(Me.lblidCliente.Text))
                            parametro_banco = CInt(Me.lblidBanco.Text)
                            parametro_empresa = CInt(Me.lblidEmpresa.Text)
                            parametro_cuenta = CInt(Me.lblidCuenta.Text)
                            parametro_fecha = Me.dpDesde.Value.Date
                            parametro_Proveedor = CInt(Me.lblidCliente.Text)
                            parametro_nombre_cuenta = Me.lblidCuenta.Text
                            parametro_nombre_banco = Me.lblidBanco.Text
                            Banderaprint = "resumen_librado_proveedor"


                        Case 5 'NUMERO CHEQUE
                            odtConsultaBancos = oChequeLibrado.ConsultarPorNumero(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text), Me.txtConsultaNumero.Text)
                            parametro_banco = CInt(Me.lblidBanco.Text)
                            parametro_empresa = CInt(Me.lblidEmpresa.Text)
                            parametro_cuenta = CInt(Me.lblidCuenta.Text)

                            parametro_fecha = Me.dpBanco.Value.Date
                            parametro_nro_cheque = Me.txtConsultaNumero.Text.Trim
                            Banderaprint = "resumen_librado_numero"

                    End Select
                Case 2 'CHEQUES RECIBIDOS
                    Select Case BanderaConsultaTipo
                        Case 1 'ENTRE FECHAS
                            odtConsultaBancos = oChequeRecibido.ConsultarEntreFechas(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text), Me.dpInicio.Value.Date, Me.dpFin.Value.Date)
                            parametro_banco = CInt(Me.lblidBanco.Text)
                            parametro_empresa = CInt(Me.lblidEmpresa.Text)
                            parametro_cuenta = CInt(Me.lblidCuenta.Text)
                            parametro_fecha_inicio = Me.dpInicio.Value.Date
                            parametro_fecha_fin = Me.dpFin.Value.Date



                            Banderaprint = "Cheques_recibidos_entrefechas"

                        Case 2 'FECHA COBRO
                            odtConsultaBancos = oChequeRecibido.ConsultarPorFechaCobro(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text), Me.dpFecha.Value.Date, Me.dtpFechaFin.Value.Date)
                            parametro_banco = CInt(Me.lblidBanco.Text)
                            parametro_empresa = CInt(Me.lblidEmpresa.Text)
                            parametro_cuenta = CInt(Me.lblidCuenta.Text)
                            parametro_fecha_inicio = Me.dpFecha.Value.Date
                            parametro_fecha_fin = Me.dpFin.Value.Date



                            Banderaprint = "Cheques_recibidos_fechacobro"




                        Case 3 'FECHA RECIBIDO
                            odtConsultaBancos = oChequeRecibido.ConsultarPorFechaRecibido(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text), Me.dpFecha.Value.Date, Me.dtpFechaFin.Value.Date)
                            parametro_banco = CInt(Me.lblidBanco.Text)
                            parametro_empresa = CInt(Me.lblidEmpresa.Text)
                            parametro_cuenta = CInt(Me.lblidCuenta.Text)
                            parametro_fecha_inicio = Me.dpFecha.Value.Date
                            parametro_fecha_fin = Me.dpFin.Value.Date
                            Banderaprint = "Cheques_recibidos_fecharecibido"

                        Case 4 'CLIENTE
                            odtConsultaBancos = oChequeRecibido.ConsultarPorCliente(CInt(Me.lblidEmpresa.Text), Me.dpDesde.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text), CInt(Me.lblidCliente.Text))
                            parametro_banco = CInt(Me.lblidBanco.Text)
                            parametro_empresa = CInt(Me.lblidEmpresa.Text)
                            parametro_cuenta = CInt(Me.lblidCuenta.Text)
                            parametro_fecha = Me.dpDesde.Value.Date
                            parametro_id_cliente = CInt(Me.lblidCliente.Text)
                            Banderaprint = "Cheques_recibidos_cliente"

                        Case 5 'NUMERO CHEQUE
                            odtConsultaBancos = oChequeRecibido.ConsultarPorNumero(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text), Me.txtConsultaNumero.Text)
                            parametro_banco = CInt(Me.lblidBanco.Text)
                            parametro_empresa = CInt(Me.lblidEmpresa.Text)
                            parametro_cuenta = CInt(Me.lblidCuenta.Text)

                            parametro_nro_cheque = Me.txtConsultaNumero.Text
                            Banderaprint = "Cheques_recibidos_numero"




                    End Select
                Case 3 'TRANSFERENCIAS
                    Select Case BanderaConsultaTipo
                        Case 1 'ENTRE FECHAS
                            odtConsultaBancos = oTransferenciaBancaria.ConsultarEntreFechas(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text), Me.dpInicio.Value.Date, Me.dpFin.Value.Date)
                            odtConsultaBancos = oTransferenciaBancaria.Get_AllQuery(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text), Me.dpInicio.Value.Date, Me.dpFin.Value.Date, "00010000001", DateTime.Now, 2, True)
                            parametro_banco = CInt(Me.lblidBanco.Text)
                            parametro_empresa = CInt(Me.lblidEmpresa.Text)
                            parametro_cuenta = CInt(Me.lblidCuenta.Text)
                            parametro_fecha = Me.dpBanco.Value.Date
                            parametro_fecha_inicio = Me.dpInicio.Value.Date
                            parametro_fecha_fin = Me.dpFin.Value.Date
                            parametro_bandera_query_trasferencias = 2
                            parametro_nro_transferencia = "000100000001"
                            parametro_con_fecha = True
                            parametro_fecha_pago = DateTime.Now
                            parametro_numero_cuenta = oCuenta.GetOne(CInt(Me.lblidCuenta.Text)).Rows(0).Item("numero").ToString()
                            parametro_nombre_banco = oBanco.GetOne(CInt(Me.lblidBanco.Text)).Rows(0).Item("nombre_banco").ToString()


                            'Banderaprint = "Transferencias_entrefechas"
                            Banderaprint = "Transferencias_query"


                        Case 5 'NUMERO
                            odtConsultaBancos = oTransferenciaBancaria.ConsultarPorNumero(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text), Me.txtConsultaNumero.Text)
                            odtConsultaBancos = oTransferenciaBancaria.Get_AllQuery(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text), Me.dpInicio.Value.Date, Me.dpFin.Value.Date, Me.txtConsultaNumero.Text.Trim, DateTime.Now, 4, False)
                            parametro_banco = CInt(Me.lblidBanco.Text)
                            parametro_empresa = CInt(Me.lblidEmpresa.Text)
                            parametro_cuenta = CInt(Me.lblidCuenta.Text)
                            parametro_fecha = Me.dpBanco.Value.Date
                            parametro_fecha_inicio = Me.dpInicio.Value.Date
                            parametro_fecha_fin = Me.dpFin.Value.Date
                            parametro_bandera_query_trasferencias = 4

                            parametro_con_fecha = False
                            parametro_fecha_pago = DateTime.Now
                            parametro_numero_cuenta = oCuenta.GetOne(CInt(Me.lblidCuenta.Text)).Rows(0).Item("numero").ToString()
                            parametro_nombre_banco = oBanco.GetOne(CInt(Me.lblidBanco.Text)).Rows(0).Item("nombre_banco").ToString()

                            parametro_nro_transferencia = Me.txtConsultaNumero.Text.Trim
                            'Banderaprint = "Transferencias_numero"
                            Banderaprint = "Transferencias_query"

                    End Select

                    '''realizado 29 septiembre

                Case 4 'DEPOSITOS
                    Select Case BanderaConsultaTipo
                        Case 1 'ENTRE FECHAS
                            'odtConsultaBancos = oDepositoEfectivo.ConsultarEntreFechas(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text), Me.dpInicio.Value.Date, Me.dpFin.Value.Date)
                            odtConsultaBancos = oDepositoEfectivo.Get_AllQuery(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text), Me.dpInicio.Value.Date, Me.dpFin.Value.Date, "00010000001", DateTime.Now, 2, True)
                            parametro_banco = CInt(Me.lblidBanco.Text)
                            parametro_empresa = CInt(Me.lblidEmpresa.Text)
                            parametro_cuenta = CInt(Me.lblidCuenta.Text)
                            parametro_fecha = Me.dpBanco.Value.Date
                            parametro_fecha_inicio = Me.dpInicio.Value.Date
                            parametro_fecha_fin = Me.dpFin.Value.Date
                            parametro_bandera_query_trasferencias = 2
                            parametro_nro_transferencia = "000100000001"
                            parametro_con_fecha = True
                            parametro_fecha_pago = DateTime.Now
                            parametro_numero_cuenta = oCuenta.GetOne(CInt(Me.lblidCuenta.Text)).Rows(0).Item("numero").ToString()
                            parametro_nombre_banco = oBanco.GetOne(CInt(Me.lblidBanco.Text)).Rows(0).Item("nombre_banco").ToString()
                            Banderaprint = "Deposito_query"


                        Case 5 'NUMERO
                            ''modificar ahora 
                            'odtConsultaBancos = oDepositoEfectivo.ConsultarPorNumero(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text), Me.txtConsultaNumero.Text)
                            odtConsultaBancos = oDepositoEfectivo.Get_AllQuery(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text), Me.dpInicio.Value.Date, Me.dpFin.Value.Date, Me.txtConsultaNumero.Text.Trim, DateTime.Now, 4, False)

                            parametro_banco = CInt(Me.lblidBanco.Text)
                            parametro_empresa = CInt(Me.lblidEmpresa.Text)
                            parametro_cuenta = CInt(Me.lblidCuenta.Text)
                            parametro_fecha = Me.dpBanco.Value.Date
                            parametro_fecha_inicio = Me.dpInicio.Value.Date
                            parametro_fecha_fin = Me.dpFin.Value.Date
                            parametro_bandera_query_trasferencias = 4

                            parametro_con_fecha = False
                            parametro_fecha_pago = DateTime.Now
                            parametro_numero_cuenta = oCuenta.GetOne(CInt(Me.lblidCuenta.Text)).Rows(0).Item("numero").ToString()
                            parametro_nombre_banco = oBanco.GetOne(CInt(Me.lblidBanco.Text)).Rows(0).Item("nombre_banco").ToString()

                            parametro_nro_transferencia = Me.txtConsultaNumero.Text.Trim
                            ''Banderaprint = "Transferencias_numero"
                            Banderaprint = "Deposito_query"


                    End Select
                Case 5 'CREDITOS
                    'modificado 29 septiembre
                    Select Case BanderaConsultaTipo
                        Case 1 'ENTRE FECHAS
                            ' odtConsultaBancos = oCredito.ConsultarEntreFechas(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text), Me.dpInicio.Value.Date, Me.dpFin.Value.Date)

                            odtConsultaBancos = oCredito.Get_AllQuery(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text), Me.dpInicio.Value.Date, Me.dpFin.Value.Date, "00010000001", DateTime.Now, 2, True)
                            parametro_banco = CInt(Me.lblidBanco.Text)
                            parametro_empresa = CInt(Me.lblidEmpresa.Text)
                            parametro_cuenta = CInt(Me.lblidCuenta.Text)
                            parametro_fecha = Me.dpBanco.Value.Date
                            parametro_fecha_inicio = Me.dpInicio.Value.Date
                            parametro_fecha_fin = Me.dpFin.Value.Date
                            parametro_bandera_query_trasferencias = 2
                            parametro_nro_transferencia = "000100000001"
                            parametro_con_fecha = True
                            parametro_fecha_pago = DateTime.Now
                            parametro_numero_cuenta = oCuenta.GetOne(CInt(Me.lblidCuenta.Text)).Rows(0).Item("numero").ToString()
                            parametro_nombre_banco = oBanco.GetOne(CInt(Me.lblidBanco.Text)).Rows(0).Item("nombre_banco").ToString()
                            Banderaprint = "Creditos_query"

                            'Case 2 'FECHA 
                            '    odtConsultaBancos = oCredito.ConsultarPorFecha(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text), Me.dpFecha.Value.Date)
                        Case 5 'NUMERO
                            'odtConsultaBancos = oCredito.ConsultarPorNumero(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text), Me.txtConsultaNumero.Text)

                            odtConsultaBancos = oCredito.Get_AllQuery(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text), Me.dpInicio.Value.Date, Me.dpFin.Value.Date, Me.txtConsultaNumero.Text.Trim, DateTime.Now, 4, False)

                            parametro_banco = CInt(Me.lblidBanco.Text)
                            parametro_empresa = CInt(Me.lblidEmpresa.Text)
                            parametro_cuenta = CInt(Me.lblidCuenta.Text)
                            parametro_fecha = Me.dpBanco.Value.Date
                            parametro_fecha_inicio = Me.dpInicio.Value.Date
                            parametro_fecha_fin = Me.dpFin.Value.Date
                            parametro_bandera_query_trasferencias = 4

                            parametro_con_fecha = False
                            parametro_fecha_pago = DateTime.Now
                            parametro_numero_cuenta = oCuenta.GetOne(CInt(Me.lblidCuenta.Text)).Rows(0).Item("numero").ToString()
                            parametro_nombre_banco = oBanco.GetOne(CInt(Me.lblidBanco.Text)).Rows(0).Item("nombre_banco").ToString()

                            parametro_nro_transferencia = Me.txtConsultaNumero.Text.Trim
                            ''Banderaprint = "Transferencias_numero"
                            Banderaprint = "Creditos_query"

                    End Select

                Case 6 'DEBITOS
                    Select Case BanderaConsultaTipo
                        Case 1 'ENTRE FECHAS
                            ' odtConsultaBancos = oDebito.ConsultarEntreFechas(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text), Me.dpInicio.Value.Date, Me.dpFin.Value.Date)

                            odtConsultaBancos = oDebito.Get_AllQuery(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text), Me.dpInicio.Value.Date, Me.dpFin.Value.Date, "00010000001", DateTime.Now, 2, True)
                            parametro_banco = CInt(Me.lblidBanco.Text)
                            parametro_empresa = CInt(Me.lblidEmpresa.Text)
                            parametro_cuenta = CInt(Me.lblidCuenta.Text)
                            parametro_fecha = Me.dpBanco.Value.Date
                            parametro_fecha_inicio = Me.dpInicio.Value.Date
                            parametro_fecha_fin = Me.dpFin.Value.Date
                            parametro_bandera_query_trasferencias = 2
                            parametro_nro_transferencia = "000100000001"
                            parametro_con_fecha = True
                            parametro_fecha_pago = DateTime.Now
                            parametro_numero_cuenta = oCuenta.GetOne(CInt(Me.lblidCuenta.Text)).Rows(0).Item("numero").ToString()
                            parametro_nombre_banco = oBanco.GetOne(CInt(Me.lblidBanco.Text)).Rows(0).Item("nombre_banco").ToString()
                            Banderaprint = "Debitos_query"
                        Case 5 'NUMERO
                            ' odtConsultaBancos = oDebito.ConsultarPorNumero(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text), Me.txtConsultaNumero.Text)

                            odtConsultaBancos = oDebito.Get_AllQuery(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text), Me.dpInicio.Value.Date, Me.dpFin.Value.Date, Me.txtConsultaNumero.Text.Trim, DateTime.Now, 4, False)
                            parametro_banco = CInt(Me.lblidBanco.Text)
                            parametro_empresa = CInt(Me.lblidEmpresa.Text)
                            parametro_cuenta = CInt(Me.lblidCuenta.Text)
                            parametro_fecha = Me.dpBanco.Value.Date
                            parametro_fecha_inicio = Me.dpInicio.Value.Date
                            parametro_fecha_fin = Me.dpFin.Value.Date
                            parametro_bandera_query_trasferencias = 4

                            parametro_con_fecha = False
                            parametro_fecha_pago = DateTime.Now
                            parametro_numero_cuenta = oCuenta.GetOne(CInt(Me.lblidCuenta.Text)).Rows(0).Item("numero").ToString()
                            parametro_nombre_banco = oBanco.GetOne(CInt(Me.lblidBanco.Text)).Rows(0).Item("nombre_banco").ToString()

                            parametro_nro_transferencia = Me.txtConsultaNumero.Text.Trim
                            ''Banderaprint = "Transferencias_numero"
                            Banderaprint = "Debitos_query"
                    End Select

                Case 7 'GASTOS
                    Select Case BanderaConsultaTipo
                        Case 1 'ENTRE FECHAS
                            ' odtConsultaBancos = oGasto.ConsultarEntreFechas(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text), Me.dpInicio.Value.Date, Me.dpFin.Value.Date)

                            odtConsultaBancos = oGasto.Get_AllQuery(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text), Me.dpInicio.Value.Date, Me.dpFin.Value.Date, "00010000001", DateTime.Now, 2, True)
                            parametro_banco = CInt(Me.lblidBanco.Text)
                            parametro_empresa = CInt(Me.lblidEmpresa.Text)
                            parametro_cuenta = CInt(Me.lblidCuenta.Text)
                            parametro_fecha = Me.dpBanco.Value.Date
                            parametro_fecha_inicio = Me.dpInicio.Value.Date
                            parametro_fecha_fin = Me.dpFin.Value.Date
                            parametro_bandera_query_trasferencias = 2
                            parametro_nro_transferencia = "000100000001"
                            parametro_con_fecha = True
                            parametro_fecha_pago = DateTime.Now
                            parametro_numero_cuenta = oCuenta.GetOne(CInt(Me.lblidCuenta.Text)).Rows(0).Item("numero").ToString()
                            parametro_nombre_banco = oBanco.GetOne(CInt(Me.lblidBanco.Text)).Rows(0).Item("nombre_banco").ToString()
                            Banderaprint = "Gastos_query"
                        Case 2 'FECHA 
                            odtConsultaBancos = oGasto.ConsultarPorFecha(CInt(Me.lblidEmpresa.Text), Me.dpBanco.Value.Date, CInt(Me.lblidBanco.Text), CInt(Me.lblidCuenta.Text), Me.dpFecha.Value.Date)
                    End Select
            End Select

            frmConsultaBancos.ShowDialog()
        Catch ex As Exception
            '  MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub optChequeLibrado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optChequeLibrado.CheckedChanged
        If Me.optChequeLibrado.Checked = True Then
            Me.CargarProveedor()
            Me.optCliente.Text = "Por Proveedor"
            Me.optFecha.Text = "Por Fecha de Pago"
            Me.optFecha2.Text = "De Emisión"
            Me.optCliente.Visible = True
            Me.dpDesde.Visible = True
            '  Me.dtpFechaFin.Visible = True
            Me.Label14.Visible = True
            Me.cmbCliente.Visible = True
            Me.cmbCliente.Text = ""
            Me.optNumero.Visible = True
            Me.txtConsultaNumero.Visible = True
            '  Me.optFecha2.Visible = True
            Me.optEntreFechas.Checked = True
            BanderaConsultaMovimiento = 1
        End If
    End Sub

    Private Sub optChequeRecibido_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optChequeRecibido.CheckedChanged
        If Me.optChequeRecibido.Checked = True Then
            Me.CargarCliente()
            Me.optCliente.Text = "Por Cliente"
            Me.optFecha.Text = "Por Fecha de Cobro"
            Me.optFecha2.Text = "De Recibido"
            Me.optCliente.Visible = True
            Me.dpDesde.Visible = True
            '  Me.dtpFechaFin.Visible = True
            Me.Label14.Visible = True
            Me.cmbCliente.Visible = True
            Me.cmbCliente.Text = ""
            Me.optNumero.Visible = True
            Me.txtConsultaNumero.Visible = True
            '   Me.optFecha2.Visible = True
            Me.optEntreFechas.Checked = True
            BanderaConsultaMovimiento = 2
        End If
    End Sub

    Private Sub optTransferencia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optTransferencia.CheckedChanged
        If Me.optTransferencia.Checked = True Then
            Me.optCliente.Visible = False
            Me.dpDesde.Visible = False

            Me.Label14.Visible = False
            Me.cmbCliente.Visible = False
            Me.optNumero.Visible = True
            Me.txtConsultaNumero.Visible = True
            Me.optFecha2.Visible = False
            Me.optFecha.Text = "Por Fecha"
            Me.optEntreFechas.Checked = True
            BanderaConsultaMovimiento = 3
        End If
    End Sub

    Private Sub optDeposito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optDeposito.CheckedChanged
        If Me.optDeposito.Checked = True Then
            Me.optCliente.Visible = False
            Me.dpDesde.Visible = False

            Me.Label14.Visible = False
            Me.cmbCliente.Visible = False
            Me.optNumero.Visible = True
            Me.txtConsultaNumero.Visible = True
            Me.optFecha2.Visible = False
            Me.optFecha.Text = "Por Fecha"
            Me.optEntreFechas.Checked = True
            BanderaConsultaMovimiento = 4
        End If
    End Sub

    Private Sub optCredito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optCredito.CheckedChanged
        If Me.optCredito.Checked = True Then
            Me.optCliente.Visible = False
            Me.dpDesde.Visible = False

            Me.Label14.Visible = False
            Me.cmbCliente.Visible = False
            Me.optNumero.Visible = True
            Me.txtConsultaNumero.Visible = True
            Me.optFecha2.Visible = False
            Me.optFecha.Text = "Por Fecha"
            Me.optEntreFechas.Checked = True
            BanderaConsultaMovimiento = 5
        End If
    End Sub

    Private Sub optDebito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optDebito.CheckedChanged
        If Me.optDebito.Checked = True Then
            Me.optCliente.Visible = False
            Me.dpDesde.Visible = False

            Me.Label14.Visible = False
            Me.cmbCliente.Visible = False
            Me.optNumero.Visible = True
            Me.txtConsultaNumero.Visible = True
            Me.optFecha2.Visible = False
            Me.optFecha.Text = "Por Fecha"
            Me.optEntreFechas.Checked = True
            BanderaConsultaMovimiento = 6
        End If
    End Sub

    Private Sub optGasto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optGasto.CheckedChanged
        If Me.optGasto.Checked = True Then
            Me.optCliente.Visible = False
            Me.dpDesde.Visible = False

            Me.Label14.Visible = False
            Me.cmbCliente.Visible = False
            Me.optNumero.Visible = False
            Me.txtConsultaNumero.Visible = False
            Me.optFecha2.Visible = False
            Me.optFecha.Text = "Por Fecha"
            Me.optEntreFechas.Checked = True
            BanderaConsultaMovimiento = 7
        End If
    End Sub

    Private Sub optEntreFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optEntreFechas.CheckedChanged
        If Me.optEntreFechas.Checked = True Then
            Me.dpInicio.Enabled = True
            Me.dpFin.Enabled = True
            Me.dpFecha.Enabled = False
            Me.dtpFechaFin.Enabled = False
            Me.dpDesde.Enabled = False
            Me.cmbCliente.Enabled = False
            Me.txtConsultaNumero.Enabled = False
            BanderaConsultaTipo = 1
        End If
    End Sub

    Private Sub optFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optFecha.CheckedChanged
        If Me.optFecha.Checked = True Then
            Me.dpInicio.Enabled = False
            Me.dpFin.Enabled = False
            Me.dpFecha.Enabled = True
            Me.dtpFechaFin.Enabled = True
            Me.dpDesde.Enabled = False
            Me.cmbCliente.Enabled = False
            Me.txtConsultaNumero.Enabled = False
            BanderaConsultaTipo = 2
        End If
    End Sub

    Private Sub optFecha2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optFecha2.CheckedChanged
        If Me.optFecha2.Checked = True Then
            Me.dpInicio.Enabled = False
            Me.dpFin.Enabled = False
            Me.dpFecha.Enabled = True
            Me.dtpFechaFin.Enabled = True
            Me.dpDesde.Enabled = False
            Me.cmbCliente.Enabled = False
            Me.txtConsultaNumero.Enabled = False
            BanderaConsultaTipo = 3
        End If
    End Sub

    Private Sub optCliente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optCliente.CheckedChanged
        If Me.optCliente.Checked = True Then
            Me.dpInicio.Enabled = False
            Me.dpFin.Enabled = False
            Me.dpFecha.Enabled = False
            Me.dtpFechaFin.Enabled = False
            Me.dpDesde.Enabled = True
            Me.cmbCliente.Enabled = True
            Me.txtConsultaNumero.Enabled = False
            BanderaConsultaTipo = 4
        End If
    End Sub

    Private Sub optNumero_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optNumero.CheckedChanged
        If Me.optNumero.Checked = True Then
            Me.dpInicio.Enabled = False
            Me.dpFin.Enabled = False
            Me.dpFecha.Enabled = False
            Me.dtpFechaFin.Enabled = False
            Me.dpDesde.Enabled = False
            Me.cmbCliente.Enabled = False
            Me.txtConsultaNumero.Enabled = True
            BanderaConsultaTipo = 5
        End If
    End Sub

    Private Sub btnSaldoActual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaldoActual.Click
        'traigo los valores del ultimo saldo

        Try
            Dim odtSaldoTemp As DataTable
            odtSaldoTemp = oSaldoBanco.GetMaxSaldo(CInt(Me.lblidCuenta.Text))
            Dim FechaMax As DateTime = #1/1/2000# 'fecha del ultimo saldo
            Dim decSaldoOld As Decimal = 0 'ultimo saldo

            If odtSaldoTemp.Rows.Count > 0 Then
                'obtengo la fecha mayor
                FechaMax = CDate(odtSaldoTemp.Rows(0).Item("fecha_saldo"))

                'obtengo el ultimo saldo
                decSaldoOld = CDec(odtSaldoTemp.Rows(0).Item("saldo"))
            Else
            End If

            'seteo la fecha con 01-mm-yy
            'FechaMax = "01-" & FechaMax.Month + 1 & "-" & FechaMax.Year


            'seteo la fecha con 01-mm-yy para calcular a partir del ultimo saldo guardado
            If FechaMax.Month = 12 Then
                FechaMax = CDate("01-01-" & FechaMax.Year + 1)
            Else
                FechaMax = CDate("01-" & FechaMax.Month + 1 & "-" & FechaMax.Year)
            End If

            'calculo el resumen
            oResumen_temporal.GetResumen(CInt(Me.lblidEmpresa.Text), FechaMax, CInt(Me.lblidCuenta.Text), CInt(Me.lblidBanco.Text))

            'calculo el saldo actual
            Dim decSaldo As Decimal = 0
            decSaldo = oResumen_temporal.GetSum + decSaldoOld

            Me.lblSaldoActual.Text = FormatCurrency(decSaldo)



            '*** cálculo del saldo contable ***

            oResumen_temporal.GetResumenContable(CInt(Me.lblidEmpresa.Text), FechaMax, CInt(Me.lblidCuenta.Text), CInt(Me.lblidBanco.Text))

            Dim decSaldoContable As Decimal = 0
            decSaldoContable = oResumen_temporal.GetSum + decSaldoOld

            Me.txtSaldoContable.Text = FormatCurrency(decSaldoContable)

        Catch ex As Exception
            ' MessageBox.Show(ex.Message)

        End Try
       


    End Sub


    Private Sub cmbCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCliente.KeyDown
        If e.KeyValue = 13 Then
            Me.dpDesde.Focus()
        End If
    End Sub

    Private Sub cmbCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCliente.SelectedIndexChanged
        Try
            If Me.cmbCliente.SelectedIndex >= 0 Then
                If Me.cmbCliente.SelectedValue.ToString = "System.Data.DataRowView" Then
                    Exit Sub
                End If
                Me.lblidCliente.Text = cmbCliente.SelectedValue.ToString
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dpFin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dpFin.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.btnConsultar.Focus()
        End If
    End Sub

    Private Sub dpFecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dpFecha.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.btnConsultar.Focus()
        End If
    End Sub

    Private Sub dpDesde_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dpDesde.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.btnConsultar.Focus()
        End If
    End Sub

    Private Sub txtConsultaNumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConsultaNumero.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.btnConsultar.Focus()
        End If
    End Sub


    Private Sub Btnimprime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnimprime.Click
        '   Dim frmimpresiontemporal As New FrmReportePantalla
        Dim odt As New DataTable
        If Me.lblidBanco.Text = "0" Or Me.lblidCuenta.Text = "0" Or Me.lblidEmpresa.Text = "0" Then
            Exit Sub
        End If
        If Not IsNumeric(Me.lblidBanco.Text) Or Not IsNumeric(Me.lblidCuenta.Text) Or Not IsNumeric(Me.lblidEmpresa.Text) Then
            Exit Sub
        End If

        Try
            Select Case Me.Cheques.SelectedTab.Name
                Case "librados"
                    Banderaprintpantalla = "cheques_librados_pantalla"
                    'empresa,fecha,banco,cuenta,id_banco,id_cuenta

                    parametro_banco = CInt(Me.lblidBanco.Text)
                    parametro_empresa = CInt(Me.lblidEmpresa.Text)
                    parametro_cuenta = CInt(Me.lblidCuenta.Text)
                    parametro_fecha = Me.dpBanco.Value
                    Dim frmimpresiontemporal_librados As New frmReporteChequeLibrados
                    frmimpresiontemporal_librados.ShowDialog()

                Case "recibidos"
                    Banderaprintpantalla = "cheques_recibidos_pantalla"
                    '.cop_ChequeLibrado_GetReporte()
                    'nuevo. reportes con .net
                   
                    parametro_num_cuenta = oCuenta.GetOne(CInt(Me.lblidCuenta.Text)).Rows(0).Item("numero").ToString()
                    parametro_nom_banco = oBanco.GetOne(CInt(Me.lblidBanco.Text)).Rows(0).Item("nombre_banco").ToString()

                    parametro_banco = CInt(Me.lblidBanco.Text)
                    parametro_empresa = CInt(Me.lblidEmpresa.Text)
                    parametro_cuenta = CInt(Me.lblidCuenta.Text)
                    parametro_fecha = Me.dpBanco.Value

                    Dim frmimpresiontemporal_recibidos As New frmReporteChequeRecibidos
                    frmimpresiontemporal_recibidos.ShowDialog()

                Case "Transferencia"
                    Banderaprintpantalla = "Transferencias_pantalla"

                    'nuevo. reportes con .net
                    parametro_banco = CInt(Me.lblidBanco.Text)
                    parametro_empresa = CInt(Me.lblidEmpresa.Text)
                    parametro_cuenta = CInt(Me.lblidCuenta.Text)
                    parametro_fecha = Me.dpBanco.Value

                    Dim frmimpresiontemporal_tranferencias As New frmReporteTransferencias
                    frmimpresiontemporal_tranferencias.ShowDialog()

                Case "DepEfect"
                    Banderaprintpantalla = "Depositos_pantalla"

                    parametro_banco = CInt(Me.lblidBanco.Text)
                    parametro_empresa = CInt(Me.lblidEmpresa.Text)
                    parametro_cuenta = CInt(Me.lblidCuenta.Text)
                    parametro_fecha = Me.dpBanco.Value

                    Dim frmimpresiontemporal_tranferencias As New frmReporteDepositos
                    frmimpresiontemporal_tranferencias.ShowDialog()


                Case "resumen"
                    Banderaprintpantalla = "resumen_bancario"

                    parametro_banco = CInt(Me.lblidBanco.Text)
                    parametro_empresa = CInt(Me.lblidEmpresa.Text)
                    parametro_cuenta = CInt(Me.lblidCuenta.Text)
                    parametro_fecha = Me.dpBanco.Value
                    parametro_nombre_cuenta = Me.lblidCuenta.Text
                    parametro_nombre_banco = Me.lblidBanco.Text

                    Dim frmimpresiontemporal_resumen As New frmReporteResumenBancario
                    frmimpresiontemporal_resumen.ShowDialog()



            End Select
            'frmimpresiontemporal.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try




    End Sub

    Sub Traer_datos()
        Me.Cargarcuentas()
        Me.Cargarbancos()
    End Sub

    Sub Cargarcuentas()
        Dim odt As New DataTable
        ' odt = oCuenta.get_one(Me.lblidCuenta.Text)
        parametro_nombre_cuenta = Me.lblidCuenta.Text ' odt.Rows(0).Item("numero").ToString

    End Sub

    Sub Cargarbancos()
        'Dim odt As New DataTable

        'odt = oBanco.get_banco(Me.lblidBanco.Text)
        parametro_nombre_banco = Me.lblidBanco.Text 'odt.Rows(0).Item("nombre_banco").ToString

    End Sub

    Private Sub DataGridView9_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView9.CurrentCellChanged
        Try
            Me.lblidChequeRecibido.Text = CStr(Me.DataGridView9.Item(0, Me.DataGridView9.CurrentRow.Index).Value)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView10_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView10.CellDoubleClick
        Try
            'pongo el id para hacer el cambio
            Me.lblidChequeLibrado.Text = CStr(Me.DataGridView10.Item(0, Me.DataGridView10.CurrentRow.Index).Value)

            If DataGridView10.Columns(e.ColumnIndex).Index = 1 Then
                If CDbl(Me.DataGridView10.Item(1, Me.DataGridView10.CurrentRow.Index).Value) = 0 Then
                    oChequeLibrado.Update_Check(CInt(Me.lblidChequeLibrado.Text), True)
                Else
                    oChequeLibrado.Update_Check(CInt(Me.lblidChequeLibrado.Text), False)
                End If
                Me.RefrescarGrilla()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView10_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView10.CurrentCellChanged
        Try
            Me.lblidChequeLibrado.Text = CStr(Me.DataGridView10.Item(0, Me.DataGridView10.CurrentRow.Index).Value)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView9_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView9.CellContentClick
        Try
            'pongo el id para hacer los cambios
            Me.lblidChequeRecibido.Text = CStr(Me.DataGridView9.Item(0, Me.DataGridView9.CurrentRow.Index).Value)

            If DataGridView9.Columns(e.ColumnIndex).Index = 1 Then
                If CDbl(Me.DataGridView9.Item(1, Me.DataGridView9.CurrentRow.Index).Value) = 0 Then
                    oChequeRecibido.Update_Check(CInt(Me.lblidChequeRecibido.Text), True)
                Else
                    oChequeRecibido.Update_Check(CInt(Me.lblidChequeRecibido.Text), False)
                End If
                Me.RefrescarGrilla()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnConsultarCheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarCheque.Click
        Dim frmTemp As New frmConsultaCheque
        frmTemp.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frmTemp As New FrmConsultaSaldos
        frmTemp.ShowDialog()
    End Sub


    ' '''''''''''''''
    ' '''''''''''''''
    'agregado para importar archivos .xls hacia la grilla
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_import.Click
        Try
            With ofdScript
                ' Vea btnRetriveFileNames_Click para obtener una explicación de los valores predeterminados
                ' de las propiedades.

                ' Comprobar que el archivo seleccionado existe. El cuadro de diálogo muestra
                ' una advertencia en caso contrario.
                .CheckFileExists = True

                ' Comprobar que la ruta de acceso seleccionada existe. El cuadro de diálogo muestra 
                ' una advertencia en caso contrario.
                .CheckPathExists = True

                ' Obtener o establecer una extensión predeterminada. No incluye el "." inicial.
                .DefaultExt = "xls"

                ' ¿Devolver el archivo al que hace referencia un vínculo? Si False, devuelve el archivo de vínculo
                ' seleccionado. Si True, devuelve el archivo vinculado al archivo LNK.
                .DereferenceLinks = True

                ' Al igual que en VB6, utilice un conjunto de pares de filtros, separados por "|". Cada
                ' par consta de una especificación descripción|archivo. Utilice "|" entre los pares. No es necesario
                ' poner "|" al final. Puede establecer la propiedad FilterIndex también, para seleccionar el
                ' filtro predeterminado. El primer filtro tiene el número 1 (no 0). El valor predeterminado es 1. 
                .Filter = _
                "Archivos Excel (*.xls)|*.xls" '|All files|*.*"

                ' .Multiselect = False

                ' ¿Restaurar el directorio original después de seleccionar
                ' un archivo? Si False, el directorio actual cambia
                ' al directorio en el que seleccionó el archivo.
                ' Establézcalo como True para poner la carpeta actual de nuevo
                ' donde estaba cuando comenzó.
                ' El valor predeterminado es False.
                .RestoreDirectory = True

                ' ¿Mostrar el botón Ayuda y la casilla de verificación Sólo lectura?
                .ShowHelp = True
                .ShowReadOnly = False

                ' ¿Comenzar con la casilla de verificación Sólo lectura activada?
                ' Esto sólo tiene sentido si ShowReadOnly es True.
                .ReadOnlyChecked = False

                .Title = "Select a file to open"

                ' ¿Aceptar sólo nombres de archivo Win32 válidos?
                .ValidateNames = True

                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Try
                        txt_import.Text = .FileName
                        '  txtFileContents.Text = My.Computer.FileSystem.ReadAllText(.FileName)
                    Catch fileException As Exception
                        Throw fileException
                    End Try
                End If

            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    ' '''''''''''''
    ' '''''''''''''
    ' '''''''''''''
    'agregado para importar archivos xls
    Private Sub btn_importarArchivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_importarArchivo.Click
        Dim odt As New DataTable
        Dim tipo As String = ""

        odt = importar()

        For Each row As DataRow In odt.Rows
            tipo = CStr(row("tipo"))

            Select Case tipo
                Case "g"
                    With oGasto
                        .Cargar()
                        .Insertar()
                        .control = False
                        .detalle = CStr(row(2)).Substring(0, 50)
                        .fecha = CDate(row(0))
                        .importe = Math.Abs(CDec(row(3))) ''en valor absoluto
                        .id_banco = CInt(Me.lblidBanco.Text)
                        .id_cuenta = CInt(Me.lblidCuenta.Text)
                        .id_empresa = CInt(Me.lblidEmpresa.Text)
                        .periodo = New Date(Year(CDate(row(0))), Month(CDate(row(0))), 1)
                        .Guardar()
                    End With
                Case "d"
                    With oDebito
                        .Cargar()
                        .Insertar()
                        .control = False
                        .detalle = CStr(row(2)).Substring(0, 50)
                        .fecha = CDate(row(0))
                        .importe = Math.Abs(CDec(row(3)))
                        .comprobante = CStr(row(1))
                        .id_banco = CInt(Me.lblidBanco.Text)
                        .id_cuenta = CInt(Me.lblidCuenta.Text)
                        .id_empresa = CInt(Me.lblidEmpresa.Text)
                        .periodo = New Date(Year(CDate(row(0))), Month(CDate(row(0))), 1)
                        .Guardar()
                    End With

                Case "c"
                    With oCredito
                        .Cargar()
                        .Insertar()
                        .control = False
                        .detalle = CStr(row(2)).Substring(0, 50)
                        .fecha = CDate(row(0))
                        .importe = Math.Abs(CDec(row(3)))
                        .comprobante = CStr(row(1))
                        .id_banco = CInt(Me.lblidBanco.Text)
                        .id_cuenta = CInt(Me.lblidCuenta.Text)
                        .id_empresa = CInt(Me.lblidEmpresa.Text)
                        .periodo = New Date(Year(CDate(row(0))), Month(CDate(row(0))), 1)
                        .Guardar()
                    End With
            End Select
        Next
        Me.RefrescarGrilla()
    End Sub

    Private Function importar() As Data.DataTable
        Dim dt As New DataTable()
        If txt_import.Text = "" Then
            MessageBox.Show("no cargo la ruta del archivo a importar")
            btn_import.Focus()
        Else
            Try
                Dim cnn As New OleDbConnection( _
                    "Provider=Microsoft.Jet.OLEDB.4.0;" & _
                    "Extended Properties='Excel 8.0;HDR=Yes';" & _
                    "Data Source=" & txt_import.Text)

                Dim sql As String = String.Format("SELECT * FROM [pagina1$]")

                Dim da As New OleDbDataAdapter(sql, cnn)

                da.Fill(dt)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
            End Try
        End If
        Return dt
    End Function

    Private Sub habilitar_importacion(ByVal v As Boolean)
        Me.txt_import.Enabled = v
        Me.btn_import.Enabled = v
        Me.btn_importarArchivo.Enabled = v
    End Sub
End Class