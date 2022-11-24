Imports System.Web.Script.Serialization
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
Imports System.Net.Mime.MediaTypeNames
Imports System.Windows.Media.Animation
Imports System.Diagnostics.Contracts
Imports System.ComponentModel
Imports System.Windows.Input
Imports Microsoft.VisualBasic.Devices
Imports System.Windows.Controls.Primitives
Imports CefSharp.DevTools.Debugger
Imports System.Runtime.InteropServices
Imports System.Drawing.Imaging

Public Class VirusScanForm

    Public tsElapseTime As TimeSpan
    Public dtStartTime As DateTime

    Dim isPnlExpanded1 As Boolean
    Dim isPnlExpanded2 As Boolean
    Dim isPnlExpanded3 As Boolean


    Dim DataGridView_index As Integer = 0

    Public VS_Time As Integer
    Public VS_Items As Integer
    Public VS_Threads As Integer
    Public VS_PUPs As Integer
    Public VS_Detection_Ignored As Integer
    Public VS_Detection_Removed As Integer

    Public virusScanType As String
    Dim isScanning As Boolean = False


    Dim FakeScannedFiles As Integer = 0


    Public VirusScanThread As New System.Threading.Thread(AddressOf VirusScan)

    Public regKey As String = "HKEY_CURRENT_USER\SOFTWARE\TEST"

    Public Structure propietatiDeSalvat


        Public scanStartedBy As String
        Public scanType As String
        Public scanLastDate As String
        Public scanDuration As String
        Public scanItems As String
        Public scanThreads As String
        Public scanThreadsRemoved As String




    End Structure

    Sub Save()
        For Each X As Control In Me.Controls
            If TypeOf X Is Label Then
                Dim dic As New propietatiDeSalvat
                dic.scanLastDate = X.Text
                dic.scanDuration = X.Text
                dic.scanItems = X.Text
                dic.scanThreads = X.Text
                dic.scanThreadsRemoved = X.Text
                Dim json As New JavaScriptSerializer
                json.MaxJsonLength = 2147483644
                My.Computer.Registry.SetValue(regKey, X.Name, json.Serialize(dic))
            End If
        Next
    End Sub
    Sub LoadJson()
        For Each X As Control In Me.Controls
            If TypeOf X Is Label Then
                Dim data As String = My.Computer.Registry.GetValue(regKey, X.Name, Nothing)
                If data Is Nothing Then Continue For
                Dim json As New JavaScriptSerializer
                json.MaxJsonLength = 2147483644
                Dim dic As propietatiDeSalvat = json.Deserialize(Of propietatiDeSalvat)(data)
                X.Text = dic.scanLastDate
                X.Text = dic.scanDuration
                X.Text = dic.scanItems
                X.Text = dic.scanThreads
                X.Text = dic.scanThreadsRemoved
            End If
        Next

    End Sub

    Sub Settings()








        Label45.Text = PowerShell("(Get-MpComputerStatus).AntispywareSignatureLastUpdated")


        LblAntispyware.Text = PowerShell("(Get-MpComputerStatus).AntispywareEnabled")
        LabelRealTimeProtection.Text = PowerShell("(Get-MpComputerStatus).RealTimeProtectionEnabled")









    End Sub



    Private Sub VirusScanForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        PanelLastScan.Hide()
        Panel12.Hide()
        PanelVirusScanSlideshow.Hide()

        LoadJson()





        swichPanel(Panel_Scanner, Panel_1, Lbl_Scanner)





        Dim T As New System.Threading.Thread(AddressOf Settings)
        T.Start()

        Dim T2 As New System.Threading.Thread(AddressOf SlideShow)
        T2.Start()




        'Default size and location
        Panel_history.Size = Panel_history.MinimumSize
        Panel_Expand_Scanner.Size = Panel_Expand_Scanner.MinimumSize
        Panel_Protection.Size = Panel_Protection.MinimumSize


        Panel_Expand_Scanner.Location = New Point(235, 319)
        Panel_history.Location = New Point(13, 319)
        Panel_Protection.Location = New Point(456, 319)



    End Sub



    Private Sub Btn_StartScan_Click(sender As Object, e As EventArgs) Handles Btn_StartScan.Click





        virusScanType = ScanOptions.ComboBox_ScanType.Text




        If isScanning = True Then


            VirusScanThread.Abort()
            ChangeScanningPanel(Panel6)
            Btn_StartScan.Text = "Start"
            PicBox_ScanPng.Image = My.Resources.Resources.beforeScan
            Label54.Text = "Scanner"
            Label54.Location = New Point(63, 174)
            isScanning = False

        Else

            VirusScanThread = New System.Threading.Thread(AddressOf VirusScan)
            VirusScanThread.Start()
            Label54.Text = "Scanning"
            Btn_StartScan.Text = "Cancel"
            isScanning = True
        End If


        If Panel_Expand_Scanner.Size = Panel_Expand_Scanner.MinimumSize Then

        Else
            Command.ChangeScanningPanel(Pnl_IsScanning)
        End If

    End Sub

    Private Sub Btn_BackToScan_Click(sender As Object, e As EventArgs)



        For Each prog As Process In Process.GetProcesses
            If prog.ProcessName = "powershell.exe" Then
                prog.Kill()

            End If
        Next


        swichPanel(Panel_Scanner, Panel_1, Lbl_Scanner)

    End Sub


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


    Sub ScannedFiles()

        Do
            FakeScannedFiles = FakeScannedFiles + 1
            Label8.Text = FakeScannedFiles



        Loop



    End Sub

    Function VirusScan()

        isScanning = True
        Frame.logger("Virus scan started", "Info")
        Lbl_Scanduration.Text = "0"


        Dim virusScanTime As Integer = 0
        Dim virusScanStepName As String



        Label54.Text = "Scanning"
        PicBox_ScanPng.Image = My.Resources.duringScan



        'Steps PicBoxes
        PicBox1.Image = Nothing
        PicBox2.Image = Nothing
        PicBox3.Image = Nothing
        PicBox4.Image = Nothing
        PicBox5.Image = Nothing

        'Ps script
        Dim p As Process = New Process()
        p.StartInfo.FileName = "PowerShell.exe"
        p.StartInfo.UseShellExecute = False
        p.StartInfo.CreateNoWindow = True
        p.StartInfo.RedirectStandardOutput = True
        p.StartInfo.RedirectStandardError = True

        'Pas.1 Checking for updates
        virusScanStepName = "Updating Antivirus"

        p.StartInfo.Arguments = "Update-MpSignature"
        p.Start()

        PicBox1.Image = My.Resources.loading1
        Lbl_Pas1.Font = New Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold)



        Do Until p.HasExited = True
            VS_Time = VS_Time + 1
            Lbl_Scanduration.Text = VS_Time & " sec"
            Label54.Text = VS_Time & "%  " & virusScanStepName
            Label54.Location = New Point(2, 174)
            Thread.Sleep(1000)
        Loop


        'Label bold
        PicBox1.Image = My.Resources.check_mark__3_
        Lbl_Pas1.Font = New Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular)


        'Pas.2 Rest of scan
        Dim FakeScanItemsCount As New System.Threading.Thread(AddressOf ScannedFiles)
        FakeScanItemsCount.Start()


        PicBox2.Image = My.Resources.loading1
        Lbl_Pas2.Font = New Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold)


        virusScanStepName = "Scanning Memory"

        If virusScanType = "Quick Scan" Then
            p.StartInfo.Arguments = "Start-MpScan -ScanType QuickScan"  'ScanType Var
        Else
            p.StartInfo.Arguments = "Start-MpScan -ScanType FullScan"  'ScanType Var
        End If
        p.Start()

        Do Until p.HasExited = True
            VS_Time = VS_Time + 1
            Lbl_Scanduration.Text = VS_Time & " sec"

            Label54.Location = New Point(4, 174)
            Label54.Text = VS_Time & "%  " & virusScanStepName


            If VS_Time >= 5 Then
                PicBox2.Image = My.Resources.check_mark__3_
                Lbl_Pas2.Font = New Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular)
                PicBox3.Image = My.Resources.loading1
                Lbl_Pas3.Font = New Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold)

                virusScanStepName = "Startup Items"
                Label54.Location = New Point(22, 174)
                Label54.Text = VS_Time & "%  " & virusScanStepName


            End If
            If VS_Time >= 10 Then
                PicBox3.Image = My.Resources.check_mark__3_
                Lbl_Pas3.Font = New Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular)
                PicBox4.Image = My.Resources.loading1
                Lbl_Pas4.Font = New Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold)

                virusScanStepName = "Scanning Registry"
                Label54.Location = New Point(2, 174)
                Label54.Text = VS_Time & "%  " & virusScanStepName

            End If



            If VS_Time >= 15 Then


                Lbl_Pas4.Font = New Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular)
                PicBox4.Image = My.Resources.check_mark__3_
                PicBox5.Image = My.Resources.loading1
                Lbl_Pas5.Font = New Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold)

                virusScanStepName = "File system"
                Label54.Location = New Point(27, 174)
                Label54.Text = VS_Time & "%  " & virusScanStepName


            End If
            Thread.Sleep(1000)
        Loop



        'Progress bar

        virusScanTime = VS_Time

        PicBox5.Image = My.Resources.check_mark__3_
        Lbl_Pas5.Font = New Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular)


        FakeScanItemsCount.Abort()
        Label54.Text = "Scan Completed!"
        Label54.Location = New Point(33, 174)


        'Get Detection result
        p.StartInfo.FileName = "PowerShell.exe"
        p.StartInfo.UseShellExecute = False
        p.StartInfo.CreateNoWindow = True
        p.StartInfo.RedirectStandardOutput = True
        p.StartInfo.RedirectStandardError = True

        'Detected Count
        p.StartInfo.Arguments = "cls;$Detect=0;foreach ($Detection in (Get-MpThreat).ThreatName){$Detect=$Detect+1};Write-Host $Detect"
        p.Start()
        p.WaitForExit()
        'Dim ps_detect_count As String = p.StandardOutput.ReadToEnd()
        VS_Threads = p.StandardOutput.ReadToEnd()
        'Detected Files
        p.StartInfo.Arguments = "cls;foreach ($Detected in (Get-MpThreat).ThreatName){Write-Host $Detected}"
        p.Start()
        p.WaitForExit()
        Dim ps_detect_file As String = p.StandardOutput.ReadToEnd()




        If VS_Threads = 0 Then
            swichPanel(Panel_Scanner, Panel_1, Lbl_Scanner)
            Command.ChangeScanningPanel(Pnl_ScanCompleted)

        End If

        ' tmrGetTimeSpan()
        ''getDetections()

        'Public scanStartedBy As String
        'Public scanType As String
        'Public scanLastDate As String
        'Public scanDuration As String
        'Public scanItems As String
        'Public scanThreads As String
        'Public scanThreadsRemoved As String


        Dim X As New propietatiDeSalvat
        X.scanType = virusScanType
        X.scanLastDate = DateTime.Now
        X.scanDuration = VS_Time
        X.scanItems = Label8.Text
        X.scanThreads = VS_Threads
        X.scanThreadsRemoved = VS_Threads


        Me.DataGridView2.Rows.Add(X.scanType, X.scanThreads, X.scanItems, X.scanDuration, X.scanLastDate)


        ''Send to scan report

        Btn_StartScan.Text = "Start"

        'Label43.Text = ps_detect_count
        'Label44.Text = ps_detect_file


        Label43.Text = VS_Threads
        Label44.Text = ps_detect_file
        Label72.Text = X.scanLastDate



        Label29.Text = VS_Detection_Ignored
        Label16.Text = VS_Time
        Label36.Text = VS_Items


        LblScanDate.Text = X.scanLastDate
        LblScannedItems.Text = X.scanItems


        'The Black Mini raport
        Label17.Text = X.scanDuration
        Label19.Text = X.scanItems
        Label18.Text = X.scanThreads
        Label25.Text = X.scanThreadsRemoved


        Label70.Text = ps_detect_file


        'End


        PicBox_ScanPng.Image = My.Resources.afterScan

        Label54.Text = "Scanner"
        Label54.Location = New Point(63, 174)

        VS_Time = 0








        Frame.logger("Virus scan ended", "Info")
        isScanning = False
        Save()
        Return Nothing



    End Function





    Function swichPanel(Pnl As Panel, PnlBtn As Panel, lbl As Label)


        'Hide Under button pnl
        Panel_1.Hide()
        Panel_2.Hide()
        Panel_3.Hide()

        'Pnl_IsScanning.SendToBack()
        'Pnl_ScanCompleted.SendToBack()
        'Pnl_beginScan.SendToBack()

        Lbl_Scanner.ForeColor = Color.LightGray
        Lbl_Scheduler.ForeColor = Color.LightGray
        Lbl_Reports.ForeColor = Color.LightGray

        Lbl_Scanner.Font = New Font("Trebuchet MS", 13.0F, FontStyle.Regular)
        Lbl_Scheduler.Font = New Font("Trebuchet MS", 13.0F, FontStyle.Regular)
        Lbl_Reports.Font = New Font("Trebuchet MS", 13.0F, FontStyle.Regular)


        lbl.ForeColor = Color.DarkOrange
        'lbl.ForeColor = ColorTranslator.FromHtml("240, 147, 43")
        lbl.Font = New Font("Trebuchet MS", 13.5F, FontStyle.Bold)

        'Trebuchet MS, 12.75pt, Style = Bold



        Pnl.Location = New Point(12, 41)

        Pnl.Show()
        Pnl.BringToFront()
        PnlBtn.Show()


        If lbl.Name = Lbl_Scanner.Name Then


            If isScanning = True Then

                If Panel_Expand_Scanner.Size = Panel_Expand_Scanner.MaximumSize Then
                    Command.ChangeScanningPanel(Pnl_IsScanning)
                End If
            End If

        End If


        Return Nothing
    End Function

    Public Function tmrGetTimeSpan() As String
        tsElapseTime = Now.Subtract(dtStartTime)
        Label31.Text = String.Format("{0}:{1}:{2}", tsElapseTime.Hours.ToString("00"), tsElapseTime.Minutes.ToString("00"), tsElapseTime.Seconds.ToString("00"))

        Return Nothing
    End Function



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False



        Me.DataGridView1.Rows.Add(ComboBox1.Text, ComboBox3.Text, ComboBox2.Text)

        If DataGridView_index = 0 Then
            DataGridView_index = DataGridView_index
        Else
            DataGridView_index += 1
        End If

        swichPanel(Panel_Scheduler, Panel_2, Lbl_Scheduler)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex






        If colName = "Delete" Then
            DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
        ElseIf colName = "Edit" Then
            Panel_Scheduler_Edit.Show()
            swichPanel(Panel_Scheduler_Edit, Panel_2, Lbl_Scheduler)
        End If


    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick, DataGridView3.CellContentClick

        Dim colName As String = DataGridView2.Columns(e.ColumnIndex).Name
        Dim index As Integer = DataGridView2.CurrentCell.RowIndex




        If colName = "DataGridViewImageColumn3" Then
            Panel_ViewScanReport.Show()
            swichPanel(Panel_ViewScanReport, Panel_3, Lbl_Reports)
        End If


    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        Dim newDataRow As DataGridViewRow

        newDataRow = DataGridView1.Rows(index)
        newDataRow.Cells(0).Value = ComboBox6.Text
        newDataRow.Cells(1).Value = ComboBox4.Text
        newDataRow.Cells(2).Value = ComboBox5.Text


        swichPanel(Panel_Scheduler, Panel_2, Lbl_Scheduler)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        'Pnl_ScanCompleted.Hide()
        'Pnl_IsScanning.Hide()
        'Pnl_beginScan.Show()



        'swichPanel(Panel_Scanner, Panel_1, Lbl_Scanner)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)
        swichPanel(Panel_Scheduler, Panel_2, Lbl_Scheduler)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        swichPanel(Panel_Scheduler, Panel_2, Lbl_Scheduler)
    End Sub


    Private Sub Lbl_Scheduler_Click(sender As Object, e As EventArgs) Handles Lbl_Scheduler.Click
        swichPanel(Panel_Scheduler, Panel_2, Lbl_Scheduler)
    End Sub

    Private Sub Lbl_Reports_Click(sender As Object, e As EventArgs) Handles Lbl_Reports.Click
        swichPanel(Pnl_Reports, Panel_3, Lbl_Reports)
    End Sub
    Private Sub Lbl_Scanner_Click(sender As Object, e As EventArgs) Handles Lbl_Scanner.Click



        If isScanning = True Then

            If Panel_Expand_Scanner.Size = Panel_Expand_Scanner.MaximumSize Then
                Command.ChangeScanningPanel(Pnl_IsScanning)


            End If

        Else



        End If
        swichPanel(Panel_Scanner, Panel_1, Lbl_Scanner)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        swichPanel(Panel_Scanner, Panel_1, Lbl_Scanner)
    End Sub

    Sub expandPanlelConstructor(pnlName As Panel)

        For Each X As Control In pnlName.Controls
            If TypeOf X Is PictureBox Then
                X.Location = New Point(79, 16)

            End If

            If TypeOf X Is PictureBox Then
                X.Location = New Point(79, 16)

            End If





        Next
























        'For Each X As Control In pnlName.Controls
        '    If TypeOf X Is PictureBox Then
        '        X.Location = New Point(75, 16)
        '        X.Size = X.MinimumSize
        '    End If

        '    If TypeOf X Is Toggle Then


        '    End If



        'Next






        'If pnlName.Size = MaximumSize Then
        '    If pnlName.Name = Panel_history.Name Then


        '    End If



        '    If pnlName.Name = Panel_Expand_Scanner.Name Then
        '        PicBox_ScanPng.Size = PicBox_ScanPng.MaximumSize
        '    End If



        '    If pnlName.Name = Panel_Protection.Name Then


        '    End If


        'Else


        '    If pnlName.Size = MinimumSize Then

        '        If pnlName.Name = Panel_history.Name Then
        '            PictureBox4.Size = PictureBox4.MinimumSize
        '            Label56.Location = New Point(59, 92)
        '            Label57.Location = New Point(12, 155)
        '            Label58.Location = New Point(12, 175)
        '            Label64.Location = New Point(12, 198)
        '            Label59.Location = New Point(174, 153)
        '            Label60.Location = New Point(174, 175)
        '            Label65.Location = New Point(174, 196)
        '        End If

        '        If pnlName.Name = Panel_Expand_Scanner.Name Then
        '            PicBox_ScanPng.Size = PicBox_ScanPng.MaximumSize

        '        End If

        '        If pnlName.Name = Panel_Protection.Name Then


        '        End If




        '    End If



        'End If






    End Sub



    Private Sub Timer_Expand_panel_1_Tick(sender As Object, e As EventArgs) Handles Timer_Expand_History.Tick


        'First sub panel HISTORY


        If isPnlExpanded1 = False Then

            Panel_history.Hide()
            Panel_history.Width += 333
            Panel_history.Height += 333
            Panel_history.BringToFront()

            'Panel_history.BackColor = ColorTranslator.FromHtml("30, 39, 46")
            Panel_history.BorderStyle = BorderStyle.None

            If Panel_history.Size = Panel_history.MaximumSize Then
                Panel_history.Location = New Point(10, 10)
                Panel_history.Show()
                isPnlExpanded1 = True
                Timer_Expand_History.Stop()

            End If
        Else

            Panel_history.Hide()
            Panel_history.Width -= 333
            Panel_history.Height -= 333

            If Panel_history.Size = Panel_history.MinimumSize Then
                Panel_history.BorderStyle = BorderStyle.FixedSingle
                Panel_history.Location = New Point(21, 319)
                Panel_history.Show()
                isPnlExpanded1 = False


                Timer_Expand_History.Stop()
            End If

        End If

    End Sub

    Private Sub Timer_Expand_panel_2_Tick(sender As Object, e As EventArgs) Handles Timer_Expand_ScanPnl.Tick



        Panel_Expand_Scanner.Hide()



        'Scanner Second Panel Expand '
        If isPnlExpanded2 = False Then

            Panel_Expand_Scanner.Width += 333
            Panel_Expand_Scanner.Height += 333
            Panel_Expand_Scanner.BringToFront()
            Panel_Expand_Scanner.Location = New Point(10, 10)
            'Panel_Expand_Scanner.BackColor = ColorTranslator.FromHtml("30, 39, 46")
            Panel_Expand_Scanner.BorderStyle = BorderStyle.None


            If Panel_Expand_Scanner.Size = Panel_Expand_Scanner.MaximumSize Then



                If isScanning = True Then
                    Command.ChangeScanningPanel(Pnl_IsScanning)
                Else
                    Command.ChangeScanningPanel(Panel6)

                End If


                isPnlExpanded2 = True
                Panel_Expand_Scanner.Show()
                Timer_Expand_ScanPnl.Stop()

            End If
        Else

            Pnl_IsScanning.Hide()
            Pnl_ScanCompleted.Hide()

            Panel_Expand_Scanner.Width -= 333
            Panel_Expand_Scanner.Height -= 333
            Panel_Expand_Scanner.Location = New Point(236, 319)
            'Panel_Expand_Scanner.BackColor = ColorTranslator.FromHtml("44, 58, 71")
            Panel_Expand_Scanner.BorderStyle = BorderStyle.FixedSingle
            Panel6.Hide()



            If Panel_Expand_Scanner.Size = Panel_Expand_Scanner.MinimumSize Then

                isPnlExpanded2 = False
                Panel_Expand_Scanner.Show()
                Timer_Expand_ScanPnl.Stop()

            End If

        End If




    End Sub

    Private Sub Timer_Expand_panel_3_Tick(sender As Object, e As EventArgs) Handles Timer_Expand_Protection.Tick


        '3rd
        Panel_Protection.Hide()

        If isPnlExpanded3 = False Then


            Panel_Protection.Height += 333
            Panel_Protection.Width += 333

            'Panel_Protection.BackColor = ColorTranslator.FromHtml("30, 39, 46")

            Panel_Protection.Location = New Point(10, 10)
            Panel_Protection.BorderStyle = BorderStyle.None


            If Panel_Protection.Size = Panel_Protection.MaximumSize Then
                isPnlExpanded3 = True
                Panel_Protection.Show()
                Panel_Protection.BringToFront()
                Timer_Expand_Protection.Stop()

            End If
        Else

            Panel_Protection.Height -= 333
            Panel_Protection.Width -= 333

            'Panel_Protection.BackColor = ColorTranslator.FromHtml("44, 58, 71")
            Panel_Protection.Location = New Point(456, 319)
            Panel_Protection.BorderStyle = BorderStyle.FixedSingle

            If Panel_Protection.Size = Panel_Protection.MinimumSize Then
                isPnlExpanded3 = False
                Panel_Protection.Show()
                Timer_Expand_Protection.Stop()

            End If



        End If

        'expandPanlelConstructor(Panel_Protection)
    End Sub


    Private Sub Panel_history_click(sender As Object, e As EventArgs) Handles Panel_history.Click, PictureBox4.Click, Label56.Click

        Timer_Expand_History.Start()

    End Sub
    Private Sub Panel_Scanner_Button_Click(sender As Object, e As EventArgs) Handles Panel_Expand_Scanner.Click, PicBox_ScanPng.Click, Label54.Click

        Timer_Expand_ScanPnl.Start()

    End Sub

    Private Sub Panel_Protection_Click(sender As Object, e As EventArgs) Handles Panel_Protection.Click, PictureBox3.Click, Label55.Click

        Timer_Expand_Protection.Start()

    End Sub


    Private Sub Btn_OK_Click(sender As Object, e As EventArgs) Handles Btn_OK.Click

        'Dim num As Integer = 5
        'Btn_OK.Text = "Ok (" & num & ")"



        'Do Until num = 0
        '    num = -1
        '    Btn_OK.Text = "Ok (" & num & ")"
        '    Thread.Sleep(1000)
        'Loop


        Pnl_ScanCompleted.Hide()
        Command.ChangeScanningPanel(Panel6)



    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton2.Click, IconButton1.Click, IconButton3.Click
        Timer_Expand_Protection.Start()

    End Sub

    Private Sub Panel_Expand_Scanner_(sender As Object, e As EventArgs) Handles Panel_Expand_Scanner.MouseEnter, Panel_Expand_Scanner.MouseLeave, PicBox_ScanPng.MouseEnter, PicBox_ScanPng.MouseLeave, Label54.MouseEnter, Label54.MouseLeave


        If Panel_Expand_Scanner.Size = Panel_Expand_Scanner.MinimumSize Then

            If Panel_Expand_Scanner.BorderStyle = BorderStyle.Fixed3D Then

                Panel_Expand_Scanner.BorderStyle = BorderStyle.FixedSingle
            Else
                Panel_Expand_Scanner.BorderStyle = BorderStyle.Fixed3D
            End If



        Else

            Panel_Expand_Scanner.BorderStyle = BorderStyle.FixedSingle

        End If


    End Sub

    Private Sub Panel_history_(sender As Object, e As EventArgs) Handles Panel_history.MouseEnter, Panel_history.MouseLeave


        If Panel_history.Size = Panel_history.MinimumSize Then

            If Panel_history.BorderStyle = BorderStyle.Fixed3D Then

                Panel_history.BorderStyle = BorderStyle.FixedSingle
            Else
                Panel_history.BorderStyle = BorderStyle.Fixed3D
            End If



        Else

            Panel_history.BorderStyle = BorderStyle.FixedSingle

        End If


    End Sub

    Private Sub Panel_Protection_(sender As Object, e As EventArgs) Handles Panel_Protection.MouseEnter, Panel_Protection.MouseLeave



        If Panel_Protection.Size = Panel_Protection.MinimumSize Then

            If Panel_Protection.BorderStyle = BorderStyle.Fixed3D Then

                Panel_Protection.BorderStyle = BorderStyle.FixedSingle
            Else
                Panel_Protection.BorderStyle = BorderStyle.Fixed3D
            End If



        Else

            Panel_Protection.BorderStyle = BorderStyle.FixedSingle

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel_ViewScanReport.Hide()
    End Sub

    Private Sub TimerSlideShow_Tick(sender As Object, e As EventArgs)



    End Sub

    Sub SlideShow()

        Dim DummyLocation As New Point(88, 60)


        Dim Time As Integer = 0



        Do

            Time = Time + 1

            If isScanning = True Then


                PanelLastScan.Hide()
                Panel12.Hide()

                PanelProtection.Hide()

                PanelVirusScanSlideshow.Show()
                'PanelVirusScanSlideshow.BringToFront()
                PanelVirusScanSlideshow.Location = DummyLocation


            Else



                If Time = 5 Then



                    PanelLastScan.Location = DummyLocation
                    PanelLastScan.Show()

                End If




                If Time = 15 Then

                    PanelLastScan.Hide()
                    PanelProtection.Hide()


                    Panel12.Location = DummyLocation
                    Panel12.Show()

                End If



                If Time > 25 Then

                    Time = 0

                    PanelLastScan.Hide()
                    Panel12.Hide()
                    PanelVirusScanSlideshow.Hide()
                    PanelProtection.Show()
                End If

            End If





            Thread.Sleep(1000)

        Loop


    End Sub

    Private Sub Panel_Scanner_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Scanner.Paint

    End Sub
End Class



