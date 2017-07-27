<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFgtPwd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFgtPwd))
        Me.btn_Login = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_UserName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_CODE = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_Verification = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Login
        '
        Me.btn_Login.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btn_Login.Location = New System.Drawing.Point(307, 191)
        Me.btn_Login.Name = "btn_Login"
        Me.btn_Login.Size = New System.Drawing.Size(105, 29)
        Me.btn_Login.TabIndex = 3
        Me.btn_Login.Text = "找回密码"
        Me.btn_Login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Login.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(63, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 21)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "帐号:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_UserName
        '
        Me.txt_UserName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txt_UserName.Location = New System.Drawing.Point(114, 107)
        Me.txt_UserName.Name = "txt_UserName"
        Me.txt_UserName.Size = New System.Drawing.Size(246, 29)
        Me.txt_UserName.TabIndex = 1
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
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "找回密码"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(36, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 21)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "输入游戏帐号并找回密码"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(424, 75)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'lbl_CODE
        '
        Me.lbl_CODE.AutoSize = True
        Me.lbl_CODE.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbl_CODE.Location = New System.Drawing.Point(309, 145)
        Me.lbl_CODE.Name = "lbl_CODE"
        Me.lbl_CODE.Size = New System.Drawing.Size(51, 21)
        Me.lbl_CODE.TabIndex = 66
        Me.lbl_CODE.Text = "CODE"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label13.Location = New System.Drawing.Point(46, 145)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 21)
        Me.Label13.TabIndex = 65
        Me.Label13.Text = "验证码:"
        '
        'txt_Verification
        '
        Me.txt_Verification.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txt_Verification.Location = New System.Drawing.Point(114, 142)
        Me.txt_Verification.Name = "txt_Verification"
        Me.txt_Verification.Size = New System.Drawing.Size(189, 29)
        Me.txt_Verification.TabIndex = 2
        '
        'frmFgtPwd
        '
        Me.AcceptButton = Me.btn_Login
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 232)
        Me.Controls.Add(Me.lbl_CODE)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_Verification)
        Me.Controls.Add(Me.btn_Login)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_UserName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFgtPwd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "找回密码"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Login As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_UserName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_CODE As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_Verification As TextBox
End Class
