Imports System.Windows.Controls
Imports CefSharp
Imports CefSharp.WinForms
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
Imports OpenHardwareMonitor
Imports OpenHardwareMonitor.Hardware
Imports Computer = OpenHardwareMonitor.Hardware.Computer
Imports System.Security.Cryptography



Public Class BrowserForm

    Dim LastUrl As String
    Dim Chrome As New ChromiumWebBrowser("us.optimumdesk.com")


    Public Structure History

        Dim lastUrl As String



    End Structure





    Private Sub AdamChat_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        ChromeBrowser("us.optimumdesk.com")





        PanelChromeBrowser.Size = Me.Size





    End Sub


    Public Sub ChromeBrowser(url As String)





        PanelChromeBrowser.Controls.Clear()

        Dim Chrome As New ChromiumWebBrowser(url)
        PanelChromeBrowser.Controls.Add(Chrome)
        Chrome.Dock = DockStyle.Fill

        LastUrl = Chrome.Address
        Chrome.Refresh()





        TextBoxUrl.Text = Chrome.Address



    End Sub






    Private Sub TextBoxUrl_Keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxUrl.KeyPress


        If TextBoxUrl.Text IsNot "" Then
            If e.KeyChar = Convert.ToChar(13) Then


                ChromeBrowser(TextBoxUrl.Text)
            End If

        End If



    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        ' Chrome.Refresh()
        ChromeBrowser(TextBoxUrl.Text)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click



        'WebBrowser1.GoForward()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        ChromeBrowser(LastUrl)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ChromeBrowser(TextBoxUrl.Text)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles SetPnlSize.Tick

        If PanelChromeBrowser.Size <> Me.Size Then

            PanelChromeBrowser.Size = Me.Size

        End If

        If Panel1.Width <> PanelChromeBrowser.Width Then

            Panel1.Width = PanelChromeBrowser.Width

        End If





    End Sub
End Class