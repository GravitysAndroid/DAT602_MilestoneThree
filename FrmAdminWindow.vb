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
        Dim DA As DataAccessClass
        Dim DS As DataSet
        Dim lcDeletePlayer As String = TxtDeletePlayer.Text
        Dim lcLoginMessage As String = ""

        DA = New DataAccessClass()
        DS = New DataSet()

        DS = DA.AdminDeleteGame(lcDeletePlayer)
        For Each aRow As DataRow In DS.Tables(0).Rows
            lcLoginMessage = aRow("Message")
        Next
        If (lcLoginMessage = "Player Successfully Deleted") Then
            DataAccessClass.PlayerID = Me.TxtDeletePlayer.Text
            MessageBox.Show("Player Successfully Deleted")
        Else
            MessageBox.Show("Player Was Not Able To Be Deleted")
        End If
    End Sub

    Private Sub BtnUpdatePlayer_Click(sender As Object, e As EventArgs) Handles BtnUpdatePlayer.Click
        Dim DA As DataAccessClass
        Dim DS As DataSet
        Dim lcUpdateFrom As String = TxtUpdateFrom.Text
        Dim lcUpdateTo As String = TxtUpdateTo.Text
        Dim lcLoginMessage As String = ""

        DA = New DataAccessClass()
        DS = New DataSet()

        DS = DA.AdminUpdatePassword(DataAccessClass.PlayerID, lcUpdateTo)
        For Each aRow As DataRow In DS.Tables(0).Rows
            lcLoginMessage = aRow("Message")
        Next
        If (lcLoginMessage = "Player Successfully Updated") Then
            MessageBox.Show("Player Successfully Updated")
        Else
            MessageBox.Show("Player Was Not Able To Be Updated")
        End If
    End Sub

    Private Sub BtnCreatePlayer_Click(sender As Object, e As EventArgs) Handles BtnCreatePlayer.Click
        FrmRegister.Show()
        Me.Hide()
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        Me.Close()
    End Sub
End Class