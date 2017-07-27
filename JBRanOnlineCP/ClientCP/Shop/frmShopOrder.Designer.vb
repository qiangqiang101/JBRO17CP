<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShopOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShopOrder))
        Me.lvHistory = New System.Windows.Forms.ListView()
        Me.cItemName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chCharName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chQty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chCurrency = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chAction = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lvHistory
        '
        Me.lvHistory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvHistory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cItemName, Me.chID, Me.chCharName, Me.chType, Me.chQty, Me.chPrice, Me.chCurrency, Me.chDate, Me.chStatus, Me.chAction})
        Me.lvHistory.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lvHistory.FullRowSelect = True
        Me.lvHistory.GridLines = True
        Me.lvHistory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvHistory.Location = New System.Drawing.Point(12, 12)
        Me.lvHistory.MultiSelect = False
        Me.lvHistory.Name = "lvHistory"
        Me.lvHistory.Size = New System.Drawing.Size(1106, 561)
        Me.lvHistory.TabIndex = 33
        Me.lvHistory.UseCompatibleStateImageBehavior = False
        Me.lvHistory.View = System.Windows.Forms.View.Details
        '
        'cItemName
        '
        Me.cItemName.DisplayIndex = 1
        Me.cItemName.Text = "产品名称"
        Me.cItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cItemName.Width = 180
        '
        'chID
        '
        Me.chID.DisplayIndex = 0
        Me.chID.Text = "ID"
        Me.chID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chID.Width = 100
        '
        'chCharName
        '
        Me.chCharName.Text = "角色名"
        Me.chCharName.Width = 120
        '
        'chType
        '
        Me.chType.Text = "类型"
        Me.chType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chType.Width = 80
        '
        'chQty
        '
        Me.chQty.Text = "数量"
        '
        'chPrice
        '
        Me.chPrice.Text = "金额"
        Me.chPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chPrice.Width = 100
        '
        'chCurrency
        '
        Me.chCurrency.Text = "货币"
        Me.chCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chCurrency.Width = 50
        '
        'chDate
        '
        Me.chDate.Text = "日期"
        Me.chDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chDate.Width = 150
        '
        'chStatus
        '
        Me.chStatus.Text = "状态"
        Me.chStatus.Width = 100
        '
        'chAction
        '
        Me.chAction.Text = "操作"
        Me.chAction.Width = 80
        '
        'frmShopOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1130, 585)
        Me.Controls.Add(Me.lvHistory)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmShopOrder"
        Me.Text = "购买记录"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lvHistory As ListView
    Friend WithEvents cItemName As ColumnHeader
    Friend WithEvents chID As ColumnHeader
    Friend WithEvents chType As ColumnHeader
    Friend WithEvents chCurrency As ColumnHeader
    Friend WithEvents chPrice As ColumnHeader
    Friend WithEvents chDate As ColumnHeader
    Friend WithEvents chStatus As ColumnHeader
    Friend WithEvents chQty As ColumnHeader
    Friend WithEvents chCharName As ColumnHeader
    Friend WithEvents chAction As ColumnHeader
End Class
