<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleModificacion_arbol
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleModificacion_arbol))
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtnombre_modificacion_arbol = New System.Windows.Forms.TextBox()
        Me.etiquetanombre_modificacion_arbol = New System.Windows.Forms.Label()
        Me.lblid_usuario = New System.Windows.Forms.Label()
        Me.btnBuscausuario = New System.Windows.Forms.Button()
        Me.cmbusuario = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_usuario = New System.Windows.Forms.Label()
        Me.chkrealizado = New System.Windows.Forms.CheckBox()
        Me.etiquetarealizado = New System.Windows.Forms.Label()
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
        'txtnombre_modificacion_arbol
        '
        Me.txtnombre_modificacion_arbol.BackColor = System.Drawing.Color.White
        Me.txtnombre_modificacion_arbol.Location = New System.Drawing.Point(161, 48)
        Me.txtnombre_modificacion_arbol.MaxLength = 500
        Me.txtnombre_modificacion_arbol.Name = "txtnombre_modificacion_arbol"
        Me.txtnombre_modificacion_arbol.Size = New System.Drawing.Size(385, 20)
        Me.txtnombre_modificacion_arbol.TabIndex = 4
        '
        'etiquetanombre_modificacion_arbol
        '
        Me.etiquetanombre_modificacion_arbol.AutoSize = True
        Me.etiquetanombre_modificacion_arbol.BackColor = System.Drawing.Color.Transparent
        Me.etiquetanombre_modificacion_arbol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanombre_modificacion_arbol.ForeColor = System.Drawing.Color.Black
        Me.etiquetanombre_modificacion_arbol.Location = New System.Drawing.Point(28, 48)
        Me.etiquetanombre_modificacion_arbol.Name = "etiquetanombre_modificacion_arbol"
        Me.etiquetanombre_modificacion_arbol.Size = New System.Drawing.Size(156, 15)
        Me.etiquetanombre_modificacion_arbol.TabIndex = 500
        Me.etiquetanombre_modificacion_arbol.Text = "Nombre modificacion arbol"
        Me.etiquetanombre_modificacion_arbol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_usuario
        '
        Me.lblid_usuario.AutoSize = True
        Me.lblid_usuario.BackColor = System.Drawing.Color.Red
        Me.lblid_usuario.Location = New System.Drawing.Point(370, 91)
        Me.lblid_usuario.Name = "lblid_usuario"
        Me.lblid_usuario.Size = New System.Drawing.Size(13, 13)
        Me.lblid_usuario.TabIndex = 501
        Me.lblid_usuario.Text = "0"
        Me.lblid_usuario.Visible = False
        '
        'btnBuscausuario
        '
        Me.btnBuscausuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscausuario.Image = CType(resources.GetObject("btnBuscausuario.Image"), System.Drawing.Image)
        Me.btnBuscausuario.Location = New System.Drawing.Point(505, 91)
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
        Me.cmbusuario.Location = New System.Drawing.Point(161, 91)
        Me.cmbusuario.Name = "cmbusuario"
        Me.cmbusuario.Size = New System.Drawing.Size(329, 21)
        Me.cmbusuario.TabIndex = 5
        '
        'etiquetaid_usuario
        '
        Me.etiquetaid_usuario.AutoSize = True
        Me.etiquetaid_usuario.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaid_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_usuario.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_usuario.Location = New System.Drawing.Point(28, 91)
        Me.etiquetaid_usuario.Name = "etiquetaid_usuario"
        Me.etiquetaid_usuario.Size = New System.Drawing.Size(50, 15)
        Me.etiquetaid_usuario.TabIndex = 502
        Me.etiquetaid_usuario.Text = "Usuario"
        Me.etiquetaid_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkrealizado
        '
        Me.chkrealizado.AutoSize = True
        Me.chkrealizado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkrealizado.Location = New System.Drawing.Point(161, 134)
        Me.chkrealizado.Name = "chkrealizado"
        Me.chkrealizado.Size = New System.Drawing.Size(85, 21)
        Me.chkrealizado.TabIndex = 6
        Me.chkrealizado.Text = "realizado"
        '
        'etiquetarealizado
        '
        Me.etiquetarealizado.AutoSize = True
        Me.etiquetarealizado.BackColor = System.Drawing.Color.Transparent
        Me.etiquetarealizado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetarealizado.ForeColor = System.Drawing.Color.Black
        Me.etiquetarealizado.Location = New System.Drawing.Point(28, 134)
        Me.etiquetarealizado.Name = "etiquetarealizado"
        Me.etiquetarealizado.Size = New System.Drawing.Size(63, 15)
        Me.etiquetarealizado.TabIndex = 503
        Me.etiquetarealizado.Text = "Realizado"
        Me.etiquetarealizado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmDetalleModificacion_arbol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 297)
        Me.Controls.Add(Me.txtnombre_modificacion_arbol)
        Me.Controls.Add(Me.etiquetanombre_modificacion_arbol)
        Me.Controls.Add(Me.lblid_usuario)
        Me.Controls.Add(Me.btnBuscausuario)
        Me.Controls.Add(Me.cmbusuario)
        Me.Controls.Add(Me.etiquetaid_usuario)
        Me.Controls.Add(Me.chkrealizado)
        Me.Controls.Add(Me.etiquetarealizado)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalleModificacion_arbol"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleModificacion_arbol"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Protected WithEvents txtnombre_modificacion_arbol As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanombre_modificacion_arbol As System.Windows.Forms.Label
   Friend WithEvents lblid_usuario As System.Windows.Forms.Label
   Friend WithEvents btnBuscausuario As System.Windows.Forms.Button
   Friend WithEvents cmbusuario As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_usuario As System.Windows.Forms.Label
   Protected WithEvents chkrealizado As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetarealizado As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

