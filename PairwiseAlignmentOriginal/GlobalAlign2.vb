Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Collections

Public Class GlobalAlign2
    Public Function InitializationStep(Seq1 As String, Seq2 As String, Match As Integer, NoMatch As Integer, Gap As Integer) As Cell(,)
        Dim M, N As Integer
        M = Seq1.Length
        N = Seq2.Length
        Dim Matrix(N, M) As Cell
        'Initialize with gap penalty set to i*Gap
        For i As Integer = 0 To (M - 1)
            Matrix(0, i) = New Cell(0, i, i * Gap)
        Next

        For j As Integer = 0 To (N - 1)
            Matrix(j, 0) = New Cell(j, 0, j * Gap)
        Next

        'Filling Matrix with each cell having a value resulted from GetMax function
        For j As Integer = 1 To (N - 1)
            For i As Integer = 1 To (M - 1)
                Matrix(j, i) = GetMax(i, j, Seq1, Seq2, Matrix, Match, NoMatch, Gap)
            Next
        Next

        Return Matrix
    End Function

    Public Function GetMax(i As Integer, j As Integer, seq1 As String, seq2 As String, Matrix As Cell(,), match As Integer, noMatch As Integer, gap As Integer) As Cell
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

        Dim Mmax As Integer
        Mmax = max(max(M1, M2), M3)
        If (Mmax = M1) Then
            Temp = New Cell(j, i, M1, Matrix(j - 1, i - 1), Cell.Position.Diagonal)
        Else
            If (Mmax = M2) Then
                Temp = New Cell(j, i, M2, Matrix(j, i - 1), Cell.Position.Left)
            Else
                If (Mmax = M3) Then
                    Temp = New Cell(j, i, M3, Matrix(j - 1, i), Cell.Position.Top)
                End If
            End If
        End If

        Return Temp
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
        CurrentCell = Matrix(sq2.Length - 1, sq1.Length - 1)

        While Not (IsNothing(CurrentCell.CellPointer))

            If (CurrentCell.Type = Cell.Position.Diagonal) Then

                Seq1.Add(sq1(CurrentCell.Column))
                Seq2.Add(sq2(CurrentCell.Row))
                'Seq2.Add(" ")
            End If

            If (CurrentCell.Type = Cell.Position.Left) Then


                Seq1.Add(sq1(CurrentCell.Column))
                Seq2.Add("-")
                Seq2.Add(" ")

            End If

            If (CurrentCell.Type = Cell.Position.Top) Then

                Seq1.Add("-")
                Seq1.Add(" ")
                'Seq2.Add(" ")
                Seq2.Add(sq2(CurrentCell.Row))

            End If
            CurrentCell = CurrentCell.CellPointer

        End While
    End Sub
           



End Class
