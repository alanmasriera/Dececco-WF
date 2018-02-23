Public Class frmMain

    Private Sub Botones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim btnTemp As New Button
        btnTemp = CType(sender, Button)

        Select Case btnTemp.Name
            Case "btnControl"
                Dim frmTemp As New frmControlActividad

                frmTemp.ShowDialog()
                'frmControlActividad.Show()
                'Me.Close()
            Case "btnSeguridad"
                Dim frmTemp As New frmSeguridad
                frmTemp.ShowDialog()
            Case "btnDato"
                Dim frmTemp As New Form
                frmTemp = frmAbmProyecto
                frmTemp.ShowDialog()
            Case "btnProyecto"
                Dim frmTemp As New frmMainProyecto
                frmTemp.ShowDialog()
        End Select
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmTemp As New frmMainControl
        frmTemp.ShowDialog()
    End Sub


    Private Sub btnAsignarControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmTemp As New frmAbmMovimiento_voz
        frmTemp.ShowDialog()
    End Sub

    Private Sub btnControlPM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmTemp As New frmControlPM
        frmTemp.ShowDialog()
    End Sub


    '¡'''''''''''''''''''''
    '       menu
    '¡'''''''''''''''''''


    Private Sub AdministrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdministrarToolStripMenuItem.Click
        Dim frmTemp As New frmMainProyecto

        frmTemp.ShowDialog()
    End Sub

    Private Sub AdministrarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdministrarToolStripMenuItem1.Click
        Dim frmTemp As New frmMainControl
        frmTemp.ShowDialog()
    End Sub

    Private Sub CadistaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadistaToolStripMenuItem.Click
        Dim frmTemp As New frmControlActividad
        Me.AddOwnedForm(frmTemp)
        frmTemp.ShowDialog()
    End Sub

    Private Sub ProyectManagerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProyectManagerToolStripMenuItem.Click
        Dim frmTemp As New frmControlPM
        frmTemp.ShowDialog()
    End Sub

    Private Sub AdministrarToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdministrarToolStripMenuItem2.Click
        Dim frmTemp As New frmSeguridad
        frmTemp.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblid_actividad.Text = CType(Me.Owner, frmLoginInicio).lblid_actividad.Text
        Me.lblid_actividad_proyecto.Text = CType(Me.Owner, frmLoginInicio).lblid_actividad_proyecto.Text
        Me.lblid_proyecto.Text = CType(Me.Owner, frmLoginInicio).lblid_proyecto.Text
        Me.lblid_cuerpo_movimiento_hora.Text = CType(Me.Owner, frmLoginInicio).lblid_cuerpo_movimiento_hora.Text
        Me.lblNodo.Text = CType(Me.Owner, frmLoginInicio).lblNodo.Text
    End Sub

    Private Sub OrdenarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdenarToolStripMenuItem.Click
        oVoz.UpdateRandom()
    End Sub

    Private Sub ControlToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControlToolStripMenuItem.Click
        Dim frmTemp As New frmAbmMovimiento_hora
        frmTemp.ShowDialog()
    End Sub

    Private Sub CalendarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalendarioToolStripMenuItem.Click
        Dim frmTemp As New frmDetalleCalendario
        frmTemp.ShowDialog()
    End Sub



End Class