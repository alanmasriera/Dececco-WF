<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalendario
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
        Me.mcCalendario = New System.Windows.Forms.MonthCalendar()
        Me.SuspendLayout()
        '
        'mcCalendario
        '
        Me.mcCalendario.CalendarDimensions = New System.Drawing.Size(4, 3)
        Me.mcCalendario.Location = New System.Drawing.Point(7, 8)
        Me.mcCalendario.Name = "mcCalendario"
        Me.mcCalendario.TabIndex = 0
        '
        'frmCalendario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 463)
        Me.Controls.Add(Me.mcCalendario)
        Me.Name = "frmCalendario"
        Me.Text = "frmCalendario"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mcCalendario As System.Windows.Forms.MonthCalendar
End Class
