Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Actividad_proyecto
    Inherits Actividad_proyecto_ent

    'trae las actividades del proyecto
    Public Function GetAllProyecto(ByVal id_proyecto As Integer, ByVal id_subproyecto As Integer, ByVal id_cliente As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Actividad_proyecto_GetAllProyecto", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_proyecto
        oda.SelectCommand.Parameters.Add("@id_subproyecto", SqlDbType.Int, 4, "id_subproyecto")
        oda.SelectCommand.Parameters("@id_subproyecto").Value = id_subproyecto
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = id_cliente

        oda.Fill(odt)
        Return odt
    End Function

    Public Function GetAllProyectoConCliente(ByVal id_proyecto As Integer, ByVal id_cliente As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Actividad_proyecto_GetAllProyecto_conCliente", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_proyecto
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = id_cliente

        oda.Fill(odt)
        Return odt
    End Function

    Public Function GetAllSubproyectoConHijos(ByVal id_subproyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Actividad_proyecto_GetAllSubProyectoConHijos", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_subproyecto", SqlDbType.Int, 4, "id_subproyecto")
        oda.SelectCommand.Parameters("@id_subproyecto").Value = id_subproyecto

        oda.Fill(odt)
        Return odt
    End Function

    Public Function GetAllProyectoConHijos(ByVal id_proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Actividad_proyecto_GetAllProyectoConHijos", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_proyecto

        oda.Fill(odt)
        Return odt
    End Function

    Public Function GetControl(ByVal id_actividad_proyecto As Integer, ByVal id_tipo_actividad As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Actividad_proyecto_GetControl", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_actividad_proyecto", SqlDbType.Int, 4, "id_actividad_proyecto")
        oda.SelectCommand.Parameters("@id_actividad_proyecto").Value = id_actividad_proyecto
        oda.SelectCommand.Parameters.Add("@id_tipo_actividad", SqlDbType.Int, 4, "id_tipo_actividad")
        oda.SelectCommand.Parameters("@id_tipo_actividad").Value = id_tipo_actividad

        oda.Fill(odt)
        Return odt
    End Function

    Public Function HayHorasCargadas(ByVal id_actividad_proyecto As Integer) As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Actividad_proyecto_hayHoras", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_actividad_proyecto", SqlDbType.Int, 4, "id_actividad_proyecto")
        oda.SelectCommand.Parameters("@id_actividad_proyecto").Value = id_actividad_proyecto

        oda.Fill(odt)

        If odt.Rows.Count = 0 Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Function ExistTipoActividad(ByVal id_tipo_actividad As Integer) As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Actividad_proyecto_ExistTipo_Actividad", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tipo_actividad", SqlDbType.Int, 4, "id_tipo_actividad")
        oda.SelectCommand.Parameters("@id_tipo_actividad").Value = id_tipo_actividad

        oda.Fill(odt)

        If odt.Rows.Count = 0 Then
            Return False
        Else
            Return True
        End If

    End Function

    'funcion para llenar el combo
    Public Function GetCmb_2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Actividad_proyecto_GetCmb_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne_2(ByVal id_Actividad_proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Actividad_proyecto_GetOne_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_actividad_proyecto", SqlDbType.Int, 4, "id_actividad_proyecto")
        oda.SelectCommand.Parameters("@id_actividad_proyecto").Value = id_Actividad_proyecto

        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id de la actividad
    Public Function GetOne_1(ByVal id_actividad As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Actividad_proyecto_GetOne_1act", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_actividad", SqlDbType.Int, 4, "id_actividad")
        oda.SelectCommand.Parameters("@id_actividad").Value = id_actividad

        oda.Fill(odt)

        Return odt
    End Function
    'funcion que trae un registro poniendo el id
    Public Function GetOne_3(ByVal id_proyecto As Integer, ByVal id_actividad As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Actividad_proyecto_GetOne_3", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_proyecto
        oda.SelectCommand.Parameters.Add("@id_actividad", SqlDbType.Int, 4, "id_actividad")
        oda.SelectCommand.Parameters("@id_actividad").Value = id_actividad

        oda.Fill(odt)

        Return odt
    End Function

    Public Function GetOne_Subproyecto(ByVal id_subproyecto As Integer, ByVal id_actividad As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Actividad_proyecto_GetOne_subproyecto", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_subproyecto", SqlDbType.Int, 4, "id_subproyecto")
        oda.SelectCommand.Parameters("@id_subproyecto").Value = id_proyecto
        oda.SelectCommand.Parameters.Add("@id_actividad", SqlDbType.Int, 4, "id_actividad")
        oda.SelectCommand.Parameters("@id_actividad").Value = id_actividad

        oda.Fill(odt)

        Return odt
    End Function

    Public Function GetOne_4(ByVal id_proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Actividad_proyecto_GetOne_4", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_proyecto

        oda.Fill(odt)

        Return odt
    End Function


    Public Function GetOne_5(ByVal id_proyecto As Integer, ByVal nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Actividad_proyecto_GetOne_5", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_proyecto
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = nombre

        oda.Fill(odt)

        Return odt
    End Function

    Public Function GetOne_6(ByVal id_proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Actividad_proyecto_GetOne_6", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_proyecto

        oda.Fill(odt)

        Return odt
    End Function

    Public Function GetOne_7(ByVal id_proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Actividad_proyecto_GetOne_7", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_proyecto

        oda.Fill(odt)

        Return odt
    End Function
    Public Function GetOne_8(ByVal id_proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Actividad_proyecto_GetOne_8", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_proyecto

        oda.Fill(odt)

        Return odt
    End Function
    'trae las actividades del proyecto
    Public Function GetMaxOrden(ByVal id_proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Actividad_proyecto_GetMaxOrden", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_proyecto

        oda.Fill(odt)
        Return odt
    End Function

    Public Function GetActividadesSubproyectosOrdenadosPorCantidadHoras_ConHijos(ByVal id_subproyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Actividad_proyecto_GetAllSubProyectoOrdenHorasSinasignar", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_subproyecto", SqlDbType.Int, 4, "id_subproyecto")
        oda.SelectCommand.Parameters("@id_subproyecto").Value = id_subproyecto

        oda.Fill(odt)
        Return odt
    End Function

    Public Function GetActividadesTodosProyectosOrdenadosPorCantidadHoras_ConHijos() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Actividad_proyecto_GetAllProyectoActivoOrdenHorasSinasignar", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.Fill(odt)
        Return odt
    End Function



End Class
