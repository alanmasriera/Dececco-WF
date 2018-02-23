<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleCuerpo_presupuesto
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleCuerpo_presupuesto))
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblid_presupuesto = New System.Windows.Forms.Label()
        Me.txtitem = New System.Windows.Forms.TextBox()
        Me.etiquetaitem = New System.Windows.Forms.Label()
        Me.lblid_usuario = New System.Windows.Forms.Label()
        Me.txtimporte = New System.Windows.Forms.TextBox()
        Me.etiquetaimporte = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(499, 270)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(81, 69)
        Me.btnSalir.TabIndex = 21
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(392, 270)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(78, 69)
        Me.btnGuardar.TabIndex = 20
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 222)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblid_presupuesto
        '
        Me.lblid_presupuesto.AutoSize = True
        Me.lblid_presupuesto.BackColor = System.Drawing.Color.Red
        Me.lblid_presupuesto.Location = New System.Drawing.Point(379, 9)
        Me.lblid_presupuesto.Name = "lblid_presupuesto"
        Me.lblid_presupuesto.Size = New System.Drawing.Size(13, 13)
        Me.lblid_presupuesto.TabIndex = 500
        Me.lblid_presupuesto.Text = "0"
        Me.lblid_presupuesto.Visible = False
        '
        'txtitem
        '
        Me.txtitem.BackColor = System.Drawing.Color.White
        Me.txtitem.Location = New System.Drawing.Point(161, 41)
        Me.txtitem.MaxLength = 5000
        Me.txtitem.Multiline = True
        Me.txtitem.Name = "txtitem"
        Me.txtitem.Size = New System.Drawing.Size(385, 113)
        Me.txtitem.TabIndex = 5
        '
        'etiquetaitem
        '
        Me.etiquetaitem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaitem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaitem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaitem.ForeColor = System.Drawing.Color.Black
        Me.etiquetaitem.Location = New System.Drawing.Point(28, 41)
        Me.etiquetaitem.Name = "etiquetaitem"
        Me.etiquetaitem.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaitem.TabIndex = 502
        Me.etiquetaitem.Text = "Item"
        Me.etiquetaitem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_usuario
        '
        Me.lblid_usuario.AutoSize = True
        Me.lblid_usuario.BackColor = System.Drawing.Color.Red
        Me.lblid_usuario.Location = New System.Drawing.Point(408, 9)
        Me.lblid_usuario.Name = "lblid_usuario"
        Me.lblid_usuario.Size = New System.Drawing.Size(13, 13)
        Me.lblid_usuario.TabIndex = 503
        Me.lblid_usuario.Text = "0"
        Me.lblid_usuario.Visible = False
        '
        'txtimporte
        '
        Me.txtimporte.BackColor = System.Drawing.Color.White
        Me.txtimporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtimporte.ForeColor = System.Drawing.Color.Blue
        Me.txtimporte.Location = New System.Drawing.Point(161, 177)
        Me.txtimporte.MaxLength = 50
        Me.txtimporte.Name = "txtimporte"
        Me.txtimporte.Size = New System.Drawing.Size(222, 31)
        Me.txtimporte.TabIndex = 7
        Me.txtimporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetaimporte
        '
        Me.etiquetaimporte.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaimporte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaimporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaimporte.ForeColor = System.Drawing.Color.Black
        Me.etiquetaimporte.Location = New System.Drawing.Point(28, 177)
        Me.etiquetaimporte.Name = "etiquetaimporte"
        Me.etiquetaimporte.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaimporte.TabIndex = 505
        Me.etiquetaimporte.Text = "Importe"
        Me.etiquetaimporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmDetalleCuerpo_presupuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 350)
        Me.Controls.Add(Me.lblid_presupuesto)
        Me.Controls.Add(Me.txtitem)
        Me.Controls.Add(Me.etiquetaitem)
        Me.Controls.Add(Me.lblid_usuario)
        Me.Controls.Add(Me.txtimporte)
        Me.Controls.Add(Me.etiquetaimporte)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalleCuerpo_presupuesto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleCuerpo_presupuesto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents lblid_presupuesto As System.Windows.Forms.Label
    Protected WithEvents txtitem As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaitem As System.Windows.Forms.Label
   Friend WithEvents lblid_usuario As System.Windows.Forms.Label
    Protected WithEvents txtimporte As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaimporte As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

