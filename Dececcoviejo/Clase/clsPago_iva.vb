Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Pago_iva
    Inherits Pago_iva_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Pago_iva As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Pago_iva", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_pago_Iva", SqlDbType.Int, 4, "id_pago_Iva")
        oda.SelectCommand.Parameters("@id_pago_Iva").Value = id_Pago_iva

        oda.Fill(odt)
        Return odt
    End Function

    'FUNCION PARA CONSULTAR TODO
    Public Function GetAll_2(ByVal id_empresa As Integer, ByVal id_iva As Integer, ByVal fecha_pago_iva As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Pago_iva_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = id_empresa
        oda.SelectCommand.Parameters.Add("@id_iva", SqlDbType.Int, 4, "id_iva")
        oda.SelectCommand.Parameters("@id_iva").Value = id_Iva
        oda.SelectCommand.Parameters.Add("@fecha_pago_iva", SqlDbType.DateTime, 8, "fecha_pago_iva")
        oda.SelectCommand.Parameters("@fecha_pago_iva").Value = fecha_pago_Iva

        oda.Fill(odt)

        Return odt
    End Function

End Class
