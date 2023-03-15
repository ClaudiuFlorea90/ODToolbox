Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Interop
Imports CefSharp
Imports CircularProgressBar
Imports Microsoft.Win32
Imports Xamarin.Essentials
Imports System.Diagnostics.Eventing.Reader
Imports System.Text
Imports System.ComponentModel
Imports System.Net
Imports System.Windows.Documents
Imports CefSharp.Web
Imports Newtonsoft.Json
Imports CefSharp.DevTools.CSS
Imports System.Web.Script.Serialization



Module Command

    Public isScanning As Boolean




    Function decryptKey(keyLocation As String, KeyValue As String)



        Dim key As RegistryKey
        key = Registry.LocalMachine.OpenSubKey(keyLocation)

        Dim data As String = Module1.Decrypt(key.GetValue(KeyValue).ToString())

        Return data

        '        Dim json As New JavaScriptSerializer
        '        json.MaxJsonLength = 2147483644
        '        Dim dic As StructuresModule.SignUpRegistrationData = json.Deserialize(Of StructuresModule.SignUpRegistrationData)(Module1.Decrypt(data)
        ')




    End Function


    Public Sub SetMainPanel(Pnl As Panel)

        'Pnl.Size = Pnl.MaximumSize

        If Pnl.Name = ToolBox.PanelInstallNewAgent.Name Then
            Pnl.Location = New Point(0, 70)
        Else
            Pnl.Location = New Point(0, 0)
        End If

        Pnl.Size = Frame.PnlMain.Size
        Pnl.Location = New Point(0, 0)
        Pnl.Show()
        Pnl.BringToFront()

    End Sub

    Public Sub SetMainForm(Form As Form, btn As Button)

        For Each item As Control In Frame.PnlMenu.Controls
            If item.GetType = GetType(Button) Then
                item.BackColor = ColorTranslator.FromHtml("30, 39, 46")
            End If
        Next

        btn.BackColor = ColorTranslator.FromHtml("109, 33, 79")
        Frame.Lbl_TopLabel.Text = btn.Text
        Frame.PnlMain.Controls.Clear()
        Form.TopLevel = False
        Frame.PnlMain.Controls.Add(Form)
        Form.Show()

        '    'To show ticket title as Top label if ticket was created for
        If btn.Name = "Btn_Ticket" Then
            If Ticket.Is_Ticket_Created Then
                Frame.Lbl_TopLabel.Text = Ticket.Ticket_Title
            End If

        End If

    End Sub

    'Switch Virus Scan sub panel
    Public Sub ChangeScanningPanel(ByVal panel As Panel)


        VirusScanForm.Pnl_IsScanning.Hide()
        VirusScanForm.Panel6.Hide()
        VirusScanForm.Pnl_ScanCompleted.Hide()

        panel.Show()
        panel.BringToFront()
        'panel.Location = VirusScanForm.PanelDefaultLocation1.Location

        If panel.Name = VirusScanForm.Panel6.Name Then
            panel.Location = New Point(217, 4)
        Else
            panel.Location = New Point(28, 55)
        End If

    End Sub



    Sub Settings()

        'VirusScanForm.Label45.Text = PowerShell("(Get-MpComputerStatus).AntispywareSignatureLastUpdated")
        'VirusScanForm.LblAntispyware.Text = PowerShell("(Get-MpComputerStatus).AntispywareEnabled")
        'VirusScanForm.LabelRealTimeProtection.Text = PowerShell("(Get-MpComputerStatus).RealTimeProtectionEnabled")

    End Sub


    Sub Protection()

        ''Anti-Spy
        'Dim antiSpyware As String = Command.PowerShell("(Get-MpComputerStatus).AntispywareEnabled").Replace(vbCrLf, "")


        'If antiSpyware = "True" Then
        '    VirusScanForm.ToggleAntispy.Checked = True

        'Else
        '    VirusScanForm.ToggleAntispy.Checked = False
        'End If


        '''Real-Time
        'Dim realTime As String = Command.PowerShell("(Get-MpComputerStatus).RealTimeProtectionEnabled").Replace(vbCrLf, "")


        'If realTime = "True" Then
        '    VirusScanForm.ToggleRealTime.Checked = True

        'Else

        '    VirusScanForm.ToggleRealTime.Checked = False
        'End If

        '''Web-Protection
        ''ToggleWebProtection

        '''Anti ransom
        'ToggleAntiRansom
    End Sub



    Public Function PowerShellCmd(Cmdlet As String)


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



    Function SlideShow()


        Dim DummyLocation As New Point(88, 60)


        Dim Time As Integer = 0



        Do

            Time = Time + 1

            If isScanning = True Then


                VirusScanForm.PanelLastScan.Hide()
                VirusScanForm.Panel12.Hide()

                VirusScanForm.PanelProtection.Hide()

                VirusScanForm.PanelVirusScanSlideshow.Show()
                'PanelVirusScanSlideshow.BringToFront()
                VirusScanForm.PanelVirusScanSlideshow.Location = DummyLocation


            Else



                If Time = 5 Then
                    VirusScanForm.PanelLastScan.Location = DummyLocation
                    VirusScanForm.PanelLastScan.Show()

                End If


                If Time = 15 Then

                    VirusScanForm.PanelLastScan.Hide()
                    VirusScanForm.PanelProtection.Hide()


                    VirusScanForm.Panel12.Location = DummyLocation
                    VirusScanForm.Panel12.Show()

                End If



                If Time > 25 Then

                    Time = 0

                    VirusScanForm.PanelLastScan.Hide()
                    VirusScanForm.Panel12.Hide()
                    VirusScanForm.PanelVirusScanSlideshow.Hide()
                    VirusScanForm.PanelProtection.Show()
                End If

            End If


            Thread.Sleep(1000)

        Loop


    End Function


    Function byteNice(TheSize As Long, Optional scurt As Boolean = False) As String
        Try
            Dim DoubleBytes As Double
            Select Case TheSize
                Case Is >= 1099511627776
                    DoubleBytes = CDbl(TheSize / 1099511627776) 'TB
                    If scurt Then
                        Return Int(DoubleBytes) & "TB"
                    Else
                        Return FormatNumber(DoubleBytes, 2) & " TB"
                    End If
                Case 1073741824 To 1099511627775
                    DoubleBytes = CDbl(TheSize / 1073741824) 'GB
                    If scurt Then
                        Return Int(DoubleBytes) & "GB"
                    Else
                        Return FormatNumber(DoubleBytes, 2) & " GB"
                    End If
                Case 1048576 To 1073741823
                    DoubleBytes = CDbl(TheSize / 1048576) 'MB
                    If scurt Then
                        Return Int(DoubleBytes) & "MB"
                    Else
                        Return FormatNumber(DoubleBytes, 2) & " MB"
                    End If
                Case 1024 To 1048575
                    DoubleBytes = CDbl(TheSize / 1024) 'KB
                    If scurt Then
                        Return Int(DoubleBytes) & "KB"
                    Else
                        Return FormatNumber(DoubleBytes, 2) & " KB"
                    End If
                Case 0 To 1023
                    DoubleBytes = TheSize ' bytes
                    If scurt Then
                        Return Int(DoubleBytes) & "B"
                    Else
                        Return FormatNumber(DoubleBytes, 2) & " B"
                    End If
                Case Else
                    Return ""
            End Select
        Catch
            Return ""
        End Try
    End Function




End Module
