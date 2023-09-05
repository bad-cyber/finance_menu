<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")>
Partial Class LoginForm1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents QPyzM_mr4w6Wgf_pHd As System.Windows.Forms.TextBox
    Friend WithEvents n_n9UH_fKQnxRk_E6um As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.QPyzM_mr4w6Wgf_pHd = New System.Windows.Forms.TextBox()
        Me.n_n9UH_fKQnxRk_E6um = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackgroundImage = Global.finance_menu.My.Resources.Resources.Picsart_23_09_04_16_44_14_541
        Me.LogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LogoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LogoPictureBox.Location = New System.Drawing.Point(-22, -20)
        Me.LogoPictureBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(247, 274)
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'UsernameLabel
        '
        Me.UsernameLabel.ForeColor = System.Drawing.Color.Lime
        Me.UsernameLabel.Location = New System.Drawing.Point(231, 17)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&Имя пользователя"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.ForeColor = System.Drawing.Color.Lime
        Me.PasswordLabel.Location = New System.Drawing.Point(231, 66)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Пароль"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'QPyzM_mr4w6Wgf_pHd
        '
        Me.QPyzM_mr4w6Wgf_pHd.BackColor = System.Drawing.Color.Lime
        Me.QPyzM_mr4w6Wgf_pHd.ForeColor = System.Drawing.Color.Black
        Me.QPyzM_mr4w6Wgf_pHd.Location = New System.Drawing.Point(232, 44)
        Me.QPyzM_mr4w6Wgf_pHd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.QPyzM_mr4w6Wgf_pHd.MinimumSize = New System.Drawing.Size(220, 22)
        Me.QPyzM_mr4w6Wgf_pHd.Name = "QPyzM_mr4w6Wgf_pHd"
        Me.QPyzM_mr4w6Wgf_pHd.Size = New System.Drawing.Size(220, 20)
        Me.QPyzM_mr4w6Wgf_pHd.TabIndex = 1
        '
        'n_n9UH_fKQnxRk_E6um
        '
        Me.n_n9UH_fKQnxRk_E6um.BackColor = System.Drawing.Color.Lime
        Me.n_n9UH_fKQnxRk_E6um.ForeColor = System.Drawing.Color.Black
        Me.n_n9UH_fKQnxRk_E6um.Location = New System.Drawing.Point(233, 93)
        Me.n_n9UH_fKQnxRk_E6um.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.n_n9UH_fKQnxRk_E6um.Name = "n_n9UH_fKQnxRk_E6um"
        Me.n_n9UH_fKQnxRk_E6um.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.n_n9UH_fKQnxRk_E6um.Size = New System.Drawing.Size(220, 20)
        Me.n_n9UH_fKQnxRk_E6um.TabIndex = 3
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.OK.ForeColor = System.Drawing.Color.Lime
        Me.OK.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.OK.Location = New System.Drawing.Point(290, 175)
        Me.OK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(116, 23)
        Me.OK.TabIndex = 4
        Me.OK.Text = "&Вход"
        Me.OK.UseVisualStyleBackColor = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.Black
        Me.CheckBox2.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.CheckBox2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.CheckBox2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox2.ForeColor = System.Drawing.Color.Lime
        Me.CheckBox2.Location = New System.Drawing.Point(233, 117)
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(111, 17)
        Me.CheckBox2.TabIndex = 6
        Me.CheckBox2.Text = "Показать пароль"
        Me.CheckBox2.UseVisualStyleBackColor = False
        Me.CheckBox2.UseWaitCursor = True
        '
        'LoginForm1
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(481, 231)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.n_n9UH_fKQnxRk_E6um)
        Me.Controls.Add(Me.QPyzM_mr4w6Wgf_pHd)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(497, 270)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(497, 270)
        Me.Name = "LoginForm1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Timer1 As Timer
End Class
