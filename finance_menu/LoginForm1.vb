Public Class LoginForm1

    ' TODO: �������� ��� ��� ������������� �������������� � �������������� ����������� ����� ������������ � ������ 
    ' (��. ������ �� ������ https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' ���������������� ��������� ����� ����� ���������� � ���������� ������ ��������� �������: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' ��� CustomPrincipal - ���������� ���������� IPrincipal, ������������ ��� ��������������. 
    ' ������������ My.User ����� ���������� ����������������� ����������, ����������� � ������� CustomPrincipal,
    ' ��������, ��� ������������, ������������ ��� � �.�.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = My.Settings.AUTH_l And PasswordTextBox.Text = My.Settings.AUTH_P Then
            OK.Text = "&�������������.."
            Me.Visible = False
            Form1.Visible = True
        Else
            UsernameTextBox.Clear()
            PasswordTextBox.Clear()
        End If '������� �������� �� ������������ �������� ������
    End Sub
End Class
