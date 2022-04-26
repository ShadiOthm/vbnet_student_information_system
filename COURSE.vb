Imports MySql.Data.MySqlClient

Public Class COURSE

    Dim db As New MY_DB()
    Public Function insertCourse(ByVal courseName As String, ByVal hoursNumber As Integer, ByVal description As String) As Boolean

        Dim command As New MySqlCommand("INSERT INTO `course`(`label`, `hours_number`, `description`) VALUES (@name,@hrs,@descr)", db.getConnection)
        command.Parameters.Add("@name", MySqlDbType.VarChar).Value = courseName
        command.Parameters.Add("@hrs", MySqlDbType.Int32).Value = hoursNumber
        command.Parameters.Add("@descr", MySqlDbType.VarChar).Value = description

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            Return True
        Else
            Return False
        End If

    End Function


    Public Function updateCourse(ByVal courseID As Integer, ByVal courseName As String, ByVal hoursNumber As Integer, ByVal description As String) As Boolean

        Dim command As New MySqlCommand("UPDATE `course` SET `label`=@name,`hours_number`=@hrs,`description`=@descr WHERE `id` = @cid", db.getConnection)
        command.Parameters.Add("@cid", MySqlDbType.Int32).Value = courseID
        command.Parameters.Add("@name", MySqlDbType.VarChar).Value = courseName
        command.Parameters.Add("@hrs", MySqlDbType.Int32).Value = hoursNumber
        command.Parameters.Add("@descr", MySqlDbType.VarChar).Value = description

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            Return True
        Else
            Return False
        End If

    End Function


    Public Function deleteCourse(ByVal courseID As Integer) As Boolean

        Dim command As New MySqlCommand("DELETE FROM `course` WHERE `id` = @CID", db.getConnection)
        command.Parameters.Add("@CID", MySqlDbType.Int32).Value = courseID

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function checkCourseName(ByVal courseName As String, Optional ByVal courseId As Integer = 0) As Boolean
        ' id <> @cID mean hen the id is diffrent of the current course id
        Dim command As New MySqlCommand("SELECT * FROM course WHERE label=@cName And id <> @cID", db.getConnection)
        command.Parameters.Add("@cName", MySqlDbType.VarChar).Value = courseName
        command.Parameters.Add("@cID", MySqlDbType.Int32).Value = courseId
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        If table.Rows.Count > 0 Then
            ' this course name aleready exists
            Return False
        Else
            Return True
        End If


    End Function

    Public Function getAllCourses() As DataTable

        Dim command As New MySqlCommand("SELECT * FROM course", db.getConnection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        Return table

    End Function


    Public Function getAllCourseById(ByVal courseID As Integer) As DataTable

        Dim command As New MySqlCommand("SELECT * FROM course WHERE id = @cid", db.getConnection)
        command.Parameters.Add("@cid", MySqlDbType.VarChar).Value = courseID
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        Return table

    End Function

    Function execCount(ByVal query As String) As String

        Dim command As New MySqlCommand(query, db.getConnection)

        db.openConnection()
        Return command.ExecuteScalar().ToString()
        db.closeConnection()

    End Function

    ' function to return the total courses in the database
    Function totalCourses() As String

        Return execCount("SELECT COUNT(*) FROM `course`")

    End Function

End Class
