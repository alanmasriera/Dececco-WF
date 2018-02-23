Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Grupo_usuario
    Inherits Grupo_usuario_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Grupo_usuario As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Grupo_usuario", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_grupo_usuario", SqlDbType.Int, 4, "id_grupo_usuario")
        oda.SelectCommand.Parameters("@id_grupo_usuario").Value = id_Grupo_usuario

        oda.Fill(odt)
        Return odt
    End Function

End Class
