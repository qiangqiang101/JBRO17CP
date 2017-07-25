<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCP))
        Me.lbl_Member = New System.Windows.Forms.Label()
        Me.lbl_Point = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_Welcome = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.sideBar = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cpTab = New MdiTabControl.TabControl()
        Me.llblChgPass = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.fbTopup = New JBRanOnlineCP.flatButton()
        Me.fbRanking = New JBRanOnlineCP.flatButton()
        Me.fbStore = New JBRanOnlineCP.flatButton()
        Me.fbKick = New JBRanOnlineCP.flatButton()
        Me.fbRename = New JBRanOnlineCP.flatButton()
        Me.fbClearRed = New JBRanOnlineCP.flatButton()
        Me.fbChgSchool = New JBRanOnlineCP.flatButton()
        Me.fbResetPoint = New JBRanOnlineCP.flatButton()
        Me.fbAddPoint = New JBRanOnlineCP.flatButton()
        Me.fbReborn = New JBRanOnlineCP.flatButton()
        Me.fbNotice = New JBRanOnlineCP.flatButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.llblProfile = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sideBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Member
        '
        Me.lbl_Member.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Member.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lbl_Member.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbl_Member.ForeColor = System.Drawing.Color.White
        Me.lbl_Member.Location = New System.Drawing.Point(843, 30)
        Me.lbl_Member.Name = "lbl_Member"
        Me.lbl_Member.Size = New System.Drawing.Size(153, 21)
        Me.lbl_Member.TabIndex = 37
        Me.lbl_Member.Text = "会员: 普通会员"
        Me.lbl_Member.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_Point
        '
        Me.lbl_Point.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Point.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lbl_Point.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbl_Point.ForeColor = System.Drawing.Color.White
        Me.lbl_Point.Location = New System.Drawing.Point(843, 9)
        Me.lbl_Point.Name = "lbl_Point"
        Me.lbl_Point.Size = New System.Drawing.Size(153, 21)
        Me.lbl_Point.TabIndex = 36
        Me.lbl_Point.Text = "积分: 0"
        Me.lbl_Point.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 37)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "控制面板"
        '
        'lbl_Welcome
        '
        Me.lbl_Welcome.AutoSize = True
        Me.lbl_Welcome.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lbl_Welcome.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbl_Welcome.ForeColor = System.Drawing.Color.White
        Me.lbl_Welcome.Location = New System.Drawing.Point(36, 46)
        Me.lbl_Welcome.Name = "lbl_Welcome"
        Me.lbl_Welcome.Size = New System.Drawing.Size(224, 21)
        Me.lbl_Welcome.TabIndex = 35
        Me.lbl_Welcome.Text = "热烈欢迎 {usernamehere} 光临"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1008, 75)
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'sideBar
        '
        Me.sideBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.sideBar.Controls.Add(Me.fbTopup)
        Me.sideBar.Controls.Add(Me.fbRanking)
        Me.sideBar.Controls.Add(Me.fbStore)
        Me.sideBar.Controls.Add(Me.fbKick)
        Me.sideBar.Controls.Add(Me.fbRename)
        Me.sideBar.Controls.Add(Me.fbClearRed)
        Me.sideBar.Controls.Add(Me.fbChgSchool)
        Me.sideBar.Controls.Add(Me.fbResetPoint)
        Me.sideBar.Controls.Add(Me.fbAddPoint)
        Me.sideBar.Controls.Add(Me.fbReborn)
        Me.sideBar.Controls.Add(Me.fbNotice)
        Me.sideBar.Dock = System.Windows.Forms.DockStyle.Left
        Me.sideBar.Location = New System.Drawing.Point(0, 75)
        Me.sideBar.Name = "sideBar"
        Me.sideBar.Size = New System.Drawing.Size(238, 655)
        Me.sideBar.TabIndex = 38
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 30000
        '
        'cpTab
        '
        Me.cpTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cpTab.BackHighColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cpTab.BackLowColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cpTab.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cpTab.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cpTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cpTab.ForeColor = System.Drawing.Color.White
        Me.cpTab.ForeColorDisabled = System.Drawing.Color.Silver
        Me.cpTab.Location = New System.Drawing.Point(238, 75)
        Me.cpTab.MenuRenderer = Nothing
        Me.cpTab.Name = "cpTab"
        Me.cpTab.Size = New System.Drawing.Size(770, 655)
        Me.cpTab.TabBackHighColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cpTab.TabBackHighColorDisabled = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cpTab.TabBackLowColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cpTab.TabBorderEnhanced = True
        Me.cpTab.TabCloseButtonImage = Nothing
        Me.cpTab.TabCloseButtonImageDisabled = Nothing
        Me.cpTab.TabCloseButtonImageHot = Nothing
        Me.cpTab.TabGlassGradient = True
        Me.cpTab.TabIndex = 39
        Me.cpTab.TopSeparator = False
        '
        'llblChgPass
        '
        Me.llblChgPass.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblChgPass.AutoSize = True
        Me.llblChgPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.llblChgPass.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.llblChgPass.ForeColor = System.Drawing.Color.White
        Me.llblChgPass.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.llblChgPass.LinkColor = System.Drawing.Color.White
        Me.llblChgPass.Location = New System.Drawing.Point(854, 51)
        Me.llblChgPass.Name = "llblChgPass"
        Me.llblChgPass.Size = New System.Drawing.Size(74, 21)
        Me.llblChgPass.TabIndex = 40
        Me.llblChgPass.TabStop = True
        Me.llblChgPass.Text = "修改密码"
        Me.llblChgPass.VisitedLinkColor = System.Drawing.Color.White
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(934, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 21)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "|"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LinkLabel1.ForeColor = System.Drawing.Color.White
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(954, 51)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(42, 21)
        Me.LinkLabel1.TabIndex = 42
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "登出"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.White
        '
        'fbTopup
        '
        Me.fbTopup.ActiveColor = System.Drawing.Color.Red
        Me.fbTopup.ActiveTextColor = System.Drawing.Color.White
        Me.fbTopup.BackColor = System.Drawing.Color.DarkRed
        Me.fbTopup.DisabledColor = System.Drawing.Color.Gray
        Me.fbTopup.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.fbTopup.HoverColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.fbTopup.HoverTextColor = System.Drawing.Color.LightBlue
        Me.fbTopup.Icon = CType(resources.GetObject("fbTopup.Icon"), System.Drawing.Image)
        Me.fbTopup.IconBackground = Nothing
        Me.fbTopup.IconBackgroundSizeMode = System.Windows.Forms.ImageLayout.Tile
        Me.fbTopup.IconSizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fbTopup.IconStyle = JBRanOnlineCP.flatButton.IconImageStyle.Normal
        Me.fbTopup.Location = New System.Drawing.Point(0, 57)
        Me.fbTopup.Name = "fbTopup"
        Me.fbTopup.NormalColor = System.Drawing.Color.DarkRed
        Me.fbTopup.NormalTextColor = System.Drawing.Color.Silver
        Me.fbTopup.Size = New System.Drawing.Size(238, 45)
        Me.fbTopup.TabIndex = 51
        Me.fbTopup.Value = "在线冲值"
        '
        'fbRanking
        '
        Me.fbRanking.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.fbRanking.ActiveTextColor = System.Drawing.Color.White
        Me.fbRanking.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.fbRanking.DisabledColor = System.Drawing.Color.Gray
        Me.fbRanking.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.fbRanking.HoverColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.fbRanking.HoverTextColor = System.Drawing.Color.LightBlue
        Me.fbRanking.Icon = CType(resources.GetObject("fbRanking.Icon"), System.Drawing.Image)
        Me.fbRanking.IconBackground = Nothing
        Me.fbRanking.IconBackgroundSizeMode = System.Windows.Forms.ImageLayout.Tile
        Me.fbRanking.IconSizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fbRanking.IconStyle = JBRanOnlineCP.flatButton.IconImageStyle.Normal
        Me.fbRanking.Location = New System.Drawing.Point(0, 516)
        Me.fbRanking.Name = "fbRanking"
        Me.fbRanking.NormalColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.fbRanking.NormalTextColor = System.Drawing.Color.Silver
        Me.fbRanking.Size = New System.Drawing.Size(238, 45)
        Me.fbRanking.TabIndex = 49
        Me.fbRanking.Value = "英雄排行"
        '
        'fbStore
        '
        Me.fbStore.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.fbStore.ActiveTextColor = System.Drawing.Color.White
        Me.fbStore.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.fbStore.DisabledColor = System.Drawing.Color.Gray
        Me.fbStore.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.fbStore.HoverColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.fbStore.HoverTextColor = System.Drawing.Color.LightBlue
        Me.fbStore.Icon = CType(resources.GetObject("fbStore.Icon"), System.Drawing.Image)
        Me.fbStore.IconBackground = Nothing
        Me.fbStore.IconBackgroundSizeMode = System.Windows.Forms.ImageLayout.Tile
        Me.fbStore.IconSizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fbStore.IconStyle = JBRanOnlineCP.flatButton.IconImageStyle.Normal
        Me.fbStore.Location = New System.Drawing.Point(0, 465)
        Me.fbStore.Name = "fbStore"
        Me.fbStore.NormalColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.fbStore.NormalTextColor = System.Drawing.Color.Silver
        Me.fbStore.Size = New System.Drawing.Size(238, 45)
        Me.fbStore.TabIndex = 48
        Me.fbStore.Value = "在线商城"
        '
        'fbKick
        '
        Me.fbKick.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.fbKick.ActiveTextColor = System.Drawing.Color.White
        Me.fbKick.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.fbKick.DisabledColor = System.Drawing.Color.Gray
        Me.fbKick.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.fbKick.HoverColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.fbKick.HoverTextColor = System.Drawing.Color.LightBlue
        Me.fbKick.Icon = CType(resources.GetObject("fbKick.Icon"), System.Drawing.Image)
        Me.fbKick.IconBackground = Nothing
        Me.fbKick.IconBackgroundSizeMode = System.Windows.Forms.ImageLayout.Tile
        Me.fbKick.IconSizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fbKick.IconStyle = JBRanOnlineCP.flatButton.IconImageStyle.Normal
        Me.fbKick.Location = New System.Drawing.Point(0, 414)
        Me.fbKick.Name = "fbKick"
        Me.fbKick.NormalColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.fbKick.NormalTextColor = System.Drawing.Color.Silver
        Me.fbKick.Size = New System.Drawing.Size(238, 45)
        Me.fbKick.TabIndex = 47
        Me.fbKick.Value = "卡号自救"
        '
        'fbRename
        '
        Me.fbRename.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.fbRename.ActiveTextColor = System.Drawing.Color.White
        Me.fbRename.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.fbRename.DisabledColor = System.Drawing.Color.Gray
        Me.fbRename.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.fbRename.HoverColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.fbRename.HoverTextColor = System.Drawing.Color.LightBlue
        Me.fbRename.Icon = CType(resources.GetObject("fbRename.Icon"), System.Drawing.Image)
        Me.fbRename.IconBackground = Nothing
        Me.fbRename.IconBackgroundSizeMode = System.Windows.Forms.ImageLayout.Tile
        Me.fbRename.IconSizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fbRename.IconStyle = JBRanOnlineCP.flatButton.IconImageStyle.Normal
        Me.fbRename.Location = New System.Drawing.Point(0, 363)
        Me.fbRename.Name = "fbRename"
        Me.fbRename.NormalColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.fbRename.NormalTextColor = System.Drawing.Color.Silver
        Me.fbRename.Size = New System.Drawing.Size(238, 45)
        Me.fbRename.TabIndex = 46
        Me.fbRename.Value = "在线改名"
        '
        'fbClearRed
        '
        Me.fbClearRed.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.fbClearRed.ActiveTextColor = System.Drawing.Color.White
        Me.fbClearRed.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.fbClearRed.DisabledColor = System.Drawing.Color.Gray
        Me.fbClearRed.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.fbClearRed.HoverColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.fbClearRed.HoverTextColor = System.Drawing.Color.LightBlue
        Me.fbClearRed.Icon = CType(resources.GetObject("fbClearRed.Icon"), System.Drawing.Image)
        Me.fbClearRed.IconBackground = Nothing
        Me.fbClearRed.IconBackgroundSizeMode = System.Windows.Forms.ImageLayout.Tile
        Me.fbClearRed.IconSizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fbClearRed.IconStyle = JBRanOnlineCP.flatButton.IconImageStyle.Normal
        Me.fbClearRed.Location = New System.Drawing.Point(0, 312)
        Me.fbClearRed.Name = "fbClearRed"
        Me.fbClearRed.NormalColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.fbClearRed.NormalTextColor = System.Drawing.Color.Silver
        Me.fbClearRed.Size = New System.Drawing.Size(238, 45)
        Me.fbClearRed.TabIndex = 45
        Me.fbClearRed.Value = "红名漂白"
        '
        'fbChgSchool
        '
        Me.fbChgSchool.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.fbChgSchool.ActiveTextColor = System.Drawing.Color.White
        Me.fbChgSchool.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.fbChgSchool.DisabledColor = System.Drawing.Color.Gray
        Me.fbChgSchool.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.fbChgSchool.HoverColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.fbChgSchool.HoverTextColor = System.Drawing.Color.LightBlue
        Me.fbChgSchool.Icon = CType(resources.GetObject("fbChgSchool.Icon"), System.Drawing.Image)
        Me.fbChgSchool.IconBackground = Nothing
        Me.fbChgSchool.IconBackgroundSizeMode = System.Windows.Forms.ImageLayout.Tile
        Me.fbChgSchool.IconSizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fbChgSchool.IconStyle = JBRanOnlineCP.flatButton.IconImageStyle.Normal
        Me.fbChgSchool.Location = New System.Drawing.Point(0, 261)
        Me.fbChgSchool.Name = "fbChgSchool"
        Me.fbChgSchool.NormalColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.fbChgSchool.NormalTextColor = System.Drawing.Color.Silver
        Me.fbChgSchool.Size = New System.Drawing.Size(238, 45)
        Me.fbChgSchool.TabIndex = 44
        Me.fbChgSchool.Value = "在线转学"
        '
        'fbResetPoint
        '
        Me.fbResetPoint.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.fbResetPoint.ActiveTextColor = System.Drawing.Color.White
        Me.fbResetPoint.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.fbResetPoint.DisabledColor = System.Drawing.Color.Gray
        Me.fbResetPoint.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.fbResetPoint.HoverColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.fbResetPoint.HoverTextColor = System.Drawing.Color.LightBlue
        Me.fbResetPoint.Icon = CType(resources.GetObject("fbResetPoint.Icon"), System.Drawing.Image)
        Me.fbResetPoint.IconBackground = Nothing
        Me.fbResetPoint.IconBackgroundSizeMode = System.Windows.Forms.ImageLayout.Tile
        Me.fbResetPoint.IconSizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fbResetPoint.IconStyle = JBRanOnlineCP.flatButton.IconImageStyle.Normal
        Me.fbResetPoint.Location = New System.Drawing.Point(0, 210)
        Me.fbResetPoint.Name = "fbResetPoint"
        Me.fbResetPoint.NormalColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.fbResetPoint.NormalTextColor = System.Drawing.Color.Silver
        Me.fbResetPoint.Size = New System.Drawing.Size(238, 45)
        Me.fbResetPoint.TabIndex = 43
        Me.fbResetPoint.Value = "在线洗点"
        '
        'fbAddPoint
        '
        Me.fbAddPoint.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.fbAddPoint.ActiveTextColor = System.Drawing.Color.White
        Me.fbAddPoint.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.fbAddPoint.DisabledColor = System.Drawing.Color.Gray
        Me.fbAddPoint.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.fbAddPoint.HoverColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.fbAddPoint.HoverTextColor = System.Drawing.Color.LightBlue
        Me.fbAddPoint.Icon = CType(resources.GetObject("fbAddPoint.Icon"), System.Drawing.Image)
        Me.fbAddPoint.IconBackground = Nothing
        Me.fbAddPoint.IconBackgroundSizeMode = System.Windows.Forms.ImageLayout.Tile
        Me.fbAddPoint.IconSizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fbAddPoint.IconStyle = JBRanOnlineCP.flatButton.IconImageStyle.Normal
        Me.fbAddPoint.Location = New System.Drawing.Point(0, 159)
        Me.fbAddPoint.Name = "fbAddPoint"
        Me.fbAddPoint.NormalColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.fbAddPoint.NormalTextColor = System.Drawing.Color.Silver
        Me.fbAddPoint.Size = New System.Drawing.Size(238, 45)
        Me.fbAddPoint.TabIndex = 42
        Me.fbAddPoint.Value = "在线加点"
        '
        'fbReborn
        '
        Me.fbReborn.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.fbReborn.ActiveTextColor = System.Drawing.Color.White
        Me.fbReborn.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.fbReborn.DisabledColor = System.Drawing.Color.Gray
        Me.fbReborn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.fbReborn.HoverColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.fbReborn.HoverTextColor = System.Drawing.Color.LightBlue
        Me.fbReborn.Icon = CType(resources.GetObject("fbReborn.Icon"), System.Drawing.Image)
        Me.fbReborn.IconBackground = Nothing
        Me.fbReborn.IconBackgroundSizeMode = System.Windows.Forms.ImageLayout.Tile
        Me.fbReborn.IconSizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fbReborn.IconStyle = JBRanOnlineCP.flatButton.IconImageStyle.Normal
        Me.fbReborn.Location = New System.Drawing.Point(0, 108)
        Me.fbReborn.Name = "fbReborn"
        Me.fbReborn.NormalColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.fbReborn.NormalTextColor = System.Drawing.Color.Silver
        Me.fbReborn.Size = New System.Drawing.Size(238, 45)
        Me.fbReborn.TabIndex = 41
        Me.fbReborn.Value = "在线转生"
        '
        'fbNotice
        '
        Me.fbNotice.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.fbNotice.ActiveTextColor = System.Drawing.Color.White
        Me.fbNotice.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.fbNotice.DisabledColor = System.Drawing.Color.Gray
        Me.fbNotice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.fbNotice.HoverColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.fbNotice.HoverTextColor = System.Drawing.Color.LightBlue
        Me.fbNotice.Icon = CType(resources.GetObject("fbNotice.Icon"), System.Drawing.Image)
        Me.fbNotice.IconBackground = Nothing
        Me.fbNotice.IconBackgroundSizeMode = System.Windows.Forms.ImageLayout.Tile
        Me.fbNotice.IconSizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fbNotice.IconStyle = JBRanOnlineCP.flatButton.IconImageStyle.Normal
        Me.fbNotice.Location = New System.Drawing.Point(0, 6)
        Me.fbNotice.Name = "fbNotice"
        Me.fbNotice.NormalColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.fbNotice.NormalTextColor = System.Drawing.Color.Silver
        Me.fbNotice.Size = New System.Drawing.Size(238, 45)
        Me.fbNotice.TabIndex = 40
        Me.fbNotice.Value = "游戏公告"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(834, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 21)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "|"
        '
        'llblProfile
        '
        Me.llblProfile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblProfile.AutoSize = True
        Me.llblProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.llblProfile.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.llblProfile.ForeColor = System.Drawing.Color.White
        Me.llblProfile.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.llblProfile.LinkColor = System.Drawing.Color.White
        Me.llblProfile.Location = New System.Drawing.Point(754, 51)
        Me.llblProfile.Name = "llblProfile"
        Me.llblProfile.Size = New System.Drawing.Size(74, 21)
        Me.llblProfile.TabIndex = 44
        Me.llblProfile.TabStop = True
        Me.llblProfile.Text = "帐户设置"
        Me.llblProfile.VisitedLinkColor = System.Drawing.Color.White
        '
        'frmCP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.llblProfile)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.llblChgPass)
        Me.Controls.Add(Me.cpTab)
        Me.Controls.Add(Me.sideBar)
        Me.Controls.Add(Me.lbl_Member)
        Me.Controls.Add(Me.lbl_Point)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_Welcome)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(900, 700)
        Me.Name = "frmCP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "新劲爆乱Online - 控制面板"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sideBar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Member As Label
    Friend WithEvents lbl_Point As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_Welcome As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents sideBar As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents cpTab As MdiTabControl.TabControl
    Friend WithEvents fbRanking As flatButton
    Friend WithEvents fbStore As flatButton
    Friend WithEvents fbKick As flatButton
    Friend WithEvents fbRename As flatButton
    Friend WithEvents fbClearRed As flatButton
    Friend WithEvents fbChgSchool As flatButton
    Friend WithEvents fbResetPoint As flatButton
    Friend WithEvents fbAddPoint As flatButton
    Friend WithEvents fbReborn As flatButton
    Friend WithEvents fbNotice As flatButton
    Friend WithEvents fbTopup As flatButton
    Friend WithEvents llblChgPass As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents llblProfile As LinkLabel
End Class
