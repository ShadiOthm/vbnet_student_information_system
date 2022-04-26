Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BackgroundImage = Image.FromFile("../../myImages/backg.png")

    End Sub

    Private Sub AddNewStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewStudentToolStripMenuItem.Click

        Dim addStdF As New AddStudentForm()
        addStdF.Show(Me)

    End Sub

    Private Sub StudentsListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentsListToolStripMenuItem.Click

        Dim stdListF As New studentsListForm()
        stdListF.Show(Me)

    End Sub

    Private Sub StaticsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaticsToolStripMenuItem.Click

        Dim stcF As New StaticsForm()
        stcF.Show(Me)

    End Sub

    Private Sub EditDeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditDeleteToolStripMenuItem.Click

        Dim updateDeleteF As New UpdateDeleteStudentForm()
        updateDeleteF.Show(Me)

    End Sub

    Private Sub ManageStudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageStudentsToolStripMenuItem.Click

        Dim manageStudentsF As New ManageStudentsForm()
        manageStudentsF.Show(Me)

    End Sub

    Private Sub AddCourseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddCourseToolStripMenuItem.Click

        Dim addCourseF As New AddCourseForm()
        addCourseF.Show(Me)

    End Sub

    Private Sub RemoveCourseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveCourseToolStripMenuItem.Click

        Dim removeCourseF As New DeleteCourseForm()
        removeCourseF.Show(Me)

    End Sub

    Private Sub EditCourseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditCourseToolStripMenuItem.Click

        Dim editCourseF As New EditCourseForm()
        editCourseF.Show(Me)

    End Sub

    Private Sub ManageCoursesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageCoursesToolStripMenuItem.Click

        Dim manageCourseF As New manageCourseForm()
        manageCourseF.Show(Me)

    End Sub

    Private Sub AddScoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddScoreToolStripMenuItem.Click

        Dim addScoreF As New addScoreForm()
        addScoreF.Show(Me)

    End Sub

    Private Sub RemoveScoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveScoreToolStripMenuItem.Click

        Dim removeScoreF As New removeScoreForm()
        removeScoreF.Show(Me)

    End Sub

    Private Sub ManageScoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageScoreToolStripMenuItem.Click

        Dim manageScoreF As New manageScoreForm()
        manageScoreF.Show(Me)

    End Sub

    Private Sub AvgScoreByCourseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvgScoreByCourseToolStripMenuItem.Click

        Dim avgScoreF As New avgScoreByCourseForm()
        avgScoreF.Show(Me)

    End Sub
End Class