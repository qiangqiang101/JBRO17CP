<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class shopItem
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.image = New System.Windows.Forms.PictureBox()
        Me.ButtonText = New System.Windows.Forms.Label()
        Me.priceTag = New System.Windows.Forms.Label()
        CType(Me.image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'image
        '
        Me.image.Location = New System.Drawing.Point(26, 9)
        Me.image.Name = "image"
        Me.image.Size = New System.Drawing.Size(150, 150)
        Me.image.TabIndex = 2
        Me.image.TabStop = False
        '
        'ButtonText
        '
        Me.ButtonText.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ButtonText.ForeColor = System.Drawing.Color.Silver
        Me.ButtonText.Location = New System.Drawing.Point(9, 162)
        Me.ButtonText.Name = "ButtonText"
        Me.ButtonText.Size = New System.Drawing.Size(182, 56)
        Me.ButtonText.TabIndex = 3
        Me.ButtonText.Text = "shopItem"
        Me.ButtonText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'priceTag
        '
        Me.priceTag.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.priceTag.ForeColor = System.Drawing.Color.Silver
        Me.priceTag.Location = New System.Drawing.Point(9, 218)
        Me.priceTag.Name = "priceTag"
        Me.priceTag.Size = New System.Drawing.Size(182, 22)
        Me.priceTag.TabIndex = 4
        Me.priceTag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'shopItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Controls.Add(Me.priceTag)
        Me.Controls.Add(Me.ButtonText)
        Me.Controls.Add(Me.image)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Name = "shopItem"
        Me.Padding = New System.Windows.Forms.Padding(6)
        Me.Size = New System.Drawing.Size(200, 246)
        CType(Me.image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents image As PictureBox
    Friend WithEvents ButtonText As Label
    Friend WithEvents priceTag As Label
End Class
