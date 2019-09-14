Public Class FrmSplash

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub FrmSplash_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub FrmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 10
        Me.Left = 150
    End Sub
End Class