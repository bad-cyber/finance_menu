Public Class LoginForm1

    ' TODO: вставить код для настраиваемой аутентификации с использованием переданного имени пользователя и пароля 
    ' (См. статью по адресу https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' Пользовательский принципал можно затем подключить к принципалу потока следующим образом: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' где CustomPrincipal - реализация интерфейса IPrincipal, используемая для аутентификации. 
    ' Впоследствии My.User будет возвращать идентификационную информацию, заключенную в объекте CustomPrincipal,
    ' например, имя пользователя, отображаемое имя и т.д.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = My.Settings.AUTH_l And PasswordTextBox.Text = My.Settings.AUTH_P Then
            OK.Text = "&Инициализация.."
            Me.Visible = False
            Form1.Visible = True
        Else
            UsernameTextBox.Clear()
            PasswordTextBox.Clear()
        End If 'Базовая проверка на правильность введённых данных
    End Sub
End Class
