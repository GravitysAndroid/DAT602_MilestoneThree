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
        Dim lcPlayers As List(Of PlayerClass)
        Dim lcPlayer As PlayerClass
        lcPlayers = New List(Of PlayerClass)

        da = New DataAccessClass()

        ds = da.GetAllPlayers()
        For Each row In ds.Tables(0).Rows
            lcPlayer = New PlayerClass()
            With lcPlayer
                .Name = row("Name")
                .Row = row("Row")
                .Col = row("Column")
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
End Class
