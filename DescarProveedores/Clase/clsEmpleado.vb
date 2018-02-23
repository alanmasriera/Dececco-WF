Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Empleado
    Inherits Empleado_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Empleado As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Empleado", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_empleado", SqlDbType.Int, 4, "id_empleado")
        oda.SelectCommand.Parameters("@id_empleado").Value = id_Empleado

        oda.Fill(odt)
        Return odt
    End Function

    'combo 2
    Public Function GetCmb_2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Empleado_GetCmb_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.Fill(odt)
        Return odt
    End Function

    'combo 2
    Public Function GetCmb_3() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Empleado_GetCmb_3", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.Fill(odt)
        Return odt
    End Function

    'getone 2
    Public Function GetOne_2(ByVal id_Empleado As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Empleado_GetOne_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_empleado", SqlDbType.Int, 4, "id_empleado")
        oda.SelectCommand.Parameters("@id_empleado").Value = id_Empleado

        oda.Fill(odt)

        Return odt
    End Function

    'getone 3
    Public Function GetOne_3(ByVal id_Empleado As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Empleado_GetOne_3", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_empleado", SqlDbType.Int, 4, "id_empleado")
        oda.SelectCommand.Parameters("@id_empleado").Value = id_Empleado

        oda.Fill(odt)

        Return odt
    End Function

    'trae los empleados activos
    Public Function GetActivo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Empleado_GetActivo", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.Fill(odt)
        Return odt
    End Function

    'get entre legajos
    Public Function GetEntreLegajo(ByVal legajo_desde As Integer, ByVal legajo_hasta As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Empleado_GetEntreLegajo", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@legajo_desde", SqlDbType.Int, 4, "legajo_desde")
        oda.SelectCommand.Parameters("@legajo_desde").Value = legajo_desde
        oda.SelectCommand.Parameters.Add("@legajo_hasta", SqlDbType.Int, 4, "legajo_hasta")
        oda.SelectCommand.Parameters("@legajo_hasta").Value = legajo_hasta

        oda.Fill(odt)

        Return odt
    End Function

    'trae los empleados que tienen recibo de sueldo
    Public Function GetCmbReporte() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_sueldo_temporal_GetAllReporte", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.Fill(odt)
        Return odt
    End Function

    'controla si existe el registro en la base de datos por cuil
    Public Function Exist_2() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Empleado_Exist_2", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@cuil", SqlDbType.VarChar, 50, "cuil")
        oda.SelectCommand.Parameters("@cuil").Value = Me.cuil

        oda.Fill(odt)
        Total = CInt(odt.Rows(0).Item("Total").ToString)
        If Total = 0 Then
            Return False  'NO EXISTE
        Else
            Return True 'SI EXISTE
        End If
    End Function


End Class
