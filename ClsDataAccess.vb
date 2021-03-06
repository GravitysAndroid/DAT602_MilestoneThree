﻿Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data
Imports MySql.Data.MySqlClient

Public Class DataAccessClass
    Dim connectionString As String = "Server=localhost;Port=3306;Database=hwdb;Uid=root;password=P@ssword1;"
    Dim mySqlConnection As MySqlConnection = New MySqlConnection(connectionString)
    Public Shared playerName As String
    Public Shared playerEditName As String
    Public Shared PlayerEmail As String
    Public Shared GameID As Integer
    Public Shared PlayerID As Integer

    'Player Self Delete
    Public Function PlayerSelfDelete(pPlayerID As Int32) As DataSet
        Dim p As List(Of MySqlParameter) = New List(Of MySqlParameter)()
        Dim aP As MySqlParameter = New MySqlParameter("@PlayerID", MySqlDbType.Int32)

        aP.Value = pPlayerID
        p.Add(aP)

        Dim aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "PlayerSelfDelete(@PlayerID)", p.ToArray())

        Return aDataSet
    End Function

    'Move
    Public Function Move(pPlayerID As Int32, pRow As Int32, pColumn As Int32) As DataSet
        Dim p As List(Of MySqlParameter) = New List(Of MySqlParameter)()
        Dim aPlayerID As MySqlParameter = New MySqlParameter("@PlayerID", MySqlDbType.Int32)
        Dim aRow As MySqlParameter = New MySqlParameter("@Row", MySqlDbType.Int32)
        Dim aColumn As MySqlParameter = New MySqlParameter("@Column", MySqlDbType.Int32)

        aPlayerID.Value = pPlayerID
        p.Add(aPlayerID)

        aRow.Value = pRow
        p.Add(aRow)

        aColumn.Value = pColumn
        p.Add(aColumn)

        Dim aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "call Move(@PlayerID,@Row, @Column)", p.ToArray())

        Return aDataSet
    End Function

    'Move Left
    Public Function MoveLeft(pPlayerID As Int32, pTileID As Int32) As DataSet
        Dim p As List(Of MySqlParameter) = New List(Of MySqlParameter)()
        Dim aPlayerID As MySqlParameter = New MySqlParameter("@PlayerID", MySqlDbType.Int32)
        Dim aTileID As MySqlParameter = New MySqlParameter("@TileID", MySqlDbType.Int32)

        aPlayerID.Value = pPlayerID
        p.Add(aPlayerID)

        aTileID.Value = pTileID
        p.Add(aTileID)

        Dim aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "Call MoveLeft(@PlayerID, @TileID)", p.ToArray())

        Return aDataSet
    End Function

    'Test Play
    Public Function TestPlay(pNumberOfPlayers As String) As DataSet
        Dim p As List(Of MySqlParameter) = New List(Of MySqlParameter)()
        Dim aP As MySqlParameter = New MySqlParameter("@NumberOfPlayers", MySqlDbType.VarChar, 50)

        aP.Value = pNumberOfPlayers
        p.Add(aP)

        Dim aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "TestPlay(@NumberOfPlayers)", p.ToArray())

        Return aDataSet
    End Function

    'Add player Name
    Public Function AddPlayerName(pPlayerName As String, pPassword As String, pEmail As String) As DataSet
        Dim p As List(Of MySqlParameter) = New List(Of MySqlParameter)()
        Dim aPlayerName As MySqlParameter = New MySqlParameter("@PlayerName", MySqlDbType.VarChar, 25)
        Dim aPassword As MySqlParameter = New MySqlParameter("@Password", MySqlDbType.VarChar, 20)
        Dim aEmail As MySqlParameter = New MySqlParameter("@Email", MySqlDbType.VarChar, 30)

        aPlayerName.Value = pPlayerName
        p.Add(aPlayerName)

        aPassword.Value = pPassword
        p.Add(aPassword)

        aEmail.Value = pEmail
        p.Add(aEmail)

        Dim aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "Call AddPlayerName(@PlayerName, @Password, @Email)", p.ToArray())
        Return aDataSet
    End Function

    'Register Player
    Public Function RegisterPlayer(pPlayerName As String, pPassword As String, pEmail As String) As DataSet
        Dim p As List(Of MySqlParameter) = New List(Of MySqlParameter)()
        Dim aPlayerName As MySqlParameter = New MySqlParameter("@PlayerName", MySqlDbType.VarChar, 25)
        Dim aPassword As MySqlParameter = New MySqlParameter("@Password", MySqlDbType.VarChar, 20)
        Dim aEmail As MySqlParameter = New MySqlParameter("@Email", MySqlDbType.VarChar, 30)

        aPlayerName.Value = pPlayerName
        p.Add(aPlayerName)

        aPassword.Value = pPassword
        p.Add(aPassword)

        aEmail.Value = pEmail
        p.Add(aEmail)

        Dim aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "Call RegisterPlayer(@PlayerName, @Password, @Email)", p.ToArray())
        Return aDataSet
    End Function

    'Login
    Public Function Login(pPlayerName As String, pPassword As String) As DataSet
        Dim p As List(Of MySqlParameter) = New List(Of MySqlParameter)()
        Dim aPlayerName As MySqlParameter = New MySqlParameter("@PlayerName", MySqlDbType.VarChar, 25)
        Dim aPassword As MySqlParameter = New MySqlParameter("@Password", MySqlDbType.VarChar, 20)

        aPlayerName.Value = pPlayerName
        p.Add(aPlayerName)

        aPassword.Value = pPassword
        p.Add(aPassword)

        Dim aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "Call Login(@PlayerName, @Password)", p.ToArray())
        Return aDataSet
    End Function

    'Is Player In A Game
    Public Function IsPlayerInAGame(pGameID As Int32) As DataSet
        Dim p As List(Of MySqlParameter) = New List(Of MySqlParameter)()
        Dim aP As MySqlParameter = New MySqlParameter("@GameID", MySqlDbType.Int32)

        aP.Value = pGameID
        p.Add(aP)

        Dim aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "IsPlayerInAGame(@GameID)", p.ToArray())

        Return aDataSet
    End Function


    'Player Select Game
    Public Function PlayerSelectAGame(pPlayerID As Int32, pGameID As Int32) As DataSet
        Dim p As List(Of MySqlParameter) = New List(Of MySqlParameter)()
        Dim aPlayerID As MySqlParameter = New MySqlParameter("@PlayerID", MySqlDbType.Int32)
        Dim aGameID As MySqlParameter = New MySqlParameter("@GameID", MySqlDbType.Int32)

        aPlayerID.Value = pPlayerID
        p.Add(aPlayerID)

        aGameID.Value = pGameID
        p.Add(aGameID)

        Dim aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "call PlayerSelectAGame(@PlayerID, @GameID)", p.ToArray())

        Return aDataSet
    End Function


    'Game Confirmation
    Public Function GameConfirmation(pPlayerID As Int32, pGameID As Int32) As DataSet
        Dim p As List(Of MySqlParameter) = New List(Of MySqlParameter)()
        Dim aPlayerID As MySqlParameter = New MySqlParameter("@PlayerID", MySqlDbType.Int32)
        Dim aGameID As MySqlParameter = New MySqlParameter("@GameID", MySqlDbType.Int32)

        aPlayerID.Value = pPlayerID
        p.Add(aPlayerID)

        aGameID.Value = pGameID
        p.Add(aGameID)

        Dim aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "Call GameConfirmation(@PlayerID, @GameID)", p.ToArray())

        Return aDataSet
    End Function


    'Admin Delete Player
    Public Function AdminDeletePlayer(pPlayerID As Int32) As DataSet
        Dim p As List(Of MySqlParameter) = New List(Of MySqlParameter)()
        Dim aP As MySqlParameter = New MySqlParameter("@PlayerID", MySqlDbType.Int32)

        aP.Value = pPlayerID
        p.Add(aP)

        Dim aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "AdminDeletePlayer(@PlayerID)", p.ToArray())

        Return aDataSet
    End Function


    'Admin Update Password
    Public Function AdminUpdatePassword(pPlayerID As Int32, pPassword As String) As DataSet
        Dim p As List(Of MySqlParameter) = New List(Of MySqlParameter)()
        Dim aPlayerID As MySqlParameter = New MySqlParameter("@PlayerID", MySqlDbType.Int32)
        Dim aPassword As MySqlParameter = New MySqlParameter("@Password", MySqlDbType.VarChar, 20)

        aPlayerID.Value = pPlayerID
        p.Add(aPlayerID)

        aPassword.Value = pPassword
        p.Add(aPassword)

        Dim aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "Call AdminUpdatePassword(@PlayerID, @Password)", p.ToArray())

        Return aDataSet
    End Function


    'Admin New Player
    Public Function AdminNewPlayer(pPlayerName As String, pPassword As String, pEmail As String) As DataSet
        Dim p As List(Of MySqlParameter) = New List(Of MySqlParameter)()
        Dim aPlayerName As MySqlParameter = New MySqlParameter("@PlayerName", MySqlDbType.VarChar, 25)
        Dim aPassword As MySqlParameter = New MySqlParameter("@Password", MySqlDbType.VarChar, 20)
        Dim aEmail As MySqlParameter = New MySqlParameter("@Email", MySqlDbType.VarChar, 30)

        aPlayerName.Value = pPlayerName
        p.Add(aPlayerName)

        aPassword.Value = pPassword
        p.Add(aPassword)

        aEmail.Value = pEmail
        p.Add(aEmail)

        Dim aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "Call AdminNewPlayer(@PlayerName, @Password, @Email)", p.ToArray())

        Return aDataSet
    End Function


    'Admin Delete Game
    Public Function AdminDeleteGame(pGameID As Int32) As DataSet
        Dim p As List(Of MySqlParameter) = New List(Of MySqlParameter)()
        Dim aP As MySqlParameter = New MySqlParameter("@GameID", MySqlDbType.Int32)

        aP.Value = pGameID
        p.Add(aP)

        Dim aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "Call AdminDeleteGame(@GameID)", p.ToArray())

        Return aDataSet
    End Function

    Public Function GetAllPlayers() As DataSet
        Dim p As List(Of MySqlParameter) = New List(Of MySqlParameter)()

        Dim aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "Call GetAllPlayers()", p.ToArray())

        Return aDataSet
    End Function
End Class

Public Class MoveClass
    ' 	SELECT `NAME`, `ROW` , `COLUMN`
    Private _PlayerName As String
    Private _Row, _Column As Integer

    Public Property PlayerName As String
        Get
            Return _PlayerName
        End Get
        Set(value As String)
            _PlayerName = value
        End Set
    End Property

    Public Property Row As Integer
        Get
            Return _Row
        End Get
        Set(value As Integer)
            _Row = value
        End Set
    End Property

    Public Property Column As Integer
        Get
            Return _Column
        End Get
        Set(value As Integer)
            _Column = value
        End Set
    End Property
End Class