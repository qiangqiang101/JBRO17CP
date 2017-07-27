<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClearPoint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClearPoint))
        Me.btn_ClearStat = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_XDUserName = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmb_CSCha = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_ClearStat
        '
        Me.btn_ClearStat.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btn_ClearStat.Location = New System.Drawing.Point(344, 277)
        Me.btn_ClearStat.Name = "btn_ClearStat"
        Me.btn_ClearStat.Size = New System.Drawing.Size(105, 29)
        Me.btn_ClearStat.TabIndex = 3
        Me.btn_ClearStat.Text = "开始洗点"
        Me.btn_ClearStat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ClearStat.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label14.Location = New System.Drawing.Point(247, 245)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 21)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "角色:"
        '
        'txt_XDUserName
        '
        Me.txt_XDUserName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txt_XDUserName.Location = New System.Drawing.Point(298, 207)
        Me.txt_XDUserName.MaxLength = 14
        Me.txt_XDUserName.Name = "txt_XDUserName"
        Me.txt_XDUserName.ReadOnly = True
        Me.txt_XDUserName.Size = New System.Drawing.Size(219, 29)
        Me.txt_XDUserName.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label15.Location = New System.Drawing.Point(247, 210)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 21)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "帐号:"
        '
        'cmb_CSCha
        '
        Me.cmb_CSCha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CSCha.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmb_CSCha.FormattingEnabled = True
        Me.cmb_CSCha.Location = New System.Drawing.Point(298, 242)
        Me.cmb_CSCha.Name = "cmb_CSCha"
        Me.cmb_CSCha.Size = New System.Drawing.Size(219, 29)
        Me.cmb_CSCha.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label13.Location = New System.Drawing.Point(12, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(750, 48)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "1. 请确认你的人物帐号已下线。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2. 在线洗点只开放给黄金会员。"
        '
        'frmClearPoint
        '
        Me.AcceptButton = Me.btn_ClearStat
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(810, 478)
        Me.Controls.Add(Me.btn_ClearStat)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txt_XDUserName)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cmb_CSCha)
        Me.Controls.Add(Me.Label13)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmClearPoint"
        Me.Text = "在线洗点"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_ClearStat As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_XDUserName As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cmb_CSCha As ComboBox
    Friend WithEvents Label13 As Label
End Class
