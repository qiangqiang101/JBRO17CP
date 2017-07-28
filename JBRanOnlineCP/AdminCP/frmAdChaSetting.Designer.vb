<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdChaSetting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdChaSetting))
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txt_SearchUser = New System.Windows.Forms.TextBox()
        Me.btn_SearchUser = New System.Windows.Forms.Button()
        Me.lvCha = New System.Windows.Forms.ListView()
        Me.chChaName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chChaNum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chChaGuild = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chChaOnline = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chChaDeleted = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chChaMoney = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "搜索"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(6, 25)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(46, 15)
        Me.Label32.TabIndex = 55
        Me.Label32.Text = "角色名:"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_SearchUser
        '
        Me.txt_SearchUser.Location = New System.Drawing.Point(58, 22)
        Me.txt_SearchUser.MaxLength = 18
        Me.txt_SearchUser.Name = "txt_SearchUser"
        Me.txt_SearchUser.Size = New System.Drawing.Size(207, 23)
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
        'lvCha
        '
        Me.lvCha.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvCha.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chChaName, Me.chChaNum, Me.chChaGuild, Me.chChaOnline, Me.chChaDeleted, Me.chChaMoney})
        Me.lvCha.FullRowSelect = True
        Me.lvCha.GridLines = True
        Me.lvCha.Location = New System.Drawing.Point(12, 79)
        Me.lvCha.Name = "lvCha"
        Me.lvCha.Size = New System.Drawing.Size(649, 382)
        Me.lvCha.TabIndex = 4
        Me.lvCha.UseCompatibleStateImageBehavior = False
        Me.lvCha.View = System.Windows.Forms.View.Details
        '
        'chChaName
        '
        Me.chChaName.DisplayIndex = 1
        Me.chChaName.Text = "角色名"
        Me.chChaName.Width = 200
        '
        'chChaNum
        '
        Me.chChaNum.DisplayIndex = 0
        Me.chChaNum.Text = "角色ID"
        Me.chChaNum.Width = 80
        '
        'chChaGuild
        '
        Me.chChaGuild.Text = "公会名"
        Me.chChaGuild.Width = 80
        '
        'chChaOnline
        '
        Me.chChaOnline.Text = "在线"
        Me.chChaOnline.Width = 80
        '
        'chChaDeleted
        '
        Me.chChaDeleted.Text = "删除"
        Me.chChaDeleted.Width = 80
        '
        'chChaMoney
        '
        Me.chChaMoney.Text = "游戏币"
        Me.chChaMoney.Width = 100
        '
        'frmAdChaSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 473)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.lvCha)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAdChaSetting"
        Me.Text = "角色设置"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label32 As Label
    Friend WithEvents txt_SearchUser As TextBox
    Friend WithEvents btn_SearchUser As Button
    Friend WithEvents lvCha As ListView
    Friend WithEvents chChaName As ColumnHeader
    Friend WithEvents chChaNum As ColumnHeader
    Friend WithEvents chChaGuild As ColumnHeader
    Friend WithEvents chChaOnline As ColumnHeader
    Friend WithEvents chChaDeleted As ColumnHeader
    Friend WithEvents chChaMoney As ColumnHeader
End Class
