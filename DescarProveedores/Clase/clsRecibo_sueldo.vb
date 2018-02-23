Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Recibo_sueldo
    Inherits Recibo_sueldo_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Recibo_sueldo As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_sueldo", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_Recibo_sueldo", SqlDbType.Int, 4, "id_Recibo_sueldo")
        oda.SelectCommand.Parameters("@id_Recibo_sueldo").Value = id_Recibo_sueldo

        oda.Fill(odt)
        Return odt
    End Function

    'ejemplo de consulta con parametros
    Public Function GetReporte(ByVal liquidacion As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_sueldo_GetReporte", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@liquidacion", SqlDbType.VarChar, 500, "liquidacion")
        oda.SelectCommand.Parameters("@liquidacion").Value = liquidacion
        

        oda.Fill(odt)
        Return odt
    End Function

    'borra las liquidaciones que existen
    Public Sub DeleteLiquidacion(ByVal tipo_sueldo As String, ByVal id_empleado As Integer, ByVal inicio As DateTime, ByVal fin As DateTime)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Recibo_sueldo_DeleteLiquidacion"

        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.Add("@tipo_sueldo", SqlDbType.Char, 1, "tipo_sueldo")
        Command.Parameters("@tipo_sueldo").Value = tipo_sueldo
        Command.Parameters.Add("@id_empleado", SqlDbType.Int, 4, "id_empleado")
        Command.Parameters("@id_empleado").Value = id_empleado
        Command.Parameters.Add("@inicio", SqlDbType.DateTime, 8, "inicio")
        Command.Parameters("@inicio").Value = inicio
        Command.Parameters.Add("@fin", SqlDbType.DateTime, 8, "fin")
        Command.Parameters("@fin").Value = fin

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'funcion de consulta
    Public Function GetAll_2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_sueldo_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion de busqueda
    Public Function Find_2(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_sueldo_Find_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'ejemplo de consulta con parametros
    Public Function GetResumenEmpleado(ByVal id_empleado As Integer, ByVal inicio As DateTime, ByVal fin As DateTime, ByVal tipo_sueldo As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_sueldo_GetResumenEmpleado", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_empleado", SqlDbType.Int, 4, "id_empleado")
        oda.SelectCommand.Parameters("@id_empleado").Value = id_empleado
        oda.SelectCommand.Parameters.Add("@inicio", SqlDbType.DateTime, 8, "inicio")
        oda.SelectCommand.Parameters("@inicio").Value = inicio
        oda.SelectCommand.Parameters.Add("@fin", SqlDbType.DateTime, 8, "fin")
        oda.SelectCommand.Parameters("@fin").Value = fin
        oda.SelectCommand.Parameters.Add("@tipo_sueldo", SqlDbType.Char, 1, "tipo_sueldo")
        oda.SelectCommand.Parameters("@tipo_sueldo").Value = tipo_sueldo

        oda.Fill(odt)
        Return odt
    End Function

End Class


