<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelfHelp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSelfHelp))
        Me.btn_SelfHelp = New System.Windows.Forms.Button()
        Me.txt_SHUserName = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_SelfHelp
        '
        Me.btn_SelfHelp.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btn_SelfHelp.Location = New System.Drawing.Point(349, 231)
        Me.btn_SelfHelp.Name = "btn_SelfHelp"
        Me.btn_SelfHelp.Size = New System.Drawing.Size(105, 29)
        Me.btn_SelfHelp.TabIndex = 65
        Me.btn_SelfHelp.Text = "立刻下线"
        Me.btn_SelfHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_SelfHelp.UseVisualStyleBackColor = True
        '
        'txt_SHUserName
        '
        Me.txt_SHUserName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txt_SHUserName.Location = New System.Drawing.Point(299, 196)
        Me.txt_SHUserName.MaxLength = 14
        Me.txt_SHUserName.Name = "txt_SHUserName"
        Me.txt_SHUserName.ReadOnly = True
        Me.txt_SHUserName.Size = New System.Drawing.Size(219, 29)
        Me.txt_SHUserName.TabIndex = 64
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label27.Location = New System.Drawing.Point(248, 199)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(45, 21)
        Me.Label27.TabIndex = 63
        Me.Label27.Text = "帐号:"
        '
        'frmSelfHelp
        '
        Me.AcceptButton = Me.btn_SelfHelp
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(810, 478)
        Me.Controls.Add(Me.btn_SelfHelp)
        Me.Controls.Add(Me.txt_SHUserName)
        Me.Controls.Add(Me.Label27)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSelfHelp"
        Me.Text = "卡号自救"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_SelfHelp As Button
    Friend WithEvents txt_SHUserName As TextBox
    Friend WithEvents Label27 As Label
End Class
