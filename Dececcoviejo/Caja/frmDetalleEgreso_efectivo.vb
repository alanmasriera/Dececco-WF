Public Class frmDetalleEgreso_efectivo

   Private Sub frmDetalleEgreso_efectivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.ttGeneral.SetToolTip(Me.btnBuscaEmpresa, "Buscar Nuevo Empresa")
       Me.ttGeneral.SetToolTip(Me.btnBuscaProveedor, "Buscar Nuevo Proveedor")
       Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Egreso_efectivo")
        Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
        Me.ttGeneral.SetToolTip(Me.btnBuscatipo_egreso, "Buscar Nuevo Tipo_egreso")
       Try
           ObtenerDatos()

            'Me.cmbEmpresa.Text = oEmpresa.GetOne(CInt(Me.lblid_Empresa.Text)).Rows(0).Item("nombre Empresa").ToString.Trim
            Me.cmbproveedor.Text = oProveedor.GetOne(CInt(Me.lblid_proveedor.Text)).Rows(0).Item("Nombre proveedor").ToString.Trim
            Me.cmbtipo_egreso.Text = oTipo_Egreso.GetOne(CInt(Me.lblid_tipo_egreso.Text)).Rows(0).Item("Nombre tipo egreso").ToString.Trim
       Catch ex As Exception
           '    MessageBox.Show(ex.Message)
       End Try

       If BanderaEgreso_efectivo  = 1 Then
           Me.LimpiarControles()
       End If
       Me.Text = "Egreso_efectivo" & vgNombreFormulario
       Me.CancelButton = Me.btnSalir
       Me.BackColor = Color.Gainsboro
       Me.StartPosition = FormStartPosition.CenterScreen
       Me.MinimizeBox = False
        Me.MaximizeBox = False

        Me.lblid_empresa.Text = CType(Me.Owner, frmResumenCaja).lblidEmpresa.Text

        'Dim tabla As New DataTable
        'tabla = oCliente_maestro.GetOne(1)
        'If tabla.Rows(0).Item("Nombre permiso").ToString = "colina" Then
        '    Me.etiquetaiva.Visible = False
        '    Me.txtiva.Visible = False
        'End If
   End Sub

   Sub CargarCombos()
        'Me.CargarEmpresa
        Me.CargarProveedor()
        Me.CargarTipo_egreso()
   End Sub

    'Sub CargarEmpresa()
    '    Dim odt As New DataTable

    '    odt = oEmpresa.GetCmb
    '    With Me.cmbEmpresa
    '        .DataSource = odt
    '        .DisplayMember = "nombre_empresa"
    '        .ValueMember = "id_empresa"
    '    End With
    '    If Me.cmbEmpresa.SelectedIndex >= 0 Then
    '        cmbEmpresa.SelectedIndex = 0
    '        Me.lblid_Empresa.Text = cmbEmpresa.SelectedValue.ToString
    '    End If
    'End Sub


    Sub CargarTipo_egreso()
        Dim odt As New DataTable

        odt = oTipo_Egreso.GetCmb
        With Me.cmbtipo_egreso
            .DataSource = odt
            .DisplayMember = "nombre_tipo_egreso"
            .ValueMember = "id_tipo_egreso"
        End With
        If Me.cmbtipo_egreso.SelectedIndex >= 0 Then
            cmbtipo_egreso.SelectedIndex = 0
            Me.lblid_tipo_egreso.Text = cmbtipo_egreso.SelectedValue.ToString
        End If
    End Sub

   Sub CargarProveedor()
       Dim odt As New DataTable

       odt = oProveedor.GetCmb
       With Me.cmbProveedor
           .DataSource = odt
           .DisplayMember = "nombre_proveedor"
           .ValueMember = "id_proveedor"
       End With
       If Me.cmbProveedor.SelectedIndex >= 0 Then
           cmbProveedor.SelectedIndex = 0
           Me.lblid_Proveedor.Text = cmbProveedor.SelectedValue.ToString
       End If
   End Sub

   Sub LimpiarControles()
       Me.dtpfecha.Value = DateTime.Now
       Me.txtcomprobante.Text = ""
       Me.txtimporte.Text = "0"
       Me.txtiva.Text = "0"
       Me.txtdetalle.Text = ""
        'Me.lblid_empresa.Text = "0"
        'Me.cmbEmpresa.Text =  ""
       Me.chkcontrol.Checked = False
        Me.chkarchivado.Checked = False

        'agregado para el check rendir
        Me.chka_rendir.Checked = False
        Me.lblid_proveedor.Text = "0"
        Me.cmbproveedor.Text = ""
        Me.lblid_tipo_egreso.Text = "0"
        Me.cmbtipo_egreso.Text = ""
   End Sub

   Private Sub ObtenerDatos()
       Me.dtpfecha.Value = oEgreso_efectivo.fecha
       Me.txtcomprobante.Text = oEgreso_efectivo.comprobante.Trim
       Me.txtimporte.Text = oEgreso_efectivo.importe.ToString.Trim
       Me.txtiva.Text = oEgreso_efectivo.iva.ToString.Trim
       Me.txtdetalle.Text = oEgreso_efectivo.detalle.Trim
        'Me.lblid_empresa.Text = oEgreso_efectivo.id_empresa.ToString
       Me.chkcontrol.Checked = oEgreso_efectivo.control
       Me.chka_rendir.Checked = oEgreso_efectivo.a_rendir
       Me.lblid_proveedor.Text = oEgreso_efectivo.id_proveedor.ToString
        Me.chkarchivado.Checked = oEgreso_efectivo.archivado
        Me.lblid_tipo_egreso.Text = oEgreso_efectivo.id_tipo_egreso.ToString
   End Sub

   Private Sub AsignarDatos()
       oEgreso_efectivo.fecha = Me.dtpfecha.Value.Date
       oEgreso_efectivo.comprobante = Me.txtcomprobante.Text
       oEgreso_efectivo.importe = CDec(Me.txtimporte.Text)
       oEgreso_efectivo.iva = CDec(Me.txtiva.Text)
       oEgreso_efectivo.detalle = Me.txtdetalle.Text
       oEgreso_efectivo.id_empresa = CInt(Me.lblid_empresa.Text)
       oEgreso_efectivo.control = Me.chkcontrol.Checked
       oEgreso_efectivo.a_rendir = Me.chka_rendir.Checked
       oEgreso_efectivo.id_proveedor = CInt(Me.lblid_proveedor.Text)
        oEgreso_efectivo.archivado = Me.chkarchivado.Checked
        oEgreso_efectivo.id_tipo_egreso = CInt(Me.lblid_tipo_egreso.Text)
   End Sub

   Public Sub SoloLectura()
       Me.dtpfecha.Enabled = False
       Me.txtcomprobante.Enabled = False
       Me.txtimporte.Enabled = False
       Me.txtiva.Enabled = False
       Me.txtdetalle.Enabled = False
        'Me.cmbEmpresa.Enabled = False
        'Me.btnBuscaEmpresa.Enabled = False
       Me.chkcontrol.Enabled = False
       Me.chka_rendir.Enabled = False
       Me.cmbProveedor.Enabled = False
       Me.btnBuscaProveedor.Enabled = False
       Me.chkarchivado.Enabled = False
        Me.btnGuardar.Visible = False
        Me.cmbtipo_egreso.Enabled = False
        Me.btnBuscatipo_egreso.Enabled = False
   End Sub

   Private Sub Guardar()
       Try
           Me.AsignarDatos()
           If oEgreso_efectivo.Exist() Then
               If BanderaEgreso_efectivo = 1 Then
                   MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
               Exit Sub
               ElseIf BanderaEgreso_efectivo = 2 Then
                   If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                       = Windows.Forms.DialogResult.No Then
                       Exit Sub
                   End If
               End If
           End If
           Select Case BanderaEgreso_efectivo
               Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                   oEgreso_efectivo.Guardar()
                    CType(Me.Owner, frmResumenCaja).RefrescarGrilla()
                   Me.CargarCombos()
                   oEgreso_efectivo.Insertar()
                   Me.ObtenerDatos()
                   Me.LimpiarControles()
                   Me.dtpfecha.Focus
               Case 2 'GUARDA Y SALE (MODIFICAR)
                   oEgreso_efectivo.Guardar()
                   Me.Close()
           End Select
       Catch ex As Exception
           MessageBox.Show(ex.Message)
       End Try
   End Sub

   Private Function ChequearVacios() As Boolean
       Dim bandera As Boolean
       If _ 
       Me.txtcomprobante.Text = "" or _
       Me.txtimporte.Text = "" or _
       Me.txtiva.Text = "" or _
       Me.txtdetalle.Text = "" Then
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
       If CDbl(Me.lblid_proveedor.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de proveedor")
           Exit Sub
       End If

        If CDbl(Me.lblid_tipo_egreso.Text) = 0 Then
            MessageBox.Show("Debe Seleccionar un Dato del Combo de tipo_egreso")
            Exit Sub
        End If

       blnVacios = Me.ChequearVacios
       If blnVacios = False Then
           MessageBox.Show("Debe Llenar los Campos Obligatorios")
           Exit Sub
       Else
           If BanderaEgreso_efectivo  = 1 Then
               Me.Guardar()
           Else
               Me.Guardar()
           End If
       End If
   End Sub

   Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
       Me.Close()
   End Sub

    'Private Sub cmbEmpresa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEmpresa.SelectedIndexChanged
    '    If Me.cmbEmpresa.SelectedIndex >= 0 Then
    '        Me.lblid_empresa.Text = cmbEmpresa.SelectedValue.ToString
    '    End If
    'End Sub

    'Private Sub btnBuscaEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaEmpresa.Click
    '    Dim frmTemporal As New FrmAbmEmpresa
    '    frmTemporal.ShowDialog()
    '     'Me.CargarEmpresa()
    '    Me.cmbEmpresa.Focus()
    '    Me.cmbEmpresa.Text = ""
    '    Me.lblid_Empresa.Text = "0"
    'End Sub

   Private Sub cmbProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProveedor.SelectedIndexChanged
       If Me.cmbProveedor.SelectedIndex >= 0 Then
           Me.lblid_proveedor.Text = cmbProveedor.SelectedValue.ToString
       End If
    End Sub

    Private Sub cmbTipo_egreso_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtipo_egreso.SelectedIndexChanged
        If Me.cmbTipo_egreso.SelectedIndex >= 0 Then
            Me.lblid_tipo_egreso.Text = cmbTipo_egreso.SelectedValue.ToString
        End If
    End Sub

    Private Sub btnBuscaTipo_egreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscatipo_egreso.Click
        Dim frmTemporal As New FrmAbmTipo_egreso
        frmTemporal.ShowDialog()
        Me.CargarTipo_egreso()
        Me.cmbTipo_egreso.Focus()
        Me.cmbTipo_egreso.Text = ""
        Me.lblid_Tipo_egreso.Text = "0"
    End Sub

   Private Sub btnBuscaProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaProveedor.Click
       Dim frmTemporal As New FrmAbmProveedor
       frmTemporal.ShowDialog()
       Me.CargarProveedor()
       Me.cmbProveedor.Focus()
       Me.cmbProveedor.Text = ""
       Me.lblid_Proveedor.Text = "0"
   End Sub

   Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtcomprobante.KeyPress, txtdetalle.KeyPress, chkcontrol.KeyPress, chka_rendir.KeyPress, chkarchivado.KeyPress
       If e.KeyChar.ToString = vbCr Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

    Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles dtpfecha.KeyDown, cmbproveedor.KeyDown, cmbtipo_egreso.KeyDown
        If CDbl(e.KeyValue.ToString) = 13 Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles txtimporte.KeyPress
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
