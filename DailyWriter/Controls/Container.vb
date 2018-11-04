Imports System.ComponentModel
Public Class Container
    Private Sub Container_ControlAdded(sender As Object, e As ControlEventArgs) Handles Me.ControlAdded
        Title = "Header"
        TitleColor = pnlHeader.ForeColor
        headerBackColor = pnlHeader.BackColor
        BorderLeftSize = pnlBorderLeft.Width
        BorderRightSize = pnlBorderRight.Width
        BorderTopSize = pnlBorderTop.Height
        BorderBottomSize = pnlBorderBottom.Height
        BorderLeftColor = pnlBorderLeft.BackColor
        BorderRightColor = pnlBorderRight.BackColor
        BorderBottomColor = pnlBorderBottom.BackColor
        BorderTopColor = pnlBorderTop.BackColor

    End Sub

    <Category("Container"), Description("Text for the container header")>
    Private _title As String
    Public Property Title() As String
        Get
            Return _title
        End Get
        Set(ByVal value As String)
            _title = value
            lblTitle.Text = value
        End Set
    End Property

    <Category("Container"), Description("Header text color")>
    Private Title_Forecolor As Color
    Public Property TitleColor() As Color
        Get
            Return Title_Forecolor
        End Get
        Set(ByVal value As Color)
            Title_Forecolor = value
            lblTitle.ForeColor = value
        End Set
    End Property

    <Category("Container"), Description("Header background color")>
    Private headerBackColor As Color
    Public Property TitleBackColor() As Color
        Get
            Return headerBackColor
        End Get
        Set(ByVal value As Color)
            headerBackColor = value
            pnlHeader.BackColor = value
        End Set
    End Property

    Private border_top_size As Integer
    Public Property BorderTopSize() As Integer
        Get
            Return border_top_size
        End Get
        Set(ByVal value As Integer)
            border_top_size = value
            pnlBorderTop.Height = value
        End Set
    End Property

    <Category("Container"), Description("Border left size")>
    Private border_left_size As Integer
    Public Property BorderLeftSize() As Integer
        Get
            Return border_left_size
        End Get
        Set(ByVal value As Integer)
            border_left_size = value
            pnlBorderLeft.Width = value
        End Set
    End Property

    <Category("Container"), Description("Border right size")>
    Private border_right_size As Integer
    Public Property BorderRightSize() As Integer
        Get
            Return border_right_size
        End Get
        Set(ByVal value As Integer)
            border_right_size = value
            pnlBorderRight.Width = value
        End Set
    End Property

    <Category("Container"), Description("Border bottom size")>
    Private border_bottom_size As Integer
    Public Property BorderBottomSize() As Integer
        Get
            Return border_bottom_size
        End Get
        Set(ByVal value As Integer)
            border_bottom_size = value
            pnlBorderBottom.Height = value
        End Set
    End Property

    Private border_top_color As Color
    Public Property BorderTopColor() As Color
        Get
            Return border_top_color
        End Get
        Set(ByVal value As Color)
            border_top_color = value
            pnlBorderTop.BackColor = value
        End Set
    End Property

    <Category("Container"), Description("Border left color")>
    Private border_left_color As Color
    Public Property BorderLeftColor() As Color
        Get
            Return border_left_color
        End Get
        Set(ByVal value As Color)
            border_left_color = value
            pnlBorderLeft.BackColor = value
        End Set
    End Property

    <Category("Container"), Description("Border right color")>
    Private border_right_color As Color
    Public Property BorderRightColor() As Color
        Get
            Return border_right_color
        End Get
        Set(ByVal value As Color)
            border_right_color = value
            pnlBorderRight.BackColor = value
        End Set
    End Property

    <Category("Container"), Description("Border bottom color")>
    Private border_bottom_color As Color
    Public Property BorderBottomColor() As Color
        Get
            Return border_bottom_color
        End Get
        Set(ByVal value As Color)
            border_bottom_color = value
            pnlBorderBottom.BackColor = value
        End Set
    End Property


End Class
