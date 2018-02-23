Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Empleado_renglon
    Inherits Empleado_renglon_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Empleado_renglon As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Empleado_renglon", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_empleado_renglon", SqlDbType.Int, 4, "id_empleado_renglon")
        oda.SelectCommand.Parameters("@id_empleado_renglon").Value = id_Empleado_renglon

        oda.Fill(odt)
        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist_2(ByVal id_empleado As Integer, ByVal id_renglon As Integer) As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Empleado_renglon_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_empleado", SqlDbType.Int, 4, "id_empleado")
        oda.SelectCommand.Parameters("@id_empleado").Value = id_empleado
        oda.SelectCommand.Parameters.Add("@id_renglon", SqlDbType.Int, 4, "id_renglon")
        oda.SelectCommand.Parameters("@id_renglon").Value = id_renglon

        oda.Fill(odt)
        Total = CInt(odt.Rows(0).Item("Total").ToString)
        If Total = 0 Then
            Return False  'NO EXISTE
        Else
            Return True 'SI EXISTE
        End If
    End Function

    'getall 2
    Public Function GetAll_2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Empleado_renglon_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.Fill(odt)
        Return odt
    End Function

    'funcion de busqueda
    Public Function Find_2(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Empleado_renglon_Find_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

End Class
