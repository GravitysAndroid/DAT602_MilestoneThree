Public Class FrmGameConfirmation
    Dim DA As DataAccessClass
    Dim DS As DataSet

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        FrmPlayerList.Show()
        Me.Close()
    End Sub

    Private Sub BtnJoin_Click(sender As Object, e As EventArgs) Handles BtnJoin.Click
        DA = New DataAccessClass()
        DS = New DataSet()
        Dim lcLoginMessage As String = ""
        Dim lcPlayerID As Int32
        Dim lcGameID As Int32

        DS = DA.GameConfirmation(lcPlayerID, lcGameID)

        For Each aRow As DataRow In DS.Tables(0).Rows
            lcLoginMessage = aRow("Message")
        Next

        If (lcLoginMessage = "Game Confirmed") Then
            'DataAccessClass.playerName = Me.TxtUsername.Text
            MessageBox.Show("Game Confirmed")
            FrmPlayerList.Show()
            Me.Hide()
        Else
            MessageBox.Show("Game Failed To Join")
            FrmRegister.Show()
            Me.Hide()
        End If

    End Sub
End Class