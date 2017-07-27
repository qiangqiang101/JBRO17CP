<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdOrderDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdOrderDetails))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnReject = New System.Windows.Forms.Button()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblCharName = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnReject)
        Me.GroupBox2.Controls.Add(Me.btnApprove)
        Me.GroupBox2.Location = New System.Drawing.Point(460, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(228, 169)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "操作"
        '
        'btnReject
        '
        Me.btnReject.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReject.Location = New System.Drawing.Point(117, 134)
        Me.btnReject.Name = "btnReject"
        Me.btnReject.Size = New System.Drawing.Size(105, 29)
        Me.btnReject.TabIndex = 61
        Me.btnReject.Text = "拒绝"
        Me.btnReject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReject.UseVisualStyleBackColor = True
        '
        'btnApprove
        '
        Me.btnApprove.Location = New System.Drawing.Point(6, 134)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(105, 29)
        Me.btnApprove.TabIndex = 60
        Me.btnApprove.Text = "允许"
        Me.btnApprove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnApprove.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblPrice)
        Me.GroupBox1.Controls.Add(Me.lblQty)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.lblType)
        Me.GroupBox1.Controls.Add(Me.lblItemName)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lblStatus)
        Me.GroupBox1.Controls.Add(Me.lblDate)
        Me.GroupBox1.Controls.Add(Me.lblCharName)
        Me.GroupBox1.Controls.Add(Me.lblUserName)
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(442, 169)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "玩家信息"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(70, 141)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(31, 15)
        Me.lblStatus.TabIndex = 76
        Me.lblStatus.Text = "新建"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(70, 112)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(65, 15)
        Me.lblDate.TabIndex = 75
        Me.lblDate.Text = "07-01-2017"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCharName
        '
        Me.lblCharName.AutoSize = True
        Me.lblCharName.Location = New System.Drawing.Point(70, 83)
        Me.lblCharName.Name = "lblCharName"
        Me.lblCharName.Size = New System.Drawing.Size(32, 15)
        Me.lblCharName.TabIndex = 74
        Me.lblCharName.Text = "Char"
        Me.lblCharName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(70, 54)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(26, 15)
        Me.lblUserName.TabIndex = 73
        Me.lblUserName.Text = "test"
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(70, 25)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(37, 15)
        Me.lblID.TabIndex = 72
        Me.lblID.Text = "00000"
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 15)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "状态:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 15)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "日期:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 15)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "角色名:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 15)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "ID:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(30, 54)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(34, 15)
        Me.Label32.TabIndex = 56
        Me.Label32.Text = "帐号:"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(266, 54)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(31, 15)
        Me.lblType.TabIndex = 83
        Me.lblType.Text = "其它"
        Me.lblType.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Location = New System.Drawing.Point(266, 25)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(73, 15)
        Me.lblItemName.TabIndex = 82
        Me.lblItemName.Text = "扩音器 (30T)"
        Me.lblItemName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(226, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 15)
        Me.Label11.TabIndex = 81
        Me.Label11.Text = "类型:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(226, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 15)
        Me.Label12.TabIndex = 80
        Me.Label12.Text = "物品:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(266, 112)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(46, 15)
        Me.lblPrice.TabIndex = 91
        Me.lblPrice.Text = "30 积分"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Location = New System.Drawing.Point(266, 83)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(13, 15)
        Me.lblQty.TabIndex = 90
        Me.lblQty.Text = "1"
        Me.lblQty.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(226, 112)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(34, 15)
        Me.Label23.TabIndex = 85
        Me.Label23.Text = "价格:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(226, 83)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(34, 15)
        Me.Label24.TabIndex = 84
        Me.Label24.Text = "数量:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmAdOrderDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 188)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAdOrderDetails"
        Me.Text = "购物ID: {ID}"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnReject As Button
    Friend WithEvents btnApprove As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblCharName As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblID As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblQty As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents lblType As Label
    Friend WithEvents lblItemName As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
End Class
