Imports MySql.Data.MySqlClient
Public Class manageScoreForm

    Dim score As New SCORE()
    Dim student As New STUDENT()
    Dim course As New COURSE()
    Dim data As String = "score"

    Private Sub manageScoreForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridViewStudentsScore.DataSource = score.getStudentsScore()
        ComboBoxCourse.DataSource = course.getAllCourses()
        ComboBoxCourse.DisplayMember = "label"
        ComboBoxCourse.ValueMember = "id"

    End Sub

    Private Sub ButtonShowScores_Click(sender As Object, e As EventArgs) Handles ButtonShowScores.Click

        data = "score"
        DataGridViewStudentsScore.DataSource = score.getStudentsScore()

    End Sub

    Private Sub ButtonShowStudents_Click(sender As Object, e As EventArgs) Handles ButtonShowStudents.Click

        data = "student"

        Dim command As New MySqlCommand("SELECT `id`, `first_name`, `last_name`, `birthdate` FROM `student`")
        DataGridViewStudentsScore.DataSource = student.getStudents(command)

    End Sub

    Sub getDataFromDatagridView()

        ' if the user select to show student data
        ' then when he click a datagridview it will only show the student id in the textbox
        If data = "student" Then

            TextBoxStudentID.Text = DataGridViewStudentsScore.CurrentRow.Cells(0).Value.ToString()

            ' if the user select to show student score data
            ' then when he click a datagridview 
            ' it will show the student id in the textbox & the course in the combobox
        ElseIf data = "score" Then

            TextBoxStudentID.Text = DataGridViewStudentsScore.CurrentRow.Cells(0).Value.ToString()
            ComboBoxCourse.SelectedValue = DataGridViewStudentsScore.CurrentRow.Cells(3).Value

        End If

    End Sub

    Private Sub DataGridViewStudentsScore_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewStudentsScore.CellClick

        getDataFromDatagridView()

    End Sub

    Private Sub ButtonRemoveScore_Click(sender As Object, e As EventArgs) Handles ButtonRemoveScore.Click

        Dim studentID As Integer = DataGridViewStudentsScore.CurrentRow.Cells(0).Value
        Dim courseID As Integer = DataGridViewStudentsScore.CurrentRow.Cells(3).Value

        If MsgBox("Do Want To Delete This Score", MsgBoxStyle.YesNo, "Delete Score") = MsgBoxResult.Yes Then

            If score.deleteScore(studentID, courseID) Then
                MsgBox("Score Deleted", MsgBoxStyle.Information, "Delete Score")
                DataGridViewStudentsScore.DataSource = score.getStudentsScore()

            Else
                MsgBox("Score Not Deleted", MsgBoxStyle.Information, "Delete Score")

            End If

        End If

    End Sub

    Private Sub ButtonAddScore_Click(sender As Object, e As EventArgs) Handles ButtonAddScore.Click

        Try

            Dim studentID As Integer = Convert.ToInt32(TextBoxStudentID.Text)
            Dim courseID As Integer = Convert.ToInt32(ComboBoxCourse.SelectedValue)
            Dim scoreValue As Double = Convert.ToDouble(TextBoxScore.Text)
            Dim description As String = TextBoxDescription.Text

            If Not score.studentScoreExist(studentID, courseID) Then

                If score.insertScore(studentID, courseID, scoreValue, description) Then

                    MsgBox("Student Score Inserted", MsgBoxStyle.Information, "Add Score")

                Else

                    MsgBox("Student Score Not Inserted", MsgBoxStyle.Exclamation, "Add Score")

                End If

            Else

                MsgBox("The Score For This Course Are Already Set", MsgBoxStyle.Exclamation, "Add Score")


            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Add Score")

        End Try


    End Sub

    Private Sub ButtonAvgScore_Click(sender As Object, e As EventArgs) Handles ButtonAvgScore.Click

        Dim avgScoreByCourseF As New avgScoreByCourseForm()
        avgScoreByCourseF.Show(Me)

    End Sub
End Class