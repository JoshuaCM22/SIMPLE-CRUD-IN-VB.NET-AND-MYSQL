<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_AddNewStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_AddNewStudent))
        Me.groupbox = New System.Windows.Forms.GroupBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.cmbboxMonth = New System.Windows.Forms.ComboBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.lblDateOfBirth = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.cmbboxDay = New System.Windows.Forms.ComboBox()
        Me.lblFemale = New System.Windows.Forms.Label()
        Me.lblMale = New System.Windows.Forms.Label()
        Me.radiobtnFemale = New System.Windows.Forms.RadioButton()
        Me.radiobtnMale = New System.Windows.Forms.RadioButton()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtGivenName = New System.Windows.Forms.TextBox()
        Me.lblGivenName = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.btnTakeAPicture = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.pictureboxProfile = New System.Windows.Forms.PictureBox()
        Me.groupbox.SuspendLayout()
        CType(Me.pictureboxProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupbox
        '
        Me.groupbox.BackColor = System.Drawing.Color.Transparent
        Me.groupbox.Controls.Add(Me.lblAge)
        Me.groupbox.Controls.Add(Me.cmbboxMonth)
        Me.groupbox.Controls.Add(Me.txtYear)
        Me.groupbox.Controls.Add(Me.lblDateOfBirth)
        Me.groupbox.Controls.Add(Me.txtAge)
        Me.groupbox.Controls.Add(Me.cmbboxDay)
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
        Me.groupbox.Controls.Add(Me.lblLastName)
        Me.groupbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupbox.ForeColor = System.Drawing.Color.Black
        Me.groupbox.Location = New System.Drawing.Point(33, 92)
        Me.groupbox.Name = "groupbox"
        Me.groupbox.Size = New System.Drawing.Size(900, 224)
        Me.groupbox.TabIndex = 147
        Me.groupbox.TabStop = False
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.ForeColor = System.Drawing.Color.Black
        Me.lblAge.Location = New System.Drawing.Point(614, 103)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(36, 20)
        Me.lblAge.TabIndex = 139
        Me.lblAge.Text = "Age"
        '
        'cmbboxMonth
        '
        Me.cmbboxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxMonth.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbboxMonth.FormattingEnabled = True
        Me.cmbboxMonth.Items.AddRange(New Object() {"Month", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmbboxMonth.Location = New System.Drawing.Point(331, 100)
        Me.cmbboxMonth.MaxLength = 9
        Me.cmbboxMonth.Name = "cmbboxMonth"
        Me.cmbboxMonth.Size = New System.Drawing.Size(98, 28)
        Me.cmbboxMonth.TabIndex = 8
        '
        'txtYear
        '
        Me.txtYear.BackColor = System.Drawing.Color.White
        Me.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtYear.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.ForeColor = System.Drawing.Color.Black
        Me.txtYear.Location = New System.Drawing.Point(517, 101)
        Me.txtYear.MaxLength = 4
        Me.txtYear.Multiline = True
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(91, 22)
        Me.txtYear.TabIndex = 10
        '
        'lblDateOfBirth
        '
        Me.lblDateOfBirth.AutoSize = True
        Me.lblDateOfBirth.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateOfBirth.ForeColor = System.Drawing.Color.Black
        Me.lblDateOfBirth.Location = New System.Drawing.Point(235, 103)
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
        Me.txtAge.Location = New System.Drawing.Point(649, 101)
        Me.txtAge.MaxLength = 2
        Me.txtAge.Multiline = True
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(95, 22)
        Me.txtAge.TabIndex = 11
        '
        'cmbboxDay
        '
        Me.cmbboxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxDay.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbboxDay.FormattingEnabled = True
        Me.cmbboxDay.Items.AddRange(New Object() {"Day", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cmbboxDay.Location = New System.Drawing.Point(435, 99)
        Me.cmbboxDay.MaxLength = 2
        Me.cmbboxDay.Name = "cmbboxDay"
        Me.cmbboxDay.Size = New System.Drawing.Size(76, 28)
        Me.cmbboxDay.TabIndex = 9
        '
        'lblFemale
        '
        Me.lblFemale.AutoSize = True
        Me.lblFemale.BackColor = System.Drawing.Color.Transparent
        Me.lblFemale.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFemale.ForeColor = System.Drawing.Color.Black
        Me.lblFemale.Location = New System.Drawing.Point(169, 103)
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
        Me.lblMale.Location = New System.Drawing.Point(105, 103)
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
        Me.radiobtnFemale.Location = New System.Drawing.Point(154, 107)
        Me.radiobtnFemale.Name = "radiobtnFemale"
        Me.radiobtnFemale.Size = New System.Drawing.Size(14, 13)
        Me.radiobtnFemale.TabIndex = 7
        Me.radiobtnFemale.TabStop = True
        Me.radiobtnFemale.UseVisualStyleBackColor = True
        '
        'radiobtnMale
        '
        Me.radiobtnMale.AutoSize = True
        Me.radiobtnMale.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radiobtnMale.ForeColor = System.Drawing.Color.White
        Me.radiobtnMale.Location = New System.Drawing.Point(85, 107)
        Me.radiobtnMale.Name = "radiobtnMale"
        Me.radiobtnMale.Size = New System.Drawing.Size(14, 13)
        Me.radiobtnMale.TabIndex = 6
        Me.radiobtnMale.TabStop = True
        Me.radiobtnMale.UseVisualStyleBackColor = True
        '
        'txtMiddleName
        '
        Me.txtMiddleName.BackColor = System.Drawing.Color.White
        Me.txtMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMiddleName.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddleName.ForeColor = System.Drawing.Color.Black
        Me.txtMiddleName.Location = New System.Drawing.Point(684, 58)
        Me.txtMiddleName.MaxLength = 16
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(185, 27)
        Me.txtMiddleName.TabIndex = 5
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.White
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.Black
        Me.txtAddress.Location = New System.Drawing.Point(79, 144)
        Me.txtAddress.MaxLength = 80
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(805, 20)
        Me.txtAddress.TabIndex = 12
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.BackColor = System.Drawing.Color.Transparent
        Me.lblMiddleName.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddleName.ForeColor = System.Drawing.Color.Black
        Me.lblMiddleName.Location = New System.Drawing.Point(574, 62)
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
        Me.txtLastName.Location = New System.Drawing.Point(90, 58)
        Me.txtLastName.MaxLength = 16
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(185, 27)
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
        Me.txtGivenName.Name = "txtGivenName"
        Me.txtGivenName.Size = New System.Drawing.Size(166, 27)
        Me.txtGivenName.TabIndex = 4
        '
        'lblGivenName
        '
        Me.lblGivenName.AutoSize = True
        Me.lblGivenName.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGivenName.ForeColor = System.Drawing.Color.Black
        Me.lblGivenName.Location = New System.Drawing.Point(293, 62)
        Me.lblGivenName.Name = "lblGivenName"
        Me.lblGivenName.Size = New System.Drawing.Size(93, 20)
        Me.lblGivenName.TabIndex = 4
        Me.lblGivenName.Text = "Given Name"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.Black
        Me.lblAddress.Location = New System.Drawing.Point(10, 144)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(63, 20)
        Me.lblAddress.TabIndex = 15
        Me.lblAddress.Text = "Address"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.Black
        Me.lblGender.Location = New System.Drawing.Point(10, 103)
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
        Me.lblLastName.Location = New System.Drawing.Point(9, 62)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(80, 20)
        Me.lblLastName.TabIndex = 2
        Me.lblLastName.Text = "Last Name"
        '
        'btnTakeAPicture
        '
        Me.btnTakeAPicture.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnTakeAPicture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTakeAPicture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnTakeAPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTakeAPicture.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTakeAPicture.ForeColor = System.Drawing.Color.Black
        Me.btnTakeAPicture.Location = New System.Drawing.Point(1115, 324)
        Me.btnTakeAPicture.Name = "btnTakeAPicture"
        Me.btnTakeAPicture.Size = New System.Drawing.Size(134, 25)
        Me.btnTakeAPicture.TabIndex = 148
        Me.btnTakeAPicture.Text = "TAKE A PICTURE"
        Me.btnTakeAPicture.UseVisualStyleBackColor = False
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.Black
        Me.btnBrowse.Location = New System.Drawing.Point(958, 324)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(145, 25)
        Me.btnBrowse.TabIndex = 149
        Me.btnBrowse.Text = "BROWSE"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(434, 439)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(168, 33)
        Me.btnAdd.TabIndex = 151
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(651, 438)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(168, 33)
        Me.btnBack.TabIndex = 152
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'pictureboxProfile
        '
        Me.pictureboxProfile.BackColor = System.Drawing.Color.White
        Me.pictureboxProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureboxProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureboxProfile.ErrorImage = Nothing
        Me.pictureboxProfile.InitialImage = Nothing
        Me.pictureboxProfile.Location = New System.Drawing.Point(958, 103)
        Me.pictureboxProfile.Name = "pictureboxProfile"
        Me.pictureboxProfile.Size = New System.Drawing.Size(291, 198)
        Me.pictureboxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureboxProfile.TabIndex = 157
        Me.pictureboxProfile.TabStop = False
        '
        'Form_AddNewStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1277, 503)
        Me.Controls.Add(Me.pictureboxProfile)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnTakeAPicture)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.groupbox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_AddNewStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADD NEW STUDENT"
        Me.groupbox.ResumeLayout(False)
        Me.groupbox.PerformLayout()
        CType(Me.pictureboxProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents groupbox As System.Windows.Forms.GroupBox
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents cmbboxMonth As System.Windows.Forms.ComboBox
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents lblDateOfBirth As System.Windows.Forms.Label
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents cmbboxDay As System.Windows.Forms.ComboBox
    Friend WithEvents lblFemale As System.Windows.Forms.Label
    Friend WithEvents lblMale As System.Windows.Forms.Label
    Friend WithEvents radiobtnFemale As System.Windows.Forms.RadioButton
    Friend WithEvents radiobtnMale As System.Windows.Forms.RadioButton
    Friend WithEvents txtMiddleName As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblMiddleName As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtGivenName As System.Windows.Forms.TextBox
    Friend WithEvents lblGivenName As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents btnTakeAPicture As System.Windows.Forms.Button
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents pictureboxProfile As System.Windows.Forms.PictureBox
End Class
