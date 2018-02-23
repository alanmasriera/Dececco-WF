Public Class frmDetalleItem

    Private Sub frmDetalleItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttGuardar.SetToolTip(Me.btnGuardar, "Guardar Datos del Item")
        Me.ttSalir.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()

        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try

        If BanderaItem = 1 Then
            Me.LimpiarControles()
        End If
        Me.Text = "Item del Comprobante" & vgNombreFormulario
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False
    End Sub

    Sub CargarCombos()
    End Sub

    Sub LimpiarControles()
        Me.txtnombre_item.Text = ""
    End Sub

    Private Sub ObtenerDatos()
        Me.txtnombre_item.Text = oItem.nombre_item.Trim
    End Sub

    Private Sub AsignarDatos()
        oItem.nombre_item = Me.txtNombre_item.Text.Trim
    End Sub

    Public Sub SoloLectura()
        Me.txtnombre_item.Enabled = False
        Me.btnGuardar.Visible = False
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            Select Case BanderaItem
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oItem.Guardar()
                    CType(Me.Owner, frmAbmItem).RefrescarGrilla()
                    Me.CargarCombos()
                    oItem.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.txtnombre_item.Focus()
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oItem.Guardar()
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If Me.txtnombre_item.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean


        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaItem = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombre_item.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) 'Handles 
        If e.KeyValue = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub


End Class