Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Actividad_proyecto
    Inherits Actividad_proyecto_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Actividad_proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Actividad_proyecto", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_actividad_proyecto", SqlDbType.Int, 4, "id_actividad_proyecto")
        oda.SelectCommand.Parameters("@id_actividad_proyecto").Value = id_Actividad_proyecto

        oda.Fill(odt)
        Return odt
    End Function

End Class
