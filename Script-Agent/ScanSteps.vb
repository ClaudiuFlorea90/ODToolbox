Imports System.Threading


Public Class ScanSteps

    Dim VS_Time As Integer = 0

    Public virusScanType As String
    Dim isScanning As Boolean = False



    Public regKey As String = "HKEY_CURRENT_USER\SOFTWARE\TEST"

    Private Sub ScanSteps_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        VirusScan()

    End Sub



    Function VirusScan()

        isScanning = True


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
        p.StartInfo.Arguments = "Update-MpSignature"
        p.Start()


        PicBox1.Image = My.Resources.loading1
        Lbl_Pas1.Font = New Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold)


        Do Until p.HasExited = True
            VS_Time = VS_Time + 1
            Lbl_Scanduration.Text = VS_Time & " sec"
            Thread.Sleep(1000)
        Loop


        'Label bold
        PicBox1.Image = My.Resources.check_mark__3_
        Lbl_Pas1.Font = New Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular)


        virusScanType = "Quick Scan"

        'Pas.2 Rest of scan
        If virusScanType = "Quick Scan" Then
            p.StartInfo.Arguments = "Start-MpScan -ScanType QuickScan"  'ScanType Var
        Else
            p.StartInfo.Arguments = "Start-MpScan -ScanType FullScan"  'ScanType Var
        End If
        p.Start()

        PicBox2.Image = My.Resources.loading1
        Lbl_Pas2.Font = New Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold)

        Do Until p.HasExited = True
            VS_Time = VS_Time + 1
            Lbl_Scanduration.Text = VS_Time & " sec"

            If VS_Time >= 10 Then
                PicBox2.Image = My.Resources.check_mark__3_
                Lbl_Pas2.Font = New Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular)
                PicBox3.Image = My.Resources.loading1
                Lbl_Pas3.Font = New Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold)
            End If
            If VS_Time >= 15 Then
                PicBox3.Image = My.Resources.check_mark__3_
                Lbl_Pas3.Font = New Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular)
                PicBox4.Image = My.Resources.loading1
                Lbl_Pas4.Font = New Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold)
            End If
            If VS_Time >= 20 Then
                Lbl_Pas4.Font = New Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular)
                PicBox4.Image = My.Resources.check_mark__3_
                PicBox5.Image = My.Resources.loading1
                Lbl_Pas5.Font = New Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold)
            End If
            Thread.Sleep(1000)
        Loop
        PicBox5.Image = My.Resources.check_mark__3_
        Lbl_Pas5.Font = New Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular)





        'VS_Time = 0
        'VS_Items = 3242345
        'VS_Threads = 1
        'VS_PUPs = 0
        'VS_Detection_Ignored = 0
        'VS_Detection_Removed = 1





        isScanning = False
        Return Nothing
    End Function





End Class

