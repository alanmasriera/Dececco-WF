Imports System.Data.SqlClient

Public Class frmNuevaVoz

    Dim id_movimiento_voz As Integer
    Dim _Cuerpo_Movimiento_voz_obs As New Cuerpo_movimiento_voz
    Dim _Voz As New Voz
    Dim observaciones As DataTable
    Dim posicion As Integer
    Dim id_voz_actual As Integer
    Dim id_cuerpo_movimiento_voz_actual As Integer

    Public Sub New(ByVal id_movimiento_voz As Integer)
        InitializeComponent()
        Me.id_movimiento_voz = id_movimiento_voz

    End Sub

    Private Sub frmNuevaVoz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = -1
        observaciones = _Cuerpo_Movimiento_voz_obs.GetObservaciones(Me.id_movimiento_voz)

        If observaciones.Rows.Count > 0 Then
            Me.posicion = 0
            MostrarObservacion(CInt(observaciones.Rows(posicion).Item("id_cuerpo_movimiento_voz")))
        Else
            Me.txt_nombre_voz.Enabled = False
        End If

    End Sub

    Private Sub GuardarNuevo()

        If Me.txt_nombre_voz.Text <> "" Then
            Dim odt As New DataTable
            Dim consulta As String
            Dim cnn As New Conexion
            Dim id_voz As Integer


            consulta = "INSERT INTO VOZ (nombre_voz) VALUES (@nombre_voz) SELECT SCOPE_IDENTITY()"

            Dim oda As New SqlDataAdapter(consulta, cnn.Coneccion)

            oda.SelectCommand.CommandType = CommandType.Text
            oda.SelectCommand.Parameters.Add("@nombre_voz", SqlDbType.VarChar, 500, "nombre_voz")
            oda.SelectCommand.Parameters("@nombre_voz").Value = txt_nombre_voz.Text

            oda.Fill(odt)

            id_voz = CInt(odt.Rows(0).Item(0))

            With oVoz
                .Cargar()
                .Modificar(id_voz)
                .codigo = "Z"
                .codigo_2 = oMovimiento_voz.obtenerUltimaObservacion(id_movimiento_voz)
                .icono = ""
                .Guardar()
            End With

            With oCuerpo_movimiento_voz
                .Cargar()
                .Insertar()
                .id_voz = id_voz
                .control1 = True
                .completado_pm = True
                .conforme1 = False
                .no_conforme1 = True
                .id_movimiento_voz = id_movimiento_voz
                .Guardar()
            End With

            Me.id_cuerpo_movimiento_voz_actual = oCuerpo_movimiento_voz.id_cuerpo_movimiento_voz
            Me.id_voz_actual = oVoz.id_voz
            observaciones = _Cuerpo_Movimiento_voz_obs.GetObservaciones(Me.id_movimiento_voz)

        End If

    End Sub

    Private Sub MostrarObservacion(ByVal id_cuerpo_movimiento_voz As Integer)

        With _Cuerpo_Movimiento_voz_obs
            .Cargar()
            .Modificar(id_cuerpo_movimiento_voz)
            Me.id_cuerpo_movimiento_voz_actual = id_cuerpo_movimiento_voz
        End With

        With _Voz
            .Cargar()
            .Modificar(_Cuerpo_Movimiento_voz_obs.id_voz)
            Me.id_voz_actual = .id_voz
        End With

        Me.txt_nombre_voz.Text = _Voz.nombre_voz

    End Sub

    Private Sub Actualizar()

        With _Voz
            .Cargar()
            .Modificar(Me.id_voz_actual)
            .nombre_voz = Me.txt_nombre_voz.Text
            .Guardar()
        End With


    End Sub

    Private Sub Borrar()

        If Me.id_cuerpo_movimiento_voz_actual <> 0 Then
            With _Voz
                .Cargar()
                .Borrar(Me.id_voz_actual)
            End With
            Me.id_voz_actual = 0

            With _Cuerpo_Movimiento_voz_obs
                .Cargar()
                .Borrar(Me.id_cuerpo_movimiento_voz_actual)
            End With
            Me.id_cuerpo_movimiento_voz_actual = 0

            observaciones = _Cuerpo_Movimiento_voz_obs.GetObservaciones(Me.id_movimiento_voz)

            If posicion - 1 > -1 And observaciones.Rows.Count > posicion - 1 Then
                posicion = posicion - 1
                MostrarObservacion(CInt(Me.observaciones.Rows(posicion).Item("id_cuerpo_movimiento_voz")))
            ElseIf observaciones.Rows.Count > posicion + 1 Then
                posicion = posicion + 1
                MostrarObservacion(CInt(Me.observaciones.Rows(posicion).Item("id_cuerpo_movimiento_voz")))
            Else
                Me.txt_nombre_voz.Enabled = False
            End If
        End If

    End Sub


    Private Sub Limpiar()
        txt_nombre_voz.Text = ""
        Me.id_cuerpo_movimiento_voz_actual = 0
        Me.id_voz_actual = 0
        Me.txt_nombre_voz.Enabled = True
        posicion = observaciones.Rows.Count
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        If Me.posicion - 1 > -1 Then

            Me.txt_nombre_voz.Enabled = True
            posicion = posicion - 1
            MostrarObservacion(CInt(Me.observaciones.Rows(posicion).Item("id_cuerpo_movimiento_voz")))

        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If Me.posicion + 1 < Me.observaciones.Rows.Count Then

            Me.txt_nombre_voz.Enabled = True
            posicion = posicion + 1
            MostrarObservacion(CInt(Me.observaciones.Rows(posicion).Item("id_cuerpo_movimiento_voz")))

        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If Me.id_cuerpo_movimiento_voz_actual <> 0 Then
            Me.Actualizar()
        Else
            Me.GuardarNuevo()
        End If

        Me.Limpiar()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Me.Borrar()
        Me.Limpiar()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.id_cuerpo_movimiento_voz_actual <> 0 Then
            Me.Actualizar()
            'MessageBox.Show("Observación actualizada correctamente", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Me.GuardarNuevo()
            'MessageBox.Show("Observación guardada correctamente", "Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub frmNuevaVoz_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.id_cuerpo_movimiento_voz_actual <> 0 Then
            With oCuerpo_movimiento_voz
                .Cargar()
                .Modificar(Me.id_cuerpo_movimiento_voz_actual)
                oVoz.Modificar(.id_voz)
            End With
            If Me.txt_nombre_voz.Text <> oVoz.nombre_voz Then
                If MessageBox.Show("¿Desea guardar los cambios antes de salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Me.Actualizar()
                End If
            End If
        Else
            If Me.txt_nombre_voz.Text <> "" Then
                If MessageBox.Show("¿Desea guardar los cambios antes de salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Me.GuardarNuevo()
                End If
            End If
        End If

    End Sub
End Class