<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTransaction
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransaction))
        Me.lvHistory = New System.Windows.Forms.ListView()
        Me.chBank = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chAmount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chCurrency = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chChannel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.chStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chReason = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lvHistory
        '
        Me.lvHistory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvHistory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chBank, Me.chID, Me.chAmount, Me.chCurrency, Me.chChannel, Me.chDate, Me.chStatus, Me.chReason})
        Me.lvHistory.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lvHistory.FullRowSelect = True
        Me.lvHistory.GridLines = True
        Me.lvHistory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvHistory.Location = New System.Drawing.Point(12, 12)
        Me.lvHistory.MultiSelect = False
        Me.lvHistory.Name = "lvHistory"
        Me.lvHistory.Size = New System.Drawing.Size(973, 419)
        Me.lvHistory.TabIndex = 32
        Me.lvHistory.UseCompatibleStateImageBehavior = False
        Me.lvHistory.View = System.Windows.Forms.View.Details
        '
        'chBank
        '
        Me.chBank.DisplayIndex = 1
        Me.chBank.Text = "银行"
        Me.chBank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chBank.Width = 180
        '
        'chID
        '
        Me.chID.DisplayIndex = 0
        Me.chID.Text = "ID"
        Me.chID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chID.Width = 100
        '
        'chAmount
        '
        Me.chAmount.Text = "金额"
        Me.chAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chAmount.Width = 100
        '
        'chCurrency
        '
        Me.chCurrency.Text = "货币"
        Me.chCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chCurrency.Width = 50
        '
        'chChannel
        '
        Me.chChannel.Text = "渠道"
        Me.chChannel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chChannel.Width = 100
        '
        'chDate
        '
        Me.chDate.Text = "日期"
        Me.chDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chDate.Width = 150
        '
        'btnSubmit
        '
        Me.btnSubmit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnSubmit.Location = New System.Drawing.Point(880, 437)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(105, 29)
        Me.btnSubmit.TabIndex = 40
        Me.btnSubmit.Text = "提交汇款"
        Me.btnSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'chStatus
        '
        Me.chStatus.Text = "状态"
        Me.chStatus.Width = 100
        '
        'chReason
        '
        Me.chReason.Text = "拒绝理由"
        Me.chReason.Width = 160
        '
        'frmTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(997, 478)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lvHistory)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmTransaction"
        Me.Text = "充值记录"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lvHistory As ListView
    Friend WithEvents chBank As ColumnHeader
    Friend WithEvents chID As ColumnHeader
    Friend WithEvents chAmount As ColumnHeader
    Friend WithEvents chCurrency As ColumnHeader
    Friend WithEvents chChannel As ColumnHeader
    Friend WithEvents chDate As ColumnHeader
    Friend WithEvents btnSubmit As Button
    Friend WithEvents chStatus As ColumnHeader
    Friend WithEvents chReason As ColumnHeader
End Class
