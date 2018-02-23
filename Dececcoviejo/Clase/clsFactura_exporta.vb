Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Factura_exporta
    Inherits Factura_exporta_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Factura_exporta As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_exporta", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_factura", SqlDbType.Int, 4, "id_factura")
        oda.SelectCommand.Parameters("@id_factura").Value = id_Factura_exporta

        oda.Fill(odt)
        Return odt
    End Function

    'autonumerico
    Public Function GetTop() As String
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_Exporta_GetTop", cnn.Coneccion)
        Dim Total As String
        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.Fill(odt)
        Total = odt.Rows(0).Item("Total").ToString
        Return Total
    End Function

    Public Function UltimaFactura() As Integer
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_Exporta_ObtenerUltimo", cnn.Coneccion)
        Dim ultimo As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)
        If odt.Rows(0).Item("ultimo").ToString = "" Then
            ultimo = 0
        Else
            ultimo = CInt(odt.Rows(0).Item("ultimo").ToString)
        End If
        Return ultimo
    End Function
End Class
