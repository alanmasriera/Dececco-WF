Public Class frmNuevoCalendario

    Private Sub frmNuevoCalendario_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim odt As New DataTable
        Dim intMax As Integer = 0

        Me.cmbAnio.Items.Clear()
        For i As Integer = CInt(Date.Now.Year) To CInt(Date.Now.Year) + 10
            Me.cmbAnio.Items.Add(i)
        Next

    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        Dim dtFecha As DateTime
        Dim hora_inicio, hora_fin As DateTime
        Dim intTipoDia As Integer = 0
        Dim dia_laboral As Boolean = False

        Me.Cursor = Cursors.WaitCursor

        dtFecha = CDate("01-01-" & Me.cmbAnio.Text)
        While Year(dtFecha) < CInt(Me.cmbAnio.Text) + 1

            Select Case dtFecha.DayOfWeek
                'sabados y domingos
                Case DayOfWeek.Saturday, DayOfWeek.Sunday
                    dia_laboral = False
                    hora_inicio = New DateTime(dtFecha.Year, dtFecha.Month, dtFecha.Day, 8, 0, 0)
                    hora_fin = New DateTime(dtFecha.Year, dtFecha.Month, dtFecha.Day, 13, 0, 0)
                    'dias de la semana
                Case Else
                    dia_laboral = True
                    hora_inicio = New DateTime(dtFecha.Year, dtFecha.Month, dtFecha.Day, 8, 0, 0)
                    hora_fin = New DateTime(dtFecha.Year, dtFecha.Month, dtFecha.Day, 16, 30, 0)
            End Select


            If oCalendario.Exist_2(dtFecha.Date) <> 0 Then

            Else
                With oCalendario
                    .Cargar()
                    .Insertar()
                    .id_dia = 0
                    .hora_inicio = hora_inicio
                    .hora_fin = hora_fin
                    .dia_laboral = dia_laboral
                    .feriado = False
                    .fecha = dtFecha.Date
                    .Guardar()
                End With
            End If

            dtFecha = dtFecha.AddDays(1)
        End While

        Me.Cursor = Cursors.Default

        MessageBox.Show("Se ha creado el calendario " & Me.cmbAnio.Text)
    End Sub

End Class