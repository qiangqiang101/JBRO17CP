<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddPoint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddPoint))
        Me.txt_ChaStRemain = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_SP = New System.Windows.Forms.TextBox()
        Me.txt_HP = New System.Windows.Forms.TextBox()
        Me.txt_Spirit = New System.Windows.Forms.TextBox()
        Me.txt_Dex = New System.Windows.Forms.TextBox()
        Me.txt_Power = New System.Windows.Forms.TextBox()
        Me.btn_AddStat = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_JDUserName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_JDChar = New System.Windows.Forms.ComboBox()
        Me.lbl_JBNote2 = New System.Windows.Forms.Label()
        Me.lbl_JDNote = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_ChaStRemain
        '
        Me.txt_ChaStRemain.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txt_ChaStRemain.Location = New System.Drawing.Point(483, 331)
        Me.txt_ChaStRemain.MaxLength = 4
        Me.txt_ChaStRemain.Name = "txt_ChaStRemain"
        Me.txt_ChaStRemain.ReadOnly = True
        Me.txt_ChaStRemain.Size = New System.Drawing.Size(170, 29)
        Me.txt_ChaStRemain.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label12.Location = New System.Drawing.Point(384, 334)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 21)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "剩余属性点:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(432, 299)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 21)
        Me.Label11.TabIndex = 63
        Me.Label11.Text = "耐力:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(432, 264)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 21)
        Me.Label10.TabIndex = 62
        Me.Label10.Text = "体力:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(130, 334)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 21)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "精神:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(130, 299)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 21)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "敏捷:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(130, 264)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 21)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "力量:"
        '
        'txt_SP
        '
        Me.txt_SP.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txt_SP.Location = New System.Drawing.Point(483, 296)
        Me.txt_SP.MaxLength = 4
        Me.txt_SP.Name = "txt_SP"
        Me.txt_SP.Size = New System.Drawing.Size(170, 29)
        Me.txt_SP.TabIndex = 7
        '
        'txt_HP
        '
        Me.txt_HP.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txt_HP.Location = New System.Drawing.Point(483, 261)
        Me.txt_HP.MaxLength = 4
        Me.txt_HP.Name = "txt_HP"
        Me.txt_HP.Size = New System.Drawing.Size(170, 29)
        Me.txt_HP.TabIndex = 6
        '
        'txt_Spirit
        '
        Me.txt_Spirit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txt_Spirit.Location = New System.Drawing.Point(181, 331)
        Me.txt_Spirit.MaxLength = 4
        Me.txt_Spirit.Name = "txt_Spirit"
        Me.txt_Spirit.Size = New System.Drawing.Size(170, 29)
        Me.txt_Spirit.TabIndex = 5
        '
        'txt_Dex
        '
        Me.txt_Dex.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txt_Dex.Location = New System.Drawing.Point(181, 296)
        Me.txt_Dex.MaxLength = 4
        Me.txt_Dex.Name = "txt_Dex"
        Me.txt_Dex.Size = New System.Drawing.Size(170, 29)
        Me.txt_Dex.TabIndex = 4
        '
        'txt_Power
        '
        Me.txt_Power.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txt_Power.Location = New System.Drawing.Point(181, 261)
        Me.txt_Power.MaxLength = 4
        Me.txt_Power.Name = "txt_Power"
        Me.txt_Power.Size = New System.Drawing.Size(170, 29)
        Me.txt_Power.TabIndex = 3
        '
        'btn_AddStat
        '
        Me.btn_AddStat.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btn_AddStat.Location = New System.Drawing.Point(354, 385)
        Me.btn_AddStat.Name = "btn_AddStat"
        Me.btn_AddStat.Size = New System.Drawing.Size(105, 29)
        Me.btn_AddStat.TabIndex = 9
        Me.btn_AddStat.Text = "确认加点"
        Me.btn_AddStat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_AddStat.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(247, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 21)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "角色:"
        '
        'txt_JDUserName
        '
        Me.txt_JDUserName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txt_JDUserName.Location = New System.Drawing.Point(298, 159)
        Me.txt_JDUserName.MaxLength = 14
        Me.txt_JDUserName.Name = "txt_JDUserName"
        Me.txt_JDUserName.ReadOnly = True
        Me.txt_JDUserName.Size = New System.Drawing.Size(219, 29)
        Me.txt_JDUserName.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(247, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 21)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "帐号:"
        '
        'cmb_JDChar
        '
        Me.cmb_JDChar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_JDChar.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmb_JDChar.FormattingEnabled = True
        Me.cmb_JDChar.Location = New System.Drawing.Point(298, 194)
        Me.cmb_JDChar.Name = "cmb_JDChar"
        Me.cmb_JDChar.Size = New System.Drawing.Size(219, 29)
        Me.cmb_JDChar.TabIndex = 2
        '
        'lbl_JBNote2
        '
        Me.lbl_JBNote2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_JBNote2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbl_JBNote2.Location = New System.Drawing.Point(12, 66)
        Me.lbl_JBNote2.Name = "lbl_JBNote2"
        Me.lbl_JBNote2.Size = New System.Drawing.Size(786, 45)
        Me.lbl_JBNote2.TabIndex = 56
        Me.lbl_JBNote2.Text = "手续费详情：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        加点花费要 {AddStatGold} 游戏币，{AddStatJifen}积分。"
        '
        'lbl_JDNote
        '
        Me.lbl_JDNote.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_JDNote.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbl_JDNote.Location = New System.Drawing.Point(12, 9)
        Me.lbl_JDNote.Name = "lbl_JDNote"
        Me.lbl_JDNote.Size = New System.Drawing.Size(786, 44)
        Me.lbl_JDNote.TabIndex = 55
        Me.lbl_JDNote.Text = "1. 请确认你的人物帐号已下线，否则会白白花费你的游戏币哦。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2. 加点费用将会从你身上扣除，请带足够的游戏币再来哦！"
        '
        'frmAddPoint
        '
        Me.AcceptButton = Me.btn_AddStat
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(810, 478)
        Me.Controls.Add(Me.txt_ChaStRemain)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_SP)
        Me.Controls.Add(Me.txt_HP)
        Me.Controls.Add(Me.txt_Spirit)
        Me.Controls.Add(Me.txt_Dex)
        Me.Controls.Add(Me.txt_Power)
        Me.Controls.Add(Me.btn_AddStat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_JDUserName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmb_JDChar)
        Me.Controls.Add(Me.lbl_JBNote2)
        Me.Controls.Add(Me.lbl_JDNote)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddPoint"
        Me.Text = "在线加点"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_ChaStRemain As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_SP As TextBox
    Friend WithEvents txt_HP As TextBox
    Friend WithEvents txt_Spirit As TextBox
    Friend WithEvents txt_Dex As TextBox
    Friend WithEvents txt_Power As TextBox
    Friend WithEvents btn_AddStat As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_JDUserName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_JDChar As ComboBox
    Friend WithEvents lbl_JBNote2 As Label
    Friend WithEvents lbl_JDNote As Label
End Class
