Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Collections

Public Class LocalAlign2
    Public Function InitializationStep(Seq1 As String, Seq2 As String, Match As Integer, NoMatch As Integer, Gap As Integer, compact As Boolean) As Cell(,)
        Dim M, N As Integer
        M = Seq1.Length
        N = Seq2.Length
        Dim Matrix(N, M) As Cell
        'Initialize with gap penalty set to i*Gap
        For i As Integer = 0 To (M - 1)
            Matrix(0, i) = New Cell(0, i, i * 0)
        Next

        For j As Integer = 0 To (N - 1)
            Matrix(j, 0) = New Cell(j, 0, j * 0)
        Next

        'Filling Matrix with each cell having a value resulted from GetMax function
        For j As Integer = 1 To (N - 1)
            For i As Integer = 1 To (M - 1)
                Matrix(j, i) = GetMax(i, j, Seq1, Seq2, Matrix, Match, NoMatch, Gap, compact)
            Next
        Next

        Return Matrix
    End Function

    Public Function GetMax(i As Integer, j As Integer, seq1 As String, seq2 As String, Matrix As Cell(,), match As Integer, noMatch As Integer, gap As Integer, CompactStatus As Boolean) As Cell
        Dim Temp As Cell = New Cell()
        Dim sim As Integer
        Dim thegap As Integer
        thegap = gap
        If (seq1(i) = seq2(j)) Then
            sim = match
        Else
            sim = noMatch
        End If

        Dim M1, M2, M3 As Integer
        M1 = Matrix(j - 1, i - 1).CellScore + sim
        M2 = Matrix(j, i - 1).CellScore + thegap
        M3 = Matrix(j - 1, i).CellScore + thegap

        'If M1 < 0 Then M1 = 0
        'If M2 < 0 Then M2 = 0
        'If M3 < 0 Then M3 = 0

        Dim Mmax As Integer
        Mmax = max(max(M1, M2), M3)
        If (Mmax = M1) Then
            Temp = New Cell(j, i, Binarize(M1, CompactStatus), Matrix(j - 1, i - 1), Cell.Position.Diagonal)

        Else
            If (Mmax = M2) Then
                Temp = New Cell(j, i, Binarize(M2, CompactStatus), Matrix(j, i - 1), Cell.Position.Left)

            Else
                If (Mmax = M3) Then
                    Temp = New Cell(j, i, Binarize(M3, CompactStatus), Matrix(j - 1, i), Cell.Position.Top)
                End If
            End If
        End If


        Return Temp
    End Function
    Private Function Binarize(ByVal N As Integer, isCompactStatus As Boolean) As Integer
        If (N <= 0) Then
            Return 0
        Else
            If (isCompactStatus) Then
                Return 1
            Else
                Return N
            End If
        End If
    End Function

    Public Function max(a As Integer, b As Integer) As Integer
        If (a >= b) Then
            Return a
        Else
            Return b
        End If
    End Function

    Public Sub TracebackStep(Matrix As Cell(,), sq1 As String, sq2 As String, Seq1 As List(Of Char), Seq2 As List(Of Char))
        Dim CurrentCell As Cell
        'Dim Seq1 as List(of Char) = New List(of Char)()
        'Dim Seq2 as List(of Char) = New List(of Char)()

        'CurrentCell = Matrix(sq2.Length - 1, sq1.Length - 1)
        CurrentCell = getCellWithMaxValue(Matrix, sq1, sq2)
        MessageBox.Show("Max Cell Details:" & vbCrLf & "Row: " & CurrentCell.Row.ToString & " Column: " & CurrentCell.Column.ToString &
                        " Value: " + CurrentCell.CellScore.ToString)


        While (Not (IsNothing(CurrentCell.CellPointer)) And CurrentCell.CellScore <> 0)

            If (CurrentCell.Type = Cell.Position.Diagonal) Then

                Seq1.Add(sq1(CurrentCell.Column))
                Seq2.Add(sq2(CurrentCell.Row))

            End If

            If (CurrentCell.Type = Cell.Position.Left) Then

                Seq1.Add(sq1(CurrentCell.Column))
                Seq2.Add("-")
                Seq2.Add(" ")

            End If

            If (CurrentCell.Type = Cell.Position.Top) Then

                Seq1.Add("-")
                Seq1.Add(" ")
                Seq2.Add(sq2(CurrentCell.Row))

            End If
            CurrentCell = CurrentCell.CellPointer

        End While
    End Sub

    Public Function getCellWithMaxValue(ByVal Matrix As Cell(,), ByVal seqStr1 As String, ByVal seqStr2 As String) As Cell
        Dim maxValCell As Cell = Nothing
        Dim largest As Integer
        largest = 0
        For row As Integer = 1 To (seqStr2.Length - 1)
            For col As Integer = 1 To (seqStr1.Length - 1)
                If (largest <= Matrix(row, col).CellScore) Then
                    largest = Matrix(row, col).CellScore
                    maxValCell = Matrix(row, col)
                End If
            Next
        Next

        Return maxValCell
    End Function

    Public Function CountCellsWithMaxValue(ByVal Matrix As Cell(,), ByVal seqStr1 As String, ByVal seqStr2 As String) As Integer
        Dim largest As Integer
        Dim largestCounter As Integer = 0
        largest = 0
        For row As Integer = 1 To (seqStr2.Length - 1)
            For col As Integer = 1 To (seqStr1.Length - 1)
                If (largest <= Matrix(row, col).CellScore) Then
                    largest = Matrix(row, col).CellScore
                End If
            Next
        Next


        For row As Integer = 1 To (seqStr2.Length - 1)
            For col As Integer = 1 To (seqStr1.Length - 1)
                If (Matrix(row, col).CellScore = largest) Then
                    largestCounter += 1
                End If
            Next
        Next


        Return largestCounter
    End Function

End Class
