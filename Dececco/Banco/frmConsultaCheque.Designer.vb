<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaCheque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaCheque))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Btnimprime = New System.Windows.Forms.Button
        Me.lblTotal = New System.Windows.Forms.Label
        Me.txtTotalConsulta = New System.Windows.Forms.TextBox
        Me.dgv1 = New System.Windows.Forms.DataGridView
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnConsultar = New System.Windows.Forms.Button
        Me.dtpLibrado_L_D = New System.Windows.Forms.DateTimePicker
        Me.dtpLibrado_L_H = New System.Windows.Forms.DateTimePicker
        Me.dtpLibrado_P_D = New System.Windows.Forms.DateTimePicker
        Me.dtpLibrado_P_H = New System.Windows.Forms.DateTimePicker
        Me.dtpRecibido_A_H = New System.Windows.Forms.DateTimePicker
        Me.dtpRecibido_A_D = New System.Windows.Forms.DateTimePicker
        Me.dtpRecibido_R_H = New System.Windows.Forms.DateTimePicker
        Me.dtpRecibido_R_D = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblid_cheque = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtDesmarcados = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtMarcados = New System.Windows.Forms.TextBox
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btnimprime
        '
        Me.Btnimprime.BackColor = System.Drawing.Color.Gainsboro
        Me.Btnimprime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnimprime.Image = CType(resources.GetObject("Btnimprime.Image"), System.Drawing.Image)
        Me.Btnimprime.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btnimprime.Location = New System.Drawing.Point(823, 656)
        Me.Btnimprime.Name = "Btnimprime"
        Me.Btnimprime.Size = New System.Drawing.Size(80, 83)
        Me.Btnimprime.TabIndex = 15
        Me.Btnimprime.Text = "Imprimir" & vgNombreFormulario
        Me.Btnimprime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btnimprime.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotal.Location = New System.Drawing.Point(510, 677)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(219, 21)
        Me.lblTotal.TabIndex = 518
        Me.lblTotal.Text = "TOTAL"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotalConsulta
        '
        Me.txtTotalConsulta.BackColor = System.Drawing.SystemColors.Info
        Me.txtTotalConsulta.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalConsulta.ForeColor = System.Drawing.Color.Green
        Me.txtTotalConsulta.Location = New System.Drawing.Point(510, 700)
        Me.txtTotalConsulta.Name = "txtTotalConsulta"
        Me.txtTotalConsulta.Size = New System.Drawing.Size(219, 39)
        Me.txtTotalConsulta.TabIndex = 516
        Me.txtTotalConsulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToResizeColumns = False
        Me.dgv1.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightPink
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Blue
        Me.dgv1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv1.BackgroundColor = System.Drawing.Color.LightBlue
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
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Pink
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv1.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgv1.GridColor = System.Drawing.Color.MediumPurple
        Me.dgv1.Location = New System.Drawing.Point(12, 176)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.ShowCellErrors = False
        Me.dgv1.ShowRowErrors = False
        Me.dgv1.Size = New System.Drawing.Size(1004, 474)
        Me.dgv1.StandardTab = True
        Me.dgv1.TabIndex = 515
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(936, 656)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(80, 83)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.Image = CType(resources.GetObject("btnConsultar.Image"), System.Drawing.Image)
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnConsultar.Location = New System.Drawing.Point(735, 656)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(80, 83)
        Me.btnConsultar.TabIndex = 13
        Me.btnConsultar.Text = "&Consultar"
        Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'dtpLibrado_L_D
        '
        Me.dtpLibrado_L_D.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpLibrado_L_D.Location = New System.Drawing.Point(143, 23)
        Me.dtpLibrado_L_D.Name = "dtpLibrado_L_D"
        Me.dtpLibrado_L_D.Size = New System.Drawing.Size(99, 20)
        Me.dtpLibrado_L_D.TabIndex = 5
        '
        'dtpLibrado_L_H
        '
        Me.dtpLibrado_L_H.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpLibrado_L_H.Location = New System.Drawing.Point(382, 23)
        Me.dtpLibrado_L_H.Name = "dtpLibrado_L_H"
        Me.dtpLibrado_L_H.Size = New System.Drawing.Size(99, 20)
        Me.dtpLibrado_L_H.TabIndex = 6
        '
        'dtpLibrado_P_D
        '
        Me.dtpLibrado_P_D.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpLibrado_P_D.Location = New System.Drawing.Point(641, 23)
        Me.dtpLibrado_P_D.Name = "dtpLibrado_P_D"
        Me.dtpLibrado_P_D.Size = New System.Drawing.Size(99, 20)
        Me.dtpLibrado_P_D.TabIndex = 7
        '
        'dtpLibrado_P_H
        '
        Me.dtpLibrado_P_H.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpLibrado_P_H.Location = New System.Drawing.Point(897, 23)
        Me.dtpLibrado_P_H.Name = "dtpLibrado_P_H"
        Me.dtpLibrado_P_H.Size = New System.Drawing.Size(99, 20)
        Me.dtpLibrado_P_H.TabIndex = 8
        '
        'dtpRecibido_A_H
        '
        Me.dtpRecibido_A_H.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRecibido_A_H.Location = New System.Drawing.Point(897, 25)
        Me.dtpRecibido_A_H.Name = "dtpRecibido_A_H"
        Me.dtpRecibido_A_H.Size = New System.Drawing.Size(99, 20)
        Me.dtpRecibido_A_H.TabIndex = 12
        '
        'dtpRecibido_A_D
        '
        Me.dtpRecibido_A_D.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRecibido_A_D.Location = New System.Drawing.Point(641, 25)
        Me.dtpRecibido_A_D.Name = "dtpRecibido_A_D"
        Me.dtpRecibido_A_D.Size = New System.Drawing.Size(99, 20)
        Me.dtpRecibido_A_D.TabIndex = 11
        '
        'dtpRecibido_R_H
        '
        Me.dtpRecibido_R_H.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRecibido_R_H.Location = New System.Drawing.Point(382, 25)
        Me.dtpRecibido_R_H.Name = "dtpRecibido_R_H"
        Me.dtpRecibido_R_H.Size = New System.Drawing.Size(99, 20)
        Me.dtpRecibido_R_H.TabIndex = 10
        '
        'dtpRecibido_R_D
        '
        Me.dtpRecibido_R_D.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRecibido_R_D.Location = New System.Drawing.Point(143, 25)
        Me.dtpRecibido_R_D.Name = "dtpRecibido_R_D"
        Me.dtpRecibido_R_D.Size = New System.Drawing.Size(99, 20)
        Me.dtpRecibido_R_D.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 13)
        Me.Label1.TabIndex = 550
        Me.Label1.Text = "Fecha de Librado Desde"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(248, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 551
        Me.Label2.Text = "Fecha de Librado Hasta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(780, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 553
        Me.Label3.Text = "Fecha de Pago Hasta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(521, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 13)
        Me.Label4.TabIndex = 552
        Me.Label4.Text = "Fecha de Pago Desde"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(746, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 13)
        Me.Label5.TabIndex = 557
        Me.Label5.Text = "Fecha de Acreditación Hasta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(487, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 13)
        Me.Label6.TabIndex = 556
        Me.Label6.Text = "Fecha de Acreditación Desde"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(248, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 13)
        Me.Label7.TabIndex = 555
        Me.Label7.Text = "Fecha de Recibido Hasta"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Yellow
        Me.Label8.Location = New System.Drawing.Point(6, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 13)
        Me.Label8.TabIndex = 554
        Me.Label8.Text = "Fecha de Recibido Desde"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpLibrado_L_D)
        Me.GroupBox1.Controls.Add(Me.dtpLibrado_L_H)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpLibrado_P_D)
        Me.GroupBox1.Controls.Add(Me.dtpLibrado_P_H)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Yellow
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1011, 66)
        Me.GroupBox1.TabIndex = 558
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CHEQUES LIBRADOS"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpRecibido_A_H)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.dtpRecibido_R_D)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.dtpRecibido_A_D)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.dtpRecibido_R_H)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Yellow
        Me.GroupBox2.Location = New System.Drawing.Point(12, 86)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1011, 66)
        Me.GroupBox2.TabIndex = 559
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CHEQUES RECIBIDOS"
        '
        'lblid_cheque
        '
        Me.lblid_cheque.AutoSize = True
        Me.lblid_cheque.BackColor = System.Drawing.Color.Red
        Me.lblid_cheque.Location = New System.Drawing.Point(18, 155)
        Me.lblid_cheque.Name = "lblid_cheque"
        Me.lblid_cheque.Size = New System.Drawing.Size(13, 13)
        Me.lblid_cheque.TabIndex = 560
        Me.lblid_cheque.Text = "0"
        Me.lblid_cheque.Visible = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(261, 677)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(219, 21)
        Me.Label9.TabIndex = 564
        Me.Label9.Text = "TOTAL DESMARCADOS"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDesmarcados
        '
        Me.txtDesmarcados.BackColor = System.Drawing.SystemColors.Info
        Me.txtDesmarcados.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesmarcados.Location = New System.Drawing.Point(261, 700)
        Me.txtDesmarcados.Name = "txtDesmarcados"
        Me.txtDesmarcados.Size = New System.Drawing.Size(219, 39)
        Me.txtDesmarcados.TabIndex = 563
        Me.txtDesmarcados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(12, 677)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(219, 21)
        Me.Label10.TabIndex = 566
        Me.Label10.Text = "TOTAL MARCADOS"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMarcados
        '
        Me.txtMarcados.BackColor = System.Drawing.SystemColors.Info
        Me.txtMarcados.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarcados.ForeColor = System.Drawing.Color.Blue
        Me.txtMarcados.Location = New System.Drawing.Point(12, 700)
        Me.txtMarcados.Name = "txtMarcados"
        Me.txtMarcados.Size = New System.Drawing.Size(219, 39)
        Me.txtMarcados.TabIndex = 565
        Me.txtMarcados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmConsultaCheque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(1028, 746)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtMarcados)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtDesmarcados)
        Me.Controls.Add(Me.lblid_cheque)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.Btnimprime)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtTotalConsulta)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsultaCheque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Cheques en Forma Conjunta" & vgNombreFormulario
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btnimprime As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtTotalConsulta As System.Windows.Forms.TextBox
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents dtpLibrado_L_D As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpLibrado_L_H As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpLibrado_P_D As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpLibrado_P_H As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpRecibido_A_H As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpRecibido_A_D As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpRecibido_R_H As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpRecibido_R_D As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblid_cheque As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDesmarcados As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtMarcados As System.Windows.Forms.TextBox
End Class
