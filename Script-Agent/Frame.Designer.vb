<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frame))
        Me.ImageList_ExpandLeftMenuBtn = New System.Windows.Forms.ImageList(Me.components)
        Me.PnlMenu = New System.Windows.Forms.Panel()
        Me.Btn_Browser = New System.Windows.Forms.Button()
        Me.ImgList_MenuLeft = New System.Windows.Forms.ImageList(Me.components)
        Me.Btn_VirusScan = New System.Windows.Forms.Button()
        Me.Btn_Commands = New System.Windows.Forms.Button()
        Me.Btn_Ticket = New System.Windows.Forms.Button()
        Me.ImageList_Buttons = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList_Expand = New System.Windows.Forms.ImageList(Me.components)
        Me.Lbl_TopLabel = New System.Windows.Forms.Label()
        Me.ImageList_FrameControl = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList_CommandButton = New System.Windows.Forms.ImageList(Me.components)
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.Btn_home = New System.Windows.Forms.Button()
        Me.Btn_Settings = New System.Windows.Forms.Button()
        Me.ExpandLeftMenu = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_Exit = New System.Windows.Forms.Button()
        Me.Btn_Minimize = New System.Windows.Forms.Button()
        Me.PanelExpandNotifications = New System.Windows.Forms.Panel()
        Me.Btn_NotifyOptions = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ExpandNotifications = New System.Windows.Forms.Timer(Me.components)
        Me.PanelExpandAccount = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ExpandAccount = New System.Windows.Forms.Timer(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ContextMenuNotify = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBoxSettings = New System.Windows.Forms.PictureBox()
        Me.PictureBoxAccount = New System.Windows.Forms.PictureBox()
        Me.PB_Logo = New System.Windows.Forms.PictureBox()
        Me.PictureBoxNotifications = New System.Windows.Forms.PictureBox()
        Me.PixBox_Top = New System.Windows.Forms.PictureBox()
        Me.Lbl_NotifyCount = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PnlMenu.SuspendLayout()
        Me.PnlMain.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelExpandNotifications.SuspendLayout()
        Me.PanelExpandAccount.SuspendLayout()
        Me.ContextMenuNotify.SuspendLayout()
        CType(Me.PictureBoxSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxNotifications, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PixBox_Top, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList_ExpandLeftMenuBtn
        '
        Me.ImageList_ExpandLeftMenuBtn.ImageStream = CType(resources.GetObject("ImageList_ExpandLeftMenuBtn.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_ExpandLeftMenuBtn.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_ExpandLeftMenuBtn.Images.SetKeyName(0, "menu (3).png")
        Me.ImageList_ExpandLeftMenuBtn.Images.SetKeyName(1, "open-menu.png")
        '
        'PnlMenu
        '
        Me.PnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.PnlMenu.Controls.Add(Me.Btn_Browser)
        Me.PnlMenu.Controls.Add(Me.Btn_VirusScan)
        Me.PnlMenu.Controls.Add(Me.Btn_Commands)
        Me.PnlMenu.Controls.Add(Me.Btn_Ticket)
        Me.PnlMenu.Location = New System.Drawing.Point(0, 71)
        Me.PnlMenu.MaximumSize = New System.Drawing.Size(169, 663)
        Me.PnlMenu.MinimumSize = New System.Drawing.Size(64, 663)
        Me.PnlMenu.Name = "PnlMenu"
        Me.PnlMenu.Size = New System.Drawing.Size(64, 663)
        Me.PnlMenu.TabIndex = 19
        '
        'Btn_Browser
        '
        Me.Btn_Browser.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Btn_Browser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Browser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Btn_Browser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.Btn_Browser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.Btn_Browser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Browser.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Browser.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Btn_Browser.ImageIndex = 7
        Me.Btn_Browser.ImageList = Me.ImgList_MenuLeft
        Me.Btn_Browser.Location = New System.Drawing.Point(4, 333)
        Me.Btn_Browser.MaximumSize = New System.Drawing.Size(162, 47)
        Me.Btn_Browser.MinimumSize = New System.Drawing.Size(57, 47)
        Me.Btn_Browser.Name = "Btn_Browser"
        Me.Btn_Browser.Size = New System.Drawing.Size(57, 47)
        Me.Btn_Browser.TabIndex = 22
        Me.Btn_Browser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Browser.UseVisualStyleBackColor = False
        '
        'ImgList_MenuLeft
        '
        Me.ImgList_MenuLeft.ImageStream = CType(resources.GetObject("ImgList_MenuLeft.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgList_MenuLeft.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgList_MenuLeft.Images.SetKeyName(0, "help.png")
        Me.ImgList_MenuLeft.Images.SetKeyName(1, "help-desk.png")
        Me.ImgList_MenuLeft.Images.SetKeyName(2, "coding (1).png")
        Me.ImgList_MenuLeft.Images.SetKeyName(3, "setting.png")
        Me.ImgList_MenuLeft.Images.SetKeyName(4, "Load-Animation2.gif")
        Me.ImgList_MenuLeft.Images.SetKeyName(5, "search.png")
        Me.ImgList_MenuLeft.Images.SetKeyName(6, "help-desk (1).png")
        Me.ImgList_MenuLeft.Images.SetKeyName(7, "browser.png")
        '
        'Btn_VirusScan
        '
        Me.Btn_VirusScan.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Btn_VirusScan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_VirusScan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Btn_VirusScan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.Btn_VirusScan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.Btn_VirusScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_VirusScan.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_VirusScan.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Btn_VirusScan.ImageIndex = 5
        Me.Btn_VirusScan.ImageList = Me.ImgList_MenuLeft
        Me.Btn_VirusScan.Location = New System.Drawing.Point(3, 110)
        Me.Btn_VirusScan.MaximumSize = New System.Drawing.Size(162, 47)
        Me.Btn_VirusScan.MinimumSize = New System.Drawing.Size(57, 47)
        Me.Btn_VirusScan.Name = "Btn_VirusScan"
        Me.Btn_VirusScan.Size = New System.Drawing.Size(57, 47)
        Me.Btn_VirusScan.TabIndex = 22
        Me.Btn_VirusScan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_VirusScan.UseVisualStyleBackColor = False
        '
        'Btn_Commands
        '
        Me.Btn_Commands.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Btn_Commands.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Commands.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Btn_Commands.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.Btn_Commands.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.Btn_Commands.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Commands.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Commands.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Btn_Commands.ImageIndex = 2
        Me.Btn_Commands.ImageList = Me.ImgList_MenuLeft
        Me.Btn_Commands.Location = New System.Drawing.Point(3, 57)
        Me.Btn_Commands.MaximumSize = New System.Drawing.Size(162, 47)
        Me.Btn_Commands.MinimumSize = New System.Drawing.Size(57, 47)
        Me.Btn_Commands.Name = "Btn_Commands"
        Me.Btn_Commands.Size = New System.Drawing.Size(57, 47)
        Me.Btn_Commands.TabIndex = 22
        Me.Btn_Commands.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Commands.UseVisualStyleBackColor = False
        '
        'Btn_Ticket
        '
        Me.Btn_Ticket.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Btn_Ticket.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Ticket.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Btn_Ticket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.Btn_Ticket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.Btn_Ticket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Ticket.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Ticket.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Btn_Ticket.ImageIndex = 6
        Me.Btn_Ticket.ImageList = Me.ImgList_MenuLeft
        Me.Btn_Ticket.Location = New System.Drawing.Point(3, 4)
        Me.Btn_Ticket.MaximumSize = New System.Drawing.Size(162, 47)
        Me.Btn_Ticket.MinimumSize = New System.Drawing.Size(57, 47)
        Me.Btn_Ticket.Name = "Btn_Ticket"
        Me.Btn_Ticket.Size = New System.Drawing.Size(57, 47)
        Me.Btn_Ticket.TabIndex = 22
        Me.Btn_Ticket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Ticket.UseVisualStyleBackColor = False
        '
        'ImageList_Buttons
        '
        Me.ImageList_Buttons.ImageStream = CType(resources.GetObject("ImageList_Buttons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_Buttons.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_Buttons.Images.SetKeyName(0, "web-search-engine.png")
        Me.ImageList_Buttons.Images.SetKeyName(1, "office (2).png")
        Me.ImageList_Buttons.Images.SetKeyName(2, "secure-data.png")
        Me.ImageList_Buttons.Images.SetKeyName(3, "printer.png")
        Me.ImageList_Buttons.Images.SetKeyName(4, "coding.png")
        Me.ImageList_Buttons.Images.SetKeyName(5, "shield.png")
        Me.ImageList_Buttons.Images.SetKeyName(6, "antivirus.png")
        Me.ImageList_Buttons.Images.SetKeyName(7, "windows (2).png")
        Me.ImageList_Buttons.Images.SetKeyName(8, "approved.png")
        Me.ImageList_Buttons.Images.SetKeyName(9, "privacy.png")
        Me.ImageList_Buttons.Images.SetKeyName(10, "sync.png")
        Me.ImageList_Buttons.Images.SetKeyName(11, "no-internet.png")
        Me.ImageList_Buttons.Images.SetKeyName(12, "information.png")
        '
        'ImageList_Expand
        '
        Me.ImageList_Expand.ImageStream = CType(resources.GetObject("ImageList_Expand.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_Expand.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_Expand.Images.SetKeyName(0, "left-chevron.png")
        Me.ImageList_Expand.Images.SetKeyName(1, "right-chevron.png")
        '
        'Lbl_TopLabel
        '
        Me.Lbl_TopLabel.AutoSize = True
        Me.Lbl_TopLabel.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_TopLabel.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Lbl_TopLabel.Location = New System.Drawing.Point(121, 40)
        Me.Lbl_TopLabel.Name = "Lbl_TopLabel"
        Me.Lbl_TopLabel.Size = New System.Drawing.Size(81, 21)
        Me.Lbl_TopLabel.TabIndex = 14
        Me.Lbl_TopLabel.Text = "Windows"
        '
        'ImageList_FrameControl
        '
        Me.ImageList_FrameControl.ImageStream = CType(resources.GetObject("ImageList_FrameControl.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_FrameControl.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_FrameControl.Images.SetKeyName(0, "minus.png")
        Me.ImageList_FrameControl.Images.SetKeyName(1, "close.png")
        Me.ImageList_FrameControl.Images.SetKeyName(2, "cancel.png")
        Me.ImageList_FrameControl.Images.SetKeyName(3, "remove.png")
        '
        'ImageList_CommandButton
        '
        Me.ImageList_CommandButton.ImageStream = CType(resources.GetObject("ImageList_CommandButton.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_CommandButton.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_CommandButton.Images.SetKeyName(0, "success.png")
        Me.ImageList_CommandButton.Images.SetKeyName(1, "fail.png")
        '
        'PnlMain
        '
        Me.PnlMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.PnlMain.Controls.Add(Me.Btn_home)
        Me.PnlMain.Controls.Add(Me.Btn_Settings)
        Me.PnlMain.Location = New System.Drawing.Point(67, 71)
        Me.PnlMain.MaximumSize = New System.Drawing.Size(686, 663)
        Me.PnlMain.MinimumSize = New System.Drawing.Size(686, 663)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(686, 663)
        Me.PnlMain.TabIndex = 31
        '
        'Btn_home
        '
        Me.Btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_home.ImageIndex = 12
        Me.Btn_home.ImageList = Me.ImageList_Buttons
        Me.Btn_home.Location = New System.Drawing.Point(108, 469)
        Me.Btn_home.Name = "Btn_home"
        Me.Btn_home.Size = New System.Drawing.Size(61, 40)
        Me.Btn_home.TabIndex = 0
        Me.Btn_home.Text = "Home"
        Me.Btn_home.UseVisualStyleBackColor = True
        '
        'Btn_Settings
        '
        Me.Btn_Settings.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Btn_Settings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Settings.FlatAppearance.BorderSize = 0
        Me.Btn_Settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.Btn_Settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.Btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Settings.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Settings.ImageIndex = 4
        Me.Btn_Settings.ImageList = Me.ImgList_MenuLeft
        Me.Btn_Settings.Location = New System.Drawing.Point(41, 469)
        Me.Btn_Settings.Name = "Btn_Settings"
        Me.Btn_Settings.Size = New System.Drawing.Size(61, 40)
        Me.Btn_Settings.TabIndex = 22
        Me.Btn_Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Settings.UseVisualStyleBackColor = False
        '
        'ExpandLeftMenu
        '
        Me.ExpandLeftMenu.Interval = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 16)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "OptimumDesk"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Btn_Exit)
        Me.Panel1.Controls.Add(Me.Btn_Minimize)
        Me.Panel1.Location = New System.Drawing.Point(67, -1)
        Me.Panel1.MaximumSize = New System.Drawing.Size(794, 36)
        Me.Panel1.MinimumSize = New System.Drawing.Size(686, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(794, 36)
        Me.Panel1.TabIndex = 23
        '
        'Btn_Exit
        '
        Me.Btn_Exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Btn_Exit.FlatAppearance.BorderSize = 0
        Me.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Exit.ImageIndex = 2
        Me.Btn_Exit.ImageList = Me.ImageList_FrameControl
        Me.Btn_Exit.Location = New System.Drawing.Point(643, 3)
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.Size = New System.Drawing.Size(37, 30)
        Me.Btn_Exit.TabIndex = 15
        Me.Btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Btn_Exit.UseVisualStyleBackColor = False
        '
        'Btn_Minimize
        '
        Me.Btn_Minimize.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Btn_Minimize.FlatAppearance.BorderSize = 0
        Me.Btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Minimize.ImageIndex = 3
        Me.Btn_Minimize.ImageList = Me.ImageList_FrameControl
        Me.Btn_Minimize.Location = New System.Drawing.Point(602, 3)
        Me.Btn_Minimize.Name = "Btn_Minimize"
        Me.Btn_Minimize.Size = New System.Drawing.Size(37, 30)
        Me.Btn_Minimize.TabIndex = 15
        Me.Btn_Minimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Btn_Minimize.UseVisualStyleBackColor = False
        '
        'PanelExpandNotifications
        '
        Me.PanelExpandNotifications.AutoScroll = True
        Me.PanelExpandNotifications.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.PanelExpandNotifications.Controls.Add(Me.Btn_NotifyOptions)
        Me.PanelExpandNotifications.Controls.Add(Me.Panel2)
        Me.PanelExpandNotifications.Controls.Add(Me.Label5)
        Me.PanelExpandNotifications.Controls.Add(Me.Label14)
        Me.PanelExpandNotifications.Controls.Add(Me.Label2)
        Me.PanelExpandNotifications.Location = New System.Drawing.Point(822, 160)
        Me.PanelExpandNotifications.MaximumSize = New System.Drawing.Size(225, 295)
        Me.PanelExpandNotifications.Name = "PanelExpandNotifications"
        Me.PanelExpandNotifications.Size = New System.Drawing.Size(225, 295)
        Me.PanelExpandNotifications.TabIndex = 23
        '
        'Btn_NotifyOptions
        '
        Me.Btn_NotifyOptions.FlatAppearance.BorderSize = 0
        Me.Btn_NotifyOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Btn_NotifyOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Btn_NotifyOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_NotifyOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_NotifyOptions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Btn_NotifyOptions.Location = New System.Drawing.Point(174, 3)
        Me.Btn_NotifyOptions.Name = "Btn_NotifyOptions"
        Me.Btn_NotifyOptions.Size = New System.Drawing.Size(46, 37)
        Me.Btn_NotifyOptions.TabIndex = 34
        Me.Btn_NotifyOptions.Text = " ⋮ "
        Me.Btn_NotifyOptions.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(3, 42)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(217, 1)
        Me.Panel2.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(117, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Label2"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label14.Location = New System.Drawing.Point(56, 10)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 18)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Notifications"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(45, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Label2"
        '
        'ExpandNotifications
        '
        Me.ExpandNotifications.Interval = 15
        '
        'PanelExpandAccount
        '
        Me.PanelExpandAccount.Controls.Add(Me.Label4)
        Me.PanelExpandAccount.Controls.Add(Me.Panel3)
        Me.PanelExpandAccount.Controls.Add(Me.Label3)
        Me.PanelExpandAccount.Controls.Add(Me.Label6)
        Me.PanelExpandAccount.Location = New System.Drawing.Point(1031, 56)
        Me.PanelExpandAccount.MaximumSize = New System.Drawing.Size(225, 295)
        Me.PanelExpandAccount.Name = "PanelExpandAccount"
        Me.PanelExpandAccount.Size = New System.Drawing.Size(225, 295)
        Me.PanelExpandAccount.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(36, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Label2"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(26, 35)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(170, 1)
        Me.Panel3.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(36, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Label2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(84, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Account"
        '
        'ExpandAccount
        '
        Me.ExpandAccount.Interval = 15
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Gray
        Me.Panel4.Location = New System.Drawing.Point(30, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1, 25)
        Me.Panel4.TabIndex = 33
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Gray
        Me.Panel5.Location = New System.Drawing.Point(61, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1, 25)
        Me.Panel5.TabIndex = 33
        '
        'ContextMenuNotify
        '
        Me.ContextMenuNotify.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ContextMenuNotify.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuNotify.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuNotify.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.ContextMenuNotify.Name = "ContextMenuNotify"
        Me.ContextMenuNotify.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ContextMenuNotify.Size = New System.Drawing.Size(164, 56)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Control
        Me.ToolStripMenuItem1.Image = Global.Script_Agent.My.Resources.Resources.envelope
        Me.ToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(163, 26)
        Me.ToolStripMenuItem1.Text = "Mark all as read"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.Control
        Me.ToolStripMenuItem2.Image = Global.Script_Agent.My.Resources.Resources.trash
        Me.ToolStripMenuItem2.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(163, 26)
        Me.ToolStripMenuItem2.Text = "Clear all"
        '
        'PictureBoxSettings
        '
        Me.PictureBoxSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxSettings.Image = Global.Script_Agent.My.Resources.Resources.settings__1_
        Me.PictureBoxSettings.Location = New System.Drawing.Point(75, 3)
        Me.PictureBoxSettings.Name = "PictureBoxSettings"
        Me.PictureBoxSettings.Size = New System.Drawing.Size(34, 30)
        Me.PictureBoxSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxSettings.TabIndex = 17
        Me.PictureBoxSettings.TabStop = False
        '
        'PictureBoxAccount
        '
        Me.PictureBoxAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxAccount.Image = Global.Script_Agent.My.Resources.Resources.user
        Me.PictureBoxAccount.Location = New System.Drawing.Point(39, 3)
        Me.PictureBoxAccount.Name = "PictureBoxAccount"
        Me.PictureBoxAccount.Size = New System.Drawing.Size(30, 27)
        Me.PictureBoxAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxAccount.TabIndex = 16
        Me.PictureBoxAccount.TabStop = False
        '
        'PB_Logo
        '
        Me.PB_Logo.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.PB_Logo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_Logo.Image = Global.Script_Agent.My.Resources.Resources.Load_Animation2
        Me.PB_Logo.Location = New System.Drawing.Point(0, -1)
        Me.PB_Logo.Name = "PB_Logo"
        Me.PB_Logo.Size = New System.Drawing.Size(64, 68)
        Me.PB_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_Logo.TabIndex = 13
        Me.PB_Logo.TabStop = False
        '
        'PictureBoxNotifications
        '
        Me.PictureBoxNotifications.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxNotifications.Image = Global.Script_Agent.My.Resources.Resources.bell
        Me.PictureBoxNotifications.Location = New System.Drawing.Point(3, 3)
        Me.PictureBoxNotifications.Name = "PictureBoxNotifications"
        Me.PictureBoxNotifications.Size = New System.Drawing.Size(30, 27)
        Me.PictureBoxNotifications.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxNotifications.TabIndex = 16
        Me.PictureBoxNotifications.TabStop = False
        '
        'PixBox_Top
        '
        Me.PixBox_Top.Location = New System.Drawing.Point(70, 40)
        Me.PixBox_Top.Name = "PixBox_Top"
        Me.PixBox_Top.Size = New System.Drawing.Size(45, 25)
        Me.PixBox_Top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PixBox_Top.TabIndex = 13
        Me.PixBox_Top.TabStop = False
        '
        'Lbl_NotifyCount
        '
        Me.Lbl_NotifyCount.AutoSize = True
        Me.Lbl_NotifyCount.BackColor = System.Drawing.Color.Red
        Me.Lbl_NotifyCount.ForeColor = System.Drawing.SystemColors.Control
        Me.Lbl_NotifyCount.Location = New System.Drawing.Point(26, 20)
        Me.Lbl_NotifyCount.Name = "Lbl_NotifyCount"
        Me.Lbl_NotifyCount.Size = New System.Drawing.Size(13, 13)
        Me.Lbl_NotifyCount.TabIndex = 23
        Me.Lbl_NotifyCount.Text = "2"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Lbl_NotifyCount)
        Me.Panel6.Controls.Add(Me.PictureBoxNotifications)
        Me.Panel6.Controls.Add(Me.Panel5)
        Me.Panel6.Controls.Add(Me.PictureBoxAccount)
        Me.Panel6.Controls.Add(Me.Panel4)
        Me.Panel6.Controls.Add(Me.PictureBoxSettings)
        Me.Panel6.Location = New System.Drawing.Point(612, 38)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(113, 33)
        Me.Panel6.TabIndex = 23
        '
        'Frame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(753, 738)
        Me.Controls.Add(Me.PanelExpandAccount)
        Me.Controls.Add(Me.PanelExpandNotifications)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PB_Logo)
        Me.Controls.Add(Me.Lbl_TopLabel)
        Me.Controls.Add(Me.PixBox_Top)
        Me.Controls.Add(Me.PnlMain)
        Me.Controls.Add(Me.PnlMenu)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(861, 738)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(753, 738)
        Me.Name = "Frame"
        Me.Opacity = 0.99R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Office"
        Me.PnlMenu.ResumeLayout(False)
        Me.PnlMain.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelExpandNotifications.ResumeLayout(False)
        Me.PanelExpandNotifications.PerformLayout()
        Me.PanelExpandAccount.ResumeLayout(False)
        Me.PanelExpandAccount.PerformLayout()
        Me.ContextMenuNotify.ResumeLayout(False)
        CType(Me.PictureBoxSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxNotifications, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PixBox_Top, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlMenu As Panel
    Friend WithEvents PB_Logo As PictureBox
    Friend WithEvents ImageList_Buttons As ImageList
    Friend WithEvents ImgList_MenuLeft As ImageList
    Friend WithEvents PixBox_Top As PictureBox
    Friend WithEvents ImageList_Expand As ImageList
    Friend WithEvents ImageList_CommandButton As ImageList
    Friend WithEvents Lbl_TopLabel As Label
    Friend WithEvents Btn_Settings As Button
    Friend WithEvents Btn_Ticket As Button
    Friend WithEvents Btn_Commands As Button
    Friend WithEvents PnlMain As Panel
    Friend WithEvents ImageList_FrameControl As ImageList
    Friend WithEvents Btn_home As Button
    Friend WithEvents Btn_Exit As Button
    Friend WithEvents Btn_Minimize As Button
    Friend WithEvents Btn_VirusScan As Button
    Friend WithEvents PictureBoxNotifications As PictureBox
    Friend WithEvents PictureBoxSettings As PictureBox
    Friend WithEvents ExpandLeftMenu As Timer
    Friend WithEvents ImageList_ExpandLeftMenuBtn As ImageList
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBoxAccount As PictureBox
    Friend WithEvents PanelExpandNotifications As Panel
    Friend WithEvents ExpandNotifications As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents PanelExpandAccount As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ExpandAccount As Timer
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Btn_NotifyOptions As Button
    Friend WithEvents ContextMenuNotify As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents Lbl_NotifyCount As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Btn_Browser As Button
End Class
