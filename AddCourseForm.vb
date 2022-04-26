Public Class AddCourseForm

    Private Sub ButtonAddCourse_Click(sender As Object, e As EventArgs) Handles ButtonAddCourse.Click
        'check if the name is not empty
        'check if this course already exists
        'the course hours number must be > 10
        'we can do it from the numericDropDown Tool
        'or by using the if condition
        'the description is optional
        Dim name As String = TextBoxCourseName.Text
        Dim hrs As Integer = NumericUpDownHours.Value
        Dim descr As String = TextBoxDescription.Text

        Dim course As New COURSE()
        If name.Trim() = "" Then
            MsgBox("Add A Course Name", MsgBoxStyle.Information, "Add Course")
        Else
            If course.checkCourseName(name, Nothing) Then

                If course.insertCourse(name, hrs, descr) Then

                    MsgBox("New Course Inserted", MsgBoxStyle.Information, "Add Course")
                Else
                    MsgBox("Course Not Inserted", MsgBoxStyle.Information, "Add Course")
                End If

            Else

                MsgBox("This Course Name Already Exists", MsgBoxStyle.Information, "Add Course")

            End If
            
        End If
        

    End Sub

End Class