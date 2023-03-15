Imports System.Management
Imports CefSharp.DevTools.CSS
Imports CefSharp.DevTools.Memory
Imports Microsoft.Win32
Imports System.Net
Imports System.ComponentModel

Public Class Settings


    Dim log As String = My.Application.Info.DirectoryPath + "\log.log"




    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '  RunAtStartup()
        Me.Size = Frame.PnlMain.MaximumSize

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If System.IO.File.Exists(log) = True Then
            Process.Start(log)
        Else
            MsgBox("Log does not exist")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If System.IO.File.Exists(log) = True Then
            My.Computer.FileSystem.DeleteFile(log)

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim client As New WebClient()

        AddHandler client.DownloadFileCompleted, AddressOf downloadCompleted
        AddHandler client.DownloadProgressChanged, AddressOf downloadProgressChanged

        client.DownloadFileAsync(New Uri("https://updateor.optimumdesk.com/public/kits/ODUninstaller.exe"), "C:\file.txt")

    End Sub



    Private Sub downloadCompleted(sender As Object, e As AsyncCompletedEventArgs)
        If e.Error IsNot Nothing Then
            MsgBox("Error: " & e.Error.Message)
        Else
            MsgBox("File downloaded successfully.")
        End If
    End Sub

    Private Sub downloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs)

        ProgressBar1.Value = e.ProgressPercentage

    End Sub



End Class