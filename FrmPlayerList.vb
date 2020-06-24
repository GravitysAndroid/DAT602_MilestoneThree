Public Class FrmPlayerList
    Private mPlayerEditID As String
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick,
    DataGridView1.CellDoubleClick, DataGridView1.CellContentDoubleClick
        mPlayerEditID = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        'mPlayerEditID = DataGridView1.SelectedCells(0).Value
        DataAccessClass.playerEditName = mPlayerEditID
        Debug.Print(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
    End Sub

    Private Sub ShowCurrentPlayers()
        Dim da As DataAccessClass
        Dim ds As DataSet
        Dim lcPlayers As List(Of MoveClass)
        Dim lcPlayer As MoveClass
        lcPlayers = New List(Of MoveClass)

        da = New DataAccessClass()

        ds = da.GetAllPlayers()
        For Each row In ds.Tables(0).Rows
            lcPlayer = New MoveClass()
            With lcPlayer
                .PlayerName = row("PlayerName")
                .Row = row("Row")
                .Column = row("Column")
            End With
            lcPlayers.Add(lcPlayer)
        Next
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = lcPlayers
    End Sub

    Private Sub FrmPlayerList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PlayerNameLabel.Text = DataAccessClass.playerName
        ShowCurrentPlayers()
    End Sub

    Private Sub BtnAdminPanel_Click(sender As Object, e As EventArgs) Handles BtnAdminPanel.Click
        FrmAdminWindow.Show()
    End Sub

    Private Sub BtnJoin_Click(sender As Object, e As EventArgs) Handles BtnJoin.Click
        Dim DA As DataAccessClass
        Dim DS As DataSet
        Dim lcLoginMessage As String = ""
        Dim lcPlayerID As Int32
        Dim lcGameID As Int32

        DA = New DataAccessClass()
        DS = New DataSet()

        DS = DA.GameConfirmation(lcPlayerID, lcGameID)

        For Each aRow As DataRow In DS.Tables(0).Rows
            lcLoginMessage = aRow("Message")
        Next

        If (lcLoginMessage = "Game Confirmed") Then
            'DataAccessClass.playerName = lcPlayerID
            MessageBox.Show("Game Confirmed")
            FrmGameDisplay.Show()
            Me.Hide()
        Else
            MessageBox.Show("Game Failed To Join")
        End If
    End Sub
End Class
