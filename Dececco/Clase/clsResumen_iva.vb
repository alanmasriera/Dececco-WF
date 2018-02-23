Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Resumen_iva
    Inherits Resumen_iva_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Resumen_iva As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Resumen_iva", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_resumen_Iva", SqlDbType.Int, 4, "id_resumen_Iva")
        oda.SelectCommand.Parameters("@id_resumen_Iva").Value = id_Resumen_iva

        oda.Fill(odt)
        Return odt
    End Function

    'update la tabla
    Public Sub Update()
        Me.CrearComandoUpdate()
    End Sub

    'genero el resumen de compras
    Public Function SetResumen(ByVal id_empresa As Integer, ByVal id_iva As Integer, ByVal fecha As DateTime) As DataTable
        dt = New DataTable
        da = New SqlDataAdapter("cop_Resumen_iva_Set", cnn.Coneccion)

        da.SelectCommand.CommandType = CommandType.StoredProcedure

        da.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.Int, 4, "id_empresa")
        da.SelectCommand.Parameters("@id_empresa").Value = id_empresa
        da.SelectCommand.Parameters.Add("@id_iva", SqlDbType.Int, 4, "id_iva")
        da.SelectCommand.Parameters("@id_iva").Value = id_iva
        da.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        da.SelectCommand.Parameters("@fecha").Value = fecha

        da.Fill(dt)
        Return dt
    End Function
End Class
