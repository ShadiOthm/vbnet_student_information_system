Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Drawing.Imaging

Public Class ManageStudentsForm

    Dim student As New STUDENT()

    Private Sub ManageStudentsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim command As New MySqlCommand("SELECT * FROM `student`")
        fillGrid(command)

    End Sub

    ' sub to fill the datagridview
    Sub fillGrid(ByVal command As MySqlCommand)

        DataGridView1.ReadOnly = True

        Dim picCol As New DataGridViewImageColumn()

        DataGridView1.RowTemplate.Height = 80

        DataGridView1.DataSource = student.getStudents(command)

        picCol = DataGridView1.Columns(7)

        picCol.ImageLayout = DataGridViewImageCellLayout.Stretch

        DataGridView1.AllowUserToAddRows = False

        ' display student count using datagridview
        LabelTotalStudents.Text = "Total Students: " & DataGridView1.Rows.Count

    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click


        TextBoxID.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        TextBoxFname.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        TextBoxLname.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        DateTimePicker1.Value = DataGridView1.CurrentRow.Cells(3).Value
        ' gender
        If DataGridView1.CurrentRow.Cells(4).Value.ToString() = "Female" Then
            RadioButtonFemale.Checked = True
        Else
            RadioButtonMale.Checked = True
        End If
        TextBoxPhone.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        TextBoxAddress.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()

        ' display the image from datagridview to picturebox
        Dim pic As Byte()
        pic = DataGridView1.CurrentRow.Cells(7).Value
        Dim picture As New MemoryStream(pic)
        PictureBoxStudentImage.Image = Image.FromStream(picture)


    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click

        Dim command As New MySqlCommand("SELECT * FROM `student` WHERE CONCAT(`first_name`,`last_name`,`address`)LIKE'%" & TextBoxSearch.Text & "%'")
        fillGrid(command)

    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged

        Dim command As New MySqlCommand("SELECT * FROM `student` WHERE CONCAT(`first_name`,`last_name`,`address`)LIKE'%" & TextBoxSearch.Text & "%'")
        fillGrid(command)

    End Sub

    Private Sub ButtonUpload_Click(sender As Object, e As EventArgs) Handles ButtonUpload.Click

        Dim opf As New OpenFileDialog()
        opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

        If opf.ShowDialog() = Windows.Forms.DialogResult.OK Then

            PictureBoxStudentImage.Image = Image.FromFile(opf.FileName)

        End If

    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click

        TextBoxID.Text = ""
        TextBoxFname.Text = ""
        TextBoxLname.Text = ""
        TextBoxAddress.Text = ""
        TextBoxPhone.Text = ""
        PictureBoxStudentImage.Image = Nothing
        RadioButtonMale.Checked = True
        DateTimePicker1.Value = Date.Now

    End Sub

    Private Sub ButtonDownload_Click(sender As Object, e As EventArgs) Handles ButtonDownload.Click

        Dim svf As New SaveFileDialog()

        svf.FileName = "student_" & TextBoxID.Text

        If PictureBoxStudentImage.Image Is Nothing Then

            MsgBox("No Image In The PictureBox")

        Else

            If svf.ShowDialog() = Windows.Forms.DialogResult.OK Then

                PictureBoxStudentImage.Image.Save(svf.FileName & "." & ImageFormat.Jpeg.ToString())

            End If

        End If

        

    End Sub

    Function verif() As Boolean

        If TextBoxFname.Text.Trim() = "" Or TextBoxLname.Text.Trim() = "" Or
           TextBoxAddress.Text.Trim() = "" Or TextBoxPhone.Text.Trim() = "" Or
           PictureBoxStudentImage.Image Is Nothing Then

            Return False

        Else

            Return True

        End If

    End Function

    Private Sub ButtonAddStudent_Click(sender As Object, e As EventArgs) Handles ButtonAddStudent.Click

        Dim student As New STUDENT()
        Dim fname As String = TextBoxFname.Text
        Dim lname As String = TextBoxLname.Text
        Dim bdate As Date = DateTimePicker1.Value
        Dim phone As String = TextBoxPhone.Text
        Dim adrs As String = TextBoxAddress.Text

        Dim gender As String = "Male"

        If RadioButtonFemale.Checked Then
            gender = "Female"
        End If

        Dim pic As New MemoryStream

        ' check if birthdate is to heigh or to low
        Dim born_year As Integer = DateTimePicker1.Value.Year
        Dim this_year As Integer = Date.Now.Year

        ' allow only students age between 10 - 100
        If this_year - born_year < 10 Or this_year - born_year > 100 Then

            MsgBox("The Student Age Must Be Between 10 and 100 year", MsgBoxStyle.Information, "Birth Date Error")

        Else

            If verif() Then

                PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat)

                If student.insertStudent(fname, lname, bdate, gender, phone, adrs, pic) Then

                    MsgBox("New Student Added", MsgBoxStyle.Information, "Add Student")
                    Dim command As New MySqlCommand("SELECT * FROM `student`")
                    fillGrid(command)
                Else

                    MsgBox("Error", MsgBoxStyle.Critical, "Add Student")

                End If

            Else

                MsgBox("Empty Fields", MsgBoxStyle.Critical, "Add Student")

            End If

        End If


    End Sub



    Private Sub ButtonRemove_Click(sender As Object, e As EventArgs) Handles ButtonRemove.Click

        ' we need to show a message that this user have scores in the table
        ' score
        ' and if the user want to continue the delete 
        ' we have to also delete the scores
        ' to do that we will add a FOEIGN KEY with ON DELETE CASCADE
        ' ON DELETE CASCADE mean when we delete the parent element the child will also be deleted
        ' we need to remove the previous data so we can add it
        ' delete student
        ' the same for course table


        Try

            Dim studentId As Integer = Convert.ToInt32(TextBoxID.Text)
            ' display a confirmation message before the delete
            If MsgBox("Are You Sure You Want To Delete This Student With All His Scores", MsgBoxStyle.YesNo, "Delete Student") = MsgBoxResult.Yes Then

                If student.deleteStudent(studentId) Then
                    MsgBox("Student Deleted", MsgBoxStyle.Information, "Delete Student")
                    Dim command As New MySqlCommand("SELECT * FROM `student`")
                    fillGrid(command)

                    ' clear fields after delete
                    ButtonReset.PerformClick()

                Else
                    MsgBox("Student Not Deleted", MsgBoxStyle.Information, "Delete Student")
                End If

            End If

        Catch ex As Exception

            MsgBox("Please Enter A Valid ID", MsgBoxStyle.Information, "Delete Student")

        End Try


    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click

        Dim id As Integer
        Dim fname As String = TextBoxFname.Text
        Dim lname As String = TextBoxLname.Text
        Dim bdate As Date = DateTimePicker1.Value
        Dim phone As String = TextBoxPhone.Text
        Dim adrs As String = TextBoxAddress.Text

        Dim gender As String = "Male"

        If RadioButtonFemale.Checked Then
            gender = "Female"
        End If

        Dim pic As New MemoryStream

        ' check if birthdate is to heigh or to low
        Dim born_year As Integer = DateTimePicker1.Value.Year
        Dim this_year As Integer = Date.Now.Year

        ' allow only students age between 10 - 100
        If this_year - born_year < 10 Or this_year - born_year > 100 Then

            MsgBox("The Student Age Must Be Between 10 and 100 year", MsgBoxStyle.Information, "Birth Date Error")

        Else

            If verif() Then
                Try
                    id = Convert.ToInt32(TextBoxID.Text)
                Catch ex As Exception
                    MsgBox("Please Enter A Valid Numeric Id", MsgBoxStyle.Exclamation, "Edit Student")
                End Try

                PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat)

                If student.updateStudent(id, fname, lname, bdate, gender, phone, adrs, pic) Then

                    MsgBox("Student Information Updated", MsgBoxStyle.Information, "Edit Student")
                    Dim command As New MySqlCommand("SELECT * FROM `student`")
                    fillGrid(command)

                Else

                    MsgBox("Error", MsgBoxStyle.Critical, "Edit Student")

                End If

            Else

                MsgBox("Empty Fields", MsgBoxStyle.Critical, "Edit Student")

            End If

        End If

    End Sub
End Class