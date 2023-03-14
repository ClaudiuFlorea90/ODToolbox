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
Imports System.Net.NetworkInformation
Imports CircularProgressBar
Imports Microsoft.DirectX
Imports System.Net
Imports Newtonsoft.Json.Linq
Imports System.Collections.ObjectModel
Imports System.Management.Automation
Imports System.Text.RegularExpressions


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
            Try
                Dim cpuCounter As New PerformanceCounter("Processor", "% Processor Time", "_Total")
                Dim cpuUsage As Single = cpuCounter.NextValue()
                System.Threading.Thread.Sleep(1000)
                cpuUsage = cpuCounter.NextValue()


                Label24.Text = Math.Round(cpuUsage) & " %"
                Chart3.ChartAreas("ChartArea1").AxisY.Maximum = 100
                Chart3.Series(0).Points.AddY(Math.Round(cpuUsage))

                ' Remove the major grid lines
                Chart3.ChartAreas(0).AxisX.MajorGrid.Enabled = False
                Chart3.ChartAreas(0).AxisY.MajorGrid.Enabled = False

                ' Remove the minor grid lines
                Chart3.ChartAreas(0).AxisX.MinorGrid.Enabled = False
                Chart3.ChartAreas(0).AxisY.MinorGrid.Enabled = False
                Chart3.ChartAreas(0).AxisX.LabelStyle.ForeColor = Color.WhiteSmoke
                Chart3.ChartAreas(0).AxisY.LabelStyle.ForeColor = Color.MediumSeaGreen
                ' Chart3.ChartAreas(0).AxisX.LabelStyle.Enabled = False
                'Chart3.ChartAreas(0).AxisY.LabelStyle.Enabled = False

            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            End Try


            Thread.Sleep(1000)
        Loop

    End Sub


    Sub Thermal()
        Do
            Try
                While True
                    Dim CpuTemp As Integer
                    Dim GpuTemp As Integer

                    Dim computer As New Computer()
                    computer.Open()
                    computer.CPUEnabled = True
                    computer.GPUEnabled = True

                    Dim cpuT = computer.Hardware.FirstOrDefault(Function(h) h.HardwareType = HardwareType.CPU)
                    Dim gpuT = computer.Hardware.FirstOrDefault(Function(h) h.HardwareType = HardwareType.GpuAti)

                    If cpuT IsNot Nothing Then
                        cpuT.Update()
                        CpuTemp = cpuT.Sensors.Where(Function(s) s.SensorType = SensorType.Temperature).FirstOrDefault().Value


                        Chart2.ChartAreas("ChartArea1").AxisY.Maximum = 100
                        Chart2.Series(0).Points.AddY(CpuTemp)
                        Label26.Text = CpuTemp & " c'"

                        ' Remove the major grid lines
                        Chart2.ChartAreas(0).AxisX.MajorGrid.Enabled = False
                        Chart2.ChartAreas(0).AxisY.MajorGrid.Enabled = False

                        ' Remove the minor grid lines
                        Chart2.ChartAreas(0).AxisX.MinorGrid.Enabled = False
                        Chart2.ChartAreas(0).AxisY.MinorGrid.Enabled = False
                        Chart2.ChartAreas(0).AxisX.LabelStyle.ForeColor = Color.MediumSeaGreen
                        Chart2.ChartAreas(0).AxisY.LabelStyle.ForeColor = Color.WhiteSmoke
                        'Chart2.ChartAreas(0).AxisX.LabelStyle.Enabled = False
                        'Chart2.ChartAreas(0).AxisY.LabelStyle.Enabled = False


                    End If

                    Thread.Sleep(1000)
                End While
            Catch ex As Exception

            End Try


            '    'CPU amd GPU TEMP

            '    Dim CpuTemp As Integer
            '    Dim GpuTemp As Integer

            '    Dim computer As New Computer()
            '    computer.Open()
            '    computer.CPUEnabled = True
            '    computer.GPUEnabled = True
            '    Dim cpuT = computer.Hardware.Where(Function(h) h.HardwareType = HardwareType.CPU).FirstOrDefault()
            '    Dim gpuT = computer.Hardware.Where(Function(h) h.HardwareType = HardwareType.GpuAti).FirstOrDefault()


            '    If cpuT IsNot Nothing Then
            '        cpuT.Update()

            '        Dim tempSensors = cpuT.Sensors.Where(Function(s) s.SensorType = SensorType.Temperature)
            '        'tempSensors.ToList.ForEach(Sub(s) Console.WriteLine(s.Value))
            '        tempSensors.ToList.ForEach(Sub(s) CpuTemp = (s.Value))

            '        CircularProgressBar4.Maximum = 100
            '        CircularProgressBar4.Value = CpuTemp
            '        CircularProgressBar4.Text = CpuTemp & "c'"



            '        If CpuTemp >= 0 Then
            '            CircularProgressBar4.ProgressColor = Color.Blue
            '        End If
            '        If CpuTemp > 40 Then
            '            CircularProgressBar4.ProgressColor = Color.Green
            '        End If
            '        If CpuTemp > 55 Then
            '            CircularProgressBar4.ProgressColor = Color.Orange
            '        End If
            '        If CpuTemp > 65 Then
            '            CircularProgressBar4.ProgressColor = Color.Red
            '        End If

            '    End If


            '    Thread.Sleep(1000)
        Loop

    End Sub




    Sub CpuData()

        Try
            Dim mSearcher As New ManagementObjectSearcher("SELECT * FROM Win32_Processor")
            For Each item In mSearcher.Get
                Lbl_CPU.Text = item.Properties("Name").Value
                Label31.Text = item.Properties("SocketDesignation").Value
                Label71.Text = item.Properties("MaxClockSpeed").Value & " GHz"
                Label3.Text = item.Properties("NumberOfCores").Value
                Label7.Text = item.Properties("NumberOfLogicalProcessors").Value
                Label94.Text = item.Properties("L2CacheSize").Value
                Label97.Text = item.Properties("L3CacheSize").Value
                Label93.Text = item.Properties("Status").Value
                Label96.Text = item.Properties("CurrentVoltage").Value
                Label98.Text = item.Properties("ProcessorId").Value
                Label102.Text = item.Properties("DeviceID").Value
                Label104.Text = item.Properties("AddressWidth").Value
                Label108.Text = item.Properties("DataWidth").Value
                Label112.Text = item.Properties("ExtClock").Value
                Label106.Text = item.Properties("PowerManagementSupported").Value
                Label110.Text = item.Properties("Version").Value
            Next
        Catch ex As Exception

        End Try
    End Sub


    Sub DiskData()


        Dim mSearcher As New ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive")

        For Each item In mSearcher.Get



            If item.Properties("Index").Value = 0 Then


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



                Chart4.ChartAreas("ChartArea1").AxisY.Maximum = TotalSize
                Chart4.Series("Series1").Points.AddXY("Free " & FreeSpace & " gb", FreeSpace)
                Chart4.Series("Series1").Points.AddXY("Used " & UsedSpace & " gb", UsedSpace)


                ' Create a new TextAnnotation object
                Dim textAnnotation As New DataVisualization.Charting.TextAnnotation()
                textAnnotation.Text = curDrive.Name & " " & Procent & "%"
                textAnnotation.Font = New Font("Microsoft PhagsPa", 9.7, FontStyle.Bold)
                textAnnotation.ForeColor = Color.WhiteSmoke
                textAnnotation.X = 35
                textAnnotation.Y = 50
                Chart4.Annotations.Add(textAnnotation)
                'Chart4.Series("Series1").ChartType = DataVisualization.Charting.SeriesChartType.Doughnut



            Else

                Dim FreeSpace2 As Long = curDrive.TotalFreeSpace / 1000000000
                Dim TotalSize2 As Long = curDrive.TotalSize / 1000000000

                UsedSpace2 = TotalSize2 - FreeSpace2

                Dim Procent2 As Integer = UsedSpace2 / TotalSize2 * 100



                Chart5.ChartAreas("ChartArea1").AxisY.Maximum = TotalSize2
                Chart5.Series("Series1").Points.AddXY("Free " & FreeSpace2 & " gb", FreeSpace2)
                Chart5.Series("Series1").Points.AddXY("Used " & UsedSpace2 & " gb", UsedSpace2)

                Dim textAnnotation As New DataVisualization.Charting.TextAnnotation()
                textAnnotation.Text = curDrive.Name & " " & Procent2 & "%"
                textAnnotation.Font = New Font("Microsoft PhagsPa", 9.7, FontStyle.Bold)
                textAnnotation.ForeColor = Color.WhiteSmoke
                textAnnotation.X = 35
                textAnnotation.Y = 50
                Chart5.Annotations.Add(textAnnotation)

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
            ' Exception handling code
        End Try

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
            Exit For ' only retrieve the first memory device info
        Next

        Label18.Text = TotalSlots
        Label17.Text = UsedSlots
        Label116.Text = "Total ram slots used " & UsedSlots & " out of " & TotalSlots

    End Sub


    Sub NetworkData(lblNetworkActivity As Label)

        Dim computerIPv4 As String = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList.FirstOrDefault(Function(i) i.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork).ToString()
        Dim computerIPv6 As String = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList.FirstOrDefault(Function(i) i.AddressFamily = System.Net.Sockets.AddressFamily.InterNetworkV6).ToString()
        Label191.Text = "IpV4 Address: " & computerIPv4
        Label188.Text = "IpV6 Address: " & computerIPv6


        Dim interfaces As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
        For Each intf As NetworkInterface In interfaces
            If intf.OperationalStatus = OperationalStatus.Up AndAlso intf.NetworkInterfaceType <> NetworkInterfaceType.Loopback Then

                Label36.Text = intf.Name & " - " & intf.Description 'Name and description
                Exit For
            End If
        Next



        Try
            Label68.Text = "Send Speed: 0 Kbps"
            Label77.Text = "Receive Speed: 0 Kbps"

            Dim loopChart As Integer = 0
            Do
                loopChart = loopChart + 1
                Dim adapters As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
                For Each adapter As NetworkInterface In adapters
                    If adapter.NetworkInterfaceType = NetworkInterfaceType.Ethernet AndAlso adapter.OperationalStatus = OperationalStatus.Up Then
                        Dim statistics As IPInterfaceStatistics = adapter.GetIPStatistics

                        'Calculate Send Speed
                        Dim sendSpeed As Double = (statistics.BytesSent / 1024) * 8
                        'Calculate Receive Speed
                        Dim receiveSpeed As Double = (statistics.BytesReceived / 1024) * 8



                        'Chart1.ChartAreas(0).AxisX.MajorGrid.Enabled = False
                        'Chart1.ChartAreas(0).AxisY.MajorGrid.Enabled = False

                        ''' Remove the minor grid lines
                        'Chart1.ChartAreas(0).AxisX.MinorGrid.Enabled = False
                        'Chart1.ChartAreas(0).AxisY.MinorGrid.Enabled = False
                        '' Chart1.ChartAreas(0).AxisX.LabelStyle.Enabled = False
                        ''Chart1.ChartAreas(0).AxisY.LabelStyle.Enabled = False


                        'Chart1.ChartAreas(0).AxisY.Maximum = sendSpeed + receiveSpeed
                        'Chart1.Series(0).Points.AddY((sendSpeed))
                        ''Chart1.Series(1).Points.AddXY((loopChart, receiveSpeed))







                        If sendSpeed > 1000 Then
                            sendSpeed /= 1000
                            Label68.Text = "Send Speed: " & sendSpeed.ToString("0.00") & " Mbps"
                        Else
                            Label68.Text = "Send Speed: " & sendSpeed.ToString("0.00") & " Kbps"
                        End If


                        If receiveSpeed > 1000 Then
                            receiveSpeed /= 1000
                            Label77.Text = "Receive Speed: " & receiveSpeed.ToString("0.00") & " Mbps"
                        Else
                            Label77.Text = "Receive Speed: " & receiveSpeed.ToString("0.00") & " Kbps"
                        End If


                    End If
                Next
                Thread.Sleep(1000)
            Loop
        Catch ex As Exception

        End Try







    End Sub


    Sub LiveStatsPnl_Default()

        'For Each control As Panel In PanelLiveStats.Controls
        '    ToolBox.RoundedCorner(control, 20)

        'Next

        PanelLiveStats.Size = PanelLiveStats.MinimumSize
        PanelLiveStats.Location = New Point(4, 303)


        ''Sub Panels
        PanelCPU.Size = PanelCPU.MinimumSize
        PanelCPU.Location = New Point(3, 3)
        ToolBox.RoundedCorner(PanelCPU, 10)


        PanelRam.Size = PanelRam.MinimumSize
        PanelRam.Location = New Point(320, 3)

        PanelDisk.Size = PanelDisk.MinimumSize
        PanelDisk.Location = New Point(4, 109)

        PanelNetwork.Size = PanelNetwork.MinimumSize
        PanelNetwork.Location = New Point(521, 109)

        PanelGpu.Size = PanelGpu.MinimumSize
        PanelGpu.Location = New Point(727, 3)

        Pnl_Windows.Size = Pnl_Windows.MinimumSize
        Pnl_Computer.Size = Pnl_Computer.MinimumSize

    End Sub


    Sub Main6Pnl(pnl As Panel)

        If pnl.Size = pnl.MinimumSize Then
            Do Until pnl.Size = MaximumSize
                pnl.Width = pnl.Width + 25
                pnl.Height = pnl.Height + 25

            Loop


            For Each control As Control In pnl.Controls
                control.Show()

            Next

            pnl.BackgroundImage = My.Resources.Resources.eye
            pnl.Location = New Point(459, 252)
        Else
            Do Until pnl.Size = MinimumSize
                pnl.Width = pnl.Width - 25
                pnl.Height = pnl.Height - 25

            Loop

            For Each control As Control In pnl.Controls
                control.Hide()
            Next
            pnl.BackgroundImage = Nothing
            pnl.Location = New Point(0, 0)
        End If





        pnl.BringToFront()

    End Sub



    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Size = Frame.PnlMain.MaximumSize




        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False

        PictureBox6.Image = GetUserTile(System.Security.Principal.WindowsIdentity.GetCurrent().Name)




        LiveStatsPnl_Default()


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
            Label2.Text = "Total ram used: " & sanalyer.ToString("N") & "/" & Total_Ram


            Dim _nameSpace$ = "root\CIMV2"

            Dim wql = "SELECT * FROM Win32_PhysicalMemory"
            Dim _strBuilder As New StringBuilder
            Using _moSearcher As New ManagementObjectSearcher(_nameSpace, wql)

                For Each _mobject As ManagementObject In _moSearcher.Get
                    Label19.Text = Convert.ToDouble($"{_mobject("ConfiguredClockSpeed")}") & "MHz"
                    ' Lbl_SlotsUsed.Text = $"{_mobject("DeviceLocator")}"
                    'Lbl_FormFactor.Text = $"{_mobject("FormFactor")}"
                Next


                ' Add data points to the chart


            End Using


            Dim RamForUse As Integer = Total_Ram2 - sanalyer
            Dim TotalRamWTF As Integer = Total_Ram2
            'CircularProgressBarRam2.Maximum = TotalRamWTF
            'CircularProgressBarRam2.Value = RamForUse
            Dim FreeMemProcent As Integer
            FreeMemProcent = RamForUse / TotalRamWTF * 100
            'CircularProgressBarRam2.Text = FreeMemProcent & "%"



            Dim textAnnotation As New DataVisualization.Charting.TextAnnotation()
            textAnnotation.Text = Total_Ram
            textAnnotation.Font = New Font("Microsoft PhagsPa", 9.7, FontStyle.Bold)
            textAnnotation.ForeColor = Color.Gray
            textAnnotation.X = 24
            textAnnotation.Y = 44
            ChartRam.Annotations.Add(textAnnotation)



            ChartRam.Series("Series1").Points.Clear()
            'ChartRam.Series("Series1").Points.AddXY("Total " & Total_Ram, total)
            ChartRam.Series("Series1").Points.AddXY("Used " & test & "% ", sanalyer)
            ChartRam.Series("Series1").Points.AddXY("Available " & FreeMemProcent & "% ", RamForUse)
            ' Set the chart type to Doughnut
            ChartRam.Series("Series1").ChartType = DataVisualization.Charting.SeriesChartType.Doughnut




            'GPU DATA LOOP

            Dim query As New SelectQuery("Win32_VideoController")
            Dim searcher As New ManagementObjectSearcher(query)


            For Each obj As ManagementObject In searcher.Get()
                Dim totalMemory As ULong = ULong.Parse(obj("AdapterRAM").ToString())
                ' Dim usedMemory As ULong = ULong.Parse(obj("AdapterRAM").ToString()) - ULong.Parse(obj("AdapterFreeMemory").ToString())
                Lbl_GpuTotalMemory.Text = "GPU total memory: " & (totalMemory / 1024 / 1024).ToString("N0") & " MB"
                'Console.WriteLine("GPU total memory: " & (totalMemory / 1024 / 1024).ToString("N0") & " MB")
                'Console.WriteLine("GPU used memory: " & (usedMemory / 1024 / 1024).ToString("N0") & " MB")
            Next





















            'System Up-Time
            Dim strResult As String = String.Empty
            strResult &= (Environment.TickCount \ 86400000).ToString + " days, "
            strResult &= (Environment.TickCount / 3600000 Mod 24).ToString("n0") + " hours, "
            strResult &= (Environment.TickCount / 120000 Mod 60).ToString("n0") + " minutes, "

            Lbl_UpTime.Text = "uptime : " & strResult



            Thread.Sleep(2000)
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






        'USER INFO

        Lbl_User.Text = "Welcome " & My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "RegisteredOwner", Nothing)



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

        ''IS WINDOWS ACTIVATED?
        'Dim searcher As New ManagementObjectSearcher(
        '  "root\CIMV2",
        '     "SELECT * FROM SoftwareLicensingProduct WHERE LicenseStatus = 1")
        'Dim myCollection As ManagementObjectCollection
        'Dim myObject As ManagementObject
        'myCollection = searcher.Get()
        'If myCollection.Count = 0 Then

        '    Label4.Text = "Yes"

        'Else
        '    Label4.Text = "No"

        'End If


        'GPU

        Dim query As New SelectQuery("Win32_VideoController")
        Dim searcher As New ManagementObjectSearcher(query)
        For Each obj As ManagementObject In searcher.Get()
            Dim driverVersion As String = obj("DriverVersion").ToString()
            Dim driverDate As String = obj("DriverDate").ToString()
            Dim gpuName As String = obj("Name").ToString()
            Label20.Text = driverVersion
            Label30.Text = driverDate
            Lbl_GPU_WTF.Text = gpuName
        Next

        'Lbl_GPU_WTF.Text = info("Caption").ToString
        ''Lbl_GPU2.Text = info("VideoProcessor").ToString

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




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Pnl_Windows.Click, Lbl_OS.Click


        Timer_Windows.Start()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Pnl_Computer.Click, Lbl_PC.Click
        Timer_Computer.Start()


    End Sub

    Private Sub Panel13_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Timer_ExpandLiveStatus_Tick(sender As Object, e As EventArgs) Handles Timer_ExpandLiveStatus.Tick


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

        ' PanelCPU.Location = New Point(3, 2)

        If PanelCPU.Size = PanelCPU.MinimumSize Then
            PanelCPU.Size = PanelLiveStats.Size
            PanelCPU.BringToFront()
        Else
            LiveStatsPnl_Default()

        End If


    End Sub


    Sub ExpandRam()

        If PanelRam.Size = PanelRam.MinimumSize Then

            PanelRam.Size = PanelLiveStats.Size
            PanelRam.Location = PanelCPU.Location
            PanelRam.BringToFront()


        Else
            LiveStatsPnl_Default()
        End If


    End Sub


    Sub ExpandDisk()

        If PanelDisk.Size = PanelDisk.MinimumSize Then
            PanelDisk.Location = PanelCPU.Location
            PanelDisk.Size = PanelLiveStats.Size
            PanelDisk.BringToFront()

        Else
            LiveStatsPnl_Default()
        End If




    End Sub


    Sub ExpandNetwork()

        If PanelNetwork.Size = PanelNetwork.MinimumSize Then
            PanelNetwork.Location = PanelCPU.Location
            PanelNetwork.Size = PanelLiveStats.Size
            PanelNetwork.BringToFront()

        Else
            LiveStatsPnl_Default()
        End If




    End Sub


    Sub ExpandGPU()

        If PanelGpu.Size = PanelGpu.MinimumSize Then

            PanelGpu.Location = PanelCPU.Location
            PanelGpu.Size = PanelLiveStats.Size

            PanelGpu.BringToFront()

        Else
            LiveStatsPnl_Default()
        End If



    End Sub

    Private Sub Lbl_CPU_Click(sender As Object, e As EventArgs) Handles Lbl_CPU.Click, PanelCPU.Click
        ExpandCpu()
    End Sub



    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, PanelRam.Click

        ExpandRam()

    End Sub

    Private Sub Timer_User_Tick(sender As Object, e As EventArgs) Handles Timer_User.Tick

    End Sub

    Private Sub Chart5_Click(sender As Object, e As EventArgs) Handles Chart5.Click, Chart4.Click

    End Sub

    Private Sub Label110_Click(sender As Object, e As EventArgs) Handles Label110.Click

    End Sub

    Private Sub PanelRam_Paint(sender As Object, e As PaintEventArgs) Handles PanelRam.Paint
        Dim rect As New Rectangle(0, 0, PanelRam.Width - 1, PanelRam.Height - 1)
        Dim path As New Drawing2D.GraphicsPath()
        Dim radius As Integer = 20

        path.StartFigure()
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddLine(rect.X + radius, rect.Y, rect.Width - radius, rect.Y)
        path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90)
        path.AddLine(rect.Width, rect.Y + radius, rect.Width, rect.Height - radius)
        path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90)
        path.AddLine(rect.Width - radius, rect.Height, rect.X + radius, rect.Height)
        path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()

        PanelRam.Region = New Region(path)
    End Sub



    Private Sub PanelDisk_Paint(sender As Object, e As PaintEventArgs) Handles PanelDisk.Paint

        Dim rect As New Rectangle(0, 0, PanelDisk.Width - 1, PanelDisk.Height - 1)
        Dim path As New Drawing2D.GraphicsPath()
        Dim radius As Integer = 20

        path.StartFigure()
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddLine(rect.X + radius, rect.Y, rect.Width - radius, rect.Y)
        path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90)
        path.AddLine(rect.Width, rect.Y + radius, rect.Width, rect.Height - radius)
        path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90)
        path.AddLine(rect.Width - radius, rect.Height, rect.X + radius, rect.Height)
        path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()

        PanelDisk.Region = New Region(path)

    End Sub

    Private Sub PanelGpu_Paint(sender As Object, e As PaintEventArgs) Handles PanelGpu.Paint
        Dim rect As New Rectangle(0, 0, PanelGpu.Width - 1, PanelGpu.Height - 1)
        Dim path As New Drawing2D.GraphicsPath()
        Dim radius As Integer = 20

        path.StartFigure()
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddLine(rect.X + radius, rect.Y, rect.Width - radius, rect.Y)
        path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90)
        path.AddLine(rect.Width, rect.Y + radius, rect.Width, rect.Height - radius)
        path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90)
        path.AddLine(rect.Width - radius, rect.Height, rect.X + radius, rect.Height)
        path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()

        PanelGpu.Region = New Region(path)
    End Sub

    Private Sub PanelNetwork_Paint(sender As Object, e As PaintEventArgs) Handles PanelNetwork.Paint
        Dim rect As New Rectangle(0, 0, PanelNetwork.Width - 1, PanelNetwork.Height - 1)
        Dim path As New Drawing2D.GraphicsPath()
        Dim radius As Integer = 20

        path.StartFigure()
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddLine(rect.X + radius, rect.Y, rect.Width - radius, rect.Y)
        path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90)
        path.AddLine(rect.Width, rect.Y + radius, rect.Width, rect.Height - radius)
        path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90)
        path.AddLine(rect.Width - radius, rect.Height, rect.X + radius, rect.Height)
        path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()

        PanelNetwork.Region = New Region(path)
    End Sub

    Private Sub Pnl_Windows_Paint(sender As Object, e As PaintEventArgs) Handles Pnl_Windows.Paint
        Dim rect As New Rectangle(0, 0, Pnl_Windows.Width - 1, Pnl_Windows.Height - 1)
        Dim path As New Drawing2D.GraphicsPath()
        Dim radius As Integer = 20

        path.StartFigure()
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddLine(rect.X + radius, rect.Y, rect.Width - radius, rect.Y)
        path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90)
        path.AddLine(rect.Width, rect.Y + radius, rect.Width, rect.Height - radius)
        path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90)
        path.AddLine(rect.Width - radius, rect.Height, rect.X + radius, rect.Height)
        path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()

        Pnl_Windows.Region = New Region(path)
    End Sub

    Private Sub Pnl_Computer_Paint(sender As Object, e As PaintEventArgs) Handles Pnl_Computer.Paint
        Dim rect As New Rectangle(0, 0, Pnl_Computer.Width - 1, Pnl_Computer.Height - 1)
        Dim path As New Drawing2D.GraphicsPath()
        Dim radius As Integer = 20

        path.StartFigure()
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddLine(rect.X + radius, rect.Y, rect.Width - radius, rect.Y)
        path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90)
        path.AddLine(rect.Width, rect.Y + radius, rect.Width, rect.Height - radius)
        path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90)
        path.AddLine(rect.Width - radius, rect.Height, rect.X + radius, rect.Height)
        path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()

        Pnl_Computer.Region = New Region(path)
    End Sub

    Private Sub RoundedButton2_Click(sender As Object, e As EventArgs) Handles RoundedButton2.Click

        Dim CheckAppUpdates As New System.Threading.Thread(AddressOf CheckForUpdates)
        CheckAppUpdates.Start()

    End Sub
    Private Sub CheckForUpdates()
        ' Create a new process to run the winget command
        Dim process As New Process()
        process.StartInfo.FileName = "winget"
        process.StartInfo.Arguments = "upgrade"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardOutput = True
        process.Start()

        ' Read the output of the winget command
        Dim output As String = process.StandardOutput.ReadToEnd()


        ' Split the output into lines and add them to the ListView control
        Dim lines() As String = output.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
        For Each line As String In lines
            Dim parts() As String = line.Split(vbTab)
            If parts.Length = 2 Then
                Dim item As New ListViewItem(parts)
                ListView1.Items.Add(item)
            End If
        Next

        ' Set the column headers
        ListView1.Columns.Add("Package", 100)
        ListView1.Columns.Add("Installed", 100)
        ListView1.Columns.Add("Available", 100)
        ListView1.Columns.Add("Publisher", 100)
        process.WaitForExit()

    End Sub

    Private Sub PanelCPU_Paint(sender As Object, e As PaintEventArgs) Handles PanelCPU.Paint

    End Sub

    Private Sub Lbl_Disk_Click(sender As Object, e As EventArgs) Handles Lbl_Disk.Click, PanelDisk.Click
        ExpandDisk()
    End Sub


    Private Sub Lbl_GPU_WTF_Click(sender As Object, e As EventArgs) Handles Lbl_GPU_WTF.Click, PanelGpu.Click

        ExpandGPU()

    End Sub

    Private Sub Label68_Click(sender As Object, e As EventArgs) Handles Label68.Click, PanelNetwork.Click
        ExpandNetwork()
    End Sub


    Private Sub Panel7_Click(sender As Object, e As EventArgs)
        'Main6Pnl(Panel7)
    End Sub

    'Private Sub TimerTEST_Tick(sender As Object, e As EventArgs) Handles TimerTEST.Tick

    '    Expand(Panel7)

    'End Sub


    'Sub Expand(pnl As Panel)
    '    If pnl.Size = pnl.MinimumSize Then
    '        Do Until pnl.Size = MaximumSize
    '            pnl.Width = pnl.Width + 25
    '            pnl.Height = pnl.Height + 25

    '        Loop


    '        For Each control As Control In pnl.Controls
    '            control.Show()

    '        Next

    '        pnl.BackgroundImage = My.Resources.Resources.eye
    '        pnl.Location = New Point(459, 252)
    '    Else
    '        Do Until pnl.Size = MinimumSize
    '            pnl.Width = pnl.Width - 25
    '            pnl.Height = pnl.Height - 25

    '        Loop

    '        For Each control As Control In pnl.Controls
    '            control.Hide()
    '        Next
    '        pnl.BackgroundImage = Nothing
    '        pnl.Location = New Point(0, 0)
    '    End If




    '    TimerTEST.Stop()
    '    pnl.BringToFront()

    'End Sub




    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Lbl_User.Click

        Timer_User.Start()



    End Sub



    Private Sub Timer_Windows_Tick(sender As Object, e As EventArgs) Handles Timer_Windows.Tick

        If isCollapsed2 = False Then
            isCollapsed2 = True
            Pnl_Computer.Size = Pnl_Computer.MinimumSize

        End If








        ''''
        If isCollapsed1 Then

            Pnl_Windows.Height += 222
            Pnl_Windows.Width += 222




            If Pnl_Windows.Size = Pnl_Windows.MaximumSize Then

                isCollapsed1 = False
                PnlExp = True
                Timer_Windows.Stop()

            End If
        Else

            Pnl_Windows.Height -= 222
            Pnl_Windows.Width -= 222


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

        End If


        ''''

        If isCollapsed2 Then

            Pnl_Computer.Height += 222
            Pnl_Computer.Width += 222




            If Pnl_Computer.Size = Pnl_Computer.MaximumSize Then


                isCollapsed2 = False
                PnlExp = True
                Timer_Computer.Stop()
            End If
        Else

            Pnl_Computer.Height -= 222
            Pnl_Computer.Width -= 222



            If Pnl_Computer.Size = Pnl_Computer.MinimumSize Then



                isCollapsed2 = True
                PnlExp = False
                Timer_Computer.Stop()
            End If

        End If

        LastExpPnl = Pnl_Computer
        Pnl_Computer.BringToFront()

    End Sub

    Private Sub Timer_Processes_Tick(sender As Object, e As EventArgs)

        If isCollapsed1 = False Then
            isCollapsed1 = True
            Pnl_Windows.Size = Pnl_Windows.MinimumSize

        End If

        If isCollapsed2 = False Then
            isCollapsed2 = True
            Pnl_Computer.Size = Pnl_Computer.MinimumSize
        End If







    End Sub





End Class