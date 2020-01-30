<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Profile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Profile))
        Me.btnTakeAPicture = New System.Windows.Forms.Button()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblDateOfBirth = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.lblFemale = New System.Windows.Forms.Label()
        Me.lblMale = New System.Windows.Forms.Label()
        Me.radiobtnFemale = New System.Windows.Forms.RadioButton()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.radiobtnMale = New System.Windows.Forms.RadioButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtGivenName = New System.Windows.Forms.TextBox()
        Me.lblGivenName = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.groupbox = New System.Windows.Forms.GroupBox()
        Me.dtpDateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.txtStudentId = New System.Windows.Forms.TextBox()
        Me.lblStudentId = New System.Windows.Forms.Label()
        Me.groupboxButtons = New System.Windows.Forms.GroupBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pictureboxProfile = New System.Windows.Forms.PictureBox()
        Me.groupbox.SuspendLayout()
        Me.groupboxButtons.SuspendLayout()
        CType(Me.pictureboxProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTakeAPicture
        '
        Me.btnTakeAPicture.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnTakeAPicture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTakeAPicture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnTakeAPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTakeAPicture.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTakeAPicture.ForeColor = System.Drawing.Color.Black
        Me.btnTakeAPicture.Location = New System.Drawing.Point(1142, 352)
        Me.btnTakeAPicture.Name = "btnTakeAPicture"
        Me.btnTakeAPicture.Size = New System.Drawing.Size(134, 25)
        Me.btnTakeAPicture.TabIndex = 154
        Me.btnTakeAPicture.Text = "TAKE A PICTURE"
        Me.btnTakeAPicture.UseVisualStyleBackColor = False
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.ForeColor = System.Drawing.Color.Black
        Me.lblAge.Location = New System.Drawing.Point(550, 91)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(36, 20)
        Me.lblAge.TabIndex = 139
        Me.lblAge.Text = "Age"
        '
        'lblDateOfBirth
        '
        Me.lblDateOfBirth.AutoSize = True
        Me.lblDateOfBirth.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateOfBirth.ForeColor = System.Drawing.Color.Black
        Me.lblDateOfBirth.Location = New System.Drawing.Point(265, 91)
        Me.lblDateOfBirth.Name = "lblDateOfBirth"
        Me.lblDateOfBirth.Size = New System.Drawing.Size(96, 20)
        Me.lblDateOfBirth.TabIndex = 141
        Me.lblDateOfBirth.Text = "Date of Birth"
        '
        'txtAge
        '
        Me.txtAge.BackColor = System.Drawing.Color.White
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAge.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.ForeColor = System.Drawing.Color.Black
        Me.txtAge.Location = New System.Drawing.Point(585, 89)
        Me.txtAge.MaxLength = 2
        Me.txtAge.Multiline = True
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(95, 22)
        Me.txtAge.TabIndex = 11
        '
        'lblFemale
        '
        Me.lblFemale.AutoSize = True
        Me.lblFemale.BackColor = System.Drawing.Color.Transparent
        Me.lblFemale.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFemale.ForeColor = System.Drawing.Color.Black
        Me.lblFemale.Location = New System.Drawing.Point(170, 89)
        Me.lblFemale.Name = "lblFemale"
        Me.lblFemale.Size = New System.Drawing.Size(58, 20)
        Me.lblFemale.TabIndex = 135
        Me.lblFemale.Text = "Female"
        '
        'lblMale
        '
        Me.lblMale.AutoSize = True
        Me.lblMale.BackColor = System.Drawing.Color.Transparent
        Me.lblMale.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMale.ForeColor = System.Drawing.Color.Black
        Me.lblMale.Location = New System.Drawing.Point(106, 89)
        Me.lblMale.Name = "lblMale"
        Me.lblMale.Size = New System.Drawing.Size(43, 20)
        Me.lblMale.TabIndex = 134
        Me.lblMale.Text = "Male"
        '
        'radiobtnFemale
        '
        Me.radiobtnFemale.AutoSize = True
        Me.radiobtnFemale.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radiobtnFemale.ForeColor = System.Drawing.Color.White
        Me.radiobtnFemale.Location = New System.Drawing.Point(155, 93)
        Me.radiobtnFemale.Name = "radiobtnFemale"
        Me.radiobtnFemale.Size = New System.Drawing.Size(14, 13)
        Me.radiobtnFemale.TabIndex = 7
        Me.radiobtnFemale.TabStop = True
        Me.radiobtnFemale.UseVisualStyleBackColor = True
        '
        'txtMiddleName
        '
        Me.txtMiddleName.BackColor = System.Drawing.Color.White
        Me.txtMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMiddleName.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddleName.ForeColor = System.Drawing.Color.Black
        Me.txtMiddleName.Location = New System.Drawing.Point(677, 58)
        Me.txtMiddleName.MaxLength = 16
        Me.txtMiddleName.Multiline = True
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(185, 20)
        Me.txtMiddleName.TabIndex = 5
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.White
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.Black
        Me.txtAddress.Location = New System.Drawing.Point(80, 124)
        Me.txtAddress.MaxLength = 80
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(805, 20)
        Me.txtAddress.TabIndex = 12
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.Black
        Me.btnBrowse.Location = New System.Drawing.Point(985, 352)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(145, 25)
        Me.btnBrowse.TabIndex = 155
        Me.btnBrowse.Text = "BROWSE"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'radiobtnMale
        '
        Me.radiobtnMale.AutoSize = True
        Me.radiobtnMale.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radiobtnMale.ForeColor = System.Drawing.Color.White
        Me.radiobtnMale.Location = New System.Drawing.Point(86, 91)
        Me.radiobtnMale.Name = "radiobtnMale"
        Me.radiobtnMale.Size = New System.Drawing.Size(14, 13)
        Me.radiobtnMale.TabIndex = 6
        Me.radiobtnMale.TabStop = True
        Me.radiobtnMale.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.BackColor = System.Drawing.Color.Transparent
        Me.lblMiddleName.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddleName.ForeColor = System.Drawing.Color.Black
        Me.lblMiddleName.Location = New System.Drawing.Point(571, 57)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(102, 20)
        Me.lblMiddleName.TabIndex = 3
        Me.lblMiddleName.Text = "Middle Name"
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.Color.White
        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastName.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.Color.Black
        Me.txtLastName.Location = New System.Drawing.Point(93, 58)
        Me.txtLastName.MaxLength = 16
        Me.txtLastName.Multiline = True
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(185, 20)
        Me.txtLastName.TabIndex = 3
        '
        'txtGivenName
        '
        Me.txtGivenName.BackColor = System.Drawing.Color.White
        Me.txtGivenName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGivenName.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGivenName.ForeColor = System.Drawing.Color.Black
        Me.txtGivenName.Location = New System.Drawing.Point(392, 58)
        Me.txtGivenName.MaxLength = 16
        Me.txtGivenName.Multiline = True
        Me.txtGivenName.Name = "txtGivenName"
        Me.txtGivenName.Size = New System.Drawing.Size(166, 20)
        Me.txtGivenName.TabIndex = 4
        '
        'lblGivenName
        '
        Me.lblGivenName.AutoSize = True
        Me.lblGivenName.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGivenName.ForeColor = System.Drawing.Color.Black
        Me.lblGivenName.Location = New System.Drawing.Point(293, 57)
        Me.lblGivenName.Name = "lblGivenName"
        Me.lblGivenName.Size = New System.Drawing.Size(93, 20)
        Me.lblGivenName.TabIndex = 4
        Me.lblGivenName.Text = "Given Name"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.Black
        Me.lblGender.Location = New System.Drawing.Point(11, 89)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(59, 20)
        Me.lblGender.TabIndex = 8
        Me.lblGender.Text = "Gender"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.ForeColor = System.Drawing.Color.Black
        Me.lblLastName.Location = New System.Drawing.Point(10, 57)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(80, 20)
        Me.lblLastName.TabIndex = 2
        Me.lblLastName.Text = "Last Name"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.Black
        Me.lblAddress.Location = New System.Drawing.Point(11, 124)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(63, 20)
        Me.lblAddress.TabIndex = 15
        Me.lblAddress.Text = "Address"
        '
        'groupbox
        '
        Me.groupbox.BackColor = System.Drawing.Color.Transparent
        Me.groupbox.Controls.Add(Me.dtpDateOfBirth)
        Me.groupbox.Controls.Add(Me.lblAge)
        Me.groupbox.Controls.Add(Me.lblDateOfBirth)
        Me.groupbox.Controls.Add(Me.txtAge)
        Me.groupbox.Controls.Add(Me.lblFemale)
        Me.groupbox.Controls.Add(Me.lblMale)
        Me.groupbox.Controls.Add(Me.radiobtnFemale)
        Me.groupbox.Controls.Add(Me.radiobtnMale)
        Me.groupbox.Controls.Add(Me.txtMiddleName)
        Me.groupbox.Controls.Add(Me.txtAddress)
        Me.groupbox.Controls.Add(Me.lblMiddleName)
        Me.groupbox.Controls.Add(Me.txtLastName)
        Me.groupbox.Controls.Add(Me.txtGivenName)
        Me.groupbox.Controls.Add(Me.lblGivenName)
        Me.groupbox.Controls.Add(Me.lblAddress)
        Me.groupbox.Controls.Add(Me.lblGender)
        Me.groupbox.Controls.Add(Me.txtStudentId)
        Me.groupbox.Controls.Add(Me.lblLastName)
        Me.groupbox.Controls.Add(Me.lblStudentId)
        Me.groupbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupbox.ForeColor = System.Drawing.Color.Black
        Me.groupbox.Location = New System.Drawing.Point(21, 136)
        Me.groupbox.Name = "groupbox"
        Me.groupbox.Size = New System.Drawing.Size(900, 214)
        Me.groupbox.TabIndex = 153
        Me.groupbox.TabStop = False
        '
        'dtpDateOfBirth
        '
        Me.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateOfBirth.Location = New System.Drawing.Point(370, 91)
        Me.dtpDateOfBirth.Name = "dtpDateOfBirth"
        Me.dtpDateOfBirth.Size = New System.Drawing.Size(163, 22)
        Me.dtpDateOfBirth.TabIndex = 159
        '
        'txtStudentId
        '
        Me.txtStudentId.BackColor = System.Drawing.Color.White
        Me.txtStudentId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStudentId.Enabled = False
        Me.txtStudentId.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentId.ForeColor = System.Drawing.Color.Black
        Me.txtStudentId.Location = New System.Drawing.Point(96, 27)
        Me.txtStudentId.MaxLength = 10
        Me.txtStudentId.Multiline = True
        Me.txtStudentId.Name = "txtStudentId"
        Me.txtStudentId.Size = New System.Drawing.Size(164, 20)
        Me.txtStudentId.TabIndex = 1
        '
        'lblStudentId
        '
        Me.lblStudentId.AutoSize = True
        Me.lblStudentId.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentId.ForeColor = System.Drawing.Color.Black
        Me.lblStudentId.Location = New System.Drawing.Point(11, 27)
        Me.lblStudentId.Name = "lblStudentId"
        Me.lblStudentId.Size = New System.Drawing.Size(81, 20)
        Me.lblStudentId.TabIndex = 1
        Me.lblStudentId.Text = "Student ID"
        '
        'groupboxButtons
        '
        Me.groupboxButtons.BackColor = System.Drawing.Color.Transparent
        Me.groupboxButtons.Controls.Add(Me.btnDelete)
        Me.groupboxButtons.Controls.Add(Me.btnEdit)
        Me.groupboxButtons.Controls.Add(Me.btnUpdate)
        Me.groupboxButtons.ForeColor = System.Drawing.Color.Black
        Me.groupboxButtons.Location = New System.Drawing.Point(416, 441)
        Me.groupboxButtons.Name = "groupboxButtons"
        Me.groupboxButtons.Size = New System.Drawing.Size(344, 69)
        Me.groupboxButtons.TabIndex = 157
        Me.groupboxButtons.TabStop = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(229, 19)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(91, 33)
        Me.btnDelete.TabIndex = 145
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(19, 19)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(91, 33)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(125, 19)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(91, 33)
        Me.btnUpdate.TabIndex = 0
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(1138, 21)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(148, 33)
        Me.btnClose.TabIndex = 146
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(536, 84)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(115, 29)
        Me.lblTitle.TabIndex = 158
        Me.lblTitle.Text = "PROFILE"
        '
        'pictureboxProfile
        '
        Me.pictureboxProfile.BackColor = System.Drawing.Color.White
        Me.pictureboxProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureboxProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureboxProfile.ErrorImage = Nothing
        Me.pictureboxProfile.Image = Global.SIMPLE_CRUD_IN_VB_AND_MYSQL.My.Resources.Resources.usericon
        Me.pictureboxProfile.InitialImage = Global.SIMPLE_CRUD_IN_VB_AND_MYSQL.My.Resources.Resources.usericon
        Me.pictureboxProfile.Location = New System.Drawing.Point(985, 136)
        Me.pictureboxProfile.Name = "pictureboxProfile"
        Me.pictureboxProfile.Size = New System.Drawing.Size(291, 198)
        Me.pictureboxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureboxProfile.TabIndex = 156
        Me.pictureboxProfile.TabStop = False
        '
        'Form_Profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1310, 553)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.groupboxButtons)
        Me.Controls.Add(Me.btnTakeAPicture)
        Me.Controls.Add(Me.pictureboxProfile)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.groupbox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Profile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.groupbox.ResumeLayout(False)
        Me.groupbox.PerformLayout()
        Me.groupboxButtons.ResumeLayout(False)
        CType(Me.pictureboxProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTakeAPicture As System.Windows.Forms.Button
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents lblDateOfBirth As System.Windows.Forms.Label
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents lblFemale As System.Windows.Forms.Label
    Friend WithEvents pictureboxProfile As System.Windows.Forms.PictureBox
    Friend WithEvents lblMale As System.Windows.Forms.Label
    Friend WithEvents radiobtnFemale As System.Windows.Forms.RadioButton
    Friend WithEvents txtMiddleName As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents radiobtnMale As System.Windows.Forms.RadioButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblMiddleName As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtGivenName As System.Windows.Forms.TextBox
    Friend WithEvents lblGivenName As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents groupbox As System.Windows.Forms.GroupBox
    Friend WithEvents groupboxButtons As System.Windows.Forms.GroupBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtStudentId As System.Windows.Forms.TextBox
    Friend WithEvents lblStudentId As System.Windows.Forms.Label
    Friend WithEvents dtpDateOfBirth As System.Windows.Forms.DateTimePicker
End Class
