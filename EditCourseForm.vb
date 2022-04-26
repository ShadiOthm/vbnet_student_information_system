Public Class EditCourseForm

    Dim course As New COURSE()

    Private Sub EditCourseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' display courses on the combobox

        ComboBoxCourse.DataSource = course.getAllCourses()
        ComboBoxCourse.DisplayMember = "label"
        ComboBoxCourse.ValueMember = "id"

        ' set the selected combo item to nothing
        ComboBoxCourse.SelectedItem = Nothing

    End Sub

    Sub fillCombo(ByVal index As Integer)

        ' reload data into the combobox
        '  and display the current course
        ' index is the selected combo item index
        ComboBoxCourse.DataSource = course.getAllCourses()
        ComboBoxCourse.DisplayMember = "label"
        ComboBoxCourse.ValueMember = "id"

        ' set the selected combo item to nothing
        ComboBoxCourse.SelectedIndex = index

    End Sub

    Private Sub ComboBoxCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCourse.SelectedIndexChanged
        Try
            ' display the selected course from the combobox data 
            Dim id As Integer = Convert.ToInt32(ComboBoxCourse.SelectedValue)
            Dim table As New DataTable()
            table = course.getAllCourseById(id)
            TextBoxCourseName.Text = table.Rows(0)(1)
            NumericUpDownHours.Value = table.Rows(0)(2)
            TextBoxDescription.Text = table.Rows(0)(3)
        Catch ex As Exception

        End Try
        

    End Sub

    Private Sub ButtonEditCourse_Click(sender As Object, e As EventArgs) Handles ButtonEditCourse.Click

        ' fix to do:
        ' if we try to edit a course without changing the name
        ' the message of 'course name already exist' will popup
        ' to fix that we need to add a new parameter to our function checkCourseName(name)
        ' the new parameter is the id of the course

        Dim name As String = TextBoxCourseName.Text
        Dim hrs As Integer = NumericUpDownHours.Value
        Dim descr As String = TextBoxDescription.Text
        Dim id As Integer = ComboBoxCourse.SelectedValue

        If Not course.checkCourseName(name, Convert.ToInt32(ComboBoxCourse.SelectedValue)) Then

            MsgBox("This Course Name Already Exist", MsgBoxStyle.Exclamation, "Edit Course")

        Else

            If course.updateCourse(id, name, hrs, descr) Then

                MsgBox("Course Updated", MsgBoxStyle.Information, "Edit Course")
                fillCombo(ComboBoxCourse.SelectedIndex)
            Else

                MsgBox("Course Not Updated", MsgBoxStyle.Information, "Edit Course")

            End If

        End If


    End Sub
End Class