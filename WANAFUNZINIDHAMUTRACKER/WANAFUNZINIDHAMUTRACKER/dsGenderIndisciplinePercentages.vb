Partial Class dsGenderIndisciplinePercentages
    Partial Public Class dtGenderIndisciplinePercentagesDataTable
        Private Sub dtGenderIndisciplinePercentagesDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.ADMISSIONNUMBERColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
