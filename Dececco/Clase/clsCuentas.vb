Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Cuentas
    Inherits Cuentas_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Cuentas As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuentas", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cuenta", SqlDbType.Int, 4, "id_cuenta")
        oda.SelectCommand.Parameters("@id_cuenta").Value = id_Cuentas

        oda.Fill(odt)
        Return odt
    End Function

    Public Function Consultar(ByVal idBanco As Integer, ByVal idEmpresa As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_CuentaBuscarBanco", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@Banco", SqlDbType.Int, 4, "id_banco")
        oda.SelectCommand.Parameters("@Banco").Value = idBanco
        oda.SelectCommand.Parameters.Add("@idEmpresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@idEmpresa").Value = idEmpresa

        oda.Fill(odt)
        Return odt
    End Function

    Public Function GetAll_2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_CUENTAS_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    Public Function ControlarCuenta(ByVal idBanco As Integer, ByVal idTitular As Integer, ByVal Numero As String) As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_CuentaControlar", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.SelectCommand.Parameters.Add("@idBanco", SqlDbType.Int, 4, "id_banco")
        oda.SelectCommand.Parameters("@idBanco").Value = idBanco
        oda.SelectCommand.Parameters.Add("@idTitular", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@idTitular").Value = idTitular
        oda.SelectCommand.Parameters.Add("@Numero", SqlDbType.NChar, 20, "numero")
        oda.SelectCommand.Parameters("@Numero").Value = Numero

        oda.Fill(odt)

        Total = CInt(odt.Rows(0).Item("Total"))

        If Total = 0 Then
            Return True
        Else
            Return False
        End If
    End Function


    'FUNCION PARA CONSULTAR EL COMBO
    Public Function GetCmb_2(ByVal id_banco As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuentas_GetCmb_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_banco", SqlDbType.Int, 4, "id_banco")
        oda.SelectCommand.Parameters("@id_banco").Value = id_banco

        oda.Fill(odt)

        Return odt
    End Function

    

    'funcion de busqueda
    Public Function Find_2(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_CUENTAS_Find_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function
End Class



