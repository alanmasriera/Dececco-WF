Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Tipo_dni
    Inherits Tipo_dni_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Tipo_dni As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_dni", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tipo_dni", SqlDbType.Int, 4, "id_tipo_dni")
        oda.SelectCommand.Parameters("@id_tipo_dni").Value = id_Tipo_dni

        oda.Fill(odt)
        Return odt
    End Function

End Class
