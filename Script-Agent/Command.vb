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




    Public Sub LoadUserInfo()
        If getUserFromAgent() = False Then
            Dim x = getUserFromRegedit()
            If x.companyId IsNot Nothing Then
                ToolBox.customer_name = x.firstname
                ToolBox.customer_lastname = x.lastname
                ToolBox.customer_email = x.email
                ToolBox.TB_MailToAddress.Text = x.email
            End If
        End If
    End Sub

    Public Function getUserFromRegedit() As SignUpRegistrationData

        Dim RegKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\ODToolbox")
        If RegKey IsNot Nothing AndAlso RegKey.GetValue("4SmT/pypiUiAOJnVV3zvrw==") IsNot Nothing Then
            Dim data As String = RegKey.GetValue("4SmT/pypiUiAOJnVV3zvrw==").ToString()
            Dim json As New JavaScriptSerializer
            json.MaxJsonLength = 2147483644
            Dim User = json.Deserialize(Of StructuresModule.SignUpRegistrationData)(Module1.Decrypt(data))
            Return User
        Else
            Return Nothing
        End If
    End Function




    Public Function getUserFromAgent() As Boolean

        Try
            Dim dic As StructuresModule.SignUpRegistrationData = Nothing
            Dim key1 As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\OptimumDesk\Account")
            Dim key2 As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Class IT\OD")
            Dim key3 As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\PCMatic\Account")

            If key1 IsNot Nothing AndAlso key1.GetValue("NCne5NUp41ltZ+S8rPJxIg==") IsNot Nothing Then
                Dim data As String = key1.GetValue("NCne5NUp41ltZ+S8rPJxIg==").ToString()
                Dim json As New JavaScriptSerializer
                json.MaxJsonLength = 2147483644
                dic = json.Deserialize(Of StructuresModule.SignUpRegistrationData)(Module1.Decrypt(data))
            ElseIf key2 IsNot Nothing AndAlso key2.GetValue("9tetZAYnyZixCW721LyyoA==") IsNot Nothing Then
                dic = New StructuresModule.SignUpRegistrationData()
                dic.firstname = Module1.Decrypt(key2.GetValue("9tetZAYnyZixCW721LyyoA==").ToString())
                dic.lastname = Module1.Decrypt(key2.GetValue("yi6tK32jAfVY4fcS9Nj5tw==").ToString())
                dic.email = Module1.Decrypt(key2.GetValue("SR3KCHzp11pUpTrd88mOOA==").ToString())
            ElseIf key3 IsNot Nothing AndAlso key3.GetValue("NCne5NUp41ltZ+S8rPJxIg==") IsNot Nothing Then
                Dim data As String = key3.GetValue("NCne5NUp41ltZ+S8rPJxIg==").ToString()
                Dim json As New JavaScriptSerializer
                json.MaxJsonLength = 2147483644
                dic = json.Deserialize(Of StructuresModule.SignUpRegistrationData)(Module1.Decrypt(data))
            End If

            If dic.email IsNot Nothing And dic.firstname IsNot Nothing And dic.lastname IsNot Nothing Then


                ToolBox.customer_name = dic.firstname
                ToolBox.customer_lastname = dic.lastname
                ToolBox.customer_email = dic.email
                ToolBox.TB_MailToAddress.Text = dic.email

                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            ' MsgBox(ex.Message & ".")
        End Try


    End Function


    Public Sub InsertCustomerInfo(ID As String, email As String, firstName As String, lastname As String, password As String)

        Dim RegKeyLocation As String

        If ID = Module1.PCMaticID Then
            RegKeyLocation = "Software\PCMATIC\Account"
        Else
            RegKeyLocation = "Software\OptimumDesk\Account"
        End If

        Dim info As New StructuresModule.SignUpRegistrationData()
        Dim json As New JavaScriptSerializer
        json.MaxJsonLength = 2147483644

        info.companyId = ID
        info.email = email
        info.firstname = firstName
        info.lastname = lastname
        info.password = password

        Dim serializedInfo As String = Encrypt(json.Serialize(info))

        If ToolBox.frameWork = "EaseeControl" Then
            'Insert to EC agent 
            Dim key_OD As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(RegKeyLocation)
            key_OD.SetValue("NCne5NUp41ltZ+S8rPJxIg==", serializedInfo, Microsoft.Win32.RegistryValueKind.String)
            key_OD.Close()
        Else
            'Insert to OD agent
            Dim key_OD As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SOFTWARE\Class IT\OD")
            key_OD.SetValue("x8/nWldyac2PPD9xldpE2g==", ("8.9.50.1003"), Microsoft.Win32.RegistryValueKind.String)
            key_OD.SetValue("SR3KCHzp11pUpTrd88mOOA==", Encrypt(email), Microsoft.Win32.RegistryValueKind.String)
            key_OD.SetValue("9tetZAYnyZixCW721LyyoA==", Encrypt(firstName), Microsoft.Win32.RegistryValueKind.String)
            key_OD.SetValue("yi6tK32jAfVY4fcS9Nj5tw==", Encrypt(lastname), Microsoft.Win32.RegistryValueKind.String)
            key_OD.SetValue("cY2EzQTGMNMeV1d8kMkNNw==", Encrypt("3"), Microsoft.Win32.RegistryValueKind.String)
            key_OD.SetValue("PXAldl7TAlON3L/b1HKIXw==", (""), Microsoft.Win32.RegistryValueKind.String)
            key_OD.Close()
            Dim key_ODMem As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SOFTWARE\Class IT\ODMem")
            key_ODMem.SetValue("Qtp0EPqa09tocvBwRimd1g==", Encrypt(ID), Microsoft.Win32.RegistryValueKind.String)
            key_ODMem.Close()
        End If

        ToolBox.SaveRegData("4SmT/pypiUiAOJnVV3zvrw==", serializedInfo)
    End Sub


    Public Sub RoundedCorner(control As Control, radius As Integer)
        Dim path As New Drawing2D.GraphicsPath()
        Dim rect As Rectangle = control.ClientRectangle

        path.StartFigure()
        path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90)
        path.AddLine(rect.X + radius, rect.Y, rect.Right - radius, rect.Y)
        path.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90)
        path.AddLine(rect.Right, rect.Y + radius, rect.Right, rect.Bottom - radius)
        path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90)
        path.AddLine(rect.Right - radius, rect.Bottom, rect.X + radius, rect.Bottom)
        path.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90)
        path.CloseFigure()

        control.Region = New Region(path)
    End Sub



    Public Sub Uninstall()
        Try
            Dim foo As New System.Diagnostics.Process
            foo.StartInfo.FileName = "taskkill"
            foo.StartInfo.UseShellExecute = True
            foo.StartInfo.Arguments = " /IM odservice.exe /F"
            foo.StartInfo.CreateNoWindow = True
            foo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            foo.Start()
            foo.WaitForExit(1000 * 3)
            foo.Dispose()
        Catch
        End Try
        Try
            Dim foo As New System.Diagnostics.Process
            foo.StartInfo.FileName = "taskkill"
            foo.StartInfo.UseShellExecute = True
            foo.StartInfo.Arguments = " /IM updatermonitor.exe /F"
            foo.StartInfo.CreateNoWindow = True
            foo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            foo.Start()
            foo.WaitForExit(1000 * 3)
            foo.Dispose()
        Catch
        End Try
        Try
            Dim foo As New System.Diagnostics.Process
            foo.StartInfo.FileName = "taskkill"
            foo.StartInfo.UseShellExecute = True
            foo.StartInfo.Arguments = " /IM optimumdesk.exe /F"
            foo.StartInfo.CreateNoWindow = True
            foo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            foo.Start()
            foo.WaitForExit(1000 * 3)
            foo.Dispose()
        Catch
        End Try
        Try
            Dim ODinstallPath = If(Environment.GetEnvironmentVariable("PROGRAMFILES(X86)"), Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)) & "\Common Files\Updater\"
            Dim foo As New System.Diagnostics.Process
            foo.StartInfo.FileName = ODinstallPath & "updateservice.exe"
            foo.StartInfo.WorkingDirectory = ODinstallPath
            foo.StartInfo.UseShellExecute = True
            foo.StartInfo.Arguments = "-911"
            foo.StartInfo.CreateNoWindow = True
            foo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            foo.Start()
            foo.WaitForExit(1000 * 3)
            foo.Dispose()
        Catch
        End Try
        Try
            Dim ODinstallPath = If(Environment.GetEnvironmentVariable("PROGRAMFILES(X86)"), Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)) & "\OptimumDesk\"
            Dim foo As New System.Diagnostics.Process
            foo.StartInfo.FileName = ODinstallPath & "odservice.exe"
            foo.StartInfo.WorkingDirectory = ODinstallPath
            foo.StartInfo.UseShellExecute = True
            foo.StartInfo.Arguments = "-911"
            foo.StartInfo.CreateNoWindow = True
            foo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            foo.Start()
            foo.WaitForExit(1000 * 3)
            foo.Dispose()
        Catch
        End Try

        Try
            Dim foo As New System.Diagnostics.Process
            foo.StartInfo.FileName = "taskkill"
            foo.StartInfo.UseShellExecute = True
            foo.StartInfo.Arguments = " /IM odservice.exe /F"
            foo.StartInfo.CreateNoWindow = True
            foo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            foo.Start()
            foo.WaitForExit(1000 * 3)
            foo.Dispose()
        Catch
        End Try
        Try
            Dim foo As New System.Diagnostics.Process
            foo.StartInfo.FileName = "sc"
            foo.StartInfo.WorkingDirectory = "delete odservice"
            foo.StartInfo.UseShellExecute = True
            foo.StartInfo.Arguments = "-911"
            foo.StartInfo.CreateNoWindow = True
            foo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            foo.Start()
            foo.WaitForExit(1000 * 3)
            foo.Dispose()
        Catch
        End Try

        Try
            Dim foo As New System.Diagnostics.Process
            foo.StartInfo.FileName = "taskkill"
            foo.StartInfo.UseShellExecute = True
            foo.StartInfo.Arguments = " /IM ScreenConnect.ClientService.exe /F"
            foo.StartInfo.CreateNoWindow = True
            foo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            foo.Start()
            foo.WaitForExit(1000 * 3)
            foo.Dispose()
        Catch
        End Try
        Try
            Dim foo As New System.Diagnostics.Process
            foo.StartInfo.FileName = "taskkill"
            foo.StartInfo.UseShellExecute = True
            foo.StartInfo.Arguments = " /IM ScreenConnect.WindowsClient.exe /F"
            foo.StartInfo.CreateNoWindow = True
            foo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            foo.Start()
            foo.WaitForExit(1000 * 3)
            foo.Dispose()
        Catch
        End Try
        Try
            Dim foo As New System.Diagnostics.Process
            foo.StartInfo.FileName = "taskkill"
            foo.StartInfo.UseShellExecute = True
            foo.StartInfo.Arguments = " /IM updateservice.exe /F"
            foo.StartInfo.CreateNoWindow = True
            foo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            foo.Start()
            foo.WaitForExit(1000 * 3)
            foo.Dispose()
        Catch
        End Try
        Try
            Dim foo As New System.Diagnostics.Process
            foo.StartInfo.FileName = "sc"
            foo.StartInfo.WorkingDirectory = "delete updaterservice"
            foo.StartInfo.UseShellExecute = True
            foo.StartInfo.Arguments = "-911"
            foo.StartInfo.CreateNoWindow = True
            foo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            foo.Start()
            foo.WaitForExit(1000 * 3)
            foo.Dispose()
        Catch
        End Try

        Try
            Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree).DeleteValue("OptimumDesk", False)
        Catch
        End Try
        Try
            Registry.LocalMachine.OpenSubKey("SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Run", Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree).DeleteValue("OptimumDesk", False)
        Catch
        End Try
        Try
            Registry.LocalMachine.OpenSubKey("Software\Class IT")
        Catch
        End Try
        Try
            Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & " (x86)\OptimumDesk"
            System.IO.Directory.Delete(path, True)
        Catch
        End Try
        Try
            Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\OptimumDesk"
            System.IO.Directory.Delete(path, True)
        Catch
        End Try
        Try
            Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & " (x86)\Common Files\Updater"
            System.IO.Directory.Delete(path, True)
        Catch
        End Try
        Try
            Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\Common Files\Updater"
            System.IO.Directory.Delete(path, True)
        Catch
        End Try


        Try
            Dim EcInstallPath = If(Environment.GetEnvironmentVariable("PROGRAMFILES(X86)"), Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)) & "\EaseeControl\Uninstallers\"
            Dim foo As New System.Diagnostics.Process
            foo.StartInfo.FileName = EcInstallPath & "EaseeControl - uninstall.exe"
            foo.StartInfo.WorkingDirectory = EcInstallPath
            foo.StartInfo.UseShellExecute = True
            foo.StartInfo.Arguments = "/S /silent /verysilent /suppressmsgboxes"
            foo.StartInfo.CreateNoWindow = True
            foo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            foo.Start()
            foo.WaitForExit(1000 * 3)
            foo.Dispose()
        Catch
        End Try

        Try
            Dim TechServicesPath = If(Environment.GetEnvironmentVariable("PROGRAMFILES(X86)"), Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)) & "\TechServices\Uninstallers\"
            Dim foo As New System.Diagnostics.Process
            foo.StartInfo.FileName = TechServicesPath & "TechServices - uninstall.exe"
            foo.StartInfo.WorkingDirectory = TechServicesPath
            foo.StartInfo.UseShellExecute = True
            foo.StartInfo.Arguments = "/S /silent /verysilent /suppressmsgboxes"
            foo.StartInfo.CreateNoWindow = True
            foo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            foo.Start()
            foo.WaitForExit(1000 * 3)
            foo.Dispose()
        Catch
        End Try


        Try
            Dim TrueInstallPath = If(Environment.GetEnvironmentVariable("PROGRAMFILES(X86)"), Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)) & "\True Solutions\Uninstallers\"
            Dim foo As New System.Diagnostics.Process
            foo.StartInfo.FileName = TrueInstallPath & "True Solutions - uninstall.exe"
            foo.StartInfo.WorkingDirectory = TrueInstallPath
            foo.StartInfo.UseShellExecute = True
            foo.StartInfo.Arguments = "/S /silent /verysilent /suppressmsgboxes"
            foo.StartInfo.CreateNoWindow = True
            foo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            foo.Start()
            foo.WaitForExit(1000 * 3)
            foo.Dispose()
        Catch
        End Try

        Try
            Dim YourHelpDeskHQ = If(Environment.GetEnvironmentVariable("PROGRAMFILES(X86)"), Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)) & "\YourHelpDeskHQ\Uninstallers\"
            Dim foo As New System.Diagnostics.Process
            foo.StartInfo.FileName = YourHelpDeskHQ & "YourHelpDeskHQ - uninstall.exe"
            foo.StartInfo.WorkingDirectory = YourHelpDeskHQ
            foo.StartInfo.UseShellExecute = True
            foo.StartInfo.Arguments = "/S /silent /verysilent /suppressmsgboxes"
            foo.StartInfo.CreateNoWindow = True
            foo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            foo.Start()
            foo.WaitForExit(1000 * 3)
            foo.Dispose()
        Catch
        End Try

        'PcMatic Uninstall
        Try
            Dim PcMatic = If(Environment.GetEnvironmentVariable("PROGRAMFILES(X86)"), Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)) & "\PCMATIC\Uninstallers\"
            Dim foo As New System.Diagnostics.Process
            foo.StartInfo.FileName = PcMatic & "PCMATIC - uninstall.exe"
            foo.StartInfo.WorkingDirectory = PcMatic
            foo.StartInfo.UseShellExecute = True
            foo.StartInfo.Arguments = "/S /silent /verysilent /suppressmsgboxes"
            foo.StartInfo.CreateNoWindow = True
            foo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            foo.Start()
            foo.WaitForExit(1000 * 3)
            foo.Dispose()
        Catch
        End Try

        'EaseeAccess Uninstall
        Try
            Dim EaseeAccess = If(Environment.GetEnvironmentVariable("PROGRAMFILES(X86)"), Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)) & "\EaseeAccess\Uninstall\"
            Dim foo As New System.Diagnostics.Process
            foo.StartInfo.FileName = EaseeAccess & "unins000.exe"
            foo.StartInfo.WorkingDirectory = EaseeAccess
            foo.StartInfo.UseShellExecute = True
            foo.StartInfo.Arguments = "/verysilent /suppressmsgboxes"
            foo.StartInfo.CreateNoWindow = True
            foo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            foo.Start()
            foo.WaitForExit(1000 * 3)
            foo.Dispose()
        Catch
        End Try


        'remove Registry
        If ToolBox.CheckBox4.Checked = True Then
            Try
                PowerShellCmd("reg delete 'HKLM\SOFTWARE\Class IT' /f")
                PowerShellCmd("reg delete 'HKLM\SOFTWARE\Easee Control' /f")
                PowerShellCmd("reg delete 'HKLM\SOFTWARE\PCMATIC' /f")
                PowerShellCmd("reg delete 'HKLM\SOFTWARE\TechServices' /f")
                PowerShellCmd("reg delete 'HKLM\SOFTWARE\OptimumDesk' /f")

                PowerShellCmd("schtasks /delete /tn 'EASetup' /f")
                PowerShellCmd("schtasks /delete /tn 'ECUnis' /f")
                PowerShellCmd("schtasks /delete /tn 'PC Matic' /f")
                PowerShellCmd("schtasks /delete /tn 'True Solutions' /f")
            Catch ex As Exception

            End Try
        End If


    End Sub




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
