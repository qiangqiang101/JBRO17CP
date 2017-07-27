<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdShopOrder
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdShopOrder))
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txt_SearchUser = New System.Windows.Forms.TextBox()
        Me.btn_SearchUser = New System.Windows.Forms.Button()
        Me.lvUser = New System.Windows.Forms.ListView()
        Me.chUserName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chCharName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chItemName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chQty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chCurrency = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
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
        Me.GroupBox5.Size = New System.Drawing.Size(383, 61)
        Me.GroupBox5.TabIndex = 7
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
        Me.lvUser.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chUserName, Me.chID, Me.chCharName, Me.chItemName, Me.chType, Me.chQty, Me.chPrice, Me.chCurrency, Me.chDate, Me.chStatus})
        Me.lvUser.FullRowSelect = True
        Me.lvUser.GridLines = True
        Me.lvUser.Location = New System.Drawing.Point(12, 79)
        Me.lvUser.Name = "lvUser"
        Me.lvUser.Size = New System.Drawing.Size(909, 410)
        Me.lvUser.TabIndex = 6
        Me.lvUser.UseCompatibleStateImageBehavior = False
        Me.lvUser.View = System.Windows.Forms.View.Details
        '
        'chUserName
        '
        Me.chUserName.DisplayIndex = 1
        Me.chUserName.Text = "账号"
        Me.chUserName.Width = 120
        '
        'chID
        '
        Me.chID.DisplayIndex = 0
        Me.chID.Text = "ID"
        Me.chID.Width = 80
        '
        'chCharName
        '
        Me.chCharName.Text = "角色名"
        Me.chCharName.Width = 120
        '
        'chItemName
        '
        Me.chItemName.Text = "产品"
        Me.chItemName.Width = 120
        '
        'chType
        '
        Me.chType.Text = "类型"
        '
        'chQty
        '
        Me.chQty.Text = "数量"
        '
        'chPrice
        '
        Me.chPrice.Text = "金额"
        Me.chPrice.Width = 80
        '
        'chCurrency
        '
        Me.chCurrency.Text = "货币"
        '
        'chDate
        '
        Me.chDate.Text = "日期"
        Me.chDate.Width = 100
        '
        'chStatus
        '
        Me.chStatus.Text = "状态"
        Me.chStatus.Width = 80
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 30000
        '
        'frmAdShopOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 501)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.lvUser)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAdShopOrder"
        Me.Text = "商城交易"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label32 As Label
    Friend WithEvents txt_SearchUser As TextBox
    Friend WithEvents btn_SearchUser As Button
    Friend WithEvents lvUser As ListView
    Friend WithEvents chUserName As ColumnHeader
    Friend WithEvents chID As ColumnHeader
    Friend WithEvents chCharName As ColumnHeader
    Friend WithEvents chItemName As ColumnHeader
    Friend WithEvents chCurrency As ColumnHeader
    Friend WithEvents chType As ColumnHeader
    Friend WithEvents chDate As ColumnHeader
    Friend WithEvents chStatus As ColumnHeader
    Friend WithEvents chPrice As ColumnHeader
    Friend WithEvents chQty As ColumnHeader
    Friend WithEvents Timer1 As Timer
End Class
