Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Iva
    Inherits Iva_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Iva As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Iva", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_Iva", SqlDbType.Int, 4, "id_Iva")
        oda.SelectCommand.Parameters("@id_Iva").Value = id_Iva

        oda.Fill(odt)
        Return odt
    End Function


    'funcion de consulta Asignaciones

    Public Function GetAll_Asignacion(ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime, ByVal id_iva As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("[cop_iva_GetAll_Asignacion]", cnn.Coneccion)
        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha_inicio", SqlDbType.DateTime, 8, "fecha_inicio")
        oda.SelectCommand.Parameters("@fecha_inicio").Value = fecha_inicio
        oda.SelectCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime, 8, "fecha_fin")
        oda.SelectCommand.Parameters("@fecha_fin").Value = fecha_fin
        oda.SelectCommand.Parameters.Add("@id_iva", SqlDbType.Int, 4, "id_iva")
        oda.SelectCommand.Parameters("@id_iva").Value = id_iva
        oda.Fill(odt)
        Return odt
    End Function

    'Funcion consulta total asignación
    Public Function GetAsigna_Sum(ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime, ByVal id_iva As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Consulta_Asignacion_iva_GetAll_Sum", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha_inicio", SqlDbType.DateTime, 8, "fecha_inicio")
        oda.SelectCommand.Parameters("@fecha_inicio").Value = fecha_inicio
        oda.SelectCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime, 8, "fecha_fin")
        oda.SelectCommand.Parameters("@fecha_fin").Value = fecha_fin
        oda.SelectCommand.Parameters.Add("@id_iva", SqlDbType.Int, 4, "id_iva")
        oda.SelectCommand.Parameters("@id_iva").Value = id_iva

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta Pagos
    Public Function GetAll_Pagos(ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime, ByVal id_iva As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("[cop_iva_GetAll_pagos]", cnn.Coneccion)
        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha_inicio", SqlDbType.DateTime, 8, "fecha_inicio")
        oda.SelectCommand.Parameters("@fecha_inicio").Value = fecha_inicio
        oda.SelectCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime, 8, "fecha_fin")
        oda.SelectCommand.Parameters("@fecha_fin").Value = fecha_fin
        oda.SelectCommand.Parameters.Add("@id_iva", SqlDbType.Int, 4, "id_iva")
        oda.SelectCommand.Parameters("@id_iva").Value = id_iva
        oda.Fill(odt)
        Return odt
    End Function

    'Funcion consulta total pagos
    Public Function Getpagos_Sum(ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime, ByVal id_iva As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Consulta_Pagos_iva_GetAll_Sum", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha_inicio", SqlDbType.DateTime, 8, "fecha_inicio")
        oda.SelectCommand.Parameters("@fecha_inicio").Value = fecha_inicio
        oda.SelectCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime, 8, "fecha_fin")
        oda.SelectCommand.Parameters("@fecha_fin").Value = fecha_fin
        oda.SelectCommand.Parameters.Add("@id_iva", SqlDbType.Int, 4, "id_iva")
        oda.SelectCommand.Parameters("@id_iva").Value = id_iva

        oda.Fill(odt)

        Return odt
    End Function
End Class
