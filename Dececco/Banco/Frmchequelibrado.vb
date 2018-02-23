Public Class Frmchequelibrado

    Private Sub Frmchequelibrado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolTipguarda.SetToolTip(btnguardar, "Guardar Datos ")
        ToolTipsalir.SetToolTip(btnsalir, "Volver a la Pantalla Anterior")
        ToolTipcliente.SetToolTip(btnbuscaproveedor, "Localiza o Agrega un nuevo Proveedor")
        ttChequera.SetToolTip(Me.btnBuscaChequera, "Localiza o Agrega una nueva Chequera")
        Try
            ObtenerDatos()

            Me.Cmbproveedor.Text = oProveedor.GetOne(CInt(Me.lblidProveedor.Text)).Rows(0).Item("nombre_Proveedor").ToString.Trim
            Me.cmbChequera.Text = oChequera.GetOne(CInt(Me.lblidChequera.Text)).Rows(0).Item("numero_cheque").ToString.Trim

            If BanderaCheque = 22 Then
                Me.txtNumero_cheque.Text = oChequeLibrado.numero_cheque.Trim
            End If
        Catch ex As Exception
            '    MessageBox.Show(ex.Message)
        End Try

        If BanderaCheque = 2 Then
            Me.LimpiarControles()
            Me.lblidChequera.Text = "0"
            Me.cmbChequera.Text = ""
        End If
        Me.CancelButton = Me.btnSalir
        '   Me.lblid_cuenta.Text = CType(Me.Owner, Frmmovbancos).lblidCuenta.Text

        ''control de acceso y de permisos
        'Dim odtUser As New DataTable
        'odtUser = oUsuario.GetPermiso(vgNombreUsuario, Me.Name)
        'If odtUser.Rows.Count = 0 OrElse CDbl(odtUser.Rows(0).Item("habilitado")) = 0 Then
        '    Me.btnGuardar.Enabled = False
        'End If

        'colina
        Dim odt As New DataTable
        odt = oCliente_maestro.GetOne(1)

        'If odt.Rows(0).Item("nombre_permiso").ToString = "colina" Then
        'Else
        '    Me.etiquetaiva.Visible = False
        '    Me.txtiva.Visible = False
        'End If
    End Sub

    Sub CargarChequera()
        Dim odt As New DataTable

        odt = oChequera.GetCmb_2(CInt(Me.lblid_cuenta.Text))
        With Me.cmbChequera
            .DataSource = odt
            .DisplayMember = "numero_cheque"
            .ValueMember = "id_chequera"
        End With
        If Me.cmbChequera.SelectedIndex >= 0 Then
            cmbChequera.SelectedIndex = 0
            Me.lblidChequera.Text = cmbChequera.SelectedValue.ToString
        End If
    End Sub

    Sub CargarProveedor()
        Dim odt As New DataTable

        odt = oProveedor.GetCmb
        With Me.Cmbproveedor
            .DataSource = odt
            .DisplayMember = "nombre_proveedor"
            .ValueMember = "id_proveedor"
        End With
        If Me.Cmbproveedor.SelectedIndex >= 0 Then
            Cmbproveedor.SelectedIndex = 0
            Me.lblidProveedor.Text = Cmbproveedor.SelectedValue.ToString
        End If
    End Sub

    Sub CargarCombos()
        Me.CargarChequera()
        Me.CargarProveedor()
    End Sub

    Sub LimpiarControles()
        Me.dtpFecha_pago.Value = CType(Me.Owner, Frmmovbancos).dpBanco.Value
        Me.dtpFecha_librado.Value = CType(Me.Owner, Frmmovbancos).dpBanco.Value
        Me.Cmbproveedor.Text = ""
        '  Me.cmbChequera.Text = ""
        '  Me.Txtnrocheque.Text = oChequeLibrado.Autonumerico(Frmmovbancos.lblidEmpresa.Text, Frmmovbancos.dpBanco.Value.ToShortDateString, Me.lblidChequera.Text)
        Me.txtImporte.Text = ""
        Me.txtDetalle.Text = ""
        Me.lblidProveedor.Text = "0"
        '  Me.lblidChequera.Text = "0"
        Me.txtiva.Text = "0"
        Me.chkanulado.Checked = False
       
    End Sub

    Private Sub ObtenerDatos()
        Me.lblidChequera.Text = CStr(oChequeLibrado.id_chequera)
        Me.lblidProveedor.Text = CStr(oChequeLibrado.id_proveedor)
        Me.txtNumero_cheque.Text = oChequeLibrado.numero_cheque
        Me.txtDetalle.Text = oChequeLibrado.detalle
        Me.dtpFecha_librado.Value = oChequeLibrado.fecha_librado
        Me.dtpFecha_pago.Value = oChequeLibrado.fecha_pago
        Me.txtImporte.Text = CStr(oChequeLibrado.importe)
        Me.txtiva.Text = CStr(oChequeLibrado.iva)
        Me.chkanulado.Checked = oChequeLibrado.anulado
    End Sub

    Private Sub AsignarDatos()
        oChequeLibrado.id_chequera = CInt(Me.lblidChequera.Text)
        oChequeLibrado.id_proveedor = CInt(Me.lblidProveedor.Text)
        oChequeLibrado.numero_cheque = Me.txtNumero_cheque.Text
        oChequeLibrado.Detalle = Me.txtDetalle.Text.Trim
        oChequeLibrado.fecha_librado = Me.dtpFecha_librado.Value.Date
        oChequeLibrado.fecha_pago = Me.dtpFecha_pago.Value.Date
        oChequeLibrado.importe = CDec(Me.txtImporte.Text)
        oChequeLibrado.banco_cheque = CInt(CType(Me.Owner, Frmmovbancos).lblidBanco.Text)
        oChequeLibrado.id_cuenta = CInt(CType(Me.Owner, Frmmovbancos).lblidCuenta.Text)
        oChequeLibrado.id_empresa = CInt(CType(Me.Owner, Frmmovbancos).lblidEmpresa.Text)
        oChequeLibrado.periodo = Me.dtpFecha_pago.Value.Date
        oChequeLibrado.iva = CDec(Me.txtiva.Text)
        oChequeLibrado.anulado = Me.chkanulado.Checked
    End Sub

    Public Sub SoloLectura()
        Me.cmbChequera.Enabled = False
        Me.Cmbproveedor.Enabled = False
        Me.txtNumero_cheque.Enabled = False
        Me.txtDetalle.Enabled = False
        Me.dtpFecha_pago.Enabled = False
        Me.dtpFecha_librado.Enabled = False
        Me.txtImporte.Enabled = False
        Me.txtiva.Enabled = False
        Me.chkanulado.Enabled = False

        Me.btnGuardar.Visible = False
    End Sub

    Private Sub Guardar()

        Try
            Me.AsignarDatos()
            If oChequeLibrado.Exist() Then
                If BanderaCheque = 2 Then
                    MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
                    Exit Sub
                ElseIf BanderaCheque = 22 Then
                    If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                        = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            Select Case BanderaCheque
                Case 2 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    Dim idChequeraViejo As Integer = CInt(Me.lblidChequera.Text)
                    oChequeLibrado.Guardar()
                    CType(Me.Owner, Frmmovbancos).RefrescarGrilla()
                    '   Me.BorrarCombos()
                    Me.CargarProveedor()
                    oChequeLibrado.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.lblidChequera.Text = CStr(idChequeraViejo)

                    Dim odt As New DataTable
                    odt = oChequera.ConsultarNumeroChequeMayorNuevo(CInt(Me.lblidChequera.Text))
                    Me.txtNumero_cheque.Text = CStr(CDec(odt.Rows(0).Item("total")) + 1)

                    'Me.txtNumero_cheque.Text = CStr(Val(oChequera.ConsultarNumeroChequeMayor(CInt(Me.lblidChequera.Text))) + 1)
                    Me.Cmbproveedor.Focus()
                Case 22 'GUARDA Y SALE (MODIFICAR)
                    oChequeLibrado.Guardar()
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If Me.txtNumero_cheque.Text = "" Or Me.txtDetalle.Text = "" Or Me.txtImporte.Text = "" Or Me.txtiva.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub Cmbproveedor_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmbproveedor.SelectedIndexChanged
        If Me.Cmbproveedor.SelectedIndex >= 0 Then
            Me.lblidProveedor.Text = Cmbproveedor.SelectedValue.ToString
        End If
    End Sub

    Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtDetalle.KeyPress, txtNumero_cheque.KeyPress, chkanulado.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles Cmbproveedor.KeyDown, dtpFecha_librado.KeyDown, dtpFecha_pago.KeyDown, cmbChequera.KeyDown
        If CDbl(e.KeyValue.ToString) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtImporte.KeyPress, txtiva.KeyPress
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

    Private Sub btnBuscaProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaProveedor.Click
        Dim frmTemp As New frmAbmProveedor
        frmTemp.ShowDialog()
        Me.CargarProveedor()
        Me.Cmbproveedor.Focus()
        Me.Cmbproveedor.Text = ""
        Me.lblidProveedor.Text = "0"
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean

        'controla la fecha_librado con el período indicado en Movimiento Bancos.
        If Not dtpFecha_librado.Value.Month = CType(Me.Owner, Frmmovbancos).dpBanco.Value.Month And _
                dtpFecha_librado.Value.Year = CType(Me.Owner, Frmmovbancos).dpBanco.Value.Year Then
            If MessageBox.Show("El Mes/Año de la fecha ingresada no es igual al período. ¿Desea continuar con la fecha ingresada?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        End If

        If CDbl(Me.lblidProveedor.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Proveedor del Combo")
            Exit Sub
        End If

        If CInt(Me.txtNumero_cheque.Text) > CInt(Me.txtFin.Text) Then
            MessageBox.Show("Se superó la cantidad de Cheques para la Chequera", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Me.LimpiarControles()
            Me.Close()
            Exit Sub
        End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios (*) ")
            Exit Sub
        Else
            If BanderaCheque = 2 Then
                Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cmbChequera_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbChequera.SelectedIndexChanged
        If Me.cmbChequera.SelectedIndex >= 0 Then
            Me.lblidChequera.Text = cmbChequera.SelectedValue.ToString
            If Not IsNumeric(Me.lblidChequera.Text) Then
                Exit Sub
            End If

            Dim odt_chequera As New DataTable
            odt_chequera = oChequera.GetOne(CInt(Me.lblidChequera.Text))
            Me.txtInicio.Text = CStr(odt_chequera.Rows(0).Item("inicio"))
            Me.txtFin.Text = CStr(odt_chequera.Rows(0).Item("fin"))

            Dim odt As New DataTable
            odt = oChequera.ConsultarNumeroChequeMayorNuevo(CInt(Me.lblidChequera.Text))
            'modificado en el procedimiento si el primer chico le asigna el inicio de la 
            'chequera , sino el ultimo + 1
            Me.txtNumero_cheque.Text = CStr(CDec(odt.Rows(0).Item("total")))
            Me.chkTipo_cheque.Checked = CBool(odt_chequera.Rows(0).Item("tipo_cheque"))
        End If
    End Sub

    Private Sub btnBuscaChequera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaChequera.Click
        Dim frmTemp As New frmAbmChequeras
        frmTemp.ShowDialog()
        Me.CargarChequera()
        Me.cmbChequera.Focus()
        Me.cmbChequera.Text = ""
        Me.lblidChequera.Text = "0"
    End Sub

    Private Sub dtpFecha_librado_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha_librado.ValueChanged
        If Me.chkTipo_cheque.Checked = True Then
            Me.dtpFecha_pago.Value = Me.dtpFecha_librado.Value
        End If
    End Sub

    Private Sub chkanulado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkanulado.CheckedChanged
        If chkanulado.Checked Then


            ' cmbChequera.SelectedIndex = 8 'id_tipo_cheque = 0 , inicio = 1 , fin = 1, id_banco = 2 , id_cuenta = 2

            lblidChequera.Text = "0"
            ' Cmbproveedor.SelectedIndex = 1 'ninguno
            lblidProveedor.Text = "0"
            txtFin.Text = "0"
            txtInicio.Text = "0"
            txtNumero_cheque.Text = "0"
            txtiva.Text = "0"
            txtDetalle.Text = "----"
            txtImporte.Text = "0"
            ' lblid_cuenta.Text = "0"
        End If
    End Sub
End Class