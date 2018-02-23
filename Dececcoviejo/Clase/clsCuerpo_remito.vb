Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Cuerpo_remito
    Inherits Cuerpo_remito_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Cuerpo_remito As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_remito", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cuerpo_remito", SqlDbType.Int, 4, "id_cuerpo_remito")
        oda.SelectCommand.Parameters("@id_cuerpo_remito").Value = id_Cuerpo_remito

        oda.Fill(odt)
        Return odt
    End Function

    Public Function GetAllMovimiento(ByVal id_remito As Integer) As DataTable
        Dim odt As New DataTable
        'Dim oda As New SqlDataAdapter("cop_Cuerpo_remito_GetAllMovimiento", cnn.Coneccion)
        Dim oda As New SqlDataAdapter("cop_Cuerpo_remito_GetAllMovimiento_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        'oda.SelectCommand.Parameters.Add("@id_cuerpo_remito", SqlDbType.Int, 4, "id_cuerpo_remito")
        'oda.SelectCommand.Parameters("@id_cuerpo_remito").Value = id_remito
        oda.SelectCommand.Parameters.Add("@id_remito", SqlDbType.Int, 4, "id_remito")
        oda.SelectCommand.Parameters("@id_remito").Value = id_remito

        oda.Fill(odt)
        Return odt
    End Function

    Public Sub DeleteRemito(ByVal id_Remito As Integer, ByVal id_usuario As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cuerpo_Remito_DeleteRemito"
        Command.Parameters.Add("@id_Remito", SqlDbType.Int, 4, "id_Remito")
        Command.Parameters("@id_Remito").Value = id_Remito

        Command.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        Command.Parameters("@id_usuario").Value = id_usuario

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra los datos relacionados al encabezado
    Public Sub UpdateID(ByVal id_Remito As Integer, ByVal id_usuario As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cuerpo_Remito_UpdateID"
        Command.Parameters.Add("@id_Remito", SqlDbType.Int, 4, "id_Remito")
        Command.Parameters("@id_Remito").Value = id_Remito
        Command.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        Command.Parameters("@id_usuario").Value = id_usuario

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub
End Class
