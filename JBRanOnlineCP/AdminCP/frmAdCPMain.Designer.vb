﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdCPMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdCPMain))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_Welcome = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cpTab = New MdiTabControl.TabControl()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tsmSetting = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmChar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmTransaction = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmShopMgmt = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmProducts = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmAddProduct = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmShopTransaction = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 37)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "后台"
        '
        'lbl_Welcome
        '
        Me.lbl_Welcome.AutoSize = True
        Me.lbl_Welcome.BackColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Welcome.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbl_Welcome.ForeColor = System.Drawing.Color.White
        Me.lbl_Welcome.Location = New System.Drawing.Point(36, 46)
        Me.lbl_Welcome.Name = "lbl_Welcome"
        Me.lbl_Welcome.Size = New System.Drawing.Size(106, 21)
        Me.lbl_Welcome.TabIndex = 36
        Me.lbl_Welcome.Text = "后台控制面板"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1008, 75)
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'cpTab
        '
        Me.cpTab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cpTab.Location = New System.Drawing.Point(0, 102)
        Me.cpTab.MenuRenderer = Nothing
        Me.cpTab.Name = "cpTab"
        Me.cpTab.Size = New System.Drawing.Size(1008, 629)
        Me.cpTab.TabCloseButtonImage = Nothing
        Me.cpTab.TabCloseButtonImageDisabled = Nothing
        Me.cpTab.TabCloseButtonImageHot = Nothing
        Me.cpTab.TabIndex = 37
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmSetting, Me.tsmUser, Me.tsmChar, Me.tsmTransaction, Me.tsmShopMgmt, Me.tsmShopTransaction})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 75)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip1.TabIndex = 38
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsmSetting
        '
        Me.tsmSetting.Name = "tsmSetting"
        Me.tsmSetting.Size = New System.Drawing.Size(67, 20)
        Me.tsmSetting.Text = "一般设置"
        '
        'tsmUser
        '
        Me.tsmUser.Name = "tsmUser"
        Me.tsmUser.Size = New System.Drawing.Size(67, 20)
        Me.tsmUser.Text = "用户设置"
        '
        'tsmChar
        '
        Me.tsmChar.AutoSize = False
        Me.tsmChar.Name = "tsmChar"
        Me.tsmChar.Size = New System.Drawing.Size(67, 20)
        Me.tsmChar.Text = "角色设置"
        '
        'tsmTransaction
        '
        Me.tsmTransaction.Name = "tsmTransaction"
        Me.tsmTransaction.Size = New System.Drawing.Size(67, 20)
        Me.tsmTransaction.Text = "用户交易"
        '
        'tsmShopMgmt
        '
        Me.tsmShopMgmt.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmProducts, Me.tsmAddProduct})
        Me.tsmShopMgmt.Name = "tsmShopMgmt"
        Me.tsmShopMgmt.Size = New System.Drawing.Size(67, 20)
        Me.tsmShopMgmt.Text = "商城设置"
        '
        'tsmProducts
        '
        Me.tsmProducts.Name = "tsmProducts"
        Me.tsmProducts.Size = New System.Drawing.Size(152, 22)
        Me.tsmProducts.Text = "商城管理"
        '
        'tsmAddProduct
        '
        Me.tsmAddProduct.Name = "tsmAddProduct"
        Me.tsmAddProduct.Size = New System.Drawing.Size(152, 22)
        Me.tsmAddProduct.Text = "添加产品"
        '
        'tsmShopTransaction
        '
        Me.tsmShopTransaction.Name = "tsmShopTransaction"
        Me.tsmShopTransaction.Size = New System.Drawing.Size(67, 20)
        Me.tsmShopTransaction.Text = "商城交易"
        '
        'frmAdCPMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.cpTab)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_Welcome)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmAdCPMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "后台控制面板"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_Welcome As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cpTab As MdiTabControl.TabControl
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents tsmSetting As ToolStripMenuItem
    Friend WithEvents tsmUser As ToolStripMenuItem
    Friend WithEvents tsmChar As ToolStripMenuItem
    Friend WithEvents tsmTransaction As ToolStripMenuItem
    Friend WithEvents tsmShopMgmt As ToolStripMenuItem
    Friend WithEvents tsmShopTransaction As ToolStripMenuItem
    Friend WithEvents tsmProducts As ToolStripMenuItem
    Friend WithEvents tsmAddProduct As ToolStripMenuItem
End Class
