Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Asignacion_iva
    Inherits Asignacion_iva_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Asignacion_iva As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Asignacion_iva", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_asignacion_Iva", SqlDbType.Int, 4, "id_asignacion_Iva")
        oda.SelectCommand.Parameters("@id_asignacion_Iva").Value = id_Asignacion_iva

        oda.Fill(odt)
        Return odt
    End Function

    'FUNCION PARA CONSULTAR TODO
    Public Function GetAll_2(ByVal id_empresa As Integer, ByVal id_iva As Integer, ByVal fecha_asignacion_iva As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Asignacion_iva_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = id_empresa
        oda.SelectCommand.Parameters.Add("@id_iva", SqlDbType.Int, 4, "id_iva")
        oda.SelectCommand.Parameters("@id_iva").Value = id_Iva
        oda.SelectCommand.Parameters.Add("@fecha_asignacion_iva", SqlDbType.DateTime, 8, "fecha_asignacion_iva")
        oda.SelectCommand.Parameters("@fecha_asignacion_iva").Value = fecha_asignacion_Iva

        oda.Fill(odt)

        Return odt
    End Function
End Class
