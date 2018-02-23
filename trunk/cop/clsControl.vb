Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Control
    Inherits Control_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Control As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Control", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_control", SqlDbType.Int, 4, "id_control")
        oda.SelectCommand.Parameters("@id_control").Value = id_Control

        oda.Fill(odt)
        Return odt
    End Function

End Class
