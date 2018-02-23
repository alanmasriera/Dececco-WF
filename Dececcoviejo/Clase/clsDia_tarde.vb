Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Dia_tarde
    Inherits Dia_tarde_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Dia_tarde As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Dia_tarde", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_dia_tarde", SqlDbType.Int, 4, "id_dia_tarde")
        oda.SelectCommand.Parameters("@id_dia_tarde").Value = id_Dia_tarde

        oda.Fill(odt)
        Return odt
    End Function

    Public Function GetAllControl(ByVal id_empleado As Integer, ByVal inicio As DateTime, ByVal fin As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Dia_tarde_GetAllControl", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_empleado", SqlDbType.Int, 4, "id_empleado")
        oda.SelectCommand.Parameters("@id_empleado").Value = id_empleado
        oda.SelectCommand.Parameters.Add("@inicio", SqlDbType.DateTime, 8, "inicio")
        oda.SelectCommand.Parameters("@inicio").Value = inicio
        oda.SelectCommand.Parameters.Add("@fin", SqlDbType.DateTime, 8, "fin")
        oda.SelectCommand.Parameters("@fin").Value = fin

        oda.Fill(odt)
        Return odt
    End Function

    'funcion de consulta
    Public Function GetAll_2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Dia_tarde_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion de busqueda
    Public Function Find_2(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Dia_tarde_Find_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function
End Class


