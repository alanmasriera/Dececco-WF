Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Voz_tipo_voz
    Inherits Voz_tipo_voz_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Voz_tipo_voz As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Voz_tipo_voz", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_voz_tipo_voz", SqlDbType.Int, 4, "id_voz_tipo_voz")
        oda.SelectCommand.Parameters("@id_voz_tipo_voz").Value = id_Voz_tipo_voz

        oda.Fill(odt)
        Return odt
    End Function

    'funcion de consulta
    Public Function GetAll_2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Voz_tipo_voz_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion de busqueda
    Public Function Find_2(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Voz_tipo_voz_Find_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function GetDuplicado(ByVal id_voz As Integer, ByVal id_tipo_voz As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Voz_tipo_voz_GetDuplicado", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_voz", SqlDbType.Int, 4, "id_voz")
        oda.SelectCommand.Parameters("@id_voz").Value = id_voz
        oda.SelectCommand.Parameters.Add("@id_tipo_voz", SqlDbType.Int, 4, "id_tipo_voz")
        oda.SelectCommand.Parameters("@id_tipo_voz").Value = id_tipo_voz

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function GetAll_3() As DataTable
        Dim odt As New DataTable("Voz_tipo_voz")
        Dim oda As New SqlDataAdapter("cop_Voz_tipo_voz_GetAll_3", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'actualiza los porcentajes un registro en la tabla
    Public Sub UpdatePorcentaje(ByVal id_tipo_voz As Integer)

        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Voz_tipo_voz_UpdatePorcentaje_Todos"

        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.Add("@id_tipo_voz", SqlDbType.Int, 4, "id_tipo_voz")
        Command.Parameters("@id_tipo_voz").Value = id_tipo_voz

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub
    'actualiza los porcentajes un registro en la tabla
    Function verificarIntegridadPorcentaje(ByVal id_tipo_voz As Integer, ByVal id_voz As Integer) As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Voz_tipo_voz_verificarIntegridadPorcentaje", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tipo_voz", SqlDbType.Int, 4, "id_tipo_voz")
        oda.SelectCommand.Parameters("@id_tipo_voz").Value = id_tipo_voz
        oda.SelectCommand.Parameters.Add("@id_voz", SqlDbType.Int, 4, "id_voz")
        oda.SelectCommand.Parameters("@id_voz").Value = id_voz

        oda.Fill(odt)

        'Si la primer columna es cero, significa que todas las voces tienen configuracion de 
        'ponderacion manual, y la segunda es la suma de las ponderaciones
        If CInt(odt.Rows(0).Item(0).ToString()) = 0 Then
            Return False
        End If

        Return True


    End Function


    'maximo codigo
    Public Function GetMaxCodigo(ByVal id_tipo_voz As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Voz_tipo_voz_GetMaxCodigo", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tipo_voz", SqlDbType.Int, 4, "id_tipo_voz")
        oda.SelectCommand.Parameters("@id_tipo_voz").Value = id_tipo_voz

        oda.Fill(odt)

        Return odt
    End Function


    'borra la voz
    Public Sub BorrarVoz(ByVal id_voz As Integer, ByVal id_tipo_voz As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Voz_tipo_voz_DeleteVoz"

        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.Add("@id_voz", SqlDbType.Int, 4, "id_voz")
        Command.Parameters("@id_voz").Value = id_voz
        Command.Parameters.Add("@id_tipo_voz", SqlDbType.Int, 4, "id_tipo_voz")
        Command.Parameters("@id_tipo_voz").Value = id_tipo_voz

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra la voz
    Public Sub BorrarTipoVoz(ByVal id_tipo_voz As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Voz_tipo_voz_DeleteTipoVoz"

        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.Add("@id_tipo_voz", SqlDbType.Int, 4, "id_tipo_voz")
        Command.Parameters("@id_tipo_voz").Value = id_tipo_voz

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'agregado 
    Public Function GetAll_4(ByVal id_tipo_voz As Integer) As DataTable
        Dim odt As New DataTable("Voz_tipo_voz")
        Dim oda As New SqlDataAdapter("cop_Voz_tipo_voz_GetAll_5", cnn.Coneccion)
        oda.SelectCommand.Parameters.Add("@id_tipo_voz", SqlDbType.Int, 4, "id_tipo_voz")
        oda.SelectCommand.Parameters("@id_tipo_voz").Value = id_tipo_voz
        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'agregado 
    Public Function GetAll_Creacion(ByVal id_tipo_voz As Integer) As DataTable
        Dim odt As New DataTable("Voz_tipo_voz")
        Dim oda As New SqlDataAdapter("cop_Voz_tipo_voz_GetAll_6", cnn.Coneccion)
        oda.SelectCommand.Parameters.Add("@id_tipo_voz", SqlDbType.Int, 4, "id_tipo_voz")
        oda.SelectCommand.Parameters("@id_tipo_voz").Value = id_tipo_voz
        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function
    'agregado 
    Public Function GetAll_Nombre(ByVal id_tipo_voz As Integer) As DataTable
        Dim odt As New DataTable("Voz_tipo_voz")
        Dim oda As New SqlDataAdapter("cop_Voz_tipo_voz_GetAll_4", cnn.Coneccion)
        oda.SelectCommand.Parameters.Add("@id_tipo_voz", SqlDbType.Int, 4, "id_tipo_voz")
        oda.SelectCommand.Parameters("@id_tipo_voz").Value = id_tipo_voz
        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'agregado
    Public Function ExisVoz(ByVal id_tipo_voz As Integer) As DataTable
        Dim odt As New DataTable("Voz_tipo_voz")
        Dim oda As New SqlDataAdapter("cop_Voz_tipo_voz_ExisVoz", cnn.Coneccion)
        oda.SelectCommand.Parameters.Add("@id_tipo_voz", SqlDbType.Int, 4, "id_tipo_voz")
        oda.SelectCommand.Parameters("@id_tipo_voz").Value = id_tipo_voz
        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function
End Class