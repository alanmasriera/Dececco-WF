Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Cheque_librado
    Inherits Cheque_librado_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Cheque_librado As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cheque_librado", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cheque_librado", SqlDbType.Int, 4, "id_cheque_librado")
        oda.SelectCommand.Parameters("@id_cheque_librado").Value = id_Cheque_librado

        oda.Fill(odt)
        Return odt
    End Function

    'update el cheque como marcado o no
    Public Sub Update_Check(ByVal id_cheque_librado As Integer, ByVal control As Boolean)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_cheque_librado_Update_Check"
        Command.Parameters.Add("@id_cheque_librado", SqlDbType.Int, 4, "id_cheque_librado")
        Command.Parameters("@id_cheque_librado").Value = id_cheque_librado
        Command.Parameters.Add("@control", SqlDbType.Bit, 1, "control")
        Command.Parameters("@control").Value = control

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    Public Function Consultar(ByVal id_empresa As Integer, ByVal fecha As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cheque_librado_GetAllGrilla", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = id_empresa
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha

        oda.Fill(odt)

        Return odt
    End Function

    Public Function Consultar2(ByVal id_empresa As Integer, ByVal fecha As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cheque_librado_GetAllGrilla_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = id_empresa
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = Fecha

        oda.Fill(odt)

        Return odt
    End Function

End Class
