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
        Me.btn_ChgPwd = New System.Windows.Forms.Button()
        Me.txt_CPUserName = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnUpdateInfo = New System.Windows.Forms.Button()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label28.ForeColor = System.Drawing.Color.Red
        Me.Label28.Location = New System.Drawing.Point(106, 137)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(289, 52)
        Me.Label28.TabIndex = 88
        Me.Label28.Text = "双支持字母和数字，不支持特殊符号如 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(* # - & % $)，长度6-14位之间。"
        '
        'lbl_CODE
        '
        Me.lbl_CODE.AutoSize = True
        Me.lbl_CODE.BackColor = System.Drawing.Color.White
        Me.lbl_CODE.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbl_CODE.ForeColor = System.Drawing.Color.Black
        Me.lbl_CODE.Location = New System.Drawing.Point(342, 196)
        Me.lbl_CODE.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_CODE.Name = "lbl_CODE"
        Me.lbl_CODE.Size = New System.Drawing.Size(51, 21)
        Me.lbl_CODE.TabIndex = 86
        Me.lbl_CODE.Text = "CODE"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label34.Location = New System.Drawing.Point(41, 197)
        Me.Label34.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(61, 21)
        Me.Label34.TabIndex = 84
        Me.Label34.Text = "验证码:"
        '
        'txt_CPVerification
        '
        Me.txt_CPVerification.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txt_CPVerification.Location = New System.Drawing.Point(110, 193)
        Me.txt_CPVerification.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_CPVerification.Name = "txt_CPVerification"
        Me.txt_CPVerification.Size = New System.Drawing.Size(224, 29)
        Me.txt_CPVerification.TabIndex = 9
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label33.Location = New System.Drawing.Point(9, 107)
        Me.Label33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(93, 21)
        Me.Label33.TabIndex = 81
        Me.Label33.Text = "新密码确认:"
        '
        'txt_CPNewPwd2
        '
        Me.txt_CPNewPwd2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txt_CPNewPwd2.Location = New System.Drawing.Point(110, 104)
        Me.txt_CPNewPwd2.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_CPNewPwd2.Name = "txt_CPNewPwd2"
        Me.txt_CPNewPwd2.Size = New System.Drawing.Size(280, 29)
        Me.txt_CPNewPwd2.TabIndex = 8
        Me.txt_CPNewPwd2.UseSystemPasswordChar = True
        '
        'txt_CPNewPwd
        '
        Me.txt_CPNewPwd.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txt_CPNewPwd.Location = New System.Drawing.Point(110, 67)
        Me.txt_CPNewPwd.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_CPNewPwd.Name = "txt_CPNewPwd"
        Me.txt_CPNewPwd.Size = New System.Drawing.Size(280, 29)
        Me.txt_CPNewPwd.TabIndex = 7
        Me.txt_CPNewPwd.UseSystemPasswordChar = True
        '
        'txt_CPPassword
        '
        Me.txt_CPPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txt_CPPassword.Location = New System.Drawing.Point(110, 30)
        Me.txt_CPPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_CPPassword.Name = "txt_CPPassword"
        Me.txt_CPPassword.Size = New System.Drawing.Size(280, 29)
        Me.txt_CPPassword.TabIndex = 6
        Me.txt_CPPassword.UseSystemPasswordChar = True
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label30.Location = New System.Drawing.Point(41, 70)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(61, 21)
        Me.Label30.TabIndex = 80
        Me.Label30.Text = "新密码:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label31.Location = New System.Drawing.Point(41, 33)
        Me.Label31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(61, 21)
        Me.Label31.TabIndex = 79
        Me.Label31.Text = "原密码:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label32.Location = New System.Drawing.Point(62, 33)
        Me.Label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(45, 21)
        Me.Label32.TabIndex = 78
        Me.Label32.Text = "帐号:"
        '
        'btn_ChgPwd
        '
        Me.btn_ChgPwd.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btn_ChgPwd.Location = New System.Drawing.Point(141, 230)
        Me.btn_ChgPwd.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_ChgPwd.Name = "btn_ChgPwd"
        Me.btn_ChgPwd.Size = New System.Drawing.Size(135, 41)
        Me.btn_ChgPwd.TabIndex = 10
        Me.btn_ChgPwd.Text = "修改密码"
        Me.btn_ChgPwd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ChgPwd.UseVisualStyleBackColor = True
        '
        'txt_CPUserName
        '
        Me.txt_CPUserName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txt_CPUserName.Location = New System.Drawing.Point(113, 30)
        Me.txt_CPUserName.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_CPUserName.MaxLength = 14
        Me.txt_CPUserName.Name = "txt_CPUserName"
        Me.txt_CPUserName.ReadOnly = True
        Me.txt_CPUserName.Size = New System.Drawing.Size(280, 29)
        Me.txt_CPUserName.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.btnUpdateInfo)
        Me.GroupBox1.Controls.Add(Me.txtTel)
        Me.GroupBox1.Controls.Add(Me.txt_CPUserName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(401, 280)
        Me.GroupBox1.TabIndex = 91
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "基本资料"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtName.Location = New System.Drawing.Point(113, 66)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(280, 29)
        Me.txtName.TabIndex = 2
        '
        'btnUpdateInfo
        '
        Me.btnUpdateInfo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnUpdateInfo.Location = New System.Drawing.Point(134, 230)
        Me.btnUpdateInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdateInfo.Name = "btnUpdateInfo"
        Me.btnUpdateInfo.Size = New System.Drawing.Size(135, 41)
        Me.btnUpdateInfo.TabIndex = 5
        Me.btnUpdateInfo.Text = "更新资料"
        Me.btnUpdateInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdateInfo.UseVisualStyleBackColor = True
        '
        'txtTel
        '
        Me.txtTel.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtTel.Location = New System.Drawing.Point(113, 136)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(280, 29)
        Me.txtTel.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(30, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 21)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "电话号码:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(30, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 21)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "真实姓名:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(62, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 21)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "电邮:"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtEmail.Location = New System.Drawing.Point(113, 101)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(280, 29)
        Me.txtEmail.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_CPPassword)
        Me.GroupBox2.Controls.Add(Me.btn_ChgPwd)
        Me.GroupBox2.Controls.Add(Me.Label33)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.lbl_CODE)
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.txt_CPVerification)
        Me.GroupBox2.Controls.Add(Me.txt_CPNewPwd)
        Me.GroupBox2.Controls.Add(Me.txt_CPNewPwd2)
        Me.GroupBox2.Location = New System.Drawing.Point(422, 13)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(401, 280)
        Me.GroupBox2.TabIndex = 92
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "修改密码"
        '
        'frmChgPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(840, 328)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmChgPass"
        Me.Text = "账户设置"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents btn_ChgPwd As Button
    Friend WithEvents txt_CPUserName As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnUpdateInfo As Button
    Friend WithEvents txtTel As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
