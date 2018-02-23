<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleOrden_compra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleOrden_compra))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.lblid_Orden_compra = New System.Windows.Forms.Label()
        Me.lblid_pk = New System.Windows.Forms.Label()
        Me.dtpfecha_orden_compra = New System.Windows.Forms.DateTimePicker()
        Me.etiquetafecha_orden_compra = New System.Windows.Forms.Label()
        Me.lblid_cliente = New System.Windows.Forms.Label()
        Me.cmbcliente = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_cliente = New System.Windows.Forms.Label()
        Me.txtobservacion = New System.Windows.Forms.TextBox()
        Me.etiquetaobservacion = New System.Windows.Forms.Label()
        Me.txtacepto_orden_compra = New System.Windows.Forms.TextBox()
        Me.etiquetaacepto_orden_compra = New System.Windows.Forms.Label()
        Me.txttotal_orden_compra = New System.Windows.Forms.TextBox()
        Me.etiquetatotal_orden_compra = New System.Windows.Forms.Label()
        Me.lblid_usuario = New System.Windows.Forms.Label()
        Me.lblid_presupuesto = New System.Windows.Forms.Label()
        Me.btnBuscapresupuesto = New System.Windows.Forms.Button()
        Me.cmbpresupuesto = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_presupuesto = New System.Windows.Forms.Label()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(28, 577)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 49)
        Me.btnSalir.TabIndex = 61
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(28, 512)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 49)
        Me.btnGuardar.TabIndex = 60
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregar.Location = New System.Drawing.Point(28, 296)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 49)
        Me.btnAgregar.TabIndex = 50
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar.Location = New System.Drawing.Point(28, 366)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 49)
        Me.btnModificar.TabIndex = 51
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), System.Drawing.Image)
        Me.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBorrar.Location = New System.Drawing.Point(28, 437)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 49)
        Me.btnBorrar.TabIndex = 52
        Me.btnBorrar.Text = "&Borrar"
        Me.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBorrar.UseVisualStyleBackColor = True
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
        Me.dgv1.BackgroundColor = System.Drawing.Color.SkyBlue
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
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Brown
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv1.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv1.GridColor = System.Drawing.Color.MediumPurple
        Me.dgv1.Location = New System.Drawing.Point(135, 296)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.ShowCellErrors = False
        Me.dgv1.ShowRowErrors = False
        Me.dgv1.Size = New System.Drawing.Size(845, 330)
        Me.dgv1.StandardTab = True
        Me.dgv1.TabIndex = 500
        '
        'lblid_Orden_compra
        '
        Me.lblid_Orden_compra.AutoSize = True
        Me.lblid_Orden_compra.BackColor = System.Drawing.Color.Red
        Me.lblid_Orden_compra.Location = New System.Drawing.Point(182, 5)
        Me.lblid_Orden_compra.Name = "lblid_Orden_compra"
        Me.lblid_Orden_compra.Size = New System.Drawing.Size(13, 13)
        Me.lblid_Orden_compra.TabIndex = 565
        Me.lblid_Orden_compra.Text = "0"
        Me.lblid_Orden_compra.Visible = False
        '
        'lblid_pk
        '
        Me.lblid_pk.AutoSize = True
        Me.lblid_pk.BackColor = System.Drawing.Color.Red
        Me.lblid_pk.Location = New System.Drawing.Point(158, 309)
        Me.lblid_pk.Name = "lblid_pk"
        Me.lblid_pk.Size = New System.Drawing.Size(13, 13)
        Me.lblid_pk.TabIndex = 565
        Me.lblid_pk.Text = "0"
        Me.lblid_pk.Visible = False
        '
        'dtpfecha_orden_compra
        '
        Me.dtpfecha_orden_compra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha_orden_compra.Location = New System.Drawing.Point(161, 70)
        Me.dtpfecha_orden_compra.Name = "dtpfecha_orden_compra"
        Me.dtpfecha_orden_compra.Size = New System.Drawing.Size(93, 20)
        Me.dtpfecha_orden_compra.TabIndex = 4
        '
        'etiquetafecha_orden_compra
        '
        Me.etiquetafecha_orden_compra.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetafecha_orden_compra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetafecha_orden_compra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetafecha_orden_compra.ForeColor = System.Drawing.Color.Black
        Me.etiquetafecha_orden_compra.Location = New System.Drawing.Point(28, 69)
        Me.etiquetafecha_orden_compra.Name = "etiquetafecha_orden_compra"
        Me.etiquetafecha_orden_compra.Size = New System.Drawing.Size(127, 21)
        Me.etiquetafecha_orden_compra.TabIndex = 500
        Me.etiquetafecha_orden_compra.Text = "Fecha_orden_compra"
        Me.etiquetafecha_orden_compra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_cliente
        '
        Me.lblid_cliente.AutoSize = True
        Me.lblid_cliente.BackColor = System.Drawing.Color.Red
        Me.lblid_cliente.Location = New System.Drawing.Point(370, 69)
        Me.lblid_cliente.Name = "lblid_cliente"
        Me.lblid_cliente.Size = New System.Drawing.Size(13, 13)
        Me.lblid_cliente.TabIndex = 501
        Me.lblid_cliente.Text = "0"
        Me.lblid_cliente.Visible = False
        '
        'cmbcliente
        '
        Me.cmbcliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbcliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbcliente.Enabled = False
        Me.cmbcliente.FormattingEnabled = True
        Me.cmbcliente.Location = New System.Drawing.Point(161, 27)
        Me.cmbcliente.Name = "cmbcliente"
        Me.cmbcliente.Size = New System.Drawing.Size(329, 21)
        Me.cmbcliente.TabIndex = 5
        '
        'etiquetaid_cliente
        '
        Me.etiquetaid_cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_cliente.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_cliente.Location = New System.Drawing.Point(28, 26)
        Me.etiquetaid_cliente.Name = "etiquetaid_cliente"
        Me.etiquetaid_cliente.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_cliente.TabIndex = 502
        Me.etiquetaid_cliente.Text = "Cliente"
        Me.etiquetaid_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtobservacion
        '
        Me.txtobservacion.BackColor = System.Drawing.Color.White
        Me.txtobservacion.Location = New System.Drawing.Point(701, 27)
        Me.txtobservacion.MaxLength = 5000
        Me.txtobservacion.Multiline = True
        Me.txtobservacion.Name = "txtobservacion"
        Me.txtobservacion.Size = New System.Drawing.Size(294, 130)
        Me.txtobservacion.TabIndex = 6
        '
        'etiquetaobservacion
        '
        Me.etiquetaobservacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaobservacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaobservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaobservacion.ForeColor = System.Drawing.Color.Black
        Me.etiquetaobservacion.Location = New System.Drawing.Point(568, 27)
        Me.etiquetaobservacion.Name = "etiquetaobservacion"
        Me.etiquetaobservacion.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaobservacion.TabIndex = 503
        Me.etiquetaobservacion.Text = "Observacion"
        Me.etiquetaobservacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtacepto_orden_compra
        '
        Me.txtacepto_orden_compra.BackColor = System.Drawing.Color.White
        Me.txtacepto_orden_compra.Location = New System.Drawing.Point(161, 123)
        Me.txtacepto_orden_compra.MaxLength = 50
        Me.txtacepto_orden_compra.Name = "txtacepto_orden_compra"
        Me.txtacepto_orden_compra.Size = New System.Drawing.Size(385, 20)
        Me.txtacepto_orden_compra.TabIndex = 7
        '
        'etiquetaacepto_orden_compra
        '
        Me.etiquetaacepto_orden_compra.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaacepto_orden_compra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaacepto_orden_compra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaacepto_orden_compra.ForeColor = System.Drawing.Color.Black
        Me.etiquetaacepto_orden_compra.Location = New System.Drawing.Point(28, 121)
        Me.etiquetaacepto_orden_compra.Name = "etiquetaacepto_orden_compra"
        Me.etiquetaacepto_orden_compra.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaacepto_orden_compra.TabIndex = 504
        Me.etiquetaacepto_orden_compra.Text = "Acepto_orden_compra"
        Me.etiquetaacepto_orden_compra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txttotal_orden_compra
        '
        Me.txttotal_orden_compra.BackColor = System.Drawing.Color.White
        Me.txttotal_orden_compra.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal_orden_compra.ForeColor = System.Drawing.Color.Blue
        Me.txttotal_orden_compra.Location = New System.Drawing.Point(161, 168)
        Me.txttotal_orden_compra.MaxLength = 50
        Me.txttotal_orden_compra.Name = "txttotal_orden_compra"
        Me.txttotal_orden_compra.Size = New System.Drawing.Size(222, 31)
        Me.txttotal_orden_compra.TabIndex = 8
        Me.txttotal_orden_compra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetatotal_orden_compra
        '
        Me.etiquetatotal_orden_compra.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetatotal_orden_compra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetatotal_orden_compra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetatotal_orden_compra.ForeColor = System.Drawing.Color.Black
        Me.etiquetatotal_orden_compra.Location = New System.Drawing.Point(28, 168)
        Me.etiquetatotal_orden_compra.Name = "etiquetatotal_orden_compra"
        Me.etiquetatotal_orden_compra.Size = New System.Drawing.Size(127, 21)
        Me.etiquetatotal_orden_compra.TabIndex = 505
        Me.etiquetatotal_orden_compra.Text = "Total_orden_compra"
        Me.etiquetatotal_orden_compra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_usuario
        '
        Me.lblid_usuario.AutoSize = True
        Me.lblid_usuario.BackColor = System.Drawing.Color.Red
        Me.lblid_usuario.Location = New System.Drawing.Point(336, 264)
        Me.lblid_usuario.Name = "lblid_usuario"
        Me.lblid_usuario.Size = New System.Drawing.Size(13, 13)
        Me.lblid_usuario.TabIndex = 506
        Me.lblid_usuario.Text = "0"
        Me.lblid_usuario.Visible = False
        '
        'lblid_presupuesto
        '
        Me.lblid_presupuesto.AutoSize = True
        Me.lblid_presupuesto.BackColor = System.Drawing.Color.Red
        Me.lblid_presupuesto.Location = New System.Drawing.Point(370, 220)
        Me.lblid_presupuesto.Name = "lblid_presupuesto"
        Me.lblid_presupuesto.Size = New System.Drawing.Size(13, 13)
        Me.lblid_presupuesto.TabIndex = 508
        Me.lblid_presupuesto.Text = "0"
        Me.lblid_presupuesto.Visible = False
        '
        'btnBuscapresupuesto
        '
        Me.btnBuscapresupuesto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscapresupuesto.Image = CType(resources.GetObject("btnBuscapresupuesto.Image"), System.Drawing.Image)
        Me.btnBuscapresupuesto.Location = New System.Drawing.Point(506, 218)
        Me.btnBuscapresupuesto.Name = "btnBuscapresupuesto"
        Me.btnBuscapresupuesto.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscapresupuesto.TabIndex = 32
        Me.btnBuscapresupuesto.UseVisualStyleBackColor = True
        '
        'cmbpresupuesto
        '
        Me.cmbpresupuesto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbpresupuesto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbpresupuesto.FormattingEnabled = True
        Me.cmbpresupuesto.Location = New System.Drawing.Point(161, 218)
        Me.cmbpresupuesto.Name = "cmbpresupuesto"
        Me.cmbpresupuesto.Size = New System.Drawing.Size(329, 21)
        Me.cmbpresupuesto.TabIndex = 10
        '
        'etiquetaid_presupuesto
        '
        Me.etiquetaid_presupuesto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_presupuesto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_presupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_presupuesto.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_presupuesto.Location = New System.Drawing.Point(28, 216)
        Me.etiquetaid_presupuesto.Name = "etiquetaid_presupuesto"
        Me.etiquetaid_presupuesto.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_presupuesto.TabIndex = 509
        Me.etiquetaid_presupuesto.Text = "Presupuesto"
        Me.etiquetaid_presupuesto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmDetalleOrden_compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 750)
        Me.Controls.Add(Me.dtpfecha_orden_compra)
        Me.Controls.Add(Me.etiquetafecha_orden_compra)
        Me.Controls.Add(Me.lblid_cliente)
        Me.Controls.Add(Me.cmbcliente)
        Me.Controls.Add(Me.etiquetaid_cliente)
        Me.Controls.Add(Me.txtobservacion)
        Me.Controls.Add(Me.etiquetaobservacion)
        Me.Controls.Add(Me.txtacepto_orden_compra)
        Me.Controls.Add(Me.etiquetaacepto_orden_compra)
        Me.Controls.Add(Me.txttotal_orden_compra)
        Me.Controls.Add(Me.etiquetatotal_orden_compra)
        Me.Controls.Add(Me.lblid_usuario)
        Me.Controls.Add(Me.lblid_presupuesto)
        Me.Controls.Add(Me.btnBuscapresupuesto)
        Me.Controls.Add(Me.cmbpresupuesto)
        Me.Controls.Add(Me.etiquetaid_presupuesto)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.lblid_pk)
        Me.Controls.Add(Me.lblid_Orden_compra)
        Me.Name = "frmDetalleOrden_compra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleOrden_compra"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

   Protected WithEvents dtpfecha_orden_compra As System.Windows.Forms.DateTimePicker
   Friend WithEvents etiquetafecha_orden_compra As System.Windows.Forms.Label
   Friend WithEvents lblid_cliente As System.Windows.Forms.Label
    Friend WithEvents cmbcliente As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_cliente As System.Windows.Forms.Label
   Protected WithEvents txtobservacion As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaobservacion As System.Windows.Forms.Label
   Protected WithEvents txtacepto_orden_compra As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaacepto_orden_compra As System.Windows.Forms.Label
   Protected WithEvents txttotal_orden_compra As System.Windows.Forms.TextBox
   Friend WithEvents etiquetatotal_orden_compra As System.Windows.Forms.Label
   Friend WithEvents lblid_usuario As System.Windows.Forms.Label
   Friend WithEvents btnBuscausuario As System.Windows.Forms.Button
   Friend WithEvents cmbusuario As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_usuario As System.Windows.Forms.Label
   Friend WithEvents lblid_presupuesto As System.Windows.Forms.Label
   Friend WithEvents btnBuscapresupuesto As System.Windows.Forms.Button
   Friend WithEvents cmbpresupuesto As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_presupuesto As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
    Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
   Protected WithEvents btnBorrar As System.Windows.Forms.Button
   Protected WithEvents btnModificar As System.Windows.Forms.Button
   Protected WithEvents btnAgregar As System.Windows.Forms.Button
   Protected WithEvents dgv1 As System.Windows.Forms.DataGridView
   Friend WithEvents lblid_pk As System.Windows.Forms.Label
   Friend WithEvents lblid_Orden_compra As System.Windows.Forms.Label
End Class

