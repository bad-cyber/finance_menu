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

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If QPyzM_mr4w6Wgf_pHd.Text = My.Settings.rt_6M6A__PMP8G_Es2cT And PasswordTextBox.Text = My.Settings.w_4HD_w5Fqkv6ref_Kq Then 'Если login и password удовлетворяют условиям, то...
            OK.Text = "&Инициализация.."
            Me.Visible = False
            Form1.Visible = True
        ElseIf QPyzM_mr4w6Wgf_pHd.Text = "" Or PasswordTextBox.Text = "" Then
            MsgBox("Внимание! Пустые строки не являются переменными! Введите необходимые данные и повторите попытку.", MsgBoxStyle.Critical, "Ошибка №63!") : Exit Sub
        ElseIf QPyzM_mr4w6Wgf_pHd.Text IsNot My.Settings.rt_6M6A__PMP8G_Es2cT Or PasswordTextBox.Text IsNot My.Settings.w_4HD_w5Fqkv6ref_Kq Then
            MsgBox("Внимание! Данные не найдены в базе данных. Пожалуйста проверьте подключение к интернету и повторите попытку.", MsgBoxStyle.Critical, "Ошибка №70!")
            'QPyzM_mr4w6Wgf_pHd.Clear()
            'PasswordTextBox.Clear()
        End If 'Базовая проверка на правильность введённых данных
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PasswordLabel_Click(sender As Object, e As EventArgs) Handles PasswordLabel.Click

    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged

    End Sub

    Private Sub QPyzM_mr4w6Wgf_pHd_TextChanged(sender As Object, e As EventArgs) Handles QPyzM_mr4w6Wgf_pHd.TextChanged

    End Sub

    Private Sub UsernameLabel_Click(sender As Object, e As EventArgs) Handles UsernameLabel.Click

    End Sub

    Private Sub LogoPictureBox_Click(sender As Object, e As EventArgs) Handles LogoPictureBox.Click

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub
End Class
