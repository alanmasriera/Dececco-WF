Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Nivel1
    Inherits Nivel1_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Nivel1 As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Nivel1", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_nivel1", SqlDbType.Int, 4, "id_nivel1")
        oda.SelectCommand.Parameters("@id_nivel1").Value = id_Nivel1

        oda.Fill(odt)
        Return odt
    End Function

End Class
