<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeguridad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSeguridad))
        Me.btnGrupo_usuario = New System.Windows.Forms.Button()
        Me.btnUsuario = New System.Windows.Forms.Button()
        Me.btnPermiso = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.btnPermisoAbm = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGrupo_usuario
        '
        Me.btnGrupo_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrupo_usuario.Image = CType(resources.GetObject("btnGrupo_usuario.Image"), System.Drawing.Image)
        Me.btnGrupo_usuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGrupo_usuario.Location = New System.Drawing.Point(32, 33)
        Me.btnGrupo_usuario.Name = "btnGrupo_usuario"
        Me.btnGrupo_usuario.Size = New System.Drawing.Size(117, 95)
        Me.btnGrupo_usuario.TabIndex = 5
        Me.btnGrupo_usuario.Text = "Grupos"
        Me.btnGrupo_usuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGrupo_usuario.UseVisualStyleBackColor = True
        '
        'btnUsuario
        '
        Me.btnUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuario.Image = CType(resources.GetObject("btnUsuario.Image"), System.Drawing.Image)
        Me.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUsuario.Location = New System.Drawing.Point(227, 33)
        Me.btnUsuario.Name = "btnUsuario"
        Me.btnUsuario.Size = New System.Drawing.Size(117, 95)
        Me.btnUsuario.TabIndex = 6
        Me.btnUsuario.Text = "Usuarios"
        Me.btnUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUsuario.UseVisualStyleBackColor = True
        '
        'btnPermiso
        '
        Me.btnPermiso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPermiso.Image = CType(resources.GetObject("btnPermiso.Image"), System.Drawing.Image)
        Me.btnPermiso.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPermiso.Location = New System.Drawing.Point(422, 33)
        Me.btnPermiso.Name = "btnPermiso"
        Me.btnPermiso.Size = New System.Drawing.Size(117, 95)
        Me.btnPermiso.TabIndex = 7
        Me.btnPermiso.Text = "Permisos"
        Me.btnPermiso.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPermiso.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(454, 309)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(86, 71)
        Me.btnSalir.TabIndex = 100
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnBackup
        '
        Me.btnBackup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackup.Image = CType(resources.GetObject("btnBackup.Image"), System.Drawing.Image)
        Me.btnBackup.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBackup.Location = New System.Drawing.Point(32, 198)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(117, 95)
        Me.btnBackup.TabIndex = 8
        Me.btnBackup.Text = "Backup"
        Me.btnBackup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'btnPermisoAbm
        '
        Me.btnPermisoAbm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPermisoAbm.Image = CType(resources.GetObject("btnPermisoAbm.Image"), System.Drawing.Image)
        Me.btnPermisoAbm.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPermisoAbm.Location = New System.Drawing.Point(227, 198)
        Me.btnPermisoAbm.Name = "btnPermisoAbm"
        Me.btnPermisoAbm.Size = New System.Drawing.Size(117, 95)
        Me.btnPermisoAbm.TabIndex = 101
        Me.btnPermisoAbm.Text = "Agregar ABM"
        Me.btnPermisoAbm.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPermisoAbm.UseVisualStyleBackColor = True
        Me.btnPermisoAbm.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(422, 198)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 95)
        Me.Button1.TabIndex = 102
        Me.Button1.Text = "Permisos Personalizados"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmSeguridad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(590, 392)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnPermisoAbm)
        Me.Controls.Add(Me.btnBackup)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnPermiso)
        Me.Controls.Add(Me.btnUsuario)
        Me.Controls.Add(Me.btnGrupo_usuario)
        Me.Name = "frmSeguridad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Seguridad del Sistema"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGrupo_usuario As System.Windows.Forms.Button
    Friend WithEvents btnUsuario As System.Windows.Forms.Button
    Friend WithEvents btnPermiso As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnBackup As System.Windows.Forms.Button
    Friend WithEvents btnPermisoAbm As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
