Public Class FrmConsultaivas
    Private Sub FrmConsultaivas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim odtTemp As New DataTable
        Select Case Bandera_consulta_iva
            Case "asignacion"

                Me.lblTitulo.Text = "Asignaciones Entre Fechas por ivas"
                ' Me.lblDetalle_consulta.Text = strTituloConsultaGeneral
                If odtConsultaGeneral.Rows.Count > 0 Then
                    Me.dgv1.DataSource = odtConsultaGeneral
                    odtTemp = oiva.GetAsigna_Sum(datFecha_inicio.Date, datFecha_fin.Date.AddDays(1), id_iva_consulta)
                    If odtTemp.Rows.Count > 0 Then
                        Me.txtTotalConsulta.Text = FormatCurrency(odtTemp.Rows(0).Item("TOTAL"))
                    Else
                        Me.txtTotalConsulta.Text = FormatCurrency(0)
                    End If

                    If CDbl(Me.txtTotalConsulta.Text) < 0 Then
                        Me.txtTotalConsulta.ForeColor = Color.Red
                    Else
                        Me.txtTotalConsulta.ForeColor = Color.Green
                    End If
                Else
                    Me.txtTotalConsulta.Text = CStr(0)
                End If
            Case "pagos"

                Me.lblTitulo.Text = "Retiros de ivas Entre Fechas"
                ' Me.lblDetalle_consulta.Text = strTituloConsultaGeneral

                If odtConsultaGeneral.Rows.Count > 0 Then

                    Me.dgv1.DataSource = odtConsultaGeneral
                    odtTemp = oiva.Getpagos_Sum(datFecha_inicio.Date, datFecha_fin.Date.AddDays(1), id_iva_consulta)
                    If odtTemp.Rows.Count > 0 Then
                        Me.txtTotalConsulta.Text = FormatCurrency(odtTemp.Rows(0).Item("TOTAL"))
                    Else
                        Me.txtTotalConsulta.Text = FormatCurrency(0)
                    End If

                    If CDbl(Me.txtTotalConsulta.Text) < 0 Then
                        Me.txtTotalConsulta.ForeColor = Color.Red
                    Else
                        Me.txtTotalConsulta.ForeColor = Color.Green
                    End If
                Else
                    Me.txtTotalConsulta.Text = CStr(0)
                End If

        End Select
    End Sub

End Class