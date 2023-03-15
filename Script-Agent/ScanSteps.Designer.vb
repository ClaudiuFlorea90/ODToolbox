<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScanSteps
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Pnl_IsScanning = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lbl_Scanduration = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Lbl_Pas2 = New System.Windows.Forms.Label()
        Me.Lbl_Pas4 = New System.Windows.Forms.Label()
        Me.Lbl_Pas3 = New System.Windows.Forms.Label()
        Me.Lbl_Pas1 = New System.Windows.Forms.Label()
        Me.Lbl_Pas5 = New System.Windows.Forms.Label()
        Me.PicBox1 = New System.Windows.Forms.PictureBox()
        Me.PicBox5 = New System.Windows.Forms.PictureBox()
        Me.PicBox4 = New System.Windows.Forms.PictureBox()
        Me.PicBox3 = New System.Windows.Forms.PictureBox()
        Me.PicBox2 = New System.Windows.Forms.PictureBox()
        Me.Pnl_ScanCompleted = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Btn_OK = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Pnl_IsScanning.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PicBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_ScanCompleted.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pnl_IsScanning
        '
        Me.Pnl_IsScanning.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pnl_IsScanning.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Pnl_IsScanning.Controls.Add(Me.ProgressBar1)
        Me.Pnl_IsScanning.Controls.Add(Me.Label50)
        Me.Pnl_IsScanning.Controls.Add(Me.Panel1)
        Me.Pnl_IsScanning.Controls.Add(Me.PicBox1)
        Me.Pnl_IsScanning.Controls.Add(Me.PicBox5)
        Me.Pnl_IsScanning.Controls.Add(Me.PicBox4)
        Me.Pnl_IsScanning.Controls.Add(Me.PicBox3)
        Me.Pnl_IsScanning.Controls.Add(Me.PicBox2)
        Me.Pnl_IsScanning.Controls.Add(Me.Lbl_Pas2)
        Me.Pnl_IsScanning.Controls.Add(Me.Lbl_Pas4)
        Me.Pnl_IsScanning.Controls.Add(Me.Lbl_Pas3)
        Me.Pnl_IsScanning.Controls.Add(Me.Lbl_Pas1)
        Me.Pnl_IsScanning.Controls.Add(Me.Lbl_Pas5)
        Me.Pnl_IsScanning.Location = New System.Drawing.Point(0, 0)
        Me.Pnl_IsScanning.Name = "Pnl_IsScanning"
        Me.Pnl_IsScanning.Size = New System.Drawing.Size(465, 217)
        Me.Pnl_IsScanning.TabIndex = 3
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(277, 102)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(156, 5)
        Me.ProgressBar1.TabIndex = 7
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label50.Location = New System.Drawing.Point(298, 20)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(103, 61)
        Me.Label50.TabIndex = 6
        Me.Label50.Text = "0%"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Lbl_Scanduration)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Location = New System.Drawing.Point(3, 128)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(459, 86)
        Me.Panel1.TabIndex = 5
        '
        'Lbl_Scanduration
        '
        Me.Lbl_Scanduration.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_Scanduration.AutoSize = True
        Me.Lbl_Scanduration.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Scanduration.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Lbl_Scanduration.Location = New System.Drawing.Point(90, 36)
        Me.Lbl_Scanduration.Name = "Lbl_Scanduration"
        Me.Lbl_Scanduration.Size = New System.Drawing.Size(56, 26)
        Me.Lbl_Scanduration.TabIndex = 1
        Me.Lbl_Scanduration.Text = "0 sec"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(228, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 26)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "0"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(340, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(23, 26)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "0"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(75, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 14)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Scan duration"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(311, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 14)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Detections"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(196, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 14)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Items scanned"
        '
        'Lbl_Pas2
        '
        Me.Lbl_Pas2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_Pas2.AutoSize = True
        Me.Lbl_Pas2.Font = New System.Drawing.Font("Calibri", 13.0!)
        Me.Lbl_Pas2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.Lbl_Pas2.Location = New System.Drawing.Point(39, 37)
        Me.Lbl_Pas2.Name = "Lbl_Pas2"
        Me.Lbl_Pas2.Size = New System.Drawing.Size(139, 22)
        Me.Lbl_Pas2.TabIndex = 1
        Me.Lbl_Pas2.Text = "Scanning memory"
        '
        'Lbl_Pas4
        '
        Me.Lbl_Pas4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_Pas4.AutoSize = True
        Me.Lbl_Pas4.Font = New System.Drawing.Font("Calibri", 13.0!)
        Me.Lbl_Pas4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.Lbl_Pas4.Location = New System.Drawing.Point(39, 80)
        Me.Lbl_Pas4.Name = "Lbl_Pas4"
        Me.Lbl_Pas4.Size = New System.Drawing.Size(132, 22)
        Me.Lbl_Pas4.TabIndex = 1
        Me.Lbl_Pas4.Text = "Scanning registry"
        '
        'Lbl_Pas3
        '
        Me.Lbl_Pas3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_Pas3.AutoSize = True
        Me.Lbl_Pas3.Font = New System.Drawing.Font("Calibri", 13.0!)
        Me.Lbl_Pas3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.Lbl_Pas3.Location = New System.Drawing.Point(39, 60)
        Me.Lbl_Pas3.Name = "Lbl_Pas3"
        Me.Lbl_Pas3.Size = New System.Drawing.Size(174, 22)
        Me.Lbl_Pas3.TabIndex = 1
        Me.Lbl_Pas3.Text = "Scanning startup items"
        '
        'Lbl_Pas1
        '
        Me.Lbl_Pas1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_Pas1.AutoSize = True
        Me.Lbl_Pas1.Font = New System.Drawing.Font("Calibri", 13.0!)
        Me.Lbl_Pas1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.Lbl_Pas1.Location = New System.Drawing.Point(39, 14)
        Me.Lbl_Pas1.Name = "Lbl_Pas1"
        Me.Lbl_Pas1.Size = New System.Drawing.Size(163, 22)
        Me.Lbl_Pas1.TabIndex = 1
        Me.Lbl_Pas1.Text = "Checking for updates"
        '
        'Lbl_Pas5
        '
        Me.Lbl_Pas5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_Pas5.AutoSize = True
        Me.Lbl_Pas5.Font = New System.Drawing.Font("Calibri", 13.0!)
        Me.Lbl_Pas5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.Lbl_Pas5.Location = New System.Drawing.Point(39, 103)
        Me.Lbl_Pas5.Name = "Lbl_Pas5"
        Me.Lbl_Pas5.Size = New System.Drawing.Size(156, 22)
        Me.Lbl_Pas5.TabIndex = 1
        Me.Lbl_Pas5.Text = "Scanning file system"
        '
        'PicBox1
        '
        Me.PicBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PicBox1.Location = New System.Drawing.Point(13, 13)
        Me.PicBox1.Name = "PicBox1"
        Me.PicBox1.Size = New System.Drawing.Size(20, 20)
        Me.PicBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicBox1.TabIndex = 4
        Me.PicBox1.TabStop = False
        '
        'PicBox5
        '
        Me.PicBox5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PicBox5.Location = New System.Drawing.Point(13, 102)
        Me.PicBox5.Name = "PicBox5"
        Me.PicBox5.Size = New System.Drawing.Size(20, 20)
        Me.PicBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicBox5.TabIndex = 4
        Me.PicBox5.TabStop = False
        '
        'PicBox4
        '
        Me.PicBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PicBox4.Image = Global.Script_Agent.My.Resources.Resources.check_mark__3_
        Me.PicBox4.Location = New System.Drawing.Point(13, 78)
        Me.PicBox4.Name = "PicBox4"
        Me.PicBox4.Size = New System.Drawing.Size(20, 20)
        Me.PicBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicBox4.TabIndex = 4
        Me.PicBox4.TabStop = False
        '
        'PicBox3
        '
        Me.PicBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PicBox3.Image = Global.Script_Agent.My.Resources.Resources.loading1
        Me.PicBox3.Location = New System.Drawing.Point(13, 58)
        Me.PicBox3.Name = "PicBox3"
        Me.PicBox3.Size = New System.Drawing.Size(20, 20)
        Me.PicBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicBox3.TabIndex = 4
        Me.PicBox3.TabStop = False
        '
        'PicBox2
        '
        Me.PicBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PicBox2.Image = Global.Script_Agent.My.Resources.Resources.loading1
        Me.PicBox2.Location = New System.Drawing.Point(13, 37)
        Me.PicBox2.Name = "PicBox2"
        Me.PicBox2.Size = New System.Drawing.Size(20, 20)
        Me.PicBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicBox2.TabIndex = 4
        Me.PicBox2.TabStop = False
        '
        'Pnl_ScanCompleted
        '
        Me.Pnl_ScanCompleted.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pnl_ScanCompleted.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Pnl_ScanCompleted.Controls.Add(Me.PictureBox1)
        Me.Pnl_ScanCompleted.Controls.Add(Me.Panel3)
        Me.Pnl_ScanCompleted.Controls.Add(Me.Label7)
        Me.Pnl_ScanCompleted.Location = New System.Drawing.Point(312, 223)
        Me.Pnl_ScanCompleted.Name = "Pnl_ScanCompleted"
        Me.Pnl_ScanCompleted.Size = New System.Drawing.Size(465, 217)
        Me.Pnl_ScanCompleted.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Script_Agent.My.Resources.Resources.checkmark
        Me.PictureBox1.Location = New System.Drawing.Point(142, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(197, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Btn_OK)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 131)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(465, 86)
        Me.Panel3.TabIndex = 6
        '
        'Btn_OK
        '
        Me.Btn_OK.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_OK.BackColor = System.Drawing.Color.Green
        Me.Btn_OK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_OK.Location = New System.Drawing.Point(187, 24)
        Me.Btn_OK.Name = "Btn_OK"
        Me.Btn_OK.Size = New System.Drawing.Size(102, 39)
        Me.Btn_OK.TabIndex = 5
        Me.Btn_OK.Text = "OK"
        Me.Btn_OK.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label7.Location = New System.Drawing.Point(103, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(301, 28)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Awesome! No threads found"
        '
        'ScanSteps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1109, 450)
        Me.Controls.Add(Me.Pnl_ScanCompleted)
        Me.Controls.Add(Me.Pnl_IsScanning)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ScanSteps"
        Me.Text = "ScanSteps"
        Me.Pnl_IsScanning.ResumeLayout(False)
        Me.Pnl_IsScanning.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PicBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_ScanCompleted.ResumeLayout(False)
        Me.Pnl_ScanCompleted.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pnl_IsScanning As Panel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label50 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Lbl_Scanduration As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents PicBox1 As PictureBox
    Friend WithEvents PicBox5 As PictureBox
    Friend WithEvents PicBox4 As PictureBox
    Friend WithEvents PicBox3 As PictureBox
    Friend WithEvents PicBox2 As PictureBox
    Friend WithEvents Lbl_Pas2 As Label
    Friend WithEvents Lbl_Pas4 As Label
    Friend WithEvents Lbl_Pas3 As Label
    Friend WithEvents Lbl_Pas1 As Label
    Friend WithEvents Lbl_Pas5 As Label
    Friend WithEvents Pnl_ScanCompleted As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Btn_OK As Button
    Friend WithEvents Label7 As Label
End Class
