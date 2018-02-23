Imports System.Globalization
Public Class frmAbmFactura

    Dim odt As DataTable
    Dim BanderaConsultaFactura As Integer

    Private Sub frmAbmFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttAgregar.SetToolTip(Me.btnAgregar, "Incorporar Nueva Factura Detallada")
        Me.ttAgregar_2.SetToolTip(Me.btnAgregar, "Incorporar Nueva Factura General")
        Me.ttBorrar.SetToolTip(Me.btnBorrar, "Anular una Factura Existente")
        Me.ttModificar.SetToolTip(Me.btnModificar, "Modificar una Factura Existente")
        'Me.ttConsultar.SetToolTip(Me.btnConsultar, "Consultar Datos del  Factura Existente")


        Dim odt As DataTable
        odt = oFactura.Cargar
        odt = oFactura_exporta.Cargar


        Me.dtpPeriodo.Value = Date.Now

        RefrescarGrilla()
        Me.txtBuscar.Focus()
        Me.lblTitulo.Text = "Gestión de Facturas"
        Me.Text = "Gestión de Facturas" & vgNombreFormulario
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False


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

    End Sub


    Public Sub RefrescarGrilla()
        Dim odt As DataTable
        Dim fecha_factura = Format(Me.dtpPeriodo.Value.Date)
        odt = oFactura.ConsultarTodo_2(Me.dtpPeriodo.Value.Date)
        Me.dgv1.DataSource = odt
        Me.dgv1.Columns(0).Visible = False
        Me.dgv1.Columns("subtotal").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgv1.Columns("subtotal").DefaultCellStyle.Format = "c"
        Me.dgv1.Columns("alicuota").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgv1.Columns("alicuota").DefaultCellStyle.Format = "n"
        Me.dgv1.Columns("iva").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgv1.Columns("iva").DefaultCellStyle.Format = "c"
        Me.dgv1.Columns("total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgv1.Columns("total").DefaultCellStyle.Format = "c"
        Me.dgv1.Columns("impuesto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgv1.Columns("impuesto").DefaultCellStyle.Format = "c"

        Dim odt_2 As New DataTable
        odt_2 = oIva_venta.GetOneDate(Me.dtpPeriodo.Value.Date)
        If odt_2.Rows.Count <= 0 Then
            Me.lblEstado_libro.Text = "ABIERTO"
            Me.lblEstado_libro.BackColor = Color.Lime
            Me.btnAgregar.Enabled = True
            Me.btnAgregar_2.Enabled = True
            Me.btnExporta.Enabled = True

        Else

            Me.lblEstado_libro.Text = "CERRADO"
            Me.lblEstado_libro.BackColor = Color.Red
            Me.btnAgregar.Enabled = False
            Me.btnAgregar_2.Enabled = False
            Me.btnExporta.Enabled = False

        End If

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
        odt = oFactura.Buscarcliente(Me.txtBuscar.Text) ', Me.dtpPeriodo.Value.Date)
        Me.dgv1.DataSource = odt
    End Sub

    Private Sub dgv1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv1.CurrentCellChanged
        Try
            Me.lblid_pk.Text = CStr(Me.dgv1.Item(0, Me.dgv1.CurrentRow.Index).Value)
            parametro_fac = CInt(Me.lblid_pk.Text)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Botones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnAgregar.Click, btnBorrar.Click, btnModificar.Click, btnSalir.Click, _
    btnImprimir.Click, btnAgregar_2.Click, btnExporta.Click
        Dim btnTemp As New Button
        Dim frmDetalle As New frmDetalleFactura
        Dim frmDetalle_2 As New frmDetalleFactura2
        Dim frmDetalle_E As New frmDetalleFacturaExporta

        btnTemp = CType(sender, Button)
        Try
            Select Case btnTemp.Name
                Case "btnAgregar"
                    BanderaFactura = 1
                    Me.AddOwnedForm(frmDetalle)
                    oFactura.Insertar()

                    'agregado
                    Dim ultimo As Integer
                    ultimo = oFactura.UltimaFactura()
                    Me.lblid_pk.Text = CStr(ultimo + 1) 'antes estaba como 0

                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()

                Case "btnAgregar_2"
                    BanderaFactura = 1
                    Me.AddOwnedForm(frmDetalle_2)
                    oFactura.Insertar()

                    Me.lblid_pk.Text = CStr(0)

                    frmDetalle_2.CargarCombos()
                    frmDetalle_2.ShowDialog()

                Case "btnExporta"
                    BanderaFactura = 1
                    Me.AddOwnedForm(frmDetalle_E)
                    oFactura_exporta.Insertar()

                    Me.lblid_pk.Text = CStr(0)

                    frmDetalle_E.CargarCombos()
                    frmDetalle_E.ShowDialog()
                Case "btnModificar"
                    If Not IsNumeric(Me.lblid_pk.Text) Then
                        Exit Sub
                    End If
                    BanderaFactura = 2

                    If Me.lblid_pk.Text < "1" Then
                        MessageBox.Show("Debe seleccionar un registro")
                        Exit Sub
                    End If

                    oFactura.Modificar(CInt(Me.lblid_pk.Text))

                    'veo que tipo de factura es
                    If oFactura.tipo_factura = "A" Then

                        Me.AddOwnedForm(frmDetalle)
                        frmDetalle.CargarCombos()
                        frmDetalle.ShowDialog()
                    ElseIf oFactura.tipo_factura = "AA" Then
                        oCuerpo_factura.ModificarPorFactura(CInt(Me.lblid_pk.Text))
                        Me.AddOwnedForm(frmDetalle_2)
                        frmDetalle_2.CargarCombos()
                        frmDetalle_2.ShowDialog()
                    End If

                    RefrescarGrilla()
                Case "btnBorrar"
                    If Not IsNumeric(Me.lblid_pk.Text) Then
                        Exit Sub
                    End If

                    If Me.lblid_pk.Text <= "1" Then
                        MessageBox.Show("Debe seleccionar un registro")
                        Exit Sub
                    End If

                    If CBool(Me.dgv1.Item("ANULADA", Me.dgv1.CurrentRow.Index).Value) = False Then
                        oFactura.Anular(CInt(Me.lblid_pk.Text), True)
                    Else
                        oFactura.Anular(CInt(Me.lblid_pk.Text), False)
                    End If


                    ' oFactura.Borrar(Me.lblid_pk.Text)
                    RefrescarGrilla()
                Case "btnAyuda"
                    'Process.Start(PathAyuda + "frmAbmFactura.avi")
                Case "btnSalir"
                    Me.Close()
                Case "btnImprimir"
                    'Dim frmimpresiontemporal As New FrmReporteFactura

                    'Try
                    '    Banderaprintpantalla = "factura"
                    '    frmimpresiontemporal.ShowDialog()
                    'Catch ex As Exception
                    '    MessageBox.Show(ex.Message)
                    'End Try
            End Select
            Me.txtBuscar.Text = ""
            Me.txtBuscar.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dtpPeriodo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpPeriodo.ValueChanged
        Me.RefrescarGrilla()
    End Sub

    
End Class