Imports MySql.Data.MySqlClient
Imports System.IO

Public Class STUDENT

    Dim db As New MY_DB()

    ' function to insert a new student
    Public Function insertStudent(ByVal fname As String, ByVal lname As String, ByVal bdate As Date, ByVal gender As String, ByVal phone As String, ByVal address As String, ByVal picture As MemoryStream) As Boolean

        Dim command As New MySqlCommand("INSERT INTO `student`(`first_name`, `last_name`, `birthdate`,`gender`, `phone`, `address`, `picture`) VALUES (@fn, @ln, @bdt, @gdr, @phn, @adrs, @pic)", db.getConnection)
        ' @fn, @ln, @bdt, @phn, @adrs, @pic
        command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname
        command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname
        command.Parameters.Add("@bdt", MySqlDbType.DateTime).Value = bdate
        command.Parameters.Add("@gdr", MySqlDbType.VarChar).Value = gender
        command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone
        command.Parameters.Add("@adrs", MySqlDbType.VarChar).Value = address
        command.Parameters.Add("@pic", MySqlDbType.Blob).Value = picture.ToArray()

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True

        Else

            Return False

        End If

        db.closeConnection()

    End Function

    ' function to get all students from database
    Public Function getStudents(ByVal command As MySqlCommand) As DataTable

        command.Connection = db.getConnection

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        Return table

    End Function


    Public Function deleteStudent(ByVal id As Integer) As Boolean

        Dim command As New MySqlCommand("DELETE FROM `student` WHERE `id` = @studentID", db.getConnection)

        command.Parameters.Add("@studentID", MySqlDbType.Int32).Value = id

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True

        Else

            Return False

        End If

        db.closeConnection()


    End Function


    ' function to update a student information
    Public Function updateStudent(ByVal id As Integer, ByVal fname As String, ByVal lname As String, ByVal bdate As Date, ByVal gender As String, ByVal phone As String, ByVal address As String, ByVal picture As MemoryStream) As Boolean

        Dim command As New MySqlCommand("UPDATE `student` SET `first_name`=@fn,`last_name`=@ln,`birthdate`=@bdt,`gender`=@gdr,`phone`=@phn,`address`=@adrs,`picture`=@pic WHERE id=@ID", db.getConnection)
        ' @fn, @ln, @bdt, @phn, @adrs, @pic
        command.Parameters.Add("@ID", MySqlDbType.Int32).Value = id
        command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname
        command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname
        command.Parameters.Add("@bdt", MySqlDbType.DateTime).Value = bdate
        command.Parameters.Add("@gdr", MySqlDbType.VarChar).Value = gender
        command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone
        command.Parameters.Add("@adrs", MySqlDbType.VarChar).Value = address
        command.Parameters.Add("@pic", MySqlDbType.Blob).Value = picture.ToArray()

        db.openConnection()

        If command.ExecuteNonQuery() = 1 Then

            Return True

        Else

            Return False

        End If

        db.closeConnection()

    End Function

    ' function to execute count query
    Function execCount(ByVal query As String) As String

        Dim command As New MySqlCommand(query, db.getConnection)

        db.openConnection()
        Return command.ExecuteScalar().ToString()
        db.closeConnection()

    End Function

    ' function to return the total students in the database
    Function totalStudent() As String

        Return execCount("SELECT COUNT(*) FROM `student`")

    End Function

    ' function to return the total Male students in the database
    Function totalMaleStudent() As String

        Return execCount("SELECT COUNT(*) FROM `student` WHERE `gender` = 'Male'")

    End Function

    ' function to return the total Female students in the database
    Function totalFemaleStudent() As String

        Return execCount("SELECT COUNT(*) FROM `student` WHERE `gender` = 'Female'")

    End Function


End Class
