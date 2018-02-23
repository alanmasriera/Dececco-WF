<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleDetalle_recurso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleDetalle_recurso))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblid_usuario = New System.Windows.Forms.Label()
        Me.lblid_actividad_proyecto = New System.Windows.Forms.Label()
        Me.btnBuscausuario = New System.Windows.Forms.Button()
        Me.cmbusuario = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_usuario = New System.Windows.Forms.Label()
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtcantidad_hora = New System.Windows.Forms.TextBox()
        Me.etiquetacantidad_hora = New System.Windows.Forms.Label()
        Me.txtporcentaje_avance = New System.Windows.Forms.TextBox()
        Me.etiquetaporcentaje_avance = New System.Windows.Forms.Label()
        Me.txtmotivo = New System.Windows.Forms.TextBox()
        Me.etiquetamotivo = New System.Windows.Forms.Label()
        Me.txttipo = New System.Windows.Forms.TextBox()
        Me.etiquetatipo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkRealizada = New System.Windows.Forms.CheckBox()
        Me.lblid_pk = New System.Windows.Forms.Label()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.btnBorrar = New System.Windows.Forms.Button()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnSalir.Location = New System.Drawing.Point(499, 344)
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
        Me.btnGuardar.Location = New System.Drawing.Point(392, 344)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(78, 69)
        Me.btnGuardar.TabIndex = 20
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 302)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblid_usuario
        '
        Me.lblid_usuario.AutoSize = True
        Me.lblid_usuario.BackColor = System.Drawing.Color.Red
        Me.lblid_usuario.Location = New System.Drawing.Point(370, 54)
        Me.lblid_usuario.Name = "lblid_usuario"
        Me.lblid_usuario.Size = New System.Drawing.Size(13, 13)
        Me.lblid_usuario.TabIndex = 502
        Me.lblid_usuario.Text = "0"
        Me.lblid_usuario.Visible = False
        '
        'lblid_actividad_proyecto
        '
        Me.lblid_actividad_proyecto.AutoSize = True
        Me.lblid_actividad_proyecto.BackColor = System.Drawing.Color.Red
        Me.lblid_actividad_proyecto.Location = New System.Drawing.Point(551, 57)
        Me.lblid_actividad_proyecto.Name = "lblid_actividad_proyecto"
        Me.lblid_actividad_proyecto.Size = New System.Drawing.Size(13, 13)
        Me.lblid_actividad_proyecto.TabIndex = 500
        Me.lblid_actividad_proyecto.Text = "0"
        Me.lblid_actividad_proyecto.Visible = False
        '
        'btnBuscausuario
        '
        Me.btnBuscausuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscausuario.Image = CType(resources.GetObject("btnBuscausuario.Image"), System.Drawing.Image)
        Me.btnBuscausuario.Location = New System.Drawing.Point(505, 54)
        Me.btnBuscausuario.Name = "btnBuscausuario"
        Me.btnBuscausuario.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscausuario.TabIndex = 31
        Me.btnBuscausuario.UseVisualStyleBackColor = True
        '
        'cmbusuario
        '
        Me.cmbusuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbusuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbusuario.FormattingEnabled = True
        Me.cmbusuario.Location = New System.Drawing.Point(161, 54)
        Me.cmbusuario.Name = "cmbusuario"
        Me.cmbusuario.Size = New System.Drawing.Size(329, 21)
        Me.cmbusuario.TabIndex = 5
        '
        'etiquetaid_usuario
        '
        Me.etiquetaid_usuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_usuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_usuario.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_usuario.Location = New System.Drawing.Point(28, 54)
        Me.etiquetaid_usuario.Name = "etiquetaid_usuario"
        Me.etiquetaid_usuario.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_usuario.TabIndex = 503
        Me.etiquetaid_usuario.Text = "Usuario"
        Me.etiquetaid_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcantidad_hora
        '
        Me.txtcantidad_hora.BackColor = System.Drawing.Color.White
        Me.txtcantidad_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad_hora.ForeColor = System.Drawing.Color.Blue
        Me.txtcantidad_hora.Location = New System.Drawing.Point(161, 101)
        Me.txtcantidad_hora.MaxLength = 50
        Me.txtcantidad_hora.Name = "txtcantidad_hora"
        Me.txtcantidad_hora.Size = New System.Drawing.Size(222, 31)
        Me.txtcantidad_hora.TabIndex = 6
        Me.txtcantidad_hora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetacantidad_hora
        '
        Me.etiquetacantidad_hora.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetacantidad_hora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetacantidad_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacantidad_hora.ForeColor = System.Drawing.Color.Black
        Me.etiquetacantidad_hora.Location = New System.Drawing.Point(28, 101)
        Me.etiquetacantidad_hora.Name = "etiquetacantidad_hora"
        Me.etiquetacantidad_hora.Size = New System.Drawing.Size(127, 21)
        Me.etiquetacantidad_hora.TabIndex = 504
        Me.etiquetacantidad_hora.Text = "Cantidad_hora"
        Me.etiquetacantidad_hora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtporcentaje_avance
        '
        Me.txtporcentaje_avance.BackColor = System.Drawing.Color.White
        Me.txtporcentaje_avance.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtporcentaje_avance.ForeColor = System.Drawing.Color.Blue
        Me.txtporcentaje_avance.Location = New System.Drawing.Point(161, 154)
        Me.txtporcentaje_avance.MaxLength = 50
        Me.txtporcentaje_avance.Name = "txtporcentaje_avance"
        Me.txtporcentaje_avance.Size = New System.Drawing.Size(222, 31)
        Me.txtporcentaje_avance.TabIndex = 7
        Me.txtporcentaje_avance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetaporcentaje_avance
        '
        Me.etiquetaporcentaje_avance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaporcentaje_avance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaporcentaje_avance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaporcentaje_avance.ForeColor = System.Drawing.Color.Black
        Me.etiquetaporcentaje_avance.Location = New System.Drawing.Point(28, 154)
        Me.etiquetaporcentaje_avance.Name = "etiquetaporcentaje_avance"
        Me.etiquetaporcentaje_avance.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaporcentaje_avance.TabIndex = 505
        Me.etiquetaporcentaje_avance.Text = "Porcentaje_avance"
        Me.etiquetaporcentaje_avance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtmotivo
        '
        Me.txtmotivo.BackColor = System.Drawing.Color.White
        Me.txtmotivo.Location = New System.Drawing.Point(161, 207)
        Me.txtmotivo.MaxLength = 50
        Me.txtmotivo.Name = "txtmotivo"
        Me.txtmotivo.Size = New System.Drawing.Size(385, 20)
        Me.txtmotivo.TabIndex = 8
        '
        'etiquetamotivo
        '
        Me.etiquetamotivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetamotivo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetamotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetamotivo.ForeColor = System.Drawing.Color.Black
        Me.etiquetamotivo.Location = New System.Drawing.Point(28, 207)
        Me.etiquetamotivo.Name = "etiquetamotivo"
        Me.etiquetamotivo.Size = New System.Drawing.Size(127, 21)
        Me.etiquetamotivo.TabIndex = 506
        Me.etiquetamotivo.Text = "Detalle"
        Me.etiquetamotivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txttipo
        '
        Me.txttipo.BackColor = System.Drawing.Color.White
        Me.txttipo.Location = New System.Drawing.Point(161, 250)
        Me.txttipo.MaxLength = 50
        Me.txttipo.Name = "txttipo"
        Me.txttipo.Size = New System.Drawing.Size(385, 20)
        Me.txttipo.TabIndex = 9
        '
        'etiquetatipo
        '
        Me.etiquetatipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetatipo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetatipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetatipo.ForeColor = System.Drawing.Color.Black
        Me.etiquetatipo.Location = New System.Drawing.Point(28, 250)
        Me.etiquetatipo.Name = "etiquetatipo"
        Me.etiquetatipo.Size = New System.Drawing.Size(127, 21)
        Me.etiquetatipo.TabIndex = 507
        Me.etiquetatipo.Text = "Tipo"
        Me.etiquetatipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(28, 290)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 21)
        Me.Label1.TabIndex = 508
        Me.Label1.Text = "Realizada"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkRealizada
        '
        Me.chkRealizada.AutoSize = True
        Me.chkRealizada.Location = New System.Drawing.Point(161, 290)
        Me.chkRealizada.Name = "chkRealizada"
        Me.chkRealizada.Size = New System.Drawing.Size(73, 17)
        Me.chkRealizada.TabIndex = 10
        Me.chkRealizada.Text = "Realizada"
        Me.chkRealizada.UseVisualStyleBackColor = True
        '
        'lblid_pk
        '
        Me.lblid_pk.AutoSize = True
        Me.lblid_pk.BackColor = System.Drawing.Color.Red
        Me.lblid_pk.Location = New System.Drawing.Point(25, 454)
        Me.lblid_pk.Name = "lblid_pk"
        Me.lblid_pk.Size = New System.Drawing.Size(13, 13)
        Me.lblid_pk.TabIndex = 567
        Me.lblid_pk.Text = "0"
        Me.lblid_pk.Visible = False
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToResizeColumns = False
        Me.dgv1.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Brown
        Me.dgv1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Brown
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv1.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgv1.GridColor = System.Drawing.Color.MediumPurple
        Me.dgv1.Location = New System.Drawing.Point(12, 441)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.ShowCellErrors = False
        Me.dgv1.ShowRowErrors = False
        Me.dgv1.Size = New System.Drawing.Size(568, 241)
        Me.dgv1.StandardTab = True
        Me.dgv1.TabIndex = 566
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(12, 693)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(97, 25)
        Me.btnBorrar.TabIndex = 568
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'frmDetalleDetalle_recurso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 730)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.lblid_pk)
        Me.Controls.Add(Me.chkRealizada)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblid_actividad_proyecto)
        Me.Controls.Add(Me.lblid_usuario)
        Me.Controls.Add(Me.txtcantidad_hora)
        Me.Controls.Add(Me.etiquetacantidad_hora)
        Me.Controls.Add(Me.btnBuscausuario)
        Me.Controls.Add(Me.txtporcentaje_avance)
        Me.Controls.Add(Me.etiquetaporcentaje_avance)
        Me.Controls.Add(Me.cmbusuario)
        Me.Controls.Add(Me.etiquetaid_usuario)
        Me.Controls.Add(Me.txtmotivo)
        Me.Controls.Add(Me.etiquetamotivo)
        Me.Controls.Add(Me.txttipo)
        Me.Controls.Add(Me.etiquetatipo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgv1)
        Me.Name = "frmDetalleDetalle_recurso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleDetalle_recurso"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents lblid_actividad_proyecto As System.Windows.Forms.Label
    Friend WithEvents lblid_usuario As System.Windows.Forms.Label
   Friend WithEvents btnBuscausuario As System.Windows.Forms.Button
   Friend WithEvents cmbusuario As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_usuario As System.Windows.Forms.Label
   Protected WithEvents txtcantidad_hora As System.Windows.Forms.TextBox
   Friend WithEvents etiquetacantidad_hora As System.Windows.Forms.Label
   Protected WithEvents txtporcentaje_avance As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaporcentaje_avance As System.Windows.Forms.Label
   Protected WithEvents txtmotivo As System.Windows.Forms.TextBox
   Friend WithEvents etiquetamotivo As System.Windows.Forms.Label
   Protected WithEvents txttipo As System.Windows.Forms.TextBox
   Friend WithEvents etiquetatipo As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkRealizada As System.Windows.Forms.CheckBox
    Protected WithEvents lblid_pk As System.Windows.Forms.Label
    Protected WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
End Class

