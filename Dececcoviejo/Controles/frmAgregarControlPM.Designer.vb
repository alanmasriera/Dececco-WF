<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarControlPM
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
        Me.lblid_control = New System.Windows.Forms.Label()
        Me.cmbcontrol = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_control = New System.Windows.Forms.Label()
        Me.lblid_movimiento_voz = New System.Windows.Forms.Label()
        Me.lblid_actividad_proyecto = New System.Windows.Forms.Label()
        Me.lblid_actividad = New System.Windows.Forms.Label()
        Me.lblid_proyecto = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_controlador_1 = New System.Windows.Forms.ComboBox()
        Me.cmb_controlador_2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grp_responsables = New System.Windows.Forms.GroupBox()
        Me.cmb_correccion_2 = New System.Windows.Forms.ComboBox()
        Me.cmb_segundo_control = New System.Windows.Forms.ComboBox()
        Me.cmb_2do_control_produccion = New System.Windows.Forms.ComboBox()
        Me.cmb_correccion_1 = New System.Windows.Forms.ComboBox()
        Me.cmb_primer_control = New System.Windows.Forms.ComboBox()
        Me.cmb_control_produccion = New System.Windows.Forms.ComboBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.cmb_cadista = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAgregarControl = New System.Windows.Forms.Button()
        Me.grp_responsables.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblid_control
        '
        Me.lblid_control.AutoSize = True
        Me.lblid_control.BackColor = System.Drawing.Color.Red
        Me.lblid_control.Location = New System.Drawing.Point(290, 9)
        Me.lblid_control.Name = "lblid_control"
        Me.lblid_control.Size = New System.Drawing.Size(13, 13)
        Me.lblid_control.TabIndex = 509
        Me.lblid_control.Text = "0"
        Me.lblid_control.Visible = False
        '
        'cmbcontrol
        '
        Me.cmbcontrol.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbcontrol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbcontrol.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbcontrol.FormattingEnabled = True
        Me.cmbcontrol.Location = New System.Drawing.Point(82, 39)
        Me.cmbcontrol.Name = "cmbcontrol"
        Me.cmbcontrol.Size = New System.Drawing.Size(507, 21)
        Me.cmbcontrol.TabIndex = 508
        '
        'etiquetaid_control
        '
        Me.etiquetaid_control.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaid_control.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_control.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_control.Location = New System.Drawing.Point(18, 37)
        Me.etiquetaid_control.Name = "etiquetaid_control"
        Me.etiquetaid_control.Size = New System.Drawing.Size(70, 21)
        Me.etiquetaid_control.TabIndex = 510
        Me.etiquetaid_control.Text = "Control:"
        Me.etiquetaid_control.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_movimiento_voz
        '
        Me.lblid_movimiento_voz.AutoSize = True
        Me.lblid_movimiento_voz.BackColor = System.Drawing.Color.Red
        Me.lblid_movimiento_voz.Location = New System.Drawing.Point(366, 9)
        Me.lblid_movimiento_voz.Name = "lblid_movimiento_voz"
        Me.lblid_movimiento_voz.Size = New System.Drawing.Size(13, 13)
        Me.lblid_movimiento_voz.TabIndex = 532
        Me.lblid_movimiento_voz.Text = "0"
        Me.lblid_movimiento_voz.Visible = False
        '
        'lblid_actividad_proyecto
        '
        Me.lblid_actividad_proyecto.AutoSize = True
        Me.lblid_actividad_proyecto.BackColor = System.Drawing.Color.Red
        Me.lblid_actividad_proyecto.Location = New System.Drawing.Point(347, 9)
        Me.lblid_actividad_proyecto.Name = "lblid_actividad_proyecto"
        Me.lblid_actividad_proyecto.Size = New System.Drawing.Size(13, 13)
        Me.lblid_actividad_proyecto.TabIndex = 531
        Me.lblid_actividad_proyecto.Text = "0"
        Me.lblid_actividad_proyecto.Visible = False
        '
        'lblid_actividad
        '
        Me.lblid_actividad.AutoSize = True
        Me.lblid_actividad.BackColor = System.Drawing.Color.Red
        Me.lblid_actividad.Location = New System.Drawing.Point(328, 9)
        Me.lblid_actividad.Name = "lblid_actividad"
        Me.lblid_actividad.Size = New System.Drawing.Size(13, 13)
        Me.lblid_actividad.TabIndex = 530
        Me.lblid_actividad.Text = "0"
        Me.lblid_actividad.Visible = False
        '
        'lblid_proyecto
        '
        Me.lblid_proyecto.AutoSize = True
        Me.lblid_proyecto.BackColor = System.Drawing.Color.Red
        Me.lblid_proyecto.Location = New System.Drawing.Point(309, 9)
        Me.lblid_proyecto.Name = "lblid_proyecto"
        Me.lblid_proyecto.Size = New System.Drawing.Size(13, 13)
        Me.lblid_proyecto.TabIndex = 529
        Me.lblid_proyecto.Text = "0"
        Me.lblid_proyecto.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 533
        Me.Label1.Text = "Controlador 1:"
        '
        'cmb_controlador_1
        '
        Me.cmb_controlador_1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_controlador_1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_controlador_1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_controlador_1.FormattingEnabled = True
        Me.cmb_controlador_1.Location = New System.Drawing.Point(116, 118)
        Me.cmb_controlador_1.Name = "cmb_controlador_1"
        Me.cmb_controlador_1.Size = New System.Drawing.Size(473, 21)
        Me.cmb_controlador_1.TabIndex = 534
        '
        'cmb_controlador_2
        '
        Me.cmb_controlador_2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_controlador_2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_controlador_2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_controlador_2.FormattingEnabled = True
        Me.cmb_controlador_2.Location = New System.Drawing.Point(116, 145)
        Me.cmb_controlador_2.Name = "cmb_controlador_2"
        Me.cmb_controlador_2.Size = New System.Drawing.Size(473, 21)
        Me.cmb_controlador_2.TabIndex = 536
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 535
        Me.Label2.Text = "Controlador 2:"
        '
        'grp_responsables
        '
        Me.grp_responsables.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_responsables.Controls.Add(Me.cmb_correccion_2)
        Me.grp_responsables.Controls.Add(Me.cmb_segundo_control)
        Me.grp_responsables.Controls.Add(Me.cmb_2do_control_produccion)
        Me.grp_responsables.Controls.Add(Me.cmb_correccion_1)
        Me.grp_responsables.Controls.Add(Me.cmb_primer_control)
        Me.grp_responsables.Controls.Add(Me.cmb_control_produccion)
        Me.grp_responsables.Controls.Add(Me.Label36)
        Me.grp_responsables.Controls.Add(Me.Label37)
        Me.grp_responsables.Controls.Add(Me.Label38)
        Me.grp_responsables.Controls.Add(Me.Label39)
        Me.grp_responsables.Controls.Add(Me.Label40)
        Me.grp_responsables.Controls.Add(Me.Label41)
        Me.grp_responsables.Location = New System.Drawing.Point(4, 183)
        Me.grp_responsables.Name = "grp_responsables"
        Me.grp_responsables.Size = New System.Drawing.Size(590, 193)
        Me.grp_responsables.TabIndex = 537
        Me.grp_responsables.TabStop = False
        Me.grp_responsables.Text = "Responsables"
        '
        'cmb_correccion_2
        '
        Me.cmb_correccion_2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_correccion_2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_correccion_2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_correccion_2.FormattingEnabled = True
        Me.cmb_correccion_2.Location = New System.Drawing.Point(181, 163)
        Me.cmb_correccion_2.Name = "cmb_correccion_2"
        Me.cmb_correccion_2.Size = New System.Drawing.Size(401, 21)
        Me.cmb_correccion_2.TabIndex = 23
        '
        'cmb_segundo_control
        '
        Me.cmb_segundo_control.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_segundo_control.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_segundo_control.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_segundo_control.FormattingEnabled = True
        Me.cmb_segundo_control.Location = New System.Drawing.Point(181, 136)
        Me.cmb_segundo_control.Name = "cmb_segundo_control"
        Me.cmb_segundo_control.Size = New System.Drawing.Size(401, 21)
        Me.cmb_segundo_control.TabIndex = 22
        '
        'cmb_2do_control_produccion
        '
        Me.cmb_2do_control_produccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_2do_control_produccion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_2do_control_produccion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_2do_control_produccion.FormattingEnabled = True
        Me.cmb_2do_control_produccion.Location = New System.Drawing.Point(181, 105)
        Me.cmb_2do_control_produccion.Name = "cmb_2do_control_produccion"
        Me.cmb_2do_control_produccion.Size = New System.Drawing.Size(401, 21)
        Me.cmb_2do_control_produccion.TabIndex = 21
        '
        'cmb_correccion_1
        '
        Me.cmb_correccion_1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_correccion_1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_correccion_1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_correccion_1.FormattingEnabled = True
        Me.cmb_correccion_1.Location = New System.Drawing.Point(181, 78)
        Me.cmb_correccion_1.Name = "cmb_correccion_1"
        Me.cmb_correccion_1.Size = New System.Drawing.Size(401, 21)
        Me.cmb_correccion_1.TabIndex = 20
        '
        'cmb_primer_control
        '
        Me.cmb_primer_control.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_primer_control.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_primer_control.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_primer_control.FormattingEnabled = True
        Me.cmb_primer_control.Location = New System.Drawing.Point(181, 51)
        Me.cmb_primer_control.Name = "cmb_primer_control"
        Me.cmb_primer_control.Size = New System.Drawing.Size(401, 21)
        Me.cmb_primer_control.TabIndex = 19
        '
        'cmb_control_produccion
        '
        Me.cmb_control_produccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_control_produccion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_control_produccion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_control_produccion.FormattingEnabled = True
        Me.cmb_control_produccion.Location = New System.Drawing.Point(181, 24)
        Me.cmb_control_produccion.Name = "cmb_control_produccion"
        Me.cmb_control_produccion.Size = New System.Drawing.Size(401, 21)
        Me.cmb_control_produccion.TabIndex = 18
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(84, 139)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(91, 13)
        Me.Label36.TabIndex = 17
        Me.Label36.Text = "Segundo control: "
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(102, 166)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(73, 13)
        Me.Label37.TabIndex = 16
        Me.Label37.Text = "Corrección 2: "
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(12, 108)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(163, 13)
        Me.Label38.TabIndex = 15
        Me.Label38.Text = "Segundo control de Producción: "
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(102, 81)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(73, 13)
        Me.Label39.TabIndex = 14
        Me.Label39.Text = "Corrección 1: "
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(98, 54)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(77, 13)
        Me.Label40.TabIndex = 13
        Me.Label40.Text = "Primer control: "
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(58, 27)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(117, 13)
        Me.Label41.TabIndex = 3
        Me.Label41.Text = "Control de producción: "
        '
        'cmb_cadista
        '
        Me.cmb_cadista.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_cadista.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_cadista.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_cadista.FormattingEnabled = True
        Me.cmb_cadista.Location = New System.Drawing.Point(116, 91)
        Me.cmb_cadista.Name = "cmb_cadista"
        Me.cmb_cadista.Size = New System.Drawing.Size(473, 21)
        Me.cmb_cadista.TabIndex = 539
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 538
        Me.Label3.Text = "Cadista:"
        '
        'btnAgregarControl
        '
        Me.btnAgregarControl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarControl.BackgroundImage = Global.Dececco.My.Resources.Resources.save1
        Me.btnAgregarControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarControl.Location = New System.Drawing.Point(518, 382)
        Me.btnAgregarControl.Name = "btnAgregarControl"
        Me.btnAgregarControl.Size = New System.Drawing.Size(76, 53)
        Me.btnAgregarControl.TabIndex = 784
        Me.btnAgregarControl.UseVisualStyleBackColor = True
        '
        'frmAgregarControlPM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 441)
        Me.Controls.Add(Me.btnAgregarControl)
        Me.Controls.Add(Me.cmb_cadista)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.grp_responsables)
        Me.Controls.Add(Me.cmb_controlador_2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_controlador_1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblid_movimiento_voz)
        Me.Controls.Add(Me.lblid_actividad_proyecto)
        Me.Controls.Add(Me.lblid_actividad)
        Me.Controls.Add(Me.lblid_proyecto)
        Me.Controls.Add(Me.lblid_control)
        Me.Controls.Add(Me.cmbcontrol)
        Me.Controls.Add(Me.etiquetaid_control)
        Me.MaximumSize = New System.Drawing.Size(1500, 480)
        Me.MinimumSize = New System.Drawing.Size(0, 480)
        Me.Name = "frmAgregarControlPM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Control"
        Me.grp_responsables.ResumeLayout(False)
        Me.grp_responsables.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblid_control As System.Windows.Forms.Label
    Friend WithEvents cmbcontrol As System.Windows.Forms.ComboBox
    Friend WithEvents etiquetaid_control As System.Windows.Forms.Label
    Friend WithEvents lblid_actividad_proyecto As System.Windows.Forms.Label
    Friend WithEvents lblid_actividad As System.Windows.Forms.Label
    Friend WithEvents lblid_proyecto As System.Windows.Forms.Label
    Friend WithEvents lblid_movimiento_voz As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_controlador_1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_controlador_2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grp_responsables As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_correccion_2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_segundo_control As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_2do_control_produccion As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_correccion_1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_primer_control As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_control_produccion As System.Windows.Forms.ComboBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents cmb_cadista As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents btnAgregarControl As System.Windows.Forms.Button
End Class
