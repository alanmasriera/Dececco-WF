Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Grupo_permiso
    Inherits Grupo_permiso_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Grupo_permiso As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Grupo_permiso", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_grupo_permiso", SqlDbType.Int, 4, "id_grupo_permiso")
        oda.SelectCommand.Parameters("@id_grupo_permiso").Value = id_Grupo_permiso

        oda.Fill(odt)
        Return odt
    End Function

    'trae los permisos que tiene el grupo de usuarios
    Public Function GetPermiso(ByVal id_grupo_usuario As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Grupo_permiso_GetPermiso", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_grupo_usuario", SqlDbType.Int, 4, "id_grupo_usuario")
        oda.SelectCommand.Parameters("@id_grupo_usuario").Value = id_grupo_usuario

        oda.Fill(odt)

        Return odt
    End Function

    'ingresa todos los permisos a un grupo de usuarios
    Public Function InsertNew(ByVal id_grupo_usuario As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Grupo_permiso_InsertNew", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_grupo_usuario", SqlDbType.Int, 4, "id_grupo_usuario")
        oda.SelectCommand.Parameters("@id_grupo_usuario").Value = id_grupo_usuario

        oda.Fill(odt)

        Return odt
    End Function

    'update el permiso como marcado o no
    Public Sub Update_Check(ByVal id_grupo_permiso As Integer, ByVal habilitado As Boolean)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Grupo_permiso_Update_Check"
        Command.Parameters.Add("@id_grupo_permiso", SqlDbType.Int, 4, "id_grupo_permiso")
        Command.Parameters("@id_grupo_permiso").Value = id_grupo_permiso
        Command.Parameters.Add("@habilitado", SqlDbType.Bit, 1, "habilitado")
        Command.Parameters("@habilitado").Value = habilitado

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'marca todos los permisos como true
    Public Sub Update_CheckAll(ByVal id_grupo_usuario As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Grupo_permiso_Update_CheckAll"
        Command.Parameters.Add("@id_grupo_usuario", SqlDbType.Int, 4, "id_grupo_usuario")
        Command.Parameters("@id_grupo_usuario").Value = id_grupo_usuario

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'marca todos los permisos como false
    Public Sub Update_UnCheckAll(ByVal id_grupo_usuario As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Grupo_permiso_Update_UnCheckAll"
        Command.Parameters.Add("@id_grupo_usuario", SqlDbType.Int, 4, "id_grupo_usuario")
        Command.Parameters("@id_grupo_usuario").Value = id_grupo_usuario

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'controla si existe el registro en la base de datos
    Public Function Exist_2(ByVal id_grupo_usuario As Integer, ByVal id_permiso As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Grupo_permiso_Exist_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_grupo_usuario", SqlDbType.Int, 4, "id_grupo_usuario")
        oda.SelectCommand.Parameters("@id_grupo_usuario").Value = id_grupo_usuario
        oda.SelectCommand.Parameters.Add("@id_permiso", SqlDbType.Int, 4, "id_permiso")
        oda.SelectCommand.Parameters("@id_permiso").Value = id_permiso


        oda.Fill(odt)
        Return odt
    End Function

End Class
