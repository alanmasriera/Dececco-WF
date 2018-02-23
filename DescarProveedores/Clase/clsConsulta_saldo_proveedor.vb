Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Consulta_saldo_proveedor
    Inherits Consulta_saldo_proveedor_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Consulta_saldo_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Consulta_saldo_proveedor", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_consulta_saldo_proveedor", SqlDbType.Int, 4, "id_consulta_saldo_proveedor")
        oda.SelectCommand.Parameters("@id_consulta_saldo_proveedor").Value = id_Consulta_saldo_proveedor

        oda.Fill(odt)
        Return odt
    End Function




    'borra todos los datos de la tabla
    Public Sub Make_Main()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Consulta_saldo_proveedor_Main"

        Command.CommandType = CommandType.StoredProcedure
        oConexion.Abrir()
        Command.ExecuteNonQuery()
        oConexion.Cerrar()
    End Sub



    'borra todos los datos de la tabla
    Public Sub Make_Main(ByVal bandera As String)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Consulta_saldo_proveedor_Main"

        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.Add("@bandera", SqlDbType.VarChar, 50, "bandera")
        Command.Parameters("@bandera").Value = bandera

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub
    'funcion de consulta
    Public Function GetAll_2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Consulta_saldo_proveedor_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function GetAll_Sum() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Consulta_saldo_proveedor_GetAll_Sum", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

End Class
