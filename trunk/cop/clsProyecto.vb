Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Proyecto
    Inherits Proyecto_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Proyecto", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_Proyecto

        oda.Fill(odt)
        Return odt
    End Function

End Class
