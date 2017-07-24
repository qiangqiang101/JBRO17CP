<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdUserSetting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdUserSetting))
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txt_SearchUser = New System.Windows.Forms.TextBox()
        Me.btn_SearchUser = New System.Windows.Forms.Button()
        Me.lvUser = New System.Windows.Forms.ListView()
        Me.chUserID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chUserNum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chUserType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chUserLoginState = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chUserPoint = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label32)
        Me.GroupBox5.Controls.Add(Me.txt_SearchUser)
        Me.GroupBox5.Controls.Add(Me.btn_SearchUser)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(388, 61)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "搜索"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(6, 25)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(34, 15)
        Me.Label32.TabIndex = 55
        Me.Label32.Text = "帐号:"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_SearchUser
        '
        Me.txt_SearchUser.Location = New System.Drawing.Point(46, 22)
        Me.txt_SearchUser.MaxLength = 18
        Me.txt_SearchUser.Name = "txt_SearchUser"
        Me.txt_SearchUser.Size = New System.Drawing.Size(219, 23)
        Me.txt_SearchUser.TabIndex = 54
        '
        'btn_SearchUser
        '
        Me.btn_SearchUser.Location = New System.Drawing.Point(271, 18)
        Me.btn_SearchUser.Name = "btn_SearchUser"
        Me.btn_SearchUser.Size = New System.Drawing.Size(105, 29)
        Me.btn_SearchUser.TabIndex = 39
        Me.btn_SearchUser.Text = "搜索"
        Me.btn_SearchUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_SearchUser.UseVisualStyleBackColor = True
        '
        'lvUser
        '
        Me.lvUser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvUser.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chUserID, Me.chUserNum, Me.chUserType, Me.chUserLoginState, Me.chUserPoint})
        Me.lvUser.FullRowSelect = True
        Me.lvUser.GridLines = True
        Me.lvUser.Location = New System.Drawing.Point(12, 79)
        Me.lvUser.Name = "lvUser"
        Me.lvUser.Size = New System.Drawing.Size(753, 376)
        Me.lvUser.TabIndex = 2
        Me.lvUser.UseCompatibleStateImageBehavior = False
        Me.lvUser.View = System.Windows.Forms.View.Details
        '
        'chUserID
        '
        Me.chUserID.DisplayIndex = 1
        Me.chUserID.Text = "User ID"
        Me.chUserID.Width = 200
        '
        'chUserNum
        '
        Me.chUserNum.DisplayIndex = 0
        Me.chUserNum.Text = "User Num"
        Me.chUserNum.Width = 80
        '
        'chUserType
        '
        Me.chUserType.Text = "User Type"
        Me.chUserType.Width = 80
        '
        'chUserLoginState
        '
        Me.chUserLoginState.Text = "User State"
        Me.chUserLoginState.Width = 80
        '
        'chUserPoint
        '
        Me.chUserPoint.Text = "User Point"
        Me.chUserPoint.Width = 80
        '
        'frmAdUserSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 467)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.lvUser)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAdUserSetting"
        Me.Text = "用户设置"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label32 As Label
    Friend WithEvents txt_SearchUser As TextBox
    Friend WithEvents btn_SearchUser As Button
    Friend WithEvents lvUser As ListView
    Friend WithEvents chUserID As ColumnHeader
    Friend WithEvents chUserNum As ColumnHeader
    Friend WithEvents chUserType As ColumnHeader
    Friend WithEvents chUserLoginState As ColumnHeader
    Friend WithEvents chUserPoint As ColumnHeader
End Class
