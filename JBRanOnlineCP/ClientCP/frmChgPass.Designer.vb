<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChgPass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChgPass))
        Me.Label28 = New System.Windows.Forms.Label()
        Me.lbl_CODE = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txt_CPVerification = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txt_CPNewPwd2 = New System.Windows.Forms.TextBox()
        Me.txt_CPNewPwd = New System.Windows.Forms.TextBox()
        Me.txt_CPPassword = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.btn_ChgPwd = New System.Windows.Forms.Button()
        Me.txt_CPUserName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label28.ForeColor = System.Drawing.Color.Red
        Me.Label28.Location = New System.Drawing.Point(302, 227)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(222, 85)
        Me.Label28.TabIndex = 88
        Me.Label28.Text = "双支持字母和数字，不支持特殊符号如 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(* # - & % $)，长度6-14位之间。"
        '
        'lbl_CODE
        '
        Me.lbl_CODE.AutoSize = True
        Me.lbl_CODE.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbl_CODE.Location = New System.Drawing.Point(487, 318)
        Me.lbl_CODE.Name = "lbl_CODE"
        Me.lbl_CODE.Size = New System.Drawing.Size(51, 21)
        Me.lbl_CODE.TabIndex = 86
        Me.lbl_CODE.Text = "CODE"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label34.Location = New System.Drawing.Point(243, 318)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(61, 21)
        Me.Label34.TabIndex = 84
        Me.Label34.Text = "验证码:"
        '
        'txt_CPVerification
        '
        Me.txt_CPVerification.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txt_CPVerification.Location = New System.Drawing.Point(306, 315)
        Me.txt_CPVerification.Name = "txt_CPVerification"
        Me.txt_CPVerification.Size = New System.Drawing.Size(175, 29)
        Me.txt_CPVerification.TabIndex = 89
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label33.Location = New System.Drawing.Point(207, 198)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(93, 21)
        Me.Label33.TabIndex = 81
        Me.Label33.Text = "新密码确认:"
        '
        'txt_CPNewPwd2
        '
        Me.txt_CPNewPwd2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txt_CPNewPwd2.Location = New System.Drawing.Point(306, 195)
        Me.txt_CPNewPwd2.Name = "txt_CPNewPwd2"
        Me.txt_CPNewPwd2.Size = New System.Drawing.Size(219, 29)
        Me.txt_CPNewPwd2.TabIndex = 87
        Me.txt_CPNewPwd2.UseSystemPasswordChar = True
        '
        'txt_CPNewPwd
        '
        Me.txt_CPNewPwd.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txt_CPNewPwd.Location = New System.Drawing.Point(306, 160)
        Me.txt_CPNewPwd.Name = "txt_CPNewPwd"
        Me.txt_CPNewPwd.Size = New System.Drawing.Size(219, 29)
        Me.txt_CPNewPwd.TabIndex = 85
        Me.txt_CPNewPwd.UseSystemPasswordChar = True
        '
        'txt_CPPassword
        '
        Me.txt_CPPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txt_CPPassword.Location = New System.Drawing.Point(306, 125)
        Me.txt_CPPassword.Name = "txt_CPPassword"
        Me.txt_CPPassword.Size = New System.Drawing.Size(219, 29)
        Me.txt_CPPassword.TabIndex = 83
        Me.txt_CPPassword.UseSystemPasswordChar = True
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label30.Location = New System.Drawing.Point(239, 163)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(61, 21)
        Me.Label30.TabIndex = 80
        Me.Label30.Text = "新密码:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label31.Location = New System.Drawing.Point(239, 128)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(61, 21)
        Me.Label31.TabIndex = 79
        Me.Label31.Text = "原密码:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label32.Location = New System.Drawing.Point(255, 93)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(45, 21)
        Me.Label32.TabIndex = 78
        Me.Label32.Text = "帐号:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label29.ForeColor = System.Drawing.Color.Red
        Me.Label29.Location = New System.Drawing.Point(303, 347)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(244, 21)
        Me.Label29.TabIndex = 77
        Me.Label29.Text = "只允许输入4-18个字符或9个汉字"
        '
        'btn_ChgPwd
        '
        Me.btn_ChgPwd.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btn_ChgPwd.Location = New System.Drawing.Point(355, 371)
        Me.btn_ChgPwd.Name = "btn_ChgPwd"
        Me.btn_ChgPwd.Size = New System.Drawing.Size(105, 29)
        Me.btn_ChgPwd.TabIndex = 90
        Me.btn_ChgPwd.Text = "修改密码"
        Me.btn_ChgPwd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ChgPwd.UseVisualStyleBackColor = True
        '
        'txt_CPUserName
        '
        Me.txt_CPUserName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txt_CPUserName.Location = New System.Drawing.Point(306, 90)
        Me.txt_CPUserName.MaxLength = 14
        Me.txt_CPUserName.Name = "txt_CPUserName"
        Me.txt_CPUserName.ReadOnly = True
        Me.txt_CPUserName.Size = New System.Drawing.Size(219, 29)
        Me.txt_CPUserName.TabIndex = 82
        '
        'frmChgPass
        '
        Me.AcceptButton = Me.btn_ChgPwd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(810, 478)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.lbl_CODE)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.txt_CPVerification)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.txt_CPNewPwd2)
        Me.Controls.Add(Me.txt_CPNewPwd)
        Me.Controls.Add(Me.txt_CPPassword)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.btn_ChgPwd)
        Me.Controls.Add(Me.txt_CPUserName)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmChgPass"
        Me.Text = "修改密码"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label28 As Label
    Friend WithEvents lbl_CODE As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents txt_CPVerification As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents txt_CPNewPwd2 As TextBox
    Friend WithEvents txt_CPNewPwd As TextBox
    Friend WithEvents txt_CPPassword As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents btn_ChgPwd As Button
    Friend WithEvents txt_CPUserName As TextBox
End Class
