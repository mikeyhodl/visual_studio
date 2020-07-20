Partial Class dsIndisciplinePercentages
    Partial Public Class dtIndisciplinePercentagesDataTable
        Private Sub dtIndisciplinePercentagesDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.TotalEnrolmentColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

        Private Sub dtIndisciplinePercentagesDataTable_dtIndisciplinePercentagesRowChanging(sender As Object, e As dtIndisciplinePercentagesRowChangeEvent) Handles Me.dtIndisciplinePercentagesRowChanging

        End Sub

    End Class
End Class
