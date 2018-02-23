Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Hora_a_devolver
    Inherits Hora_a_devolver_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Hora_a_devolver As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Hora_a_devolver", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_hora_a_devolver", SqlDbType.Int, 4, "id_hora_a_devolver")
        oda.SelectCommand.Parameters("@id_hora_a_devolver").Value = id_Hora_a_devolver

        oda.Fill(odt)
        Return odt
    End Function

    Public Function GetAll_2(ByVal fecha As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Hora_a_devolver_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha

        oda.Fill(odt)

        Return odt
    End Function

    Public Function GetAll_3(ByVal fecha As DateTime, ByVal id_usuario As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Hora_a_devolver_GetAll_3", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_usuario

        oda.Fill(odt)

        Return odt
    End Function

End Class
