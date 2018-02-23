<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteFactura
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
        Me.reportespantalla = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'reportespantalla
        '
        Me.reportespantalla.ActiveViewIndex = -1
        Me.reportespantalla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reportespantalla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.reportespantalla.Location = New System.Drawing.Point(0, 0)
        Me.reportespantalla.Name = "reportespantalla"
        Me.reportespantalla.SelectionFormula = ""
        Me.reportespantalla.Size = New System.Drawing.Size(1028, 746)
        Me.reportespantalla.TabIndex = 0
        Me.reportespantalla.ViewTimeSelectionFormula = ""
        '
        'FrmReporteFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 746)
        Me.Controls.Add(Me.reportespantalla)
        Me.Name = "FrmReporteFactura"
        Me.Text = "FrmReportePantalla"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents reportespantalla As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
