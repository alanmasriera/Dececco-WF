<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleTipo_voz_3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleTipo_voz_3))
        Me.txtnombre_tipo_voz = New System.Windows.Forms.TextBox()
        Me.etiquetanombre_tipo_voz = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.etiquetacodigo = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblId_tipo_voz = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtnombre_tipo_voz
        '
        Me.txtnombre_tipo_voz.BackColor = System.Drawing.Color.White
        Me.txtnombre_tipo_voz.Location = New System.Drawing.Point(162, 19)
        Me.txtnombre_tipo_voz.MaxLength = 50
        Me.txtnombre_tipo_voz.Name = "txtnombre_tipo_voz"
        Me.txtnombre_tipo_voz.Size = New System.Drawing.Size(385, 20)
        Me.txtnombre_tipo_voz.TabIndex = 502
        '
        'etiquetanombre_tipo_voz
        '
        Me.etiquetanombre_tipo_voz.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetanombre_tipo_voz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetanombre_tipo_voz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanombre_tipo_voz.ForeColor = System.Drawing.Color.Black
        Me.etiquetanombre_tipo_voz.Location = New System.Drawing.Point(29, 21)
        Me.etiquetanombre_tipo_voz.Name = "etiquetanombre_tipo_voz"
        Me.etiquetanombre_tipo_voz.Size = New System.Drawing.Size(127, 21)
        Me.etiquetanombre_tipo_voz.TabIndex = 506
        Me.etiquetanombre_tipo_voz.Text = "Nombre_tipo_voz"
        Me.etiquetanombre_tipo_voz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcodigo
        '
        Me.txtcodigo.BackColor = System.Drawing.Color.White
        Me.txtcodigo.Location = New System.Drawing.Point(162, 64)
        Me.txtcodigo.MaxLength = 50
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(385, 20)
        Me.txtcodigo.TabIndex = 503
        '
        'etiquetacodigo
        '
        Me.etiquetacodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetacodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetacodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacodigo.ForeColor = System.Drawing.Color.Black
        Me.etiquetacodigo.Location = New System.Drawing.Point(29, 62)
        Me.etiquetacodigo.Name = "etiquetacodigo"
        Me.etiquetacodigo.Size = New System.Drawing.Size(127, 21)
        Me.etiquetacodigo.TabIndex = 507
        Me.etiquetacodigo.Text = "Codigo"
        Me.etiquetacodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(499, 121)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(81, 69)
        Me.btnSalir.TabIndex = 505
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
        Me.btnGuardar.Location = New System.Drawing.Point(388, 121)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(78, 69)
        Me.btnGuardar.TabIndex = 504
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtnombre_tipo_voz)
        Me.GroupBox1.Controls.Add(Me.txtcodigo)
        Me.GroupBox1.Controls.Add(Me.etiquetacodigo)
        Me.GroupBox1.Controls.Add(Me.etiquetanombre_tipo_voz)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 101)
        Me.GroupBox1.TabIndex = 508
        Me.GroupBox1.TabStop = False
        '
        'lblId_tipo_voz
        '
        Me.lblId_tipo_voz.AutoSize = True
        Me.lblId_tipo_voz.BackColor = System.Drawing.Color.Red
        Me.lblId_tipo_voz.Location = New System.Drawing.Point(38, 121)
        Me.lblId_tipo_voz.Name = "lblId_tipo_voz"
        Me.lblId_tipo_voz.Size = New System.Drawing.Size(13, 13)
        Me.lblId_tipo_voz.TabIndex = 513
        Me.lblId_tipo_voz.Text = "0"
        Me.lblId_tipo_voz.Visible = False
        '
        'frmDetalleTipo_voz_3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 201)
        Me.Controls.Add(Me.lblId_tipo_voz)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Name = "frmDetalleTipo_voz_3"
        Me.Text = "frmDetalleTipo_voz_3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Protected WithEvents txtnombre_tipo_voz As System.Windows.Forms.TextBox
    Friend WithEvents etiquetanombre_tipo_voz As System.Windows.Forms.Label
    Protected WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents etiquetacodigo As System.Windows.Forms.Label
    Protected WithEvents btnSalir As System.Windows.Forms.Button
    Protected WithEvents btnGuardar As System.Windows.Forms.Button
    Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblId_tipo_voz As System.Windows.Forms.Label
End Class
