Public Class frmPropiedadesActividad

    Dim id_actividad_proyecto As Integer
    Dim actividad As Actividad

    Public Sub New(ByVal id_actividad_proyecto As Integer)
        InitializeComponent()
        Me.id_actividad_proyecto = id_actividad_proyecto
    End Sub

    Private Sub frmPropiedadesActividad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actividad = New Actividad()

        dgv_horas_actividad.DataSource = actividad.GetHorasTrabajadas(id_actividad_proyecto)

        Dim horas As Double = 0
        For Each row As DataGridViewRow In dgv_horas_actividad.Rows
            horas = horas + CDbl(row.Cells(1).Value.ToString())
        Next

        Me.txtHorasConsumidas.Text = horas.ToString()
    End Sub

    Private Sub btn_Aceptar_Click(sender As Object, e As EventArgs) Handles btn_Aceptar.Click
        Me.Close()
    End Sub
End Class