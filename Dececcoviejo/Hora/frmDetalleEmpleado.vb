Public Class frmDetalleEmpleado

   Private Sub frmDetalleEmpleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Me.ttGeneral.SetToolTip(Me.btnBuscaTipo_empleado, "Buscar Nuevo Tipo_empleado")
       Me.ttGeneral.SetToolTip(Me.btnBuscaObra_social, "Buscar Nuevo Obra_social")
       Me.ttGeneral.SetToolTip(Me.btnGuardar, "Guardar Datos del Empleado")
       Me.ttGeneral.SetToolTip(Me.btnSalir, "Volver a la Pantalla Anterior")
       Try
           ObtenerDatos()

           Me.cmbTipo_empleado.Text = oTipo_empleado.GetOne(CInt(Me.lblid_Tipo_empleado.Text)).Rows(0).Item("nombre_Tipo_empleado").ToString.Trim
           Me.cmbObra_social.Text = oObra_social.GetOne(CInt(Me.lblid_Obra_social.Text)).Rows(0).Item("nombre_Obra_social").ToString.Trim
       Catch ex As Exception
           '    MessageBox.Show(ex.Message)
       End Try

       If BanderaEmpleado  = 1 Then
           Me.LimpiarControles()
       End If
       Me.Text = "Empleado"
       Me.CancelButton = Me.btnSalir
       Me.BackColor = Color.Gainsboro
       Me.StartPosition = FormStartPosition.CenterScreen
       Me.MinimizeBox = False
       Me.MaximizeBox = False
   End Sub

   Sub CargarCombos()
       Me.CargarTipo_empleado
       Me.CargarObra_social
   End Sub

   Sub CargarTipo_empleado()
       Dim odt As New DataTable

       odt = oTipo_empleado.GetCmb
       With Me.cmbTipo_empleado
           .DataSource = odt
           .DisplayMember = "nombre_tipo_empleado"
           .ValueMember = "id_tipo_empleado"
       End With
       If Me.cmbTipo_empleado.SelectedIndex >= 0 Then
           cmbTipo_empleado.SelectedIndex = 0
           Me.lblid_Tipo_empleado.Text = cmbTipo_empleado.SelectedValue.ToString
       End If
   End Sub

   Sub CargarObra_social()
       Dim odt As New DataTable

       odt = oObra_social.GetCmb
       With Me.cmbObra_social
           .DataSource = odt
           .DisplayMember = "nombre_obra_social"
           .ValueMember = "id_obra_social"
       End With
       If Me.cmbObra_social.SelectedIndex >= 0 Then
           cmbObra_social.SelectedIndex = 0
           Me.lblid_Obra_social.Text = cmbObra_social.SelectedValue.ToString
       End If
   End Sub

   Sub LimpiarControles()
       Me.txtlegajo.Text = ""
       Me.txtapellido.Text = ""
       Me.txtnombre.Text = ""
       Me.txtcuil.Text = ""
       Me.dtpnacimiento.Value = DateTime.Now
       Me.txtdomicilio.Text = ""
       Me.txtlocalidad.Text = ""
       Me.txtcp.Text = ""
       Me.txtprovincia.Text = ""
       Me.txtnacionalidad.Text = ""
       Me.txtestado_civil.Text = ""
       Me.txttelefono.Text = ""
       Me.dtpcasamiento.Value = DateTime.Now
       Me.txtlugar_nacimiento.Text = ""
       Me.txtapellido_conyugue.Text = ""
       Me.txtnombre_conyugue.Text = ""
       Me.txtapellido_casado.Text = ""
       Me.txtdni_conyugue.Text = ""
       Me.txtapellido_beneficiario.Text = ""
       Me.txtnombre_beneficiario.Text = ""
       Me.txtdni_beneficiario.Text = ""
       Me.dtpingreso.Value = DateTime.Now
       Me.dtpreviza.Value = DateTime.Now
       Me.chkdesabilitado.Checked = False
       Me.lblid_tipo_empleado.Text = "0"
       Me.cmbTipo_empleado.Text =  ""
       Me.txtsexo.Text = ""
       Me.txtpais.Text = ""
       Me.txtdni.Text = ""
       Me.txttipo_dni.Text = ""
       Me.dtpegreso.Value = DateTime.Now
       Me.txtmodalidad_trabajo.Text = ""
       Me.lblid_obra_social.Text = "0"
       Me.cmbObra_social.Text =  ""
       Me.txttarea.Text = ""
       Me.txtvalor_hora.Text = ""
       Me.chkcoordinador.Checked = False
        Me.txthijo.Text = "0"
        Me.txtvalor_hijo.Text = "0"
        Me.txtsalario_mvm.Text = "0"
        Me.txtadicional_obra_social.Text = "0"
        Me.txthijo_discapacitado.Text = "0"
   End Sub

   Private Sub ObtenerDatos()
       Me.txtlegajo.Text = oEmpleado.legajo.Trim
       Me.txtapellido.Text = oEmpleado.apellido.Trim
       Me.txtnombre.Text = oEmpleado.nombre.Trim
       Me.txtcuil.Text = oEmpleado.cuil.Trim
       Me.dtpnacimiento.Value = oEmpleado.nacimiento
       Me.txtdomicilio.Text = oEmpleado.domicilio.Trim
       Me.txtlocalidad.Text = oEmpleado.localidad.Trim
       Me.txtcp.Text = oEmpleado.cp.Trim
       Me.txtprovincia.Text = oEmpleado.provincia.Trim
       Me.txtnacionalidad.Text = oEmpleado.nacionalidad.Trim
       Me.txtestado_civil.Text = oEmpleado.estado_civil.Trim
       Me.txttelefono.Text = oEmpleado.telefono.Trim
       Me.dtpcasamiento.Value = oEmpleado.casamiento
       Me.txtlugar_nacimiento.Text = oEmpleado.lugar_nacimiento.Trim
       Me.txtapellido_conyugue.Text = oEmpleado.apellido_conyugue.Trim
       Me.txtnombre_conyugue.Text = oEmpleado.nombre_conyugue.Trim
       Me.txtapellido_casado.Text = oEmpleado.apellido_casado.Trim
       Me.txtdni_conyugue.Text = oEmpleado.dni_conyugue.Trim
       Me.txtapellido_beneficiario.Text = oEmpleado.apellido_beneficiario.Trim
       Me.txtnombre_beneficiario.Text = oEmpleado.nombre_beneficiario.Trim
       Me.txtdni_beneficiario.Text = oEmpleado.dni_beneficiario.Trim
       Me.dtpingreso.Value = oEmpleado.ingreso
       Me.dtpreviza.Value = oEmpleado.reviza
       Me.chkdesabilitado.Checked = oEmpleado.desabilitado
       Me.lblid_tipo_empleado.Text = oEmpleado.id_tipo_empleado.ToString
       Me.txtsexo.Text = oEmpleado.sexo.Trim
       Me.txtpais.Text = oEmpleado.pais.Trim
       Me.txtdni.Text = oEmpleado.dni.Trim
       Me.txttipo_dni.Text = oEmpleado.tipo_dni.Trim
       Me.dtpegreso.Value = oEmpleado.egreso
       Me.txtmodalidad_trabajo.Text = oEmpleado.modalidad_trabajo.Trim
       Me.lblid_obra_social.Text = oEmpleado.id_obra_social.ToString
       Me.txttarea.Text = oEmpleado.tarea.Trim
       Me.txtvalor_hora.Text = oEmpleado.valor_hora.ToString.Trim
       Me.chkcoordinador.Checked = oEmpleado.coordinador
       Me.txthijo.Text = oEmpleado.hijo.ToString.Trim
       Me.txtvalor_hijo.Text = oEmpleado.valor_hijo.ToString.Trim
       Me.txtsalario_mvm.Text = oEmpleado.salario_mvm.ToString.Trim
       Me.txtadicional_obra_social.Text = oEmpleado.adicional_obra_social.ToString.Trim
       Me.txthijo_discapacitado.Text = oEmpleado.hijo_discapacitado.ToString.Trim
   End Sub

   Private Sub AsignarDatos()
       oEmpleado.legajo = Me.txtlegajo.Text
       oEmpleado.apellido = Me.txtapellido.Text
       oEmpleado.nombre = Me.txtnombre.Text
       oEmpleado.cuil = Me.txtcuil.Text
       oEmpleado.nacimiento = Me.dtpnacimiento.Value.Date
       oEmpleado.domicilio = Me.txtdomicilio.Text
       oEmpleado.localidad = Me.txtlocalidad.Text
       oEmpleado.cp = Me.txtcp.Text
       oEmpleado.provincia = Me.txtprovincia.Text
       oEmpleado.nacionalidad = Me.txtnacionalidad.Text
       oEmpleado.estado_civil = Me.txtestado_civil.Text
       oEmpleado.telefono = Me.txttelefono.Text
       oEmpleado.casamiento = Me.dtpcasamiento.Value.Date
       oEmpleado.lugar_nacimiento = Me.txtlugar_nacimiento.Text
       oEmpleado.apellido_conyugue = Me.txtapellido_conyugue.Text
       oEmpleado.nombre_conyugue = Me.txtnombre_conyugue.Text
       oEmpleado.apellido_casado = Me.txtapellido_casado.Text
       oEmpleado.dni_conyugue = Me.txtdni_conyugue.Text
       oEmpleado.apellido_beneficiario = Me.txtapellido_beneficiario.Text
       oEmpleado.nombre_beneficiario = Me.txtnombre_beneficiario.Text
       oEmpleado.dni_beneficiario = Me.txtdni_beneficiario.Text
       oEmpleado.ingreso = Me.dtpingreso.Value.Date
       oEmpleado.reviza = Me.dtpreviza.Value.Date
       oEmpleado.desabilitado = Me.chkdesabilitado.Checked
       oEmpleado.id_tipo_empleado = CInt(Me.lblid_tipo_empleado.Text)
       oEmpleado.sexo = Me.txtsexo.Text
       oEmpleado.pais = Me.txtpais.Text
       oEmpleado.dni = Me.txtdni.Text
       oEmpleado.tipo_dni = Me.txttipo_dni.Text
       oEmpleado.egreso = Me.dtpegreso.Value.Date
       oEmpleado.modalidad_trabajo = Me.txtmodalidad_trabajo.Text
       oEmpleado.id_obra_social = CInt(Me.lblid_obra_social.Text)
       oEmpleado.tarea = Me.txttarea.Text
       oEmpleado.valor_hora = CDec(Me.txtvalor_hora.Text)
       oEmpleado.coordinador = Me.chkcoordinador.Checked
       oEmpleado.hijo = CDec(Me.txthijo.Text)
       oEmpleado.valor_hijo = CDec(Me.txtvalor_hijo.Text)
       oEmpleado.salario_mvm = CDec(Me.txtsalario_mvm.Text)
       oEmpleado.adicional_obra_social = CDec(Me.txtadicional_obra_social.Text)
       oEmpleado.hijo_discapacitado = CDec(Me.txthijo_discapacitado.Text)
   End Sub

   Public Sub SoloLectura()
       Me.txtlegajo.Enabled = False
       Me.txtapellido.Enabled = False
       Me.txtnombre.Enabled = False
       Me.txtcuil.Enabled = False
       Me.dtpnacimiento.Enabled = False
       Me.txtdomicilio.Enabled = False
       Me.txtlocalidad.Enabled = False
       Me.txtcp.Enabled = False
       Me.txtprovincia.Enabled = False
       Me.txtnacionalidad.Enabled = False
       Me.txtestado_civil.Enabled = False
       Me.txttelefono.Enabled = False
       Me.dtpcasamiento.Enabled = False
       Me.txtlugar_nacimiento.Enabled = False
       Me.txtapellido_conyugue.Enabled = False
       Me.txtnombre_conyugue.Enabled = False
       Me.txtapellido_casado.Enabled = False
       Me.txtdni_conyugue.Enabled = False
       Me.txtapellido_beneficiario.Enabled = False
       Me.txtnombre_beneficiario.Enabled = False
       Me.txtdni_beneficiario.Enabled = False
       Me.dtpingreso.Enabled = False
       Me.dtpreviza.Enabled = False
       Me.chkdesabilitado.Enabled = False
       Me.cmbTipo_empleado.Enabled = False
       Me.btnBuscaTipo_empleado.Enabled = False
       Me.txtsexo.Enabled = False
       Me.txtpais.Enabled = False
       Me.txtdni.Enabled = False
       Me.txttipo_dni.Enabled = False
       Me.dtpegreso.Enabled = False
       Me.txtmodalidad_trabajo.Enabled = False
       Me.cmbObra_social.Enabled = False
       Me.btnBuscaObra_social.Enabled = False
       Me.txttarea.Enabled = False
       Me.txtvalor_hora.Enabled = False
       Me.chkcoordinador.Enabled = False
       Me.txthijo.Enabled = False
       Me.txtvalor_hijo.Enabled = False
       Me.txtsalario_mvm.Enabled = False
       Me.txtadicional_obra_social.Enabled = False
       Me.txthijo_discapacitado.Enabled = False
       Me.btnGuardar.Visible = False
   End Sub

   Private Sub Guardar()
       Try
           Me.AsignarDatos()
           If oEmpleado.Exist() Then
               If BanderaEmpleado = 1 Then
                   MessageBox.Show("Sr. Usuario: Los Datos que Pretende Ingresar ya Fueron Cargados en el Sistema")
               Exit Sub
               ElseIf BanderaEmpleado = 2 Then
                   If MessageBox.Show("Sr. Usuario: Los Datos que Desea Modificar ya Existen ¿Desea Reemplazarlos?", "MODIFICAR", _
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                       = Windows.Forms.DialogResult.No Then
                       Exit Sub
                   End If
               End If
           End If
           Select Case BanderaEmpleado
               Case 1 'GUARDA,REFRESCA LA GRILLA E INSERTA UNO NUEVO (AGREGAR)
                   oEmpleado.Guardar()
                   CType(Me.Owner, frmAbmEmpleado).RefrescarGrilla()
                   Me.CargarCombos()
                   oEmpleado.Insertar()
                   Me.ObtenerDatos()
                   Me.LimpiarControles()
                   Me.txtlegajo.Focus
               Case 2 'GUARDA Y SALE (MODIFICAR)
                   oEmpleado.Guardar()
                   Me.Close()
           End Select
       Catch ex As Exception
           MessageBox.Show(ex.Message)
       End Try
   End Sub

   Private Function ChequearVacios() As Boolean
       Dim bandera As Boolean
       If Me.txtlegajo.Text = "" Then
           bandera = False
       Else
           bandera = True
       End If
       Return bandera
   End Function

   Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
       Dim blnVacios As Boolean

       If CDbl(Me.lblid_tipo_empleado.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de tipo_empleado")
           Exit Sub
       End If
       If CDbl(Me.lblid_obra_social.Text) = 0 Then
           MessageBox.Show("Debe Seleccionar un Dato del Combo de obra_social")
           Exit Sub
       End If

        If Me.txthijo.Text = "" Then
            Me.txthijo.Text = "0"
        End If
        If Me.txtvalor_hijo.Text = "" Then
            Me.txtvalor_hijo.Text = "0"
        End If
        If Me.txtsalario_mvm.Text = "" Then
            Me.txtsalario_mvm.Text = "0"
        End If
        If Me.txtadicional_obra_social.Text = "" Then
            Me.txtadicional_obra_social.Text = "0"
        End If
        If Me.txthijo_discapacitado.Text = "" Then
            Me.txthijo_discapacitado.Text = "0"
        End If


        blnVacios = Me.ChequearVacios
        If blnVacios = False Then
            MessageBox.Show("Debe Llenar los Campos Obligatorios")
            Exit Sub
        Else
            If BanderaEmpleado = 1 Then
                Me.Guardar()
            Else
                Me.Guardar()
            End If
        End If
    End Sub

   Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
       Me.Close()
   End Sub

   Private Sub cmbTipo_empleado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipo_empleado.SelectedIndexChanged
       If Me.cmbTipo_empleado.SelectedIndex >= 0 Then
           Me.lblid_tipo_empleado.Text = cmbTipo_empleado.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaTipo_empleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaTipo_empleado.Click
       Dim frmTemporal As New FrmAbmTipo_empleado
       frmTemporal.ShowDialog()
       Me.CargarTipo_empleado()
       Me.cmbTipo_empleado.Focus()
       Me.cmbTipo_empleado.Text = ""
       Me.lblid_Tipo_empleado.Text = "0"
   End Sub

   Private Sub cmbObra_social_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbObra_social.SelectedIndexChanged
       If Me.cmbObra_social.SelectedIndex >= 0 Then
           Me.lblid_obra_social.Text = cmbObra_social.SelectedValue.ToString
       End If
   End Sub

   Private Sub btnBuscaObra_social_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaObra_social.Click
       Dim frmTemporal As New FrmAbmObra_social
       frmTemporal.ShowDialog()
       Me.CargarObra_social()
       Me.cmbObra_social.Focus()
       Me.cmbObra_social.Text = ""
       Me.lblid_Obra_social.Text = "0"
   End Sub

   Private Sub TabulacionTextBox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtlegajo.KeyPress, txtapellido.KeyPress, txtnombre.KeyPress, txtcuil.KeyPress, txtdomicilio.KeyPress, txtlocalidad.KeyPress, txtcp.KeyPress, txtprovincia.KeyPress, txtnacionalidad.KeyPress, txtestado_civil.KeyPress, txttelefono.KeyPress, txtlugar_nacimiento.KeyPress, txtapellido_conyugue.KeyPress, txtnombre_conyugue.KeyPress, txtapellido_casado.KeyPress, txtdni_conyugue.KeyPress, txtapellido_beneficiario.KeyPress, txtnombre_beneficiario.KeyPress, txtdni_beneficiario.KeyPress, chkdesabilitado.KeyPress, txtsexo.KeyPress, txtpais.KeyPress, txtdni.KeyPress, txttipo_dni.KeyPress, txtmodalidad_trabajo.KeyPress, txttarea.KeyPress, chkcoordinador.KeyPress
       If e.KeyChar.ToString = vbCr Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub TabulacionCombos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
   Handles dtpnacimiento.KeyDown, dtpcasamiento.KeyDown, dtpingreso.KeyDown, dtpreviza.KeyDown, cmbTipo_empleado.KeyDown, dtpegreso.KeyDown, cmbObra_social.KeyDown
       If CDbl(e.KeyValue.ToString) = 13 Then
           Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
       End If
   End Sub

   Private Sub Decimales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
   Handles txtvalor_hora.KeyPress, txthijo.KeyPress, txtvalor_hijo.KeyPress, txtsalario_mvm.KeyPress, txtadicional_obra_social.KeyPress, txthijo_discapacitado.KeyPress
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

    Private Sub txtnombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.TextChanged

    End Sub
    Private Sub txtapellido_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtapellido.TextChanged

    End Sub
    Private Sub txtlegajo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlegajo.TextChanged

    End Sub
End Class
