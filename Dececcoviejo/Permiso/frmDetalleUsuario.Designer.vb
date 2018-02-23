<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleUsuario))
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtnombre_usuario = New System.Windows.Forms.TextBox()
        Me.etiquetanombre_usuario = New System.Windows.Forms.Label()
        Me.txtpassword_usuario = New System.Windows.Forms.TextBox()
        Me.etiquetapassword_usuario = New System.Windows.Forms.Label()
        Me.lblid_grupo_usuario = New System.Windows.Forms.Label()
        Me.btnBuscagrupo_usuario = New System.Windows.Forms.Button()
        Me.cmbgrupo_usuario = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_grupo_usuario = New System.Windows.Forms.Label()
        Me.txtlegajo = New System.Windows.Forms.TextBox()
        Me.etiquetalegajo = New System.Windows.Forms.Label()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.etiquetaapellido = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.etiquetanombre = New System.Windows.Forms.Label()
        Me.dtpsession_activa = New System.Windows.Forms.DateTimePicker()
        Me.etiquetasession_activa = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(499, 321)
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
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(409, 321)
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
        Me.GroupBox1.Size = New System.Drawing.Size(568, 286)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtnombre_usuario
        '
        Me.txtnombre_usuario.BackColor = System.Drawing.Color.White
        Me.txtnombre_usuario.Location = New System.Drawing.Point(161, 48)
        Me.txtnombre_usuario.MaxLength = 50
        Me.txtnombre_usuario.Name = "txtnombre_usuario"
        Me.txtnombre_usuario.Size = New System.Drawing.Size(385, 20)
        Me.txtnombre_usuario.TabIndex = 4
        '
        'etiquetanombre_usuario
        '
        Me.etiquetanombre_usuario.AutoSize = True
        Me.etiquetanombre_usuario.BackColor = System.Drawing.Color.Transparent
        Me.etiquetanombre_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanombre_usuario.ForeColor = System.Drawing.Color.Black
        Me.etiquetanombre_usuario.Location = New System.Drawing.Point(28, 48)
        Me.etiquetanombre_usuario.Name = "etiquetanombre_usuario"
        Me.etiquetanombre_usuario.Size = New System.Drawing.Size(96, 15)
        Me.etiquetanombre_usuario.TabIndex = 500
        Me.etiquetanombre_usuario.Text = "Nombre usuario"
        Me.etiquetanombre_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtpassword_usuario
        '
        Me.txtpassword_usuario.BackColor = System.Drawing.Color.White
        Me.txtpassword_usuario.Location = New System.Drawing.Point(161, 91)
        Me.txtpassword_usuario.MaxLength = 50
        Me.txtpassword_usuario.Name = "txtpassword_usuario"
        Me.txtpassword_usuario.Size = New System.Drawing.Size(385, 20)
        Me.txtpassword_usuario.TabIndex = 5
        '
        'etiquetapassword_usuario
        '
        Me.etiquetapassword_usuario.AutoSize = True
        Me.etiquetapassword_usuario.BackColor = System.Drawing.Color.Transparent
        Me.etiquetapassword_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetapassword_usuario.ForeColor = System.Drawing.Color.Black
        Me.etiquetapassword_usuario.Location = New System.Drawing.Point(28, 91)
        Me.etiquetapassword_usuario.Name = "etiquetapassword_usuario"
        Me.etiquetapassword_usuario.Size = New System.Drawing.Size(105, 15)
        Me.etiquetapassword_usuario.TabIndex = 501
        Me.etiquetapassword_usuario.Text = "Password usuario"
        Me.etiquetapassword_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_grupo_usuario
        '
        Me.lblid_grupo_usuario.AutoSize = True
        Me.lblid_grupo_usuario.BackColor = System.Drawing.Color.Red
        Me.lblid_grupo_usuario.Location = New System.Drawing.Point(370, 134)
        Me.lblid_grupo_usuario.Name = "lblid_grupo_usuario"
        Me.lblid_grupo_usuario.Size = New System.Drawing.Size(13, 13)
        Me.lblid_grupo_usuario.TabIndex = 502
        Me.lblid_grupo_usuario.Text = "0"
        Me.lblid_grupo_usuario.Visible = False
        '
        'btnBuscagrupo_usuario
        '
        Me.btnBuscagrupo_usuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscagrupo_usuario.Image = CType(resources.GetObject("btnBuscagrupo_usuario.Image"), System.Drawing.Image)
        Me.btnBuscagrupo_usuario.Location = New System.Drawing.Point(505, 134)
        Me.btnBuscagrupo_usuario.Name = "btnBuscagrupo_usuario"
        Me.btnBuscagrupo_usuario.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscagrupo_usuario.TabIndex = 60
        Me.btnBuscagrupo_usuario.UseVisualStyleBackColor = True
        '
        'cmbgrupo_usuario
        '
        Me.cmbgrupo_usuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbgrupo_usuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbgrupo_usuario.FormattingEnabled = True
        Me.cmbgrupo_usuario.Location = New System.Drawing.Point(161, 134)
        Me.cmbgrupo_usuario.Name = "cmbgrupo_usuario"
        Me.cmbgrupo_usuario.Size = New System.Drawing.Size(329, 21)
        Me.cmbgrupo_usuario.TabIndex = 6
        '
        'etiquetaid_grupo_usuario
        '
        Me.etiquetaid_grupo_usuario.AutoSize = True
        Me.etiquetaid_grupo_usuario.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaid_grupo_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_grupo_usuario.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_grupo_usuario.Location = New System.Drawing.Point(28, 134)
        Me.etiquetaid_grupo_usuario.Name = "etiquetaid_grupo_usuario"
        Me.etiquetaid_grupo_usuario.Size = New System.Drawing.Size(85, 15)
        Me.etiquetaid_grupo_usuario.TabIndex = 503
        Me.etiquetaid_grupo_usuario.Text = "Grupo usuario"
        Me.etiquetaid_grupo_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtlegajo
        '
        Me.txtlegajo.BackColor = System.Drawing.Color.White
        Me.txtlegajo.Location = New System.Drawing.Point(161, 177)
        Me.txtlegajo.MaxLength = 50
        Me.txtlegajo.Name = "txtlegajo"
        Me.txtlegajo.Size = New System.Drawing.Size(385, 20)
        Me.txtlegajo.TabIndex = 7
        '
        'etiquetalegajo
        '
        Me.etiquetalegajo.AutoSize = True
        Me.etiquetalegajo.BackColor = System.Drawing.Color.Transparent
        Me.etiquetalegajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetalegajo.ForeColor = System.Drawing.Color.Black
        Me.etiquetalegajo.Location = New System.Drawing.Point(28, 177)
        Me.etiquetalegajo.Name = "etiquetalegajo"
        Me.etiquetalegajo.Size = New System.Drawing.Size(45, 15)
        Me.etiquetalegajo.TabIndex = 504
        Me.etiquetalegajo.Text = "Legajo"
        Me.etiquetalegajo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtapellido
        '
        Me.txtapellido.BackColor = System.Drawing.Color.White
        Me.txtapellido.Location = New System.Drawing.Point(161, 220)
        Me.txtapellido.MaxLength = 50
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(385, 20)
        Me.txtapellido.TabIndex = 8
        '
        'etiquetaapellido
        '
        Me.etiquetaapellido.AutoSize = True
        Me.etiquetaapellido.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaapellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaapellido.ForeColor = System.Drawing.Color.Black
        Me.etiquetaapellido.Location = New System.Drawing.Point(28, 220)
        Me.etiquetaapellido.Name = "etiquetaapellido"
        Me.etiquetaapellido.Size = New System.Drawing.Size(51, 15)
        Me.etiquetaapellido.TabIndex = 505
        Me.etiquetaapellido.Text = "Apellido"
        Me.etiquetaapellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtnombre
        '
        Me.txtnombre.BackColor = System.Drawing.Color.White
        Me.txtnombre.Location = New System.Drawing.Point(161, 263)
        Me.txtnombre.MaxLength = 50
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(385, 20)
        Me.txtnombre.TabIndex = 9
        '
        'etiquetanombre
        '
        Me.etiquetanombre.AutoSize = True
        Me.etiquetanombre.BackColor = System.Drawing.Color.Transparent
        Me.etiquetanombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanombre.ForeColor = System.Drawing.Color.Black
        Me.etiquetanombre.Location = New System.Drawing.Point(28, 263)
        Me.etiquetanombre.Name = "etiquetanombre"
        Me.etiquetanombre.Size = New System.Drawing.Size(52, 15)
        Me.etiquetanombre.TabIndex = 506
        Me.etiquetanombre.Text = "Nombre"
        Me.etiquetanombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpsession_activa
        '
        Me.dtpsession_activa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpsession_activa.Location = New System.Drawing.Point(161, 306)
        Me.dtpsession_activa.Name = "dtpsession_activa"
        Me.dtpsession_activa.Size = New System.Drawing.Size(93, 20)
        Me.dtpsession_activa.TabIndex = 10
        Me.dtpsession_activa.Visible = False
        '
        'etiquetasession_activa
        '
        Me.etiquetasession_activa.AutoSize = True
        Me.etiquetasession_activa.BackColor = System.Drawing.Color.Transparent
        Me.etiquetasession_activa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetasession_activa.ForeColor = System.Drawing.Color.Black
        Me.etiquetasession_activa.Location = New System.Drawing.Point(28, 306)
        Me.etiquetasession_activa.Name = "etiquetasession_activa"
        Me.etiquetasession_activa.Size = New System.Drawing.Size(85, 15)
        Me.etiquetasession_activa.TabIndex = 507
        Me.etiquetasession_activa.Text = "Session activa"
        Me.etiquetasession_activa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.etiquetasession_activa.Visible = False
        '
        'frmDetalleUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 396)
        Me.Controls.Add(Me.txtnombre_usuario)
        Me.Controls.Add(Me.etiquetanombre_usuario)
        Me.Controls.Add(Me.txtpassword_usuario)
        Me.Controls.Add(Me.etiquetapassword_usuario)
        Me.Controls.Add(Me.lblid_grupo_usuario)
        Me.Controls.Add(Me.btnBuscagrupo_usuario)
        Me.Controls.Add(Me.cmbgrupo_usuario)
        Me.Controls.Add(Me.etiquetaid_grupo_usuario)
        Me.Controls.Add(Me.txtlegajo)
        Me.Controls.Add(Me.etiquetalegajo)
        Me.Controls.Add(Me.txtapellido)
        Me.Controls.Add(Me.etiquetaapellido)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.etiquetanombre)
        Me.Controls.Add(Me.dtpsession_activa)
        Me.Controls.Add(Me.etiquetasession_activa)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalleUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleUsuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Protected WithEvents txtnombre_usuario As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanombre_usuario As System.Windows.Forms.Label
   Protected WithEvents txtpassword_usuario As System.Windows.Forms.TextBox
   Friend WithEvents etiquetapassword_usuario As System.Windows.Forms.Label
   Friend WithEvents lblid_grupo_usuario As System.Windows.Forms.Label
   Friend WithEvents btnBuscagrupo_usuario As System.Windows.Forms.Button
   Friend WithEvents cmbgrupo_usuario As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_grupo_usuario As System.Windows.Forms.Label
   Protected WithEvents txtlegajo As System.Windows.Forms.TextBox
   Friend WithEvents etiquetalegajo As System.Windows.Forms.Label
   Protected WithEvents txtapellido As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaapellido As System.Windows.Forms.Label
   Protected WithEvents txtnombre As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanombre As System.Windows.Forms.Label
   Protected WithEvents dtpsession_activa As System.Windows.Forms.DateTimePicker
   Friend WithEvents etiquetasession_activa As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

