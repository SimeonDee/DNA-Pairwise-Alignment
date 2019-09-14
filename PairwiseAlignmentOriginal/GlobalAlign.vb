Public Class GlobalAlign
    Private theSeq1, theSeq2 As String
    Private theMatch, theMismatch, theGap, row, col As Integer
    Private theBacktrack As List(Of Cell)
    Public matrix(,) As Integer

    Public Enum Location
        Left
        Top
        Diagonal
    End Enum

    Public Sub New(seq1 As String, seq2 As String, match As Integer, mismatch As Integer, gap As Integer)
        theSeq1 = seq1
        theSeq2 = seq2
        theMatch = match
        theMismatch = mismatch
        theGap = gap
        theBacktrack = New List(Of Cell)
    End Sub

    Public Property Gap() As Integer
        Get
            Return theGap
        End Get
        Set(value As Integer)
            theGap = value
        End Set
    End Property

    'initialization of first row and column
    Public Sub initializeIt()
        col = theSeq1.Trim.Length
        row = theSeq2.Trim.Length
        ReDim matrix(row, col)
        For i As Integer = 0 To row
            matrix(i, 0) = i * Gap
        Next

        For j As Integer = 0 To col
            matrix(0, j) = j * Gap
        Next

    End Sub

    Public Sub FillMatrix()
        Dim u, l, d As Integer, position As Location
        'Dim ab As Cell
        For i As Integer = 1 To row
            For j As Integer = 1 To col
                u = matrix(i - 1, j) + theGap
                l = matrix(i, j - 1) + theGap
                If theSeq1(j - 1) = theSeq2(i - 1) Then
                    d = matrix(i - 1, j - 1) + theMatch
                Else
                    d = matrix(i - 1, j - 1) + theMismatch
                End If

                If (u > l) And (u > d) Then
                    position = Location.Top
                End If
                If (l > u) And (l > d) Then
                    position = Location.Left
                End If
                If (d > u) And (d > l) Then
                    position = Location.Diagonal
                End If
                If (u = l) And (l = d) Then
                    position = Location.Diagonal
                End If


                matrix(i, j) = max(max(u, l), d)
                'ab = New Cell(i, j, position)

                theBacktrack.Add(New Cell(i, j, position))
            Next
        Next
    End Sub


    Private Function max(a As Integer, b As Integer) As Integer
        If a >= b Then
            Return a
        Else
            Return b
        End If

    End Function

    Public Sub Align(ByRef str1 As String, ByRef str2 As String)
        Dim n, m As Integer
        Dim backSeq1 As String = "", backSeq2 As String = ""
        Dim count1, count2 As Integer

        n = row
        m = col
        count1 = theSeq1.Length
        count2 = theSeq2.Length
        'count1 = m
        'count2 = n
        Do
            For i As Integer = theBacktrack.Count - 1 To 0 Step -1

                If theBacktrack(i).Row = n And theBacktrack(i).Column = m Then
                    Select Case (theBacktrack(i).Location)
                        Case Cell.Position.Diagonal

                            backSeq1 = Mid(theSeq1, m, 1) & backSeq1
                            backSeq2 = Mid(theSeq2, n, 1) & backSeq2
                            n = theBacktrack(i).Row - 1
                            m = theBacktrack(i).Column - 1

                            'count1 = count1 - 1
                            'count2 = count2 - 1
                        Case Cell.Position.Left
                            backSeq1 = Mid(theSeq1, n, 1) & backSeq1
                            backSeq2 = "-" & backSeq2
                            n = theBacktrack(i).Row
                            m = theBacktrack(i).Column - 1
                            'count2 = count2 - 1

                        Case Cell.Position.Top
                            backSeq1 = "-" & backSeq1
                            backSeq2 = Mid(theSeq1, m, 1) & backSeq2
                            n = theBacktrack(i).Row - 1
                            m = theBacktrack(i).Column
                            'count1 = count1 - 1
                    End Select
                    If (n = 1 And theBacktrack(i).Location <> Location.Left) _
                        Or (m = 1 And theBacktrack(i).Location <> Location.Top) _
                        Or (n = 1 And m = 1) Then
                        Exit For
                        GoTo Terminate
                    End If
                End If
            Next
Terminate:  Exit Do
        Loop

        str1 = backSeq1
        str2 = backSeq2
        'MsgBox("The Aligned Sequence is " & vbCrLf & backSeq1 & vbCrLf & backSeq2)
    End Sub

End Class
