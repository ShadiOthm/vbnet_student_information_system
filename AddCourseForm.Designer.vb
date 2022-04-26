<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCourseForm
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
        Me.TextBoxCourseName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDownHours = New System.Windows.Forms.NumericUpDown()
        Me.TextBoxDescription = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonAddCourse = New System.Windows.Forms.Button()
        CType(Me.NumericUpDownHours, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxCourseName
        '
        Me.TextBoxCourseName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCourseName.Location = New System.Drawing.Point(154, 36)
        Me.TextBoxCourseName.Name = "TextBoxCourseName"
        Me.TextBoxCourseName.Size = New System.Drawing.Size(237, 26)
        Me.TextBoxCourseName.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(83, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Hours Number:"
        '
        'NumericUpDownHours
        '
        Me.NumericUpDownHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDownHours.Location = New System.Drawing.Point(154, 93)
        Me.NumericUpDownHours.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDownHours.Name = "NumericUpDownHours"
        Me.NumericUpDownHours.Size = New System.Drawing.Size(120, 26)
        Me.NumericUpDownHours.TabIndex = 5
        Me.NumericUpDownHours.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'TextBoxDescription
        '
        Me.TextBoxDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDescription.Location = New System.Drawing.Point(154, 149)
        Me.TextBoxDescription.Multiline = True
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.Size = New System.Drawing.Size(237, 80)
        Me.TextBoxDescription.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(36, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Description:"
        '
        'ButtonAddCourse
        '
        Me.ButtonAddCourse.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.ButtonAddCourse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAddCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddCourse.ForeColor = System.Drawing.Color.White
        Me.ButtonAddCourse.Location = New System.Drawing.Point(63, 260)
        Me.ButtonAddCourse.Name = "ButtonAddCourse"
        Me.ButtonAddCourse.Size = New System.Drawing.Size(276, 40)
        Me.ButtonAddCourse.TabIndex = 14
        Me.ButtonAddCourse.Text = "Add"
        Me.ButtonAddCourse.UseVisualStyleBackColor = False
        '
        'AddCourseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(403, 330)
        Me.Controls.Add(Me.ButtonAddCourse)
        Me.Controls.Add(Me.TextBoxDescription)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NumericUpDownHours)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxCourseName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddCourseForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddCourseForm"
        CType(Me.NumericUpDownHours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxCourseName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownHours As System.Windows.Forms.NumericUpDown
    Friend WithEvents TextBoxDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ButtonAddCourse As System.Windows.Forms.Button
End Class
