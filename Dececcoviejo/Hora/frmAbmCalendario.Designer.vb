<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbmCalendario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbmCalendario))
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.lblid_pk = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbAnio = New System.Windows.Forms.ComboBox()
        Me.mcFecha = New System.Windows.Forms.MonthCalendar()
        Me.lblid_dia = New System.Windows.Forms.Label()
        Me.cmbdia = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_dia = New System.Windows.Forms.Label()
        Me.dgvCambio = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnActualizarCalendario = New System.Windows.Forms.Button()
        Me.btnAgregarTodo = New System.Windows.Forms.Button()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCambio, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnSalir.Location = New System.Drawing.Point(918, 651)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(86, 71)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTitulo.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.Black
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
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Brown
        Me.dgv1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Brown
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv1.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgv1.GridColor = System.Drawing.Color.MediumPurple
        Me.dgv1.Location = New System.Drawing.Point(15, 83)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.ShowCellErrors = False
        Me.dgv1.ShowRowErrors = False
        Me.dgv1.Size = New System.Drawing.Size(364, 639)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 569
        Me.Label1.Text = "Año"
        '
        'cmbAnio
        '
        Me.cmbAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAnio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAnio.FormattingEnabled = True
        Me.cmbAnio.Items.AddRange(New Object() {"2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.cmbAnio.Location = New System.Drawing.Point(63, 22)
        Me.cmbAnio.Name = "cmbAnio"
        Me.cmbAnio.Size = New System.Drawing.Size(147, 33)
        Me.cmbAnio.TabIndex = 570
        '
        'mcFecha
        '
        Me.mcFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcFecha.Location = New System.Drawing.Point(406, 83)
        Me.mcFecha.Name = "mcFecha"
        Me.mcFecha.TabIndex = 571
        '
        'lblid_dia
        '
        Me.lblid_dia.AutoSize = True
        Me.lblid_dia.BackColor = System.Drawing.Color.Red
        Me.lblid_dia.Location = New System.Drawing.Point(645, 55)
        Me.lblid_dia.Name = "lblid_dia"
        Me.lblid_dia.Size = New System.Drawing.Size(13, 13)
        Me.lblid_dia.TabIndex = 576
        Me.lblid_dia.Text = "0"
        Me.lblid_dia.Visible = False
        '
        'cmbdia
        '
        Me.cmbdia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbdia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbdia.FormattingEnabled = True
        Me.cmbdia.Location = New System.Drawing.Point(436, 55)
        Me.cmbdia.Name = "cmbdia"
        Me.cmbdia.Size = New System.Drawing.Size(301, 21)
        Me.cmbdia.TabIndex = 574
        '
        'etiquetaid_dia
        '
        Me.etiquetaid_dia.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaid_dia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_dia.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_dia.Location = New System.Drawing.Point(406, 53)
        Me.etiquetaid_dia.Name = "etiquetaid_dia"
        Me.etiquetaid_dia.Size = New System.Drawing.Size(38, 21)
        Me.etiquetaid_dia.TabIndex = 577
        Me.etiquetaid_dia.Text = "Dia"
        Me.etiquetaid_dia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvCambio
        '
        Me.dgvCambio.AllowUserToAddRows = False
        Me.dgvCambio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCambio.Location = New System.Drawing.Point(406, 302)
        Me.dgvCambio.Name = "dgvCambio"
        Me.dgvCambio.ReadOnly = True
        Me.dgvCambio.Size = New System.Drawing.Size(331, 375)
        Me.dgvCambio.TabIndex = 578
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(407, 265)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(58, 24)
        Me.btnAdd.TabIndex = 573
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnActualizarCalendario
        '
        Me.btnActualizarCalendario.Location = New System.Drawing.Point(406, 683)
        Me.btnActualizarCalendario.Name = "btnActualizarCalendario"
        Me.btnActualizarCalendario.Size = New System.Drawing.Size(130, 39)
        Me.btnActualizarCalendario.TabIndex = 579
        Me.btnActualizarCalendario.Text = "Actualizar Calendario General"
        Me.btnActualizarCalendario.UseVisualStyleBackColor = True
        '
        'btnAgregarTodo
        '
        Me.btnAgregarTodo.Location = New System.Drawing.Point(607, 683)
        Me.btnAgregarTodo.Name = "btnAgregarTodo"
        Me.btnAgregarTodo.Size = New System.Drawing.Size(130, 39)
        Me.btnAgregarTodo.TabIndex = 580
        Me.btnAgregarTodo.Text = "Agregar Calendario a Todos"
        Me.btnAgregarTodo.UseVisualStyleBackColor = True
        '
        'frmAbmCalendario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 734)
        Me.Controls.Add(Me.btnAgregarTodo)
        Me.Controls.Add(Me.btnActualizarCalendario)
        Me.Controls.Add(Me.dgvCambio)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblid_dia)
        Me.Controls.Add(Me.cmbdia)
        Me.Controls.Add(Me.etiquetaid_dia)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.mcFecha)
        Me.Controls.Add(Me.cmbAnio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lblid_pk)
        Me.Controls.Add(Me.dgv1)
        Me.Name = "frmAbmCalendario"
        Me.Text = "frmAbmCalendario"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCambio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Protected WithEvents btnSalir As System.Windows.Forms.Button
    Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
    Protected WithEvents lblTitulo As System.Windows.Forms.Label
    Protected WithEvents dgv1 As System.Windows.Forms.DataGridView
    Protected WithEvents lblid_pk As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbAnio As System.Windows.Forms.ComboBox
    Friend WithEvents mcFecha As System.Windows.Forms.MonthCalendar
    Friend WithEvents lblid_dia As System.Windows.Forms.Label
    Friend WithEvents cmbdia As System.Windows.Forms.ComboBox
    Friend WithEvents etiquetaid_dia As System.Windows.Forms.Label
    Friend WithEvents dgvCambio As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnActualizarCalendario As System.Windows.Forms.Button
    Friend WithEvents btnAgregarTodo As System.Windows.Forms.Button
End Class

