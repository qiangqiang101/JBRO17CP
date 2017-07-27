Public Class shopItem

    Private _ID As Integer
    Public Property ItemID As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property

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

    Public Enum CurrencyType
        Gold
        ePoint
    End Enum

    Private _CurrencyMethod As CurrencyType
    Public Property CurrencyMethod() As CurrencyType
        Get
            Return _CurrencyMethod
        End Get
        Set(value As CurrencyType)
            _CurrencyMethod = value
        End Set
    End Property

    Private _price As Integer
    Public Property Price() As Integer
        Get
            Return _price
        End Get
        Set(value As Integer)
            _price = value
        End Set
    End Property

    Private _remaining As Integer
    Public Property Remaining() As Integer
        Get
            Return _remaining
        End Get
        Set(value As Integer)
            _remaining = value
        End Set
    End Property

    Private _desc As String
    Public Property Desciption() As String
        Get
            Return _desc
        End Get
        Set(value As String)
            _desc = value
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
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub SetWebImage(url As String)
        Dim MyWebClient As New Net.WebClient
        Dim ImageInBytes() As Byte = MyWebClient.DownloadData(url)
        Dim ImageStream As New IO.MemoryStream(ImageInBytes)
        image.Image = New Bitmap(ImageStream)
    End Sub

    Private Sub Icon_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, image.MouseDown, ButtonText.MouseDown, image.MouseDown, priceTag.MouseDown
        If Enabled Then
            BackColor = _activeColor
            ButtonText.ForeColor = _activetextcolor
        End If
    End Sub

    Private Sub Icon_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp, image.MouseUp, ButtonText.MouseUp, image.MouseUp, priceTag.MouseUp
        If Enabled Then
            BackColor = _hovercolor
            ButtonText.ForeColor = _hovertextcolor
        End If
    End Sub

    Private Sub flatButton_EnabledChanged(sender As Object, e As EventArgs) Handles Me.EnabledChanged
        If Enabled Then BackColor = _normalcolor Else BackColor = _disabledColor
    End Sub

    Private Sub flatButton_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter, image.MouseEnter, ButtonText.MouseEnter, image.MouseEnter, priceTag.MouseEnter
        If Enabled Then
            BackColor = _hovercolor
            ButtonText.ForeColor = _hovertextcolor
        End If
    End Sub

    Private Sub flatButton_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave, image.MouseLeave, ButtonText.MouseLeave, image.MouseLeave, priceTag.MouseLeave
        If Enabled Then
            BackColor = _normalcolor
            ButtonText.ForeColor = _normalTextColor
        End If
    End Sub

    Private Sub HandleClick(ByVal sender As Object, ByVal e As EventArgs) Handles image.Click, ButtonText.Click, priceTag.Click
        Me.OnClick(EventArgs.Empty)
    End Sub

    Private Sub shopItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lb As String = Nothing
        Select Case _CurrencyMethod
            Case _CurrencyMethod.Gold
                lb = "游戏币"
            Case _CurrencyMethod.ePoint
                lb = "积分"
        End Select
        priceTag.Text = String.Format("{0} {1}", _price, lb)
    End Sub
End Class
