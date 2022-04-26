Public Class StaticsForm

    Dim panTotalColor As Color
    Dim panMaleColor As Color
    Dim panFemaleColor As Color

    Private Sub StaticsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' get panels color
        panTotalColor = PanelTotal.BackColor
        panMaleColor = PanelMale.BackColor
        panFemaleColor = PanelFemale.BackColor

        ' display the values
        Dim student As New STUDENT()
        Dim total As Integer = Convert.ToInt32(student.totalStudent())
        Dim totalMale As Integer = Convert.ToInt32(student.totalMaleStudent())
        Dim totalFemale As Integer = Convert.ToInt32(student.totalFemaleStudent())

        ' count the %
        ' (total male students X 100) / (total students)
        ' (total female students X 100) / (total students)
        Dim maleStudentsPercentage As Double = totalMale * 100 / total
        Dim femaleStudentsPercentage As Double = totalFemale * 100 / total

        LabelTotal.Text = "Total Students: " & total.ToString()
        LabelMale.Text = "Male : " & maleStudentsPercentage.ToString("0.00") & "%"
        LabelFemale.Text = "Female : " & femaleStudentsPercentage.ToString("0.00") & "%"

    End Sub

    Private Sub LabelTotal_MouseEnter(sender As Object, e As EventArgs) Handles LabelTotal.MouseEnter

        LabelTotal.ForeColor = panTotalColor
        PanelTotal.BackColor = Color.White

    End Sub

    Private Sub LabelTotal_MouseLeave(sender As Object, e As EventArgs) Handles LabelTotal.MouseLeave

        LabelTotal.ForeColor = Color.White
        PanelTotal.BackColor = panTotalColor

    End Sub

    Private Sub LabelMale_MouseEnter(sender As Object, e As EventArgs) Handles LabelMale.MouseEnter

        LabelMale.ForeColor = panMaleColor
        PanelMale.BackColor = Color.White

    End Sub

    Private Sub LabelMale_MouseLeave(sender As Object, e As EventArgs) Handles LabelMale.MouseLeave

        LabelMale.ForeColor = Color.White
        PanelMale.BackColor = panMaleColor

    End Sub

    Private Sub LabelFemale_MouseEnter(sender As Object, e As EventArgs) Handles LabelFemale.MouseEnter

        LabelFemale.ForeColor = panFemaleColor
        PanelFemale.BackColor = Color.White

    End Sub

    Private Sub LabelFemale_MouseLeave(sender As Object, e As EventArgs) Handles LabelFemale.MouseLeave

        LabelFemale.ForeColor = Color.White
        PanelFemale.BackColor = panFemaleColor

    End Sub
End Class