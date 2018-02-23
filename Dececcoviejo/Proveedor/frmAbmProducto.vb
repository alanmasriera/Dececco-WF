Imports Ean13Barcode2005

Public Class frmAbmProducto

    Dim odt As DataTable
    Dim BanderaConsultaProducto As Integer

    Private Sub frmAbmProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ttGeneral.SetToolTip(Me.btnAgregar, "Incorporar Nuevo Producto")
        Me.ttGeneral.SetToolTip(Me.btnBorrar, "Borrar un  Producto Existente")
        Me.ttGeneral.SetToolTip(Me.btnModificar, "Modificar  un Producto Existente")
        'Me.ttGeneral.SetToolTip(Me.btnConsultar, "Consultar Datos del  Producto Existente")

        Dim odt As DataTable
        odt = oProducto.Cargar()

        RefrescarGrilla()
        Me.txtBuscar.Focus()
        Me.lblTitulo.Text = "Producto"
        Me.Text = "Producto"
        Me.CancelButton = Me.btnSalir
        Me.BackColor = Color.Gainsboro
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False

        'control de acceso y de permisos
        Dim odtUser As New DataTable
        odtUser = oUsuario.GetPermiso(vgNombreUsuario, Me.Name)
        If odtUser.Rows.Count = 0 OrElse CDbl(odtUser.Rows(0).Item("habilitado")) = 0 Then
            Me.btnAgregar.Enabled = False
            Me.btnBorrar.Enabled = False
            Me.btnModificar.Enabled = False
        End If
        'btnAyuda.Visible = False

        Me.txtTotal.Text = "0"
    End Sub

    Public Sub RefrescarGrilla()
        Dim odt As DataTable

        odt = oProducto.GetAll_2
        Me.dgv1.DataSource = odt
        Me.dgv1.Columns(0).Visible = False
        Me.dgv1.Columns(3).Visible = False
    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar.ToString = vbCr Then
            Me.btnModificar.Focus()
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        If Me.txtBuscar.Text = "" Then
            Me.txtBuscar.Text = " "
        End If
        odt = oProducto.Find_2(Me.txtBuscar.Text)
        Me.dgv1.DataSource = odt
    End Sub

    Private Sub dgv1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv1.CurrentCellChanged
        Try
            Me.lblid_pk.Text = CStr(Me.dgv1.Item(0, Me.dgv1.CurrentRow.Index).Value)
            Me.txtCodigo.Text = CStr(Me.dgv1.Item("nombre_producto", Me.dgv1.CurrentRow.Index).Value)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Botones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnAgregar.Click, btnBorrar.Click, btnModificar.Click, btnSalir.Click, btnImprimirCodigo.Click
        Dim btnTemp As New Button
        Dim frmDetalle As New frmDetalleProducto
        btnTemp = CType(sender, Button)
        Try
            Select Case btnTemp.Name
                Case "btnAgregar"
                    BanderaProducto = 1
                    Me.AddOwnedForm(frmDetalle)
                    oProducto.Insertar()
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                Case "btnModificar"
                    If Not IsNumeric(Me.lblid_pk.Text) Then
                        Exit Sub
                    End If
                    BanderaProducto = 2
                    Me.AddOwnedForm(frmDetalle)
                    oProducto.Modificar(CInt(Me.lblid_pk.Text))
                    frmDetalle.CargarCombos()
                    frmDetalle.ShowDialog()
                    RefrescarGrilla()
                Case "btnBorrar"
                    If Not IsNumeric(Me.lblid_pk.Text) Then
                        Exit Sub
                    End If

                    If MessageBox.Show("Desea Realmente Eliminar el Registro ", "BORRAR", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                    = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If

                    oProducto.Borrar(CInt(Me.lblid_pk.Text))
                    RefrescarGrilla()
                Case "btnImprimirCodigo"
                    'Me.ImprimirCodigo()

                Case "btnSalir"
                    Me.Close()
            End Select
            Me.txtBuscar.Text = ""
            Me.txtBuscar.Focus()
        Catch ex As Exception
            Errores(ex)
        End Try
    End Sub


    'Private ean13 As Ean13 = Nothing

    'Private Sub CreateEan13(ByVal nombre_producto As String)
    '    Dim strCodProd As String = ""

    '    strCodProd = nombre_producto

    '    'ean13 = New Ean13
    '    ean13.CountryCode = strCodProd.Substring(0, 3)
    '    ean13.ManufacturerCode = strCodProd.Substring(3, 4)
    '    ean13.ProductCode = strCodProd.Substring(7, 5)
    '    ean13.ChecksumDigit = strCodProd.Substring(12, 1)
    'End Sub

    'Sub ImprimirCodigo()
    '    '	pd.PrintPage += new System.Drawing.Printing.PrintPageEventHandler( this.pd_PrintPage );

    '    Dim pd As System.Drawing.Printing.PrintDocument = New System.Drawing.Printing.PrintDocument
    '    AddHandler pd.PrintPage, AddressOf Me.pd_PrintPage

    '    pd.Print()
    'End Sub

    'Private Sub pd_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) _
    'Handles pd.PrintPage
    '    Dim odt As New DataTable





    '    Dim X As Integer = 0
    '    Dim Y As Integer = 0
    '    Dim i As Integer = 1

    '    For Each row As DataRow In odt.Rows
    '        Me.CreateEan13(CStr(row("nombre_producto")))
    '        ean13.Scale = 0.8

    '        If i >= 1 And i < 23 Then
    '            X = 4
    '        ElseIf i >= 23 And i < 45 Then
    '            X = 56
    '        ElseIf i >= 45 And i < 67 Then
    '            X = 108
    '        ElseIf i >= 67 And i < 89 Then
    '            X = 160
    '        End If

    '        Select Case i
    '            Case 1, 23, 45, 67

    '                Y = 0
    '                ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '            Case 2, 24, 46, 68

    '                Y = 12
    '                ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '            Case 3, 25, 47, 69

    '                Y = 25
    '                ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '            Case 4, 26, 48, 70

    '                Y = 37
    '                ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '            Case 5, 27, 49, 71

    '                Y = 50
    '                ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '            Case 6, 28, 50, 72

    '                Y = 62
    '                ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '            Case 7, 29, 51, 73

    '                Y = 75
    '                ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '            Case 8, 30, 52, 74

    '                Y = 87
    '                ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '            Case 9, 31, 53, 75

    '                Y = 100
    '                ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '            Case 10, 32, 54, 76

    '                Y = 113
    '                ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '            Case 11, 33, 55, 77

    '                Y = 126
    '                ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '            Case 12, 34, 56, 78

    '                Y = 138
    '                ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '            Case 13, 35, 57, 79

    '                Y = 151
    '                ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '            Case 14, 36, 58, 80

    '                Y = 163
    '                ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '            Case 15, 37, 59, 81

    '                Y = 176
    '                ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '            Case 16, 38, 60, 82

    '                Y = 188
    '                ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '            Case 17, 39, 61, 83

    '                Y = 201
    '                ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '            Case 18, 40, 62, 84

    '                Y = 214
    '                ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '            Case 19, 41, 63, 85

    '                Y = 227
    '                ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '            Case 20, 42, 64, 86

    '                Y = 239
    '                ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '            Case 21, 43, 65, 87

    '                Y = 252
    '                ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '            Case 22, 44, 66, 88

    '                Y = 264
    '                ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))



    '        End Select
    '        i = i + 1
    '    Next

    '    ''columna 1
    '    'X = 4
    '    'Y = 0
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 12
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 25
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 37
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 50
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 62
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 75
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 87
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 100
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 113
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 126
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 138
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 151
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 163
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 176
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 188
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 201
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 214
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 227
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 239
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 252
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 264
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))

    '    ''columna 2
    '    'X = 56
    '    'Y = 0
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 12
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 25
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 37
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 50
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 62
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 75
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 87
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 100
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 113
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 126
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 138
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 151
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 163
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 176
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 188
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 201
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 214
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 227
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 239
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 252
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 264
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))


    '    ''columna 3
    '    'X = 108
    '    'Y = 0
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 12
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 25
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 37
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 50
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 62
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 75
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 87
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 100
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 113
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 126
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 138
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 151
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 163
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 176
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 188
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 201
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 214
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 227
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 239
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 252
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 264
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))


    '    ''columna 4
    '    'X = 160
    '    'Y = 0
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 12
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 25
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 37
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 50
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 62
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 75
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 87
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 100
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 113
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 126
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 138
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 151
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 163
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 176
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 188
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 201
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 214
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 227
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 239
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 252
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))
    '    'Y = 264
    '    'ean13.DrawEan13Barcode(e.Graphics, New System.Drawing.Point(X, Y))


    '    e.Graphics.Dispose()
    'End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
 
        Me.txtTotal.Text = "0"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Dim odt As New DataTable

        'If Me.txtCantidad.Text = "" Then
        '    Exit Sub
        'End If
        'If Not IsNumeric(Me.txtCantidad.Text) Then
        '    Exit Sub
        'End If

        'Try
        '    For i As Integer = 1 To CInt(Me.txtCantidad.Text)


        '        Me.txtTotal.Text = CStr(odt.Rows.Count + 1)
        '    Next
        'Catch ex As Exception
        'End Try

    End Sub

End Class
