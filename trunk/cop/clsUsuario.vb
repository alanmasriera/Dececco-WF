Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Usuario
    Inherits Usuario_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Usuario As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Usuario", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_Usuario

        oda.Fill(odt)
        Return odt
    End Function

End Class
