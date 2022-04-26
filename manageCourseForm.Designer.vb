<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manageCourseForm
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
        Me.ButtonAddCourse = New System.Windows.Forms.Button()
        Me.TextBoxDescription = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumericUpDownHours = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxCourseName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListBoxCourses = New System.Windows.Forms.ListBox()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonRemove = New System.Windows.Forms.Button()
        Me.ButtonPrevious = New System.Windows.Forms.Button()
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.ButtonFirst = New System.Windows.Forms.Button()
        Me.ButtonLast = New System.Windows.Forms.Button()
        Me.LabelTotalCourses = New System.Windows.Forms.Label()
        CType(Me.NumericUpDownHours, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonAddCourse
        '
        Me.ButtonAddCourse.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.ButtonAddCourse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAddCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddCourse.ForeColor = System.Drawing.Color.White
        Me.ButtonAddCourse.Location = New System.Drawing.Point(64, 352)
        Me.ButtonAddCourse.Name = "ButtonAddCourse"
        Me.ButtonAddCourse.Size = New System.Drawing.Size(96, 40)
        Me.ButtonAddCourse.TabIndex = 21
        Me.ButtonAddCourse.Text = "Add"
        Me.ButtonAddCourse.UseVisualStyleBackColor = False
        '
        'TextBoxDescription
        '
        Me.TextBoxDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDescription.Location = New System.Drawing.Point(155, 165)
        Me.TextBoxDescription.Multiline = True
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.Size = New System.Drawing.Size(237, 80)
        Me.TextBoxDescription.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(37, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 20)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Description:"
        '
        'NumericUpDownHours
        '
        Me.NumericUpDownHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDownHours.Location = New System.Drawing.Point(155, 116)
        Me.NumericUpDownHours.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDownHours.Name = "NumericUpDownHours"
        Me.NumericUpDownHours.Size = New System.Drawing.Size(120, 26)
        Me.NumericUpDownHours.TabIndex = 18
        Me.NumericUpDownHours.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Hours Number:"
        '
        'TextBoxCourseName
        '
        Me.TextBoxCourseName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCourseName.Location = New System.Drawing.Point(155, 68)
        Me.TextBoxCourseName.Name = "TextBoxCourseName"
        Me.TextBoxCourseName.Size = New System.Drawing.Size(237, 26)
        Me.TextBoxCourseName.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(84, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Label:"
        '
        'TextBoxID
        '
        Me.TextBoxID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxID.Location = New System.Drawing.Point(155, 21)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(120, 26)
        Me.TextBoxID.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(109, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 20)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "ID:"
        '
        'ListBoxCourses
        '
        Me.ListBoxCourses.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxCourses.FormattingEnabled = True
        Me.ListBoxCourses.ItemHeight = 25
        Me.ListBoxCourses.Location = New System.Drawing.Point(490, 24)
        Me.ListBoxCourses.Name = "ListBoxCourses"
        Me.ListBoxCourses.Size = New System.Drawing.Size(327, 354)
        Me.ListBoxCourses.TabIndex = 24
        '
        'ButtonEdit
        '
        Me.ButtonEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.ButtonEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEdit.ForeColor = System.Drawing.Color.White
        Me.ButtonEdit.Location = New System.Drawing.Point(179, 352)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(96, 40)
        Me.ButtonEdit.TabIndex = 25
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = False
        '
        'ButtonRemove
        '
        Me.ButtonRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.ButtonRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRemove.ForeColor = System.Drawing.Color.White
        Me.ButtonRemove.Location = New System.Drawing.Point(296, 352)
        Me.ButtonRemove.Name = "ButtonRemove"
        Me.ButtonRemove.Size = New System.Drawing.Size(96, 40)
        Me.ButtonRemove.TabIndex = 26
        Me.ButtonRemove.Text = "Remove"
        Me.ButtonRemove.UseVisualStyleBackColor = False
        '
        'ButtonPrevious
        '
        Me.ButtonPrevious.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ButtonPrevious.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonPrevious.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPrevious.ForeColor = System.Drawing.Color.Black
        Me.ButtonPrevious.Location = New System.Drawing.Point(246, 272)
        Me.ButtonPrevious.Name = "ButtonPrevious"
        Me.ButtonPrevious.Size = New System.Drawing.Size(96, 40)
        Me.ButtonPrevious.TabIndex = 29
        Me.ButtonPrevious.Tag = ""
        Me.ButtonPrevious.Text = "<"
        Me.ButtonPrevious.UseVisualStyleBackColor = False
        '
        'ButtonNext
        '
        Me.ButtonNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ButtonNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonNext.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNext.ForeColor = System.Drawing.Color.Black
        Me.ButtonNext.Location = New System.Drawing.Point(129, 272)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(96, 40)
        Me.ButtonNext.TabIndex = 28
        Me.ButtonNext.Text = ">"
        Me.ButtonNext.UseVisualStyleBackColor = False
        '
        'ButtonFirst
        '
        Me.ButtonFirst.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ButtonFirst.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonFirst.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFirst.ForeColor = System.Drawing.Color.Black
        Me.ButtonFirst.Location = New System.Drawing.Point(14, 272)
        Me.ButtonFirst.Name = "ButtonFirst"
        Me.ButtonFirst.Size = New System.Drawing.Size(96, 40)
        Me.ButtonFirst.TabIndex = 27
        Me.ButtonFirst.Text = "<<"
        Me.ButtonFirst.UseVisualStyleBackColor = False
        '
        'ButtonLast
        '
        Me.ButtonLast.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ButtonLast.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonLast.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLast.ForeColor = System.Drawing.Color.Black
        Me.ButtonLast.Location = New System.Drawing.Point(363, 272)
        Me.ButtonLast.Name = "ButtonLast"
        Me.ButtonLast.Size = New System.Drawing.Size(96, 40)
        Me.ButtonLast.TabIndex = 30
        Me.ButtonLast.Text = ">>"
        Me.ButtonLast.UseVisualStyleBackColor = False
        '
        'LabelTotalCourses
        '
        Me.LabelTotalCourses.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.LabelTotalCourses.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalCourses.ForeColor = System.Drawing.Color.White
        Me.LabelTotalCourses.Location = New System.Drawing.Point(604, 381)
        Me.LabelTotalCourses.Name = "LabelTotalCourses"
        Me.LabelTotalCourses.Size = New System.Drawing.Size(213, 40)
        Me.LabelTotalCourses.TabIndex = 40
        Me.LabelTotalCourses.Text = "Total Courses:"
        Me.LabelTotalCourses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'manageCourseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(829, 482)
        Me.Controls.Add(Me.LabelTotalCourses)
        Me.Controls.Add(Me.ButtonLast)
        Me.Controls.Add(Me.ButtonPrevious)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.ButtonFirst)
        Me.Controls.Add(Me.ButtonRemove)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.ListBoxCourses)
        Me.Controls.Add(Me.TextBoxID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ButtonAddCourse)
        Me.Controls.Add(Me.TextBoxDescription)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NumericUpDownHours)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxCourseName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "manageCourseForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "manageCourseForm"
        CType(Me.NumericUpDownHours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonAddCourse As System.Windows.Forms.Button
    Friend WithEvents TextBoxDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownHours As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCourseName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ListBoxCourses As System.Windows.Forms.ListBox
    Friend WithEvents ButtonEdit As System.Windows.Forms.Button
    Friend WithEvents ButtonRemove As System.Windows.Forms.Button
    Friend WithEvents ButtonPrevious As System.Windows.Forms.Button
    Friend WithEvents ButtonNext As System.Windows.Forms.Button
    Friend WithEvents ButtonFirst As System.Windows.Forms.Button
    Friend WithEvents ButtonLast As System.Windows.Forms.Button
    Friend WithEvents LabelTotalCourses As System.Windows.Forms.Label
End Class
