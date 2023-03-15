Imports System.Threading

Public Class Ticket




    Public Is_Ticket_Created As Boolean

    Public Ticket_Title As String
    Public Ticket_Description As String



    Public TechName As String
    Public TechMsg As String
    Public MeMsg As String


    Public Function SendToHistory(t_title As String, t_description As String)



        Me.DataGridView1.Rows.Add(t_title, t_description, DateTime.Now)




        Return Nothing
    End Function



    Sub Random_Tech_Name()

        Dim Ran As New Random
        Dim tech_name As Integer = Ran.Next(1, 5)


        If tech_name = 1 Then
            TechName = "Gheorghe Vasile"
        End If

        If tech_name = 2 Then
            TechName = "Marian Ion"
        End If

        If tech_name = 3 Then
            TechName = "Florea Claudiu"
        End If

        If tech_name = 4 Then
            TechName = "Andrei Vajea"
        End If



    End Sub

    Sub MeSendMsg()

        Do

            Dim Ran As New Random
            Dim msg As Integer = Ran.Next(1, 5)

            If msg = 1 Then
                MeMsg = "Me: I`m just fine!"
            End If

            If msg = 2 Then
                MeMsg = "Me: I`m ok with that"
            End If

            If msg = 3 Then
                MeMsg = "Me: Are you there?"
            End If

            If msg = 4 Then
                MeMsg = "Me: I need help " & TechName
            End If



            TextBox2.Text &= Environment.NewLine & MeMsg
            Thread.Sleep(3000)
            TextBox2.Text &= Environment.NewLine

        Loop



    End Sub


    Public Function TechSendMsg()

        TextBox2.Clear()

        Do
            Dim Ran As New Random
            Dim tech_msg As Integer = Ran.Next(1, 6)


            If tech_msg = 1 Then
                TechMsg = ": How can I help you?"
            End If

            If tech_msg = 2 Then
                TechMsg = ": What can I do for you?"
            End If

            If tech_msg = 3 Then
                TechMsg = ": What is this " & Ticket_Title & "you need help with ?"
            End If

            If tech_msg = 4 Then
                TechMsg = ": Hello? are you here?"
            End If

            If tech_msg = 5 Then
                TechMsg = ": Hello? my name is " & TechName & " are you here?"
            End If

            TextBox2.Text &= Environment.NewLine & TechName & TechMsg
            Thread.Sleep(3000)
            TextBox2.Text &= Environment.NewLine
        Loop
        Return Nothing

    End Function



    Sub Send_Ticket()


        If TbTitleES.Text = "Title" Then
            MessageBox.Show("Please enter title", "Expert support", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            Ticket_Title = TbTitleES.Text
        End If

        If TbDescriptionES.Text = "Description" Then
            MessageBox.Show("Please enter description", "Expert support", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            Ticket_Description = TbDescriptionES.Text
        End If



        MessageBox.Show("Ticket " & Ticket_Title & " was send", "Expert support", MessageBoxButtons.OK, MessageBoxIcon.Information)



        TbTitleES.Text = "Title"
        TbDescriptionES.Text = "Description"
        'Label11.Text = Ticket_Title






        ShowTicketCreatedPanel()
        Random_Tech_Name()

        Dim Thread1 As New System.Threading.Thread(AddressOf TechSendMsg)
        Dim Thread2 As New System.Threading.Thread(AddressOf MeSendMsg)


        Thread1.Start()
        Thread2.Start()



        Label12.Text = DateTime.Now
        Label8.Text = TechName

        Is_Ticket_Created = True
        SendToHistory(Ticket_Title, Ticket_Description)

    End Sub









    Private Sub Button2_Click(sender As Object, e As EventArgs)


        'SwitchPanel(Pnl_ExpertTicket)

    End Sub

    Private Sub Ticket_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Panel_1.Show()
        Panel_2.Hide()
        Panel_3.Hide()

        Me.Size = Frame.PnlMain.MaximumSize


    End Sub



    Function AdamChatMessages(txt As String)


        Tb_AdamChat.TextAlign = HorizontalAlignment.Left

        Tb_AdamChat.Text &= Environment.NewLine & txt & ": Me"


        'Random message

        Dim Ran As New Random
        Dim random As New Random

        Dim num_gif As Integer = Ran.Next(1, 5)
        Dim num_msg As Integer = random.Next(1, 4)


        ' Adam Welcome Output




        If num_msg = 1 Then

            Tb_AdamChat.Text &= Environment.NewLine & "Adam Intop: " & "Ok. Great!"
        End If

        If num_msg = 2 Then

            Tb_AdamChat.Text &= Environment.NewLine & "Adam Intop: " & "Sure! Nice to meet you!"
        End If

        If num_msg = 3 Then

            Tb_AdamChat.Text &= Environment.NewLine & "Adam Intop: " & txt & " ? Don't know if I can do that.."

        End If

        Tb_AdamChat.TextAlign = HorizontalAlignment.Right

        TextBox1.Clear()
        TextBox1.Text = "Message"

        Return Nothing

    End Function


    Sub ShowTicketCreatedPanel()

        Frame.Lbl_TopLabel.Text = Ticket_Title
        Panel_TicketCreated.Show()
        Panel_TicketCreated.BringToFront()
        Panel_TicketCreated.Location = New Point(8, 48)

    End Sub






    Sub SwitchPanel(panel As Panel, lblBtn As Label, ColorPnl As Panel)


        Panel_1.Hide()
        Panel_2.Hide()
        Panel_3.Hide()

        Label5.Font = New Font("Trebuchet MS", 13.0F, FontStyle.Regular)
        Label16.Font = New Font("Trebuchet MS", 13.0F, FontStyle.Regular)
        Label4.Font = New Font("Trebuchet MS", 13.0F, FontStyle.Regular)




        Label5.ForeColor = Color.LightGray
        Label16.ForeColor = Color.LightGray
        Label4.ForeColor = Color.LightGray

        Label5.Font = New Font("Trebuchet MS", 13.0F, FontStyle.Regular)
        Label16.Font = New Font("Trebuchet MS", 13.0F, FontStyle.Regular)
        Label4.Font = New Font("Trebuchet MS", 13.0F, FontStyle.Regular)


        lblBtn.ForeColor = ColorTranslator.FromHtml("240, 147, 43")
        lblBtn.Font = New Font("Trebuchet MS", 13.5F, FontStyle.Bold)


        panel.BringToFront()
        panel.Location = New Point(8, 48)
        ColorPnl.Show()


    End Sub

    Private Sub BtnHistory_Click(sender As Object, e As EventArgs)

        'SwitchPanel(Pnl_History)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button3.Click, Button2.Click, Button4.Click

        If TextBox1.Text = "Message" Then

        Else



            AdamChatMessages(TextBox1.Text)


        End If

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click



        SwitchPanel(Pnl_AdamChat, Label5, Panel_1)


    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

        If Is_Ticket_Created Then
            SwitchPanel(Panel_TicketCreated, Label16, Panel_2)
        Else
            SwitchPanel(Pnl_ExpertTicket, Label16, Panel_2)
        End If



    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click


        If Is_Ticket_Created Then
            Panel_Yes_History.Show()
            Panel_Yes_History.Location = New Point(3, 63)
            Panel_No_History.Hide()

        Else
            Panel_No_History.Show()
            Panel_No_History.Location = New Point(3, 63)
            Panel_Yes_History.Hide()

        End If


        SwitchPanel(Pnl_History, Label4, Panel_3)



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.MouseClick

        If TextBox1.Text = "Message" Then

            TextBox1.Text = ""

        End If


    End Sub

    Private Sub TbTitleES_Click(sender As Object, e As EventArgs) Handles TbTitleES.MouseClick

        If TbTitleES.Text = "" Then
            TbTitleES.Text = "Title"
        Else
            TbTitleES.Text = ""
        End If



    End Sub

    Private Sub TbDescriptionES_Click(sender As Object, e As EventArgs) Handles TbDescriptionES.MouseClick

        If TbDescriptionES.Text = "" Then
            TbDescriptionES.Text = "Description"
        Else
            TbDescriptionES.Text = ""
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Send_Ticket()

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click


        Dim response As Integer
        response = MessageBox.Show("Are you sure you want to close ticket?", Ticket_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = vbYes Then

            SwitchPanel(Pnl_ExpertTicket, Label16, Panel_2)
            Is_Ticket_Created = False

        End If

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        If Is_Ticket_Created Then
            SwitchPanel(Panel_TicketCreated, Label16, Panel_2)
        Else
            SwitchPanel(Pnl_ExpertTicket, Label16, Panel_2)
        End If


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Is_Ticket_Created Then
            SwitchPanel(Panel_TicketCreated, Label16, Panel_2)
        Else
            SwitchPanel(Pnl_ExpertTicket, Label16, Panel_2)
        End If

    End Sub

    Private Sub Pnl_History_Paint(sender As Object, e As PaintEventArgs) Handles Pnl_History.Paint

    End Sub

    Private Sub TextBox1_Keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

        If TextBox1.Text IsNot "" Then
            If e.KeyChar = Convert.ToChar(13) Then

                AdamChatMessages(TextBox1.Text)
                TextBox1.Clear()

            End If

        End If




    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class