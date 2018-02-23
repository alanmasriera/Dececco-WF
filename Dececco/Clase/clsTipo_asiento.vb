Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Tipo_asiento
    Inherits Tipo_asiento_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Tipo_asiento As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_asiento", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tipo_asiento", SqlDbType.Int, 4, "id_tipo_asiento")
        oda.SelectCommand.Parameters("@id_tipo_asiento").Value = id_Tipo_asiento

        oda.Fill(odt)
        Return odt
    End Function

    'ejemplo de consulta con parametros
    Public Function GetAllModelo(ByVal id_Tipo_asiento As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_asiento_GetAllModelo", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tipo_asiento", SqlDbType.Int, 4, "id_tipo_asiento")
        oda.SelectCommand.Parameters("@id_tipo_asiento").Value = id_Tipo_asiento

        oda.Fill(odt)
        Return odt
    End Function

End Class
