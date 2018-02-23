Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Renglon
    Inherits Renglon_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Renglon As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Renglon", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_renglon", SqlDbType.Int, 4, "id_renglon")
        oda.SelectCommand.Parameters("@id_renglon").Value = id_Renglon

        oda.Fill(odt)
        Return odt
    End Function

    'ejemplo de consulta con parametros
    Public Function GetCmb_2(ByVal id_empleado As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Renglon_GetCmb_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_empleado", SqlDbType.Int, 4, "id_empleado")
        oda.SelectCommand.Parameters("@id_empleado").Value = id_empleado

        oda.Fill(odt)
        Return odt
    End Function

End Class
