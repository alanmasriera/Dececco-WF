Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Permiso
    Inherits Permiso_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Permiso As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Permiso", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_permiso", SqlDbType.Int, 4, "id_permiso")
        oda.SelectCommand.Parameters("@id_permiso").Value = id_Permiso

        oda.Fill(odt)
        Return odt
    End Function

    Public Sub InsertNewPermiso(ByVal detalle As String, ByVal abm As String)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Permiso_InsertPermisoNew"

        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.Add("@detalle", SqlDbType.VarChar, 50, "detalle")
        Command.Parameters("@detalle").Value = detalle
        Command.Parameters.Add("@abm", SqlDbType.VarChar, 50, "abm")
        Command.Parameters("@abm").Value = abm

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'agrega el permiso nuevo en un usuario
    Public Sub InsertNewPermisoUsuario(ByVal abm As String, ByVal id_grupo_usuario As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Permiso_InsertPermisoNewUsuario"

        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.Add("@abm", SqlDbType.VarChar, 50, "abm")
        Command.Parameters("@abm").Value = abm
        Command.Parameters.Add("@id_grupo_usuario", SqlDbType.Int, 4, "id_grupo_usuario")
        Command.Parameters("@id_grupo_usuario").Value = id_grupo_usuario

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

End Class
