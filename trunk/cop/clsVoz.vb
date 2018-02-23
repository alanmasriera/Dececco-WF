Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Voz
    Inherits Voz_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Voz As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Voz", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_voz", SqlDbType.Int, 4, "id_voz")
        oda.SelectCommand.Parameters("@id_voz").Value = id_Voz

        oda.Fill(odt)
        Return odt
    End Function

End Class
