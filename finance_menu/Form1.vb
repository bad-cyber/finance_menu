Imports System.ComponentModel

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db_editor_log.Text = My.Settings.AUTH_l
        db_editor_pas.Text = My.Settings.AUTH_P
        ProgressBar1.Maximum = My.Settings.Nikita
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = ProgressBar1.Maximum - ProgressBar1.Value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ProgressBar1.Value += TextBox1.Text
        Label1.Text = ProgressBar1.Maximum
        My.Settings.Nikita = ProgressBar1.Maximum
        My.Settings.Upgrade()
        My.Settings.Save()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProgressBar1.Maximum += TextBox1.Text
        Label1.Text = ProgressBar1.Maximum
        My.Settings.Nikita = ProgressBar1.Maximum
        My.Settings.Upgrade()
        My.Settings.Save()
    End Sub
    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.Nikita = ProgressBar1.Maximum - ProgressBar1.Value 'Сохраняем результаты изменений в приложение
        My.Settings.Save()
        LoginForm1.Close()
    End Sub
End Class
