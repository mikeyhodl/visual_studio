Partial Class dsIndisciplineCases2
    Partial Public Class dtIndisciplineCases2DataTable
        Private Sub dtIndisciplineCases2DataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.CURRENTPOINTSColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
