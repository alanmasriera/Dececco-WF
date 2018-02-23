Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Tipo_empleado
    Inherits Tipo_empleado_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Tipo_empleado As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_empleado", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tipo_empleado", SqlDbType.Int, 4, "id_tipo_empleado")
        oda.SelectCommand.Parameters("@id_tipo_empleado").Value = id_Tipo_empleado

        oda.Fill(odt)
        Return odt
    End Function

End Class
