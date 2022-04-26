Public Class DeleteCourseForm

    Private Sub ButtonRemoveCourse_Click(sender As Object, e As EventArgs) Handles ButtonRemoveCourse.Click

        Dim course As New COURSE()

        Try
            Dim courseID As Integer = Convert.ToInt32(TextBoxCourseID.Text)

            If MsgBox("Are Yousure You Want To Delete This Course", MsgBoxStyle.YesNo, "Remove Course") = MsgBoxResult.Yes Then

                If course.deleteCourse(courseID) Then
                    MsgBox("Course Deleted", MsgBoxStyle.Information, "Remove Course")
                Else
                    MsgBox("Course Not Deleted", MsgBoxStyle.Information, "Remove Course")
                End If

            End If

        Catch ex As Exception
            MsgBox("Enter A Valid Numeric ID", MsgBoxStyle.Exclamation, "Remove Course")
        End Try

        

    End Sub
End Class