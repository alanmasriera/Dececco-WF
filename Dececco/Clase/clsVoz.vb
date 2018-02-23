Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Voz
    Inherits Voz_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Voz As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Voz", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_voz", SqlDbType.Int, 4, "id_voz")
        oda.SelectCommand.Parameters("@id_voz").Value = id_Voz

        oda.Fill(odt)
        Return odt
    End Function

    'funcion de consulta
    Public Function GetAll_2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Voz_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion de busqueda
    Public Function Find_2(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Voz_Find_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'inicio del control
    Public Function GetAllInicio(ByVal id_usuario As Integer, ByVal id_actividad_proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_voz_GetAllInicio", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_usuario
        oda.SelectCommand.Parameters.Add("@id_actividad_proyecto", SqlDbType.Int, 4, "id_actividad_proyecto")
        oda.SelectCommand.Parameters("@id_actividad_proyecto").Value = id_actividad_proyecto

        oda.Fill(odt)
        Return odt
    End Function

    'inicio del control
    Public Function GetAllInicio_2(ByVal id_usuario As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_voz_GetAllInicio_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_usuario

        oda.Fill(odt)
        Return odt
    End Function
    ''' <summary>
    ''' inicio del control - Devuelve las preguntas correspondientes a ese usuario, la actividad y el control segun sea produccion, o primer y segundo control
    ''' </summary>
    Public Function GetAllInicioPM(ByVal id_usuario As Integer, ByVal id_actividad_proyecto As Integer, ByVal id_control As Integer, ByVal idEtapa As Integer) As DataTable
        Dim odt As New DataTable
        Dim consulta As String
        'If opcion = 2 Then
        '    consulta = "cop_Cuerpo_movimiento_voz_GetAllInicioPM_R2"
        'Else
        consulta = "cop_Cuerpo_movimiento_voz_GetAllInicioPM"
        'End If
        ''Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_voz_GetAllInicioPM", cnn.Coneccion)
        Dim oda As New SqlDataAdapter(consulta, cnn.Coneccion)


        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_usuario
        oda.SelectCommand.Parameters.Add("@id_actividad_proyecto", SqlDbType.Int, 4, "id_actividad_proyecto")
        oda.SelectCommand.Parameters("@id_actividad_proyecto").Value = id_actividad_proyecto
        oda.SelectCommand.Parameters.Add("@id_control", SqlDbType.Int, 4, "id_control")
        oda.SelectCommand.Parameters("@id_control").Value = id_control
        oda.SelectCommand.Parameters.Add("@opcion", SqlDbType.Int, 4, "opcion")
        oda.SelectCommand.Parameters("@opcion").Value = idEtapa
        oda.Fill(odt)
        Return odt
    End Function

    'inicio del control
    Public Function GetAllInicio_2_PM(ByVal id_proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_voz_GetAllInicio_2_PM", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_proyecto

        oda.Fill(odt)
        Return odt
    End Function

    'inicio del control
    Public Function GetAllInicio_3_PM(ByVal id_proyecto As Integer, ByVal id_proyect_manager As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_voz_GetAllInicio_3_PM", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_proyecto
        oda.SelectCommand.Parameters.Add("@id_proyect_manager", SqlDbType.Int, 4, "id_proyect_manager")
        oda.SelectCommand.Parameters("@id_proyect_manager").Value = id_proyect_manager

        oda.Fill(odt)
        Return odt
    End Function

    'inicio del control
    Public Function GetAllInicio_3_PM_ConPendiente(ByVal id_proyecto As Integer, ByVal id_proyect_manager As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_voz_GetAllInicio_3_PM_ConPentientes", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_proyecto
        oda.SelectCommand.Parameters.Add("@id_proyect_manager", SqlDbType.Int, 4, "id_proyect_manager")
        oda.SelectCommand.Parameters("@id_proyect_manager").Value = id_proyect_manager

        oda.Fill(odt)
        Return odt
    End Function

    'inicio del control
    Public Function GetAllInicio_4_PM(ByVal id_proyect_manager As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_voz_GetAllInicio_4_PM", cnn.Coneccion)
        'Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_voz_GetAllInicio_ConPendientes", cnn.Coneccion)
        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyect_manager", SqlDbType.Int, 4, "id_proyect_manager")
        oda.SelectCommand.Parameters("@id_proyect_manager").Value = id_proyect_manager

        oda.Fill(odt)
        Return odt
    End Function

    'inicio del control
    Public Function GetAllInicio_4_PM_ConPendientes(ByVal id_proyect_manager As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_voz_GetAllInicio_4_PM_ConPendientes", cnn.Coneccion)
        'Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_voz_GetAllInicio_ConPendientes", cnn.Coneccion)
        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyect_manager", SqlDbType.Int, 4, "id_proyect_manager")
        oda.SelectCommand.Parameters("@id_proyect_manager").Value = id_proyect_manager

        oda.Fill(odt)
        Return odt
    End Function

    Public Function GetInformacion(ByVal id_movimiento_voz As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_voz_GetInformacion", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_movimiento_voz", SqlDbType.Int, 4, "id_movimiento_voz")
        oda.SelectCommand.Parameters("@id_movimiento_voz").Value = id_movimiento_voz

        oda.Fill(odt)
        Return odt
    End Function

    Public Function GetAllInicio_4_PM_EnEspera(ByVal id_proyect_manager As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_voz_GetAllInicio_4_PM_EnEspera", cnn.Coneccion)
        'Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_voz_GetAllInicio_ConPendientes", cnn.Coneccion)
        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyect_manager", SqlDbType.Int, 4, "id_proyect_manager")
        oda.SelectCommand.Parameters("@id_proyect_manager").Value = id_proyect_manager

        oda.Fill(odt)
        Return odt
    End Function

    Public Function GetAllInicio_4_PM_Completados(ByVal id_proyect_manager As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_voz_GetAllInicio_4_PM_Completado", cnn.Coneccion)
        'Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_voz_GetAllInicio_ConPendientes", cnn.Coneccion)
        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyect_manager", SqlDbType.Int, 4, "id_proyect_manager")
        oda.SelectCommand.Parameters("@id_proyect_manager").Value = id_proyect_manager

        oda.Fill(odt)
        Return odt
    End Function

    Public Function GetAllInicio_4_PM_Todos(ByVal id_proyecto As Integer, ByVal id_control As Integer, ByVal Voz As String, ByVal id_cliente As Integer, ByVal id_usuario As Integer, ByVal id_controlador_1 As Integer, ByVal id_controlador_2 As Integer, ByVal fecha_desde As Date, ByVal fecha_hasta As Date, ByVal param_proyecto As Boolean, ByVal param_cadista As Boolean, ByVal param_voz As Boolean, ByVal param_control As Boolean, ByVal param_cliente As Boolean, ByVal param_concepto As Boolean, ByVal param_preparado As Boolean, ByVal param_detallado As Boolean, ByVal param_fecha As Boolean, ByVal id_subproyecto As Integer, ByVal nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_voz_GetAllInicio_4_PM_Todos", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_proyecto
        oda.SelectCommand.Parameters.Add("@id_control", SqlDbType.Int, 4, "id_control")
        oda.SelectCommand.Parameters("@id_control").Value = id_control
        oda.SelectCommand.Parameters.Add("@voz", SqlDbType.VarChar, 4, "voz")
        oda.SelectCommand.Parameters("@voz").Value = Voz
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = id_cliente
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_usuario
        oda.SelectCommand.Parameters.Add("@id_controlador_1", SqlDbType.Int, 4, "id_controlador_1")
        oda.SelectCommand.Parameters("@id_controlador_1").Value = id_controlador_1
        oda.SelectCommand.Parameters.Add("@id_controlador_2", SqlDbType.Int, 4, "id_controlador_2")
        oda.SelectCommand.Parameters("@id_controlador_2").Value = id_controlador_2
        oda.SelectCommand.Parameters.Add("@fecha_desde", SqlDbType.DateTime, 4, "fecha_desde")
        oda.SelectCommand.Parameters("@fecha_desde").Value = fecha_desde
        oda.SelectCommand.Parameters.Add("@fecha_hasta", SqlDbType.DateTime, 4, "fecha_hasta")
        oda.SelectCommand.Parameters("@fecha_hasta").Value = fecha_hasta
        oda.SelectCommand.Parameters.Add("@param_proyecto", SqlDbType.Bit, 4, "param_proyecto")
        oda.SelectCommand.Parameters("@param_proyecto").Value = param_proyecto
        oda.SelectCommand.Parameters.Add("@param_cadista", SqlDbType.Bit, 4, "param_cadista")
        oda.SelectCommand.Parameters("@param_cadista").Value = param_cadista
        oda.SelectCommand.Parameters.Add("@param_voz", SqlDbType.Bit, 4, "param_voz")
        oda.SelectCommand.Parameters("@param_voz").Value = param_voz
        oda.SelectCommand.Parameters.Add("@param_control", SqlDbType.Bit, 4, "param_control")
        oda.SelectCommand.Parameters("@param_control").Value = param_control
        oda.SelectCommand.Parameters.Add("@param_cliente", SqlDbType.Bit, 4, "param_cliente")
        oda.SelectCommand.Parameters("@param_cliente").Value = param_cliente
        oda.SelectCommand.Parameters.Add("@param_concepto", SqlDbType.Bit, 4, "param_concepto")
        oda.SelectCommand.Parameters("@param_concepto").Value = param_concepto
        oda.SelectCommand.Parameters.Add("@param_preparado", SqlDbType.Bit, 4, "param_preparado")
        oda.SelectCommand.Parameters("@param_preparado").Value = param_preparado
        oda.SelectCommand.Parameters.Add("@param_detallado", SqlDbType.Bit, 4, "param_detallado")
        oda.SelectCommand.Parameters("@param_detallado").Value = param_detallado
        oda.SelectCommand.Parameters.Add("@param_fecha", SqlDbType.Bit, 4, "param_fecha")
        oda.SelectCommand.Parameters("@param_fecha").Value = param_fecha
        oda.SelectCommand.Parameters.Add("@id_subproyecto", SqlDbType.Int, 4, "id_subproyecto")
        oda.SelectCommand.Parameters("@id_subproyecto").Value = id_subproyecto
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 200, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = nombre

        oda.Fill(odt)
        Return odt
    End Function


    'ejemplo de consulta con parametros
    Public Function GetNextCode(ByVal codigo As String, ByVal id_tipo_voz As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Voz_GetNextCode", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@codigo", SqlDbType.VarChar, 50, "codigo")
        oda.SelectCommand.Parameters("@codigo").Value = codigo
        oda.SelectCommand.Parameters.Add("@id_tipo_voz", SqlDbType.Int, 4, "id_tipo_voz")
        oda.SelectCommand.Parameters("@id_tipo_voz").Value = id_tipo_voz

        oda.Fill(odt)
        Return odt
    End Function

    'inserta un registro en la tabla
    Public Sub UpdateRandom()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Voz_UpdateRandom"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub
    Public Function GetAllExiste(ByVal nombre_voz As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Voz_GetAllExiste", cnn.Coneccion)
        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_voz", SqlDbType.NVarChar, 500, "nombre__voz")
        oda.SelectCommand.Parameters("@nombre_voz").Value = nombre_voz
        oda.Fill(odt)
        Return odt
    End Function


    'agregado para optener la cantidad de voces
    Public Function Cantidad(ByVal id_control As Integer, ByVal id_tipoVoz As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Voz_cantidad", cnn.Coneccion)
        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_control", SqlDbType.Int, 4, "id_control")
        oda.SelectCommand.Parameters("@id_control").Value = id_control
        oda.SelectCommand.Parameters.Add("@id_tipo_voz", SqlDbType.Int, 4, "id_tipo_voz")
        oda.SelectCommand.Parameters("@id_tipo_voz").Value = id_tipoVoz
        oda.Fill(odt)
        Return odt
    End Function


    'agregado para traer las voces para ese tipo de voz
    Public Function Voces(ByVal id_control As Integer, ByVal id_tipoVoz As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Voz_voces", cnn.Coneccion)
        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_control", SqlDbType.Int, 4, "id_control")
        oda.SelectCommand.Parameters("@id_control").Value = id_control
        oda.SelectCommand.Parameters.Add("@id_tipo_voz", SqlDbType.Int, 4, "id_tipo_voz")
        oda.SelectCommand.Parameters("@id_tipo_voz").Value = id_tipoVoz
        oda.Fill(odt)
        Return odt
    End Function

    Public Function getObservaciones(ByVal id_movimiento_voz As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("getCuerpoMovimientoObservaciones", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_movimiento_voz", SqlDbType.Int, 4, "id_movimiento_voz")
        oda.SelectCommand.Parameters("@id_movimiento_voz").Value = id_movimiento_voz
        oda.Fill(odt)
        Return odt
    End Function

    Public Function getNotas(ByVal id_movimiento_voz As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("voz_getNotas", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_movimiento_voz", SqlDbType.Int, 4, "id_movimiento_voz")
        oda.SelectCommand.Parameters("@id_movimiento_voz").Value = id_movimiento_voz
        oda.Fill(odt)
        Return odt
    End Function

    ''' <summary>
    ''' inicio del control - Devuelve las preguntas correspondientes a ese usuario, la actividad y el control segun sea produccion, o primer y segundo control
    ''' </summary>
    Public Function getCuerpoMovimientoPorTipo(ByVal id_tipo_voz As Integer, ByVal id_movimiento_voz As Integer) As DataTable
        Dim odt As New DataTable
        Dim consulta As String
        'If opcion = 2 Then
        '    consulta = "cop_Cuerpo_movimiento_voz_GetAllInicioPM_R2"
        'Else
        consulta = "getCuerpoMovimientoPorTipo"
        'End If
        ''Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_voz_GetAllInicioPM", cnn.Coneccion)
        Dim oda As New SqlDataAdapter(consulta, cnn.Coneccion)


        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_movimiento_voz", SqlDbType.Int, 4, "id_movimiento_voz")
        oda.SelectCommand.Parameters("@id_movimiento_voz").Value = id_movimiento_voz
        oda.SelectCommand.Parameters.Add("@voz_tipo_voz", SqlDbType.Int, 4, "id_tipo_voz")
        oda.SelectCommand.Parameters("@voz_tipo_voz").Value = id_tipo_voz

        oda.Fill(odt)
        Return odt
    End Function




End Class