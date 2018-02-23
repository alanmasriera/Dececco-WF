Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Ingreso_efectivo
    Inherits Ingreso_efectivo_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Ingreso_efectivo As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Ingreso_efectivo", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_ingreso_efectivo", SqlDbType.Int, 4, "id_ingreso_efectivo")
        oda.SelectCommand.Parameters("@id_ingreso_efectivo").Value = id_Ingreso_efectivo

        oda.Fill(odt)
        Return odt
    End Function

    Public Function Consultar(ByVal id_empresa As Integer, ByVal fecha As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Ingreso_efectivo_GetAllGrilla", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = id_empresa
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha

        oda.Fill(odt)

        Return odt
    End Function

    'update el credito como marcado o no
    Public Sub Update_Check(ByVal id_ingreso_efectivo As Integer, ByVal control As Boolean)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Ingreso_efectivo_Update_Check"
        Command.Parameters.Add("@id_ingreso_efectivo", SqlDbType.Int, 4, "id_ingreso_efectivo")
        Command.Parameters("@id_ingreso_efectivo").Value = id_ingreso_efectivo
        Command.Parameters.Add("@control", SqlDbType.Bit, 1, "control")
        Command.Parameters("@control").Value = control

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'funcion para llenar el combo
    Public Function GetCmb_2(ByVal id_cliente As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Ingreso_efectivo_GetCmb_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = id_cliente
        oda.Fill(odt)

        Return odt
    End Function

    'archivo o desarchivo un ingreso
    Public Sub Archivar_ingreso(ByVal id_ingreso_efectivo As Integer, ByVal archivado As Boolean)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Ingreso_efectivo_Archivar_ingreso"
        Command.Parameters.Add("@id_ingreso_efectivo", SqlDbType.Int, 4, "id_ingreso_efectivo")
        Command.Parameters("@id_ingreso_efectivo").Value = id_ingreso_efectivo
        Command.Parameters.Add("@archivado", SqlDbType.Bit, 1, "archivado")
        Command.Parameters("@archivado").Value = archivado

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

End Class
