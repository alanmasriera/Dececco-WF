Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Usuario_permiso
    Inherits Usuario_permiso_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Usuario_permiso As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Usuario_permiso", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_usuario_permiso", SqlDbType.Int, 4, "id_usuario_permiso")
        oda.SelectCommand.Parameters("@id_usuario_permiso").Value = id_Usuario_permiso

        oda.Fill(odt)
        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOnen(ByVal id_Usuario As Integer, ByVal id_permiso As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Usuario_permiso_GetOne_Usuario", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_Usuario
        oda.SelectCommand.Parameters.Add("@id_permiso", SqlDbType.Int, 4, "id_permiso")
        oda.SelectCommand.Parameters("@id_permiso").Value = id_permiso

        oda.Fill(odt)

        Return odt
    End Function

    Public Function TienePermiso(ByVal id_Usuario As Integer, ByVal id_permiso As Integer) As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Usuario_tienePermiso", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_Usuario
        oda.SelectCommand.Parameters.Add("@id_permiso", SqlDbType.Int, 4, "id_permiso")
        oda.SelectCommand.Parameters("@id_permiso").Value = id_permiso

        oda.Fill(odt)

        If CInt(odt.Rows(0).Item("habilitado")) = 0 Then
            Return False
        Else
            Return True
        End If

    End Function

End Class
