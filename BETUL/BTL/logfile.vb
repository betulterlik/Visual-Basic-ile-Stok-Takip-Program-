Public Class LogFile

    Public Property Path As String
    Dim sw As IO.StreamWriter
    Dim strFile As String


    Public Sub New(ByVal IniPath As String)
        _Path = IniPath
        If (Not System.IO.Directory.Exists(IniPath)) Then
            System.IO.Directory.CreateDirectory(IniPath)
        End If
    End Sub

    Public Sub WriteLog(ByVal Log As String)


        strFile = Path & "\" & DateTime.Today.ToString("yyyy-MM-dd") & ".log"

        If IO.File.Exists(strFile) = False Then

            sw = IO.File.CreateText(strFile)
            sw.WriteLine(DateTime.Now.ToString("HH:mm:ss") & " : " & Log)
            sw.Close()

        Else

            sw = IO.File.AppendText(strFile)
            sw.WriteLine(DateTime.Now.ToString("HH:mm:ss") & " : " & Log)
            sw.Close()

        End If

    End Sub

End Class
