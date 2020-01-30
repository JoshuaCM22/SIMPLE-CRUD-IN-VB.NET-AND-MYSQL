<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_ForgotPassword
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_ForgotPassword))
        Me.groupBox = New System.Windows.Forms.GroupBox()
        Me.cmbboxSecretQuestion = New System.Windows.Forms.ComboBox()
        Me.chckboxSecretAnswer = New System.Windows.Forms.CheckBox()
        Me.txtSecretAnswer = New System.Windows.Forms.TextBox()
        Me.lblSecretAnswer = New System.Windows.Forms.Label()
        Me.lblSecretQuestion = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtShowPassword = New System.Windows.Forms.TextBox()
        Me.btnShowPassword = New System.Windows.Forms.Button()
        Me.groupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox
        '
        Me.groupBox.BackColor = System.Drawing.Color.Transparent
        Me.groupBox.Controls.Add(Me.cmbboxSecretQuestion)
        Me.groupBox.Controls.Add(Me.chckboxSecretAnswer)
        Me.groupBox.Controls.Add(Me.txtSecretAnswer)
        Me.groupBox.Controls.Add(Me.lblSecretAnswer)
        Me.groupBox.Controls.Add(Me.lblSecretQuestion)
        Me.groupBox.Controls.Add(Me.txtUsername)
        Me.groupBox.Controls.Add(Me.lblUsername)
        Me.groupBox.Location = New System.Drawing.Point(48, 47)
        Me.groupBox.Name = "groupBox"
        Me.groupBox.Size = New System.Drawing.Size(406, 222)
        Me.groupBox.TabIndex = 7
        Me.groupBox.TabStop = False
        '
        'cmbboxSecretQuestion
        '
        Me.cmbboxSecretQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxSecretQuestion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbboxSecretQuestion.FormattingEnabled = True
        Me.cmbboxSecretQuestion.Items.AddRange(New Object() {"", "What is your favorite color?", "What is your contact number?", "When is your birthday?", "What is love for you?", "Where were you born ?", "What is the meaning of life?", "What is your gender?", "What is your civil status in life?", "What is your dream in life?", "What things that makes you happy?", "What things that makes you sad?", "What things that makes you mad?", "What is your job?", "What is your favorite song?", "What is your favorite band?", "What is your favorite singer?"})
        Me.cmbboxSecretQuestion.Location = New System.Drawing.Point(135, 89)
        Me.cmbboxSecretQuestion.Name = "cmbboxSecretQuestion"
        Me.cmbboxSecretQuestion.Size = New System.Drawing.Size(240, 25)
        Me.cmbboxSecretQuestion.TabIndex = 2
        '
        'chckboxSecretAnswer
        '
        Me.chckboxSecretAnswer.AutoSize = True
        Me.chckboxSecretAnswer.BackColor = System.Drawing.Color.Transparent
        Me.chckboxSecretAnswer.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckboxSecretAnswer.ForeColor = System.Drawing.Color.White
        Me.chckboxSecretAnswer.Location = New System.Drawing.Point(135, 169)
        Me.chckboxSecretAnswer.Name = "chckboxSecretAnswer"
        Me.chckboxSecretAnswer.Size = New System.Drawing.Size(144, 21)
        Me.chckboxSecretAnswer.TabIndex = 4
        Me.chckboxSecretAnswer.Text = "Show Secret Answer"
        Me.chckboxSecretAnswer.UseVisualStyleBackColor = False
        '
        'txtSecretAnswer
        '
        Me.txtSecretAnswer.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecretAnswer.Location = New System.Drawing.Point(135, 129)
        Me.txtSecretAnswer.MaxLength = 0
        Me.txtSecretAnswer.Name = "txtSecretAnswer"
        Me.txtSecretAnswer.Size = New System.Drawing.Size(240, 25)
        Me.txtSecretAnswer.TabIndex = 3
        Me.txtSecretAnswer.UseSystemPasswordChar = True
        '
        'lblSecretAnswer
        '
        Me.lblSecretAnswer.AutoSize = True
        Me.lblSecretAnswer.BackColor = System.Drawing.Color.Transparent
        Me.lblSecretAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSecretAnswer.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecretAnswer.ForeColor = System.Drawing.Color.White
        Me.lblSecretAnswer.Location = New System.Drawing.Point(30, 132)
        Me.lblSecretAnswer.Name = "lblSecretAnswer"
        Me.lblSecretAnswer.Size = New System.Drawing.Size(102, 20)
        Me.lblSecretAnswer.TabIndex = 44
        Me.lblSecretAnswer.Text = "Secret Answer"
        '
        'lblSecretQuestion
        '
        Me.lblSecretQuestion.AutoSize = True
        Me.lblSecretQuestion.BackColor = System.Drawing.Color.Transparent
        Me.lblSecretQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSecretQuestion.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecretQuestion.ForeColor = System.Drawing.Color.White
        Me.lblSecretQuestion.Location = New System.Drawing.Point(19, 92)
        Me.lblSecretQuestion.Name = "lblSecretQuestion"
        Me.lblSecretQuestion.Size = New System.Drawing.Size(113, 20)
        Me.lblSecretQuestion.TabIndex = 43
        Me.lblSecretQuestion.Text = "Secret Question"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(135, 47)
        Me.txtUsername.MaxLength = 12
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(240, 25)
        Me.txtUsername.TabIndex = 1
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(57, 50)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(75, 20)
        Me.lblUsername.TabIndex = 41
        Me.lblUsername.Text = "Username"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(327, 387)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(137, 28)
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'txtShowPassword
        '
        Me.txtShowPassword.BackColor = System.Drawing.Color.White
        Me.txtShowPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtShowPassword.Enabled = False
        Me.txtShowPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShowPassword.ForeColor = System.Drawing.Color.Black
        Me.txtShowPassword.Location = New System.Drawing.Point(233, 306)
        Me.txtShowPassword.Name = "txtShowPassword"
        Me.txtShowPassword.Size = New System.Drawing.Size(221, 27)
        Me.txtShowPassword.TabIndex = 8
        Me.txtShowPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnShowPassword
        '
        Me.btnShowPassword.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnShowPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShowPassword.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnShowPassword.FlatAppearance.BorderSize = 0
        Me.btnShowPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowPassword.ForeColor = System.Drawing.Color.White
        Me.btnShowPassword.Location = New System.Drawing.Point(53, 303)
        Me.btnShowPassword.Name = "btnShowPassword"
        Me.btnShowPassword.Size = New System.Drawing.Size(162, 30)
        Me.btnShowPassword.TabIndex = 9
        Me.btnShowPassword.Text = "SHOW PASSWORD"
        Me.btnShowPassword.UseVisualStyleBackColor = False
        '
        'Form_ForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(507, 447)
        Me.Controls.Add(Me.groupBox)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtShowPassword)
        Me.Controls.Add(Me.btnShowPassword)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_ForgotPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FORGOT PASSWORD ?"
        Me.groupBox.ResumeLayout(False)
        Me.groupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents groupBox As System.Windows.Forms.GroupBox
    Friend WithEvents cmbboxSecretQuestion As System.Windows.Forms.ComboBox
    Friend WithEvents chckboxSecretAnswer As System.Windows.Forms.CheckBox
    Friend WithEvents txtSecretAnswer As System.Windows.Forms.TextBox
    Friend WithEvents lblSecretAnswer As System.Windows.Forms.Label
    Friend WithEvents lblSecretQuestion As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents txtShowPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnShowPassword As System.Windows.Forms.Button
End Class
