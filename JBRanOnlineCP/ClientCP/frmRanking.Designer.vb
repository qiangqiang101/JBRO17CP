<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRanking
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRanking))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_Rank = New System.Windows.Forms.ComboBox()
        Me.lvRank = New System.Windows.Forms.ListView()
        Me.chChaName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chChaIntel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chChaLevel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chChaClass = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chChaSchool = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chChaMoney = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cms_Rank = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmi_Copy = New System.Windows.Forms.ToolStripMenuItem()
        Me.cms_Rank.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(528, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 21)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "分类:"
        '
        'cmb_Rank
        '
        Me.cmb_Rank.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_Rank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Rank.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmb_Rank.FormattingEnabled = True
        Me.cmb_Rank.Items.AddRange(New Object() {"总排行", "圣门学院", "玄岩学院", "凤凰学院", "格斗部", "剑道部", "气功部", "弓箭部", "大富翁"})
        Me.cmb_Rank.Location = New System.Drawing.Point(579, 12)
        Me.cmb_Rank.Name = "cmb_Rank"
        Me.cmb_Rank.Size = New System.Drawing.Size(219, 29)
        Me.cmb_Rank.TabIndex = 32
        '
        'lvRank
        '
        Me.lvRank.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvRank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvRank.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chChaName, Me.chNo, Me.chChaIntel, Me.chChaLevel, Me.chChaClass, Me.chChaSchool, Me.chChaMoney})
        Me.lvRank.ContextMenuStrip = Me.cms_Rank
        Me.lvRank.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lvRank.FullRowSelect = True
        Me.lvRank.GridLines = True
        Me.lvRank.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvRank.Location = New System.Drawing.Point(12, 47)
        Me.lvRank.MultiSelect = False
        Me.lvRank.Name = "lvRank"
        Me.lvRank.Size = New System.Drawing.Size(786, 419)
        Me.lvRank.TabIndex = 31
        Me.lvRank.UseCompatibleStateImageBehavior = False
        Me.lvRank.View = System.Windows.Forms.View.Details
        '
        'chChaName
        '
        Me.chChaName.DisplayIndex = 1
        Me.chChaName.Text = "角色名"
        Me.chChaName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chChaName.Width = 220
        '
        'chNo
        '
        Me.chNo.DisplayIndex = 0
        Me.chNo.Text = "名次"
        Me.chNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chNo.Width = 50
        '
        'chChaIntel
        '
        Me.chChaIntel.Text = "转生"
        Me.chChaIntel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chChaIntel.Width = 50
        '
        'chChaLevel
        '
        Me.chChaLevel.Text = "等级"
        Me.chChaLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chChaLevel.Width = 50
        '
        'chChaClass
        '
        Me.chChaClass.Text = "职业"
        Me.chChaClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chChaClass.Width = 80
        '
        'chChaSchool
        '
        Me.chChaSchool.Text = "学院"
        Me.chChaSchool.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chChaSchool.Width = 80
        '
        'chChaMoney
        '
        Me.chChaMoney.Text = "个人财富"
        Me.chChaMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chChaMoney.Width = 200
        '
        'cms_Rank
        '
        Me.cms_Rank.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cms_Rank.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_Copy})
        Me.cms_Rank.Name = "cms_Rank"
        Me.cms_Rank.Size = New System.Drawing.Size(201, 30)
        '
        'tsmi_Copy
        '
        Me.tsmi_Copy.Name = "tsmi_Copy"
        Me.tsmi_Copy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.tsmi_Copy.Size = New System.Drawing.Size(200, 26)
        Me.tsmi_Copy.Text = "複製文字"
        '
        'frmRanking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(810, 478)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_Rank)
        Me.Controls.Add(Me.lvRank)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRanking"
        Me.Text = "英雄排行"
        Me.cms_Rank.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_Rank As ComboBox
    Friend WithEvents lvRank As ListView
    Friend WithEvents chChaName As ColumnHeader
    Friend WithEvents chNo As ColumnHeader
    Friend WithEvents chChaIntel As ColumnHeader
    Friend WithEvents chChaLevel As ColumnHeader
    Friend WithEvents chChaClass As ColumnHeader
    Friend WithEvents chChaSchool As ColumnHeader
    Friend WithEvents chChaMoney As ColumnHeader
    Friend WithEvents cms_Rank As ContextMenuStrip
    Friend WithEvents tsmi_Copy As ToolStripMenuItem
End Class
