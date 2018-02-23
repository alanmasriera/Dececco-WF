<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProgramacionTarea
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombreTarea = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rdAnual = New System.Windows.Forms.RadioButton()
        Me.rdUnicaVez = New System.Windows.Forms.RadioButton()
        Me.rdDiario = New System.Windows.Forms.RadioButton()
        Me.rdMensual = New System.Windows.Forms.RadioButton()
        Me.rdSemanal = New System.Windows.Forms.RadioButton()
        Me.PanelGeneral = New System.Windows.Forms.Panel()
        Me.PanelDiario = New System.Windows.Forms.Panel()
        Me.numCantDias = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PanelSemanal = New System.Windows.Forms.Panel()
        Me.chkMiercoles = New System.Windows.Forms.CheckBox()
        Me.chkSabado = New System.Windows.Forms.CheckBox()
        Me.chkMartes = New System.Windows.Forms.CheckBox()
        Me.chkViernes = New System.Windows.Forms.CheckBox()
        Me.chkLunes = New System.Windows.Forms.CheckBox()
        Me.chkJueves = New System.Windows.Forms.CheckBox()
        Me.chkDomingo = New System.Windows.Forms.CheckBox()
        Me.PanelMensual = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.numDiaMes = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PanelAnual = New System.Windows.Forms.Panel()
        Me.dtAnual = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PanelUnicaVez = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtFin = New System.Windows.Forms.DateTimePicker()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtNombreActividad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.PanelGeneral.SuspendLayout
        Me.PanelDiario.SuspendLayout
        CType(Me.numCantDias,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelSemanal.SuspendLayout
        Me.PanelMensual.SuspendLayout
        CType(Me.numDiaMes,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelAnual.SuspendLayout
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(36, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de la tarea: "
        '
        'txtNombreTarea
        '
        Me.txtNombreTarea.Location = New System.Drawing.Point(145, 45)
        Me.txtNombreTarea.Name = "txtNombreTarea"
        Me.txtNombreTarea.Size = New System.Drawing.Size(311, 20)
        Me.txtNombreTarea.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.80451!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.19549!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelGeneral, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(11, 82)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 148!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 148!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 148!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 148!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(532, 148)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rdAnual)
        Me.Panel1.Controls.Add(Me.rdUnicaVez)
        Me.Panel1.Controls.Add(Me.rdDiario)
        Me.Panel1.Controls.Add(Me.rdMensual)
        Me.Panel1.Controls.Add(Me.rdSemanal)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(109, 142)
        Me.Panel1.TabIndex = 0
        '
        'rdAnual
        '
        Me.rdAnual.AutoSize = true
        Me.rdAnual.Location = New System.Drawing.Point(15, 107)
        Me.rdAnual.Name = "rdAnual"
        Me.rdAnual.Size = New System.Drawing.Size(52, 17)
        Me.rdAnual.TabIndex = 8
        Me.rdAnual.TabStop = true
        Me.rdAnual.Text = "Anual"
        Me.rdAnual.UseVisualStyleBackColor = true
        '
        'rdUnicaVez
        '
        Me.rdUnicaVez.AutoSize = true
        Me.rdUnicaVez.Location = New System.Drawing.Point(15, 15)
        Me.rdUnicaVez.Name = "rdUnicaVez"
        Me.rdUnicaVez.Size = New System.Drawing.Size(73, 17)
        Me.rdUnicaVez.TabIndex = 4
        Me.rdUnicaVez.TabStop = true
        Me.rdUnicaVez.Text = "Única vez"
        Me.rdUnicaVez.UseVisualStyleBackColor = true
        '
        'rdDiario
        '
        Me.rdDiario.AutoSize = true
        Me.rdDiario.Location = New System.Drawing.Point(15, 38)
        Me.rdDiario.Name = "rdDiario"
        Me.rdDiario.Size = New System.Drawing.Size(52, 17)
        Me.rdDiario.TabIndex = 5
        Me.rdDiario.TabStop = true
        Me.rdDiario.Text = "Diario"
        Me.rdDiario.UseVisualStyleBackColor = true
        '
        'rdMensual
        '
        Me.rdMensual.AutoSize = true
        Me.rdMensual.Location = New System.Drawing.Point(15, 84)
        Me.rdMensual.Name = "rdMensual"
        Me.rdMensual.Size = New System.Drawing.Size(65, 17)
        Me.rdMensual.TabIndex = 7
        Me.rdMensual.TabStop = true
        Me.rdMensual.Text = "Mensual"
        Me.rdMensual.UseVisualStyleBackColor = true
        '
        'rdSemanal
        '
        Me.rdSemanal.AutoSize = true
        Me.rdSemanal.Location = New System.Drawing.Point(15, 61)
        Me.rdSemanal.Name = "rdSemanal"
        Me.rdSemanal.Size = New System.Drawing.Size(66, 17)
        Me.rdSemanal.TabIndex = 6
        Me.rdSemanal.TabStop = true
        Me.rdSemanal.Text = "Semanal"
        Me.rdSemanal.UseVisualStyleBackColor = true
        '
        'PanelGeneral
        '
        Me.PanelGeneral.Controls.Add(Me.PanelDiario)
        Me.PanelGeneral.Controls.Add(Me.PanelSemanal)
        Me.PanelGeneral.Controls.Add(Me.PanelMensual)
        Me.PanelGeneral.Controls.Add(Me.PanelAnual)
        Me.PanelGeneral.Controls.Add(Me.PanelUnicaVez)
        Me.PanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGeneral.Location = New System.Drawing.Point(118, 3)
        Me.PanelGeneral.Name = "PanelGeneral"
        Me.PanelGeneral.Size = New System.Drawing.Size(411, 142)
        Me.PanelGeneral.TabIndex = 0
        '
        'PanelDiario
        '
        Me.PanelDiario.Controls.Add(Me.numCantDias)
        Me.PanelDiario.Controls.Add(Me.Label9)
        Me.PanelDiario.Controls.Add(Me.Label10)
        Me.PanelDiario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDiario.Location = New System.Drawing.Point(0, 0)
        Me.PanelDiario.Name = "PanelDiario"
        Me.PanelDiario.Size = New System.Drawing.Size(411, 142)
        Me.PanelDiario.TabIndex = 9
        '
        'numCantDias
        '
        Me.numCantDias.Location = New System.Drawing.Point(57, 15)
        Me.numCantDias.Maximum = New Decimal(New Integer() {9000, 0, 0, 0})
        Me.numCantDias.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numCantDias.Name = "numCantDias"
        Me.numCantDias.Size = New System.Drawing.Size(52, 20)
        Me.numCantDias.TabIndex = 5
        Me.numCantDias.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Location = New System.Drawing.Point(115, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "días"
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Location = New System.Drawing.Point(19, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Cada"
        '
        'PanelSemanal
        '
        Me.PanelSemanal.Controls.Add(Me.chkMiercoles)
        Me.PanelSemanal.Controls.Add(Me.chkSabado)
        Me.PanelSemanal.Controls.Add(Me.chkMartes)
        Me.PanelSemanal.Controls.Add(Me.chkViernes)
        Me.PanelSemanal.Controls.Add(Me.chkLunes)
        Me.PanelSemanal.Controls.Add(Me.chkJueves)
        Me.PanelSemanal.Controls.Add(Me.chkDomingo)
        Me.PanelSemanal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelSemanal.Location = New System.Drawing.Point(0, 0)
        Me.PanelSemanal.Name = "PanelSemanal"
        Me.PanelSemanal.Size = New System.Drawing.Size(411, 142)
        Me.PanelSemanal.TabIndex = 1
        '
        'chkMiercoles
        '
        Me.chkMiercoles.AutoSize = true
        Me.chkMiercoles.Location = New System.Drawing.Point(309, 29)
        Me.chkMiercoles.Name = "chkMiercoles"
        Me.chkMiercoles.Size = New System.Drawing.Size(71, 17)
        Me.chkMiercoles.TabIndex = 7
        Me.chkMiercoles.Text = "Miércoles"
        Me.chkMiercoles.UseVisualStyleBackColor = true
        '
        'chkSabado
        '
        Me.chkSabado.AutoSize = true
        Me.chkSabado.Location = New System.Drawing.Point(222, 62)
        Me.chkSabado.Name = "chkSabado"
        Me.chkSabado.Size = New System.Drawing.Size(63, 17)
        Me.chkSabado.TabIndex = 6
        Me.chkSabado.Text = "Sábado"
        Me.chkSabado.UseVisualStyleBackColor = true
        '
        'chkMartes
        '
        Me.chkMartes.AutoSize = true
        Me.chkMartes.Location = New System.Drawing.Point(222, 29)
        Me.chkMartes.Name = "chkMartes"
        Me.chkMartes.Size = New System.Drawing.Size(58, 17)
        Me.chkMartes.TabIndex = 5
        Me.chkMartes.Text = "Martes"
        Me.chkMartes.UseVisualStyleBackColor = true
        '
        'chkViernes
        '
        Me.chkViernes.AutoSize = true
        Me.chkViernes.Location = New System.Drawing.Point(121, 62)
        Me.chkViernes.Name = "chkViernes"
        Me.chkViernes.Size = New System.Drawing.Size(61, 17)
        Me.chkViernes.TabIndex = 4
        Me.chkViernes.Text = "Viernes"
        Me.chkViernes.UseVisualStyleBackColor = true
        '
        'chkLunes
        '
        Me.chkLunes.AutoSize = true
        Me.chkLunes.Location = New System.Drawing.Point(121, 29)
        Me.chkLunes.Name = "chkLunes"
        Me.chkLunes.Size = New System.Drawing.Size(55, 17)
        Me.chkLunes.TabIndex = 3
        Me.chkLunes.Text = "Lunes"
        Me.chkLunes.UseVisualStyleBackColor = true
        '
        'chkJueves
        '
        Me.chkJueves.AutoSize = true
        Me.chkJueves.Location = New System.Drawing.Point(15, 62)
        Me.chkJueves.Name = "chkJueves"
        Me.chkJueves.Size = New System.Drawing.Size(60, 17)
        Me.chkJueves.TabIndex = 2
        Me.chkJueves.Text = "Jueves"
        Me.chkJueves.UseVisualStyleBackColor = true
        '
        'chkDomingo
        '
        Me.chkDomingo.AutoSize = true
        Me.chkDomingo.Location = New System.Drawing.Point(15, 29)
        Me.chkDomingo.Name = "chkDomingo"
        Me.chkDomingo.Size = New System.Drawing.Size(68, 17)
        Me.chkDomingo.TabIndex = 1
        Me.chkDomingo.Text = "Domingo"
        Me.chkDomingo.UseVisualStyleBackColor = true
        '
        'PanelMensual
        '
        Me.PanelMensual.Controls.Add(Me.Label7)
        Me.PanelMensual.Controls.Add(Me.numDiaMes)
        Me.PanelMensual.Controls.Add(Me.Label6)
        Me.PanelMensual.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMensual.Location = New System.Drawing.Point(0, 0)
        Me.PanelMensual.Name = "PanelMensual"
        Me.PanelMensual.Size = New System.Drawing.Size(411, 142)
        Me.PanelMensual.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Location = New System.Drawing.Point(140, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "de cada mes"
        '
        'numDiaMes
        '
        Me.numDiaMes.Location = New System.Drawing.Point(63, 29)
        Me.numDiaMes.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.numDiaMes.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numDiaMes.Name = "numDiaMes"
        Me.numDiaMes.Size = New System.Drawing.Size(71, 20)
        Me.numDiaMes.TabIndex = 10
        Me.numDiaMes.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(32, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Día"
        '
        'PanelAnual
        '
        Me.PanelAnual.Controls.Add(Me.dtAnual)
        Me.PanelAnual.Controls.Add(Me.Label8)
        Me.PanelAnual.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelAnual.Location = New System.Drawing.Point(0, 0)
        Me.PanelAnual.Name = "PanelAnual"
        Me.PanelAnual.Size = New System.Drawing.Size(411, 142)
        Me.PanelAnual.TabIndex = 11
        '
        'dtAnual
        '
        Me.dtAnual.CustomFormat = "d MMMM"
        Me.dtAnual.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtAnual.Location = New System.Drawing.Point(57, 26)
        Me.dtAnual.Name = "dtAnual"
        Me.dtAnual.Size = New System.Drawing.Size(151, 20)
        Me.dtAnual.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Location = New System.Drawing.Point(32, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "El "
        '
        'PanelUnicaVez
        '
        Me.PanelUnicaVez.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelUnicaVez.Location = New System.Drawing.Point(0, 0)
        Me.PanelUnicaVez.Name = "PanelUnicaVez"
        Me.PanelUnicaVez.Size = New System.Drawing.Size(411, 142)
        Me.PanelUnicaVez.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(36, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Intervalo de repetición"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(26, 282)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Comienzo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(230, 282)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Terminar el:"
        '
        'dtInicio
        '
        Me.dtInicio.CustomFormat = "dddd dd/MM/yyy"
        Me.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtInicio.Location = New System.Drawing.Point(88, 276)
        Me.dtInicio.Name = "dtInicio"
        Me.dtInicio.Size = New System.Drawing.Size(92, 20)
        Me.dtInicio.TabIndex = 6
        '
        'dtFin
        '
        Me.dtFin.CustomFormat = "dddd dd/MM/yyy"
        Me.dtFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFin.Location = New System.Drawing.Point(298, 276)
        Me.dtFin.Name = "dtFin"
        Me.dtFin.Size = New System.Drawing.Size(92, 20)
        Me.dtFin.TabIndex = 7
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(469, 327)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 8
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = true
        '
        'txtNombreActividad
        '
        Me.txtNombreActividad.Location = New System.Drawing.Point(145, 19)
        Me.txtNombreActividad.Name = "txtNombreActividad"
        Me.txtNombreActividad.ReadOnly = true
        Me.txtNombreActividad.Size = New System.Drawing.Size(311, 20)
        Me.txtNombreActividad.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(17, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Nombre de la actividad: "
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(381, 327)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = true
        '
        'frmProgramacionTarea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 366)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.txtNombreActividad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.dtFin)
        Me.Controls.Add(Me.dtInicio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.txtNombreTarea)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmProgramacionTarea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Programación de la actividad"
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.PanelGeneral.ResumeLayout(false)
        Me.PanelDiario.ResumeLayout(false)
        Me.PanelDiario.PerformLayout
        CType(Me.numCantDias,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelSemanal.ResumeLayout(false)
        Me.PanelSemanal.PerformLayout
        Me.PanelMensual.ResumeLayout(false)
        Me.PanelMensual.PerformLayout
        CType(Me.numDiaMes,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelAnual.ResumeLayout(false)
        Me.PanelAnual.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombreTarea As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rdAnual As RadioButton
    Friend WithEvents rdUnicaVez As RadioButton
    Friend WithEvents rdDiario As RadioButton
    Friend WithEvents rdMensual As RadioButton
    Friend WithEvents rdSemanal As RadioButton
    Friend WithEvents PanelSemanal As Panel
    Friend WithEvents PanelAnual As Panel
    Friend WithEvents PanelMensual As Panel
    Friend WithEvents PanelDiario As Panel
    Friend WithEvents PanelUnicaVez As Panel
    Friend WithEvents chkMiercoles As CheckBox
    Friend WithEvents chkSabado As CheckBox
    Friend WithEvents chkMartes As CheckBox
    Friend WithEvents chkViernes As CheckBox
    Friend WithEvents chkLunes As CheckBox
    Friend WithEvents chkJueves As CheckBox
    Friend WithEvents chkDomingo As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtInicio As DateTimePicker
    Friend WithEvents dtFin As DateTimePicker
    Friend WithEvents btnAceptar As Button
    Friend WithEvents txtNombreActividad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents PanelGeneral As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents numDiaMes As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents dtAnual As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents numCantDias As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
