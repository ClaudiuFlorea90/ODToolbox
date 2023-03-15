<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Lbl_CPU = New System.Windows.Forms.Label()
        Me.Lbl_RAM = New System.Windows.Forms.Label()
        Me.Lbl_Disk = New System.Windows.Forms.Label()
        Me.ImageList_MainIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.Lbl_GPU_WTF = New System.Windows.Forms.Label()
        Me.Pnl_Windows = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.Btn_Windows = New System.Windows.Forms.Button()
        Me.ImageList_ExpandBtn = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Lbl_OS = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbl_os_build = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbl_os_buildasadfa = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Pnl_Computer = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Btn_Computer = New System.Windows.Forms.Button()
        Me.Lbl_PC = New System.Windows.Forms.Label()
        Me.Pnl_Network = New System.Windows.Forms.Panel()
        Me.Chart_Network = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Btn_Network = New System.Windows.Forms.Button()
        Me.Lbl_Network = New System.Windows.Forms.Label()
        Me.PictureBox18 = New System.Windows.Forms.PictureBox()
        Me.PictureBox19 = New System.Windows.Forms.PictureBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.PictureBox20 = New System.Windows.Forms.PictureBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.PictureBox22 = New System.Windows.Forms.PictureBox()
        Me.Pnl_Processes = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Btn_Processes = New System.Windows.Forms.Button()
        Me.PictureBox23 = New System.Windows.Forms.PictureBox()
        Me.Lbl_Process = New System.Windows.Forms.Label()
        Me.PictureBox26 = New System.Windows.Forms.PictureBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Pnl_User = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PictureBox34 = New System.Windows.Forms.PictureBox()
        Me.PictureBox38 = New System.Windows.Forms.PictureBox()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.PictureBox35 = New System.Windows.Forms.PictureBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.PictureBox36 = New System.Windows.Forms.PictureBox()
        Me.Btn_User = New System.Windows.Forms.Button()
        Me.Lbl_User = New System.Windows.Forms.Label()
        Me.Timer_Windows = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Computer = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Network = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Processes = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_User = New System.Windows.Forms.Timer(Me.components)
        Me.PanelLiveStats = New System.Windows.Forms.Panel()
        Me.PanelCPU = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CircularProgressBar4 = New CircularProgressBar.CircularProgressBar()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.CircularProgressBar1 = New CircularProgressBar.CircularProgressBar()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.Lbl_UpTime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.LabelCpuClockSpeed = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.Label109 = New System.Windows.Forms.Label()
        Me.Label105 = New System.Windows.Forms.Label()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.Label96 = New System.Windows.Forms.Label()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.Label112 = New System.Windows.Forms.Label()
        Me.Label106 = New System.Windows.Forms.Label()
        Me.Label110 = New System.Windows.Forms.Label()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.Label108 = New System.Windows.Forms.Label()
        Me.Label104 = New System.Windows.Forms.Label()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.Label107 = New System.Windows.Forms.Label()
        Me.PanelRam = New System.Windows.Forms.Panel()
        Me.Label116 = New System.Windows.Forms.Label()
        Me.Label132 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label131 = New System.Windows.Forms.Label()
        Me.CircularProgressBar2 = New CircularProgressBar.CircularProgressBar()
        Me.CircularProgressBarRam2 = New CircularProgressBar.CircularProgressBar()
        Me.Label117 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label133 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label130 = New System.Windows.Forms.Label()
        Me.Lbl_TotalRam = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label118 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label134 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Lbl_Available = New System.Windows.Forms.Label()
        Me.Label129 = New System.Windows.Forms.Label()
        Me.Lbl_RamInUse = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label119 = New System.Windows.Forms.Label()
        Me.Label122 = New System.Windows.Forms.Label()
        Me.Label121 = New System.Windows.Forms.Label()
        Me.Label111 = New System.Windows.Forms.Label()
        Me.Label124 = New System.Windows.Forms.Label()
        Me.Label137 = New System.Windows.Forms.Label()
        Me.Label135 = New System.Windows.Forms.Label()
        Me.Label125 = New System.Windows.Forms.Label()
        Me.Label126 = New System.Windows.Forms.Label()
        Me.Label128 = New System.Windows.Forms.Label()
        Me.Label123 = New System.Windows.Forms.Label()
        Me.Label140 = New System.Windows.Forms.Label()
        Me.Label141 = New System.Windows.Forms.Label()
        Me.Label127 = New System.Windows.Forms.Label()
        Me.Label136 = New System.Windows.Forms.Label()
        Me.Label120 = New System.Windows.Forms.Label()
        Me.PanelGpu = New System.Windows.Forms.Panel()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.CircularProgressBar7 = New CircularProgressBar.CircularProgressBar()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.LabelGpuMemoryUsed = New System.Windows.Forms.Label()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.Lbl_GpuTotalMemory = New System.Windows.Forms.Label()
        Me.LblGpuUsage = New System.Windows.Forms.Label()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.PanelDisk = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label170 = New System.Windows.Forms.Label()
        Me.Label154 = New System.Windows.Forms.Label()
        Me.Label153 = New System.Windows.Forms.Label()
        Me.Label168 = New System.Windows.Forms.Label()
        Me.Label155 = New System.Windows.Forms.Label()
        Me.Label167 = New System.Windows.Forms.Label()
        Me.Label156 = New System.Windows.Forms.Label()
        Me.Label166 = New System.Windows.Forms.Label()
        Me.Label157 = New System.Windows.Forms.Label()
        Me.Label165 = New System.Windows.Forms.Label()
        Me.Label158 = New System.Windows.Forms.Label()
        Me.Label164 = New System.Windows.Forms.Label()
        Me.Label159 = New System.Windows.Forms.Label()
        Me.Label163 = New System.Windows.Forms.Label()
        Me.Label160 = New System.Windows.Forms.Label()
        Me.Label162 = New System.Windows.Forms.Label()
        Me.Label161 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.CircularProgressBar6 = New CircularProgressBar.CircularProgressBar()
        Me.CircularProgressBar5 = New CircularProgressBar.CircularProgressBar()
        Me.Label152 = New System.Windows.Forms.Label()
        Me.Label151 = New System.Windows.Forms.Label()
        Me.Label144 = New System.Windows.Forms.Label()
        Me.Label150 = New System.Windows.Forms.Label()
        Me.Label143 = New System.Windows.Forms.Label()
        Me.Label149 = New System.Windows.Forms.Label()
        Me.Label138 = New System.Windows.Forms.Label()
        Me.Label148 = New System.Windows.Forms.Label()
        Me.Label142 = New System.Windows.Forms.Label()
        Me.Label147 = New System.Windows.Forms.Label()
        Me.Label115 = New System.Windows.Forms.Label()
        Me.Label146 = New System.Windows.Forms.Label()
        Me.Label139 = New System.Windows.Forms.Label()
        Me.Label145 = New System.Windows.Forms.Label()
        Me.Label114 = New System.Windows.Forms.Label()
        Me.Label113 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label169 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.PanelNetwork = New System.Windows.Forms.Panel()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label191 = New System.Windows.Forms.Label()
        Me.Label190 = New System.Windows.Forms.Label()
        Me.Label179 = New System.Windows.Forms.Label()
        Me.Label189 = New System.Windows.Forms.Label()
        Me.Label173 = New System.Windows.Forms.Label()
        Me.Label178 = New System.Windows.Forms.Label()
        Me.Label188 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label172 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label187 = New System.Windows.Forms.Label()
        Me.CircularProgressBar3 = New CircularProgressBar.CircularProgressBar()
        Me.Label177 = New System.Windows.Forms.Label()
        Me.Label186 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label185 = New System.Windows.Forms.Label()
        Me.Label176 = New System.Windows.Forms.Label()
        Me.Label184 = New System.Windows.Forms.Label()
        Me.Label171 = New System.Windows.Forms.Label()
        Me.Label183 = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.Label175 = New System.Windows.Forms.Label()
        Me.Label182 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label181 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label174 = New System.Windows.Forms.Label()
        Me.Label180 = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.Timer_ExpandLiveStatus = New System.Windows.Forms.Timer(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Pnl_Windows.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_Computer.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_Network.SuspendLayout()
        CType(Me.Chart_Network, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox22, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_Processes.SuspendLayout()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox26, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_User.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox36, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLiveStats.SuspendLayout()
        Me.PanelCPU.SuspendLayout()
        Me.PanelRam.SuspendLayout()
        Me.PanelGpu.SuspendLayout()
        Me.PanelDisk.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelNetwork.SuspendLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_CPU
        '
        Me.Lbl_CPU.AutoSize = True
        Me.Lbl_CPU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_CPU.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_CPU.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Lbl_CPU.Location = New System.Drawing.Point(20, 13)
        Me.Lbl_CPU.Name = "Lbl_CPU"
        Me.Lbl_CPU.Size = New System.Drawing.Size(60, 21)
        Me.Lbl_CPU.TabIndex = 2
        Me.Lbl_CPU.Text = "Label2"
        '
        'Lbl_RAM
        '
        Me.Lbl_RAM.AutoSize = True
        Me.Lbl_RAM.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RAM.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Lbl_RAM.Location = New System.Drawing.Point(42, 54)
        Me.Lbl_RAM.Name = "Lbl_RAM"
        Me.Lbl_RAM.Size = New System.Drawing.Size(44, 13)
        Me.Lbl_RAM.TabIndex = 2
        Me.Lbl_RAM.Text = "Label2"
        '
        'Lbl_Disk
        '
        Me.Lbl_Disk.AutoSize = True
        Me.Lbl_Disk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_Disk.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Disk.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Lbl_Disk.Location = New System.Drawing.Point(20, 13)
        Me.Lbl_Disk.Name = "Lbl_Disk"
        Me.Lbl_Disk.Size = New System.Drawing.Size(60, 21)
        Me.Lbl_Disk.TabIndex = 2
        Me.Lbl_Disk.Text = "Label2"
        '
        'ImageList_MainIcons
        '
        Me.ImageList_MainIcons.ImageStream = CType(resources.GetObject("ImageList_MainIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_MainIcons.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_MainIcons.Images.SetKeyName(0, "process.png")
        Me.ImageList_MainIcons.Images.SetKeyName(1, "global-network.png")
        Me.ImageList_MainIcons.Images.SetKeyName(2, "pc.png")
        Me.ImageList_MainIcons.Images.SetKeyName(3, "windows.png")
        Me.ImageList_MainIcons.Images.SetKeyName(4, "user.png")
        '
        'Lbl_GPU_WTF
        '
        Me.Lbl_GPU_WTF.AutoSize = True
        Me.Lbl_GPU_WTF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_GPU_WTF.Font = New System.Drawing.Font("Microsoft PhagsPa", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_GPU_WTF.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Lbl_GPU_WTF.Location = New System.Drawing.Point(20, 13)
        Me.Lbl_GPU_WTF.Name = "Lbl_GPU_WTF"
        Me.Lbl_GPU_WTF.Size = New System.Drawing.Size(55, 20)
        Me.Lbl_GPU_WTF.TabIndex = 2
        Me.Lbl_GPU_WTF.Text = "Label2"
        '
        'Pnl_Windows
        '
        Me.Pnl_Windows.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Pnl_Windows.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnl_Windows.Controls.Add(Me.Panel2)
        Me.Pnl_Windows.Controls.Add(Me.PictureBox10)
        Me.Pnl_Windows.Controls.Add(Me.Btn_Windows)
        Me.Pnl_Windows.Controls.Add(Me.PictureBox9)
        Me.Pnl_Windows.Controls.Add(Me.PictureBox7)
        Me.Pnl_Windows.Controls.Add(Me.Label15)
        Me.Pnl_Windows.Controls.Add(Me.Lbl_OS)
        Me.Pnl_Windows.Controls.Add(Me.Label20)
        Me.Pnl_Windows.Controls.Add(Me.Label8)
        Me.Pnl_Windows.Controls.Add(Me.PictureBox12)
        Me.Pnl_Windows.Controls.Add(Me.PictureBox8)
        Me.Pnl_Windows.Controls.Add(Me.Label4)
        Me.Pnl_Windows.Controls.Add(Me.Label9)
        Me.Pnl_Windows.Controls.Add(Me.Label14)
        Me.Pnl_Windows.Controls.Add(Me.lbl_os_build)
        Me.Pnl_Windows.Controls.Add(Me.Label13)
        Me.Pnl_Windows.Controls.Add(Me.lbl_os_buildasadfa)
        Me.Pnl_Windows.Controls.Add(Me.Label12)
        Me.Pnl_Windows.Location = New System.Drawing.Point(3, 266)
        Me.Pnl_Windows.MaximumSize = New System.Drawing.Size(680, 397)
        Me.Pnl_Windows.MinimumSize = New System.Drawing.Size(322, 39)
        Me.Pnl_Windows.Name = "Pnl_Windows"
        Me.Pnl_Windows.Size = New System.Drawing.Size(322, 39)
        Me.Pnl_Windows.TabIndex = 20
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(191, 67)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1, 203)
        Me.Panel2.TabIndex = 21
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = Global.Script_Agent.My.Resources.Resources.processor
        Me.PictureBox10.Location = New System.Drawing.Point(14, 58)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(33, 33)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox10.TabIndex = 19
        Me.PictureBox10.TabStop = False
        '
        'Btn_Windows
        '
        Me.Btn_Windows.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Btn_Windows.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Btn_Windows.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Btn_Windows.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Btn_Windows.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Windows.ImageIndex = 1
        Me.Btn_Windows.ImageList = Me.ImageList_ExpandBtn
        Me.Btn_Windows.Location = New System.Drawing.Point(3, 7)
        Me.Btn_Windows.Name = "Btn_Windows"
        Me.Btn_Windows.Size = New System.Drawing.Size(30, 23)
        Me.Btn_Windows.TabIndex = 20
        Me.Btn_Windows.UseVisualStyleBackColor = True
        '
        'ImageList_ExpandBtn
        '
        Me.ImageList_ExpandBtn.ImageStream = CType(resources.GetObject("ImageList_ExpandBtn.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_ExpandBtn.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_ExpandBtn.Images.SetKeyName(0, "upward-arrow.png")
        Me.ImageList_ExpandBtn.Images.SetKeyName(1, "arrow-right.png")
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = Global.Script_Agent.My.Resources.Resources.ram_memory
        Me.PictureBox9.Location = New System.Drawing.Point(14, 97)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(33, 33)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox9.TabIndex = 19
        Me.PictureBox9.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.Script_Agent.My.Resources.Resources.hdd
        Me.PictureBox7.Location = New System.Drawing.Point(14, 144)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(33, 33)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 19
        Me.PictureBox7.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.Control
        Me.Label15.Location = New System.Drawing.Point(53, 110)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 16)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Version:"
        '
        'Lbl_OS
        '
        Me.Lbl_OS.AutoSize = True
        Me.Lbl_OS.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_OS.ForeColor = System.Drawing.SystemColors.Control
        Me.Lbl_OS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lbl_OS.ImageIndex = 3
        Me.Lbl_OS.ImageList = Me.ImageList_MainIcons
        Me.Lbl_OS.Location = New System.Drawing.Point(39, 9)
        Me.Lbl_OS.Name = "Lbl_OS"
        Me.Lbl_OS.Size = New System.Drawing.Size(216, 21)
        Me.Lbl_OS.TabIndex = 2
        Me.Lbl_OS.Text = "        Microsoft Windows 11"
        Me.Lbl_OS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.Control
        Me.Label20.Location = New System.Drawing.Point(53, 253)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(76, 16)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Activated:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(53, 205)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 16)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Up to date?"
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = Global.Script_Agent.My.Resources.Resources.graphic_card
        Me.PictureBox12.Location = New System.Drawing.Point(14, 240)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(33, 33)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox12.TabIndex = 19
        Me.PictureBox12.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.Script_Agent.My.Resources.Resources.graphic_card
        Me.PictureBox8.Location = New System.Drawing.Point(14, 192)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(33, 33)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 19
        Me.PictureBox8.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(209, 254)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Label2"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(209, 110)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 19)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Label2"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.Control
        Me.Label14.Location = New System.Drawing.Point(209, 206)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 19)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Label2"
        '
        'lbl_os_build
        '
        Me.lbl_os_build.AutoSize = True
        Me.lbl_os_build.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_os_build.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_os_build.Location = New System.Drawing.Point(209, 72)
        Me.lbl_os_build.Name = "lbl_os_build"
        Me.lbl_os_build.Size = New System.Drawing.Size(57, 19)
        Me.lbl_os_build.TabIndex = 2
        Me.lbl_os_build.Text = "Label2"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.Control
        Me.Label13.Location = New System.Drawing.Point(209, 158)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 19)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Label2"
        '
        'lbl_os_buildasadfa
        '
        Me.lbl_os_buildasadfa.AutoSize = True
        Me.lbl_os_buildasadfa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_os_buildasadfa.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_os_buildasadfa.Location = New System.Drawing.Point(51, 70)
        Me.lbl_os_buildasadfa.Name = "lbl_os_buildasadfa"
        Me.lbl_os_buildasadfa.Size = New System.Drawing.Size(125, 16)
        Me.lbl_os_buildasadfa.TabIndex = 2
        Me.lbl_os_buildasadfa.Text = "Os build number"""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Control
        Me.Label12.Location = New System.Drawing.Point(53, 157)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 16)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Install date:"
        '
        'Pnl_Computer
        '
        Me.Pnl_Computer.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Pnl_Computer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnl_Computer.Controls.Add(Me.Panel5)
        Me.Pnl_Computer.Controls.Add(Me.Btn_Computer)
        Me.Pnl_Computer.Controls.Add(Me.Lbl_PC)
        Me.Pnl_Computer.Location = New System.Drawing.Point(3, 309)
        Me.Pnl_Computer.MaximumSize = New System.Drawing.Size(680, 351)
        Me.Pnl_Computer.MinimumSize = New System.Drawing.Size(233, 39)
        Me.Pnl_Computer.Name = "Pnl_Computer"
        Me.Pnl_Computer.Size = New System.Drawing.Size(233, 39)
        Me.Pnl_Computer.TabIndex = 20
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel5.Controls.Add(Me.PictureBox3)
        Me.Panel5.Controls.Add(Me.PictureBox5)
        Me.Panel5.Controls.Add(Me.Lbl_RAM)
        Me.Panel5.Controls.Add(Me.PictureBox4)
        Me.Panel5.Location = New System.Drawing.Point(10, 41)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(658, 297)
        Me.Panel5.TabIndex = 21
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Script_Agent.My.Resources.Resources.processor
        Me.PictureBox3.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(33, 33)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 19
        Me.PictureBox3.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Script_Agent.My.Resources.Resources.hdd
        Me.PictureBox5.Location = New System.Drawing.Point(3, 81)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(33, 33)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 19
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Script_Agent.My.Resources.Resources.ram_memory
        Me.PictureBox4.Location = New System.Drawing.Point(3, 42)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(33, 33)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 19
        Me.PictureBox4.TabStop = False
        '
        'Btn_Computer
        '
        Me.Btn_Computer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Btn_Computer.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Btn_Computer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Btn_Computer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Btn_Computer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Computer.ImageIndex = 1
        Me.Btn_Computer.ImageList = Me.ImageList_ExpandBtn
        Me.Btn_Computer.Location = New System.Drawing.Point(3, 7)
        Me.Btn_Computer.Name = "Btn_Computer"
        Me.Btn_Computer.Size = New System.Drawing.Size(30, 23)
        Me.Btn_Computer.TabIndex = 20
        Me.Btn_Computer.UseVisualStyleBackColor = True
        '
        'Lbl_PC
        '
        Me.Lbl_PC.AutoSize = True
        Me.Lbl_PC.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_PC.ForeColor = System.Drawing.SystemColors.Control
        Me.Lbl_PC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lbl_PC.ImageIndex = 2
        Me.Lbl_PC.ImageList = Me.ImageList_MainIcons
        Me.Lbl_PC.Location = New System.Drawing.Point(39, 9)
        Me.Lbl_PC.Name = "Lbl_PC"
        Me.Lbl_PC.Size = New System.Drawing.Size(119, 21)
        Me.Lbl_PC.TabIndex = 2
        Me.Lbl_PC.Text = "        Computer"
        Me.Lbl_PC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pnl_Network
        '
        Me.Pnl_Network.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Pnl_Network.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnl_Network.Controls.Add(Me.Chart_Network)
        Me.Pnl_Network.Controls.Add(Me.Panel3)
        Me.Pnl_Network.Controls.Add(Me.Btn_Network)
        Me.Pnl_Network.Controls.Add(Me.Lbl_Network)
        Me.Pnl_Network.Controls.Add(Me.PictureBox18)
        Me.Pnl_Network.Controls.Add(Me.PictureBox19)
        Me.Pnl_Network.Controls.Add(Me.Label24)
        Me.Pnl_Network.Controls.Add(Me.PictureBox20)
        Me.Pnl_Network.Controls.Add(Me.Label26)
        Me.Pnl_Network.Controls.Add(Me.Label28)
        Me.Pnl_Network.Controls.Add(Me.Label30)
        Me.Pnl_Network.Controls.Add(Me.Label32)
        Me.Pnl_Network.Controls.Add(Me.Label34)
        Me.Pnl_Network.Controls.Add(Me.Label35)
        Me.Pnl_Network.Controls.Add(Me.Label36)
        Me.Pnl_Network.Controls.Add(Me.PictureBox22)
        Me.Pnl_Network.Location = New System.Drawing.Point(331, 266)
        Me.Pnl_Network.MaximumSize = New System.Drawing.Size(680, 397)
        Me.Pnl_Network.MinimumSize = New System.Drawing.Size(180, 39)
        Me.Pnl_Network.Name = "Pnl_Network"
        Me.Pnl_Network.Size = New System.Drawing.Size(180, 39)
        Me.Pnl_Network.TabIndex = 20
        '
        'Chart_Network
        '
        Me.Chart_Network.BackColor = System.Drawing.Color.Transparent
        Me.Chart_Network.BorderlineColor = System.Drawing.Color.Crimson
        Me.Chart_Network.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.Chart_Network.BorderlineWidth = 2
        ChartArea1.Name = "ChartArea1"
        Me.Chart_Network.ChartAreas.Add(ChartArea1)
        Me.Chart_Network.Location = New System.Drawing.Point(304, 112)
        Me.Chart_Network.Margin = New System.Windows.Forms.Padding(2)
        Me.Chart_Network.Name = "Chart_Network"
        Me.Chart_Network.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.Name = "Series1"
        Me.Chart_Network.Series.Add(Series1)
        Me.Chart_Network.Size = New System.Drawing.Size(366, 192)
        Me.Chart_Network.TabIndex = 24
        Me.Chart_Network.Text = "Chart1"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(285, 123)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1, 161)
        Me.Panel3.TabIndex = 23
        '
        'Btn_Network
        '
        Me.Btn_Network.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Btn_Network.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Btn_Network.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Btn_Network.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Btn_Network.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Network.ImageIndex = 1
        Me.Btn_Network.ImageList = Me.ImageList_ExpandBtn
        Me.Btn_Network.Location = New System.Drawing.Point(3, 7)
        Me.Btn_Network.Name = "Btn_Network"
        Me.Btn_Network.Size = New System.Drawing.Size(30, 23)
        Me.Btn_Network.TabIndex = 20
        Me.Btn_Network.UseVisualStyleBackColor = True
        '
        'Lbl_Network
        '
        Me.Lbl_Network.AutoSize = True
        Me.Lbl_Network.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Network.ForeColor = System.Drawing.SystemColors.Control
        Me.Lbl_Network.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lbl_Network.ImageIndex = 1
        Me.Lbl_Network.ImageList = Me.ImageList_MainIcons
        Me.Lbl_Network.Location = New System.Drawing.Point(39, 9)
        Me.Lbl_Network.Name = "Lbl_Network"
        Me.Lbl_Network.Size = New System.Drawing.Size(108, 21)
        Me.Lbl_Network.TabIndex = 2
        Me.Lbl_Network.Text = "        Network"
        Me.Lbl_Network.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox18
        '
        Me.PictureBox18.Image = Global.Script_Agent.My.Resources.Resources.processor
        Me.PictureBox18.Location = New System.Drawing.Point(19, 115)
        Me.PictureBox18.Name = "PictureBox18"
        Me.PictureBox18.Size = New System.Drawing.Size(33, 33)
        Me.PictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox18.TabIndex = 19
        Me.PictureBox18.TabStop = False
        '
        'PictureBox19
        '
        Me.PictureBox19.Image = Global.Script_Agent.My.Resources.Resources.ram_memory
        Me.PictureBox19.Location = New System.Drawing.Point(19, 164)
        Me.PictureBox19.Name = "PictureBox19"
        Me.PictureBox19.Size = New System.Drawing.Size(33, 33)
        Me.PictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox19.TabIndex = 19
        Me.PictureBox19.TabStop = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.Control
        Me.Label24.Location = New System.Drawing.Point(58, 177)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(43, 16)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "Ram:"
        '
        'PictureBox20
        '
        Me.PictureBox20.Image = Global.Script_Agent.My.Resources.Resources.graphic_card
        Me.PictureBox20.Location = New System.Drawing.Point(19, 259)
        Me.PictureBox20.Name = "PictureBox20"
        Me.PictureBox20.Size = New System.Drawing.Size(33, 33)
        Me.PictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox20.TabIndex = 19
        Me.PictureBox20.TabStop = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.Control
        Me.Label26.Location = New System.Drawing.Point(206, 269)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(57, 19)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "Label2"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.Control
        Me.Label28.Location = New System.Drawing.Point(206, 221)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(57, 19)
        Me.Label28.TabIndex = 2
        Me.Label28.Text = "Label2"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.Control
        Me.Label30.Location = New System.Drawing.Point(58, 224)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(81, 16)
        Me.Label30.TabIndex = 2
        Me.Label30.Text = "Bios Mode"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.SystemColors.Control
        Me.Label32.Location = New System.Drawing.Point(56, 127)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(122, 16)
        Me.Label32.TabIndex = 2
        Me.Label32.Text = "Network Adapter"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.SystemColors.Control
        Me.Label34.Location = New System.Drawing.Point(206, 124)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(57, 19)
        Me.Label34.TabIndex = 2
        Me.Label34.Text = "Label2"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.SystemColors.Control
        Me.Label35.Location = New System.Drawing.Point(206, 173)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(57, 19)
        Me.Label35.TabIndex = 2
        Me.Label35.Text = "Label2"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.SystemColors.Control
        Me.Label36.Location = New System.Drawing.Point(58, 272)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(88, 16)
        Me.Label36.TabIndex = 2
        Me.Label36.Text = "System Sku"
        '
        'PictureBox22
        '
        Me.PictureBox22.Image = Global.Script_Agent.My.Resources.Resources.hdd
        Me.PictureBox22.Location = New System.Drawing.Point(19, 211)
        Me.PictureBox22.Name = "PictureBox22"
        Me.PictureBox22.Size = New System.Drawing.Size(33, 33)
        Me.PictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox22.TabIndex = 19
        Me.PictureBox22.TabStop = False
        '
        'Pnl_Processes
        '
        Me.Pnl_Processes.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Pnl_Processes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnl_Processes.Controls.Add(Me.Panel4)
        Me.Pnl_Processes.Controls.Add(Me.ListView1)
        Me.Pnl_Processes.Controls.Add(Me.Btn_Processes)
        Me.Pnl_Processes.Controls.Add(Me.PictureBox23)
        Me.Pnl_Processes.Controls.Add(Me.Lbl_Process)
        Me.Pnl_Processes.Controls.Add(Me.PictureBox26)
        Me.Pnl_Processes.Controls.Add(Me.Label44)
        Me.Pnl_Processes.Controls.Add(Me.Label46)
        Me.Pnl_Processes.Controls.Add(Me.Label47)
        Me.Pnl_Processes.Controls.Add(Me.Label49)
        Me.Pnl_Processes.Location = New System.Drawing.Point(517, 266)
        Me.Pnl_Processes.MaximumSize = New System.Drawing.Size(680, 397)
        Me.Pnl_Processes.MinimumSize = New System.Drawing.Size(166, 39)
        Me.Pnl_Processes.Name = "Pnl_Processes"
        Me.Pnl_Processes.Size = New System.Drawing.Size(166, 39)
        Me.Pnl_Processes.TabIndex = 20
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Location = New System.Drawing.Point(295, 52)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1, 50)
        Me.Panel4.TabIndex = 22
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(16, 108)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(647, 270)
        Me.ListView1.TabIndex = 21
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Btn_Processes
        '
        Me.Btn_Processes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Btn_Processes.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Btn_Processes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Btn_Processes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Btn_Processes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Processes.ImageIndex = 1
        Me.Btn_Processes.ImageList = Me.ImageList_ExpandBtn
        Me.Btn_Processes.Location = New System.Drawing.Point(3, 7)
        Me.Btn_Processes.Name = "Btn_Processes"
        Me.Btn_Processes.Size = New System.Drawing.Size(30, 23)
        Me.Btn_Processes.TabIndex = 20
        Me.Btn_Processes.UseVisualStyleBackColor = True
        '
        'PictureBox23
        '
        Me.PictureBox23.Image = Global.Script_Agent.My.Resources.Resources.processor
        Me.PictureBox23.Location = New System.Drawing.Point(316, 60)
        Me.PictureBox23.Name = "PictureBox23"
        Me.PictureBox23.Size = New System.Drawing.Size(33, 33)
        Me.PictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox23.TabIndex = 19
        Me.PictureBox23.TabStop = False
        '
        'Lbl_Process
        '
        Me.Lbl_Process.AutoSize = True
        Me.Lbl_Process.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Process.ForeColor = System.Drawing.SystemColors.Control
        Me.Lbl_Process.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lbl_Process.ImageIndex = 0
        Me.Lbl_Process.ImageList = Me.ImageList_MainIcons
        Me.Lbl_Process.Location = New System.Drawing.Point(39, 9)
        Me.Lbl_Process.Name = "Lbl_Process"
        Me.Lbl_Process.Size = New System.Drawing.Size(118, 21)
        Me.Lbl_Process.TabIndex = 2
        Me.Lbl_Process.Text = "        Processes"
        Me.Lbl_Process.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox26
        '
        Me.PictureBox26.Image = Global.Script_Agent.My.Resources.Resources.processor
        Me.PictureBox26.Location = New System.Drawing.Point(16, 55)
        Me.PictureBox26.Name = "PictureBox26"
        Me.PictureBox26.Size = New System.Drawing.Size(33, 33)
        Me.PictureBox26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox26.TabIndex = 19
        Me.PictureBox26.TabStop = False
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.SystemColors.Control
        Me.Label44.Location = New System.Drawing.Point(353, 72)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(38, 16)
        Me.Label44.TabIndex = 2
        Me.Label44.Text = "Cpu:"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.SystemColors.Control
        Me.Label46.Location = New System.Drawing.Point(503, 69)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(57, 19)
        Me.Label46.TabIndex = 2
        Me.Label46.Text = "Label2"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.SystemColors.Control
        Me.Label47.Location = New System.Drawing.Point(53, 67)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(38, 16)
        Me.Label47.TabIndex = 2
        Me.Label47.Text = "Cpu:"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.SystemColors.Control
        Me.Label49.Location = New System.Drawing.Point(201, 70)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(57, 19)
        Me.Label49.TabIndex = 2
        Me.Label49.Text = "Label2"
        '
        'Pnl_User
        '
        Me.Pnl_User.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Pnl_User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnl_User.Controls.Add(Me.PictureBox6)
        Me.Pnl_User.Controls.Add(Me.Panel6)
        Me.Pnl_User.Controls.Add(Me.Btn_User)
        Me.Pnl_User.Controls.Add(Me.Lbl_User)
        Me.Pnl_User.Location = New System.Drawing.Point(242, 309)
        Me.Pnl_User.MaximumSize = New System.Drawing.Size(680, 397)
        Me.Pnl_User.MinimumSize = New System.Drawing.Size(309, 39)
        Me.Pnl_User.Name = "Pnl_User"
        Me.Pnl_User.Size = New System.Drawing.Size(309, 39)
        Me.Pnl_User.TabIndex = 20
        '
        'PictureBox6
        '
        Me.PictureBox6.Location = New System.Drawing.Point(33, 5)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(27, 29)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 22
        Me.PictureBox6.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.PictureBox34)
        Me.Panel6.Controls.Add(Me.PictureBox38)
        Me.Panel6.Controls.Add(Me.Label66)
        Me.Panel6.Controls.Add(Me.Label65)
        Me.Panel6.Controls.Add(Me.Label64)
        Me.Panel6.Controls.Add(Me.Label62)
        Me.Panel6.Controls.Add(Me.Label60)
        Me.Panel6.Controls.Add(Me.PictureBox35)
        Me.Panel6.Controls.Add(Me.Label58)
        Me.Panel6.Controls.Add(Me.Label54)
        Me.Panel6.Controls.Add(Me.Label56)
        Me.Panel6.Controls.Add(Me.PictureBox36)
        Me.Panel6.Location = New System.Drawing.Point(9, 43)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(656, 292)
        Me.Panel6.TabIndex = 21
        '
        'PictureBox34
        '
        Me.PictureBox34.Image = Global.Script_Agent.My.Resources.Resources.processor
        Me.PictureBox34.Location = New System.Drawing.Point(24, 45)
        Me.PictureBox34.Name = "PictureBox34"
        Me.PictureBox34.Size = New System.Drawing.Size(33, 33)
        Me.PictureBox34.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox34.TabIndex = 19
        Me.PictureBox34.TabStop = False
        '
        'PictureBox38
        '
        Me.PictureBox38.Image = Global.Script_Agent.My.Resources.Resources.hdd
        Me.PictureBox38.Location = New System.Drawing.Point(24, 123)
        Me.PictureBox38.Name = "PictureBox38"
        Me.PictureBox38.Size = New System.Drawing.Size(33, 33)
        Me.PictureBox38.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox38.TabIndex = 19
        Me.PictureBox38.TabStop = False
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Label66.ForeColor = System.Drawing.SystemColors.Control
        Me.Label66.Location = New System.Drawing.Point(63, 176)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(76, 13)
        Me.Label66.TabIndex = 2
        Me.Label66.Text = "System Sku"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Label65.ForeColor = System.Drawing.SystemColors.Control
        Me.Label65.Location = New System.Drawing.Point(190, 97)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(44, 13)
        Me.Label65.TabIndex = 2
        Me.Label65.Text = "Label2"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Label64.ForeColor = System.Drawing.SystemColors.Control
        Me.Label64.Location = New System.Drawing.Point(190, 57)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(26, 13)
        Me.Label64.TabIndex = 2
        Me.Label64.Text = "Yes"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Label62.ForeColor = System.Drawing.SystemColors.Control
        Me.Label62.Location = New System.Drawing.Point(61, 57)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(124, 13)
        Me.Label62.TabIndex = 2
        Me.Label62.Text = "Password protected:"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Label60.ForeColor = System.Drawing.SystemColors.Control
        Me.Label60.Location = New System.Drawing.Point(63, 136)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(65, 13)
        Me.Label60.TabIndex = 2
        Me.Label60.Text = "Bios Mode"
        '
        'PictureBox35
        '
        Me.PictureBox35.Image = Global.Script_Agent.My.Resources.Resources.ram_memory
        Me.PictureBox35.Location = New System.Drawing.Point(24, 84)
        Me.PictureBox35.Name = "PictureBox35"
        Me.PictureBox35.Size = New System.Drawing.Size(33, 33)
        Me.PictureBox35.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox35.TabIndex = 19
        Me.PictureBox35.TabStop = False
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Label58.ForeColor = System.Drawing.SystemColors.Control
        Me.Label58.Location = New System.Drawing.Point(190, 136)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(44, 13)
        Me.Label58.TabIndex = 2
        Me.Label58.Text = "Label2"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Label54.ForeColor = System.Drawing.SystemColors.Control
        Me.Label54.Location = New System.Drawing.Point(63, 97)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(38, 13)
        Me.Label54.TabIndex = 2
        Me.Label54.Text = "Ram:"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Label56.ForeColor = System.Drawing.SystemColors.Control
        Me.Label56.Location = New System.Drawing.Point(190, 176)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(44, 13)
        Me.Label56.TabIndex = 2
        Me.Label56.Text = "Label2"
        '
        'PictureBox36
        '
        Me.PictureBox36.Image = Global.Script_Agent.My.Resources.Resources.graphic_card
        Me.PictureBox36.Location = New System.Drawing.Point(24, 163)
        Me.PictureBox36.Name = "PictureBox36"
        Me.PictureBox36.Size = New System.Drawing.Size(33, 33)
        Me.PictureBox36.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox36.TabIndex = 19
        Me.PictureBox36.TabStop = False
        '
        'Btn_User
        '
        Me.Btn_User.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Btn_User.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Btn_User.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Btn_User.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Btn_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_User.ImageIndex = 1
        Me.Btn_User.ImageList = Me.ImageList_ExpandBtn
        Me.Btn_User.Location = New System.Drawing.Point(3, 7)
        Me.Btn_User.Name = "Btn_User"
        Me.Btn_User.Size = New System.Drawing.Size(30, 23)
        Me.Btn_User.TabIndex = 20
        Me.Btn_User.UseVisualStyleBackColor = True
        '
        'Lbl_User
        '
        Me.Lbl_User.AutoSize = True
        Me.Lbl_User.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_User.ForeColor = System.Drawing.SystemColors.Control
        Me.Lbl_User.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lbl_User.ImageIndex = 4
        Me.Lbl_User.Location = New System.Drawing.Point(67, 9)
        Me.Lbl_User.Name = "Lbl_User"
        Me.Lbl_User.Size = New System.Drawing.Size(45, 21)
        Me.Lbl_User.TabIndex = 2
        Me.Lbl_User.Text = "User"
        Me.Lbl_User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer_Windows
        '
        Me.Timer_Windows.Interval = 5
        '
        'Timer_Computer
        '
        Me.Timer_Computer.Interval = 5
        '
        'Timer_Network
        '
        Me.Timer_Network.Interval = 5
        '
        'Timer_Processes
        '
        Me.Timer_Processes.Interval = 5
        '
        'Timer_User
        '
        Me.Timer_User.Interval = 5
        '
        'PanelLiveStats
        '
        Me.PanelLiveStats.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelLiveStats.Controls.Add(Me.PanelCPU)
        Me.PanelLiveStats.Controls.Add(Me.PanelRam)
        Me.PanelLiveStats.Controls.Add(Me.PanelGpu)
        Me.PanelLiveStats.Controls.Add(Me.PanelNetwork)
        Me.PanelLiveStats.Controls.Add(Me.PanelDisk)
        Me.PanelLiveStats.Location = New System.Drawing.Point(736, 274)
        Me.PanelLiveStats.MaximumSize = New System.Drawing.Size(683, 527)
        Me.PanelLiveStats.MinimumSize = New System.Drawing.Size(680, 130)
        Me.PanelLiveStats.Name = "PanelLiveStats"
        Me.PanelLiveStats.Size = New System.Drawing.Size(683, 527)
        Me.PanelLiveStats.TabIndex = 23
        '
        'PanelCPU
        '
        Me.PanelCPU.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.PanelCPU.Controls.Add(Me.Label5)
        Me.PanelCPU.Controls.Add(Me.CircularProgressBar4)
        Me.PanelCPU.Controls.Add(Me.Label76)
        Me.PanelCPU.Controls.Add(Me.Label99)
        Me.PanelCPU.Controls.Add(Me.CircularProgressBar1)
        Me.PanelCPU.Controls.Add(Me.Lbl_CPU)
        Me.PanelCPU.Controls.Add(Me.Label83)
        Me.PanelCPU.Controls.Add(Me.Lbl_UpTime)
        Me.PanelCPU.Controls.Add(Me.Label1)
        Me.PanelCPU.Controls.Add(Me.Label11)
        Me.PanelCPU.Controls.Add(Me.Label79)
        Me.PanelCPU.Controls.Add(Me.Label100)
        Me.PanelCPU.Controls.Add(Me.Label27)
        Me.PanelCPU.Controls.Add(Me.Label6)
        Me.PanelCPU.Controls.Add(Me.Label98)
        Me.PanelCPU.Controls.Add(Me.Label31)
        Me.PanelCPU.Controls.Add(Me.Label10)
        Me.PanelCPU.Controls.Add(Me.Label90)
        Me.PanelCPU.Controls.Add(Me.Label71)
        Me.PanelCPU.Controls.Add(Me.LabelCpuClockSpeed)
        Me.PanelCPU.Controls.Add(Me.Label3)
        Me.PanelCPU.Controls.Add(Me.Label7)
        Me.PanelCPU.Controls.Add(Me.Label101)
        Me.PanelCPU.Controls.Add(Me.Label109)
        Me.PanelCPU.Controls.Add(Me.Label105)
        Me.PanelCPU.Controls.Add(Me.Label89)
        Me.PanelCPU.Controls.Add(Me.Label93)
        Me.PanelCPU.Controls.Add(Me.Label96)
        Me.PanelCPU.Controls.Add(Me.Label102)
        Me.PanelCPU.Controls.Add(Me.Label85)
        Me.PanelCPU.Controls.Add(Me.Label84)
        Me.PanelCPU.Controls.Add(Me.Label112)
        Me.PanelCPU.Controls.Add(Me.Label106)
        Me.PanelCPU.Controls.Add(Me.Label110)
        Me.PanelCPU.Controls.Add(Me.Label86)
        Me.PanelCPU.Controls.Add(Me.Label108)
        Me.PanelCPU.Controls.Add(Me.Label104)
        Me.PanelCPU.Controls.Add(Me.Label97)
        Me.PanelCPU.Controls.Add(Me.Label87)
        Me.PanelCPU.Controls.Add(Me.Label88)
        Me.PanelCPU.Controls.Add(Me.Label103)
        Me.PanelCPU.Controls.Add(Me.Label94)
        Me.PanelCPU.Controls.Add(Me.Label91)
        Me.PanelCPU.Controls.Add(Me.Label107)
        Me.PanelCPU.Location = New System.Drawing.Point(3, 2)
        Me.PanelCPU.MaximumSize = New System.Drawing.Size(676, 515)
        Me.PanelCPU.MinimumSize = New System.Drawing.Size(676, 124)
        Me.PanelCPU.Name = "PanelCPU"
        Me.PanelCPU.Size = New System.Drawing.Size(676, 124)
        Me.PanelCPU.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label5.Location = New System.Drawing.Point(2, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 12)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Cpu"
        '
        'CircularProgressBar4
        '
        Me.CircularProgressBar4.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CircularProgressBar4.AnimationSpeed = 500
        Me.CircularProgressBar4.BackColor = System.Drawing.Color.Transparent
        Me.CircularProgressBar4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CircularProgressBar4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.CircularProgressBar4.InnerColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CircularProgressBar4.InnerMargin = 2
        Me.CircularProgressBar4.InnerWidth = -1
        Me.CircularProgressBar4.Location = New System.Drawing.Point(555, 13)
        Me.CircularProgressBar4.MarqueeAnimationSpeed = 2000
        Me.CircularProgressBar4.Name = "CircularProgressBar4"
        Me.CircularProgressBar4.OuterColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.CircularProgressBar4.OuterMargin = -25
        Me.CircularProgressBar4.OuterWidth = 26
        Me.CircularProgressBar4.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CircularProgressBar4.ProgressWidth = 25
        Me.CircularProgressBar4.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold)
        Me.CircularProgressBar4.Size = New System.Drawing.Size(100, 100)
        Me.CircularProgressBar4.StartAngle = 270
        Me.CircularProgressBar4.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.CircularProgressBar4.SubscriptColor = System.Drawing.Color.DimGray
        Me.CircularProgressBar4.SubscriptMargin = New System.Windows.Forms.Padding(-21, 0, 0, 0)
        Me.CircularProgressBar4.SubscriptText = "TEMP"
        Me.CircularProgressBar4.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBar4.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CircularProgressBar4.SuperscriptText = ""
        Me.CircularProgressBar4.TabIndex = 23
        Me.CircularProgressBar4.TextMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.CircularProgressBar4.Value = 68
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label76.ForeColor = System.Drawing.Color.Gray
        Me.Label76.Location = New System.Drawing.Point(21, 164)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(86, 17)
        Me.Label76.TabIndex = 24
        Me.Label76.Text = "Manufacturer"
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label99.ForeColor = System.Drawing.Color.Silver
        Me.Label99.Location = New System.Drawing.Point(137, 356)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(25, 17)
        Me.Label99.TabIndex = 24
        Me.Label99.Text = "Txt"
        '
        'CircularProgressBar1
        '
        Me.CircularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CircularProgressBar1.AnimationSpeed = 500
        Me.CircularProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.CircularProgressBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CircularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.CircularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CircularProgressBar1.InnerMargin = 2
        Me.CircularProgressBar1.InnerWidth = -1
        Me.CircularProgressBar1.Location = New System.Drawing.Point(447, 13)
        Me.CircularProgressBar1.MarqueeAnimationSpeed = 2000
        Me.CircularProgressBar1.Name = "CircularProgressBar1"
        Me.CircularProgressBar1.OuterColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.CircularProgressBar1.OuterMargin = -25
        Me.CircularProgressBar1.OuterWidth = 26
        Me.CircularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CircularProgressBar1.ProgressWidth = 25
        Me.CircularProgressBar1.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CircularProgressBar1.Size = New System.Drawing.Size(100, 100)
        Me.CircularProgressBar1.StartAngle = 270
        Me.CircularProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.CircularProgressBar1.SubscriptColor = System.Drawing.Color.DimGray
        Me.CircularProgressBar1.SubscriptMargin = New System.Windows.Forms.Padding(-23, 0, 0, 0)
        Me.CircularProgressBar1.SubscriptText = "Cpu"
        Me.CircularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBar1.SuperscriptMargin = New System.Windows.Forms.Padding(0)
        Me.CircularProgressBar1.SuperscriptText = ""
        Me.CircularProgressBar1.TabIndex = 23
        Me.CircularProgressBar1.TextMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.CircularProgressBar1.Value = 68
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label83.ForeColor = System.Drawing.Color.Gray
        Me.Label83.Location = New System.Drawing.Point(21, 190)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(83, 17)
        Me.Label83.TabIndex = 24
        Me.Label83.Text = "Virtualization"
        '
        'Lbl_UpTime
        '
        Me.Lbl_UpTime.AutoSize = True
        Me.Lbl_UpTime.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Lbl_UpTime.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Lbl_UpTime.Location = New System.Drawing.Point(72, 96)
        Me.Lbl_UpTime.Name = "Lbl_UpTime"
        Me.Lbl_UpTime.Size = New System.Drawing.Size(16, 17)
        Me.Lbl_UpTime.TabIndex = 2
        Me.Lbl_UpTime.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(11, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cores"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label11.ForeColor = System.Drawing.Color.Silver
        Me.Label11.Location = New System.Drawing.Point(11, 79)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 17)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Socket"
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.ForeColor = System.Drawing.Color.Silver
        Me.Label79.Location = New System.Drawing.Point(280, 44)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(63, 12)
        Me.Label79.TabIndex = 2
        Me.Label79.Text = "Base speed"
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label100.ForeColor = System.Drawing.Color.Gray
        Me.Label100.Location = New System.Drawing.Point(347, 164)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(58, 17)
        Me.Label100.TabIndex = 24
        Me.Label100.Text = "DeviceID"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Silver
        Me.Label27.Location = New System.Drawing.Point(168, 44)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(76, 12)
        Me.Label27.TabIndex = 2
        Me.Label27.Text = "Current speed"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label6.ForeColor = System.Drawing.Color.Silver
        Me.Label6.Location = New System.Drawing.Point(11, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Treads"
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label98.ForeColor = System.Drawing.Color.Silver
        Me.Label98.Location = New System.Drawing.Point(137, 329)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(25, 17)
        Me.Label98.TabIndex = 24
        Me.Label98.Text = "Txt"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label31.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label31.Location = New System.Drawing.Point(72, 81)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(16, 17)
        Me.Label31.TabIndex = 2
        Me.Label31.Text = "X"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label10.ForeColor = System.Drawing.Color.Silver
        Me.Label10.Location = New System.Drawing.Point(12, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 17)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Up time"
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label90.ForeColor = System.Drawing.Color.Silver
        Me.Label90.Location = New System.Drawing.Point(137, 164)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(25, 17)
        Me.Label90.TabIndex = 24
        Me.Label90.Text = "Txt"
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label71.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label71.Location = New System.Drawing.Point(262, 61)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(65, 21)
        Me.Label71.TabIndex = 2
        Me.Label71.Text = "XX GHz"
        '
        'LabelCpuClockSpeed
        '
        Me.LabelCpuClockSpeed.AutoSize = True
        Me.LabelCpuClockSpeed.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelCpuClockSpeed.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.LabelCpuClockSpeed.Location = New System.Drawing.Point(172, 61)
        Me.LabelCpuClockSpeed.Name = "LabelCpuClockSpeed"
        Me.LabelCpuClockSpeed.Size = New System.Drawing.Size(65, 21)
        Me.LabelCpuClockSpeed.TabIndex = 2
        Me.LabelCpuClockSpeed.Text = "XX GHz"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(72, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "X"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label7.Location = New System.Drawing.Point(72, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 17)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "X"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label101.ForeColor = System.Drawing.Color.Gray
        Me.Label101.Location = New System.Drawing.Point(347, 190)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(90, 17)
        Me.Label101.TabIndex = 24
        Me.Label101.Text = "AddressWidth"
        '
        'Label109
        '
        Me.Label109.AutoSize = True
        Me.Label109.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label109.ForeColor = System.Drawing.Color.Gray
        Me.Label109.Location = New System.Drawing.Point(347, 245)
        Me.Label109.Name = "Label109"
        Me.Label109.Size = New System.Drawing.Size(56, 17)
        Me.Label109.TabIndex = 24
        Me.Label109.Text = "ExtClock"
        '
        'Label105
        '
        Me.Label105.AutoSize = True
        Me.Label105.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label105.ForeColor = System.Drawing.Color.Gray
        Me.Label105.Location = New System.Drawing.Point(347, 218)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(69, 17)
        Me.Label105.TabIndex = 24
        Me.Label105.Text = "DataWidth"
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label89.ForeColor = System.Drawing.Color.Gray
        Me.Label89.Location = New System.Drawing.Point(21, 356)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(92, 17)
        Me.Label89.TabIndex = 24
        Me.Label89.Text = "LastErrorCode"
        '
        'Label93
        '
        Me.Label93.AutoSize = True
        Me.Label93.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label93.ForeColor = System.Drawing.Color.Silver
        Me.Label93.Location = New System.Drawing.Point(137, 275)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(25, 17)
        Me.Label93.TabIndex = 24
        Me.Label93.Text = "Txt"
        '
        'Label96
        '
        Me.Label96.AutoSize = True
        Me.Label96.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label96.ForeColor = System.Drawing.Color.Silver
        Me.Label96.Location = New System.Drawing.Point(137, 301)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(25, 17)
        Me.Label96.TabIndex = 24
        Me.Label96.Text = "Txt"
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label102.ForeColor = System.Drawing.Color.Silver
        Me.Label102.Location = New System.Drawing.Point(499, 164)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(25, 17)
        Me.Label102.TabIndex = 24
        Me.Label102.Text = "Txt"
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label85.ForeColor = System.Drawing.Color.Gray
        Me.Label85.Location = New System.Drawing.Point(21, 245)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(79, 17)
        Me.Label85.TabIndex = 24
        Me.Label85.Text = "L3CacheSize"
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label84.ForeColor = System.Drawing.Color.Gray
        Me.Label84.Location = New System.Drawing.Point(21, 218)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(79, 17)
        Me.Label84.TabIndex = 24
        Me.Label84.Text = "L2CacheSize"
        '
        'Label112
        '
        Me.Label112.AutoSize = True
        Me.Label112.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label112.ForeColor = System.Drawing.Color.Silver
        Me.Label112.Location = New System.Drawing.Point(499, 245)
        Me.Label112.Name = "Label112"
        Me.Label112.Size = New System.Drawing.Size(25, 17)
        Me.Label112.TabIndex = 24
        Me.Label112.Text = "Txt"
        '
        'Label106
        '
        Me.Label106.AutoSize = True
        Me.Label106.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label106.ForeColor = System.Drawing.Color.Silver
        Me.Label106.Location = New System.Drawing.Point(499, 275)
        Me.Label106.Name = "Label106"
        Me.Label106.Size = New System.Drawing.Size(25, 17)
        Me.Label106.TabIndex = 24
        Me.Label106.Text = "Txt"
        '
        'Label110
        '
        Me.Label110.AutoSize = True
        Me.Label110.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label110.ForeColor = System.Drawing.Color.Silver
        Me.Label110.Location = New System.Drawing.Point(499, 303)
        Me.Label110.Name = "Label110"
        Me.Label110.Size = New System.Drawing.Size(25, 17)
        Me.Label110.TabIndex = 24
        Me.Label110.Text = "Txt"
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label86.ForeColor = System.Drawing.Color.Gray
        Me.Label86.Location = New System.Drawing.Point(21, 275)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(43, 17)
        Me.Label86.TabIndex = 24
        Me.Label86.Text = "Status"
        '
        'Label108
        '
        Me.Label108.AutoSize = True
        Me.Label108.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label108.ForeColor = System.Drawing.Color.Silver
        Me.Label108.Location = New System.Drawing.Point(499, 218)
        Me.Label108.Name = "Label108"
        Me.Label108.Size = New System.Drawing.Size(25, 17)
        Me.Label108.TabIndex = 24
        Me.Label108.Text = "Txt"
        '
        'Label104
        '
        Me.Label104.AutoSize = True
        Me.Label104.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label104.ForeColor = System.Drawing.Color.Silver
        Me.Label104.Location = New System.Drawing.Point(499, 190)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(25, 17)
        Me.Label104.TabIndex = 24
        Me.Label104.Text = "Txt"
        '
        'Label97
        '
        Me.Label97.AutoSize = True
        Me.Label97.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label97.ForeColor = System.Drawing.Color.Silver
        Me.Label97.Location = New System.Drawing.Point(137, 245)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(25, 17)
        Me.Label97.TabIndex = 24
        Me.Label97.Text = "Txt"
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label87.ForeColor = System.Drawing.Color.Gray
        Me.Label87.Location = New System.Drawing.Point(21, 301)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(96, 17)
        Me.Label87.TabIndex = 24
        Me.Label87.Text = "CurrentVoltage"
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label88.ForeColor = System.Drawing.Color.Gray
        Me.Label88.Location = New System.Drawing.Point(21, 329)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(77, 17)
        Me.Label88.TabIndex = 24
        Me.Label88.Text = "ProcessorId"
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label103.ForeColor = System.Drawing.Color.Gray
        Me.Label103.Location = New System.Drawing.Point(347, 275)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(125, 17)
        Me.Label103.TabIndex = 24
        Me.Label103.Text = "Power Management"
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label94.ForeColor = System.Drawing.Color.Silver
        Me.Label94.Location = New System.Drawing.Point(137, 218)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(25, 17)
        Me.Label94.TabIndex = 24
        Me.Label94.Text = "Txt"
        '
        'Label91
        '
        Me.Label91.AutoSize = True
        Me.Label91.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label91.ForeColor = System.Drawing.Color.Silver
        Me.Label91.Location = New System.Drawing.Point(137, 190)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(25, 17)
        Me.Label91.TabIndex = 24
        Me.Label91.Text = "Txt"
        '
        'Label107
        '
        Me.Label107.AutoSize = True
        Me.Label107.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label107.ForeColor = System.Drawing.Color.Gray
        Me.Label107.Location = New System.Drawing.Point(347, 301)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(52, 17)
        Me.Label107.TabIndex = 24
        Me.Label107.Text = "Version"
        '
        'PanelRam
        '
        Me.PanelRam.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.PanelRam.Controls.Add(Me.Label116)
        Me.PanelRam.Controls.Add(Me.Label132)
        Me.PanelRam.Controls.Add(Me.Label16)
        Me.PanelRam.Controls.Add(Me.Label17)
        Me.PanelRam.Controls.Add(Me.Label131)
        Me.PanelRam.Controls.Add(Me.CircularProgressBar2)
        Me.PanelRam.Controls.Add(Me.CircularProgressBarRam2)
        Me.PanelRam.Controls.Add(Me.Label117)
        Me.PanelRam.Controls.Add(Me.Label18)
        Me.PanelRam.Controls.Add(Me.Label2)
        Me.PanelRam.Controls.Add(Me.Label133)
        Me.PanelRam.Controls.Add(Me.Label23)
        Me.PanelRam.Controls.Add(Me.Label22)
        Me.PanelRam.Controls.Add(Me.Label130)
        Me.PanelRam.Controls.Add(Me.Lbl_TotalRam)
        Me.PanelRam.Controls.Add(Me.Label21)
        Me.PanelRam.Controls.Add(Me.Label118)
        Me.PanelRam.Controls.Add(Me.Label19)
        Me.PanelRam.Controls.Add(Me.Label38)
        Me.PanelRam.Controls.Add(Me.Label134)
        Me.PanelRam.Controls.Add(Me.Label37)
        Me.PanelRam.Controls.Add(Me.Lbl_Available)
        Me.PanelRam.Controls.Add(Me.Label129)
        Me.PanelRam.Controls.Add(Me.Lbl_RamInUse)
        Me.PanelRam.Controls.Add(Me.Label33)
        Me.PanelRam.Controls.Add(Me.Label119)
        Me.PanelRam.Controls.Add(Me.Label122)
        Me.PanelRam.Controls.Add(Me.Label121)
        Me.PanelRam.Controls.Add(Me.Label111)
        Me.PanelRam.Controls.Add(Me.Label124)
        Me.PanelRam.Controls.Add(Me.Label137)
        Me.PanelRam.Controls.Add(Me.Label135)
        Me.PanelRam.Controls.Add(Me.Label125)
        Me.PanelRam.Controls.Add(Me.Label126)
        Me.PanelRam.Controls.Add(Me.Label128)
        Me.PanelRam.Controls.Add(Me.Label123)
        Me.PanelRam.Controls.Add(Me.Label140)
        Me.PanelRam.Controls.Add(Me.Label141)
        Me.PanelRam.Controls.Add(Me.Label127)
        Me.PanelRam.Controls.Add(Me.Label136)
        Me.PanelRam.Controls.Add(Me.Label120)
        Me.PanelRam.Location = New System.Drawing.Point(3, 132)
        Me.PanelRam.MaximumSize = New System.Drawing.Size(676, 515)
        Me.PanelRam.MinimumSize = New System.Drawing.Size(676, 124)
        Me.PanelRam.Name = "PanelRam"
        Me.PanelRam.Size = New System.Drawing.Size(676, 124)
        Me.PanelRam.TabIndex = 24
        '
        'Label116
        '
        Me.Label116.AutoSize = True
        Me.Label116.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label116.ForeColor = System.Drawing.Color.Silver
        Me.Label116.Location = New System.Drawing.Point(16, 138)
        Me.Label116.Name = "Label116"
        Me.Label116.Size = New System.Drawing.Size(25, 17)
        Me.Label116.TabIndex = 24
        Me.Label116.Text = "Txt"
        '
        'Label132
        '
        Me.Label132.AutoSize = True
        Me.Label132.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label132.ForeColor = System.Drawing.Color.Silver
        Me.Label132.Location = New System.Drawing.Point(180, 239)
        Me.Label132.Name = "Label132"
        Me.Label132.Size = New System.Drawing.Size(25, 17)
        Me.Label132.TabIndex = 24
        Me.Label132.Text = "Txt"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label16.Location = New System.Drawing.Point(2, 1)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(28, 12)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Ram"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label17.Location = New System.Drawing.Point(325, 77)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 17)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Label2"
        '
        'Label131
        '
        Me.Label131.AutoSize = True
        Me.Label131.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label131.ForeColor = System.Drawing.Color.DarkGray
        Me.Label131.Location = New System.Drawing.Point(362, 321)
        Me.Label131.Name = "Label131"
        Me.Label131.Size = New System.Drawing.Size(30, 17)
        Me.Label131.TabIndex = 24
        Me.Label131.Text = "Tag"
        '
        'CircularProgressBar2
        '
        Me.CircularProgressBar2.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CircularProgressBar2.AnimationSpeed = 500
        Me.CircularProgressBar2.BackColor = System.Drawing.Color.Transparent
        Me.CircularProgressBar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CircularProgressBar2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.CircularProgressBar2.InnerColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CircularProgressBar2.InnerMargin = 2
        Me.CircularProgressBar2.InnerWidth = -1
        Me.CircularProgressBar2.Location = New System.Drawing.Point(447, 13)
        Me.CircularProgressBar2.MarqueeAnimationSpeed = 2000
        Me.CircularProgressBar2.Name = "CircularProgressBar2"
        Me.CircularProgressBar2.OuterColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.CircularProgressBar2.OuterMargin = -25
        Me.CircularProgressBar2.OuterWidth = 26
        Me.CircularProgressBar2.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CircularProgressBar2.ProgressWidth = 25
        Me.CircularProgressBar2.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold)
        Me.CircularProgressBar2.Size = New System.Drawing.Size(100, 100)
        Me.CircularProgressBar2.StartAngle = 270
        Me.CircularProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.CircularProgressBar2.SubscriptColor = System.Drawing.Color.DimGray
        Me.CircularProgressBar2.SubscriptMargin = New System.Windows.Forms.Padding(-23, 0, 0, 0)
        Me.CircularProgressBar2.SubscriptText = "Used"
        Me.CircularProgressBar2.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBar2.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CircularProgressBar2.SuperscriptText = ""
        Me.CircularProgressBar2.TabIndex = 23
        Me.CircularProgressBar2.TextMargin = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.CircularProgressBar2.Value = 68
        '
        'CircularProgressBarRam2
        '
        Me.CircularProgressBarRam2.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CircularProgressBarRam2.AnimationSpeed = 500
        Me.CircularProgressBarRam2.BackColor = System.Drawing.Color.Transparent
        Me.CircularProgressBarRam2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CircularProgressBarRam2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.CircularProgressBarRam2.InnerColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CircularProgressBarRam2.InnerMargin = 2
        Me.CircularProgressBarRam2.InnerWidth = -1
        Me.CircularProgressBarRam2.Location = New System.Drawing.Point(555, 13)
        Me.CircularProgressBarRam2.MarqueeAnimationSpeed = 2000
        Me.CircularProgressBarRam2.Name = "CircularProgressBarRam2"
        Me.CircularProgressBarRam2.OuterColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.CircularProgressBarRam2.OuterMargin = -25
        Me.CircularProgressBarRam2.OuterWidth = 26
        Me.CircularProgressBarRam2.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CircularProgressBarRam2.ProgressWidth = 25
        Me.CircularProgressBarRam2.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold)
        Me.CircularProgressBarRam2.Size = New System.Drawing.Size(100, 100)
        Me.CircularProgressBarRam2.StartAngle = 270
        Me.CircularProgressBarRam2.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.CircularProgressBarRam2.SubscriptColor = System.Drawing.Color.DimGray
        Me.CircularProgressBarRam2.SubscriptMargin = New System.Windows.Forms.Padding(-23, 0, 0, 0)
        Me.CircularProgressBarRam2.SubscriptText = "Free"
        Me.CircularProgressBarRam2.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBarRam2.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CircularProgressBarRam2.SuperscriptText = ""
        Me.CircularProgressBarRam2.TabIndex = 23
        Me.CircularProgressBarRam2.TextMargin = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.CircularProgressBarRam2.Value = 68
        '
        'Label117
        '
        Me.Label117.AutoSize = True
        Me.Label117.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label117.ForeColor = System.Drawing.Color.Gray
        Me.Label117.Location = New System.Drawing.Point(34, 210)
        Me.Label117.Name = "Label117"
        Me.Label117.Size = New System.Drawing.Size(74, 17)
        Me.Label117.TabIndex = 24
        Me.Label117.Text = "FormFactor"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label18.Location = New System.Drawing.Point(325, 59)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(46, 17)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Label2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(20, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 21)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Ram usage"
        '
        'Label133
        '
        Me.Label133.AutoSize = True
        Me.Label133.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label133.ForeColor = System.Drawing.Color.Silver
        Me.Label133.Location = New System.Drawing.Point(459, 239)
        Me.Label133.Name = "Label133"
        Me.Label133.Size = New System.Drawing.Size(25, 17)
        Me.Label133.TabIndex = 24
        Me.Label133.Text = "Txt"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Silver
        Me.Label23.Location = New System.Drawing.Point(252, 42)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(45, 17)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "Speed"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Silver
        Me.Label22.Location = New System.Drawing.Point(252, 59)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(36, 17)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "Slots"
        '
        'Label130
        '
        Me.Label130.AutoSize = True
        Me.Label130.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label130.ForeColor = System.Drawing.Color.Gray
        Me.Label130.Location = New System.Drawing.Point(34, 321)
        Me.Label130.Name = "Label130"
        Me.Label130.Size = New System.Drawing.Size(131, 17)
        Me.Label130.TabIndex = 24
        Me.Label130.Text = "SMBIOSMemoryType"
        '
        'Lbl_TotalRam
        '
        Me.Lbl_TotalRam.AutoSize = True
        Me.Lbl_TotalRam.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_TotalRam.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Lbl_TotalRam.Location = New System.Drawing.Point(166, 77)
        Me.Lbl_TotalRam.Name = "Lbl_TotalRam"
        Me.Lbl_TotalRam.Size = New System.Drawing.Size(65, 21)
        Me.Lbl_TotalRam.TabIndex = 2
        Me.Lbl_TotalRam.Text = "XX GHz"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Silver
        Me.Label21.Location = New System.Drawing.Point(252, 77)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(68, 17)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "Slots used"
        '
        'Label118
        '
        Me.Label118.AutoSize = True
        Me.Label118.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label118.ForeColor = System.Drawing.Color.DarkGray
        Me.Label118.Location = New System.Drawing.Point(362, 184)
        Me.Label118.Name = "Label118"
        Me.Label118.Size = New System.Drawing.Size(66, 17)
        Me.Label118.TabIndex = 24
        Me.Label118.Text = "BankLabel"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label19.Location = New System.Drawing.Point(325, 42)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(46, 17)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Label2"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Verdana", 6.75!)
        Me.Label38.ForeColor = System.Drawing.Color.Silver
        Me.Label38.Location = New System.Drawing.Point(187, 59)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(30, 12)
        Me.Label38.TabIndex = 2
        Me.Label38.Text = "Total"
        '
        'Label134
        '
        Me.Label134.AutoSize = True
        Me.Label134.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label134.ForeColor = System.Drawing.Color.Gray
        Me.Label134.Location = New System.Drawing.Point(34, 265)
        Me.Label134.Name = "Label134"
        Me.Label134.Size = New System.Drawing.Size(71, 17)
        Me.Label134.TabIndex = 24
        Me.Label134.Text = "TotalWidth"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Verdana", 6.75!)
        Me.Label37.ForeColor = System.Drawing.Color.Silver
        Me.Label37.Location = New System.Drawing.Point(100, 59)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(52, 12)
        Me.Label37.TabIndex = 2
        Me.Label37.Text = "Available"
        '
        'Lbl_Available
        '
        Me.Lbl_Available.AutoSize = True
        Me.Lbl_Available.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Available.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Lbl_Available.Location = New System.Drawing.Point(87, 77)
        Me.Lbl_Available.Name = "Lbl_Available"
        Me.Lbl_Available.Size = New System.Drawing.Size(65, 21)
        Me.Lbl_Available.TabIndex = 2
        Me.Lbl_Available.Text = "XX GHz"
        '
        'Label129
        '
        Me.Label129.AutoSize = True
        Me.Label129.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label129.ForeColor = System.Drawing.Color.Silver
        Me.Label129.Location = New System.Drawing.Point(459, 296)
        Me.Label129.Name = "Label129"
        Me.Label129.Size = New System.Drawing.Size(25, 17)
        Me.Label129.TabIndex = 24
        Me.Label129.Text = "Txt"
        '
        'Lbl_RamInUse
        '
        Me.Lbl_RamInUse.AutoSize = True
        Me.Lbl_RamInUse.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_RamInUse.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Lbl_RamInUse.Location = New System.Drawing.Point(15, 77)
        Me.Lbl_RamInUse.Name = "Lbl_RamInUse"
        Me.Lbl_RamInUse.Size = New System.Drawing.Size(65, 21)
        Me.Lbl_RamInUse.TabIndex = 2
        Me.Lbl_RamInUse.Text = "XX GHz"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Verdana", 6.75!)
        Me.Label33.ForeColor = System.Drawing.Color.Silver
        Me.Label33.Location = New System.Drawing.Point(29, 60)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(37, 12)
        Me.Label33.TabIndex = 2
        Me.Label33.Text = "In use"
        '
        'Label119
        '
        Me.Label119.AutoSize = True
        Me.Label119.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label119.ForeColor = System.Drawing.Color.Silver
        Me.Label119.Location = New System.Drawing.Point(180, 185)
        Me.Label119.Name = "Label119"
        Me.Label119.Size = New System.Drawing.Size(25, 17)
        Me.Label119.TabIndex = 24
        Me.Label119.Text = "Txt"
        '
        'Label122
        '
        Me.Label122.AutoSize = True
        Me.Label122.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label122.ForeColor = System.Drawing.Color.Gray
        Me.Label122.Location = New System.Drawing.Point(34, 295)
        Me.Label122.Name = "Label122"
        Me.Label122.Size = New System.Drawing.Size(118, 17)
        Me.Label122.TabIndex = 24
        Me.Label122.Text = "ConfiguredVoltage"
        '
        'Label121
        '
        Me.Label121.AutoSize = True
        Me.Label121.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label121.ForeColor = System.Drawing.Color.Silver
        Me.Label121.Location = New System.Drawing.Point(459, 185)
        Me.Label121.Name = "Label121"
        Me.Label121.Size = New System.Drawing.Size(25, 17)
        Me.Label121.TabIndex = 24
        Me.Label121.Text = "Txt"
        '
        'Label111
        '
        Me.Label111.AutoSize = True
        Me.Label111.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label111.ForeColor = System.Drawing.Color.Gray
        Me.Label111.Location = New System.Drawing.Point(34, 184)
        Me.Label111.Name = "Label111"
        Me.Label111.Size = New System.Drawing.Size(79, 17)
        Me.Label111.TabIndex = 24
        Me.Label111.Text = "PartNumber"
        '
        'Label124
        '
        Me.Label124.AutoSize = True
        Me.Label124.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label124.ForeColor = System.Drawing.Color.Silver
        Me.Label124.Location = New System.Drawing.Point(180, 211)
        Me.Label124.Name = "Label124"
        Me.Label124.Size = New System.Drawing.Size(25, 17)
        Me.Label124.TabIndex = 24
        Me.Label124.Text = "Txt"
        '
        'Label137
        '
        Me.Label137.AutoSize = True
        Me.Label137.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label137.ForeColor = System.Drawing.Color.Silver
        Me.Label137.Location = New System.Drawing.Point(459, 322)
        Me.Label137.Name = "Label137"
        Me.Label137.Size = New System.Drawing.Size(25, 17)
        Me.Label137.TabIndex = 24
        Me.Label137.Text = "Txt"
        '
        'Label135
        '
        Me.Label135.AutoSize = True
        Me.Label135.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label135.ForeColor = System.Drawing.Color.DarkGray
        Me.Label135.Location = New System.Drawing.Point(362, 265)
        Me.Label135.Name = "Label135"
        Me.Label135.Size = New System.Drawing.Size(86, 17)
        Me.Label135.TabIndex = 24
        Me.Label135.Text = "Manufacturer"
        '
        'Label125
        '
        Me.Label125.AutoSize = True
        Me.Label125.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label125.ForeColor = System.Drawing.Color.Silver
        Me.Label125.Location = New System.Drawing.Point(459, 211)
        Me.Label125.Name = "Label125"
        Me.Label125.Size = New System.Drawing.Size(25, 17)
        Me.Label125.TabIndex = 24
        Me.Label125.Text = "Txt"
        '
        'Label126
        '
        Me.Label126.AutoSize = True
        Me.Label126.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label126.ForeColor = System.Drawing.Color.Gray
        Me.Label126.Location = New System.Drawing.Point(34, 238)
        Me.Label126.Name = "Label126"
        Me.Label126.Size = New System.Drawing.Size(69, 17)
        Me.Label126.TabIndex = 24
        Me.Label126.Text = "DataWidth"
        '
        'Label128
        '
        Me.Label128.AutoSize = True
        Me.Label128.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label128.ForeColor = System.Drawing.Color.Silver
        Me.Label128.Location = New System.Drawing.Point(180, 296)
        Me.Label128.Name = "Label128"
        Me.Label128.Size = New System.Drawing.Size(25, 17)
        Me.Label128.TabIndex = 24
        Me.Label128.Text = "Txt"
        '
        'Label123
        '
        Me.Label123.AutoSize = True
        Me.Label123.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label123.ForeColor = System.Drawing.Color.DarkGray
        Me.Label123.Location = New System.Drawing.Point(362, 295)
        Me.Label123.Name = "Label123"
        Me.Label123.Size = New System.Drawing.Size(88, 17)
        Me.Label123.TabIndex = 24
        Me.Label123.Text = "SerialNumber"
        '
        'Label140
        '
        Me.Label140.AutoSize = True
        Me.Label140.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label140.ForeColor = System.Drawing.Color.Silver
        Me.Label140.Location = New System.Drawing.Point(180, 266)
        Me.Label140.Name = "Label140"
        Me.Label140.Size = New System.Drawing.Size(25, 17)
        Me.Label140.TabIndex = 24
        Me.Label140.Text = "Txt"
        '
        'Label141
        '
        Me.Label141.AutoSize = True
        Me.Label141.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label141.ForeColor = System.Drawing.Color.Silver
        Me.Label141.Location = New System.Drawing.Point(459, 266)
        Me.Label141.Name = "Label141"
        Me.Label141.Size = New System.Drawing.Size(25, 17)
        Me.Label141.TabIndex = 24
        Me.Label141.Text = "Txt"
        '
        'Label127
        '
        Me.Label127.AutoSize = True
        Me.Label127.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label127.ForeColor = System.Drawing.Color.DarkGray
        Me.Label127.Location = New System.Drawing.Point(362, 238)
        Me.Label127.Name = "Label127"
        Me.Label127.Size = New System.Drawing.Size(64, 17)
        Me.Label127.TabIndex = 24
        Me.Label127.Text = "Attributes"
        '
        'Label136
        '
        Me.Label136.AutoSize = True
        Me.Label136.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label136.ForeColor = System.Drawing.Color.Silver
        Me.Label136.Location = New System.Drawing.Point(180, 322)
        Me.Label136.Name = "Label136"
        Me.Label136.Size = New System.Drawing.Size(25, 17)
        Me.Label136.TabIndex = 24
        Me.Label136.Text = "Txt"
        '
        'Label120
        '
        Me.Label120.AutoSize = True
        Me.Label120.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label120.ForeColor = System.Drawing.Color.DarkGray
        Me.Label120.Location = New System.Drawing.Point(362, 210)
        Me.Label120.Name = "Label120"
        Me.Label120.Size = New System.Drawing.Size(85, 17)
        Me.Label120.TabIndex = 24
        Me.Label120.Text = "MemoryType"
        '
        'PanelGpu
        '
        Me.PanelGpu.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.PanelGpu.Controls.Add(Me.Label42)
        Me.PanelGpu.Controls.Add(Me.CircularProgressBar7)
        Me.PanelGpu.Controls.Add(Me.Label74)
        Me.PanelGpu.Controls.Add(Me.LabelGpuMemoryUsed)
        Me.PanelGpu.Controls.Add(Me.Label92)
        Me.PanelGpu.Controls.Add(Me.Lbl_GpuTotalMemory)
        Me.PanelGpu.Controls.Add(Me.LblGpuUsage)
        Me.PanelGpu.Controls.Add(Me.Lbl_GPU_WTF)
        Me.PanelGpu.Controls.Add(Me.Label95)
        Me.PanelGpu.Location = New System.Drawing.Point(348, 393)
        Me.PanelGpu.MaximumSize = New System.Drawing.Size(676, 515)
        Me.PanelGpu.MinimumSize = New System.Drawing.Size(332, 124)
        Me.PanelGpu.Name = "PanelGpu"
        Me.PanelGpu.Size = New System.Drawing.Size(332, 124)
        Me.PanelGpu.TabIndex = 24
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label42.Location = New System.Drawing.Point(2, 1)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(25, 12)
        Me.Label42.TabIndex = 3
        Me.Label42.Text = "Gpu"
        '
        'CircularProgressBar7
        '
        Me.CircularProgressBar7.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CircularProgressBar7.AnimationSpeed = 500
        Me.CircularProgressBar7.BackColor = System.Drawing.Color.Transparent
        Me.CircularProgressBar7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CircularProgressBar7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.CircularProgressBar7.InnerColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CircularProgressBar7.InnerMargin = 2
        Me.CircularProgressBar7.InnerWidth = -1
        Me.CircularProgressBar7.Location = New System.Drawing.Point(210, 12)
        Me.CircularProgressBar7.MarqueeAnimationSpeed = 2000
        Me.CircularProgressBar7.Name = "CircularProgressBar7"
        Me.CircularProgressBar7.OuterColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.CircularProgressBar7.OuterMargin = -25
        Me.CircularProgressBar7.OuterWidth = 26
        Me.CircularProgressBar7.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CircularProgressBar7.ProgressWidth = 25
        Me.CircularProgressBar7.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CircularProgressBar7.Size = New System.Drawing.Size(100, 100)
        Me.CircularProgressBar7.StartAngle = 270
        Me.CircularProgressBar7.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.CircularProgressBar7.SubscriptColor = System.Drawing.Color.DimGray
        Me.CircularProgressBar7.SubscriptMargin = New System.Windows.Forms.Padding(-21, 0, 0, 0)
        Me.CircularProgressBar7.SubscriptText = "Gpu"
        Me.CircularProgressBar7.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBar7.SuperscriptMargin = New System.Windows.Forms.Padding(0)
        Me.CircularProgressBar7.SuperscriptText = ""
        Me.CircularProgressBar7.TabIndex = 23
        Me.CircularProgressBar7.TextMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.CircularProgressBar7.Value = 68
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Font = New System.Drawing.Font("Verdana", 6.75!)
        Me.Label74.ForeColor = System.Drawing.Color.Silver
        Me.Label74.Location = New System.Drawing.Point(93, 60)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(45, 12)
        Me.Label74.TabIndex = 2
        Me.Label74.Text = "Memory"
        '
        'LabelGpuMemoryUsed
        '
        Me.LabelGpuMemoryUsed.AutoSize = True
        Me.LabelGpuMemoryUsed.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelGpuMemoryUsed.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.LabelGpuMemoryUsed.Location = New System.Drawing.Point(94, 78)
        Me.LabelGpuMemoryUsed.Name = "LabelGpuMemoryUsed"
        Me.LabelGpuMemoryUsed.Size = New System.Drawing.Size(44, 21)
        Me.LabelGpuMemoryUsed.TabIndex = 2
        Me.LabelGpuMemoryUsed.Text = "1 GB"
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Font = New System.Drawing.Font("Verdana", 6.75!)
        Me.Label92.ForeColor = System.Drawing.Color.Silver
        Me.Label92.Location = New System.Drawing.Point(155, 59)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(45, 12)
        Me.Label92.TabIndex = 2
        Me.Label92.Text = "Memory"
        '
        'Lbl_GpuTotalMemory
        '
        Me.Lbl_GpuTotalMemory.AutoSize = True
        Me.Lbl_GpuTotalMemory.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_GpuTotalMemory.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Lbl_GpuTotalMemory.Location = New System.Drawing.Point(156, 77)
        Me.Lbl_GpuTotalMemory.Name = "Lbl_GpuTotalMemory"
        Me.Lbl_GpuTotalMemory.Size = New System.Drawing.Size(44, 21)
        Me.Lbl_GpuTotalMemory.TabIndex = 2
        Me.Lbl_GpuTotalMemory.Text = "1 GB"
        '
        'LblGpuUsage
        '
        Me.LblGpuUsage.AutoSize = True
        Me.LblGpuUsage.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblGpuUsage.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.LblGpuUsage.Location = New System.Drawing.Point(28, 78)
        Me.LblGpuUsage.Name = "LblGpuUsage"
        Me.LblGpuUsage.Size = New System.Drawing.Size(46, 21)
        Me.LblGpuUsage.TabIndex = 2
        Me.LblGpuUsage.Text = "12 %"
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.Font = New System.Drawing.Font("Verdana", 6.75!)
        Me.Label95.ForeColor = System.Drawing.Color.Silver
        Me.Label95.Location = New System.Drawing.Point(31, 60)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(37, 12)
        Me.Label95.TabIndex = 2
        Me.Label95.Text = "In use"
        '
        'PanelDisk
        '
        Me.PanelDisk.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.PanelDisk.Controls.Add(Me.Panel1)
        Me.PanelDisk.Controls.Add(Me.Label39)
        Me.PanelDisk.Controls.Add(Me.CircularProgressBar6)
        Me.PanelDisk.Controls.Add(Me.CircularProgressBar5)
        Me.PanelDisk.Controls.Add(Me.Label152)
        Me.PanelDisk.Controls.Add(Me.Label151)
        Me.PanelDisk.Controls.Add(Me.Label144)
        Me.PanelDisk.Controls.Add(Me.Label150)
        Me.PanelDisk.Controls.Add(Me.Label143)
        Me.PanelDisk.Controls.Add(Me.Label149)
        Me.PanelDisk.Controls.Add(Me.Label138)
        Me.PanelDisk.Controls.Add(Me.Label148)
        Me.PanelDisk.Controls.Add(Me.Label142)
        Me.PanelDisk.Controls.Add(Me.Label147)
        Me.PanelDisk.Controls.Add(Me.Label115)
        Me.PanelDisk.Controls.Add(Me.Label146)
        Me.PanelDisk.Controls.Add(Me.Label139)
        Me.PanelDisk.Controls.Add(Me.Label145)
        Me.PanelDisk.Controls.Add(Me.Label114)
        Me.PanelDisk.Controls.Add(Me.Label113)
        Me.PanelDisk.Controls.Add(Me.Label40)
        Me.PanelDisk.Controls.Add(Me.Label41)
        Me.PanelDisk.Controls.Add(Me.Lbl_Disk)
        Me.PanelDisk.Controls.Add(Me.Label43)
        Me.PanelDisk.Controls.Add(Me.Label45)
        Me.PanelDisk.Controls.Add(Me.Label48)
        Me.PanelDisk.Controls.Add(Me.Label169)
        Me.PanelDisk.Controls.Add(Me.Label50)
        Me.PanelDisk.Controls.Add(Me.Label51)
        Me.PanelDisk.Controls.Add(Me.Label52)
        Me.PanelDisk.Controls.Add(Me.Label53)
        Me.PanelDisk.Controls.Add(Me.Label55)
        Me.PanelDisk.Controls.Add(Me.Label57)
        Me.PanelDisk.Controls.Add(Me.Label59)
        Me.PanelDisk.Location = New System.Drawing.Point(4, 262)
        Me.PanelDisk.MaximumSize = New System.Drawing.Size(676, 515)
        Me.PanelDisk.MinimumSize = New System.Drawing.Size(676, 124)
        Me.PanelDisk.Name = "PanelDisk"
        Me.PanelDisk.Size = New System.Drawing.Size(676, 124)
        Me.PanelDisk.TabIndex = 24
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label170)
        Me.Panel1.Controls.Add(Me.Label154)
        Me.Panel1.Controls.Add(Me.Label153)
        Me.Panel1.Controls.Add(Me.Label168)
        Me.Panel1.Controls.Add(Me.Label155)
        Me.Panel1.Controls.Add(Me.Label167)
        Me.Panel1.Controls.Add(Me.Label156)
        Me.Panel1.Controls.Add(Me.Label166)
        Me.Panel1.Controls.Add(Me.Label157)
        Me.Panel1.Controls.Add(Me.Label165)
        Me.Panel1.Controls.Add(Me.Label158)
        Me.Panel1.Controls.Add(Me.Label164)
        Me.Panel1.Controls.Add(Me.Label159)
        Me.Panel1.Controls.Add(Me.Label163)
        Me.Panel1.Controls.Add(Me.Label160)
        Me.Panel1.Controls.Add(Me.Label162)
        Me.Panel1.Controls.Add(Me.Label161)
        Me.Panel1.Location = New System.Drawing.Point(296, 121)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(327, 366)
        Me.Panel1.TabIndex = 25
        '
        'Label170
        '
        Me.Label170.AutoSize = True
        Me.Label170.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label170.ForeColor = System.Drawing.Color.Silver
        Me.Label170.Location = New System.Drawing.Point(7, 11)
        Me.Label170.Name = "Label170"
        Me.Label170.Size = New System.Drawing.Size(81, 17)
        Me.Label170.TabIndex = 2
        Me.Label170.Text = "Disk Caption"
        '
        'Label154
        '
        Me.Label154.AutoSize = True
        Me.Label154.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label154.ForeColor = System.Drawing.Color.Silver
        Me.Label154.Location = New System.Drawing.Point(132, 39)
        Me.Label154.Name = "Label154"
        Me.Label154.Size = New System.Drawing.Size(32, 17)
        Me.Label154.TabIndex = 24
        Me.Label154.Text = "Text"
        '
        'Label153
        '
        Me.Label153.AutoSize = True
        Me.Label153.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label153.ForeColor = System.Drawing.Color.Gray
        Me.Label153.Location = New System.Drawing.Point(12, 39)
        Me.Label153.Name = "Label153"
        Me.Label153.Size = New System.Drawing.Size(43, 17)
        Me.Label153.TabIndex = 24
        Me.Label153.Text = "Status"
        '
        'Label168
        '
        Me.Label168.AutoSize = True
        Me.Label168.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label168.ForeColor = System.Drawing.Color.Silver
        Me.Label168.Location = New System.Drawing.Point(132, 236)
        Me.Label168.Name = "Label168"
        Me.Label168.Size = New System.Drawing.Size(32, 17)
        Me.Label168.TabIndex = 24
        Me.Label168.Text = "Text"
        '
        'Label155
        '
        Me.Label155.AutoSize = True
        Me.Label155.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label155.ForeColor = System.Drawing.Color.Gray
        Me.Label155.Location = New System.Drawing.Point(12, 151)
        Me.Label155.Name = "Label155"
        Me.Label155.Size = New System.Drawing.Size(86, 17)
        Me.Label155.TabIndex = 24
        Me.Label155.Text = "InterfaceType"
        '
        'Label167
        '
        Me.Label167.AutoSize = True
        Me.Label167.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label167.ForeColor = System.Drawing.Color.Gray
        Me.Label167.Location = New System.Drawing.Point(12, 236)
        Me.Label167.Name = "Label167"
        Me.Label167.Size = New System.Drawing.Size(73, 17)
        Me.Label167.TabIndex = 24
        Me.Label167.Text = "MediaType"
        '
        'Label156
        '
        Me.Label156.AutoSize = True
        Me.Label156.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label156.ForeColor = System.Drawing.Color.Gray
        Me.Label156.Location = New System.Drawing.Point(12, 98)
        Me.Label156.Name = "Label156"
        Me.Label156.Size = New System.Drawing.Size(62, 17)
        Me.Label156.TabIndex = 24
        Me.Label156.Text = "Partitions"
        '
        'Label166
        '
        Me.Label166.AutoSize = True
        Me.Label166.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label166.ForeColor = System.Drawing.Color.Silver
        Me.Label166.Location = New System.Drawing.Point(132, 124)
        Me.Label166.Name = "Label166"
        Me.Label166.Size = New System.Drawing.Size(32, 17)
        Me.Label166.TabIndex = 24
        Me.Label166.Text = "Text"
        '
        'Label157
        '
        Me.Label157.AutoSize = True
        Me.Label157.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label157.ForeColor = System.Drawing.Color.Silver
        Me.Label157.Location = New System.Drawing.Point(132, 151)
        Me.Label157.Name = "Label157"
        Me.Label157.Size = New System.Drawing.Size(32, 17)
        Me.Label157.TabIndex = 24
        Me.Label157.Text = "Text"
        '
        'Label165
        '
        Me.Label165.AutoSize = True
        Me.Label165.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label165.ForeColor = System.Drawing.Color.Silver
        Me.Label165.Location = New System.Drawing.Point(132, 177)
        Me.Label165.Name = "Label165"
        Me.Label165.Size = New System.Drawing.Size(32, 17)
        Me.Label165.TabIndex = 24
        Me.Label165.Text = "Text"
        '
        'Label158
        '
        Me.Label158.AutoSize = True
        Me.Label158.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label158.ForeColor = System.Drawing.Color.Gray
        Me.Label158.Location = New System.Drawing.Point(12, 65)
        Me.Label158.Name = "Label158"
        Me.Label158.Size = New System.Drawing.Size(58, 17)
        Me.Label158.TabIndex = 24
        Me.Label158.Text = "DeviceID"
        '
        'Label164
        '
        Me.Label164.AutoSize = True
        Me.Label164.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label164.ForeColor = System.Drawing.Color.Gray
        Me.Label164.Location = New System.Drawing.Point(12, 124)
        Me.Label164.Name = "Label164"
        Me.Label164.Size = New System.Drawing.Size(94, 17)
        Me.Label164.TabIndex = 24
        Me.Label164.Text = "BytesPerSector"
        '
        'Label159
        '
        Me.Label159.AutoSize = True
        Me.Label159.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label159.ForeColor = System.Drawing.Color.Gray
        Me.Label159.Location = New System.Drawing.Point(12, 210)
        Me.Label159.Name = "Label159"
        Me.Label159.Size = New System.Drawing.Size(109, 17)
        Me.Label159.TabIndex = 24
        Me.Label159.Text = "FirmwareRevision"
        '
        'Label163
        '
        Me.Label163.AutoSize = True
        Me.Label163.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label163.ForeColor = System.Drawing.Color.Silver
        Me.Label163.Location = New System.Drawing.Point(132, 210)
        Me.Label163.Name = "Label163"
        Me.Label163.Size = New System.Drawing.Size(32, 17)
        Me.Label163.TabIndex = 24
        Me.Label163.Text = "Text"
        '
        'Label160
        '
        Me.Label160.AutoSize = True
        Me.Label160.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label160.ForeColor = System.Drawing.Color.Silver
        Me.Label160.Location = New System.Drawing.Point(132, 98)
        Me.Label160.Name = "Label160"
        Me.Label160.Size = New System.Drawing.Size(32, 17)
        Me.Label160.TabIndex = 24
        Me.Label160.Text = "Text"
        '
        'Label162
        '
        Me.Label162.AutoSize = True
        Me.Label162.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label162.ForeColor = System.Drawing.Color.Silver
        Me.Label162.Location = New System.Drawing.Point(132, 65)
        Me.Label162.Name = "Label162"
        Me.Label162.Size = New System.Drawing.Size(32, 17)
        Me.Label162.TabIndex = 24
        Me.Label162.Text = "Text"
        '
        'Label161
        '
        Me.Label161.AutoSize = True
        Me.Label161.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label161.ForeColor = System.Drawing.Color.Gray
        Me.Label161.Location = New System.Drawing.Point(12, 177)
        Me.Label161.Name = "Label161"
        Me.Label161.Size = New System.Drawing.Size(31, 17)
        Me.Label161.TabIndex = 24
        Me.Label161.Text = "Size"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label39.Location = New System.Drawing.Point(2, 1)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(28, 12)
        Me.Label39.TabIndex = 3
        Me.Label39.Text = "Disk"
        '
        'CircularProgressBar6
        '
        Me.CircularProgressBar6.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CircularProgressBar6.AnimationSpeed = 500
        Me.CircularProgressBar6.BackColor = System.Drawing.Color.Transparent
        Me.CircularProgressBar6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CircularProgressBar6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.CircularProgressBar6.InnerColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CircularProgressBar6.InnerMargin = 2
        Me.CircularProgressBar6.InnerWidth = -1
        Me.CircularProgressBar6.Location = New System.Drawing.Point(555, 13)
        Me.CircularProgressBar6.MarqueeAnimationSpeed = 2043456654
        Me.CircularProgressBar6.Name = "CircularProgressBar6"
        Me.CircularProgressBar6.OuterColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.CircularProgressBar6.OuterMargin = -25
        Me.CircularProgressBar6.OuterWidth = 26
        Me.CircularProgressBar6.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CircularProgressBar6.ProgressWidth = 25
        Me.CircularProgressBar6.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold)
        Me.CircularProgressBar6.Size = New System.Drawing.Size(100, 100)
        Me.CircularProgressBar6.StartAngle = 270
        Me.CircularProgressBar6.SubscriptColor = System.Drawing.Color.DimGray
        Me.CircularProgressBar6.SubscriptMargin = New System.Windows.Forms.Padding(-21, 0, 0, 0)
        Me.CircularProgressBar6.SubscriptText = "Disk"
        Me.CircularProgressBar6.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBar6.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CircularProgressBar6.SuperscriptText = ""
        Me.CircularProgressBar6.TabIndex = 23
        Me.CircularProgressBar6.TextMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.CircularProgressBar6.Value = 68
        '
        'CircularProgressBar5
        '
        Me.CircularProgressBar5.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CircularProgressBar5.AnimationSpeed = 500
        Me.CircularProgressBar5.BackColor = System.Drawing.Color.Transparent
        Me.CircularProgressBar5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CircularProgressBar5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.CircularProgressBar5.InnerColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CircularProgressBar5.InnerMargin = 2
        Me.CircularProgressBar5.InnerWidth = -1
        Me.CircularProgressBar5.Location = New System.Drawing.Point(447, 13)
        Me.CircularProgressBar5.MarqueeAnimationSpeed = 2043456654
        Me.CircularProgressBar5.Name = "CircularProgressBar5"
        Me.CircularProgressBar5.OuterColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.CircularProgressBar5.OuterMargin = -25
        Me.CircularProgressBar5.OuterWidth = 26
        Me.CircularProgressBar5.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CircularProgressBar5.ProgressWidth = 25
        Me.CircularProgressBar5.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold)
        Me.CircularProgressBar5.Size = New System.Drawing.Size(100, 100)
        Me.CircularProgressBar5.StartAngle = 270
        Me.CircularProgressBar5.SubscriptColor = System.Drawing.Color.DimGray
        Me.CircularProgressBar5.SubscriptMargin = New System.Windows.Forms.Padding(-21, 0, 0, 0)
        Me.CircularProgressBar5.SubscriptText = "Disk"
        Me.CircularProgressBar5.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBar5.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CircularProgressBar5.SuperscriptText = ""
        Me.CircularProgressBar5.TabIndex = 23
        Me.CircularProgressBar5.TextMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.CircularProgressBar5.Value = 68
        '
        'Label152
        '
        Me.Label152.AutoSize = True
        Me.Label152.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label152.ForeColor = System.Drawing.Color.Silver
        Me.Label152.Location = New System.Drawing.Point(148, 357)
        Me.Label152.Name = "Label152"
        Me.Label152.Size = New System.Drawing.Size(32, 17)
        Me.Label152.TabIndex = 24
        Me.Label152.Text = "Text"
        '
        'Label151
        '
        Me.Label151.AutoSize = True
        Me.Label151.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label151.ForeColor = System.Drawing.Color.Gray
        Me.Label151.Location = New System.Drawing.Point(28, 357)
        Me.Label151.Name = "Label151"
        Me.Label151.Size = New System.Drawing.Size(73, 17)
        Me.Label151.TabIndex = 24
        Me.Label151.Text = "MediaType"
        '
        'Label144
        '
        Me.Label144.AutoSize = True
        Me.Label144.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label144.ForeColor = System.Drawing.Color.Silver
        Me.Label144.Location = New System.Drawing.Point(148, 245)
        Me.Label144.Name = "Label144"
        Me.Label144.Size = New System.Drawing.Size(32, 17)
        Me.Label144.TabIndex = 24
        Me.Label144.Text = "Text"
        '
        'Label150
        '
        Me.Label150.AutoSize = True
        Me.Label150.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label150.ForeColor = System.Drawing.Color.Silver
        Me.Label150.Location = New System.Drawing.Point(148, 298)
        Me.Label150.Name = "Label150"
        Me.Label150.Size = New System.Drawing.Size(32, 17)
        Me.Label150.TabIndex = 24
        Me.Label150.Text = "Text"
        '
        'Label143
        '
        Me.Label143.AutoSize = True
        Me.Label143.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label143.ForeColor = System.Drawing.Color.Gray
        Me.Label143.Location = New System.Drawing.Point(28, 245)
        Me.Label143.Name = "Label143"
        Me.Label143.Size = New System.Drawing.Size(94, 17)
        Me.Label143.TabIndex = 24
        Me.Label143.Text = "BytesPerSector"
        '
        'Label149
        '
        Me.Label149.AutoSize = True
        Me.Label149.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label149.ForeColor = System.Drawing.Color.Silver
        Me.Label149.Location = New System.Drawing.Point(148, 331)
        Me.Label149.Name = "Label149"
        Me.Label149.Size = New System.Drawing.Size(32, 17)
        Me.Label149.TabIndex = 24
        Me.Label149.Text = "Text"
        '
        'Label138
        '
        Me.Label138.AutoSize = True
        Me.Label138.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label138.ForeColor = System.Drawing.Color.Silver
        Me.Label138.Location = New System.Drawing.Point(148, 186)
        Me.Label138.Name = "Label138"
        Me.Label138.Size = New System.Drawing.Size(32, 17)
        Me.Label138.TabIndex = 24
        Me.Label138.Text = "Text"
        '
        'Label148
        '
        Me.Label148.AutoSize = True
        Me.Label148.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label148.ForeColor = System.Drawing.Color.Gray
        Me.Label148.Location = New System.Drawing.Point(28, 298)
        Me.Label148.Name = "Label148"
        Me.Label148.Size = New System.Drawing.Size(31, 17)
        Me.Label148.TabIndex = 24
        Me.Label148.Text = "Size"
        '
        'Label142
        '
        Me.Label142.AutoSize = True
        Me.Label142.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label142.ForeColor = System.Drawing.Color.Silver
        Me.Label142.Location = New System.Drawing.Point(148, 219)
        Me.Label142.Name = "Label142"
        Me.Label142.Size = New System.Drawing.Size(32, 17)
        Me.Label142.TabIndex = 24
        Me.Label142.Text = "Text"
        '
        'Label147
        '
        Me.Label147.AutoSize = True
        Me.Label147.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label147.ForeColor = System.Drawing.Color.Gray
        Me.Label147.Location = New System.Drawing.Point(28, 331)
        Me.Label147.Name = "Label147"
        Me.Label147.Size = New System.Drawing.Size(109, 17)
        Me.Label147.TabIndex = 24
        Me.Label147.Text = "FirmwareRevision"
        '
        'Label115
        '
        Me.Label115.AutoSize = True
        Me.Label115.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label115.ForeColor = System.Drawing.Color.Gray
        Me.Label115.Location = New System.Drawing.Point(28, 186)
        Me.Label115.Name = "Label115"
        Me.Label115.Size = New System.Drawing.Size(58, 17)
        Me.Label115.TabIndex = 24
        Me.Label115.Text = "DeviceID"
        '
        'Label146
        '
        Me.Label146.AutoSize = True
        Me.Label146.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label146.ForeColor = System.Drawing.Color.Silver
        Me.Label146.Location = New System.Drawing.Point(148, 272)
        Me.Label146.Name = "Label146"
        Me.Label146.Size = New System.Drawing.Size(32, 17)
        Me.Label146.TabIndex = 24
        Me.Label146.Text = "Text"
        '
        'Label139
        '
        Me.Label139.AutoSize = True
        Me.Label139.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label139.ForeColor = System.Drawing.Color.Gray
        Me.Label139.Location = New System.Drawing.Point(28, 219)
        Me.Label139.Name = "Label139"
        Me.Label139.Size = New System.Drawing.Size(62, 17)
        Me.Label139.TabIndex = 24
        Me.Label139.Text = "Partitions"
        '
        'Label145
        '
        Me.Label145.AutoSize = True
        Me.Label145.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label145.ForeColor = System.Drawing.Color.Gray
        Me.Label145.Location = New System.Drawing.Point(28, 272)
        Me.Label145.Name = "Label145"
        Me.Label145.Size = New System.Drawing.Size(86, 17)
        Me.Label145.TabIndex = 24
        Me.Label145.Text = "InterfaceType"
        '
        'Label114
        '
        Me.Label114.AutoSize = True
        Me.Label114.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label114.ForeColor = System.Drawing.Color.Silver
        Me.Label114.Location = New System.Drawing.Point(148, 160)
        Me.Label114.Name = "Label114"
        Me.Label114.Size = New System.Drawing.Size(32, 17)
        Me.Label114.TabIndex = 24
        Me.Label114.Text = "Text"
        '
        'Label113
        '
        Me.Label113.AutoSize = True
        Me.Label113.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!)
        Me.Label113.ForeColor = System.Drawing.Color.Gray
        Me.Label113.Location = New System.Drawing.Point(28, 160)
        Me.Label113.Name = "Label113"
        Me.Label113.Size = New System.Drawing.Size(43, 17)
        Me.Label113.TabIndex = 24
        Me.Label113.Text = "Status"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label40.Location = New System.Drawing.Point(335, 77)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(16, 17)
        Me.Label40.TabIndex = 2
        Me.Label40.Text = "X"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label41.Location = New System.Drawing.Point(335, 59)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(16, 17)
        Me.Label41.TabIndex = 2
        Me.Label41.Text = "X"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Silver
        Me.Label43.Location = New System.Drawing.Point(252, 42)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(84, 17)
        Me.Label43.TabIndex = 2
        Me.Label43.Text = "Volume label"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Silver
        Me.Label45.Location = New System.Drawing.Point(252, 59)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(81, 17)
        Me.Label45.TabIndex = 2
        Me.Label45.Text = "Drive format"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label48.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label48.Location = New System.Drawing.Point(166, 77)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(65, 21)
        Me.Label48.TabIndex = 2
        Me.Label48.Text = "XX GHz"
        '
        'Label169
        '
        Me.Label169.AutoSize = True
        Me.Label169.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label169.ForeColor = System.Drawing.Color.Silver
        Me.Label169.Location = New System.Drawing.Point(25, 132)
        Me.Label169.Name = "Label169"
        Me.Label169.Size = New System.Drawing.Size(81, 17)
        Me.Label169.TabIndex = 2
        Me.Label169.Text = "Disk Caption"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.Silver
        Me.Label50.Location = New System.Drawing.Point(252, 77)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(36, 17)
        Me.Label50.TabIndex = 2
        Me.Label50.Text = "Root"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label51.Location = New System.Drawing.Point(335, 42)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(16, 17)
        Me.Label51.TabIndex = 2
        Me.Label51.Text = "X"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Verdana", 6.75!)
        Me.Label52.ForeColor = System.Drawing.Color.Silver
        Me.Label52.Location = New System.Drawing.Point(187, 59)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(30, 12)
        Me.Label52.TabIndex = 2
        Me.Label52.Text = "Total"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Verdana", 6.75!)
        Me.Label53.ForeColor = System.Drawing.Color.Silver
        Me.Label53.Location = New System.Drawing.Point(100, 59)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(52, 12)
        Me.Label53.TabIndex = 2
        Me.Label53.Text = "Available"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label55.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label55.Location = New System.Drawing.Point(87, 77)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(65, 21)
        Me.Label55.TabIndex = 2
        Me.Label55.Text = "XX GHz"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label57.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label57.Location = New System.Drawing.Point(15, 77)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(65, 21)
        Me.Label57.TabIndex = 2
        Me.Label57.Text = "XX GHz"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Verdana", 6.75!)
        Me.Label59.ForeColor = System.Drawing.Color.Silver
        Me.Label59.Location = New System.Drawing.Point(29, 60)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(37, 12)
        Me.Label59.TabIndex = 2
        Me.Label59.Text = "In use"
        '
        'PanelNetwork
        '
        Me.PanelNetwork.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.PanelNetwork.Controls.Add(Me.Label61)
        Me.PanelNetwork.Controls.Add(Me.Label191)
        Me.PanelNetwork.Controls.Add(Me.Label190)
        Me.PanelNetwork.Controls.Add(Me.Label179)
        Me.PanelNetwork.Controls.Add(Me.Label189)
        Me.PanelNetwork.Controls.Add(Me.Label173)
        Me.PanelNetwork.Controls.Add(Me.Label178)
        Me.PanelNetwork.Controls.Add(Me.Label188)
        Me.PanelNetwork.Controls.Add(Me.Label63)
        Me.PanelNetwork.Controls.Add(Me.Label172)
        Me.PanelNetwork.Controls.Add(Me.Label67)
        Me.PanelNetwork.Controls.Add(Me.Label187)
        Me.PanelNetwork.Controls.Add(Me.CircularProgressBar3)
        Me.PanelNetwork.Controls.Add(Me.Label177)
        Me.PanelNetwork.Controls.Add(Me.Label186)
        Me.PanelNetwork.Controls.Add(Me.Label68)
        Me.PanelNetwork.Controls.Add(Me.Label185)
        Me.PanelNetwork.Controls.Add(Me.Label176)
        Me.PanelNetwork.Controls.Add(Me.Label184)
        Me.PanelNetwork.Controls.Add(Me.Label171)
        Me.PanelNetwork.Controls.Add(Me.Label183)
        Me.PanelNetwork.Controls.Add(Me.Label75)
        Me.PanelNetwork.Controls.Add(Me.Label175)
        Me.PanelNetwork.Controls.Add(Me.Label182)
        Me.PanelNetwork.Controls.Add(Me.Label69)
        Me.PanelNetwork.Controls.Add(Me.Label181)
        Me.PanelNetwork.Controls.Add(Me.Label29)
        Me.PanelNetwork.Controls.Add(Me.Label174)
        Me.PanelNetwork.Controls.Add(Me.Label180)
        Me.PanelNetwork.Controls.Add(Me.Label70)
        Me.PanelNetwork.Controls.Add(Me.Label25)
        Me.PanelNetwork.Controls.Add(Me.Label72)
        Me.PanelNetwork.Controls.Add(Me.Label73)
        Me.PanelNetwork.Controls.Add(Me.Label77)
        Me.PanelNetwork.Controls.Add(Me.Label78)
        Me.PanelNetwork.Location = New System.Drawing.Point(5, 393)
        Me.PanelNetwork.MaximumSize = New System.Drawing.Size(676, 515)
        Me.PanelNetwork.MinimumSize = New System.Drawing.Size(339, 124)
        Me.PanelNetwork.Name = "PanelNetwork"
        Me.PanelNetwork.Size = New System.Drawing.Size(339, 124)
        Me.PanelNetwork.TabIndex = 24
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label61.Location = New System.Drawing.Point(2, 1)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(48, 12)
        Me.Label61.TabIndex = 3
        Me.Label61.Text = "Network"
        '
        'Label191
        '
        Me.Label191.AutoSize = True
        Me.Label191.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label191.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label191.Location = New System.Drawing.Point(157, 341)
        Me.Label191.Name = "Label191"
        Me.Label191.Size = New System.Drawing.Size(46, 17)
        Me.Label191.TabIndex = 2
        Me.Label191.Text = "Label2"
        '
        'Label190
        '
        Me.Label190.AutoSize = True
        Me.Label190.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label190.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label190.Location = New System.Drawing.Point(157, 287)
        Me.Label190.Name = "Label190"
        Me.Label190.Size = New System.Drawing.Size(46, 17)
        Me.Label190.TabIndex = 2
        Me.Label190.Text = "Label2"
        '
        'Label179
        '
        Me.Label179.AutoSize = True
        Me.Label179.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label179.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label179.Location = New System.Drawing.Point(157, 236)
        Me.Label179.Name = "Label179"
        Me.Label179.Size = New System.Drawing.Size(46, 17)
        Me.Label179.TabIndex = 2
        Me.Label179.Text = "Label2"
        '
        'Label189
        '
        Me.Label189.AutoSize = True
        Me.Label189.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label189.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label189.Location = New System.Drawing.Point(157, 323)
        Me.Label189.Name = "Label189"
        Me.Label189.Size = New System.Drawing.Size(46, 17)
        Me.Label189.TabIndex = 2
        Me.Label189.Text = "Label2"
        '
        'Label173
        '
        Me.Label173.AutoSize = True
        Me.Label173.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label173.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label173.Location = New System.Drawing.Point(157, 182)
        Me.Label173.Name = "Label173"
        Me.Label173.Size = New System.Drawing.Size(46, 17)
        Me.Label173.TabIndex = 2
        Me.Label173.Text = "Label2"
        '
        'Label178
        '
        Me.Label178.AutoSize = True
        Me.Label178.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label178.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label178.Location = New System.Drawing.Point(157, 218)
        Me.Label178.Name = "Label178"
        Me.Label178.Size = New System.Drawing.Size(46, 17)
        Me.Label178.TabIndex = 2
        Me.Label178.Text = "Label2"
        '
        'Label188
        '
        Me.Label188.AutoSize = True
        Me.Label188.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label188.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label188.Location = New System.Drawing.Point(157, 269)
        Me.Label188.Name = "Label188"
        Me.Label188.Size = New System.Drawing.Size(46, 17)
        Me.Label188.TabIndex = 2
        Me.Label188.Text = "Label2"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label63.Location = New System.Drawing.Point(176, 77)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(46, 17)
        Me.Label63.TabIndex = 2
        Me.Label63.Text = "Label2"
        '
        'Label172
        '
        Me.Label172.AutoSize = True
        Me.Label172.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label172.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label172.Location = New System.Drawing.Point(157, 164)
        Me.Label172.Name = "Label172"
        Me.Label172.Size = New System.Drawing.Size(46, 17)
        Me.Label172.TabIndex = 2
        Me.Label172.Text = "Label2"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label67.Location = New System.Drawing.Point(176, 59)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(46, 17)
        Me.Label67.TabIndex = 2
        Me.Label67.Text = "Label2"
        '
        'Label187
        '
        Me.Label187.AutoSize = True
        Me.Label187.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label187.ForeColor = System.Drawing.Color.Silver
        Me.Label187.Location = New System.Drawing.Point(28, 306)
        Me.Label187.Name = "Label187"
        Me.Label187.Size = New System.Drawing.Size(45, 17)
        Me.Label187.TabIndex = 2
        Me.Label187.Text = "Speed"
        '
        'CircularProgressBar3
        '
        Me.CircularProgressBar3.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CircularProgressBar3.AnimationSpeed = 500
        Me.CircularProgressBar3.BackColor = System.Drawing.Color.Transparent
        Me.CircularProgressBar3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CircularProgressBar3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.CircularProgressBar3.InnerColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CircularProgressBar3.InnerMargin = 2
        Me.CircularProgressBar3.InnerWidth = -1
        Me.CircularProgressBar3.Location = New System.Drawing.Point(230, 12)
        Me.CircularProgressBar3.MarqueeAnimationSpeed = 2000
        Me.CircularProgressBar3.Name = "CircularProgressBar3"
        Me.CircularProgressBar3.OuterColor = System.Drawing.SystemColors.HotTrack
        Me.CircularProgressBar3.OuterMargin = -25
        Me.CircularProgressBar3.OuterWidth = 26
        Me.CircularProgressBar3.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CircularProgressBar3.ProgressWidth = 25
        Me.CircularProgressBar3.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold)
        Me.CircularProgressBar3.Size = New System.Drawing.Size(100, 100)
        Me.CircularProgressBar3.StartAngle = 270
        Me.CircularProgressBar3.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.CircularProgressBar3.SubscriptColor = System.Drawing.Color.DimGray
        Me.CircularProgressBar3.SubscriptMargin = New System.Windows.Forms.Padding(-23, 0, 0, 0)
        Me.CircularProgressBar3.SubscriptText = "Disk"
        Me.CircularProgressBar3.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBar3.SuperscriptMargin = New System.Windows.Forms.Padding(0)
        Me.CircularProgressBar3.SuperscriptText = ""
        Me.CircularProgressBar3.TabIndex = 23
        Me.CircularProgressBar3.TextMargin = New System.Windows.Forms.Padding(0)
        Me.CircularProgressBar3.Value = 68
        '
        'Label177
        '
        Me.Label177.AutoSize = True
        Me.Label177.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label177.ForeColor = System.Drawing.Color.Silver
        Me.Label177.Location = New System.Drawing.Point(28, 201)
        Me.Label177.Name = "Label177"
        Me.Label177.Size = New System.Drawing.Size(45, 17)
        Me.Label177.TabIndex = 2
        Me.Label177.Text = "Speed"
        '
        'Label186
        '
        Me.Label186.AutoSize = True
        Me.Label186.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label186.ForeColor = System.Drawing.Color.Silver
        Me.Label186.Location = New System.Drawing.Point(28, 323)
        Me.Label186.Name = "Label186"
        Me.Label186.Size = New System.Drawing.Size(46, 17)
        Me.Label186.TabIndex = 2
        Me.Label186.Text = "Label2"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label68.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label68.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label68.Location = New System.Drawing.Point(20, 13)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(57, 21)
        Me.Label68.TabIndex = 22
        Me.Label68.Text = "Usage"
        '
        'Label185
        '
        Me.Label185.AutoSize = True
        Me.Label185.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label185.ForeColor = System.Drawing.Color.Silver
        Me.Label185.Location = New System.Drawing.Point(28, 252)
        Me.Label185.Name = "Label185"
        Me.Label185.Size = New System.Drawing.Size(45, 17)
        Me.Label185.TabIndex = 2
        Me.Label185.Text = "Speed"
        '
        'Label176
        '
        Me.Label176.AutoSize = True
        Me.Label176.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label176.ForeColor = System.Drawing.Color.Silver
        Me.Label176.Location = New System.Drawing.Point(28, 218)
        Me.Label176.Name = "Label176"
        Me.Label176.Size = New System.Drawing.Size(46, 17)
        Me.Label176.TabIndex = 2
        Me.Label176.Text = "Label2"
        '
        'Label184
        '
        Me.Label184.AutoSize = True
        Me.Label184.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label184.ForeColor = System.Drawing.Color.Silver
        Me.Label184.Location = New System.Drawing.Point(28, 269)
        Me.Label184.Name = "Label184"
        Me.Label184.Size = New System.Drawing.Size(46, 17)
        Me.Label184.TabIndex = 2
        Me.Label184.Text = "Label2"
        '
        'Label171
        '
        Me.Label171.AutoSize = True
        Me.Label171.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label171.ForeColor = System.Drawing.Color.Silver
        Me.Label171.Location = New System.Drawing.Point(28, 147)
        Me.Label171.Name = "Label171"
        Me.Label171.Size = New System.Drawing.Size(45, 17)
        Me.Label171.TabIndex = 2
        Me.Label171.Text = "Speed"
        '
        'Label183
        '
        Me.Label183.AutoSize = True
        Me.Label183.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label183.ForeColor = System.Drawing.Color.Silver
        Me.Label183.Location = New System.Drawing.Point(28, 341)
        Me.Label183.Name = "Label183"
        Me.Label183.Size = New System.Drawing.Size(46, 17)
        Me.Label183.TabIndex = 2
        Me.Label183.Text = "Label2"
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.ForeColor = System.Drawing.Color.Silver
        Me.Label75.Location = New System.Drawing.Point(28, 164)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(46, 17)
        Me.Label75.TabIndex = 2
        Me.Label75.Text = "Label2"
        '
        'Label175
        '
        Me.Label175.AutoSize = True
        Me.Label175.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label175.ForeColor = System.Drawing.Color.Silver
        Me.Label175.Location = New System.Drawing.Point(28, 236)
        Me.Label175.Name = "Label175"
        Me.Label175.Size = New System.Drawing.Size(46, 17)
        Me.Label175.TabIndex = 2
        Me.Label175.Text = "Label2"
        '
        'Label182
        '
        Me.Label182.AutoSize = True
        Me.Label182.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label182.ForeColor = System.Drawing.Color.Silver
        Me.Label182.Location = New System.Drawing.Point(28, 287)
        Me.Label182.Name = "Label182"
        Me.Label182.Size = New System.Drawing.Size(46, 17)
        Me.Label182.TabIndex = 2
        Me.Label182.Text = "Label2"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.ForeColor = System.Drawing.Color.Silver
        Me.Label69.Location = New System.Drawing.Point(125, 42)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(45, 17)
        Me.Label69.TabIndex = 2
        Me.Label69.Text = "Speed"
        '
        'Label181
        '
        Me.Label181.AutoSize = True
        Me.Label181.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label181.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label181.Location = New System.Drawing.Point(157, 306)
        Me.Label181.Name = "Label181"
        Me.Label181.Size = New System.Drawing.Size(46, 17)
        Me.Label181.TabIndex = 2
        Me.Label181.Text = "Label2"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Silver
        Me.Label29.Location = New System.Drawing.Point(28, 182)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(46, 17)
        Me.Label29.TabIndex = 2
        Me.Label29.Text = "Label2"
        '
        'Label174
        '
        Me.Label174.AutoSize = True
        Me.Label174.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label174.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label174.Location = New System.Drawing.Point(157, 201)
        Me.Label174.Name = "Label174"
        Me.Label174.Size = New System.Drawing.Size(46, 17)
        Me.Label174.TabIndex = 2
        Me.Label174.Text = "Label2"
        '
        'Label180
        '
        Me.Label180.AutoSize = True
        Me.Label180.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label180.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label180.Location = New System.Drawing.Point(157, 252)
        Me.Label180.Name = "Label180"
        Me.Label180.Size = New System.Drawing.Size(46, 17)
        Me.Label180.TabIndex = 2
        Me.Label180.Text = "Label2"
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.ForeColor = System.Drawing.Color.Silver
        Me.Label70.Location = New System.Drawing.Point(125, 59)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(46, 17)
        Me.Label70.TabIndex = 2
        Me.Label70.Text = "Label2"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label25.Location = New System.Drawing.Point(157, 147)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(46, 17)
        Me.Label25.TabIndex = 2
        Me.Label25.Text = "Label2"
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.ForeColor = System.Drawing.Color.Silver
        Me.Label72.Location = New System.Drawing.Point(125, 77)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(46, 17)
        Me.Label72.TabIndex = 2
        Me.Label72.Text = "Label2"
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label73.Location = New System.Drawing.Point(176, 42)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(46, 17)
        Me.Label73.TabIndex = 2
        Me.Label73.Text = "Label2"
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label77.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label77.Location = New System.Drawing.Point(15, 77)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(65, 21)
        Me.Label77.TabIndex = 2
        Me.Label77.Text = "XX GHz"
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Font = New System.Drawing.Font("Verdana", 6.75!)
        Me.Label78.ForeColor = System.Drawing.Color.Silver
        Me.Label78.Location = New System.Drawing.Point(29, 60)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(37, 12)
        Me.Label78.TabIndex = 2
        Me.Label78.Text = "In use"
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label80.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label80.Location = New System.Drawing.Point(66, 62)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(51, 21)
        Me.Label80.TabIndex = 2
        Me.Label80.Text = "Good"
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label81.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label81.Location = New System.Drawing.Point(257, 61)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(51, 21)
        Me.Label81.TabIndex = 2
        Me.Label81.Text = "Good"
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label82.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label82.Location = New System.Drawing.Point(476, 62)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(51, 21)
        Me.Label82.TabIndex = 2
        Me.Label82.Text = "Good"
        '
        'Timer_ExpandLiveStatus
        '
        Me.Timer_ExpandLiveStatus.Interval = 10
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "focus.gif")
        Me.ImageList1.Images.SetKeyName(1, "zoom.gif")
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = Global.Script_Agent.My.Resources.Resources.green2
        Me.PictureBox11.Location = New System.Drawing.Point(568, 61)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox11.TabIndex = 24
        Me.PictureBox11.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Script_Agent.My.Resources.Resources.green2
        Me.PictureBox2.Location = New System.Drawing.Point(368, 62)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Script_Agent.My.Resources.Resources.green2
        Me.PictureBox1.Location = New System.Drawing.Point(179, 61)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1940, 1051)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Pnl_User)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PanelLiveStats)
        Me.Controls.Add(Me.Pnl_Windows)
        Me.Controls.Add(Me.Pnl_Processes)
        Me.Controls.Add(Me.Pnl_Network)
        Me.Controls.Add(Me.Pnl_Computer)
        Me.Controls.Add(Me.Label82)
        Me.Controls.Add(Me.Label81)
        Me.Controls.Add(Me.Label80)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Home"
        Me.Text = "Home"
        Me.Pnl_Windows.ResumeLayout(False)
        Me.Pnl_Windows.PerformLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_Computer.ResumeLayout(False)
        Me.Pnl_Computer.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_Network.ResumeLayout(False)
        Me.Pnl_Network.PerformLayout()
        CType(Me.Chart_Network, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox22, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_Processes.ResumeLayout(False)
        Me.Pnl_Processes.PerformLayout()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox26, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_User.ResumeLayout(False)
        Me.Pnl_User.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox36, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLiveStats.ResumeLayout(False)
        Me.PanelCPU.ResumeLayout(False)
        Me.PanelCPU.PerformLayout()
        Me.PanelRam.ResumeLayout(False)
        Me.PanelRam.PerformLayout()
        Me.PanelGpu.ResumeLayout(False)
        Me.PanelGpu.PerformLayout()
        Me.PanelDisk.ResumeLayout(False)
        Me.PanelDisk.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelNetwork.ResumeLayout(False)
        Me.PanelNetwork.PerformLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_CPU As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Lbl_RAM As Label
    Friend WithEvents Lbl_Disk As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Lbl_OS As Label
    Friend WithEvents Lbl_GPU_WTF As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Pnl_Windows As Panel
    Friend WithEvents Pnl_Computer As Panel
    Friend WithEvents Lbl_PC As Label
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lbl_os_build As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lbl_os_buildasadfa As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Btn_Windows As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Pnl_Network As Panel
    Friend WithEvents Lbl_Network As Label
    Friend WithEvents PictureBox18 As PictureBox
    Friend WithEvents PictureBox19 As PictureBox
    Friend WithEvents Label24 As Label
    Friend WithEvents PictureBox20 As PictureBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents PictureBox22 As PictureBox
    Friend WithEvents Pnl_Processes As Panel
    Friend WithEvents PictureBox23 As PictureBox
    Friend WithEvents Lbl_Process As Label
    Friend WithEvents PictureBox26 As PictureBox
    Friend WithEvents Label44 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Pnl_User As Panel
    Friend WithEvents Lbl_User As Label
    Friend WithEvents PictureBox34 As PictureBox
    Friend WithEvents PictureBox35 As PictureBox
    Friend WithEvents Label54 As Label
    Friend WithEvents PictureBox36 As PictureBox
    Friend WithEvents Label56 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents Label64 As Label
    Friend WithEvents Label65 As Label
    Friend WithEvents Label66 As Label
    Friend WithEvents PictureBox38 As PictureBox
    Friend WithEvents ImageList_MainIcons As ImageList
    Friend WithEvents ImageList_ExpandBtn As ImageList
    Friend WithEvents Btn_Computer As Button
    Friend WithEvents Btn_Network As Button
    Friend WithEvents Btn_Processes As Button
    Friend WithEvents Btn_User As Button
    Friend WithEvents Timer_Windows As Timer
    Friend WithEvents Timer_Computer As Timer
    Friend WithEvents Timer_Network As Timer
    Friend WithEvents Timer_Processes As Timer
    Friend WithEvents Timer_User As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Chart_Network As DataVisualization.Charting.Chart
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PanelLiveStats As Panel
    Friend WithEvents CircularProgressBar1 As CircularProgressBar.CircularProgressBar
    Friend WithEvents CircularProgressBar3 As CircularProgressBar.CircularProgressBar
    Friend WithEvents CircularProgressBar2 As CircularProgressBar.CircularProgressBar
    Friend WithEvents CircularProgressBar4 As CircularProgressBar.CircularProgressBar
    Friend WithEvents CircularProgressBar5 As CircularProgressBar.CircularProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelCPU As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Lbl_UpTime As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PanelRam As Panel
    Friend WithEvents CircularProgressBarRam2 As CircularProgressBar.CircularProgressBar
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents LabelCpuClockSpeed As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Lbl_TotalRam As Label
    Friend WithEvents Lbl_Available As Label
    Friend WithEvents Lbl_RamInUse As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents PanelDisk As Panel
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents Label57 As Label
    Friend WithEvents Label59 As Label
    Friend WithEvents PanelNetwork As Panel
    Friend WithEvents Label63 As Label
    Friend WithEvents Label67 As Label
    Friend WithEvents Label68 As Label
    Friend WithEvents Label69 As Label
    Friend WithEvents Label70 As Label
    Friend WithEvents Label72 As Label
    Friend WithEvents Label73 As Label
    Friend WithEvents Label77 As Label
    Friend WithEvents Label78 As Label
    Friend WithEvents Label79 As Label
    Friend WithEvents Label80 As Label
    Friend WithEvents Label81 As Label
    Friend WithEvents Label82 As Label
    Friend WithEvents PanelGpu As Panel
    Friend WithEvents CircularProgressBar7 As CircularProgressBar.CircularProgressBar
    Friend WithEvents Label92 As Label
    Friend WithEvents Lbl_GpuTotalMemory As Label
    Friend WithEvents LblGpuUsage As Label
    Friend WithEvents Label95 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents Label74 As Label
    Friend WithEvents LabelGpuMemoryUsed As Label
    Friend WithEvents Label71 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Timer_ExpandLiveStatus As Timer
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Label99 As Label
    Friend WithEvents Label98 As Label
    Friend WithEvents Label89 As Label
    Friend WithEvents Label112 As Label
    Friend WithEvents Label97 As Label
    Friend WithEvents Label88 As Label
    Friend WithEvents Label110 As Label
    Friend WithEvents Label96 As Label
    Friend WithEvents Label109 As Label
    Friend WithEvents Label85 As Label
    Friend WithEvents Label108 As Label
    Friend WithEvents Label94 As Label
    Friend WithEvents Label107 As Label
    Friend WithEvents Label87 As Label
    Friend WithEvents Label106 As Label
    Friend WithEvents Label93 As Label
    Friend WithEvents Label105 As Label
    Friend WithEvents Label84 As Label
    Friend WithEvents Label104 As Label
    Friend WithEvents Label91 As Label
    Friend WithEvents Label103 As Label
    Friend WithEvents Label86 As Label
    Friend WithEvents Label102 As Label
    Friend WithEvents Label101 As Label
    Friend WithEvents Label90 As Label
    Friend WithEvents Label100 As Label
    Friend WithEvents Label83 As Label
    Friend WithEvents Label76 As Label
    Friend WithEvents Label141 As Label
    Friend WithEvents Label140 As Label
    Friend WithEvents Label121 As Label
    Friend WithEvents Label124 As Label
    Friend WithEvents Label123 As Label
    Friend WithEvents Label125 As Label
    Friend WithEvents Label122 As Label
    Friend WithEvents Label137 As Label
    Friend WithEvents Label126 As Label
    Friend WithEvents Label127 As Label
    Friend WithEvents Label136 As Label
    Friend WithEvents Label120 As Label
    Friend WithEvents Label128 As Label
    Friend WithEvents Label135 As Label
    Friend WithEvents Label119 As Label
    Friend WithEvents Label129 As Label
    Friend WithEvents Label134 As Label
    Friend WithEvents Label118 As Label
    Friend WithEvents Label130 As Label
    Friend WithEvents Label133 As Label
    Friend WithEvents Label117 As Label
    Friend WithEvents Label131 As Label
    Friend WithEvents Label132 As Label
    Friend WithEvents Label116 As Label
    Friend WithEvents Label111 As Label
    Friend WithEvents Label152 As Label
    Friend WithEvents Label151 As Label
    Friend WithEvents Label144 As Label
    Friend WithEvents Label150 As Label
    Friend WithEvents Label143 As Label
    Friend WithEvents Label149 As Label
    Friend WithEvents Label138 As Label
    Friend WithEvents Label148 As Label
    Friend WithEvents Label142 As Label
    Friend WithEvents Label147 As Label
    Friend WithEvents Label115 As Label
    Friend WithEvents Label146 As Label
    Friend WithEvents Label139 As Label
    Friend WithEvents Label145 As Label
    Friend WithEvents Label114 As Label
    Friend WithEvents Label113 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label170 As Label
    Friend WithEvents Label169 As Label
    Friend WithEvents Label154 As Label
    Friend WithEvents Label153 As Label
    Friend WithEvents Label168 As Label
    Friend WithEvents Label155 As Label
    Friend WithEvents Label167 As Label
    Friend WithEvents Label156 As Label
    Friend WithEvents Label166 As Label
    Friend WithEvents Label157 As Label
    Friend WithEvents Label165 As Label
    Friend WithEvents Label158 As Label
    Friend WithEvents Label164 As Label
    Friend WithEvents Label159 As Label
    Friend WithEvents Label163 As Label
    Friend WithEvents Label160 As Label
    Friend WithEvents Label162 As Label
    Friend WithEvents Label161 As Label
    Friend WithEvents CircularProgressBar6 As CircularProgressBar.CircularProgressBar
    Friend WithEvents Label191 As Label
    Friend WithEvents Label190 As Label
    Friend WithEvents Label179 As Label
    Friend WithEvents Label189 As Label
    Friend WithEvents Label173 As Label
    Friend WithEvents Label178 As Label
    Friend WithEvents Label188 As Label
    Friend WithEvents Label172 As Label
    Friend WithEvents Label187 As Label
    Friend WithEvents Label177 As Label
    Friend WithEvents Label186 As Label
    Friend WithEvents Label185 As Label
    Friend WithEvents Label176 As Label
    Friend WithEvents Label184 As Label
    Friend WithEvents Label171 As Label
    Friend WithEvents Label183 As Label
    Friend WithEvents Label75 As Label
    Friend WithEvents Label175 As Label
    Friend WithEvents Label182 As Label
    Friend WithEvents Label181 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label174 As Label
    Friend WithEvents Label180 As Label
    Friend WithEvents Label25 As Label
End Class
