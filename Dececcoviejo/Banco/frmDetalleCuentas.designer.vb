<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleCuentas
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
       Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleCuentas))
       Me.btnSalir = New System.Windows.Forms.Button
       Me.btnGuardar = New System.Windows.Forms.Button
       Me.GroupBox1 = New System.Windows.Forms.GroupBox
       Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
       Me.txtnumero = New System.Windows.Forms.TextBox
       Me.etiquetanumero = New System.Windows.Forms.Label
       Me.lblid_empresa = New System.Windows.Forms.Label
       Me.btnBuscaempresa = New System.Windows.Forms.Button
       Me.cmbempresa = New System.Windows.Forms.ComboBox
       Me.etiquetaid_empresa = New System.Windows.Forms.Label
       Me.lblid_banco = New System.Windows.Forms.Label
       Me.btnBuscabanco = New System.Windows.Forms.Button
       Me.cmbbanco = New System.Windows.Forms.ComboBox
       Me.etiquetaid_banco = New System.Windows.Forms.Label
       Me.txtcbu = New System.Windows.Forms.TextBox
       Me.etiquetacbu = New System.Windows.Forms.Label
       Me.txtmoneda = New System.Windows.Forms.TextBox
       Me.etiquetamoneda = New System.Windows.Forms.Label
       Me.SuspendLayout()
       '
       'txtnumero
       '
       Me.txtnumero.BackColor = System.Drawing.Color.White
       Me.txtnumero.Location = New System.Drawing.Point(161, 48)
       Me.txtnumero.MaxLength = 50
       Me.txtnumero.Name = "txtnumero"
       Me.txtnumero.Size = New System.Drawing.Size(385, 20)
       Me.txtnumero.TabIndex = 4
       '
       'etiquietanumero
       '
       Me.etiquetanumero.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
       Me.etiquetanumero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
       Me.etiquetanumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetanumero.ForeColor = System.Drawing.Color.Black
       Me.etiquetanumero.Location = New System.Drawing.Point(28, 48)
       Me.etiquetanumero.Name = "etiquetanumero"
       Me.etiquetanumero.Size = New System.Drawing.Size(127, 21)
       Me.etiquetanumero.TabIndex = 500
       Me.etiquetanumero.Text = "Numero"
       Me.etiquetanumero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_empresa
       '
       Me.lblid_empresa.AutoSize = True
       Me.lblid_empresa.BackColor = System.Drawing.Color.Red
       Me.lblid_empresa.Location = New System.Drawing.Point(370, 91)
       Me.lblid_empresa.Name = "lblid_empresa"
       Me.lblid_empresa.Size = New System.Drawing.Size(13, 13)
       Me.lblid_empresa.TabIndex = 501
       Me.lblid_empresa.Text = "0"
       Me.lblid_empresa.Visible = False
       '
       'btnBuscaempresa
       '
       Me.btnBuscaempresa.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscaempresa.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscaempresa.Location = New System.Drawing.Point(505, 91)
       Me.btnBuscaempresa.Name = "btnBuscaempresa"
       Me.btnBuscaempresa.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscaempresa.TabIndex = 30
       Me.btnBuscaempresa.UseVisualStyleBackColor = True
       '
       'cmbempresa
       '
       Me.cmbempresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbempresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbempresa.FormattingEnabled = True
       Me.cmbempresa.Location = New System.Drawing.Point(161, 91)
       Me.cmbempresa.Name = "cmbempresa"
       Me.cmbempresa.Size = New System.Drawing.Size(329, 21)
       Me.cmbempresa.TabIndex = 5
       '
       'etiquietaid_empresa
       '
       Me.etiquetaid_empresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
       Me.etiquetaid_empresa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
       Me.etiquetaid_empresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_empresa.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_empresa.Location = New System.Drawing.Point(28, 91)
       Me.etiquetaid_empresa.Name = "etiquetaid_empresa"
       Me.etiquetaid_empresa.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_empresa.TabIndex = 502
       Me.etiquetaid_empresa.Text = "Empresa"
       Me.etiquetaid_empresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_banco
       '
       Me.lblid_banco.AutoSize = True
       Me.lblid_banco.BackColor = System.Drawing.Color.Red
       Me.lblid_banco.Location = New System.Drawing.Point(370, 134)
       Me.lblid_banco.Name = "lblid_banco"
       Me.lblid_banco.Size = New System.Drawing.Size(13, 13)
       Me.lblid_banco.TabIndex = 503
       Me.lblid_banco.Text = "0"
       Me.lblid_banco.Visible = False
       '
       'btnBuscabanco
       '
       Me.btnBuscabanco.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscabanco.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscabanco.Location = New System.Drawing.Point(505, 134)
       Me.btnBuscabanco.Name = "btnBuscabanco"
       Me.btnBuscabanco.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscabanco.TabIndex = 31
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
       'etiquietaid_banco
       '
       Me.etiquetaid_banco.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
       Me.etiquetaid_banco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
       Me.etiquetaid_banco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_banco.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_banco.Location = New System.Drawing.Point(28, 134)
       Me.etiquetaid_banco.Name = "etiquetaid_banco"
       Me.etiquetaid_banco.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_banco.TabIndex = 504
       Me.etiquetaid_banco.Text = "Banco"
       Me.etiquetaid_banco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtcbu
       '
       Me.txtcbu.BackColor = System.Drawing.Color.White
       Me.txtcbu.Location = New System.Drawing.Point(161, 177)
       Me.txtcbu.MaxLength = 50
       Me.txtcbu.Name = "txtcbu"
       Me.txtcbu.Size = New System.Drawing.Size(385, 20)
       Me.txtcbu.TabIndex = 7
       '
       'etiquietacbu
       '
       Me.etiquetacbu.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
       Me.etiquetacbu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
       Me.etiquetacbu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetacbu.ForeColor = System.Drawing.Color.Black
       Me.etiquetacbu.Location = New System.Drawing.Point(28, 177)
       Me.etiquetacbu.Name = "etiquetacbu"
       Me.etiquetacbu.Size = New System.Drawing.Size(127, 21)
       Me.etiquetacbu.TabIndex = 505
       Me.etiquetacbu.Text = "Cbu"
       Me.etiquetacbu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtmoneda
       '
       Me.txtmoneda.BackColor = System.Drawing.Color.White
       Me.txtmoneda.Location = New System.Drawing.Point(161, 220)
       Me.txtmoneda.MaxLength = 50
       Me.txtmoneda.Name = "txtmoneda"
       Me.txtmoneda.Size = New System.Drawing.Size(385, 20)
       Me.txtmoneda.TabIndex = 8
       '
       'etiquietamoneda
       '
       Me.etiquetamoneda.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
       Me.etiquetamoneda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
       Me.etiquetamoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetamoneda.ForeColor = System.Drawing.Color.Black
       Me.etiquetamoneda.Location = New System.Drawing.Point(28, 220)
       Me.etiquetamoneda.Name = "etiquetamoneda"
       Me.etiquetamoneda.Size = New System.Drawing.Size(127, 21)
       Me.etiquetamoneda.TabIndex = 506
       Me.etiquetamoneda.Text = "Moneda"
       Me.etiquetamoneda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
       Me.btnSalir.Location = New System.Drawing.Point(499, 303)
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
       Me.btnGuardar.Location = New System.Drawing.Point(392,303)
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
       Me.GroupBox1.Size = New System.Drawing.Size(568, 263)
       Me.GroupBox1.TabIndex = 0
       Me.GroupBox1.TabStop = False
       '
       'frmDetalleCuentas
       '
       Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
       Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
       Me.ClientSize = New System.Drawing.Size(600, 383)
       Me.Controls.Add(Me.txtnumero)
       Me.Controls.Add(Me.etiquetanumero)
       Me.Controls.Add(Me.lblid_empresa)
       Me.Controls.Add(Me.btnBuscaempresa)
       Me.Controls.Add(Me.cmbempresa)
       Me.Controls.Add(Me.etiquetaid_empresa)
       Me.Controls.Add(Me.lblid_banco)
       Me.Controls.Add(Me.btnBuscabanco)
       Me.Controls.Add(Me.cmbbanco)
       Me.Controls.Add(Me.etiquetaid_banco)
       Me.Controls.Add(Me.txtcbu)
       Me.Controls.Add(Me.etiquetacbu)
       Me.Controls.Add(Me.txtmoneda)
       Me.Controls.Add(Me.etiquetamoneda)
       Me.Controls.Add(Me.btnSalir)
       Me.Controls.Add(Me.btnGuardar)
       Me.Controls.Add(Me.GroupBox1)
       Me.Name = "frmDetalleCuentas"
       Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleCuentas" & vgNombreFormulario
       Me.ResumeLayout(False)
       Me.PerformLayout()

   End Sub
   Protected WithEvents txtnumero As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanumero As System.Windows.Forms.Label
   Friend WithEvents lblid_empresa As System.Windows.Forms.Label
   Friend WithEvents btnBuscaempresa As System.Windows.Forms.Button
   Friend WithEvents cmbempresa As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_empresa As System.Windows.Forms.Label
   Friend WithEvents lblid_banco As System.Windows.Forms.Label
   Friend WithEvents btnBuscabanco As System.Windows.Forms.Button
   Friend WithEvents cmbbanco As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_banco As System.Windows.Forms.Label
   Protected WithEvents txtcbu As System.Windows.Forms.TextBox
   Friend WithEvents etiquetacbu As System.Windows.Forms.Label
   Protected WithEvents txtmoneda As System.Windows.Forms.TextBox
   Friend WithEvents etiquetamoneda As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

