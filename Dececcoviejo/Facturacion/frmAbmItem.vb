Public Class frmAbmItem

    Dim odt As DataTable
    Dim BanderaConsultaItem As Integer

    Private Sub frmAbmItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttAgregar.SetToolTip(Me.btnAgregar, "Incorporar Nuevo Item")
        Me.ttBorrar.SetToolTip(Me.btnBorrar, "Borrar un  Item Existente")
        Me.ttModificar.SetToolTip(Me.btnModificar, "Modificar  un Item Existente")
        'Me.ttConsultar.SetToolTip(Me.btnConsultar, "Consultar Datos del  Item Existente")

        Dim odt As DataTable
        odt = oItem.Cargar

        RefrescarGrilla()
        Me.txtBuscar.Focus()
        Me.lblTitulo.Text = "Item del Comprobante"
        Me.Text = "Item del Comprobante" & vgNombreFormulario
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False
    End Sub

    Public Sub RefrescarGrilla()
        Dim odt As DataTable

        odt = oItem.ConsultarTodo()
        Me.dgv1.DataSource = odt
        Me.dgv1.Columns(0).Visible = False
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
        odt = oItem.Buscar(Me.txtBuscar.Text)
        Me.dgv1.DataSource = odt
    End Sub

    Private Sub dgv1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv1.CurrentCellChanged
        Try
            Me.lblid_pk.Text = CStr(Me.dgv1.Item(0, Me.dgv1.CurrentRow.Index).Value)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Botones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click, btnAyuda.Click, btnBorrar.Click, btnModificar.Click, btnSalir.Click, btnImprimir.Click
        Dim btnTemp As New Button
        Dim frmDetalle As New frmDetalleItem
        btnTemp = CType(sender, Button)
        Try
            Select Case btnTemp.Name
                Case "btnAgregar"
                    BanderaItem = 1
                    Me.AddOwnedForm(frmDetalle)
                    oItem.Insertar()
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                Case "btnModificar"
                    If Not IsNumeric(Me.lblid_pk.Text) Then
                        Exit Sub
                    End If
                    If CDbl(Me.lblid_pk.Text) <= 1 Then
                        MessageBox.Show("No se Puede Modificar el Registro")
                        Exit Sub
                    End If
                    BanderaItem = 2
                    oItem.Modificar(CInt(Me.lblid_pk.Text))
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                    RefrescarGrilla()
                Case "btnBorrar"
                    If Not IsNumeric(Me.lblid_pk.Text) Then
                        Exit Sub
                    End If
                    If CDbl(Me.lblid_pk.Text) <= 1 Then
                        MessageBox.Show("No se Puede Borrar el Registro")
                        Exit Sub
                    End If
                    oItem.Borrar(CInt(Me.lblid_pk.Text))
                    RefrescarGrilla()
                Case "btnAyuda"
                    'Process.Start(PathAyuda + "frmAbmItem.avi")
                Case "btnSalir"
                    Me.Close()
                Case "btnImprimir"
                    'Dim frmimpresiontemporal As New FrmReporteFactura

                    'Try
                    '    Banderaprintpantalla = "orden compra"
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

End Class