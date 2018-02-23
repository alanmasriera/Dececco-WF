<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaBancos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaBancos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btnSalir = New System.Windows.Forms.Button
        Me.DataGridView9 = New System.Windows.Forms.DataGridView
        Me.txtTotalConsulta = New System.Windows.Forms.TextBox
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.Btnimprime = New System.Windows.Forms.Button
        CType(Me.DataGridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(926, 655)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(93, 79)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'DataGridView9
        '
        Me.DataGridView9.AllowUserToAddRows = False
        Me.DataGridView9.AllowUserToResizeColumns = False
        Me.DataGridView9.AllowUserToResizeRows = False
        Me.DataGridView9.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView9.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView9.BackgroundColor = System.Drawing.Color.LightBlue
        Me.DataGridView9.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView9.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Pink
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView9.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView9.GridColor = System.Drawing.Color.MediumPurple
        Me.DataGridView9.Location = New System.Drawing.Point(12, 78)
        Me.DataGridView9.Name = "DataGridView9"
        Me.DataGridView9.ReadOnly = True
        Me.DataGridView9.ShowCellErrors = False
        Me.DataGridView9.ShowRowErrors = False
        Me.DataGridView9.Size = New System.Drawing.Size(1004, 545)
        Me.DataGridView9.StandardTab = True
        Me.DataGridView9.TabIndex = 10
        '
        'txtTotalConsulta
        '
        Me.txtTotalConsulta.BackColor = System.Drawing.SystemColors.Info
        Me.txtTotalConsulta.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalConsulta.ForeColor = System.Drawing.Color.Blue
        Me.txtTotalConsulta.Location = New System.Drawing.Point(12, 695)
        Me.txtTotalConsulta.Name = "txtTotalConsulta"
        Me.txtTotalConsulta.Size = New System.Drawing.Size(260, 39)
        Me.txtTotalConsulta.TabIndex = 12
        Me.txtTotalConsulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Gold
        Me.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(145, 19)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(738, 35)
        Me.lblTitulo.TabIndex = 409
        Me.lblTitulo.Text = "CONSULTA"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotal.Location = New System.Drawing.Point(12, 655)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(66, 21)
        Me.lblTotal.TabIndex = 512
        Me.lblTotal.Text = "TOTAL"
        '
        'Btnimprime
        '
        Me.Btnimprime.BackColor = System.Drawing.Color.Gainsboro
        Me.Btnimprime.Enabled = False
        Me.Btnimprime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnimprime.Image = CType(resources.GetObject("Btnimprime.Image"), System.Drawing.Image)
        Me.Btnimprime.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btnimprime.Location = New System.Drawing.Point(805, 655)
        Me.Btnimprime.Name = "Btnimprime"
        Me.Btnimprime.Size = New System.Drawing.Size(93, 79)
        Me.Btnimprime.TabIndex = 513
        Me.Btnimprime.Text = "&Imprimir"
        Me.Btnimprime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btnimprime.UseVisualStyleBackColor = True
        '
        'frmConsultaBancos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(1028, 746)
        Me.Controls.Add(Me.Btnimprime)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.txtTotalConsulta)
        Me.Controls.Add(Me.DataGridView9)
        Me.Controls.Add(Me.btnSalir)
        Me.Name = "frmConsultaBancos"
        Me.Text = "CONSULTA" & vgNombreFormulario
        CType(Me.DataGridView9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents DataGridView9 As System.Windows.Forms.DataGridView
    Friend WithEvents txtTotalConsulta As System.Windows.Forms.TextBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Btnimprime As System.Windows.Forms.Button
End Class
