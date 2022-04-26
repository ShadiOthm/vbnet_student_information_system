Imports System.IO

Public Class AddStudentForm

    Private Sub TextBoxPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPhone.KeyPress

        ' allo only numbers on this textbox
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then

            e.Handled = True

        End If

    End Sub

    Private Sub ButtonUploadImage_Click(sender As Object, e As EventArgs) Handles ButtonUploadImage.Click

        Dim opf As New OpenFileDialog()
        opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

        If opf.ShowDialog() = Windows.Forms.DialogResult.OK Then

            PictureBoxStudentImage.Image = Image.FromFile(opf.FileName)

        End If

    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click

        Close()

    End Sub

    Private Sub ButtonAddStudent_Click(sender As Object, e As EventArgs) Handles ButtonAddStudent.Click

        ' add a gender column to the database

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

                Else

                    MsgBox("Error", MsgBoxStyle.Critical, "Add Student")

                End If

            Else

                MsgBox("Empty Fields", MsgBoxStyle.Critical, "Add Student")

            End If

        End If


    End Sub

    ' create a function to verify data
    Function verif() As Boolean

        If TextBoxFname.Text.Trim() = "" Or TextBoxLname.Text.Trim() = "" Or
           TextBoxAddress.Text.Trim() = "" Or TextBoxPhone.Text.Trim() = "" Or
           PictureBoxStudentImage.Image Is Nothing Then

            Return False

        Else

            Return True

        End If

    End Function

End Class