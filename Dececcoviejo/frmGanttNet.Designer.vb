<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGanttNet
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGanttNet))
        Me.GanttChartView2 = New DlhSoft.ProjectDataControlLibrary.GanttChartView()
        Me.GanttChartView2SplitContainer = New System.Windows.Forms.SplitContainer()
        Me.GanttChartView2TasksTreeGrid = New DlhSoft.ProjectDataControlLibrary.TasksTreeGrid()
        Me.GanttChartView2GanttChartPanel = New DlhSoft.ProjectDataControlLibrary.GanttChartPanel()
        Me.GanttChartView2GanttChartHeader = New DlhSoft.ProjectDataControlLibrary.GanttChartHeader()
        Me.GanttChartView2GanttChartArea = New DlhSoft.ProjectDataControlLibrary.GanttChartArea()
        Me.GanttChartView2GanttChartVerticalScrollBar = New DlhSoft.ProjectDataControlLibrary.GanttChartVerticalScrollBar()
        Me.GanttChartView2GanttChartCurrentDateScrollBar = New DlhSoft.ProjectDataControlLibrary.GanttChartCurrentDateScrollBar()
        Me.GanttChartView2.SuspendLayout()
        CType(Me.GanttChartView2SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GanttChartView2SplitContainer.Panel1.SuspendLayout()
        Me.GanttChartView2SplitContainer.Panel2.SuspendLayout()
        Me.GanttChartView2SplitContainer.SuspendLayout()
        CType(Me.GanttChartView2TasksTreeGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GanttChartView2GanttChartPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'GanttChartView2
        '
        Me.GanttChartView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GanttChartView2.Controls.Add(Me.GanttChartView2SplitContainer)
        Me.GanttChartView2.DefaultAssignmentsBrush = Nothing
        Me.GanttChartView2.DefaultAssignmentsFont = Nothing
        Me.GanttChartView2.DefaultBarTextsBrush = Nothing
        Me.GanttChartView2.DefaultBarTextsFont = Nothing
        Me.GanttChartView2.DefaultBottomTextsBrush = Nothing
        Me.GanttChartView2.DefaultBottomTextsFont = Nothing
        Me.GanttChartView2.DefaultCriticalRemainingsTextBrush = Nothing
        Me.GanttChartView2.DefaultCriticalRemainingsTextFont = Nothing
        Me.GanttChartView2.DefaultLeftTextsBrush = Nothing
        Me.GanttChartView2.DefaultLeftTextsFont = Nothing
        Me.GanttChartView2.DefaultTopTextsBrush = Nothing
        Me.GanttChartView2.DefaultTopTextsFont = Nothing
        Me.GanttChartView2.Location = New System.Drawing.Point(21, 26)
        Me.GanttChartView2.Name = "GanttChartView2"
        Me.GanttChartView2.Size = New System.Drawing.Size(694, 348)
        Me.GanttChartView2.TabIndex = 1
        '
        'GanttChartView2SplitContainer
        '
        Me.GanttChartView2SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GanttChartView2SplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.GanttChartView2SplitContainer.Name = "GanttChartView2SplitContainer"
        '
        'GanttChartView2SplitContainer.Panel1
        '
        Me.GanttChartView2SplitContainer.Panel1.Controls.Add(Me.GanttChartView2TasksTreeGrid)
        '
        'GanttChartView2SplitContainer.Panel2
        '
        Me.GanttChartView2SplitContainer.Panel2.Controls.Add(Me.GanttChartView2GanttChartPanel)
        Me.GanttChartView2SplitContainer.Panel2.Controls.Add(Me.GanttChartView2GanttChartCurrentDateScrollBar)
        Me.GanttChartView2SplitContainer.Size = New System.Drawing.Size(692, 346)
        Me.GanttChartView2SplitContainer.SplitterDistance = 346
        Me.GanttChartView2SplitContainer.TabIndex = 0
        '
        'GanttChartView2TasksTreeGrid
        '
        Me.GanttChartView2TasksTreeGrid.BackgroundColor = System.Drawing.SystemColors.Window
        Me.GanttChartView2TasksTreeGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GanttChartView2TasksTreeGrid.ColumnHeadersHeight = 40
        Me.GanttChartView2TasksTreeGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GanttChartView2TasksTreeGrid.EnableHeadersVisualStyles = False
        Me.GanttChartView2TasksTreeGrid.Location = New System.Drawing.Point(0, 0)
        Me.GanttChartView2TasksTreeGrid.Name = "GanttChartView2TasksTreeGrid"
        Me.GanttChartView2TasksTreeGrid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GanttChartView2TasksTreeGrid.Size = New System.Drawing.Size(346, 346)
        Me.GanttChartView2TasksTreeGrid.TabIndex = 0
        Me.GanttChartView2TasksTreeGrid.TreeMinusIcon = CType(resources.GetObject("GanttChartView2TasksTreeGrid.TreeMinusIcon"), System.Drawing.Icon)
        Me.GanttChartView2TasksTreeGrid.TreePlusIcon = CType(resources.GetObject("GanttChartView2TasksTreeGrid.TreePlusIcon"), System.Drawing.Icon)
        '
        'GanttChartView2GanttChartPanel
        '
        Me.GanttChartView2GanttChartPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GanttChartView2GanttChartPanel.BackColor = System.Drawing.SystemColors.Window
        Me.GanttChartView2GanttChartPanel.Controls.Add(Me.GanttChartView2GanttChartHeader)
        Me.GanttChartView2GanttChartPanel.Controls.Add(Me.GanttChartView2GanttChartArea)
        Me.GanttChartView2GanttChartPanel.Controls.Add(Me.GanttChartView2GanttChartVerticalScrollBar)
        Me.GanttChartView2GanttChartPanel.Location = New System.Drawing.Point(0, 0)
        Me.GanttChartView2GanttChartPanel.Name = "GanttChartView2GanttChartPanel"
        Me.GanttChartView2GanttChartPanel.Size = New System.Drawing.Size(342, 329)
        Me.GanttChartView2GanttChartPanel.TabIndex = 0
        '
        'GanttChartView2GanttChartHeader
        '
        Me.GanttChartView2GanttChartHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GanttChartView2GanttChartHeader.BackColor = System.Drawing.SystemColors.Control
        Me.GanttChartView2GanttChartHeader.Location = New System.Drawing.Point(0, 0)
        Me.GanttChartView2GanttChartHeader.Name = "GanttChartView2GanttChartHeader"
        Me.GanttChartView2GanttChartHeader.Size = New System.Drawing.Size(342, 40)
        Me.GanttChartView2GanttChartHeader.TabIndex = 0
        '
        'GanttChartView2GanttChartArea
        '
        Me.GanttChartView2GanttChartArea.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GanttChartView2GanttChartArea.DefaultAssignmentsBrush = Nothing
        Me.GanttChartView2GanttChartArea.DefaultAssignmentsFont = Nothing
        Me.GanttChartView2GanttChartArea.DefaultBarTextsBrush = Nothing
        Me.GanttChartView2GanttChartArea.DefaultBarTextsFont = Nothing
        Me.GanttChartView2GanttChartArea.DefaultBottomTextsBrush = Nothing
        Me.GanttChartView2GanttChartArea.DefaultBottomTextsFont = Nothing
        Me.GanttChartView2GanttChartArea.DefaultCriticalRemainingsTextBrush = Nothing
        Me.GanttChartView2GanttChartArea.DefaultCriticalRemainingsTextFont = Nothing
        Me.GanttChartView2GanttChartArea.DefaultLeftTextsBrush = Nothing
        Me.GanttChartView2GanttChartArea.DefaultLeftTextsFont = Nothing
        Me.GanttChartView2GanttChartArea.DefaultTopTextsBrush = Nothing
        Me.GanttChartView2GanttChartArea.DefaultTopTextsFont = Nothing
        Me.GanttChartView2GanttChartArea.Location = New System.Drawing.Point(0, 40)
        Me.GanttChartView2GanttChartArea.Name = "GanttChartView2GanttChartArea"
        Me.GanttChartView2GanttChartArea.Size = New System.Drawing.Size(342, 289)
        Me.GanttChartView2GanttChartArea.TabIndex = 1
        '
        'GanttChartView2GanttChartVerticalScrollBar
        '
        Me.GanttChartView2GanttChartVerticalScrollBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GanttChartView2GanttChartVerticalScrollBar.LargeChange = 0
        Me.GanttChartView2GanttChartVerticalScrollBar.Location = New System.Drawing.Point(342, 0)
        Me.GanttChartView2GanttChartVerticalScrollBar.Maximum = 0
        Me.GanttChartView2GanttChartVerticalScrollBar.Name = "GanttChartView2GanttChartVerticalScrollBar"
        Me.GanttChartView2GanttChartVerticalScrollBar.Size = New System.Drawing.Size(17, 329)
        Me.GanttChartView2GanttChartVerticalScrollBar.SmallChange = 0
        Me.GanttChartView2GanttChartVerticalScrollBar.TabIndex = 2
        '
        'GanttChartView2GanttChartCurrentDateScrollBar
        '
        Me.GanttChartView2GanttChartCurrentDateScrollBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GanttChartView2GanttChartCurrentDateScrollBar.LargeChange = 7
        Me.GanttChartView2GanttChartCurrentDateScrollBar.Location = New System.Drawing.Point(0, 329)
        Me.GanttChartView2GanttChartCurrentDateScrollBar.Maximum = 730
        Me.GanttChartView2GanttChartCurrentDateScrollBar.Name = "GanttChartView2GanttChartCurrentDateScrollBar"
        Me.GanttChartView2GanttChartCurrentDateScrollBar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GanttChartView2GanttChartCurrentDateScrollBar.Size = New System.Drawing.Size(342, 17)
        Me.GanttChartView2GanttChartCurrentDateScrollBar.TabIndex = 1
        '
        'frmGanttNet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 408)
        Me.Controls.Add(Me.GanttChartView2)
        Me.Name = "frmGanttNet"
        Me.Text = "frmGanttNet"
        Me.GanttChartView2.ResumeLayout(False)
        Me.GanttChartView2SplitContainer.Panel1.ResumeLayout(False)
        Me.GanttChartView2SplitContainer.Panel2.ResumeLayout(False)
        CType(Me.GanttChartView2SplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GanttChartView2SplitContainer.ResumeLayout(False)
        CType(Me.GanttChartView2TasksTreeGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GanttChartView2GanttChartPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GanttChartView2 As DlhSoft.ProjectDataControlLibrary.GanttChartView
    Friend WithEvents GanttChartView2SplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents GanttChartView2TasksTreeGrid As DlhSoft.ProjectDataControlLibrary.TasksTreeGrid
    Friend WithEvents GanttChartView2GanttChartPanel As DlhSoft.ProjectDataControlLibrary.GanttChartPanel
    Friend WithEvents GanttChartView2GanttChartHeader As DlhSoft.ProjectDataControlLibrary.GanttChartHeader
    Friend WithEvents GanttChartView2GanttChartArea As DlhSoft.ProjectDataControlLibrary.GanttChartArea
    Friend WithEvents GanttChartView2GanttChartVerticalScrollBar As DlhSoft.ProjectDataControlLibrary.GanttChartVerticalScrollBar
    Friend WithEvents GanttChartView2GanttChartCurrentDateScrollBar As DlhSoft.ProjectDataControlLibrary.GanttChartCurrentDateScrollBar
End Class
