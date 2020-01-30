Imports System.Drawing
Imports System.Windows.Forms
Public Class Form_Main ' Created by: Joshua C. Magoliman
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTimeNow.Text = TimeOfDay.ToString("h:mm:ss tt")
        lblDateToday.Text = Date.Now.ToString("MMMM dd, yyyy")
        lblDayToday.Text = WeekdayName(Weekday(Now))
    End Sub
    Private Sub btnStudents_Click(sender As Object, e As EventArgs) Handles btnStudents.Click
        Me.Hide()
        Form_Students.Show()
    End Sub
    Private Sub Form_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        lblTimeNow.Focus()
        lblDateToday.Text = Date.Now.ToString("MMMM d, yyyy")
        lblDayToday.Text = WeekdayName(Weekday(Now))
    End Sub
    Private Sub toolstrip_CreateAnotherAccount_Click(sender As Object, e As EventArgs) Handles toolstrip_CreateAnotherAccount.Click
        Me.Hide()
        Form_CreateAnotherAccount.Show()
        Form_CreateAnotherAccount.txtUsername.Focus()
    End Sub
    Private Sub toolstrip_ChangePassword_Click(sender As Object, e As EventArgs) Handles toolstrip_ChangePassword.Click
        Me.Hide()
        Form_ChangePassword.Show()
        Form_ChangePassword.txtCurrentPassword.Focus()
    End Sub
    Private Sub toolstrip_Logout_Click(sender As Object, e As EventArgs) Handles toolstrip_Logout.Click
        Dim Question1 As String
        Question1 = MsgBox("Are you sure you want to log-out ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATTENTION")
        If Question1 = vbYes Then
            Me.Hide()
            Form_Login.Show()
            Form_Login.txtUsername.Focus()
            Form_Login.chckboxShowPassword.Checked = False
            Form_Login.txtUsername.Clear()
            Form_Login.txtPassword.Clear()
        End If
    End Sub
End Class