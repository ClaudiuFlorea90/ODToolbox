Imports System.Management
Imports System.Text
Imports System
Imports System.IO
Imports Newtonsoft.Json
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.Win32
Imports System.Diagnostics.Eventing.Reader
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ListView
Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Net.Sockets
'Imports System.Net.Mime.MediaTypeNames
Imports OpenHardwareMonitor
Imports OpenHardwareMonitor.Hardware
Imports Computer = OpenHardwareMonitor.Hardware.Computer
Imports System.Security.Cryptography
Imports Xamarin.Essentials
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Diagnostics
Imports System.Windows.Forms.HtmlElement
Imports CefSharp.WinForms
Imports CefSharp
Imports System.Security.Policy
Imports System.Runtime.InteropServices
Imports System.Drawing







Public Class Home



    Dim T1, T2, T3, T4, T5, T6, T7, T8, T9, tw As System.Threading.Thread






    Dim isCollapsed1 As Boolean = True
    Dim isCollapsed2 As Boolean = True
    Dim isCollapsed3 As Boolean = True
    Dim isCollapsed4 As Boolean = True
    Dim isCollapsed5 As Boolean = True
    Dim isCollapsed6 As Boolean = True

    Public PnlExp As Boolean
    Public LastExpPnl As Panel



    Dim CpuUsage As Integer
    Dim RamUsage As Integer
    Dim DiskUsage As Integer



    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.Size = Frame.PnlMain.MaximumSize



        Pnl_Windows.Size = Pnl_Windows.MinimumSize
        Pnl_Computer.Size = Pnl_Computer.MinimumSize
        Pnl_Network.Size = Pnl_Network.MinimumSize
        Pnl_Processes.Size = Pnl_Processes.MinimumSize
        Pnl_User.Size = Pnl_User.MinimumSize



        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False

        '  T1 = New System.Threading.Thread(AddressOf LiveUsage)
        'prea mult cpu usage



        T2 = New System.Threading.Thread(AddressOf DeviceInfo)
        'T3 = New System.Threading.Thread(AddressOf GPUInfo)
        'T4 = New System.Threading.Thread(AddressOf OsInfo)
        T5 = New System.Threading.Thread(AddressOf TermalSensor)
        T6 = New System.Threading.Thread(AddressOf Fake)
        T7 = New System.Threading.Thread(AddressOf RamLoad)
        T8 = New System.Threading.Thread(AddressOf DiskLoad)
        T9 = New System.Threading.Thread(AddressOf test2)




        ' T1.Start()
        T2.Start()
        'T3.Start()
        'T4.Start()
        T5.Start()
        T6.Start()
        T7.Start()
        T8.Start()
        T9.Start()


        PictureBox6.Image = GetUserTile(System.Security.Principal.WindowsIdentity.GetCurrent().Name)
        Label5.Text = "Live stats"


        Pnl_Windows.Location = New Point(3, 266)
        Pnl_Network.Location = New Point(331, 266)
        Pnl_Processes.Location = New Point(517, 266)
        Pnl_Computer.Location = New Point(3, 309)
        Pnl_User.Location = New Point(242, 309)

        Pnl_Windows.Size = Pnl_Windows.MinimumSize
        Pnl_Network.Size = Pnl_Network.MinimumSize
        Pnl_Processes.Size = Pnl_Processes.MinimumSize
        Pnl_Computer.Size = Pnl_Computer.MinimumSize
        Pnl_User.Size = Pnl_User.MinimumSize



    End Sub




    <DllImport("shell32", EntryPoint:="#261", CharSet:=CharSet.Unicode, PreserveSig:=False)>
    Public Shared Sub GetUserTilePath(username As String, whatever As UInt32, picpath As StringBuilder, maxLength As Integer)
    End Sub

    Public Function GetUserTilePath(username As String) As String
        Dim sb As StringBuilder
        sb = New StringBuilder(1000)
        GetUserTilePath(username, 2147483648, sb, sb.Capacity)
        Return sb.ToString()
    End Function

    Public Function GetUserTile(username As String) As Image




        Return Image.FromFile(GetUserTilePath(username))


    End Function






    Sub test2()


        Dim CpuLoad As Double


        ' ...
        Dim cpu As New PerformanceCounter()
        With cpu
            .CategoryName = "Processor"
            .CounterName = "% Processor Time"
            .InstanceName = "_Total"
        End With

        ' ...
        Do
            System.Threading.Thread.Sleep(1000)
            CpuLoad = Math.Round(cpu.NextValue())

            Label25.Text = CpuLoad

        Loop
    End Sub



    Private Sub LiveUsage()

        Do
            Dim _nameSpace$ = "root\CIMV2"
            Dim wql = "SELECT * FROM WIN32_Processor"
            Dim _strBuilder As New StringBuilder
            Using _moSearcher As New ManagementObjectSearcher(_nameSpace, wql)

                For Each _mobject As ManagementObject In _moSearcher.Get

                    LabelCpuClockSpeed.Text = Convert.ToDouble($"{_mobject("CurrentClockSpeed")}") / 1000.0 & " GHz"
                    Label71.Text = Convert.ToDouble($"{_mobject("MaxClockSpeed")}") / 1000.0 & " GHz"


                    Try

                        Dim UsageValue As Integer = $"{_mobject("LoadPercentage")}"
                        CircularProgressBar1.Value = UsageValue
                        CircularProgressBar1.Text = UsageValue & "%"
                        'Label24234324293534.Text = UsageValue & "%"

                        If UsageValue >= 0 Then
                            CircularProgressBar1.ProgressColor = Color.Green
                        End If
                        If UsageValue > 10 Then
                            CircularProgressBar1.ProgressColor = Color.Yellow
                        End If
                        If UsageValue > 25 Then
                            CircularProgressBar1.ProgressColor = Color.Orange
                        End If

                        If UsageValue > 40 Then
                            CircularProgressBar1.ProgressColor = Color.OrangeRed
                        End If

                        If UsageValue > 60 Then
                            CircularProgressBar1.ProgressColor = Color.Red
                        End If

                    Catch ex As Exception

                        Frame.logger(ex.Message, "Error")
                    End Try


                Next

            End Using

            ''CPU USAGE


            Dim query As New System.Management.SelectQuery("Win32_VideoController")
            Dim search As New System.Management.ManagementObjectSearcher(query)
            Dim info As System.Management.ManagementObject
            For Each info In search.Get()
                Lbl_GPU_WTF.Text = info("Caption").ToString
                'Lbl_GPU2.Text = info("VideoProcessor").ToString

            Next




            Dim GpuTotalMemory As Double = Command.PowerShell("(Get-WmiObject Win32_VideoController | select @{Expression={$_.adapterram/1GB};label='GB'}).GB")
            Dim GpuMemoryUsed As Double = Command.PowerShell("$GpuMemTotal = (((Get-Counter '\GPU Process Memory(*)\Local Usage').CounterSamples | where CookedValue).CookedValue | measure -sum).sum; Write-Output ($GpuMemTotal/1GB)")
            Dim GpuUsage As Double = Command.PowerShell("$GpuUseTotal = (((Get-Counter '\GPU Engine(*engtype_3D)\Utilization Percentage').CounterSamples | where CookedValue).CookedValue | measure -sum).sum; Write-Output $GpuUseTotal")




            Lbl_GpuTotalMemory.Text = Math.Round(GpuTotalMemory) & " Gb"
            LabelGpuMemoryUsed.Text = Format(GpuMemoryUsed, "##.##") & " GB"
            LblGpuUsage.Text = Math.Round(GpuUsage) & " %"




            CircularProgressBar7.Maximum = 100
            CircularProgressBar7.Value = Math.Round(GpuUsage)
            CircularProgressBar7.Text = Math.Round(GpuUsage) & "%"


            If GpuUsage >= 0 Then
                CircularProgressBar7.ProgressColor = Color.Green
            End If
            If GpuUsage > 30 Then
                CircularProgressBar7.ProgressColor = Color.Orange
            End If
            If GpuUsage > 60 Then
                CircularProgressBar7.ProgressColor = Color.Red
            End If
            If GpuUsage > 90 Then
                CircularProgressBar7.ProgressColor = Color.DarkRed
            End If



            'System Up-Time
            Dim strResult As String = String.Empty
            strResult &= (Environment.TickCount \ 86400000).ToString + " days, "
            strResult &= (Environment.TickCount / 3600000 Mod 24).ToString("n0") + " hours, "
            strResult &= (Environment.TickCount / 120000 Mod 60).ToString("n0") + " minutes, "

            Lbl_UpTime.Text = strResult


            Thread.Sleep(1000)
        Loop


    End Sub


    Private Sub TermalSensor()
        Do

            'CPU amd GPU TEMP

            Dim CpuTemp As Integer
            Dim GpuTemp As Integer

            Dim computer As New Computer()
            computer.Open()
            computer.CPUEnabled = True
            computer.GPUEnabled = True
            Dim cpu = computer.Hardware.Where(Function(h) h.HardwareType = HardwareType.CPU).FirstOrDefault()
            Dim gpu = computer.Hardware.Where(Function(h) h.HardwareType = HardwareType.GpuAti).FirstOrDefault()


            If cpu IsNot Nothing Then
                cpu.Update()

                Dim tempSensors = cpu.Sensors.Where(Function(s) s.SensorType = SensorType.Temperature)
                'tempSensors.ToList.ForEach(Sub(s) Console.WriteLine(s.Value))
                tempSensors.ToList.ForEach(Sub(s) CpuTemp = (s.Value))

                CircularProgressBar4.Maximum = 100
                CircularProgressBar4.Value = CpuTemp
                CircularProgressBar4.Text = CpuTemp & "c'"
                Label80.Text = GpuTemp


                If CpuTemp >= 0 Then
                    CircularProgressBar4.ProgressColor = Color.Blue
                End If
                If CpuTemp > 40 Then
                    CircularProgressBar4.ProgressColor = Color.Green
                End If
                If CpuTemp > 55 Then
                    CircularProgressBar4.ProgressColor = Color.Orange
                End If
                If CpuTemp > 65 Then
                    CircularProgressBar4.ProgressColor = Color.Red
                End If

            End If



            'NU MERGE INCA!


            'If gpu IsNot Nothing Then

            '    gpu.Update()
            '    Dim GpuTempSensors = gpu.Sensors.Where(Function(s) s.SensorType = SensorType.Temperature)
            '    'Dim GpuTempSensors = gpu.Sensors.Where(Function(s) s.SensorType = SensorType.Temperature)
            '    GpuTempSensors.ToList.ForEach(Sub(s) GpuTemp = (s.SensorType))

            '    'Label80.Text = GpuTemp & "c'"
            '    'CircularProgressBar4.Maximum = 100
            '    'CircularProgressBar4.Value = GpuTemp
            '    'CircularProgressBar4.Text = GpuTemp & "c'"



            '    '    If CpuTemp >= 0 Then
            '    '        CircularProgressBar4.ProgressColor = Color.Blue
            '    '    End If
            '    '    If CpuTemp > 40 Then
            '    '        CircularProgressBar4.ProgressColor = Color.Green
            '    '    End If
            '    '    If CpuTemp > 55 Then
            '    '        CircularProgressBar4.ProgressColor = Color.Orange
            '    '    End If
            '    '    If CpuTemp > 65 Then
            '    '        CircularProgressBar4.ProgressColor = Color.Red
            '    '    End If
            'End If


            Thread.Sleep(1000)
        Loop

    End Sub


    Private Sub RamLoad()

        Do
            Dim sanalyer As Double
            Dim Total_Ram As String = (CDbl(My.Computer.Info.TotalPhysicalMemory) / 1024 / 1024 / 1024).ToString("##.#GB")
            Dim Total_Ram2 As String = (CDbl(My.Computer.Info.TotalPhysicalMemory) / 1024 / 1024 / 1024).ToString
            Dim Ram_Available As String = (CDbl(My.Computer.Info.AvailablePhysicalMemory) / 1024 / 1024 / 1024).ToString("##.#GB")

            sanalyer = (My.Computer.Info.TotalPhysicalMemory - My.Computer.Info.AvailablePhysicalMemory) / 1048576 / 1024

            Dim sanalyzer1 As Long
            sanalyzer1 = My.Computer.Info.AvailablePhysicalMemory * 100
            Dim mrt As Long

            Dim total As Double = Val(sanalyer) / (Total_Ram2) * 100


            mrt = Val(sanalyzer1 / My.Computer.Info.TotalPhysicalMemory)



            Dim Pb_Ram_Max As Long = (CDbl(My.Computer.Info.TotalPhysicalMemory) / 1024 / 1024 / 1024).ToString("##.#")



            Dim test As Integer = FormatNumber(total, 2)


            Lbl_RamInUse.Text = sanalyer.ToString("##.# GB")
            Lbl_Available.Text = Ram_Available
            Lbl_TotalRam.Text = Total_Ram

            CircularProgressBar2.Maximum = total
            CircularProgressBar2.Value = sanalyer
            CircularProgressBar2.Text = test & "%"
            Label2.Text = "Ram: " & sanalyer.ToString("N") & "/" & Total_Ram


            If test >= 0 Then
                CircularProgressBar2.ProgressColor = Color.Green
            End If
            If test > 30 Then
                CircularProgressBar2.ProgressColor = Color.Orange
            End If
            If test > 60 Then
                CircularProgressBar2.ProgressColor = Color.Red
            End If
            If test > 90 Then
                CircularProgressBar2.ProgressColor = Color.DarkRed
            End If



            Dim _nameSpace$ = "root\CIMV2"

            Dim wql = "SELECT * FROM Win32_PhysicalMemory"
            Dim _strBuilder As New StringBuilder
            Using _moSearcher As New ManagementObjectSearcher(_nameSpace, wql)

                For Each _mobject As ManagementObject In _moSearcher.Get
                    Label19.Text = Convert.ToDouble($"{_mobject("ConfiguredClockSpeed")}") & "MHz"
                    ' Lbl_SlotsUsed.Text = $"{_mobject("DeviceLocator")}"
                    'Lbl_FormFactor.Text = $"{_mobject("FormFactor")}"
                Next

            End Using


            Dim RamForUse As Integer = Total_Ram2 - sanalyer
            Dim TotalRamWTF As Integer = Total_Ram2


            CircularProgressBarRam2.Maximum = TotalRamWTF
            CircularProgressBarRam2.Value = RamForUse





            Dim FreeMemProcent As Integer



            FreeMemProcent = RamForUse / TotalRamWTF * 100



            'Ia vezi aici mai jos!!


            'Label2555.Text = FreeMemProcent
            CircularProgressBarRam2.Text = FreeMemProcent & "%"



            If test >= 0 Then
                CircularProgressBarRam2.ProgressColor = Color.Green
            End If
            If test > 30 Then
                CircularProgressBarRam2.ProgressColor = Color.Orange
            End If
            If test > 60 Then
                CircularProgressBarRam2.ProgressColor = Color.Red
            End If
            If test > 90 Then
                CircularProgressBarRam2.ProgressColor = Color.DarkRed
            End If


            Thread.Sleep(1000)
        Loop
    End Sub

    Private Sub DiskLoad()

        'Fake
        Do
            Dim rm As New Random
            Dim num As Double = (rm.Next(0, 39))


            CircularProgressBar5.Maximum = 100
            CircularProgressBar5.Text = num & "%"
            'CircularProgressBar3.Value = num
            CircularProgressBar5.Value = 24


            If num >= 0 Then
                CircularProgressBar5.ProgressColor = Color.Green
            End If
            If num > 30 Then
                CircularProgressBar5.ProgressColor = Color.Orange
            End If
            If num > 60 Then
                CircularProgressBar5.ProgressColor = Color.Red
            End If
            If num > 90 Then
                CircularProgressBar5.ProgressColor = Color.DarkRed
            End If




            Thread.Sleep(1000)

        Loop


    End Sub





    Sub Fake()


        ' Fake
        Do
            Dim rm As New Random
            Dim num As Double = (rm.Next(0, 39))



            CircularProgressBar3.Maximum = 100
            CircularProgressBar3.Value = num
            CircularProgressBar3.Text = num & "%"


            If num >= 0 Then
                CircularProgressBar3.ProgressColor = Color.Green
            End If
            If num > 30 Then
                CircularProgressBar3.ProgressColor = Color.Orange
            End If
            If num > 60 Then
                CircularProgressBar3.ProgressColor = Color.Red
            End If
            If num > 90 Then
                CircularProgressBar3.ProgressColor = Color.DarkRed
            End If




            Thread.Sleep(1000)

        Loop




    End Sub


    Private Sub DeviceInfo()


        'CPU INFO 

        Dim _nameSpace$ = "root\CIMV2"

        Dim wql = "SELECT * FROM WIN32_Processor"
        Dim _strBuilder As New StringBuilder
        Using _moSearcher As New ManagementObjectSearcher(_nameSpace, wql)

            For Each _mobject As ManagementObject In _moSearcher.Get
                Lbl_CPU.Text = $"{_mobject("Name")}"
                'Lbl_BaseSpeed.Text = $"{_mobject("MaxClockSpeed")}"
                'Lbl_Socket.Text = $"{_mobject("SocketDesignation")}"
                Label3.Text = $"{_mobject("NumberOfCores")}"
                'Lbl_EnabledCores.Text = $"{_mobject("NumberOfEnabledCore")}"
                Label7.Text = $"{_mobject("NumberOfLogicalProcessors")}"
                'Lbl_Threads.Text = $"{_mobject("ThreadCount")}"
                'Lbl_Virtualization.Text = $"{_mobject("VirtualizationFirmwareEnabled")}"
                'Lbl_L1Cache.Text = "383 Kb"
                'Lbl_L2Cache.Text = $"{_mobject("L2CacheSize")}" / 1024 & " MB"
                ' Lbl_L3Cache.Text = $"{_mobject("L3CacheSize")}" / 1024 & " MB"
                'Lbl_Arhitecture.Text = $"{_mobject("Architecture")}"
                'Lbl_Manufacturer.Text = $"{_mobject("Manufacturer")}"

            Next

        End Using





        Lbl_RAM.Text = (CDbl(My.Computer.Info.TotalPhysicalMemory) / 1024 / 1024 / 1024).ToString("##.# GB")


        For Each curDrive As DriveInfo In My.Computer.FileSystem.Drives
            If curDrive.DriveType = DriveType.Fixed Then
                ' Dim diskName As String = curDrive.Name
                ' Dim theFreeSpace As Long = curDrive.AvailableFreeSpace
                ' Lbl_Disk.Text = diskName
                Lbl_Disk.Text = IO.Path.GetPathRoot(Environment.SystemDirectory)


            End If
        Next




        'USER INFO

        Lbl_User.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "RegisteredOwner", Nothing)






        'OS Info


        Lbl_OS.Text = "        " & My.Computer.Info.OSFullName
        lbl_os_build.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "CurrentBuild", Nothing)
        Label9.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "DisplayVersion", Nothing)

        Dim dtmInstallDate As DateTime
        Dim oSearcher As New ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem")
        For Each oMgmtObj As ManagementObject In oSearcher.Get
            dtmInstallDate = ManagementDateTimeConverter.ToDateTime(CStr(oMgmtObj("InstallDate")))


        Next
        Label13.Text = dtmInstallDate

        'IS WINDOWS ACTIVATED?
        Dim searcher As New ManagementObjectSearcher(
          "root\CIMV2",
             "SELECT * FROM SoftwareLicensingProduct WHERE LicenseStatus = 1")
        Dim myCollection As ManagementObjectCollection
        Dim myObject As ManagementObject
        myCollection = searcher.Get()
        If myCollection.Count = 0 Then

            Label4.Text = "Yes"

        Else
            Label4.Text = "No"

        End If




        '    Lbl_OS.Text = "        " & My.Computer.Info.OSFullName
        '    lbl_os_build.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "CurrentBuild", Nothing)
        '    Label9.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "DisplayVersion", Nothing)

        '    Dim dtmInstallDate As DateTime
        '    Dim oSearcher As New ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem")
        '    For Each oMgmtObj As ManagementObject In oSearcher.Get
        '        dtmInstallDate = ManagementDateTimeConverter.ToDateTime(CStr(oMgmtObj("InstallDate")))


        '    Next
        '    Label13.Text = dtmInstallDate

        '    'IS WINDOWS ACTIVATED?
        '    Dim searcher As New ManagementObjectSearcher(
        '      "root\CIMV2",
        '         "SELECT * FROM SoftwareLicensingProduct WHERE LicenseStatus = 1")
        '    Dim myCollection As ManagementObjectCollection
        '    Dim myObject As ManagementObject
        '    myCollection = searcher.Get()
        '    If myCollection.Count = 0 Then

        '        Label4.Text = "Yes"

        '    Else
        '        Label4.Text = "No"

        '    End If






    End Sub





    'Private Sub GPUInfo()





    '    Dim query As New System.Management.SelectQuery("Win32_VideoController")
    '    Dim search As New System.Management.ManagementObjectSearcher(query)
    '    Dim info As System.Management.ManagementObject
    '    For Each info In search.Get()
    '        Lbl_GPU_WTF.Text = info("Caption").ToString
    '        'Lbl_GPU2.Text = info("VideoProcessor").ToString

    '    Next


    '    Do

    '        Dim GpuTotalMemory As Double = Command.PowerShell("(Get-WmiObject Win32_VideoController | select @{Expression={$_.adapterram/1GB};label='GB'}).GB")
    '        Dim GpuMemoryUsed As Double = Command.PowerShell("$GpuMemTotal = (((Get-Counter '\GPU Process Memory(*)\Local Usage').CounterSamples | where CookedValue).CookedValue | measure -sum).sum; Write-Output ($GpuMemTotal/1GB)")
    '        Dim GpuUsage As Double = Command.PowerShell("$GpuUseTotal = (((Get-Counter '\GPU Engine(*engtype_3D)\Utilization Percentage').CounterSamples | where CookedValue).CookedValue | measure -sum).sum; Write-Output $GpuUseTotal")




    '        Lbl_GpuTotalMemory.Text = Math.Round(GpuTotalMemory) & " Gb"
    '        LabelGpuMemoryUsed.Text = Format(GpuMemoryUsed, "##.##") & " GB"
    '        LblGpuUsage.Text = Math.Round(GpuUsage) & " %"




    '        CircularProgressBar7.Maximum = 100
    '        CircularProgressBar7.Value = Math.Round(GpuUsage)
    '        CircularProgressBar7.Text = Math.Round(GpuUsage) & "%"


    '        If GpuUsage >= 0 Then
    '            CircularProgressBar7.ProgressColor = Color.Green
    '        End If
    '        If GpuUsage > 30 Then
    '            CircularProgressBar7.ProgressColor = Color.Orange
    '        End If
    '        If GpuUsage > 60 Then
    '            CircularProgressBar7.ProgressColor = Color.Red
    '        End If
    '        If GpuUsage > 90 Then
    '            CircularProgressBar7.ProgressColor = Color.DarkRed
    '        End If









    '        Thread.Sleep(1000)
    '    Loop



    'End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Windows.Click, Pnl_Windows.Click, Lbl_OS.Click


        Timer_Windows.Start()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_Computer.Click, Pnl_Computer.Click, Lbl_PC.Click
        Timer_Computer.Start()


    End Sub

    Private Sub Panel13_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Timer_ExpandLiveStatus_Tick(sender As Object, e As EventArgs) Handles Timer_ExpandLiveStatus.Tick

        Pnl_Windows.SendToBack()
        Pnl_Computer.SendToBack()
        Pnl_Network.SendToBack()
        Pnl_Processes.SendToBack()
        Pnl_User.SendToBack()



        If isCollapsed6 Then

            Label5.Text = "Cpu"



            PanelLiveStats.Width += 150
            PanelLiveStats.Height += 150
            PanelLiveStats.BringToFront()

            If PanelLiveStats.Size = PanelLiveStats.MaximumSize Then

                isCollapsed6 = False
                Timer_ExpandLiveStatus.Stop()
            End If


        Else

            Label5.Text = "Live stats"



            PanelLiveStats.Width -= 150
            PanelLiveStats.Height -= 150

            If PanelLiveStats.Size = PanelLiveStats.MinimumSize Then

                isCollapsed6 = True
                Timer_ExpandLiveStatus.Stop()
            End If

        End If




    End Sub

    Private Sub CircularProgressBar1_Click(sender As Object, e As EventArgs) Handles CircularProgressBar1.Click

    End Sub

    Private Sub Panel7_Click(sender As Object, e As EventArgs) Handles Panel7.Click
        Timer_ExpandLiveStatus.Start()
    End Sub

    Private Sub PanelLiveStats_Click(sender As Object, e As EventArgs) Handles PanelLiveStats.Click


        Timer_ExpandLiveStatus.Start()


    End Sub

    Private Sub Timer_PnlShrink_Tick(sender As Object, e As EventArgs) Handles Timer_PnlShrink.Tick

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Btn_User.Click, Pnl_User.Click, Lbl_User.Click

        Timer_User.Start()



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Btn_Network.Click, Pnl_Network.Click, Lbl_Network.Click

        Timer_Network.Start()

    End Sub

    Private Sub Btn_Processes_Click(sender As Object, e As EventArgs) Handles Btn_Processes.Click, Pnl_Processes.Click, Lbl_Process.Click


        Timer_Processes.Start()


    End Sub

    Private Sub Timer_Windows_Tick(sender As Object, e As EventArgs) Handles Timer_Windows.Tick

        If isCollapsed2 = False Then
            isCollapsed2 = True
            Pnl_Computer.Size = Pnl_Computer.MinimumSize
            Btn_Computer.Image = ImageList_ExpandBtn.Images(1)
        End If


        If isCollapsed3 = False Then
            isCollapsed3 = True
            Pnl_Network.Size = Pnl_Network.MinimumSize
            Btn_Network.Image = ImageList_ExpandBtn.Images(1)
        End If

        If isCollapsed4 = False Then
            isCollapsed4 = True
            Pnl_Processes.Size = Pnl_Processes.MinimumSize
            Btn_Processes.Image = ImageList_ExpandBtn.Images(1)
        End If

        If isCollapsed5 = False Then
            isCollapsed5 = True
            Pnl_User.Size = Pnl_User.MinimumSize
            Btn_User.Image = ImageList_ExpandBtn.Images(1)
        End If

        ''''
        If isCollapsed1 Then

            Pnl_Windows.Height += 100
            Pnl_Windows.Width += 100



            Btn_Windows.Image = ImageList_ExpandBtn.Images(0)
            If Pnl_Windows.Size = Pnl_Windows.MaximumSize Then

                isCollapsed1 = False
                PnlExp = True
                Timer_Windows.Stop()

            End If
        Else

            Pnl_Windows.Height -= 100
            Pnl_Windows.Width -= 100
            Btn_Windows.Image = ImageList_ExpandBtn.Images(1)


            If Pnl_Windows.Size = Pnl_Windows.MinimumSize Then

                isCollapsed1 = True
                PnlExp = False
                Timer_Windows.Stop()


            End If

        End If
        LastExpPnl = Pnl_Windows
        Pnl_Windows.BringToFront()

    End Sub


    Private Sub Timer_Computer_Tick(sender As Object, e As EventArgs) Handles Timer_Computer.Tick

        If isCollapsed1 = False Then
            isCollapsed1 = True
            Pnl_Windows.Size = Pnl_Windows.MinimumSize
            Btn_Windows.Image = ImageList_ExpandBtn.Images(1)
        End If

        If isCollapsed3 = False Then
            isCollapsed3 = True
            Pnl_Network.Size = Pnl_Network.MinimumSize
            Btn_Network.Image = ImageList_ExpandBtn.Images(1)
        End If

        If isCollapsed4 = False Then
            isCollapsed4 = True
            Pnl_Processes.Size = Pnl_Processes.MinimumSize
            Btn_Processes.Image = ImageList_ExpandBtn.Images(1)
        End If

        If isCollapsed5 = False Then
            isCollapsed5 = True
            Pnl_User.Size = Pnl_User.MinimumSize
            Btn_User.Image = ImageList_ExpandBtn.Images(1)
        End If

        ''''

        If isCollapsed2 Then

            Pnl_Computer.Height += 100
            Pnl_Computer.Width += 100



            Btn_Computer.Image = ImageList_ExpandBtn.Images(0)


            If Pnl_Computer.Size = Pnl_Computer.MaximumSize Then


                isCollapsed2 = False
                PnlExp = True
                Timer_Computer.Stop()
            End If
        Else

            Pnl_Computer.Height -= 100
            Pnl_Computer.Width -= 100

            Btn_Computer.Image = ImageList_ExpandBtn.Images(1)

            If Pnl_Computer.Size = Pnl_Computer.MinimumSize Then



                isCollapsed2 = True
                PnlExp = False
                Timer_Computer.Stop()
            End If

        End If

        LastExpPnl = Pnl_Computer
        Pnl_Computer.BringToFront()

    End Sub

    Private Sub Timer_Network_Tick(sender As Object, e As EventArgs) Handles Timer_Network.Tick

        If isCollapsed1 = False Then
            isCollapsed1 = True
            Pnl_Windows.Size = Pnl_Windows.MinimumSize
            Btn_Windows.Image = ImageList_ExpandBtn.Images(1)
        End If

        If isCollapsed2 = False Then
            isCollapsed2 = True
            Pnl_Computer.Size = Pnl_Computer.MinimumSize
            Btn_Computer.Image = ImageList_ExpandBtn.Images(1)
        End If

        If isCollapsed4 = False Then
            isCollapsed4 = True
            Pnl_Processes.Size = Pnl_Processes.MinimumSize
            Btn_Processes.Image = ImageList_ExpandBtn.Images(1)
        End If

        If isCollapsed5 = False Then
            isCollapsed5 = True
            Pnl_User.Size = Pnl_User.MinimumSize
            Btn_User.Image = ImageList_ExpandBtn.Images(1)
        End If

        ''''

        If isCollapsed3 Then


            Pnl_Network.Height += 100
            Pnl_Network.Width += 100
            Pnl_Network.Location = Pnl_Windows.Location


            Btn_Network.Image = ImageList_ExpandBtn.Images(0)

            If Pnl_Network.Size = Pnl_Network.MaximumSize Then

                isCollapsed3 = False
                PnlExp = True
                Timer_Network.Stop()


            End If
        Else

            Pnl_Network.Height -= 100
            Pnl_Network.Width -= 100
            Btn_Network.Image = ImageList_ExpandBtn.Images(1)

            If Pnl_Network.Size = Pnl_Network.MinimumSize Then

                Pnl_Network.Location = New Point(331, 266)
                isCollapsed3 = True
                PnlExp = False
                Timer_Network.Stop()
            End If

        End If

        LastExpPnl = Pnl_Network
        Pnl_Network.BringToFront()

    End Sub

    Private Sub Timer_Processes_Tick(sender As Object, e As EventArgs) Handles Timer_Processes.Tick

        If isCollapsed1 = False Then
            isCollapsed1 = True
            Pnl_Windows.Size = Pnl_Windows.MinimumSize
            Btn_Windows.Image = ImageList_ExpandBtn.Images(1)
        End If

        If isCollapsed2 = False Then
            isCollapsed2 = True
            Pnl_Computer.Size = Pnl_Computer.MinimumSize
            Btn_Computer.Image = ImageList_ExpandBtn.Images(1)
        End If

        If isCollapsed3 = False Then
            isCollapsed3 = True
            Pnl_Network.Size = Pnl_Network.MinimumSize
            Btn_Network.Image = ImageList_ExpandBtn.Images(1)
        End If

        If isCollapsed5 = False Then
            isCollapsed5 = True
            Pnl_User.Size = Pnl_User.MinimumSize
            Btn_User.Image = ImageList_ExpandBtn.Images(1)
        End If

        ''''

        If isCollapsed4 Then

            Pnl_Processes.Height += 100
            Pnl_Processes.Width += 100
            Pnl_Processes.Location = Pnl_Windows.Location


            Btn_Processes.Image = ImageList_ExpandBtn.Images(0)

            If Pnl_Processes.Size = Pnl_Processes.MaximumSize Then

                isCollapsed4 = False
                PnlExp = True
                Timer_Processes.Stop()
            End If
        Else

            Pnl_Processes.Height -= 100
            Pnl_Processes.Width -= 100
            Pnl_Processes.Location = New Point(517, 266)

            Btn_Processes.Image = ImageList_ExpandBtn.Images(1)

            If Pnl_Processes.Size = Pnl_Processes.MinimumSize Then


                isCollapsed4 = True
                PnlExp = False
                Timer_Processes.Stop()
            End If

        End If


        LastExpPnl = Pnl_Processes
        Pnl_Processes.BringToFront()



    End Sub

    Private Sub Timer_User_Tick(sender As Object, e As EventArgs) Handles Timer_User.Tick


        If isCollapsed1 = False Then
            isCollapsed1 = True
            Pnl_Windows.Size = Pnl_Windows.MinimumSize
            Btn_Windows.Image = ImageList_ExpandBtn.Images(1)
        End If

        If isCollapsed2 = False Then
            isCollapsed2 = True
            Pnl_Computer.Size = Pnl_Computer.MinimumSize
            Btn_Computer.Image = ImageList_ExpandBtn.Images(1)
        End If


        If isCollapsed3 = False Then
            isCollapsed3 = True
            Pnl_Network.Size = Pnl_Network.MinimumSize
            Btn_Network.Image = ImageList_ExpandBtn.Images(1)
        End If

        If isCollapsed4 = False Then
            isCollapsed5 = True
            Pnl_Processes.Size = Pnl_Processes.MinimumSize
            Btn_Processes.Image = ImageList_ExpandBtn.Images(1)
        End If

        ''''


        If isCollapsed5 Then

            Btn_User.Image = ImageList_ExpandBtn.Images(0)
            Pnl_User.Height += 63
            Pnl_User.Width += 63
            Pnl_User.Location = Pnl_Computer.Location


            If Pnl_User.Size = Pnl_User.MaximumSize Then
                Timer_User.Stop()
                isCollapsed5 = False
                PnlExp = True
            End If
        Else

            Pnl_User.Height -= 63
            Pnl_User.Width -= 63
            Btn_User.Image = ImageList_ExpandBtn.Images(1)



            If Pnl_User.Size = Pnl_User.MinimumSize Then

                Pnl_User.Location = New Point(242, 309)
                Timer_User.Stop()
                isCollapsed5 = True
                PnlExp = False
            End If

        End If


        LastExpPnl = Pnl_User
        Pnl_User.BringToFront()


    End Sub




End Class