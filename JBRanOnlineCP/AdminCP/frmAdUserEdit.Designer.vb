<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdUserEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdUserEdit))
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbBanned = New System.Windows.Forms.CheckBox()
        Me.btnMD5_2 = New System.Windows.Forms.Button()
        Me.btnMD5 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_UserPoint = New System.Windows.Forms.TextBox()
        Me.txt_ChaRemain = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_ChaName = New System.Windows.Forms.TextBox()
        Me.txt_UserType = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_UserEmail = New System.Windows.Forms.TextBox()
        Me.txt_UserPass2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_UserPass = New System.Windows.Forms.TextBox()
        Me.txt_UserID = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Save
        '
        Me.btn_Save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Save.Location = New System.Drawing.Point(470, 186)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(105, 29)
        Me.btn_Save.TabIndex = 20
        Me.btn_Save.Text = "保存"
        Me.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbBanned)
        Me.GroupBox1.Controls.Add(Me.btnMD5_2)
        Me.GroupBox1.Controls.Add(Me.btnMD5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_UserPoint)
        Me.GroupBox1.Controls.Add(Me.txt_ChaRemain)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_ChaName)
        Me.GroupBox1.Controls.Add(Me.txt_UserType)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txt_UserEmail)
        Me.GroupBox1.Controls.Add(Me.txt_UserPass2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_UserPass)
        Me.GroupBox1.Controls.Add(Me.txt_UserID)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(561, 169)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "基本"
        '
        'cbBanned
        '
        Me.cbBanned.AutoSize = True
        Me.cbBanned.Location = New System.Drawing.Point(58, 140)
        Me.cbBanned.Name = "cbBanned"
        Me.cbBanned.Size = New System.Drawing.Size(74, 19)
        Me.cbBanned.TabIndex = 6
        Me.cbBanned.Text = "禁止帐号"
        Me.cbBanned.UseVisualStyleBackColor = True
        '
        'btnMD5_2
        '
        Me.btnMD5_2.Location = New System.Drawing.Point(499, 23)
        Me.btnMD5_2.Name = "btnMD5_2"
        Me.btnMD5_2.Size = New System.Drawing.Size(53, 23)
        Me.btnMD5_2.TabIndex = 8
        Me.btnMD5_2.Text = "MD5"
        Me.btnMD5_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMD5_2.UseVisualStyleBackColor = True
        '
        'btnMD5
        '
        Me.btnMD5.Location = New System.Drawing.Point(205, 53)
        Me.btnMD5.Name = "btnMD5"
        Me.btnMD5.Size = New System.Drawing.Size(53, 23)
        Me.btnMD5.TabIndex = 3
        Me.btnMD5.Text = "MD5"
        Me.btnMD5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMD5.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(312, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 15)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "积分:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(276, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 15)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "剩余创建数:"
        '
        'txt_UserPoint
        '
        Me.txt_UserPoint.Location = New System.Drawing.Point(352, 111)
        Me.txt_UserPoint.MaxLength = 50
        Me.txt_UserPoint.Name = "txt_UserPoint"
        Me.txt_UserPoint.Size = New System.Drawing.Size(200, 23)
        Me.txt_UserPoint.TabIndex = 11
        '
        'txt_ChaRemain
        '
        Me.txt_ChaRemain.Location = New System.Drawing.Point(352, 82)
        Me.txt_ChaRemain.MaxLength = 4
        Me.txt_ChaRemain.Name = "txt_ChaRemain"
        Me.txt_ChaRemain.Size = New System.Drawing.Size(200, 23)
        Me.txt_ChaRemain.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 15)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "角色名:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 15)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "会员:"
        '
        'txt_ChaName
        '
        Me.txt_ChaName.Location = New System.Drawing.Point(58, 111)
        Me.txt_ChaName.MaxLength = 20
        Me.txt_ChaName.Name = "txt_ChaName"
        Me.txt_ChaName.Size = New System.Drawing.Size(200, 23)
        Me.txt_ChaName.TabIndex = 5
        '
        'txt_UserType
        '
        Me.txt_UserType.Location = New System.Drawing.Point(58, 82)
        Me.txt_UserType.MaxLength = 4
        Me.txt_UserType.Name = "txt_UserType"
        Me.txt_UserType.Size = New System.Drawing.Size(200, 23)
        Me.txt_UserType.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(288, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 15)
        Me.Label11.TabIndex = 68
        Me.Label11.Text = "电子邮箱:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(264, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 15)
        Me.Label12.TabIndex = 67
        Me.Label12.Text = "删除角色密码:"
        '
        'txt_UserEmail
        '
        Me.txt_UserEmail.Location = New System.Drawing.Point(352, 53)
        Me.txt_UserEmail.MaxLength = 50
        Me.txt_UserEmail.Name = "txt_UserEmail"
        Me.txt_UserEmail.Size = New System.Drawing.Size(200, 23)
        Me.txt_UserEmail.TabIndex = 9
        '
        'txt_UserPass2
        '
        Me.txt_UserPass2.Location = New System.Drawing.Point(352, 24)
        Me.txt_UserPass2.MaxLength = 20
        Me.txt_UserPass2.Name = "txt_UserPass2"
        Me.txt_UserPass2.Size = New System.Drawing.Size(141, 23)
        Me.txt_UserPass2.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 15)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "密码:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 15)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "帐号:"
        '
        'txt_UserPass
        '
        Me.txt_UserPass.Location = New System.Drawing.Point(58, 53)
        Me.txt_UserPass.MaxLength = 20
        Me.txt_UserPass.Name = "txt_UserPass"
        Me.txt_UserPass.Size = New System.Drawing.Size(141, 23)
        Me.txt_UserPass.TabIndex = 2
        '
        'txt_UserID
        '
        Me.txt_UserID.Location = New System.Drawing.Point(58, 24)
        Me.txt_UserID.MaxLength = 20
        Me.txt_UserID.Name = "txt_UserID"
        Me.txt_UserID.Size = New System.Drawing.Size(200, 23)
        Me.txt_UserID.TabIndex = 1
        '
        'frmAdUserEdit
        '
        Me.AcceptButton = Me.btn_Save
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 227)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAdUserEdit"
        Me.Text = "{username} - 用户设置"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_Save As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_UserPoint As TextBox
    Friend WithEvents txt_ChaRemain As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_ChaName As TextBox
    Friend WithEvents txt_UserType As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_UserEmail As TextBox
    Friend WithEvents txt_UserPass2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_UserPass As TextBox
    Friend WithEvents txt_UserID As TextBox
    Friend WithEvents btnMD5_2 As Button
    Friend WithEvents btnMD5 As Button
    Friend WithEvents cbBanned As CheckBox
End Class
