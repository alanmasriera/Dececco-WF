Imports System.Data.SqlClient

Public Class Backup
    Private cnn As New Conexion

    Private _nombre_base_dato As String
    Public Property nombre_base_dato() As String
        Get
            Return _nombre_base_dato
        End Get
        Set(ByVal Value As String)
            _nombre_base_dato = Value
        End Set
    End Property

    Private _path As String
    Public Property path() As String
        Get
            Return _path
        End Get
        Set(ByVal Value As String)
            _path = Value
        End Set
    End Property

    Private _estado As String
    Public Property estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal Value As String)
            _estado = Value
        End Set
    End Property

    'crea la base de datos
    Public Sub HacerBackup()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()
        Dim sBackup As String = "BACKUP DATABASE " & nombre_base_dato & _
                                " TO DISK = N'" & path & _
                                ".bak' WITH NOFORMAT, NOINIT, NAME =N'" & nombre_base_dato & _
                                "-Full Database Backup',SKIP, NOREWIND, NOUNLOAD,  STATS = 10"

        Command.Connection = oConexion.Coneccion
        Command.CommandText = sBackup
        Command.CommandType = CommandType.Text

        Command.Connection.Open()

        Try
            Command.ExecuteNonQuery()
            MessageBox.Show("Se ha creado un BackUp de la base de datos satisfactoriamente", _
                        "Copia de seguridad de base de datos", _
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
            estado = "ok"
        Catch ex As Exception
            MessageBox.Show(ex.Message, _
                            "Error al copiar la base de datos", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = "error"
        End Try

        Command.Connection.Close()
    End Sub



End Class
