Public Class manageCourseForm

    Dim course As New COURSE()
    Dim pos As Integer
    Private Sub manageCourseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        reloadListBoxData()

    End Sub

    ' create a sub to modify the listbox data

    Sub reloadListBoxData()

        ListBoxCourses.DataSource = course.getAllCourses()
        ListBoxCourses.ValueMember = "id"
        ListBoxCourses.DisplayMember = "label"
        ' unselect selected listbox item
        ListBoxCourses.SelectedItem = Nothing
        ' display the total course value
        LabelTotalCourses.Text = "Total Courses: " + course.totalCourses()

    End Sub

    Private Sub ListBoxCourses_Click(sender As Object, e As EventArgs) Handles ListBoxCourses.Click

        Dim drv As DataRowView = ListBoxCourses.SelectedItem
        pos = ListBoxCourses.SelectedIndex
        showData(pos)

    End Sub

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
                    reloadListBoxData()
                Else
                    MsgBox("Course Not Inserted", MsgBoxStyle.Information, "Add Course")
                End If

            Else

                MsgBox("This Course Name Already Exists", MsgBoxStyle.Information, "Add Course")

            End If

        End If

        pos = 0

    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click

        Dim name As String = TextBoxCourseName.Text
        Dim hrs As Integer = NumericUpDownHours.Value
        Dim descr As String = TextBoxDescription.Text
        Dim id As Integer = ListBoxCourses.SelectedValue

        If Not course.checkCourseName(name, Convert.ToInt32(ListBoxCourses.SelectedValue)) Then

            MsgBox("This Course Name Already Exist", MsgBoxStyle.Exclamation, "Edit Course")

        Else

            If course.updateCourse(id, name, hrs, descr) Then

                MsgBox("Course Updated", MsgBoxStyle.Information, "Edit Course")
                reloadListBoxData()
            Else

                MsgBox("Course Not Updated", MsgBoxStyle.Information, "Edit Course")

            End If

        End If

        pos = 0

    End Sub

    Private Sub ButtonRemove_Click(sender As Object, e As EventArgs) Handles ButtonRemove.Click

        ' we can use the TextBoxCourseID or ListBoxCourse

        Dim course As New COURSE()

        Try
            Dim courseID As Integer = Convert.ToInt32(ListBoxCourses.SelectedValue)

            If MsgBox("Are You sure You Want To Delete This Course With All The Scores Related To It", MsgBoxStyle.YesNo, "Remove Course") = MsgBoxResult.Yes Then

                If course.deleteCourse(courseID) Then
                    MsgBox("Course Deleted", MsgBoxStyle.Information, "Remove Course")

                    ' clear fields
                    TextBoxID.Text = ""
                    TextBoxCourseName.Text = ""
                    NumericUpDownHours.Value = 10
                    TextBoxDescription.Text = ""

                    reloadListBoxData()
                Else
                    MsgBox("Course Not Deleted", MsgBoxStyle.Information, "Remove Course")
                End If

            End If

        Catch ex As Exception
            MsgBox("Enter A Valid Numeric ID", MsgBoxStyle.Exclamation, "Remove Course")
        End Try

        pos = 0

    End Sub

    Private Sub ButtonFirst_Click(sender As Object, e As EventArgs) Handles ButtonFirst.Click

        pos = 0
        showData(pos)

    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click

        If pos < course.getAllCourses().Rows.Count - 1 Then

            pos = pos + 1
            showData(pos)

        End If
        

    End Sub

    Private Sub ButtonPrevious_Click(sender As Object, e As EventArgs) Handles ButtonPrevious.Click

        If pos > 0 Then

            pos = pos - 1
            showData(pos)

        End If

    End Sub

    Private Sub ButtonLast_Click(sender As Object, e As EventArgs) Handles ButtonLast.Click

        pos = course.getAllCourses().Rows.Count - 1
        showData(pos)

    End Sub

    ' sub to show data depending in the index
    Sub showData(ByVal index As Integer)

        Dim dr As DataRow = course.getAllCourses().Rows(index)
        ListBoxCourses.SelectedIndex = index
        TextBoxID.Text = dr.Item(0).ToString()
        TextBoxCourseName.Text = dr.Item(1).ToString()
        NumericUpDownHours.Value = dr.Item(2)
        TextBoxDescription.Text = dr.Item(3).ToString()

    End Sub

End Class