<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmShop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShop))
        Me.flpShop = New System.Windows.Forms.FlowLayoutPanel()
        Me.sidebar = New System.Windows.Forms.Panel()
        Me.fbMisc = New JBRanOnlineCP.flatButton()
        Me.fbSet = New JBRanOnlineCP.flatButton()
        Me.fbPets = New JBRanOnlineCP.flatButton()
        Me.fbVehicle = New JBRanOnlineCP.flatButton()
        Me.fbSkill = New JBRanOnlineCP.flatButton()
        Me.fbHair = New JBRanOnlineCP.flatButton()
        Me.fbAccessory = New JBRanOnlineCP.flatButton()
        Me.fbArmour = New JBRanOnlineCP.flatButton()
        Me.fbWeapon = New JBRanOnlineCP.flatButton()
        Me.sidebar.SuspendLayout()
        Me.SuspendLayout()
        '
        'flpShop
        '
        Me.flpShop.AutoScroll = True
        Me.flpShop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpShop.Location = New System.Drawing.Point(0, 0)
        Me.flpShop.Name = "flpShop"
        Me.flpShop.Size = New System.Drawing.Size(770, 589)
        Me.flpShop.TabIndex = 0
        '
        'sidebar
        '
        Me.sidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.sidebar.Controls.Add(Me.fbMisc)
        Me.sidebar.Controls.Add(Me.fbSet)
        Me.sidebar.Controls.Add(Me.fbPets)
        Me.sidebar.Controls.Add(Me.fbVehicle)
        Me.sidebar.Controls.Add(Me.fbSkill)
        Me.sidebar.Controls.Add(Me.fbHair)
        Me.sidebar.Controls.Add(Me.fbAccessory)
        Me.sidebar.Controls.Add(Me.fbArmour)
        Me.sidebar.Controls.Add(Me.fbWeapon)
        Me.sidebar.Dock = System.Windows.Forms.DockStyle.Right
        Me.sidebar.Location = New System.Drawing.Point(770, 0)
        Me.sidebar.Name = "sidebar"
        Me.sidebar.Size = New System.Drawing.Size(238, 589)
        Me.sidebar.TabIndex = 1
        '
        'fbMisc
        '
        Me.fbMisc.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.fbMisc.ActiveTextColor = System.Drawing.Color.White
        Me.fbMisc.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.fbMisc.DisabledColor = System.Drawing.Color.Gray
        Me.fbMisc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.fbMisc.HoverColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.fbMisc.HoverTextColor = System.Drawing.Color.LightBlue
        Me.fbMisc.Icon = CType(resources.GetObject("fbMisc.Icon"), System.Drawing.Image)
        Me.fbMisc.IconBackground = Nothing
        Me.fbMisc.IconBackgroundSizeMode = System.Windows.Forms.ImageLayout.Tile
        Me.fbMisc.IconSizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fbMisc.IconStyle = JBRanOnlineCP.flatButton.IconImageStyle.Normal
        Me.fbMisc.Location = New System.Drawing.Point(0, 408)
        Me.fbMisc.Name = "fbMisc"
        Me.fbMisc.NormalColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.fbMisc.NormalTextColor = System.Drawing.Color.Silver
        Me.fbMisc.Size = New System.Drawing.Size(238, 45)
        Me.fbMisc.TabIndex = 49
        Me.fbMisc.Value = "其他"
        '
        'fbSet
        '
        Me.fbSet.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.fbSet.ActiveTextColor = System.Drawing.Color.White
        Me.fbSet.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.fbSet.DisabledColor = System.Drawing.Color.Gray
        Me.fbSet.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.fbSet.HoverColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.fbSet.HoverTextColor = System.Drawing.Color.LightBlue
        Me.fbSet.Icon = CType(resources.GetObject("fbSet.Icon"), System.Drawing.Image)
        Me.fbSet.IconBackground = Nothing
        Me.fbSet.IconBackgroundSizeMode = System.Windows.Forms.ImageLayout.Tile
        Me.fbSet.IconSizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fbSet.IconStyle = JBRanOnlineCP.flatButton.IconImageStyle.Normal
        Me.fbSet.Location = New System.Drawing.Point(0, 357)
        Me.fbSet.Name = "fbSet"
        Me.fbSet.NormalColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.fbSet.NormalTextColor = System.Drawing.Color.Silver
        Me.fbSet.Size = New System.Drawing.Size(238, 45)
        Me.fbSet.TabIndex = 48
        Me.fbSet.Value = "套餐"
        '
        'fbPets
        '
        Me.fbPets.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.fbPets.ActiveTextColor = System.Drawing.Color.White
        Me.fbPets.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.fbPets.DisabledColor = System.Drawing.Color.Gray
        Me.fbPets.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.fbPets.HoverColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.fbPets.HoverTextColor = System.Drawing.Color.LightBlue
        Me.fbPets.Icon = CType(resources.GetObject("fbPets.Icon"), System.Drawing.Image)
        Me.fbPets.IconBackground = Nothing
        Me.fbPets.IconBackgroundSizeMode = System.Windows.Forms.ImageLayout.Tile
        Me.fbPets.IconSizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fbPets.IconStyle = JBRanOnlineCP.flatButton.IconImageStyle.Normal
        Me.fbPets.Location = New System.Drawing.Point(0, 306)
        Me.fbPets.Name = "fbPets"
        Me.fbPets.NormalColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.fbPets.NormalTextColor = System.Drawing.Color.Silver
        Me.fbPets.Size = New System.Drawing.Size(238, 45)
        Me.fbPets.TabIndex = 47
        Me.fbPets.Value = "宠物"
        '
        'fbVehicle
        '
        Me.fbVehicle.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.fbVehicle.ActiveTextColor = System.Drawing.Color.White
        Me.fbVehicle.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.fbVehicle.DisabledColor = System.Drawing.Color.Gray
        Me.fbVehicle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.fbVehicle.HoverColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.fbVehicle.HoverTextColor = System.Drawing.Color.LightBlue
        Me.fbVehicle.Icon = CType(resources.GetObject("fbVehicle.Icon"), System.Drawing.Image)
        Me.fbVehicle.IconBackground = Nothing
        Me.fbVehicle.IconBackgroundSizeMode = System.Windows.Forms.ImageLayout.Tile
        Me.fbVehicle.IconSizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fbVehicle.IconStyle = JBRanOnlineCP.flatButton.IconImageStyle.Normal
        Me.fbVehicle.Location = New System.Drawing.Point(0, 255)
        Me.fbVehicle.Name = "fbVehicle"
        Me.fbVehicle.NormalColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.fbVehicle.NormalTextColor = System.Drawing.Color.Silver
        Me.fbVehicle.Size = New System.Drawing.Size(238, 45)
        Me.fbVehicle.TabIndex = 46
        Me.fbVehicle.Value = "载具"
        '
        'fbSkill
        '
        Me.fbSkill.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.fbSkill.ActiveTextColor = System.Drawing.Color.White
        Me.fbSkill.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.fbSkill.DisabledColor = System.Drawing.Color.Gray
        Me.fbSkill.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.fbSkill.HoverColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.fbSkill.HoverTextColor = System.Drawing.Color.LightBlue
        Me.fbSkill.Icon = CType(resources.GetObject("fbSkill.Icon"), System.Drawing.Image)
        Me.fbSkill.IconBackground = Nothing
        Me.fbSkill.IconBackgroundSizeMode = System.Windows.Forms.ImageLayout.Tile
        Me.fbSkill.IconSizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fbSkill.IconStyle = JBRanOnlineCP.flatButton.IconImageStyle.Normal
        Me.fbSkill.Location = New System.Drawing.Point(0, 204)
        Me.fbSkill.Name = "fbSkill"
        Me.fbSkill.NormalColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.fbSkill.NormalTextColor = System.Drawing.Color.Silver
        Me.fbSkill.Size = New System.Drawing.Size(238, 45)
        Me.fbSkill.TabIndex = 45
        Me.fbSkill.Value = "技能书"
        '
        'fbHair
        '
        Me.fbHair.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.fbHair.ActiveTextColor = System.Drawing.Color.White
        Me.fbHair.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.fbHair.DisabledColor = System.Drawing.Color.Gray
        Me.fbHair.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.fbHair.HoverColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.fbHair.HoverTextColor = System.Drawing.Color.LightBlue
        Me.fbHair.Icon = CType(resources.GetObject("fbHair.Icon"), System.Drawing.Image)
        Me.fbHair.IconBackground = Nothing
        Me.fbHair.IconBackgroundSizeMode = System.Windows.Forms.ImageLayout.Tile
        Me.fbHair.IconSizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fbHair.IconStyle = JBRanOnlineCP.flatButton.IconImageStyle.Normal
        Me.fbHair.Location = New System.Drawing.Point(0, 153)
        Me.fbHair.Name = "fbHair"
        Me.fbHair.NormalColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.fbHair.NormalTextColor = System.Drawing.Color.Silver
        Me.fbHair.Size = New System.Drawing.Size(238, 45)
        Me.fbHair.TabIndex = 44
        Me.fbHair.Value = "发型"
        '
        'fbAccessory
        '
        Me.fbAccessory.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.fbAccessory.ActiveTextColor = System.Drawing.Color.White
        Me.fbAccessory.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.fbAccessory.DisabledColor = System.Drawing.Color.Gray
        Me.fbAccessory.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.fbAccessory.HoverColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.fbAccessory.HoverTextColor = System.Drawing.Color.LightBlue
        Me.fbAccessory.Icon = CType(resources.GetObject("fbAccessory.Icon"), System.Drawing.Image)
        Me.fbAccessory.IconBackground = Nothing
        Me.fbAccessory.IconBackgroundSizeMode = System.Windows.Forms.ImageLayout.Tile
        Me.fbAccessory.IconSizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fbAccessory.IconStyle = JBRanOnlineCP.flatButton.IconImageStyle.Normal
        Me.fbAccessory.Location = New System.Drawing.Point(0, 102)
        Me.fbAccessory.Name = "fbAccessory"
        Me.fbAccessory.NormalColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.fbAccessory.NormalTextColor = System.Drawing.Color.Silver
        Me.fbAccessory.Size = New System.Drawing.Size(238, 45)
        Me.fbAccessory.TabIndex = 43
        Me.fbAccessory.Value = "首饰"
        '
        'fbArmour
        '
        Me.fbArmour.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.fbArmour.ActiveTextColor = System.Drawing.Color.White
        Me.fbArmour.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.fbArmour.DisabledColor = System.Drawing.Color.Gray
        Me.fbArmour.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.fbArmour.HoverColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.fbArmour.HoverTextColor = System.Drawing.Color.LightBlue
        Me.fbArmour.Icon = CType(resources.GetObject("fbArmour.Icon"), System.Drawing.Image)
        Me.fbArmour.IconBackground = Nothing
        Me.fbArmour.IconBackgroundSizeMode = System.Windows.Forms.ImageLayout.Tile
        Me.fbArmour.IconSizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fbArmour.IconStyle = JBRanOnlineCP.flatButton.IconImageStyle.Normal
        Me.fbArmour.Location = New System.Drawing.Point(0, 51)
        Me.fbArmour.Name = "fbArmour"
        Me.fbArmour.NormalColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.fbArmour.NormalTextColor = System.Drawing.Color.Silver
        Me.fbArmour.Size = New System.Drawing.Size(238, 45)
        Me.fbArmour.TabIndex = 42
        Me.fbArmour.Value = "服装"
        '
        'fbWeapon
        '
        Me.fbWeapon.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.fbWeapon.ActiveTextColor = System.Drawing.Color.White
        Me.fbWeapon.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.fbWeapon.DisabledColor = System.Drawing.Color.Gray
        Me.fbWeapon.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.fbWeapon.HoverColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.fbWeapon.HoverTextColor = System.Drawing.Color.LightBlue
        Me.fbWeapon.Icon = CType(resources.GetObject("fbWeapon.Icon"), System.Drawing.Image)
        Me.fbWeapon.IconBackground = Nothing
        Me.fbWeapon.IconBackgroundSizeMode = System.Windows.Forms.ImageLayout.Tile
        Me.fbWeapon.IconSizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fbWeapon.IconStyle = JBRanOnlineCP.flatButton.IconImageStyle.Normal
        Me.fbWeapon.Location = New System.Drawing.Point(0, 0)
        Me.fbWeapon.Name = "fbWeapon"
        Me.fbWeapon.NormalColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.fbWeapon.NormalTextColor = System.Drawing.Color.Silver
        Me.fbWeapon.Size = New System.Drawing.Size(238, 45)
        Me.fbWeapon.TabIndex = 41
        Me.fbWeapon.Value = "武器"
        '
        'frmShop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 589)
        Me.Controls.Add(Me.flpShop)
        Me.Controls.Add(Me.sidebar)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmShop"
        Me.Text = "在线商城"
        Me.sidebar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents flpShop As FlowLayoutPanel
    Friend WithEvents sidebar As Panel
    Friend WithEvents fbWeapon As flatButton
    Friend WithEvents fbMisc As flatButton
    Friend WithEvents fbSet As flatButton
    Friend WithEvents fbPets As flatButton
    Friend WithEvents fbVehicle As flatButton
    Friend WithEvents fbSkill As flatButton
    Friend WithEvents fbHair As flatButton
    Friend WithEvents fbAccessory As flatButton
    Friend WithEvents fbArmour As flatButton
End Class