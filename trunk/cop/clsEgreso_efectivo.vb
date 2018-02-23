Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Egreso_efectivo
    Inherits Egreso_efectivo_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Egreso_efectivo As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Egreso_efectivo", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_Egreso_efectivo", SqlDbType.Int, 4, "id_Egreso_efectivo")
        oda.SelectCommand.Parameters("@id_Egreso_efectivo").Value = id_Egreso_efectivo

        oda.Fill(odt)
        Return odt
    End Function

End Class
