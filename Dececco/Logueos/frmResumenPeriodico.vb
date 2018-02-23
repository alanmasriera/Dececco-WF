Public Class frmResumenPeriodico
    Dim clientes As New List(Of Integer)
    Dim usuarios As New List(Of Integer)
    Dim loaded As Boolean = False
    Dim indice As Integer


    Sub New()
        ' TODO: Complete member initialization 
        InitializeComponent()

    End Sub

    Private Sub frmResumenPeriodico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim index As Integer
        Dim dt As New DataTable
        usuarios.Clear()
        clientes.Clear()

        dt = oUsuario.ConsultarNombreCompleto()
        For Each row As DataRow In dt.Rows
            index = dgv_usuarios.Rows.Add()
            dgv_usuarios.Rows(index).Cells("id_usuario").Value = CInt(row.Item("Id_usuario").ToString())
            dgv_usuarios.Rows(index).Cells("usuario").Value = (row.Item("Nombre_completo").ToString())
            dgv_usuarios.Rows(index).Cells("usuario_seleccionado").Value = False

        Next
        dt = oCliente.ConsultarTodo()
        For Each row As DataRow In dt.Rows
            index = dgv_clientes.Rows.Add()
            dgv_clientes.Rows(index).Cells("id_cliente").Value = CInt(row.Item("id_cliente").ToString())
            dgv_clientes.Rows(index).Cells("cliente").Value = (row.Item("Nombre_cliente").ToString())
            dgv_clientes.Rows(index).Cells("cliente_seleccionado").Value = False

        Next
        dtp_fecha_desde.Value = Date.Today
        dtp_fecha_hasta.Value = Date.Today

        Me.loaded = True

    End Sub

    'Private Sub dgv_clientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_clientes.CellContentClick


    '    If Me.loaded Then
    '        Me.indice = dgv_prints.Rows.Add()
    '        dgv_prints.Rows(Me.indice).Cells("errores").Value = "modifique clientes"
    '        clientes.Clear()
    '        For Each row As DataGridViewRow In dgv_clientes.Rows
    '            If CBool(row.Cells("cliente_seleccionado").Value.ToString()) Then
    '                clientes.Add(CInt(row.Cells("id_cliente").Value))
    '            End If
    '        Next
    '        Me.actualizarHoras()
    '    End If


    'If Me.loaded And e. = Me.dgv_clientes.Columns("cliente_seleccionado").Index Then
    '    Dim selectedRow As DataGridViewRow
    '    Dim selectedCell As DataGridViewCell
    '    Dim selectedClient As Integer
    '    selectedRow = dgv_clientes.Rows(e.RowIndex)
    '    selectedCell = selectedRow.Cells(e.ColumnIndex)
    '    selectedClient = CInt(selectedRow.Cells("id_cliente").Value)
    '    If clientes.Contains(selectedClient) Then
    '        If CBool(selectedCell.Value) = True Then
    '            Me.indice = dgv_prints.Rows.Add()
    '            dgv_prints.Rows(Me.indice).Cells("errores").Value = "elimine el cliente " + selectedClient.ToString()
    '            clientes.Remove(selectedClient)
    '        End If
    '    Else
    '        If CBool(selectedCell.Value) = False Then
    '            Me.indice = dgv_prints.Rows.Add()
    '            dgv_prints.Rows(Me.indice).Cells("errores").Value = "agregue el cliente " + selectedClient.ToString()
    '            clientes.Add(selectedClient)
    '        End If
    '    End If
    '    Me.actualizarHoras()
    'End If
    'End Sub
    'Private Sub dgv_usuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_usuarios.CellContentClick
    '    If Me.loaded Then
    '        Me.indice = dgv_prints.Rows.Add()
    '        dgv_prints.Rows(Me.indice).Cells("errores").Value = "modifique usuarios"
    '        usuarios.Clear()
    '        For Each row As DataRow In dgv_usuarios.Rows
    '            If CBool(row.Item("usuario_seleccionado").ToString()) Then
    '                usuarios.Add(CInt(row.Item("id_usuario")))
    '            End If
    '        Next
    '        Me.actualizarHoras()
    '    End If
    'If Me.loaded And e.ColumnIndex = Me.dgv_usuarios.Columns("usuario_seleccionado").Index Then
    '    Dim selectedRow As DataGridViewRow
    '    Dim selectedCell As DataGridViewCell
    '    Dim selectedUser As Integer
    '    selectedRow = dgv_usuarios.Rows(e.RowIndex)
    '    selectedCell = selectedRow.Cells(e.ColumnIndex)
    '    selectedUser = CInt(selectedRow.Cells("id_usuario").Value)
    '    If usuarios.Contains(selectedUser) Then
    '        If CBool(selectedCell.Value) = False Then
    '            usuarios.Remove(selectedUser)
    '        End If
    '    Else
    '        If CBool(selectedCell.Value) = True Then
    '            usuarios.Add(selectedUser)
    '        End If
    '    End If
    '    Me.actualizarHoras()
    'End If
    'End Sub

    'Private Sub actualizarHoras()

    '    Me.indice = dgv_prints.Rows.Add()
    '    dgv_prints.Rows(Me.indice).Cells("errores").Value = "entre a actualizar"
    '    Try
    '        Dim dt As DataTable
    '        Dim tiempo As TimeSpan = New TimeSpan(0)

    '        For Each cliente As Integer In clientes
    '            Me.indice = dgv_prints.Rows.Add()
    '            dgv_prints.Rows(Me.indice).Cells("errores").Value = "cliente " + cliente.ToString()
    '            For Each usuario As Integer In usuarios
    '                Dim proyectos As DataTable
    '                proyectos = oProyecto.ObtenerProyectos(CInt(cliente))
    '                For Each proyecto As DataRow In proyectos.Rows
    '                    dt = oCuerpo_movimiento_hora.GetLogueoDia(CInt(usuario), dtp_fecha_desde.Value, dtp_fecha_hasta.Value, CInt(cliente), CInt(proyecto.Item("Id_proyecto").ToString()))
    '                    For Each row As DataRow In dt.Rows
    '                        tiempo = tiempo + CDate(row.Item("hora_salida")).Subtract(CDate(CDate(row.Item("hora_entrada")).ToString("HH:mm:ss")))
    '                        Console.WriteLine(tiempo)
    '                    Next
    '                    Me.lbl_total_horas.Text = tiempo.ToString()
    '                    Me.lbl_total_horas.Text = String.Format("{0} horas {1} minutos {2} segundos", _
    '                    CInt(Math.Truncate(tiempo.TotalHours)), _
    '                    tiempo.Minutes, _
    '                    tiempo.Seconds)
    '                Next
    '            Next
    '        Next

    '    Catch ex As Exception

    '    End Try

    'End Sub

    'Private Sub dtp_fecha_desde_ValueChanged(sender As Object, e As EventArgs) Handles dtp_fecha_desde.ValueChanged
    '    Me.actualizarHoras()
    'End Sub

    'Private Sub dtp_fecha_hasta_ValueChanged(sender As Object, e As EventArgs) Handles dtp_fecha_hasta.ValueChanged
    '    Me.actualizarHoras()
    'End Sub


    Private Sub btn_agregar_anotacion_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click

        Dim dt As DataTable
        Dim tiempo As TimeSpan = New TimeSpan(0)
        Dim proyectos As DataTable
        Dim cliente As Integer
        Dim usuario As Integer
        Me.lbl_total_horas.Text = "calculando.Windows.Forms.."
        Try
            For Each rowC As DataGridViewRow In dgv_clientes.Rows
                If CBool(rowC.Cells("cliente_seleccionado").Value) Then
                    cliente = CInt(rowC.Cells("id_cliente").Value)
                    For Each rowU As DataGridViewRow In dgv_usuarios.Rows
                        If CBool(rowU.Cells("usuario_seleccionado").Value) Then
                            usuario = CInt(rowU.Cells("id_usuario").Value)
                            proyectos = oProyecto.ObtenerProyectos(CInt(cliente))
                            For Each proyecto As DataRow In proyectos.Rows
                                dt = oCuerpo_movimiento_hora.GetLogueoDia(CInt(usuario), dtp_fecha_desde.Value, dtp_fecha_hasta.Value, CInt(cliente), CInt(proyecto.Item("Id_proyecto").ToString()))
                                For Each row As DataRow In dt.Rows
                                    tiempo = tiempo + CDate(row.Item("Hora Salida")).Subtract(CDate(CDate(row.Item("Hora Entrada")).ToString("HH:mm:ss")))
                                Next
                                Me.lbl_total_horas.Text = tiempo.ToString()
                                Me.lbl_total_horas.Text = String.Format("{0} horas {1} minutos {2} segundos", _
                                CInt(Math.Truncate(tiempo.TotalHours)), _
                                tiempo.Minutes, _
                                tiempo.Seconds)
                            Next
                        End If
                    Next
                End If
            Next

        Catch ex As Exception
        End Try
    End Sub
End Class