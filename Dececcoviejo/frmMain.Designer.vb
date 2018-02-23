<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.AdministrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.AdministrarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadistaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProyectManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdenarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton3 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.AdministrarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.lblid_actividad_proyecto = New System.Windows.Forms.Label()
        Me.lblid_actividad = New System.Windows.Forms.Label()
        Me.lblid_proyecto = New System.Windows.Forms.Label()
        Me.lblid_cuerpo_movimiento_hora = New System.Windows.Forms.Label()
        Me.lblNodo = New System.Windows.Forms.Label()
        Me.CalendarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(140, 722)
        Me.Panel1.TabIndex = 6
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.ToolStripSeparator1, Me.ToolStripDropDownButton2, Me.ToolStripSeparator2, Me.ToolStripSplitButton1, Me.ToolStripSeparator4, Me.ToolStripDropDownButton3, Me.ToolStripSeparator3, Me.ToolStripButton1})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(140, 407)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrarToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(138, 68)
        Me.ToolStripDropDownButton1.Text = "Proyectos"
        '
        'AdministrarToolStripMenuItem
        '
        Me.AdministrarToolStripMenuItem.Name = "AdministrarToolStripMenuItem"
        Me.AdministrarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AdministrarToolStripMenuItem.Text = "Administrar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(138, 6)
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrarToolStripMenuItem1, Me.CadistaToolStripMenuItem, Me.ProyectManagerToolStripMenuItem, Me.OrdenarToolStripMenuItem})
        Me.ToolStripDropDownButton2.Image = CType(resources.GetObject("ToolStripDropDownButton2.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(138, 68)
        Me.ToolStripDropDownButton2.Text = "Controles"
        '
        'AdministrarToolStripMenuItem1
        '
        Me.AdministrarToolStripMenuItem1.Name = "AdministrarToolStripMenuItem1"
        Me.AdministrarToolStripMenuItem1.Size = New System.Drawing.Size(167, 22)
        Me.AdministrarToolStripMenuItem1.Text = "Administrar"
        '
        'CadistaToolStripMenuItem
        '
        Me.CadistaToolStripMenuItem.Name = "CadistaToolStripMenuItem"
        Me.CadistaToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.CadistaToolStripMenuItem.Text = "Cadista"
        '
        'ProyectManagerToolStripMenuItem
        '
        Me.ProyectManagerToolStripMenuItem.Name = "ProyectManagerToolStripMenuItem"
        Me.ProyectManagerToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ProyectManagerToolStripMenuItem.Text = "Proyect Manager"
        '
        'OrdenarToolStripMenuItem
        '
        Me.OrdenarToolStripMenuItem.Name = "OrdenarToolStripMenuItem"
        Me.OrdenarToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.OrdenarToolStripMenuItem.Text = "Ordenar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(138, 6)
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ControlToolStripMenuItem, Me.CalendarioToolStripMenuItem})
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(138, 68)
        Me.ToolStripSplitButton1.Text = "Horas"
        '
        'ControlToolStripMenuItem
        '
        Me.ControlToolStripMenuItem.Name = "ControlToolStripMenuItem"
        Me.ControlToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ControlToolStripMenuItem.Text = "Control"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(138, 6)
        '
        'ToolStripDropDownButton3
        '
        Me.ToolStripDropDownButton3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrarToolStripMenuItem2})
        Me.ToolStripDropDownButton3.Image = CType(resources.GetObject("ToolStripDropDownButton3.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton3.Name = "ToolStripDropDownButton3"
        Me.ToolStripDropDownButton3.Size = New System.Drawing.Size(138, 68)
        Me.ToolStripDropDownButton3.Text = "Seguridad"
        '
        'AdministrarToolStripMenuItem2
        '
        Me.AdministrarToolStripMenuItem2.Name = "AdministrarToolStripMenuItem2"
        Me.AdministrarToolStripMenuItem2.Size = New System.Drawing.Size(139, 22)
        Me.AdministrarToolStripMenuItem2.Text = "Administrar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(138, 6)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(138, 68)
        Me.ToolStripButton1.Text = "Salir"
        '
        'lblid_actividad_proyecto
        '
        Me.lblid_actividad_proyecto.AutoSize = True
        Me.lblid_actividad_proyecto.BackColor = System.Drawing.Color.Red
        Me.lblid_actividad_proyecto.Location = New System.Drawing.Point(232, 9)
        Me.lblid_actividad_proyecto.Name = "lblid_actividad_proyecto"
        Me.lblid_actividad_proyecto.Size = New System.Drawing.Size(13, 13)
        Me.lblid_actividad_proyecto.TabIndex = 528
        Me.lblid_actividad_proyecto.Text = "0"
        Me.lblid_actividad_proyecto.Visible = False
        '
        'lblid_actividad
        '
        Me.lblid_actividad.AutoSize = True
        Me.lblid_actividad.BackColor = System.Drawing.Color.Red
        Me.lblid_actividad.Location = New System.Drawing.Point(213, 9)
        Me.lblid_actividad.Name = "lblid_actividad"
        Me.lblid_actividad.Size = New System.Drawing.Size(13, 13)
        Me.lblid_actividad.TabIndex = 527
        Me.lblid_actividad.Text = "0"
        Me.lblid_actividad.Visible = False
        '
        'lblid_proyecto
        '
        Me.lblid_proyecto.AutoSize = True
        Me.lblid_proyecto.BackColor = System.Drawing.Color.Red
        Me.lblid_proyecto.Location = New System.Drawing.Point(194, 9)
        Me.lblid_proyecto.Name = "lblid_proyecto"
        Me.lblid_proyecto.Size = New System.Drawing.Size(13, 13)
        Me.lblid_proyecto.TabIndex = 526
        Me.lblid_proyecto.Text = "0"
        Me.lblid_proyecto.Visible = False
        '
        'lblid_cuerpo_movimiento_hora
        '
        Me.lblid_cuerpo_movimiento_hora.AutoSize = True
        Me.lblid_cuerpo_movimiento_hora.BackColor = System.Drawing.Color.Red
        Me.lblid_cuerpo_movimiento_hora.Location = New System.Drawing.Point(232, 32)
        Me.lblid_cuerpo_movimiento_hora.Name = "lblid_cuerpo_movimiento_hora"
        Me.lblid_cuerpo_movimiento_hora.Size = New System.Drawing.Size(13, 13)
        Me.lblid_cuerpo_movimiento_hora.TabIndex = 532
        Me.lblid_cuerpo_movimiento_hora.Text = "0"
        Me.lblid_cuerpo_movimiento_hora.Visible = False
        '
        'lblNodo
        '
        Me.lblNodo.AutoSize = True
        Me.lblNodo.BackColor = System.Drawing.Color.Red
        Me.lblNodo.Location = New System.Drawing.Point(213, 32)
        Me.lblNodo.Name = "lblNodo"
        Me.lblNodo.Size = New System.Drawing.Size(13, 13)
        Me.lblNodo.TabIndex = 533
        Me.lblNodo.Text = "0"
        Me.lblNodo.Visible = False
        '
        'CalendarioToolStripMenuItem
        '
        Me.CalendarioToolStripMenuItem.Name = "CalendarioToolStripMenuItem"
        Me.CalendarioToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CalendarioToolStripMenuItem.Text = "Calendario"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1016, 734)
        Me.Controls.Add(Me.lblNodo)
        Me.Controls.Add(Me.lblid_cuerpo_movimiento_hora)
        Me.Controls.Add(Me.lblid_actividad_proyecto)
        Me.Controls.Add(Me.lblid_actividad)
        Me.Controls.Add(Me.lblid_proyecto)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMain"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents lblid_actividad_proyecto As System.Windows.Forms.Label
    Friend WithEvents lblid_actividad As System.Windows.Forms.Label
    Friend WithEvents lblid_proyecto As System.Windows.Forms.Label
    Friend WithEvents ToolStripDropDownButton2 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents AdministrarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadistaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProyectManagerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton3 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents AdministrarToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents AdministrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblid_cuerpo_movimiento_hora As System.Windows.Forms.Label
    Friend WithEvents lblNodo As System.Windows.Forms.Label
    Friend WithEvents OrdenarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ControlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalendarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
