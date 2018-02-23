<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbmTipo_hora
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
       Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbmTipo_hora))
       Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
       Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
       Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
       Me.txtBuscar = New System.Windows.Forms.TextBox
       Me.GroupBox1 = New System.Windows.Forms.GroupBox
       Me.btnAyuda = New System.Windows.Forms.Button
       Me.btnSalir = New System.Windows.Forms.Button
       Me.btnBorrar = New System.Windows.Forms.Button
       Me.btnModificar = New System.Windows.Forms.Button
       Me.btnAgregar = New System.Windows.Forms.Button
       Me.lblconsultar = New System.Windows.Forms.Label
       Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
       Me.lblTitulo = New System.Windows.Forms.Label
       Me.dgv1 = New System.Windows.Forms.DataGridView
       Me.lblid_pk = New System.Windows.Forms.Label
       Me.GroupBox1.SuspendLayout()
       CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
       Me.SuspendLayout()
       '
       'txtBuscar
       '
       Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
       Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtBuscar.Location = New System.Drawing.Point(128, 561)
       Me.txtBuscar.Name = "txtBuscar"
       Me.txtBuscar.Size = New System.Drawing.Size(873, 26)
       Me.txtBuscar.TabIndex = 563
       '
       'GroupBox1
       '
       Me.GroupBox1.Controls.Add(Me.btnAyuda)
       Me.GroupBox1.Controls.Add(Me.btnSalir)
       Me.GroupBox1.Controls.Add(Me.btnBorrar)
       Me.GroupBox1.Controls.Add(Me.btnModificar)
       Me.GroupBox1.Controls.Add(Me.btnAgregar)
       Me.GroupBox1.Location = New System.Drawing.Point(15, 606)
       Me.GroupBox1.Name = "GroupBox1"
       Me.GroupBox1.Size = New System.Drawing.Size(986, 107)
       Me.GroupBox1.TabIndex = 564
       Me.GroupBox1.TabStop = False
       '
       'btnAyuda
       '
       Me.btnAyuda.BackColor = System.Drawing.Color.Gainsboro
       Me.btnAyuda.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.btnAyuda.ForeColor = System.Drawing.Color.Black
       Me.btnAyuda.Image = CType(resources.GetObject("btnAyuda.Image"), System.Drawing.Image)
       Me.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.TopCenter
       Me.btnAyuda.Location = New System.Drawing.Point(715, 19)
       Me.btnAyuda.Name = "btnAyuda"
       Me.btnAyuda.Size = New System.Drawing.Size(86, 71)
       Me.btnAyuda.TabIndex = 11
       Me.btnAyuda.Text = "A&yuda"
       Me.btnAyuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter
       Me.btnAyuda.UseVisualStyleBackColor = True
       '
       'btnSalir
       '
       Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
       Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.btnSalir.ForeColor = System.Drawing.Color.Black
       Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
       Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
       Me.btnSalir.Location = New System.Drawing.Point(858, 19)
       Me.btnSalir.Name = "btnSalir"
       Me.btnSalir.Size = New System.Drawing.Size(86, 71)
       Me.btnSalir.TabIndex = 12
       Me.btnSalir.Text = "&Salir"
       Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
       Me.btnSalir.UseVisualStyleBackColor = True
       '
       'btnBorrar
       '
       Me.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBorrar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), System.Drawing.Image)
       Me.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
       Me.btnBorrar.Location = New System.Drawing.Point(292, 19)
       Me.btnBorrar.Name = "btnBorrar"
       Me.btnBorrar.Size = New System.Drawing.Size(86, 71)
       Me.btnBorrar.TabIndex = 10
       Me.btnBorrar.Text = "&Borrar"
       Me.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
       Me.btnBorrar.UseVisualStyleBackColor = True
       '
       'btnModificar
       '
       Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnModificar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
       Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
       Me.btnModificar.Location = New System.Drawing.Point(160, 19)
       Me.btnModificar.Name = "btnModificar"
       Me.btnModificar.Size = New System.Drawing.Size(86, 71)
       Me.btnModificar.TabIndex = 9
       Me.btnModificar.Text = "&Modificar"
       Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
       Me.btnModificar.UseVisualStyleBackColor = True
       '
       'btnAgregar
       '
       Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnAgregar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
       Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
       Me.btnAgregar.Location = New System.Drawing.Point(28, 19)
       Me.btnAgregar.Name = "btnAgregar"
       Me.btnAgregar.Size = New System.Drawing.Size(86, 71)
       Me.btnAgregar.TabIndex = 8
       Me.btnAgregar.Text = "&Agregar"
       Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
       Me.btnAgregar.UseVisualStyleBackColor = True
       '
       'lblconsultar
       '
       Me.lblconsultar.AutoSize = True
        Me.lblconsultar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblconsultar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblconsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconsultar.ForeColor = System.Drawing.Color.Blue
        Me.lblconsultar.Location = New System.Drawing.Point(15, 561)
        Me.lblconsultar.Name = "lblconsultar"
        Me.lblconsultar.Size = New System.Drawing.Size(100, 26)
        Me.lblconsultar.TabIndex = 567
        Me.lblconsultar.Text = "Consultar"
        Me.lblconsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
       Me.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
       Me.lblTitulo.Font = New System.Drawing.Font("Times New Roman", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.lblTitulo.ForeColor = System.Drawing.Color.Red
       Me.lblTitulo.Location = New System.Drawing.Point(281, 22)
       Me.lblTitulo.Name = "lblTitulo"
       Me.lblTitulo.Size = New System.Drawing.Size(456, 30)
       Me.lblTitulo.TabIndex = 566
       Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
       '
       'dgv1
       '
       Me.dgv1.AllowUserToAddRows = False
       Me.dgv1.AllowUserToResizeColumns = False
       Me.dgv1.AllowUserToResizeRows = False
       DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue
       DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
       DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow
       DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Brown
       Me.dgv1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
       Me.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
       Me.dgv1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
       Me.dgv1.BackgroundColor = System.Drawing.Color.PeachPuff
       Me.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.None
       DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
       DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold
       DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
       DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
       DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
       DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
       Me.dgv1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
       Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
       DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
       DataGridViewCellStyle3.BackColor = System.Drawing.Color.Lavender
       DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
       DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Beige
       DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Brown
       DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
       Me.dgv1.DefaultCellStyle = DataGridViewCellStyle3
       Me.dgv1.GridColor = System.Drawing.Color.MediumPurple
       Me.dgv1.Location = New System.Drawing.Point(15, 83)
       Me.dgv1.Name = "dgv1"
       Me.dgv1.ReadOnly = True
       Me.dgv1.ShowCellErrors = False
       Me.dgv1.ShowRowErrors = False
       Me.dgv1.Size = New System.Drawing.Size(986, 457)
       Me.dgv1.StandardTab = True
       Me.dgv1.TabIndex = 562
       '
       'lblid_pk
       '
       Me.lblid_pk.AutoSize = True
       Me.lblid_pk.BackColor = System.Drawing.Color.Red
       Me.lblid_pk.Location = New System.Drawing.Point(21, 94)
       Me.lblid_pk.Name = "lblid_pk"
       Me.lblid_pk.Size = New System.Drawing.Size(13, 13)
       Me.lblid_pk.TabIndex = 565
       Me.lblid_pk.Text = "0"
       Me.lblid_pk.Visible = False
       '
       'frmAbmTipo_hora
       '
       Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
       Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
       Me.ClientSize = New System.Drawing.Size(1016, 734)
       Me.Controls.Add(Me.txtBuscar)
       Me.Controls.Add(Me.GroupBox1)
       Me.Controls.Add(Me.lblconsultar)
       Me.Controls.Add(Me.lblTitulo)
       Me.Controls.Add(Me.lblid_pk)
       Me.Controls.Add(Me.dgv1)
       Me.Name = "frmAbmTipo_hora"
       Me.Text = "frmAbmTipo_hora"
       Me.GroupBox1.ResumeLayout(False)
       CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
       Me.ResumeLayout(False)
       Me.PerformLayout()

   End Sub
   Protected WithEvents txtBuscar As System.Windows.Forms.TextBox
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents btnAyuda As System.Windows.Forms.Button
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnBorrar As System.Windows.Forms.Button
   Protected WithEvents btnModificar As System.Windows.Forms.Button
   Protected WithEvents btnAgregar As System.Windows.Forms.Button
   Protected WithEvents lblconsultar As System.Windows.Forms.Label
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
   Protected WithEvents lblTitulo As System.Windows.Forms.Label
   Protected WithEvents dgv1 As System.Windows.Forms.DataGridView
   Protected WithEvents lblid_pk As System.Windows.Forms.Label
End Class

