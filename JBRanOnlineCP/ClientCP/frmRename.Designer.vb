<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRename
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRename))
        Me.lbl_CNNote = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txt_CNNewName = New System.Windows.Forms.TextBox()
        Me.btn_ChangeName = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txt_CNUserName = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.cmb_CNCha = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lbl_CNNote
        '
        Me.lbl_CNNote.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbl_CNNote.Location = New System.Drawing.Point(12, 9)
        Me.lbl_CNNote.Name = "lbl_CNNote"
        Me.lbl_CNNote.Size = New System.Drawing.Size(786, 88)
        Me.lbl_CNNote.TabIndex = 67
        Me.lbl_CNNote.Text = "1. 请确认你的人物帐号已下线。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2. 改名需要 {ChangeNameGold} 游戏币 {ChangeNameJifen}积分，钱将从你身上扣除，清代足够的" &
    "钱哦！" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3. 角色名不可以含有 - & ; 、 = : # $ "" { } [ ] 的这些字符。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4. 改角色名后下次改角色名需等 {ChangeNameW" &
    "ait} 天。"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(294, 293)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(244, 21)
        Me.Label23.TabIndex = 66
        Me.Label23.Text = "只允许输入4-18个字符或9个汉字"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label24.Location = New System.Drawing.Point(215, 264)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(77, 21)
        Me.Label24.TabIndex = 65
        Me.Label24.Text = "新角色名:"
        '
        'txt_CNNewName
        '
        Me.txt_CNNewName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txt_CNNewName.Location = New System.Drawing.Point(298, 261)
        Me.txt_CNNewName.MaxLength = 18
        Me.txt_CNNewName.Name = "txt_CNNewName"
        Me.txt_CNNewName.Size = New System.Drawing.Size(219, 29)
        Me.txt_CNNewName.TabIndex = 61
        '
        'btn_ChangeName
        '
        Me.btn_ChangeName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btn_ChangeName.Location = New System.Drawing.Point(349, 317)
        Me.btn_ChangeName.Name = "btn_ChangeName"
        Me.btn_ChangeName.Size = New System.Drawing.Size(105, 29)
        Me.btn_ChangeName.TabIndex = 62
        Me.btn_ChangeName.Text = "确认改名"
        Me.btn_ChangeName.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ChangeName.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label25.Location = New System.Drawing.Point(215, 229)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(77, 21)
        Me.Label25.TabIndex = 64
        Me.Label25.Text = "原角色名:"
        '
        'txt_CNUserName
        '
        Me.txt_CNUserName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txt_CNUserName.Location = New System.Drawing.Point(298, 191)
        Me.txt_CNUserName.MaxLength = 14
        Me.txt_CNUserName.Name = "txt_CNUserName"
        Me.txt_CNUserName.ReadOnly = True
        Me.txt_CNUserName.Size = New System.Drawing.Size(219, 29)
        Me.txt_CNUserName.TabIndex = 59
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label26.Location = New System.Drawing.Point(247, 194)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(45, 21)
        Me.Label26.TabIndex = 63
        Me.Label26.Text = "帐号:"
        '
        'cmb_CNCha
        '
        Me.cmb_CNCha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CNCha.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmb_CNCha.FormattingEnabled = True
        Me.cmb_CNCha.Location = New System.Drawing.Point(298, 226)
        Me.cmb_CNCha.Name = "cmb_CNCha"
        Me.cmb_CNCha.Size = New System.Drawing.Size(219, 29)
        Me.cmb_CNCha.TabIndex = 60
        '
        'frmRename
        '
        Me.AcceptButton = Me.btn_ChangeName
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(810, 478)
        Me.Controls.Add(Me.lbl_CNNote)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.txt_CNNewName)
        Me.Controls.Add(Me.btn_ChangeName)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txt_CNUserName)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.cmb_CNCha)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRename"
        Me.Text = "在线改名"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_CNNote As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents txt_CNNewName As TextBox
    Friend WithEvents btn_ChangeName As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents txt_CNUserName As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents cmb_CNCha As ComboBox
End Class
