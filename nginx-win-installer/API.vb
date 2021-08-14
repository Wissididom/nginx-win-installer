Public Class API
    Public Shared Function DownloadLatestNgnix(ByVal Optional filepath As String = Nothing)
        Dim wc As New Net.WebClient()
        Dim html As String = wc.DownloadString("http://nginx.org/en/download.html")
        html = html.Substring(html.IndexOf("<h4>Mainline version</h4>") + "<h4>Mainline version</h4>".Length)
        Dim r As New Text.RegularExpressions.Regex("<a href=""(\/download\/nginx-[0-9\.]+zip)"">")
        Dim m As Text.RegularExpressions.Match = r.Match(html)
        Dim latest As String = "http://nginx.org" & m.Groups(1).Value
        Dim latestFilename As String = latest.Substring(latest.LastIndexOf("/"c) + 1)
        If Not IsNothing(filepath) Then
            wc.DownloadFile(latest, (filepath & IO.Path.DirectorySeparatorChar & latestFilename).Replace("//", "/").Replace("\\", "\"))
        Else
            wc.DownloadFile(latest, latestFilename)
        End If
        Return latestFilename
    End Function

    Public Shared Sub UnZip(ByVal inputZip As String, ByVal outputFolder As String)
        Dim shObj As Object = Activator.CreateInstance(Type.GetTypeFromProgID("Shell.Application"))
        'Create directory in which you will unzip your items.
        IO.Directory.CreateDirectory(outputFolder)
        'Declare the folder where the items will be extracted.
        Dim output As Object = shObj.NameSpace((outputFolder))
        'Declare the input zip file.
        Dim input As Object = shObj.NameSpace((inputZip))
        'Extract the items from the zip file.
        output.CopyHere((input.Items), 4)
    End Sub

    Public Shared Sub CreateShortCut(ByVal TargetName As String, ByVal ShortCutPath As String, ByVal ShortCutName As String, ByVal Optional WorkingDirectory As String = Nothing)
        Dim oShell As Object
        Dim oLink As Object
        Try
            oShell = CreateObject("WScript.Shell")
            oLink = oShell.CreateShortcut(ShortCutPath & IO.Path.DirectorySeparatorChar & ShortCutName & ".lnk")
            oLink.TargetPath = TargetName
            If Not IsNothing(WorkingDirectory) Then oLink.WorkingDirectory = WorkingDirectory
            oLink.WindowStyle = 4
            oLink.Save()
        Catch ex As Exception : End Try
    End Sub
End Class
