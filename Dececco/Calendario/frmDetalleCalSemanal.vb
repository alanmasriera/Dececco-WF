Imports Entidades
Imports ControladoresLogica

Public Class frmDetalleCalSemanal

    
    Dim detalles As List(Of Detalle_Calendario_Laboral)
    Dim definicion As Definicion_Calendario_Laboral
    Dim detalle As Detalle_Calendario_Laboral
    Dim validar As Boolean = False

    Public Sub New(ByRef definicion As Definicion_Calendario_Laboral)

        ' This call is required by the designer.
        InitializeComponent()
        Me.definicion = definicion
        ' Add any initialization after the InitializeComponent() call.
        detalles = ControladorCalendario.ObtenerDetalles(definicion)

        dgv_detalle_calendario.Rows.Add(5)
    End Sub
    Private Sub frmDetalleCalSemanal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstDias.SelectedIndex = 0
        

    End Sub

    Private Sub lstDias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDias.SelectedIndexChanged
        If (definicion IsNot Nothing) Then

            ''Actualiza la lista con el valor actual antes de cambiar
            validar = False


            Dim result = From d In detalles Where d.id_dia = ControladorCalendario.ObtenerDiaPorNombre(lstDias.SelectedIndex).id_dia
            detalle = result.First

            ''TODO
            If detalle Is Nothing Then
                Exit Sub
            End If

            dgv_detalle_calendario.Rows.Clear
            dgv_detalle_calendario.Rows.Add(5)

            rdTomarDeBase.Checked = detalle.importa_base
            rdNoLaborable.Checked = detalle.no_laborable
            
            ''Periodo especificp
            If Not detalle.no_laborable And Not detalle.importa_base Then

                rdPeriodoEspecifico.Checked = True

                With dgv_detalle_calendario

                Dim id As Integer
                id = 0        
                If detalle.hora_desde_1 IsNot Nothing Then         
                .Item(hora_inicio_dgv.Index,id).Value = detalle.hora_desde_1.ToString()
                .Item(hora_fin_dgv.Index, id).Value = detalle.hora_hasta_1.ToString()
                    End If
                If detalle.hora_desde_2 IsNot Nothing Then
                    id = 1
                    .Item(hora_inicio_dgv.Index,id).Value = detalle.hora_desde_2.ToString()
                    .Item(hora_fin_dgv.Index, id).Value = detalle.hora_hasta_2.ToString()
                End If

                 If detalle.hora_desde_3 IsNot Nothing Then
                    id = 2
                    .Item(hora_inicio_dgv.Index,id).Value = detalle.hora_desde_3.ToString()
                    .Item(hora_fin_dgv.Index, id).Value = detalle.hora_hasta_3.ToString()
                End If

                 If detalle.hora_desde_4 IsNot Nothing Then
                    id = 3
                    .Item(hora_inicio_dgv.Index,id).Value = detalle.hora_desde_4.ToString()
                    .Item(hora_fin_dgv.Index, id).Value = detalle.hora_hasta_4.ToString()
                End If

                 If detalle.hora_desde_5 IsNot Nothing Then
                    id = 4
                    .Item(hora_inicio_dgv.Index,id).Value = detalle.hora_desde_5.ToString()
                    .Item(hora_fin_dgv.Index, id).Value = detalle.hora_hasta_5.ToString()
                End If
                End With

            End If

            

            


           validar= True
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        For Each detalle In detalles
            ControladorCalendario.ActualizarDetalle(detalle)
        Next
        Close
    End Sub

    Private Sub dgv_detalle_calendario_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_detalle_calendario.RowValidated
        If e.RowIndex >= 0 And validar Then

            Dim result = From d In detalles Where d.id_dia = ControladorCalendario.ObtenerDiaPorNombre(lstDias.SelectedIndex).id_dia
            Dim ddetalle As Detalle_Calendario_Laboral = result.First

            For index = 0 To dgv_detalle_calendario.Rows.Count-1
                If  dgv_detalle_calendario.Item(hora_inicio_dgv.Index, index).Value IsNot Nothing _
                     And dgv_detalle_calendario.Item(hora_fin_dgv.Index, index).Value IsNot Nothing Then

                    Select Case index
                        Case 0:
                                detalle.hora_desde_1 = TimeSpan.Parse(dgv_detalle_calendario.Item(hora_inicio_dgv.Index, index).Value)
                                detalle.hora_hasta_1 = TimeSpan.Parse(dgv_detalle_calendario.Item(hora_fin_dgv.Index, index).Value)
                        Case 1:
                                detalle.hora_desde_2 = TimeSpan.Parse(dgv_detalle_calendario.Item(hora_inicio_dgv.Index, index).Value)
                                detalle.hora_hasta_2 = TimeSpan.Parse(dgv_detalle_calendario.Item(hora_fin_dgv.Index, index).Value)
                        Case 2:
                                detalle.hora_desde_3 = TimeSpan.Parse(dgv_detalle_calendario.Item(hora_inicio_dgv.Index, index).Value)
                                detalle.hora_hasta_3 = TimeSpan.Parse(dgv_detalle_calendario.Item(hora_fin_dgv.Index, index).Value)
                        Case 3:
                                detalle.hora_desde_4 = TimeSpan.Parse(dgv_detalle_calendario.Item(hora_inicio_dgv.Index, index).Value)
                                detalle.hora_hasta_4 = TimeSpan.Parse(dgv_detalle_calendario.Item(hora_fin_dgv.Index, index).Value)
                        Case 4:
                                detalle.hora_desde_5 = TimeSpan.Parse(dgv_detalle_calendario.Item(hora_inicio_dgv.Index, index).Value)
                                detalle.hora_hasta_5 = TimeSpan.Parse(dgv_detalle_calendario.Item(hora_fin_dgv.Index, index).Value)
                    End Select
                   Else
                    Select Case index
                     Case 0:
                                detalle.hora_desde_1 = Nothing
                                detalle.hora_hasta_1 = Nothing
                        Case 1:
                                detalle.hora_desde_2 = Nothing
                                detalle.hora_hasta_2 = Nothing
                        Case 2:
                                detalle.hora_desde_3 = Nothing
                                detalle.hora_hasta_3 = Nothing
                        Case 3:
                                detalle.hora_desde_4 = Nothing
                                detalle.hora_hasta_4 = Nothing
                        Case 4:
                                detalle.hora_desde_5 = Nothing
                                detalle.hora_hasta_5 = Nothing
                    End Select
                End If
            Next
        End If        
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close
    End Sub

    Private Sub rdPeriodoEspecifico_CheckedChanged(sender As Object, e As EventArgs) Handles rdPeriodoEspecifico.CheckedChanged
        If rdPeriodoEspecifico.Checked Then
            dgv_detalle_calendario.Enabled = True
            detalle.no_laborable = False
            detalle.importa_base = False
            Else
            dgv_detalle_calendario.Enabled = False
        End If
    End Sub

    Private Sub rdTomarDeBase_CheckedChanged(sender As Object, e As EventArgs) Handles rdTomarDeBase.CheckedChanged
        If rdTomarDeBase.Checked Then
            detalle.no_laborable = False
            detalle.importa_base = True
            
            Me.dgv_detalle_calendario.Rows.Clear()
            Me.dgv_detalle_calendario.Rows.Add(5)
            Me.dgv_detalle_calendario.Enabled = False

        End If
    End Sub

    Private Sub rdNoLaborable_CheckedChanged(sender As Object, e As EventArgs) Handles rdNoLaborable.CheckedChanged
        If rdNoLaborable.Checked Then
            detalle.no_laborable = True
            detalle.importa_base = False

            Me.dgv_detalle_calendario.Rows.Clear()
            Me.dgv_detalle_calendario.Rows.Add(5)
            Me.dgv_detalle_calendario.Enabled = False
        End If
    End Sub
End Class