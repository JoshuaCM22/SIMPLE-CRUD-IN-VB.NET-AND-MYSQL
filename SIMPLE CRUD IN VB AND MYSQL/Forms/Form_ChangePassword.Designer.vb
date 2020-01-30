<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_ChangePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_ChangePassword))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.lblConfirmNewPassword = New System.Windows.Forms.Label()
        Me.txtConfirmNewPassword = New System.Windows.Forms.TextBox()
        Me.groupbox = New System.Windows.Forms.GroupBox()
        Me.chckbox_ShowPassword1 = New System.Windows.Forms.CheckBox()
        Me.chckbox_ShowPassword2 = New System.Windows.Forms.CheckBox()
        Me.lblNewPassword = New System.Windows.Forms.Label()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.lblCurrentPassword = New System.Windows.Forms.Label()
        Me.txtCurrentPassword = New System.Windows.Forms.TextBox()
        Me.groupbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(288, 415)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(164, 33)
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnChangePassword
        '
        Me.btnChangePassword.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChangePassword.FlatAppearance.BorderSize = 0
        Me.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePassword.ForeColor = System.Drawing.Color.White
        Me.btnChangePassword.Location = New System.Drawing.Point(84, 415)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(173, 33)
        Me.btnChangePassword.TabIndex = 9
        Me.btnChangePassword.Text = "CHANGE PASSWORD"
        Me.btnChangePassword.UseVisualStyleBackColor = False
        '
        'lblConfirmNewPassword
        '
        Me.lblConfirmNewPassword.AutoSize = True
        Me.lblConfirmNewPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblConfirmNewPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmNewPassword.ForeColor = System.Drawing.Color.White
        Me.lblConfirmNewPassword.Location = New System.Drawing.Point(30, 199)
        Me.lblConfirmNewPassword.Name = "lblConfirmNewPassword"
        Me.lblConfirmNewPassword.Size = New System.Drawing.Size(173, 21)
        Me.lblConfirmNewPassword.TabIndex = 0
        Me.lblConfirmNewPassword.Text = "Confirm New Password"
        '
        'txtConfirmNewPassword
        '
        Me.txtConfirmNewPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmNewPassword.Location = New System.Drawing.Point(205, 198)
        Me.txtConfirmNewPassword.MaxLength = 12
        Me.txtConfirmNewPassword.Name = "txtConfirmNewPassword"
        Me.txtConfirmNewPassword.Size = New System.Drawing.Size(234, 25)
        Me.txtConfirmNewPassword.TabIndex = 3
        Me.txtConfirmNewPassword.UseSystemPasswordChar = True
        '
        'groupbox
        '
        Me.groupbox.BackColor = System.Drawing.Color.Transparent
        Me.groupbox.Controls.Add(Me.chckbox_ShowPassword1)
        Me.groupbox.Controls.Add(Me.chckbox_ShowPassword2)
        Me.groupbox.Controls.Add(Me.lblNewPassword)
        Me.groupbox.Controls.Add(Me.txtNewPassword)
        Me.groupbox.Controls.Add(Me.lblCurrentPassword)
        Me.groupbox.Controls.Add(Me.txtCurrentPassword)
        Me.groupbox.Controls.Add(Me.lblConfirmNewPassword)
        Me.groupbox.Controls.Add(Me.txtConfirmNewPassword)
        Me.groupbox.Location = New System.Drawing.Point(30, 48)
        Me.groupbox.Name = "groupbox"
        Me.groupbox.Size = New System.Drawing.Size(483, 321)
        Me.groupbox.TabIndex = 7
        Me.groupbox.TabStop = False
        '
        'chckbox_ShowPassword1
        '
        Me.chckbox_ShowPassword1.AutoSize = True
        Me.chckbox_ShowPassword1.BackColor = System.Drawing.Color.Transparent
        Me.chckbox_ShowPassword1.FlatAppearance.BorderSize = 0
        Me.chckbox_ShowPassword1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckbox_ShowPassword1.ForeColor = System.Drawing.Color.White
        Me.chckbox_ShowPassword1.Location = New System.Drawing.Point(205, 95)
        Me.chckbox_ShowPassword1.Name = "chckbox_ShowPassword1"
        Me.chckbox_ShowPassword1.Size = New System.Drawing.Size(118, 21)
        Me.chckbox_ShowPassword1.TabIndex = 0
        Me.chckbox_ShowPassword1.Text = "Show Password"
        Me.chckbox_ShowPassword1.UseVisualStyleBackColor = False
        '
        'chckbox_ShowPassword2
        '
        Me.chckbox_ShowPassword2.AutoSize = True
        Me.chckbox_ShowPassword2.BackColor = System.Drawing.Color.Transparent
        Me.chckbox_ShowPassword2.FlatAppearance.BorderSize = 0
        Me.chckbox_ShowPassword2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckbox_ShowPassword2.ForeColor = System.Drawing.Color.White
        Me.chckbox_ShowPassword2.Location = New System.Drawing.Point(205, 241)
        Me.chckbox_ShowPassword2.Name = "chckbox_ShowPassword2"
        Me.chckbox_ShowPassword2.Size = New System.Drawing.Size(118, 21)
        Me.chckbox_ShowPassword2.TabIndex = 0
        Me.chckbox_ShowPassword2.Text = "Show Password"
        Me.chckbox_ShowPassword2.UseVisualStyleBackColor = False
        '
        'lblNewPassword
        '
        Me.lblNewPassword.AutoSize = True
        Me.lblNewPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblNewPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewPassword.ForeColor = System.Drawing.Color.White
        Me.lblNewPassword.Location = New System.Drawing.Point(87, 153)
        Me.lblNewPassword.Name = "lblNewPassword"
        Me.lblNewPassword.Size = New System.Drawing.Size(112, 21)
        Me.lblNewPassword.TabIndex = 0
        Me.lblNewPassword.Text = "New Password"
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.Location = New System.Drawing.Point(206, 153)
        Me.txtNewPassword.MaxLength = 12
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(234, 25)
        Me.txtNewPassword.TabIndex = 2
        Me.txtNewPassword.UseSystemPasswordChar = True
        '
        'lblCurrentPassword
        '
        Me.lblCurrentPassword.AutoSize = True
        Me.lblCurrentPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblCurrentPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentPassword.ForeColor = System.Drawing.Color.White
        Me.lblCurrentPassword.Location = New System.Drawing.Point(70, 60)
        Me.lblCurrentPassword.Name = "lblCurrentPassword"
        Me.lblCurrentPassword.Size = New System.Drawing.Size(133, 21)
        Me.lblCurrentPassword.TabIndex = 0
        Me.lblCurrentPassword.Text = "Current Password"
        '
        'txtCurrentPassword
        '
        Me.txtCurrentPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentPassword.Location = New System.Drawing.Point(205, 59)
        Me.txtCurrentPassword.MaxLength = 12
        Me.txtCurrentPassword.Name = "txtCurrentPassword"
        Me.txtCurrentPassword.Size = New System.Drawing.Size(234, 25)
        Me.txtCurrentPassword.TabIndex = 1
        Me.txtCurrentPassword.UseSystemPasswordChar = True
        '
        'Form_ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(542, 490)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnChangePassword)
        Me.Controls.Add(Me.groupbox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_ChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CHANGE PASSWORD"
        Me.groupbox.ResumeLayout(False)
        Me.groupbox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnChangePassword As System.Windows.Forms.Button
    Friend WithEvents lblConfirmNewPassword As System.Windows.Forms.Label
    Friend WithEvents txtConfirmNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents groupbox As System.Windows.Forms.GroupBox
    Friend WithEvents chckbox_ShowPassword1 As System.Windows.Forms.CheckBox
    Friend WithEvents chckbox_ShowPassword2 As System.Windows.Forms.CheckBox
    Friend WithEvents lblNewPassword As System.Windows.Forms.Label
    Friend WithEvents txtNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblCurrentPassword As System.Windows.Forms.Label
    Friend WithEvents txtCurrentPassword As System.Windows.Forms.TextBox
End Class
