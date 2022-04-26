Imports System.IO
Imports MySql.Data.MySqlClient

Public Class studentsListForm

    Dim student As New STUDENT()
    Private Sub studentsListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim command As New MySqlCommand("SELECT * FROM `student`")

        DataGridView1.ReadOnly = True

        Dim picCol As New DataGridViewImageColumn()

        DataGridView1.RowTemplate.Height = 80

        DataGridView1.DataSource = student.getStudents(command)

        picCol = DataGridView1.Columns(7)

        picCol.ImageLayout = DataGridViewImageCellLayout.Stretch

        DataGridView1.AllowUserToAddRows = False



    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick

        ' display the selected row data into update delete student form on double click

        Dim updateDeletStdF As New UpdateDeleteStudentForm()
        ' DATA ORDER -> id - fn - ln - bd - gdr - phn - adrs - pic
        updateDeletStdF.TextBoxID.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        updateDeletStdF.TextBoxFname.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        updateDeletStdF.TextBoxLname.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        updateDeletStdF.DateTimePicker1.Value = DataGridView1.CurrentRow.Cells(3).Value
        ' gender
        If DataGridView1.CurrentRow.Cells(4).Value.ToString() = "Female" Then
            updateDeletStdF.RadioButtonFemale.Checked = True
        End If
        updateDeletStdF.TextBoxPhone.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        updateDeletStdF.TextBoxAddress.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()

        ' display the image from datagridview to picturebox
        Dim pic As Byte()
        pic = DataGridView1.CurrentRow.Cells(7).Value
        Dim picture As New MemoryStream(pic)
        updateDeletStdF.PictureBoxStudentImage.Image = Image.FromStream(picture)

        updateDeletStdF.Show()

    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click

        Dim command As New MySqlCommand("SELECT * FROM `student`")

        DataGridView1.ReadOnly = True

        Dim picCol As New DataGridViewImageColumn()

        DataGridView1.RowTemplate.Height = 80

        DataGridView1.DataSource = student.getStudents(command)

        picCol = DataGridView1.Columns(7)

        picCol.ImageLayout = DataGridViewImageCellLayout.Stretch

        DataGridView1.AllowUserToAddRows = False


    End Sub
End Class