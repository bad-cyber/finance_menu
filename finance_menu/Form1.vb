Imports System.ComponentModel

Public Class Form1
    '=========================================================='
    'Custom ProgressBar:
    Dim progressbarrunit As Double
    Dim progressbarwidth, progressbarheight, progressbarcomplte As Integer
    Dim bmp As Bitmap
    Dim g As Graphics
    'End code
    '==========================================================='
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '===========================================================
        'Kod Egora:
        progressbarwidth = PictureBox1.Width
        progressbarheight = PictureBox1.Height
        progressbarrunit = progressbarwidth / 100
        'progressbarrunit = progressbarwidth / My.Settings.xZeyZSDtZ_M8PpJCn
        progressbarcomplte = 0
        bmp = New Bitmap(progressbarwidth, progressbarheight)
        Timer2.Start()
        'End code
        '===========================================================
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

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        'If Not Char.IsDigit(e.KeyChar) Then e.Handled = True 'Проверка на вшивость
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'A
        g = Graphics.FromImage(bmp)
        g.Clear(Color.Gray)
        g.FillRectangle(Brushes.LimeGreen, New Rectangle(0, 0, CInt(progressbarcomplte * progressbarrunit), progressbarheight))
        g.DrawString(progressbarcomplte & " руб.", New Font("Segoe UI", progressbarheight / 2), Brushes.Black, New PointF(progressbarwidth / 2 - progressbarheight, progressbarheight / 10))
        PictureBox1.Image = bmp
        progressbarcomplte += 1
        If (progressbarcomplte > 100) Then
            g.Dispose()
            Timer2.Stop()
        End If
        'B
    End Sub

    Private Sub page_settings_Click(sender As Object, e As EventArgs) Handles page_settings.Click
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    End Sub

    Private Sub db_editor_log_TextChanged(sender As Object, e As EventArgs) Handles db_editor_log.TextChanged
    End Sub

    Private Sub db_editor_pas_TextChanged(sender As Object, e As EventArgs) Handles db_editor_pas.TextChanged
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
    End Sub

    Private Sub page1_Click(sender As Object, e As EventArgs) Handles page1.Click

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
    End Sub
End Class