Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Egreso_efectivo_proveedor
    Inherits Egreso_efectivo_proveedor_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Egreso_efectivo_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Egreso_efectivo_proveedor", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_Egreso_efectivo_proveedor", SqlDbType.Int, 4, "id_Egreso_efectivo_proveedor")
        oda.SelectCommand.Parameters("@id_Egreso_efectivo_proveedor").Value = id_egreso_efectivo_proveedor

        oda.Fill(odt)
        Return odt
    End Function

    Public Function GetAllRecibo_proveedor(ByVal id_recibo_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Egreso_efectivo_proveedor_GetAllRecibo_proveedor", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_recibo_proveedor", SqlDbType.Int, 4, "id_recibo_proveedor")
        oda.SelectCommand.Parameters("@id_recibo_proveedor").Value = id_recibo_proveedor

        oda.Fill(odt)

        Return odt
    End Function

    Public Function GetImporte(ByVal id_egreso_efectivo_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Egreso_efectivo_proveedor_GetImporte", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_egreso_efectivo_proveedor", SqlDbType.Int, 4, "id_egreso_efectivo_proveedor")
        oda.SelectCommand.Parameters("@id_egreso_efectivo_proveedor").Value = id_egreso_efectivo_proveedor

        oda.Fill(odt)

        Return odt
    End Function


    Public Function GetOne_2(ByVal id_Egreso_efectivo As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Egreso_efectivo_GetOne_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_egreso_efectivo", SqlDbType.Int, 4, "id_egreso_efectivo")
        oda.SelectCommand.Parameters("@id_egreso_efectivo").Value = id_Egreso_efectivo

        oda.Fill(odt)

        Return odt
    End Function

    Public Function GetCmb_2(ByVal id_recibo_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Egreso_efectivo_proveedor_GetCmb_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_recibo_proveedor", SqlDbType.Int, 4, "id_recibo_proveedor")
        oda.SelectCommand.Parameters("@id_recibo_proveedor").Value = id_recibo_proveedor

        oda.Fill(odt)

        Return odt
    End Function

    Public Function GetAllEgreso_efectivo(ByVal id_egreso_efectivo As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Egreso_efectivo_proveedor_GetAllEgreso_efectivo", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_egreso_efectivo", SqlDbType.Int, 4, "id_egreso_efectivo")
        oda.SelectCommand.Parameters("@id_egreso_efectivo").Value = id_egreso_efectivo

        oda.Fill(odt)

        Return odt
    End Function

    Public Sub DeleteEgreso_efectivo_proveedor(ByVal id_Recibo_proveedor As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Egreso_efectivo_Proveedor_DeleteRecibo_proveedor"
        Command.Parameters.Add("@id_recibo_proveedor", SqlDbType.Int, 4, "id_recibo_proveedor")
        Command.Parameters("@id_recibo_proveedor").Value = id_Recibo_proveedor

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra los datos relacionados al encabezado
    Public Sub UpdateID(ByVal id_Recibo_proveedor As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Egreso_efectivo_Proveedor_UpdateID"
        Command.Parameters.Add("@id_recibo_proveedor", SqlDbType.Int, 4, "id_recibo_proveedor")
        Command.Parameters("@id_recibo_proveedor").Value = id_Recibo_proveedor
        'Command.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        'Command.Parameters("@id_usuario").Value = id_usuario

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'controla si existe el registro en la base de datos
    Public Function Exist_2() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Egreso_efectivo_proveedor_Exist_2", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_recibo_proveedor", SqlDbType.Int, 4, "id_recibo_proveedor")
        oda.SelectCommand.Parameters("@id_recibo_proveedor").Value = Me.id_recibo_proveedor
        oda.SelectCommand.Parameters.Add("@id_egreso_efectivo", SqlDbType.Int, 4, "id_egreso_efectivo")
        oda.SelectCommand.Parameters("@id_egreso_efectivo").Value = Me.id_egreso_efectivo
        oda.Fill(odt)
        Total = CInt(odt.Rows(0).Item("Total").ToString)
        If Total = 0 Then
            Return False  'NO EXISTE
        Else
            Return True 'SI EXISTE
        End If
    End Function

End Class
