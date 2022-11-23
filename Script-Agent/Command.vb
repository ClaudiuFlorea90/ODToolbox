
Imports System.Threading

Module Command

    Public isScanning As Boolean


    'Switch Virus Scan sub panel



    Public Sub ChangeScanningPanel(ByVal panel As Panel)


        VirusScanForm.Pnl_IsScanning.Hide()
        VirusScanForm.Panel6.Hide()
        VirusScanForm.Pnl_ScanCompleted.Hide()

        panel.Show()
        panel.BringToFront()
        'panel.Location = VirusScanForm.PanelDefaultLocation1.Location





        If panel.Name = VirusScanForm.Panel6.Name Then
            panel.Location = New Point(183, 14)
        Else
            panel.Location = New Point(28, 55)
        End If





    End Sub




    'Panel hover line







    Public Function PowerShell(Cmdlet As String)


        Dim p As Process = New Process()
        p.StartInfo.FileName = "PowerShell.exe"
        p.StartInfo.UseShellExecute = False
        p.StartInfo.CreateNoWindow = True
        p.StartInfo.RedirectStandardOutput = True
        p.StartInfo.RedirectStandardError = True

        'Detected Count
        p.StartInfo.Arguments = Cmdlet
        p.Start()
        p.WaitForExit()
        Dim CmdletOutut As String = p.StandardOutput.ReadToEnd()
        Dim CmdletError As String = p.ExitCode



        Return CmdletOutut

    End Function




End Module
