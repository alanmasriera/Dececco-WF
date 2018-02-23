<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleTipo_voz_2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleTipo_voz_2))
        Me.txtponderacion = New System.Windows.Forms.TextBox()
        Me.etiquetaponderacion = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblId_tipo_voz = New System.Windows.Forms.Label()
        Me.chk_pond_manual = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtponderacion
        '
        Me.txtponderacion.BackColor = System.Drawing.Color.White
        Me.txtponderacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtponderacion.ForeColor = System.Drawing.Color.Blue
        Me.txtponderacion.Location = New System.Drawing.Point(144, 28)
        Me.txtponderacion.MaxLength = 50
        Me.txtponderacion.Name = "txtponderacion"
        Me.txtponderacion.Size = New System.Drawing.Size(222, 31)
        Me.txtponderacion.TabIndex = 505
        Me.txtponderacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetaponderacion
        '
        Me.etiquetaponderacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaponderacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaponderacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaponderacion.ForeColor = System.Drawing.Color.Black
        Me.etiquetaponderacion.Location = New System.Drawing.Point(11, 28)
        Me.etiquetaponderacion.Name = "etiquetaponderacion"
        Me.etiquetaponderacion.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaponderacion.TabIndex = 510
        Me.etiquetaponderacion.Text = "Ponderación"
        Me.etiquetaponderacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(470, 87)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(81, 69)
        Me.btnSalir.TabIndex = 507
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
        Me.btnGuardar.Location = New System.Drawing.Point(361, 87)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(78, 69)
        Me.btnGuardar.TabIndex = 506
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chk_pond_manual)
        Me.GroupBox1.Controls.Add(Me.txtponderacion)
        Me.GroupBox1.Controls.Add(Me.etiquetaponderacion)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(565, 81)
        Me.GroupBox1.TabIndex = 511
        Me.GroupBox1.TabStop = False
        '
        'lblId_tipo_voz
        '
        Me.lblId_tipo_voz.AutoSize = True
        Me.lblId_tipo_voz.BackColor = System.Drawing.Color.Red
        Me.lblId_tipo_voz.Location = New System.Drawing.Point(12, 87)
        Me.lblId_tipo_voz.Name = "lblId_tipo_voz"
        Me.lblId_tipo_voz.Size = New System.Drawing.Size(13, 13)
        Me.lblId_tipo_voz.TabIndex = 512
        Me.lblId_tipo_voz.Text = "0"
        Me.lblId_tipo_voz.Visible = False
        '
        'chk_pond_manual
        '
        Me.chk_pond_manual.AutoSize = True
        Me.chk_pond_manual.Location = New System.Drawing.Point(390, 31)
        Me.chk_pond_manual.Name = "chk_pond_manual"
        Me.chk_pond_manual.Size = New System.Drawing.Size(124, 17)
        Me.chk_pond_manual.TabIndex = 511
        Me.chk_pond_manual.Text = "Ponderación Manual"
        Me.chk_pond_manual.UseVisualStyleBackColor = True
        '
        'frmDetalleTipo_voz_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 169)
        Me.Controls.Add(Me.lblId_tipo_voz)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Name = "frmDetalleTipo_voz_2"
        Me.Text = "Modificar ponderación"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Protected WithEvents txtponderacion As System.Windows.Forms.TextBox
    Friend WithEvents etiquetaponderacion As System.Windows.Forms.Label
    Protected WithEvents btnSalir As System.Windows.Forms.Button
    Protected WithEvents btnGuardar As System.Windows.Forms.Button
    Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
    Friend WithEvents lblId_tipo_voz As System.Windows.Forms.Label
    Friend WithEvents chk_pond_manual As System.Windows.Forms.CheckBox
End Class
