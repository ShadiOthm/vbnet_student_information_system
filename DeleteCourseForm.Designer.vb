<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteCourseForm
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
        Me.TextBoxCourseID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonRemoveCourse = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxCourseID
        '
        Me.TextBoxCourseID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCourseID.Location = New System.Drawing.Point(197, 58)
        Me.TextBoxCourseID.Name = "TextBoxCourseID"
        Me.TextBoxCourseID.Size = New System.Drawing.Size(169, 26)
        Me.TextBoxCourseID.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter The Course ID:"
        '
        'ButtonRemoveCourse
        '
        Me.ButtonRemoveCourse.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.ButtonRemoveCourse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRemoveCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRemoveCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRemoveCourse.ForeColor = System.Drawing.Color.White
        Me.ButtonRemoveCourse.Location = New System.Drawing.Point(372, 55)
        Me.ButtonRemoveCourse.Name = "ButtonRemoveCourse"
        Me.ButtonRemoveCourse.Size = New System.Drawing.Size(123, 33)
        Me.ButtonRemoveCourse.TabIndex = 15
        Me.ButtonRemoveCourse.Text = "Remove"
        Me.ButtonRemoveCourse.UseVisualStyleBackColor = False
        '
        'DeleteCourseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(507, 157)
        Me.Controls.Add(Me.ButtonRemoveCourse)
        Me.Controls.Add(Me.TextBoxCourseID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DeleteCourseForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DeleteCourseForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxCourseID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonRemoveCourse As System.Windows.Forms.Button
End Class
