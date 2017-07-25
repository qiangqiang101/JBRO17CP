<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTopup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTopup))
        Me.lbl_RBNote1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_TUUserName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_Bank = New System.Windows.Forms.ComboBox()
        Me.txt_Amount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_Channel = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_RefNo = New System.Windows.Forms.TextBox()
        Me.cmb_Dollar = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lbl_RBNote1
        '
        Me.lbl_RBNote1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbl_RBNote1.Location = New System.Drawing.Point(12, 77)
        Me.lbl_RBNote1.Name = "lbl_RBNote1"
        Me.lbl_RBNote1.Size = New System.Drawing.Size(786, 193)
        Me.lbl_RBNote1.TabIndex = 33
        Me.lbl_RBNote1.Text = resources.GetString("lbl_RBNote1.Text")
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(786, 68)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "本服秉着公平公正的原则向广大玩家开放赞助装备，以维持伺服器正常运行，所有贩售之装备在游戏中均能获得，视个人能力赞助，觉得贵觉得负担不起不要赞助就好，本服不勉强任何" &
    "人赞助，就算您完全没赞助本服，也一样能在本服畅玩游戏，也不会因为有赞助或 没赞助会有差别待遇，所有会员或非会员我们都将一视同仁。"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 292)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(786, 68)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "<<< 赞助方式 >>>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        1马币=10积分" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        1新币=31积分"
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnSubmit.Location = New System.Drawing.Point(376, 538)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(105, 29)
        Me.btnSubmit.TabIndex = 7
        Me.btnSubmit.Text = "提交"
        Me.btnSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(269, 401)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 21)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "银行:"
        '
        'txt_TUUserName
        '
        Me.txt_TUUserName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txt_TUUserName.Location = New System.Drawing.Point(320, 363)
        Me.txt_TUUserName.MaxLength = 14
        Me.txt_TUUserName.Name = "txt_TUUserName"
        Me.txt_TUUserName.ReadOnly = True
        Me.txt_TUUserName.Size = New System.Drawing.Size(219, 29)
        Me.txt_TUUserName.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(269, 366)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 21)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "帐号:"
        '
        'cmb_Bank
        '
        Me.cmb_Bank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Bank.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmb_Bank.FormattingEnabled = True
        Me.cmb_Bank.Items.AddRange(New Object() {"Maybank", "CIMB Bank", "Public Bank", "Hong Leong Bank"})
        Me.cmb_Bank.Location = New System.Drawing.Point(320, 398)
        Me.cmb_Bank.Name = "cmb_Bank"
        Me.cmb_Bank.Size = New System.Drawing.Size(219, 29)
        Me.cmb_Bank.TabIndex = 2
        '
        'txt_Amount
        '
        Me.txt_Amount.Location = New System.Drawing.Point(320, 433)
        Me.txt_Amount.Name = "txt_Amount"
        Me.txt_Amount.Size = New System.Drawing.Size(148, 29)
        Me.txt_Amount.TabIndex = 3
        Me.txt_Amount.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(269, 436)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 21)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "金额:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(269, 471)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 21)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "渠道:"
        '
        'cmb_Channel
        '
        Me.cmb_Channel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Channel.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmb_Channel.FormattingEnabled = True
        Me.cmb_Channel.Items.AddRange(New Object() {"CDM", "ATM", "在线转账"})
        Me.cmb_Channel.Location = New System.Drawing.Point(320, 468)
        Me.cmb_Channel.Name = "cmb_Channel"
        Me.cmb_Channel.Size = New System.Drawing.Size(219, 29)
        Me.cmb_Channel.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(170, 506)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 21)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "参考号码/SEQ号码:"
        '
        'txt_RefNo
        '
        Me.txt_RefNo.Location = New System.Drawing.Point(320, 503)
        Me.txt_RefNo.Name = "txt_RefNo"
        Me.txt_RefNo.Size = New System.Drawing.Size(219, 29)
        Me.txt_RefNo.TabIndex = 6
        '
        'cmb_Dollar
        '
        Me.cmb_Dollar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Dollar.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmb_Dollar.FormattingEnabled = True
        Me.cmb_Dollar.Items.AddRange(New Object() {"马币", "新币"})
        Me.cmb_Dollar.Location = New System.Drawing.Point(474, 433)
        Me.cmb_Dollar.Name = "cmb_Dollar"
        Me.cmb_Dollar.Size = New System.Drawing.Size(65, 29)
        Me.cmb_Dollar.TabIndex = 4
        '
        'frmTopup
        '
        Me.AcceptButton = Me.btnSubmit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(810, 595)
        Me.Controls.Add(Me.cmb_Dollar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_RefNo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmb_Channel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_Amount)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_TUUserName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmb_Bank)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_RBNote1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmTopup"
        Me.Text = "在线充值"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_RBNote1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_TUUserName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmb_Bank As ComboBox
    Friend WithEvents txt_Amount As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_Channel As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_RefNo As TextBox
    Friend WithEvents cmb_Dollar As ComboBox
End Class
