Public Class frmConsultaProveedorMain

    Private Sub Botones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn10.Click, _
      btnSalir.Click

        Dim btnTemp As New Button
        btnTemp = CType(sender, Button)



        'saldo total de proveedores
        Select Case btnTemp.Name
            Case "btn1"
                Dim frmTemp1 As New frmReporte_Saldo_Todos_Proveedores
                oConsulta_saldo_proveedor.Make_Main(vgCuentaProveedorResta)
                odtConsultaGeneral = oConsulta_saldo_proveedor.GetAll_2
                Me.AddOwnedForm(frmTemp1)
                frmTemp1.ShowDialog()
                ' ''Dim frmTemp1 As New frmReporte_Saldo_Todos_Proveedores
                ' ''oConsulta_saldo_proveedor.Make_Main(vgCuentaProveedorResta)
                ' ''Me.AddOwnedForm(frmTemp1)
                ' ''frmTemp1.ShowDialog()

                'BanderaConsultaGeneral = "saldo_proveedor_todo"
                'strTituloConsultaGeneral = "Saldo de todos los proveedores"
                'vgBanderaprint = "imprime_saldo_proveedores"

            Case "btn2"
                'facturas vencidas entre fechas por proveedor
                Dim frmTemp1 As New frmReporteFacturasProveedor
                parametro_fecha_inicio = Me.dtpFecha_desde.Value.Date
                parametro_fecha_fin = Me.dtpFecha_hasta.Value.Date
                parametro_Proveedor = CInt(Me.lblid_proveedor.Text)
                'bandera_imprime_prov = 2
                'Banderabtn = 2
                'BanderaConsultaGeneral = "factura_vencida_entre_fecha_proveedor"
                'strTituloConsultaGeneral = "Proveedor: " & Me.cmbProveedor.Text

                parametro_nom_prov = Me.cmbProveedor.Text
                'vgBanderaprint = "imprime_facturas_Prov"
                Me.AddOwnedForm(frmTemp1)
                frmTemp1.ShowDialog()
            Case "btn3" 'factura y pagos entre fechas
                Try
                    odtConsultaGeneral = oResumen_proveedor.SetResumenBD_All(Me.dtpFecha_desde.Value.Date, Me.dtpFecha_hasta.Value.Date, vgCuentaProveedorResta)
                    BanderaConsultaGeneral = "movimiento_proveedor_entre_fecha"
                    odtConsultaGeneralSuma = oResumen_proveedor.SetResumenBD_All_Sum()
                    strTituloConsultaGeneral = ""
                    'frmTemp.ShowDialog()
                Catch ex As Exception
                    'MessageBox.Show(ex.Message)
                End Try
            Case "btn4" 'facturas entre fechas
                Dim frmTemp1 As New frmReporteFacProveedoresEntreFechas
                odtConsultaGeneral = oFactura_proveedor.GetAll_VencidaBD_All(Me.dtpFecha_desde.Value.Date, Me.dtpFecha_hasta.Value.Date)
                parametro_fecha_inicio = Me.dtpFecha_desde.Value.Date
                parametro_fecha_fin = Me.dtpFecha_hasta.Value.Date
                'bandera_imprime_prov = 4
                'Banderabtn = 4
                'BanderaConsultaGeneral = "factura_vencida_entre_fecha"
                odtConsultaGeneralSuma = oFactura_proveedor.GetAll_VencidaBD_All_Sum(Me.dtpFecha_desde.Value.Date, Me.dtpFecha_hasta.Value.Date)
                'strTituloConsultaGeneral = ""

                'vgBanderaprint = "imprime_facturas_vencidas"
                Me.AddOwnedForm(frmTemp1)
                frmTemp1.ShowDialog()
            Case "btn5" 'movimientos entre fecha por proveedor
                Dim frmTemp1 As New frmReportePagoXProv
                'Dim tabla As New DataTable
                'tabla = oRecibo_proveedor.GetAll_4(Me.dtpFecha_desde.Value.Date, Me.dtpFecha_hasta.Value.Date)

                parametro_fecha_inicio = Me.dtpFecha_desde.Value.Date
                parametro_fecha_fin = Me.dtpFecha_hasta.Value.Date
                Me.AddOwnedForm(frmTemp1)
                frmTemp1.ShowDialog()

            Case "btn6"
                Dim frmTemp1 As New frmPagoAProveedoresEntreFechas
                odtConsultaGeneral = oRecibo_proveedor.GetAll_4(Me.dtpFecha_desde.Value.Date, Me.dtpFecha_hasta.Value.Date)
                parametro_fecha_inicio = Me.dtpFecha_desde.Value.Date
                parametro_fecha_fin = Me.dtpFecha_hasta.Value.Date
                Me.AddOwnedForm(frmTemp1)
                frmTemp1.ShowDialog()
            Case "btn7"
                Dim frmTemp1 As New frmFacturasProveedoresEntreFechas
                odtConsultaGeneral = oFactura_proveedor.GetAll_Entre_Fechas(Me.dtpFecha_desde.Value.Date, Me.dtpFecha_hasta.Value.Date)
                parametro_fecha_inicio = Me.dtpFecha_desde.Value.Date
                parametro_fecha_fin = Me.dtpFecha_hasta.Value.Date
                Me.AddOwnedForm(frmTemp1)
                frmTemp1.ShowDialog()
            Case "btn8"
                Dim frmTemp1 As New frmReporteFacturas_Vencidas_X_Proveedor
                odtConsultaGeneral = oFactura_proveedor.GetAll_VencidaBD_All(Me.dtpFecha_desde.Value.Date, Me.dtpFecha_hasta.Value.Date)
                parametro_fecha_inicio = Me.dtpFecha_desde.Value.Date
                parametro_fecha_fin = Me.dtpFecha_hasta.Value.Date
                odtConsultaGeneralSuma = oFactura_proveedor.GetAll_VencidaBD_All_Sum(Me.dtpFecha_desde.Value.Date, Me.dtpFecha_hasta.Value.Date)
                Me.AddOwnedForm(frmTemp1)
                frmTemp1.ShowDialog()
            Case "btn9"
            Case "btn10"
                Dim frmTemp1 As New frmReporteXProveedor2
                parametro_fecha_inicio = Me.dtpFecha_desde.Value.Date
                parametro_fecha_fin = Me.dtpFecha_hasta.Value.Date
                Me.AddOwnedForm(frmTemp1)
                frmTemp1.ShowDialog()
            Case "btnSalir"
                Me.Close()
        End Select
    End Sub



    Private Sub frmConsultaProveedorMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CargarProveedor()
        Me.dtpFecha_desde.MaxDate = Today
        Me.dtpFecha_hasta.MaxDate = Today

        oConsulta_saldo_proveedor.Cargar()
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

    Private Sub cmbProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProveedor.SelectedIndexChanged
        If Me.cmbProveedor.SelectedIndex >= 0 Then
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

            'seteo la fecha anterior y traigo el saldo anterior
            FechaOld = DateAdd(DateInterval.Month, -1, Date.Now.Date)
            'parametro_fecha_old = FechaOld
            Me.lblSaldoAnterior.Text = FormatCurrency(oSaldo_proveedor.GetOldSaldo(CInt(Me.lblid_proveedor.Text), FechaOld))

            'genera el resumen de cuenta
            odtResumen = oResumen_proveedor.SetResumen(CInt(Me.lblid_proveedor.Text), Date.Now.Date, vgCuentaProveedorResta)
            'parametro_id_empleado = Me.lblid_proveedor.Text
            'parametro_id_empleado_old = Me.lblid_proveedor.Text
            parametro_fecha_inicio = Date.Now.Date

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

            'actualiza el datatable
            oResumen_proveedor.Update()
            oResumen_proveedor.Guardar()

            'agrega el saldo al total de la grilla
            Me.lblTotalGrilla.Text = CStr(s)

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



End Class