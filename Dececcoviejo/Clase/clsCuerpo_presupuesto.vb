Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Cuerpo_presupuesto
    Inherits Cuerpo_presupuesto_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Cuerpo_presupuesto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_presupuesto", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cuerpo_presupuesto", SqlDbType.Int, 4, "id_cuerpo_presupuesto")
        oda.SelectCommand.Parameters("@id_cuerpo_presupuesto").Value = id_Cuerpo_presupuesto

        oda.Fill(odt)
        Return odt
    End Function


    'ejemplo de consulta con parametros
    Public Function GetAllMovimiento(ByVal id_presupuesto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_presupuesto_GetAllMovimiento", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_presupuesto", SqlDbType.Int, 4, "id_presupuesto")
        oda.SelectCommand.Parameters("@id_presupuesto").Value = id_presupuesto

        oda.Fill(odt)
        Return odt
    End Function

    'borra los datos relacionados al encabezado
    Public Sub Deletepresupuesto(ByVal id_presupuesto As Integer, ByVal id_usuario As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cuerpo_presupuesto_Deletepresupuesto"
        Command.Parameters.Add("@id_presupuesto", SqlDbType.Int, 4, "id_presupuesto")
        Command.Parameters("@id_presupuesto").Value = id_presupuesto
        Command.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        Command.Parameters("@id_usuario").Value = id_usuario

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra los datos relacionados al encabezado
    Public Sub UpdateID(ByVal id_presupuesto As Integer, ByVal id_usuario As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cuerpo_presupuesto_UpdateID"
        Command.Parameters.Add("@id_presupuesto", SqlDbType.Int, 4, "id_presupuesto")
        Command.Parameters("@id_presupuesto").Value = id_presupuesto
        Command.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        Command.Parameters("@id_usuario").Value = id_usuario

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

End Class





    'borra los datos relacionados al encabezado
    