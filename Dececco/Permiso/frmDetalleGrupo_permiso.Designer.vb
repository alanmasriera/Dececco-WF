<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleGrupo_permiso
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleGrupo_permiso))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.lblid_grupo_usuario = New System.Windows.Forms.Label
        Me.btnBuscaGrupo_usuario = New System.Windows.Forms.Button
        Me.cmbGrupo_usuario = New System.Windows.Forms.ComboBox
        Me.label1 = New System.Windows.Forms.Label
        Me.lblid_pk = New System.Windows.Forms.Label
        Me.dgv1 = New System.Windows.Forms.DataGridView
        Me.btnSalir = New System.Windows.Forms.Button
        Me.ttGrupo_usuario = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttSalir = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnLlenar_permiso = New System.Windows.Forms.Button
        Me.btnCheckAll = New System.Windows.Forms.Button
        Me.btnUnCheckAll = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnAyuda = New System.Windows.Forms.Button
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblid_grupo_usuario
        '
        Me.lblid_grupo_usuario.AutoSize = True
        Me.lblid_grupo_usuario.BackColor = System.Drawing.Color.Red
        Me.lblid_grupo_usuario.Location = New System.Drawing.Point(345, 30)
        Me.lblid_grupo_usuario.Name = "lblid_grupo_usuario"
        Me.lblid_grupo_usuario.Size = New System.Drawing.Size(13, 13)
        Me.lblid_grupo_usuario.TabIndex = 570
        Me.lblid_grupo_usuario.Text = "0"
        Me.lblid_grupo_usuario.Visible = False
        '
        'btnBuscaGrupo_usuario
        '
        Me.btnBuscaGrupo_usuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaGrupo_usuario.Image = CType(resources.GetObject("btnBuscaGrupo_usuario.Image"), System.Drawing.Image)
        Me.btnBuscaGrupo_usuario.Location = New System.Drawing.Point(454, 25)
        Me.btnBuscaGrupo_usuario.Name = "btnBuscaGrupo_usuario"
        Me.btnBuscaGrupo_usuario.Size = New System.Drawing.Size(41, 36)
        Me.btnBuscaGrupo_usuario.TabIndex = 569
        Me.btnBuscaGrupo_usuario.UseVisualStyleBackColor = True
        '
        'cmbGrupo_usuario
        '
        Me.cmbGrupo_usuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbGrupo_usuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbGrupo_usuario.FormattingEnabled = True
        Me.cmbGrupo_usuario.Location = New System.Drawing.Point(136, 27)
        Me.cmbGrupo_usuario.Name = "cmbGrupo_usuario"
        Me.cmbGrupo_usuario.Size = New System.Drawing.Size(299, 21)
        Me.cmbGrupo_usuario.TabIndex = 567
        '
        'label1
        '
        Me.label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Black
        Me.label1.Location = New System.Drawing.Point(20, 25)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(101, 21)
        Me.label1.TabIndex = 568
        Me.label1.Text = "Grupo"
        '
        'lblid_pk
        '
        Me.lblid_pk.AutoSize = True
        Me.lblid_pk.BackColor = System.Drawing.Color.Red
        Me.lblid_pk.Location = New System.Drawing.Point(153, 88)
        Me.lblid_pk.Name = "lblid_pk"
        Me.lblid_pk.Size = New System.Drawing.Size(13, 13)
        Me.lblid_pk.TabIndex = 572
        Me.lblid_pk.Text = "0"
        Me.lblid_pk.Visible = False
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToResizeColumns = False
        Me.dgv1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Brown
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv1.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv1.GridColor = System.Drawing.Color.MediumPurple
        Me.dgv1.Location = New System.Drawing.Point(82, 79)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.RowHeadersVisible = False
        Me.dgv1.ShowCellErrors = False
        Me.dgv1.ShowRowErrors = False
        Me.dgv1.Size = New System.Drawing.Size(413, 603)
        Me.dgv1.StandardTab = True
        Me.dgv1.TabIndex = 571
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(515, 611)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(90, 71)
        Me.btnSalir.TabIndex = 573
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnLlenar_permiso
        '
        Me.btnLlenar_permiso.Image = CType(resources.GetObject("btnLlenar_permiso.Image"), System.Drawing.Image)
        Me.btnLlenar_permiso.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLlenar_permiso.Location = New System.Drawing.Point(515, 164)
        Me.btnLlenar_permiso.Name = "btnLlenar_permiso"
        Me.btnLlenar_permiso.Size = New System.Drawing.Size(90, 90)
        Me.btnLlenar_permiso.TabIndex = 574
        Me.btnLlenar_permiso.Text = "Llenar Permisos"
        Me.btnLlenar_permiso.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLlenar_permiso.UseVisualStyleBackColor = True
        '
        'btnCheckAll
        '
        Me.btnCheckAll.Image = CType(resources.GetObject("btnCheckAll.Image"), System.Drawing.Image)
        Me.btnCheckAll.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCheckAll.Location = New System.Drawing.Point(515, 277)
        Me.btnCheckAll.Name = "btnCheckAll"
        Me.btnCheckAll.Size = New System.Drawing.Size(90, 71)
        Me.btnCheckAll.TabIndex = 575
        Me.btnCheckAll.Text = "Permitir Todos"
        Me.btnCheckAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCheckAll.UseVisualStyleBackColor = True
        '
        'btnUnCheckAll
        '
        Me.btnUnCheckAll.Image = CType(resources.GetObject("btnUnCheckAll.Image"), System.Drawing.Image)
        Me.btnUnCheckAll.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUnCheckAll.Location = New System.Drawing.Point(515, 369)
        Me.btnUnCheckAll.Name = "btnUnCheckAll"
        Me.btnUnCheckAll.Size = New System.Drawing.Size(90, 71)
        Me.btnUnCheckAll.TabIndex = 576
        Me.btnUnCheckAll.Text = "Denegar Todos"
        Me.btnUnCheckAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUnCheckAll.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(20, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 154)
        Me.Label2.TabIndex = 577
        Me.Label2.Text = "P" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "e" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "r" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "m" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "i" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "s" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "o" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "s"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAyuda
        '
        Me.btnAyuda.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAyuda.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAyuda.ForeColor = System.Drawing.Color.Black
        Me.btnAyuda.Image = CType(resources.GetObject("btnAyuda.Image"), System.Drawing.Image)
        Me.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAyuda.Location = New System.Drawing.Point(515, 525)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(90, 71)
        Me.btnAyuda.TabIndex = 578
        Me.btnAyuda.Text = "A&yuda"
        Me.btnAyuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAyuda.UseVisualStyleBackColor = True
        '
        'frmDetalleGrupo_permiso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(631, 736)
        Me.Controls.Add(Me.btnAyuda)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnUnCheckAll)
        Me.Controls.Add(Me.btnCheckAll)
        Me.Controls.Add(Me.btnLlenar_permiso)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblid_pk)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.lblid_grupo_usuario)
        Me.Controls.Add(Me.btnBuscaGrupo_usuario)
        Me.Controls.Add(Me.cmbGrupo_usuario)
        Me.Controls.Add(Me.label1)
        Me.Name = "frmDetalleGrupo_permiso"
        Me.Text = "frmDetalleGrupo_permiso"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblid_grupo_usuario As System.Windows.Forms.Label
    Friend WithEvents btnBuscaGrupo_usuario As System.Windows.Forms.Button
    Friend WithEvents cmbGrupo_usuario As System.Windows.Forms.ComboBox
    Friend WithEvents label1 As System.Windows.Forms.Label
    Protected WithEvents lblid_pk As System.Windows.Forms.Label
    Protected WithEvents dgv1 As System.Windows.Forms.DataGridView
    Protected WithEvents btnSalir As System.Windows.Forms.Button
    Protected WithEvents ttGrupo_usuario As System.Windows.Forms.ToolTip
    Protected WithEvents ttSalir As System.Windows.Forms.ToolTip
    Friend WithEvents btnLlenar_permiso As System.Windows.Forms.Button
    Friend WithEvents btnCheckAll As System.Windows.Forms.Button
    Friend WithEvents btnUnCheckAll As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Protected WithEvents btnAyuda As System.Windows.Forms.Button
End Class
