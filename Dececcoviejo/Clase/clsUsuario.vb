Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Usuario
    Inherits Usuario_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Usuario As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Usuario", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_Usuario

        oda.Fill(odt)
        Return odt
    End Function

    'EJ PARA CONSULTAR CON PARAMETROS
    Public Function GetUser(ByVal nombre_usuario As String, ByVal password_usuario As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Usuario_GetUser", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50, "nombre_usuario")
        oda.SelectCommand.Parameters("@nombre_usuario").Value = nombre_usuario
        oda.SelectCommand.Parameters.Add("@password_usuario", SqlDbType.VarChar, 50, "password_usuario")
        oda.SelectCommand.Parameters("@password_usuario").Value = password_usuario

        oda.Fill(odt)
        Return odt
    End Function

    'trae el permiso de un formulario
    Public Function GetPermiso(ByVal nombre_usuario As String, ByVal formulario As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Usuario_GetPermiso", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50, "nombre_usuario")
        oda.SelectCommand.Parameters("@nombre_usuario").Value = nombre_usuario
        oda.SelectCommand.Parameters.Add("@formulario", SqlDbType.VarChar, 50, "formulario")
        oda.SelectCommand.Parameters("@formulario").Value = formulario

        oda.Fill(odt)
        Return odt
    End Function

    'grilla
    Public Function GetAll_2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Usuario_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.Fill(odt)
        Return odt
    End Function

    'funcion de busqueda 2
    Public Function Find_2(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Usuario_Find_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'combo 2
    Public Function GetCmb_2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Usuario_GetCmb_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.Fill(odt)
        Return odt
    End Function

    'combo 2
    Public Function GetCmb_3() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Usuario_GetCmb_3", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.Fill(odt)
        Return odt
    End Function

    'combo 2
    Public Function GetCmbPM() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Usuario_GetCmbpm", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.Fill(odt)
        Return odt
    End Function

    'getone 2
    Public Function GetOne_2(ByVal id_Usuario As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Usuario_GetOne_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_Usuario", SqlDbType.Int, 4, "id_Usuario")
        oda.SelectCommand.Parameters("@id_Usuario").Value = id_Usuario

        oda.Fill(odt)

        Return odt
    End Function

    'getone 3
    Public Function GetOne_3(ByVal id_Usuario As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Usuario_GetOne_3", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_Usuario", SqlDbType.Int, 4, "id_Usuario")
        oda.SelectCommand.Parameters("@id_Usuario").Value = id_Usuario

        oda.Fill(odt)

        Return odt
    End Function

    'trae los Usuarios activos
    Public Function GetActivo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Usuario_GetActivo", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.Fill(odt)
        Return odt
    End Function


    Public Function Exist_2(ByVal id_tipo_asiento As Integer, ByVal id_cuenta_imputable As Integer) As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Asiento_modelo_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cuenta_imputable", SqlDbType.Int, 4, "id_cuenta_imputable")
        oda.SelectCommand.Parameters("@id_cuenta_imputable").Value = id_cuenta_imputable
        oda.SelectCommand.Parameters.Add("@id_tipo_asiento", SqlDbType.Int, 4, "id_tipo_asiento")
        oda.SelectCommand.Parameters("@id_tipo_asiento").Value = id_tipo_asiento

        oda.Fill(odt)
        Total = CInt(odt.Rows(0).Item("Total").ToString)
        If Total = 0 Then
            Return False  'NO EXISTE
        Else
            Return True 'SI EXISTE
        End If
    End Function

    'agregado
    Public Function GetPermiso_2(ByVal nombre_usuario As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Usuario_GetPermiso_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50, "nombre_usuario")
        oda.SelectCommand.Parameters("@nombre_usuario").Value = nombre_usuario
        oda.Fill(odt)
        Return odt
    End Function

    Public Function GetCadistas() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Usuario_GetPorGrupo", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_grupo_usuario", SqlDbType.Int, 6, "id_grupo_usuario")
        oda.SelectCommand.Parameters("@id_grupo_usuario").Value = 4
        oda.Fill(odt)
        Return odt
    End Function

    Public Function GetControladores() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Usuario_GetPorGrupo", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_grupo_usuario", SqlDbType.Int, 6, "id_grupo_usuario")
        oda.SelectCommand.Parameters("@id_grupo_usuario").Value = 6
        oda.Fill(odt)
        Return odt
    End Function


End Class


