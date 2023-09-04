Imports System.ComponentModel

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db_editor_log.Text = My.Settings.rt_6M6A__PMP8G_Es2cT
        db_editor_pas.Text = My.Settings.w_4HD_w5Fqkv6ref_Kq
        ProgressBar1.Maximum = My.Settings.xZeyZSDtZ_M8PpJCn
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = ProgressBar1.Maximum - ProgressBar1.Value
    End Sub

    Private Sub Aa1_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("Внимание! Пустые строки не являются переменными! Введите необходимые данные и повторите попытку.", MsgBoxStyle.Critical, "Ошибка №63!") : Exit Sub
        Else
            ProgressBar1.Value += TextBox1.Text 'Изменение значения у progressbar'а
            Label1.Text = ProgressBar1.Maximum 'Принятие данных надписью "MONEY"
            My.Settings.xZeyZSDtZ_M8PpJCn = ProgressBar1.Maximum 'Присвоение показателя в фиксированную настройку
            My.Settings.Upgrade() 'Дубль сохранения данных
            My.Settings.Save() 'Дубль сохранения данных
        End If
    End Sub

    Private Sub Bb2_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Внимание! Пустые строки не являются переменными! Введите необходимые данные и повторите попытку.", MsgBoxStyle.Critical, "Ошибка №63!") : Exit Sub
        Else
            ProgressBar1.Maximum += TextBox1.Text 'Изменение значения у progressbar'а
            Label1.Text = ProgressBar1.Maximum 'Принятие данных надписью "MONEY"
            My.Settings.xZeyZSDtZ_M8PpJCn = ProgressBar1.Maximum 'Присвоение показателя в фиксированную настройку
            My.Settings.Upgrade() 'Дубль сохранения данных
            My.Settings.Save() 'Дубль сохранения данных
        End If
    End Sub
    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.xZeyZSDtZ_M8PpJCn = ProgressBar1.Maximum - ProgressBar1.Value 'Сохраняем результаты изменений в приложение
        My.Settings.Save() 'Дубль сохранения данных
        LoginForm1.Close() 'Костыль на выключение при закрытии первого окна
    End Sub
End Class