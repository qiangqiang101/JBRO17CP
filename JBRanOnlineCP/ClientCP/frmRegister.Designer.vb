<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegister))
        Me.btn_Check = New System.Windows.Forms.Button()
        Me.lbl_CODE = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_Verification = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_2ndPass1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_2ndPass2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_Email = New System.Windows.Forms.TextBox()
        Me.txt_Pass2 = New System.Windows.Forms.TextBox()
        Me.txt_Pass1 = New System.Windows.Forms.TextBox()
        Me.txt_UserName = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Check
        '
        Me.btn_Check.Location = New System.Drawing.Point(350, 122)
        Me.btn_Check.Name = "btn_Check"
        Me.btn_Check.Size = New System.Drawing.Size(70, 23)
        Me.btn_Check.TabIndex = 40
        Me.btn_Check.Text = "检测帐号"
        Me.btn_Check.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Check.UseVisualStyleBackColor = True
        '
        'lbl_CODE
        '
        Me.lbl_CODE.AutoSize = True
        Me.lbl_CODE.Location = New System.Drawing.Point(382, 427)
        Me.lbl_CODE.Name = "lbl_CODE"
        Me.lbl_CODE.Size = New System.Drawing.Size(38, 15)
        Me.lbl_CODE.TabIndex = 63
        Me.lbl_CODE.Text = "CODE"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(122, 427)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 15)
        Me.Label13.TabIndex = 62
        Me.Label13.Text = "验证码:"
        '
        'txt_Verification
        '
        Me.txt_Verification.Location = New System.Drawing.Point(174, 424)
        Me.txt_Verification.Name = "txt_Verification"
        Me.txt_Verification.Size = New System.Drawing.Size(202, 23)
        Me.txt_Verification.TabIndex = 46
        '
        'Label12
        '
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(171, 388)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(249, 33)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "双支持字母和数字，不支持特殊符号如 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(* # - & % $)，长度6-14位之间。"
        '
        'Label11
        '
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(171, 306)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(249, 24)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "请输入邮箱以便找回密码！"
        '
        'Label10
        '
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(171, 239)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(249, 33)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "双支持字母和数字，不支持特殊符号如 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(* # - & % $)，长度6-14位之间。"
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(171, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(249, 33)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "双支持字母和数字，不支持特殊符号如 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(* # - & % $)，长度6-14位之间。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(86, 336)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 15)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "删除角色密码:"
        '
        'txt_2ndPass1
        '
        Me.txt_2ndPass1.Location = New System.Drawing.Point(174, 333)
        Me.txt_2ndPass1.MaxLength = 14
        Me.txt_2ndPass1.Name = "txt_2ndPass1"
        Me.txt_2ndPass1.Size = New System.Drawing.Size(246, 23)
        Me.txt_2ndPass1.TabIndex = 44
        Me.txt_2ndPass1.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 365)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 15)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "删除角色密码确认:"
        '
        'txt_2ndPass2
        '
        Me.txt_2ndPass2.Location = New System.Drawing.Point(174, 362)
        Me.txt_2ndPass2.MaxLength = 14
        Me.txt_2ndPass2.Name = "txt_2ndPass2"
        Me.txt_2ndPass2.Size = New System.Drawing.Size(246, 23)
        Me.txt_2ndPass2.TabIndex = 45
        Me.txt_2ndPass2.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 37)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "帐号注册"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(36, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 21)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "注册一个新帐号"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(517, 75)
        Me.PictureBox1.TabIndex = 53
        Me.PictureBox1.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(400, 505)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(105, 29)
        Me.btnCancel.TabIndex = 48
        Me.btnCancel.Text = "取消"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(110, 283)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 15)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "电子邮箱:"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(289, 505)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(105, 29)
        Me.btnAdd.TabIndex = 47
        Me.btnAdd.Text = "提交"
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(110, 216)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 15)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "密码确认:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(134, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 15)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "密码:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(134, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 15)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "帐号:"
        '
        'txt_Email
        '
        Me.txt_Email.Location = New System.Drawing.Point(174, 280)
        Me.txt_Email.Name = "txt_Email"
        Me.txt_Email.Size = New System.Drawing.Size(246, 23)
        Me.txt_Email.TabIndex = 43
        '
        'txt_Pass2
        '
        Me.txt_Pass2.Location = New System.Drawing.Point(174, 213)
        Me.txt_Pass2.MaxLength = 14
        Me.txt_Pass2.Name = "txt_Pass2"
        Me.txt_Pass2.Size = New System.Drawing.Size(246, 23)
        Me.txt_Pass2.TabIndex = 42
        Me.txt_Pass2.UseSystemPasswordChar = True
        '
        'txt_Pass1
        '
        Me.txt_Pass1.Location = New System.Drawing.Point(174, 184)
        Me.txt_Pass1.MaxLength = 14
        Me.txt_Pass1.Name = "txt_Pass1"
        Me.txt_Pass1.Size = New System.Drawing.Size(246, 23)
        Me.txt_Pass1.TabIndex = 41
        Me.txt_Pass1.UseSystemPasswordChar = True
        '
        'txt_UserName
        '
        Me.txt_UserName.Location = New System.Drawing.Point(174, 122)
        Me.txt_UserName.MaxLength = 14
        Me.txt_UserName.Name = "txt_UserName"
        Me.txt_UserName.Size = New System.Drawing.Size(170, 23)
        Me.txt_UserName.TabIndex = 39
        '
        'frmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 546)
        Me.Controls.Add(Me.btn_Check)
        Me.Controls.Add(Me.lbl_CODE)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_Verification)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_2ndPass1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_2ndPass2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_Email)
        Me.Controls.Add(Me.txt_Pass2)
        Me.Controls.Add(Me.txt_Pass1)
        Me.Controls.Add(Me.txt_UserName)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "帐号注册"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Check As Button
    Friend WithEvents lbl_CODE As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_Verification As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_2ndPass1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_2ndPass2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_Email As TextBox
    Friend WithEvents txt_Pass2 As TextBox
    Friend WithEvents txt_Pass1 As TextBox
    Friend WithEvents txt_UserName As TextBox
End Class
