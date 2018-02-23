Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Movimiento_manual
    Inherits Movimiento_manual_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Movimiento_manual As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Movimiento_manual", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_movimiento_manual", SqlDbType.Int, 4, "id_movimiento_manual")
        oda.SelectCommand.Parameters("@id_movimiento_manual").Value = id_Movimiento_manual

        oda.Fill(odt)
        Return odt
    End Function

    'getall 2
    Public Function GetAll_2(ByVal inicio As DateTime, ByVal fin As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Movimiento_manual_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@inicio", SqlDbType.DateTime, 8, "inicio")
        oda.SelectCommand.Parameters("@inicio").Value = inicio
        oda.SelectCommand.Parameters.Add("@fin", SqlDbType.DateTime, 8, "fin")
        oda.SelectCommand.Parameters("@fin").Value = fin

        oda.Fill(odt)
        Return odt
    End Function

    'funcion de busqueda
    Public Function Find_2(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Movimiento_manual_Find_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'control
    Public Function GetAllControl(ByVal id_empleado As Integer, ByVal inicio As DateTime, ByVal fin As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Movimiento_manual_GetAllControl", cnn.Coneccion)

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

End Class
