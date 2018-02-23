<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleUsuario_permiso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleUsuario_permiso))
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblid_usuario = New System.Windows.Forms.Label()
        Me.btnBuscausuario = New System.Windows.Forms.Button()
        Me.cmbusuario = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_usuario = New System.Windows.Forms.Label()
        Me.lblid_permiso = New System.Windows.Forms.Label()
        Me.btnBuscapermiso = New System.Windows.Forms.Button()
        Me.cmbpermiso = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_permiso = New System.Windows.Forms.Label()
        Me.chkhabilitado = New System.Windows.Forms.CheckBox()
        Me.etiquetahabilitado = New System.Windows.Forms.Label()
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
        Me.btnSalir.Location = New System.Drawing.Point(499, 217)
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
        Me.btnGuardar.Location = New System.Drawing.Point(392, 217)
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
        Me.GroupBox1.Size = New System.Drawing.Size(568, 177)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblid_usuario
        '
        Me.lblid_usuario.AutoSize = True
        Me.lblid_usuario.BackColor = System.Drawing.Color.Red
        Me.lblid_usuario.Location = New System.Drawing.Point(370, 48)
        Me.lblid_usuario.Name = "lblid_usuario"
        Me.lblid_usuario.Size = New System.Drawing.Size(13, 13)
        Me.lblid_usuario.TabIndex = 500
        Me.lblid_usuario.Text = "0"
        Me.lblid_usuario.Visible = False
        '
        'btnBuscausuario
        '
        Me.btnBuscausuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscausuario.Image = CType(resources.GetObject("btnBuscausuario.Image"), System.Drawing.Image)
        Me.btnBuscausuario.Location = New System.Drawing.Point(505, 48)
        Me.btnBuscausuario.Name = "btnBuscausuario"
        Me.btnBuscausuario.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscausuario.TabIndex = 60
        Me.btnBuscausuario.UseVisualStyleBackColor = True
        '
        'cmbusuario
        '
        Me.cmbusuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbusuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbusuario.FormattingEnabled = True
        Me.cmbusuario.Location = New System.Drawing.Point(161, 48)
        Me.cmbusuario.Name = "cmbusuario"
        Me.cmbusuario.Size = New System.Drawing.Size(329, 21)
        Me.cmbusuario.TabIndex = 4
        '
        'etiquetaid_usuario
        '
        Me.etiquetaid_usuario.AutoSize = True
        Me.etiquetaid_usuario.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaid_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_usuario.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_usuario.Location = New System.Drawing.Point(28, 48)
        Me.etiquetaid_usuario.Name = "etiquetaid_usuario"
        Me.etiquetaid_usuario.Size = New System.Drawing.Size(50, 15)
        Me.etiquetaid_usuario.TabIndex = 501
        Me.etiquetaid_usuario.Text = "Usuario"
        Me.etiquetaid_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_permiso
        '
        Me.lblid_permiso.AutoSize = True
        Me.lblid_permiso.BackColor = System.Drawing.Color.Red
        Me.lblid_permiso.Location = New System.Drawing.Point(370, 91)
        Me.lblid_permiso.Name = "lblid_permiso"
        Me.lblid_permiso.Size = New System.Drawing.Size(13, 13)
        Me.lblid_permiso.TabIndex = 502
        Me.lblid_permiso.Text = "0"
        Me.lblid_permiso.Visible = False
        '
        'btnBuscapermiso
        '
        Me.btnBuscapermiso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscapermiso.Image = CType(resources.GetObject("btnBuscapermiso.Image"), System.Drawing.Image)
        Me.btnBuscapermiso.Location = New System.Drawing.Point(505, 91)
        Me.btnBuscapermiso.Name = "btnBuscapermiso"
        Me.btnBuscapermiso.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscapermiso.TabIndex = 61
        Me.btnBuscapermiso.UseVisualStyleBackColor = True
        '
        'cmbpermiso
        '
        Me.cmbpermiso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbpermiso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbpermiso.FormattingEnabled = True
        Me.cmbpermiso.Location = New System.Drawing.Point(161, 91)
        Me.cmbpermiso.Name = "cmbpermiso"
        Me.cmbpermiso.Size = New System.Drawing.Size(329, 21)
        Me.cmbpermiso.TabIndex = 5
        '
        'etiquetaid_permiso
        '
        Me.etiquetaid_permiso.AutoSize = True
        Me.etiquetaid_permiso.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaid_permiso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_permiso.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_permiso.Location = New System.Drawing.Point(28, 91)
        Me.etiquetaid_permiso.Name = "etiquetaid_permiso"
        Me.etiquetaid_permiso.Size = New System.Drawing.Size(53, 15)
        Me.etiquetaid_permiso.TabIndex = 503
        Me.etiquetaid_permiso.Text = "Permiso"
        Me.etiquetaid_permiso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkhabilitado
        '
        Me.chkhabilitado.AutoSize = True
        Me.chkhabilitado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkhabilitado.Location = New System.Drawing.Point(161, 134)
        Me.chkhabilitado.Name = "chkhabilitado"
        Me.chkhabilitado.Size = New System.Drawing.Size(88, 21)
        Me.chkhabilitado.TabIndex = 6
        Me.chkhabilitado.Text = "habilitado"
        '
        'etiquetahabilitado
        '
        Me.etiquetahabilitado.AutoSize = True
        Me.etiquetahabilitado.BackColor = System.Drawing.Color.Transparent
        Me.etiquetahabilitado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetahabilitado.ForeColor = System.Drawing.Color.Black
        Me.etiquetahabilitado.Location = New System.Drawing.Point(28, 134)
        Me.etiquetahabilitado.Name = "etiquetahabilitado"
        Me.etiquetahabilitado.Size = New System.Drawing.Size(63, 15)
        Me.etiquetahabilitado.TabIndex = 504
        Me.etiquetahabilitado.Text = "Habilitado"
        Me.etiquetahabilitado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmDetalleUsuario_permiso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 297)
        Me.Controls.Add(Me.lblid_usuario)
        Me.Controls.Add(Me.btnBuscausuario)
        Me.Controls.Add(Me.cmbusuario)
        Me.Controls.Add(Me.etiquetaid_usuario)
        Me.Controls.Add(Me.lblid_permiso)
        Me.Controls.Add(Me.btnBuscapermiso)
        Me.Controls.Add(Me.cmbpermiso)
        Me.Controls.Add(Me.etiquetaid_permiso)
        Me.Controls.Add(Me.chkhabilitado)
        Me.Controls.Add(Me.etiquetahabilitado)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalleUsuario_permiso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleUsuario_permiso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents lblid_usuario As System.Windows.Forms.Label
   Friend WithEvents btnBuscausuario As System.Windows.Forms.Button
   Friend WithEvents cmbusuario As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_usuario As System.Windows.Forms.Label
   Friend WithEvents lblid_permiso As System.Windows.Forms.Label
   Friend WithEvents btnBuscapermiso As System.Windows.Forms.Button
   Friend WithEvents cmbpermiso As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_permiso As System.Windows.Forms.Label
   Protected WithEvents chkhabilitado As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetahabilitado As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

