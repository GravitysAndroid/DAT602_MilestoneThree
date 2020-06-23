Public Class FrmRegister
    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Dim DA As DataAccessClass
        Dim DS As DataSet
        Dim lcPlayerName As String = TxtUserName.Text
        Dim lcPassword As String = TxtPassword.Text
        Dim lcEmail As String = TxtEmail.Text
        Dim lcLoginMessage As String = ""

        DA = New DataAccessClass()
        DS = New DataSet()

        DS = DA.RegisterPlayer(lcPlayerName, lcPassword, lcEmail)
        For Each aRow As DataRow In DS.Tables(0).Rows
            lcLoginMessage = aRow("Message")
        Next

        If (lcLoginMessage = "REGISTRATION SUCCEEDED") Then
            DataAccessClass.playerName = Me.TxtUserName.Text
            MessageBox.Show("REGISTRATION SUCCEEDED")
            FrmLogin.Show()
            Me.Hide()
        Else
            MessageBox.Show("Registration Failed, Email already in use")
        End If
    End Sub
End Class
