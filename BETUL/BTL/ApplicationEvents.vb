Imports System.IO

Namespace My

    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication

        'One of the global exceptions we are catching is not thread safe, so we need to make it thread safe first.
        Private Delegate Sub SafeApplicationThreadException(ByVal sender As Object, ByVal e As Threading.ThreadExceptionEventArgs)

        Private Sub ShowDebugOutput(ByVal ex As Exception)

            'Dim exePath As String = frm_main.ExecutablePath

            'Display the output form
            'frm_main.SendErrorMail(ex.ToString())

            'Process.Start(exePath)

            'Perform application cleanup
            'TODO: Add your application cleanup code here.

            'Exit the application - Or try to recover from the exception:
            Environment.Exit(0)

        End Sub

        Function AnyOfThePropertyEmpty() As Boolean
            My.Settings.Reload()

            'If My.Settings.firstrun = True Then
            '    Return True
            'End If

            For Each value As System.Configuration.SettingsPropertyValue In My.Settings.PropertyValues
                If (value.SerializedValue.ToString = String.Empty) Or (value.SerializedValue.ToString = "0") Then
                    Return True
                End If
            Next
            Return False

        End Function

        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup

            If AnyOfThePropertyEmpty() Then

                Dim myChild As New frm_MySettings
                If (myChild.ShowDialog() = DialogResult.No) Then
                    MsgBox("Program is Closing. If you want to use this program, please set all settings areas.", MsgBoxStyle.Information)
                    Environment.Exit(0)
                End If

            End If

            'There are three places to catch all global unhandled exceptions:
            'AppDomain.CurrentDomain.UnhandledException event.
            'System.Windows.Forms.Application.ThreadException event.
            'MyApplication.UnhandledException event.
            AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf AppDomain_UnhandledException
            AddHandler System.Windows.Forms.Application.ThreadException, AddressOf app_ThreadException

        End Sub

        Private Sub app_ThreadException(ByVal sender As Object, ByVal e As Threading.ThreadExceptionEventArgs)

            'This is not thread safe, so make it thread safe.
            If MainForm.InvokeRequired Then
                ' Invoke back to the main thread
                MainForm.Invoke(New SafeApplicationThreadException(AddressOf app_ThreadException), New Object() {sender, e})
            Else
                ShowDebugOutput(e.Exception)
            End If

        End Sub

        Private Sub AppDomain_UnhandledException(ByVal sender As Object, ByVal e As UnhandledExceptionEventArgs)

            ShowDebugOutput(DirectCast(e.ExceptionObject, Exception))

        End Sub

        Private Sub MyApplication_UnhandledException(sender As Object, e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            Dim myFilePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                                                      "unhelded_exception.log")

            Using sw As New StreamWriter(File.Open(myFilePath, FileMode.Append))
                sw.WriteLine(DateTime.Now)
                sw.WriteLine(e.Exception.Message)
            End Using

            ShowDebugOutput(e.Exception)

        End Sub
    End Class

End Namespace