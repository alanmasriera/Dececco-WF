Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Medio_entrega
    Inherits Medio_entrega_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Medio_entrega As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Medio_entrega", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_medio_entrega", SqlDbType.Int, 4, "id_medio_entrega")
        oda.SelectCommand.Parameters("@id_medio_entrega").Value = id_Medio_entrega

        oda.Fill(odt)
        Return odt
    End Function

End Class
