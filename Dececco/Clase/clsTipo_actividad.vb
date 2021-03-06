Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Tipo_actividad
    Inherits Tipo_actividad_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Tipo_actividad As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_actividad", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tipo_actividad", SqlDbType.Int, 4, "id_tipo_actividad")
        oda.SelectCommand.Parameters("@id_tipo_actividad").Value = id_Tipo_actividad

        oda.Fill(odt)
        Return odt
    End Function

    Public Function ActualizarAsignableActividadProyecto(ByVal id_Tipo_actividad As Integer, ByVal asignable As Boolean) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_actividad_actualizar_actividad_asignable", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tipo_actividad", SqlDbType.Int, 4, "id_tipo_actividad")
        oda.SelectCommand.Parameters("@id_tipo_actividad").Value = id_Tipo_actividad
        oda.SelectCommand.Parameters.Add("@asignable", SqlDbType.Bit, 1, "asignable")
        oda.SelectCommand.Parameters("@asignable").Value = asignable

        oda.Fill(odt)
        Return odt
    End Function

End Class
