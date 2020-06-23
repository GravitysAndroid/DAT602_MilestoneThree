Public Class FrmAdminWindow
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim DA As DataAccessClass
        Dim DS As DataSet
        Dim lcDeleteGame As String = TxtDeleteGame.Text
        Dim lcLoginMessage As String = ""

        DA = New DataAccessClass()
        DS = New DataSet()

        DS = DA.AdminDeleteGame(lcDeleteGame)
        For Each aRow As DataRow In DS.Tables(0).Rows
            lcLoginMessage = aRow("Message")
        Next
        If (lcLoginMessage = "Game Successfully Deleted") Then
            DataAccessClass.GameID = Me.TxtDeleteGame.Text
            MessageBox.Show("Game Successfully Deleted")
        Else
            MessageBox.Show("Deletion Failed")
        End If

    End Sub

    Private Sub BtnDeletePlayer_Click(sender As Object, e As EventArgs) Handles BtnDeletePlayer.Click

    End Sub

    Private Sub BtnUpdatePlayer_Click(sender As Object, e As EventArgs) Handles BtnUpdatePlayer.Click

    End Sub

    Private Sub BtnCreatePlayer_Click(sender As Object, e As EventArgs) Handles BtnCreatePlayer.Click

    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        Me.Close()
    End Sub
End Class