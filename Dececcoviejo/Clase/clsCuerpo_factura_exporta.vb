Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Cuerpo_factura_exporta
    Inherits Cuerpo_factura_exporta_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Cuerpo_factura_exporta As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_factura_exporta", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cuerpo_factura", SqlDbType.Int, 4, "id_cuerpo_factura")
        oda.SelectCommand.Parameters("@id_cuerpo_factura").Value = id_Cuerpo_factura_exporta

        oda.Fill(odt)
        Return odt
    End Function

    Public Function ConsultarTodo_2(ByVal id_factura As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_factura_exporta_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_factura", SqlDbType.Int, 4, "id_factura")
        oda.SelectCommand.Parameters("@id_factura").Value = id_factura

        oda.Fill(odt)

        Return odt
    End Function


    'FUNCION PARA CONSULTAR TODO
    Public Function UpdateFactura(ByVal id_factura As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_factura_exporta_Update", cnn.Coneccion)
        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_factura", SqlDbType.Int, 4, "id_factura")
        oda.SelectCommand.Parameters("@id_factura").Value = id_factura

        oda.Fill(odt)

        Return odt
    End Function

End Class
