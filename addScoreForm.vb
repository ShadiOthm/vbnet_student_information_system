Imports MySql.Data.MySqlClient

Public Class addScoreForm

    Dim score As New SCORE()
    Dim course As New COURSE()
    Dim student As New STUDENT()

    Private Sub ButtonAddScore_Click(sender As Object, e As EventArgs) Handles ButtonAddScore.Click

        ' fix to do:
        ' the exceptions
        ' this student dosen't exist on the database
        ' we have to select from the students that exists on the database
        ' done
        ' Not allow the user to add a score to a student in the same course 2 time
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

    Private Sub addScoreForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBoxCourse.DataSource = course.getAllCourses()
        ComboBoxCourse.DisplayMember = "label"
        ComboBoxCourse.ValueMember = "id"

        Dim command As New MySqlCommand("SELECT `id`, `first_name`, `last_name` FROM `student`")
        DataGridViewStudents.DataSource = student.getStudents(command)

    End Sub

    Private Sub DataGridViewStudents_Click(sender As Object, e As EventArgs) Handles DataGridViewStudents.Click

        TextBoxStudentID.Text = DataGridViewStudents.CurrentRow.Cells(0).Value.ToString()

    End Sub
End Class