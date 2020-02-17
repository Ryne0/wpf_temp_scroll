Class MainWindow



    Private Sub Window_Loaded_1(sender As Object, e As RoutedEventArgs)
        'Dim pg As page_lsit = New page_lsit
        Dim pg As pg_testbtn = New pg_testbtn

        main_frame.NavigationUIVisibility = NavigationUIVisibility.Hidden
        main_frame.NavigationService.Navigate(pg)

        Dim desktopWorkingArea = System.Windows.SystemParameters.WorkArea
        Left = desktopWorkingArea.Right - Width
        Top = desktopWorkingArea.Bottom - Height
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim x As New rec_case
        x.ShowDialog()
    End Sub
End Class
