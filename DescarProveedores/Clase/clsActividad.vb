Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Actividad
    Inherits Actividad_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Actividad As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Actividad", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_actividad", SqlDbType.Int, 4, "id_actividad")
        oda.SelectCommand.Parameters("@id_actividad").Value = id_Actividad

        oda.Fill(odt)
        Return odt
    End Function

    'funcion de consulta
    Public Function GetAll_2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Actividad_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion de busqueda
    Public Function Find_2(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Actividad_Find_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de busqueda
    Public Function GetAllExiste2(ByVal id_proyecto As Integer, ByVal nombre_actividad As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Actividad_Exist2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_proyecto
        oda.SelectCommand.Parameters.Add("@nombre_actividad", SqlDbType.VarChar, 50, "nombre_actividad")
        oda.SelectCommand.Parameters("@nombre_actividad").Value = nombre_actividad

        oda.Fill(odt)

        Return odt
    End Function

    Public Function GetHorasTrabajadas(ByVal id_actividad_proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_hora_GetAllConsumida_Actividad", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_actividad_proyecto", SqlDbType.Int, 4, "id_actividad_proyecto")
        oda.SelectCommand.Parameters("@id_actividad_proyecto").Value = id_actividad_proyecto

        oda.Fill(odt)

        Return odt
    End Function

    Public Function GetActividad(ByVal id_actividad As Integer) As Actividad
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Actividad_GetOne", cnn.Coneccion)
        Dim actividad As New Actividad

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_actividad", SqlDbType.Int, 4, "id_actividad")
        oda.SelectCommand.Parameters("@id_actividad").Value = id_actividad

        oda.Fill(odt)

        actividad.Cargar()
        actividad.Insertar()
        actividad.nombre_actividad = odt.Rows(0).Item("nombre_actividad").ToString()
        actividad.tiempo_standart = CDec(odt.Rows(0).Item("tiempo_standart").ToString())
        actividad.costo_standart = CDec(odt.Rows(0).Item("costo_standart").ToString())
        actividad.id_tipo_actividad = CInt(odt.Rows(0).Item("id_tipo_actividad").ToString())


        Return actividad

    End Function

    Public Function GetTipoActividad() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_tipo_actividad_GetCmb", cnn.Coneccion)
        Dim actividad As New Actividad

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.Fill(odt)

        Return odt

    End Function

End Class


