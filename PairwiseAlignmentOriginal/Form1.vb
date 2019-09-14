Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Public Class Form1

    Dim Matrix As Cell(,)
    Dim Aligner As New LocalAlignment()
    Dim Seq1, Seq2 As String, match, mismatch, gap As Integer
    Dim LocalAlignCompactStatus As Boolean = False

    Private Sub btnLocal_Click(sender As Object, e As EventArgs) Handles btnLocal.Click
        Dim SeqAlign1 As New List(Of Char)
        Dim SeqAlign2 As New List(Of Char)
        Dim Success As Boolean

        LocalAlignCompactStatus = False
        Success = DoLocal(LocalAlignCompactStatus)

        If (Not (Success)) Then
            Exit Sub
        End If

        ' Trace back matrix from end cell that contains max score { from end cell [SeqAlign2.Count - 1,SeqAlign1.Count - 1] to initial cell [0,0]}
        Aligner.TracebackStep(Matrix, Seq1, Seq2, SeqAlign1, SeqAlign2)

        ' Display Result of alignments
        ' note the trace in matrix done in reverse manner (trace back) 

        RichTextOutput.Clear()

        For j As Integer = SeqAlign1.Count - 1 To 0 Step -1
            RichTextOutput.AppendText(SeqAlign1(j).ToString)
        Next
        RichTextOutput.AppendText(vbCrLf)

        For k As Integer = SeqAlign2.Count - 1 To 0 Step -1
            RichTextOutput.AppendText(SeqAlign2(k).ToString)
        Next

        lblOutput.Text = "OUTPUT FOR LOCAL ALIGNMENT"

        AnalyzeResult(SeqAlign1, SeqAlign2)

    End Sub


    Private Sub btnLocalCompact_Click(sender As Object, e As EventArgs) Handles btnLocalCompact.Click
        Dim SeqAlign1 As New List(Of Char)
        Dim SeqAlign2 As New List(Of Char)
        Dim Success As Boolean

        LocalAlignCompactStatus = True
        Success = DoLocal(LocalAlignCompactStatus)

        If (Not (Success)) Then
            Exit Sub
        End If

        ' Trace back matrix from end cell that contains max score { from end cell [SeqAlign2.Count - 1,SeqAlign1.Count - 1] to initial cell [0,0]}
        Aligner.TracebackStep(Matrix, Seq1, Seq2, SeqAlign1, SeqAlign2)

        ' Display Result of alignments
        ' note the trace in matrix done in reverse manner (trace back) 


        RichTextOutput.Clear()
        RichTextOutput.Text = "MATRIX CELL VALUE OF ""1"" DENOTES A MATCH WHILE ""0"" DENOTES MISMATCH"

        lblOutput.Text = "OUTPUT FOR LOCAL ALIGNMENT (COMPACT)"

        AnalyzeResultLocal()

    End Sub


    Private Function DoLocal(ByVal isCompact As Boolean) As Boolean

        For Each ab As Char In txtSeq1.Text.Trim.ToUpper
            Select Case (ab)
                Case "A", "C", "G", "T"
                Case Else
                    MessageBox.Show("Allowable Characters in Sequence1 and Sequence2 are: A, C, G or T", "INVALID DNA CHARACTER DETECTED")
                    txtSeq1.SelectAll()
                    txtSeq1.Focus()
                    Return False
            End Select
        Next

        For Each abc As Char In txtSeq2.Text.Trim.ToUpper
            Select Case (abc)
                Case "A", "C", "G", "T"
                Case Else
                    MessageBox.Show("Allowable Characters in Sequence1 and Sequence2 are: A, C, G or T", "INVALID DNA CHARACTER DETECTED")
                    txtSeq2.SelectAll()
                    txtSeq2.Focus()
                    Return False
            End Select
        Next

        If (txtSeq1.Text.Length <= txtSeq2.Text.Length) Then
            MessageBox.Show("For LOCAL ALIGNMENT, The Second Sequence Must be Smaller in Length than the First Sequence", "INCOMPATIBLE SEQUENCE")
            txtSeq1.SelectAll()
            txtSeq2.SelectAll()
            txtSeq2.Focus()
            Return False
        End If

        ' Each sequence begin with - to manage dynamic programming table to show why?? show the table in datagridview cell[0,0]

        Dim ReversedSeq2 As String = ""
        Seq1 = "-" & txtSeq1.Text.Trim
        Seq2 = txtSeq2.Text.Trim

        For i As Integer = (Seq2.Length - 1) To 0 Step -1
            ReversedSeq2 &= Seq2(i).ToString
        Next

        Seq2 = "-" & ReversedSeq2

        match = CInt(txtMatch.Text.Trim)
        mismatch = CInt(txtMismatch.Text.Trim)
        gap = CInt(txtGap.Text.Trim)


        'string Seq1 = "-GAATTCAGTTA";
        'string Seq2 = "-GGATCGA";

        'Prepare Matrix for Computing optimal alignment


        ' Initialize matrix
        LocalAlignCompactStatus = False
        Matrix = Aligner.InitializationStep(Seq1, Seq2, match, mismatch, gap, isCompact)

        ' prepare Datagridview to show result of Dynamic Programming Matrix
        'GridMatrix.AutoResizeColumns()
        GridMatrix.ColumnCount = Matrix.GetLength(1) + 1

        For i As Integer = 0 To (GridMatrix.ColumnCount - 1)
            GridMatrix.Columns(i).Width = 30
        Next
        GridMatrix.RowHeadersWidth = 30
        GridMatrix.ColumnHeadersHeight = 30
        GridMatrix.RowCount = Matrix.GetLength(0) + 1
        '*************************************
        'MsgBox(Matrix.GetLength(0).ToString)

        For j As Integer = 1 To (Matrix.GetLength(0) - 1)
            GridMatrix.Rows(j).Cells(0).Value = Seq2(j - 1)
        Next

        For i As Integer = 1 To (Matrix.GetLength(1) - 1)
            GridMatrix.Rows(0).Cells(i).Value = Seq1(i - 1)
        Next

        For j As Integer = 1 To (Matrix.GetLength(0) - 1)
            For i As Integer = 1 To (Matrix.GetLength(1) - 1)
                GridMatrix.Rows(j).Cells(i).Value = Matrix(j - 1, i - 1).CellScore
            Next
        Next

        Return True
    End Function

    Private Sub btnGlobal_Click(sender As Object, e As EventArgs) Handles btnGlobal.Click


        ' Lists That Holds Alignments
        Dim SeqAlign1 As New List(Of Char)
        Dim SeqAlign2 As New List(Of Char)
        RichTextOutput.Clear()
        lblInterpreted.Text = ""


        ' Each sequence begin with - to manage dynamic programming table to show why?? show the table in datagridview cell[0,0]
        Dim Seq1, Seq2 As String, match, mismatch, gap As Integer

        For Each ab As Char In txtSeq1.Text.Trim.ToUpper
            Select Case (ab)
                Case "A", "C", "G", "T"
                Case Else
                    MessageBox.Show("Allowable Characters in Sequence1 and Sequence2 are: A, C, G or T", "INVALID DNA CHARACTER DETECTED")
                    txtSeq1.SelectAll()
                    txtSeq1.Focus()
                    Exit Sub
            End Select
        Next

        For Each abc As Char In txtSeq2.Text.Trim.ToUpper
            Select Case (abc)
                Case "A", "C", "G", "T"
                Case Else
                    MessageBox.Show("Allowable Characters in Sequence1 and Sequence2 are: A, C, G or T", "INVALID DNA CHARACTER DETECTED")
                    txtSeq2.SelectAll()
                    txtSeq2.Focus()
                    Exit Sub
            End Select
        Next

        If (txtSeq1.Text.Length <> txtSeq2.Text.Length) Then
            MessageBox.Show("For GLOBAL ALIGNMENT, The Two Sequences to be Aligned Must be of Equal Length", "INCOMPATIBLE SEQUENCE")
            txtSeq1.SelectAll()
            txtSeq2.SelectAll()
            txtSeq2.Focus()
            Exit Sub
        End If

        Seq1 = "-" & txtSeq1.Text.Trim.ToUpper
        Seq2 = "-" & txtSeq2.Text.Trim.ToUpper
        match = CInt(txtMatch.Text.Trim)
        mismatch = CInt(txtMismatch.Text.Trim)
        gap = CInt(txtGap.Text.Trim)


        'string Seq1 = "-GAATTCAGTTA";
        'string Seq2 = "-GGATCGA";

        'Prepare Matrix for Computing optimal alignment
        Dim Matrix As Cell(,)
        Dim Aligner As New GlobalAlign2()

        ' Initialize matrix
        Matrix = Aligner.InitializationStep(Seq1, Seq2, match, mismatch, gap)

        ' prepare Datagridview to show result of Dynamic Programming Matrix
        'GridMatrix.AutoResizeColumns()
        GridMatrix.ColumnCount = Matrix.GetLength(1) + 1

        For i As Integer = 0 To (GridMatrix.ColumnCount - 1)
            GridMatrix.Columns(i).Width = 30
        Next
        GridMatrix.RowHeadersWidth = 30
        GridMatrix.ColumnHeadersHeight = 30
        GridMatrix.RowCount = Matrix.GetLength(0) + 1
        '*************************************
        'MsgBox(Matrix.GetLength(0).ToString)

        For j As Integer = 1 To (Matrix.GetLength(0) - 1)
            GridMatrix.Rows(j).Cells(0).Value = Seq2(j - 1)
        Next

        For i As Integer = 1 To (Matrix.GetLength(1) - 1)
            GridMatrix.Rows(0).Cells(i).Value = Seq1(i - 1)
        Next

        For j As Integer = 1 To (Matrix.GetLength(0) - 1)
            For i As Integer = 1 To (Matrix.GetLength(1) - 1)
                GridMatrix.Rows(j).Cells(i).Value = Matrix(j - 1, i - 1).CellScore
            Next
        Next

        ' Trace back matrix from end cell that contains max score { from end cell [SeqAlign2.Count - 1,SeqAlign1.Count - 1] to initial cell [0,0]}
        Aligner.TracebackStep(Matrix, Seq1, Seq2, SeqAlign1, SeqAlign2)

        ' Display Result of alignments
        ' note the trace in matrix done in reverse manner (trace back) 

        RichTextOutput.Clear()

        For j As Integer = SeqAlign1.Count - 1 To 0 Step -1
            RichTextOutput.AppendText(SeqAlign1(j).ToString)
        Next
        RichTextOutput.AppendText(vbCrLf)

        For k As Integer = SeqAlign2.Count - 1 To 0 Step -1
            RichTextOutput.AppendText(SeqAlign2(k).ToString)
        Next

        
        AnalyzeResult(SeqAlign1, SeqAlign2)

    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'txtSeq1.Text = "GAATTCAGTTA"
        'txtSeq2.Text = "GGATCGA"
        'txtMatch.Text = "1"
        'txtMismatch.Text = "-1"
        'txtGap.Text = "-2"
        Me.Top = 0
        Me.Left = 250
        lblInterpreted.Text = ""
        pnlAnalysis.Visible = False
    End Sub

    Private Sub txtSeq1_LostFocus(sender As Object, e As EventArgs) Handles txtSeq1.LostFocus
        If txtSeq1.Text <> "" Then txtSeq1.Text = txtSeq1.Text.ToUpper
    End Sub

    

    Private Sub txtSeq1_TextChanged(sender As Object, e As EventArgs) Handles txtSeq1.TextChanged

    End Sub

    Private Sub txtSeq2_LostFocus(sender As Object, e As EventArgs) Handles txtSeq2.LostFocus
        If txtSeq2.Text <> "" Then txtSeq2.Text = txtSeq2.Text.ToUpper
    End Sub

    Private Sub txtSeq2_TextChanged(sender As Object, e As EventArgs) Handles txtSeq2.TextChanged

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim reply As DialogResult
        reply = MessageBox.Show("Do You Really Want to Exit Application?", "EXIT", MessageBoxButtons.YesNo)
        If reply = vbYes Then
            End
        End If
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        RefreshPage()
    End Sub

    Private Sub AnalyzeResult(ByVal str1 As List(Of Char), ByVal str2 As List(Of Char))
        Dim str1Len, str2Len, counterMismatch, stringComparedLength As Integer
        Dim matchRatio As Single

        counterMismatch = 0
        stringComparedLength = 0
        For Each ch As Char In str1
            If (ch <> " ") Then str1Len += 1
            If (ch = "-") Then counterMismatch += 1
        Next

        For Each ch As Char In str2
            If (ch <> " ") Then str2Len += 1
            If (ch = "-") Then counterMismatch += 1
        Next

        If ((str1Len = str2Len) And counterMismatch < str1Len) Then
            matchRatio = (str1Len - counterMismatch) / str1Len

            lblInterpreted.Text = String.Format("{0:0.0%}", matchRatio) & vbCrLf & "Related"
            lblSampleSpace.Text = str1Len.ToString + " DNA Sequences"
            lblSimilarity.Text = String.Format("{0:0.0%}", matchRatio)
            lblVariation.Text = String.Format("{0:0.0%}", counterMismatch / str1Len)
            lblConclusion.Text = String.Format("{0:0.0%} Related", matchRatio)

            pnlAnalysis.Visible = True
            MessageBox.Show(String.Format("{0:0.0%} Related", matchRatio), "ANALYSIS")
        End If

    End Sub

    Private Sub AnalyzeResultLocal()
        Dim strLen1, strLen2 As Integer
        Dim matchDetectedCounter As Integer
        Dim MatchRatio, VariationRatio As Single
        Dim SampleSpace As Integer

        strLen1 = Seq1.Length - 1
        strLen2 = Seq2.Length - 1
        SampleSpace = strLen1 * strLen2

        matchDetectedCounter = Aligner.CountCellsWithMaxValue(Matrix, Seq1, Seq2)

        MatchRatio = matchDetectedCounter / SampleSpace
        VariationRatio = 1 - MatchRatio

        lblInterpreted.Text = String.Format("{0:0.0%}", MatchRatio) & vbCrLf & "Match Related cases"
        lblSampleSpace.Text = strLen1.ToString & " x " & strLen2.ToString & " DNA Sequences"
        lblSimilarity.Text = String.Format("{0:0.0%} Match Cases", MatchRatio)
        lblVariation.Text = String.Format("{0:0.0%} Mismatch Cases", VariationRatio)
        lblConclusion.Text = String.Format("{0:0.0%} Related Match Cases", MatchRatio)

        pnlAnalysis.Visible = True

        RichTextOutput.AppendText(vbCrLf & String.Format("{0:0.0%} Related DNA Match Cases", MatchRatio))
        RichTextOutput.SelectAll()
        RichTextOutput.SelectionAlignment = HorizontalAlignment.Center
        RichTextOutput.DeselectAll()

        MessageBox.Show(matchDetectedCounter & " DNA Match Pair Aligned, Out of " & SampleSpace & " Possible Match Cases " & _
                        vbCrLf & vbCrLf & "This Make Up for " & String.Format("{0:0.0%} of The Sample Space", MatchRatio), "RESULT ANALYSIS")

    End Sub

    Private Sub RefreshPage()
        txtSeq1.Clear()
        txtSeq2.Clear()
        txtMatch.Clear()
        txtMismatch.Clear()
        txtGap.Clear()
        RichTextOutput.Clear()
        For i As Integer = 0 To (GridMatrix.ColumnCount - 1)
            For j As Integer = 0 To (GridMatrix.RowCount - 1)
                GridMatrix.Item(i, j).Value = ""
            Next
        Next
        txtSeq1.Focus()
        lblInterpreted.Text = ""
        lblSampleSpace.Text = ""
        lblSimilarity.Text = ""
        lblVariation.Text = ""
        lblConclusion.Text = ""
        pnlAnalysis.Visible = False

    End Sub

End Class
