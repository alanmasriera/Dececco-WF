<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleTipo_voz
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleTipo_voz))
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtnombre_tipo_voz = New System.Windows.Forms.TextBox()
        Me.etiquetanombre_tipo_voz = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.etiquetacodigo = New System.Windows.Forms.Label()
        Me.txtponderacion = New System.Windows.Forms.TextBox()
        Me.etiquetaponderacion = New System.Windows.Forms.Label()
        Me.lblid_control = New System.Windows.Forms.Label()
        Me.btnBuscacontrol = New System.Windows.Forms.Button()
        Me.cmbcontrol = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_control = New System.Windows.Forms.Label()
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
        Me.btnSalir.Location = New System.Drawing.Point(499, 270)
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
        Me.btnGuardar.Location = New System.Drawing.Point(392, 270)
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
        Me.GroupBox1.Size = New System.Drawing.Size(568, 230)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtnombre_tipo_voz
        '
        Me.txtnombre_tipo_voz.BackColor = System.Drawing.Color.White
        Me.txtnombre_tipo_voz.Location = New System.Drawing.Point(161, 48)
        Me.txtnombre_tipo_voz.MaxLength = 50
        Me.txtnombre_tipo_voz.Name = "txtnombre_tipo_voz"
        Me.txtnombre_tipo_voz.Size = New System.Drawing.Size(385, 20)
        Me.txtnombre_tipo_voz.TabIndex = 4
        '
        'etiquetanombre_tipo_voz
        '
        Me.etiquetanombre_tipo_voz.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetanombre_tipo_voz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetanombre_tipo_voz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanombre_tipo_voz.ForeColor = System.Drawing.Color.Black
        Me.etiquetanombre_tipo_voz.Location = New System.Drawing.Point(28, 48)
        Me.etiquetanombre_tipo_voz.Name = "etiquetanombre_tipo_voz"
        Me.etiquetanombre_tipo_voz.Size = New System.Drawing.Size(127, 21)
        Me.etiquetanombre_tipo_voz.TabIndex = 500
        Me.etiquetanombre_tipo_voz.Text = "Nombre_tipo_voz"
        Me.etiquetanombre_tipo_voz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcodigo
        '
        Me.txtcodigo.BackColor = System.Drawing.Color.White
        Me.txtcodigo.Location = New System.Drawing.Point(161, 91)
        Me.txtcodigo.MaxLength = 50
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(385, 20)
        Me.txtcodigo.TabIndex = 5
        '
        'etiquetacodigo
        '
        Me.etiquetacodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetacodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetacodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacodigo.ForeColor = System.Drawing.Color.Black
        Me.etiquetacodigo.Location = New System.Drawing.Point(28, 91)
        Me.etiquetacodigo.Name = "etiquetacodigo"
        Me.etiquetacodigo.Size = New System.Drawing.Size(127, 21)
        Me.etiquetacodigo.TabIndex = 501
        Me.etiquetacodigo.Text = "Codigo"
        Me.etiquetacodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtponderacion
        '
        Me.txtponderacion.BackColor = System.Drawing.Color.White
        Me.txtponderacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtponderacion.ForeColor = System.Drawing.Color.Blue
        Me.txtponderacion.Location = New System.Drawing.Point(161, 134)
        Me.txtponderacion.MaxLength = 50
        Me.txtponderacion.Name = "txtponderacion"
        Me.txtponderacion.Size = New System.Drawing.Size(222, 31)
        Me.txtponderacion.TabIndex = 6
        Me.txtponderacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetaponderacion
        '
        Me.etiquetaponderacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaponderacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaponderacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaponderacion.ForeColor = System.Drawing.Color.Black
        Me.etiquetaponderacion.Location = New System.Drawing.Point(28, 134)
        Me.etiquetaponderacion.Name = "etiquetaponderacion"
        Me.etiquetaponderacion.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaponderacion.TabIndex = 502
        Me.etiquetaponderacion.Text = "Ponderacion"
        Me.etiquetaponderacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_control
        '
        Me.lblid_control.AutoSize = True
        Me.lblid_control.BackColor = System.Drawing.Color.Red
        Me.lblid_control.Location = New System.Drawing.Point(370, 187)
        Me.lblid_control.Name = "lblid_control"
        Me.lblid_control.Size = New System.Drawing.Size(13, 13)
        Me.lblid_control.TabIndex = 503
        Me.lblid_control.Text = "0"
        Me.lblid_control.Visible = False
        '
        'btnBuscacontrol
        '
        Me.btnBuscacontrol.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscacontrol.Image = CType(resources.GetObject("btnBuscacontrol.Image"), System.Drawing.Image)
        Me.btnBuscacontrol.Location = New System.Drawing.Point(505, 187)
        Me.btnBuscacontrol.Name = "btnBuscacontrol"
        Me.btnBuscacontrol.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscacontrol.TabIndex = 30
        Me.btnBuscacontrol.UseVisualStyleBackColor = True
        '
        'cmbcontrol
        '
        Me.cmbcontrol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbcontrol.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbcontrol.FormattingEnabled = True
        Me.cmbcontrol.Location = New System.Drawing.Point(161, 187)
        Me.cmbcontrol.Name = "cmbcontrol"
        Me.cmbcontrol.Size = New System.Drawing.Size(329, 21)
        Me.cmbcontrol.TabIndex = 7
        '
        'etiquetaid_control
        '
        Me.etiquetaid_control.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_control.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_control.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_control.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_control.Location = New System.Drawing.Point(28, 187)
        Me.etiquetaid_control.Name = "etiquetaid_control"
        Me.etiquetaid_control.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_control.TabIndex = 504
        Me.etiquetaid_control.Text = "Control"
        Me.etiquetaid_control.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmDetalleTipo_voz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 350)
        Me.Controls.Add(Me.txtnombre_tipo_voz)
        Me.Controls.Add(Me.etiquetanombre_tipo_voz)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.etiquetacodigo)
        Me.Controls.Add(Me.txtponderacion)
        Me.Controls.Add(Me.etiquetaponderacion)
        Me.Controls.Add(Me.lblid_control)
        Me.Controls.Add(Me.btnBuscacontrol)
        Me.Controls.Add(Me.cmbcontrol)
        Me.Controls.Add(Me.etiquetaid_control)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalleTipo_voz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleTipo_voz"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Protected WithEvents txtnombre_tipo_voz As System.Windows.Forms.TextBox
    Friend WithEvents etiquetanombre_tipo_voz As System.Windows.Forms.Label
    Protected WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents etiquetacodigo As System.Windows.Forms.Label
    Protected WithEvents txtponderacion As System.Windows.Forms.TextBox
    Friend WithEvents etiquetaponderacion As System.Windows.Forms.Label
    Friend WithEvents lblid_control As System.Windows.Forms.Label
    Friend WithEvents btnBuscacontrol As System.Windows.Forms.Button
    Friend WithEvents cmbcontrol As System.Windows.Forms.ComboBox
    Friend WithEvents etiquetaid_control As System.Windows.Forms.Label
    Protected WithEvents btnSalir As System.Windows.Forms.Button
    Protected WithEvents btnGuardar As System.Windows.Forms.Button
    Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

