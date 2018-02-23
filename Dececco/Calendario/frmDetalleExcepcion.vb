Imports Entidades
Imports ControladoresLogica
Imports System.Globalization

Public Class frmDetalleExcepcion
    Private exce As Excepcion_Calendario


    Public Sub New(exce As Excepcion_Calendario)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.exce = exce

        dgv_detalle_periodo.Rows.Clear
        dgv_detalle_periodo.Rows.Add(5)

        rdDiario.Checked = True

        CargarDatosExcepcion()

    End Sub



    Private Sub GuardarPeriodosLaborables
        For index = 0 To dgv_detalle_periodo.Rows.Count - 1
            If dgv_detalle_periodo.Item(hora_inicio_dgv.Index, index).Value.ToString() <> "" _
                 And dgv_detalle_periodo.Item(hora_fin_dgv.Index, index).Value.ToString() <> "" Then

                Select Case index
                    Case 0 :
                        exce.hora_inicio_1 = TimeSpan.Parse(dgv_detalle_periodo.Item(hora_inicio_dgv.Index, index).Value.ToString())
                        exce.hora_fin_1 = TimeSpan.Parse(dgv_detalle_periodo.Item(hora_fin_dgv.Index, index).Value.ToString())
                    Case 1 :
                        exce.hora_inicio_2 = TimeSpan.Parse(dgv_detalle_periodo.Item(hora_inicio_dgv.Index, index).Value.ToString())
                        exce.hora_fin_2 = TimeSpan.Parse(dgv_detalle_periodo.Item(hora_fin_dgv.Index, index).Value.ToString())
                    Case 2 :
                        exce.hora_inicio_3 = TimeSpan.Parse(dgv_detalle_periodo.Item(hora_inicio_dgv.Index, index).Value.ToString())
                        exce.hora_fin_3 = TimeSpan.Parse(dgv_detalle_periodo.Item(hora_fin_dgv.Index, index).Value.ToString())
                    Case 3 :
                        exce.hora_inicio_4 = TimeSpan.Parse(dgv_detalle_periodo.Item(hora_inicio_dgv.Index, index).Value.ToString())
                        exce.hora_fin_4 = TimeSpan.Parse(dgv_detalle_periodo.Item(hora_fin_dgv.Index, index).Value.ToString())
                    Case 4 :
                        exce.hora_inicio_5 = TimeSpan.Parse(dgv_detalle_periodo.Item(hora_inicio_dgv.Index, index).Value.ToString())
                        exce.hora_fin_5 = TimeSpan.Parse(dgv_detalle_periodo.Item(hora_fin_dgv.Index, index).Value.ToString())
                End Select

            End If
        Next
    End Sub

    Private Sub rdSemanal_CheckedChanged(sender As Object, e As EventArgs) Handles rdSemanal.CheckedChanged
        If rdSemanal.Checked Then
            PanelSemanal.BringToFront
        End If
    End Sub

    Private Sub rdUnicaVez_CheckedChanged(sender As Object, e As EventArgs) Handles rdUnicaVez.CheckedChanged
        If rdUnicaVez.Checked Then
            PanelUnicaVez.BringToFront
            rdTerminarFecha.Enabled = False
            rdTerminarVeces.Enabled = False
            dtFin.Value = dtInicio.Value
            numTerminarVeces.Value = 1
            dtFin.Enabled = False
            numTerminarVeces.Enabled = False
        Else
            rdTerminarFecha.Enabled = True
            rdTerminarVeces.Enabled = True
            dtFin.Enabled = True
            numTerminarVeces.Enabled = True
        End If
    End Sub

    Private Sub rdDiario_CheckedChanged(sender As Object, e As EventArgs) Handles rdDiario.CheckedChanged
        If rdDiario.Checked Then
            PanelDiario.BringToFront
        End If
    End Sub

    Private Sub rdMensual_CheckedChanged(sender As Object, e As EventArgs) Handles rdMensual.CheckedChanged
        If rdMensual.Checked Then
            PanelMensual.BringToFront
        End If
    End Sub

    Private Sub rdAnual_CheckedChanged(sender As Object, e As EventArgs) Handles rdAnual.CheckedChanged
        If rdAnual.Checked Then
            PanelAnual.BringToFront
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If rdNoLaborable.Checked Then
            exce.laborable = False

        ElseIf rdLaborable.Checked Then
            GuardarPeriodosLaborables
            exce.laborable = True
        End If

        exce.fecha_comienzo = dtInicio.Value
        exce.fecha_fin = dtFin.Value

        If rdUnicaVez.Checked Then
            exce.freq_type = 1
            exce.freq_interval = 0
        ElseIf rdDiario.Checked Then
            exce.freq_type = 4
            exce.freq_interval = numCantDias.Value
        ElseIf rdSemanal.Checked Then
            exce.freq_type = 8
            exce.freq_interval = CalcularDiasSemanales
        ElseIf rdMensual.Checked Then
            exce.freq_type = 16
            exce.freq_interval = numDiaMes.Value
        ElseIf rdAnual.Checked Then
            exce.freq_type = 64
            exce.freq_interval = Convert.ToInt32(dtAnual.Value.ToString("ddMM"))
        End If



        ControladorCalendario.ActualizarExcepcion(exce)

        Me.Close
    End Sub

    Private Function CalcularDiasSemanales() As Integer
        Dim lunes, martes, miercoles, jueves, viernes, sabado, domingo As Integer
        domingo = If(chkDomingo.Checked, 1, 0)
        lunes = If(chkLunes.Checked, 2, 0)
        martes = If(chkMartes.Checked, 4, 0)
        miercoles = If(chkMiercoles.Checked, 8, 0)
        jueves = If(chkJueves.Checked, 16, 0)
        viernes = If(chkViernes.Checked, 32, 0)
        sabado = If(chkSabado.Checked, 64, 0)

        Return lunes Or martes Or miercoles Or jueves Or viernes Or sabado Or domingo

    End Function

    Private Sub dgv_detalle_periodo_RowValidated(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_detalle_periodo.RowValidated
        If e.RowIndex >= 0 Then
            For index = 0 To dgv_detalle_periodo.Rows.Count - 1
                If dgv_detalle_periodo.Item(hora_inicio_dgv.Index, index).Value.ToString() <> "" _
                     And dgv_detalle_periodo.Item(hora_fin_dgv.Index, index).Value.ToString() <> "" Then

                    Select Case index
                        Case 0 :
                            exce.hora_inicio_1 = TimeSpan.Parse(dgv_detalle_periodo.Item(hora_inicio_dgv.Index, index).Value.ToString())
                            exce.hora_fin_1 = TimeSpan.Parse(dgv_detalle_periodo.Item(hora_fin_dgv.Index, index).Value.ToString())
                        Case 1 :
                            exce.hora_inicio_2 = TimeSpan.Parse(dgv_detalle_periodo.Item(hora_inicio_dgv.Index, index).Value.ToString())
                            exce.hora_fin_2 = TimeSpan.Parse(dgv_detalle_periodo.Item(hora_fin_dgv.Index, index).Value.ToString())
                        Case 2 :
                            exce.hora_inicio_3 = TimeSpan.Parse(dgv_detalle_periodo.Item(hora_inicio_dgv.Index, index).Value.ToString())
                            exce.hora_fin_3 = TimeSpan.Parse(dgv_detalle_periodo.Item(hora_fin_dgv.Index, index).Value.ToString())
                        Case 3 :
                            exce.hora_inicio_4 = TimeSpan.Parse(dgv_detalle_periodo.Item(hora_inicio_dgv.Index, index).Value.ToString())
                            exce.hora_fin_4 = TimeSpan.Parse(dgv_detalle_periodo.Item(hora_fin_dgv.Index, index).Value.ToString())
                        Case 4 :
                            exce.hora_inicio_5 = TimeSpan.Parse(dgv_detalle_periodo.Item(hora_inicio_dgv.Index, index).Value.ToString())
                            exce.hora_fin_5 = TimeSpan.Parse(dgv_detalle_periodo.Item(hora_fin_dgv.Index, index).Value.ToString())
                    End Select                   
                Else
                    ''If e.ColumnIndex = hora_fin_dgv.Index Then
                        Select Case index
                            Case 0 :
                                exce.hora_inicio_1 = Nothing
                                exce.hora_fin_1 = Nothing
                            Case 1 :
                                exce.hora_inicio_2 = Nothing
                                exce.hora_fin_2 =Nothing
                            Case 2 :
                                exce.hora_inicio_3 = Nothing
                                exce.hora_fin_3 = Nothing
                            Case 3 :
                                exce.hora_inicio_4 = Nothing
                                exce.hora_fin_4 = Nothing
                            Case 4 :
                                exce.hora_inicio_5 = Nothing
                                exce.hora_fin_5 = Nothing
                        End Select
                        ''End If                    
                End If
            Next
        End If
    End Sub

    Private Sub rdNoLaborable_CheckedChanged(sender As Object, e As EventArgs) Handles rdNoLaborable.CheckedChanged
        If rdNoLaborable.Checked Then
            dgv_detalle_periodo.Rows.Clear
            exce.laborable = False
            exce.hora_inicio_1 = Nothing
            exce.hora_fin_1 = Nothing
            exce.hora_inicio_2 = Nothing
            exce.hora_fin_2 = Nothing
            exce.hora_inicio_3 = Nothing
            exce.hora_fin_3 = Nothing
            exce.hora_inicio_4 = Nothing
            exce.hora_fin_4 = Nothing
            exce.hora_inicio_5 = Nothing
            exce.hora_fin_5 = Nothing
            dgv_detalle_periodo.Enabled = False
        Else
            dgv_detalle_periodo.Enabled = True
            dgv_detalle_periodo.Rows.Add(5)
        End If
    End Sub


    Private Sub CargarDatosExcepcion()
        Me.rdLaborable.Checked = exce.laborable
        Me.rdNoLaborable.Checked = Not exce.laborable

        If exce.laborable Then
            dgv_detalle_periodo.Item(hora_inicio_dgv.Index, 0).Value = If(exce.hora_inicio_1.HasValue, exce.hora_inicio_1.Value, "")
            dgv_detalle_periodo.Item(hora_fin_dgv.Index, 0).Value = If(exce.hora_fin_1.HasValue, exce.hora_fin_1.Value, "")
            dgv_detalle_periodo.Item(hora_inicio_dgv.Index, 1).Value = If(exce.hora_inicio_2.HasValue, exce.hora_inicio_2.Value, "")
            dgv_detalle_periodo.Item(hora_fin_dgv.Index, 1).Value = If(exce.hora_fin_2.HasValue, exce.hora_fin_2.Value, "")
            dgv_detalle_periodo.Item(hora_inicio_dgv.Index, 2).Value = If(exce.hora_inicio_3.HasValue, exce.hora_inicio_3.Value, "")
            dgv_detalle_periodo.Item(hora_fin_dgv.Index, 2).Value = If(exce.hora_fin_3.HasValue, exce.hora_fin_3.Value, "")
            dgv_detalle_periodo.Item(hora_inicio_dgv.Index, 3).Value = If(exce.hora_inicio_4.HasValue, exce.hora_inicio_4.Value, "")
            dgv_detalle_periodo.Item(hora_fin_dgv.Index, 3).Value = If(exce.hora_fin_4.HasValue, exce.hora_fin_4.Value, "")
            dgv_detalle_periodo.Item(hora_inicio_dgv.Index, 4).Value = If(exce.hora_inicio_5.HasValue, exce.hora_inicio_5.Value, "")
            dgv_detalle_periodo.Item(hora_fin_dgv.Index, 4).Value = If(exce.hora_fin_5.HasValue, exce.hora_fin_5.Value, "")
        End If


        Select Case exce.freq_type.Value
            Case 1 ''Unica vez
                rdUnicaVez.Checked = True
            Case 4 ''Diario
                rdDiario.Checked = True
                numCantDias.Value = exce.freq_interval
            Case 8 ''Semanal
                rdSemanal.Checked = True
                Dim dias As Char() = Convert.ToString(exce.freq_interval.Value, 2).PadLeft(7,"0").ToCharArray().Reverse().ToArray()
                For index = 0 To dias.Count -1

                    Dim chk As CheckBox
                    Select Case index
                        Case 0
                            chk = chkDomingo
                            Case 1
                            chk = chkLunes
                            Case 2
                            chk = chkMartes
                            Case 3
                            chk = chkMiercoles
                            Case 4
                            chk = chkJueves
                            Case 5
                            chk = chkViernes
                            Case 6 
                            chk = chkSabado
                    End Select

                    If dias(index) = "1" Then
                        chk.Checked = True
                    End If
                Next
            Case 16 ''Mensual
                numDiaMes.Value = exce.freq_interval
                rdMensual.Checked = True
            Case 32 ''Mensual relativo
                rdMensual.Checked = True
            Case 64 ''Anual
                Dim aux As String = exce.freq_interval.ToString().PadLeft(4, "0").Insert(2, "/") & "/" & exce.fecha_comienzo.Value.Year
                dtAnual.Value = DateTime.Parse(aux, CultureInfo.CreateSpecificCulture("es-ES"))
                rdAnual.Checked = True
        End Select

        dtInicio.Value = exce.fecha_comienzo
        dtFin.Value = exce.fecha_fin
        rdTerminarFecha.Checked = True

    End Sub

    Private Sub frmDetalleExcepcion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class