Public Class LoginForm1

    ' TODO: �������� ��� ��� ������������� �������������� � �������������� ����������� ����� ������������ � ������ 
    ' (��. ������ �� ������ https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' ���������������� ��������� ����� ����� ���������� � ���������� ������ ��������� �������: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' ��� CustomPrincipal - ���������� ���������� IPrincipal, ������������ ��� ��������������. 
    ' ������������ My.User ����� ���������� ����������������� ����������, ����������� � ������� CustomPrincipal,
    ' ��������, ��� ������������, ������������ ��� � �.�.
    'CHANGELOG 1.1:
    '1. ������ ��������� � ��� ��� ���� ������
    '1.1. --> �������� ���������� ��������(��������� ������ -> ��������� ����� ����������, �������������� ������ �� ����� ���������, ���������� ��. +: ���� ; -: ������ �70
    '

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If QPyzM_mr4w6Wgf_pHd.Text = My.Settings.rt_6M6A__PMP8G_Es2cT And PasswordTextBox.Text = My.Settings.w_4HD_w5Fqkv6ref_Kq Then '���� login � password ������������� ��������, ��...
            OK.Text = "&�������������.."
            Me.Visible = False
            Form1.Visible = True
        ElseIf QPyzM_mr4w6Wgf_pHd.Text = "" Or PasswordTextBox.Text = "" Then
            MsgBox("��������! ������ ������ �� �������� �����������! ������� ����������� ������ � ��������� �������.",, "������ �63!") : Exit Sub
        ElseIf QPyzM_mr4w6Wgf_pHd.Text IsNot My.Settings.rt_6M6A__PMP8G_Es2cT Or PasswordTextBox.Text IsNot My.Settings.w_4HD_w5Fqkv6ref_Kq Then
            MsgBox("��������! ������ �� ������� � ���� ������. ���������� ��������� ����������� � ��������� � ��������� �������.",, "������ �70!")
            'QPyzM_mr4w6Wgf_pHd.Clear()
            'PasswordTextBox.Clear()
        End If '������� �������� �� ������������ �������� ������
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
