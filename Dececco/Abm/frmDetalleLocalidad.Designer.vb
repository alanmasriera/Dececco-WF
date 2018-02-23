<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleLocalidad
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
       Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleLocalidad))
       Me.btnSalir = New System.Windows.Forms.Button
       Me.btnGuardar = New System.Windows.Forms.Button
       Me.GroupBox1 = New System.Windows.Forms.GroupBox
       Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
       Me.txtnombre_localidad = New System.Windows.Forms.TextBox
       Me.etiquetanombre_localidad = New System.Windows.Forms.Label
       Me.lblid_provincia = New System.Windows.Forms.Label
       Me.btnBuscaprovincia = New System.Windows.Forms.Button
       Me.cmbprovincia = New System.Windows.Forms.ComboBox
       Me.etiquetaid_provincia = New System.Windows.Forms.Label
       Me.txtcodigo_postal = New System.Windows.Forms.TextBox
       Me.etiquetacodigo_postal = New System.Windows.Forms.Label
       Me.txtcaracteristica_telefonica = New System.Windows.Forms.TextBox
       Me.etiquetacaracteristica_telefonica = New System.Windows.Forms.Label
       Me.SuspendLayout()
       '
       'txtnombre_localidad
       '
       Me.txtnombre_localidad.BackColor = System.Drawing.Color.White
       Me.txtnombre_localidad.Location = New System.Drawing.Point(161, 48)
       Me.txtnombre_localidad.MaxLength = 50
       Me.txtnombre_localidad.Name = "txtnombre_localidad"
       Me.txtnombre_localidad.Size = New System.Drawing.Size(385, 20)
       Me.txtnombre_localidad.TabIndex = 4
       '
       'etiquietanombre_localidad
       '
       Me.etiquetanombre_localidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
       Me.etiquetanombre_localidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
       Me.etiquetanombre_localidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetanombre_localidad.ForeColor = System.Drawing.Color.Black
       Me.etiquetanombre_localidad.Location = New System.Drawing.Point(28, 48)
       Me.etiquetanombre_localidad.Name = "etiquetanombre_localidad"
       Me.etiquetanombre_localidad.Size = New System.Drawing.Size(127, 21)
       Me.etiquetanombre_localidad.TabIndex = 500
       Me.etiquetanombre_localidad.Text = "Nombre_localidad"
       Me.etiquetanombre_localidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_provincia
       '
       Me.lblid_provincia.AutoSize = True
       Me.lblid_provincia.BackColor = System.Drawing.Color.Red
       Me.lblid_provincia.Location = New System.Drawing.Point(370, 91)
       Me.lblid_provincia.Name = "lblid_provincia"
       Me.lblid_provincia.Size = New System.Drawing.Size(13, 13)
       Me.lblid_provincia.TabIndex = 501
       Me.lblid_provincia.Text = "0"
       Me.lblid_provincia.Visible = False
       '
       'btnBuscaprovincia
       '
       Me.btnBuscaprovincia.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscaprovincia.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscaprovincia.Location = New System.Drawing.Point(505, 91)
       Me.btnBuscaprovincia.Name = "btnBuscaprovincia"
       Me.btnBuscaprovincia.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscaprovincia.TabIndex = 30
       Me.btnBuscaprovincia.UseVisualStyleBackColor = True
       '
       'cmbprovincia
       '
       Me.cmbprovincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbprovincia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbprovincia.FormattingEnabled = True
       Me.cmbprovincia.Location = New System.Drawing.Point(161, 91)
       Me.cmbprovincia.Name = "cmbprovincia"
       Me.cmbprovincia.Size = New System.Drawing.Size(329, 21)
       Me.cmbprovincia.TabIndex = 5
       '
       'etiquietaid_provincia
       '
       Me.etiquetaid_provincia.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
       Me.etiquetaid_provincia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
       Me.etiquetaid_provincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_provincia.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_provincia.Location = New System.Drawing.Point(28, 91)
       Me.etiquetaid_provincia.Name = "etiquetaid_provincia"
       Me.etiquetaid_provincia.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_provincia.TabIndex = 502
       Me.etiquetaid_provincia.Text = "Provincia"
       Me.etiquetaid_provincia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtcodigo_postal
       '
       Me.txtcodigo_postal.BackColor = System.Drawing.Color.White
       Me.txtcodigo_postal.Location = New System.Drawing.Point(161, 134)
       Me.txtcodigo_postal.MaxLength = 50
       Me.txtcodigo_postal.Name = "txtcodigo_postal"
       Me.txtcodigo_postal.Size = New System.Drawing.Size(385, 20)
       Me.txtcodigo_postal.TabIndex = 6
       '
       'etiquietacodigo_postal
       '
       Me.etiquetacodigo_postal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
       Me.etiquetacodigo_postal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
       Me.etiquetacodigo_postal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetacodigo_postal.ForeColor = System.Drawing.Color.Black
       Me.etiquetacodigo_postal.Location = New System.Drawing.Point(28, 134)
       Me.etiquetacodigo_postal.Name = "etiquetacodigo_postal"
       Me.etiquetacodigo_postal.Size = New System.Drawing.Size(127, 21)
       Me.etiquetacodigo_postal.TabIndex = 503
       Me.etiquetacodigo_postal.Text = "Codigo_postal"
       Me.etiquetacodigo_postal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtcaracteristica_telefonica
       '
       Me.txtcaracteristica_telefonica.BackColor = System.Drawing.Color.White
       Me.txtcaracteristica_telefonica.Location = New System.Drawing.Point(161, 177)
       Me.txtcaracteristica_telefonica.MaxLength = 50
       Me.txtcaracteristica_telefonica.Name = "txtcaracteristica_telefonica"
       Me.txtcaracteristica_telefonica.Size = New System.Drawing.Size(385, 20)
       Me.txtcaracteristica_telefonica.TabIndex = 7
       '
       'etiquietacaracteristica_telefonica
       '
       Me.etiquetacaracteristica_telefonica.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
       Me.etiquetacaracteristica_telefonica.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
       Me.etiquetacaracteristica_telefonica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetacaracteristica_telefonica.ForeColor = System.Drawing.Color.Black
       Me.etiquetacaracteristica_telefonica.Location = New System.Drawing.Point(28, 177)
       Me.etiquetacaracteristica_telefonica.Name = "etiquetacaracteristica_telefonica"
       Me.etiquetacaracteristica_telefonica.Size = New System.Drawing.Size(127, 21)
       Me.etiquetacaracteristica_telefonica.TabIndex = 504
       Me.etiquetacaracteristica_telefonica.Text = "Caracteristica_telefonica"
       Me.etiquetacaracteristica_telefonica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'btnSalir
       '
       Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
       Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.btnSalir.ForeColor = System.Drawing.Color.Black
       Me.btnSalir.Image = CType(Resources.GetObject("btnSalir.Image"), System.Drawing.Image)
       Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
       Me.btnSalir.Location = New System.Drawing.Point(499, 260)
       Me.btnSalir.Name = "btnSalir"
       Me.btnSalir.Size = New System.Drawing.Size(81, 69)
       Me.btnSalir.TabIndex = 21
       Me.btnSalir.Text = "&Salir"
       Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
       Me.btnSalir.UseVisualStyleBackColor = True
       '
       'btnGuardar
       '
       Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnGuardar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.btnGuardar.ForeColor = System.Drawing.Color.Black
       Me.btnGuardar.Image = CType(Resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
       Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
       Me.btnGuardar.Location = New System.Drawing.Point(392,260)
       Me.btnGuardar.Name = "btnGuardar"
       Me.btnGuardar.Size = New System.Drawing.Size(78, 69)
       Me.btnGuardar.TabIndex = 20
       Me.btnGuardar.Text = "&Guardar"
       Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
       Me.btnGuardar.UseVisualStyleBackColor = True
       '
       'GroupBox1
       '
       Me.GroupBox1.Location = New System.Drawing.Point(12, 17)
       Me.GroupBox1.Name = "GroupBox1"
       Me.GroupBox1.Size = New System.Drawing.Size(568, 220)
       Me.GroupBox1.TabIndex = 0
       Me.GroupBox1.TabStop = False
       '
       'frmDetalleLocalidad
       '
       Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
       Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
       Me.ClientSize = New System.Drawing.Size(600, 340)
       Me.Controls.Add(Me.txtnombre_localidad)
       Me.Controls.Add(Me.etiquetanombre_localidad)
       Me.Controls.Add(Me.lblid_provincia)
       Me.Controls.Add(Me.btnBuscaprovincia)
       Me.Controls.Add(Me.cmbprovincia)
       Me.Controls.Add(Me.etiquetaid_provincia)
       Me.Controls.Add(Me.txtcodigo_postal)
       Me.Controls.Add(Me.etiquetacodigo_postal)
       Me.Controls.Add(Me.txtcaracteristica_telefonica)
       Me.Controls.Add(Me.etiquetacaracteristica_telefonica)
       Me.Controls.Add(Me.btnSalir)
       Me.Controls.Add(Me.btnGuardar)
       Me.Controls.Add(Me.GroupBox1)
       Me.Name = "frmDetalleLocalidad"
       Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleLocalidad" & vgNombreFormulario
       Me.ResumeLayout(False)
       Me.PerformLayout()

   End Sub
   Protected WithEvents txtnombre_localidad As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanombre_localidad As System.Windows.Forms.Label
   Friend WithEvents lblid_provincia As System.Windows.Forms.Label
   Friend WithEvents btnBuscaprovincia As System.Windows.Forms.Button
   Friend WithEvents cmbprovincia As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_provincia As System.Windows.Forms.Label
   Protected WithEvents txtcodigo_postal As System.Windows.Forms.TextBox
   Friend WithEvents etiquetacodigo_postal As System.Windows.Forms.Label
   Protected WithEvents txtcaracteristica_telefonica As System.Windows.Forms.TextBox
   Friend WithEvents etiquetacaracteristica_telefonica As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

