Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Public Class Form_AddNewStudent ' Created by: Joshua C. Magoliman
    Dim gender As String
    Dim arrImage() As Byte
    Dim photo As Image = My.Resources.usericon
    Private Sub Reset()
        pictureboxProfile.Image = photo
        txtLastName.Focus()
        txtLastName.Clear()
        txtMiddleName.Clear()
        txtGivenName.Clear()
        txtAge.Clear()
        txtAddress.Clear()
        radiobtnMale.Checked = False
        radiobtnFemale.Checked = False
        cmbboxMonth.Text = "Month"
        cmbboxDay.Text = "Day"
        txtYear.Text = "Year"
    End Sub
    Private Sub Form_AddNewStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtLastName.Text = "" And txtMiddleName.Text = "" And txtGivenName.Text = "" And txtAge.Text = "" And txtAddress.Text = "" And cmbboxMonth.Text = "Month" And cmbboxDay.Text = "Day" And txtYear.Text = "Year" And radiobtnMale.Checked = False And radiobtnFemale.Checked = False Then
            MsgBox("Fill up your all the details", MsgBoxStyle.Critical, "ATTENTION")
            txtLastName.Focus()
        ElseIf txtLastName.Text = "" Then
            MsgBox("No Surname Found!", MsgBoxStyle.Critical, "Error")
            txtLastName.Focus()
        ElseIf txtMiddleName.Text = "" Then
            MsgBox("No First Name Found!", MsgBoxStyle.Critical, "Error")
            txtMiddleName.Focus()
        ElseIf txtGivenName.Text = "" Then
            MsgBox("No Middle Name Found!", MsgBoxStyle.Critical, "Error")
            txtGivenName.Focus()
        ElseIf radiobtnMale.Checked = False And radiobtnFemale.Checked = False Then
            MsgBox("No Gender Found!", MsgBoxStyle.Critical, "Error")
        ElseIf cmbboxMonth.Text = "Month" Then
            MsgBox("No Month Found!", MsgBoxStyle.Critical, "Error")
        ElseIf cmbboxDay.Text = "Day" Then
            MsgBox("No Day Found!", MsgBoxStyle.Critical, "Error")
        ElseIf txtYear.Text = "Year" Then
            MsgBox("No Year Found!", MsgBoxStyle.Critical, "Error")
        ElseIf txtAge.Text = "" Then
            MsgBox("No Age Found!", MsgBoxStyle.Critical, "Error")
            txtAge.Focus()
        ElseIf txtAddress.Text = "" Then
            MsgBox("No Address Found!", MsgBoxStyle.Critical, "Error")
            txtAddress.Focus()
        ElseIf pictureboxProfile.Image Is photo Then
            MsgBox("No Photo Found!", MsgBoxStyle.Critical, "Error")
            btnBrowseClicked()
        Else
            Try
                Dim mstream As New System.IO.MemoryStream()
                pictureboxProfile.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                arrImage = mstream.GetBuffer()
                Dim FileSize As UInt64
                FileSize = mstream.Length
                mstream.Close()

                Dim combine As String
                combine = cmbboxMonth.Text & Space(1) + cmbboxDay.Text + (",") & Space(1) + txtYear.Text

                con.Open()
                cmd = New MySqlCommand("sp_InsertNewStudent", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add(New MySqlParameter("@param_LastName", txtLastName.Text))
                cmd.Parameters.Add(New MySqlParameter("@param_GivenName", txtGivenName.Text))
                cmd.Parameters.Add(New MySqlParameter("@param_MiddleName", txtMiddleName.Text))
                cmd.Parameters.Add(New MySqlParameter("@param_GenderId", gender))
                cmd.Parameters.Add(New MySqlParameter("@param_DateOfBirth", Convert.ToDateTime(combine)))
                cmd.Parameters.Add(New MySqlParameter("@param_Age", txtAge.Text))
                cmd.Parameters.Add(New MySqlParameter("@param_Address", txtAddress.Text))
                cmd.Parameters.Add(New MySqlParameter("@param_Photo", arrImage))
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                MsgBox("SUCCESSFULLY ADDDED", MsgBoxStyle.Information, "ATTENTION")
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            Finally
                con.Close()
                Reset()
            End Try
        End If
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If btnBack.Text = "BACK" Then
            Me.Hide()
            Reset()
            Form_Students.GetData()
            Form_Students.Show()
        Else
            Dim Question1 As String
            Question1 = MsgBox("Are you sure you want to cancel ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATTENTION")
            If Question1 = vbYes Then
                Me.Hide()
                Reset()
                Form_Students.GetData()
                Form_Students.Show()
            End If
        End If
    End Sub
    Private Sub radiobtnMale_CheckedChanged(sender As Object, e As EventArgs) Handles radiobtnMale.CheckedChanged
        gender = "1"
    End Sub
    Private Sub radiobtnFemale_CheckedChanged(sender As Object, e As EventArgs) Handles radiobtnFemale.CheckedChanged
        gender = "2"
    End Sub
    Private Sub cmbboxMonth_Click(sender As Object, e As EventArgs) Handles cmbboxMonth.Click
        Me.cmbboxMonth.Text = ""
    End Sub
    Private Sub cmbboxMonth_Layout(sender As Object, e As LayoutEventArgs) Handles cmbboxMonth.Layout
        Me.cmbboxMonth.Text = "Month"
    End Sub
    Private Sub cmbboxMonth_Leave(sender As Object, e As EventArgs) Handles cmbboxMonth.Leave
        If cmbboxMonth.Text = "" Then
            Me.cmbboxMonth.Text = "Month"
        End If
    End Sub
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        btnBrowseClicked()
    End Sub
    Private Sub btnBrowseClicked()
        OpenFileDialog1.Filter = "image file (*.jpg, *.gif, *.bmp, *.png) | *.jpg; *.gif; *.bmp; *.png *.| all files (*.*) | *.*"
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            pictureboxProfile.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
        lblLastName.Focus()
    End Sub
    Private Sub btnTakeAPicture_Click(sender As Object, e As EventArgs) Handles btnTakeAPicture.Click
        lblLastName.Focus()
        Me.Enabled = False
        Form_Camera.btnAddNewStudent.Visible = True
        Form_Camera.btnStudentProfile.Visible = False
        Form_Camera.Show()
    End Sub
    Private Sub cmbboxYear_TextChanged(sender As Object, e As EventArgs) Handles txtYear.TextChanged
        Dim todayYear As Integer = Today.Year
        Dim todayDay As Integer = Today.Day
        Dim todayMonth As Integer = Today.Month
        Dim getValueOfYear As Integer = Val(txtYear.Text)
        Dim getValueOfDay As Integer = Val(cmbboxDay.Text)
        Dim getValueOfMonth As String = cmbboxMonth.SelectedIndex + 1
        Dim finalOutput As Integer = todayYear - getValueOfYear
        If todayMonth = getValueOfMonth Then
            If todayDay < getValueOfDay Then
                finalOutput -= 1
            End If
        ElseIf todayMonth < getValueOfMonth Then
            finalOutput -= 1
        End If
        txtAge.Text = finalOutput
    End Sub
    Private Sub cmbboxYear_Layout(sender As Object, e As LayoutEventArgs) Handles txtYear.Layout
        Me.txtYear.Text = "Year"
    End Sub
    Private Sub cmbboxYear_Click(sender As Object, e As EventArgs) Handles txtYear.Click
        Me.txtYear.Clear()
    End Sub
    Private Sub cmbboxYear_Leave(sender As Object, e As EventArgs) Handles txtYear.Leave
        If txtYear.Text = "" Then
            Me.txtYear.Text = "Year"
        End If
    End Sub
    Private Sub cmbboxDay_Click(sender As Object, e As EventArgs) Handles cmbboxDay.Click
        Me.cmbboxDay.Text = ""
    End Sub
    Private Sub cmbboxDay_Layout(sender As Object, e As LayoutEventArgs) Handles cmbboxDay.Layout
        Me.cmbboxDay.Text = "Day"
    End Sub
    Private Sub cmbboxDay_Leave(sender As Object, e As EventArgs) Handles cmbboxDay.Leave
        If cmbboxDay.Text = "" Then
            Me.cmbboxDay.Text = "Day"
        End If
    End Sub
    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged
        If txtLastName.Text = "" Then
            btnBack.Text = "BACK"
        Else
            btnBack.Text = "CANCEL"
        End If
    End Sub
    Private Sub txtLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLastName.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtMiddleName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMiddleName.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtGivenName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGivenName.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAge.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtAge_Leave(sender As Object, e As EventArgs) Handles txtAge.Leave
        If txtAge.Text = "2017" Then
            Me.txtAge.Clear()
        End If
    End Sub
End Class