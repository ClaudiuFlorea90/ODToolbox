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
Imports CefSharp.DevTools.Memory
Imports System.Security.Cryptography
Imports Syncfusion
Imports System.Security.Principal
Imports System.Security.Policy
Imports FontAwesome.Sharp
Imports System.Windows.Media.Animation
Imports System.Diagnostics.Eventing
Imports System.Net.Mail
Imports Microsoft.Win32.TaskScheduler

Public Class ToolBox

    Public customer_name As String
    Public customer_lastname As String
    Public customer_email As String
    Public returnID As String
    Public last_used_panel As Panel
    Public last_used_button As Button
    ' Dim installtime As Integer = 0


    Public isInstallRunning As Boolean = False
    Public isAgentInstalled As Boolean = False
    Public LastUsedDownloadLink As String



    Public agentInstalled As CompanyDetails
    Public agentToInstall As CompanyDetails
    Public companyDetailsList As New List(Of CompanyDetails)




    Public Language As String = Nothing
    Public frameWork As String = Nothing
    Public agent_Ver As String = Nothing



    Public DownloadUrl As String
    Dim InstallStatus As String
    Dim isMenu1Collapsed As Boolean = True



    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click


        Dim EventThread As New System.Threading.Thread(AddressOf ReadEventLog)

        EventThread.Start()

    End Sub

    Sub ReadEventLog()
        Label105.Visible = True
        Label105.Show()
        Button20.Enabled = False
        Me.ListView1.Items.Clear()

        Using eventLogApp As New System.Diagnostics.EventLog(ComboBox5.Text)
            Dim eventCntr As Integer = 0

            Try
                For Each eventLogEntry In eventLogApp.Entries
                    If eventLogEntry.Source = "Application Error" Then
                        Dim message As String = eventLogEntry.Message

                        ' Extract application name and version from error message
                        Dim applicationName As String = ""


                        Dim exeIndex As Integer = message.IndexOf(".exe", StringComparison.OrdinalIgnoreCase)
                        If exeIndex <> -1 Then
                            Dim startIndex As Integer = message.LastIndexOf(" ", exeIndex, exeIndex) + 1
                            applicationName = message.Substring(startIndex, exeIndex - startIndex + 4)


                        End If

                        ' Add entry to ListView
                        eventCntr += 1
                        Label105.Text = "Events found: " & eventCntr
                        Dim item As ListViewItem = ListView1.Items.Add(eventCntr)
                        item.SubItems.Add(applicationName)
                        item.SubItems.Add(eventLogEntry.EntryType.ToString)
                        item.SubItems.Add(eventLogEntry.TimeGenerated.ToString)
                        item.SubItems.Add(eventLogEntry.Message.ToString)
                        item.SubItems.Add(eventLogEntry.MachineName.ToString)
                        item.SubItems.Add(eventLogEntry.Source.ToString)
                        item.SubItems.Add(eventLogEntry.UserName.ToString)
                        item.SubItems.Add(eventLogEntry.EventID.ToString)
                    End If
                Next
            Catch ex As Exception
                ' Log any errors that may occur
                Console.WriteLine("Error reading event log: " & ex.Message)
            End Try

            Me.ListView1.Refresh()
            ListView1.ContextMenuStrip = ContextMenuStrip1
            Label22.Text = eventCntr
        End Using

        Button20.Enabled = True
    End Sub





    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

        My.Computer.Clipboard.SetText(sender.ToString)

    End Sub



    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.MouseDoubleClick

        Dim EventViewForm As New EventView
        Dim clickedRow As ListViewItem = ListView1.SelectedItems(0)

        Dim column1Data As String = clickedRow.SubItems(0).Text
        Dim column2Data As String = clickedRow.SubItems(1).Text ' index 1 corresponds to column 2
        Dim column3Data As String = clickedRow.SubItems(2).Text ' index 2 corresponds to column 3
        Dim column4Data As String = clickedRow.SubItems(3).Text ' index 3 corresponds to column 4
        Dim column5Data As String = clickedRow.SubItems(4).Text ' index 4 corresponds to column 5
        Dim column6Data As String = clickedRow.SubItems(5).Text ' index 5 corresponds to column 6
        Dim column7Data As String = clickedRow.SubItems(6).Text ' index 6 corresponds to column 7
        Dim column8Data As String = clickedRow.SubItems(7).Text ' index 7 corresponds to column 8


        EventViewForm.Label1.Text = column1Data
        EventViewForm.Lbl_ErrorType.Text = column4Data
        EventViewForm.Label_Date.Text = column3Data
        EventViewForm.Label_Title.Text = column2Data

        EventViewForm.TextBox_ErrorMsg.Text = column5Data
        EventViewForm.Label3.Text = "user: " & column7Data
        EventViewForm.Label4.Text = "event ID: " & column8Data

        ' EventViewForm.Label2.Text = column5Data


        EventViewForm.Show()




    End Sub


    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        My.Computer.Clipboard.SetText(String.Join(ControlChars.Tab, ListView1.SelectedItems(0).SubItems.Cast(Of ListViewItem.ListViewSubItem).Select(Function(x) x.Text)))
    End Sub


    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click

        ListView1.Clear()

    End Sub

    Public Structure CompanyDetails
        Public company_id As String
        Public company_name As String
        Public company_logo As Image
        Public proxy_server As String
        Public proxy_port As String
        Public agent_version As String
        Public beta_version As String
        Public ftp As String
        Public file_location As String
        Public regKey As String
        Public regKeyCheck As String
        Public agent_framework As String
        Public agent_region As String
        Public agent_shortname As String
    End Structure


    Public Shared Property location As List(Of String)



    Public Sub ChangeOverViewPnl(pnl As Panel)
        For Each item As Control In Me.Controls
            If item.GetType = GetType(Panel) Then
                item.Hide()
            End If

        Next
        pnl.Location = New Point(0, 0)
        pnl.Size = Frame.PnlMain.Size
        pnl.Show()
        pnl.BringToFront()
    End Sub

    Sub LoadMiniDetaills()

        Dim agent As StructuresModule.AgentData

        On Error Resume Next
        Dim N As RegistryKey
        Dim FILE_NAME As String = System.IO.Path.GetTempPath & "\ODRegDecrypted.txt"
        Dim ZX As String = Reg("SOFTWARE\Class IT") & vbNewLine
        ZX = ZX & Reg("SOFTWARE\OptimumDesk") & vbNewLine
        ZX = ZX & Reg("SOFTWARE\Easee Control") & vbNewLine
        ZX = ZX & Reg("SOFTWARE\PCMATIC") & vbNewLine
        Using objWriter As New System.IO.StreamWriter(FILE_NAME)
            objWriter.Write(ZX)
        End Using

        Dim filePath As String = FILE_NAME
        Dim searchTexts As String() = {"ClientID : ", "GUID : ", "deviceId : ", "Version : ", "API_Server : ", "Download_Server : ", "Socket_Server : ", "Socket_Server_Port : "}

        Dim fileLines As String() = File.ReadAllLines(filePath)
        For Each line As String In fileLines
            For Each searchText As String In searchTexts
                If line.Contains(searchText) Then
                    Dim value As String = line.Replace(searchText, String.Empty)
                    Select Case searchText
                        Case "ClientID : "
                            agent.companyId = value
                        Case "GUID : "
                            agent.GUID = value
                        Case "deviceId : "
                            agent.deviceId = value
                        Case "Version : "
                            agent.agentVersion = value
                        Case "API_Server : "
                            agent.API_Server = value
                        Case "Download_Server : "
                            agent.DeliveryServer = value
                        Case "Socket_Server : "
                            agent.Socket_Server = value
                        Case "Socket_Server_Port : "
                            agent.Socket_Server_Port = value
                    End Select
                    Exit For
                End If
            Next
        Next

        TextBox14.Text = agent.GUID
        TextBox16.Text = agent.deviceId
        TextBox15.Text = agent.agentVersion
        TextBox7.Text = agent.DeliveryServer
        TextBox9.Text = agent.Socket_Server
        TextBox10.Text = agent.Socket_Server_Port
        TextBox13.Text = agent.companyId
    End Sub


    Sub SelectRegion(lang As String)

        Language = lang

        If lang = "US" Then
            ComboBoxCompany.Items.Clear()
            ComboBoxCompany.Text = "TechServices"
            selectAgent("TechServices")
            For Each item As String In Module1.companiesUS
                ComboBoxCompany.Items.Add(item)
            Next
        End If

        If lang = "EU" Then
            ComboBoxCompany.Items.Clear()
            ComboBoxCompany.Text = "Class It Outsourcing"
            selectAgent("Class It Outsourcing")
            For Each item As String In Module1.companiesRO
                ComboBoxCompany.Items.Add(item)
            Next
        End If
    End Sub




    Private Sub ToolBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'For Each ctrl As Control In Me.Controls
        '    If TypeOf ctrl Is Button Then
        '        RoundedCorner(ctrl, 55)
        '    End If
        'Next






        RoundedCorner(Button5, 5)
        RoundedCorner(Button6, 5)
        RoundedCorner(Button8, 5)
        RoundedCorner(Button13, 5)



        RoundedCorner(TextBox4, 5)
        RoundedCorner(TextBox5, 5)
        RoundedCorner(TextBox6, 5)
        RoundedCorner(Btn_StartInstall, 5)
        RoundedCorner(Button20, 5)
        RoundedCorner(Button3, 5)
        RoundedCorner(Button4, 5)
        RoundedCorner(Button22, 5)
        'RoundedCorner(TextBox13, 5)


        RoundedCorner(PanelMultiAgent, 15)

        SelectRegion("US")


        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False

        'Dim EventThread As New System.Threading.Thread(AddressOf ReadEventLog)
        'EventThread.Start()
        'Toggle1.Checked = False

        LoadMiniDetaills()
        getCustomerInfo()



        Panel2.Size = Panel2.MaximumSize
        PanelMultiAgent.Size = PanelMultiAgent.MinimumSize

        'Label105.Hide()
        Me.Show()

    End Sub


    Public Function getCustomerInfo() As Boolean

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
                'Top
                tbEmail.Text = dic.email
                tbName.Text = dic.firstname & " " & dic.lastname
                'Home Left side
                TextBox25.Text = dic.firstname
                TextBox26.Text = dic.lastname
                TextBox27.Text = dic.email
                'Advanced settings
                TextBox4.Text = dic.firstname
                TextBox5.Text = dic.lastname
                TextBox6.Text = dic.email
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            ' MsgBox(ex.Message & ".")
        End Try


    End Function


    Public Sub InsertCustomerInfo(ID As String, email As String, firstName As String, lastname As String, password As String)

        Dim info As New StructuresModule.SignUpRegistrationData()
        Dim json As New JavaScriptSerializer
        json.MaxJsonLength = 2147483644

        info.companyId = ID
        info.email = email
        info.firstname = firstName
        info.lastname = lastname
        info.password = password


        Dim serializedInfo As String = Encrypt(json.Serialize(info))

        Dim key_OD As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("Software\OptimumDesk\Account")
        key_OD.SetValue("NCne5NUp41ltZ+S8rPJxIg==", serializedInfo, Microsoft.Win32.RegistryValueKind.String)
        key_OD.Close()



        '' Open the registry key for writing
        'Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("Software\Test")
        'key.SetValue("Test2", serializedInfo, Microsoft.Win32.RegistryValueKind.String)

        '' Close the key
        'key.Close()



        'PowerShell("reg add HKLM\Software\Test /v Test2 /t reg_sz /d" & serializedInfo & " /f")

    End Sub


    Sub SetBannerPanel(pnl As Panel, btn As Button)
        ''sub to set pnls for toolbox menu

        'Hide multipanel
        If PanelMultiAgent.Size = PanelMultiAgent.MaximumSize Then
            Timer_MultiAgentDropDown.Start()
        End If



        If PanelMultiAgent IsNot Nothing Then
            For Each button As Button In PanelMultiAgent.Controls.OfType(Of Button)()
                RoundedCorner(button, 10)
                button.ForeColor = SystemColors.AppWorkspace
                button.ImageList = ImageList_LineForBtn
                button.ImageIndex = -1
                ' button.Font = SystemFonts.DefaultFont
            Next
        End If


        ' btn.BackColor = ColorTranslator.FromHtml("44, 58, 71")
        ' btn.Font = New System.Drawing.Font("Microsoft PhagsPa", 9, FontStyle.Bold)
        btn.ForeColor = Color.YellowGreen
        btn.ImageIndex = 1

        pnl.Size = pnl.MaximumSize
        pnl.Location = New Point(0, 70)
        pnl.Show()
        pnl.BringToFront()

        last_used_button = btn
        last_used_panel = pnl

    End Sub

    Public Function CheckIfDataExists(Key1 As String, keyName As String) As Boolean


        Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(Key1)
        If key IsNot Nothing AndAlso key.GetValue(keyName) IsNot Nothing Then
            Return True
        Else
            Return False

        End If




    End Function


    Function CreateDownloadLink(ID As String) As String



        Dim downloadUrl As String = ""
        Dim digit As Integer = Nothing

        If Language = "US" Then
            digit = 1
        ElseIf Language = "EU" Then
            digit = 2
        End If


        If frameWork = "EaseeControl" Then

            agent_Ver = "9.1.0.0"

            If digit = 1 Then
                'EC US
                downloadUrl = "https://updateor.optimumdesk.com/compiledEC/" & "/" & agentToInstall.agent_shortname & "/setup.exe"
            Else
                'EC EU
                downloadUrl = "https://updateor.optimumdesk.com/compiledEC/" & digit & "/" & ID & "/setup.exe"
            End If

        Else

            agent_Ver = "8.9.50.1020"

            If digit = 1 Then
                'OD US
                downloadUrl = "https://updateor.optimumdesk.com/download/884c3b4485160e19f93ffe73cf719fa6b081b7a7/company/" & ID & "/setup.exe"
            Else
                'OD EU
                downloadUrl = "https://updateor.optimumdesk.com/download/b17b36236610ef36f29efe86a39fdc5d46a436fa/company/" & ID & "/setup.exe"
            End If
        End If

        Return downloadUrl
    End Function


    Private Sub Btn_StartInstall_Click(sender As Object, e As EventArgs) Handles Btn_StartInstall.Click
        Try
            If isInstallRunning = False Then
                Dim client As New WebClient
                isInstallRunning = True
                Command.SetMainPanel(PanelLoading)
                CircularProgressBar2.Show()
                CircularProgressBar2.Value = 0
                CircularProgressBar2.Text = "0%"
                PictureBox22.Hide()


                selectAgent(ComboBoxCompany.Text)





                If System.IO.File.Exists(My.Application.Info.DirectoryPath + "\Setup.exe") = True Then
                    My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath + "\Setup.exe")
                End If




                client.DownloadFileAsync(New System.Uri(agentToInstall.ftp), My.Application.Info.DirectoryPath + "\setup.exe")







                AddHandler client.DownloadProgressChanged, AddressOf DownloadProgressChanged
                AddHandler client.DownloadFileCompleted, AddressOf DownloadFileCompleted

                ' client.DownloadFileAsync(New System.Uri(CreateDownloadLink(agentToInstall.company_id)), My.Application.Info.DirectoryPath + "\setup.exe")



                TextBoxCName.Text = ComboBoxCompany.Text


            Else
                Command.SetMainPanel(PanelLoading)

            End If

        Catch ex As Exception
            Frame.logger(ex.Message + agentToInstall.company_name, "Error")
        End Try


    End Sub

    Public Sub DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs)

        Try
            Dim bytes1 As Long = e.BytesReceived
            Dim bytes2 As Long = e.TotalBytesToReceive
            Dim megabytes1 As Double = Math.Round(bytes1 / (1024 * 1024))
            Dim megabytes2 As Double = Math.Round(bytes2 / (1024 * 1024))


            CircularProgressBar2.Value = e.ProgressPercentage
            CircularProgressBar2.Text = e.ProgressPercentage & "%"
            TextBox_InstallStep.Text = "Downloading resource " & megabytes1 & "/" & megabytes2 & " mb"
        Catch ex As Exception
            Frame.logger(ex.Message + "Install", "Error")
        End Try
    End Sub



    Public Sub DownloadFileCompleted(sender As Object, e As AsyncCompletedEventArgs)


        'PictureBox1.Image = agentInstalled.company_logo
        'tbCName.Text = agentInstalled.company_name & agentInstalled.company_id



        Dim test As New System.Threading.Thread(AddressOf TEST_TEST)
        test.Start()

    End Sub


    Sub TEST_TEST()

        CircularProgressBar2.Hide()
        PictureBox22.Location = CircularProgressBar2.Location
        PictureBox22.Show()
        TextBox_InstallStep.Text = "Installing setup"



        If Toggle1.Checked = True Then
            InsertCustomerInfo(agentToInstall.company_id, TextBox6.Text, TextBox4.Text, TextBox5.Text, Nothing)
        End If


        Dim process As New Process()
        process.StartInfo.FileName = My.Application.Info.DirectoryPath & "\Setup.exe"
        process.StartInfo.Arguments = "/S /verysilent /suppressmsgboxes"
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.UseShellExecute = False
        process.StartInfo.CreateNoWindow = False
        process.Start()
        Dim output As String = process.StandardOutput.ReadToEnd()




        Do Until process.HasExited = True
            'getID()
            Thread.Sleep(1000)
        Loop



        Do Until getCustomerInfo()
            Thread.Sleep(1000)
        Loop






        Command.SetMainPanel(PanelMainBox)
        LoadMiniDetaills()
        getCustomerInfo()



        SetBannerPanel(Panel_INFO, IconButton1)
        Me.Refresh()
        Me.getID()


        isInstallRunning = False
        isAgentInstalled = True
    End Sub


    Private Sub Label42342_Click(sender As Object, e As EventArgs)

        If isAgentInstalled = True Then

            ChangeOverViewPnl(PanelMainBox)

        Else


            ChangeOverViewPnl(PanelInstallNewAgent)


        End If

    End Sub

    Private Sub Lbl_432_Click(sender As Object, e As EventArgs)
        ChangeOverViewPnl(PanelDecryptor)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked Then

            CheckBox1.Text = "Beta"
            TextBox_Server.Text = "BETA"
        Else
            TextBox_Server.Text = "LIVE"
            CheckBox1.Text = "Live"
        End If


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_FrameWork.SelectedIndexChanged

        TextBox_AgentFrameWork.Text = ComboBox_FrameWork.Text
        frameWork = ComboBox_FrameWork.Text
        selectAgent(ComboBoxCompany.Text)


    End Sub

    Private Sub ComboBoxAgentVersion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCompany.SelectedIndexChanged

        selectAgent(ComboBoxCompany.Text)
    End Sub

    'Private Sub ComboBox1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles ComboBoxCompany.DrawItem

    '    ComboBoxCompany.DrawMode = DrawMode.OwnerDrawFixed

    '    e.DrawBackground()
    '    e.Graphics.DrawString(ComboBoxCompany.Items(e.Index).ToString(), Me.Font, Brushes.Black, e.Bounds.X, e.Bounds.Y)
    'End Sub






    Private Sub ComboBoxAgentVersion_Click(sender As Object, e As EventArgs) Handles ComboBoxCompany.Click

        ComboBoxCompany.DroppedDown = True

    End Sub

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox_FrameWork.Click

        ComboBox_FrameWork.DroppedDown = True

    End Sub



    Function Reg(ByVal Path As String) As String
        Dim ZX As String = "HKLM\" & Path & vbNewLine
        Try
            Dim rk As RegistryKey = Registry.LocalMachine.CreateSubKey(Path)
            For Each skName As String In rk.GetValueNames
                ZX = ZX & Decrypt(skName) & " : "
                ZX = ZX & Decrypt(Registry.LocalMachine.CreateSubKey(Path).GetValue(skName)) & vbNewLine
            Next
            Try
                If rk.SubKeyCount > 0 Then
                    Try
                        For Each subKeyName As String In rk.GetSubKeyNames()
                            Dim Thispath As String = Path + "\" + subKeyName
                            ZX = ZX & vbNewLine & Reg(Thispath)
                        Next
                    Catch
                    End Try
                End If
            Catch
            End Try
        Catch ex As Exception
        End Try
        Return ZX
    End Function

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click



        'OpenFileDialog1.Filter = "OD db files|*.db"
        'OpenFileDialog1.ShowDialog()
        'If File.Exists(OpenFileDialog1.FileName) Then
        '    Try
        '        Dim x As String = OpenFileDialog1.FileName
        '        Dim t As String = System.IO.File.ReadAllText(x)
        '        Dim FILE_NAME As String = x & "-decrypted"
        '        Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
        '        objWriter.Write(Decrypt(t))
        '        objWriter.Close()
        '        System.Diagnostics.Process.Start("notepad.exe", FILE_NAME)
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try
        'End If
    End Sub


    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        SetBannerPanel(Panel_INFO, IconButton1)
    End Sub


    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        SetBannerPanel(PnlLogs, IconButton4)
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click

        SetBannerPanel(PanelInstallNewAgent, IconButton5)

    End Sub


    Private Sub btn_ReadOdLog_Click(sender As Object, e As EventArgs) Handles btn_ReadOdLog.Click

        btn_ReadOdLog.Enabled = False
        RichTextBox2.Clear()

        Dim filePath As String = "C:\Program Files (x86)\OptimumDesk\OptimumDesk.log"

        ' Check if the file exists
        If My.Computer.FileSystem.FileExists(filePath) Then

            PowerShellCmd("taskkill /f /im OptimumDesk.exe; taskkill /f /im ODService.exe")

            Dim fileReader As System.IO.StreamReader
            fileReader = My.Computer.FileSystem.OpenTextFileReader(filePath)
            Dim stringReader As String
            stringReader = Decrypt(fileReader.ReadToEnd())
            RichTextBox2.Text = stringReader
        End If





        btn_ReadOdLog.Enabled = True

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Button17.Enabled = False
        RichTextBox2.Clear()

        Dim filePath As String = "C:\Program Files (x86)\OptimumDesk\ODService.log"
        ' Check if the file exists
        If My.Computer.FileSystem.FileExists(filePath) Then

            PowerShellCmd("taskkill /f /im OptimumDesk.exe; taskkill /f /im ODService.exe")

            Dim fileReader As System.IO.StreamReader
            fileReader = My.Computer.FileSystem.OpenTextFileReader(filePath)
            Dim stringReader As String


            stringReader = fileReader.ReadToEnd()
            RichTextBox2.Text = stringReader
        End If
        Button17.Enabled = True

    End Sub




    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click




        RichTextBox_Output.Clear()



        If RichTextBox_Input.Text IsNot "Your text here" Then
            If RichTextBox_Input.Text IsNot "" Then
                RichTextBox_Output.Text = WebCrypt(RichTextBox_Input.Text.Trim)
            End If
        End If


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        RichTextBox_Output.Clear()
        RichTextBox_Output.Text = WebUnCrypt(RichTextBox_Input.Text.Trim)


    End Sub


    Function WebCrypt(text) As String
        Select Case ComboBox4.SelectedIndex
            Case 0
                Return WEBC(text)
            Case 1
                Return WEBEncrypt(text)
            Case Else
                Return Encrypt(text)
        End Select

    End Function


    Function WebUnCrypt(text) As String
        Select Case ComboBox4.SelectedIndex
            Case 0
                Return WEBD(text)
            Case 1
                Return WEBDecrypt(text)
            Case Else
                Return Decrypt(text)
        End Select

    End Function

    Public Function getTextLength(Optional n As String = "")
        On Error Resume Next
        Dim length As Integer
        If n = "" Then
            length = Int(Rnd() * 13) + 12
        Else
            length = Val(n)
        End If
        Dim validchars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890+=" '!@#$%^&*()_-,./?;:<>{}[]|\+='~`"
        Dim sb As New StringBuilder()
        For i As Integer = 1 To length
            Dim idx As Integer = Int(Rnd() * validchars.Length)
            Dim rChar As Char = validchars(idx)
            sb.Append(rChar)
        Next i
        Return sb.ToString()
    End Function
    Public Function WEBC(ByVal value As String) As String
        Try
            Dim valueP As String = getTextLength()
            Dim valueS As String = getTextLength("16")
            Return Chr(65 + valueP.Length) & valueP & valueS & WEBC2(StrReverse(WEBC1(value) & getTextLength("8")), WEBC1(valueP), valueS)
        Catch
        End Try
        Return value
    End Function
    Public Function WEBD(ByVal value As String) As String
        Try
            Dim pL As Integer = Asc(value.Substring(0, 1)) - 65
            Dim sL As Integer = 16
            Return WEBD1(StrReverse(WEBD2(value.Substring(pL + sL + 1), WEBC1(value.Substring(1, pL)), value.Substring(pL + 1, sL)).Substring(8)))
        Catch
        End Try
        Return value
    End Function



    Public Function WEBC1(ByVal value As String) As String
        Return PEA(value, "54EDA16A7E700C51A98BE8F4C128646A", "7E226F48F6D37F74")
    End Function

    Public Function WEBD1(ByVal value As String) As String
        Return PDA("54EDA16A7E700C51A98BE8F4C128646A", "7E226F48F6D37F74", value)
    End Function
    Public Function WEBC2(ByVal value As String, ByVal valueP As String, ByVal valueS As String) As String
        Return PEA(value, valueP, valueS)
    End Function

    Public Function WEBD2(ByVal value As String, ByVal valueP As String, ByVal valueS As String) As String
        Return PDA(valueP, valueS, value)
    End Function

    Private Function PDA(ByVal pp As String, ByVal pi As String, ByVal value_data As String) As String
        Dim key As Byte() = valuePE(pp, 32)
        Dim iv As Byte() = valuePE(pi, 16)
        Dim buff As Byte() = Encoding.ASCII.GetBytes(value_data)

        Using aes As Aes = Aes.Create()
            Using decryptor As ICryptoTransform = aes.CreateDecryptor(key, iv)
                buff = Convert.FromBase64String(value_data)
                Return ASCIIEncoding.ASCII.GetString(decryptor.TransformFinalBlock(buff, 0, buff.Length))
            End Using
        End Using
        Return value_data
    End Function
    Private Function valuePE(ByVal value As String, ByVal expectedLength As Integer) As Byte()
        Dim temp As Byte() = Encoding.ASCII.GetBytes(value)

        If temp.Length = expectedLength Then
            Return temp
        End If

        Dim ret As Byte() = New Byte(expectedLength - 1) {}
        Buffer.BlockCopy(temp, 0, ret, 0, Math.Min(temp.Length, expectedLength))
        Return ret
    End Function

    Private Function PEA(ByVal value_data As String, ByVal pp As String, ByVal pi As String) As String
        Try
            Dim key As Byte() = valuePE(pp, 32)
            Dim iv As Byte() = valuePE(pi, 16)
            Dim data As Byte() = Encoding.ASCII.GetBytes(value_data)

            Using aes As Aes = Aes.Create()

                Using encryptor As ICryptoTransform = aes.CreateEncryptor(key, iv)
                    Return Convert.ToBase64String(encryptor.TransformFinalBlock(data, 0, data.Length))
                End Using
            End Using
        Catch
        End Try
        Return value_data
    End Function



    Private Sub RichTextBox1_TextClick(sender As Object, e As EventArgs) Handles RichTextBox_Input.Click

        RichTextBox_Input.Clear()

    End Sub

    Private Sub Panel_ED_Paint(sender As Object, e As PaintEventArgs) Handles PanelDecryptor.Paint

    End Sub

    Private Sub TextBox4_TextClick(sender As Object, e As EventArgs) Handles TextBox4.Click, TextBox25.Click

        TextBox4.Select(0, TextBox4.TextLength)

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.Click, TextBox26.Click


        TextBox5.Select(0, TextBox5.TextLength)


    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.Click, TextBox27.Click

        TextBox6.Select(0, TextBox6.TextLength)


    End Sub

    Private Sub TextBox4_Leave(sender As Object, e As EventArgs) Handles TextBox4.MouseLeave, TextBox25.MouseLeave
        'If TextBox4.Text = "" Then
        '    TextBox4.Text = "First name"
        'End If
    End Sub

    Private Sub TextBox5_Leave(sender As Object, e As EventArgs) Handles TextBox5.MouseLeave, TextBox26.MouseLeave
        'If TextBox5.Text = "" Then
        '    TextBox5.Text = "Last name"
        'End If
    End Sub

    Private Sub TextBox6_Leave(sender As Object, e As EventArgs) Handles TextBox6.MouseLeave, TextBox27.MouseLeave
        'If TextBox6.Text = "" Then
        '    TextBox6.Text = "Email address"
        'End If
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
        If CheckBox4.Checked = True Then
            Try
                PowerShellCmd("reg delete 'HKLM\SOFTWARE\Class IT' /f")
                PowerShellCmd("reg delete 'HKLM\SOFTWARE\Easee Control' /f")
                PowerShellCmd("reg delete 'HKLM\SOFTWARE\PCMATIC' /f")
                PowerShellCmd("reg delete 'HKLM\SOFTWARE\TechServices' /f")

                PowerShellCmd("schtasks /delete /tn 'EASetup' /f")
                PowerShellCmd("schtasks /delete /tn 'ECUnis' /f")
                PowerShellCmd("schtasks /delete /tn 'PC Matic' /f")
                PowerShellCmd("schtasks /delete /tn 'True Solutions' /f")
            Catch ex As Exception

            End Try
        End If


    End Sub


    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Button11.Enabled = False

        Dim unins As New System.Threading.Thread(AddressOf Uninstall)
        unins.Start()




        Frame.agentCount = 0
        isAgentInstalled = False
        Button11.Enabled = True


        PictureBox8.Image = agentToInstall.company_logo
        TextBox3.Text = agentToInstall.company_name
        TextBox31.Text = agentToInstall.company_id
        TextBox_AgentFrameWork.Text = ComboBox_FrameWork.Text
        Command.SetMainPanel(PanelInstallNewAgent)

    End Sub


    Private Sub SetRoundedRegion(ByVal control As Control, ByVal radius As Integer, ByVal borderColor As Color)
        ' Create a GraphicsPath object to define the rounded rectangle shape
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

        ' Create a Region object from the GraphicsPath and set it as the control's region
        control.Region = New Region(path)

        ' Draw a 1-pixel border around the control using the specified color
        Using pen As New Pen(borderColor, 1)
            Dim g As Graphics = control.CreateGraphics()
            g.DrawPath(pen, path)
        End Using
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


    Private Sub Button21_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TimerTopBannerInfoCheck_Tick(sender As Object, e As EventArgs)
        '  tbCName.Text = getByID().company_name
        '   PictureBox1.Image = getByID().company_logo
        getCustomerInfo()
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TimerAdvancedSettings.Tick

        If Panel2.Size = Panel2.MinimumSize Then

            Panel2.Size = Panel2.MaximumSize
            TextBox35.Text = "Hide advanced settings"
            '  Panel2.BorderStyle = BorderStyle.FixedSingle
            ' Panel2.BackColor = Color.FromArgb(44, 58, 71)
            TimerAdvancedSettings.Stop()

        Else
            Panel2.Size = Panel2.MinimumSize
            TextBox35.Text = "View advanced settings"
            ' Panel2.BorderStyle = BorderStyle.None
            'Panel2.BackColor = Color.FromArgb(44, 58, 71)
            TimerAdvancedSettings.Stop()
        End If

    End Sub

    Private Sub TextBox35_Hover(sender As Object, e As EventArgs) Handles TextBox35.MouseHover

        'TextBox35.Font = New Font(" Microsoft PhagsPa", 9, FontStyle.Bold)
        TextBox35.ForeColor = Color.LightSalmon


    End Sub
    Private Sub TextBox35_Hover2(sender As Object, e As EventArgs) Handles TextBox35.MouseLeave

        ' TextBox35.Font = New Font(" Microsoft PhagsPa", 9, FontStyle.Regular)
        TextBox35.ForeColor = Color.FromArgb(165, 177, 194)

    End Sub

    Private Sub TextBox35_Click(sender As Object, e As EventArgs) Handles TextBox35.Click
        TimerAdvancedSettings.Start()
    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click

        TimerAdvancedSettings.Start()

    End Sub

    Private Sub Toggle1_Load(sender As Object, e As EventArgs) Handles Toggle1.Click

        If Toggle1.Checked = True Then

            TextBox4.Enabled = False
            TextBox5.Enabled = False
            TextBox6.Enabled = False
        Else
            CheckBox3.Checked = False
            TextBox4.Enabled = True
            TextBox5.Enabled = True
            TextBox6.Enabled = True
        End If




    End Sub

    Private Sub PictureBox3_Hover(sender As Object, e As EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.Size = PictureBox3.MaximumSize


    End Sub


    Private Sub PictureBox3_Leave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Size = PictureBox3.MinimumSize


    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click


        Dim Input As String = RichTextBox_Input.Text
        Dim Output As String = RichTextBox_Output.Text

        RichTextBox_Output.Clear()
        RichTextBox_Input.Clear()


        RichTextBox_Output.Text = Input
        RichTextBox_Input.Text = Output

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.Click
        ComboBox4.DroppedDown = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Frame.SetTopMenu(Frame.PnlSmallToolbox, Frame.Button3)
        ChangeOverViewPnl(PanelEventViewer)
    End Sub

    Private Sub ComboBox5_Click(sender As Object, e As EventArgs) Handles ComboBox5.Click
        ComboBox5.DroppedDown = True
    End Sub

    'Private Sub SetupComboBox(ByVal comboBox As ComboBox, param1 As Boolean, param2 As Boolean)

    '    Dim items As New Dictionary(Of String, Boolean)
    '    items.Add("EaseeControl", param1)
    '    items.Add("OptimumDesk", param2)
    '    comboBox.DataSource = New BindingSource(items, Nothing)
    '    comboBox.DisplayMember = "Key"
    '    comboBox.ValueMember = "Value"
    'End Sub




    Public Function selectAgent(valueName As String) As CompanyDetails


        If valueName = "GoAgilant" Then
            agentToInstall.company_id = GoAgilantID
            agentToInstall.company_name = valueName
            agentToInstall.company_logo = My.Resources.agilant_logo
            agentToInstall.ftp = "https://updateor.optimumdesk.com/download/884c3b4485160e19f93ffe73cf719fa6b081b7a7/company/23570/setup.exe"
        End If


        If valueName = "Company.com" Then
            agentToInstall.company_id = CompanyCom
            agentToInstall.company_name = valueName
            agentToInstall.company_logo = My.Resources.companyCom2
            agentToInstall.ftp = "https://updateor.optimumdesk.com/download/884c3b4485160e19f93ffe73cf719fa6b081b7a7/company/20686/setup.exe"
        End If


        If valueName = "EaseeAccess" Then
            agentToInstall.company_id = EaseeAccess
            agentToInstall.company_name = valueName
            agentToInstall.company_logo = My.Resources.optimumdesk_logo
            agentToInstall.ftp = "https://updateor.optimumdesk.com/download/884c3b4485160e19f93ffe73cf719fa6b081b7a7/company/23571/setup.exe"
        End If



        If valueName = "EaseeControl" Then
            agentToInstall.company_id = EaseeControlID
            agentToInstall.company_name = valueName
            agentToInstall.company_logo = My.Resources.EaseeControlLogo
            'agentToInstall.agent_shortname = "Nu stiu"
            agentToInstall.ftp = CreateDownloadLink(Module1.EaseeControlID)
        End If


        If valueName = "True Solutions" Then
            agentToInstall.company_id = TrueID
            agentToInstall.company_name = "True Solution"
            agentToInstall.company_logo = My.Resources.TrueLogoWhite2
            agentToInstall.ftp = "https://update.optimumdesk.com/public/compiledEC/true/setup.exe"
            'agentToInstall.beta_version
            'agentToInstall.agent_framework
            'agentToInstall.file_location
            agentToInstall.agent_shortname = "true"
            agentToInstall.agent_version = agent_Ver
        End If

        If valueName = "PcMatic" Then
            agentToInstall.company_id = PCMaticID
            agentToInstall.company_name = "PC Matic"
            agentToInstall.company_logo = My.Resources.SupportUnlimited_logo
            agentToInstall.ftp = "https://updateor.optimumdesk.com/download/884c3b4485160e19f93ffe73cf719fa6b081b7a7/company/23861/setup.exe"
        End If



        If valueName = "TechServices" Then
            agentToInstall.company_id = TechID
            agentToInstall.company_name = valueName
            agentToInstall.company_logo = My.Resources.logoTech
            agentToInstall.ftp = CreateDownloadLink(agentToInstall.company_id)
            agentToInstall.agent_shortname = "tech"
            agentToInstall.agent_version = agent_Ver
        End If

        If valueName = "Your Help Desk HQ" Then
            agentToInstall.company_id = DnHID
            agentToInstall.company_name = valueName
            agentToInstall.company_logo = My.Resources.TrueLogoWhite2
            agentToInstall.ftp = "https://updateor.optimumdesk.com/download/884c3b4485160e19f93ffe73cf719fa6b081b7a7/company/24159/setup.exe"

        End If


        If valueName = "NewEgg" Then
            agentToInstall.company_id = NewEGGID
            agentToInstall.company_name = valueName
            agentToInstall.company_logo = My.Resources.logo_trust
            agentToInstall.ftp = "https://updateor.optimumdesk.com/download/884c3b4485160e19f93ffe73cf719fa6b081b7a7/company/23862/setup.exe"
        End If

        If valueName = "Office Depot SMB" Then
            agentToInstall.company_id = Office_Depot_SMB
            agentToInstall.company_name = valueName
            agentToInstall.company_logo = My.Resources.logoTech
            agentToInstall.ftp = "https://updateor.optimumdesk.com/download/884c3b4485160e19f93ffe73cf719fa6b081b7a7/company/23515/setup.exe"
        End If

        If valueName = "OptimumDesk" Then
            agentToInstall.company_id = OptimumDeskID
            agentToInstall.company_name = valueName
            agentToInstall.company_logo = My.Resources.optimumdesk_logo
            agentToInstall.ftp = "https://updateor.optimumdesk.com/download/884c3b4485160e19f93ffe73cf719fa6b081b7a7/company/23569/setup.exe"
        End If

        If valueName = "Plus" Then
            agentToInstall.company_id = PlusID
            agentToInstall.company_name = "Plus"
            agentToInstall.company_logo = My.Resources.puls_logo
            agentToInstall.ftp = "https://updateor.optimumdesk.com/download/884c3b4485160e19f93ffe73cf719fa6b081b7a7/company/23526/setup.exe"
        End If

        If valueName = "Startech365" Then
            agentToInstall.company_id = Startech365
            agentToInstall.company_name = "Startech365"
            agentToInstall.company_logo = My.Resources.startech365
            agentToInstall.ftp = "https://updateor.optimumdesk.com/download/884c3b4485160e19f93ffe73cf719fa6b081b7a7/company/23589/setup.exe"
        End If

        If valueName = "Synnex" Then
            agentToInstall.company_id = Synnex
            agentToInstall.company_name = "Synnex"
            agentToInstall.company_logo = My.Resources.SynnexLogo
            agentToInstall.ftp = "https://updateor.optimumdesk.com/download/884c3b4485160e19f93ffe73cf719fa6b081b7a7/company/23863/setup.exe"
            '  SetupComboBox(ComboBox_FrameWork, True, True)
        End If

        If valueName = "Staples" Then
            agentToInstall.company_id = StaplesID
            agentToInstall.company_name = valueName
            agentToInstall.company_logo = My.Resources.stapleslogo
            agentToInstall.ftp = "https://updateor.optimumdesk.com/download/884c3b4485160e19f93ffe73cf719fa6b081b7a7/company/23588/setup.exe"
        End If


        If valueName = "Staples Retail" Then
            agentToInstall.company_id = StaplesRetailID
            agentToInstall.company_name = valueName
            agentToInstall.company_logo = My.Resources.stapleslogo
            '   agentToInstall.ftp = "https://updateor.optimumdesk.com/download/884c3b4485160e19f93ffe73cf719fa6b081b7a7/company/24162/setup.exe"
            agentToInstall.ftp = CreateDownloadLink(Module1.StaplesRetailID)
        End If


        If valueName = "Walmart.com" Then
            agentToInstall.company_id = WalmartComID
            agentToInstall.company_name = valueName
            agentToInstall.company_logo = My.Resources.walmartLogo
            agentToInstall.ftp = "https://updateor.optimumdesk.com/download/884c3b4485160e19f93ffe73cf719fa6b081b7a7/company/" & agentToInstall.company_id & "/setup.exe"
        End If

        If valueName = "Walmart Online" Then
            agentToInstall.company_id = WalmartOnlineID
            agentToInstall.company_name = valueName
            agentToInstall.company_logo = My.Resources.Walmert2Logo
            agentToInstall.ftp = "https://updateor.optimumdesk.com/download/884c3b4485160e19f93ffe73cf719fa6b081b7a7/company/" & agentToInstall.company_id & "/setup.exe"

        End If


        'RO......................................................

        If valueName = "Class It Outsourcing" Then
            agentToInstall.company_id = ClassITID
            agentToInstall.company_name = valueName
            agentToInstall.company_logo = My.Resources.optimumdesk_logo
            agentToInstall.ftp = CreateDownloadLink(agentToInstall.company_id)
            agentToInstall.agent_version = agent_Ver
        End If

        If valueName = "Class IT Home" Then
            agentToInstall.company_id = Module1.Class_IT_Home
            agentToInstall.company_name = valueName
            agentToInstall.company_logo = My.Resources.optimumdesk_logo
            agentToInstall.ftp = CreateDownloadLink(agentToInstall.company_id)
            agentToInstall.agent_version = agent_Ver
        End If

        If valueName = "April Romania" Then
            agentToInstall.company_id = Module1.April_Romania
            agentToInstall.company_name = valueName
            agentToInstall.company_logo = My.Resources.optimumdesk_logo
            agentToInstall.ftp = CreateDownloadLink(agentToInstall.company_id)
            agentToInstall.agent_version = agent_Ver
        End If

        If valueName = "Archivit" Then
            agentToInstall.company_id = Module1.Archivit
            agentToInstall.company_name = valueName
            agentToInstall.company_logo = My.Resources.optimumdesk_logo
            agentToInstall.ftp = CreateDownloadLink(agentToInstall.company_id)
            agentToInstall.agent_version = agent_Ver
        End If

        If valueName = "Aectra" Then
            agentToInstall.company_id = Module1.Aectra
            agentToInstall.company_name = valueName
            agentToInstall.company_logo = My.Resources.optimumdesk_logo
            agentToInstall.ftp = CreateDownloadLink(agentToInstall.company_id)
            agentToInstall.agent_version = agent_Ver
        End If

        If valueName = "Aerodynamics" Then
            agentToInstall.company_id = Module1.Aerodynamics
            agentToInstall.company_name = valueName
            agentToInstall.company_logo = My.Resources.optimumdesk_logo
            agentToInstall.ftp = CreateDownloadLink(agentToInstall.company_id)
            agentToInstall.agent_version = agent_Ver
        End If

        If valueName = "Agroconcept" Then
            agentToInstall.company_id = Module1.Agroconcept
            agentToInstall.company_name = valueName
            agentToInstall.company_logo = My.Resources.optimumdesk_logo
            agentToInstall.ftp = CreateDownloadLink(agentToInstall.company_id)
            agentToInstall.agent_version = agent_Ver
        End If

        If valueName = "Aims Human Capital Romania" Then
            agentToInstall.company_id = Module1.Aims_Human_Capital_Romania
            agentToInstall.company_name = valueName
            agentToInstall.company_logo = My.Resources.optimumdesk_logo
            agentToInstall.ftp = CreateDownloadLink(agentToInstall.company_id)
            agentToInstall.agent_version = agent_Ver
        End If

        If valueName = "Aktiv Power" Then
            agentToInstall.company_id = Module1.Aktiv_Power
            agentToInstall.company_name = valueName
            agentToInstall.company_logo = My.Resources.optimumdesk_logo
            agentToInstall.ftp = CreateDownloadLink(agentToInstall.company_id)
            agentToInstall.agent_version = agent_Ver
        End If

        If valueName = "AMREST FOOD (Burger King)" Then
            agentToInstall.company_id = Module1.AMREST_FOOD_Burger_King
            agentToInstall.company_name = valueName
            agentToInstall.company_logo = My.Resources.optimumdesk_logo
            agentToInstall.ftp = CreateDownloadLink(agentToInstall.company_id)
            agentToInstall.agent_version = agent_Ver
        End If

        If valueName = "Angelini Pharmaceuticals" Then
            agentToInstall.company_id = Module1.Angelini_Pharmaceuticals
            agentToInstall.company_name = valueName
            agentToInstall.company_logo = My.Resources.optimumdesk_logo
            agentToInstall.ftp = CreateDownloadLink(agentToInstall.company_id)
            agentToInstall.agent_version = agent_Ver
        End If

        If valueName = "Artemob International" Then
            agentToInstall.company_id = Module1.Artemob_International
            agentToInstall.company_name = valueName
            agentToInstall.company_logo = My.Resources.optimumdesk_logo
            agentToInstall.ftp = CreateDownloadLink(agentToInstall.company_id)
            agentToInstall.agent_version = agent_Ver
        End If

        If valueName = "As24 Tankservice" Then
            agentToInstall.company_id = Module1.As24_Tankservice
            agentToInstall.company_name = valueName
            agentToInstall.company_logo = My.Resources.optimumdesk_logo
            agentToInstall.ftp = CreateDownloadLink(agentToInstall.company_id)
            agentToInstall.agent_version = agent_Ver
        End If

        If valueName = "ASHAY SERVICES S.R.L." Then
            agentToInstall.company_id = Module1.ASHAY_SERVICES_SRL
            agentToInstall.company_name = valueName
            agentToInstall.company_logo = My.Resources.optimumdesk_logo
            agentToInstall.ftp = CreateDownloadLink(agentToInstall.company_id)
            agentToInstall.agent_version = agent_Ver
        End If



        If valueName = "Auto Erebus" Then
            agentToInstall.company_id = Module1.Auto_Erebus
            agentToInstall.company_name = valueName
            agentToInstall.company_logo = My.Resources.optimumdesk_logo
            agentToInstall.ftp = CreateDownloadLink(agentToInstall.company_id)
            agentToInstall.agent_version = agent_Ver
        End If

        If valueName = "Avocati Corina Popescu" Then
            agentToInstall.company_id = Module1.Avocati_Corina_Popescu
            agentToInstall.company_name = valueName
            agentToInstall.company_logo = My.Resources.optimumdesk_logo
            agentToInstall.ftp = CreateDownloadLink(agentToInstall.company_id)
            agentToInstall.agent_version = agent_Ver
        End If


        If valueName = "B2Holding" Then
            agentToInstall.company_id = Module1.B2Holding
            agentToInstall.company_name = valueName
            agentToInstall.company_logo = My.Resources.optimumdesk_logo
            agentToInstall.ftp = CreateDownloadLink(agentToInstall.company_id)
            agentToInstall.agent_version = agent_Ver
        End If




        TextBox_CompanyID.Text = agentToInstall.company_id
        PictureBox8.Image = agentToInstall.company_logo
        TextBox3.Text = agentToInstall.company_name
        TextBox31.Text = agentToInstall.company_id
        TextBox11.Text = agentToInstall.agent_version
        TextBox_AgentVersion.Text = agentToInstall.agent_version

        LastUsedDownloadLink = agentToInstall.ftp


        Return agentToInstall
    End Function



    Private Sub Button14_Click(sender As Object, e As EventArgs)
        Timer_MultiAgentDropDown.Start()
    End Sub

    Private Sub PictureBox1_Hover(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter, tbCName.MouseEnter

        PictureBox1.Width = PictureBox1.Width + 2
        PictureBox1.Height = PictureBox1.Height + 1

        'PictureBox1.BorderStyle = BorderStyle.FixedSingle

    End Sub


    Private Sub PictureBox1_leave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave, tbCName.MouseLeave



        PictureBox1.Width = PictureBox1.Width - 2
        PictureBox1.Height = PictureBox1.Height - 1


        'PictureBox1.BorderStyle = BorderStyle.None

    End Sub

    Private Sub PictureBox6_Hover(sender As Object, e As EventArgs) Handles PictureBox6.MouseEnter, TextBox2.MouseEnter
        'PictureBox6.BorderStyle = BorderStyle.FixedSingle
        PictureBox6.Width = PictureBox6.Width + 2
        PictureBox6.Height = PictureBox6.Height + 1

    End Sub

    Private Sub PictureBox6_Leave(sender As Object, e As EventArgs) Handles PictureBox6.MouseLeave, TextBox2.MouseLeave
        'PictureBox6.BorderStyle = BorderStyle.None
        PictureBox6.Width = PictureBox6.Width - 2
        PictureBox6.Height = PictureBox6.Height - 1
    End Sub


    Private Sub PictureBox18_Hover(sender As Object, e As EventArgs) Handles PictureBox18.MouseEnter, TextBox38.MouseEnter
        'PictureBox6.BorderStyle = BorderStyle.FixedSingle
        PictureBox18.Width = PictureBox18.Width + 2
        PictureBox18.Height = PictureBox18.Height + 1

    End Sub

    Private Sub PictureBox18_Leave(sender As Object, e As EventArgs) Handles PictureBox18.MouseLeave, TextBox38.MouseLeave
        'PictureBox6.BorderStyle = BorderStyle.None
        PictureBox18.Width = PictureBox18.Width - 2
        PictureBox18.Height = PictureBox18.Height - 1
    End Sub

    Private Sub Panel15_Click(sender As Object, e As EventArgs) Handles Panel11.Click, Panel10.Click, Panel13.Click, tbCName.Click, PictureBox1.Click, Label56.Click, Label38.Click
        Timer_MultiAgentDropDown.Start()

    End Sub


    Private Sub Button_US_Agent_Hover(sender As Object, e As EventArgs) Handles Button_US_Agent.MouseHover
        Button_US_Agent.Size = Button_US_Agent.MaximumSize
    End Sub

    Private Sub Button_US_Agent_Leave(sender As Object, e As EventArgs) Handles Button_US_Agent.MouseLeave

        Button_US_Agent.Size = Button_US_Agent.MinimumSize

    End Sub

    Private Sub Button_EU_Agent_hover(sender As Object, e As EventArgs) Handles Button_EU_Agent.MouseHover
        Button_EU_Agent.Size = Button_EU_Agent.MaximumSize
    End Sub

    Private Sub Button_EU_Agent_leave(sender As Object, e As EventArgs) Handles Button_EU_Agent.MouseLeave
        Button_EU_Agent.Size = Button_EU_Agent.MinimumSize
    End Sub

    Private Sub Button22_Click_1(sender As Object, e As EventArgs)

        For Each pnl As Control In PanelInstallNewAgent.Controls
            If pnl.GetType = GetType(Panel) Then
                pnl.Size = pnl.MinimumSize
                pnl.SendToBack()
            End If
        Next


    End Sub

    'Private Sub CheckBoxClicked(sender As Object, e As EventArgs)
    '    Dim chkBox1 As CheckBox = DirectCast(sender, CheckBox)
    '    Dim chkBox2 As CheckBox = If(chkBox1.Name = "CheckBox6", CheckBox_EU, CheckBox_US)

    '    If chkBox1.Checked Then
    '        chkBox2.Checked = False
    '    End If
    'End Sub



    Public Function getID() As CompanyDetails

        '' Associates CompanyID with CompanyDetails
        companyDetailsList.Clear()
        Frame.agentCount = 0
        Dim companyIDList As New List(Of String)
        Dim value As String = Nothing


        ' Check first registry key location
        Using key As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Class IT\ODMem")
            If key IsNot Nothing Then
                value = key.GetValue("Qtp0EPqa09tocvBwRimd1g==")
                If value IsNot Nothing Then
                    companyID = Decrypt(value)
                    companyIDList.Add(companyID)
                End If
            End If
        End Using

        ' Check second registry key location
        Using key As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Easee Control")
            If key IsNot Nothing Then
                value = key.GetValue("Qtp0EPqa09tocvBwRimd1g==")
                If value IsNot Nothing Then
                    companyID = Decrypt(value)
                    companyIDList.Add(companyID)
                End If
            End If
        End Using

        ' Check second registry key location
        Using key As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\OptimumDesk")
            If key IsNot Nothing Then
                value = key.GetValue("Qtp0EPqa09tocvBwRimd1g==")
                If value IsNot Nothing Then
                    companyID = Decrypt(value)
                    companyIDList.Add(companyID)
                End If
            End If
        End Using



        ' Check PC Matic registry key location
        Using key As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\PCMatic\Account")
            If key IsNot Nothing Then
                value = key.GetValue("NCne5NUp41ltZ+S8rPJxIg==")
                If value IsNot Nothing Then
                    Dim dic2 As StructuresModule.SignUpRegistrationData
                    Dim json As New JavaScriptSerializer
                    json.MaxJsonLength = 2147483644
                    dic2 = json.Deserialize(Of StructuresModule.SignUpRegistrationData)(Module1.Decrypt(value))
                    companyID = Decrypt(dic2.companyId)
                    companyIDList.Add(companyID)
                End If
            End If

        End Using

        '4 reg key location
        Using key As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\OptimumDesk\Account")
            If key IsNot Nothing Then
                value = key.GetValue("NCne5NUp41ltZ+S8rPJxIg==")
                If value IsNot Nothing Then
                    Dim dic2 As StructuresModule.SignUpRegistrationData
                    Dim json As New JavaScriptSerializer
                    json.MaxJsonLength = 2147483644
                    dic2 = json.Deserialize(Of StructuresModule.SignUpRegistrationData)(Module1.Decrypt(value))
                    companyID = Decrypt(dic2.companyId)
                    companyIDList.Add(companyID)
                End If
            End If
        End Using

        '5 reg key EaseeAccess
        Using key As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Class IT\EARem")
            If key IsNot Nothing Then
                value = key.GetValue("UxUPrnclGvzAU+gtGMsxEQ==")
                If value IsNot Nothing Then
                    Dim dic2 As StructuresModule.SignUpRegistrationData
                    Dim json As New JavaScriptSerializer
                    json.MaxJsonLength = 2147483644
                    dic2 = json.Deserialize(Of StructuresModule.SignUpRegistrationData)(Module1.Decrypt(value))

                    'Manual 
                    companyID = "23571"
                    companyIDList.Add(companyID)


                    'companyIDList.Add(companyID)
                End If
            End If
        End Using









        'Loop for each returned company ID assing to agent list
        For Each company As String In companyIDList.Distinct
            Frame.agentCount = Frame.agentCount + 1
            selectByID(company)
        Next



        'If Frame.agentCount > 1 Then
        '    Frame.agentCount = Frame.agentCount - 1
        'End If

        ' Label56.Text = "+ " & Frame.agentCount - 2

        Return agentInstalled

    End Function


    Public Function selectByID(companyID As String) As CompanyDetails

        Dim path1 As String = "OptimumDesk\OptimumDesk.exe"
        Dim path2 As String = "EaseeControl\EaseeControl.exe"






        Select Case companyID
            Case Module1.TechID
                If Module1.TechID = companyID Then
                    If System.IO.File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "OptimumDesk\OptimumDesk.exe")) Or System.IO.File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "TechServices\TechServices.exe")) Then
                        Dim agentInstalled As New CompanyDetails
                        agentInstalled.company_id = Module1.TechID
                        agentInstalled.company_name = "TechServices"
                        agentInstalled.company_logo = My.Resources.logoTech
                        agentInstalled.agent_region = "US"
                        agentInstalled.beta_version = TextBox_Server.Text
                        agentInstalled.agent_framework = "OD"
                        ' agentInstalled.ftp = "https://updateor.optimumdesk.com/download/884c3b4485160e19f93ffe73cf719fa6b081b7a7/company/20621/setup.exe"
                        agentInstalled.file_location = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "OptimumDesk\OptimumDesk.exe")
                        companyDetailsList.Add(agentInstalled)
                        Frame.agentExeFound = Frame.agentExeFound + 1
                    End If
                End If

            Case Module1.TrueID
                If companyID = Module1.TrueID Then
                    If System.IO.File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "True Solutions\True.exe")) Then
                        Dim agentInstalled As New CompanyDetails
                        agentInstalled.company_id = Module1.TrueID
                        agentInstalled.company_name = "True Solutions"
                        agentInstalled.beta_version = TextBox_Server.Text
                        agentInstalled.company_logo = My.Resources.TrueLogoWhite2
                        agentInstalled.agent_region = "US"
                        agentInstalled.agent_framework = "EC"
                        agentInstalled.regKey = "SOFTWARE\OptimumDesk\Account"
                        agentInstalled.regKeyCheck = "NCne5NUp41ltZ+S8rPJxIg=="
                        agentInstalled.ftp = "https://update.optimumdesk.com/public/compiledEC/true/setup.exe"
                        agentInstalled.file_location = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "True Solutions\True.exe")
                        companyDetailsList.Add(agentInstalled)
                        Frame.agentExeFound = Frame.agentExeFound + 1
                    End If
                End If


            Case Module1.PCMaticID
                If System.IO.File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "PCMATIC\PCMATIC.exe")) Then
                    Dim agentInstalled As New CompanyDetails
                    agentInstalled.company_id = Module1.PCMaticID
                    agentInstalled.company_name = "Pc Matic"
                    agentInstalled.beta_version = TextBox_Server.Text
                    agentInstalled.company_logo = My.Resources.SupportUnlimited_logo
                    agentInstalled.agent_region = "US"
                    agentInstalled.agent_framework = "OD"
                    agentInstalled.ftp = "https://updateor.optimumdesk.com/download/884c3b4485160e19f93ffe73cf719fa6b081b7a7/company/23861/setup.exe"
                    agentInstalled.file_location = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "PCMATIC\PCMATIC.exe")
                    companyDetailsList.Add(agentInstalled)
                    Frame.agentExeFound = Frame.agentExeFound + 1
                End If


            Case Module1.DnHID
                If companyID = Module1.DnHID Then
                    If System.IO.File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "YourHelpDeskHQ\YourHelpDeskHQ.exe")) Then
                        Dim agentInstalled As New CompanyDetails
                        agentInstalled.company_id = Module1.DnHID
                        agentInstalled.company_name = "Your Help Desk HQ"
                        agentInstalled.beta_version = TextBox_Server.Text
                        agentInstalled.company_logo = My.Resources.TrueLogoWhite2
                        agentInstalled.agent_region = "US"
                        agentInstalled.agent_framework = "EC"
                        agentInstalled.ftp = "https://updateor.optimumdesk.com/download/884c3b4485160e19f93ffe73cf719fa6b081b7a7/company/24159/setup.exe"
                        agentInstalled.file_location = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "YourHelpDeskHQ\YourHelpDeskHQ.exe")
                        companyDetailsList.Add(agentInstalled)
                        Frame.agentExeFound = Frame.agentExeFound + 1
                    End If
                End If



            Case Module1.StaplesID
                If System.IO.File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "OptimumDesk\OptimumDesk.exe")) Then
                    Dim agentInstalled As New CompanyDetails
                    agentInstalled.company_id = Module1.StaplesID
                    agentInstalled.company_name = "Staples"
                    agentInstalled.beta_version = TextBox_Server.Text
                    agentInstalled.company_logo = My.Resources.stapleslogo
                    agentInstalled.agent_region = "US"
                    agentInstalled.agent_framework = "?"
                    agentInstalled.ftp = "https://updateor.optimumdesk.com/download/884c3b4485160e19f93ffe73cf719fa6b081b7a7/company/24159/setup.exe"
                    agentInstalled.file_location = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "OptimumDesk\OptimumDesk.exe")
                    companyDetailsList.Add(agentInstalled)
                    Frame.agentExeFound = Frame.agentExeFound + 1
                End If

            Case Module1.StaplesRetailID
                If System.IO.File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "OptimumDesk\OptimumDesk.exe")) Then
                    Dim agentInstalled As New CompanyDetails
                    agentInstalled.company_id = Module1.StaplesRetailID
                    agentInstalled.company_name = "Staples Retail"
                    agentInstalled.beta_version = TextBox_Server.Text
                    agentInstalled.company_logo = My.Resources.stapleslogo
                    agentInstalled.agent_region = "US"
                    agentInstalled.agent_framework = "??"
                    agentInstalled.ftp = "https://updateor.optimumdesk.com/download/884c3b4485160e19f93ffe73cf719fa6b081b7a7/company/24159/setup.exe"
                    agentInstalled.file_location = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "OptimumDesk\OptimumDesk.exe")
                    companyDetailsList.Add(agentInstalled)
                    Frame.agentExeFound = Frame.agentExeFound + 1
                End If

            Case Module1.WalmartOnlineID
                If System.IO.File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "OptimumDesk\OptimumDesk.exe")) Then
                    Dim agentInstalled As New CompanyDetails
                    agentInstalled.company_id = Module1.WalmartOnlineID
                    agentInstalled.company_name = "Walmart Online"
                    agentInstalled.beta_version = TextBox_Server.Text
                    agentInstalled.company_logo = My.Resources.walmartLogo
                    agentInstalled.agent_region = "US"
                    agentInstalled.agent_framework = "OD"
                    agentInstalled.ftp = "https://updateor.optimumdesk.com/download/884c3b4485160e19f93ffe73cf719fa6b081b7a7/company/24159/setup.exe"
                    agentInstalled.file_location = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "OptimumDesk\OptimumDesk.exe")
                    companyDetailsList.Add(agentInstalled)
                    Frame.agentExeFound = Frame.agentExeFound + 1
                End If

            Case Module1.WalmartComID
                If System.IO.File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "OptimumDesk\OptimumDesk.exe")) Then
                    Dim agentInstalled As New CompanyDetails
                    agentInstalled.company_id = Module1.WalmartComID
                    agentInstalled.company_name = "Walmart.com"
                    agentInstalled.beta_version = TextBox_Server.Text
                    agentInstalled.company_logo = My.Resources.Walmert2Logo
                    agentInstalled.agent_region = "US"
                    agentInstalled.agent_framework = "OD"
                    agentInstalled.ftp = "https://updateor.optimumdesk.com/download/884c3b4485160e19f93ffe73cf719fa6b081b7a7/company/23559/setup.exe"
                    agentInstalled.file_location = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "OptimumDesk\OptimumDesk.exe")
                    companyDetailsList.Add(agentInstalled)
                    Frame.agentExeFound = Frame.agentExeFound + 1
                End If


            Case Module1.PlusID
                If System.IO.File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "OptimumDesk\OptimumDesk.exe")) Then
                    Dim agentInstalled As New CompanyDetails
                    agentInstalled.company_id = Module1.PlusID
                    agentInstalled.company_name = "Plus"
                    agentInstalled.beta_version = TextBox_Server.Text
                    agentInstalled.company_logo = My.Resources.puls_logo
                    agentInstalled.agent_region = "US"
                    agentInstalled.agent_framework = "OD"
                    agentInstalled.ftp = "https://updateor.optimumdesk.com/download/884c3b4485160e19f93ffe73cf719fa6b081b7a7/company/23526/setup.exe"
                    agentInstalled.file_location = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "OptimumDesk\OptimumDesk.exe")
                    companyDetailsList.Add(agentInstalled)
                    Frame.agentExeFound = Frame.agentExeFound + 1
                End If

            Case Module1.NewEGGID
                If companyID = Module1.NewEGGID Then
                    If System.IO.File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "OptimumDesk\OptimumDesk.exe")) Then
                        Dim agentInstalled As New CompanyDetails
                        agentInstalled.company_id = Module1.NewEGGID
                        agentInstalled.company_name = "NewEgg"
                        agentInstalled.beta_version = TextBox_Server.Text
                        agentInstalled.company_logo = My.Resources.newegglogo
                        agentInstalled.agent_framework = "EC"
                        agentInstalled.agent_region = "US"
                        agentInstalled.ftp = "https://updateor.optimumdesk.com/download/884c3b4485160e19f93ffe73cf719fa6b081b7a7/company/23862/setup.exe"
                        agentInstalled.file_location = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "OptimumDesk\OptimumDesk.exe")
                        companyDetailsList.Add(agentInstalled)
                        Frame.agentExeFound = Frame.agentExeFound + 1
                    End If
                End If


            Case Module1.CompanyCom
                If companyID = Module1.CompanyCom Then
                    If System.IO.File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "OptimumDesk\OptimumDesk.exe")) Then
                        Dim agentInstalled As New CompanyDetails
                        agentInstalled.company_id = Module1.CompanyCom
                        agentInstalled.company_name = "Company.Com"
                        agentInstalled.beta_version = TextBox_Server.Text
                        agentInstalled.company_logo = My.Resources.newegglogo
                        agentInstalled.agent_framework = "OD"
                        agentInstalled.agent_region = "US"
                        'agentInstalled.ftp = CreateDownloadLink(Module1.CompanyCom)
                        agentInstalled.ftp = "https://updateor.optimumdesk.com/download/884c3b4485160e19f93ffe73cf719fa6b081b7a7/company/20686/setup.exe"
                        agentInstalled.file_location = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "OptimumDesk\OptimumDesk.exe")
                        companyDetailsList.Add(agentInstalled)
                        Frame.agentExeFound = Frame.agentExeFound + 1
                    End If
                End If


            Case Module1.EaseeAccess
                If companyID = Module1.EaseeAccess Then
                    If System.IO.File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "EaseeAccess\EaseeAccess.exe")) Then
                        Dim agentInstalled As New CompanyDetails
                        agentInstalled.company_id = Module1.EaseeAccess
                        agentInstalled.company_name = "EaseeAccess"
                        agentInstalled.beta_version = TextBox_Server.Text
                        agentInstalled.company_logo = My.Resources.optimumdesk_logo
                        agentInstalled.agent_framework = "OD"
                        agentInstalled.agent_region = "US"
                        'agentInstalled.ftp = CreateDownloadLink(Module1.CompanyCom)
                        agentInstalled.ftp = "https://updateor.optimumdesk.com/download/884c3b4485160e19f93ffe73cf719fa6b081b7a7/company/23571/setup.exe"
                        agentInstalled.file_location = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "EaseeAccess\EaseeAccess.exe")
                        companyDetailsList.Add(agentInstalled)
                        Frame.agentExeFound = Frame.agentExeFound + 1
                    End If
                End If

            Case Module1.EaseeControlID
                If companyID = Module1.EaseeControlID Then
                    If System.IO.File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "EaseeControl\EaseeControl.exe")) Then
                        Dim agentInstalled As New CompanyDetails
                        agentInstalled.company_id = Module1.EaseeControlID
                        agentInstalled.company_name = "EaseeControl"
                        agentInstalled.beta_version = TextBox_Server.Text
                        agentInstalled.company_logo = My.Resources.EaseeControlLogo
                        agentInstalled.agent_framework = "EC"
                        agentInstalled.agent_region = "US"
                        agentInstalled.ftp = CreateDownloadLink(Module1.EaseeControlID)
                        agentInstalled.file_location = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "EaseeAccess\EaseeAccess.exe")
                        companyDetailsList.Add(agentInstalled)
                        Frame.agentExeFound = Frame.agentExeFound + 1
                    End If
                End If


            Case Module1.GoAgilantID
                If companyID = Module1.GoAgilantID Then
                    If System.IO.File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "OptimumDesk\OptimumDesk.exe")) Then
                        Dim agentInstalled As New CompanyDetails
                        agentInstalled.company_id = Module1.GoAgilantID
                        agentInstalled.company_name = "GoAgilant"
                        agentInstalled.beta_version = TextBox_Server.Text
                        agentInstalled.company_logo = My.Resources.agilant_logo
                        agentInstalled.agent_framework = "OD"
                        agentInstalled.agent_region = "US"
                        agentInstalled.ftp = CreateDownloadLink(Module1.GoAgilantID)
                        agentInstalled.file_location = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "OptimumDesk\OptimumDesk.exe")
                        companyDetailsList.Add(agentInstalled)
                        Frame.agentExeFound = Frame.agentExeFound + 1
                    End If
                End If

            Case Module1.Office_Depot_SMB
                If companyID = Module1.Office_Depot_SMB Then
                    If System.IO.File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "OptimumDesk\OptimumDesk.exe")) Then
                        Dim agentInstalled As New CompanyDetails
                        agentInstalled.company_id = Module1.Office_Depot_SMB
                        agentInstalled.company_name = "Office Depot SMB"
                        agentInstalled.beta_version = TextBox_Server.Text
                        agentInstalled.company_logo = My.Resources.logoTech
                        agentInstalled.agent_framework = "OD"
                        agentInstalled.agent_region = "US"
                        agentInstalled.ftp = CreateDownloadLink(Module1.Office_Depot_SMB)
                        agentInstalled.file_location = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "OptimumDesk\OptimumDesk.exe")
                        companyDetailsList.Add(agentInstalled)
                        Frame.agentExeFound = Frame.agentExeFound + 1
                    End If
                End If


            Case Module1.OptimumDeskID
                If companyID = Module1.OptimumDeskID Then
                    If System.IO.File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "OptimumDesk\OptimumDesk.exe")) Then
                        Dim agentInstalled As New CompanyDetails
                        agentInstalled.company_id = Module1.OptimumDeskID
                        agentInstalled.company_name = "OptimumDesk"
                        agentInstalled.beta_version = TextBox_Server.Text
                        agentInstalled.company_logo = My.Resources.logoTech
                        agentInstalled.agent_framework = "OD"
                        agentInstalled.agent_region = "US"
                        agentInstalled.ftp = CreateDownloadLink(Module1.OptimumDeskID)
                        agentInstalled.file_location = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "OptimumDesk\OptimumDesk.exe")
                        companyDetailsList.Add(agentInstalled)
                        Frame.agentExeFound = Frame.agentExeFound + 1
                    End If
                End If

            Case Module1.Startech365
                If companyID = Module1.Startech365 Then
                    If System.IO.File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "OptimumDesk\OptimumDesk.exe")) Then
                        Dim agentInstalled As New CompanyDetails
                        agentInstalled.company_id = Module1.Startech365
                        agentInstalled.company_name = "Startech365"
                        agentInstalled.beta_version = TextBox_Server.Text
                        agentInstalled.company_logo = My.Resources.logoTech
                        agentInstalled.agent_framework = "OD"
                        agentInstalled.agent_region = "US"
                        agentInstalled.ftp = CreateDownloadLink(Module1.Startech365)
                        agentInstalled.file_location = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "OptimumDesk\OptimumDesk.exe")
                        companyDetailsList.Add(agentInstalled)
                        Frame.agentExeFound = Frame.agentExeFound + 1
                    End If
                End If


            Case Module1.Synnex
                If companyID = Module1.Synnex Then
                    If System.IO.File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "OptimumDesk\OptimumDesk.exe")) Then
                        Dim agentInstalled As New CompanyDetails
                        agentInstalled.company_id = Module1.Synnex
                        agentInstalled.company_name = "Synnex"
                        agentInstalled.beta_version = TextBox_Server.Text
                        agentInstalled.company_logo = My.Resources.SynnexLogo
                        agentInstalled.agent_framework = "OD"
                        agentInstalled.agent_region = "US"
                        agentInstalled.ftp = CreateDownloadLink(Module1.Synnex)
                        agentInstalled.file_location = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "OptimumDesk\OptimumDesk.exe")
                        companyDetailsList.Add(agentInstalled)
                        Frame.agentExeFound = Frame.agentExeFound + 1
                    End If
                End If

                'ROMANIA

            Case Module1.ClassITID
                If companyID = Module1.ClassITID Then
                    If System.IO.File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), path1)) Or System.IO.File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), path2)) Then
                        Dim agentInstalled As New CompanyDetails
                        agentInstalled.company_id = Module1.ClassITID
                        agentInstalled.company_name = "Class It Outsourcing"
                        agentInstalled.beta_version = TextBox_Server.Text
                        agentInstalled.company_logo = My.Resources.optimumdesk_logo
                        agentInstalled.agent_framework = "OD"
                        agentInstalled.agent_region = "EU"
                        agentInstalled.ftp = "https://updateor.optimumdesk.com/download/884c3b4485160e19f93ffe73cf719fa6b081b7a7/company/8511/setup.exe"
                        agentInstalled.file_location = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "OptimumDesk\OptimumDesk.exe")
                        companyDetailsList.Add(agentInstalled)
                        Frame.agentExeFound = Frame.agentExeFound + 1
                    End If
                End If

            Case Module1.Class_IT_Home
                If System.IO.File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), path1)) Or System.IO.File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), path2)) Then
                    Dim agentInstalled As New CompanyDetails
                    agentInstalled.company_id = Module1.Class_IT_Home
                    agentInstalled.company_name = "Class IT Home"
                    agentInstalled.company_logo = My.Resources.optimumdesk_logo
                    agentInstalled.beta_version = TextBox_Server.Text
                    agentInstalled.agent_framework = "OD"
                    agentInstalled.agent_region = "EU"
                    agentInstalled.ftp = "https://updateor.optimumdesk.com/download/b17b36236610ef36f29efe86a39fdc5d46a436fa/company/" & agentInstalled.company_id & "/setup.exe"
                    agentInstalled.file_location = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "OptimumDesk\OptimumDesk.exe")
                    companyDetailsList.Add(agentInstalled)
                    Frame.agentExeFound = Frame.agentExeFound + 1
                End If

            Case Module1.April_Romania
                If System.IO.File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "OptimumDesk\OptimumDesk.exe")) Then
                    Dim agentInstalled As New CompanyDetails
                    agentInstalled.company_id = Module1.April_Romania
                    agentInstalled.company_name = "April Romania"
                    agentInstalled.company_logo = My.Resources.optimumdesk_logo
                    agentInstalled.beta_version = TextBox_Server.Text
                    agentInstalled.agent_framework = "OD"
                    agentInstalled.agent_region = "EU"
                    agentInstalled.ftp = "https://updateor.optimumdesk.com/compiledEC/2/19490/setup.exe"
                    agentInstalled.file_location = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "OptimumDesk\OptimumDesk.exe")
                    companyDetailsList.Add(agentInstalled)
                    Frame.agentExeFound = Frame.agentExeFound + 1
                End If


            Case Module1.Aectra
                If System.IO.File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "OptimumDesk\OptimumDesk.exe")) Or System.IO.File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "EaseeControl\EaseeControl.exe")) Then
                    Dim agentInstalled As New CompanyDetails
                    agentInstalled.company_id = Module1.Aectra
                    agentInstalled.company_name = "Aectra"
                    agentInstalled.company_logo = My.Resources.optimumdesk_logo
                    agentInstalled.beta_version = TextBox_Server.Text
                    agentInstalled.agent_framework = "OD"
                    agentInstalled.agent_region = "EU"
                    agentInstalled.ftp = "https://updateor.optimumdesk.com/download/b17b36236610ef36f29efe86a39fdc5d46a436fa/company/" & agentInstalled.company_id & "/setup.exe"
                    agentInstalled.file_location = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "OptimumDesk\OptimumDesk.exe")
                    companyDetailsList.Add(agentInstalled)
                    Frame.agentExeFound = Frame.agentExeFound + 1
                End If

            Case Module1.Aerodynamics
                If System.IO.File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), path1)) Or System.IO.File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), path2)) Then
                    Dim agentInstalled As New CompanyDetails
                    agentInstalled.company_id = Module1.Aerodynamics
                    agentInstalled.company_name = "Aerodynamics"
                    agentInstalled.company_logo = My.Resources.optimumdesk_logo
                    agentInstalled.beta_version = TextBox_Server.Text
                    agentInstalled.agent_framework = "OD"
                    agentInstalled.agent_region = "EU"
                    agentInstalled.ftp = "https://updateor.optimumdesk.com/download/b17b36236610ef36f29efe86a39fdc5d46a436fa/company/" & agentInstalled.company_id & "/setup.exe"
                    agentInstalled.file_location = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "OptimumDesk\OptimumDesk.exe")
                    companyDetailsList.Add(agentInstalled)
                    Frame.agentExeFound = Frame.agentExeFound + 1
                End If


            Case Module1.B2Holding
                If System.IO.File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), path1)) Or System.IO.File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), path2)) Then
                    Dim agentInstalled As New CompanyDetails
                    agentInstalled.company_id = Module1.B2Holding
                    agentInstalled.company_name = "B2Holding"
                    agentInstalled.company_logo = My.Resources.optimumdesk_logo
                    agentInstalled.beta_version = TextBox_Server.Text
                    agentInstalled.agent_framework = "OD"
                    agentInstalled.agent_region = "EU"
                    agentInstalled.ftp = "https://updateor.optimumdesk.com/download/b17b36236610ef36f29efe86a39fdc5d46a436fa/company/" & agentInstalled.company_id & "/setup.exe"
                    agentInstalled.file_location = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "OptimumDesk\OptimumDesk.exe")
                    companyDetailsList.Add(agentInstalled)
                    Frame.agentExeFound = Frame.agentExeFound + 1
                End If

            Case Else
                agentInstalled.company_id = "0000"
                agentInstalled.company_name = "Null"
                agentInstalled.beta_version = "0.0"
                agentInstalled.company_logo = Nothing
                agentInstalled.agent_version = "0.0"
                agentInstalled.agent_framework = "EC"
                agentInstalled.ftp = Nothing
                agentInstalled.file_location = "Null"
        End Select

        If Frame.agentExeFound = 0 Then
            isAgentInstalled = False
        Else
            isAgentInstalled = True
        End If




        ' PanelMultiAgent.Hide()

        Dim sizeX1 As New Size(1017, 60)
        Dim sizeX2 As New Size(1017, 116)
        Dim sizeX3 As New Size(1017, 174)

        Dim i As Integer = 1
        For Each company As CompanyDetails In companyDetailsList.Distinct

            Select Case i
                Case 1
                    PictureBox1.Image = company.company_logo
                    PictureBox4.Image = company.company_logo
                    tbCName.Text = company.company_name
                    Label7.Text = company.company_name
                    Label38.Text = company.company_id
                    PanelMultiAgent.MaximumSize = sizeX1

                Case 2

                    PictureBox6.Image = company.company_logo
                    TextBox2.Text = company.company_name
                    Label37.Text = company.company_id

                    If company.agent_region = "EU" Then
                        PictureBox_MiniFlag1.Image = My.Resources.european_union
                    Else
                        PictureBox_MiniFlag1.Image = My.Resources.united_states
                    End If

                    Label59.Text = company.agent_framework
                    PanelMultiAgent.MaximumSize = sizeX2

                Case 3
                    PictureBox18.Image = company.company_logo
                    TextBox38.Text = company.company_name
                    Label39.Text = company.company_id

                    If company.agent_region = "EU" Then
                        PictureBox_MiniFlag2.Image = My.Resources.european_union
                    Else
                        PictureBox_MiniFlag2.Image = My.Resources.united_states
                    End If

                    Label10.Text = company.agent_framework
                    PanelMultiAgent.MaximumSize = sizeX3

                Case 4

                    PictureBox19.Image = company.company_logo
                    TextBox37.Text = company.company_name
                    Label35.Text = company.company_id
                    Label34.Text = company.agent_framework
                    PanelMultiAgent.MaximumSize = sizeX3

            End Select
            i += 1
        Next

        Label56.Text = i - 1
        PanelMultiAgent.Show()
        Return agentInstalled
    End Function


    Sub ChangeMainAgent()


        ' Create a new list to hold the company IDs to process
        Dim companyIDs As New List(Of Integer)

        ' Add the IDs of companies that need to be processed to the new list
        For Each company As CompanyDetails In companyDetailsList
            If company.company_id <> Label38.Text Then
                companyIDs.Add(company.company_id)
            End If
        Next

        ' Iterate over the new list of company IDs and call the selectAgent method for each company
        For Each companyID As Integer In companyIDs
            selectByID(companyID)
        Next
    End Sub





    Private Sub Timer_MultiAgentDropDown_Tick(sender As Object, e As EventArgs) Handles Timer_MultiAgentDropDown.Tick


        PanelMultiAgent.Show()



        If isMenu1Collapsed Then
            PanelMultiAgent.Width += 50
            PanelMultiAgent.Height += 50
            RoundedCorner(PanelMultiAgent, 20)
            If PanelMultiAgent.Size = PanelMultiAgent.MaximumSize Then
                isMenu1Collapsed = False
                PanelMultiAgent.BringToFront()
                Timer_MultiAgentDropDown.Stop()
            End If
        Else
            PanelMultiAgent.Width -= 50
            PanelMultiAgent.Height -= 50
            RoundedCorner(PanelMultiAgent, 20)
            If PanelMultiAgent.Size = PanelMultiAgent.MinimumSize Then
                isMenu1Collapsed = True
                PanelMultiAgent.SendToBack()
                Timer_MultiAgentDropDown.Stop()
            End If
        End If

    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs)
        getID()
    End Sub

    'Sub SearchText()

    '    If TextBox28.Text <> "Search" Then
    '        ' Get the search term from the TextBox
    '        Dim searchTerm As String = TextBox28.Text.Trim()

    '        ' Search for the term in the RichTextBox
    '        Dim index As Integer = RichTextBox2.Find(searchTerm)

    '        ' If the term is found, select and scroll to the result in the RichTextBox
    '        If index >= 0 Then
    '            RichTextBox2.Select(index, searchTerm.Length)
    '            RichTextBox2.ScrollToCaret()
    '            RichTextBox2.SelectionBackColor = Color.Yellow
    '            RichTextBox2.SelectionColor = Color.Black

    '        Else
    '            MsgBox("Search term " & TextBox28.Text & " not found.")
    '        End If
    '    Else
    '        TextBox28.Text = ""
    '    End If
    'End Sub

    Sub SearchText()
        If TextBox28.Text <> "Search" Then
            ' Get the search term from the TextBox
            Dim searchTerm As String = TextBox28.Text.Trim()

            ' Search for the term in the RichTextBox
            Dim index As Integer = RichTextBox2.Find(searchTerm)

            ' If the term is found, select and scroll to the result in the RichTextBox
            If index >= 0 Then
                RichTextBox2.Select(index, searchTerm.Length)
                RichTextBox2.ScrollToCaret()
                RichTextBox2.SelectionBackColor = Color.Yellow
                RichTextBox2.SelectionColor = Color.Black

                ' Get the line number of the search result
                Dim lineIndex As Integer = RichTextBox2.GetLineFromCharIndex(index)

                ' Scroll the RichTextBox to the line of the search result
                RichTextBox2.SelectionStart = RichTextBox2.GetFirstCharIndexFromLine(lineIndex)
                RichTextBox2.ScrollToCaret()
            Else
                ' Display a message box if the search term is not found
                MsgBox("Search term " & TextBox28.Text & " not found.")
            End If
        Else
            TextBox28.Text = ""
        End If
    End Sub


    Private Sub TextBox28_Leave(sender As Object, e As EventArgs) Handles TextBox28.MouseLeave

        If TextBox28.Text = "" Then
            TextBox28.Text = "Search"
        End If
    End Sub


    Private Sub TextBox28_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox28.KeyDown
        If e.KeyCode = Keys.Enter Then
            SearchText()
        End If
    End Sub


    Private Sub TextBox28_Click(sender As Object, e As EventArgs) Handles TextBox28.Click

        SearchText()

    End Sub


    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles btnDecryptRegistry.Click

        btnDecryptRegistry.Enabled = False


        RichTextBox2.Clear()

        On Error Resume Next
        Dim N As RegistryKey
        Dim FILE_NAME As String = System.IO.Path.GetTempPath & "\ODRegDecrypted.txt"
        Dim ZX As String = Reg("SOFTWARE\Class IT") & vbNewLine
        ZX = ZX & Reg("SOFTWARE\OptimumDesk") & vbNewLine
        ZX = ZX & Reg("SOFTWARE\Easee Control") & vbNewLine
        ZX = ZX & Reg("SOFTWARE\PCMATIC") & vbNewLine
        Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
        objWriter.Write(ZX)
        objWriter.Close()

        Dim reader As TextReader = New StreamReader(FILE_NAME)
        RichTextBox2.Text = reader.ReadToEnd()
        reader.Close()



        btnDecryptRegistry.Enabled = True



    End Sub



    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxUS2.CheckedChanged

        If CheckBoxUS2.Checked = False Then
            CheckBoxUS2.ForeColor = Color.Tan
            CheckBoxEU2.ForeColor = SystemColors.ActiveCaption
            CheckBoxEU2.Checked = True
            SelectRegion("EU")
        Else
            CheckBoxEU2.Checked = False
            CheckBoxUS2.ForeColor = SystemColors.ActiveCaption
            CheckBoxEU2.ForeColor = Color.Tan
            SelectRegion("US")
        End If

        selectAgent(ComboBoxCompany.Text)
    End Sub

    Private Sub CheckBox6_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBoxEU2.CheckedChanged

        If CheckBoxEU2.Checked = False Then
            CheckBoxUS2.Checked = True
            CheckBoxUS2.ForeColor = SystemColors.ActiveCaption
            CheckBoxEU2.ForeColor = Color.Tan
            SelectRegion("US")
        Else
            CheckBoxUS2.Checked = False
            'CheckBoxUS2.ForeColor =
            'CheckBoxEU2.ForeColor = Color.Tan
            SelectRegion("EU")
        End If

        frameWork = ComboBox_FrameWork.Text
        selectAgent(ComboBoxCompany.Text)
    End Sub



    Private Sub Toggle1_Load_1(sender As Object, e As EventArgs) Handles Toggle1.Load

        Toggle1.Checked = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.MouseClick


    End Sub

    Private Sub CheckBox3_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged


        If CheckBox3.Checked = True Then
            Toggle1.Checked = False
        End If
    End Sub

    Private Sub PictureBox21_Enter(sender As Object, e As EventArgs) Handles PictureBox21.MouseHover, PictureBox25.MouseHover, PictureBox24.MouseHover
        PictureBox21.BorderStyle = BorderStyle.FixedSingle

    End Sub

    Private Sub PictureBox21_Leave(sender As Object, e As EventArgs) Handles PictureBox21.MouseLeave, PictureBox25.MouseLeave, PictureBox24.MouseLeave
        PictureBox21.BorderStyle = BorderStyle.None
    End Sub

    Private Sub PictureBox23_Enter(sender As Object, e As EventArgs) Handles PictureBox23.MouseHover
        PictureBox23.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.MouseLeave
        PictureBox23.BorderStyle = BorderStyle.None
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Button24.Enabled = False
        InsertCustomerInfo(TextBox13.Text, TextBox27.Text, TextBox25.Text, TextBox25.Text, "Password")
        RestartAgent()
        getCustomerInfo()
        ChangeOverViewPnl(PanelMainBox)
        Command.SetMainPanel(PanelMainBox)
        SetBannerPanel(Panel_INFO, IconButton1)

        Button24.Enabled = True
    End Sub



    Private Sub Panel12_Paint(sender As Object, e As PaintEventArgs) Handles Panel12.Paint

        RoundedCorner(Panel12, 15)
    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

        RoundedCorner(Panel7, 15)
    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint

        RoundedCorner(Panel8, 15)
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint
        RoundedCorner(Panel4, 15)
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint
        RoundedCorner(Panel5, 15)
    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint
        RoundedCorner(Panel6, 15)
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint
        RoundedCorner(Panel3, 15)
    End Sub

    Private Sub Panel11_Paint(sender As Object, e As PaintEventArgs) Handles Panel11.Paint
        RoundedCorner(Panel11, 15)
    End Sub

    Private Sub Panel10_Paint(sender As Object, e As PaintEventArgs) Handles Panel10.Paint
        RoundedCorner(Panel10, 15)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

    End Sub

    Private Sub Timer_MoreDetails_Tick(sender As Object, e As EventArgs) Handles Timer_MoreDetails.Tick

        Panel16.Hide()

        If Panel16.Size = Panel16.MinimumSize Then
            Panel16.Location = New Point(52, 20)
            Panel16.Size = Panel16.MaximumSize
            Label6.Text = "View Less"
            Panel16.BringToFront()
        Else
            Panel16.Location = New Point(52, 253)
            Panel16.Size = Panel16.MinimumSize
            Label6.Text = "View More"
        End If

        Panel16.Show()

        Timer_MoreDetails.Stop()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Timer_MoreDetails.Start()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim fromAddress As New MailAddress("adam.intop.tech@gmail.com", "Adam Intop")
        Dim toAddress As New MailAddress("cs_stk@yahoo.com", "Claudiu Florea")
        Dim fromPassword As String = "AdamIntopBestTech"
        Dim subject As String = "Subject"
        Dim body As String = "Body Text"

        Dim smtpClient As New SmtpClient()
        smtpClient.Host = "smtp.gmail.com"
        smtpClient.Port = 465
        smtpClient.EnableSsl = True

        ' Add the following two lines to authenticate with Gmail
        smtpClient.UseDefaultCredentials = False
        smtpClient.Credentials = New NetworkCredential(fromAddress.Address, fromPassword)
        ' Add the following line to avoid the "secure connection" error message
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3

        Dim message As New MailMessage(fromAddress, toAddress)
        message.Subject = subject
        message.Body = body
        smtpClient.Send(message)



        'Try
        '    Dim SmtpServer As New SmtpClient()
        '    Dim mail As New MailMessage()
        '    SmtpServer.Host = "smtp.gmail.com"
        '    SmtpServer.Port = 587
        '    SmtpServer.UseDefaultCredentials = False
        '    SmtpServer.Credentials = New Net.NetworkCredential("adam.intop.tech@gmail.com", "AdamIntopBestTech")
        '    SmtpServer.EnableSsl = True
        '    mail.From = New MailAddress("adam.intop.tech@gmail.com")
        '    mail.To.Add(TextBox57.Text)
        '    mail.Subject = "Test Mail"
        '    mail.Body = "This is a test email sent using VB.NET"
        '    SmtpServer.Send(mail)
        '    MsgBox("Mail Sent")
        'Catch ex As Exception
        '    MsgBox(ex.ToString())
        '    RichTextBox2.Text = ex.ToString()
        'End Try
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.Click
        ComboBox3.DroppedDown = True
    End Sub

    Private Sub Button22_Click_2(sender As Object, e As EventArgs) Handles Button22.Click

    End Sub

    Public Sub RestartAgent()
        Try
            Dim exePaths As New Dictionary(Of String, String)
            exePaths.Add("easeecontrol", Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "EaseeControl\EaseeControl.exe"))
            exePaths.Add("optimumdesk", Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "OptimumDesk\OptimumDesk.exe"))
            ' exePaths.Add("exe3", "C:\path\to\exe3.exe")
            'exePaths.Add("exe4", "C:\path\to\exe4.exe")

            Dim processes() As Process = Process.GetProcesses()

            For Each process As Process In processes
                Dim processName As String = process.ProcessName.ToLower()

                If exePaths.ContainsKey(processName) Then
                    Dim exePath As String = exePaths(processName)
                    process.Kill()
                    System.Threading.Thread.Sleep(1000)
                    Process.Start(exePath)
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Button25.Enabled = False
        RestartAgent()
        Button25.Enabled = True
    End Sub

    Private Shared WingetExe As String = "winget.exe"


    Public Shared Function InstallProgram(ByVal programName As String, ByRef outputLabel As Label) As Boolean

        Dim psi As New ProcessStartInfo()
        psi.FileName = "winget.exe"
        psi.Arguments = "install " + programName

        Dim process As Process = Process.Start(psi)

        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.UseShellExecute = False
        process.StartInfo.CreateNoWindow = False
        process.WaitForExit()

        'Dim output As String = process.StandardOutput.ReadToEnd()



        'outputLabel.Text = output


    End Function

    Public Shared Function CheckForUpdates(ByVal programName As String, ByRef outputLabel As Label) As Boolean

    End Function

    Private Sub Panel14_Paint(sender As Object, e As PaintEventArgs) Handles Panel14.Paint
        Dim bottomPen As Pen = New Pen(Color.Gray, 1)
        e.Graphics.DrawLine(bottomPen, 0, Panel14.Height - 1, Panel14.Width, Panel14.Height - 1)
    End Sub

    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs) Handles Panel9.Paint
        Dim bottomPen As Pen = New Pen(Color.Gray, 1)
        e.Graphics.DrawLine(bottomPen, 0, Panel9.Height - 1, Panel9.Width, Panel9.Height - 1)
    End Sub

    Private Sub Panel15_Paint(sender As Object, e As PaintEventArgs) Handles Panel15.Paint
        Dim bottomPen As Pen = New Pen(Color.Gray, 1)
        e.Graphics.DrawLine(bottomPen, 0, Panel15.Height - 1, Panel15.Width, Panel15.Height - 1)
    End Sub

    Private Sub PanelInstallNewAgent_Paint(sender As Object, e As PaintEventArgs) Handles PanelInstallNewAgent.Paint

    End Sub

    Private Sub PictureBox41_Enter(sender As Object, e As EventArgs) Handles PictureBox41.MouseEnter
        PictureBox41.Width = PictureBox41.Width + 2
        PictureBox41.Height = PictureBox41.Height + 2
    End Sub


    Private Sub PictureBox41_Leave(sender As Object, e As EventArgs) Handles PictureBox41.MouseLeave
        PictureBox41.Width = PictureBox41.Width - 2
        PictureBox41.Height = PictureBox41.Height - 2
    End Sub

    Private Sub PictureBox40_Enter(sender As Object, e As EventArgs) Handles PictureBox40.MouseEnter
        PictureBox40.Width = PictureBox40.Width + 2
        PictureBox40.Height = PictureBox40.Height + 2
    End Sub
    Private Sub PictureBox40_Leave(sender As Object, e As EventArgs) Handles PictureBox40.MouseLeave
        PictureBox40.Width = PictureBox40.Width - 2
        PictureBox40.Height = PictureBox40.Height - 2
    End Sub

    Private Sub PictureBox41_Click(sender As Object, e As EventArgs) Handles PictureBox41.Click
        ChangeMainAgent()
    End Sub

    Private Sub PictureBox40_Click(sender As Object, e As EventArgs) Handles PictureBox40.Click
        ChangeMainAgent()
    End Sub
End Class
