<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class removeScoreForm
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
        Me.DataGridViewStudentsScore = New System.Windows.Forms.DataGridView()
        Me.ButtonRemoveScore = New System.Windows.Forms.Button()
        CType(Me.DataGridViewStudentsScore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewStudentsScore
        '
        Me.DataGridViewStudentsScore.AllowUserToAddRows = False
        Me.DataGridViewStudentsScore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewStudentsScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewStudentsScore.Location = New System.Drawing.Point(21, 12)
        Me.DataGridViewStudentsScore.Name = "DataGridViewStudentsScore"
        Me.DataGridViewStudentsScore.Size = New System.Drawing.Size(584, 295)
        Me.DataGridViewStudentsScore.TabIndex = 42
        '
        'ButtonRemoveScore
        '
        Me.ButtonRemoveScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.ButtonRemoveScore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRemoveScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRemoveScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRemoveScore.ForeColor = System.Drawing.Color.White
        Me.ButtonRemoveScore.Location = New System.Drawing.Point(21, 313)
        Me.ButtonRemoveScore.Name = "ButtonRemoveScore"
        Me.ButtonRemoveScore.Size = New System.Drawing.Size(584, 40)
        Me.ButtonRemoveScore.TabIndex = 39
        Me.ButtonRemoveScore.Text = "Remove Score"
        Me.ButtonRemoveScore.UseVisualStyleBackColor = False
        '
        'removeScoreForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(617, 378)
        Me.Controls.Add(Me.DataGridViewStudentsScore)
        Me.Controls.Add(Me.ButtonRemoveScore)
        Me.Name = "removeScoreForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "removeScoreForm"
        CType(Me.DataGridViewStudentsScore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewStudentsScore As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonRemoveScore As System.Windows.Forms.Button
End Class
