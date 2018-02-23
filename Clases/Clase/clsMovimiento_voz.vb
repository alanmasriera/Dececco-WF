Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Movimiento_voz
    Inherits Movimiento_voz_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Movimiento_voz As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Movimiento_voz", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_movimiento_voz", SqlDbType.Int, 4, "id_movimiento_voz")
        oda.SelectCommand.Parameters("@id_movimiento_voz").Value = id_Movimiento_voz

        oda.Fill(odt)
        Return odt
    End Function

    'consulta si la actividad ya tiene asignada un control
    Public Function GetActividadProyecto(ByVal id_actividad_proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Movimiento_voz_GetActividadProyecto", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_actividad_proyecto", SqlDbType.Int, 4, "id_actividad_proyecto")
        oda.SelectCommand.Parameters("@id_actividad_proyecto").Value = id_actividad_proyecto

        oda.Fill(odt)
        Return odt
    End Function

    'consulta si la actividad ya tiene asignada un control
    Public Function GetActividadProyectoCompleto(ByVal id_actividad_proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Movimiento_voz_GetActividadProyectoCompleto", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_actividad_proyecto", SqlDbType.Int, 4, "id_actividad_proyecto")
        oda.SelectCommand.Parameters("@id_actividad_proyecto").Value = id_actividad_proyecto

        oda.Fill(odt)
        Return odt
    End Function

    'consulta si la actividad ya tiene asignada un control
    Public Function GetActividadProyectoEnProceso(ByVal id_actividad_proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Movimiento_voz_GetActividadProyectoEnProceso", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_actividad_proyecto", SqlDbType.Int, 4, "id_actividad_proyecto")
        oda.SelectCommand.Parameters("@id_actividad_proyecto").Value = id_actividad_proyecto

        oda.Fill(odt)
        Return odt
    End Function


    'consulta si la actividad ya tiene asignada un control
    Public Function GetActividadProyectoPrimerControl(ByVal id_actividad_proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Movimiento_voz_GetActividadProyectoPrimerControl", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_actividad_proyecto", SqlDbType.Int, 4, "id_actividad_proyecto")
        oda.SelectCommand.Parameters("@id_actividad_proyecto").Value = id_actividad_proyecto

        oda.Fill(odt)
        Return odt
    End Function


    'actualiza a todos como no corresponde
    Public Sub UpdatePedidoSegundoControl(ByVal id_movimiento_voz As Integer, ByVal pedido_segundo_control As Boolean)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "[cop_movimiento_voz_UpdatePedidoSegundoControl]"
        Command.Parameters.Add("@id_movimiento_voz", SqlDbType.Int, 4, "id_movimiento_voz")
        Command.Parameters("@id_movimiento_voz").Value = id_movimiento_voz
        Command.Parameters.Add("@pedido_segundo_control", SqlDbType.Bit, 1, "pedido_segundo_control")
        Command.Parameters("@pedido_segundo_control").Value = pedido_segundo_control

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub



    Public Function hayErrores(ByVal id_movimiento_voz As Integer) As Boolean
        
        Dim cnn As New Conexion
        Dim sql As String
        Dim cant As Integer

        sql = "Select count(*)  " & _
"from movimiento_voz mv, cuerpo_movimiento_voz cmv " & _
        "where cmv.id_movimiento_voz = mv.id_movimiento_voz " & _
"and (cmv.no_conforme1 = 1 and cmv.correccion1 =  0" & _
"or cmv.no_conforme2 = 1 and cmv.correccion2 = 0) " & _
"and mv.id_movimiento_voz = @id_movimiento_voz"

        da.SelectCommand.Parameters.Add("@id_movimiento_voz", SqlDbType.Int, 4, "id_movimiento_voz")

        Dim cmd As New SqlCommand(sql, cnn.Coneccion)
        cmd.Parameters.Add("@id_movimiento_voz", SqlDbType.Int)
        cmd.Parameters("@id_movimiento_voz").Value = id_movimiento_voz

        Try
            cnn.Abrir()
            cant = Convert.ToInt32(cmd.ExecuteScalar())
        Catch ex As Exception
        End Try

        If cant = 0 Then
            Return False

        End If

        Return True
    End Function

    Public Function obtenerUltimaObservacion(ByVal id_movimiento_voz As Integer) As String

        Dim id_ultimo_codigo_2 As String

        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_movimiento_voz_getUltimaObservacion", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_movimiento_voz", SqlDbType.Int, 4, "id_movimiento_voz")
        oda.SelectCommand.Parameters("@id_movimiento_voz").Value = id_movimiento_voz

        oda.Fill(odt)

        If odt.Rows.Count > 0 Then
            id_ultimo_codigo_2 = CInt(CInt(odt.Rows(0).Item("id_ultimo_codigo_2").ToString()) + 1).ToString()
        Else
            id_ultimo_codigo_2 = "1"
        End If

        Return id_ultimo_codigo_2

    End Function

    Public Function obtenerMovimientoVozDesdeActividadProyecto(ByVal id_actividad_proyecto As Integer) As Integer

        Dim id_ultimo_codigo_2 As Integer

        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Movimiento_voz_ObtenerDesdeProyectoActividad", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_actividad_proyecto", SqlDbType.Int, 4, "id_actividad_proyecto")
        oda.SelectCommand.Parameters("@id_actividad_proyecto").Value = id_actividad_proyecto

        oda.Fill(odt)

        If odt.Rows.Count > 0 Then
            id_ultimo_codigo_2 = CInt(odt.Rows(0).Item("id_movimiento_voz").ToString())
        Else
            id_ultimo_codigo_2 = 0
        End If

        Return id_ultimo_codigo_2

    End Function

    Public Function ObtenerDatos(ByVal id_movimiento_voz As Integer) As DataTable
        Dim odt As New DataTable

        Dim oda As New SqlDataAdapter("cop_movimiento_voz_obtenerEstados", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_movimiento_voz", SqlDbType.Int, 6, "id_movimiento_voz")
        oda.SelectCommand.Parameters("@id_movimiento_voz").Value = id_movimiento_voz

        oda.Fill(odt)

        Return odt
    End Function

    Public Function ObtenerDatosExtras(ByVal id_movimiento_voz As Integer) As DataTable
        Dim odt As New DataTable

        Dim oda As New SqlDataAdapter("cop_movimiento_voz_obtenerDetallesExtras", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_movimiento_voz", SqlDbType.Int, 6, "id_movimiento_voz")
        oda.SelectCommand.Parameters("@id_movimiento_voz").Value = id_movimiento_voz

        oda.Fill(odt)

        Return odt
    End Function



End Class
