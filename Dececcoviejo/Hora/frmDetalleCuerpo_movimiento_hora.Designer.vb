<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleCuerpo_movimiento_hora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleCuerpo_movimiento_hora))
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblid_actividad_proyecto = New System.Windows.Forms.Label()
        Me.btnBuscaActividad_proyecto = New System.Windows.Forms.Button()
        Me.cmbActividad_proyecto = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_obra = New System.Windows.Forms.Label()
        Me.dtpentrada = New System.Windows.Forms.DateTimePicker()
        Me.etiquetaentrada = New System.Windows.Forms.Label()
        Me.dtpsalida = New System.Windows.Forms.DateTimePicker()
        Me.etiquetasalida = New System.Windows.Forms.Label()
        Me.lblid_movimiento_hora = New System.Windows.Forms.Label()
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
        Me.btnSalir.Location = New System.Drawing.Point(499, 227)
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
        Me.btnGuardar.Location = New System.Drawing.Point(392, 227)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(78, 69)
        Me.btnGuardar.TabIndex = 20
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 185)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblid_actividad_proyecto
        '
        Me.lblid_actividad_proyecto.AutoSize = True
        Me.lblid_actividad_proyecto.BackColor = System.Drawing.Color.Red
        Me.lblid_actividad_proyecto.Location = New System.Drawing.Point(370, 48)
        Me.lblid_actividad_proyecto.Name = "lblid_actividad_proyecto"
        Me.lblid_actividad_proyecto.Size = New System.Drawing.Size(13, 13)
        Me.lblid_actividad_proyecto.TabIndex = 500
        Me.lblid_actividad_proyecto.Text = "0"
        Me.lblid_actividad_proyecto.Visible = False
        '
        'btnBuscaActividad_proyecto
        '
        Me.btnBuscaActividad_proyecto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaActividad_proyecto.Image = CType(resources.GetObject("btnBuscaActividad_proyecto.Image"), System.Drawing.Image)
        Me.btnBuscaActividad_proyecto.Location = New System.Drawing.Point(505, 48)
        Me.btnBuscaActividad_proyecto.Name = "btnBuscaActividad_proyecto"
        Me.btnBuscaActividad_proyecto.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscaActividad_proyecto.TabIndex = 30
        Me.btnBuscaActividad_proyecto.UseVisualStyleBackColor = True
        '
        'cmbActividad_proyecto
        '
        Me.cmbActividad_proyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbActividad_proyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbActividad_proyecto.FormattingEnabled = True
        Me.cmbActividad_proyecto.Location = New System.Drawing.Point(161, 48)
        Me.cmbActividad_proyecto.Name = "cmbActividad_proyecto"
        Me.cmbActividad_proyecto.Size = New System.Drawing.Size(329, 21)
        Me.cmbActividad_proyecto.TabIndex = 4
        '
        'etiquetaid_obra
        '
        Me.etiquetaid_obra.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_obra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_obra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_obra.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_obra.Location = New System.Drawing.Point(28, 48)
        Me.etiquetaid_obra.Name = "etiquetaid_obra"
        Me.etiquetaid_obra.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_obra.TabIndex = 501
        Me.etiquetaid_obra.Text = "Actividad"
        Me.etiquetaid_obra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpentrada
        '
        Me.dtpentrada.CustomFormat = "HH:mm"
        Me.dtpentrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpentrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpentrada.Location = New System.Drawing.Point(161, 91)
        Me.dtpentrada.Name = "dtpentrada"
        Me.dtpentrada.Size = New System.Drawing.Size(115, 31)
        Me.dtpentrada.TabIndex = 5
        '
        'etiquetaentrada
        '
        Me.etiquetaentrada.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaentrada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaentrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaentrada.ForeColor = System.Drawing.Color.Black
        Me.etiquetaentrada.Location = New System.Drawing.Point(28, 91)
        Me.etiquetaentrada.Name = "etiquetaentrada"
        Me.etiquetaentrada.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaentrada.TabIndex = 502
        Me.etiquetaentrada.Text = "Entrada"
        Me.etiquetaentrada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpsalida
        '
        Me.dtpsalida.CustomFormat = "HH:mm"
        Me.dtpsalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpsalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpsalida.Location = New System.Drawing.Point(161, 134)
        Me.dtpsalida.Name = "dtpsalida"
        Me.dtpsalida.Size = New System.Drawing.Size(115, 31)
        Me.dtpsalida.TabIndex = 6
        '
        'etiquetasalida
        '
        Me.etiquetasalida.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetasalida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetasalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetasalida.ForeColor = System.Drawing.Color.Black
        Me.etiquetasalida.Location = New System.Drawing.Point(28, 134)
        Me.etiquetasalida.Name = "etiquetasalida"
        Me.etiquetasalida.Size = New System.Drawing.Size(127, 21)
        Me.etiquetasalida.TabIndex = 503
        Me.etiquetasalida.Text = "Salida"
        Me.etiquetasalida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_movimiento_hora
        '
        Me.lblid_movimiento_hora.AutoSize = True
        Me.lblid_movimiento_hora.BackColor = System.Drawing.Color.Red
        Me.lblid_movimiento_hora.Location = New System.Drawing.Point(370, 177)
        Me.lblid_movimiento_hora.Name = "lblid_movimiento_hora"
        Me.lblid_movimiento_hora.Size = New System.Drawing.Size(13, 13)
        Me.lblid_movimiento_hora.TabIndex = 504
        Me.lblid_movimiento_hora.Text = "0"
        Me.lblid_movimiento_hora.Visible = False
        '
        'frmDetalleCuerpo_movimiento_hora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 314)
        Me.Controls.Add(Me.lblid_actividad_proyecto)
        Me.Controls.Add(Me.btnBuscaActividad_proyecto)
        Me.Controls.Add(Me.cmbActividad_proyecto)
        Me.Controls.Add(Me.etiquetaid_obra)
        Me.Controls.Add(Me.dtpentrada)
        Me.Controls.Add(Me.etiquetaentrada)
        Me.Controls.Add(Me.dtpsalida)
        Me.Controls.Add(Me.etiquetasalida)
        Me.Controls.Add(Me.lblid_movimiento_hora)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalleCuerpo_movimiento_hora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleCuerpo_movimiento_hora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblid_actividad_proyecto As System.Windows.Forms.Label
    Friend WithEvents btnBuscaActividad_proyecto As System.Windows.Forms.Button
    Friend WithEvents cmbActividad_proyecto As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_obra As System.Windows.Forms.Label
   Protected WithEvents dtpentrada As System.Windows.Forms.DateTimePicker
   Friend WithEvents etiquetaentrada As System.Windows.Forms.Label
   Protected WithEvents dtpsalida As System.Windows.Forms.DateTimePicker
   Friend WithEvents etiquetasalida As System.Windows.Forms.Label
    Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
    Friend WithEvents lblid_movimiento_hora As System.Windows.Forms.Label
End Class

