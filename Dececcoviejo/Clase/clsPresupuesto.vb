Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Presupuesto
    Inherits Presupuesto_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Presupuesto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Presupuesto", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_presupuesto", SqlDbType.Int, 4, "id_presupuesto")
        oda.SelectCommand.Parameters("@id_presupuesto").Value = id_Presupuesto

        oda.Fill(odt)
        Return odt
    End Function

    'funcion de consulta
    Public Function GetAll_2(ByVal id_cliente As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Presupuesto_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = id_cliente
        'oda.SelectCommand.Parameters.Add("@fecha_inicio", SqlDbType.DateTime, 8, "fecha_inicio")
        'oda.SelectCommand.Parameters("@fecha_inicio").Value = fecha_inicio
        'oda.SelectCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime, 8, "fecha_fin")
        'oda.SelectCommand.Parameters("@fecha_fin").Value = fecha_fin
        oda.Fill(odt)

        Return odt
    End Function
End Class
