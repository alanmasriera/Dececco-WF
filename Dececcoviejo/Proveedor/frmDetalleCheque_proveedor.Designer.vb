<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleCheque_proveedor
   Inherits System.Windows.Forms.Form

   'Form reemplaza a Dispose para limpiar la lista de componentes.
   <System.Diagnostics.DebuggerNonUserCode()> _
   Protected Overrides Sub Dispose(ByVal disposing As Boolean)
       If disposing AndAlso components IsNot Nothing Then
           components.Dispose()
       End If
       MyBase.Dispose(disposing)
   End Sub

   'Requerido por el Dise�ador de Windows Forms
   Private components As System.ComponentModel.IContainer

   'NOTA: el Dise�ador de Windows Forms necesita el siguiente procedimiento
   'Se puede modificar usando el Dise�ador de Windows Forms.
   'No lo modifique con el editor de c�digo.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleCheque_proveedor))
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblid_recibo_proveedor = New System.Windows.Forms.Label
        Me.lblid_cheque_librado = New System.Windows.Forms.Label
        Me.btnBuscacheque_librado = New System.Windows.Forms.Button
        Me.cmbcheque_librado = New System.Windows.Forms.ComboBox
        Me.etiquetaid_cheque_recibido = New System.Windows.Forms.Label
        Me.chkcontrol = New System.Windows.Forms.CheckBox
        Me.etiquetacontrol = New System.Windows.Forms.Label
        Me.lblid_proveedor = New System.Windows.Forms.Label
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
        Me.btnSalir.Location = New System.Drawing.Point(499, 181)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(81, 69)
        Me.btnSalir.TabIndex = 51
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
        Me.btnGuardar.Location = New System.Drawing.Point(392, 181)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(78, 69)
        Me.btnGuardar.TabIndex = 50
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 120)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblid_recibo_proveedor
        '
        Me.lblid_recibo_proveedor.AutoSize = True
        Me.lblid_recibo_proveedor.BackColor = System.Drawing.Color.Red
        Me.lblid_recibo_proveedor.Location = New System.Drawing.Point(370, 9)
        Me.lblid_recibo_proveedor.Name = "lblid_recibo_proveedor"
        Me.lblid_recibo_proveedor.Size = New System.Drawing.Size(13, 13)
        Me.lblid_recibo_proveedor.TabIndex = 500
        Me.lblid_recibo_proveedor.Text = "0"
        Me.lblid_recibo_proveedor.Visible = False
        '
        'lblid_cheque_librado
        '
        Me.lblid_cheque_librado.AutoSize = True
        Me.lblid_cheque_librado.BackColor = System.Drawing.Color.Red
        Me.lblid_cheque_librado.Location = New System.Drawing.Point(372, 45)
        Me.lblid_cheque_librado.Name = "lblid_cheque_librado"
        Me.lblid_cheque_librado.Size = New System.Drawing.Size(13, 13)
        Me.lblid_cheque_librado.TabIndex = 502
        Me.lblid_cheque_librado.Text = "0"
        Me.lblid_cheque_librado.Visible = False
        '
        'btnBuscacheque_librado
        '
        Me.btnBuscacheque_librado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscacheque_librado.Image = CType(resources.GetObject("btnBuscacheque_librado.Image"), System.Drawing.Image)
        Me.btnBuscacheque_librado.Location = New System.Drawing.Point(507, 45)
        Me.btnBuscacheque_librado.Name = "btnBuscacheque_librado"
        Me.btnBuscacheque_librado.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscacheque_librado.TabIndex = 61
        Me.btnBuscacheque_librado.UseVisualStyleBackColor = True
        '
        'cmbcheque_librado
        '
        Me.cmbcheque_librado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbcheque_librado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbcheque_librado.FormattingEnabled = True
        Me.cmbcheque_librado.Location = New System.Drawing.Point(163, 45)
        Me.cmbcheque_librado.Name = "cmbcheque_librado"
        Me.cmbcheque_librado.Size = New System.Drawing.Size(329, 21)
        Me.cmbcheque_librado.TabIndex = 5
        '
        'etiquetaid_cheque_recibido
        '
        Me.etiquetaid_cheque_recibido.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_cheque_recibido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_cheque_recibido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_cheque_recibido.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_cheque_recibido.Location = New System.Drawing.Point(30, 45)
        Me.etiquetaid_cheque_recibido.Name = "etiquetaid_cheque_recibido"
        Me.etiquetaid_cheque_recibido.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_cheque_recibido.TabIndex = 503
        Me.etiquetaid_cheque_recibido.Text = "Cheque_librado"
        Me.etiquetaid_cheque_recibido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkcontrol
        '
        Me.chkcontrol.AutoSize = True
        Me.chkcontrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkcontrol.Location = New System.Drawing.Point(163, 88)
        Me.chkcontrol.Name = "chkcontrol"
        Me.chkcontrol.Size = New System.Drawing.Size(77, 21)
        Me.chkcontrol.TabIndex = 6
        Me.chkcontrol.Text = "control"
        '
        'etiquetacontrol
        '
        Me.etiquetacontrol.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetacontrol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetacontrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacontrol.ForeColor = System.Drawing.Color.Black
        Me.etiquetacontrol.Location = New System.Drawing.Point(30, 88)
        Me.etiquetacontrol.Name = "etiquetacontrol"
        Me.etiquetacontrol.Size = New System.Drawing.Size(127, 21)
        Me.etiquetacontrol.TabIndex = 504
        Me.etiquetacontrol.Text = "Control"
        Me.etiquetacontrol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_proveedor
        '
        Me.lblid_proveedor.AutoSize = True
        Me.lblid_proveedor.BackColor = System.Drawing.Color.Red
        Me.lblid_proveedor.Location = New System.Drawing.Point(351, 9)
        Me.lblid_proveedor.Name = "lblid_proveedor"
        Me.lblid_proveedor.Size = New System.Drawing.Size(13, 13)
        Me.lblid_proveedor.TabIndex = 664
        Me.lblid_proveedor.Text = "0"
        Me.lblid_proveedor.Visible = False
        '
        'frmDetalleCheque_proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 270)
        Me.Controls.Add(Me.lblid_proveedor)
        Me.Controls.Add(Me.lblid_recibo_proveedor)
        Me.Controls.Add(Me.lblid_cheque_librado)
        Me.Controls.Add(Me.btnBuscacheque_librado)
        Me.Controls.Add(Me.cmbcheque_librado)
        Me.Controls.Add(Me.etiquetaid_cheque_recibido)
        Me.Controls.Add(Me.chkcontrol)
        Me.Controls.Add(Me.etiquetacontrol)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalleCheque_proveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleCheque_proveedor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblid_recibo_proveedor As System.Windows.Forms.Label
    Friend WithEvents lblid_cheque_librado As System.Windows.Forms.Label
    Friend WithEvents btnBuscacheque_librado As System.Windows.Forms.Button
    Friend WithEvents cmbcheque_librado As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_cheque_recibido As System.Windows.Forms.Label
   Protected WithEvents chkcontrol As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetacontrol As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
    Friend WithEvents lblid_proveedor As System.Windows.Forms.Label
End Class

