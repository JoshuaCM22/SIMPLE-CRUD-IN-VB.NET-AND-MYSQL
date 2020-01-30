<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_CreateAnotherAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_CreateAnotherAccount))
        Me.groupBox = New System.Windows.Forms.GroupBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.chckbox_ShowPassword = New System.Windows.Forms.CheckBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.cmbboxSecretQuestion = New System.Windows.Forms.ComboBox()
        Me.chckbox_ShowSecretAnswer = New System.Windows.Forms.CheckBox()
        Me.txtSecretAnswer = New System.Windows.Forms.TextBox()
        Me.lblSecretAnswer = New System.Windows.Forms.Label()
        Me.lblSecretQuestion = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.groupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox
        '
        Me.groupBox.BackColor = System.Drawing.Color.Transparent
        Me.groupBox.Controls.Add(Me.txtPassword)
        Me.groupBox.Controls.Add(Me.chckbox_ShowPassword)
        Me.groupBox.Controls.Add(Me.txtUsername)
        Me.groupBox.Controls.Add(Me.lblPassword)
        Me.groupBox.Controls.Add(Me.lblUsername)
        Me.groupBox.Controls.Add(Me.cmbboxSecretQuestion)
        Me.groupBox.Controls.Add(Me.chckbox_ShowSecretAnswer)
        Me.groupBox.Controls.Add(Me.txtSecretAnswer)
        Me.groupBox.Controls.Add(Me.lblSecretAnswer)
        Me.groupBox.Controls.Add(Me.lblSecretQuestion)
        Me.groupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.groupBox.Location = New System.Drawing.Point(61, 48)
        Me.groupBox.Name = "groupBox"
        Me.groupBox.Size = New System.Drawing.Size(435, 292)
        Me.groupBox.TabIndex = 72
        Me.groupBox.TabStop = False
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(149, 86)
        Me.txtPassword.MaxLength = 12
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(234, 25)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'chckbox_ShowPassword
        '
        Me.chckbox_ShowPassword.AutoSize = True
        Me.chckbox_ShowPassword.BackColor = System.Drawing.Color.Transparent
        Me.chckbox_ShowPassword.FlatAppearance.BorderSize = 0
        Me.chckbox_ShowPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckbox_ShowPassword.ForeColor = System.Drawing.Color.White
        Me.chckbox_ShowPassword.Location = New System.Drawing.Point(149, 117)
        Me.chckbox_ShowPassword.Name = "chckbox_ShowPassword"
        Me.chckbox_ShowPassword.Size = New System.Drawing.Size(118, 21)
        Me.chckbox_ShowPassword.TabIndex = 0
        Me.chckbox_ShowPassword.Text = "Show Password"
        Me.chckbox_ShowPassword.UseVisualStyleBackColor = False
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(149, 48)
        Me.txtUsername.MaxLength = 12
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(234, 25)
        Me.txtUsername.TabIndex = 2
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.White
        Me.lblPassword.Location = New System.Drawing.Point(67, 86)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(76, 21)
        Me.lblPassword.TabIndex = 32
        Me.lblPassword.Text = "Password"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(62, 48)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(81, 21)
        Me.lblUsername.TabIndex = 31
        Me.lblUsername.Text = "Username"
        '
        'cmbboxSecretQuestion
        '
        Me.cmbboxSecretQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxSecretQuestion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbboxSecretQuestion.FormattingEnabled = True
        Me.cmbboxSecretQuestion.ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        Me.cmbboxSecretQuestion.Items.AddRange(New Object() {"None", "What is your favorite color?", "What is your contact number?", "When is your birthday?", "What is love for you?", "Where were you born ?", "What is the meaning of life?", "What is your gender?", "What is your civil status in life?", "What is your dream in life?", "What things that makes you happy?", "What things that makes you sad?", "What things that makes you mad?", "What is your job?", "What is your favorite song?", "What is your favorite band?", "What is your favorite singer?"})
        Me.cmbboxSecretQuestion.Location = New System.Drawing.Point(149, 149)
        Me.cmbboxSecretQuestion.Name = "cmbboxSecretQuestion"
        Me.cmbboxSecretQuestion.Size = New System.Drawing.Size(234, 25)
        Me.cmbboxSecretQuestion.TabIndex = 11
        '
        'chckbox_ShowSecretAnswer
        '
        Me.chckbox_ShowSecretAnswer.AutoSize = True
        Me.chckbox_ShowSecretAnswer.BackColor = System.Drawing.Color.Transparent
        Me.chckbox_ShowSecretAnswer.FlatAppearance.BorderSize = 0
        Me.chckbox_ShowSecretAnswer.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckbox_ShowSecretAnswer.ForeColor = System.Drawing.Color.White
        Me.chckbox_ShowSecretAnswer.Location = New System.Drawing.Point(149, 226)
        Me.chckbox_ShowSecretAnswer.Name = "chckbox_ShowSecretAnswer"
        Me.chckbox_ShowSecretAnswer.Size = New System.Drawing.Size(144, 21)
        Me.chckbox_ShowSecretAnswer.TabIndex = 0
        Me.chckbox_ShowSecretAnswer.Text = "Show Secret Answer"
        Me.chckbox_ShowSecretAnswer.UseVisualStyleBackColor = False
        '
        'txtSecretAnswer
        '
        Me.txtSecretAnswer.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecretAnswer.Location = New System.Drawing.Point(149, 189)
        Me.txtSecretAnswer.MaxLength = 50
        Me.txtSecretAnswer.Name = "txtSecretAnswer"
        Me.txtSecretAnswer.Size = New System.Drawing.Size(234, 25)
        Me.txtSecretAnswer.TabIndex = 12
        Me.txtSecretAnswer.UseSystemPasswordChar = True
        '
        'lblSecretAnswer
        '
        Me.lblSecretAnswer.AutoSize = True
        Me.lblSecretAnswer.BackColor = System.Drawing.Color.Transparent
        Me.lblSecretAnswer.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecretAnswer.ForeColor = System.Drawing.Color.White
        Me.lblSecretAnswer.Location = New System.Drawing.Point(37, 190)
        Me.lblSecretAnswer.Name = "lblSecretAnswer"
        Me.lblSecretAnswer.Size = New System.Drawing.Size(109, 21)
        Me.lblSecretAnswer.TabIndex = 32
        Me.lblSecretAnswer.Text = "Secret Answer"
        '
        'lblSecretQuestion
        '
        Me.lblSecretQuestion.AutoSize = True
        Me.lblSecretQuestion.BackColor = System.Drawing.Color.Transparent
        Me.lblSecretQuestion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecretQuestion.ForeColor = System.Drawing.Color.White
        Me.lblSecretQuestion.Location = New System.Drawing.Point(27, 150)
        Me.lblSecretQuestion.Name = "lblSecretQuestion"
        Me.lblSecretQuestion.Size = New System.Drawing.Size(120, 21)
        Me.lblSecretQuestion.TabIndex = 31
        Me.lblSecretQuestion.Text = "Secret Question"
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegister.FlatAppearance.BorderSize = 0
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.Location = New System.Drawing.Point(90, 395)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(164, 33)
        Me.btnRegister.TabIndex = 74
        Me.btnRegister.Text = "REGISTER"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(299, 395)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(164, 33)
        Me.btnBack.TabIndex = 73
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Form_CreateAnotherAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(565, 476)
        Me.Controls.Add(Me.groupBox)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_CreateAnotherAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CREATE ANOTHER ACCOUNT ?"
        Me.groupBox.ResumeLayout(False)
        Me.groupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents groupBox As System.Windows.Forms.GroupBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents chckbox_ShowPassword As System.Windows.Forms.CheckBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents cmbboxSecretQuestion As System.Windows.Forms.ComboBox
    Friend WithEvents chckbox_ShowSecretAnswer As System.Windows.Forms.CheckBox
    Friend WithEvents txtSecretAnswer As System.Windows.Forms.TextBox
    Friend WithEvents lblSecretAnswer As System.Windows.Forms.Label
    Friend WithEvents lblSecretQuestion As System.Windows.Forms.Label
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
