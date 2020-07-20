Public Class Form1
    Private Sub BtnGo_Click(sender As Object, e As EventArgs) Handles BtnGo.Click
        Dim TxtURL As Object = Nothing
        MikeSurf.Navigate(TxtURL.Text)
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        MikeSurf.GoSearch()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        MikeSurf.GoBack()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        MikeSurf.Refresh()
    End Sub

    Private Sub BtnForward_Click(sender As Object, e As EventArgs) Handles BtnForward.Click
        MikeSurf.GoForward()
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        MikeSurf.GoHome()
    End Sub

    Private Sub MikeSurf_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles MikeSurf.DocumentCompleted

    End Sub
End Class
