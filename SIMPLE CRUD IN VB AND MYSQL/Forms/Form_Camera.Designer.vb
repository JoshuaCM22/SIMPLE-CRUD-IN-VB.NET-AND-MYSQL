<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Camera
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Camera))
        Me.btnAddNewStudent = New System.Windows.Forms.Button()
        Me.btnStudentProfile = New System.Windows.Forms.Button()
        Me.panel = New System.Windows.Forms.Panel()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnCaptured = New System.Windows.Forms.Button()
        Me.btnSaveImage = New System.Windows.Forms.Button()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.pictureboxTwo = New System.Windows.Forms.PictureBox()
        Me.pictureboxOne = New System.Windows.Forms.PictureBox()
        Me.panel.SuspendLayout()
        CType(Me.pictureboxTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureboxOne, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAddNewStudent
        '
        Me.btnAddNewStudent.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnAddNewStudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddNewStudent.FlatAppearance.BorderSize = 0
        Me.btnAddNewStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNewStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewStudent.ForeColor = System.Drawing.Color.White
        Me.btnAddNewStudent.Location = New System.Drawing.Point(1093, 628)
        Me.btnAddNewStudent.Name = "btnAddNewStudent"
        Me.btnAddNewStudent.Size = New System.Drawing.Size(135, 33)
        Me.btnAddNewStudent.TabIndex = 65
        Me.btnAddNewStudent.Text = "BACK"
        Me.btnAddNewStudent.UseVisualStyleBackColor = False
        '
        'btnStudentProfile
        '
        Me.btnStudentProfile.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnStudentProfile.FlatAppearance.BorderSize = 0
        Me.btnStudentProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudentProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudentProfile.ForeColor = System.Drawing.Color.White
        Me.btnStudentProfile.Location = New System.Drawing.Point(1093, 628)
        Me.btnStudentProfile.Name = "btnStudentProfile"
        Me.btnStudentProfile.Size = New System.Drawing.Size(135, 33)
        Me.btnStudentProfile.TabIndex = 64
        Me.btnStudentProfile.Text = "BACK"
        Me.btnStudentProfile.UseVisualStyleBackColor = False
        '
        'panel
        '
        Me.panel.BackColor = System.Drawing.Color.Black
        Me.panel.Controls.Add(Me.btnStart)
        Me.panel.Controls.Add(Me.btnCaptured)
        Me.panel.Location = New System.Drawing.Point(48, 583)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(674, 60)
        Me.panel.TabIndex = 63
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStart.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.White
        Me.btnStart.Location = New System.Drawing.Point(292, 7)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(94, 33)
        Me.btnStart.TabIndex = 7
        Me.btnStart.Text = "START"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnCaptured
        '
        Me.btnCaptured.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCaptured.BackgroundImage = Global.SIMPLE_CRUD_IN_VB_AND_MYSQL.My.Resources.Resources.cameraicon
        Me.btnCaptured.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCaptured.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCaptured.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnCaptured.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCaptured.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCaptured.ForeColor = System.Drawing.Color.Black
        Me.btnCaptured.Location = New System.Drawing.Point(292, 7)
        Me.btnCaptured.Name = "btnCaptured"
        Me.btnCaptured.Size = New System.Drawing.Size(94, 44)
        Me.btnCaptured.TabIndex = 8
        Me.btnCaptured.UseVisualStyleBackColor = False
        '
        'btnSaveImage
        '
        Me.btnSaveImage.BackColor = System.Drawing.Color.Black
        Me.btnSaveImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnSaveImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSaveImage.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveImage.ForeColor = System.Drawing.Color.White
        Me.btnSaveImage.Location = New System.Drawing.Point(952, 526)
        Me.btnSaveImage.Name = "btnSaveImage"
        Me.btnSaveImage.Size = New System.Drawing.Size(115, 33)
        Me.btnSaveImage.TabIndex = 62
        Me.btnSaveImage.Text = "SAVE IMAGE"
        Me.btnSaveImage.UseVisualStyleBackColor = False
        '
        'pictureboxTwo
        '
        Me.pictureboxTwo.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.pictureboxTwo.Location = New System.Drawing.Point(772, 123)
        Me.pictureboxTwo.Name = "pictureboxTwo"
        Me.pictureboxTwo.Size = New System.Drawing.Size(465, 383)
        Me.pictureboxTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureboxTwo.TabIndex = 61
        Me.pictureboxTwo.TabStop = False
        '
        'pictureboxOne
        '
        Me.pictureboxOne.BackColor = System.Drawing.Color.Black
        Me.pictureboxOne.Location = New System.Drawing.Point(48, 48)
        Me.pictureboxOne.Name = "pictureboxOne"
        Me.pictureboxOne.Size = New System.Drawing.Size(674, 580)
        Me.pictureboxOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureboxOne.TabIndex = 60
        Me.pictureboxOne.TabStop = False
        '
        'Form_Camera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1300, 690)
        Me.Controls.Add(Me.btnAddNewStudent)
        Me.Controls.Add(Me.btnStudentProfile)
        Me.Controls.Add(Me.panel)
        Me.Controls.Add(Me.btnSaveImage)
        Me.Controls.Add(Me.pictureboxTwo)
        Me.Controls.Add(Me.pictureboxOne)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Camera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TAKE A PICTURE"
        Me.panel.ResumeLayout(False)
        CType(Me.pictureboxTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureboxOne, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAddNewStudent As System.Windows.Forms.Button
    Friend WithEvents btnStudentProfile As System.Windows.Forms.Button
    Friend WithEvents panel As System.Windows.Forms.Panel
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnCaptured As System.Windows.Forms.Button
    Friend WithEvents btnSaveImage As System.Windows.Forms.Button
    Friend WithEvents pictureboxTwo As System.Windows.Forms.PictureBox
    Friend WithEvents pictureboxOne As System.Windows.Forms.PictureBox
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
End Class
