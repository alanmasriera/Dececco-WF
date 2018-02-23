Imports System.Data.SqlClient

Public Class ClaseDB

    'update el cheque como marcado o no
    Public Sub ConectDB()
        Dim oConexion As New ConexionMaster
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop__AtachDataBase"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

End Class
