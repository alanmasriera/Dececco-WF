Public Class frmDetalleCuentas

   Private Sub frmDetalleCuentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnBuscaEmpresa, "Buscar Nuevo Empresa")
       Me.ttGeneral.SetToolTip(Me.btnBuscaBanco, "Buscar Nuevo Banco")
       Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Cuentas")
       Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
       Try
           ObtenerDatos()

           Me.cmbEmpresa.Text = oEmpresa.GetOne(CInt(Me.lblid_Empresa.Text)).Rows(0).Item("nombre_Empresa").ToString.Trim
           Me.cmbBanco.Text = oBanco.GetOne(CInt(Me.lblid_Banco.Text)).Rows(0).Item("nombre_Banco").ToString.Trim
       Catch ex As Exception
           '    MessageBox.Show(ex.Message)
       End Try

        If BanderaCuenta = 1 Then
            Me.LimpiarControles()
        End If
        Me.Text = "Cuentas" & vgNombreFormulario
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False
    End Sub

    Sub CargarCombos()
        Me.CargarEmpresa()
        Me.CargarBanco()
    End Sub

    Sub CargarEmpresa()
        Dim odt As New DataTable

        odt = oEmpresa.GetCmb
        With Me.cmbempresa
            .DataSource = odt
            .DisplayMember = "nombre_empresa"
            .ValueMember = "id_empresa"
        End With
        If Me.cmbempresa.SelectedIndex >= 0 Then
            cmbempresa.SelectedIndex = 0
            Me.lblid_empresa.Text = cmbempresa.SelectedValue.ToString
        End If
    End Sub

    Sub CargarBanco()
        Dim odt As New DataTable

        odt = oBanco.GetCmb
        With Me.cmbbanco
            .DataSource = odt
            .DisplayMember = "nombre_banco"
            .ValueMember = "id_banco"
        End With
        If Me.cmbbanco.SelectedIndex >= 0 Then
            cmbbanco.SelectedIndex = 0
            Me.lblid_banco.Text = cmbbanco.SelectedValue.ToString
        End If
    End Sub

    Sub LimpiarControles()
        Me.txtnumero.Text = ""
        Me.lblid_empresa.Text = "0"
        Me.cmbempresa.Text = ""
        Me.lblid_banco.Text = "0"
        Me.cmbbanco.Text = ""
        Me.txtcbu.Text = ""
        Me.txtmoneda.Text = ""
    End Sub

    Private Sub ObtenerDatos()
        Me.txtnumero.Text = oCuenta.numero.Trim
        Me.lblid_empresa.Text = oCuenta.id_empresa.ToString
        Me.lblid_banco.Text = oCuenta.id_banco.ToString
        Me.txtcbu.Text = oCuenta.cbu.Trim
        Me.txtmoneda.Text = oCuenta.moneda.Trim
    End Sub

    Private Sub AsignarDatos()
        oCuenta.numero = Me.txtnumero.Text
        oCuenta.id_empresa = CInt(Me.lblid_empresa.Text)
        oCuenta.id_banco = CInt(Me.lblid_banco.Text)
        oCuenta.cbu = Me.txtcbu.Text
        oCuenta.moneda = Me.txtmoneda.Text
    End Sub

    Public Sub SoloLectura()
        Me.txtnumero.Enabled = False
        Me.cmbempresa.Enabled = False
        Me.btnBuscaempresa.Enabled = False
        Me.cmbbanco.Enabled = False
        Me.btnBuscabanco.Enabled = False
        Me.txtcbu.Enabled = False
        Me.txtmoneda.Enabled = False
        Me.btnGuardar.Visible = False
    End Sub

    Private Sub Guardar()
        Try
            Me.AsignarDatos()
            If oCuenta.Exist() Then
                If BanderaCuenta = 1 Then
                    MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
                    Exit Sub
                ElseIf BanderaCuenta = 2 Then
                    If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                        = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
            Select Case BanderaCuenta
                Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                    oCuenta.Guardar()
                    CType(Me.Owner, frmAbmCuentas).RefrescarGrilla()
                    Me.CargarCombos()
                    oCuenta.Insertar()
                    Me.ObtenerDatos()
                    Me.LimpiarControles()
                    Me.txtnumero.Focus()
                Case 2 'GUARDA Y SALE (MODIFICAR)
                    oCuenta.Guardar()
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ChequearVacios() As Boolean
        Dim bandera As Boolean
        If Me.txtnumero.Text = "" Then
            bandera = False
        Else
            bandera = True
        End If
        Return bandera
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim blnVacios As Boolean

        If CDbl(Me.lblid_empresa.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de empresa")
            Exit Sub
        End If
        If CDbl(Me.lblid_banco.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de banco")
            Exit Sub
        End If

        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaCuenta = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

   Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
       Me.Close()
   End Sub

   Private Sub cmbEmpresa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEmpresa.SelectedIndexChanged
       If Me.cmbEmpresa.SelectedIndex >= 0 Then
           Me.lblid_empresa.Text = cmbEmpresa.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaEmpresa.Click
       Dim frmTemporal As New FrmAbmEmpresa
       frmTemporal.ShowDialog()
       Me.CargarEmpresa()
       Me.cmbEmpresa.Focus()
       Me.cmbEmpresa.Text = ""
       Me.lblid_Empresa.Text = "0"
   End Sub

   Private Sub cmbBanco_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBanco.SelectedIndexChanged
       If Me.cmbBanco.SelectedIndex >= 0 Then
           Me.lblid_banco.Text = cmbBanco.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaBanco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaBanco.Click
       Dim frmTemporal As New FrmAbmBanco
       frmTemporal.ShowDialog()
       Me.CargarBanco()
       Me.cmbBanco.Focus()
       Me.cmbBanco.Text = ""
       Me.lblid_Banco.Text = "0"
   End Sub

   Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtnumero.KeyPress, txtcbu.KeyPress, txtmoneda.KeyPress
       If e.KeyChar.ToString = vbCr Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
   Handles cmbEmpresa.KeyDown, cmbBanco.KeyDown
       If CDbl(e.KeyValue.ToString) = 13 Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   'Handles 
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

End Class
