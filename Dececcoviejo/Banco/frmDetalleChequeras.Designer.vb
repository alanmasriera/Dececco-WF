<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleChequeras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleChequeras))
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtnumero_cheque = New System.Windows.Forms.TextBox
        Me.etiquetanumero_cheque = New System.Windows.Forms.Label
        Me.chktipo_cheque = New System.Windows.Forms.CheckBox
        Me.etiquetatipo_cheque = New System.Windows.Forms.Label
        Me.lblid_banco = New System.Windows.Forms.Label
        Me.btnBuscabanco = New System.Windows.Forms.Button
        Me.cmbbanco = New System.Windows.Forms.ComboBox
        Me.etiquetaid_banco = New System.Windows.Forms.Label
        Me.lblid_cuenta = New System.Windows.Forms.Label
        Me.btnBuscacuenta = New System.Windows.Forms.Button
        Me.cmbcuenta = New System.Windows.Forms.ComboBox
        Me.etiquetaid_cuenta = New System.Windows.Forms.Label
        Me.txtinicio = New System.Windows.Forms.TextBox
        Me.etiquetainicio = New System.Windows.Forms.Label
        Me.txtfin = New System.Windows.Forms.TextBox
        Me.etiquetafin = New System.Windows.Forms.Label
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
        Me.btnSalir.Location = New System.Drawing.Point(499, 366)
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
        Me.btnGuardar.Location = New System.Drawing.Point(392, 366)
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
        Me.GroupBox1.Size = New System.Drawing.Size(568, 326)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtnumero_cheque
        '
        Me.txtnumero_cheque.BackColor = System.Drawing.Color.White
        Me.txtnumero_cheque.Location = New System.Drawing.Point(161, 48)
        Me.txtnumero_cheque.MaxLength = 50
        Me.txtnumero_cheque.Name = "txtnumero_cheque"
        Me.txtnumero_cheque.Size = New System.Drawing.Size(385, 20)
        Me.txtnumero_cheque.TabIndex = 4
        '
        'etiquetanumero_cheque
        '
        Me.etiquetanumero_cheque.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetanumero_cheque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetanumero_cheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanumero_cheque.ForeColor = System.Drawing.Color.Black
        Me.etiquetanumero_cheque.Location = New System.Drawing.Point(28, 48)
        Me.etiquetanumero_cheque.Name = "etiquetanumero_cheque"
        Me.etiquetanumero_cheque.Size = New System.Drawing.Size(127, 21)
        Me.etiquetanumero_cheque.TabIndex = 500
        Me.etiquetanumero_cheque.Text = "Numero_cheque"
        Me.etiquetanumero_cheque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chktipo_cheque
        '
        Me.chktipo_cheque.AutoSize = True
        Me.chktipo_cheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chktipo_cheque.Location = New System.Drawing.Point(161, 91)
        Me.chktipo_cheque.Name = "chktipo_cheque"
        Me.chktipo_cheque.Size = New System.Drawing.Size(116, 21)
        Me.chktipo_cheque.TabIndex = 5
        Me.chktipo_cheque.Text = "tipo_cheque"
        '
        'etiquetatipo_cheque
        '
        Me.etiquetatipo_cheque.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetatipo_cheque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetatipo_cheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetatipo_cheque.ForeColor = System.Drawing.Color.Black
        Me.etiquetatipo_cheque.Location = New System.Drawing.Point(28, 91)
        Me.etiquetatipo_cheque.Name = "etiquetatipo_cheque"
        Me.etiquetatipo_cheque.Size = New System.Drawing.Size(127, 21)
        Me.etiquetatipo_cheque.TabIndex = 501
        Me.etiquetatipo_cheque.Text = "Tipo_cheque"
        Me.etiquetatipo_cheque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_banco
        '
        Me.lblid_banco.AutoSize = True
        Me.lblid_banco.BackColor = System.Drawing.Color.Red
        Me.lblid_banco.Location = New System.Drawing.Point(370, 134)
        Me.lblid_banco.Name = "lblid_banco"
        Me.lblid_banco.Size = New System.Drawing.Size(13, 13)
        Me.lblid_banco.TabIndex = 502
        Me.lblid_banco.Text = "0"
        Me.lblid_banco.Visible = False
        '
        'btnBuscabanco
        '
        Me.btnBuscabanco.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscabanco.Image = CType(resources.GetObject("btnBuscabanco.Image"), System.Drawing.Image)
        Me.btnBuscabanco.Location = New System.Drawing.Point(505, 134)
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
        Me.cmbbanco.Location = New System.Drawing.Point(161, 134)
        Me.cmbbanco.Name = "cmbbanco"
        Me.cmbbanco.Size = New System.Drawing.Size(329, 21)
        Me.cmbbanco.TabIndex = 6
        '
        'etiquetaid_banco
        '
        Me.etiquetaid_banco.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_banco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_banco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_banco.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_banco.Location = New System.Drawing.Point(28, 134)
        Me.etiquetaid_banco.Name = "etiquetaid_banco"
        Me.etiquetaid_banco.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_banco.TabIndex = 503
        Me.etiquetaid_banco.Text = "Banco"
        Me.etiquetaid_banco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_cuenta
        '
        Me.lblid_cuenta.AutoSize = True
        Me.lblid_cuenta.BackColor = System.Drawing.Color.Red
        Me.lblid_cuenta.Location = New System.Drawing.Point(370, 177)
        Me.lblid_cuenta.Name = "lblid_cuenta"
        Me.lblid_cuenta.Size = New System.Drawing.Size(13, 13)
        Me.lblid_cuenta.TabIndex = 504
        Me.lblid_cuenta.Text = "0"
        Me.lblid_cuenta.Visible = False
        '
        'btnBuscacuenta
        '
        Me.btnBuscacuenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscacuenta.Image = CType(resources.GetObject("btnBuscacuenta.Image"), System.Drawing.Image)
        Me.btnBuscacuenta.Location = New System.Drawing.Point(505, 177)
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
        Me.cmbcuenta.Location = New System.Drawing.Point(161, 177)
        Me.cmbcuenta.Name = "cmbcuenta"
        Me.cmbcuenta.Size = New System.Drawing.Size(329, 21)
        Me.cmbcuenta.TabIndex = 7
        '
        'etiquetaid_cuenta
        '
        Me.etiquetaid_cuenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_cuenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_cuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_cuenta.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_cuenta.Location = New System.Drawing.Point(28, 177)
        Me.etiquetaid_cuenta.Name = "etiquetaid_cuenta"
        Me.etiquetaid_cuenta.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_cuenta.TabIndex = 505
        Me.etiquetaid_cuenta.Text = "Cuenta"
        Me.etiquetaid_cuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtinicio
        '
        Me.txtinicio.BackColor = System.Drawing.Color.White
        Me.txtinicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinicio.ForeColor = System.Drawing.Color.Blue
        Me.txtinicio.Location = New System.Drawing.Point(161, 220)
        Me.txtinicio.MaxLength = 50
        Me.txtinicio.Name = "txtinicio"
        Me.txtinicio.Size = New System.Drawing.Size(222, 31)
        Me.txtinicio.TabIndex = 8
        Me.txtinicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetainicio
        '
        Me.etiquetainicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetainicio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetainicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetainicio.ForeColor = System.Drawing.Color.Black
        Me.etiquetainicio.Location = New System.Drawing.Point(28, 220)
        Me.etiquetainicio.Name = "etiquetainicio"
        Me.etiquetainicio.Size = New System.Drawing.Size(127, 21)
        Me.etiquetainicio.TabIndex = 506
        Me.etiquetainicio.Text = "Inicio"
        Me.etiquetainicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtfin
        '
        Me.txtfin.BackColor = System.Drawing.Color.White
        Me.txtfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfin.ForeColor = System.Drawing.Color.Blue
        Me.txtfin.Location = New System.Drawing.Point(161, 273)
        Me.txtfin.MaxLength = 50
        Me.txtfin.Name = "txtfin"
        Me.txtfin.Size = New System.Drawing.Size(222, 31)
        Me.txtfin.TabIndex = 9
        Me.txtfin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetafin
        '
        Me.etiquetafin.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetafin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetafin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetafin.ForeColor = System.Drawing.Color.Black
        Me.etiquetafin.Location = New System.Drawing.Point(28, 273)
        Me.etiquetafin.Name = "etiquetafin"
        Me.etiquetafin.Size = New System.Drawing.Size(127, 21)
        Me.etiquetafin.TabIndex = 507
        Me.etiquetafin.Text = "Fin"
        Me.etiquetafin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmDetalleChequeras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 446)
        Me.Controls.Add(Me.txtnumero_cheque)
        Me.Controls.Add(Me.etiquetanumero_cheque)
        Me.Controls.Add(Me.chktipo_cheque)
        Me.Controls.Add(Me.etiquetatipo_cheque)
        Me.Controls.Add(Me.lblid_banco)
        Me.Controls.Add(Me.btnBuscabanco)
        Me.Controls.Add(Me.cmbbanco)
        Me.Controls.Add(Me.etiquetaid_banco)
        Me.Controls.Add(Me.lblid_cuenta)
        Me.Controls.Add(Me.btnBuscacuenta)
        Me.Controls.Add(Me.cmbcuenta)
        Me.Controls.Add(Me.etiquetaid_cuenta)
        Me.Controls.Add(Me.txtinicio)
        Me.Controls.Add(Me.etiquetainicio)
        Me.Controls.Add(Me.txtfin)
        Me.Controls.Add(Me.etiquetafin)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalleChequeras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleChequeras"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Protected WithEvents txtnumero_cheque As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanumero_cheque As System.Windows.Forms.Label
   Protected WithEvents chktipo_cheque As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetatipo_cheque As System.Windows.Forms.Label
   Friend WithEvents lblid_banco As System.Windows.Forms.Label
   Friend WithEvents btnBuscabanco As System.Windows.Forms.Button
   Friend WithEvents cmbbanco As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_banco As System.Windows.Forms.Label
   Friend WithEvents lblid_cuenta As System.Windows.Forms.Label
   Friend WithEvents btnBuscacuenta As System.Windows.Forms.Button
   Friend WithEvents cmbcuenta As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_cuenta As System.Windows.Forms.Label
   Protected WithEvents txtinicio As System.Windows.Forms.TextBox
   Friend WithEvents etiquetainicio As System.Windows.Forms.Label
   Protected WithEvents txtfin As System.Windows.Forms.TextBox
   Friend WithEvents etiquetafin As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

