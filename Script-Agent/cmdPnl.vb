'Imports System.Web.Script.Serialization

'Imports System.Management
'Imports System.Text
'Imports System
'Imports System.IO
'Imports Newtonsoft.Json
'Imports System.Threading
'Imports System.Windows.Forms
'Imports Microsoft.Win32
'Imports System.Diagnostics.Eventing.Reader
'Imports System.Security.Cryptography.X509Certificates
'Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ListView
'Imports Microsoft.VisualBasic.ApplicationServices
'Imports System.Net.Sockets
'Imports System.Net.Mime.MediaTypeNames
'Imports System.Windows.Media.Animation
'Imports System.Diagnostics.Contracts


'Imports System.ComponentModel
'Imports System.Windows.Input

'Public Class cmdPnl


'    Dim len As Integer
'    Dim counter As Integer
'    Dim txt As String
'    Dim CmdRunTime As Integer
'    Dim cmdEndOutput As String
'    Dim Regkey As String
'    Dim IsPnlExtended As Integer = 0
'    Dim PnlExtended As Panel

'    Public isCmdRunning As Boolean = False

'    Dim isCollapsed As Boolean = True
'    Dim isWinPnlCollapsed As Boolean = False
'    Dim IsEventsCollapsed As Boolean = True

'    Public cmdName As String
'    Public cmdMsg As String
'    Public cmdStatus As String
'    Public btn As Button










'    Public cmdBtnColor As Color
'    Public cmdPictureBox As PictureBox


'    Public RegkeySave As String = "HKEY_CURRENT_USER\SOFTWARE\TEST"



'    Sub Save()
'        For Each X As Control In Me.Controls
'            If TypeOf X Is Button Then
'                Dim dic As New propietatiDeSalvat
'                dic.btnColor = cmdBtnColor
'                Dim json As New JavaScriptSerializer
'                json.MaxJsonLength = 2147483644
'                My.Computer.Registry.SetValue(RegkeySave, X.Name, json.Serialize(dic))
'            End If
'        Next
'    End Sub

'    Sub Load()
'        For Each X As Control In Me.Controls
'            If TypeOf X Is Button Then
'                Dim data As String = My.Computer.Registry.GetValue(RegkeySave, X.Name, Nothing)
'                If data Is Nothing Then Continue For
'                Dim json As New JavaScriptSerializer
'                json.MaxJsonLength = 2147483644
'                Dim dic As propietatiDeSalvat = json.Deserialize(Of propietatiDeSalvat)(data)
'                X.BackColor = dic.btnColor
'                X.ForeColor = Color.AntiqueWhite

'            End If
'        Next
'    End Sub

'    Public Structure propietatiDeSalvat


'        Public btnColor As Color



'    End Structure






'    Private Sub cmdPnl_Load(sender As Object, e As EventArgs) Handles MyBase.Load


'        'Load()




'        'counter = 0
'        'len = TB_CmdResponse.Text.Length
'        'txt = TB_CmdResponse.Text





'        'PB_Cmd.Hide()
'        'Pb1.Hide()
'        'Lbl_Procent.Hide()


'        'Lbl_MoreWinUpdate.Hide()
'        'Lbl_MoreDrvUp.Hide()
'        'Lbl_MoreTuneUp.Hide()
'        'Lbl_More_DiskC.Hide()
'        'Lbl_MoreDism.Hide()
'        'Lbl_MoreActiveWin.Hide()
'        'Lbl_MoreTempFiles.Hide()
'        'Lbl_RestorePoint.Hide()




'        'PicBox_WinUpdate.Hide()

'        'Pb_WinUpdate.Hide()
'        'Lbl_WinUpdate.Hide()

'        'PB_DrvUp.Hide()
'        'PicBox_DrvUp.Hide()
'        'Lbl_DrvUp.Hide()
'        'PicBox_DISM.Hide()
'        'PB_DISM.Hide()
'        'Lbl_DISM.Hide()
'        'PicBox_DiskCleanUp.Hide()
'        'PB_DiskCleanUp.Hide()
'        'Lbl_DiskCleanUp.Hide()
'        'PicBox_TuneUp.Hide()
'        'PB_TuneUP.Hide()
'        'Lbl_TuneUp.Hide()
'        'PicBox_Temp.Hide()
'        'Pb_Temp.Hide()
'        'Lbl_Temp.Hide()
'        'PictureBox32.Hide()
'        'ProgressBar17.Hide()
'        'Label23.Hide()
'        'PictureBox34.Hide()
'        'ProgressBar19.Hide()
'        'Label26.Hide()


'        'PictureBox1.Hide()

'        'PictureBox9.Hide()
'        'PictureBox33.Hide()
'        'PictureBox37.Hide()
'        'PictureBox30.Hide()
'        'PictureBox35.Hide()
'        'PictureBox36.Hide()
'        'PictureBox31.Hide()
'        'Label57.Hide()
'        'Label63.Hide()
'        'Label66.Hide()
'        'Label54.Hide()
'        'Label60.Hide()
'        'Label69.Hide()
'        'Label51.Hide()
'        'Label49.Hide()
'        'Label58.Hide()
'        'Label64.Hide()
'        'Label67.Hide()
'        'Label55.Hide()
'        'Label70.Hide()
'        'Label61.Hide()
'        'Label52.Hide()
'        'Label8.Hide()



'    End Sub

'    Private Sub Btn_DriverUpdates_Click(sender As Object, e As EventArgs) Handles Btn_DriverUpdates.Click, Button35.Click



'        Dim btn As Button = CType(sender, Button)

'        Dim T_DrvUp As System.Threading.Thread
'        T_DrvUp = New System.Threading.Thread(AddressOf DriverUpdate)
'        T_DrvUp.Start(btn)

'    End Sub

'    Private Sub Btn_DISM_Click(sender As Object, e As EventArgs) Handles Btn_DISM.Click, Button37.Click, Button1.Click, Button8.Click



'        Dim btn As Button = CType(sender, Button)



'        Dim T_DISM As System.Threading.Thread
'        T_DISM = New System.Threading.Thread(AddressOf DISM)
'        T_DISM.Start(btn)

'    End Sub

'    Private Sub Btn_DiskCleanup_Click(sender As Object, e As EventArgs) Handles Btn_DiskCleanup.Click, Button32.Click, Button4.Click, Button11.Click


'        Dim btn As Button = CType(sender, Button)



'        Dim T_DskCln As System.Threading.Thread
'        T_DskCln = New System.Threading.Thread(AddressOf DiskCleanup)
'        T_DskCln.Start(btn)


'    End Sub

'    Private Sub Btn_TuneUp_Click(sender As Object, e As EventArgs) Handles Btn_TuneUp.Click, Button36.Click, Button2.Click, Button9.Click


'        Dim btn As Button = CType(sender, Button)



'        Dim T_TuneUp As System.Threading.Thread
'        T_TuneUp = New System.Threading.Thread(AddressOf TuneUp)
'        T_TuneUp.Start(btn)


'    End Sub

'    Private Sub Btn_TempFiles_Click(sender As Object, e As EventArgs) Handles Btn_TempFiles.Click, Button31.Click, Button5.Click, Button12.Click


'        Dim btn As Button = CType(sender, Button)


'        Dim T_Temp As System.Threading.Thread
'        T_Temp = New System.Threading.Thread(AddressOf Temp)
'        T_Temp.Start(btn)

'    End Sub

'    Private Sub Btn_ActivateWindows_Click(sender As Object, e As EventArgs) Handles Btn_ActivateWindows.Click, Button34.Click, Button3.Click, Button10.Click

'        Dim btn As Button = CType(sender, Button)

'        Dim T_AC_WIN As System.Threading.Thread
'        T_AC_WIN = New System.Threading.Thread(AddressOf ActivateWindows)
'        T_AC_WIN.Start(btn)

'    End Sub




'    Private Sub Btn_RestorePoint_Click(sender As Object, e As EventArgs) Handles Btn_RestorePoint.Click, Button6.Click, Button7.Click, Button13.Click

'        Dim btn As Button = CType(sender, Button)



'        Dim T_RestorePoint As System.Threading.Thread
'        T_RestorePoint = New System.Threading.Thread(AddressOf RestorePoint)
'        T_RestorePoint.Start(btn)

'    End Sub


'    Public JsonLocation As String = My.Application.Info.DirectoryPath + "\Json\cmdJson.Json"


'    Public Sub RestorePoint(Btn)

'        Dim cmdName As String = "Restore Point"
'        Dim batFile As String = My.Application.Info.DirectoryPath + "\Scripts\RestorePoint.bat"
'        Dim regKey As String = "HKEY_LOCAL_MACHINE\SOFTWARE\Class IT\ODMem"

'        Dim PicBoxName As PictureBox = PictureBox34
'        Dim PbName As ProgressBar = ProgressBar19
'        Dim PbLabel As Label = Label26
'        Dim LblMore As Label = Lbl_RestorePoint




'        RunCmd(Btn, batFile, cmdName, regKey, PicBoxName, PbName, PbLabel, LblMore, TextBox8)

'    End Sub

'    Public Sub ActivateWindows(Btn)

'        Dim cmdName As String = "Activate Windows"
'        Dim batFile As String = My.Application.Info.DirectoryPath + "\Scripts\ActivateWin.bat"
'        Dim regKey As String = "HKEY_LOCAL_MACHINE\SOFTWARE\Class IT\ODMem"

'        Dim PicBoxName As PictureBox = PictureBox32
'        Dim PbName As ProgressBar = ProgressBar17
'        Dim PbLabel As Label = Label23


'        Dim LblMore As Label = Lbl_MoreActiveWin
'        RunCmd(Btn, batFile, cmdName, regKey, PicBoxName, PbName, PbLabel, LblMore, TextBox7)
'    End Sub


'    Public Sub WinUpdate(Btn)


'        'Windows update


'        Dim cmdName As String = "Windows Update"
'        Dim batFile As String = My.Application.Info.DirectoryPath + "\Scripts\WinUpdate.bat"
'        Dim regKey As String = "HKEY_LOCAL_MACHINE\SOFTWARE\Class IT\ODMem"

'        Dim PicBoxName As PictureBox = PicBox_WinUpdate
'        Dim PbName As ProgressBar = Pb_WinUpdate
'        Dim PbLabel As Label = Lbl_WinUpdate

'        Dim LblMore As Label = Lbl_MoreWinUpdate



'        RunCmd(Btn, batFile, cmdName, regKey, PicBoxName, PbName, PbLabel, LblMore, TextBox2)



'    End Sub


'    Public Sub DriverUpdate(Btn)



'        Dim cmdName As String = "Driver Update"
'        Dim batFile As String = My.Application.Info.DirectoryPath + "\Scripts\DriverUpdate.bat"
'        Dim regKey As String = "HKEY_LOCAL_MACHINE\SOFTWARE\Class IT\ODMem"
'        Dim PicBoxName As PictureBox = PicBox_DrvUp
'        Dim PbName As ProgressBar = PB_DrvUp
'        Dim PbLabel As Label = Lbl_DrvUp

'        Dim LblMore As Label = Lbl_MoreDrvUp

'        RunCmd(Btn, batFile, cmdName, regKey, PicBoxName, PbName, PbLabel, LblMore, TextBox6)


'    End Sub


'    Public Sub DISM(Btn)


'        'DISM Repair

'        Dim cmdName As String = "DISM Repair"
'        Dim batFile As String = My.Application.Info.DirectoryPath + "\Scripts\dism.bat"
'        Dim regKey As String = "HKEY_LOCAL_MACHINE\SOFTWARE\Class IT\ODMem"
'        Dim PicBoxName As PictureBox = PicBox_DISM
'        Dim PbName As ProgressBar = PB_DISM
'        Dim PbLabel As Label = Lbl_DISM
'        Dim LblMore As Label = Lbl_MoreDism

'        RunCmd(Btn, batFile, cmdName, regKey, PicBoxName, PbName, PbLabel, LblMore, TextBox3)

'    End Sub

'    Public Sub DiskCleanup(btn)


'        Dim cmdName As String = "Disk Cleanup"
'        Dim batFile As String = My.Application.Info.DirectoryPath + "\Scripts\DiskCleanUp.bat"
'        Dim regKey As String = "HKEY_LOCAL_MACHINE\SOFTWARE\Class IT\ODMem"

'        Dim PicBoxName As PictureBox = PicBox_DiskCleanUp
'        Dim PbName As ProgressBar = PB_DiskCleanUp
'        Dim PbLabel As Label = Lbl_DiskCleanUp
'        Dim LblMore As Label = Lbl_More_DiskC


'        RunCmd(btn, batFile, cmdName, regKey, PicBoxName, PbName, PbLabel, LblMore, TextBox9)


'        ';Public Function RunCmd(Btn As Button, batFile As String, cmdName As String, regKey As String, PicBoxName As PictureBox, PbName As ProgressBar, PbLabel As Label, LblMoreBtn As Label, LblMore As TextBox)

'    End Sub

'    Public Sub TuneUp(btn)


'        Dim cmdName As String = "Tune Up"
'        Dim batFile As String = My.Application.Info.DirectoryPath + "\Scripts\TuneUp.bat"
'        Dim regKey As String = "HKEY_LOCAL_MACHINE\SOFTWARE\Class IT\ODMem"

'        Dim PicBoxName As PictureBox = PicBox_TuneUp
'        Dim PbName As ProgressBar = ProgressBar31
'        Dim PbLabel As Label = Lbl_TuneUp
'        Dim LblMore As Label = Lbl_MoreTuneUp

'        RunCmd(btn, batFile, cmdName, regKey, PicBoxName, PbName, PbLabel, LblMore, TextBox4)

'    End Sub



'    Public Sub Temp(btn)


'        Dim cmdName As String = "Delete Temp files"
'        Dim batFile As String = My.Application.Info.DirectoryPath + "\Scripts\TempFiles.bat"
'        Dim regKey As String = "HKEY_LOCAL_MACHINE\SOFTWARE\Class IT\ODMem"

'        Dim PicBoxName As PictureBox = PicBox_Temp
'        Dim PbName As ProgressBar = Pb_Temp
'        Dim PbLabel As Label = Lbl_Temp
'        Dim LblMore As Label = Lbl_MoreTempFiles

'        RunCmd(btn, batFile, cmdName, regKey, PicBoxName, PbName, PbLabel, LblMore, TextBox5)




'    End Sub




'    Public Sub NetworkTroubleshoot(btn)


'        Dim cmdName As String = "Network Troubleshoot"
'        Dim batFile As String = My.Application.Info.DirectoryPath + "\Scripts\NetTroublesoot.bat"
'        Dim regKey As String = "HKEY_LOCAL_MACHINE\SOFTWARE\Class IT\ODMem"

'        Dim PicBoxName As PictureBox = PictureBox31
'        Dim PbName As ProgressBar = ProgressBar34
'        Dim PbLabel As Label = Label57
'        Dim LblMore As Label = Label58

'        RunCmd(btn, batFile, cmdName, regKey, PicBoxName, PbName, PbLabel, LblMore, TextBox13)


'    End Sub


'    Private Sub Btn_Windows_Click(sender As Object, e As EventArgs) Handles Btn_Windows.Click


'        Dim btn As Button = CType(sender, Button)
'        Dim Pnl As Panel = Pnl_Windows
'        Frame.Lbl_TopLabel.Text = "Windows"
'        Frame.Lbl_TopLabel.Show()


'        ChangeCmdPanel(btn, Pnl)




'    End Sub


'    Private Sub WinUpdate_MouseHover(sender As Object, e As EventArgs) Handles Btn_WinUpdate.MouseHover, Button33.MouseHover



'        Dim Title As String = "Windows Update"
'        Dim Button As Button = Btn_WinUpdate
'        Dim Text As String = "Run this command to fix common windows update issues & check for any available updates"


'        ButtonToolTip(Title, Button, Text)

'    End Sub

'    Private Sub DriverUpdates_MouseHover(sender As Object, e As EventArgs) Handles Btn_DriverUpdates.MouseHover, Button35.MouseHover

'        Dim Title As String = "Driver Update"
'        Dim Button As Button = Btn_DriverUpdates
'        Dim Text As String = "Install and update system drivers directly from Microsoft Catalog"


'        ButtonToolTip(Title, Button, Text)

'    End Sub

'    Private Sub DISM_MouseHover(sender As Object, e As EventArgs) Handles Btn_DISM.MouseHover, Button37.MouseHover, Button1.MouseHover, Button8.MouseHover

'        Dim Title As String = "DISM Repair"
'        Dim Button As Button = Btn_DISM
'        Dim Text As String = "Scan the Windows image for any corruption and to perform a repair automatically. This operation takes 15 mins or more depending on the level of corruption"


'        ButtonToolTip(Title, Button, Text)

'    End Sub

'    Private Sub DiskClean_MouseHover(sender As Object, e As EventArgs) Handles Btn_DiskCleanup.MouseHover, Button32.MouseHover, Button4.MouseHover, Button11.MouseHover


'        Dim Title As String = "Disk Clean-up"
'        Dim Button As Button = Btn_DiskCleanup
'        Dim Text As String = "Disk Clean-up is a computer maintenance utility included in Microsoft Windows designed to free up disk space on a computer's hard drive"

'        ButtonToolTip(Title, Button, Text)
'    End Sub

'    Private Sub Btn_TuneUp_MouseHover(sender As Object, e As EventArgs) Handles Btn_TuneUp.MouseHover, Button36.MouseHover, Button2.MouseHover, Button9.MouseHover



'        Dim Title As String = "Tune-up"
'        Dim Button As Button = Btn_TuneUp
'        Dim Text As String = "Help manage, maintain, optimize, configure, and troubleshoot a computer system"


'        ButtonToolTip(Title, Button, Text)


'    End Sub




'    Sub SwitchPanel(ByVal panel As Form)


'        Pnl_Windows.Controls.Clear()
'        panel.TopLevel = False
'        Pnl_Windows.Controls.Add(panel)

'        panel.Show()

'    End Sub

'    Private Sub Colapse_Events_Tick(sender As Object, e As EventArgs) Handles Colapse_Events.Tick





'    End Sub

'    Private Sub Btn_Network_Click(sender As Object, e As EventArgs) Handles Btn_Network.Click


'        Dim btn As Button = CType(sender, Button)
'        Dim Pnl As Panel = Pnl_Network
'        Frame.Lbl_TopLabel.Text = "Network"
'        Frame.Lbl_TopLabel.Show()


'        ChangeCmdPanel(btn, Pnl)

'    End Sub

'    Private Sub Btn_Antivirus_Click(sender As Object, e As EventArgs) Handles Btn_Antivirus.Click


'        Dim btn As Button = CType(sender, Button)
'        Dim Pnl As Panel = Pnl_Windows
'        Frame.Lbl_TopLabel.Text = "Windows"
'        Frame.Lbl_TopLabel.Show()


'        ChangeCmdPanel(btn, Pnl)


'    End Sub


'    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click


'        If IsEventsCollapsed = True Then
'            ListView_Cmd.Show()
'            ListView_Cmd.Location = Pnl_CommandAnimation.Location
'            ListView_Cmd.BringToFront()
'            IsEventsCollapsed = False
'        Else
'            ListView_Cmd.Hide()
'            IsEventsCollapsed = True
'        End If







'    End Sub

'    Private Sub Btn_Security_Click(sender As Object, e As EventArgs) Handles Btn_Security.Click

'    End Sub

'    Private Sub Timer_LetterByLetter_Tick(sender As Object, e As EventArgs) Handles Timer_LetterByLetter.Tick


'        counter += 1

'        If counter > len Then
'            counter = 0
'            TB_CmdResponse.Text = ""
'        Else

'            TB_CmdResponse.Text = txt.Substring(0, counter)

'        End If






'    End Sub

'    Private Sub ProgressBar2_Click(sender As Object, e As EventArgs)

'    End Sub

'    Private Sub Label49_Click(sender As Object, e As EventArgs)

'    End Sub

'    Private Sub CheckBox25_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox25.CheckedChanged, CheckBox1.CheckedChanged, CheckBox43.CheckedChanged, CheckBox42.CheckedChanged, CheckBox3.CheckedChanged, CheckBox2.CheckedChanged, CheckBox9.CheckedChanged, CheckBox8.CheckedChanged, CheckBox20.CheckedChanged

'    End Sub


'    'Sub SwitchPanel(ByVal panel As Form, TopStr As String, Btn As Button)


'    '    Frame.Lbl_TopLabel.Text = TopStr
'    '    Frame.PixBox_Top.Image = Btn.Image


'    '    PnlMain.Controls.Clear()
'    '    panel.TopLevel = False
'    '    PnlMain.Controls.Add(panel)

'    '    panel.Show()

'    'End Sub


'    'Private Sub Btn_NetworkTroubleshoot_Click(sender As Object, e As EventArgs) Handles Btn_NetworkTroubleshoot.Click


'    '    Dim btn As Button = CType(sender, Button)


'    '    Dim T_N_Troubleshoot As System.Threading.Thread
'    '    T_N_Troubleshoot = New System.Threading.Thread(AddressOf NetTroubleShoot)
'    '    T_N_Troubleshoot.Start(btn)
'    'End Sub




'    'Private Sub Btn_AutoDNS_Click(sender As Object, e As EventArgs) Handles Btn_AutoDNS.Click

'    '    Dim btn As Button = CType(sender, Button)


'    '    Dim T_AutoDNS As System.Threading.Thread
'    '    T_AutoDNS = New System.Threading.Thread(AddressOf AutoDNS)
'    '    T_AutoDNS.Start(btn)

'    'End Sub

'    'Public Sub AutoDNS(btn)
'    '    Dim cmdName As String = "Restore Auto DNS"
'    '    Dim batFile As String = My.Application.Info.DirectoryPath + "\Scripts\AutoDNS.bat"
'    '    Dim regKey As String = "HKEY_LOCAL_MACHINE\SOFTWARE\Class IT\ODMem"

'    '    Dim PicBoxName As PictureBox = PictureBox44
'    '    Dim PbName As ProgressBar = ProgressBar14
'    '    Dim PbLabel As Label = Label20

'    '    RunCmd(btn, batFile, cmdName, regKey, PicBoxName, PbName, PbLabel)


'    'End Sub

'    'Private Sub Btn_WinSockReset_Click(sender As Object, e As EventArgs) Handles Btn_WinSockReset.Click

'    '    Dim btn As Button = CType(sender, Button)


'    '    Dim T_WinSOCK As System.Threading.Thread
'    '    T_WinSOCK = New System.Threading.Thread(AddressOf WinSOCK)
'    '    T_WinSOCK.Start(btn)


'    'End Sub

'    'Public Sub WinSOCK(Btn)

'    '    Dim cmdName As String = "WinSock Reset"
'    '    Dim batFile As String = My.Application.Info.DirectoryPath + "\Scripts\WinSOCK.bat"
'    '    Dim regKey As String = "HKEY_LOCAL_MACHINE\SOFTWARE\Class IT\ODMem"

'    '    Dim PicBoxName As PictureBox = PictureBox40
'    '    Dim PbName As ProgressBar = ProgressBar12
'    '    Dim PbLabel As Label = Label18

'    '    RunCmd(Btn, batFile, cmdName, regKey, PicBoxName, PbName, PbLabel)
'    'End Sub

'    'Private Sub Btn_AirplnMode_Click(sender As Object, e As EventArgs) Handles Btn_AirplnMode.Click


'    '    Dim btn As Button = CType(sender, Button)


'    '    Dim T_AIR_Mode As System.Threading.Thread
'    '    T_AIR_Mode = New System.Threading.Thread(AddressOf AirMode)
'    '    T_AIR_Mode.Start(btn)


'    'End Sub


'    'Public Sub AirMode(Btn)


'    '    Dim cmdName As String = "Disable Airplane Mode"
'    '    Dim batFile As String = My.Application.Info.DirectoryPath + "\Scripts\AMode.bat"
'    '    Dim regKey As String = "HKEY_LOCAL_MACHINE\SOFTWARE\Class IT\ODMem"

'    '    Dim PicBoxName As PictureBox = PictureBox26
'    '    Dim PbName As ProgressBar = ProgressBar9
'    '    Dim PbLabel As Label = Label15


'    '    RunCmd(Btn, batFile, cmdName, regKey, PicBoxName, PbName, PbLabel)

'    'End Sub

'    'Private Sub Btn_WirelessReport_Click(sender As Object, e As EventArgs) Handles Btn_WirelessReport.Click

'    '    Dim btn As Button = CType(sender, Button)


'    '    Dim T_WIFI_Report As System.Threading.Thread
'    '    T_WIFI_Report = New System.Threading.Thread(AddressOf WifiReport)
'    '    T_WIFI_Report.Start(btn)

'    'End Sub

'    'Public Sub WifiReport(Btn)

'    '    Dim cmdName As String = "Wireless Report"
'    '    Dim batFile As String = My.Application.Info.DirectoryPath + "\Scripts\WReport.bat"
'    '    Dim regKey As String = "HKEY_LOCAL_MACHINE\SOFTWARE\Class IT\ODMem"

'    '    Dim PicBoxName As PictureBox = PictureBox42
'    '    Dim PbName As ProgressBar = ProgressBar13
'    '    Dim PbLabel As Label = Label19


'    '    RunCmd(Btn, batFile, cmdName, regKey, PicBoxName, PbName, PbLabel)


'    'End Sub


'    Private Sub Temp_MouseHover(sender As Object, e As EventArgs) Handles Lbl_Temp.MouseHover, Btn_TempFiles.MouseHover, Label51.MouseHover, Button31.MouseHover, Label19.MouseHover, Button5.MouseHover, Label40.MouseHover, Button12.MouseHover


'        Dim Title As String = "Delete Temp Files"
'        Dim Button As Button = Btn_TempFiles
'        Dim Text As String = "Remove system and user temporary files"


'        ButtonToolTip(Title, Button, Text)

'    End Sub



'    Public Function Notification(CmdName As String, CmdOutput As String, ttStatus As ToolTipIcon)

'        NotifyIcon.ShowBalloonTip(1000, CmdName, CmdOutput, ttStatus)

'        Return Nothing
'    End Function

'    Private Sub Lbl_MoreWinUpdate_Click(sender As Object, e As EventArgs) Handles Lbl_MoreWinUpdate.Click, Pnl_WindowsUpdate.Click, Panel15.Click

'        PnlExtended = Pnl_WindowsUpdate
'        ExpandCmdPnl(Pnl_WindowsUpdate, Lbl_MoreWinUpdate)

'    End Sub

'    Private Sub Lbl_MoreActiveWin_Click(sender As Object, e As EventArgs) Handles Lbl_MoreActiveWin.Click, Panel10.Click, Label23.Click, Panel51.Click, Label61.Click, Label60.Click, Panel3.Click, Label14.Click, Label13.Click, Panel20.Click, Label35.Click, Label34.Click

'        PnlExtended = Panel10
'        ExpandCmdPnl(Panel10, Lbl_MoreActiveWin)

'    End Sub

'    Private Sub Lbl_MoreDrvUp_Click(sender As Object, e As EventArgs) Handles Lbl_MoreDrvUp.Click, Panel5.Click, Panel52.Click, Label64.Click

'        PnlExtended = Panel5
'        ExpandCmdPnl(Panel5, Lbl_MoreDrvUp)


'    End Sub







'    'VISUAL 

'    'Public Function showCmdMore(lbl As Label)




'    '    lbl.Show()
'    '    Return Nothing

'    'End Function

'    Private Sub Lbl_More_DiskC_Click(sender As Object, e As EventArgs) Handles Lbl_More_DiskC.Click, Panel7.Click, Lbl_DiskCleanUp.Click, Panel14.Click, Label55.Click, Label54.Click, Panel4.Click, Label17.Click, Label16.Click, Panel21.Click, Label38.Click, Label37.Click

'        ExpandCmdPnl(Panel7, Lbl_More_DiskC)


'    End Sub

'    Public Function RunCmd(Btn As Button, batFile As String, cmdName As String, regKey As String, PicBoxName As PictureBox, PbName As ProgressBar, PbLabel As Label, LblMoreBtn As Label, LblMore As TextBox)


'        PicBoxName.Visible = True



'        ''Button
'        Btn.Enabled = False
'        ' Btn.BackColor = Color.Chocolate
'        Btn.Font = New Font("Verdana", 9.0F, FontStyle.Bold)
'        ''  Btn.BackColor = ColorTranslator.FromHtml("247, 183, 49")


'        PbLabel.Hide()


'        PicBoxName.Image = My.Resources.loading1
'        Pb1.Image = My.Resources.PlayNext
'        Pb1.Show()

'        If isCmdRunning = True Then
'            PicBoxName.Image = My.Resources.NextCmd
'            PicBoxName.Show()

'            PbName.Show()

'        End If









'        Do Until isCmdRunning = False


'            Thread.Sleep(1000)


'        Loop


'        ''Random message

'        'Dim Ran As New Random
'        'Dim random As New Random

'        'Dim num_gif As Integer = Ran.Next(1, 5)
'        'Dim num_msg As Integer = random.Next(1, 4)

'        '' Adam Welcome Output

'        'If num_msg = 1 Then

'        '    TB_CmdResponse.Text = "Hi I`m Adam! Please wait while i run the " & cmdName & " command"
'        'End If

'        'If num_msg = 2 Then

'        '    TB_CmdResponse.Text = "Please wait while I run the " & cmdName & " command. Thank you!"
'        'End If

'        'If num_msg = 3 Then

'        '    TB_CmdResponse.Text = "Ok! Running " & cmdName & " command. Please wait"
'        'End If

'        ''Animation random


'        'If num_gif = 1 Then
'        '    PicBox_CmdRun.Image = My.Resources.Animation1
'        'End If

'        'If num_gif = 2 Then
'        '    PicBox_CmdRun.Image = My.Resources.Animation2
'        'End If

'        'If num_gif = 3 Then
'        '    PicBox_CmdRun.Image = My.Resources.Animation3
'        'End If

'        'If num_gif = 4 Then
'        '    PicBox_CmdRun.Image = My.Resources.Animation4
'        'End If


'        'TB_CmdResponse.Hide()
'        Timer_LetterByLetter.Start()

'        cmdStartAnimation(cmdName)


'        'Frame.Lbl_CmdStatus.Visible = True
'        'Frame.Lbl_CmdStatus.Text = "Running the " & TB_Cmd.Text & " command..."
'        Pnl_CommandAnimation.Show()




'        Dim Img_Status As Integer



'        isCmdRunning = True

'        PicBoxName.Show()
'        PbName.Show()
'        'PbLabel.Show()


'        'Create dummy key


'        My.Computer.Registry.LocalMachine.CreateSubKey("SOFTWARE\Class IT\ODMem")
'        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Class IT\ODMem", "AdamFromSITI", "ok")
'        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Class IT\ODMem", "aqte0JMpr6ot/97sLWwKiw==", "ERROR")
'        'Thread.Sleep(1000)


'        Dim PbValue As Integer = 0



'        PicBoxName.Image = My.Resources.loading1
'        PbName.ForeColor = Color.Blue

'        PbName.Value = 0
'        'PbLabel.Text = 0 & "%"
'        PB_Cmd.Value = PbValue
'        Lbl_Procent.Text = PbValue & "%"




'        PB_Cmd.Show()
'        'TB_CmdResponse.Show()
'        Lbl_Procent.Show()
'        'Notification(cmdName, Frame.Lbl_CmdStatus.Text, ToolTipIcon.Info)


'        Dim key As Microsoft.Win32.RegistryKey
'        key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Class IT\ODMem", True)
'        key.DeleteValue("AdamFromSITI")
'        key.DeleteValue("aqte0JMpr6ot/97sLWwKiw==")


'        Dim cmdProcess As New ProcessStartInfo(batFile)
'        cmdProcess.CreateNoWindow = True
'        cmdProcess.WindowStyle = ProcessWindowStyle.Hidden
'        Try
'            'Process.Start(cmdProcess).WaitForExit()
'            Process.Start(cmdProcess)

'            'Get Response
'            Do Until My.Computer.Registry.GetValue(regKey, "AdamFromSITI", Nothing) IsNot Nothing

'                PbValue = PbValue + 1
'                If PbValue >= 100 Then
'                    PbValue = 99
'                End If
'                PB_Cmd.Value = PbValue
'                Lbl_Procent.Text = PbValue & "%"
'                PbName.Value = PB_Cmd.Value
'                PbLabel.Text = Lbl_Procent.Text

'                CmdRunTime += 1
'                Thread.Sleep(1000)
'            Loop




'            cmdMsg = My.Computer.Registry.GetValue(regKey, "AdamFromSITI", Nothing)
'            cmdStatus = My.Computer.Registry.GetValue(regKey, "aqte0JMpr6ot/97sLWwKiw==", Nothing)




'            'Check for error
'            Dim Title As String


'            If cmdStatus = "ERROR" Then
'                Btn.BackColor = ColorTranslator.FromHtml(" 196, 69, 105")
'                'Btn.FlatAppearance.MouseOverBackColor = Color.Red
'                Btn.ForeColor = Color.Black
'                Notification(cmdName, cmdMsg, ToolTipIcon.Error)
'                PicBox_CmdRun.Image = My.Resources.NoCmdRunning
'                PicBoxName.Image = My.Resources.fail
'                Img_Status = 1
'                Title = "Command has failed!"
'            Else
'                'Btn.BackColor = ColorTranslator.FromHtml("106, 176, 76")
'                Btn.BackColor = ColorTranslator.FromHtml("106, 176, 76")
'                'Btn.FlatAppearance.MouseOverBackColor = Color.Green
'                Btn.ForeColor = Color.Black
'                Notification(cmdName, cmdMsg, ToolTipIcon.Info)
'                PicBox_CmdRun.Image = My.Resources.AnimationStatic
'                PicBoxName.Image = My.Resources.success
'                Img_Status = 0
'                Title = "Command ran successfully!"
'            End If



'            Pb1.Image = PicBoxName.Image

'            cmdBtnColor = Btn.BackColor

'            Btn_Test.BackColor = cmdBtnColor


'            Save()






'            TB_CmdResponse.Text = cmdMsg
'            PB_Cmd.Value = PB_Cmd.Maximum
'            Lbl_Procent.Text = 100 & "%"

'            LblMore.Text = cmdMsg

'            LblMoreBtn.Visible = True
'            LblMoreBtn.Show()


'            cmdEndSmalTalk(PbLabel, cmdName, CmdRunTime)



'            'PbLabel.Text = "Cmmand " & cmdName & " ran successfully in " & CmdRunTime & " seconds"

'            'Character label limit72
'            'If (cmdMsg.Length >= 52) Then
'            '    PbLabel.Text = cmdMsg.Substring(0, 52) & "..."
'            'Else
'            '    PbLabel.Text = cmdMsg
'            'End If






'            PbName.Hide()
'            PbLabel.ForeColor = Btn.BackColor

'            'PbLabel.Text = cmdName & " ran at " & DateTime.Now
'            ' PbLabel.Text = cmdMsg




'            'PbLabel.Location = TbName.Location
'            'PbLabel.Text = cmdName & " ran at " & DateTime.Now


'            '
'            '
'            'PbLabel.ForeColor = Color.Black
'            ' Btn.ForeColor = Color.Black



'            Btn.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Bold)



'            'Frame.Lbl_CmdStatus.Text = "Last command runned " & cmdName & " at " & DateTime.Now
'        Catch ex As Exception
'            LblMoreBtn.Show()
'            isCmdRunning = False



'            Btn.Enabled = True
'            Btn.TextAlign = ContentAlignment.MiddleCenter
'            Btn.Font = New Font("Verdana", 9.0F, FontStyle.Regular)
'            ' Btn.BackColor = Color.AliceBlue




'            ''Send to list view

'            Dim LI As New ListViewItem
'            LI.Text = cmdName
'            LI.ImageIndex = Img_Status
'            LI.SubItems.Add(cmdMsg)
'            LI.SubItems.Add(DateTime.Now)
'            ListView_Cmd2.Items.Add(LI)

'            ''JSON Serialize


'            'test

'            PB_Cmd.Hide()
'            Lbl_Procent.Location = New Point(317, 177)
'            Pb1.Location = New Point(282, 176)






'        Catch ex As Exception
'            Return Nothing
'        End Try
'        Return Nothing
'    End Function

'    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click



'        Dim btn As Button = CType(sender, Button)
'        PictureBox31.Image = My.Resources.PlayNext






'        Dim Thread As System.Threading.Thread
'        Thread = New System.Threading.Thread(AddressOf NetworkTroubleshoot)
'        Thread.Start(btn)

'    End Sub

'    Private Sub Btn_WinUpdate_Click(sender As Object, e As EventArgs) Handles Btn_WinUpdate.Click

'        Dim btn As Button = CType(sender, Button)



'        Dim Thread As System.Threading.Thread
'        Thread = New System.Threading.Thread(AddressOf WinUpdate)
'        Thread.Start(btn)



'    End Sub

'    Private Sub Label58_Click(sender As Object, e As EventArgs) Handles Label58.Click


'        PnlExtended = Panel15
'        ExpandCmdPnl(Pnl_WindowsUpdate, Label58)


'    End Sub

'    Private Sub Pnl_WindowsUpdate_Paint(sender As Object, e As PaintEventArgs) Handles Pnl_WindowsUpdate.Paint

'    End Sub

'    Public Function ChangeCmdPanel(btn As Button, Pnl As Panel)


'        Frame.Lbl_TopLabel.Text = btn.Text
'        Pnl_CommandAnimation.Show()

'        Pnl.Location = New Point(2, 351)
'        Pnl.BringToFront()




'        ' btn.BackColor = Color.Blue




'        ''Set default Style
'        Btn_Windows.Font = New Font("Roboto", 8.25F, FontStyle.Regular)
'        Btn_Network.Font = New Font("Roboto", 8.25F, FontStyle.Regular)
'        Btn_Antivirus.Font = New Font("Roboto", 8.25F, FontStyle.Regular)
'        Btn_Security.Font = New Font("Roboto", 8.25F, FontStyle.Regular)
'        Btn_Software.Font = New Font("Roboto", 8.25F, FontStyle.Regular)
'        Btn_Privacy.Font = New Font("Roboto", 8.25F, FontStyle.Regular)
'        Btn_Office.Font = New Font("Roboto", 8.25F, FontStyle.Regular)
'        Btn_Browser.Font = New Font("Roboto", 8.25F, FontStyle.Regular)

'        Btn_Windows.BackColor = ColorTranslator.FromHtml("44, 58, 71")
'        Btn_Network.BackColor = ColorTranslator.FromHtml("44, 58, 71")
'        Btn_Antivirus.BackColor = ColorTranslator.FromHtml("44, 58, 71")
'        Btn_Security.BackColor = ColorTranslator.FromHtml("44, 58, 71")
'        Btn_Software.BackColor = ColorTranslator.FromHtml("44, 58, 71")
'        Btn_Privacy.BackColor = ColorTranslator.FromHtml("44, 58, 71")
'        Btn_Office.BackColor = ColorTranslator.FromHtml("44, 58, 71")
'        Btn_Browser.BackColor = ColorTranslator.FromHtml("44, 58, 71")


'        btn.BackColor = ColorTranslator.FromHtml("30, 39, 46")
'        'btn.BackColor = ColorTranslator.FromHtml("109, 33, 79")



'        btn.Font = New Font("Roboto", 9.0F, FontStyle.Regular)


'        If btn.Name = Btn_Windows.Name Then

'            Pnl.Show()
'            Pnl.BringToFront()
'            Pnl.Location = New Point(2, 351)
'        End If




'        If btn.Name = Btn_Network.Name Then
'            btn.Font = New Font("Roboto", 9.0F, FontStyle.Regular)
'            Pnl.Show()
'            Pnl.BringToFront()
'            Pnl.Location = New Point(2, 351)
'        End If


'        If btn.Name = Btn_Antivirus.Name Then
'            btn.Font = New Font("Roboto", 9.0F, FontStyle.Regular)
'            Pnl.Show()
'            Pnl.BringToFront()
'            Pnl.Location = New Point(2, 351)
'        End If


'        If btn.Name = Btn_Security.Name Then
'            btn.Font = New Font("Roboto", 9.0F, FontStyle.Regular)
'            Pnl.Show()
'            Pnl.BringToFront()
'            Pnl.Location = New Point(2, 351)
'        End If

'        If btn.Name = Btn_Software.Name Then
'            btn.Font = New Font("Roboto", 9.0F, FontStyle.Regular)
'            Pnl.Show()
'            Pnl.BringToFront()
'            Pnl.Location = New Point(2, 351)
'        End If



'        If btn.Name = Btn_Privacy.Name Then
'            btn.Font = New Font("Roboto", 9.0F, FontStyle.Regular)
'            Pnl.Show()
'            Pnl.BringToFront()
'            Pnl.Location = New Point(2, 351)
'        End If

'        If btn.Name = Btn_Office.Name Then
'            btn.Font = New Font("Roboto", 9.0F, FontStyle.Regular)
'            Pnl.Show()
'            Pnl.BringToFront()
'            Pnl.Location = New Point(2, 351)
'        End If

'        If btn.Name = Btn_Browser.Name Then
'            btn.Font = New Font("Roboto", 9.0F, FontStyle.Regular)
'            Pnl.Show()
'            Pnl.BringToFront()
'            Pnl.Location = New Point(2, 351)
'        End If




'        Return Nothing
'    End Function

'    Public Function ButtonToolTip(Title As String, Button As Button, Text As String)

'        Dim but As New ToolTip()

'        but.ToolTipTitle = Title
'        but.UseFading = True
'        but.UseAnimation = True
'        but.IsBalloon = True
'        but.ShowAlways = True
'        but.AutoPopDelay = 5000
'        but.InitialDelay = 1000
'        but.ReshowDelay = 500
'        but.SetToolTip(Button, Text)

'        Return Nothing
'    End Function


'    'Public Function LabelToolTip(Title As String, Label As Label, Text As String) Handles Lbl_Temp.Click

'    '    Dim but As New ToolTip()

'    '    but.ToolTipTitle = Title
'    '    but.UseFading = True
'    '    but.UseAnimation = True
'    '    but.IsBalloon = True
'    '    but.ShowAlways = True
'    '    but.AutoPopDelay = 5000
'    '    but.InitialDelay = 1000
'    '    but.ReshowDelay = 500
'    '    but.SetToolTip(Label, Text)

'    '    Return Nothing
'    'End Function



'    Public Function cmdStartAnimation(cmdName As String)

'        Pb1.Location = New Point(154, 168)
'        Pb1.Image = My.Resources.PlayNext
'        Pb1.Show()

'        TB_Cmd.Text = cmdName
'        PB_Cmd.Show()

'        Lbl_Procent.Location = New Point(445, 177)
'        Lbl_Procent.Show()


'        TB_CmdResponse.Show()
'        Pnl_CommandAnimation.Show()


'        'Random message

'        Dim Ran As New Random
'        Dim random As New Random

'        Dim num_gif As Integer = Ran.Next(1, 5)
'        Dim num_msg As Integer = random.Next(1, 4)

'        ' Adam Welcome Output

'        If num_msg = 1 Then

'            TB_CmdResponse.Text = "Hi I`m Adam! Please wait while i run the " & cmdName & " command"
'        End If

'        If num_msg = 2 Then

'            TB_CmdResponse.Text = "Please wait while I run the " & cmdName & " command. Thank you!"
'        End If

'        If num_msg = 3 Then

'            TB_CmdResponse.Text = "Ok! Running " & cmdName & " command. Please wait"
'        End If

'        'Animation random


'        If num_gif = 1 Then
'            PicBox_CmdRun.Image = My.Resources.Animation1
'        End If

'        If num_gif = 2 Then
'            PicBox_CmdRun.Image = My.Resources.Animation2
'        End If

'        If num_gif = 3 Then
'            PicBox_CmdRun.Image = My.Resources.Animation3
'        End If

'        If num_gif = 4 Then
'            PicBox_CmdRun.Image = My.Resources.Animation4
'        End If



'        Return Nothing
'    End Function



'    Function cmdEndSmalTalk(Lbl As Label, cmdName As String, cmdRunTime As Integer)


'        Lbl.Show()
'        Lbl.Location = New Point(193, 6)

'        'Random message

'        Dim Ran As New Random

'        Dim num As Integer = Ran.Next(1, 5)

'        If num = 1 Then

'            cmdEndOutput = "Command " & cmdName & " run at " & DateTime.Now


'        End If

'        If num = 2 Then
'            cmdEndOutput = cmdName & "completed in " & cmdRunTime & " seconds!"
'        End If

'        If num = 3 Then

'            cmdEndOutput = "Command ended at" & DateTime.Now
'        End If


'        If num = 4 Then
'            cmdEndOutput = "Cmmand " & cmdName & " ran successfully in " & cmdRunTime & " seconds"
'        End If



'        'Character label limit72
'        If (cmdEndOutput.Length >= 52) Then
'            Lbl.Text = cmdEndOutput.Substring(0, 48) & "..."
'        Else
'            Lbl.Text = cmdEndOutput
'        End If






'        Return Nothing

'    End Function


'    Function ExpandCmdPnl(Pnl As Panel, lbl As Label)





'        If IsPnlExtended = 1 Then

'            lbl.Image = ImageList_ExpandBtns.Images(1)


'            Do Until Pnl.Size = Pnl.MinimumSize
'                Pnl.Height -= 10
'                Thread.Sleep(10)
'            Loop
'            lbl.Text = "More       "
'            IsPnlExtended = 0
'            Pnl.SendToBack()
'        Else

'            lbl.Image = ImageList_ExpandBtns.Images(0)
'            Pnl.BringToFront()

'            Do Until Pnl.Size = Pnl.MaximumSize
'                Pnl.Height += 10
'                Thread.Sleep(10)
'            Loop

'            lbl.Text = "Less       "
'            PnlExtended = Pnl
'            IsPnlExtended = 1


'        End If



'        Return Nothing

'    End Function

'    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

'    End Sub

'    Private Sub ListView_Cmd2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView_Cmd2.SelectedIndexChanged

'    End Sub

'    Private Sub Btn_Test_Click(sender As Object, e As EventArgs) Handles Btn_Test.Click

'    End Sub
'End Class






'Public Class CmdClass

'    Public btnName As String
'    Public cmdName As String
'    Public cmdMsg As String
'    Public cmdStatus As Integer
'    Public cmdDate As Date
'    Public btnPic As PictureBox




'End Class
