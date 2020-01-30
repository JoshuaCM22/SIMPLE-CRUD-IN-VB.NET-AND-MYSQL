<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Main))
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.toolstrip_Settings = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolstrip_CreateAnotherAccount = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolstrip_ChangePassword = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolstrip_Logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnStudents = New System.Windows.Forms.Button()
        Me.lblTimeNow = New System.Windows.Forms.Label()
        Me.lblDayToday = New System.Windows.Forms.Label()
        Me.lblDateToday = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.menuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip
        '
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolstrip_Settings})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.menuStrip.Size = New System.Drawing.Size(800, 24)
        Me.menuStrip.TabIndex = 0
        Me.menuStrip.Text = "MenuStrip1"
        '
        'toolstrip_Settings
        '
        Me.toolstrip_Settings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolstrip_CreateAnotherAccount, Me.toolstrip_ChangePassword, Me.toolstrip_Logout})
        Me.toolstrip_Settings.Name = "toolstrip_Settings"
        Me.toolstrip_Settings.Size = New System.Drawing.Size(69, 20)
        Me.toolstrip_Settings.Text = "SETTINGS"
        '
        'toolstrip_CreateAnotherAccount
        '
        Me.toolstrip_CreateAnotherAccount.Name = "toolstrip_CreateAnotherAccount"
        Me.toolstrip_CreateAnotherAccount.Size = New System.Drawing.Size(232, 22)
        Me.toolstrip_CreateAnotherAccount.Text = "CREATE ANOTHER ACCOUNT "
        '
        'toolstrip_ChangePassword
        '
        Me.toolstrip_ChangePassword.Name = "toolstrip_ChangePassword"
        Me.toolstrip_ChangePassword.Size = New System.Drawing.Size(232, 22)
        Me.toolstrip_ChangePassword.Text = "CHANGE PASSWORD"
        '
        'toolstrip_Logout
        '
        Me.toolstrip_Logout.Name = "toolstrip_Logout"
        Me.toolstrip_Logout.Size = New System.Drawing.Size(232, 22)
        Me.toolstrip_Logout.Text = "LOG-OUT"
        '
        'btnStudents
        '
        Me.btnStudents.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnStudents.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStudents.FlatAppearance.BorderSize = 0
        Me.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudents.ForeColor = System.Drawing.Color.White
        Me.btnStudents.Location = New System.Drawing.Point(292, 201)
        Me.btnStudents.Name = "btnStudents"
        Me.btnStudents.Size = New System.Drawing.Size(219, 44)
        Me.btnStudents.TabIndex = 1
        Me.btnStudents.Text = "STUDENTS"
        Me.btnStudents.UseVisualStyleBackColor = False
        '
        'lblTimeNow
        '
        Me.lblTimeNow.AutoSize = True
        Me.lblTimeNow.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblTimeNow.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeNow.ForeColor = System.Drawing.Color.White
        Me.lblTimeNow.Location = New System.Drawing.Point(589, 389)
        Me.lblTimeNow.Name = "lblTimeNow"
        Me.lblTimeNow.Size = New System.Drawing.Size(107, 24)
        Me.lblTimeNow.TabIndex = 136
        Me.lblTimeNow.Text = "TIME NOW"
        '
        'lblDayToday
        '
        Me.lblDayToday.AutoSize = True
        Me.lblDayToday.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblDayToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDayToday.ForeColor = System.Drawing.Color.White
        Me.lblDayToday.Location = New System.Drawing.Point(358, 389)
        Me.lblDayToday.Name = "lblDayToday"
        Me.lblDayToday.Size = New System.Drawing.Size(118, 24)
        Me.lblDayToday.TabIndex = 135
        Me.lblDayToday.Text = "DAY TODAY"
        '
        'lblDateToday
        '
        Me.lblDateToday.AutoSize = True
        Me.lblDateToday.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblDateToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateToday.ForeColor = System.Drawing.Color.White
        Me.lblDateToday.Location = New System.Drawing.Point(65, 389)
        Me.lblDateToday.Name = "lblDateToday"
        Me.lblDateToday.Size = New System.Drawing.Size(131, 24)
        Me.lblDateToday.TabIndex = 134
        Me.lblDateToday.Text = "DATE TODAY"
        '
        'Timer1
        '
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(111, 96)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(571, 33)
        Me.lblTitle.TabIndex = 137
        Me.lblTitle.Text = "SIMPLE CRUD IN VB.NET AND MYSQL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Form_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(800, 441)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblTimeNow)
        Me.Controls.Add(Me.lblDayToday)
        Me.Controls.Add(Me.lblDateToday)
        Me.Controls.Add(Me.btnStudents)
        Me.Controls.Add(Me.menuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menuStrip
        Me.MaximizeBox = False
        Me.Name = "Form_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents toolstrip_Settings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolstrip_CreateAnotherAccount As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolstrip_ChangePassword As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolstrip_Logout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnStudents As System.Windows.Forms.Button
    Friend WithEvents lblTimeNow As System.Windows.Forms.Label
    Friend WithEvents lblDayToday As System.Windows.Forms.Label
    Friend WithEvents lblDateToday As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblTitle As System.Windows.Forms.Label
End Class
