Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Windows.Forms
Public Class Form_CreateAnotherAccount ' Created by: Joshua C. Magoliman
    Private Sub Reset()
        txtUsername.MaxLength = 15
        txtSecretAnswer.MaxLength = 15
        txtUsername.Clear()
        txtPassword.Clear()
        cmbboxSecretQuestion.Text = "None"
        txtSecretAnswer.Clear()
        chckbox_ShowPassword.Checked = False
        chckbox_ShowSecretAnswer.Checked = False
    End Sub
    Private Sub Form_CreateAnotherAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub
    Private Sub Form_CreateAnotherAccount_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnRegister.PerformClick()
        End If
    End Sub
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtUsername.Text = "" And txtPassword.Text = "" And cmbboxSecretQuestion.Text = "" And txtSecretAnswer.Text = "" Then
            MsgBox("Fill up your account details", MsgBoxStyle.Critical, "ATTENTION")
            txtUsername.Focus()
        ElseIf txtUsername.Text = "" Then
            MsgBox("No Username Found!", MsgBoxStyle.Critical, "Error")
            txtUsername.Focus()
        ElseIf txtPassword.Text = "" Then
            MsgBox("No Password Found!", MsgBoxStyle.Critical, "Error")
            txtPassword.Focus()
        ElseIf cmbboxSecretQuestion.Text = "None" Then
            MsgBox("No Secret Question Found!", MsgBoxStyle.Critical, "Error")
            cmbboxSecretQuestion.Focus()
        ElseIf txtSecretAnswer.Text = "" Then
            MsgBox("No Secret Answer Found!", MsgBoxStyle.Critical, "Error")
            txtSecretAnswer.Focus()
        Else
            CheckingUsername()
        End If
    End Sub
    Private Sub CheckingUsername()
        Try
            con.Open()
            cmd = New MySqlCommand("SELECT Username FROM tbl_Users WHERE Username=@Username ", con)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add(New MySqlParameter("@Username", txtUsername.Text))
            dr = cmd.ExecuteReader()
            Dim count As Integer
            count = 0
            While dr.Read
                count = count + 1
            End While
            Select Case count
                Case 1
                    MsgBox("Username is already exist. Please try another username!", MsgBoxStyle.Critical, "ATTENTION")
                Case Else
                    con.Close()
                    CreatingAccount()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            dr.Close()
            con.Close()
        End Try
    End Sub
    Public Sub CreatingAccount()
        Try
            con.Open()
            cmd = New MySqlCommand("sp_InsertNewUser", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New MySqlParameter("@param_Username", txtUsername.Text))
            cmd.Parameters.Add(New MySqlParameter("@param_Password", txtPassword.Text))
            cmd.Parameters.Add(New MySqlParameter("@param_SecretQuestion", cmbboxSecretQuestion.Text))
            cmd.Parameters.Add(New MySqlParameter("@param_SecretAnswer", txtSecretAnswer.Text))
            cmd.ExecuteNonQuery()
            MsgBox("SUCCESSFULLY REGISTERED", MsgBoxStyle.Information, "ATTENTION")
            con.Close()
            Reset()
            Me.Hide()
            Form_Main.Show()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Reset()
        Form_Main.Show()
    End Sub
    Private Sub chckbox_ShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chckbox_ShowPassword.CheckedChanged
        If chckbox_ShowPassword.Checked = False Then
            txtPassword.UseSystemPasswordChar = True
        Else
            txtPassword.UseSystemPasswordChar = False
        End If
        lblUsername.Focus()
    End Sub
    Private Sub chckbox_ShowSecretAnswer_CheckedChanged(sender As Object, e As EventArgs) Handles chckbox_ShowSecretAnswer.CheckedChanged
        If chckbox_ShowSecretAnswer.Checked = False Then
            txtSecretAnswer.UseSystemPasswordChar = True
        Else
            txtSecretAnswer.UseSystemPasswordChar = False
        End If
        lblUsername.Focus()
    End Sub
    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class