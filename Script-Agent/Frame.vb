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




Public Class Frame



    Dim T1, T2, T3, T4, T5, T6 As System.Threading.Thread

    Dim isCollapsed As Boolean = True
    Dim isNotifyCollapsed As Boolean = True
    Dim isAccCollapsed As Boolean = True




    'Public isCmdRunning As Boolean
    'Public cmdName As String
    'Public cmdMsg As String
    'Public cmdStatus As String







    Dim draggable As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer








    Public JsonLocation As String = My.Application.Info.DirectoryPath + "\Json\cmdJson.Json"



    Private Sub Frame_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        logger("App started", "Info")



        Dim btn As Button = Btn_home
        Dim Str As String = "System Information"

        SwitchMainPanel(Home, Str, btn)


        ScanSteps.Activate()
        ScanOptions.Activate()


        PanelExpandNotifications.Size = PanelExpandNotifications.MinimumSize



        PnlMain.Size = PnlMain.MaximumSize
        PnlMain.Location = New Point(67, 71)



        PnlMenu.Size = PnlMenu.MinimumSize
        PnlMenu.Location = New Point(0, 71)

        Panel6.Location = New Point(660, 38)




        Me.Size = Me.MinimumSize








    End Sub


    'Here Logger 

    Public Sub logger(log As String, logType As String)



        Dim file As System.IO.StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter("log.log", True)
        'Dim LogFile As String = My.Application.Info.DirectoryPath + "log.log"
        file.WriteLine("[" & logType & "] - " & DateTime.Now & ": -> " & log)
        file.Close()





    End Sub
























    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Ticket.Click

        Dim btn As Button = CType(sender, Button)

        Dim Str As String = "Create a ticket"


        SwitchMainPanel(Ticket, Str, btn)

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_Settings.Click, PictureBoxSettings.Click



        Dim Str As String = "Settings"


        SwitchMainPanel(Settings, Str, Btn_Settings)


    End Sub


    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click



        Dim response As Integer
        response = MessageBox.Show("Are you sure you wish to quick?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = vbYes Then

            Shell("taskkill /F /IM Script-Agent.exe /T", 0)

        End If




    End Sub





    Private Sub Btn_Minimize_Click(sender As Object, e As EventArgs) Handles Btn_Minimize.Click

        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PB_Logo.Click


        Dim btn As Button = Btn_home
        Dim Str As String = "System Information"

        SwitchMainPanel(Home, Str, btn)



    End Sub


    Private Sub Btn_VirusScan_Click(sender As Object, e As EventArgs) Handles Btn_VirusScan.Click



        Dim Str As String = "Virus Scan"
        Dim btn As Button = CType(sender, Button)


        SwitchMainPanel(VirusScanForm, Str, btn)


    End Sub

    Private Sub ExpandLeftMenu_Tick(sender As Object, e As EventArgs) Handles ExpandLeftMenu.Tick


        If isCollapsed Then

            PnlMenu.Width += 33
            PnlMenu.Height += 33


            If PnlMenu.Size = PnlMenu.MaximumSize Then

                PnlMain.Size = PnlMain.MinimumSize
                PnlMain.Location = New Point(175, 71)
                Btn_Ticket.Text = "Support"
                Btn_Commands.Text = "Commands"
                Btn_VirusScan.Text = "Virus Scan"
                Btn_Browser.Text = "Browser"
                Btn_Ticket.Size = Btn_Ticket.MaximumSize
                Btn_Commands.Size = Btn_Commands.MaximumSize
                Btn_VirusScan.Size = Btn_VirusScan.MaximumSize
                Btn_Browser.Size = Btn_Browser.MaximumSize
                PnlMenu.BringToFront()
                PnlMain.SendToBack()
                ExpandLeftMenu.Stop()
                isCollapsed = False

                'Set Form Size +105
                Me.Size = Me.MaximumSize
                Panel1.Size = Panel1.MaximumSize


                Btn_Minimize.Location = New Point(713, 3)

                Btn_Exit.Location = New Point(754, 3)

                Panel6.Location = New Point(768, 38)

            End If
        Else


            PnlMenu.Height -= 33
            PnlMenu.Width -= 33
            If PnlMenu.Size = PnlMenu.MinimumSize Then

                Btn_Ticket.Size = Btn_Ticket.MinimumSize
                Btn_Commands.Size = Btn_Commands.MinimumSize
                Btn_VirusScan.Size = Btn_VirusScan.MinimumSize
                Btn_Browser.Size = Btn_Browser.MinimumSize


                Btn_Ticket.Text = ""
                Btn_Commands.Text = ""
                Btn_VirusScan.Text = ""
                Btn_Browser.Text = ""


                PnlMain.Size = PnlMain.MaximumSize
                PnlMain.Location = New Point(67, 71)

                PnlMenu.SendToBack()
                PnlMain.BringToFront()

                ExpandLeftMenu.Stop()
                isCollapsed = True

                Me.Size = Me.MinimumSize
                Panel1.Size = Panel1.MinimumSize

                Btn_Minimize.Location = New Point(602, 3)
                Btn_Exit.Location = New Point(643, 3)
                Panel6.Location = New Point(660, 38)

            End If
        End If





    End Sub

    Private Sub Pnl_Top_Paint(sender As Object, e As PaintEventArgs)

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

    Private Sub PictureBoxAccount_Hover(sender As Object, e As EventArgs) Handles PictureBoxAccount.MouseHover
        ExpandAccount.Start()

    End Sub

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

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuNotify.Opening

    End Sub



    'Private Sub PnlMenu_Hover(sender As Object, e As EventArgs) Handles PnlMenu.MouseHover

    '    ExpandLeftMenu.Start()


    'End Sub

    'Private Sub PnlMain_Hover(sender As Object, e As EventArgs) Handles PnlMain.MouseEnter
    '    ExpandLeftMenu.Start()

    'End Sub

    Private Sub PnlMenu_Click(sender As Object, e As EventArgs) Handles PnlMenu.Click
        ExpandLeftMenu.Start()
    End Sub

    Private Sub PictureBoxAccount_Click(sender As Object, e As EventArgs) Handles PictureBoxAccount.Click
        ExpandAccount.Start()

    End Sub

    Private Sub PictureBoxNotifications_Click(sender As Object, e As EventArgs) Handles PictureBoxNotifications.Click
        ExpandNotifications.Start()


    End Sub

    Private Sub Lbl_NotifyCount_Click(sender As Object, e As EventArgs) Handles Lbl_NotifyCount.Click
        ExpandNotifications.Start()

    End Sub

    Private Sub PnlMenu_Hover(sender As Object, e As EventArgs) Handles PnlMenu.MouseHover
        ExpandLeftMenu.Start()
    End Sub

    Private Sub PnlMenu_Paint(sender As Object, e As PaintEventArgs) Handles PnlMenu.Paint

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


        Dim Browser As New BrowserForm
        Browser.Show()

    End Sub

    Private Sub Btn_Commands_Click(sender As Object, e As EventArgs) Handles Btn_Commands.Click


        Dim Str As String = "Commands"
        Dim btn As Button = CType(sender, Button)


        SwitchMainPanel(cmdPnl, Str, btn)

    End Sub


    Sub SwitchMainPanel(ByVal panel As Form, TopStr As String, Btn As Button)


        If panel IsNot Nothing Then


            'Set default Style
            Btn_Ticket.BackColor = ColorTranslator.FromHtml("30, 39, 46")
            Btn_Commands.BackColor = ColorTranslator.FromHtml("30, 39, 46")
            Btn_Settings.BackColor = ColorTranslator.FromHtml("30, 39, 46")
            Btn_VirusScan.BackColor = ColorTranslator.FromHtml("30, 39, 46")
            Btn_Browser.BackColor = ColorTranslator.FromHtml("30, 39, 46")

            Btn.BackColor = ColorTranslator.FromHtml("109, 33, 79")

            Lbl_TopLabel.Text = TopStr
            PixBox_Top.Image = Btn.Image


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

    Private Sub Pnl_Top_MouseDown(sender As Object, e As MouseEventArgs) Handles Lbl_TopLabel.MouseDown, PixBox_Top.MouseDown, PB_Logo.MouseDown, Panel1.MouseDown, Label1.MouseDown


        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top




    End Sub

    Private Sub Pnl_Top_MouseMove(sender As Object, e As MouseEventArgs) Handles Lbl_TopLabel.MouseMove, PixBox_Top.MouseMove, PB_Logo.MouseMove, Panel1.MouseMove, Label1.MouseMove

        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If

    End Sub

    Private Sub Pnl_Top_MouseUp(sender As Object, e As MouseEventArgs) Handles Lbl_TopLabel.MouseUp, PixBox_Top.MouseUp, PB_Logo.MouseUp, Panel1.MouseUp, Label1.MouseUp


        draggable = False

    End Sub



End Class





