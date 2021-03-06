Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Cheque_proveedor_2
    Inherits Cheque_proveedor_2_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Cheque_proveedor_2 As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cheque_proveedor_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cheque_proveedor_2", SqlDbType.Int, 4, "id_cheque_proveedor_2")
        oda.SelectCommand.Parameters("@id_cheque_proveedor_2").Value = id_Cheque_proveedor_2

        oda.Fill(odt)
        Return odt
    End Function

    Public Function GetAll_2(ByVal id_recibo_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cheque_proveedor_2_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_recibo_proveedor", SqlDbType.Int, 4, "id_recibo_proveedor")
        oda.SelectCommand.Parameters("@id_recibo_proveedor").Value = id_recibo_proveedor
        oda.Fill(odt)
        Return odt
    End Function

    'borra los datos relacionados al encabezado
    Public Sub UpdateID(ByVal id_Recibo_proveedor As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cheque_Proveedor_2_UpdateID"
        Command.Parameters.Add("@id_recibo_proveedor", SqlDbType.Int, 4, "id_recibo_proveedor")
        Command.Parameters("@id_recibo_proveedor").Value = id_Recibo_proveedor
        'Command.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        'Command.Parameters("@id_usuario").Value = id_usuario

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    Public Sub DeleteCheque_proveedor(ByVal id_Recibo_proveedor As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cheque_Proveedor_2_DeleteRecibo_proveedor"
        Command.Parameters.Add("@id_recibo_proveedor", SqlDbType.Int, 4, "id_recibo_proveedor")
        Command.Parameters("@id_recibo_proveedor").Value = id_Recibo_proveedor

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    Public Function GetAllRecibo_proveedor(ByVal id_recibo_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cheque_proveedor_2_GetAllRecibo_proveedor", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_recibo_proveedor", SqlDbType.Int, 4, "id_recibo_proveedor")
        oda.SelectCommand.Parameters("@id_recibo_proveedor").Value = id_recibo_proveedor

        oda.Fill(odt)
        Return odt
    End Function


End Class
