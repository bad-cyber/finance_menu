<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.page1 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.bb1 = New System.Windows.Forms.Button()
        Me.bb2 = New System.Windows.Forms.Button()
        Me.page2 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.bb3 = New System.Windows.Forms.Button()
        Me.bb4 = New System.Windows.Forms.Button()
        Me.page3 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProgressBar3 = New System.Windows.Forms.ProgressBar()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.bb5 = New System.Windows.Forms.Button()
        Me.bb6 = New System.Windows.Forms.Button()
        Me.page4 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProgressBar4 = New System.Windows.Forms.ProgressBar()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.bb7 = New System.Windows.Forms.Button()
        Me.bb8 = New System.Windows.Forms.Button()
        Me.page5 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.page6 = New System.Windows.Forms.TabPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.page_settings = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.db_editor_pas = New System.Windows.Forms.TextBox()
        Me.db_editor_log = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.page1.SuspendLayout()
        Me.page2.SuspendLayout()
        Me.page3.SuspendLayout()
        Me.page4.SuspendLayout()
        Me.page5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.page6.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.page_settings.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.page1)
        Me.TabControl1.Controls.Add(Me.page2)
        Me.TabControl1.Controls.Add(Me.page3)
        Me.TabControl1.Controls.Add(Me.page4)
        Me.TabControl1.Controls.Add(Me.page5)
        Me.TabControl1.Controls.Add(Me.page6)
        Me.TabControl1.Controls.Add(Me.page_settings)
        Me.TabControl1.Location = New System.Drawing.Point(-4, -2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(452, 361)
        Me.TabControl1.TabIndex = 5
        '
        'page1
        '
        Me.page1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.page1.Controls.Add(Me.Label1)
        Me.page1.Controls.Add(Me.ProgressBar1)
        Me.page1.Controls.Add(Me.TextBox1)
        Me.page1.Controls.Add(Me.bb1)
        Me.page1.Controls.Add(Me.bb2)
        Me.page1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.page1.Location = New System.Drawing.Point(4, 22)
        Me.page1.Name = "page1"
        Me.page1.Padding = New System.Windows.Forms.Padding(3)
        Me.page1.Size = New System.Drawing.Size(444, 335)
        Me.page1.TabIndex = 0
        Me.page1.Text = "Никита"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(197, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "TEXT"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(10, 142)
        Me.ProgressBar1.Maximum = 1
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(418, 23)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Lime
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(116, 172)
        Me.TextBox1.MaxLength = 7
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(206, 22)
        Me.TextBox1.TabIndex = 4
        '
        'bb1
        '
        Me.bb1.BackColor = System.Drawing.Color.Black
        Me.bb1.ForeColor = System.Drawing.Color.Lime
        Me.bb1.Location = New System.Drawing.Point(17, 107)
        Me.bb1.Name = "bb1"
        Me.bb1.Size = New System.Drawing.Size(85, 32)
        Me.bb1.TabIndex = 1
        Me.bb1.Text = "Вернул"
        Me.bb1.UseVisualStyleBackColor = False
        '
        'bb2
        '
        Me.bb2.BackColor = System.Drawing.Color.Black
        Me.bb2.ForeColor = System.Drawing.Color.Lime
        Me.bb2.Location = New System.Drawing.Point(339, 107)
        Me.bb2.Name = "bb2"
        Me.bb2.Size = New System.Drawing.Size(86, 32)
        Me.bb2.TabIndex = 0
        Me.bb2.Text = "Взял"
        Me.bb2.UseVisualStyleBackColor = False
        '
        'page2
        '
        Me.page2.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.page2.Controls.Add(Me.Label2)
        Me.page2.Controls.Add(Me.ProgressBar2)
        Me.page2.Controls.Add(Me.TextBox2)
        Me.page2.Controls.Add(Me.bb3)
        Me.page2.Controls.Add(Me.bb4)
        Me.page2.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.page2.Location = New System.Drawing.Point(4, 22)
        Me.page2.Name = "page2"
        Me.page2.Padding = New System.Windows.Forms.Padding(3)
        Me.page2.Size = New System.Drawing.Size(444, 335)
        Me.page2.TabIndex = 1
        Me.page2.Text = "Александр"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(197, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "TEXT"
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(10, 148)
        Me.ProgressBar2.Maximum = 1
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(418, 23)
        Me.ProgressBar2.Step = 1
        Me.ProgressBar2.TabIndex = 11
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Lime
        Me.TextBox2.ForeColor = System.Drawing.Color.Black
        Me.TextBox2.Location = New System.Drawing.Point(116, 178)
        Me.TextBox2.MaxLength = 7
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(206, 22)
        Me.TextBox2.TabIndex = 10
        '
        'bb3
        '
        Me.bb3.BackColor = System.Drawing.Color.Black
        Me.bb3.ForeColor = System.Drawing.Color.Lime
        Me.bb3.Location = New System.Drawing.Point(11, 113)
        Me.bb3.Name = "bb3"
        Me.bb3.Size = New System.Drawing.Size(85, 32)
        Me.bb3.TabIndex = 8
        Me.bb3.Text = "Вернул"
        Me.bb3.UseVisualStyleBackColor = False
        '
        'bb4
        '
        Me.bb4.BackColor = System.Drawing.Color.Black
        Me.bb4.ForeColor = System.Drawing.Color.Lime
        Me.bb4.Location = New System.Drawing.Point(343, 113)
        Me.bb4.Name = "bb4"
        Me.bb4.Size = New System.Drawing.Size(85, 32)
        Me.bb4.TabIndex = 7
        Me.bb4.Text = "Взял"
        Me.bb4.UseVisualStyleBackColor = False
        '
        'page3
        '
        Me.page3.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.page3.Controls.Add(Me.Label3)
        Me.page3.Controls.Add(Me.ProgressBar3)
        Me.page3.Controls.Add(Me.TextBox3)
        Me.page3.Controls.Add(Me.bb5)
        Me.page3.Controls.Add(Me.bb6)
        Me.page3.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.page3.Location = New System.Drawing.Point(4, 22)
        Me.page3.Name = "page3"
        Me.page3.Size = New System.Drawing.Size(444, 335)
        Me.page3.TabIndex = 2
        Me.page3.Text = "Светлана"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(197, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 19)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "TEXT"
        '
        'ProgressBar3
        '
        Me.ProgressBar3.Location = New System.Drawing.Point(10, 147)
        Me.ProgressBar3.Maximum = 1
        Me.ProgressBar3.Name = "ProgressBar3"
        Me.ProgressBar3.Size = New System.Drawing.Size(418, 23)
        Me.ProgressBar3.Step = 1
        Me.ProgressBar3.TabIndex = 11
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.Lime
        Me.TextBox3.ForeColor = System.Drawing.Color.Black
        Me.TextBox3.Location = New System.Drawing.Point(116, 177)
        Me.TextBox3.MaxLength = 7
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(206, 22)
        Me.TextBox3.TabIndex = 10
        '
        'bb5
        '
        Me.bb5.BackColor = System.Drawing.Color.Black
        Me.bb5.ForeColor = System.Drawing.Color.Lime
        Me.bb5.Location = New System.Drawing.Point(17, 112)
        Me.bb5.Name = "bb5"
        Me.bb5.Size = New System.Drawing.Size(85, 32)
        Me.bb5.TabIndex = 8
        Me.bb5.Text = "Вернул"
        Me.bb5.UseVisualStyleBackColor = False
        '
        'bb6
        '
        Me.bb6.BackColor = System.Drawing.Color.Black
        Me.bb6.ForeColor = System.Drawing.Color.Lime
        Me.bb6.Location = New System.Drawing.Point(339, 112)
        Me.bb6.Name = "bb6"
        Me.bb6.Size = New System.Drawing.Size(86, 32)
        Me.bb6.TabIndex = 7
        Me.bb6.Text = "Взял"
        Me.bb6.UseVisualStyleBackColor = False
        '
        'page4
        '
        Me.page4.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.page4.Controls.Add(Me.Label4)
        Me.page4.Controls.Add(Me.ProgressBar4)
        Me.page4.Controls.Add(Me.TextBox4)
        Me.page4.Controls.Add(Me.bb7)
        Me.page4.Controls.Add(Me.bb8)
        Me.page4.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.page4.Location = New System.Drawing.Point(4, 22)
        Me.page4.Name = "page4"
        Me.page4.Size = New System.Drawing.Size(444, 335)
        Me.page4.TabIndex = 3
        Me.page4.Text = "Юрий"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(197, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 19)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "TEXT"
        '
        'ProgressBar4
        '
        Me.ProgressBar4.Location = New System.Drawing.Point(10, 146)
        Me.ProgressBar4.Maximum = 1
        Me.ProgressBar4.Name = "ProgressBar4"
        Me.ProgressBar4.Size = New System.Drawing.Size(418, 23)
        Me.ProgressBar4.Step = 1
        Me.ProgressBar4.TabIndex = 11
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.Lime
        Me.TextBox4.ForeColor = System.Drawing.Color.Black
        Me.TextBox4.Location = New System.Drawing.Point(116, 176)
        Me.TextBox4.MaxLength = 7
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(206, 22)
        Me.TextBox4.TabIndex = 10
        '
        'bb7
        '
        Me.bb7.BackColor = System.Drawing.Color.Black
        Me.bb7.ForeColor = System.Drawing.Color.Lime
        Me.bb7.Location = New System.Drawing.Point(17, 111)
        Me.bb7.Name = "bb7"
        Me.bb7.Size = New System.Drawing.Size(85, 32)
        Me.bb7.TabIndex = 8
        Me.bb7.Text = "Вернул"
        Me.bb7.UseVisualStyleBackColor = False
        '
        'bb8
        '
        Me.bb8.BackColor = System.Drawing.Color.Black
        Me.bb8.ForeColor = System.Drawing.Color.Lime
        Me.bb8.Location = New System.Drawing.Point(339, 111)
        Me.bb8.Name = "bb8"
        Me.bb8.Size = New System.Drawing.Size(86, 32)
        Me.bb8.TabIndex = 7
        Me.bb8.Text = "Взял"
        Me.bb8.UseVisualStyleBackColor = False
        '
        'page5
        '
        Me.page5.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.page5.Controls.Add(Me.PictureBox1)
        Me.page5.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.page5.Location = New System.Drawing.Point(4, 22)
        Me.page5.Name = "page5"
        Me.page5.Size = New System.Drawing.Size(444, 335)
        Me.page5.TabIndex = 4
        Me.page5.Text = "test5"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.finance_menu.My.Resources.Resources.kisspng_strategic_planning_strategy_product_debriefing_5bff0905db8926_4163649115434406458992
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(444, 339)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'page6
        '
        Me.page6.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.page6.Controls.Add(Me.PictureBox2)
        Me.page6.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.page6.Location = New System.Drawing.Point(4, 22)
        Me.page6.Name = "page6"
        Me.page6.Size = New System.Drawing.Size(444, 335)
        Me.page6.TabIndex = 5
        Me.page6.Text = "test6"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.finance_menu.My.Resources.Resources.kisspng_strategic_planning_strategy_product_debriefing_5bff0905db8926_4163649115434406458992
        Me.PictureBox2.Location = New System.Drawing.Point(0, -2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(444, 339)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'page_settings
        '
        Me.page_settings.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.page_settings.Controls.Add(Me.Button4)
        Me.page_settings.Controls.Add(Me.LinkLabel2)
        Me.page_settings.Controls.Add(Me.db_editor_pas)
        Me.page_settings.Controls.Add(Me.db_editor_log)
        Me.page_settings.Controls.Add(Me.LinkLabel1)
        Me.page_settings.Controls.Add(Me.Button3)
        Me.page_settings.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.page_settings.Location = New System.Drawing.Point(4, 22)
        Me.page_settings.Name = "page_settings"
        Me.page_settings.Size = New System.Drawing.Size(444, 335)
        Me.page_settings.TabIndex = 6
        Me.page_settings.Text = "Settings"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(103, 128)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Logon"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(19, 86)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(59, 15)
        Me.LinkLabel2.TabIndex = 4
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Password"
        '
        'db_editor_pas
        '
        Me.db_editor_pas.Location = New System.Drawing.Point(22, 102)
        Me.db_editor_pas.Name = "db_editor_pas"
        Me.db_editor_pas.Size = New System.Drawing.Size(100, 22)
        Me.db_editor_pas.TabIndex = 3
        '
        'db_editor_log
        '
        Me.db_editor_log.Location = New System.Drawing.Point(22, 63)
        Me.db_editor_log.Name = "db_editor_log"
        Me.db_editor_log.Size = New System.Drawing.Size(100, 22)
        Me.db_editor_log.TabIndex = 2
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(19, 47)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(38, 15)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Login"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(22, 128)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Change"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(442, 352)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(458, 391)
        Me.MinimumSize = New System.Drawing.Size(458, 391)
        Me.Name = "Form1"
        Me.Text = "Finance Operations"
        Me.TabControl1.ResumeLayout(False)
        Me.page1.ResumeLayout(False)
        Me.page1.PerformLayout()
        Me.page2.ResumeLayout(False)
        Me.page2.PerformLayout()
        Me.page3.ResumeLayout(False)
        Me.page3.PerformLayout()
        Me.page4.ResumeLayout(False)
        Me.page4.PerformLayout()
        Me.page5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.page6.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.page_settings.ResumeLayout(False)
        Me.page_settings.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents page1 As TabPage
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents bb1 As Button
    Friend WithEvents bb2 As Button
    Friend WithEvents page2 As TabPage
    Friend WithEvents page3 As TabPage
    Friend WithEvents page4 As TabPage
    Friend WithEvents page5 As TabPage
    Friend WithEvents page6 As TabPage
    Friend WithEvents page_settings As TabPage
    Friend WithEvents Timer1 As Timer
    Friend WithEvents db_editor_log As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents db_editor_pas As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents bb3 As Button
    Friend WithEvents bb4 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ProgressBar3 As ProgressBar
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents bb5 As Button
    Friend WithEvents bb6 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ProgressBar4 As ProgressBar
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents bb7 As Button
    Friend WithEvents bb8 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
