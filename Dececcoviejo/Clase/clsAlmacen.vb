Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Almacen
    Inherits Almacen_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Almacen As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Almacen", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_almacen", SqlDbType.Int, 4, "id_almacen")
        oda.SelectCommand.Parameters("@id_almacen").Value = id_Almacen

        oda.Fill(odt)
        Return odt
    End Function

End Class
