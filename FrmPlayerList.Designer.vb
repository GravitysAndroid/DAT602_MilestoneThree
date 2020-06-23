<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPlayerList
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
        Me.MySqlDataAdapter1 = New MySql.Data.MySqlClient.MySqlDataAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PlayerNameLabel = New System.Windows.Forms.Label()
        Me.BtnAdminPanel = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnJoin
        '
        Me.BtnJoin.Location = New System.Drawing.Point(12, 226)
        Me.BtnJoin.Name = "BtnJoin"
        Me.BtnJoin.Size = New System.Drawing.Size(75, 23)
        Me.BtnJoin.TabIndex = 1
        Me.BtnJoin.Text = "Join"
        Me.BtnJoin.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(284, 225)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 3
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'MySqlDataAdapter1
        '
        Me.MySqlDataAdapter1.DeleteCommand = Nothing
        Me.MySqlDataAdapter1.InsertCommand = Nothing
        Me.MySqlDataAdapter1.SelectCommand = Nothing
        Me.MySqlDataAdapter1.UpdateCommand = Nothing
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(347, 207)
        Me.DataGridView1.TabIndex = 4
        '
        'PlayerNameLabel
        '
        Me.PlayerNameLabel.AutoSize = True
        Me.PlayerNameLabel.Location = New System.Drawing.Point(93, 231)
        Me.PlayerNameLabel.Name = "PlayerNameLabel"
        Me.PlayerNameLabel.Size = New System.Drawing.Size(67, 13)
        Me.PlayerNameLabel.TabIndex = 5
        Me.PlayerNameLabel.Text = "Player Name"
        '
        'BtnAdminPanel
        '
        Me.BtnAdminPanel.Location = New System.Drawing.Point(203, 225)
        Me.BtnAdminPanel.Name = "BtnAdminPanel"
        Me.BtnAdminPanel.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdminPanel.TabIndex = 6
        Me.BtnAdminPanel.Text = "Admin Panel"
        Me.BtnAdminPanel.UseVisualStyleBackColor = True
        '
        'FrmPlayerList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 254)
        Me.Controls.Add(Me.BtnAdminPanel)
        Me.Controls.Add(Me.PlayerNameLabel)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnJoin)
        Me.Name = "FrmPlayerList"
        Me.Text = "FrmPlayerList"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnJoin As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents MySqlDataAdapter1 As MySql.Data.MySqlClient.MySqlDataAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PlayerNameLabel As Label
    Friend WithEvents BtnAdminPanel As Button
End Class
