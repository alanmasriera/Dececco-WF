Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Control
    Inherits Control_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Control As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Control", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_control", SqlDbType.Int, 4, "id_control")
        oda.SelectCommand.Parameters("@id_control").Value = id_Control

        oda.Fill(odt)
        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist_2(ByVal nombre_control As String) As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Control_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_control", SqlDbType.VarChar, 500, "nombre_control")
        oda.SelectCommand.Parameters("@nombre_control").Value = nombre_control

        oda.Fill(odt)
        Total = CInt(odt.Rows(0).Item("Total").ToString)
        If Total = 0 Then
            Return False  'NO EXISTE
        Else
            Return True 'SI EXISTE
        End If
    End Function

    'get all control
    Public Function GetAllControl(ByVal id_control As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Control_GetAllControl", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_control", SqlDbType.Int, 4, "id_control")
        oda.SelectCommand.Parameters("@id_control").Value = id_Control

        oda.Fill(odt)
        Return odt
    End Function

    'get all control
    Public Function GetAllVoz(ByVal id_control As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Control_GetAllVoz", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_control", SqlDbType.Int, 4, "id_control")
        oda.SelectCommand.Parameters("@id_control").Value = id_control

        oda.Fill(odt)
        Return odt
    End Function
    Public Function GetAllExiste(ByVal nombre_control As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Control_GetAllExiste", cnn.Coneccion)
        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_control", SqlDbType.NVarChar, 500, "nombre_control")
        oda.SelectCommand.Parameters("@nombre_control").Value = nombre_control
        oda.Fill(odt)
        Return odt
    End Function

    ' agregado para saber si un control tiene asociado un tipo voz
    Public Function ExisTipoVoz(ByVal id_control As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Control_ExisTipoVoz", cnn.Coneccion)
        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_control", SqlDbType.Int, 4, "id_control")
        oda.SelectCommand.Parameters("@id_control").Value = id_control
        oda.Fill(odt)
        Return odt
    End Function



End Class
