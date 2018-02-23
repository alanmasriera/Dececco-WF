Imports DlhSoft.Windows.Controls

Public Class GanttWpf


    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        'GanttChartDataGrid1.ApplyTemplate()
        'Dim startDate As DateTime = DateTime.Today.AddDays(-CInt(DateTime.Today.DayOfWeek))
        'Dim [date] As DateTime = startDate.AddDays(-5 * 7)
        'While [date] < startDate.AddDays(20 * 7)
        '    Dim aux As New ScaleInterval([date], [date].AddDays(7))

        '    GanttChartDataGrid1.Scales(1).Intervals.Add(aux)
        '    'With GanttChartDataGrid1.Scales(1).Intervals.Item(1)
        '    'aux.HeaderContent = [date].ToLongDateString()
        '    'End With
        '    [date] = [date].AddDays(7)
        'End While
        ''For Each interval As ScaleInterval In GanttChartDataGrid1.Scales(2).Intervals
        ''    Dim dayNumber As Integer = CInt((interval.TimeInterval.Start.[Date] - startDate).TotalDays)
        ''    interval.HeaderContent = If(dayNumber >= 0, (dayNumber + 1).ToString(), String.Empty)

        ''Next
        '' Do not allow end users to change the timeline page by using special extra horizontal scrolling buttons.
        'GanttChartDataGrid1.AreUpdateTimelinePageButtonsVisible = False



    End Sub
End Class
