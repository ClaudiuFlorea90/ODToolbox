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
Imports Xamarin.Essentials
Imports Microsoft.VisualBasic.Devices
Imports System.Linq.Expressions
Imports System.Windows.Documents
Imports FontAwesome.Sharp
Imports Script_Agent.ToolBox
Imports CefSharp.WinForms

Public Class Frame



    Dim T1, T2, T3, T4, T5, T6 As System.Threading.Thread

    Dim isCollapsed As Boolean = True
    Dim isNotifyCollapsed As Boolean = True
    Dim isAccCollapsed As Boolean = True

    Public LastUrl As String


    'Public isCmdRunning As Boolean
    'Public cmdName As String
    'Public cmdMsg As String
    'Public cmdStatus As String



    Public agentCount As Integer = 0
    Public agentExeFound As Integer = 0



    Dim draggable As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer



    Public JsonLocation As String = My.Application.Info.DirectoryPath + "\Json\cmdJson.Json"



    Private Sub Frame_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        logger("App started", "Info")

        ToolBox.getID()

        Dim btn As Button = Btn_home
        Dim Str As String = "System Information"


        PanelExpandNotifications.Size = PanelExpandNotifications.MinimumSize



        PnlMain.Size = PnlMain.MaximumSize
        PnlMain.Location = New Point(52, 34)
        PnlMenu.Size = PnlMenu.MinimumSize
        PnlMenu.Location = New Point(0, 32)



        '  SetTopMenu(PanelTopMenu_Home, Button5)

        'SwitchMainPanel(Home, Str, btn)
        ' SwitchMainPanel(ToolBox, Str, btn)


        'fgerg
        SwitchMainPanel(ToolBox, Str, Btn_ToolBoxLeft)
        SetTopMenu(PnlSmallToolbox, Btn_ToolBoxTop)



        ToolBox.getID()



        If ToolBox.isAgentInstalled = True Then
            getUserFromAgent()
            'ToolBox.ChangeOverViewPnl(ToolBox.PanelMainBox)
            Command.SetMainPanel(ToolBox.PanelMainBox)
            ToolBox.SetBannerPanel(ToolBox.Panel_INFO, ToolBox.IconButton1)
        End If

        If ToolBox.isAgentInstalled = False Then
            'To install agent
            Command.SetMainPanel(ToolBox.PanelInstallNewAgent)
            ToolBox.PictureBox8.Image = ToolBox.agentToInstall.company_logo
            ToolBox.TextBox3.Text = ToolBox.agentToInstall.company_name
            ToolBox.TextBox31.Text = ToolBox.agentToInstall.company_id
            ToolBox.TextBox_AgentFrameWork.Text = ToolBox.ComboBox_FrameWork.Text
        End If

        If ToolBox.isInstallRunning = True Then
            Command.SetMainPanel(ToolBox.PanelLoading)
        End If

        For Each thing As Control In ToolBox.Controls
            thing.Show()
        Next



        Me.Size = Me.MinimumSize



    End Sub



    Public Sub ChromeBrowser(url As String, Pnl As Panel)



        Pnl.Controls.Clear()

        Dim Chrome As New ChromiumWebBrowser(url)
        Pnl.Controls.Add(Chrome)
        Chrome.Dock = DockStyle.Fill
        Chrome.BackColor = Color.Black
        LastUrl = Chrome.Address
        Chrome.Refresh()
    End Sub



    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim path As New Drawing2D.GraphicsPath()
        Dim rect As Rectangle = Me.ClientRectangle
        Dim radius As Integer = 15 ' adjust this to change the roundness of the corners

        path.StartFigure()
        path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90)
        path.AddLine(rect.X + radius, rect.Y, rect.Right - radius, rect.Y)
        path.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90)
        path.AddLine(rect.Right, rect.Y + radius, rect.Right, rect.Bottom - radius)
        path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90)
        path.AddLine(rect.Right - radius, rect.Bottom, rect.X + radius, rect.Bottom)
        path.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90)
        path.CloseFigure()

        Me.Region = New Region(path)
    End Sub


    Sub SetTopMenu(pnl As Panel, Btn As Button)

        ' Top menu panel
        Panel1.Size = Panel1.MinimumSize
        Panel1.Location = New Point(67, 3)

        If pnl IsNot Nothing Then
            pnl.Location = New Point(255, 3)
            pnl.Show()
            pnl.BringToFront()

            For Each item As Button In pnl.Controls.OfType(Of Button)()
                RoundedCorner(item, 5)
                item.ForeColor = Color.White
                item.BackColor = ColorTranslator.FromHtml("#2D98DA")
                item.Font = New Font("Microsoft PhagsPa", 9, FontStyle.Regular)
                '  item.Enabled = True
            Next

            Btn.ForeColor = Color.White
            ' Btn.ForeColor = Color.LightGray
            Btn.Font = New Font("Microsoft PhagsPa", 9, FontStyle.Bold)
            Btn.BackColor = ColorTranslator.FromHtml("#2C3A47")
            '   Btn.Enabled = False

        Else
            'For Each item In Panel1.Controls
            '    If TypeOf item Is Panel Then
            '        item.Hide()
            '    End If
            'Next
        End If


    End Sub


    Public Sub logger(log As String, logType As String)

        'Here Logger 

        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("log.log", True)
        file.WriteLine("[" & logType & "] - " & DateTime.Now & ": -> " & log)
        file.Close()

    End Sub

    Private Sub Btn_Ticket1_Click(sender As Object, e As EventArgs) Handles Btn_Ticket.Click


        Dim btn As Button = CType(sender, Button)
        Dim Str As String = "Create a ticket"

        SetTopMenu(Nothing, Nothing)
        SwitchMainPanel(Ticket, Str, btn)

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_Settings.Click

        Dim Str As String = "Settings"

        SwitchMainPanel(Settings, Str, Btn_Settings)
        SetTopMenu(Nothing, Nothing)

    End Sub


    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click

        Shell("taskkill /F /IM Script-Agent.exe /T", 0)

    End Sub





    Private Sub Btn_Minimize_Click(sender As Object, e As EventArgs) Handles Btn_Minimize.Click

        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles Button5.Click, PictureBox1.Click


        Dim btn As Button = Btn_home
        Dim Str As String = "System Information"

        SwitchMainPanel(Home, Str, btn)
        SetTopMenu(PanelTopMenu_Home, Button5)

        SwitchSecondPanel(Home.PanelStatus)


    End Sub

    Private Sub PictureBox1_hover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover

        If PictureBox1.Size = PictureBox1.MinimumSize Then
            PictureBox1.Size = PictureBox1.MaximumSize
        End If

    End Sub

    Private Sub PictureBox1_Leave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave

        If PictureBox1.Size = PictureBox1.MaximumSize Then
            PictureBox1.Size = PictureBox1.MinimumSize
        End If

    End Sub


    Private Sub Btn_VirusScan_Click(sender As Object, e As EventArgs) Handles Btn_VirusScan.Click, Button10.Click



        Dim Str As String = "Virus Scan"
        Dim btn As Button = CType(sender, Button)


        SwitchMainPanel(VirusScanForm, Str, btn)
        SetTopMenu(Panel5, Button10)

    End Sub

    Private Sub ExpandLeftMenu_Tick(sender As Object, e As EventArgs) Handles ExpandLeftMenu.Tick



        If isCollapsed Then

            PnlMenu.Width += 33

            If PnlMenu.Size = PnlMenu.MaximumSize Then
                For Each item As Button In PnlMenu.Controls

                    item.Width = PnlMenu.Width
                    item.ImageAlign = ContentAlignment.MiddleLeft

                Next

                Btn_ToolBoxLeft.Text = " Toolbox"
                Btn_Ticket.Text = " Support"
                Btn_Commands.Text = " Commands"
                Btn_VirusScan.Text = " Virus Scan"
                Btn_Browser.Text = " Browser"
                Button11.Text = " Settings"

                isCollapsed = False
                PnlMenu.BringToFront()
                ExpandLeftMenu.Stop()
            End If
        Else

            PnlMenu.Width -= 33

            If PnlMenu.Size = PnlMenu.MinimumSize Then
                For Each item As Button In PnlMenu.Controls

                    item.Text = ""
                    item.Width = PnlMenu.Width
                    item.ImageAlign = ContentAlignment.MiddleCenter

                Next
                isCollapsed = True
                PnlMain.SendToBack()
                ExpandLeftMenu.Stop()
            End If
        End If


        For Each item As Button In PnlMenu.Controls
            If item.GetType = GetType(Button) Then
                RoundedCorner(item, 5)
            End If

        Next
    End Sub

    Private Sub ExpandNotifications_Tick(sender As Object, e As EventArgs) Handles ExpandNotifications.Tick

        If isNotifyCollapsed Then


            PanelExpandNotifications.Location = New Point(525, 70)

            PanelExpandNotifications.Show()
            PanelExpandNotifications.BringToFront()


            PanelExpandNotifications.Width += 30
            PanelExpandNotifications.Height += 60



            If PanelExpandNotifications.Size = PanelExpandNotifications.MaximumSize Then


                isNotifyCollapsed = False
                ExpandNotifications.Stop()

            End If
        Else

            PanelExpandNotifications.Width -= 60
            PanelExpandNotifications.Height -= 60
            PanelExpandNotifications.Hide()

            If PanelExpandNotifications.Size = PanelExpandNotifications.MinimumSize Then

                PanelExpandNotifications.SendToBack()

                isNotifyCollapsed = True
                ExpandNotifications.Stop()

            End If



        End If


    End Sub


    Private Sub PictureBoxNotifications_Hover(sender As Object, e As EventArgs) Handles PictureBoxNotifications.MouseHover

        ExpandNotifications.Start()

    End Sub

    Private Sub ExpandAccount_Tick(sender As Object, e As EventArgs) Handles ExpandAccount.Tick

        If isAccCollapsed Then


            PanelExpandAccount.Location = New Point(525, 70)

            PanelExpandAccount.Show()
            PanelExpandAccount.BringToFront()


            PanelExpandAccount.Width += 30
            PanelExpandAccount.Height += 60



            If PanelExpandAccount.Size = PanelExpandAccount.MaximumSize Then


                isAccCollapsed = False
                ExpandAccount.Stop()

            End If
        Else

            PanelExpandAccount.Width -= 60
            PanelExpandAccount.Height -= 60
            PanelExpandAccount.Hide()

            If PanelExpandAccount.Size = PanelExpandAccount.MinimumSize Then

                PanelExpandAccount.SendToBack()

                isAccCollapsed = True
                ExpandAccount.Stop()

            End If



        End If

    End Sub

    'Private Sub PictureBoxAccount_Hover(sender As Object, e As EventArgs) Handles PictureBoxAccount.MouseHover
    '    ExpandAccount.Start()

    'End Sub

    Private Sub Btn_NitifyOptions_Hover(sender As Object, e As EventArgs) Handles Btn_NotifyOptions.MouseHover

        Btn_NotifyOptions.ForeColor = ColorTranslator.FromHtml("0, 151, 230")

    End Sub

    Private Sub Btn_NitifyOptions_MouseLeave(sender As Object, e As EventArgs) Handles Btn_NotifyOptions.MouseLeave

        Btn_NotifyOptions.ForeColor = ColorTranslator.FromHtml("245, 246, 250")

    End Sub

    Private Sub Btn_NitifyOptions_Click(sender As Object, e As EventArgs) Handles Btn_NotifyOptions.Click


        'ContextMenuStrip1.Show(CType(sender, Control), sender.Location)

        'ContextMenuStrip1.Show(CType(sender, Control), 15, 40)



        Dim MousePosition As Point
        MousePosition = Cursor.Position

        'ContextMenuStrip1.Show(CType(sender, Control), MousePosition)
        ContextMenuNotify.Show(CType(sender, Control), mouseX, mouseY)


        'Btn_NitifyOtions
    End Sub


    Private Sub PictureBoxAccount_Click(sender As Object, e As EventArgs) Handles PictureBoxAccount.Click
        '   ExpandAccount.Start()
    End Sub

    Private Sub PictureBoxNotifications_Click(sender As Object, e As EventArgs) Handles PictureBoxNotifications.Click
        ' ExpandNotifications.Start()
    End Sub

    Private Sub Lbl_NotifyCount_Click(sender As Object, e As EventArgs) Handles Lbl_NotifyCount.Click
        ' ExpandNotifications.Start()
    End Sub

    Private Sub PnlMenu_Click(sender As Object, e As EventArgs) Handles PnlMenu.MouseClick
        ExpandLeftMenu.Start()
    End Sub

    Private Sub PnlMenu_Hover(sender As Object, e As EventArgs) Handles PnlMenu.MouseHover
        ExpandLeftMenu.Start()
    End Sub


    Private Sub PnlMenu_Leave(sender As Object, e As EventArgs) Handles PnlMenu.MouseLeave
        If isCollapsed = False Then
            ExpandLeftMenuCooldown.Start()
        End If
    End Sub

    Private Sub ExpandLeftMenuCooldown_Tick(sender As Object, e As EventArgs) Handles ExpandLeftMenuCooldown.Tick

        If isCollapsed = False Then
            ExpandLeftMenu.Start()
        End If

        ExpandLeftMenuCooldown.Stop()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Dim Str As String = "Test"
        Dim btn As Button = CType(sender, Button)
        'SwitchMainPanel(BrowserForm, Str, btn)
        Dim Browser As New BrowserForm
        Browser.Show()
    End Sub

    Private Sub Btn_Browser_Click(sender As Object, e As EventArgs) Handles Btn_Browser.Click

        Dim Str As String = "Browser"
        Dim btn As Button = CType(sender, Button)


        SwitchMainPanel(Nothing, Str, btn)
        SetTopMenu(Nothing, Nothing)

        Dim Browser As New BrowserForm
        Browser.Show()

    End Sub


    'Private Sub Buttton_Paint(sender As Object, e As PaintEventArgs) Handles Btn_ToolBoxLeft.Paint, Btn_Commands.Paint, Btn_VirusScan.Paint, Btn_Browser.Paint, Btn_Ticket.Paint, Btn_Settings.Paint

    '    ToolBox.RoundedCorner(sender, 9)

    'End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_ToolBoxLeft.Click


        For Each thing As Control In ToolBox.Controls
            thing.Hide()
        Next





        Dim Str As String = "ToolBox"
        Dim btn As Button = CType(sender, Button)

        SwitchMainPanel(ToolBox, Str, btn)
        SetTopMenu(PnlSmallToolbox, Btn_ToolBoxTop)



        ToolBox.getID()




        If ToolBox.isAgentInstalled = True Then
            getUserFromAgent()
            Command.SetMainPanel(ToolBox.PanelMainBox)
            ToolBox.SetBannerPanel(ToolBox.Panel_INFO, ToolBox.IconButton1)
        End If

        If ToolBox.isAgentInstalled = False Then
            'To install agent
            Command.SetMainPanel(ToolBox.PanelInstallNewAgent)
        End If

        If ToolBox.isInstallRunning = True Then
            Command.SetMainPanel(ToolBox.PanelLoading)
        End If

        For Each thing As Control In ToolBox.Controls
            thing.Show()
        Next


        'Me.Refresh()
        ToolBox.Refresh()


    End Sub


    Private Sub Btn_ToolBoxTop_Click(sender As Object, e As EventArgs) Handles Btn_ToolBoxTop.Click

        SetTopMenu(PnlSmallToolbox, Btn_ToolBoxTop)


        If ToolBox.isAgentInstalled = True Then
            ToolBox.ChangeOverViewPnl(ToolBox.PanelMainBox)
        Else
            ToolBox.ChangeOverViewPnl(ToolBox.PanelInstallNewAgent)
        End If

        If ToolBox.isInstallRunning = True Then
            ToolBox.ChangeOverViewPnl(ToolBox.PanelLoading)
        End If


    End Sub




    Private Sub Lbl_Scanner_Click(sender As Object, e As EventArgs) Handles Lbl_Scanner.Click


        If isScanning = True Then

            If VirusScanForm.Panel_Expand_Scanner.Size = VirusScanForm.Panel_Expand_Scanner.MaximumSize Then
                Command.ChangeScanningPanel(VirusScanForm.Pnl_IsScanning)


            End If

        Else



        End If

        VirusScanForm.swichPanel(VirusScanForm.Panel_Scanner, Nothing, Nothing)
        SetTopMenu(Panel5, Button10)


    End Sub

    Private Sub Lbl_Scheduler_Click(sender As Object, e As EventArgs) Handles Lbl_Scheduler.Click


        SetTopMenu(Panel5, Button9)
        VirusScanForm.swichPanel(VirusScanForm.Panel_Scheduler, Nothing, Nothing)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        SetTopMenu(Panel5, Button9)
        VirusScanForm.swichPanel(VirusScanForm.Panel_Scheduler, Nothing, Nothing)


    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click


        SetTopMenu(Panel5, Button8)


        If VirusScanForm.isScanCompleted = True Then
            VirusScanForm.Panel11.Hide()
            VirusScanForm.DataGridView2.Show()
            VirusScanForm.swichPanel(VirusScanForm.Pnl_Reports, Nothing, Nothing)
        Else
            VirusScanForm.DataGridView2.Hide()
            VirusScanForm.Panel11.Show()
            VirusScanForm.swichPanel(VirusScanForm.Pnl_Reports, Nothing, Nothing)
        End If


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        SetTopMenu(PnlSmallToolbox, Button4)
        ToolBox.ChangeOverViewPnl(ToolBox.PanelDecryptor)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        SetTopMenu(PnlSmallToolbox, Button3)
        ToolBox.ChangeOverViewPnl(ToolBox.PanelEventViewer)
    End Sub



    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        Dim Str As String = "Settings"


        SwitchMainPanel(Settings, Str, Btn_Settings)
        SetTopMenu(Nothing, Nothing)


    End Sub



    Private Sub PnlMain_Paint(sender As Object, e As PaintEventArgs) Handles PnlMain.Paint
        'ToolBox.RoundedCorner(Me.PnlMain, 20)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Dim btn As Button = Btn_home
        Dim Str As String = "Updater"

        SwitchMainPanel(Home, Str, btn)
        SetTopMenu(PanelTopMenu_Home, Button6)
        SwitchSecondPanel(Home.PanelUpdater)


    End Sub

    Private Sub Btn_Commands_Click(sender As Object, e As EventArgs) Handles Btn_Commands.Click

        Dim Str As String = "Commands"
        Dim btn As Button = CType(sender, Button)

        SetTopMenu(Nothing, Nothing)
        SwitchMainPanel(cmdPnl, Str, btn)

    End Sub


    Sub SwitchMainPanel(ByVal panel As Form, TopStr As String, Btn As Button)

        If panel IsNot Nothing Then

            panel.Hide()

            For Each item As Control In PnlMenu.Controls
                If item.GetType = GetType(Button) Then
                    item.BackColor = ColorTranslator.FromHtml("30, 39, 46")
                    ' item.Enabled = True
                End If
            Next



            Btn.BackColor = ColorTranslator.FromHtml("109, 33, 79")
            'Btn.Enabled = False
            Lbl_TopLabel.Text = TopStr
            PnlMain.Controls.Clear()
            panel.TopLevel = False
            PnlMain.Controls.Add(panel)


            panel.Show()

            'To show ticket title as Top label if ticket was created for
            If Btn.Name = Btn_Ticket.Name Then
                If Ticket.Is_Ticket_Created Then
                    Lbl_TopLabel.Text = Ticket.Ticket_Title
                End If
            End If
        End If

    End Sub

    Public Sub SwitchSecondPanel(pnl As Panel)

        pnl.Size = pnl.MaximumSize
        pnl.Location = New Point(0, 0)
        pnl.BringToFront()
        pnl.Show()

    End Sub




    Private Sub Pnl_Top_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown, Label1.MouseDown, PictureBox1.MouseDown, Lbl_TopLabel.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Pnl_Top_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove, Label1.MouseMove, PictureBox1.MouseMove, Lbl_TopLabel.MouseMove

        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If

    End Sub

    Private Sub Pnl_Top_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp, Label1.MouseUp, PictureBox1.MouseUp, Lbl_TopLabel.MouseUp
        draggable = False

    End Sub

End Class