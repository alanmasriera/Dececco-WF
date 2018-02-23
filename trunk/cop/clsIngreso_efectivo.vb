Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Ingreso_efectivo
    Inherits Ingreso_efectivo_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Ingreso_efectivo As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Ingreso_efectivo", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_ingreso_efectivo", SqlDbType.Int, 4, "id_ingreso_efectivo")
        oda.SelectCommand.Parameters("@id_ingreso_efectivo").Value = id_Ingreso_efectivo

        oda.Fill(odt)
        Return odt
    End Function

End Class
