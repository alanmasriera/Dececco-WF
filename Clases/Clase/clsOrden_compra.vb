Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Orden_compra
    Inherits Orden_compra_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Orden_compra As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Orden_compra", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_orden_compra", SqlDbType.Int, 4, "id_orden_compra")
        oda.SelectCommand.Parameters("@id_orden_compra").Value = id_Orden_compra

        oda.Fill(odt)
        Return odt
    End Function
    Public Function ConsultarTodo2(ByVal id_cliente As Integer) As DataTable
        Dim odt As New DataTable
        ' Dim oda As New SqlDataAdapter("cop_Orden_compra_GetAll2", cnn.Coneccion)
        Dim oda As New SqlDataAdapter("cop_Orden_compra_GetAll_3", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = id_cliente

        oda.Fill(odt)

        Return odt
    End Function

End Class
