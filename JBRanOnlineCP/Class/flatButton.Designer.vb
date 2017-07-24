<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class flatButton
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.ButtonText = New System.Windows.Forms.Label()
        Me.image = New System.Windows.Forms.PictureBox()
        CType(Me.image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonText
        '
        Me.ButtonText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonText.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ButtonText.ForeColor = System.Drawing.Color.Silver
        Me.ButtonText.Location = New System.Drawing.Point(66, 13)
        Me.ButtonText.Name = "ButtonText"
        Me.ButtonText.Size = New System.Drawing.Size(169, 20)
        Me.ButtonText.TabIndex = 0
        Me.ButtonText.Text = "flatButton"
        '
        'image
        '
        Me.image.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.image.Location = New System.Drawing.Point(20, 3)
        Me.image.Name = "image"
        Me.image.Size = New System.Drawing.Size(40, 40)
        Me.image.TabIndex = 1
        Me.image.TabStop = False
        '
        'flatButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Controls.Add(Me.image)
        Me.Controls.Add(Me.ButtonText)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "flatButton"
        Me.Size = New System.Drawing.Size(238, 45)
        CType(Me.image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonText As Label
    Friend WithEvents image As PictureBox
End Class
