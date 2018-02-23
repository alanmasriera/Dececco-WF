Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Chequeras
    Inherits Chequeras_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Chequeras As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Chequeras", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_chequera", SqlDbType.Int, 4, "id_chequera")
        oda.SelectCommand.Parameters("@id_chequera").Value = id_Chequeras

        oda.Fill(odt)

        Return odt
    End Function

    'Public Function ConsultarNumeroChequeMayor(ByVal idChequera As Integer) As String
    '    Dim odt As New DataTable
    '    Dim oda As New SqlDataAdapter("cop_Chequera_ConsultarNumeroChequeMayor", cnn.Coneccion)
    '    Dim Total As String

    '    oda.SelectCommand.CommandType = CommandType.StoredProcedure
    '    oda.SelectCommand.Parameters.Add("@idChequera", SqlDbType.Int, 4, "id_chequera")
    '    oda.SelectCommand.Parameters("@idChequera").Value = idChequera

    '    oda.Fill(odt)
    '    Total = odt.Rows(0).Item("Total").ToString
    '    Return Total
    'End Function

    Public Function GetAll_2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Chequeras_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function
    Public Function Find_2(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Chequeras_Find_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'FUNCION PARA CONSULTAR EL COMBO
    Public Function GetCmb_2(ByVal id_cuenta As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Chequeras_GetCmb_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cuenta", SqlDbType.Int, 4, "id_cuenta")
        oda.SelectCommand.Parameters("@id_cuenta").Value = id_cuenta

        oda.Fill(odt)

        Return odt
    End Function

    Public Function ConsultarNumeroChequeMayorNuevo(ByVal idChequera As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Chequera_ConsultarNumeroChequeMayorNuevo", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@idChequera", SqlDbType.Int, 4, "id_chequera")
        oda.SelectCommand.Parameters("@idChequera").Value = idChequera

        oda.Fill(odt)
        Return odt
    End Function

End Class
