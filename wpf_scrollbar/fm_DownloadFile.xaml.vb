Imports System.Collections.ObjectModel

Public Class fm_DownloadFile
    Private Sub Cb_File_Select_Checked(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub Form_Load()


        Dim gOC As New ObservableCollection(Of File_ListItem)



        Dim f1 As New File_ListItem
        f1.Download_Comp = 10
        f1.FileSelect = False
        f1.FileName = "123.txt"


        Dim f2 As New File_ListItem
        f2.Download_Comp = 40
        f2.FileSelect = True
        f2.FileName = "test.pdf"

        gOC.Add(f1)

        gOC.Add(f2)

        lbFileList.ItemsSource = gOC

    End Sub


    Class File_ListItem
        Property FileSelect As Boolean
        Property FileName As String
        Property Download_Comp As Integer
    End Class

    Private Sub Btn_cancel_Click(sender As Object, e As RoutedEventArgs)

        MsgBox(123)

    End Sub
End Class
