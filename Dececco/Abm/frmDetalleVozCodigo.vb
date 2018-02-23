Public Class frmDetalleVozCodigo

    Private Sub frmDetalleVozCodigo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Me.lblid_voz.Text = CType(Me.Owner, frmMainControl).lblid_voz.Text
            Me.txtcodigo.Text = CType(Me.Owner, frmMainControl).txtcodigo.Text
            Me.txtcodigo_2.Text = CType(Me.Owner, frmMainControl).txtCodigo_2.Text
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        Try
            With oVoz
                .Cargar()
                .Modificar(CInt(Me.lblid_voz.Text))
                .codigo = Me.txtcodigo.Text
                .codigo_2 = Me.txtcodigo_2.Text
                .Guardar()
            End With
        Catch ex As Exception
        End Try
        Me.Close()
    End Sub

End Class