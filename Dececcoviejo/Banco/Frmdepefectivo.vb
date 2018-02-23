'esta
Public Class Frmdepefectivo

    Private Sub Frmdepefectivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolTipguarda.SetToolTip(btnGuardar, "Guardar Datos ")
        ToolTipsalir.SetToolTip(btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()
        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try

        If BanderaCheque = 6 Then
            Me.LimpiarControles()
        End If

        ''control de acceso y de permisos
        'Dim odtUser As New DataTable
        'odtUser = oUsuario.GetPermiso(vgNombreUsuario, Me.Name)
        'If odtUser.Rows.Count = 0 OrElse CDbl(odtUser.Rows(0).Item("habilitado")) = 0 Then
        '    Me.btnGuardar.Enabled = False
        'End If
    End Sub

    Sub LimpiarControles()
        Me.dpFecha.Value = CType(Me.Owner, Frmmovbancos).dpBanco.Value
        Me.Txtboleta.Text = ""
        Me.Txtimporte.Text = ""
        Me.txtDetalle.Text = ""
        Me.txtiva.Text = "0"

        'colina
        Dim odt As New DataTable
        odt = oCliente_maestro.GetOne(1)
        If odt.Rows(0).Item("nombre_permiso").ToString = "colina" Then
            Me.etiquetaiva.Visible = False
            Me.txtiva.Visible = False
        End If
    End Sub

    'CARGA EL FORMULARIO CON LOS DATOS DEL EMPLEADO
    Private Sub ObtenerDatos()
        Me.Txtboleta.Text = oDepositoEfectivo.comprobante
        Me.txtDetalle.Text = oDepositoEfectivo.detalle
        Me.dpFecha.Value = oDepositoEfectivo.fecha
        Me.Txtimporte.Text = CStr(oDepositoEfectivo.importe)
        Me.txtiva.Text = CStr(oDepositoEfectivo.iva)
    End Sub

    'ASIGNA LOS VALORES DEL FORMULARIO AL EMPLEADO
    Private Sub AsignarDatos()
        oDepositoEfectivo.comprobante = Me.Txtboleta.Text
        oDepositoEfectivo.detalle = Me.txtDetalle.Text.Trim
        oDepositoEfectivo.fecha = Me.dpFecha.Value.Date
        oDepositoEfectivo.importe = CDec(Me.Txtimporte.Text)
        oDepositoEfectivo.id_banco = CInt(CType(Me.Owner, Frmmovbancos).lblidBanco.Text)
        oDepositoEfectivo.id_cuenta = CInt(CType(Me.Owner, Frmmovbancos).lblidCuenta.Text)
        oDepositoEfectivo.id_empresa = CInt(CType(Me.Owner, Frmmovbancos).lblidEmpresa.Text)
        oDepositoEfectivo.periodo = Me.dpFecha.Value.Date
        oDepositoEfectivo.iva = CDec(Me.txtiva.Text)
    End Sub

    'ENABLE=FALSE TODOS LOS CONTROLES PARA CONSULTA
    Public Sub SoloLectura()
        Me.Txtboleta.Enabled = False
        Me.txtDetalle.Enabled = False
        Me.dpFecha.Enabled = False
        Me.Txtimporte.Enabled = False

        Me.btnGuardar.Visible = False
        Me.txtiva.Enabled = False
    End Sub

    'GUARDA LOS CAMBIOS
    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            Select Case BanderaCheque
                Case 6 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oDepositoEfectivo.Guardar()
                    CType(Me.Owner, Frmmovbancos).RefrescarGrilla()
                    oDepositoEfectivo.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.dpFecha.Focus()
                Case 66 'GUARDA Y SALE (MODIFICAR)
                    oDepositoEfectivo.Guardar()
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'CONTROLA LOS CONTROLES VACIOS Y DEVUELVE UN BOOLEAN
    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If Me.Txtboleta.Text = "" Or Me.txtDetalle.Text = "" Or Me.Txtimporte.Text = "" Or Me.txtiva.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function


    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles Txtimporte.KeyPress, txtiva.KeyPress
        Dim txtTemp As TextBox
        txtTemp = CType(sender, TextBox)

        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
        If e.KeyChar.ToString = "." Or e.KeyChar.ToString = "," Then
            If InStr(txtTemp.Text, ",") <> 0 Then
                e.Handled = True
            Else
                e.KeyChar = CChar(",")
            End If
        End If

        Dim Largo As Integer = InStr(txtTemp.Text, ",")

        If txtTemp.Text.Length > Largo + 2 And Largo <> 0 And e.KeyChar.ToString <> vbBack Then
            e.Handled = True
        End If

        If (e.KeyChar.ToString >= "0" And e.KeyChar.ToString <= "9") Or e.KeyChar.ToString = "," Or e.KeyChar = vbBack Then
            '  e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtDetalle_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDetalle.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.btnGuardar.Focus()
        End If
    End Sub

    Private Sub Txtboleta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtboleta.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.Txtimporte.Focus()
        End If

        If (e.KeyChar.ToString >= "0" And e.KeyChar.ToString <= "9") Or e.KeyChar.ToString = "/" Or e.KeyChar.ToString = "-" Or e.KeyChar = vbBack Then
            '  e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub dpFecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dpFecha.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.Txtboleta.Focus()
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios (*) ")
            Exit Sub
        Else
            If BanderaCheque = 6 Then
                Guardar()
            Else
                Me.Guardar()
            End If
        End If

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

End Class