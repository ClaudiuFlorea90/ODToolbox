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
Imports System.Windows.Documents
Imports CefSharp.DevTools.CSS

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


    Sub JustCpuLoad()

        Do

            'CPU
            Dim CpuLoad As Integer
            Dim _nameSpace$ = "root\CIMV2"
            Dim wql = "SELECT * FROM WIN32_Processor"
            Dim _strBuilder As New StringBuilder
            Using _moSearcher As New ManagementObjectSearcher(_nameSpace, wql)

                For Each _mobject As ManagementObject In _moSearcher.Get

                    Try
                        CpuLoad = ($"{_mobject("LoadPercentage")}")


                        CircularProgressBar1.Maximum = 100
                        CircularProgressBar1.Value = CpuLoad
                        CircularProgressBar1.Text = CpuLoad & "%"

                        If CpuLoad >= 0 Then
                            CircularProgressBar1.ProgressColor = Color.Green
                        End If
                        If CpuLoad > 10 Then
                            CircularProgressBar1.ProgressColor = Color.Yellow
                        End If
                        If CpuLoad > 25 Then
                            CircularProgressBar1.ProgressColor = Color.Orange
                        End If

                        If CpuLoad > 40 Then
                            CircularProgressBar1.ProgressColor = Color.OrangeRed
                        End If

                        If CpuLoad > 60 Then
                            CircularProgressBar1.ProgressColor = Color.Red
                        End If

                    Catch ex As Exception
                        Frame.logger(ex.Message, "Error. Cpu Load")
                    End Try

                    Thread.Sleep(1000)
                Next
            End Using
        Loop

    End Sub


    Sub Thermal()

        Do
            'CPU amd GPU TEMP

            Dim CpuTemp As Integer
            Dim GpuTemp As Integer

            Dim computer As New Computer()
            computer.Open()
            computer.CPUEnabled = True
            computer.GPUEnabled = True
            Dim cpuT = computer.Hardware.Where(Function(h) h.HardwareType = HardwareType.CPU).FirstOrDefault()
            Dim gpuT = computer.Hardware.Where(Function(h) h.HardwareType = HardwareType.GpuAti).FirstOrDefault()


            If cpuT IsNot Nothing Then
                cpuT.Update()

                Dim tempSensors = cpuT.Sensors.Where(Function(s) s.SensorType = SensorType.Temperature)
                'tempSensors.ToList.ForEach(Sub(s) Console.WriteLine(s.Value))
                tempSensors.ToList.ForEach(Sub(s) CpuTemp = (s.Value))

                CircularProgressBar4.Maximum = 100
                CircularProgressBar4.Value = CpuTemp
                CircularProgressBar4.Text = CpuTemp & "c'"



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


            Thread.Sleep(1000)
        Loop

    End Sub




    Sub CpuData()


        Dim mSearcher As New ManagementObjectSearcher("SELECT * FROM Win32_Processor")

        For Each item In mSearcher.Get
            Lbl_CPU.Text = item.Properties("Name").Value
            Label31.Text = item.Properties("SocketDesignation").Value
            Label71.Text = item.Properties("MaxClockSpeed").Value & " GHz"
            Label3.Text = item.Properties("NumberOfCores").Value
            Label7.Text = item.Properties("NumberOfLogicalProcessors").Value
            Label90.Text = item.Properties("Manufacturer").Value
            Try
                Label91.Text = item.Properties("Virtualization").Value
            Catch ex As Exception
            End Try

            Label94.Text = item.Properties("L2CacheSize").Value
            Label97.Text = item.Properties("L3CacheSize").Value
            Label93.Text = item.Properties("Status").Value
            Label96.Text = item.Properties("CurrentVoltage").Value
            Label98.Text = item.Properties("ProcessorId").Value
            Label99.Text = item.Properties("LastErrorCode").Value
            Label102.Text = item.Properties("DeviceID").Value
            Label104.Text = item.Properties("AddressWidth").Value
            Label108.Text = item.Properties("DataWidth").Value
            Label112.Text = item.Properties("ExtClock").Value
            Label106.Text = item.Properties("PowerManagementSupported").Value
            Label110.Text = item.Properties("Version").Value
        Next

    End Sub


    Sub DiskData()


        Dim mSearcher As New ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive")

        For Each item In mSearcher.Get



            If item.Properties("Index").Value = 0 Then
                Panel1.Hide()

                Label169.Text = item.Properties("Caption").Value
                Label114.Text = item.Properties("Status").Value
                Label138.Text = item.Properties("DeviceID").Value
                Label142.Text = item.Properties("Partitions").Value
                Label144.Text = item.Properties("BytesPerSector").Value
                Label146.Text = item.Properties("InterfaceType").Value
                Dim Size As Long = (item.Properties("Size").Value / 1000000000)
                Label150.Text = Size & " GB"
                Label149.Text = item.Properties("FirmwareRevision").Value
                Label152.Text = item.Properties("MediaType").Value



                Lbl_Disk.Text = Label169.Text
                Label48.Text = Label150.Text



            ElseIf item.Properties("Index").Value = 1 Then
                Panel1.Show()

                Label170.Text = item.Properties("Caption").Value
                Label154.Text = item.Properties("Status").Value
                Label162.Text = item.Properties("DeviceID").Value
                Label160.Text = item.Properties("Partitions").Value
                Label166.Text = item.Properties("BytesPerSector").Value
                Label157.Text = item.Properties("InterfaceType").Value
                Dim Size1 As Long = item.Properties("Size").Value / 1000000000
                Label165.Text = Size1 & " GB"
                Label163.Text = item.Properties("FirmwareRevision").Value
                Label168.Text = item.Properties("MediaType").Value

            End If
        Next

        Dim UsedSpace As Long
        Dim UsedSpace2 As Long


        For Each curDrive As DriveInfo In My.Computer.FileSystem.Drives

            If curDrive.Name = "C:\" Then

                Dim FreeSpace As Long = curDrive.TotalFreeSpace / 1000000000
                Dim TotalSize As Long = curDrive.TotalSize / 1000000000

                UsedSpace = TotalSize - FreeSpace

                Dim Procent As Integer = UsedSpace / TotalSize * 100

                Label55.Text = FreeSpace & " GB"
                Label48.Text = TotalSize & " GB"
                Label57.Text = UsedSpace & " GB"

                Try
                    Label51.Text = curDrive.VolumeLabel
                Catch ex As Exception
                End Try

                Label41.Text = curDrive.DriveFormat
                Label40.Text = curDrive.Name


                CircularProgressBar5.Maximum = TotalSize
                CircularProgressBar5.SubscriptText = curDrive.Name
                CircularProgressBar5.Text = Procent & "%"

                Me.Invoke(Sub() CircularProgressBar5.Value = UsedSpace)


            Else

                Dim FreeSpace2 As Long = curDrive.TotalFreeSpace / 1000000000
                Dim TotalSize2 As Long = curDrive.TotalSize / 1000000000

                UsedSpace2 = TotalSize2 - FreeSpace2

                Dim Procent2 As Integer = UsedSpace2 / TotalSize2 * 100

                CircularProgressBar6.Maximum = TotalSize2
                CircularProgressBar6.SubscriptText = curDrive.Name
                Me.Invoke(Sub() CircularProgressBar6.Text = Procent2 & "%")
                Me.Invoke(Sub() CircularProgressBar6.Value = UsedSpace2)


            End If
        Next

    End Sub


    Sub MemoryData()

        Dim TotalSlots As Integer = 0
        Dim TotalCapacity As Long = 0
        Dim UsedSlots As Integer = 0
        Dim objprintjob
        Dim objWMIService = GetObject("winmgmts:{impersonationLevel=impersonate}!\\.\root\cimv2")
        Dim colPrintJobs
        Try
            colPrintJobs = objWMIService.ExecQuery("Select MemoryDevices from Win32_PhysicalMemoryArray")
            For Each objprintjob In colPrintJobs
                TotalSlots = objprintjob.MemoryDevices
                Exit For
            Next
        Catch
        End Try
        colPrintJobs = Nothing
        objprintjob = Nothing

        colPrintJobs = objWMIService.ExecQuery("Select * from Win32_PhysicalMemory")
        For Each objprintjob In colPrintJobs


            TotalCapacity = CLng(TotalCapacity + objprintjob.Capacity)
            UsedSlots = UsedSlots + 1

        Next


        Dim mSearcher As New ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory")

        For Each item In mSearcher.Get
            Label119.Text = item.Properties("PartNumber").Value
            Label124.Text = item.Properties("FormFactor").Value
            Label132.Text = item.Properties("DataWidth").Value
            Label140.Text = item.Properties("TotalWidth").Value
            Label128.Text = item.Properties("ConfiguredVoltage").Value
            Label136.Text = item.Properties("SMBIOSMemoryType").Value
            Label121.Text = item.Properties("BankLabel").Value
            Label125.Text = item.Properties("MemoryType").Value
            Label133.Text = item.Properties("Attributes").Value
            Label141.Text = item.Properties("Manufacturer").Value
            Label129.Text = item.Properties("SerialNumber").Value
            Label137.Text = item.Properties("Tag").Value

        Next


        Label18.Text = TotalSlots
        Label17.Text = UsedSlots
        Label116.Text = "Total ram slots used " & UsedSlots & " out of " & TotalSlots


    End Sub


    Sub NetworkData()

        Dim mSearcher As New ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration")

        For Each item In mSearcher.Get



            If item.Properties("IPEnabled").Value = "True" Then

                Label68.Text = item.Properties("Description").Value

            End If


        Next

    End Sub





    Sub LiveStatsPnl()

        PanelLiveStats.Size = PanelLiveStats.MinimumSize
        PanelLiveStats.Location = New Point(3, 130)

        'Sub Panels
        PanelCPU.Size = PanelCPU.MinimumSize
        PanelCPU.Location = New Point(3, 2)

        PanelRam.Size = PanelRam.MinimumSize
        PanelRam.Location = New Point(3, 132)

        PanelDisk.Size = PanelDisk.MinimumSize
        PanelDisk.Location = New Point(3, 263)

        PanelNetwork.Size = PanelNetwork.MinimumSize
        PanelNetwork.Location = New Point(3, 393)

        PanelGpu.Size = PanelGpu.MinimumSize
        PanelGpu.Location = New Point(348, 393)

    End Sub



    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Hide()

        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False

        Me.Size = Frame.PnlMain.MaximumSize
        Pnl_Windows.Size = Pnl_Windows.MinimumSize
        Pnl_Computer.Size = Pnl_Computer.MinimumSize
        Pnl_Network.Size = Pnl_Network.MinimumSize
        Pnl_Processes.Size = Pnl_Processes.MinimumSize
        Pnl_User.Size = Pnl_User.MinimumSize

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

        LiveStatsPnl()








        T1 = New System.Threading.Thread(AddressOf DeviceInfo)
        T2 = New System.Threading.Thread(AddressOf MainLoop)

        T3 = New System.Threading.Thread(AddressOf MemoryData)
        T4 = New System.Threading.Thread(AddressOf CpuData)
        T5 = New System.Threading.Thread(AddressOf DiskData)

        T6 = New System.Threading.Thread(AddressOf NetworkData)
        T7 = New System.Threading.Thread(AddressOf JustCpuLoad)
        T8 = New System.Threading.Thread(AddressOf Thermal)



        T1.Start()
        T2.Start()
        T3.Start()
        T4.Start()
        T5.Start()
        T6.Start()
        T7.Start()
        T8.Start()


        Me.Show()


        'Pnl_Network.ra



    End Sub



    Sub MainLoop()

        Do



            'Ram
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

            Me.Invoke(Sub() Lbl_RamInUse.Text = sanalyer.ToString("##.# GB"))
            Me.Invoke(Sub() Lbl_Available.Text = Ram_Available)
            Me.Invoke(Sub() Lbl_TotalRam.Text = Total_Ram)

            Me.Invoke(Sub() CircularProgressBar2.Maximum = total)
            Me.Invoke(Sub() CircularProgressBar2.Value = sanalyer)
            Me.Invoke(Sub() CircularProgressBar2.Text = test & "%")
            Label2.Text = "Total ram used: " & sanalyer.ToString("N") & "/" & Total_Ram


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

            'Ia vezi aici mai jos!

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






            'Using _moSearcher As New ManagementObjectSearcher(_nameSpace, wql)

            '            For Each _mobject As ManagementObject In _moSearcher.Get

            '                LabelCpuClockSpeed.Text = Convert.ToDouble($"{_mobject("CurrentClockSpeed")}") / 1000.0 & " GHz"
            '                Label71.Text = Convert.ToDouble($"{_mobject("MaxClockSpeed")}") / 1000.0 & " GHz"


            '                Try

            '                    Dim UsageValue As Integer = $"{_mobject("LoadPercentage")}"
            '                    CircularProgressBar1.Value = UsageValue
            '                    CircularProgressBar1.Text = UsageValue & "%"
            '                    'Label24234324293534.Text = UsageValue & "%"

            '                    If UsageValue >= 0 Then
            '                        CircularProgressBar1.ProgressColor = Color.Green
            '                    End If
            '                    If UsageValue > 10 Then
            '                        CircularProgressBar1.ProgressColor = Color.Yellow
            '                    End If
            '                    If UsageValue > 25 Then
            '                        CircularProgressBar1.ProgressColor = Color.Orange
            '                    End If

            '                    If UsageValue > 40 Then
            '                        CircularProgressBar1.ProgressColor = Color.OrangeRed
            '                    End If

            '                    If UsageValue > 60 Then
            '                        CircularProgressBar1.ProgressColor = Color.Red
            '                    End If

            '                Catch ex As Exception

            '                    Frame.logger(ex.Message, "Error")
            '                End Try


            '            Next

            '        End Using

            ''CPU USAGE





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



    Private Sub DeviceInfo()


        'CPU INFO 

        Dim mSearcher As New ManagementObjectSearcher("SELECT * FROM Win32_Processor")

        For Each item In mSearcher.Get
            Lbl_CPU.Text = item.Properties("Name").Value
            Label31.Text = item.Properties("SocketDesignation").Value
            Label71.Text = item.Properties("MaxClockSpeed").Value & " GHz"
            Label3.Text = item.Properties("NumberOfCores").Value
            Label7.Text = item.Properties("NumberOfLogicalProcessors").Value



        Next
        Thread.Sleep(1000)




        'UInt16 AddressWidth;
        'UInt16 Architecture;
        'UInt16 Availability;
        'String Caption;
        'UInt32 ConfigManagerErrorCode;
        'Boolean ConfigManagerUserConfig;
        'UInt16 CpuStatus;
        'String CreationClassName;
        'UInt32 CurrentClockSpeed;
        'UInt16 CurrentVoltage;
        'UInt16 DataWidth;
        'String Description;
        'String DeviceID;
        'Boolean ErrorCleared;
        'String ErrorDescription;
        'UInt32 ExtClock;
        'UInt16 Family;
        'DateTime InstallDate;
        'UInt32 L2CacheSize;
        'UInt32 L2CacheSpeed;
        'UInt32 L3CacheSize;
        'UInt32 L3CacheSpeed;
        'UInt32 LastErrorCode;
        'UInt16 Level;
        'UInt16 LoadPercentage;
        'String Manufacturer;
        'UInt32 MaxClockSpeed;
        'String Name;
        'UInt32 NumberOfCores;
        'UInt32 NumberOfLogicalProcessors;
        'String OtherFamilyDescription;
        'String PNPDeviceID;
        'UInt16 PowerManagementCapabilities[];
        'Boolean PowerManagementSupported;
        'String ProcessorId;
        'UInt16 ProcessorType;
        'UInt16 Revision;
        'String Role;
        'String SocketDesignation;
        'String Status;
        'UInt16 StatusInfo;
        'String Stepping;
        'String SystemCreationClassName;
        'String SystemName;
        'String UniqueId;
        'UInt16 UpgradeMethod;
        'String Version;
        'UInt32 VoltageCaps









        Dim _nameSpace$ = "root\CIMV2"

        Dim wql = "SELECT * FROM WIN32_Processor"
        Dim _strBuilder As New StringBuilder
        Using _moSearcher As New ManagementObjectSearcher(_nameSpace, wql)

            For Each _mobject As ManagementObject In _moSearcher.Get
                Lbl_CPU.Text = $"{_mobject("Name")}"
                Label71.Text = $"{_mobject("MaxClockSpeed")}" & " GHz"
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


        'GPU
        Dim query As New System.Management.SelectQuery("Win32_VideoController")
        Dim search As New System.Management.ManagementObjectSearcher(query)
        Dim info As System.Management.ManagementObject
        For Each info In search.Get()
            Lbl_GPU_WTF.Text = info("Caption").ToString
            'Lbl_GPU2.Text = info("VideoProcessor").ToString

        Next





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



            PanelLiveStats.Width += 333
            PanelLiveStats.Height += 333
            PanelLiveStats.BringToFront()

            If PanelLiveStats.Size = PanelLiveStats.MaximumSize Then

                isCollapsed6 = False
                Timer_ExpandLiveStatus.Stop()
            End If


        Else

            Label5.Text = "Live stats"



            PanelLiveStats.Width -= 333
            PanelLiveStats.Height -= 333

            If PanelLiveStats.Size = PanelLiveStats.MinimumSize Then

                isCollapsed6 = True
                Timer_ExpandLiveStatus.Stop()
            End If

        End If




    End Sub


    Sub ExpandCpu()

        PanelCPU.Location = New Point(3, 2)

        If PanelCPU.Size = PanelCPU.MinimumSize Then

            PanelCPU.BringToFront()
            PanelCPU.Size = PanelCPU.MaximumSize
        Else
            PanelCPU.Size = PanelCPU.MinimumSize

        End If


    End Sub


    Sub ExpandRam()

        If PanelRam.Size = PanelRam.MinimumSize Then

            PanelRam.Size = PanelRam.MaximumSize
            PanelRam.Location = PanelCPU.Location
            PanelRam.BringToFront()


        Else
            PanelRam.Size = PanelRam.MinimumSize
            PanelRam.Location = New Point(3, 132)
        End If


    End Sub


    Sub ExpandDisk()

        If PanelDisk.Size = PanelDisk.MinimumSize Then

            PanelDisk.Location = PanelCPU.Location
            PanelDisk.Size = PanelDisk.MaximumSize
            PanelDisk.BringToFront()

        Else
            PanelDisk.Size = PanelDisk.MinimumSize
            PanelDisk.Location = New Point(3, 263)

        End If




    End Sub


    Sub ExpandNetwork()

        If PanelNetwork.Size = PanelNetwork.MinimumSize Then

            PanelNetwork.Location = PanelCPU.Location
            PanelNetwork.Size = PanelNetwork.MaximumSize
            CircularProgressBar3.Location = New Point(555, 13)

            PanelNetwork.BringToFront()

        Else
            PanelNetwork.Size = PanelNetwork.MinimumSize
            PanelNetwork.Location = New Point(3, 393)
            CircularProgressBar3.Location = New Point(230, 12)
        End If




    End Sub


    Sub ExpandGPU()

        If PanelGpu.Size = PanelGpu.MinimumSize Then

            PanelGpu.Location = PanelCPU.Location
            PanelGpu.Size = PanelGpu.MaximumSize
            CircularProgressBar7.Location = New Point(555, 13)

            PanelGpu.BringToFront()

        Else
            PanelGpu.Size = PanelGpu.MinimumSize
            PanelGpu.Location = New Point(348, 393)

            CircularProgressBar7.Location = New Point(230, 12)

        End If



    End Sub




    Private Sub PanelLiveStats_Click(sender As Object, e As EventArgs) Handles PanelLiveStats.Click, PanelCPU.Click, CircularProgressBar4.Click, CircularProgressBar1.Click


        Timer_ExpandLiveStatus.Start()


    End Sub



    Private Sub Lbl_CPU_Click(sender As Object, e As EventArgs) Handles Lbl_CPU.Click

        If PanelLiveStats.Size = PanelLiveStats.MinimumSize Then

            Timer_ExpandLiveStatus.Start()

        Else

            ExpandCpu()

        End If






    End Sub

    Private Sub PanelCPU_Hover(sender As Object, e As EventArgs) Handles PanelCPU.MouseEnter

        If PanelCPU.Size = PanelCPU.MinimumSize Then
            PanelCPU.BorderStyle = BorderStyle.FixedSingle
        End If






    End Sub

    Private Sub PanelCPU_Leave(sender As Object, e As EventArgs) Handles PanelCPU.MouseLeave

        PanelCPU.BorderStyle = BorderStyle.None

    End Sub

    Private Sub PanelRam_Hover(sender As Object, e As EventArgs) Handles PanelRam.MouseEnter

        If PanelRam.Size = PanelRam.MinimumSize Then

            PanelRam.BorderStyle = BorderStyle.FixedSingle

        End If

    End Sub

    Private Sub PanelRam_Leave(sender As Object, e As EventArgs) Handles PanelRam.MouseLeave

        PanelRam.BorderStyle = BorderStyle.None

    End Sub

    Private Sub PanelDisk_Enter(sender As Object, e As EventArgs) Handles PanelDisk.MouseEnter

        If PanelDisk.Size = PanelDisk.MinimumSize Then

            PanelDisk.BorderStyle = BorderStyle.FixedSingle

        End If



    End Sub

    Private Sub PanelDisk_Leave(sender As Object, e As EventArgs) Handles PanelDisk.MouseLeave

        PanelDisk.BorderStyle = BorderStyle.None

    End Sub


    Private Sub PanelNetwork_Enter(sender As Object, e As EventArgs) Handles PanelNetwork.MouseEnter

        If PanelNetwork.Size = PanelNetwork.MinimumSize Then
            PanelNetwork.BorderStyle = BorderStyle.FixedSingle
        End If


    End Sub


    Private Sub PanelNetwork_Leave(sender As Object, e As EventArgs) Handles PanelNetwork.MouseLeave
        PanelNetwork.BorderStyle = BorderStyle.None

    End Sub



    Private Sub PanelGPU_Enter(sender As Object, e As EventArgs) Handles PanelGpu.MouseEnter

        If PanelGpu.Size = PanelGpu.MinimumSize Then

            PanelGpu.BorderStyle = BorderStyle.FixedSingle
        End If


    End Sub


    Private Sub PanelGPU_Leave(sender As Object, e As EventArgs) Handles PanelGpu.MouseLeave

        PanelGpu.BorderStyle = BorderStyle.None
    End Sub















    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

        ExpandRam()

    End Sub

    Private Sub Lbl_Disk_Click(sender As Object, e As EventArgs) Handles Lbl_Disk.Click

        ExpandDisk()

    End Sub


    Private Sub Lbl_GPU_WTF_Click(sender As Object, e As EventArgs) Handles Lbl_GPU_WTF.Click

        ExpandGPU()

    End Sub

    Private Sub Label68_Click(sender As Object, e As EventArgs) Handles Label68.Click


        ExpandNetwork()


    End Sub

    Private Sub PanelCPU_Paint(sender As Object, e As PaintEventArgs) Handles PanelCPU.Paint

    End Sub

    Private Sub Label119_Click(sender As Object, e As EventArgs) Handles Label119.Click, Label111.Click

    End Sub

    Private Sub PanelNetwork_Paint(sender As Object, e As PaintEventArgs) Handles PanelNetwork.Paint

    End Sub

    Private Sub PanelDisk_Paint(sender As Object, e As PaintEventArgs) Handles PanelDisk.Paint

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

            Pnl_Windows.Height += 222
            Pnl_Windows.Width += 222



            Btn_Windows.Image = ImageList_ExpandBtn.Images(0)
            If Pnl_Windows.Size = Pnl_Windows.MaximumSize Then

                isCollapsed1 = False
                PnlExp = True
                Timer_Windows.Stop()

            End If
        Else

            Pnl_Windows.Height -= 222
            Pnl_Windows.Width -= 222
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

            Pnl_Computer.Height += 222
            Pnl_Computer.Width += 222



            Btn_Computer.Image = ImageList_ExpandBtn.Images(0)


            If Pnl_Computer.Size = Pnl_Computer.MaximumSize Then


                isCollapsed2 = False
                PnlExp = True
                Timer_Computer.Stop()
            End If
        Else

            Pnl_Computer.Height -= 222
            Pnl_Computer.Width -= 222

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


            Pnl_Network.Height += 222
            Pnl_Network.Width += 222
            Pnl_Network.Location = Pnl_Windows.Location


            Btn_Network.Image = ImageList_ExpandBtn.Images(0)

            If Pnl_Network.Size = Pnl_Network.MaximumSize Then

                isCollapsed3 = False
                PnlExp = True
                Timer_Network.Stop()


            End If
        Else

            Pnl_Network.Height -= 222
            Pnl_Network.Width -= 222
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

            Pnl_Processes.Height += 222
            Pnl_Processes.Width += 222
            Pnl_Processes.Location = Pnl_Windows.Location


            Btn_Processes.Image = ImageList_ExpandBtn.Images(0)

            If Pnl_Processes.Size = Pnl_Processes.MaximumSize Then

                isCollapsed4 = False
                PnlExp = True
                Timer_Processes.Stop()
            End If
        Else

            Pnl_Processes.Height -= 222
            Pnl_Processes.Width -= 222
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
            Pnl_User.Height += 222
            Pnl_User.Width += 222
            Pnl_User.Location = Pnl_Computer.Location


            If Pnl_User.Size = Pnl_User.MaximumSize Then
                Timer_User.Stop()
                isCollapsed5 = False
                PnlExp = True
            End If
        Else

            Pnl_User.Height -= 222
            Pnl_User.Width -= 222
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