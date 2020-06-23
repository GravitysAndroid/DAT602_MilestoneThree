Public Class FrmLogin
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim DA As DataAccessClass
        Dim DS As DataSet
        Dim lcUsername As String = TxtUsername.Text
        Dim lcPassword As String = TxtPassword.Text
        Dim lcLoginMessage As String = ""

        DA = New DataAccessClass()
        DS = New DataSet()

        DS = DA.Login(lcUsername, lcPassword)

        For Each aRow As DataRow In DS.Tables(0).Rows
            lcLoginMessage = aRow("Message")
        Next
        If (lcLoginMessage = "Login Successful") Then
            DataAccessClass.playerName = Me.TxtUsername.Text
            MessageBox.Show("Login Successful")
            FrmGameDisplay.Show()
            Me.Hide()
        Else
            MessageBox.Show("Login Failed")
            FrmRegister.Show()
            Me.Hide()
        End If


    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        FrmRegister.Show()
        Me.Hide()
    End Sub
End Class
