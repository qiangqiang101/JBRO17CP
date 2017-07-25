<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEncDec
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEncDec))
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtEncOri = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnEnc = New System.Windows.Forms.Button()
        Me.txtEncEnc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnDec = New System.Windows.Forms.Button()
        Me.txtDecOri = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDecEnc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(20, 25)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(58, 15)
        Me.Label30.TabIndex = 62
        Me.Label30.Text = "原始文本:"
        '
        'txtEncOri
        '
        Me.txtEncOri.Location = New System.Drawing.Point(84, 22)
        Me.txtEncOri.Name = "txtEncOri"
        Me.txtEncOri.Size = New System.Drawing.Size(428, 23)
        Me.txtEncOri.TabIndex = 61
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnEnc)
        Me.GroupBox1.Controls.Add(Me.txtEncEnc)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtEncOri)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(518, 117)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "加密"
        '
        'btnEnc
        '
        Me.btnEnc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnc.Location = New System.Drawing.Point(407, 80)
        Me.btnEnc.Name = "btnEnc"
        Me.btnEnc.Size = New System.Drawing.Size(105, 29)
        Me.btnEnc.TabIndex = 65
        Me.btnEnc.Text = "加密"
        Me.btnEnc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEnc.UseVisualStyleBackColor = True
        '
        'txtEncEnc
        '
        Me.txtEncEnc.Location = New System.Drawing.Point(84, 51)
        Me.txtEncEnc.Name = "txtEncEnc"
        Me.txtEncEnc.Size = New System.Drawing.Size(428, 23)
        Me.txtEncEnc.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 15)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "加密文本:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnDec)
        Me.GroupBox2.Controls.Add(Me.txtDecOri)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtDecEnc)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 135)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(518, 117)
        Me.GroupBox2.TabIndex = 64
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "解密"
        '
        'btnDec
        '
        Me.btnDec.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDec.Location = New System.Drawing.Point(407, 80)
        Me.btnDec.Name = "btnDec"
        Me.btnDec.Size = New System.Drawing.Size(105, 29)
        Me.btnDec.TabIndex = 65
        Me.btnDec.Text = "解密"
        Me.btnDec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDec.UseVisualStyleBackColor = True
        '
        'txtDecOri
        '
        Me.txtDecOri.Location = New System.Drawing.Point(84, 51)
        Me.txtDecOri.Name = "txtDecOri"
        Me.txtDecOri.Size = New System.Drawing.Size(428, 23)
        Me.txtDecOri.TabIndex = 63
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 15)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "加密文本:"
        '
        'txtDecEnc
        '
        Me.txtDecEnc.Location = New System.Drawing.Point(84, 22)
        Me.txtDecEnc.Name = "txtDecEnc"
        Me.txtDecEnc.Size = New System.Drawing.Size(428, 23)
        Me.txtDecEnc.TabIndex = 61
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 15)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "原始文本:"
        '
        'frmEncDec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 259)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEncDec"
        Me.Text = "加密解密"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label30 As Label
    Friend WithEvents txtEncOri As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtEncEnc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEnc As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnDec As Button
    Friend WithEvents txtDecOri As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDecEnc As TextBox
    Friend WithEvents Label3 As Label
End Class
