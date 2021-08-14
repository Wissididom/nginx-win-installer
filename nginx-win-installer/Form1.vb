Imports System.IO
Imports System.IO.Compression
Public Class Form1
    Private Sub cb_savetoworkingdirectory_CheckedChanged(sender As Object, e As EventArgs) Handles cb_savetoworkingdirectory.CheckedChanged
        If cb_savetoworkingdirectory.Checked Then
            txt_destination_folder.Enabled = False
            btn_destination_folder.Enabled = False
        Else
            txt_destination_folder.Enabled = True
            btn_destination_folder.Enabled = True
        End If
    End Sub

    Private Sub btn_destination_folder_Click(sender As Object, e As EventArgs) Handles btn_destination_folder.Click
        Dim fbd As New FolderBrowserDialog()
        fbd.SelectedPath = Application.StartupPath
        fbd.ShowNewFolderButton = True
        If fbd.ShowDialog() = DialogResult.OK Then
            txt_destination_folder.Text = fbd.SelectedPath
        End If
    End Sub

    Private Sub btn_install_Click(sender As Object, e As EventArgs) Handles btn_install.Click
        Dim destinationFolder As String = Nothing
        If Not cb_savetoworkingdirectory.Checked Then
            destinationFolder = txt_destination_folder.Text
        End If
        Dim latestName As String = API.DownloadLatestNgnix(destinationFolder)
        If IsNothing(destinationFolder) Then destinationFolder = Application.StartupPath
        API.UnZip(destinationFolder & Path.DirectorySeparatorChar & latestName, destinationFolder)
        Dim currentPath As String = Environment.GetEnvironmentVariable("PATH")
        If Not currentPath.EndsWith(Path.PathSeparator) Then
            currentPath &= Path.PathSeparator
        End If
        Dim nginxPath As String = destinationFolder & Path.DirectorySeparatorChar & latestName.Substring(0, latestName.LastIndexOf(".zip"))
        currentPath &= nginxPath
        Environment.SetEnvironmentVariable("PATH", currentPath, EnvironmentVariableTarget.Machine)
        File.Delete(destinationFolder & Path.DirectorySeparatorChar & latestName)
        API.CreateShortCut(nginxPath & Path.DirectorySeparatorChar & "nginx.exe", My.Computer.FileSystem.SpecialDirectories.Desktop, "NGNIX", nginxPath)
        MsgBox("NGINX was successfully installed.", MsgBoxStyle.ApplicationModal, "Installed")
    End Sub
End Class
