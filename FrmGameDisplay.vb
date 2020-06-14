Public Class FrmGameDisplay

    Private Sub DrawCurrentPlayers()
        Dim da As DataAccessClass
        Dim ds As DataSet
        da = New DataAccessClass

        ds = da.GetAllPlayers()
        For Each row In ds.Tables(0).Rows

        Next
    End Sub

    Private Sub DrawPlayerAt(pName As String, )

    End Sub
    Private Sub FrmGameDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DrawCurrentPlayers()
    End Sub
End Class