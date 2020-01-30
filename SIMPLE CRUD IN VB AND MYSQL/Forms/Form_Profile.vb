Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Public Class Form_Profile ' Created by: Joshua C. Magoliman
    Dim gender As String
    Dim arrImage() As Byte
    Private Sub Reset()
        txtStudentId.Enabled = False
        txtLastName.Enabled = False
        txtMiddleName.Enabled = False
        txtGivenName.Enabled = False
        txtAge.Enabled = False
        txtAddress.Enabled = False
        radiobtnMale.Enabled = False
        radiobtnFemale.Enabled = False
        btnBrowse.Enabled = False
        dtpDateOfBirth.Enabled = False
        btnTakeAPicture.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnEdit.Enabled = True
        btnClose.Text = "CLOSE"
    End Sub
    Private Sub Form_Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnEdit.Enabled = False
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        txtLastName.Enabled = True
        txtMiddleName.Enabled = True
        txtGivenName.Enabled = True
        txtAge.Enabled = True
        txtAddress.Enabled = True
        radiobtnMale.Enabled = True
        radiobtnFemale.Enabled = True
        btnBrowse.Enabled = True
        dtpDateOfBirth.Enabled = True
        btnTakeAPicture.Enabled = True
        btnClose.Text = "CANCEL"
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim Question1 As String
        Question1 = MsgBox("Are you sure you want to update ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATTENTION")
        If Question1 = vbYes Then
            Try
                Dim mstream As New System.IO.MemoryStream()
                pictureboxProfile.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                arrImage = mstream.GetBuffer()
                Dim FileSize As UInt64
                FileSize = mstream.Length
                mstream.Close()
                con.Open()
                cmd = New MySqlCommand("sp_UpdateExistingStudent", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add(New MySqlParameter("@param_LastName", txtLastName.Text))
                cmd.Parameters.Add(New MySqlParameter("@param_GivenName", txtGivenName.Text))
                cmd.Parameters.Add(New MySqlParameter("@param_MiddleName", txtMiddleName.Text))
                cmd.Parameters.Add(New MySqlParameter("@param_GenderId", gender))
                cmd.Parameters.Add(New MySqlParameter("@param_DateOfBirth", dtpDateOfBirth.Value))
                cmd.Parameters.Add(New MySqlParameter("@param_Age", txtAge.Text))
                cmd.Parameters.Add(New MySqlParameter("@param_Address", txtAddress.Text))
                cmd.Parameters.Add(New MySqlParameter("@param_Photo", arrImage))
                cmd.Parameters.Add(New MySqlParameter("@param_StudentId", txtStudentId.Text))
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                con.Close()
                MsgBox("SUCCESSFULLY UPDATED", MsgBoxStyle.Information, "ATTENTION")
                Reset()
                Form_Students.GetData()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim Question1 As String
        Question1 = MsgBox("Are you sure you want to delete ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATTENTION")
        If Question1 = vbYes Then
            Try
                con.Open()
                cmd = New MySqlCommand("sp_DeleteExistingStudent", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("param_StudentId", txtStudentId.Text)
                cmd.ExecuteNonQuery()
                MsgBox("SUCCESSFULLY DELETED", MsgBoxStyle.Information, "ATTENTION")
                con.Close()
                Reset()
                Me.Hide()
                Form_Students.GetData()
                Form_Students.Enabled = True
                Form_Students.btnBack.Visible = True
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If btnClose.Text = "CANCEL" = True Then
            Dim Question1 As String
            Question1 = MsgBox("Are you sure you want to cancel ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "ATTENTION")
            If Question1 = vbYes Then
                Me.Hide()
                Reset()
                Form_Students.Show()
                Form_Students.Enabled = True
                Form_Students.btnBack.Visible = True
            End If
        Else
            Me.Hide()
            Reset()
            Form_Students.Show()
            Form_Students.Enabled = True
            Form_Students.btnBack.Visible = True
        End If
    End Sub
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "image file (*.jpg, *.gif, *.bmp, *.png) | *.jpg; *.gif; *.bmp; *.png *.| all files (*.*) | *.*"
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            pictureboxProfile.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub
    Private Sub btnTakeAPicture_Click(sender As Object, e As EventArgs) Handles btnTakeAPicture.Click
        Me.Enabled = False
        Form_Camera.btnAddNewStudent.Visible = False
        Form_Camera.btnStudentProfile.Visible = True
        Form_Camera.Show()
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
    Private Sub radiobtnMale_CheckedChanged(sender As Object, e As EventArgs) Handles radiobtnMale.CheckedChanged
        gender = "1"
    End Sub
    Private Sub radiobtnFemale_CheckedChanged(sender As Object, e As EventArgs) Handles radiobtnFemale.CheckedChanged
        gender = "2"
    End Sub
    Private Sub txtAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAge.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class