﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.page1 = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.page2 = New System.Windows.Forms.TabPage()
        Me.page3 = New System.Windows.Forms.TabPage()
        Me.page4 = New System.Windows.Forms.TabPage()
        Me.page5 = New System.Windows.Forms.TabPage()
        Me.page6 = New System.Windows.Forms.TabPage()
        Me.page_settings = New System.Windows.Forms.TabPage()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.db_editor_log = New System.Windows.Forms.TextBox()
        Me.db_editor_pas = New System.Windows.Forms.TextBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.page1.SuspendLayout()
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
        Me.TabControl1.Location = New System.Drawing.Point(1, -1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(351, 357)
        Me.TabControl1.TabIndex = 5
        '
        'page1
        '
        Me.page1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.page1.Controls.Add(Me.TextBox1)
        Me.page1.Controls.Add(Me.Label1)
        Me.page1.Controls.Add(Me.Button2)
        Me.page1.Controls.Add(Me.Button1)
        Me.page1.Controls.Add(Me.ProgressBar1)
        Me.page1.Location = New System.Drawing.Point(4, 22)
        Me.page1.Name = "page1"
        Me.page1.Padding = New System.Windows.Forms.Padding(3)
        Me.page1.Size = New System.Drawing.Size(343, 331)
        Me.page1.TabIndex = 0
        Me.page1.Text = "Никита"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(98, 137)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(147, 20)
        Me.TextBox1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(154, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "12"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 105)
        Me.ProgressBar1.Maximum = 1
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(343, 23)
        Me.ProgressBar1.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(7, 134)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Вернул"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(251, 134)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Взял"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'page2
        '
        Me.page2.Location = New System.Drawing.Point(4, 22)
        Me.page2.Name = "page2"
        Me.page2.Padding = New System.Windows.Forms.Padding(3)
        Me.page2.Size = New System.Drawing.Size(343, 331)
        Me.page2.TabIndex = 1
        Me.page2.Text = "Александр"
        Me.page2.UseVisualStyleBackColor = True
        '
        'page3
        '
        Me.page3.Location = New System.Drawing.Point(4, 22)
        Me.page3.Name = "page3"
        Me.page3.Size = New System.Drawing.Size(343, 331)
        Me.page3.TabIndex = 2
        Me.page3.Text = "Светлана"
        Me.page3.UseVisualStyleBackColor = True
        '
        'page4
        '
        Me.page4.Location = New System.Drawing.Point(4, 22)
        Me.page4.Name = "page4"
        Me.page4.Size = New System.Drawing.Size(343, 331)
        Me.page4.TabIndex = 3
        Me.page4.Text = "Юрий"
        Me.page4.UseVisualStyleBackColor = True
        '
        'page5
        '
        Me.page5.Location = New System.Drawing.Point(4, 22)
        Me.page5.Name = "page5"
        Me.page5.Size = New System.Drawing.Size(343, 331)
        Me.page5.TabIndex = 4
        Me.page5.Text = "TabPage5"
        Me.page5.UseVisualStyleBackColor = True
        '
        'page6
        '
        Me.page6.Location = New System.Drawing.Point(4, 22)
        Me.page6.Name = "page6"
        Me.page6.Size = New System.Drawing.Size(343, 331)
        Me.page6.TabIndex = 5
        Me.page6.Text = "TabPage6"
        Me.page6.UseVisualStyleBackColor = True
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
        Me.page_settings.Location = New System.Drawing.Point(4, 22)
        Me.page_settings.Name = "page_settings"
        Me.page_settings.Size = New System.Drawing.Size(343, 331)
        Me.page_settings.TabIndex = 6
        Me.page_settings.Text = "Settings"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
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
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(19, 47)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(33, 13)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Login"
        '
        'db_editor_log
        '
        Me.db_editor_log.Location = New System.Drawing.Point(22, 63)
        Me.db_editor_log.Name = "db_editor_log"
        Me.db_editor_log.Size = New System.Drawing.Size(100, 20)
        Me.db_editor_log.TabIndex = 2
        '
        'db_editor_pas
        '
        Me.db_editor_pas.Location = New System.Drawing.Point(22, 102)
        Me.db_editor_pas.Name = "db_editor_pas"
        Me.db_editor_pas.Size = New System.Drawing.Size(100, 20)
        Me.db_editor_pas.TabIndex = 3
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(19, 86)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(53, 13)
        Me.LinkLabel2.TabIndex = 4
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Password"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(268, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Logon"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(350, 354)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.page1.ResumeLayout(False)
        Me.page1.PerformLayout()
        Me.page_settings.ResumeLayout(False)
        Me.page_settings.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents page1 As TabPage
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
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
End Class