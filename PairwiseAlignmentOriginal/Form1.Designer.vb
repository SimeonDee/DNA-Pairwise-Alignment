<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.btnGlobal = New System.Windows.Forms.Button()
        Me.btnLocal = New System.Windows.Forms.Button()
        Me.txtGap = New System.Windows.Forms.TextBox()
        Me.txtMismatch = New System.Windows.Forms.TextBox()
        Me.txtMatch = New System.Windows.Forms.TextBox()
        Me.txtSeq2 = New System.Windows.Forms.TextBox()
        Me.txtSeq1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RichTextOutput = New System.Windows.Forms.RichTextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.pnlAnalysis = New System.Windows.Forms.Panel()
        Me.lblConclusion = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblVariation = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblSimilarity = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblSampleSpace = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblInterpreted = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GridMatrix = New System.Windows.Forms.DataGridView()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnLocalCompact = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.pnlAnalysis.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.GridMatrix, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGlobal
        '
        Me.btnGlobal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGlobal.Location = New System.Drawing.Point(1158, 9)
        Me.btnGlobal.Name = "btnGlobal"
        Me.btnGlobal.Size = New System.Drawing.Size(144, 66)
        Me.btnGlobal.TabIndex = 11
        Me.btnGlobal.Text = "ALIGN GLOBAL"
        Me.btnGlobal.UseVisualStyleBackColor = True
        '
        'btnLocal
        '
        Me.btnLocal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLocal.Location = New System.Drawing.Point(868, 8)
        Me.btnLocal.Name = "btnLocal"
        Me.btnLocal.Size = New System.Drawing.Size(134, 68)
        Me.btnLocal.TabIndex = 10
        Me.btnLocal.Text = "ALIGN LOCAL"
        Me.btnLocal.UseVisualStyleBackColor = True
        '
        'txtGap
        '
        Me.txtGap.Location = New System.Drawing.Point(735, 69)
        Me.txtGap.Name = "txtGap"
        Me.txtGap.Size = New System.Drawing.Size(68, 20)
        Me.txtGap.TabIndex = 9
        '
        'txtMismatch
        '
        Me.txtMismatch.Location = New System.Drawing.Point(475, 71)
        Me.txtMismatch.Name = "txtMismatch"
        Me.txtMismatch.Size = New System.Drawing.Size(68, 20)
        Me.txtMismatch.TabIndex = 8
        '
        'txtMatch
        '
        Me.txtMatch.Location = New System.Drawing.Point(205, 69)
        Me.txtMatch.Name = "txtMatch"
        Me.txtMatch.Size = New System.Drawing.Size(68, 20)
        Me.txtMatch.TabIndex = 7
        '
        'txtSeq2
        '
        Me.txtSeq2.Location = New System.Drawing.Point(205, 39)
        Me.txtSeq2.Name = "txtSeq2"
        Me.txtSeq2.Size = New System.Drawing.Size(639, 20)
        Me.txtSeq2.TabIndex = 6
        '
        'txtSeq1
        '
        Me.txtSeq1.Location = New System.Drawing.Point(205, 8)
        Me.txtSeq1.Name = "txtSeq1"
        Me.txtSeq1.Size = New System.Drawing.Size(639, 20)
        Me.txtSeq1.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(631, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Gap Penalty"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(344, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Mismatch Score"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Match Score"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Enter the Second Sequence"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Enter the First Sequence"
        '
        'RichTextOutput
        '
        Me.RichTextOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextOutput.Location = New System.Drawing.Point(4, 436)
        Me.RichTextOutput.Name = "RichTextOutput"
        Me.RichTextOutput.Size = New System.Drawing.Size(1081, 82)
        Me.RichTextOutput.TabIndex = 1
        Me.RichTextOutput.Text = ""
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.lblInterpreted)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.lblOutput)
        Me.Panel4.Controls.Add(Me.RichTextOutput)
        Me.Panel4.Location = New System.Drawing.Point(5, 111)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1323, 528)
        Me.Panel4.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.pnlAnalysis)
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Location = New System.Drawing.Point(1090, 30)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(226, 398)
        Me.Panel6.TabIndex = 6
        '
        'pnlAnalysis
        '
        Me.pnlAnalysis.Controls.Add(Me.lblConclusion)
        Me.pnlAnalysis.Controls.Add(Me.Label14)
        Me.pnlAnalysis.Controls.Add(Me.lblVariation)
        Me.pnlAnalysis.Controls.Add(Me.Label12)
        Me.pnlAnalysis.Controls.Add(Me.lblSimilarity)
        Me.pnlAnalysis.Controls.Add(Me.Label10)
        Me.pnlAnalysis.Controls.Add(Me.lblSampleSpace)
        Me.pnlAnalysis.Controls.Add(Me.Label8)
        Me.pnlAnalysis.Location = New System.Drawing.Point(3, 44)
        Me.pnlAnalysis.Name = "pnlAnalysis"
        Me.pnlAnalysis.Size = New System.Drawing.Size(219, 349)
        Me.pnlAnalysis.TabIndex = 17
        '
        'lblConclusion
        '
        Me.lblConclusion.AllowDrop = True
        Me.lblConclusion.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConclusion.Location = New System.Drawing.Point(14, 319)
        Me.lblConclusion.Name = "lblConclusion"
        Me.lblConclusion.Size = New System.Drawing.Size(194, 19)
        Me.lblConclusion.TabIndex = 24
        Me.lblConclusion.Text = "100.0% Related"
        Me.lblConclusion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(49, 295)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(124, 20)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "CONCLUSION"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVariation
        '
        Me.lblVariation.AllowDrop = True
        Me.lblVariation.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVariation.Location = New System.Drawing.Point(35, 234)
        Me.lblVariation.Name = "lblVariation"
        Me.lblVariation.Size = New System.Drawing.Size(150, 19)
        Me.lblVariation.TabIndex = 22
        Me.lblVariation.Text = "Sample Space:"
        Me.lblVariation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(68, 206)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 20)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Variation:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSimilarity
        '
        Me.lblSimilarity.AllowDrop = True
        Me.lblSimilarity.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSimilarity.Location = New System.Drawing.Point(39, 145)
        Me.lblSimilarity.Name = "lblSimilarity"
        Me.lblSimilarity.Size = New System.Drawing.Size(148, 19)
        Me.lblSimilarity.TabIndex = 20
        Me.lblSimilarity.Text = "Sample Space:"
        Me.lblSimilarity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(68, 119)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 20)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Similarity:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSampleSpace
        '
        Me.lblSampleSpace.AllowDrop = True
        Me.lblSampleSpace.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSampleSpace.Location = New System.Drawing.Point(16, 47)
        Me.lblSampleSpace.Name = "lblSampleSpace"
        Me.lblSampleSpace.Size = New System.Drawing.Size(190, 19)
        Me.lblSampleSpace.TabIndex = 18
        Me.lblSampleSpace.Text = "Sample Space:"
        Me.lblSampleSpace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(44, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(130, 20)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Sample Space:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Elephant", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(57, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 31)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "ANALYSIS"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInterpreted
        '
        Me.lblInterpreted.AllowDrop = True
        Me.lblInterpreted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInterpreted.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterpreted.Location = New System.Drawing.Point(1094, 436)
        Me.lblInterpreted.Name = "lblInterpreted"
        Me.lblInterpreted.Size = New System.Drawing.Size(218, 83)
        Me.lblInterpreted.TabIndex = 5
        Me.lblInterpreted.Text = "50% Related"
        Me.lblInterpreted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.AutoScroll = True
        Me.Panel5.Controls.Add(Me.GridMatrix)
        Me.Panel5.Location = New System.Drawing.Point(4, 30)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1081, 399)
        Me.Panel5.TabIndex = 4
        '
        'GridMatrix
        '
        Me.GridMatrix.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GridMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridMatrix.Location = New System.Drawing.Point(6, 6)
        Me.GridMatrix.Name = "GridMatrix"
        Me.GridMatrix.Size = New System.Drawing.Size(1069, 387)
        Me.GridMatrix.TabIndex = 1
        '
        'lblOutput
        '
        Me.lblOutput.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(4, 2)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(1308, 25)
        Me.lblOutput.TabIndex = 3
        Me.lblOutput.Text = "OUTPUT"
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(12, 78)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1338, 648)
        Me.Panel2.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnLocalCompact)
        Me.Panel3.Controls.Add(Me.btnGlobal)
        Me.Panel3.Controls.Add(Me.btnLocal)
        Me.Panel3.Controls.Add(Me.txtGap)
        Me.Panel3.Controls.Add(Me.txtMismatch)
        Me.Panel3.Controls.Add(Me.txtMatch)
        Me.Panel3.Controls.Add(Me.txtSeq2)
        Me.Panel3.Controls.Add(Me.txtSeq1)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(4, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1326, 99)
        Me.Panel3.TabIndex = 0
        '
        'btnLocalCompact
        '
        Me.btnLocalCompact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLocalCompact.Location = New System.Drawing.Point(1011, 8)
        Me.btnLocalCompact.Name = "btnLocalCompact"
        Me.btnLocalCompact.Size = New System.Drawing.Size(134, 67)
        Me.btnLocalCompact.TabIndex = 12
        Me.btnLocalCompact.Text = "ALIGN LOCAL COMPACT"
        Me.btnLocalCompact.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(109, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1118, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "PAIRWISE SEQUENCE LOCAL AND GLOBAL ALIGNMENT USING NEEDLEMAN AND SMITH WATERMAN'S" & _
    " ALGORITHMNS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1338, 37)
        Me.Panel1.TabIndex = 5
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1362, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(98, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "ABOSEDE AND TOSIN"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel4.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.pnlAnalysis.ResumeLayout(False)
        Me.pnlAnalysis.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.GridMatrix, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGlobal As System.Windows.Forms.Button
    Friend WithEvents btnLocal As System.Windows.Forms.Button
    Friend WithEvents txtGap As System.Windows.Forms.TextBox
    Friend WithEvents txtMismatch As System.Windows.Forms.TextBox
    Friend WithEvents txtMatch As System.Windows.Forms.TextBox
    Friend WithEvents txtSeq2 As System.Windows.Forms.TextBox
    Friend WithEvents txtSeq1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RichTextOutput As System.Windows.Forms.RichTextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblInterpreted As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents GridMatrix As System.Windows.Forms.DataGridView
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents pnlAnalysis As System.Windows.Forms.Panel
    Friend WithEvents lblConclusion As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblVariation As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblSimilarity As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblSampleSpace As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnLocalCompact As System.Windows.Forms.Button

End Class
