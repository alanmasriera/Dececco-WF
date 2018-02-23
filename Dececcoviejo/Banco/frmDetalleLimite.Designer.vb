<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleLimite
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
       Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleLimite))
       Me.btnSalir = New System.Windows.Forms.Button
       Me.btnGuardar = New System.Windows.Forms.Button
       Me.GroupBox1 = New System.Windows.Forms.GroupBox
       Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
       Me.lblid_banco = New System.Windows.Forms.Label
       Me.btnBuscabanco = New System.Windows.Forms.Button
       Me.cmbbanco = New System.Windows.Forms.ComboBox
       Me.etiquetaid_banco = New System.Windows.Forms.Label
       Me.lblid_cuenta = New System.Windows.Forms.Label
       Me.btnBuscacuenta = New System.Windows.Forms.Button
       Me.cmbcuenta = New System.Windows.Forms.ComboBox
       Me.etiquetaid_cuenta = New System.Windows.Forms.Label
       Me.txtlimite = New System.Windows.Forms.TextBox
       Me.etiquetalimite = New System.Windows.Forms.Label
       Me.SuspendLayout()
       '
       'lblid_banco
       '
       Me.lblid_banco.AutoSize = True
       Me.lblid_banco.BackColor = System.Drawing.Color.Red
       Me.lblid_banco.Location = New System.Drawing.Point(370, 48)
       Me.lblid_banco.Name = "lblid_banco"
       Me.lblid_banco.Size = New System.Drawing.Size(13, 13)
       Me.lblid_banco.TabIndex = 500
       Me.lblid_banco.Text = "0"
       Me.lblid_banco.Visible = False
       '
       'btnBuscabanco
       '
       Me.btnBuscabanco.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscabanco.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscabanco.Location = New System.Drawing.Point(505, 48)
       Me.btnBuscabanco.Name = "btnBuscabanco"
       Me.btnBuscabanco.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscabanco.TabIndex = 30
       Me.btnBuscabanco.UseVisualStyleBackColor = True
       '
       'cmbbanco
       '
       Me.cmbbanco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbbanco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbbanco.FormattingEnabled = True
       Me.cmbbanco.Location = New System.Drawing.Point(161, 48)
       Me.cmbbanco.Name = "cmbbanco"
       Me.cmbbanco.Size = New System.Drawing.Size(329, 21)
       Me.cmbbanco.TabIndex = 4
       '
       'etiquietaid_banco
       '
       Me.etiquetaid_banco.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
       Me.etiquetaid_banco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
       Me.etiquetaid_banco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_banco.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_banco.Location = New System.Drawing.Point(28, 48)
       Me.etiquetaid_banco.Name = "etiquetaid_banco"
       Me.etiquetaid_banco.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_banco.TabIndex = 501
       Me.etiquetaid_banco.Text = "Banco"
       Me.etiquetaid_banco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_cuenta
       '
       Me.lblid_cuenta.AutoSize = True
       Me.lblid_cuenta.BackColor = System.Drawing.Color.Red
       Me.lblid_cuenta.Location = New System.Drawing.Point(370, 91)
       Me.lblid_cuenta.Name = "lblid_cuenta"
       Me.lblid_cuenta.Size = New System.Drawing.Size(13, 13)
       Me.lblid_cuenta.TabIndex = 502
       Me.lblid_cuenta.Text = "0"
       Me.lblid_cuenta.Visible = False
       '
       'btnBuscacuenta
       '
       Me.btnBuscacuenta.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscacuenta.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscacuenta.Location = New System.Drawing.Point(505, 91)
       Me.btnBuscacuenta.Name = "btnBuscacuenta"
       Me.btnBuscacuenta.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscacuenta.TabIndex = 31
       Me.btnBuscacuenta.UseVisualStyleBackColor = True
       '
       'cmbcuenta
       '
       Me.cmbcuenta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbcuenta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbcuenta.FormattingEnabled = True
       Me.cmbcuenta.Location = New System.Drawing.Point(161, 91)
       Me.cmbcuenta.Name = "cmbcuenta"
       Me.cmbcuenta.Size = New System.Drawing.Size(329, 21)
       Me.cmbcuenta.TabIndex = 5
       '
       'etiquietaid_cuenta
       '
       Me.etiquetaid_cuenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
       Me.etiquetaid_cuenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
       Me.etiquetaid_cuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_cuenta.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_cuenta.Location = New System.Drawing.Point(28, 91)
       Me.etiquetaid_cuenta.Name = "etiquetaid_cuenta"
       Me.etiquetaid_cuenta.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_cuenta.TabIndex = 503
       Me.etiquetaid_cuenta.Text = "Cuenta"
       Me.etiquetaid_cuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtlimite
       '
       Me.txtlimite.BackColor = System.Drawing.Color.White
       Me.txtlimite.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtlimite.ForeColor = System.Drawing.Color.Blue
       Me.txtlimite.Location = New System.Drawing.Point(161, 134)
       Me.txtlimite.MaxLength = 50
       Me.txtlimite.Name = "txtlimite"
       Me.txtlimite.Size = New System.Drawing.Size(222, 31)
       Me.txtlimite.TabIndex = 6
       Me.txtlimite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietalimite
       '
       Me.etiquetalimite.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
       Me.etiquetalimite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
       Me.etiquetalimite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetalimite.ForeColor = System.Drawing.Color.Black
       Me.etiquetalimite.Location = New System.Drawing.Point(28, 134)
       Me.etiquetalimite.Name = "etiquetalimite"
       Me.etiquetalimite.Size = New System.Drawing.Size(127, 21)
       Me.etiquetalimite.TabIndex = 504
       Me.etiquetalimite.Text = "Limite"
       Me.etiquetalimite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'btnSalir
       '
       Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
       Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.btnSalir.ForeColor = System.Drawing.Color.Black
       Me.btnSalir.Image = CType(Resources.GetObject("btnSalir.Image"), System.Drawing.Image)
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
       Me.btnGuardar.Image = CType(Resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
       Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
       Me.btnGuardar.Location = New System.Drawing.Point(392,227)
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
       Me.GroupBox1.Size = New System.Drawing.Size(568, 187)
       Me.GroupBox1.TabIndex = 0
       Me.GroupBox1.TabStop = False
       '
       'frmDetalleLimite
       '
       Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
       Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
       Me.ClientSize = New System.Drawing.Size(600, 307)
       Me.Controls.Add(Me.lblid_banco)
       Me.Controls.Add(Me.btnBuscabanco)
       Me.Controls.Add(Me.cmbbanco)
       Me.Controls.Add(Me.etiquetaid_banco)
       Me.Controls.Add(Me.lblid_cuenta)
       Me.Controls.Add(Me.btnBuscacuenta)
       Me.Controls.Add(Me.cmbcuenta)
       Me.Controls.Add(Me.etiquetaid_cuenta)
       Me.Controls.Add(Me.txtlimite)
       Me.Controls.Add(Me.etiquetalimite)
       Me.Controls.Add(Me.btnSalir)
       Me.Controls.Add(Me.btnGuardar)
       Me.Controls.Add(Me.GroupBox1)
       Me.Name = "frmDetalleLimite"
       Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleLimite" & vgNombreFormulario
       Me.ResumeLayout(False)
       Me.PerformLayout()

   End Sub
   Friend WithEvents lblid_banco As System.Windows.Forms.Label
   Friend WithEvents btnBuscabanco As System.Windows.Forms.Button
   Friend WithEvents cmbbanco As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_banco As System.Windows.Forms.Label
   Friend WithEvents lblid_cuenta As System.Windows.Forms.Label
   Friend WithEvents btnBuscacuenta As System.Windows.Forms.Button
   Friend WithEvents cmbcuenta As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_cuenta As System.Windows.Forms.Label
   Protected WithEvents txtlimite As System.Windows.Forms.TextBox
   Friend WithEvents etiquetalimite As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

