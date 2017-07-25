<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReborn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReborn))
        Me.btnReborn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_RBUserName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_RBChar = New System.Windows.Forms.ComboBox()
        Me.lbl_RBNote3 = New System.Windows.Forms.Label()
        Me.lbl_RBNote2 = New System.Windows.Forms.Label()
        Me.lbl_RBNote1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnReborn
        '
        Me.btnReborn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnReborn.Location = New System.Drawing.Point(351, 383)
        Me.btnReborn.Name = "btnReborn"
        Me.btnReborn.Size = New System.Drawing.Size(105, 29)
        Me.btnReborn.TabIndex = 31
        Me.btnReborn.Text = "确认转生"
        Me.btnReborn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReborn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(253, 351)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 21)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "角色:"
        '
        'txt_RBUserName
        '
        Me.txt_RBUserName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txt_RBUserName.Location = New System.Drawing.Point(304, 313)
        Me.txt_RBUserName.MaxLength = 14
        Me.txt_RBUserName.Name = "txt_RBUserName"
        Me.txt_RBUserName.ReadOnly = True
        Me.txt_RBUserName.Size = New System.Drawing.Size(219, 29)
        Me.txt_RBUserName.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(253, 316)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 21)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "帐号:"
        '
        'cmb_RBChar
        '
        Me.cmb_RBChar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_RBChar.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmb_RBChar.FormattingEnabled = True
        Me.cmb_RBChar.Location = New System.Drawing.Point(304, 348)
        Me.cmb_RBChar.Name = "cmb_RBChar"
        Me.cmb_RBChar.Size = New System.Drawing.Size(219, 29)
        Me.cmb_RBChar.TabIndex = 30
        '
        'lbl_RBNote3
        '
        Me.lbl_RBNote3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbl_RBNote3.Location = New System.Drawing.Point(9, 184)
        Me.lbl_RBNote3.Name = "lbl_RBNote3"
        Me.lbl_RBNote3.Size = New System.Drawing.Size(789, 86)
        Me.lbl_RBNote3.TabIndex = 34
        Me.lbl_RBNote3.Text = "手续费详情：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        初级转生 {PrimaryGold} 游戏币，{PrimaryPoint} 积分。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        中级转生 {Secondar" &
    "yGold} 游戏币，{SecondaryPoint} 积分。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        高级转生 {AdvanceGold} 游戏币，{AdvancePoint} 积" &
    "分。"
        '
        'lbl_RBNote2
        '
        Me.lbl_RBNote2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbl_RBNote2.Location = New System.Drawing.Point(12, 95)
        Me.lbl_RBNote2.Name = "lbl_RBNote2"
        Me.lbl_RBNote2.Size = New System.Drawing.Size(786, 89)
        Me.lbl_RBNote2.TabIndex = 33
        Me.lbl_RBNote2.Text = "转生级数需求：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        初级转生 {PrimaryReborn} 等级，每转一次增加 {PrimaryStat} 属性点。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        中级转生 " &
    "{SecondaryReborn} 等级，每转一次增加 {SecondaryStat} 属性点。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        高级转生 {AdvanceReborn} 等" &
    "级，每转一次增加 {AdvanceStat} 属性点。"
        '
        'lbl_RBNote1
        '
        Me.lbl_RBNote1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbl_RBNote1.Location = New System.Drawing.Point(12, 9)
        Me.lbl_RBNote1.Name = "lbl_RBNote1"
        Me.lbl_RBNote1.Size = New System.Drawing.Size(786, 86)
        Me.lbl_RBNote1.TabIndex = 32
        Me.lbl_RBNote1.Text = "1. 最多可以转生 {Reborn} 次。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2. 目前提供高级转生、中级转生、初级转生。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3. 转生前请先确认帐号内的角色已经下线。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4. 转生费用将会从你" &
    "身上扣除，请带足够的游戏币和积分再来哦！"
        '
        'frmReborn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(810, 478)
        Me.Controls.Add(Me.btnReborn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_RBUserName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmb_RBChar)
        Me.Controls.Add(Me.lbl_RBNote3)
        Me.Controls.Add(Me.lbl_RBNote2)
        Me.Controls.Add(Me.lbl_RBNote1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReborn"
        Me.Text = "在线转生"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReborn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_RBUserName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmb_RBChar As ComboBox
    Friend WithEvents lbl_RBNote3 As Label
    Friend WithEvents lbl_RBNote2 As Label
    Friend WithEvents lbl_RBNote1 As Label
End Class
