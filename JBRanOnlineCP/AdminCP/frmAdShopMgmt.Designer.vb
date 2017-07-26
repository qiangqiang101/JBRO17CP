<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdShopMgmt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdShopMgmt))
        Me.lvProducts = New System.Windows.Forms.ListView()
        Me.chName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chAmount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chCurrency = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chRemain = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chEnable = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtSearchProduct = New System.Windows.Forms.TextBox()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvProducts
        '
        Me.lvProducts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvProducts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chName, Me.chID, Me.chType, Me.chAmount, Me.chCurrency, Me.chRemain, Me.chEnable})
        Me.lvProducts.FullRowSelect = True
        Me.lvProducts.GridLines = True
        Me.lvProducts.Location = New System.Drawing.Point(12, 79)
        Me.lvProducts.Name = "lvProducts"
        Me.lvProducts.Size = New System.Drawing.Size(716, 453)
        Me.lvProducts.TabIndex = 5
        Me.lvProducts.UseCompatibleStateImageBehavior = False
        Me.lvProducts.View = System.Windows.Forms.View.Details
        '
        'chName
        '
        Me.chName.DisplayIndex = 1
        Me.chName.Text = "名称"
        Me.chName.Width = 200
        '
        'chID
        '
        Me.chID.DisplayIndex = 0
        Me.chID.Text = "ID"
        Me.chID.Width = 80
        '
        'chType
        '
        Me.chType.Text = "类型"
        Me.chType.Width = 80
        '
        'chAmount
        '
        Me.chAmount.Text = "金额"
        Me.chAmount.Width = 80
        '
        'chCurrency
        '
        Me.chCurrency.Text = "货币"
        Me.chCurrency.Width = 80
        '
        'chRemain
        '
        Me.chRemain.Text = "数量"
        Me.chRemain.Width = 80
        '
        'chEnable
        '
        Me.chEnable.Text = "启用"
        Me.chEnable.Width = 80
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label32)
        Me.GroupBox5.Controls.Add(Me.txtSearchProduct)
        Me.GroupBox5.Controls.Add(Me.btn_Search)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(383, 61)
        Me.GroupBox5.TabIndex = 6
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
        Me.Label32.Text = "名称:"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtSearchProduct
        '
        Me.txtSearchProduct.Location = New System.Drawing.Point(46, 22)
        Me.txtSearchProduct.MaxLength = 18
        Me.txtSearchProduct.Name = "txtSearchProduct"
        Me.txtSearchProduct.Size = New System.Drawing.Size(219, 23)
        Me.txtSearchProduct.TabIndex = 54
        '
        'btn_Search
        '
        Me.btn_Search.Location = New System.Drawing.Point(271, 18)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(105, 29)
        Me.btn_Search.TabIndex = 39
        Me.btn_Search.Text = "搜索"
        Me.btn_Search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Search.UseVisualStyleBackColor = True
        '
        'frmShopMgmt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 544)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.lvProducts)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmShopMgmt"
        Me.Text = "商城设置"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lvProducts As ListView
    Friend WithEvents chName As ColumnHeader
    Friend WithEvents chID As ColumnHeader
    Friend WithEvents chType As ColumnHeader
    Friend WithEvents chAmount As ColumnHeader
    Friend WithEvents chCurrency As ColumnHeader
    Friend WithEvents chRemain As ColumnHeader
    Friend WithEvents chEnable As ColumnHeader
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label32 As Label
    Friend WithEvents txtSearchProduct As TextBox
    Friend WithEvents btn_Search As Button
End Class
