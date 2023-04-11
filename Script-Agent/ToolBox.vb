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
Imports System.Windows.Input

Public Class ToolBox

    Public customer_name As String
    Public customer_lastname As String
    Public customer_email As String
    Public returnID As String

    Public mainCompanyID As String
    Public mainCompanyName As String
    Public last_used_panel As Panel
    Public last_used_button As Button


    Public isInstallRunning As Boolean = False
    Public isAgentInstalled As Boolean = False
    Public BetaInstall As Boolean
    Public LastUsedDownloadLink As String



    Public agentInstalled As CompanyDetails
    Public agentToInstall As CompanyDetails
    Public companyDetailsList As New List(Of CompanyDetails)




    Public ec_path_default = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "EaseeControl\")
    Public ec_tech_default = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "TechServices\")
    Public od_path_default = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "OptimumDesk\")



    'Log files
    Public ODServiceLog As String
    Public OptimumDeskLog As String
    Public EaseeControlLog As String
    Public ModulesLog As String
    Public RegistryLog


    Public ODServiceLog_RAW As String
    Public OptimumDeskLog_RAW As String
    Public EaseeControlLog_RAW As String
    Public ModulesLog_RAW As String
    Public RegistryLog_RAW





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

    Public Sub ReadEventLog()

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

                        ' Add entry to ListView with checkbox
                        eventCntr += 1
                        Label105.Text = "Events found: " & eventCntr
                        Dim item As New ListViewItem(eventCntr.ToString())

                        item.SubItems.Add(applicationName)
                        item.SubItems.Add(eventLogEntry.EntryType.ToString)
                        item.SubItems.Add(eventLogEntry.TimeGenerated.ToString)
                        item.SubItems.Add(eventLogEntry.Message.ToString)
                        item.SubItems.Add(eventLogEntry.MachineName.ToString)
                        item.SubItems.Add(eventLogEntry.Source.ToString)
                        item.SubItems.Add(eventLogEntry.UserName.ToString)
                        item.SubItems.Add(eventLogEntry.EventID.ToString)

                        ' Set the Checked property of the ListViewItem to True to show the checkbox on the right
                        item.Checked = True

                        ListView1.Items.Add(item)
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

        Try
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
        Catch ex As Exception

        End Try
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
        Public working_folder_od As String
        Public working_folder_ec As String
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
        Dim agent As New StructuresModule.AgentData

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
        Dim searchTexts As String() = {"ClientID : ", "GUID : ", "deviceId : ", "ForceVer : ", "API_Server : ", "Download_Server : ", "Socket_Server : ", "Socket_Server_Port : "}

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
                        Case "ForceVer : "
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

        If agent.companyId = Label38.Text Then
            TextBox14.Text = agent.GUID
            TextBox16.Text = agent.deviceId
            TextBox15.Text = agent.agentVersion
            TextBox7.Text = agent.DeliveryServer
            TextBox9.Text = agent.Socket_Server
            TextBox10.Text = agent.Socket_Server_Port
            TextBox13.Text = agent.companyId
        Else
            TextBox14.Text = ""
            TextBox16.Text = ""
            TextBox15.Text = ""
            TextBox7.Text = ""
            TextBox9.Text = ""
            TextBox10.Text = ""
            TextBox13.Text = ""
        End If
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

    Public Sub ToolTip(title As String, msg As String, control As Control)

        Dim tt As New ToolTip
        tt.ToolTipTitle = title
        tt.ToolTipIcon = ToolTipIcon.Info
        tt.UseFading = True
        tt.UseAnimation = True
        tt.IsBalloon = True
        tt.ShowAlways = True
        tt.AutoPopDelay = 5000
        tt.InitialDelay = 1000
        tt.ReshowDelay = 100
        tt.SetToolTip(control, msg)


    End Sub


    Private Sub ToolBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        If customer_email IsNot Nothing AndAlso customer_name IsNot Nothing AndAlso customer_lastname IsNot Nothing Then
            'Top
            tbEmail.Text = customer_email
            tbName.Text = customer_name & " " & customer_lastname
            'Home Left side
            TextBoxH_Name.Text = customer_name
            TextBoxH_LastName.Text = customer_lastname
            TextBoxH_Email.Text = customer_email
            'Advanced settings
            TextBox_FirstName.Text = customer_name
            TextBox_LastName.Text = customer_lastname
            TextBox_EmailAddress.Text = customer_email
        End If


        RoundedCorner(Panel17, 10)
        RoundedCorner(Panel18, 10)
        RoundedCorner(Panel19, 10)
        RoundedCorner(Panel20, 10)
        RoundedCorner(Panel21, 10)
        RoundedCorner(Panel22, 10)



        RoundedCorner(Button21, 10)
        RoundedCorner(Button28, 10)
        RoundedCorner(Button17, 10)
        RoundedCorner(Button31, 10)
        RoundedCorner(Button16, 10)
        RoundedCorner(Button29, 10)
        RoundedCorner(Button26, 10)
        RoundedCorner(Button30, 10)
        RoundedCorner(Button12, 10)
        RoundedCorner(Button14, 10)


        RoundedCorner(Button24, 10)
        RoundedCorner(Button11, 10)
        RoundedCorner(Button25, 10)
        RoundedCorner(Button10, 10)




        ' System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False



        Dim aTest As New System.Threading.Thread(AddressOf SearchForLogs)
        aTest.Start()



        RoundedCorner(Button2, 9)
        RoundedCorner(Button7, 9)
        RoundedCorner(Button10, 3)

        RoundedCorner(Button5, 5)
        RoundedCorner(Button6, 5)
        RoundedCorner(Button8, 5)
        RoundedCorner(Button13, 5)
        RoundedCorner(TextBoxH_Name, 5)
        RoundedCorner(TextBoxH_LastName, 5)
        RoundedCorner(TextBoxH_Email, 5)
        RoundedCorner(TextBox_FirstName, 5)
        RoundedCorner(TextBox_LastName, 5)
        RoundedCorner(TextBox_EmailAddress, 5)
        RoundedCorner(Btn_StartInstall, 5)
        RoundedCorner(Button20, 5)
        RoundedCorner(Button3, 5)
        RoundedCorner(Button4, 5)
        RoundedCorner(Button22, 5)
        'RoundedCorner(TextBox13, 5)

        RoundedCorner(TextBox2, 15)
        RoundedCorner(TextBox7, 5)
        RoundedCorner(TextBox10, 5)
        RoundedCorner(TextBox24, 5)



        SelectRegion("US")


        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False

        Dim EventThread As New System.Threading.Thread(AddressOf ReadEventLog)
        EventThread.Start()


        'LoadMiniDetaills()
        getUserFromAgent()



        Panel2.Size = Panel2.MaximumSize
        PanelMultiAgent.Size = PanelMultiAgent.MinimumSize

        'Label105.Hide()
        Me.Show()

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


    Public Function CreateDownloadLink(ID As String) As String

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


    Public Function ReadRegData(valueName As String)


        Dim regKey As Microsoft.Win32.RegistryKey
        regKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\ODToolbox")
        If regKey IsNot Nothing Then
            Dim value As Object = regKey.GetValue(valueName)
            regKey.Close()
            Return value
        Else
            Return False
        End If

    End Function

    Public Sub SaveRegData(keyName As String, KeyVal As String)

        Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("Software\ODToolbox")
        key.SetValue(keyName, KeyVal, Microsoft.Win32.RegistryValueKind.String)
        key.Close()
    End Sub

    Public Sub DownloadSetup(LinkAddress As String)

        isInstallRunning = True
        CircularProgressBar2.Value = 0
        CircularProgressBar2.Text = "0%"
        PictureBox22.Hide()
        CircularProgressBar2.Show()
        TextBoxCName.Text = ComboBoxCompany.Text
        Command.SetMainPanel(PanelLoading)


        If System.IO.File.Exists(My.Application.Info.DirectoryPath + "\Setup.exe") = True Then
            My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath + "\Setup.exe")
        End If

        Dim client As New WebClient
        client.DownloadFileAsync(New System.Uri(LinkAddress), My.Application.Info.DirectoryPath + "\setup.exe")
        AddHandler client.DownloadProgressChanged, AddressOf DownloadProgressChanged
        AddHandler client.DownloadFileCompleted, AddressOf DownloadFileCompleted

    End Sub


    Private Sub Btn_StartInstall_Click(sender As Object, e As EventArgs) Handles Btn_StartInstall.Click
        Try
            If isInstallRunning = False Then
                selectAgent(ComboBoxCompany.Text)

                If BetaInstall = True Then
                    PowerShellCmd("Reg add HKLM\Software\OptimumDesk /v Beta /t reg_sz /d Beta /f")
                Else
                    PowerShellCmd("Reg delete HKLM\Software\OptimumDesk /v Beta /f")
                End If
                CheckBox1.Checked = False


                If Decrypt(ReadRegData("51g+obrBZbcPu/NQN1jr8A==")) <> agentToInstall.ftp Then
                    DownloadSetup(agentToInstall.ftp)
                Else
                    If System.IO.File.Exists(My.Application.Info.DirectoryPath + "\Setup.exe") = True Then
                        Dim test As New System.Threading.Thread(AddressOf TEST_TEST)
                        test.Start()
                    Else
                        DownloadSetup(agentToInstall.ftp)
                    End If
                End If
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
            TextBox_InstallStep.Text = "Downloading agent setup " & megabytes1 & "/" & megabytes2 & " mb"
        Catch ex As Exception
            Frame.logger(ex.Message + "Install", "Error")
        End Try
    End Sub



    Public Sub DownloadFileCompleted(sender As Object, e As AsyncCompletedEventArgs)

        SaveRegData("51g+obrBZbcPu/NQN1jr8A==", Encrypt(agentToInstall.ftp))
        Dim test As New System.Threading.Thread(AddressOf TEST_TEST)
        test.Start()

    End Sub


    Sub TEST_TEST()

        CircularProgressBar2.Hide()
        PictureBox22.Location = CircularProgressBar2.Location
        PictureBox22.Show()
        TextBox_InstallStep.Text = "Installing setup"
        TextBoxCName.Text = ComboBoxCompany.Text
        Command.SetMainPanel(PanelLoading)


        If Toggle_ApplyCustInfo.Checked = True Then
            InsertCustomerInfo(agentToInstall.company_id, TextBox_EmailAddress.Text, TextBox_FirstName.Text, TextBox_LastName.Text, Nothing)
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



        Do Until getUserFromAgent()
            Thread.Sleep(1000)
        Loop


        Command.SetMainPanel(PanelMainBox)


        getUserFromAgent()
        SetBannerPanel(Panel_INFO, IconButton1)
        Me.Refresh()
        Me.getID()
        Me.LoadMiniDetaills()

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
            BetaInstall = True
            TextBox_Server.Text = "BETA"
        Else
            BetaInstall = False
            TextBox_Server.Text = "LIVE"
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

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        SetBannerPanel(Panel_INFO, IconButton1)
    End Sub


    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        SetBannerPanel(PnlLogs, IconButton4)
        SearchForLogs()
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click

        SetBannerPanel(PanelInstallNewAgent, IconButton5)

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

    Public Function PDA(ByVal pp As String, ByVal pi As String, ByVal value_data As String) As String
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
    Public Function valuePE(ByVal value As String, ByVal expectedLength As Integer) As Byte()
        Dim temp As Byte() = Encoding.ASCII.GetBytes(value)

        If temp.Length = expectedLength Then
            Return temp
        End If

        Dim ret As Byte() = New Byte(expectedLength - 1) {}
        Buffer.BlockCopy(temp, 0, ret, 0, Math.Min(temp.Length, expectedLength))
        Return ret
    End Function

    Public Function PEA(ByVal value_data As String, ByVal pp As String, ByVal pi As String) As String
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

    Private Sub TextBox4_TextClick(sender As Object, e As EventArgs) Handles TextBox_FirstName.Click, TextBoxH_Name.Click
        sender.Select(0, sender.TextLength)
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox_LastName.Click, TextBoxH_LastName.Click
        sender.Select(0, sender.TextLength)
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox_EmailAddress.Click, TextBoxH_Email.Click
        sender.Select(0, sender.TextLength)
    End Sub


    'Public Sub Uninstall()
    '    Try
    '        Dim foo As New System.Diagnostics.Process
    '        foo.StartInfo.FileName = "taskkill"
    '        foo.StartInfo.UseShellExecute = True
    '        foo.StartInfo.Arguments = " /IM odservice.exe /F"
    '        foo.StartInfo.CreateNoWindow = True
    '        foo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
    '        foo.Start()
    '        foo.WaitForExit(1000 * 3)
    '        foo.Dispose()
    '    Catch
    '    End Try
    '    Try
    '        Dim foo As New System.Diagnostics.Process
    '        foo.StartInfo.FileName = "taskkill"
    '        foo.StartInfo.UseShellExecute = True
    '        foo.StartInfo.Arguments = " /IM updatermonitor.exe /F"
    '        foo.StartInfo.CreateNoWindow = True
    '        foo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
    '        foo.Start()
    '        foo.WaitForExit(1000 * 3)
    '        foo.Dispose()
    '    Catch
    '    End Try
    '    Try
    '        Dim foo As New System.Diagnostics.Process
    '        foo.StartInfo.FileName = "taskkill"
    '        foo.StartInfo.UseShellExecute = True
    '        foo.StartInfo.Arguments = " /IM optimumdesk.exe /F"
    '        foo.StartInfo.CreateNoWindow = True
    '        foo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
    '        foo.Start()
    '        foo.WaitForExit(1000 * 3)
    '        foo.Dispose()
    '    Catch
    '    End Try
    '    Try
    '        Dim ODinstallPath = If(Environment.GetEnvironmentVariable("PROGRAMFILES(X86)"), Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)) & "\Common Files\Updater\"
    '        Dim foo As New System.Diagnostics.Process
    '        foo.StartInfo.FileName = ODinstallPath & "updateservice.exe"
    '        foo.StartInfo.WorkingDirectory = ODinstallPath
    '        foo.StartInfo.UseShellExecute = True
    '        foo.StartInfo.Arguments = "-911"
    '        foo.StartInfo.CreateNoWindow = True
    '        foo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
    '        foo.Start()
    '        foo.WaitForExit(1000 * 3)
    '        foo.Dispose()
    '    Catch
    '    End Try
    '    Try
    '        Dim ODinstallPath = If(Environment.GetEnvironmentVariable("PROGRAMFILES(X86)"), Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)) & "\OptimumDesk\"
    '        Dim foo As New System.Diagnostics.Process
    '        foo.StartInfo.FileName = ODinstallPath & "odservice.exe"
    '        foo.StartInfo.WorkingDirectory = ODinstallPath
    '        foo.StartInfo.UseShellExecute = True
    '        foo.StartInfo.Arguments = "-911"
    '        foo.StartInfo.CreateNoWindow = True
    '        foo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
    '        foo.Start()
    '        foo.WaitForExit(1000 * 3)
    '        foo.Dispose()
    '    Catch
    '    End Try

    '    Try
    '        Dim foo As New System.Diagnostics.Process
    '        foo.StartInfo.FileName = "taskkill"
    '        foo.StartInfo.UseShellExecute = True
    '        foo.StartInfo.Arguments = " /IM odservice.exe /F"
    '        foo.StartInfo.CreateNoWindow = True
    '        foo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
    '        foo.Start()
    '        foo.WaitForExit(1000 * 3)
    '        foo.Dispose()
    '    Catch
    '    End Try
    '    Try
    '        Dim foo As New System.Diagnostics.Process
    '        foo.StartInfo.FileName = "sc"
    '        foo.StartInfo.WorkingDirectory = "delete odservice"
    '        foo.StartInfo.UseShellExecute = True
    '        foo.StartInfo.Arguments = "-911"
    '        foo.StartInfo.CreateNoWindow = True
    '        foo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
    '        foo.Start()
    '        foo.WaitForExit(1000 * 3)
    '        foo.Dispose()
    '    Catch
    '    End Try

    '    Try
    '        Dim foo As New System.Diagnostics.Process
    '        foo.StartInfo.FileName = "taskkill"
    '        foo.StartInfo.UseShellExecute = True
    '        foo.StartInfo.Arguments = " /IM ScreenConnect.ClientService.exe /F"
    '        foo.StartInfo.CreateNoWindow = True
    '        foo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
    '        foo.Start()
    '        foo.WaitForExit(1000 * 3)
    '        foo.Dispose()
    '    Catch
    '    End Try
    '    Try
    '        Dim foo As New System.Diagnostics.Process
    '        foo.StartInfo.FileName = "taskkill"
    '        foo.StartInfo.UseShellExecute = True
    '        foo.StartInfo.Arguments = " /IM ScreenConnect.WindowsClient.exe /F"
    '        foo.StartInfo.CreateNoWindow = True
    '        foo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
    '        foo.Start()
    '        foo.WaitForExit(1000 * 3)
    '        foo.Dispose()
    '    Catch
    '    End Try
    '    Try
    '        Dim foo As New System.Diagnostics.Process
    '        foo.StartInfo.FileName = "taskkill"
    '        foo.StartInfo.UseShellExecute = True
    '        foo.StartInfo.Arguments = " /IM updateservice.exe /F"
    '        foo.StartInfo.CreateNoWindow = True
    '        foo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
    '        foo.Start()
    '        foo.WaitForExit(1000 * 3)
    '        foo.Dispose()
    '    Catch
    '    End Try
    '    Try
    '        Dim foo As New System.Diagnostics.Process
    '        foo.StartInfo.FileName = "sc"
    '        foo.StartInfo.WorkingDirectory = "delete updaterservice"
    '        foo.StartInfo.UseShellExecute = True
    '        foo.StartInfo.Arguments = "-911"
    '        foo.StartInfo.CreateNoWindow = True
    '        foo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
    '        foo.Start()
    '        foo.WaitForExit(1000 * 3)
    '        foo.Dispose()
    '    Catch
    '    End Try

    '    Try
    '        Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree).DeleteValue("OptimumDesk", False)
    '    Catch
    '    End Try
    '    Try
    '        Registry.LocalMachine.OpenSubKey("SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Run", Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree).DeleteValue("OptimumDesk", False)
    '    Catch
    '    End Try
    '    Try
    '        Registry.LocalMachine.OpenSubKey("Software\Class IT")
    '    Catch
    '    End Try
    '    Try
    '        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & " (x86)\OptimumDesk"
    '        System.IO.Directory.Delete(path, True)
    '    Catch
    '    End Try
    '    Try
    '        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\OptimumDesk"
    '        System.IO.Directory.Delete(path, True)
    '    Catch
    '    End Try
    '    Try
    '        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & " (x86)\Common Files\Updater"
    '        System.IO.Directory.Delete(path, True)
    '    Catch
    '    End Try
    '    Try
    '        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\Common Files\Updater"
    '        System.IO.Directory.Delete(path, True)
    '    Catch
    '    End Try


    '    Try
    '        Dim EcInstallPath = If(Environment.GetEnvironmentVariable("PROGRAMFILES(X86)"), Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)) & "\EaseeControl\Uninstallers\"
    '        Dim foo As New System.Diagnostics.Process
    '        foo.StartInfo.FileName = EcInstallPath & "EaseeControl - uninstall.exe"
    '        foo.StartInfo.WorkingDirectory = EcInstallPath
    '        foo.StartInfo.UseShellExecute = True
    '        foo.StartInfo.Arguments = "/S /silent /verysilent /suppressmsgboxes"
    '        foo.StartInfo.CreateNoWindow = True
    '        foo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
    '        foo.Start()
    '        foo.WaitForExit(1000 * 3)
    '        foo.Dispose()
    '    Catch
    '    End Try

    '    Try
    '        Dim TechServicesPath = If(Environment.GetEnvironmentVariable("PROGRAMFILES(X86)"), Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)) & "\TechServices\Uninstallers\"
    '        Dim foo As New System.Diagnostics.Process
    '        foo.StartInfo.FileName = TechServicesPath & "TechServices - uninstall.exe"
    '        foo.StartInfo.WorkingDirectory = TechServicesPath
    '        foo.StartInfo.UseShellExecute = True
    '        foo.StartInfo.Arguments = "/S /silent /verysilent /suppressmsgboxes"
    '        foo.StartInfo.CreateNoWindow = True
    '        foo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
    '        foo.Start()
    '        foo.WaitForExit(1000 * 3)
    '        foo.Dispose()
    '    Catch
    '    End Try


    '    Try
    '        Dim TrueInstallPath = If(Environment.GetEnvironmentVariable("PROGRAMFILES(X86)"), Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)) & "\True Solutions\Uninstallers\"
    '        Dim foo As New System.Diagnostics.Process
    '        foo.StartInfo.FileName = TrueInstallPath & "True Solutions - uninstall.exe"
    '        foo.StartInfo.WorkingDirectory = TrueInstallPath
    '        foo.StartInfo.UseShellExecute = True
    '        foo.StartInfo.Arguments = "/S /silent /verysilent /suppressmsgboxes"
    '        foo.StartInfo.CreateNoWindow = True
    '        foo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
    '        foo.Start()
    '        foo.WaitForExit(1000 * 3)
    '        foo.Dispose()
    '    Catch
    '    End Try

    '    Try
    '        Dim YourHelpDeskHQ = If(Environment.GetEnvironmentVariable("PROGRAMFILES(X86)"), Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)) & "\YourHelpDeskHQ\Uninstallers\"
    '        Dim foo As New System.Diagnostics.Process
    '        foo.StartInfo.FileName = YourHelpDeskHQ & "YourHelpDeskHQ - uninstall.exe"
    '        foo.StartInfo.WorkingDirectory = YourHelpDeskHQ
    '        foo.StartInfo.UseShellExecute = True
    '        foo.StartInfo.Arguments = "/S /silent /verysilent /suppressmsgboxes"
    '        foo.StartInfo.CreateNoWindow = True
    '        foo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
    '        foo.Start()
    '        foo.WaitForExit(1000 * 3)
    '        foo.Dispose()
    '    Catch
    '    End Try

    '    'PcMatic Uninstall
    '    Try
    '        Dim PcMatic = If(Environment.GetEnvironmentVariable("PROGRAMFILES(X86)"), Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)) & "\PCMATIC\Uninstallers\"
    '        Dim foo As New System.Diagnostics.Process
    '        foo.StartInfo.FileName = PcMatic & "PCMATIC - uninstall.exe"
    '        foo.StartInfo.WorkingDirectory = PcMatic
    '        foo.StartInfo.UseShellExecute = True
    '        foo.StartInfo.Arguments = "/S /silent /verysilent /suppressmsgboxes"
    '        foo.StartInfo.CreateNoWindow = True
    '        foo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
    '        foo.Start()
    '        foo.WaitForExit(1000 * 3)
    '        foo.Dispose()
    '    Catch
    '    End Try

    '    'EaseeAccess Uninstall
    '    Try
    '        Dim EaseeAccess = If(Environment.GetEnvironmentVariable("PROGRAMFILES(X86)"), Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)) & "\EaseeAccess\Uninstall\"
    '        Dim foo As New System.Diagnostics.Process
    '        foo.StartInfo.FileName = EaseeAccess & "unins000.exe"
    '        foo.StartInfo.WorkingDirectory = EaseeAccess
    '        foo.StartInfo.UseShellExecute = True
    '        foo.StartInfo.Arguments = "/verysilent /suppressmsgboxes"
    '        foo.StartInfo.CreateNoWindow = True
    '        foo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
    '        foo.Start()
    '        foo.WaitForExit(1000 * 3)
    '        foo.Dispose()
    '    Catch
    '    End Try


    '    'remove Registry
    '    If CheckBox4.Checked = True Then
    '        Try
    '            PowerShellCmd("reg delete 'HKLM\SOFTWARE\Class IT' /f")
    '            PowerShellCmd("reg delete 'HKLM\SOFTWARE\Easee Control' /f")
    '            PowerShellCmd("reg delete 'HKLM\SOFTWARE\PCMATIC' /f")
    '            PowerShellCmd("reg delete 'HKLM\SOFTWARE\TechServices' /f")
    '            PowerShellCmd("reg delete 'HKLM\SOFTWARE\OptimumDesk' /f")

    '            PowerShellCmd("schtasks /delete /tn 'EASetup' /f")
    '            PowerShellCmd("schtasks /delete /tn 'ECUnis' /f")
    '            PowerShellCmd("schtasks /delete /tn 'PC Matic' /f")
    '            PowerShellCmd("schtasks /delete /tn 'True Solutions' /f")
    '        Catch ex As Exception

    '        End Try
    '    End If


    'End Sub


    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Button11.Enabled = False

        Dim unins As New System.Threading.Thread(AddressOf Command.Uninstall)
        unins.Start()
        Frame.agentCount = 0
        isAgentInstalled = False
        PictureBox8.Image = agentToInstall.company_logo
        TextBox3.Text = agentToInstall.company_name
        TextBox31.Text = agentToInstall.company_id
        TextBox_AgentFrameWork.Text = ComboBox_FrameWork.Text
        Command.SetMainPanel(PanelInstallNewAgent)

        customer_lastname = Nothing
        customer_email = Nothing
        customer_name = Nothing

        Button11.Enabled = True

    End Sub



    Private Sub Button21_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TimerTopBannerInfoCheck_Tick(sender As Object, e As EventArgs)
        getUserFromAgent()
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

    Private Sub CheckBox3_Click(sender As Object, e As EventArgs) Handles CheckBox_CleanInstall.Click

        If CheckBox_CleanInstall.Checked = True Then
            TextBox_FirstName.Enabled = False
            TextBox_LastName.Enabled = False
            TextBox_EmailAddress.Enabled = False
            Toggle_ApplyCustInfo.Checked = False
            'Toggle_ApplyCustInfo.Enabled = False
        Else
            TextBox_FirstName.Enabled = True
            TextBox_LastName.Enabled = True
            TextBox_EmailAddress.Enabled = True
            Toggle_ApplyCustInfo.Checked = True
            'Toggle_ApplyCustInfo.Enabled = True
        End If
        Me.Refresh()
    End Sub




    Private Sub Toggle1_Load(sender As Object, e As EventArgs) Handles Toggle_ApplyCustInfo.CheckedChanged



        If Toggle_ApplyCustInfo.Checked = True Then

            TextBox_FirstName.Enabled = True
            TextBox_LastName.Enabled = True
            TextBox_EmailAddress.Enabled = True
            CheckBox_CleanInstall.Checked = False

        Else

            TextBox_FirstName.Enabled = False
            TextBox_LastName.Enabled = False
            TextBox_EmailAddress.Enabled = False
            CheckBox_CleanInstall.Checked = True
        End If




        'If Toggle1.Checked = True Then

        '    TextBox4.Enabled = False
        '    TextBox5.Enabled = False
        '    TextBox6.Enabled = False
        'Else
        '    CheckBox3.Checked = False
        '    TextBox4.Enabled = True
        '    TextBox5.Enabled = True
        '    TextBox6.Enabled = True
        'End If




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
            ' agentToInstall.agent_framework =
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


        Select Case companyID
            Case Module1.TechID
                If Module1.TechID = companyID Then
                    If System.IO.File.Exists(od_path_default & "OptimumDesk.exe") Or System.IO.File.Exists(ec_tech_default & "TechServices.exe") Then
                        agentInstalled.company_id = Module1.TechID
                        agentInstalled.company_name = "TechServices"
                        agentInstalled.company_logo = My.Resources.logoTech
                        agentInstalled.agent_region = "US"
                        agentInstalled.beta_version = TextBox_Server.Text
                        agentInstalled.agent_framework = "OD"

                        agentInstalled.file_location = od_path_default & "OptimumDesk.exe"
                        agentInstalled.working_folder_od = od_path_default
                        agentInstalled.working_folder_ec = ec_tech_default
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
                    If System.IO.File.Exists(od_path_default & "OptimumDesk.exe") Or System.IO.File.Exists(ec_path_default & "EaseeControl.exe") Then
                        agentInstalled.company_id = Module1.ClassITID
                        agentInstalled.company_name = "Class It Outsourcing"
                        agentInstalled.beta_version = TextBox_Server.Text
                        agentInstalled.company_logo = My.Resources.optimumdesk_logo
                        agentInstalled.agent_framework = "OD"
                        agentInstalled.agent_region = "EU"
                        agentInstalled.ftp = "https://updateor.optimumdesk.com/download/884c3b4485160e19f93ffe73cf719fa6b081b7a7/company/8511/setup.exe"
                        agentInstalled.file_location = od_path_default & "OptimumDesk.exe"
                        agentInstalled.working_folder_ec = ec_path_default
                        agentInstalled.working_folder_od = od_path_default
                        companyDetailsList.Add(agentInstalled)
                        Frame.agentExeFound = Frame.agentExeFound + 1
                    End If
                End If

            Case Module1.Class_IT_Home
                If System.IO.File.Exists(od_path_default & "OptimumDesk.exe") Or System.IO.File.Exists(ec_path_default & "EaseeControl.exe") Then
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
                If System.IO.File.Exists(Path.Combine(od_path_default & "OptimumDesk.exe") Or System.IO.File.Exists(ec_path_default & "EaseeControl.exe")) Then
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
                If System.IO.File.Exists(Path.Combine(od_path_default & "OptimumDesk.exe") Or System.IO.File.Exists(ec_path_default & "EaseeControl.exe")) Then
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


        LoadMiniDetaills()

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

                    mainCompanyID = company.company_id
                    mainCompanyName = company.company_name
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
            PanelMultiAgent.Height += 66
            If PanelMultiAgent.Size = PanelMultiAgent.MaximumSize Then
                isMenu1Collapsed = False
                PanelMultiAgent.BringToFront()
                Timer_MultiAgentDropDown.Stop()
            End If
        Else
            PanelMultiAgent.Width += 50
            PanelMultiAgent.Height -= 66
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



    'Private Sub Button12_Click(sender As Object, e As EventArgs)




    '    On Error Resume Next
    '    Dim N As RegistryKey
    '    Dim FILE_NAME As String = System.IO.Path.GetTempPath & "\ODRegDecrypted.txt"
    '    Dim ZX As String = Reg("SOFTWARE\Class IT") & vbNewLine
    '    ZX = ZX & Reg("SOFTWARE\OptimumDesk") & vbNewLine
    '    ZX = ZX & Reg("SOFTWARE\Easee Control") & vbNewLine
    '    ZX = ZX & Reg("SOFTWARE\PCMATIC") & vbNewLine
    '    Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
    '    objWriter.Write(ZX)
    '    objWriter.Close()

    '    Dim reader As TextReader = New StreamReader(FILE_NAME)

    '    reader.Close()



    '    btnDecryptRegistry.Enabled = True



    'End Sub



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



    Private Sub Toggle1_Load_1(sender As Object, e As EventArgs) Handles Toggle_ApplyCustInfo.Load

        LoadUserInfo()

        If customer_email IsNot Nothing AndAlso customer_lastname IsNot Nothing AndAlso customer_name IsNot Nothing Then
            Toggle_ApplyCustInfo.Checked = True
        Else
            Toggle_ApplyCustInfo.Checked = False
        End If




    End Sub



    Private Sub CheckBox3_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox_CleanInstall.CheckedChanged

        If CheckBox_CleanInstall.Checked = True Then
            Toggle_ApplyCustInfo.Checked = False
        Else
            Toggle_ApplyCustInfo.Checked = True
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
        InsertCustomerInfo(Label38.Text, TextBoxH_Email.Text, TextBoxH_Name.Text, TextBoxH_LastName.Text, Nothing)
        RestartAgent()
        getUserFromAgent()
        ChangeOverViewPnl(PanelMainBox)
        'Command.SetMainPanel(PanelMainBox)
        SetBannerPanel(Panel_INFO, IconButton1)

        Button24.Enabled = True
    End Sub

    Private Sub Panel12_Paint(sender As Object, e As PaintEventArgs) Handles Panel12.Paint
        RoundedCorner(Panel12, 10)
    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint
        RoundedCorner(Panel7, 10)
    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint
        RoundedCorner(Panel8, 10)
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint
        RoundedCorner(Panel4, 10)
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint
        RoundedCorner(Panel5, 10)
    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint
        RoundedCorner(Panel6, 10)
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint
        RoundedCorner(Panel3, 10)
    End Sub

    Private Sub Panel11_Paint(sender As Object, e As PaintEventArgs) Handles Panel11.Paint
        RoundedCorner(Panel11, 10)
    End Sub

    Private Sub Panel10_Paint(sender As Object, e As PaintEventArgs) Handles Panel10.Paint
        RoundedCorner(Panel10, 10)
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


    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Btn_SendMail.Click

        Dim Send As New System.Threading.Thread(AddressOf SendEmail)
        Send.Start()

    End Sub

    Public Sub RestartAgent()

        PowerShellCmd("Stop-Service -Name 'ODService'")
        PowerShellCmd("Stop-Service -Name 'UpdaterService'")
        PowerShellCmd("Stop-Service -Name 'ModuleServ'")
        PowerShellCmd("Taskkill /f /im Modules.exe")
        PowerShellCmd("Taskkill /f /im ModuleServ.exe")

        Try
            Dim exePaths As New Dictionary(Of String, String)
            exePaths.Add("easeecontrol", Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "EaseeControl\EaseeControl.exe"))
            exePaths.Add("optimumdesk", Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "OptimumDesk\OptimumDesk.exe"))
            exePaths.Add("pcmatic", Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "PCMATIC\PCMATIC.exe"))
            exePaths.Add("true", Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "True Solutions\True.exe"))
            exePaths.Add("techservices", Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "TechServices\TechServices.exe"))
            exePaths.Add("yourhelpdeskhq", Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "YourHelpDeskHQ\YourHelpDeskHQ.exe"))
            'exePaths.Add("exe4", "C:\path\to\exe4.exe")
            'exePaths.Add("exe4", "C:\path\to\exe4.exe")


            Dim processes() As Process = Process.GetProcesses()

            For Each process As Process In processes
                Dim processName As String = process.ProcessName.ToLower()

                If exePaths.ContainsKey(processName) Then
                    Dim exePath As String = exePaths(processName)
                    process.Kill()
                    Process.Start(exePath)
                End If
            Next
        Catch ex As Exception

        End Try

        PowerShellCmd("Start-Service -Name 'ODService'")
        PowerShellCmd("Start-Service -Name 'UpdaterService'")
        PowerShellCmd("Start-Service -Name 'ModuleServ'")
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Button25.Enabled = False
        RestartAgent()
        Button25.Enabled = True
    End Sub

    Private Sub Panel14_Paint(sender As Object, e As PaintEventArgs) Handles Panel14.Paint
        Dim bottomPen As Pen = New Pen(Color.Black, 1)
        e.Graphics.DrawLine(bottomPen, 0, Panel14.Height - 1, Panel14.Width, Panel14.Height - 1)
    End Sub

    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs) Handles Panel9.Paint
        Dim bottomPen As Pen = New Pen(Color.Black, 1)
        e.Graphics.DrawLine(bottomPen, 0, Panel9.Height - 1, Panel9.Width, Panel9.Height - 1)
    End Sub

    Private Sub Panel15_Paint(sender As Object, e As PaintEventArgs) Handles Panel15.Paint
        Dim bottomPen As Pen = New Pen(Color.Black, 1)
        e.Graphics.DrawLine(bottomPen, 0, Panel15.Height - 1, Panel15.Width, Panel15.Height - 1)
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

    Private Sub TextBox4_LostFocus(sender As Object, e As EventArgs) Handles TextBox_FirstName.LostFocus

        If TextBox_FirstName.Text = Nothing Or TextBox_FirstName.Text = " " Then
            TextBox_FirstName.Text = "First name"
        End If

    End Sub


    Private Sub TextBox4_GotFocus(sender As Object, e As EventArgs) Handles TextBox_FirstName.GotFocus

        If TextBox_FirstName.Text = "First name" Then
            TextBox_FirstName.Clear()
        End If
    End Sub

    Private Sub TextBox5_LostFocus(sender As Object, e As EventArgs) Handles TextBox_LastName.LostFocus

        If TextBox_LastName.Text = Nothing Or TextBox_LastName.Text = " " Then
            TextBox_LastName.Text = "Last name"
        End If
    End Sub

    Private Sub TextBox5_GetFocus(sender As Object, e As EventArgs) Handles TextBox_LastName.GotFocus

        If TextBox_LastName.Text = "Last name" Then
            TextBox_LastName.Clear()
        End If
    End Sub

    Private Sub TextBox6_LostFocus(sender As Object, e As EventArgs) Handles TextBox_EmailAddress.LostFocus
        If TextBox_EmailAddress.Text = Nothing Or TextBox_EmailAddress.Text = " " Then
            TextBox_EmailAddress.Text = "Email address"
        End If
    End Sub

    Private Sub TextBox6_GetFocus(sender As Object, e As EventArgs) Handles TextBox_EmailAddress.GotFocus
        If TextBox_EmailAddress.Text = "Email address" Then
            TextBox_EmailAddress.Clear()
        End If
    End Sub

    Private Sub PanelMultiAgent_Paint(sender As Object, e As PaintEventArgs) Handles PanelMultiAgent.Paint
        RoundedCorner(PanelMultiAgent, 10)
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Sub NewLog(title As String)
        Dim A As New LogView
        A.Text = title
        A.Show()
        Me.Invoke(Sub() Me.Focus())
    End Sub



    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles Button10.Click

        Button10.Enabled = False

        Dim hostsPath As String = "C:\Windows\System32\drivers\etc\hosts"

        If System.IO.File.Exists(hostsPath) Then
            Try
                Dim processInfo As New ProcessStartInfo("notepad.exe", hostsPath)
                Process.Start(processInfo)
            Catch ex As Exception
                MessageBox.Show("Error opening hosts file: " & ex.Message)
            End Try
        Else
            MsgBox("The hosts file does not exist.")
        End If

        Button10.Enabled = True

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Button7.Enabled = False
        PowerShellCmd("ipconfig /flushdns")
        Button7.Enabled = True
    End Sub

    Private Sub Button11_Hover(sender As Object, e As EventArgs) Handles Button11.MouseHover
        ToolTip("Uninstall", "Remove installed agent", Button11)
    End Sub

    Private Sub CheckBox4_Hover(sender As Object, e As EventArgs) Handles CheckBox4.MouseHover
        ToolTip("Clear registry", "Remove any registry info left behind by the agent", CheckBox4)
    End Sub

    Private Sub Button25_Hover(sender As Object, e As EventArgs) Handles Button25.MouseHover
        ToolTip("Restart agent", "Restart including any processes and services associated with this agent", Button25)
    End Sub

    Private Sub Button7_Hover(sender As Object, e As EventArgs) Handles Button7.MouseHover

        ToolTip("Flush DNS", "ipconfig /flushdns", Button7)
    End Sub

    Private Sub Button10_Hover(sender As Object, e As EventArgs) Handles Button10.MouseHover
        ToolTip("Open hosts file", "found at C:\Windows\System32\drivers\etc\hosts", Button10)
    End Sub

    Private Sub PictureBox29_Click(sender As Object, e As EventArgs) Handles PictureBox29.MouseHover
        ToolTip("Skip the customer legislation step", Nothing, PictureBox29)
    End Sub

    Private Sub PictureBox28_Hover(sender As Object, e As EventArgs) Handles PictureBox28.MouseHover
        ToolTip("Clean Install", "Remove any previously used data or files", PictureBox28)
    End Sub

    Private Sub TextBoxH_Name_GotFocus(sender As Object, e As EventArgs) Handles TextBoxH_Name.GotFocus
        If TextBoxH_Name.Text = "First name" Then
            TextBoxH_Name.Clear()
        End If
    End Sub

    Private Sub TextBoxH_Name_LostFocus(sender As Object, e As EventArgs) Handles TextBoxH_Name.LostFocus
        If TextBoxH_Name.Text = " " Or TextBoxH_Name.Text = Nothing Then
            TextBoxH_Name.Text = "First name"
        End If
    End Sub

    Private Sub TextBoxH_LastName_GetFocus(sender As Object, e As EventArgs) Handles TextBoxH_LastName.GotFocus
        If TextBoxH_LastName.Text = "Last name" Then
            sender.clear()
        End If
    End Sub

    Private Sub TextBoxH_LastName_LostFocus(sender As Object, e As EventArgs) Handles TextBoxH_LastName.LostFocus
        If sender.Text = " " Or sender.text = Nothing Then
            sender.text = "Last name"
        End If
    End Sub

    Private Sub TextBoxH_Email_GotFocus(sender As Object, e As EventArgs) Handles TextBoxH_Email.GotFocus
        If sender.text = "Email address" Then
            sender.clear
        End If
    End Sub

    Private Sub TextBoxH_Email_LostFocus(sender As Object, e As EventArgs) Handles TextBoxH_Email.LostFocus
        If sender.text = Nothing Or sender.text = " " Then
            sender.text = "Email address"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        OpenFileDialog1.Filter = "Log files|*.log"
        OpenFileDialog1.ShowDialog()
        If File.Exists(OpenFileDialog1.FileName) Then
            Dim a As New Thread(Sub() NewLog(OpenFileDialog1.FileName))
            a.SetApartmentState(ApartmentState.STA)
            a.Start()
        End If

    End Sub

    Private Sub TB_MailToAddress_GotFocus(sender As Object, e As EventArgs) Handles TB_MailToAddress.MouseClick
        sender.SelectAll()
    End Sub


    Public Function SendEmail() As Boolean

        Btn_SendMail.Enabled = False
        RestartAgent()



        Dim ToName As String = "Tech"

        If customer_lastname IsNot Nothing Or customer_lastname = "Last Name" Or customer_lastname = " " Then
            ToName = "Tech"
        Else
            ToName = customer_lastname
        End If



        Try
            Dim fromAddress As New MailAddress("cs_stk@yahoo.com", "Adam Intop")
            Dim toAddress As New MailAddress(TB_MailToAddress.Text, ToName)
            Dim smtp As New SmtpClient()
            smtp.Host = "smtp.mail.yahoo.com"
            smtp.Port = 587
            smtp.EnableSsl = True
            smtp.UseDefaultCredentials = False
            smtp.Credentials = New NetworkCredential("cs_stk@yahoo.com", "ffhngoeyujgofwpy")
            Dim message As New MailMessage(fromAddress, toAddress)
            message.Subject = mainCompanyName + " Logs"
            message.Body = "Logs recived via email for company ID: " & mainCompanyID & " " & mainCompanyName



            'EaseeControl log
            If CheckBox_EaseeControlLog.Checked Then
                Dim attachment As New Attachment(EaseeControlLog)
                message.Attachments.Add(attachment)
            End If

            'OptimumDesk log
            If CheckBox_OdLog.Checked Then
                Dim attachment As New Attachment(OptimumDeskLog)
                message.Attachments.Add(attachment)
            End If

            'ODService Log
            If CheckBox_ODServiceLog.Checked Then
                Dim attachment As New Attachment(ODServiceLog)
                message.Attachments.Add(attachment)
            End If


            'Modules
            If CheckBox_Modules.Checked Then
                Dim attachment As New Attachment(ModulesLog)
                message.Attachments.Add(attachment)
            End If

            'Local registry
            If CheckBox_LocalRegistry.Checked Then
                RegistryLog = ReadLocalRegistry()
                Dim attachment As New Attachment(RegistryLog)
                message.Attachments.Add(attachment)
            End If


            smtp.Send(message)



            Btn_SendMail.Enabled = True
            MsgBox("Email message was send to " + TB_MailToAddress.Text)


            For Each x As Control In Panel17.Controls
                If TypeOf x Is CheckBox Then
                    CType(x, CheckBox).Checked = False
                End If
            Next

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            PowerShellCmd("Start-Service -Name 'ODService'; Start-Service -Name 'UpdaterService'")
            Btn_SendMail.Enabled = True
            Return False
        End Try


    End Function

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged

        If TypeOf sender Is CheckBox AndAlso CType(sender, CheckBox).Checked Then
            For Each item As Control In Panel17.Controls
                If TypeOf item Is CheckBox Then
                    If item.Enabled = True Then
                        CType(item, CheckBox).Checked = True
                    End If
                End If
            Next
        Else
            For Each item As Control In Panel17.Controls
                If TypeOf item Is CheckBox Then
                    CType(item, CheckBox).Checked = False
                End If
            Next
        End If

    End Sub


    Public Function ReadLocalRegistry()
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
        Return FILE_NAME
        'System.Diagnostics.Process.Start("notepad.exe", FILE_NAME)
    End Function



    Public Sub SearchForLogs()


        If CheckBox_EaseeControlLog.InvokeRequired Then
            CheckBox_EaseeControlLog.Invoke(New Action(AddressOf SearchForLogs))
            Return
        End If

        CheckBox_EaseeControlLog.Enabled = False
        CheckBox_Modules.Enabled = False
        CheckBox_ODServiceLog.Enabled = False
        CheckBox_OdLog.Enabled = False

        Try
            For Each file As String In Directory.GetFiles(agentInstalled.working_folder_ec, "*", SearchOption.AllDirectories)
                Dim fileInfo As New FileInfo(file)
                If fileInfo.Name = "EaseeControl.log" Or fileInfo.Name = "Easee Control.log" Then
                    EaseeControlLog_RAW = fileInfo.ToString
                    EaseeControlLog = DecryptLogFile(fileInfo.Name, "EaseeControl.log")
                    CheckBox_EaseeControlLog.Enabled = True
                ElseIf fileInfo.Name = "ModuleServ.log" Or fileInfo.Name = "ModuleServ.log" Then
                    ModulesLog_RAW = fileInfo.ToString
                    ModulesLog = DecryptLogFile(fileInfo.Name, "ModulesLog.log")
                    CheckBox_Modules.Enabled = True
                End If
            Next

            For Each file As String In Directory.GetFiles(agentInstalled.working_folder_od, "*", SearchOption.AllDirectories)
                Dim fileInfo As New FileInfo(file)
                If fileInfo.Name = "ODService.log" Then
                    ODServiceLog_RAW = fileInfo.ToString
                    ODServiceLog = DecryptLogFile(fileInfo.Name, "ODService.log")
                    CheckBox_ODServiceLog.Enabled = True
                ElseIf fileInfo.Name = "OptimumDesk.log" Then
                    OptimumDeskLog_RAW = fileInfo.ToString
                    OptimumDeskLog = DecryptLogFile(fileInfo.Name, "OptimumDesk.log")
                    CheckBox_OdLog.Enabled = True
                End If
            Next

        Catch ex As Exception

        End Try
    End Sub


    Public Sub UpdateTileEC()
        Dim lastLine As String = ""
        Try
            If EaseeControlLog_RAW IsNot Nothing Then
                Label32.Text = EaseeControlLog_RAW
                Dim currentLine As String = ""
                Using fs As New FileStream(EaseeControlLog_RAW, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
                    Using sr As New StreamReader(fs, Encoding.UTF8)
                        While Not sr.EndOfStream
                            currentLine = sr.ReadLine()
                        End While
                    End Using
                End Using
                If currentLine IsNot Nothing AndAlso currentLine <> lastLine Then
                    lastLine = currentLine
                    Dim splitIndex As Integer = lastLine.LastIndexOf("]") + 2
                    If splitIndex > 1 AndAlso splitIndex < lastLine.Length Then ' ensure splitIndex is valid
                        Dim leftString As String = lastLine.Substring(splitIndex)
                        Dim rightString As String = lastLine.Substring(0, splitIndex - 2)

                        ' store left and right sides in variables if needed
                        Dim leftVariable As String = Decrypt(leftString)
                        Dim rightVariable As String = rightString

                        RichTextBox1.Invoke(Sub() RichTextBox1.Text = rightVariable & leftVariable)

                    End If
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub UpdateTileModules()

        Dim lastLine As String = ""
        If ModulesLog_RAW IsNot Nothing Then
            Try
                Label40.Text = ModulesLog_RAW
                Dim currentLine As String = ""
                Using fs As New FileStream(ModulesLog_RAW, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
                    Using sr As New StreamReader(fs, Encoding.UTF8)
                        While Not sr.EndOfStream
                            currentLine = sr.ReadLine()
                        End While
                    End Using
                End Using
                If currentLine IsNot Nothing AndAlso currentLine <> lastLine Then
                    lastLine = currentLine
                    Dim leftString As String = lastLine.Substring(lastLine.LastIndexOf("]") + 2)
                    RichTextBox2.Invoke(Sub() RichTextBox2.Text = Decrypt(leftString))
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Public Sub UpdateODServiceTile()

        Dim lastLine As String = ""
        Try
            If ODServiceLog_RAW IsNot Nothing Then
                Label44.Text = ODServiceLog_RAW
                Dim currentLine As String = ""
                Using fs As New FileStream(ODServiceLog_RAW, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
                    Using sr As New StreamReader(fs, Encoding.UTF8)
                        While Not sr.EndOfStream
                            currentLine = sr.ReadLine()
                        End While
                    End Using
                End Using
                If currentLine IsNot Nothing AndAlso currentLine <> lastLine Then
                    lastLine = currentLine
                    Dim splitIndex As Integer = lastLine.LastIndexOf("]") + 2
                    If splitIndex > 1 AndAlso splitIndex < lastLine.Length Then
                        Dim rightString As String = lastLine.Substring(splitIndex)
                        Dim leftString As String = lastLine.Substring(0, splitIndex - 2)
                        Dim rightVariable As String = Decrypt(rightString)
                        Dim leftVariable As String = leftString
                        RichTextBox3.Invoke(Sub() RichTextBox3.Text = rightVariable & leftVariable)
                    End If
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub UpdateOptimumDeskTile()

        Dim lastLine As String = ""
        Try
            If OptimumDeskLog_RAW IsNot Nothing Then
                Label45.Text = OptimumDeskLog_RAW
                Dim currentLine As String = ""
                Using fs As New FileStream(OptimumDeskLog_RAW, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
                    Using sr As New StreamReader(fs, Encoding.UTF8)
                        While Not sr.EndOfStream
                            currentLine = sr.ReadLine()
                        End While
                    End Using
                End Using
                If currentLine IsNot Nothing AndAlso currentLine <> lastLine Then
                    lastLine = currentLine
                    Dim leftString As String = lastLine.Substring(lastLine.LastIndexOf("]") + 2)
                    RichTextBox4.Invoke(Sub() RichTextBox4.Text = Decrypt(leftString))
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

    End Sub






    Public Function DecryptLogFile(input As String, output As String)


        Dim fs As FileStream
        Dim sr As StreamReader
        Dim output_file = "C:\Windows\Temp\" & output

        If File.Exists(output_file) Then
            File.Delete(output_file)
        End If

        Try
            fs = New FileStream(input, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
            sr = New StreamReader(fs)
            Dim t As String = sr.ReadToEnd
            sr.Close()
            fs.Close()
            Dim d As New List(Of String)(t.Split(Chr(13)))
            Dim x As String
            Dim l As Integer
            l = d.Count
            Application.DoEvents()
            Dim decryptedText As New StringBuilder()

            For r = 0 To l - 2
                t = d(r)
                x = t.Substring(0, t.LastIndexOf("] ") + 2)
                x = x & Decrypt(t.Substring(t.LastIndexOf("] ") + 2))
                decryptedText.AppendLine(x)
                Application.DoEvents()
            Next

            File.WriteAllText(output_file, decryptedText.ToString())
            Return output_file

        Catch ex As Exception
            'If Not ex.Message = "Object reference not set to an instance of an object." Then MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If File.Exists(ModulesLog_RAW) Then
            NewLog(ModulesLog_RAW)
        End If
    End Sub

    Private Sub Button21_Click_2(sender As Object, e As EventArgs) Handles Button21.Click
        If File.Exists(EaseeControlLog_RAW) Then
            NewLog(EaseeControlLog_RAW)
        End If
    End Sub

    Private Sub Button16_Click_1(sender As Object, e As EventArgs) Handles Button16.Click
        If File.Exists(ODServiceLog_RAW) Then
            NewLog(ODServiceLog_RAW)
        End If
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        If File.Exists(OptimumDeskLog_RAW) Then
            NewLog(OptimumDeskLog_RAW)
        End If
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click

        If System.IO.File.Exists(ModulesLog_RAW) = True Then
            RestartAgent()
            Timer_LogsPreview.Stop()
            System.IO.File.Delete(ModulesLog_RAW)
            Timer_LogsPreview.Start()
        End If
    End Sub

    Private Sub CheckBox_Modules_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Modules.CheckedChanged

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        Dim startInfo As New ProcessStartInfo("notepad.exe", ReadLocalRegistry())
        startInfo.WindowStyle = ProcessWindowStyle.Maximized
        Process.Start(startInfo)

        ' System.Diagnostics.Process.Start("notepad.exe", ReadLocalRegistry())
    End Sub

    Private Sub Timer_LogsPreview_Tick(sender As Object, e As EventArgs) Handles Timer_LogsPreview.Tick

        If File.Exists(EaseeControlLog_RAW) Then
            UpdateTileEC()
        End If

        If File.Exists(ModulesLog_RAW) Then
            UpdateTileModules()
        End If

        If File.Exists(OptimumDeskLog_RAW) Then
            UpdateOptimumDeskTile()
        End If

        If File.Exists(ODServiceLog_RAW) Then
            UpdateODServiceTile()
        End If

    End Sub
End Class