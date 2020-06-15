Imports System.Configuration
Imports Org.BouncyCastle.Crypto.Engines

Public Class FrmGameDisplay
    Dim lcPictureBoxes(3, 3)


    Private Sub PicturesToArray()

    End Sub
    Private Sub DrawCurrentPlayers()
        Dim da As DataAccessClass
        Dim ds As DataSet
        da = New DataAccessClass
        Dim row As Integer
        Dim col As Integer


        ds = da.GetAllPlayers()
        For Each row In ds.Tables(0).Rows
            DrawPlayerAt(row("NAME"), row("ROW"), row("COLUMN"))
        Next
    End Sub

    Private Sub DrawPlayerAt(pName As String, pRow As Integer, pCol As Integer)

        Dim aPicture As PictureBox
        aPicture = lcPictureBoxes(pRow, pCol)
        If (pName = John) Then
            aPicture.Image = Image.FromFile("c:\")
        ElseIf (pName = Jim) Then
            aPicture.Image = Image.FromFile("c:\")
        Else
            'default image
        End If

    End Sub

    Private Sub FrmGameDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DrawCurrentPlayers()
    End Sub
End Class