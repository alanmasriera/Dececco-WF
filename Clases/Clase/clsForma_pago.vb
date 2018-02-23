Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Forma_pago
    Inherits Forma_pago_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Forma_pago As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Forma_pago", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_forma_pago", SqlDbType.Int, 4, "id_forma_pago")
        oda.SelectCommand.Parameters("@id_forma_pago").Value = id_Forma_pago

        oda.Fill(odt)
        Return odt
    End Function

End Class
