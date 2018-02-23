Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Cuerpo_movimiento_libro
    Inherits Cuerpo_movimiento_libro_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Cuerpo_movimiento_libro As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_libro", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cuerpo_movimiento_libro", SqlDbType.Int, 4, "id_cuerpo_movimiento_libro")
        oda.SelectCommand.Parameters("@id_cuerpo_movimiento_libro").Value = id_Cuerpo_movimiento_libro

        oda.Fill(odt)
        Return odt
    End Function


    'borra todo el cuerpo de la Movimiento_hora
    Public Sub DeleteMovimiento_libro(ByVal id_movimiento_libro As Integer, ByVal id_usuario As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cuerpo_Movimiento_libro_DeleteMovimiento_libro"

        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.Add("@id_movimiento_libro", SqlDbType.Int, 4, "id_movimiento_libro")
        Command.Parameters("@id_movimiento_libro").Value = id_movimiento_libro
        Command.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        Command.Parameters("@id_usuario").Value = id_usuario

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'update id
    Public Sub UpdateID(ByVal id_movimiento_libro As Integer, ByVal id_usuario As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cuerpo_Movimiento_libro_UpdateID"

        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.Add("@id_movimiento_libro", SqlDbType.Int, 4, "id_cuerpo_Movimiento_hora")
        Command.Parameters("@id_movimiento_libro").Value = id_movimiento_libro
        Command.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        Command.Parameters("@id_usuario").Value = id_usuario

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'grilla
    Public Function GetAllMovimiento(ByVal id_movimiento_libro As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_libro_GetAllMovimiento", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_movimiento_libro", SqlDbType.Int, 4, "id_movimiento_libro")
        oda.SelectCommand.Parameters("@id_movimiento_libro").Value = id_movimiento_libro

        oda.Fill(odt)
        Return odt
    End Function


    'controla si existe el registro en la base de datos
    Public Function Exist_2(ByVal id_cuenta_imputable As Integer, ByVal id_movimiento_libro As Integer, ByVal id_usuario As Integer) As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_libro_Exist_2", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cuenta_imputable", SqlDbType.Int, 4, "id_cuenta_imputable")
        oda.SelectCommand.Parameters("@id_cuenta_imputable").Value = id_cuenta_imputable
        oda.SelectCommand.Parameters.Add("@id_movimiento_libro", SqlDbType.Int, 4, "id_movimiento_libro")
        oda.SelectCommand.Parameters("@id_movimiento_libro").Value = id_movimiento_libro
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_usuario

        oda.Fill(odt)
        Total = CInt(odt.Rows(0).Item("Total").ToString)
        If Total = 0 Then
            Return False  'NO EXISTE
        Else
            Return True 'SI EXISTE
        End If
    End Function

    'borra todo el cuerpo de la Movimiento_hora
    Public Sub DeleteVacio(ByVal id_movimiento_libro As Integer, ByVal id_usuario As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cuerpo_Movimiento_libro_DeleteVacio"

        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.Add("@id_movimiento_libro", SqlDbType.Int, 4, "id_movimiento_libro")
        Command.Parameters("@id_movimiento_libro").Value = id_movimiento_libro
        Command.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        Command.Parameters("@id_usuario").Value = id_usuario

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

End Class
