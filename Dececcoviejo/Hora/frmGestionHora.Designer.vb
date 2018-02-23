<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionHora
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestionHora))
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnMovimiento_hora = New System.Windows.Forms.Button
        Me.btnObra = New System.Windows.Forms.Button
        Me.btnEmpleado = New System.Windows.Forms.Button
        Me.btnReporte = New System.Windows.Forms.Button
        Me.btnConsulta = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(697, 355)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(63, 55)
        Me.btnSalir.TabIndex = 16
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnMovimiento_hora
        '
        Me.btnMovimiento_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMovimiento_hora.Image = CType(resources.GetObject("btnMovimiento_hora.Image"), System.Drawing.Image)
        Me.btnMovimiento_hora.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMovimiento_hora.Location = New System.Drawing.Point(465, 39)
        Me.btnMovimiento_hora.Name = "btnMovimiento_hora"
        Me.btnMovimiento_hora.Size = New System.Drawing.Size(164, 166)
        Me.btnMovimiento_hora.TabIndex = 13
        Me.btnMovimiento_hora.Text = "Gestion de Horas"
        Me.btnMovimiento_hora.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMovimiento_hora.UseVisualStyleBackColor = True
        '
        'btnObra
        '
        Me.btnObra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnObra.Image = CType(resources.GetObject("btnObra.Image"), System.Drawing.Image)
        Me.btnObra.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnObra.Location = New System.Drawing.Point(266, 39)
        Me.btnObra.Name = "btnObra"
        Me.btnObra.Size = New System.Drawing.Size(164, 166)
        Me.btnObra.TabIndex = 12
        Me.btnObra.Text = "Gestion de Obras"
        Me.btnObra.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnObra.UseVisualStyleBackColor = True
        '
        'btnEmpleado
        '
        Me.btnEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpleado.Image = CType(resources.GetObject("btnEmpleado.Image"), System.Drawing.Image)
        Me.btnEmpleado.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEmpleado.Location = New System.Drawing.Point(64, 39)
        Me.btnEmpleado.Name = "btnEmpleado"
        Me.btnEmpleado.Size = New System.Drawing.Size(164, 166)
        Me.btnEmpleado.TabIndex = 11
        Me.btnEmpleado.Text = "Datos Personales"
        Me.btnEmpleado.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEmpleado.UseVisualStyleBackColor = True
        '
        'btnReporte
        '
        Me.btnReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporte.Image = CType(resources.GetObject("btnReporte.Image"), System.Drawing.Image)
        Me.btnReporte.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnReporte.Location = New System.Drawing.Point(266, 237)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(164, 166)
        Me.btnReporte.TabIndex = 10
        Me.btnReporte.Text = "Reportes"
        Me.btnReporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'btnConsulta
        '
        Me.btnConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsulta.Image = CType(resources.GetObject("btnConsulta.Image"), System.Drawing.Image)
        Me.btnConsulta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnConsulta.Location = New System.Drawing.Point(64, 237)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(164, 166)
        Me.btnConsulta.TabIndex = 22
        Me.btnConsulta.Text = "Consultas"
        Me.btnConsulta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnConsulta.UseVisualStyleBackColor = True
        Me.btnConsulta.Visible = False
        '
        'frmGestionHora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(802, 458)
        Me.Controls.Add(Me.btnConsulta)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnMovimiento_hora)
        Me.Controls.Add(Me.btnObra)
        Me.Controls.Add(Me.btnEmpleado)
        Me.Controls.Add(Me.btnReporte)
        Me.Name = "frmGestionHora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmGestionHora"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnMovimiento_hora As System.Windows.Forms.Button
    Friend WithEvents btnObra As System.Windows.Forms.Button
    Friend WithEvents btnEmpleado As System.Windows.Forms.Button
    Friend WithEvents btnReporte As System.Windows.Forms.Button
    Friend WithEvents btnConsulta As System.Windows.Forms.Button
End Class
