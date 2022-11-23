Imports System.Management

Public Class Settings





    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RunAtStartup()


    End Sub

    Sub RunAtStartup()


        Dim JobID As String = "Test"
        Dim mgmtClass As New ManagementClass("Win32_ScheduledJob")
        Dim methodArgs(6) As Object 'seven arguments
        methodArgs(0) = "Notepad.exe"
        methodArgs(1) = "********143000.000000-420"
        methodArgs(2) = True
        methodArgs(3) = 1 Or 4 Or 16 'days of the week? 
        methodArgs(4) = Nothing
        methodArgs(5) = True
        methodArgs(6) = JobID
        'Execute the method
        Dim errorNum As Integer = mgmtClass.InvokeMethod("Create", methodArgs)
        MsgBox(errorNum) 'Zero means success. 

    End Sub


End Class