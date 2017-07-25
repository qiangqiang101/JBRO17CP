<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClearRed
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClearRed))
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_PKValue = New System.Windows.Forms.TextBox()
        Me.btn_ClearPK = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_PKUserName = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmb_PKCha = New System.Windows.Forms.ComboBox()
        Me.lbl_PKNote = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label22.Location = New System.Drawing.Point(484, 272)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(44, 21)
        Me.Label22.TabIndex = 57
        Me.Label22.Text = "PK值"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label21.Location = New System.Drawing.Point(247, 272)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(45, 21)
        Me.Label21.TabIndex = 56
        Me.Label21.Text = "清洗:"
        '
        'txt_PKValue
        '
        Me.txt_PKValue.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txt_PKValue.Location = New System.Drawing.Point(298, 269)
        Me.txt_PKValue.MaxLength = 4
        Me.txt_PKValue.Name = "txt_PKValue"
        Me.txt_PKValue.Size = New System.Drawing.Size(180, 29)
        Me.txt_PKValue.TabIndex = 51
        Me.txt_PKValue.Text = "0"
        '
        'btn_ClearPK
        '
        Me.btn_ClearPK.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btn_ClearPK.Location = New System.Drawing.Point(345, 304)
        Me.btn_ClearPK.Name = "btn_ClearPK"
        Me.btn_ClearPK.Size = New System.Drawing.Size(105, 29)
        Me.btn_ClearPK.TabIndex = 53
        Me.btn_ClearPK.Text = "开始漂白"
        Me.btn_ClearPK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ClearPK.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label18.Location = New System.Drawing.Point(247, 237)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 21)
        Me.Label18.TabIndex = 55
        Me.Label18.Text = "角色:"
        '
        'txt_PKUserName
        '
        Me.txt_PKUserName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txt_PKUserName.Location = New System.Drawing.Point(298, 199)
        Me.txt_PKUserName.MaxLength = 14
        Me.txt_PKUserName.Name = "txt_PKUserName"
        Me.txt_PKUserName.ReadOnly = True
        Me.txt_PKUserName.Size = New System.Drawing.Size(219, 29)
        Me.txt_PKUserName.TabIndex = 49
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label20.Location = New System.Drawing.Point(247, 202)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(45, 21)
        Me.Label20.TabIndex = 54
        Me.Label20.Text = "帐号:"
        '
        'cmb_PKCha
        '
        Me.cmb_PKCha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_PKCha.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmb_PKCha.FormattingEnabled = True
        Me.cmb_PKCha.Location = New System.Drawing.Point(298, 234)
        Me.cmb_PKCha.Name = "cmb_PKCha"
        Me.cmb_PKCha.Size = New System.Drawing.Size(219, 29)
        Me.cmb_PKCha.TabIndex = 50
        '
        'lbl_PKNote
        '
        Me.lbl_PKNote.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbl_PKNote.Location = New System.Drawing.Point(12, 9)
        Me.lbl_PKNote.Name = "lbl_PKNote"
        Me.lbl_PKNote.Size = New System.Drawing.Size(786, 51)
        Me.lbl_PKNote.TabIndex = 52
        Me.lbl_PKNote.Text = "1. 请确认你的人物帐号已下线。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2. 每花费 {ClearPKGold} 游戏币可以漂白 1 点PK值，钱将从你身上扣除，清代足够的钱哦！"
        '
        'frmClearRed
        '
        Me.AcceptButton = Me.btn_ClearPK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(810, 478)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txt_PKValue)
        Me.Controls.Add(Me.btn_ClearPK)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txt_PKUserName)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.cmb_PKCha)
        Me.Controls.Add(Me.lbl_PKNote)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmClearRed"
        Me.Text = "红名漂白"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txt_PKValue As TextBox
    Friend WithEvents btn_ClearPK As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_PKUserName As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents cmb_PKCha As ComboBox
    Friend WithEvents lbl_PKNote As Label
End Class
