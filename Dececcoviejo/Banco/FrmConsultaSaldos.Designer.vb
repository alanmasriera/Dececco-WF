<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaSaldos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaSaldos))
        Me.dtpLibrado_L_D = New System.Windows.Forms.DateTimePicker
        Me.btnConsultar = New System.Windows.Forms.Button
        Me.Btnimprime = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.lblTotal = New System.Windows.Forms.Label
        Me.txtTotalConsulta = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'dtpLibrado_L_D
        '
        Me.dtpLibrado_L_D.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpLibrado_L_D.Location = New System.Drawing.Point(90, 45)
        Me.dtpLibrado_L_D.Name = "dtpLibrado_L_D"
        Me.dtpLibrado_L_D.Size = New System.Drawing.Size(99, 20)
        Me.dtpLibrado_L_D.TabIndex = 6
        '
        'btnConsultar
        '
        Me.btnConsultar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.Image = CType(resources.GetObject("btnConsultar.Image"), System.Drawing.Image)
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnConsultar.Location = New System.Drawing.Point(735, 651)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(80, 83)
        Me.btnConsultar.TabIndex = 16
        Me.btnConsultar.Text = "&Consultar"
        Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'Btnimprime
        '
        Me.Btnimprime.BackColor = System.Drawing.Color.Gainsboro
        Me.Btnimprime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnimprime.Image = CType(resources.GetObject("Btnimprime.Image"), System.Drawing.Image)
        Me.Btnimprime.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btnimprime.Location = New System.Drawing.Point(823, 651)
        Me.Btnimprime.Name = "Btnimprime"
        Me.Btnimprime.Size = New System.Drawing.Size(80, 83)
        Me.Btnimprime.TabIndex = 18
        Me.Btnimprime.Text = "Imprimir" & vgNombreFormulario
        Me.Btnimprime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btnimprime.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(936, 651)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(80, 83)
        Me.btnSalir.TabIndex = 17
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotal.Location = New System.Drawing.Point(120, 672)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(219, 21)
        Me.lblTotal.TabIndex = 520
        Me.lblTotal.Text = "TOTAL"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotalConsulta
        '
        Me.txtTotalConsulta.BackColor = System.Drawing.SystemColors.Info
        Me.txtTotalConsulta.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalConsulta.ForeColor = System.Drawing.Color.Green
        Me.txtTotalConsulta.Location = New System.Drawing.Point(120, 695)
        Me.txtTotalConsulta.Name = "txtTotalConsulta"
        Me.txtTotalConsulta.Size = New System.Drawing.Size(219, 39)
        Me.txtTotalConsulta.TabIndex = 519
        Me.txtTotalConsulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(16, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 551
        Me.Label1.Text = "Fecha Hasta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(262, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 552
        Me.Label2.Text = "Saldo Actual"
        '
        'FrmConsultaSaldos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1028, 746)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtTotalConsulta)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.Btnimprime)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.dtpLibrado_L_D)
        Me.Name = "FrmConsultaSaldos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Saldos a Futuro" & vgNombreFormulario
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpLibrado_L_D As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents Btnimprime As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtTotalConsulta As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
