Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Windows.Forms
Public Class Form_Login ' Created by: Joshua C. Magoliman
    Private Sub Reset()
        chckboxShowPassword.Checked = False
        txtUsername.Focus()
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub
    Private Sub Form_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub
    Private Sub Form_Login_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnForgotPassword.PerformClick()
        End If
    End Sub
    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtUsername.Text = "" And txtPassword.Text = "" Then
                MsgBox("No Username and Password Found!", MsgBoxStyle.Critical, "ATTENTION")
                txtUsername.Focus()
            ElseIf txtUsername.Text = "" Then
                MsgBox("No Username Found!", MsgBoxStyle.Critical, "ATTENTION")
                txtUsername.Focus()
            ElseIf txtPassword.Text = "" Then
                MsgBox("No Password Found!", MsgBoxStyle.Critical, "ATTENTION")
                txtPassword.Focus()
            Else
                lblPassword.Focus()
                LoginValidation()
            End If
        End If
    End Sub
    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtUsername.Text = "" And txtPassword.Text = "" Then
                MsgBox("No Username and Password Found!", MsgBoxStyle.Critical, "ATTENTION")
                txtUsername.Focus()
            ElseIf txtUsername.Text = "" Then
                MsgBox("No Username Found!", MsgBoxStyle.Critical, "ATTENTION")
                txtUsername.Focus()
            ElseIf txtPassword.Text = "" Then
                MsgBox("No Password Found!", MsgBoxStyle.Critical, "ATTENTION")
                txtPassword.Focus()
            Else
                lblPassword.Focus()
                LoginValidation()
            End If
        End If
    End Sub
    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub chckboxShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chckboxShowPassword.CheckedChanged
        If chckboxShowPassword.Checked = False Then
            txtPassword.UseSystemPasswordChar = True
        Else
            txtPassword.UseSystemPasswordChar = False
        End If
        lblUsername.Focus()
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" And txtPassword.Text = "" Then
            MsgBox("No Username and Password Found!", MsgBoxStyle.Critical, "ATTENTION")
            txtUsername.Focus()
        ElseIf txtUsername.Text = "" Then
            MsgBox("No Username Found!", MsgBoxStyle.Critical, "ATTENTION")
            txtUsername.Focus()
        ElseIf txtPassword.Text = "" Then
            MsgBox("No Password Found!", MsgBoxStyle.Critical, "ATTENTION")
            txtPassword.Focus()
        Else
            lblPassword.Focus()
            LoginValidation()
        End If
    End Sub
    Private Sub LoginValidation()
        Try
            con.Open()
            cmd = New MySqlCommand("SELECT * FROM tbl_Users WHERE Username = @Username AND BINARY Password = @Password", con)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
            dr = cmd.ExecuteReader()
            If dr.Read Then
                dr.Close()
                con.Close()
                Form_ChangePassword.usernameGetter = txtUsername.Text
                Form_ChangePassword.passwordGetter = txtPassword.Text
                Me.Hide()
                Form_Main.Show()
            Else
                dr.Close()
                con.Close()
                MsgBox("Invalid details!", MsgBoxStyle.Critical, "ATTENTION")
                Reset()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            dr.Close()
            con.Close()
        End Try
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    Private Sub btnForgotPassword_Click(sender As Object, e As EventArgs) Handles btnForgotPassword.Click
        Me.Hide()
        Form_ForgotPassword.Show()
        Form_ForgotPassword.txtUsername.Focus()
    End Sub
End Class