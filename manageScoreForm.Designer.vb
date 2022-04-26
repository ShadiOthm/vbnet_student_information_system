<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manageScoreForm
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
        Me.TextBoxStudentID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxCourse = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxScore = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxDescription = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonAddScore = New System.Windows.Forms.Button()
        Me.ButtonShowStudents = New System.Windows.Forms.Button()
        Me.ButtonShowScores = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonAvgScore = New System.Windows.Forms.Button()
        CType(Me.DataGridViewStudentsScore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewStudentsScore
        '
        Me.DataGridViewStudentsScore.AllowUserToAddRows = False
        Me.DataGridViewStudentsScore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewStudentsScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewStudentsScore.Location = New System.Drawing.Point(455, 69)
        Me.DataGridViewStudentsScore.Name = "DataGridViewStudentsScore"
        Me.DataGridViewStudentsScore.Size = New System.Drawing.Size(503, 388)
        Me.DataGridViewStudentsScore.TabIndex = 44
        '
        'ButtonRemoveScore
        '
        Me.ButtonRemoveScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.ButtonRemoveScore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRemoveScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRemoveScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRemoveScore.ForeColor = System.Drawing.Color.White
        Me.ButtonRemoveScore.Location = New System.Drawing.Point(177, 309)
        Me.ButtonRemoveScore.Name = "ButtonRemoveScore"
        Me.ButtonRemoveScore.Size = New System.Drawing.Size(131, 40)
        Me.ButtonRemoveScore.TabIndex = 43
        Me.ButtonRemoveScore.Text = "Remove"
        Me.ButtonRemoveScore.UseVisualStyleBackColor = False
        '
        'TextBoxStudentID
        '
        Me.TextBoxStudentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxStudentID.Location = New System.Drawing.Point(164, 29)
        Me.TextBoxStudentID.Name = "TextBoxStudentID"
        Me.TextBoxStudentID.ReadOnly = True
        Me.TextBoxStudentID.Size = New System.Drawing.Size(120, 26)
        Me.TextBoxStudentID.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(50, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 20)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Student ID:"
        '
        'ComboBoxCourse
        '
        Me.ComboBoxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxCourse.FormattingEnabled = True
        Me.ComboBoxCourse.Location = New System.Drawing.Point(164, 77)
        Me.ComboBoxCourse.Name = "ComboBoxCourse"
        Me.ComboBoxCourse.Size = New System.Drawing.Size(238, 28)
        Me.ComboBoxCourse.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(26, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 20)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Select Course:"
        '
        'TextBoxScore
        '
        Me.TextBoxScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxScore.Location = New System.Drawing.Point(163, 126)
        Me.TextBoxScore.Name = "TextBoxScore"
        Me.TextBoxScore.Size = New System.Drawing.Size(121, 26)
        Me.TextBoxScore.TabIndex = 48
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(92, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 20)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Score:"
        '
        'TextBoxDescription
        '
        Me.TextBoxDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDescription.Location = New System.Drawing.Point(163, 176)
        Me.TextBoxDescription.Multiline = True
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.Size = New System.Drawing.Size(237, 80)
        Me.TextBoxDescription.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(45, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 20)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Description:"
        '
        'ButtonAddScore
        '
        Me.ButtonAddScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.ButtonAddScore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAddScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAddScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddScore.ForeColor = System.Drawing.Color.White
        Me.ButtonAddScore.Location = New System.Drawing.Point(34, 309)
        Me.ButtonAddScore.Name = "ButtonAddScore"
        Me.ButtonAddScore.Size = New System.Drawing.Size(123, 40)
        Me.ButtonAddScore.TabIndex = 53
        Me.ButtonAddScore.Text = "Add"
        Me.ButtonAddScore.UseVisualStyleBackColor = False
        '
        'ButtonShowStudents
        '
        Me.ButtonShowStudents.Location = New System.Drawing.Point(455, 32)
        Me.ButtonShowStudents.Name = "ButtonShowStudents"
        Me.ButtonShowStudents.Size = New System.Drawing.Size(233, 26)
        Me.ButtonShowStudents.TabIndex = 54
        Me.ButtonShowStudents.Text = "Show Students"
        Me.ButtonShowStudents.UseVisualStyleBackColor = True
        '
        'ButtonShowScores
        '
        Me.ButtonShowScores.Location = New System.Drawing.Point(725, 30)
        Me.ButtonShowScores.Name = "ButtonShowScores"
        Me.ButtonShowScores.Size = New System.Drawing.Size(233, 26)
        Me.ButtonShowScores.TabIndex = 55
        Me.ButtonShowScores.Text = "Show Scores"
        Me.ButtonShowScores.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 460)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(450, 16)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "* to edit a score you have to delete it and RE add it with the values you want"
        '
        'ButtonAvgScore
        '
        Me.ButtonAvgScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonAvgScore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAvgScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAvgScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAvgScore.ForeColor = System.Drawing.Color.White
        Me.ButtonAvgScore.Location = New System.Drawing.Point(34, 375)
        Me.ButtonAvgScore.Name = "ButtonAvgScore"
        Me.ButtonAvgScore.Size = New System.Drawing.Size(274, 40)
        Me.ButtonAvgScore.TabIndex = 57
        Me.ButtonAvgScore.Text = "Average Score By Course"
        Me.ButtonAvgScore.UseVisualStyleBackColor = False
        '
        'manageScoreForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(970, 492)
        Me.Controls.Add(Me.ButtonAvgScore)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ButtonShowScores)
        Me.Controls.Add(Me.ButtonShowStudents)
        Me.Controls.Add(Me.ButtonAddScore)
        Me.Controls.Add(Me.TextBoxStudentID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBoxCourse)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxScore)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxDescription)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridViewStudentsScore)
        Me.Controls.Add(Me.ButtonRemoveScore)
        Me.Name = "manageScoreForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "manageScoreForm"
        CType(Me.DataGridViewStudentsScore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewStudentsScore As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonRemoveScore As System.Windows.Forms.Button
    Friend WithEvents TextBoxStudentID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxCourse As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxScore As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ButtonAddScore As System.Windows.Forms.Button
    Friend WithEvents ButtonShowStudents As System.Windows.Forms.Button
    Friend WithEvents ButtonShowScores As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ButtonAvgScore As System.Windows.Forms.Button
End Class
