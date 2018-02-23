Imports MECMOD
Imports HybridShapeTypeLib
Imports ProductStructureTypeLib
Imports INFITF

Public Class Form1

    Dim CATIA As INFITF.Application
    Dim MyPart
    Dim first As Boolean = True
    Dim selection1 As INFITF.Selection

    Public Sub New()
        InitializeComponent()
        comenzarLogueoCATIA()
    End Sub

    Private Sub comenzarLogueoCATIA()
        'Try
        '    CATIA = System.Runtime.InteropServices.Marshal.GetActiveObject("CATIA.Application")

        Try
            CATIA = System.Runtime.InteropServices.Marshal.GetActiveObject("CATIA.Application")
            Timer1.Start()
        Catch ex As Exception
            MessageBox.Show("CATIA debe estar ejecutándose para poder sumar las horas trabajadas")
        End Try
        'Catch ex As Exception
        '    MessageBox.Show("CATIA debe estar ejecutándose para poder sumar las horas trabajadas")
        'End Try
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        For Each P As Process In Process.GetProcessesByName("CNEXT")
            ' MessageBox.Show(P.ProcessName)
            ' CATIA = System.Runtime.InteropServices.Marshal.GetActiveObject(P)

        Next


            selection1 = CATIA.ActiveDocument.Selection
            Dim part
            Dim feature

            If first And selection1.Count2 > 0 Then
                Try
                    feature = selection1.Item2(1).Value
                    MyPart = GetIdUnidad(selection1.Item2(1).Value)

                    If MyPart Is Nothing = False Then
                        first = False

                        Dim dr As New DataGridViewRow

                        dr.CreateCells(dgv_logueo)
                        dr.Cells(0).Value = DateTime.Now.ToString()
                        dr.Cells(1).Value = DateTime.Now.ToString()
                        dr.Cells(2).Value = MyPart

                        dgv_logueo.Rows.Add(dr)
                        dgv_logueo.Update()

                    End If

                Catch ex As Exception
                    Dim a As String = ex.Message
                End Try
            ElseIf first And selection1.Count2 = 0 Then
                Try
                    MyPart = GetIdUnidad(CATIA.ActiveDocument)

                    If MyPart Is Nothing = False Then
                        first = False

                        Dim dr As New DataGridViewRow

                        dr.CreateCells(dgv_logueo)
                        dr.Cells(0).Value = DateTime.Now.ToString()
                        dr.Cells(1).Value = DateTime.Now.ToString()
                        dr.Cells(2).Value = MyPart

                        dgv_logueo.Rows.Add(dr)
                        dgv_logueo.Update()

                    End If

                Catch ex As Exception
                    Dim a As String = ex.Message
                End Try
            End If

            If selection1.Count2 > 0 And first = False Then
                Try
                    part = GetIdUnidad(selection1.Item2(1).Value)
                    If part Is Nothing = False Then
                        If MyPart = part Then
                            dgv_logueo.Rows(dgv_logueo.Rows.Count - 1).Cells(1).Value = DateTime.Now.ToString()
                            dgv_logueo.Update()
                        Else
                            MyPart = part
                            Dim dr As New DataGridViewRow
                            dr.CreateCells(dgv_logueo)
                            dr.Cells(0).Value = DateTime.Now.ToString()
                            dr.Cells(1).Value = DateTime.Now.ToString()
                            dr.Cells(2).Value = MyPart

                            dgv_logueo.Rows.Add(dr)
                            dgv_logueo.Update()

                        End If
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If

            If selection1.Count2 = 0 And first = False Then
                Try
                    dgv_logueo.Rows(dgv_logueo.Rows.Count - 1).Cells(1).Value = DateTime.Now.ToString()
                    dgv_logueo.Update()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If



    End Sub

    Function GetIdUnidad(ByRef iObject As Object) As String

        If selection1.Count2 > 0 Then
            Return prueba(selection1.Item(1).Value)
        End If

    End Function


    Function prueba(ByRef iObject As Object) As String
        Dim Feature, LeafProduct, LeafProductProcessed
        Dim AutomationTreeNodeOrProduct
        Dim id_unidad As String

        Try
            Feature = selection1.Item(1).Value
            LeafProduct = selection1.Item(1).LeafProduct
            LeafProductProcessed = True

            If (LeafProduct.Name <> "InvalidLeafProduct") Then LeafProductProcessed = False
            AutomationTreeNodeOrProduct = Feature
            Do While (TypeName(AutomationTreeNodeOrProduct) <> "Application")


                If (TypeName(AutomationTreeNodeOrProduct) = "ProductDocument" Or TypeName(AutomationTreeNodeOrProduct) = "Product" Or TypeName(AutomationTreeNodeOrProduct) = "Products") Then
                    Try
                        id_unidad = AutomationTreeNodeOrProduct.Parameters.GetItem("id_unidad").Value
                        'MsgBox(AutomationTreeNodeOrProduct.Name & "  " & id_unidad)
                        id_unidad = AutomationTreeNodeOrProduct.Name
                        Return AutomationTreeNodeOrProduct.Name 'CAMBIAR ESTO
                        Exit Function
                    Catch ex As Exception
                        Try
                            id_unidad = AutomationTreeNodeOrProduct.Name
                            If AutomationTreeNodeOrProduct.Name Like "??00_UNIDAD*" Then
                                id_unidad = AutomationTreeNodeOrProduct.Name
                                Return id_unidad
                                Exit Function
                            End If
                        Catch ex4 As Exception

                        End Try

                    End Try
                    'ElseIf (TypeName(AutomationTreeNodeOrProduct.Parent) = "ProductDocument" Or TypeName(AutomationTreeNodeOrProduct.Parent) = "Product" Or TypeName(AutomationTreeNodeOrProduct.Parent) = "Products") Then
                    '    Try
                    '        id_unidad = AutomationTreeNodeOrProduct.Parameters.GetItem("id_unidad").Value
                    '        'MsgBox(AutomationTreeNodeOrProduct.Name & "  " & id_unidad)
                    '        Return AutomationTreeNodeOrProduct.Parent.Name 'CAMBIAR ESTO
                    '        Exit Function
                    '    Catch ex As Exception
                    '        id_unidad = AutomationTreeNodeOrProduct.Name
                    '    End Try
                End If
                AutomationTreeNodeOrProduct = AutomationTreeNodeOrProduct.Parent

                If ((TypeName(AutomationTreeNodeOrProduct) = "Application") And (Not LeafProductProcessed)) Then
                    '      The specification tree path corresponding to the selection contains at least one product, which the current
                    '      loop as not yet processed. It means that the parent in the specification tree of the feature corresponding
                    '      to the last message box sent is LeafProduct
                    AutomationTreeNodeOrProduct = LeafProduct
                    LeafProductProcessed = True
                End If
            Loop
        Catch ex As Exception
            'Es porque esta abierta una .Part

            Return "Igual que el último"
        End Try

        Return id_unidad

    End Function

End Class
