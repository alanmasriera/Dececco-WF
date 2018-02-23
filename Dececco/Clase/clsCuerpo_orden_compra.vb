Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Cuerpo_orden_compra
    Inherits Cuerpo_orden_compra_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Cuerpo_orden_compra As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_orden_compra", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cuerpo_orden_compra", SqlDbType.Int, 4, "id_cuerpo_orden_compra")
        oda.SelectCommand.Parameters("@id_cuerpo_orden_compra").Value = id_Cuerpo_orden_compra

        oda.Fill(odt)
        Return odt
    End Function
    Public Sub Deleteorden_compra(ByVal id_orden_compra As Integer, ByVal id_usuario As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cuerpo_orden_compra_Deleteorden_compra"
        Command.Parameters.Add("@id_orden_compra", SqlDbType.Int, 4, "id_orden_compra")
        Command.Parameters("@id_orden_compra").Value = id_orden_compra
        Command.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        Command.Parameters("@id_usuario").Value = id_usuario

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra los datos relacionados al encabezado
    Public Sub UpdateID(ByVal id_orden_compra As Integer, ByVal id_usuario As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cuerpo_orden_compra_UpdateID"
        Command.Parameters.Add("@id_orden_compra", SqlDbType.Int, 4, "id_orden_compra")
        Command.Parameters("@id_orden_compra").Value = id_orden_compra
        Command.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        Command.Parameters("@id_usuario").Value = id_usuario

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub
    'le enviamos la orden de compra como parametro
    Public Function GetAllMovimiento(ByVal id_orden_compra As Integer) As DataTable
        Dim odt As New DataTable
        'Dim oda As New SqlDataAdapter("cop_Cuerpo_orden_compra_GetAllMovimiento", cnn.Coneccion)
        Dim oda As New SqlDataAdapter("cop_Cuerpo_orden_compra_GetAllMovimiento2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_orden_compra", SqlDbType.Int, 4, "id_orden_compra")
        oda.SelectCommand.Parameters("@id_orden_compra").Value = id_orden_compra

        oda.Fill(odt)
        Return odt
    End Function
End Class

 

