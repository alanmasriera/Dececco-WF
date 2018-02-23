Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Cliente_maestro
    Inherits Cliente_maestro_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Cliente_maestro As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cliente_maestro", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cliente_maestro", SqlDbType.Int, 4, "id_cliente_maestro")
        oda.SelectCommand.Parameters("@id_cliente_maestro").Value = id_Cliente_maestro

        oda.Fill(odt)
        Return odt
    End Function

End Class
