<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControlActividad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmControlActividad))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.panel_control_1 = New System.Windows.Forms.Panel()
        Me.btn_nueva_voz = New System.Windows.Forms.Button()
        Me.chkNoConformidad = New System.Windows.Forms.CheckBox()
        Me.chkPedir_segundo_control = New System.Windows.Forms.CheckBox()
        Me.btnvolver2 = New System.Windows.Forms.Button()
        Me.btnAceptar2 = New System.Windows.Forms.Button()
        Me.chkCorreccion = New System.Windows.Forms.CheckBox()
        Me.txtDetalle1 = New System.Windows.Forms.TextBox()
        Me.chkNoConforme = New System.Windows.Forms.CheckBox()
        Me.cmbTipo1 = New System.Windows.Forms.ComboBox()
        Me.chkConforme = New System.Windows.Forms.CheckBox()
        Me.chkCorresponde1 = New System.Windows.Forms.CheckBox()
        Me.lblid_tipo_voz = New System.Windows.Forms.Label()
        Me.tlPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.panel_control_2 = New System.Windows.Forms.Panel()
        Me.btnVolver_2doC = New System.Windows.Forms.Button()
        Me.btnAceptar_2doC = New System.Windows.Forms.Button()
        Me.chkCorreccion2 = New System.Windows.Forms.CheckBox()
        Me.txtDetalle2 = New System.Windows.Forms.TextBox()
        Me.chkNoConforme2 = New System.Windows.Forms.CheckBox()
        Me.cmbTipo2 = New System.Windows.Forms.ComboBox()
        Me.chkConforme2 = New System.Windows.Forms.CheckBox()
        Me.chkCorresponde2 = New System.Windows.Forms.CheckBox()
        Me.panel_cadista = New System.Windows.Forms.Panel()
        Me.chkCorresp = New System.Windows.Forms.CheckBox()
        Me.lblid_cuerpo_movimiento_hora = New System.Windows.Forms.Label()
        Me.btnMenos = New System.Windows.Forms.Button()
        Me.bntMas = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnAceptar1 = New System.Windows.Forms.Button()
        Me.chkNoCorresponde = New System.Windows.Forms.CheckBox()
        Me.chkOk = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtNombre_voz = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panel_control_1.SuspendLayout()
        Me.tlPanel.SuspendLayout()
        Me.panel_control_2.SuspendLayout()
        Me.panel_cadista.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "IconFolder.png")
        Me.ImageList1.Images.SetKeyName(1, "mini_file.png")
        Me.ImageList1.Images.SetKeyName(2, "bullet-check.png")
        Me.ImageList1.Images.SetKeyName(3, "ActividadCheck.png")
        '
        'Timer1
        '
        Me.Timer1.Interval = 30000
        '
        'panel_control_1
        '
        Me.panel_control_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_control_1.Controls.Add(Me.btn_nueva_voz)
        Me.panel_control_1.Controls.Add(Me.chkNoConformidad)
        Me.panel_control_1.Controls.Add(Me.chkPedir_segundo_control)
        Me.panel_control_1.Controls.Add(Me.btnvolver2)
        Me.panel_control_1.Controls.Add(Me.btnAceptar2)
        Me.panel_control_1.Controls.Add(Me.chkCorreccion)
        Me.panel_control_1.Controls.Add(Me.txtDetalle1)
        Me.panel_control_1.Controls.Add(Me.chkNoConforme)
        Me.panel_control_1.Controls.Add(Me.cmbTipo1)
        Me.panel_control_1.Controls.Add(Me.chkConforme)
        Me.panel_control_1.Controls.Add(Me.chkCorresponde1)
        Me.panel_control_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_control_1.Location = New System.Drawing.Point(483, 3)
        Me.panel_control_1.MinimumSize = New System.Drawing.Size(454, 156)
        Me.panel_control_1.Name = "panel_control_1"
        Me.panel_control_1.Size = New System.Drawing.Size(454, 156)
        Me.panel_control_1.TabIndex = 13
        '
        'btn_nueva_voz
        '
        Me.btn_nueva_voz.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_nueva_voz.Location = New System.Drawing.Point(12, 113)
        Me.btn_nueva_voz.Name = "btn_nueva_voz"
        Me.btn_nueva_voz.Size = New System.Drawing.Size(82, 23)
        Me.btn_nueva_voz.TabIndex = 536
        Me.btn_nueva_voz.Text = "Agregar Obs."
        Me.btn_nueva_voz.UseVisualStyleBackColor = True
        Me.btn_nueva_voz.Visible = False
        '
        'chkNoConformidad
        '
        Me.chkNoConformidad.AutoSize = True
        Me.chkNoConformidad.Enabled = False
        Me.chkNoConformidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNoConformidad.Location = New System.Drawing.Point(3, 56)
        Me.chkNoConformidad.Name = "chkNoConformidad"
        Me.chkNoConformidad.Size = New System.Drawing.Size(101, 17)
        Me.chkNoConformidad.TabIndex = 535
        Me.chkNoConformidad.Text = "No conformidad"
        Me.chkNoConformidad.UseVisualStyleBackColor = True
        Me.chkNoConformidad.Visible = False
        '
        'chkPedir_segundo_control
        '
        Me.chkPedir_segundo_control.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkPedir_segundo_control.AutoSize = True
        Me.chkPedir_segundo_control.Location = New System.Drawing.Point(376, 56)
        Me.chkPedir_segundo_control.Name = "chkPedir_segundo_control"
        Me.chkPedir_segundo_control.Size = New System.Drawing.Size(72, 17)
        Me.chkPedir_segundo_control.TabIndex = 534
        Me.chkPedir_segundo_control.Text = "2° Control"
        Me.chkPedir_segundo_control.UseVisualStyleBackColor = True
        Me.chkPedir_segundo_control.Visible = False
        '
        'btnvolver2
        '
        Me.btnvolver2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnvolver2.Image = CType(resources.GetObject("btnvolver2.Image"), System.Drawing.Image)
        Me.btnvolver2.Location = New System.Drawing.Point(376, 113)
        Me.btnvolver2.Name = "btnvolver2"
        Me.btnvolver2.Size = New System.Drawing.Size(32, 35)
        Me.btnvolver2.TabIndex = 533
        Me.btnvolver2.UseVisualStyleBackColor = True
        '
        'btnAceptar2
        '
        Me.btnAceptar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar2.Image = CType(resources.GetObject("btnAceptar2.Image"), System.Drawing.Image)
        Me.btnAceptar2.Location = New System.Drawing.Point(414, 112)
        Me.btnAceptar2.Name = "btnAceptar2"
        Me.btnAceptar2.Size = New System.Drawing.Size(33, 36)
        Me.btnAceptar2.TabIndex = 532
        Me.btnAceptar2.UseVisualStyleBackColor = True
        '
        'chkCorreccion
        '
        Me.chkCorreccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkCorreccion.AutoSize = True
        Me.chkCorreccion.ForeColor = System.Drawing.Color.Blue
        Me.chkCorreccion.Location = New System.Drawing.Point(376, 79)
        Me.chkCorreccion.Name = "chkCorreccion"
        Me.chkCorreccion.Size = New System.Drawing.Size(77, 17)
        Me.chkCorreccion.TabIndex = 18
        Me.chkCorreccion.Text = "Corrección"
        Me.chkCorreccion.UseVisualStyleBackColor = True
        '
        'txtDetalle1
        '
        Me.txtDetalle1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDetalle1.Enabled = False
        Me.txtDetalle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalle1.Location = New System.Drawing.Point(118, 4)
        Me.txtDetalle1.Multiline = True
        Me.txtDetalle1.Name = "txtDetalle1"
        Me.txtDetalle1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDetalle1.Size = New System.Drawing.Size(251, 145)
        Me.txtDetalle1.TabIndex = 17
        '
        'chkNoConforme
        '
        Me.chkNoConforme.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkNoConforme.AutoSize = True
        Me.chkNoConforme.Enabled = False
        Me.chkNoConforme.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNoConforme.ForeColor = System.Drawing.Color.Red
        Me.chkNoConforme.Location = New System.Drawing.Point(375, 6)
        Me.chkNoConforme.Name = "chkNoConforme"
        Me.chkNoConforme.Size = New System.Drawing.Size(36, 17)
        Me.chkNoConforme.TabIndex = 16
        Me.chkNoConforme.Text = "✘"
        Me.chkNoConforme.UseVisualStyleBackColor = True
        '
        'cmbTipo1
        '
        Me.cmbTipo1.Enabled = False
        Me.cmbTipo1.FormattingEnabled = True
        Me.cmbTipo1.Items.AddRange(New Object() {"ncm", "NCM", "obs"})
        Me.cmbTipo1.Location = New System.Drawing.Point(3, 79)
        Me.cmbTipo1.Name = "cmbTipo1"
        Me.cmbTipo1.Size = New System.Drawing.Size(109, 21)
        Me.cmbTipo1.TabIndex = 15
        Me.cmbTipo1.Visible = False
        '
        'chkConforme
        '
        Me.chkConforme.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkConforme.AutoSize = True
        Me.chkConforme.Enabled = False
        Me.chkConforme.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkConforme.ForeColor = System.Drawing.Color.Green
        Me.chkConforme.Location = New System.Drawing.Point(375, 25)
        Me.chkConforme.Name = "chkConforme"
        Me.chkConforme.Size = New System.Drawing.Size(35, 17)
        Me.chkConforme.TabIndex = 14
        Me.chkConforme.Text = "✓"
        Me.chkConforme.UseVisualStyleBackColor = True
        '
        'chkCorresponde1
        '
        Me.chkCorresponde1.AutoSize = True
        Me.chkCorresponde1.Enabled = False
        Me.chkCorresponde1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCorresponde1.ForeColor = System.Drawing.Color.Red
        Me.chkCorresponde1.Location = New System.Drawing.Point(3, 6)
        Me.chkCorresponde1.Name = "chkCorresponde1"
        Me.chkCorresponde1.Size = New System.Drawing.Size(112, 17)
        Me.chkCorresponde1.TabIndex = 13
        Me.chkCorresponde1.Text = "Si Corresponde"
        Me.chkCorresponde1.UseVisualStyleBackColor = True
        '
        'lblid_tipo_voz
        '
        Me.lblid_tipo_voz.AutoSize = True
        Me.lblid_tipo_voz.BackColor = System.Drawing.Color.Red
        Me.lblid_tipo_voz.Location = New System.Drawing.Point(81, 45)
        Me.lblid_tipo_voz.Name = "lblid_tipo_voz"
        Me.lblid_tipo_voz.Size = New System.Drawing.Size(13, 13)
        Me.lblid_tipo_voz.TabIndex = 534
        Me.lblid_tipo_voz.Text = "0"
        Me.lblid_tipo_voz.Visible = False
        '
        'tlPanel
        '
        Me.tlPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlPanel.BackColor = System.Drawing.Color.Transparent
        Me.tlPanel.ColumnCount = 3
        Me.tlPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlPanel.Controls.Add(Me.panel_control_2, 2, 0)
        Me.tlPanel.Controls.Add(Me.panel_cadista, 0, 0)
        Me.tlPanel.Controls.Add(Me.panel_control_1, 1, 0)
        Me.tlPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlPanel.Location = New System.Drawing.Point(0, 0)
        Me.tlPanel.Name = "tlPanel"
        Me.tlPanel.RowCount = 1
        Me.tlPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlPanel.Size = New System.Drawing.Size(1276, 162)
        Me.tlPanel.TabIndex = 536
        '
        'panel_control_2
        '
        Me.panel_control_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_control_2.Controls.Add(Me.btnVolver_2doC)
        Me.panel_control_2.Controls.Add(Me.btnAceptar_2doC)
        Me.panel_control_2.Controls.Add(Me.chkCorreccion2)
        Me.panel_control_2.Controls.Add(Me.txtDetalle2)
        Me.panel_control_2.Controls.Add(Me.chkNoConforme2)
        Me.panel_control_2.Controls.Add(Me.cmbTipo2)
        Me.panel_control_2.Controls.Add(Me.chkConforme2)
        Me.panel_control_2.Controls.Add(Me.chkCorresponde2)
        Me.panel_control_2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_control_2.Location = New System.Drawing.Point(943, 3)
        Me.panel_control_2.Name = "panel_control_2"
        Me.panel_control_2.Size = New System.Drawing.Size(330, 156)
        Me.panel_control_2.TabIndex = 14
        Me.panel_control_2.Visible = False
        '
        'btnVolver_2doC
        '
        Me.btnVolver_2doC.Image = CType(resources.GetObject("btnVolver_2doC.Image"), System.Drawing.Image)
        Me.btnVolver_2doC.Location = New System.Drawing.Point(218, 107)
        Me.btnVolver_2doC.Name = "btnVolver_2doC"
        Me.btnVolver_2doC.Size = New System.Drawing.Size(43, 38)
        Me.btnVolver_2doC.TabIndex = 535
        Me.btnVolver_2doC.UseVisualStyleBackColor = True
        '
        'btnAceptar_2doC
        '
        Me.btnAceptar_2doC.Image = CType(resources.GetObject("btnAceptar_2doC.Image"), System.Drawing.Image)
        Me.btnAceptar_2doC.Location = New System.Drawing.Point(267, 107)
        Me.btnAceptar_2doC.Name = "btnAceptar_2doC"
        Me.btnAceptar_2doC.Size = New System.Drawing.Size(43, 38)
        Me.btnAceptar_2doC.TabIndex = 534
        Me.btnAceptar_2doC.UseVisualStyleBackColor = True
        '
        'chkCorreccion2
        '
        Me.chkCorreccion2.AutoSize = True
        Me.chkCorreccion2.ForeColor = System.Drawing.Color.Green
        Me.chkCorreccion2.Location = New System.Drawing.Point(173, 76)
        Me.chkCorreccion2.Name = "chkCorreccion2"
        Me.chkCorreccion2.Size = New System.Drawing.Size(77, 17)
        Me.chkCorreccion2.TabIndex = 18
        Me.chkCorreccion2.Text = "Corrección"
        Me.chkCorreccion2.UseVisualStyleBackColor = True
        '
        'txtDetalle2
        '
        Me.txtDetalle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalle2.Location = New System.Drawing.Point(3, 4)
        Me.txtDetalle2.Multiline = True
        Me.txtDetalle2.Name = "txtDetalle2"
        Me.txtDetalle2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDetalle2.Size = New System.Drawing.Size(164, 144)
        Me.txtDetalle2.TabIndex = 17
        '
        'chkNoConforme2
        '
        Me.chkNoConforme2.AutoSize = True
        Me.chkNoConforme2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNoConforme2.ForeColor = System.Drawing.Color.Red
        Me.chkNoConforme2.Location = New System.Drawing.Point(173, 6)
        Me.chkNoConforme2.Name = "chkNoConforme2"
        Me.chkNoConforme2.Size = New System.Drawing.Size(36, 17)
        Me.chkNoConforme2.TabIndex = 16
        Me.chkNoConforme2.Text = "✘"
        Me.chkNoConforme2.UseVisualStyleBackColor = True
        '
        'cmbTipo2
        '
        Me.cmbTipo2.FormattingEnabled = True
        Me.cmbTipo2.Items.AddRange(New Object() {"ncm", "NCM", "obs"})
        Me.cmbTipo2.Location = New System.Drawing.Point(224, 29)
        Me.cmbTipo2.Name = "cmbTipo2"
        Me.cmbTipo2.Size = New System.Drawing.Size(88, 21)
        Me.cmbTipo2.TabIndex = 15
        Me.cmbTipo2.Visible = False
        '
        'chkConforme2
        '
        Me.chkConforme2.AutoSize = True
        Me.chkConforme2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkConforme2.ForeColor = System.Drawing.Color.Green
        Me.chkConforme2.Location = New System.Drawing.Point(173, 25)
        Me.chkConforme2.Name = "chkConforme2"
        Me.chkConforme2.Size = New System.Drawing.Size(35, 17)
        Me.chkConforme2.TabIndex = 14
        Me.chkConforme2.Text = "✓"
        Me.chkConforme2.UseVisualStyleBackColor = True
        '
        'chkCorresponde2
        '
        Me.chkCorresponde2.AutoSize = True
        Me.chkCorresponde2.Location = New System.Drawing.Point(224, 6)
        Me.chkCorresponde2.Name = "chkCorresponde2"
        Me.chkCorresponde2.Size = New System.Drawing.Size(86, 17)
        Me.chkCorresponde2.TabIndex = 13
        Me.chkCorresponde2.Text = "Corresponde"
        Me.chkCorresponde2.UseVisualStyleBackColor = True
        Me.chkCorresponde2.Visible = False
        '
        'panel_cadista
        '
        Me.panel_cadista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel_cadista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_cadista.Controls.Add(Me.chkCorresp)
        Me.panel_cadista.Controls.Add(Me.lblid_cuerpo_movimiento_hora)
        Me.panel_cadista.Controls.Add(Me.btnMenos)
        Me.panel_cadista.Controls.Add(Me.bntMas)
        Me.panel_cadista.Controls.Add(Me.btnVolver)
        Me.panel_cadista.Controls.Add(Me.btnAceptar1)
        Me.panel_cadista.Controls.Add(Me.chkNoCorresponde)
        Me.panel_cadista.Controls.Add(Me.chkOk)
        Me.panel_cadista.Controls.Add(Me.TextBox1)
        Me.panel_cadista.Controls.Add(Me.txtNombre_voz)
        Me.panel_cadista.Controls.Add(Me.PictureBox1)
        Me.panel_cadista.Location = New System.Drawing.Point(3, 3)
        Me.panel_cadista.MinimumSize = New System.Drawing.Size(457, 156)
        Me.panel_cadista.Name = "panel_cadista"
        Me.panel_cadista.Size = New System.Drawing.Size(474, 156)
        Me.panel_cadista.TabIndex = 15
        '
        'chkCorresp
        '
        Me.chkCorresp.AutoSize = True
        Me.chkCorresp.Location = New System.Drawing.Point(3, 115)
        Me.chkCorresp.Name = "chkCorresp"
        Me.chkCorresp.Size = New System.Drawing.Size(15, 14)
        Me.chkCorresp.TabIndex = 539
        Me.chkCorresp.UseVisualStyleBackColor = True
        Me.chkCorresp.Visible = False
        '
        'lblid_cuerpo_movimiento_hora
        '
        Me.lblid_cuerpo_movimiento_hora.AutoSize = True
        Me.lblid_cuerpo_movimiento_hora.BackColor = System.Drawing.Color.Red
        Me.lblid_cuerpo_movimiento_hora.Location = New System.Drawing.Point(614, 46)
        Me.lblid_cuerpo_movimiento_hora.Name = "lblid_cuerpo_movimiento_hora"
        Me.lblid_cuerpo_movimiento_hora.Size = New System.Drawing.Size(13, 13)
        Me.lblid_cuerpo_movimiento_hora.TabIndex = 530
        Me.lblid_cuerpo_movimiento_hora.Text = "0"
        Me.lblid_cuerpo_movimiento_hora.Visible = False
        '
        'btnMenos
        '
        Me.btnMenos.Location = New System.Drawing.Point(38, 131)
        Me.btnMenos.Name = "btnMenos"
        Me.btnMenos.Size = New System.Drawing.Size(20, 19)
        Me.btnMenos.TabIndex = 654
        Me.btnMenos.Text = "-"
        Me.btnMenos.UseVisualStyleBackColor = True
        '
        'bntMas
        '
        Me.bntMas.Location = New System.Drawing.Point(12, 131)
        Me.bntMas.Name = "bntMas"
        Me.bntMas.Size = New System.Drawing.Size(20, 19)
        Me.bntMas.TabIndex = 653
        Me.bntMas.Text = "+"
        Me.bntMas.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVolver.Image = CType(resources.GetObject("btnVolver.Image"), System.Drawing.Image)
        Me.btnVolver.Location = New System.Drawing.Point(395, 115)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(33, 35)
        Me.btnVolver.TabIndex = 531
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnAceptar1
        '
        Me.btnAceptar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar1.Image = CType(resources.GetObject("btnAceptar1.Image"), System.Drawing.Image)
        Me.btnAceptar1.Location = New System.Drawing.Point(434, 115)
        Me.btnAceptar1.Name = "btnAceptar1"
        Me.btnAceptar1.Size = New System.Drawing.Size(33, 35)
        Me.btnAceptar1.TabIndex = 529
        Me.btnAceptar1.UseVisualStyleBackColor = True
        '
        'chkNoCorresponde
        '
        Me.chkNoCorresponde.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkNoCorresponde.AutoSize = True
        Me.chkNoCorresponde.Location = New System.Drawing.Point(364, 6)
        Me.chkNoCorresponde.Name = "chkNoCorresponde"
        Me.chkNoCorresponde.Size = New System.Drawing.Size(103, 17)
        Me.chkNoCorresponde.TabIndex = 3
        Me.chkNoCorresponde.Text = "No Corresponde"
        Me.chkNoCorresponde.UseVisualStyleBackColor = True
        '
        'chkOk
        '
        Me.chkOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkOk.AutoSize = True
        Me.chkOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOk.ForeColor = System.Drawing.Color.Green
        Me.chkOk.Location = New System.Drawing.Point(364, 31)
        Me.chkOk.Name = "chkOk"
        Me.chkOk.Size = New System.Drawing.Size(56, 17)
        Me.chkOk.TabIndex = 4
        Me.chkOk.Text = "OK ✓"
        Me.chkOk.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(3, 6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(57, 35)
        Me.TextBox1.TabIndex = 0
        '
        'txtNombre_voz
        '
        Me.txtNombre_voz.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre_voz.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre_voz.Location = New System.Drawing.Point(73, 3)
        Me.txtNombre_voz.Multiline = True
        Me.txtNombre_voz.Name = "txtNombre_voz"
        Me.txtNombre_voz.ReadOnly = True
        Me.txtNombre_voz.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNombre_voz.Size = New System.Drawing.Size(285, 145)
        Me.txtNombre_voz.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 66)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frmControlActividad
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1276, 162)
        Me.Controls.Add(Me.tlPanel)
        Me.Controls.Add(Me.lblid_tipo_voz)
        Me.Location = New System.Drawing.Point(0, 700)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(476, 201)
        Me.Name = "frmControlActividad"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Controlar Actividad"
        Me.TopMost = True
        Me.panel_control_1.ResumeLayout(False)
        Me.panel_control_1.PerformLayout()
        Me.tlPanel.ResumeLayout(False)
        Me.panel_control_2.ResumeLayout(False)
        Me.panel_control_2.PerformLayout()
        Me.panel_cadista.ResumeLayout(False)
        Me.panel_cadista.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents panel_control_1 As System.Windows.Forms.Panel
    Friend WithEvents chkNoConformidad As System.Windows.Forms.CheckBox
    Friend WithEvents chkPedir_segundo_control As System.Windows.Forms.CheckBox
    Friend WithEvents btnvolver2 As System.Windows.Forms.Button
    Friend WithEvents btnAceptar2 As System.Windows.Forms.Button
    Friend WithEvents chkCorreccion As System.Windows.Forms.CheckBox
    Friend WithEvents txtDetalle1 As System.Windows.Forms.TextBox
    Friend WithEvents chkNoConforme As System.Windows.Forms.CheckBox
    Friend WithEvents cmbTipo1 As System.Windows.Forms.ComboBox
    Friend WithEvents chkConforme As System.Windows.Forms.CheckBox
    Friend WithEvents chkCorresponde1 As System.Windows.Forms.CheckBox
    Friend WithEvents lblid_tipo_voz As System.Windows.Forms.Label
    Friend WithEvents tlPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents panel_control_2 As System.Windows.Forms.Panel
    Friend WithEvents btnVolver_2doC As System.Windows.Forms.Button
    Friend WithEvents btnAceptar_2doC As System.Windows.Forms.Button
    Friend WithEvents chkCorreccion2 As System.Windows.Forms.CheckBox
    Friend WithEvents txtDetalle2 As System.Windows.Forms.TextBox
    Friend WithEvents chkNoConforme2 As System.Windows.Forms.CheckBox
    Friend WithEvents cmbTipo2 As System.Windows.Forms.ComboBox
    Friend WithEvents chkConforme2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkCorresponde2 As System.Windows.Forms.CheckBox
    Friend WithEvents btn_nueva_voz As System.Windows.Forms.Button
    Friend WithEvents panel_cadista As System.Windows.Forms.Panel
    Friend WithEvents chkCorresp As System.Windows.Forms.CheckBox
    Friend WithEvents lblid_cuerpo_movimiento_hora As System.Windows.Forms.Label
    Friend WithEvents btnMenos As System.Windows.Forms.Button
    Friend WithEvents bntMas As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnAceptar1 As System.Windows.Forms.Button
    Friend WithEvents chkNoCorresponde As System.Windows.Forms.CheckBox
    Friend WithEvents chkOk As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre_voz As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
