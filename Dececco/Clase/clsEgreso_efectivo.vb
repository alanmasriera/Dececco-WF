Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Egreso_efectivo
    Inherits Egreso_efectivo_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Egreso_efectivo As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Egreso_efectivo", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_egreso_efectivo", SqlDbType.Int, 4, "id_egreso_efectivo")
        oda.SelectCommand.Parameters("@id_egreso_efectivo").Value = id_Egreso_efectivo

        oda.Fill(odt)
        Return odt
    End Function

    Public Function Consultar(ByVal id_empresa As Integer, ByVal fecha As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Egreso_efectivo_GetAllGrilla", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = id_empresa
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha

        oda.Fill(odt)

        Return odt
    End Function

    'update el debito como marcado o no
    Public Sub Update_Check(ByVal id_egreso_efectivo As Integer, ByVal control As Boolean)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Egreso_efectivo_Update_Check"
        Command.Parameters.Add("@id_egreso_efectivo", SqlDbType.Int, 4, "id_egreso_efectivo")
        Command.Parameters("@id_egreso_efectivo").Value = id_egreso_efectivo
        Command.Parameters.Add("@control", SqlDbType.Bit, 1, "control")
        Command.Parameters("@control").Value = control

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    Public Function GetCmb_2(ByVal id_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Egreso_efectivo_GetCmb_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proveedor", SqlDbType.Int, 4, "id_proveedor")
        oda.SelectCommand.Parameters("@id_proveedor").Value = id_proveedor

        oda.Fill(odt)

        Return odt
    End Function

    'borra los datos relacionados al encabezado
    Public Sub UpdateID(ByVal id_Recibo_proveedor As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Egreso_efectivo_UpdateID"
        Command.Parameters.Add("@id_recibo_proveedor", SqlDbType.Int, 4, "id_recibo_proveedor")
        Command.Parameters("@id_recibo_proveedor").Value = id_Recibo_proveedor
        'Command.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        'Command.Parameters("@id_usuario").Value = id_usuario

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    Public Sub ArchivarEgreso(ByVal id_egreso_efectivo As Integer, ByVal archivado As Boolean)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Egreso_efectivo_ArchivarEgreso"
        Command.Parameters.Add("@id_egreso_efectivo", SqlDbType.Int, 4, "id_egreso_efectivo")
        Command.Parameters("@id_egreso_efectivo").Value = id_egreso_efectivo
        Command.Parameters.Add("@archivado", SqlDbType.Bit, 1, "archivado")
        Command.Parameters("@archivado").Value = archivado

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub



End Class
