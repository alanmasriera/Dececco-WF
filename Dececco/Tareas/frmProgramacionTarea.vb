Imports System.Globalization
Imports ControladoresLogica
Imports Entidades

Public Class frmProgramacionTarea
    Private activ_proy As Entidades.Actividad_proyecto
    Private progr_actividad As Entidades.Programacion_Actividad
    Dim progr As New Programacion_Actividad

    Public Sub New(activ_proy As Entidades.Actividad_proyecto)

        Me.InitializeComponent

        Me.activ_proy = activ_proy
        ObtenerProgramacionDeActividad(activ_proy)
        CargarDatos

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        progr.fecha_inicio = dtInicio.Value
        progr.fecha_fin = dtFin.Value

        If rdUnicaVez.Checked Then
            progr.freq_type = 1
            progr.freq_interval = 0
        ElseIf rdDiario.Checked Then
            progr.freq_type = 4
            progr.freq_interval = numCantDias.Value
        ElseIf rdSemanal.Checked Then
            progr.freq_type = 8
            progr.freq_interval = CalcularDiasSemanales
        ElseIf rdMensual.Checked Then
            progr.freq_type = 16
            progr.freq_interval = numDiaMes.Value
        ElseIf rdAnual.Checked Then
            progr.freq_type = 64
            progr.freq_interval = Convert.ToInt32(dtAnual.Value.ToString("ddMM"))
        End If

        progr = ControladorTareas.InsertarOActualizarProgramacion(progr)

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

    Private Sub CargarDatos
        txtNombreActividad.Text = ControladorActividades.ObtenerActividad(activ_proy).nombre_actividad
        txtNombreTarea.Text = progr.nombre_programacion

        If progr.freq_type Is Nothing Then
            progr.freq_type = 0
            progr.freq_interval = 0
        End If

        Select Case progr.freq_type.Value
            Case 1 ''Unica vez
                rdUnicaVez.Checked = True
            Case 4 ''Diario
                rdDiario.Checked = True
                numCantDias.Value = progr.freq_interval
            Case 8 ''Semanal
                rdSemanal.Checked = True
                Dim dias As Char() = Convert.ToString(progr.freq_interval.Value, 2).PadLeft(7, "0").ToCharArray().Reverse().ToArray()
                For index = 0 To dias.Count - 1

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
                numDiaMes.Value = progr.freq_interval
                rdMensual.Checked = True
            Case 32 ''Mensual relativo
                rdMensual.Checked = True
            Case 64 ''Anual
                Dim aux As String = progr.freq_interval.ToString().PadLeft(4, "0").Insert(2, "/") & "/" & progr.fecha_inicio.Value.Year
                dtAnual.Value = DateTime.Parse(aux, CultureInfo.CreateSpecificCulture("es-ES"))
                rdAnual.Checked = True
        End Select
        
        dtInicio.Value = If(progr.fecha_inicio IsNot Nothing, progr.fecha_inicio, Date.Today)
        dtFin.Value = If(progr.fecha_fin IsNot Nothing, progr.fecha_fin, Date.Today)


    End Sub

    Private Sub ObtenerProgramacionDeActividad(ByRef activ_proy As Entidades.Actividad_proyecto)
        progr = ControladorTareas.ObtenerProgramacion(activ_proy)

        If progr Is Nothing Then
            progr = New Programacion_Actividad
            progr.id_actividad_proyecto = activ_proy.id_actividad_proyecto
        End If
    End Sub

    Private Sub rdUnicaVez_CheckedChanged(sender As Object, e As EventArgs) Handles rdUnicaVez.CheckedChanged
        If rdUnicaVez.Checked Then
            PanelUnicaVez.BringToFront
        End If
    End Sub

    Private Sub rdDiario_CheckedChanged(sender As Object, e As EventArgs) Handles rdDiario.CheckedChanged
        If rdDiario.Checked Then
            PanelDiario.BringToFront
        End If
    End Sub

    Private Sub rdSemanal_CheckedChanged(sender As Object, e As EventArgs) Handles rdSemanal.CheckedChanged
        If rdSemanal.Checked Then
            PanelSemanal.BringToFront
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

    Private Sub frmProgramacionTarea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rdUnicaVez.Checked = True
    End Sub
End Class