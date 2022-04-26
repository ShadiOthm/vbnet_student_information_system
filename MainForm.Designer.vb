<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.STUDENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentsListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaticsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditDeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageStudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COURSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddCourseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveCourseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditCourseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageCoursesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SCOREToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddScoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveScoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageScoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvgScoreByCourseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.STUDENTToolStripMenuItem, Me.COURSToolStripMenuItem, Me.SCOREToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(806, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'STUDENTToolStripMenuItem
        '
        Me.STUDENTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewStudentToolStripMenuItem, Me.StudentsListToolStripMenuItem, Me.StaticsToolStripMenuItem, Me.EditDeleteToolStripMenuItem, Me.ManageStudentsToolStripMenuItem})
        Me.STUDENTToolStripMenuItem.Name = "STUDENTToolStripMenuItem"
        Me.STUDENTToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.STUDENTToolStripMenuItem.Text = "STUDENT"
        '
        'AddNewStudentToolStripMenuItem
        '
        Me.AddNewStudentToolStripMenuItem.Name = "AddNewStudentToolStripMenuItem"
        Me.AddNewStudentToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.AddNewStudentToolStripMenuItem.Text = "Add New Student"
        '
        'StudentsListToolStripMenuItem
        '
        Me.StudentsListToolStripMenuItem.Name = "StudentsListToolStripMenuItem"
        Me.StudentsListToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.StudentsListToolStripMenuItem.Text = "Students List"
        '
        'StaticsToolStripMenuItem
        '
        Me.StaticsToolStripMenuItem.Name = "StaticsToolStripMenuItem"
        Me.StaticsToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.StaticsToolStripMenuItem.Text = "Statics"
        '
        'EditDeleteToolStripMenuItem
        '
        Me.EditDeleteToolStripMenuItem.Name = "EditDeleteToolStripMenuItem"
        Me.EditDeleteToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.EditDeleteToolStripMenuItem.Text = "Edit / Delete"
        '
        'ManageStudentsToolStripMenuItem
        '
        Me.ManageStudentsToolStripMenuItem.Name = "ManageStudentsToolStripMenuItem"
        Me.ManageStudentsToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ManageStudentsToolStripMenuItem.Text = "Manage Students"
        '
        'COURSToolStripMenuItem
        '
        Me.COURSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddCourseToolStripMenuItem, Me.RemoveCourseToolStripMenuItem, Me.EditCourseToolStripMenuItem, Me.ManageCoursesToolStripMenuItem})
        Me.COURSToolStripMenuItem.Name = "COURSToolStripMenuItem"
        Me.COURSToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.COURSToolStripMenuItem.Text = "COURSE"
        '
        'AddCourseToolStripMenuItem
        '
        Me.AddCourseToolStripMenuItem.Name = "AddCourseToolStripMenuItem"
        Me.AddCourseToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.AddCourseToolStripMenuItem.Text = "Add Course"
        '
        'RemoveCourseToolStripMenuItem
        '
        Me.RemoveCourseToolStripMenuItem.Name = "RemoveCourseToolStripMenuItem"
        Me.RemoveCourseToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.RemoveCourseToolStripMenuItem.Text = "Remove Course"
        '
        'EditCourseToolStripMenuItem
        '
        Me.EditCourseToolStripMenuItem.Name = "EditCourseToolStripMenuItem"
        Me.EditCourseToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.EditCourseToolStripMenuItem.Text = "Edit Course"
        '
        'ManageCoursesToolStripMenuItem
        '
        Me.ManageCoursesToolStripMenuItem.Name = "ManageCoursesToolStripMenuItem"
        Me.ManageCoursesToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ManageCoursesToolStripMenuItem.Text = "Manage Courses"
        '
        'SCOREToolStripMenuItem
        '
        Me.SCOREToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddScoreToolStripMenuItem, Me.RemoveScoreToolStripMenuItem, Me.ManageScoreToolStripMenuItem, Me.AvgScoreByCourseToolStripMenuItem})
        Me.SCOREToolStripMenuItem.Name = "SCOREToolStripMenuItem"
        Me.SCOREToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.SCOREToolStripMenuItem.Text = "SCORE"
        '
        'AddScoreToolStripMenuItem
        '
        Me.AddScoreToolStripMenuItem.Name = "AddScoreToolStripMenuItem"
        Me.AddScoreToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.AddScoreToolStripMenuItem.Text = "Add Score"
        '
        'RemoveScoreToolStripMenuItem
        '
        Me.RemoveScoreToolStripMenuItem.Name = "RemoveScoreToolStripMenuItem"
        Me.RemoveScoreToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.RemoveScoreToolStripMenuItem.Text = "Remove Score"
        '
        'ManageScoreToolStripMenuItem
        '
        Me.ManageScoreToolStripMenuItem.Name = "ManageScoreToolStripMenuItem"
        Me.ManageScoreToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ManageScoreToolStripMenuItem.Text = "Manage Score"
        '
        'AvgScoreByCourseToolStripMenuItem
        '
        Me.AvgScoreByCourseToolStripMenuItem.Name = "AvgScoreByCourseToolStripMenuItem"
        Me.AvgScoreByCourseToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.AvgScoreByCourseToolStripMenuItem.Text = "Avg Score By Course"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 410)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents STUDENTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COURSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SCOREToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentsListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StaticsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditDeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageStudentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddCourseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveCourseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditCourseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageCoursesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddScoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveScoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageScoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AvgScoreByCourseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
