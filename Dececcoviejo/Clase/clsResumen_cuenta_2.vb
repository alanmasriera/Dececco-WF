Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Resumen_cuenta_2
    Inherits Resumen_cuenta_2_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Resumen_cuenta_2 As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Resumen_cuenta_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_resumen_cuenta", SqlDbType.Int, 4, "id_resumen_cuenta")
        oda.SelectCommand.Parameters("@id_resumen_cuenta").Value = id_Resumen_cuenta_2

        oda.Fill(odt)
        Return odt
    End Function

End Class
