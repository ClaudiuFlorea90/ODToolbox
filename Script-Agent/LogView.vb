Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Timers

Public Class LogView


    Dim fs As FileStream
    Dim sr As StreamReader
    Public CurrLine As Integer = 0
    Sub Start()
        Try
            fs = New FileStream(Me.Text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
            sr = New StreamReader(fs)
            Dim t As String = sr.ReadToEnd
            sr.Close()
            fs.Close()
            Dim d As New List(Of String)(t.Split(Chr(13)))
            Dim x As String
            Dim l As Integer
            l = d.Count
            ToolStripProgressBar1.Visible = True
            ToolStripStatusLabel1.Text = "Processing... "
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            Button2.Enabled = False
            Application.DoEvents()
            For r = 0 To l - 2
                ToolStripProgressBar1.Value = (Int((r * 100) / (l - 1)))
                t = d(r)
                x = t.Substring(0, t.LastIndexOf("] ") + 2)
                x = x & Decrypt(t.Substring(t.LastIndexOf("] ") + 2))
                RichTextBox1.AppendText(x)
                Application.DoEvents()
            Next
            CurrLine = l - 1
            CheckBox1.Enabled = True
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            Button2.Enabled = True
            ToolStripStatusLabel1.Text = "Status: Ready"
            ToolStripProgressBar1.Visible = False

        Catch ex As Exception
            If Not ex.Message = "Object reference not set to an instance of an object." Then MsgBox(ex.Message)
            Me.Close()
            Exit Sub
        End Try
    End Sub



    Private Sub LogView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RoundedCorner(Button4, 10)
        Label1.Hide()


        'Me.Text = ""
        Dim ToolTip1 As System.Windows.Forms.ToolTip = New System.Windows.Forms.ToolTip()
        ToolTip1.SetToolTip(Button1, "F3")
        Dim ToolTip2 As System.Windows.Forms.ToolTip = New System.Windows.Forms.ToolTip()
        ToolTip2.SetToolTip(Button3, "F4")
        Me.Icon = Frame.Icon
        'RichTextBox1.Autoscroll = True
        Me.Show()
        RichTextBox1.Enabled = False
        Start()
        RichTextBox1.Enabled = True
        Try
            System.IO.File.ReadAllText(Me.Text)
            CheckBox3.Checked = False
            CheckBox1.Checked = False
            RichTextBox1.SelectionStart = 0
            RichTextBox1.ScrollToCaret()
        Catch
            CheckBox1.Checked = True
            CheckBox3.Checked = True
        End Try
        While True
            Application.DoEvents()
            Thread.Sleep(25)
        End While
    End Sub


    'Private Sub Form2_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    '    If Me.Width < 600 Then Me.Width = 600
    '    If Me.Height < 250 Then Me.Height = 250
    'End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            ToolStripStatusLabel1.Text = "Status: Monitoring..."
            Timer1.Enabled = True
            CheckBox2.Checked = False
        Else
            ToolStripStatusLabel1.Text = "Status: Ready"
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

        Try
            If CheckBox1.Checked Then
                If CheckBox2.Checked Then
                    CheckBox2.Checked = False
                    FindStatusLabel.Text = "   Word Wrap not supported during monitoring."
                    Timer2.Enabled = False
                    Timer2.Enabled = True
                    Exit Sub
                End If
            End If
            RichTextBox1.WordWrap = CheckBox2.Checked
            If CheckBox3.Checked Then
                RichTextBox1.SelectionStart = RichTextBox1.Text.Length
                RichTextBox1.ScrollToCaret()

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Try
            fs = New FileStream(Me.Text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
            sr = New StreamReader(fs)
            Dim t As String = sr.ReadToEnd
            Dim d As New List(Of String)(t.Split(Chr(13)))
            sr.Close()
            fs.Close()
            Dim x As String
            Dim l As Integer = d.Count
            For r = CurrLine To l - 2
                t = d(r)
                x = t.Substring(0, t.LastIndexOf("] ") + 2)
                x = x & Decrypt(t.Substring(t.LastIndexOf("] ") + 2))
                If x.Trim <> "" Then
                    RichTextBox1.AppendText(x)
                    ToolStripStatusLabel1.Text = "Status: Monitoring... Last entry at " & Format(Now, "HH:mm:ss")

                End If
            Next
            CurrLine = l - 1
            Timer1.Enabled = CheckBox1.Checked
        Catch ex As Exception
            Timer1.Enabled = False
            MsgBox(ex.Message)
            CheckBox1.Checked = False
        End Try
    End Sub


    Private Sub RichTextBox1_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles RichTextBox1.LinkClicked
        Try
            Process.Start(e.LinkText)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim sfd As New SaveFileDialog() ' this creates an instance of the SaveFileDialog called "sfd"
            sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
            sfd.FilterIndex = 1
            sfd.FileName = Me.Text & "-decrypted.txt"
            sfd.RestoreDirectory = True
            If sfd.ShowDialog() = DialogResult.OK Then
                Dim FileName As String = sfd.FileName ' retrieve the full path to the file selected by the user
                Dim sw As New System.IO.StreamWriter(FileName, False) ' create a StreamWriter with the FileName selected by the User
                sw.Write(RichTextBox1.Text)
                sw.Close() ' close the file
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        RichTextBox1.Clear()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        'RichTextBox1.Autoscroll = CheckBox3.Checked
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FindStatusLabel.Text = ""
        LastDown = True
        On Error Resume Next
        If TextBox1.Text <> "" Then
            If CheckBox1.Checked Then
                CheckBox3.Checked = False
                CheckBox2.Checked = False
            End If
            Dim S As Integer = RichTextBox1.Find(TextBox1.Text, RichTextBox1.SelectionStart + 1, RichTextBoxFinds.None)
            If S > 0 Then
                RichTextBox1.SelectionStart = RichTextBox1.Find(RichTextBox1.Lines(RichTextBox1.GetLineFromCharIndex(RichTextBox1.SelectionStart)))
                RichTextBox1.ScrollToCaret()
                RichTextBox1.Select(S, TextBox1.Text.Length)
                FindStatusLabel.Text = "   Text '" & TextBox1.Text & "' found at line " & 1 + RichTextBox1.GetLineFromCharIndex(RichTextBox1.SelectionStart)
                Timer2.Enabled = False
                Timer2.Enabled = True
            Else
                FindStatusLabel.Text = "   Text '" & TextBox1.Text & "' not found downwards."
                Timer2.Enabled = False
                Timer2.Enabled = True
            End If

            Label1.Show()
            Label1.Text = FindStatusLabel.Text
            RichTextBox1.Focus()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        On Error Resume Next
        FindStatusLabel.Text = ""
        LastDown = False
        If TextBox1.Text <> "" Then
            If CheckBox1.Checked Then
                CheckBox3.Checked = False
                CheckBox2.Checked = False
            End If
            Dim S As Integer = RichTextBox1.Find(TextBox1.Text, 0, RichTextBox1.SelectionStart - 1, RichTextBoxFinds.Reverse)
            If S > 0 Then
                RichTextBox1.SelectionStart = RichTextBox1.Find(RichTextBox1.Lines(RichTextBox1.GetLineFromCharIndex(RichTextBox1.SelectionStart)))
                RichTextBox1.ScrollToCaret()
                RichTextBox1.Select(S, TextBox1.Text.Length)
                FindStatusLabel.Text = "   Text '" & TextBox1.Text & "' found at line " & 1 + RichTextBox1.GetLineFromCharIndex(RichTextBox1.SelectionStart)
                Timer2.Enabled = False
                Timer2.Enabled = True

            Else
                FindStatusLabel.Text = "   Text '" & TextBox1.Text & "' not found upwards."
                Timer2.Enabled = False
                Timer2.Enabled = True
            End If

            Label1.Show()
            Label1.Text = FindStatusLabel.Text
            RichTextBox1.Focus()
        End If
    End Sub
    Dim LastDown As Boolean = True
    Private Sub RichTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles RichTextBox1.KeyDown
        If e.KeyCode = Keys.F3 Then Button1_Click(Nothing, Nothing)
        If e.KeyCode = Keys.F4 Then Button3_Click(Nothing, Nothing)
        If e.KeyData = (Keys.F + Keys.Control) Then
            TextBox1.Focus()
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If LastDown Then
                Button1_Click(Nothing, Nothing)
            Else
                Button3_Click(Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        Timer2.Enabled = False
        TextBox1.SelectAll()
        FindStatusLabel.Text = ""
    End Sub

    Private Sub ReloadLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadLogToolStripMenuItem.Click
        On Error Resume Next
        Dim C1 As Boolean = CheckBox1.Checked
        Dim C2 As Boolean = CheckBox2.Checked
        Dim C3 As Boolean = CheckBox3.Checked
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = True
        RichTextBox1.Clear()
        'Form1.Focus()
        RichTextBox1.Enabled = False
        Start()
        RichTextBox1.Enabled = True
        CheckBox2.Checked = C2
        CheckBox3.Checked = C3
        CheckBox1.Checked = C1
        If C1 Then
            RichTextBox1.SelectionStart = RichTextBox1.Text.Length
        Else
            RichTextBox1.SelectionStart = 0
        End If
        RichTextBox1.ScrollToCaret()
        Me.Focus()
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1_GotFocus(Nothing, Nothing)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

    End Sub

    Private Sub Form2_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        RichTextBox1.ScrollToCaret()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub TextBox1_GotFocus1(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        If sender.text = "Search" Then
            sender.clear()
        End If

    End Sub
    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus

        If sender.text = " " Or sender.text = Nothing Then
            sender.text = "Search"
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim sfd As New SaveFileDialog()
            sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
            sfd.FilterIndex = 1
            sfd.FileName = Me.Text & "-decrypted.txt"
            sfd.RestoreDirectory = True
            If sfd.ShowDialog() = DialogResult.OK Then
                Dim FileName As String = sfd.FileName
                Dim sw As New System.IO.StreamWriter(FileName, False)
                sw.Write(RichTextBox1.Text)
                sw.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class

