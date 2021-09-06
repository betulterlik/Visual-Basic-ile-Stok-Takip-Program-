Public Class INIfile

    Private Declare Ansi Function GetPrivateProfileString Lib "kernel32.dll" Alias "GetPrivateProfileStringA" _
           (ByVal lpApplicationName As String,
            ByVal lpKeyName As String,
            ByVal lpDefault As String,
            ByVal lpReturnedString As System.Text.StringBuilder,
            ByVal nSize As Integer,
            ByVal lpFileName As String) _
        As Integer

    Private Declare Ansi Function WritePrivateProfileString Lib "kernel32.dll" Alias "WritePrivateProfileStringA" _
        (ByVal lpApplicationName As String,
         ByVal lpKeyName As String,
         ByVal lpString As String,
         ByVal lpFileName As String) _
    As Integer

    Public Property Path As String

    ''' <summary>
    ''' IniFile Constructor
    ''' </summary>
    ''' <param name="IniPath">The path to the INI file.</param>
    Public Sub New(ByVal IniPath As String)
        _Path = IniPath
    End Sub

    Function AsciiToUtf8(ByRef s As String) As String
        Return System.Text.Encoding.GetEncoding("utf-8").GetString(System.Text.Encoding.Default.GetBytes(s))
    End Function

    '''<summary>
    '''Read value from INI file
    ''' </summary>
    ''' <param name = "section" > The section Of the file To look In</param>
    ''' <param name = "key" > The key In the section To look For</param>
    Public Function ReadValue(ByVal section As String, ByVal key As String) As String
        Dim sb As New System.Text.StringBuilder(255)
        Dim i = GetPrivateProfileString(section, key, "", sb, 255, Path)
        Return AsciiToUtf8(sb.ToString())
    End Function

    ''' <summary>
    ''' Write value to INI file
    ''' </summary>
    ''' <param name="section">The section of the file to write in</param>
    ''' <param name="key">The key in the section to write</param>
    ''' <param name="value">The value to write for the key</param>
    Public Sub WriteValue(ByVal section As String, ByVal key As String, ByVal value As String)
        WritePrivateProfileString(section, key, value, Path)
    End Sub

End Class



