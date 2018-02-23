<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleVoz_tipo_voz
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
       Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleVoz_tipo_voz))
       Me.btnSalir = New System.Windows.Forms.Button
       Me.btnGuardar = New System.Windows.Forms.Button
       Me.GroupBox1 = New System.Windows.Forms.GroupBox
       Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
       Me.lblid_voz = New System.Windows.Forms.Label
       Me.btnBuscavoz = New System.Windows.Forms.Button
       Me.cmbvoz = New System.Windows.Forms.ComboBox
       Me.etiquetaid_voz = New System.Windows.Forms.Label
       Me.lblid_tipo_voz = New System.Windows.Forms.Label
       Me.btnBuscatipo_voz = New System.Windows.Forms.Button
       Me.cmbtipo_voz = New System.Windows.Forms.ComboBox
       Me.etiquetaid_tipo_voz = New System.Windows.Forms.Label
       Me.txtporcentaje_voz = New System.Windows.Forms.TextBox
       Me.etiquetaporcentaje_voz = New System.Windows.Forms.Label
       Me.txtporcentaje_tipo_voz = New System.Windows.Forms.TextBox
       Me.etiquetaporcentaje_tipo_voz = New System.Windows.Forms.Label
       Me.lblindice = New System.Windows.Forms.Label
       Me.btnBuscaice = New System.Windows.Forms.Button
       Me.cmbice = New System.Windows.Forms.ComboBox
       Me.etiquetaindice = New System.Windows.Forms.Label
       Me.lblnro = New System.Windows.Forms.Label
       Me.btnBusca = New System.Windows.Forms.Button
       Me.cmb = New System.Windows.Forms.ComboBox
       Me.etiquetanro = New System.Windows.Forms.Label
       Me.SuspendLayout()
       '
       'lblid_voz
       '
       Me.lblid_voz.AutoSize = True
       Me.lblid_voz.BackColor = System.Drawing.Color.Red
       Me.lblid_voz.Location = New System.Drawing.Point(370, 48)
       Me.lblid_voz.Name = "lblid_voz"
       Me.lblid_voz.Size = New System.Drawing.Size(13, 13)
       Me.lblid_voz.TabIndex = 500
       Me.lblid_voz.Text = "0"
       Me.lblid_voz.Visible = False
       '
       'btnBuscavoz
       '
       Me.btnBuscavoz.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscavoz.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscavoz.Location = New System.Drawing.Point(505, 48)
       Me.btnBuscavoz.Name = "btnBuscavoz"
       Me.btnBuscavoz.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscavoz.TabIndex = 60
       Me.btnBuscavoz.UseVisualStyleBackColor = True
       '
       'cmbvoz
       '
       Me.cmbvoz.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbvoz.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbvoz.FormattingEnabled = True
       Me.cmbvoz.Location = New System.Drawing.Point(161, 48)
       Me.cmbvoz.Size = New System.Drawing.Size(329, 21)
       Me.cmbvoz.Name = "cmbvoz"
       Me.cmbvoz.TabIndex = 4
       '
       'etiquietaid_voz
       '
       Me.etiquetaid_voz.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_voz.AutoSize = True
       Me.etiquetaid_voz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_voz.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_voz.Location = New System.Drawing.Point(28, 48)
       Me.etiquetaid_voz.Name = "etiquetaid_voz"
       Me.etiquetaid_voz.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_voz.TabIndex = 501
       Me.etiquetaid_voz.Text = "Voz"
       Me.etiquetaid_voz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_tipo_voz
       '
       Me.lblid_tipo_voz.AutoSize = True
       Me.lblid_tipo_voz.BackColor = System.Drawing.Color.Red
       Me.lblid_tipo_voz.Location = New System.Drawing.Point(370, 91)
       Me.lblid_tipo_voz.Name = "lblid_tipo_voz"
       Me.lblid_tipo_voz.Size = New System.Drawing.Size(13, 13)
       Me.lblid_tipo_voz.TabIndex = 502
       Me.lblid_tipo_voz.Text = "0"
       Me.lblid_tipo_voz.Visible = False
       '
       'btnBuscatipo_voz
       '
       Me.btnBuscatipo_voz.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscatipo_voz.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscatipo_voz.Location = New System.Drawing.Point(505, 91)
       Me.btnBuscatipo_voz.Name = "btnBuscatipo_voz"
       Me.btnBuscatipo_voz.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscatipo_voz.TabIndex = 61
       Me.btnBuscatipo_voz.UseVisualStyleBackColor = True
       '
       'cmbtipo_voz
       '
       Me.cmbtipo_voz.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbtipo_voz.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbtipo_voz.FormattingEnabled = True
       Me.cmbtipo_voz.Location = New System.Drawing.Point(161, 91)
       Me.cmbtipo_voz.Size = New System.Drawing.Size(329, 21)
       Me.cmbtipo_voz.Name = "cmbtipo_voz"
       Me.cmbtipo_voz.TabIndex = 5
       '
       'etiquietaid_tipo_voz
       '
       Me.etiquetaid_tipo_voz.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_tipo_voz.AutoSize = True
       Me.etiquetaid_tipo_voz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_tipo_voz.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_tipo_voz.Location = New System.Drawing.Point(28, 91)
       Me.etiquetaid_tipo_voz.Name = "etiquetaid_tipo_voz"
       Me.etiquetaid_tipo_voz.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_tipo_voz.TabIndex = 503
       Me.etiquetaid_tipo_voz.Text = "Tipo voz"
       Me.etiquetaid_tipo_voz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtporcentaje_voz
       '
       Me.txtporcentaje_voz.BackColor = System.Drawing.Color.White
       Me.txtporcentaje_voz.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtporcentaje_voz.ForeColor = System.Drawing.Color.Blue
       Me.txtporcentaje_voz.Location = New System.Drawing.Point(161, 134)
       Me.txtporcentaje_voz.MaxLength = 50
       Me.txtporcentaje_voz.Name = "txtporcentaje_voz"
       Me.txtporcentaje_voz.Size = New System.Drawing.Size(222, 31)
       Me.txtporcentaje_voz.TabIndex = 6
       Me.txtporcentaje_voz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietaporcentaje_voz
       '
       Me.etiquetaporcentaje_voz.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaporcentaje_voz.AutoSize = True
       Me.etiquetaporcentaje_voz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaporcentaje_voz.ForeColor = System.Drawing.Color.Black
       Me.etiquetaporcentaje_voz.Location = New System.Drawing.Point(28, 134)
       Me.etiquetaporcentaje_voz.Name = "etiquetaporcentaje_voz"
       Me.etiquetaporcentaje_voz.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaporcentaje_voz.TabIndex = 504
       Me.etiquetaporcentaje_voz.Text = "Porcentaje voz"
       Me.etiquetaporcentaje_voz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtporcentaje_tipo_voz
       '
       Me.txtporcentaje_tipo_voz.BackColor = System.Drawing.Color.White
       Me.txtporcentaje_tipo_voz.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtporcentaje_tipo_voz.ForeColor = System.Drawing.Color.Blue
       Me.txtporcentaje_tipo_voz.Location = New System.Drawing.Point(161, 187)
       Me.txtporcentaje_tipo_voz.MaxLength = 50
       Me.txtporcentaje_tipo_voz.Name = "txtporcentaje_tipo_voz"
       Me.txtporcentaje_tipo_voz.Size = New System.Drawing.Size(222, 31)
       Me.txtporcentaje_tipo_voz.TabIndex = 7
       Me.txtporcentaje_tipo_voz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietaporcentaje_tipo_voz
       '
       Me.etiquetaporcentaje_tipo_voz.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaporcentaje_tipo_voz.AutoSize = True
       Me.etiquetaporcentaje_tipo_voz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaporcentaje_tipo_voz.ForeColor = System.Drawing.Color.Black
       Me.etiquetaporcentaje_tipo_voz.Location = New System.Drawing.Point(28, 187)
       Me.etiquetaporcentaje_tipo_voz.Name = "etiquetaporcentaje_tipo_voz"
       Me.etiquetaporcentaje_tipo_voz.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaporcentaje_tipo_voz.TabIndex = 505
       Me.etiquetaporcentaje_tipo_voz.Text = "Porcentaje tipo voz"
       Me.etiquetaporcentaje_tipo_voz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblindice
       '
       Me.lblindice.AutoSize = True
       Me.lblindice.BackColor = System.Drawing.Color.Red
       Me.lblindice.Location = New System.Drawing.Point(370, 240)
       Me.lblindice.Name = "lblindice"
       Me.lblindice.Size = New System.Drawing.Size(13, 13)
       Me.lblindice.TabIndex = 506
       Me.lblindice.Text = "0"
       Me.lblindice.Visible = False
       '
       'btnBuscaice
       '
       Me.btnBuscaice.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscaice.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscaice.Location = New System.Drawing.Point(505, 240)
       Me.btnBuscaice.Name = "btnBuscaice"
       Me.btnBuscaice.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscaice.TabIndex = 62
       Me.btnBuscaice.UseVisualStyleBackColor = True
       '
       'cmbice
       '
       Me.cmbice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbice.FormattingEnabled = True
       Me.cmbice.Location = New System.Drawing.Point(161, 240)
       Me.cmbice.Size = New System.Drawing.Size(329, 21)
       Me.cmbice.Name = "cmbice"
       Me.cmbice.TabIndex = 8
       '
       'etiquietaindice
       '
       Me.etiquetaindice.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaindice.AutoSize = True
       Me.etiquetaindice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaindice.ForeColor = System.Drawing.Color.Black
       Me.etiquetaindice.Location = New System.Drawing.Point(28, 240)
       Me.etiquetaindice.Name = "etiquetaindice"
       Me.etiquetaindice.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaindice.TabIndex = 507
       Me.etiquetaindice.Text = "Ice"
       Me.etiquetaindice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblnro
       '
       Me.lblnro.AutoSize = True
       Me.lblnro.BackColor = System.Drawing.Color.Red
       Me.lblnro.Location = New System.Drawing.Point(370, 283)
       Me.lblnro.Name = "lblnro"
       Me.lblnro.Size = New System.Drawing.Size(13, 13)
       Me.lblnro.TabIndex = 508
       Me.lblnro.Text = "0"
       Me.lblnro.Visible = False
       '
       'btnBusca
       '
       Me.btnBusca.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBusca.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBusca.Location = New System.Drawing.Point(505, 283)
       Me.btnBusca.Name = "btnBusca"
       Me.btnBusca.Size = New System.Drawing.Size(30, 21)
       Me.btnBusca.TabIndex = 63
       Me.btnBusca.UseVisualStyleBackColor = True
       '
       'cmb
       '
       Me.cmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmb.FormattingEnabled = True
       Me.cmb.Location = New System.Drawing.Point(161, 283)
       Me.cmb.Size = New System.Drawing.Size(329, 21)
       Me.cmb.Name = "cmb"
       Me.cmb.TabIndex = 9
       '
       'etiquietanro
       '
       Me.etiquetanro.BackColor = System.Drawing.Color.Transparent
       Me.etiquetanro.AutoSize = True
       Me.etiquetanro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetanro.ForeColor = System.Drawing.Color.Black
       Me.etiquetanro.Location = New System.Drawing.Point(28, 283)
       Me.etiquetanro.Name = "etiquetanro"
       Me.etiquetanro.Size = New System.Drawing.Size(127, 21)
       Me.etiquetanro.TabIndex = 509
       Me.etiquetanro.Text = ""
       Me.etiquetanro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
       Me.btnSalir.Location = New System.Drawing.Point(499, 366)
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
       Me.btnGuardar.Location = New System.Drawing.Point(392,366)
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
       Me.GroupBox1.Size = New System.Drawing.Size(568, 326)
       Me.GroupBox1.TabIndex = 0
       Me.GroupBox1.TabStop = False
       '
       'frmDetalleVoz_tipo_voz
       '
       Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
       Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
       Me.ClientSize = New System.Drawing.Size(600, 446)
       Me.Controls.Add(Me.lblid_voz)
       Me.Controls.Add(Me.btnBuscavoz)
       Me.Controls.Add(Me.cmbvoz)
       Me.Controls.Add(Me.etiquetaid_voz)
       Me.Controls.Add(Me.lblid_tipo_voz)
       Me.Controls.Add(Me.btnBuscatipo_voz)
       Me.Controls.Add(Me.cmbtipo_voz)
       Me.Controls.Add(Me.etiquetaid_tipo_voz)
       Me.Controls.Add(Me.txtporcentaje_voz)
       Me.Controls.Add(Me.etiquetaporcentaje_voz)
       Me.Controls.Add(Me.txtporcentaje_tipo_voz)
       Me.Controls.Add(Me.etiquetaporcentaje_tipo_voz)
       Me.Controls.Add(Me.lblindice)
       Me.Controls.Add(Me.btnBuscaice)
       Me.Controls.Add(Me.cmbice)
       Me.Controls.Add(Me.etiquetaindice)
       Me.Controls.Add(Me.lblnro)
       Me.Controls.Add(Me.btnBusca)
       Me.Controls.Add(Me.cmb)
       Me.Controls.Add(Me.etiquetanro)
       Me.Controls.Add(Me.btnSalir)
       Me.Controls.Add(Me.btnGuardar)
       Me.Controls.Add(Me.GroupBox1)
       Me.Name = "frmDetalleVoz_tipo_voz"
       Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
       Me.Text = "frmDetalleVoz_tipo_voz" & vgNombreFormulario
       Me.ResumeLayout(False)
       Me.PerformLayout()

   End Sub
   Friend WithEvents lblid_voz As System.Windows.Forms.Label
   Friend WithEvents btnBuscavoz As System.Windows.Forms.Button
   Friend WithEvents cmbvoz As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_voz As System.Windows.Forms.Label
   Friend WithEvents lblid_tipo_voz As System.Windows.Forms.Label
   Friend WithEvents btnBuscatipo_voz As System.Windows.Forms.Button
   Friend WithEvents cmbtipo_voz As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_tipo_voz As System.Windows.Forms.Label
   Protected WithEvents txtporcentaje_voz As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaporcentaje_voz As System.Windows.Forms.Label
   Protected WithEvents txtporcentaje_tipo_voz As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaporcentaje_tipo_voz As System.Windows.Forms.Label
   Friend WithEvents lblindice As System.Windows.Forms.Label
   Friend WithEvents btnBuscaice As System.Windows.Forms.Button
   Friend WithEvents cmbice As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaindice As System.Windows.Forms.Label
   Friend WithEvents lblnro As System.Windows.Forms.Label
   Friend WithEvents btnBusca As System.Windows.Forms.Button
   Friend WithEvents cmb As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetanro As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

