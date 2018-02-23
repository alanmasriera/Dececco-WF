<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleControl
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
       Me.components = New System.ComponentModel.Container
       Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleControl))
       Me.btnSalir = New System.Windows.Forms.Button
       Me.btnGuardar = New System.Windows.Forms.Button
       Me.GroupBox1 = New System.Windows.Forms.GroupBox
       Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
       Me.txtnombre_control = New System.Windows.Forms.TextBox
       Me.etiquetanombre_control = New System.Windows.Forms.Label
       Me.lblindice = New System.Windows.Forms.Label
       Me.btnBuscaice = New System.Windows.Forms.Button
       Me.cmbice = New System.Windows.Forms.ComboBox
       Me.etiquetaindice = New System.Windows.Forms.Label
       Me.SuspendLayout()
       '
       'txtnombre_control
       '
       Me.txtnombre_control.BackColor = System.Drawing.Color.White
       Me.txtnombre_control.Location = New System.Drawing.Point(161, 48)
       Me.txtnombre_control.Size = New System.Drawing.Size(385, 20)
       Me.txtnombre_control.MaxLength = 500
       Me.txtnombre_control.Name = "txtnombre_control"
       Me.txtnombre_control.TabIndex = 4
       '
       'etiquietanombre_control
       '
       Me.etiquetanombre_control.BackColor = System.Drawing.Color.Transparent
       Me.etiquetanombre_control.AutoSize = True
       Me.etiquetanombre_control.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetanombre_control.ForeColor = System.Drawing.Color.Black
       Me.etiquetanombre_control.Location = New System.Drawing.Point(28, 48)
       Me.etiquetanombre_control.Name = "etiquetanombre_control"
       Me.etiquetanombre_control.Size = New System.Drawing.Size(127, 21)
       Me.etiquetanombre_control.TabIndex = 500
       Me.etiquetanombre_control.Text = "Nombre control"
       Me.etiquetanombre_control.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblindice
       '
       Me.lblindice.AutoSize = True
       Me.lblindice.BackColor = System.Drawing.Color.Red
       Me.lblindice.Location = New System.Drawing.Point(370, 91)
       Me.lblindice.Name = "lblindice"
       Me.lblindice.Size = New System.Drawing.Size(13, 13)
       Me.lblindice.TabIndex = 501
       Me.lblindice.Text = "0"
       Me.lblindice.Visible = False
       '
       'btnBuscaice
       '
       Me.btnBuscaice.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscaice.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscaice.Location = New System.Drawing.Point(505, 91)
       Me.btnBuscaice.Name = "btnBuscaice"
       Me.btnBuscaice.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscaice.TabIndex = 60
       Me.btnBuscaice.UseVisualStyleBackColor = True
       '
       'cmbice
       '
       Me.cmbice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbice.FormattingEnabled = True
       Me.cmbice.Location = New System.Drawing.Point(161, 91)
       Me.cmbice.Size = New System.Drawing.Size(329, 21)
       Me.cmbice.Name = "cmbice"
       Me.cmbice.TabIndex = 5
       '
       'etiquietaindice
       '
       Me.etiquetaindice.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaindice.AutoSize = True
       Me.etiquetaindice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaindice.ForeColor = System.Drawing.Color.Black
       Me.etiquetaindice.Location = New System.Drawing.Point(28, 91)
       Me.etiquetaindice.Name = "etiquetaindice"
       Me.etiquetaindice.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaindice.TabIndex = 502
       Me.etiquetaindice.Text = "Ice"
       Me.etiquetaindice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'btnSalir
       '
       Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
       Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.btnSalir.ForeColor = System.Drawing.Color.Black
       Me.btnSalir.Image = CType(Resources.GetObject("btnSalir.Image"), System.Drawing.Image)
       Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
       Me.btnSalir.Location = New System.Drawing.Point(499, 174)
       Me.btnSalir.Name = "btnSalir"
       Me.btnSalir.Size = New System.Drawing.Size(81, 61)
       Me.btnSalir.TabIndex = 51
       Me.btnSalir.Text = "&Salir"
       Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
       Me.btnSalir.UseVisualStyleBackColor = True
       '
       'btnGuardar
       '
       Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnGuardar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.btnGuardar.ForeColor = System.Drawing.Color.Black
       Me.btnGuardar.Image = CType(Resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
       Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
       Me.btnGuardar.Location = New System.Drawing.Point(392,174)
       Me.btnGuardar.Name = "btnGuardar"
       Me.btnGuardar.Size = New System.Drawing.Size(81, 61)
       Me.btnGuardar.TabIndex = 50
       Me.btnGuardar.Text = "&Guardar"
       Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
       Me.btnGuardar.UseVisualStyleBackColor = True
       '
       'GroupBox1
       '
       Me.GroupBox1.Location = New System.Drawing.Point(12, 17)
       Me.GroupBox1.Name = "GroupBox1"
       Me.GroupBox1.Size = New System.Drawing.Size(568, 134)
       Me.GroupBox1.TabIndex = 0
       Me.GroupBox1.TabStop = False
       '
       'frmDetalleControl
       '
       Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
       Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
       Me.ClientSize = New System.Drawing.Size(600, 254)
       Me.Controls.Add(Me.txtnombre_control)
       Me.Controls.Add(Me.etiquetanombre_control)
       Me.Controls.Add(Me.lblindice)
       Me.Controls.Add(Me.btnBuscaice)
       Me.Controls.Add(Me.cmbice)
       Me.Controls.Add(Me.etiquetaindice)
       Me.Controls.Add(Me.btnSalir)
       Me.Controls.Add(Me.btnGuardar)
       Me.Controls.Add(Me.GroupBox1)
       Me.Name = "frmDetalleControl"
       Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
       Me.Text = "frmDetalleControl" & vgNombreFormulario
       Me.ResumeLayout(False)
       Me.PerformLayout()

   End Sub
   Protected WithEvents txtnombre_control As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanombre_control As System.Windows.Forms.Label
   Friend WithEvents lblindice As System.Windows.Forms.Label
   Friend WithEvents btnBuscaice As System.Windows.Forms.Button
   Friend WithEvents cmbice As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaindice As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

