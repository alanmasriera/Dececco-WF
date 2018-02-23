Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Asiento_modelo
    Inherits Asiento_modelo_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Asiento_modelo As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Asiento_modelo", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_asiento_modelo", SqlDbType.Int, 4, "id_asiento_modelo")
        oda.SelectCommand.Parameters("@id_asiento_modelo").Value = id_Asiento_modelo

        oda.Fill(odt)
        Return odt
    End Function

    'funcion de consulta
    Public Function GetAll_2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Asiento_modelo_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion de busqueda
    Public Function Find_2(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Asiento_modelo_Find_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist_2(ByVal id_tipo_asiento As Integer, ByVal id_cuenta_imputable As Integer) As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Asiento_modelo_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cuenta_imputable", SqlDbType.Int, 4, "id_cuenta_imputable")
        oda.SelectCommand.Parameters("@id_cuenta_imputable").Value = id_cuenta_imputable
        oda.SelectCommand.Parameters.Add("@id_tipo_asiento", SqlDbType.Int, 4, "id_tipo_asiento")
        oda.SelectCommand.Parameters("@id_tipo_asiento").Value = id_tipo_asiento

        oda.Fill(odt)
        Total = CInt(odt.Rows(0).Item("Total").ToString)
        If Total = 0 Then
            Return False  'NO EXISTE
        Else
            Return True 'SI EXISTE
        End If
    End Function

End Class


