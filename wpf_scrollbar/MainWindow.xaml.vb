Class MainWindow



    Private Sub Window_Loaded_1(sender As Object, e As RoutedEventArgs)
        'Dim pg As page_lsit = New page_lsit
        'Dim pg As pg_testbtn = New pg_testbtn
        Dim pg As Page = New page_empty

        main_frame.NavigationUIVisibility = NavigationUIVisibility.Hidden
        main_frame.NavigationService.Navigate(pg)

        Dim desktopWorkingArea = System.Windows.SystemParameters.WorkArea
        Left = desktopWorkingArea.Right - Width
        Top = desktopWorkingArea.Bottom - Height
    End Sub

    Dim sw As Boolean = False
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)


        Dim pg As Page = New Page_spinner
        main_frame.NavigationService.Navigate(pg)

        If sw Then
            pg = New page_display
            main_frame.NavigationService.Navigate(pg)
        End If
        sw = True
        ' Threading.Thread.Sleep(5000)


        ' pg = New page_display
        ' main_frame.NavigationService.Navigate(pg)

    End Sub
End Class
