Public Class LoginForm1

    ' TODO: вставить код для настраиваемой аутентификации с использованием переданного имени пользователя и пароля 
    ' (См. статью по адресу https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' Пользовательский принципал можно затем подключить к принципалу потока следующим образом: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' где CustomPrincipal - реализация интерфейса IPrincipal, используемая для аутентификации. 
    ' Впоследствии My.User будет возвращать идентификационную информацию, заключенную в объекте CustomPrincipal,
    ' например, имя пользователя, отображаемое имя и т.д.
    'CHANGELOG 1.1:
    '1. Выводы сообщений о той или иной ошибке
    '1.1. --> Введение улучшенной проверки(принимаем данные -> прогоняем через шифрование, расшифровываем данные из самой программы, сравниваем их. +: Вход ; -: Ошибка №70
    '

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles confirm_button.Click
        If QPyzM_mr4w6Wgf_pHd.Text = My.Settings.rt_6M6A__PMP8G_Es2cT And n_n9UH_fKQnxRk_E6um.Text = My.Settings.w_4HD_w5Fqkv6ref_Kq Then 'Если login и password удовлетворяют условиям, то...
            confirm_button.Text = "&Инициализация.."
            Me.Visible = False
            Form1.Visible = True
        ElseIf QPyzM_mr4w6Wgf_pHd.Text = "" Or n_n9UH_fKQnxRk_E6um.Text = "" Then
            MsgBox("Внимание! Пустые строки не являются переменными! Введите необходимые данные и повторите попытку.", MsgBoxStyle.Critical, "Ошибка №63!") : Exit Sub
        ElseIf QPyzM_mr4w6Wgf_pHd.Text IsNot My.Settings.rt_6M6A__PMP8G_Es2cT Or n_n9UH_fKQnxRk_E6um.Text IsNot My.Settings.w_4HD_w5Fqkv6ref_Kq Then
            MsgBox("Внимание! Данные не найдены в базе данных. Пожалуйста проверьте подключение к интернету и повторите попытку.", MsgBoxStyle.Critical, "Ошибка №70!")
            QPyzM_mr4w6Wgf_pHd.Clear()
            n_n9UH_fKQnxRk_E6um.Clear()
        End If 'Базовая проверка на правильность введённых данных
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub PasswordLabel_Click(sender As Object, e As EventArgs) Handles PasswordLabel.Click
    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles n_n9UH_fKQnxRk_E6um.TextChanged
    End Sub

    Private Sub QPyzM_mr4w6Wgf_pHd_TextChanged(sender As Object, e As EventArgs) Handles QPyzM_mr4w6Wgf_pHd.TextChanged
    End Sub

    Private Sub UsernameLabel_Click(sender As Object, e As EventArgs) Handles UsernameLabel.Click
    End Sub

    Private Sub LogoPictureBox_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub kL9LT___pwazbX4_5K9m_CheckedChanged(sender As Object, e As EventArgs) Handles kL9LT___pwazbX4_5K9m.CheckedChanged
        If kL9LT___pwazbX4_5K9m.Checked = True Then 'Показать/Скрыть пароль v1
            n_n9UH_fKQnxRk_E6um.PasswordChar = ""
        Else
            n_n9UH_fKQnxRk_E6um.PasswordChar = "*"
        End If
    End Sub

    Private Sub OK_MouseMove(sender As Object, e As MouseEventArgs) Handles confirm_button.MouseMove
        confirm_button.ForeColor = Color.Black
        confirm_button.FlatAppearance.BorderColor = Color.Black
    End Sub

    Private Sub OK_MouseLeave(sender As Object, e As EventArgs) Handles confirm_button.MouseLeave
        confirm_button.ForeColor = Color.Lime
        confirm_button.FlatAppearance.BorderColor = Color.Lime
    End Sub
End Class
