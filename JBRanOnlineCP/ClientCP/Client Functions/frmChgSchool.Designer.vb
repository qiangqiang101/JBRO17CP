<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChgSchool
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChgSchool))
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmb_ZXSchool = New System.Windows.Forms.ComboBox()
        Me.btn_ChangeSchool = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_ZXUserName = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmb_ZXCha = New System.Windows.Forms.ComboBox()
        Me.lbl_ZXNote = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label19.Location = New System.Drawing.Point(247, 272)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(45, 21)
        Me.Label19.TabIndex = 49
        Me.Label19.Text = "学院:"
        '
        'cmb_ZXSchool
        '
        Me.cmb_ZXSchool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ZXSchool.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmb_ZXSchool.FormattingEnabled = True
        Me.cmb_ZXSchool.Location = New System.Drawing.Point(298, 269)
        Me.cmb_ZXSchool.Name = "cmb_ZXSchool"
        Me.cmb_ZXSchool.Size = New System.Drawing.Size(219, 29)
        Me.cmb_ZXSchool.TabIndex = 3
        '
        'btn_ChangeSchool
        '
        Me.btn_ChangeSchool.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btn_ChangeSchool.Location = New System.Drawing.Point(349, 304)
        Me.btn_ChangeSchool.Name = "btn_ChangeSchool"
        Me.btn_ChangeSchool.Size = New System.Drawing.Size(105, 29)
        Me.btn_ChangeSchool.TabIndex = 4
        Me.btn_ChangeSchool.Text = "确认转学"
        Me.btn_ChangeSchool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ChangeSchool.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label16.Location = New System.Drawing.Point(247, 237)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 21)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "角色:"
        '
        'txt_ZXUserName
        '
        Me.txt_ZXUserName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txt_ZXUserName.Location = New System.Drawing.Point(298, 199)
        Me.txt_ZXUserName.MaxLength = 14
        Me.txt_ZXUserName.Name = "txt_ZXUserName"
        Me.txt_ZXUserName.ReadOnly = True
        Me.txt_ZXUserName.Size = New System.Drawing.Size(219, 29)
        Me.txt_ZXUserName.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label17.Location = New System.Drawing.Point(247, 202)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 21)
        Me.Label17.TabIndex = 47
        Me.Label17.Text = "帐号:"
        '
        'cmb_ZXCha
        '
        Me.cmb_ZXCha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ZXCha.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmb_ZXCha.FormattingEnabled = True
        Me.cmb_ZXCha.Location = New System.Drawing.Point(298, 234)
        Me.cmb_ZXCha.Name = "cmb_ZXCha"
        Me.cmb_ZXCha.Size = New System.Drawing.Size(219, 29)
        Me.cmb_ZXCha.TabIndex = 2
        '
        'lbl_ZXNote
        '
        Me.lbl_ZXNote.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbl_ZXNote.Location = New System.Drawing.Point(12, 9)
        Me.lbl_ZXNote.Name = "lbl_ZXNote"
        Me.lbl_ZXNote.Size = New System.Drawing.Size(786, 50)
        Me.lbl_ZXNote.TabIndex = 46
        Me.lbl_ZXNote.Text = "1. 请确认你的人物帐号已下线。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2. 转学需要 {ChangeSchoolGold} 游戏币，{ChangeSchoolJifen} 积分，钱将从你身上扣除，" &
    "清代足够的钱哦！"
        '
        'frmChgSchool
        '
        Me.AcceptButton = Me.btn_ChangeSchool
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(810, 478)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.cmb_ZXSchool)
        Me.Controls.Add(Me.btn_ChangeSchool)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txt_ZXUserName)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.cmb_ZXCha)
        Me.Controls.Add(Me.lbl_ZXNote)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmChgSchool"
        Me.Text = "在线转学"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label19 As Label
    Friend WithEvents cmb_ZXSchool As ComboBox
    Friend WithEvents btn_ChangeSchool As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_ZXUserName As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents cmb_ZXCha As ComboBox
    Friend WithEvents lbl_ZXNote As Label
End Class
