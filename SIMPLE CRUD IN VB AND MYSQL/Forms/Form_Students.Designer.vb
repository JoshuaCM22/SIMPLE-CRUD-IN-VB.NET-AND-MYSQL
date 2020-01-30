<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Students
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Students))
        Me.dgvStudents = New System.Windows.Forms.DataGridView()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnAddNewStudent = New System.Windows.Forms.Button()
        Me.groupBox = New System.Windows.Forms.GroupBox()
        Me.cmbboxFilter = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvStudents
        '
        Me.dgvStudents.AllowUserToAddRows = False
        Me.dgvStudents.AllowUserToResizeColumns = False
        Me.dgvStudents.AllowUserToResizeRows = False
        Me.dgvStudents.BackgroundColor = System.Drawing.Color.MidnightBlue
        Me.dgvStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStudents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvStudents.ColumnHeadersHeight = 41
        Me.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStudents.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvStudents.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvStudents.Location = New System.Drawing.Point(28, 144)
        Me.dgvStudents.MultiSelect = False
        Me.dgvStudents.Name = "dgvStudents"
        Me.dgvStudents.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.NullValue = "---------"
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStudents.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvStudents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStudents.Size = New System.Drawing.Size(1301, 429)
        Me.dgvStudents.TabIndex = 56
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(33, 599)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(132, 30)
        Me.btnBack.TabIndex = 58
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnAddNewStudent
        '
        Me.btnAddNewStudent.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnAddNewStudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddNewStudent.FlatAppearance.BorderSize = 0
        Me.btnAddNewStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNewStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewStudent.ForeColor = System.Drawing.Color.White
        Me.btnAddNewStudent.Location = New System.Drawing.Point(1131, 81)
        Me.btnAddNewStudent.Name = "btnAddNewStudent"
        Me.btnAddNewStudent.Size = New System.Drawing.Size(198, 41)
        Me.btnAddNewStudent.TabIndex = 59
        Me.btnAddNewStudent.Text = "ADD A NEW STUDENT"
        Me.btnAddNewStudent.UseVisualStyleBackColor = False
        '
        'groupBox
        '
        Me.groupBox.BackColor = System.Drawing.Color.Transparent
        Me.groupBox.Controls.Add(Me.cmbboxFilter)
        Me.groupBox.Controls.Add(Me.txtSearch)
        Me.groupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox.ForeColor = System.Drawing.Color.White
        Me.groupBox.Location = New System.Drawing.Point(33, 53)
        Me.groupBox.Name = "groupBox"
        Me.groupBox.Size = New System.Drawing.Size(412, 69)
        Me.groupBox.TabIndex = 60
        Me.groupBox.TabStop = False
        Me.groupBox.Text = "SEARCH BY :"
        '
        'cmbboxFilter
        '
        Me.cmbboxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbboxFilter.FormattingEnabled = True
        Me.cmbboxFilter.Items.AddRange(New Object() {"None", "Student ID", "Last Name", "Given Name", "Middle Name", "Gender", "Date of Birth", "Age", "Address"})
        Me.cmbboxFilter.Location = New System.Drawing.Point(14, 28)
        Me.cmbboxFilter.Name = "cmbboxFilter"
        Me.cmbboxFilter.Size = New System.Drawing.Size(138, 24)
        Me.cmbboxFilter.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(158, 28)
        Me.txtSearch.MaxLength = 30
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(235, 22)
        Me.txtSearch.TabIndex = 0
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(1190, 589)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(104, 18)
        Me.lblTotal.TabIndex = 61
        Me.lblTotal.Text = "TOTAL LABEL"
        '
        'Form_Students
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1359, 649)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.groupBox)
        Me.Controls.Add(Me.btnAddNewStudent)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvStudents)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_Students"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox.ResumeLayout(False)
        Me.groupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvStudents As System.Windows.Forms.DataGridView
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnAddNewStudent As System.Windows.Forms.Button
    Friend WithEvents groupBox As System.Windows.Forms.GroupBox
    Friend WithEvents cmbboxFilter As System.Windows.Forms.ComboBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
End Class
