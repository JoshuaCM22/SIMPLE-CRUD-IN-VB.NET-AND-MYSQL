Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Windows.Forms
Public Class Form_ChangePassword ' Created by: Joshua C. Magoliman
    Public usernameGetter, passwordGetter As String
    Public Sub Validation()
        If txtCurrentPassword.Text = "" And txtNewPassword.Text = "" And txtConfirmNewPassword.Text = "" Then
            MsgBox("Fill up your password details", MsgBoxStyle.Critical, "ATTENTION")
            txtCurrentPassword.Focus()
        ElseIf txtCurrentPassword.Text = "" Then
            MsgBox("No Current Password Found!", MsgBoxStyle.Critical, "Error")
            txtCurrentPassword.Focus()
        ElseIf txtNewPassword.Text = "" Then
            MsgBox("No New Password Found!", MsgBoxStyle.Critical, "Error")
            txtNewPassword.Focus()
        ElseIf txtConfirmNewPassword.Text = "" Then
            MsgBox("No Confirm New Password Found!", MsgBoxStyle.Critical, "Error")
            txtConfirmNewPassword.Focus()
        Else
            Try
                con.Open()
                cmd = New MySqlCommand("SELECT * FROM tbl_Users WHERE BINARY Username = @Username AND BINARY Password = @Password ", con)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.Add(New MySqlParameter("@Username", usernameGetter))
                cmd.Parameters.Add(New MySqlParameter("@Password", txtCurrentPassword.Text))
                dr = cmd.ExecuteReader()
                Dim count As Integer
                count = 0
                While dr.Read
                    count = count + 1
                End While
                If count = 1 Then
                    dr.Close()
                    con.Close()
                    Reading()
                Else
                    dr.Close()
                    con.Close()
                    MsgBox("Current Password is incorrect!", MsgBoxStyle.Critical, "Error")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try
        End If
    End Sub
    Public Sub Reading()
        If Not txtNewPassword.Text = txtConfirmNewPassword.Text Then
            MsgBox("Your New Password and Confirm New Password are not same!", MsgBoxStyle.Critical, "Error")
        ElseIf Not txtConfirmNewPassword.Text = txtNewPassword.Text Then
            MsgBox("Your New Password and Confirm New Password are not same!", MsgBoxStyle.Critical, "Error")
        Else
            con.Open()
            cmd = New MySqlCommand("SELECT * FROM tbl_Users WHERE Username = @Username AND Password = @Password ", con)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add(New MySqlParameter("@Username", usernameGetter))
            cmd.Parameters.Add(New MySqlParameter("@Password", txtConfirmNewPassword.Text))
            dr = cmd.ExecuteReader()
            Dim count As Integer
            count = 0
            While dr.Read
                count = count + 1
            End While
            If count = 1 Then
                MsgBox("Your new and confirm password is currently used, please try another password!", MsgBoxStyle.Critical, "ATTENTION")
            Else
                dr.Close()
                con.Close()
                Updating()
            End If
            dr.Close()
            con.Close()
        End If
    End Sub
    Public Sub Updating()
        Try
            con.Open()
            cmd = New MySqlCommand("UPDATE tbl_Users set Password = @Password WHERE Username = @Username", con)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add(New MySqlParameter("@Password", txtNewPassword.Text))
            cmd.Parameters.Add(New MySqlParameter("@Username", usernameGetter))
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MsgBox("SUCCESSFULLY UPDATED", MsgBoxStyle.Information, "ATTENTION")
            passwordGetter = txtNewPassword.Text
            txtCurrentPassword.Clear()
            txtNewPassword.Clear()
            txtConfirmNewPassword.Clear()
            chckbox_ShowPassword1.Checked = False
            chckbox_ShowPassword2.Checked = False
            Me.Hide()
            Form_Main.Show()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        Validation()
    End Sub
    Private Sub Form_ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub
    Private Sub Reset()
        txtCurrentPassword.Clear()
        txtNewPassword.Clear()
        txtConfirmNewPassword.Clear()
        chckbox_ShowPassword1.Checked = False
        chckbox_ShowPassword2.Checked = False
    End Sub
    Private Sub Form_ChangePassword_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnChangePassword.PerformClick()
        End If
    End Sub
    Private Sub chckbox_ShowPassword1_CheckedChanged(sender As Object, e As EventArgs) Handles chckbox_ShowPassword1.CheckedChanged
        If chckbox_ShowPassword1.Checked = False Then
            txtCurrentPassword.UseSystemPasswordChar = True
        Else
            txtCurrentPassword.UseSystemPasswordChar = False
        End If
        lblCurrentPassword.Focus()
    End Sub
    Private Sub chckbox_ShowPassword2_CheckedChanged(sender As Object, e As EventArgs) Handles chckbox_ShowPassword2.CheckedChanged
        If chckbox_ShowPassword2.Checked = False Then
            txtNewPassword.UseSystemPasswordChar = True
            txtConfirmNewPassword.UseSystemPasswordChar = True
        Else
            txtNewPassword.UseSystemPasswordChar = False
            txtConfirmNewPassword.UseSystemPasswordChar = False
        End If
        lblCurrentPassword.Focus()
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Reset()
        Form_Main.Show()
        Me.Hide()
    End Sub
    Private Sub txtCurrentPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCurrentPassword.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtNewPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNewPassword.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtConfirmNewPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConfirmNewPassword.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class