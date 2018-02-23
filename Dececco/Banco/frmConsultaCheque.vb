Public Class frmConsultaCheque
    Dim Bandera_cheque As Integer
    Dim odtTemp As New DataTable

    Private Sub frmConsultaCheque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'control de acceso y de permisos
        Dim odtUser As New DataTable
        odtUser = oUsuario.GetPermiso(vgNombreUsuario, Me.Name)
        If odtUser.Rows.Count = 0 OrElse CDbl(odtUser.Rows(0).Item("habilitado")) = 0 Then
            Me.btnConsultar.Enabled = False
            Me.Btnimprime.Enabled = False
        End If

    End Sub

    Private Sub rbnLibrado_desde_librado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim rbnTemp As New RadioButton
        rbnTemp = CType(sender, RadioButton)

        Select Case rbnTemp.Name
            Case "rbnLibrado_desde_librado"
            Case "rbnLibrado_desde_pago"
            Case "rbnLibrado_hasta_librado"
            Case "rbnLibrado_hasta_pago"
            Case "rbnRecibido_desde_librado"
            Case "rbnRecibido_desde_pago"
            Case "rbnRecibido_hasta_librado"
            Case "rbnRecibido_hasta_pago"
        End Select

    End Sub

    Private Function FechaAño(ByVal Fecha As DateTime, ByVal Operacion As Integer) As DateTime
        Dim FechaNew As DateTime

        If Operacion = 1 Then
            FechaNew = DateAdd("yyyy", -2, Fecha)
        Else
            FechaNew = DateAdd("yyyy", +2, Fecha)
        End If

        Return FechaNew
    End Function

    Sub Consultar()
        odtTemp = oChequeLibrado.GetBothCheques(Me.dtpLibrado_L_D.Value.Date, Me.dtpLibrado_L_H.Value.Date, _
        Me.dtpLibrado_P_D.Value.Date, Me.dtpLibrado_P_H.Value.Date, Me.dtpRecibido_R_D.Value.Date, _
        Me.dtpRecibido_R_H.Value.Date, Me.dtpRecibido_A_D.Value.Date, Me.dtpRecibido_A_H.Value.Date)

        Me.dgv1.DataSource = odtTemp

        Me.dgv1.Columns(0).Visible = False
        Me.dgv1.Columns(1).Visible = False
        Me.dgv1.Columns("IMPORTE").DefaultCellStyle.Format = "c"
        Me.dgv1.Columns("IMPORTE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        'calcula la sumatoria de los cheques
        Me.txtTotalConsulta.Text = FormatCurrency(oChequeLibrado.GetSum)
        'calcula la sumatoria de los cheques marcados
        Me.txtMarcados.Text = FormatCurrency(oChequeLibrado.GetSumCheck)
        'calcula la sumatoria de los cheques desmarcados
        Me.txtDesmarcados.Text = FormatCurrency(oChequeLibrado.GetSumNoCheck)
        parametro_fecha_librado_desde = Me.dtpLibrado_L_D.Value
        parametro_fecha_librado_hasta = Me.dtpLibrado_L_H.Value
        parametro_fecha_pago_desde = Me.dtpLibrado_P_D.Value
        parametro_fecha_pago_hasta = Me.dtpLibrado_P_H.Value
        parametro_fecha_recibido_desde = Me.dtpRecibido_R_D.Value
        parametro_fecha_recibido_hasta = Me.dtpRecibido_R_H.Value
        parametro_fecha_acreditacion_desde = Me.dtpRecibido_A_D.Value
        parametro_fecha_acreditacion_hasta = Me.dtpRecibido_A_H.Value

        Banderaprint = "consulta_maestra"
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        Me.Consultar()
    End Sub




    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub dgv1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellContentClick

    End Sub

    Private Sub dgv1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellDoubleClick
        Try
            If dgv1.Columns(e.ColumnIndex).Name = "CONTROL" Then
                If CStr(Me.dgv1.Item(2, Me.dgv1.CurrentRow.Index).Value) = "RECIBIDO" Then
                    If CDbl(Me.dgv1.Item(3, Me.dgv1.CurrentRow.Index).Value) = 0 Then
                        oChequeRecibido.Update_Check(CInt(Me.lblid_cheque.Text), True)
                    Else
                        oChequeRecibido.Update_Check(CInt(Me.lblid_cheque.Text), False)
                    End If
                ElseIf CStr(Me.dgv1.Item(2, Me.dgv1.CurrentRow.Index).Value) = "LIBRADO" Then
                    If CDbl(Me.dgv1.Item(3, Me.dgv1.CurrentRow.Index).Value) = 0 Then
                        oChequeLibrado.Update_Check(CInt(Me.lblid_cheque.Text), True)
                    Else
                        oChequeLibrado.Update_Check(CInt(Me.lblid_cheque.Text), False)
                    End If
                End If
                Me.Consultar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgv1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv1.CurrentCellChanged
        Try
            Me.lblid_cheque.Text = CStr(Me.dgv1.Item(1, Me.dgv1.CurrentRow.Index).Value)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.txtTotalConsulta.Text = FormatCurrency(oChequeLibrado.GetSum)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.txtTotalConsulta.Text = FormatCurrency(oChequeLibrado.GetSumCheck)
    End Sub

    
    
    Private Sub Btnimprime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnimprime.Click
        'Dim frmimpresiontemporal As New Frmreporte   '--> incluido 05/03
        'Dim odt As New DataTable

        'frmimpresiontemporal.ShowDialog()

    End Sub


End Class