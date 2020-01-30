Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Public Class Form_Camera ' Created by: Joshua C. Magoliman
    Dim videoCaptureDevice As VideoCaptureDevice
    Dim bitmap As Bitmap
    Private Sub Captured(sender As Object, eventArgs As NewFrameEventArgs)
        bitmap = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        pictureboxOne.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub
    Private Sub Form_Camera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pictureboxTwo.Image = My.Resources.usericon()
        btnCaptured.Hide()
        btnSaveImage.Hide()
    End Sub
    Private Sub Form_Camera_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        videoCaptureDevice.Stop()
    End Sub
    Private Sub btnSaveImage_Click(sender As Object, e As EventArgs) Handles btnSaveImage.Click
        SaveFileDialog.DefaultExt = ".jpg"
        If SaveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            pictureboxTwo.Image.Save(SaveFileDialog.FileName, Imaging.ImageFormat.Jpeg)
            pictureboxTwo.Image = My.Resources.usericon()
            pictureboxTwo.BackColor = Color.DimGray
        End If
    End Sub
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim videoCaptureDevicef As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        If videoCaptureDevicef.ShowDialog() = Windows.Forms.DialogResult.OK Then
            videoCaptureDevice = videoCaptureDevicef.VideoDevice
            AddHandler videoCaptureDevice.NewFrame, New NewFrameEventHandler(AddressOf Captured)
            videoCaptureDevice.Start()
            btnStart.Hide()
            btnCaptured.Show()
            btnSaveImage.Show()
        End If
    End Sub
    Private Sub btnCaptured_Click(sender As Object, e As EventArgs) Handles btnCaptured.Click
        pictureboxTwo.Image = pictureboxOne.Image
        pictureboxTwo.BackColor = Color.Black
    End Sub
    Private Sub btnAddNewStudent_Click(sender As Object, e As EventArgs) Handles btnAddNewStudent.Click
        Hide()
        Form_AddNewStudent.Enabled = True
    End Sub
    Private Sub btnStudentProfile_Click(sender As Object, e As EventArgs) Handles btnStudentProfile.Click
        Hide()
        Form_Profile.Enabled = True
    End Sub
End Class