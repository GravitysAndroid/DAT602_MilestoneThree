<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGameConfirmation
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
        Me.BtnJoin = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.LblJoin = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnJoin
        '
        Me.BtnJoin.Location = New System.Drawing.Point(13, 122)
        Me.BtnJoin.Name = "BtnJoin"
        Me.BtnJoin.Size = New System.Drawing.Size(75, 23)
        Me.BtnJoin.TabIndex = 0
        Me.BtnJoin.Text = "Join"
        Me.BtnJoin.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(235, 122)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 1
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'LblJoin
        '
        Me.LblJoin.AutoSize = True
        Me.LblJoin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblJoin.Location = New System.Drawing.Point(94, 9)
        Me.LblJoin.Name = "LblJoin"
        Me.LblJoin.Size = New System.Drawing.Size(130, 15)
        Me.LblJoin.TabIndex = 2
        Me.LblJoin.Text = "Your game is ready to join"
        '
        'FrmGameConfirmation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 157)
        Me.Controls.Add(Me.LblJoin)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnJoin)
        Me.Name = "FrmGameConfirmation"
        Me.Text = "FrmGameConfirmation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnJoin As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents LblJoin As Label
End Class
