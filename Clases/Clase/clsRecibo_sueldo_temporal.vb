Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Recibo_sueldo_temporal
    Inherits Recibo_sueldo_temporal_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Recibo_sueldo_temporal As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_sueldo_temporal", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_recibo_sueldo_temporal", SqlDbType.Int, 4, "id_recibo_sueldo_temporal")
        oda.SelectCommand.Parameters("@id_recibo_sueldo_temporal").Value = id_Recibo_sueldo_temporal

        oda.Fill(odt)
        Return odt
    End Function


    'ejemplo de consulta con parametros
    Public Function GetResumenEmpleado(ByVal id_empleado As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_sueldo_temporal_GetResumenEmpleado", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_empleado", SqlDbType.Int, 4, "id_empleado")
        oda.SelectCommand.Parameters("@id_empleado").Value = id_empleado

        oda.Fill(odt)
        Return odt
    End Function


End Class
