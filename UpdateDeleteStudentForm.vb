Imports System.IO

Public Class UpdateDeleteStudentForm

    Dim student As New STUDENT()
    Private Sub ButtonRemove_Click(sender As Object, e As EventArgs) Handles ButtonRemove.Click

        ' delete student
        Try

            Dim studentId As Integer = Convert.ToInt32(TextBoxID.Text)
            ' display a confirmation message before the delete
            If MsgBox("Are You Sure You Want To Delete This Student", MsgBoxStyle.YesNo, "Delete Student") = MsgBoxResult.Yes Then

                If student.deleteStudent(studentId) Then
                    MsgBox("Student Deleted", MsgBoxStyle.Information, "Delete Student")

                    ' clear fields after delete
                    TextBoxID.Text = ""
                    TextBoxFname.Text = ""
                    TextBoxLname.Text = ""
                    TextBoxAddress.Text = ""
                    TextBoxPhone.Text = ""
                    DateTimePicker1.Value = Date.Now
                    PictureBoxStudentImage.Image = Nothing

                Else
                    MsgBox("Student Not Deleted", MsgBoxStyle.Information, "Delete Student")
                End If

            End If

        Catch ex As Exception

            MsgBox("Please Enter A Valid ID", MsgBoxStyle.Information, "Delete Student")

        End Try



    End Sub

    Private Sub ButtonEditStudent_Click(sender As Object, e As EventArgs) Handles ButtonEditStudent.Click

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

                Else

                    MsgBox("Error", MsgBoxStyle.Critical, "Edit Student")

                End If

            Else

                MsgBox("Empty Fields", MsgBoxStyle.Critical, "Edit Student")

            End If

        End If

    End Sub

    ' create a function to verify data
    Function verif() As Boolean

        If TextBoxID.Text.Trim() = "" Or TextBoxFname.Text.Trim() = "" Or
           TextBoxLname.Text.Trim() = "" Or TextBoxAddress.Text.Trim() = "" Or
           TextBoxPhone.Text.Trim() = "" Or PictureBoxStudentImage.Image Is Nothing Then

            Return False

        Else

            Return True

        End If

    End Function

    Private Sub ButtonUploadImage_Click(sender As Object, e As EventArgs) Handles ButtonUploadImage.Click

        Dim opf As New OpenFileDialog()
        opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

        If opf.ShowDialog() = Windows.Forms.DialogResult.OK Then

            PictureBoxStudentImage.Image = Image.FromFile(opf.FileName)

        End If

    End Sub
End Class