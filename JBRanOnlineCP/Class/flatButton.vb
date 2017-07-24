Public Class flatButton

    Public Property Value() As String
        Get
            Return ButtonText.Text
        End Get
        Set(value As String)
            ButtonText.Text = value
        End Set
    End Property

    Public Property Icon() As Image
        Get
            Return image.Image
        End Get
        Set(value As Image)
            image.Image = value
        End Set
    End Property

    Public Property IconSizeMode As PictureBoxSizeMode
        Get
            Return image.SizeMode
        End Get
        Set(value As PictureBoxSizeMode)
            image.SizeMode = value
        End Set
    End Property

    Public Property IconBackground() As Image
        Get
            Return image.BackgroundImage
        End Get
        Set(value As Image)
            image.BackgroundImage = value
        End Set
    End Property

    Public Property IconBackgroundSizeMode As ImageLayout
        Get
            Return image.BackgroundImageLayout
        End Get
        Set(value As ImageLayout)
            image.BackgroundImageLayout = value
        End Set
    End Property

    Private _normalcolor As Color
    Public Property NormalColor() As Color
        Get
            Return _normalcolor
        End Get
        Set(value As Color)
            _normalcolor = value
        End Set
    End Property

    Private _normalTextColor As Color
    Public Property NormalTextColor() As Color
        Get
            Return _normalTextColor
        End Get
        Set(value As Color)
            _normalTextColor = value
        End Set
    End Property

    Private _hovercolor As Color
    Public Property HoverColor() As Color
        Get
            Return _hovercolor
        End Get
        Set(value As Color)
            _hovercolor = value
        End Set
    End Property

    Private _hovertextcolor As Color
    Public Property HoverTextColor() As Color
        Get
            Return _hovertextcolor
        End Get
        Set(value As Color)
            _hovertextcolor = value
        End Set
    End Property

    Private _activeColor As Color
    Public Property ActiveColor() As Color
        Get
            Return _activeColor
        End Get
        Set(value As Color)
            _activeColor = value
        End Set
    End Property

    Private _activetextcolor As Color
    Public Property ActiveTextColor As Color
        Get
            Return _activetextcolor
        End Get
        Set(value As Color)
            _activetextcolor = value
        End Set
    End Property

    Private _disabledColor As Color
    Public Property DisabledColor() As Color
        Get
            Return _disabledColor
        End Get
        Set(value As Color)
            _disabledColor = value
        End Set
    End Property

    Public Enum IconImageStyle
        Normal
        Left
    End Enum

    Private _iconstyle As IconImageStyle
    Public Property IconStyle() As IconImageStyle
        Get
            Return _iconstyle
        End Get
        Set(value As IconImageStyle)
            _iconstyle = value
        End Set
    End Property

    Public Sub New()
        _activeColor = Color.FromArgb(255, 0, 102, 204)
        _activetextcolor = Color.White
        _disabledColor = Color.Gray
        _hovercolor = Color.FromArgb(255, 37, 46, 59)
        _hovertextcolor = Color.LightBlue
        _normalcolor = Color.FromArgb(255, 26, 32, 40)
        _normalTextColor = Color.Silver
        _iconstyle = IconImageStyle.Normal
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Icon_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, image.MouseDown, ButtonText.MouseDown, image.MouseDown
        If Enabled Then
            BackColor = _activeColor
            ButtonText.ForeColor = _activetextcolor
        End If
    End Sub

    Private Sub Icon_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp, image.MouseUp, ButtonText.MouseUp, image.MouseUp
        If Enabled Then
            BackColor = _hovercolor
            ButtonText.ForeColor = _hovertextcolor
        End If
    End Sub

    Private Sub flatButton_EnabledChanged(sender As Object, e As EventArgs) Handles Me.EnabledChanged
        If Enabled Then BackColor = _normalcolor Else BackColor = _disabledColor
    End Sub

    Private Sub flatButton_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter, image.MouseEnter, ButtonText.MouseEnter, image.MouseEnter
        If Enabled Then
            BackColor = _hovercolor
            ButtonText.ForeColor = _hovertextcolor
        End If
    End Sub

    Private Sub flatButton_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave, image.MouseLeave, ButtonText.MouseLeave, image.MouseLeave
        If Enabled Then
            BackColor = _normalcolor
            ButtonText.ForeColor = _normalTextColor
        End If
    End Sub

    Private Sub flatButton_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case _iconstyle
            Case IconImageStyle.Normal
                image.Location = New Point(20, 3)
            Case IconImageStyle.Left
                image.Location = New Point(3, 3)
        End Select
    End Sub

    Private Sub HandleClick(ByVal sender As Object, ByVal e As EventArgs) Handles image.Click, ButtonText.Click
        Me.OnClick(EventArgs.Empty)
    End Sub
End Class
