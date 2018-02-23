Imports Entidades
Imports ControladoresLogica

Public Class frmNuevoCalendario
    Dim Public calen As Calendario_Laboral
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        InsertarCalendario
        DialogResult = DialogResult.OK
        Close
    End Sub

    Private Sub InsertarCalendario()
        Dim calendario As New Calendario_Laboral
        With calendario
            .nombre_calendario = txtNombreCalendario.Text
            .es_calendario_base = True            
        End With
        calen = ControladorCalendario.Insertar(calendario)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        DialogResult = DialogResult.Cancel
        Close
    End Sub

    Private Sub frmNuevoCalendario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class