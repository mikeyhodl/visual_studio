Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)

        If RadioButton1.IsChecked = True Then
            MessageBox.Show("Helllo.")
        Else RadioButton2.IsChecked = True
            MessageBox.Show("Goodbye.")
        End If

    End Sub
End Class
