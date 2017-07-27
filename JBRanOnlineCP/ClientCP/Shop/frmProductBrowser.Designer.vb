<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductBrowser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductBrowser))
        Me.pbImage = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblRemain = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_Char = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbImage
        '
        Me.pbImage.Location = New System.Drawing.Point(12, 12)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(250, 250)
        Me.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImage.TabIndex = 0
        Me.pbImage.TabStop = False
        '
        'lblName
        '
        Me.lblName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(268, 12)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(473, 32)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "{ItemName}"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(303, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "类型:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(303, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "剩余:"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(354, 128)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(100, 29)
        Me.txtQty.TabIndex = 1
        Me.txtQty.Text = "1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(303, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "数量:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(303, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 21)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "价格:"
        '
        'lblDesc
        '
        Me.lblDesc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDesc.Location = New System.Drawing.Point(9, 25)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(723, 229)
        Me.lblDesc.TabIndex = 11
        Me.lblDesc.Text = "{Desc}"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(354, 61)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(84, 21)
        Me.lblType.TabIndex = 15
        Me.lblType.Text = "{ItemType}"
        '
        'lblRemain
        '
        Me.lblRemain.AutoSize = True
        Me.lblRemain.Location = New System.Drawing.Point(354, 96)
        Me.lblRemain.Name = "lblRemain"
        Me.lblRemain.Size = New System.Drawing.Size(104, 21)
        Me.lblRemain.TabIndex = 16
        Me.lblRemain.Text = "{ItemRemain}"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(350, 166)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(131, 21)
        Me.lblPrice.TabIndex = 17
        Me.lblPrice.Text = "{Price} {Currency}"
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnSubmit.Location = New System.Drawing.Point(354, 233)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(105, 29)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "购买"
        Me.btnSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(303, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 21)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "角色:"
        '
        'cmb_Char
        '
        Me.cmb_Char.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Char.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmb_Char.FormattingEnabled = True
        Me.cmb_Char.Location = New System.Drawing.Point(354, 198)
        Me.cmb_Char.Name = "cmb_Char"
        Me.cmb_Char.Size = New System.Drawing.Size(219, 29)
        Me.cmb_Char.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblDesc)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 268)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(738, 257)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "描述"
        '
        'frmProductBrowser
        '
        Me.AcceptButton = Me.btnSubmit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(753, 537)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_Char)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblRemain)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.pbImage)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmProductBrowser"
        Me.Text = "产品: {ID}"
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbImage As PictureBox
    Friend WithEvents lblName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblType As Label
    Friend WithEvents lblRemain As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_Char As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
