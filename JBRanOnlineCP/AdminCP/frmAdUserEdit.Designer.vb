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
        Me.btn_Save.Location = New System.Drawing.Point(391, 166)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(105, 29)
        Me.btn_Save.TabIndex = 41
        Me.btn_Save.Text = "保存"
        Me.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
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
        Me.GroupBox1.Size = New System.Drawing.Size(481, 149)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "基本"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(291, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 15)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "积分:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(255, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 15)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "剩余创建数:"
        '
        'txt_UserPoint
        '
        Me.txt_UserPoint.Location = New System.Drawing.Point(331, 111)
        Me.txt_UserPoint.MaxLength = 50
        Me.txt_UserPoint.Name = "txt_UserPoint"
        Me.txt_UserPoint.Size = New System.Drawing.Size(137, 23)
        Me.txt_UserPoint.TabIndex = 8
        '
        'txt_ChaRemain
        '
        Me.txt_ChaRemain.Location = New System.Drawing.Point(331, 82)
        Me.txt_ChaRemain.MaxLength = 4
        Me.txt_ChaRemain.Name = "txt_ChaRemain"
        Me.txt_ChaRemain.Size = New System.Drawing.Size(137, 23)
        Me.txt_ChaRemain.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 15)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "角色名:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 15)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "会员:"
        '
        'txt_ChaName
        '
        Me.txt_ChaName.Location = New System.Drawing.Point(100, 109)
        Me.txt_ChaName.MaxLength = 20
        Me.txt_ChaName.Name = "txt_ChaName"
        Me.txt_ChaName.Size = New System.Drawing.Size(137, 23)
        Me.txt_ChaName.TabIndex = 4
        '
        'txt_UserType
        '
        Me.txt_UserType.Location = New System.Drawing.Point(100, 80)
        Me.txt_UserType.MaxLength = 4
        Me.txt_UserType.Name = "txt_UserType"
        Me.txt_UserType.Size = New System.Drawing.Size(137, 23)
        Me.txt_UserType.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(267, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 15)
        Me.Label11.TabIndex = 68
        Me.Label11.Text = "电子邮箱:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(243, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 15)
        Me.Label12.TabIndex = 67
        Me.Label12.Text = "删除角色密码:"
        '
        'txt_UserEmail
        '
        Me.txt_UserEmail.Location = New System.Drawing.Point(331, 53)
        Me.txt_UserEmail.MaxLength = 50
        Me.txt_UserEmail.Name = "txt_UserEmail"
        Me.txt_UserEmail.Size = New System.Drawing.Size(137, 23)
        Me.txt_UserEmail.TabIndex = 6
        '
        'txt_UserPass2
        '
        Me.txt_UserPass2.Location = New System.Drawing.Point(331, 24)
        Me.txt_UserPass2.MaxLength = 20
        Me.txt_UserPass2.Name = "txt_UserPass2"
        Me.txt_UserPass2.Size = New System.Drawing.Size(137, 23)
        Me.txt_UserPass2.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(60, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 15)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "密码:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(60, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 15)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "帐号:"
        '
        'txt_UserPass
        '
        Me.txt_UserPass.Location = New System.Drawing.Point(100, 51)
        Me.txt_UserPass.MaxLength = 20
        Me.txt_UserPass.Name = "txt_UserPass"
        Me.txt_UserPass.Size = New System.Drawing.Size(137, 23)
        Me.txt_UserPass.TabIndex = 2
        '
        'txt_UserID
        '
        Me.txt_UserID.Location = New System.Drawing.Point(100, 22)
        Me.txt_UserID.MaxLength = 20
        Me.txt_UserID.Name = "txt_UserID"
        Me.txt_UserID.Size = New System.Drawing.Size(137, 23)
        Me.txt_UserID.TabIndex = 1
        '
        'frmAdUserEdit
        '
        Me.AcceptButton = Me.btn_Save
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 207)
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
End Class
