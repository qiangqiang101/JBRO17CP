﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.lbl_ForgotPwd = New System.Windows.Forms.LinkLabel()
        Me.btn_Register = New System.Windows.Forms.Button()
        Me.chk_Remember = New System.Windows.Forms.CheckBox()
        Me.btn_Login = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Password = New System.Windows.Forms.TextBox()
        Me.txt_UserName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_ForgotPwd
        '
        Me.lbl_ForgotPwd.AutoSize = True
        Me.lbl_ForgotPwd.Location = New System.Drawing.Point(305, 140)
        Me.lbl_ForgotPwd.Name = "lbl_ForgotPwd"
        Me.lbl_ForgotPwd.Size = New System.Drawing.Size(55, 15)
        Me.lbl_ForgotPwd.TabIndex = 33
        Me.lbl_ForgotPwd.TabStop = True
        Me.lbl_ForgotPwd.Text = "找回密码"
        '
        'btn_Register
        '
        Me.btn_Register.Location = New System.Drawing.Point(304, 168)
        Me.btn_Register.Name = "btn_Register"
        Me.btn_Register.Size = New System.Drawing.Size(105, 29)
        Me.btn_Register.TabIndex = 32
        Me.btn_Register.Text = "注册"
        Me.btn_Register.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Register.UseVisualStyleBackColor = True
        '
        'chk_Remember
        '
        Me.chk_Remember.AutoSize = True
        Me.chk_Remember.Location = New System.Drawing.Point(114, 143)
        Me.chk_Remember.Name = "chk_Remember"
        Me.chk_Remember.Size = New System.Drawing.Size(62, 19)
        Me.chk_Remember.TabIndex = 25
        Me.chk_Remember.Text = "记住我"
        Me.chk_Remember.UseVisualStyleBackColor = True
        '
        'btn_Login
        '
        Me.btn_Login.Location = New System.Drawing.Point(193, 168)
        Me.btn_Login.Name = "btn_Login"
        Me.btn_Login.Size = New System.Drawing.Size(105, 29)
        Me.btn_Login.TabIndex = 26
        Me.btn_Login.Text = "登入"
        Me.btn_Login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Login.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(74, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 15)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "密码:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(74, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 15)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "帐号:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_Password
        '
        Me.txt_Password.Location = New System.Drawing.Point(114, 114)
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.Size = New System.Drawing.Size(246, 23)
        Me.txt_Password.TabIndex = 24
        Me.txt_Password.UseSystemPasswordChar = True
        '
        'txt_UserName
        '
        Me.txt_UserName.Location = New System.Drawing.Point(114, 85)
        Me.txt_UserName.Name = "txt_UserName"
        Me.txt_UserName.Size = New System.Drawing.Size(246, 23)
        Me.txt_UserName.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 37)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "登入"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(36, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 21)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "输入游戏帐号及密码"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(421, 75)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btn_Login
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 209)
        Me.Controls.Add(Me.lbl_ForgotPwd)
        Me.Controls.Add(Me.btn_Register)
        Me.Controls.Add(Me.chk_Remember)
        Me.Controls.Add(Me.btn_Login)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_Password)
        Me.Controls.Add(Me.txt_UserName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "登入"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_ForgotPwd As LinkLabel
    Friend WithEvents btn_Register As Button
    Friend WithEvents chk_Remember As CheckBox
    Friend WithEvents btn_Login As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Password As TextBox
    Friend WithEvents txt_UserName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
