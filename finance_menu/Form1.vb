Imports System.ComponentModel

Public Class Form1
    Private Const V_rub As String = " руб."
    Private Sub Loading_set()
        db_editor_log.Text = My.Settings.rt_6M6A__PMP8G_Es2cT
        db_editor_pas.Text = My.Settings.w_4HD_w5Fqkv6ref_Kq
        ProgressBar1.Maximum = My.Settings.xZeyZSDtZ_M8PpJCn 'user1
        ProgressBar2.Maximum = My.Settings.y6X6eyNr_ZGNgPK2M 'user2
        ProgressBar3.Maximum = My.Settings.W84Ammg_gcy__LhxKja 'user3
        ProgressBar4.Maximum = My.Settings.JVJtJ4z_A9V3FnwmS 'user4
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loading_set()
    End Sub
    Private Shared Sub Critical()
        MsgBox("Внимание! Пустые строки не являются переменными! Введите необходимые данные и повторите попытку.", MsgBoxStyle.Critical, "Ошибка №63!")
    End Sub
    Private Shared Sub Critical_pb()
        MsgBox("Значение не может быть отрицательным.", MsgBoxStyle.Critical, "Ошибка №64!")
    End Sub
    Private Shared Sub Er_message()
        MsgBox("Данное окно на этапе разработки*", MsgBoxStyle.Information, "Ошибка №404!")
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = CStr(ProgressBar1.Maximum - ProgressBar1.Value) + V_rub
        Label2.Text = CStr(ProgressBar2.Maximum - ProgressBar2.Value) + V_rub
        Label3.Text = CStr(ProgressBar3.Maximum - ProgressBar3.Value) + V_rub
        Label4.Text = CStr(ProgressBar4.Maximum - ProgressBar4.Value) + V_rub
    End Sub
    Private Sub Aa1_Click(sender As Object, e As EventArgs) Handles bb1.Click '1
        If ProgressBar1.Maximum >= CInt(TextBox1.Text) Then
            If TextBox1.Text = "" Then
                Critical() : Exit Sub
            Else
                ProgressBar1.Value += CInt(TextBox1.Text) 'Изменение значения у progressbar'а
                Label1.Text = CStr(ProgressBar1.Maximum) 'Принятие данных надписью "MONEY"
                My.Settings.xZeyZSDtZ_M8PpJCn = ProgressBar1.Maximum 'Присвоение показателя в фиксированную настройку
                My.Settings.Upgrade() 'Дубль сохранения данных
                My.Settings.Save() 'Дубль сохранения данных
            End If
        Else
            Critical_pb() : Exit Sub
        End If
    End Sub
    Private Sub Bb2_Click(sender As Object, e As EventArgs) Handles bb2.Click '1
        If TextBox1.Text = "" Then
            Critical() : Exit Sub
        Else
            ProgressBar1.Maximum += CInt(TextBox1.Text) 'Изменение значения у progressbar'а
            Label1.Text = CStr(ProgressBar1.Maximum) 'Принятие данных надписью "MONEY"
            My.Settings.xZeyZSDtZ_M8PpJCn = ProgressBar1.Maximum 'Присвоение показателя в фиксированную настройку
            My.Settings.Upgrade() 'Дубль сохранения данных
            My.Settings.Save() 'Дубль сохранения данных
        End If
    End Sub
    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.xZeyZSDtZ_M8PpJCn = ProgressBar1.Maximum - ProgressBar1.Value 'Сохраняем результаты изменений в приложение
        My.Settings.y6X6eyNr_ZGNgPK2M = ProgressBar2.Maximum - ProgressBar2.Value 'Сохраняем результаты изменений в приложение
        My.Settings.W84Ammg_gcy__LhxKja = ProgressBar3.Maximum - ProgressBar3.Value 'Сохраняем результаты изменений в приложение
        My.Settings.JVJtJ4z_A9V3FnwmS = ProgressBar4.Maximum - ProgressBar4.Value 'Сохраняем результаты изменений в приложение
        My.Settings.Save() 'Дубль сохранения данных
        LoginForm1.Close() 'Костыль на выключение при закрытии первого окна
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 'change log/pass
        If db_editor_log.Text = "" Or db_editor_pas.Text = "" Then
            Critical() : Exit Sub
        Else
            My.Settings.rt_6M6A__PMP8G_Es2cT = db_editor_log.Text
            My.Settings.w_4HD_w5Fqkv6ref_Kq = db_editor_pas.Text
            MsgBox("Логин или пароль успешно изменены. |                         Логин: " + My.Settings.rt_6M6A__PMP8G_Es2cT + "; Пароль: " + My.Settings.w_4HD_w5Fqkv6ref_Kq, MsgBoxStyle.Information, "finance_menu")
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'exit
        My.Settings.Save() 'Дубль сохранения данных
        LoginForm1.Close() 'Костыль на выключение при закрытии первого окна
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Er_message() : Exit Sub
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Er_message() : Exit Sub
    End Sub
    Private Sub bb3_Click(sender As Object, e As EventArgs) Handles bb3.Click '2
        If ProgressBar2.Maximum >= CInt(TextBox2.Text) Then
            If TextBox2.Text = "" Then
                Critical() : Exit Sub
            Else
                ProgressBar2.Value += CInt(TextBox2.Text) 'Изменение значения у progressbar'а
                Label2.Text = CStr(ProgressBar2.Maximum) 'Принятие данных надписью "MONEY"
                My.Settings.y6X6eyNr_ZGNgPK2M = ProgressBar2.Maximum 'Присвоение показателя в фиксированную настройку
                My.Settings.Upgrade() 'Дубль сохранения данных
                My.Settings.Save() 'Дубль сохранения данных
            End If
        Else
            Critical_pb() : Exit Sub
        End If
    End Sub
    Private Sub bb4_Click(sender As Object, e As EventArgs) Handles bb4.Click '2
        If TextBox2.Text = "" Then
            Critical() : Exit Sub
        Else
            ProgressBar2.Maximum += CInt(TextBox2.Text) 'Изменение значения у progressbar'а
            Label2.Text = CStr(ProgressBar2.Maximum) 'Принятие данных надписью "MONEY"
            My.Settings.y6X6eyNr_ZGNgPK2M = ProgressBar2.Maximum 'Присвоение показателя в фиксированную настройку
            My.Settings.Upgrade() 'Дубль сохранения данных
            My.Settings.Save() 'Дубль сохранения данных
        End If
    End Sub
    Private Sub bb5_Click(sender As Object, e As EventArgs) Handles bb5.Click '3
        If ProgressBar3.Maximum >= CInt(TextBox3.Text) Then
            If TextBox3.Text = "" Then
                Critical() : Exit Sub
            Else
                ProgressBar3.Value += CInt(TextBox3.Text) 'Изменение значения у progressbar'а
                Label3.Text = CStr(ProgressBar3.Maximum) 'Принятие данных надписью "MONEY"
                My.Settings.W84Ammg_gcy__LhxKja = ProgressBar3.Maximum 'Присвоение показателя в фиксированную настройку
                My.Settings.Upgrade() 'Дубль сохранения данных
                My.Settings.Save() 'Дубль сохранения данных
            End If
        Else
            Critical_pb() : Exit Sub
        End If
    End Sub
    Private Sub bb6_Click(sender As Object, e As EventArgs) Handles bb6.Click '3
        If TextBox3.Text = "" Then
            Critical() : Exit Sub
        Else
            ProgressBar3.Maximum += CInt(TextBox3.Text) 'Изменение значения у progressbar'а
            Label3.Text = CStr(ProgressBar3.Maximum) 'Принятие данных надписью "MONEY"
            My.Settings.W84Ammg_gcy__LhxKja = ProgressBar3.Maximum 'Присвоение показателя в фиксированную настройку
            My.Settings.Upgrade() 'Дубль сохранения данных
            My.Settings.Save() 'Дубль сохранения данных
        End If
    End Sub
    Private Sub bb7_Click(sender As Object, e As EventArgs) Handles bb7.Click '4
        If ProgressBar4.Maximum >= CInt(TextBox4.Text) Then
            If TextBox4.Text = "" Then
                Critical() : Exit Sub
            Else
                ProgressBar4.Value += CInt(TextBox4.Text) 'Изменение значения у progressbar'а
                Label4.Text = CStr(ProgressBar4.Maximum) 'Принятие данных надписью "MONEY"
                My.Settings.JVJtJ4z_A9V3FnwmS = ProgressBar4.Maximum 'Присвоение показателя в фиксированную настройку
                My.Settings.Upgrade() 'Дубль сохранения данных
                My.Settings.Save() 'Дубль сохранения данных
            End If
        Else
            Critical_pb() : Exit Sub
        End If
    End Sub
    Private Sub bb8_Click(sender As Object, e As EventArgs) Handles bb8.Click '4
        If TextBox4.Text = "" Then
            Critical() : Exit Sub
        Else
            ProgressBar4.Maximum += CInt(TextBox4.Text) 'Изменение значения у progressbar'а
            Label4.Text = CStr(ProgressBar4.Maximum) 'Принятие данных надписью "MONEY"
            My.Settings.JVJtJ4z_A9V3FnwmS = ProgressBar4.Maximum 'Присвоение показателя в фиксированную настройку
            My.Settings.Upgrade() 'Дубль сохранения данных
            My.Settings.Save() 'Дубль сохранения данных
        End If
    End Sub
End Class