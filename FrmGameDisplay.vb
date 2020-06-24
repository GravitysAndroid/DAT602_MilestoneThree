Imports System.Configuration
Imports Org.BouncyCastle.Crypto.Engines
Public Class FrmGameDisplay
    Dim lcPictureBoxes(3, 3) As PictureBox

    Private Sub putPictureBoxesIntoAnArray()
        Dim cControl As Control
        Dim row As Integer
        Dim column As Integer

        row = 1
        column = 1
        For Each cControl In Me.Controls
            If (TypeOf cControl Is PictureBox) Then
                lcPictureBoxes(row, column) = cControl
                column = column + 1
                If column > 3 Then
                    column = 1
                    row = row + 1
                    If row > 3 Then
                        Exit For
                    End If

                End If
            End If
        Next cControl
    End Sub

    Private Sub DrawCurrentPlayers()
        Dim da As DataAccessClass
        Dim ds As DataSet
        da = New DataAccessClass

        ds = da.GetAllPlayers()
        For Each row In ds.Tables(0).Rows
            DrawPlayerAt(row("PlayerName"), row("Row"), row("Column"))
        Next
    End Sub

    Private Sub DrawPlayerAt(pName As String, pRow As Integer, pColumn As Integer)
        Dim aPicture As PictureBox
        aPicture = lcPictureBoxes(pRow, pColumn)

        If (pName = "John") Then
            'FOR LAPTOP
            'aPicture.Image = Image.FromFile("C:\Users\hayde\source\repos\DAT602_MilestoneThree\Resources\Archer.jpg")

            'FOR PC
            aPicture.Image = Image.FromFile("C:\Users\Hayden Williams\source\repos\DAT602_MilestoneThree\Resources\Archer.jpg")
        ElseIf (pName = "Jim") Then
            'FOR LAPTOP
            'aPicture.Image = Image.FromFile("C:\Users\hayde\source\repos\DAT602_MilestoneThree\Resources\Mage.png")

            'FOR PC
            aPicture.Image = Image.FromFile("C:\Users\Hayden Williams\source\repos\DAT602_MilestoneThree\Resources\Mage.png")
        Else
            'default image
        End If

    End Sub

    Private Sub FrmGameDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        putPictureBoxesIntoAnArray()
        DrawCurrentPlayers()
    End Sub

    Private Sub BtnMove_Click(sender As Object, e As EventArgs) Handles BtnMove.Click
        Dim DA As DataAccessClass
        Dim DS As DataSet
        Dim lcPlayerID As Integer
        Dim lcRow As Integer
        Dim lcColumn As Integer
        Dim lcMoveMessage As String = ""

        DA = New DataAccessClass()
        DS = New DataSet()

        lcRow = lcRow + 1
        lcColumn = lcColumn + 1
        lcPlayerID = DataAccessClass.PlayerID

        DS = DA.Move(lcPlayerID, lcRow, lcColumn)

        For Each aRow As DataRow In DS.Tables(0).Rows
            lcMoveMessage = aRow("Message")
        Next

        If (lcMoveMessage = "Player Moved") Then
            MessageBox.Show("Player Moved")
            putPictureBoxesIntoAnArray()
            DrawCurrentPlayers()
        Else
            MessageBox.Show("Move Failed")
        End If
    End Sub
End Class
