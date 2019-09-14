Public Class Cell
    Private therow, thecol, thescore As Integer
    Private theLocation As String
    Private PreviousCell As Cell
    Private PreviousCells As List(Of Cell) = New List(Of Cell)
    Private PCType As Position

    Public Enum Position
        Left
        Top
        Diagonal
    End Enum

    Public Sub New()

    End Sub
    Public Sub New(row As Integer, col As Integer)
        Me.therow = row
        Me.thecol = col
    End Sub

    Public Sub New(row As Integer, col As Integer, sco As Integer)
        Me.therow = row
        Me.thecol = col
        Me.thescore = sco
    End Sub
    Public Sub New(ByVal row As Integer, ByVal col As Integer, ByVal pos As Position)
        therow = row
        thecol = col
        theLocation = pos
    End Sub
    Public Sub New(row As Integer, ByVal col As Integer, ByVal sco As Integer, prev As Cell)
        Me.therow = row
        Me.thecol = col
        Me.thescore = sco
        Me.PreviousCell = prev
    End Sub

    Public Sub New(row As Integer, ByVal col As Integer, ByVal sco As Integer, prev As Cell, PType As Position)
        Me.therow = row
        Me.thecol = col
        Me.thescore = sco
        Me.PreviousCell = prev
        Me.PCType = PType
    End Sub
    Public Property CellPointer() As Cell
        Get
            Return Me.PreviousCell
        End Get
        Set(value As Cell)
            Me.PreviousCell = value
        End Set
    End Property

    Public Property PrevCellPointer() As List(Of Cell)
        Get
            Return Me.PreviousCells
        End Get
        Set(value As List(Of Cell))
            Me.PreviousCells = value
        End Set
    End Property

    Public Property Type() As Position
        Get
            Return Me.PCType
        End Get
        Set(value As Position)
            Me.PCType = value
        End Set
    End Property
    

    Public Property Row() As Integer
        Get
            Return therow
        End Get
        Set(value As Integer)
            therow = value
        End Set
    End Property

    Public Property Column() As Integer
        Get
            Return thecol
        End Get
        Set(value As Integer)
            thecol = value
        End Set
    End Property

    Public Property Location() As Position
        Get
            Return theLocation
        End Get
        Set(value As Position)
            theLocation = value
        End Set
    End Property

    Public Property CellScore() As Integer
        Get
            Return Me.thescore
        End Get
        Set(value As Integer)
            Me.thescore = value
        End Set
    End Property

End Class
