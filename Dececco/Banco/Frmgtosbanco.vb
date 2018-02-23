'esta
Public Class Frmgtosbanco

    Private Sub Frmgtosbanco_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolTipguarda.SetToolTip(btnGuardar, "Guardar Datos ")
        ToolTipsalir.SetToolTip(btnSalir, "Volver a la Pantalla Anterior")
        Try
            ObtenerDatos()
        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try

        If BanderaCheque = 7 Then
            Me.LimpiarControles()
        End If
        Me.dpFecha.Focus()

        ''control de acceso y de permisos
        'Dim odtUser As New DataTable
        'odtUser = oUsuario.GetPermiso(vgNombreUsuario, Me.Name)
        'If odtUser.Rows.Count = 0 OrElse CDbl(odtUser.Rows(0).Item("habilitado")) = 0 Then
        '    Me.btnGuardar.Enabled = False
        'End If
        'Dim odt As New DataTable
        'odt = oCliente_maestro.GetOne(1)
        'If odt.Rows(0).Item("nombre_permiso").ToString = "colina" Then
        '    Me.etiquetaiva.Visible = False
        '    Me.txtiva.Visible = False
        'End If
    End Sub


    Sub LimpiarControles()
        '     Me.Txtboleta.Text = ""
        Me.dpFecha.Value = CType(Me.Owner, Frmmovbancos).dpBanco.Value
        Me.Txtimporte.Text = ""
        Me.txtDetalle.Text = ""
        Me.txtiva.Text = "0"

    End Sub

    'CARGA EL FORMULARIO CON LOS DATOS DEL EMPLEADO
    Private Sub ObtenerDatos()
        '    Me.Txtboleta.Text = Trim(oGasto.Comprobante)
        Me.txtDetalle.Text = oGasto.detalle
        Me.dpFecha.Value = oGasto.fecha
        Me.Txtimporte.Text = CStr(oGasto.importe)
        Me.txtiva.Text = CStr(oGasto.iva)
    End Sub

    'ASIGNA LOS VALORES DEL FORMULARIO AL EMPLEADO
    Private Sub AsignarDatos()
        '  oGasto.Comprobante = Me.Txtboleta.Text
        oGasto.detalle = Me.txtDetalle.Text.Trim
        oGasto.fecha = Me.dpFecha.Value.Date
        oGasto.importe = CDec(Me.Txtimporte.Text)
        oGasto.id_banco = CInt(CType(Me.Owner, Frmmovbancos).lblidBanco.Text)
        oGasto.id_cuenta = CInt(CType(Me.Owner, Frmmovbancos).lblidCuenta.Text)
        oGasto.id_empresa = CInt(CType(Me.Owner, Frmmovbancos).lblidEmpresa.Text)
        oGasto.periodo = Me.dpFecha.Value.Date
        oGasto.iva = CDec(Me.txtiva.Text)
    End Sub

    'ENABLE=FALSE TODOS LOS CONTROLES PARA CONSULTA
    Public Sub SoloLectura()
        '   Me.txtBoleta.Enabled = False
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
                Case 7 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oGasto.Guardar()
                    CType(Me.Owner, Frmmovbancos).RefrescarGrilla()
                    oGasto.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.dpFecha.Focus()
                Case 77 'GUARDA Y SALE (MODIFICAR)
                    oGasto.Guardar()
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'CONTROLA LOS CONTROLES VACIOS Y DEVUELVE UN BOOLEAN
    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If Me.txtDetalle.Text = "" Or Me.Txtimporte.Text = "" Or Me.txtiva.Text = "" Then
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

    '  Private Sub Txtboleta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtboleta.KeyPress
    '     If e.KeyChar.ToString = vbCr Then
    '        Me.Cmbbanco.Focus()
    '    End If
    '
    '   If (e.KeyChar.ToString >= "0" And e.KeyChar.ToString <= "9") Or e.KeyChar.ToString = "/" Or e.KeyChar.ToString = "-" Or e.KeyChar = vbBack Then
    '  
    '       Else
    '          e.Handled = True
    '      End If
    '   End Sub

    Private Sub dpFecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dpFecha.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.Txtimporte.Focus()
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean


        'controla la fecha_librado con el período indicado en Movimiento Bancos.
        If Not dpFecha.Value.Month = CType(Me.Owner, Frmmovbancos).dpBanco.Value.Month And _
                dpFecha.Value.Year = CType(Me.Owner, Frmmovbancos).dpBanco.Value.Year Then
            If MessageBox.Show("El Mes/Año de la fecha ingresada no es igual al período. ¿Desea continuar con la fecha ingresada?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        End If


        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios (*) ")
            Exit Sub
        Else
            If BanderaCheque = 7 Then
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