Imports MySql.Data.MySqlClient

Public Class SCORE

    Dim db As New MY_DB()
    Public Function insertScore(ByVal studentID As Integer, ByVal courseID As Integer, ByVal scoreValue As Double, ByVal description As String) As Boolean

        Dim command As New MySqlCommand("INSERT INTO `score`(`student_id`, `course_id`, `student_score`, `description`) VALUES (@sid,@cid,@scr,@descr)", db.getConnection)
        command.Parameters.Add("@sid", MySqlDbType.Int32).Value = studentID
        command.Parameters.Add("@cid", MySqlDbType.Int32).Value = courseID
        command.Parameters.Add("@scr", MySqlDbType.Double).Value = scoreValue
        command.Parameters.Add("@descr", MySqlDbType.VarChar).Value = description

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            Return True
        Else
            Return False
        End If

    End Function

    Function studentScoreExist(ByVal studentId As Integer, ByVal courseID As Integer) As Boolean

        Dim command As New MySqlCommand("SELECT * FROM `score` WHERE `student_id` = @sid AND `course_id` = @cid", db.getConnection)
        command.Parameters.Add("@sid", MySqlDbType.Int32).Value = studentId
        command.Parameters.Add("@cid", MySqlDbType.Int32).Value = courseID

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        If table.Rows.Count = 0 Then

            Return False

        Else

            Return True

        End If


    End Function

    Function getAvgScoreByCourse() As DataTable

        Dim command As New MySqlCommand()
        command.Connection = db.getConnection
        command.CommandText = "SELECT course.label, AVG(score.student_score) as 'Average Score' FROM course, score WHERE course.id = score.course_id GROUP BY course.label"

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        Return table

    End Function


    Function getStudentsScore() As DataTable

        Dim command As New MySqlCommand()
        command.Connection = db.getConnection
        command.CommandText = "SELECT SCORE.student_id, STUDENT.first_name, STUDENT.last_name, SCORE.course_id, COURSE.label, SCORE.student_score " & vbCrLf &
        "FROM STUDENT INNER JOIN score on student.id = score.student_id " & vbCrLf &
        "INNER JOIN course on score.course_id = course.id"

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        Return table

    End Function

    Public Function deleteScore(ByVal studentID As Integer, ByVal courseID As Integer) As Boolean

        Dim command As New MySqlCommand("DELETE FROM `score` WHERE `student_id` = @sid AND course_id = @cid", db.getConnection)
        command.Parameters.Add("@sid", MySqlDbType.Int32).Value = studentID
        command.Parameters.Add("@cid", MySqlDbType.Int32).Value = courseID

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            Return True
        Else
            Return False
        End If

    End Function

End Class
