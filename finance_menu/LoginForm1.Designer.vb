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
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents QPyzM_mr4w6Wgf_pHd As System.Windows.Forms.TextBox
    Friend WithEvents n_n9UH_fKQnxRk_E6um As System.Windows.Forms.TextBox
    Friend WithEvents confirm_button As System.Windows.Forms.Button

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm1))
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.QPyzM_mr4w6Wgf_pHd = New System.Windows.Forms.TextBox()
        Me.n_n9UH_fKQnxRk_E6um = New System.Windows.Forms.TextBox()
        Me.confirm_button = New System.Windows.Forms.Button()
        Me.kL9LT___pwazbX4_5K9m = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.QPyzM_mr4w6Wgf_pHd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        Me.n_n9UH_fKQnxRk_E6um.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.n_n9UH_fKQnxRk_E6um.ForeColor = System.Drawing.Color.Black
        Me.n_n9UH_fKQnxRk_E6um.Location = New System.Drawing.Point(233, 93)
        Me.n_n9UH_fKQnxRk_E6um.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.n_n9UH_fKQnxRk_E6um.Name = "n_n9UH_fKQnxRk_E6um"
        Me.n_n9UH_fKQnxRk_E6um.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.n_n9UH_fKQnxRk_E6um.Size = New System.Drawing.Size(220, 20)
        Me.n_n9UH_fKQnxRk_E6um.TabIndex = 3
        '
        'confirm_button
        '
        Me.confirm_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.confirm_button.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.confirm_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.confirm_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.confirm_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.confirm_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.confirm_button.ForeColor = System.Drawing.Color.Lime
        Me.confirm_button.Location = New System.Drawing.Point(290, 166)
        Me.confirm_button.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.confirm_button.Name = "confirm_button"
        Me.confirm_button.Size = New System.Drawing.Size(116, 32)
        Me.confirm_button.TabIndex = 4
        Me.confirm_button.Text = "&Вход"
        Me.confirm_button.UseVisualStyleBackColor = False
        '
        'kL9LT___pwazbX4_5K9m
        '
        Me.kL9LT___pwazbX4_5K9m.AutoSize = True
        Me.kL9LT___pwazbX4_5K9m.BackColor = System.Drawing.Color.Black
        Me.kL9LT___pwazbX4_5K9m.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.kL9LT___pwazbX4_5K9m.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.kL9LT___pwazbX4_5K9m.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.kL9LT___pwazbX4_5K9m.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.kL9LT___pwazbX4_5K9m.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.kL9LT___pwazbX4_5K9m.ForeColor = System.Drawing.Color.Lime
        Me.kL9LT___pwazbX4_5K9m.Location = New System.Drawing.Point(233, 117)
        Me.kL9LT___pwazbX4_5K9m.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.kL9LT___pwazbX4_5K9m.Name = "kL9LT___pwazbX4_5K9m"
        Me.kL9LT___pwazbX4_5K9m.Size = New System.Drawing.Size(111, 17)
        Me.kL9LT___pwazbX4_5K9m.TabIndex = 6
        Me.kL9LT___pwazbX4_5K9m.Text = "Показать пароль"
        Me.kL9LT___pwazbX4_5K9m.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(227, 232)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'LoginForm1
        '
        Me.AcceptButton = Me.confirm_button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(481, 229)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.kL9LT___pwazbX4_5K9m)
        Me.Controls.Add(Me.confirm_button)
        Me.Controls.Add(Me.n_n9UH_fKQnxRk_E6um)
        Me.Controls.Add(Me.QPyzM_mr4w6Wgf_pHd)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(497, 268)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(497, 268)
        Me.Name = "LoginForm1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Auth to continue.."
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents kL9LT___pwazbX4_5K9m As CheckBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
End Class
