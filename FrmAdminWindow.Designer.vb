﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdminWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnDeletePlayer = New System.Windows.Forms.Button()
        Me.BtnUpdatePlayer = New System.Windows.Forms.Button()
        Me.BtnCreatePlayer = New System.Windows.Forms.Button()
        Me.TxtDeleteGame = New System.Windows.Forms.TextBox()
        Me.TxtDeletePlayer = New System.Windows.Forms.TextBox()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.TxtUpdateFrom = New System.Windows.Forms.TextBox()
        Me.TxtUpdateTo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(12, 12)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(114, 23)
        Me.BtnDelete.TabIndex = 4
        Me.BtnDelete.Text = "Delete a Game"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnDeletePlayer
        '
        Me.BtnDeletePlayer.Location = New System.Drawing.Point(12, 41)
        Me.BtnDeletePlayer.Name = "BtnDeletePlayer"
        Me.BtnDeletePlayer.Size = New System.Drawing.Size(114, 23)
        Me.BtnDeletePlayer.TabIndex = 5
        Me.BtnDeletePlayer.Text = "Delete a Player"
        Me.BtnDeletePlayer.UseVisualStyleBackColor = True
        '
        'BtnUpdatePlayer
        '
        Me.BtnUpdatePlayer.Location = New System.Drawing.Point(12, 70)
        Me.BtnUpdatePlayer.Name = "BtnUpdatePlayer"
        Me.BtnUpdatePlayer.Size = New System.Drawing.Size(114, 23)
        Me.BtnUpdatePlayer.TabIndex = 6
        Me.BtnUpdatePlayer.Text = "Update a Player"
        Me.BtnUpdatePlayer.UseVisualStyleBackColor = True
        '
        'BtnCreatePlayer
        '
        Me.BtnCreatePlayer.Location = New System.Drawing.Point(12, 99)
        Me.BtnCreatePlayer.Name = "BtnCreatePlayer"
        Me.BtnCreatePlayer.Size = New System.Drawing.Size(114, 23)
        Me.BtnCreatePlayer.TabIndex = 7
        Me.BtnCreatePlayer.Text = "Create a New Player"
        Me.BtnCreatePlayer.UseVisualStyleBackColor = True
        '
        'TxtDeleteGame
        '
        Me.TxtDeleteGame.Location = New System.Drawing.Point(133, 13)
        Me.TxtDeleteGame.Name = "TxtDeleteGame"
        Me.TxtDeleteGame.Size = New System.Drawing.Size(100, 20)
        Me.TxtDeleteGame.TabIndex = 8
        '
        'TxtDeletePlayer
        '
        Me.TxtDeletePlayer.Location = New System.Drawing.Point(133, 43)
        Me.TxtDeletePlayer.Name = "TxtDeletePlayer"
        Me.TxtDeletePlayer.Size = New System.Drawing.Size(100, 20)
        Me.TxtDeletePlayer.TabIndex = 9
        '
        'BtnOK
        '
        Me.BtnOK.Location = New System.Drawing.Point(13, 162)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(75, 23)
        Me.BtnOK.TabIndex = 12
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'TxtUpdateFrom
        '
        Me.TxtUpdateFrom.Location = New System.Drawing.Point(133, 72)
        Me.TxtUpdateFrom.Name = "TxtUpdateFrom"
        Me.TxtUpdateFrom.Size = New System.Drawing.Size(100, 20)
        Me.TxtUpdateFrom.TabIndex = 13
        '
        'TxtUpdateTo
        '
        Me.TxtUpdateTo.Location = New System.Drawing.Point(240, 71)
        Me.TxtUpdateTo.Name = "TxtUpdateTo"
        Me.TxtUpdateTo.Size = New System.Drawing.Size(100, 20)
        Me.TxtUpdateTo.TabIndex = 14
        '
        'FrmAdminWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 197)
        Me.Controls.Add(Me.TxtUpdateTo)
        Me.Controls.Add(Me.TxtUpdateFrom)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.TxtDeletePlayer)
        Me.Controls.Add(Me.TxtDeleteGame)
        Me.Controls.Add(Me.BtnCreatePlayer)
        Me.Controls.Add(Me.BtnUpdatePlayer)
        Me.Controls.Add(Me.BtnDeletePlayer)
        Me.Controls.Add(Me.BtnDelete)
        Me.Name = "FrmAdminWindow"
        Me.Text = "FrmAdminWindow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnDeletePlayer As Button
    Friend WithEvents BtnUpdatePlayer As Button
    Friend WithEvents BtnCreatePlayer As Button
    Friend WithEvents TxtDeleteGame As TextBox
    Friend WithEvents TxtDeletePlayer As TextBox
    Friend WithEvents BtnOK As Button
    Friend WithEvents TxtUpdateFrom As TextBox
    Friend WithEvents TxtUpdateTo As TextBox
End Class
