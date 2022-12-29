

Imports System.Windows.Interop
Imports CefSharp

Public Class ToolBox

    Dim isAgentInstalled As Boolean = False

    Dim CompanyToInstall As String
    Dim DownloadUrl As String
    Dim InstallStatus As String
    Dim Beta As Boolean
    Dim T1 As New System.Threading.Thread(AddressOf InstallAgent)

    Public Structure CompanyDetails
        Public company_id As String
        Public company_name As String
        Public company_logo As Image
        Public proxy_server As String
        Public proxy_port As String
        Public agent_version As String
        Public beta_version As Boolean
        Public ftp As String

    End Structure


    Sub Agent()


        CompanyToInstall = ComboBoxCompany.Text

            Dim agent As New CompanyDetails

            If CompanyToInstall = "TechServices" Then



                agent.company_id = Module1.TechID
                agent.company_name = "TechServices"
            agent.company_logo = My.Resources.logoTech
            agent.beta_version = Beta
                agent.agent_version = ComboBox1.Text
                agent.ftp = "https://updateor.optimumdesk.com/download/884c3b4485160e19f93ffe73cf719fa6b081b7a7/company/20621/setup.exe"


            End If

            If CompanyToInstall = "True Solutions" Then

                agent.company_id = Module1.TrueID
                agent.company_name = "True Solutions"
            agent.company_logo = My.Resources.TrueLogo
            agent.beta_version = Beta
                agent.agent_version = ComboBox1.Text
                agent.ftp = "https://update.optimumdesk.com/public/compiledEC/true/setup.exe"


            End If


        DownloadUrl = agent.ftp
        PictureBox8.Image = agent.company_logo

    End Sub


    Sub InstallAgent()

        Try


            If System.IO.File.Exists(My.Application.Info.DirectoryPath + "\setup.exe") = True Then
                My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath + "\setup.exe")
            End If

            My.Computer.Network.DownloadFile(DownloadUrl, My.Application.Info.DirectoryPath + "\setup.exe")





        Catch ex As Exception

            Frame.logger(ex.Message + CompanyToInstall, "Error")

        End Try




    End Sub






    Sub ChangeOverViewPnl(pnl As Panel)





        pnl.Location = New Point(2, 40)
        '  pnl.Location = pnl.MaximumSize
        pnl.Show()
        pnl.BringToFront()


        Me.Refresh()



    End Sub



    Private Sub ToolBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label10.Text = ComboBox1.Text






        Me.Size = Me.MinimumSize

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click

        If CheckBox1.Checked = True Then
            Beta = True
        Else
            Beta = False

        End If




        T1.Start()



        ChangeOverViewPnl(Panel8)

    End Sub

    Private Sub Label42342_Click(sender As Object, e As EventArgs) Handles Label42342.Click

        If isAgentInstalled = True Then

            ChangeOverViewPnl(Panel8)

        Else


            ChangeOverViewPnl(Panel10)


        End If

    End Sub

    Private Sub Lbl_432_Click(sender As Object, e As EventArgs) Handles Lbl_432.Click
        ChangeOverViewPnl(Panel_ED)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked Then
            Label13.Text = "BETA"
        Else
            Label13.Text = "LIVE"
        End If




    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        Label10.Text = ComboBox1.Text


    End Sub

    Private Sub ComboBoxAgentVersion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCompany.SelectedIndexChanged


        Button1.Text = "Install " + ComboBoxCompany.Text
        Agent()
    End Sub

    Private Sub Panel_InstallAgent_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class