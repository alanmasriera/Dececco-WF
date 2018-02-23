Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Voz_tipo_voz
    Inherits Voz_tipo_voz_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Voz_tipo_voz As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Voz_tipo_voz", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_voz_tipo_voz", SqlDbType.Int, 4, "id_voz_tipo_voz")
        oda.SelectCommand.Parameters("@id_voz_tipo_voz").Value = id_Voz_tipo_voz

        oda.Fill(odt)
        Return odt
    End Function

End Class
