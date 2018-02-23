Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Cuerpo_movimiento_voz
    Inherits Cuerpo_movimiento_voz_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Cuerpo_movimiento_voz As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_voz", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cuerpo_movimiento_voz", SqlDbType.Int, 4, "id_cuerpo_movimiento_voz")
        oda.SelectCommand.Parameters("@id_cuerpo_movimiento_voz").Value = id_Cuerpo_movimiento_voz

        oda.Fill(odt)
        Return odt
    End Function

    'borra los datos relacionados al encabezado
    Public Sub Deletemovimiento_voz(ByVal id_movimiento_voz As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cuerpo_movimiento_voz_Deletemovimiento_voz"
        Command.Parameters.Add("@id_movimiento_voz", SqlDbType.Int, 4, "id_movimiento_voz")
        Command.Parameters("@id_movimiento_voz").Value = id_movimiento_voz

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra los datos relacionados al encabezado
    Public Sub UpdateID(ByVal id_movimiento_voz As Integer, ByVal id_usuario As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cuerpo_movimiento_voz_UpdateID"
        Command.Parameters.Add("@id_movimiento_voz", SqlDbType.Int, 4, "id_movimiento_voz")
        Command.Parameters("@id_movimiento_voz").Value = id_movimiento_voz
        Command.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        Command.Parameters("@id_usuario").Value = id_usuario

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'funcion de consulta
    Public Function GetAll_2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_voz_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion de busqueda
    Public Function Find_2(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_voz_Find_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'ejemplo de consulta con parametros
    Public Function GetPath(ByVal id_Cuerpo_movimiento_voz As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_voz_GetPath", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cuerpo_movimiento_voz", SqlDbType.Int, 4, "id_cuerpo_movimiento_voz")
        oda.SelectCommand.Parameters("@id_cuerpo_movimiento_voz").Value = id_Cuerpo_movimiento_voz

        oda.Fill(odt)
        Return odt
    End Function

    'grilla del project manager
    Public Function GetAllGrilla(ByVal id_proyect_manager As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_voz_GetAllGrilla", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proyect_manager", SqlDbType.Int, 4, "id_proyect_manager")
        oda.SelectCommand.Parameters("@id_proyect_manager").Value = id_proyect_manager

        oda.Fill(odt)
        Return odt
    End Function

    'trae el cuerpo de ese movimiento de voz
    Public Function GetAllMovimiento(ByVal id_movimiento_voz As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_voz_GetAllMovimiento", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_movimiento_voz", SqlDbType.Int, 4, "id_movimiento_voz")
        oda.SelectCommand.Parameters("@id_movimiento_voz").Value = id_movimiento_voz

        oda.Fill(odt)
        Return odt
    End Function


    'actualiza a todos como no corresponde
    Public Sub UpdateNoCorresponde(ByVal id_tipo_voz As Integer, ByVal id_movimiento_voz As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cuerpo_movimiento_voz_UpdateNoCorresponde"
        Command.Parameters.Add("@id_tipo_voz", SqlDbType.Int, 4, "id_tipo_voz")
        Command.Parameters("@id_tipo_voz").Value = id_tipo_voz
        Command.Parameters.Add("@id_movimiento_voz", SqlDbType.Int, 4, "id_movimiento_voz")
        Command.Parameters("@id_movimiento_voz").Value = id_movimiento_voz

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'actualiza a todos como no corresponde
    Public Sub UpdatePedidoSegundoControl(ByVal id_tipo_voz As Integer, ByVal id_movimiento_voz As Integer, ByVal pedido_segundo_control As Boolean)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cuerpo_movimiento_voz_UpdatePedidoSegundoControl"
        Command.Parameters.Add("@id_tipo_voz", SqlDbType.Int, 4, "id_tipo_voz")
        Command.Parameters("@id_tipo_voz").Value = id_tipo_voz
        Command.Parameters.Add("@id_movimiento_voz", SqlDbType.Int, 4, "id_movimiento_voz")
        Command.Parameters("@id_movimiento_voz").Value = id_movimiento_voz
        Command.Parameters.Add("@pedido_segundo_control", SqlDbType.Bit, 1, "pedido_segundo_control")
        Command.Parameters("@pedido_segundo_control").Value = pedido_segundo_control

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'trae el cuerpo de ese movimiento de voz de los cuales tienen numero de revision=0 o sea  no se han revisado
    Public Function GetAllMovimientoCerrado(ByVal id_movimiento_voz As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_voz_GetAllMovimientoCerrado", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_movimiento_voz", SqlDbType.Int, 4, "id_movimiento_voz")
        oda.SelectCommand.Parameters("@id_movimiento_voz").Value = id_movimiento_voz

        oda.Fill(odt)
        Return odt
    End Function

    'marca todos los controles como no revisados
    Public Sub UpdateControlNoCompleto(ByVal id_movimiento_voz As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        'marcacontrolnocompleto---------
        Command.CommandText = "cop_Cuerpo_movimiento_voz_UpdateControlNoCompleto"
        'Command.CommandText = "cop_Cuerpo_movimiento_voz_GetAllMovimientoGetMaxRevision"
        '----------------------
        Command.Parameters.Add("@id_movimiento_voz", SqlDbType.Int, 4, "id_movimiento_voz")
        Command.Parameters("@id_movimiento_voz").Value = id_movimiento_voz

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'consulta los registros de un control de un tipo de voz
    Public Function GetAllMovimientoTipoVoz(ByVal id_movimiento_voz As Integer, ByVal id_tipo_voz As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_voz_GetAllMovimientoTipoVoz", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_movimiento_voz", SqlDbType.Int, 4, "id_movimiento_voz")
        oda.SelectCommand.Parameters("@id_movimiento_voz").Value = id_movimiento_voz
        oda.SelectCommand.Parameters.Add("@id_tipo_voz", SqlDbType.Int, 4, "id_tipo_voz")
        oda.SelectCommand.Parameters("@id_tipo_voz").Value = id_tipo_voz

        oda.Fill(odt)
        Return odt
    End Function

    'consulta el numero mayor de revision del control
    Public Function GetAllMovimientoGetMaxRevision(ByVal id_movimiento_voz As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_voz_GetAllMovimientoGetMaxRevision", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_movimiento_voz", SqlDbType.Int, 4, "id_movimiento_voz")
        oda.SelectCommand.Parameters("@id_movimiento_voz").Value = id_movimiento_voz

        oda.Fill(odt)
        Return odt
    End Function

    'consulta por el numero de revision del registro
    Public Function GetAllMovimientoGetRevision(ByVal id_movimiento_voz As Integer, ByVal numero_revision As Decimal) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_voz_GetAllMovimientoGetRevision", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_movimiento_voz", SqlDbType.Int, 4, "id_movimiento_voz")
        oda.SelectCommand.Parameters("@id_movimiento_voz").Value = id_movimiento_voz
        oda.SelectCommand.Parameters.Add("@numero_revision", SqlDbType.Decimal, 9, "numero_revision")
        oda.SelectCommand.Parameters("@numero_revision").Value = numero_revision

        oda.Fill(odt)
        Return odt
    End Function


End Class








