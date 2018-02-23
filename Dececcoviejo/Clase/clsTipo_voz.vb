Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Tipo_voz
    Inherits Tipo_voz_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Tipo_voz As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_voz", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tipo_voz", SqlDbType.Int, 4, "id_tipo_voz")
        oda.SelectCommand.Parameters("@id_tipo_voz").Value = id_Tipo_voz

        oda.Fill(odt)
        Return odt
    End Function


    'funcion de consulta
    Public Function GetAll_2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_voz_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion de busqueda
    Public Function Find_2(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_voz_Find_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'actualiza los porcentajes un registro en la tabla
    Public Sub UpdatePorcentaje(ByVal id_control As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Tipo_voz_UpdatePorcentaje"

        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.Add("@id_control", SqlDbType.Int, 4, "id_control")
        Command.Parameters("@id_control").Value = id_control

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    Public Sub UpdatePorcentajeTodos(ByVal id_control As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Tipo_voz_UpdatePorcentaje_Todos"

        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.Add("@id_control", SqlDbType.Int, 4, "id_control")
        Command.Parameters("@id_control").Value = id_control

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub


    'funcion de consulta
    Public Function GetAllArbol() As DataTable
        Dim odt As New DataTable("Tipo_voz")
        Dim oda As New SqlDataAdapter("cop_Tipo_voz_GetAllArbol", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'agregado para traer los tipos de voz
    Public Function GetAllArbol_2(ByVal id_control As Integer) As DataTable
        Dim odt As New DataTable("Tipo_voz")
        Dim oda As New SqlDataAdapter("cop_Tipo_voz_GetAllArbol_3", cnn.Coneccion)
        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_control", SqlDbType.Int, 4, "id_control")
        oda.SelectCommand.Parameters("@id_control").Value = id_control
        oda.Fill(odt)
        Return odt
    End Function
    'agregado para traer los tipos de voz
    Public Function GetAllArbol_ordenado(ByVal id_control As Integer) As DataTable
        Dim odt As New DataTable("Tipo_voz")
        Dim oda As New SqlDataAdapter("cop_Tipo_voz_GetAllArbol_2", cnn.Coneccion)
        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_control", SqlDbType.Int, 4, "id_control")
        oda.SelectCommand.Parameters("@id_control").Value = id_control
        oda.Fill(odt)
        Return odt
    End Function
    'agregado para traer los tipos de voz
    Public Function GetAllArbol_4(ByVal id_control As Integer) As DataTable
        Dim odt As New DataTable("Tipo_voz")
        Dim oda As New SqlDataAdapter("cop_Tipo_voz_GetAllArbol_4", cnn.Coneccion)
        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_control", SqlDbType.Int, 4, "id_control")
        oda.SelectCommand.Parameters("@id_control").Value = id_control
        oda.Fill(odt)
        Return odt
    End Function
    Public Function GetAllExiste(ByVal nombre_Tipo_voz As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_voz_GetAllExiste", cnn.Coneccion)
        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_tipo_voz", SqlDbType.NVarChar, 500, "nombre_tipo_voz")
        oda.SelectCommand.Parameters("@nombre_tipo_voz").Value = nombre_Tipo_voz
        oda.Fill(odt)
        Return odt
    End Function

    ''agregado para el ultimo codigo
    Public Function GetUltimoCodigo(ByVal id_control As Integer) As DataTable
        Dim odt As New DataTable("Tipo_voz")
        Dim oda As New SqlDataAdapter("cop_Tipo_voz_GetUltimoCodigo", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_control", SqlDbType.Int, 4, "id_control")
        oda.SelectCommand.Parameters("@id_control").Value = id_control
        oda.Fill(odt)

        Return odt
    End Function

    ''agregado para actualizar el porcentaje de los registros no modificados
    Public Sub UpdatePorcentaje_2(ByVal id_tipo_voz As Integer, ByVal id_voz As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Voz_tipo_voz_UpdatePorcentaje_2"

        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.Add("@id_tipo_voz", SqlDbType.Int, 4, "id_tipo_voz")
        Command.Parameters("@id_tipo_voz").Value = id_tipo_voz
        Command.Parameters.Add("@id_voz", SqlDbType.Int, 4, "id_voz")
        Command.Parameters("@id_voz").Value = id_voz

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    Public Sub UpdatePorcentaje_Todos(ByVal id_tipo_voz As Integer)
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

    Public Function ExisVoz(ByVal id_control As Integer) As DataTable
        Dim odt As New DataTable("Tipo_voz")
        Dim oda As New SqlDataAdapter("cop_Tipo_voz_ExisVoz", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_control", SqlDbType.Int, 4, "id_control")
        oda.SelectCommand.Parameters("@id_control").Value = id_control
        oda.Fill(odt)

        Return odt
    End Function

    'agregado para cuando un tipo de voz cambia de porcentaje
    Public Sub UpdatePorcentaje_tipo_2(ByVal id_control As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Tipo_voz_UpdatePorcentaje_2"

        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.Add("@id_control", SqlDbType.Int, 4, "id_control")
        Command.Parameters("@id_control").Value = id_control


        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    Function verificarIntegridadPorcentaje(id_control As Integer, id_tipo_voz As Integer) As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_tipo_voz_verificarIntegridadPorcentaje", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tipo_voz", SqlDbType.Int, 4, "id_tipo_voz")
        oda.SelectCommand.Parameters("@id_tipo_voz").Value = id_tipo_voz
        oda.SelectCommand.Parameters.Add("@id_control", SqlDbType.Int, 4, "id_control")
        oda.SelectCommand.Parameters("@id_control").Value = id_control

        oda.Fill(odt)

        'Si la primer columna es cero, significa que todas las voces tienen configuracion de 
        'ponderacion manual, y la segunda es la suma de las ponderaciones
        If CInt(odt.Rows(0).Item(0).ToString()) = 0 Then
            Return False
        End If

        Return True
    End Function

End Class